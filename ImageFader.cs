
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class ImageFader : MonoBehaviour
{
  public SpriteRenderer spriteRenderer1;
  public SpriteRenderer spriteRenderer2;
  public List<Sprite> sprites;
  public float fadeDuration = 1f;
  public float holdDuration = 1f;
  private int currentSpriteIndex;
  private bool isUsingFirstRenderer = true;

  private void Start()
  {
    if (this.sprites.Count == 0 || !(bool) (Object) this.spriteRenderer1 || !(bool) (Object) this.spriteRenderer2)
      Debug.LogError((object) "Ensure sprites list and SpriteRenderers are properly assigned.");
    else
      this.StartCoroutine(this.FadeCycle());
  }

  private IEnumerator FadeCycle()
  {
    ImageFader imageFader = this;
    while (true)
    {
      Sprite sprite = imageFader.sprites[imageFader.currentSpriteIndex];
      imageFader.currentSpriteIndex = (imageFader.currentSpriteIndex + 1) % imageFader.sprites.Count;
      SpriteRenderer fadeIn = imageFader.isUsingFirstRenderer ? imageFader.spriteRenderer1 : imageFader.spriteRenderer2;
      SpriteRenderer fadeOut = imageFader.isUsingFirstRenderer ? imageFader.spriteRenderer2 : imageFader.spriteRenderer1;
      fadeIn.sprite = sprite;
      fadeIn.color = new Color(1f, 1f, 1f, 0.0f);
      yield return (object) imageFader.StartCoroutine(imageFader.FadeSprites(fadeIn, fadeOut));
      imageFader.isUsingFirstRenderer = !imageFader.isUsingFirstRenderer;
      yield return (object) new WaitForSeconds(imageFader.holdDuration);
    }
  }

  private IEnumerator FadeSprites(SpriteRenderer fadeIn, SpriteRenderer fadeOut)
  {
    float elapsedTime = 0.0f;
    while ((double) elapsedTime < (double) this.fadeDuration)
    {
      elapsedTime += Time.deltaTime;
      float t = elapsedTime / this.fadeDuration;
      fadeIn.color = new Color(1f, 1f, 1f, Mathf.Lerp(0.0f, 1f, t));
      fadeOut.color = new Color(1f, 1f, 1f, Mathf.Lerp(1f, 0.0f, t));
      yield return (object) null;
    }
    fadeIn.color = new Color(1f, 1f, 1f, 1f);
    fadeOut.color = new Color(1f, 1f, 1f, 0.0f);
  }
}
