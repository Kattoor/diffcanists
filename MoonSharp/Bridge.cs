
using Educative;
using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Interop;
using MoonSharp.Interpreter.Interop.BasicDescriptors;
using MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors;
using MyPolling;
using System.Collections.Generic;
using UnityEngine;

namespace MoonSharp
{
  public abstract class Bridge
  {
    private Bridge()
    {
    }

    public static void Initialize()
    {
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_065805549d3b4cfab68aac7036214cf6());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_008a05134d27427dad48579ae0c4cabc());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_4ea197ed244d4a8a9a7641764d1b1193());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_e677c05978bb408588e8df4e6b6afe17());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_8cf7a64d112f4018b53d55ca0ee220f3());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_45ad71462c5945c2b7cbc4d6f66da4ba());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_2c77888099f241bb985e24f998b8c1a0());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_dbfab461b99a4fb680bbb94ee1dd2fc8());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_e85970bb2e054b5d9309c44eda9a3bd7());
    }

    private sealed class TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f : HardwiredUserDataDescriptor
    {
      internal TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_3f207c884f48465abba422fe84935d8b()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_c914d214e216435696b229831ecc182a()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_38b72aa619ff4812bf5eac3b6ae5c0e0()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_fc5e4568ee9f47ae817ff6990fa5151a()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_9c50ea5052ee41528e6d74839d20c731()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_ac72a953682b4cd8ae130f90405cf614()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_492e671bc64f4403b8c2d7959302997f()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_3e3d662415c0486c9821b3cb2b3d7747()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_ab1fe71f38b8425c835326faee822660()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_f008d7e41f6f4f41a08d6ff38221adaa()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_926e6c0902ec478c82c8622a51577545()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_54a7d6a2852947c8a40aa45d21b70c1f()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_0c675ae6f40b439996e719a6dc57b6da()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_73bc389050474f5ebb6119c9575e7961()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_3c58ffc235c147ba8aa788a4013ab3d7()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_f555e0f8b35149719d52d57761e9b23a()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_e21c98c3d942442a870217cefaac48c9()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_bb4dc9d509814e03b0485da12ab222b9()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_2bb21a2be20b462b8787d7b9c6e31ca5()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_5054484dc6134475a2a5ec9c601413df()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_99ea90331d4e47d5821f8146865aea63()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_31bb4cd7a5f54e1899ea19ae42ab0015()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_ab22462bfc7a4c7aa37abc7fe23ea634()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_5d9634a367a24c4797f9dd1db35cccca()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_e298c40bf3054328a6a0aa413ecba35e()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_86c3801949464531963ec6887038fec3()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_c4733eeb0d4045018b7a2f087c2961f5()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_f9eabd78896e44c78e47939f4a9c5401()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_02d47d6ee2774a3ca5ba6633c3dcfa9a()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_a21cc2c663ca428496046bd93d1776e2()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_d9281798705840e6b51a8644fa79748a()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_b39bd0cc72e242cab03ddb4d9fba044a()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_c9c2c79a736a49489ffab9e4193ebaf1()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_d24e22086c6242c8a744acbf93de6a2d()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_ae1930d2083c47779d86085f71ffbc8a()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_95eacfbd4384425bb4a8527600950816()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_777bce5ce20f48bc9b56b57b1536cc47()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_1c3486e30b794ad09a6f3fb262c9b8b9()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_cd8036f18d87411489f3e7590634c6af()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_a95bf138c0b3491e8e032a70b18e67c8()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_469b4d88999e498abc8bfd083362c57a()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_2d1eb3e6991f47699615c2dedb5bf445()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_dd0ac61057394e70bfb86123aa0a53f2()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_2c315f848cb740ecac3db9463ff2c085()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_1f99d579e8384717bf9fb265694ff568()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_d0e7ac0f986c4f72ac53ec1e396a2847()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_472f80bef59c44498f03cb1605c772b4()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_ee21218c33e640f8a504e297ea4a8a10()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_5c83cc17e9734dfeb51c488c8b00faee()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_16cc582c2ba649fcb0f5f377daab150d()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_aa4b2515f9a74d34a1ceebfcc3677572()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_901155a8e22a4e879a4021e845fea3d2()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_ede31eb6b57e4f489909555907a45dc9()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_c57aa3a6724d456e968fb2605dc82595()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_eeb3bb08f3ad4020882d00ab78bd93a2()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_c901e53035c44262ab779ca7d13a3841()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_eb56a90128db49f18ccc518872fb4ea5()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_b0d73c1d54c540c0b6f2c96ec0e040e1()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_c52d7353d4ab423c8586c9778a6428f1()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_e79706b8eabf461c89a1bb6047dfe514()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_fca61ae6b63d46dcb2da6e1528c6374b()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_36f20ae1ed124da9a103a79b2b1eef11()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_2c4fa6d2aa6b4ebb9dcec20e4e8acbb9()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_e8af87c062c441ed8a4303b1ba44d4f6()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_4cbe1ff1e8a543af9b2b71dc13420a0d()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_68347e8d4af5429eb792a1efe8dfb30e()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_628620d4a59446df94ae3e8e8ebc35d6()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_d6c8aea58ec54b80b05b59bde4e242dc()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_c0f197ea7edb4093a20b98deca02b34c()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_b6b04f11c030460b90d051116004cd3e()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_affaa8bf6f864cebb81233f283aa1fda()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_5eb923363e0c42b6acda9f3269b03f7e()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_c7dbef7a7c46441a82b12904939dd194()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_2c5d179c2ab74cd88afdcbe6c7390f1d()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_56f1c8d1b2c34d1eb3622c2ef01f9c9d()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_a82444d4b4f34d1b802f220c567516bf()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_11664ff3e8794ec0866c334033f7b140()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_5f704554e6e74679b185694630394424()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_1ed7abb9de4643fe801bd1630418b7a0()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_c40acb7cace643f89bb9115434b8c036()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_07eb19a7f66f413881b8f47bc1accbd2()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_7c6ce7ba0b5a4b31ad90d5172d90450d()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_63223615f8674b8d9f287bdeb95f720c()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_f8b64e9cd096455e9ba4b160fb36f267()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_e4cf953a5c8542be97c16f2cd14c2cbf()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_92888aeae50146319db3db6dc63d59f9()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_a1f2f7db12e84106b87823758b5a5c53()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_c3a207d988ae4903af1ab404e59f8eec()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_6ae4396ba9b64a3a98fbbf65b241ae12()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_b4c6b2340d2f4871986acfc80d32d7fa()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_8581078ca8214cc59b2a6425f2db21af()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_c6f8ba13fc1d4bf097d469a5b997d419()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_ae38d2a3f13f46489f517d78d4b10b5a()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_de67ae1d2d2b4a0a82cb8cf97eb4013e()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_0c30d8507a9e4d858562722a9f7f55e8()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_85933498c0f344738d79f59860ba3e87()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.MTHD_43fc9a7460b341c5bcd99c6c3cf3eb69()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_1b3c9c92e0bb4631a12b9f207e3acb60());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_b26329a5bab54337825cac6863f3f8ed());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_e5e1f0e758e24a219bb388961fa6da51());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_862443743a6f4e09a7d5e7a8b9ce7d3f());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_91fb60e72a5a41dc84fe8de669fd2726());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_c04c454b6ecf46da952930d0d8bc5795());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_fdde472efd074a0f804f5d53d70e1d80());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_5960bf77f649471584cf9e5bbca87795());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_d8febeb527a04429810f328a2b1b6dbb());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_d94f2a1ad2984b319b71c1a9d566aa0d());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_ea18afb7016444ee89984e41b2ffaac8());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_3cb055e5096f4380bfd2d4f396609b70());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_f9120953582644bd86fb10f5c18db74a());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_c189b94c2f3141308bfe2f676e1e6956());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_c796fc5c0fdf4050ad665d4768d2197e());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_c499881eec5448a8ad08be1e061dd91c());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_e25b4cde80bf4f5aae715575d6d55ac4());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_4c8ebd50f19f49aeb6656e3a7158b0b6());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_be353ebd6e3348eab0c11e207faa52af());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_5b5da6c4e13744609bca4068eff94609());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_6e8ae90b8e204a3b9f541bdf36d8c2e1());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_760c7860dcf44ce69254452f447ad216());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_e3ae8bb5e7424c5b949ca04f3bf0c251());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_be2faf4ed1bc4f2b8eb8bb3e3194267a());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_298e796ab83b4c4c87234568ac74e52a());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_c732f84035e44237b4074c174d5d4af4());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_bc2d75cc12ed4861a71f60b2e06a6da0());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_e098a90a848e4172bad1922569ed3858());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_be03712623f84ab8b011dce384d3b75f());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_7375e901f57b4ae0b9a169131639711e());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_31a50b79221b4935922791a76abccefe());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_fa77a05ccb6b4dbdb76aac120e2b7e5f.PROP_fed3d15eef7c40c3b907d9232cf36ff3());
      }

      private sealed class MTHD_3f207c884f48465abba422fe84935d8b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f207c884f48465abba422fe84935d8b()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_c914d214e216435696b229831ecc182a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c914d214e216435696b229831ecc182a()
        {
          this.Initialize("getPlayers", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("script", typeof (Script), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayers((Script) pars[0]);
        }
      }

      private sealed class MTHD_38b72aa619ff4812bf5eac3b6ae5c0e0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_38b72aa619ff4812bf5eac3b6ae5c0e0()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_fc5e4568ee9f47ae817ff6990fa5151a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fc5e4568ee9f47ae817ff6990fa5151a()
        {
          this.Initialize("getCreatures", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("script", typeof (Script), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getCreatures((Script) pars[0]);
        }
      }

      private sealed class MTHD_9c50ea5052ee41528e6d74839d20c731 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c50ea5052ee41528e6d74839d20c731()
        {
          this.Initialize("findCreatures", false, new ParameterDescriptor[3]
          {
            new ParameterDescriptor("script", typeof (Script), false, (object) null, false, false, false),
            new ParameterDescriptor("point", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("radius", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).findCreatures((Script) pars[0], (Educative.Point) pars[1], (int) pars[2]);
        }
      }

      private sealed class MTHD_ac72a953682b4cd8ae130f90405cf614 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac72a953682b4cd8ae130f90405cf614()
        {
          this.Initialize("findEffectors", false, new ParameterDescriptor[3]
          {
            new ParameterDescriptor("script", typeof (Script), false, (object) null, false, false, false),
            new ParameterDescriptor("point", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("radius", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).findEffectors((Script) pars[0], (Educative.Point) pars[1], (int) pars[2]);
        }
      }

      private sealed class MTHD_492e671bc64f4403b8c2d7959302997f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_492e671bc64f4403b8c2d7959302997f()
        {
          this.Initialize("LineCast", false, new ParameterDescriptor[6]
          {
            new ParameterDescriptor("a", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("b", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("ignore", typeof (ContainerCreature), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("includeCreatures", typeof (bool), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("includeEffectors", typeof (bool), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("includePhantom", typeof (bool), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 2)
            return (object) ((ContainerGame) obj).LineCast((Educative.Point) pars[0], (Educative.Point) pars[1], (ContainerCreature) null, true, false, false);
          if (argscount <= 3)
            return (object) ((ContainerGame) obj).LineCast((Educative.Point) pars[0], (Educative.Point) pars[1], (ContainerCreature) pars[2], true, false, false);
          if (argscount <= 4)
            return (object) ((ContainerGame) obj).LineCast((Educative.Point) pars[0], (Educative.Point) pars[1], (ContainerCreature) pars[2], (bool) pars[3], false, false);
          return argscount <= 5 ? (object) ((ContainerGame) obj).LineCast((Educative.Point) pars[0], (Educative.Point) pars[1], (ContainerCreature) pars[2], (bool) pars[3], (bool) pars[4], false) : (object) ((ContainerGame) obj).LineCast((Educative.Point) pars[0], (Educative.Point) pars[1], (ContainerCreature) pars[2], (bool) pars[3], (bool) pars[4], (bool) pars[5]);
        }
      }

      private sealed class MTHD_3e3d662415c0486c9821b3cb2b3d7747 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e3d662415c0486c9821b3cb2b3d7747()
        {
          this.Initialize("LineCastOnlyCreatures", false, new ParameterDescriptor[5]
          {
            new ParameterDescriptor("a", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("b", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("ignore", typeof (ContainerCreature), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("includeCreatures", typeof (bool), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("includePhantom", typeof (bool), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 2)
            return (object) ((ContainerGame) obj).LineCastOnlyCreatures((Educative.Point) pars[0], (Educative.Point) pars[1], (ContainerCreature) null, true, false);
          if (argscount <= 3)
            return (object) ((ContainerGame) obj).LineCastOnlyCreatures((Educative.Point) pars[0], (Educative.Point) pars[1], (ContainerCreature) pars[2], true, false);
          return argscount <= 4 ? (object) ((ContainerGame) obj).LineCastOnlyCreatures((Educative.Point) pars[0], (Educative.Point) pars[1], (ContainerCreature) pars[2], (bool) pars[3], false) : (object) ((ContainerGame) obj).LineCastOnlyCreatures((Educative.Point) pars[0], (Educative.Point) pars[1], (ContainerCreature) pars[2], (bool) pars[3], (bool) pars[4]);
        }
      }

      private sealed class MTHD_ab1fe71f38b8425c835326faee822660 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab1fe71f38b8425c835326faee822660()
        {
          this.Initialize("LineCastOnlyTerrain", false, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("a", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("b", typeof (Educative.Point), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).LineCastOnlyTerrain((Educative.Point) pars[0], (Educative.Point) pars[1]);
        }
      }

      private sealed class MTHD_f008d7e41f6f4f41a08d6ff38221adaa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f008d7e41f6f4f41a08d6ff38221adaa()
        {
          this.Initialize("ShowInfo", false, new ParameterDescriptor[4]
          {
            new ParameterDescriptor("message", typeof (string), false, (object) null, false, false, false),
            new ParameterDescriptor("onContinue", typeof (bool), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("pauseGame", typeof (bool), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("unpauseGame", typeof (bool), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 1)
          {
            ((ContainerGame) obj).ShowInfo((string) pars[0], false, false, true);
            return (object) DynValue.Void;
          }
          if (argscount <= 2)
          {
            ((ContainerGame) obj).ShowInfo((string) pars[0], (bool) pars[1], false, true);
            return (object) DynValue.Void;
          }
          if (argscount <= 3)
          {
            ((ContainerGame) obj).ShowInfo((string) pars[0], (bool) pars[1], (bool) pars[2], true);
            return (object) DynValue.Void;
          }
          ((ContainerGame) obj).ShowInfo((string) pars[0], (bool) pars[1], (bool) pars[2], (bool) pars[3]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_926e6c0902ec478c82c8622a51577545 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_926e6c0902ec478c82c8622a51577545()
        {
          this.Initialize("Talk", false, new ParameterDescriptor[3]
          {
            new ParameterDescriptor("what", typeof (ContainerCreature), false, (object) null, false, false, false),
            new ParameterDescriptor("message", typeof (string), false, (object) null, false, false, false),
            new ParameterDescriptor("options", typeof (TalkOptions), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 2)
          {
            ((ContainerGame) obj).Talk((ContainerCreature) pars[0], (string) pars[1], (TalkOptions) null);
            return (object) DynValue.Void;
          }
          ((ContainerGame) obj).Talk((ContainerCreature) pars[0], (string) pars[1], (TalkOptions) pars[2]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_54a7d6a2852947c8a40aa45d21b70c1f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_54a7d6a2852947c8a40aa45d21b70c1f()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_0c675ae6f40b439996e719a6dc57b6da : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c675ae6f40b439996e719a6dc57b6da()
        {
          this.Initialize("set_turn", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).turn = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_73bc389050474f5ebb6119c9575e7961 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_73bc389050474f5ebb6119c9575e7961()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_3c58ffc235c147ba8aa788a4013ab3d7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3c58ffc235c147ba8aa788a4013ab3d7()
        {
          this.Initialize("set_timeLimit", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).timeLimit = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_f555e0f8b35149719d52d57761e9b23a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f555e0f8b35149719d52d57761e9b23a()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_e21c98c3d942442a870217cefaac48c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e21c98c3d942442a870217cefaac48c9()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_bb4dc9d509814e03b0485da12ab222b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb4dc9d509814e03b0485da12ab222b9()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_2bb21a2be20b462b8787d7b9c6e31ca5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2bb21a2be20b462b8787d7b9c6e31ca5()
        {
          this.Initialize("random", false, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("lower", typeof (int), false, (object) null, false, false, false),
            new ParameterDescriptor("upper", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).random((int) pars[0], (int) pars[1]);
        }
      }

      private sealed class MTHD_5054484dc6134475a2a5ec9c601413df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5054484dc6134475a2a5ec9c601413df()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_99ea90331d4e47d5821f8146865aea63 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99ea90331d4e47d5821f8146865aea63()
        {
          this.Initialize("set_winOnDeath", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).winOnDeath = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_31bb4cd7a5f54e1899ea19ae42ab0015 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_31bb4cd7a5f54e1899ea19ae42ab0015()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_ab22462bfc7a4c7aa37abc7fe23ea634 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab22462bfc7a4c7aa37abc7fe23ea634()
        {
          this.Initialize("set_allowMovement", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).allowMovement = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_5d9634a367a24c4797f9dd1db35cccca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d9634a367a24c4797f9dd1db35cccca()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_e298c40bf3054328a6a0aa413ecba35e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e298c40bf3054328a6a0aa413ecba35e()
        {
          this.Initialize("set_allowInput", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).allowInput = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_86c3801949464531963ec6887038fec3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_86c3801949464531963ec6887038fec3()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_c4733eeb0d4045018b7a2f087c2961f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c4733eeb0d4045018b7a2f087c2961f5()
        {
          this.Initialize("set_allowCallbacks", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).allowCallbacks = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_f9eabd78896e44c78e47939f4a9c5401 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f9eabd78896e44c78e47939f4a9c5401()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_02d47d6ee2774a3ca5ba6633c3dcfa9a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_02d47d6ee2774a3ca5ba6633c3dcfa9a()
        {
          this.Initialize("set_allowSkipTurn", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).allowSkipTurn = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_a21cc2c663ca428496046bd93d1776e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a21cc2c663ca428496046bd93d1776e2()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_d9281798705840e6b51a8644fa79748a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d9281798705840e6b51a8644fa79748a()
        {
          this.Initialize("set_terrainDestruction", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).terrainDestruction = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_b39bd0cc72e242cab03ddb4d9fba044a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b39bd0cc72e242cab03ddb4d9fba044a()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_c9c2c79a736a49489ffab9e4193ebaf1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c9c2c79a736a49489ffab9e4193ebaf1()
        {
          this.Initialize("set_takeDamage", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).takeDamage = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_d24e22086c6242c8a744acbf93de6a2d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d24e22086c6242c8a744acbf93de6a2d()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_ae1930d2083c47779d86085f71ffbc8a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae1930d2083c47779d86085f71ffbc8a()
        {
          this.Initialize("set_armageddon", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (MapEnum), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).armageddon = (MapEnum) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_95eacfbd4384425bb4a8527600950816 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95eacfbd4384425bb4a8527600950816()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_777bce5ce20f48bc9b56b57b1536cc47 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_777bce5ce20f48bc9b56b57b1536cc47()
        {
          this.Initialize("set_armageddonTurn", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).armageddonTurn = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_1c3486e30b794ad09a6f3fb262c9b8b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c3486e30b794ad09a6f3fb262c9b8b9()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_cd8036f18d87411489f3e7590634c6af : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd8036f18d87411489f3e7590634c6af()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_a95bf138c0b3491e8e032a70b18e67c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a95bf138c0b3491e8e032a70b18e67c8()
        {
          this.Initialize("set_paused", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).paused = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_469b4d88999e498abc8bfd083362c57a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_469b4d88999e498abc8bfd083362c57a()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_2d1eb3e6991f47699615c2dedb5bf445 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d1eb3e6991f47699615c2dedb5bf445()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_dd0ac61057394e70bfb86123aa0a53f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dd0ac61057394e70bfb86123aa0a53f2()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_2c315f848cb740ecac3db9463ff2c085 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c315f848cb740ecac3db9463ff2c085()
        {
          this.Initialize("set_gravity", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).gravity = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_1f99d579e8384717bf9fb265694ff568 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f99d579e8384717bf9fb265694ff568()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_d0e7ac0f986c4f72ac53ec1e396a2847 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0e7ac0f986c4f72ac53ec1e396a2847()
        {
          this.Initialize("set_wind", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).wind = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_472f80bef59c44498f03cb1605c772b4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_472f80bef59c44498f03cb1605c772b4()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_ee21218c33e640f8a504e297ea4a8a10 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee21218c33e640f8a504e297ea4a8a10()
        {
          this.Initialize("set_windDir", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).windDir = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_5c83cc17e9734dfeb51c488c8b00faee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c83cc17e9734dfeb51c488c8b00faee()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_16cc582c2ba649fcb0f5f377daab150d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_16cc582c2ba649fcb0f5f377daab150d()
        {
          this.Initialize("set_windPower", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).windPower = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_aa4b2515f9a74d34a1ceebfcc3677572 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa4b2515f9a74d34a1ceebfcc3677572()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_901155a8e22a4e879a4021e845fea3d2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_901155a8e22a4e879a4021e845fea3d2()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_ede31eb6b57e4f489909555907a45dc9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ede31eb6b57e4f489909555907a45dc9()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_c57aa3a6724d456e968fb2605dc82595 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c57aa3a6724d456e968fb2605dc82595()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_eeb3bb08f3ad4020882d00ab78bd93a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eeb3bb08f3ad4020882d00ab78bd93a2()
        {
          this.Initialize("worldToCanvas", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("p", typeof (Educative.Point), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).worldToCanvas((Educative.Point) pars[0]);
        }
      }

      private sealed class MTHD_c901e53035c44262ab779ca7d13a3841 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c901e53035c44262ab779ca7d13a3841()
        {
          this.Initialize("canvasToWorld", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("p", typeof (Educative.Point), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).canvasToWorld((Educative.Point) pars[0]);
        }
      }

      private sealed class MTHD_eb56a90128db49f18ccc518872fb4ea5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb56a90128db49f18ccc518872fb4ea5()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_b0d73c1d54c540c0b6f2c96ec0e040e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b0d73c1d54c540c0b6f2c96ec0e040e1()
        {
          this.Initialize("set_cameraPosition", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (Educative.Point), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).cameraPosition = (Educative.Point) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_c52d7353d4ab423c8586c9778a6428f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c52d7353d4ab423c8586c9778a6428f1()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_e79706b8eabf461c89a1bb6047dfe514 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e79706b8eabf461c89a1bb6047dfe514()
        {
          this.Initialize("set_cameraZoom", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).cameraZoom = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_fca61ae6b63d46dcb2da6e1528c6374b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fca61ae6b63d46dcb2da6e1528c6374b()
        {
          this.Initialize("getMapPixel", false, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("x", typeof (int), false, (object) null, false, false, false),
            new ParameterDescriptor("y", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapPixel((int) pars[0], (int) pars[1]);
        }
      }

      private sealed class MTHD_36f20ae1ed124da9a103a79b2b1eef11 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_36f20ae1ed124da9a103a79b2b1eef11()
        {
          this.Initialize("setMapPixel", false, new ParameterDescriptor[3]
          {
            new ParameterDescriptor("x", typeof (int), false, (object) null, false, false, false),
            new ParameterDescriptor("y", typeof (int), false, (object) null, false, false, false),
            new ParameterDescriptor("c", typeof (LuaColor), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).setMapPixel((int) pars[0], (int) pars[1], (LuaColor) pars[2]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_2c4fa6d2aa6b4ebb9dcec20e4e8acbb9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c4fa6d2aa6b4ebb9dcec20e4e8acbb9()
        {
          this.Initialize("drawRectangle", false, new ParameterDescriptor[5]
          {
            new ParameterDescriptor("x", typeof (int), false, (object) null, false, false, false),
            new ParameterDescriptor("y", typeof (int), false, (object) null, false, false, false),
            new ParameterDescriptor("width", typeof (int), false, (object) null, false, false, false),
            new ParameterDescriptor("height", typeof (int), false, (object) null, false, false, false),
            new ParameterDescriptor("c", typeof (LuaColor), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).drawRectangle((int) pars[0], (int) pars[1], (int) pars[2], (int) pars[3], (LuaColor) pars[4]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_e8af87c062c441ed8a4303b1ba44d4f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e8af87c062c441ed8a4303b1ba44d4f6()
        {
          this.Initialize("drawEllipseOutline", false, new ParameterDescriptor[6]
          {
            new ParameterDescriptor("x", typeof (int), false, (object) null, false, false, false),
            new ParameterDescriptor("y", typeof (int), false, (object) null, false, false, false),
            new ParameterDescriptor("radiusX", typeof (int), false, (object) null, false, false, false),
            new ParameterDescriptor("radiusY", typeof (int), false, (object) null, false, false, false),
            new ParameterDescriptor("outlineWidth", typeof (int), false, (object) null, false, false, false),
            new ParameterDescriptor("c", typeof (LuaColor), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).drawEllipseOutline((int) pars[0], (int) pars[1], (int) pars[2], (int) pars[3], (int) pars[4], (LuaColor) pars[5]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_4cbe1ff1e8a543af9b2b71dc13420a0d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4cbe1ff1e8a543af9b2b71dc13420a0d()
        {
          this.Initialize("drawEllipse", false, new ParameterDescriptor[5]
          {
            new ParameterDescriptor("x", typeof (int), false, (object) null, false, false, false),
            new ParameterDescriptor("y", typeof (int), false, (object) null, false, false, false),
            new ParameterDescriptor("radiusX", typeof (int), false, (object) null, false, false, false),
            new ParameterDescriptor("radiusY", typeof (int), false, (object) null, false, false, false),
            new ParameterDescriptor("c", typeof (LuaColor), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).drawEllipse((int) pars[0], (int) pars[1], (int) pars[2], (int) pars[3], (LuaColor) pars[4]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_68347e8d4af5429eb792a1efe8dfb30e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_68347e8d4af5429eb792a1efe8dfb30e()
        {
          this.Initialize("blit", false, new ParameterDescriptor[4]
          {
            new ParameterDescriptor("ex", typeof (ExplosionCutout), false, (object) null, false, false, false),
            new ParameterDescriptor("point", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("ignoreAlpha", typeof (bool), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("apply", typeof (bool), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 2)
          {
            ((ContainerGame) obj).blit((ExplosionCutout) pars[0], (Educative.Point) pars[1], false, true);
            return (object) DynValue.Void;
          }
          if (argscount <= 3)
          {
            ((ContainerGame) obj).blit((ExplosionCutout) pars[0], (Educative.Point) pars[1], (bool) pars[2], true);
            return (object) DynValue.Void;
          }
          ((ContainerGame) obj).blit((ExplosionCutout) pars[0], (Educative.Point) pars[1], (bool) pars[2], (bool) pars[3]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_628620d4a59446df94ae3e8e8ebc35d6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_628620d4a59446df94ae3e8e8ebc35d6()
        {
          this.Initialize("blitRotate", false, new ParameterDescriptor[5]
          {
            new ParameterDescriptor("ex", typeof (ExplosionCutout), false, (object) null, false, false, false),
            new ParameterDescriptor("point", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("rotation", typeof (double), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("inFront", typeof (bool), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("apply", typeof (bool), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 2)
          {
            ((ContainerGame) obj).blitRotate((ExplosionCutout) pars[0], (Educative.Point) pars[1], 0.0, true, true);
            return (object) DynValue.Void;
          }
          if (argscount <= 3)
          {
            ((ContainerGame) obj).blitRotate((ExplosionCutout) pars[0], (Educative.Point) pars[1], (double) pars[2], true, true);
            return (object) DynValue.Void;
          }
          if (argscount <= 4)
          {
            ((ContainerGame) obj).blitRotate((ExplosionCutout) pars[0], (Educative.Point) pars[1], (double) pars[2], (bool) pars[3], true);
            return (object) DynValue.Void;
          }
          ((ContainerGame) obj).blitRotate((ExplosionCutout) pars[0], (Educative.Point) pars[1], (double) pars[2], (bool) pars[3], (bool) pars[4]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_d6c8aea58ec54b80b05b59bde4e242dc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6c8aea58ec54b80b05b59bde4e242dc()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c0f197ea7edb4093a20b98deca02b34c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c0f197ea7edb4093a20b98deca02b34c()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_b6b04f11c030460b90d051116004cd3e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b6b04f11c030460b90d051116004cd3e()
        {
          this.Initialize("set_allowBounce", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).allowBounce = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_affaa8bf6f864cebb81233f283aa1fda : HardwiredMethodMemberDescriptor
      {
        internal MTHD_affaa8bf6f864cebb81233f283aa1fda()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_5eb923363e0c42b6acda9f3269b03f7e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5eb923363e0c42b6acda9f3269b03f7e()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c7dbef7a7c46441a82b12904939dd194 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c7dbef7a7c46441a82b12904939dd194()
        {
          this.Initialize("startCoroutine", false, new ParameterDescriptor[4]
          {
            new ParameterDescriptor("script", typeof (Script), false, (object) null, false, false, false),
            new ParameterDescriptor("f", typeof (DynValue), false, (object) null, false, false, false),
            new ParameterDescriptor("runAsCoroutine", typeof (bool), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("seconds", typeof (float), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 2)
          {
            ((ContainerGame) obj).startCoroutine((Script) pars[0], (DynValue) pars[1], true, 0.0f);
            return (object) DynValue.Void;
          }
          if (argscount <= 3)
          {
            ((ContainerGame) obj).startCoroutine((Script) pars[0], (DynValue) pars[1], (bool) pars[2], 0.0f);
            return (object) DynValue.Void;
          }
          ((ContainerGame) obj).startCoroutine((Script) pars[0], (DynValue) pars[1], (bool) pars[2], (float) pars[3]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_2c5d179c2ab74cd88afdcbe6c7390f1d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c5d179c2ab74cd88afdcbe6c7390f1d()
        {
          this.Initialize("devCommand", false, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("s", typeof (string), false, (object) null, false, false, false),
            new ParameterDescriptor("p", typeof (Educative.Point), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 1)
          {
            ((ContainerGame) obj).devCommand((string) pars[0], (Educative.Point) null);
            return (object) DynValue.Void;
          }
          ((ContainerGame) obj).devCommand((string) pars[0], (Educative.Point) pars[1]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_56f1c8d1b2c34d1eb3622c2ef01f9c9d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_56f1c8d1b2c34d1eb3622c2ef01f9c9d()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_a82444d4b4f34d1b802f220c567516bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a82444d4b4f34d1b802f220c567516bf()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_11664ff3e8794ec0866c334033f7b140 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_11664ff3e8794ec0866c334033f7b140()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_5f704554e6e74679b185694630394424 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5f704554e6e74679b185694630394424()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_1ed7abb9de4643fe801bd1630418b7a0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ed7abb9de4643fe801bd1630418b7a0()
        {
          this.Initialize("clearMap", false, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("newWidth", typeof (int), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("newHeight", typeof (int), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 0)
          {
            ((ContainerGame) obj).clearMap(-1, -1);
            return (object) DynValue.Void;
          }
          if (argscount <= 1)
          {
            ((ContainerGame) obj).clearMap((int) pars[0], -1);
            return (object) DynValue.Void;
          }
          ((ContainerGame) obj).clearMap((int) pars[0], (int) pars[1]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c40acb7cace643f89bb9115434b8c036 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c40acb7cace643f89bb9115434b8c036()
        {
          this.Initialize("getSpell", true, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("name", typeof (string), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ContainerGame.getSpell((string) pars[0]);
        }
      }

      private sealed class MTHD_07eb19a7f66f413881b8f47bc1accbd2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_07eb19a7f66f413881b8f47bc1accbd2()
        {
          this.Initialize("getSpellEnum", true, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("name", typeof (string), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ContainerGame.getSpellEnum((string) pars[0]);
        }
      }

      private sealed class MTHD_7c6ce7ba0b5a4b31ad90d5172d90450d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7c6ce7ba0b5a4b31ad90d5172d90450d()
        {
          this.Initialize("getSpellName", true, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("id", typeof (SpellEnum), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ContainerGame.getSpellName((SpellEnum) pars[0]);
        }
      }

      private sealed class MTHD_63223615f8674b8d9f287bdeb95f720c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_63223615f8674b8d9f287bdeb95f720c()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_f8b64e9cd096455e9ba4b160fb36f267 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f8b64e9cd096455e9ba4b160fb36f267()
        {
          this.Initialize("getMapRealName", true, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("id", typeof (MapEnum), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ContainerGame.getMapRealName((MapEnum) pars[0]);
        }
      }

      private sealed class MTHD_e4cf953a5c8542be97c16f2cd14c2cbf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e4cf953a5c8542be97c16f2cd14c2cbf()
        {
          this.Initialize("getMapShortName", true, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("id", typeof (MapEnum), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ContainerGame.getMapShortName((MapEnum) pars[0]);
        }
      }

      private sealed class MTHD_92888aeae50146319db3db6dc63d59f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_92888aeae50146319db3db6dc63d59f9()
        {
          this.Initialize("getArmageddonName", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("id", typeof (MapEnum), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getArmageddonName((MapEnum) pars[0]);
        }
      }

      private sealed class MTHD_a1f2f7db12e84106b87823758b5a5c53 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1f2f7db12e84106b87823758b5a5c53()
        {
          this.Initialize("panCamera", false, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("point", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("interuptable", typeof (bool), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 1)
          {
            ((ContainerGame) obj).panCamera((Educative.Point) pars[0], true);
            return (object) DynValue.Void;
          }
          ((ContainerGame) obj).panCamera((Educative.Point) pars[0], (bool) pars[1]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c3a207d988ae4903af1ab404e59f8eec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c3a207d988ae4903af1ab404e59f8eec()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_6ae4396ba9b64a3a98fbbf65b241ae12 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ae4396ba9b64a3a98fbbf65b241ae12()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_b4c6b2340d2f4871986acfc80d32d7fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b4c6b2340d2f4871986acfc80d32d7fa()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_8581078ca8214cc59b2a6425f2db21af : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8581078ca8214cc59b2a6425f2db21af()
        {
          this.Initialize("createCreature", false, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("script", typeof (Script), false, (object) null, false, false, false),
            new ParameterDescriptor("summon", typeof (Summon), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).createCreature((Script) pars[0], (Summon) pars[1]);
        }
      }

      private sealed class MTHD_c6f8ba13fc1d4bf097d469a5b997d419 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c6f8ba13fc1d4bf097d469a5b997d419()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ae38d2a3f13f46489f517d78d4b10b5a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae38d2a3f13f46489f517d78d4b10b5a()
        {
          this.Initialize("createIndicator", false, new ParameterDescriptor[6]
          {
            new ParameterDescriptor("kind", typeof (IndicatorKind), false, (object) null, false, false, false),
            new ParameterDescriptor("point", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("hexColor", typeof (string), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("radius", typeof (double), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("angle", typeof (double), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("lifetime", typeof (double), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 2)
            return (object) ((ContainerGame) obj).createIndicator((IndicatorKind) pars[0], (Educative.Point) pars[1], "#FFFFFF", 18.0, 0.0, 0.0);
          if (argscount <= 3)
            return (object) ((ContainerGame) obj).createIndicator((IndicatorKind) pars[0], (Educative.Point) pars[1], (string) pars[2], 18.0, 0.0, 0.0);
          if (argscount <= 4)
            return (object) ((ContainerGame) obj).createIndicator((IndicatorKind) pars[0], (Educative.Point) pars[1], (string) pars[2], (double) pars[3], 0.0, 0.0);
          return argscount <= 5 ? (object) ((ContainerGame) obj).createIndicator((IndicatorKind) pars[0], (Educative.Point) pars[1], (string) pars[2], (double) pars[3], (double) pars[4], 0.0) : (object) ((ContainerGame) obj).createIndicator((IndicatorKind) pars[0], (Educative.Point) pars[1], (string) pars[2], (double) pars[3], (double) pars[4], (double) pars[5]);
        }
      }

      private sealed class MTHD_de67ae1d2d2b4a0a82cb8cf97eb4013e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de67ae1d2d2b4a0a82cb8cf97eb4013e()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.Equals(pars[0]);
        }
      }

      private sealed class MTHD_0c30d8507a9e4d858562722a9f7f55e8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c30d8507a9e4d858562722a9f7f55e8()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_85933498c0f344738d79f59860ba3e87 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85933498c0f344738d79f59860ba3e87()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_43fc9a7460b341c5bcd99c6c3cf3eb69 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_43fc9a7460b341c5bcd99c6c3cf3eb69()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_1b3c9c92e0bb4631a12b9f207e3acb60 : HardwiredMemberDescriptor
      {
        internal PROP_1b3c9c92e0bb4631a12b9f207e3acb60()
          : base(typeof (int), "turn", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turn;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerGame) obj).turn = (int) value;
        }
      }

      private sealed class PROP_b26329a5bab54337825cac6863f3f8ed : HardwiredMemberDescriptor
      {
        internal PROP_b26329a5bab54337825cac6863f3f8ed()
          : base(typeof (int), "timeLimit", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerGame) obj).timeLimit = (int) value;
        }
      }

      private sealed class PROP_e5e1f0e758e24a219bb388961fa6da51 : HardwiredMemberDescriptor
      {
        internal PROP_e5e1f0e758e24a219bb388961fa6da51()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_862443743a6f4e09a7d5e7a8b9ce7d3f : HardwiredMemberDescriptor
      {
        internal PROP_862443743a6f4e09a7d5e7a8b9ce7d3f()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_91fb60e72a5a41dc84fe8de669fd2726 : HardwiredMemberDescriptor
      {
        internal PROP_91fb60e72a5a41dc84fe8de669fd2726()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_c04c454b6ecf46da952930d0d8bc5795 : HardwiredMemberDescriptor
      {
        internal PROP_c04c454b6ecf46da952930d0d8bc5795()
          : base(typeof (bool), "winOnDeath", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerGame) obj).winOnDeath = (bool) value;
        }
      }

      private sealed class PROP_fdde472efd074a0f804f5d53d70e1d80 : HardwiredMemberDescriptor
      {
        internal PROP_fdde472efd074a0f804f5d53d70e1d80()
          : base(typeof (bool), "allowMovement", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerGame) obj).allowMovement = (bool) value;
        }
      }

      private sealed class PROP_5960bf77f649471584cf9e5bbca87795 : HardwiredMemberDescriptor
      {
        internal PROP_5960bf77f649471584cf9e5bbca87795()
          : base(typeof (bool), "allowInput", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerGame) obj).allowInput = (bool) value;
        }
      }

      private sealed class PROP_d8febeb527a04429810f328a2b1b6dbb : HardwiredMemberDescriptor
      {
        internal PROP_d8febeb527a04429810f328a2b1b6dbb()
          : base(typeof (bool), "allowCallbacks", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerGame) obj).allowCallbacks = (bool) value;
        }
      }

      private sealed class PROP_d94f2a1ad2984b319b71c1a9d566aa0d : HardwiredMemberDescriptor
      {
        internal PROP_d94f2a1ad2984b319b71c1a9d566aa0d()
          : base(typeof (bool), "allowSkipTurn", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerGame) obj).allowSkipTurn = (bool) value;
        }
      }

      private sealed class PROP_ea18afb7016444ee89984e41b2ffaac8 : HardwiredMemberDescriptor
      {
        internal PROP_ea18afb7016444ee89984e41b2ffaac8()
          : base(typeof (bool), "terrainDestruction", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerGame) obj).terrainDestruction = (bool) value;
        }
      }

      private sealed class PROP_3cb055e5096f4380bfd2d4f396609b70 : HardwiredMemberDescriptor
      {
        internal PROP_3cb055e5096f4380bfd2d4f396609b70()
          : base(typeof (bool), "takeDamage", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerGame) obj).takeDamage = (bool) value;
        }
      }

      private sealed class PROP_f9120953582644bd86fb10f5c18db74a : HardwiredMemberDescriptor
      {
        internal PROP_f9120953582644bd86fb10f5c18db74a()
          : base(typeof (MapEnum), "armageddon", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerGame) obj).armageddon = (MapEnum) value;
        }
      }

      private sealed class PROP_c189b94c2f3141308bfe2f676e1e6956 : HardwiredMemberDescriptor
      {
        internal PROP_c189b94c2f3141308bfe2f676e1e6956()
          : base(typeof (int), "armageddonTurn", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerGame) obj).armageddonTurn = (int) value;
        }
      }

      private sealed class PROP_c796fc5c0fdf4050ad665d4768d2197e : HardwiredMemberDescriptor
      {
        internal PROP_c796fc5c0fdf4050ad665d4768d2197e()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_c499881eec5448a8ad08be1e061dd91c : HardwiredMemberDescriptor
      {
        internal PROP_c499881eec5448a8ad08be1e061dd91c()
          : base(typeof (bool), "paused", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).paused;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerGame) obj).paused = (bool) value;
        }
      }

      private sealed class PROP_e25b4cde80bf4f5aae715575d6d55ac4 : HardwiredMemberDescriptor
      {
        internal PROP_e25b4cde80bf4f5aae715575d6d55ac4()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_4c8ebd50f19f49aeb6656e3a7158b0b6 : HardwiredMemberDescriptor
      {
        internal PROP_4c8ebd50f19f49aeb6656e3a7158b0b6()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_be353ebd6e3348eab0c11e207faa52af : HardwiredMemberDescriptor
      {
        internal PROP_be353ebd6e3348eab0c11e207faa52af()
          : base(typeof (double), "gravity", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).gravity;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerGame) obj).gravity = (double) value;
        }
      }

      private sealed class PROP_5b5da6c4e13744609bca4068eff94609 : HardwiredMemberDescriptor
      {
        internal PROP_5b5da6c4e13744609bca4068eff94609()
          : base(typeof (bool), "wind", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).wind;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerGame) obj).wind = (bool) value;
        }
      }

      private sealed class PROP_6e8ae90b8e204a3b9f541bdf36d8c2e1 : HardwiredMemberDescriptor
      {
        internal PROP_6e8ae90b8e204a3b9f541bdf36d8c2e1()
          : base(typeof (double), "windDir", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).windDir;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerGame) obj).windDir = (double) value;
        }
      }

      private sealed class PROP_760c7860dcf44ce69254452f447ad216 : HardwiredMemberDescriptor
      {
        internal PROP_760c7860dcf44ce69254452f447ad216()
          : base(typeof (double), "windPower", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).windPower;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerGame) obj).windPower = (double) value;
        }
      }

      private sealed class PROP_e3ae8bb5e7424c5b949ca04f3bf0c251 : HardwiredMemberDescriptor
      {
        internal PROP_e3ae8bb5e7424c5b949ca04f3bf0c251()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_be2faf4ed1bc4f2b8eb8bb3e3194267a : HardwiredMemberDescriptor
      {
        internal PROP_be2faf4ed1bc4f2b8eb8bb3e3194267a()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_298e796ab83b4c4c87234568ac74e52a : HardwiredMemberDescriptor
      {
        internal PROP_298e796ab83b4c4c87234568ac74e52a()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_c732f84035e44237b4074c174d5d4af4 : HardwiredMemberDescriptor
      {
        internal PROP_c732f84035e44237b4074c174d5d4af4()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_bc2d75cc12ed4861a71f60b2e06a6da0 : HardwiredMemberDescriptor
      {
        internal PROP_bc2d75cc12ed4861a71f60b2e06a6da0()
          : base(typeof (Educative.Point), "cameraPosition", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerGame) obj).cameraPosition = (Educative.Point) value;
        }
      }

      private sealed class PROP_e098a90a848e4172bad1922569ed3858 : HardwiredMemberDescriptor
      {
        internal PROP_e098a90a848e4172bad1922569ed3858()
          : base(typeof (double), "cameraZoom", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerGame) obj).cameraZoom = (double) value;
        }
      }

      private sealed class PROP_be03712623f84ab8b011dce384d3b75f : HardwiredMemberDescriptor
      {
        internal PROP_be03712623f84ab8b011dce384d3b75f()
          : base(typeof (bool), "allowBounce", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerGame) obj).allowBounce = (bool) value;
        }
      }

      private sealed class PROP_7375e901f57b4ae0b9a169131639711e : HardwiredMemberDescriptor
      {
        internal PROP_7375e901f57b4ae0b9a169131639711e()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_31a50b79221b4935922791a76abccefe : HardwiredMemberDescriptor
      {
        internal PROP_31a50b79221b4935922791a76abccefe()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_fed3d15eef7c40c3b907d9232cf36ff3 : HardwiredMemberDescriptor
      {
        internal PROP_fed3d15eef7c40c3b907d9232cf36ff3()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_065805549d3b4cfab68aac7036214cf6 : HardwiredUserDataDescriptor
    {
      internal TYPE_065805549d3b4cfab68aac7036214cf6()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_065805549d3b4cfab68aac7036214cf6.MTHD_c165210346f7494d910e151a49d7dca0()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_065805549d3b4cfab68aac7036214cf6.MTHD_db9acb58bd0d44dfa90e6170bde8acf6()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_065805549d3b4cfab68aac7036214cf6.MTHD_64e48e9cc93b49dab21c2d72daf742c6()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_065805549d3b4cfab68aac7036214cf6.MTHD_f11715f3a4b944689978d005e0935475()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_065805549d3b4cfab68aac7036214cf6.MTHD_715464c4426d4e06a81fd56c0f439dc0()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_065805549d3b4cfab68aac7036214cf6.MTHD_b9c8c230a1d34347b7b70619d9a053a8()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_065805549d3b4cfab68aac7036214cf6.MTHD_4ce5fdba2c69477380f9a1062bd269aa()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_065805549d3b4cfab68aac7036214cf6.MTHD_21db58fed9e34207bc39316df7709a71()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_065805549d3b4cfab68aac7036214cf6.MTHD_3ca1abf89fbb482a8948c03ed874652c()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_065805549d3b4cfab68aac7036214cf6.MTHD_465a104c918e4021ba3fa82aa3b11fdb()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_065805549d3b4cfab68aac7036214cf6.MTHD_e2ec1c50526440399ccefef39edbc985()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_065805549d3b4cfab68aac7036214cf6.MTHD_4baa6b1a96d849f78e8ac113d47d5784()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_065805549d3b4cfab68aac7036214cf6.PROP_e05b289639154502bd1f4914d168a11a());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_065805549d3b4cfab68aac7036214cf6.PROP_ca5537b45e47425b9b68257ad4c82eba());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_065805549d3b4cfab68aac7036214cf6.PROP_363c6787e271450b83a462c6b7d8d3e9());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_065805549d3b4cfab68aac7036214cf6.PROP_53d01aaaea4740b1b965477e3566bca8());
      }

      private sealed class MTHD_c165210346f7494d910e151a49d7dca0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c165210346f7494d910e151a49d7dca0()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_db9acb58bd0d44dfa90e6170bde8acf6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db9acb58bd0d44dfa90e6170bde8acf6()
        {
          this.Initialize("set_localTurn", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerPlayer) obj).localTurn = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_64e48e9cc93b49dab21c2d72daf742c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_64e48e9cc93b49dab21c2d72daf742c6()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_f11715f3a4b944689978d005e0935475 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f11715f3a4b944689978d005e0935475()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_715464c4426d4e06a81fd56c0f439dc0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_715464c4426d4e06a81fd56c0f439dc0()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_b9c8c230a1d34347b7b70619d9a053a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b9c8c230a1d34347b7b70619d9a053a8()
        {
          this.Initialize("getCreatures", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("script", typeof (Script), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getCreatures((Script) pars[0]);
        }
      }

      private sealed class MTHD_4ce5fdba2c69477380f9a1062bd269aa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ce5fdba2c69477380f9a1062bd269aa()
        {
          this.Initialize("getCreature", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("index", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getCreature((int) pars[0]);
        }
      }

      private sealed class MTHD_21db58fed9e34207bc39316df7709a71 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_21db58fed9e34207bc39316df7709a71()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_3ca1abf89fbb482a8948c03ed874652c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3ca1abf89fbb482a8948c03ed874652c()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_465a104c918e4021ba3fa82aa3b11fdb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_465a104c918e4021ba3fa82aa3b11fdb()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.Equals(pars[0]);
        }
      }

      private sealed class MTHD_e2ec1c50526440399ccefef39edbc985 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e2ec1c50526440399ccefef39edbc985()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_4baa6b1a96d849f78e8ac113d47d5784 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4baa6b1a96d849f78e8ac113d47d5784()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_e05b289639154502bd1f4914d168a11a : HardwiredMemberDescriptor
      {
        internal PROP_e05b289639154502bd1f4914d168a11a()
          : base(typeof (int), "localTurn", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerPlayer) obj).localTurn = (int) value;
        }
      }

      private sealed class PROP_ca5537b45e47425b9b68257ad4c82eba : HardwiredMemberDescriptor
      {
        internal PROP_ca5537b45e47425b9b68257ad4c82eba()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_363c6787e271450b83a462c6b7d8d3e9 : HardwiredMemberDescriptor
      {
        internal PROP_363c6787e271450b83a462c6b7d8d3e9()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_53d01aaaea4740b1b965477e3566bca8 : HardwiredMemberDescriptor
      {
        internal PROP_53d01aaaea4740b1b965477e3566bca8()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca : HardwiredUserDataDescriptor
    {
      internal TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_6c3ec604ae154113994db65a943f5e7d()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_8cbaedd3e71047d6813797f6028afc9b()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_38e71c6d82be469380f553fbeb88ada8()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_a548ba86e2b24e9c88a20d4b9f375479()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_43841728b8c849f2b7760c964ad906b6()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_3ea8623a25f84c3f9d839aa022a030df()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_f081a470b40749b7a3d9a7532d5ef0f4()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_20f0b4af9bcd4a40b4342dd004c64429()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_9e8119734e934944b5a8c1b6d85f4387()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_5937b1a54c17481fa21f07559aca7299()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_db048117ed4941a5b8642ee6d3a5f1d8()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_72fd0291462d43f487c6ca439a98c213()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_15b7a20fdefd4b78b8f9a8ff4a2b36a2()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_3c69e9ddd0f34eefa5d50444b3800fc4()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_286494caa5594858bb33c45818a1a67e()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_6b38375b128342ebb9324080b2da17d3()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_f32e355cb37a4ad793a438ff9bfa42cd()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_f5c124244bcf4e3e996395d27df0f70d()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_5150d2bdc6a54739ae37703b06d3a330()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_19a756fe94c94e208009a49ba1fdfc90()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_34cce751be454792b9c2ec3346a623eb()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_76b88c6a33bc4e238e5a256f4b1a8a01()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_edfd8021b3a04c4a84b863610c117c94()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_fec4f1f06e14450e9ed65e85340048c7()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_0a3ed17e5e274f8bb6ce55f17e366c90()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_509175be245f4e9c9702413bf69c85e7()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_743b42d79d9a46e88234cb6065c8e4b0()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_b2c0cfc0d16c4abbbc47e92482b86953()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_f4817b31e42c42588edd6be66ab7b859()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_26a94b20e37d45e7b90656b848f4a297()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_bf5ff4e72edb4206a08dd3950013944e()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_b86a1d57396044f9aefdd8fa7de053ae()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_041a7ee6ab8640edab080d87042e82ba()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_fd7405cfe93a49d99120e9b4fc8d86b4()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_a86bc6d59c914fb8a5abd05969906bda()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_0f98c9da597343cd89688b21121bbc81()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_aa08683cda0c432690b55283c8684f91()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_f0acbbd315d44d649bbdd4fd241d37e1()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_9cde8a247b924551a38b92ee9300f085()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_eacb56d85f154913b0f2a8216c0bdaae()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_c42e38ac764c4ccc885f2f23193f69c4()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_53c96c70d62740f3bb31dc83f8bb1a2b()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_4b3156b1df364696b5d7d4aa9cc63887()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_c79d310d71b04d7da114572b7f752aa4()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_cd4638c9b2d04be2978243dd8c6bf1df()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_eaf27afe2fff47b499fa932e70fb5e3f()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_e5d9223b369046a98d5f69c3ec5adfe8()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_c54725c451b54bfdb5c47b8bc09d8823()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_277510ae9d904ff5b559044b3b8627e4()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_44d67fe4c31a494dbe3cc338ef326e4e()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_0e94fc3756a145b785d359af3d1fd4f5()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_95e2c5a1ce4a4531ac51b1f52503ad73()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_a90600d3f349433e8052b2d8208072bb()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_70902638f2c34ff3beb0ae003ebc4d03()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_07ffb328ee1f4f019d067b14f513cd4c()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_f356c56a17ae41af8e7ccf59897fe635()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_623efb7a1ee54076aacbf2fef4105be8()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_f1a9620024fe43ffb1df3f5d67b2c482()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_3f25cca45a4f465f891e1aab0f33a38c()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_57e939074a904419a037079bc477a31e()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_46b6745bcf9c4a4183dd482847ffa121()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_b30978ad65264cabb285237f2160fc0b()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_73bd7f1fcb504ec1a524ed93d7ea4c67()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_5267d2fcaa304b31b92bf2db6f4c0ca5(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_d6d275ae8c714e428f067fca63d43031()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_c72571dd16c8428eb5278b867687118e(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_67a5aa45fc814ff3ac673a9c90896c02()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_e30f043723994e07b903c7b5b3144874()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_e0b17986cacd4d9184207547dc3728d2()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_530c522e001c4ddbb9ec4f5c0e8856a3(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_cf4554ee511745b598788c7d08ca83b1()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_74a1c34d6eda481c8fffb137d23b794c()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_a199a727847948c1933769f27bb8b69f()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_9d7b37ae5c844212b5976cf407f31615()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_aa3bdd64fb674c308d5e3ae20d10f951()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_de27b39fe7154929a32c71cd721ff16a()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_0f387dfbc0c94e75be68efb0386c7444()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_6937d4b4d62649cda73b592c3f660668()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_41a54a5af1b0448fb39240076e020cdd()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_7b8d1d75d548492f88389c0076e8cf2e(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_9f2176f5ffc84c0a8d09c9b8a511b47e()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_6e15314416a94e8eb5b0cc73e48b9639(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_e8a7908b60ba484eb8eca832e1fdbe2b()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_4283ebfa49f947b1bc68fb418145752f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_c40fedb6670d4afea24bbe417f2caf0c()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_de807bc368764a83aadb12e81fbd4673()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_071218671d7b4504a385de4f1403c63b()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_8762ee6edce34155b632cea728b73bfa()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.MTHD_b9b8c4e55b6d4e31acb45d551fee23bd()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_ea614ba682ec414eacbdb860ea9cce3b());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_7c476409fb5d4cf2bf5989a41651467b());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_bf5a7b465513480b943ae1a2c138dea0());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_71a8e5abd7c14f80b35836405282700a());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_e6cac898d37749c9924f6bf8e16c92ba());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_ab7f963f5740495bb843befd44524803());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_56a472d41ec1416293d90c9fc05df6d9());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_d9eede99cada445c8c370c6b851edfd8());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_9f63c9a4ed03427887d1d7a459319121());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_61060252f57f4ed296fdfb2e371f6468());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_90bf5a7b0a194889aac226b4b95575bb());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_b26f8c662de4465187bb2121618cc3a9());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_90dfc8557f0048848b262b861c9156b4());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_e51ad8bc6f1f4b329b5ee4db0b64ad25());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_7aa1cd5173664fef8da2b6788aad4c4d());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_267f2d21016541e0964d5723076e31e8());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_998b13e3363f438b8f2f4bc3078e8e53());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_a891ad5e1d72429cbccca5644c6729ed());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_3977c1a2083445ba98ca58b1b361e8df());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_fdbfecf5af9e4e8f9a31a590e02c7f69());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_fdc9b1f5eebc469ea5c9c51e32ca05eb());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_e189e6ceacc64fcabf6706253a87e130());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_fad1b15b5d144615ba46601460c382af());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_ffa9d87ce46748749c151f9e8ed20028());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_49f8d63470f348999102387a151f9fb8());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_bb1f2a3b48b34033b22888dc0f020b50());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_830be3517c524337a4c47f7951ecbb28());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_97f449ee62fd49f78ce04b86287f7e9a());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_4002ce3a283943f4b1b485b14994d409());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_aae4b61799b644c5b244d5c056568560());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_989fb594d42048638a2a672357fd8af5());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_6ddcd77e2f7548938227d20bf9fed610());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_ae99b1df7a3d4ed4974cc3a6a60861ca.PROP_7eb2e49c9cf145c3b141363a1a3ac22a());
      }

      private sealed class MTHD_6c3ec604ae154113994db65a943f5e7d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6c3ec604ae154113994db65a943f5e7d()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_8cbaedd3e71047d6813797f6028afc9b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8cbaedd3e71047d6813797f6028afc9b()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_38e71c6d82be469380f553fbeb88ada8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_38e71c6d82be469380f553fbeb88ada8()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_a548ba86e2b24e9c88a20d4b9f375479 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a548ba86e2b24e9c88a20d4b9f375479()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_43841728b8c849f2b7760c964ad906b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_43841728b8c849f2b7760c964ad906b6()
        {
          this.Initialize("set_health", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).health = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_3ea8623a25f84c3f9d839aa022a030df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3ea8623a25f84c3f9d839aa022a030df()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_f081a470b40749b7a3d9a7532d5ef0f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f081a470b40749b7a3d9a7532d5ef0f4()
        {
          this.Initialize("set_maxHealth", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).maxHealth = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_20f0b4af9bcd4a40b4342dd004c64429 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_20f0b4af9bcd4a40b4342dd004c64429()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_9e8119734e934944b5a8c1b6d85f4387 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e8119734e934944b5a8c1b6d85f4387()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_5937b1a54c17481fa21f07559aca7299 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5937b1a54c17481fa21f07559aca7299()
        {
          this.Initialize("set_shield", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).shield = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_db048117ed4941a5b8642ee6d3a5f1d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db048117ed4941a5b8642ee6d3a5f1d8()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_72fd0291462d43f487c6ca439a98c213 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_72fd0291462d43f487c6ca439a98c213()
        {
          this.Initialize("set_x", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).x = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_15b7a20fdefd4b78b8f9a8ff4a2b36a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15b7a20fdefd4b78b8f9a8ff4a2b36a2()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_3c69e9ddd0f34eefa5d50444b3800fc4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3c69e9ddd0f34eefa5d50444b3800fc4()
        {
          this.Initialize("set_y", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).y = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_286494caa5594858bb33c45818a1a67e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_286494caa5594858bb33c45818a1a67e()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_6b38375b128342ebb9324080b2da17d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b38375b128342ebb9324080b2da17d3()
        {
          this.Initialize("set_position", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (Educative.Point), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).position = (Educative.Point) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_f32e355cb37a4ad793a438ff9bfa42cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f32e355cb37a4ad793a438ff9bfa42cd()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_f5c124244bcf4e3e996395d27df0f70d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f5c124244bcf4e3e996395d27df0f70d()
        {
          this.Initialize("set_parent", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (ContainerPlayer), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).parent = (ContainerPlayer) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_5150d2bdc6a54739ae37703b06d3a330 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5150d2bdc6a54739ae37703b06d3a330()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_19a756fe94c94e208009a49ba1fdfc90 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_19a756fe94c94e208009a49ba1fdfc90()
        {
          this.Initialize("set_weight", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).weight = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_34cce751be454792b9c2ec3346a623eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_34cce751be454792b9c2ec3346a623eb()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_76b88c6a33bc4e238e5a256f4b1a8a01 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76b88c6a33bc4e238e5a256f4b1a8a01()
        {
          this.Initialize("set_radius", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).radius = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_edfd8021b3a04c4a84b863610c117c94 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_edfd8021b3a04c4a84b863610c117c94()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_fec4f1f06e14450e9ed65e85340048c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fec4f1f06e14450e9ed65e85340048c7()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_0a3ed17e5e274f8bb6ce55f17e366c90 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0a3ed17e5e274f8bb6ce55f17e366c90()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_509175be245f4e9c9702413bf69c85e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_509175be245f4e9c9702413bf69c85e7()
        {
          this.Initialize("set_stunned", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).stunned = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_743b42d79d9a46e88234cb6065c8e4b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_743b42d79d9a46e88234cb6065c8e4b0()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_b2c0cfc0d16c4abbbc47e92482b86953 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b2c0cfc0d16c4abbbc47e92482b86953()
        {
          this.Initialize("set_superStunned", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).superStunned = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_f4817b31e42c42588edd6be66ab7b859 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4817b31e42c42588edd6be66ab7b859()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_26a94b20e37d45e7b90656b848f4a297 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_26a94b20e37d45e7b90656b848f4a297()
        {
          this.Initialize("set_waterWalking", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).waterWalking = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_bf5ff4e72edb4206a08dd3950013944e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf5ff4e72edb4206a08dd3950013944e()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_b86a1d57396044f9aefdd8fa7de053ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b86a1d57396044f9aefdd8fa7de053ae()
        {
          this.Initialize("set_frostWalking", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).frostWalking = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_041a7ee6ab8640edab080d87042e82ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_041a7ee6ab8640edab080d87042e82ba()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_fd7405cfe93a49d99120e9b4fc8d86b4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd7405cfe93a49d99120e9b4fc8d86b4()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_a86bc6d59c914fb8a5abd05969906bda : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a86bc6d59c914fb8a5abd05969906bda()
        {
          this.Initialize("set_diesInWater", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).diesInWater = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_0f98c9da597343cd89688b21121bbc81 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f98c9da597343cd89688b21121bbc81()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_aa08683cda0c432690b55283c8684f91 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa08683cda0c432690b55283c8684f91()
        {
          this.Initialize("set_type", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (CreatureType), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).type = (CreatureType) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_f0acbbd315d44d649bbdd4fd241d37e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f0acbbd315d44d649bbdd4fd241d37e1()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_9cde8a247b924551a38b92ee9300f085 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9cde8a247b924551a38b92ee9300f085()
        {
          this.Initialize("set_race", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (CreatureRace), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).race = (CreatureRace) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_eacb56d85f154913b0f2a8216c0bdaae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eacb56d85f154913b0f2a8216c0bdaae()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_c42e38ac764c4ccc885f2f23193f69c4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c42e38ac764c4ccc885f2f23193f69c4()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_53c96c70d62740f3bb31dc83f8bb1a2b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_53c96c70d62740f3bb31dc83f8bb1a2b()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_4b3156b1df364696b5d7d4aa9cc63887 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b3156b1df364696b5d7d4aa9cc63887()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_c79d310d71b04d7da114572b7f752aa4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c79d310d71b04d7da114572b7f752aa4()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_cd4638c9b2d04be2978243dd8c6bf1df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd4638c9b2d04be2978243dd8c6bf1df()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_eaf27afe2fff47b499fa932e70fb5e3f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eaf27afe2fff47b499fa932e70fb5e3f()
        {
          this.Initialize("set_isFlying", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).isFlying = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_e5d9223b369046a98d5f69c3ec5adfe8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e5d9223b369046a98d5f69c3ec5adfe8()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_c54725c451b54bfdb5c47b8bc09d8823 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c54725c451b54bfdb5c47b8bc09d8823()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_277510ae9d904ff5b559044b3b8627e4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_277510ae9d904ff5b559044b3b8627e4()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_44d67fe4c31a494dbe3cc338ef326e4e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_44d67fe4c31a494dbe3cc338ef326e4e()
        {
          this.Initialize("set_arcaneMonster", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).arcaneMonster = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_0e94fc3756a145b785d359af3d1fd4f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e94fc3756a145b785d359af3d1fd4f5()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_95e2c5a1ce4a4531ac51b1f52503ad73 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95e2c5a1ce4a4531ac51b1f52503ad73()
        {
          this.Initialize("set_takeDamage", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).takeDamage = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_a90600d3f349433e8052b2d8208072bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a90600d3f349433e8052b2d8208072bb()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_70902638f2c34ff3beb0ae003ebc4d03 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70902638f2c34ff3beb0ae003ebc4d03()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_07ffb328ee1f4f019d067b14f513cd4c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_07ffb328ee1f4f019d067b14f513cd4c()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_f356c56a17ae41af8e7ccf59897fe635 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f356c56a17ae41af8e7ccf59897fe635()
        {
          this.Initialize("LongJump", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("dir", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).LongJump((int) pars[0]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_623efb7a1ee54076aacbf2fef4105be8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_623efb7a1ee54076aacbf2fef4105be8()
        {
          this.Initialize("HighJump", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("dir", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).HighJump((int) pars[0]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f1a9620024fe43ffb1df3f5d67b2c482 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f1a9620024fe43ffb1df3f5d67b2c482()
        {
          this.Initialize("Walk", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("dir", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).Walk((int) pars[0]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_3f25cca45a4f465f891e1aab0f33a38c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f25cca45a4f465f891e1aab0f33a38c()
        {
          this.Initialize("setDirection", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("dir", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).setDirection((int) pars[0]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_57e939074a904419a037079bc477a31e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57e939074a904419a037079bc477a31e()
        {
          this.Initialize("getFamiliarLevel", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("book", typeof (BookOf), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getFamiliarLevel((BookOf) pars[0]);
        }
      }

      private sealed class MTHD_46b6745bcf9c4a4183dd482847ffa121 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_46b6745bcf9c4a4183dd482847ffa121()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_b30978ad65264cabb285237f2160fc0b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b30978ad65264cabb285237f2160fc0b()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_73bd7f1fcb504ec1a524ed93d7ea4c67 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_73bd7f1fcb504ec1a524ed93d7ea4c67()
        {
          this.Initialize("increaseFamiliarLevel", false, new ParameterDescriptor[3]
          {
            new ParameterDescriptor("book", typeof (BookOf), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("dealDmg", typeof (bool), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("capAt5", typeof (bool), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 0)
          {
            ((ContainerCreature) obj).increaseFamiliarLevel(BookOf.Nothing, true, true);
            return (object) DynValue.Void;
          }
          if (argscount <= 1)
          {
            ((ContainerCreature) obj).increaseFamiliarLevel((BookOf) pars[0], true, true);
            return (object) DynValue.Void;
          }
          if (argscount <= 2)
          {
            ((ContainerCreature) obj).increaseFamiliarLevel((BookOf) pars[0], (bool) pars[1], true);
            return (object) DynValue.Void;
          }
          ((ContainerCreature) obj).increaseFamiliarLevel((BookOf) pars[0], (bool) pars[1], (bool) pars[2]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_5267d2fcaa304b31b92bf2db6f4c0ca5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5267d2fcaa304b31b92bf2db6f4c0ca5()
        {
          this.Initialize("inside", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("a", typeof (ContainerIndicator), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inside((ContainerIndicator) pars[0]);
        }
      }

      private sealed class MTHD_d6d275ae8c714e428f067fca63d43031 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6d275ae8c714e428f067fca63d43031()
        {
          this.Initialize("inside", false, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("a", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("radius", typeof (double), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inside((Educative.Point) pars[0], (double) pars[1]);
        }
      }

      private sealed class MTHD_c72571dd16c8428eb5278b867687118e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c72571dd16c8428eb5278b867687118e()
        {
          this.Initialize("overlap", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("a", typeof (ContainerIndicator), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).overlap((ContainerIndicator) pars[0]);
        }
      }

      private sealed class MTHD_67a5aa45fc814ff3ac673a9c90896c02 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67a5aa45fc814ff3ac673a9c90896c02()
        {
          this.Initialize("overlap", false, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("a", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("radius", typeof (double), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return argscount <= 1 ? (object) ((ContainerCreature) obj).overlap((Educative.Point) pars[0], 0.0) : (object) ((ContainerCreature) obj).overlap((Educative.Point) pars[0], (double) pars[1]);
        }
      }

      private sealed class MTHD_e30f043723994e07b903c7b5b3144874 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e30f043723994e07b903c7b5b3144874()
        {
          this.Initialize("die", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("playSound", typeof (bool), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 0)
          {
            ((ContainerCreature) obj).die(true);
            return (object) DynValue.Void;
          }
          ((ContainerCreature) obj).die((bool) pars[0]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_e0b17986cacd4d9184207547dc3728d2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e0b17986cacd4d9184207547dc3728d2()
        {
          this.Initialize("addSpell", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("s", typeof (object), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).addSpell(pars[0]);
        }
      }

      private sealed class MTHD_530c522e001c4ddbb9ec4f5c0e8856a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_530c522e001c4ddbb9ec4f5c0e8856a3()
        {
          this.Initialize("removeSpell", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("s", typeof (object), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).removeSpell(pars[0]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_cf4554ee511745b598788c7d08ca83b1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf4554ee511745b598788c7d08ca83b1()
        {
          this.Initialize("removeSpell", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("spell", typeof (ContainerSpell), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).removeSpell((ContainerSpell) pars[0]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_74a1c34d6eda481c8fffb137d23b794c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74a1c34d6eda481c8fffb137d23b794c()
        {
          this.Initialize("getSpells", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("script", typeof (Script), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpells((Script) pars[0]);
        }
      }

      private sealed class MTHD_a199a727847948c1933769f27bb8b69f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a199a727847948c1933769f27bb8b69f()
        {
          this.Initialize("getSpell", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("spellObj", typeof (object), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpell(pars[0]);
        }
      }

      private sealed class MTHD_9d7b37ae5c844212b5976cf407f31615 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d7b37ae5c844212b5976cf407f31615()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_aa3bdd64fb674c308d5e3ae20d10f951 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa3bdd64fb674c308d5e3ae20d10f951()
        {
          this.Initialize("castedCount", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("spellID", typeof (SpellEnum), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCount((SpellEnum) pars[0]);
        }
      }

      private sealed class MTHD_de27b39fe7154929a32c71cd721ff16a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de27b39fe7154929a32c71cd721ff16a()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_0f387dfbc0c94e75be68efb0386c7444 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f387dfbc0c94e75be68efb0386c7444()
        {
          this.Initialize("castedDamage", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("spellID", typeof (SpellEnum), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedDamage((SpellEnum) pars[0]);
        }
      }

      private sealed class MTHD_6937d4b4d62649cda73b592c3f660668 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6937d4b4d62649cda73b592c3f660668()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_41a54a5af1b0448fb39240076e020cdd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41a54a5af1b0448fb39240076e020cdd()
        {
          this.Initialize("castSpell", false, new ParameterDescriptor[5]
          {
            new ParameterDescriptor("spellObj", typeof (object), false, (object) null, false, false, false),
            new ParameterDescriptor("target", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("angle", typeof (double), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("power", typeof (double), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("secTarget", typeof (Educative.Point), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 2)
          {
            ((ContainerCreature) obj).castSpell(pars[0], (Educative.Point) pars[1], 0.0, 1.0, (Educative.Point) null);
            return (object) DynValue.Void;
          }
          if (argscount <= 3)
          {
            ((ContainerCreature) obj).castSpell(pars[0], (Educative.Point) pars[1], (double) pars[2], 1.0, (Educative.Point) null);
            return (object) DynValue.Void;
          }
          if (argscount <= 4)
          {
            ((ContainerCreature) obj).castSpell(pars[0], (Educative.Point) pars[1], (double) pars[2], (double) pars[3], (Educative.Point) null);
            return (object) DynValue.Void;
          }
          ((ContainerCreature) obj).castSpell(pars[0], (Educative.Point) pars[1], (double) pars[2], (double) pars[3], (Educative.Point) pars[4]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_7b8d1d75d548492f88389c0076e8cf2e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b8d1d75d548492f88389c0076e8cf2e()
        {
          this.Initialize("fireAt", false, new ParameterDescriptor[3]
          {
            new ParameterDescriptor("spellObj", typeof (object), false, (object) null, false, false, false),
            new ParameterDescriptor("target", typeof (ContainerCreature), false, (object) null, false, false, false),
            new ParameterDescriptor("anglevariance", typeof (double), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 2)
          {
            ((ContainerCreature) obj).fireAt(pars[0], (ContainerCreature) pars[1], 0.0);
            return (object) DynValue.Void;
          }
          ((ContainerCreature) obj).fireAt(pars[0], (ContainerCreature) pars[1], (double) pars[2]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9f2176f5ffc84c0a8d09c9b8a511b47e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f2176f5ffc84c0a8d09c9b8a511b47e()
        {
          this.Initialize("fireAt", false, new ParameterDescriptor[4]
          {
            new ParameterDescriptor("spellObj", typeof (object), false, (object) null, false, false, false),
            new ParameterDescriptor("target", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("anglevariance", typeof (double), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("secTarget", typeof (Educative.Point), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 2)
          {
            ((ContainerCreature) obj).fireAt(pars[0], (Educative.Point) pars[1], 0.0, (Educative.Point) null);
            return (object) DynValue.Void;
          }
          if (argscount <= 3)
          {
            ((ContainerCreature) obj).fireAt(pars[0], (Educative.Point) pars[1], (double) pars[2], (Educative.Point) null);
            return (object) DynValue.Void;
          }
          ((ContainerCreature) obj).fireAt(pars[0], (Educative.Point) pars[1], (double) pars[2], (Educative.Point) pars[3]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_6e15314416a94e8eb5b0cc73e48b9639 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e15314416a94e8eb5b0cc73e48b9639()
        {
          this.Initialize("getEffectors", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("script", typeof (Script), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getEffectors((Script) pars[0]);
        }
      }

      private sealed class MTHD_e8a7908b60ba484eb8eca832e1fdbe2b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e8a7908b60ba484eb8eca832e1fdbe2b()
        {
          this.Initialize("getEffectors", false, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("script", typeof (Script), false, (object) null, false, false, false),
            new ParameterDescriptor("destroyable", typeof (bool), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getEffectors((Script) pars[0], (bool) pars[1]);
        }
      }

      private sealed class MTHD_4283ebfa49f947b1bc68fb418145752f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4283ebfa49f947b1bc68fb418145752f()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).Equals(pars[0]);
        }
      }

      private sealed class MTHD_c40fedb6670d4afea24bbe417f2caf0c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c40fedb6670d4afea24bbe417f2caf0c()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_de807bc368764a83aadb12e81fbd4673 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de807bc368764a83aadb12e81fbd4673()
        {
          this.Initialize("op_Equality", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("v", typeof (ContainerCreature), false, (object) null, false, false, false),
            new ParameterDescriptor("x", typeof (ContainerCreature), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) pars[0] == (ContainerCreature) pars[1]);
        }
      }

      private sealed class MTHD_071218671d7b4504a385de4f1403c63b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_071218671d7b4504a385de4f1403c63b()
        {
          this.Initialize("op_Inequality", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("v", typeof (ContainerCreature), false, (object) null, false, false, false),
            new ParameterDescriptor("x", typeof (ContainerCreature), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) pars[0] != (ContainerCreature) pars[1]);
        }
      }

      private sealed class MTHD_8762ee6edce34155b632cea728b73bfa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8762ee6edce34155b632cea728b73bfa()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_b9b8c4e55b6d4e31acb45d551fee23bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b9b8c4e55b6d4e31acb45d551fee23bd()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_ea614ba682ec414eacbdb860ea9cce3b : HardwiredMemberDescriptor
      {
        internal PROP_ea614ba682ec414eacbdb860ea9cce3b()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_7c476409fb5d4cf2bf5989a41651467b : HardwiredMemberDescriptor
      {
        internal PROP_7c476409fb5d4cf2bf5989a41651467b()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_bf5a7b465513480b943ae1a2c138dea0 : HardwiredMemberDescriptor
      {
        internal PROP_bf5a7b465513480b943ae1a2c138dea0()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_71a8e5abd7c14f80b35836405282700a : HardwiredMemberDescriptor
      {
        internal PROP_71a8e5abd7c14f80b35836405282700a()
          : base(typeof (int), "health", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).health;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerCreature) obj).health = (int) value;
        }
      }

      private sealed class PROP_e6cac898d37749c9924f6bf8e16c92ba : HardwiredMemberDescriptor
      {
        internal PROP_e6cac898d37749c9924f6bf8e16c92ba()
          : base(typeof (int), "maxHealth", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerCreature) obj).maxHealth = (int) value;
        }
      }

      private sealed class PROP_ab7f963f5740495bb843befd44524803 : HardwiredMemberDescriptor
      {
        internal PROP_ab7f963f5740495bb843befd44524803()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_56a472d41ec1416293d90c9fc05df6d9 : HardwiredMemberDescriptor
      {
        internal PROP_56a472d41ec1416293d90c9fc05df6d9()
          : base(typeof (int), "shield", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).shield;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerCreature) obj).shield = (int) value;
        }
      }

      private sealed class PROP_d9eede99cada445c8c370c6b851edfd8 : HardwiredMemberDescriptor
      {
        internal PROP_d9eede99cada445c8c370c6b851edfd8()
          : base(typeof (int), "x", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).x;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerCreature) obj).x = (int) value;
        }
      }

      private sealed class PROP_9f63c9a4ed03427887d1d7a459319121 : HardwiredMemberDescriptor
      {
        internal PROP_9f63c9a4ed03427887d1d7a459319121()
          : base(typeof (int), "y", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).y;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerCreature) obj).y = (int) value;
        }
      }

      private sealed class PROP_61060252f57f4ed296fdfb2e371f6468 : HardwiredMemberDescriptor
      {
        internal PROP_61060252f57f4ed296fdfb2e371f6468()
          : base(typeof (Educative.Point), "position", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).position;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerCreature) obj).position = (Educative.Point) value;
        }
      }

      private sealed class PROP_90bf5a7b0a194889aac226b4b95575bb : HardwiredMemberDescriptor
      {
        internal PROP_90bf5a7b0a194889aac226b4b95575bb()
          : base(typeof (ContainerPlayer), "parent", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).parent;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerCreature) obj).parent = (ContainerPlayer) value;
        }
      }

      private sealed class PROP_b26f8c662de4465187bb2121618cc3a9 : HardwiredMemberDescriptor
      {
        internal PROP_b26f8c662de4465187bb2121618cc3a9()
          : base(typeof (int), "weight", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).weight;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerCreature) obj).weight = (int) value;
        }
      }

      private sealed class PROP_90dfc8557f0048848b262b861c9156b4 : HardwiredMemberDescriptor
      {
        internal PROP_90dfc8557f0048848b262b861c9156b4()
          : base(typeof (int), "radius", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).radius;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerCreature) obj).radius = (int) value;
        }
      }

      private sealed class PROP_e51ad8bc6f1f4b329b5ee4db0b64ad25 : HardwiredMemberDescriptor
      {
        internal PROP_e51ad8bc6f1f4b329b5ee4db0b64ad25()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_7aa1cd5173664fef8da2b6788aad4c4d : HardwiredMemberDescriptor
      {
        internal PROP_7aa1cd5173664fef8da2b6788aad4c4d()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_267f2d21016541e0964d5723076e31e8 : HardwiredMemberDescriptor
      {
        internal PROP_267f2d21016541e0964d5723076e31e8()
          : base(typeof (bool), "stunned", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerCreature) obj).stunned = (bool) value;
        }
      }

      private sealed class PROP_998b13e3363f438b8f2f4bc3078e8e53 : HardwiredMemberDescriptor
      {
        internal PROP_998b13e3363f438b8f2f4bc3078e8e53()
          : base(typeof (bool), "superStunned", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerCreature) obj).superStunned = (bool) value;
        }
      }

      private sealed class PROP_a891ad5e1d72429cbccca5644c6729ed : HardwiredMemberDescriptor
      {
        internal PROP_a891ad5e1d72429cbccca5644c6729ed()
          : base(typeof (bool), "waterWalking", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerCreature) obj).waterWalking = (bool) value;
        }
      }

      private sealed class PROP_3977c1a2083445ba98ca58b1b361e8df : HardwiredMemberDescriptor
      {
        internal PROP_3977c1a2083445ba98ca58b1b361e8df()
          : base(typeof (bool), "frostWalking", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerCreature) obj).frostWalking = (bool) value;
        }
      }

      private sealed class PROP_fdbfecf5af9e4e8f9a31a590e02c7f69 : HardwiredMemberDescriptor
      {
        internal PROP_fdbfecf5af9e4e8f9a31a590e02c7f69()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_fdc9b1f5eebc469ea5c9c51e32ca05eb : HardwiredMemberDescriptor
      {
        internal PROP_fdc9b1f5eebc469ea5c9c51e32ca05eb()
          : base(typeof (bool), "diesInWater", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerCreature) obj).diesInWater = (bool) value;
        }
      }

      private sealed class PROP_e189e6ceacc64fcabf6706253a87e130 : HardwiredMemberDescriptor
      {
        internal PROP_e189e6ceacc64fcabf6706253a87e130()
          : base(typeof (CreatureType), "type", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).type;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerCreature) obj).type = (CreatureType) value;
        }
      }

      private sealed class PROP_fad1b15b5d144615ba46601460c382af : HardwiredMemberDescriptor
      {
        internal PROP_fad1b15b5d144615ba46601460c382af()
          : base(typeof (CreatureRace), "race", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).race;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerCreature) obj).race = (CreatureRace) value;
        }
      }

      private sealed class PROP_ffa9d87ce46748749c151f9e8ed20028 : HardwiredMemberDescriptor
      {
        internal PROP_ffa9d87ce46748749c151f9e8ed20028()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_49f8d63470f348999102387a151f9fb8 : HardwiredMemberDescriptor
      {
        internal PROP_49f8d63470f348999102387a151f9fb8()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_bb1f2a3b48b34033b22888dc0f020b50 : HardwiredMemberDescriptor
      {
        internal PROP_bb1f2a3b48b34033b22888dc0f020b50()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_830be3517c524337a4c47f7951ecbb28 : HardwiredMemberDescriptor
      {
        internal PROP_830be3517c524337a4c47f7951ecbb28()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_97f449ee62fd49f78ce04b86287f7e9a : HardwiredMemberDescriptor
      {
        internal PROP_97f449ee62fd49f78ce04b86287f7e9a()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_4002ce3a283943f4b1b485b14994d409 : HardwiredMemberDescriptor
      {
        internal PROP_4002ce3a283943f4b1b485b14994d409()
          : base(typeof (bool), "isFlying", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerCreature) obj).isFlying = (bool) value;
        }
      }

      private sealed class PROP_aae4b61799b644c5b244d5c056568560 : HardwiredMemberDescriptor
      {
        internal PROP_aae4b61799b644c5b244d5c056568560()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_989fb594d42048638a2a672357fd8af5 : HardwiredMemberDescriptor
      {
        internal PROP_989fb594d42048638a2a672357fd8af5()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_6ddcd77e2f7548938227d20bf9fed610 : HardwiredMemberDescriptor
      {
        internal PROP_6ddcd77e2f7548938227d20bf9fed610()
          : base(typeof (bool), "arcaneMonster", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerCreature) obj).arcaneMonster = (bool) value;
        }
      }

      private sealed class PROP_7eb2e49c9cf145c3b141363a1a3ac22a : HardwiredMemberDescriptor
      {
        internal PROP_7eb2e49c9cf145c3b141363a1a3ac22a()
          : base(typeof (bool), "takeDamage", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerCreature) obj).takeDamage = (bool) value;
        }
      }
    }

    private sealed class TYPE_31d2bbd7df8547eab1f9633b198bbac3 : HardwiredUserDataDescriptor
    {
      internal TYPE_31d2bbd7df8547eab1f9633b198bbac3()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.MTHD_1ac36b6c07c8448f9705967cdfbc88af()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.MTHD_b0a8150ef6694e79b5c7a3653d25a183()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.MTHD_63fc7ce3fb234eaba20218bad41ff43b()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.MTHD_3117f4bfde454c1fac6460d0bb873e75()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.MTHD_26e7e97e2ddf491cb63c8cd53c48abf3()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.MTHD_cb4589818f0b4bd9b0b1b60aeffdc59b()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.MTHD_9ae8ed4d57464682b159494c73b92649()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.MTHD_fe4556abcd9c4471af027d496b75ecda()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.MTHD_4f248b0b47184199a79e86f1b177b157()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.MTHD_b39b7eb8795241daa47da31dc45070ed()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.MTHD_ba2154049e2e41c3ae80ae08ba37ddc6()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.MTHD_96b1ff9eac3b4ec4a9c417b32337cc2c()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.MTHD_ad00814b2462496e9cdc99f0649e6d49()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.MTHD_323c6d1f42474e4bbb47245408b96cfb()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.MTHD_bea4bf863eec4a1fad92eddecdb95a67()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.MTHD_b2ebfdeafc424e4a8c54d588b95fed09()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.MTHD_f2cb7ed812174ab89a6b838599258e0f()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.MTHD_43b62194a25f496ebbd69a826e15f3f9()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.MTHD_84f4d814201a4ba9b541035fac068d3f()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.MTHD_14e88d78af56425dafebe38c15766cd6()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.PROP_86467fe59b8c44978fd876e0bb81ba77());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.PROP_3b7925a96b6a40acab2e8d1e8f2a2a79());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.PROP_362431cfadcb424582b73410e933e9a9());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.PROP_de55113f15934bfb862692fdd09e2731());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.PROP_5eb3c34a103c4e7f909700b7c9422ae4());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.PROP_37255010ac354bac927e27db9b14c260());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.PROP_c9b1e7728a0045beba776c08647be735());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_31d2bbd7df8547eab1f9633b198bbac3.PROP_e0a55fde83ac4d7088e88c6e9876dcde());
      }

      private sealed class MTHD_1ac36b6c07c8448f9705967cdfbc88af : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ac36b6c07c8448f9705967cdfbc88af()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_b0a8150ef6694e79b5c7a3653d25a183 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b0a8150ef6694e79b5c7a3653d25a183()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_63fc7ce3fb234eaba20218bad41ff43b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_63fc7ce3fb234eaba20218bad41ff43b()
        {
          this.Initialize("set_x", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).x = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_3117f4bfde454c1fac6460d0bb873e75 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3117f4bfde454c1fac6460d0bb873e75()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_26e7e97e2ddf491cb63c8cd53c48abf3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_26e7e97e2ddf491cb63c8cd53c48abf3()
        {
          this.Initialize("set_y", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).y = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_cb4589818f0b4bd9b0b1b60aeffdc59b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cb4589818f0b4bd9b0b1b60aeffdc59b()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_9ae8ed4d57464682b159494c73b92649 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ae8ed4d57464682b159494c73b92649()
        {
          this.Initialize("set_position", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (Educative.Point), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).position = (Educative.Point) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_fe4556abcd9c4471af027d496b75ecda : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fe4556abcd9c4471af027d496b75ecda()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_4f248b0b47184199a79e86f1b177b157 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4f248b0b47184199a79e86f1b177b157()
        {
          this.Initialize("set_turnsAlive", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnsAlive = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_b39b7eb8795241daa47da31dc45070ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b39b7eb8795241daa47da31dc45070ed()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_ba2154049e2e41c3ae80ae08ba37ddc6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba2154049e2e41c3ae80ae08ba37ddc6()
        {
          this.Initialize("set_maxTurnsAlive", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).maxTurnsAlive = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_96b1ff9eac3b4ec4a9c417b32337cc2c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_96b1ff9eac3b4ec4a9c417b32337cc2c()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_ad00814b2462496e9cdc99f0649e6d49 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ad00814b2462496e9cdc99f0649e6d49()
        {
          this.Initialize("set_active", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).active = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_323c6d1f42474e4bbb47245408b96cfb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_323c6d1f42474e4bbb47245408b96cfb()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_bea4bf863eec4a1fad92eddecdb95a67 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bea4bf863eec4a1fad92eddecdb95a67()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b2ebfdeafc424e4a8c54d588b95fed09 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b2ebfdeafc424e4a8c54d588b95fed09()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f2cb7ed812174ab89a6b838599258e0f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f2cb7ed812174ab89a6b838599258e0f()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_43b62194a25f496ebbd69a826e15f3f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_43b62194a25f496ebbd69a826e15f3f9()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.Equals(pars[0]);
        }
      }

      private sealed class MTHD_84f4d814201a4ba9b541035fac068d3f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84f4d814201a4ba9b541035fac068d3f()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_14e88d78af56425dafebe38c15766cd6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_14e88d78af56425dafebe38c15766cd6()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_86467fe59b8c44978fd876e0bb81ba77 : HardwiredMemberDescriptor
      {
        internal PROP_86467fe59b8c44978fd876e0bb81ba77()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_3b7925a96b6a40acab2e8d1e8f2a2a79 : HardwiredMemberDescriptor
      {
        internal PROP_3b7925a96b6a40acab2e8d1e8f2a2a79()
          : base(typeof (int), "x", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).x;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerEffector) obj).x = (int) value;
        }
      }

      private sealed class PROP_362431cfadcb424582b73410e933e9a9 : HardwiredMemberDescriptor
      {
        internal PROP_362431cfadcb424582b73410e933e9a9()
          : base(typeof (int), "y", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).y;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerEffector) obj).y = (int) value;
        }
      }

      private sealed class PROP_de55113f15934bfb862692fdd09e2731 : HardwiredMemberDescriptor
      {
        internal PROP_de55113f15934bfb862692fdd09e2731()
          : base(typeof (Educative.Point), "position", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).position;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerEffector) obj).position = (Educative.Point) value;
        }
      }

      private sealed class PROP_5eb3c34a103c4e7f909700b7c9422ae4 : HardwiredMemberDescriptor
      {
        internal PROP_5eb3c34a103c4e7f909700b7c9422ae4()
          : base(typeof (int), "turnsAlive", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerEffector) obj).turnsAlive = (int) value;
        }
      }

      private sealed class PROP_37255010ac354bac927e27db9b14c260 : HardwiredMemberDescriptor
      {
        internal PROP_37255010ac354bac927e27db9b14c260()
          : base(typeof (int), "maxTurnsAlive", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerEffector) obj).maxTurnsAlive = (int) value;
        }
      }

      private sealed class PROP_c9b1e7728a0045beba776c08647be735 : HardwiredMemberDescriptor
      {
        internal PROP_c9b1e7728a0045beba776c08647be735()
          : base(typeof (bool), "active", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).active;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerEffector) obj).active = (bool) value;
        }
      }

      private sealed class PROP_e0a55fde83ac4d7088e88c6e9876dcde : HardwiredMemberDescriptor
      {
        internal PROP_e0a55fde83ac4d7088e88c6e9876dcde()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_0622caa3fbe5444aac8e449aa78f8ef8 : HardwiredUserDataDescriptor
    {
      internal TYPE_0622caa3fbe5444aac8e449aa78f8ef8()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.MTHD_e9cc6670eae94082850772b85de2e044()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.MTHD_c5e6c2b64b914ae88eb35c0e0ea1f230()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.MTHD_04a429e639d343f596be0b45fb30eecf()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.MTHD_2840e9e31edb4b92a705f8364118a3ef()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.MTHD_7a69681060fd4405ac59aa13a675770c()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.MTHD_fa92c7cd919042f59eaaef6dd050b279()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.MTHD_7fe6bdd5dffe43cab950f5c41a3880f2()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.MTHD_8093614228d5417295d58944b3a3647a()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.MTHD_e5b2d5e4e25a471ea4254d27fbe32f27()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.MTHD_46f30d3b8bd64b3d927eeb77844c4084()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.MTHD_17c5a05955dd420b89e5ae7689e0ad92()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.MTHD_0489c92a1add4c9eae1c06b693cefe5a()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.MTHD_f6a3a042d445463c8b35dfe60e72f1c9()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.MTHD_3309f541336d4437b9f28565478b1d04()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.MTHD_a22f629294844ace80906b37895eff59()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.MTHD_e1f55176c1f54b09b0a7c65933bae47d()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.MTHD_138fbe0825284db89506299ff4c7f712()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.MTHD_75d57ffae0a14c25b9c83dfcece035cc()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.MTHD_344a623526654bd7b8e99b72b31a5f34()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.PROP_f62e2896f48543608bec96ebe1800816());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.PROP_83d23c28fe3b462db8d7f89cbda84dfc());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.PROP_a7f4dc89b07842d58533b5a8f4822b88());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.PROP_988f2f01758a4df9896377609d6acec7());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.PROP_9edf700de895414c8fbecc28d0e75d17());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.PROP_d538479d7f804c9abd5d563f89c2415e());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.PROP_9809b3af507845e1a4b35b5cc3a62e84());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_0622caa3fbe5444aac8e449aa78f8ef8.PROP_aa6895c644a44e478c3e9d701647b496());
      }

      private sealed class MTHD_e9cc6670eae94082850772b85de2e044 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e9cc6670eae94082850772b85de2e044()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_c5e6c2b64b914ae88eb35c0e0ea1f230 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c5e6c2b64b914ae88eb35c0e0ea1f230()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_04a429e639d343f596be0b45fb30eecf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_04a429e639d343f596be0b45fb30eecf()
        {
          this.Initialize("set_x", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).x = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_2840e9e31edb4b92a705f8364118a3ef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2840e9e31edb4b92a705f8364118a3ef()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_7a69681060fd4405ac59aa13a675770c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a69681060fd4405ac59aa13a675770c()
        {
          this.Initialize("set_y", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).y = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_fa92c7cd919042f59eaaef6dd050b279 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa92c7cd919042f59eaaef6dd050b279()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_7fe6bdd5dffe43cab950f5c41a3880f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7fe6bdd5dffe43cab950f5c41a3880f2()
        {
          this.Initialize("set_radius", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).radius = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_8093614228d5417295d58944b3a3647a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8093614228d5417295d58944b3a3647a()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_e5b2d5e4e25a471ea4254d27fbe32f27 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e5b2d5e4e25a471ea4254d27fbe32f27()
        {
          this.Initialize("set_position", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (Educative.Point), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).position = (Educative.Point) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_46f30d3b8bd64b3d927eeb77844c4084 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_46f30d3b8bd64b3d927eeb77844c4084()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_17c5a05955dd420b89e5ae7689e0ad92 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_17c5a05955dd420b89e5ae7689e0ad92()
        {
          this.Initialize("set_angle", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).angle = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_0489c92a1add4c9eae1c06b693cefe5a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0489c92a1add4c9eae1c06b693cefe5a()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_f6a3a042d445463c8b35dfe60e72f1c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f6a3a042d445463c8b35dfe60e72f1c9()
        {
          this.Initialize("set_color", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (string), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).color = (string) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_3309f541336d4437b9f28565478b1d04 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3309f541336d4437b9f28565478b1d04()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_a22f629294844ace80906b37895eff59 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a22f629294844ace80906b37895eff59()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_e1f55176c1f54b09b0a7c65933bae47d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e1f55176c1f54b09b0a7c65933bae47d()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.Equals(pars[0]);
        }
      }

      private sealed class MTHD_138fbe0825284db89506299ff4c7f712 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_138fbe0825284db89506299ff4c7f712()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_75d57ffae0a14c25b9c83dfcece035cc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75d57ffae0a14c25b9c83dfcece035cc()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_344a623526654bd7b8e99b72b31a5f34 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_344a623526654bd7b8e99b72b31a5f34()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_f62e2896f48543608bec96ebe1800816 : HardwiredMemberDescriptor
      {
        internal PROP_f62e2896f48543608bec96ebe1800816()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_83d23c28fe3b462db8d7f89cbda84dfc : HardwiredMemberDescriptor
      {
        internal PROP_83d23c28fe3b462db8d7f89cbda84dfc()
          : base(typeof (int), "x", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).x;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerIndicator) obj).x = (int) value;
        }
      }

      private sealed class PROP_a7f4dc89b07842d58533b5a8f4822b88 : HardwiredMemberDescriptor
      {
        internal PROP_a7f4dc89b07842d58533b5a8f4822b88()
          : base(typeof (int), "y", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).y;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerIndicator) obj).y = (int) value;
        }
      }

      private sealed class PROP_988f2f01758a4df9896377609d6acec7 : HardwiredMemberDescriptor
      {
        internal PROP_988f2f01758a4df9896377609d6acec7()
          : base(typeof (double), "radius", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerIndicator) obj).radius = (double) value;
        }
      }

      private sealed class PROP_9edf700de895414c8fbecc28d0e75d17 : HardwiredMemberDescriptor
      {
        internal PROP_9edf700de895414c8fbecc28d0e75d17()
          : base(typeof (Educative.Point), "position", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).position;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerIndicator) obj).position = (Educative.Point) value;
        }
      }

      private sealed class PROP_d538479d7f804c9abd5d563f89c2415e : HardwiredMemberDescriptor
      {
        internal PROP_d538479d7f804c9abd5d563f89c2415e()
          : base(typeof (double), "angle", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerIndicator) obj).angle = (double) value;
        }
      }

      private sealed class PROP_9809b3af507845e1a4b35b5cc3a62e84 : HardwiredMemberDescriptor
      {
        internal PROP_9809b3af507845e1a4b35b5cc3a62e84()
          : base(typeof (string), "color", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).color;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerIndicator) obj).color = (string) value;
        }
      }

      private sealed class PROP_aa6895c644a44e478c3e9d701647b496 : HardwiredMemberDescriptor
      {
        internal PROP_aa6895c644a44e478c3e9d701647b496()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_f6171ebd6ff94219a117e84b3f1d68da : HardwiredUserDataDescriptor
    {
      internal TYPE_f6171ebd6ff94219a117e84b3f1d68da()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_853fce585ed2474481e8c69829847b6c()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_e532bad3549345efab32c648e7d7c065()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_41995c34919b47feaeb2085b1153b6ce()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_29d4892e1c5f4cc3bcd968c8389fc582()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_99580f822c694b478f1729bf4b7a75a4()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_ed89c4bd31f14fca89093c656258aa85()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_add1dddebec846ddb211f331dbd0eb17()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_c27acdf36b3d46cdb2ba269b177539d2()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_11efff29955a47f8a3da990e9038717c()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_c4b6dd76fa504c5a9ed2b5a9c90a2f93()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_3bd62869b9c0403abb9b9b0b1660a1a1()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_3603e50b43dd46f78bceaa46546d1a79()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_a11bd4cc97b14a88ad45559add5c08bd()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_fbc06845fc7f40e4ae027a9962b7212d()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_ada5e4f19a924530a5f1cadfe421147f()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_5f8e83067e444f7184ec7a6402271ec5()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_68fcb32e0af84d0f9743991744ab3c76()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_5ef4ce52abf347389fe435e21262f5f9()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_8d4a72df96954501938ea5577c7c9765()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_accc36ef924045b0b622b468d8c43afe()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_21c9f44aaff643ab99a33efd0d3959e7()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_7bebca4b55ce40cb92d7e9ce16c44c34()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_bb244c5eafa9427189b7c1a33308636f()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_a322033008c44e0ab677d592bdcfcbcb()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_b52ef8eed29f4b00be3aaea766f217cc()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_04ce360895c249448f2d0f971527b2e2()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_546a996d599945ebb6a4175299ea1c3d()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.MTHD_485b34be69cd4f4bb59a1792385da14f()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.PROP_0ff57cbae2054855bfa34ea14d819952());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.PROP_240c63de01384d4fadd6e552bcbb657a());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.PROP_5ba1265babb24fc6aeb2da661fc9868f());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.PROP_74272e877db64a508b3175ee86e99167());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.PROP_34a8f768a27c403395b78fd6ad56821d());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.PROP_1967d67276c6484e93e32660b57cd3d9());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.PROP_efc73fb85af646a080ca067dd25355f0());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.PROP_6cb62adef4ce478598b8f7d2bb3b2d36());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.PROP_19f8d0111fc84eeba0561c0ff3ef8c6d());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.PROP_0da99d0e8ee54b46a86166004127dd7a());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.PROP_543c979314084231bc5288ea1078d340());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.PROP_6c4236727a914b92a6400136b2626fda());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.PROP_1deec3db12ad4f639309ea1b6e4caf20());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.PROP_b82be39857b040169aee36f973d97da1());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.PROP_82acbef55fe84e70b7cb8d35956e242e());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.PROP_080d572684044212b3693824c4710915());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_f6171ebd6ff94219a117e84b3f1d68da.PROP_bcae1c4fba3442dc90cce793b47d59fe());
      }

      private sealed class MTHD_853fce585ed2474481e8c69829847b6c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_853fce585ed2474481e8c69829847b6c()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_e532bad3549345efab32c648e7d7c065 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e532bad3549345efab32c648e7d7c065()
        {
          this.Initialize("set_uses", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerSpell) obj).uses = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_41995c34919b47feaeb2085b1153b6ce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41995c34919b47feaeb2085b1153b6ce()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_29d4892e1c5f4cc3bcd968c8389fc582 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_29d4892e1c5f4cc3bcd968c8389fc582()
        {
          this.Initialize("set_maxUses", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerSpell) obj).maxUses = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_99580f822c694b478f1729bf4b7a75a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99580f822c694b478f1729bf4b7a75a4()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_ed89c4bd31f14fca89093c656258aa85 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed89c4bd31f14fca89093c656258aa85()
        {
          this.Initialize("set_rechargeTime", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerSpell) obj).rechargeTime = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_add1dddebec846ddb211f331dbd0eb17 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_add1dddebec846ddb211f331dbd0eb17()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_c27acdf36b3d46cdb2ba269b177539d2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c27acdf36b3d46cdb2ba269b177539d2()
        {
          this.Initialize("set_lastTurnFired", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerSpell) obj).lastTurnFired = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_11efff29955a47f8a3da990e9038717c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_11efff29955a47f8a3da990e9038717c()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_c4b6dd76fa504c5a9ed2b5a9c90a2f93 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c4b6dd76fa504c5a9ed2b5a9c90a2f93()
        {
          this.Initialize("set_isPresent", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerSpell) obj).isPresent = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_3bd62869b9c0403abb9b9b0b1660a1a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3bd62869b9c0403abb9b9b0b1660a1a1()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_3603e50b43dd46f78bceaa46546d1a79 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3603e50b43dd46f78bceaa46546d1a79()
        {
          this.Initialize("set_locked", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerSpell) obj).locked = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_a11bd4cc97b14a88ad45559add5c08bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a11bd4cc97b14a88ad45559add5c08bd()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_fbc06845fc7f40e4ae027a9962b7212d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fbc06845fc7f40e4ae027a9962b7212d()
        {
          this.Initialize("set_turnsTillFirstUse", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerSpell) obj).turnsTillFirstUse = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_ada5e4f19a924530a5f1cadfe421147f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ada5e4f19a924530a5f1cadfe421147f()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_5f8e83067e444f7184ec7a6402271ec5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5f8e83067e444f7184ec7a6402271ec5()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_68fcb32e0af84d0f9743991744ab3c76 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_68fcb32e0af84d0f9743991744ab3c76()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_5ef4ce52abf347389fe435e21262f5f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ef4ce52abf347389fe435e21262f5f9()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_8d4a72df96954501938ea5577c7c9765 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8d4a72df96954501938ea5577c7c9765()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_accc36ef924045b0b622b468d8c43afe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_accc36ef924045b0b622b468d8c43afe()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_21c9f44aaff643ab99a33efd0d3959e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_21c9f44aaff643ab99a33efd0d3959e7()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_7bebca4b55ce40cb92d7e9ce16c44c34 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7bebca4b55ce40cb92d7e9ce16c44c34()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_bb244c5eafa9427189b7c1a33308636f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb244c5eafa9427189b7c1a33308636f()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_a322033008c44e0ab677d592bdcfcbcb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a322033008c44e0ab677d592bdcfcbcb()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_b52ef8eed29f4b00be3aaea766f217cc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b52ef8eed29f4b00be3aaea766f217cc()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.Equals(pars[0]);
        }
      }

      private sealed class MTHD_04ce360895c249448f2d0f971527b2e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_04ce360895c249448f2d0f971527b2e2()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_546a996d599945ebb6a4175299ea1c3d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_546a996d599945ebb6a4175299ea1c3d()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_485b34be69cd4f4bb59a1792385da14f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_485b34be69cd4f4bb59a1792385da14f()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_0ff57cbae2054855bfa34ea14d819952 : HardwiredMemberDescriptor
      {
        internal PROP_0ff57cbae2054855bfa34ea14d819952()
          : base(typeof (int), "uses", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).uses;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerSpell) obj).uses = (int) value;
        }
      }

      private sealed class PROP_240c63de01384d4fadd6e552bcbb657a : HardwiredMemberDescriptor
      {
        internal PROP_240c63de01384d4fadd6e552bcbb657a()
          : base(typeof (int), "maxUses", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerSpell) obj).maxUses = (int) value;
        }
      }

      private sealed class PROP_5ba1265babb24fc6aeb2da661fc9868f : HardwiredMemberDescriptor
      {
        internal PROP_5ba1265babb24fc6aeb2da661fc9868f()
          : base(typeof (int), "rechargeTime", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerSpell) obj).rechargeTime = (int) value;
        }
      }

      private sealed class PROP_74272e877db64a508b3175ee86e99167 : HardwiredMemberDescriptor
      {
        internal PROP_74272e877db64a508b3175ee86e99167()
          : base(typeof (int), "lastTurnFired", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerSpell) obj).lastTurnFired = (int) value;
        }
      }

      private sealed class PROP_34a8f768a27c403395b78fd6ad56821d : HardwiredMemberDescriptor
      {
        internal PROP_34a8f768a27c403395b78fd6ad56821d()
          : base(typeof (bool), "isPresent", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerSpell) obj).isPresent = (bool) value;
        }
      }

      private sealed class PROP_1967d67276c6484e93e32660b57cd3d9 : HardwiredMemberDescriptor
      {
        internal PROP_1967d67276c6484e93e32660b57cd3d9()
          : base(typeof (bool), "locked", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).locked;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerSpell) obj).locked = (bool) value;
        }
      }

      private sealed class PROP_efc73fb85af646a080ca067dd25355f0 : HardwiredMemberDescriptor
      {
        internal PROP_efc73fb85af646a080ca067dd25355f0()
          : base(typeof (int), "turnsTillFirstUse", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerSpell) obj).turnsTillFirstUse = (int) value;
        }
      }

      private sealed class PROP_6cb62adef4ce478598b8f7d2bb3b2d36 : HardwiredMemberDescriptor
      {
        internal PROP_6cb62adef4ce478598b8f7d2bb3b2d36()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_19f8d0111fc84eeba0561c0ff3ef8c6d : HardwiredMemberDescriptor
      {
        internal PROP_19f8d0111fc84eeba0561c0ff3ef8c6d()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_0da99d0e8ee54b46a86166004127dd7a : HardwiredMemberDescriptor
      {
        internal PROP_0da99d0e8ee54b46a86166004127dd7a()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_543c979314084231bc5288ea1078d340 : HardwiredMemberDescriptor
      {
        internal PROP_543c979314084231bc5288ea1078d340()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_6c4236727a914b92a6400136b2626fda : HardwiredMemberDescriptor
      {
        internal PROP_6c4236727a914b92a6400136b2626fda()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_1deec3db12ad4f639309ea1b6e4caf20 : HardwiredMemberDescriptor
      {
        internal PROP_1deec3db12ad4f639309ea1b6e4caf20()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_b82be39857b040169aee36f973d97da1 : HardwiredMemberDescriptor
      {
        internal PROP_b82be39857b040169aee36f973d97da1()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_82acbef55fe84e70b7cb8d35956e242e : HardwiredMemberDescriptor
      {
        internal PROP_82acbef55fe84e70b7cb8d35956e242e()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_080d572684044212b3693824c4710915 : HardwiredMemberDescriptor
      {
        internal PROP_080d572684044212b3693824c4710915()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_bcae1c4fba3442dc90cce793b47d59fe : HardwiredMemberDescriptor
      {
        internal PROP_bcae1c4fba3442dc90cce793b47d59fe()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_008a05134d27427dad48579ae0c4cabc : HardwiredUserDataDescriptor
    {
      internal TYPE_008a05134d27427dad48579ae0c4cabc()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_008a05134d27427dad48579ae0c4cabc.MTHD_71d5d6a94aa64f978a08ecf7f9008db3()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_008a05134d27427dad48579ae0c4cabc.MTHD_dd5ca268c8a94dadbc6d236ecf4f1adb()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_008a05134d27427dad48579ae0c4cabc.MTHD_77024c765d744f02844871516820edf5()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_008a05134d27427dad48579ae0c4cabc.MTHD_d1c3efedc79045f1af30abb86a2bd688()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_008a05134d27427dad48579ae0c4cabc.MTHD_9b17b3fc7c2c4748b400c0691b5bac99()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_008a05134d27427dad48579ae0c4cabc.MTHD_4deec377e1dd4367b37dddf7252c138b()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_008a05134d27427dad48579ae0c4cabc.MTHD_d594deae26cc4d2cb3b181e267000a1f()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_008a05134d27427dad48579ae0c4cabc.MTHD_26f3935358254f75884d4a252c917e83()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_008a05134d27427dad48579ae0c4cabc.MTHD_e19fe6e45f8b48cca32ab5ed0016619d()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_008a05134d27427dad48579ae0c4cabc.MTHD_abf49f91f29445b9975c6f32a4a841a9()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_008a05134d27427dad48579ae0c4cabc.MTHD_4c4c9bf95e4a4f63a7422d4bc573dc95()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_008a05134d27427dad48579ae0c4cabc.MTHD_c5b96b7b9687414a9fae64bc59551cb4()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_008a05134d27427dad48579ae0c4cabc.MTHD_26e2590cf64b4fdab715472ef2f48630()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_008a05134d27427dad48579ae0c4cabc.MTHD_b21d7426bf9249d586de2d678fe6f1e2()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_008a05134d27427dad48579ae0c4cabc.MTHD_ed7c9a0368c64ba295cd4645d4a68ce2()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_008a05134d27427dad48579ae0c4cabc.MTHD_13fb6c1e314a428a81783aeb3c226866()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_008a05134d27427dad48579ae0c4cabc.MTHD_d153258b0b64489998ddc296799e9228()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_008a05134d27427dad48579ae0c4cabc.PROP_d875a7e4fdb54279a5cc2bad2c6986f8());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_008a05134d27427dad48579ae0c4cabc.PROP_21c76f86d4c44fdbbaaaa629933b8fe7());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_008a05134d27427dad48579ae0c4cabc.PROP_03c775b01928406f84b60f5489934c7e());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_008a05134d27427dad48579ae0c4cabc.PROP_3d4e51dedb55449b8c877cd4a6ef20e4());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_008a05134d27427dad48579ae0c4cabc.PROP_4dfc32c22cd54b63b07136ad5bc3c80e());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_008a05134d27427dad48579ae0c4cabc.PROP_040ea596e18b4fcdaf8fdf6f29a1ed2c());
      }

      private sealed class MTHD_71d5d6a94aa64f978a08ecf7f9008db3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_71d5d6a94aa64f978a08ecf7f9008db3()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_dd5ca268c8a94dadbc6d236ecf4f1adb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dd5ca268c8a94dadbc6d236ecf4f1adb()
        {
          this.Initialize("set_health", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).health = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_77024c765d744f02844871516820edf5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_77024c765d744f02844871516820edf5()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_d1c3efedc79045f1af30abb86a2bd688 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1c3efedc79045f1af30abb86a2bd688()
        {
          this.Initialize("set_maxHealth", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).maxHealth = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_9b17b3fc7c2c4748b400c0691b5bac99 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b17b3fc7c2c4748b400c0691b5bac99()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_4deec377e1dd4367b37dddf7252c138b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4deec377e1dd4367b37dddf7252c138b()
        {
          this.Initialize("set_x", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).x = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_d594deae26cc4d2cb3b181e267000a1f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d594deae26cc4d2cb3b181e267000a1f()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_26f3935358254f75884d4a252c917e83 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_26f3935358254f75884d4a252c917e83()
        {
          this.Initialize("set_y", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).y = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_e19fe6e45f8b48cca32ab5ed0016619d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e19fe6e45f8b48cca32ab5ed0016619d()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_abf49f91f29445b9975c6f32a4a841a9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_abf49f91f29445b9975c6f32a4a841a9()
        {
          this.Initialize("set_position", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (Educative.Point), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).position = (Educative.Point) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_4c4c9bf95e4a4f63a7422d4bc573dc95 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c4c9bf95e4a4f63a7422d4bc573dc95()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_c5b96b7b9687414a9fae64bc59551cb4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c5b96b7b9687414a9fae64bc59551cb4()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_26e2590cf64b4fdab715472ef2f48630 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_26e2590cf64b4fdab715472ef2f48630()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b21d7426bf9249d586de2d678fe6f1e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b21d7426bf9249d586de2d678fe6f1e2()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_ed7c9a0368c64ba295cd4645d4a68ce2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed7c9a0368c64ba295cd4645d4a68ce2()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.Equals(pars[0]);
        }
      }

      private sealed class MTHD_13fb6c1e314a428a81783aeb3c226866 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_13fb6c1e314a428a81783aeb3c226866()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_d153258b0b64489998ddc296799e9228 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d153258b0b64489998ddc296799e9228()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_d875a7e4fdb54279a5cc2bad2c6986f8 : HardwiredMemberDescriptor
      {
        internal PROP_d875a7e4fdb54279a5cc2bad2c6986f8()
          : base(typeof (int), "health", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).health;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerTower) obj).health = (int) value;
        }
      }

      private sealed class PROP_21c76f86d4c44fdbbaaaa629933b8fe7 : HardwiredMemberDescriptor
      {
        internal PROP_21c76f86d4c44fdbbaaaa629933b8fe7()
          : base(typeof (int), "maxHealth", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerTower) obj).maxHealth = (int) value;
        }
      }

      private sealed class PROP_03c775b01928406f84b60f5489934c7e : HardwiredMemberDescriptor
      {
        internal PROP_03c775b01928406f84b60f5489934c7e()
          : base(typeof (int), "x", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).x;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerTower) obj).x = (int) value;
        }
      }

      private sealed class PROP_3d4e51dedb55449b8c877cd4a6ef20e4 : HardwiredMemberDescriptor
      {
        internal PROP_3d4e51dedb55449b8c877cd4a6ef20e4()
          : base(typeof (int), "y", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).y;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerTower) obj).y = (int) value;
        }
      }

      private sealed class PROP_4dfc32c22cd54b63b07136ad5bc3c80e : HardwiredMemberDescriptor
      {
        internal PROP_4dfc32c22cd54b63b07136ad5bc3c80e()
          : base(typeof (Educative.Point), "position", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).position;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerTower) obj).position = (Educative.Point) value;
        }
      }

      private sealed class PROP_040ea596e18b4fcdaf8fdf6f29a1ed2c : HardwiredMemberDescriptor
      {
        internal PROP_040ea596e18b4fcdaf8fdf6f29a1ed2c()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_4ea197ed244d4a8a9a7641764d1b1193 : HardwiredUserDataDescriptor
    {
      internal TYPE_4ea197ed244d4a8a9a7641764d1b1193()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4ea197ed244d4a8a9a7641764d1b1193.MTHD_696d1c52fbc241f0af16a61f9e81cb0b(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4ea197ed244d4a8a9a7641764d1b1193.MTHD_2478e1848833496dae75788ba4ce4683()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4ea197ed244d4a8a9a7641764d1b1193.MTHD_d9421541a2714d7a8fee9bb7c83aad4f(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4ea197ed244d4a8a9a7641764d1b1193.MTHD_81acc54c630e4594b20bd26f89710112()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4ea197ed244d4a8a9a7641764d1b1193.MTHD_c5e7288a04b24a9c8cb79b3706ebb581()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4ea197ed244d4a8a9a7641764d1b1193.MTHD_59c8208e9f4b4e99b01da4690f074c5c()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4ea197ed244d4a8a9a7641764d1b1193.MTHD_44c05702666842dc9172b8ef813ea53f()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4ea197ed244d4a8a9a7641764d1b1193.MTHD_80aaa768b77d445b8eeecab160172cfd()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4ea197ed244d4a8a9a7641764d1b1193.MTHD_aee5aff0b5bc4e70a408f2912e657c38()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4ea197ed244d4a8a9a7641764d1b1193.MTHD_a81e9ff7e04e4c959906a655a3956647()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4ea197ed244d4a8a9a7641764d1b1193.MTHD_a2c0ad9ab2584cb0949c11fcc0434caf()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4ea197ed244d4a8a9a7641764d1b1193.MTHD_6d2cbfedc7a94b38829ca9d89782e384(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4ea197ed244d4a8a9a7641764d1b1193.MTHD_eeb7978b08a94228a689f0f95f09169a()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4ea197ed244d4a8a9a7641764d1b1193.MTHD_8c8bfce60e4b45278329feae29db2e3d(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4ea197ed244d4a8a9a7641764d1b1193.MTHD_6264abe1cc744143abc92d033be20f33()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4ea197ed244d4a8a9a7641764d1b1193.MTHD_d9ac515744b648bf95a6a1573e0af6df(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4ea197ed244d4a8a9a7641764d1b1193.MTHD_f20ac5f0e44d4f2b829f8e8e847bb28f()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4ea197ed244d4a8a9a7641764d1b1193.MTHD_d0198cd6ce0a467b8f7fb15f9f86ab7c(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4ea197ed244d4a8a9a7641764d1b1193.MTHD_bb6b65b9cdb54a3e9711c4f2a800a8b6()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4ea197ed244d4a8a9a7641764d1b1193.MTHD_c8e96b2a609242daa4dc6aa50b0d8fe0(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4ea197ed244d4a8a9a7641764d1b1193.MTHD_e84df25941ef48f7a35b08ff0b05e2ec()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4ea197ed244d4a8a9a7641764d1b1193.MTHD_21c99221eb824fff92531b3cfd217f87()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4ea197ed244d4a8a9a7641764d1b1193.MTHD_f78cad9ac4304a25ab186641f7f749c3()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_4ea197ed244d4a8a9a7641764d1b1193.FLDV_11f49c0f212f4aa1aa854fa22206f809());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_4ea197ed244d4a8a9a7641764d1b1193.FLDV_cc23e39fb91b4ff99de83fcc0b3d8676());
      }

      private sealed class MTHD_696d1c52fbc241f0af16a61f9e81cb0b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_696d1c52fbc241f0af16a61f9e81cb0b()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("x", typeof (double), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("y", typeof (double), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 0)
            return (object) new Educative.Point(0.0, 0.0);
          return argscount <= 1 ? (object) new Educative.Point((double) pars[0], 0.0) : (object) new Educative.Point((double) pars[0], (double) pars[1]);
        }
      }

      private sealed class MTHD_2478e1848833496dae75788ba4ce4683 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2478e1848833496dae75788ba4ce4683()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("v", typeof (Vector2), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Educative.Point((Vector2) pars[0]);
        }
      }

      private sealed class MTHD_d9421541a2714d7a8fee9bb7c83aad4f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d9421541a2714d7a8fee9bb7c83aad4f()
        {
          this.Initialize("distance", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("a", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("b", typeof (Educative.Point), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) Educative.Point.distance((Educative.Point) pars[0], (Educative.Point) pars[1]);
        }
      }

      private sealed class MTHD_81acc54c630e4594b20bd26f89710112 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_81acc54c630e4594b20bd26f89710112()
        {
          this.Initialize("distance", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("b", typeof (Educative.Point), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).distance((Educative.Point) pars[0]);
        }
      }

      private sealed class MTHD_c5e7288a04b24a9c8cb79b3706ebb581 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c5e7288a04b24a9c8cb79b3706ebb581()
        {
          this.Initialize("construct", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("x", typeof (int), false, (object) null, false, false, false),
            new ParameterDescriptor("y", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) Educative.Point.construct((int) pars[0], (int) pars[1]);
        }
      }

      private sealed class MTHD_59c8208e9f4b4e99b01da4690f074c5c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_59c8208e9f4b4e99b01da4690f074c5c()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_44c05702666842dc9172b8ef813ea53f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_44c05702666842dc9172b8ef813ea53f()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_80aaa768b77d445b8eeecab160172cfd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_80aaa768b77d445b8eeecab160172cfd()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_aee5aff0b5bc4e70a408f2912e657c38 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aee5aff0b5bc4e70a408f2912e657c38()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).Equals(pars[0]);
        }
      }

      private sealed class MTHD_a81e9ff7e04e4c959906a655a3956647 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a81e9ff7e04e4c959906a655a3956647()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_a2c0ad9ab2584cb0949c11fcc0434caf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2c0ad9ab2584cb0949c11fcc0434caf()
        {
          this.Initialize("op_Equality", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("v", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("x", typeof (Educative.Point), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) pars[0] == (Educative.Point) pars[1]);
        }
      }

      private sealed class MTHD_6d2cbfedc7a94b38829ca9d89782e384 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d2cbfedc7a94b38829ca9d89782e384()
        {
          this.Initialize("op_Subtraction", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("x", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("v", typeof (double), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) pars[0] - (double) pars[1]);
        }
      }

      private sealed class MTHD_eeb7978b08a94228a689f0f95f09169a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eeb7978b08a94228a689f0f95f09169a()
        {
          this.Initialize("op_Subtraction", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("x", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("v", typeof (Educative.Point), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) pars[0] - (Educative.Point) pars[1]);
        }
      }

      private sealed class MTHD_8c8bfce60e4b45278329feae29db2e3d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c8bfce60e4b45278329feae29db2e3d()
        {
          this.Initialize("op_Addition", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("x", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("v", typeof (double), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) pars[0] + (double) pars[1]);
        }
      }

      private sealed class MTHD_6264abe1cc744143abc92d033be20f33 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6264abe1cc744143abc92d033be20f33()
        {
          this.Initialize("op_Addition", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("x", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("v", typeof (Educative.Point), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) pars[0] + (Educative.Point) pars[1]);
        }
      }

      private sealed class MTHD_d9ac515744b648bf95a6a1573e0af6df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d9ac515744b648bf95a6a1573e0af6df()
        {
          this.Initialize("op_Multiply", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("x", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("v", typeof (double), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) pars[0] * (double) pars[1]);
        }
      }

      private sealed class MTHD_f20ac5f0e44d4f2b829f8e8e847bb28f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f20ac5f0e44d4f2b829f8e8e847bb28f()
        {
          this.Initialize("op_Multiply", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("x", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("v", typeof (Educative.Point), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) pars[0] * (Educative.Point) pars[1]);
        }
      }

      private sealed class MTHD_d0198cd6ce0a467b8f7fb15f9f86ab7c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0198cd6ce0a467b8f7fb15f9f86ab7c()
        {
          this.Initialize("op_Division", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("x", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("v", typeof (double), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) pars[0] / (double) pars[1]);
        }
      }

      private sealed class MTHD_bb6b65b9cdb54a3e9711c4f2a800a8b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb6b65b9cdb54a3e9711c4f2a800a8b6()
        {
          this.Initialize("op_Division", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("x", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("v", typeof (Educative.Point), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) pars[0] / (Educative.Point) pars[1]);
        }
      }

      private sealed class MTHD_c8e96b2a609242daa4dc6aa50b0d8fe0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c8e96b2a609242daa4dc6aa50b0d8fe0()
        {
          this.Initialize("op_Modulus", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("x", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("v", typeof (double), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) pars[0] % (double) pars[1]);
        }
      }

      private sealed class MTHD_e84df25941ef48f7a35b08ff0b05e2ec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e84df25941ef48f7a35b08ff0b05e2ec()
        {
          this.Initialize("op_Modulus", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("x", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("v", typeof (Educative.Point), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) pars[0] % (Educative.Point) pars[1]);
        }
      }

      private sealed class MTHD_21c99221eb824fff92531b3cfd217f87 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_21c99221eb824fff92531b3cfd217f87()
        {
          this.Initialize("op_Inequality", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("v", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("x", typeof (Educative.Point), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) pars[0] != (Educative.Point) pars[1]);
        }
      }

      private sealed class MTHD_f78cad9ac4304a25ab186641f7f749c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f78cad9ac4304a25ab186641f7f749c3()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_11f49c0f212f4aa1aa854fa22206f809 : HardwiredMemberDescriptor
      {
        internal FLDV_11f49c0f212f4aa1aa854fa22206f809()
          : base(typeof (double), "x", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((Educative.Point) obj).x;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((Educative.Point) obj).x = (double) value;
        }
      }

      private sealed class FLDV_cc23e39fb91b4ff99de83fcc0b3d8676 : HardwiredMemberDescriptor
      {
        internal FLDV_cc23e39fb91b4ff99de83fcc0b3d8676()
          : base(typeof (double), "y", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((Educative.Point) obj).y;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((Educative.Point) obj).y = (double) value;
        }
      }
    }

    private sealed class TYPE_e677c05978bb408588e8df4e6b6afe17 : HardwiredUserDataDescriptor
    {
      internal TYPE_e677c05978bb408588e8df4e6b6afe17()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e677c05978bb408588e8df4e6b6afe17.MTHD_eb4a311acdc943ad9e39610c756a6b7f()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e677c05978bb408588e8df4e6b6afe17.MTHD_01833b54dc8d4949b0598f545e3e64c2()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e677c05978bb408588e8df4e6b6afe17.MTHD_62068e4cbd72487f8f99cc50b5e7ad62()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e677c05978bb408588e8df4e6b6afe17.MTHD_eb95f599031f46f9a42135a732b9555b()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e677c05978bb408588e8df4e6b6afe17.MTHD_94282a0a1c414b128179028877d5f25c()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e677c05978bb408588e8df4e6b6afe17.MTHD_bd01f17df8944f9d9efdb267ec59ea62()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_e677c05978bb408588e8df4e6b6afe17.FLDV_bf2234477ccc489bbd67235741979202());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_e677c05978bb408588e8df4e6b6afe17.FLDV_4a0f08671f4344dd9707338515019af6());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_e677c05978bb408588e8df4e6b6afe17.FLDV_6b5662dc0d3245a88121246685b24ba5());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_e677c05978bb408588e8df4e6b6afe17.FLDV_c3243bd4c99c4841840e415e2c0a589c());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_e677c05978bb408588e8df4e6b6afe17.FLDV_f2c0f5de85914d99993da2d2b3b17594());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_e677c05978bb408588e8df4e6b6afe17.FLDV_2d4a20f81237446f91cd9cdd76d9018e());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_e677c05978bb408588e8df4e6b6afe17.FLDV_c4ccf8606cf049a6a63f81c934ee4c1b());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_e677c05978bb408588e8df4e6b6afe17.FLDV_4f773c78c3ad4604825a5ac796e14740());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_e677c05978bb408588e8df4e6b6afe17.FLDV_1abf81268da34070a288510ce32d7fd2());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_e677c05978bb408588e8df4e6b6afe17.FLDV_3f799f83f51a4f7d8e1b940842d0bf1e());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_e677c05978bb408588e8df4e6b6afe17.FLDV_372295d88f9a46878e2b2bdcb166327e());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_e677c05978bb408588e8df4e6b6afe17.FLDV_11fc13ea1c724406bf5297de9ae12366());
      }

      private sealed class MTHD_eb4a311acdc943ad9e39610c756a6b7f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb4a311acdc943ad9e39610c756a6b7f()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_01833b54dc8d4949b0598f545e3e64c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_01833b54dc8d4949b0598f545e3e64c2()
        {
          this.Initialize("construct", true, new ParameterDescriptor[10]
          {
            new ParameterDescriptor("spell", typeof (object), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("point", typeof (Educative.Point), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("team", typeof (int), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("colors", typeof (Table), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("playSound", typeof (bool), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("onPlayersPanel", typeof (bool), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("name", typeof (string), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("outfit", typeof (Table), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("spells", typeof (Table), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("elemental", typeof (BookOf), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 0)
            return (object) Summon.construct((object) null, (Educative.Point) null, 1, (Table) null, true, false, "", (Table) null, (Table) null, BookOf.Nothing);
          if (argscount <= 1)
            return (object) Summon.construct(pars[0], (Educative.Point) null, 1, (Table) null, true, false, "", (Table) null, (Table) null, BookOf.Nothing);
          if (argscount <= 2)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], 1, (Table) null, true, false, "", (Table) null, (Table) null, BookOf.Nothing);
          if (argscount <= 3)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) null, true, false, "", (Table) null, (Table) null, BookOf.Nothing);
          if (argscount <= 4)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], true, false, "", (Table) null, (Table) null, BookOf.Nothing);
          if (argscount <= 5)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], (bool) pars[4], false, "", (Table) null, (Table) null, BookOf.Nothing);
          if (argscount <= 6)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], (bool) pars[4], (bool) pars[5], "", (Table) null, (Table) null, BookOf.Nothing);
          if (argscount <= 7)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], (bool) pars[4], (bool) pars[5], (string) pars[6], (Table) null, (Table) null, BookOf.Nothing);
          if (argscount <= 8)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], (bool) pars[4], (bool) pars[5], (string) pars[6], (Table) pars[7], (Table) null, BookOf.Nothing);
          return argscount <= 9 ? (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], (bool) pars[4], (bool) pars[5], (string) pars[6], (Table) pars[7], (Table) pars[8], BookOf.Nothing) : (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], (bool) pars[4], (bool) pars[5], (string) pars[6], (Table) pars[7], (Table) pars[8], (BookOf) pars[9]);
        }
      }

      private sealed class MTHD_62068e4cbd72487f8f99cc50b5e7ad62 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_62068e4cbd72487f8f99cc50b5e7ad62()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.Equals(pars[0]);
        }
      }

      private sealed class MTHD_eb95f599031f46f9a42135a732b9555b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb95f599031f46f9a42135a732b9555b()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_94282a0a1c414b128179028877d5f25c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_94282a0a1c414b128179028877d5f25c()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_bd01f17df8944f9d9efdb267ec59ea62 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd01f17df8944f9d9efdb267ec59ea62()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_bf2234477ccc489bbd67235741979202 : HardwiredMemberDescriptor
      {
        internal FLDV_bf2234477ccc489bbd67235741979202()
          : base(typeof (object), "spell", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return ((Summon) obj).spell;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((Summon) obj).spell = value;
        }
      }

      private sealed class FLDV_4a0f08671f4344dd9707338515019af6 : HardwiredMemberDescriptor
      {
        internal FLDV_4a0f08671f4344dd9707338515019af6()
          : base(typeof (Educative.Point), "position", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((Summon) obj).position;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((Summon) obj).position = (Educative.Point) value;
        }
      }

      private sealed class FLDV_6b5662dc0d3245a88121246685b24ba5 : HardwiredMemberDescriptor
      {
        internal FLDV_6b5662dc0d3245a88121246685b24ba5()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((Summon) obj).team;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((Summon) obj).team = (int) value;
        }
      }

      private sealed class FLDV_c3243bd4c99c4841840e415e2c0a589c : HardwiredMemberDescriptor
      {
        internal FLDV_c3243bd4c99c4841840e415e2c0a589c()
          : base(typeof (bool), "onPlayersPanel", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((Summon) obj).onPlayersPanel;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((Summon) obj).onPlayersPanel = (bool) value;
        }
      }

      private sealed class FLDV_f2c0f5de85914d99993da2d2b3b17594 : HardwiredMemberDescriptor
      {
        internal FLDV_f2c0f5de85914d99993da2d2b3b17594()
          : base(typeof (bool), "useAI", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((Summon) obj).useAI;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((Summon) obj).useAI = (bool) value;
        }
      }

      private sealed class FLDV_2d4a20f81237446f91cd9cdd76d9018e : HardwiredMemberDescriptor
      {
        internal FLDV_2d4a20f81237446f91cd9cdd76d9018e()
          : base(typeof (bool), "no_AI_still_use_turn", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((Summon) obj).no_AI_still_use_turn;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((Summon) obj).no_AI_still_use_turn = (bool) value;
        }
      }

      private sealed class FLDV_c4ccf8606cf049a6a63f81c934ee4c1b : HardwiredMemberDescriptor
      {
        internal FLDV_c4ccf8606cf049a6a63f81c934ee4c1b()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((Summon) obj).name;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((Summon) obj).name = (string) value;
        }
      }

      private sealed class FLDV_4f773c78c3ad4604825a5ac796e14740 : HardwiredMemberDescriptor
      {
        internal FLDV_4f773c78c3ad4604825a5ac796e14740()
          : base(typeof (bool), "playSound", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((Summon) obj).playSound;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((Summon) obj).playSound = (bool) value;
        }
      }

      private sealed class FLDV_1abf81268da34070a288510ce32d7fd2 : HardwiredMemberDescriptor
      {
        internal FLDV_1abf81268da34070a288510ce32d7fd2()
          : base(typeof (Table), "colors", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((Summon) obj).colors;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((Summon) obj).colors = (Table) value;
        }
      }

      private sealed class FLDV_3f799f83f51a4f7d8e1b940842d0bf1e : HardwiredMemberDescriptor
      {
        internal FLDV_3f799f83f51a4f7d8e1b940842d0bf1e()
          : base(typeof (Table), "spells", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((Summon) obj).spells;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((Summon) obj).spells = (Table) value;
        }
      }

      private sealed class FLDV_372295d88f9a46878e2b2bdcb166327e : HardwiredMemberDescriptor
      {
        internal FLDV_372295d88f9a46878e2b2bdcb166327e()
          : base(typeof (Table), "outfit", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((Summon) obj).outfit;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((Summon) obj).outfit = (Table) value;
        }
      }

      private sealed class FLDV_11fc13ea1c724406bf5297de9ae12366 : HardwiredMemberDescriptor
      {
        internal FLDV_11fc13ea1c724406bf5297de9ae12366()
          : base(typeof (BookOf), "elemental", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((Summon) obj).elemental;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((Summon) obj).elemental = (BookOf) value;
        }
      }
    }

    private sealed class TYPE_033173100587446e9d472680d13649e1 : HardwiredUserDataDescriptor
    {
      internal TYPE_033173100587446e9d472680d13649e1()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_599c5539eb1f4b24a44aeb809a5efcee()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_f52a8014d20544aeb685669a78050d5f()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_78ca926e9c0f4e76a934390deec72d5d()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_24dd1acb2ffc427ca889da7fb4cdd867()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_b6005a7e606743c0a806e3ad303d1bf8()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_b371776666d6495197880da4808c84ab()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_2f99c78b29d648da8e5cab0def6da638()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_ac6454d0db74479c8c4f08473afb0404()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_c1e627bf206f4b65b9de2c2063399d35()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_40827a1905334bc9a87c15da2a083173()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_9c03bebbd2f944b39c26a68f7fa154bf()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_1bc2ca0052ef4f8785e4ffa773e106f0()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_9b27d134a73a441b9edfc3b45d7e7f23()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_44f711114a35483e8fc7b665644258c0()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_1f75aa2c76cb479cbd205c357d8d544e()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_520a26b593cb44c68bdfa07b4cdab7f9()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_4cc4985e6b6842c7a176fee081aa250e()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_cded9389669e44ecbfb56883e91d430c()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_120b37e8bf1b49eba0fe9beac24c6a95()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_2347e7fee00641bea9b52ef0ca878f6d()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_771c6162fe8248d5af23b8eb1e89fcb5()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_31b5e4698eb54e789c33506d98bfce95()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_2a3adcf6ef624ec7823953c1c5b67314()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_dd683a063cb94593992b9956a447a81d()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_90f655eb0799433eb58956e1e567a65a()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_530d0eba75454c948621ebfdb1cc9d29()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_65c5235d68ba49509741f1e7b67615ae()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_fdf27fd941a34f39b31957e04521aa02()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_3fe0435af51e41c2ad55dc06a2737bd8()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_a1497dbf2cb442618573076729f5d7cf()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_b757a461bb6f4311b8d7ed1523567ab4()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_44d9b780f2454e41a4753dfb7fde65db()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_85ec30f4100944e08bc415f8bc26b2fa()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_4c47a29db06b447fa5107c56d0f850b0()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_fd67f1c17a7641c5ab5f2e7629c34f4d()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_4ff48190507b4c6e9669ad53555f04f6()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_305dec8a4964464cb9e31a058d3fdbd8()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_c583d9ca4937494fa530d4fbb4a440d6()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_0e1a8b82ee0b412d97e8a0a7533d7cda()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_f322b63f214a4c3fa9da0ffd1b6fc251()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_d78e1dbf2b2e466ca8752a2da4395a83()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_9edf31fe835e4f50abce2643fd06aed0()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_c9adfd11b364468fa2569fd025b10748()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_965d9fda1a934002a686445fe4a0ea97()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_abb8efbf74814bdf9fb360a664952bf6()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_3553c35413fb4776b71ac5e5fbca037e()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_d7c6990af3804a218bab9f3c0fc9b800()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.MTHD_a2d68e529ff74c76a779668642ce3506()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.PROP_a71fd6ca0acf4a71a7c9e5c574525ed7());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.PROP_0e0323dacb0640a2846190498d0cbd40());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.PROP_75f184c7fbea409fae27271ada3104f8());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.PROP_bee9d6d5a70d44108cab3fbc2b1932c4());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.PROP_318ac2ba5b5442d99b826c4344f5ae35());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.PROP_7088cc6c1cb0476d8f7308ef0a3a2271());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.PROP_3e585f81450d4a41ac6d9ee66f7d1f54());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.PROP_0c5545b5f9704eec866236aa2a4c3981());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.PROP_17f70e3555f94a539c8b47708ead7233());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.PROP_ec185c425e9148cc91a7ab2deb691761());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.PROP_1c984a1042f84cc4aabcd689a6d7a4f5());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.PROP_e47c0c3acf7a48cfa7ba8161a90e8032());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.PROP_4a55acbb65dc43cebde30c38e8183e37());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.PROP_b2860ed300994102b2bcf7a7b08d42a1());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.PROP_6fcd23b572c544209e912988edff7f52());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.PROP_d043eab252cd45b6b9d9b6acbb81630e());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.PROP_0e4a315da0f04d47aa5807e68660c451());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.PROP_0f6a24d59ba44eca805fe870f3c4273d());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.PROP_eb7d2575808e49e8a063e0d15e27c2a8());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.FLDV_15264415e20244599c72217f10265de0());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.FLDV_3ab5376a1e73405e984736a8c8e5bbf0());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_033173100587446e9d472680d13649e1.FLDV_02c58c01d067473aa7cf80794eefbddd());
      }

      private sealed class MTHD_599c5539eb1f4b24a44aeb809a5efcee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_599c5539eb1f4b24a44aeb809a5efcee()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_f52a8014d20544aeb685669a78050d5f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f52a8014d20544aeb685669a78050d5f()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_78ca926e9c0f4e76a934390deec72d5d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_78ca926e9c0f4e76a934390deec72d5d()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_24dd1acb2ffc427ca889da7fb4cdd867 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24dd1acb2ffc427ca889da7fb4cdd867()
        {
          this.Initialize("set_graphic", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (object), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).graphic = pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_b6005a7e606743c0a806e3ad303d1bf8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b6005a7e606743c0a806e3ad303d1bf8()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_b371776666d6495197880da4808c84ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b371776666d6495197880da4808c84ab()
        {
          this.Initialize("set_anchor", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (Anchor), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).anchor = (Anchor) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_2f99c78b29d648da8e5cab0def6da638 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2f99c78b29d648da8e5cab0def6da638()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_ac6454d0db74479c8c4f08473afb0404 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac6454d0db74479c8c4f08473afb0404()
        {
          this.Initialize("set_width", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).width = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_c1e627bf206f4b65b9de2c2063399d35 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c1e627bf206f4b65b9de2c2063399d35()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_40827a1905334bc9a87c15da2a083173 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_40827a1905334bc9a87c15da2a083173()
        {
          this.Initialize("set_height", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).height = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_9c03bebbd2f944b39c26a68f7fa154bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c03bebbd2f944b39c26a68f7fa154bf()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_1bc2ca0052ef4f8785e4ffa773e106f0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1bc2ca0052ef4f8785e4ffa773e106f0()
        {
          this.Initialize("set_size", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (Educative.Point), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).size = (Educative.Point) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_9b27d134a73a441b9edfc3b45d7e7f23 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b27d134a73a441b9edfc3b45d7e7f23()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_44f711114a35483e8fc7b665644258c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_44f711114a35483e8fc7b665644258c0()
        {
          this.Initialize("set_x", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).x = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_1f75aa2c76cb479cbd205c357d8d544e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f75aa2c76cb479cbd205c357d8d544e()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_520a26b593cb44c68bdfa07b4cdab7f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_520a26b593cb44c68bdfa07b4cdab7f9()
        {
          this.Initialize("set_y", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).y = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_4cc4985e6b6842c7a176fee081aa250e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4cc4985e6b6842c7a176fee081aa250e()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_cded9389669e44ecbfb56883e91d430c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cded9389669e44ecbfb56883e91d430c()
        {
          this.Initialize("set_position", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (Educative.Point), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).position = (Educative.Point) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_120b37e8bf1b49eba0fe9beac24c6a95 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_120b37e8bf1b49eba0fe9beac24c6a95()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_2347e7fee00641bea9b52ef0ca878f6d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2347e7fee00641bea9b52ef0ca878f6d()
        {
          this.Initialize("set_pivot_x", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).pivot_x = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_771c6162fe8248d5af23b8eb1e89fcb5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_771c6162fe8248d5af23b8eb1e89fcb5()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_31b5e4698eb54e789c33506d98bfce95 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_31b5e4698eb54e789c33506d98bfce95()
        {
          this.Initialize("set_pivot_y", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).pivot_y = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_2a3adcf6ef624ec7823953c1c5b67314 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a3adcf6ef624ec7823953c1c5b67314()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_dd683a063cb94593992b9956a447a81d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dd683a063cb94593992b9956a447a81d()
        {
          this.Initialize("set_pivot", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (Educative.Point), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).pivot = (Educative.Point) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_90f655eb0799433eb58956e1e567a65a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90f655eb0799433eb58956e1e567a65a()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_530d0eba75454c948621ebfdb1cc9d29 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_530d0eba75454c948621ebfdb1cc9d29()
        {
          this.Initialize("set_angle", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).angle = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_65c5235d68ba49509741f1e7b67615ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65c5235d68ba49509741f1e7b67615ae()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_fdf27fd941a34f39b31957e04521aa02 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fdf27fd941a34f39b31957e04521aa02()
        {
          this.Initialize("set_onClick", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (string), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).onClick = (string) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_3fe0435af51e41c2ad55dc06a2737bd8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3fe0435af51e41c2ad55dc06a2737bd8()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_a1497dbf2cb442618573076729f5d7cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1497dbf2cb442618573076729f5d7cf()
        {
          this.Initialize("set_color", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (string), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).color = (string) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_b757a461bb6f4311b8d7ed1523567ab4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b757a461bb6f4311b8d7ed1523567ab4()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_44d9b780f2454e41a4753dfb7fde65db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_44d9b780f2454e41a4753dfb7fde65db()
        {
          this.Initialize("set_text", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (string), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).text = (string) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_85ec30f4100944e08bc415f8bc26b2fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85ec30f4100944e08bc415f8bc26b2fa()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_4c47a29db06b447fa5107c56d0f850b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c47a29db06b447fa5107c56d0f850b0()
        {
          this.Initialize("set_textColor", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (string), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).textColor = (string) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_fd67f1c17a7641c5ab5f2e7629c34f4d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd67f1c17a7641c5ab5f2e7629c34f4d()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_4ff48190507b4c6e9669ad53555f04f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ff48190507b4c6e9669ad53555f04f6()
        {
          this.Initialize("set_textStyle", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).textStyle = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_305dec8a4964464cb9e31a058d3fdbd8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_305dec8a4964464cb9e31a058d3fdbd8()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_c583d9ca4937494fa530d4fbb4a440d6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c583d9ca4937494fa530d4fbb4a440d6()
        {
          this.Initialize("set_textSize", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).textSize = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_0e1a8b82ee0b412d97e8a0a7533d7cda : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e1a8b82ee0b412d97e8a0a7533d7cda()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f322b63f214a4c3fa9da0ffd1b6fc251 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f322b63f214a4c3fa9da0ffd1b6fc251()
        {
          this.Initialize("createUI", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("script", typeof (Script), false, (object) null, false, false, false),
            new ParameterDescriptor("parent", typeof (UIElement), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return argscount <= 1 ? (object) UIElement.createUI((Script) pars[0], (UIElement) null) : (object) UIElement.createUI((Script) pars[0], (UIElement) pars[1]);
        }
      }

      private sealed class MTHD_d78e1dbf2b2e466ca8752a2da4395a83 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d78e1dbf2b2e466ca8752a2da4395a83()
        {
          this.Initialize("createInput", true, new ParameterDescriptor[6]
          {
            new ParameterDescriptor("script", typeof (Script), false, (object) null, false, false, false),
            new ParameterDescriptor("parent", typeof (UIElement), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("callback", typeof (string), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("onSubmit", typeof (bool), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("active", typeof (bool), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("forceFocus", typeof (bool), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 1)
            return (object) UIElement.createInput((Script) pars[0], (UIElement) null, (string) null, true, true, true);
          if (argscount <= 2)
            return (object) UIElement.createInput((Script) pars[0], (UIElement) pars[1], (string) null, true, true, true);
          if (argscount <= 3)
            return (object) UIElement.createInput((Script) pars[0], (UIElement) pars[1], (string) pars[2], true, true, true);
          if (argscount <= 4)
            return (object) UIElement.createInput((Script) pars[0], (UIElement) pars[1], (string) pars[2], (bool) pars[3], true, true);
          return argscount <= 5 ? (object) UIElement.createInput((Script) pars[0], (UIElement) pars[1], (string) pars[2], (bool) pars[3], (bool) pars[4], true) : (object) UIElement.createInput((Script) pars[0], (UIElement) pars[1], (string) pars[2], (bool) pars[3], (bool) pars[4], (bool) pars[5]);
        }
      }

      private sealed class MTHD_9edf31fe835e4f50abce2643fd06aed0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9edf31fe835e4f50abce2643fd06aed0()
        {
          this.Initialize("duplicate", false, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("script", typeof (Script), false, (object) null, false, false, false),
            new ParameterDescriptor("parent", typeof (UIElement), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return argscount <= 1 ? (object) ((UIElement) obj).duplicate((Script) pars[0], (UIElement) null) : (object) ((UIElement) obj).duplicate((Script) pars[0], (UIElement) pars[1]);
        }
      }

      private sealed class MTHD_c9adfd11b364468fa2569fd025b10748 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c9adfd11b364468fa2569fd025b10748()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_965d9fda1a934002a686445fe4a0ea97 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_965d9fda1a934002a686445fe4a0ea97()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_abb8efbf74814bdf9fb360a664952bf6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_abb8efbf74814bdf9fb360a664952bf6()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.Equals(pars[0]);
        }
      }

      private sealed class MTHD_3553c35413fb4776b71ac5e5fbca037e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3553c35413fb4776b71ac5e5fbca037e()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_d7c6990af3804a218bab9f3c0fc9b800 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d7c6990af3804a218bab9f3c0fc9b800()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_a2d68e529ff74c76a779668642ce3506 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2d68e529ff74c76a779668642ce3506()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_a71fd6ca0acf4a71a7c9e5c574525ed7 : HardwiredMemberDescriptor
      {
        internal PROP_a71fd6ca0acf4a71a7c9e5c574525ed7()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_0e0323dacb0640a2846190498d0cbd40 : HardwiredMemberDescriptor
      {
        internal PROP_0e0323dacb0640a2846190498d0cbd40()
          : base(typeof (object), "graphic", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return ((UIElement) obj).graphic;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).graphic = value;
        }
      }

      private sealed class PROP_75f184c7fbea409fae27271ada3104f8 : HardwiredMemberDescriptor
      {
        internal PROP_75f184c7fbea409fae27271ada3104f8()
          : base(typeof (Anchor), "anchor", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).anchor;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).anchor = (Anchor) value;
        }
      }

      private sealed class PROP_bee9d6d5a70d44108cab3fbc2b1932c4 : HardwiredMemberDescriptor
      {
        internal PROP_bee9d6d5a70d44108cab3fbc2b1932c4()
          : base(typeof (double), "width", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).width;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).width = (double) value;
        }
      }

      private sealed class PROP_318ac2ba5b5442d99b826c4344f5ae35 : HardwiredMemberDescriptor
      {
        internal PROP_318ac2ba5b5442d99b826c4344f5ae35()
          : base(typeof (double), "height", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).height;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).height = (double) value;
        }
      }

      private sealed class PROP_7088cc6c1cb0476d8f7308ef0a3a2271 : HardwiredMemberDescriptor
      {
        internal PROP_7088cc6c1cb0476d8f7308ef0a3a2271()
          : base(typeof (Educative.Point), "size", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).size;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).size = (Educative.Point) value;
        }
      }

      private sealed class PROP_3e585f81450d4a41ac6d9ee66f7d1f54 : HardwiredMemberDescriptor
      {
        internal PROP_3e585f81450d4a41ac6d9ee66f7d1f54()
          : base(typeof (double), "x", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).x;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).x = (double) value;
        }
      }

      private sealed class PROP_0c5545b5f9704eec866236aa2a4c3981 : HardwiredMemberDescriptor
      {
        internal PROP_0c5545b5f9704eec866236aa2a4c3981()
          : base(typeof (double), "y", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).y;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).y = (double) value;
        }
      }

      private sealed class PROP_17f70e3555f94a539c8b47708ead7233 : HardwiredMemberDescriptor
      {
        internal PROP_17f70e3555f94a539c8b47708ead7233()
          : base(typeof (Educative.Point), "position", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).position;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).position = (Educative.Point) value;
        }
      }

      private sealed class PROP_ec185c425e9148cc91a7ab2deb691761 : HardwiredMemberDescriptor
      {
        internal PROP_ec185c425e9148cc91a7ab2deb691761()
          : base(typeof (double), "pivot_x", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).pivot_x;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).pivot_x = (double) value;
        }
      }

      private sealed class PROP_1c984a1042f84cc4aabcd689a6d7a4f5 : HardwiredMemberDescriptor
      {
        internal PROP_1c984a1042f84cc4aabcd689a6d7a4f5()
          : base(typeof (double), "pivot_y", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).pivot_y;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).pivot_y = (double) value;
        }
      }

      private sealed class PROP_e47c0c3acf7a48cfa7ba8161a90e8032 : HardwiredMemberDescriptor
      {
        internal PROP_e47c0c3acf7a48cfa7ba8161a90e8032()
          : base(typeof (Educative.Point), "pivot", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).pivot;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).pivot = (Educative.Point) value;
        }
      }

      private sealed class PROP_4a55acbb65dc43cebde30c38e8183e37 : HardwiredMemberDescriptor
      {
        internal PROP_4a55acbb65dc43cebde30c38e8183e37()
          : base(typeof (double), "angle", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).angle;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).angle = (double) value;
        }
      }

      private sealed class PROP_b2860ed300994102b2bcf7a7b08d42a1 : HardwiredMemberDescriptor
      {
        internal PROP_b2860ed300994102b2bcf7a7b08d42a1()
          : base(typeof (string), "onClick", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).onClick;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).onClick = (string) value;
        }
      }

      private sealed class PROP_6fcd23b572c544209e912988edff7f52 : HardwiredMemberDescriptor
      {
        internal PROP_6fcd23b572c544209e912988edff7f52()
          : base(typeof (string), "color", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).color;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).color = (string) value;
        }
      }

      private sealed class PROP_d043eab252cd45b6b9d9b6acbb81630e : HardwiredMemberDescriptor
      {
        internal PROP_d043eab252cd45b6b9d9b6acbb81630e()
          : base(typeof (string), "text", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).text;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).text = (string) value;
        }
      }

      private sealed class PROP_0e4a315da0f04d47aa5807e68660c451 : HardwiredMemberDescriptor
      {
        internal PROP_0e4a315da0f04d47aa5807e68660c451()
          : base(typeof (string), "textColor", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).textColor;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).textColor = (string) value;
        }
      }

      private sealed class PROP_0f6a24d59ba44eca805fe870f3c4273d : HardwiredMemberDescriptor
      {
        internal PROP_0f6a24d59ba44eca805fe870f3c4273d()
          : base(typeof (int), "textStyle", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).textStyle;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).textStyle = (int) value;
        }
      }

      private sealed class PROP_eb7d2575808e49e8a063e0d15e27c2a8 : HardwiredMemberDescriptor
      {
        internal PROP_eb7d2575808e49e8a063e0d15e27c2a8()
          : base(typeof (double), "textSize", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).textSize;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).textSize = (double) value;
        }
      }

      private sealed class FLDV_15264415e20244599c72217f10265de0 : HardwiredMemberDescriptor
      {
        internal FLDV_15264415e20244599c72217f10265de0()
          : base(typeof (UIElement), "parent", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).parent;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).parent = (UIElement) value;
        }
      }

      private sealed class FLDV_3ab5376a1e73405e984736a8c8e5bbf0 : HardwiredMemberDescriptor
      {
        internal FLDV_3ab5376a1e73405e984736a8c8e5bbf0()
          : base(typeof (object), "clickID", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return ((UIElement) obj).clickID;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).clickID = value;
        }
      }

      private sealed class FLDV_02c58c01d067473aa7cf80794eefbddd : HardwiredMemberDescriptor
      {
        internal FLDV_02c58c01d067473aa7cf80794eefbddd()
          : base(typeof (bool), "clickDestroy", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).clickDestroy;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).clickDestroy = (bool) value;
        }
      }
    }

    private sealed class TYPE_8cf7a64d112f4018b53d55ca0ee220f3 : HardwiredUserDataDescriptor
    {
      internal TYPE_8cf7a64d112f4018b53d55ca0ee220f3()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8cf7a64d112f4018b53d55ca0ee220f3.MTHD_edad824b025e4716b5286ed94c89b088()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8cf7a64d112f4018b53d55ca0ee220f3.MTHD_aedebf1b3fe248579f0a42a2c782a640()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8cf7a64d112f4018b53d55ca0ee220f3.MTHD_ae0db3ae592047a797f0035552811051()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8cf7a64d112f4018b53d55ca0ee220f3.MTHD_d90595a581f54ba381329fe59f5ebd60()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8cf7a64d112f4018b53d55ca0ee220f3.MTHD_fe71a614cc5a4d84ad16d666e4f93717()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8cf7a64d112f4018b53d55ca0ee220f3.MTHD_efbee84023174792bae0549bfd8e1915()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_8cf7a64d112f4018b53d55ca0ee220f3.FLDV_d996112c5d434f9c95044a65f3fcdfe9());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_8cf7a64d112f4018b53d55ca0ee220f3.FLDV_09bfeeb033b341b887889eb1eb2a5ff4());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_8cf7a64d112f4018b53d55ca0ee220f3.FLDV_5dcf937827064867b76200d786ca7486());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_8cf7a64d112f4018b53d55ca0ee220f3.FLDV_94b84585c312420a925065a59078ac47());
      }

      private sealed class MTHD_edad824b025e4716b5286ed94c89b088 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_edad824b025e4716b5286ed94c89b088()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_aedebf1b3fe248579f0a42a2c782a640 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aedebf1b3fe248579f0a42a2c782a640()
        {
          this.Initialize("addAnswer", false, new ParameterDescriptor[3]
          {
            new ParameterDescriptor("answer", typeof (string), false, (object) null, false, false, false),
            new ParameterDescriptor("checkable", typeof (bool), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("allowUserInput", typeof (bool), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 1)
            return (object) ((MyPoll.Item) obj).addAnswer((string) pars[0], true, false);
          return argscount <= 2 ? (object) ((MyPoll.Item) obj).addAnswer((string) pars[0], (bool) pars[1], false) : (object) ((MyPoll.Item) obj).addAnswer((string) pars[0], (bool) pars[1], (bool) pars[2]);
        }
      }

      private sealed class MTHD_ae0db3ae592047a797f0035552811051 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae0db3ae592047a797f0035552811051()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.Equals(pars[0]);
        }
      }

      private sealed class MTHD_d90595a581f54ba381329fe59f5ebd60 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d90595a581f54ba381329fe59f5ebd60()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_fe71a614cc5a4d84ad16d666e4f93717 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fe71a614cc5a4d84ad16d666e4f93717()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_efbee84023174792bae0549bfd8e1915 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_efbee84023174792bae0549bfd8e1915()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_d996112c5d434f9c95044a65f3fcdfe9 : HardwiredMemberDescriptor
      {
        internal FLDV_d996112c5d434f9c95044a65f3fcdfe9()
          : base(typeof (string), "question", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((MyPoll.Item) obj).question;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((MyPoll.Item) obj).question = (string) value;
        }
      }

      private sealed class FLDV_09bfeeb033b341b887889eb1eb2a5ff4 : HardwiredMemberDescriptor
      {
        internal FLDV_09bfeeb033b341b887889eb1eb2a5ff4()
          : base(typeof (bool), "multipleSelection", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((MyPoll.Item) obj).multipleSelection;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((MyPoll.Item) obj).multipleSelection = (bool) value;
        }
      }

      private sealed class FLDV_5dcf937827064867b76200d786ca7486 : HardwiredMemberDescriptor
      {
        internal FLDV_5dcf937827064867b76200d786ca7486()
          : base(typeof (bool), "requiresAnswer", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((MyPoll.Item) obj).requiresAnswer;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((MyPoll.Item) obj).requiresAnswer = (bool) value;
        }
      }

      private sealed class FLDV_94b84585c312420a925065a59078ac47 : HardwiredMemberDescriptor
      {
        internal FLDV_94b84585c312420a925065a59078ac47()
          : base(typeof (List<MyPoll.Answer>), "answers", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((MyPoll.Item) obj).answers;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((MyPoll.Item) obj).answers = (List<MyPoll.Answer>) value;
        }
      }
    }

    private sealed class TYPE_45ad71462c5945c2b7cbc4d6f66da4ba : HardwiredUserDataDescriptor
    {
      internal TYPE_45ad71462c5945c2b7cbc4d6f66da4ba()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_45ad71462c5945c2b7cbc4d6f66da4ba.MTHD_f01211e756784b518425beda6e994834()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_45ad71462c5945c2b7cbc4d6f66da4ba.MTHD_c18a1928893748c18b607b87b3491813()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_45ad71462c5945c2b7cbc4d6f66da4ba.MTHD_cab0f4b94f11443e9c3cffa3d7936d36()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_45ad71462c5945c2b7cbc4d6f66da4ba.MTHD_5bfd6b387833413daed7f672f87eb52f()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_45ad71462c5945c2b7cbc4d6f66da4ba.MTHD_76f565f9e1ef48b1bfe2e7546dbb9a77()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_45ad71462c5945c2b7cbc4d6f66da4ba.FLDV_141f08e6ee004aa98ea294c23975d8c2());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_45ad71462c5945c2b7cbc4d6f66da4ba.FLDV_90f53f2e816b4b348c646753eac1fee7());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_45ad71462c5945c2b7cbc4d6f66da4ba.FLDV_4068110b6eff4319b96c33505e5e8c95());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_45ad71462c5945c2b7cbc4d6f66da4ba.FLDV_cbb7cfcebc5640ffa104eee235199d4c());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_45ad71462c5945c2b7cbc4d6f66da4ba.FLDV_ca8d30de4efb4b9c8118102096750ff9());
      }

      private sealed class MTHD_f01211e756784b518425beda6e994834 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f01211e756784b518425beda6e994834()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_c18a1928893748c18b607b87b3491813 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c18a1928893748c18b607b87b3491813()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.Equals(pars[0]);
        }
      }

      private sealed class MTHD_cab0f4b94f11443e9c3cffa3d7936d36 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cab0f4b94f11443e9c3cffa3d7936d36()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_5bfd6b387833413daed7f672f87eb52f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5bfd6b387833413daed7f672f87eb52f()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_76f565f9e1ef48b1bfe2e7546dbb9a77 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76f565f9e1ef48b1bfe2e7546dbb9a77()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_141f08e6ee004aa98ea294c23975d8c2 : HardwiredMemberDescriptor
      {
        internal FLDV_141f08e6ee004aa98ea294c23975d8c2()
          : base(typeof (string), "text", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((MyPoll.Answer) obj).text;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((MyPoll.Answer) obj).text = (string) value;
        }
      }

      private sealed class FLDV_90f53f2e816b4b348c646753eac1fee7 : HardwiredMemberDescriptor
      {
        internal FLDV_90f53f2e816b4b348c646753eac1fee7()
          : base(typeof (bool), "allowUserInput", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((MyPoll.Answer) obj).allowUserInput;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((MyPoll.Answer) obj).allowUserInput = (bool) value;
        }
      }

      private sealed class FLDV_4068110b6eff4319b96c33505e5e8c95 : HardwiredMemberDescriptor
      {
        internal FLDV_4068110b6eff4319b96c33505e5e8c95()
          : base(typeof (bool), "checkable", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((MyPoll.Answer) obj).checkable;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((MyPoll.Answer) obj).checkable = (bool) value;
        }
      }

      private sealed class FLDV_cbb7cfcebc5640ffa104eee235199d4c : HardwiredMemberDescriptor
      {
        internal FLDV_cbb7cfcebc5640ffa104eee235199d4c()
          : base(typeof (string), "userInput", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((MyPoll.Answer) obj).userInput;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((MyPoll.Answer) obj).userInput = (string) value;
        }
      }

      private sealed class FLDV_ca8d30de4efb4b9c8118102096750ff9 : HardwiredMemberDescriptor
      {
        internal FLDV_ca8d30de4efb4b9c8118102096750ff9()
          : base(typeof (bool), "isChecked", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((MyPoll.Answer) obj).isChecked;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((MyPoll.Answer) obj).isChecked = (bool) value;
        }
      }
    }

    private sealed class TYPE_2c77888099f241bb985e24f998b8c1a0 : HardwiredUserDataDescriptor
    {
      internal TYPE_2c77888099f241bb985e24f998b8c1a0()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2c77888099f241bb985e24f998b8c1a0.MTHD_c16b9c6318e94896a7cca26fd663395c()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2c77888099f241bb985e24f998b8c1a0.MTHD_55bd9d4bb5974ebab91d3869d73a434e()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2c77888099f241bb985e24f998b8c1a0.MTHD_a199758a4c7140cd91a61408e1716a78()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2c77888099f241bb985e24f998b8c1a0.MTHD_f648adbe57c64fed9c59ef8365fdf0d7()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2c77888099f241bb985e24f998b8c1a0.MTHD_c8b2d3317bbb42e78c07ca60e5c10e0d()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2c77888099f241bb985e24f998b8c1a0.MTHD_d99a44b82ce34a81be09a09da0e1d305()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2c77888099f241bb985e24f998b8c1a0.MTHD_31f99f8bbf4d4819ae9b4228982c43a2()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2c77888099f241bb985e24f998b8c1a0.MTHD_1348c562cb1f4c0a9bbd020e721cae94()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2c77888099f241bb985e24f998b8c1a0.MTHD_131017881ce94a39960f67f783df3570()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2c77888099f241bb985e24f998b8c1a0.MTHD_912d0a309fe0446f835a4f00a4f31155()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2c77888099f241bb985e24f998b8c1a0.MTHD_2e837470be584e7ba26d10fdfecda855()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2c77888099f241bb985e24f998b8c1a0.MTHD_49f3f5c6f9d04e9eb4c61b753b0c76cd()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2c77888099f241bb985e24f998b8c1a0.MTHD_a2129ffe611f4fed8d044d7c16ee524c()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_2c77888099f241bb985e24f998b8c1a0.FLDV_de08b1962fc44f66b8fbc324d2676385());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_2c77888099f241bb985e24f998b8c1a0.FLDV_38b1836ec74546a7a94bc406481d251d());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_2c77888099f241bb985e24f998b8c1a0.FLDV_4e283eb37a6e49c19f4be2952370f5a2());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_2c77888099f241bb985e24f998b8c1a0.FLDV_a1b8a726f13740cfb9f39b5d3a1123ca());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_2c77888099f241bb985e24f998b8c1a0.FLDV_8d0bb78b604c4321a012af4f34af9423());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_2c77888099f241bb985e24f998b8c1a0.FLDV_f5560f71c62144b2aab210d6032690e3());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_2c77888099f241bb985e24f998b8c1a0.FLDV_c7218a4a30fb4494b647b24a1048a3d7());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_2c77888099f241bb985e24f998b8c1a0.FLDV_e43442e4bbd4468e9cd17cdcd05e564f());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_2c77888099f241bb985e24f998b8c1a0.DVAL_5820469a2afe44a89ba2b3e6d474ee50());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_2c77888099f241bb985e24f998b8c1a0.DVAL_b5e227e469464431861218cb05fc458c());
      }

      private sealed class MTHD_c16b9c6318e94896a7cca26fd663395c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c16b9c6318e94896a7cca26fd663395c()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_55bd9d4bb5974ebab91d3869d73a434e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_55bd9d4bb5974ebab91d3869d73a434e()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_a199758a4c7140cd91a61408e1716a78 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a199758a4c7140cd91a61408e1716a78()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f648adbe57c64fed9c59ef8365fdf0d7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f648adbe57c64fed9c59ef8365fdf0d7()
        {
          this.Initialize("addItem", false, new ParameterDescriptor[3]
          {
            new ParameterDescriptor("question", typeof (string), false, (object) null, false, false, false),
            new ParameterDescriptor("multipleSelection", typeof (bool), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("requireAnswer", typeof (bool), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 1)
            return (object) ((MyPoll) obj).addItem((string) pars[0], false, true);
          return argscount <= 2 ? (object) ((MyPoll) obj).addItem((string) pars[0], (bool) pars[1], true) : (object) ((MyPoll) obj).addItem((string) pars[0], (bool) pars[1], (bool) pars[2]);
        }
      }

      private sealed class MTHD_c8b2d3317bbb42e78c07ca60e5c10e0d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c8b2d3317bbb42e78c07ca60e5c10e0d()
        {
          this.Initialize("construct", true, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("name", typeof (string), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) MyPoll.construct((string) pars[0]);
        }
      }

      private sealed class MTHD_d99a44b82ce34a81be09a09da0e1d305 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d99a44b82ce34a81be09a09da0e1d305()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_31f99f8bbf4d4819ae9b4228982c43a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_31f99f8bbf4d4819ae9b4228982c43a2()
        {
          this.Initialize("fromString", true, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("s", typeof (string), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) MyPoll.fromString((string) pars[0]);
        }
      }

      private sealed class MTHD_1348c562cb1f4c0a9bbd020e721cae94 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1348c562cb1f4c0a9bbd020e721cae94()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_131017881ce94a39960f67f783df3570 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_131017881ce94a39960f67f783df3570()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_912d0a309fe0446f835a4f00a4f31155 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_912d0a309fe0446f835a4f00a4f31155()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_2e837470be584e7ba26d10fdfecda855 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2e837470be584e7ba26d10fdfecda855()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.Equals(pars[0]);
        }
      }

      private sealed class MTHD_49f3f5c6f9d04e9eb4c61b753b0c76cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49f3f5c6f9d04e9eb4c61b753b0c76cd()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_a2129ffe611f4fed8d044d7c16ee524c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2129ffe611f4fed8d044d7c16ee524c()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_de08b1962fc44f66b8fbc324d2676385 : HardwiredMemberDescriptor
      {
        internal FLDV_de08b1962fc44f66b8fbc324d2676385()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((MyPoll) obj).name;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((MyPoll) obj).name = (string) value;
        }
      }

      private sealed class FLDV_38b1836ec74546a7a94bc406481d251d : HardwiredMemberDescriptor
      {
        internal FLDV_38b1836ec74546a7a94bc406481d251d()
          : base(typeof (int), "id", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((MyPoll) obj).id;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((MyPoll) obj).id = (int) value;
        }
      }

      private sealed class FLDV_4e283eb37a6e49c19f4be2952370f5a2 : HardwiredMemberDescriptor
      {
        internal FLDV_4e283eb37a6e49c19f4be2952370f5a2()
          : base(typeof (List<MyPoll.Item>), "items", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((MyPoll) obj).items;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((MyPoll) obj).items = (List<MyPoll.Item>) value;
        }
      }

      private sealed class FLDV_a1b8a726f13740cfb9f39b5d3a1123ca : HardwiredMemberDescriptor
      {
        internal FLDV_a1b8a726f13740cfb9f39b5d3a1123ca()
          : base(typeof (bool), "isPublic", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((MyPoll) obj).isPublic;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((MyPoll) obj).isPublic = (bool) value;
        }
      }

      private sealed class FLDV_8d0bb78b604c4321a012af4f34af9423 : HardwiredMemberDescriptor
      {
        internal FLDV_8d0bb78b604c4321a012af4f34af9423()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_f5560f71c62144b2aab210d6032690e3 : HardwiredMemberDescriptor
      {
        internal FLDV_f5560f71c62144b2aab210d6032690e3()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_c7218a4a30fb4494b647b24a1048a3d7 : HardwiredMemberDescriptor
      {
        internal FLDV_c7218a4a30fb4494b647b24a1048a3d7()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_e43442e4bbd4468e9cd17cdcd05e564f : HardwiredMemberDescriptor
      {
        internal FLDV_e43442e4bbd4468e9cd17cdcd05e564f()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_5820469a2afe44a89ba2b3e6d474ee50 : DynValueMemberDescriptor
      {
        internal DVAL_5820469a2afe44a89ba2b3e6d474ee50()
          : base("Item")
        {
        }

        public override DynValue Value
        {
          get
          {
            return UserData.CreateStatic(typeof (MyPoll.Item));
          }
        }
      }

      private sealed class DVAL_b5e227e469464431861218cb05fc458c : DynValueMemberDescriptor
      {
        internal DVAL_b5e227e469464431861218cb05fc458c()
          : base("Answer")
        {
        }

        public override DynValue Value
        {
          get
          {
            return UserData.CreateStatic(typeof (MyPoll.Answer));
          }
        }
      }
    }

    private sealed class TYPE_dbfab461b99a4fb680bbb94ee1dd2fc8 : HardwiredUserDataDescriptor
    {
      internal TYPE_dbfab461b99a4fb680bbb94ee1dd2fc8()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dbfab461b99a4fb680bbb94ee1dd2fc8.MTHD_cbedda82be5448d282839c21aeec0215()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dbfab461b99a4fb680bbb94ee1dd2fc8.MTHD_30115cb567674e1f8388995b274535e0()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dbfab461b99a4fb680bbb94ee1dd2fc8.MTHD_3493bf8f2c3f4ca6886c8106f693aa02(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dbfab461b99a4fb680bbb94ee1dd2fc8.MTHD_8bc345475f254b909436eb093f91ef54()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dbfab461b99a4fb680bbb94ee1dd2fc8.MTHD_234ff7d72dfb48ba93b6af608441f6cb(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dbfab461b99a4fb680bbb94ee1dd2fc8.MTHD_ae6dc432725147aa87af115eb4602862()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dbfab461b99a4fb680bbb94ee1dd2fc8.MTHD_0be3d91514ff450e92c1b3a664d6bd0b()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dbfab461b99a4fb680bbb94ee1dd2fc8.MTHD_4fe597425b0e4f9ebe803b05d9fa14e7()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dbfab461b99a4fb680bbb94ee1dd2fc8.MTHD_b9aafac127494b9e9ea0ab5db042cddd()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dbfab461b99a4fb680bbb94ee1dd2fc8.MTHD_a5a76fd21a62499a8ee47952adf50317()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_dbfab461b99a4fb680bbb94ee1dd2fc8.FLDV_715fd922c83c4793ac2a8f0ca4034784());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_dbfab461b99a4fb680bbb94ee1dd2fc8.FLDV_61c5a0219aab454ba466f2c2e13c1cfc());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_dbfab461b99a4fb680bbb94ee1dd2fc8.FLDV_df3f0e55a26e469ea3e8bb04306b6db3());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_dbfab461b99a4fb680bbb94ee1dd2fc8.FLDV_44b274ba8cab4a96a160a58db63038eb());
      }

      private sealed class MTHD_cbedda82be5448d282839c21aeec0215 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cbedda82be5448d282839c21aeec0215()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_30115cb567674e1f8388995b274535e0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_30115cb567674e1f8388995b274535e0()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_3493bf8f2c3f4ca6886c8106f693aa02 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3493bf8f2c3f4ca6886c8106f693aa02()
        {
          this.Initialize("construct", true, new ParameterDescriptor[4]
          {
            new ParameterDescriptor("r", typeof (byte), false, (object) null, false, false, false),
            new ParameterDescriptor("g", typeof (byte), false, (object) null, false, false, false),
            new ParameterDescriptor("b", typeof (byte), false, (object) null, false, false, false),
            new ParameterDescriptor("a", typeof (byte), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) LuaColor.construct((byte) pars[0], (byte) pars[1], (byte) pars[2], (byte) pars[3]);
        }
      }

      private sealed class MTHD_8bc345475f254b909436eb093f91ef54 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8bc345475f254b909436eb093f91ef54()
        {
          this.Initialize("construct", true, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("hex", typeof (string), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) LuaColor.construct((string) pars[0]);
        }
      }

      private sealed class MTHD_234ff7d72dfb48ba93b6af608441f6cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_234ff7d72dfb48ba93b6af608441f6cb()
        {
          this.Initialize("From", true, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("c", typeof (Color32), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) LuaColor.From((Color32) pars[0]);
        }
      }

      private sealed class MTHD_ae6dc432725147aa87af115eb4602862 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae6dc432725147aa87af115eb4602862()
        {
          this.Initialize("From", true, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("c", typeof (LuaColor), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) LuaColor.From((LuaColor) pars[0]);
        }
      }

      private sealed class MTHD_0be3d91514ff450e92c1b3a664d6bd0b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0be3d91514ff450e92c1b3a664d6bd0b()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.Equals(pars[0]);
        }
      }

      private sealed class MTHD_4fe597425b0e4f9ebe803b05d9fa14e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4fe597425b0e4f9ebe803b05d9fa14e7()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_b9aafac127494b9e9ea0ab5db042cddd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b9aafac127494b9e9ea0ab5db042cddd()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_a5a76fd21a62499a8ee47952adf50317 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a5a76fd21a62499a8ee47952adf50317()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_715fd922c83c4793ac2a8f0ca4034784 : HardwiredMemberDescriptor
      {
        internal FLDV_715fd922c83c4793ac2a8f0ca4034784()
          : base(typeof (byte), "r", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((LuaColor) obj).r;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((LuaColor) obj).r = (byte) value;
        }
      }

      private sealed class FLDV_61c5a0219aab454ba466f2c2e13c1cfc : HardwiredMemberDescriptor
      {
        internal FLDV_61c5a0219aab454ba466f2c2e13c1cfc()
          : base(typeof (byte), "g", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((LuaColor) obj).g;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((LuaColor) obj).g = (byte) value;
        }
      }

      private sealed class FLDV_df3f0e55a26e469ea3e8bb04306b6db3 : HardwiredMemberDescriptor
      {
        internal FLDV_df3f0e55a26e469ea3e8bb04306b6db3()
          : base(typeof (byte), "b", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((LuaColor) obj).b;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((LuaColor) obj).b = (byte) value;
        }
      }

      private sealed class FLDV_44b274ba8cab4a96a160a58db63038eb : HardwiredMemberDescriptor
      {
        internal FLDV_44b274ba8cab4a96a160a58db63038eb()
          : base(typeof (byte), "a", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((LuaColor) obj).a;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((LuaColor) obj).a = (byte) value;
        }
      }
    }

    private sealed class TYPE_e85970bb2e054b5d9309c44eda9a3bd7 : HardwiredUserDataDescriptor
    {
      internal TYPE_e85970bb2e054b5d9309c44eda9a3bd7()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e85970bb2e054b5d9309c44eda9a3bd7.MTHD_3f6aa196c0d04fa0b2c0ce40efb4498c()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e85970bb2e054b5d9309c44eda9a3bd7.MTHD_1b3d36c4bfe143ac880afee1ab4ae8ff()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e85970bb2e054b5d9309c44eda9a3bd7.MTHD_45e7cd651523412f9db9edf03209b393()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e85970bb2e054b5d9309c44eda9a3bd7.MTHD_8b4234f41ced441a859878cbdadb0264()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e85970bb2e054b5d9309c44eda9a3bd7.MTHD_9ce8cca3374e41ccb4a4bebb31a7e327()
        }));
      }

      private sealed class MTHD_3f6aa196c0d04fa0b2c0ce40efb4498c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f6aa196c0d04fa0b2c0ce40efb4498c()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_1b3d36c4bfe143ac880afee1ab4ae8ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1b3d36c4bfe143ac880afee1ab4ae8ff()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.Equals(pars[0]);
        }
      }

      private sealed class MTHD_45e7cd651523412f9db9edf03209b393 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_45e7cd651523412f9db9edf03209b393()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_8b4234f41ced441a859878cbdadb0264 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b4234f41ced441a859878cbdadb0264()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_9ce8cca3374e41ccb4a4bebb31a7e327 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ce8cca3374e41ccb4a4bebb31a7e327()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }
    }
  }
}
