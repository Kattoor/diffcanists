
using System;
using UnityEngine;

public class CircleWiggle : MonoBehaviour
{
  public int lineCount = 10;
  public int joints = 5;
  public float radius = 5f;
  public float wiggleAmount = 0.5f;
  public float wiggleSpeed = 5f;
  public Vector3 startPoint = Vector3.zero;
  private LineRenderer[] lines;
  public LineRenderer pfab;

  private void Start()
  {
    this.startPoint = this.transform.position + new Vector3(0.0f, 30f, 0.0f);
    this.lines = new LineRenderer[this.lineCount];
    for (int index = 0; index < this.lineCount; ++index)
    {
      this.lines[index] = UnityEngine.Object.Instantiate<LineRenderer>(this.pfab, this.startPoint, Quaternion.identity, this.transform);
      this.lines[index].useWorldSpace = true;
      this.lines[index].positionCount = this.joints + 2;
      this.lines[index].gameObject.SetActive(true);
    }
    this.Update();
  }

  private void Update()
  {
    float num = (float) (360.0 / (double) this.lineCount * (Math.PI / 180.0));
    for (int index1 = 0; index1 < this.lineCount; ++index1)
    {
      Vector3 vector3_1 = this.transform.position + new Vector3(Mathf.Cos((float) ((double) num * (double) index1 + (double) num / 2.0)) * this.radius, Mathf.Sin((float) ((double) num * (double) index1 + (double) num / 2.0)) * this.radius, 0.0f);
      for (int index2 = 1; index2 < this.joints + 1; ++index2)
      {
        Vector3 vector3_2 = new Vector3(Mathf.PerlinNoise(Time.time * this.wiggleSpeed, (float) (index1 * index2)) - 0.5f, Mathf.PerlinNoise((float) (index1 * index2), Time.time * this.wiggleSpeed) - 0.5f, 0.0f) * this.wiggleAmount;
        this.lines[index1].SetPosition(index2, Vector3.Lerp(this.startPoint, vector3_1, (float) (index2 + 1) / 7f) + vector3_2);
      }
      this.lines[index1].SetPosition(0, this.startPoint);
      this.lines[index1].SetPosition(this.joints + 1, vector3_1);
    }
  }
}
