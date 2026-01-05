
using UnityEngine;

public class BalloonFollow : MonoBehaviour
{
  [Header("Offsets")]
  public Vector3 localOffset = new Vector3(0.0f, 2f, 0.0f);
  [Header("Follow")]
  public float followSharpness = 8f;
  public float trailStrength = 0.15f;
  [Header("Idle Sway")]
  public float swayAmplitude = 0.1f;
  public float swayFrequency = 1.5f;
  public float freq = 1f;
  public float max = 10f;
  [Header("Target")]
  public Transform target;
  private float dist;
  private Vector3 velocity;
  private Vector3 lastTargetPos;

  private void Start()
  {
    this.target = this.transform.parent.parent;
    this.lastTargetPos = this.target.position;
  }

  private void LateUpdate()
  {
    Vector3 vector3_1 = this.target.TransformPoint(this.localOffset);
    Vector3 vector3_2 = (this.target.position - this.lastTargetPos) / Mathf.Max(Time.deltaTime, 0.0001f);
    this.lastTargetPos = this.target.position;
    Vector3 vector3_3 = Vector3.ClampMagnitude(-vector3_2 * this.trailStrength, 1.5f);
    this.transform.position = Vector3.SmoothDamp(this.transform.position, vector3_1 + vector3_3, ref this.velocity, 1f / this.followSharpness);
    this.ApplyIdleSway(vector3_2.magnitude);
  }

  private void ApplyIdleSway(float movementSpeed)
  {
    this.transform.localPosition += this.transform.right * (Mathf.Sin(Time.time * this.swayFrequency) * this.swayAmplitude);
  }
}
