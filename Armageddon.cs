
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
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

  public static int CountCustomArmageddon(ZGame game, SpellEnum spell)
  {
    if (game == null || game.gameFacts == null || game.gameFacts.settings == null || game.gameFacts.settings.customArmageddon == null)
      return 0;
    int num = 0;
    foreach (SpellEnum spellEnum in game.gameFacts.settings.customArmageddon)
    {
      if (spellEnum == spell)
        ++num;
    }
    return num;
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
    if (p.localTurn < p.game.armageddonTurn - 1 || (ZComponent) p.first() == (object) null || p.first().isDead || p.controlled.Count == 0)
      return;
    if (p.armaWarnings.Count == 0)
    {
      for (int index = 0; index < p.game.customArmageddon.Count; ++index)
        p.AddArmaWarning();
    }
    else
    {
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
            int xInt = p.DequeueArmaWarning();
            p.AddArmaWarning();
            MyLocation pos1 = new MyLocation(xInt, p.game.RandomInt(0, p.map.Height));
            int num = xInt > p.map.Width / 2 ? p.game.RandomInt(90, 180) : p.game.RandomInt(-90, 90);
            if (theSpell.type == CastType.TargetOnly)
            {
              p.first().SetScale(xInt > p.map.Width / 2 ? -1f : 1f);
              if (theSpell.spellEnum == SpellEnum.Curse_of_Disabling || theSpell.spellEnum == SpellEnum.Curse_of_Loneliness)
                ZSpell.FireWhich(theSpell, p.first(), pos1, (FixedInt) 0, (FixedInt) num, p.first().position, p.first().position, fromArmageddon: true);
              else
                ZSpell.FireWhich(theSpell, p.first(), pos1, (FixedInt) 0, (FixedInt) num, new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), fromArmageddon: true);
            }
            else if (theSpell.type == CastType.Target_Power || theSpell.type == CastType.Power)
            {
              pos1.y = (FixedInt) p.map.Height;
              ZSpell.FireWhich(theSpell, p.first(), pos1, (FixedInt) num, (FixedInt) 1 / (FixedInt) 2, new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), fromArmageddon: true);
            }
            else if (theSpell.type == CastType.Flash || theSpell.type == CastType.Naplem)
            {
              if (theSpell.spellEnum == SpellEnum.Abduction)
              {
                MyLocation pos2 = new MyLocation(p.first().position.x + p.game.RandomInt(-125, 125), p.first().position.y + p.game.RandomInt(75, 125));
                MyLocation myLocation = p.first().position - pos2;
                myLocation.Normalize();
                FixedInt rot_z = FixedInt.Atan2(myLocation.y, myLocation.x) * FixedInt.Rad2Deg;
                ZSpell.FireWhich(theSpell, p.first(), pos2, rot_z, (FixedInt) 1, new MyLocation(), new MyLocation(), fromArmageddon: true);
              }
              else
                ZSpell.FireWhich(theSpell, p.first(), new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), (FixedInt) num, (FixedInt) 1, new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), fromArmageddon: true);
            }
            else if (theSpell.type == CastType.Double_Naplem)
              ZSpell.FireWhich(theSpell, p.first(), new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), (FixedInt) num, (FixedInt) 1, new MyLocation(xInt > p.map.Width / 2 ? p.game.RandomInt(90, 180) : p.game.RandomInt(-90, 90), p.game.RandomInt(0, p.map.Height)), new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), fromArmageddon: true);
            else if (theSpell.type == CastType.Target_Placement)
            {
              if (theSpell.spellEnum == SpellEnum.Duplication || theSpell.spellEnum == SpellEnum.Passage_Ways)
              {
                ZCreature randomTarget = Armageddon.GetRandomTarget(p);
                if (!((ZComponent) randomTarget == (object) null))
                  ZSpell.FireWhich(theSpell, p.first(), pos1, (FixedInt) p.game.RandomInt(0, 360), (FixedInt) num, new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), randomTarget.position, fromArmageddon: true);
              }
              else
                ZSpell.FireWhich(theSpell, p.first(), pos1, (FixedInt) p.game.RandomInt(0, 360), (FixedInt) num, new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), fromArmageddon: true);
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
                ZSpell.FireWhich(theSpell, p.first(), new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), (FixedInt) num, (FixedInt) 1, new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), fromArmageddon: true);
              }
            }
            else if (theSpell.type == CastType.Blit)
              ZSpell.FireWhich(theSpell, p.first(), pos1, (FixedInt) 0, (FixedInt) num, new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), new MyLocation(xInt, p.game.RandomInt(0, p.map.Height)), fromArmageddon: true);
            else if (theSpell.type == CastType.Flight)
              ZSpell.FireWhich(theSpell, p.first(), pos1, (FixedInt) 0, (FixedInt) num, new MyLocation(0, 0), new MyLocation(0, 0), fromArmageddon: true);
            else if (theSpell.type == CastType.Tower && (ZComponent) p.first().tower == (object) null)
              ZSpell.FireWhich(theSpell, p.first(), pos1, (FixedInt) 0, (FixedInt) num, new MyLocation(0, 0), new MyLocation(0, 0), fromArmageddon: true);
          }
        }
      }
      if (!((ZComponent) p.first() != (object) null) || p.first().isDead)
        return;
      p.first().SetScale(transformscale);
    }
  }

  private static void Grassy_Hills(ZPerson p)
  {
  }

  private static void Giants_Mountains(ZPerson p)
  {
    if (p.localTurn <= p.lastArmageddon + 2)
      return;
    if (p.armaWarnings.Count == 0)
    {
      p.AddArmaWarning();
    }
    else
    {
      p.lastArmageddon = p.localTurn;
      int xInt = p.DequeueArmaWarning();
      ZSpell.FireVolcano(Inert.Instance.ArmageddonObjects[GameFacts.GetMapIndex(p.game.armageddon)], p.controlled[0], new MyLocation(xInt, -300), true);
      p.AddArmaWarning();
    }
  }

  private static void Elven_Isles(ZPerson p)
  {
    if (p.armaWarnings.Count == 0)
    {
      p.AddArmaWarning();
    }
    else
    {
      int xInt = p.DequeueArmaWarning();
      ZSpell.FireCometArmageddon(Inert.Instance.ArmageddonObjects[GameFacts.GetMapIndex(p.game.armageddon)], p, new MyLocation(xInt, 50));
      p.AddArmaWarning();
    }
  }

  private static void Goblin_Caves(ZPerson p)
  {
    if (p.localTurn < 20 && p.localTurn <= p.lastArmageddon + 2 || p.localTurn >= 20 && p.localTurn <= p.lastArmageddon + 1)
      return;
    if (p.armaWarnings.Count == 0)
    {
      p.AddArmaWarning();
    }
    else
    {
      p.lastArmageddon = p.localTurn;
      int xInt = p.DequeueArmaWarning();
      ZSpell.FireVolcano(Inert.Instance.ArmageddonObjects[GameFacts.GetMapIndex(p.game.armageddon)], p.controlled[0], new MyLocation(xInt, -300), true);
      p.AddArmaWarning();
    }
  }

  private static void Murkey_Swamp(ZPerson p)
  {
    if (p.armaWarnings.Count == 0)
    {
      p.AddArmaWarning();
    }
    else
    {
      int xInt = p.DequeueArmaWarning();
      ZSpell.FireStorm(Inert.Instance.ArmageddonObjects[GameFacts.GetMapIndex(p.game.armageddon)], p.controlled[0], new MyLocation(xInt, 0), armageddon: true);
      p.AddArmaWarning();
    }
  }

  private static void Graveyard(ZPerson p)
  {
    if (p.armaWarnings.Count == 0)
    {
      p.AddArmaWarning();
    }
    else
    {
      int xInt = p.DequeueArmaWarning();
      ZSpell.FireRainOfChaos(Inert.Instance.ArmageddonObjects[GameFacts.GetMapIndex(p.game.armageddon)], p.first(), new MyLocation(xInt, 0), true);
      p.AddArmaWarning();
    }
  }

  private static void Desert(ZPerson p)
  {
    if (p.armaWarnings.Count == 0)
    {
      p.AddArmaWarning();
    }
    else
    {
      if ((p.localTurn > 20 || p.lastArmageddon >= p.localTurn - 3) && (p.localTurn <= 20 || p.lastArmageddon >= p.localTurn - 2) && (p.localTurn <= 40 || p.lastArmageddon >= p.localTurn - 1))
        return;
      p.lastArmageddon = p.localTurn;
      int xInt = p.DequeueArmaWarning();
      ZSpell.FireBurningSands(Inert.Instance.ArmageddonObjects[GameFacts.GetMapIndex(p.game.armageddon)], p.first(), new MyLocation(xInt, 0), 25, true);
      p.AddArmaWarning();
    }
  }

  private static void Sky_Castles(ZPerson p)
  {
    if (p.armaWarnings.Count == 0)
    {
      p.AddArmaWarning();
    }
    else
    {
      int xInt = p.DequeueArmaWarning();
      Spell armageddonObject = Inert.Instance.ArmageddonObjects[GameFacts.GetMapIndex(p.game.armageddon)];
      p.game.ongoing.RunSpell(ZSpell.FireSkyRay(armageddonObject, p.first(), new MyLocation(xInt, 0), true));
      if (p.game.isClient)
        AudioManager.Play(armageddonObject.castClip);
      p.AddArmaWarning();
    }
  }

  private static void Mos_LeHarmless(ZPerson p)
  {
    if (p.armaWarnings.Count == 0)
    {
      p.AddArmaWarning();
    }
    else
    {
      int xInt = p.DequeueArmaWarning();
      Spell armageddonObject = Inert.Instance.ArmageddonObjects[GameFacts.GetMapIndex(p.game.armageddon)];
      ZSpell.FireSummon(armageddonObject, p.game, p.controlled[0], new MyLocation(xInt, p.map.Height + armageddonObject.radius + 50));
      p.AddArmaWarning();
    }
  }

  private static void Arcane_Crystals(ZPerson p)
  {
    if (p.armaWarnings.Count == 0)
    {
      p.AddArmaWarning();
    }
    else
    {
      int xInt = p.DequeueArmaWarning();
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
      p.game.ongoing.RunSpell(ZSpell.IEnumeratorArcaneArrows(armageddonObject, p.controlled[0], new MyLocation(xInt, 0), Quaternion.identity, (FixedInt) 90, (FixedInt) 1, amount, target, p.controlled[0].HasArcaneEnergizer ? (int) ((FixedInt) armageddonObject.damage * (FixedInt) 1572864L) : 0, true));
      p.AddArmaWarning();
    }
  }

  private static void Snowy_Hills(ZPerson p)
  {
    ZCreature c = p.first();
    ZSpell.FireRainOfClams(Inert.Instance.spells["Presents!"], c, c.position, 1, true, true);
  }

  private static void Ocean_Floor(ZPerson p)
  {
    if (p.armaWarnings.Count == 0)
    {
      p.AddArmaWarning();
    }
    else
    {
      ZSpell.FireRainOfClams(Inert.Instance.clamOceanFloor, p.first(), new MyLocation(p.DequeueArmaWarning(), 50), Mathf.Max(1, p.localTurn / 10), true, true);
      p.AddArmaWarning();
      if (p.localTurn % 5 != 1)
        return;
      p.lastArmageddon = p.localTurn;
      p.game.ongoing.RunSpell(Armageddon.IEnumeratorSeaSalt(p, Inert.Instance.seaSalt, 25, true));
    }
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
    ZCreature z = ZSpell.FireSummon(spell, p.game, c, new MyLocation(xInt, p.game.RandomInt(30, p.map.Height - 30)), 1);
    p.controlled.Remove(z);
    if (ZComponent.IsNull((ZComponent) z) || z.isDead)
      return;
    if (p.game.isClient)
    {
      z.bg.gameObject.SetActive(false);
      p.panelPlayer?.SetSummons(p);
      AudioManager.Play(spell.castClip);
    }
    p.game.globalEffectors.Add(new ZEffector()
    {
      game = c.game,
      type = EffectorType.DieNSpawnVoid,
      MaxTurnsAlive = 4,
      whoSummoned = z,
      active = false
    });
    z.effectors[0].TurnPassed(0, false, false);
    z.game._uncontrolledPlayer.controlled.Add(z);
    z.daOriginalTrueParent = p;
    z.parent = z.game._uncontrolledPlayer;
  }

  private static void Wasteland(ZPerson p)
  {
    ZCreature c = p.first();
    if (p.localTurn == 25 && p.game.armageddonTurnVariable != 25)
    {
      p.game.armageddonTurnVariable = 25;
      Spell spell = Inert.Instance.spells["Redo"];
      ZSpell.FireRedo(spell, c, true);
      if (p.game.isClient)
        AudioManager.Play(spell.castClip);
    }
    if (p.armaWarnings.Count == 0)
    {
      p.AddArmaWarning();
    }
    else
    {
      if (p.localTurn <= p.lastArmageddon + 1)
        return;
      p.lastArmageddon = p.localTurn;
      int xInt = p.DequeueArmaWarning();
      ZSpell.FireStorm(Inert.Instance.ArmageddonObjects[GameFacts.GetMapIndex(p.game.armageddon)], p.controlled[0], new MyLocation(xInt, 0), armageddon: true);
      p.AddArmaWarning();
    }
  }

  private static void Arcana_te_Deum(ZPerson p)
  {
    if (p.armaWarnings.Count == 0)
    {
      p.AddArmaWarning();
    }
    else
    {
      int xInt = p.DequeueArmaWarning();
      ZSpell.FireCometArmageddon(Inert.Instance.ArmageddonObjects[GameFacts.GetMapIndex(p.game.armageddon)], p, new MyLocation(xInt, 50));
      p.AddArmaWarning();
    }
  }

  private static void AlienWorld(ZPerson p)
  {
    int num = Mathf.Max(1, p.localTurn / 10) * 2;
    Spell armageddonObject = Inert.Instance.ArmageddonObjects[GameFacts.GetMapIndex(p.game.armageddon)];
    for (int index = 0; index < num; ++index)
    {
      MyLocation myLocation = new MyLocation(p.game.RandomInt(0, 10) >= 5 ? -1000 : p.game.map.Width + 1000, p.game.map.Height + 100);
      MyLocation a = new MyLocation(p.game.RandomInt(0, p.game.map.Width), p.game.RandomInt(0, p.game.map.Height));
      ZSpell zspell = ZSpell.BaseFire(armageddonObject, p, myLocation, Quaternion.identity, Inert.Velocity(Inert.AngleOfVectors(a, myLocation)) * 40);
      zspell.fromArmageddon = true;
      zspell.maxDuration -= p.game.RandomInt(0, 30);
    }
  }

  private static void GhostlyHalls(ZPerson p)
  {
    if ((p.localTurn - p.game.armageddonTurn) % 3 != 0 || ZComponent.IsNull((ZComponent) p.first()))
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
    duplicate.parent?.panelPlayer?.SetSummons(duplicate.parent);
    duplicate.effectors.Add(new ZEffector()
    {
      game = p.game,
      active = false,
      type = EffectorType.ApparitionArmageddon,
      MaxTurnsAlive = -1,
      whoSummoned = duplicate
    });
    ZSpell.FireApparition(duplicate);
    p.map.ServerBitBlt(13, (int) duplicate.position.x, (int) duplicate.position.y);
    ZSpell.ApplyExplosionForce(SpellEnum.Duplication, duplicate.world, duplicate.position, 0, Curve.None, 10, 75, (FixedInt) 0, DamageType.None, duplicate, duplicate.game.turn);
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
        ZSpell.BaseFire(spell, c, new MyLocation(c.game.RandomInt(0, c.map.Width), c.map.Height + 100), Quaternion.identity, new MyLocation(0, c.game.RandomInt(-20, -10))).fromArmageddon = armageddon;
      yield return 0.0f;
    }
  }

  public static bool HasWarning(MapEnum m)
  {
    if (m <= MapEnum.Goblin_Caves)
    {
      if (m <= MapEnum.Dark_Fortress)
      {
        if (m <= MapEnum.Snowy_Hills)
        {
          if (m == MapEnum.Jungle || m == MapEnum.Snowy_Hills)
            goto label_19;
          else
            goto label_19;
        }
        else if (m != MapEnum.Ocean_Floor)
        {
          if (m == MapEnum.Dark_Fortress)
            goto label_19;
          else
            goto label_19;
        }
      }
      else if (m <= MapEnum.Grassy_Hills)
      {
        if (m != MapEnum.Wasteland)
        {
          if (m == MapEnum.Grassy_Hills)
            goto label_19;
          else
            goto label_19;
        }
      }
      else if (m != MapEnum.Giants_Mountains && m != MapEnum.Elven_Isles && m != MapEnum.Goblin_Caves)
        goto label_19;
    }
    else if (m <= MapEnum.Mos_LeHarmless)
    {
      if (m <= MapEnum.Graveyard)
      {
        if (m != MapEnum.Murky_Swamp && m != MapEnum.Graveyard)
          goto label_19;
      }
      else if (m != MapEnum.Sky_Castles && m != MapEnum.Mos_LeHarmless)
        goto label_19;
    }
    else if (m <= MapEnum.Alien_World)
    {
      if (m != MapEnum.Arcane_Crystals)
      {
        if (m == MapEnum.Alien_World)
          goto label_19;
        else
          goto label_19;
      }
    }
    else if (m == MapEnum.Ghostly_Halls || m != MapEnum.Desert && m != MapEnum.Space_Nexus)
      goto label_19;
    return true;
label_19:
    return false;
  }

  public static void NextTurn(ZPerson p)
  {
    if (p.localTurn < p.game.armageddonTurn - (Armageddon.HasWarning(p.game.armageddon) ? 1 : 0) || p.controlled.Count == 0)
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
