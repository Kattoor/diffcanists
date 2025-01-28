
using System;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
  private float _alpha = 1f;
  public ColorChangedEvent onValueChangedPUBLIC = new ColorChangedEvent();
  public ColorChangedEvent onValueChanged = new ColorChangedEvent();
  public HSVChangedEvent onHSVChanged = new HSVChangedEvent();
  private float _hue;
  private float _saturation;
  private float _brightness;
  private float _red;
  private float _green;
  private float _blue;

  public Color CurrentColor
  {
    get
    {
      return new Color(this._red, this._green, this._blue, this._alpha);
    }
    set
    {
      if (this.CurrentColor == value)
        return;
      this._red = value.r;
      this._green = value.g;
      this._blue = value.b;
      this._alpha = value.a;
      this.RGBChanged();
      this.SendChangedEvent();
    }
  }

  public Color CurrentColorNoNotify
  {
    set
    {
      if (this.CurrentColor == value)
        return;
      this._red = value.r;
      this._green = value.g;
      this._blue = value.b;
      this._alpha = value.a;
      this.RGBChanged();
      this.SendChangedEventNoNotify();
    }
  }

  private void Start()
  {
    this.SendChangedEventNoNotify();
  }

  public float H
  {
    get
    {
      return this._hue;
    }
    set
    {
      if ((double) this._hue == (double) value)
        return;
      this._hue = value;
      this.HSVChanged();
      this.SendChangedEvent();
    }
  }

  public float S
  {
    get
    {
      return this._saturation;
    }
    set
    {
      if ((double) this._saturation == (double) value)
        return;
      this._saturation = value;
      this.HSVChanged();
      this.SendChangedEvent();
    }
  }

  public float V
  {
    get
    {
      return this._brightness;
    }
    set
    {
      if ((double) this._brightness == (double) value)
        return;
      this._brightness = value;
      this.HSVChanged();
      this.SendChangedEvent();
    }
  }

  public float R
  {
    get
    {
      return this._red;
    }
    set
    {
      if ((double) this._red == (double) value)
        return;
      this._red = value;
      this.RGBChanged();
      this.SendChangedEvent();
    }
  }

  public float G
  {
    get
    {
      return this._green;
    }
    set
    {
      if ((double) this._green == (double) value)
        return;
      this._green = value;
      this.RGBChanged();
      this.SendChangedEvent();
    }
  }

  public float B
  {
    get
    {
      return this._blue;
    }
    set
    {
      if ((double) this._blue == (double) value)
        return;
      this._blue = value;
      this.RGBChanged();
      this.SendChangedEvent();
    }
  }

  private float A
  {
    get
    {
      return this._alpha;
    }
    set
    {
      if ((double) this._alpha == (double) value)
        return;
      this._alpha = value;
      this.SendChangedEvent();
    }
  }

  private void RGBChanged()
  {
    HsvColor hsv = HSVUtil.ConvertRgbToHsv(this.CurrentColor);
    this._hue = hsv.normalizedH;
    this._saturation = hsv.normalizedS;
    this._brightness = hsv.normalizedV;
  }

  private void HSVChanged()
  {
    Color rgb = HSVUtil.ConvertHsvToRgb((double) this._hue * 360.0, (double) this._saturation, (double) this._brightness, this._alpha);
    this._red = rgb.r;
    this._green = rgb.g;
    this._blue = rgb.b;
  }

  private void SendChangedEvent()
  {
    this.onValueChanged.Invoke(this.CurrentColor);
    this.onValueChangedPUBLIC.Invoke(this.CurrentColor);
    this.onHSVChanged.Invoke(this._hue, this._saturation, this._brightness);
  }

  private void SendChangedEventNoNotify()
  {
    this.onValueChanged.Invoke(this.CurrentColor);
    this.onHSVChanged.Invoke(this._hue, this._saturation, this._brightness);
  }

  public void AssignColor(ColorValues type, float value)
  {
    switch (type)
    {
      case ColorValues.R:
        this.R = value;
        break;
      case ColorValues.G:
        this.G = value;
        break;
      case ColorValues.B:
        this.B = value;
        break;
      case ColorValues.A:
        this.A = value;
        break;
      case ColorValues.Hue:
        this.H = value;
        break;
      case ColorValues.Saturation:
        this.S = value;
        break;
      case ColorValues.Value:
        this.V = value;
        break;
    }
  }

  public float GetValue(ColorValues type)
  {
    switch (type)
    {
      case ColorValues.R:
        return this.R;
      case ColorValues.G:
        return this.G;
      case ColorValues.B:
        return this.B;
      case ColorValues.A:
        return this.A;
      case ColorValues.Hue:
        return this.H;
      case ColorValues.Saturation:
        return this.S;
      case ColorValues.Value:
        return this.V;
      default:
        throw new NotImplementedException("");
    }
  }
}
