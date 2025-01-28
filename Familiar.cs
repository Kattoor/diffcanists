
using UnityEngine;

public class Familiar : MonoBehaviour
{
  internal ZFamiliar serverObj;
  public BookOf bookOf;

  public ZCreature creature
  {
    get
    {
      return this.serverObj.creature;
    }
  }

  public MyLocation position
  {
    get
    {
      return this.serverObj.position;
    }
  }

  public void ColorFamiliar()
  {
    if (!Client.game.isClient || ZComponent.IsNull((ZComponent) this.creature) || this.creature.parent == null)
      return;
    AnimateRepeat component = this.GetComponent<AnimateRepeat>();
    Sprite[] sprites = component.sprites;
    component.deleteOnDestroy = true;
    int length = sprites.Length;
    for (int index = 0; index < length; ++index)
      sprites[index] = ConfigurePlayer.ApplyOutfit(sprites[index], this.creature.parent.settingsPlayer);
    this.GetComponent<SpriteRenderer>().sprite = sprites[0];
  }

  internal Vector3 GetOffset()
  {
    switch (this.bookOf)
    {
      case BookOf.Arcane:
        return new Vector3(30f, 20f, 0.0f);
      case BookOf.Flame:
        return new Vector3(20f, 20f, 0.0f);
      case BookOf.Stone:
        return new Vector3(20f, 0.0f, 0.0f);
      case BookOf.Storm:
        return new Vector3(0.0f, 45f, 0.0f);
      case BookOf.Frost:
        return new Vector3(25f, 0.0f, 0.0f);
      case BookOf.OverLight:
        return new Vector3(18f, 18f, 0.0f);
      case BookOf.Nature:
        return new Vector3(0.0f, 12f, 0.0f);
      case BookOf.Seas:
        return new Vector3(22f, 0.0f, 0.0f);
      case BookOf.Cogs:
        return new Vector3(23f, 23f, 0.0f);
      case BookOf.Seasons:
        return new Vector3(15f, 15f, 0.0f);
      case BookOf.Illusion:
        return new Vector3(20f, 20f, 0.0f);
      case BookOf.Blood:
        return new Vector3(20f, 22f, 0.0f);
      case BookOf.Druidism:
        return new Vector3(20f, 23f, 0.0f);
      case BookOf.Cosmos:
        return new Vector3(18f, 25f, 0.0f);
      case BookOf.Sands:
        return new Vector3(28f, 0.0f, 0.0f);
      default:
        return Vector3.zero;
    }
  }

  protected virtual void LateUpdate()
  {
    if (ZComponent.IsNull((ZComponent) this.creature))
    {
      Object.Destroy((Object) this.gameObject);
    }
    else
    {
      int num = this.creature.game.isClient ? 1 : 0;
    }
  }
}
