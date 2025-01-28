
using System.Collections.Generic;
using UnityEngine;

public class ColorLerp : MonoBehaviour
{
  public List<SpriteRenderer> rends = new List<SpriteRenderer>();
  public float min = 0.2f;
  public float max = 0.5f;
  public float speed = 1f;
  private bool up = true;
  private float c = 0.5f;
  public ZCreature _creature;
  public bool randomOffset;
  private float cur;

  public void Kill()
  {
    for (int index = 0; index < this.rends.Count; ++index)
    {
      Color color = this.rends[index].color;
      color.a = 1f;
      this.rends[index].color = color;
    }
    this.enabled = false;
    Object.Destroy((Object) this);
  }

  private void Start()
  {
    if (Application.isBatchMode)
    {
      this.enabled = false;
    }
    else
    {
      if (!this.randomOffset)
        return;
      this.cur = Random.Range(0.0f, 1f);
      this.up = Random.Range(0, 10) >= 5;
    }
  }

  private void Update()
  {
    float from = this.min;
    float to = this.max;
    if ((ZComponent) this._creature != (object) null && !this._creature.isPhantom)
    {
      from = 0.8f;
      to = 1f;
    }
    if (this.up)
    {
      this.cur += Time.deltaTime * this.speed;
      if ((double) this.cur >= 1.0)
      {
        this.cur = 1f;
        this.up = false;
      }
    }
    else
    {
      this.cur -= Time.deltaTime * this.speed;
      if ((double) this.cur <= 0.0)
      {
        this.cur = 0.0f;
        this.up = true;
      }
    }
    this.c = Mathf.SmoothStep(from, to, this.cur);
    for (int index = 0; index < this.rends.Count; ++index)
    {
      if ((Object) this.rends[index] == (Object) null)
      {
        this.rends.RemoveAt(index);
      }
      else
      {
        Color color = this.rends[index].color;
        color.a = this.c;
        this.rends[index].color = color;
      }
    }
  }
}
