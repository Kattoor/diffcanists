
using HardShellStudios.InputManager;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public static class MyInput
{
  public static float cameraSpeed = 1f;
  public static float mouseSpeed = 1f;
  private static (KeyCode key, MouseButton button)[] MouseKeys = new (KeyCode, MouseButton)[2]
  {
    (KeyCode.Joystick1Button0, MouseButton.Left),
    (KeyCode.Joystick1Button1, MouseButton.Right)
  };
  public const string prefCameraSpeed = "prefcameraspeed";
  public const string prefMouseSpeed = "prefmousespeed";

  public static void SetCameraSpeed(float f)
  {
    PlayerPrefs.SetFloat("prefcameraspeed", f);
    MyInput.cameraSpeed = f;
  }

  public static void SetMouseSpeed(float f)
  {
    PlayerPrefs.SetFloat("prefmousespeed", f);
    MyInput.mouseSpeed = f;
  }

  public static void InitVariables()
  {
    MyInput.cameraSpeed = PlayerPrefs.GetFloat("prefcameraspeed", 0.5f);
    MyInput.mouseSpeed = PlayerPrefs.GetFloat("prefmousespeed", 0.5f);
    int num = PlayerPrefs.GetInt("prefusecontroller", 0);
    if (num == 0 || num == 1)
    {
      if (num == 1)
      {
        Controller.Instance.keysKeyboard.ChangeSetup(hardManager.SetupType.Controller);
        if (num != 0)
          return;
        PlayerPrefs.SetInt("prefusecontroller", 1);
      }
      else
        PlayerPrefs.SetInt("prefusecontroller", 2);
    }
    else
    {
      if (num != 0)
        return;
      PlayerPrefs.SetInt("prefusecontroller", 2);
    }
  }

  public static bool GetMouseButtonDown(int w)
  {
    return Input.GetMouseButtonDown(w);
  }

  public static bool GetMouseButtonUp(int w)
  {
    return Input.GetMouseButtonUp(w);
  }

  public static bool GetMouseButton(int w)
  {
    return Input.GetMouseButton(w);
  }

  public static void LoopControllerMouseEvents()
  {
    for (int index = 0; index < MyInput.MouseKeys.Length; ++index)
    {
      if (Input.GetKeyDown(MyInput.MouseKeys[index].key))
        SimulateMouse.Press(MyInput.MouseKeys[index].button);
      if (Input.GetKeyUp(MyInput.MouseKeys[index].key))
        SimulateMouse.Release(MyInput.MouseKeys[index].button);
    }
  }
}
