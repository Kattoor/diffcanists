
using UnityEngine;

#nullable disable
public class AnimateWyrm : IAnimator
{
  public SpriteRenderer sp;
  public float timeToFinish = 1f;
  public Sprite[] sprites;
  public Sprite[] attackSprites;
  public Sprite[] jumpSprites;
  public Sprite[] burrowingSprites;
  public Sprite[] fallSprites;
  public float boost = 2f;
  public float jumpSpeed = 1f;
  public float fallSpeed = 1f;
  private float curTime;
  private float timeBetweenFrames;
  private int index;
  private float boosting;
  public Sprite[] choose;

  public override void Play(AnimateState anim, float duration = 0.0f, bool sound = true)
  {
    if (!Client.game.isClient || Client.game.resyncing || this.currentState == AnimateState.UnBurrow)
      return;
    switch (anim)
    {
      case AnimateState.Attack:
        if (this.attackSprites.Length == 0)
          return;
        this.curTime = 0.0f;
        this.boosting = 0.0f;
        this.choose = this.attackSprites;
        this.index = 0;
        break;
      case AnimateState.Burrow:
        if (this.jumpSprites.Length == 0)
          return;
        this.curTime = 0.0f;
        this.boosting = 0.0f;
        this.choose = this.jumpSprites;
        this.index = 0;
        break;
      case AnimateState.UnBurrow:
        if (this.fallSprites.Length == 0)
          return;
        this.curTime = 0.0f;
        this.boosting = 0.0f;
        this.choose = this.fallSprites;
        this.index = 0;
        break;
      default:
        this.boosting = 0.5f;
        this.choose = this.sprites;
        break;
    }
    this.duration = duration;
    this.currentState = anim;
  }

  private void Start()
  {
    this.timeBetweenFrames = this.timeToFinish / (float) this.sprites.Length;
    this.choose = this.sprites;
  }

  private void Update()
  {
    if (Client.game == null || !Client.game.isClient || Client.game.resyncing)
      return;
    this.curTime += Time.deltaTime * (this.currentState == AnimateState.Burrow ? this.jumpSpeed : (this.currentState == AnimateState.UnBurrow ? this.fallSpeed : 1f));
    if ((double) this.curTime <= (double) this.timeBetweenFrames)
      return;
    this.curTime = 0.0f;
    ++this.index;
    if (this.index >= this.choose.Length)
    {
      this.index = 0;
      if (this.currentState != AnimateState.Stop)
      {
        if (this.currentState == AnimateState.Burrow)
        {
          this.currentState = AnimateState.Burrowing;
          this.choose = this.burrowingSprites;
        }
        if (this.currentState == AnimateState.Burrowing)
        {
          this.currentState = AnimateState.UnBurrow;
          this.choose = this.fallSprites;
        }
        else
        {
          this.currentState = AnimateState.Stop;
          this.choose = this.sprites;
        }
      }
    }
    this.sp.sprite = this.choose[this.index];
  }
}
