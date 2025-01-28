
using MoonSharp.Interpreter;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Educative
{
  public class UIElement
  {
    private object _graphic = (object) 0;
    private Anchor _anchor = Anchor.MiddleCenter;
    public bool clickDestroy = true;
    public UIElement parent;
    [MoonSharpHidden]
    public LuaPanel container;
    [MoonSharpHidden]
    public Script script;
    private string _onClick;
    public object clickID;

    public bool isDead
    {
      get
      {
        return (Object) this.container == (Object) null;
      }
    }

    public object graphic
    {
      get
      {
        return this._graphic;
      }
      set
      {
        this.SetGraphic(value);
      }
    }

    public Anchor anchor
    {
      get
      {
        return this._anchor;
      }
      set
      {
        this._anchor = value;
        this.container.rectTransform.SetAnchor(this._anchor);
      }
    }

    public double width
    {
      get
      {
        return (double) this.container.rectTransform.sizeDelta.x;
      }
      set
      {
        this.container.rectTransform.sizeDelta = new Vector2((float) value, this.container.rectTransform.sizeDelta.y);
      }
    }

    public double height
    {
      get
      {
        return (double) this.container.rectTransform.sizeDelta.y;
      }
      set
      {
        this.container.rectTransform.sizeDelta = new Vector2(this.container.rectTransform.sizeDelta.x, (float) value);
      }
    }

    public Point size
    {
      get
      {
        return new Point((double) this.container.rectTransform.sizeDelta.x, (double) this.container.rectTransform.sizeDelta.y);
      }
      set
      {
        this.container.rectTransform.sizeDelta = new Vector2((float) value.x, (float) value.y);
      }
    }

    public double x
    {
      get
      {
        return (double) this.container.rectTransform.anchoredPosition.x;
      }
      set
      {
        this.container.rectTransform.anchoredPosition = new Vector2((float) value, this.container.rectTransform.anchoredPosition.y);
      }
    }

    public double y
    {
      get
      {
        return (double) this.container.rectTransform.anchoredPosition.y;
      }
      set
      {
        this.container.rectTransform.anchoredPosition = new Vector2(this.container.rectTransform.anchoredPosition.x, (float) value);
      }
    }

    public Point position
    {
      get
      {
        return new Point((double) this.container.rectTransform.anchoredPosition.x, (double) this.container.rectTransform.anchoredPosition.y);
      }
      set
      {
        this.container.rectTransform.anchoredPosition = new Vector2((float) value.x, (float) value.y);
      }
    }

    public double pivot_x
    {
      get
      {
        return (double) this.container.rectTransform.pivot.x;
      }
      set
      {
        this.container.rectTransform.pivot = new Vector2((float) value, this.container.rectTransform.pivot.y);
      }
    }

    public double pivot_y
    {
      get
      {
        return (double) this.container.rectTransform.pivot.y;
      }
      set
      {
        this.container.rectTransform.pivot = new Vector2(this.container.rectTransform.pivot.x, (float) value);
      }
    }

    public Point pivot
    {
      get
      {
        return new Point((double) this.container.rectTransform.pivot.x, (double) this.container.rectTransform.pivot.y);
      }
      set
      {
        this.container.rectTransform.pivot = new Vector2((float) value.x, (float) value.y);
      }
    }

    public double angle
    {
      get
      {
        return (double) this.container.rectTransform.localEulerAngles.z;
      }
      set
      {
        this.container.rectTransform.localEulerAngles = new Vector3(0.0f, 0.0f, (float) value);
      }
    }

    public string onClick
    {
      get
      {
        return this._onClick;
      }
      set
      {
        this.SetCallback(value);
      }
    }

    public string color
    {
      get
      {
        return "#" + ColorUtility.ToHtmlStringRGBA(this.container.image.color);
      }
      set
      {
        Color color = Color.white;
        ColorUtility.TryParseHtmlString(value, out color);
        this.container.image.color = color;
        this.container.button.StopAllCoroutines();
        this.container.button.NormalColor = color;
      }
    }

    public string text
    {
      get
      {
        return this.container.input?.text ?? this.container.text.text ?? "";
      }
      set
      {
        if ((Object) this.container.input != (Object) null)
          this.container.input.text = value;
        else
          this.container.text.text = value;
      }
    }

    public string textColor
    {
      get
      {
        return "#" + ColorUtility.ToHtmlStringRGBA(this.container.text.color);
      }
      set
      {
        Color color = Color.white;
        ColorUtility.TryParseHtmlString(value, out color);
        this.container.text.color = color;
      }
    }

    public int textStyle
    {
      get
      {
        return (int) this.container.text.fontStyle;
      }
      set
      {
        this.container.text.fontStyle = (FontStyles) value;
      }
    }

    public double textSize
    {
      get
      {
        return (double) this.container.text.fontSize;
      }
      set
      {
        this.container.text.fontSize = (float) value;
      }
    }

    public void activateInput()
    {
      if (!((Object) this.container.input != (Object) null))
        return;
      this.container.input.Select();
    }

    private void SetGraphic(object graphic)
    {
      if (graphic.GetType() == typeof (double))
      {
        int index = Mathf.Clamp((int) (double) graphic, 0, ClientResources.Instance.luaGraphic.Length - 1);
        this.container.image.sprite = ClientResources.Instance.luaGraphic[index];
        this._graphic = (object) index;
      }
      else
      {
        Sprite sprite;
        if (!(graphic.GetType() == typeof (string)) || !ClientResources.Instance.icons.TryGetValue((string) graphic, out sprite))
          return;
        this.container.image.sprite = sprite;
        this._graphic = graphic;
      }
    }

    private void SetCallback(string s)
    {
      this._onClick = s;
      if ((Object) this.container.input != (Object) null)
        return;
      this.container.button.onClick.RemoveAllListeners();
      if (!string.IsNullOrWhiteSpace(s))
      {
        Color color1 = this.container.image.color;
        this.container.button.onClick.AddListener(new UnityAction(this.OnClick));
        Color color2 = ColorHSV.LowerHigher(color1, 0.4f);
        this.container.button.HighlightedColor = color2;
        this.container.button.PressedColor = color2;
        this.container.image.raycastTarget = true;
        this.container.button.enabled = true;
      }
      else
      {
        this.container.button.enabled = false;
        this.container.image.raycastTarget = false;
      }
    }

    private void OnClick()
    {
      if (!string.IsNullOrEmpty(this._onClick))
        this.script.Call(this.script.Globals.Get(this._onClick), this.clickID, (object) this);
      if (!this.clickDestroy)
        return;
      this.destroyHierarchy();
    }

    private void OnInputEnd(string s)
    {
      if (!string.IsNullOrEmpty(this._onClick))
        this.script.Call(this.script.Globals.Get(this._onClick), (object) s, (object) this);
      if (!this.clickDestroy)
        return;
      this.destroyHierarchy();
    }

    public static UIElement createUI(Script script, UIElement parent = null)
    {
      return new UIElement()
      {
        script = script,
        parent = parent == null || !((Object) parent.container != (Object) null) ? (UIElement) null : parent,
        container = Object.Instantiate<LuaPanel>(ClientResources.Instance.luaPanel, parent == null || !((Object) parent.container != (Object) null) ? (Transform) HUD.instance.luaContainer : (Transform) parent.container.rectTransform)
      };
    }

    public static UIElement createInput(
      Script script,
      UIElement parent = null,
      string callback = null,
      bool onSubmit = true,
      bool active = true,
      bool forceFocus = true)
    {
      UIElement uiElement = new UIElement();
      uiElement.script = script;
      uiElement.parent = parent == null || !((Object) parent.container != (Object) null) ? (UIElement) null : parent;
      RectTransform rectTransform = parent == null || !((Object) parent.container != (Object) null) ? HUD.instance.luaContainer : parent.container.rectTransform;
      uiElement.container = Object.Instantiate<LuaPanel>(ClientResources.Instance.luaPanel, (Transform) rectTransform);
      uiElement.width = 260.0;
      uiElement.height = 40.0;
      uiElement.container.input = Object.Instantiate<TMP_InputField>(ClientResources.Instance.luaInput, uiElement.container.transform);
      uiElement.container.text = uiElement.container.input.textComponent;
      uiElement._onClick = callback;
      if (onSubmit)
        uiElement.container.input.onSubmit.AddListener(new UnityAction<string>(uiElement.OnInputEnd));
      else
        uiElement.container.input.onEndEdit.AddListener(new UnityAction<string>(uiElement.OnInputEnd));
      if (active)
        uiElement.activateInput();
      if (!forceFocus)
        uiElement.container.input.GetComponent<ForceInput>().enabled = false;
      return uiElement;
    }

    public UIElement duplicate(Script script, UIElement parent = null)
    {
      return new UIElement()
      {
        script = script,
        parent = parent == null || !((Object) parent.container != (Object) null) ? (UIElement) null : parent,
        container = Object.Instantiate<LuaPanel>(this.container, parent == null || !((Object) parent.container != (Object) null) ? (Transform) HUD.instance.luaContainer : (Transform) parent.container.rectTransform)
      };
    }

    public void destroyHierarchy()
    {
      if ((Object) this.container == (Object) null)
        return;
      UIElement parent = this.parent;
      while (parent != null && (Object) parent.container != (Object) null && (parent.parent != null && (Object) parent.parent.container != (Object) null))
        parent = parent.parent;
      if ((Object) parent?.container == (Object) null)
        this.destroy();
      else
        parent.destroy();
    }

    public void destroy()
    {
      if (!((Object) this.container != (Object) null))
        return;
      Object.Destroy((Object) this.container.gameObject);
      this.container = (LuaPanel) null;
    }
  }
}
