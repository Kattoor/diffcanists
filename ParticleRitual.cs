
using UnityEngine;

public class ParticleRitual : MonoBehaviour
{
  public bool up = true;
  public float speed = 1f;
  public SpriteRenderer icon;
  public SpriteRenderer lightObj;
  public SpriteRenderer bg;
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
        Object.Destroy((Object) this.gameObject);
        return;
      }
    }
    Color color1 = this.icon.color;
    color1.a = this.cur;
    this.icon.color = color1;
    Color color2 = this.lightObj.color;
    color2.a = Mathf.Lerp(0.0f, 0.6588f, this.cur);
    this.lightObj.color = color2;
    Color color3 = this.bg.color;
    color3.a = Mathf.Lerp(0.0f, 0.6588f, this.cur);
    this.bg.color = color3;
  }
}
