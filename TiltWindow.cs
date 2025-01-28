
using UnityEngine;

public class TiltWindow : MonoBehaviour
{
  public Vector2 range = new Vector2(5f, 3f);
  private Vector2 mRot = Vector2.zero;
  private Transform mTrans;
  private Quaternion mStart;

  private void Start()
  {
    this.mTrans = this.transform;
    this.mStart = this.mTrans.localRotation;
  }

  private void Update()
  {
    Vector3 mousePosition = Input.mousePosition;
    float num1 = (float) Screen.width * 0.5f;
    float num2 = (float) Screen.height * 0.5f;
    this.mRot = Vector2.Lerp(this.mRot, new Vector2(Mathf.Clamp((mousePosition.x - num1) / num1, -1f, 1f), Mathf.Clamp((mousePosition.y - num2) / num2, -1f, 1f)), Time.deltaTime * 5f);
    this.mTrans.localRotation = this.mStart * Quaternion.Euler(-this.mRot.y * this.range.y, this.mRot.x * this.range.x, 0.0f);
  }
}
