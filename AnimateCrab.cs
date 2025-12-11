
using System;
using System.Collections;
using UnityEngine;

public class AnimateCrab : IAnimator
{
  public float walkSpeed = 20f;
  public float stopSpeed = 16f;
  public float footRadiusX = 2.5f;
  public float footRadiusY = 1.5f;
  public Transform[] feet;
  private Vector3[] start;
  private Vector3[] joint;
  private Vector3[] stop;
  private Coroutine coroutine;
  [NonSerialized]
  public ZCreature creature;
  private float nextWalkSound;

  public override void ResetLeftHand()
  {
  }

  public override void ResetRightHand()
  {
  }

  public override void ResetRightFoot()
  {
  }

  public override void ResetLeftFoot()
  {
  }

  private void Awake()
  {
    this.start = new Vector3[this.feet.Length];
    this.joint = new Vector3[this.feet.Length];
    this.stop = new Vector3[this.feet.Length];
    for (int index = 0; index < this.feet.Length; ++index)
    {
      this.start[index] = this.feet[index].localPosition;
      this.joint[index] = this.feet[index].localPosition;
    }
  }

  public override void Play(AnimateState anim, float duration = 0.0f, bool sound = true)
  {
    if (Client.game == null || !Client.game.isClient || Client.game.resyncing || !ZComponent.IsNull((ZComponent) this.creature) && this.creature.parent != null && ((UnityEngine.Object) this.creature.parent.torquing != (UnityEngine.Object) null && (ZComponent) this.creature.parent.torquing.creature == (object) this.creature) || (ZComponent) this.creature != (object) null && this.creature.flying && !this.creature.entangledOrGravity)
      return;
    this.duration = duration;
    if (this.currentState == anim)
      return;
    this.currentState = anim;
    if (this.coroutine != null)
      this.StopCoroutine(this.coroutine);
    this.nextWalkSound = 0.0f;
    switch (anim)
    {
      case AnimateState.Walk:
        this.coroutine = this.StartCoroutine(this.Walk());
        break;
      case AnimateState.Jump:
        this.coroutine = this.StartCoroutine(this.Walk());
        break;
      case AnimateState.Fall:
        this.coroutine = this.StartCoroutine(this.Walk());
        break;
      default:
        this.coroutine = this.StartCoroutine(this.Stop());
        break;
    }
  }

  private IEnumerator Walk()
  {
    AnimateCrab animateCrab = this;
    float t = 0.0f;
    while ((double) animateCrab.duration > 0.0)
    {
      t += Time.deltaTime * animateCrab.walkSpeed;
      for (int index = 0; index < animateCrab.feet.Length; ++index)
      {
        float f = t + (index % 2 == 0 ? (float) index * 0.3f : (float) index * 0.6f);
        animateCrab.feet[index].localPosition = new Vector3(animateCrab.joint[index].x + Mathf.Sin(f) * animateCrab.footRadiusX, animateCrab.joint[index].y + Mathf.Max(0.0f, Mathf.Cos(f) * animateCrab.footRadiusY));
      }
      animateCrab.duration -= Time.deltaTime;
      yield return (object) new WaitForEndOfFrame();
    }
    animateCrab.Play(AnimateState.Stop, 0.0f, true);
  }

  private IEnumerator Stop()
  {
    float t = 0.0f;
    for (int index = 0; index < this.feet.Length; ++index)
      this.stop[index] = this.feet[index].localPosition;
    while ((double) t < 1.0)
    {
      t += Time.deltaTime * this.stopSpeed;
      for (int index = 0; index < this.feet.Length; ++index)
        this.feet[index].localPosition = Vector3.Lerp(this.stop[index], this.start[index], t);
      yield return (object) new WaitForEndOfFrame();
    }
    for (int index = 0; index < this.feet.Length; ++index)
      this.feet[index].localPosition = this.start[index];
  }
}
