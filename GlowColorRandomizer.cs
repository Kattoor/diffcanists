
using SpriteGlow;
using UnityEngine;

#nullable disable
[RequireComponent(typeof (SpriteGlowEffect))]
public class GlowColorRandomizer : MonoBehaviour
{
  private SpriteGlowEffect spriteGlow;

  private void Awake() => this.spriteGlow = this.GetComponent<SpriteGlowEffect>();

  private void OnEnable()
  {
    this.spriteGlow.enabled = true;
    this.spriteGlow.GlowColor = Random.ColorHSV();
    this.spriteGlow.GlowBrightness = Random.Range(2f, 4f);
  }

  private void OnDisable() => this.spriteGlow.enabled = false;
}
