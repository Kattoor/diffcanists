
using ChessConsole;
using Educative;
using Hazel;
using Hazel.Tcp;
using mattmc3.dotmore.Collections.Generic;
using MovementEffects;
using MyPolling;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;
using UnityThreading;

public static class Client
{
  public static Connection connection = (Connection) null;
  public static Dictionary<string, Account> _accounts = new Dictionary<string, Account>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
  public static OrderedDictionary<string, string> _lobby = new OrderedDictionary<string, string>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
  public static OrderedDictionary<int, GameFacts> _games = new OrderedDictionary<int, GameFacts>();
  public static OrderedDictionary<int, RatedContainer> _ratedSearches = new OrderedDictionary<int, RatedContainer>();
  public static Dictionary<int, RatedContainer> _NEWratedSearches = new Dictionary<int, RatedContainer>();
  public static IMiniGame miniGame = (IMiniGame) null;
  private static ColorScheme _scheme = (ColorScheme) null;
  private static ColorScheme _defscheme = (ColorScheme) null;
  public static bool allowtutorialDebugging = false;
  public static ZGame game = (ZGame) null;
  public static BitBools badges = new BitBools();
  private static Cosmetics _cosmetics = Server.DefaultCosmetics;
  public static ArcanistsStore.Item previewItem = (ArcanistsStore.Item) null;
  public static string sharingWith = "";
  public static float accountSticker = 0.0f;
  public static HashSet<string> friends = new HashSet<string>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
  public static HashSet<string> ignore = new HashSet<string>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
  public static Client.TempIgnored tempIgnored = new Client.TempIgnored();
  public static List<SettingsPlayer> multiSettingsPlayer = new List<SettingsPlayer>();
  public static Clan clan = (Clan) null;
  public static ViewSpellLocks viewSpellLocks = ViewSpellLocks.Locked;
  public static System.Random ranomdStuff = new System.Random();
  private static string[] DownloadFolders = new string[4]
  {
    "%USERPROFILE%\\Downloads",
    "~/Downloads/",
    "$HOME/.config/user-dirs.dirs",
    "$HOME/Downloads"
  };
  public static bool viewLTS = true;
  public static bool viewHTS = true;
  public static bool viewPMO = true;
  public static bool viewUnratedGames = true;
  public static bool viewRatedGames = true;
  public static byte[] randomBytes = (byte[]) null;
  public static bool displayName = true;
  public static bool displayMinionType = true;
  public static bool displayTeam = true;
  public static GameFacts _gameFacts = new GameFacts();
  public static RatedContainer _ratedFacts = new RatedContainer();
  public static GameSettings _gameSettings = new GameSettings();
  public static SettingsPlayer settingsPlayer = new SettingsPlayer();
  public static List<Report> reports = new List<Report>();
  public static string chatLog = "";
  public static int curGameID = 0;
  public static string Name = "Player";
  public static string identifier = "";
  public static string NameOrReplay = "";
  public static string currentIP = "";
  public static string serverIP = "18.117.245.0";
  public static string serverURL = "play.arcanists.com";
  public static byte[] cryp = (byte[]) null;
  public static int port = 43594;
  public static int webPort = 9998;
  public static int webPortInsecure = 9996;
  public static string pollName = "";
  public static int pollID = -1;
  public static bool Host = true;
  public static bool local = false;
  public static bool offlineMode = true;
  public static ulong discordID = 0;
  public static ChatSetting lobbyChat = ChatSetting.On;
  public static ChatSetting gameChat = ChatSetting.On;
  public static ChatSetting friendChat = ChatSetting.On;
  public static ChatSetting inviteChat = ChatSetting.On;
  public static ChatSetting spectatorChat = ChatSetting.On;
  public static ChatSetting clanChat = ChatSetting.On;
  public static ChatSetting teamChat = ChatSetting.On;
  public static ChatSetting minigameChat = ChatSetting.On;
  private static Client.JoinLocation joinLobby = Client.JoinLocation.Mainmenu;
  public static int joinGameId = 0;
  private static bool firstChatOnly = true;
  public static List<Achievement> achievements = new List<Achievement>();
  private static readonly string[] spawnNames = new string[23]
  {
    "Combatarek",
    "Sigtinius",
    "Magical Trix",
    "Darthvegas",
    "Rangers R Us",
    "Deadace 21",
    "Whiplash 99",
    "Squirrelkin1",
    "Coron Island",
    "I Dark Joker",
    "Zeme",
    "Nevets H",
    "Khaled57",
    "Idc Just Win",
    "N 0 V 1 S Fo",
    "Str Power Dx",
    "Seerkomp",
    "Tiger",
    "110",
    "Psapocalypse",
    "Sgt Killboy",
    "Arcanist40",
    "Desorienter"
  };
  private static float _lastOverheadEmoji = 0.0f;
  private static FixedInt _power = (FixedInt) 1;
  private static int debugLogchat = 0;
  internal static Queue<byte[]> delayedChatQue = new Queue<byte[]>();
  private static float chatquetime = 0.0f;
  private static float sharequetime = 0.0f;
  public static bool showBlood = true;
  public static Client.JoinLocation joinedFrom;
  public static ZGame.GameType gameType;
  public static Tutorial _tutorial;
  public static byte[] bytePass;
  public static AesManaged aes;
  public static EncryptionType en;
  private static IEnumerator<float> IEChatQue;

  public static ColorScheme colorScheme
  {
    get
    {
      if (Client._scheme == null)
        Client._scheme = ColorScheme.From(ClientResources.Instance._texturePalette);
      return Client._scheme;
    }
    set
    {
      Client._scheme = value;
    }
  }

  public static ColorScheme defaultScheme
  {
    get
    {
      if (Client._defscheme == null)
        Client._defscheme = ColorScheme.From(ClientResources.Instance._texturePalette);
      return Client._defscheme;
    }
  }

  public static bool renderEmoji
  {
    get
    {
      return Global.GetPrefBool("toggleOverheadRender", true);
    }
    set
    {
      Global.SetPrefBool("toggleOverheadRender", value);
    }
  }

  public static bool renderEmojiSpectator
  {
    get
    {
      return Global.GetPrefBool("toggleOverheadSpectator", true);
    }
    set
    {
      Global.SetPrefBool("toggleOverheadSpectator", value);
    }
  }

  public static bool emojiSound
  {
    get
    {
      return Global.GetPrefBool("toggleOverheadSound", true);
    }
    set
    {
      Global.SetPrefBool("toggleOverheadSound", value);
    }
  }

  public static ZMyWorld world
  {
    get
    {
      return Client.game.world;
    }
  }

  public static ZMap map
  {
    get
    {
      return Client.game?.map;
    }
  }

  public static Transform GetMapTransform()
  {
    return Client.game.GetMapTransform();
  }

  public static Cosmetics cosmetics
  {
    get
    {
      return Client._cosmetics;
    }
    set
    {
      Client._cosmetics = value;
      Client.MyAccount.cosmetics = Client._cosmetics;
    }
  }

  public static float bonusPrestige
  {
    get
    {
      return Client.MyAccount.bonusExperience;
    }
    set
    {
      Client.MyAccount.bonusExperience = value;
    }
  }

  public static string DownloadsFolder
  {
    get
    {
      foreach (string downloadFolder in Client.DownloadFolders)
      {
        if (Directory.Exists(downloadFolder))
          return downloadFolder;
      }
      return "";
    }
  }

  public static Account MyAccount { get; set; } = new Account();

  public static void RefreshIgnore()
  {
    UnratedMenu.instance?.RefreshIgnore(false);
    LobbyMenu.instance?.RefreshIgnore(false);
    RatedMenu.instance?.RefreshIgnore(false);
  }

  public static void RefreshNames()
  {
    UnratedMenu.instance?.RefreshNames(true, false);
    LobbyMenu.instance?.RefreshNames(false);
  }

  public static bool HasAccount(string n)
  {
    return !string.IsNullOrEmpty(n) && Client._accounts.ContainsKey(n);
  }

  public static Account GetAccount(string n, bool addIfNot = false)
  {
    Account account1 = (Account) null;
    if (!string.IsNullOrEmpty(n) && Client._accounts.TryGetValue(n, out account1))
      return account1;
    Account account2 = new Account(n);
    if (addIfNot)
    {
      Client._accounts[n] = account2;
      return account2;
    }
    account2.fake = true;
    return account2;
  }

  public static bool steamVerified
  {
    get
    {
      return Client.MyAccount.steamVerified;
    }
    set
    {
      Client.MyAccount.steamVerified = value;
    }
  }

  public static bool HasFriend(string name)
  {
    return Client.friends.Contains(name);
  }

  public static bool IsIgnored(string name)
  {
    return Client.ignore.Contains(name) || Client.tempIgnored.Ignored(name);
  }

  public static void SendToServer(byte b)
  {
    if (Client.connection == null || Client.Host)
      return;
    Client.SendToServer(new byte[1]{ b });
  }

  public static void SendToServer(byte[] b)
  {
    if (Client.connection == null)
      return;
    Client.connection.SendBytes(b, SendOption.None);
  }

  public static void SendToGameServer(byte[] b)
  {
    if (Client.connection != null && !Client.game.isServer)
      Client.connection.SendBytes(b, SendOption.None);
    if (!((UnityEngine.Object) Player.Instance != (UnityEngine.Object) null) || b[0] == (byte) 153 || !Client.game.isServer && b[0] == (byte) 220)
      return;
    Client.game.GameHandler(Player.Instance.person, b, false, true);
    if (Client.game.MoveQue.Count <= 0 || Client.game.ongoing.NumberOfSlowUpdateCoroutines != 0)
      return;
    Client.game.MoveQue.DequeueAndInvoke();
  }

  public static string GetTime()
  {
    return DateTime.Now.ToString("M/d h:mm tt");
  }

  public static void OnApplicationQuit()
  {
    if (Client.connection == null)
      return;
    Client.connection.Disconnected -= new EventHandler<DisconnectedEventArgs>(Client.Disconnected);
    Client.connection.Dispose();
    Client.connection = (Connection) null;
  }

  public static bool isConnected
  {
    get
    {
      return Client.connection != null && Client.connection.State == ConnectionState.Connected;
    }
  }

  public static void RemoveAllDataReceived()
  {
    Client.connection.DataReceived -= new EventHandler<DataReceivedEventArgs>(Client.AuthHandler);
    Client.connection.DataReceived -= new EventHandler<DataReceivedEventArgs>(Client.MainMenuHandler);
    Client.connection.DataReceived -= new EventHandler<DataReceivedEventArgs>(Client.LobbyHandler);
    Client.connection.DataReceived -= new EventHandler<DataReceivedEventArgs>(ZGame.GameClientHandler);
  }

  public static void Disconnect(bool openLogin)
  {
    if (Client.connection != null)
    {
      Client.connection.Disconnected -= new EventHandler<DisconnectedEventArgs>(Client.Disconnected);
      Client.RemoveAllDataReceived();
      try
      {
        Client.connection.Dispose();
      }
      catch (Exception ex)
      {
        Debug.Log((object) ex);
      }
      Client.connection = (Connection) null;
    }
    if (!openLogin)
      return;
    Controller.Instance.OpenMenu(Controller.Instance.MenuLogin, false);
  }

  private static void Init()
  {
    Dispatcher dispatcher = UnityThreadHelper.Dispatcher;
    Global.persistentDataPath = Application.persistentDataPath;
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
      {
        myBinaryWriter.Write((byte) 1);
        myBinaryWriter.Write(Inert.Version);
      }
      Inert.Version_As_Bytes = memoryStream.ToArray();
    }
    PersistantGameObject.Get();
  }

  public static void ConnectToServer()
  {
    Client.currentIP = PlayerPrefs.GetString("prefserver", Client.serverIP);
    if (string.IsNullOrWhiteSpace(Client.currentIP))
      Client.currentIP = Client.serverIP;
    Client.ReConnectToServer(Client.JoinLocation.Mainmenu);
  }

  public static void ConnectToLocalServer()
  {
    Client.currentIP = PlayerPrefs.GetString("localispserver", "127.0.0.1");
    Client.ReConnectToServer(Client.JoinLocation.Mainmenu);
  }

  public static void InitializeConnection()
  {
  }

  public static void TryConnect()
  {
  }

  public static void ReConnectToServer(Client.JoinLocation lobby = Client.JoinLocation.Mainmenu)
  {
    Client._accounts.Clear();
    Client.joinLobby = lobby;
    Client.Init();
    Client.Disconnect(false);
    if (Global.GetPrefBool("data1", false) && !string.Equals("unbanrequest", Client.Name))
    {
      LocalServerConn.UseEncryption = false;
      Client.currentIP = PlayerPrefs.GetString("localispserver", "127.0.0.1");
      if (string.Equals(Client.currentIP, Client.serverIP))
        Client.currentIP = "127.0.0.1";
    }
    if (string.IsNullOrEmpty(Client.currentIP))
      return;
    Client.connection = (Connection) new TcpConnection(new NetworkEndPoint(Client.currentIP, Client.port, IPMode.IPv4));
    Client.connection.DataReceived += new EventHandler<DataReceivedEventArgs>(Client.AuthHandler);
    Client.connection.Disconnected += new EventHandler<DisconnectedEventArgs>(Client.Disconnected);
    Controller.Instance?.RefreshKeepAliveTimer();
    try
    {
      Client.connection.Connect((byte[]) null, 5000);
      FpsToText.Instance?.StartPing();
    }
    catch (Exception ex)
    {
      Debug.Log((object) ex);
      if ((UnityEngine.Object) HUD.instance != (UnityEngine.Object) null)
      {
        HUD.instance.txtAttemptReconnect.gameObject.SetActive(false);
        HUD.instance.panelReconnect.SetActive(true);
      }
      else
      {
        if (!string.Equals(Client.currentIP, Client.serverIP))
          PlayerPrefs.SetString("localispserver", "127.0.0.1");
        if ((UnityEngine.Object) LocalServerConn.Instance == (UnityEngine.Object) null)
          Controller.Instance.OpenMenu(Controller.Instance.MenuLogin, false);
        if (!((UnityEngine.Object) LocalServerConn.Instance != (UnityEngine.Object) null))
          return;
        LocalServerConn.Instance.Error("Connection Could not be Established");
      }
    }
  }

  public static Uri IpToHttp(string ip, int port)
  {
    Debug.Log((object) ("URL: " + Application.absoluteURL));
    return Application.absoluteURL.Contains("https") ? new Uri(string.Format("wss://server.arcanists.com:{0}", (object) port)) : new Uri(string.Format("ws://{0}:{1}", (object) ip, (object) Client.webPortInsecure));
  }

  public static void Disconnected(object sender, DisconnectedEventArgs args)
  {
    Client.Disconnect(false);
    UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
    {
      if ((UnityEngine.Object) HUD.instance == (UnityEngine.Object) null || Client.game == null)
        Controller.Instance.OpenMenu(Controller.Instance.MenuLogin, false);
      else if (Client.game.serverState.busy != ServerState.Busy.Ended)
      {
        HUD.instance.txtAttemptReconnect.gameObject.SetActive(false);
        HUD.instance.panelReconnect.SetActive(true);
      }
      else if ((UnityEngine.Object) Player.Instance != (UnityEngine.Object) null && Player.Instance.person.offeringRematch)
        Client.game.QuitToMainMenu(true, Client.JoinLocation.Game, false);
      else
        Client.game.QuitToMainMenu(true, Client.JoinLocation.Lobby, false);
    }));
  }

  public static byte[] FirstEncrypt(byte[] b)
  {
    if (!LocalServerConn.UseEncryption)
      return b;
    using (RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider(2048))
    {
      cryptoServiceProvider.FromXmlString("<RSAKeyValue><Modulus>mJbQP4q78dSvBUsCKXJXMnPQVVBtwEoC6IZH/n+jVWwT4P/AUw3pIGY69LzcLSjVErJmx2cTFHOk61mlqyQp0+51fUOkHL7Z9Xz7A486O9Sb85AtcUBfpyRuTdS9mgOVuXUeLzxwzuxiTqRRhLv7zOWPBze5nZG97luHkIWQ3AkjIdlurCIqeS2KHlwtdPgqzrAev/Qt38z/dug1bYJkxq3zVUBJR67JHR/WjBP6g8ZvU8dNTNNROU/gaaACnBOgx4IQOtJTAF4x9AWt3TG13opXlo/Pr5HD2FtWIcmPYf+cKLqtGd6tbN+GZvTgDsEic2w+HH9c5bRTHlBVcCvr3w==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
      return cryptoServiceProvider.Encrypt(b, true);
    }
  }

  public static void SetupEncryption(myBinaryWriter w)
  {
    if (!LocalServerConn.UseEncryption)
    {
      w.Write(false);
    }
    else
    {
      w.Write(true);
      Client.connection.myAes = new AesManaged();
      Client.connection.myAes.GenerateKey();
      w.Write(Client.connection.myAes.Key);
    }
  }

  internal static bool GlobalHandler(byte tag, myBinaryReader r)
  {
    switch (tag)
    {
      case 42:
        Account a = new Account();
        a.Deserialize(r, false);
        Account account1 = Client.GetAccount(a.name, false);
        a.pfabName = account1.pfabName;
        Client._accounts[a.name] = a;
        if (string.Equals(a.name, Client.Name))
          Client.MyAccount.CopyClient(a);
        UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
        {
          if ((UnityEngine.Object) PrestigeLobbyUI.Instance != (UnityEngine.Object) null && string.Equals(a.name, Client.Name))
            PrestigeLobbyUI.Instance.Refresh(false);
          if ((UnityEngine.Object) LobbyMenu.instance != (UnityEngine.Object) null)
            LobbyMenu.instance.RefreshActive();
          else if ((UnityEngine.Object) UnratedMenu.instance != (UnityEngine.Object) null)
          {
            UnratedMenu.instance.RefreshActive();
            if (!UnratedMenu.IsViewingInvitePanel)
              return;
            UnratedMenu.instance.OpenInvitePlayers();
          }
          else
          {
            if (!((UnityEngine.Object) RatedMenu.instance != (UnityEngine.Object) null))
              return;
            RatedMenu.instance.RefreshActive();
          }
        }));
        return true;
      case 49:
        string msg1 = r.ReadString();
        string s = r.ReadString();
        ulong num1 = 0;
        ref ulong local = ref num1;
        ulong.TryParse(s, out local);
        Client.discordID = num1;
        UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
        {
          MainMenu.Instance?.buttonVerifyDiscord?.gameObject.SetActive(false);
          ChatBox.Instance?.discordButton?.SetActive(false);
          Controller.CreateNotification("Account Successfully Linked " + msg1);
        }));
        return true;
      case 51:
        Client.HandleAchievment((Achievement) r.ReadByte());
        return true;
      case 54:
        UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
        {
          MainMenu.Instance?.buttonVerifyDiscord?.gameObject.SetActive(false);
          Controller.CreateErrorNotification("Could not verify. Contact a mod on discord with your ingame name for assistance.");
        }));
        return true;
      case 55:
        Client.ReceivedReports(r);
        return true;
      case 63:
        string msg2 = r.ReadString();
        UnityThreadHelper.Dispatcher.Dispatch2((Action) (() => Controller.CreateNotification(msg2)));
        return true;
      case 68:
        switch (r.ReadByte())
        {
          case 1:
            RatingsMenu.selfRank = AllRankingsContainer.DeserializeSelf(r);
            return true;
          case 3:
            return true;
          case 5:
            RatingsMenu.nameRank = AllRankingsContainer.DeserializeSelf(r);
            return true;
          default:
            RatingsMenu.cached = AllRankingsContainer.Deserialize(r);
            int num2 = 1;
            foreach (JsonGamesLow jsonGamesLow in RatingsMenu.cached.low)
            {
              jsonGamesLow.rank = num2;
              ++num2;
            }
            int num3 = 1;
            foreach (JsonGamesHigh jsonGamesHigh in RatingsMenu.cached.high)
            {
              jsonGamesHigh.rank = num3;
              ++num3;
            }
            int num4 = 1;
            foreach (JsonGamesParty jsonGamesParty in RatingsMenu.cached.party)
            {
              jsonGamesParty.rank = num4;
              ++num4;
            }
            UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
            {
              if (!((UnityEngine.Object) RatingsMenu.Instance != (UnityEngine.Object) null))
                return;
              RatingsMenu.Instance.ClickDefault();
            }));
            return true;
        }
      case 72:
        string msg3 = r.ReadString();
        UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
        {
          PlayerPrefs.SetString("prefName", msg3);
          if ((UnityEngine.Object) LocalServerConn.Instance != (UnityEngine.Object) null)
            LocalServerConn.Instance.input_name.text = msg3;
          Controller.CreateNotification("This accounts name was changed to: " + msg3);
        }));
        return true;
      case 84:
        switch (r.ReadByte())
        {
          case 1:
            Client.clan = Clan.Deserialize(r);
            Client.UpdateClanUI();
            return true;
          case 2:
            string str1 = r.ReadString();
            byte num5 = r.ReadByte();
            Client.clan?.members.Add(str1, (Clan.Roles) num5);
            ChatBox.Instance?.NewChatMsg("", "Welcome <#6633ff>" + str1 + "</color> to the clan!", (Color) ColorScheme.GetColor(Global.ColorClanText), str1, ChatOrigination.Clan, ContentType.STRING, (object) null);
            Client.UpdateClanUI();
            return true;
          case 3:
            string str2 = r.ReadString();
            Client.clan?.members.Remove(str2);
            if (string.Equals(str2, Client.Name))
            {
              Client.clan = (Clan) null;
              ChatBox.Instance?.NewChatMsg("", "You have left the clan.", (Color) ColorScheme.GetColor(Global.ColorClanText), str2, ChatOrigination.Clan, ContentType.STRING, (object) null);
            }
            else
              ChatBox.Instance?.NewChatMsg("", "Player: <#6633ff>" + str2 + "</color> left the clan.", (Color) ColorScheme.GetColor(Global.ColorClanText), str2, ChatOrigination.Clan, ContentType.STRING, (object) null);
            Client.UpdateClanUI();
            return true;
          case 4:
            string RightClickName = r.ReadString();
            byte num6 = r.ReadByte();
            Client.clan.members[RightClickName] = (Clan.Roles) num6;
            ChatBox.Instance?.NewChatMsg("", "Player: <#6633ff>" + RightClickName + "</color> clan role changed to " + Client.clan.members[RightClickName].ToString(), (Color) ColorScheme.GetColor(Global.ColorClanText), RightClickName, ChatOrigination.Clan, ContentType.STRING, (object) null);
            Client.UpdateClanUI();
            return true;
          case 5:
            ClientResources.Instance.RecieveAllClanOutfits(r);
            return true;
          case 6:
            ClientResources.Instance.SetClanOutfit(r.ReadString(), ClanOutfit.Deserialize(r));
            return true;
          case 7:
            object content = Content.GetContent(r, ContentType.ClanInvite);
            ClanInvite clanInvite = (ClanInvite) content;
            if (ChatBox.Instance.butFriends.currentSetting == ChatSetting.Friends)
            {
              if (!Client.HasFriend(clanInvite.from))
                return true;
            }
            else if (ChatBox.Instance.butFriends.currentSetting == ChatSetting.Off || Client.IsIgnored(clanInvite.from))
              return true;
            ChatBox.Instance.NotificationInfiteToClan(clanInvite.from, clanInvite.clan, content);
            return true;
          case 8:
            ClanMenu.clans.Clear();
            int num7 = r.ReadInt32();
            for (int index = 0; index < num7; ++index)
              ClanMenu.clans.Add(Clan.FromBasic(r));
            ClanMenu.Instance?.Populate();
            return true;
          case 10:
            string str3 = r.ReadString();
            string str4 = r.ReadString();
            Client.clan?.members.Remove(str3);
            if (string.Equals(str3, Client.Name))
            {
              Client.clan = (Clan) null;
              ChatBox.Instance?.NewChatMsg("", "You have been kicked from the clan.", (Color) ColorScheme.GetColor(Global.ColorClanText), str3, ChatOrigination.Clan, ContentType.STRING, (object) null);
            }
            else
              ChatBox.Instance?.NewChatMsg("", "Player: <#6633ff>" + str3 + "</color> was " + str4, (Color) ColorScheme.GetColor(Global.ColorClanText), str3, ChatOrigination.Clan, ContentType.STRING, (object) null);
            Client.UpdateClanUI();
            return true;
          case 11:
            string key = r.ReadString();
            string index1 = r.ReadString();
            Clan.Roles roles = (Clan.Roles) r.ReadByte();
            if (Client.clan != null)
            {
              Client.clan.members.Remove(key);
              Client.clan.members[index1] = roles;
              Client.UpdateClanUI();
            }
            return true;
          default:
            return true;
        }
      case 85:
        string n1 = r.ReadString();
        Client.GetAccount(n1, true).location = r.ReadBoolean() ? Location.Ingame : Location.Disconnecting;
        Client.UpdateOnlineUI(n1);
        return true;
      case 87:
        Client.miniGame?.ClientHandler(r);
        return true;
      case 88:
        switch (r.ReadByte())
        {
          case 1:
            ChessBoard b1 = ChessBoard.Deserialize(r);
            if (Client.miniGame != null)
              Client.miniGame.Dispose();
            Client.miniGame = (IMiniGame) b1;
            ChessUI.Create(b1);
            if (b1.status == 1)
            {
              b1.Start(false);
              if (b1.isClient && b1.previousMoves.Count > 0)
              {
                b1.ui?.poolMoved.SpawnBehind((Vector3) b1.ui.GetAnchoredPosition(b1.FromIndex(b1.previousMoves[b1.previousMoves.Count - 1].from)), Color.red);
                b1.ui?.poolMoved.SpawnBehind((Vector3) b1.ui.GetAnchoredPosition(b1.FromIndex((int) b1.previousMoves[b1.previousMoves.Count - 1].to)), Color.red);
              }
              StringBuilder stringBuilder = new StringBuilder();
              bool flag = true;
              foreach (string str5 in b1.notation)
              {
                stringBuilder.Append(flag ? "<color=white>" + str5 + "</color>\n" : str5 + "\n");
                flag = !flag;
              }
              b1.ui.txtNotation.text = stringBuilder.ToString();
              break;
            }
            break;
          case 2:
            CheckersBoard b2 = CheckersBoard.Deserialize(r);
            if (Client.miniGame != null)
              Client.miniGame.Dispose();
            Client.miniGame = (IMiniGame) b2;
            CheckersUI.Create(b2);
            if (b2.status == 1)
            {
              b2.Start(false);
              if (b2.isClient && b2.previousMoves.Count > 0)
              {
                b2.ui?.poolMoved.SpawnBehind((Vector3) b2.ui.GetAnchoredPosition(b2.FromIndex(b2.previousMoves[b2.previousMoves.Count - 1].from)), Color.red);
                CheckersUI ui = b2.ui;
                if (ui != null)
                {
                  ui.poolMoved.SpawnBehind((Vector3) b2.ui.GetAnchoredPosition(b2.FromIndex((int) b2.previousMoves[b2.previousMoves.Count - 1].to)), Color.red);
                  break;
                }
                break;
              }
              break;
            }
            break;
          case 3:
            Join31Board b3 = Join31Board.Deserialize(r);
            if (Client.miniGame != null)
              Client.miniGame.Dispose();
            Client.miniGame = (IMiniGame) b3;
            Join31UI.Create(b3);
            if (b3.status == 1)
            {
              b3.Start(false);
              break;
            }
            break;
          case 4:
            RPSTBGBoard b4 = RPSTBGBoard.Deserialize(r);
            if (Client.miniGame != null)
              Client.miniGame.Dispose();
            Client.miniGame = (IMiniGame) b4;
            RPSTBGUI.Create(b4);
            if (b4.status == 1)
            {
              b4.Start(false);
              if (b4.isClient && b4.previousMoves.Count > 0)
              {
                b4.ui?.poolMoved.SpawnBehind((Vector3) b4.ui.GetAnchoredPosition(b4.FromIndex(b4.previousMoves[b4.previousMoves.Count - 1].from)), Color.red);
                RPSTBGUI ui = b4.ui;
                if (ui != null)
                {
                  ui.poolMoved.SpawnBehind((Vector3) b4.ui.GetAnchoredPosition(b4.FromIndex((int) b4.previousMoves[b4.previousMoves.Count - 1].to)), Color.red);
                  break;
                }
                break;
              }
              break;
            }
            break;
        }
        return true;
      case 89:
        Client.miniGame?.Dispose();
        Client.miniGame = (IMiniGame) null;
        return true;
      case 90:
        switch (r.ReadByte())
        {
          case 1:
            MyPollUI.Create(MyPoll.FromBytes<MyPoll>(r.ReadBytes()), false);
            break;
          case 3:
            Client.pollName = r.ReadString();
            Client.pollID = r.ReadInt32();
            LobbyMenu instance = LobbyMenu.instance;
            if (instance != null)
            {
              instance.TogglePoll();
              break;
            }
            break;
          case 4:
            MyPollResults.Create(MyPoll.FromBytesWithResponses<MyPoll>(r.ReadBytes()));
            break;
        }
        return true;
      case 94:
        if (r.ReadByte() == (byte) 1)
        {
          int id = r.ReadInt32();
          MyMessageBox.Create("Your game is ongoing. Would you like to rejoin it? You can rejoin from the lobby if you change your mind.", (Action) (() => Client.Ask((byte) 93, id)), "Ok", "Cancel", (Action) null, (Action) null, (Sprite) null, (string) null, (Action) null);
        }
        return true;
      case 95:
        ClientResources.DeserializeRestrictions(r);
        SpellLobbyChange.Instance?.Refresh(true);
        return true;
      case 96:
        Prestige.ClientHandler(r);
        return true;
      case 97:
        if (r.ReadByte() == (byte) 1)
        {
          Account.DeserializeList(Client.ignore, r);
          Client.RefreshIgnore();
        }
        return true;
      case 99:
        SpellOverrides.HandleMsg(r, true);
        return true;
      case 109:
        int gameType = r.ReadInt32();
        Server.compressedGameFacts = r.ReadBytes();
        using (MemoryStream memoryStream = new MemoryStream(Server.compressedGameFacts))
        {
          using (myBinaryReader r1 = new myBinaryReader((Stream) memoryStream))
            Server.DeserializePreGameFacts(r1);
        }
        if ((UnityEngine.Object) RatedTab.instance != (UnityEngine.Object) null)
          RatedTab.instance.RefreshGameOptions();
        if ((UnityEngine.Object) ChatBox.Instance != (UnityEngine.Object) null)
        {
          if (Server._preGameFacts[gameType] == null)
            ChatBox.Instance.NewChatMsg(RatedFacts.GetGameTypeAsString(gameType) + " Preset Setting has been removed.", Global.ColorSystem);
          else
            ChatBox.Instance.NewChatMsg(RatedFacts.GetGameTypeAsString(gameType) + " Preset Setting Changed - " + Server._preGameFacts[gameType].settings.description, Global.ColorSystem);
        }
        return true;
      case 112:
        string n2 = r.ReadString();
        long num8 = r.ReadInt64();
        Account account2 = Client.GetAccount(n2, false);
        account2.afkTimer = num8;
        if ((UnityEngine.Object) account2.pfabName != (UnityEngine.Object) null)
          account2.pfabName.RefreshActivity();
        return true;
      default:
        return false;
    }
  }

  internal static void UpdateOnlineUI(string n)
  {
    UnratedMenu.instance?.UpdateOnlineUI(n);
    LobbyMenu.instance?.UpdateOnlineUI(n);
    RatedMenu.instance?.UpdateOnlineUI(n);
  }

  internal static void UpdateClanUI()
  {
    if ((UnityEngine.Object) UnratedMenu.instance != (UnityEngine.Object) null && UnratedMenu.instance.viewing == Viewing.Clan)
      UnratedMenu.instance.ViewClan();
    else if ((UnityEngine.Object) LobbyMenu.instance != (UnityEngine.Object) null && LobbyMenu.instance.viewing == Viewing.Clan)
    {
      LobbyMenu.instance.ViewClan();
    }
    else
    {
      if (!((UnityEngine.Object) RatedMenu.instance != (UnityEngine.Object) null) || RatedMenu.instance.viewing != Viewing.Clan)
        return;
      RatedMenu.instance.ViewClan();
    }
  }

  private static void AuthHandler(object sender, DataReceivedEventArgs args)
  {
    if (args.Bytes.Length == 1 && args.Bytes[0] == (byte) 34)
    {
      args.Recycle();
    }
    else
    {
      using (MemoryStream memoryStream1 = new MemoryStream(args.Bytes))
      {
        using (myBinaryReader r1 = new myBinaryReader((Stream) memoryStream1))
        {
          try
          {
            byte tag = r1.ReadByte();
            switch (tag)
            {
              case 1:
                string version = r1.ReadString();
                if (version != Inert.Version)
                {
                  UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
                  {
                    Client.Disconnect(false);
                    if ((UnityEngine.Object) LocalServerConn.Instance != (UnityEngine.Object) null)
                      LocalServerConn.Instance.Error("Your Version (" + Inert.Version + ") does not match the Server's (" + version + ")");
                    else
                      Controller.Instance.OpenMenu(Controller.Instance.MenuLogin, false);
                  }));
                  break;
                }
                if (LocalServerConn.PasswordChange)
                {
                  LocalServerConn.PasswordChange = false;
                  byte[] buffer = r1.ReadBytes();
                  byte[] numArray = new byte[10];
                  using (RNGCryptoServiceProvider cryptoServiceProvider = new RNGCryptoServiceProvider())
                    cryptoServiceProvider.GetBytes(numArray);
                  string str = "";
                  using (MemoryStream memoryStream2 = new MemoryStream())
                  {
                    using (myBinaryWriter w = new myBinaryWriter((Stream) memoryStream2))
                    {
                      w.Write((byte) 48);
                      w.Write(numArray);
                      w.Write(Controller.OperatingSystem);
                      w.Write(Controller.HWID);
                      w.Write(Client.Name);
                      if ((UnityEngine.Object) LocalServerConn.Instance != (UnityEngine.Object) null)
                      {
                        Client.bytePass = Encoding.UTF8.GetBytes(!LocalServerConn.UseEncryption ? "" : LocalServerConn.Instance.input_pass.text);
                        str = LocalServerConn.Instance.inputPasswordPasswordChange.text;
                      }
                      w.Write(Encoding.UTF8.GetString(Client.bytePass));
                      w.Write(str);
                      w.Write(buffer);
                      Client.SetupEncryption(w);
                    }
                    Client.connection.SendBytesUnencrypted(Client.FirstEncrypt(memoryStream2.ToArray()));
                    Client.connection.SetupEncryption();
                    break;
                  }
                }
                else if (LocalServerConn.CreatingAccount)
                {
                  LocalServerConn.CreatingAccount = false;
                  if ((double) Client.accountSticker > (double) Controller.realtimeSinceStartup)
                  {
                    if (!((UnityEngine.Object) LocalServerConn.Instance != (UnityEngine.Object) null))
                      return;
                    LocalServerConn.Instance.Error("You've made enough alt accounts...use one of those.");
                    return;
                  }
                  byte[] buffer = r1.ReadBytes();
                  byte[] numArray = new byte[10];
                  using (RNGCryptoServiceProvider cryptoServiceProvider = new RNGCryptoServiceProvider())
                    cryptoServiceProvider.GetBytes(numArray);
                  using (MemoryStream memoryStream2 = new MemoryStream())
                  {
                    using (myBinaryWriter w = new myBinaryWriter((Stream) memoryStream2))
                    {
                      w.Write((byte) 46);
                      w.Write(numArray);
                      w.Write(Controller.OperatingSystem);
                      w.Write(Controller.HWID);
                      w.Write(Client.Name);
                      if ((UnityEngine.Object) LocalServerConn.Instance != (UnityEngine.Object) null)
                        Client.bytePass = Encoding.UTF8.GetBytes(!LocalServerConn.UseEncryption ? "" : LocalServerConn.Instance.input_pass.text);
                      w.Write(Encoding.UTF8.GetString(Client.bytePass));
                      w.Write(buffer);
                      Client.SetupEncryption(w);
                    }
                    Client.connection.SendBytesUnencrypted(Client.FirstEncrypt(memoryStream2.ToArray()));
                    Client.connection.SetupEncryption();
                    break;
                  }
                }
                else
                {
                  Client.randomBytes = r1.ReadBytes();
                  byte[] numArray = new byte[10];
                  using (RNGCryptoServiceProvider cryptoServiceProvider = new RNGCryptoServiceProvider())
                    cryptoServiceProvider.GetBytes(numArray);
                  switch (LocalServerConn.authenticationMethod)
                  {
                    case AuthenticationMethod.Arcanists:
                      using (MemoryStream memoryStream2 = new MemoryStream())
                      {
                        using (myBinaryWriter w = new myBinaryWriter((Stream) memoryStream2))
                        {
                          w.Write((byte) 1);
                          w.Write(numArray);
                          w.Write(Controller.OperatingSystem);
                          w.Write(Controller.HWID);
                          w.Write(Client.Name);
                          if ((UnityEngine.Object) LocalServerConn.Instance != (UnityEngine.Object) null)
                            Client.bytePass = Encoding.UTF8.GetBytes(!LocalServerConn.UseEncryption ? "" : LocalServerConn.Instance.input_pass.text);
                          w.Write(Encoding.UTF8.GetString(Client.bytePass));
                          w.Write(Client.randomBytes);
                          Client.SetupEncryption(w);
                        }
                        Client.connection.SendBytesUnencrypted(Client.FirstEncrypt(memoryStream2.ToArray()));
                        Client.connection.SetupEncryption();
                        break;
                      }
                    case AuthenticationMethod.Steam:
                      using (MemoryStream memoryStream2 = new MemoryStream())
                      {
                        using (myBinaryWriter w = new myBinaryWriter((Stream) memoryStream2))
                        {
                          w.Write((byte) 107);
                          w.Write((byte) 1);
                          w.Write(numArray);
                          w.Write(Controller.OperatingSystem);
                          w.Write(Controller.HWID);
                          Client.SetupEncryption(w);
                        }
                        Client.connection.SendBytesUnencrypted(Client.FirstEncrypt(memoryStream2.ToArray()));
                        Client.connection.SetupEncryption();
                        break;
                      }
                  }
                }
                break;
              case 3:
                UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
                {
                  if ((UnityEngine.Object) LocalServerConn.Instance == (UnityEngine.Object) null || !LocalServerConn.Instance.panelSteam.activeSelf)
                    Client.Disconnect(false);
                  if ((UnityEngine.Object) LocalServerConn.Instance == (UnityEngine.Object) null)
                    Controller.Instance.OpenMenu(Controller.Instance.MenuLogin, false);
                  if (!((UnityEngine.Object) LocalServerConn.Instance != (UnityEngine.Object) null))
                    return;
                  LocalServerConn.Instance.Error(Client.Name + " already Exists.");
                }));
                break;
              case 19:
                UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
                {
                  Client.Disconnect(false);
                  if ((UnityEngine.Object) LocalServerConn.Instance == (UnityEngine.Object) null)
                    Controller.Instance.OpenMenu(Controller.Instance.MenuLogin, false);
                  if (!((UnityEngine.Object) LocalServerConn.Instance != (UnityEngine.Object) null))
                    return;
                  LocalServerConn.Instance.Error(LocalServerConn.UseEncryption ? "Could not Connect" : "Name in use or could not connect");
                }));
                break;
              case 20:
                Client.RemoveAllDataReceived();
                Client.connection.DataReceived += new EventHandler<DataReceivedEventArgs>(Client.MainMenuHandler);
                Account other = new Account();
                other.Deserialize(r1, false);
                Client.cosmetics = Cosmetics.Deserialize(r1);
                Client.badges.Deserialize(r1);
                Client.bonusPrestige = r1.ReadSingle();
                Client.Name = other.name;
                Client.lobbyChat = (ChatSetting) r1.ReadByte();
                Client.gameChat = (ChatSetting) r1.ReadByte();
                Client.teamChat = (ChatSetting) r1.ReadByte();
                Client.minigameChat = (ChatSetting) r1.ReadByte();
                Client.friendChat = (ChatSetting) r1.ReadByte();
                Client.inviteChat = (ChatSetting) r1.ReadByte();
                Client.spectatorChat = (ChatSetting) r1.ReadByte();
                Client.clanChat = (ChatSetting) r1.ReadByte();
                Client.identifier = r1.ReadString();
                Client._accounts[other.name] = other;
                Client.MyAccount.CopyClient(other);
                Client.MyAccount.cosmetics = Client.cosmetics;
                Client.MyAccount.badges = Client.badges;
                Client.discordID = other.discord;
                Client.steamVerified = r1.ReadBoolean();
                Client.friends.Clear();
                Client.ignore.Clear();
                Client.MyAccount.wands = r1.ReadInt32();
                Client.MyAccount.totalWands = r1.ReadInt32();
                Client.MyAccount.tournamentCoins = r1.ReadInt32();
                Account.DeserializeList(Client.friends, r1);
                Account.DeserializeList(Client.ignore, r1);
                Server.compressedGameFacts = r1.ReadBytes();
                using (MemoryStream memoryStream2 = new MemoryStream(Server.compressedGameFacts))
                {
                  using (myBinaryReader r2 = new myBinaryReader((Stream) memoryStream2))
                    Server.DeserializePreGameFacts(r2);
                }
                if (r1.ReadByte() == (byte) 1)
                {
                  Clan clan = Clan.Deserialize(r1);
                  Client.clan = clan;
                  foreach (KeyValuePair<string, Clan.Roles> member in clan.members)
                  {
                    Account account = Client.GetAccount(member.Key, false);
                    account.clanRole = member.Value;
                    account.clan = clan.name;
                    Client._accounts[member.Key] = account;
                  }
                }
                Client.MyAccount.tutorials.Deserialize(r1);
                Client.MyAccount.dust = r1.ReadInt32();
                Client.MyAccount.tomatoes = r1.ReadInt32();
                Client.MyAccount.storeItems = BoughtStoreItems.Deserialize(r1);
                Client.MyAccount.activeItems.Deserialize(r1);
                switch (Client.joinLobby)
                {
                  case Client.JoinLocation.Lobby:
                    Client.joinLobby = Client.JoinLocation.Mainmenu;
                    Client.AskToJoinLobby();
                    break;
                  case Client.JoinLocation.Game:
                    Client.AskToJoinLobby();
                    break;
                  default:
                    UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
                    {
                      Controller.Instance.DestroyMap(false, true);
                      Controller.Instance.OpenMenu(Controller.Instance.MenuMain, false);
                    }));
                    break;
                }
                break;
              case 25:
                UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
                {
                  Client.Disconnect(false);
                  Client.accountSticker = Controller.realtimeSinceStartup + 60f;
                  if ((UnityEngine.Object) LocalServerConn.Instance == (UnityEngine.Object) null)
                    Controller.Instance.OpenMenu(Controller.Instance.MenuLogin, false);
                  if (!((UnityEngine.Object) LocalServerConn.Instance != (UnityEngine.Object) null))
                    return;
                  LocalServerConn.Instance.Error("You've made enough alt accounts...use one of those.");
                }));
                break;
              case 40:
                UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
                {
                  Client.Disconnect(false);
                  if ((UnityEngine.Object) LocalServerConn.Instance == (UnityEngine.Object) null)
                    Controller.Instance.OpenMenu(Controller.Instance.MenuLogin, false);
                  if (!((UnityEngine.Object) LocalServerConn.Instance != (UnityEngine.Object) null))
                    return;
                  LocalServerConn.Instance.Error("Could not process. Join the discord for help.");
                }));
                break;
              case 47:
                UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
                {
                  Client.Disconnect(false);
                  if ((UnityEngine.Object) LocalServerConn.Instance == (UnityEngine.Object) null)
                    Controller.Instance.OpenMenu(Controller.Instance.MenuLogin, false);
                  if (!((UnityEngine.Object) LocalServerConn.Instance != (UnityEngine.Object) null))
                    return;
                  LocalServerConn.Instance.Error("Invalid Name and/or Password");
                }));
                break;
              case 53:
                UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
                {
                  Client.Disconnect(false);
                  if ((UnityEngine.Object) LocalServerConn.Instance == (UnityEngine.Object) null)
                    Controller.Instance.OpenMenu(Controller.Instance.MenuLogin, false);
                  if (!((UnityEngine.Object) LocalServerConn.Instance != (UnityEngine.Object) null))
                    return;
                  LocalServerConn.Instance.Error("vpn / proxy / tor connections are not allowed, please disable and try again.");
                }));
                break;
              case 61:
              case 101:
                break;
              case 62:
                UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
                {
                  Global.SetPrefBool("data1", true);
                  string ipAddress = LocalServerConn.getIpAddress();
                  if (ipAddress.Length < 20)
                    PlayerPrefs.SetString("localispserver", ipAddress);
                  Client.Disconnect(false);
                  if ((UnityEngine.Object) LocalServerConn.Instance == (UnityEngine.Object) null)
                    Controller.Instance.OpenMenu(Controller.Instance.MenuLogin, false);
                  if (!((UnityEngine.Object) LocalServerConn.Instance != (UnityEngine.Object) null))
                    return;
                  LocalServerConn.Instance.Error("Could not Connect");
                }));
                break;
              case 63:
                string msg1 = r1.ReadString();
                UnityThreadHelper.Dispatcher.Dispatch2((Action) (() => Controller.CreateNotification(msg1)));
                break;
              case 65:
                string msg2 = r1.ReadString();
                UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
                {
                  Client.Disconnect(false);
                  if ((UnityEngine.Object) LocalServerConn.Instance == (UnityEngine.Object) null)
                    Controller.Instance.OpenMenu(Controller.Instance.MenuLogin, false);
                  if ((UnityEngine.Object) LocalServerConn.Instance != (UnityEngine.Object) null)
                    LocalServerConn.Instance.Error(msg2);
                  Global.SetPrefBool("data1", false);
                }));
                break;
              case 70:
                byte[] b = ZGame.CopyByteArray(args.Bytes);
                UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
                {
                  Controller.Instance.DestroyMap(true, true);
                  Client.game?.Reset(true);
                  using (MemoryStream memoryStream = new MemoryStream(b))
                  {
                    using (myBinaryReader myBinaryReader = new myBinaryReader((Stream) memoryStream))
                    {
                      int num1 = (int) myBinaryReader.ReadByte();
                      Account account1 = new Account();
                      account1.Deserialize(myBinaryReader, false);
                      Client.cosmetics = Cosmetics.Deserialize(myBinaryReader);
                      Client.bonusPrestige = myBinaryReader.ReadSingle();
                      Client.Name = account1.name;
                      int num2 = myBinaryReader.ReadInt32();
                      for (int index = 0; index < num2; ++index)
                      {
                        Account account2 = new Account();
                        account2.Deserialize(myBinaryReader, false);
                        Client._accounts[account2.name] = account2;
                      }
                      Client.HandleStartGame(myBinaryReader);
                      Client.MyAccount.CopyClient(Client._accounts[Client.Name]);
                      Client.MyAccount.cosmetics = Client.cosmetics;
                    }
                  }
                }));
                break;
              case 72:
                string msg3 = r1.ReadString();
                UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
                {
                  Client.Disconnect(false);
                  PlayerPrefs.SetString("prefName", msg3);
                  if ((UnityEngine.Object) LocalServerConn.Instance != (UnityEngine.Object) null)
                    LocalServerConn.Instance.input_name.text = msg3;
                  Controller.CreateNotification("This accounts name was changed to: " + msg3);
                }));
                break;
              case 102:
                UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
                {
                  Client.Disconnect(false);
                  if ((UnityEngine.Object) LocalServerConn.Instance == (UnityEngine.Object) null)
                    Controller.Instance.OpenMenu(Controller.Instance.MenuLogin, false);
                  if (!((UnityEngine.Object) LocalServerConn.Instance != (UnityEngine.Object) null))
                    return;
                  LocalServerConn.Instance.Error("Network Error - Could not Connect");
                }));
                break;
              case 107:
                switch (r1.ReadByte())
                {
                  case 1:
                    using (MemoryStream memoryStream2 = new MemoryStream())
                    {
                      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream2))
                      {
                        myBinaryWriter.Write((byte) 107);
                        myBinaryWriter.Write((byte) 2);
                        myBinaryWriter.Write(SteamManager.ByteArrayToString(SteamManager.Instance.ticket.Value.m_rgubTicket));
                      }
                      Client.connection.SendBytes(memoryStream2.ToArray(), SendOption.None);
                      break;
                    }
                  case 3:
                    if ((UnityEngine.Object) LocalServerConn.Instance != (UnityEngine.Object) null)
                    {
                      LocalServerConn.Instance.panelSteam.SetActive(true);
                      break;
                    }
                    break;
                }
                break;
              default:
                Client.GlobalHandler(tag, r1);
                break;
            }
          }
          catch (Exception ex)
          {
            Debug.LogError((object) ex.ToString());
          }
        }
      }
      args.Recycle();
    }
  }

  public static void LobbyHandler(object sender, DataReceivedEventArgs args)
  {
    if (args.Bytes.Length == 1 && args.Bytes[0] == (byte) 34)
      args.Recycle();
    else
      UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
      {
        Client.LobbyHandler(args.Bytes);
        args.Recycle();
      }));
  }

  private static void MainMenuHandler(object sender, DataReceivedEventArgs args)
  {
    if (args.Bytes.Length == 1 && args.Bytes[0] == (byte) 34)
      args.Recycle();
    else
      UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
      {
        using (MemoryStream memoryStream = new MemoryStream(args.Bytes))
        {
          using (myBinaryReader reader = new myBinaryReader((Stream) memoryStream))
          {
            try
            {
              if (reader.ReadByte() == (byte) 10)
              {
                RatingsMenu.cachedFriends = (List<RatingLineInfo>) null;
                RatingsMenu.cachedGlobal = (List<RatingLineInfo>) null;
                Client.SyncLobby(reader);
              }
              else
                Client.LobbyHandler(args.Bytes);
            }
            catch (Exception ex)
            {
              Debug.LogError((object) ex);
            }
          }
        }
        args.Recycle();
      }));
  }

  public static void SyncLobby(myBinaryReader reader)
  {
    RatedTab.FindingOpponents = false;
    Client._lobby.Clear();
    Client._games.Clear();
    Client._ratedSearches.Clear();
    Client._NEWratedSearches.Clear();
    int goToLobby = reader.ReadInt32();
    int num1 = reader.ReadInt32();
    for (int index = 0; index < num1; ++index)
    {
      Account account = new Account();
      account.Deserialize(reader, false);
      Client._accounts[account.name] = account;
    }
    Client.MyAccount.CopyClient(Client._accounts[Client.Name]);
    int num2 = reader.ReadInt32();
    for (int index = 0; index < num2; ++index)
    {
      string key = reader.ReadString();
      Client._lobby.Add(key, key);
    }
    int num3 = reader.ReadInt32();
    for (int index = 0; index < num3; ++index)
    {
      GameFacts gf = new GameFacts();
      gf.ManualDeserialize(reader, false, false, (byte) 0);
      Client._games.Add(gf.id, gf);
    }
    int num4 = reader.ReadInt32();
    for (int index = 0; index < num4; ++index)
    {
      int key = reader.ReadInt32();
      RatedContainer ratedContainer = RatedContainer.Deserialize(reader);
      Client._ratedSearches.Add(key, ratedContainer);
    }
    string serverJoinMsg = reader.ReadString();
    Client.pollName = reader.ReadString();
    Client.pollID = reader.ReadInt32();
    Client.MyAccount.poll = reader.ReadInt32();
    Client.RemoveAllDataReceived();
    Client.connection.DataReceived += new EventHandler<DataReceivedEventArgs>(Client.LobbyHandler);
    Client.connection.player.inBoat = false;
    UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
    {
      Controller.Instance.DestroyMap(false, true);
      if (goToLobby >= 0 && !Client._games.TryGetValue(goToLobby, out Client._gameFacts))
      {
        Client.AskToJoinLobby();
      }
      else
      {
        Controller.Instance.OpenMenu(goToLobby < 0 ? Controller.Instance.MenuLobby : Controller.Instance.MenuUnrated, true);
        if (Client.joinLobby == Client.JoinLocation.Game)
        {
          Client.AskTojoinGame(Client.joinGameId);
          Client.joinLobby = Client.JoinLocation.Mainmenu;
        }
        Client.AskToChangeOutfit(Client.settingsPlayer);
        Client.AskToChangeSpells(Client.settingsPlayer);
        if (!string.IsNullOrEmpty(serverJoinMsg))
          ChatBox.Instance?.NewChatMsg("", serverJoinMsg, (Color) ColorScheme.GetColor(Global.ColorAnnoucement), "[Annoucement]", ChatOrigination.System, ContentType.STRING, (object) null);
        Account account = Client.GetAccount(Client.Name, false);
        if (!account.accountType.IsMuted() || account.discord != 0UL || (Client.steamVerified || !string.IsNullOrEmpty(account.steamKey)) || !Client.firstChatOnly)
          return;
        Client.firstChatOnly = false;
        ChatBox.Instance?.NewChatMsg("", "Verify your account to talk... and join the discord! (Right-Click for options)", (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen), "[Discord]", ChatOrigination.System, ContentType.STRING, (object) null);
        ChatBox.Instance?.NewChatMsg("You can quickchat using the blue megaphone <sprite name=\"Emoji2_1352\"> on the right side of the chat box", (Color) ColorScheme.GetColor(MyContextMenu.ColorBlue));
      }
    }));
  }

  public static void HandleAchievment(Achievement a)
  {
    Client.achievements.Add(a);
    Client.cosmetics.achievements[(int) a] = true;
    if (!((UnityEngine.Object) UIAchievement.Instance == (UnityEngine.Object) null))
      return;
    UIAchievement.Create();
  }

  public static void LobbyHandler(byte[] b)
  {
    using (MemoryStream memoryStream = new MemoryStream(b))
    {
      using (myBinaryReader myBinaryReader = new myBinaryReader((Stream) memoryStream))
      {
        try
        {
          byte num1 = myBinaryReader.ReadByte();
          switch (num1)
          {
            case 5:
              Account a = new Account();
              a.Deserialize(myBinaryReader, false);
              Client._accounts[a.name] = a;
              if (string.Equals(a.name, Client.Name))
                Client.MyAccount.CopyClient(a);
              bool refresh = false;
              UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
              {
                if (Client._lobby.ContainsKey(a.name))
                {
                  refresh = true;
                  Client._lobby.Remove(a.name);
                }
                Client._lobby.Add(a.name, a.name);
                if ((UnityEngine.Object) LobbyMenu.instance != (UnityEngine.Object) null)
                {
                  if (refresh)
                    LobbyMenu.instance.RefreshNames(false);
                  else
                    LobbyMenu.instance.AddName(a);
                }
                else
                {
                  if (!UnratedMenu.IsViewingInvitePanel)
                    return;
                  UnratedMenu.instance.OpenInvitePlayers();
                }
              }));
              break;
            case 6:
              int id1 = myBinaryReader.ReadInt32();
              if (myBinaryReader.ReadBoolean())
              {
                RatedContainer ratedContainer = RatedContainer.Deserialize(myBinaryReader);
                Client._NEWratedSearches.Add(id1, ratedContainer);
                UnityThreadHelper.Dispatcher.Dispatch2((Action) (() => LobbyMenu.instance?.StartCoroutine(LobbyMenu.instance.DelayAddGame(id1))));
              }
              else
              {
                Client._ratedSearches.Remove(id1);
                Client._NEWratedSearches.Remove(id1);
              }
              if (!((UnityEngine.Object) LobbyMenu.instance != (UnityEngine.Object) null))
                break;
              LobbyMenu.instance.RefreshGames();
              break;
            case 8:
              string n1 = myBinaryReader.ReadString();
              int g1 = myBinaryReader.ReadInt32();
              UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
              {
                if (!Client._games.ContainsKey(g1))
                  return;
                if ((UnityEngine.Object) UnratedMenu.instance != (UnityEngine.Object) null && g1 == Client._gameFacts.id)
                {
                  if (string.Equals(n1, Client.Name, StringComparison.OrdinalIgnoreCase))
                  {
                    Client._gameFacts = new GameFacts();
                    Client._games.GetValue(g1).players.RemoveAll((Predicate<string>) (x => x == n1));
                    if (Client._games.GetValue(g1).players.Count == 0)
                      Client._games.Remove(g1);
                    if (Client._lobby.ContainsKey(n1))
                      Client._lobby.Remove(n1);
                    Client._lobby.Add(n1, n1);
                    Controller.Instance.OpenMenu(Controller.Instance.MenuLobby, true);
                  }
                  else
                  {
                    Client._games.GetValue(g1).players.RemoveAll((Predicate<string>) (x => x == n1));
                    UnratedMenu.instance.SetReadyStatesOff();
                    UnratedMenu.instance.RefreshNames(true, false);
                  }
                }
                else
                {
                  Client._games.GetValue(g1).players.RemoveAll((Predicate<string>) (x => x == n1));
                  if (Client._games.GetValue(g1).players.Count == 0)
                    Client._games.Remove(g1);
                  if ((UnityEngine.Object) LobbyMenu.instance != (UnityEngine.Object) null)
                    LobbyMenu.instance.RefreshGames();
                }
                if (!UnratedMenu.IsViewingInvitePanel)
                  return;
                UnratedMenu.instance.OpenInvitePlayers();
              }));
              break;
            case 10:
              Controller.Instance.DestroyMap(false, true);
              Client.SyncLobby(myBinaryReader);
              break;
            case 11:
              string name = myBinaryReader.ReadString();
              UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
              {
                if (!Client._lobby.ContainsKey(name))
                  return;
                Client._lobby.Remove(name);
                if (UnratedMenu.CheckInvites && Client._gameFacts.invitedPlayers.Contains(name))
                  Client.AskToInvite(name);
                if ((UnityEngine.Object) LobbyMenu.instance != (UnityEngine.Object) null)
                {
                  LobbyMenu.instance.RefreshNames(false);
                }
                else
                {
                  if (!UnratedMenu.IsViewingInvitePanel)
                    return;
                  UnratedMenu.instance.OpenInvitePlayers();
                }
              }));
              break;
            case 12:
              int key = myBinaryReader.ReadInt32();
              GameFacts g2 = (GameFacts) null;
              if (Client._games.TryGetValue(key, out g2))
              {
                g2.status = (byte) 1;
                g2.serverStartTime = (int) Controller.realtimeSinceStartup;
                UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
                {
                  if (!((UnityEngine.Object) LobbyMenu.instance != (UnityEngine.Object) null))
                    return;
                  LobbyMenu.instance.UpdateGame(g2);
                }));
                break;
              }
              Debug.Log((object) ("Game does not exist: " + key.ToString()));
              break;
            case 14:
              int id2 = myBinaryReader.ReadInt32();
              GameFacts g3 = (GameFacts) null;
              if (Client._games.TryGetValue(id2, out g3))
              {
                g3.settings.Deserialize(myBinaryReader, (byte) 5);
                UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
                {
                  if ((UnityEngine.Object) LobbyMenu.instance != (UnityEngine.Object) null)
                  {
                    LobbyMenu.instance.UpdateGame(g3);
                  }
                  else
                  {
                    if (id2 != Client._gameFacts.id || !((UnityEngine.Object) UnratedMenu.instance != (UnityEngine.Object) null))
                      return;
                    UnratedMenu.instance.SetReadyStatesOff();
                    UnratedMenu.instance.RefreshGameOptions();
                  }
                }));
                break;
              }
              Debug.Log((object) ("Game does not exist: " + id2.ToString()));
              break;
            case 17:
              Client._gameFacts.RecieveReadyState(myBinaryReader);
              break;
            case 20:
              Client.RemoveAllDataReceived();
              Client.connection.DataReceived += new EventHandler<DataReceivedEventArgs>(Client.MainMenuHandler);
              UnityThreadHelper.Dispatcher.Dispatch2((Action) (() => Controller.Instance.OpenMenu(Controller.Instance.MenuMain, false)));
              break;
            case 23:
              UnityThreadHelper.Dispatcher.Dispatch2((Action) (() => Controller.Instance.OpenMenu(Controller.Instance.MenuRated, true)));
              break;
            case 24:
              string n2 = myBinaryReader.ReadString();
              int num2 = myBinaryReader.ReadInt32();
              List<string> players = new List<string>();
              for (int index = 0; index < num2; ++index)
                players.Add(myBinaryReader.ReadString());
              int g4 = myBinaryReader.ReadInt32();
              UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
              {
                if (!Client._games.ContainsKey(g4))
                  return;
                if (string.Equals(n2, Client.Name, StringComparison.OrdinalIgnoreCase))
                {
                  Client._gameFacts = Client._games.GetValue(g4);
                  Client._gameFacts.players = players;
                  Controller.Instance.OpenMenu(Controller.Instance.MenuUnrated, true);
                }
                else if ((UnityEngine.Object) UnratedMenu.instance != (UnityEngine.Object) null && g4 == Client._gameFacts.id && Client._gameFacts.players.Count > 0)
                {
                  Client._gameFacts.players = players;
                  UnratedMenu.instance.SetReadyStatesOff();
                  UnratedMenu.instance.RefreshNames(true, false);
                }
                else
                {
                  Client._games.GetValue(g4).players = players;
                  if ((UnityEngine.Object) LobbyMenu.instance != (UnityEngine.Object) null)
                    LobbyMenu.instance.RefreshGames();
                }
                Client._games.GetValue(g4).invitedPlayers.Remove(n2);
                if (!UnratedMenu.IsViewingInvitePanel)
                  return;
                UnratedMenu.instance.OpenInvitePlayers();
              }));
              break;
            case 29:
              GameFacts gf = new GameFacts();
              gf.ManualDeserialize(myBinaryReader, false, false, (byte) 0);
              if (Client._games.ContainsKey(gf.id))
              {
                Debug.Log((object) ("Game already exists! " + gf.id.ToString()));
                Client._games.Remove(gf.id);
              }
              Client._games.Add(gf.id, gf);
              UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
              {
                if (gf.players.Count > 0 && string.Equals(Client.Name, gf.players[0], StringComparison.OrdinalIgnoreCase))
                {
                  Client._gameFacts = gf;
                  Controller.Instance.OpenMenu(Controller.Instance.MenuUnrated, true);
                }
                else if ((UnityEngine.Object) LobbyMenu.instance != (UnityEngine.Object) null)
                {
                  LobbyMenu.instance.AddGame(gf);
                }
                else
                {
                  if (!Spectator.isConnected)
                    return;
                  if (gf.GetRatedMode())
                  {
                    if (gf.status == (byte) 0)
                    {
                      if (!Global.GetPrefBool("prefshowcreatedgames", true))
                        return;
                      ChatBox.Instance?.Notification(gf.players[0] + " created a rated team lobby", gf.players[0], ChatOrigination.System);
                    }
                    else
                    {
                      if (!Global.GetPrefBool("prefshowstartedgames", true))
                        return;
                      ChatBox.Instance?.Notification("Rated Game Started: " + string.Join(", ", (IEnumerable<string>) gf.players), gf.players[0], ChatOrigination.System);
                    }
                  }
                  else
                  {
                    if (gf.status != (byte) 0 || gf.GetInviteMode() != InviteEnum.Open || !Global.GetPrefBool("prefshowcreatedgames", true))
                      return;
                    ChatBox.Instance?.Notification(gf.players[0] + " created an unrated lobby", gf.players[0], ChatOrigination.System);
                  }
                }
              }));
              break;
            case 30:
              int id3 = myBinaryReader.ReadInt32();
              byte num3 = myBinaryReader.ReadByte();
              GameFacts g5 = (GameFacts) null;
              if (Client._games.TryGetValue(id3, out g5))
              {
                g5.status = num3;
                if (num3 == (byte) 0)
                {
                  g5.players.Clear();
                  g5.connections.Clear();
                  g5.accounts.Clear();
                  g5.settingsPlayer.Clear();
                  g5.settings.Deserialize(myBinaryReader, (byte) 5);
                  int num4 = myBinaryReader.ReadInt32();
                  List<string> stringList = new List<string>();
                  for (int index = 0; index < num4; ++index)
                    g5.players.Add(myBinaryReader.ReadString());
                  if (g5.GetRatedMode() && !g5.GetTeamMode())
                    g5.SetRatedMode(false);
                }
                UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
                {
                  if ((UnityEngine.Object) LobbyMenu.instance != (UnityEngine.Object) null)
                  {
                    LobbyMenu.instance.UpdateGame(g5);
                  }
                  else
                  {
                    if (id3 != Client._gameFacts.id || !((UnityEngine.Object) UnratedMenu.instance != (UnityEngine.Object) null))
                      return;
                    UnratedMenu.instance.SetReadyStatesOff();
                    UnratedMenu.instance.RefreshGameOptions();
                  }
                }));
                break;
              }
              Debug.Log((object) ("Game does not exist: " + id3.ToString()));
              break;
            case 33:
              string msg1 = myBinaryReader.ReadString();
              UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
              {
                if (!((UnityEngine.Object) ChatBox.Instance != (UnityEngine.Object) null))
                  return;
                ChatBox.Instance.NewChatMsg("", msg1, (Color) ColorScheme.GetColor(Global.ColorSystem), "", ChatOrigination.System, ContentType.STRING, (object) null);
              }));
              break;
            case 36:
              if (Client.game != null)
                Controller.Instance.DestroyMap(false, true);
              myBinaryReader.ReadInt32();
              Client.cryp = myBinaryReader.ReadBytes();
              Client._gameFacts.ManualDeserialize(myBinaryReader, true, true, (byte) 0);
              Client.game = Client._gameFacts.game;
              Client.game.isSpectator = true;
              Client.game.MAPCREATED = false;
              UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
              {
                Client.game.serverState = new ServerState();
                Client.joinedFrom = Client.JoinLocation.Lobby;
                Controller.Instance.InitMap(false, false, true);
                Client.game.isSandbox = false;
                Client.game.isServer = false;
                Client.game.isClient = true;
                Client.game.isReplay = false;
                Client.NameOrReplay = Client.Name;
                Client.SomeSetup();
                Spectator.ConnectToGame();
              }));
              break;
            case 41:
              int id4 = myBinaryReader.ReadInt32();
              string n3 = myBinaryReader.ReadString();
              bool v1 = myBinaryReader.ReadBoolean();
              GameFacts g6 = Client._games.GetValue(id4);
              if (v1)
                g6.invitedPlayers.Add(n3);
              else
                g6.invitedPlayers.Remove(n3);
              UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
              {
                if ((UnityEngine.Object) LobbyMenu.instance != (UnityEngine.Object) null || (UnityEngine.Object) HUD.instance != (UnityEngine.Object) null && Client.game != null && Client.game.isSpectator)
                {
                  if (!string.Equals(n3, Client.Name, StringComparison.OrdinalIgnoreCase))
                    return;
                  LobbyMenu.instance?.RefreshGames();
                  if (!v1)
                    return;
                  switch (Client.inviteChat)
                  {
                    case ChatSetting.On:
                      ChatBox.Instance?.Notification(g6.players[0] + " invited you to a game", g6.players[0], ChatOrigination.System);
                      break;
                    case ChatSetting.Friends:
                      if (!Client.HasFriend(g6.players[0]))
                        break;
                      goto case ChatSetting.On;
                  }
                }
                else
                {
                  if (id4 != Client._gameFacts.id || !UnratedMenu.IsViewingInvitePanel)
                    return;
                  UnratedMenu.instance.OpenInvitePlayers();
                }
              }));
              break;
            case 44:
              SettingsPlayer b1 = new SettingsPlayer();
              b1.Deserialize(myBinaryReader);
              Client.settingsPlayer.CopySpells(b1, false);
              UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
              {
                if ((UnityEngine.Object) UnratedMenu.instance != (UnityEngine.Object) null)
                  UnratedMenu.instance.UpdateSpellIcons();
                if ((UnityEngine.Object) LobbyMenu.instance != (UnityEngine.Object) null)
                  LobbyMenu.instance.UpdateSpellIcons();
                if ((UnityEngine.Object) RatedMenu.instance != (UnityEngine.Object) null)
                  RatedMenu.instance.UpdateSpellIcons();
                Inert.SaveSettingsPlayer();
              }));
              break;
            case 45:
              SettingsPlayer b2 = new SettingsPlayer();
              b2.Deserialize(myBinaryReader);
              Client.settingsPlayer.CopyOutfit(b2);
              UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
              {
                if ((UnityEngine.Object) UnratedMenu.instance != (UnityEngine.Object) null)
                  UnratedMenu.instance.UpdateOutfit();
                if ((UnityEngine.Object) LobbyMenu.instance != (UnityEngine.Object) null)
                  LobbyMenu.instance.UpdateOutfit();
                if ((UnityEngine.Object) RatedMenu.instance != (UnityEngine.Object) null)
                  RatedMenu.instance.UpdateOutfit();
                Inert.SaveSettingsPlayer();
              }));
              break;
            case 52:
              try
              {
                Spectator.Disconnect();
                if (Client.game == null || !Client.game.isSpectator)
                  break;
                Controller.Instance.DestroyMap(false, true);
                break;
              }
              catch (Exception ex)
              {
                Debug.Log((object) ex);
                break;
              }
            case 56:
              string str1_1 = myBinaryReader.ReadString();
              ulong id5 = myBinaryReader.ReadUInt64();
              UnityThreadHelper.Dispatcher.Dispatch2((Action) (() => ChatBox.Instance.NewChatMsg("", str1_1 + "'s Discord ID: " + id5.ToString(), (Color) ColorScheme.GetColor(Global.ColorSystem), str1_1, ChatOrigination.System, ContentType.STRING, (object) null)));
              break;
            case 58:
              string str1_2 = myBinaryReader.ReadString();
              string str2_1 = myBinaryReader.ReadString();
              UnityThreadHelper.Dispatcher.Dispatch2((Action) (() => ChatBox.Instance.NewChatMsg("", str1_2 + " " + str2_1, (Color) ColorScheme.GetColor(Global.ColorSystem), str1_2, ChatOrigination.System, ContentType.STRING, (object) null)));
              break;
            case 59:
              string n4 = myBinaryReader.ReadString();
              UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
              {
                if (!((UnityEngine.Object) UnratedMenu.instance != (UnityEngine.Object) null))
                  return;
                ChatBox.Instance?.NotificationAskToJoin(n4);
              }));
              break;
            case 60:
              byte num5 = myBinaryReader.ReadByte();
              Client.settingsPlayer.fullBook = num5;
              UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
              {
                if ((UnityEngine.Object) UnratedMenu.instance != (UnityEngine.Object) null)
                  UnratedMenu.instance.UpdateSpellIcons();
                if ((UnityEngine.Object) LobbyMenu.instance != (UnityEngine.Object) null)
                  LobbyMenu.instance.UpdateSpellIcons();
                if ((UnityEngine.Object) RatedMenu.instance != (UnityEngine.Object) null)
                  RatedMenu.instance.UpdateSpellIcons();
                Inert.SaveSettingsPlayer();
              }));
              break;
            case 66:
              RatedContainer rf = RatedContainer.Deserialize(myBinaryReader);
              UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
              {
                Client._ratedFacts = rf;
                RatedMenu.instance.RefreshGameOptions();
                Inert.SaveSettingsPlayer();
              }));
              break;
            case 67:
              bool v2 = myBinaryReader.ReadBoolean();
              UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
              {
                if (!((UnityEngine.Object) RatedTab.instance != (UnityEngine.Object) null))
                  return;
                RatedTab.instance.FindOpponents(v2);
              }));
              break;
            case 70:
              RatedTab.FindingOpponents = false;
              Controller.Instance.DestroyMap(true, true);
              Client.game?.Reset(true);
              Client.HandleStartGame(myBinaryReader);
              break;
            case 73:
              Client.cosmetics = Cosmetics.Deserialize(myBinaryReader);
              Client.bonusPrestige = myBinaryReader.ReadSingle();
              Client.MyAccount.cosmetics = Client.cosmetics;
              break;
            case 74:
              string n5 = myBinaryReader.ReadString();
              Cosmetics c1 = Cosmetics.Deserialize(myBinaryReader);
              UnityThreadHelper.Dispatcher.Dispatch2((Action) (() => CosmeticsMenuDev.Create(c1, n5)));
              break;
            case 77:
              Client.RecieveShare(myBinaryReader);
              break;
            case 98:
              int id6 = myBinaryReader.ReadInt32();
              if (!Client._games.Remove(id6))
                break;
              UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
              {
                if ((UnityEngine.Object) LobbyMenu.instance != (UnityEngine.Object) null)
                  LobbyMenu.instance.RefreshGames();
                if (Spectator.connection == null || Client.game == null || (!Client.game.isSpectator || Client.game.gameFacts == null) || (Client.game.gameFacts.id != id6 || !((UnityEngine.Object) HUD.instance != (UnityEngine.Object) null) || (!HUD.instance.LoadingPanel.activeInHierarchy || Client.game.timeline.Count >= 100)))
                  return;
                Client.game.QuitToMainMenu(false, Client.JoinLocation.Lobby, false);
                ChatBox.Instance?.NewChatMsg("This game ended. Returning to lobby.", (Color) ColorScheme.GetColor(Global.ColorSystem));
              }));
              break;
            case 103:
              Client.badges.Deserialize(myBinaryReader);
              Client.MyAccount.badges = Client.badges;
              break;
            case 104:
              string n6 = myBinaryReader.ReadString();
              BitBools c2 = new BitBools();
              c2.Deserialize(myBinaryReader);
              UnityThreadHelper.Dispatcher.Dispatch2((Action) (() => BadgeMenuDev.Create(c2, n6)));
              break;
            case 105:
              string msg2 = myBinaryReader.ReadString();
              float time = myBinaryReader.ReadSingle();
              UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
              {
                if ((UnityEngine.Object) ChatBox.Instance != (UnityEngine.Object) null)
                  ChatBox.Instance.NewChatMsg("", msg2 + " " + Global.ToTime(time), (Color) ColorScheme.GetColor(Global.ColorSystem), "", ChatOrigination.System, ContentType.STRING, (object) null);
                SystemUpdate.Create(msg2, time);
              }));
              break;
            case 106:
              if (myBinaryReader.ReadInt32() == 0)
              {
                PopupRestrictions.Instance?.UpdateData(new Restrictions());
                break;
              }
              PopupRestrictions.Instance?.UpdateData(Restrictions.Deserialize(myBinaryReader, (byte) 2));
              break;
            case 150:
              string str1_3 = myBinaryReader.ReadString();
              string str2_2 = myBinaryReader.ReadString();
              UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
              {
                if (!((UnityEngine.Object) ChatBox.Instance != (UnityEngine.Object) null))
                  return;
                ChatBox.Instance.NewChatMsg("[Clan] " + str1_3, str2_2, (Color) ColorScheme.GetColor(Global.ColorClanText), str1_3, ChatOrigination.Clan, ContentType.STRING, (object) null);
              }));
              break;
            case 151:
              string sender = myBinaryReader.ReadString();
              myBinaryReader.ReadString();
              string msg3 = myBinaryReader.ReadString();
              UnityThreadHelper.Dispatcher.Dispatch2((Action) (() => ChatBox.Instance?.NewChatMsg("From " + sender, msg3, (Color) ColorScheme.GetColor(Global.ColorReceivedPrivate), sender, ChatOrigination.Private, ContentType.STRING, (object) null)));
              break;
            case 153:
              string str1_4 = myBinaryReader.ReadString();
              string str2_3 = myBinaryReader.ReadString();
              UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
              {
                if (!((UnityEngine.Object) ChatBox.Instance != (UnityEngine.Object) null))
                  return;
                ChatBox.Instance.NewChatMsg(str1_4, str2_3, (Color) ((UnityEngine.Object) UnratedMenu.instance != (UnityEngine.Object) null ? ColorScheme.GetColor(Global.ColorGameText) : ColorScheme.GetColor(Global.ColorLobbyText)), str1_4, (UnityEngine.Object) UnratedMenu.instance != (UnityEngine.Object) null ? ChatOrigination.Game : ChatOrigination.Lobby, ContentType.STRING, (object) null);
              }));
              break;
            case 155:
              Quickchat.Data d = Quickchat.Data.Deserialize(myBinaryReader);
              string msg4 = Quickchat.TryGetCommand(d.id, d.options);
              if (msg4 == null)
                break;
              UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
              {
                if (!((UnityEngine.Object) ChatBox.Instance != (UnityEngine.Object) null))
                  return;
                ChatBox.Instance.NewChatMsg(Quickchat.GetDestination(d.destination) + "<sprite name=\"Emoji2_1352\"> " + d.name, msg4, (Color) ColorScheme.GetColor(d.destination), d.name, d.destination, ContentType.STRING, (object) null);
              }));
              break;
            default:
              if (Global.IsGameMsg(num1))
              {
                DataReceivedEventArgs args = DataReceivedEventArgs.GetObject();
                args.Set(b, SendOption.Reliable);
                ZGame.GameClientHandler((object) null, args);
                break;
              }
              Client.GlobalHandler(num1, myBinaryReader);
              break;
          }
        }
        catch (Exception ex)
        {
          Debug.LogError((object) ex.ToString());
        }
      }
    }
  }

  public static void HandleStartGame(myBinaryReader reader)
  {
    reader.ReadInt32();
    Client._gameFacts.ManualDeserialize(reader, true, true, (byte) 0);
    if (Client._gameFacts.GetMultiTeamMode())
    {
      SpellsOnly b1 = SpellsOnly.Deserialize(reader);
      int index1 = Client._gameFacts.players.FindIndex((Predicate<string>) (z => string.Equals(z, Client.Name)));
      Client._gameFacts.settingsPlayer[index1].CopySpells(b1);
      int numberPlayersPerTeam = Client._gameFacts.GetNumberPlayersPerTeam();
      for (int index2 = 1; index2 < numberPlayersPerTeam; ++index2)
      {
        SpellsOnly b2 = SpellsOnly.Deserialize(reader);
        Client._gameFacts.settingsPlayer[index1 + index2].CopySpells(b2);
      }
    }
    else if (Client._gameFacts.GetTeamMode())
    {
      int num = reader.ReadInt32();
      int numberPlayersPerTeam = Client._gameFacts.GetNumberPlayersPerTeam();
      for (int index = 0; index < numberPlayersPerTeam; ++index)
      {
        SpellsOnly b = SpellsOnly.Deserialize(reader);
        Client._gameFacts.settingsPlayer[num + index].CopySpells(b);
      }
    }
    else
    {
      SpellsOnly b = SpellsOnly.Deserialize(reader);
      int index = Client._gameFacts.players.FindIndex((Predicate<string>) (z => string.Equals(z, Client.Name)));
      Client._gameFacts.settingsPlayer[index].CopySpells(b);
    }
    Server.DebugResyncs = reader.ReadBoolean();
    Client.game = Client._gameFacts.game;
    Client.game.isSpectator = false;
    Client.game.MAPCREATED = false;
    Client.RemoveAllDataReceived();
    Client.connection.DataReceived += new EventHandler<DataReceivedEventArgs>(ZGame.GameClientHandler);
    UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
    {
      Client.game.serverState = new ServerState();
      Client.joinedFrom = Client.JoinLocation.Game;
      Controller.Instance.InitMap(false, false, true);
      Client.game.isSandbox = false;
      Client.game.isServer = false;
      Client.game.isClient = true;
      Client.game.isReplay = false;
      Client.NameOrReplay = Client.Name;
      Client.SomeSetup();
    }));
  }

  public static void ConnectToGame()
  {
    Client.ReConnectToServer(Client.JoinLocation.Mainmenu);
  }

  public static void SomeSetup()
  {
    if (Client._gameFacts.GetTeamMode())
      HUD.instance.AddVSPanel();
    Client.game.CreatePlayers(Client._gameFacts);
    if (!Client.game.resyncing)
      Client.game.timeline.Clear();
    Client.map.doneCallback = (Action) (() =>
    {
      Resources.UnloadUnusedAssets();
      HUD.instance.FindPlayer();
      HUD.FindFullBooks(Client.game);
      HUD.instance.SetupStartPanel();
      Client.game.init_Client(ServerState.Busy.Not_started);
      if ((UnityEngine.Object) CameraMovement.Instance != (UnityEngine.Object) null && (UnityEngine.Object) Player.Instance != (UnityEngine.Object) null)
      {
        CameraMovement.Instance.GotoPosition(Player.Instance.GetTransform.position);
        CameraMovement.Instance.target = Player.Instance.person.first();
        CameraMovement.Instance.state = CameraState.Follow;
      }
      HUD.SetupMiniCamera();
      if (!Client.game.isSpectator && (UnityEngine.Object) Player.Instance == (UnityEngine.Object) null)
      {
        int count = Client.game.players.Count;
        string str1 = count.ToString();
        count = Client._gameFacts.players.Count;
        string str2 = count.ToString();
        Debug.LogError((object) ("!!!!! NULL !!!!!!!" + str1 + " " + str2));
      }
      DiscordIntergration.Instance?.UpdateActivity(Client._gameFacts, Client.game.isSpectator, true);
    });
    if (Client.game.isSpectator || Client.game.resyncing)
      return;
    Client.SendToGameServer(new byte[2]
    {
      (byte) 71,
      (byte) Client.game.players.FindIndex((Predicate<ZPerson>) (x => string.Equals(x.name, Client.Name)))
    });
  }

  private static void ReceivedReports(myBinaryReader r)
  {
    int count = r.ReadInt32();
    Client.reports.Clear();
    for (int index = 0; index < count; ++index)
      Client.reports.Add(Report.Deserialize(r, false, (string) null));
    Client.chatLog = r.ReadString();
    UnityThreadHelper.Dispatcher.Dispatch2((Action) (() =>
    {
      Client.chatLog.CopyToClipboard();
      if (count <= 0)
        Client.chatLog = "";
      Controller.Instance.ProcessReports();
    }));
  }

  public static void AskAllSettings(GameSettings r)
  {
    if ((UnityEngine.Object) RatedMenu.instance != (UnityEngine.Object) null || !UnratedMenu.instance.IsFirst)
      return;
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter w = new myBinaryWriter((Stream) memoryStream))
      {
        w.Write((byte) 80);
        r.Serialize(w);
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void AskRestrictions(Restrictions r)
  {
    if ((UnityEngine.Object) RatedMenu.instance != (UnityEngine.Object) null || !UnratedMenu.instance.IsFirst)
      return;
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter w = new myBinaryWriter((Stream) memoryStream))
      {
        w.Write((byte) 79);
        r.Serialize(w);
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void AskGetRank(int type = 0, string name = null)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
      {
        myBinaryWriter.Write((byte) 68);
        myBinaryWriter.Write((byte) type);
        if (type == 5)
        {
          if (name != null)
            myBinaryWriter.Write(name);
        }
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void AskDebugTest(string s)
  {
    Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    MyLocation myLocation = new MyLocation((int) worldPoint.x, (int) worldPoint.y);
    FixedInt fixedInt = Inert.AngleOfVelocity(myLocation - Player.Instance.selected.position);
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
      {
        myBinaryWriter.Write((byte) 92);
        myBinaryWriter.Write(s);
        myBinaryWriter.Write(fixedInt.RawValue);
        myBinaryWriter.Write(myLocation);
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
    if (!Client.game.isSandbox)
      return;
    Client.DevConsole(s, Client.game, new FixedInt?(), new MyLocation?());
  }

  public static void AskToChangeDisplayIcon(int id)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
      {
        myBinaryWriter.Write((byte) 75);
        myBinaryWriter.Write(id);
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void AskToCreateMiniGame(byte gameType)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
      {
        myBinaryWriter.Write((byte) 88);
        myBinaryWriter.Write(gameType);
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void AskTojoinGame(int id)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
      {
        myBinaryWriter.Write((byte) 26);
        myBinaryWriter.Write(id);
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void AcceptClanInvite(string n)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
      {
        myBinaryWriter.Write((byte) 84);
        myBinaryWriter.Write((byte) 9);
        myBinaryWriter.Write(n);
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void AcceptSpectateMiniGame(int id, bool forceSpectator)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
      {
        myBinaryWriter.Write((byte) 89);
        myBinaryWriter.Write(id);
        myBinaryWriter.Write(forceSpectator);
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void AskClanCommand(byte msg, string n)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
      {
        myBinaryWriter.Write((byte) 84);
        myBinaryWriter.Write(msg);
        myBinaryWriter.Write(n);
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void AskClanRank(string n, int rank)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
      {
        myBinaryWriter.Write((byte) 84);
        myBinaryWriter.Write((byte) 4);
        myBinaryWriter.Write(n);
        myBinaryWriter.Write(rank);
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void AskToInvite(string n)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
      {
        myBinaryWriter.Write((byte) 41);
        myBinaryWriter.Write(n);
        myBinaryWriter.Write(!Client._gameFacts.invitedPlayers.Contains(n));
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void AskToKick(string n)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
      {
        myBinaryWriter.Write((byte) 43);
        myBinaryWriter.Write(n);
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void AskToSpectate(int id)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
      {
        myBinaryWriter.Write((byte) 36);
        myBinaryWriter.Write(id);
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void AskToFindOpponents(bool v)
  {
    if (v)
    {
      int num = 0;
      foreach (RatedFacts ratedFacts in Client._ratedFacts.list)
      {
        ++num;
        if (ratedFacts.spellOverrides == null)
        {
          if (!Prestige.VerifySpells(Client.MyAccount, Client.settingsPlayer.spells, ref Client.settingsPlayer._spells.fullBook))
          {
            ChatBox.Instance?.NewChatMsg("Your spell book contains a locked spell!!!!", (Color) ColorScheme.GetColor(Global.ColorSystem));
            return;
          }
          if (Server._restrictions != null && Server._restrictions.HasRestricted(Client.settingsPlayer._spells))
          {
            ChatBox.Instance?.NewChatMsg("Your spell book contains a restricted spell!!!!", (Color) ColorScheme.GetColor(Global.ColorSystem));
            return;
          }
          if (Server._restrictions != null && Server._restrictions.CheckElemental(Client.settingsPlayer._spells, (int) Client.settingsPlayer.Elemental))
          {
            ChatBox.Instance?.NewChatMsg("You're using a restricted elemental!!!!", (Color) ColorScheme.GetColor(Global.ColorSystem));
            return;
          }
        }
        else
        {
          ratedFacts.spellOverrides.VerifySpells();
          if (!Prestige.VerifySpells(Client.MyAccount, ratedFacts.spellOverrides.spells, ref ratedFacts.spellOverrides.fullBook))
          {
            ChatBox.Instance?.NewChatMsg("Your settings profile {" + num.ToString() + "} contains a locked spell!!!!", (Color) ColorScheme.GetColor(Global.ColorSystem));
            return;
          }
          if (Server._restrictions != null && Server._restrictions.HasRestricted(ratedFacts.spellOverrides))
          {
            ChatBox.Instance?.NewChatMsg("Your settings profile {" + num.ToString() + "} contains a restricted spell!!!!", (Color) ColorScheme.GetColor(Global.ColorSystem));
            return;
          }
          if (Server._restrictions != null && Server._restrictions.CheckElemental(ratedFacts.spellOverrides, (int) ratedFacts.spellOverrides.Elemental))
          {
            ChatBox.Instance?.NewChatMsg("Your settings profile {" + num.ToString() + "} is using a restricted elemental!!!!", (Color) ColorScheme.GetColor(Global.ColorSystem));
            return;
          }
        }
      }
    }
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter w = new myBinaryWriter((Stream) memoryStream))
      {
        w.Write((byte) 67);
        w.Write(v);
        if (v)
        {
          w.Write(Global.GetPrefBool("prefbroadcast", true));
          Client._ratedFacts.Serialize(w, true);
        }
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void AskToStart()
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
        myBinaryWriter.Write((byte) 12);
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
    Client._gameFacts.settings.gameType = (ZGame.GameType) Mathf.Clamp((int) Client._gameFacts.settings.gameType, 0, 2);
    Client._gameSettings = Global.Copy<GameSettings>(Client._gameFacts.settings);
    Inert.SaveSettingsPlayer();
  }

  public static void AskToJoinLobbyFromeQue()
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
      {
        myBinaryWriter.Write((byte) 76);
        myBinaryWriter.Write((byte) Client.curGameID);
      }
      if (Client.connection == null || Client.connection.State != ConnectionState.Connected)
      {
        Controller.Instance.DestroyMap(false, true);
        Controller.Instance.OpenMenu(Controller.Instance.MenuLogin, false);
      }
      else
        Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void AskToJoinLobby()
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
      {
        myBinaryWriter.Write((byte) 193);
        myBinaryWriter.Write((byte) Client.curGameID);
        myBinaryWriter.Write((UnityEngine.Object) Player.Instance != (UnityEngine.Object) null ? Player.Instance.person.GetNextMoveID() : 0);
      }
      if (Client.connection == null || Client.connection.State != ConnectionState.Connected)
      {
        Controller.Instance.DestroyMap(false, true);
        Controller.Instance.OpenMenu(Controller.Instance.MenuLogin, false);
      }
      else
        Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void AskToGoToMainMenu()
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
        myBinaryWriter.Write((byte) 28);
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void AskToBid(byte bid)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
      {
        myBinaryWriter.Write((byte) 192);
        myBinaryWriter.Write(Player.Instance.person.id);
        myBinaryWriter.Write(bid);
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void Ask(byte tag, int msg)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
      {
        myBinaryWriter.Write(tag);
        myBinaryWriter.Write(msg);
      }
      Client.connection?.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void Ask(byte tag, byte msg)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
      {
        myBinaryWriter.Write(tag);
        myBinaryWriter.Write(msg);
      }
      Client.connection?.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void Ask(byte msg)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
        myBinaryWriter.Write(msg);
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void AskReadyMulti()
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter w = new myBinaryWriter((Stream) memoryStream))
      {
        w.Write((byte) 17);
        int num = Client._gameFacts.GetNumberPlayersPerTeam() - 1;
        w.Write(num);
        for (int index = 0; index < num; ++index)
          Client.multiSettingsPlayer[index].Serialize(w);
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void AskToCreateRatedLobby()
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter w = new myBinaryWriter((Stream) memoryStream))
      {
        w.Write((byte) 39);
        Client._gameSettings.Serialize(w);
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void AskToCreateGame()
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter w = new myBinaryWriter((Stream) memoryStream))
      {
        w.Write((byte) 29);
        Client._gameSettings.Serialize(w);
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void AskToOpenRated()
  {
  }

  public static void AskToUploadClanOutfit(
    string clan,
    Outfit o,
    Texture2D t,
    Vector2 pivot,
    byte effect)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
      {
        myBinaryWriter.Write((byte) 84);
        myBinaryWriter.Write((byte) 6);
        myBinaryWriter.Write(clan);
        myBinaryWriter.Write((byte) o);
        myBinaryWriter.Write(effect);
        myBinaryWriter.Write(pivot);
        myBinaryWriter.Write(t.EncodeToPNG());
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void AskBanStage(SettingsPlayer sp)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter w = new myBinaryWriter((Stream) memoryStream))
      {
        w.Write((byte) 186);
        w.Write(Player.Instance.person.id);
        w.Write(true);
        new SpellsOnly().Copy(sp).Serialize(w);
        sp.Serialize(w);
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void AskToChangeSpells(SettingsPlayer sp)
  {
    sp.VerifySpells();
    if ((UnityEngine.Object) RatedMenu.instance != (UnityEngine.Object) null)
      Prestige.VerifySpells(Client.MyAccount, sp.spells, ref sp._spells.fullBook);
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter w = new myBinaryWriter((Stream) memoryStream))
      {
        w.Write((byte) 44);
        sp.Serialize(w);
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void AskToChangeElemental(byte fullBook)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
      {
        myBinaryWriter.Write((byte) 60);
        myBinaryWriter.Write(fullBook);
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void AskToChangeOutfit(SettingsPlayer sp)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter w = new myBinaryWriter((Stream) memoryStream))
      {
        w.Write((byte) 45);
        sp.Serialize(w);
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void AskToChangeOutfitInGame(SettingsPlayer sp)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter w = new myBinaryWriter((Stream) memoryStream))
      {
        w.Write((byte) 197);
        w.Write(Player.Instance.person.id);
        sp.Serialize(w);
      }
      if (Client.game.isSandbox)
      {
        Client.game.GameHandler(Client.game.players[0], memoryStream.ToArray(), false, false);
      }
      else
      {
        if (Client.connection == null || Client.connection.State != ConnectionState.Connected)
          return;
        Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
      }
    }
  }

  public static void AskToAddFriend(bool friend, bool add, string n)
  {
    if (Client.connection.State != ConnectionState.Connected)
    {
      MyContextMenu.ShowSimple("Not Connected", (Action) null, new Color?());
    }
    else
    {
      using (MemoryStream memoryStream = new MemoryStream())
      {
        using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
        {
          myBinaryWriter.Write((byte) 50);
          myBinaryWriter.Write(Client.Name);
          myBinaryWriter.Write(friend);
          myBinaryWriter.Write(add);
          myBinaryWriter.Write(n);
        }
        Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
      }
      if (friend)
      {
        if (add)
        {
          if (!Client.friends.Contains(n))
            Client.friends.Add(n);
        }
        else
          Client.friends.Remove(n);
        UnratedMenu.instance?.RefreshFriends(false);
        LobbyMenu.instance?.RefreshFriends(false);
        RatedMenu.instance?.RefreshFriends(false);
      }
      else
      {
        if (add)
        {
          if (!Client.ignore.Contains(n))
            Client.ignore.Add(n);
        }
        else
          Client.ignore.Remove(n);
        Client.RefreshIgnore();
      }
    }
  }

  public static void AskToChangeChatSetting(byte lgf, ChatSetting s)
  {
    if (Client.connection == null || Client.connection.State != ConnectionState.Connected)
    {
      MyContextMenu.ShowSimple("Not Connected", (Action) null, new Color?());
    }
    else
    {
      using (MemoryStream memoryStream = new MemoryStream())
      {
        using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
        {
          myBinaryWriter.Write((byte) 57);
          myBinaryWriter.Write(Client.Name);
          myBinaryWriter.Write(lgf);
          myBinaryWriter.Write((byte) s);
        }
        Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
      }
      switch (lgf)
      {
        case 0:
          Client.lobbyChat = s;
          ChatBox.Instance?.butLobby.Set(s);
          break;
        case 1:
          Client.gameChat = s;
          ChatBox.Instance?.butGame.Set(s);
          break;
        case 2:
          Client.friendChat = s;
          ChatBox.Instance?.butFriends.Set(s);
          break;
        case 3:
          Client.inviteChat = s;
          ChatBox.Instance?.butInvites.Set(s);
          break;
        case 4:
          Client.spectatorChat = s;
          ChatBox.Instance?.butSpectators.Set(s);
          BoatSpectators.Instance?.RefreshVisible();
          break;
        case 5:
          Client.clanChat = s;
          ChatBox.Instance?.butClan.Set(s);
          UnratedMenu instance1 = UnratedMenu.instance;
          if ((instance1 != null ? (instance1.viewing == Viewing.Lobby ? 1 : 0) : 0) != 0)
            UnratedMenu.instance?.RefreshNames(false, false);
          LobbyMenu instance2 = LobbyMenu.instance;
          if ((instance2 != null ? (instance2.viewing == Viewing.Lobby ? 1 : 0) : 0) == 0)
            break;
          LobbyMenu.instance?.RefreshNames(false);
          break;
        case 6:
          Client.teamChat = s;
          ChatBox.Instance?.butTeam.Set(s);
          break;
        case 7:
          Client.minigameChat = s;
          ChatBox.Instance?.butMinigame.Set(s);
          break;
      }
    }
  }

  public static void AskToChangeGameMode(GameFacts.Message msg, int which)
  {
    if ((UnityEngine.Object) UnratedMenu.instance != (UnityEngine.Object) null && !UnratedMenu.instance.IsFirst)
      return;
    if ((UnityEngine.Object) RatedTab.instance != (UnityEngine.Object) null)
    {
      if (!RatedTab.instance.IsFirst)
        return;
      RatedTab.instance.VerifyGameMode(msg, which);
      int count = RatedTab.instance.partyQueue.Count;
    }
    else
    {
      using (MemoryStream memoryStream = new MemoryStream())
      {
        using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
        {
          myBinaryWriter.Write((byte) 14);
          myBinaryWriter.Write((byte) msg);
          myBinaryWriter.Write(which);
        }
        Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
      }
    }
  }

  public static void AskToChangeDescription(string msg)
  {
    if ((UnityEngine.Object) RatedMenu.instance == (UnityEngine.Object) null && !UnratedMenu.instance.IsFirst)
      return;
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
      {
        myBinaryWriter.Write((byte) 82);
        myBinaryWriter.Write(msg);
      }
      Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
    }
  }

  public static void SendPrivateChatMsg(string n, string s)
  {
    if (s.Length > 600)
      s = s.Substring(0, 600);
    if (Client.friendChat == ChatSetting.Off)
      ChatBox.Instance?.NewChatMsg("", "Private chat is disabled - Enable to Send/Receive private messages", (Color) ColorScheme.GetColor(Global.ColorGrayChat), "", ChatOrigination.System, ContentType.STRING, (object) null);
    else if (string.Equals(n, Client.Name, StringComparison.OrdinalIgnoreCase))
    {
      ChatBox.Instance?.NewChatMsg("Note to self", s, (Color) ColorScheme.GetColor(Global.ColorGrayChat), "", ChatOrigination.System, ContentType.STRING, (object) null);
    }
    else
    {
      using (MemoryStream memoryStream = new MemoryStream())
      {
        using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
        {
          myBinaryWriter.Write((byte) 151);
          myBinaryWriter.Write(Client.Name);
          myBinaryWriter.Write(n);
          myBinaryWriter.Write(s);
        }
        Client.SendChatMsg(memoryStream.ToArray(), 0.6f);
      }
      ChatBox.Instance?.NewChatMsg("To " + n, s, (Color) ColorScheme.GetColor(Global.ColorSentPrivate), n, ChatOrigination.System, ContentType.STRING, (object) null);
      if (Client.friendChat != ChatSetting.Friends || Client.HasFriend(n))
        return;
      ChatBox.Instance?.NewChatMsg("", n + " is not on your Friends List - Add them or Enable Friend Chat to see their messages", (Color) ColorScheme.GetColor(Global.ColorGrayChat), n, ChatOrigination.System, ContentType.STRING, (object) null);
    }
  }

  public static void SendClanChatMsg(string s)
  {
    if (s.Length > 600)
      s = s.Substring(0, 600);
    if (Client.clanChat == ChatSetting.Off)
    {
      ChatBox.Instance?.NewChatMsg("", "Clan chat is disabled - Enable to Send/Receive clan messages", (Color) ColorScheme.GetColor(Global.ColorGrayChat), "", ChatOrigination.System, ContentType.STRING, (object) null);
    }
    else
    {
      using (MemoryStream memoryStream = new MemoryStream())
      {
        using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
        {
          myBinaryWriter.Write((byte) 150);
          myBinaryWriter.Write(Client.Name);
          myBinaryWriter.Write(s);
        }
        Client.SendChatMsg(memoryStream.ToArray(), 0.6f);
      }
    }
  }

  public static void SendMiniGameChatMsg(string s)
  {
    if (s.Length > 600)
      s = s.Substring(0, 600);
    if (Client.gameChat == ChatSetting.Off)
    {
      ChatBox.Instance?.NewChatMsg("", "Game chat is disabled - Enable to Send/Receive game messages", (Color) ColorScheme.GetColor(Global.ColorGrayChat), "", ChatOrigination.System, ContentType.STRING, (object) null);
    }
    else
    {
      using (MemoryStream memoryStream = new MemoryStream())
      {
        using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
        {
          myBinaryWriter.Write((byte) 87);
          myBinaryWriter.Write((byte) 7);
          myBinaryWriter.Write(Client.Name);
          myBinaryWriter.Write(s);
        }
        Client.SendChatMsg(memoryStream.ToArray(), 0.6f);
      }
    }
  }

  public static void AskOverheadEmoji(int index)
  {
    if (Client.MyAccount.accountType.IsMuted() && !Client.game.isSandbox && !Client.game.isReplay)
    {
      ChatBox.Instance?.NewChatMsg("Looks like you're muted, try to behave yourself next time.", (Color) ColorScheme.GetColor(Global.ColorSystem));
    }
    else
    {
      if ((double) Time.realtimeSinceStartup < (double) Client._lastOverheadEmoji)
        return;
      Client._lastOverheadEmoji = Time.realtimeSinceStartup + 4f;
      using (MemoryStream memoryStream = new MemoryStream())
      {
        using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
        {
          if (Spectator.isConnected || (UnityEngine.Object) Player.Instance == (UnityEngine.Object) null)
            myBinaryWriter.Write((byte) 83);
          myBinaryWriter.Write(Spectator.isConnected || (UnityEngine.Object) Player.Instance == (UnityEngine.Object) null ? (byte) 6 : (byte) 157);
          myBinaryWriter.Write(Spectator.isConnected || (UnityEngine.Object) Player.Instance == (UnityEngine.Object) null ? Spectator.GetBoatConnection().player.id : (int) Player.Instance.person.id);
          myBinaryWriter.Write(index);
        }
        if (Client.game != null && (Client.game.isSandbox || Client.game.isReplay))
          Client.game.GameHandler(Player.Instance.person, memoryStream.ToArray(), true, false);
        else if (Spectator.isConnected)
          Spectator.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
        else
          Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
      }
    }
  }

  private static IEnumerator<float> FireAllSpells(
    ZCreature c,
    ZGame game,
    FixedInt? angle2,
    MyLocation? pos)
  {
    if (!pos.HasValue)
    {
      Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
      pos = new MyLocation?(new MyLocation((int) worldPoint.x, (int) worldPoint.y));
    }
    MyLocation m = new MyLocation(pos.Value.x, pos.Value.y);
    if (!angle2.HasValue)
      angle2 = new FixedInt?(Inert.AngleOfVelocity(m - c.position));
    FixedInt angle = angle2.Value;
    for (int i = 0; i < Inert.Instance.presentIndex && !((ZComponent) c == (object) null); ++i)
    {
      Spell spell = Inert.Instance.spells[i];
      if (spell.spellEnum != SpellEnum.Arcane_Gate && spell.spellEnum != SpellEnum.Santas_Magic && (spell.spellEnum != SpellEnum.Recall && spell.spellEnum != SpellEnum.The_ol_swaparoo) && spell.spellEnum != SpellEnum.Blink)
      {
        ZSpell.FireWhich(spell, c, c.position, angle, Client._power, m, c.position, 0, false, (SpellSlot) null, false);
        yield return 0.0f;
      }
    }
  }

  public static void DevConsole(string s, ZGame game, FixedInt? angle = null, MyLocation? pos = null)
  {
    if (string.IsNullOrEmpty(s) || string.Equals("kill", s, StringComparison.OrdinalIgnoreCase))
      Controller.Instance.DestroyChatBox();
    else if (string.Equals("help", s, StringComparison.OrdinalIgnoreCase))
    {
      ChatBox.Instance?.NewChatMsg("", "Type a spell name to cast it (must be exact) ex ---> Arcane Tower", (Color) ColorScheme.GetColor(Global.ColorTeamText), "", ChatOrigination.System, ContentType.STRING, (object) null);
      ChatBox.Instance?.NewChatMsg("", "m# -  to select a minion (the player is a minion (zero based index)) ex---> m1.Arcane Tower", (Color) ColorScheme.GetColor(Global.ColorTeamText), "", ChatOrigination.System, ContentType.STRING, (object) null);
      ChatBox.Instance?.NewChatMsg("", "\".\" to seperate commands (used in the example above)", (Color) ColorScheme.GetColor(Global.ColorTeamText), "", ChatOrigination.System, ContentType.STRING, (object) null);
      ChatBox.Instance?.NewChatMsg("", "pie", (Color) ColorScheme.GetColor(Global.ColorTeamText), "", ChatOrigination.System, ContentType.STRING, (object) null);
      ChatBox.Instance?.NewChatMsg("", "quiz (.optional set max) displays/sets completed seasonal quizzes", (Color) ColorScheme.GetColor(Global.ColorTeamText), "", ChatOrigination.System, ContentType.STRING, (object) null);
      ChatBox.Instance?.NewChatMsg("", "spawn (.optional name - default Zezima) Spawns a new character with name and book/outfit if you have one saved with that name", (Color) ColorScheme.GetColor(Global.ColorTeamText), "", ChatOrigination.System, ContentType.STRING, (object) null);
      ChatBox.Instance?.NewChatMsg("", "If Zezima is on the map you can use \"z\" to select him like a minion", (Color) ColorScheme.GetColor(Global.ColorTeamText), "", ChatOrigination.System, ContentType.STRING, (object) null);
      ChatBox.Instance?.NewChatMsg("", "power.# to set fire power can only be used as the first argument (10-2000)", (Color) ColorScheme.GetColor(Global.ColorTeamText), "", ChatOrigination.System, ContentType.STRING, (object) null);
      ChatBox.Instance?.NewChatMsg("", "arma.Spell Name ---> Add that spell name as an Armageddon (Leave blank to remove all custom Armageddon spells)", (Color) ColorScheme.GetColor(Global.ColorTeamText), "", ChatOrigination.System, ContentType.STRING, (object) null);
    }
    else
    {
      string[] commands = s.Split('.', StringSplitOptions.None);
      int i = 0;
      int num1 = 0;
      if (commands[0].StartsWith("x"))
      {
        try
        {
          num1 = int.Parse(commands[0].Substring(1)) - 1;
          List<string> list = ((IEnumerable<string>) commands).ToList<string>();
          list.RemoveAt(0);
          commands = list.ToArray();
        }
        catch (Exception ex)
        {
        }
      }
label_206:
      for (; num1 >= 0; --num1)
      {
        MyLocation myLocation;
        if (string.Equals(commands[0], "power", StringComparison.CurrentCultureIgnoreCase))
        {
          int result;
          if (commands.Length >= 2 && int.TryParse(commands[1], out result))
          {
            if (result > 2000)
              result = 2000;
            else if (result < 10)
              result = 10;
            Client._power = (FixedInt) ((float) result / 1000f);
            ChatBox.Instance?.NewChatMsg("", "power set to: " + result.ToString(), (Color) ColorScheme.GetColor(Global.ColorTeamText), "", ChatOrigination.System, ContentType.STRING, (object) null);
            if (commands.Length != 2)
              i = 2;
            else
              continue;
          }
          else
          {
            ChatBox instance = ChatBox.Instance;
            if (instance != null)
            {
              instance.NewChatMsg("", "power requires a number (ex: power.20)", (Color) ColorScheme.GetColor(Global.ColorSystem), "", ChatOrigination.System, ContentType.STRING, (object) null);
              continue;
            }
            continue;
          }
        }
        else
        {
          FixedInt fixedInt;
          if (string.Equals(commands[0], "windspeed"))
          {
            double result;
            if (commands.Length >= 2 && double.TryParse(commands[1], out result))
            {
              FixedInt x = Mathd.Clamp((FixedInt) (float) result, (FixedInt) 0, (FixedInt) 100);
              Client.game.map.windSpeed = Mathd.Clamp(x, (FixedInt) 0, (FixedInt) 100) * ZMap.MaxWindSpeed;
              Client.game.map.wind = Global.Velocity(Client.game.map.windDir, Client.game.map.windSpeed);
              ChatBox instance = ChatBox.Instance;
              if (instance != null)
              {
                fixedInt = x;
                string str1 = fixedInt.ToString();
                myLocation = Client.game.map.wind;
                string str2 = myLocation.ToString();
                instance.NewChatMsg("", "windspeed set to: " + str1 + "% " + str2, (Color) ColorScheme.GetColor(Global.ColorTeamText), "", ChatOrigination.System, ContentType.STRING, (object) null);
              }
              WindIndicatorUI.Instance?.Refresh();
            }
            else
            {
              ChatBox instance = ChatBox.Instance;
              if (instance != null)
              {
                fixedInt = Client.game.map.windSpeed;
                instance.NewChatMsg("", "windspeed requires a number (ex: windspeed.20) ... current: " + fixedInt.ToString(), (Color) ColorScheme.GetColor(Global.ColorSystem), "", ChatOrigination.System, ContentType.STRING, (object) null);
              }
            }
            Client.game.isWindy = true;
            WindIndicatorUI instance1 = WindIndicatorUI.Instance;
            if (instance1 != null)
            {
              instance1.gameObject.SetActive(true);
              continue;
            }
            continue;
          }
          if (string.Equals(commands[0], "winddir"))
          {
            double result;
            if (commands.Length >= 2 && double.TryParse(commands[1], out result))
            {
              Client.game.map.windDir = (FixedInt) (float) result;
              Client.game.map.wind = Global.Velocity(Client.game.map.windDir, Client.game.map.windSpeed);
              ChatBox instance = ChatBox.Instance;
              if (instance != null)
              {
                string str1 = result.ToString();
                myLocation = Client.game.map.wind;
                string str2 = myLocation.ToString();
                instance.NewChatMsg("", "winddir set to: " + str1 + " " + str2, (Color) ColorScheme.GetColor(Global.ColorTeamText), "", ChatOrigination.System, ContentType.STRING, (object) null);
              }
              WindIndicatorUI.Instance?.Refresh();
            }
            else
            {
              ChatBox instance = ChatBox.Instance;
              if (instance != null)
              {
                fixedInt = Client.game.map.windDir;
                instance.NewChatMsg("", "winddir requires a number (ex: winddir.20) ... current: " + fixedInt.ToString(), (Color) ColorScheme.GetColor(Global.ColorSystem), "", ChatOrigination.System, ContentType.STRING, (object) null);
              }
            }
            Client.game.isWindy = true;
            WindIndicatorUI instance1 = WindIndicatorUI.Instance;
            if (instance1 != null)
            {
              instance1.gameObject.SetActive(true);
              continue;
            }
            continue;
          }
          if (string.Equals(commands[0], "wind"))
          {
            WindIndicatorUI instance1 = WindIndicatorUI.Instance;
            if ((instance1 != null ? (instance1.gameObject.activeInHierarchy ? 1 : 0) : 0) != 0)
            {
              Client.game.isWindy = false;
              WindIndicatorUI instance2 = WindIndicatorUI.Instance;
              if (instance2 != null)
              {
                instance2.gameObject.SetActive(false);
                continue;
              }
              continue;
            }
            Client.game.isWindy = true;
            Client.game.map.RandomizeWind();
            WindIndicatorUI instance3 = WindIndicatorUI.Instance;
            if (instance3 != null)
            {
              instance3.gameObject.SetActive(true);
              continue;
            }
            continue;
          }
        }
        ZCreature c = (ZCreature) null;
        int num2;
        if (string.Equals(commands[i], "z", StringComparison.CurrentCultureIgnoreCase))
        {
          if ((UnityEngine.Object) Player.Instance != (UnityEngine.Object) null && Player.Instance.summonedPerson != null)
            c = Player.Instance.summonedPerson.first();
          num2 = ++i;
        }
        for (int index = 0; index < game.players.Count && (ZComponent) c == (object) null; ++index)
          c = game.players[index].first();
        if (commands.Length > i)
        {
          if (commands[i].StartsWith("byname"))
          {
            string n = commands[i].Substring("byname".Length);
            ZPerson zperson = game.players.Find((Predicate<ZPerson>) (pt => string.Equals(pt.name, n)));
            if (zperson != null && (ZComponent) zperson.first() != (object) null)
              c = zperson.first();
            num2 = ++i;
          }
          if (commands[i].StartsWith("p") && commands[i].Length > 1)
          {
            string s1 = commands[i].Substring(1);
            int index = 0;
            ref int local = ref index;
            if (int.TryParse(s1, out local))
            {
              --index;
              if (index < c.game.players.Count && index >= 0 && (ZComponent) c.game.players[index].first() != (object) null)
              {
                c = c.game.players[index].first();
                num2 = ++i;
              }
            }
          }
          if (commands[i].StartsWith("m") && commands[i].Length > 1)
          {
            string s1 = commands[i].Substring(1);
            int index = 0;
            ref int local = ref index;
            if (int.TryParse(s1, out local) && index < c.parent.controlled.Count && index > 0)
            {
              c = c.parent.controlled[index];
              num2 = ++i;
            }
          }
          if (commands[i].StartsWith("t") && commands[i].Length > 1)
          {
            string s1 = commands[i].Substring(1);
            int num3 = 0;
            ref int local = ref num3;
            if (int.TryParse(s1, out local))
            {
              c.game.PlayersMaxTurnTime += (float) num3;
              HUD instance = HUD.instance;
              if (instance != null)
              {
                instance.UpdateTime();
                continue;
              }
              continue;
            }
          }
        }
        for (; commands.Length > i; num2 = ++i)
        {
          if (string.Equals(commands[i], "all", StringComparison.CurrentCultureIgnoreCase))
          {
            game.ongoing.RunSpell(Client.FireAllSpells(c ?? game.players[0].first(), game, angle, pos), true);
            ChatBox instance = ChatBox.Instance;
            if (instance != null)
            {
              instance.NewChatMsg("", c.name + " Firing All Spells", (Color) ColorScheme.GetColor(Global.ColorSystem), "", ChatOrigination.System, ContentType.STRING, (object) null);
              goto label_206;
            }
            else
              goto label_206;
          }
          else if (string.Equals(commands[i], "quiz", StringComparison.CurrentCultureIgnoreCase))
          {
            if (commands.Length > i + 1)
            {
              int result = 0;
              if (int.TryParse(commands[i + 1], out result))
              {
                PlayerPrefs.SetInt("quiz_max", result);
                ChatBox instance = ChatBox.Instance;
                if (instance != null)
                {
                  string[] strArray = new string[5]
                  {
                    "Set max quizzes: ",
                    result.ToString(),
                    "(",
                    null,
                    null
                  };
                  num2 = PlayerPrefs.GetInt("quizcorrectcount");
                  strArray[3] = num2.ToString();
                  strArray[4] = " completed";
                  instance.NewChatMsg("", string.Concat(strArray), (Color) ColorScheme.GetColor(Global.ColorSystem), "", ChatOrigination.System, ContentType.STRING, (object) null);
                  goto label_206;
                }
                else
                  goto label_206;
              }
              else
              {
                ChatBox instance = ChatBox.Instance;
                if (instance != null)
                {
                  instance.NewChatMsg("", "Max quizzes must be a valid integer." + result.ToString(), (Color) ColorScheme.GetColor(Global.ColorSystem), "", ChatOrigination.System, ContentType.STRING, (object) null);
                  goto label_206;
                }
                else
                  goto label_206;
              }
            }
            else
            {
              ChatBox instance = ChatBox.Instance;
              if (instance != null)
              {
                num2 = PlayerPrefs.GetInt("quizcorrectcount");
                string str1 = num2.ToString();
                num2 = PlayerPrefs.GetInt("quiz_max", 10);
                string str2 = num2.ToString();
                instance.NewChatMsg("", "Correct Quizzes: " + str1 + " out of " + str2, (Color) ColorScheme.GetColor(Global.ColorSystem), "", ChatOrigination.System, ContentType.STRING, (object) null);
                goto label_206;
              }
              else
                goto label_206;
            }
          }
          else if (string.Equals(commands[i], "ship", StringComparison.CurrentCultureIgnoreCase))
          {
            BoatSpectators.Create(Client.Name);
            ChatBox instance = ChatBox.Instance;
            if (instance != null)
            {
              instance.NewChatMsg("", "Created the spectator ship", (Color) ColorScheme.GetColor(Global.ColorSystem), "", ChatOrigination.System, ContentType.STRING, (object) null);
              goto label_206;
            }
            else
              goto label_206;
          }
          else if (string.Equals(commands[i], "fps", StringComparison.CurrentCultureIgnoreCase))
          {
            int targetFrameRate = Application.targetFrameRate;
            Application.targetFrameRate = int.Parse(commands[i + 1]);
            ChatBox instance = ChatBox.Instance;
            if (instance != null)
            {
              string str1 = targetFrameRate.ToString();
              num2 = Application.targetFrameRate;
              string str2 = num2.ToString();
              instance.NewChatMsg("", "Before: " + str1 + " After: " + str2, (Color) ColorScheme.GetColor(Global.ColorSystem), "", ChatOrigination.System, ContentType.STRING, (object) null);
              goto label_206;
            }
            else
              goto label_206;
          }
          else if (string.Equals(commands[i], "spawn", StringComparison.CurrentCultureIgnoreCase))
          {
            if ((UnityEngine.Object) Player.Instance != (UnityEngine.Object) null)
              Player.Instance.person.panelPlayer.MyTurn(true);
            if (HUD.instance.game.players.Count >= 24)
            {
              ChatBox instance = ChatBox.Instance;
              if (instance != null)
              {
                instance.NewChatMsg("", "Reached Player Limit", (Color) ColorScheme.GetColor(Global.ColorSystem), "", ChatOrigination.System, ContentType.STRING, (object) null);
                goto label_206;
              }
              else
                goto label_206;
            }
            else
            {
              string name = "Zezima";
              if (commands.Length > i + 1 && !string.IsNullOrEmpty(commands[i + 1]))
                name = commands[i + 1];
              else if (HUD.instance.game.players.Count > 1)
              {
                int n = HUD.instance.game.players.Count - 2;
                for (int index = 0; HUD.instance.game.players.FindIndex((Predicate<ZPerson>) (player => string.Equals(player.name, Client.spawnNames[n]))) != -1 && index < Client.spawnNames.Length; ++index)
                {
                  num2 = n++;
                  if (n >= Client.spawnNames.Length)
                    n = 0;
                }
                name = Client.spawnNames[n];
              }
              ZPerson zperson = Player.SpawnZezima((MyLocation) Camera.main.ScreenToWorldPoint(Input.mousePosition), true, name, HUD.instance.game.players.Count, (SettingsPlayer) null, true, 0);
              if (Player.Instance.summonedPerson == null)
                Player.Instance.summonedPerson = zperson;
              if (game.players.Count > 8)
              {
                game.ScalePlayersPanel(false, 1f);
                goto label_206;
              }
              else
                goto label_206;
            }
          }
          else if (string.Equals(commands[i], "log", StringComparison.CurrentCultureIgnoreCase))
          {
            int num3 = (int) (RandomExtensions.LastBook() + 1) * 12;
            int num4 = 0;
            using (IEnumerator<KeyValuePair<string, Spell>> enumerator = Inert.Instance.spells.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                KeyValuePair<string, Spell> current = enumerator.Current;
                ChatBox.Instance?.NewChatMsg("", "<sprite name=\"" + current.Key + "\"> - " + current.Key, (Color) ColorScheme.GetColor(Global.ColorWhiteText), "", ChatOrigination.System, ContentType.STRING, (object) null);
                ++num4;
                if (num4 >= num3)
                  break;
              }
              goto label_206;
            }
          }
          else
          {
            if (string.Equals(commands[i], "select", StringComparison.CurrentCultureIgnoreCase) && c.controllable)
            {
              Player.Instance.selected = c;
              Player.Instance.selectedCreatureIndex = c.parent.controlled.FindIndex((Predicate<ZCreature>) (zz => (ZComponent) zz == (object) c));
              Player.Instance.selectedCreaturePlayerOffset = game.players.FindIndex((Predicate<ZPerson>) (zz => zz == c.parent));
              Player.Instance.UpdateVisuals();
            }
            else if (string.Equals(commands[i], "move"))
            {
              int result = 0;
              int yInt = 0;
              int.TryParse(commands[i + 1].Split(',', StringSplitOptions.None)[0], out result);
              int.TryParse(commands[i + 1].Split(',', StringSplitOptions.None)[0], out result);
              if ((ZComponent) c.tower != (object) null)
                c.tower.SetPosition(new MyLocation(result, yInt));
              else
                c.SetPosition(new MyLocation(result, yInt));
              ChatBox instance = ChatBox.Instance;
              if (instance != null)
              {
                myLocation = new MyLocation(result, yInt);
                instance.NewChatMsg("", "Moved to: " + myLocation.ToString(), (Color) ColorScheme.GetColor(Global.ColorWhiteText), "", ChatOrigination.System, ContentType.STRING, (object) null);
                goto label_206;
              }
              else
                goto label_206;
            }
            else if (string.Equals(commands[i], "health"))
            {
              int result = 0;
              if (i + 1 >= commands.Length)
              {
                ChatBox instance = ChatBox.Instance;
                if (instance != null)
                {
                  instance.NewChatMsg("", c.name + " health is: " + c.health.ToString(), (Color) ColorScheme.GetColor(Global.ColorWhiteText), "", ChatOrigination.System, ContentType.STRING, (object) null);
                  goto label_206;
                }
                else
                  goto label_206;
              }
              else
              {
                int.TryParse(commands[i + 1], out result);
                if ((ZComponent) c.tower != (object) null)
                  c.tower.Health = result;
                else
                  c.health = result;
                c.UpdateHealthTxt();
                if (result <= 0)
                  c.OnDeath(true);
                ChatBox instance = ChatBox.Instance;
                if (instance != null)
                {
                  instance.NewChatMsg("", c.name + " changed health: " + c.health.ToString(), (Color) ColorScheme.GetColor(Global.ColorWhiteText), "", ChatOrigination.System, ContentType.STRING, (object) null);
                  goto label_206;
                }
                else
                  goto label_206;
              }
            }
            else if (string.Equals(commands[i], "maxhealth"))
            {
              int result = 0;
              if (i + 1 >= commands.Length)
              {
                ChatBox instance = ChatBox.Instance;
                if (instance != null)
                {
                  instance.NewChatMsg("", c.name + " max health is: " + c.maxHealth.ToString(), (Color) ColorScheme.GetColor(Global.ColorWhiteText), "", ChatOrigination.System, ContentType.STRING, (object) null);
                  goto label_206;
                }
                else
                  goto label_206;
              }
              else
              {
                string str1 = commands[i];
                num2 = 1;
                string str2 = num2.ToString();
                int.TryParse(str1 + str2, out result);
                int num3 = Mathf.Clamp(result, 1, 10000);
                c.health = num3;
                c.maxHealth = num3;
                c.UpdateHealthTxt();
                ChatBox instance = ChatBox.Instance;
                if (instance != null)
                {
                  instance.NewChatMsg("", c.name + " changed max health: " + c.maxHealth.ToString(), (Color) ColorScheme.GetColor(Global.ColorWhiteText), "", ChatOrigination.System, ContentType.STRING, (object) null);
                  goto label_206;
                }
                else
                  goto label_206;
              }
            }
            else if (string.Equals(commands[i], "arma", StringComparison.CurrentCultureIgnoreCase))
            {
              if (commands.Length <= i + 1)
              {
                c.game.gameFacts.settings.customArmageddon = (List<SpellEnum>) null;
                c.game.customArmageddon = (List<Spell>) null;
                HUD.instance.SetArmageddonIcon();
                ChatBox instance = ChatBox.Instance;
                if (instance != null)
                {
                  instance.NewChatMsg("", "Removed any custom Armageddons", (Color) ColorScheme.GetColor(Global.ColorGameText), "", ChatOrigination.System, ContentType.STRING, (object) null);
                  goto label_206;
                }
                else
                  goto label_206;
              }
              else
              {
                Spell s1 = (Spell) null;
                if (Inert.Instance.spells.TryGetValue(commands[i + 1], out s1) || Inert.Instance.TryGetSpell(commands[i + 1], out s1))
                {
                  if (c.game.gameFacts.settings.customArmageddon == null)
                    c.game.gameFacts.settings.customArmageddon = new List<SpellEnum>();
                  c.game.gameFacts.settings.customArmageddon.Add(s1.spellEnum);
                  if (c.game.customArmageddon == null)
                    c.game.customArmageddon = new List<Spell>();
                  c.game.customArmageddon.Add(s1);
                  HUD.instance.SetArmageddonIcon();
                  ChatBox instance = ChatBox.Instance;
                  if (instance != null)
                  {
                    instance.NewChatMsg("", "Added " + s1.name + " as an Armageddon", (Color) ColorScheme.GetColor(Global.ColorGameText), "", ChatOrigination.System, ContentType.STRING, (object) null);
                    goto label_206;
                  }
                  else
                    goto label_206;
                }
                else
                {
                  ChatBox instance = ChatBox.Instance;
                  if (instance != null)
                  {
                    instance.NewChatMsg("", "Unknown spell: " + commands[i + 1], (Color) ColorScheme.GetColor(Global.ColorSystem), "", ChatOrigination.System, ContentType.STRING, (object) null);
                    goto label_206;
                  }
                  else
                    goto label_206;
                }
              }
            }
            else if (string.Equals(commands[i], "add", StringComparison.CurrentCultureIgnoreCase))
            {
              Spell s1 = (Spell) null;
              if (Inert.Instance.spells.TryGetValue(commands[i + 1], out s1) || Inert.Instance.TryGetSpell(commands[i + 1], out s1))
              {
                SpellSlot spellSlot = new SpellSlot(s1);
                spellSlot.MaxUses = -1;
                spellSlot.TurnsTillFirstUse = -1;
                c.spells.Add(spellSlot);
                if (ZCreatureCreate.IsGate(spellSlot))
                  c.parent.AddGate(spellSlot);
                ChatBox instance = ChatBox.Instance;
                if (instance != null)
                {
                  instance.NewChatMsg("", "Added the present: " + s1.name, (Color) ColorScheme.GetColor(Global.ColorSystem), "", ChatOrigination.System, ContentType.STRING, (object) null);
                  goto label_206;
                }
                else
                  goto label_206;
              }
              else
                goto label_206;
            }
            else if (string.Equals(commands[i], "addAll", StringComparison.CurrentCultureIgnoreCase))
            {
              int num3 = 0;
              foreach (KeyValuePair<string, Spell> spell in Inert.Instance.spells)
              {
                if (num3 < Inert.Instance.presentIndex)
                {
                  ++num3;
                  if (spell.Value.level < 4)
                  {
                    if (ClientResources.Instance.icons.ContainsKey(spell.Key))
                      c.spells.Add(new SpellSlot(spell.Value));
                    else
                      Debug.LogError((object) ("Missing Icons: " + spell.Key));
                  }
                }
                else
                  break;
              }
              ChatBox instance = ChatBox.Instance;
              if (instance != null)
              {
                instance.NewChatMsg("", "Added all spells", (Color) ColorScheme.GetColor(Global.ColorSystem), "", ChatOrigination.System, ContentType.STRING, (object) null);
                goto label_206;
              }
              else
                goto label_206;
            }
            else if (string.Equals(commands[i], "chat", StringComparison.CurrentCultureIgnoreCase))
            {
              for (int index = 0; index < 99; ++index)
              {
                ++Client.debugLogchat;
                ChatBox.Instance?.NewChatMsg("", Client.debugLogchat.ToString() + ")", (Color) ColorScheme.GetColor(Global.ColorSystem), "", ChatOrigination.System, ContentType.STRING, (object) null);
              }
              goto label_206;
            }
            Spell s2;
            if (Inert.Instance.spells.TryGetValue(commands[i], out s2) || Inert.Instance.TryGetSpell(commands[i], out s2))
            {
              Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
              FixedInt rot_z = !angle.HasValue ? Inert.AngleOfVelocity(new MyLocation((int) worldPoint.x, (int) worldPoint.y) - c.position) : angle.Value;
              MyLocation target = !pos.HasValue ? new MyLocation((int) worldPoint.x, (int) worldPoint.y) : pos.Value;
              ZSpell.FireWhich(s2, c, c.position, rot_z, Client._power, target, new MyLocation(c.position.x, c.position.y + 100), 0, false, (SpellSlot) null, false);
              goto label_206;
            }
            else
            {
              ZPerson zperson = game.players.Find((Predicate<ZPerson>) (pt => string.Equals(pt.name, commands[i])));
              if (zperson != null && (ZComponent) zperson.first() != (object) null)
                c = zperson.first();
              else
                break;
            }
          }
        }
        ChatBox.Instance?.NewChatMsg("", "Unknown command: " + s, (Color) ColorScheme.GetColor(Global.ColorSystem), "", ChatOrigination.System, ContentType.STRING, (object) null);
      }
    }
  }

  public static IEnumerator<float> ChatQue(float delay = 0.6f)
  {
    while (Client.delayedChatQue.Count > 0)
    {
      if ((double) Client.chatquetime < (double) Time.realtimeSinceStartup)
      {
        Client.SendChatMsg(Client.delayedChatQue.Dequeue(), 0.6f);
        Client.chatquetime = Time.realtimeSinceStartup + delay;
      }
      yield return 0.0f;
    }
    Client.IEChatQue = (IEnumerator<float>) null;
  }

  public static void SendChatMsg(byte[] b, float delay = 0.6f)
  {
    if ((double) Client.chatquetime >= (double) Time.realtimeSinceStartup)
    {
      if (Client.delayedChatQue.Count < 3)
        Client.delayedChatQue.Enqueue(b);
      if (Client.IEChatQue != null)
        return;
      Client.IEChatQue = Timing.RunCoroutine(Client.ChatQue(delay));
    }
    else
    {
      Client.connection?.SendBytes(b, SendOption.None);
      Client.chatquetime = Time.realtimeSinceStartup + delay;
    }
  }

  public static void SendShareMsg(byte[] b)
  {
    if ((double) Client.sharequetime >= (double) Time.realtimeSinceStartup)
    {
      ChatBox.Instance?.NewChatMsg("Rate limit reached. You can only share one item every 2 seconds", (Color) ColorScheme.GetColor(Global.ColorSystem));
    }
    else
    {
      Client.connection?.SendBytes(b, SendOption.None);
      Client.sharequetime = Time.realtimeSinceStartup + 2f;
    }
  }

  public static void SendChatMsg(string s)
  {
    if (Client.game != null && Client.game.isTutorial && (UnityEngine.Object) HUD.instance != (UnityEngine.Object) null)
    {
      Client.DevConsole(s, Client.game, new FixedInt?(), new MyLocation?());
    }
    else
    {
      Account account = Client.GetAccount(Client.Name, false);
      if (s.Length > 600 && (!account.accountType.IsModPlus() || s[0] != '?'))
        s = s.Substring(0, 600);
      if (s[0] == '/')
      {
        int num = s.IndexOf(':');
        if (num > 1 && num < Account.MaxNameLength + 2)
        {
          string n = s.Substring(1, num - 1);
          if (s.Length > num + 1 && Client.HasAccount(n))
          {
            Client.SendPrivateChatMsg(n, s.Substring(num + 1));
            ChatBox.Instance.privateChatTo = n;
            return;
          }
          if (s.Length > num + 1)
          {
            ChatBox.Instance.NewChatMsg(n + " does not exist or is offline", Global.ColorSystem);
            return;
          }
        }
      }
      else
      {
        if (s[0] == '.' && s.Length > 1 && (s[1] != '.' && Client.clan != null))
        {
          Client.SendClanChatMsg(s.Substring(1));
          return;
        }
        if (s[0] == ';' && s.Length > 1 && Client.miniGame != null)
        {
          Client.SendMiniGameChatMsg(s.Substring(1));
          return;
        }
        if (s[0] == '\\' && s.Length > 1)
        {
          ChatBox.Instance?.NewChatMsg("[Note] " + Client.Name, s.Substring(1), (Color) ColorScheme.GetColor(Global.ColorNoteText), Client.Name, ChatOrigination.System, ContentType.STRING, (object) null);
          return;
        }
      }
      using (MemoryStream memoryStream = new MemoryStream())
      {
        using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
        {
          if ((UnityEngine.Object) UnratedMenu.instance == (UnityEngine.Object) null && (UnityEngine.Object) LobbyMenu.instance == (UnityEngine.Object) null && !Spectator.isConnected)
          {
            if (s[0] == '/' || s[0] == '-')
            {
              s = s.Substring(1);
              ZGame game = Client.game;
              if ((game != null ? (!game.isTeam ? 1 : 0) : 1) != 0)
              {
                ChatBox.Instance?.NewChatMsg("[Note] " + Client.Name, s, (Color) ColorScheme.GetColor(Global.ColorNoteText), Client.Name, ChatOrigination.System, ContentType.STRING, (object) null);
                return;
              }
              myBinaryWriter.Write((byte) 152);
            }
            else
              myBinaryWriter.Write((byte) 153);
          }
          else
            myBinaryWriter.Write((byte) 153);
          myBinaryWriter.Write(Client.Name);
          myBinaryWriter.Write(s);
        }
        if (Client.connection != null)
          Client.SendChatMsg(memoryStream.ToArray(), 0.6f);
        else
          ChatBox.Instance.NewChatMsg("", "Oops, looks like you're disconnected.", (Color) ColorScheme.GetColor(Global.ColorGrayChat), "", ChatOrigination.System, ContentType.STRING, (object) null);
      }
    }
  }

  public static void AsktoPing(int type, Vector2 pos)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
      {
        myBinaryWriter.Write((byte) 154);
        myBinaryWriter.Write(Client.curGameID);
        myBinaryWriter.Write(type);
        myBinaryWriter.Write(pos);
      }
      if (Client.connection != null && Client.game != null && (!Client.game.isSandbox && !Client.game.isReplay) && (Client.game.isTeam && !Client.game.isMulti))
      {
        Client.connection.SendBytes(memoryStream.ToArray(), SendOption.None);
      }
      else
      {
        ZPerson person = Player.Instance?.person;
        ClientResources.Instance.CreatePing(type, Client.Name, person != null ? person.clientColor : Client.game.players[0].clientColor, pos);
      }
    }
  }

  public static void AskToShare(string nameOfObject, ContentType t, object obj, bool alreadyBytes = false)
  {
    string with = Client.sharingWith;
    if (Client.MyAccount.accountType.IsMuted())
    {
      if (Client.MyAccount.accountType.IsPermMuted())
        return;
      Client._Share(with, t.ToString(), t, obj, alreadyBytes);
    }
    else if (t == ContentType.MiniGameInvite)
    {
      Client._Share(with, nameOfObject, t, obj, alreadyBytes);
    }
    else
    {
      MyContextMenu myContextMenu = MyContextMenu.Show();
      myContextMenu.AddInput((Action<string>) (s =>
      {
        nameOfObject = Server.SanitizeFilename(s);
        if (string.IsNullOrEmpty(nameOfObject))
          nameOfObject = Server.RandomString(8);
        Client._Share(with, nameOfObject, t, obj, alreadyBytes);
      }), nameOfObject, true, true);
      myContextMenu.SetOnCancel((Action) (() => Client.sharingWith = ""));
      myContextMenu.Rebuild(false);
    }
  }

  private static void _Share(
    string with,
    string nameOfObject,
    ContentType t,
    object obj,
    bool alreadyBytes)
  {
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter writer = new myBinaryWriter((Stream) memoryStream))
      {
        writer.Write((byte) 77);
        writer.Write(Client.Name);
        writer.Write(with);
        writer.Write(nameOfObject);
        writer.Write((byte) t);
        if (alreadyBytes)
          writer.WriteBytesNoLength((byte[]) obj);
        else
          Content.ToBytes(writer, obj, t);
      }
      Client.SendShareMsg(memoryStream.ToArray());
    }
    Client.sharingWith = "";
  }

  public static void PollSubmit(MyPoll poll)
  {
    Client.MyAccount.poll = poll.id;
    LobbyMenu.instance?.buttonPoll.SetActive(false);
    LobbyMenu.instance?.buttonPollResults.SetActive(true);
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
      {
        myBinaryWriter.Write((byte) 90);
        myBinaryWriter.Write((byte) 2);
        myBinaryWriter.Write(MyPoll.ToBytes<MyPoll>(poll));
      }
      Client.SendShareMsg(memoryStream.ToArray());
    }
  }

  public static void PollMake(MyPoll poll)
  {
    if (!Client.MyAccount.accountType.isDevOrHeadMod())
      return;
    using (MemoryStream memoryStream = new MemoryStream())
    {
      using (myBinaryWriter myBinaryWriter = new myBinaryWriter((Stream) memoryStream))
      {
        myBinaryWriter.Write((byte) 90);
        myBinaryWriter.Write((byte) 3);
        myBinaryWriter.Write(poll == null ? 0 : 1);
        if (poll != null)
          myBinaryWriter.Write(MyPoll.ToBytes<MyPoll>(poll));
      }
      Client.SendShareMsg(memoryStream.ToArray());
    }
    Tutorial.Print("Sent to server");
  }

  public static void RecieveShare(myBinaryReader reader)
  {
    string str = reader.ReadString();
    string a = reader.ReadString();
    string name1 = reader.ReadString();
    ContentType contentType = (ContentType) reader.ReadByte();
    object content = Content.GetContent(reader, contentType);
    string name2 = Client.Name;
    bool flag = string.Equals(a, name2, StringComparison.OrdinalIgnoreCase);
    switch (contentType)
    {
      case ContentType.MiniGameInvite:
        ChatBox.Instance.NewContent(name1, "[" + str + "] sent a mini-game invite - " + name1, (Color) ColorScheme.GetColor(Global.ColorNotification), flag ? ChatOrigination.Private : ChatOrigination.Lobby, contentType, content);
        break;
      case ContentType.RatedSettings:
        ChatBox.Instance.NewContent(name1, "[" + str + "] is searching for [" + name1, (Color) ColorScheme.GetColor(Global.ColorNotification), flag ? ChatOrigination.Private : ChatOrigination.Lobby, contentType, content);
        break;
      default:
        ChatBox instance = ChatBox.Instance;
        string name3 = name1;
        string msg;
        if (!flag)
          msg = "[" + str + "] uploaded " + (contentType == ContentType.Outfit ? "an " : "a ") + contentType.ToString() + " - " + name1;
        else
          msg = "[" + str + "] uploaded a private " + contentType.ToString() + " - " + name1;
        Color color = (Color) ColorScheme.GetColor(Global.ColorNotification);
        int num1 = flag ? 2 : 0;
        int num2 = (int) contentType;
        object data = content;
        instance.NewContent(name3, msg, color, (ChatOrigination) num1, (ContentType) num2, data);
        break;
    }
  }

  public static void CheckBloodToggle()
  {
    Client.showBlood = Global.GetPrefBool("showblood", true);
  }

  public static void ToggleBlood(bool v)
  {
    Client.showBlood = v;
    Global.SetPrefBool("showblood", v);
  }

  public enum JoinLocation
  {
    Mainmenu,
    Lobby,
    Game,
    TestTutorial,
    Tutorial,
    Replay,
    Store,
  }

  [Serializable]
  public class TempIgnored
  {
    [NonSerialized]
    public HashSet<string> ignored = new HashSet<string>();
    public List<Client.TempIgnored.Who> list = new List<Client.TempIgnored.Who>();

    public void RemoveByTime()
    {
      long binary = DateTime.Now.ToBinary();
      bool flag = false;
      while (this.list.Count > 0 && this.list[0].time <= binary)
      {
        this.ignored.Remove(this.list[0].name);
        this.list.RemoveAt(0);
        flag = true;
      }
      if (!flag)
        return;
      Client.TempIgnored.Save();
      Client.RefreshIgnore();
    }

    public bool Ignored(string n)
    {
      return this.ignored.Contains(n);
    }

    public void Add(string n, long t)
    {
      if (this.ignored.Add(n))
      {
        this.list.Add(new Client.TempIgnored.Who()
        {
          name = n,
          time = t
        });
      }
      else
      {
        Client.TempIgnored.Who who = this.list.Find((Predicate<Client.TempIgnored.Who>) (x => string.Equals(x.name, n)));
        if (who != null)
          this.list.Remove(who);
        this.list.Add(new Client.TempIgnored.Who()
        {
          name = n,
          time = t
        });
        this.list.Sort((Comparison<Client.TempIgnored.Who>) ((a, b) => (int) (a.time - b.time)));
      }
      Client.RefreshIgnore();
      if (t == long.MaxValue)
        return;
      Client.TempIgnored.Save();
    }

    public bool Remove(string n)
    {
      bool flag = this.ignored.Remove(n);
      for (int index = 0; index < this.list.Count; ++index)
      {
        if (string.Equals(this.list[index].name, n))
        {
          this.list.RemoveAt(index);
          Client.RefreshIgnore();
          Client.TempIgnored.Save();
          return flag;
        }
      }
      return flag;
    }

    public void Filter()
    {
      for (int index = this.list.Count - 1; index >= 0 && this.list[index].time == long.MaxValue; --index)
        this.list.RemoveAt(index);
    }

    public static string PATH
    {
      get
      {
        return SaveFolder.persistentDataPath + Path.DirectorySeparatorChar.ToString() + "tempIgnored.json";
      }
    }

    public static void Save()
    {
      File.WriteAllText(Client.TempIgnored.PATH, JsonUtility.ToJson((object) Client.tempIgnored));
    }

    public static void Load()
    {
      try
      {
        if (File.Exists(Client.TempIgnored.PATH))
        {
          Client.tempIgnored = JsonUtility.FromJson<Client.TempIgnored>(File.ReadAllText(Client.TempIgnored.PATH));
          Client.tempIgnored.Filter();
          foreach (Client.TempIgnored.Who who in Client.tempIgnored.list)
            Client.tempIgnored.ignored.Add(who.name);
        }
        else
          Client.tempIgnored = new Client.TempIgnored();
      }
      catch (Exception ex)
      {
        Debug.LogError((object) ex);
        Client.tempIgnored = new Client.TempIgnored();
      }
    }

    [Serializable]
    public class Who
    {
      public string name;
      public long time;

      public string TimeTill()
      {
        if (this.time == long.MaxValue)
          return "This Session";
        TimeSpan timeSpan = DateTime.FromBinary(this.time) - DateTime.Now;
        if (timeSpan.Hours >= 1)
          return timeSpan.Hours.ToString() + " Hour" + (timeSpan.Hours > 1 ? "s" : "");
        return timeSpan.Minutes >= 1 ? ((int) (timeSpan.TotalMinutes + 0.5)).ToString() + " Minute" + ((int) (timeSpan.TotalMinutes + 0.5) > 1 ? "s" : "") : "Briefly";
      }
    }
  }
}
