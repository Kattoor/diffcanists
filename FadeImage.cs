
using UnityEngine;
using UnityEngine.UI;

public class FadeImage : MonoBehaviour
{
  public float speed = 0.3f;
  public float delay = 1f;
  public Image img;
  private float cur;

  private void Update()
  {
    if ((double) this.delay > 0.0)
    {
      this.delay -= Time.deltaTime;
    }
    else
    {
      this.cur += Time.deltaTime * this.speed;
      if ((double) this.cur >= 1.0)
      {
        this.gameObject.SetActive(false);
      }
      else
      {
        Color color = this.img.color;
        color.a = 1f - this.cur;
        this.img.color = color;
      }
    }
  }
}
