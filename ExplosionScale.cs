
using UnityEngine;

public class ExplosionScale : Explosion
{
  public override void Update()
  {
    float num = (float) (1.0 - (double) this.curDuration / (double) this.Duration);
    if ((double) num < 0.00999999977648258)
      num = 0.01f;
    this.transform.localScale = Vector3.one * num;
    base.Update();
  }
}
