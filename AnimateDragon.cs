
using UnityEngine;

public class AnimateDragon : IAnimator
{
  public float timeToFinish = 1f;
  public float boost = 2f;
  public SpriteRenderer sp;
  public Sprite[] sprites;
  public Sprite[] attackSprites;
  private float curTime;
  private float timeBetweenFrames;
  private int index;
  private float boosting;
  public Sprite[] choose;

  public override void Play(AnimateState anim, float duration = 0.0f, bool sound = true)
  {
    if (!Client.game.isClient || Client.game.resyncing)
      return;
    if (anim == AnimateState.Attack)
    {
      if (this.attackSprites.Length == 0)
        return;
      this.curTime = 0.0f;
      this.boosting = 0.0f;
      this.choose = this.attackSprites;
      this.index = 0;
    }
    else
    {
      this.boosting = 0.5f;
      this.choose = this.sprites;
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
    if (this.currentState == AnimateState.Stop)
      this.curTime += Time.deltaTime;
    else if (this.currentState != AnimateState.Attack)
    {
      this.curTime += Time.deltaTime * this.boost;
      this.boosting -= Time.deltaTime;
      if ((double) this.boosting <= 0.0)
      {
        this.currentState = AnimateState.Stop;
        this.choose = this.sprites;
      }
    }
    else
    {
      this.curTime += Time.deltaTime * 2f;
      this.boosting += Time.deltaTime * 2f;
      if ((double) this.boosting >= 0.899999976158142)
      {
        this.currentState = AnimateState.Stop;
        this.choose = this.sprites;
        this.index = 0;
      }
    }
    if ((double) this.curTime <= (double) this.timeBetweenFrames)
      return;
    this.curTime = 0.0f;
    ++this.index;
    if (this.index >= this.choose.Length)
      this.index = 0;
    this.sp.sprite = this.choose[this.index];
  }
}
