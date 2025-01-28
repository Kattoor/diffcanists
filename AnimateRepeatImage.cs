
using UnityEngine;
using UnityEngine.UI;

public class AnimateRepeatImage : MonoBehaviour
{
  public float timeToFinish = 1f;
  public Sprite[] sprites;
  private float curTime;
  private float timeBetweenFrames;
  private int index;
  public Image sp;

  private void Start()
  {
    this.timeBetweenFrames = this.timeToFinish / (float) this.sprites.Length;
  }

  private void Update()
  {
    this.curTime += Time.deltaTime;
    if ((double) this.curTime <= (double) this.timeBetweenFrames)
      return;
    this.curTime = 0.0f;
    ++this.index;
    if (this.index >= this.sprites.Length)
      this.index = 0;
    this.sp.sprite = this.sprites[this.index];
  }
}
