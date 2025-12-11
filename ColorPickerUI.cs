
using System;
using UnityEngine;
using UnityEngine.Events;

public class ColorPickerUI : MonoBehaviour
{
  public ColorPicker picker;
  public GameObject but_onRemove;
  private Action<Color> onEnd;
  private Action onRemove;
  private Color start;

  public static ColorPickerUI Instance { get; private set; }

  public static ColorPickerUI Create(
    Color c,
    Action<Color> onEnd,
    Action<Color> onChange,
    Action onRemove = null)
  {
    if ((UnityEngine.Object) ColorPickerUI.Instance != (UnityEngine.Object) null)
      return ColorPickerUI.Instance;
    ColorPickerUI.Instance = Controller.Instance.CreateAndApply<ColorPickerUI>(Controller.Instance.colorPickerUI, Controller.Instance.transform);
    ColorPickerUI.Instance.picker.CurrentColor = c;
    ColorPickerUI.Instance.onEnd = onEnd;
    ColorPickerUI.Instance.start = c;
    ColorPickerUI.Instance.onRemove = onRemove;
    ColorPickerUI.Instance.but_onRemove.SetActive(onRemove != null);
    if (onChange != null)
      ColorPickerUI.Instance.picker.onValueChangedPUBLIC.AddListener((UnityAction<Color>) (col =>
      {
        Action<Color> action = onChange;
        if (action == null)
          return;
        action(col);
      }));
    return ColorPickerUI.Instance;
  }

  public void ClickRemove()
  {
    Action onRemove = this.onRemove;
    if (onRemove != null)
      onRemove();
    UnityEngine.Object.Destroy((UnityEngine.Object) this.gameObject);
  }

  public void ClickOk()
  {
    Action<Color> onEnd = this.onEnd;
    if (onEnd != null)
      onEnd(this.picker.CurrentColor);
    UnityEngine.Object.Destroy((UnityEngine.Object) this.gameObject);
  }

  public void ClickCancel()
  {
    Action<Color> onEnd = this.onEnd;
    if (onEnd != null)
      onEnd(this.start);
    UnityEngine.Object.Destroy((UnityEngine.Object) this.gameObject);
  }

  private void Update()
  {
    if (!((UnityEngine.Object) this.transform.parent.GetChild(this.transform.parent.childCount - 1) != (UnityEngine.Object) this.transform))
      return;
    this.ClickCancel();
  }

  private void OnDestroy()
  {
    if (!((UnityEngine.Object) ColorPickerUI.Instance == (UnityEngine.Object) this))
      return;
    ColorPickerUI.Instance = (ColorPickerUI) null;
  }
}
