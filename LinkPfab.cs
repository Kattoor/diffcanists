
using System;
using System.Collections;
using UnityEngine;

public class LinkPfab : MonoBehaviour
{
  public static bool isVisible = true;
  public float slideSpeed = 500f;
  public float hiddenX = -200f;
  public float hoverThreshold = 50f;
  public float hideDelay = 1f;
  private float curDelay = -1f;
  public UIOnHover buttonRankings;
  public UIOnHover buttonClans;
  public GameObject newPatch;
  [Header("Slide")]
  public RectTransform panel;
  public float visibleX;
  private bool isLockedOpen;
  private bool isMoving;

  private void Awake()
  {
    if (!LinkPfab.isVisible)
      this.panel.anchoredPosition = new Vector2(this.hiddenX, this.panel.anchoredPosition.y);
    if (Client.offlineMode)
    {
      this.buttonRankings.Interactable(false);
      this.buttonClans.Interactable(false);
    }
    this.newPatch.SetActive(PatchMenu.NewVersion);
  }

  public void ContextMenu(string name, Action a)
  {
    MyContextMenu myContextMenu = MyContextMenu.Show();
    myContextMenu.AddSeperator("Opens in an External Browser");
    myContextMenu.AddItem(name, a, (Color) ColorScheme.GetColor(MyContextMenu.ColorGreen));
    myContextMenu.Rebuild(false);
  }

  public void ClickDiscordLink()
  {
    this.ContextMenu("Arcanists Discord", (Action) (() => Global.OpenURL(Server.discordLink)));
  }

  public void ClicWebsiteLink()
  {
    this.ContextMenu("Arcanists Website", (Action) (() => Global.OpenURL(Server.websiteLink)));
  }

  public void ClicWikiLink()
  {
    this.ContextMenu("Arcanists wiki", (Action) (() => Global.OpenURL(Server.wikiLink)));
  }

  public void ClickRules()
  {
    Controller.ShowPopup(CreditsMenu.Type.Rules, (string) null);
  }

  public void ClickPatchNotes()
  {
    Controller.ShowPopup(Controller.Instance.MenuPatchNotes);
    this.newPatch.SetActive(false);
  }

  public void ClickCredits()
  {
    Controller.ShowPopup(CreditsMenu.Type.Credits, (string) null);
  }

  public void ClickClans()
  {
    Controller.ShowPopup(Controller.Instance.MenuClanList);
  }

  public void ClickRatingsMenu()
  {
    Controller.ShowPopup(Controller.Instance.MenuRatings);
  }

  public void ClickAchievements()
  {
    Controller.ShowPopup(Controller.Instance.MenuAchievements);
  }

  public void ClickInformation()
  {
    Controller.ShowPrestigeMenu();
  }

  public void ClickStore()
  {
    Controller.ShowPopup(Controller.Instance.MenuStore);
  }

  public void Hover(string s)
  {
    MyToolTip.Show(s, -1f, false);
  }

  public void Leave()
  {
    MyToolTip.Close();
  }

  private void Update()
  {
    if (this.isLockedOpen || this.isMoving)
      return;
    int num = (double) ((Vector2) Input.mousePosition).x < (double) this.hoverThreshold ? 1 : 0;
    if (num == 0)
      this.curDelay += Time.deltaTime;
    else if ((double) this.curDelay != 0.0)
      this.curDelay = 0.0f;
    if (num != 0 || (double) this.curDelay < (double) this.hideDelay && LinkPfab.isVisible)
      this.SlidePanel(this.visibleX);
    else
      this.SlidePanel(this.hiddenX);
  }

  public void ToggleLock()
  {
  }

  private void SlidePanel(float targetX)
  {
    LinkPfab.isVisible = (double) targetX >= 0.0;
    if ((double) this.panel.anchoredPosition.x == (double) targetX)
      return;
    this.StopAllCoroutines();
    this.StartCoroutine(this.SmoothMove(targetX));
  }

  private IEnumerator SmoothMove(float targetX)
  {
    this.isMoving = true;
    Vector2 startPos = this.panel.anchoredPosition;
    float elapsedTime = 0.0f;
    float duration = Mathf.Abs(startPos.x - targetX) / this.slideSpeed;
    while ((double) elapsedTime < (double) duration)
    {
      elapsedTime += Time.deltaTime;
      this.panel.anchoredPosition = new Vector2(Mathf.Lerp(startPos.x, targetX, elapsedTime / duration), startPos.y);
      yield return (object) null;
    }
    this.panel.anchoredPosition = new Vector2(targetX, startPos.y);
    this.isMoving = false;
  }
}
