
using System.Collections.Generic;
using UnityEngine;

public class WerewolfObject : MonoBehaviour
{
  private List<Sprite> sprites = new List<Sprite>();
  public SpriteRenderer body;
  public SpriteRenderer leftArm;
  public SpriteRenderer rightArm;

  internal void Init(ZPerson p, ZCreature creature, SettingsPlayer settingsPlayer, string name)
  {
    Color32 gray = settingsPlayer.coloring.colors[0].gray;
    settingsPlayer.coloring.colors[0].gray = settingsPlayer.coloring.colors[0].red;
    foreach (SpriteRenderer componentsInChild in this.GetComponentsInChildren<SpriteRenderer>(true))
    {
      if ((Object) componentsInChild.sprite != (Object) null && componentsInChild.sprite.texture.isReadable)
      {
        ConfigurePlayer.ApplyOutfit(componentsInChild, settingsPlayer);
        this.sprites.Add(componentsInChild.sprite);
      }
    }
    settingsPlayer.coloring.colors[2].gray = gray;
  }

  private void OnDestroy()
  {
    foreach (Sprite sprite in this.sprites)
    {
      if ((Object) sprite != (Object) null && sprite.texture.isReadable)
        Global.DestroySprite(sprite);
    }
  }
}
