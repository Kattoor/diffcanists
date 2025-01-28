
using UnityEngine;

public class Tower : MonoBehaviour
{
  public static readonly FixedInt AddedOffsetY = (FixedInt) -3250585L;
  public static readonly FixedInt CogTowerRadius = (FixedInt) 18874368L;
  public int MaxHealth = 75;
  public int Health = 75;
  internal ZTower serverObj;
  public Spell FromSpell;
  public TowerType type;
  public int radius;
  public int lowerRadius;
  public int colliderOffset;
  public ExplosionCutout cutout;
  [Tooltip("Height/2 - playerRadius")]
  public int playerOffsetY;
  [Tooltip("Check using Cutout in Hierarchy")]
  public int cutoutOffsetY;
  public Texture2D texture;
  private MyLocation _position;
  public MyCollider collider;
  internal MyCollider secondCollider;
  public Effector effector;
  public int firstChildYOffset;

  [ContextMenu("offset")]
  private void offset()
  {
    this.colliderOffset = (int) this.gameObject.transform.GetChild(0).transform.localPosition.y + 1;
  }
}
