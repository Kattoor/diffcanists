
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
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_0f7458cc1147419497003baa011fc6b9());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_2212dae513cb4a0ead87e44402681c98());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_9f9fb89427124bc29313e6f5d5ae8f1f());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_5a4aa814ada44711985cc95172db024c());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_61b6fbb74f13485eaa47b577e0759ef5());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_e8360457ba8e4cc780163978b566cde7());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_eec1e86cf01548b8b41ba0ab3b502b8b());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_7821c251a9bc412f92ec9bb115287fe9());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_1c9689f2e0ce47cdbf4ad5c9658d5c10());
    }

    private sealed class TYPE_290f23cc77a74733b4f45d014f0b2786 : HardwiredUserDataDescriptor
    {
      internal TYPE_290f23cc77a74733b4f45d014f0b2786()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_5ba70d8326a54d139bf7cbe64991e0c7()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_1247a05667924b83bb8ac47a9b2141c7()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_866a76d6eaf34ebd9946bbaf2eb2ff30()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_8ca52b979e014d90bcdd822b9c753319()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_88a50419e80d44afaba5bb80b6deb355()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_5b917f997b934c5583a7bde087c1d51e()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_00140bdb811e44c8bc1ae5dcec17d768()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_e893da7cebb242a49b52da4ec10b4196()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_302299053c70416594839a0f430e5375()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_61cacd1082964393b45549181e9cebfc()
        }));
        this.AddMember("hideInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("hideInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_96fe169b245d43788052e71d6c5b0ac7()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_979cfcbb4a524ef9ace922c9fa447f39()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_ea63aa59fbda4ce1bb9e8a97c37ef8d3()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_3a0a3abf818c4656a82219b5e615bed0()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_5474363bd4f74528ac250828019b5aba()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_9edc36e9ee9241939ce835d2c769bb10()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_dc0ab9fd9c21437c9f567485f8fd3551()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_db8661f8953a4f47a0d996d212020917()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_4dbf851311294e2f98298456a1188efd()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_77bd0925ca0342cf8f8a31bbceb03ad0()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_d4fea5884ab047b3aeac9ade42a76457()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_7a1d14e16e0c445d84c30aadeba73bbe()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_d4bd8a106512482c89270739b03c3a92()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_48805f97bc90446684a7277271c7c0f4()
        }));
        this.AddMember("get_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_ec799bd51adf4a02942bbeb965a20cb4()
        }));
        this.AddMember("set_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_cf4fc27a72e0425696623c4b0de448f5()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_a55cce35de1942bda8ef8523e64a5f4a()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_02fb58e526f5448194feb7c7b73a4e6e()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_27f3505d526e4b1fb0bde430d5ca6338()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_4330ff1458574d919eedfadb90df16c9()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_2a681e126c994ef3b19a519d7e93c987()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_991488a453874e11928d1b588d80d464()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_9e06d7303cfb42b7913cfb446ce8f236()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_2899c275b2174372b41e50771d2a1930()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_fda5fc51935549db9f1429bd4ca0d361()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_bb2e930450184e25b2a87dff14317ce4()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_e3585cb0eb9944d7aeeb74146e510332()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_b4a82abcb32b4d12a7e8489db0f2596b()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_da38970710264ec4b6f5e1683e446568()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_2b42175aaa8542359273330499019b63()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_c7d89bfd8dcb4cb4a250cee63270d2e7()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_6ce61074bac94e1aa96caec09a926d39()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_5c466913e4164cf18af7d58e3580cab7()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_092c9efe4c05473b92a1715346c7f121()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_a9e9913189074740bfa60970ec3af9d6()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_bae17f6b19c443829a42bbd938f8398d()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_8984295ed40745b1b4a98bb3d9447992()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_20994dca9827447f844644b3b9110874()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_7c455de27961406182f1a3a9ed5580fa()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_4adffe3b74814d3b89a45876d46c63e4()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_2cd11a122c474008aa1524e7b1d5cc67()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_e2d17421c6ab44009af4ea6d147ffdff()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_60a6bcee85704d54986377145f6b8e3e()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_e781d87989924f6982a1b33c8ca6f9bf()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_8025c83a8fbc4370a32bbd381fc9a2de()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_b13b9b4d37444932ba4f2f39fc44d951()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_a2cfa59ed22f439db21e7f04d9ab531e()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_ab0d5cca970c40ac9192e25f50f2353d()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_4ba034325ab2400eb4619ae285b9e59f()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_5843b74048f147608c8c07ccad93d8e2()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_8b276c94b2864a4389a4712c2d298869()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_7f62a3844a3e4f5ea77996f047969894()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_5cf939577620434fb4e243deb1dff2a1()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_d56a797dc015480e9de8437920519e62()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_db8ae14538e4441f910607c0ba251c10()
        }));
        this.AddMember("Dispose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Dispose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_9aee6043797b4405b4d9b256b2ea85b7()
        }));
        this.AddMember("drawImage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawImage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_b497f17dbf5f49cb93c3a5773eac7238()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_edc1e3acd74b4a4c88de3ed6817b99c0()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_0c7c772c8a3a4e1d92fa539d3d066509()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_5075aebc9f19440d90eb49f5ec961a7c()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_2d312b9084b64d71b20c8fe3bede34b8()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_eb9c5d61c86f4646a8cb85c4b44c16e6()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_6227154dd9e74ac5b067824b36665db5()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_7bd93a4bffc94d52b2d696b5ad4772aa()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_26ad239e7dab48a3868abfc1161d7bf4()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_d6b1b247c0784158b9caac10acef047e()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_8447d2491f1c415a957fa6fc532f0e80()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_bd19236dd7a1434cb71c014f339e1c84()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_d69b34b220104fd3812064346e8e59be()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_6bcc9acf7cb0450487f80b77f0aafd1e()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_c90c6261af4b4aebac8c89c4b3569e6f()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_9c0496ccdb4a4f458b64fe7c0c1d61e1()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_ce48eea64c8d422d985a51815cbe6c9f()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_01a2e54c026a4b728044f4b4d62c649f()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_78574e9d906145f68fce05f41c9929f5()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_12c097cacecf4157897ca3d4045e4f35()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_7c2d8e0d5bfe4dbd9c7b7de83f628434()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_53b1287919524c858018a675bdf27700()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_7bc78033ac434f2e872381005fbfcce0()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_0468b81b233f4bcf88773c6a4e8a4270()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_49adb38b03604f61b97284adc6c0dd70()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_58e5bdca108a48f2881d55c661aa41b7()
        }));
        this.AddMember("cameraFollow", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("cameraFollow", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_31ccf28a079b42bfbc1379b31bf57d47()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_4dc0b64bb6584dc5ac0a5e09f0c476aa()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_1ec97bd5928c4af2bea478819bf366e0()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_a974072b84ab4840a5bef536f84a3e2a()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_83a46f1a0ccf4399a8dd6d39674b43fe()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_8697a85eb0d14e08a01ed870db3f4db7()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_f72924a0598c493aa8ed882707f708a1(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_ab8c57c658df429e90bddcaaf0eaed7a()
        }));
        this.AddMember("getKeyBinds", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getKeyBinds", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_93c9ccc170854da39456b17855ae1ddc()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_f3887e402a3f4a90b05a22b83d544302()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_9f049820d9f349aab9d8d24277971ca6()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_81c356cb8e7c4b5786f3a77aa12912c0()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.MTHD_296654983526407da03148586b31c516()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_46c80548a5a347519a4bd69187040003());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_a8d4ac9b56f543f9a37ae28b63dae0bd());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_4ce6040183024891852cdee219ca0200());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_45599c2c065f4917985e520c4e0819df());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_612ea6e86e194b1082935415a27cf91b());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_f08a5b24d51842a398aba457f8cad8a5());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_8c3d1fa9be7e49b5814b9ba9526970a6());
        this.AddMember("allowMinionMovement", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_cd93459982034d2b858db8c7d429d96e());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_4362391fde044560a446ff000d0dd67f());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_c0ec2e41a9454154b0eadb71ff80fea9());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_d24427e8b88145da98c31c2188184ec6());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_919f400adbaf4d15909de5df3f88f282());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_fd80ec87ded84e6296caaecd0fccb8d2());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_01123af79d0e4a7584f41f77289b4d70());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_21c816799ae046a69793d6e261cff1ec());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_8825c68d9199406681437bffb5e202bf());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_d8054dc6a582464990644d96cb938811());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_d32cd377fbf4495a841dfbd30e801983());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_4190cccffbc540f2a42295c729c3221a());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_7cffcf1078544e81aa03558f345d0b06());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_3459d64cb02b4370afd930d516e58fe0());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_662ae3166b094af29c29de6ddf48272e());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_d90f994a5b614a8d900cbf91f55b69d7());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_61da1fcda97d47cda4bea3f2b1bac4ea());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_4d59d25bd2f24764ba0bb982acf3d559());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_c91c4425727f4c599eb1d3c83f3a4867());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_019445233b2a4abdb6c64081d49727cc());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_fead447a8d094ddfb8c31ec0d3964e9b());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_e7666f8f01974dba996c319d298fc882());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_8eba573c5c5748899cbeb4180450acd7());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_e6f014b30b514263a836c566a001ed15());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_2c2a7b717e2940679f43bba784b8fe2b());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_290f23cc77a74733b4f45d014f0b2786.PROP_662a71c28e684392902acf69deadd235());
      }

      private sealed class MTHD_5ba70d8326a54d139bf7cbe64991e0c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ba70d8326a54d139bf7cbe64991e0c7()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_1247a05667924b83bb8ac47a9b2141c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1247a05667924b83bb8ac47a9b2141c7()
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

      private sealed class MTHD_866a76d6eaf34ebd9946bbaf2eb2ff30 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_866a76d6eaf34ebd9946bbaf2eb2ff30()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_8ca52b979e014d90bcdd822b9c753319 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ca52b979e014d90bcdd822b9c753319()
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

      private sealed class MTHD_88a50419e80d44afaba5bb80b6deb355 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_88a50419e80d44afaba5bb80b6deb355()
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

      private sealed class MTHD_5b917f997b934c5583a7bde087c1d51e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b917f997b934c5583a7bde087c1d51e()
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

      private sealed class MTHD_00140bdb811e44c8bc1ae5dcec17d768 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_00140bdb811e44c8bc1ae5dcec17d768()
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

      private sealed class MTHD_e893da7cebb242a49b52da4ec10b4196 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e893da7cebb242a49b52da4ec10b4196()
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

      private sealed class MTHD_302299053c70416594839a0f430e5375 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_302299053c70416594839a0f430e5375()
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

      private sealed class MTHD_61cacd1082964393b45549181e9cebfc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_61cacd1082964393b45549181e9cebfc()
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

      private sealed class MTHD_96fe169b245d43788052e71d6c5b0ac7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_96fe169b245d43788052e71d6c5b0ac7()
        {
          this.Initialize("hideInfo", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).hideInfo();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_979cfcbb4a524ef9ace922c9fa447f39 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_979cfcbb4a524ef9ace922c9fa447f39()
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

      private sealed class MTHD_ea63aa59fbda4ce1bb9e8a97c37ef8d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea63aa59fbda4ce1bb9e8a97c37ef8d3()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_3a0a3abf818c4656a82219b5e615bed0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3a0a3abf818c4656a82219b5e615bed0()
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

      private sealed class MTHD_5474363bd4f74528ac250828019b5aba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5474363bd4f74528ac250828019b5aba()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_9edc36e9ee9241939ce835d2c769bb10 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9edc36e9ee9241939ce835d2c769bb10()
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

      private sealed class MTHD_dc0ab9fd9c21437c9f567485f8fd3551 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc0ab9fd9c21437c9f567485f8fd3551()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_db8661f8953a4f47a0d996d212020917 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db8661f8953a4f47a0d996d212020917()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_4dbf851311294e2f98298456a1188efd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4dbf851311294e2f98298456a1188efd()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_77bd0925ca0342cf8f8a31bbceb03ad0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_77bd0925ca0342cf8f8a31bbceb03ad0()
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

      private sealed class MTHD_d4fea5884ab047b3aeac9ade42a76457 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d4fea5884ab047b3aeac9ade42a76457()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_7a1d14e16e0c445d84c30aadeba73bbe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a1d14e16e0c445d84c30aadeba73bbe()
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

      private sealed class MTHD_d4bd8a106512482c89270739b03c3a92 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d4bd8a106512482c89270739b03c3a92()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_48805f97bc90446684a7277271c7c0f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_48805f97bc90446684a7277271c7c0f4()
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

      private sealed class MTHD_ec799bd51adf4a02942bbeb965a20cb4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec799bd51adf4a02942bbeb965a20cb4()
        {
          this.Initialize("get_allowMinionMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMinionMovement;
        }
      }

      private sealed class MTHD_cf4fc27a72e0425696623c4b0de448f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf4fc27a72e0425696623c4b0de448f5()
        {
          this.Initialize("set_allowMinionMovement", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).allowMinionMovement = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_a55cce35de1942bda8ef8523e64a5f4a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a55cce35de1942bda8ef8523e64a5f4a()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_02fb58e526f5448194feb7c7b73a4e6e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_02fb58e526f5448194feb7c7b73a4e6e()
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

      private sealed class MTHD_27f3505d526e4b1fb0bde430d5ca6338 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_27f3505d526e4b1fb0bde430d5ca6338()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_4330ff1458574d919eedfadb90df16c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4330ff1458574d919eedfadb90df16c9()
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

      private sealed class MTHD_2a681e126c994ef3b19a519d7e93c987 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a681e126c994ef3b19a519d7e93c987()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_991488a453874e11928d1b588d80d464 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_991488a453874e11928d1b588d80d464()
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

      private sealed class MTHD_9e06d7303cfb42b7913cfb446ce8f236 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e06d7303cfb42b7913cfb446ce8f236()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_2899c275b2174372b41e50771d2a1930 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2899c275b2174372b41e50771d2a1930()
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

      private sealed class MTHD_fda5fc51935549db9f1429bd4ca0d361 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fda5fc51935549db9f1429bd4ca0d361()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_bb2e930450184e25b2a87dff14317ce4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb2e930450184e25b2a87dff14317ce4()
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

      private sealed class MTHD_e3585cb0eb9944d7aeeb74146e510332 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e3585cb0eb9944d7aeeb74146e510332()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_b4a82abcb32b4d12a7e8489db0f2596b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b4a82abcb32b4d12a7e8489db0f2596b()
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

      private sealed class MTHD_da38970710264ec4b6f5e1683e446568 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_da38970710264ec4b6f5e1683e446568()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_2b42175aaa8542359273330499019b63 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b42175aaa8542359273330499019b63()
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

      private sealed class MTHD_c7d89bfd8dcb4cb4a250cee63270d2e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c7d89bfd8dcb4cb4a250cee63270d2e7()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_6ce61074bac94e1aa96caec09a926d39 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ce61074bac94e1aa96caec09a926d39()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_5c466913e4164cf18af7d58e3580cab7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c466913e4164cf18af7d58e3580cab7()
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

      private sealed class MTHD_092c9efe4c05473b92a1715346c7f121 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_092c9efe4c05473b92a1715346c7f121()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_a9e9913189074740bfa60970ec3af9d6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a9e9913189074740bfa60970ec3af9d6()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_bae17f6b19c443829a42bbd938f8398d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bae17f6b19c443829a42bbd938f8398d()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_8984295ed40745b1b4a98bb3d9447992 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8984295ed40745b1b4a98bb3d9447992()
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

      private sealed class MTHD_20994dca9827447f844644b3b9110874 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_20994dca9827447f844644b3b9110874()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_7c455de27961406182f1a3a9ed5580fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7c455de27961406182f1a3a9ed5580fa()
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

      private sealed class MTHD_4adffe3b74814d3b89a45876d46c63e4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4adffe3b74814d3b89a45876d46c63e4()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_2cd11a122c474008aa1524e7b1d5cc67 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2cd11a122c474008aa1524e7b1d5cc67()
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

      private sealed class MTHD_e2d17421c6ab44009af4ea6d147ffdff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e2d17421c6ab44009af4ea6d147ffdff()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_60a6bcee85704d54986377145f6b8e3e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60a6bcee85704d54986377145f6b8e3e()
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

      private sealed class MTHD_e781d87989924f6982a1b33c8ca6f9bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e781d87989924f6982a1b33c8ca6f9bf()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_8025c83a8fbc4370a32bbd381fc9a2de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8025c83a8fbc4370a32bbd381fc9a2de()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_b13b9b4d37444932ba4f2f39fc44d951 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b13b9b4d37444932ba4f2f39fc44d951()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_a2cfa59ed22f439db21e7f04d9ab531e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2cfa59ed22f439db21e7f04d9ab531e()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_ab0d5cca970c40ac9192e25f50f2353d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab0d5cca970c40ac9192e25f50f2353d()
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

      private sealed class MTHD_4ba034325ab2400eb4619ae285b9e59f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ba034325ab2400eb4619ae285b9e59f()
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

      private sealed class MTHD_5843b74048f147608c8c07ccad93d8e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5843b74048f147608c8c07ccad93d8e2()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_8b276c94b2864a4389a4712c2d298869 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b276c94b2864a4389a4712c2d298869()
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

      private sealed class MTHD_7f62a3844a3e4f5ea77996f047969894 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f62a3844a3e4f5ea77996f047969894()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_5cf939577620434fb4e243deb1dff2a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5cf939577620434fb4e243deb1dff2a1()
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

      private sealed class MTHD_d56a797dc015480e9de8437920519e62 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d56a797dc015480e9de8437920519e62()
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

      private sealed class MTHD_db8ae14538e4441f910607c0ba251c10 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db8ae14538e4441f910607c0ba251c10()
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

      private sealed class MTHD_9aee6043797b4405b4d9b256b2ea85b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9aee6043797b4405b4d9b256b2ea85b7()
        {
          this.Initialize("Dispose", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ContainerGame.Dispose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b497f17dbf5f49cb93c3a5773eac7238 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b497f17dbf5f49cb93c3a5773eac7238()
        {
          this.Initialize("drawImage", false, new ParameterDescriptor[4]
          {
            new ParameterDescriptor("file", typeof (string), false, (object) null, false, false, false),
            new ParameterDescriptor("x", typeof (int), false, (object) null, false, false, false),
            new ParameterDescriptor("y", typeof (int), false, (object) null, false, false, false),
            new ParameterDescriptor("apply", typeof (bool), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 3)
          {
            ((ContainerGame) obj).drawImage((string) pars[0], (int) pars[1], (int) pars[2], false);
            return (object) DynValue.Void;
          }
          ((ContainerGame) obj).drawImage((string) pars[0], (int) pars[1], (int) pars[2], (bool) pars[3]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_edc1e3acd74b4a4c88de3ed6817b99c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_edc1e3acd74b4a4c88de3ed6817b99c0()
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

      private sealed class MTHD_0c7c772c8a3a4e1d92fa539d3d066509 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c7c772c8a3a4e1d92fa539d3d066509()
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

      private sealed class MTHD_5075aebc9f19440d90eb49f5ec961a7c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5075aebc9f19440d90eb49f5ec961a7c()
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

      private sealed class MTHD_2d312b9084b64d71b20c8fe3bede34b8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d312b9084b64d71b20c8fe3bede34b8()
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

      private sealed class MTHD_eb9c5d61c86f4646a8cb85c4b44c16e6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb9c5d61c86f4646a8cb85c4b44c16e6()
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

      private sealed class MTHD_6227154dd9e74ac5b067824b36665db5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6227154dd9e74ac5b067824b36665db5()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_7bd93a4bffc94d52b2d696b5ad4772aa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7bd93a4bffc94d52b2d696b5ad4772aa()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_26ad239e7dab48a3868abfc1161d7bf4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_26ad239e7dab48a3868abfc1161d7bf4()
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

      private sealed class MTHD_d6b1b247c0784158b9caac10acef047e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6b1b247c0784158b9caac10acef047e()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_8447d2491f1c415a957fa6fc532f0e80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8447d2491f1c415a957fa6fc532f0e80()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_bd19236dd7a1434cb71c014f339e1c84 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd19236dd7a1434cb71c014f339e1c84()
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

      private sealed class MTHD_d69b34b220104fd3812064346e8e59be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d69b34b220104fd3812064346e8e59be()
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

      private sealed class MTHD_6bcc9acf7cb0450487f80b77f0aafd1e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6bcc9acf7cb0450487f80b77f0aafd1e()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c90c6261af4b4aebac8c89c4b3569e6f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c90c6261af4b4aebac8c89c4b3569e6f()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9c0496ccdb4a4f458b64fe7c0c1d61e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c0496ccdb4a4f458b64fe7c0c1d61e1()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ce48eea64c8d422d985a51815cbe6c9f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ce48eea64c8d422d985a51815cbe6c9f()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_01a2e54c026a4b728044f4b4d62c649f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_01a2e54c026a4b728044f4b4d62c649f()
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

      private sealed class MTHD_78574e9d906145f68fce05f41c9929f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_78574e9d906145f68fce05f41c9929f5()
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

      private sealed class MTHD_12c097cacecf4157897ca3d4045e4f35 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_12c097cacecf4157897ca3d4045e4f35()
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

      private sealed class MTHD_7c2d8e0d5bfe4dbd9c7b7de83f628434 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7c2d8e0d5bfe4dbd9c7b7de83f628434()
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

      private sealed class MTHD_53b1287919524c858018a675bdf27700 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_53b1287919524c858018a675bdf27700()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_7bc78033ac434f2e872381005fbfcce0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7bc78033ac434f2e872381005fbfcce0()
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

      private sealed class MTHD_0468b81b233f4bcf88773c6a4e8a4270 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0468b81b233f4bcf88773c6a4e8a4270()
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

      private sealed class MTHD_49adb38b03604f61b97284adc6c0dd70 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49adb38b03604f61b97284adc6c0dd70()
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

      private sealed class MTHD_58e5bdca108a48f2881d55c661aa41b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_58e5bdca108a48f2881d55c661aa41b7()
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

      private sealed class MTHD_31ccf28a079b42bfbc1379b31bf57d47 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_31ccf28a079b42bfbc1379b31bf57d47()
        {
          this.Initialize("cameraFollow", false, new ParameterDescriptor[2]
          {
            new ParameterDescriptor("creature", typeof (ContainerCreature), false, (object) null, false, false, false),
            new ParameterDescriptor("force", typeof (bool), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 1)
          {
            ((ContainerGame) obj).cameraFollow((ContainerCreature) pars[0], true);
            return (object) DynValue.Void;
          }
          ((ContainerGame) obj).cameraFollow((ContainerCreature) pars[0], (bool) pars[1]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_4dc0b64bb6584dc5ac0a5e09f0c476aa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4dc0b64bb6584dc5ac0a5e09f0c476aa()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_1ec97bd5928c4af2bea478819bf366e0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ec97bd5928c4af2bea478819bf366e0()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_a974072b84ab4840a5bef536f84a3e2a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a974072b84ab4840a5bef536f84a3e2a()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_83a46f1a0ccf4399a8dd6d39674b43fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_83a46f1a0ccf4399a8dd6d39674b43fe()
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

      private sealed class MTHD_8697a85eb0d14e08a01ed870db3f4db7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8697a85eb0d14e08a01ed870db3f4db7()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f72924a0598c493aa8ed882707f708a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f72924a0598c493aa8ed882707f708a1()
        {
          this.Initialize("createIndicator", false, new ParameterDescriptor[6]
          {
            new ParameterDescriptor("kind", typeof (IndicatorKind), false, (object) null, false, false, false),
            new ParameterDescriptor("point", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("color", typeof (LuaColor), false, (object) null, false, false, false),
            new ParameterDescriptor("radius", typeof (double), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("angle", typeof (double), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("lifetime", typeof (double), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 3)
            return (object) ((ContainerGame) obj).createIndicator((IndicatorKind) pars[0], (Educative.Point) pars[1], (LuaColor) pars[2], 18.0, 0.0, 0.0);
          if (argscount <= 4)
            return (object) ((ContainerGame) obj).createIndicator((IndicatorKind) pars[0], (Educative.Point) pars[1], (LuaColor) pars[2], (double) pars[3], 0.0, 0.0);
          return argscount <= 5 ? (object) ((ContainerGame) obj).createIndicator((IndicatorKind) pars[0], (Educative.Point) pars[1], (LuaColor) pars[2], (double) pars[3], (double) pars[4], 0.0) : (object) ((ContainerGame) obj).createIndicator((IndicatorKind) pars[0], (Educative.Point) pars[1], (LuaColor) pars[2], (double) pars[3], (double) pars[4], (double) pars[5]);
        }
      }

      private sealed class MTHD_ab8c57c658df429e90bddcaaf0eaed7a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab8c57c658df429e90bddcaaf0eaed7a()
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

      private sealed class MTHD_93c9ccc170854da39456b17855ae1ddc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93c9ccc170854da39456b17855ae1ddc()
        {
          this.Initialize("getKeyBinds", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("key", typeof (KeyBinds), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getKeyBinds((KeyBinds) pars[0]);
        }
      }

      private sealed class MTHD_f3887e402a3f4a90b05a22b83d544302 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f3887e402a3f4a90b05a22b83d544302()
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

      private sealed class MTHD_9f049820d9f349aab9d8d24277971ca6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f049820d9f349aab9d8d24277971ca6()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_81c356cb8e7c4b5786f3a77aa12912c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_81c356cb8e7c4b5786f3a77aa12912c0()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_296654983526407da03148586b31c516 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_296654983526407da03148586b31c516()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_46c80548a5a347519a4bd69187040003 : HardwiredMemberDescriptor
      {
        internal PROP_46c80548a5a347519a4bd69187040003()
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

      private sealed class PROP_a8d4ac9b56f543f9a37ae28b63dae0bd : HardwiredMemberDescriptor
      {
        internal PROP_a8d4ac9b56f543f9a37ae28b63dae0bd()
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

      private sealed class PROP_4ce6040183024891852cdee219ca0200 : HardwiredMemberDescriptor
      {
        internal PROP_4ce6040183024891852cdee219ca0200()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_45599c2c065f4917985e520c4e0819df : HardwiredMemberDescriptor
      {
        internal PROP_45599c2c065f4917985e520c4e0819df()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_612ea6e86e194b1082935415a27cf91b : HardwiredMemberDescriptor
      {
        internal PROP_612ea6e86e194b1082935415a27cf91b()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_f08a5b24d51842a398aba457f8cad8a5 : HardwiredMemberDescriptor
      {
        internal PROP_f08a5b24d51842a398aba457f8cad8a5()
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

      private sealed class PROP_8c3d1fa9be7e49b5814b9ba9526970a6 : HardwiredMemberDescriptor
      {
        internal PROP_8c3d1fa9be7e49b5814b9ba9526970a6()
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

      private sealed class PROP_cd93459982034d2b858db8c7d429d96e : HardwiredMemberDescriptor
      {
        internal PROP_cd93459982034d2b858db8c7d429d96e()
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

      private sealed class PROP_4362391fde044560a446ff000d0dd67f : HardwiredMemberDescriptor
      {
        internal PROP_4362391fde044560a446ff000d0dd67f()
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

      private sealed class PROP_c0ec2e41a9454154b0eadb71ff80fea9 : HardwiredMemberDescriptor
      {
        internal PROP_c0ec2e41a9454154b0eadb71ff80fea9()
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

      private sealed class PROP_d24427e8b88145da98c31c2188184ec6 : HardwiredMemberDescriptor
      {
        internal PROP_d24427e8b88145da98c31c2188184ec6()
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

      private sealed class PROP_919f400adbaf4d15909de5df3f88f282 : HardwiredMemberDescriptor
      {
        internal PROP_919f400adbaf4d15909de5df3f88f282()
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

      private sealed class PROP_fd80ec87ded84e6296caaecd0fccb8d2 : HardwiredMemberDescriptor
      {
        internal PROP_fd80ec87ded84e6296caaecd0fccb8d2()
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

      private sealed class PROP_01123af79d0e4a7584f41f77289b4d70 : HardwiredMemberDescriptor
      {
        internal PROP_01123af79d0e4a7584f41f77289b4d70()
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

      private sealed class PROP_21c816799ae046a69793d6e261cff1ec : HardwiredMemberDescriptor
      {
        internal PROP_21c816799ae046a69793d6e261cff1ec()
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

      private sealed class PROP_8825c68d9199406681437bffb5e202bf : HardwiredMemberDescriptor
      {
        internal PROP_8825c68d9199406681437bffb5e202bf()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_d8054dc6a582464990644d96cb938811 : HardwiredMemberDescriptor
      {
        internal PROP_d8054dc6a582464990644d96cb938811()
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

      private sealed class PROP_d32cd377fbf4495a841dfbd30e801983 : HardwiredMemberDescriptor
      {
        internal PROP_d32cd377fbf4495a841dfbd30e801983()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_4190cccffbc540f2a42295c729c3221a : HardwiredMemberDescriptor
      {
        internal PROP_4190cccffbc540f2a42295c729c3221a()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_7cffcf1078544e81aa03558f345d0b06 : HardwiredMemberDescriptor
      {
        internal PROP_7cffcf1078544e81aa03558f345d0b06()
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

      private sealed class PROP_3459d64cb02b4370afd930d516e58fe0 : HardwiredMemberDescriptor
      {
        internal PROP_3459d64cb02b4370afd930d516e58fe0()
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

      private sealed class PROP_662ae3166b094af29c29de6ddf48272e : HardwiredMemberDescriptor
      {
        internal PROP_662ae3166b094af29c29de6ddf48272e()
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

      private sealed class PROP_d90f994a5b614a8d900cbf91f55b69d7 : HardwiredMemberDescriptor
      {
        internal PROP_d90f994a5b614a8d900cbf91f55b69d7()
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

      private sealed class PROP_61da1fcda97d47cda4bea3f2b1bac4ea : HardwiredMemberDescriptor
      {
        internal PROP_61da1fcda97d47cda4bea3f2b1bac4ea()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_4d59d25bd2f24764ba0bb982acf3d559 : HardwiredMemberDescriptor
      {
        internal PROP_4d59d25bd2f24764ba0bb982acf3d559()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_c91c4425727f4c599eb1d3c83f3a4867 : HardwiredMemberDescriptor
      {
        internal PROP_c91c4425727f4c599eb1d3c83f3a4867()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_019445233b2a4abdb6c64081d49727cc : HardwiredMemberDescriptor
      {
        internal PROP_019445233b2a4abdb6c64081d49727cc()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_fead447a8d094ddfb8c31ec0d3964e9b : HardwiredMemberDescriptor
      {
        internal PROP_fead447a8d094ddfb8c31ec0d3964e9b()
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

      private sealed class PROP_e7666f8f01974dba996c319d298fc882 : HardwiredMemberDescriptor
      {
        internal PROP_e7666f8f01974dba996c319d298fc882()
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

      private sealed class PROP_8eba573c5c5748899cbeb4180450acd7 : HardwiredMemberDescriptor
      {
        internal PROP_8eba573c5c5748899cbeb4180450acd7()
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

      private sealed class PROP_e6f014b30b514263a836c566a001ed15 : HardwiredMemberDescriptor
      {
        internal PROP_e6f014b30b514263a836c566a001ed15()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_2c2a7b717e2940679f43bba784b8fe2b : HardwiredMemberDescriptor
      {
        internal PROP_2c2a7b717e2940679f43bba784b8fe2b()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_662a71c28e684392902acf69deadd235 : HardwiredMemberDescriptor
      {
        internal PROP_662a71c28e684392902acf69deadd235()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_0f7458cc1147419497003baa011fc6b9 : HardwiredUserDataDescriptor
    {
      internal TYPE_0f7458cc1147419497003baa011fc6b9()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0f7458cc1147419497003baa011fc6b9.MTHD_8e24db59716a470a9da55ed16cbff7d2()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0f7458cc1147419497003baa011fc6b9.MTHD_99b975f801de4722aef773f6273ebcf4()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0f7458cc1147419497003baa011fc6b9.MTHD_7213c4d936d14eb8ab96643163d063eb()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0f7458cc1147419497003baa011fc6b9.MTHD_edbfade8a0734d508c8dfa44eca5e9e5()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0f7458cc1147419497003baa011fc6b9.MTHD_066f7a1a3cb545108c359d05affc55ee()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0f7458cc1147419497003baa011fc6b9.MTHD_d405c5e01c254f66bcc94e72f6e74472()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0f7458cc1147419497003baa011fc6b9.MTHD_d6b928aae8d146979ba3de6d160342bd()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0f7458cc1147419497003baa011fc6b9.MTHD_8e2ae900ef024afe800da29342d10ff6()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0f7458cc1147419497003baa011fc6b9.MTHD_636134fbd3574b1a93aca51a4caf72db()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0f7458cc1147419497003baa011fc6b9.MTHD_6529d26c1baf4e0792f0544bffb052ff()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0f7458cc1147419497003baa011fc6b9.MTHD_f7b582d992654d9bb9346e7008815987()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0f7458cc1147419497003baa011fc6b9.MTHD_265b7c59f06f4ee884c99bf38919e1bc()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_0f7458cc1147419497003baa011fc6b9.PROP_a1da888bd27a4740a23476e7709962f9());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_0f7458cc1147419497003baa011fc6b9.PROP_fd593991d6cb467198582acfcac7dfae());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_0f7458cc1147419497003baa011fc6b9.PROP_c79cc763c27946d4a2aaa5dad4cdbfaa());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_0f7458cc1147419497003baa011fc6b9.PROP_341feac80bbb47bcb50da6572cf58b43());
      }

      private sealed class MTHD_8e24db59716a470a9da55ed16cbff7d2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e24db59716a470a9da55ed16cbff7d2()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_99b975f801de4722aef773f6273ebcf4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99b975f801de4722aef773f6273ebcf4()
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

      private sealed class MTHD_7213c4d936d14eb8ab96643163d063eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7213c4d936d14eb8ab96643163d063eb()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_edbfade8a0734d508c8dfa44eca5e9e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_edbfade8a0734d508c8dfa44eca5e9e5()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_066f7a1a3cb545108c359d05affc55ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_066f7a1a3cb545108c359d05affc55ee()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_d405c5e01c254f66bcc94e72f6e74472 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d405c5e01c254f66bcc94e72f6e74472()
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

      private sealed class MTHD_d6b928aae8d146979ba3de6d160342bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6b928aae8d146979ba3de6d160342bd()
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

      private sealed class MTHD_8e2ae900ef024afe800da29342d10ff6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e2ae900ef024afe800da29342d10ff6()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_636134fbd3574b1a93aca51a4caf72db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_636134fbd3574b1a93aca51a4caf72db()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_6529d26c1baf4e0792f0544bffb052ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6529d26c1baf4e0792f0544bffb052ff()
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

      private sealed class MTHD_f7b582d992654d9bb9346e7008815987 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7b582d992654d9bb9346e7008815987()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_265b7c59f06f4ee884c99bf38919e1bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_265b7c59f06f4ee884c99bf38919e1bc()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_a1da888bd27a4740a23476e7709962f9 : HardwiredMemberDescriptor
      {
        internal PROP_a1da888bd27a4740a23476e7709962f9()
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

      private sealed class PROP_fd593991d6cb467198582acfcac7dfae : HardwiredMemberDescriptor
      {
        internal PROP_fd593991d6cb467198582acfcac7dfae()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_c79cc763c27946d4a2aaa5dad4cdbfaa : HardwiredMemberDescriptor
      {
        internal PROP_c79cc763c27946d4a2aaa5dad4cdbfaa()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_341feac80bbb47bcb50da6572cf58b43 : HardwiredMemberDescriptor
      {
        internal PROP_341feac80bbb47bcb50da6572cf58b43()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_ddaade72be2145e79812d45039b4f4be : HardwiredUserDataDescriptor
    {
      internal TYPE_ddaade72be2145e79812d45039b4f4be()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_9861b897f42349e38bd029426d3462ca()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_378a0ff2fc1d4056baf884c665d14567()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_4eadec59a1364a469d50220ceeac6fa5()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_c347856f066d4a81962e8ef1c31604ad()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_7e400dfc949b44b98c1cdd6e491d63a5()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_acb2b665e8c44c7d8f4d151c1c5c62fd()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_061db8cc91d245b2b5715fcfee1cfd96()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_d88d0ea79a8e43f1bec7403125ae470f()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_b7f0245eb297488299fc5e8a8a056a8b()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_068f59927d2d4bbfb83fd2c2de3f1690()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_920301240b454bab920a83d5c6357c5a()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_7146b96a298a4ad69d6be2aea3dc7409()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_3c94cfca949d49608f9ba1f532084fa0()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_9347394ada2541b4b1dbe63f7d658573()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_42d0a8c1b64846dba6752bf0c4fa65c6()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_ac3cb2d343be4dc397e53d4e9db817e7()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_102b9b75393b428dbe552d236383abe8()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_eccfd12c38284a129f8a0f786a10085a()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_58cc92e8ef474f44a0b68c6fd332aba4()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_e093093f72e648aaa2753c74baf1f9cf()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_a8d46573ff144221841b5030bb03ae88()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_0ebd77c8c5bd4d06a40e5ca70b977eed()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_14b1e352530a4541a711c236480d37b2()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_fd655fffff15478ebebbe790d6da570d()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_fb57846f86e04b3a914e27c06881b1d8()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_f88cc652fd27483da27594f0d720e37a()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_0665b1967c114106b85e831b30367b9a()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_3b6353ebd38043f6b4958f7da2bf45b0()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_1dd525537e244af6a1c0528bbd4b91f9()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_912ed2e465704561aca556673ed68618()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_ed8d018fa5cd42968162a7726a5c8f35()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_051c34b0beac46f9ac217c7cc798221a()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_1be6ba42a20641a0a75cf73ff8eccc09()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_349db132a6524a04a3df28d97a25ea27()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_77b50931e3354342b9a1d937de79d1c5()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_c5ccc9c4920c460d9b085db194b7185c()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_ba1cb42f849b4febb4b66906869e4d28()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_36cc9294a82a4b8f8457a65a3909ddb7()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_255f5be2c24a48d7ba16bf4dc1a00fd5()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_6188c44378464d8ead51d16bb91b91ee()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_f9857a1c665841348a1d8e0bc3a5f1e4()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_a989ae78e0c24daea18ad5bef9d7be2b()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_06bca64cadfe47a4b1ce25a8d17721da()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_dca3c9f687f24b73b7b077f8bd0754c8()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_031da1e022b54aadacbc8118321a0925()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_68e9fef89eb94d66b6cc810cba1652ba()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_e61a3e01141944d5a485ce7027441ca3()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_720d7967bce244f7880932b042fb3237()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_07529db1ba124bd09818165915c5f44a()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_c64f7888a1724cbe802a4154dbef0097()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_e333457b002d4011a2013c89f2153017()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_e0237147126d460e82cde34371e7dc02()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_799876515f1349979206d14b09c99232()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_39528e613f0147e9813a672916b3c10e()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_41688ca629724a679d0435e45a01bbae()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_ee9e2722d17441c8bb7fd13dc0858257()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_730d70587eb14b9c998155ca3c5865ae()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_beec937ccaa0492090aafc4db3cebf4a()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_b7ee1a51dec44a54a2a2bd00ec48795b()
        }));
        this.AddMember("getDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_6bcb1e020f3c4128ba04a23fec5dff57()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_adea95359f3244bf9556a0be9ccefc4f()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_0c979816deaf484baf9f39466cbcee11()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_a4e451699a1d4c96a9a0d81cce314aff()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_786de1d3cd8c470b90d1b3f57ec998ac()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_f27bcfe8ae1d4c919c36156668827a8e(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_0d3f9925e4a340b3a417842ec6cd669e()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_7e2c1e3fc1e844ef9293b4434e728dc9(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_479e7cd6ea26478d8017269977e99c3d()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_06327c8370104091b1578d2eaf833534()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_fd0c1e9b2f7940eab9c487b125cbb1ec()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_036d3be56c264241ad39757985d0c655(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_1a7f78aec58b42989208549c26d44de8()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_cb339d2d77e041988d34e19b4fbafba5()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_23969011dace46aa9a0e6793839306d0()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_97a125517dcb4236b67b45cff81da35f()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_5452782e06434f4dbf44929b10733a91()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_159dcfb58c7146b2a5f5aa95f545c200()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_daedc61cf6664f36964b3caba9912043()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_b42915e2d55f4f51ba64f868e19f670b()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_d0134aafd0a74bbcbf7510befe8dea15()
        }));
        this.AddMember("angleToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("angleToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_6b964ccdcaff464ea6d81d006e67bbc1()
        }));
        this.AddMember("powerToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("powerToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_f10c8375f28e4cbfb28bc23d92fd080c()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_3d478c0eb6c54f138c96b4942c922592(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_9a607fc878ab427da7936d9b10759c7b()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_4bd3ffc34d4945c3af15e99f0b3ea8fa(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_592b7fca50364dcd9fc0fcce258d154d()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_0a68b737206442dab077b563930c3f68()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_d697b92bd7e944639d126cad7dfe1eb8()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_3e60d702da3845e99e10386217bb5db1()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_c96aef6f20d847478f9e4cf063869af0()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_1500fd4146ce4b879678abb454df5c52()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.MTHD_bde2633866bd4a3ca39504bf3646d58e()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_9b54bd9a3e31482a9e18e02d8781549e());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_86611ea6c11648508ac037a59be7d095());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_3c6ebef9d55b4df0b575a1805e36d901());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_2f2d9a1757ba49e5b7f3c73f0e757376());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_47aa6d8f8c09478fa9b2ac8d369a53ea());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_a13c032b85dc4a239711b07535891de2());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_01daa0df3a3a4c118d51aeeeb25ae698());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_2702c3995f9e4eeea985048433f3eaa2());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_ee6ecf785c6049c69fe90228d4fb7006());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_fde31e2e70c14f60b01a5bed5014e77a());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_f4c56f9d14b34e1da2e135540ed515b2());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_d13efbaf4e1047cdaee2a716c6557ab9());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_e518b6fca1254e98878bd84290e5eef7());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_f33f3c5cd0294e7f820e8adc36e934e2());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_cf9bacc14b1d4a71b574afb706da0e65());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_daebc6c7f84d4186938ce7c5e43abf09());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_5706b130a9864433a8b77903bdad1ef8());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_8587e1c77d6747be92cfab0c7a4c0813());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_a10e7c8905de41698a3698dcc5cbff1a());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_3a47122196b44503aca7ae0ec7eab98e());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_d68a190895af447ea3d33278370e42e0());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_7791d8e5a54e42d1ba9ccdb93b7b2f78());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_19d76d37a70f429b92e4d2b23c2fadec());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_2549982ff42d4c54ab9be4476ed71693());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_1b7ead0a71914a1397d1157d4ba49428());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_e66b17f2e70e41b08ecb068aebc77030());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_bd4b717021eb496883d98b3935f1b80a());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_cf1165e47cfc4a45872375be98b4e63c());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_44b113a16c984a8faeff97ba008990ae());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_67f06e739c5b4d06bd1b45608d6c39b2());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_b63e63b2df574ff8a16242d2cbd3c815());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_9c6ac500b4cf4767b15a739416675cf3());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_ddaade72be2145e79812d45039b4f4be.PROP_0a2afc1dadbb4266805c1512bdd020f9());
      }

      private sealed class MTHD_9861b897f42349e38bd029426d3462ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9861b897f42349e38bd029426d3462ca()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_378a0ff2fc1d4056baf884c665d14567 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_378a0ff2fc1d4056baf884c665d14567()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_4eadec59a1364a469d50220ceeac6fa5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4eadec59a1364a469d50220ceeac6fa5()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_c347856f066d4a81962e8ef1c31604ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c347856f066d4a81962e8ef1c31604ad()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_7e400dfc949b44b98c1cdd6e491d63a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7e400dfc949b44b98c1cdd6e491d63a5()
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

      private sealed class MTHD_acb2b665e8c44c7d8f4d151c1c5c62fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_acb2b665e8c44c7d8f4d151c1c5c62fd()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_061db8cc91d245b2b5715fcfee1cfd96 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_061db8cc91d245b2b5715fcfee1cfd96()
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

      private sealed class MTHD_d88d0ea79a8e43f1bec7403125ae470f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d88d0ea79a8e43f1bec7403125ae470f()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_b7f0245eb297488299fc5e8a8a056a8b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b7f0245eb297488299fc5e8a8a056a8b()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_068f59927d2d4bbfb83fd2c2de3f1690 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_068f59927d2d4bbfb83fd2c2de3f1690()
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

      private sealed class MTHD_920301240b454bab920a83d5c6357c5a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_920301240b454bab920a83d5c6357c5a()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_7146b96a298a4ad69d6be2aea3dc7409 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7146b96a298a4ad69d6be2aea3dc7409()
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

      private sealed class MTHD_3c94cfca949d49608f9ba1f532084fa0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3c94cfca949d49608f9ba1f532084fa0()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_9347394ada2541b4b1dbe63f7d658573 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9347394ada2541b4b1dbe63f7d658573()
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

      private sealed class MTHD_42d0a8c1b64846dba6752bf0c4fa65c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42d0a8c1b64846dba6752bf0c4fa65c6()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_ac3cb2d343be4dc397e53d4e9db817e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac3cb2d343be4dc397e53d4e9db817e7()
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

      private sealed class MTHD_102b9b75393b428dbe552d236383abe8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_102b9b75393b428dbe552d236383abe8()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_eccfd12c38284a129f8a0f786a10085a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eccfd12c38284a129f8a0f786a10085a()
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

      private sealed class MTHD_58cc92e8ef474f44a0b68c6fd332aba4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_58cc92e8ef474f44a0b68c6fd332aba4()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_e093093f72e648aaa2753c74baf1f9cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e093093f72e648aaa2753c74baf1f9cf()
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

      private sealed class MTHD_a8d46573ff144221841b5030bb03ae88 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a8d46573ff144221841b5030bb03ae88()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_0ebd77c8c5bd4d06a40e5ca70b977eed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ebd77c8c5bd4d06a40e5ca70b977eed()
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

      private sealed class MTHD_14b1e352530a4541a711c236480d37b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_14b1e352530a4541a711c236480d37b2()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_fd655fffff15478ebebbe790d6da570d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd655fffff15478ebebbe790d6da570d()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_fb57846f86e04b3a914e27c06881b1d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb57846f86e04b3a914e27c06881b1d8()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_f88cc652fd27483da27594f0d720e37a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f88cc652fd27483da27594f0d720e37a()
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

      private sealed class MTHD_0665b1967c114106b85e831b30367b9a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0665b1967c114106b85e831b30367b9a()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_3b6353ebd38043f6b4958f7da2bf45b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3b6353ebd38043f6b4958f7da2bf45b0()
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

      private sealed class MTHD_1dd525537e244af6a1c0528bbd4b91f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1dd525537e244af6a1c0528bbd4b91f9()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_912ed2e465704561aca556673ed68618 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_912ed2e465704561aca556673ed68618()
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

      private sealed class MTHD_ed8d018fa5cd42968162a7726a5c8f35 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed8d018fa5cd42968162a7726a5c8f35()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_051c34b0beac46f9ac217c7cc798221a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_051c34b0beac46f9ac217c7cc798221a()
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

      private sealed class MTHD_1be6ba42a20641a0a75cf73ff8eccc09 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1be6ba42a20641a0a75cf73ff8eccc09()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_349db132a6524a04a3df28d97a25ea27 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_349db132a6524a04a3df28d97a25ea27()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_77b50931e3354342b9a1d937de79d1c5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_77b50931e3354342b9a1d937de79d1c5()
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

      private sealed class MTHD_c5ccc9c4920c460d9b085db194b7185c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c5ccc9c4920c460d9b085db194b7185c()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_ba1cb42f849b4febb4b66906869e4d28 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba1cb42f849b4febb4b66906869e4d28()
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

      private sealed class MTHD_36cc9294a82a4b8f8457a65a3909ddb7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_36cc9294a82a4b8f8457a65a3909ddb7()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_255f5be2c24a48d7ba16bf4dc1a00fd5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_255f5be2c24a48d7ba16bf4dc1a00fd5()
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

      private sealed class MTHD_6188c44378464d8ead51d16bb91b91ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6188c44378464d8ead51d16bb91b91ee()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_f9857a1c665841348a1d8e0bc3a5f1e4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f9857a1c665841348a1d8e0bc3a5f1e4()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_a989ae78e0c24daea18ad5bef9d7be2b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a989ae78e0c24daea18ad5bef9d7be2b()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_06bca64cadfe47a4b1ce25a8d17721da : HardwiredMethodMemberDescriptor
      {
        internal MTHD_06bca64cadfe47a4b1ce25a8d17721da()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_dca3c9f687f24b73b7b077f8bd0754c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dca3c9f687f24b73b7b077f8bd0754c8()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_031da1e022b54aadacbc8118321a0925 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_031da1e022b54aadacbc8118321a0925()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_68e9fef89eb94d66b6cc810cba1652ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_68e9fef89eb94d66b6cc810cba1652ba()
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

      private sealed class MTHD_e61a3e01141944d5a485ce7027441ca3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e61a3e01141944d5a485ce7027441ca3()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_720d7967bce244f7880932b042fb3237 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_720d7967bce244f7880932b042fb3237()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_07529db1ba124bd09818165915c5f44a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_07529db1ba124bd09818165915c5f44a()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_c64f7888a1724cbe802a4154dbef0097 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c64f7888a1724cbe802a4154dbef0097()
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

      private sealed class MTHD_e333457b002d4011a2013c89f2153017 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e333457b002d4011a2013c89f2153017()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_e0237147126d460e82cde34371e7dc02 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e0237147126d460e82cde34371e7dc02()
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

      private sealed class MTHD_799876515f1349979206d14b09c99232 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_799876515f1349979206d14b09c99232()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_39528e613f0147e9813a672916b3c10e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_39528e613f0147e9813a672916b3c10e()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_41688ca629724a679d0435e45a01bbae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41688ca629724a679d0435e45a01bbae()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_ee9e2722d17441c8bb7fd13dc0858257 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee9e2722d17441c8bb7fd13dc0858257()
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

      private sealed class MTHD_730d70587eb14b9c998155ca3c5865ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_730d70587eb14b9c998155ca3c5865ae()
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

      private sealed class MTHD_beec937ccaa0492090aafc4db3cebf4a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_beec937ccaa0492090aafc4db3cebf4a()
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

      private sealed class MTHD_b7ee1a51dec44a54a2a2bd00ec48795b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b7ee1a51dec44a54a2a2bd00ec48795b()
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

      private sealed class MTHD_6bcb1e020f3c4128ba04a23fec5dff57 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6bcb1e020f3c4128ba04a23fec5dff57()
        {
          this.Initialize("getDirection", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getDirection();
        }
      }

      private sealed class MTHD_adea95359f3244bf9556a0be9ccefc4f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_adea95359f3244bf9556a0be9ccefc4f()
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

      private sealed class MTHD_0c979816deaf484baf9f39466cbcee11 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c979816deaf484baf9f39466cbcee11()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_a4e451699a1d4c96a9a0d81cce314aff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a4e451699a1d4c96a9a0d81cce314aff()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_786de1d3cd8c470b90d1b3f57ec998ac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_786de1d3cd8c470b90d1b3f57ec998ac()
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

      private sealed class MTHD_f27bcfe8ae1d4c919c36156668827a8e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f27bcfe8ae1d4c919c36156668827a8e()
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

      private sealed class MTHD_0d3f9925e4a340b3a417842ec6cd669e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d3f9925e4a340b3a417842ec6cd669e()
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

      private sealed class MTHD_7e2c1e3fc1e844ef9293b4434e728dc9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7e2c1e3fc1e844ef9293b4434e728dc9()
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

      private sealed class MTHD_479e7cd6ea26478d8017269977e99c3d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_479e7cd6ea26478d8017269977e99c3d()
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

      private sealed class MTHD_06327c8370104091b1578d2eaf833534 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_06327c8370104091b1578d2eaf833534()
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

      private sealed class MTHD_fd0c1e9b2f7940eab9c487b125cbb1ec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd0c1e9b2f7940eab9c487b125cbb1ec()
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

      private sealed class MTHD_036d3be56c264241ad39757985d0c655 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_036d3be56c264241ad39757985d0c655()
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

      private sealed class MTHD_1a7f78aec58b42989208549c26d44de8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a7f78aec58b42989208549c26d44de8()
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

      private sealed class MTHD_cb339d2d77e041988d34e19b4fbafba5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cb339d2d77e041988d34e19b4fbafba5()
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

      private sealed class MTHD_23969011dace46aa9a0e6793839306d0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_23969011dace46aa9a0e6793839306d0()
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

      private sealed class MTHD_97a125517dcb4236b67b45cff81da35f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97a125517dcb4236b67b45cff81da35f()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_5452782e06434f4dbf44929b10733a91 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5452782e06434f4dbf44929b10733a91()
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

      private sealed class MTHD_159dcfb58c7146b2a5f5aa95f545c200 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_159dcfb58c7146b2a5f5aa95f545c200()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_daedc61cf6664f36964b3caba9912043 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_daedc61cf6664f36964b3caba9912043()
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

      private sealed class MTHD_b42915e2d55f4f51ba64f868e19f670b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b42915e2d55f4f51ba64f868e19f670b()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_d0134aafd0a74bbcbf7510befe8dea15 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0134aafd0a74bbcbf7510befe8dea15()
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

      private sealed class MTHD_6b964ccdcaff464ea6d81d006e67bbc1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b964ccdcaff464ea6d81d006e67bbc1()
        {
          this.Initialize("angleToFire", false, new ParameterDescriptor[3]
          {
            new ParameterDescriptor("spellObj", typeof (object), false, (object) null, false, false, false),
            new ParameterDescriptor("target", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("power", typeof (float), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return argscount <= 2 ? (object) ((ContainerCreature) obj).angleToFire(pars[0], (Educative.Point) pars[1], 1f) : (object) ((ContainerCreature) obj).angleToFire(pars[0], (Educative.Point) pars[1], (float) pars[2]);
        }
      }

      private sealed class MTHD_f10c8375f28e4cbfb28bc23d92fd080c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f10c8375f28e4cbfb28bc23d92fd080c()
        {
          this.Initialize("powerToFire", false, new ParameterDescriptor[3]
          {
            new ParameterDescriptor("spellObj", typeof (object), false, (object) null, false, false, false),
            new ParameterDescriptor("target", typeof (Educative.Point), false, (object) null, false, false, false),
            new ParameterDescriptor("angle", typeof (float), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return argscount <= 2 ? (object) ((ContainerCreature) obj).powerToFire(pars[0], (Educative.Point) pars[1], 45f) : (object) ((ContainerCreature) obj).powerToFire(pars[0], (Educative.Point) pars[1], (float) pars[2]);
        }
      }

      private sealed class MTHD_3d478c0eb6c54f138c96b4942c922592 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d478c0eb6c54f138c96b4942c922592()
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

      private sealed class MTHD_9a607fc878ab427da7936d9b10759c7b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9a607fc878ab427da7936d9b10759c7b()
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

      private sealed class MTHD_4bd3ffc34d4945c3af15e99f0b3ea8fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4bd3ffc34d4945c3af15e99f0b3ea8fa()
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

      private sealed class MTHD_592b7fca50364dcd9fc0fcce258d154d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_592b7fca50364dcd9fc0fcce258d154d()
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

      private sealed class MTHD_0a68b737206442dab077b563930c3f68 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0a68b737206442dab077b563930c3f68()
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

      private sealed class MTHD_d697b92bd7e944639d126cad7dfe1eb8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d697b92bd7e944639d126cad7dfe1eb8()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_3e60d702da3845e99e10386217bb5db1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e60d702da3845e99e10386217bb5db1()
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

      private sealed class MTHD_c96aef6f20d847478f9e4cf063869af0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c96aef6f20d847478f9e4cf063869af0()
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

      private sealed class MTHD_1500fd4146ce4b879678abb454df5c52 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1500fd4146ce4b879678abb454df5c52()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_bde2633866bd4a3ca39504bf3646d58e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bde2633866bd4a3ca39504bf3646d58e()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_9b54bd9a3e31482a9e18e02d8781549e : HardwiredMemberDescriptor
      {
        internal PROP_9b54bd9a3e31482a9e18e02d8781549e()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_86611ea6c11648508ac037a59be7d095 : HardwiredMemberDescriptor
      {
        internal PROP_86611ea6c11648508ac037a59be7d095()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_3c6ebef9d55b4df0b575a1805e36d901 : HardwiredMemberDescriptor
      {
        internal PROP_3c6ebef9d55b4df0b575a1805e36d901()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_2f2d9a1757ba49e5b7f3c73f0e757376 : HardwiredMemberDescriptor
      {
        internal PROP_2f2d9a1757ba49e5b7f3c73f0e757376()
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

      private sealed class PROP_47aa6d8f8c09478fa9b2ac8d369a53ea : HardwiredMemberDescriptor
      {
        internal PROP_47aa6d8f8c09478fa9b2ac8d369a53ea()
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

      private sealed class PROP_a13c032b85dc4a239711b07535891de2 : HardwiredMemberDescriptor
      {
        internal PROP_a13c032b85dc4a239711b07535891de2()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_01daa0df3a3a4c118d51aeeeb25ae698 : HardwiredMemberDescriptor
      {
        internal PROP_01daa0df3a3a4c118d51aeeeb25ae698()
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

      private sealed class PROP_2702c3995f9e4eeea985048433f3eaa2 : HardwiredMemberDescriptor
      {
        internal PROP_2702c3995f9e4eeea985048433f3eaa2()
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

      private sealed class PROP_ee6ecf785c6049c69fe90228d4fb7006 : HardwiredMemberDescriptor
      {
        internal PROP_ee6ecf785c6049c69fe90228d4fb7006()
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

      private sealed class PROP_fde31e2e70c14f60b01a5bed5014e77a : HardwiredMemberDescriptor
      {
        internal PROP_fde31e2e70c14f60b01a5bed5014e77a()
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

      private sealed class PROP_f4c56f9d14b34e1da2e135540ed515b2 : HardwiredMemberDescriptor
      {
        internal PROP_f4c56f9d14b34e1da2e135540ed515b2()
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

      private sealed class PROP_d13efbaf4e1047cdaee2a716c6557ab9 : HardwiredMemberDescriptor
      {
        internal PROP_d13efbaf4e1047cdaee2a716c6557ab9()
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

      private sealed class PROP_e518b6fca1254e98878bd84290e5eef7 : HardwiredMemberDescriptor
      {
        internal PROP_e518b6fca1254e98878bd84290e5eef7()
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

      private sealed class PROP_f33f3c5cd0294e7f820e8adc36e934e2 : HardwiredMemberDescriptor
      {
        internal PROP_f33f3c5cd0294e7f820e8adc36e934e2()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_cf9bacc14b1d4a71b574afb706da0e65 : HardwiredMemberDescriptor
      {
        internal PROP_cf9bacc14b1d4a71b574afb706da0e65()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_daebc6c7f84d4186938ce7c5e43abf09 : HardwiredMemberDescriptor
      {
        internal PROP_daebc6c7f84d4186938ce7c5e43abf09()
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

      private sealed class PROP_5706b130a9864433a8b77903bdad1ef8 : HardwiredMemberDescriptor
      {
        internal PROP_5706b130a9864433a8b77903bdad1ef8()
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

      private sealed class PROP_8587e1c77d6747be92cfab0c7a4c0813 : HardwiredMemberDescriptor
      {
        internal PROP_8587e1c77d6747be92cfab0c7a4c0813()
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

      private sealed class PROP_a10e7c8905de41698a3698dcc5cbff1a : HardwiredMemberDescriptor
      {
        internal PROP_a10e7c8905de41698a3698dcc5cbff1a()
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

      private sealed class PROP_3a47122196b44503aca7ae0ec7eab98e : HardwiredMemberDescriptor
      {
        internal PROP_3a47122196b44503aca7ae0ec7eab98e()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_d68a190895af447ea3d33278370e42e0 : HardwiredMemberDescriptor
      {
        internal PROP_d68a190895af447ea3d33278370e42e0()
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

      private sealed class PROP_7791d8e5a54e42d1ba9ccdb93b7b2f78 : HardwiredMemberDescriptor
      {
        internal PROP_7791d8e5a54e42d1ba9ccdb93b7b2f78()
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

      private sealed class PROP_19d76d37a70f429b92e4d2b23c2fadec : HardwiredMemberDescriptor
      {
        internal PROP_19d76d37a70f429b92e4d2b23c2fadec()
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

      private sealed class PROP_2549982ff42d4c54ab9be4476ed71693 : HardwiredMemberDescriptor
      {
        internal PROP_2549982ff42d4c54ab9be4476ed71693()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_1b7ead0a71914a1397d1157d4ba49428 : HardwiredMemberDescriptor
      {
        internal PROP_1b7ead0a71914a1397d1157d4ba49428()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_e66b17f2e70e41b08ecb068aebc77030 : HardwiredMemberDescriptor
      {
        internal PROP_e66b17f2e70e41b08ecb068aebc77030()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_bd4b717021eb496883d98b3935f1b80a : HardwiredMemberDescriptor
      {
        internal PROP_bd4b717021eb496883d98b3935f1b80a()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_cf1165e47cfc4a45872375be98b4e63c : HardwiredMemberDescriptor
      {
        internal PROP_cf1165e47cfc4a45872375be98b4e63c()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_44b113a16c984a8faeff97ba008990ae : HardwiredMemberDescriptor
      {
        internal PROP_44b113a16c984a8faeff97ba008990ae()
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

      private sealed class PROP_67f06e739c5b4d06bd1b45608d6c39b2 : HardwiredMemberDescriptor
      {
        internal PROP_67f06e739c5b4d06bd1b45608d6c39b2()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_b63e63b2df574ff8a16242d2cbd3c815 : HardwiredMemberDescriptor
      {
        internal PROP_b63e63b2df574ff8a16242d2cbd3c815()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_9c6ac500b4cf4767b15a739416675cf3 : HardwiredMemberDescriptor
      {
        internal PROP_9c6ac500b4cf4767b15a739416675cf3()
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

      private sealed class PROP_0a2afc1dadbb4266805c1512bdd020f9 : HardwiredMemberDescriptor
      {
        internal PROP_0a2afc1dadbb4266805c1512bdd020f9()
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

    private sealed class TYPE_36140d006a6b4f979de41d57e45f1529 : HardwiredUserDataDescriptor
    {
      internal TYPE_36140d006a6b4f979de41d57e45f1529()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.MTHD_39dee02bd1544c4281c53d8950dc5e7a()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.MTHD_f474f98c245542d4822b8a89600386ee()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.MTHD_7dbc6ab922e4491896b1fce844d10ee1()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.MTHD_c697ee9d01364006ae29f9f6d2b13f69()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.MTHD_5a016acaed8d41428ae81e4133c7efc1()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.MTHD_c7b76bab76c647e9a3d887194e63cde4()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.MTHD_0f8d2382c862483b966e95358e7c2add()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.MTHD_0de9a100eddb43518e92361470ab742a()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.MTHD_02725108836f41659accb05575d43a1f()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.MTHD_fecc1c7f5e644ac79f53835564db2125()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.MTHD_d3661f9206bc47f79459bee44a529f68()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.MTHD_acbac2864fa8430fa5bbbc775c5b8b0b()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.MTHD_a0c1f38e281c4a599e2561ed5eb13dcd()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.MTHD_34f23ac1f4214d8a9446d7290bc8c55e()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.MTHD_734496b0170940b59e7bfda9264c2556()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.MTHD_f1ef0fdd066e453a8aed2b243afcf3bf()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.MTHD_fda9dd58ed6d4059945763b9b83c3a35()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.MTHD_d1c8d73b155a4db6a46229daf87d264e()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.MTHD_29fbaf2e482044ad8b00f6d9d9ab934b()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.MTHD_08ea1c6ac89c471d85a80211126c1540()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.PROP_c769089a368c4e25857c0187d53407b9());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.PROP_a4a1bae883234d5ab43effc32294629c());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.PROP_febb94718f49456d9dd681432a8c89e4());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.PROP_47994d92cb5f4695868bb6d4208adebd());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.PROP_15d558c200fd456f8fd726a45ba99b0c());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.PROP_898e89c979ee4e8ea47372b57207f2ba());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.PROP_91e150977f4a49e58a22615ee19db1cb());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_36140d006a6b4f979de41d57e45f1529.PROP_1867af4a721341c39f86e7fc49a30406());
      }

      private sealed class MTHD_39dee02bd1544c4281c53d8950dc5e7a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_39dee02bd1544c4281c53d8950dc5e7a()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_f474f98c245542d4822b8a89600386ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f474f98c245542d4822b8a89600386ee()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_7dbc6ab922e4491896b1fce844d10ee1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7dbc6ab922e4491896b1fce844d10ee1()
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

      private sealed class MTHD_c697ee9d01364006ae29f9f6d2b13f69 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c697ee9d01364006ae29f9f6d2b13f69()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_5a016acaed8d41428ae81e4133c7efc1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5a016acaed8d41428ae81e4133c7efc1()
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

      private sealed class MTHD_c7b76bab76c647e9a3d887194e63cde4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c7b76bab76c647e9a3d887194e63cde4()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_0f8d2382c862483b966e95358e7c2add : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f8d2382c862483b966e95358e7c2add()
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

      private sealed class MTHD_0de9a100eddb43518e92361470ab742a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0de9a100eddb43518e92361470ab742a()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_02725108836f41659accb05575d43a1f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_02725108836f41659accb05575d43a1f()
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

      private sealed class MTHD_fecc1c7f5e644ac79f53835564db2125 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fecc1c7f5e644ac79f53835564db2125()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_d3661f9206bc47f79459bee44a529f68 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d3661f9206bc47f79459bee44a529f68()
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

      private sealed class MTHD_acbac2864fa8430fa5bbbc775c5b8b0b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_acbac2864fa8430fa5bbbc775c5b8b0b()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_a0c1f38e281c4a599e2561ed5eb13dcd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a0c1f38e281c4a599e2561ed5eb13dcd()
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

      private sealed class MTHD_34f23ac1f4214d8a9446d7290bc8c55e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_34f23ac1f4214d8a9446d7290bc8c55e()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_734496b0170940b59e7bfda9264c2556 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_734496b0170940b59e7bfda9264c2556()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f1ef0fdd066e453a8aed2b243afcf3bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f1ef0fdd066e453a8aed2b243afcf3bf()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_fda9dd58ed6d4059945763b9b83c3a35 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fda9dd58ed6d4059945763b9b83c3a35()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_d1c8d73b155a4db6a46229daf87d264e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1c8d73b155a4db6a46229daf87d264e()
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

      private sealed class MTHD_29fbaf2e482044ad8b00f6d9d9ab934b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_29fbaf2e482044ad8b00f6d9d9ab934b()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_08ea1c6ac89c471d85a80211126c1540 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_08ea1c6ac89c471d85a80211126c1540()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_c769089a368c4e25857c0187d53407b9 : HardwiredMemberDescriptor
      {
        internal PROP_c769089a368c4e25857c0187d53407b9()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_a4a1bae883234d5ab43effc32294629c : HardwiredMemberDescriptor
      {
        internal PROP_a4a1bae883234d5ab43effc32294629c()
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

      private sealed class PROP_febb94718f49456d9dd681432a8c89e4 : HardwiredMemberDescriptor
      {
        internal PROP_febb94718f49456d9dd681432a8c89e4()
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

      private sealed class PROP_47994d92cb5f4695868bb6d4208adebd : HardwiredMemberDescriptor
      {
        internal PROP_47994d92cb5f4695868bb6d4208adebd()
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

      private sealed class PROP_15d558c200fd456f8fd726a45ba99b0c : HardwiredMemberDescriptor
      {
        internal PROP_15d558c200fd456f8fd726a45ba99b0c()
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

      private sealed class PROP_898e89c979ee4e8ea47372b57207f2ba : HardwiredMemberDescriptor
      {
        internal PROP_898e89c979ee4e8ea47372b57207f2ba()
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

      private sealed class PROP_91e150977f4a49e58a22615ee19db1cb : HardwiredMemberDescriptor
      {
        internal PROP_91e150977f4a49e58a22615ee19db1cb()
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

      private sealed class PROP_1867af4a721341c39f86e7fc49a30406 : HardwiredMemberDescriptor
      {
        internal PROP_1867af4a721341c39f86e7fc49a30406()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_b07882ad3f324df4ad3ef70a345524d3 : HardwiredUserDataDescriptor
    {
      internal TYPE_b07882ad3f324df4ad3ef70a345524d3()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.MTHD_b2ad0b7198564c98adeb86a3cc2a1c14()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.MTHD_cab36cde610941ccb67eedc294a117e6()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.MTHD_8edf3071c9474ea589726ea7e88d64a6()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.MTHD_7fe41b020b6d42b8bd8e87d7abc5a0c6()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.MTHD_3b7a2eeac49149f481d8ea0d1ccef7d3()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.MTHD_9302781d36974f17b6d74d649842f326()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.MTHD_d43da2f7294247fda8bad5217ae01ea1()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.MTHD_88dd8deedf2143bb99efbe4bbc9a3417()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.MTHD_ad0b77f4b00a49efb70c1c6eea947fc1()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.MTHD_3fb3305f9adb4ceb848cc1b5a91c8a11()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.MTHD_d06ccaea55714ac2a5cdc5fb03cb9766()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.MTHD_b88920b1912c4f74ac83ff23b1908bb4()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.MTHD_86859746b44440df8e56229c0c89b868()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.MTHD_d49f73701a8c468db9b68c5ef2cc1cbc()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.MTHD_0ffbef414f914c46aaaf31d7c1abef6b()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.MTHD_77352b9492ae42cc9fdd505266a9ab4b()
        }));
        this.AddMember("setIcon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setIcon", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.MTHD_b29c48cdff4a48ec8edd6b63e96d6565()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.MTHD_c487013e3fb84a3e8ca2af64b8cba469()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.MTHD_971ac706b5274f9fa3281f17e7657c4a()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.MTHD_270c519bffd94bcfa998541f3dc3790c()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.MTHD_4bbb22e3666c4064a31d61b7ce6a0ef8()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.MTHD_2b727a8abcea47c0b2a98fe25817a95a()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.PROP_b61d6d355d8a48b0ba156530a14d446c());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.PROP_8ead3cb5c6104a25ba366db9a8259179());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.PROP_61ff3aee871b4e8c9fffb25ee82e3d80());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.PROP_1f34cdca607a47efa68408aad147421f());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.PROP_421563b552564eec9666a40b8b15aedb());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.PROP_63934bda37084e0cae77828cb297f356());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.PROP_11dbff3851654461a1dfa23b71b6c26f());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.PROP_3125047b6c7e4db7b3a7bea07b378134());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_b07882ad3f324df4ad3ef70a345524d3.PROP_f5ebbae2d35c43619586c5f89b25ed0a());
      }

      private sealed class MTHD_b2ad0b7198564c98adeb86a3cc2a1c14 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b2ad0b7198564c98adeb86a3cc2a1c14()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_cab36cde610941ccb67eedc294a117e6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cab36cde610941ccb67eedc294a117e6()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_8edf3071c9474ea589726ea7e88d64a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8edf3071c9474ea589726ea7e88d64a6()
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

      private sealed class MTHD_7fe41b020b6d42b8bd8e87d7abc5a0c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7fe41b020b6d42b8bd8e87d7abc5a0c6()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_3b7a2eeac49149f481d8ea0d1ccef7d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3b7a2eeac49149f481d8ea0d1ccef7d3()
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

      private sealed class MTHD_9302781d36974f17b6d74d649842f326 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9302781d36974f17b6d74d649842f326()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_d43da2f7294247fda8bad5217ae01ea1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d43da2f7294247fda8bad5217ae01ea1()
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

      private sealed class MTHD_88dd8deedf2143bb99efbe4bbc9a3417 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_88dd8deedf2143bb99efbe4bbc9a3417()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_ad0b77f4b00a49efb70c1c6eea947fc1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ad0b77f4b00a49efb70c1c6eea947fc1()
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

      private sealed class MTHD_3fb3305f9adb4ceb848cc1b5a91c8a11 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3fb3305f9adb4ceb848cc1b5a91c8a11()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_d06ccaea55714ac2a5cdc5fb03cb9766 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d06ccaea55714ac2a5cdc5fb03cb9766()
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

      private sealed class MTHD_b88920b1912c4f74ac83ff23b1908bb4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b88920b1912c4f74ac83ff23b1908bb4()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_86859746b44440df8e56229c0c89b868 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_86859746b44440df8e56229c0c89b868()
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

      private sealed class MTHD_d49f73701a8c468db9b68c5ef2cc1cbc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d49f73701a8c468db9b68c5ef2cc1cbc()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color2;
        }
      }

      private sealed class MTHD_0ffbef414f914c46aaaf31d7c1abef6b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ffbef414f914c46aaaf31d7c1abef6b()
        {
          this.Initialize("set_color2", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (LuaColor), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).color2 = (LuaColor) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_77352b9492ae42cc9fdd505266a9ab4b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_77352b9492ae42cc9fdd505266a9ab4b()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_b29c48cdff4a48ec8edd6b63e96d6565 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b29c48cdff4a48ec8edd6b63e96d6565()
        {
          this.Initialize("setIcon", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("spellObj", typeof (object), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).setIcon(pars[0]);
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c487013e3fb84a3e8ca2af64b8cba469 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c487013e3fb84a3e8ca2af64b8cba469()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_971ac706b5274f9fa3281f17e7657c4a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_971ac706b5274f9fa3281f17e7657c4a()
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

      private sealed class MTHD_270c519bffd94bcfa998541f3dc3790c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_270c519bffd94bcfa998541f3dc3790c()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_4bbb22e3666c4064a31d61b7ce6a0ef8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4bbb22e3666c4064a31d61b7ce6a0ef8()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_2b727a8abcea47c0b2a98fe25817a95a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b727a8abcea47c0b2a98fe25817a95a()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_b61d6d355d8a48b0ba156530a14d446c : HardwiredMemberDescriptor
      {
        internal PROP_b61d6d355d8a48b0ba156530a14d446c()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_8ead3cb5c6104a25ba366db9a8259179 : HardwiredMemberDescriptor
      {
        internal PROP_8ead3cb5c6104a25ba366db9a8259179()
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

      private sealed class PROP_61ff3aee871b4e8c9fffb25ee82e3d80 : HardwiredMemberDescriptor
      {
        internal PROP_61ff3aee871b4e8c9fffb25ee82e3d80()
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

      private sealed class PROP_1f34cdca607a47efa68408aad147421f : HardwiredMemberDescriptor
      {
        internal PROP_1f34cdca607a47efa68408aad147421f()
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

      private sealed class PROP_421563b552564eec9666a40b8b15aedb : HardwiredMemberDescriptor
      {
        internal PROP_421563b552564eec9666a40b8b15aedb()
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

      private sealed class PROP_63934bda37084e0cae77828cb297f356 : HardwiredMemberDescriptor
      {
        internal PROP_63934bda37084e0cae77828cb297f356()
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

      private sealed class PROP_11dbff3851654461a1dfa23b71b6c26f : HardwiredMemberDescriptor
      {
        internal PROP_11dbff3851654461a1dfa23b71b6c26f()
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

      private sealed class PROP_3125047b6c7e4db7b3a7bea07b378134 : HardwiredMemberDescriptor
      {
        internal PROP_3125047b6c7e4db7b3a7bea07b378134()
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

      private sealed class PROP_f5ebbae2d35c43619586c5f89b25ed0a : HardwiredMemberDescriptor
      {
        internal PROP_f5ebbae2d35c43619586c5f89b25ed0a()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_995a627c13e64d23a18822e8953a3c17 : HardwiredUserDataDescriptor
    {
      internal TYPE_995a627c13e64d23a18822e8953a3c17()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_37a6d6081f75444f8672e9cfd803a765()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_c0d2b1ec8691421b9eae7c9f2229cd39()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_4ca6759b25f34425a30e437023f4e844()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_c582e237b04c45e2af8e8c2a274138dc()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_755074e641b14a51ba5dc9847f886bf2()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_5003f03efe01440fb6f0db8c78e4aa91()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_b32ae84dbc3c400290d3cbd08b6155fb()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_a2dfc3db8702457c98b96d26399a7844()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_d4ffd742fe594bc6bc442eb90b13bde0()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_84fcd2f067a342c6a202fa1d2977d8d7()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_fa07868128e04257a9b0c880ad941f11()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_62cb35ddc5ad46f0ab6e03adce8507ec()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_1dbbdd40d8eb40f5acc671d46ece1e00()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_46b3dc6faaa54d8a98cd542d25a64d58()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_006ca5adb88048d09563a5a9badaf62f()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_a616d130edba421c9cfb42967bc0d9b7()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_8e66bd0839904160938f20e64565c98e()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_087a8f0ba4de4f86b5429510aa448d4c()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_97ea8fc781af426aa23ead5ad83ad805()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_9f04ac0cecc3434892fdf995747e791c()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_91480ffda3354752936673ad63880d6e()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_4fc56614c3504324a60f4b6cd9092271()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_3e149d5d716a4776930fddf3ebdff99f()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_e42559b6c7d9491e9521859d3ac5bddc()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_fbba9cfffe53432a8966070fcc8b0f57()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_7c0610389e9d4e51aa178e79ec02d4c4()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_d221ec129a8b48e89b6e9348d82c8446()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.MTHD_0243f4f8abc040d9af8bc3df46335362()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.PROP_16c513e0c55d488fabec1248a6dc221a());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.PROP_eb0b557fc55345a3952f326b2e2cde7a());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.PROP_64bb5b3b3caa49c79d42fe5f3b41a9e6());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.PROP_9e0e502604ec4048805cf9cb44389f61());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.PROP_ea9704b7b85441e3ac5d998c186cea68());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.PROP_2958b5a138ad4df2834dbfb3aec11dbb());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.PROP_f6d8a04196be444b81383fe0710779b8());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.PROP_23af26d1f5394116bf15e50458fe269b());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.PROP_28e71be7bf0d458ebaa063ebbdc0174f());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.PROP_f907277a465647fdb246086ee0b07da8());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.PROP_2a7b27b95f0c4cd099dd50afa4de2aef());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.PROP_3b5642a515aa46bfbe6f2e81b37fe413());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.PROP_02649fcf2076426b86dee7412944483f());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.PROP_dff9a26b4d42413da45530ae76539007());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.PROP_a3f4221ccf494de1817530557a15e42c());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.PROP_c46abd4b19064bd7bc6b981583173140());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_995a627c13e64d23a18822e8953a3c17.PROP_7f6cfb3873e94421a6f7a355164d25b7());
      }

      private sealed class MTHD_37a6d6081f75444f8672e9cfd803a765 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_37a6d6081f75444f8672e9cfd803a765()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_c0d2b1ec8691421b9eae7c9f2229cd39 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c0d2b1ec8691421b9eae7c9f2229cd39()
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

      private sealed class MTHD_4ca6759b25f34425a30e437023f4e844 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ca6759b25f34425a30e437023f4e844()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_c582e237b04c45e2af8e8c2a274138dc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c582e237b04c45e2af8e8c2a274138dc()
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

      private sealed class MTHD_755074e641b14a51ba5dc9847f886bf2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_755074e641b14a51ba5dc9847f886bf2()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_5003f03efe01440fb6f0db8c78e4aa91 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5003f03efe01440fb6f0db8c78e4aa91()
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

      private sealed class MTHD_b32ae84dbc3c400290d3cbd08b6155fb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b32ae84dbc3c400290d3cbd08b6155fb()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_a2dfc3db8702457c98b96d26399a7844 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2dfc3db8702457c98b96d26399a7844()
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

      private sealed class MTHD_d4ffd742fe594bc6bc442eb90b13bde0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d4ffd742fe594bc6bc442eb90b13bde0()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_84fcd2f067a342c6a202fa1d2977d8d7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84fcd2f067a342c6a202fa1d2977d8d7()
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

      private sealed class MTHD_fa07868128e04257a9b0c880ad941f11 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa07868128e04257a9b0c880ad941f11()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_62cb35ddc5ad46f0ab6e03adce8507ec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_62cb35ddc5ad46f0ab6e03adce8507ec()
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

      private sealed class MTHD_1dbbdd40d8eb40f5acc671d46ece1e00 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1dbbdd40d8eb40f5acc671d46ece1e00()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_46b3dc6faaa54d8a98cd542d25a64d58 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_46b3dc6faaa54d8a98cd542d25a64d58()
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

      private sealed class MTHD_006ca5adb88048d09563a5a9badaf62f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_006ca5adb88048d09563a5a9badaf62f()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_a616d130edba421c9cfb42967bc0d9b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a616d130edba421c9cfb42967bc0d9b7()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_8e66bd0839904160938f20e64565c98e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e66bd0839904160938f20e64565c98e()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_087a8f0ba4de4f86b5429510aa448d4c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_087a8f0ba4de4f86b5429510aa448d4c()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_97ea8fc781af426aa23ead5ad83ad805 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97ea8fc781af426aa23ead5ad83ad805()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_9f04ac0cecc3434892fdf995747e791c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f04ac0cecc3434892fdf995747e791c()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_91480ffda3354752936673ad63880d6e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_91480ffda3354752936673ad63880d6e()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_4fc56614c3504324a60f4b6cd9092271 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4fc56614c3504324a60f4b6cd9092271()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_3e149d5d716a4776930fddf3ebdff99f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e149d5d716a4776930fddf3ebdff99f()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_e42559b6c7d9491e9521859d3ac5bddc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e42559b6c7d9491e9521859d3ac5bddc()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_fbba9cfffe53432a8966070fcc8b0f57 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fbba9cfffe53432a8966070fcc8b0f57()
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

      private sealed class MTHD_7c0610389e9d4e51aa178e79ec02d4c4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7c0610389e9d4e51aa178e79ec02d4c4()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_d221ec129a8b48e89b6e9348d82c8446 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d221ec129a8b48e89b6e9348d82c8446()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_0243f4f8abc040d9af8bc3df46335362 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0243f4f8abc040d9af8bc3df46335362()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_16c513e0c55d488fabec1248a6dc221a : HardwiredMemberDescriptor
      {
        internal PROP_16c513e0c55d488fabec1248a6dc221a()
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

      private sealed class PROP_eb0b557fc55345a3952f326b2e2cde7a : HardwiredMemberDescriptor
      {
        internal PROP_eb0b557fc55345a3952f326b2e2cde7a()
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

      private sealed class PROP_64bb5b3b3caa49c79d42fe5f3b41a9e6 : HardwiredMemberDescriptor
      {
        internal PROP_64bb5b3b3caa49c79d42fe5f3b41a9e6()
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

      private sealed class PROP_9e0e502604ec4048805cf9cb44389f61 : HardwiredMemberDescriptor
      {
        internal PROP_9e0e502604ec4048805cf9cb44389f61()
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

      private sealed class PROP_ea9704b7b85441e3ac5d998c186cea68 : HardwiredMemberDescriptor
      {
        internal PROP_ea9704b7b85441e3ac5d998c186cea68()
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

      private sealed class PROP_2958b5a138ad4df2834dbfb3aec11dbb : HardwiredMemberDescriptor
      {
        internal PROP_2958b5a138ad4df2834dbfb3aec11dbb()
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

      private sealed class PROP_f6d8a04196be444b81383fe0710779b8 : HardwiredMemberDescriptor
      {
        internal PROP_f6d8a04196be444b81383fe0710779b8()
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

      private sealed class PROP_23af26d1f5394116bf15e50458fe269b : HardwiredMemberDescriptor
      {
        internal PROP_23af26d1f5394116bf15e50458fe269b()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_28e71be7bf0d458ebaa063ebbdc0174f : HardwiredMemberDescriptor
      {
        internal PROP_28e71be7bf0d458ebaa063ebbdc0174f()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_f907277a465647fdb246086ee0b07da8 : HardwiredMemberDescriptor
      {
        internal PROP_f907277a465647fdb246086ee0b07da8()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_2a7b27b95f0c4cd099dd50afa4de2aef : HardwiredMemberDescriptor
      {
        internal PROP_2a7b27b95f0c4cd099dd50afa4de2aef()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_3b5642a515aa46bfbe6f2e81b37fe413 : HardwiredMemberDescriptor
      {
        internal PROP_3b5642a515aa46bfbe6f2e81b37fe413()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_02649fcf2076426b86dee7412944483f : HardwiredMemberDescriptor
      {
        internal PROP_02649fcf2076426b86dee7412944483f()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_dff9a26b4d42413da45530ae76539007 : HardwiredMemberDescriptor
      {
        internal PROP_dff9a26b4d42413da45530ae76539007()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_a3f4221ccf494de1817530557a15e42c : HardwiredMemberDescriptor
      {
        internal PROP_a3f4221ccf494de1817530557a15e42c()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_c46abd4b19064bd7bc6b981583173140 : HardwiredMemberDescriptor
      {
        internal PROP_c46abd4b19064bd7bc6b981583173140()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_7f6cfb3873e94421a6f7a355164d25b7 : HardwiredMemberDescriptor
      {
        internal PROP_7f6cfb3873e94421a6f7a355164d25b7()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_2212dae513cb4a0ead87e44402681c98 : HardwiredUserDataDescriptor
    {
      internal TYPE_2212dae513cb4a0ead87e44402681c98()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2212dae513cb4a0ead87e44402681c98.MTHD_1c8769dbd8894442b9487f764d43ea08()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2212dae513cb4a0ead87e44402681c98.MTHD_e2de1f9171424a8cb6bd6d6c663885a6()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2212dae513cb4a0ead87e44402681c98.MTHD_3e67353ea1e0430e92f2e5a6fd5d2e74()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2212dae513cb4a0ead87e44402681c98.MTHD_3cf14e9270e94ba38931b42779c792f1()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2212dae513cb4a0ead87e44402681c98.MTHD_6f997c34ba1b4dcdbeaed1f1b643500a()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2212dae513cb4a0ead87e44402681c98.MTHD_bcdd5b5fd5c649d49a3b08da3ed72dea()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2212dae513cb4a0ead87e44402681c98.MTHD_8b8c44c9768e4e75847adf0a94298759()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2212dae513cb4a0ead87e44402681c98.MTHD_4a8776fc146649569aa6068f5a17b7b0()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2212dae513cb4a0ead87e44402681c98.MTHD_01bd00c088744e30b10b5ca33c0e2384()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2212dae513cb4a0ead87e44402681c98.MTHD_9f9187d331b1459e8aa45eb0146247b5()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2212dae513cb4a0ead87e44402681c98.MTHD_523df08902c446c1b38e67fc1a713925()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2212dae513cb4a0ead87e44402681c98.MTHD_fc51f7fc4d1a42b6a42174278e424948()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2212dae513cb4a0ead87e44402681c98.MTHD_8f7e223ea64a40568d238de7487cb152()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2212dae513cb4a0ead87e44402681c98.MTHD_3832085df1a746138d6d7039f3f4916b()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2212dae513cb4a0ead87e44402681c98.MTHD_e8563c27d053478098e5f53b965081be()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2212dae513cb4a0ead87e44402681c98.MTHD_0e4786054da64c2088ab9545bd9e389c()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2212dae513cb4a0ead87e44402681c98.MTHD_b0946edc43184c21aaae17964532af21()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_2212dae513cb4a0ead87e44402681c98.PROP_5ebdfdff5ef4429ea580dbf9ce71923a());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_2212dae513cb4a0ead87e44402681c98.PROP_30b4ab128e7c43ff80a8143938c8379d());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_2212dae513cb4a0ead87e44402681c98.PROP_47c096283b8741b0b7fa1989f193502d());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_2212dae513cb4a0ead87e44402681c98.PROP_d7cdcc9f36744d14ac57f3c3483a5e5f());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_2212dae513cb4a0ead87e44402681c98.PROP_a2f5b131bd8f4a34aeab1fa099452008());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_2212dae513cb4a0ead87e44402681c98.PROP_31535a8a3afd407482ff4f94670a907e());
      }

      private sealed class MTHD_1c8769dbd8894442b9487f764d43ea08 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c8769dbd8894442b9487f764d43ea08()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_e2de1f9171424a8cb6bd6d6c663885a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e2de1f9171424a8cb6bd6d6c663885a6()
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

      private sealed class MTHD_3e67353ea1e0430e92f2e5a6fd5d2e74 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e67353ea1e0430e92f2e5a6fd5d2e74()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_3cf14e9270e94ba38931b42779c792f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3cf14e9270e94ba38931b42779c792f1()
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

      private sealed class MTHD_6f997c34ba1b4dcdbeaed1f1b643500a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6f997c34ba1b4dcdbeaed1f1b643500a()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_bcdd5b5fd5c649d49a3b08da3ed72dea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bcdd5b5fd5c649d49a3b08da3ed72dea()
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

      private sealed class MTHD_8b8c44c9768e4e75847adf0a94298759 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b8c44c9768e4e75847adf0a94298759()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_4a8776fc146649569aa6068f5a17b7b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a8776fc146649569aa6068f5a17b7b0()
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

      private sealed class MTHD_01bd00c088744e30b10b5ca33c0e2384 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_01bd00c088744e30b10b5ca33c0e2384()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_9f9187d331b1459e8aa45eb0146247b5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f9187d331b1459e8aa45eb0146247b5()
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

      private sealed class MTHD_523df08902c446c1b38e67fc1a713925 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_523df08902c446c1b38e67fc1a713925()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_fc51f7fc4d1a42b6a42174278e424948 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fc51f7fc4d1a42b6a42174278e424948()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_8f7e223ea64a40568d238de7487cb152 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8f7e223ea64a40568d238de7487cb152()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_3832085df1a746138d6d7039f3f4916b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3832085df1a746138d6d7039f3f4916b()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_e8563c27d053478098e5f53b965081be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e8563c27d053478098e5f53b965081be()
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

      private sealed class MTHD_0e4786054da64c2088ab9545bd9e389c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e4786054da64c2088ab9545bd9e389c()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_b0946edc43184c21aaae17964532af21 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b0946edc43184c21aaae17964532af21()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_5ebdfdff5ef4429ea580dbf9ce71923a : HardwiredMemberDescriptor
      {
        internal PROP_5ebdfdff5ef4429ea580dbf9ce71923a()
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

      private sealed class PROP_30b4ab128e7c43ff80a8143938c8379d : HardwiredMemberDescriptor
      {
        internal PROP_30b4ab128e7c43ff80a8143938c8379d()
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

      private sealed class PROP_47c096283b8741b0b7fa1989f193502d : HardwiredMemberDescriptor
      {
        internal PROP_47c096283b8741b0b7fa1989f193502d()
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

      private sealed class PROP_d7cdcc9f36744d14ac57f3c3483a5e5f : HardwiredMemberDescriptor
      {
        internal PROP_d7cdcc9f36744d14ac57f3c3483a5e5f()
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

      private sealed class PROP_a2f5b131bd8f4a34aeab1fa099452008 : HardwiredMemberDescriptor
      {
        internal PROP_a2f5b131bd8f4a34aeab1fa099452008()
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

      private sealed class PROP_31535a8a3afd407482ff4f94670a907e : HardwiredMemberDescriptor
      {
        internal PROP_31535a8a3afd407482ff4f94670a907e()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_9f9fb89427124bc29313e6f5d5ae8f1f : HardwiredUserDataDescriptor
    {
      internal TYPE_9f9fb89427124bc29313e6f5d5ae8f1f()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9fb89427124bc29313e6f5d5ae8f1f.MTHD_296731fde39d492b856156c8d98720c7(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9fb89427124bc29313e6f5d5ae8f1f.MTHD_ba2b8595017247269b2eec7a99a6f67f()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9fb89427124bc29313e6f5d5ae8f1f.MTHD_a8705f0bd85b46829a1e1d12a78c78a7(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9fb89427124bc29313e6f5d5ae8f1f.MTHD_621055fc72604d8381aadaf147edc449()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9fb89427124bc29313e6f5d5ae8f1f.MTHD_6e4e7a2fbfa64006aea03c2f83da5c68()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9fb89427124bc29313e6f5d5ae8f1f.MTHD_476ea891835f4928ac10a67d4537f4fb()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9fb89427124bc29313e6f5d5ae8f1f.MTHD_1116aea7a2264a029dec5724b1e15fb0()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9fb89427124bc29313e6f5d5ae8f1f.MTHD_0ee9419a49224316b0b2dca89576a96e()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9fb89427124bc29313e6f5d5ae8f1f.MTHD_b584d9c90fb847bebfc4fd168382460f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9fb89427124bc29313e6f5d5ae8f1f.MTHD_b4986c14707f4df3ac14eca2108af4bc()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9fb89427124bc29313e6f5d5ae8f1f.MTHD_18c76e7e42334f22bce8d369f57a720c()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9fb89427124bc29313e6f5d5ae8f1f.MTHD_7177a3ac363d4f4a9c5ebb9574643bac(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9fb89427124bc29313e6f5d5ae8f1f.MTHD_1c499387435244d6b4556a872e261a8c()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9fb89427124bc29313e6f5d5ae8f1f.MTHD_728e1f5d728746a2890ad21af5b72271(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9fb89427124bc29313e6f5d5ae8f1f.MTHD_127d11ebf5604026a8f120979ce6f4fa()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9fb89427124bc29313e6f5d5ae8f1f.MTHD_446a4724e9be446c85bcf7aceb2c62c2(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9fb89427124bc29313e6f5d5ae8f1f.MTHD_f158398847be4136b99213d9608c729b()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9fb89427124bc29313e6f5d5ae8f1f.MTHD_ac3ca83009f7476cb876edab117a5d93(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9fb89427124bc29313e6f5d5ae8f1f.MTHD_dc7d9e50d9034531a5af510a0e0d79b7()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9fb89427124bc29313e6f5d5ae8f1f.MTHD_1ed055e4dd504d3fb869725848906ed4(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9fb89427124bc29313e6f5d5ae8f1f.MTHD_8c828216543843eba95b4d573fa879a6()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9fb89427124bc29313e6f5d5ae8f1f.MTHD_0d65394f3cea4948a4cd9cfa6691db9c()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9fb89427124bc29313e6f5d5ae8f1f.MTHD_d76d6ac3950e49289770c0723ce225e3()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_9f9fb89427124bc29313e6f5d5ae8f1f.FLDV_d91834ea98554165908ae0dd69e13af8());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_9f9fb89427124bc29313e6f5d5ae8f1f.FLDV_a766090c450c41e881b23ad748a2fafa());
      }

      private sealed class MTHD_296731fde39d492b856156c8d98720c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_296731fde39d492b856156c8d98720c7()
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

      private sealed class MTHD_ba2b8595017247269b2eec7a99a6f67f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba2b8595017247269b2eec7a99a6f67f()
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

      private sealed class MTHD_a8705f0bd85b46829a1e1d12a78c78a7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a8705f0bd85b46829a1e1d12a78c78a7()
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

      private sealed class MTHD_621055fc72604d8381aadaf147edc449 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_621055fc72604d8381aadaf147edc449()
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

      private sealed class MTHD_6e4e7a2fbfa64006aea03c2f83da5c68 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e4e7a2fbfa64006aea03c2f83da5c68()
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

      private sealed class MTHD_476ea891835f4928ac10a67d4537f4fb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_476ea891835f4928ac10a67d4537f4fb()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_1116aea7a2264a029dec5724b1e15fb0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1116aea7a2264a029dec5724b1e15fb0()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_0ee9419a49224316b0b2dca89576a96e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ee9419a49224316b0b2dca89576a96e()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b584d9c90fb847bebfc4fd168382460f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b584d9c90fb847bebfc4fd168382460f()
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

      private sealed class MTHD_b4986c14707f4df3ac14eca2108af4bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b4986c14707f4df3ac14eca2108af4bc()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_18c76e7e42334f22bce8d369f57a720c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_18c76e7e42334f22bce8d369f57a720c()
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

      private sealed class MTHD_7177a3ac363d4f4a9c5ebb9574643bac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7177a3ac363d4f4a9c5ebb9574643bac()
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

      private sealed class MTHD_1c499387435244d6b4556a872e261a8c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c499387435244d6b4556a872e261a8c()
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

      private sealed class MTHD_728e1f5d728746a2890ad21af5b72271 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_728e1f5d728746a2890ad21af5b72271()
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

      private sealed class MTHD_127d11ebf5604026a8f120979ce6f4fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_127d11ebf5604026a8f120979ce6f4fa()
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

      private sealed class MTHD_446a4724e9be446c85bcf7aceb2c62c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_446a4724e9be446c85bcf7aceb2c62c2()
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

      private sealed class MTHD_f158398847be4136b99213d9608c729b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f158398847be4136b99213d9608c729b()
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

      private sealed class MTHD_ac3ca83009f7476cb876edab117a5d93 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac3ca83009f7476cb876edab117a5d93()
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

      private sealed class MTHD_dc7d9e50d9034531a5af510a0e0d79b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc7d9e50d9034531a5af510a0e0d79b7()
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

      private sealed class MTHD_1ed055e4dd504d3fb869725848906ed4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ed055e4dd504d3fb869725848906ed4()
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

      private sealed class MTHD_8c828216543843eba95b4d573fa879a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c828216543843eba95b4d573fa879a6()
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

      private sealed class MTHD_0d65394f3cea4948a4cd9cfa6691db9c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d65394f3cea4948a4cd9cfa6691db9c()
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

      private sealed class MTHD_d76d6ac3950e49289770c0723ce225e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d76d6ac3950e49289770c0723ce225e3()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_d91834ea98554165908ae0dd69e13af8 : HardwiredMemberDescriptor
      {
        internal FLDV_d91834ea98554165908ae0dd69e13af8()
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

      private sealed class FLDV_a766090c450c41e881b23ad748a2fafa : HardwiredMemberDescriptor
      {
        internal FLDV_a766090c450c41e881b23ad748a2fafa()
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

    private sealed class TYPE_5a4aa814ada44711985cc95172db024c : HardwiredUserDataDescriptor
    {
      internal TYPE_5a4aa814ada44711985cc95172db024c()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5a4aa814ada44711985cc95172db024c.MTHD_2760343d6c13482b916fd3b5da185b3f()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5a4aa814ada44711985cc95172db024c.MTHD_622b586ec301451bbcbd1dd6fe8eb789()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5a4aa814ada44711985cc95172db024c.MTHD_588b3a00462a4f6bb0cb633756e6369f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5a4aa814ada44711985cc95172db024c.MTHD_082e8d7357d04aadaa9a6280b091b579()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5a4aa814ada44711985cc95172db024c.MTHD_03c1faae5cd741ffbcdb065fb56b178d()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5a4aa814ada44711985cc95172db024c.MTHD_90d184e0035e49f99b96cbec055b03dd()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_5a4aa814ada44711985cc95172db024c.FLDV_e9bf2855143d4867b9de58c66d47419f());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_5a4aa814ada44711985cc95172db024c.FLDV_13e909950b5a48dabcafbca2e6b35f7e());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_5a4aa814ada44711985cc95172db024c.FLDV_af3fd823df044aeea0f29288b024e383());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_5a4aa814ada44711985cc95172db024c.FLDV_899cacf641cf46a696d10d6c7c884256());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_5a4aa814ada44711985cc95172db024c.FLDV_d2f03da3bd8b4d8b930c6a9012898434());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_5a4aa814ada44711985cc95172db024c.FLDV_bb9aae4d6e1e4ed4915ddac1679bdfbe());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_5a4aa814ada44711985cc95172db024c.FLDV_5c82b505bd034648aaafbaa20a768b4a());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_5a4aa814ada44711985cc95172db024c.FLDV_d5409bb5d0c24976b6afb7fd11c02d3e());
        this.AddMember("prestige", (IMemberDescriptor) new Bridge.TYPE_5a4aa814ada44711985cc95172db024c.FLDV_7d600134f9904be5a7c944dfab0caee8());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_5a4aa814ada44711985cc95172db024c.FLDV_79ddf1dfe1c247fa8aa2d341fdd6bc38());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_5a4aa814ada44711985cc95172db024c.FLDV_b70606cf54fe485aa5b68996db14b47c());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_5a4aa814ada44711985cc95172db024c.FLDV_91c999e3158f40b387034b729f7ec6c5());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_5a4aa814ada44711985cc95172db024c.FLDV_3dd6057bff6640a39e89b34ee9618c98());
      }

      private sealed class MTHD_2760343d6c13482b916fd3b5da185b3f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2760343d6c13482b916fd3b5da185b3f()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_622b586ec301451bbcbd1dd6fe8eb789 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_622b586ec301451bbcbd1dd6fe8eb789()
        {
          this.Initialize("construct", true, new ParameterDescriptor[11]
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
            new ParameterDescriptor("elemental", typeof (BookOf), true, (object) new DefaultValue(), false, false, false),
            new ParameterDescriptor("prestige", typeof (int), true, (object) new DefaultValue(), false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          if (argscount <= 0)
            return (object) Summon.construct((object) null, (Educative.Point) null, 1, (Table) null, true, false, "", (Table) null, (Table) null, BookOf.Nothing, 0);
          if (argscount <= 1)
            return (object) Summon.construct(pars[0], (Educative.Point) null, 1, (Table) null, true, false, "", (Table) null, (Table) null, BookOf.Nothing, 0);
          if (argscount <= 2)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], 1, (Table) null, true, false, "", (Table) null, (Table) null, BookOf.Nothing, 0);
          if (argscount <= 3)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) null, true, false, "", (Table) null, (Table) null, BookOf.Nothing, 0);
          if (argscount <= 4)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], true, false, "", (Table) null, (Table) null, BookOf.Nothing, 0);
          if (argscount <= 5)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], (bool) pars[4], false, "", (Table) null, (Table) null, BookOf.Nothing, 0);
          if (argscount <= 6)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], (bool) pars[4], (bool) pars[5], "", (Table) null, (Table) null, BookOf.Nothing, 0);
          if (argscount <= 7)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], (bool) pars[4], (bool) pars[5], (string) pars[6], (Table) null, (Table) null, BookOf.Nothing, 0);
          if (argscount <= 8)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], (bool) pars[4], (bool) pars[5], (string) pars[6], (Table) pars[7], (Table) null, BookOf.Nothing, 0);
          if (argscount <= 9)
            return (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], (bool) pars[4], (bool) pars[5], (string) pars[6], (Table) pars[7], (Table) pars[8], BookOf.Nothing, 0);
          return argscount <= 10 ? (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], (bool) pars[4], (bool) pars[5], (string) pars[6], (Table) pars[7], (Table) pars[8], (BookOf) pars[9], 0) : (object) Summon.construct(pars[0], (Educative.Point) pars[1], (int) pars[2], (Table) pars[3], (bool) pars[4], (bool) pars[5], (string) pars[6], (Table) pars[7], (Table) pars[8], (BookOf) pars[9], (int) pars[10]);
        }
      }

      private sealed class MTHD_588b3a00462a4f6bb0cb633756e6369f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_588b3a00462a4f6bb0cb633756e6369f()
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

      private sealed class MTHD_082e8d7357d04aadaa9a6280b091b579 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_082e8d7357d04aadaa9a6280b091b579()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_03c1faae5cd741ffbcdb065fb56b178d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_03c1faae5cd741ffbcdb065fb56b178d()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_90d184e0035e49f99b96cbec055b03dd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90d184e0035e49f99b96cbec055b03dd()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_e9bf2855143d4867b9de58c66d47419f : HardwiredMemberDescriptor
      {
        internal FLDV_e9bf2855143d4867b9de58c66d47419f()
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

      private sealed class FLDV_13e909950b5a48dabcafbca2e6b35f7e : HardwiredMemberDescriptor
      {
        internal FLDV_13e909950b5a48dabcafbca2e6b35f7e()
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

      private sealed class FLDV_af3fd823df044aeea0f29288b024e383 : HardwiredMemberDescriptor
      {
        internal FLDV_af3fd823df044aeea0f29288b024e383()
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

      private sealed class FLDV_899cacf641cf46a696d10d6c7c884256 : HardwiredMemberDescriptor
      {
        internal FLDV_899cacf641cf46a696d10d6c7c884256()
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

      private sealed class FLDV_d2f03da3bd8b4d8b930c6a9012898434 : HardwiredMemberDescriptor
      {
        internal FLDV_d2f03da3bd8b4d8b930c6a9012898434()
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

      private sealed class FLDV_bb9aae4d6e1e4ed4915ddac1679bdfbe : HardwiredMemberDescriptor
      {
        internal FLDV_bb9aae4d6e1e4ed4915ddac1679bdfbe()
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

      private sealed class FLDV_5c82b505bd034648aaafbaa20a768b4a : HardwiredMemberDescriptor
      {
        internal FLDV_5c82b505bd034648aaafbaa20a768b4a()
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

      private sealed class FLDV_d5409bb5d0c24976b6afb7fd11c02d3e : HardwiredMemberDescriptor
      {
        internal FLDV_d5409bb5d0c24976b6afb7fd11c02d3e()
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

      private sealed class FLDV_7d600134f9904be5a7c944dfab0caee8 : HardwiredMemberDescriptor
      {
        internal FLDV_7d600134f9904be5a7c944dfab0caee8()
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

      private sealed class FLDV_79ddf1dfe1c247fa8aa2d341fdd6bc38 : HardwiredMemberDescriptor
      {
        internal FLDV_79ddf1dfe1c247fa8aa2d341fdd6bc38()
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

      private sealed class FLDV_b70606cf54fe485aa5b68996db14b47c : HardwiredMemberDescriptor
      {
        internal FLDV_b70606cf54fe485aa5b68996db14b47c()
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

      private sealed class FLDV_91c999e3158f40b387034b729f7ec6c5 : HardwiredMemberDescriptor
      {
        internal FLDV_91c999e3158f40b387034b729f7ec6c5()
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

      private sealed class FLDV_3dd6057bff6640a39e89b34ee9618c98 : HardwiredMemberDescriptor
      {
        internal FLDV_3dd6057bff6640a39e89b34ee9618c98()
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

    private sealed class TYPE_5d13e4fd6082469798bf04213e44dbd0 : HardwiredUserDataDescriptor
    {
      internal TYPE_5d13e4fd6082469798bf04213e44dbd0()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_2ffb04e692154edb899ab4e9097f38f0()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_3265973418d14282bc00c53aaff4cedf()
        }));
        this.AddMember("get_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_9fcc4523cf744778b19f8105ada0d634()
        }));
        this.AddMember("set_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_c9eea347197a4fa9bcef9f4e2855d5b6()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_27ebfcbbca1a45959585601d60080e61()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_ee90860ca88f46fd9a9e958a111a9efe()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_59d7e95e41bf44f786fb3245f5b3d65f()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_e514081045a1484f9448e0610657127b()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_7d02de07713c47139b9a0d583baa605c()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_61d5e7326f84402ca2c3f3c01cf0f445()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_f781ff2db9704c229960ce6229a2481e()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_11746759c4044ab287f525d24956d9d1()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_0ee494446a884ec7882626925fc4e4a5()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_6ebcdcbba06c4ec0ad529a0908c58472()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_0b96e5f8cfc944dda444509726fdce54()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_8e3277b8567f4ac6ad8d888d2abdf8b2()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_649586b25e4148169359c92d68962564()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_d67299d5c4604a0f9b712ecad0bbb600()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_92a25b9d7085472e8dbd6e7fa397d7b9()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_4b2c7fe194f741088e9b0001e60d176a()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_1b091f967bdd479eb6d1207d1bee0d18()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_635bc3d5eda74a6c992b6f0015bed5fa()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_c507897b419d4a04b28f86aad25b039f()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_488b252897524e7aaa6fbf4802dd6445()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_cc33db630a07403fac1c04c7d602a3b1()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_d57ab104d523446d87a0911740ffb816()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_2a4022f3e0904f2e8878654fd42c7cfe()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_3c324e0103964269ad1f7e75e498ea5a()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_e1ada03c281e4d75ada0e785a6e6084d()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_8a11559e9100490da06c4255cbb6a102()
        }));
        this.AddMember("get_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_418258f520c446f5b733fb12d9047aff()
        }));
        this.AddMember("set_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_c192b1ac57d14875b1783f03f5a2ed61()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_bf50362a7f1748c8830340fe80e63e85()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_3f27e3488a1d4f23b75dfb40d7333bb1()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_ade35448a7c340128e0ea3f47a674720()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_90431acb004e49b99a5e223030cb5ce7()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_c6ea2ac59c9244ceaa6fcd493eed9efd()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_3a9cce63e67d4141b05cd0ad7fe4596b()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_2daf2a50d7a34ec084e468fa8f6b722b()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_caccefd5c50b4680b16ab897794f0905()
        }));
        this.AddMember("get_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_c6a7112e8c744e0eb05be7bf244881d8()
        }));
        this.AddMember("set_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_122a99efb8864439b42ece6f52fbc443()
        }));
        this.AddMember("get_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_47cd7734d3f64501b5f2290756a822f5()
        }));
        this.AddMember("set_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_0a6eced04de74d63b523458894aab575()
        }));
        this.AddMember("get_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_0f89f14e0d1a40c6a80cbe0d6ad045be()
        }));
        this.AddMember("set_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_e7dcafd0982f45c2999ab347311f8544()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_92efd6c2435d457c9e87fa7797d7c162()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_63db2c80ecce4c8d917838c9bc1b7253()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_c24a4aaf4db34705b20ecc82c6e8267b()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_c3778b209b444b3aa7a54af482247c89()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_739c3d655fee4155bae4db8a872950f0()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_81dca5b4657c44839b43492094f963e0()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_727fe1ef3cf24475a1f0fefb1838145f()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_f9122191bed74d27b96da0e2dff7ac92()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_409575be7fc7416c9d889f6c23ba16fe()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_6cad208b3ad44f11b332fd0d3fb678c6()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_963dfb9f3c5d4c3a903791885c168269()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_1cabe72d51c44e2f865761048e978720()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_db3e8d5c97214b2a806c69b6d8e0a526()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.MTHD_4b93686d63c04d21a84489a28326a315()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.PROP_571635099b6c46ef8e8994cf12e6313c());
        this.AddMember("visible", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.PROP_0c4bca16988d4f28aa7ac54936fa06bc());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.PROP_9b7825d81ec44d818191a8527caa57c3());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.PROP_db532fafd4d0482594ebc563ffd77ccd());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.PROP_75f12c608d264486b8f84395d551da56());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.PROP_f4d0f8f0fd6b4a8a8f044e06ca363fbf());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.PROP_9086c904267d470796d79c5e7c92a440());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.PROP_a5a838ba5a394d07bca042b0c403708f());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.PROP_34e76eed26294f658cc9cb6cabaee207());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.PROP_322afc3d92024fe49513988ccc438cd2());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.PROP_b755059d960e4466b35dde0a732d6df7());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.PROP_19dfc222295d4120844817b155814ce6());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.PROP_17e47974f38c4c81b7da399132bc6d45());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.PROP_2d0ffeecd76f4d57ad98ff369ad9c430());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.PROP_23026239964a47dc9858d94de1f26e63());
        this.AddMember("onClick2", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.PROP_cb1a2efe55b247488dd99feae00ed735());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.PROP_9676f7a3e0224fb8beb08c0cedb7f095());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.PROP_a277197be0ec4c86b10e07a97d29524a());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.PROP_df54eae1a6024c0d98939b69adbe2ef5());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.PROP_9e825de336794013966eb22681e28251());
        this.AddMember("textColor2", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.PROP_3ce9d66948044b0eb7ba3d227e230c30());
        this.AddMember("highlightColor", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.PROP_1778feffac994a23a1e0bbedc4b41639());
        this.AddMember("highlightColor2", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.PROP_53a629ad53a646378a2f2c1b4b9c8f26());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.PROP_6c88bca763974577a99db6280919431a());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.PROP_d4c84f8fa528456f9319d07ed9555aff());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.FLDV_8132810828c94d859bd4deedd0a328a6());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.FLDV_f352ebee3402411faa5ee000945d1cd4());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_5d13e4fd6082469798bf04213e44dbd0.FLDV_23399e8386fb47db85fa5174bff9cbff());
      }

      private sealed class MTHD_2ffb04e692154edb899ab4e9097f38f0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2ffb04e692154edb899ab4e9097f38f0()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_3265973418d14282bc00c53aaff4cedf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3265973418d14282bc00c53aaff4cedf()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_9fcc4523cf744778b19f8105ada0d634 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9fcc4523cf744778b19f8105ada0d634()
        {
          this.Initialize("get_visible", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).visible;
        }
      }

      private sealed class MTHD_c9eea347197a4fa9bcef9f4e2855d5b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c9eea347197a4fa9bcef9f4e2855d5b6()
        {
          this.Initialize("set_visible", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (bool), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).visible = (bool) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_27ebfcbbca1a45959585601d60080e61 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_27ebfcbbca1a45959585601d60080e61()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_ee90860ca88f46fd9a9e958a111a9efe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee90860ca88f46fd9a9e958a111a9efe()
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

      private sealed class MTHD_59d7e95e41bf44f786fb3245f5b3d65f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_59d7e95e41bf44f786fb3245f5b3d65f()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_e514081045a1484f9448e0610657127b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e514081045a1484f9448e0610657127b()
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

      private sealed class MTHD_7d02de07713c47139b9a0d583baa605c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7d02de07713c47139b9a0d583baa605c()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_61d5e7326f84402ca2c3f3c01cf0f445 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_61d5e7326f84402ca2c3f3c01cf0f445()
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

      private sealed class MTHD_f781ff2db9704c229960ce6229a2481e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f781ff2db9704c229960ce6229a2481e()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_11746759c4044ab287f525d24956d9d1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_11746759c4044ab287f525d24956d9d1()
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

      private sealed class MTHD_0ee494446a884ec7882626925fc4e4a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ee494446a884ec7882626925fc4e4a5()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_6ebcdcbba06c4ec0ad529a0908c58472 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ebcdcbba06c4ec0ad529a0908c58472()
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

      private sealed class MTHD_0b96e5f8cfc944dda444509726fdce54 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b96e5f8cfc944dda444509726fdce54()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_8e3277b8567f4ac6ad8d888d2abdf8b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e3277b8567f4ac6ad8d888d2abdf8b2()
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

      private sealed class MTHD_649586b25e4148169359c92d68962564 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_649586b25e4148169359c92d68962564()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_d67299d5c4604a0f9b712ecad0bbb600 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d67299d5c4604a0f9b712ecad0bbb600()
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

      private sealed class MTHD_92a25b9d7085472e8dbd6e7fa397d7b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_92a25b9d7085472e8dbd6e7fa397d7b9()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_4b2c7fe194f741088e9b0001e60d176a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b2c7fe194f741088e9b0001e60d176a()
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

      private sealed class MTHD_1b091f967bdd479eb6d1207d1bee0d18 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1b091f967bdd479eb6d1207d1bee0d18()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_635bc3d5eda74a6c992b6f0015bed5fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_635bc3d5eda74a6c992b6f0015bed5fa()
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

      private sealed class MTHD_c507897b419d4a04b28f86aad25b039f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c507897b419d4a04b28f86aad25b039f()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_488b252897524e7aaa6fbf4802dd6445 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_488b252897524e7aaa6fbf4802dd6445()
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

      private sealed class MTHD_cc33db630a07403fac1c04c7d602a3b1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cc33db630a07403fac1c04c7d602a3b1()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_d57ab104d523446d87a0911740ffb816 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d57ab104d523446d87a0911740ffb816()
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

      private sealed class MTHD_2a4022f3e0904f2e8878654fd42c7cfe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a4022f3e0904f2e8878654fd42c7cfe()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_3c324e0103964269ad1f7e75e498ea5a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3c324e0103964269ad1f7e75e498ea5a()
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

      private sealed class MTHD_e1ada03c281e4d75ada0e785a6e6084d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e1ada03c281e4d75ada0e785a6e6084d()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_8a11559e9100490da06c4255cbb6a102 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a11559e9100490da06c4255cbb6a102()
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

      private sealed class MTHD_418258f520c446f5b733fb12d9047aff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_418258f520c446f5b733fb12d9047aff()
        {
          this.Initialize("get_onClick2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick2;
        }
      }

      private sealed class MTHD_c192b1ac57d14875b1783f03f5a2ed61 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c192b1ac57d14875b1783f03f5a2ed61()
        {
          this.Initialize("set_onClick2", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (DynValue), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).onClick2 = (DynValue) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_bf50362a7f1748c8830340fe80e63e85 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf50362a7f1748c8830340fe80e63e85()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_3f27e3488a1d4f23b75dfb40d7333bb1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f27e3488a1d4f23b75dfb40d7333bb1()
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

      private sealed class MTHD_ade35448a7c340128e0ea3f47a674720 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ade35448a7c340128e0ea3f47a674720()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color2;
        }
      }

      private sealed class MTHD_90431acb004e49b99a5e223030cb5ce7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90431acb004e49b99a5e223030cb5ce7()
        {
          this.Initialize("set_color2", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (LuaColor), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).color2 = (LuaColor) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_c6ea2ac59c9244ceaa6fcd493eed9efd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c6ea2ac59c9244ceaa6fcd493eed9efd()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_3a9cce63e67d4141b05cd0ad7fe4596b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3a9cce63e67d4141b05cd0ad7fe4596b()
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

      private sealed class MTHD_2daf2a50d7a34ec084e468fa8f6b722b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2daf2a50d7a34ec084e468fa8f6b722b()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_caccefd5c50b4680b16ab897794f0905 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_caccefd5c50b4680b16ab897794f0905()
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

      private sealed class MTHD_c6a7112e8c744e0eb05be7bf244881d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c6a7112e8c744e0eb05be7bf244881d8()
        {
          this.Initialize("get_textColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor2;
        }
      }

      private sealed class MTHD_122a99efb8864439b42ece6f52fbc443 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_122a99efb8864439b42ece6f52fbc443()
        {
          this.Initialize("set_textColor2", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (LuaColor), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).textColor2 = (LuaColor) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_47cd7734d3f64501b5f2290756a822f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_47cd7734d3f64501b5f2290756a822f5()
        {
          this.Initialize("get_highlightColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor;
        }
      }

      private sealed class MTHD_0a6eced04de74d63b523458894aab575 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0a6eced04de74d63b523458894aab575()
        {
          this.Initialize("set_highlightColor", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (string), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).highlightColor = (string) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_0f89f14e0d1a40c6a80cbe0d6ad045be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f89f14e0d1a40c6a80cbe0d6ad045be()
        {
          this.Initialize("get_highlightColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor2;
        }
      }

      private sealed class MTHD_e7dcafd0982f45c2999ab347311f8544 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7dcafd0982f45c2999ab347311f8544()
        {
          this.Initialize("set_highlightColor2", false, new ParameterDescriptor[1]
          {
            new ParameterDescriptor("value", typeof (LuaColor), false, (object) null, false, false, false)
          }, false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).highlightColor2 = (LuaColor) pars[0];
          return (object) null;
        }
      }

      private sealed class MTHD_92efd6c2435d457c9e87fa7797d7c162 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_92efd6c2435d457c9e87fa7797d7c162()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_63db2c80ecce4c8d917838c9bc1b7253 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_63db2c80ecce4c8d917838c9bc1b7253()
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

      private sealed class MTHD_c24a4aaf4db34705b20ecc82c6e8267b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c24a4aaf4db34705b20ecc82c6e8267b()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_c3778b209b444b3aa7a54af482247c89 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c3778b209b444b3aa7a54af482247c89()
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

      private sealed class MTHD_739c3d655fee4155bae4db8a872950f0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_739c3d655fee4155bae4db8a872950f0()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_81dca5b4657c44839b43492094f963e0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_81dca5b4657c44839b43492094f963e0()
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

      private sealed class MTHD_727fe1ef3cf24475a1f0fefb1838145f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_727fe1ef3cf24475a1f0fefb1838145f()
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

      private sealed class MTHD_f9122191bed74d27b96da0e2dff7ac92 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f9122191bed74d27b96da0e2dff7ac92()
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

      private sealed class MTHD_409575be7fc7416c9d889f6c23ba16fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_409575be7fc7416c9d889f6c23ba16fe()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_6cad208b3ad44f11b332fd0d3fb678c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6cad208b3ad44f11b332fd0d3fb678c6()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_963dfb9f3c5d4c3a903791885c168269 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_963dfb9f3c5d4c3a903791885c168269()
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

      private sealed class MTHD_1cabe72d51c44e2f865761048e978720 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1cabe72d51c44e2f865761048e978720()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_db3e8d5c97214b2a806c69b6d8e0a526 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db3e8d5c97214b2a806c69b6d8e0a526()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_4b93686d63c04d21a84489a28326a315 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b93686d63c04d21a84489a28326a315()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_571635099b6c46ef8e8994cf12e6313c : HardwiredMemberDescriptor
      {
        internal PROP_571635099b6c46ef8e8994cf12e6313c()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_0c4bca16988d4f28aa7ac54936fa06bc : HardwiredMemberDescriptor
      {
        internal PROP_0c4bca16988d4f28aa7ac54936fa06bc()
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

      private sealed class PROP_9b7825d81ec44d818191a8527caa57c3 : HardwiredMemberDescriptor
      {
        internal PROP_9b7825d81ec44d818191a8527caa57c3()
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

      private sealed class PROP_db532fafd4d0482594ebc563ffd77ccd : HardwiredMemberDescriptor
      {
        internal PROP_db532fafd4d0482594ebc563ffd77ccd()
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

      private sealed class PROP_75f12c608d264486b8f84395d551da56 : HardwiredMemberDescriptor
      {
        internal PROP_75f12c608d264486b8f84395d551da56()
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

      private sealed class PROP_f4d0f8f0fd6b4a8a8f044e06ca363fbf : HardwiredMemberDescriptor
      {
        internal PROP_f4d0f8f0fd6b4a8a8f044e06ca363fbf()
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

      private sealed class PROP_9086c904267d470796d79c5e7c92a440 : HardwiredMemberDescriptor
      {
        internal PROP_9086c904267d470796d79c5e7c92a440()
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

      private sealed class PROP_a5a838ba5a394d07bca042b0c403708f : HardwiredMemberDescriptor
      {
        internal PROP_a5a838ba5a394d07bca042b0c403708f()
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

      private sealed class PROP_34e76eed26294f658cc9cb6cabaee207 : HardwiredMemberDescriptor
      {
        internal PROP_34e76eed26294f658cc9cb6cabaee207()
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

      private sealed class PROP_322afc3d92024fe49513988ccc438cd2 : HardwiredMemberDescriptor
      {
        internal PROP_322afc3d92024fe49513988ccc438cd2()
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

      private sealed class PROP_b755059d960e4466b35dde0a732d6df7 : HardwiredMemberDescriptor
      {
        internal PROP_b755059d960e4466b35dde0a732d6df7()
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

      private sealed class PROP_19dfc222295d4120844817b155814ce6 : HardwiredMemberDescriptor
      {
        internal PROP_19dfc222295d4120844817b155814ce6()
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

      private sealed class PROP_17e47974f38c4c81b7da399132bc6d45 : HardwiredMemberDescriptor
      {
        internal PROP_17e47974f38c4c81b7da399132bc6d45()
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

      private sealed class PROP_2d0ffeecd76f4d57ad98ff369ad9c430 : HardwiredMemberDescriptor
      {
        internal PROP_2d0ffeecd76f4d57ad98ff369ad9c430()
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

      private sealed class PROP_23026239964a47dc9858d94de1f26e63 : HardwiredMemberDescriptor
      {
        internal PROP_23026239964a47dc9858d94de1f26e63()
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

      private sealed class PROP_cb1a2efe55b247488dd99feae00ed735 : HardwiredMemberDescriptor
      {
        internal PROP_cb1a2efe55b247488dd99feae00ed735()
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

      private sealed class PROP_9676f7a3e0224fb8beb08c0cedb7f095 : HardwiredMemberDescriptor
      {
        internal PROP_9676f7a3e0224fb8beb08c0cedb7f095()
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

      private sealed class PROP_a277197be0ec4c86b10e07a97d29524a : HardwiredMemberDescriptor
      {
        internal PROP_a277197be0ec4c86b10e07a97d29524a()
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

      private sealed class PROP_df54eae1a6024c0d98939b69adbe2ef5 : HardwiredMemberDescriptor
      {
        internal PROP_df54eae1a6024c0d98939b69adbe2ef5()
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

      private sealed class PROP_9e825de336794013966eb22681e28251 : HardwiredMemberDescriptor
      {
        internal PROP_9e825de336794013966eb22681e28251()
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

      private sealed class PROP_3ce9d66948044b0eb7ba3d227e230c30 : HardwiredMemberDescriptor
      {
        internal PROP_3ce9d66948044b0eb7ba3d227e230c30()
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

      private sealed class PROP_1778feffac994a23a1e0bbedc4b41639 : HardwiredMemberDescriptor
      {
        internal PROP_1778feffac994a23a1e0bbedc4b41639()
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

      private sealed class PROP_53a629ad53a646378a2f2c1b4b9c8f26 : HardwiredMemberDescriptor
      {
        internal PROP_53a629ad53a646378a2f2c1b4b9c8f26()
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

      private sealed class PROP_6c88bca763974577a99db6280919431a : HardwiredMemberDescriptor
      {
        internal PROP_6c88bca763974577a99db6280919431a()
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

      private sealed class PROP_d4c84f8fa528456f9319d07ed9555aff : HardwiredMemberDescriptor
      {
        internal PROP_d4c84f8fa528456f9319d07ed9555aff()
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

      private sealed class FLDV_8132810828c94d859bd4deedd0a328a6 : HardwiredMemberDescriptor
      {
        internal FLDV_8132810828c94d859bd4deedd0a328a6()
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

      private sealed class FLDV_f352ebee3402411faa5ee000945d1cd4 : HardwiredMemberDescriptor
      {
        internal FLDV_f352ebee3402411faa5ee000945d1cd4()
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

      private sealed class FLDV_23399e8386fb47db85fa5174bff9cbff : HardwiredMemberDescriptor
      {
        internal FLDV_23399e8386fb47db85fa5174bff9cbff()
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

    private sealed class TYPE_61b6fbb74f13485eaa47b577e0759ef5 : HardwiredUserDataDescriptor
    {
      internal TYPE_61b6fbb74f13485eaa47b577e0759ef5()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61b6fbb74f13485eaa47b577e0759ef5.MTHD_c328ae3c37f24d5689a16b7b88d1df67()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61b6fbb74f13485eaa47b577e0759ef5.MTHD_20f8d66fead7459eb0b001ce77feb8e8()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61b6fbb74f13485eaa47b577e0759ef5.MTHD_c80577b8b5694c608262b804011f199e()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61b6fbb74f13485eaa47b577e0759ef5.MTHD_6ac784c0def74f95be9daf28bc7553a4()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61b6fbb74f13485eaa47b577e0759ef5.MTHD_5f6e19baf31545249af62da74e7f9f54()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61b6fbb74f13485eaa47b577e0759ef5.MTHD_93c0e937349b419c8d29e30b3c8f5e33()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_61b6fbb74f13485eaa47b577e0759ef5.FLDV_92762396d39b43faa9f088e564d993dc());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_61b6fbb74f13485eaa47b577e0759ef5.FLDV_3acec5f14c2a41aaacdc545e5fa90e24());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_61b6fbb74f13485eaa47b577e0759ef5.FLDV_e9e7f8d244214ae9806408770a43f252());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_61b6fbb74f13485eaa47b577e0759ef5.FLDV_fd0d7b1bfc734e4a9aeab5315e72cbf4());
      }

      private sealed class MTHD_c328ae3c37f24d5689a16b7b88d1df67 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c328ae3c37f24d5689a16b7b88d1df67()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_20f8d66fead7459eb0b001ce77feb8e8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_20f8d66fead7459eb0b001ce77feb8e8()
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

      private sealed class MTHD_c80577b8b5694c608262b804011f199e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c80577b8b5694c608262b804011f199e()
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

      private sealed class MTHD_6ac784c0def74f95be9daf28bc7553a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ac784c0def74f95be9daf28bc7553a4()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_5f6e19baf31545249af62da74e7f9f54 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5f6e19baf31545249af62da74e7f9f54()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_93c0e937349b419c8d29e30b3c8f5e33 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93c0e937349b419c8d29e30b3c8f5e33()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_92762396d39b43faa9f088e564d993dc : HardwiredMemberDescriptor
      {
        internal FLDV_92762396d39b43faa9f088e564d993dc()
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

      private sealed class FLDV_3acec5f14c2a41aaacdc545e5fa90e24 : HardwiredMemberDescriptor
      {
        internal FLDV_3acec5f14c2a41aaacdc545e5fa90e24()
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

      private sealed class FLDV_e9e7f8d244214ae9806408770a43f252 : HardwiredMemberDescriptor
      {
        internal FLDV_e9e7f8d244214ae9806408770a43f252()
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

      private sealed class FLDV_fd0d7b1bfc734e4a9aeab5315e72cbf4 : HardwiredMemberDescriptor
      {
        internal FLDV_fd0d7b1bfc734e4a9aeab5315e72cbf4()
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

    private sealed class TYPE_e8360457ba8e4cc780163978b566cde7 : HardwiredUserDataDescriptor
    {
      internal TYPE_e8360457ba8e4cc780163978b566cde7()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e8360457ba8e4cc780163978b566cde7.MTHD_a4e69d84b17e4ab5870f5e3253acc38b()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e8360457ba8e4cc780163978b566cde7.MTHD_562796200547425981e628fb7fd1637f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e8360457ba8e4cc780163978b566cde7.MTHD_c59936d20f5b4969bdaf511b85819bcd()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e8360457ba8e4cc780163978b566cde7.MTHD_9eedf3c74cec45dfa800b111e741d466()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e8360457ba8e4cc780163978b566cde7.MTHD_20218af8e0f24676ab4e8b4bedccbab0()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_e8360457ba8e4cc780163978b566cde7.FLDV_63f37bb5d9bd4ef99b0ed394aa75d116());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_e8360457ba8e4cc780163978b566cde7.FLDV_e7e810ebfad744a0acf56b707ddee99b());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_e8360457ba8e4cc780163978b566cde7.FLDV_eedc749795cd4694956566efbeb13edf());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_e8360457ba8e4cc780163978b566cde7.FLDV_81e088ed220e48e186980cb3ba2e4a7a());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_e8360457ba8e4cc780163978b566cde7.FLDV_102b8068ef51464a8a8d1fadaf6250cd());
      }

      private sealed class MTHD_a4e69d84b17e4ab5870f5e3253acc38b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a4e69d84b17e4ab5870f5e3253acc38b()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_562796200547425981e628fb7fd1637f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_562796200547425981e628fb7fd1637f()
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

      private sealed class MTHD_c59936d20f5b4969bdaf511b85819bcd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c59936d20f5b4969bdaf511b85819bcd()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_9eedf3c74cec45dfa800b111e741d466 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9eedf3c74cec45dfa800b111e741d466()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_20218af8e0f24676ab4e8b4bedccbab0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_20218af8e0f24676ab4e8b4bedccbab0()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_63f37bb5d9bd4ef99b0ed394aa75d116 : HardwiredMemberDescriptor
      {
        internal FLDV_63f37bb5d9bd4ef99b0ed394aa75d116()
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

      private sealed class FLDV_e7e810ebfad744a0acf56b707ddee99b : HardwiredMemberDescriptor
      {
        internal FLDV_e7e810ebfad744a0acf56b707ddee99b()
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

      private sealed class FLDV_eedc749795cd4694956566efbeb13edf : HardwiredMemberDescriptor
      {
        internal FLDV_eedc749795cd4694956566efbeb13edf()
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

      private sealed class FLDV_81e088ed220e48e186980cb3ba2e4a7a : HardwiredMemberDescriptor
      {
        internal FLDV_81e088ed220e48e186980cb3ba2e4a7a()
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

      private sealed class FLDV_102b8068ef51464a8a8d1fadaf6250cd : HardwiredMemberDescriptor
      {
        internal FLDV_102b8068ef51464a8a8d1fadaf6250cd()
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

    private sealed class TYPE_eec1e86cf01548b8b41ba0ab3b502b8b : HardwiredUserDataDescriptor
    {
      internal TYPE_eec1e86cf01548b8b41ba0ab3b502b8b()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eec1e86cf01548b8b41ba0ab3b502b8b.MTHD_3e17723437d24c9ea5504c677b9cc63d()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eec1e86cf01548b8b41ba0ab3b502b8b.MTHD_3c09fbdd903a4375b9ab5273c5745a83()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eec1e86cf01548b8b41ba0ab3b502b8b.MTHD_7efad465c58445c1b2f79b3c2498b3c8()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eec1e86cf01548b8b41ba0ab3b502b8b.MTHD_5249706a9de84940a2b8c1de8453e313()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eec1e86cf01548b8b41ba0ab3b502b8b.MTHD_8f72137d995e4ef7bc1fb4523a326544()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eec1e86cf01548b8b41ba0ab3b502b8b.MTHD_e577b391b69c45ada6d31e73973f7f80()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eec1e86cf01548b8b41ba0ab3b502b8b.MTHD_cd02ef387e844ee5961f0ad7949c5730()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eec1e86cf01548b8b41ba0ab3b502b8b.MTHD_a3a7ffa1babc4a8fb9dd65c4186a9477()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eec1e86cf01548b8b41ba0ab3b502b8b.MTHD_1e63dddc674541b396cb640d2513d682()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eec1e86cf01548b8b41ba0ab3b502b8b.MTHD_603dd49bab854eddab5a38f375556cc0()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eec1e86cf01548b8b41ba0ab3b502b8b.MTHD_5d407c2c34c941ec8127c88f88527141()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eec1e86cf01548b8b41ba0ab3b502b8b.MTHD_def28e03967f4a76a033af0b61771df9()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_eec1e86cf01548b8b41ba0ab3b502b8b.MTHD_65799b3a384b4cbb9089d0ac24b933cd()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_eec1e86cf01548b8b41ba0ab3b502b8b.FLDV_651359bb1f8942769690282d4c609487());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_eec1e86cf01548b8b41ba0ab3b502b8b.FLDV_98f7baf900094a3c92246da014b8d657());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_eec1e86cf01548b8b41ba0ab3b502b8b.FLDV_4eee3de438344cf69827bfee0cd249e5());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_eec1e86cf01548b8b41ba0ab3b502b8b.FLDV_38515aae072f40a0a573c5089026d4e7());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_eec1e86cf01548b8b41ba0ab3b502b8b.FLDV_dab94da83435400a98c85d0d60bbd1eb());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_eec1e86cf01548b8b41ba0ab3b502b8b.FLDV_3db4d93780ec4e71b512727988cab353());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_eec1e86cf01548b8b41ba0ab3b502b8b.FLDV_a62a2a6aeac6489e9f690764ffc8845d());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_eec1e86cf01548b8b41ba0ab3b502b8b.FLDV_7905c1a5071a4fc08001422bb58e6609());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_eec1e86cf01548b8b41ba0ab3b502b8b.DVAL_c2c7f8730d75446e8b5183980f6965f2());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_eec1e86cf01548b8b41ba0ab3b502b8b.DVAL_798be2d7cf43449ebc992958ecda6b1a());
      }

      private sealed class MTHD_3e17723437d24c9ea5504c677b9cc63d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e17723437d24c9ea5504c677b9cc63d()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_3c09fbdd903a4375b9ab5273c5745a83 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3c09fbdd903a4375b9ab5273c5745a83()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_7efad465c58445c1b2f79b3c2498b3c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7efad465c58445c1b2f79b3c2498b3c8()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_5249706a9de84940a2b8c1de8453e313 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5249706a9de84940a2b8c1de8453e313()
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

      private sealed class MTHD_8f72137d995e4ef7bc1fb4523a326544 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8f72137d995e4ef7bc1fb4523a326544()
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

      private sealed class MTHD_e577b391b69c45ada6d31e73973f7f80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e577b391b69c45ada6d31e73973f7f80()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_cd02ef387e844ee5961f0ad7949c5730 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd02ef387e844ee5961f0ad7949c5730()
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

      private sealed class MTHD_a3a7ffa1babc4a8fb9dd65c4186a9477 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a3a7ffa1babc4a8fb9dd65c4186a9477()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_1e63dddc674541b396cb640d2513d682 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1e63dddc674541b396cb640d2513d682()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_603dd49bab854eddab5a38f375556cc0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_603dd49bab854eddab5a38f375556cc0()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_5d407c2c34c941ec8127c88f88527141 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d407c2c34c941ec8127c88f88527141()
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

      private sealed class MTHD_def28e03967f4a76a033af0b61771df9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_def28e03967f4a76a033af0b61771df9()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_65799b3a384b4cbb9089d0ac24b933cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65799b3a384b4cbb9089d0ac24b933cd()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_651359bb1f8942769690282d4c609487 : HardwiredMemberDescriptor
      {
        internal FLDV_651359bb1f8942769690282d4c609487()
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

      private sealed class FLDV_98f7baf900094a3c92246da014b8d657 : HardwiredMemberDescriptor
      {
        internal FLDV_98f7baf900094a3c92246da014b8d657()
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

      private sealed class FLDV_4eee3de438344cf69827bfee0cd249e5 : HardwiredMemberDescriptor
      {
        internal FLDV_4eee3de438344cf69827bfee0cd249e5()
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

      private sealed class FLDV_38515aae072f40a0a573c5089026d4e7 : HardwiredMemberDescriptor
      {
        internal FLDV_38515aae072f40a0a573c5089026d4e7()
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

      private sealed class FLDV_dab94da83435400a98c85d0d60bbd1eb : HardwiredMemberDescriptor
      {
        internal FLDV_dab94da83435400a98c85d0d60bbd1eb()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_3db4d93780ec4e71b512727988cab353 : HardwiredMemberDescriptor
      {
        internal FLDV_3db4d93780ec4e71b512727988cab353()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_a62a2a6aeac6489e9f690764ffc8845d : HardwiredMemberDescriptor
      {
        internal FLDV_a62a2a6aeac6489e9f690764ffc8845d()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_7905c1a5071a4fc08001422bb58e6609 : HardwiredMemberDescriptor
      {
        internal FLDV_7905c1a5071a4fc08001422bb58e6609()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_c2c7f8730d75446e8b5183980f6965f2 : DynValueMemberDescriptor
      {
        internal DVAL_c2c7f8730d75446e8b5183980f6965f2()
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

      private sealed class DVAL_798be2d7cf43449ebc992958ecda6b1a : DynValueMemberDescriptor
      {
        internal DVAL_798be2d7cf43449ebc992958ecda6b1a()
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

    private sealed class TYPE_7821c251a9bc412f92ec9bb115287fe9 : HardwiredUserDataDescriptor
    {
      internal TYPE_7821c251a9bc412f92ec9bb115287fe9()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7821c251a9bc412f92ec9bb115287fe9.MTHD_b39188587ce04a4394ebd424d8c6e431()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7821c251a9bc412f92ec9bb115287fe9.MTHD_c4d28defac8d40a7bc6d19728144efc9()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7821c251a9bc412f92ec9bb115287fe9.MTHD_12ee21b39c1c4ff78214fd0aced51148(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7821c251a9bc412f92ec9bb115287fe9.MTHD_cf8cff79d5974c099935bee81c81cd04()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7821c251a9bc412f92ec9bb115287fe9.MTHD_5ceb8eed6e0c4f359a439888e59e2708(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7821c251a9bc412f92ec9bb115287fe9.MTHD_f898e597ac044d71b53371e9ac42d44e()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7821c251a9bc412f92ec9bb115287fe9.MTHD_5c3346d96b504863853fd2bf3eb6df9b()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7821c251a9bc412f92ec9bb115287fe9.MTHD_7a056beb8cac4c9f8d27ae76aebf8195()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7821c251a9bc412f92ec9bb115287fe9.MTHD_d4bc13d7929b4500adcb6c6383fca462()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7821c251a9bc412f92ec9bb115287fe9.MTHD_83b698f994784d46ab21f755d9d49225()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_7821c251a9bc412f92ec9bb115287fe9.FLDV_62ffdd229d174d23983a914dbb94a7bd());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_7821c251a9bc412f92ec9bb115287fe9.FLDV_2054f6c5d5d04dc3a2bd8d82bdbfbfe5());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_7821c251a9bc412f92ec9bb115287fe9.FLDV_3abb42da163b4bb096e3bf3df97d8727());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_7821c251a9bc412f92ec9bb115287fe9.FLDV_c9f98babfc7e40d6966c8ee6dcd1f19b());
        this.AddMember("white", (IMemberDescriptor) new Bridge.TYPE_7821c251a9bc412f92ec9bb115287fe9.FLDV_9a8a9e890b8d449c9b300da88d13d94c());
      }

      private sealed class MTHD_b39188587ce04a4394ebd424d8c6e431 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b39188587ce04a4394ebd424d8c6e431()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_c4d28defac8d40a7bc6d19728144efc9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c4d28defac8d40a7bc6d19728144efc9()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_12ee21b39c1c4ff78214fd0aced51148 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_12ee21b39c1c4ff78214fd0aced51148()
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

      private sealed class MTHD_cf8cff79d5974c099935bee81c81cd04 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf8cff79d5974c099935bee81c81cd04()
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

      private sealed class MTHD_5ceb8eed6e0c4f359a439888e59e2708 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ceb8eed6e0c4f359a439888e59e2708()
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

      private sealed class MTHD_f898e597ac044d71b53371e9ac42d44e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f898e597ac044d71b53371e9ac42d44e()
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

      private sealed class MTHD_5c3346d96b504863853fd2bf3eb6df9b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c3346d96b504863853fd2bf3eb6df9b()
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

      private sealed class MTHD_7a056beb8cac4c9f8d27ae76aebf8195 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a056beb8cac4c9f8d27ae76aebf8195()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_d4bc13d7929b4500adcb6c6383fca462 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d4bc13d7929b4500adcb6c6383fca462()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_83b698f994784d46ab21f755d9d49225 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_83b698f994784d46ab21f755d9d49225()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_62ffdd229d174d23983a914dbb94a7bd : HardwiredMemberDescriptor
      {
        internal FLDV_62ffdd229d174d23983a914dbb94a7bd()
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

      private sealed class FLDV_2054f6c5d5d04dc3a2bd8d82bdbfbfe5 : HardwiredMemberDescriptor
      {
        internal FLDV_2054f6c5d5d04dc3a2bd8d82bdbfbfe5()
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

      private sealed class FLDV_3abb42da163b4bb096e3bf3df97d8727 : HardwiredMemberDescriptor
      {
        internal FLDV_3abb42da163b4bb096e3bf3df97d8727()
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

      private sealed class FLDV_c9f98babfc7e40d6966c8ee6dcd1f19b : HardwiredMemberDescriptor
      {
        internal FLDV_c9f98babfc7e40d6966c8ee6dcd1f19b()
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

      private sealed class FLDV_9a8a9e890b8d449c9b300da88d13d94c : HardwiredMemberDescriptor
      {
        internal FLDV_9a8a9e890b8d449c9b300da88d13d94c()
          : base(typeof (LuaColor), "white", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) LuaColor.white;
        }
      }
    }

    private sealed class TYPE_1c9689f2e0ce47cdbf4ad5c9658d5c10 : HardwiredUserDataDescriptor
    {
      internal TYPE_1c9689f2e0ce47cdbf4ad5c9658d5c10()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c9689f2e0ce47cdbf4ad5c9658d5c10.MTHD_e7fbee6ce0c54113bbafa4cde2b00ffe()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c9689f2e0ce47cdbf4ad5c9658d5c10.MTHD_fa34fc8fd6ae44bc9777b7d424c8bec1()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c9689f2e0ce47cdbf4ad5c9658d5c10.MTHD_8426fcb158a84ea6b1a014c4c1df9866()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c9689f2e0ce47cdbf4ad5c9658d5c10.MTHD_37cd02c7beae464aac29f48306eb0dfa()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c9689f2e0ce47cdbf4ad5c9658d5c10.MTHD_093f986c7d7b476f9ea0a29433edd76f()
        }));
      }

      private sealed class MTHD_e7fbee6ce0c54113bbafa4cde2b00ffe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7fbee6ce0c54113bbafa4cde2b00ffe()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_fa34fc8fd6ae44bc9777b7d424c8bec1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa34fc8fd6ae44bc9777b7d424c8bec1()
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

      private sealed class MTHD_8426fcb158a84ea6b1a014c4c1df9866 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8426fcb158a84ea6b1a014c4c1df9866()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_37cd02c7beae464aac29f48306eb0dfa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_37cd02c7beae464aac29f48306eb0dfa()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_093f986c7d7b476f9ea0a29433edd76f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_093f986c7d7b476f9ea0a29433edd76f()
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
