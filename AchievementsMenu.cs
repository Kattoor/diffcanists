
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class AchievementsMenu : Catalogue
{
  public RectTransform container;
  public AchievementButton pfabItem;
  public Image img;
  public TMP_Text txtName;
  public TMP_Text txtObtained;
  public TMP_Text txtPoints;
  public TMP_Text txtDescription;
  public Image[] coins;
  public GameObject infoPanel;
  public GameObject statsPanel;
  public TMP_Text txtAmount;
  public Image outfitImage;
  public List<GameObject> outfitImages = new List<GameObject>();
  public bool isStatic;
  public int _viewing = -1;
  private AchievementButton activeButton;

  public static AchievementsMenu Instance { get; private set; }

  private void Awake()
  {
    AchievementsMenu.Instance = this;
    DiscordIntergration.Instance?.UpdateNoUpdate();
  }

  public void OnClick(AchievementButton a, Achievement e)
  {
    if ((UnityEngine.Object) this.activeButton != (UnityEngine.Object) null)
      this.activeButton.button.AlwaysOn = false;
    this.isStatic = !this.isStatic || (Achievement) this._viewing != e;
    this.activeButton = a;
    if (this.isStatic)
      this.activeButton.button.AlwaysOn = true;
    this._viewing = (int) e;
    this.OnEnter(e, true);
  }

  public void OnEnter(Achievement e, bool v = false)
  {
    if (this.isStatic && !v)
      return;
    int index1 = (int) e;
    bool achievement = Client.cosmetics.achievements[index1];
    Achievements.Container container = Achievements.list[index1];
    this.img.sprite = ClientResources.Instance._achievementIcons[index1];
    if (!Client.cosmetics.achievements[index1])
      this.img.color = (Color) new Color32(byte.MaxValue, (byte) 0, (byte) 200, byte.MaxValue);
    else
      this.img.color = Color.white;
    this.txtName.text = container.name;
    this.txtDescription.text = container.description;
    this.txtObtained.text = (achievement ? "Obtained!" : "<color=#FF0000FF>Not yet achieved</color>") + (container.ratedOnly ? "\n<color=#555500FF>Rated Only</color>" : "");
    this.txtPoints.text = "Orb points:\n" + container.points.ToString();
    for (int index2 = 0; index2 < this.outfitImages.Count; ++index2)
      UnityEngine.Object.Destroy((UnityEngine.Object) this.outfitImages[index2]);
    this.outfitImages.Clear();
    int num = 0;
    foreach (OutfitDataList outfitDataList in Inert.Instance.GetOutfitData())
    {
      foreach (OutfitData outfitData in outfitDataList.list)
      {
        if (outfitData.achievement == e)
        {
          Image image = UnityEngine.Object.Instantiate<Image>(this.outfitImage, this.outfitImage.transform.parent);
          image.sprite = OutfitButton.GetPreview(outfitData.sprite);
          image.transform.GetChild(0).GetComponent<TMP_Text>().text = ((OutfitShortName) num).ToString().Replace("_", " ");
          image.gameObject.SetActive(true);
          this.outfitImages.Add(image.gameObject);
        }
      }
      ++num;
    }
    int index3;
    for (index3 = 0; index3 < (int) container.points / 100; ++index3)
      this.coins[index3].gameObject.SetActive(true);
    for (; index3 < this.coins.Length; ++index3)
      this.coins[index3].gameObject.SetActive(false);
    this.statsPanel.SetActive(true);
    this.infoPanel.SetActive(false);
  }

  public void OnExit()
  {
    if (this.isStatic)
      return;
    this.statsPanel.SetActive(false);
    this.infoPanel.SetActive(true);
  }

  private void Start()
  {
    int num1 = 0;
    int num2 = 0;
    int index = -1;
    foreach (Achievement achievement in (Achievement[]) Enum.GetValues(typeof (Achievement)))
    {
      if (achievement != Achievement.None)
      {
        ++index;
        if (Achievements.list[index].available)
        {
          AchievementButton achievementButton = UnityEngine.Object.Instantiate<AchievementButton>(this.pfabItem, (Transform) this.container);
          achievementButton.achievement = achievement;
          if (Client.cosmetics.achievements[index])
            ++num2;
          achievementButton.image.sprite = ClientResources.Instance._achievementIcons[index];
          if (!Client.cosmetics.achievements[index])
            achievementButton.image.color = (Color) new Color32(byte.MaxValue, (byte) 0, (byte) 200, byte.MaxValue);
          achievementButton.gameObject.SetActive(true);
          ++num1;
        }
      }
    }
    this.txtAmount.text = num2.ToString() + "/" + (object) num1;
  }

  public void ClickMainMenu() => UnityEngine.Object.Destroy((UnityEngine.Object) this.gameObject);

  private void OnDestroy()
  {
    if ((UnityEngine.Object) AchievementsMenu.Instance == (UnityEngine.Object) this)
      AchievementsMenu.Instance = (AchievementsMenu) null;
    DiscordIntergration.Instance?.UpdateNoUpdate();
  }
}
