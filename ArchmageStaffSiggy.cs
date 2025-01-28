
using System;
using System.Collections.Generic;
using UnityEngine;

public class ArchmageStaffSiggy : MonoBehaviour
{
  public float size = 50f;
  [Header("Rotation")]
  public float speed = 2f;
  private Queue<Vector3> oldPos = new Queue<Vector3>();
  public ParticleSystem p1;
  [NonSerialized]
  public Creature target;
  public int id;
  public bool triStaff;
  public int triIndex;

  private void Start()
  {
    for (int index = 0; index < 15; ++index)
      this.oldPos.Enqueue(this.target.transform.position);
  }

  private void Update()
  {
    if (!this.triStaff)
      return;
    if ((int) this.transform.position.y == 1000 && Client.map.Height > 0)
    {
      if (this.triStaff)
        this.transform.position = new Vector3((float) (Client.map.Width / 2 * this.triIndex), (float) (Client.map.Height + 1000));
      else if (Client.game.gameFacts.settingsPlayer.Count == 1)
        this.transform.position = new Vector3(0.0f, (float) Client.map.Height);
      else
        this.transform.position = new Vector3((float) (Client.map.Width / (Client.game.gameFacts.settingsPlayer.Count - 1) * this.id), (float) Client.map.Height);
    }
    if ((bool) (UnityEngine.Object) this.target && (bool) (UnityEngine.Object) this.target.transform)
    {
      if ((double) this.transform.position.x != (double) this.target.transform.position.x)
      {
        Vector3 position = this.transform.position;
        position.x = this.target.transform.position.x;
        this.transform.position = position;
      }
      Coords coords = Client.map.bresenhamsLineCastOnlyTerrain(new Coords((int) this.transform.position.x, (int) this.transform.position.y), new Coords((int) this.target.transform.position.x, (int) this.target.transform.position.y));
      Vector3 vector3 = this.target.transform.position - this.transform.position;
      if (coords == null)
      {
        float num = (float) ((double) vector3.magnitude - (double) this.target.radius - 25.0);
        ParticleSystem.MainModule main = this.p1.main;
        main.startLifetime = (ParticleSystem.MinMaxCurve) (num / this.size);
        this.p1.trails.lifetime = main.startLifetime;
      }
      vector3.Normalize();
      this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.Euler(0.0f, 0.0f, Mathf.Atan2(vector3.y, vector3.x) * 57.29578f), this.speed * Time.deltaTime);
      if (coords == null)
      {
        if (this.p1.isPlaying)
          return;
        this.p1.Play();
      }
      else
      {
        if (!this.p1.isPlaying)
          return;
        this.p1.Stop();
      }
    }
    else
      UnityEngine.Object.Destroy((UnityEngine.Object) this.gameObject);
  }
}
