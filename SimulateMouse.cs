
using System.Runtime.InteropServices;
using UnityEngine.InputSystem.LowLevel;

public static class SimulateMouse
{
  private static bool[] _isdown = new bool[5];
  private const int MOUSEEVENTF_LEFTDOWN = 2;
  private const int MOUSEEVENTF_LEFTUP = 4;
  private const int MOUSEEVENTF_RIGHTDOWN = 8;
  private const int MOUSEEVENTF_RIGHTUP = 16;
  private const int MOUSEEVENTF_MIDDLEDOWN = 32;
  private const int MOUSEEVENTF_MIDDLEUP = 64;

  public static bool isMouseDown(MouseButton button)
  {
    return SimulateMouse._isdown[(int) button];
  }

  private static void SetIsDown(MouseButton b, bool v)
  {
    SimulateMouse._isdown[(int) b] = v;
  }

  public static void OnApplicationFocus(bool v)
  {
    for (int index = 0; index < 3; ++index)
    {
      if (SimulateMouse.isMouseDown((MouseButton) index))
        SimulateMouse.Release((MouseButton) index);
    }
  }

  [DllImport("user32.dll")]
  private static extern void mouse_event(
    int dwFlags,
    int dx,
    int dy,
    int cButtons,
    int dwExtraInfo);

  public static void Click(MouseButton button)
  {
    int num1 = 2;
    int num2 = 4;
    switch (button)
    {
      case MouseButton.Right:
        num1 = 8;
        num2 = 16;
        break;
      case MouseButton.Middle:
        num1 = 32;
        num2 = 64;
        break;
    }
    SimulateMouse.mouse_event(num1 | num2, 0, 0, 0, 0);
  }

  public static void Press(MouseButton button)
  {
    if (SimulateMouse.isMouseDown(button))
      SimulateMouse.Release(button);
    SimulateMouse.SetIsDown(button, true);
    int dwFlags = 2;
    switch (button)
    {
      case MouseButton.Right:
        dwFlags = 8;
        break;
      case MouseButton.Middle:
        dwFlags = 32;
        break;
    }
    SimulateMouse.mouse_event(dwFlags, 0, 0, 0, 0);
  }

  public static void Release(MouseButton button)
  {
    SimulateMouse.SetIsDown(button, false);
    int dwFlags = 4;
    switch (button)
    {
      case MouseButton.Right:
        dwFlags = 16;
        break;
      case MouseButton.Middle:
        dwFlags = 64;
        break;
    }
    SimulateMouse.mouse_event(dwFlags, 0, 0, 0, 0);
  }
}
