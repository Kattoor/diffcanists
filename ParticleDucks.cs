
using UnityEngine;

public class ParticleDucks : MonoBehaviour
{
  public float speed = 10f;
  private Vector3 a = Vector3.zero;
  private Vector3 b = Vector3.zero;
  public Creature c;
  public Transform[] ducks;
  public Transform[] duckParents;

  internal void SetRed()
  {
    foreach (Component duck in this.ducks)
      duck.GetComponent<AnimateRepeat>().sprites = ClientResources.Instance.zombieDucks;
  }

  internal void SetNormal()
  {
    foreach (Component duck in this.ducks)
      duck.GetComponent<AnimateRepeat>().sprites = ClientResources.Instance.ducks;
  }

  private void Update()
  {
    if (!((Object) this.c == (Object) null))
    {
      ZCreature serverObj = this.c.serverObj;
      if ((serverObj != null ? (!serverObj.stunned ? 1 : 0) : 1) == 0 && !((Object) this.c.myducks != (Object) this))
      {
        if ((double) this.transform.parent.localScale.x < 0.0)
        {
          if ((double) this.transform.localScale.x > 0.0)
            this.transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if ((double) this.transform.localScale.x < 0.0)
          this.transform.localScale = new Vector3(1f, 1f, 1f);
        this.a.z += Time.deltaTime * this.speed;
        this.b.z = this.a.z;
        for (int index = 0; index < this.ducks.Length; ++index)
        {
          this.duckParents[index].localEulerAngles = this.b;
          this.ducks[index].eulerAngles = Vector3.zero;
          this.b.z += 120f;
          if ((double) this.ducks[index].position.x > (double) this.transform.position.x)
          {
            if ((double) this.ducks[index].localScale.x > 0.0)
              this.ducks[index].localScale = new Vector3(-1f, 1f, 1f);
          }
          else if ((double) this.ducks[index].localScale.x < 0.0)
            this.ducks[index].localScale = new Vector3(1f, 1f, 1f);
        }
        return;
      }
    }
    if ((Object) this.c != (Object) null && (Object) this.c.myducks == (Object) this)
      this.c.myducks = (ParticleDucks) null;
    Object.Destroy((Object) this.gameObject);
  }
}
