
using UnityEngine;
using UnityEngine.UI;

public class TransitionObj : MonoBehaviour
{
  public float min = 0.2f;
  public float max = 1f;
  private float speed = 3.333333f;
  private bool up = true;
  private float c = 0.5f;
  public Image rend;
  public Image rend2;
  private float cur;

  private void OnEnable()
  {
    this.rend.rectTransform.anchoredPosition = new Vector2(this.rend.rectTransform.anchoredPosition.x, Mathf.Lerp(-275f, 275f, Random.Range(0.0f, 1f)));
    this.rend2.rectTransform.anchoredPosition = new Vector2(this.rend2.rectTransform.anchoredPosition.x, Mathf.Lerp(-275f, 275f, Random.Range(0.0f, 1f)));
  }

  private void Update()
  {
    if (this.up)
    {
      this.cur += Time.deltaTime * this.speed;
      if ((double) this.cur >= 1.0)
      {
        this.cur = 1f;
        this.up = false;
      }
    }
    else
    {
      this.cur -= (float) ((double) Time.deltaTime * (double) this.speed * 2.0);
      if ((double) this.cur <= 0.0)
      {
        this.cur = 0.0f;
        Object.Destroy((Object) this.gameObject);
        return;
      }
    }
    this.c = this.up ? Mathf.Lerp(this.min, this.max, this.cur) : Mathf.Lerp(0.0f, this.max, this.cur);
    Color color = this.rend.color;
    color.a = this.c;
    this.rend.color = color;
    this.rend2.color = color;
  }
}
