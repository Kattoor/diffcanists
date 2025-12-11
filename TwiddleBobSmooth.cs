
using UnityEngine;

public class TwiddleBobSmooth : MonoBehaviour
{
  public float speed = 1f;
  public float maxY = 5f;
  public float minY;
  private float curTime;
  private bool down;

  private void Update()
  {
    if (this.down)
    {
      this.curTime -= Time.deltaTime * this.speed;
      if ((double) this.curTime <= 0.0)
      {
        this.curTime = 0.0f;
        this.down = false;
      }
    }
    else
    {
      if ((double) this.curTime >= 1.0)
      {
        this.curTime = 1f;
        this.down = true;
      }
      this.curTime += Time.deltaTime * this.speed;
    }
    Vector3 localPosition = this.transform.localPosition;
    localPosition.y = Mathf.SmoothStep(this.minY, this.maxY, this.curTime);
    this.transform.localPosition = localPosition;
  }
}
