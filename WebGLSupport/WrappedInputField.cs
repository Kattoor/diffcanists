
using UnityEngine;
using UnityEngine.UI;
using WebGLSupport.Detail;

namespace WebGLSupport
{
  internal class WrappedInputField : IInputField
  {
    private InputField input;
    private RebuildChecker checker;

    public bool ReadOnly
    {
      get
      {
        return this.input.readOnly;
      }
    }

    public string text
    {
      get
      {
        return this.input.text;
      }
      set
      {
        this.input.text = value;
      }
    }

    public string placeholder
    {
      get
      {
        if (!(bool) (Object) this.input.placeholder)
          return "";
        Text component = this.input.placeholder.GetComponent<Text>();
        return !(bool) (Object) component ? "" : component.text;
      }
    }

    public int fontSize
    {
      get
      {
        return this.input.textComponent.fontSize;
      }
    }

    public ContentType contentType
    {
      get
      {
        return (ContentType) this.input.contentType;
      }
    }

    public LineType lineType
    {
      get
      {
        return (LineType) this.input.lineType;
      }
    }

    public int characterLimit
    {
      get
      {
        return this.input.characterLimit;
      }
    }

    public int caretPosition
    {
      get
      {
        return this.input.caretPosition;
      }
    }

    public bool isFocused
    {
      get
      {
        return this.input.isFocused;
      }
    }

    public int selectionFocusPosition
    {
      get
      {
        return this.input.selectionFocusPosition;
      }
      set
      {
        this.input.selectionFocusPosition = value;
      }
    }

    public int selectionAnchorPosition
    {
      get
      {
        return this.input.selectionAnchorPosition;
      }
      set
      {
        this.input.selectionAnchorPosition = value;
      }
    }

    public bool OnFocusSelectAll
    {
      get
      {
        return true;
      }
    }

    public WrappedInputField(InputField input)
    {
      this.input = input;
      this.checker = new RebuildChecker((IInputField) this);
    }

    public UnityEngine.RectTransform RectTransform()
    {
      return this.input.GetComponent<UnityEngine.RectTransform>();
    }

    public void ActivateInputField()
    {
      this.input.ActivateInputField();
    }

    public void DeactivateInputField()
    {
      this.input.DeactivateInputField();
    }

    public void Rebuild()
    {
      if (!this.checker.NeedRebuild(false))
        return;
      this.input.textComponent.SetAllDirty();
      this.input.Rebuild(CanvasUpdate.LatePreRender);
    }
  }
}
