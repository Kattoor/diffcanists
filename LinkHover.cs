
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class LinkHover : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
  private int linkIndex = -1;
  public TMP_Text pTextMeshPro;

  public void OnPointerEnter(PointerEventData eventData)
  {
    this.StartCoroutine(this.MouseMove());
    this.OnPointerMove(eventData);
  }

  public void OnPointerExit(PointerEventData eventData)
  {
    this.StopAllCoroutines();
    MyToolTip.Close();
    this.linkIndex = -1;
  }

  public void OnPointerMove(PointerEventData eventData)
  {
    int intersectingLink = TMP_TextUtilities.FindIntersectingLink(this.pTextMeshPro, Input.mousePosition, (Camera) null);
    if (intersectingLink != -1 && this.linkIndex != intersectingLink)
      MyToolTip.Show(this.pTextMeshPro.textInfo.linkInfo[intersectingLink].GetLinkID(), -1f);
    else if (intersectingLink == -1)
      MyToolTip.Close();
    this.linkIndex = intersectingLink;
  }

  public IEnumerator MouseMove()
  {
    while (true)
    {
      this.OnPointerMove((PointerEventData) null);
      yield return (object) new WaitForEndOfFrame();
    }
  }
}
