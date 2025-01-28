
using Hazel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UnratedMenu : Catalogue
{
  public static bool[] readyStates = new bool[0];
  private float[] scrollValues = new float[4]
  {
    1f,
    1f,
    1f,
    1f
  };
  public UnratedTab unratedTab;
  public RectTransform _containerAccounts;
  public RectTransform _containerInvite;
  public GameObject panelInvite;
  public TextMeshProUGUI txtRateType;
  public TextMeshProUGUI txtName;
  public TextMeshProUGUI txtDescription;
  public Button buttonStartGame;
  public TMP_Text buttonStartGameTxt;
  public Image startGameImg;
  public Button buttonInvite;
  public GameObject pfabNames;
  public GameObject pfabInvite;
  public GameObject pfabFriend;
  public UIOnHover butViewLobby;
  public UIOnHover butViewFriends;
  public UIOnHover butViewIgnore;
  public UIOnHover butViewClan;
  public UIOnHover butAddFriend;
  internal Viewing viewing;
  public UIOnHover buttonAdvanced;
  [Header("Custom Armageddon")]
  public TMP_Text txtNumPlayers;
  public TMP_Text txtGameOwner;
  public GameObject panelMultiBooks;
  public List<MultiSelectConfig> multiBooks;
  public GameObject buttonMultiBookPanel;
  public GameObject panelPlayersPerTeam;
  [Header("Preview")]
  public SpellImageList spellImageList;
  [Header("Scroll")]
  public ScrollRect scrollRect;
  public GameObject panelPopup;
  private bool isFirst;
  private bool allReady;

  public static UnratedMenu instance { get; private set; }

  public void UpdateScrollValue()
  {
    this.scrollValues[LobbyMenu.GetScrollIndex(this.viewing)] = this.scrollRect.verticalNormalizedPosition;
  }

  public void SetScrollValue()
  {
    this.scrollRect.verticalNormalizedPosition = this.scrollValues[LobbyMenu.GetScrollIndex(this.viewing)];
  }

  public bool IsFirst
  {
    get
    {
      return this.isFirst;
    }
  }

  public static bool IsViewingInvitePanel
  {
    get
    {
      return (UnityEngine.Object) UnratedMenu.instance != (UnityEngine.Object) null && UnratedMenu.instance.panelInvite.activeSelf;
    }
  }

  public static bool CheckInvites
  {
    get
    {
      return (UnityEngine.Object) UnratedMenu.instance != (UnityEngine.Object) null && UnratedMenu.instance.IsFirst;
    }
  }

  private void Awake()
  {
    UnratedMenu.instance = this;
    this.UpdateOutfit();
    this.UpdateSpellIcons();
    this.SetReadyStatesOff();
  }

  private void Start()
  {
    this.ViewLobby();
    ChatBox.Instance.Init(ColorScheme.GetColor(Global.ColorGameText));
    AudioManager.PlayMusicMainMenu();
    if (Client._gameFacts.GetRatedMode())
      ChatBox.Instance.NewChatMsg("This is a rated lobby.", (Color) ColorScheme.GetColor(Global.ColorSystem));
    this.unratedTab._Start();
  }

  private void OnDestroy()
  {
    if (!((UnityEngine.Object) UnratedMenu.instance == (UnityEngine.Object) this))
      return;
    UnratedMenu.instance = (UnratedMenu) null;
  }

  public void RefreshReadyStates(bool allOn)
  {
    this.allReady = allOn;
    if (UnratedMenu.readyStates != null)
    {
      for (int index = 0; index < this._containerAccounts.childCount && index < UnratedMenu.readyStates.Length; ++index)
        this._containerAccounts.GetChild(index).GetComponent<pfabName>().ready.gameObject.SetActive(UnratedMenu.readyStates[index]);
    }
    if (allOn)
      this.StartCoroutine(this.CountDown());
    this.SetStartButton();
  }

  public void SetStartButton()
  {
    if (UnratedMenu.readyStates == null || UnratedMenu.readyStates.Length != Client._gameFacts.players.Count)
      UnratedMenu.readyStates = new bool[Client._gameFacts.players.Count];
    if (Client._gameFacts.GetRatedMode() || Client._gameFacts.GetMultiTeamMode() || Client._gameFacts.GetTournamentMode())
    {
      string str1 = (string) null;
      if (Client._gameFacts.GetRatedMode())
      {
        Client._gameFacts.CalculateGameType();
        str1 = RatedFacts.GetGameTypeAsString((int) Client._gameFacts.gameType);
      }
      int index = Client._gameFacts.players.FindIndex((Predicate<string>) (z => string.Equals(z, Client.Name, StringComparison.CurrentCultureIgnoreCase)));
      if (index >= 0)
      {
        bool readyState = UnratedMenu.readyStates[index];
        TMP_Text buttonStartGameTxt = this.buttonStartGameTxt;
        string str2;
        if (!readyState)
        {
          if (!this.buttonStartGame.interactable)
            str2 = Client._gameFacts.players.Count.ToString() + "/" + (object) (2 * Client._gameFacts.GetNumberPlayersPerTeam()) + " Players";
          else
            str2 = "Ready";
        }
        else
          str2 = "Cancel";
        buttonStartGameTxt.text = str2;
        this.startGameImg.color = (Color) (readyState ? new Color32((byte) 147, (byte) 38, (byte) 38, byte.MaxValue) : new Color32((byte) 43, (byte) 147, (byte) 38, byte.MaxValue));
      }
      else
      {
        this.buttonStartGameTxt.text = "Ready";
        this.startGameImg.color = (Color) new Color32((byte) 43, (byte) 147, (byte) 38, byte.MaxValue);
        this.unratedTab.groupSpectate[0].Interactable(false);
        this.unratedTab.groupTeams[0].Interactable(false);
      }
      if (str1 == null)
        return;
      TMP_Text buttonStartGameTxt1 = this.buttonStartGameTxt;
      buttonStartGameTxt1.text = buttonStartGameTxt1.text + " (" + str1 + ")";
    }
    else
      this.buttonStartGameTxt.text = "Start Game";
  }

  public void SetReadyStatesOff()
  {
    this.StopAllCoroutines();
    this.allReady = false;
    UnratedMenu.readyStates = new bool[Client._gameFacts.players.Count];
    for (int index = 0; index < this._containerAccounts.childCount; ++index)
      this._containerAccounts.GetChild(index).GetComponent<pfabName>().ready.gameObject.SetActive(false);
    this.SetStartButton();
  }

  private IEnumerator CountDown()
  {
    float f = 5f;
    this.startGameImg.color = (Color) new Color32((byte) 147, (byte) 38, (byte) 38, byte.MaxValue);
    while (this.allReady && UnratedMenu.readyStates != null)
    {
      f -= Time.deltaTime;
      if ((double) f < 0.0)
        f = 0.0f;
      this.buttonStartGameTxt.text = "Starting in " + (object) (int) ((double) f + 0.5);
      yield return (object) new WaitForEndOfFrame();
    }
  }

  public void ClickAddFriend()
  {
    MyContextMenu myContextMenu = MyContextMenu.Show();
    myContextMenu.AddSeperator("Name of Friend");
    myContextMenu.AddInput((Action<string>) (s =>
    {
      if (string.IsNullOrEmpty(s) || s.Length > 13)
        return;
      Client.AskToAddFriend(true, true, s);
    }), (string) null, false);
    myContextMenu.Rebuild(false);
  }

  public void RightClickDescription()
  {
  }

  public void ClickSettings()
  {
    Controller.ShowSettingsMenu(false);
  }

  public void ClickPrestige()
  {
    Controller.ShowPrestigeMenu();
  }

  public void HoverSimiliarRating()
  {
    MyToolTip.Show(Mathf.Max(1000, (int) Client.GetAccount(Client._gameFacts.players[0], false).similarRating).ToString() + "-" + (object) ((int) Client.GetAccount(Client._gameFacts.players[0], false).similarRating + 500), -1f);
  }

  public void OpenInvitePlayers()
  {
    int index1 = 0;
    int num1 = 0;
    int num2 = (int) ((RectTransform) this.pfabInvite.transform).sizeDelta.y + 2;
    for (; index1 < Client._lobby.Count && index1 < this._containerInvite.childCount; ++index1)
      this._containerInvite.GetChild(index1).GetComponent<global::pfabInvite>().Setup(Client.GetAccount(Client._lobby.GetItem(index1).Key, false));
    for (; index1 < Client._lobby.Count; ++index1)
    {
      Account account = Client.GetAccount(Client._lobby.GetItem(index1).Key, false);
      GameObject andApply = Controller.Instance.CreateAndApply(this.pfabInvite, (Transform) this._containerInvite);
      ((RectTransform) andApply.transform).anchoredPosition = new Vector2((float) num1, (float) (-index1 * num2));
      andApply.GetComponent<global::pfabInvite>().Setup(account);
    }
    int num3 = index1;
    for (int index2 = this._containerInvite.childCount - 1; index2 >= num3; --index2)
      UnityEngine.Object.Destroy((UnityEngine.Object) this._containerInvite.GetChild(index2).gameObject);
    this._containerInvite.sizeDelta = new Vector2(this._containerInvite.sizeDelta.x, (float) (num2 * num3));
    this.panelInvite.SetActive(true);
  }

  public void HideInvitePlayers()
  {
    this.panelInvite.SetActive(false);
  }

  public void ToggleAll(UIOnHover[] group)
  {
    for (int index = 0; index < group.Length; ++index)
    {
      if (group[index].AlwaysOn)
        group[index].AlwaysOn = false;
    }
  }

  private void Update()
  {
    if (!Input.GetKeyDown(KeyCode.F12) || !Input.GetKey(KeyCode.LeftControl) || !Client.MyAccount.accountType.isDev())
      return;
    this.UploadToServer();
  }

  public void RefreshFriends(bool updatePos = false)
  {
    if (this.viewing != Viewing.Friends)
      return;
    this.txtNumPlayers.text = "Friends " + (object) Client.friends.Count + " / 200";
    this.txtRateType.text = "";
    int num1 = (int) ((RectTransform) this.pfabFriend.transform).sizeDelta.y + 2;
    int num2 = 2;
    List<(string, int)> valueTupleList = new List<(string, int)>();
    foreach (string friend in Client.friends)
      valueTupleList.Add((friend, Client.GetAccount(friend, false).location.Online() ? 1 : 0));
    valueTupleList.Sort((Comparison<(string, int)>) ((a, b) => a.online == b.online ? a.name.CompareTo(b.name) : b.online - a.online));
    this._containerAccounts.DestroyChildern();
    this._containerAccounts.sizeDelta = new Vector2(this._containerAccounts.sizeDelta.x, (float) (num1 * valueTupleList.Count + 35));
    for (int index1 = 0; index1 < valueTupleList.Count; ++index1)
    {
      GameObject andApply = Controller.Instance.CreateAndApply(this.pfabFriend, (Transform) this._containerAccounts);
      ((RectTransform) andApply.transform).anchoredPosition = new Vector2((float) num2, (float) (-index1 * num1 - 2 - 35));
      pfabName component = andApply.GetComponent<pfabName>();
      component.Setup(valueTupleList[index1].Item1, false);
      int server = Client.GetAccount(valueTupleList[index1].Item1, false).server;
      int index2 = valueTupleList[index1].Item2 == 1 ? (Client.MyAccount.server == server ? 1 : 2) : 0;
      if (server > 0)
        component.txtName.text += string.Format(" ({0})", (object) server);
      component.ready.color = pfabName.colorStatus[index2];
      component.txtName.color = pfabName.colorStatus[index2];
    }
    if (!updatePos)
      return;
    this.SetScrollValue();
  }

  public void RefreshIgnore(bool updatePos = false)
  {
    if (this.viewing != Viewing.Ignore)
      return;
    this.txtNumPlayers.text = "Ignored " + (object) Client.ignore.Count + " / 100";
    this.txtRateType.text = "";
    int num1 = (int) ((RectTransform) this.pfabFriend.transform).sizeDelta.y + 2;
    int num2 = 2;
    List<string> stringList = new List<string>();
    foreach (string str in Client.ignore)
      stringList.Add(str);
    stringList.Sort();
    List<Client.TempIgnored.Who> whoList = new List<Client.TempIgnored.Who>();
    foreach (Client.TempIgnored.Who who in Client.tempIgnored.list)
      whoList.Add(who);
    whoList.Sort((Comparison<Client.TempIgnored.Who>) ((a, b) => a.name.CompareTo(b.name)));
    this._containerAccounts.DestroyChildern();
    this._containerAccounts.sizeDelta = new Vector2(this._containerAccounts.sizeDelta.x, (float) (num1 * (stringList.Count + whoList.Count)));
    for (int index = 0; index < stringList.Count; ++index)
    {
      GameObject andApply = Controller.Instance.CreateAndApply(this.pfabFriend, (Transform) this._containerAccounts);
      ((RectTransform) andApply.transform).anchoredPosition = new Vector2((float) num2, (float) (-index * num1 - 2));
      andApply.GetComponent<pfabName>().Setup(stringList[index], false);
    }
    for (int index = 0; index < whoList.Count; ++index)
    {
      GameObject andApply = Controller.Instance.CreateAndApply(this.pfabFriend, (Transform) this._containerAccounts);
      ((RectTransform) andApply.transform).anchoredPosition = new Vector2((float) num2, (float) ((-index - stringList.Count) * num1 - 2));
      andApply.GetComponent<pfabName>().SetupIgnored(whoList[index].name, whoList[index].TimeTill());
    }
    if (!updatePos)
      return;
    this.SetScrollValue();
  }

  public void RefreshClan(bool updatePos = false)
  {
    if (this.viewing != Viewing.Clan)
      return;
    this.txtRateType.text = "Role";
    if (Client.clan == null)
    {
      this.txtNumPlayers.text = "You're not in a clan :(";
      this._containerAccounts.DestroyChildern();
      this._containerAccounts.sizeDelta = new Vector2(this._containerAccounts.sizeDelta.x, 20f);
    }
    else
    {
      this.txtNumPlayers.text = "Clan " + (object) Client.clan.members.Count + " / 100";
      int num1 = (int) ((RectTransform) this.pfabFriend.transform).sizeDelta.y + 2;
      int num2 = 2;
      List<Clan.MemberX> memberXList = new List<Clan.MemberX>();
      foreach (KeyValuePair<string, Clan.Roles> member in Client.clan.members)
        memberXList.Add(new Clan.MemberX()
        {
          name = member.Key,
          role = member.Value,
          acc = Client.GetAccount(member.Key, false)
        });
      memberXList.Sort((Comparison<Clan.MemberX>) ((a, b) => b.acc.location.Online() == a.acc.location.Online() ? (b.role == a.role ? a.name.CompareTo(b.name) : (int) (b.role - a.role)) : (!b.acc.location.Online() ? -1 : 1)));
      this._containerAccounts.DestroyChildern();
      this._containerAccounts.sizeDelta = new Vector2(this._containerAccounts.sizeDelta.x, (float) (num1 * memberXList.Count + 2));
      for (int index1 = 0; index1 < memberXList.Count; ++index1)
      {
        GameObject andApply = Controller.Instance.CreateAndApply(this.pfabFriend, (Transform) this._containerAccounts);
        ((RectTransform) andApply.transform).anchoredPosition = new Vector2((float) num2, (float) (-index1 * num1 - 2));
        pfabName component = andApply.GetComponent<pfabName>();
        component.Setup(memberXList[index1].name, false);
        component.txtRating.text = "(" + memberXList[index1].role.ToString().Replace('_', ' ') + ")";
        int server = Client.GetAccount(memberXList[index1].name, false).server;
        int index2 = memberXList[index1].acc.location.Online() ? (Client.MyAccount.server == server ? 1 : 2) : 0;
        if (server > 0)
          component.txtName.text += string.Format(" ({0})", (object) server);
        component.ready.color = pfabName.colorStatus[index2];
        component.txtName.color = pfabName.colorStatus[index2];
      }
      if (!updatePos)
        return;
      this.SetScrollValue();
    }
  }

  public void RefreshActive()
  {
    this.RefreshNames(false, false);
    this.RefreshFriends(false);
    this.RefreshIgnore(false);
    this.RefreshClan(false);
  }

  public void RefreshNames(bool setReadyStates = true, bool updatePos = false)
  {
    if ((UnityEngine.Object) this.txtName != (UnityEngine.Object) null)
      this.txtName.text = Client.Name;
    if (setReadyStates)
      this.SetReadyStatesOff();
    this.isFirst = string.Equals(Client._gameFacts.players[0], Client.Name, StringComparison.OrdinalIgnoreCase);
    this.UpdateStartButton();
    if (this.viewing != Viewing.Lobby)
      return;
    this.txtRateType.text = "Rating";
    this.UpdatePlayerCount();
    this.txtGameOwner.text = !(Client._gameFacts.players[0] == Client.Name) ? Client._gameFacts.players[0] + "'s Game" : "Your Game";
    int num1 = (int) ((RectTransform) this.pfabNames.transform).sizeDelta.y + 2;
    int num2 = 2;
    int index1 = 0;
    this._containerAccounts.sizeDelta = new Vector2(this._containerAccounts.sizeDelta.x, (float) (num1 * Client._gameFacts.players.Count));
    for (; index1 < Client._gameFacts.players.Count && index1 < this._containerAccounts.childCount; ++index1)
      this._containerAccounts.GetChild(index1).GetComponent<pfabName>().Setup(Client.GetAccount(Client._gameFacts.players[index1], false), UnratedMenu.readyStates != null && UnratedMenu.readyStates.Length > index1 && UnratedMenu.readyStates[index1]);
    for (; index1 < Client._gameFacts.players.Count; ++index1)
    {
      GameObject andApply = Controller.Instance.CreateAndApply(this.pfabNames, (Transform) this._containerAccounts);
      ((RectTransform) andApply.transform).anchoredPosition = new Vector2((float) num2, (float) (-index1 * num1 - 2));
      andApply.GetComponent<pfabName>().Setup(Client.GetAccount(Client._gameFacts.players[index1], false), false);
    }
    int num3 = index1;
    for (int index2 = this._containerAccounts.childCount - 1; index2 >= num3; --index2)
      UnityEngine.Object.Destroy((UnityEngine.Object) this._containerAccounts.GetChild(index2).gameObject);
    if (!updatePos)
      return;
    this.SetScrollValue();
  }

  public bool IsAdvanced()
  {
    return this.unratedTab.IsAdvanced();
  }

  public void ClickToggleAdvanced()
  {
    this.ToggleAdvanced(!this.unratedTab.advanced);
  }

  public void ToggleAdvanced(bool v)
  {
    this.unratedTab.ToggleAdvanced(v);
  }

  public void AskToChangeElementalLevel(int x)
  {
    Client.AskToChangeGameMode(GameFacts.Message.ElementalLevel, x);
  }

  public void AskToChangeStartHealth(int x)
  {
    Client.AskToChangeGameMode(GameFacts.Message.StartHealth, x);
  }

  public void AskToChangeArmageddonTurn(int x)
  {
    Client.AskToChangeGameMode(GameFacts.Message.ArmageddonTurn, x);
  }

  public void AskToChangeMaxTime(int x)
  {
    Client.AskToChangeGameMode(GameFacts.Message.MaxTime, x);
  }

  public void AskToChangeDelay(int x)
  {
    Client.AskToChangeGameMode(GameFacts.Message.Delay, x);
  }

  public void AskToChangeMapSize(int x)
  {
    Client.AskToChangeGameMode(GameFacts.Message.Map_Size, x);
  }

  public void AskToChangeMapSeed(int x)
  {
    Client.AskToChangeGameMode(GameFacts.Message.Map_Seed, x);
  }

  public void AskToDisableMapSeed()
  {
    Client.AskToChangeGameMode(GameFacts.Message.Disable_Map_Seed, 0);
  }

  public void AskAddCustomArmageddon(int x)
  {
    Client.AskToChangeGameMode(GameFacts.Message.Custom_Armageddon, x);
  }

  public void AskRemoveCustomArmageddon(int x)
  {
    Client.AskToChangeGameMode(GameFacts.Message.Remove_Custom_Armageddon, x);
  }

  public void Ask(GameFacts.Message g, int x)
  {
    Client.AskToChangeGameMode(g, x);
  }

  [EnumAction(typeof (GameStyle))]
  public void AskToChangeGameStyle(int x)
  {
    Client.AskToChangeGameMode(GameFacts.Message.GameStyle, x);
  }

  [EnumAction(typeof (RatedEnum))]
  public void AskToChangeTournament(int x)
  {
    if (!Client.MyAccount.accountType.IsModPlusTOParticipate())
      return;
    Client.AskToChangeGameMode(GameFacts.Message.Tournament, x);
  }

  [EnumAction(typeof (InviteEnum))]
  public void AskToChangeGameModeInvite(int x)
  {
    Client.AskToChangeGameMode(GameFacts.Message.Invite_Mode, x);
  }

  [EnumAction(typeof (PlayerEnum))]
  public void AskToChangeGameModePlayers(int x)
  {
    Client.AskToChangeGameMode(GameFacts.Message.Players, x);
  }

  [EnumAction(typeof (SpectatorsEnum))]
  public void AskToChangeGameModeSpectators(int x)
  {
    Client.AskToChangeGameMode(GameFacts.Message.Spectators, x);
  }

  [EnumAction(typeof (TimeEnum))]
  public void AskToChangeGameModeTime(int x)
  {
    Client.AskToChangeGameMode(GameFacts.Message.Time, x);
  }

  [EnumAction(typeof (TimeEnum))]
  public void AskToChangeCustomPlayers(int x)
  {
    Client.AskToChangeGameMode(GameFacts.Message.CustomPlayerCount, x);
  }

  public void AskToChangeCustomTime(int x)
  {
    Client.AskToChangeGameMode(GameFacts.Message.CustomTime, x);
  }

  [EnumAction(typeof (MapEnum))]
  public void AskToChangeGameModeMap(int x)
  {
    Client.AskToChangeGameMode(GameFacts.Message.Map, x);
  }

  [EnumAction(typeof (MapEnum))]
  public void AskToChangeArmageddon(int x)
  {
    Client.AskToChangeGameMode(GameFacts.Message.Armageddon, x);
  }

  [EnumAction(typeof (MapEnum))]
  public void AskToToggleGameModeMap(int x)
  {
    Client.AskToChangeGameMode(GameFacts.Message.AddMap, x);
  }

  [EnumAction(typeof (MapEnum))]
  public void AskToToggleArmageddon(int x)
  {
    Client.AskToChangeGameMode(GameFacts.Message.AddArmageddon, x);
  }

  [EnumAction(typeof (TeamEnum))]
  public void AskToChangeGameModeTeams(int x)
  {
    Client.AskToChangeGameMode(GameFacts.Message.Team, x);
  }

  [EnumAction(typeof (PlayersPerTeam))]
  public void AskToChangePlayersPerTeam(int x)
  {
    Client.AskToChangeGameMode(GameFacts.Message.PerTeam, x);
  }

  private void UpdatePlayerCount()
  {
    this.txtNumPlayers.text = "Players: " + (object) Client._gameFacts.players.Count + "/" + (object) Client._gameFacts.customPlayerCount;
  }

  private IEnumerator DelayStart()
  {
    this.buttonStartGame.interactable = false;
    for (float i = this.isFirst ? 5.5f : 5f; (double) i > 0.0; i -= Time.deltaTime)
    {
      this.buttonStartGameTxt.text = "Settings Changed " + (object) (int) ((double) i + 0.490000009536743);
      yield return (object) new WaitForEndOfFrame();
    }
    bool flag = Client._gameFacts.GetTeamMode() && !Client._gameFacts.GetMultiTeamMode();
    if (Client._gameFacts.GetMultiTeamMode())
      this.buttonStartGame.interactable = true;
    else
      this.buttonStartGame.interactable = this.isFirst ? !flag || Client._gameFacts.players.Count % Client._gameFacts.GetNumberPlayersPerTeam() == 0 && Client._gameFacts.players.Count > Client._gameFacts.GetNumberPlayersPerTeam() : Client._gameFacts.GetTournamentMode();
    this.buttonStartGameTxt.text = "Start Game";
  }

  private void UpdateStartButton()
  {
    this.isFirst = string.Equals(Client._gameFacts.players[0], Client.Name, StringComparison.OrdinalIgnoreCase);
    this.buttonInvite.interactable = true;
    bool flag1 = Client._gameFacts.GetTeamMode() && !Client._gameFacts.GetMultiTeamMode();
    bool flag2 = !Client._gameFacts.GetMultiTeamMode() || (!Client._gameFacts.GetRatedMode() || Client._gameFacts.players.Count == 2);
    this.buttonStartGame.interactable = (this.isFirst || Client._gameFacts.GetRatedMode() || (Client._gameFacts.GetMultiTeamMode() || Client._gameFacts.GetTournamentMode())) && (flag1 ? Client._gameFacts.players.Count % Client._gameFacts.GetNumberPlayersPerTeam() == 0 && Client._gameFacts.players.Count > Client._gameFacts.GetNumberPlayersPerTeam() : flag2);
    this.SetStartButton();
  }

  public void RefreshGameOptions()
  {
    this.unratedTab.RefreshGameOptions();
    this.UpdateStartButton();
    this.UpdatePlayerCount();
    this.txtDescription.text = Client._gameFacts.settings.FilteredDescription();
    SpellLobbyChange.Instance?.RefreshList();
    this.spellImageList?.SetSpells();
    if (this.IsFirst)
    {
      Client._gameSettings = Global.Copy<GameSettings>(Client._gameFacts.settings);
      Inert.SaveSettingsPlayer();
    }
    if (Client._gameFacts.GetMultiTeamMode())
    {
      if (Client.multiSettingsPlayer.Count == 0)
      {
        for (int index = 0; index < 12; ++index)
        {
          SettingsPlayer settingsPlayer = new SettingsPlayer();
          settingsPlayer.CopyOutfit(Client.settingsPlayer);
          settingsPlayer.CopySpells(Client.settingsPlayer, true);
          Client.multiSettingsPlayer.Add(settingsPlayer);
        }
      }
      if (this.multiBooks.Count < Client.multiSettingsPlayer.Count)
      {
        for (int index = 1; index < 12; ++index)
        {
          MultiSelectConfig multiSelectConfig = UnityEngine.Object.Instantiate<MultiSelectConfig>(this.multiBooks[0], this.multiBooks[0].transform.parent);
          multiSelectConfig.settings = Client.multiSettingsPlayer[index];
          multiSelectConfig.spells.settingsPlayer = multiSelectConfig.settings;
          multiSelectConfig.spells.SetSpells(multiSelectConfig.settings);
          multiSelectConfig.UpdateOutfit();
          this.multiBooks.Add(multiSelectConfig);
        }
        this.multiBooks[0].settings = Client.multiSettingsPlayer[0];
        this.multiBooks[0].spells.settingsPlayer = this.multiBooks[0].settings;
        this.multiBooks[0].spells.SetSpells(this.multiBooks[0].settings);
        this.multiBooks[0].UpdateOutfit();
      }
      int num = Client._gameFacts.GetNumberPlayersPerTeam() - 1;
      for (int index = 0; index < this.multiBooks.Count; ++index)
        this.multiBooks[index].gameObject.SetActive(index < num);
      this.buttonMultiBookPanel.SetActive(true);
    }
    else
      this.buttonMultiBookPanel.SetActive(false);
    if (!this.unratedTab.advanced && this.IsAdvanced() || Global.GetPrefBool("prefadvanced", false))
      this.ToggleAdvanced(true);
    this.buttonAdvanced.AlwaysOn = this.unratedTab.advanced;
    DiscordIntergration.Instance?.UpdateActivity(Client._gameFacts, false, false);
  }

  public void ToggleMultiBookPanel()
  {
    this.panelMultiBooks.SetActive(!this.panelMultiBooks.activeSelf);
  }

  public void ClickResetAll()
  {
    foreach (MultiSelectConfig multiBook in this.multiBooks)
    {
      multiBook.ClickResetOutfit();
      multiBook.ClickResetSpells();
    }
  }

  public void AddName(Account a)
  {
    if (this.viewing != Viewing.Lobby)
      return;
    this.RefreshNames(true, false);
  }

  public void ViewLobby()
  {
    this.UpdateScrollValue();
    this.viewing = Viewing.Lobby;
    this.butViewLobby.AlwaysOn = true;
    this.butViewFriends.AlwaysOn = false;
    this.butViewIgnore.AlwaysOn = false;
    this.butViewClan.AlwaysOn = false;
    this.butAddFriend.gameObject.SetActive(this.butViewFriends.AlwaysOn);
    this._containerAccounts.DestroyChildern();
    this.RefreshNames(false, false);
  }

  public void ViewFriends()
  {
    this.UpdateScrollValue();
    this.viewing = Viewing.Friends;
    this.butViewLobby.AlwaysOn = false;
    this.butViewFriends.AlwaysOn = true;
    this.butViewIgnore.AlwaysOn = false;
    this.butViewClan.AlwaysOn = false;
    this.butAddFriend.gameObject.SetActive(this.butViewFriends.AlwaysOn);
    this.RefreshFriends(true);
  }

  public void ViewIgnore()
  {
    this.UpdateScrollValue();
    this.viewing = Viewing.Ignore;
    this.butViewLobby.AlwaysOn = false;
    this.butViewFriends.AlwaysOn = false;
    this.butViewIgnore.AlwaysOn = true;
    this.butViewClan.AlwaysOn = false;
    this.butAddFriend.gameObject.SetActive(this.butViewFriends.AlwaysOn);
    this.RefreshIgnore(true);
  }

  public void ViewClan()
  {
    this.UpdateScrollValue();
    this.viewing = Viewing.Clan;
    this.butViewLobby.AlwaysOn = false;
    this.butViewFriends.AlwaysOn = false;
    this.butViewIgnore.AlwaysOn = false;
    this.butViewClan.AlwaysOn = true;
    this.butAddFriend.gameObject.SetActive(false);
    this.RefreshClan(true);
  }

  public void UpdateOnlineUI(string n)
  {
    if (this.viewing == Viewing.Friends && Client.HasFriend(n))
    {
      this.RefreshFriends(false);
    }
    else
    {
      if (this.viewing != Viewing.Clan || Client.clan == null || !Client.clan.members.ContainsKey(n))
        return;
      this.RefreshClan(false);
    }
  }

  public void ClickLobby()
  {
    Client.AskToJoinLobby();
  }

  public void ClickInvitePlayers()
  {
  }

  public void ClickStartGame()
  {
    if (Client._gameFacts.GetMultiTeamMode())
      Client.AskReadyMulti();
    else if (Client._gameFacts.GetRatedMode() || Client._gameFacts.GetTournamentMode())
      Client.Ask((byte) 17);
    else
      Client.AskToStart();
  }

  public void UpdateSpellIcons()
  {
    this.spellImageList.SetSpells();
  }

  public void UpdateOutfit()
  {
    this.spellImageList.UpdateOutfit();
    PrestigeLobbyUI.Instance?.RefreshOutfit();
  }

  public void ToolTip(string s)
  {
    MyToolTip.Show(s, -1f);
  }

  public void HoverCountdown()
  {
    MyToolTip.Show("Countdown: " + Mathf.Abs((int) Client._gameFacts.countdownTime).ToString() + (Client._gameFacts.countdownTime > (short) 0 ? " seconds<br>If time runs out you will get 5 second turns from then on." : " seconds<br><#FF0000>If time runs out you lose</color><br>Turn time is still used."), -1f);
  }

  public void HideToolTip()
  {
    MyToolTip.Close();
  }

  public void ClickMapSize(bool width)
  {
    if (!this.IsFirst)
      return;
    MyContextMenu myContextMenu = MyContextMenu.Show();
    myContextMenu.AddSeperator("Map " + (width ? "Width: " + (object) Client._gameFacts.settings.mapWidth : "Height: " + (object) Client._gameFacts.settings.mapHeight));
    myContextMenu.AddSeperator("Valid range: 50% through 150%");
    if (width)
      myContextMenu.AddInput((Action<string>) (v =>
      {
        int result = 0;
        if (string.IsNullOrEmpty(v) || !int.TryParse(v, out result))
          return;
        this.AskToChangeMapSize(CombineBytes.To((byte) result, Client._gameFacts.settings.mapHeight));
      }), (string) null, false);
    else
      myContextMenu.AddInput((Action<string>) (v =>
      {
        int result = 0;
        if (string.IsNullOrEmpty(v) || !int.TryParse(v, out result))
          return;
        this.AskToChangeMapSize(CombineBytes.To(Client._gameFacts.settings.mapWidth, (byte) result));
      }), (string) null, false);
    myContextMenu.Rebuild(false);
  }

  public void ClickMapSeed()
  {
    if (!this.IsFirst)
      return;
    MyContextMenu myContextMenu = MyContextMenu.Show();
    myContextMenu.AddSeperator("Map Seed: " + (object) Client._gameFacts.settings.mapSeed);
    myContextMenu.AddInput((Action<string>) (v =>
    {
      int result = 0;
      if (string.IsNullOrEmpty(v) || !int.TryParse(v, out result))
        return;
      this.AskToChangeMapSeed(result);
    }), (string) null, false);
    myContextMenu.AddSeperator("-------------------------------");
    myContextMenu.AddItem("Use Random Seed", (Action) (() => this.AskToDisableMapSeed()), (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
    myContextMenu.Rebuild(false);
  }

  public void ClickPickElementalLevel()
  {
    if (!this.IsFirst)
      return;
    MyContextMenu myContextMenu = MyContextMenu.Show();
    ButtonArrayContextmenu arrayContextmenu = myContextMenu.AddArray();
    arrayContextmenu.AddItem("Off", (Action) (() => this.AskToChangeElementalLevel(-2)), (string) null);
    arrayContextmenu.AddItem("0", (Action) (() => this.AskToChangeElementalLevel(0)), (string) null);
    arrayContextmenu.AddItem("1", (Action) (() => this.AskToChangeElementalLevel(1)), (string) null);
    arrayContextmenu.AddItem("2", (Action) (() => this.AskToChangeElementalLevel(2)), (string) null);
    arrayContextmenu.AddItem("3", (Action) (() => this.AskToChangeElementalLevel(3)), (string) null);
    arrayContextmenu.AddItem("4", (Action) (() => this.AskToChangeElementalLevel(4)), (string) null);
    arrayContextmenu.AddItem("5", (Action) (() => this.AskToChangeElementalLevel(5)), (string) null);
    myContextMenu.Rebuild(false);
  }

  public void ClickPickStartingHealth()
  {
    if (!this.IsFirst)
      return;
    MyContextMenu myContextMenu = MyContextMenu.Show();
    myContextMenu.AddSeperator("Staring Health: 1 - 500");
    myContextMenu.AddInput((Action<string>) (s =>
    {
      float result = 0.0f;
      if (!float.TryParse(s, out result))
        return;
      this.AskToChangeStartHealth((int) result);
    }), (string) null, false);
    myContextMenu.Rebuild(false);
  }

  public void ClickArmageddonTurn()
  {
    if (!this.IsFirst)
      return;
    MyContextMenu myContextMenu = MyContextMenu.Show();
    myContextMenu.AddSeperator("Armageddon turn (0 is the first turn)");
    myContextMenu.AddInput((Action<string>) (s =>
    {
      float result = 0.0f;
      if (!float.TryParse(s, out result))
        return;
      this.AskToChangeArmageddonTurn((int) result);
    }), (string) null, false);
    myContextMenu.Rebuild(false);
  }

  public void ClickMaxTime()
  {
    if (!this.IsFirst)
      return;
    MyContextMenu myContextMenu = MyContextMenu.Show();
    myContextMenu.AddItem("None", (Action) (() => this.AskToChangeMaxTime(0)), (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
    myContextMenu.AddSeperator("If a negative value is used - the player loses when time runs out - otherwise they get 5 sec turns");
    myContextMenu.AddSeperator("Time in Seconds (ex: 240)");
    myContextMenu.AddSeperator("End with an m for minutes (ex: 5m)");
    myContextMenu.AddSeperator("Or use a ':' (ex: 5:15)");
    myContextMenu.AddInput((Action<string>) (s =>
    {
      int num1 = 1;
      int num2 = 1;
      if (s.EndsWith("m"))
      {
        s = s.Substring(0, s.Length - 1).Trim();
        num1 = 60;
      }
      if (s.StartsWith("-"))
      {
        num2 = -1;
        s = s.Substring(1);
      }
      if (s.Contains(":"))
      {
        string[] strArray = s.Split(':');
        float result1 = 0.0f;
        float result2 = 0.0f;
        float.TryParse(strArray[0], out result1);
        float.TryParse(strArray[1], out result2);
        this.AskToChangeMaxTime(num2 * (int) ((double) result1 * 60.0 + (double) result2));
      }
      else
      {
        float result = 0.0f;
        float.TryParse(s, out result);
        this.AskToChangeMaxTime(num2 * (int) ((double) result * (double) num1));
      }
    }), (string) null, false);
    myContextMenu.Rebuild(false);
  }

  public void ClickDelay()
  {
    if (!this.IsFirst)
      return;
    MyContextMenu myContextMenu = MyContextMenu.Show();
    myContextMenu.AddSeperator("Delay each turn before the countdown starts");
    myContextMenu.AddInput((Action<string>) (s =>
    {
      float result = 0.0f;
      if (!float.TryParse(s, out result))
        return;
      this.AskToChangeDelay((int) result);
    }), (string) null, false);
    myContextMenu.Rebuild(false);
  }

  public void ClickDescription()
  {
    if (!this.IsFirst)
      return;
    MyContextMenu myContextMenu = MyContextMenu.Show();
    myContextMenu.AddSeperator("Game's Description");
    myContextMenu.AddInput((Action<string>) (s => Client.AskToChangeDescription(s)), Client._gameFacts.settings.description, true);
    if (Client._gameFacts.GetRatedMode())
      myContextMenu.AddSeperator("<#FF0000>----Rated Game So these do nothing----");
    myContextMenu.AddSeperator("Obscure Game Options");
    for (int index = 0; index < ZGame.MoreGameOptions.GetLength(0); ++index)
    {
      int z = index;
      if (Client._gameFacts.settings.description.Contains(ZGame.MoreGameOptions[index, 0]))
        myContextMenu.AddItem(ZGame.MoreGameOptions[index, 0] + " | " + ZGame.MoreGameOptions[index, 1], (Action) (() =>
        {
          if (!this.IsFirst)
            return;
          Client.AskToChangeDescription(Client._gameFacts.settings.description.Replace(ZGame.MoreGameOptions[z, 0], ""));
        }), MyContextMenu.ColorRed);
      else
        myContextMenu.AddItem(ZGame.MoreGameOptions[index, 0] + " | " + ZGame.MoreGameOptions[index, 1], (Action) (() =>
        {
          if (!this.IsFirst)
            return;
          Client.AskToChangeDescription(Client._gameFacts.settings.description + ZGame.MoreGameOptions[z, 0]);
        }), MyContextMenu.ColorGreen);
    }
    myContextMenu.Rebuild(false);
  }

  public void ClickCustomPlayers()
  {
    if (!this.IsFirst)
      return;
    MyContextMenu myContextMenu = MyContextMenu.Show();
    ButtonArrayContextmenu arrayContextmenu = myContextMenu.AddArray();
    arrayContextmenu.AddItem("2", (Action) (() => this.AskToChangeGameModePlayers(67108864)), (string) null);
    arrayContextmenu.AddItem("3", (Action) (() => this.AskToChangeGameModePlayers(134217728)), (string) null);
    arrayContextmenu.AddItem("4", (Action) (() => this.AskToChangeGameModePlayers(268435456)), (string) null);
    arrayContextmenu.AddItem("5", (Action) (() => this.AskToChangeGameModePlayers(536870912)), (string) null);
    arrayContextmenu.AddItem("6", (Action) (() => this.AskToChangeGameModePlayers(1073741824)), (string) null);
    myContextMenu.AddSeperator("Players 1 - 24");
    myContextMenu.AddInput((Action<string>) (s =>
    {
      float result = 0.0f;
      if (!float.TryParse(s, out result))
        return;
      this.AskToChangeCustomPlayers((int) result);
    }), (string) null, false);
    myContextMenu.Rebuild(false);
  }

  public void ClickCustomTime()
  {
    if (!this.IsFirst)
      return;
    MyContextMenu myContextMenu = MyContextMenu.Show();
    ButtonArrayContextmenu arrayContextmenu = myContextMenu.AddArray();
    arrayContextmenu.AddItem("5", (Action) (() => this.AskToChangeGameModeTime(32)), (string) null);
    arrayContextmenu.AddItem("7", (Action) (() => this.AskToChangeGameModeTime(262144)), (string) null);
    arrayContextmenu.AddItem("10", (Action) (() => this.AskToChangeGameModeTime(16384)), (string) null);
    arrayContextmenu.AddItem("15", (Action) (() => this.AskToChangeGameModeTime(1048576)), (string) null);
    arrayContextmenu.AddItem("20", (Action) (() => this.AskToChangeGameModeTime(8192)), (string) null);
    arrayContextmenu.AddItem("30", (Action) (() => this.AskToChangeGameModeTime(4096)), (string) null);
    arrayContextmenu.AddItem("45", (Action) (() => this.AskToChangeGameModeTime(2048)), (string) null);
    arrayContextmenu.AddItem("60", (Action) (() => this.AskToChangeGameModeTime(1024)), (string) null);
    arrayContextmenu.AddItem("90", (Action) (() => this.AskToChangeGameModeTime(512)), (string) null);
    arrayContextmenu.AddItem("120", (Action) (() => this.AskToChangeGameModeTime(256)), (string) null);
    myContextMenu.AddSeperator("5 - 120");
    myContextMenu.AddInput((Action<string>) (s =>
    {
      float result = 0.0f;
      if (!float.TryParse(s, out result))
        return;
      this.AskToChangeCustomTime((int) result);
    }), (string) null, false);
    myContextMenu.Rebuild(false);
  }

  public void ClickMapOptions()
  {
    if (!this.IsFirst)
      return;
    MyContextMenu myContextMenu = MyContextMenu.Show();
    myContextMenu.AddItem("Alternate Map Generation", (Action) (() => this.Ask(GameFacts.Message.Alternate_Generation, 0)), (Color) (Client._gameFacts.settings.altGeneration ? ColorScheme.GetColor(MyContextMenu.ColorRed) : ColorScheme.GetColor(MyContextMenu.ColorCream)));
    myContextMenu.AddSeperator("--------------------------");
    myContextMenu.AddSeperator("----Water Styles----");
    myContextMenu.AddItem("Map Default", (Action) (() => this.Ask(GameFacts.Message.Water, 0)), (Color) (Client._gameFacts.settings.water == WaterStyle.Default ? ColorScheme.GetColor(MyContextMenu.ColorRed) : ColorScheme.GetColor(MyContextMenu.ColorCream)));
    myContextMenu.AddItem("Water", (Action) (() => this.Ask(GameFacts.Message.Water, 3)), (Color) (Client._gameFacts.settings.water == WaterStyle.Water ? ColorScheme.GetColor(MyContextMenu.ColorRed) : ColorScheme.GetColor(MyContextMenu.ColorCream)));
    myContextMenu.AddItem("Ground", (Action) (() => this.Ask(GameFacts.Message.Water, 2)), (Color) (Client._gameFacts.settings.water == WaterStyle.Ground ? ColorScheme.GetColor(MyContextMenu.ColorRed) : ColorScheme.GetColor(MyContextMenu.ColorCream)));
    myContextMenu.AddItem("No Water", (Action) (() => this.Ask(GameFacts.Message.Water, 1)), (Color) (Client._gameFacts.settings.water == WaterStyle.No_Water ? ColorScheme.GetColor(MyContextMenu.ColorRed) : ColorScheme.GetColor(MyContextMenu.ColorCream)));
    myContextMenu.Rebuild(false);
  }

  public void ClickArmageddonAdditionalOptions()
  {
    if (!this.IsFirst)
      return;
    MyContextMenu myContextMenu1 = MyContextMenu.Show();
    myContextMenu1.AddItem("Mos Le'Harmless - Zombie Monkeys", (Action) (() => this.AskToChangeGameStyle(32768)), (Color) (Client._gameFacts.GetStyle().HasStyle(GameStyle.Zombie_Monkey) ? ColorScheme.GetColor(MyContextMenu.ColorRed) : ColorScheme.GetColor(MyContextMenu.ColorCream)));
    myContextMenu1.AddSeperator("--------------------------");
    myContextMenu1.AddSeperator("----Custom Armageddon----(Not Compatible with normal Armageddons)");
    if (Client._gameFacts.settings.customArmageddon == null || Client._gameFacts.settings.customArmageddon.Count < 5)
      myContextMenu1.AddItem("Add Custom Armageddon", (Action) (() =>
      {
        MyContextMenu myContextMenu2 = MyContextMenu.Show();
        myContextMenu2.AddSpellSelector((UnityAction<SpellEnum>) (s => this.AskAddCustomArmageddon((int) s)), (Func<Spell, bool>) (spell => spell.level > 3 && !GameFacts.AllowCustomArmageddon(spell.spellEnum)), false);
        myContextMenu2.Rebuild(true);
      }), (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
    List<SpellEnum> customArmageddon = Client._gameFacts.settings.customArmageddon;
    if ((customArmageddon != null ? (__nonvirtual (customArmageddon.Count) > 0 ? 1 : 0) : 0) != 0)
    {
      if (Client._gameFacts.settings.customArmageddon.Count < 5)
        myContextMenu1.AddSeperator("--------------------------");
      for (int index = 0; index < Client._gameFacts.settings.customArmageddon.Count; ++index)
      {
        Spell spell = Inert.GetSpell(Client._gameFacts.settings.customArmageddon[index]);
        SpellEnum e = Client._gameFacts.settings.customArmageddon[index];
        if ((UnityEngine.Object) spell == (UnityEngine.Object) null)
          myContextMenu1.AddItem("Invalid Spell", (Action) (() => this.AskRemoveCustomArmageddon((int) e)), (Color) ColorScheme.GetColor(MyContextMenu.ColorRed));
        else
          myContextMenu1.AddItemWithImage(spell.name, ClientResources.Instance.GetSpellIcon(spell.name), (Action) (() => this.AskRemoveCustomArmageddon((int) e)), (Color) ColorScheme.GetColor(MyContextMenu.ColorRed), "");
      }
      myContextMenu1.AddSeperator("--------------------------");
      myContextMenu1.AddItem("Remove all Armageddons", (Action) (() => this.AskRemoveCustomArmageddon(-1)), (Color) ColorScheme.GetColor(MyContextMenu.ColorRed));
    }
    myContextMenu1.Rebuild(false);
  }

  public void ClickAutoIncludeSpells()
  {
    if (!this.IsFirst)
      return;
    MyContextMenu myContextMenu1 = MyContextMenu.Show();
    myContextMenu1.AddSeperator("----Auto Include spell book spells----");
    if (Client._gameFacts.settings.autoInclude == null || Client._gameFacts.settings.autoInclude.Count < 250)
    {
      myContextMenu1.AddItem("Add Auto Include Spell (You can select multiple)", (Action) (() =>
      {
        MyContextMenu myContextMenu2 = MyContextMenu.Show();
        myContextMenu2.AddSpellSelector((UnityAction<SpellEnum>) (s => this.Ask(GameFacts.Message.AutoInclude, (int) s)), (Func<Spell, bool>) (spell => spell.level > 3), true);
        myContextMenu2.AddItem("Close", (Action) null, MyContextMenu.ColorRed);
        myContextMenu2.Rebuild(true);
      }), (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
      myContextMenu1.AddSeperator("Note: You can only have 1 of each spell, selecting it again will remove it.");
    }
    List<SpellEnum> autoInclude = Client._gameFacts.settings.autoInclude;
    if ((autoInclude != null ? (__nonvirtual (autoInclude.Count) > 0 ? 1 : 0) : 0) != 0)
    {
      if (Client._gameFacts.settings.autoInclude.Count < 250)
        myContextMenu1.AddSeperator("--------------------------");
      for (int index = 0; index < Client._gameFacts.settings.autoInclude.Count; ++index)
      {
        Spell spell = Inert.GetSpell(Client._gameFacts.settings.autoInclude[index]);
        SpellEnum e = Client._gameFacts.settings.autoInclude[index];
        if ((UnityEngine.Object) spell == (UnityEngine.Object) null)
          myContextMenu1.AddItem("Invalid Spell", (Action) (() => this.Ask(GameFacts.Message.AutoInclude, (int) e)), (Color) ColorScheme.GetColor(MyContextMenu.ColorRed));
        else
          myContextMenu1.AddItemWithImage(spell.name, ClientResources.Instance.GetSpellIcon(spell.name), (Action) (() => this.Ask(GameFacts.Message.Remove_AutoInclude, (int) e)), (Color) ColorScheme.GetColor(MyContextMenu.ColorRed), "");
      }
      myContextMenu1.AddSeperator("--------------------------");
      myContextMenu1.AddItem("Remove all spells", (Action) (() => this.Ask(GameFacts.Message.Remove_AutoInclude, -1)), (Color) ColorScheme.GetColor(MyContextMenu.ColorRed));
    }
    myContextMenu1.Rebuild(false);
  }

  public void UploadToServer()
  {
    if (!Client.MyAccount.accountType.isDev())
      return;
    MyContextMenu myContextMenu = MyContextMenu.Show();
    myContextMenu.AddSeperator("-----Send As------");
    myContextMenu.AddItem("Low Time", (Action) (() => this._sendGameFactsToServer(1)), MyContextMenu.ColorGreen);
    myContextMenu.AddItem("High Time", (Action) (() => this._sendGameFactsToServer(2)), MyContextMenu.ColorGreen);
    myContextMenu.AddItem("Party Mode", (Action) (() => this._sendGameFactsToServer(3)), MyContextMenu.ColorGreen);
    myContextMenu.AddSeperator("-----Remove-----");
    myContextMenu.AddItem("Low Time", (Action) (() => this._sendGameFactsToServer(-1)), MyContextMenu.ColorRed);
    myContextMenu.AddItem("High Time", (Action) (() => this._sendGameFactsToServer(-2)), MyContextMenu.ColorRed);
    myContextMenu.AddItem("Party Mode", (Action) (() => this._sendGameFactsToServer(-3)), MyContextMenu.ColorRed);
  }

  private void _sendGameFactsToServer(int x)
  {
    List<string> players = Client._gameFacts.players;
    List<Connection> connections = Client._gameFacts.connections;
    HashSet<string> invitedPlayers = Client._gameFacts.invitedPlayers;
    Client._gameFacts.players = new List<string>();
    Client._gameFacts.connections = new List<Connection>();
    Client._gameFacts.invitedPlayers = new HashSet<string>();
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter writer = new myBinaryWriter((Stream) memoryStream))
      {
        writer.Write((byte) 109);
        writer.Write(x);
        Client._gameFacts.ManualSerialize(writer, false);
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
    Client._gameFacts.players = players;
    Client._gameFacts.connections = connections;
    Client._gameFacts.invitedPlayers = invitedPlayers;
  }

  public void ClickShowRestrictions()
  {
    PopupRestrictions.Create(Client._gameFacts.restrictions, this.IsFirst);
  }

  public void ClickReset()
  {
    Client._gameSettings = new GameSettings();
    if (!this.IsFirst)
      return;
    Client.AskAllSettings(Client._gameSettings);
    this.ToggleAdvanced(false);
  }

  public void LoadSettings()
  {
    MyFilePicker.Create("Load Settings", "GameSettings", ".gameSettings", false, (Action<string>) (s =>
    {
      Client._gameSettings = GameSettings.DeserializeFromFile(s);
      Client.AskAllSettings(Client._gameSettings);
      Inert.SaveSettingsPlayer();
      this.ToggleAdvanced(this.IsAdvanced() || Global.GetPrefBool("prefadvanced", false));
    }), ContentType.GameSettings, false);
  }

  public void SaveSettings()
  {
    GameSettings x = Global.Copy<GameSettings>(Client._gameFacts.settings);
    MyFilePicker.Create("Save Settings", "GameSettings", ".gameSettings", true, (Action<string>) (s => x.SerializeToFile(s)), ContentType.GameSettings, false);
    Inert.SaveSettingsPlayer();
  }
}
