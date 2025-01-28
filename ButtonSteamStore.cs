
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSteamStore : MonoBehaviour
{
  public UIOnHover uiOnHover;
  public Image imgStars;
  public Image imgGradiant;
  public Image imgCrystal;
  public TMP_Text txtCost;
  public TMP_Text txtAmount;

  public void Setup(SteamStore.Item x)
  {
    this.txtCost.text = ButtonSteamStore.ConvertCentsToDollars(x.cost);
    this.txtAmount.text = x.amount.ToString();
  }

  public static string ConvertCentsToDollars(int cents)
  {
    return ((Decimal) cents / new Decimal(1000, 0, 0, false, (byte) 1)).ToString("C2");
  }
}
