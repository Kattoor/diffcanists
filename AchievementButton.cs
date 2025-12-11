
using UnityEngine;
using UnityEngine.UI;

public class AchievementButton : MonoBehaviour
{
  public RectTransform rect;
  public Image image;
  public UIOnHover button;
  public Achievement achievement;

  public void OnClick()
  {
    AchievementsMenu.Instance.OnClick(this, this.achievement);
  }

  public void OnHover()
  {
    AchievementsMenu.Instance.OnEnter(this.achievement, false);
  }

  public void OnExit()
  {
    AchievementsMenu.Instance.OnExit();
  }
}
