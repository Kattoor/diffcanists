
using System.Globalization;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof (TMP_InputField))]
public class HexColorField : MonoBehaviour
{
  public ColorPicker hsvpicker;
  public bool displayAlpha;
  private TMP_InputField hexInputField;
  private const string hexRegex = "^#?(?:[0-9a-fA-F]{3,4}){1,2}$";

  private void Awake()
  {
    this.hexInputField = this.GetComponent<TMP_InputField>();
    this.hexInputField.onEndEdit.AddListener(new UnityAction<string>(this.UpdateColor));
    this.hsvpicker.onValueChanged.AddListener(new UnityAction<Color>(this.UpdateHex));
  }

  private void OnDestroy()
  {
    this.hexInputField.onValueChanged.RemoveListener(new UnityAction<string>(this.UpdateColor));
    this.hsvpicker.onValueChanged.RemoveListener(new UnityAction<Color>(this.UpdateHex));
  }

  private void UpdateHex(Color newColor)
  {
    this.hexInputField.text = this.ColorToHex((Color32) newColor);
  }

  private void UpdateColor(string newHex)
  {
    Color32 color;
    if (HexColorField.HexToColor(newHex, out color))
      this.hsvpicker.CurrentColor = (Color) color;
    else
      Debug.Log((object) "hex value is in the wrong format, valid formats are: #RGB, #RGBA, #RRGGBB and #RRGGBBAA (# is optional)");
  }

  private string ColorToHex(Color32 color)
  {
    if (!this.displayAlpha)
      return string.Format("#{0:X2}{1:X2}{2:X2}", (object) color.r, (object) color.g, (object) color.b);
    return string.Format("#{0:X2}{1:X2}{2:X2}{3:X2}", (object) color.r, (object) color.g, (object) color.b, (object) color.a);
  }

  public static bool HexToColor(string hex, out Color32 color)
  {
    if (Regex.IsMatch(hex, "^#?(?:[0-9a-fA-F]{3,4}){1,2}$"))
    {
      int startIndex = hex.StartsWith("#") ? 1 : 0;
      if (hex.Length == startIndex + 8)
        color = new Color32(byte.Parse(hex.Substring(startIndex, 2), NumberStyles.AllowHexSpecifier), byte.Parse(hex.Substring(startIndex + 2, 2), NumberStyles.AllowHexSpecifier), byte.Parse(hex.Substring(startIndex + 4, 2), NumberStyles.AllowHexSpecifier), byte.Parse(hex.Substring(startIndex + 6, 2), NumberStyles.AllowHexSpecifier));
      else if (hex.Length == startIndex + 6)
        color = new Color32(byte.Parse(hex.Substring(startIndex, 2), NumberStyles.AllowHexSpecifier), byte.Parse(hex.Substring(startIndex + 2, 2), NumberStyles.AllowHexSpecifier), byte.Parse(hex.Substring(startIndex + 4, 2), NumberStyles.AllowHexSpecifier), byte.MaxValue);
      else if (hex.Length == startIndex + 4)
      {
        ref Color32 local = ref color;
        string str1 = hex[startIndex].ToString();
        char ch = hex[startIndex];
        string str2 = ch.ToString();
        int num1 = (int) byte.Parse(str1 + str2, NumberStyles.AllowHexSpecifier);
        ch = hex[startIndex + 1];
        string str3 = ch.ToString();
        ch = hex[startIndex + 1];
        string str4 = ch.ToString();
        int num2 = (int) byte.Parse(str3 + str4, NumberStyles.AllowHexSpecifier);
        ch = hex[startIndex + 2];
        string str5 = ch.ToString();
        ch = hex[startIndex + 2];
        string str6 = ch.ToString();
        int num3 = (int) byte.Parse(str5 + str6, NumberStyles.AllowHexSpecifier);
        ch = hex[startIndex + 3];
        string str7 = ch.ToString();
        ch = hex[startIndex + 3];
        string str8 = ch.ToString();
        int num4 = (int) byte.Parse(str7 + str8, NumberStyles.AllowHexSpecifier);
        Color32 color32 = new Color32((byte) num1, (byte) num2, (byte) num3, (byte) num4);
        local = color32;
      }
      else
      {
        ref Color32 local = ref color;
        string str1 = hex[startIndex].ToString();
        char ch = hex[startIndex];
        string str2 = ch.ToString();
        int num1 = (int) byte.Parse(str1 + str2, NumberStyles.AllowHexSpecifier);
        ch = hex[startIndex + 1];
        string str3 = ch.ToString();
        ch = hex[startIndex + 1];
        string str4 = ch.ToString();
        int num2 = (int) byte.Parse(str3 + str4, NumberStyles.AllowHexSpecifier);
        ch = hex[startIndex + 2];
        string str5 = ch.ToString();
        ch = hex[startIndex + 2];
        string str6 = ch.ToString();
        int num3 = (int) byte.Parse(str5 + str6, NumberStyles.AllowHexSpecifier);
        Color32 color32 = new Color32((byte) num1, (byte) num2, (byte) num3, byte.MaxValue);
        local = color32;
      }
      return true;
    }
    color = new Color32();
    return false;
  }
}
