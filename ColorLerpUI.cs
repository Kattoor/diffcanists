
using UnityEngine;
using UnityEngine.UI;

public class ColorLerpUI : MonoBehaviour
{
  public float min = 0.2f;
  public float max = 0.5f;
  public float speed = 1f;
  private bool up = true;
  private float c = 0.5f;
  public Image rend;
  private float cur;

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
      this.cur -= Time.deltaTime * this.speed;
      if ((double) this.cur <= 0.0)
      {
        this.cur = 0.0f;
        this.up = true;
      }
    }
    this.c = Mathf.Lerp(this.min, this.max, this.cur);
    Color color = this.rend.color;
    color.a = this.c;
    this.rend.color = color;
  }
}
