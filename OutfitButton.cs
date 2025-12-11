
using Hazel;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class OutfitButton : MonoBehaviour
{
  public Image image;
  public UIOnHover uihover;
  private int index;
  private Outfit outfit;

  internal int Index
  {
    get
    {
      return this.index;
    }
  }

  public static Sprite GetPreview(Sprite s)
  {
    Sprite sprite = (Sprite) null;
    return ClientResources.Instance._overridePreviews.TryGetValue(s.name, out sprite) ? sprite : s;
  }

  public void SetSprite(Sprite s, Outfit o, int i, bool disabled)
  {
    this.index = i;
    this.outfit = o;
    this.image.sprite = OutfitButton.GetPreview(s);
    float num = Mathf.Min(1f, Mathf.Max((float) s.texture.height / 64f, (float) s.texture.width / 64f));
    this.image.rectTransform.sizeDelta = new Vector2(num * 28f, num * 28f);
    if (this.uihover.interactable != disabled)
      return;
    this.uihover.Interactable(!disabled);
  }

  public void SetCallBack(int i)
  {
    this.index = i;
    this.uihover.onClick.AddListener((UnityAction) (() => CharacterCreation.Instance.SelectIndex(this.index)));
    this.uihover.onRightClick.AddListener((UnityAction) (() => CharacterCreation.Instance.TryBuyTournamentOutfit(this.index)));
    this.uihover.onEnter.AddListener(new UnityAction(this.Hover));
    this.uihover.onExit.AddListener(new UnityAction(this.Leave));
  }

  private string ExtraHoverInfo()
  {
    return "";
  }

  public void Hover()
  {
    if (this.uihover.interactable)
    {
      CharacterCreation.Instance.outfitHoverObj.anchoredPosition = ((RectTransform) this.transform).anchoredPosition;
      CharacterCreation.Instance.outfitHoverObj.gameObject.SetActive(true);
    }
    Outfit viewing = CharacterCreation.GetViewing(CharacterCreation.Instance.viewing);
    OutfitData outfitData = Inert.Instance.GetOutfit(viewing)[this.index];
    if (viewing >= Outfit.LeftFoot || !CharacterCreation.Instance.optionNoTooltips.isOn || !outfitData.isLocked)
      return;
    if (outfitData.achievement != Achievement.None)
      MyToolTip.Show("Achievement required: <#00FFFF>" + Achievements.list[(int) outfitData.achievement].name + this.ExtraHoverInfo(), -1f);
    else if (outfitData.accountType != AccountType.None)
      MyToolTip.Show("Account role required: <#FF0000>" + outfitData.accountType.GetFirstFlags().Replace("_", " ") + this.ExtraHoverInfo(), -1f);
    else if (outfitData.badge != Badge.None)
      MyToolTip.Show("Account role required: <#FF0000>" + ClientResources.Instance.badges[(int) outfitData.badge].name + this.ExtraHoverInfo(), -1f);
    else if (outfitData.prestige > 0)
      MyToolTip.Show(string.Format("Prestige: <#00FF00>{0}</color>", (object) outfitData.prestige) + this.ExtraHoverInfo(), -1f);
    else if (outfitData.experience > 0)
      MyToolTip.Show(string.Format("Experience Level: <#00FF00>{0}</color>", (object) outfitData.experience) + this.ExtraHoverInfo(), -1f);
    else if (outfitData.tournament > 0)
      MyToolTip.Show(string.Format("<sprite name=\"tcoin\"> Tournament Coins: <#00FF00>{0}</color>", (object) outfitData.tournament) + this.ExtraHoverInfo(), -1f);
    else if (outfitData.season == Server.ServerSettings.Season.Halloween)
      MyToolTip.Show("Seasonal login reward: <#FF8A00>Halloween</color>" + this.ExtraHoverInfo(), -1f);
    else if (outfitData.season == Server.ServerSettings.Season.Thanksgiving)
      MyToolTip.Show("Seasonal login reward: <#874400>Thanksgiving</color>" + this.ExtraHoverInfo(), -1f);
    else if (outfitData.season == Server.ServerSettings.Season.Easter)
      MyToolTip.Show("Seasonal login reward: <#4444FF>Easter</color>" + this.ExtraHoverInfo(), -1f);
    else if (outfitData.season == Server.ServerSettings.Season.Christmas)
      MyToolTip.Show("Seasonal login reward: <#44FF00>Christmas</color>" + this.ExtraHoverInfo(), -1f);
    else if (!string.IsNullOrEmpty(Inert.Instance.GetOutfit(viewing)[this.index].reason))
    {
      MyToolTip.Show("Reward: " + Inert.Instance.GetOutfit(viewing)[this.index].reason + this.ExtraHoverInfo(), -1f);
    }
    else
    {
      if (Client.cosmetics.array[(int) viewing][(int) (byte) this.index] || !Inert.Instance.GetOutfit(viewing)[this.index].isLocked)
        return;
      MyToolTip.Show("Locked due to limited availability." + this.ExtraHoverInfo(), -1f);
    }
  }

  public void Leave()
  {
    CharacterCreation.Instance.outfitHoverObj.gameObject.SetActive(false);
    MyToolTip.Close();
  }
}
