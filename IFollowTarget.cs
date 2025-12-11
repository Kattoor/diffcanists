
using UnityEngine;

public interface IFollowTarget
{
  Vector3 GetTarget();

  bool Check();
}
