
using UnityEngine;

#nullable disable
public class SpinningAxe : MonoBehaviour
{
  public Transform parentT;
  public Transform realAxe;
  public float _speed = 1000f;
  public bool isBear;
  private Vector3 startPos = Vector3.zero;
  private Vector3 target = Vector3.zero;
  private Vector3 angle = Vector3.zero;
  private float lerpT;
  [Header("Bear")]
  public Transform leftArm;
  [Header("Bear")]
  public Transform rightArm;
  private Vector3 leftStart;
  private Vector3 rightStart;
  public float speedUp = 1f;
  public float handRadius = 10f;
  private bool up = true;

  public void StartSpinning(Vector3 target)
  {
    if (this.isBear)
    {
      if ((double) this.leftStart.x == 0.0)
      {
        this.leftStart = this.leftArm.localPosition;
        this.rightStart = this.rightArm.localPosition;
        this.lerpT = 0.5f;
      }
      this.angle.z = 0.0f;
      this.realAxe.localEulerAngles = Vector3.zero;
      this.realAxe.gameObject.SetActive(false);
      this.gameObject.SetActive(true);
    }
    else
    {
      this.target = target;
      this.lerpT = 0.0f;
      this.startPos = this.transform.localPosition;
      if (this.gameObject.activeSelf)
        return;
      this.angle.z = 0.0f;
      this.transform.localPosition = this.realAxe.localPosition;
      this.realAxe.localEulerAngles = Vector3.zero;
      this.realAxe.gameObject.SetActive(false);
      this.gameObject.SetActive(true);
    }
  }

  public void StopSpinning()
  {
    this.realAxe.gameObject.SetActive(true);
    this.gameObject.SetActive(false);
  }

  private void LateUpdate()
  {
    if (this.isBear)
    {
      this.angle.z += this._speed * Time.deltaTime * this.parentT.localScale.x;
      this.lerpT += Time.deltaTime * this.speedUp;
      while ((double) this.angle.z < -360.0)
        this.angle.z += 360f;
      while ((double) this.angle.z > 360.0)
        this.angle.z -= 360f;
      this.leftArm.localEulerAngles = this.angle;
      this.rightArm.localEulerAngles = this.angle;
      this.leftArm.localPosition = Vector3.Lerp(this.leftStart, this.leftStart + new Vector3(0.0f, 20f), this.lerpT);
      this.rightArm.localPosition = Vector3.Lerp(this.rightStart, this.rightStart + new Vector3(0.0f, 20f), 1f - this.lerpT);
      this.leftArm.localPosition = new Vector3(this.leftStart.x + Mathf.Sin(this.lerpT + 180f) * this.handRadius, this.leftStart.y + Mathf.Cos(this.lerpT + 180f) * this.handRadius);
      this.rightArm.localPosition = new Vector3(this.rightStart.x + Mathf.Sin(this.lerpT) * this.handRadius, this.rightStart.y + Mathf.Cos(this.lerpT) * this.handRadius);
    }
    else
    {
      this.angle.z += this._speed * Time.deltaTime * this.parentT.localScale.x;
      while ((double) this.angle.z < -360.0)
        this.angle.z += 360f;
      while ((double) this.angle.z > 360.0)
        this.angle.z -= 360f;
      this.transform.localEulerAngles = this.angle;
      if ((double) this.lerpT < 1.0)
      {
        this.lerpT += Time.deltaTime * 4f;
        if ((double) this.lerpT > 1.0)
          this.lerpT = 1f;
        this.transform.position = Vector3.Lerp(this.startPos, this.target, this.lerpT) + this.parentT.position;
      }
      else
        this.transform.position = this.target + this.parentT.position;
    }
  }
}
