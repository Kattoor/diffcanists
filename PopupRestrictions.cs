
using Hazel;
using System;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PopupRestrictions : MonoBehaviour
{
  private List<Image> pool = new List<Image>();
  private List<UIOnHover> buttons = new List<UIOnHover>();
  private List<Image> ele = new List<Image>();
  private List<UIOnHover> ele_buttons = new List<UIOnHover>();
  private Restrictions restrictions;
  public Image pfabImage;
  public Image pfabBook;
  public RectTransform containerBook;
  public RectTransform containerElementals;
  public RectTransform container;
  public TMP_Dropdown dropSpellType;
  public TMP_Dropdown dropCastType;
  public GameObject panelOptions;
  public GameObject butApply;
  private bool editing;

  public static PopupRestrictions Instance { get; private set; }

  public static void Create(Restrictions r, bool edit = false)
  {
    if ((UnityEngine.Object) PopupRestrictions.Instance != (UnityEngine.Object) null)
      return;
    PopupRestrictions andApply = Controller.Instance.CreateAndApply<PopupRestrictions>(Controller.Instance.dialogRestrictions, Controller.Instance.transform);
    andApply.restrictions = new Restrictions();
    if (r != null)
      andApply.restrictions.Copy(r);
    andApply.editing = edit;
    andApply.butApply.SetActive(false);
    andApply.Init();
    andApply.CreateHeaders();
    andApply.CreateElementals();
  }

  public void UpdateData(Restrictions r)
  {
    this.restrictions.Copy(r);
    for (int index = 0; index < this.pool.Count; ++index)
      this.SpellEnabled(index, this.restrictions.availableSpells[index]);
    for (int index = 0; index < this.ele.Count; ++index)
      this.ElementalEnabled(index, (uint) (this.restrictions.elementals & 1 << index) > 0U);
  }

  private void Edited()
  {
    this.butApply.SetActive(true);
  }

  private void Awake()
  {
    PopupRestrictions.Instance = this;
  }

  private void OnDestroy()
  {
    if (!((UnityEngine.Object) PopupRestrictions.Instance == (UnityEngine.Object) this))
      return;
    PopupRestrictions.Instance = (PopupRestrictions) null;
  }

  private void Update()
  {
    if (!Input.GetKeyDown(KeyCode.F12) || !Client.MyAccount.accountType.isDev())
      return;
    MyContextMenu myContextMenu = MyContextMenu.Show();
    myContextMenu.AddItem("Send Restrictions", (Action) (() =>
    {
      if (Server._restrictions == null)
        Server._restrictions = new Restrictions();
      Server._restrictions.Copy(this.restrictions);
      Client.connection.SendBytes(ClientResources.SerializeRestricitons(), SendOption.None);
      ChatBox.SystemMessage("Restrictions Sent");
    }), (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
    myContextMenu.AddItem("Random Restrictions", (Action) (() => this.SendRandomRestrictions(false, false)), (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
    myContextMenu.AddItem("Casino Restrictions", (Action) (() => this.SendRandomRestrictions(false, true)), (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
    myContextMenu.AddSeperator("--------------------------");
    myContextMenu.AddItem("Retrieve Random", (Action) (() => this.SendRandomRestrictions(true, false)), (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
    myContextMenu.AddItem("Retrieve Casino", (Action) (() => this.SendRandomRestrictions(true, true)), (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
    myContextMenu.Rebuild(false);
  }

  public void SendRandomRestrictions(bool retrieve, bool casino)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter w = new myBinaryWriter((Stream) memoryStream))
      {
        w.Write((byte) 106);
        if (retrieve)
          w.Write(-1);
        else if (!this.restrictions.AnyRestricted())
          w.Write(0);
        else
          w.Write(1);
        w.Write(casino);
        this.restrictions.Serialize(w);
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
      if (retrieve)
        ChatBox.SystemMessage("Retrieving..." + (casino ? "Casino" : "Random") + " restrictions");
      else
        ChatBox.SystemMessage((casino ? "Casino" : "Random") + " Restrictions Sent");
    }
  }

  public void Close()
  {
    UnityEngine.Object.Destroy((UnityEngine.Object) this.gameObject);
  }

  public void ClickApply()
  {
    Client.AskRestrictions(this.restrictions);
    this.Close();
  }

  private void Start()
  {
    if (!this.editing)
    {
      this.panelOptions.SetActive(false);
    }
    else
    {
      List<TMP_Dropdown.OptionData> optionDataList1 = new List<TMP_Dropdown.OptionData>();
      optionDataList1.Add(new TMP_Dropdown.OptionData("Spell type..."));
      foreach (SpellType spellType in (SpellType[]) Enum.GetValues(typeof (SpellType)))
        optionDataList1.Add(new TMP_Dropdown.OptionData(spellType.ToString()));
      this.dropSpellType.options = optionDataList1;
      List<TMP_Dropdown.OptionData> optionDataList2 = new List<TMP_Dropdown.OptionData>();
      optionDataList2.Add(new TMP_Dropdown.OptionData("Cast type..."));
      foreach (CastType castType in (CastType[]) Enum.GetValues(typeof (CastType)))
        optionDataList2.Add(new TMP_Dropdown.OptionData(castType.ToString()));
      this.dropCastType.options = optionDataList2;
      this.dropSpellType.onValueChanged.AddListener(new UnityAction<int>(this.OnSpellType));
      this.dropCastType.onValueChanged.AddListener(new UnityAction<int>(this.OnCastType));
    }
  }

  public void ClickToggleAll()
  {
    if (!this.editing)
      return;
    if (this.restrictions.availableSpells[0])
      this.ClickDisableAll();
    else
      this.ClickEnableAll();
    this.Edited();
  }

  public void ClickDisableAll()
  {
    this.restrictions.availableSpells.ResetAll();
    for (int index = 0; index < this.pool.Count; ++index)
      this.SpellEnabled(index, false);
  }

  public void ClickEnableAll()
  {
    this.restrictions.availableSpells.SetAll();
    for (int index = 0; index < this.pool.Count; ++index)
      this.SpellEnabled(index, true);
  }

  public void OnSpellType(int i)
  {
    if (i != 0)
      this.dropSpellType.SetValueWithoutNotify(0);
    if (!this.editing)
      return;
    this.restrictions.ToggleSpellType(i);
    this.Edited();
  }

  public void OnCastType(int i)
  {
    if (i != 0)
      this.dropCastType.SetValueWithoutNotify(0);
    if (!this.editing)
      return;
    this.restrictions.ToggleCastType(i);
    this.Edited();
  }

  public int ParseInt(string s, int def)
  {
    int result;
    return int.TryParse(s, out result) ? result : def;
  }

  public float ParseFloat(string s, float def)
  {
    float result;
    return float.TryParse(s, out result) ? result : def;
  }

  public void CreateHeaders()
  {
    int num1 = 5;
    int num2 = 0;
    int num3 = (int) (RandomExtensions.LastBook() + 1);
    for (int index = 0; index < num3; ++index)
    {
      Image image = UnityEngine.Object.Instantiate<Image>(this.pfabBook, (Transform) this.containerBook);
      ((RectTransform) image.transform).anchoredPosition = new Vector2((float) num1, (float) num2);
      image.sprite = ClientResources.Instance.spellBookIcons[index + 1];
      UIOnHover component = image.GetComponent<UIOnHover>();
      int e = index;
      component.onEnter.AddListener((UnityAction) (() => this.Hover("Book of " + ((BookOf) e).ToString())));
      component.onClick.AddListener((UnityAction) (() =>
      {
        if (!this.editing)
          return;
        this.restrictions.ToggleBook(e);
        this.Edited();
      }));
      num1 += 42;
      image.gameObject.SetActive(true);
    }
  }

  public void CreateElementals()
  {
    int num1 = 5;
    int num2 = 0;
    int num3 = (int) (RandomExtensions.LastBook() + 1);
    for (int index = 0; index < num3; ++index)
    {
      Image image = UnityEngine.Object.Instantiate<Image>(this.pfabBook, (Transform) this.containerElementals);
      ((RectTransform) image.transform).anchoredPosition = new Vector2((float) num1, (float) num2);
      image.sprite = ClientResources.Instance.spellBookIcons[index + 1];
      UIOnHover component = image.GetComponent<UIOnHover>();
      int e = index;
      component.onEnter.AddListener((UnityAction) (() => this.Hover(((BookOf) e).ToString() + " Elemental")));
      component.onClick.AddListener((UnityAction) (() =>
      {
        if (!this.editing)
          return;
        this.restrictions.ToggleElemental(e);
        this.Edited();
      }));
      num1 += 42;
      image.gameObject.SetActive(true);
      this.ele.Add(image);
      this.ele_buttons.Add(component);
      this.ElementalEnabled(e, (uint) (this.restrictions.elementals & 1 << e) > 0U);
    }
  }

  private void Init()
  {
    int num1 = 0;
    int num2 = (int) (RandomExtensions.LastBook() + 1) * 12;
    int num3 = 5;
    int num4 = -5;
    for (int index = 0; index < num2; ++index)
    {
      Image g = UnityEngine.Object.Instantiate<Image>(this.pfabImage, (Transform) this.container);
      UIOnHover component = g.GetComponent<UIOnHover>();
      g.rectTransform.anchoredPosition = new Vector2((float) num3, (float) num4);
      g.sprite = ClientResources.Instance._spellicons[index];
      int e = index;
      component.onClick.AddListener((UnityAction) (() =>
      {
        if (!this.editing)
          return;
        this.restrictions.ToggleSpell(e);
        this.Edited();
      }));
      component.onEnter.AddListener((UnityAction) (() => this.Hover(g.sprite.name)));
      g.gameObject.SetActive(true);
      this.pool.Add(g);
      this.buttons.Add(component);
      this.SpellEnabled(index, this.restrictions.availableSpells[index]);
      ++num1;
      if (index % 12 == 11)
      {
        num3 += 42;
        num4 = -5;
      }
      else
        num4 -= 42;
    }
  }

  public void SpellEnabled(int index, bool v)
  {
    this.pool[index].color = v ? Color.white : new Color(1f, 1f, 1f, 0.15f);
    this.buttons[index].NormalColor = this.pool[index].color;
  }

  public void ElementalEnabled(int index, bool v)
  {
    this.ele[index].color = v ? Color.white : new Color(1f, 1f, 1f, 0.15f);
    this.ele_buttons[index].NormalColor = this.pool[index].color;
  }

  public void Hover(string s)
  {
    MyToolTip.Show(s, -1f);
  }

  public void HoverLeave()
  {
    MyToolTip.Close();
  }
}
