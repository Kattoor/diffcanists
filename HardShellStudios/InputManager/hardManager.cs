
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace HardShellStudios.InputManager
{
  [AddComponentMenu("Hard Shell Studios/Input Manager/Input Manager")]
  [Serializable]
  public class hardManager : MonoBehaviour
  {
    [SerializeField]
    public hardManager.givenInputs[] inputs = new hardManager.givenInputs[0];
    public Dictionary<string, hardKey> keyMaps = new Dictionary<string, hardKey>();
    private string currentRebind = "";
    public hardManager.SetupType setupType;
    private bool replaceSecond;
    private GameObject currentBindFrom;
    public bool saveControllerType;
    public bool useController;
    public int controllerType;
    public static hardManager singleton;
    private int frame;
    private float lastX;
    private float lastY;
    private hardKey tempKey;
    private hardKey tempAxis;

    private void Awake()
    {
      hardManager.singleton = this;
    }

    private void Update()
    {
      ++this.frame;
    }

    private void Start()
    {
      for (int index = 0; index < this.inputs.Length; ++index)
      {
        int axisType = this.inputs[index].axisType;
        int axisType2 = this.inputs[index].axisType2;
        if (this.inputs[index].axisType > 0)
          this.inputs[index].primaryKeycode = KeyCode.None;
        if (this.inputs[index].axisType2 > 0)
          this.inputs[index].secondaryKeycode = KeyCode.None;
        hardKey hardKey = new hardKey(this.inputs[index].keyName, this.translateController(this.inputs[index].primaryKeycode, this.inputs[index].controllerOne, axisType), this.translateController(this.inputs[index].secondaryKeycode, this.inputs[index].controllerTwo, axisType2), this.getAxisFromController(this.inputs[index].controllerOne, axisType), this.getAxisFromController(this.inputs[index].controllerTwo, axisType2), this.inputs[index].saveKey);
        this.keyMaps.Add(hardKey.keyName, hardKey);
      }
      this.loadBindings();
    }

    private KeyCode translateController(
      KeyCode keyName,
      hardKey.controllerMap inputName,
      int axis)
    {
      if (axis == 5 && this.useController)
        return this.getFromController(inputName);
      if (axis >= 10 && axis <= 15)
      {
        keyName = KeyCode.None;
        if (!this.useController)
          axis = 0;
      }
      return keyName;
    }

    private int getAxisFromController(hardKey.controllerMap inputName, int axis)
    {
      if (!this.useController)
        return axis >= 10 && axis <= 15 ? 0 : axis;
      switch (inputName)
      {
        case hardKey.controllerMap.L2:
          return 14;
        case hardKey.controllerMap.R2:
          return 15;
        case hardKey.controllerMap.DPadUp:
          return 10;
        case hardKey.controllerMap.DPadDown:
          return 11;
        case hardKey.controllerMap.DPadLeft:
          return 13;
        case hardKey.controllerMap.DPadRight:
          return 12;
        default:
          return axis;
      }
    }

    private KeyCode getFromController(hardKey.controllerMap inputName)
    {
      switch (inputName)
      {
        case hardKey.controllerMap.Square:
          return KeyCode.Joystick1Button2;
        case hardKey.controllerMap.Cross:
          return KeyCode.Joystick1Button0;
        case hardKey.controllerMap.Circle:
          return KeyCode.Joystick1Button1;
        case hardKey.controllerMap.Triangle:
          return KeyCode.Joystick1Button3;
        case hardKey.controllerMap.L1:
          return KeyCode.Joystick1Button4;
        case hardKey.controllerMap.R1:
          return KeyCode.Joystick1Button5;
        case hardKey.controllerMap.L2:
          return KeyCode.None;
        case hardKey.controllerMap.R2:
          return KeyCode.None;
        case hardKey.controllerMap.Share:
          return KeyCode.Joystick1Button6;
        case hardKey.controllerMap.Options:
          return KeyCode.Joystick1Button7;
        case hardKey.controllerMap.LeftStick:
          return KeyCode.Joystick1Button8;
        case hardKey.controllerMap.RightStick:
          return KeyCode.Joystick1Button9;
        case hardKey.controllerMap.PSHome:
          return KeyCode.Joystick1Button12;
        case hardKey.controllerMap.Trackpad:
          return KeyCode.Joystick1Button13;
        case hardKey.controllerMap.DPadUp:
          return KeyCode.None;
        case hardKey.controllerMap.DPadDown:
          return KeyCode.None;
        case hardKey.controllerMap.DPadLeft:
          return KeyCode.None;
        case hardKey.controllerMap.DPadRight:
          return KeyCode.None;
        default:
          return KeyCode.None;
      }
    }

    public bool GetKeyDownSecondaryOnly(string keyName)
    {
      bool flag = false;
      this.tempKey = this.keyMaps[keyName];
      if (this.tempKey.keyWheelState2 == 0 || this.tempKey.keyWheelState2 == 5)
      {
        if (Input.GetKeyDown(this.tempKey.keyInput2))
          flag = true;
      }
      else if (this.tempKey.keyWheelState2 == 1)
      {
        if ((double) Input.mouseScrollDelta.y > 0.0)
          flag = true;
      }
      else if (this.tempKey.keyWheelState2 == 2)
      {
        if ((double) Input.mouseScrollDelta.y < 0.0)
          flag = true;
      }
      else if (this.useController)
      {
        if (this.tempKey.keyWheelState2 == 10)
        {
          if ((double) Input.GetAxis("DPADVER") == 1.0 && (double) Input.GetAxis("DPADVER") != (double) this.tempKey.keyValue)
          {
            flag = true;
            this.tempKey.pressedFrame = this.frame;
          }
          else if (this.tempKey.pressedFrame == this.frame)
            flag = true;
          this.tempKey.keyValue = Input.GetAxis("DPADVER");
        }
        else if (this.tempKey.keyWheelState2 == 11)
        {
          if ((double) Input.GetAxis("DPADVER") == -1.0 && (double) Input.GetAxis("DPADVER") != (double) this.tempKey.keyValue)
          {
            flag = true;
            this.tempKey.pressedFrame = this.frame;
          }
          else if (this.tempKey.pressedFrame == this.frame)
            flag = true;
          this.tempKey.keyValue = Input.GetAxis("DPADVER");
        }
        else if (this.tempKey.keyWheelState2 == 12)
        {
          if ((double) Input.GetAxis("DPADHOR") == 1.0 && (double) Input.GetAxis("DPADHOR") != (double) this.tempKey.keyValue)
          {
            flag = true;
            this.tempKey.pressedFrame = this.frame;
          }
          else if (this.tempKey.pressedFrame == this.frame)
            flag = true;
          this.tempKey.keyValue = Input.GetAxis("DPADHOR");
        }
        else if (this.tempKey.keyWheelState2 == 13)
        {
          if ((double) Input.GetAxis("DPADHOR") == -1.0 && (double) Input.GetAxis("DPADHOR") != (double) this.tempKey.keyValue)
          {
            flag = true;
            this.tempKey.pressedFrame = this.frame;
          }
          else if (this.tempKey.pressedFrame == this.frame)
            flag = true;
          this.tempKey.keyValue = Input.GetAxis("DPADHOR");
        }
        else if (this.tempKey.keyWheelState2 == 14)
        {
          if ((double) Input.GetAxis("Left Trigger") == 1.0 && (double) Input.GetAxis("Left Trigger") != (double) this.tempKey.keyValue)
          {
            flag = true;
            this.tempKey.pressedFrame = this.frame;
          }
          else if (this.tempKey.pressedFrame == this.frame)
            flag = true;
          this.tempKey.keyValue = Input.GetAxis("Left Trigger");
        }
        else if (this.tempKey.keyWheelState2 == 15)
        {
          if ((double) Input.GetAxis("Right Trigger") == 1.0 && (double) Input.GetAxis("Right Trigger") != (double) this.tempKey.keyValue)
          {
            flag = true;
            this.tempKey.pressedFrame = this.frame;
          }
          else if (this.tempKey.pressedFrame == this.frame)
            flag = true;
          this.tempKey.keyValue = Input.GetAxis("Right Trigger");
        }
      }
      return flag;
    }

    public bool GetKeyDownPrimaryOnly(string keyName)
    {
      bool flag = false;
      this.tempKey = this.keyMaps[keyName];
      if (this.tempKey.keyWheelState == 0 || this.tempKey.keyWheelState == 5)
      {
        if (Input.GetKeyDown(this.tempKey.keyInput))
          flag = true;
      }
      else if (this.tempKey.keyWheelState == 1)
      {
        if ((double) Input.mouseScrollDelta.y > 0.0)
          flag = true;
      }
      else if (this.tempKey.keyWheelState == 2)
      {
        if ((double) Input.mouseScrollDelta.y < 0.0)
          flag = true;
      }
      else if (this.tempKey.keyWheelState == 10)
      {
        if ((double) Input.GetAxis("DPADVER") == 1.0 && (double) Input.GetAxis("DPADVER") != (double) this.tempKey.keyValue)
        {
          flag = true;
          this.tempKey.pressedFrame = this.frame;
        }
        else if (this.tempKey.pressedFrame == this.frame)
          flag = true;
        this.tempKey.keyValue = Input.GetAxis("DPADVER");
      }
      else if (this.tempKey.keyWheelState == 11)
      {
        if ((double) Input.GetAxis("DPADVER") == -1.0 && (double) Input.GetAxis("DPADVER") != (double) this.tempKey.keyValue)
        {
          flag = true;
          this.tempKey.pressedFrame = this.frame;
        }
        else if (this.tempKey.pressedFrame == this.frame)
          flag = true;
        this.tempKey.keyValue = Input.GetAxis("DPADVER");
      }
      else if (this.tempKey.keyWheelState == 12)
      {
        if ((double) Input.GetAxis("DPADHOR") == 1.0 && (double) Input.GetAxis("DPADHOR") != (double) this.tempKey.keyValue)
        {
          flag = true;
          this.tempKey.pressedFrame = this.frame;
        }
        else if (this.tempKey.pressedFrame == this.frame)
          flag = true;
        this.tempKey.keyValue = Input.GetAxis("DPADHOR");
      }
      else if (this.tempKey.keyWheelState == 13)
      {
        if ((double) Input.GetAxis("DPADHOR") == -1.0 && (double) Input.GetAxis("DPADHOR") != (double) this.tempKey.keyValue)
        {
          flag = true;
          this.tempKey.pressedFrame = this.frame;
        }
        else if (this.tempKey.pressedFrame == this.frame)
          flag = true;
        this.tempKey.keyValue = Input.GetAxis("DPADHOR");
      }
      else if (this.tempKey.keyWheelState == 14)
      {
        if ((double) Input.GetAxis("Left Trigger") == 1.0 && (double) Input.GetAxis("Left Trigger") != (double) this.tempKey.keyValue)
        {
          flag = true;
          this.tempKey.pressedFrame = this.frame;
        }
        else if (this.tempKey.pressedFrame == this.frame)
          flag = true;
        this.tempKey.keyValue = Input.GetAxis("Left Trigger");
      }
      else if (this.tempKey.keyWheelState == 15)
      {
        if ((double) Input.GetAxis("Right Trigger") == 1.0 && (double) Input.GetAxis("Right Trigger") != (double) this.tempKey.keyValue)
        {
          flag = true;
          this.tempKey.pressedFrame = this.frame;
        }
        else if (this.tempKey.pressedFrame == this.frame)
          flag = true;
        this.tempKey.keyValue = Input.GetAxis("Right Trigger");
      }
      return flag;
    }

    public bool GetKeyDown(string keyName)
    {
      bool flag = false;
      this.tempKey = this.keyMaps[keyName];
      if (this.tempKey.keyWheelState == 0 || this.tempKey.keyWheelState == 5)
      {
        if (Input.GetKeyDown(this.tempKey.keyInput))
          flag = true;
      }
      else if (this.tempKey.keyWheelState == 1)
      {
        if ((double) Input.mouseScrollDelta.y > 0.0)
          flag = true;
      }
      else if (this.tempKey.keyWheelState == 2)
      {
        if ((double) Input.mouseScrollDelta.y < 0.0)
          flag = true;
      }
      else if (this.tempKey.keyWheelState == 10)
      {
        if ((double) Input.GetAxis("DPADVER") == 1.0 && (double) Input.GetAxis("DPADVER") != (double) this.tempKey.keyValue)
        {
          flag = true;
          this.tempKey.pressedFrame = this.frame;
        }
        else if (this.tempKey.pressedFrame == this.frame)
          flag = true;
        this.tempKey.keyValue = Input.GetAxis("DPADVER");
      }
      else if (this.tempKey.keyWheelState == 11)
      {
        if ((double) Input.GetAxis("DPADVER") == -1.0 && (double) Input.GetAxis("DPADVER") != (double) this.tempKey.keyValue)
        {
          flag = true;
          this.tempKey.pressedFrame = this.frame;
        }
        else if (this.tempKey.pressedFrame == this.frame)
          flag = true;
        this.tempKey.keyValue = Input.GetAxis("DPADVER");
      }
      else if (this.tempKey.keyWheelState == 12)
      {
        if ((double) Input.GetAxis("DPADHOR") == 1.0 && (double) Input.GetAxis("DPADHOR") != (double) this.tempKey.keyValue)
        {
          flag = true;
          this.tempKey.pressedFrame = this.frame;
        }
        else if (this.tempKey.pressedFrame == this.frame)
          flag = true;
        this.tempKey.keyValue = Input.GetAxis("DPADHOR");
      }
      else if (this.tempKey.keyWheelState == 13)
      {
        if ((double) Input.GetAxis("DPADHOR") == -1.0 && (double) Input.GetAxis("DPADHOR") != (double) this.tempKey.keyValue)
        {
          flag = true;
          this.tempKey.pressedFrame = this.frame;
        }
        else if (this.tempKey.pressedFrame == this.frame)
          flag = true;
        this.tempKey.keyValue = Input.GetAxis("DPADHOR");
      }
      else if (this.tempKey.keyWheelState == 14)
      {
        if ((double) Input.GetAxis("Left Trigger") == 1.0 && (double) Input.GetAxis("Left Trigger") != (double) this.tempKey.keyValue)
        {
          flag = true;
          this.tempKey.pressedFrame = this.frame;
        }
        else if (this.tempKey.pressedFrame == this.frame)
          flag = true;
        this.tempKey.keyValue = Input.GetAxis("Left Trigger");
      }
      else if (this.tempKey.keyWheelState == 15)
      {
        if ((double) Input.GetAxis("Right Trigger") == 1.0 && (double) Input.GetAxis("Right Trigger") != (double) this.tempKey.keyValue)
        {
          flag = true;
          this.tempKey.pressedFrame = this.frame;
        }
        else if (this.tempKey.pressedFrame == this.frame)
          flag = true;
        this.tempKey.keyValue = Input.GetAxis("Right Trigger");
      }
      if (flag)
        return true;
      if (this.tempKey.keyWheelState2 == 0 || this.tempKey.keyWheelState2 == 5)
      {
        if (Input.GetKeyDown(this.tempKey.keyInput2))
          flag = true;
      }
      else if (this.tempKey.keyWheelState2 == 1)
      {
        if ((double) Input.mouseScrollDelta.y > 0.0)
          flag = true;
      }
      else if (this.tempKey.keyWheelState2 == 2)
      {
        if ((double) Input.mouseScrollDelta.y < 0.0)
          flag = true;
      }
      else if (this.useController)
      {
        if (this.tempKey.keyWheelState2 == 10)
        {
          if ((double) Input.GetAxis("DPADVER") == 1.0 && (double) Input.GetAxis("DPADVER") != (double) this.tempKey.keyValue)
          {
            flag = true;
            this.tempKey.pressedFrame = this.frame;
          }
          else if (this.tempKey.pressedFrame == this.frame)
            flag = true;
          this.tempKey.keyValue = Input.GetAxis("DPADVER");
        }
        else if (this.tempKey.keyWheelState2 == 11)
        {
          if ((double) Input.GetAxis("DPADVER") == -1.0 && (double) Input.GetAxis("DPADVER") != (double) this.tempKey.keyValue)
          {
            flag = true;
            this.tempKey.pressedFrame = this.frame;
          }
          else if (this.tempKey.pressedFrame == this.frame)
            flag = true;
          this.tempKey.keyValue = Input.GetAxis("DPADVER");
        }
        else if (this.tempKey.keyWheelState2 == 12)
        {
          if ((double) Input.GetAxis("DPADHOR") == 1.0 && (double) Input.GetAxis("DPADHOR") != (double) this.tempKey.keyValue)
          {
            flag = true;
            this.tempKey.pressedFrame = this.frame;
          }
          else if (this.tempKey.pressedFrame == this.frame)
            flag = true;
          this.tempKey.keyValue = Input.GetAxis("DPADHOR");
        }
        else if (this.tempKey.keyWheelState2 == 13)
        {
          if ((double) Input.GetAxis("DPADHOR") == -1.0 && (double) Input.GetAxis("DPADHOR") != (double) this.tempKey.keyValue)
          {
            flag = true;
            this.tempKey.pressedFrame = this.frame;
          }
          else if (this.tempKey.pressedFrame == this.frame)
            flag = true;
          this.tempKey.keyValue = Input.GetAxis("DPADHOR");
        }
      }
      else if (this.tempKey.keyWheelState2 == 14)
      {
        if ((double) Input.GetAxis("Left Trigger") == 1.0 && (double) Input.GetAxis("Left Trigger") != (double) this.tempKey.keyValue)
        {
          flag = true;
          this.tempKey.pressedFrame = this.frame;
        }
        else if (this.tempKey.pressedFrame == this.frame)
          flag = true;
        this.tempKey.keyValue = Input.GetAxis("Left Trigger");
      }
      else if (this.tempKey.keyWheelState2 == 15)
      {
        if ((double) Input.GetAxis("Right Trigger") == 1.0 && (double) Input.GetAxis("Right Trigger") != (double) this.tempKey.keyValue)
        {
          flag = true;
          this.tempKey.pressedFrame = this.frame;
        }
        else if (this.tempKey.pressedFrame == this.frame)
          flag = true;
        this.tempKey.keyValue = Input.GetAxis("Right Trigger");
      }
      return flag;
    }

    public bool GetKeyUp(string keyName)
    {
      bool flag = false;
      this.tempKey = this.keyMaps[keyName];
      if ((this.tempKey.keyWheelState == 0 || this.tempKey.keyWheelState == 5) && Input.GetKeyUp(this.tempKey.keyInput))
        flag = true;
      if (flag)
        return true;
      if ((this.tempKey.keyWheelState2 == 0 || this.tempKey.keyWheelState2 == 5) && Input.GetKeyUp(this.tempKey.keyInput2))
        flag = true;
      return flag;
    }

    public bool GetKey(string keyName)
    {
      bool flag = false;
      this.tempKey = this.keyMaps[keyName];
      if (this.tempKey.keyWheelState == 0 || this.tempKey.keyWheelState == 5)
      {
        if (Input.GetKey(this.tempKey.keyInput))
          flag = true;
      }
      else if (this.tempKey.keyWheelState == 1)
      {
        if ((double) Input.mouseScrollDelta.y > 0.0)
          flag = true;
      }
      else if (this.tempKey.keyWheelState == 2)
      {
        if ((double) Input.mouseScrollDelta.y < 0.0)
          flag = true;
      }
      else if (this.useController)
      {
        if (this.tempKey.keyWheelState == 10)
        {
          if ((double) Input.GetAxis("DPADVER") == 1.0)
            flag = true;
        }
        else if (this.tempKey.keyWheelState == 11)
        {
          if ((double) Input.GetAxis("DPADVER") == -1.0)
            flag = true;
        }
        else if (this.tempKey.keyWheelState == 12)
        {
          if ((double) Input.GetAxis("DPADHOR") == 1.0)
            flag = true;
        }
        else if (this.tempKey.keyWheelState == 13)
        {
          if ((double) Input.GetAxis("DPADHOR") == -1.0)
            flag = true;
        }
        else if (this.tempKey.keyWheelState == 14)
        {
          if ((double) Input.GetAxis("Left Trigger") == 1.0)
            flag = true;
        }
        else if (this.tempKey.keyWheelState == 15 && (double) Input.GetAxis("Right Trigger") == 1.0)
          flag = true;
      }
      if (flag)
        return true;
      if (this.tempKey.keyWheelState2 == 0 || this.tempKey.keyWheelState2 == 5)
      {
        if (Input.GetKey(this.tempKey.keyInput2))
          flag = true;
      }
      else if (this.tempKey.keyWheelState2 == 1)
      {
        if ((double) Input.mouseScrollDelta.y > 0.0)
          flag = true;
      }
      else if (this.tempKey.keyWheelState2 == 2)
      {
        if ((double) Input.mouseScrollDelta.y < 0.0)
          flag = true;
      }
      else if (this.useController)
      {
        if (this.tempKey.keyWheelState2 == 10)
        {
          if ((double) Input.GetAxis("DPADVER") == 1.0)
            flag = true;
        }
        else if (this.tempKey.keyWheelState2 == 11)
        {
          if ((double) Input.GetAxis("DPADVER") == -1.0)
            flag = true;
        }
        else if (this.tempKey.keyWheelState2 == 12)
        {
          if ((double) Input.GetAxis("DPADHOR") > 0.0)
            flag = true;
        }
        else if (this.tempKey.keyWheelState2 == 13)
        {
          if ((double) Input.GetAxis("DPADHOR") < 0.0)
            flag = true;
        }
        else if (this.tempKey.keyWheelState2 == 14)
        {
          if ((double) Input.GetAxis("Left Trigger") > 0.0)
            flag = true;
        }
        else if (this.tempKey.keyWheelState2 == 15 && (double) Input.GetAxis("Right Trigger") > 0.0)
          flag = true;
      }
      return flag;
    }

    private float MoveTowards(float cur, float tar, float max)
    {
      if ((double) cur > (double) tar)
      {
        cur -= max;
        if ((double) cur < (double) tar)
          cur = tar;
      }
      else if ((double) cur < (double) tar)
      {
        cur += max;
        if ((double) cur > (double) tar)
          cur = tar;
      }
      return cur;
    }

    public float GetAxis(string keyName, string keyName2, float gravity)
    {
      this.tempAxis = this.keyMaps[keyName];
      this.tempAxis.keyValue = !this.GetKey(keyName) ? (!this.GetKey(keyName2) ? this.MoveTowards(this.tempAxis.keyValue, 0.0f, gravity * Time.deltaTime) : Mathf.Clamp(this.tempAxis.keyValue - gravity * Time.deltaTime, -1f, 1f)) : Mathf.Clamp(this.tempAxis.keyValue + gravity * Time.deltaTime, -1f, 1f);
      return this.tempAxis.keyValue;
    }

    public float GetAxis(string keyName, float gravity)
    {
      this.tempAxis = this.keyMaps[keyName];
      if (this.GetKey(keyName))
        this.tempAxis.keyValue += gravity * Time.deltaTime;
      else
        this.tempAxis.keyValue = Mathf.MoveTowards(this.tempAxis.keyValue, 0.0f, gravity * Time.deltaTime);
      this.tempAxis.keyValue = Mathf.Clamp(this.tempAxis.keyValue, -1f, 1f);
      if (this.tempAxis.keyWheelState == 3 || this.tempAxis.keyWheelState2 == 3)
        return this.tempAxis.keyValue = Input.GetAxis("Mouse X") * gravity;
      if (this.tempAxis.keyWheelState == 4 || this.tempAxis.keyWheelState2 == 4)
        return this.tempAxis.keyValue = Input.GetAxis("Mouse Y") * gravity;
      if (this.useController)
      {
        if (this.tempAxis.keyWheelState == 6 || this.tempAxis.keyWheelState2 == 6)
          this.tempAxis.keyValue = Input.GetAxis("STICKLHOR") * gravity;
        else if (this.tempAxis.keyWheelState == 7 || this.tempAxis.keyWheelState2 == 7)
          this.tempAxis.keyValue = Input.GetAxis("STICKLVER") * gravity;
        else if (this.tempAxis.keyWheelState == 8 || this.tempAxis.keyWheelState2 == 8)
          this.tempAxis.keyValue = Input.GetAxis("STICKRHOR") * gravity;
        else if (this.tempAxis.keyWheelState == 9 || this.tempAxis.keyWheelState2 == 9)
          this.tempAxis.keyValue = Input.GetAxis("STICKRVER") * gravity;
      }
      return Mathf.Clamp(this.tempAxis.keyValue, -1f, 1f);
    }

    public string GetKeyName(string keyString, int keyWheel)
    {
      switch (keyWheel)
      {
        case 0:
          if (keyString.Contains("Alpha"))
          {
            keyString = keyString.Replace("Alpha", "");
            break;
          }
          if (keyString.Contains("Keypad"))
          {
            keyString = keyString.Replace("Keypad", "Keypad ");
            break;
          }
          if (keyString.Contains("Left"))
          {
            keyString = keyString.Replace("Left", "Left ");
            break;
          }
          if (keyString.Contains("Right"))
          {
            keyString = keyString.Replace("Right", "Right ");
            break;
          }
          if (keyString.Contains("Up"))
          {
            keyString = keyString.Replace("Up", "Up ");
            break;
          }
          if (keyString.Contains("Down"))
          {
            keyString = keyString.Replace("Down", "Down ");
            break;
          }
          if (keyString.Contains("Mouse0"))
          {
            keyString = "Left Click";
            break;
          }
          if (keyString.Contains("Mouse1"))
          {
            keyString = "Right Click";
            break;
          }
          if (keyString.Contains("Mouse2"))
          {
            keyString = "Middle Click";
            break;
          }
          if (keyString.Contains("Mouse"))
          {
            keyString = "Mouse " + keyString.Replace("Mouse", "");
            break;
          }
          break;
        case 1:
          keyString = "Wheel Up";
          break;
        case 2:
          keyString = "Wheel Down";
          break;
        case 3:
          keyString = "Mouse X";
          break;
        case 4:
          keyString = "Mouse Y";
          break;
        case 5:
          if (this.controllerType == 0)
          {
            if (keyString == "Joystick1Button0")
            {
              keyString = "Cross";
              break;
            }
            if (keyString == "Joystick1Button1")
            {
              keyString = "Circle";
              break;
            }
            if (keyString == "Joystick1Button2")
            {
              keyString = "Square";
              break;
            }
            if (keyString == "Joystick1Button3")
            {
              keyString = "Triangle";
              break;
            }
            if (keyString == "Joystick1Button4")
            {
              keyString = "L1";
              break;
            }
            if (keyString == "Joystick1Button5")
            {
              keyString = "R1";
              break;
            }
            if (keyString == "Joystick1Button6")
            {
              keyString = "Share";
              break;
            }
            if (keyString == "Joystick1Button7")
            {
              keyString = "Options";
              break;
            }
            if (keyString == "Joystick1Button8")
            {
              keyString = "Left S Click";
              break;
            }
            if (keyString == "Joystick1Button9")
            {
              keyString = "Right S Click";
              break;
            }
            if (keyString == "Joystick1Button10")
            {
              keyString = "????";
              break;
            }
            if (keyString == "Joystick1Button11")
            {
              keyString = "?????";
              break;
            }
            if (keyString == "Joystick1Button12")
            {
              keyString = "PS Home";
              break;
            }
            if (keyString == "JoystickButton13")
            {
              keyString = "Trackpad";
              break;
            }
            break;
          }
          if (this.controllerType == 1)
          {
            if (keyString == "Joystick1Button0")
            {
              keyString = "Cross";
              break;
            }
            if (keyString == "Joystick1Button1")
            {
              keyString = "Circle";
              break;
            }
            if (keyString == "Joystick1Button2")
            {
              keyString = "Square";
              break;
            }
            if (keyString == "Joystick1Button3")
            {
              keyString = "Triangle";
              break;
            }
            if (keyString == "Joystick1Button4")
            {
              keyString = "L1";
              break;
            }
            if (keyString == "Joystick1Button5")
            {
              keyString = "R1";
              break;
            }
            if (keyString == "Joystick1Button6")
            {
              keyString = "Share";
              break;
            }
            if (keyString == "Joystick1Button7")
            {
              keyString = "Options";
              break;
            }
            if (keyString == "Joystick1Button8")
            {
              keyString = "Left S Click";
              break;
            }
            if (keyString == "Joystick1Button9")
            {
              keyString = "Right S Click";
              break;
            }
            if (keyString == "Joystick1Button10")
            {
              keyString = "????";
              break;
            }
            if (keyString == "Joystick1Button11")
            {
              keyString = "?????";
              break;
            }
            if (keyString == "Joystick1Button12")
            {
              keyString = "PS Home";
              break;
            }
            if (keyString == "JoystickButton13")
            {
              keyString = "Trackpad";
              break;
            }
            break;
          }
          if (this.controllerType == 2)
          {
            if (keyString == "Joystick1Button0")
            {
              keyString = "A";
              break;
            }
            if (keyString == "Joystick1Button1")
            {
              keyString = "B";
              break;
            }
            if (keyString == "Joystick1Button2")
            {
              keyString = "X";
              break;
            }
            if (keyString == "Joystick1Button3")
            {
              keyString = "Y";
              break;
            }
            if (keyString == "Joystick1Button4")
            {
              keyString = "LB";
              break;
            }
            if (keyString == "Joystick1Button5")
            {
              keyString = "RB";
              break;
            }
            if (keyString == "Joystick1Button6")
            {
              keyString = "Back";
              break;
            }
            if (keyString == "Joystick1Button7")
            {
              keyString = "Start";
              break;
            }
            if (keyString == "Joystick1Button8")
            {
              keyString = "Left S Click";
              break;
            }
            if (keyString == "Joystick1Button9")
            {
              keyString = "Right S Click";
              break;
            }
            if (keyString == "Joystick1Button10")
            {
              keyString = "LT";
              break;
            }
            if (keyString == "Joystick1Button11")
            {
              keyString = "RT";
              break;
            }
            if (keyString == "Joystick1Button12")
            {
              keyString = "Xbox Home";
              break;
            }
            break;
          }
          if (this.controllerType == 3)
          {
            if (keyString == "Joystick1Button0")
            {
              keyString = "A";
              break;
            }
            if (keyString == "Joystick1Button1")
            {
              keyString = "B";
              break;
            }
            if (keyString == "Joystick1Button2")
            {
              keyString = "X";
              break;
            }
            if (keyString == "Joystick1Button3")
            {
              keyString = "Y";
              break;
            }
            if (keyString == "Joystick1Button4")
            {
              keyString = "LB";
              break;
            }
            if (keyString == "Joystick1Button5")
            {
              keyString = "RB";
              break;
            }
            if (keyString == "Joystick1Button6")
            {
              keyString = "Back";
              break;
            }
            if (keyString == "Joystick1Button7")
            {
              keyString = "Start";
              break;
            }
            if (keyString == "Joystick1Button8")
            {
              keyString = "Left S Click";
              break;
            }
            if (keyString == "Joystick1Button9")
            {
              keyString = "Right S Click";
              break;
            }
            if (keyString == "Joystick1Button10")
            {
              keyString = "LT";
              break;
            }
            if (keyString == "Joystick1Button11")
            {
              keyString = "RT";
              break;
            }
            if (keyString == "Joystick1Button12")
            {
              keyString = "Xbox Home";
              break;
            }
            break;
          }
          break;
        case 10:
          keyString = "D-Pad Up";
          break;
        case 11:
          keyString = "D-Pad Down";
          break;
        case 12:
          keyString = "D-Pad Right";
          break;
        case 13:
          keyString = "D-Pad Left";
          break;
        case 14:
          keyString = "LT";
          break;
        case 15:
          keyString = "RT";
          break;
      }
      return keyString;
    }

    public string GetKeyName(string keyName, bool wantSecond)
    {
      this.tempKey = this.keyMaps[keyName];
      string keyString;
      int keyWheel;
      if (!wantSecond)
      {
        if (this.tempKey.keyInput == KeyCode.None && this.tempKey.keyWheelState == 0)
          return "";
        keyString = this.tempKey.keyInput.ToString();
        keyWheel = this.tempKey.keyWheelState;
      }
      else
      {
        if (this.tempKey.keyInput2 == KeyCode.None && this.tempKey.keyWheelState2 == 0)
          return "";
        keyString = this.tempKey.keyInput2.ToString();
        keyWheel = this.tempKey.keyWheelState2;
      }
      return this.GetKeyName(keyString, keyWheel);
    }

    public void MouseLock(bool lockedOrNot)
    {
      if (lockedOrNot)
        Cursor.lockState = CursorLockMode.Locked;
      else
        Cursor.lockState = CursorLockMode.None;
    }

    public void MouseVisble(bool visibleOrNot)
    {
      Cursor.visible = visibleOrNot;
    }

    public void loadBindings()
    {
      Dictionary<string, hardKey>.Enumerator enumerator1 = this.keyMaps.GetEnumerator();
      KeyValuePair<string, hardKey> current;
      while (enumerator1.MoveNext())
      {
        current = enumerator1.Current;
        if (PlayerPrefs.HasKey("settings_bindings_" + current.Value.keyName))
        {
          Dictionary<string, hardKey> keyMaps1 = this.keyMaps;
          current = enumerator1.Current;
          string keyName1 = current.Value.keyName;
          if (keyMaps1[keyName1].saveKey)
          {
            current = enumerator1.Current;
            string[] strArray = PlayerPrefs.GetString("settings_bindings_" + current.Value.keyName).Split('^');
            int num = int.Parse(strArray[1]);
            if (this.useController || !this.useController && num <= 10 && num >= 13)
            {
              Dictionary<string, hardKey> keyMaps2 = this.keyMaps;
              current = enumerator1.Current;
              string keyName2 = current.Value.keyName;
              keyMaps2[keyName2].keyInput = (KeyCode) Enum.Parse(typeof (KeyCode), strArray[0]);
              Dictionary<string, hardKey> keyMaps3 = this.keyMaps;
              current = enumerator1.Current;
              string keyName3 = current.Value.keyName;
              keyMaps3[keyName3].keyWheelState = int.Parse(strArray[1]);
            }
            else
              MonoBehaviour.print((object) (KeyCode) Enum.Parse(typeof (KeyCode), strArray[0]));
          }
        }
      }
      Dictionary<string, hardKey>.Enumerator enumerator2 = this.keyMaps.GetEnumerator();
      while (enumerator2.MoveNext())
      {
        current = enumerator2.Current;
        if (PlayerPrefs.HasKey("settings_bindings_sec_" + current.Value.keyName))
        {
          Dictionary<string, hardKey> keyMaps1 = this.keyMaps;
          current = enumerator2.Current;
          string keyName1 = current.Value.keyName;
          if (keyMaps1[keyName1].saveKey)
          {
            current = enumerator2.Current;
            string[] strArray = PlayerPrefs.GetString("settings_bindings_sec_" + current.Value.keyName).Split('^');
            int num = int.Parse(strArray[1]);
            if (this.useController || !this.useController && num <= 10 && num >= 13)
            {
              Dictionary<string, hardKey> keyMaps2 = this.keyMaps;
              current = enumerator2.Current;
              string keyName2 = current.Value.keyName;
              keyMaps2[keyName2].keyInput2 = (KeyCode) Enum.Parse(typeof (KeyCode), strArray[0]);
              Dictionary<string, hardKey> keyMaps3 = this.keyMaps;
              current = enumerator2.Current;
              string keyName3 = current.Value.keyName;
              keyMaps3[keyName3].keyWheelState2 = int.Parse(strArray[1]);
            }
          }
        }
      }
      if (PlayerPrefs.HasKey("settings_bindings_controller_type") && this.saveControllerType)
        this.controllerType = PlayerPrefs.GetInt("settings_bindings_controller_type");
      this.SaveBindings();
    }

    public void SaveBindings()
    {
      Dictionary<string, hardKey>.Enumerator enumerator1 = this.keyMaps.GetEnumerator();
      KeyValuePair<string, hardKey> current;
      while (enumerator1.MoveNext())
      {
        current = enumerator1.Current;
        string key = "settings_bindings_" + current.Value.keyName;
        current = enumerator1.Current;
        string str1 = current.Value.keyInput.ToString();
        current = enumerator1.Current;
        string str2 = current.Value.keyWheelState.ToString();
        string str3 = str1 + "^" + str2;
        PlayerPrefs.SetString(key, str3);
      }
      Dictionary<string, hardKey>.Enumerator enumerator2 = this.keyMaps.GetEnumerator();
      while (enumerator2.MoveNext())
      {
        current = enumerator2.Current;
        string key = "settings_bindings_sec_" + current.Value.keyName;
        current = enumerator2.Current;
        string str1 = current.Value.keyInput2.ToString();
        current = enumerator2.Current;
        string str2 = current.Value.keyWheelState2.ToString();
        string str3 = str1 + "^" + str2;
        PlayerPrefs.SetString(key, str3);
      }
      PlayerPrefs.Save();
    }

    public void HardStartRebind(string keyNameGET, bool wantSecond, GameObject inputFrom)
    {
      this.currentBindFrom = inputFrom;
      this.replaceSecond = wantSecond;
      this.currentRebind = keyNameGET;
      this.StartCoroutine(this.waitForKeyPress());
    }

    public void HardStartRebind(string keyNameGET, bool wantSecond, KeyCode inputFrom)
    {
      this.currentBindFrom = (GameObject) null;
      this.replaceSecond = wantSecond;
      this.currentRebind = keyNameGET;
      int keyWheelState1 = 0;
      if (inputFrom.ToString().Contains("Joystick1Button") && this.useController)
      {
        int keyWheelState2 = 5;
        this.hardRebind(this.currentRebind, inputFrom, keyWheelState2);
      }
      else
      {
        if (inputFrom.ToString().Contains("Joystick"))
          return;
        this.hardRebind(this.currentRebind, inputFrom, keyWheelState1);
      }
    }

    private IEnumerator waitForKeyPress()
    {
      yield return (object) new WaitForEndOfFrame();
      while (MyInput.GetMouseButton(0))
        yield return (object) null;
      if (!this.useController)
      {
        while (!Input.anyKeyDown && (double) Input.mouseScrollDelta.y == 0.0)
          yield return (object) null;
      }
      else
      {
        while (!Input.anyKeyDown && (double) Input.mouseScrollDelta.y == 0.0 && ((double) Input.GetAxis("DPADHOR") == 0.0 && (double) Input.GetAxis("DPADVER") == 0.0) && ((double) Input.GetAxis("Left Trigger") == 0.0 && (double) Input.GetAxis("Right Trigger") == 0.0))
          yield return (object) null;
      }
      if ((double) Input.mouseScrollDelta.y != 0.0)
      {
        if ((double) Input.mouseScrollDelta.y > 0.0)
          this.hardRebind(this.currentRebind, KeyCode.None, 1);
        else
          this.hardRebind(this.currentRebind, KeyCode.None, 2);
      }
      else if ((double) Input.GetAxis("DPADVER") != 0.0)
      {
        if ((double) Input.GetAxis("DPADVER") > 0.0)
          this.hardRebind(this.currentRebind, KeyCode.None, 10);
        else
          this.hardRebind(this.currentRebind, KeyCode.None, 11);
      }
      else if ((double) Input.GetAxis("DPADHOR") != 0.0)
      {
        if ((double) Input.GetAxis("DPADHOR") > 0.0)
          this.hardRebind(this.currentRebind, KeyCode.None, 12);
        else
          this.hardRebind(this.currentRebind, KeyCode.None, 13);
      }
      else if ((double) Input.GetAxis("Left Trigger") != 0.0)
        this.hardRebind(this.currentRebind, KeyCode.None, 14);
      else if ((double) Input.GetAxis("Right Trigger") != 0.0)
      {
        this.hardRebind(this.currentRebind, KeyCode.None, 15);
      }
      else
      {
        foreach (KeyCode keyCode in Enum.GetValues(typeof (KeyCode)))
        {
          if (Input.GetKeyDown(keyCode))
          {
            if (keyCode == KeyCode.Escape || keyCode == KeyCode.Mouse0)
            {
              if ((UnityEngine.Object) this.currentBindFrom != (UnityEngine.Object) null)
                this.currentBindFrom.SendMessage("EndBind");
            }
            else
            {
              int keyWheelState1 = 0;
              if (keyCode.ToString().Contains("Joystick1Button") && this.useController)
              {
                int keyWheelState2 = 5;
                this.hardRebind(this.currentRebind, keyCode, keyWheelState2);
              }
              else if (!keyCode.ToString().Contains("Joystick"))
                this.hardRebind(this.currentRebind, keyCode, keyWheelState1);
            }
          }
        }
      }
    }

    private void hardRebind(string rebindName, KeyCode inputKey, int keyWheelState)
    {
      if (inputKey == KeyCode.Delete || inputKey == KeyCode.Joystick1Button1)
      {
        inputKey = KeyCode.None;
        keyWheelState = 0;
      }
      if (!this.replaceSecond)
      {
        this.keyMaps[rebindName].keyInput = inputKey;
        this.keyMaps[rebindName].keyWheelState = keyWheelState;
      }
      else
      {
        this.keyMaps[rebindName].keyInput2 = inputKey;
        this.keyMaps[rebindName].keyWheelState2 = keyWheelState;
      }
      if ((UnityEngine.Object) this.currentBindFrom != (UnityEngine.Object) null)
        this.currentBindFrom.SendMessage("EndBind");
      this.SaveBindings();
    }

    public void setControllerType(hardInput.controllerType type)
    {
      switch (type)
      {
        case hardInput.controllerType.PS3:
          this.controllerType = 0;
          PlayerPrefs.SetInt("settings_bindings_controller_type", 0);
          break;
        case hardInput.controllerType.PS4:
          this.controllerType = 1;
          PlayerPrefs.SetInt("settings_bindings_controller_type", 1);
          break;
        case hardInput.controllerType.XBOX1:
          this.controllerType = 2;
          PlayerPrefs.SetInt("settings_bindings_controller_type", 2);
          break;
        case hardInput.controllerType.XBOX360:
          this.controllerType = 3;
          PlayerPrefs.SetInt("settings_bindings_controller_type", 3);
          break;
      }
      PlayerPrefs.Save();
    }

    public void resetSavedKeys()
    {
      for (int index = 0; index < this.inputs.Length; ++index)
      {
        if (PlayerPrefs.HasKey("settings_bindings_" + this.inputs[index].keyName))
          PlayerPrefs.DeleteKey("settings_bindings_" + this.inputs[index].keyName);
        if (PlayerPrefs.HasKey("settings_bindings_sec_" + this.inputs[index].keyName))
          PlayerPrefs.DeleteKey("settings_bindings_sec_" + this.inputs[index].keyName);
        this.keyMaps[this.inputs[index].keyName].keyInput = this.translateController(this.inputs[index].primaryKeycode, this.inputs[index].controllerOne, this.inputs[index].axisType);
        this.keyMaps[this.inputs[index].keyName].keyInput2 = this.translateController(this.inputs[index].secondaryKeycode, this.inputs[index].controllerTwo, this.inputs[index].axisType2);
        this.keyMaps[this.inputs[index].keyName].keyWheelState = this.getAxisFromController(this.inputs[index].controllerOne, this.inputs[index].axisType);
        this.keyMaps[this.inputs[index].keyName].keyWheelState2 = this.getAxisFromController(this.inputs[index].controllerTwo, this.inputs[index].axisType2);
      }
      if (PlayerPrefs.HasKey("settings_bindings_controller_type"))
        PlayerPrefs.DeleteKey("settings_bindings_controller_type");
      Debug.Log((object) "All bindings reset to default values. PlayerPrefs have been removed for each key.");
    }

    public void ChangeSetup(hardManager.SetupType t)
    {
      this.SaveCurrentSetup(this.setupType);
      this.LoadSetup(t);
    }

    public void SaveCurrentSetup(hardManager.SetupType t)
    {
      hardManager.SavedKeys savedKeys = new hardManager.SavedKeys()
      {
        setupType = t
      };
      Dictionary<string, hardKey>.Enumerator enumerator = this.keyMaps.GetEnumerator();
      while (enumerator.MoveNext())
      {
        if (this.keyMaps[enumerator.Current.Value.keyName].saveKey)
        {
          hardKey keyMap = this.keyMaps[enumerator.Current.Value.keyName];
          savedKeys.keys.Add(new hardManager.SavedKeys.Key()
          {
            name = enumerator.Current.Value.keyName,
            keyInput = keyMap.keyInput,
            keyInput2 = keyMap.keyInput2,
            keyWheelState = keyMap.keyWheelState,
            keyWheelState2 = keyMap.keyWheelState2
          });
        }
      }
      File.WriteAllText(SaveFolder.persistentDataPath + Path.DirectorySeparatorChar.ToString() + t.ToString() + "layout.json", JsonConvert.SerializeObject((object) savedKeys));
    }

    public static bool IsUsingController()
    {
      return hardManager.singleton.setupType == hardManager.SetupType.Controller;
    }

    public static string GetAxisCameraX()
    {
      return !hardManager.IsUsingController() ? "Horizontal" : "Right Stick Horizontal";
    }

    public static string GetAxisCameraY()
    {
      return !hardManager.IsUsingController() ? "Vertical" : "Right Stick Vertical";
    }

    public static bool HasController()
    {
      return (uint) Input.GetJoystickNames().Length > 0U;
    }

    public void LoadSetup(hardManager.SetupType t)
    {
      if (!File.Exists(SaveFolder.persistentDataPath + Path.DirectorySeparatorChar.ToString() + t.ToString() + "layout.json"))
      {
        this.setupType = t;
        if (t == hardManager.SetupType.Keyboard)
        {
          this.resetSavedKeys();
        }
        else
        {
          for (int index = 0; index < this.inputs.Length; ++index)
          {
            try
            {
              hardKey keyMap = this.keyMaps[this.inputs[index].keyName];
              hardManager.givenInputs input = Controller.Instance.keysController.inputs[index];
              keyMap.keyInput = Controller.Instance.keysController.translateController(input.primaryKeycode, input.controllerOne, input.axisType);
              keyMap.keyInput2 = Controller.Instance.keysController.translateController(input.secondaryKeycode, input.controllerTwo, input.axisType2);
              keyMap.keyWheelState = Controller.Instance.keysController.getAxisFromController(input.controllerOne, input.axisType);
              keyMap.keyWheelState2 = Controller.Instance.keysController.getAxisFromController(input.controllerTwo, input.axisType2);
            }
            catch (Exception ex)
            {
            }
          }
        }
      }
      else
      {
        hardManager.SavedKeys savedKeys = JsonConvert.DeserializeObject<hardManager.SavedKeys>(File.ReadAllText(SaveFolder.persistentDataPath + Path.DirectorySeparatorChar.ToString() + t.ToString() + "layout.json"));
        this.setupType = savedKeys.setupType;
        foreach (hardManager.SavedKeys.Key key in savedKeys.keys)
        {
          hardKey hardKey;
          if (this.keyMaps.TryGetValue(key.name, out hardKey))
          {
            hardKey.keyInput = key.keyInput;
            hardKey.keyInput2 = key.keyInput2;
            hardKey.keyWheelState = key.keyWheelState;
            hardKey.keyWheelState2 = key.keyWheelState2;
          }
        }
      }
    }

    public void resetKey(string name)
    {
      for (int index = 0; index < this.inputs.Length; ++index)
      {
        if (this.inputs[index].keyName.Equals(name))
        {
          if (PlayerPrefs.HasKey("settings_bindings_" + this.inputs[index].keyName))
            PlayerPrefs.DeleteKey("settings_bindings_" + this.inputs[index].keyName);
          if (PlayerPrefs.HasKey("settings_bindings_sec_" + this.inputs[index].keyName))
            PlayerPrefs.DeleteKey("settings_bindings_sec_" + this.inputs[index].keyName);
          this.keyMaps[this.inputs[index].keyName].keyInput = this.translateController(this.inputs[index].primaryKeycode, this.inputs[index].controllerOne, this.inputs[index].axisType);
          this.keyMaps[this.inputs[index].keyName].keyInput2 = this.translateController(this.inputs[index].secondaryKeycode, this.inputs[index].controllerTwo, this.inputs[index].axisType2);
          this.keyMaps[this.inputs[index].keyName].keyWheelState = this.getAxisFromController(this.inputs[index].controllerOne, this.inputs[index].axisType);
          this.keyMaps[this.inputs[index].keyName].keyWheelState2 = this.getAxisFromController(this.inputs[index].controllerTwo, this.inputs[index].axisType2);
          break;
        }
      }
      Debug.Log((object) ("The binding '" + name + "' has been reset to the fault value"));
    }

    public KeyCode GetKeyCode(string keyName, bool wantSecond)
    {
      try
      {
        return !wantSecond ? this.keyMaps[keyName].keyInput : this.keyMaps[keyName].keyInput2;
      }
      catch
      {
        Debug.LogWarning((object) ("Failed to 'GetKeyCode' for key: " + keyName));
        return KeyCode.None;
      }
    }

    [Serializable]
    public struct givenInputs
    {
      public string keyName;
      public KeyCode primaryKeycode;
      public KeyCode secondaryKeycode;
      public int axisType;
      public int axisType2;
      public hardKey.controllerMap controllerOne;
      public hardKey.controllerMap controllerTwo;
      public bool saveKey;
    }

    [Serializable]
    public class SavedKeys
    {
      public List<hardManager.SavedKeys.Key> keys = new List<hardManager.SavedKeys.Key>();
      public hardManager.SetupType setupType;

      [Serializable]
      public class Key
      {
        public string name;
        public KeyCode keyInput;
        public KeyCode keyInput2;
        public int keyWheelState;
        public int keyWheelState2;
      }
    }

    [Serializable]
    public enum SetupType
    {
      Keyboard,
      Controller,
    }
  }
}
