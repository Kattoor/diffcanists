
using Educative;
using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Interop;
using MoonSharp.Interpreter.Interop.BasicDescriptors;
using MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors;
using MyPolling;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace MoonSharp
{
  public abstract class Bridge
  {
    private Bridge()
    {
    }

    public static void Initialize()
    {
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_b0b102743061489c91fdc5553f2049db());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_c9f67096b1d5495d8f0b9fa17ddf6d89());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_50d12a67c75c4029bc93bccabe32ff00());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_63ca7ab16ef54422bacbebfb95956b66());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_eb2d1f5d3d3e4806b39bf2ee6467ab89());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_87bcf4fbcf2247668204877d13ace778());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_1c424c6f2d244b88b7503e2539f94186());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_4bd0d34446364d379e801dfa0a2ef6ab());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_31f415a7efe944b0ae73947aa2fe0855());
    }

    private sealed class TYPE_79284a5b61014026892d4b70a6867e5c : HardwiredUserDataDescriptor
    {
      internal TYPE_79284a5b61014026892d4b70a6867e5c()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_294a6dce6f4e46798f64eaf6a7f9ce45()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_4b0f6295bcbd4ff5b9eeee147bec6021()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_0b4be690d9c64319ab07a586e86f4071()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_a1ef49bd59f04b779fc2ff229a06ead8()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_5b066100fcec42b29c3911635f7b415a()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_16504d6c55b040768d2825586dc455f2()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_e46ba682635e42ffb8149e00914e001a()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_2de6d6eff9014fe081441db4c8619771()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_fb0c5fa30bbd4c7882682a91cb46b014()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_7f31cbc7e9d042088ab4553f017a783f()
        }));
        this.AddMember("hideInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("hideInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_0b3707142b684de394d8bb859e286bb5()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_a07b069f23494cfc9e836807903242f6()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_78ff30ccb8fe49938293cf7b89fe3325()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_0f00dfb73ce74f0aaab532f8ebe00722()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_c2522751ee62427ebb05d6c0ee619b72()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_7441a7a1ecf84dcf85a6c0df3bd6a770()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_bb02275b56af4c5db9f094ad5f6a05db()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_8ee27b2a244c49488a64d5e6c9206fe9()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_c0bf38bb95f44c65b40ceeeb2ad62fac()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_81b68d33a8774254bd3b713164c7512f()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_0d1802adbf4245f1846c8874e14d9113()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_8a49b4d9b5f94a14ac83d7ff953be4d9()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_de897fa2f1c94e9d90f15de4f11a65b9()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_ace8f095d9d74c68b0c411ca33bb60c7()
        }));
        this.AddMember("get_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_d82b00d278f846c7a007e92c0576bba5()
        }));
        this.AddMember("set_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_f05b13ffef324e92b67d82219da57225()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_44c1b325185a4b0f956f4f3d80bf8bb8()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_e555e49a38d648978f759f8fceab1ca8()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_52f0677cab8f4c20bd8738fc94816ec9()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_eb192598f5554f0eb76d0d97f8ab8b8e()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_43e116c191004a1ab61cfc166510449c()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_cac6e2c8b2df4c87b49842ead3d66b2b()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_0dfa56dcdef4467ba22b0f9ddebd50ad()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_835c0ab70eb74a05a0ccb8f133c97ec0()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_809f77abb7f54cb383a305607d7d7501()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_b219d0e07c564d96af2ddd289dcbe767()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_fa3f40ee5ccd449db887859c8df77b8a()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_22980e7407ad4013b5325d0d510019c0()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_c58b425c5ebd4e0e9577526cb374b020()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_24ab9e0e785f4e83aa04c65b7eb17942()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_46f499ab3b62428baad646324027f11c()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_e5087dd4c98d4a06a84d10d4f8a36822()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_d1bfc9fc7b0941689682383533db6574()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_05cae85f49284195ac88017ab2dd46f7()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_64166c05595c4964a3eb76de3f892cef()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_4be2d1d4dfe14ce2a28af5676fe9cb29()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_567ad793a8d044bda28c5a7d926c5318()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_a84e7468f5bf4fc586e23a79a4f7e5ef()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_8a323300c13a4b6183e59090ab509b9a()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_495f0b88d6a24dcb837da5886358221f()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_bcb0abd64e65419d8e5a7c7a4bca2581()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_94cbe3afd32541ba8f430556bc1642d7()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_100abfa96253419880dbf608b0b60ba4()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_d040bc5a8de645d2b6e4d1aa410b0946()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_2461cda3b2654c758592100ff0d0a774()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_0dcd6b3db7de4ac1aec6b43f1c7bbee0()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_5ced087628424aa1b7f05a9bbb3ffb6b()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_ab205b99440a4e69a8d123b3e6f16a15()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_4b4775148c4e44cab411d9b7f533d024()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_69d4f4ccd8ca4844ba6e00fca8cacb9c()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_4677a5c8b2db4b88ae1961326e119af7()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_d39dacb05bb4421998852dbec2fe0d91()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_6e726c989d0041ac985a0f3cb2420552()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_9fdf52bb16aa41c8b8681519d98259ae()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_b83bca3ff7f3465faae619bb0f2e2aaa()
        }));
        this.AddMember("Dispose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Dispose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_b0b26f20701643d0a604df7c3fa16096()
        }));
        this.AddMember("drawImage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawImage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_51251c6549b5432a9d021b9557cfd8ed()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_a7e000e71644451fa76e2bd075ec9691()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_390f13111293426e97fca377f2bfdf3b()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_cbefa8b761c944f48ab622a97eb80924()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_ef347825d7194ed59205fdada82c3326()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_f233b46dd9d442df922ec6021a1ccd59()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_13952cedb43a4f3aa99e63ab4d54616a()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_6550fda13dfd4d04871b720c5007b8f9()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_d3f36e403ea74972b901fa8c2bfa3ee6()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_32acb440b9444b9fab9c30e7114b6e0b()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_f0d9acdf6e8143328c4af022de62636e()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_ee64af1431294ef59d9909e858e40dc0()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_7ae6ee3e41f0468fa61d7ec92f8ccd5d()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_bc71a0fa9b724cdd97ec7c18d6ab0b0d()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_0bce63c9840140359f4a9a6d3f8990cc()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_06e92bfbe5834a10b0b1cac178bdb44d()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_3832c2d726f2469196e0d847056c8218()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_ad110fda7cf44bdc9c4f81c99af0a5bb()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_bacd61b453274662a6121ab2b2346d4f()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_31ee846daf4a4c089d091a62ecd75d4c()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_14d0695863fd462b85e52fd5647a4006()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_b5c02f03cae44394ae5ab50bc7a7a97f()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_38d82933004d4227b8fd7e4ac31d5233()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_70e76d39eb9546529cb6572babcef363()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_2786697f719d4848b3b869e02365b8b3()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_38d323975b194b2289274719d6419f38()
        }));
        this.AddMember("cameraFollow", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("cameraFollow", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_b77270c48ee549aeb2817dbfc4bff354()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_f9584d43030e44dd9d84171bd7659d31()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_06f2b6f8a25e42d3b654ae1d7de75738()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_7d876a53439b4218b3c14dcbc88b156a()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_619e18bb2542444d9120cd693826e451()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_8aeae92975c14a4eba70df0f341ebe6c()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_2b1213d0798345f3b996972cf427bfbd(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_ca349689734e4f7fbfefe105e9a9cce6()
        }));
        this.AddMember("getKeyBinds", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getKeyBinds", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_6affefeb41194d16a51401d9f86b15f7()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_220785592f8740d8af2e40b727a90e2b()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_2596539e0c0744dd89b03afbb1206941()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_6d0cd82ee7a8475c971ac90572a1b3e4()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.MTHD_f63b2fa3309f4cd99863cab330d0471f()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_f9a9ea8cc9d343ceb1b3c0a42fb08001());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_469a189023d8413da51a296246522e8e());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_ce79572cac304e3e8e65e6244bd65a8b());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_56c34ea563b84c60bf37954fea213b80());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_e36e23711438433ea5296a442a5d73de());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_1c3115158bb0491fa3a642fdc0977761());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_b7c3caa247fa42c694c772edea62d9ae());
        this.AddMember("allowMinionMovement", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_d2697cd33ebc473b91e2ff5d0b46a991());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_7c5cbb4aa0e84a408a5e34dfc8202960());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_8ac44cac0058445095ce32d0762fd3ea());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_e4968523e00c4ef0ba5007bbdc9c6921());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_dcc1f8f7e1204689aa78bdadbe82e81c());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_9733a03829bf4394a2f5572ec3a65c3b());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_8c864c98dc6e45259394a142e2450f64());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_7f6c8522ff894e78a171099ef0439096());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_da5d8f4ba2734122a442970d5cd88b77());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_5503b6c8ca5d443b898dd8bc3a89665b());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_ef049e026f824f38bfa11ef0f641d53c());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_beb83664110b45d2951b64a7e8b83c6c());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_3f3b7f3052e64c94886b66697798ae07());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_8a30093d52ba4cfdbde8f8187b56d32e());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_acb68287fb3c42a4bba95ecc26d43e3b());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_1eb00e5b8f8c4b0ea55b75e14216a096());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_2f3a9989fda34e51b8e6962579c51326());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_24eca7af8efb47dcb0bdb86739f440ce());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_a67bcb559f0a4f04ad4c3590d55aba52());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_297614ad860f4aadbe5e2ccff56f8ea4());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_19306ef3691d4e20bd2eca958903bde0());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_e7024fdf447b42279332f95f81de5f29());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_769648b7ea5f445bac874c515455dac9());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_2c5a156bcd86413db9e436d86a6cf3dc());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_bd4c01bd6deb414f9f1f6bc1f942ea1a());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_79284a5b61014026892d4b70a6867e5c.PROP_c556e945aac943c2986ce8ed16eccf96());
      }

      private sealed class MTHD_294a6dce6f4e46798f64eaf6a7f9ce45 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_294a6dce6f4e46798f64eaf6a7f9ce45()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_4b0f6295bcbd4ff5b9eeee147bec6021 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b0f6295bcbd4ff5b9eeee147bec6021()
        {
          this.Initialize("getPlayers", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("script", typeof (Script))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayers((Script) pars[0]);
        }
      }

      private sealed class MTHD_0b4be690d9c64319ab07a586e86f4071 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b4be690d9c64319ab07a586e86f4071()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_a1ef49bd59f04b779fc2ff229a06ead8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1ef49bd59f04b779fc2ff229a06ead8()
        {
          this.Initialize("getCreatures", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("script", typeof (Script))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getCreatures((Script) pars[0]);
        }
      }

      private sealed class MTHD_5b066100fcec42b29c3911635f7b415a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b066100fcec42b29c3911635f7b415a()
        {
          this.Initialize("findCreatures", false, new ParameterDescriptor[3]
          {
            new ParameterDescriptor("script", typeof (Script)),
            new ParameterDescriptor("point", typeof (Educative.Point)),
            new ParameterDescriptor("radius", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).findCreatures((Script) pars[0], (Educative.Point) pars[1], (int) pars[2]);
        }
      }

      private sealed class MTHD_16504d6c55b040768d2825586dc455f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_16504d6c55b040768d2825586dc455f2()
        {
          this.Initialize("findEffectors", false, new ParameterDescriptor[3]
          {
            new ParameterDescriptor("script", typeof (Script)),
            new ParameterDescriptor("point", typeof (Educative.Point)),
            new ParameterDescriptor("radius", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).findEffectors((Script) pars[0], (Educative.Point) pars[1], (int) pars[2]);
        }
      }

      private sealed class MTHD_e46ba682635e42ffb8149e00914e001a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e46ba682635e42ffb8149e00914e001a()
        {
          this.Initialize("LineCast", false, new ParameterDescriptor[6]
          {
            new ParameterDescriptor("a", typeof (Educative.Point)),
            new ParameterDescriptor("b", typeof (Educative.Point)),
            new ParameterDescriptor("ignore", typeof (ContainerCreature), true, (object) new DefaultValue()),
            new ParameterDescriptor("includeCreatures", typeof (bool), true, (object) new DefaultValue()),
            new ParameterDescriptor("includeEffectors", typeof (bool), true, (object) new DefaultValue()),
            new ParameterDescriptor("includePhantom", typeof (bool), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 2)
            return (object) ((ContainerGame) obj).LineCast((Educative.Point) pars[0], (Educative.Point) pars[1]);
          if (argscount <= 3)
            return (object) ((ContainerGame) obj).LineCast((Educative.Point) pars[0], (Educative.Point) pars[1], (ContainerCreature) pars[2]);
          if (argscount <= 4)
            return (object) ((ContainerGame) obj).LineCast((Educative.Point) pars[0], (Educative.Point) pars[1], (ContainerCreature) pars[2], (bool) pars[3]);
          return argscount <= 5 ? (object) ((ContainerGame) obj).LineCast((Educative.Point) pars[0], (Educative.Point) pars[1], (ContainerCreature) pars[2], (bool) pars[3], (bool) pars[4]) : (object) ((ContainerGame) obj).LineCast((Educative.Point) pars[0], (Educative.Point) pars[1], (ContainerCreature) pars[2], (bool) pars[3], (bool) pars[4], (bool) pars[5]);
        }
      }

      private sealed class MTHD_2de6d6eff9014fe081441db4c8619771 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2de6d6eff9014fe081441db4c8619771()
        {
          this.Initialize("LineCastOnlyCreatures", false, new ParameterDescriptor[5]
          {
            new ParameterDescriptor("a", typeof (Educative.Point)),
            new ParameterDescriptor("b", typeof (Educative.Point)),
            new ParameterDescriptor("ignore", typeof (ContainerCreature), true, (object) new DefaultValue()),
            new ParameterDescriptor("includeCreatures", typeof (bool), true, (object) new DefaultValue()),
            new ParameterDescriptor("includePhantom", typeof (bool), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 2)
            return (object) ((ContainerGame) obj).LineCastOnlyCreatures((Educative.Point) pars[0], (Educative.Point) pars[1]);
          if (argscount <= 3)
            return (object) ((ContainerGame) obj).LineCastOnlyCreatures((Educative.Point) pars[0], (Educative.Point) pars[1], (ContainerCreature) pars[2]);
          return argscount <= 4 ? (object) ((ContainerGame) obj).LineCastOnlyCreatures((Educative.Point) pars[0], (Educative.Point) pars[1], (ContainerCreature) pars[2], (bool) pars[3]) : (object) ((ContainerGame) obj).LineCastOnlyCreatures((Educative.Point) pars[0], (Educative.Point) pars[1], (ContainerCreature) pars[2], (bool) pars[3], (bool) pars[4]);
        }
      }

      private sealed class MTHD_fb0c5fa30bbd4c7882682a91cb46b014 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb0c5fa30bbd4c7882682a91cb46b014()
        {
          this.Initialize("LineCastOnlyTerrain", false, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("a", typeof (Educative.Point)),
            new ParameterDescriptor("b", typeof (Educative.Point))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).LineCastOnlyTerrain((Educative.Point) pars[0], (Educative.Point) pars[1]);
        }
      }

      private sealed class MTHD_7f31cbc7e9d042088ab4553f017a783f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f31cbc7e9d042088ab4553f017a783f()
        {
          this.Initialize("ShowInfo", false, new ParameterDescriptor[4]
          {
            new ParameterDescriptor("message", typeof (string)),
            new ParameterDescriptor("onContinue", typeof (bool), true, (object) new DefaultValue()),
            new ParameterDescriptor("pauseGame", typeof (bool), true, (object) new DefaultValue()),
            new ParameterDescriptor("unpauseGame", typeof (bool), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 1)
          {
            ((ContainerGame) obj).ShowInfo((string) pars[0]);
            return (object) DynValue.Void;
          }
          if (argscount <= 2)
          {
            ((ContainerGame) obj).ShowInfo((string) pars[0], (bool) pars[1]);
            return (object) DynValue.Void;
          }
          if (argscount <= 3)
          {
            ((ContainerGame) obj).ShowInfo((string) pars[0], (bool) pars[1], (bool) pars[2]);
            return (object) DynValue.Void;
          }
          ((ContainerGame) obj).ShowInfo((string) pars[0], (bool) pars[1], (bool) pars[2], (bool) pars[3]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_0b3707142b684de394d8bb859e286bb5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b3707142b684de394d8bb859e286bb5()
        {
          this.Initialize("hideInfo", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).hideInfo();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_a07b069f23494cfc9e836807903242f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a07b069f23494cfc9e836807903242f6()
        {
          this.Initialize("Talk", false, new ParameterDescriptor[3]
          {
            new ParameterDescriptor("what", typeof (ContainerCreature)),
            new ParameterDescriptor("message", typeof (string)),
            new ParameterDescriptor("options", typeof (TalkOptions), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 2)
          {
            ((ContainerGame) obj).Talk((ContainerCreature) pars[0], (string) pars[1]);
            return (object) DynValue.Void;
          }
          ((ContainerGame) obj).Talk((ContainerCreature) pars[0], (string) pars[1], (TalkOptions) pars[2]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_78ff30ccb8fe49938293cf7b89fe3325 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_78ff30ccb8fe49938293cf7b89fe3325()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_0f00dfb73ce74f0aaab532f8ebe00722 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f00dfb73ce74f0aaab532f8ebe00722()
        {
          this.Initialize("set_turn", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).turn = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_c2522751ee62427ebb05d6c0ee619b72 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c2522751ee62427ebb05d6c0ee619b72()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_7441a7a1ecf84dcf85a6c0df3bd6a770 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7441a7a1ecf84dcf85a6c0df3bd6a770()
        {
          this.Initialize("set_timeLimit", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).timeLimit = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_bb02275b56af4c5db9f094ad5f6a05db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb02275b56af4c5db9f094ad5f6a05db()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_8ee27b2a244c49488a64d5e6c9206fe9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ee27b2a244c49488a64d5e6c9206fe9()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_c0bf38bb95f44c65b40ceeeb2ad62fac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c0bf38bb95f44c65b40ceeeb2ad62fac()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_81b68d33a8774254bd3b713164c7512f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_81b68d33a8774254bd3b713164c7512f()
        {
          this.Initialize("random", false, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("lower", typeof (int)),
            new ParameterDescriptor("upper", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).random((int) pars[0], (int) pars[1]);
        }
      }

      private sealed class MTHD_0d1802adbf4245f1846c8874e14d9113 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d1802adbf4245f1846c8874e14d9113()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_8a49b4d9b5f94a14ac83d7ff953be4d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a49b4d9b5f94a14ac83d7ff953be4d9()
        {
          this.Initialize("set_winOnDeath", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).winOnDeath = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_de897fa2f1c94e9d90f15de4f11a65b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de897fa2f1c94e9d90f15de4f11a65b9()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_ace8f095d9d74c68b0c411ca33bb60c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ace8f095d9d74c68b0c411ca33bb60c7()
        {
          this.Initialize("set_allowMovement", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).allowMovement = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_d82b00d278f846c7a007e92c0576bba5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d82b00d278f846c7a007e92c0576bba5()
        {
          this.Initialize("get_allowMinionMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMinionMovement;
        }
      }

      private sealed class MTHD_f05b13ffef324e92b67d82219da57225 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f05b13ffef324e92b67d82219da57225()
        {
          this.Initialize("set_allowMinionMovement", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).allowMinionMovement = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_44c1b325185a4b0f956f4f3d80bf8bb8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_44c1b325185a4b0f956f4f3d80bf8bb8()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_e555e49a38d648978f759f8fceab1ca8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e555e49a38d648978f759f8fceab1ca8()
        {
          this.Initialize("set_allowInput", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).allowInput = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_52f0677cab8f4c20bd8738fc94816ec9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52f0677cab8f4c20bd8738fc94816ec9()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_eb192598f5554f0eb76d0d97f8ab8b8e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb192598f5554f0eb76d0d97f8ab8b8e()
        {
          this.Initialize("set_allowCallbacks", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).allowCallbacks = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_43e116c191004a1ab61cfc166510449c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_43e116c191004a1ab61cfc166510449c()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_cac6e2c8b2df4c87b49842ead3d66b2b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cac6e2c8b2df4c87b49842ead3d66b2b()
        {
          this.Initialize("set_allowSkipTurn", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).allowSkipTurn = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_0dfa56dcdef4467ba22b0f9ddebd50ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0dfa56dcdef4467ba22b0f9ddebd50ad()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_835c0ab70eb74a05a0ccb8f133c97ec0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_835c0ab70eb74a05a0ccb8f133c97ec0()
        {
          this.Initialize("set_terrainDestruction", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).terrainDestruction = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_809f77abb7f54cb383a305607d7d7501 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_809f77abb7f54cb383a305607d7d7501()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_b219d0e07c564d96af2ddd289dcbe767 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b219d0e07c564d96af2ddd289dcbe767()
        {
          this.Initialize("set_takeDamage", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).takeDamage = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_fa3f40ee5ccd449db887859c8df77b8a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa3f40ee5ccd449db887859c8df77b8a()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_22980e7407ad4013b5325d0d510019c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22980e7407ad4013b5325d0d510019c0()
        {
          this.Initialize("set_armageddon", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (MapEnum))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).armageddon = (MapEnum) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_c58b425c5ebd4e0e9577526cb374b020 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c58b425c5ebd4e0e9577526cb374b020()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_24ab9e0e785f4e83aa04c65b7eb17942 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24ab9e0e785f4e83aa04c65b7eb17942()
        {
          this.Initialize("set_armageddonTurn", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).armageddonTurn = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_46f499ab3b62428baad646324027f11c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_46f499ab3b62428baad646324027f11c()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_e5087dd4c98d4a06a84d10d4f8a36822 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e5087dd4c98d4a06a84d10d4f8a36822()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_d1bfc9fc7b0941689682383533db6574 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1bfc9fc7b0941689682383533db6574()
        {
          this.Initialize("set_paused", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).paused = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_05cae85f49284195ac88017ab2dd46f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_05cae85f49284195ac88017ab2dd46f7()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_64166c05595c4964a3eb76de3f892cef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_64166c05595c4964a3eb76de3f892cef()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_4be2d1d4dfe14ce2a28af5676fe9cb29 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4be2d1d4dfe14ce2a28af5676fe9cb29()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_567ad793a8d044bda28c5a7d926c5318 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_567ad793a8d044bda28c5a7d926c5318()
        {
          this.Initialize("set_gravity", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).gravity = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_a84e7468f5bf4fc586e23a79a4f7e5ef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a84e7468f5bf4fc586e23a79a4f7e5ef()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_8a323300c13a4b6183e59090ab509b9a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a323300c13a4b6183e59090ab509b9a()
        {
          this.Initialize("set_wind", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).wind = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_495f0b88d6a24dcb837da5886358221f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_495f0b88d6a24dcb837da5886358221f()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_bcb0abd64e65419d8e5a7c7a4bca2581 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bcb0abd64e65419d8e5a7c7a4bca2581()
        {
          this.Initialize("set_windDir", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).windDir = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_94cbe3afd32541ba8f430556bc1642d7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_94cbe3afd32541ba8f430556bc1642d7()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_100abfa96253419880dbf608b0b60ba4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_100abfa96253419880dbf608b0b60ba4()
        {
          this.Initialize("set_windPower", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).windPower = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_d040bc5a8de645d2b6e4d1aa410b0946 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d040bc5a8de645d2b6e4d1aa410b0946()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_2461cda3b2654c758592100ff0d0a774 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2461cda3b2654c758592100ff0d0a774()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_0dcd6b3db7de4ac1aec6b43f1c7bbee0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0dcd6b3db7de4ac1aec6b43f1c7bbee0()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_5ced087628424aa1b7f05a9bbb3ffb6b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ced087628424aa1b7f05a9bbb3ffb6b()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_ab205b99440a4e69a8d123b3e6f16a15 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab205b99440a4e69a8d123b3e6f16a15()
        {
          this.Initialize("worldToCanvas", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("p", typeof (Educative.Point))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).worldToCanvas((Educative.Point) pars[0]);
        }
      }

      private sealed class MTHD_4b4775148c4e44cab411d9b7f533d024 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b4775148c4e44cab411d9b7f533d024()
        {
          this.Initialize("canvasToWorld", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("p", typeof (Educative.Point))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).canvasToWorld((Educative.Point) pars[0]);
        }
      }

      private sealed class MTHD_69d4f4ccd8ca4844ba6e00fca8cacb9c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69d4f4ccd8ca4844ba6e00fca8cacb9c()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_4677a5c8b2db4b88ae1961326e119af7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4677a5c8b2db4b88ae1961326e119af7()
        {
          this.Initialize("set_cameraPosition", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (Educative.Point))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).cameraPosition = (Educative.Point) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_d39dacb05bb4421998852dbec2fe0d91 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d39dacb05bb4421998852dbec2fe0d91()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_6e726c989d0041ac985a0f3cb2420552 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e726c989d0041ac985a0f3cb2420552()
        {
          this.Initialize("set_cameraZoom", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).cameraZoom = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_9fdf52bb16aa41c8b8681519d98259ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9fdf52bb16aa41c8b8681519d98259ae()
        {
          this.Initialize("getMapPixel", false, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("x", typeof (int)),
            new ParameterDescriptor("y", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapPixel((int) pars[0], (int) pars[1]);
        }
      }

      private sealed class MTHD_b83bca3ff7f3465faae619bb0f2e2aaa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b83bca3ff7f3465faae619bb0f2e2aaa()
        {
          this.Initialize("setMapPixel", false, new ParameterDescriptor[3]
          {
            new ParameterDescriptor("x", typeof (int)),
            new ParameterDescriptor("y", typeof (int)),
            new ParameterDescriptor("c", typeof (LuaColor))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).setMapPixel((int) pars[0], (int) pars[1], (LuaColor) pars[2]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b0b26f20701643d0a604df7c3fa16096 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b0b26f20701643d0a604df7c3fa16096()
        {
          this.Initialize("Dispose", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ContainerGame.Dispose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_51251c6549b5432a9d021b9557cfd8ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_51251c6549b5432a9d021b9557cfd8ed()
        {
          this.Initialize("drawImage", false, new ParameterDescriptor[4]
          {
            new ParameterDescriptor("file", typeof (string)),
            new ParameterDescriptor("x", typeof (int)),
            new ParameterDescriptor("y", typeof (int)),
            new ParameterDescriptor("apply", typeof (bool), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 3)
          {
            ((ContainerGame) obj).drawImage((string) pars[0], (int) pars[1], (int) pars[2]);
            return (object) DynValue.Void;
          }
          ((ContainerGame) obj).drawImage((string) pars[0], (int) pars[1], (int) pars[2], (bool) pars[3]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_a7e000e71644451fa76e2bd075ec9691 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a7e000e71644451fa76e2bd075ec9691()
        {
          this.Initialize("drawRectangle", false, new ParameterDescriptor[5]
          {
            new ParameterDescriptor("x", typeof (int)),
            new ParameterDescriptor("y", typeof (int)),
            new ParameterDescriptor("width", typeof (int)),
            new ParameterDescriptor("height", typeof (int)),
            new ParameterDescriptor("c", typeof (LuaColor))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).drawRectangle((int) pars[0], (int) pars[1], (int) pars[2], (int) pars[3], (LuaColor) pars[4]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_390f13111293426e97fca377f2bfdf3b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_390f13111293426e97fca377f2bfdf3b()
        {
          this.Initialize("drawEllipseOutline", false, new ParameterDescriptor[6]
          {
            new ParameterDescriptor("x", typeof (int)),
            new ParameterDescriptor("y", typeof (int)),
            new ParameterDescriptor("radiusX", typeof (int)),
            new ParameterDescriptor("radiusY", typeof (int)),
            new ParameterDescriptor("outlineWidth", typeof (int)),
            new ParameterDescriptor("c", typeof (LuaColor))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).drawEllipseOutline((int) pars[0], (int) pars[1], (int) pars[2], (int) pars[3], (int) pars[4], (LuaColor) pars[5]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_cbefa8b761c944f48ab622a97eb80924 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cbefa8b761c944f48ab622a97eb80924()
        {
          this.Initialize("drawEllipse", false, new ParameterDescriptor[5]
          {
            new ParameterDescriptor("x", typeof (int)),
            new ParameterDescriptor("y", typeof (int)),
            new ParameterDescriptor("radiusX", typeof (int)),
            new ParameterDescriptor("radiusY", typeof (int)),
            new ParameterDescriptor("c", typeof (LuaColor))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).drawEllipse((int) pars[0], (int) pars[1], (int) pars[2], (int) pars[3], (LuaColor) pars[4]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ef347825d7194ed59205fdada82c3326 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef347825d7194ed59205fdada82c3326()
        {
          this.Initialize("blit", false, new ParameterDescriptor[4]
          {
            new ParameterDescriptor("ex", typeof (ExplosionCutout)),
            new ParameterDescriptor("point", typeof (Educative.Point)),
            new ParameterDescriptor("ignoreAlpha", typeof (bool), true, (object) new DefaultValue()),
            new ParameterDescriptor("apply", typeof (bool), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 2)
          {
            ((ContainerGame) obj).blit((ExplosionCutout) pars[0], (Educative.Point) pars[1]);
            return (object) DynValue.Void;
          }
          if (argscount <= 3)
          {
            ((ContainerGame) obj).blit((ExplosionCutout) pars[0], (Educative.Point) pars[1], (bool) pars[2]);
            return (object) DynValue.Void;
          }
          ((ContainerGame) obj).blit((ExplosionCutout) pars[0], (Educative.Point) pars[1], (bool) pars[2], (bool) pars[3]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f233b46dd9d442df922ec6021a1ccd59 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f233b46dd9d442df922ec6021a1ccd59()
        {
          this.Initialize("blitRotate", false, new ParameterDescriptor[5]
          {
            new ParameterDescriptor("ex", typeof (ExplosionCutout)),
            new ParameterDescriptor("point", typeof (Educative.Point)),
            new ParameterDescriptor("rotation", typeof (double), true, (object) new DefaultValue()),
            new ParameterDescriptor("inFront", typeof (bool), true, (object) new DefaultValue()),
            new ParameterDescriptor("apply", typeof (bool), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 2)
          {
            ((ContainerGame) obj).blitRotate((ExplosionCutout) pars[0], (Educative.Point) pars[1]);
            return (object) DynValue.Void;
          }
          if (argscount <= 3)
          {
            ((ContainerGame) obj).blitRotate((ExplosionCutout) pars[0], (Educative.Point) pars[1], (double) pars[2]);
            return (object) DynValue.Void;
          }
          if (argscount <= 4)
          {
            ((ContainerGame) obj).blitRotate((ExplosionCutout) pars[0], (Educative.Point) pars[1], (double) pars[2], (bool) pars[3]);
            return (object) DynValue.Void;
          }
          ((ContainerGame) obj).blitRotate((ExplosionCutout) pars[0], (Educative.Point) pars[1], (double) pars[2], (bool) pars[3], (bool) pars[4]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_13952cedb43a4f3aa99e63ab4d54616a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_13952cedb43a4f3aa99e63ab4d54616a()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_6550fda13dfd4d04871b720c5007b8f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6550fda13dfd4d04871b720c5007b8f9()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_d3f36e403ea74972b901fa8c2bfa3ee6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d3f36e403ea74972b901fa8c2bfa3ee6()
        {
          this.Initialize("set_allowBounce", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).allowBounce = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_32acb440b9444b9fab9c30e7114b6e0b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_32acb440b9444b9fab9c30e7114b6e0b()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_f0d9acdf6e8143328c4af022de62636e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f0d9acdf6e8143328c4af022de62636e()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ee64af1431294ef59d9909e858e40dc0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee64af1431294ef59d9909e858e40dc0()
        {
          this.Initialize("startCoroutine", false, new ParameterDescriptor[4]
          {
            new ParameterDescriptor("script", typeof (Script)),
            new ParameterDescriptor("f", typeof (DynValue)),
            new ParameterDescriptor("runAsCoroutine", typeof (bool), true, (object) new DefaultValue()),
            new ParameterDescriptor("seconds", typeof (float), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 2)
          {
            ((ContainerGame) obj).startCoroutine((Script) pars[0], (DynValue) pars[1]);
            return (object) DynValue.Void;
          }
          if (argscount <= 3)
          {
            ((ContainerGame) obj).startCoroutine((Script) pars[0], (DynValue) pars[1], (bool) pars[2]);
            return (object) DynValue.Void;
          }
          ((ContainerGame) obj).startCoroutine((Script) pars[0], (DynValue) pars[1], (bool) pars[2], (float) pars[3]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_7ae6ee3e41f0468fa61d7ec92f8ccd5d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ae6ee3e41f0468fa61d7ec92f8ccd5d()
        {
          this.Initialize("devCommand", false, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("s", typeof (string)),
            new ParameterDescriptor("p", typeof (Educative.Point), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 1)
          {
            ((ContainerGame) obj).devCommand((string) pars[0]);
            return (object) DynValue.Void;
          }
          ((ContainerGame) obj).devCommand((string) pars[0], (Educative.Point) pars[1]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_bc71a0fa9b724cdd97ec7c18d6ab0b0d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bc71a0fa9b724cdd97ec7c18d6ab0b0d()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_0bce63c9840140359f4a9a6d3f8990cc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0bce63c9840140359f4a9a6d3f8990cc()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_06e92bfbe5834a10b0b1cac178bdb44d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_06e92bfbe5834a10b0b1cac178bdb44d()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_3832c2d726f2469196e0d847056c8218 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3832c2d726f2469196e0d847056c8218()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ad110fda7cf44bdc9c4f81c99af0a5bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ad110fda7cf44bdc9c4f81c99af0a5bb()
        {
          this.Initialize("clearMap", false, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("newWidth", typeof (int), true, (object) new DefaultValue()),
            new ParameterDescriptor("newHeight", typeof (int), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 0)
          {
            ((ContainerGame) obj).clearMap();
            return (object) DynValue.Void;
          }
          if (argscount <= 1)
          {
            ((ContainerGame) obj).clearMap((int) pars[0]);
            return (object) DynValue.Void;
          }
          ((ContainerGame) obj).clearMap((int) pars[0], (int) pars[1]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_bacd61b453274662a6121ab2b2346d4f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bacd61b453274662a6121ab2b2346d4f()
        {
          this.Initialize("getSpell", true, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("name", typeof (string))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ContainerGame.getSpell((string) pars[0]);
        }
      }

      private sealed class MTHD_31ee846daf4a4c089d091a62ecd75d4c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_31ee846daf4a4c089d091a62ecd75d4c()
        {
          this.Initialize("getSpellEnum", true, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("name", typeof (string))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ContainerGame.getSpellEnum((string) pars[0]);
        }
      }

      private sealed class MTHD_14d0695863fd462b85e52fd5647a4006 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_14d0695863fd462b85e52fd5647a4006()
        {
          this.Initialize("getSpellName", true, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("id", typeof (SpellEnum))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ContainerGame.getSpellName((SpellEnum) pars[0]);
        }
      }

      private sealed class MTHD_b5c02f03cae44394ae5ab50bc7a7a97f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b5c02f03cae44394ae5ab50bc7a7a97f()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_38d82933004d4227b8fd7e4ac31d5233 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_38d82933004d4227b8fd7e4ac31d5233()
        {
          this.Initialize("getMapRealName", true, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("id", typeof (MapEnum))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ContainerGame.getMapRealName((MapEnum) pars[0]);
        }
      }

      private sealed class MTHD_70e76d39eb9546529cb6572babcef363 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70e76d39eb9546529cb6572babcef363()
        {
          this.Initialize("getMapShortName", true, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("id", typeof (MapEnum))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ContainerGame.getMapShortName((MapEnum) pars[0]);
        }
      }

      private sealed class MTHD_2786697f719d4848b3b869e02365b8b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2786697f719d4848b3b869e02365b8b3()
        {
          this.Initialize("getArmageddonName", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("id", typeof (MapEnum))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getArmageddonName((MapEnum) pars[0]);
        }
      }

      private sealed class MTHD_38d323975b194b2289274719d6419f38 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_38d323975b194b2289274719d6419f38()
        {
          this.Initialize("panCamera", false, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("point", typeof (Educative.Point)),
            new ParameterDescriptor("interuptable", typeof (bool), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 1)
          {
            ((ContainerGame) obj).panCamera((Educative.Point) pars[0]);
            return (object) DynValue.Void;
          }
          ((ContainerGame) obj).panCamera((Educative.Point) pars[0], (bool) pars[1]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b77270c48ee549aeb2817dbfc4bff354 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b77270c48ee549aeb2817dbfc4bff354()
        {
          this.Initialize("cameraFollow", false, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("creature", typeof (ContainerCreature)),
            new ParameterDescriptor("force", typeof (bool), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 1)
          {
            ((ContainerGame) obj).cameraFollow((ContainerCreature) pars[0]);
            return (object) DynValue.Void;
          }
          ((ContainerGame) obj).cameraFollow((ContainerCreature) pars[0], (bool) pars[1]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f9584d43030e44dd9d84171bd7659d31 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f9584d43030e44dd9d84171bd7659d31()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_06f2b6f8a25e42d3b654ae1d7de75738 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_06f2b6f8a25e42d3b654ae1d7de75738()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_7d876a53439b4218b3c14dcbc88b156a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7d876a53439b4218b3c14dcbc88b156a()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_619e18bb2542444d9120cd693826e451 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_619e18bb2542444d9120cd693826e451()
        {
          this.Initialize("createCreature", false, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("script", typeof (Script)),
            new ParameterDescriptor("summon", typeof (Summon))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).createCreature((Script) pars[0], (Summon) pars[1]);
        }
      }

      private sealed class MTHD_8aeae92975c14a4eba70df0f341ebe6c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8aeae92975c14a4eba70df0f341ebe6c()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_2b1213d0798345f3b996972cf427bfbd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b1213d0798345f3b996972cf427bfbd()
        {
          this.Initialize("createIndicator", false, new ParameterDescriptor[6]
          {
            new ParameterDescriptor("kind", typeof (IndicatorKind)),
            new ParameterDescriptor("point", typeof (Educative.Point)),
            new ParameterDescriptor("color", typeof (LuaColor)),
            new ParameterDescriptor("radius", typeof (double), true, (object) new DefaultValue()),
            new ParameterDescriptor("angle", typeof (double), true, (object) new DefaultValue()),
            new ParameterDescriptor("lifetime", typeof (double), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 3)
            return (object) ((ContainerGame) obj).createIndicator((IndicatorKind) pars[0], (Educative.Point) pars[1], (LuaColor) pars[2]);
          if (argscount <= 4)
            return (object) ((ContainerGame) obj).createIndicator((IndicatorKind) pars[0], (Educative.Point) pars[1], (LuaColor) pars[2], (double) pars[3]);
          return argscount <= 5 ? (object) ((ContainerGame) obj).createIndicator((IndicatorKind) pars[0], (Educative.Point) pars[1], (LuaColor) pars[2], (double) pars[3], (double) pars[4]) : (object) ((ContainerGame) obj).createIndicator((IndicatorKind) pars[0], (Educative.Point) pars[1], (LuaColor) pars[2], (double) pars[3], (double) pars[4], (double) pars[5]);
        }
      }

      private sealed class MTHD_ca349689734e4f7fbfefe105e9a9cce6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ca349689734e4f7fbfefe105e9a9cce6()
        {
          this.Initialize("createIndicator", false, new ParameterDescriptor[6]
          {
            new ParameterDescriptor("kind", typeof (IndicatorKind)),
            new ParameterDescriptor("point", typeof (Educative.Point)),
            new ParameterDescriptor("hexColor", typeof (string), true, (object) new DefaultValue()),
            new ParameterDescriptor("radius", typeof (double), true, (object) new DefaultValue()),
            new ParameterDescriptor("angle", typeof (double), true, (object) new DefaultValue()),
            new ParameterDescriptor("lifetime", typeof (double), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 2)
            return (object) ((ContainerGame) obj).createIndicator((IndicatorKind) pars[0], (Educative.Point) pars[1]);
          if (argscount <= 3)
            return (object) ((ContainerGame) obj).createIndicator((IndicatorKind) pars[0], (Educative.Point) pars[1], (string) pars[2]);
          if (argscount <= 4)
            return (object) ((ContainerGame) obj).createIndicator((IndicatorKind) pars[0], (Educative.Point) pars[1], (string) pars[2], (double) pars[3]);
          return argscount <= 5 ? (object) ((ContainerGame) obj).createIndicator((IndicatorKind) pars[0], (Educative.Point) pars[1], (string) pars[2], (double) pars[3], (double) pars[4]) : (object) ((ContainerGame) obj).createIndicator((IndicatorKind) pars[0], (Educative.Point) pars[1], (string) pars[2], (double) pars[3], (double) pars[4], (double) pars[5]);
        }
      }

      private sealed class MTHD_6affefeb41194d16a51401d9f86b15f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6affefeb41194d16a51401d9f86b15f7()
        {
          this.Initialize("getKeyBinds", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("key", typeof (KeyBinds))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getKeyBinds((KeyBinds) pars[0]);
        }
      }

      private sealed class MTHD_220785592f8740d8af2e40b727a90e2b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_220785592f8740d8af2e40b727a90e2b()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.Equals(pars[0]);
        }
      }

      private sealed class MTHD_2596539e0c0744dd89b03afbb1206941 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2596539e0c0744dd89b03afbb1206941()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_6d0cd82ee7a8475c971ac90572a1b3e4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d0cd82ee7a8475c971ac90572a1b3e4()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_f63b2fa3309f4cd99863cab330d0471f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f63b2fa3309f4cd99863cab330d0471f()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_f9a9ea8cc9d343ceb1b3c0a42fb08001 : HardwiredMemberDescriptor
      {
        internal PROP_f9a9ea8cc9d343ceb1b3c0a42fb08001()
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

      private sealed class PROP_469a189023d8413da51a296246522e8e : HardwiredMemberDescriptor
      {
        internal PROP_469a189023d8413da51a296246522e8e()
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

      private sealed class PROP_ce79572cac304e3e8e65e6244bd65a8b : HardwiredMemberDescriptor
      {
        internal PROP_ce79572cac304e3e8e65e6244bd65a8b()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_56c34ea563b84c60bf37954fea213b80 : HardwiredMemberDescriptor
      {
        internal PROP_56c34ea563b84c60bf37954fea213b80()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_e36e23711438433ea5296a442a5d73de : HardwiredMemberDescriptor
      {
        internal PROP_e36e23711438433ea5296a442a5d73de()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_1c3115158bb0491fa3a642fdc0977761 : HardwiredMemberDescriptor
      {
        internal PROP_1c3115158bb0491fa3a642fdc0977761()
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

      private sealed class PROP_b7c3caa247fa42c694c772edea62d9ae : HardwiredMemberDescriptor
      {
        internal PROP_b7c3caa247fa42c694c772edea62d9ae()
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

      private sealed class PROP_d2697cd33ebc473b91e2ff5d0b46a991 : HardwiredMemberDescriptor
      {
        internal PROP_d2697cd33ebc473b91e2ff5d0b46a991()
          : base(typeof (bool), "allowMinionMovement", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).allowMinionMovement;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerGame) obj).allowMinionMovement = (bool) value;
        }
      }

      private sealed class PROP_7c5cbb4aa0e84a408a5e34dfc8202960 : HardwiredMemberDescriptor
      {
        internal PROP_7c5cbb4aa0e84a408a5e34dfc8202960()
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

      private sealed class PROP_8ac44cac0058445095ce32d0762fd3ea : HardwiredMemberDescriptor
      {
        internal PROP_8ac44cac0058445095ce32d0762fd3ea()
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

      private sealed class PROP_e4968523e00c4ef0ba5007bbdc9c6921 : HardwiredMemberDescriptor
      {
        internal PROP_e4968523e00c4ef0ba5007bbdc9c6921()
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

      private sealed class PROP_dcc1f8f7e1204689aa78bdadbe82e81c : HardwiredMemberDescriptor
      {
        internal PROP_dcc1f8f7e1204689aa78bdadbe82e81c()
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

      private sealed class PROP_9733a03829bf4394a2f5572ec3a65c3b : HardwiredMemberDescriptor
      {
        internal PROP_9733a03829bf4394a2f5572ec3a65c3b()
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

      private sealed class PROP_8c864c98dc6e45259394a142e2450f64 : HardwiredMemberDescriptor
      {
        internal PROP_8c864c98dc6e45259394a142e2450f64()
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

      private sealed class PROP_7f6c8522ff894e78a171099ef0439096 : HardwiredMemberDescriptor
      {
        internal PROP_7f6c8522ff894e78a171099ef0439096()
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

      private sealed class PROP_da5d8f4ba2734122a442970d5cd88b77 : HardwiredMemberDescriptor
      {
        internal PROP_da5d8f4ba2734122a442970d5cd88b77()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_5503b6c8ca5d443b898dd8bc3a89665b : HardwiredMemberDescriptor
      {
        internal PROP_5503b6c8ca5d443b898dd8bc3a89665b()
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

      private sealed class PROP_ef049e026f824f38bfa11ef0f641d53c : HardwiredMemberDescriptor
      {
        internal PROP_ef049e026f824f38bfa11ef0f641d53c()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_beb83664110b45d2951b64a7e8b83c6c : HardwiredMemberDescriptor
      {
        internal PROP_beb83664110b45d2951b64a7e8b83c6c()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_3f3b7f3052e64c94886b66697798ae07 : HardwiredMemberDescriptor
      {
        internal PROP_3f3b7f3052e64c94886b66697798ae07()
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

      private sealed class PROP_8a30093d52ba4cfdbde8f8187b56d32e : HardwiredMemberDescriptor
      {
        internal PROP_8a30093d52ba4cfdbde8f8187b56d32e()
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

      private sealed class PROP_acb68287fb3c42a4bba95ecc26d43e3b : HardwiredMemberDescriptor
      {
        internal PROP_acb68287fb3c42a4bba95ecc26d43e3b()
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

      private sealed class PROP_1eb00e5b8f8c4b0ea55b75e14216a096 : HardwiredMemberDescriptor
      {
        internal PROP_1eb00e5b8f8c4b0ea55b75e14216a096()
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

      private sealed class PROP_2f3a9989fda34e51b8e6962579c51326 : HardwiredMemberDescriptor
      {
        internal PROP_2f3a9989fda34e51b8e6962579c51326()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_24eca7af8efb47dcb0bdb86739f440ce : HardwiredMemberDescriptor
      {
        internal PROP_24eca7af8efb47dcb0bdb86739f440ce()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_a67bcb559f0a4f04ad4c3590d55aba52 : HardwiredMemberDescriptor
      {
        internal PROP_a67bcb559f0a4f04ad4c3590d55aba52()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_297614ad860f4aadbe5e2ccff56f8ea4 : HardwiredMemberDescriptor
      {
        internal PROP_297614ad860f4aadbe5e2ccff56f8ea4()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_19306ef3691d4e20bd2eca958903bde0 : HardwiredMemberDescriptor
      {
        internal PROP_19306ef3691d4e20bd2eca958903bde0()
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

      private sealed class PROP_e7024fdf447b42279332f95f81de5f29 : HardwiredMemberDescriptor
      {
        internal PROP_e7024fdf447b42279332f95f81de5f29()
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

      private sealed class PROP_769648b7ea5f445bac874c515455dac9 : HardwiredMemberDescriptor
      {
        internal PROP_769648b7ea5f445bac874c515455dac9()
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

      private sealed class PROP_2c5a156bcd86413db9e436d86a6cf3dc : HardwiredMemberDescriptor
      {
        internal PROP_2c5a156bcd86413db9e436d86a6cf3dc()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_bd4c01bd6deb414f9f1f6bc1f942ea1a : HardwiredMemberDescriptor
      {
        internal PROP_bd4c01bd6deb414f9f1f6bc1f942ea1a()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_c556e945aac943c2986ce8ed16eccf96 : HardwiredMemberDescriptor
      {
        internal PROP_c556e945aac943c2986ce8ed16eccf96()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_b0b102743061489c91fdc5553f2049db : HardwiredUserDataDescriptor
    {
      internal TYPE_b0b102743061489c91fdc5553f2049db()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b0b102743061489c91fdc5553f2049db.MTHD_d6819d8d18f94803ada0c7488454caa0()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b0b102743061489c91fdc5553f2049db.MTHD_2b767002cbc64ade822fafa5e5fdc441()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b0b102743061489c91fdc5553f2049db.MTHD_2b391af9d7e549699ccd0ee1b0301339()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b0b102743061489c91fdc5553f2049db.MTHD_717bd28f8327496482c3abddaeaab049()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b0b102743061489c91fdc5553f2049db.MTHD_352a356a7b3046beae2db4b40933eb92()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b0b102743061489c91fdc5553f2049db.MTHD_8ada1f5e9ef5430c90526b1981576469()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b0b102743061489c91fdc5553f2049db.MTHD_687908c8a53a4395a6e66a611223f3fe()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b0b102743061489c91fdc5553f2049db.MTHD_7795ed519b2d4c13b856626f48fa1c87()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b0b102743061489c91fdc5553f2049db.MTHD_bd3e9f35effa42549291460debb64f06()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b0b102743061489c91fdc5553f2049db.MTHD_f7660b09677a4a9cb38018974accfe49()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b0b102743061489c91fdc5553f2049db.MTHD_925e1908ad08467a8f893908ca0d3883()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b0b102743061489c91fdc5553f2049db.MTHD_f321198805cf4831b5089c6959eebbd1()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_b0b102743061489c91fdc5553f2049db.PROP_6ba8f5d7257941b6a6e8c5231fc71772());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_b0b102743061489c91fdc5553f2049db.PROP_2ad2da1e6a294e4895cc2a4e17c905b0());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_b0b102743061489c91fdc5553f2049db.PROP_102babc77d4e410e9f6c126bc9a362b8());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_b0b102743061489c91fdc5553f2049db.PROP_40947b1a9ecf4d209d301bdeae19f03c());
      }

      private sealed class MTHD_d6819d8d18f94803ada0c7488454caa0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6819d8d18f94803ada0c7488454caa0()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_2b767002cbc64ade822fafa5e5fdc441 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b767002cbc64ade822fafa5e5fdc441()
        {
          this.Initialize("set_localTurn", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerPlayer) obj).localTurn = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_2b391af9d7e549699ccd0ee1b0301339 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b391af9d7e549699ccd0ee1b0301339()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_717bd28f8327496482c3abddaeaab049 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_717bd28f8327496482c3abddaeaab049()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_352a356a7b3046beae2db4b40933eb92 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_352a356a7b3046beae2db4b40933eb92()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_8ada1f5e9ef5430c90526b1981576469 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ada1f5e9ef5430c90526b1981576469()
        {
          this.Initialize("getCreatures", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("script", typeof (Script))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getCreatures((Script) pars[0]);
        }
      }

      private sealed class MTHD_687908c8a53a4395a6e66a611223f3fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_687908c8a53a4395a6e66a611223f3fe()
        {
          this.Initialize("getCreature", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("index", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getCreature((int) pars[0]);
        }
      }

      private sealed class MTHD_7795ed519b2d4c13b856626f48fa1c87 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7795ed519b2d4c13b856626f48fa1c87()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_bd3e9f35effa42549291460debb64f06 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd3e9f35effa42549291460debb64f06()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_f7660b09677a4a9cb38018974accfe49 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7660b09677a4a9cb38018974accfe49()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.Equals(pars[0]);
        }
      }

      private sealed class MTHD_925e1908ad08467a8f893908ca0d3883 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_925e1908ad08467a8f893908ca0d3883()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_f321198805cf4831b5089c6959eebbd1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f321198805cf4831b5089c6959eebbd1()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_6ba8f5d7257941b6a6e8c5231fc71772 : HardwiredMemberDescriptor
      {
        internal PROP_6ba8f5d7257941b6a6e8c5231fc71772()
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

      private sealed class PROP_2ad2da1e6a294e4895cc2a4e17c905b0 : HardwiredMemberDescriptor
      {
        internal PROP_2ad2da1e6a294e4895cc2a4e17c905b0()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_102babc77d4e410e9f6c126bc9a362b8 : HardwiredMemberDescriptor
      {
        internal PROP_102babc77d4e410e9f6c126bc9a362b8()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_40947b1a9ecf4d209d301bdeae19f03c : HardwiredMemberDescriptor
      {
        internal PROP_40947b1a9ecf4d209d301bdeae19f03c()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_65168de9aeae49b8aeb0152434d0d237 : HardwiredUserDataDescriptor
    {
      internal TYPE_65168de9aeae49b8aeb0152434d0d237()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_b531b8ca09f24ab3beb58b341b1ad614()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_bfb652b149d34e0c8aa225f8201ec8ba()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_6f143db9ee6b4b24a45e99b591aa25fa()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_8140ecfd2cbc417da353dd2f86e8474c()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_afe6e1ebad1f478b9d85a3abb88de0a9()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_ae9c80bafaed4a0fa0aab69ac4923ce9()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_4c15e90d334943caa460b7efaed2c795()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_9ebdf62dff7c49cabb28e357e0972b48()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_57887c5d43d5405a92d42ba9b1afd204()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_eb73605d11a14265a2fbf87444812b0e()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_66c67eabcdce4ace99508b6be4b6d7c8()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_3e19c2e2cc3a450692fe7989f5db4da0()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_f063922a3a744b2dbe2ab429a45e4656()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_607d9abb1116488698e8139709959ac0()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_00913af80d9149f4aec71a88d3053074()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_44477c77801040538a4b023746fdf621()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_76af56e2227740f89f67ef4283b9c524()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_a78759870cb645e6904603eae41eed04()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_3e3a7e7864774ea38d1b6b2ba8be1050()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_d8850dcb93d94ae49d69b983bf376265()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_4feecc90398c4646991e48cf33737c7a()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_ee225f03e3fe446bb4f543c1e058ba77()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_0c53b15a5bc34c2e97cac06df4e69d27()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_5771c26372284b2e99061874b1623550()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_bc009549714049a8a60992c749936cc6()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_cd723f08fc934136a103ec7503ea96b4()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_370059dcfa1b47edaf5593b88a06265f()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_f590e77cc9ea467f9527bc13916ca0f3()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_4edfa21be8ec4043883e37da51edb9bb()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_4faba66b2dd5473c8c936d39649a3641()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_77fdd9217f2b4aeea6a4f71fcfab4f0c()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_c50ea9fd0c3e492cabce15223417c335()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_459ce96b7e8c40f8bf37d76ba68b2d21()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_0da7b63534944e97ac922b6da489db87()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_774e3482c20d4b6dac3041084d2d5ce0()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_0a10bf325bc54347807f616c32c5a502()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_697eeba09dac462c9f2e3ef2b499f466()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_e45396c8124544e697ac22cfd304729b()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_99051d84851a413397e8fe481c27aa55()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_f4d03dab15eb475babc1d4ef430e712f()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_5c4df22ba5994e48ac4bce5e94759406()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_586b9c7dbf954402a4aaee460dec73bd()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_7956d51d58a5456f87d7e7603a954776()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_94e3cbf1d32c4c4989eb2576d868620f()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_33a54205664d4f5eb12be0dab0c2413c()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_e22f085bd41041bb93e7d6fcb1366396()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_96238b9b622b40f6ae67aed3e933300a()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_974dcf38a5064b8690732cd6f02540f6()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_cae19ba72de84f8cbd06f62459e263bf()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_f852e6bd1db643738acded0d9367e345()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_983a197a2218475d97d37855e6c4d733()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_96b0f1f9d1c64f769014ff2d1f991205()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_902ecfdeee6c45d28acbdfe2cfa67997()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_d50f546174564c5d92e38c0386cb36f2()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_bb4d5a1576b7439aaac3691f53a91c6f()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_db957ec6b837421eba677151cf406c45()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_958c0302316e4fd1b87caaec81f8ef24()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_696d160f3e3c4d6b83ef76ed4a4a681d()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_a104dbe816264155bcfbe99d61cf2663()
        }));
        this.AddMember("getDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_6afbccb033f5467597aaca2b6633349e()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_0381502da2544b7eb877c3944b98dc1f()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_9d100b3569d54ce2b133f7bf332008bd()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_f34959e3da56420bab1704aa2c556d66()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_1203303e13ee484fad7ee6bef9968eba()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_517680c1a55e45aab2349065cd2bba92(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_591f5738a9a34abca9cf045176bd9b1c()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_b5d5b601a7c34497a9d9eb57e3ab1b4e(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_9297b05041e443dc9c7247b24697c146()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_2fb88e1177894f99b424fa22799c23c6()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_731ae51c2d404d95b338f94d95b62274()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_7f94fa42ab174a0fa1c19038e802f484(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_c1670192d341488d8507bcf707b52afd()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_7f6f580e2e5c4ffa8baeef7cf031ffb8()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_03115c8a9ff849769576095c6bd76320()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_475edc2c971c4047915940020e56cfb7()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_fd91e8cef2044e7e8de7af037f07f991()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_402ef6a2023d4c3b9bde9886e4736bad()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_8546c3d438714113aa72d5fe77ead332()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_a3e0a972c4b34d77b00fa268445ceaa9()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_1bbfc142050349a2a49458452ff24f53()
        }));
        this.AddMember("angleToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("angleToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_71e0a6c15d3a4d7ea14d49e1372d9cab()
        }));
        this.AddMember("powerToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("powerToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_091e8b37d0914ee9ad27a6135a2ae90d()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_2e105d08d7c24e2ab9a743b20fb44217(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_66d9f7273ca9441caa1ece294f96c1c2()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_b238f8249fa04715ad1f11d021eeaf21(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_dc01e2b5e6b14738b80d1fce78e59624()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_6bfdf208493d4d54b642df61de8e1f5c()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_a6a0d4bf43af42efb723d8ce47ea18f2()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_c1584321fd6446a6915386c6e03e370e()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_bdd54b1019b647d29a2b0de9b3ce9d3a()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_efd16f5300d442bdb648b1f6a1b72dec()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.MTHD_2528fa92d8dd4661b0c4a909b2d73e4d()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_9e127d08b1544d569c5840f2ff7080f4());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_56eb2998a72f470faecf8dcee84f801e());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_eda2f7ea84ef42f3af7cdc6c60b92893());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_57191c28bcbf4aa4b75c8e67b39470a0());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_7883cbb9677040e99e9faf7c193ce4e1());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_e976fb52f24f4dac9a0df4b12620c638());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_b6e90ff9f7b9443abe64a5c7bf0906ba());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_39cbe88a5a3e4fe9a233dddd3bc5072c());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_5fbe1e85a54f4ad58214409a58a26995());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_cb8df41230fc40ef860672ded9ea5d96());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_b8fe4a19169e4c678a69f9f7675e0dc1());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_fb465cc776474df4acecdd7c977f3f88());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_f459c96f1f2049ffa3b691e82066922f());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_a9f289cdd8984699b98a97f13a2e6b84());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_2e82531e76f94809bda342a0c337421c());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_4f4d12fb2dd642dd96931ec05f3c4673());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_623b32bc12234bc898f85684dd0f3b6b());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_dab8780851104558af6d3686de2ec057());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_ce4ba3b8e10f4e5ca0acb97f40984824());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_c7eae8f5b67449f1ab798c0bc9435e87());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_39fded1714af453b85fbe6921f830c73());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_fbb131e9c7914cfcb0e527b63eb1e33c());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_8edb8af785a9440b89752eb222838c37());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_1932e0cbab644db0bc2259c037be34d7());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_db583874c8d642a7a8fb4781eec6928b());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_b14061d309d74b2a9b4dbdc2b3928c8f());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_27e727857b314ba6bbf8808f3e1c615c());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_dd8eb5a3fae143dd905abf93b35f6321());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_ece45b8336914c239bae85a22aff89c7());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_c05ed3babf7747fab9289332d09fb5f3());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_8dfde15fcc40417da7179b19f2626a66());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_5ca6603c305c4a3e92deaf2295af4004());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_65168de9aeae49b8aeb0152434d0d237.PROP_1cde8a1385e244f7b9c3836ead14d14a());
      }

      private sealed class MTHD_b531b8ca09f24ab3beb58b341b1ad614 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b531b8ca09f24ab3beb58b341b1ad614()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_bfb652b149d34e0c8aa225f8201ec8ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bfb652b149d34e0c8aa225f8201ec8ba()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_6f143db9ee6b4b24a45e99b591aa25fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6f143db9ee6b4b24a45e99b591aa25fa()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_8140ecfd2cbc417da353dd2f86e8474c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8140ecfd2cbc417da353dd2f86e8474c()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_afe6e1ebad1f478b9d85a3abb88de0a9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_afe6e1ebad1f478b9d85a3abb88de0a9()
        {
          this.Initialize("set_health", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).health = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_ae9c80bafaed4a0fa0aab69ac4923ce9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae9c80bafaed4a0fa0aab69ac4923ce9()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_4c15e90d334943caa460b7efaed2c795 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c15e90d334943caa460b7efaed2c795()
        {
          this.Initialize("set_maxHealth", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).maxHealth = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_9ebdf62dff7c49cabb28e357e0972b48 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ebdf62dff7c49cabb28e357e0972b48()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_57887c5d43d5405a92d42ba9b1afd204 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57887c5d43d5405a92d42ba9b1afd204()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_eb73605d11a14265a2fbf87444812b0e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb73605d11a14265a2fbf87444812b0e()
        {
          this.Initialize("set_shield", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).shield = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_66c67eabcdce4ace99508b6be4b6d7c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_66c67eabcdce4ace99508b6be4b6d7c8()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_3e19c2e2cc3a450692fe7989f5db4da0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e19c2e2cc3a450692fe7989f5db4da0()
        {
          this.Initialize("set_x", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).x = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_f063922a3a744b2dbe2ab429a45e4656 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f063922a3a744b2dbe2ab429a45e4656()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_607d9abb1116488698e8139709959ac0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_607d9abb1116488698e8139709959ac0()
        {
          this.Initialize("set_y", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).y = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_00913af80d9149f4aec71a88d3053074 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_00913af80d9149f4aec71a88d3053074()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_44477c77801040538a4b023746fdf621 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_44477c77801040538a4b023746fdf621()
        {
          this.Initialize("set_position", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (Educative.Point))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).position = (Educative.Point) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_76af56e2227740f89f67ef4283b9c524 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76af56e2227740f89f67ef4283b9c524()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_a78759870cb645e6904603eae41eed04 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a78759870cb645e6904603eae41eed04()
        {
          this.Initialize("set_parent", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (ContainerPlayer))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).parent = (ContainerPlayer) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_3e3a7e7864774ea38d1b6b2ba8be1050 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e3a7e7864774ea38d1b6b2ba8be1050()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_d8850dcb93d94ae49d69b983bf376265 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8850dcb93d94ae49d69b983bf376265()
        {
          this.Initialize("set_weight", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).weight = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_4feecc90398c4646991e48cf33737c7a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4feecc90398c4646991e48cf33737c7a()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_ee225f03e3fe446bb4f543c1e058ba77 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee225f03e3fe446bb4f543c1e058ba77()
        {
          this.Initialize("set_radius", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).radius = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_0c53b15a5bc34c2e97cac06df4e69d27 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c53b15a5bc34c2e97cac06df4e69d27()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_5771c26372284b2e99061874b1623550 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5771c26372284b2e99061874b1623550()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_bc009549714049a8a60992c749936cc6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bc009549714049a8a60992c749936cc6()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_cd723f08fc934136a103ec7503ea96b4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd723f08fc934136a103ec7503ea96b4()
        {
          this.Initialize("set_stunned", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).stunned = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_370059dcfa1b47edaf5593b88a06265f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_370059dcfa1b47edaf5593b88a06265f()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_f590e77cc9ea467f9527bc13916ca0f3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f590e77cc9ea467f9527bc13916ca0f3()
        {
          this.Initialize("set_superStunned", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).superStunned = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_4edfa21be8ec4043883e37da51edb9bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4edfa21be8ec4043883e37da51edb9bb()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_4faba66b2dd5473c8c936d39649a3641 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4faba66b2dd5473c8c936d39649a3641()
        {
          this.Initialize("set_waterWalking", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).waterWalking = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_77fdd9217f2b4aeea6a4f71fcfab4f0c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_77fdd9217f2b4aeea6a4f71fcfab4f0c()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_c50ea9fd0c3e492cabce15223417c335 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c50ea9fd0c3e492cabce15223417c335()
        {
          this.Initialize("set_frostWalking", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).frostWalking = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_459ce96b7e8c40f8bf37d76ba68b2d21 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_459ce96b7e8c40f8bf37d76ba68b2d21()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_0da7b63534944e97ac922b6da489db87 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0da7b63534944e97ac922b6da489db87()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_774e3482c20d4b6dac3041084d2d5ce0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_774e3482c20d4b6dac3041084d2d5ce0()
        {
          this.Initialize("set_diesInWater", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).diesInWater = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_0a10bf325bc54347807f616c32c5a502 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0a10bf325bc54347807f616c32c5a502()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_697eeba09dac462c9f2e3ef2b499f466 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_697eeba09dac462c9f2e3ef2b499f466()
        {
          this.Initialize("set_type", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (CreatureType))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).type = (CreatureType) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_e45396c8124544e697ac22cfd304729b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e45396c8124544e697ac22cfd304729b()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_99051d84851a413397e8fe481c27aa55 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99051d84851a413397e8fe481c27aa55()
        {
          this.Initialize("set_race", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (CreatureRace))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).race = (CreatureRace) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_f4d03dab15eb475babc1d4ef430e712f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4d03dab15eb475babc1d4ef430e712f()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_5c4df22ba5994e48ac4bce5e94759406 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c4df22ba5994e48ac4bce5e94759406()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_586b9c7dbf954402a4aaee460dec73bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_586b9c7dbf954402a4aaee460dec73bd()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_7956d51d58a5456f87d7e7603a954776 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7956d51d58a5456f87d7e7603a954776()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_94e3cbf1d32c4c4989eb2576d868620f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_94e3cbf1d32c4c4989eb2576d868620f()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_33a54205664d4f5eb12be0dab0c2413c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_33a54205664d4f5eb12be0dab0c2413c()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_e22f085bd41041bb93e7d6fcb1366396 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e22f085bd41041bb93e7d6fcb1366396()
        {
          this.Initialize("set_isFlying", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).isFlying = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_96238b9b622b40f6ae67aed3e933300a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_96238b9b622b40f6ae67aed3e933300a()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_974dcf38a5064b8690732cd6f02540f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_974dcf38a5064b8690732cd6f02540f6()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_cae19ba72de84f8cbd06f62459e263bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cae19ba72de84f8cbd06f62459e263bf()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_f852e6bd1db643738acded0d9367e345 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f852e6bd1db643738acded0d9367e345()
        {
          this.Initialize("set_arcaneMonster", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).arcaneMonster = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_983a197a2218475d97d37855e6c4d733 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_983a197a2218475d97d37855e6c4d733()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_96b0f1f9d1c64f769014ff2d1f991205 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_96b0f1f9d1c64f769014ff2d1f991205()
        {
          this.Initialize("set_takeDamage", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).takeDamage = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_902ecfdeee6c45d28acbdfe2cfa67997 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_902ecfdeee6c45d28acbdfe2cfa67997()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_d50f546174564c5d92e38c0386cb36f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d50f546174564c5d92e38c0386cb36f2()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_bb4d5a1576b7439aaac3691f53a91c6f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb4d5a1576b7439aaac3691f53a91c6f()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_db957ec6b837421eba677151cf406c45 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db957ec6b837421eba677151cf406c45()
        {
          this.Initialize("LongJump", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("dir", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).LongJump((int) pars[0]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_958c0302316e4fd1b87caaec81f8ef24 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_958c0302316e4fd1b87caaec81f8ef24()
        {
          this.Initialize("HighJump", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("dir", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).HighJump((int) pars[0]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_696d160f3e3c4d6b83ef76ed4a4a681d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_696d160f3e3c4d6b83ef76ed4a4a681d()
        {
          this.Initialize("Walk", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("dir", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).Walk((int) pars[0]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_a104dbe816264155bcfbe99d61cf2663 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a104dbe816264155bcfbe99d61cf2663()
        {
          this.Initialize("setDirection", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("dir", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).setDirection((int) pars[0]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_6afbccb033f5467597aaca2b6633349e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6afbccb033f5467597aaca2b6633349e()
        {
          this.Initialize("getDirection", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getDirection();
        }
      }

      private sealed class MTHD_0381502da2544b7eb877c3944b98dc1f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0381502da2544b7eb877c3944b98dc1f()
        {
          this.Initialize("getFamiliarLevel", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("book", typeof (BookOf))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getFamiliarLevel((BookOf) pars[0]);
        }
      }

      private sealed class MTHD_9d100b3569d54ce2b133f7bf332008bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d100b3569d54ce2b133f7bf332008bd()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_f34959e3da56420bab1704aa2c556d66 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f34959e3da56420bab1704aa2c556d66()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_1203303e13ee484fad7ee6bef9968eba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1203303e13ee484fad7ee6bef9968eba()
        {
          this.Initialize("increaseFamiliarLevel", false, new ParameterDescriptor[3]
          {
            new ParameterDescriptor("book", typeof (BookOf), true, (object) new DefaultValue()),
            new ParameterDescriptor("dealDmg", typeof (bool), true, (object) new DefaultValue()),
            new ParameterDescriptor("capAt5", typeof (bool), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 0)
          {
            ((ContainerCreature) obj).increaseFamiliarLevel();
            return (object) DynValue.Void;
          }
          if (argscount <= 1)
          {
            ((ContainerCreature) obj).increaseFamiliarLevel((BookOf) pars[0]);
            return (object) DynValue.Void;
          }
          if (argscount <= 2)
          {
            ((ContainerCreature) obj).increaseFamiliarLevel((BookOf) pars[0], (bool) pars[1]);
            return (object) DynValue.Void;
          }
          ((ContainerCreature) obj).increaseFamiliarLevel((BookOf) pars[0], (bool) pars[1], (bool) pars[2]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_517680c1a55e45aab2349065cd2bba92 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_517680c1a55e45aab2349065cd2bba92()
        {
          this.Initialize("inside", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("a", typeof (ContainerIndicator))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inside((ContainerIndicator) pars[0]);
        }
      }

      private sealed class MTHD_591f5738a9a34abca9cf045176bd9b1c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_591f5738a9a34abca9cf045176bd9b1c()
        {
          this.Initialize("inside", false, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("a", typeof (Educative.Point)),
            new ParameterDescriptor("radius", typeof (double))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inside((Educative.Point) pars[0], (double) pars[1]);
        }
      }

      private sealed class MTHD_b5d5b601a7c34497a9d9eb57e3ab1b4e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b5d5b601a7c34497a9d9eb57e3ab1b4e()
        {
          this.Initialize("overlap", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("a", typeof (ContainerIndicator))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).overlap((ContainerIndicator) pars[0]);
        }
      }

      private sealed class MTHD_9297b05041e443dc9c7247b24697c146 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9297b05041e443dc9c7247b24697c146()
        {
          this.Initialize("overlap", false, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("a", typeof (Educative.Point)),
            new ParameterDescriptor("radius", typeof (double), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return argscount <= 1 ? (object) ((ContainerCreature) obj).overlap((Educative.Point) pars[0]) : (object) ((ContainerCreature) obj).overlap((Educative.Point) pars[0], (double) pars[1]);
        }
      }

      private sealed class MTHD_2fb88e1177894f99b424fa22799c23c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2fb88e1177894f99b424fa22799c23c6()
        {
          this.Initialize("die", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("playSound", typeof (bool), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 0)
          {
            ((ContainerCreature) obj).die();
            return (object) DynValue.Void;
          }
          ((ContainerCreature) obj).die((bool) pars[0]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_731ae51c2d404d95b338f94d95b62274 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_731ae51c2d404d95b338f94d95b62274()
        {
          this.Initialize("addSpell", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("s", typeof (object))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).addSpell(pars[0]);
        }
      }

      private sealed class MTHD_7f94fa42ab174a0fa1c19038e802f484 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f94fa42ab174a0fa1c19038e802f484()
        {
          this.Initialize("removeSpell", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("s", typeof (object))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).removeSpell(pars[0]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c1670192d341488d8507bcf707b52afd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c1670192d341488d8507bcf707b52afd()
        {
          this.Initialize("removeSpell", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("spell", typeof (ContainerSpell))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerCreature) obj).removeSpell((ContainerSpell) pars[0]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_7f6f580e2e5c4ffa8baeef7cf031ffb8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f6f580e2e5c4ffa8baeef7cf031ffb8()
        {
          this.Initialize("getSpells", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("script", typeof (Script))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpells((Script) pars[0]);
        }
      }

      private sealed class MTHD_03115c8a9ff849769576095c6bd76320 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_03115c8a9ff849769576095c6bd76320()
        {
          this.Initialize("getSpell", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("spellObj", typeof (object))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpell(pars[0]);
        }
      }

      private sealed class MTHD_475edc2c971c4047915940020e56cfb7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_475edc2c971c4047915940020e56cfb7()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_fd91e8cef2044e7e8de7af037f07f991 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd91e8cef2044e7e8de7af037f07f991()
        {
          this.Initialize("castedCount", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("spellID", typeof (SpellEnum))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCount((SpellEnum) pars[0]);
        }
      }

      private sealed class MTHD_402ef6a2023d4c3b9bde9886e4736bad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_402ef6a2023d4c3b9bde9886e4736bad()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_8546c3d438714113aa72d5fe77ead332 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8546c3d438714113aa72d5fe77ead332()
        {
          this.Initialize("castedDamage", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("spellID", typeof (SpellEnum))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedDamage((SpellEnum) pars[0]);
        }
      }

      private sealed class MTHD_a3e0a972c4b34d77b00fa268445ceaa9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a3e0a972c4b34d77b00fa268445ceaa9()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_1bbfc142050349a2a49458452ff24f53 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1bbfc142050349a2a49458452ff24f53()
        {
          this.Initialize("castSpell", false, new ParameterDescriptor[5]
          {
            new ParameterDescriptor("spellObj", typeof (object)),
            new ParameterDescriptor("target", typeof (Educative.Point)),
            new ParameterDescriptor("angle", typeof (double), true, (object) new DefaultValue()),
            new ParameterDescriptor("power", typeof (double), true, (object) new DefaultValue()),
            new ParameterDescriptor("secTarget", typeof (Educative.Point), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 2)
          {
            ((ContainerCreature) obj).castSpell(pars[0], (Educative.Point) pars[1]);
            return (object) DynValue.Void;
          }
          if (argscount <= 3)
          {
            ((ContainerCreature) obj).castSpell(pars[0], (Educative.Point) pars[1], (double) pars[2]);
            return (object) DynValue.Void;
          }
          if (argscount <= 4)
          {
            ((ContainerCreature) obj).castSpell(pars[0], (Educative.Point) pars[1], (double) pars[2], (double) pars[3]);
            return (object) DynValue.Void;
          }
          ((ContainerCreature) obj).castSpell(pars[0], (Educative.Point) pars[1], (double) pars[2], (double) pars[3], (Educative.Point) pars[4]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_71e0a6c15d3a4d7ea14d49e1372d9cab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_71e0a6c15d3a4d7ea14d49e1372d9cab()
        {
          this.Initialize("angleToFire", false, new ParameterDescriptor[3]
          {
            new ParameterDescriptor("spellObj", typeof (object)),
            new ParameterDescriptor("target", typeof (Educative.Point)),
            new ParameterDescriptor("power", typeof (float), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return argscount <= 2 ? (object) ((ContainerCreature) obj).angleToFire(pars[0], (Educative.Point) pars[1]) : (object) ((ContainerCreature) obj).angleToFire(pars[0], (Educative.Point) pars[1], (float) pars[2]);
        }
      }

      private sealed class MTHD_091e8b37d0914ee9ad27a6135a2ae90d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_091e8b37d0914ee9ad27a6135a2ae90d()
        {
          this.Initialize("powerToFire", false, new ParameterDescriptor[3]
          {
            new ParameterDescriptor("spellObj", typeof (object)),
            new ParameterDescriptor("target", typeof (Educative.Point)),
            new ParameterDescriptor("angle", typeof (float), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return argscount <= 2 ? (object) ((ContainerCreature) obj).powerToFire(pars[0], (Educative.Point) pars[1]) : (object) ((ContainerCreature) obj).powerToFire(pars[0], (Educative.Point) pars[1], (float) pars[2]);
        }
      }

      private sealed class MTHD_2e105d08d7c24e2ab9a743b20fb44217 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2e105d08d7c24e2ab9a743b20fb44217()
        {
          this.Initialize("fireAt", false, new ParameterDescriptor[3]
          {
            new ParameterDescriptor("spellObj", typeof (object)),
            new ParameterDescriptor("target", typeof (ContainerCreature)),
            new ParameterDescriptor("anglevariance", typeof (double), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 2)
          {
            ((ContainerCreature) obj).fireAt(pars[0], (ContainerCreature) pars[1]);
            return (object) DynValue.Void;
          }
          ((ContainerCreature) obj).fireAt(pars[0], (ContainerCreature) pars[1], (double) pars[2]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_66d9f7273ca9441caa1ece294f96c1c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_66d9f7273ca9441caa1ece294f96c1c2()
        {
          this.Initialize("fireAt", false, new ParameterDescriptor[4]
          {
            new ParameterDescriptor("spellObj", typeof (object)),
            new ParameterDescriptor("target", typeof (Educative.Point)),
            new ParameterDescriptor("anglevariance", typeof (double), true, (object) new DefaultValue()),
            new ParameterDescriptor("secTarget", typeof (Educative.Point), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 2)
          {
            ((ContainerCreature) obj).fireAt(pars[0], (Educative.Point) pars[1]);
            return (object) DynValue.Void;
          }
          if (argscount <= 3)
          {
            ((ContainerCreature) obj).fireAt(pars[0], (Educative.Point) pars[1], (double) pars[2]);
            return (object) DynValue.Void;
          }
          ((ContainerCreature) obj).fireAt(pars[0], (Educative.Point) pars[1], (double) pars[2], (Educative.Point) pars[3]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b238f8249fa04715ad1f11d021eeaf21 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b238f8249fa04715ad1f11d021eeaf21()
        {
          this.Initialize("getEffectors", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("script", typeof (Script))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getEffectors((Script) pars[0]);
        }
      }

      private sealed class MTHD_dc01e2b5e6b14738b80d1fce78e59624 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc01e2b5e6b14738b80d1fce78e59624()
        {
          this.Initialize("getEffectors", false, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("script", typeof (Script)),
            new ParameterDescriptor("destroyable", typeof (bool))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getEffectors((Script) pars[0], (bool) pars[1]);
        }
      }

      private sealed class MTHD_6bfdf208493d4d54b642df61de8e1f5c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6bfdf208493d4d54b642df61de8e1f5c()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).Equals(pars[0]);
        }
      }

      private sealed class MTHD_a6a0d4bf43af42efb723d8ce47ea18f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6a0d4bf43af42efb723d8ce47ea18f2()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_c1584321fd6446a6915386c6e03e370e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c1584321fd6446a6915386c6e03e370e()
        {
          this.Initialize("op_Equality", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("v", typeof (ContainerCreature)),
            new ParameterDescriptor("x", typeof (ContainerCreature))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) pars[0] == (ContainerCreature) pars[1]);
        }
      }

      private sealed class MTHD_bdd54b1019b647d29a2b0de9b3ce9d3a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bdd54b1019b647d29a2b0de9b3ce9d3a()
        {
          this.Initialize("op_Inequality", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("v", typeof (ContainerCreature)),
            new ParameterDescriptor("x", typeof (ContainerCreature))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) pars[0] != (ContainerCreature) pars[1]);
        }
      }

      private sealed class MTHD_efd16f5300d442bdb648b1f6a1b72dec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_efd16f5300d442bdb648b1f6a1b72dec()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_2528fa92d8dd4661b0c4a909b2d73e4d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2528fa92d8dd4661b0c4a909b2d73e4d()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_9e127d08b1544d569c5840f2ff7080f4 : HardwiredMemberDescriptor
      {
        internal PROP_9e127d08b1544d569c5840f2ff7080f4()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_56eb2998a72f470faecf8dcee84f801e : HardwiredMemberDescriptor
      {
        internal PROP_56eb2998a72f470faecf8dcee84f801e()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_eda2f7ea84ef42f3af7cdc6c60b92893 : HardwiredMemberDescriptor
      {
        internal PROP_eda2f7ea84ef42f3af7cdc6c60b92893()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_57191c28bcbf4aa4b75c8e67b39470a0 : HardwiredMemberDescriptor
      {
        internal PROP_57191c28bcbf4aa4b75c8e67b39470a0()
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

      private sealed class PROP_7883cbb9677040e99e9faf7c193ce4e1 : HardwiredMemberDescriptor
      {
        internal PROP_7883cbb9677040e99e9faf7c193ce4e1()
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

      private sealed class PROP_e976fb52f24f4dac9a0df4b12620c638 : HardwiredMemberDescriptor
      {
        internal PROP_e976fb52f24f4dac9a0df4b12620c638()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_b6e90ff9f7b9443abe64a5c7bf0906ba : HardwiredMemberDescriptor
      {
        internal PROP_b6e90ff9f7b9443abe64a5c7bf0906ba()
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

      private sealed class PROP_39cbe88a5a3e4fe9a233dddd3bc5072c : HardwiredMemberDescriptor
      {
        internal PROP_39cbe88a5a3e4fe9a233dddd3bc5072c()
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

      private sealed class PROP_5fbe1e85a54f4ad58214409a58a26995 : HardwiredMemberDescriptor
      {
        internal PROP_5fbe1e85a54f4ad58214409a58a26995()
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

      private sealed class PROP_cb8df41230fc40ef860672ded9ea5d96 : HardwiredMemberDescriptor
      {
        internal PROP_cb8df41230fc40ef860672ded9ea5d96()
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

      private sealed class PROP_b8fe4a19169e4c678a69f9f7675e0dc1 : HardwiredMemberDescriptor
      {
        internal PROP_b8fe4a19169e4c678a69f9f7675e0dc1()
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

      private sealed class PROP_fb465cc776474df4acecdd7c977f3f88 : HardwiredMemberDescriptor
      {
        internal PROP_fb465cc776474df4acecdd7c977f3f88()
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

      private sealed class PROP_f459c96f1f2049ffa3b691e82066922f : HardwiredMemberDescriptor
      {
        internal PROP_f459c96f1f2049ffa3b691e82066922f()
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

      private sealed class PROP_a9f289cdd8984699b98a97f13a2e6b84 : HardwiredMemberDescriptor
      {
        internal PROP_a9f289cdd8984699b98a97f13a2e6b84()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_2e82531e76f94809bda342a0c337421c : HardwiredMemberDescriptor
      {
        internal PROP_2e82531e76f94809bda342a0c337421c()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_4f4d12fb2dd642dd96931ec05f3c4673 : HardwiredMemberDescriptor
      {
        internal PROP_4f4d12fb2dd642dd96931ec05f3c4673()
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

      private sealed class PROP_623b32bc12234bc898f85684dd0f3b6b : HardwiredMemberDescriptor
      {
        internal PROP_623b32bc12234bc898f85684dd0f3b6b()
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

      private sealed class PROP_dab8780851104558af6d3686de2ec057 : HardwiredMemberDescriptor
      {
        internal PROP_dab8780851104558af6d3686de2ec057()
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

      private sealed class PROP_ce4ba3b8e10f4e5ca0acb97f40984824 : HardwiredMemberDescriptor
      {
        internal PROP_ce4ba3b8e10f4e5ca0acb97f40984824()
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

      private sealed class PROP_c7eae8f5b67449f1ab798c0bc9435e87 : HardwiredMemberDescriptor
      {
        internal PROP_c7eae8f5b67449f1ab798c0bc9435e87()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_39fded1714af453b85fbe6921f830c73 : HardwiredMemberDescriptor
      {
        internal PROP_39fded1714af453b85fbe6921f830c73()
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

      private sealed class PROP_fbb131e9c7914cfcb0e527b63eb1e33c : HardwiredMemberDescriptor
      {
        internal PROP_fbb131e9c7914cfcb0e527b63eb1e33c()
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

      private sealed class PROP_8edb8af785a9440b89752eb222838c37 : HardwiredMemberDescriptor
      {
        internal PROP_8edb8af785a9440b89752eb222838c37()
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

      private sealed class PROP_1932e0cbab644db0bc2259c037be34d7 : HardwiredMemberDescriptor
      {
        internal PROP_1932e0cbab644db0bc2259c037be34d7()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_db583874c8d642a7a8fb4781eec6928b : HardwiredMemberDescriptor
      {
        internal PROP_db583874c8d642a7a8fb4781eec6928b()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_b14061d309d74b2a9b4dbdc2b3928c8f : HardwiredMemberDescriptor
      {
        internal PROP_b14061d309d74b2a9b4dbdc2b3928c8f()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_27e727857b314ba6bbf8808f3e1c615c : HardwiredMemberDescriptor
      {
        internal PROP_27e727857b314ba6bbf8808f3e1c615c()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_dd8eb5a3fae143dd905abf93b35f6321 : HardwiredMemberDescriptor
      {
        internal PROP_dd8eb5a3fae143dd905abf93b35f6321()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_ece45b8336914c239bae85a22aff89c7 : HardwiredMemberDescriptor
      {
        internal PROP_ece45b8336914c239bae85a22aff89c7()
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

      private sealed class PROP_c05ed3babf7747fab9289332d09fb5f3 : HardwiredMemberDescriptor
      {
        internal PROP_c05ed3babf7747fab9289332d09fb5f3()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_8dfde15fcc40417da7179b19f2626a66 : HardwiredMemberDescriptor
      {
        internal PROP_8dfde15fcc40417da7179b19f2626a66()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_5ca6603c305c4a3e92deaf2295af4004 : HardwiredMemberDescriptor
      {
        internal PROP_5ca6603c305c4a3e92deaf2295af4004()
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

      private sealed class PROP_1cde8a1385e244f7b9c3836ead14d14a : HardwiredMemberDescriptor
      {
        internal PROP_1cde8a1385e244f7b9c3836ead14d14a()
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

    private sealed class TYPE_06145b5293734f6b9606663774d4ba28 : HardwiredUserDataDescriptor
    {
      internal TYPE_06145b5293734f6b9606663774d4ba28()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.MTHD_7bee85810b244dbbacb2151f1571a217()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.MTHD_dfae3680920c4e8098b9a1817c84da61()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.MTHD_0e45fc46efcd47ec824f372a0f9158cc()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.MTHD_1c77a9abb75247dbaaf7acfa1725b0a8()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.MTHD_15cb7a6a31bc425a80722e0fdc1df25b()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.MTHD_373f2412d7fb419f9da83bc6cf8345ab()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.MTHD_0b5b0521f4c645ee99ca547ae6492780()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.MTHD_add8a2e70bfe41c7a8cbff25a4249663()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.MTHD_6445e33d29ed4e8ea6884ee7d3520292()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.MTHD_30fb22431e004407ae5fcbcc28b35c8a()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.MTHD_6299ee2c1c524fca824878323a5abd87()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.MTHD_f2d204a6a6fa4ce39145acdf7177e135()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.MTHD_dc2dc86ad2ab42ee868c9de3d89f923b()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.MTHD_627dccb8ce9a4cd2bad4914dbb46b006()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.MTHD_7e262048c2c44ab591e57ccc49fbe62b()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.MTHD_25b1926e8fb04804892849af10a39162()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.MTHD_6629f3e2e349457ab2aa032c956fc95d()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.MTHD_1ff0b356636b4cbeaff54ef847d98d48()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.MTHD_41fe2cd85de94caf88953acc1a4cacd2()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.MTHD_8005f4f5b65d44d1ab759237ada025fd()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.PROP_0c39162d0b1745d1bda26847b1e8368d());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.PROP_70a2548d2ad94903bc999c529dcd5367());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.PROP_97306dcc495c48228e784b66ada65594());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.PROP_6ea0c5e81a004212ae2ab644202ff4b2());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.PROP_2fbce8b806d8482e8b11453c7484fd57());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.PROP_3e6e6d6bb0074e1992b3a2ffe5bd8814());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.PROP_2270db065c94447083bf9234a37cc136());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_06145b5293734f6b9606663774d4ba28.PROP_b9ba709ba76b48f8bc0ea08c206ece19());
      }

      private sealed class MTHD_7bee85810b244dbbacb2151f1571a217 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7bee85810b244dbbacb2151f1571a217()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_dfae3680920c4e8098b9a1817c84da61 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dfae3680920c4e8098b9a1817c84da61()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_0e45fc46efcd47ec824f372a0f9158cc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e45fc46efcd47ec824f372a0f9158cc()
        {
          this.Initialize("set_x", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).x = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_1c77a9abb75247dbaaf7acfa1725b0a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c77a9abb75247dbaaf7acfa1725b0a8()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_15cb7a6a31bc425a80722e0fdc1df25b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15cb7a6a31bc425a80722e0fdc1df25b()
        {
          this.Initialize("set_y", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).y = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_373f2412d7fb419f9da83bc6cf8345ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_373f2412d7fb419f9da83bc6cf8345ab()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_0b5b0521f4c645ee99ca547ae6492780 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b5b0521f4c645ee99ca547ae6492780()
        {
          this.Initialize("set_position", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (Educative.Point))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).position = (Educative.Point) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_add8a2e70bfe41c7a8cbff25a4249663 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_add8a2e70bfe41c7a8cbff25a4249663()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_6445e33d29ed4e8ea6884ee7d3520292 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6445e33d29ed4e8ea6884ee7d3520292()
        {
          this.Initialize("set_turnsAlive", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnsAlive = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_30fb22431e004407ae5fcbcc28b35c8a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_30fb22431e004407ae5fcbcc28b35c8a()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_6299ee2c1c524fca824878323a5abd87 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6299ee2c1c524fca824878323a5abd87()
        {
          this.Initialize("set_maxTurnsAlive", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).maxTurnsAlive = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_f2d204a6a6fa4ce39145acdf7177e135 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f2d204a6a6fa4ce39145acdf7177e135()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_dc2dc86ad2ab42ee868c9de3d89f923b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc2dc86ad2ab42ee868c9de3d89f923b()
        {
          this.Initialize("set_active", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).active = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_627dccb8ce9a4cd2bad4914dbb46b006 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_627dccb8ce9a4cd2bad4914dbb46b006()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_7e262048c2c44ab591e57ccc49fbe62b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7e262048c2c44ab591e57ccc49fbe62b()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_25b1926e8fb04804892849af10a39162 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_25b1926e8fb04804892849af10a39162()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_6629f3e2e349457ab2aa032c956fc95d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6629f3e2e349457ab2aa032c956fc95d()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_1ff0b356636b4cbeaff54ef847d98d48 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ff0b356636b4cbeaff54ef847d98d48()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.Equals(pars[0]);
        }
      }

      private sealed class MTHD_41fe2cd85de94caf88953acc1a4cacd2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41fe2cd85de94caf88953acc1a4cacd2()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_8005f4f5b65d44d1ab759237ada025fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8005f4f5b65d44d1ab759237ada025fd()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_0c39162d0b1745d1bda26847b1e8368d : HardwiredMemberDescriptor
      {
        internal PROP_0c39162d0b1745d1bda26847b1e8368d()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_70a2548d2ad94903bc999c529dcd5367 : HardwiredMemberDescriptor
      {
        internal PROP_70a2548d2ad94903bc999c529dcd5367()
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

      private sealed class PROP_97306dcc495c48228e784b66ada65594 : HardwiredMemberDescriptor
      {
        internal PROP_97306dcc495c48228e784b66ada65594()
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

      private sealed class PROP_6ea0c5e81a004212ae2ab644202ff4b2 : HardwiredMemberDescriptor
      {
        internal PROP_6ea0c5e81a004212ae2ab644202ff4b2()
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

      private sealed class PROP_2fbce8b806d8482e8b11453c7484fd57 : HardwiredMemberDescriptor
      {
        internal PROP_2fbce8b806d8482e8b11453c7484fd57()
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

      private sealed class PROP_3e6e6d6bb0074e1992b3a2ffe5bd8814 : HardwiredMemberDescriptor
      {
        internal PROP_3e6e6d6bb0074e1992b3a2ffe5bd8814()
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

      private sealed class PROP_2270db065c94447083bf9234a37cc136 : HardwiredMemberDescriptor
      {
        internal PROP_2270db065c94447083bf9234a37cc136()
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

      private sealed class PROP_b9ba709ba76b48f8bc0ea08c206ece19 : HardwiredMemberDescriptor
      {
        internal PROP_b9ba709ba76b48f8bc0ea08c206ece19()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_468311be14c144f7b9a961a32f872acb : HardwiredUserDataDescriptor
    {
      internal TYPE_468311be14c144f7b9a961a32f872acb()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.MTHD_ef2c708e514540dd8724b63c1c938c65()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.MTHD_e76e5dba2c1a447e8e19c3b40f3fc71d()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.MTHD_a3d7516ca8d347708b7c7465bf3db92f()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.MTHD_8827e3ee0dd64828a1a5f619b50c41c3()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.MTHD_46fd4da064244e46a4c3eb35e72d5555()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.MTHD_c3662527dff54d1aa98d9e296c0a7d1c()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.MTHD_59b0140237ec4a2aa0ed80c5237a329a()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.MTHD_539ccecd1cda41fc8d08b7421d78d3f8()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.MTHD_0c2c080f0cdc47a597bd59118b4dd51d()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.MTHD_adde0bd2d3414b8f97714c47be06f0c9()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.MTHD_588498318b364e48b443df47bca172c3()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.MTHD_343dd55fd51e45e7965d04ff3a000a6b()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.MTHD_e401ce1a19ae46a9a5f4e8c7294cdde8()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.MTHD_06e4732459f74e5d86e2965d96c513c1()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.MTHD_a248b0341aa340e7b9ec056530655c68()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.MTHD_74cc86a2ae8f47158c3ab86c1a2cffc2()
        }));
        this.AddMember("setIcon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setIcon", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.MTHD_b3420e3eeebb48e28cc159d05ce72b33()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.MTHD_7a0d657c2ae44cb292df354e41b61260()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.MTHD_aea153282d7042b0bdb089f8d4e55a10()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.MTHD_43b5c250351c48b88da0cf256b5a4184()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.MTHD_80a25fb7a2ca4a45a177df369ba8df67()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.MTHD_6e12a1b2749a4755a5f72d9d0365c633()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.PROP_bd89073d622f4ef58b662e7042006292());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.PROP_830f7534ab0b40d9b81867e011811dc3());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.PROP_55890caa786e4a5d8e6a56d0b685f974());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.PROP_263ea267e20b4f4da0ec4ae945b396a5());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.PROP_a934c83c581e45f8a31de478d621df9f());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.PROP_7559c0ce9cce4ae48e1fe931bc9d4a14());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.PROP_8039f0eee6ed42b1b3803d910a610515());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.PROP_a4a09506d30943bf9f5434c1d41e5915());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_468311be14c144f7b9a961a32f872acb.PROP_4a0cbbfd257647c29ba96ba618204727());
      }

      private sealed class MTHD_ef2c708e514540dd8724b63c1c938c65 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef2c708e514540dd8724b63c1c938c65()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_e76e5dba2c1a447e8e19c3b40f3fc71d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e76e5dba2c1a447e8e19c3b40f3fc71d()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_a3d7516ca8d347708b7c7465bf3db92f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a3d7516ca8d347708b7c7465bf3db92f()
        {
          this.Initialize("set_x", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).x = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_8827e3ee0dd64828a1a5f619b50c41c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8827e3ee0dd64828a1a5f619b50c41c3()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_46fd4da064244e46a4c3eb35e72d5555 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_46fd4da064244e46a4c3eb35e72d5555()
        {
          this.Initialize("set_y", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).y = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_c3662527dff54d1aa98d9e296c0a7d1c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c3662527dff54d1aa98d9e296c0a7d1c()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_59b0140237ec4a2aa0ed80c5237a329a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_59b0140237ec4a2aa0ed80c5237a329a()
        {
          this.Initialize("set_radius", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).radius = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_539ccecd1cda41fc8d08b7421d78d3f8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_539ccecd1cda41fc8d08b7421d78d3f8()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_0c2c080f0cdc47a597bd59118b4dd51d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c2c080f0cdc47a597bd59118b4dd51d()
        {
          this.Initialize("set_position", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (Educative.Point))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).position = (Educative.Point) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_adde0bd2d3414b8f97714c47be06f0c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_adde0bd2d3414b8f97714c47be06f0c9()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_588498318b364e48b443df47bca172c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_588498318b364e48b443df47bca172c3()
        {
          this.Initialize("set_angle", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).angle = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_343dd55fd51e45e7965d04ff3a000a6b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_343dd55fd51e45e7965d04ff3a000a6b()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_e401ce1a19ae46a9a5f4e8c7294cdde8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e401ce1a19ae46a9a5f4e8c7294cdde8()
        {
          this.Initialize("set_color", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (string))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).color = (string) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_06e4732459f74e5d86e2965d96c513c1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_06e4732459f74e5d86e2965d96c513c1()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color2;
        }
      }

      private sealed class MTHD_a248b0341aa340e7b9ec056530655c68 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a248b0341aa340e7b9ec056530655c68()
        {
          this.Initialize("set_color2", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (LuaColor))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).color2 = (LuaColor) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_74cc86a2ae8f47158c3ab86c1a2cffc2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74cc86a2ae8f47158c3ab86c1a2cffc2()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_b3420e3eeebb48e28cc159d05ce72b33 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b3420e3eeebb48e28cc159d05ce72b33()
        {
          this.Initialize("setIcon", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("spellObj", typeof (object))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).setIcon(pars[0]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_7a0d657c2ae44cb292df354e41b61260 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a0d657c2ae44cb292df354e41b61260()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_aea153282d7042b0bdb089f8d4e55a10 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aea153282d7042b0bdb089f8d4e55a10()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.Equals(pars[0]);
        }
      }

      private sealed class MTHD_43b5c250351c48b88da0cf256b5a4184 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_43b5c250351c48b88da0cf256b5a4184()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_80a25fb7a2ca4a45a177df369ba8df67 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_80a25fb7a2ca4a45a177df369ba8df67()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_6e12a1b2749a4755a5f72d9d0365c633 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e12a1b2749a4755a5f72d9d0365c633()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_bd89073d622f4ef58b662e7042006292 : HardwiredMemberDescriptor
      {
        internal PROP_bd89073d622f4ef58b662e7042006292()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_830f7534ab0b40d9b81867e011811dc3 : HardwiredMemberDescriptor
      {
        internal PROP_830f7534ab0b40d9b81867e011811dc3()
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

      private sealed class PROP_55890caa786e4a5d8e6a56d0b685f974 : HardwiredMemberDescriptor
      {
        internal PROP_55890caa786e4a5d8e6a56d0b685f974()
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

      private sealed class PROP_263ea267e20b4f4da0ec4ae945b396a5 : HardwiredMemberDescriptor
      {
        internal PROP_263ea267e20b4f4da0ec4ae945b396a5()
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

      private sealed class PROP_a934c83c581e45f8a31de478d621df9f : HardwiredMemberDescriptor
      {
        internal PROP_a934c83c581e45f8a31de478d621df9f()
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

      private sealed class PROP_7559c0ce9cce4ae48e1fe931bc9d4a14 : HardwiredMemberDescriptor
      {
        internal PROP_7559c0ce9cce4ae48e1fe931bc9d4a14()
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

      private sealed class PROP_8039f0eee6ed42b1b3803d910a610515 : HardwiredMemberDescriptor
      {
        internal PROP_8039f0eee6ed42b1b3803d910a610515()
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

      private sealed class PROP_a4a09506d30943bf9f5434c1d41e5915 : HardwiredMemberDescriptor
      {
        internal PROP_a4a09506d30943bf9f5434c1d41e5915()
          : base(typeof (LuaColor), "color2", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).color2;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((ContainerIndicator) obj).color2 = (LuaColor) value;
        }
      }

      private sealed class PROP_4a0cbbfd257647c29ba96ba618204727 : HardwiredMemberDescriptor
      {
        internal PROP_4a0cbbfd257647c29ba96ba618204727()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_5009c011086a44d8ac15cd662dfb03c8 : HardwiredUserDataDescriptor
    {
      internal TYPE_5009c011086a44d8ac15cd662dfb03c8()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_883d3605d6b54d05a224f474b2e3c8eb()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_0a9a861d3411445cb8f1e80c931a8269()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_2d756eea9ccf4c7ea224a1e90735f7a9()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_8b3ff06d5d354199ba78985d04638a9e()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_b67c3c5688f84c298803016740096060()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_e2b27c4c192449619294038b689e4a88()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_9e511f8940824013ab8cf2b86c5c2f74()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_084450eaacc94d84b9cd5cf2ec97d2a0()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_b67fea70c50745bf807ac6acb04d9acd()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_e88e61cf1f624dd6b01e9b51dbc00a58()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_8f771351420e45c189c8449504b4438b()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_03f540ed659d41c1b4de47bee3fa5aba()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_614fbf06dddd461f9539c607cde145d1()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_7d30a0606fe3492c92cd086d64239625()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_1089bcd7a62d46b295180ddfc9eb6df2()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_6b6e9f4e0ad94023ba1a2321f06aae9b()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_84b07a371722400292246b3e9a3bf41a()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_0409f7ddaae5482982d0777df436150a()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_178cb2b2422c485c8f466e6a11179488()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_53d197d6dbe7496cb6654dc8df449053()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_236e3662849b48d7a46f6cd4b3b00b03()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_426d3f3d8b704a2abc35369df1b3319b()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_32a684b59ac74e389f10a15fc4471c28()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_7ef749614a084f79bab13c0a18c803bf()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_a32a08c735944a07b3363a3806eb2c4f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_3a8362f521ba49d087293eee79db59b1()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_c1894285c7874bcfbe07b43ee4581bfc()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.MTHD_f3f2a452c63a48f098b2336da97afc6b()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.PROP_7d4e9c34a0ea4af6a1e10a884a8fb575());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.PROP_ad7ba93a500d48e1bd7a031195020d8d());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.PROP_a4cbb5fa7f634e51b171e208865228aa());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.PROP_a6afafa8e4ad416198ab10c55951560e());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.PROP_654f30d0ef9d4fd8b9c80f1d76ec4691());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.PROP_9a0e0d06967c430aa1774d0a6cdc5611());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.PROP_4dae1362ce2c4beabed6e3fccdfab39f());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.PROP_b7103ac0a4e14a4e8ee930a5580f8c60());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.PROP_8b7b97a5111748c9b043f7701a992488());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.PROP_379e7295af3e410aa8acc392201133a1());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.PROP_b4c7db4118274c60bd6a86db1c7aa083());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.PROP_7b9dd10bc7b64fb2bdd02a04499351ff());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.PROP_ba34b7d668c64888b9c82fc5a0223190());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.PROP_d277f0094e444110b8a20d2468271317());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.PROP_7d28fdf993f743f59d9d7e5b16c92054());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.PROP_f8bc7b025440487c9f862dec005758bf());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_5009c011086a44d8ac15cd662dfb03c8.PROP_0ea102b7c2014b50872c5b598cc6db50());
      }

      private sealed class MTHD_883d3605d6b54d05a224f474b2e3c8eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_883d3605d6b54d05a224f474b2e3c8eb()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_0a9a861d3411445cb8f1e80c931a8269 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0a9a861d3411445cb8f1e80c931a8269()
        {
          this.Initialize("set_uses", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerSpell) obj).uses = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_2d756eea9ccf4c7ea224a1e90735f7a9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d756eea9ccf4c7ea224a1e90735f7a9()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_8b3ff06d5d354199ba78985d04638a9e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b3ff06d5d354199ba78985d04638a9e()
        {
          this.Initialize("set_maxUses", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerSpell) obj).maxUses = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_b67c3c5688f84c298803016740096060 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b67c3c5688f84c298803016740096060()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_e2b27c4c192449619294038b689e4a88 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e2b27c4c192449619294038b689e4a88()
        {
          this.Initialize("set_rechargeTime", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerSpell) obj).rechargeTime = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_9e511f8940824013ab8cf2b86c5c2f74 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e511f8940824013ab8cf2b86c5c2f74()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_084450eaacc94d84b9cd5cf2ec97d2a0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_084450eaacc94d84b9cd5cf2ec97d2a0()
        {
          this.Initialize("set_lastTurnFired", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerSpell) obj).lastTurnFired = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_b67fea70c50745bf807ac6acb04d9acd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b67fea70c50745bf807ac6acb04d9acd()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_e88e61cf1f624dd6b01e9b51dbc00a58 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e88e61cf1f624dd6b01e9b51dbc00a58()
        {
          this.Initialize("set_isPresent", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerSpell) obj).isPresent = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_8f771351420e45c189c8449504b4438b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8f771351420e45c189c8449504b4438b()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_03f540ed659d41c1b4de47bee3fa5aba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_03f540ed659d41c1b4de47bee3fa5aba()
        {
          this.Initialize("set_locked", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerSpell) obj).locked = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_614fbf06dddd461f9539c607cde145d1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_614fbf06dddd461f9539c607cde145d1()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_7d30a0606fe3492c92cd086d64239625 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7d30a0606fe3492c92cd086d64239625()
        {
          this.Initialize("set_turnsTillFirstUse", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerSpell) obj).turnsTillFirstUse = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_1089bcd7a62d46b295180ddfc9eb6df2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1089bcd7a62d46b295180ddfc9eb6df2()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_6b6e9f4e0ad94023ba1a2321f06aae9b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b6e9f4e0ad94023ba1a2321f06aae9b()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_84b07a371722400292246b3e9a3bf41a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84b07a371722400292246b3e9a3bf41a()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_0409f7ddaae5482982d0777df436150a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0409f7ddaae5482982d0777df436150a()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_178cb2b2422c485c8f466e6a11179488 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_178cb2b2422c485c8f466e6a11179488()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_53d197d6dbe7496cb6654dc8df449053 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_53d197d6dbe7496cb6654dc8df449053()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_236e3662849b48d7a46f6cd4b3b00b03 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_236e3662849b48d7a46f6cd4b3b00b03()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_426d3f3d8b704a2abc35369df1b3319b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_426d3f3d8b704a2abc35369df1b3319b()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_32a684b59ac74e389f10a15fc4471c28 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_32a684b59ac74e389f10a15fc4471c28()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_7ef749614a084f79bab13c0a18c803bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ef749614a084f79bab13c0a18c803bf()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_a32a08c735944a07b3363a3806eb2c4f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a32a08c735944a07b3363a3806eb2c4f()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.Equals(pars[0]);
        }
      }

      private sealed class MTHD_3a8362f521ba49d087293eee79db59b1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3a8362f521ba49d087293eee79db59b1()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_c1894285c7874bcfbe07b43ee4581bfc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c1894285c7874bcfbe07b43ee4581bfc()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_f3f2a452c63a48f098b2336da97afc6b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f3f2a452c63a48f098b2336da97afc6b()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_7d4e9c34a0ea4af6a1e10a884a8fb575 : HardwiredMemberDescriptor
      {
        internal PROP_7d4e9c34a0ea4af6a1e10a884a8fb575()
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

      private sealed class PROP_ad7ba93a500d48e1bd7a031195020d8d : HardwiredMemberDescriptor
      {
        internal PROP_ad7ba93a500d48e1bd7a031195020d8d()
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

      private sealed class PROP_a4cbb5fa7f634e51b171e208865228aa : HardwiredMemberDescriptor
      {
        internal PROP_a4cbb5fa7f634e51b171e208865228aa()
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

      private sealed class PROP_a6afafa8e4ad416198ab10c55951560e : HardwiredMemberDescriptor
      {
        internal PROP_a6afafa8e4ad416198ab10c55951560e()
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

      private sealed class PROP_654f30d0ef9d4fd8b9c80f1d76ec4691 : HardwiredMemberDescriptor
      {
        internal PROP_654f30d0ef9d4fd8b9c80f1d76ec4691()
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

      private sealed class PROP_9a0e0d06967c430aa1774d0a6cdc5611 : HardwiredMemberDescriptor
      {
        internal PROP_9a0e0d06967c430aa1774d0a6cdc5611()
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

      private sealed class PROP_4dae1362ce2c4beabed6e3fccdfab39f : HardwiredMemberDescriptor
      {
        internal PROP_4dae1362ce2c4beabed6e3fccdfab39f()
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

      private sealed class PROP_b7103ac0a4e14a4e8ee930a5580f8c60 : HardwiredMemberDescriptor
      {
        internal PROP_b7103ac0a4e14a4e8ee930a5580f8c60()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_8b7b97a5111748c9b043f7701a992488 : HardwiredMemberDescriptor
      {
        internal PROP_8b7b97a5111748c9b043f7701a992488()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_379e7295af3e410aa8acc392201133a1 : HardwiredMemberDescriptor
      {
        internal PROP_379e7295af3e410aa8acc392201133a1()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_b4c7db4118274c60bd6a86db1c7aa083 : HardwiredMemberDescriptor
      {
        internal PROP_b4c7db4118274c60bd6a86db1c7aa083()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_7b9dd10bc7b64fb2bdd02a04499351ff : HardwiredMemberDescriptor
      {
        internal PROP_7b9dd10bc7b64fb2bdd02a04499351ff()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_ba34b7d668c64888b9c82fc5a0223190 : HardwiredMemberDescriptor
      {
        internal PROP_ba34b7d668c64888b9c82fc5a0223190()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_d277f0094e444110b8a20d2468271317 : HardwiredMemberDescriptor
      {
        internal PROP_d277f0094e444110b8a20d2468271317()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_7d28fdf993f743f59d9d7e5b16c92054 : HardwiredMemberDescriptor
      {
        internal PROP_7d28fdf993f743f59d9d7e5b16c92054()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_f8bc7b025440487c9f862dec005758bf : HardwiredMemberDescriptor
      {
        internal PROP_f8bc7b025440487c9f862dec005758bf()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_0ea102b7c2014b50872c5b598cc6db50 : HardwiredMemberDescriptor
      {
        internal PROP_0ea102b7c2014b50872c5b598cc6db50()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_c9f67096b1d5495d8f0b9fa17ddf6d89 : HardwiredUserDataDescriptor
    {
      internal TYPE_c9f67096b1d5495d8f0b9fa17ddf6d89()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9f67096b1d5495d8f0b9fa17ddf6d89.MTHD_d5a621ff9c5148fd9deb8aa26eda7ff5()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9f67096b1d5495d8f0b9fa17ddf6d89.MTHD_67d8eae2e259460e8e1870be199e3f66()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9f67096b1d5495d8f0b9fa17ddf6d89.MTHD_3b533fad72d0420aa05752a314323ccd()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9f67096b1d5495d8f0b9fa17ddf6d89.MTHD_f38ce8002aed487a89bbe6c626aa4f88()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9f67096b1d5495d8f0b9fa17ddf6d89.MTHD_efad6ab8a9054821bb563b09fb83ba5f()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9f67096b1d5495d8f0b9fa17ddf6d89.MTHD_81a6f52352ef4f9489d7d205319ec7b3()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9f67096b1d5495d8f0b9fa17ddf6d89.MTHD_195e47a90fed4d46968e520239388cd6()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9f67096b1d5495d8f0b9fa17ddf6d89.MTHD_76729557d3dc4c638711be04682ae450()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9f67096b1d5495d8f0b9fa17ddf6d89.MTHD_99f1c008161d475fb07dc866b7962467()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9f67096b1d5495d8f0b9fa17ddf6d89.MTHD_df66dbe202994845a3e161e8c66fca57()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9f67096b1d5495d8f0b9fa17ddf6d89.MTHD_6d37ff37a55c4c82b252312797ed4170()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9f67096b1d5495d8f0b9fa17ddf6d89.MTHD_121b1ab1f74a41919d6a937a58aa7ae3()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9f67096b1d5495d8f0b9fa17ddf6d89.MTHD_5f56b4d82a30438d85e9a540af759baa()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9f67096b1d5495d8f0b9fa17ddf6d89.MTHD_1d9c18f184a74b08b6616ba3eabad787()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9f67096b1d5495d8f0b9fa17ddf6d89.MTHD_e435ca9fc5b54735a7452b9073ea6a8d()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9f67096b1d5495d8f0b9fa17ddf6d89.MTHD_3de342c723ea4db383cf1d020f942828()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c9f67096b1d5495d8f0b9fa17ddf6d89.MTHD_38d577d214434cef98f2cda99b30b96a()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_c9f67096b1d5495d8f0b9fa17ddf6d89.PROP_2c303ff076f640ca8a21409c9b38947d());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_c9f67096b1d5495d8f0b9fa17ddf6d89.PROP_f6b3f67f6c584c2c83e728b73fc55cf5());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_c9f67096b1d5495d8f0b9fa17ddf6d89.PROP_33577fac2e7d48519c2e01f2a954f5dc());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_c9f67096b1d5495d8f0b9fa17ddf6d89.PROP_4281419781c845aa9c46a0030c515339());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_c9f67096b1d5495d8f0b9fa17ddf6d89.PROP_b02c01ef39c94c789db9f2f9733d2dc9());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_c9f67096b1d5495d8f0b9fa17ddf6d89.PROP_464fc32697ce454fb8c520fe2314dbf0());
      }

      private sealed class MTHD_d5a621ff9c5148fd9deb8aa26eda7ff5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d5a621ff9c5148fd9deb8aa26eda7ff5()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_67d8eae2e259460e8e1870be199e3f66 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67d8eae2e259460e8e1870be199e3f66()
        {
          this.Initialize("set_health", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).health = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_3b533fad72d0420aa05752a314323ccd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3b533fad72d0420aa05752a314323ccd()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_f38ce8002aed487a89bbe6c626aa4f88 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f38ce8002aed487a89bbe6c626aa4f88()
        {
          this.Initialize("set_maxHealth", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).maxHealth = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_efad6ab8a9054821bb563b09fb83ba5f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_efad6ab8a9054821bb563b09fb83ba5f()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_81a6f52352ef4f9489d7d205319ec7b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_81a6f52352ef4f9489d7d205319ec7b3()
        {
          this.Initialize("set_x", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).x = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_195e47a90fed4d46968e520239388cd6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_195e47a90fed4d46968e520239388cd6()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_76729557d3dc4c638711be04682ae450 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76729557d3dc4c638711be04682ae450()
        {
          this.Initialize("set_y", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).y = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_99f1c008161d475fb07dc866b7962467 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99f1c008161d475fb07dc866b7962467()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_df66dbe202994845a3e161e8c66fca57 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_df66dbe202994845a3e161e8c66fca57()
        {
          this.Initialize("set_position", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (Educative.Point))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).position = (Educative.Point) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_6d37ff37a55c4c82b252312797ed4170 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d37ff37a55c4c82b252312797ed4170()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_121b1ab1f74a41919d6a937a58aa7ae3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_121b1ab1f74a41919d6a937a58aa7ae3()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_5f56b4d82a30438d85e9a540af759baa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5f56b4d82a30438d85e9a540af759baa()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_1d9c18f184a74b08b6616ba3eabad787 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d9c18f184a74b08b6616ba3eabad787()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_e435ca9fc5b54735a7452b9073ea6a8d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e435ca9fc5b54735a7452b9073ea6a8d()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.Equals(pars[0]);
        }
      }

      private sealed class MTHD_3de342c723ea4db383cf1d020f942828 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3de342c723ea4db383cf1d020f942828()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_38d577d214434cef98f2cda99b30b96a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_38d577d214434cef98f2cda99b30b96a()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_2c303ff076f640ca8a21409c9b38947d : HardwiredMemberDescriptor
      {
        internal PROP_2c303ff076f640ca8a21409c9b38947d()
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

      private sealed class PROP_f6b3f67f6c584c2c83e728b73fc55cf5 : HardwiredMemberDescriptor
      {
        internal PROP_f6b3f67f6c584c2c83e728b73fc55cf5()
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

      private sealed class PROP_33577fac2e7d48519c2e01f2a954f5dc : HardwiredMemberDescriptor
      {
        internal PROP_33577fac2e7d48519c2e01f2a954f5dc()
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

      private sealed class PROP_4281419781c845aa9c46a0030c515339 : HardwiredMemberDescriptor
      {
        internal PROP_4281419781c845aa9c46a0030c515339()
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

      private sealed class PROP_b02c01ef39c94c789db9f2f9733d2dc9 : HardwiredMemberDescriptor
      {
        internal PROP_b02c01ef39c94c789db9f2f9733d2dc9()
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

      private sealed class PROP_464fc32697ce454fb8c520fe2314dbf0 : HardwiredMemberDescriptor
      {
        internal PROP_464fc32697ce454fb8c520fe2314dbf0()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_50d12a67c75c4029bc93bccabe32ff00 : HardwiredUserDataDescriptor
    {
      internal TYPE_50d12a67c75c4029bc93bccabe32ff00()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50d12a67c75c4029bc93bccabe32ff00.MTHD_4cd90ae203b64534a046f46ae4328f93(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50d12a67c75c4029bc93bccabe32ff00.MTHD_8370e39f683d42eba91b4ae954dade22()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50d12a67c75c4029bc93bccabe32ff00.MTHD_2cfb012089de4f7cb8c38a0b35f6d377(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50d12a67c75c4029bc93bccabe32ff00.MTHD_9713ee546e3f4795a11f808a611a6dbe()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50d12a67c75c4029bc93bccabe32ff00.MTHD_d231fccb4d1d470aa790ecc58a1b905e()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50d12a67c75c4029bc93bccabe32ff00.MTHD_df6726ab836e412e8c6462bdb3804951()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50d12a67c75c4029bc93bccabe32ff00.MTHD_ef1d2f71ea1e4085a0e3cee5f853dfe6()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50d12a67c75c4029bc93bccabe32ff00.MTHD_693c1617fe6b45d994da3d351add02cd()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50d12a67c75c4029bc93bccabe32ff00.MTHD_d1cc118867bb4738a0c6cfb0b7d1553f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50d12a67c75c4029bc93bccabe32ff00.MTHD_dcf8bcef5bb143f788a83348afbfd2f2()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50d12a67c75c4029bc93bccabe32ff00.MTHD_bc868b8c8db04c6783517c317474c023()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50d12a67c75c4029bc93bccabe32ff00.MTHD_dbdeb2d8d6de40b194443e12503ae841(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50d12a67c75c4029bc93bccabe32ff00.MTHD_d5431ae21ee042628df2cfe1c66794ca()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50d12a67c75c4029bc93bccabe32ff00.MTHD_958e270b8f2e4ac08e682d5caa3d5f48(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50d12a67c75c4029bc93bccabe32ff00.MTHD_00c3474a96254e54bfeaf3761b6b0d75()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50d12a67c75c4029bc93bccabe32ff00.MTHD_d52059f5b5354e2498e3d822cb6e8098(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50d12a67c75c4029bc93bccabe32ff00.MTHD_b44e15a16aab4998b3ad96c77095c72a()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50d12a67c75c4029bc93bccabe32ff00.MTHD_3437cfa2252740798e2b9ee3c65350a7(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50d12a67c75c4029bc93bccabe32ff00.MTHD_b016991486814a6bb4fb53bd611e189c()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50d12a67c75c4029bc93bccabe32ff00.MTHD_4b2426a013f241c0a9abf82ae61b52e2(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50d12a67c75c4029bc93bccabe32ff00.MTHD_880aabc341e04456b6be3fa31999c52b()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50d12a67c75c4029bc93bccabe32ff00.MTHD_1a39c7e235f84cc980e113d5696427c3()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50d12a67c75c4029bc93bccabe32ff00.MTHD_f49b0e83aca2483c838d1c187b041179()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_50d12a67c75c4029bc93bccabe32ff00.FLDV_14c175263c7f4fb7bd71fe024d8e06bc());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_50d12a67c75c4029bc93bccabe32ff00.FLDV_64fe0a910519490c91c05d9355d857f2());
      }

      private sealed class MTHD_4cd90ae203b64534a046f46ae4328f93 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4cd90ae203b64534a046f46ae4328f93()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("x", typeof (double), true, (object) new DefaultValue()),
            new ParameterDescriptor("y", typeof (double), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 0)
            return (object) new Educative.Point();
          return argscount <= 1 ? (object) new Educative.Point((double) pars[0]) : (object) new Educative.Point((double) pars[0], (double) pars[1]);
        }
      }

      private sealed class MTHD_8370e39f683d42eba91b4ae954dade22 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8370e39f683d42eba91b4ae954dade22()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("v", typeof (Vector2))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Educative.Point((Vector2) pars[0]);
        }
      }

      private sealed class MTHD_2cfb012089de4f7cb8c38a0b35f6d377 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2cfb012089de4f7cb8c38a0b35f6d377()
        {
          this.Initialize("distance", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("a", typeof (Educative.Point)),
            new ParameterDescriptor("b", typeof (Educative.Point))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) Educative.Point.distance((Educative.Point) pars[0], (Educative.Point) pars[1]);
        }
      }

      private sealed class MTHD_9713ee546e3f4795a11f808a611a6dbe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9713ee546e3f4795a11f808a611a6dbe()
        {
          this.Initialize("distance", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("b", typeof (Educative.Point))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).distance((Educative.Point) pars[0]);
        }
      }

      private sealed class MTHD_d231fccb4d1d470aa790ecc58a1b905e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d231fccb4d1d470aa790ecc58a1b905e()
        {
          this.Initialize("construct", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("x", typeof (int)),
            new ParameterDescriptor("y", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) Educative.Point.construct((int) pars[0], (int) pars[1]);
        }
      }

      private sealed class MTHD_df6726ab836e412e8c6462bdb3804951 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_df6726ab836e412e8c6462bdb3804951()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_ef1d2f71ea1e4085a0e3cee5f853dfe6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef1d2f71ea1e4085a0e3cee5f853dfe6()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_693c1617fe6b45d994da3d351add02cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_693c1617fe6b45d994da3d351add02cd()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_d1cc118867bb4738a0c6cfb0b7d1553f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1cc118867bb4738a0c6cfb0b7d1553f()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).Equals(pars[0]);
        }
      }

      private sealed class MTHD_dcf8bcef5bb143f788a83348afbfd2f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dcf8bcef5bb143f788a83348afbfd2f2()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_bc868b8c8db04c6783517c317474c023 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bc868b8c8db04c6783517c317474c023()
        {
          this.Initialize("op_Equality", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("v", typeof (Educative.Point)),
            new ParameterDescriptor("x", typeof (Educative.Point))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) pars[0] == (Educative.Point) pars[1]);
        }
      }

      private sealed class MTHD_dbdeb2d8d6de40b194443e12503ae841 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dbdeb2d8d6de40b194443e12503ae841()
        {
          this.Initialize("op_Subtraction", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("x", typeof (Educative.Point)),
            new ParameterDescriptor("v", typeof (double))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) pars[0] - (double) pars[1]);
        }
      }

      private sealed class MTHD_d5431ae21ee042628df2cfe1c66794ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d5431ae21ee042628df2cfe1c66794ca()
        {
          this.Initialize("op_Subtraction", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("x", typeof (Educative.Point)),
            new ParameterDescriptor("v", typeof (Educative.Point))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) pars[0] - (Educative.Point) pars[1]);
        }
      }

      private sealed class MTHD_958e270b8f2e4ac08e682d5caa3d5f48 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_958e270b8f2e4ac08e682d5caa3d5f48()
        {
          this.Initialize("op_Addition", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("x", typeof (Educative.Point)),
            new ParameterDescriptor("v", typeof (double))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) pars[0] + (double) pars[1]);
        }
      }

      private sealed class MTHD_00c3474a96254e54bfeaf3761b6b0d75 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_00c3474a96254e54bfeaf3761b6b0d75()
        {
          this.Initialize("op_Addition", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("x", typeof (Educative.Point)),
            new ParameterDescriptor("v", typeof (Educative.Point))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) pars[0] + (Educative.Point) pars[1]);
        }
      }

      private sealed class MTHD_d52059f5b5354e2498e3d822cb6e8098 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d52059f5b5354e2498e3d822cb6e8098()
        {
          this.Initialize("op_Multiply", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("x", typeof (Educative.Point)),
            new ParameterDescriptor("v", typeof (double))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) pars[0] * (double) pars[1]);
        }
      }

      private sealed class MTHD_b44e15a16aab4998b3ad96c77095c72a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b44e15a16aab4998b3ad96c77095c72a()
        {
          this.Initialize("op_Multiply", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("x", typeof (Educative.Point)),
            new ParameterDescriptor("v", typeof (Educative.Point))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) pars[0] * (Educative.Point) pars[1]);
        }
      }

      private sealed class MTHD_3437cfa2252740798e2b9ee3c65350a7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3437cfa2252740798e2b9ee3c65350a7()
        {
          this.Initialize("op_Division", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("x", typeof (Educative.Point)),
            new ParameterDescriptor("v", typeof (double))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) pars[0] / (double) pars[1]);
        }
      }

      private sealed class MTHD_b016991486814a6bb4fb53bd611e189c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b016991486814a6bb4fb53bd611e189c()
        {
          this.Initialize("op_Division", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("x", typeof (Educative.Point)),
            new ParameterDescriptor("v", typeof (Educative.Point))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) pars[0] / (Educative.Point) pars[1]);
        }
      }

      private sealed class MTHD_4b2426a013f241c0a9abf82ae61b52e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b2426a013f241c0a9abf82ae61b52e2()
        {
          this.Initialize("op_Modulus", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("x", typeof (Educative.Point)),
            new ParameterDescriptor("v", typeof (double))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) pars[0] % (double) pars[1]);
        }
      }

      private sealed class MTHD_880aabc341e04456b6be3fa31999c52b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_880aabc341e04456b6be3fa31999c52b()
        {
          this.Initialize("op_Modulus", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("x", typeof (Educative.Point)),
            new ParameterDescriptor("v", typeof (Educative.Point))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) pars[0] % (Educative.Point) pars[1]);
        }
      }

      private sealed class MTHD_1a39c7e235f84cc980e113d5696427c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a39c7e235f84cc980e113d5696427c3()
        {
          this.Initialize("op_Inequality", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("v", typeof (Educative.Point)),
            new ParameterDescriptor("x", typeof (Educative.Point))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) pars[0] != (Educative.Point) pars[1]);
        }
      }

      private sealed class MTHD_f49b0e83aca2483c838d1c187b041179 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f49b0e83aca2483c838d1c187b041179()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_14c175263c7f4fb7bd71fe024d8e06bc : HardwiredMemberDescriptor
      {
        internal FLDV_14c175263c7f4fb7bd71fe024d8e06bc()
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

      private sealed class FLDV_64fe0a910519490c91c05d9355d857f2 : HardwiredMemberDescriptor
      {
        internal FLDV_64fe0a910519490c91c05d9355d857f2()
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

    private sealed class TYPE_63ca7ab16ef54422bacbebfb95956b66 : HardwiredUserDataDescriptor
    {
      internal TYPE_63ca7ab16ef54422bacbebfb95956b66()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_63ca7ab16ef54422bacbebfb95956b66.MTHD_9759750770804d3f9779838d21089aba()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_63ca7ab16ef54422bacbebfb95956b66.MTHD_2874973fcefa4aa591031b2631c36bbc()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_63ca7ab16ef54422bacbebfb95956b66.MTHD_d6a55d86c37a475cb37d1370068f19eb()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_63ca7ab16ef54422bacbebfb95956b66.MTHD_8e00257848bd4dd091ec7ff7d30cce55()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_63ca7ab16ef54422bacbebfb95956b66.MTHD_30a45790aa364b6c96e92bcda22d50a6()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_63ca7ab16ef54422bacbebfb95956b66.MTHD_a2526a8327524cb4b65d2ca98d9ce156()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_63ca7ab16ef54422bacbebfb95956b66.FLDV_f30b343b15d44b588c7b03c7aac4af47());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_63ca7ab16ef54422bacbebfb95956b66.FLDV_d4d72703f60145409b2a97985f199ec7());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_63ca7ab16ef54422bacbebfb95956b66.FLDV_857f5d5c80e64ab5a9518b6ddc9f370a());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_63ca7ab16ef54422bacbebfb95956b66.FLDV_0b98942652ca4a99ab893d5a0dbeffd0());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_63ca7ab16ef54422bacbebfb95956b66.FLDV_a7d407f15e264d078397bdef719c98e2());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_63ca7ab16ef54422bacbebfb95956b66.FLDV_31189c1952e348628309edd6f6f8c72a());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_63ca7ab16ef54422bacbebfb95956b66.FLDV_1475ba7069a64e8e9ca7021c381e5a8d());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_63ca7ab16ef54422bacbebfb95956b66.FLDV_b55c98c95f484e9ea2302d703dc2607e());
        this.AddMember("prestige", (IMemberDescriptor) new Bridge.TYPE_63ca7ab16ef54422bacbebfb95956b66.FLDV_7831adabbd6d4448a3d891f73dd1bf89());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_63ca7ab16ef54422bacbebfb95956b66.FLDV_c4892770ea324501891778f5db815909());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_63ca7ab16ef54422bacbebfb95956b66.FLDV_af9615671a8b45189fc0602fa338ebc4());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_63ca7ab16ef54422bacbebfb95956b66.FLDV_1d9bb323ed1f4405bf674fa7a1d0f058());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_63ca7ab16ef54422bacbebfb95956b66.FLDV_3b4cd73b42b7447ca771c7fff99efc9d());
      }

      private sealed class MTHD_9759750770804d3f9779838d21089aba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9759750770804d3f9779838d21089aba()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_2874973fcefa4aa591031b2631c36bbc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2874973fcefa4aa591031b2631c36bbc()
        {
          this.Initialize("construct", true, new ParameterDescriptor[11]
          {
            new ParameterDescriptor("spell", typeof (object), true, (object) new DefaultValue()),
            new ParameterDescriptor("point", typeof (Educative.Point), true, (object) new DefaultValue()),
            new ParameterDescriptor("team", typeof (int), true, (object) new DefaultValue()),
            new ParameterDescriptor("colors", typeof (Table), true, (object) new DefaultValue()),
            new ParameterDescriptor("playSound", typeof (bool), true, (object) new DefaultValue()),
            new ParameterDescriptor("onPlayersPanel", typeof (bool), true, (object) new DefaultValue()),
            new ParameterDescriptor("name", typeof (string), true, (object) new DefaultValue()),
            new ParameterDescriptor("outfit", typeof (Table), true, (object) new DefaultValue()),
            new ParameterDescriptor("spells", typeof (Table), true, (object) new DefaultValue()),
            new ParameterDescriptor("elemental", typeof (BookOf), true, (object) new DefaultValue()),
            new ParameterDescriptor("prestige", typeof (int), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 0)
            return (object) Summon.construct();
          if (argscount <= 1)
            return (object) Summon.construct(pars[0]);
          if (argscount <= 2)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1]);
          if (argscount <= 3)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2]);
          if (argscount <= 4)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3]);
          if (argscount <= 5)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], (bool) pars[4]);
          if (argscount <= 6)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], (bool) pars[4], (bool) pars[5]);
          if (argscount <= 7)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], (bool) pars[4], (bool) pars[5], (string) pars[6]);
          if (argscount <= 8)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], (bool) pars[4], (bool) pars[5], (string) pars[6], (Table) pars[7]);
          if (argscount <= 9)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], (bool) pars[4], (bool) pars[5], (string) pars[6], (Table) pars[7], (Table) pars[8]);
          return argscount <= 10 ? (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], (bool) pars[4], (bool) pars[5], (string) pars[6], (Table) pars[7], (Table) pars[8], (BookOf) pars[9]) : (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], (bool) pars[4], (bool) pars[5], (string) pars[6], (Table) pars[7], (Table) pars[8], (BookOf) pars[9], (int) pars[10]);
        }
      }

      private sealed class MTHD_d6a55d86c37a475cb37d1370068f19eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6a55d86c37a475cb37d1370068f19eb()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.Equals(pars[0]);
        }
      }

      private sealed class MTHD_8e00257848bd4dd091ec7ff7d30cce55 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e00257848bd4dd091ec7ff7d30cce55()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_30a45790aa364b6c96e92bcda22d50a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_30a45790aa364b6c96e92bcda22d50a6()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_a2526a8327524cb4b65d2ca98d9ce156 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2526a8327524cb4b65d2ca98d9ce156()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_f30b343b15d44b588c7b03c7aac4af47 : HardwiredMemberDescriptor
      {
        internal FLDV_f30b343b15d44b588c7b03c7aac4af47()
          : base(typeof (object), "spell", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj) => ((Summon) obj).spell;

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((Summon) obj).spell = value;
        }
      }

      private sealed class FLDV_d4d72703f60145409b2a97985f199ec7 : HardwiredMemberDescriptor
      {
        internal FLDV_d4d72703f60145409b2a97985f199ec7()
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

      private sealed class FLDV_857f5d5c80e64ab5a9518b6ddc9f370a : HardwiredMemberDescriptor
      {
        internal FLDV_857f5d5c80e64ab5a9518b6ddc9f370a()
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

      private sealed class FLDV_0b98942652ca4a99ab893d5a0dbeffd0 : HardwiredMemberDescriptor
      {
        internal FLDV_0b98942652ca4a99ab893d5a0dbeffd0()
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

      private sealed class FLDV_a7d407f15e264d078397bdef719c98e2 : HardwiredMemberDescriptor
      {
        internal FLDV_a7d407f15e264d078397bdef719c98e2()
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

      private sealed class FLDV_31189c1952e348628309edd6f6f8c72a : HardwiredMemberDescriptor
      {
        internal FLDV_31189c1952e348628309edd6f6f8c72a()
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

      private sealed class FLDV_1475ba7069a64e8e9ca7021c381e5a8d : HardwiredMemberDescriptor
      {
        internal FLDV_1475ba7069a64e8e9ca7021c381e5a8d()
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

      private sealed class FLDV_b55c98c95f484e9ea2302d703dc2607e : HardwiredMemberDescriptor
      {
        internal FLDV_b55c98c95f484e9ea2302d703dc2607e()
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

      private sealed class FLDV_7831adabbd6d4448a3d891f73dd1bf89 : HardwiredMemberDescriptor
      {
        internal FLDV_7831adabbd6d4448a3d891f73dd1bf89()
          : base(typeof (int), "prestige", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((Summon) obj).prestige;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((Summon) obj).prestige = (int) value;
        }
      }

      private sealed class FLDV_c4892770ea324501891778f5db815909 : HardwiredMemberDescriptor
      {
        internal FLDV_c4892770ea324501891778f5db815909()
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

      private sealed class FLDV_af9615671a8b45189fc0602fa338ebc4 : HardwiredMemberDescriptor
      {
        internal FLDV_af9615671a8b45189fc0602fa338ebc4()
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

      private sealed class FLDV_1d9bb323ed1f4405bf674fa7a1d0f058 : HardwiredMemberDescriptor
      {
        internal FLDV_1d9bb323ed1f4405bf674fa7a1d0f058()
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

      private sealed class FLDV_3b4cd73b42b7447ca771c7fff99efc9d : HardwiredMemberDescriptor
      {
        internal FLDV_3b4cd73b42b7447ca771c7fff99efc9d()
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

    private sealed class TYPE_6aa7ec174af84051b50e4a746e1bbb00 : HardwiredUserDataDescriptor
    {
      internal TYPE_6aa7ec174af84051b50e4a746e1bbb00()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_5f9a73f49fe5414c968796080691c1e5()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_5d01fb482af84bfb818f44722edb066c()
        }));
        this.AddMember("get_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_e65484180cc64491b821b5c21143e1f6()
        }));
        this.AddMember("set_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_b8f4867ef9d4439483571968d199e79d()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_b18f6e45168b4a8490ca236d430ead69()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_a775660b199945c7b50cdd96634b3752()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_6df517bd286c4a3e9463ffb0ddaaef09()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_c2a45ac8cabf4bfba2e386a7e4203343()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_c5f770dbac16481d9e67ac001a0ee0ec()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_8a4517e44e5e42fd9eb9a9a50affce4b()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_e6314f3ce37a461b9ae0cc7894c5fd8a()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_549c67a00b0a43dfaed396ae2edb7997()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_0afa5edad924433d95e3c0741d3c7a1d()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_74caab1ad8914b2a95e382a569db571f()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_fa0cacc05be64e48be9e989e6c43682a()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_790c1406c2de4a6ea24d78f5b673a966()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_7d282e01b40c43028be795c4707eb364()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_3d6c13ed5943476ba8fc6fe13a756bb3()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_a375b7cd69a84a129cfd0a044f9891e5()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_191233aafcde42cfb2d9cd27de25eb93()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_65a9c0fc84fa48e1887c8d892d328031()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_36c48137f5cb4d008a2b2bf842a0a023()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_9d45274ac59242d2bf3a50309e7a8383()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_7f1939dbed1e4ff8811bafcc9f54c25c()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_769dd3a820ae436db596914379dfcbbb()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_0b62be2a90c846158bcc0a13585b12db()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_a06471ac0d68408a80975bb58c6dbecb()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_8d922d6c981d4d6084c72e09a8c30ddf()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_b6a279e42cf74566ad7da71a141f8b5c()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_a2441801e68143ada096d5a2da6b53d6()
        }));
        this.AddMember("get_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_84eee2bf79044e9b8e11d63246ec27c6()
        }));
        this.AddMember("set_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_3f1971bec27e45ecb89e69ed9995fad7()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_7082f524b4c8430dae03f76ac034f0f7()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_c8716d04b1f34252b42097274ebd62b5()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_a0f1e85e58a64928a35b067a6af642d4()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_acf84532cde74851b608b890e67f228e()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_e82ddfa8c16b4eafbc911f866238a482()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_d12ed491d33649d6adeb9d15ad7635cb()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_f1397a0363234fb2b2651b30d0bc4c98()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_7afe4aa06d154be48fffc160a5e5308a()
        }));
        this.AddMember("get_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_f13278c6734f4351a6fd477f04eb803a()
        }));
        this.AddMember("set_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_ee8cacdfa3ca4379b5c7051070f098d2()
        }));
        this.AddMember("get_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_5db287b5cf7247d4a780d362d1e0e59c()
        }));
        this.AddMember("set_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_b46951d621a642dc8eaa7879a5f1da4f()
        }));
        this.AddMember("get_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_6c6a4b39310d4eb6a1d97f5adecda14f()
        }));
        this.AddMember("set_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_6cfb0a0119774b2aa74a7324dae21dcf()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_23432812be0e4a5ab0ac92b9df5badb5()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_703a3dfd95af4cc0a3db79d882e254a0()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_ea8158f7a3524055bcea36ae1f63e93f()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_e87c2c998ea645e283bf476e969f5983()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_46ddc09111284393b95c582f930feea9()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_2679381803c94a6096ba13d964643750()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_9fe5633ebf4e435b93bfbfb7cd452233()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_2fa79d0c174f40dea03cd8238bf70e90()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_02b46454c8ec4f218dd495bcf0deb378()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_7c531bea2f4746cfa86532b951b68fb9()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_3903f5ffbf864ceab71b84b132dfd9d9()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_333b5c9be958468b9131d1a4bec8740d()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_cc8d337559a744c88545c95380b05e41()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.MTHD_b711249a1d52466eb7de70880afcbb46()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.PROP_c598be21a8064ed9903ab29b1f3cebe7());
        this.AddMember("visible", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.PROP_89b4528a87314505bae0f79ffa4eb0ed());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.PROP_72a0be43f9134e8daf1ebe187dc7bbb8());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.PROP_511a6544abf44189aa5d2b6e3ac04ac9());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.PROP_8ac62d8bc94a4de195fd48349221969e());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.PROP_b9bf9b9e5e8349a69d5681ec8225c229());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.PROP_317a013208ee45ddae9cef08c58e00d8());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.PROP_211a3ea53d6549b3a65267cdfca932c4());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.PROP_f848a194f35e49eab10abbfbbbc7ad3f());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.PROP_23c5da2a556b4352b1f41df364eb4e08());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.PROP_2b1e409f51fb416caa2ee63d71dc9dd7());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.PROP_4b41f70b62ad4fb79a73e00034c9501c());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.PROP_58479c21d3e94a04aed9966e22b8ad6b());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.PROP_873659bc8adf47c48d0bb6d94300cd27());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.PROP_6ebf9fde7c62466dbccd2d29ef962da0());
        this.AddMember("onClick2", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.PROP_4ae17ec15983403f932e9881b8e62ede());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.PROP_5205c3aefbc24ec5a0ddc99006b7558a());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.PROP_559ba22b570d42db8c3906160f33c1d7());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.PROP_b85a66a4bd8745b1a7ad29c28a2afe09());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.PROP_24137fd083c649ab8082c05adf1209b4());
        this.AddMember("textColor2", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.PROP_246c4ea28a794a8b8d7cb61e41308e37());
        this.AddMember("highlightColor", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.PROP_777d570e320d45f4bd3b7e7ce51a01e2());
        this.AddMember("highlightColor2", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.PROP_d9f2df9902cf4158905b8eb233dbe6e7());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.PROP_2e2549d8cefb4d4d8787e366683fd092());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.PROP_9b843237b4d74841b3222f48b01b40ad());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.FLDV_4c0ac182acce4df1a797acd941697ff9());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.FLDV_72341e1acc6844789bc421b8b5c2ce88());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_6aa7ec174af84051b50e4a746e1bbb00.FLDV_a3d14858430a4f6caaf6e386ae0f64cd());
      }

      private sealed class MTHD_5f9a73f49fe5414c968796080691c1e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5f9a73f49fe5414c968796080691c1e5()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_5d01fb482af84bfb818f44722edb066c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d01fb482af84bfb818f44722edb066c()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_e65484180cc64491b821b5c21143e1f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e65484180cc64491b821b5c21143e1f6()
        {
          this.Initialize("get_visible", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).visible;
        }
      }

      private sealed class MTHD_b8f4867ef9d4439483571968d199e79d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b8f4867ef9d4439483571968d199e79d()
        {
          this.Initialize("set_visible", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).visible = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_b18f6e45168b4a8490ca236d430ead69 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b18f6e45168b4a8490ca236d430ead69()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_a775660b199945c7b50cdd96634b3752 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a775660b199945c7b50cdd96634b3752()
        {
          this.Initialize("set_graphic", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (object))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).graphic = pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_6df517bd286c4a3e9463ffb0ddaaef09 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6df517bd286c4a3e9463ffb0ddaaef09()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_c2a45ac8cabf4bfba2e386a7e4203343 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c2a45ac8cabf4bfba2e386a7e4203343()
        {
          this.Initialize("set_anchor", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (Anchor))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).anchor = (Anchor) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_c5f770dbac16481d9e67ac001a0ee0ec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c5f770dbac16481d9e67ac001a0ee0ec()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_8a4517e44e5e42fd9eb9a9a50affce4b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a4517e44e5e42fd9eb9a9a50affce4b()
        {
          this.Initialize("set_width", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).width = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_e6314f3ce37a461b9ae0cc7894c5fd8a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e6314f3ce37a461b9ae0cc7894c5fd8a()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_549c67a00b0a43dfaed396ae2edb7997 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_549c67a00b0a43dfaed396ae2edb7997()
        {
          this.Initialize("set_height", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).height = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_0afa5edad924433d95e3c0741d3c7a1d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0afa5edad924433d95e3c0741d3c7a1d()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_74caab1ad8914b2a95e382a569db571f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74caab1ad8914b2a95e382a569db571f()
        {
          this.Initialize("set_size", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (Educative.Point))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).size = (Educative.Point) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_fa0cacc05be64e48be9e989e6c43682a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa0cacc05be64e48be9e989e6c43682a()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_790c1406c2de4a6ea24d78f5b673a966 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_790c1406c2de4a6ea24d78f5b673a966()
        {
          this.Initialize("set_x", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).x = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_7d282e01b40c43028be795c4707eb364 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7d282e01b40c43028be795c4707eb364()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_3d6c13ed5943476ba8fc6fe13a756bb3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d6c13ed5943476ba8fc6fe13a756bb3()
        {
          this.Initialize("set_y", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).y = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_a375b7cd69a84a129cfd0a044f9891e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a375b7cd69a84a129cfd0a044f9891e5()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_191233aafcde42cfb2d9cd27de25eb93 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_191233aafcde42cfb2d9cd27de25eb93()
        {
          this.Initialize("set_position", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (Educative.Point))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).position = (Educative.Point) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_65a9c0fc84fa48e1887c8d892d328031 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65a9c0fc84fa48e1887c8d892d328031()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_36c48137f5cb4d008a2b2bf842a0a023 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_36c48137f5cb4d008a2b2bf842a0a023()
        {
          this.Initialize("set_pivot_x", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).pivot_x = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_9d45274ac59242d2bf3a50309e7a8383 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d45274ac59242d2bf3a50309e7a8383()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_7f1939dbed1e4ff8811bafcc9f54c25c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f1939dbed1e4ff8811bafcc9f54c25c()
        {
          this.Initialize("set_pivot_y", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).pivot_y = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_769dd3a820ae436db596914379dfcbbb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_769dd3a820ae436db596914379dfcbbb()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_0b62be2a90c846158bcc0a13585b12db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b62be2a90c846158bcc0a13585b12db()
        {
          this.Initialize("set_pivot", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (Educative.Point))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).pivot = (Educative.Point) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_a06471ac0d68408a80975bb58c6dbecb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a06471ac0d68408a80975bb58c6dbecb()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_8d922d6c981d4d6084c72e09a8c30ddf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8d922d6c981d4d6084c72e09a8c30ddf()
        {
          this.Initialize("set_angle", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).angle = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_b6a279e42cf74566ad7da71a141f8b5c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b6a279e42cf74566ad7da71a141f8b5c()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_a2441801e68143ada096d5a2da6b53d6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2441801e68143ada096d5a2da6b53d6()
        {
          this.Initialize("set_onClick", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (string))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).onClick = (string) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_84eee2bf79044e9b8e11d63246ec27c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84eee2bf79044e9b8e11d63246ec27c6()
        {
          this.Initialize("get_onClick2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick2;
        }
      }

      private sealed class MTHD_3f1971bec27e45ecb89e69ed9995fad7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f1971bec27e45ecb89e69ed9995fad7()
        {
          this.Initialize("set_onClick2", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (DynValue))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).onClick2 = (DynValue) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_7082f524b4c8430dae03f76ac034f0f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7082f524b4c8430dae03f76ac034f0f7()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_c8716d04b1f34252b42097274ebd62b5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c8716d04b1f34252b42097274ebd62b5()
        {
          this.Initialize("set_color", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (string))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).color = (string) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_a0f1e85e58a64928a35b067a6af642d4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a0f1e85e58a64928a35b067a6af642d4()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color2;
        }
      }

      private sealed class MTHD_acf84532cde74851b608b890e67f228e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_acf84532cde74851b608b890e67f228e()
        {
          this.Initialize("set_color2", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (LuaColor))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).color2 = (LuaColor) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_e82ddfa8c16b4eafbc911f866238a482 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e82ddfa8c16b4eafbc911f866238a482()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_d12ed491d33649d6adeb9d15ad7635cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d12ed491d33649d6adeb9d15ad7635cb()
        {
          this.Initialize("set_text", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (string))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).text = (string) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_f1397a0363234fb2b2651b30d0bc4c98 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f1397a0363234fb2b2651b30d0bc4c98()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_7afe4aa06d154be48fffc160a5e5308a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7afe4aa06d154be48fffc160a5e5308a()
        {
          this.Initialize("set_textColor", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (string))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).textColor = (string) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_f13278c6734f4351a6fd477f04eb803a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f13278c6734f4351a6fd477f04eb803a()
        {
          this.Initialize("get_textColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor2;
        }
      }

      private sealed class MTHD_ee8cacdfa3ca4379b5c7051070f098d2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee8cacdfa3ca4379b5c7051070f098d2()
        {
          this.Initialize("set_textColor2", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (LuaColor))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).textColor2 = (LuaColor) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_5db287b5cf7247d4a780d362d1e0e59c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5db287b5cf7247d4a780d362d1e0e59c()
        {
          this.Initialize("get_highlightColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor;
        }
      }

      private sealed class MTHD_b46951d621a642dc8eaa7879a5f1da4f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b46951d621a642dc8eaa7879a5f1da4f()
        {
          this.Initialize("set_highlightColor", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (string))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).highlightColor = (string) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_6c6a4b39310d4eb6a1d97f5adecda14f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6c6a4b39310d4eb6a1d97f5adecda14f()
        {
          this.Initialize("get_highlightColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor2;
        }
      }

      private sealed class MTHD_6cfb0a0119774b2aa74a7324dae21dcf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6cfb0a0119774b2aa74a7324dae21dcf()
        {
          this.Initialize("set_highlightColor2", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (LuaColor))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).highlightColor2 = (LuaColor) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_23432812be0e4a5ab0ac92b9df5badb5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_23432812be0e4a5ab0ac92b9df5badb5()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_703a3dfd95af4cc0a3db79d882e254a0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_703a3dfd95af4cc0a3db79d882e254a0()
        {
          this.Initialize("set_textStyle", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (int))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).textStyle = (int) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_ea8158f7a3524055bcea36ae1f63e93f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea8158f7a3524055bcea36ae1f63e93f()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_e87c2c998ea645e283bf476e969f5983 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e87c2c998ea645e283bf476e969f5983()
        {
          this.Initialize("set_textSize", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (double))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).textSize = (double) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_46ddc09111284393b95c582f930feea9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_46ddc09111284393b95c582f930feea9()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_2679381803c94a6096ba13d964643750 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2679381803c94a6096ba13d964643750()
        {
          this.Initialize("createUI", true, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("script", typeof (Script)),
            new ParameterDescriptor("parent", typeof (UIElement), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return argscount <= 1 ? (object) UIElement.createUI((Script) pars[0]) : (object) UIElement.createUI((Script) pars[0], (UIElement) pars[1]);
        }
      }

      private sealed class MTHD_9fe5633ebf4e435b93bfbfb7cd452233 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9fe5633ebf4e435b93bfbfb7cd452233()
        {
          this.Initialize("createInput", true, new ParameterDescriptor[6]
          {
            new ParameterDescriptor("script", typeof (Script)),
            new ParameterDescriptor("parent", typeof (UIElement), true, (object) new DefaultValue()),
            new ParameterDescriptor("callback", typeof (string), true, (object) new DefaultValue()),
            new ParameterDescriptor("onSubmit", typeof (bool), true, (object) new DefaultValue()),
            new ParameterDescriptor("active", typeof (bool), true, (object) new DefaultValue()),
            new ParameterDescriptor("forceFocus", typeof (bool), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 1)
            return (object) UIElement.createInput((Script) pars[0]);
          if (argscount <= 2)
            return (object) UIElement.createInput((Script) pars[0], (UIElement) pars[1]);
          if (argscount <= 3)
            return (object) UIElement.createInput((Script) pars[0], (UIElement) pars[1], (string) pars[2]);
          if (argscount <= 4)
            return (object) UIElement.createInput((Script) pars[0], (UIElement) pars[1], (string) pars[2], (bool) pars[3]);
          return argscount <= 5 ? (object) UIElement.createInput((Script) pars[0], (UIElement) pars[1], (string) pars[2], (bool) pars[3], (bool) pars[4]) : (object) UIElement.createInput((Script) pars[0], (UIElement) pars[1], (string) pars[2], (bool) pars[3], (bool) pars[4], (bool) pars[5]);
        }
      }

      private sealed class MTHD_2fa79d0c174f40dea03cd8238bf70e90 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2fa79d0c174f40dea03cd8238bf70e90()
        {
          this.Initialize("duplicate", false, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("script", typeof (Script)),
            new ParameterDescriptor("parent", typeof (UIElement), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return argscount <= 1 ? (object) ((UIElement) obj).duplicate((Script) pars[0]) : (object) ((UIElement) obj).duplicate((Script) pars[0], (UIElement) pars[1]);
        }
      }

      private sealed class MTHD_02b46454c8ec4f218dd495bcf0deb378 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_02b46454c8ec4f218dd495bcf0deb378()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_7c531bea2f4746cfa86532b951b68fb9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7c531bea2f4746cfa86532b951b68fb9()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_3903f5ffbf864ceab71b84b132dfd9d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3903f5ffbf864ceab71b84b132dfd9d9()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.Equals(pars[0]);
        }
      }

      private sealed class MTHD_333b5c9be958468b9131d1a4bec8740d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_333b5c9be958468b9131d1a4bec8740d()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_cc8d337559a744c88545c95380b05e41 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cc8d337559a744c88545c95380b05e41()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_b711249a1d52466eb7de70880afcbb46 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b711249a1d52466eb7de70880afcbb46()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_c598be21a8064ed9903ab29b1f3cebe7 : HardwiredMemberDescriptor
      {
        internal PROP_c598be21a8064ed9903ab29b1f3cebe7()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_89b4528a87314505bae0f79ffa4eb0ed : HardwiredMemberDescriptor
      {
        internal PROP_89b4528a87314505bae0f79ffa4eb0ed()
          : base(typeof (bool), "visible", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).visible;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).visible = (bool) value;
        }
      }

      private sealed class PROP_72a0be43f9134e8daf1ebe187dc7bbb8 : HardwiredMemberDescriptor
      {
        internal PROP_72a0be43f9134e8daf1ebe187dc7bbb8()
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

      private sealed class PROP_511a6544abf44189aa5d2b6e3ac04ac9 : HardwiredMemberDescriptor
      {
        internal PROP_511a6544abf44189aa5d2b6e3ac04ac9()
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

      private sealed class PROP_8ac62d8bc94a4de195fd48349221969e : HardwiredMemberDescriptor
      {
        internal PROP_8ac62d8bc94a4de195fd48349221969e()
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

      private sealed class PROP_b9bf9b9e5e8349a69d5681ec8225c229 : HardwiredMemberDescriptor
      {
        internal PROP_b9bf9b9e5e8349a69d5681ec8225c229()
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

      private sealed class PROP_317a013208ee45ddae9cef08c58e00d8 : HardwiredMemberDescriptor
      {
        internal PROP_317a013208ee45ddae9cef08c58e00d8()
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

      private sealed class PROP_211a3ea53d6549b3a65267cdfca932c4 : HardwiredMemberDescriptor
      {
        internal PROP_211a3ea53d6549b3a65267cdfca932c4()
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

      private sealed class PROP_f848a194f35e49eab10abbfbbbc7ad3f : HardwiredMemberDescriptor
      {
        internal PROP_f848a194f35e49eab10abbfbbbc7ad3f()
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

      private sealed class PROP_23c5da2a556b4352b1f41df364eb4e08 : HardwiredMemberDescriptor
      {
        internal PROP_23c5da2a556b4352b1f41df364eb4e08()
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

      private sealed class PROP_2b1e409f51fb416caa2ee63d71dc9dd7 : HardwiredMemberDescriptor
      {
        internal PROP_2b1e409f51fb416caa2ee63d71dc9dd7()
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

      private sealed class PROP_4b41f70b62ad4fb79a73e00034c9501c : HardwiredMemberDescriptor
      {
        internal PROP_4b41f70b62ad4fb79a73e00034c9501c()
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

      private sealed class PROP_58479c21d3e94a04aed9966e22b8ad6b : HardwiredMemberDescriptor
      {
        internal PROP_58479c21d3e94a04aed9966e22b8ad6b()
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

      private sealed class PROP_873659bc8adf47c48d0bb6d94300cd27 : HardwiredMemberDescriptor
      {
        internal PROP_873659bc8adf47c48d0bb6d94300cd27()
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

      private sealed class PROP_6ebf9fde7c62466dbccd2d29ef962da0 : HardwiredMemberDescriptor
      {
        internal PROP_6ebf9fde7c62466dbccd2d29ef962da0()
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

      private sealed class PROP_4ae17ec15983403f932e9881b8e62ede : HardwiredMemberDescriptor
      {
        internal PROP_4ae17ec15983403f932e9881b8e62ede()
          : base(typeof (DynValue), "onClick2", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).onClick2;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).onClick2 = (DynValue) value;
        }
      }

      private sealed class PROP_5205c3aefbc24ec5a0ddc99006b7558a : HardwiredMemberDescriptor
      {
        internal PROP_5205c3aefbc24ec5a0ddc99006b7558a()
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

      private sealed class PROP_559ba22b570d42db8c3906160f33c1d7 : HardwiredMemberDescriptor
      {
        internal PROP_559ba22b570d42db8c3906160f33c1d7()
          : base(typeof (LuaColor), "color2", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).color2;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).color2 = (LuaColor) value;
        }
      }

      private sealed class PROP_b85a66a4bd8745b1a7ad29c28a2afe09 : HardwiredMemberDescriptor
      {
        internal PROP_b85a66a4bd8745b1a7ad29c28a2afe09()
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

      private sealed class PROP_24137fd083c649ab8082c05adf1209b4 : HardwiredMemberDescriptor
      {
        internal PROP_24137fd083c649ab8082c05adf1209b4()
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

      private sealed class PROP_246c4ea28a794a8b8d7cb61e41308e37 : HardwiredMemberDescriptor
      {
        internal PROP_246c4ea28a794a8b8d7cb61e41308e37()
          : base(typeof (LuaColor), "textColor2", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).textColor2;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).textColor2 = (LuaColor) value;
        }
      }

      private sealed class PROP_777d570e320d45f4bd3b7e7ce51a01e2 : HardwiredMemberDescriptor
      {
        internal PROP_777d570e320d45f4bd3b7e7ce51a01e2()
          : base(typeof (string), "highlightColor", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).highlightColor;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).highlightColor = (string) value;
        }
      }

      private sealed class PROP_d9f2df9902cf4158905b8eb233dbe6e7 : HardwiredMemberDescriptor
      {
        internal PROP_d9f2df9902cf4158905b8eb233dbe6e7()
          : base(typeof (LuaColor), "highlightColor2", false, MemberDescriptorAccess.CanRead | MemberDescriptorAccess.CanWrite)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).highlightColor2;
        }

        protected override void SetValueImpl(Script script, object obj, object value)
        {
          ((UIElement) obj).highlightColor2 = (LuaColor) value;
        }
      }

      private sealed class PROP_2e2549d8cefb4d4d8787e366683fd092 : HardwiredMemberDescriptor
      {
        internal PROP_2e2549d8cefb4d4d8787e366683fd092()
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

      private sealed class PROP_9b843237b4d74841b3222f48b01b40ad : HardwiredMemberDescriptor
      {
        internal PROP_9b843237b4d74841b3222f48b01b40ad()
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

      private sealed class FLDV_4c0ac182acce4df1a797acd941697ff9 : HardwiredMemberDescriptor
      {
        internal FLDV_4c0ac182acce4df1a797acd941697ff9()
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

      private sealed class FLDV_72341e1acc6844789bc421b8b5c2ce88 : HardwiredMemberDescriptor
      {
        internal FLDV_72341e1acc6844789bc421b8b5c2ce88()
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

      private sealed class FLDV_a3d14858430a4f6caaf6e386ae0f64cd : HardwiredMemberDescriptor
      {
        internal FLDV_a3d14858430a4f6caaf6e386ae0f64cd()
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

    private sealed class TYPE_eb2d1f5d3d3e4806b39bf2ee6467ab89 : HardwiredUserDataDescriptor
    {
      internal TYPE_eb2d1f5d3d3e4806b39bf2ee6467ab89()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb2d1f5d3d3e4806b39bf2ee6467ab89.MTHD_0e8cef6ffc3449159584c89ec41c5b32()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb2d1f5d3d3e4806b39bf2ee6467ab89.MTHD_366f0cd2259143fcaede65ec6a68857d()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb2d1f5d3d3e4806b39bf2ee6467ab89.MTHD_2bb2cac1c86d4ca5a545f8a0cc2264a5()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb2d1f5d3d3e4806b39bf2ee6467ab89.MTHD_8f5643345d7c45cba68942bf6bf2192d()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb2d1f5d3d3e4806b39bf2ee6467ab89.MTHD_7fabf6f6b5a549aea570f2ce19926612()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eb2d1f5d3d3e4806b39bf2ee6467ab89.MTHD_b24a696b4a454a9a9d7e0f4d2b8d1876()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_eb2d1f5d3d3e4806b39bf2ee6467ab89.FLDV_77b5d394ed6e4905b0f8253c4f3ea001());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_eb2d1f5d3d3e4806b39bf2ee6467ab89.FLDV_3b0a325ad54443c486ee9a4815354f2b());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_eb2d1f5d3d3e4806b39bf2ee6467ab89.FLDV_7f7e029412144097894b48532b6de703());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_eb2d1f5d3d3e4806b39bf2ee6467ab89.FLDV_02fd8181053c48db8c161bdb33f56996());
      }

      private sealed class MTHD_0e8cef6ffc3449159584c89ec41c5b32 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e8cef6ffc3449159584c89ec41c5b32()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_366f0cd2259143fcaede65ec6a68857d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_366f0cd2259143fcaede65ec6a68857d()
        {
          this.Initialize("addAnswer", false, new ParameterDescriptor[3]
          {
            new ParameterDescriptor("answer", typeof (string)),
            new ParameterDescriptor("checkable", typeof (bool), true, (object) new DefaultValue()),
            new ParameterDescriptor("allowUserInput", typeof (bool), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 1)
            return (object) ((MyPoll.Item) obj).addAnswer((string) pars[0]);
          return argscount <= 2 ? (object) ((MyPoll.Item) obj).addAnswer((string) pars[0], (bool) pars[1]) : (object) ((MyPoll.Item) obj).addAnswer((string) pars[0], (bool) pars[1], (bool) pars[2]);
        }
      }

      private sealed class MTHD_2bb2cac1c86d4ca5a545f8a0cc2264a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2bb2cac1c86d4ca5a545f8a0cc2264a5()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.Equals(pars[0]);
        }
      }

      private sealed class MTHD_8f5643345d7c45cba68942bf6bf2192d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8f5643345d7c45cba68942bf6bf2192d()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_7fabf6f6b5a549aea570f2ce19926612 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7fabf6f6b5a549aea570f2ce19926612()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_b24a696b4a454a9a9d7e0f4d2b8d1876 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b24a696b4a454a9a9d7e0f4d2b8d1876()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_77b5d394ed6e4905b0f8253c4f3ea001 : HardwiredMemberDescriptor
      {
        internal FLDV_77b5d394ed6e4905b0f8253c4f3ea001()
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

      private sealed class FLDV_3b0a325ad54443c486ee9a4815354f2b : HardwiredMemberDescriptor
      {
        internal FLDV_3b0a325ad54443c486ee9a4815354f2b()
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

      private sealed class FLDV_7f7e029412144097894b48532b6de703 : HardwiredMemberDescriptor
      {
        internal FLDV_7f7e029412144097894b48532b6de703()
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

      private sealed class FLDV_02fd8181053c48db8c161bdb33f56996 : HardwiredMemberDescriptor
      {
        internal FLDV_02fd8181053c48db8c161bdb33f56996()
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

    private sealed class TYPE_87bcf4fbcf2247668204877d13ace778 : HardwiredUserDataDescriptor
    {
      internal TYPE_87bcf4fbcf2247668204877d13ace778()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_87bcf4fbcf2247668204877d13ace778.MTHD_522ab179f2574756be83ca5ae40f6b5a()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_87bcf4fbcf2247668204877d13ace778.MTHD_69a9beb9bb1940338f6b0e235a7b4618()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_87bcf4fbcf2247668204877d13ace778.MTHD_ce2d620048bc42a1862c356ee281625d()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_87bcf4fbcf2247668204877d13ace778.MTHD_b021a2ad379945399154bbdc8ca84054()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_87bcf4fbcf2247668204877d13ace778.MTHD_ae073c2b82e1410eba7db759dce14ae7()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_87bcf4fbcf2247668204877d13ace778.FLDV_85756c7f567148aaabd77791becc9135());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_87bcf4fbcf2247668204877d13ace778.FLDV_c1ceebac4b7b495c8ec7cd090053c204());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_87bcf4fbcf2247668204877d13ace778.FLDV_15e594a960ab408bb0b922d76bab6bbc());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_87bcf4fbcf2247668204877d13ace778.FLDV_62da79d1bc26470ab47ee16cf67c72bd());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_87bcf4fbcf2247668204877d13ace778.FLDV_a41b4439d131435b9ba6b54fc8226a5d());
      }

      private sealed class MTHD_522ab179f2574756be83ca5ae40f6b5a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_522ab179f2574756be83ca5ae40f6b5a()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_69a9beb9bb1940338f6b0e235a7b4618 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69a9beb9bb1940338f6b0e235a7b4618()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.Equals(pars[0]);
        }
      }

      private sealed class MTHD_ce2d620048bc42a1862c356ee281625d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ce2d620048bc42a1862c356ee281625d()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_b021a2ad379945399154bbdc8ca84054 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b021a2ad379945399154bbdc8ca84054()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_ae073c2b82e1410eba7db759dce14ae7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae073c2b82e1410eba7db759dce14ae7()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_85756c7f567148aaabd77791becc9135 : HardwiredMemberDescriptor
      {
        internal FLDV_85756c7f567148aaabd77791becc9135()
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

      private sealed class FLDV_c1ceebac4b7b495c8ec7cd090053c204 : HardwiredMemberDescriptor
      {
        internal FLDV_c1ceebac4b7b495c8ec7cd090053c204()
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

      private sealed class FLDV_15e594a960ab408bb0b922d76bab6bbc : HardwiredMemberDescriptor
      {
        internal FLDV_15e594a960ab408bb0b922d76bab6bbc()
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

      private sealed class FLDV_62da79d1bc26470ab47ee16cf67c72bd : HardwiredMemberDescriptor
      {
        internal FLDV_62da79d1bc26470ab47ee16cf67c72bd()
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

      private sealed class FLDV_a41b4439d131435b9ba6b54fc8226a5d : HardwiredMemberDescriptor
      {
        internal FLDV_a41b4439d131435b9ba6b54fc8226a5d()
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

    private sealed class TYPE_1c424c6f2d244b88b7503e2539f94186 : HardwiredUserDataDescriptor
    {
      internal TYPE_1c424c6f2d244b88b7503e2539f94186()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c424c6f2d244b88b7503e2539f94186.MTHD_bf95041713e148349f509031f09c4ce2()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c424c6f2d244b88b7503e2539f94186.MTHD_e13cd582fd01414eafbdc41a1d6ea5a9()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c424c6f2d244b88b7503e2539f94186.MTHD_0a44abbe733b41abb2d840359538019b()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c424c6f2d244b88b7503e2539f94186.MTHD_0877383a5c7f4b9ca7ac9d8b3e0dbb35()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c424c6f2d244b88b7503e2539f94186.MTHD_e96ad68938864e9188bb13935b6aad5e()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c424c6f2d244b88b7503e2539f94186.MTHD_f3b79905a7d14a0abe1341996743a5c4()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c424c6f2d244b88b7503e2539f94186.MTHD_e016900e67644d9a876abaed9b670cd1()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c424c6f2d244b88b7503e2539f94186.MTHD_da0caec823014e98ab0a847c0a74e40d()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c424c6f2d244b88b7503e2539f94186.MTHD_e8f70773f1bb4e70876f0b2266e6f800()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c424c6f2d244b88b7503e2539f94186.MTHD_aa0f39b572dd4c9bac9575b065761a73()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c424c6f2d244b88b7503e2539f94186.MTHD_69587c61122f4694a5cab3b0959d74a0()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c424c6f2d244b88b7503e2539f94186.MTHD_b7268c4ceb96403e9c0de64ec79e6476()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c424c6f2d244b88b7503e2539f94186.MTHD_d7a7de5b694e43069c5898ffa17a0c75()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_1c424c6f2d244b88b7503e2539f94186.FLDV_4677a26e779a4412b5ab4c6c5b4ef5a7());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_1c424c6f2d244b88b7503e2539f94186.FLDV_bb54b4b27dec45b788a9d6c16d13e5db());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_1c424c6f2d244b88b7503e2539f94186.FLDV_f4178d9b6de14240a1f66d593b6b638d());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_1c424c6f2d244b88b7503e2539f94186.FLDV_fbe3f6f6ec7540c4b5a5c9aaedf36b80());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_1c424c6f2d244b88b7503e2539f94186.FLDV_3154e5dafe4c489a8479caa12a26800c());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_1c424c6f2d244b88b7503e2539f94186.FLDV_cce78834390e4ab2b2ce4879cdee019a());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_1c424c6f2d244b88b7503e2539f94186.FLDV_ed2a0d49c21e47ea89f13e180dce2b2b());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_1c424c6f2d244b88b7503e2539f94186.FLDV_9021a615cd924bf09bf0a1f81f7586bc());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_1c424c6f2d244b88b7503e2539f94186.DVAL_10cb5059702048b68cc045aab528c919());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_1c424c6f2d244b88b7503e2539f94186.DVAL_d3a822b830bb4f349581ad3866956807());
      }

      private sealed class MTHD_bf95041713e148349f509031f09c4ce2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf95041713e148349f509031f09c4ce2()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_e13cd582fd01414eafbdc41a1d6ea5a9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e13cd582fd01414eafbdc41a1d6ea5a9()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_0a44abbe733b41abb2d840359538019b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0a44abbe733b41abb2d840359538019b()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_0877383a5c7f4b9ca7ac9d8b3e0dbb35 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0877383a5c7f4b9ca7ac9d8b3e0dbb35()
        {
          this.Initialize("addItem", false, new ParameterDescriptor[3]
          {
            new ParameterDescriptor("question", typeof (string)),
            new ParameterDescriptor("multipleSelection", typeof (bool), true, (object) new DefaultValue()),
            new ParameterDescriptor("requireAnswer", typeof (bool), true, (object) new DefaultValue())
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 1)
            return (object) ((MyPoll) obj).addItem((string) pars[0]);
          return argscount <= 2 ? (object) ((MyPoll) obj).addItem((string) pars[0], (bool) pars[1]) : (object) ((MyPoll) obj).addItem((string) pars[0], (bool) pars[1], (bool) pars[2]);
        }
      }

      private sealed class MTHD_e96ad68938864e9188bb13935b6aad5e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e96ad68938864e9188bb13935b6aad5e()
        {
          this.Initialize("construct", true, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("name", typeof (string))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) MyPoll.construct((string) pars[0]);
        }
      }

      private sealed class MTHD_f3b79905a7d14a0abe1341996743a5c4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f3b79905a7d14a0abe1341996743a5c4()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_e016900e67644d9a876abaed9b670cd1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e016900e67644d9a876abaed9b670cd1()
        {
          this.Initialize("fromString", true, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("s", typeof (string))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) MyPoll.fromString((string) pars[0]);
        }
      }

      private sealed class MTHD_da0caec823014e98ab0a847c0a74e40d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_da0caec823014e98ab0a847c0a74e40d()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_e8f70773f1bb4e70876f0b2266e6f800 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e8f70773f1bb4e70876f0b2266e6f800()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_aa0f39b572dd4c9bac9575b065761a73 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa0f39b572dd4c9bac9575b065761a73()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_69587c61122f4694a5cab3b0959d74a0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69587c61122f4694a5cab3b0959d74a0()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.Equals(pars[0]);
        }
      }

      private sealed class MTHD_b7268c4ceb96403e9c0de64ec79e6476 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b7268c4ceb96403e9c0de64ec79e6476()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_d7a7de5b694e43069c5898ffa17a0c75 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d7a7de5b694e43069c5898ffa17a0c75()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_4677a26e779a4412b5ab4c6c5b4ef5a7 : HardwiredMemberDescriptor
      {
        internal FLDV_4677a26e779a4412b5ab4c6c5b4ef5a7()
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

      private sealed class FLDV_bb54b4b27dec45b788a9d6c16d13e5db : HardwiredMemberDescriptor
      {
        internal FLDV_bb54b4b27dec45b788a9d6c16d13e5db()
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

      private sealed class FLDV_f4178d9b6de14240a1f66d593b6b638d : HardwiredMemberDescriptor
      {
        internal FLDV_f4178d9b6de14240a1f66d593b6b638d()
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

      private sealed class FLDV_fbe3f6f6ec7540c4b5a5c9aaedf36b80 : HardwiredMemberDescriptor
      {
        internal FLDV_fbe3f6f6ec7540c4b5a5c9aaedf36b80()
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

      private sealed class FLDV_3154e5dafe4c489a8479caa12a26800c : HardwiredMemberDescriptor
      {
        internal FLDV_3154e5dafe4c489a8479caa12a26800c()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj) => (object) (byte) 1;
      }

      private sealed class FLDV_cce78834390e4ab2b2ce4879cdee019a : HardwiredMemberDescriptor
      {
        internal FLDV_cce78834390e4ab2b2ce4879cdee019a()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj) => (object) (byte) 2;
      }

      private sealed class FLDV_ed2a0d49c21e47ea89f13e180dce2b2b : HardwiredMemberDescriptor
      {
        internal FLDV_ed2a0d49c21e47ea89f13e180dce2b2b()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj) => (object) (byte) 3;
      }

      private sealed class FLDV_9021a615cd924bf09bf0a1f81f7586bc : HardwiredMemberDescriptor
      {
        internal FLDV_9021a615cd924bf09bf0a1f81f7586bc()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj) => (object) (byte) 4;
      }

      private sealed class DVAL_10cb5059702048b68cc045aab528c919 : DynValueMemberDescriptor
      {
        internal DVAL_10cb5059702048b68cc045aab528c919()
          : base("Item")
        {
        }

        public override DynValue Value => UserData.CreateStatic(typeof (MyPoll.Item));
      }

      private sealed class DVAL_d3a822b830bb4f349581ad3866956807 : DynValueMemberDescriptor
      {
        internal DVAL_d3a822b830bb4f349581ad3866956807()
          : base("Answer")
        {
        }

        public override DynValue Value => UserData.CreateStatic(typeof (MyPoll.Answer));
      }
    }

    private sealed class TYPE_4bd0d34446364d379e801dfa0a2ef6ab : HardwiredUserDataDescriptor
    {
      internal TYPE_4bd0d34446364d379e801dfa0a2ef6ab()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd0d34446364d379e801dfa0a2ef6ab.MTHD_dd2a94c8173f4a2a8ed6418614677dc1()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd0d34446364d379e801dfa0a2ef6ab.MTHD_76150c5cf62643cb9292cf45e8140acc()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd0d34446364d379e801dfa0a2ef6ab.MTHD_8b61555e982d459890fc7826a5efb1c7(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd0d34446364d379e801dfa0a2ef6ab.MTHD_1426be1d22c14ece8a19ec820b47b8bb()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd0d34446364d379e801dfa0a2ef6ab.MTHD_687e2cde53af440cb0176324727dca2b(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd0d34446364d379e801dfa0a2ef6ab.MTHD_894bf77c1bcf46808c530db5d629914d()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd0d34446364d379e801dfa0a2ef6ab.MTHD_5620d52a066e44679ecf5a89cacbd569()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd0d34446364d379e801dfa0a2ef6ab.MTHD_8b80b5bdce9948d2afe46a019eb3a7bb()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd0d34446364d379e801dfa0a2ef6ab.MTHD_209e8f86ff0744e69cf06c483ba70abd()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd0d34446364d379e801dfa0a2ef6ab.MTHD_c4976afbe97749ddbf8498d6fe73d244()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_4bd0d34446364d379e801dfa0a2ef6ab.FLDV_cfc142b64d504fee84be6079df2b838c());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_4bd0d34446364d379e801dfa0a2ef6ab.FLDV_8d2d1830c37c43acb8d296905e70b7a2());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_4bd0d34446364d379e801dfa0a2ef6ab.FLDV_b565fe337f1a4173831d452a745c1f08());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_4bd0d34446364d379e801dfa0a2ef6ab.FLDV_660767cb461d4b9c889659d5f25c648d());
        this.AddMember("white", (IMemberDescriptor) new Bridge.TYPE_4bd0d34446364d379e801dfa0a2ef6ab.FLDV_2c28c03b683545458fcc4db4061faa7d());
      }

      private sealed class MTHD_dd2a94c8173f4a2a8ed6418614677dc1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dd2a94c8173f4a2a8ed6418614677dc1()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_76150c5cf62643cb9292cf45e8140acc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76150c5cf62643cb9292cf45e8140acc()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_8b61555e982d459890fc7826a5efb1c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b61555e982d459890fc7826a5efb1c7()
        {
          this.Initialize("construct", true, new ParameterDescriptor[4]
          {
            new ParameterDescriptor("r", typeof (byte)),
            new ParameterDescriptor("g", typeof (byte)),
            new ParameterDescriptor("b", typeof (byte)),
            new ParameterDescriptor("a", typeof (byte))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) LuaColor.construct((byte) pars[0], (byte) pars[1], (byte) pars[2], (byte) pars[3]);
        }
      }

      private sealed class MTHD_1426be1d22c14ece8a19ec820b47b8bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1426be1d22c14ece8a19ec820b47b8bb()
        {
          this.Initialize("construct", true, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("hex", typeof (string))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) LuaColor.construct((string) pars[0]);
        }
      }

      private sealed class MTHD_687e2cde53af440cb0176324727dca2b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_687e2cde53af440cb0176324727dca2b()
        {
          this.Initialize("From", true, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("c", typeof (Color32))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) LuaColor.From((Color32) pars[0]);
        }
      }

      private sealed class MTHD_894bf77c1bcf46808c530db5d629914d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_894bf77c1bcf46808c530db5d629914d()
        {
          this.Initialize("From", true, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("c", typeof (LuaColor))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) LuaColor.From((LuaColor) pars[0]);
        }
      }

      private sealed class MTHD_5620d52a066e44679ecf5a89cacbd569 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5620d52a066e44679ecf5a89cacbd569()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.Equals(pars[0]);
        }
      }

      private sealed class MTHD_8b80b5bdce9948d2afe46a019eb3a7bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b80b5bdce9948d2afe46a019eb3a7bb()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_209e8f86ff0744e69cf06c483ba70abd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_209e8f86ff0744e69cf06c483ba70abd()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_c4976afbe97749ddbf8498d6fe73d244 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c4976afbe97749ddbf8498d6fe73d244()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_cfc142b64d504fee84be6079df2b838c : HardwiredMemberDescriptor
      {
        internal FLDV_cfc142b64d504fee84be6079df2b838c()
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

      private sealed class FLDV_8d2d1830c37c43acb8d296905e70b7a2 : HardwiredMemberDescriptor
      {
        internal FLDV_8d2d1830c37c43acb8d296905e70b7a2()
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

      private sealed class FLDV_b565fe337f1a4173831d452a745c1f08 : HardwiredMemberDescriptor
      {
        internal FLDV_b565fe337f1a4173831d452a745c1f08()
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

      private sealed class FLDV_660767cb461d4b9c889659d5f25c648d : HardwiredMemberDescriptor
      {
        internal FLDV_660767cb461d4b9c889659d5f25c648d()
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

      private sealed class FLDV_2c28c03b683545458fcc4db4061faa7d : HardwiredMemberDescriptor
      {
        internal FLDV_2c28c03b683545458fcc4db4061faa7d()
          : base(typeof (LuaColor), "white", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) LuaColor.white;
        }
      }
    }

    private sealed class TYPE_31f415a7efe944b0ae73947aa2fe0855 : HardwiredUserDataDescriptor
    {
      internal TYPE_31f415a7efe944b0ae73947aa2fe0855()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31f415a7efe944b0ae73947aa2fe0855.MTHD_67289688f6634863953d5675e6bfd7c5()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31f415a7efe944b0ae73947aa2fe0855.MTHD_a9a2af9bc6dd47d8bea6a56ebb2bde87()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31f415a7efe944b0ae73947aa2fe0855.MTHD_67edd2c450ca4fd9a6f4a6147c5f81bd()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31f415a7efe944b0ae73947aa2fe0855.MTHD_5af54738af1849d583c122e32bc7d700()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31f415a7efe944b0ae73947aa2fe0855.MTHD_a356df266efb417e8411338d48867a6d()
        }));
      }

      private sealed class MTHD_67289688f6634863953d5675e6bfd7c5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67289688f6634863953d5675e6bfd7c5()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_a9a2af9bc6dd47d8bea6a56ebb2bde87 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a9a2af9bc6dd47d8bea6a56ebb2bde87()
        {
          this.Initialize("Equals", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("obj", typeof (object))
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.Equals(pars[0]);
        }
      }

      private sealed class MTHD_67edd2c450ca4fd9a6f4a6147c5f81bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67edd2c450ca4fd9a6f4a6147c5f81bd()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_5af54738af1849d583c122e32bc7d700 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5af54738af1849d583c122e32bc7d700()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_a356df266efb417e8411338d48867a6d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a356df266efb417e8411338d48867a6d()
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
