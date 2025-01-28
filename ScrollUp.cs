
using UnityEngine;

public class ScrollUp : MonoBehaviour
{
  public float speed = 30f;
  public RectTransform parent;
  public RectTransform rect;

  private void Update()
  {
    float num = this.parent.sizeDelta.y + this.rect.sizeDelta.y * this.rect.localScale.y;
    float y = this.rect.anchoredPosition.y + Time.deltaTime * this.speed;
    if ((double) y > (double) num)
      y = -10f;
    this.rect.anchoredPosition = new Vector2(0.0f, y);
  }
}
