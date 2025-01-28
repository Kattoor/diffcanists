
using System;
using System.Collections.Generic;
using UnityEngine;

public static class Armageddon
{
  public static HashSet<SpellEnum> ApparitionExcludedSpells = new HashSet<SpellEnum>()
  {
    SpellEnum.Flight,
    SpellEnum.Ice_Shield,
    SpellEnum.Lichdom,
    SpellEnum.Shining_Power,
    SpellEnum.Invulnerability_Shield,
    SpellEnum.Vine_Bloom,
    SpellEnum.Nature_s_Wrath,
    SpellEnum.Glide,
    SpellEnum.Apparition,
    SpellEnum.Grove_Renewal,
    SpellEnum.Bear_Form,
    SpellEnum.Abduction
  };
  public static HashSet<SpellEnum> ApparitionFriendlySpells = new HashSet<SpellEnum>()
  {
    SpellEnum.Sphere_of_Healing,
    SpellEnum.Thanksgiving_Dinner,
    SpellEnum.Vortex,
    SpellEnum.Healing_Spores,
    SpellEnum.Blood_Mist
  };

  public static ZCreature GetRandomTarget(ZPerson p)
  {
    List<ZCreature> zcreatureList = new List<ZCreature>();
    foreach (ZPerson player in p.game.players)
    {
      foreach (ZCreature zcreature in player.controlled)
      {
        if ((ZComponent) zcreature != (object) null && !zcreature.isDead)
          zcreatureList.Add(zcreature);
      }
    }
    return zcreatureList.Count <= 0 ? (ZCreature) null : zcreatureList[p.game.RandomInt(0, zcreatureList.Count)];
  }

  public static void CustomArmageddon(ZPerson p)
  {
    if (p.game.customArmageddon == null)
    {
      p.game.customArmageddon = new List<Spell>();
      foreach (SpellEnum s in p.game.gameFacts.settings.customArmageddon)
      {
        Spell spell = Inert.GetSpell(s);
        if ((UnityEngine.Object) spell != (UnityEngine.Object) null && (spell.level < 4 || GameFacts.AllowCustomArmageddon(spell.spellEnum)))
          p.game.customArmageddon.Add(spell);
      }
    }
    if (p.localTurn < p.game.armageddonTurn || (ZComponent) p.first() == (object) null || (p.first().isDead || p.controlled.Count == 0))
      return;
    p.game.ongoing.forceArmageddon = true;
    if (p.lastArmageddon < 0)
      p.lastArmageddon = 0;
    ++p.lastArmageddon;
    float transformscale = p.first().transformscale;
    for (int index = 0; index < p.game.customArmageddon.Count; ++index)
    {
      if (!((ZComponent) p.first() == (object) null) && !p.first().isDead)
      {
        Spell theSpell = p.game.customArmageddon[index];
        if ((UnityEngine.Object) theSpell != (UnityEngine.Object) null && (theSpell.level <= 1 || p.lastArmageddon % theSpell.level == 1))
        {
          int xInt = p.game.RandomInt(100, Mathf.Min(p.map.Width - 100, Mathf.Max(1, p.localTurn - p.game.armageddonTurn) * 100));
          if (p.game.RandomInt(0, 10) >= 5)
            xInt = p.map.Width - xInt;
          MyLocation pos1 = new MyLocation(xInt, p.game.RandomInt(0, p.map.Height));
          int num = xInt > p.map.Width / 2 ? p.game.RandomInt(90, 180) : p.game.RandomInt(-90, 90);
          if (theSpell.type == CastType.TargetOnly)
          {
            p.first().SetScale(xInt > p.map.Width / 2 ? -1f : 1f);
            if (theSpell.spellEnum == SpellEnum.Curse_of_Disabling || theSpell.spellEnum == SpellEnum.Curse_of_Loneliness)
              ZSpell.FireWhich(theSpell, p.first(), pos1, (FixedInt) 0, (FixedInt) num, p.first().position, p.first().position, 0, false, (SpellSlot) null, true);
            else
              ZSpell.FireWhich(theSpell, p.first(), pos1, (FixedInt) 0, (FixedInt) num, new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), 0, false, (SpellSlot) null, true);
          }
          else if (theSpell.type == CastType.Target_Power || theSpell.type == CastType.Power)
          {
            pos1.y = (FixedInt) p.map.Height;
            ZSpell.FireWhich(theSpell, p.first(), pos1, (FixedInt) num, (FixedInt) 1 / (FixedInt) 2, new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), 0, false, (SpellSlot) null, true);
          }
          else if (theSpell.type == CastType.Flash || theSpell.type == CastType.Naplem)
          {
            if (theSpell.spellEnum == SpellEnum.Abduction)
            {
              MyLocation pos2 = new MyLocation(p.first().position.x + p.game.RandomInt(-125, 125), p.first().position.y + p.game.RandomInt(75, 125));
              MyLocation myLocation = p.first().position - pos2;
              myLocation.Normalize();
              FixedInt rot_z = FixedInt.Atan2(myLocation.y, myLocation.x) * FixedInt.Rad2Deg;
              ZSpell.FireWhich(theSpell, p.first(), pos2, rot_z, (FixedInt) 1, new MyLocation(), new MyLocation(), 0, false, (SpellSlot) null, true);
            }
            else
              ZSpell.FireWhich(theSpell, p.first(), new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), (FixedInt) num, (FixedInt) 1, new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), 0, false, (SpellSlot) null, true);
          }
          else if (theSpell.type == CastType.Double_Naplem)
            ZSpell.FireWhich(theSpell, p.first(), new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), (FixedInt) num, (FixedInt) 1, new MyLocation(xInt > p.map.Width / 2 ? p.game.RandomInt(90, 180) : p.game.RandomInt(-90, 90), p.game.RandomInt(0, p.map.Height)), new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), 0, false, (SpellSlot) null, true);
          else if (theSpell.type == CastType.Target_Placement)
          {
            if (theSpell.spellEnum == SpellEnum.Duplication)
            {
              ZCreature randomTarget = Armageddon.GetRandomTarget(p);
              if (!((ZComponent) randomTarget == (object) null))
                ZSpell.FireWhich(theSpell, p.first(), pos1, (FixedInt) p.game.RandomInt(0, 360), (FixedInt) num, new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), randomTarget.position, 0, false, (SpellSlot) null, true);
            }
            else
              ZSpell.FireWhich(theSpell, p.first(), pos1, (FixedInt) p.game.RandomInt(0, 360), (FixedInt) num, new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), 0, false, (SpellSlot) null, true);
          }
          else if (theSpell.type == CastType.Placement)
          {
            if (theSpell.amount <= 0 || p.GetMaxMinions() > theSpell.amount + p.controlled.Count)
            {
              if (theSpell.spellEnum == SpellEnum.Resurrection)
              {
                if (p.game.lastMinionToDie.Count != 0)
                  num = p.game.RandomInt(0, p.game.lastMinionToDie.Count);
                else
                  continue;
              }
              if (theSpell.spellEnum == SpellEnum.Summon_Titan)
                num = p.game.RandomInt(0, p.minionBookTitans.Count);
              ZSpell.FireWhich(theSpell, p.first(), new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), (FixedInt) num, (FixedInt) 1, new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), 0, false, (SpellSlot) null, true);
            }
          }
          else if (theSpell.type == CastType.Blit)
            ZSpell.FireWhich(theSpell, p.first(), pos1, (FixedInt) 0, (FixedInt) num, new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), 0, false, (SpellSlot) null, true);
          else if (theSpell.type == CastType.Flight)
            ZSpell.FireWhich(theSpell, p.first(), pos1, (FixedInt) 0, (FixedInt) num, new MyLocation(0, 0), new MyLocation(0, 0), 0, false, (SpellSlot) null, true);
          else if (theSpell.type == CastType.Tower && (ZComponent) p.first().tower == (object) null)
            ZSpell.FireWhich(theSpell, p.first(), pos1, (FixedInt) 0, (FixedInt) num, new MyLocation(0, 0), new MyLocation(0, 0), 0, false, (SpellSlot) null, true);
        }
      }
    }
    if (!((ZComponent) p.first() != (object) null) || p.first().isDead)
      return;
    p.first().SetScale(transformscale);
  }

  private static void Grassy_Hills(ZPerson p)
  {
  }

  private static void Giants_Mountains(ZPerson p)
  {
    if (p.localTurn <= p.lastArmageddon + 2)
      return;
    p.lastArmageddon = p.localTurn;
    int xInt = p.game.RandomInt(100, Mathf.Min(p.map.Width - 100, Mathf.Max(1, p.localTurn - p.game.armageddonTurn) * 100));
    if (p.game.RandomInt(0, 10) >= 5)
      xInt = p.map.Width - xInt;
    ZSpell.FireVolcano(Inert.Instance.ArmageddonObjects[GameFacts.GetMapIndex(p.game.armageddon)], p.controlled[0], new MyLocation(xInt, -300), true);
  }

  private static void Elven_Isles(ZPerson p)
  {
    int xInt = p.game.RandomInt(100, Mathf.Min(p.map.Width - 100, Mathf.Max(1, p.localTurn - p.game.armageddonTurn) * 100));
    if (p.game.RandomInt(0, 10) >= 5)
      xInt = p.map.Width - xInt;
    ZSpell.FireCometArmageddon(Inert.Instance.ArmageddonObjects[GameFacts.GetMapIndex(p.game.armageddon)], p, new MyLocation(xInt, 50));
  }

  private static void Goblin_Caves(ZPerson p)
  {
    if (p.localTurn < 20 && p.localTurn <= p.lastArmageddon + 2 || p.localTurn >= 20 && p.localTurn <= p.lastArmageddon + 1)
      return;
    p.lastArmageddon = p.localTurn;
    int xInt = p.game.RandomInt(100, Mathf.Min(p.map.Width - 100, Mathf.Max(1, p.localTurn - p.game.armageddonTurn) * 100));
    if (p.game.RandomInt(0, 10) >= 5)
      xInt = p.map.Width - xInt;
    ZSpell.FireVolcano(Inert.Instance.ArmageddonObjects[GameFacts.GetMapIndex(p.game.armageddon)], p.controlled[0], new MyLocation(xInt, -300), true);
  }

  private static void Murkey_Swamp(ZPerson p)
  {
    int xInt = p.game.RandomInt(50, Mathf.Min(p.map.Width - 50, Mathf.Max(1, p.localTurn - p.game.armageddonTurn) * 100));
    if (p.game.RandomInt(0, 10) >= 5)
      xInt = p.map.Width - xInt;
    ZSpell.FireStorm(Inert.Instance.ArmageddonObjects[GameFacts.GetMapIndex(p.game.armageddon)], p.controlled[0], new MyLocation(xInt, 0), 300, true);
  }

  private static void Graveyard(ZPerson p)
  {
    int xInt = p.game.RandomInt(100, Mathf.Min(p.map.Width - 100, Mathf.Max(1, p.localTurn - p.game.armageddonTurn) * 100));
    if (p.game.RandomInt(0, 10) >= 5)
      xInt = p.map.Width - xInt;
    ZSpell.FireRainOfChaos(Inert.Instance.ArmageddonObjects[GameFacts.GetMapIndex(p.game.armageddon)], p.first(), new MyLocation(xInt, 0), true);
  }

  private static void Desert(ZPerson p)
  {
    if (p.localTurn % 2 != 0 && p.localTurn <= 20)
      return;
    int xInt = p.game.RandomInt(100, Mathf.Min(p.map.Width - 100, Mathf.Max(1, p.localTurn - p.game.armageddonTurn) * 100));
    if (p.game.RandomInt(0, 10) >= 5)
      xInt = p.map.Width - xInt;
    ZSpell.FireBurningSands(Inert.Instance.ArmageddonObjects[GameFacts.GetMapIndex(p.game.armageddon)], p.first(), new MyLocation(xInt, 0), 25, true);
  }

  private static void Sky_Castles(ZPerson p)
  {
    int xInt = p.game.RandomInt(100, Mathf.Min(p.map.Width - 100, Mathf.Max(1, p.localTurn - p.game.armageddonTurn) * 100));
    if (p.game.RandomInt(0, 10) >= 5)
      xInt = p.map.Width - xInt;
    Spell armageddonObject = Inert.Instance.ArmageddonObjects[GameFacts.GetMapIndex(p.game.armageddon)];
    p.game.ongoing.RunSpell(ZSpell.FireSkyRay(armageddonObject, p.first(), new MyLocation(xInt, 0), true), true);
    if (!p.game.isClient)
      return;
    AudioManager.Play(armageddonObject.castClip);
  }

  private static void Mos_LeHarmless(ZPerson p)
  {
    int xInt = p.game.RandomInt(100, p.map.Width - 100);
    Spell armageddonObject = Inert.Instance.ArmageddonObjects[GameFacts.GetMapIndex(p.game.armageddon)];
    ZSpell.FireSummon(armageddonObject, p.game, p.controlled[0], new MyLocation(xInt, p.map.Height + armageddonObject.radius + 50), -1, false, (ZPerson) null);
  }

  private static void Arcane_Crystals(ZPerson p)
  {
    int xInt = p.game.RandomInt(100, Mathf.Min(p.map.Width - 100, Mathf.Max(1, p.localTurn - p.game.armageddonTurn) * 100));
    if (p.game.RandomInt(0, 10) >= 5)
      xInt = p.map.Width - xInt;
    Spell armageddonObject = Inert.Instance.ArmageddonObjects[GameFacts.GetMapIndex(MapEnum.Arcane_Crystals)];
    MyLocation target = new MyLocation(xInt, -300);
    int amount = 6 + Mathf.Min(p.localTurn - 10, 10);
    if (p.localTurn > 20)
    {
      target = p.controlled[0].position;
    }
    else
    {
      List<ZCreature> zcreatureList = new List<ZCreature>();
      if (p.controlled.Count > 1)
      {
        for (int index = 1; index < p.controlled.Count; ++index)
        {
          if (p.controlled[index].type == CreatureType.Imp)
            zcreatureList.Add(p.controlled[index]);
        }
      }
      if (zcreatureList.Count == 0)
      {
        foreach (ZPerson player in p.game.players)
        {
          if (player.controlled.Count > 1)
          {
            for (int index = 1; index < player.controlled.Count; ++index)
            {
              if (player.controlled[index].type == CreatureType.Imp)
                zcreatureList.Add(player.controlled[index]);
            }
          }
        }
      }
      if (zcreatureList.Count > 0)
      {
        int index = p.game.RandomInt(0, zcreatureList.Count);
        target = zcreatureList[index].position;
      }
      else
        target = new MyLocation(p.map.Width - xInt, p.game.RandomInt(200, 500));
    }
    p.game.ongoing.RunSpell(ZSpell.IEnumeratorArcaneArrows(armageddonObject, p.controlled[0], new MyLocation(xInt, 0), Quaternion.identity, (FixedInt) 90, (FixedInt) 1, amount, target, p.controlled[0].HasArcaneEnergizer ? (int) ((FixedInt) armageddonObject.damage * (FixedInt) 1572864L) : 0, true), true);
  }

  private static void Snowy_Hills(ZPerson p)
  {
    ZCreature c = p.first();
    ZSpell.FireRainOfClams(Inert.Instance.spells["Presents!"], c, c.position, 1, true, true);
  }

  private static void Ocean_Floor(ZPerson p)
  {
    ZCreature c = p.first();
    int xInt = p.game.RandomInt(100, Mathf.Min(p.map.Width - 100, Mathf.Max(1, p.localTurn - p.game.armageddonTurn) * 100));
    if (p.game.RandomInt(0, 10) >= 5)
      xInt = p.map.Width - xInt;
    ZSpell.FireRainOfClams(Inert.Instance.clamOceanFloor, c, new MyLocation(xInt, 50), Mathf.Max(1, p.localTurn / 10), true, true);
    if (p.localTurn % 5 != 0)
      return;
    p.lastArmageddon = p.localTurn;
    p.game.ongoing.RunSpell(Armageddon.IEnumeratorSeaSalt(p, Inert.Instance.seaSalt, 25, true), true);
  }

  private static void Dark_Fortress(ZPerson p)
  {
    if (p.localTurn != p.game.armageddonTurn || p.game.globalEffectors.FindIndex((Predicate<ZEffector>) (a => (ZComponent) a != (object) null && a.type == EffectorType.Rising_Lava)) != -1)
      return;
    ZSpell.FireRisingLava(Inert.Instance.ArmageddonObjects[GameFacts.GetMapIndex(MapEnum.Dark_Fortress)], p.game);
    ZSpell.FireDenseFog(Inert.GetSpell(SpellEnum.Dense_Fog), p.game);
  }

  private static void Jungle(ZPerson p)
  {
    if (p.localTurn < 20 && p.localTurn <= p.lastArmageddon + 2)
      return;
    p.lastArmageddon = p.localTurn;
    ZCreature c = p.first();
    Spell spell = Inert.Instance.spells["Summon Dark Totem"];
    int xInt = p.game.RandomInt(100, Mathf.Min(p.map.Width - 100, Mathf.Max(1, p.localTurn - p.game.armageddonTurn) * 100));
    if (p.game.RandomInt(0, 10) >= 5)
      xInt = p.map.Width - xInt;
    ZCreature zcreature = ZSpell.FireSummon(spell, p.game, c, new MyLocation(xInt, p.game.RandomInt(30, p.map.Height - 30)), 1, false, (ZPerson) null);
    p.controlled.Remove(zcreature);
    if (ZComponent.IsNull((ZComponent) zcreature) || zcreature.isDead)
      return;
    if (p.game.isClient)
    {
      zcreature.bg.gameObject.SetActive(false);
      p.panelPlayer?.SetSummons(p);
      AudioManager.Play(spell.castClip);
    }
    p.game.globalEffectors.Add(new ZEffector()
    {
      game = c.game,
      type = EffectorType.DieNSpawnVoid,
      MaxTurnsAlive = 4,
      whoSummoned = zcreature,
      active = false
    });
    zcreature.effectors[0].TurnPassed(0, false, false);
    zcreature.game._uncontrolledPlayer.controlled.Add(zcreature);
    zcreature.daOriginalTrueParent = p;
    zcreature.parent = zcreature.game._uncontrolledPlayer;
  }

  private static void Wasteland(ZPerson p)
  {
    ZCreature c = p.first();
    if (p.localTurn % 2 == 0)
    {
      int xInt = p.game.RandomInt(100, Mathf.Min(p.map.Width - 100, Mathf.Max(1, p.localTurn - p.game.armageddonTurn) * 100));
      if (p.game.RandomInt(0, 10) >= 5)
        xInt = p.map.Width - xInt;
      ZSpell.FireStorm(Inert.Instance.ArmageddonObjects[GameFacts.GetMapIndex(p.game.armageddon)], p.controlled[0], new MyLocation(xInt, 0), 300, true);
    }
    else
    {
      switch (p.game.RandomInt(0, 2))
      {
        case 0:
          Spell spell1 = Inert.Instance.spells["Clockwork Bomb"];
          ZSpell.FireGenericReturn(spell1, c, new MyLocation(p.game.RandomInt(200, p.map.Width - 200), p.map.Height), (FixedInt) p.game.RandomInt(75, 115), (FixedInt) 262144L);
          if (p.game.isClient)
          {
            AudioManager.Play(spell1.castClip);
            break;
          }
          break;
        case 1:
          Spell spell2 = Inert.Instance.spells["Static Ball"];
          ZSpell.FireGenericReturn(spell2, c, new MyLocation(p.game.RandomInt(200, p.map.Width - 200), p.game.RandomInt(200, p.map.Height - 200)), (FixedInt) 0, (FixedInt) 0).curDuration = 900;
          if (p.game.isClient)
          {
            AudioManager.Play(spell2.castClip);
            break;
          }
          break;
      }
    }
    if (p.localTurn != 25 || p.game.armageddonTurnVariable == 25)
      return;
    p.game.armageddonTurnVariable = 25;
    Spell spell3 = Inert.Instance.spells["Redo"];
    ZSpell.FireRedo(spell3, c, true, false);
    if (!p.game.isClient)
      return;
    AudioManager.Play(spell3.castClip);
  }

  private static void Arcana_te_Deum(ZPerson p)
  {
    int xInt = p.game.RandomInt(100, Mathf.Min(p.map.Width - 100, Mathf.Max(1, p.localTurn - p.game.armageddonTurn) * 100));
    if (p.game.RandomInt(0, 10) >= 5)
      xInt = p.map.Width - xInt;
    ZSpell.FireCometArmageddon(Inert.Instance.ArmageddonObjects[GameFacts.GetMapIndex(p.game.armageddon)], p, new MyLocation(xInt, 50));
  }

  private static void AlienWorld(ZPerson p)
  {
    int num = Mathf.Max(1, p.localTurn / 10) * 2;
    Spell armageddonObject = Inert.Instance.ArmageddonObjects[GameFacts.GetMapIndex(p.game.armageddon)];
    for (int index = 0; index < num; ++index)
    {
      MyLocation myLocation = new MyLocation(p.game.RandomInt(0, 10) >= 5 ? -1000 : p.game.map.Width + 1000, p.game.map.Height + 100);
      MyLocation a = new MyLocation(p.game.RandomInt(0, p.game.map.Width), p.game.RandomInt(0, p.game.map.Height));
      ZSpell zspell = ZSpell.BaseFire(armageddonObject, p, myLocation, Quaternion.identity, Inert.Velocity(Inert.AngleOfVectors(a, myLocation)) * 40, true, false);
      zspell.fromArmageddon = true;
      zspell.maxDuration -= p.game.RandomInt(0, 30);
    }
  }

  private static void GhostlyHalls(ZPerson p)
  {
    if ((p.localTurn - p.game.armageddonTurn) % 3 != 0 || ZComponent.IsNull((ZComponent) p.first()) || p.GetMaxMinions() <= p.GetMinionCount())
      return;
    ZCreature duplicate = ZSpell.CreateDuplicate(p.first(), p.first(), new MyLocation(p.game.RandomInt(50, p.game.map.Width - 50), p.game.RandomInt(50, p.game.map.Height - 50)), true);
    if (ZComponent.IsNull((ZComponent) duplicate))
      return;
    duplicate.spells.Clear();
    duplicate.spells.Add(new SpellSlot(Inert.GetSpell(SpellEnum.Whisper_Bomb)));
    duplicate.spells.Add(new SpellSlot(Inert.GetSpell(SpellEnum.Air_Surge)));
    duplicate.spells.Add(new SpellSlot(Inert.GetSpell(SpellEnum.Whisper_Arrow)));
    duplicate.spells.Add(new SpellSlot(Inert.GetSpell(SpellEnum.Color_Spray)));
    duplicate.spells.Add(new SpellSlot(Inert.GetSpell(SpellEnum.Summon_Phantom)));
    duplicate.spells.Add(new SpellSlot(Inert.GetSpell(SpellEnum.Magical_Barrier)));
    duplicate.spells.Add(new SpellSlot(Inert.GetSpell(SpellEnum.Vortex)));
    duplicate.spells.Add(new SpellSlot(Inert.GetSpell(SpellEnum.The_ol_swaparoo)));
    duplicate.spells.Add(new SpellSlot(Inert.GetSpell(SpellEnum.Blink)));
    duplicate.spells.Add(new SpellSlot(Inert.GetSpell(SpellEnum.Arcane_Arrow)));
    duplicate.spells.Add(new SpellSlot(Inert.GetSpell(SpellEnum.Arcane_Bomb)));
    duplicate.spells.Add(new SpellSlot(Inert.GetSpell(SpellEnum.Arcane_Flash)));
    duplicate.spells.Add(new SpellSlot(Inert.GetSpell(SpellEnum.Arcane_Sigil)));
    duplicate.controllable = false;
    duplicate.effectors.Add(new ZEffector()
    {
      game = p.game,
      active = false,
      type = EffectorType.ApparitionArmageddon,
      MaxTurnsAlive = -1,
      whoSummoned = duplicate
    });
    ZSpell.FireApparition(duplicate, true, false);
    p.map.ServerBitBlt(13, (int) duplicate.position.x, (int) duplicate.position.y, true, true);
    ZSpell.ApplyExplosionForce(SpellEnum.Duplication, duplicate.world, duplicate.position, 0, Curve.None, 10, 75, (FixedInt) 0, DamageType.None, duplicate, duplicate.game.turn, Curve.Generic, (ISpellBridge) null, (ZCreature) null);
    if (!duplicate.game.isClient)
      return;
    AudioManager.Play(Inert.GetSpell(SpellEnum.Duplication).castClip);
  }

  public static IEnumerator<float> IEnumeratorSeaSalt(
    ZPerson c,
    Spell spell,
    int amount,
    bool armageddon = false)
  {
    for (int i = 0; i < amount; ++i)
    {
      for (int index = 0; index < 4; ++index)
        ZSpell.BaseFire(spell, c, new MyLocation(c.game.RandomInt(0, c.map.Width), c.map.Height + 100), Quaternion.identity, new MyLocation(0, c.game.RandomInt(-20, -10)), true, false).fromArmageddon = armageddon;
      yield return 0.0f;
    }
  }

  public static void NextTurn(ZPerson p)
  {
    if (p.localTurn < p.game.armageddonTurn || p.controlled.Count == 0)
      return;
    switch (p.game.armageddon)
    {
      case MapEnum.Jungle:
        Armageddon.Jungle(p);
        break;
      case MapEnum.Snowy_Hills:
        Armageddon.Snowy_Hills(p);
        break;
      case MapEnum.Ocean_Floor:
        Armageddon.Ocean_Floor(p);
        break;
      case MapEnum.Dark_Fortress:
        Armageddon.Dark_Fortress(p);
        break;
      case MapEnum.Wasteland:
        Armageddon.Wasteland(p);
        break;
      case MapEnum.Grassy_Hills:
        Armageddon.Grassy_Hills(p);
        break;
      case MapEnum.Giants_Mountains:
        Armageddon.Giants_Mountains(p);
        break;
      case MapEnum.Elven_Isles:
        Armageddon.Elven_Isles(p);
        break;
      case MapEnum.Goblin_Caves:
        Armageddon.Goblin_Caves(p);
        break;
      case MapEnum.Murky_Swamp:
        Armageddon.Murkey_Swamp(p);
        break;
      case MapEnum.Graveyard:
        Armageddon.Graveyard(p);
        break;
      case MapEnum.Sky_Castles:
        Armageddon.Sky_Castles(p);
        break;
      case MapEnum.Mos_LeHarmless:
        Armageddon.Mos_LeHarmless(p);
        break;
      case MapEnum.Arcane_Crystals:
        Armageddon.Arcane_Crystals(p);
        break;
      case MapEnum.Alien_World:
        Armageddon.AlienWorld(p);
        break;
      case MapEnum.Ghostly_Halls:
        Armageddon.GhostlyHalls(p);
        break;
      case MapEnum.Desert:
        Armageddon.Desert(p);
        break;
      case MapEnum.Space_Nexus:
        Armageddon.Arcana_te_Deum(p);
        break;
    }
  }
}
