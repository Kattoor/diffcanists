
using System.Collections.Generic;
using UnityEngine;

#nullable disable
public class MouthOverride : MonoBehaviour
{
  public List<Sprite> sprites = new List<Sprite>();
  public SpriteRenderer r;

  public void Start()
  {
    Creature componentInParent = this.GetComponentInParent<Creature>();
    if (!((Object) componentInParent != (Object) null))
      return;
    this.r.sprite = this.sprites[componentInParent.serverObj?.parent == null ? 0 : (int) componentInParent.serverObj.parent.settingsPlayer.indexMouth % this.sprites.Count];
  }
}
