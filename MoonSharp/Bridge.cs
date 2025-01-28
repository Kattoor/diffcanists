
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
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_992947ecae8a496eaf3a73a022b34bcf());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_ef15c76fc75b48b797e33ed105e2b106());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_0998032d752044c78f0ba12bfce50d1d());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_1480b72b568a4ffb8d1542688875dfe4());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_03f512dde1134381babc415b717591e4());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_4363901069d94c5d91feb9c40f733b91());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_fd45273f9ee34908b3ab75899a932dbb());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_9dfc6ca5898b48929a10296c55be684b());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_d1d043fcd373499d81ce71ecac33856c());
    }

    private sealed class TYPE_da1377e11af14d83ad6afcd824397cca : HardwiredUserDataDescriptor
    {
      internal TYPE_da1377e11af14d83ad6afcd824397cca()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_d52cbde176244cba88370c3a5fdcdd52()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_d9ca1456185c47feaa967ed9348b018d()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_d8178245bbcb40adb98ee4de9612a7c0()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_880c68b889714133b029969e0e172d1f()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_2ca5201fb00a4dd1872c3852f552d680()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_7b3825cf909e465db47ad76e4600013c()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_e4c089ee01eb416ba0257ed54d887f20()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_428640f5d76b42568a9d5ab1720702b8()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_fbf2183548ca4bf4a0ae94234bfa0e09()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_30c71b77bbca47299d709ec8cfbc7bc9()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_783e011891df4337a6ed0fd293376e17()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_335bdbf318724d67a08fddc863b77225()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_ceea1a351e664efd9c04143b06392363()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_fef27e671df740f0a8be852b1b9e3b3a()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_f40f90b893704b6290634c64f1159540()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_55a440c781dc40f4927cc38404670199()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_2877212a536d44fca7271fa60c999e5d()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_1f13e30aa55c4062bac623a2a5b5f747()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_54f6386850734544ae0555bf8345cd09()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_905e639243d04bb293a23cbad9145948()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_0d992c11edc54e3dbff04be231979a55()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_1253088aee4f4cde93f146025840fee6()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_411b08f149884a2bb9afd960d33da8db()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_145df9de67e3448daa4d98d1a4c9f756()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_83304099145d438eaa988ce2fbfa8d7f()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_fa18c7c6605f480f9866437df0ea6502()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_2e7e1a69fcfe4eda9cd77d491981835f()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_39c008669db94fef9bfea87049db0c5d()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_6e1833eaa5554510a989bb28eb1af906()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_eb60968d9ab549eb9934e470c6fd3495()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_02c0bd8f59354011b1d3e331da638cc6()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_94c6fef001bd4e888edcb4ccbde5def2()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_4c9722f0f09d4a1092ed0190f77a223a()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_5b143b0e8bd047e6b9358cf1b6ff8215()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_5363580df32f4b66818b7a3f12cf9bd6()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_8dddc2829b374acd8902ddf5b81f2b2e()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_e2dae595d1384c79aadc1ec7b90ac9a2()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_d66dc719dbfb4cf398de9b6c946dee93()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_83762104a7074f9eb61802b8e6bbd760()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_721d0e80289b411cae37de82ded7f2e0()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_af4736d06a9a4a3297cda2d715eb7106()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_02ac830fba6a4301964f6f64541d01ff()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_d1edb7d0ce3f4ae9be85b58e7c2b588e()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_dc07f7e482ca446f9e3271577043119c()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_4a8004db71df46ec859f76e981c43903()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_8974f80f46114f9f872393efbac36f7b()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_cd769775f50b4f83b589473bd5bbd63c()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_0177392ef02d48548960c6cf7dea4364()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_6b78a75890e247f88386d7568d6c250c()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_70d49f47e7964c649a1802736b20a058()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_8db4105dfc3440809fef3031f3eb8325()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_e0495734a41449798990deba602410da()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_14dcff73cf144a229b74961a47b3b29a()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_84e9351ec10747de8289666e21d3e1c7()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_e9579a2a05e0460db4af0747057ea7dd()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_6520beb7418140c7a6389d8116319f2b()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_4ef4c8f8f4a94fcc90040956842255c6()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_a25987d7254f46e0858894ea4b8fcba6()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_28e4ac4da6f5487298612fcd3b199841()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_756f8df7970040179ee8d22d0be024cf()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_afce91fee77645408036eb36780f2a81()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_77fb9b380d5b43de98d674161236962f()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_f404ff6218cd4e1580c9da4b2855a883()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_f3b52bd1fae341578630c251db6a52cb()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_291591dbf0ad45a2bcd1f62ad70d69ec()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_0ce29b83d0ae48849c969ece1e44f918()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_0a22a47af96546fa95f8c9fb4a4b14fa()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_64d5817293f740f1912096a1c6de8e67()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_c2df76d054274893811d18181af17b3b()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_d25102b8d57649f0b92e4706c08b2f2c()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_70772cd4a1434f55923656bf60acde9f()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_e6b82fa72eea4c6d858377072a784275()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_957bf96c244e4cb49b00ead73b3fad81()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_d3c622ccf839409795cba552422ba6dc()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_02d79980bff04e7eb5f4ff41f225a0a9()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_4a9030aa56f34202b600c4437269af9c()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_cbbe127b455f498ba63573024b620dd2()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_411ed2a32225487b819d78c74ceed54d()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_ed895482739d44d5bb4a53f25eea049b()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_0b6ab7277bd1442ab5625f4a154db259()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_331babf686434172a726ed7fb8a65f62()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_8a6ff50350b54eeda35a33a7960db064()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_7cda5dfd1115488a9e9d1d720d6b6657()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_a4c82c2b5aa84cba8a57860a82a7dec8()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_b611b44c2e0e40da87a1e94c878d88ab()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_e8dbf962829848bca771d36d9db84efb()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_19956a67e46b462a8dcb631743b4eac9()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_86ff6df7ce9c460192d3286f6821baae()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_f159466a8f164d4daa58cd22968b6a32()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_d1326f36299a417c8c9c58ad119f0be0()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_c0da3c96614b4d80973a43054b63ec87()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_6a5ab3401d594336b09b1f71daf67461()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_2a53acb1b8aa4d32b70067064852a8a3()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_ecb28b935cc84b3881c5f436d55ee6e2()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_60d71e5ea0b0473bacdb4afe6ba3e57c()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_746d032870b24e6b972fb5a56e3e4fbc()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.MTHD_0f05ab6a187343ee9c8bb0352c21e021()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_5c7c035c369140d4ab324cf01aa10c13());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_ca539a192a8845e7894a9dc98743b23f());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_b495d7ea8aba41f8ad0db3f599682d9d());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_752933c0bc0f4df5a37c5ea34a714c2b());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_c679b6d8120a451ca8e9b6126895de10());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_e213da388e264690b59a044f78bbf72b());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_369fac9cc99746b985d3fbdfd3c5ac56());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_36ca3eff417446af872f1acce6e4a3b1());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_2b030fcd0a82427caebc5708c0302ef2());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_746c2757e19445bc9157465f256063c1());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_d7c42fd527a8459b9fadba9dbd350f64());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_10d8dce68fab4929ac610436842c9df9());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_8fb1804b4c88401ca324097997663d0c());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_b16bb824daa7466f9e703399237f4d84());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_99574ede1d9e45af8070bb987f92dbd2());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_840dafe86bbb44a285ed167cbe1e7225());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_7a8844f58b3f49a586fc79a938f8b6e0());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_af371858a0a5453eaf58d34acdcf741c());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_9ddd7aadc3a34ed08dc650f209fd976a());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_81a7f4420c854c2a8d30b46152c0bc5e());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_52690e00f8464e259e5a8cc07a103cac());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_8f54877521ec4dde84625c8cefc96bc1());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_612ce1f19a5740fdb0a022a1f9377e48());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_48b08d0184964bbda92bfe25020c7f34());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_ef5a6a54c3a346e88e00628f5f6ee450());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_212c23fa6e65448f9153864f49110a2f());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_0bf0fbe4cca94c348f1a4d7416a6e3e6());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_465435b49c694ad0aad3eb72b1a9f4c0());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_67a0bbcf073a4e3fb135ae34f3014ccf());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_6e6db2a510d4439a8cae7b92a7cf3ff7());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_c7bcc9d995a8452c8a9f578f14bec20b());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_da1377e11af14d83ad6afcd824397cca.PROP_537e49d1134340c2a23e1ed46e794d5f());
      }

      private sealed class MTHD_d52cbde176244cba88370c3a5fdcdd52 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d52cbde176244cba88370c3a5fdcdd52()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_d9ca1456185c47feaa967ed9348b018d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d9ca1456185c47feaa967ed9348b018d()
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

      private sealed class MTHD_d8178245bbcb40adb98ee4de9612a7c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8178245bbcb40adb98ee4de9612a7c0()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_880c68b889714133b029969e0e172d1f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_880c68b889714133b029969e0e172d1f()
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

      private sealed class MTHD_2ca5201fb00a4dd1872c3852f552d680 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2ca5201fb00a4dd1872c3852f552d680()
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

      private sealed class MTHD_7b3825cf909e465db47ad76e4600013c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b3825cf909e465db47ad76e4600013c()
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

      private sealed class MTHD_e4c089ee01eb416ba0257ed54d887f20 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e4c089ee01eb416ba0257ed54d887f20()
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

      private sealed class MTHD_428640f5d76b42568a9d5ab1720702b8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_428640f5d76b42568a9d5ab1720702b8()
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

      private sealed class MTHD_fbf2183548ca4bf4a0ae94234bfa0e09 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fbf2183548ca4bf4a0ae94234bfa0e09()
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

      private sealed class MTHD_30c71b77bbca47299d709ec8cfbc7bc9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_30c71b77bbca47299d709ec8cfbc7bc9()
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

      private sealed class MTHD_783e011891df4337a6ed0fd293376e17 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_783e011891df4337a6ed0fd293376e17()
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

      private sealed class MTHD_335bdbf318724d67a08fddc863b77225 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_335bdbf318724d67a08fddc863b77225()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_ceea1a351e664efd9c04143b06392363 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ceea1a351e664efd9c04143b06392363()
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

      private sealed class MTHD_fef27e671df740f0a8be852b1b9e3b3a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fef27e671df740f0a8be852b1b9e3b3a()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_f40f90b893704b6290634c64f1159540 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f40f90b893704b6290634c64f1159540()
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

      private sealed class MTHD_55a440c781dc40f4927cc38404670199 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_55a440c781dc40f4927cc38404670199()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_2877212a536d44fca7271fa60c999e5d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2877212a536d44fca7271fa60c999e5d()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_1f13e30aa55c4062bac623a2a5b5f747 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f13e30aa55c4062bac623a2a5b5f747()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_54f6386850734544ae0555bf8345cd09 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_54f6386850734544ae0555bf8345cd09()
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

      private sealed class MTHD_905e639243d04bb293a23cbad9145948 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_905e639243d04bb293a23cbad9145948()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_0d992c11edc54e3dbff04be231979a55 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d992c11edc54e3dbff04be231979a55()
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

      private sealed class MTHD_1253088aee4f4cde93f146025840fee6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1253088aee4f4cde93f146025840fee6()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_411b08f149884a2bb9afd960d33da8db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_411b08f149884a2bb9afd960d33da8db()
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

      private sealed class MTHD_145df9de67e3448daa4d98d1a4c9f756 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_145df9de67e3448daa4d98d1a4c9f756()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_83304099145d438eaa988ce2fbfa8d7f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_83304099145d438eaa988ce2fbfa8d7f()
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

      private sealed class MTHD_fa18c7c6605f480f9866437df0ea6502 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa18c7c6605f480f9866437df0ea6502()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_2e7e1a69fcfe4eda9cd77d491981835f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2e7e1a69fcfe4eda9cd77d491981835f()
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

      private sealed class MTHD_39c008669db94fef9bfea87049db0c5d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_39c008669db94fef9bfea87049db0c5d()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_6e1833eaa5554510a989bb28eb1af906 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e1833eaa5554510a989bb28eb1af906()
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

      private sealed class MTHD_eb60968d9ab549eb9934e470c6fd3495 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb60968d9ab549eb9934e470c6fd3495()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_02c0bd8f59354011b1d3e331da638cc6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_02c0bd8f59354011b1d3e331da638cc6()
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

      private sealed class MTHD_94c6fef001bd4e888edcb4ccbde5def2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_94c6fef001bd4e888edcb4ccbde5def2()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_4c9722f0f09d4a1092ed0190f77a223a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c9722f0f09d4a1092ed0190f77a223a()
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

      private sealed class MTHD_5b143b0e8bd047e6b9358cf1b6ff8215 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b143b0e8bd047e6b9358cf1b6ff8215()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_5363580df32f4b66818b7a3f12cf9bd6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5363580df32f4b66818b7a3f12cf9bd6()
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

      private sealed class MTHD_8dddc2829b374acd8902ddf5b81f2b2e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8dddc2829b374acd8902ddf5b81f2b2e()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_e2dae595d1384c79aadc1ec7b90ac9a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e2dae595d1384c79aadc1ec7b90ac9a2()
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

      private sealed class MTHD_d66dc719dbfb4cf398de9b6c946dee93 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d66dc719dbfb4cf398de9b6c946dee93()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_83762104a7074f9eb61802b8e6bbd760 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_83762104a7074f9eb61802b8e6bbd760()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_721d0e80289b411cae37de82ded7f2e0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_721d0e80289b411cae37de82ded7f2e0()
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

      private sealed class MTHD_af4736d06a9a4a3297cda2d715eb7106 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_af4736d06a9a4a3297cda2d715eb7106()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_02ac830fba6a4301964f6f64541d01ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_02ac830fba6a4301964f6f64541d01ff()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_d1edb7d0ce3f4ae9be85b58e7c2b588e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1edb7d0ce3f4ae9be85b58e7c2b588e()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_dc07f7e482ca446f9e3271577043119c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc07f7e482ca446f9e3271577043119c()
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

      private sealed class MTHD_4a8004db71df46ec859f76e981c43903 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a8004db71df46ec859f76e981c43903()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_8974f80f46114f9f872393efbac36f7b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8974f80f46114f9f872393efbac36f7b()
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

      private sealed class MTHD_cd769775f50b4f83b589473bd5bbd63c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd769775f50b4f83b589473bd5bbd63c()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_0177392ef02d48548960c6cf7dea4364 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0177392ef02d48548960c6cf7dea4364()
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

      private sealed class MTHD_6b78a75890e247f88386d7568d6c250c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b78a75890e247f88386d7568d6c250c()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_70d49f47e7964c649a1802736b20a058 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70d49f47e7964c649a1802736b20a058()
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

      private sealed class MTHD_8db4105dfc3440809fef3031f3eb8325 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8db4105dfc3440809fef3031f3eb8325()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_e0495734a41449798990deba602410da : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e0495734a41449798990deba602410da()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_14dcff73cf144a229b74961a47b3b29a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_14dcff73cf144a229b74961a47b3b29a()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_84e9351ec10747de8289666e21d3e1c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84e9351ec10747de8289666e21d3e1c7()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_e9579a2a05e0460db4af0747057ea7dd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e9579a2a05e0460db4af0747057ea7dd()
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

      private sealed class MTHD_6520beb7418140c7a6389d8116319f2b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6520beb7418140c7a6389d8116319f2b()
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

      private sealed class MTHD_4ef4c8f8f4a94fcc90040956842255c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ef4c8f8f4a94fcc90040956842255c6()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_a25987d7254f46e0858894ea4b8fcba6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a25987d7254f46e0858894ea4b8fcba6()
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

      private sealed class MTHD_28e4ac4da6f5487298612fcd3b199841 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_28e4ac4da6f5487298612fcd3b199841()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_756f8df7970040179ee8d22d0be024cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_756f8df7970040179ee8d22d0be024cf()
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

      private sealed class MTHD_afce91fee77645408036eb36780f2a81 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_afce91fee77645408036eb36780f2a81()
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

      private sealed class MTHD_77fb9b380d5b43de98d674161236962f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_77fb9b380d5b43de98d674161236962f()
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

      private sealed class MTHD_f404ff6218cd4e1580c9da4b2855a883 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f404ff6218cd4e1580c9da4b2855a883()
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

      private sealed class MTHD_f3b52bd1fae341578630c251db6a52cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f3b52bd1fae341578630c251db6a52cb()
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

      private sealed class MTHD_291591dbf0ad45a2bcd1f62ad70d69ec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_291591dbf0ad45a2bcd1f62ad70d69ec()
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

      private sealed class MTHD_0ce29b83d0ae48849c969ece1e44f918 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ce29b83d0ae48849c969ece1e44f918()
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

      private sealed class MTHD_0a22a47af96546fa95f8c9fb4a4b14fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0a22a47af96546fa95f8c9fb4a4b14fa()
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

      private sealed class MTHD_64d5817293f740f1912096a1c6de8e67 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_64d5817293f740f1912096a1c6de8e67()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c2df76d054274893811d18181af17b3b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c2df76d054274893811d18181af17b3b()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_d25102b8d57649f0b92e4706c08b2f2c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d25102b8d57649f0b92e4706c08b2f2c()
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

      private sealed class MTHD_70772cd4a1434f55923656bf60acde9f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70772cd4a1434f55923656bf60acde9f()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_e6b82fa72eea4c6d858377072a784275 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e6b82fa72eea4c6d858377072a784275()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_957bf96c244e4cb49b00ead73b3fad81 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_957bf96c244e4cb49b00ead73b3fad81()
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

      private sealed class MTHD_d3c622ccf839409795cba552422ba6dc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d3c622ccf839409795cba552422ba6dc()
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

      private sealed class MTHD_02d79980bff04e7eb5f4ff41f225a0a9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_02d79980bff04e7eb5f4ff41f225a0a9()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_4a9030aa56f34202b600c4437269af9c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a9030aa56f34202b600c4437269af9c()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_cbbe127b455f498ba63573024b620dd2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cbbe127b455f498ba63573024b620dd2()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_411ed2a32225487b819d78c74ceed54d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_411ed2a32225487b819d78c74ceed54d()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ed895482739d44d5bb4a53f25eea049b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed895482739d44d5bb4a53f25eea049b()
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

      private sealed class MTHD_0b6ab7277bd1442ab5625f4a154db259 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b6ab7277bd1442ab5625f4a154db259()
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

      private sealed class MTHD_331babf686434172a726ed7fb8a65f62 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_331babf686434172a726ed7fb8a65f62()
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

      private sealed class MTHD_8a6ff50350b54eeda35a33a7960db064 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a6ff50350b54eeda35a33a7960db064()
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

      private sealed class MTHD_7cda5dfd1115488a9e9d1d720d6b6657 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7cda5dfd1115488a9e9d1d720d6b6657()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_a4c82c2b5aa84cba8a57860a82a7dec8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a4c82c2b5aa84cba8a57860a82a7dec8()
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

      private sealed class MTHD_b611b44c2e0e40da87a1e94c878d88ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b611b44c2e0e40da87a1e94c878d88ab()
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

      private sealed class MTHD_e8dbf962829848bca771d36d9db84efb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e8dbf962829848bca771d36d9db84efb()
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

      private sealed class MTHD_19956a67e46b462a8dcb631743b4eac9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_19956a67e46b462a8dcb631743b4eac9()
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

      private sealed class MTHD_86ff6df7ce9c460192d3286f6821baae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_86ff6df7ce9c460192d3286f6821baae()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_f159466a8f164d4daa58cd22968b6a32 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f159466a8f164d4daa58cd22968b6a32()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_d1326f36299a417c8c9c58ad119f0be0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1326f36299a417c8c9c58ad119f0be0()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_c0da3c96614b4d80973a43054b63ec87 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c0da3c96614b4d80973a43054b63ec87()
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

      private sealed class MTHD_6a5ab3401d594336b09b1f71daf67461 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6a5ab3401d594336b09b1f71daf67461()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_2a53acb1b8aa4d32b70067064852a8a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a53acb1b8aa4d32b70067064852a8a3()
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

      private sealed class MTHD_ecb28b935cc84b3881c5f436d55ee6e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ecb28b935cc84b3881c5f436d55ee6e2()
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

      private sealed class MTHD_60d71e5ea0b0473bacdb4afe6ba3e57c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60d71e5ea0b0473bacdb4afe6ba3e57c()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_746d032870b24e6b972fb5a56e3e4fbc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_746d032870b24e6b972fb5a56e3e4fbc()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_0f05ab6a187343ee9c8bb0352c21e021 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f05ab6a187343ee9c8bb0352c21e021()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_5c7c035c369140d4ab324cf01aa10c13 : HardwiredMemberDescriptor
      {
        internal PROP_5c7c035c369140d4ab324cf01aa10c13()
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

      private sealed class PROP_ca539a192a8845e7894a9dc98743b23f : HardwiredMemberDescriptor
      {
        internal PROP_ca539a192a8845e7894a9dc98743b23f()
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

      private sealed class PROP_b495d7ea8aba41f8ad0db3f599682d9d : HardwiredMemberDescriptor
      {
        internal PROP_b495d7ea8aba41f8ad0db3f599682d9d()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_752933c0bc0f4df5a37c5ea34a714c2b : HardwiredMemberDescriptor
      {
        internal PROP_752933c0bc0f4df5a37c5ea34a714c2b()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_c679b6d8120a451ca8e9b6126895de10 : HardwiredMemberDescriptor
      {
        internal PROP_c679b6d8120a451ca8e9b6126895de10()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_e213da388e264690b59a044f78bbf72b : HardwiredMemberDescriptor
      {
        internal PROP_e213da388e264690b59a044f78bbf72b()
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

      private sealed class PROP_369fac9cc99746b985d3fbdfd3c5ac56 : HardwiredMemberDescriptor
      {
        internal PROP_369fac9cc99746b985d3fbdfd3c5ac56()
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

      private sealed class PROP_36ca3eff417446af872f1acce6e4a3b1 : HardwiredMemberDescriptor
      {
        internal PROP_36ca3eff417446af872f1acce6e4a3b1()
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

      private sealed class PROP_2b030fcd0a82427caebc5708c0302ef2 : HardwiredMemberDescriptor
      {
        internal PROP_2b030fcd0a82427caebc5708c0302ef2()
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

      private sealed class PROP_746c2757e19445bc9157465f256063c1 : HardwiredMemberDescriptor
      {
        internal PROP_746c2757e19445bc9157465f256063c1()
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

      private sealed class PROP_d7c42fd527a8459b9fadba9dbd350f64 : HardwiredMemberDescriptor
      {
        internal PROP_d7c42fd527a8459b9fadba9dbd350f64()
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

      private sealed class PROP_10d8dce68fab4929ac610436842c9df9 : HardwiredMemberDescriptor
      {
        internal PROP_10d8dce68fab4929ac610436842c9df9()
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

      private sealed class PROP_8fb1804b4c88401ca324097997663d0c : HardwiredMemberDescriptor
      {
        internal PROP_8fb1804b4c88401ca324097997663d0c()
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

      private sealed class PROP_b16bb824daa7466f9e703399237f4d84 : HardwiredMemberDescriptor
      {
        internal PROP_b16bb824daa7466f9e703399237f4d84()
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

      private sealed class PROP_99574ede1d9e45af8070bb987f92dbd2 : HardwiredMemberDescriptor
      {
        internal PROP_99574ede1d9e45af8070bb987f92dbd2()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_840dafe86bbb44a285ed167cbe1e7225 : HardwiredMemberDescriptor
      {
        internal PROP_840dafe86bbb44a285ed167cbe1e7225()
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

      private sealed class PROP_7a8844f58b3f49a586fc79a938f8b6e0 : HardwiredMemberDescriptor
      {
        internal PROP_7a8844f58b3f49a586fc79a938f8b6e0()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_af371858a0a5453eaf58d34acdcf741c : HardwiredMemberDescriptor
      {
        internal PROP_af371858a0a5453eaf58d34acdcf741c()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_9ddd7aadc3a34ed08dc650f209fd976a : HardwiredMemberDescriptor
      {
        internal PROP_9ddd7aadc3a34ed08dc650f209fd976a()
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

      private sealed class PROP_81a7f4420c854c2a8d30b46152c0bc5e : HardwiredMemberDescriptor
      {
        internal PROP_81a7f4420c854c2a8d30b46152c0bc5e()
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

      private sealed class PROP_52690e00f8464e259e5a8cc07a103cac : HardwiredMemberDescriptor
      {
        internal PROP_52690e00f8464e259e5a8cc07a103cac()
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

      private sealed class PROP_8f54877521ec4dde84625c8cefc96bc1 : HardwiredMemberDescriptor
      {
        internal PROP_8f54877521ec4dde84625c8cefc96bc1()
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

      private sealed class PROP_612ce1f19a5740fdb0a022a1f9377e48 : HardwiredMemberDescriptor
      {
        internal PROP_612ce1f19a5740fdb0a022a1f9377e48()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_48b08d0184964bbda92bfe25020c7f34 : HardwiredMemberDescriptor
      {
        internal PROP_48b08d0184964bbda92bfe25020c7f34()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_ef5a6a54c3a346e88e00628f5f6ee450 : HardwiredMemberDescriptor
      {
        internal PROP_ef5a6a54c3a346e88e00628f5f6ee450()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_212c23fa6e65448f9153864f49110a2f : HardwiredMemberDescriptor
      {
        internal PROP_212c23fa6e65448f9153864f49110a2f()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_0bf0fbe4cca94c348f1a4d7416a6e3e6 : HardwiredMemberDescriptor
      {
        internal PROP_0bf0fbe4cca94c348f1a4d7416a6e3e6()
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

      private sealed class PROP_465435b49c694ad0aad3eb72b1a9f4c0 : HardwiredMemberDescriptor
      {
        internal PROP_465435b49c694ad0aad3eb72b1a9f4c0()
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

      private sealed class PROP_67a0bbcf073a4e3fb135ae34f3014ccf : HardwiredMemberDescriptor
      {
        internal PROP_67a0bbcf073a4e3fb135ae34f3014ccf()
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

      private sealed class PROP_6e6db2a510d4439a8cae7b92a7cf3ff7 : HardwiredMemberDescriptor
      {
        internal PROP_6e6db2a510d4439a8cae7b92a7cf3ff7()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_c7bcc9d995a8452c8a9f578f14bec20b : HardwiredMemberDescriptor
      {
        internal PROP_c7bcc9d995a8452c8a9f578f14bec20b()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_537e49d1134340c2a23e1ed46e794d5f : HardwiredMemberDescriptor
      {
        internal PROP_537e49d1134340c2a23e1ed46e794d5f()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_992947ecae8a496eaf3a73a022b34bcf : HardwiredUserDataDescriptor
    {
      internal TYPE_992947ecae8a496eaf3a73a022b34bcf()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_992947ecae8a496eaf3a73a022b34bcf.MTHD_33ee93b9e39a4078a5fdbd732fdfe9b0()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_992947ecae8a496eaf3a73a022b34bcf.MTHD_eab642fe414b479d83162b225173fe06()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_992947ecae8a496eaf3a73a022b34bcf.MTHD_5477b3351542465bb35b08676f7029cb()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_992947ecae8a496eaf3a73a022b34bcf.MTHD_7c069579cee3473ab7b2430879f8a3e5()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_992947ecae8a496eaf3a73a022b34bcf.MTHD_886ec24fc97f4f3dbfd1501044dd558a()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_992947ecae8a496eaf3a73a022b34bcf.MTHD_1d5feef759b54344be94b6d99aaa8b3a()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_992947ecae8a496eaf3a73a022b34bcf.MTHD_dddffa858d194f7cb9a13475e05f2fff()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_992947ecae8a496eaf3a73a022b34bcf.MTHD_c9144b2b6ea347049680aeb7f25c65a0()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_992947ecae8a496eaf3a73a022b34bcf.MTHD_aeb81befcf1d4d7abcb63778ac5121e3()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_992947ecae8a496eaf3a73a022b34bcf.MTHD_780e5e0db286448aa0dc36b2e4f7f4e5()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_992947ecae8a496eaf3a73a022b34bcf.MTHD_1f59f23b2a4040688383ac55a171ef33()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_992947ecae8a496eaf3a73a022b34bcf.MTHD_575471659adf4af391a47ec07309ae96()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_992947ecae8a496eaf3a73a022b34bcf.PROP_12ea04c249214dc0b16ca82601ca9abc());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_992947ecae8a496eaf3a73a022b34bcf.PROP_6feb616c41aa470eae283ca3deceebf3());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_992947ecae8a496eaf3a73a022b34bcf.PROP_d4f2430a42de4b4c99baff36ae0e8322());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_992947ecae8a496eaf3a73a022b34bcf.PROP_170a45aa70704aa391caacd0c46897b1());
      }

      private sealed class MTHD_33ee93b9e39a4078a5fdbd732fdfe9b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_33ee93b9e39a4078a5fdbd732fdfe9b0()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_eab642fe414b479d83162b225173fe06 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eab642fe414b479d83162b225173fe06()
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

      private sealed class MTHD_5477b3351542465bb35b08676f7029cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5477b3351542465bb35b08676f7029cb()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_7c069579cee3473ab7b2430879f8a3e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7c069579cee3473ab7b2430879f8a3e5()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_886ec24fc97f4f3dbfd1501044dd558a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_886ec24fc97f4f3dbfd1501044dd558a()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_1d5feef759b54344be94b6d99aaa8b3a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d5feef759b54344be94b6d99aaa8b3a()
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

      private sealed class MTHD_dddffa858d194f7cb9a13475e05f2fff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dddffa858d194f7cb9a13475e05f2fff()
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

      private sealed class MTHD_c9144b2b6ea347049680aeb7f25c65a0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c9144b2b6ea347049680aeb7f25c65a0()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_aeb81befcf1d4d7abcb63778ac5121e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aeb81befcf1d4d7abcb63778ac5121e3()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_780e5e0db286448aa0dc36b2e4f7f4e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_780e5e0db286448aa0dc36b2e4f7f4e5()
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

      private sealed class MTHD_1f59f23b2a4040688383ac55a171ef33 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f59f23b2a4040688383ac55a171ef33()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_575471659adf4af391a47ec07309ae96 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_575471659adf4af391a47ec07309ae96()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_12ea04c249214dc0b16ca82601ca9abc : HardwiredMemberDescriptor
      {
        internal PROP_12ea04c249214dc0b16ca82601ca9abc()
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

      private sealed class PROP_6feb616c41aa470eae283ca3deceebf3 : HardwiredMemberDescriptor
      {
        internal PROP_6feb616c41aa470eae283ca3deceebf3()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_d4f2430a42de4b4c99baff36ae0e8322 : HardwiredMemberDescriptor
      {
        internal PROP_d4f2430a42de4b4c99baff36ae0e8322()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_170a45aa70704aa391caacd0c46897b1 : HardwiredMemberDescriptor
      {
        internal PROP_170a45aa70704aa391caacd0c46897b1()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_c9e3db78f5d64368b8b223e9400164c3 : HardwiredUserDataDescriptor
    {
      internal TYPE_c9e3db78f5d64368b8b223e9400164c3()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_5dfc327776b24e6b9728e225af83f546()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_7b0a3a4367f148fdbece9dfcd0e68d80()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_0dd5d631b5b94f85a314741ef6c458d1()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_7e68ed2b22c1474d82ef9951c68c75f9()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_730eecd6ceb841259f646306fbaa3e5c()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_628b784385e84a0a9ebb65c65c004ed7()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_4012f2993bd54c2493c0f226089c1b41()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_e193a1db1dc240dd948cfeb766604f61()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_14a5bd8fd558494a8f17362c92044358()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_0a815a08aa2443f191be8d14ba3a71ce()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_e00060f3744e4febaf68e2f707e8b1c6()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_6f3b9f580a0f4464b676016482098ac7()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_b77bad77fd3d43539a4089ad1a235c6c()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_ce6136268b5447d3b47dffee862c4cd7()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_d6093c57b78f49a9a3d175e782ee41ea()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_9517fc01fafe42009f65f5c44c8ffabd()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_08e3d32e6e2642ff98d7e4ea48f19ff0()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_a6a5b7c490944af08a8dcef56b30b8c4()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_9653c40daa984430b115baf2d00df993()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_ad05872b600749fb878f8d5d3043751c()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_2bdaac24802841b99a8e3121ebb24346()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_71bc1b41319e4c37a6fc6d3f613cc4da()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_5dbc59d8898442968b87a584bf90b88f()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_ad976444b41740548bc1d1db5ee6bfa3()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_d975850a67d441e9b9da3fc63a018b61()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_6219bff2596a453abb1f51201bd28982()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_1642111827084e9a9a31aacb16493687()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_45d9271a42e741a6943d10fd1829ef6f()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_584c3bdab84f422a87d6dce7bce4157f()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_453e6f468d2b4b3389c33d0d921ee388()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_67765c24377b4afcba9f783bc28e83ae()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_a06c93dc8d1a4b51b388d79dbb498f28()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_7932339aaf5e498e80fad17ffdd2a818()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_227936aeb2d046afa51b6db236783b0e()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_95ca20ed5ec34a8083894f896a508ef5()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_01f8a943834248dabb6e9e10b29332c5()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_f890949116934c49907fc1bca14d1a57()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_fa017ad87b0040969e7ed36338efd953()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_738aa5e50d294f928571b00f2d4a6b25()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_71a7eafe717f44e98a2f24d53af4173d()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_d51436bf853b4bbdbd577dbf13482669()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_de66660976284459866f8393fd9e9b10()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_78876f82a4e64840b5b265a96387795a()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_444e8d664602406ab5b35eab5cb63903()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_88137965e5d041048f093f476f280d32()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_28ef36bdd2094bca96b7a54097fd8b61()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_4e03f8726f324858b2b5fe472fae13a6()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_d2e32a5316574ad1b1d560f3ba3b2790()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_9926aacf3c684001989f7d0dbc55de56()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_75535ba6e7c043e08f418cb99e3bfced()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_df99bc14df094419b79b2de395eaf9c6()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_0da7f88a6f4c4740808870b4ca95b0bf()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_17840a18a6a54c7e8513f805365d8c58()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_23b507487454461bae8831b28dd38d34()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_6ff0eb9829224e158172016bd6e8a81c()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_acfe9656e92046beb1c0b59b07f55bdf()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_45a96978e6c54d3b82573ed4496009b0()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_fec9bea0305e4027a1677296d806abcb()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_5ea31ff2c17547d7a04b49a27f22dc5b()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_ae5952204ad14afe811bd054b3fcebb7()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_7cf5b01db09c404bbd601bc427499eb3()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_2660319c1db04ccea37299bb24c20328()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_9154f4d56d8b40058dcd5077904487c5()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_cfb817f08f7048e089ce8290627c23c3(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_852e6e1f97d04f0f82fc99ac6c20914a()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_461af706c110476e8a0fcd59df12ec98(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_826444c6dd5b44fa8daf9e3586a1f76f()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_ee2fb24ebcb24c80b3152af111e766b3()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_dca72ebfa4b8470285c327dc982de3e5()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_bbca182efbc5476fbc3311dca2462fd9(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_f4f0d692e4b74602bd818efa64cb44e1()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_1bef2892931d48bcb378fb62af5b93ba()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_a1d82e16c959479d8cfda3d64d872270()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_242d7cbb508748af91dad3e81b17efb3()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_d67555a5a05b4d809b329121bd11ad3b()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_71176cfd7ad24925b651ce8dbf25a896()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_292eb1cc6e494243acff6e6a1ee9b7f4()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_10b84efd087c4b9cb7a5e2756ab5d61c()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_c3470b5c333548f198e0fc3819217c39()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_fbfa3e66202546c9bcea16e502ddc6ea(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_028cde4b51c54b3caee66c6f53ab5cf5()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_2965d3e0a0e8491db322ef68b8e31cdc(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_32b68b0ac262475884b6023e611a3d1c()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_a39af06d5cef4561820cb5eb646e6eda()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_6af339a3f1cb4f548bb3a4734c3e50b4()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_73217f35797640debe58b793cbcd906b()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_9db6ff5711484e9abd10d6b1bd207855()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_f5a7ce7177554b738a82b3348405f01a()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.MTHD_cc339aeed546497896bc8a95809c78a1()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_231178626bb448f1a62125d22f130e35());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_227c12639e154193a46b8e18671ed0a3());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_83b70f590bde4b0ca8713e2c6a61fdf9());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_8fae7fef2e0a4effbe68345fdbc1da0e());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_7842027279254a0f94596d226840ceff());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_49c46f3026fe46b0a49c8671898b7cbe());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_c2eca18973864388b2232879681c1260());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_3b025cde05d64c7db5a0cba99690e639());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_74fafca40db545a784d72bde32c8de75());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_a2819a35b7e049e8a9e486ae77a5f311());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_d219153a031d40bda2325477b11f8a36());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_10363d512af94c1ca070cc2816fc719f());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_8d017cabcc084d4394084de6dbb6aa61());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_fa4d30ccc3344e47a7197b33894288f8());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_11de10cd35ec436fadec047b8af124bf());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_4586e9ffa479487dafb45159c675a0d7());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_3d948416bd6342a397b2d9024f3f846e());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_57f4ab9459844a80b598deecf8edc7a6());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_baba3b10b26e46609b5f33512a2e6fe7());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_2afaa6465f134403a27137063eae9e55());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_e6e68093fd4f4cfb9271b303944d51f3());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_6bee13d474314ee482879f07e2f7e451());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_2ccb2fde29834ac39ae48dd2f5271dec());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_f7055369855c4724b7df6f2c1487d943());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_9c2233ab44b64e84b4ef12ac8e44e3d4());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_a9aab7fa0a934c03a5e09918f3fd507c());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_50d5c7a624754d149d5aecbf66cec406());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_22011d9c5f004ea394aef7996106308d());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_98ae78d83cf54a5d96bcaad69f570c36());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_5c49a39390894e6ea0f1e702623bf158());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_7e2d85ecad1c43138fadadb87aecdfcf());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_e3dcc24b85234da0b2cc556948237819());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_c9e3db78f5d64368b8b223e9400164c3.PROP_2a6da6ca13b1442092d4ef05c3f850a5());
      }

      private sealed class MTHD_5dfc327776b24e6b9728e225af83f546 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5dfc327776b24e6b9728e225af83f546()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_7b0a3a4367f148fdbece9dfcd0e68d80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b0a3a4367f148fdbece9dfcd0e68d80()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_0dd5d631b5b94f85a314741ef6c458d1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0dd5d631b5b94f85a314741ef6c458d1()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_7e68ed2b22c1474d82ef9951c68c75f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7e68ed2b22c1474d82ef9951c68c75f9()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_730eecd6ceb841259f646306fbaa3e5c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_730eecd6ceb841259f646306fbaa3e5c()
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

      private sealed class MTHD_628b784385e84a0a9ebb65c65c004ed7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_628b784385e84a0a9ebb65c65c004ed7()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_4012f2993bd54c2493c0f226089c1b41 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4012f2993bd54c2493c0f226089c1b41()
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

      private sealed class MTHD_e193a1db1dc240dd948cfeb766604f61 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e193a1db1dc240dd948cfeb766604f61()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_14a5bd8fd558494a8f17362c92044358 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_14a5bd8fd558494a8f17362c92044358()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_0a815a08aa2443f191be8d14ba3a71ce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0a815a08aa2443f191be8d14ba3a71ce()
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

      private sealed class MTHD_e00060f3744e4febaf68e2f707e8b1c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e00060f3744e4febaf68e2f707e8b1c6()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_6f3b9f580a0f4464b676016482098ac7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6f3b9f580a0f4464b676016482098ac7()
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

      private sealed class MTHD_b77bad77fd3d43539a4089ad1a235c6c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b77bad77fd3d43539a4089ad1a235c6c()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_ce6136268b5447d3b47dffee862c4cd7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ce6136268b5447d3b47dffee862c4cd7()
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

      private sealed class MTHD_d6093c57b78f49a9a3d175e782ee41ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6093c57b78f49a9a3d175e782ee41ea()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_9517fc01fafe42009f65f5c44c8ffabd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9517fc01fafe42009f65f5c44c8ffabd()
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

      private sealed class MTHD_08e3d32e6e2642ff98d7e4ea48f19ff0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_08e3d32e6e2642ff98d7e4ea48f19ff0()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_a6a5b7c490944af08a8dcef56b30b8c4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6a5b7c490944af08a8dcef56b30b8c4()
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

      private sealed class MTHD_9653c40daa984430b115baf2d00df993 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9653c40daa984430b115baf2d00df993()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_ad05872b600749fb878f8d5d3043751c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ad05872b600749fb878f8d5d3043751c()
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

      private sealed class MTHD_2bdaac24802841b99a8e3121ebb24346 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2bdaac24802841b99a8e3121ebb24346()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_71bc1b41319e4c37a6fc6d3f613cc4da : HardwiredMethodMemberDescriptor
      {
        internal MTHD_71bc1b41319e4c37a6fc6d3f613cc4da()
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

      private sealed class MTHD_5dbc59d8898442968b87a584bf90b88f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5dbc59d8898442968b87a584bf90b88f()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_ad976444b41740548bc1d1db5ee6bfa3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ad976444b41740548bc1d1db5ee6bfa3()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_d975850a67d441e9b9da3fc63a018b61 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d975850a67d441e9b9da3fc63a018b61()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_6219bff2596a453abb1f51201bd28982 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6219bff2596a453abb1f51201bd28982()
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

      private sealed class MTHD_1642111827084e9a9a31aacb16493687 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1642111827084e9a9a31aacb16493687()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_45d9271a42e741a6943d10fd1829ef6f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_45d9271a42e741a6943d10fd1829ef6f()
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

      private sealed class MTHD_584c3bdab84f422a87d6dce7bce4157f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_584c3bdab84f422a87d6dce7bce4157f()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_453e6f468d2b4b3389c33d0d921ee388 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_453e6f468d2b4b3389c33d0d921ee388()
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

      private sealed class MTHD_67765c24377b4afcba9f783bc28e83ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67765c24377b4afcba9f783bc28e83ae()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_a06c93dc8d1a4b51b388d79dbb498f28 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a06c93dc8d1a4b51b388d79dbb498f28()
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

      private sealed class MTHD_7932339aaf5e498e80fad17ffdd2a818 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7932339aaf5e498e80fad17ffdd2a818()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_227936aeb2d046afa51b6db236783b0e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_227936aeb2d046afa51b6db236783b0e()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_95ca20ed5ec34a8083894f896a508ef5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95ca20ed5ec34a8083894f896a508ef5()
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

      private sealed class MTHD_01f8a943834248dabb6e9e10b29332c5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_01f8a943834248dabb6e9e10b29332c5()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_f890949116934c49907fc1bca14d1a57 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f890949116934c49907fc1bca14d1a57()
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

      private sealed class MTHD_fa017ad87b0040969e7ed36338efd953 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa017ad87b0040969e7ed36338efd953()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_738aa5e50d294f928571b00f2d4a6b25 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_738aa5e50d294f928571b00f2d4a6b25()
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

      private sealed class MTHD_71a7eafe717f44e98a2f24d53af4173d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_71a7eafe717f44e98a2f24d53af4173d()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_d51436bf853b4bbdbd577dbf13482669 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d51436bf853b4bbdbd577dbf13482669()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_de66660976284459866f8393fd9e9b10 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de66660976284459866f8393fd9e9b10()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_78876f82a4e64840b5b265a96387795a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_78876f82a4e64840b5b265a96387795a()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_444e8d664602406ab5b35eab5cb63903 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_444e8d664602406ab5b35eab5cb63903()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_88137965e5d041048f093f476f280d32 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_88137965e5d041048f093f476f280d32()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_28ef36bdd2094bca96b7a54097fd8b61 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_28ef36bdd2094bca96b7a54097fd8b61()
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

      private sealed class MTHD_4e03f8726f324858b2b5fe472fae13a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e03f8726f324858b2b5fe472fae13a6()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_d2e32a5316574ad1b1d560f3ba3b2790 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d2e32a5316574ad1b1d560f3ba3b2790()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_9926aacf3c684001989f7d0dbc55de56 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9926aacf3c684001989f7d0dbc55de56()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_75535ba6e7c043e08f418cb99e3bfced : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75535ba6e7c043e08f418cb99e3bfced()
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

      private sealed class MTHD_df99bc14df094419b79b2de395eaf9c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_df99bc14df094419b79b2de395eaf9c6()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_0da7f88a6f4c4740808870b4ca95b0bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0da7f88a6f4c4740808870b4ca95b0bf()
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

      private sealed class MTHD_17840a18a6a54c7e8513f805365d8c58 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_17840a18a6a54c7e8513f805365d8c58()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_23b507487454461bae8831b28dd38d34 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_23b507487454461bae8831b28dd38d34()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_6ff0eb9829224e158172016bd6e8a81c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ff0eb9829224e158172016bd6e8a81c()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_acfe9656e92046beb1c0b59b07f55bdf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_acfe9656e92046beb1c0b59b07f55bdf()
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

      private sealed class MTHD_45a96978e6c54d3b82573ed4496009b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_45a96978e6c54d3b82573ed4496009b0()
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

      private sealed class MTHD_fec9bea0305e4027a1677296d806abcb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fec9bea0305e4027a1677296d806abcb()
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

      private sealed class MTHD_5ea31ff2c17547d7a04b49a27f22dc5b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ea31ff2c17547d7a04b49a27f22dc5b()
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

      private sealed class MTHD_ae5952204ad14afe811bd054b3fcebb7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae5952204ad14afe811bd054b3fcebb7()
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

      private sealed class MTHD_7cf5b01db09c404bbd601bc427499eb3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7cf5b01db09c404bbd601bc427499eb3()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_2660319c1db04ccea37299bb24c20328 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2660319c1db04ccea37299bb24c20328()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_9154f4d56d8b40058dcd5077904487c5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9154f4d56d8b40058dcd5077904487c5()
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

      private sealed class MTHD_cfb817f08f7048e089ce8290627c23c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cfb817f08f7048e089ce8290627c23c3()
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

      private sealed class MTHD_852e6e1f97d04f0f82fc99ac6c20914a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_852e6e1f97d04f0f82fc99ac6c20914a()
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

      private sealed class MTHD_461af706c110476e8a0fcd59df12ec98 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_461af706c110476e8a0fcd59df12ec98()
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

      private sealed class MTHD_826444c6dd5b44fa8daf9e3586a1f76f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_826444c6dd5b44fa8daf9e3586a1f76f()
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

      private sealed class MTHD_ee2fb24ebcb24c80b3152af111e766b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee2fb24ebcb24c80b3152af111e766b3()
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

      private sealed class MTHD_dca72ebfa4b8470285c327dc982de3e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dca72ebfa4b8470285c327dc982de3e5()
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

      private sealed class MTHD_bbca182efbc5476fbc3311dca2462fd9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bbca182efbc5476fbc3311dca2462fd9()
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

      private sealed class MTHD_f4f0d692e4b74602bd818efa64cb44e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4f0d692e4b74602bd818efa64cb44e1()
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

      private sealed class MTHD_1bef2892931d48bcb378fb62af5b93ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1bef2892931d48bcb378fb62af5b93ba()
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

      private sealed class MTHD_a1d82e16c959479d8cfda3d64d872270 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1d82e16c959479d8cfda3d64d872270()
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

      private sealed class MTHD_242d7cbb508748af91dad3e81b17efb3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_242d7cbb508748af91dad3e81b17efb3()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_d67555a5a05b4d809b329121bd11ad3b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d67555a5a05b4d809b329121bd11ad3b()
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

      private sealed class MTHD_71176cfd7ad24925b651ce8dbf25a896 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_71176cfd7ad24925b651ce8dbf25a896()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_292eb1cc6e494243acff6e6a1ee9b7f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_292eb1cc6e494243acff6e6a1ee9b7f4()
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

      private sealed class MTHD_10b84efd087c4b9cb7a5e2756ab5d61c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_10b84efd087c4b9cb7a5e2756ab5d61c()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_c3470b5c333548f198e0fc3819217c39 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c3470b5c333548f198e0fc3819217c39()
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

      private sealed class MTHD_fbfa3e66202546c9bcea16e502ddc6ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fbfa3e66202546c9bcea16e502ddc6ea()
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

      private sealed class MTHD_028cde4b51c54b3caee66c6f53ab5cf5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_028cde4b51c54b3caee66c6f53ab5cf5()
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

      private sealed class MTHD_2965d3e0a0e8491db322ef68b8e31cdc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2965d3e0a0e8491db322ef68b8e31cdc()
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

      private sealed class MTHD_32b68b0ac262475884b6023e611a3d1c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_32b68b0ac262475884b6023e611a3d1c()
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

      private sealed class MTHD_a39af06d5cef4561820cb5eb646e6eda : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a39af06d5cef4561820cb5eb646e6eda()
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

      private sealed class MTHD_6af339a3f1cb4f548bb3a4734c3e50b4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6af339a3f1cb4f548bb3a4734c3e50b4()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_73217f35797640debe58b793cbcd906b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_73217f35797640debe58b793cbcd906b()
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

      private sealed class MTHD_9db6ff5711484e9abd10d6b1bd207855 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9db6ff5711484e9abd10d6b1bd207855()
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

      private sealed class MTHD_f5a7ce7177554b738a82b3348405f01a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f5a7ce7177554b738a82b3348405f01a()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_cc339aeed546497896bc8a95809c78a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cc339aeed546497896bc8a95809c78a1()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_231178626bb448f1a62125d22f130e35 : HardwiredMemberDescriptor
      {
        internal PROP_231178626bb448f1a62125d22f130e35()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_227c12639e154193a46b8e18671ed0a3 : HardwiredMemberDescriptor
      {
        internal PROP_227c12639e154193a46b8e18671ed0a3()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_83b70f590bde4b0ca8713e2c6a61fdf9 : HardwiredMemberDescriptor
      {
        internal PROP_83b70f590bde4b0ca8713e2c6a61fdf9()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_8fae7fef2e0a4effbe68345fdbc1da0e : HardwiredMemberDescriptor
      {
        internal PROP_8fae7fef2e0a4effbe68345fdbc1da0e()
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

      private sealed class PROP_7842027279254a0f94596d226840ceff : HardwiredMemberDescriptor
      {
        internal PROP_7842027279254a0f94596d226840ceff()
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

      private sealed class PROP_49c46f3026fe46b0a49c8671898b7cbe : HardwiredMemberDescriptor
      {
        internal PROP_49c46f3026fe46b0a49c8671898b7cbe()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_c2eca18973864388b2232879681c1260 : HardwiredMemberDescriptor
      {
        internal PROP_c2eca18973864388b2232879681c1260()
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

      private sealed class PROP_3b025cde05d64c7db5a0cba99690e639 : HardwiredMemberDescriptor
      {
        internal PROP_3b025cde05d64c7db5a0cba99690e639()
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

      private sealed class PROP_74fafca40db545a784d72bde32c8de75 : HardwiredMemberDescriptor
      {
        internal PROP_74fafca40db545a784d72bde32c8de75()
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

      private sealed class PROP_a2819a35b7e049e8a9e486ae77a5f311 : HardwiredMemberDescriptor
      {
        internal PROP_a2819a35b7e049e8a9e486ae77a5f311()
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

      private sealed class PROP_d219153a031d40bda2325477b11f8a36 : HardwiredMemberDescriptor
      {
        internal PROP_d219153a031d40bda2325477b11f8a36()
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

      private sealed class PROP_10363d512af94c1ca070cc2816fc719f : HardwiredMemberDescriptor
      {
        internal PROP_10363d512af94c1ca070cc2816fc719f()
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

      private sealed class PROP_8d017cabcc084d4394084de6dbb6aa61 : HardwiredMemberDescriptor
      {
        internal PROP_8d017cabcc084d4394084de6dbb6aa61()
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

      private sealed class PROP_fa4d30ccc3344e47a7197b33894288f8 : HardwiredMemberDescriptor
      {
        internal PROP_fa4d30ccc3344e47a7197b33894288f8()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_11de10cd35ec436fadec047b8af124bf : HardwiredMemberDescriptor
      {
        internal PROP_11de10cd35ec436fadec047b8af124bf()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_4586e9ffa479487dafb45159c675a0d7 : HardwiredMemberDescriptor
      {
        internal PROP_4586e9ffa479487dafb45159c675a0d7()
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

      private sealed class PROP_3d948416bd6342a397b2d9024f3f846e : HardwiredMemberDescriptor
      {
        internal PROP_3d948416bd6342a397b2d9024f3f846e()
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

      private sealed class PROP_57f4ab9459844a80b598deecf8edc7a6 : HardwiredMemberDescriptor
      {
        internal PROP_57f4ab9459844a80b598deecf8edc7a6()
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

      private sealed class PROP_baba3b10b26e46609b5f33512a2e6fe7 : HardwiredMemberDescriptor
      {
        internal PROP_baba3b10b26e46609b5f33512a2e6fe7()
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

      private sealed class PROP_2afaa6465f134403a27137063eae9e55 : HardwiredMemberDescriptor
      {
        internal PROP_2afaa6465f134403a27137063eae9e55()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_e6e68093fd4f4cfb9271b303944d51f3 : HardwiredMemberDescriptor
      {
        internal PROP_e6e68093fd4f4cfb9271b303944d51f3()
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

      private sealed class PROP_6bee13d474314ee482879f07e2f7e451 : HardwiredMemberDescriptor
      {
        internal PROP_6bee13d474314ee482879f07e2f7e451()
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

      private sealed class PROP_2ccb2fde29834ac39ae48dd2f5271dec : HardwiredMemberDescriptor
      {
        internal PROP_2ccb2fde29834ac39ae48dd2f5271dec()
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

      private sealed class PROP_f7055369855c4724b7df6f2c1487d943 : HardwiredMemberDescriptor
      {
        internal PROP_f7055369855c4724b7df6f2c1487d943()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_9c2233ab44b64e84b4ef12ac8e44e3d4 : HardwiredMemberDescriptor
      {
        internal PROP_9c2233ab44b64e84b4ef12ac8e44e3d4()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_a9aab7fa0a934c03a5e09918f3fd507c : HardwiredMemberDescriptor
      {
        internal PROP_a9aab7fa0a934c03a5e09918f3fd507c()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_50d5c7a624754d149d5aecbf66cec406 : HardwiredMemberDescriptor
      {
        internal PROP_50d5c7a624754d149d5aecbf66cec406()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_22011d9c5f004ea394aef7996106308d : HardwiredMemberDescriptor
      {
        internal PROP_22011d9c5f004ea394aef7996106308d()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_98ae78d83cf54a5d96bcaad69f570c36 : HardwiredMemberDescriptor
      {
        internal PROP_98ae78d83cf54a5d96bcaad69f570c36()
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

      private sealed class PROP_5c49a39390894e6ea0f1e702623bf158 : HardwiredMemberDescriptor
      {
        internal PROP_5c49a39390894e6ea0f1e702623bf158()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_7e2d85ecad1c43138fadadb87aecdfcf : HardwiredMemberDescriptor
      {
        internal PROP_7e2d85ecad1c43138fadadb87aecdfcf()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_e3dcc24b85234da0b2cc556948237819 : HardwiredMemberDescriptor
      {
        internal PROP_e3dcc24b85234da0b2cc556948237819()
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

      private sealed class PROP_2a6da6ca13b1442092d4ef05c3f850a5 : HardwiredMemberDescriptor
      {
        internal PROP_2a6da6ca13b1442092d4ef05c3f850a5()
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

    private sealed class TYPE_b7913a64dc7a460c820e2e195d520ba6 : HardwiredUserDataDescriptor
    {
      internal TYPE_b7913a64dc7a460c820e2e195d520ba6()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.MTHD_00fc6ac45d194f12975169b81af0980d()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.MTHD_1d627f033f6f4c9396e35527555772cb()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.MTHD_24b14bd2baba4fa78a2ac9610ff5bda0()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.MTHD_dcbcfbe19263499eae5f8a4f37408825()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.MTHD_dd19f09a8b8e489baecd23c27f18220f()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.MTHD_fe438d0d439845f8917a285c465da189()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.MTHD_ae0426a48d6247ea8b4d9d4d372fe588()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.MTHD_10a0d2b05edf41898fd7bdb344b60f5f()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.MTHD_9fe597bb529a40609043f30f7ef042a6()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.MTHD_9f174e00ba384b14b8a95bc44a9a4102()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.MTHD_1864926b513b45529780e7079e7ba582()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.MTHD_8ec1fe229ccd4051b01557e6b7392e05()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.MTHD_2a264cca91194c8ab9ef42c09ee17e08()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.MTHD_4c29f61682b742088d5005f759821af3()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.MTHD_4d9dc776d71f42fb842de2eaf3e204c9()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.MTHD_0f645aa82d3f48f3805f3b909d5cb10a()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.MTHD_e1488ea9a9024cd580e843835b2362cb()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.MTHD_3fd670d83b7c46d08a0138d1c9ddf60b()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.MTHD_f3f9094c2e26408aab52caa0e4084ebe()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.MTHD_41fc81c2a5c541a08bb16d7f4f735f80()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.PROP_3199b1416cea40bd8826c17b81acd1ae());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.PROP_a093d35f8b1a48419b63c032b2171a1c());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.PROP_7d350d0e59594ad397e22f49cb5e1cfc());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.PROP_684b082baac947e6879b5480d1f5b317());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.PROP_4fbc2dbaf6e84b5e89995e1be74e7a66());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.PROP_1b1aa848959e467c89b6aa83fbc7ae5f());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.PROP_31ab9c96dda7452d91b18134d53e508e());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_b7913a64dc7a460c820e2e195d520ba6.PROP_a72bfb50b14840fc85c23ac7d76dcc22());
      }

      private sealed class MTHD_00fc6ac45d194f12975169b81af0980d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_00fc6ac45d194f12975169b81af0980d()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_1d627f033f6f4c9396e35527555772cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d627f033f6f4c9396e35527555772cb()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_24b14bd2baba4fa78a2ac9610ff5bda0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24b14bd2baba4fa78a2ac9610ff5bda0()
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

      private sealed class MTHD_dcbcfbe19263499eae5f8a4f37408825 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dcbcfbe19263499eae5f8a4f37408825()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_dd19f09a8b8e489baecd23c27f18220f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dd19f09a8b8e489baecd23c27f18220f()
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

      private sealed class MTHD_fe438d0d439845f8917a285c465da189 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fe438d0d439845f8917a285c465da189()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_ae0426a48d6247ea8b4d9d4d372fe588 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae0426a48d6247ea8b4d9d4d372fe588()
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

      private sealed class MTHD_10a0d2b05edf41898fd7bdb344b60f5f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_10a0d2b05edf41898fd7bdb344b60f5f()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_9fe597bb529a40609043f30f7ef042a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9fe597bb529a40609043f30f7ef042a6()
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

      private sealed class MTHD_9f174e00ba384b14b8a95bc44a9a4102 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f174e00ba384b14b8a95bc44a9a4102()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_1864926b513b45529780e7079e7ba582 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1864926b513b45529780e7079e7ba582()
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

      private sealed class MTHD_8ec1fe229ccd4051b01557e6b7392e05 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ec1fe229ccd4051b01557e6b7392e05()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_2a264cca91194c8ab9ef42c09ee17e08 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a264cca91194c8ab9ef42c09ee17e08()
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

      private sealed class MTHD_4c29f61682b742088d5005f759821af3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c29f61682b742088d5005f759821af3()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_4d9dc776d71f42fb842de2eaf3e204c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d9dc776d71f42fb842de2eaf3e204c9()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_0f645aa82d3f48f3805f3b909d5cb10a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f645aa82d3f48f3805f3b909d5cb10a()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_e1488ea9a9024cd580e843835b2362cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e1488ea9a9024cd580e843835b2362cb()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_3fd670d83b7c46d08a0138d1c9ddf60b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3fd670d83b7c46d08a0138d1c9ddf60b()
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

      private sealed class MTHD_f3f9094c2e26408aab52caa0e4084ebe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f3f9094c2e26408aab52caa0e4084ebe()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_41fc81c2a5c541a08bb16d7f4f735f80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41fc81c2a5c541a08bb16d7f4f735f80()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_3199b1416cea40bd8826c17b81acd1ae : HardwiredMemberDescriptor
      {
        internal PROP_3199b1416cea40bd8826c17b81acd1ae()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_a093d35f8b1a48419b63c032b2171a1c : HardwiredMemberDescriptor
      {
        internal PROP_a093d35f8b1a48419b63c032b2171a1c()
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

      private sealed class PROP_7d350d0e59594ad397e22f49cb5e1cfc : HardwiredMemberDescriptor
      {
        internal PROP_7d350d0e59594ad397e22f49cb5e1cfc()
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

      private sealed class PROP_684b082baac947e6879b5480d1f5b317 : HardwiredMemberDescriptor
      {
        internal PROP_684b082baac947e6879b5480d1f5b317()
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

      private sealed class PROP_4fbc2dbaf6e84b5e89995e1be74e7a66 : HardwiredMemberDescriptor
      {
        internal PROP_4fbc2dbaf6e84b5e89995e1be74e7a66()
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

      private sealed class PROP_1b1aa848959e467c89b6aa83fbc7ae5f : HardwiredMemberDescriptor
      {
        internal PROP_1b1aa848959e467c89b6aa83fbc7ae5f()
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

      private sealed class PROP_31ab9c96dda7452d91b18134d53e508e : HardwiredMemberDescriptor
      {
        internal PROP_31ab9c96dda7452d91b18134d53e508e()
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

      private sealed class PROP_a72bfb50b14840fc85c23ac7d76dcc22 : HardwiredMemberDescriptor
      {
        internal PROP_a72bfb50b14840fc85c23ac7d76dcc22()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8 : HardwiredUserDataDescriptor
    {
      internal TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.MTHD_1ca3100e52a14d9e9cadebea086c38f5()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.MTHD_ea4f313a2d104d999d6c6689bccded0b()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.MTHD_677b5210a8cb4ab4a7545aa3fbd3019f()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.MTHD_662d7733201a4b7cbc73577a5b44ff80()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.MTHD_b43ded72991e457f94684b3c578836b1()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.MTHD_f5694c64e3ef4b24aac218e533097bf1()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.MTHD_4066a05401774794a422a3d977b40160()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.MTHD_22a7d4644fb242b7a97c1045a32fcfed()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.MTHD_8591b8b1a6cd4b999fece7e39e7f8ba5()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.MTHD_c6d8be8001be4d2b84894c061b88458c()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.MTHD_5e92b8fe34b04fef9bf1b36eae6056a1()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.MTHD_27e13a773aae40c1a21d97f6b66edb36()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.MTHD_6cb25f92ee4e46688741f9ac6bb2d285()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.MTHD_f4361b2e4d264af6886208ecf5b7726a()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.MTHD_241b0240f5d34f54a5b3d2e2125cf8ba()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.MTHD_5b293d6fde7f4ad39515bb4570a13a9f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.MTHD_70b16761b4df47d8b3aa2c5614307bc6()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.MTHD_09e7ca70a3fb4ebcac9430862f05643b()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.MTHD_e7018e6689bd4da9a2d1d02022be593b()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.PROP_dfcfe5ab230048f5bdcc406196d117e9());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.PROP_30792fb6a990403ebd52e81bba8e9847());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.PROP_a6f6a0c7076e434bbd99d82e74026009());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.PROP_09e349af4187420a8770c1f0d3f94946());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.PROP_b94edf3288f64c1391e792ec8ff94c26());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.PROP_7915bf2b87e540648565b624fd2293f6());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.PROP_b27e8492677f4b56a3ae2433086fe427());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_a163ce06b3da4a52aa96dc7ac89d6cb8.PROP_5d8042b65a8543f08cd7d86b4a3524eb());
      }

      private sealed class MTHD_1ca3100e52a14d9e9cadebea086c38f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ca3100e52a14d9e9cadebea086c38f5()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_ea4f313a2d104d999d6c6689bccded0b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea4f313a2d104d999d6c6689bccded0b()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_677b5210a8cb4ab4a7545aa3fbd3019f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_677b5210a8cb4ab4a7545aa3fbd3019f()
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

      private sealed class MTHD_662d7733201a4b7cbc73577a5b44ff80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_662d7733201a4b7cbc73577a5b44ff80()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_b43ded72991e457f94684b3c578836b1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b43ded72991e457f94684b3c578836b1()
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

      private sealed class MTHD_f5694c64e3ef4b24aac218e533097bf1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f5694c64e3ef4b24aac218e533097bf1()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_4066a05401774794a422a3d977b40160 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4066a05401774794a422a3d977b40160()
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

      private sealed class MTHD_22a7d4644fb242b7a97c1045a32fcfed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22a7d4644fb242b7a97c1045a32fcfed()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_8591b8b1a6cd4b999fece7e39e7f8ba5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8591b8b1a6cd4b999fece7e39e7f8ba5()
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

      private sealed class MTHD_c6d8be8001be4d2b84894c061b88458c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c6d8be8001be4d2b84894c061b88458c()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_5e92b8fe34b04fef9bf1b36eae6056a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e92b8fe34b04fef9bf1b36eae6056a1()
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

      private sealed class MTHD_27e13a773aae40c1a21d97f6b66edb36 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_27e13a773aae40c1a21d97f6b66edb36()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_6cb25f92ee4e46688741f9ac6bb2d285 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6cb25f92ee4e46688741f9ac6bb2d285()
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

      private sealed class MTHD_f4361b2e4d264af6886208ecf5b7726a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4361b2e4d264af6886208ecf5b7726a()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_241b0240f5d34f54a5b3d2e2125cf8ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_241b0240f5d34f54a5b3d2e2125cf8ba()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_5b293d6fde7f4ad39515bb4570a13a9f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b293d6fde7f4ad39515bb4570a13a9f()
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

      private sealed class MTHD_70b16761b4df47d8b3aa2c5614307bc6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70b16761b4df47d8b3aa2c5614307bc6()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_09e7ca70a3fb4ebcac9430862f05643b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_09e7ca70a3fb4ebcac9430862f05643b()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_e7018e6689bd4da9a2d1d02022be593b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7018e6689bd4da9a2d1d02022be593b()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_dfcfe5ab230048f5bdcc406196d117e9 : HardwiredMemberDescriptor
      {
        internal PROP_dfcfe5ab230048f5bdcc406196d117e9()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_30792fb6a990403ebd52e81bba8e9847 : HardwiredMemberDescriptor
      {
        internal PROP_30792fb6a990403ebd52e81bba8e9847()
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

      private sealed class PROP_a6f6a0c7076e434bbd99d82e74026009 : HardwiredMemberDescriptor
      {
        internal PROP_a6f6a0c7076e434bbd99d82e74026009()
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

      private sealed class PROP_09e349af4187420a8770c1f0d3f94946 : HardwiredMemberDescriptor
      {
        internal PROP_09e349af4187420a8770c1f0d3f94946()
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

      private sealed class PROP_b94edf3288f64c1391e792ec8ff94c26 : HardwiredMemberDescriptor
      {
        internal PROP_b94edf3288f64c1391e792ec8ff94c26()
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

      private sealed class PROP_7915bf2b87e540648565b624fd2293f6 : HardwiredMemberDescriptor
      {
        internal PROP_7915bf2b87e540648565b624fd2293f6()
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

      private sealed class PROP_b27e8492677f4b56a3ae2433086fe427 : HardwiredMemberDescriptor
      {
        internal PROP_b27e8492677f4b56a3ae2433086fe427()
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

      private sealed class PROP_5d8042b65a8543f08cd7d86b4a3524eb : HardwiredMemberDescriptor
      {
        internal PROP_5d8042b65a8543f08cd7d86b4a3524eb()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_dd672499c0744d809e60a03a63bd6a3f : HardwiredUserDataDescriptor
    {
      internal TYPE_dd672499c0744d809e60a03a63bd6a3f()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_3e8b995f17844a86aedd27fdadc9b699()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_c2660015eb124a4193feb6dfe8c8c652()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_35fa5acaa23046c6b77f994c520c4ee5()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_00cec70fa3104e9ebf841b01ba7c5472()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_81ce1f8f85124c9a93e0a69ecd781d64()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_3ff796ba6b0b473f9ef3472d4172ca4d()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_d4c78245d17548799075f763eea94835()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_e67c009484914b5aba40d395e2a6188d()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_a83670ab624c4a59ab4816af92793244()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_0a745db677de494288beffabfb6d413a()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_55e39c832c694c279f8b15f32f202d5f()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_9f3b5dc5d239425abe68a1d615a25148()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_0fc75f01193942db9b90bd07d18c5a5e()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_ca0eff8bd3b648e4b306084fb2fb6a42()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_fa18134dc8cf4b9a97ca255943b00f6c()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_93002f0eea6d4ddc956af800855a383e()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_d51109f284b94ba9a1b1655ab402ed6c()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_8954eb77c5de4d06adb7ca6a33b5bd1f()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_348995dab2c44d839ec2ac68a5fe35d1()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_2b080d965c75412fb923b8b8b3f2db2b()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_5b917fa673cd48b9a315552bbce6783c()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_c95aae45e3b04746a8a7d43660910f58()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_b5d849c0a89c4f1ba83d9920a13ba051()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_4d0da7135e45413881f499c75b54d9e9()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_48208cc983c641989b2030b78a18a431()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_36b4a5117506442fb207a1ff2c000203()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_be6943bc0c154e9b9f40c12a8552afde()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.MTHD_6ae75611583b403991fb155fd66ee92b()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.PROP_2c4a82f7c8c84e5ea19c5a40de927ae3());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.PROP_cf92384ced86402293fca9ca77d486e8());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.PROP_9c5b7a89d6dd4f7597179f19cb906cf8());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.PROP_4c6ec0eba85045928d1a91b9529edea2());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.PROP_b9d7e299c7ec4d009fd383b626580ecf());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.PROP_2e60cfc883d1424fac24bd65f571154e());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.PROP_bfc2dd6245ec491190d1c52583736c3d());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.PROP_f77f815aea77447eb64f2b77279fda4a());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.PROP_4a0d6353c74a438ca7278515b4f595fb());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.PROP_95992e53a2bd4f249992eba878f209bc());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.PROP_93542383150c4bac87165a21978763be());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.PROP_c5d177b44f9a463c8afee35b67ad5fc9());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.PROP_926043abdfe64de88463ad733b3d923a());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.PROP_7cc4e76b35b94b729447fa8723881af4());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.PROP_e2693f9ff421462eaee852f0c3099210());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.PROP_bb3f20ccdfbb4f4eb7cfb2d52d84d751());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_dd672499c0744d809e60a03a63bd6a3f.PROP_50bc24c5cb174b68a0988c1b4a15084d());
      }

      private sealed class MTHD_3e8b995f17844a86aedd27fdadc9b699 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e8b995f17844a86aedd27fdadc9b699()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_c2660015eb124a4193feb6dfe8c8c652 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c2660015eb124a4193feb6dfe8c8c652()
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

      private sealed class MTHD_35fa5acaa23046c6b77f994c520c4ee5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35fa5acaa23046c6b77f994c520c4ee5()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_00cec70fa3104e9ebf841b01ba7c5472 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_00cec70fa3104e9ebf841b01ba7c5472()
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

      private sealed class MTHD_81ce1f8f85124c9a93e0a69ecd781d64 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_81ce1f8f85124c9a93e0a69ecd781d64()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_3ff796ba6b0b473f9ef3472d4172ca4d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3ff796ba6b0b473f9ef3472d4172ca4d()
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

      private sealed class MTHD_d4c78245d17548799075f763eea94835 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d4c78245d17548799075f763eea94835()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_e67c009484914b5aba40d395e2a6188d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e67c009484914b5aba40d395e2a6188d()
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

      private sealed class MTHD_a83670ab624c4a59ab4816af92793244 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a83670ab624c4a59ab4816af92793244()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_0a745db677de494288beffabfb6d413a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0a745db677de494288beffabfb6d413a()
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

      private sealed class MTHD_55e39c832c694c279f8b15f32f202d5f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_55e39c832c694c279f8b15f32f202d5f()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_9f3b5dc5d239425abe68a1d615a25148 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f3b5dc5d239425abe68a1d615a25148()
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

      private sealed class MTHD_0fc75f01193942db9b90bd07d18c5a5e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0fc75f01193942db9b90bd07d18c5a5e()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_ca0eff8bd3b648e4b306084fb2fb6a42 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ca0eff8bd3b648e4b306084fb2fb6a42()
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

      private sealed class MTHD_fa18134dc8cf4b9a97ca255943b00f6c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa18134dc8cf4b9a97ca255943b00f6c()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_93002f0eea6d4ddc956af800855a383e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93002f0eea6d4ddc956af800855a383e()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_d51109f284b94ba9a1b1655ab402ed6c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d51109f284b94ba9a1b1655ab402ed6c()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_8954eb77c5de4d06adb7ca6a33b5bd1f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8954eb77c5de4d06adb7ca6a33b5bd1f()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_348995dab2c44d839ec2ac68a5fe35d1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_348995dab2c44d839ec2ac68a5fe35d1()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_2b080d965c75412fb923b8b8b3f2db2b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b080d965c75412fb923b8b8b3f2db2b()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_5b917fa673cd48b9a315552bbce6783c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b917fa673cd48b9a315552bbce6783c()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_c95aae45e3b04746a8a7d43660910f58 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c95aae45e3b04746a8a7d43660910f58()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_b5d849c0a89c4f1ba83d9920a13ba051 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b5d849c0a89c4f1ba83d9920a13ba051()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_4d0da7135e45413881f499c75b54d9e9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d0da7135e45413881f499c75b54d9e9()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_48208cc983c641989b2030b78a18a431 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_48208cc983c641989b2030b78a18a431()
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

      private sealed class MTHD_36b4a5117506442fb207a1ff2c000203 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_36b4a5117506442fb207a1ff2c000203()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_be6943bc0c154e9b9f40c12a8552afde : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be6943bc0c154e9b9f40c12a8552afde()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_6ae75611583b403991fb155fd66ee92b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ae75611583b403991fb155fd66ee92b()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_2c4a82f7c8c84e5ea19c5a40de927ae3 : HardwiredMemberDescriptor
      {
        internal PROP_2c4a82f7c8c84e5ea19c5a40de927ae3()
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

      private sealed class PROP_cf92384ced86402293fca9ca77d486e8 : HardwiredMemberDescriptor
      {
        internal PROP_cf92384ced86402293fca9ca77d486e8()
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

      private sealed class PROP_9c5b7a89d6dd4f7597179f19cb906cf8 : HardwiredMemberDescriptor
      {
        internal PROP_9c5b7a89d6dd4f7597179f19cb906cf8()
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

      private sealed class PROP_4c6ec0eba85045928d1a91b9529edea2 : HardwiredMemberDescriptor
      {
        internal PROP_4c6ec0eba85045928d1a91b9529edea2()
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

      private sealed class PROP_b9d7e299c7ec4d009fd383b626580ecf : HardwiredMemberDescriptor
      {
        internal PROP_b9d7e299c7ec4d009fd383b626580ecf()
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

      private sealed class PROP_2e60cfc883d1424fac24bd65f571154e : HardwiredMemberDescriptor
      {
        internal PROP_2e60cfc883d1424fac24bd65f571154e()
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

      private sealed class PROP_bfc2dd6245ec491190d1c52583736c3d : HardwiredMemberDescriptor
      {
        internal PROP_bfc2dd6245ec491190d1c52583736c3d()
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

      private sealed class PROP_f77f815aea77447eb64f2b77279fda4a : HardwiredMemberDescriptor
      {
        internal PROP_f77f815aea77447eb64f2b77279fda4a()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_4a0d6353c74a438ca7278515b4f595fb : HardwiredMemberDescriptor
      {
        internal PROP_4a0d6353c74a438ca7278515b4f595fb()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_95992e53a2bd4f249992eba878f209bc : HardwiredMemberDescriptor
      {
        internal PROP_95992e53a2bd4f249992eba878f209bc()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_93542383150c4bac87165a21978763be : HardwiredMemberDescriptor
      {
        internal PROP_93542383150c4bac87165a21978763be()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_c5d177b44f9a463c8afee35b67ad5fc9 : HardwiredMemberDescriptor
      {
        internal PROP_c5d177b44f9a463c8afee35b67ad5fc9()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_926043abdfe64de88463ad733b3d923a : HardwiredMemberDescriptor
      {
        internal PROP_926043abdfe64de88463ad733b3d923a()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_7cc4e76b35b94b729447fa8723881af4 : HardwiredMemberDescriptor
      {
        internal PROP_7cc4e76b35b94b729447fa8723881af4()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_e2693f9ff421462eaee852f0c3099210 : HardwiredMemberDescriptor
      {
        internal PROP_e2693f9ff421462eaee852f0c3099210()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_bb3f20ccdfbb4f4eb7cfb2d52d84d751 : HardwiredMemberDescriptor
      {
        internal PROP_bb3f20ccdfbb4f4eb7cfb2d52d84d751()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_50bc24c5cb174b68a0988c1b4a15084d : HardwiredMemberDescriptor
      {
        internal PROP_50bc24c5cb174b68a0988c1b4a15084d()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_ef15c76fc75b48b797e33ed105e2b106 : HardwiredUserDataDescriptor
    {
      internal TYPE_ef15c76fc75b48b797e33ed105e2b106()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ef15c76fc75b48b797e33ed105e2b106.MTHD_10e2e5d0113f446983d67ac9f2898277()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ef15c76fc75b48b797e33ed105e2b106.MTHD_1099155565474a4387feb65fd49c8159()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ef15c76fc75b48b797e33ed105e2b106.MTHD_3947a990cf364ce39aa21c12f95b770d()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ef15c76fc75b48b797e33ed105e2b106.MTHD_381a5f9161ad4a64b1c27eb8ed0c7dce()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ef15c76fc75b48b797e33ed105e2b106.MTHD_b79dc45638874542853a2055a2793a5c()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ef15c76fc75b48b797e33ed105e2b106.MTHD_8b6339e89c8444b49eea85988a9b64aa()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ef15c76fc75b48b797e33ed105e2b106.MTHD_4b162f7f79f64c7e9459af728b971a04()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ef15c76fc75b48b797e33ed105e2b106.MTHD_071c0e8a8a9349d78724019093b0a7bb()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ef15c76fc75b48b797e33ed105e2b106.MTHD_92abd4e00f94446199752770141cdac4()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ef15c76fc75b48b797e33ed105e2b106.MTHD_9838773442a14aaf87bae8d0ce6803dd()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ef15c76fc75b48b797e33ed105e2b106.MTHD_ec0f0746967847a982f0d1d48070f6ed()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ef15c76fc75b48b797e33ed105e2b106.MTHD_d1b655cef5f34c498195243e27fedfba()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ef15c76fc75b48b797e33ed105e2b106.MTHD_378ff51494584a39b3ae376f80a19ed3()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ef15c76fc75b48b797e33ed105e2b106.MTHD_1100f18dfff54d0ab245862d92d051be()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ef15c76fc75b48b797e33ed105e2b106.MTHD_e3de11cec23345d7ab1c3e4ba10cc87f()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ef15c76fc75b48b797e33ed105e2b106.MTHD_9b6ed8b81f384b60bc8ae8c962b27fd5()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ef15c76fc75b48b797e33ed105e2b106.MTHD_30d40e8793124179895fb5e06072604d()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_ef15c76fc75b48b797e33ed105e2b106.PROP_4f86c447f1c042f0ad4f2650b460308e());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_ef15c76fc75b48b797e33ed105e2b106.PROP_9429ad44abce4e8bbddf8a0277b0901f());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_ef15c76fc75b48b797e33ed105e2b106.PROP_b5915b72f351407e8d26acb85cee4ee3());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_ef15c76fc75b48b797e33ed105e2b106.PROP_8fb378e36a2549409d0325e58bd7a907());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_ef15c76fc75b48b797e33ed105e2b106.PROP_05184b8a271a43a984ea0127889399e5());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_ef15c76fc75b48b797e33ed105e2b106.PROP_6418ca2932f4441db27f75fd75408e3e());
      }

      private sealed class MTHD_10e2e5d0113f446983d67ac9f2898277 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_10e2e5d0113f446983d67ac9f2898277()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_1099155565474a4387feb65fd49c8159 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1099155565474a4387feb65fd49c8159()
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

      private sealed class MTHD_3947a990cf364ce39aa21c12f95b770d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3947a990cf364ce39aa21c12f95b770d()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_381a5f9161ad4a64b1c27eb8ed0c7dce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_381a5f9161ad4a64b1c27eb8ed0c7dce()
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

      private sealed class MTHD_b79dc45638874542853a2055a2793a5c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b79dc45638874542853a2055a2793a5c()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_8b6339e89c8444b49eea85988a9b64aa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b6339e89c8444b49eea85988a9b64aa()
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

      private sealed class MTHD_4b162f7f79f64c7e9459af728b971a04 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b162f7f79f64c7e9459af728b971a04()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_071c0e8a8a9349d78724019093b0a7bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_071c0e8a8a9349d78724019093b0a7bb()
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

      private sealed class MTHD_92abd4e00f94446199752770141cdac4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_92abd4e00f94446199752770141cdac4()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_9838773442a14aaf87bae8d0ce6803dd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9838773442a14aaf87bae8d0ce6803dd()
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

      private sealed class MTHD_ec0f0746967847a982f0d1d48070f6ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec0f0746967847a982f0d1d48070f6ed()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_d1b655cef5f34c498195243e27fedfba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1b655cef5f34c498195243e27fedfba()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_378ff51494584a39b3ae376f80a19ed3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_378ff51494584a39b3ae376f80a19ed3()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_1100f18dfff54d0ab245862d92d051be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1100f18dfff54d0ab245862d92d051be()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_e3de11cec23345d7ab1c3e4ba10cc87f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e3de11cec23345d7ab1c3e4ba10cc87f()
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

      private sealed class MTHD_9b6ed8b81f384b60bc8ae8c962b27fd5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b6ed8b81f384b60bc8ae8c962b27fd5()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_30d40e8793124179895fb5e06072604d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_30d40e8793124179895fb5e06072604d()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_4f86c447f1c042f0ad4f2650b460308e : HardwiredMemberDescriptor
      {
        internal PROP_4f86c447f1c042f0ad4f2650b460308e()
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

      private sealed class PROP_9429ad44abce4e8bbddf8a0277b0901f : HardwiredMemberDescriptor
      {
        internal PROP_9429ad44abce4e8bbddf8a0277b0901f()
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

      private sealed class PROP_b5915b72f351407e8d26acb85cee4ee3 : HardwiredMemberDescriptor
      {
        internal PROP_b5915b72f351407e8d26acb85cee4ee3()
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

      private sealed class PROP_8fb378e36a2549409d0325e58bd7a907 : HardwiredMemberDescriptor
      {
        internal PROP_8fb378e36a2549409d0325e58bd7a907()
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

      private sealed class PROP_05184b8a271a43a984ea0127889399e5 : HardwiredMemberDescriptor
      {
        internal PROP_05184b8a271a43a984ea0127889399e5()
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

      private sealed class PROP_6418ca2932f4441db27f75fd75408e3e : HardwiredMemberDescriptor
      {
        internal PROP_6418ca2932f4441db27f75fd75408e3e()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_0998032d752044c78f0ba12bfce50d1d : HardwiredUserDataDescriptor
    {
      internal TYPE_0998032d752044c78f0ba12bfce50d1d()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0998032d752044c78f0ba12bfce50d1d.MTHD_81621ceaabdf40e5822d63e813e23a51(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0998032d752044c78f0ba12bfce50d1d.MTHD_cb7f3adcd0014af8b9e41b1ed444ef4d()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0998032d752044c78f0ba12bfce50d1d.MTHD_4cae026acfef45cca6dd1636c2fdac37(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0998032d752044c78f0ba12bfce50d1d.MTHD_dba3f1a9e9b5427591dafb941c256e6a()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0998032d752044c78f0ba12bfce50d1d.MTHD_3dc7b34d8da34def8613747690b5ae4b()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0998032d752044c78f0ba12bfce50d1d.MTHD_5fee6dfe8af8446486ae91bc52934671()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0998032d752044c78f0ba12bfce50d1d.MTHD_b9d65a5cf76d41cd99580fe3408605f1()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0998032d752044c78f0ba12bfce50d1d.MTHD_a656f562fdb14b48ac6139598f57c995()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0998032d752044c78f0ba12bfce50d1d.MTHD_0e6a747f1d334f1cb6abbb380a5abda7()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0998032d752044c78f0ba12bfce50d1d.MTHD_e9e2b37364744d5ba4de6a05bbb0393d()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0998032d752044c78f0ba12bfce50d1d.MTHD_7efe19c67d654b23a62314b09732ef02()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0998032d752044c78f0ba12bfce50d1d.MTHD_a09c89f822574c9da66af4b7f92a7aab(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0998032d752044c78f0ba12bfce50d1d.MTHD_4a72d2cdee3f4d418605df305a974453()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0998032d752044c78f0ba12bfce50d1d.MTHD_b26d3b64037f483a8a18a0d8aa1a539a(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0998032d752044c78f0ba12bfce50d1d.MTHD_d554069f172e4c52b6a7d3d924e73550()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0998032d752044c78f0ba12bfce50d1d.MTHD_dcebf0bc20524a30a6dd8ed8e0b67025(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0998032d752044c78f0ba12bfce50d1d.MTHD_878818fba5be4a188b14848124835e25()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0998032d752044c78f0ba12bfce50d1d.MTHD_dddfe066adc141068935ce3dd48159d5(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0998032d752044c78f0ba12bfce50d1d.MTHD_cbfdb81d000a4097a22490152cd310d9()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0998032d752044c78f0ba12bfce50d1d.MTHD_d7b4e28db7b941518acad938046d4e5d(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0998032d752044c78f0ba12bfce50d1d.MTHD_1944144c323644ad9f47583309c36adc()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0998032d752044c78f0ba12bfce50d1d.MTHD_f8b4080666e54735b72a3cfc8bf968f7()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0998032d752044c78f0ba12bfce50d1d.MTHD_7615740d2464430885fffdd590467e3e()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_0998032d752044c78f0ba12bfce50d1d.FLDV_f4aee4a2db6f46d0b4d9edbe0133d0d9());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_0998032d752044c78f0ba12bfce50d1d.FLDV_89cff59de21d42aa9765253fb42e98d6());
      }

      private sealed class MTHD_81621ceaabdf40e5822d63e813e23a51 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_81621ceaabdf40e5822d63e813e23a51()
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

      private sealed class MTHD_cb7f3adcd0014af8b9e41b1ed444ef4d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cb7f3adcd0014af8b9e41b1ed444ef4d()
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

      private sealed class MTHD_4cae026acfef45cca6dd1636c2fdac37 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4cae026acfef45cca6dd1636c2fdac37()
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

      private sealed class MTHD_dba3f1a9e9b5427591dafb941c256e6a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dba3f1a9e9b5427591dafb941c256e6a()
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

      private sealed class MTHD_3dc7b34d8da34def8613747690b5ae4b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3dc7b34d8da34def8613747690b5ae4b()
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

      private sealed class MTHD_5fee6dfe8af8446486ae91bc52934671 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5fee6dfe8af8446486ae91bc52934671()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_b9d65a5cf76d41cd99580fe3408605f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b9d65a5cf76d41cd99580fe3408605f1()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_a656f562fdb14b48ac6139598f57c995 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a656f562fdb14b48ac6139598f57c995()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_0e6a747f1d334f1cb6abbb380a5abda7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e6a747f1d334f1cb6abbb380a5abda7()
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

      private sealed class MTHD_e9e2b37364744d5ba4de6a05bbb0393d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e9e2b37364744d5ba4de6a05bbb0393d()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_7efe19c67d654b23a62314b09732ef02 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7efe19c67d654b23a62314b09732ef02()
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

      private sealed class MTHD_a09c89f822574c9da66af4b7f92a7aab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a09c89f822574c9da66af4b7f92a7aab()
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

      private sealed class MTHD_4a72d2cdee3f4d418605df305a974453 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a72d2cdee3f4d418605df305a974453()
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

      private sealed class MTHD_b26d3b64037f483a8a18a0d8aa1a539a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b26d3b64037f483a8a18a0d8aa1a539a()
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

      private sealed class MTHD_d554069f172e4c52b6a7d3d924e73550 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d554069f172e4c52b6a7d3d924e73550()
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

      private sealed class MTHD_dcebf0bc20524a30a6dd8ed8e0b67025 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dcebf0bc20524a30a6dd8ed8e0b67025()
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

      private sealed class MTHD_878818fba5be4a188b14848124835e25 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_878818fba5be4a188b14848124835e25()
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

      private sealed class MTHD_dddfe066adc141068935ce3dd48159d5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dddfe066adc141068935ce3dd48159d5()
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

      private sealed class MTHD_cbfdb81d000a4097a22490152cd310d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cbfdb81d000a4097a22490152cd310d9()
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

      private sealed class MTHD_d7b4e28db7b941518acad938046d4e5d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d7b4e28db7b941518acad938046d4e5d()
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

      private sealed class MTHD_1944144c323644ad9f47583309c36adc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1944144c323644ad9f47583309c36adc()
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

      private sealed class MTHD_f8b4080666e54735b72a3cfc8bf968f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f8b4080666e54735b72a3cfc8bf968f7()
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

      private sealed class MTHD_7615740d2464430885fffdd590467e3e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7615740d2464430885fffdd590467e3e()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_f4aee4a2db6f46d0b4d9edbe0133d0d9 : HardwiredMemberDescriptor
      {
        internal FLDV_f4aee4a2db6f46d0b4d9edbe0133d0d9()
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

      private sealed class FLDV_89cff59de21d42aa9765253fb42e98d6 : HardwiredMemberDescriptor
      {
        internal FLDV_89cff59de21d42aa9765253fb42e98d6()
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

    private sealed class TYPE_1480b72b568a4ffb8d1542688875dfe4 : HardwiredUserDataDescriptor
    {
      internal TYPE_1480b72b568a4ffb8d1542688875dfe4()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1480b72b568a4ffb8d1542688875dfe4.MTHD_f1b65e6089fd485692d3e2f09446a1d3()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1480b72b568a4ffb8d1542688875dfe4.MTHD_ade459574f704376a091fe349842ccb4()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1480b72b568a4ffb8d1542688875dfe4.MTHD_0905b0f66796404182dddbd5ad2eb5e9()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1480b72b568a4ffb8d1542688875dfe4.MTHD_6f53873726694b419ad83f1a1e9f41c5()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1480b72b568a4ffb8d1542688875dfe4.MTHD_c8402ae547fd4b37a6835828b912e7ba()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1480b72b568a4ffb8d1542688875dfe4.MTHD_d58e677a600d4f8e9851e6dfc9d7cb73()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_1480b72b568a4ffb8d1542688875dfe4.FLDV_3bad65af4c434f56a7cb8ba2ec84eede());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_1480b72b568a4ffb8d1542688875dfe4.FLDV_660586ee66094223be713dbc8454f2ea());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_1480b72b568a4ffb8d1542688875dfe4.FLDV_654787b72a3f45c9a9fe6d8a2fb730ac());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_1480b72b568a4ffb8d1542688875dfe4.FLDV_46ac8aa3764c4a7580365c5a4a69efa8());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_1480b72b568a4ffb8d1542688875dfe4.FLDV_9d5477789bae4fda8489ffc080936015());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_1480b72b568a4ffb8d1542688875dfe4.FLDV_2e9b9298aba147eaad96f1805c3fe63b());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_1480b72b568a4ffb8d1542688875dfe4.FLDV_22784a9731cb4a0dad10d65b63252761());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_1480b72b568a4ffb8d1542688875dfe4.FLDV_e1f7166fdd504d05a04116811c177884());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_1480b72b568a4ffb8d1542688875dfe4.FLDV_90e88db696904bb4bdcd80bea1455d69());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_1480b72b568a4ffb8d1542688875dfe4.FLDV_180df30be1484ba68f3ae6060517f5c6());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_1480b72b568a4ffb8d1542688875dfe4.FLDV_030e306a233f4dabbd8f9c08eea2fcb6());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_1480b72b568a4ffb8d1542688875dfe4.FLDV_b2843a6d9b484f6b94f3ea8208865df7());
      }

      private sealed class MTHD_f1b65e6089fd485692d3e2f09446a1d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f1b65e6089fd485692d3e2f09446a1d3()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_ade459574f704376a091fe349842ccb4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ade459574f704376a091fe349842ccb4()
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

      private sealed class MTHD_0905b0f66796404182dddbd5ad2eb5e9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0905b0f66796404182dddbd5ad2eb5e9()
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

      private sealed class MTHD_6f53873726694b419ad83f1a1e9f41c5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6f53873726694b419ad83f1a1e9f41c5()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_c8402ae547fd4b37a6835828b912e7ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c8402ae547fd4b37a6835828b912e7ba()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_d58e677a600d4f8e9851e6dfc9d7cb73 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d58e677a600d4f8e9851e6dfc9d7cb73()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_3bad65af4c434f56a7cb8ba2ec84eede : HardwiredMemberDescriptor
      {
        internal FLDV_3bad65af4c434f56a7cb8ba2ec84eede()
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

      private sealed class FLDV_660586ee66094223be713dbc8454f2ea : HardwiredMemberDescriptor
      {
        internal FLDV_660586ee66094223be713dbc8454f2ea()
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

      private sealed class FLDV_654787b72a3f45c9a9fe6d8a2fb730ac : HardwiredMemberDescriptor
      {
        internal FLDV_654787b72a3f45c9a9fe6d8a2fb730ac()
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

      private sealed class FLDV_46ac8aa3764c4a7580365c5a4a69efa8 : HardwiredMemberDescriptor
      {
        internal FLDV_46ac8aa3764c4a7580365c5a4a69efa8()
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

      private sealed class FLDV_9d5477789bae4fda8489ffc080936015 : HardwiredMemberDescriptor
      {
        internal FLDV_9d5477789bae4fda8489ffc080936015()
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

      private sealed class FLDV_2e9b9298aba147eaad96f1805c3fe63b : HardwiredMemberDescriptor
      {
        internal FLDV_2e9b9298aba147eaad96f1805c3fe63b()
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

      private sealed class FLDV_22784a9731cb4a0dad10d65b63252761 : HardwiredMemberDescriptor
      {
        internal FLDV_22784a9731cb4a0dad10d65b63252761()
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

      private sealed class FLDV_e1f7166fdd504d05a04116811c177884 : HardwiredMemberDescriptor
      {
        internal FLDV_e1f7166fdd504d05a04116811c177884()
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

      private sealed class FLDV_90e88db696904bb4bdcd80bea1455d69 : HardwiredMemberDescriptor
      {
        internal FLDV_90e88db696904bb4bdcd80bea1455d69()
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

      private sealed class FLDV_180df30be1484ba68f3ae6060517f5c6 : HardwiredMemberDescriptor
      {
        internal FLDV_180df30be1484ba68f3ae6060517f5c6()
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

      private sealed class FLDV_030e306a233f4dabbd8f9c08eea2fcb6 : HardwiredMemberDescriptor
      {
        internal FLDV_030e306a233f4dabbd8f9c08eea2fcb6()
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

      private sealed class FLDV_b2843a6d9b484f6b94f3ea8208865df7 : HardwiredMemberDescriptor
      {
        internal FLDV_b2843a6d9b484f6b94f3ea8208865df7()
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

    private sealed class TYPE_c3848519142c40f2bba89fe83e9aa5ef : HardwiredUserDataDescriptor
    {
      internal TYPE_c3848519142c40f2bba89fe83e9aa5ef()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_cdaa8b82ff694e19aa84f9003e3d4adc()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_6661cde6b96a4c279909c74249d144e4()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_4113b38c66144c2893072ed056667f49()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_3402fbd22d0543889969761378c95e9f()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_ccb47cbb09ec4c7e9bc8e91c02dc687c()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_3064d1e5592845cdb6216065c2dff7ca()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_92ccc7c585ea42b08c8f429ef071e996()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_10905e9108b04bce9a0d2790947d32cc()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_532455fe5df644c69d84e2ad9ceb4be3()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_2e39b5ce908c462d9e0d0887cdff70cf()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_42ebe70f114e40898ba94e7d1d4a2c79()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_2af37080712041dfb62ec0e2fb8bd7c4()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_6be3051ddb7443f4a5ce3c0fdbddedd6()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_e4f06568cc834bf8a5bd8ddb0b98b3e7()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_f83943f5881e40f8970dd75af5efa808()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_52d8096a385f4b6aaae766c48d093771()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_14267de4b10345d5ba65fc67f2d3a4c3()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_dc14338851bc40bc8cbd9bc10a167a16()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_e0b1e44e9fa642a9be2c010ca437b4b7()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_7f4547c30d4843b783ed8cc067858de5()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_e5a67e2d64b942afae69dbf00739b86e()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_4a5f36a1aaa54674997ad66a2b5217a6()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_74a75e00554e44fd9e69d25e149d0c09()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_fb10ff39e11248318777933e1e3cd7c8()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_6060fd6cc3594ac3bdea74ae01130e25()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_4ab5dd23209445b6824cf33639346ed0()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_d8457371b94c449393a945725bf3af4a()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_65c741c3bdbc43f6a76841bdd51f353d()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_5261a11937e94a0a820f1da139bf8480()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_889a125e09284fc688bc689f6ef1554e()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_45ef580dcc894b31bd5a8496fcb32fa6()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_cd27799b79eb46a8b48a837c8945e0c0()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_345440fccd6e45ea8a19430597dbe843()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_d32e2c871314471f8f5bba700f3b6a61()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_dd815c33d93f43c58c64782e7be09408()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_70250a794f3b4676b809d5f0a29f21db()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_5ef9f1ea60434d36a3e0d700513298e7()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_0e7027248f3d4b4dbccba7c6cd386dd1()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_f65b098fc303434bba766c69e0fcfbec()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_9ab8886bf1c84281a9dde9dfdee32ef9()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_4e859172455a477781b74eee779e2e5e()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_86bb745acf3c46e584f22ac51eb21b41()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_2c0028b1402848649ae971ff76ebddd6()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_82a7c115d3634e6eb957cc701c819bbb()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_753d8115d70e4905aaeb24242cbdf207()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_22573a9e6d3e46df819dec07bbeaba7c()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_e8763c79f8774f43b0add14ceef31467()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.MTHD_d9ef40c7b9154d459d09fadb9f1d44ae()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.PROP_2a5f0da4575142619045645f2399d46c());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.PROP_a2323063389f4698ad83168bdee40cea());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.PROP_1615386b6ae2434db9a3b94b7fa573e4());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.PROP_9b1d56cab93c40f1b359a04de52b8e68());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.PROP_8977174ee7e44ed6a72c882cf5c44153());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.PROP_a1f2fc7816bc4c95897237a74a1084cc());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.PROP_4740fc14264f492ab6eb38c3cee2cda0());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.PROP_d9b7b7a84b114fad894e3eb8aa4dfc9d());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.PROP_b5de920fc6dd4887806086a518f138e6());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.PROP_89b1ae3ec3cf42668657506828523b7a());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.PROP_33bf4022399e40b5a2ed1d3e6ceaa554());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.PROP_a4c8c51f1a4e4c2dbf53f52a33f6a598());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.PROP_0903cb968526456eb796f6c4f6ebdabf());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.PROP_4c1fb060b65b4a70bd96b526c07c95e2());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.PROP_20e29a33331d4d729bc488c5c84419ba());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.PROP_cb06e6dad0bd48d79d42086b75f87bd1());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.PROP_f05a5b7bb18a4818baeabf2cc6784bfe());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.PROP_71840279a95949f98ece366f9f21355b());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.PROP_cc0a41b288564aa8a2c87d4c094754c8());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.FLDV_eddcb6dcf4d945ada244654ec1c7a9a4());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.FLDV_b8c12345223b4ead87766acea19dfa65());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_c3848519142c40f2bba89fe83e9aa5ef.FLDV_62c98bb0e3454546a60409c97e9a3af8());
      }

      private sealed class MTHD_cdaa8b82ff694e19aa84f9003e3d4adc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cdaa8b82ff694e19aa84f9003e3d4adc()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_6661cde6b96a4c279909c74249d144e4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6661cde6b96a4c279909c74249d144e4()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_4113b38c66144c2893072ed056667f49 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4113b38c66144c2893072ed056667f49()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_3402fbd22d0543889969761378c95e9f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3402fbd22d0543889969761378c95e9f()
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

      private sealed class MTHD_ccb47cbb09ec4c7e9bc8e91c02dc687c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ccb47cbb09ec4c7e9bc8e91c02dc687c()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_3064d1e5592845cdb6216065c2dff7ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3064d1e5592845cdb6216065c2dff7ca()
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

      private sealed class MTHD_92ccc7c585ea42b08c8f429ef071e996 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_92ccc7c585ea42b08c8f429ef071e996()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_10905e9108b04bce9a0d2790947d32cc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_10905e9108b04bce9a0d2790947d32cc()
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

      private sealed class MTHD_532455fe5df644c69d84e2ad9ceb4be3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_532455fe5df644c69d84e2ad9ceb4be3()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_2e39b5ce908c462d9e0d0887cdff70cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2e39b5ce908c462d9e0d0887cdff70cf()
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

      private sealed class MTHD_42ebe70f114e40898ba94e7d1d4a2c79 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42ebe70f114e40898ba94e7d1d4a2c79()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_2af37080712041dfb62ec0e2fb8bd7c4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2af37080712041dfb62ec0e2fb8bd7c4()
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

      private sealed class MTHD_6be3051ddb7443f4a5ce3c0fdbddedd6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6be3051ddb7443f4a5ce3c0fdbddedd6()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_e4f06568cc834bf8a5bd8ddb0b98b3e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e4f06568cc834bf8a5bd8ddb0b98b3e7()
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

      private sealed class MTHD_f83943f5881e40f8970dd75af5efa808 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f83943f5881e40f8970dd75af5efa808()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_52d8096a385f4b6aaae766c48d093771 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52d8096a385f4b6aaae766c48d093771()
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

      private sealed class MTHD_14267de4b10345d5ba65fc67f2d3a4c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_14267de4b10345d5ba65fc67f2d3a4c3()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_dc14338851bc40bc8cbd9bc10a167a16 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc14338851bc40bc8cbd9bc10a167a16()
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

      private sealed class MTHD_e0b1e44e9fa642a9be2c010ca437b4b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e0b1e44e9fa642a9be2c010ca437b4b7()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_7f4547c30d4843b783ed8cc067858de5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f4547c30d4843b783ed8cc067858de5()
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

      private sealed class MTHD_e5a67e2d64b942afae69dbf00739b86e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e5a67e2d64b942afae69dbf00739b86e()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_4a5f36a1aaa54674997ad66a2b5217a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a5f36a1aaa54674997ad66a2b5217a6()
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

      private sealed class MTHD_74a75e00554e44fd9e69d25e149d0c09 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74a75e00554e44fd9e69d25e149d0c09()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_fb10ff39e11248318777933e1e3cd7c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb10ff39e11248318777933e1e3cd7c8()
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

      private sealed class MTHD_6060fd6cc3594ac3bdea74ae01130e25 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6060fd6cc3594ac3bdea74ae01130e25()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_4ab5dd23209445b6824cf33639346ed0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ab5dd23209445b6824cf33639346ed0()
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

      private sealed class MTHD_d8457371b94c449393a945725bf3af4a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8457371b94c449393a945725bf3af4a()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_65c741c3bdbc43f6a76841bdd51f353d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65c741c3bdbc43f6a76841bdd51f353d()
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

      private sealed class MTHD_5261a11937e94a0a820f1da139bf8480 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5261a11937e94a0a820f1da139bf8480()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_889a125e09284fc688bc689f6ef1554e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_889a125e09284fc688bc689f6ef1554e()
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

      private sealed class MTHD_45ef580dcc894b31bd5a8496fcb32fa6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_45ef580dcc894b31bd5a8496fcb32fa6()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_cd27799b79eb46a8b48a837c8945e0c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd27799b79eb46a8b48a837c8945e0c0()
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

      private sealed class MTHD_345440fccd6e45ea8a19430597dbe843 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_345440fccd6e45ea8a19430597dbe843()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_d32e2c871314471f8f5bba700f3b6a61 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d32e2c871314471f8f5bba700f3b6a61()
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

      private sealed class MTHD_dd815c33d93f43c58c64782e7be09408 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dd815c33d93f43c58c64782e7be09408()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_70250a794f3b4676b809d5f0a29f21db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70250a794f3b4676b809d5f0a29f21db()
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

      private sealed class MTHD_5ef9f1ea60434d36a3e0d700513298e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ef9f1ea60434d36a3e0d700513298e7()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_0e7027248f3d4b4dbccba7c6cd386dd1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e7027248f3d4b4dbccba7c6cd386dd1()
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

      private sealed class MTHD_f65b098fc303434bba766c69e0fcfbec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f65b098fc303434bba766c69e0fcfbec()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9ab8886bf1c84281a9dde9dfdee32ef9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ab8886bf1c84281a9dde9dfdee32ef9()
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

      private sealed class MTHD_4e859172455a477781b74eee779e2e5e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e859172455a477781b74eee779e2e5e()
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

      private sealed class MTHD_86bb745acf3c46e584f22ac51eb21b41 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_86bb745acf3c46e584f22ac51eb21b41()
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

      private sealed class MTHD_2c0028b1402848649ae971ff76ebddd6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c0028b1402848649ae971ff76ebddd6()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_82a7c115d3634e6eb957cc701c819bbb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_82a7c115d3634e6eb957cc701c819bbb()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_753d8115d70e4905aaeb24242cbdf207 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_753d8115d70e4905aaeb24242cbdf207()
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

      private sealed class MTHD_22573a9e6d3e46df819dec07bbeaba7c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22573a9e6d3e46df819dec07bbeaba7c()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_e8763c79f8774f43b0add14ceef31467 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e8763c79f8774f43b0add14ceef31467()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_d9ef40c7b9154d459d09fadb9f1d44ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d9ef40c7b9154d459d09fadb9f1d44ae()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_2a5f0da4575142619045645f2399d46c : HardwiredMemberDescriptor
      {
        internal PROP_2a5f0da4575142619045645f2399d46c()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_a2323063389f4698ad83168bdee40cea : HardwiredMemberDescriptor
      {
        internal PROP_a2323063389f4698ad83168bdee40cea()
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

      private sealed class PROP_1615386b6ae2434db9a3b94b7fa573e4 : HardwiredMemberDescriptor
      {
        internal PROP_1615386b6ae2434db9a3b94b7fa573e4()
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

      private sealed class PROP_9b1d56cab93c40f1b359a04de52b8e68 : HardwiredMemberDescriptor
      {
        internal PROP_9b1d56cab93c40f1b359a04de52b8e68()
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

      private sealed class PROP_8977174ee7e44ed6a72c882cf5c44153 : HardwiredMemberDescriptor
      {
        internal PROP_8977174ee7e44ed6a72c882cf5c44153()
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

      private sealed class PROP_a1f2fc7816bc4c95897237a74a1084cc : HardwiredMemberDescriptor
      {
        internal PROP_a1f2fc7816bc4c95897237a74a1084cc()
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

      private sealed class PROP_4740fc14264f492ab6eb38c3cee2cda0 : HardwiredMemberDescriptor
      {
        internal PROP_4740fc14264f492ab6eb38c3cee2cda0()
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

      private sealed class PROP_d9b7b7a84b114fad894e3eb8aa4dfc9d : HardwiredMemberDescriptor
      {
        internal PROP_d9b7b7a84b114fad894e3eb8aa4dfc9d()
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

      private sealed class PROP_b5de920fc6dd4887806086a518f138e6 : HardwiredMemberDescriptor
      {
        internal PROP_b5de920fc6dd4887806086a518f138e6()
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

      private sealed class PROP_89b1ae3ec3cf42668657506828523b7a : HardwiredMemberDescriptor
      {
        internal PROP_89b1ae3ec3cf42668657506828523b7a()
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

      private sealed class PROP_33bf4022399e40b5a2ed1d3e6ceaa554 : HardwiredMemberDescriptor
      {
        internal PROP_33bf4022399e40b5a2ed1d3e6ceaa554()
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

      private sealed class PROP_a4c8c51f1a4e4c2dbf53f52a33f6a598 : HardwiredMemberDescriptor
      {
        internal PROP_a4c8c51f1a4e4c2dbf53f52a33f6a598()
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

      private sealed class PROP_0903cb968526456eb796f6c4f6ebdabf : HardwiredMemberDescriptor
      {
        internal PROP_0903cb968526456eb796f6c4f6ebdabf()
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

      private sealed class PROP_4c1fb060b65b4a70bd96b526c07c95e2 : HardwiredMemberDescriptor
      {
        internal PROP_4c1fb060b65b4a70bd96b526c07c95e2()
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

      private sealed class PROP_20e29a33331d4d729bc488c5c84419ba : HardwiredMemberDescriptor
      {
        internal PROP_20e29a33331d4d729bc488c5c84419ba()
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

      private sealed class PROP_cb06e6dad0bd48d79d42086b75f87bd1 : HardwiredMemberDescriptor
      {
        internal PROP_cb06e6dad0bd48d79d42086b75f87bd1()
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

      private sealed class PROP_f05a5b7bb18a4818baeabf2cc6784bfe : HardwiredMemberDescriptor
      {
        internal PROP_f05a5b7bb18a4818baeabf2cc6784bfe()
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

      private sealed class PROP_71840279a95949f98ece366f9f21355b : HardwiredMemberDescriptor
      {
        internal PROP_71840279a95949f98ece366f9f21355b()
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

      private sealed class PROP_cc0a41b288564aa8a2c87d4c094754c8 : HardwiredMemberDescriptor
      {
        internal PROP_cc0a41b288564aa8a2c87d4c094754c8()
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

      private sealed class FLDV_eddcb6dcf4d945ada244654ec1c7a9a4 : HardwiredMemberDescriptor
      {
        internal FLDV_eddcb6dcf4d945ada244654ec1c7a9a4()
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

      private sealed class FLDV_b8c12345223b4ead87766acea19dfa65 : HardwiredMemberDescriptor
      {
        internal FLDV_b8c12345223b4ead87766acea19dfa65()
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

      private sealed class FLDV_62c98bb0e3454546a60409c97e9a3af8 : HardwiredMemberDescriptor
      {
        internal FLDV_62c98bb0e3454546a60409c97e9a3af8()
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

    private sealed class TYPE_03f512dde1134381babc415b717591e4 : HardwiredUserDataDescriptor
    {
      internal TYPE_03f512dde1134381babc415b717591e4()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_03f512dde1134381babc415b717591e4.MTHD_86380729bccf40c2aeb94e498024264c()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_03f512dde1134381babc415b717591e4.MTHD_bca6da2c3f624592a3f230e28bb3febf()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_03f512dde1134381babc415b717591e4.MTHD_4e387172378d47b4a38357df1b9a0971()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_03f512dde1134381babc415b717591e4.MTHD_2b8a5307357141e89bc82ea4d4075c2f()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_03f512dde1134381babc415b717591e4.MTHD_e4623581d4af467696166ee4e1c57faf()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_03f512dde1134381babc415b717591e4.MTHD_5a3c895a4b8f489fa2746b13e9c828b7()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_03f512dde1134381babc415b717591e4.FLDV_96e21a4bd6664a5c87ec0b83fb184634());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_03f512dde1134381babc415b717591e4.FLDV_0fdecf3696164bce86077928a6d304d0());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_03f512dde1134381babc415b717591e4.FLDV_583de59381964d59a850009b91be9d3e());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_03f512dde1134381babc415b717591e4.FLDV_7916be6f2e4e4fd3b78ce1ca61ccdefc());
      }

      private sealed class MTHD_86380729bccf40c2aeb94e498024264c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_86380729bccf40c2aeb94e498024264c()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_bca6da2c3f624592a3f230e28bb3febf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bca6da2c3f624592a3f230e28bb3febf()
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

      private sealed class MTHD_4e387172378d47b4a38357df1b9a0971 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e387172378d47b4a38357df1b9a0971()
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

      private sealed class MTHD_2b8a5307357141e89bc82ea4d4075c2f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b8a5307357141e89bc82ea4d4075c2f()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_e4623581d4af467696166ee4e1c57faf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e4623581d4af467696166ee4e1c57faf()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_5a3c895a4b8f489fa2746b13e9c828b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5a3c895a4b8f489fa2746b13e9c828b7()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_96e21a4bd6664a5c87ec0b83fb184634 : HardwiredMemberDescriptor
      {
        internal FLDV_96e21a4bd6664a5c87ec0b83fb184634()
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

      private sealed class FLDV_0fdecf3696164bce86077928a6d304d0 : HardwiredMemberDescriptor
      {
        internal FLDV_0fdecf3696164bce86077928a6d304d0()
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

      private sealed class FLDV_583de59381964d59a850009b91be9d3e : HardwiredMemberDescriptor
      {
        internal FLDV_583de59381964d59a850009b91be9d3e()
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

      private sealed class FLDV_7916be6f2e4e4fd3b78ce1ca61ccdefc : HardwiredMemberDescriptor
      {
        internal FLDV_7916be6f2e4e4fd3b78ce1ca61ccdefc()
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

    private sealed class TYPE_4363901069d94c5d91feb9c40f733b91 : HardwiredUserDataDescriptor
    {
      internal TYPE_4363901069d94c5d91feb9c40f733b91()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4363901069d94c5d91feb9c40f733b91.MTHD_73c158b7809646e28f93edf8484bd56d()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4363901069d94c5d91feb9c40f733b91.MTHD_2ba484e21cfc44189e091df79b862194()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4363901069d94c5d91feb9c40f733b91.MTHD_a882b7b5441740afada98c036290f1ff()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4363901069d94c5d91feb9c40f733b91.MTHD_18e9ee98dd6b48a5ae090edf89205c12()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4363901069d94c5d91feb9c40f733b91.MTHD_32cbda6e799c406ab7b211f9ffe7bdd4()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_4363901069d94c5d91feb9c40f733b91.FLDV_d7b1cc3f8d7f4f98800fbefd45c52429());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_4363901069d94c5d91feb9c40f733b91.FLDV_89c8ac90c1e54d54acc6eb52a63a8a95());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_4363901069d94c5d91feb9c40f733b91.FLDV_73cbf384100542868afde5d3c2b8acb5());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_4363901069d94c5d91feb9c40f733b91.FLDV_5251b99e329e44e8b5d4cc3d5e7c21cd());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_4363901069d94c5d91feb9c40f733b91.FLDV_f1a19bc98a5b43bc8bcb745f26813c95());
      }

      private sealed class MTHD_73c158b7809646e28f93edf8484bd56d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_73c158b7809646e28f93edf8484bd56d()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_2ba484e21cfc44189e091df79b862194 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2ba484e21cfc44189e091df79b862194()
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

      private sealed class MTHD_a882b7b5441740afada98c036290f1ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a882b7b5441740afada98c036290f1ff()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_18e9ee98dd6b48a5ae090edf89205c12 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_18e9ee98dd6b48a5ae090edf89205c12()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_32cbda6e799c406ab7b211f9ffe7bdd4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_32cbda6e799c406ab7b211f9ffe7bdd4()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_d7b1cc3f8d7f4f98800fbefd45c52429 : HardwiredMemberDescriptor
      {
        internal FLDV_d7b1cc3f8d7f4f98800fbefd45c52429()
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

      private sealed class FLDV_89c8ac90c1e54d54acc6eb52a63a8a95 : HardwiredMemberDescriptor
      {
        internal FLDV_89c8ac90c1e54d54acc6eb52a63a8a95()
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

      private sealed class FLDV_73cbf384100542868afde5d3c2b8acb5 : HardwiredMemberDescriptor
      {
        internal FLDV_73cbf384100542868afde5d3c2b8acb5()
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

      private sealed class FLDV_5251b99e329e44e8b5d4cc3d5e7c21cd : HardwiredMemberDescriptor
      {
        internal FLDV_5251b99e329e44e8b5d4cc3d5e7c21cd()
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

      private sealed class FLDV_f1a19bc98a5b43bc8bcb745f26813c95 : HardwiredMemberDescriptor
      {
        internal FLDV_f1a19bc98a5b43bc8bcb745f26813c95()
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

    private sealed class TYPE_fd45273f9ee34908b3ab75899a932dbb : HardwiredUserDataDescriptor
    {
      internal TYPE_fd45273f9ee34908b3ab75899a932dbb()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fd45273f9ee34908b3ab75899a932dbb.MTHD_1fe85ec224fb40e1aa398f8ea616e740()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fd45273f9ee34908b3ab75899a932dbb.MTHD_c8b0b06834044465b768e268b22c9312()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fd45273f9ee34908b3ab75899a932dbb.MTHD_f85973f5e87d47658d7e81692865b32d()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fd45273f9ee34908b3ab75899a932dbb.MTHD_f366db0ad4ab461898dd67211fc72fa6()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fd45273f9ee34908b3ab75899a932dbb.MTHD_f97a6ab2d83043748435ecfeb1c31b5b()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fd45273f9ee34908b3ab75899a932dbb.MTHD_f6a7d1ed8784472989a50a6c766dc697()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fd45273f9ee34908b3ab75899a932dbb.MTHD_412ee53458454598b2a30783aa81b36f()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fd45273f9ee34908b3ab75899a932dbb.MTHD_e261df7305164efaa6209a86caf2d61c()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fd45273f9ee34908b3ab75899a932dbb.MTHD_95347fa8eca045a78be04c386ee538f4()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fd45273f9ee34908b3ab75899a932dbb.MTHD_cecfa8ab7ba141e698cf184f73081afc()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fd45273f9ee34908b3ab75899a932dbb.MTHD_3e6da3d8d1ca4d3c8f6168da4080b64f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fd45273f9ee34908b3ab75899a932dbb.MTHD_479411e265a646c6beed05dd1d3e43a9()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fd45273f9ee34908b3ab75899a932dbb.MTHD_039957f1a8914ba6a0671d11bf531526()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_fd45273f9ee34908b3ab75899a932dbb.FLDV_b6098b331224474ebb3c831e4063a7b9());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_fd45273f9ee34908b3ab75899a932dbb.FLDV_3e47fa4873c54498bb8cfcb58b49a599());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_fd45273f9ee34908b3ab75899a932dbb.FLDV_e09a2ed93c384cfca1d15e22de7b1f13());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_fd45273f9ee34908b3ab75899a932dbb.FLDV_a0de7ff7835f4978a9426d416ffdf5f5());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_fd45273f9ee34908b3ab75899a932dbb.FLDV_5b3d2dcb9df34b7a82b61bf89d9b8ee8());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_fd45273f9ee34908b3ab75899a932dbb.FLDV_a96bf10293874fcb9672fb98f68f2e22());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_fd45273f9ee34908b3ab75899a932dbb.FLDV_a7dd18d515524eb4b3c61bddc397f843());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_fd45273f9ee34908b3ab75899a932dbb.FLDV_b10eb1cbe6e44591abf533d910da2cee());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_fd45273f9ee34908b3ab75899a932dbb.DVAL_eabb9d517ddd4017a8b028335ade69c5());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_fd45273f9ee34908b3ab75899a932dbb.DVAL_ab4570ce4a294ac197f6476dcdadb312());
      }

      private sealed class MTHD_1fe85ec224fb40e1aa398f8ea616e740 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1fe85ec224fb40e1aa398f8ea616e740()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_c8b0b06834044465b768e268b22c9312 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c8b0b06834044465b768e268b22c9312()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_f85973f5e87d47658d7e81692865b32d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f85973f5e87d47658d7e81692865b32d()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f366db0ad4ab461898dd67211fc72fa6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f366db0ad4ab461898dd67211fc72fa6()
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

      private sealed class MTHD_f97a6ab2d83043748435ecfeb1c31b5b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f97a6ab2d83043748435ecfeb1c31b5b()
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

      private sealed class MTHD_f6a7d1ed8784472989a50a6c766dc697 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f6a7d1ed8784472989a50a6c766dc697()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_412ee53458454598b2a30783aa81b36f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_412ee53458454598b2a30783aa81b36f()
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

      private sealed class MTHD_e261df7305164efaa6209a86caf2d61c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e261df7305164efaa6209a86caf2d61c()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_95347fa8eca045a78be04c386ee538f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95347fa8eca045a78be04c386ee538f4()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_cecfa8ab7ba141e698cf184f73081afc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cecfa8ab7ba141e698cf184f73081afc()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_3e6da3d8d1ca4d3c8f6168da4080b64f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e6da3d8d1ca4d3c8f6168da4080b64f()
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

      private sealed class MTHD_479411e265a646c6beed05dd1d3e43a9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_479411e265a646c6beed05dd1d3e43a9()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_039957f1a8914ba6a0671d11bf531526 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_039957f1a8914ba6a0671d11bf531526()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_b6098b331224474ebb3c831e4063a7b9 : HardwiredMemberDescriptor
      {
        internal FLDV_b6098b331224474ebb3c831e4063a7b9()
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

      private sealed class FLDV_3e47fa4873c54498bb8cfcb58b49a599 : HardwiredMemberDescriptor
      {
        internal FLDV_3e47fa4873c54498bb8cfcb58b49a599()
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

      private sealed class FLDV_e09a2ed93c384cfca1d15e22de7b1f13 : HardwiredMemberDescriptor
      {
        internal FLDV_e09a2ed93c384cfca1d15e22de7b1f13()
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

      private sealed class FLDV_a0de7ff7835f4978a9426d416ffdf5f5 : HardwiredMemberDescriptor
      {
        internal FLDV_a0de7ff7835f4978a9426d416ffdf5f5()
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

      private sealed class FLDV_5b3d2dcb9df34b7a82b61bf89d9b8ee8 : HardwiredMemberDescriptor
      {
        internal FLDV_5b3d2dcb9df34b7a82b61bf89d9b8ee8()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_a96bf10293874fcb9672fb98f68f2e22 : HardwiredMemberDescriptor
      {
        internal FLDV_a96bf10293874fcb9672fb98f68f2e22()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_a7dd18d515524eb4b3c61bddc397f843 : HardwiredMemberDescriptor
      {
        internal FLDV_a7dd18d515524eb4b3c61bddc397f843()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_b10eb1cbe6e44591abf533d910da2cee : HardwiredMemberDescriptor
      {
        internal FLDV_b10eb1cbe6e44591abf533d910da2cee()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_eabb9d517ddd4017a8b028335ade69c5 : DynValueMemberDescriptor
      {
        internal DVAL_eabb9d517ddd4017a8b028335ade69c5()
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

      private sealed class DVAL_ab4570ce4a294ac197f6476dcdadb312 : DynValueMemberDescriptor
      {
        internal DVAL_ab4570ce4a294ac197f6476dcdadb312()
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

    private sealed class TYPE_9dfc6ca5898b48929a10296c55be684b : HardwiredUserDataDescriptor
    {
      internal TYPE_9dfc6ca5898b48929a10296c55be684b()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9dfc6ca5898b48929a10296c55be684b.MTHD_bc77345eda4c4663b037a929f1b416d2()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9dfc6ca5898b48929a10296c55be684b.MTHD_9d0ca64a31be450b81dbbbbb10443d7d()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9dfc6ca5898b48929a10296c55be684b.MTHD_44bb235d19584f46804c7028fde17caa(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9dfc6ca5898b48929a10296c55be684b.MTHD_8b14a50b4463469aa8ae6b0bcbc80101()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9dfc6ca5898b48929a10296c55be684b.MTHD_a8d7717014f9423aba733e7415b8a286(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9dfc6ca5898b48929a10296c55be684b.MTHD_4f13595c18014f38bf888775265c1cbf()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9dfc6ca5898b48929a10296c55be684b.MTHD_aeee66a376174b8fb4fc7b23c535ae1e()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9dfc6ca5898b48929a10296c55be684b.MTHD_92ac3df35d8944af99096ee0594afeb9()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9dfc6ca5898b48929a10296c55be684b.MTHD_45ab29342ce44ad2a25b4a703a914654()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9dfc6ca5898b48929a10296c55be684b.MTHD_c96397b3f90840898a117fb592e0d09c()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_9dfc6ca5898b48929a10296c55be684b.FLDV_d796a1e2a6584c17aef450617d04169e());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_9dfc6ca5898b48929a10296c55be684b.FLDV_09c9d8501eaf4f60b31b4d115810e5e1());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_9dfc6ca5898b48929a10296c55be684b.FLDV_2171e4200802439cb0f90edce3fbc55e());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_9dfc6ca5898b48929a10296c55be684b.FLDV_b2d65df9e76842d0ad04820d889fb509());
      }

      private sealed class MTHD_bc77345eda4c4663b037a929f1b416d2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bc77345eda4c4663b037a929f1b416d2()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_9d0ca64a31be450b81dbbbbb10443d7d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d0ca64a31be450b81dbbbbb10443d7d()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_44bb235d19584f46804c7028fde17caa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_44bb235d19584f46804c7028fde17caa()
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

      private sealed class MTHD_8b14a50b4463469aa8ae6b0bcbc80101 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b14a50b4463469aa8ae6b0bcbc80101()
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

      private sealed class MTHD_a8d7717014f9423aba733e7415b8a286 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a8d7717014f9423aba733e7415b8a286()
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

      private sealed class MTHD_4f13595c18014f38bf888775265c1cbf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4f13595c18014f38bf888775265c1cbf()
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

      private sealed class MTHD_aeee66a376174b8fb4fc7b23c535ae1e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aeee66a376174b8fb4fc7b23c535ae1e()
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

      private sealed class MTHD_92ac3df35d8944af99096ee0594afeb9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_92ac3df35d8944af99096ee0594afeb9()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_45ab29342ce44ad2a25b4a703a914654 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_45ab29342ce44ad2a25b4a703a914654()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_c96397b3f90840898a117fb592e0d09c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c96397b3f90840898a117fb592e0d09c()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_d796a1e2a6584c17aef450617d04169e : HardwiredMemberDescriptor
      {
        internal FLDV_d796a1e2a6584c17aef450617d04169e()
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

      private sealed class FLDV_09c9d8501eaf4f60b31b4d115810e5e1 : HardwiredMemberDescriptor
      {
        internal FLDV_09c9d8501eaf4f60b31b4d115810e5e1()
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

      private sealed class FLDV_2171e4200802439cb0f90edce3fbc55e : HardwiredMemberDescriptor
      {
        internal FLDV_2171e4200802439cb0f90edce3fbc55e()
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

      private sealed class FLDV_b2d65df9e76842d0ad04820d889fb509 : HardwiredMemberDescriptor
      {
        internal FLDV_b2d65df9e76842d0ad04820d889fb509()
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

    private sealed class TYPE_d1d043fcd373499d81ce71ecac33856c : HardwiredUserDataDescriptor
    {
      internal TYPE_d1d043fcd373499d81ce71ecac33856c()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d1d043fcd373499d81ce71ecac33856c.MTHD_a72dd78ea6af4186beb3133ef37af5b1()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d1d043fcd373499d81ce71ecac33856c.MTHD_6d073d2171d54770b0095e433f804d3f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d1d043fcd373499d81ce71ecac33856c.MTHD_a24c33686c8846cfab47a7d02cedbbaa()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d1d043fcd373499d81ce71ecac33856c.MTHD_afaf4b440c57419692790894278108c7()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d1d043fcd373499d81ce71ecac33856c.MTHD_d4e7f4d755494aa2bb3fda2c2a573cc1()
        }));
      }

      private sealed class MTHD_a72dd78ea6af4186beb3133ef37af5b1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a72dd78ea6af4186beb3133ef37af5b1()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_6d073d2171d54770b0095e433f804d3f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d073d2171d54770b0095e433f804d3f()
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

      private sealed class MTHD_a24c33686c8846cfab47a7d02cedbbaa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a24c33686c8846cfab47a7d02cedbbaa()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_afaf4b440c57419692790894278108c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_afaf4b440c57419692790894278108c7()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_d4e7f4d755494aa2bb3fda2c2a573cc1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d4e7f4d755494aa2bb3fda2c2a573cc1()
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
