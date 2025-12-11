
using System;
using UnityEngine;

public class AnimateDestroyStructure : MonoBehaviour
{
  private float speed;
  private float fillAmount;
  public SpriteRenderer sp;
  private Material mat;

  private void Start()
  {
    this.speed = (float) (this.sp.sprite.texture.height / 3);
    this.mat = this.GetComponent<SpriteRenderer>().material;
  }

  private void Update()
  {
    this.fillAmount += Time.deltaTime * 40f / this.speed;
    this.mat.SetFloat("_FillAmount", 1f - this.fillAmount);
    if ((double) this.fillAmount < 1.0)
      return;
    try
    {
      UnityEngine.Object.Destroy((UnityEngine.Object) this.sp.sprite);
    }
    catch (Exception ex)
    {
    }
    UnityEngine.Object.Destroy((UnityEngine.Object) this.gameObject);
  }
}
