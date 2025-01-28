
using TMPro;
using UnityEngine;

public class OverheadEmoji : MonoBehaviour
{
  public float speed = 10f;
  public AnimationCurve curve;
  public TMP_Text text;
  public float cur;
  private int state;

  private void Start()
  {
  }

  private void Update()
  {
    if (this.state == 0)
    {
      this.cur += Time.deltaTime * this.speed;
      float num = 1f / this.transform.parent.localScale.x * this.curve.Evaluate(this.cur);
      this.transform.localScale = new Vector3(num, Mathf.Abs(num), 1f);
      if ((double) this.cur < 1.0)
        return;
      ++this.state;
      this.cur = 0.0f;
    }
    else if (this.state == 1)
    {
      this.cur += Time.deltaTime;
      if ((double) this.cur < 2.0)
        return;
      ++this.state;
      this.cur = 1f;
    }
    else
    {
      this.cur -= Time.deltaTime * this.speed;
      if ((double) this.cur <= 0.0)
      {
        Object.Destroy((Object) this.gameObject);
      }
      else
      {
        float num = 1f / this.transform.parent.localScale.x * this.curve.Evaluate(this.cur);
        this.transform.localScale = new Vector3(num, Mathf.Abs(num), 1f);
      }
    }
  }

  public void OnEmoji(int emoji)
  {
    this.text.text = "<sprite name=\"" + EmojiInfo.FromIndex(emoji).realName + "\">";
  }
}
