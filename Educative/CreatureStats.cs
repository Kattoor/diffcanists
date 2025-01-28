
using System;
using System.Collections.Generic;

namespace Educative
{
  [Serializable]
  public class CreatureStats
  {
    public List<SpellSlot> spells = new List<SpellSlot>();
    public int radius = 5;
    public int health = 250;
    public int maxHealth = 250;
    public FixedInt speed = (FixedInt) 1;
    public bool affectedByGravity = true;
    public bool canMove = true;
    public bool usingGlide = true;
    public EditorFixedInt massMulti = (EditorFixedInt) 1f;
    public EditorFixedInt minAngle = (EditorFixedInt) -180;
    public EditorFixedInt maxAngle = (EditorFixedInt) 180;
    public int effectorMaxTurnsOverride = -1;
    public CreatureType type;
    public CreatureRace race;
    public EditorVector2 LongJumpData;
    public EditorVector2 HighJumpData;
    public bool flying;
    public bool mountable;
    public bool canMount;
    public bool phantom;
    public bool gliding;
    public bool waterWalking;
    public bool frostWalking;
  }
}
