
using System.Collections.Generic;
using UnityEngine;

public class ParticleElectricity : MonoBehaviour
{
  private Vector3[] points = new Vector3[5];
  private readonly float randomPosOffset = 20f;
  private readonly float randomWithOffsetMax = 20f;
  private readonly float randomWithOffsetMin = 10f;
  public LineRenderer lRend;
  public ParticleSystem ps;
  private ParticleSystem.EmitParams emitParams;
  private float t;

  public void Setup(Vector3 start, Vector3 end)
  {
    Vector3[] bolt = ParticleElectricity.CreateBolt(start, end);
    this.lRend.positionCount = bolt.Length;
    this.lRend.SetPositions(bolt);
    this.lRend.startWidth = this.RandomWidthOffset();
    this.lRend.endWidth = this.RandomWidthOffset();
    this.t = 0.0f;
    this.gameObject.SetActive(true);
    this.lRend.enabled = true;
    this.emitParams.position = end;
    this.ps.Emit(this.emitParams, 1);
  }

  private void Update()
  {
    this.t += Time.deltaTime;
    if (this.lRend.enabled && (double) this.t > 0.200000002980232)
    {
      this.lRend.enabled = false;
    }
    else
    {
      if ((double) this.t <= 0.5)
        return;
      this.gameObject.SetActive(false);
    }
  }

  private float RandomWidthOffset()
  {
    return Random.Range(this.randomWithOffsetMin, this.randomWithOffsetMax);
  }

  private Vector3 GetMiddleWithRandomness(Vector3 point1, Vector3 point2)
  {
    float num1 = (float) (((double) point1.x + (double) point2.x) / 2.0);
    double num2 = (double) Random.Range(num1 - this.randomPosOffset, num1 + this.randomPosOffset);
    float num3 = (float) (((double) point1.y + (double) point2.y) / 2.0);
    double num4 = (double) Random.Range(num3 - this.randomPosOffset, num3 + this.randomPosOffset);
    return new Vector3((float) num2, (float) num4, 0.0f);
  }

  protected static Vector3[] CreateBolt(Vector3 source, Vector3 dest)
  {
    Vector3 vector3_1 = dest - source;
    Vector3 normalized = (Vector3) new Vector2(vector3_1.y, -vector3_1.x).normalized;
    float magnitude = vector3_1.magnitude;
    List<float> floatList = new List<float>();
    floatList.Add(0.0f);
    int num1 = (int) magnitude / 20;
    Vector3[] vector3Array = new Vector3[num1 + 2];
    for (int index = 0; index < num1; ++index)
      floatList.Add(1f * (float) index / (float) num1);
    Vector2 vector2_1 = (Vector2) source;
    vector3Array[0] = source;
    float num2 = 0.0f;
    for (int index = 1; index < floatList.Count; ++index)
    {
      float num3 = floatList[index];
      float num4 = (float) ((double) magnitude * 0.00416666688397527 * ((double) num3 - (double) floatList[index - 1]));
      float num5 = (double) num3 > 0.949999988079071 ? (float) (20.0 * (1.0 - (double) num3)) : 1f;
      float num6 = Random.Range(-120f, 120f);
      float num7 = (num6 - (float) (((double) num6 - (double) num2) * (1.0 - (double) num4))) * num5;
      Vector3 vector3_2 = source + num3 * vector3_1 + num7 * normalized;
      vector3Array[index] = vector3_2;
      Vector2 vector2_2 = (Vector2) vector3_2;
      num2 = num7;
    }
    vector3Array[num1 + 1] = dest;
    return vector3Array;
  }
}
