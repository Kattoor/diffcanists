
using UnityEngine;

public class ScaleSnare : MonoBehaviour
{
  public float minScale = 0.5f;
  public float maxScale = 0.5f;
  public float speed = 2f;
  public Effector effector;
  private float curT;
  private bool v;

  private void Update()
  {
    if ((Object) this.effector == (Object) null || (ZComponent) this.effector.serverObj == (object) null || !this.effector.serverObj.active)
    {
      if ((double) this.transform.localScale.x == 1.0)
        return;
      this.transform.localScale = new Vector3(1f, 1f, 1f);
    }
    else
    {
      if (this.v)
      {
        this.curT += Time.deltaTime * this.speed;
        if ((double) this.curT >= 1.0)
        {
          this.v = false;
          this.curT = 1f;
        }
      }
      else
      {
        this.curT -= Time.deltaTime * this.speed;
        if ((double) this.curT <= 0.0)
        {
          this.v = true;
          this.curT = 0.0f;
        }
      }
      float num = Mathf.SmoothStep(this.minScale, this.maxScale, this.curT);
      this.transform.localScale = new Vector3(num, num, num);
    }
  }
}
