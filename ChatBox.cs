
using Hazel;
using mattmc3.dotmore.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Win32Utilities;

public class ChatBox : UIBehaviour
{
  public static bool showDate = true;
  public static bool showIcons = true;
  public static int showFade = 2;
  public string privateChatTo = "";
  private bool _active = true;
  private OrderedDictionary<string, float> recentNotifications = new OrderedDictionary<string, float>();
  public bool privateChat;
  public bool isFake;
  public InputFieldPlus chatInput;
  public RectTransform chatContainer;
  public ScrollRect _chatScrollbar;
  public TMP_Text _name;
  public TMP_Text hiddenText;
  public GameObject pfabChat;
  public RecycledScrollView recycled;
  public GameObject buttonEmojiPopup;
  public GameObject buttonMiniGames;
  public GameObject discordButton;
  public ButtonChatSetting butLobby;
  public ButtonChatSetting butGame;
  public ButtonChatSetting butFriends;
  public ButtonChatSetting butInvites;
  public ButtonChatSetting butSpectators;
  public ButtonChatSetting butClan;
  public ButtonChatSetting butTeam;
  public ButtonChatSetting butMinigame;
  public TMP_Text txtDiscordQuickLinks;
  public GameObject activeContainer;
  public TextMeshProUGUI txtFilterMode;
  [Header("Transparent")]
  public Image[] fullTransparent;
  public Image[] halfTransparent;
  public GameObject containerRightSide;
  public RectTransform mainRect;
  public RectTransform containerSettingsButtons;
  public TMP_Text txtIndicatorTransparent;
  [Header("LineCount")]
  public RectTransform filterContainer;
  public RectTransform emptyPanel;
  public RectTransform fpsPanel;
  private Vector2 defaultPosition;
  private Vector2 currentPosition;
  [NonSerialized]
  public TMP_Text textSpellCasted;
  public bool isTransparent;
  private ChatBox.ChatFilter chatFilter;

  public static ChatBox Instance { get; set; }

  public static bool UsingMobileInput
  {
    get
    {
      return (UnityEngine.Object) ChatBox.Instance != (UnityEngine.Object) null && KeyBoard.IsActive;
    }
  }

  public bool Active
  {
    get
    {
      return this._active;
    }
  }

  public void ToggleTransparency()
  {
    this.isTransparent = !this.isTransparent;
    Global.SetPrefBool("invisChatbox", this.isTransparent);
    this.SetTransparent(false);
  }

  public static void ChangeLineCount(int i, bool save = true, bool force = false)
  {
    i = Mathf.Clamp(i, 1, 8);
    if ((UnityEngine.Object) HUD.instance != (UnityEngine.Object) null | force && (UnityEngine.Object) ChatBox.Instance != (UnityEngine.Object) null)
    {
      RectTransform transform = (RectTransform) ChatBox.Instance.transform;
      transform.sizeDelta = new Vector2(transform.sizeDelta.x, 236.3f - (float) (24 * (8 - i)));
      ChatBox.Instance.filterContainer.gameObject.SetActive(i > 5);
      ChatBox.Instance.emptyPanel.gameObject.SetActive(i > 7);
      ChatBox.Instance.fpsPanel.gameObject.SetActive(i > 7);
      HUD.instance?.SetSepllBarPosition();
      ChatBox.Instance.recycled.ChangeLineCount(i);
    }
    if (!save)
      return;
    PlayerPrefs.SetInt("linecount", i);
  }

  public void SetTransparent(bool fromDefault = false)
  {
    if (this.isTransparent)
    {
      for (int index = 0; index < this.fullTransparent.Length; ++index)
        this.fullTransparent[index].color = new Color(1f, 1f, 1f, 0.0f);
      for (int index = 0; index < this.halfTransparent.Length; ++index)
        this.halfTransparent[index].color = new Color(1f, 1f, 1f, PlayerPrefs.GetFloat("prefchattransparency", 0.75f));
      this.txtIndicatorTransparent.text = ">";
      this.containerRightSide.SetActive(false);
      this.mainRect.sizeDelta = new Vector2(1045f, this.mainRect.sizeDelta.y);
      this.containerSettingsButtons.SetAnchor(Anchor.BottomRight);
      this.containerSettingsButtons.anchoredPosition = new Vector2(-29.2f, 18.86f);
      ChatBox.ChangeLineCount(PlayerPrefs.GetInt("linecount", 5), false, true);
    }
    else
    {
      for (int index = 0; index < this.fullTransparent.Length; ++index)
        this.fullTransparent[index].color = new Color(1f, 1f, 1f, 1f);
      for (int index = 0; index < this.halfTransparent.Length; ++index)
        this.halfTransparent[index].color = new Color(1f, 1f, 1f, 1f);
      this.txtIndicatorTransparent.text = "<";
      this.containerRightSide.SetActive(true);
      this.mainRect.sizeDelta = new Vector2(1202.23f, this.mainRect.sizeDelta.y);
      this.containerSettingsButtons.SetAnchor(Anchor.TopRight);
      this.containerSettingsButtons.anchoredPosition = new Vector2(-5f, -19.5f);
      if (!fromDefault)
      {
        ChatBox.ChangeLineCount(PlayerPrefs.GetInt("linecount", 5), false, !fromDefault);
      }
      else
      {
        if (this.recycled.MaxVisible == 8)
          return;
        ChatBox.ChangeLineCount(8, false, false);
      }
    }
  }

  protected override void Awake()
  {
    base.Awake();
    if (!this.isFake)
      ChatBox.Instance = this;
    this.chatInput.onEnd.AddListener(new UnityAction<string>(this.SendChatMessage));
    this._name.text = Client.Name + ":<color=#00000000>||";
    this.defaultPosition = ((RectTransform) this.transform).anchoredPosition;
    this.currentPosition = this.defaultPosition;
    this.butLobby.Set(Client.lobbyChat);
    this.butGame.Set(Client.gameChat);
    this.butFriends.Set(Client.friendChat);
    this.butSpectators.Set(Client.spectatorChat);
    this.butInvites.Set(Client.inviteChat);
    this.butClan.Set(Client.clanChat);
    this.butTeam.Set(Client.teamChat);
    this.butMinigame.Set(Client.minigameChat);
    this.chatFilter = (ChatBox.ChatFilter) PlayerPrefs.GetInt("filterChat", 0);
    this.SetFilter(this.chatFilter, false);
    ChatBox.showDate = Global.GetPrefBool("prefshowdate", true);
    ChatBox.showFade = PlayerPrefs.GetInt("prefshowfade", 2);
    ChatBox.showIcons = Global.GetPrefBool("prefshowicons", true);
    this.discordButton.SetActive(Client.MyAccount.discord == 0UL && Client.MyAccount.accountType.IsMuted() && Client.isConnected);
  }

  public void ToggleEmojiSelector()
  {
    this.chatInput.ToggleEmoji();
  }

  private void Update()
  {
    if (this.recentNotifications.Count > 0 && (double) this.recentNotifications.GetItem(0).Value < (double) Time.realtimeSinceStartup)
      this.recentNotifications.RemoveAt(0);
    if (!Input.GetKeyDown(KeyCode.Tab) || !((UnityEngine.Object) HUD.instance == (UnityEngine.Object) null))
      return;
    if (this.privateChat)
    {
      this.Init();
    }
    else
    {
      if (string.IsNullOrEmpty(this.privateChatTo))
        return;
      this.InitPrivate(ColorScheme.GetColor(Global.ColorSentPrivate), this.privateChatTo);
    }
  }

  public void ReportAbuse()
  {
    Controller.Instance.Report("");
  }

  public void ClickMiniGames()
  {
    MyContextMenu myContextMenu = MyContextMenu.Show();
    if (Client.miniGame != null)
    {
      myContextMenu.AddItem("Leave current minigame", (Action) (() => Client.miniGame?.gameObject?.ClickClose()), (Color) ColorScheme.GetColor(Color.red));
      if (Client.miniGame.IsFirst)
      {
        myContextMenu.AddSeperator("--------------------------");
        myContextMenu.AddItem("Invite Lobby to " + Client.miniGame.GetGameType() + " match", (Action) (() => Client.AskToShare(Client.miniGame.GetGameType(), ContentType.MiniGameInvite, (object) new MinigameInvite()
        {
          from = Client.Name,
          minigameID = Client.miniGame.id,
          miniGameType = (int) Client.miniGame.gameType,
          spectator = (Client.miniGame.players.Count > 1)
        }, false)), (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
        if (Client.clan != null)
        {
          myContextMenu.AddSeperator("--------------------------");
          myContextMenu.AddItem("Invite Clan to " + Client.miniGame.GetGameType() + " match", (Action) (() =>
          {
            Client.sharingWith = "[Clan]";
            Client.AskToShare(Client.miniGame.GetGameType(), ContentType.MiniGameInvite, (object) new MinigameInvite()
            {
              from = Client.Name,
              minigameID = Client.miniGame.id,
              miniGameType = (int) Client.miniGame.gameType,
              spectator = (Client.miniGame.players.Count > 1)
            }, false);
          }), (Color) ColorScheme.GetColor(MyContextMenu.ColorClan));
        }
      }
    }
    else
    {
      myContextMenu.AddItem("New Chess Lobby", (Action) (() => Client.AskToCreateMiniGame((byte) 1)), Color.green);
      myContextMenu.AddItem("New Checkers Lobby", (Action) (() => Client.AskToCreateMiniGame((byte) 2)), Color.green);
      myContextMenu.AddItem("New Join31 Lobby", (Action) (() => Client.AskToCreateMiniGame((byte) 3)), Color.green);
      myContextMenu.AddItem("New RPSTBG Lobby", (Action) (() => Client.AskToCreateMiniGame((byte) 4)), Color.green);
    }
    myContextMenu.Rebuild(false);
  }

  public void ClickQuickchat()
  {
    QuickchatUI.Create();
  }

  public void ClickOptions()
  {
    HUD.instance?.TogglePauseMenu(true);
    Controller.ShowSettingsMenu(false);
  }

  public void ClickStore()
  {
    Controller.ShowPopup(Controller.Instance.MenuStore);
  }

  public void ClickDiscord()
  {
    MyContextMenu myContextMenu = MyContextMenu.Show();
    myContextMenu.AddItem("Verify using your browser", (Action) (() => DiscordController._VerifyBrowser()), (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
    myContextMenu.Rebuild(false);
  }

  public void HoverHelp()
  {
    if (this.txtDiscordQuickLinks.text.Length < 100)
    {
      StringBuilder stringBuilder = new StringBuilder("Quick Links:\n");
      foreach (KeyValuePair<string, string> keyValuePair in WordFilter.linkreplacement)
        stringBuilder.Append(keyValuePair.Key).Append("\n");
      this.txtDiscordQuickLinks.text = stringBuilder.ToString();
    }
    this.txtDiscordQuickLinks.transform.parent.gameObject.SetActive(true);
    MyToolTip.Show("Chat Prefixes\n\n<" + InputFieldPlus.RGBtoHEX(ColorScheme.GetColor(Global.ColorTeamText)) + ">Team Chat: '/' (If in a team game...ex: /summon swarm)\n</color><" + InputFieldPlus.RGBtoHEX(ColorScheme.GetColor(Global.ColorSentPrivate)) + ">Private Chat: '/name:' (Easier to Right-click their name but...ex: /bob:hi bob)\n</color><" + InputFieldPlus.RGBtoHEX(ColorScheme.GetColor(Global.ColorMiniGameText)) + ">Mini-Game Chat: ';' (If in a mini-game...ex: ;Checkmate!)\n</color><" + InputFieldPlus.RGBtoHEX(ColorScheme.GetColor(Global.ColorClanText)) + ">Clan Chat: '.' (If in a clan...ex: .hello)</color>\n\nEmoji: ':' (ex: :shark:)\nHold alt while picking an Emoji\nfrom the emoji selector to\nAdd it to your favorites", -1f);
  }

  public void ClickLineCount()
  {
    ChatBox.ClickLineCount2();
  }

  public static void ClickLineCount2()
  {
    MyContextMenu myContextMenu = MyContextMenu.Show();
    for (int index = 1; index <= 8; ++index)
    {
      int e = index;
      myContextMenu.AddItem(index.ToString(), (Action) (() => ChatBox.ChangeLineCount(e, true, false)), (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
    }
    myContextMenu.Rebuild(false);
  }

  public void ShowToolTip(string s)
  {
    MyToolTip.Show(s, -1f);
  }

  public void HoverLeave()
  {
    this.txtDiscordQuickLinks.transform.parent.gameObject.SetActive(false);
    MyToolTip.Close();
  }

  public void ShowChatOptions(int x)
  {
    int num = x;
    MyContextMenu myContextMenu = MyContextMenu.Show();
    myContextMenu.AddItem("On", (Action) (() => Client.AskToChangeChatSetting((byte) x, ChatSetting.On)), (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
    myContextMenu.AddItem("Friends", (Action) (() => Client.AskToChangeChatSetting((byte) x, ChatSetting.Friends)), (Color) ColorScheme.GetColor(MyContextMenu.ColorYellow));
    myContextMenu.AddItem("Off", (Action) (() => Client.AskToChangeChatSetting((byte) x, ChatSetting.Off)), (Color) ColorScheme.GetColor(MyContextMenu.ColorRed));
    myContextMenu.Rebuild(false);
  }

  public void ShowFilterOptions()
  {
    ChatBox._ShowFilterOptions();
  }

  public static void _ShowFilterOptions()
  {
    MyContextMenu myContextMenu = MyContextMenu.Show();
    ChatBox instance = ChatBox.Instance;
    ChatBox.ChatFilter chatFilter = instance != null ? instance.chatFilter : (ChatBox.ChatFilter) PlayerPrefs.GetInt("filterChat", 0);
    myContextMenu.AddSeperator("<mspace=\"-\">---------------------In-Game Line Count--------------------</mspace>");
    myContextMenu.AddItem("Visible Lines (" + (object) PlayerPrefs.GetInt("linecount", 5) + ")", (Action) (() => ChatBox.ClickLineCount2()), (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
    myContextMenu.AddSeperator("<mspace=\"-\">---------------------Chat Filter--------------------</mspace>");
    myContextMenu.AddItem("Block Entirely" + (chatFilter == ChatBox.ChatFilter.Block_Entirely ? "<sprite=\"AccountIconsAll\" index=225>" : ""), (Action) (() => ChatBox._SetFilter(ChatBox.ChatFilter.Block_Entirely, true)), (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
    myContextMenu.AddItem("Stars" + (chatFilter == ChatBox.ChatFilter.Stars ? "<sprite=\"AccountIconsAll\" index=225>" : ""), (Action) (() => ChatBox._SetFilter(ChatBox.ChatFilter.Stars, true)), (Color) ColorScheme.GetColor(MyContextMenu.ColorYellow));
    myContextMenu.AddItem("Off" + (chatFilter == ChatBox.ChatFilter.Off ? "<sprite=\"AccountIconsAll\" index=225>" : ""), (Action) (() => ChatBox._SetFilter(ChatBox.ChatFilter.Off, true)), (Color) ColorScheme.GetColor(MyContextMenu.ColorRed));
    myContextMenu.AddSeperator("<mspace=\"-\">---------------In-game Floating Text--------------</mspace>");
    myContextMenu.AddItem("Whenever the chat box is hidden" + (ChatBox.showFade == 1 ? "<sprite=\"AccountIconsAll\" index=225>" : ""), (Action) (() =>
    {
      ChatBox.showFade = 1;
      PlayerPrefs.SetInt("prefshowfade", ChatBox.showFade);
    }), (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
    myContextMenu.AddItem("Same as above but NOT on your turn" + (ChatBox.showFade == 2 ? "<sprite=\"AccountIconsAll\" index=225>" : ""), (Action) (() =>
    {
      ChatBox.showFade = 2;
      PlayerPrefs.SetInt("prefshowfade", ChatBox.showFade);
    }), (Color) ColorScheme.GetColor(MyContextMenu.ColorYellow));
    myContextMenu.AddItem("Disabled" + (ChatBox.showFade == 0 ? "<sprite=\"AccountIconsAll\" index=225>" : ""), (Action) (() =>
    {
      ChatBox.showFade = 0;
      PlayerPrefs.SetInt("prefshowfade", ChatBox.showFade);
    }), (Color) ColorScheme.GetColor(MyContextMenu.ColorRed));
    myContextMenu.AddSeperator("----------------------------------------------------");
    if (Global.GetPrefBool("prefflashchat", true))
      myContextMenu.AddItem("Disable flashing when a chat message is recieved", (Action) (() => ChatBox.ToggleFlashChat()), (Color) ColorScheme.GetColor(MyContextMenu.ColorRed));
    else
      myContextMenu.AddItem("Enable flashing when a chat message is recieved", (Action) (() => ChatBox.ToggleFlashChat()), (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
    if (Global.GetPrefBool("prefflashchatturn", true))
      myContextMenu.AddItem("Disable flashing when its your turn", (Action) (() => ChatBox.ToggleFlashChatTurn()), (Color) ColorScheme.GetColor(MyContextMenu.ColorRed));
    else
      myContextMenu.AddItem("Enable flashing when its your turn", (Action) (() => ChatBox.ToggleFlashChatTurn()), (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
    if (Global.GetPrefBool("prefflashchatinvite", true))
      myContextMenu.AddItem("Disable flashing when a game invite is received", (Action) (() => ChatBox.ToggleFlashChaInvite()), (Color) ColorScheme.GetColor(MyContextMenu.ColorRed));
    else
      myContextMenu.AddItem("Enable flashing when a game invite is received", (Action) (() => ChatBox.ToggleFlashChaInvite()), (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
    if (Global.GetPrefBool("prefacceptinvites", true))
      myContextMenu.AddItem("Disable Game Invites", (Action) (() => ChatBox.ToggleAcceptInvites()), (Color) ColorScheme.GetColor(MyContextMenu.ColorRed));
    else
      myContextMenu.AddItem("Enable Game Invites", (Action) (() => ChatBox.ToggleAcceptInvites()), (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
    if (Global.GetPrefBool("prefclaninvites", true))
      myContextMenu.AddItem("Disable Clan Invites", (Action) (() => ChatBox.ToggleClanInvites()), (Color) ColorScheme.GetColor(MyContextMenu.ColorRed));
    else
      myContextMenu.AddItem("Enable Clan Invites", (Action) (() => ChatBox.ToggleClanInvites()), (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
    if (Global.GetPrefBool("prefshowcreatedgames", true))
      myContextMenu.AddItem("Disable Created Lobbies Notifications", (Action) (() => ChatBox.ToggleShowCreatedGames()), (Color) ColorScheme.GetColor(MyContextMenu.ColorRed));
    else
      myContextMenu.AddItem("Enable Created Lobbies Notifications", (Action) (() => ChatBox.ToggleShowCreatedGames()), (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
    if (Global.GetPrefBool("prefshowstartedgames", true))
      myContextMenu.AddItem("Disable Rated Game Notifications", (Action) (() => ChatBox.ToggleShowStartGame()), (Color) ColorScheme.GetColor(MyContextMenu.ColorRed));
    else
      myContextMenu.AddItem("Enable Rated Game Notifications", (Action) (() => ChatBox.ToggleShowStartGame()), (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
    if (ChatBox.showDate)
      myContextMenu.AddItem("Hide chat message timestamps", (Action) (() => ChatBox.ToggleShowDate()), (Color) ColorScheme.GetColor(MyContextMenu.ColorRed));
    else
      myContextMenu.AddItem("Show chat message timestamps", (Action) (() => ChatBox.ToggleShowDate()), (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
    if (ChatBox.showIcons)
      myContextMenu.AddItem("Hide Account Icons", (Action) (() => ChatBox.ToggleShowIcons()), (Color) ColorScheme.GetColor(MyContextMenu.ColorRed));
    else
      myContextMenu.AddItem("Show Account Icons", (Action) (() => ChatBox.ToggleShowIcons()), (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
    if (Global.GetPrefBool("prefdeathmsg", true))
      myContextMenu.AddItem("Disable player messages on death", (Action) (() => Global.SetPrefBool("prefdeathmsg", false)), (Color) ColorScheme.GetColor(MyContextMenu.ColorRed));
    else
      myContextMenu.AddItem("Enable player messages on death", (Action) (() => Global.SetPrefBool("prefdeathmsg", true)), (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
    myContextMenu.AddSlider((UnityAction<float>) (a =>
    {
      PlayerPrefs.SetFloat("prefchattransparency", a);
      ChatBox.Instance?.SetTransparent(false);
    }), "Chatbox Transparency", PlayerPrefs.GetFloat("prefchattransparency", 0.75f));
    myContextMenu.AddSlider((UnityAction<float>) (a =>
    {
      PlayerPrefs.SetFloat("prefSpellBarTransparency", a);
      ClickSpell.Instance?.ChangeAlpha(a);
    }), "Spellbar Transparency", PlayerPrefs.GetFloat("prefSpellBarTransparency", 0.35f));
    myContextMenu.Rebuild(false);
  }

  private static void ToggleFlashChat()
  {
    Global.SetPrefBool("prefflashchat", !Global.GetPrefBool("prefflashchat", true));
  }

  private static void ToggleFlashChatTurn()
  {
    Global.SetPrefBool("prefflashchatturn", !Global.GetPrefBool("prefflashchatturn", true));
  }

  private static void ToggleFlashChaInvite()
  {
    Global.SetPrefBool("prefflashchatinvite", !Global.GetPrefBool("prefflashchatinvite", true));
  }

  private static void ToggleAcceptInvites()
  {
    Global.SetPrefBool("prefacceptinvites", !Global.GetPrefBool("prefacceptinvites", true));
  }

  private static void ToggleClanInvites()
  {
    Global.SetPrefBool("prefclaninvites", !Global.GetPrefBool("prefclaninvites", true));
  }

  private static void ToggleShowCreatedGames()
  {
    Global.SetPrefBool("prefshowcreatedgames", !Global.GetPrefBool("prefshowcreatedgames", true));
  }

  private static void ToggleShowStartGame()
  {
    Global.SetPrefBool("prefshowstartedgames", !Global.GetPrefBool("prefshowstartedgames", true));
  }

  private static void ToggleShowDate()
  {
    ChatBox.showDate = !ChatBox.showDate;
    Global.SetPrefBool("prefshowdate", ChatBox.showDate);
    ChatBox.Instance?.recycled.ForceRender();
  }

  private static void ToggleShowIcons()
  {
    ChatBox.showIcons = !ChatBox.showIcons;
    Global.SetPrefBool("prefshowicons", ChatBox.showIcons);
    ChatBox.Instance?.recycled.ForceRender();
  }

  public static void _SetFilter(ChatBox.ChatFilter c, bool update)
  {
    ChatBox.Instance?.SetFilter(c, update);
    if (!update)
      return;
    PlayerPrefs.SetInt("filterChat", (int) c);
  }

  public void SetFilter(ChatBox.ChatFilter c, bool update)
  {
    this.chatFilter = c;
    this.txtFilterMode.text = c.ToString().Replace('_', ' ');
    switch (c)
    {
      case ChatBox.ChatFilter.Stars:
        this.txtFilterMode.color = (Color) ColorScheme.GetColor(Global.ColorLobbyText);
        break;
      case ChatBox.ChatFilter.Block_Entirely:
        this.txtFilterMode.color = (Color) ColorScheme.GetColor(Global.ColorGameText);
        break;
      default:
        this.txtFilterMode.color = Color.red;
        break;
    }
    if (!update)
      return;
    PlayerPrefs.SetInt("filterChat", (int) c);
  }

  public void Notification(string s, string rightClickName, ChatOrigination org = ChatOrigination.System)
  {
    if (this.recentNotifications.ContainsKey(s))
      return;
    this.NewChatMsg("", s, (Color) ColorScheme.GetColor(Global.ColorSystem), rightClickName, org, ContentType.STRING, (object) null);
    this.recentNotifications[s] = Time.realtimeSinceStartup + 10f;
  }

  public void NotificationAskToJoin(string s)
  {
    if (Client.IsIgnored(s) || !Global.GetPrefBool("prefacceptinvites", true) || this.recentNotifications.ContainsKey(s))
      return;
    this.NewChatMsg("", s + " wants to join", (Color) ColorScheme.GetColor(Global.ColorNotification), s, ChatOrigination.System, ContentType.STRING, (object) null);
    this.recentNotifications[s] = Time.realtimeSinceStartup + 10f;
    if (!Global.GetPrefBool("prefflashchatinvite", true))
      return;
    FlashWindow.instance.Flash();
  }

  public void NotificationInfiteToClan(string n, string clan, object content)
  {
    if (Client.IsIgnored(n) || !Global.GetPrefBool("prefclaninvites", true) || this.recentNotifications.ContainsKey(n))
      return;
    this.NewContent("", n + " invited you to join the clan <#ff8d02>[" + clan + "]</color> (Right-click to accept) ~ Expires in 30 seconds", (Color) ColorScheme.GetColor(Global.ColorNotification), ChatOrigination.Clan, ContentType.ClanInvite, content);
    this.recentNotifications[n] = Time.realtimeSinceStartup + 10f;
  }

  public void UpdatePostion(bool defaultPosition)
  {
    if (defaultPosition)
      this.DefaultPosition();
    else
      this.PositionGame();
  }

  private void PositionGame()
  {
    RectTransform transform = (RectTransform) this.transform;
    transform.SetAnchor(Anchor.BottomLeft);
    transform.pivot = new Vector2(0.0f, 0.0f);
    transform.anchoredPosition = new Vector2(5f, Controller.Instance.useColorScheme ? 5f : this.defaultPosition.y);
    this.currentPosition = transform.anchoredPosition;
    this._active = true;
    this.isTransparent = Global.GetPrefBool("invisChatbox", true);
    this.SetTransparent(false);
  }

  private void DefaultPosition()
  {
    RectTransform transform = (RectTransform) this.transform;
    transform.SetAnchor(Anchor.BottomCenter);
    transform.pivot = new Vector2(0.5f, 0.0f);
    transform.anchoredPosition = this.defaultPosition;
    this.currentPosition = transform.anchoredPosition;
    this._active = true;
    this.isTransparent = false;
    this.SetTransparent(true);
  }

  public void ToggleChat()
  {
    this.SetActive(!this._active);
  }

  public void OnTouch()
  {
  }

  public void SetActive(bool v)
  {
    RectTransform transform = (RectTransform) this.transform;
    if (this._active == v)
    {
      if (!((UnityEngine.Object) HUD.instance != (UnityEngine.Object) null))
        return;
      HUD.instance.buttonHideChat.anchoredPosition = v ? new Vector2(6f, (float) ((double) transform.sizeDelta.y + (double) transform.anchoredPosition.y + 6.0)) : new Vector2(6f, 6f);
      HUD.instance.buttonChatEaseOfAccess.SetActive(!v);
    }
    else
    {
      this._active = v;
      transform.anchoredPosition = !v ? new Vector2(transform.anchoredPosition.x, (float) (-(double) transform.sizeDelta.y - 6.0)) : this.currentPosition;
      if (!((UnityEngine.Object) HUD.instance != (UnityEngine.Object) null))
        return;
      HUD.instance.buttonHideChat.anchoredPosition = v ? new Vector2(6f, (float) ((double) transform.sizeDelta.y + (double) transform.anchoredPosition.y + 6.0)) : new Vector2(6f, 6f);
      HUD.instance.buttonChatEaseOfAccess.SetActive(!v);
      HUD.instance.ValidateFromChatBox();
    }
  }

  public void AllowInput(bool v)
  {
    this.activeContainer.SetActive(v);
    this.chatInput.enabled = v;
    this.hiddenText.text = v ? "" : "Press Tab to chat";
    this.buttonEmojiPopup.SetActive(v);
    if (v)
      return;
    this.chatInput.emojiSelector.gameObject.SetActive(false);
  }

  public void Resized()
  {
    this.chatInput.inputText.rectTransform.anchoredPosition = new Vector2(this._name.rectTransform.sizeDelta.x, 0.0f);
    this.chatInput.inputText.rectTransform.sizeDelta = new Vector2((float) ((double) ((RectTransform) this._name.rectTransform.parent).sizeDelta.x - (double) this._name.rectTransform.sizeDelta.x - 17.0), this.chatInput.inputText.rectTransform.sizeDelta.y);
  }

  public void InitPrivate(Color32 c, string name)
  {
    this.chatInput.Init(c);
    this._name.color = (Color) c;
    this._name.text = "To " + name + ":<color=#00000000>||";
    this.chatInput.inputText.color = (Color) c;
    this.privateChat = true;
    this.privateChatTo = name;
    this.OnTouch();
  }

  public void Init()
  {
    this.Init((UnityEngine.Object) LobbyMenu.instance != (UnityEngine.Object) null || Spectator.isConnected ? ColorScheme.GetColor(Global.ColorLobbyText) : ColorScheme.GetColor(Global.ColorGameText));
  }

  public void Init(Color32 c)
  {
    this.chatInput.Init(c);
    this._name.color = (Color) c;
    this._name.text = Client.Name + ":<color=#00000000>||";
    this.chatInput.inputText.color = (Color) c;
    this.privateChat = false;
  }

  protected override void OnDestroy()
  {
    if (!((UnityEngine.Object) ChatBox.Instance == (UnityEngine.Object) this))
      return;
    ChatBox.Instance = (ChatBox) null;
  }

  public static ChatBox.ChatFilter GetFilter()
  {
    return (UnityEngine.Object) ChatBox.Instance != (UnityEngine.Object) null ? ChatBox.Instance.chatFilter : ChatBox.ChatFilter.Stars;
  }

  public void NewContent(
    string name,
    string msg,
    Color c,
    ChatOrigination origination,
    ContentType t,
    object data)
  {
    this.NewChatMsg("", msg, c, name, origination, t, data);
  }

  public static void SystemMessage(string msg)
  {
    ChatBox.Instance?.NewChatMsg(msg, (Color) ColorScheme.GetColor(Global.ColorSystem));
  }

  public void NewChatMsg(string msg, Color c)
  {
    WordFilter.CheckReplacements(ref msg);
    this.recycled.Add("", "", msg, c, "", ChatOrigination.System, ContentType.STRING, (object) null);
  }

  public void NewChatMsg(PfabChatMsg.contain contain)
  {
    WordFilter.CheckReplacements(ref contain.msg);
    this.recycled.Add(contain);
  }

  public static string IconString(Account acc, AccountType a)
  {
    switch (a)
    {
      case AccountType.None:
        return "";
      case AccountType.Mod:
      case AccountType.Head_of_Moderation:
        return "<sprite=\"AccountIconsAll\" anim=\"168,183,15\"> ";
      case AccountType.Developer:
      case AccountType.Game_Director:
      case AccountType.Owner:
        return "<sprite=\"AccountIconsAll\" anim=\"144,159,15\"> ";
      case AccountType.Muted:
        return acc.discord != 0UL ? "<sprite=\"AccountIconsAll\" index=223> " : "<sprite=\"AccountIconsAll\" index=222>";
      case AccountType.Audio_Director:
        return "<sprite=\"AccountIconsAll\" anim=\"312,327,10\"> ";
      case AccountType.Arcane_Monster:
        return "<sprite=\"AccountIconsAll\" anim=\"240,255,8\"> ";
      case AccountType.First_Place:
        return "<sprite=\"AccountIconsAll\" anim=\"0,23,15\"> ";
      case AccountType.Second_Place:
        return "<sprite=\"AccountIconsAll\" anim=\"24,47,15\"> ";
      case AccountType.Third_Place:
        return "<sprite=\"AccountIconsAll\" anim=\"48,71,15\"> ";
      case AccountType.Booster:
        return "<sprite=\"AccountIconsAll\" anim=\"120,135,15\"> ";
      case AccountType.Robotics_Division:
        return "<sprite=\"AccountIconsAll\" index=216> ";
      case AccountType.Contributor:
        return "<sprite=\"AccountIconsAll\" anim=\"288,300,15\"> ";
      case AccountType.Backend_Technical_Director:
        return "<sprite=\"AccountIconsAll\" anim=\"312,327,10\"> ";
      case AccountType.Tournament_Official:
        return "<sprite=\"AccountIconsAll\" index=219> ";
      case AccountType.Wiki_Staff:
        return "<sprite=\"AccountIconsAll\" index=220> ";
      case AccountType.Twitch_Streamer:
        return "<sprite=\"AccountIconsAll\" anim=\"72,95,15\"> ";
      case AccountType.Youtube_Creator:
        return "<sprite=\"AccountIconsAll\" anim=\"96,119,15\"> ";
      case AccountType.Donator:
        return "<sprite=\"AccountIconsAll\" index=227> ";
      case AccountType.Asset_Creator:
        return "<sprite=\"AccountIconsAll\" index=226> ";
      case AccountType.Audio_Wizard:
        return "<sprite=\"AccountIconsAll\" index=228> ";
      case AccountType.Perm_Muted:
        return "<sprite=\"AccountIconsAll\" index=223> ";
      case AccountType.Arch_Donator:
        return "<sprite=\"AccountIconsAll\" anim=\"136,142,10\"> ";
      case AccountType.Lifetime:
        return "<sprite=\"AccountIconsAll\" anim=\"136,142,10\"> ";
      case AccountType.Website_Director:
        return "<sprite=\"AccountIconsAll\" anim=\"312,327,10\"> ";
      case AccountType.Art_Director:
        return "<sprite=\"AccountIconsAll\" anim=\"312,327,10\"> ";
      case AccountType.Tournament_Director:
        return "<sprite=\"AccountIconsAll\" anim=\"312,327,10\"> ";
      case AccountType.Press_Account:
        return "<sprite=\"AccountIconsAll\" index=229> ";
      case AccountType.Tourny_Participate:
        return "<sprite=\"AccountIconsAll\" index=230> ";
      default:
        return "";
    }
  }

  public static string PrestigeString(int prestige)
  {
    return "<sprite=\"AccountIconsAll\" index=" + (object) (191 + prestige) + "> ";
  }

  public static string ExperienceString(int ex)
  {
    return "<sprite=\"AccountIconsAll\" index=264> ";
  }

  public static string GetAllAccountIcons(Account acc)
  {
    int accountType = (int) acc.accountType;
    if (accountType == 0)
      return "";
    StringBuilder stringBuilder = new StringBuilder();
    for (int index = 0; index < AccountExtension._IconOrder.Length; ++index)
    {
      if (((AccountType) accountType & AccountExtension._IconOrder[index]) != AccountType.None)
        stringBuilder.Append(ChatBox.IconString(acc, AccountExtension._IconOrder[index]));
    }
    return stringBuilder.ToString();
  }

  public static string GetAccountIcons(Account acc, bool includeExtra, bool link = false, bool clanChat = false)
  {
    string str = !includeExtra || acc.displayClanPrefix != (byte) 0 || (clanChat || Client.clanChat == ChatSetting.Off) || string.IsNullOrEmpty(acc.clan) ? "" : "<#FF8E00>[" + acc.clan + "]</color> ";
    if (acc.accountType.IsMuted())
    {
      if (!includeExtra)
        return "";
      if (!link)
        return ChatBox.IconString(acc, acc.accountType.has(AccountType.Perm_Muted) ? AccountType.Perm_Muted : AccountType.Muted) + str;
      return "<link=\"" + (acc.discord == 0UL ? "Unverified" : "Muted") + "\">" + ChatBox.IconString(acc, acc.accountType.has(AccountType.Perm_Muted) ? AccountType.Perm_Muted : AccountType.Muted) + "</link>" + str;
    }
    int accountType = (int) acc.accountType;
    if (acc.displayedIcon == 252)
    {
      if (!includeExtra)
        return str;
      if (!link)
        return ChatBox.ExperienceString((int) acc.experience) + str;
      return "<link=\"Level " + acc.experience.ToString() + "\">" + ChatBox.ExperienceString((int) acc.experience) + "</link>" + str;
    }
    if (acc.displayedIcon > (int) byte.MaxValue)
      return link ? "<link=\"Badge: " + ClientResources.Instance.badges[acc.DisplayedBadge].name + "\"><sprite=\"Badges\" index=" + (object) acc.DisplayedBadge + "> </link>" + str : "<sprite=\"Badges\" index=" + (object) acc.DisplayedBadge + "> " + str;
    if (accountType == 0 || acc.displayedIcon == (int) byte.MaxValue)
    {
      if (!includeExtra)
        return str;
      if (acc.prestige <= (byte) 0)
        return "<sprite=\"AccountIconsAll\" index=221> " + str;
      if (!link)
        return ChatBox.PrestigeString((int) acc.prestige) + str;
      return "<link=\"Prestige " + acc.prestige.ToString() + "\">" + ChatBox.PrestigeString((int) acc.prestige) + "</link>" + str;
    }
    if (acc.displayedIcon != 0)
    {
      int num = 1 << acc.displayedIcon;
      if ((num & accountType) != 0)
      {
        if (!link)
          return ChatBox.IconString(acc, (AccountType) num) + str;
        return "<link=\"" + ((AccountType) num).ToSpacelessString() + "\">" + ChatBox.IconString(acc, (AccountType) num) + "</link>" + str;
      }
    }
    for (int index = 0; index < AccountExtension._IconOrder.Length; ++index)
    {
      if (((AccountType) accountType & AccountExtension._IconOrder[index]) != AccountType.None)
      {
        if (!link)
          return ChatBox.IconString(acc, AccountExtension._IconOrder[index]) + str;
        return "<link=\"" + AccountExtension._IconOrder[index].ToSpacelessString() + "\">" + ChatBox.IconString(acc, AccountExtension._IconOrder[index]) + "</link>" + str;
      }
    }
    return "Error ";
  }

  public void NewChatMsg(
    string name,
    string msg,
    Color c,
    string RightClickName,
    ChatOrigination origination,
    ContentType contentType = ContentType.STRING,
    object data = null)
  {
    if (!string.IsNullOrEmpty(RightClickName) && Client.IsIgnored(RightClickName))
      return;
    if (origination != ChatOrigination.System && WordFilter.HasRealBadWords(msg))
      msg = WordFilter.ReplaceRealBadWords(msg);
    if (this.chatFilter != ChatBox.ChatFilter.Off && origination != ChatOrigination.System && WordFilter.HasBadWords(msg))
    {
      if (this.chatFilter == ChatBox.ChatFilter.Block_Entirely)
        return;
      msg = WordFilter.ReplaceBadWords(msg);
    }
    if (origination != ChatOrigination.System)
      msg = WordFilter.FilterForbiddenWords(msg);
    string icon = "";
    if (!string.IsNullOrEmpty(RightClickName) && (string.Equals(RightClickName, name) || name.Contains(RightClickName)))
    {
      Account account = Client.GetAccount(RightClickName, false);
      if (!account.fake)
        icon = ChatBox.GetAccountIcons(account, false, false, origination == ChatOrigination.Clan);
      if (WordFilter.HasWeb(msg) && origination != ChatOrigination.System && !account.accountType.Heightened())
        return;
      if (!string.Equals(RightClickName, Client.Name, StringComparison.OrdinalIgnoreCase))
      {
        switch (origination)
        {
          case ChatOrigination.Lobby:
            if (ChatBox.Instance.butLobby.currentSetting == ChatSetting.Friends)
            {
              if (!Client.HasFriend(RightClickName))
                return;
              break;
            }
            if (ChatBox.Instance.butLobby.currentSetting == ChatSetting.Off || Client.IsIgnored(RightClickName))
              return;
            break;
          case ChatOrigination.Game:
            if (ChatBox.Instance.butGame.currentSetting == ChatSetting.Friends)
            {
              if (!Client.HasFriend(RightClickName))
                return;
              break;
            }
            if (ChatBox.Instance.butGame.currentSetting == ChatSetting.Off || Client.IsIgnored(RightClickName))
              return;
            break;
          case ChatOrigination.Private:
            if (ChatBox.Instance.butFriends.currentSetting == ChatSetting.Friends)
            {
              if (!Client.HasFriend(RightClickName))
                return;
              break;
            }
            if (ChatBox.Instance.butFriends.currentSetting == ChatSetting.Off || Client.IsIgnored(RightClickName))
              return;
            break;
          case ChatOrigination.Clan:
            if (ChatBox.Instance.butClan.currentSetting == ChatSetting.Friends)
            {
              if (!Client.HasFriend(RightClickName))
                return;
              break;
            }
            if (ChatBox.Instance.butClan.currentSetting == ChatSetting.Off || Client.IsIgnored(RightClickName))
              return;
            break;
          case ChatOrigination.MiniGame:
            if (ChatBox.Instance.butMinigame.currentSetting == ChatSetting.Friends)
            {
              if (!Client.HasFriend(RightClickName))
                return;
              break;
            }
            if (ChatBox.Instance.butMinigame.currentSetting == ChatSetting.Off || Client.IsIgnored(RightClickName))
              return;
            break;
          case ChatOrigination.Team:
            if (ChatBox.Instance.butTeam.currentSetting == ChatSetting.Friends)
            {
              if (!Client.HasFriend(RightClickName))
                return;
              break;
            }
            if (ChatBox.Instance.butTeam.currentSetting == ChatSetting.Off || Client.IsIgnored(RightClickName))
              return;
            break;
        }
      }
    }
    WordFilter.CheckReplacements(ref msg);
    this.recycled.Add(name, icon, msg, c, RightClickName, origination, contentType, data);
    if (!Global.GetPrefBool("prefflashchat", true))
      return;
    FlashWindow.instance.Flash();
  }

  public void MobileSend(string s)
  {
    this.SendChatMessage(s);
    this.chatInput?.SetText("");
  }

  public void SendChatMessage(string s)
  {
    if ((UnityEngine.Object) ColorSchemeUI.Instance != (UnityEngine.Object) null)
      return;
    if (Client.game != null && Client.game.isSandbox)
    {
      this.NewChatMsg("", s, (Color) ColorScheme.GetColor(Global.ColorAnnoucement), "", ChatOrigination.System, ContentType.STRING, (object) null);
      Client.DevConsole(s, Client.game, new FixedInt?(), new MyLocation?());
    }
    else if (string.IsNullOrEmpty(s))
    {
      if (!this.privateChat)
        return;
      this.Init();
    }
    else
    {
      if (!Client.isConnected)
        return;
      if (this.privateChat)
      {
        Client.SendPrivateChatMsg(this.privateChatTo, s);
        this.Init();
      }
      else
        Client.SendChatMsg(s);
    }
  }

  public enum ChatFilter
  {
    Stars,
    Block_Entirely,
    Off,
  }
}
