
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof (Slider))]
public class ColorSlider : MonoBehaviour
{
  public ColorPicker hsvpicker;
  public ColorValues type;
  private Slider slider;

  private void Awake()
  {
    this.slider = this.GetComponent<Slider>();
    this.hsvpicker.onValueChanged.AddListener(new UnityAction<Color>(this.ColorChanged));
    this.hsvpicker.onHSVChanged.AddListener(new UnityAction<float, float, float>(this.HSVChanged));
    this.slider.onValueChanged.AddListener(new UnityAction<float>(this.SliderChanged));
  }

  private void OnDestroy()
  {
    this.hsvpicker.onValueChanged.RemoveListener(new UnityAction<Color>(this.ColorChanged));
    this.hsvpicker.onHSVChanged.RemoveListener(new UnityAction<float, float, float>(this.HSVChanged));
    this.slider.onValueChanged.RemoveListener(new UnityAction<float>(this.SliderChanged));
  }

  private void ColorChanged(Color newColor)
  {
    switch (this.type)
    {
      case ColorValues.R:
        this.slider.SetValueWithoutNotify(newColor.r);
        break;
      case ColorValues.G:
        this.slider.SetValueWithoutNotify(newColor.g);
        break;
      case ColorValues.B:
        this.slider.SetValueWithoutNotify(newColor.b);
        break;
      case ColorValues.A:
        this.slider.SetValueWithoutNotify(newColor.a);
        break;
    }
  }

  private void HSVChanged(float hue, float saturation, float value)
  {
    switch (this.type)
    {
      case ColorValues.Hue:
        this.slider.SetValueWithoutNotify(hue);
        break;
      case ColorValues.Saturation:
        this.slider.SetValueWithoutNotify(saturation);
        break;
      case ColorValues.Value:
        this.slider.SetValueWithoutNotify(value);
        break;
    }
  }

  private void SliderChanged(float newValue)
  {
    newValue = this.slider.normalizedValue;
    this.hsvpicker.AssignColor(this.type, newValue);
  }
}
