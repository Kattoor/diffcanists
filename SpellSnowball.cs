
using UnityEngine;

public class SpellSnowball : Spell
{
  private Vector3 velocity = new Vector3(0.0f, 1f);
  private float angle;
  private int down;

  public void TestBlit()
  {
    Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    Surface src = new Surface(this.snowTexture);
    RotateImage.Render(Client.game.map, src, (int) worldPoint.x, (int) worldPoint.y - src.height / 2, (float) (360.0 - (double) Mathf.Atan2(this.velocity.y, this.velocity.x) * 57.2957801818848), 1, true, false, 1f);
    this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, Mathf.Atan2(this.velocity.y, this.velocity.x) * 57.29578f);
    if (this.down == 0)
    {
      this.velocity.x += 0.1f;
      this.velocity.y -= 0.1f;
      if ((double) this.velocity.x >= 1.0)
        this.down = 1;
    }
    else if (this.down == 1)
    {
      this.velocity.x -= 0.1f;
      this.velocity.y -= 0.1f;
      if ((double) this.velocity.x <= 0.0)
        this.down = 2;
    }
    else if (this.down == 2)
    {
      this.velocity.x -= 0.1f;
      this.velocity.y += 0.1f;
      if ((double) this.velocity.x <= -1.0)
        this.down = 3;
    }
    else
    {
      this.velocity.x += 0.1f;
      this.velocity.y += 0.1f;
      if ((double) this.velocity.x >= 0.0)
        this.down = 0;
    }
    this.angle += 15f;
  }
}
