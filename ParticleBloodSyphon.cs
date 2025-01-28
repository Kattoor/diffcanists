
using UnityEngine;

public class ParticleBloodSyphon : MonoBehaviour
{
  private bool goend = true;
  public float speed = 1f;
  public Vector3 start;
  public Vector3 end;
  public Vector3 velocity;
  public ParticleSystem p;
  public GameObject explosion;
  private float cur;

  private void Start()
  {
  }

  private void Update()
  {
    if (this.goend)
    {
      this.cur += Time.deltaTime * this.speed;
      if ((double) this.cur >= 1.0)
      {
        this.cur = 1f;
        this.goend = false;
        Object.Instantiate<GameObject>(this.explosion, this.end, Quaternion.identity, this.transform.parent);
      }
    }
    else
    {
      this.cur -= Time.deltaTime * this.speed;
      if ((double) this.cur <= 0.0)
      {
        this.p.Stop();
        this.enabled = false;
        Object.Destroy((Object) this.gameObject, 1f);
        return;
      }
    }
    this.transform.position = Vector3.Slerp(this.start, this.end, this.cur);
  }
}
