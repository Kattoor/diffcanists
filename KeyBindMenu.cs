
using HardShellStudios.InputManager;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class KeyBindMenu : MonoBehaviour
{
  public UIOnHover toggleMouseX;
  public UIOnHover toggleMouseY;
  public UIOnHover toggleScrollWheel;
  public UIOnHover toggleMouseZoom;
  public UIOnHover toggleControls;
  public UIOnHover toggleSkipWarning;
  public UIOnHover toggleDetower;
  public GameObject panelHotkeys;
  [Header("Controller")]
  public GameObject controllerStuff;
  public TMP_Text txtInfo;
  public TMP_Text infoControllerMouse;
  public UIOnSlider sliderCameraSpeed;
  public UIOnSlider sliderMouseSpeed;
  public UIOnHover toggleKeyboard;
  public UIOnHover toggleController;
  public UIOnHover[] toggleGroup;
  private bool connected;

  public static KeyBindMenu Instance { get; private set; }

  public void ClickBack()
  {
    Object.Destroy((Object) this.gameObject);
  }

  private void Awake()
  {
    KeyBindMenu.Instance = this;
  }

  private void OnDestroy()
  {
    if (!((Object) KeyBindMenu.Instance == (Object) this))
      return;
    KeyBindMenu.Instance = (KeyBindMenu) null;
  }

  private void Start()
  {
    this.toggleMouseX.AlwaysOn = Global.GetPrefBool("prefreversedx", false);
    this.toggleMouseY.AlwaysOn = Global.GetPrefBool("prefreversedy", false);
    this.toggleScrollWheel.AlwaysOn = Global.GetPrefBool("prefScrollWheel", true);
    this.toggleControls.onClick.AddListener(new UnityAction(this.ToggleControls));
    this.toggleControls.AlwaysOn = Global.GetPrefBool("prefControls", HUD.UseTouchControls);
    if ((Object) this.toggleMouseZoom != (Object) null)
    {
      this.toggleMouseZoom.onClick.AddListener(new UnityAction(this.MouseZoom));
      this.toggleMouseZoom.AlwaysOn = Global.GetPrefBool("prefZoomMouse", false);
    }
    this.toggleSkipWarning.onClick.AddListener((UnityAction) (() => HUD.ToggleSkipWarning(this.toggleSkipWarning, false)));
    this.toggleSkipWarning.AlwaysOn = !Global.GetPrefBool("prefskipwarning", false);
    this.toggleDetower.onClick.AddListener((UnityAction) (() =>
    {
      bool b = !Global.GetPrefBool("prefjumpdetower", false);
      Global.SetPrefBool("prefjumpdetower", b);
      if ((Object) Player.Instance != (Object) null)
        Player.Instance.jumpIsDetower = b;
      this.toggleDetower.AlwaysOn = b;
    }));
    this.toggleDetower.AlwaysOn = Global.GetPrefBool("prefjumpdetower", false);
    this.StartCoroutine(this.CheckForControllers());
    Input.GetJoystickNames();
    this.UpdateToggles();
    this.sliderCameraSpeed.SetValue(MyInput.cameraSpeed - 0.5f);
    this.sliderMouseSpeed.SetValue(MyInput.mouseSpeed - 0.5f);
    this.sliderCameraSpeed.onClick.AddListener((UnityAction<float>) (f => MyInput.SetCameraSpeed(f + 0.5f)));
    this.sliderMouseSpeed.onClick.AddListener((UnityAction<float>) (f => MyInput.SetMouseSpeed(f + 0.5f)));
    this.toggleKeyboard.AlwaysOn = PlayerPrefs.GetInt("prefusecontroller", 0) == 2;
    this.toggleController.AlwaysOn = PlayerPrefs.GetInt("prefusecontroller", 0) == 1;
    this.toggleKeyboard.onClick.AddListener((UnityAction) (() =>
    {
      if (this.toggleKeyboard.AlwaysOn)
        return;
      this.toggleKeyboard.AlwaysOn = true;
      this.toggleController.AlwaysOn = false;
      PlayerPrefs.SetInt("prefusecontroller", 2);
      Controller.Instance.keysKeyboard.ChangeSetup(hardManager.SetupType.Keyboard);
    }));
    this.toggleController.onClick.AddListener((UnityAction) (() =>
    {
      if (this.toggleController.AlwaysOn)
        return;
      this.toggleKeyboard.AlwaysOn = false;
      this.toggleController.AlwaysOn = true;
      PlayerPrefs.SetInt("prefusecontroller", 1);
      Controller.Instance.keysKeyboard.ChangeSetup(hardManager.SetupType.Controller);
    }));
  }

  public void ToggleHotkeys()
  {
    this.panelHotkeys.SetActive(!this.panelHotkeys.activeSelf);
  }

  public void ToggleControls()
  {
    bool b = !Global.GetPrefBool("prefControls", HUD.UseTouchControls);
    Global.SetPrefBool("prefControls", b);
    this.toggleControls.AlwaysOn = b;
    HUD.UseTouchControls = b;
    HUD.instance?.panelControls.SetActive(b);
    HUD.instance?.buttonPing.gameObject.SetActive(b && !Client.game.isSandbox && Client.game.isTeam);
  }

  public void ResetControls()
  {
    hardInput.ResetAllBindings();
  }

  public void ToggleMouseX()
  {
    bool b = !Global.GetPrefBool("prefreversedx", false);
    CameraMovement.reversedX = b;
    Global.SetPrefBool("prefreversedx", b);
    this.toggleMouseX.AlwaysOn = b;
  }

  public void ToggleMouseY()
  {
    bool b = !Global.GetPrefBool("prefreversedy", false);
    CameraMovement.reversedY = b;
    Global.SetPrefBool("prefreversedy", b);
    this.toggleMouseY.AlwaysOn = b;
  }

  public void ToggleScrollWheel()
  {
    bool b = !Global.GetPrefBool("prefScrollWheel", true);
    CameraMovement.allowscrollwheel = b;
    Global.SetPrefBool("prefScrollWheel", b);
    this.toggleScrollWheel.AlwaysOn = b;
  }

  public void MouseZoom()
  {
    if (!Global.GetPrefBool("prefZoomMouse", false))
    {
      Global.SetPrefBool("prefZoomMouse", true);
      this.toggleMouseZoom.AlwaysOn = true;
    }
    else
    {
      Global.SetPrefBool("prefZoomMouse", false);
      this.toggleMouseZoom.AlwaysOn = false;
    }
  }

  public void SetPS3()
  {
    hardInput.SetControllerType(hardInput.controllerType.PS3);
    this.UpdateToggles();
  }

  public void SetXBOX360()
  {
    hardInput.SetControllerType(hardInput.controllerType.XBOX360);
    this.UpdateToggles();
  }

  private void UpdateToggles()
  {
    for (int index = 0; index < this.toggleGroup.Length; ++index)
      this.toggleGroup[index].AlwaysOn = false;
    TMP_Text txtInfo = this.txtInfo;
    string[] strArray = new string[5]
    {
      "Left Click (",
      null,
      null,
      null,
      null
    };
    KeyCode keyCode = KeyCode.Joystick1Button0;
    strArray[1] = hardInput.GetKeyName(keyCode.ToString(), 5);
    strArray[2] = ") to Cancel - Del (";
    keyCode = KeyCode.Joystick1Button1;
    strArray[3] = hardInput.GetKeyName(keyCode.ToString(), 5);
    strArray[4] = ") to Remove";
    string str1 = string.Concat(strArray);
    txtInfo.text = str1;
    TMP_Text infoControllerMouse = this.infoControllerMouse;
    keyCode = KeyCode.Joystick1Button0;
    string keyName1 = hardInput.GetKeyName(keyCode.ToString(), 5);
    keyCode = KeyCode.Joystick1Button1;
    string keyName2 = hardInput.GetKeyName(keyCode.ToString(), 5);
    string str2 = keyName1 + " = Left Click\n" + keyName2 + " = Right Click\nIf Zoom shares the same key - Use the extend key to zoom in";
    infoControllerMouse.text = str2;
    switch (hardInput.GetControllerType())
    {
      case hardInput.controllerType.PS3:
        this.toggleGroup[0].AlwaysOn = true;
        break;
      case hardInput.controllerType.PS4:
        this.toggleGroup[0].AlwaysOn = true;
        break;
      case hardInput.controllerType.XBOX1:
        this.toggleGroup[1].AlwaysOn = true;
        break;
      case hardInput.controllerType.XBOX360:
        this.toggleGroup[1].AlwaysOn = true;
        break;
    }
  }

  private IEnumerator CheckForControllers()
  {
    while (true)
    {
      string[] joystickNames = Input.GetJoystickNames();
      if (!this.connected && joystickNames.Length != 0)
      {
        this.connected = true;
        this.OnControllerConnected(true);
        Debug.Log((object) "Connected");
      }
      else if (this.connected && joystickNames.Length == 0)
      {
        this.connected = false;
        this.OnControllerConnected(false);
        Debug.Log((object) "Disconnected");
      }
      yield return (object) new WaitForSeconds(1f);
    }
  }

  public void OnControllerConnected(bool v)
  {
    this.controllerStuff.SetActive(v);
  }
}
