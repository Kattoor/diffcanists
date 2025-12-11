
using Educative;
using System;
using System.Collections;
using UnityEngine;

public class Spell : Entity, ISpellBridge
{
  public static float[] _tomatoScale = new float[8]
  {
    2.56f,
    1.86f,
    1.46f,
    1.06f,
    1.06f,
    1.06f,
    1.06f,
    1.06f
  };
  public bool canHitSelf = true;
  public SpellEnum spellEnum;
  public SpellStats stats;
  [NonSerialized]
  internal SpellStats runTimeStats;
  internal ZSpell serverObj;
  public AudioClip castClip;
  public AudioClip explosionClip;
  public GameObject explosion;
  public GameObject toSummon;
  public Texture2D snowTexture;
  public ExplosionCutout snowCutout;
  public MyCollider collider;
  public MyCollider colliderB;
  public Effector effector;
  internal int spellIndex;
  private Renderer _renderer;
  public bool altBook;

  public void ScaleToZero()
  {
    this.StartCoroutine(this._ScaleToZero());
  }

  private IEnumerator _ScaleToZero()
  {
    Spell spell = this;
    float z = 1f;
    while ((double) spell.transform.localScale.y > 0.0)
    {
      float num = ClientResources.Instance.tomatoCurve.Evaluate(z);
      if ((double) num < 0.0)
        num = 0.0f;
      z -= Time.deltaTime;
      spell.transform.localScale = new Vector3(num, num, num);
      yield return (object) null;
    }
  }

  public int radius
  {
    get
    {
      return this.runTimeStats.radius;
    }
  }

  public int maxDistance
  {
    get
    {
      return this.runTimeStats.maxDistance;
    }
  }

  public bool affectedByGravity
  {
    get
    {
      return this.runTimeStats.affectedByGravity;
    }
  }

  public Renderer Renderer
  {
    get
    {
      return this._renderer;
    }
  }

  public void FindRenderer()
  {
    if (!((UnityEngine.Object) this._renderer == (UnityEngine.Object) null))
      return;
    this._renderer = this.GetComponent<Renderer>();
  }

  public SpellLogic spellLogic
  {
    get
    {
      return this.runTimeStats.spellLogic;
    }
  }

  public SpellType spellType
  {
    get
    {
      return this.runTimeStats.spellType;
    }
  }

  public TargetType targetType
  {
    get
    {
      return this.runTimeStats.targetType;
    }
  }

  public int level
  {
    get
    {
      return this.runTimeStats.level;
    }
  }

  public EditorFixedInt speedMin
  {
    get
    {
      return this.runTimeStats.speedMin;
    }
  }

  public EditorFixedInt speedMax
  {
    get
    {
      return this.runTimeStats.speedMax;
    }
  }

  public EditorFixedInt speedFlying
  {
    get
    {
      return this.runTimeStats.speedFlying;
    }
  }

  public EditorFixedInt speedRotation
  {
    get
    {
      return this.runTimeStats.speedRotation;
    }
  }

  public int maxDuration
  {
    get
    {
      return this.runTimeStats.maxDuration;
    }
  }

  public EditorFixedInt elasticity
  {
    get
    {
      return this.runTimeStats.elasticity;
    }
  }

  public int damage
  {
    get
    {
      return this.runTimeStats.damage;
    }
  }

  public DamageType damageType
  {
    get
    {
      return this.runTimeStats.damageType;
    }
  }

  public int EXORADIUS
  {
    get
    {
      return this.runTimeStats.EXORADIUS;
    }
  }

  public EditorFixedInt explisiveForce
  {
    get
    {
      return this.runTimeStats.explisiveForce;
    }
  }

  public ExplosionCutout explosionCutout
  {
    get
    {
      return this.runTimeStats.explosionCutout;
    }
  }

  public Curve damageOverDistance
  {
    get
    {
      return this.runTimeStats.damageOverDistance;
    }
  }

  public Curve forceOverDistance
  {
    get
    {
      return this.runTimeStats.forceOverDistance;
    }
  }

  public bool explodeOnImpact
  {
    get
    {
      return this.runTimeStats.explodeOnImpact;
    }
  }

  public int frameOfPhantom
  {
    get
    {
      return this.runTimeStats.frameOfPhantom;
    }
  }

  public bool goToTarget
  {
    get
    {
      return this.runTimeStats.goToTarget;
    }
  }

  public int maxTargetFrames
  {
    get
    {
      return this.runTimeStats.maxTargetFrames;
    }
  }

  public bool Rotates
  {
    get
    {
      return this.runTimeStats.Rotates;
    }
  }

  public bool EndsTurn
  {
    get
    {
      return this.runTimeStats.EndsTurn;
    }
  }

  public int MaxUses
  {
    get
    {
      return this.runTimeStats.MaxUses;
    }
  }

  public int RechargeTime
  {
    get
    {
      return this.runTimeStats.RechargeTime;
    }
  }

  public int TurnsTillFirstUse
  {
    get
    {
      return this.runTimeStats.TurnsTillFirstUse;
    }
  }

  public bool halfFirstTurn
  {
    get
    {
      return this.runTimeStats.halfFirstTurn;
    }
  }

  public CastType type
  {
    get
    {
      return this.runTimeStats.type;
    }
  }

  public BookOf bookOf
  {
    get
    {
      return this.runTimeStats.bookOf;
    }
  }

  public int amount
  {
    get
    {
      return this.runTimeStats.amount;
    }
  }

  public int MaxMinionCount
  {
    get
    {
      return this.runTimeStats.MaxMinionCap;
    }
  }

  public int Bounces
  {
    get
    {
      return this.runTimeStats.Bounces;
    }
  }

  public EditorFixedInt CustomGravity
  {
    get
    {
      return this.runTimeStats.CustomGravity;
    }
  }

  public bool hitPhantom
  {
    get
    {
      return this.runTimeStats.hitPhantom;
    }
  }

  public bool destroyTerrainFirstBounce
  {
    get
    {
      return this.runTimeStats.destroyTerrainFirstBounce;
    }
  }

  public int destroyTerrainBounces
  {
    get
    {
      return this.runTimeStats.destroyTerrainBounces;
    }
  }

  public int maxSandDamage
  {
    get
    {
      return this.runTimeStats.maxSandDamage;
    }
  }

  public static bool IsMinionSpell(SpellEnum e)
  {
    return ZSpell.MinionSpells.Contains(e);
  }

  public bool IsMinionSpell()
  {
    return ZSpell.MinionSpells.Contains(this.spellEnum);
  }

  public SpellType GetSpellType
  {
    get
    {
      return this.spellType;
    }
  }

  public string GetName
  {
    get
    {
      return this.name;
    }
  }

  public SpellEnum GetSpellEnum
  {
    get
    {
      return this.spellEnum;
    }
  }

  public BookOf book
  {
    get
    {
      return this.bookOf;
    }
  }

  public bool FromArmageddon
  {
    get
    {
      return false;
    }
  }

  public ZCreature GetParent
  {
    get
    {
      return (ZCreature) null;
    }
  }

  public bool GetGoToTarget
  {
    get
    {
      return this.goToTarget;
    }
  }

  public GameObject GetToSummon
  {
    get
    {
      return this.toSummon;
    }
  }

  public Spell GetBaseSpell
  {
    get
    {
      return this;
    }
  }

  public ExplosionCutout GetExplosionCutout
  {
    get
    {
      return this.explosionCutout;
    }
  }

  public int GetDamage
  {
    get
    {
      return this.runTimeStats.damage;
    }
  }

  public DamageType GetDamageType
  {
    get
    {
      return this.damageType;
    }
  }
}
