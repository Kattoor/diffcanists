
using UnityEngine;

[RequireComponent(typeof (LineRenderer))]
public class BalloonString : MonoBehaviour
{
  [Header("Curve")]
  public int segments = 12;
  public float sagAmount = 0.4f;
  public float swayStrength = 0.2f;
  [Header("Dynamics")]
  public float followSharpness = 10f;
  public Transform balloon;
  public Transform hand;
  private LineRenderer line;
  private Vector3 sagOffset;
  private Vector3 sagVelocity;

  private void Awake()
  {
    this.hand = this.balloon.parent;
    this.line = this.GetComponent<LineRenderer>();
    this.line.positionCount = this.segments;
  }

  private void LateUpdate()
  {
    if (!(bool) (Object) this.balloon || !(bool) (Object) this.hand)
      return;
    Vector3 position1 = this.balloon.position;
    Vector3 position2 = this.hand.position;
    Vector3 vector3 = (position1 + position2) * 0.5f;
    this.sagOffset = Vector3.SmoothDamp(this.sagOffset, Vector3.down * this.sagAmount * Vector3.Distance(position1, position2), ref this.sagVelocity, 1f / this.followSharpness);
    Vector3 b = Vector3.Lerp(position1, vector3, 0.5f) + this.sagOffset;
    Vector3 c = Vector3.Lerp(vector3, position2, 0.5f) + this.sagOffset;
    for (int index = 0; index < this.segments; ++index)
    {
      float t = (float) index / ((float) this.segments - 1f);
      Vector3 position3 = this.Bezier(position1, b, c, position2, t);
      this.line.SetPosition(index, position3);
    }
  }

  private Vector3 Bezier(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float t)
  {
    float num = 1f - t;
    return num * num * num * a + 3f * num * num * t * b + 3f * num * t * t * c + t * t * t * d;
  }
}
