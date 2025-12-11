
using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class StoreMenu : MonoBehaviour
{
  private static ArcanistsStore curStore = (ArcanistsStore) null;
  private static bool holdScroll = false;
  public static float scrollPos = 1f;
  public TMP_Text txtCrystals;
  public TMP_Text txtTomatoes;
  public TMP_Text testServer;
  [Header("Arcanists")]
  public ButtonArcanistsStore pfabItem;
  public GameObject panelArc;
  public RectTransform containerStore;
  [Header("Steam")]
  public ButtonSteamStore[] steamButtons;
  public GameObject panelSteam;
  public Sprite spriteCrystal;
  public TMP_Text startedFromSteam;
  public ScrollRect scrollRect;

  public static StoreMenu Instance { get; private set; }

  private void Awake()
  {
    StoreMenu.Instance = this;
    this.txtCrystals.SetText(Client.MyAccount.dust.ToString(), true);
    if (Client.MyAccount.tomatoes > 0)
    {
      this.txtTomatoes.SetText(Client.MyAccount.tomatoes.ToString(), true);
      this.txtTomatoes.transform.parent.gameObject.SetActive(true);
    }
    this.startedFromSteam.gameObject.SetActive(!SteamManager.startedFromSteam);
    this.testServer.gameObject.SetActive(false);
  }

  private void OnDestroy()
  {
    if (!((UnityEngine.Object) StoreMenu.Instance == (UnityEngine.Object) this))
      return;
    StoreMenu.Instance = (StoreMenu) null;
  }

  private void Start()
  {
    for (int index = 0; index < this.steamButtons.Length; ++index)
    {
      int e = index;
      Controller.Instance.ApplyScheme(this.steamButtons[index].gameObject);
      this.steamButtons[index].Setup(SteamStore.items[index]);
      this.steamButtons[index].uiOnHover.onClick.AddListener((UnityAction) (() => this.BuyCrystals(e)));
    }
    if (StoreMenu.curStore == null)
    {
      this.ClickBuyCrystals();
    }
    else
    {
      this._clickedArcButton();
      this._PopulateStore(StoreMenu.curStore);
      this.scrollRect.verticalScrollbar.SetValueWithoutNotify(StoreMenu.scrollPos);
      this.scrollRect.verticalNormalizedPosition = StoreMenu.scrollPos;
    }
    this.scrollRect.verticalScrollbar.onValueChanged.AddListener(new UnityAction<float>(this.OnScroll));
  }

  public void ClickClose()
  {
    UnityEngine.Object.Destroy((UnityEngine.Object) this.gameObject);
  }

  public void ClickTomatoes()
  {
    this._clickedArcButton();
    this._PopulateStore(Store.Instance.tomatoes);
  }

  public void ClickPets()
  {
    this._clickedArcButton();
    this._PopulateStore(Store.Instance.pets);
  }

  public void ClickMonsters()
  {
    this._clickedArcButton();
    this._PopulateStore(Store.Instance.monsters);
  }

  public void ClickSpellSkins()
  {
    this._clickedArcButton();
    this._PopulateStore(Store.Instance.spellSkins);
  }

  public void ClickPlayerAnimations()
  {
    this._clickedArcButton();
    this._PopulateStore(Store.Instance.playerAnimation);
  }

  public void ClickIcons()
  {
    this._clickedArcButton();
    this._PopulateStore(Store.Instance.icons);
  }

  public void Refresh()
  {
    if (StoreMenu.curStore == null)
      return;
    this._PopulateStore(StoreMenu.curStore);
  }

  private void _PopulateStore(ArcanistsStore x)
  {
    StoreMenu.curStore = x;
    StoreMenu.holdScroll = true;
    this.containerStore.DestroyChildern();
    int i = 0;
    BoughtStoreItems storeItems = Client.MyAccount.storeItems;
    SerializedActiveItem activeItems = Client.MyAccount.activeItems;
    foreach (ArcanistsStore.Item x1 in x.items)
    {
      ButtonArcanistsStore buttonArcanistsStore = UnityEngine.Object.Instantiate<ButtonArcanistsStore>(this.pfabItem, (Transform) this.containerStore);
      bool isUnlocked = storeItems.IsUnlocked(x.which, i);
      bool isActive = activeItems.FindIndex(closure_0 ?? (closure_0 = (Predicate<ActiveItem>) (z => z.which == x.which && z.index == i))) > -1;
      buttonArcanistsStore.Setup(x1, x.which, i, isUnlocked, isActive);
      buttonArcanistsStore.gameObject.SetActive(true);
      int e = i;
      if (!isUnlocked)
        buttonArcanistsStore.button.onRightClick.AddListener((UnityAction) (() => this.BuyArcanistsItem(e, x.which)));
      else
        buttonArcanistsStore.button.onRightClick.AddListener((UnityAction) (() => this.RightClickItem(e, x.which)));
      if (!isUnlocked)
        buttonArcanistsStore.button.onClick.AddListener((UnityAction) (() => this.BuyArcanistsItem(e, x.which)));
      else
        buttonArcanistsStore.button.onClick.AddListener((UnityAction) (() => Prestige.Ask((byte) 16, (int) x.which, e, Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))));
      ++i;
    }
    StoreMenu.holdScroll = false;
  }

  public void OnScroll(float v)
  {
    if (StoreMenu.holdScroll)
      return;
    StoreMenu.scrollPos = v;
  }

  public void SetScrollPosition()
  {
    this.scrollRect.verticalNormalizedPosition = 0.0f;
  }

  private void _clickedArcButton()
  {
    this.panelSteam.SetActive(false);
    this.panelArc.SetActive(true);
  }

  public void ClickBuyCrystals()
  {
    StoreMenu.curStore = (ArcanistsStore) null;
    this.panelSteam.SetActive(true);
    this.panelArc.SetActive(false);
  }

  public void BuyArcanistsItem(int itemIndex, ArcanistsStore.Which which)
  {
    ArcanistsStore.Item item = Store.Instance.Get(which)[itemIndex];
    if (which == ArcanistsStore.Which.SpellSkin)
      MyMessageBox.Create("Buy <#FF0000>" + item.name + "</color> for <#00FFFF>" + (object) item.cost + "</color> crystals?", (Action) (() => Prestige.Ask((byte) 12, (int) which, itemIndex)), "Ok", "Cancel", (Action) null, (Action) null, item.sprite, "Preview", (Action) (() =>
      {
        if ((UnityEngine.Object) MainMenu.Instance == (UnityEngine.Object) null)
        {
          MyMessageBox.Create("Sorry, you can only preview skins from the main menu!", (Action) null, "Ok", "Cancel", (Action) null, (Action) null, (Sprite) null, (string) null, (Action) null);
        }
        else
        {
          Client.previewItem = item;
          Client._gameFacts = new GameFacts();
          Client.joinedFrom = Client.JoinLocation.Store;
          Controller.Instance.InitMap(true, false, true);
          DiscordIntergration.Instance?.UpdateActivitySandbox();
        }
      }));
    else
      MyMessageBox.Create("Buy <#FF0000>" + item.name + "</color> for <#00FFFF>" + (object) item.cost + "</color> crystals?", (Action) (() => Prestige.Ask((byte) 12, (int) which, itemIndex)), "Ok", "Cancel", (Action) null, (Action) null, item.sprite, (string) null, (Action) null);
  }

  public void RightClickItem(int itemIndex, ArcanistsStore.Which which)
  {
    ArcanistsStore.Item item = Store.Instance.Get(which)[itemIndex];
    if (which == ArcanistsStore.Which.SpellSkin)
    {
      string ok = Client.MyAccount.storeItems.IsUnlocked(which, itemIndex) ? "Toggle" : (string) null;
      Action onEnd = (Action) (() => Prestige.Ask((byte) 16, (int) which, itemIndex, true));
      MyMessageBox.Create("Preview <#FF0000>" + item.name + "</color>?", onEnd, ok, "Cancel", (Action) null, (Action) null, item.sprite, "Preview", (Action) (() =>
      {
        if ((UnityEngine.Object) MainMenu.Instance == (UnityEngine.Object) null)
        {
          MyMessageBox.Create("Sorry, you can only preview skins from the main menu!", (Action) null, "Ok", "Cancel", (Action) null, (Action) null, (Sprite) null, (string) null, (Action) null);
        }
        else
        {
          Client.previewItem = item;
          Client._gameFacts = new GameFacts();
          Client.joinedFrom = Client.JoinLocation.Store;
          Controller.Instance.InitMap(true, false, true);
          DiscordIntergration.Instance?.UpdateActivitySandbox();
        }
      }));
    }
    else
      MyMessageBox.Create("<#FF0000>" + item.name + "</color>", (Action) null, (string) null, "Cancel", (Action) null, (Action) null, item.sprite, (string) null, (Action) null);
  }

  public void BuyCrystals(int x)
  {
    Prestige.Ask((byte) 11, x);
  }

  public void HideCrystalPanel()
  {
    this.panelSteam.SetActive(false);
    this.panelArc.SetActive(true);
  }

  public void Tooltip(string s)
  {
    MyToolTip.Show(s, -1f);
  }

  public void HideTooltip()
  {
    MyToolTip.Close();
  }
}
