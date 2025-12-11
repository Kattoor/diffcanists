
using HardShellStudios.InputManager;
using Lean.Touch;
using MovementEffects;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraMovement : MonoBehaviour
{
  public static Queue<IFollowTarget> followTargets = new Queue<IFollowTarget>();
  public static bool FOLLOWTARGETS = true;
  public static bool reversedX = false;
  public static bool reversedY = false;
  public static bool allowscrollwheel = true;
  public static bool refollowCamera = true;
  public static readonly int[] zoomLevels = new int[10]
  {
    15,
    50,
    150,
    250,
    350,
    450,
    550,
    650,
    750,
    850
  };
  public CameraState state = CameraState.Stationary;
  public Vector3 target_lastFrame = Vector3.zero;
  public Vector3 offset = new Vector3(0.0f, 0.0f, -200f);
  private Vector3 lerpFrom = Vector3.zero;
  private Vector3 lerpOffset = Vector3.zero;
  private Camera _camera;
  public Transform _background;
  public ZCreature target;
  public float sizeX;
  public float sizeY;
  private float bgMinX;
  private float bgMinY;
  private float bgMaxX;
  private float bgMaxY;
  public IFollowTarget activeTarget;
  public float mapXmin;
  public float mapXmax;
  public float mapYmin;
  public float mapYmax;
  private float horz;
  private float vert;
  private float lerpF;
  private bool wasFollowingTarget;
  private bool wasChatting;

  public static CameraMovement Instance { get; private set; }

  public bool IsfollowingBee(ZCreature t)
  {
    if (t.type == CreatureType.Beehive)
    {
      ZCreatureBeehive zcreatureBeehive = (ZCreatureBeehive) t;
      for (int index = 0; index < zcreatureBeehive.bees.Count; ++index)
      {
        if ((ZComponent) zcreatureBeehive.bees[index] != (object) null && (ZComponent) zcreatureBeehive.bees[index] == (object) this.target)
          return true;
      }
    }
    return false;
  }

  public void SetBounds()
  {
    if (Client.game == null)
      return;
    this.sizeX = Vector3.Distance(this._camera.ViewportToWorldPoint(new Vector3(1f, 0.0f, 0.0f)), this._camera.ViewportToWorldPoint(new Vector3(0.5f, 0.0f, 0.0f)));
    this.sizeY = Vector3.Distance(this._camera.ViewportToWorldPoint(new Vector3(0.0f, 1f, 0.0f)), this._camera.ViewportToWorldPoint(new Vector3(0.0f, 0.5f, 0.0f)));
    this.mapYmax = (float) Client.map.Height + 1000f - this.sizeY;
    this.mapYmin = 0.0f;
    if ((double) this.mapYmax < (double) this.mapYmin)
      this.mapYmax = this.mapYmin;
    this.mapXmax = (float) Client.map.Width + 1000f - this.sizeX;
    this.mapXmin = this.sizeX - 1000f;
    if ((double) this.mapXmax < (double) this.mapXmin)
    {
      this.mapXmax = (float) Client.map.Width * 0.5f;
      this.mapXmin = this.mapXmax;
    }
    if ((bool) (Object) MapObjects.Instance)
      MapObjects.Instance.SetWaves();
    if ((Object) this._background != (Object) null)
    {
      SpriteRenderer component = this._background.GetComponent<SpriteRenderer>();
      MapEnum mapMode = Client._gameFacts.GetMapMode();
      int mapIndex = GameFacts.GetMapIndex(mapMode);
      component.sprite = Client._tutorial == null || !Client._tutorial.NOBACKGROUND ? (Global.GetPrefBool("prefhdbg", false) ? ClientResources.Instance.mapBgBig[GameFacts.GetMapIndex(Client._gameFacts.GetMapMode())] : ClientResources.Instance.mapBgs[mapIndex]) : ClientResources.Instance.spriteBlack;
      float a = Mathf.Clamp01(PlayerPrefs.GetFloat("prefblackBg", 1f));
      Color white = Color.white;
      white.a = a;
      component.color = !Client._gameFacts.settings.altGeneration || mapMode != MapEnum.Grassy_Hills ? white : new Color(0.39f, 0.39f, 0.8f, a);
      float height = (float) component.sprite.texture.height;
      float width = (float) component.sprite.texture.width;
      this._background.localScale = new Vector3(Mathf.Max((float) ((double) this.sizeX * 2.0 + 200.0), (float) (Client.map.Width + 1900)) / width, Mathf.Max((float) ((double) this.sizeY * 2.0 + 200.0), (float) (Client.map.Height + 1900)) / height);
      this.bgMaxY = (float) (Client.map.Height + 1000) - height / 2f * this._background.localScale.y;
      this.bgMinY = (float) ((double) height / 2.0 * (double) this._background.localScale.y - 1000.0);
      this.bgMaxX = (float) (Client.map.Width + 1000) - width / 2f * this._background.localScale.x;
      this.bgMinX = (float) ((double) width / 2.0 * (double) this._background.localScale.x - 1000.0);
      if ((double) this.bgMaxX < (double) this.bgMinX)
      {
        this.bgMaxX = (float) Client.map.Width * 0.5f;
        this.bgMinX = this.bgMaxX;
      }
      if ((double) this.bgMaxY < (double) this.bgMinY)
        this.bgMaxY = this.bgMinY;
    }
    float num = this.sizeX / 8f;
    this._camera.transform.GetChild(1).localScale = new Vector3(num, num, 1f);
  }

  private void Awake()
  {
    CameraMovement.Instance = this;
  }

  private void OnDestroy()
  {
    if (!((Object) CameraMovement.Instance == (Object) this))
      return;
    CameraMovement.Instance = (CameraMovement) null;
  }

  public static void PrefChanged()
  {
    if ((Object) HUD.instance == (Object) null)
    {
      CameraMovement.Instance._background.GetComponent<SpriteRenderer>().color = Color.black;
    }
    else
    {
      MapEnum mapMode = Client._gameFacts.GetMapMode();
      float a = Mathf.Clamp01(PlayerPrefs.GetFloat("prefblackBg", 1f));
      Color white = Color.white;
      white.a = a;
      CameraMovement.Instance._background.GetComponent<SpriteRenderer>().color = !Client._gameFacts.settings.altGeneration || mapMode != MapEnum.Grassy_Hills ? white : new Color(0.39f, 0.39f, 0.8f, a);
      float t = Mathf.Clamp01(PlayerPrefs.GetFloat("prefblackFg", 1f));
      white.a = 1f;
      float num = Mathf.Lerp(0.4f, 1f, t);
      white.r = num;
      white.g = num;
      white.b = num;
      if (Client.map == null || Client.map.GetRawSprites() == null)
        return;
      foreach (ZMap.RawSprite rawSprite in Client.map.GetRawSprites())
      {
        if ((Object) rawSprite.sr != (Object) null)
          rawSprite.sr.color = white;
      }
    }
  }

  public void Start()
  {
    this._camera = Camera.main;
    this._background = this._camera.transform.GetChild(0);
    CameraMovement.PrefChanged();
    this._background.gameObject.SetActive(true);
    CameraMovement.reversedX = Global.GetPrefBool("prefreversedx", false);
    CameraMovement.reversedY = Global.GetPrefBool("prefreversedy", false);
    CameraMovement.allowscrollwheel = Global.GetPrefBool("prefScrollWheel", true);
    Camera.main.orthographicSize = PlayerPrefs.GetFloat("prefZoom", 350f);
    this.SetBounds();
  }

  public bool HasValidFollowTarget()
  {
    if (CameraMovement.followTargets.Count == 0)
    {
      if (this.activeTarget == null || !this.activeTarget.Check())
        return false;
      this.Follow(this.activeTarget.GetTarget());
      return true;
    }
    if ((Object) Player.Instance != (Object) null && (Object) Player.Instance.selectedSpell != (Object) null)
    {
      CameraMovement.followTargets.Clear();
      this.activeTarget = (IFollowTarget) null;
      return false;
    }
    if (this.activeTarget == null || !this.activeTarget.Check())
    {
      this.lerpFrom = this.transform.position;
      this.lerpOffset = Vector3.zero;
      this.lerpF = 0.0f;
      while (CameraMovement.followTargets.Count > 0)
      {
        this.activeTarget = CameraMovement.followTargets.Dequeue();
        if (this.activeTarget != null && this.activeTarget.Check())
        {
          this.Follow(this.activeTarget.GetTarget());
          return true;
        }
      }
      return false;
    }
    this.Follow(this.activeTarget.GetTarget());
    return true;
  }

  public void KillIfMoving()
  {
    CameraMovement.followTargets.Clear();
    this.activeTarget = (IFollowTarget) null;
    if (this.state != CameraState.MoveTo)
      return;
    this.state = CameraState.Stationary;
  }

  public void Follow(Vector3 p)
  {
    this.wasFollowingTarget = true;
    if ((double) p.z > 0.0 || (double) p.y < 0.0)
      return;
    p.x = Mathf.Clamp(p.x, this.mapXmin, this.mapXmax);
    p.y = Mathf.Clamp(p.y, this.mapYmin, this.mapYmax);
    p.z = -100f;
    if ((double) this.lerpF >= 1.0)
    {
      this.transform.position = p + this.lerpOffset;
    }
    else
    {
      this.lerpF += Time.deltaTime;
      this.transform.position = new Vector3(Mathf.SmoothStep(this.lerpFrom.x, p.x, this.lerpF), Mathf.SmoothStep(this.lerpFrom.y, p.y, this.lerpF), -10f);
      if ((double) Vector3.Distance(p, this.transform.position) < 100.0)
      {
        this.lerpOffset = this.transform.position - p;
        this.lerpOffset.z = 0.0f;
        this.lerpF = 2f;
      }
    }
    this.UpdateBackground();
  }

  private void Update()
  {
  }

  public static int FindNextZoom(int x, bool v)
  {
    for (int index = 0; index < CameraMovement.zoomLevels.Length; ++index)
    {
      if (CameraMovement.zoomLevels[index] == x)
        return v ? CameraMovement.zoomLevels[Mathf.Clamp(index + 1, 0, CameraMovement.zoomLevels.Length - 1)] : CameraMovement.zoomLevels[Mathf.Clamp(index - 1, 0, CameraMovement.zoomLevels.Length - 1)];
    }
    return 250;
  }

  public void LateUpdate()
  {
    if (Client.game == null || !Client.game.AllowInput || Input.anyKey && this.wasChatting)
      return;
    if (this.wasChatting)
      this.wasChatting = false;
    if ((Object) HUD.instance != (Object) null && HUD.instance.Chatting() && !string.IsNullOrEmpty(Global.InputString))
      this.wasChatting = true;
    if (((Object) HUD.instance == (Object) null || HUD.instance.chatInput.gameObject.activeSelf) && (Object) MapEditor.Instance == (Object) null)
      return;
    Vector3 position = this.transform.position;
    position.z = 0.0f;
    if (HUD.UseTouchControls)
    {
      float pinchRatio = LeanGesture.GetPinchRatio(0.0f);
      if ((double) pinchRatio != 1.0)
      {
        this._camera.orthographicSize = Mathf.Clamp(this._camera.orthographicSize + (float) ((1.0 - (double) pinchRatio) * 500.0), 15f, 850f);
        PlayerPrefs.SetFloat("prefZoom", this._camera.orthographicSize);
        this.SetBounds();
      }
    }
    if (Input.touchCount != 0 && (Input.touchCount != 1 || Player.IsPointerOverGameObject(0) || !((Object) Player.Instance?.selectedSpell == (Object) null)))
    {
      switch (Input.touchCount)
      {
        case 3:
          break;
        case 4:
          HUD instance = HUD.instance;
          if (instance != null)
          {
            instance.PressedCenterCamera();
            goto label_39;
          }
          else
            goto label_39;
        default:
          goto label_39;
      }
    }
    float num = (Object) HUD.instance != (Object) null && !HUD.instance.Chatting() || Global.InputString.Length == 0 ? (float) ((hardInput.GetKeyDown("ZoomIn") ? 1 : 0) + (hardInput.GetKeyDown("ZoomOut") ? -1 : 0)) : 0.0f;
    if (CameraMovement.allowscrollwheel)
      num += Global.IsMouseOverGameWindow ? Input.GetAxis("Mouse ScrollWheel") : 0.0f;
    if ((double) num == 0.0 && hardManager.IsUsingController() && (hardInput.GetKeyDown("ZoomIn") || hardInput.GetKeyDown("ZoomOut")))
      num = hardInput.GetKey("Extended Shot") ? 1f : -1f;
    if ((double) num != 0.0 && !EventSystem.current.IsPointerOverGameObject())
    {
      float nextZoom = (float) CameraMovement.FindNextZoom((int) this._camera.orthographicSize, (double) num < 0.0);
      if ((double) nextZoom != (double) this._camera.orthographicSize)
      {
        if ((double) Input.GetAxis("Mouse ScrollWheel") != 0.0 && Global.GetPrefBool("prefZoomMouse", false))
        {
          Vector3 worldPoint1 = this._camera.ScreenToWorldPoint(Input.mousePosition);
          this._camera.orthographicSize = nextZoom;
          Vector3 worldPoint2 = this._camera.ScreenToWorldPoint(Input.mousePosition);
          position.x += worldPoint1.x - worldPoint2.x;
          position.y += worldPoint1.y - worldPoint2.y;
          this.state = CameraState.Stationary;
        }
        else
          this._camera.orthographicSize = nextZoom;
        PlayerPrefs.SetFloat("prefZoom", nextZoom);
        this.SetBounds();
      }
    }
    if (((Object) HUD.instance == (Object) null || !HUD.instance.Chatting() || !this.wasChatting) && (!Client.game.isSandbox || (Object) ChatBox.Instance == (Object) null))
    {
      this.horz = Input.GetAxis(hardManager.GetAxisCameraX()) + hardInput.GetAxis("Camera Right", "Camera Left", 3f);
      this.vert = Input.GetAxis(hardManager.GetAxisCameraY()) + hardInput.GetAxis("Camera Up", "Camera Down", 3f);
      if (hardManager.IsUsingController() && (double) this.vert != 0.0)
        this.vert = -this.vert;
      if ((double) this.horz != 0.0 || (double) this.vert != 0.0)
      {
        if ((double) this._camera.orthographicSize < 50.0)
        {
          this.horz *= 0.25f;
          this.vert *= 0.25f;
        }
        this.KillMovement();
        position.x += this.horz * 1000f * Time.deltaTime;
        position.y += this.vert * 1000f * Time.deltaTime;
      }
    }
    bool flag = (Object) MapEditor.Instance != (Object) null;
    if ((MyInput.GetMouseButton(1) && !flag || MyInput.GetMouseButton(2) || Input.touchCount == 1 && !Player.IsPointerOverGameObject(0) && ((Object) Player.Instance?.selectedSpell == (Object) null && !flag)) && (!HUD.UseTouchControls || (double) Input.GetAxis("Mouse X") != 0.0 || (double) Input.GetAxis("Mouse Y") != 0.0))
    {
      this.KillMovement();
      if (CameraMovement.reversedX)
        position.x += Input.GetAxis("Mouse X") * -25f;
      else
        position.x += Input.GetAxis("Mouse X") * 25f;
      if (CameraMovement.reversedY)
        position.y += Input.GetAxis("Mouse Y") * -25f;
      else
        position.y += Input.GetAxis("Mouse Y") * 25f;
    }
label_39:
    if (CameraMovement.FOLLOWTARGETS && (this.state != CameraState.Stationary || CameraMovement.refollowCamera) && this.HasValidFollowTarget())
    {
      if (Client.game.serverState.busy != ServerState.Busy.Between_Turns)
        return;
      this.target = (ZCreature) null;
    }
    else
    {
      if (this.wasFollowingTarget)
      {
        this.wasFollowingTarget = false;
        this.activeTarget = (IFollowTarget) null;
        if ((ZComponent) this.target != (object) null)
          this.LerpToTransform(this.target, false);
      }
      if (this.state == CameraState.Stationary)
      {
        this.GotoPosition(position);
      }
      else
      {
        if (this.state != CameraState.Follow)
          return;
        if ((ZComponent) this.target == (object) null || (Object) this.target.transform == (Object) null)
        {
          this.state = CameraState.Stationary;
        }
        else
        {
          if (!((Object) Player.Instance == (Object) null) && !((Object) Player.Instance.selectedSpell == (Object) null))
            return;
          this.GotoPosition(this.target.transform.position);
        }
      }
    }
  }

  public float ClampZoom(float vertExtent)
  {
    return Mathf.Clamp(vertExtent, 15f, 850f);
  }

  public void SetZoom(float vertExtent)
  {
    this._camera.orthographicSize = this.ClampZoom(vertExtent);
    this.SetBounds();
  }

  public float GetZoom()
  {
    return this._camera.orthographicSize;
  }

  public void GotoPosition(Vector3 v)
  {
    v.x = Mathf.Clamp(v.x, this.mapXmin, this.mapXmax);
    v.y = Mathf.Clamp(v.y, this.mapYmin, this.mapYmax);
    v.z = -100f;
    this.transform.position = v;
    this.UpdateBackground();
  }

  public void KillMovement()
  {
    CameraMovement.FOLLOWTARGETS = false;
    this.wasFollowingTarget = false;
    if (this.activeTarget != null)
      this.activeTarget = (IFollowTarget) null;
    if (CameraMovement.followTargets.Count > 0)
      CameraMovement.followTargets.Clear();
    if (this.state == CameraState.Stationary)
      return;
    this.target = (ZCreature) null;
    Timing.KillCoroutines("Camera");
    this.state = CameraState.Stationary;
  }

  public void LerpToPosition(Vector3 v)
  {
    if (MyInput.GetMouseButton(1))
      return;
    Timing.RunCoroutine(this.LerpPosition(v), Segment.Update, "Camera");
  }

  public void TutorialLerpToPosition(Vector3 v, bool interupatable)
  {
    if (interupatable && MyInput.GetMouseButton(1))
      return;
    if (interupatable)
      Timing.RunCoroutine(this.LerpPosition(v), Segment.Update, "Camera");
    else
      Timing.RunCoroutine(this.LerpPosition(v), Segment.Update, "UnInteruptable");
  }

  public void LerpToTransform(ZCreature v, bool force = false)
  {
    if (!force && (!CameraMovement.refollowCamera && this.state != CameraState.Follow && this.state != CameraState.MoveTo || (MyInput.GetMouseButton(1) || Client.game.resyncing) || ((ZComponent) this.target == (object) v && (this.state == CameraState.MoveTo || this.state == CameraState.Follow) || (Object) Player.Instance != (Object) null && (Object) Player.Instance.selectedSpell != (Object) null)))
      return;
    Timing.KillCoroutines("Camera");
    Timing.RunCoroutine(this.LerpTransform(v, force), Segment.Update, "Camera");
  }

  private IEnumerator<float> LerpTransform(ZCreature t, bool force = false)
  {
    CameraMovement cameraMovement = this;
    cameraMovement.state = CameraState.MoveTo;
    Vector3 v = Vector3.zero;
    v.z = -100f;
    Vector3 start = cameraMovement.transform.position;
    cameraMovement.target = t;
    float scale = force ? 5f : 2f;
    for (float i = 0.0f; (double) i < 1.0; i += Time.deltaTime * scale)
    {
      if ((ZComponent) t != (object) null)
      {
        v.x = Mathf.Clamp(t.transform.position.x, cameraMovement.mapXmin, cameraMovement.mapXmax);
        v.y = Mathf.Clamp(t.transform.position.y, cameraMovement.mapYmin, cameraMovement.mapYmax);
      }
      cameraMovement.transform.position = Vector3.Lerp(start, v, i);
      cameraMovement.UpdateBackground();
      yield return 0.0f;
    }
    cameraMovement.state = !((ZComponent) t != (object) null) ? CameraState.Stationary : CameraState.Follow;
  }

  private IEnumerator<float> LerpPosition(Vector3 v)
  {
    CameraMovement cameraMovement = this;
    cameraMovement.state = CameraState.MoveTo;
    v.x = Mathf.Clamp(v.x, cameraMovement.mapXmin, cameraMovement.mapXmax);
    v.y = Mathf.Clamp(v.y, cameraMovement.mapYmin, cameraMovement.mapYmax);
    v.z = -100f;
    Vector3 start = cameraMovement.transform.position;
    for (float i = 0.0f; (double) i < 1.0; i += Time.deltaTime * 2f)
    {
      cameraMovement.transform.position = Vector3.Lerp(start, v, i);
      cameraMovement.UpdateBackground();
      yield return 0.0f;
    }
    cameraMovement.state = CameraState.Stationary;
  }

  public static float InverseLerp(Vector3 a, Vector3 b, Vector3 value)
  {
    Vector3 vector3 = b - a;
    return Vector3.Dot(value - a, vector3) / Vector3.Dot(vector3, vector3);
  }

  public void UpdateBackground()
  {
    if ((Object) this._background == (Object) null)
      return;
    this._background.position = new Vector3(Mathf.Lerp(this.bgMinX, this.bgMaxX, Mathf.InverseLerp(this.mapXmin, this.mapXmax, this.transform.position.x)), Mathf.Lerp(this.bgMinY, this.bgMaxY, Mathf.InverseLerp(this.mapYmin, this.mapYmax, this.transform.position.y)));
  }
}
