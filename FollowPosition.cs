
using UnityEngine;

public class FollowPosition : IFollowTarget
{
  public float time = -1f;
  private Vector3 s;

  public FollowPosition(Vector2 p)
  {
    this.s = (Vector3) p;
    this.time = Time.realtimeSinceStartup + (Client.game.isReplay ? 1f : 3f);
  }

  public Vector3 GetTarget()
  {
    return this.s;
  }

  public bool Check()
  {
    return (double) this.time >= (double) Time.realtimeSinceStartup;
  }
}
