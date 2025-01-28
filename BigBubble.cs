
using UnityEngine;

public class BigBubble : MonoBehaviour
{
  private float cur = 1f;
  public float speed = 1f;
  public ZCreature creature;
  private Vector3 _target;
  private Vector3 _start;

  private void Update()
  {
    if (!((ZComponent) this.creature == (object) null) && this.creature.parent.localTurn < 0)
      return;
    Object.Destroy((Object) this.gameObject);
  }
}
