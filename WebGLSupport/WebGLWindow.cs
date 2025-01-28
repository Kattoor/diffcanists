
using AOT;
using System;

namespace WebGLSupport
{
  public static class WebGLWindow
  {
    private static string ViewportContent;

    public static bool Focus { get; private set; }

    public static event Action OnFocusEvent = () => {};

    public static event Action OnBlurEvent = () => {};

    public static event Action OnResizeEvent = () => {};

    private static void Init()
    {
      WebGLWindow.Focus = true;
      WebGLWindowPlugin.WebGLWindowOnFocus(new Action(WebGLWindow.OnWindowFocus));
      WebGLWindowPlugin.WebGLWindowOnBlur(new Action(WebGLWindow.OnWindowBlur));
      WebGLWindowPlugin.WebGLWindowOnResize(new Action(WebGLWindow.OnWindowResize));
      WebGLWindowPlugin.WebGLWindowInjectFullscreen();
    }

    [MonoPInvokeCallback(typeof (Action))]
    private static void OnWindowFocus()
    {
      WebGLWindow.Focus = true;
      WebGLWindow.OnFocusEvent();
    }

    [MonoPInvokeCallback(typeof (Action))]
    private static void OnWindowBlur()
    {
      WebGLWindow.Focus = false;
      WebGLWindow.OnBlurEvent();
    }

    [MonoPInvokeCallback(typeof (Action))]
    private static void OnWindowResize()
    {
      WebGLWindow.OnResizeEvent();
    }

    [UnityEngine.RuntimeInitializeOnLoadMethod]
    private static void RuntimeInitializeOnLoadMethod()
    {
      WebGLWindow.Init();
    }
  }
}
