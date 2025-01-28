
using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class StoreMenu : MonoBehaviour
{
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
  private ArcanistsStore curStore;
  public TMP_Text startedFromSteam;

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
    this.ClickBuyCrystals();
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
    if (this.curStore == null)
      return;
    this._PopulateStore(this.curStore);
  }

  private void _PopulateStore(ArcanistsStore x)
  {
    this.curStore = x;
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
        buttonArcanistsStore.button.onClick.AddListener((UnityAction) (() => this.BuyArcanistsItem(e, x.which)));
      else
        buttonArcanistsStore.button.onClick.AddListener((UnityAction) (() => Prestige.Ask((byte) 16, (int) x.which, e)));
      ++i;
    }
  }

  private void _clickedArcButton()
  {
    this.panelSteam.SetActive(false);
    this.panelArc.SetActive(true);
  }

  public void ClickBuyCrystals()
  {
    this.panelSteam.SetActive(true);
    this.panelArc.SetActive(false);
  }

  public void BuyArcanistsItem(int itemIndex, ArcanistsStore.Which which)
  {
    ArcanistsStore.Item obj = Store.Instance.Get(which)[itemIndex];
    MyMessageBox.Create("Buy <#FF0000>" + obj.name + "</color> for <#00FFFF>" + (object) obj.cost + "</color> crystals?", (Action) (() => Prestige.Ask((byte) 12, (int) which, itemIndex)), "Ok", "Cancel", (Action) null, (Action) null, obj.sprite);
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
