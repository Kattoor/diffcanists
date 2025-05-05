
using UnityEngine;

#nullable disable
public class FamiliarSand : Familiar
{
  public float maxDistance = 4f;
  public float speed = 1f;
  public float walkSpeed = 20f;
  public float height = 18f;
  public int lineCast = 30;
  public IAnimator anim;
  private AnimateState lastState;

  private void Start()
  {
    if (ZComponent.IsNull((ZComponent) this.creature))
      return;
    this.transform.position = (Vector3) this.creature.position.ToSinglePrecision() + new Vector3(-9f, -12f);
  }

  protected override void LateUpdate()
  {
    if (ZComponent.IsNull((ZComponent) this.creature) || this.creature.isDead)
    {
      Object.Destroy((Object) this.gameObject);
    }
    else
    {
      if (!this.creature.game.isClient)
        return;
      Vector3 offset = this.GetOffset();
      if ((double) this.creature.transformscale > 0.0)
        offset.x = -offset.x;
      Vector3 vector3 = (Vector3) this.creature.position.ToSinglePrecision() + offset;
      Coords coords1 = this.creature.game.map.bresenhamsLineCastOnlyTerrain(new Coords((int) vector3.x, (int) vector3.y), new Coords((int) vector3.x, (int) vector3.y - (this.creature.GetRadius() + this.lineCast)));
      if (coords1 != null)
        vector3.y = (float) coords1.y + this.height;
      if ((double) this.transform.localScale.x < 0.0 && (double) this.creature.transformscale > 0.0)
        this.transform.localScale = new Vector3(1f, 1f, 1f);
      else if ((double) this.transform.localScale.x > 0.0 && (double) this.creature.transformscale < 0.0)
        this.transform.localScale = new Vector3(-1f, 1f, 1f);
      bool flag = true;
      float num = Vector3.Distance(vector3, this.transform.position);
      if (Mathf.Abs((int) vector3.y - (int) this.transform.position.y) > 1 || (double) num > (double) this.maxDistance)
      {
        Coords coords2 = (int) this.transform.position.x == (int) vector3.x ? coords1 : this.creature.game.map.bresenhamsLineCastOnlyTerrain(new Coords((int) this.transform.position.x, (int) this.transform.position.y), new Coords((int) this.transform.position.x, (int) this.transform.position.y - (this.creature.GetRadius() + this.lineCast)));
        if (coords2 != null)
        {
          if ((double) vector3.x < (double) this.transform.position.x - 1.0)
            this.transform.position = new Vector3(this.transform.position.x - this.walkSpeed * Time.deltaTime, Mathf.Lerp(this.transform.position.y, (float) coords2.y + this.height, Time.deltaTime * this.speed));
          else if ((double) vector3.x > (double) this.transform.position.x + 1.0)
            this.transform.position = new Vector3(this.transform.position.x + this.walkSpeed * Time.deltaTime, Mathf.Lerp(this.transform.position.y, (float) coords2.y + this.height, Time.deltaTime * this.speed));
          else
            this.transform.position = new Vector3(this.transform.position.x, Mathf.Lerp(this.transform.position.y, (float) coords2.y + this.height, Time.deltaTime * this.speed));
        }
        else
          this.transform.position = Vector3.Lerp(this.transform.position, vector3, Time.deltaTime * this.speed);
        if ((double) num > 3.0)
        {
          this.anim.Play(AnimateState.Walk, 0.05f);
          flag = false;
        }
      }
      if (!flag)
        return;
      if (this.creature.animator.currentState == AnimateState.Walk)
      {
        this.anim.Play(AnimateState.Walk, 0.05f);
        this.lastState = AnimateState.Walk;
      }
      else if (this.creature.animator.currentState == AnimateState.Jump)
      {
        this.anim.Play(AnimateState.Jump, 0.05f);
        this.lastState = AnimateState.Jump;
      }
      else
      {
        if (this.creature.animator.currentState != AnimateState.Stop)
          return;
        this.anim.Play(AnimateState.Stop);
      }
    }
  }
}
