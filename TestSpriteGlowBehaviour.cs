
using SpriteGlow;
using System.Collections;
using UnityEngine;

#nullable disable
public class TestSpriteGlowBehaviour : MonoBehaviour
{
  private IEnumerator Start()
  {
    SpriteGlowEffect spriteGlow = this.gameObject.AddComponent<SpriteGlowEffect>();
    yield return (object) new WaitForSeconds(0.5f);
    spriteGlow.enabled = false;
    yield return (object) new WaitForSeconds(0.5f);
    spriteGlow.enabled = true;
    yield return (object) new WaitForSeconds(0.5f);
    spriteGlow.OutlineWidth = 5;
    yield return (object) new WaitForSeconds(0.5f);
    spriteGlow.DrawOutside = true;
    yield return (object) new WaitForSeconds(0.5f);
    spriteGlow.DrawOutside = false;
    yield return (object) new WaitForSeconds(0.5f);
    spriteGlow.GlowColor = Color.red;
    yield return (object) new WaitForSeconds(0.5f);
    spriteGlow.GlowBrightness = 1.5f;
    yield return (object) new WaitForSeconds(0.5f);
    Object.Destroy((Object) spriteGlow);
  }
}
