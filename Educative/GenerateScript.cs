
using MoonSharp.Interpreter;
using MyPolling;
using System;
using TMPro;
using UnityEngine;

namespace Educative
{
  public class GenerateScript
  {
    public static Script GetScript(Tutorial t = null)
    {
      UserData.RegisterProxyType<ContainerGame, ZGame>((Func<ZGame, ContainerGame>) (r => new ContainerGame(r, t)), InteropAccessMode.Default, (string) null);
      UserData.RegisterProxyType<ContainerPlayer, ZPerson>((Func<ZPerson, ContainerPlayer>) (r => new ContainerPlayer(r)), InteropAccessMode.Default, (string) null);
      UserData.RegisterProxyType<ContainerCreature, ZCreature>((Func<ZCreature, ContainerCreature>) (r => new ContainerCreature(r)), InteropAccessMode.Default, (string) null);
      UserData.RegisterProxyType<ContainerEffector, ZEffector>((Func<ZEffector, ContainerEffector>) (r => new ContainerEffector(r)), InteropAccessMode.Default, (string) null);
      UserData.RegisterProxyType<ContainerIndicator, GameObject>((Func<GameObject, ContainerIndicator>) (r => new ContainerIndicator(r)), InteropAccessMode.Default, (string) null);
      UserData.RegisterProxyType<ContainerSpell, SpellSlot>((Func<SpellSlot, ContainerSpell>) (r => new ContainerSpell(r)), InteropAccessMode.Default, (string) null);
      UserData.RegisterProxyType<ContainerTower, ZTower>((Func<ZTower, ContainerTower>) (r => new ContainerTower(r)), InteropAccessMode.Default, (string) null);
      Script.GlobalOptions.RethrowExceptionNested = true;
      UserData.RegisterType<Point>(InteropAccessMode.Default, (string) null);
      UserData.RegisterType<Summon>(InteropAccessMode.Default, (string) null);
      UserData.RegisterType<UIElement>(InteropAccessMode.Default, (string) null);
      UserData.RegisterType<KeyCode>(InteropAccessMode.Default, (string) null);
      UserData.RegisterType<KeyBinds>(InteropAccessMode.Default, (string) null);
      UserData.RegisterType<SpellEnum>(InteropAccessMode.Default, (string) null);
      UserData.RegisterType<CastType>(InteropAccessMode.Default, (string) null);
      UserData.RegisterType<DamageType>(InteropAccessMode.Default, (string) null);
      UserData.RegisterType<BookOf>(InteropAccessMode.Default, (string) null);
      UserData.RegisterType<Anchor>(InteropAccessMode.Default, (string) null);
      UserData.RegisterType<HorizontalAlignmentOptions>(InteropAccessMode.Default, (string) null);
      UserData.RegisterType<VerticalAlignmentOptions>(InteropAccessMode.Default, (string) null);
      UserData.RegisterType<IndicatorKind>(InteropAccessMode.Default, (string) null);
      UserData.RegisterType<MapEnum>(InteropAccessMode.Default, (string) null);
      UserData.RegisterType<EffectorType>(InteropAccessMode.Default, (string) null);
      UserData.RegisterType<TowerType>(InteropAccessMode.Default, (string) null);
      UserData.RegisterType<CreatureType>(InteropAccessMode.Default, (string) null);
      UserData.RegisterType<CreatureRace>(InteropAccessMode.Default, (string) null);
      UserData.RegisterType<ExplosionCutout>(InteropAccessMode.Default, (string) null);
      UserData.RegisterType<MyPoll>(InteropAccessMode.Default, (string) null);
      UserData.RegisterType<MyPoll.Item>(InteropAccessMode.Default, (string) null);
      UserData.RegisterType<MyPoll.Answer>(InteropAccessMode.Default, (string) null);
      UserData.RegisterType<LuaColor>(InteropAccessMode.Default, (string) null);
      UserData.RegisterType<TalkOptions>(InteropAccessMode.Default, (string) null);
      return new Script(CoreModules.Preset_SoftSandbox)
      {
        Globals = {
          [(object) "game"] = (object) new ContainerGame(Client.game, t),
          [(object) "point"] = (object) new Func<int, int, Point>(Point.construct),
          [(object) "color"] = (object) new Func<byte, byte, byte, byte, LuaColor>(LuaColor.construct),
          [(object) "colorHex"] = (object) new Func<string, LuaColor>(LuaColor.construct),
          [(object) "createUI"] = (object) new Func<Script, UIElement, UIElement>(UIElement.createUI),
          [(object) "createInput"] = (object) new Func<Script, UIElement, string, bool, bool, bool, UIElement>(UIElement.createInput),
          [(object) "summon"] = (object) new Func<string, Point, int, Table, bool, bool, string, Table, Table, BookOf, int, Summon>(Summon.construct),
          [(object) "spell"] = (object) new Func<string, ContainerSpell>(ContainerGame.getSpell),
          [(object) "createPoll"] = (object) new Func<string, MyPoll>(MyPoll.construct),
          [(object) "KeyCode"] = (object) UserData.CreateStatic<KeyCode>(),
          [(object) "KeyBinds"] = (object) UserData.CreateStatic<KeyBinds>(),
          [(object) "SpellEnum"] = (object) UserData.CreateStatic<SpellEnum>(),
          [(object) "CastType"] = (object) UserData.CreateStatic<CastType>(),
          [(object) "DamageType"] = (object) UserData.CreateStatic<DamageType>(),
          [(object) "Book"] = (object) UserData.CreateStatic<BookOf>(),
          [(object) "Anchor"] = (object) UserData.CreateStatic<Anchor>(),
          [(object) "AlignHorizontal"] = (object) UserData.CreateStatic<HorizontalAlignmentOptions>(),
          [(object) "AlignVertical"] = (object) UserData.CreateStatic<VerticalAlignmentOptions>(),
          [(object) "IndicatorKind"] = (object) UserData.CreateStatic<IndicatorKind>(),
          [(object) "MapEnum"] = (object) UserData.CreateStatic<MapEnum>(),
          [(object) "EffectorType"] = (object) UserData.CreateStatic<EffectorType>(),
          [(object) "TowerType"] = (object) UserData.CreateStatic<TowerType>(),
          [(object) "CreatureType"] = (object) UserData.CreateStatic<CreatureType>(),
          [(object) "CreatureRace"] = (object) UserData.CreateStatic<CreatureRace>(),
          [(object) "ExplosionCutout"] = (object) UserData.CreateStatic<ExplosionCutout>()
        },
        Options = {
          CheckThreadAccess = false
        }
      };
    }
  }
}
