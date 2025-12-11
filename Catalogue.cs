
using System.Collections;
using UnityEngine;

public abstract class Catalogue : MonoBehaviour
{
  public virtual void Kill()
  {
    this.StopAllCoroutines();
    Object.Destroy((Object) this.gameObject);
  }

  public IEnumerator SlowKill()
  {
    Catalogue catalogue = this;
    for (float i = 0.0f; (double) i < 0.300000011920929; i += Time.deltaTime)
      yield return (object) 0;
    Object.Destroy((Object) catalogue.gameObject);
  }
}
