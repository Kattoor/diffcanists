
using UnityEngine;

public class AnimateLineRenderer : MonoBehaviour
{
  public float startDelay = 3f;
  public float speed = 1f;
  public LineRenderer line;
  private float cur;

  private void Update()
  {
    this.cur += Time.deltaTime;
    if ((double) this.cur < (double) this.startDelay)
      return;
    Color startColor = this.line.startColor;
    Color endColor = this.line.endColor;
    startColor.a -= Time.deltaTime * this.speed;
    endColor.a = startColor.a;
    this.line.startColor = startColor;
    this.line.endColor = endColor;
    if ((double) startColor.a > 0.0)
      return;
    Object.Destroy((Object) this.gameObject);
  }
}
