
using AOT;
using Steamworks;
using System;
using System.Collections;
using System.Text;
using UnityEngine;

[DisallowMultipleComponent]
public class SteamManager : MonoBehaviour
{
  protected AppId_t appid = (AppId_t) 2901550U;
  public static bool startedFromSteam;
  protected static bool s_EverInitialized;
  protected static SteamManager s_instance;
  public GetTicketForWebApiResponse_t? ticket;
  protected Callback<GetTicketForWebApiResponse_t> _receivedTicket;
  protected Callback<MicroTxnAuthorizationResponse_t> _microTxn;
  internal bool reconnect;
  protected bool m_bInitialized;
  protected SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook;

  public static bool HasTicket
  {
    get
    {
      SteamManager instance = SteamManager.Instance;
      return instance != null && instance.ticket.HasValue;
    }
  }

  internal static SteamManager Instance
  {
    get
    {
      return (UnityEngine.Object) SteamManager.s_instance == (UnityEngine.Object) null ? new GameObject(nameof (SteamManager)).AddComponent<SteamManager>() : SteamManager.s_instance;
    }
  }

  public static bool Initialized
  {
    get
    {
      return SteamManager.Instance.m_bInitialized;
    }
  }

  [MonoPInvokeCallback(typeof (SteamAPIWarningMessageHook_t))]
  protected static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
  {
    Debug.LogWarning((object) pchDebugText);
  }

  [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
  private static void InitOnPlayMode()
  {
    SteamManager.s_EverInitialized = false;
    SteamManager.s_instance = (SteamManager) null;
  }

  protected virtual void Awake()
  {
    if ((UnityEngine.Object) SteamManager.s_instance != (UnityEngine.Object) null)
    {
      UnityEngine.Object.Destroy((UnityEngine.Object) this.gameObject);
    }
    else
    {
      SteamManager.s_instance = this;
      if (SteamManager.s_EverInitialized)
        throw new Exception("Tried to Initialize the SteamAPI twice in one session!");
      UnityEngine.Object.DontDestroyOnLoad((UnityEngine.Object) this.gameObject);
      if (!Packsize.Test())
        Debug.LogError((object) "[Steamworks.NET] Packsize Test returned false, the wrong version of Steamworks.NET is being run in this platform.", (UnityEngine.Object) this);
      if (!DllCheck.Test())
        Debug.LogError((object) "[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.", (UnityEngine.Object) this);
      try
      {
        if (SteamAPI.RestartAppIfNecessary(this.appid))
        {
          SteamManager.startedFromSteam = false;
          return;
        }
      }
      catch (DllNotFoundException ex)
      {
        Debug.LogError((object) ("[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n" + ex?.ToString()), (UnityEngine.Object) this);
        return;
      }
      this.m_bInitialized = SteamAPI.Init();
      if (!this.m_bInitialized)
      {
        Debug.LogError((object) "[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.", (UnityEngine.Object) this);
        this.StartCoroutine(this.TryAgain());
      }
      else
      {
        SteamManager.s_EverInitialized = true;
        this._receivedTicket = Callback<GetTicketForWebApiResponse_t>.Create(new Callback<GetTicketForWebApiResponse_t>.DispatchDelegate(this.RecievedTicket));
        this._microTxn = Callback<MicroTxnAuthorizationResponse_t>.Create(new Callback<MicroTxnAuthorizationResponse_t>.DispatchDelegate(this.MicroTxnResponse));
        this._receivedTicket.Register(new Callback<GetTicketForWebApiResponse_t>.DispatchDelegate(this.RecievedTicket));
        this._microTxn.Register(new Callback<MicroTxnAuthorizationResponse_t>.DispatchDelegate(this.MicroTxnResponse));
        SteamUser.GetAuthTicketForWebApi("arc");
        SteamManager.startedFromSteam = true;
      }
    }
  }

  private IEnumerator TryAgain()
  {
    while (true)
    {
      this.m_bInitialized = SteamAPI.Init();
      if (!this.m_bInitialized)
        yield return (object) new WaitForSeconds(10f);
      else
        break;
    }
    this.Refresh(false);
  }

  public void Refresh(bool reconnect)
  {
    this.reconnect = reconnect;
    if (!SteamManager.s_EverInitialized)
    {
      this.m_bInitialized = SteamAPI.Init();
      SteamManager.s_EverInitialized = true;
    }
    this._receivedTicket = Callback<GetTicketForWebApiResponse_t>.Create(new Callback<GetTicketForWebApiResponse_t>.DispatchDelegate(this.RecievedTicket));
    this._microTxn = Callback<MicroTxnAuthorizationResponse_t>.Create(new Callback<MicroTxnAuthorizationResponse_t>.DispatchDelegate(this.MicroTxnResponse));
    this._receivedTicket.Register(new Callback<GetTicketForWebApiResponse_t>.DispatchDelegate(this.RecievedTicket));
    this._microTxn.Register(new Callback<MicroTxnAuthorizationResponse_t>.DispatchDelegate(this.MicroTxnResponse));
    SteamUser.GetAuthTicketForWebApi("arc");
  }

  public static string ByteArrayToString(byte[] ba)
  {
    return BitConverter.ToString(ba).Replace("-", "");
  }

  private void MicroTxnResponse(MicroTxnAuthorizationResponse_t t)
  {
    Debug.Log((object) "client txn response");
    if ((int) t.m_unAppID != (int) this.appid.m_AppId)
      return;
    Prestige.Ask((byte) 14, t.m_ulOrderID, t.m_bAuthorized);
  }

  private void RecievedTicket(GetTicketForWebApiResponse_t t)
  {
    this.ticket = new GetTicketForWebApiResponse_t?(t);
    if (!((UnityEngine.Object) LocalServerConn.Instance != (UnityEngine.Object) null))
      return;
    LocalServerConn.Instance.steamButtonSignin.Interactable(true);
    LocalServerConn.Instance.steamSignin.SetActive(true);
    if (!this.reconnect)
      return;
    LocalServerConn.Instance.ForceConnect();
  }

  protected virtual void OnEnable()
  {
    if ((UnityEngine.Object) SteamManager.s_instance == (UnityEngine.Object) null)
      SteamManager.s_instance = this;
    if (!this.m_bInitialized || this.m_SteamAPIWarningMessageHook != null)
      return;
    this.m_SteamAPIWarningMessageHook = new SteamAPIWarningMessageHook_t(SteamManager.SteamAPIDebugTextHook);
    SteamClient.SetWarningMessageHook(this.m_SteamAPIWarningMessageHook);
  }

  protected virtual void OnDestroy()
  {
    if ((UnityEngine.Object) SteamManager.s_instance != (UnityEngine.Object) this)
      return;
    SteamManager.s_instance = (SteamManager) null;
    if (!this.m_bInitialized)
      return;
    SteamAPI.Shutdown();
  }

  protected virtual void Update()
  {
    if (!this.m_bInitialized)
      return;
    SteamAPI.RunCallbacks();
  }
}
