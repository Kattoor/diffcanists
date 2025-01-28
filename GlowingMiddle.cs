
using UnityEngine;
using UnityEngine.UI;

public class GlowingMiddle : MonoBehaviour
{
  private Color tColor = Color.white;
  public float speed = 1f;
  public float minScale = 0.5f;
  public float maxScale = 1f;
  private float ts;
  public Image image;

  private void Update()
  {
    this.ts += this.speed * Time.deltaTime;
    this.tColor.a = Mathf.Lerp(this.maxScale, this.minScale, Mathf.Abs(Mathf.Sin(this.ts)));
    this.image.color = this.tColor;
  }
}
