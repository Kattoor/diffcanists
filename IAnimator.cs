
using System;
using UnityEngine;

public class IAnimator : MonoBehaviour
{
  [NonSerialized]
  public float duration = float.MaxValue;
  public AnimateState currentState;

  public virtual void Play(AnimateState anim, float duration = 0.0f, bool sound = true)
  {
    throw new Exception("Play not implemented in IAnimator.cs");
  }

  public virtual void ResetLeftHand()
  {
  }

  public virtual void ResetRightHand()
  {
  }

  public virtual void ResetRightFoot()
  {
  }

  public virtual void ResetLeftFoot()
  {
  }
}
