
using System;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundCenter : MonoBehaviour
{
  public float speed = 60f;
  public float radius = 3f;
  public float angle;
  public List<Transform> _transforms;
  private float v;

  public void Awake()
  {
    this.Update();
  }

  private void Update()
  {
    this.v += this.speed * Time.deltaTime;
    for (int index = 0; index < this._transforms.Count; ++index)
      this._transforms[index].localPosition = new Vector3(Mathf.Sin(this.v + (float) ((double) this.angle * (double) index * (Math.PI / 180.0))) * this.radius, Mathf.Cos(this.v + (float) ((double) this.angle * (double) index * (Math.PI / 180.0))) * this.radius, 0.0f);
  }
}
