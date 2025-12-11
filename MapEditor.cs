
using System;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MapEditor : MonoBehaviour
{
  private string editing = "";
  internal List<GameObject> _layerUI = new List<GameObject>();
  internal Vector3[] lr_texture_positions = new Vector3[360];
  internal int grass_offset = 6;
  public MapEnum selectedMap = MapEnum.Grassy_Hills;
  public int mapSizeX = 1800;
  public int mapSizeY = 900;
  public List<ZMap> layers = new List<ZMap>();
  public ZGame game = new ZGame();
  public int brushSize = 10;
  public byte textureAlpha = byte.MaxValue;
  public Vector2 lastMousePos = Vector2.zero;
  public float desiredPixelWidth = 2f;
  private Stack<MapEditor.IUndoOperation> stack_undo = new Stack<MapEditor.IUndoOperation>();
  private Stack<MapEditor.IUndoOperation> stack_redo = new Stack<MapEditor.IUndoOperation>();
  public static MapEditor Instance;
  public const int Version = 1;
  [Header("UI")]
  public List<GameObject> toolGraphics;
  public List<UIOnHover> toolButtons;
  public TMP_Text txt_editing;
  public TMP_Text txt_undo;
  public TMP_Text txt_redo;
  public UIOnHover but_undo;
  public UIOnHover but_redo;
  public TMP_InputField input_tex_brushSize;
  public TMP_Dropdown drop_texShape;
  public LineRenderer lineRenderer;
  public TMP_InputField input_objectRot;
  public TMP_InputField input_objectScale;
  public TMP_InputField input_objectHue;
  public Toggle toggle_objectFlipX;
  public Toggle toggle_objectBehind;
  public SpriteRenderer sr_object;
  public LineRenderer lr_texture;
  public UIOnHover but_layerAdd;
  public UIOnHover but_layerRemove;
  public UIOnHover but_layerMoveUp;
  public UIOnHover but_layerMoveDown;
  public UIOnHover pfabLayer;
  [Header("Object Buttons")]
  public Slider slider_objectRot;
  public Slider slider_objectScale;
  public Slider slider_objectHue;
  public Image img_objectColor;
  [Header("Texture Buttons")]
  public Image texture_preview;
  public TMP_InputField input_textureHue;
  public Slider slider_textureHue;
  public Toggle toggle_textureIgnoreExisting;
  public Image img_textureColor;
  internal bool softLock;
  [Header("Internal")]
  public MapEditor.Tool selectedTool;
  public int selectedObject;
  public ZMap selectedLayer;
  public bool isDragging;
  public Texture2D _texPrivate;
  public Texture2D _grass;
  public Texture2D _underbelly;
  public HashSet<Point> selectedPixels;
  public MapEditor.BoxSelection boxSelection;
  internal Camera cam;
  private Stack<MapEditor.IUndoOperation> stack_multiple;
  internal MapEditor.UndoPixels curPixelStack;

  public int selectedLayerIndex
  {
    get
    {
      return this.layers.FindIndex((Predicate<ZMap>) (z => z == this.selectedLayer));
    }
  }

  internal static float getObjectRot
  {
    get
    {
      return MapEditor.Instance.input_objectRot.text.ToFloat(0.0f);
    }
  }

  internal static float getObjectScale
  {
    get
    {
      return MapEditor.Instance.input_objectScale.text.ToFloat(0.0f);
    }
  }

  internal static bool getObjectFlipX
  {
    get
    {
      return MapEditor.Instance.toggle_objectFlipX.isOn;
    }
  }

  internal static bool getObjectBehind
  {
    get
    {
      return MapEditor.Instance.toggle_objectBehind.isOn;
    }
  }

  internal static float getObjectHue
  {
    get
    {
      return MapEditor.Instance.input_objectHue.text.ToFloat(0.0f);
    }
  }

  internal static Color32 getTextureColor
  {
    get
    {
      return (Color32) MapEditor.Instance.img_textureColor.color;
    }
  }

  internal static Color32 getObjectColor
  {
    get
    {
      return (Color32) MapEditor.Instance.img_objectColor.color;
    }
  }

  internal static bool getTextureIgnoreExisting
  {
    get
    {
      return MapEditor.Instance.toggle_textureIgnoreExisting.isOn;
    }
  }

  internal static float getTextureHue
  {
    get
    {
      return MapEditor.Instance.input_textureHue.text.ToFloat(0.0f);
    }
  }

  public Texture2D _tex
  {
    get
    {
      return this._texPrivate;
    }
    set
    {
      this.DestroyTex();
      this._texPrivate = value;
    }
  }

  private void Awake()
  {
    MapEditor.Instance = this;
    this.cam = Camera.main;
    this.game.gameFacts = new GameFacts();
    this.game.isClient = true;
    this.game.isServer = true;
    Client.game = this.game;
    this._tex = Inert.Instance.classMaps.mapGroups[0].bgTexture;
    this.OnToolChange(MapEditor.Tool.TexturePainter);
    Controller.Instance.InitMap(false, false, false);
    this.NewMap();
  }

  private void OnDestroy()
  {
    if ((UnityEngine.Object) MapEditor.Instance == (UnityEngine.Object) this)
      MapEditor.Instance = (MapEditor) null;
    this.CleanUp();
  }

  public void RebuildLayerUI()
  {
    foreach (UnityEngine.Object @object in this._layerUI)
      UnityEngine.Object.Destroy(@object);
    this._layerUI.Clear();
    int selectedLayerIndex = this.selectedLayerIndex;
    for (int index = 0; index < this.layers.Count; ++index)
    {
      int ii = index;
      ZMap c = this.layers[index];
      UIOnHover g = UnityEngine.Object.Instantiate<UIOnHover>(this.pfabLayer, this.pfabLayer.transform.parent);
      g.onClick.AddListener((UnityAction) (() =>
      {
        this._layerUI[this.selectedLayerIndex].GetComponent<UIOnHover>().AlwaysOn = false;
        this.selectedLayer = c;
        g.AlwaysOn = true;
        this.RefreshUI();
      }));
      g.onRightClick.AddListener((UnityAction) (() =>
      {
        MyContextMenu myContextMenu = MyContextMenu.Show();
        myContextMenu.AddInput((Action<string>) (s =>
        {
          this.stack_undo.Push((MapEditor.IUndoOperation) new MapEditor.UndoLayerName(ii, c.name));
          c.name = s;
          g.transform.GetChild(0).GetComponent<TMP_Text>().text = s;
          this.RefreshUI();
        }), g.transform.GetChild(0).GetComponent<TMP_Text>().text, false, true);
        myContextMenu.Rebuild(false);
      }));
      g.transform.GetChild(0).GetComponent<TMP_Text>().text = c.name;
      this._layerUI.Add(g.gameObject);
      g.gameObject.SetActive(true);
      if (index == selectedLayerIndex)
        g.AlwaysOn = true;
    }
  }

  internal void OnToolChange(MapEditor.Tool t)
  {
    this.selectedTool = t;
    for (int index = 0; index < this.toolGraphics.Count; ++index)
    {
      if ((UnityEngine.Object) this.toolGraphics[index] != (UnityEngine.Object) null)
        this.toolGraphics[index].SetActive((MapEditor.Tool) index == t);
    }
    for (int index = 0; index < this.toolButtons.Count; ++index)
    {
      if ((UnityEngine.Object) this.toolButtons[index] != (UnityEngine.Object) null)
        this.toolButtons[index].AlwaysOn = (MapEditor.Tool) index == t;
    }
    this.RefreshToolGraphic();
    switch (t)
    {
      case MapEditor.Tool.TexturePainter:
        if (this.texture_preview.gameObject.CompareTag("RawImage"))
          UnityEngine.Object.Destroy((UnityEngine.Object) this.texture_preview.sprite);
        this.texture_preview.sprite = Sprite.Create(this._tex, new Rect(0.0f, 0.0f, (float) this._tex.width, (float) this._tex.height), new Vector2(0.5f, 0.5f));
        this.texture_preview.gameObject.tag = "RawImage";
        break;
      case MapEditor.Tool.ObjectPlacer:
        if (this.sr_object.gameObject.CompareTag("RawImage"))
          UnityEngine.Object.Destroy((UnityEngine.Object) this.sr_object.sprite);
        this.sr_object.transform.SetParent(MapObjects.Instance.transform);
        float num = Mathf.Clamp(this.input_objectScale.text.ToFloat(1f), 0.1f, 10f) * 100f;
        this.sr_object.transform.localScale = new Vector3(num, num, 1f);
        this.sr_object.sprite = Sprite.Create(this._tex, new Rect(0.0f, 0.0f, (float) this._tex.width, (float) this._tex.height), new Vector2(0.5f, 0.0f));
        this.sr_object.gameObject.tag = "RawImage";
        break;
    }
  }

  public void OnToggleObjectFlipX(bool v)
  {
    this.sr_object.flipX = v;
  }

  public void OnToggleObjectBehind(bool v)
  {
  }

  public void OnSliderObjectRot(float s)
  {
    this.sr_object.transform.localEulerAngles = new Vector3(0.0f, 0.0f, -s);
    this.input_objectRot.SetTextWithoutNotify(s.ToString());
  }

  public void OnSliderObjectScale(float s)
  {
    float num = Mathf.Clamp(s, 0.1f, 10f) * 100f;
    this.sr_object.transform.localScale = new Vector3(num, num, 1f);
    this.input_objectScale.SetTextWithoutNotify(s.ToString());
  }

  public void OnSliderObjectHue(float s)
  {
    this.sr_object.color = new Color(Mathf.Clamp(s, 0.0f, 1f), 1f, 1f, 0.5f);
    this.input_objectHue.SetTextWithoutNotify(s.ToString());
  }

  public void OnSliderTextureHue(float s)
  {
    this.texture_preview.color = new Color(Mathf.Clamp(s, 0.0f, 1f), 1f, 1f);
    this.input_textureHue.SetTextWithoutNotify(s.ToString());
  }

  public void OnEditObjectRot(string s)
  {
    float input = s.ToFloat(0.0f);
    while ((double) input > 180.0)
      input -= 180f;
    while ((double) input < -180.0)
      input += 180f;
    this.sr_object.transform.localEulerAngles = new Vector3(0.0f, 0.0f, -input);
    this.slider_objectRot.SetValueWithoutNotify(input);
    this.input_objectRot.SetTextWithoutNotify(input.ToString());
  }

  public void OnEditObjectScale(string s)
  {
    float num = Mathf.Clamp(s.ToFloat(0.0f), 0.1f, 10f) * 100f;
    this.sr_object.transform.localScale = new Vector3(num, num, 1f);
    this.slider_objectScale.SetValueWithoutNotify(s.ToFloat(0.0f));
  }

  public void OnEditObjectHue(string s)
  {
    float r = Mathf.Clamp(s.ToFloat(0.0f), 0.0f, 1f);
    this.sr_object.color = new Color(r, 1f, 1f, 0.5f);
    this.slider_objectHue.SetValueWithoutNotify(s.ToFloat(0.0f));
    this.input_objectHue.SetTextWithoutNotify(r.ToString());
  }

  public void OnEditTextureHue(string s)
  {
    float r = Mathf.Clamp(s.ToFloat(0.0f), 0.0f, 1f);
    this.texture_preview.color = new Color(r, 1f, 1f);
    this.slider_textureHue.SetValueWithoutNotify(s.ToFloat(0.0f));
    this.input_textureHue.SetTextWithoutNotify(r.ToString());
  }

  public void OnEditTextureBrushSize(string s)
  {
    this.brushSize = Mathf.Clamp(s.ToInt(0), 1, 2048);
    this.input_tex_brushSize.SetTextWithoutNotify(this.brushSize.ToString());
  }

  public void MenuStrip_BoxSelection()
  {
    this.OnToolChange(MapEditor.Tool.BoxSelect);
  }

  public void MenuStrip_File()
  {
    MyContextMenu myContextMenu = MyContextMenu.Show();
    myContextMenu.AddSeperator("File");
    myContextMenu.AddSeperator("--------------------------");
    myContextMenu.AddItem("New", (Action) (() => this.SubMenu_New()), MyContextMenu.ColorGreen);
    myContextMenu.AddItem("Open Arcpng", (Action) (() => MyFilePicker.Create("Open Arc Map", "CustomMaps", ".arcpng", false, new Action<string>(this._open), ContentType.ArcMap, false)), MyContextMenu.ColorGreen);
    myContextMenu.AddItem("Open png", (Action) (() => MyFilePicker.Create("Open png", "CustomMaps", ".png", false, new Action<string>(this._open), ContentType.ArcMap, false)), MyContextMenu.ColorGreen);
    myContextMenu.AddItem("Save Arcpng", (Action) (() => MyFilePicker.Create("Save Arc Map", "CustomMaps", ".arcpng", true, (Action<string>) (s => this._save(s, ".arcpng")), ContentType.ArcMap, false)), MyContextMenu.ColorGreen);
    myContextMenu.AddItem("Save png", (Action) (() => MyFilePicker.Create("Save png", "CustomMaps", ".png", true, (Action<string>) (s => this._save(s, ".png")), ContentType.ArcMap, false)), MyContextMenu.ColorGreen);
    myContextMenu.AddSeperator("--------------------------");
    myContextMenu.AddItem("Quit", (Action) (() =>
    {
      if (this.stack_undo.Count > 0 || this.stack_redo.Count > 0)
        MyMessageBox.Create("Are you sure you want to quit?", (Action) (() => Controller.Instance.OpenMenu(Controller.Instance.MenuTutorialCodeEditor, false)), "Ok", "Cancel", (Action) null, (Action) null, (Sprite) null, (string) null, (Action) null);
      else
        Controller.Instance.OpenMenu(Controller.Instance.MenuTutorialCodeEditor, false);
    }), MyContextMenu.ColorGreen);
    myContextMenu.Rebuild(false);
  }

  public void MenuStrip_Layer()
  {
    MyContextMenu myContextMenu1 = MyContextMenu.Show();
    myContextMenu1.AddSeperator("Layers");
    myContextMenu1.AddSeperator("--------------------------");
    int curLayer = this.selectedLayerIndex;
    if (curLayer > 0)
      myContextMenu1.AddItem("Merge Down", (Action) (() =>
      {
        MapEditor.UndoMultiple undoMultiple = new MapEditor.UndoMultiple();
        this.stack_multiple = undoMultiple.stack;
        ZMap layer = this.layers[this.selectedLayerIndex - 1];
        int y = 0;
        int num = 0;
        for (; y < this.mapSizeY; ++y)
        {
          int x = 0;
          while (x < this.mapSizeX)
          {
            if (this.selectedLayer.GetPixelNoBoundsCheck(x, y).a > (byte) 0)
              layer.SetPixelColor(x, y, this.selectedLayer.GetPixelNoBoundsCheck(x, y));
            ++x;
            ++num;
          }
        }
        this.RemoveLayer();
        this.selectedLayer = layer;
        this.SaveDo_Pixels();
        layer.Apply();
        this.stack_multiple = (Stack<MapEditor.IUndoOperation>) null;
        this.stack_undo.Push((MapEditor.IUndoOperation) undoMultiple);
        this.RefreshUI();
        this.RebuildLayerUI();
      }), MyContextMenu.ColorGreen);
    else
      myContextMenu1.AddSeperator("Merge Down");
    if (this.layers.Count > 1)
      myContextMenu1.AddItem("Cutout Other", (Action) (() =>
      {
        MyContextMenu myContextMenu2 = MyContextMenu.Show();
        for (int index = 0; index < this.layers.Count; ++index)
        {
          if (index == curLayer)
          {
            myContextMenu2.AddSeperator(this.layers[index].name);
          }
          else
          {
            ZMap other = this.layers[index];
            myContextMenu2.AddItem(other.name, (Action) (() =>
            {
              Color32 clear = (Color32) Color.clear;
              int y = 0;
              int num = 0;
              for (; y < this.mapSizeY; ++y)
              {
                int x = 0;
                while (x < this.mapSizeX)
                {
                  if (other.GetPixelNoBoundsCheck(x, y).a > (byte) 0 && this.selectedLayer.GetPixelNoBoundsCheck(x, y).a > (byte) 0)
                    this.selectedLayer.SetPixelColor(x, y, clear);
                  ++x;
                  ++num;
                }
              }
              this.SaveDo_Pixels();
            }), MyContextMenu.ColorGreen);
          }
        }
        myContextMenu2.Rebuild(false);
      }), MyContextMenu.ColorGreen);
    else
      myContextMenu1.AddSeperator("Cutout Other");
    myContextMenu1.Rebuild(false);
  }

  internal void _open(string file)
  {
    this.CleanUp();
    this.editing = Path.GetFileName(file);
    this.txt_editing.text = this.editing;
    try
    {
      if (file.EndsWith(".png"))
      {
        Texture2D texture2D = new Texture2D(2, 2);
        texture2D.LoadImage(File.ReadAllBytes(file));
        if (texture2D.width < 100 || texture2D.height < 100 || (texture2D.width > 8192 || texture2D.height > 8192))
          throw new Exception("Map Size is too big/small (100x100 - 8192x8192)");
        this.AddLayer();
        this.layers[0].SetMapSprite(this.game, texture2D);
      }
      else
      {
        using (MemoryStream memoryStream = new MemoryStream(File.ReadAllBytes(file)))
        {
          using (myBinaryReader myBinaryReader = new myBinaryReader((Stream) memoryStream))
          {
            myBinaryReader.ReadInt32();
            int num1 = myBinaryReader.ReadInt32();
            int num2 = myBinaryReader.ReadInt32();
            if (num1 < 200 || num2 < 10 || (num1 > 8192 || num2 > 8192))
              throw new Exception("Map Size is too big/small");
            this.mapSizeX = num1;
            this.mapSizeY = num2;
            int num3 = myBinaryReader.ReadInt32();
            for (int index = 0; index < num3; ++index)
            {
              this.AddLayer();
              this.layers[index].name = myBinaryReader.ReadString();
              Texture2D texture2D = new Texture2D(2, 2);
              texture2D.LoadImage(myBinaryReader.ReadBytes());
              if (texture2D.width != num1 || texture2D.height != num2)
                throw new Exception("Map Size is malformed");
              this.layers[index].SetMapSprite(this.game, texture2D);
            }
          }
        }
      }
    }
    catch (Exception ex)
    {
      Debug.LogError((object) ex.ToString());
      this.CleanUp();
      MyMessageBox.Create("Error loading image: " + ex.ToString(), (Action) null, "Ok", (string) null, (Action) null, (Action) null, (Sprite) null, (string) null, (Action) null);
    }
    this.OnNewMap();
  }

  private void _save(string file, string ext)
  {
    if (!file.EndsWith(ext, StringComparison.OrdinalIgnoreCase))
      file += ext;
    this.editing = Path.GetFileName(file);
    this.txt_editing.text = this.editing;
    if (file.EndsWith(".png"))
    {
      Texture2D tex = new Texture2D(this.mapSizeX, this.mapSizeY);
      Color32[] pixels32 = tex.GetPixels32();
      bool flag = true;
      foreach (ZMap layer in this.layers)
      {
        int y = 0;
        int index = 0;
        for (; y < this.mapSizeY; ++y)
        {
          int x = 0;
          while (x < this.mapSizeX)
          {
            if (flag || layer.GetPixelNoBoundsCheck(x, y).a > (byte) 0)
              pixels32[index] = layer.GetPixelNoBoundsCheck(x, y);
            ++x;
            ++index;
          }
        }
      }
      tex.SetPixels32(pixels32);
      tex.Apply();
      File.WriteAllBytes(file, tex.EncodeToPNG());
    }
    else
    {
      using (MemoryStream memoryStream = new MemoryStream())
      {
        using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
        {
          myBinaryWriter.Write(1);
          myBinaryWriter.Write(this.mapSizeX);
          myBinaryWriter.Write(this.mapSizeY);
          myBinaryWriter.Write(this.layers.Count);
          foreach (ZMap layer in this.layers)
          {
            myBinaryWriter.Write(layer.name);
            Texture2D tex = new Texture2D(this.mapSizeX, this.mapSizeY);
            Color32[] pixels32 = tex.GetPixels32();
            int y = 0;
            int index = 0;
            for (; y < this.mapSizeY; ++y)
            {
              int x = 0;
              while (x < this.mapSizeX)
              {
                pixels32[index] = layer.GetPixelNoBoundsCheck(x, y);
                ++x;
                ++index;
              }
            }
            tex.SetPixels32(pixels32);
            tex.Apply();
            myBinaryWriter.Write(tex.EncodeToPNG());
          }
        }
        File.WriteAllBytes(file, memoryStream.ToArray());
      }
    }
  }

  public void SubMenu_New()
  {
    MyContextMenu myContextMenu = MyContextMenu.Show();
    InputFieldPlus width = myContextMenu.AddInput((Action<string>) null, this.mapSizeX.ToString(), false, false);
    InputFieldPlus height = myContextMenu.AddInput((Action<string>) null, this.mapSizeY.ToString(), false, false);
    myContextMenu.AddItem("Generate", (Action) (() =>
    {
      Prefs.mapEditorWidthX = width.inputText.text.ToInt(0);
      Prefs.mapEditorWidthY = height.inputText.text.ToInt(0);
      this.NewMap();
    }), MyContextMenu.ColorGreen);
    myContextMenu.Rebuild(false);
  }

  public void SubMenu_TextureColor()
  {
    Color color = this.img_textureColor.color;
    color.a = 1f;
    ColorPickerUI.Create(color, (Action<Color>) (c => this.img_textureColor.color = c), (Action<Color>) (c => this.img_textureColor.color = c), (Action) (() => this.img_textureColor.color = Color.clear));
  }

  public void SubMenu_ObjectColor()
  {
    Color color = this.img_objectColor.color;
    color.a = 1f;
    ColorPickerUI.Create(color, (Action<Color>) (c => this.img_objectColor.color = c), (Action<Color>) (c => this.img_objectColor.color = c), (Action) (() => this.img_objectColor.color = Color.clear));
  }

  public void MenuStrip_ClickObjects()
  {
    MyContextMenu myContextMenu = MyContextMenu.Show();
    myContextMenu.AddSeperator("Map Objects");
    myContextMenu.AddSeperator("--------------------------");
    MapEnum mapEnum = MapEnum.Grassy_Hills;
    int num = 0;
    foreach (SerializedResources.MapGroup mapGroup in Inert.Instance.classMaps.mapGroups)
    {
      SerializedResources.MapGroup z = mapGroup;
      MapEnum ttt = mapEnum;
      myContextMenu.AddItem(mapEnum.ToString(), (Action) (() => this.SubMenu_Objects(ttt, z)), MyContextMenu.ColorGreen);
      num = GameFacts.NextMapIndex(num);
      mapEnum = GameFacts.MapFromIndex(num);
    }
    if ((UnityEngine.Object) this._tex != (UnityEngine.Object) null)
    {
      myContextMenu.AddSeperator("--------------------------");
      myContextMenu.AddItem("Current - " + this._tex.name, (Action) (() => this.OnToolChange(MapEditor.Tool.ObjectPlacer)), MyContextMenu.ColorGreen);
    }
    myContextMenu.AddSeperator("--------------------------");
    myContextMenu.AddItem("Import... ", (Action) (() => MyFileBrowser.GetFile("", "", (Action<string, byte[]>) ((s, b) =>
    {
      if (b == null || b.Length == 0)
        return;
      this._tex = new Texture2D(2, 2);
      this._tex.LoadImage(b);
      this._tex.name = Path.GetFileNameWithoutExtension(s) + " (Imported)";
      this.OnToolChange(MapEditor.Tool.ObjectPlacer);
    }), new string[1]{ "png" })), MyContextMenu.ColorGreen);
    myContextMenu.Rebuild(false);
  }

  private void DestroyTex()
  {
    if (!((UnityEngine.Object) this._texPrivate != (UnityEngine.Object) null) || !this._texPrivate.name.EndsWith("(Imported)"))
      return;
    UnityEngine.Object.Destroy((UnityEngine.Object) this._texPrivate);
    this._texPrivate = (Texture2D) null;
  }

  public void SubMenu_Objects(MapEnum t, SerializedResources.MapGroup z)
  {
    MyContextMenu myContextMenu = MyContextMenu.Show();
    myContextMenu.AddSeperator(t.ToString() + " Objects");
    myContextMenu.AddSeperator("--------------------------");
    foreach (SerializedResources.Resource resource in z.resources)
    {
      SerializedResources.Resource x = resource;
      myContextMenu.AddItem(x.texture.name, (Action) (() =>
      {
        this._tex = x.texture;
        this.OnToolChange(MapEditor.Tool.ObjectPlacer);
      }), MyContextMenu.ColorGreen);
    }
    if (t == MapEnum.Mos_LeHarmless)
      myContextMenu.AddItem(Inert.Instance.classMaps.brdige.name, (Action) (() =>
      {
        this._tex = Inert.Instance.classMaps.brdige;
        this.OnToolChange(MapEditor.Tool.ObjectPlacer);
      }), MyContextMenu.ColorGreen);
    myContextMenu.AddSeperator("--------------------------");
    if ((UnityEngine.Object) z.grass != (UnityEngine.Object) null)
      myContextMenu.AddItem(z.grass.name, (Action) (() =>
      {
        this._tex = z.grass;
        this.OnToolChange(MapEditor.Tool.ObjectPlacer);
      }), MyContextMenu.ColorGreen);
    if ((UnityEngine.Object) z.underbelly != (UnityEngine.Object) null)
      myContextMenu.AddItem(z.underbelly.name, (Action) (() =>
      {
        this._tex = z.underbelly;
        this.OnToolChange(MapEditor.Tool.ObjectPlacer);
      }), MyContextMenu.ColorGreen);
    if ((UnityEngine.Object) z.bgTexture != (UnityEngine.Object) null)
      myContextMenu.AddItem(z.bgTexture.name, (Action) (() =>
      {
        this._tex = z.bgTexture;
        this.OnToolChange(MapEditor.Tool.ObjectPlacer);
      }), MyContextMenu.ColorGreen);
    myContextMenu.Rebuild(false);
  }

  public void MenuStrip_ClickTextures()
  {
    MyContextMenu myContextMenu = MyContextMenu.Show();
    myContextMenu.AddSeperator("Textures");
    myContextMenu.AddSeperator("--------------------------");
    MapEnum mapEnum = MapEnum.Grassy_Hills;
    int num = 0;
    foreach (SerializedResources.MapGroup mapGroup in Inert.Instance.classMaps.mapGroups)
    {
      SerializedResources.MapGroup z = mapGroup;
      myContextMenu.AddItem(mapEnum.ToString(), (Action) (() =>
      {
        this._tex = z.bgTexture;
        this.OnToolChange(MapEditor.Tool.TexturePainter);
      }), MyContextMenu.ColorGreen);
      num = GameFacts.NextMapIndex(num);
      mapEnum = GameFacts.MapFromIndex(num);
    }
    if ((UnityEngine.Object) this._tex != (UnityEngine.Object) null)
    {
      myContextMenu.AddSeperator("--------------------------");
      myContextMenu.AddItem("Current - " + this._tex.name, (Action) (() => this.OnToolChange(MapEditor.Tool.TexturePainter)), MyContextMenu.ColorGreen);
    }
    myContextMenu.AddSeperator("--------------------------");
    myContextMenu.AddItem("Import... ", (Action) (() => MyFileBrowser.GetFile("", "", (Action<string, byte[]>) ((s, b) =>
    {
      if (b == null || b.Length == 0)
        return;
      this._tex = new Texture2D(2, 2);
      this._tex.LoadImage(b);
      this._tex.name = Path.GetFileNameWithoutExtension(s) + " (Imported)";
      this.OnToolChange(MapEditor.Tool.TexturePainter);
    }), new string[1]{ "png" })), MyContextMenu.ColorGreen);
    myContextMenu.Rebuild(false);
  }

  public void MenuStrip_ClickGrass()
  {
    MyContextMenu myContextMenu1 = MyContextMenu.Show();
    myContextMenu1.AddSeperator("Generate Grass");
    myContextMenu1.AddSeperator("--------------------------");
    MapEnum mapEnum = MapEnum.Grassy_Hills;
    int num = 0;
    foreach (SerializedResources.MapGroup mapGroup in Inert.Instance.classMaps.mapGroups)
    {
      SerializedResources.MapGroup z = mapGroup;
      myContextMenu1.AddItem(mapEnum.ToString(), (Action) (() =>
      {
        this._grass = z.grass;
        this.selectedLayer.EditorPaintGrass();
        this.SaveDo_Pixels();
        this.selectedLayer.Apply();
      }), MyContextMenu.ColorGreen);
      num = GameFacts.NextMapIndex(num);
      mapEnum = GameFacts.MapFromIndex(num);
    }
    if ((UnityEngine.Object) this._tex != (UnityEngine.Object) null)
    {
      myContextMenu1.AddSeperator("--------------------------");
      myContextMenu1.AddItem("Current - " + this._tex.name, (Action) (() =>
      {
        this._grass = this._tex;
        this.selectedLayer.EditorPaintGrass();
        this.SaveDo_Pixels();
        this.selectedLayer.Apply();
      }), MyContextMenu.ColorGreen);
    }
    myContextMenu1.AddSeperator("--------------------------");
    myContextMenu1.AddItem("Import... ", (Action) (() => MyFileBrowser.GetFile("", "", (Action<string, byte[]>) ((s, b) =>
    {
      if (b == null || b.Length == 0)
        return;
      this._grass = new Texture2D(2, 2);
      this._grass.LoadImage(b);
      this._grass.name = Path.GetFileNameWithoutExtension(s);
      this.selectedLayer.EditorPaintGrass();
      this.SaveDo_Pixels();
      this.selectedLayer.Apply();
      UnityEngine.Object.Destroy((UnityEngine.Object) this._grass);
      this._grass = (Texture2D) null;
    }), new string[1]{ "png" })), MyContextMenu.ColorGreen);
    myContextMenu1.AddSeperator("--------------------------");
    myContextMenu1.AddItem("Offset " + this.grass_offset.ToString() + "px", (Action) (() =>
    {
      MyContextMenu myContextMenu2 = MyContextMenu.Show();
      myContextMenu2.AddInput((Action<string>) (s => this.grass_offset = s.ToInt(6)), this.grass_offset.ToString(), false, true);
      myContextMenu2.Rebuild(false);
    }), MyContextMenu.ColorGreen);
    myContextMenu1.Rebuild(false);
  }

  public void MenuStrip_ClickUnderbelly()
  {
    MyContextMenu myContextMenu = MyContextMenu.Show();
    myContextMenu.AddSeperator("Generate Grass");
    myContextMenu.AddSeperator("--------------------------");
    MapEnum mapEnum = MapEnum.Grassy_Hills;
    int num = 0;
    foreach (SerializedResources.MapGroup mapGroup in Inert.Instance.classMaps.mapGroups)
    {
      SerializedResources.MapGroup z = mapGroup;
      myContextMenu.AddItem(mapEnum.ToString(), (Action) (() =>
      {
        this._underbelly = z.underbelly;
        this.selectedLayer.EditorUnderbelly();
        this.SaveDo_Pixels();
        this.selectedLayer.Apply();
      }), MyContextMenu.ColorGreen);
      num = GameFacts.NextMapIndex(num);
      mapEnum = GameFacts.MapFromIndex(num);
    }
    if ((UnityEngine.Object) this._tex != (UnityEngine.Object) null)
    {
      myContextMenu.AddSeperator("--------------------------");
      myContextMenu.AddItem("Current - " + this._tex.name, (Action) (() =>
      {
        this._underbelly = this._tex;
        this.selectedLayer.EditorUnderbelly();
        this.SaveDo_Pixels();
        this.selectedLayer.Apply();
      }), MyContextMenu.ColorGreen);
    }
    myContextMenu.AddSeperator("--------------------------");
    myContextMenu.AddItem("Import... ", (Action) (() => MyFileBrowser.GetFile("", "", (Action<string, byte[]>) ((s, b) =>
    {
      if (b == null || b.Length == 0)
        return;
      this._underbelly = new Texture2D(2, 2);
      this._underbelly.LoadImage(b);
      this._underbelly.name = Path.GetFileNameWithoutExtension(s);
      this.selectedLayer.EditorUnderbelly();
      this.SaveDo_Pixels();
      this.selectedLayer.Apply();
      UnityEngine.Object.Destroy((UnityEngine.Object) this._underbelly);
      this._underbelly = (Texture2D) null;
    }), new string[1]{ "png" })), MyContextMenu.ColorGreen);
    myContextMenu.Rebuild(false);
  }

  public static Point GetMousePos()
  {
    Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    return new Point((int) worldPoint.x, (int) worldPoint.y);
  }

  public static Vector3 GetMousePosVector()
  {
    Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    return new Vector3(worldPoint.x, worldPoint.y);
  }

  public void RefreshBoxSelection()
  {
    if (this.boxSelection == null)
    {
      this.lineRenderer.positionCount = 0;
    }
    else
    {
      this.lineRenderer.positionCount = 4;
      this.lineRenderer.SetPositions(this.boxSelection.getBounds());
    }
  }

  public bool isSelected(Point p)
  {
    if (this.boxSelection != null)
      return this.boxSelection.Contains(p);
    if (this.selectedPixels != null)
      return this.selectedPixels.Contains(p);
    return p.x >= 0 && p.y >= 0 && p.x < this.mapSizeX && p.y < this.mapSizeY;
  }

  public IEnumerator<Point> inSelection()
  {
    int x;
    int y;
    if (this.boxSelection != null)
    {
      for (x = this.boxSelection.start.x; x < this.boxSelection.end.x; ++x)
      {
        for (y = this.boxSelection.start.y; y < this.boxSelection.end.y; ++y)
          yield return new Point(x, y);
      }
    }
    else if (this.selectedPixels != null)
    {
      foreach (Point selectedPixel in this.selectedPixels)
        yield return selectedPixel;
    }
    else
    {
      for (x = 0; x < this.mapSizeX; ++x)
      {
        for (y = 0; y < this.mapSizeY; ++y)
          yield return new Point(x, y);
      }
    }
  }

  private bool IsPointInPolygon(Vector2 point, List<Vector2> polygon)
  {
    bool flag = false;
    int index1 = polygon.Count - 1;
    for (int index2 = 0; index2 < polygon.Count; index1 = index2++)
    {
      if ((double) polygon[index2].y > (double) point.y != (double) polygon[index1].y > (double) point.y && (double) point.x < ((double) polygon[index1].x - (double) polygon[index2].x) * ((double) point.y - (double) polygon[index2].y) / ((double) polygon[index1].y - (double) polygon[index2].y) + (double) polygon[index2].x)
        flag = !flag;
    }
    return flag;
  }

  public void ResizeMap()
  {
  }

  private void CleanUp()
  {
    try
    {
      this.DestroyTex();
      if ((UnityEngine.Object) this.texture_preview != (UnityEngine.Object) null && this.texture_preview.CompareTag("RawImage"))
        UnityEngine.Object.Destroy((UnityEngine.Object) this.texture_preview.sprite);
      if ((UnityEngine.Object) this.sr_object != (UnityEngine.Object) null && this.sr_object.CompareTag("RawImage"))
        UnityEngine.Object.Destroy((UnityEngine.Object) this.sr_object.sprite);
      foreach (ZMap layer in this.layers)
        layer.CleanUp();
      this.layers.Clear();
    }
    catch (Exception ex)
    {
      Debug.LogError((object) ex.ToString());
    }
  }

  private void OnNewMap()
  {
    MapObjects.Instance.SetDashes();
    MapObjects.Instance.SetWaves();
    CameraMovement.Instance.SetBounds();
    HUD.SetupMiniCamera();
    this.stack_undo.Clear();
    this.stack_redo.Clear();
    this.stack_multiple = (Stack<MapEditor.IUndoOperation>) null;
    this.RefreshUI();
    this.RebuildLayerUI();
    Camera.main.orthographicSize = 850f;
    CameraMovement.Instance.GotoPosition(new Vector3((float) (this.mapSizeX / 2), (float) (this.mapSizeY / 2)));
  }

  public void NewMap()
  {
    this.CleanUp();
    this.mapSizeX = Prefs.mapEditorWidthX;
    this.mapSizeY = Prefs.mapEditorWidthY;
    this.mapSizeY = Mathf.Clamp(this.mapSizeY, 100, 8192);
    this.mapSizeX = Mathf.Clamp(this.mapSizeX, 100, 8192);
    this.AddLayer();
    this.OnNewMap();
  }

  public void AddLayer()
  {
    ZMap layer = new ZMap();
    Color32[] pixels = new Color32[this.mapSizeX * this.mapSizeY];
    layer.game = this.game;
    this.game.map = layer;
    layer.SetMapSprite(this.game, pixels, this.mapSizeY, this.mapSizeX);
    this.UpdateLayerOrder(layer, this.layers.Count);
    layer.name = "Layer " + (this.layers.Count + 1).ToString();
    this.layers.Add(layer);
    this.selectedLayer = layer;
    if (this.layers.Count > 1)
      this.stack_undo.Push((MapEditor.IUndoOperation) new MapEditor.UndoLayerAdd());
    this.RefreshUI();
    this.RebuildLayerUI();
  }

  public ZMap InsertLayer(int index, string name)
  {
    ZMap zmap = new ZMap();
    Color32[] pixels = new Color32[this.mapSizeX * this.mapSizeY];
    zmap.game = this.game;
    this.game.map = zmap;
    zmap.SetMapSprite(this.game, pixels, this.mapSizeY, this.mapSizeX);
    zmap.name = name;
    this.layers.Insert(index, zmap);
    for (int i = index; i < this.layers.Count; ++i)
      this.UpdateLayerOrder(this.layers[i], i);
    this.selectedLayer = zmap;
    this.RefreshUI();
    this.RebuildLayerUI();
    return zmap;
  }

  public void RemoveLayer()
  {
    this.RemoveLayer(true);
  }

  public void RemoveLayer(bool undo)
  {
    if (undo)
      MapEditor.GetStack(true).Push((MapEditor.IUndoOperation) new MapEditor.UndoLayerDelete(this.selectedLayer));
    int selectedLayerIndex = this.selectedLayerIndex;
    if (selectedLayerIndex != -1 && this.layers.Count > 1)
    {
      this.selectedLayer.CleanUp();
      this.layers.RemoveAt(selectedLayerIndex);
      if (selectedLayerIndex >= this.layers.Count)
        --selectedLayerIndex;
      this.selectedLayer = this.layers[selectedLayerIndex];
      for (; selectedLayerIndex < this.layers.Count; ++selectedLayerIndex)
        this.UpdateLayerOrder(this.layers[selectedLayerIndex], selectedLayerIndex);
    }
    this.RefreshUI();
    this.RebuildLayerUI();
  }

  public void MoveLayerUp()
  {
    int selectedLayerIndex = this.selectedLayerIndex;
    if (selectedLayerIndex >= this.layers.Count - 1)
      return;
    ZMap layer = this.layers[selectedLayerIndex + 1];
    this.layers[selectedLayerIndex] = layer;
    this.layers[selectedLayerIndex + 1] = this.selectedLayer;
    this.UpdateLayerOrder(this.layers[selectedLayerIndex], selectedLayerIndex);
    this.UpdateLayerOrder(this.selectedLayer, selectedLayerIndex + 1);
    this.RefreshUI();
    this.RebuildLayerUI();
  }

  public void MoveLayerDown()
  {
    int selectedLayerIndex = this.selectedLayerIndex;
    if (selectedLayerIndex <= 0)
      return;
    ZMap layer = this.layers[selectedLayerIndex - 1];
    this.layers[selectedLayerIndex] = layer;
    this.layers[selectedLayerIndex - 1] = this.selectedLayer;
    this.UpdateLayerOrder(this.layers[selectedLayerIndex], selectedLayerIndex);
    this.UpdateLayerOrder(this.selectedLayer, selectedLayerIndex - 1);
    this.RefreshUI();
    this.RebuildLayerUI();
  }

  private void UpdateLayerOrder(ZMap layer, int i)
  {
    int num = i - 20;
    foreach (ZMap.RawSprite rawSprite in layer.GetRawSprites())
      rawSprite.sr.sortingOrder = num;
  }

  public static IMapEditorTool GetTool(MapEditor.Tool t)
  {
    switch (t)
    {
      case MapEditor.Tool.TexturePainter:
        return (IMapEditorTool) new ToolTexturePainter();
      case MapEditor.Tool.ObjectPlacer:
        return (IMapEditorTool) new ToolObjectPainter();
      case MapEditor.Tool.BoxSelect:
        return (IMapEditorTool) new ToolBoxSelection();
      default:
        return (IMapEditorTool) new ToolTexturePainter();
    }
  }

  private void Start()
  {
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.Escape))
      this.MenuStrip_File();
    else if (Player.IsPointerOverGameObject(0) && !Input.GetMouseButton(0) && Input.touchCount <= 0)
    {
      this.softLock = true;
    }
    else
    {
      if (this.softLock)
      {
        if (Input.GetMouseButton(0) || Input.touchCount > 0)
          return;
        this.softLock = false;
      }
      this.CheckMouse(0);
      this.CheckMouse(1);
      this.RefreshToolGraphic();
    }
  }

  private void RefreshToolGraphic()
  {
    switch (this.selectedTool)
    {
      case MapEditor.Tool.TexturePainter:
        Point mousePos = MapEditor.GetMousePos();
        if (this.drop_texShape.value == 1)
        {
          if (this.lr_texture_positions.Length != 4)
            this.lr_texture_positions = new Vector3[4];
          this.lr_texture_positions[0] = new Vector3((float) (mousePos.x - this.brushSize), (float) (mousePos.y - this.brushSize));
          this.lr_texture_positions[1] = new Vector3((float) (mousePos.x + this.brushSize), (float) (mousePos.y - this.brushSize));
          this.lr_texture_positions[2] = new Vector3((float) (mousePos.x + this.brushSize), (float) (mousePos.y + this.brushSize));
          this.lr_texture_positions[3] = new Vector3((float) (mousePos.x - this.brushSize), (float) (mousePos.y + this.brushSize));
          this.lr_texture.positionCount = this.lr_texture_positions.Length;
          this.lr_texture.SetPositions(this.lr_texture_positions);
          break;
        }
        if (this.lr_texture_positions.Length != 360)
          this.lr_texture_positions = new Vector3[360];
        float num = (float) (360.0 / (double) this.lr_texture_positions.Length * (Math.PI / 180.0));
        float brushSize = (float) this.brushSize;
        for (int index = 0; index < this.lr_texture_positions.Length; ++index)
          this.lr_texture_positions[index] = new Vector3(Mathf.Sin(num * (float) index) * brushSize + (float) mousePos.x, Mathf.Cos(num * (float) index) * brushSize + (float) mousePos.y);
        this.lr_texture.positionCount = this.lr_texture_positions.Length;
        this.lr_texture.SetPositions(this.lr_texture_positions);
        break;
      case MapEditor.Tool.ObjectPlacer:
        this.toolGraphics[(int) this.selectedTool].transform.position = MapEditor.GetMousePos().ToVector3();
        break;
      default:
        if (!((UnityEngine.Object) this.toolGraphics[(int) this.selectedTool] != (UnityEngine.Object) null))
          break;
        this.toolGraphics[(int) this.selectedTool].transform.position = MapEditor.GetMousePos().ToVector3();
        break;
    }
  }

  private void CheckMouse(int x)
  {
    if (Input.GetMouseButton(x))
    {
      if (Input.GetMouseButtonDown(x))
      {
        this.isDragging = false;
        this.lastMousePos = (Vector2) Input.mousePosition;
        MapEditor.GetTool(this.selectedTool).OnMouseDown(x == 0);
      }
      else
      {
        if ((double) Vector2.Distance((Vector2) Input.mousePosition, this.lastMousePos) <= 1.0)
          return;
        this.isDragging = true;
        MapEditor.GetTool(this.selectedTool).OnMouseDrag(x == 0);
      }
    }
    else
    {
      if (!Input.GetMouseButtonUp(x))
        return;
      MapEditor.GetTool(this.selectedTool).OnMouseUp(x == 0);
      this.isDragging = false;
    }
  }

  public void RefreshUI()
  {
    int count;
    if (this.stack_undo.Count == 0)
    {
      this.txt_undo.text = "Undo";
    }
    else
    {
      TMP_Text txtUndo = this.txt_undo;
      count = this.stack_undo.Count;
      string str = "Undo (" + count.ToString() + ")";
      txtUndo.text = str;
    }
    if (this.stack_redo.Count == 0)
    {
      this.txt_redo.text = "Redo";
    }
    else
    {
      TMP_Text txtRedo = this.txt_redo;
      count = this.stack_redo.Count;
      string str = "Redo (" + count.ToString() + ")";
      txtRedo.text = str;
    }
    int selectedLayerIndex = this.selectedLayerIndex;
    this.but_undo.Interactable(this.stack_undo.Count > 0);
    this.but_redo.Interactable(this.stack_redo.Count > 0);
    this.but_layerAdd.Interactable(this.layers.Count < 6);
    this.but_layerRemove.Interactable(this.layers.Count > 1);
    this.but_layerMoveUp.Interactable(selectedLayerIndex < this.layers.Count - 1);
    this.but_layerMoveDown.Interactable(selectedLayerIndex > 0);
  }

  private void LateUpdate()
  {
    float num = (float) Screen.height / (this.cam.orthographicSize * 2f);
    this.lineRenderer.widthMultiplier = this.desiredPixelWidth / num;
    this.lr_texture.widthMultiplier = this.desiredPixelWidth / num;
  }

  public static Stack<MapEditor.IUndoOperation> GetStack(bool undo)
  {
    if (MapEditor.Instance.stack_multiple != null)
      return MapEditor.Instance.stack_multiple;
    return !undo ? MapEditor.Instance.stack_redo : MapEditor.Instance.stack_undo;
  }

  public void SaveDo_BoxSelection(MapEditor.BoxSelection b)
  {
    MapEditor.IUndoOperation undoOperation = this.stack_undo.Count == 0 ? (MapEditor.IUndoOperation) null : this.stack_undo.Peek();
    if (undoOperation == null && b == null || undoOperation != null && b != null && (undoOperation is MapEditor.UndoBoxSelection && b.Equals((object) (undoOperation as MapEditor.BoxSelection))))
      return;
    this.stack_undo.Push((MapEditor.IUndoOperation) new MapEditor.UndoBoxSelection(b));
    this.RefreshUI();
  }

  public void SaveDo_Pixels()
  {
    MapEditor.UndoPixels changed = MapEditor.UndoPixels.GetChanged(this.curPixelStack);
    if (changed.areas.Count == 0)
      return;
    MapEditor.GetStack(true).Push((MapEditor.IUndoOperation) changed);
    this.curPixelStack = (MapEditor.UndoPixels) null;
    if (this.stack_multiple == null)
      this.stack_redo.Clear();
    this.RefreshUI();
  }

  public void Redo()
  {
    if (this.stack_redo.Count > 0)
      this.stack_redo.Pop().Do(true);
    this.RefreshUI();
  }

  public void Undo()
  {
    if (this.stack_undo.Count > 0)
      this.stack_undo.Pop().Do(false);
    this.RefreshUI();
  }

  public class BoxSelection
  {
    public Point start;
    public Point end;

    public MapEditor.BoxSelection Copy()
    {
      return new MapEditor.BoxSelection()
      {
        start = new Point(this.start.x, this.start.y),
        end = new Point(this.end.x, this.end.y)
      };
    }

    public Vector3[] getBounds()
    {
      int num1 = Mathf.Min(this.start.x, this.end.x);
      int num2 = Mathf.Max(this.start.x, this.end.x);
      int num3 = Mathf.Max(this.start.y, this.end.y);
      int num4 = Mathf.Min(this.start.y, this.end.y);
      return new Vector3[4]
      {
        new Vector3((float) num1, (float) num3),
        new Vector3((float) num2, (float) num3),
        new Vector3((float) num2, (float) num4),
        new Vector3((float) num1, (float) num4)
      };
    }

    public int width
    {
      get
      {
        return this.end.x - this.start.x;
      }
    }

    public int height
    {
      get
      {
        return this.start.y - this.end.y;
      }
    }

    public bool Contains(Point p)
    {
      Mathf.Min(this.start.x, this.end.x);
      Mathf.Max(this.start.x, this.end.x);
      Mathf.Max(this.start.y, this.end.y);
      Mathf.Min(this.start.y, this.end.y);
      return p.x >= this.start.x && p.x <= this.end.x && p.y <= this.start.y && p.y >= this.end.y;
    }

    public BoxSelection()
    {
    }

    public BoxSelection(Point p)
    {
      this.start = p;
      this.end = p;
    }

    public MapEditor.BoxSelection SetEnd(Point p)
    {
      this.end = p;
      return this;
    }

    public override bool Equals(object obj)
    {
      if (obj == null || !(obj is MapEditor.BoxSelection))
        return false;
      MapEditor.BoxSelection boxSelection = obj as MapEditor.BoxSelection;
      return boxSelection.start.x == this.start.x && boxSelection.start.y == this.start.y && boxSelection.end.x == this.end.x && boxSelection.end.y == this.end.y;
    }
  }

  public enum BrushShape
  {
    Circle,
    Square,
    Pixel,
  }

  public enum Tool
  {
    None,
    TexturePainter,
    ObjectPlacer,
    Grass,
    BoxSelect,
    Move,
    FreeFormSelect,
    ColorPicker,
    ColorDropper,
    PaintBucket,
  }

  public interface IUndoOperation
  {
    void Do(bool undo);
  }

  public class UndoLayerName : MapEditor.IUndoOperation
  {
    public int layer;
    public string name;

    public void Do(bool undo)
    {
      MapEditor.GetStack(undo).Push((MapEditor.IUndoOperation) new MapEditor.UndoLayerName(this.layer, MapEditor.Instance.layers[this.layer].name));
      MapEditor.Instance.layers[this.layer].name = this.name;
    }

    public UndoLayerName(int layer, string name)
    {
      this.layer = layer;
      this.name = name;
    }
  }

  public class UndoMultiple : MapEditor.IUndoOperation
  {
    public Stack<MapEditor.IUndoOperation> stack = new Stack<MapEditor.IUndoOperation>();

    public void Do(bool undo)
    {
      MapEditor.UndoMultiple undoMultiple = new MapEditor.UndoMultiple();
      MapEditor.Instance.stack_multiple = undoMultiple.stack;
      for (int count = this.stack.Count; count > 0; --count)
        this.stack.Pop().Do(undo);
      MapEditor.Instance.stack_multiple = (Stack<MapEditor.IUndoOperation>) null;
      MapEditor.GetStack(undo).Push((MapEditor.IUndoOperation) undoMultiple);
    }
  }

  public class UndoLayerDelete : MapEditor.IUndoOperation
  {
    public List<MapEditor.UndoPixels.area> areas = new List<MapEditor.UndoPixels.area>();
    public int layer;
    public string name;

    public void Do(bool undo)
    {
      MapEditor.GetStack(undo).Push((MapEditor.IUndoOperation) new MapEditor.UndoLayerAdd());
      ZMap zmap = MapEditor.Instance.InsertLayer(this.layer, this.name);
      foreach (MapEditor.UndoPixels.area area in this.areas)
      {
        zmap.GetRawSprites()[area.index].colors = area.pixels;
        zmap.GetRawSprites()[area.index].requireUpdate = true;
        zmap.GetRawSprites()[area.index].Apply();
      }
    }

    public UndoLayerDelete(ZMap m)
    {
      this.layer = MapEditor.Instance.layers.FindIndex((Predicate<ZMap>) (z => z == m));
      this.name = m.name;
      int num = 0;
      foreach (ZMap.RawSprite rawSprite in m.GetRawSprites())
      {
        this.areas.Add(new MapEditor.UndoPixels.area()
        {
          layer = this.layer,
          index = num,
          pixels = rawSprite.colors
        });
        ++num;
      }
    }
  }

  public class UndoLayerAdd : MapEditor.IUndoOperation
  {
    public void Do(bool undo)
    {
      MapEditor.GetStack(undo).Push((MapEditor.IUndoOperation) new MapEditor.UndoLayerDelete(MapEditor.Instance.selectedLayer));
      MapEditor.Instance.RemoveLayer(false);
    }
  }

  public class UndoLayerSelect : MapEditor.IUndoOperation
  {
    public int layer;

    public UndoLayerSelect(int layer)
    {
      this.layer = layer;
    }

    public void Do(bool undo)
    {
      MapEditor.GetStack(undo).Push((MapEditor.IUndoOperation) new MapEditor.UndoLayerSelect(MapEditor.Instance.selectedLayerIndex));
      MapEditor.Instance.selectedLayer = MapEditor.Instance.layers[this.layer];
      MapEditor.Instance.RefreshUI();
    }
  }

  public class UndoLayerMove : MapEditor.IUndoOperation
  {
    public bool up;

    public UndoLayerMove(bool up)
    {
      this.up = up;
    }

    public void Do(bool undo)
    {
      MapEditor.GetStack(undo).Push((MapEditor.IUndoOperation) new MapEditor.UndoLayerMove(!this.up));
      if (this.up)
        MapEditor.Instance.MoveLayerUp();
      else
        MapEditor.Instance.MoveLayerDown();
    }
  }

  public class UndoBoxSelection : MapEditor.IUndoOperation
  {
    public MapEditor.BoxSelection box;

    public UndoBoxSelection(MapEditor.BoxSelection b)
    {
      if (b == null)
        return;
      this.box = b.Copy();
    }

    public void Do(bool undo)
    {
      if (undo)
        MapEditor.Instance.stack_undo.Push((MapEditor.IUndoOperation) new MapEditor.UndoBoxSelection(MapEditor.Instance.boxSelection));
      else
        MapEditor.Instance.stack_redo.Push((MapEditor.IUndoOperation) new MapEditor.UndoBoxSelection(MapEditor.Instance.boxSelection));
      MapEditor.Instance.boxSelection = this.box;
      MapEditor.Instance.RefreshBoxSelection();
    }
  }

  public class UndoPixels : MapEditor.IUndoOperation
  {
    public List<MapEditor.UndoPixels.area> areas = new List<MapEditor.UndoPixels.area>();

    public void Do(bool undo)
    {
      MapEditor.UndoPixels undoPixels = new MapEditor.UndoPixels();
      foreach (MapEditor.UndoPixels.area area in this.areas)
      {
        undoPixels.Add(area.layer, area.index, MapEditor.Instance.layers[area.layer].GetRawSprites()[area.index].colors);
        MapEditor.Instance.layers[area.layer].GetRawSprites()[area.index].colors = area.pixels;
        MapEditor.Instance.layers[area.layer].GetRawSprites()[area.index].requireUpdate = true;
        MapEditor.Instance.layers[area.layer].GetRawSprites()[area.index].Apply();
      }
      if (undo)
        MapEditor.Instance.stack_undo.Push((MapEditor.IUndoOperation) undoPixels);
      else
        MapEditor.Instance.stack_redo.Push((MapEditor.IUndoOperation) undoPixels);
    }

    public void Add(int layer, int index, Color32[] s)
    {
      MapEditor.UndoPixels.area area = new MapEditor.UndoPixels.area();
      area.layer = layer;
      area.index = index;
      area.pixels = new Color32[s.Length];
      Array.Copy((Array) s, (Array) area.pixels, s.Length);
      this.areas.Add(area);
    }

    public static MapEditor.UndoPixels GetChanged(MapEditor.UndoPixels p = null)
    {
      MapEditor.UndoPixels undoPixels = p ?? new MapEditor.UndoPixels();
      List<ZMap.RawSprite> rawSprites = MapEditor.Instance.selectedLayer.GetRawSprites();
      int layer = MapEditor.Instance.selectedLayerIndex;
      for (int i = 0; i < rawSprites.Count; ++i)
      {
        if (rawSprites[i].requireUpdate && undoPixels.areas.Find((Predicate<MapEditor.UndoPixels.area>) (t => t.layer == layer && t.index == i)) == null)
          undoPixels.Add(layer, i, rawSprites[i].sr.sprite.texture.GetPixels32());
      }
      return undoPixels;
    }

    public class area
    {
      public int layer;
      public int index;
      public Color32[] pixels;
    }
  }
}
