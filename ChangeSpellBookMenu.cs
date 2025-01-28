
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ChangeSpellBookMenu : MonoBehaviour
{
  private string selectedBook = "";
  private string selectedFilePath = "";
  private SettingsPlayer settingsPlayer = new SettingsPlayer();
  private string subDir = "";
  public GameObject buttonOpenFileExplorer;
  public InputFieldPlus input;
  public RectTransform container;
  public GameObject pfabBook;
  public RectTransform[] column;
  public UIOnHover buttonSelect;
  public Image[] spellSlot;
  [NonSerialized]
  public Image[] restricted;
  public Image elemental;
  public TMP_Text headerMouseoverSpell;
  public TMP_Text textMouseoverSpell;
  public TMP_Text textMouseoverSpellExtra;
  public GameObject MouseoverObj;
  private GameObject selectedGameObject;
  public UIOnHover buttonDelete;
  public UIOnHover buttonRename;
  [Header("Folders")]
  public RectTransform containerFolder;
  public GameObject pfabFolder;
  [Header("Share")]
  public UIOnHover buttonShare;
  private Action<SettingsPlayer> onEnd;
  public static ChangeSpellBookMenu Instance;
  private float lastClick;

  public static void Create(bool saving, SettingsPlayer sp = null, Action<SettingsPlayer> onEnd = null)
  {
    Client.sharingWith = "";
    if (!((UnityEngine.Object) ChangeSpellBookMenu.Instance == (UnityEngine.Object) null))
      return;
    Controller.Instance.Push(Controller.Instance.CreateAndApply(Controller.Instance.PopupSavedSpells, Controller.Instance.transform));
    ChangeSpellBookMenu.Instance.onEnd = onEnd;
    ChangeSpellBookMenu.Instance.restricted = new Image[ChangeSpellBookMenu.Instance.spellSlot.Length];
    int index = 0;
    foreach (Image image in ChangeSpellBookMenu.Instance.spellSlot)
    {
      ChangeSpellBookMenu.Instance.restricted[index] = image.transform.parent.GetChild(2).GetComponent<Image>();
      ++index;
    }
    if (saving)
    {
      ChangeSpellBookMenu.Instance.input.onEnd.AddListener(new UnityAction<string>(ChangeSpellBookMenu.Instance.OnEndEdit));
      ChangeSpellBookMenu.Instance.input.gameObject.SetActive(true);
      ChangeSpellBookMenu.Instance.input.SetAsActive(true);
    }
    if (sp != null)
      ChangeSpellBookMenu.Instance.settingsPlayer.CopySpells(sp, false);
    if (!((UnityEngine.Object) LobbyMenu.instance != (UnityEngine.Object) null) && !((UnityEngine.Object) UnratedMenu.instance != (UnityEngine.Object) null) && (!((UnityEngine.Object) RatedMenu.instance != (UnityEngine.Object) null) || string.IsNullOrEmpty(Client.sharingWith)))
      return;
    ChangeSpellBookMenu.Instance.buttonShare.transform.gameObject.SetActive(true);
  }

  public void ClickShare()
  {
    Client.AskToShare(Path.GetFileNameWithoutExtension(this.selectedBook), ContentType.SpellBook, (object) this.settingsPlayer, false);
    this.Cancel();
  }

  public void Awake()
  {
    if ((UnityEngine.Object) ChangeSpellBookMenu.Instance != (UnityEngine.Object) null)
      UnityEngine.Object.Destroy((UnityEngine.Object) ChangeSpellBookMenu.Instance.gameObject);
    ChangeSpellBookMenu.Instance = this;
    this.Load("");
    this.settingsPlayer.CopySpells(Client.settingsPlayer, false);
    GameObject openFileExplorer = this.buttonOpenFileExplorer;
    if (openFileExplorer == null)
      return;
    openFileExplorer.HideIfWebGL();
  }

  private void Start()
  {
    this.SetSpells();
  }

  private void OnDestroy()
  {
    if (!((UnityEngine.Object) ChangeSpellBookMenu.Instance == (UnityEngine.Object) this))
      return;
    ChangeSpellBookMenu.Instance = (ChangeSpellBookMenu) null;
  }

  private void OnEndEdit(string s)
  {
    if (!this.input.gameObject.activeSelf)
      return;
    s = s.Trim();
    if (string.IsNullOrEmpty(s))
      return;
    this.input.gameObject.SetActive(false);
    this.Save(s);
    UnityEngine.Object.Destroy((UnityEngine.Object) this.gameObject);
  }

  public void ClickDelete()
  {
    if ((UnityEngine.Object) this.selectedGameObject == (UnityEngine.Object) null)
      return;
    Global.DeleteFile(this.selectedFilePath);
    UnityEngine.Object.Destroy((UnityEngine.Object) this.selectedGameObject);
    this.buttonDelete.Interactable(false);
    this.buttonSelect.Interactable(false);
    this.buttonShare.Interactable(false);
  }

  public void ClickRename()
  {
    if ((UnityEngine.Object) this.selectedGameObject == (UnityEngine.Object) null)
      return;
    MyContextMenu myContextMenu = MyContextMenu.Show();
    string s = this.selectedFilePath;
    GameObject gameObject = this.selectedGameObject;
    Action<string> a = (Action<string>) (ss =>
    {
      if (string.IsNullOrEmpty(ss))
        return;
      string dir = s.Substring(0, s.Length - Path.GetFileName(s).Length) + ss + Path.GetExtension(s);
      File.Move(s, dir);
      this.selectedFilePath = dir;
      gameObject.GetComponent<UIOnHover>().onRightClick.RemoveAllListeners();
      gameObject.name = dir;
      gameObject.GetComponent<TextMeshProUGUI>().text = ss;
      gameObject.GetComponent<UIOnHover>().onRightClick.AddListener((UnityAction) (() => this.OnRightClick(dir, gameObject)));
    });
    myContextMenu.AddInput(a, (string) null, false);
  }

  public void OnRightClick(string s, GameObject gameObject)
  {
    if (!File.Exists(s))
      return;
    MyContextMenu myContextMenu = MyContextMenu.Show();
    myContextMenu.AddSeperator("--------------------------");
    myContextMenu.AddItem("Rename", (Action) (() => MyContextMenu.Show().AddInput((Action<string>) (ss =>
    {
      ChangeSpellBookMenu.\u003C\u003Ec__DisplayClass33_0 cDisplayClass330 = this;
      if (string.IsNullOrEmpty(ss))
        return;
      string dir = s.Substring(0, s.Length - Path.GetFileName(s).Length) + ss + Path.GetExtension(s);
      File.Move(s, dir);
      this.selectedFilePath = dir;
      gameObject.GetComponent<UIOnHover>().onRightClick.RemoveAllListeners();
      gameObject.name = dir;
      gameObject.GetComponent<TextMeshProUGUI>().text = ss;
      gameObject.GetComponent<UIOnHover>().onRightClick.AddListener((UnityAction) (() => cDisplayClass330.\u003C\u003E4__this.OnRightClick(dir, cDisplayClass330.gameObject)));
    }), (string) null, false)), (Color) ColorScheme.GetColor(MyContextMenu.ColorYellow));
    myContextMenu.AddItem("Delete " + Path.GetFileNameWithoutExtension(s), (Action) (() =>
    {
      Global.DeleteFile(s);
      UnityEngine.Object.Destroy((UnityEngine.Object) gameObject);
    }), (Color) ColorScheme.GetColor(MyContextMenu.ColorRed));
    myContextMenu.Rebuild(false);
  }

  private void Load(string subFolder = "")
  {
    this.subDir = subFolder;
    for (int index = this.container.childCount - 1; index > 3; --index)
      UnityEngine.Object.Destroy((UnityEngine.Object) this.container.GetChild(index).gameObject);
    for (int index = this.containerFolder.childCount - 1; index > 0; --index)
      UnityEngine.Object.Destroy((UnityEngine.Object) this.containerFolder.GetChild(index).gameObject);
    string persistentDataPath1 = SaveFolder.persistentDataPath;
    char directorySeparatorChar = Path.DirectorySeparatorChar;
    string str1 = directorySeparatorChar.ToString();
    directorySeparatorChar = Path.DirectorySeparatorChar;
    string str2 = directorySeparatorChar.ToString();
    string path = persistentDataPath1 + str1 + "SavedSpells" + str2;
    int length = path.Length;
    if (!Directory.Exists(path))
      Directory.CreateDirectory(path);
    if (!string.IsNullOrEmpty(subFolder))
    {
      path += subFolder;
      if (!Directory.Exists(path))
      {
        string persistentDataPath2 = SaveFolder.persistentDataPath;
        directorySeparatorChar = Path.DirectorySeparatorChar;
        string str3 = directorySeparatorChar.ToString();
        directorySeparatorChar = Path.DirectorySeparatorChar;
        string str4 = directorySeparatorChar.ToString();
        path = persistentDataPath2 + str3 + "SavedSpells" + str4;
      }
    }
    int num1 = 0;
    if (path.Length > length)
    {
      num1 = 64;
      GameObject gameObject1 = UnityEngine.Object.Instantiate<GameObject>(this.pfabFolder, (Transform) this.containerFolder);
      RectTransform transform = (RectTransform) gameObject1.transform;
      transform.anchoredPosition = (Vector2) new Vector3(5f, 0.0f);
      transform.localScale = new Vector3(1f, 1f, 1f);
      transform.GetComponent<TMP_Text>().text = "Top Folder";
      transform.name = "";
      UIOnHover component1 = gameObject1.GetComponent<UIOnHover>();
      component1.textNormalColor = Color.green;
      gameObject1.GetComponent<TMP_Text>().color = Color.green;
      component1.onClick.AddListener((UnityAction) (() => this.Load("")));
      gameObject1.SetActive(true);
      GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.pfabFolder, (Transform) this.containerFolder);
      RectTransform rect = (RectTransform) gameObject2.transform;
      rect.anchoredPosition = (Vector2) new Vector3(0.0f, -32f);
      rect.localScale = new Vector3(1f, 1f, 1f);
      rect.GetComponent<TMP_Text>().text = "Up One Folder";
      string fullName = Directory.GetParent(Directory.GetParent(path).FullName).FullName;
      RectTransform rectTransform = rect;
      string str3;
      if (fullName.Length <= length)
      {
        str3 = "";
      }
      else
      {
        string str4 = fullName.Substring(length);
        directorySeparatorChar = Path.DirectorySeparatorChar;
        string str5 = directorySeparatorChar.ToString();
        str3 = str4 + str5;
      }
      rectTransform.name = str3;
      UIOnHover component2 = gameObject2.GetComponent<UIOnHover>();
      component2.textNormalColor = Color.green;
      gameObject2.GetComponent<TMP_Text>().color = Color.green;
      component2.onClick.AddListener((UnityAction) (() => this.Load(rect.name)));
      gameObject2.SetActive(true);
    }
    string[] directories = Directory.GetDirectories(path);
    for (int index = 0; index < directories.Length; ++index)
    {
      GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.pfabFolder, (Transform) this.containerFolder);
      RectTransform rect = (RectTransform) gameObject.transform;
      rect.anchoredPosition = (Vector2) new Vector3(0.0f, (float) (index * -32 - num1));
      rect.localScale = new Vector3(1f, 1f, 1f);
      rect.GetComponent<TMP_Text>().text = directories[index].Substring(path.Length);
      RectTransform rectTransform = rect;
      string str3 = directories[index].Substring(length);
      directorySeparatorChar = Path.DirectorySeparatorChar;
      string str4 = directorySeparatorChar.ToString();
      string str5 = str3 + str4;
      rectTransform.name = str5;
      gameObject.GetComponent<UIOnHover>().onClick.AddListener((UnityAction) (() => this.Load(rect.name)));
      gameObject.SetActive(true);
    }
    this.containerFolder.sizeDelta = new Vector2(this.containerFolder.sizeDelta.x, (float) (num1 + directories.Length * 32));
    List<string> list = ((IEnumerable<string>) Directory.GetFiles(path, "*.spellBook")).OrderBy<string, string>((Func<string, string>) (f => f)).ToList<string>();
    float[] numArray = new float[this.column.Length];
    for (int index = 0; index < this.column.Length; ++index)
      numArray[index] = this.column[index].anchoredPosition.y;
    int index1 = 0;
    float num2 = 0.0f;
    foreach (string str3 in list)
    {
      GameObject g = UnityEngine.Object.Instantiate<GameObject>(this.pfabBook, (Transform) this.container);
      RectTransform transform = (RectTransform) g.transform;
      transform.localScale = new Vector3(1f, 1f, 1f);
      transform.anchoredPosition = new Vector2(this.column[index1].anchoredPosition.x, numArray[index1]);
      string s = str3;
      g.name = str3;
      g.GetComponent<TextMeshProUGUI>().text = Path.GetFileNameWithoutExtension(g.name);
      g.GetComponent<UIOnHover>().onClick.AddListener((UnityAction) (() =>
      {
        this.selectedGameObject = g;
        this.PreviewBook(s);
      }));
      g.GetComponent<UIOnHover>().onRightClick.AddListener((UnityAction) (() => this.OnRightClick(s, g)));
      numArray[index1] -= transform.sizeDelta.y * transform.localScale.y;
      if ((double) numArray[index1] < (double) num2)
        num2 = numArray[index1];
      ++index1;
      if (index1 >= this.column.Length)
        index1 = 0;
      g.SetActive(true);
    }
    this.container.sizeDelta = new Vector2(this.container.sizeDelta.x, (float) (-(double) num2 + 20.0));
  }

  public void Select()
  {
    if (this.input.gameObject.activeInHierarchy)
      this.ClickSave();
    else if (this.onEnd != null)
    {
      this.onEnd(this.settingsPlayer);
      if (!string.IsNullOrEmpty(Client.sharingWith))
        this.ClickShare();
      this.Cancel();
    }
    else
    {
      if (string.IsNullOrEmpty(this.selectedBook))
        return;
      if ((UnityEngine.Object) SpellSelection.Instance != (UnityEngine.Object) null)
      {
        Client.settingsPlayer.CopySpells(this.settingsPlayer, false);
        SpellSelection.Instance.RefreshList();
      }
      else
        Client.AskToChangeSpells(this.settingsPlayer);
      this.Cancel();
    }
  }

  public void Cancel()
  {
    Client.sharingWith = "";
    UnityEngine.Object.Destroy((UnityEngine.Object) this.gameObject);
  }

  public void Random()
  {
    if (this.container.childCount == 4)
      return;
    for (int index1 = 0; index1 < 20; ++index1)
    {
      int index2 = UnityEngine.Random.Range(4, this.container.childCount);
      string name = this.container.GetChild(index2).name;
      if (!string.Equals(this.selectedBook, name))
      {
        this.selectedGameObject = this.container.GetChild(index2).gameObject;
        this.PreviewBook(name);
        break;
      }
    }
  }

  public void PreviewBook(string file)
  {
    if (this.selectedBook == file && (double) this.lastClick > (double) Time.realtimeSinceStartup)
    {
      this.Select();
    }
    else
    {
      this.lastClick = Time.realtimeSinceStartup + 0.5f;
      this.selectedBook = file;
      this.selectedFilePath = file;
      if (this.input.gameObject.activeInHierarchy)
      {
        this.input.SetText(Path.GetFileNameWithoutExtension(file));
      }
      else
      {
        try
        {
          using (FileStream fileStream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.None))
          {
            using (myBinaryReader r = new myBinaryReader((Stream) fileStream))
              this.settingsPlayer.Deserialize(r);
          }
        }
        catch (Exception ex)
        {
          this.settingsPlayer = new SettingsPlayer();
        }
        this.buttonDelete.Interactable(true);
        this.buttonRename.Interactable(true);
        this.buttonSelect.Interactable(true);
        this.buttonShare.Interactable(true);
        this.SetSpells();
      }
    }
  }

  private void SetSpells()
  {
    for (int index = 0; index < 16; ++index)
    {
      if (this.settingsPlayer.spells[index] != byte.MaxValue && (int) this.settingsPlayer.spells[index] < Inert.Instance._spells.Length)
      {
        this.spellSlot[index].sprite = !this.settingsPlayer._spells.SeasonsIsHoliday || this.settingsPlayer.spells[index] < (byte) 120 || this.settingsPlayer.spells[index] >= (byte) 132 ? ClientResources.Instance.icons.GetItem((int) this.settingsPlayer.spells[index]).Value : ClientResources.Instance.icons[Inert.Instance.holidaySpells[(int) this.settingsPlayer.spells[index] % 12].name];
        this.spellSlot[index].enabled = true;
        if (Client.viewSpellLocks.ViewLocked() && !Prestige.IsUnlocked(Client.MyAccount, (int) this.settingsPlayer.spells[index]))
        {
          this.restricted[index].gameObject.SetActive(true);
          this.restricted[index].sprite = ClientResources.Instance.imgLocked;
        }
        else
        {
          if (Client.viewSpellLocks.ViewRestricted())
          {
            Restrictions restrictions = Server._restrictions;
            if ((restrictions != null ? (restrictions.CheckRestricted((int) this.settingsPlayer.spells[index]) ? 1 : 0) : 0) != 0)
            {
              this.restricted[index].gameObject.SetActive(true);
              this.restricted[index].sprite = ClientResources.Instance.imgRestricted;
              continue;
            }
          }
          this.restricted[index].gameObject.SetActive(false);
        }
      }
      else
      {
        this.spellSlot[index].enabled = false;
        this.restricted[index].gameObject.SetActive(false);
      }
    }
    if ((int) this.settingsPlayer.fullBook >= ClientResources.Instance.spellBookIcons.Length)
      this.settingsPlayer.fullBook = (byte) 0;
    this.elemental.sprite = ClientResources.Instance.spellBookIcons[(int) this.settingsPlayer.fullBook];
  }

  public void ClickSave()
  {
    string s = this.input.inputText.text.Trim();
    if (string.IsNullOrEmpty(s))
      return;
    this.Save(s);
  }

  private void Save(string s)
  {
    string persistentDataPath = SaveFolder.persistentDataPath;
    char directorySeparatorChar = Path.DirectorySeparatorChar;
    string str1 = directorySeparatorChar.ToString();
    directorySeparatorChar = Path.DirectorySeparatorChar;
    string str2 = directorySeparatorChar.ToString();
    string path1 = persistentDataPath + str1 + "SavedSpells" + str2;
    Global.CheckDirectoryExists(path1, this.subDir + s);
    string path2 = path1 + this.subDir + s + ".spellBook";
    if (string.IsNullOrEmpty(Path.GetFileNameWithoutExtension(path2)))
      return;
    using (FileStream fileStream = new FileStream(path2, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
    {
      using (myBinaryWriter w = new myBinaryWriter((Stream) fileStream))
        this.settingsPlayer.Serialize(w);
    }
    this.Cancel();
  }

  public void OpenFileLocation()
  {
    Global.OpenFileLocation("SavedSpells");
  }

  public void HoverElemental()
  {
    int num = (int) this.settingsPlayer.fullBook - 1;
    this.headerMouseoverSpell.text = num < 0 || num >= ClientResources.Instance.spellBookIcons.Length ? "No Elemental Selected" : "Elemental of " + (object) (BookOf) num;
    this.textMouseoverSpell.text = "Used with the game mode \"Elementals\": Provides the full book along with your chosen 16 spells. It starts with full familiar - you are free to bring a second familiar.";
    this.textMouseoverSpellExtra.text = "";
    this.MouseoverObj.SetActive(true);
  }

  public void Hover(int i)
  {
    if (this.settingsPlayer.spells[i] >= byte.MaxValue || (int) this.settingsPlayer.spells[i] >= Inert.Instance.spells.Count)
      return;
    KeyValuePair<string, Spell> keyValuePair = Inert.Instance.spells.GetItem((int) this.settingsPlayer.spells[i]);
    this.headerMouseoverSpell.text = keyValuePair.Key;
    (this.textMouseoverSpell.text, this.textMouseoverSpellExtra.text) = Descriptions.GetSpellDescription(keyValuePair.Key, (SpellSlot) null, false);
    this.MouseoverObj.SetActive(true);
  }

  public void Leave()
  {
    this.MouseoverObj.SetActive(false);
  }

  public void OnTouch()
  {
  }
}
