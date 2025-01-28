
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonArcanistsStore : MonoBehaviour
{
  public UIOnHover button;
  public TMP_Text txtName;
  public TMP_Text txtCost;
  public Image image;
  public GameObject objBought;
  public GameObject objPrice;
  public TMP_Text txtBought;
  public UIOnHoverChild boughtStarColor;
  public Image boughtStarImg;
  public UIOnHoverChild boughtBgColor;
  public Image boughtBgImg;
  public int myIndex;

  public void Setup(
    ArcanistsStore.Item x,
    ArcanistsStore.Which which,
    int i,
    bool isUnlocked,
    bool isActive)
  {
    this.myIndex = i;
    this.txtName.text = x.name;
    this.txtCost.text = x.cost.ToString();
    this.image.sprite = x.sprite;
    this.objBought.SetActive(isUnlocked);
    this.objPrice.SetActive(!isUnlocked);
    if (!isUnlocked)
      return;
    bool flag = Client.MyAccount.activeItems.FindIndex((Predicate<ActiveItem>) (z => z.which == which && z.index == i)) > -1;
    this.txtBought.text = flag ? "Equipped" : "Bought";
    float hue = flag ? 0.1882353f : -0.1882353f;
    float sat = 0.0f;
    float val = flag ? 0.0f : -0.2f;
    this.boughtStarColor.NormalColor = ColorHSV.AdjustColor(this.boughtStarColor.NormalColor, hue, sat, val);
    this.boughtStarColor.HighlightedColor = ColorHSV.AdjustColor(this.boughtStarColor.HighlightedColor, hue, sat, val);
    this.boughtStarColor.PressedColor = ColorHSV.AdjustColor(this.boughtStarColor.PressedColor, hue, sat, val);
    this.boughtStarImg.color = ColorHSV.AdjustColor(this.boughtStarImg.color, hue, sat, val);
    this.boughtBgColor.NormalColor = ColorHSV.AdjustColor(this.boughtBgColor.NormalColor, hue, sat, val);
    this.boughtBgColor.HighlightedColor = ColorHSV.AdjustColor(this.boughtBgColor.HighlightedColor, hue, sat, val);
    this.boughtBgColor.PressedColor = ColorHSV.AdjustColor(this.boughtBgColor.PressedColor, hue, sat, val);
    this.boughtBgImg.color = ColorHSV.AdjustColor(this.boughtBgImg.color, hue, sat, val);
  }

  public void ToggleActive(bool v)
  {
    if (v)
    {
      float hue = -0.1882353f;
      this.boughtStarColor.NormalColor = ColorHSV.AdjustColor(this.boughtStarColor.NormalColor, hue);
      this.boughtStarColor.HighlightedColor = ColorHSV.AdjustColor(this.boughtStarColor.HighlightedColor, hue);
      this.boughtStarColor.PressedColor = ColorHSV.AdjustColor(this.boughtStarColor.PressedColor, hue);
      this.boughtStarImg.color = ColorHSV.AdjustColor(this.boughtStarImg.color, hue);
      this.boughtBgColor.NormalColor = ColorHSV.AdjustColor(this.boughtBgColor.NormalColor, hue);
      this.boughtBgColor.HighlightedColor = ColorHSV.AdjustColor(this.boughtBgColor.HighlightedColor, hue);
      this.boughtBgColor.PressedColor = ColorHSV.AdjustColor(this.boughtBgColor.PressedColor, hue);
      this.boughtBgImg.color = ColorHSV.AdjustColor(this.boughtBgImg.color, hue);
    }
    else
    {
      this.boughtStarColor.NormalColor = StoreMenu.Instance.pfabItem.boughtStarColor.NormalColor;
      this.boughtStarColor.HighlightedColor = StoreMenu.Instance.pfabItem.boughtStarColor.HighlightedColor;
      this.boughtStarColor.PressedColor = StoreMenu.Instance.pfabItem.boughtStarColor.PressedColor;
      this.boughtStarImg.color = StoreMenu.Instance.pfabItem.boughtStarImg.color;
      this.boughtBgColor.NormalColor = StoreMenu.Instance.pfabItem.boughtBgColor.NormalColor;
      this.boughtBgColor.HighlightedColor = StoreMenu.Instance.pfabItem.boughtBgColor.HighlightedColor;
      this.boughtBgColor.PressedColor = StoreMenu.Instance.pfabItem.boughtBgColor.PressedColor;
      this.boughtBgImg.color = StoreMenu.Instance.pfabItem.boughtBgImg.color;
    }
  }
}
