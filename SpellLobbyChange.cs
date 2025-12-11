
using Hazel;
using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SpellLobbyChange : MonoBehaviour
{
  internal SettingsPlayer settingsPlayer = new SettingsPlayer();
  [NonSerialized]
  internal BookOf viewingExtraSpells = BookOf.Nothing;
  public PrestigeSpellIcon pfabItem;
  public UIOnHover pfabBook;
  public RectTransform containerItem;
  public RectTransform containerBook;
  [Header("SpellSlots")]
  public SpellSlotButton[] spellSlotbuttons;
  public Image imageElemental;
  [Header("new")]
  public Image bookIcon;
  public ButtonSpell[] buttonSpells;
  public Image imgLocked;
  [Header("Mouser over spell")]
  public GameObject mouserOverPanel;
  public Image mouserOverImage;
  public Image mouserOverFrame;
  public TMP_Text txtHeader;
  public TMP_Text txtDescription;
  public TMP_Text txtExtraText;
  public TMP_Text textError;
  [Header("Center stuff")]
  public RectTransform mainPanel;
  public Image mainBg;
  public Image disableBg;
  public Image disableBg2;
  [Header("Toggle Restrictions")]
  public UIOnHover toggleLocked;
  public UIOnHover toggleRated;
  public UIOnHover toggleSandbox;
  public GameObject buttonViewRestrictions;
  [Header("Prestige")]
  public TMP_Text txtScrollCount;
  public TMP_Text txtMaxScrolls;
  public GameObject buttonPrestige;
  public TMP_Text txtPrestige;
  [Header("Share")]
  public UIOnHover buttonShare;
  internal BookOf openBook;
  private Action<SettingsPlayer> onEnd;
  private Action onCancel;
  internal Validation validating;
  public Image imgHoliday;
  public Image[] imgNormalBook;
  public Image[] imgAltBooks;
  [NonSerialized]
  internal Spell viewingSpellMinion;
  [NonSerialized]
  internal Creature viewingMinion;
  private float alpha;

  public static SpellLobbyChange Instance { get; private set; }

  public static void Create(
    SettingsPlayer sp = null,
    Action<SettingsPlayer> onEnd = null,
    bool center = false,
    Validation validate = Validation.Default,
    bool transparent = false,
    Action onCancel = null)
  {
    Client.viewSpellLocks = (ViewSpellLocks) PlayerPrefs.GetInt("prefviewinglocked", 1);
    Client.sharingWith = "";
    if ((UnityEngine.Object) SpellLobbyChange.Instance != (UnityEngine.Object) null)
    {
      if (sp == null)
        return;
      SpellLobbyChange.Instance.settingsPlayer.CopySpells(sp, false);
      SpellLobbyChange.Instance.RefreshList();
    }
    else
    {
      SpellLobbyChange.Instance = Controller.Instance.CreateAndApply<SpellLobbyChange>(Controller.Instance.spellLobbyChange, Controller.Instance.transform);
      SpellLobbyChange.Instance.validating = validate;
      if (transparent)
      {
        foreach (Image componentsInChild in SpellLobbyChange.Instance.transform.GetComponentsInChildren<Image>())
        {
          if (!componentsInChild.gameObject.CompareTag("PopupNotAlpha"))
          {
            Color color = componentsInChild.color;
            color.a = 0.3f;
            componentsInChild.color = color;
          }
        }
      }
      SpellLobbyChange.Instance.Init(sp, onEnd);
      SpellLobbyChange.Instance.onCancel = onCancel;
      if (center)
        SpellLobbyChange.Instance.Center();
      if ((UnityEngine.Object) LobbyMenu.instance != (UnityEngine.Object) null || (UnityEngine.Object) UnratedMenu.instance != (UnityEngine.Object) null)
        SpellLobbyChange.Instance.buttonShare.gameObject.SetActive(true);
      if (!((UnityEngine.Object) HUD.instance != (UnityEngine.Object) null))
        return;
      SpellLobbyChange.Instance.disableBg2?.gameObject.SetActive(false);
    }
  }

  private void OnDestroy()
  {
    if (!((UnityEngine.Object) SpellLobbyChange.Instance == (UnityEngine.Object) this))
      return;
    SpellLobbyChange.Instance = (SpellLobbyChange) null;
  }

  private void Awake()
  {
    if ((UnityEngine.Object) SpellLobbyChange.Instance == (UnityEngine.Object) null)
      SpellLobbyChange.Instance = this;
    this.toggleLocked.AlwaysOn = Client.viewSpellLocks.ViewLocked();
    this.toggleRated.AlwaysOn = Client.viewSpellLocks.ViewRestricted();
    this.toggleSandbox.AlwaysOn = !Client.viewSpellLocks.ViewLocked() && !Client.viewSpellLocks.ViewRestricted();
    this.buttonViewRestrictions.SetActive(this.toggleRated.AlwaysOn);
    if ((UnityEngine.Object) RatedMenu.instance != (UnityEngine.Object) null)
    {
      this.toggleRated.AlwaysOn = true;
      this.toggleRated.Interactable(false);
    }
    if (this.toggleSandbox.AlwaysOn && Global.GetPrefBool("prefflashsandbox", true))
      this.StartCoroutine(this.Flash((UIOnHoverChild) this.toggleSandbox, Color.white, 1f, 10f));
    this.Refresh(false);
    if (!Prestige.ReadyToPrestige(Client.MyAccount) || !Prestige.AboveRating(Client.MyAccount, 0) || (!this.toggleSandbox.AlwaysOn || !Global.GetPrefBool("prefflashprestige", true)))
      return;
    this.StartCoroutine(this.Flash(this.buttonPrestige.transform.GetChild(0).GetComponent<UIOnHoverChild>(), Color.red, 1f, 10f));
  }

  private IEnumerator Flash(UIOnHoverChild button, Color r2, float f = 1f, float speed = 10f)
  {
    Color r = button.textPressedColor;
    float cur = 0.0f;
    bool up = true;
    while ((double) f > 0.0)
    {
      f -= Time.deltaTime;
      if (up)
      {
        cur += Time.deltaTime * speed;
        if ((double) cur >= 1.0)
        {
          cur = 1f;
          up = false;
        }
      }
      else
      {
        cur -= Time.deltaTime * speed;
        if ((double) cur <= 0.0)
        {
          cur = 0.0f;
          up = true;
        }
      }
      button.GetText.color = Color.Lerp(r, r2, cur);
      yield return (object) null;
    }
    button.GetText.color = button.textPressedColor;
  }

  public void Refresh(bool book = false)
  {
    if (book)
    {
      this.OpenBook(this.openBook);
      this.UpdateElementalIcon();
      this.UpdateHolidaySprites();
      this.CreateHeaders();
    }
    this.txtScrollCount.text = Client.MyAccount.wands.ToString();
    this.txtMaxScrolls.text = "Obtained: " + (object) Client.MyAccount.totalWands + "/" + (object) Prestige.MaxWands(Client.MyAccount);
    bool prestige = Prestige.ReadyToPrestige(Client.MyAccount);
    this.buttonPrestige.SetActive(prestige || Client.MyAccount.prestige > (byte) 0 && (!prestige || Client.MyAccount.prestige < byte.MaxValue));
    this.txtPrestige.text = prestige ? "Prestige" : "Downgrade";
    this.buttonPrestige.GetComponent<UIOnHover>().Interactable(true);
    if (prestige && !Prestige.AboveRating(Client.MyAccount, 0))
    {
      this.buttonPrestige.GetComponent<UIOnHover>().Interactable(false);
      this.txtPrestige.text = Client.MyAccount.HighestRating.ToString() + " / " + (object) Prestige.RequiredRating(Client.MyAccount) + " rating";
    }
    this.RefreshList();
    this.buttonViewRestrictions.SetActive(this.toggleRated.AlwaysOn || !this.toggleRated.interactable);
  }

  public void ClickShare()
  {
    string str = "";
    int[] numArray = new int[(int) (RandomExtensions.LastBook() + 1)];
    int num1 = (int) (RandomExtensions.LastBook() + 1) * 12;
    int num2 = 0;
    for (int index = 0; index < 16; ++index)
    {
      if ((int) this.settingsPlayer.spells[index] < num1)
      {
        ++numArray[(int) this.settingsPlayer.spells[index] / 12];
        num2 += (int) this.settingsPlayer.spells[index];
      }
    }
    for (int index = 0; index < numArray.Length; ++index)
    {
      if (numArray[index] >= 12)
        str = str + "Full " + ((BookOf) index).ToString();
      else if (numArray[index] >= 5)
        str += ((BookOf) index).ToString();
    }
    if (string.IsNullOrEmpty(str))
      str = "Mixed";
    Client.AskToShare(str + (object) num2, ContentType.SpellBook, (object) this.settingsPlayer, false);
  }

  public void ClickHelp()
  {
    Controller.ShowPrestigeMenu();
  }

  public void ClickPrestige()
  {
    if (Prestige.ReadyToPrestige(Client.MyAccount))
    {
      if (Client.MyAccount.prestige < (byte) 2)
        MyMessageBox.Create("Clicking 'Prestige' will reset all your spells to Arcane, Flame Levels 1 & 2, Cogs, and a book of your choosing. Set your wands to 50 and increase your prestige level by 1: giving you the next prestige hat and the ability to unlock all of the books.", (Action) (() => this.Prestiging()), "Prestige!", "Cancel", (Action) null, (Action) null, (Sprite) null, (string) null, (Action) null);
      else
        MyMessageBox.Create("Clicking 'Prestige' will reset all your spells to Arcane, Flame Levels 1 & 2, Cogs, and a book of your choosing. Set your wands to 0 and increase your prestige level by 1: giving you the next prestige hat. You <color=red>CANNOT gain wands in unrated games</color> after the second prestige.", (Action) (() => this.Prestiging()), "Prestige!", "Cancel", (Action) null, (Action) null, (Sprite) null, (string) null, (Action) null);
    }
    else
      MyMessageBox.Create("Clicking 'Downgrade' will decrease your prestige by 1, remove all wands you currently have and unlock all your spells. ONLY do this if you are stuck and cannot gain wands.", (Action) (() => Prestige.Ask((byte) 5, 0)), "Downgrade...", "Cancel", (Action) null, (Action) null, (Sprite) null, (string) null, (Action) null);
  }

  public void Prestiging()
  {
    ElementalSelection.Create((RectTransform) this.transform, this.settingsPlayer._spells, (Action<BookOf>) (b => Prestige.Ask((byte) 4, (int) b)), false, BookOf.Arcane, BookOf.Flame, BookOf.Cogs);
  }

  public void ClickSave()
  {
    ChangeSpellBookMenu.Create(true, this.settingsPlayer, (Action<SettingsPlayer>) null);
  }

  public void ClicOpen()
  {
    ChangeSpellBookMenu.Create(false, this.settingsPlayer, (Action<SettingsPlayer>) (s =>
    {
      this.settingsPlayer.CopySpells(s, false);
      this.RefreshList();
    }));
  }

  private void Center()
  {
    this.mainPanel.anchoredPosition = new Vector2(0.0f, 0.0f);
    this.mainBg.enabled = true;
    this.disableBg.enabled = false;
    this.disableBg2.enabled = false;
  }

  public void ClickToggleLocked()
  {
    this.toggleLocked.AlwaysOn = !this.toggleLocked.AlwaysOn;
    this.toggleSandbox.AlwaysOn = !this.toggleLocked.AlwaysOn && !this.toggleRated.AlwaysOn;
    Client.viewSpellLocks = !this.toggleSandbox.AlwaysOn ? (this.toggleRated.AlwaysOn ? ViewSpellLocks.Locked_Rated_Restricted : ViewSpellLocks.Locked) : ViewSpellLocks.Sandbox;
    PlayerPrefs.SetInt("prefviewinglocked", (int) Client.viewSpellLocks);
    this.Refresh(true);
  }

  public void ClickToggleRated()
  {
    this.toggleRated.AlwaysOn = !this.toggleRated.AlwaysOn;
    this.toggleSandbox.AlwaysOn = !this.toggleLocked.AlwaysOn && !this.toggleRated.AlwaysOn;
    Client.viewSpellLocks = !this.toggleSandbox.AlwaysOn ? (this.toggleLocked.AlwaysOn ? ViewSpellLocks.Locked_Rated_Restricted : ViewSpellLocks.Rated_Restricted) : ViewSpellLocks.Sandbox;
    PlayerPrefs.SetInt("prefviewinglocked", (int) Client.viewSpellLocks);
    this.Refresh(true);
  }

  public void ClickToggleSandbox()
  {
    this.toggleLocked.AlwaysOn = false;
    if (this.toggleRated.interactable)
      this.toggleRated.AlwaysOn = false;
    this.toggleSandbox.AlwaysOn = true;
    Client.viewSpellLocks = ViewSpellLocks.Sandbox;
    PlayerPrefs.SetInt("prefviewinglocked", (int) Client.viewSpellLocks);
    this.Refresh(true);
  }

  internal void Init(SettingsPlayer sp, Action<SettingsPlayer> onEnd)
  {
    SpellLobbyChange.Instance = this;
    this.settingsPlayer.CopySpells(sp ?? Client.settingsPlayer, false);
    this.onEnd = onEnd;
    this.CreateHeaders();
    this.RefreshList();
    for (int i = 0; i < this.spellSlotbuttons.Length; ++i)
      this.spellSlotbuttons[i].Init(i);
    for (int i = 0; i < 12; ++i)
      this.buttonSpells[i].Init(i);
    this.UpdateHolidaySprites();
  }

  public void ToggleMouserOverImage(bool v)
  {
  }

  private void ColorThis(TMP_Text r)
  {
    Color color = r.color;
    color.a = this.alpha;
    r.color = color;
  }

  private void ColorThis(Image r)
  {
    Color color = r.color;
    color.a = this.alpha;
    r.color = color;
  }

  private IEnumerator Fade(bool show)
  {
    if (show)
    {
      this.mouserOverPanel.SetActive(true);
      while ((double) this.alpha < 1.0)
      {
        this.alpha += Time.deltaTime * 4f;
        this.ColorThis(this.txtHeader);
        this.ColorThis(this.txtDescription);
        this.ColorThis(this.textError);
        this.ColorThis(this.mouserOverImage);
        this.ColorThis(this.mouserOverFrame);
        if ((double) this.alpha > 1.0)
          this.alpha = 1f;
        yield return (object) new WaitForEndOfFrame();
      }
    }
    else
    {
      while ((double) this.alpha > 0.0)
      {
        this.alpha -= Time.deltaTime * 4f;
        this.ColorThis(this.txtHeader);
        this.ColorThis(this.txtDescription);
        this.ColorThis(this.textError);
        this.ColorThis(this.mouserOverImage);
        this.ColorThis(this.mouserOverFrame);
        if ((double) this.alpha < 0.0)
          this.alpha = 0.0f;
        yield return (object) new WaitForEndOfFrame();
      }
      this.mouserOverPanel.SetActive(false);
    }
  }

  public void ClickOk()
  {
    if (this.onEnd != null)
    {
      Action<SettingsPlayer> onEnd = this.onEnd;
      if (onEnd != null)
        onEnd(this.settingsPlayer);
      UnityEngine.Object.Destroy((UnityEngine.Object) this.gameObject);
    }
    else
    {
      Client.AskToChangeSpells(this.settingsPlayer);
      UnityEngine.Object.Destroy((UnityEngine.Object) this.gameObject);
    }
  }

  public void ClickCancel()
  {
    Client.sharingWith = "";
    UnityEngine.Object.Destroy((UnityEngine.Object) this.gameObject);
    Action onCancel = this.onCancel;
    if (onCancel == null)
      return;
    onCancel();
  }

  public void ClickElemental()
  {
    ElementalSelection.Create((RectTransform) this.transform, this.settingsPlayer._spells, (Action<BookOf>) (b =>
    {
      this.settingsPlayer.fullBook = (byte) (b + 1);
      this.UpdateElementalIcon();
      this.UpdateHolidaySprites();
    }), true);
  }

  public void CickHoliday()
  {
    this.settingsPlayer._spells.ToggleAlt(BookOf.Seasons, !this.settingsPlayer._spells.UsingAltBook(BookOf.Seasons));
    this.UpdateHolidaySprites();
    if (this.openBook == BookOf.Seasons)
    {
      this.openBook = BookOf.Nothing;
      this.OpenBook(BookOf.Seasons);
    }
    this.RefreshList();
  }

  public void ClickToggleAltBook(int b)
  {
    this.settingsPlayer._spells.ToggleAlt((BookOf) b, !this.settingsPlayer._spells.UsingAltBook((BookOf) b));
    this.UpdateHolidaySprites();
    this.openBook = BookOf.Nothing;
    this.OpenBook((BookOf) b);
    this.RefreshList();
  }

  private void UpdateHolidaySprites()
  {
    for (int b = 0; (BookOf) b < RandomExtensions.LastBook(); ++b)
    {
      this.SetSprite(this.imgNormalBook[b], b, false);
      this.SetSprite(this.imgAltBooks[b], b, true);
    }
  }

  private void SetSprite(Image img, int b, bool reversed)
  {
    if ((UnityEngine.Object) img == (UnityEngine.Object) null)
      return;
    if (!reversed)
      img.sprite = this.settingsPlayer._spells.UsingAltBook((BookOf) b) ? ClientResources.Instance.altSpellBookIcons[b + 1] : ClientResources.Instance.spellBookIcons[b + 1];
    else
      img.sprite = !this.settingsPlayer._spells.UsingAltBook((BookOf) b) ? ClientResources.Instance.altSpellBookIcons[b + 1] : ClientResources.Instance.spellBookIcons[b + 1];
  }

  public void UpdateElementalIcon()
  {
    if ((int) this.settingsPlayer.fullBook >= ClientResources.Instance.spellBookIcons.Length)
      this.settingsPlayer.fullBook = (byte) 0;
    this.imageElemental.sprite = !this.settingsPlayer._spells.UsingAltBook(this.settingsPlayer.Elemental) ? ClientResources.Instance.spellBookIcons[(int) this.settingsPlayer.fullBook] : ClientResources.Instance.altSpellBookIcons[(int) this.settingsPlayer.fullBook];
    int num;
    if (this.settingsPlayer.fullBook > (byte) 0)
    {
      if (!Restrictions.IsElementalRestricted(this.settingsPlayer._spells, (int) this.settingsPlayer.fullBook - 1, (Restrictions) null))
      {
        if (Client.viewSpellLocks.ViewRestricted())
        {
          Restrictions restrictions = Server._restrictions;
          num = restrictions != null ? (restrictions.CheckElemental(this.settingsPlayer._spells, (int) this.settingsPlayer.fullBook - 1) ? 1 : 0) : 0;
        }
        else
          num = 0;
      }
      else
        num = 1;
    }
    else
      num = 0;
    this.imageElemental.transform.GetChild(0).gameObject.SetActive(num != 0);
    if (!Client.viewSpellLocks.ViewLocked() || Prestige.CanUseElemental(Client.MyAccount, (int) this.settingsPlayer.fullBook - 1))
      this.imageElemental.transform.GetChild(1).gameObject.SetActive(false);
    else
      this.imageElemental.transform.GetChild(1).gameObject.SetActive(true);
  }

  public void HoverBook(int i, bool fromHeader = false)
  {
    if (!fromHeader && (UnityEngine.Object) this.viewingMinion != (UnityEngine.Object) null)
    {
      this.ShowDescription(this.viewingSpellMinion.name, -1);
    }
    else
    {
      if (this.settingsPlayer._spells.UsingAltBook((BookOf) i))
      {
        this.txtHeader.text = i == 0 ? "Corrupted Arcane" : "Book of " + ((BookOf) i).ToStringX(true);
        this.txtDescription.text = Descriptions.GetBookHeader((BookOf) i, true) + "\nFamiliar - " + Descriptions.GetBookDescription((BookOf) i, true);
        this.ToggleMouserOverImage(true);
      }
      else
      {
        this.txtHeader.text = i == 0 ? "Arcane Book" : "Book of " + ((BookOf) i).ToStringX(false);
        this.txtDescription.text = Descriptions.GetBookHeader((BookOf) i, false) + "\nFamiliar - " + Descriptions.GetBookDescription((BookOf) i, false);
        this.ToggleMouserOverImage(true);
      }
      if (Client.viewSpellLocks.ViewLocked() && !Prestige.IsUnlocked(Client.MyAccount, (BookOf) i))
      {
        if (Client.MyAccount.prestige == (byte) 0 && i >= 9)
        {
          if (i == 9)
            this.txtDescription.text += "\n<color=red>Unlocked at the first prestige.";
          else
            this.txtDescription.text += "\n<color=red>Requires the first prestige and</color> 5 <color=red>wands.";
        }
        else
        {
          TMP_Text txtDescription = this.txtDescription;
          txtDescription.text = txtDescription.text + "\n" + (Prestige.CanUnlock(Client.MyAccount, (BookOf) i) == 0 ? "<color=green>Buy with</color> 5 <color=green>wands." : "<color=red>Requires</color> 5 <color=red>wands.");
        }
      }
      this.txtExtraText.text = "";
      if (this.viewingExtraSpells != BookOf.Nothing)
        this.textError.text = "Click to view the regular spellbook";
      else
        this.textError.text = "<br><color=#0093FF>Right-Click to see this book's familiar spells</color>";
    }
  }

  public void PostClickBook()
  {
    this.HoverBook((int) this.openBook, false);
  }

  public void HoverBook2()
  {
    if ((UnityEngine.Object) this.viewingMinion != (UnityEngine.Object) null)
      this.textError.text = "";
    else if (this.viewingExtraSpells != BookOf.Nothing)
      this.textError.text = "Click to view the regular spellbook";
    else
      this.textError.text = "Left-Click to equip all available spells<br><color=#0093FF>Right-Click to see this book's familiar spells</color>";
  }

  public void ClickRestrictions()
  {
    PopupRestrictions.Create(Server._restrictions, Client.MyAccount.accountType.isDev() && Client.isConnected);
  }

  public void HoverSpell(string n, int myRealIndex)
  {
    this.txtHeader.text = n;
    (this.txtDescription.text, this.txtExtraText.text) = Descriptions.GetSpellDescription(n, (SpellSlot) null, false);
    this.ToggleMouserOverImage(true);
  }

  public void Hover(string s)
  {
    MyToolTip.Show(s, -1f, false);
  }

  public void HoverLeave()
  {
    MyToolTip.Close();
  }

  public void HideMouseOver()
  {
    this.ToggleMouserOverImage(false);
  }

  public void CreateHeaders()
  {
    int num1 = 0;
    int num2 = -6;
    int length = (int) (RandomExtensions.LastBook() + 1);
    this.containerBook.DestroyChildern();
    this.imgNormalBook = new Image[length];
    for (int index = 0; index < length; ++index)
    {
      UIOnHover uiOnHover = UnityEngine.Object.Instantiate<UIOnHover>(this.pfabBook, (Transform) this.containerBook);
      ((RectTransform) uiOnHover.transform).anchoredPosition = new Vector2((float) num1, (float) num2);
      uiOnHover.GetComponent<Image>().sprite = ClientResources.Instance.spellBookIcons[index + 1];
      UIOnHover component = uiOnHover.GetComponent<UIOnHover>();
      int e = index;
      component.onEnter.AddListener((UnityAction) (() => this.HoverBook(e, true)));
      component.onClick.AddListener((UnityAction) (() =>
      {
        this.OpenBook((BookOf) e);
        this.PostClickBook();
      }));
      component.onRightClick.AddListener((UnityAction) (() =>
      {
        this.OpenExtraSpells((BookOf) e);
        this.PostClickBook();
      }));
      num1 += 60;
      uiOnHover.gameObject.SetActive(true);
      this.imgNormalBook[index] = uiOnHover.GetComponent<Image>();
      if (Client.viewSpellLocks.ViewLocked() && !Prestige.IsUnlocked(Client.MyAccount, (BookOf) index))
      {
        uiOnHover.transform.GetChild(0).GetComponent<Image>().sprite = Prestige.CanUnlock(Client.MyAccount, (BookOf) index) == 0 ? ClientResources.Instance.imgBuyable : ClientResources.Instance.imgLocked;
        uiOnHover.transform.GetChild(0).gameObject.SetActive(true);
      }
    }
  }

  public void OpenMinion(Spell s, Creature minion)
  {
    this.viewingSpellMinion = s;
    this.viewingExtraSpells = BookOf.Nothing;
    this.viewingMinion = minion;
    this.bookIcon.sprite = ClientResources.Instance.GetSpellIcon(s.name);
    this.ResizeBookIcon(2.5f);
    for (int index = 0; index < minion.spells.Count && index < 12; ++index)
    {
      this.buttonSpells[index].SetSprite(ClientResources.Instance.icons[minion.spells[index].spell.name], 1, false, true, index);
      this.buttonSpells[index].gameObject.SetActive(true);
    }
    for (int count = minion.spells.Count; count < 11; ++count)
      this.buttonSpells[count].gameObject.SetActive(false);
    this.buttonSpells[11].SetSprite(ClientResources.Instance.icons["Banish"], 1, false, true, 11);
    this.buttonSpells[11].gameObject.SetActive(true);
  }

  public static Spell GetFamiliarSpell(int index)
  {
    int num = 0;
    BookOf openBook = SpellLobbyChange.Instance.openBook;
    SettingsPlayer settingsPlayer = SpellLobbyChange.Instance.settingsPlayer;
    foreach (Spell familiarSpell in ClientResources.Instance.familiarSpells)
    {
      if (familiarSpell.bookOf == openBook && settingsPlayer._spells.UsingAltBook(openBook) == familiarSpell.altBook)
      {
        if (num == index)
          return familiarSpell;
        ++num;
      }
    }
    return ClientResources.Instance.familiarSpells[0];
  }

  public void OpenExtraSpells(BookOf b)
  {
    this.openBook = b;
    this.OpenExtraSpells();
  }

  public void OpenExtraSpells()
  {
    if (this.viewingExtraSpells == this.openBook)
    {
      this.OpenBook(this.openBook);
      this.PostClickBook();
      this.HoverBook2();
    }
    else
    {
      this.viewingExtraSpells = this.openBook;
      this.viewingMinion = (Creature) null;
      int index = 0;
      this.bookIcon.sprite = !this.settingsPlayer._spells.UsingAltBook(this.openBook) ? ClientResources.Instance.spellBookIcons[(int) (this.openBook + 1)] : ClientResources.Instance.altSpellBookIcons[(int) (this.openBook + 1)];
      this.ResizeBookIcon(1f);
      foreach (Spell familiarSpell in ClientResources.Instance.familiarSpells)
      {
        if (familiarSpell.bookOf == this.openBook && this.settingsPlayer._spells.UsingAltBook(this.openBook) == familiarSpell.altBook)
        {
          this.buttonSpells[index].SetSprite(ClientResources.Instance.icons[familiarSpell.name], 1, false, true, index);
          this.buttonSpells[index].gameObject.SetActive(true);
          ++index;
        }
      }
      for (; index < 11; ++index)
        this.buttonSpells[index].gameObject.SetActive(false);
      this.buttonSpells[11].SetSprite(ClientResources.Instance.icons["Banish"], 1, false, true, 11);
      this.buttonSpells[11].gameObject.SetActive(true);
      this.PostClickBook();
      this.HoverBook2();
    }
  }

  public void ResizeBookIcon(float scale = 1f)
  {
    Sprite sprite = this.bookIcon.sprite;
    RectTransform rectTransform = this.bookIcon.rectTransform;
    Rect rect = sprite.rect;
    double num1 = (double) rect.width * (double) scale;
    rect = sprite.rect;
    double num2 = (double) rect.height * (double) scale;
    Vector2 vector2 = new Vector2((float) num1, (float) num2);
    rectTransform.sizeDelta = vector2;
  }

  public void OpenBook(BookOf b)
  {
    if (this.openBook != b || (UnityEngine.Object) this.viewingMinion != (UnityEngine.Object) null || this.viewingExtraSpells != BookOf.Nothing)
    {
      this.bookIcon.sprite = !this.settingsPlayer._spells.UsingAltBook(b) ? ClientResources.Instance.spellBookIcons[(int) (b + 1)] : ClientResources.Instance.altSpellBookIcons[(int) (b + 1)];
      this.openBook = b;
      this.ResizeBookIcon(1f);
    }
    this.viewingMinion = (Creature) null;
    this.viewingExtraSpells = BookOf.Nothing;
    int index1 = (int) b * 12;
    int num = index1 + 12;
    if (this.settingsPlayer._spells.UsingAltBook(b))
    {
      int index2 = 0;
      while (index1 < num)
      {
        Spell altSpell = Inert.Instance.altSpells[index1];
        bool equipped = this.HasSpell((byte) index2);
        this.buttonSpells[index2].SetSprite(ClientResources.Instance.icons[altSpell.name], altSpell.level, equipped, equipped || this.settingsPlayer.CanEquipSpell(15, (byte) (index2 + (int) this.openBook * 12)), index1);
        this.buttonSpells[index2].gameObject.SetActive(true);
        ++index1;
        ++index2;
      }
    }
    else
    {
      int index2 = 0;
      while (index1 < num)
      {
        Spell spell = Inert.Instance.spells.GetItem(index1).Value;
        bool equipped = this.HasSpell((byte) index2);
        this.buttonSpells[index2].SetSprite(ClientResources.Instance.icons[spell.name], spell.level, equipped, equipped || this.settingsPlayer.CanEquipSpell(15, (byte) (index2 + (int) this.openBook * 12)), index1);
        this.buttonSpells[index2].gameObject.SetActive(true);
        ++index1;
        ++index2;
      }
    }
    if (!((UnityEngine.Object) this.imgLocked != (UnityEngine.Object) null))
      return;
    if (!Client.viewSpellLocks.ViewLocked() || Prestige.IsUnlocked(Client.MyAccount, b))
    {
      this.imgLocked.gameObject.SetActive(false);
    }
    else
    {
      this.imgLocked.sprite = Prestige.CanUnlock(Client.MyAccount, b) == 0 ? ClientResources.Instance.imgBuyable : ClientResources.Instance.imgLocked;
      this.imgLocked.gameObject.SetActive(true);
    }
  }

  public void ClickFullBook()
  {
    if ((UnityEngine.Object) this.viewingMinion != (UnityEngine.Object) null || this.viewingExtraSpells != BookOf.Nothing)
    {
      this.OpenBook(this.openBook);
      this.HoverBook((int) this.openBook, false);
    }
    else if (Client.viewSpellLocks.ViewLocked() && !Prestige.IsUnlocked(Client.MyAccount, this.openBook))
    {
      int i = Prestige.CanUnlock(Client.MyAccount, this.openBook);
      if (i == 0)
        MyMessageBox.Create("Buy the Book of " + this.openBook.ToStringX(false) + " with 5 wands?", (Action) (() => Prestige.AskUnlock(this.openBook)), "Ok", "Cancel", (Action) null, (Action) null, (Sprite) null, (string) null, (Action) null);
      else
        MyToolTip.Show(Prestige.BookErrorCode(i), 5f, false);
    }
    else
    {
      int length = this.settingsPlayer.spells.Length;
      for (int index = 0; index < this.settingsPlayer.spells.Length && index < 12; ++index)
      {
        if (this.settingsPlayer.spells[index] != byte.MaxValue)
          --length;
      }
      for (int index = 0; index < 12 && index < length; ++index)
      {
        if (!SpellLobbyChange.Instance.HasSpell((byte) index))
          this.buttonSpells[index].UpdatedFromSpellSelection_FullBook();
        else
          ++length;
      }
    }
  }

  public void HoverFullBook()
  {
    this.HoverBook((int) this.openBook, false);
  }

  public void RefreshList()
  {
    if (this.validating == Validation.Default)
    {
      for (int index = 0; index < 16; ++index)
      {
        if (!this.settingsPlayer.CanEquipSpell(index, this.settingsPlayer.spells[index]) && this.settingsPlayer.spells[index] != byte.MaxValue)
        {
          this.RemoveSpellSlot(index, false);
          --index;
        }
      }
    }
    else if (this.validating == Validation.Level3Only)
    {
      for (int index = 0; index < 16; ++index)
      {
        if (!this.settingsPlayer.CanEquipSpellLevel3Only(index, this.settingsPlayer.spells[index]) && this.settingsPlayer.spells[index] != byte.MaxValue)
        {
          this.RemoveSpellSlot(index, false);
          --index;
        }
      }
    }
    for (int index = 0; index < 16; ++index)
    {
      if (this.settingsPlayer.spells[index] != byte.MaxValue)
      {
        if (this.settingsPlayer._spells.IsAlt((int) this.settingsPlayer.spells[index]))
          this.spellSlotbuttons[index].SetSprite(ClientResources.Instance.icons[Inert.Instance.altSpells[(int) this.settingsPlayer.spells[index]].name], (int) this.settingsPlayer.spells[index]);
        else
          this.spellSlotbuttons[index].SetSprite(ClientResources.Instance.icons.GetItem((int) this.settingsPlayer.spells[index]).Value, (int) this.settingsPlayer.spells[index]);
      }
      else
        this.spellSlotbuttons[index].Empty();
    }
    this.OpenBook(this.openBook);
    this.UpdateElementalIcon();
    if (this.imgNormalBook == null || this.imgNormalBook.Length == 0)
      this.CreateHeaders();
    this.UpdateHolidaySprites();
  }

  public bool HasSpell(byte spellID)
  {
    spellID += (byte) ((uint) this.openBook * 12U);
    for (int index = 0; index < 16; ++index)
    {
      if ((int) this.settingsPlayer.spells[index] == (int) spellID)
        return true;
    }
    return false;
  }

  public bool AddSpell(byte spellID)
  {
    spellID += (byte) ((uint) this.openBook * 12U);
    for (int index = 0; index < 16; ++index)
    {
      if (this.settingsPlayer.spells[index] == byte.MaxValue)
      {
        if (!this.settingsPlayer.CanEquipSpell(index, spellID))
          return false;
        for (; index > 0 && (int) this.settingsPlayer.spells[index - 1] > (int) spellID; --index)
          this.settingsPlayer.spells[index] = this.settingsPlayer.spells[index - 1];
        this.settingsPlayer.spells[index] = spellID;
        this.RefreshList();
        return true;
      }
    }
    return false;
  }

  public void RemoveSpell(byte spellID)
  {
    spellID += (byte) ((uint) this.openBook * 12U);
    for (int i = 0; i < 16; ++i)
    {
      if ((int) this.settingsPlayer.spells[i] == (int) spellID)
      {
        this.RemoveSpellSlot(i, true);
        break;
      }
    }
  }

  public void RemoveSpellSlot(int i, bool refresh)
  {
    for (; i < 15 && this.settingsPlayer.spells[i + 1] < byte.MaxValue; ++i)
      this.settingsPlayer.spells[i] = this.settingsPlayer.spells[i + 1];
    this.settingsPlayer.spells[i] = byte.MaxValue;
    if (!refresh)
      return;
    this.RefreshList();
  }

  public void ClearSpells()
  {
    for (int index = 0; index < this.settingsPlayer.spells.Length; ++index)
      this.settingsPlayer.spells[index] = byte.MaxValue;
    this.settingsPlayer.spells[0] = (byte) 4;
    this.RefreshList();
  }

  public void HoverSpellSlot(int i)
  {
    if (this.settingsPlayer.spells[i] >= byte.MaxValue || (int) this.settingsPlayer.spells[i] >= Inert.Instance._spells.Length)
      return;
    this.textError.text = "";
    if (this.settingsPlayer._spells.IsAlt((int) this.settingsPlayer.spells[i]))
      this.ShowDescription(Inert.Instance.altSpells[(int) this.settingsPlayer.spells[i]].name, (int) this.settingsPlayer.spells[i]);
    else
      this.ShowDescription(Inert.Instance.spells.GetItem((int) this.settingsPlayer.spells[i]).Key, (int) this.settingsPlayer.spells[i]);
    this.ToggleMouserOverImage(true);
  }

  public void ShowDescription(string s, int myRealIndex)
  {
    this.txtHeader.text = !((UnityEngine.Object) this.viewingMinion != (UnityEngine.Object) null) ? s : ClickSpell.GetSpellNameUI(s, Inert.GetSpell(s), this.viewingMinion);
    (this.txtDescription.text, this.txtExtraText.text) = Descriptions.GetSpellDescription(s, (SpellSlot) null, false);
    this.textError.text += this.GetIsMinionSpell(s);
    this.ToggleMouserOverImage(true);
  }

  public string GetIsMinionSpell(string spell)
  {
    Spell spell1 = Inert.GetSpell(spell);
    return (UnityEngine.Object) spell1 == (UnityEngine.Object) null || (UnityEngine.Object) spell1.toSummon == (UnityEngine.Object) null || (!((UnityEngine.Object) spell1.toSummon?.GetComponent<Creature>() != (UnityEngine.Object) null) || !spell1.IsMinionSpell()) ? "" : "<br><color=#0093FF>Right-Click to see this minions spells</color>";
  }

  public void LeaveSpell()
  {
    if (Global.OS.Is(OperatingSystem.Android))
      return;
    this.txtHeader.text = "";
    this.txtDescription.text = "";
    this.txtExtraText.text = "";
    this.textError.text = "";
    this.ToggleMouserOverImage(false);
  }
}
