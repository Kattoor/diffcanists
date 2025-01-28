
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
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_872f17734e3347a8954d7b5e9304433c());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_246bebdbd0394e48a0e29866179a4b4d());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_9e8939f3a64a4960999873330f6e2f9a());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_dc24497884c1447d8ce910a835aa485a());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_1b503d38962e4b7e9ff29451f1a4e0fd());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_9f9c84e3708d4dff86bc4c835dcd9a3f());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_3db03bc69b8b447194880382f97fe946());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_6169071836e940ddbb227a48e1864bf4());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_81c4126b4d474b99a4c18a6012df0c8c());
    }

    private sealed class TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe : HardwiredUserDataDescriptor
    {
      internal TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_177c3e64e3164ee78a4bf3ce61b7bb01()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_95f4cf8cf81e46b69836c61ca187ed50()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_4ceb0120088842afb05f3d4853d4aaae()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_5c8d5c811a7949618f28903586cd3215()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_cfe0cce63e224c578b4818c6e7a09de2()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_bb0b09ecb9624737ab008520d1470700()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_bc30405f9efc4579b0359e6162e61c30()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_e55ba8492b014f3d9244e11bf48863b2()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_ea42e332e10340d5bf1bbe0f8c6fd0e8()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_f8cd48f3c1e4463a9c56d05ce0983aba()
        }));
        this.AddMember("hideInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("hideInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_a2ca2887ef564f8db15705b2a6b92491()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_74255469e2484887b9660d61fd23a571()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_4a0dca7bbb544f97a5181b1ae8eb0a7d()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_dd59aac84bb945949ee01b7567098d0a()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_1d0e72456f374ccc91ec7e9241bdb0bd()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_2a886e6dcdc640498dce186b46c623cd()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_0903ee1602e94fa59dfc7ded39982826()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_1b3ad323971840c9b00fca7d5e134d47()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_2c5d42a281a747abb40b84eeaf163081()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_8967c175d89c4c99bd90daa379835e76()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_67e4fd48dc3943b4b3cf69eed9ddb50d()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_05205dd2536a4b4d8dd0639ab05c231b()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_34970af9d40b4f5a900b2b5cd9c4c709()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_97550e9baedc48c291c3f2d72e094d29()
        }));
        this.AddMember("get_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_a10e12e235f348838f5c454277357a31()
        }));
        this.AddMember("set_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_bcc7084de522438fb2306938047d2e7f()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_ee05baacbf344c2a80f6b553c7cb88c3()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_e767012a9dcc469c80cdd90579fb5bb2()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_f0aec0ff9e6541ac84ab370c7e8e4c68()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_826bdb9acae144ebb042af50cf8a8dbe()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_f157c63e1eba4f5e8430f5c93d49dbef()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_a43489ce9a6a4d46b979533606f58bd6()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_0159e4a42c004429a4d1776b1206aeca()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_2621451e1ab34f0abb3abee715765fe8()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_ed4cc63a73124cfcb172b7e06adbcf3b()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_ccf731ef00604340b80ad87295470d78()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_de04139bbd23435fb26e9b48f1977cbc()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_ddb07a0fe7e64d05b606b2b8bc03adc0()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_f2976b9b52b24dcc9c967517bb375004()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_ef2c8f14d4b946f594ab5f166ab425c3()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_c9d6501fda064313b9ae200e823f2b26()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_b96e58e473db42e182dcbd9026628a7f()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_74cd3aa91ffe4549a7fe20853a822a8c()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_0ca662969d4041f0884b56f1fb832c4b()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_60669fea4679488ea5d77246f61ff8ce()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_410dee55fae644afa2b27e295cf0eeda()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_16c05517e96842ada0c4cb18083a6fab()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_69ef5e712bdc413a878b98103396e4c3()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_b59bb1c49f964a94b5b5d067cfe984e6()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_07e95b84c89e4dc591944e21cbf74341()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_cd932a1f43984f07b2ab2eb1173f55d2()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_fb4efad1acf94762996a53672fb995fa()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_a1339bfc84ca4080a4289ab0595ebbc1()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_0e0b7a875bbc49898ee422702b5b0026()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_d769cdd0db124fd9bc6fe376d133730a()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_2ba10b4fc8814cdd9e2baa32c08187c7()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_ae4824462832489ca17ba4306b371a92()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_9df88abd39254105a44e18f1b1336242()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_5b2f05802be946b9a648e6cee78c27f5()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_23e90ac5c1d64a64a2a91178c415a4b6()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_be80196d195049b4a5027168b97a3fd9()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_1be411067a044288ae4f454604443877()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_c0aed23b45d64a65b152a08c46b18a12()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_c95bc35acf8b440c8e6109eaa300fa2f()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_be149c438e69437f8c3eb123f0797d97()
        }));
        this.AddMember("Dispose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Dispose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_d6af70c18e684ba7a5a994fccd9e1981()
        }));
        this.AddMember("drawImage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawImage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_04573c38738c432e8302121dd6fdf2c7()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_f0cafc19cbc94b0c9fd6c1f4fe8f34cd()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_da7cac53ebbe4c74b114bc1aaf47619b()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_2d9a716452b147558f2f8259bc9c6aec()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_a504c785745f4d7787d74a7dd285c39f()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_9815d1b1f54a4187ac4744e2d932b6b2()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_10b4d7942ef04bcc957662b3970956a9()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_7625b88208ba436f812084b015934c89()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_eb010919331a486ba8c235ccac02567b()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_f4324be4490140079827bfa65fb43acc()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_15faf87c208b46c3a9543dab1874abaf()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_084c25867f6a4ee882f7fdd03bf9afcd()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_0a70d689756c4ccb91616cc5e0ba112d()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_0c8e38a1e8794f1fa5e0274e33f97c68()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_9017a9b7e0674eec9e5ae9e96d5d2a85()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_228d96bc1d8d4bc098dc7dab67549feb()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_6b16a6c1161546c48d5d176de89afd42()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_eaa4627f52ff4d5e955494161afc9755()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_4977f95d4ce742e29d349da1f007cb96()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_fd64be652e384a608e14fb9d72dcb259()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_f48b423823f64f149cc339310a0bb957()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_9cb737ef1a7a42188238187de3b75943()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_7283a859c121470f89d7776015948460()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_a4f236cc775741f5a42fdf263fe6f8bf()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_9ad09c15075042c3b69097b3f5e802d4()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_5cfc2e8e8dd140e2992f7200c87356db()
        }));
        this.AddMember("cameraFollow", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("cameraFollow", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_9c355c7951f24d6394b5f33c221a1b21()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_a1b8973f7def4781ad61b7db1f50d6e2()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_291536784ddf4b26b83d0cea96fb3623()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_74064858580440b883ffc5113a45c44f()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_85dff45ecb9942429888aaffbbed1f0f()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_9d28045dd18e40b8ae73faaa33d9b684()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_f67314191a884d6c986d909fc571c992(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_f1634c1d206d45aabdd16b33ecdc3554()
        }));
        this.AddMember("getKeyBinds", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getKeyBinds", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_7cb374d9ca7a4c7280b9d1e0113cd9dd()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_45ba117ac79748bbab20949ddaf478f8()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_6e133cc79d234004861583e59b397119()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_85f5605f6c774d3db13059c94ae271df()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.MTHD_425fb5c516f948f5b3f69893712bc356()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_b3052f1af7344170abfdd9c89067cd6c());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_e67ddbfb973c447696ed9cd0527c3f09());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_1d873f1321564c9aa29a19cbce62dd7a());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_43cf28cb055049cc9cc68e0eb5c00421());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_b514627b884d41f18dabfd37d6e90f9a());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_c960209f83764a828884d5ccdcccb319());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_0f7b6ce7c6eb415ab3c7fd214ca5c201());
        this.AddMember("allowMinionMovement", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_2f49ff0f3d4e4332a775b3be3346a01f());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_9581392cf50d4fec9d1bd41cd71dc8fe());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_4256e3e0aa2c41cbbc5ccd2571dffd9a());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_a68dcc86bc1943a7aaf141270a49e296());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_5974835744f144a393e2651acef24b1b());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_302f5eb6bda94851ae0dc23fa7807191());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_afcc644693f54318bd0fb8cc9b5547d8());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_0ed831604358448c92460202fc6fe539());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_27c858195a974a429980890952879cbf());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_c22a4969e9cb4b04a1ea0af3a3936298());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_86b0a887b83a4d72b9b6d7126a3b8070());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_836e0ac75d42442189fde3740ed04f79());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_e9c9ef4acc83454e8df315de1e32cae6());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_a8ece52416c940ec96f60dbcd69c5b37());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_c1c6f1127eb54d4f862e210829e43b2c());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_b73da8c181204ba092140cc4a6eabd38());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_f324a852b68a45d9ae1af4f8987ea13d());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_d56befc8bffd4d8c8a85c1cb555d290f());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_ef802f227f644c7ba8cf5aad1037b3be());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_eff6aba0477a4ea5b1acc078de988c7a());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_64c9fb7b690b4f27bf225e2777a3cb7e());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_034a1593bb1c4c47bb8333f4a3dbc9cd());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_7a9c6184c89b42d18cae0807a49b2f48());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_ca9e2f73f134472fa66dd66d23ab9722());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_ae79eabaa8844154bb9326f04b89f23d());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_0b0d7fd9bee247ffbc0eeb8870455bbe.PROP_f02a489211be46dfbafed988a48fba4b());
      }

      private sealed class MTHD_177c3e64e3164ee78a4bf3ce61b7bb01 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_177c3e64e3164ee78a4bf3ce61b7bb01()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_95f4cf8cf81e46b69836c61ca187ed50 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95f4cf8cf81e46b69836c61ca187ed50()
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

      private sealed class MTHD_4ceb0120088842afb05f3d4853d4aaae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ceb0120088842afb05f3d4853d4aaae()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_5c8d5c811a7949618f28903586cd3215 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c8d5c811a7949618f28903586cd3215()
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

      private sealed class MTHD_cfe0cce63e224c578b4818c6e7a09de2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cfe0cce63e224c578b4818c6e7a09de2()
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

      private sealed class MTHD_bb0b09ecb9624737ab008520d1470700 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb0b09ecb9624737ab008520d1470700()
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

      private sealed class MTHD_bc30405f9efc4579b0359e6162e61c30 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bc30405f9efc4579b0359e6162e61c30()
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

      private sealed class MTHD_e55ba8492b014f3d9244e11bf48863b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e55ba8492b014f3d9244e11bf48863b2()
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

      private sealed class MTHD_ea42e332e10340d5bf1bbe0f8c6fd0e8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea42e332e10340d5bf1bbe0f8c6fd0e8()
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

      private sealed class MTHD_f8cd48f3c1e4463a9c56d05ce0983aba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f8cd48f3c1e4463a9c56d05ce0983aba()
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

      private sealed class MTHD_a2ca2887ef564f8db15705b2a6b92491 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2ca2887ef564f8db15705b2a6b92491()
        {
          this.Initialize("hideInfo", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).hideInfo();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_74255469e2484887b9660d61fd23a571 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74255469e2484887b9660d61fd23a571()
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

      private sealed class MTHD_4a0dca7bbb544f97a5181b1ae8eb0a7d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a0dca7bbb544f97a5181b1ae8eb0a7d()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_dd59aac84bb945949ee01b7567098d0a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dd59aac84bb945949ee01b7567098d0a()
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

      private sealed class MTHD_1d0e72456f374ccc91ec7e9241bdb0bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d0e72456f374ccc91ec7e9241bdb0bd()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_2a886e6dcdc640498dce186b46c623cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a886e6dcdc640498dce186b46c623cd()
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

      private sealed class MTHD_0903ee1602e94fa59dfc7ded39982826 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0903ee1602e94fa59dfc7ded39982826()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_1b3ad323971840c9b00fca7d5e134d47 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1b3ad323971840c9b00fca7d5e134d47()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_2c5d42a281a747abb40b84eeaf163081 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c5d42a281a747abb40b84eeaf163081()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_8967c175d89c4c99bd90daa379835e76 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8967c175d89c4c99bd90daa379835e76()
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

      private sealed class MTHD_67e4fd48dc3943b4b3cf69eed9ddb50d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67e4fd48dc3943b4b3cf69eed9ddb50d()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_05205dd2536a4b4d8dd0639ab05c231b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_05205dd2536a4b4d8dd0639ab05c231b()
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

      private sealed class MTHD_34970af9d40b4f5a900b2b5cd9c4c709 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_34970af9d40b4f5a900b2b5cd9c4c709()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_97550e9baedc48c291c3f2d72e094d29 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97550e9baedc48c291c3f2d72e094d29()
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

      private sealed class MTHD_a10e12e235f348838f5c454277357a31 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a10e12e235f348838f5c454277357a31()
        {
          this.Initialize("get_allowMinionMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMinionMovement;
        }
      }

      private sealed class MTHD_bcc7084de522438fb2306938047d2e7f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bcc7084de522438fb2306938047d2e7f()
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

      private sealed class MTHD_ee05baacbf344c2a80f6b553c7cb88c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee05baacbf344c2a80f6b553c7cb88c3()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_e767012a9dcc469c80cdd90579fb5bb2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e767012a9dcc469c80cdd90579fb5bb2()
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

      private sealed class MTHD_f0aec0ff9e6541ac84ab370c7e8e4c68 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f0aec0ff9e6541ac84ab370c7e8e4c68()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_826bdb9acae144ebb042af50cf8a8dbe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_826bdb9acae144ebb042af50cf8a8dbe()
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

      private sealed class MTHD_f157c63e1eba4f5e8430f5c93d49dbef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f157c63e1eba4f5e8430f5c93d49dbef()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_a43489ce9a6a4d46b979533606f58bd6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a43489ce9a6a4d46b979533606f58bd6()
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

      private sealed class MTHD_0159e4a42c004429a4d1776b1206aeca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0159e4a42c004429a4d1776b1206aeca()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_2621451e1ab34f0abb3abee715765fe8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2621451e1ab34f0abb3abee715765fe8()
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

      private sealed class MTHD_ed4cc63a73124cfcb172b7e06adbcf3b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed4cc63a73124cfcb172b7e06adbcf3b()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_ccf731ef00604340b80ad87295470d78 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ccf731ef00604340b80ad87295470d78()
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

      private sealed class MTHD_de04139bbd23435fb26e9b48f1977cbc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de04139bbd23435fb26e9b48f1977cbc()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_ddb07a0fe7e64d05b606b2b8bc03adc0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ddb07a0fe7e64d05b606b2b8bc03adc0()
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

      private sealed class MTHD_f2976b9b52b24dcc9c967517bb375004 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f2976b9b52b24dcc9c967517bb375004()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_ef2c8f14d4b946f594ab5f166ab425c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef2c8f14d4b946f594ab5f166ab425c3()
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

      private sealed class MTHD_c9d6501fda064313b9ae200e823f2b26 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c9d6501fda064313b9ae200e823f2b26()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_b96e58e473db42e182dcbd9026628a7f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b96e58e473db42e182dcbd9026628a7f()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_74cd3aa91ffe4549a7fe20853a822a8c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74cd3aa91ffe4549a7fe20853a822a8c()
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

      private sealed class MTHD_0ca662969d4041f0884b56f1fb832c4b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ca662969d4041f0884b56f1fb832c4b()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_60669fea4679488ea5d77246f61ff8ce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60669fea4679488ea5d77246f61ff8ce()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_410dee55fae644afa2b27e295cf0eeda : HardwiredMethodMemberDescriptor
      {
        internal MTHD_410dee55fae644afa2b27e295cf0eeda()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_16c05517e96842ada0c4cb18083a6fab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_16c05517e96842ada0c4cb18083a6fab()
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

      private sealed class MTHD_69ef5e712bdc413a878b98103396e4c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69ef5e712bdc413a878b98103396e4c3()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_b59bb1c49f964a94b5b5d067cfe984e6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b59bb1c49f964a94b5b5d067cfe984e6()
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

      private sealed class MTHD_07e95b84c89e4dc591944e21cbf74341 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_07e95b84c89e4dc591944e21cbf74341()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_cd932a1f43984f07b2ab2eb1173f55d2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd932a1f43984f07b2ab2eb1173f55d2()
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

      private sealed class MTHD_fb4efad1acf94762996a53672fb995fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb4efad1acf94762996a53672fb995fa()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_a1339bfc84ca4080a4289ab0595ebbc1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1339bfc84ca4080a4289ab0595ebbc1()
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

      private sealed class MTHD_0e0b7a875bbc49898ee422702b5b0026 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e0b7a875bbc49898ee422702b5b0026()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_d769cdd0db124fd9bc6fe376d133730a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d769cdd0db124fd9bc6fe376d133730a()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_2ba10b4fc8814cdd9e2baa32c08187c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2ba10b4fc8814cdd9e2baa32c08187c7()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_ae4824462832489ca17ba4306b371a92 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae4824462832489ca17ba4306b371a92()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_9df88abd39254105a44e18f1b1336242 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9df88abd39254105a44e18f1b1336242()
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

      private sealed class MTHD_5b2f05802be946b9a648e6cee78c27f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b2f05802be946b9a648e6cee78c27f5()
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

      private sealed class MTHD_23e90ac5c1d64a64a2a91178c415a4b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_23e90ac5c1d64a64a2a91178c415a4b6()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_be80196d195049b4a5027168b97a3fd9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be80196d195049b4a5027168b97a3fd9()
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

      private sealed class MTHD_1be411067a044288ae4f454604443877 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1be411067a044288ae4f454604443877()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_c0aed23b45d64a65b152a08c46b18a12 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c0aed23b45d64a65b152a08c46b18a12()
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

      private sealed class MTHD_c95bc35acf8b440c8e6109eaa300fa2f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c95bc35acf8b440c8e6109eaa300fa2f()
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

      private sealed class MTHD_be149c438e69437f8c3eb123f0797d97 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be149c438e69437f8c3eb123f0797d97()
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

      private sealed class MTHD_d6af70c18e684ba7a5a994fccd9e1981 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6af70c18e684ba7a5a994fccd9e1981()
        {
          this.Initialize("Dispose", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ContainerGame.Dispose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_04573c38738c432e8302121dd6fdf2c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_04573c38738c432e8302121dd6fdf2c7()
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

      private sealed class MTHD_f0cafc19cbc94b0c9fd6c1f4fe8f34cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f0cafc19cbc94b0c9fd6c1f4fe8f34cd()
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

      private sealed class MTHD_da7cac53ebbe4c74b114bc1aaf47619b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_da7cac53ebbe4c74b114bc1aaf47619b()
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

      private sealed class MTHD_2d9a716452b147558f2f8259bc9c6aec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d9a716452b147558f2f8259bc9c6aec()
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

      private sealed class MTHD_a504c785745f4d7787d74a7dd285c39f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a504c785745f4d7787d74a7dd285c39f()
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

      private sealed class MTHD_9815d1b1f54a4187ac4744e2d932b6b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9815d1b1f54a4187ac4744e2d932b6b2()
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

      private sealed class MTHD_10b4d7942ef04bcc957662b3970956a9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_10b4d7942ef04bcc957662b3970956a9()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_7625b88208ba436f812084b015934c89 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7625b88208ba436f812084b015934c89()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_eb010919331a486ba8c235ccac02567b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb010919331a486ba8c235ccac02567b()
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

      private sealed class MTHD_f4324be4490140079827bfa65fb43acc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4324be4490140079827bfa65fb43acc()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_15faf87c208b46c3a9543dab1874abaf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15faf87c208b46c3a9543dab1874abaf()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_084c25867f6a4ee882f7fdd03bf9afcd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_084c25867f6a4ee882f7fdd03bf9afcd()
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

      private sealed class MTHD_0a70d689756c4ccb91616cc5e0ba112d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0a70d689756c4ccb91616cc5e0ba112d()
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

      private sealed class MTHD_0c8e38a1e8794f1fa5e0274e33f97c68 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c8e38a1e8794f1fa5e0274e33f97c68()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9017a9b7e0674eec9e5ae9e96d5d2a85 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9017a9b7e0674eec9e5ae9e96d5d2a85()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_228d96bc1d8d4bc098dc7dab67549feb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_228d96bc1d8d4bc098dc7dab67549feb()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_6b16a6c1161546c48d5d176de89afd42 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b16a6c1161546c48d5d176de89afd42()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_eaa4627f52ff4d5e955494161afc9755 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eaa4627f52ff4d5e955494161afc9755()
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

      private sealed class MTHD_4977f95d4ce742e29d349da1f007cb96 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4977f95d4ce742e29d349da1f007cb96()
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

      private sealed class MTHD_fd64be652e384a608e14fb9d72dcb259 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd64be652e384a608e14fb9d72dcb259()
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

      private sealed class MTHD_f48b423823f64f149cc339310a0bb957 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f48b423823f64f149cc339310a0bb957()
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

      private sealed class MTHD_9cb737ef1a7a42188238187de3b75943 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9cb737ef1a7a42188238187de3b75943()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_7283a859c121470f89d7776015948460 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7283a859c121470f89d7776015948460()
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

      private sealed class MTHD_a4f236cc775741f5a42fdf263fe6f8bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a4f236cc775741f5a42fdf263fe6f8bf()
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

      private sealed class MTHD_9ad09c15075042c3b69097b3f5e802d4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ad09c15075042c3b69097b3f5e802d4()
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

      private sealed class MTHD_5cfc2e8e8dd140e2992f7200c87356db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5cfc2e8e8dd140e2992f7200c87356db()
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

      private sealed class MTHD_9c355c7951f24d6394b5f33c221a1b21 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c355c7951f24d6394b5f33c221a1b21()
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

      private sealed class MTHD_a1b8973f7def4781ad61b7db1f50d6e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1b8973f7def4781ad61b7db1f50d6e2()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_291536784ddf4b26b83d0cea96fb3623 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_291536784ddf4b26b83d0cea96fb3623()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_74064858580440b883ffc5113a45c44f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74064858580440b883ffc5113a45c44f()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_85dff45ecb9942429888aaffbbed1f0f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85dff45ecb9942429888aaffbbed1f0f()
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

      private sealed class MTHD_9d28045dd18e40b8ae73faaa33d9b684 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d28045dd18e40b8ae73faaa33d9b684()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f67314191a884d6c986d909fc571c992 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f67314191a884d6c986d909fc571c992()
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

      private sealed class MTHD_f1634c1d206d45aabdd16b33ecdc3554 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f1634c1d206d45aabdd16b33ecdc3554()
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

      private sealed class MTHD_7cb374d9ca7a4c7280b9d1e0113cd9dd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7cb374d9ca7a4c7280b9d1e0113cd9dd()
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

      private sealed class MTHD_45ba117ac79748bbab20949ddaf478f8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_45ba117ac79748bbab20949ddaf478f8()
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

      private sealed class MTHD_6e133cc79d234004861583e59b397119 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e133cc79d234004861583e59b397119()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_85f5605f6c774d3db13059c94ae271df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85f5605f6c774d3db13059c94ae271df()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_425fb5c516f948f5b3f69893712bc356 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_425fb5c516f948f5b3f69893712bc356()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_b3052f1af7344170abfdd9c89067cd6c : HardwiredMemberDescriptor
      {
        internal PROP_b3052f1af7344170abfdd9c89067cd6c()
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

      private sealed class PROP_e67ddbfb973c447696ed9cd0527c3f09 : HardwiredMemberDescriptor
      {
        internal PROP_e67ddbfb973c447696ed9cd0527c3f09()
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

      private sealed class PROP_1d873f1321564c9aa29a19cbce62dd7a : HardwiredMemberDescriptor
      {
        internal PROP_1d873f1321564c9aa29a19cbce62dd7a()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_43cf28cb055049cc9cc68e0eb5c00421 : HardwiredMemberDescriptor
      {
        internal PROP_43cf28cb055049cc9cc68e0eb5c00421()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_b514627b884d41f18dabfd37d6e90f9a : HardwiredMemberDescriptor
      {
        internal PROP_b514627b884d41f18dabfd37d6e90f9a()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_c960209f83764a828884d5ccdcccb319 : HardwiredMemberDescriptor
      {
        internal PROP_c960209f83764a828884d5ccdcccb319()
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

      private sealed class PROP_0f7b6ce7c6eb415ab3c7fd214ca5c201 : HardwiredMemberDescriptor
      {
        internal PROP_0f7b6ce7c6eb415ab3c7fd214ca5c201()
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

      private sealed class PROP_2f49ff0f3d4e4332a775b3be3346a01f : HardwiredMemberDescriptor
      {
        internal PROP_2f49ff0f3d4e4332a775b3be3346a01f()
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

      private sealed class PROP_9581392cf50d4fec9d1bd41cd71dc8fe : HardwiredMemberDescriptor
      {
        internal PROP_9581392cf50d4fec9d1bd41cd71dc8fe()
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

      private sealed class PROP_4256e3e0aa2c41cbbc5ccd2571dffd9a : HardwiredMemberDescriptor
      {
        internal PROP_4256e3e0aa2c41cbbc5ccd2571dffd9a()
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

      private sealed class PROP_a68dcc86bc1943a7aaf141270a49e296 : HardwiredMemberDescriptor
      {
        internal PROP_a68dcc86bc1943a7aaf141270a49e296()
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

      private sealed class PROP_5974835744f144a393e2651acef24b1b : HardwiredMemberDescriptor
      {
        internal PROP_5974835744f144a393e2651acef24b1b()
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

      private sealed class PROP_302f5eb6bda94851ae0dc23fa7807191 : HardwiredMemberDescriptor
      {
        internal PROP_302f5eb6bda94851ae0dc23fa7807191()
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

      private sealed class PROP_afcc644693f54318bd0fb8cc9b5547d8 : HardwiredMemberDescriptor
      {
        internal PROP_afcc644693f54318bd0fb8cc9b5547d8()
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

      private sealed class PROP_0ed831604358448c92460202fc6fe539 : HardwiredMemberDescriptor
      {
        internal PROP_0ed831604358448c92460202fc6fe539()
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

      private sealed class PROP_27c858195a974a429980890952879cbf : HardwiredMemberDescriptor
      {
        internal PROP_27c858195a974a429980890952879cbf()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_c22a4969e9cb4b04a1ea0af3a3936298 : HardwiredMemberDescriptor
      {
        internal PROP_c22a4969e9cb4b04a1ea0af3a3936298()
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

      private sealed class PROP_86b0a887b83a4d72b9b6d7126a3b8070 : HardwiredMemberDescriptor
      {
        internal PROP_86b0a887b83a4d72b9b6d7126a3b8070()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_836e0ac75d42442189fde3740ed04f79 : HardwiredMemberDescriptor
      {
        internal PROP_836e0ac75d42442189fde3740ed04f79()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_e9c9ef4acc83454e8df315de1e32cae6 : HardwiredMemberDescriptor
      {
        internal PROP_e9c9ef4acc83454e8df315de1e32cae6()
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

      private sealed class PROP_a8ece52416c940ec96f60dbcd69c5b37 : HardwiredMemberDescriptor
      {
        internal PROP_a8ece52416c940ec96f60dbcd69c5b37()
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

      private sealed class PROP_c1c6f1127eb54d4f862e210829e43b2c : HardwiredMemberDescriptor
      {
        internal PROP_c1c6f1127eb54d4f862e210829e43b2c()
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

      private sealed class PROP_b73da8c181204ba092140cc4a6eabd38 : HardwiredMemberDescriptor
      {
        internal PROP_b73da8c181204ba092140cc4a6eabd38()
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

      private sealed class PROP_f324a852b68a45d9ae1af4f8987ea13d : HardwiredMemberDescriptor
      {
        internal PROP_f324a852b68a45d9ae1af4f8987ea13d()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_d56befc8bffd4d8c8a85c1cb555d290f : HardwiredMemberDescriptor
      {
        internal PROP_d56befc8bffd4d8c8a85c1cb555d290f()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_ef802f227f644c7ba8cf5aad1037b3be : HardwiredMemberDescriptor
      {
        internal PROP_ef802f227f644c7ba8cf5aad1037b3be()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_eff6aba0477a4ea5b1acc078de988c7a : HardwiredMemberDescriptor
      {
        internal PROP_eff6aba0477a4ea5b1acc078de988c7a()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_64c9fb7b690b4f27bf225e2777a3cb7e : HardwiredMemberDescriptor
      {
        internal PROP_64c9fb7b690b4f27bf225e2777a3cb7e()
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

      private sealed class PROP_034a1593bb1c4c47bb8333f4a3dbc9cd : HardwiredMemberDescriptor
      {
        internal PROP_034a1593bb1c4c47bb8333f4a3dbc9cd()
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

      private sealed class PROP_7a9c6184c89b42d18cae0807a49b2f48 : HardwiredMemberDescriptor
      {
        internal PROP_7a9c6184c89b42d18cae0807a49b2f48()
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

      private sealed class PROP_ca9e2f73f134472fa66dd66d23ab9722 : HardwiredMemberDescriptor
      {
        internal PROP_ca9e2f73f134472fa66dd66d23ab9722()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_ae79eabaa8844154bb9326f04b89f23d : HardwiredMemberDescriptor
      {
        internal PROP_ae79eabaa8844154bb9326f04b89f23d()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_f02a489211be46dfbafed988a48fba4b : HardwiredMemberDescriptor
      {
        internal PROP_f02a489211be46dfbafed988a48fba4b()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_872f17734e3347a8954d7b5e9304433c : HardwiredUserDataDescriptor
    {
      internal TYPE_872f17734e3347a8954d7b5e9304433c()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_872f17734e3347a8954d7b5e9304433c.MTHD_d7532f11736c415c9417865c09a17931()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_872f17734e3347a8954d7b5e9304433c.MTHD_8eac58765c4748c0b8e6f8d03d600e06()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_872f17734e3347a8954d7b5e9304433c.MTHD_22e0ed7391114e57b637a41a067247c9()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_872f17734e3347a8954d7b5e9304433c.MTHD_d5da35ee284548e68414c18aed865732()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_872f17734e3347a8954d7b5e9304433c.MTHD_4898a0a602e14eeca8a4e3f94fa40d58()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_872f17734e3347a8954d7b5e9304433c.MTHD_2580ce5fa90c49d0876d6443dcb33612()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_872f17734e3347a8954d7b5e9304433c.MTHD_a891bed327334a588fda456adaeae10b()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_872f17734e3347a8954d7b5e9304433c.MTHD_0a47cd61dfb74e9badf75b09e841ece8()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_872f17734e3347a8954d7b5e9304433c.MTHD_f302d0a432594c6ab2c7307090c5fcf9()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_872f17734e3347a8954d7b5e9304433c.MTHD_469b85e4e93a40a699e4409061251d29()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_872f17734e3347a8954d7b5e9304433c.MTHD_327184207bab402b8fa5d449fdda081d()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_872f17734e3347a8954d7b5e9304433c.MTHD_dacb06ee255c4d0893f76a3a8dec73fc()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_872f17734e3347a8954d7b5e9304433c.PROP_ac6f9b4f8a5a492da1709321396596aa());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_872f17734e3347a8954d7b5e9304433c.PROP_5de91e9faf7d4e3ead7387006b1e4910());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_872f17734e3347a8954d7b5e9304433c.PROP_7da989f5179d436fbd4ce3a6d697febd());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_872f17734e3347a8954d7b5e9304433c.PROP_eb7d91874eae46e4bfbc1261ba60689d());
      }

      private sealed class MTHD_d7532f11736c415c9417865c09a17931 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d7532f11736c415c9417865c09a17931()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_8eac58765c4748c0b8e6f8d03d600e06 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8eac58765c4748c0b8e6f8d03d600e06()
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

      private sealed class MTHD_22e0ed7391114e57b637a41a067247c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22e0ed7391114e57b637a41a067247c9()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_d5da35ee284548e68414c18aed865732 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d5da35ee284548e68414c18aed865732()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_4898a0a602e14eeca8a4e3f94fa40d58 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4898a0a602e14eeca8a4e3f94fa40d58()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_2580ce5fa90c49d0876d6443dcb33612 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2580ce5fa90c49d0876d6443dcb33612()
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

      private sealed class MTHD_a891bed327334a588fda456adaeae10b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a891bed327334a588fda456adaeae10b()
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

      private sealed class MTHD_0a47cd61dfb74e9badf75b09e841ece8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0a47cd61dfb74e9badf75b09e841ece8()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_f302d0a432594c6ab2c7307090c5fcf9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f302d0a432594c6ab2c7307090c5fcf9()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_469b85e4e93a40a699e4409061251d29 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_469b85e4e93a40a699e4409061251d29()
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

      private sealed class MTHD_327184207bab402b8fa5d449fdda081d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_327184207bab402b8fa5d449fdda081d()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_dacb06ee255c4d0893f76a3a8dec73fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dacb06ee255c4d0893f76a3a8dec73fc()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_ac6f9b4f8a5a492da1709321396596aa : HardwiredMemberDescriptor
      {
        internal PROP_ac6f9b4f8a5a492da1709321396596aa()
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

      private sealed class PROP_5de91e9faf7d4e3ead7387006b1e4910 : HardwiredMemberDescriptor
      {
        internal PROP_5de91e9faf7d4e3ead7387006b1e4910()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_7da989f5179d436fbd4ce3a6d697febd : HardwiredMemberDescriptor
      {
        internal PROP_7da989f5179d436fbd4ce3a6d697febd()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_eb7d91874eae46e4bfbc1261ba60689d : HardwiredMemberDescriptor
      {
        internal PROP_eb7d91874eae46e4bfbc1261ba60689d()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_30c2b5af896941aca3e82e18eb4e51c8 : HardwiredUserDataDescriptor
    {
      internal TYPE_30c2b5af896941aca3e82e18eb4e51c8()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_aff0a86949134a97a0be5ca48088c366()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_83dfd175651545b892e40e003021b15f()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_3e6f8847768042d19eca77310b68a8e7()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_3a0a0ff9cf814460a8598cccf85d6c23()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_329f3d161d924ba7976cc3d9108c2692()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_412c82a519f0404689da98e17b22d384()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_bb300232dd934c829cc8273ca4f5c767()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_2358bbe4969547e9a29bc9790d752574()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_85bbee298ebe48b4bd8ba6d3a829aece()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_a0d3a98c62df4772b931bcaead8ccb27()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_488f711d9e2545428734cb1866582713()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_a2d8a50cf43b43ee81904f7260628414()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_f540ac5b734f4218a133db11740bdbcc()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_9ba19fba904048e68b54eaf30290d5c4()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_3ae7e8969e2b4b5a9e51ff6128525348()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_f061a67bde624e248782fc8307801890()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_49884fb66e464779afdb605a7a19d064()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_1dd5a28cd3e444b38152dcfa7839438a()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_a8d9cdc809404314bfea1d9e39b1e095()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_57e59163a80d4764856d2142be8b2e40()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_2a2b08c675ae4645ba25d68579d0eadc()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_bd17628fb84c451595759b9914784281()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_9b4ca56f7d1240af87905890d9bc068e()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_b4606fdb1dd64b5eb2d771caa73e99d4()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_da46d2e428924005969343140c596a56()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_fc51454f31fe43f185c260e8ae7aea9b()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_0ff3b885b70d4ef1b1f3e3800ee12f13()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_6c998b9c5ebd4742ae43e35cbe3e1434()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_aba1e145076e4913af059505e843e8a6()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_158344e1aa05481a96876c2812769c86()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_57d6f70278e841f6b851a8723b8eba7e()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_8a2888ce57584fa486cf4c58e4c1a3e5()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_9aa144efea204e1ba3416d18e153870e()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_b3bc0cd5d6a8417ab0ce40553ea083f3()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_4438a128adf540af9233be107dcf1931()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_65e502e524d44147b082c9d9e114fa5d()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_40e9b938c7084555ade079269affca7b()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_3b99176bf2b94514ae53ff28ba5cfa9a()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_c93da0d73564455489defcff616e2ebc()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_4d4c4844f068470ab428b2b14c73eaa5()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_a18956f4bbb74aeaa3924892ee90f878()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_1545d7230cef4629bdd0a63d32f33faf()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_0d2bfcdb66304cf5b57aeb2681324f07()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_9a667ae2dd4146a8827b3ac9f614cda7()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_244248a632004d8e99464985191a4f66()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_d2debb9ef65b4061bc522ef0780d3fff()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_90fe51b4211b43b49eeb64e35206fcdb()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_f39d5818a4ab4ccb80a2c8b7be2efec0()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_f78a6bc2fa3643f6b01ed51d36ee5dc8()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_65341af7a0c041b4afd870967d890c65()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_16525994c1cc4d6c88b08f1c82bd3c9e()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_a0b9f03e8e1a4bd8b400994651409a8a()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_31d1664ce8104307837e85d0edd25daa()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_cc29316ff1cf4de3b195eadf56267fea()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_474530ceb5ec48779c16938fb0cb25d1()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_0edb9d89540e42d6881571ce91b2d3d7()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_09f4eb0965dc4aca8096a8aa5c0c6fda()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_26ed347c27cc4d5ba9e2a685d577b69b()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_8df3c01f05e84125842c175e38d729ca()
        }));
        this.AddMember("getDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_df48b8db28114583ab93cb60f6f1c4f7()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_f5d1a6048e50483aa74d95b4d0180441()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_b08a98cd2a9441eba143917a4dc2cb3a()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_e5101455717b42069c65985c336cec53()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_3271a337ed9d4cf883a3fc9e52be06e2()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_f7c159f139af4ecc94c8be19af8e4c74(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_680c920b413940848a2f753ca057176f()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_b71ac20332064f8f87f535660126231b(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_2458736190574374ac84cd62b14db720()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_2003efe0bb96477c84769d282bb41310()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_8e854f3f2b474e5592823e2cccd4671e()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_d8189f9d78074d06b5f262a3b435168f(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_ff559defa3374d6492caa44b11054af0()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_31d436e6df584a72a332f63704e61c41()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_63cab9e554be467785f096b0868193bd()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_6b72421e0a364e23ab5b40e73525ef54()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_060e229787254dfd8e8a5df353147001()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_3025799d59974e739166c72fe51e3a25()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_7af5f5719646447d892a31dd5e2f8b7e()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_5c7b0e27662744949a77b38af18a424a()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_0d77e310f13546bf839cf0731097f4ad()
        }));
        this.AddMember("angleToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("angleToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_006067124b8c43329ba49a9895f9ccb6()
        }));
        this.AddMember("powerToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("powerToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_e38fe67374ce4b5197bf8d696dad9a05()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_e78a89aba7604fd39665d5ec2b50aab0(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_1aa0239d3db2498784014cc702a95415()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_3ff4f025cd1b4f31b881eccdc00214e0(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_84ad15e1c2d743c5967c07fba2083338()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_a7da98ab044c424eabf89d6355cb442e()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_fee2bf98540c46c8974462947c36bb9d()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_ee769e271d23415a8a04f365fcd6a1e9()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_52a2347633d642d7a51522ece896fd7c()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_092d2b7284f3437397516beec34b0244()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.MTHD_9d8c6e4edbdf48e0932489608d0c15ee()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_f54111a472af46a29b852d1f68b606b9());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_663f7486b76c485d9842c16e38540756());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_84988f9238fd423aa208135602bbe428());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_ad3df5c379e941ca96cd86b354ad6034());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_81c0a2419e654de593bc77d011a9096f());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_94a6651f48d84877a65ab6a7eb820495());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_b0655cfdfcca4f07bfad1e0a1be06a88());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_35f06724660145798d840a51888f8e40());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_14b7b05b2a424de991c41fcf4e13c1af());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_4db4f141fc2745bfb0ecaf8be6d730dc());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_0ca9049825ac4b83b30ba78081fb6162());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_7ce6558068a74264b0a94ae1ceb9866e());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_37e100f6fc8f4c1fb1bbd199b15754ed());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_9b40b17a329240bb8b04a024d2853311());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_ddc7a2913f43414380cefd4d6b8bc3d0());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_e8bde69e3e72400cab9cc97fade3cad5());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_bc33399679c549dc87a0516aa6ed5771());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_f986579eb95448a6b78fd2ac92e622ef());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_12a149a3c10a4dc8a46d7f9b79e98af6());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_ad9eabc9ad5b47a5beee3c200c5e6154());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_84c62dc5dab649a18e6b729a09857560());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_ba7324e96c2846a5af560506e0f07f51());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_2ea274ab061c4a06a6b9f6e234029667());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_1049e59f5e7043ec9a608e76ab6516e3());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_439871fbb6694f3db3adbc048fbbd89c());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_ce51e50ac3ff43b5a32c20c543930ab1());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_84b03080509d4cabaa3e7f34c834749c());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_43d7f6c70fde471b89c12e5dec195c8c());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_929636aa6841447e8c99232d008f629f());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_1b4f2bfc42da4acca383d367c2a8187d());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_6a8c23a3c497452aaaa1ecd44d213759());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_e71346b9ac974563a989a6b986403965());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_30c2b5af896941aca3e82e18eb4e51c8.PROP_c8c81e804f7a43fc978aa1d788f2dcac());
      }

      private sealed class MTHD_aff0a86949134a97a0be5ca48088c366 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aff0a86949134a97a0be5ca48088c366()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_83dfd175651545b892e40e003021b15f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_83dfd175651545b892e40e003021b15f()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_3e6f8847768042d19eca77310b68a8e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e6f8847768042d19eca77310b68a8e7()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_3a0a0ff9cf814460a8598cccf85d6c23 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3a0a0ff9cf814460a8598cccf85d6c23()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_329f3d161d924ba7976cc3d9108c2692 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_329f3d161d924ba7976cc3d9108c2692()
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

      private sealed class MTHD_412c82a519f0404689da98e17b22d384 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_412c82a519f0404689da98e17b22d384()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_bb300232dd934c829cc8273ca4f5c767 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb300232dd934c829cc8273ca4f5c767()
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

      private sealed class MTHD_2358bbe4969547e9a29bc9790d752574 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2358bbe4969547e9a29bc9790d752574()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_85bbee298ebe48b4bd8ba6d3a829aece : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85bbee298ebe48b4bd8ba6d3a829aece()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_a0d3a98c62df4772b931bcaead8ccb27 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a0d3a98c62df4772b931bcaead8ccb27()
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

      private sealed class MTHD_488f711d9e2545428734cb1866582713 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_488f711d9e2545428734cb1866582713()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_a2d8a50cf43b43ee81904f7260628414 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2d8a50cf43b43ee81904f7260628414()
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

      private sealed class MTHD_f540ac5b734f4218a133db11740bdbcc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f540ac5b734f4218a133db11740bdbcc()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_9ba19fba904048e68b54eaf30290d5c4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ba19fba904048e68b54eaf30290d5c4()
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

      private sealed class MTHD_3ae7e8969e2b4b5a9e51ff6128525348 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3ae7e8969e2b4b5a9e51ff6128525348()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_f061a67bde624e248782fc8307801890 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f061a67bde624e248782fc8307801890()
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

      private sealed class MTHD_49884fb66e464779afdb605a7a19d064 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49884fb66e464779afdb605a7a19d064()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_1dd5a28cd3e444b38152dcfa7839438a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1dd5a28cd3e444b38152dcfa7839438a()
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

      private sealed class MTHD_a8d9cdc809404314bfea1d9e39b1e095 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a8d9cdc809404314bfea1d9e39b1e095()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_57e59163a80d4764856d2142be8b2e40 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57e59163a80d4764856d2142be8b2e40()
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

      private sealed class MTHD_2a2b08c675ae4645ba25d68579d0eadc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a2b08c675ae4645ba25d68579d0eadc()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_bd17628fb84c451595759b9914784281 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd17628fb84c451595759b9914784281()
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

      private sealed class MTHD_9b4ca56f7d1240af87905890d9bc068e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b4ca56f7d1240af87905890d9bc068e()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_b4606fdb1dd64b5eb2d771caa73e99d4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b4606fdb1dd64b5eb2d771caa73e99d4()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_da46d2e428924005969343140c596a56 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_da46d2e428924005969343140c596a56()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_fc51454f31fe43f185c260e8ae7aea9b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fc51454f31fe43f185c260e8ae7aea9b()
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

      private sealed class MTHD_0ff3b885b70d4ef1b1f3e3800ee12f13 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ff3b885b70d4ef1b1f3e3800ee12f13()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_6c998b9c5ebd4742ae43e35cbe3e1434 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6c998b9c5ebd4742ae43e35cbe3e1434()
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

      private sealed class MTHD_aba1e145076e4913af059505e843e8a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aba1e145076e4913af059505e843e8a6()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_158344e1aa05481a96876c2812769c86 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_158344e1aa05481a96876c2812769c86()
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

      private sealed class MTHD_57d6f70278e841f6b851a8723b8eba7e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57d6f70278e841f6b851a8723b8eba7e()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_8a2888ce57584fa486cf4c58e4c1a3e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a2888ce57584fa486cf4c58e4c1a3e5()
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

      private sealed class MTHD_9aa144efea204e1ba3416d18e153870e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9aa144efea204e1ba3416d18e153870e()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_b3bc0cd5d6a8417ab0ce40553ea083f3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b3bc0cd5d6a8417ab0ce40553ea083f3()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_4438a128adf540af9233be107dcf1931 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4438a128adf540af9233be107dcf1931()
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

      private sealed class MTHD_65e502e524d44147b082c9d9e114fa5d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65e502e524d44147b082c9d9e114fa5d()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_40e9b938c7084555ade079269affca7b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_40e9b938c7084555ade079269affca7b()
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

      private sealed class MTHD_3b99176bf2b94514ae53ff28ba5cfa9a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3b99176bf2b94514ae53ff28ba5cfa9a()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_c93da0d73564455489defcff616e2ebc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c93da0d73564455489defcff616e2ebc()
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

      private sealed class MTHD_4d4c4844f068470ab428b2b14c73eaa5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d4c4844f068470ab428b2b14c73eaa5()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_a18956f4bbb74aeaa3924892ee90f878 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a18956f4bbb74aeaa3924892ee90f878()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_1545d7230cef4629bdd0a63d32f33faf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1545d7230cef4629bdd0a63d32f33faf()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_0d2bfcdb66304cf5b57aeb2681324f07 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d2bfcdb66304cf5b57aeb2681324f07()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_9a667ae2dd4146a8827b3ac9f614cda7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9a667ae2dd4146a8827b3ac9f614cda7()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_244248a632004d8e99464985191a4f66 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_244248a632004d8e99464985191a4f66()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_d2debb9ef65b4061bc522ef0780d3fff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d2debb9ef65b4061bc522ef0780d3fff()
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

      private sealed class MTHD_90fe51b4211b43b49eeb64e35206fcdb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90fe51b4211b43b49eeb64e35206fcdb()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_f39d5818a4ab4ccb80a2c8b7be2efec0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f39d5818a4ab4ccb80a2c8b7be2efec0()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_f78a6bc2fa3643f6b01ed51d36ee5dc8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f78a6bc2fa3643f6b01ed51d36ee5dc8()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_65341af7a0c041b4afd870967d890c65 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65341af7a0c041b4afd870967d890c65()
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

      private sealed class MTHD_16525994c1cc4d6c88b08f1c82bd3c9e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_16525994c1cc4d6c88b08f1c82bd3c9e()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_a0b9f03e8e1a4bd8b400994651409a8a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a0b9f03e8e1a4bd8b400994651409a8a()
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

      private sealed class MTHD_31d1664ce8104307837e85d0edd25daa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_31d1664ce8104307837e85d0edd25daa()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_cc29316ff1cf4de3b195eadf56267fea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cc29316ff1cf4de3b195eadf56267fea()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_474530ceb5ec48779c16938fb0cb25d1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_474530ceb5ec48779c16938fb0cb25d1()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_0edb9d89540e42d6881571ce91b2d3d7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0edb9d89540e42d6881571ce91b2d3d7()
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

      private sealed class MTHD_09f4eb0965dc4aca8096a8aa5c0c6fda : HardwiredMethodMemberDescriptor
      {
        internal MTHD_09f4eb0965dc4aca8096a8aa5c0c6fda()
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

      private sealed class MTHD_26ed347c27cc4d5ba9e2a685d577b69b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_26ed347c27cc4d5ba9e2a685d577b69b()
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

      private sealed class MTHD_8df3c01f05e84125842c175e38d729ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8df3c01f05e84125842c175e38d729ca()
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

      private sealed class MTHD_df48b8db28114583ab93cb60f6f1c4f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_df48b8db28114583ab93cb60f6f1c4f7()
        {
          this.Initialize("getDirection", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getDirection();
        }
      }

      private sealed class MTHD_f5d1a6048e50483aa74d95b4d0180441 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f5d1a6048e50483aa74d95b4d0180441()
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

      private sealed class MTHD_b08a98cd2a9441eba143917a4dc2cb3a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b08a98cd2a9441eba143917a4dc2cb3a()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_e5101455717b42069c65985c336cec53 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e5101455717b42069c65985c336cec53()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_3271a337ed9d4cf883a3fc9e52be06e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3271a337ed9d4cf883a3fc9e52be06e2()
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

      private sealed class MTHD_f7c159f139af4ecc94c8be19af8e4c74 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7c159f139af4ecc94c8be19af8e4c74()
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

      private sealed class MTHD_680c920b413940848a2f753ca057176f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_680c920b413940848a2f753ca057176f()
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

      private sealed class MTHD_b71ac20332064f8f87f535660126231b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b71ac20332064f8f87f535660126231b()
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

      private sealed class MTHD_2458736190574374ac84cd62b14db720 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2458736190574374ac84cd62b14db720()
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

      private sealed class MTHD_2003efe0bb96477c84769d282bb41310 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2003efe0bb96477c84769d282bb41310()
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

      private sealed class MTHD_8e854f3f2b474e5592823e2cccd4671e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e854f3f2b474e5592823e2cccd4671e()
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

      private sealed class MTHD_d8189f9d78074d06b5f262a3b435168f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8189f9d78074d06b5f262a3b435168f()
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

      private sealed class MTHD_ff559defa3374d6492caa44b11054af0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff559defa3374d6492caa44b11054af0()
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

      private sealed class MTHD_31d436e6df584a72a332f63704e61c41 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_31d436e6df584a72a332f63704e61c41()
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

      private sealed class MTHD_63cab9e554be467785f096b0868193bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_63cab9e554be467785f096b0868193bd()
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

      private sealed class MTHD_6b72421e0a364e23ab5b40e73525ef54 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b72421e0a364e23ab5b40e73525ef54()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_060e229787254dfd8e8a5df353147001 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_060e229787254dfd8e8a5df353147001()
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

      private sealed class MTHD_3025799d59974e739166c72fe51e3a25 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3025799d59974e739166c72fe51e3a25()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_7af5f5719646447d892a31dd5e2f8b7e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7af5f5719646447d892a31dd5e2f8b7e()
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

      private sealed class MTHD_5c7b0e27662744949a77b38af18a424a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c7b0e27662744949a77b38af18a424a()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_0d77e310f13546bf839cf0731097f4ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d77e310f13546bf839cf0731097f4ad()
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

      private sealed class MTHD_006067124b8c43329ba49a9895f9ccb6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_006067124b8c43329ba49a9895f9ccb6()
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

      private sealed class MTHD_e38fe67374ce4b5197bf8d696dad9a05 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e38fe67374ce4b5197bf8d696dad9a05()
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

      private sealed class MTHD_e78a89aba7604fd39665d5ec2b50aab0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e78a89aba7604fd39665d5ec2b50aab0()
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

      private sealed class MTHD_1aa0239d3db2498784014cc702a95415 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1aa0239d3db2498784014cc702a95415()
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

      private sealed class MTHD_3ff4f025cd1b4f31b881eccdc00214e0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3ff4f025cd1b4f31b881eccdc00214e0()
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

      private sealed class MTHD_84ad15e1c2d743c5967c07fba2083338 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84ad15e1c2d743c5967c07fba2083338()
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

      private sealed class MTHD_a7da98ab044c424eabf89d6355cb442e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a7da98ab044c424eabf89d6355cb442e()
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

      private sealed class MTHD_fee2bf98540c46c8974462947c36bb9d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fee2bf98540c46c8974462947c36bb9d()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_ee769e271d23415a8a04f365fcd6a1e9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee769e271d23415a8a04f365fcd6a1e9()
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

      private sealed class MTHD_52a2347633d642d7a51522ece896fd7c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52a2347633d642d7a51522ece896fd7c()
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

      private sealed class MTHD_092d2b7284f3437397516beec34b0244 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_092d2b7284f3437397516beec34b0244()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_9d8c6e4edbdf48e0932489608d0c15ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d8c6e4edbdf48e0932489608d0c15ee()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_f54111a472af46a29b852d1f68b606b9 : HardwiredMemberDescriptor
      {
        internal PROP_f54111a472af46a29b852d1f68b606b9()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_663f7486b76c485d9842c16e38540756 : HardwiredMemberDescriptor
      {
        internal PROP_663f7486b76c485d9842c16e38540756()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_84988f9238fd423aa208135602bbe428 : HardwiredMemberDescriptor
      {
        internal PROP_84988f9238fd423aa208135602bbe428()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_ad3df5c379e941ca96cd86b354ad6034 : HardwiredMemberDescriptor
      {
        internal PROP_ad3df5c379e941ca96cd86b354ad6034()
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

      private sealed class PROP_81c0a2419e654de593bc77d011a9096f : HardwiredMemberDescriptor
      {
        internal PROP_81c0a2419e654de593bc77d011a9096f()
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

      private sealed class PROP_94a6651f48d84877a65ab6a7eb820495 : HardwiredMemberDescriptor
      {
        internal PROP_94a6651f48d84877a65ab6a7eb820495()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_b0655cfdfcca4f07bfad1e0a1be06a88 : HardwiredMemberDescriptor
      {
        internal PROP_b0655cfdfcca4f07bfad1e0a1be06a88()
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

      private sealed class PROP_35f06724660145798d840a51888f8e40 : HardwiredMemberDescriptor
      {
        internal PROP_35f06724660145798d840a51888f8e40()
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

      private sealed class PROP_14b7b05b2a424de991c41fcf4e13c1af : HardwiredMemberDescriptor
      {
        internal PROP_14b7b05b2a424de991c41fcf4e13c1af()
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

      private sealed class PROP_4db4f141fc2745bfb0ecaf8be6d730dc : HardwiredMemberDescriptor
      {
        internal PROP_4db4f141fc2745bfb0ecaf8be6d730dc()
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

      private sealed class PROP_0ca9049825ac4b83b30ba78081fb6162 : HardwiredMemberDescriptor
      {
        internal PROP_0ca9049825ac4b83b30ba78081fb6162()
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

      private sealed class PROP_7ce6558068a74264b0a94ae1ceb9866e : HardwiredMemberDescriptor
      {
        internal PROP_7ce6558068a74264b0a94ae1ceb9866e()
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

      private sealed class PROP_37e100f6fc8f4c1fb1bbd199b15754ed : HardwiredMemberDescriptor
      {
        internal PROP_37e100f6fc8f4c1fb1bbd199b15754ed()
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

      private sealed class PROP_9b40b17a329240bb8b04a024d2853311 : HardwiredMemberDescriptor
      {
        internal PROP_9b40b17a329240bb8b04a024d2853311()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_ddc7a2913f43414380cefd4d6b8bc3d0 : HardwiredMemberDescriptor
      {
        internal PROP_ddc7a2913f43414380cefd4d6b8bc3d0()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_e8bde69e3e72400cab9cc97fade3cad5 : HardwiredMemberDescriptor
      {
        internal PROP_e8bde69e3e72400cab9cc97fade3cad5()
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

      private sealed class PROP_bc33399679c549dc87a0516aa6ed5771 : HardwiredMemberDescriptor
      {
        internal PROP_bc33399679c549dc87a0516aa6ed5771()
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

      private sealed class PROP_f986579eb95448a6b78fd2ac92e622ef : HardwiredMemberDescriptor
      {
        internal PROP_f986579eb95448a6b78fd2ac92e622ef()
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

      private sealed class PROP_12a149a3c10a4dc8a46d7f9b79e98af6 : HardwiredMemberDescriptor
      {
        internal PROP_12a149a3c10a4dc8a46d7f9b79e98af6()
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

      private sealed class PROP_ad9eabc9ad5b47a5beee3c200c5e6154 : HardwiredMemberDescriptor
      {
        internal PROP_ad9eabc9ad5b47a5beee3c200c5e6154()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_84c62dc5dab649a18e6b729a09857560 : HardwiredMemberDescriptor
      {
        internal PROP_84c62dc5dab649a18e6b729a09857560()
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

      private sealed class PROP_ba7324e96c2846a5af560506e0f07f51 : HardwiredMemberDescriptor
      {
        internal PROP_ba7324e96c2846a5af560506e0f07f51()
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

      private sealed class PROP_2ea274ab061c4a06a6b9f6e234029667 : HardwiredMemberDescriptor
      {
        internal PROP_2ea274ab061c4a06a6b9f6e234029667()
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

      private sealed class PROP_1049e59f5e7043ec9a608e76ab6516e3 : HardwiredMemberDescriptor
      {
        internal PROP_1049e59f5e7043ec9a608e76ab6516e3()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_439871fbb6694f3db3adbc048fbbd89c : HardwiredMemberDescriptor
      {
        internal PROP_439871fbb6694f3db3adbc048fbbd89c()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_ce51e50ac3ff43b5a32c20c543930ab1 : HardwiredMemberDescriptor
      {
        internal PROP_ce51e50ac3ff43b5a32c20c543930ab1()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_84b03080509d4cabaa3e7f34c834749c : HardwiredMemberDescriptor
      {
        internal PROP_84b03080509d4cabaa3e7f34c834749c()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_43d7f6c70fde471b89c12e5dec195c8c : HardwiredMemberDescriptor
      {
        internal PROP_43d7f6c70fde471b89c12e5dec195c8c()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_929636aa6841447e8c99232d008f629f : HardwiredMemberDescriptor
      {
        internal PROP_929636aa6841447e8c99232d008f629f()
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

      private sealed class PROP_1b4f2bfc42da4acca383d367c2a8187d : HardwiredMemberDescriptor
      {
        internal PROP_1b4f2bfc42da4acca383d367c2a8187d()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_6a8c23a3c497452aaaa1ecd44d213759 : HardwiredMemberDescriptor
      {
        internal PROP_6a8c23a3c497452aaaa1ecd44d213759()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_e71346b9ac974563a989a6b986403965 : HardwiredMemberDescriptor
      {
        internal PROP_e71346b9ac974563a989a6b986403965()
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

      private sealed class PROP_c8c81e804f7a43fc978aa1d788f2dcac : HardwiredMemberDescriptor
      {
        internal PROP_c8c81e804f7a43fc978aa1d788f2dcac()
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

    private sealed class TYPE_b1cffd66d5424df6a1fd1f9adb1648a3 : HardwiredUserDataDescriptor
    {
      internal TYPE_b1cffd66d5424df6a1fd1f9adb1648a3()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.MTHD_410cdfa5fe044181b9e75b561cd86e62()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.MTHD_3fb4891fe60a47338c02d48e9958280f()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.MTHD_d5fb099533ea4edfa975b8b16d51bd08()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.MTHD_1e65b9dff4e84d91b25e624fa07a974c()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.MTHD_9ad5d9e44d44498691ab66cc2d2d65f1()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.MTHD_2b08a98c065e4ef7ba89bf8c906e0422()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.MTHD_059ee9c393b1413fa2dd21c667c09232()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.MTHD_8ce51b1f91f14477a3ffe35d051b4f90()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.MTHD_8c7d9a0d698b40ea8a24e79247b2b431()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.MTHD_58ff9dfab5d04a568448800c1fe54be0()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.MTHD_27f4ae07837c4170ad04b50d9b1b1011()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.MTHD_a4b6e05fb129436c8e8dd3d6807915bd()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.MTHD_7089a538941c4a0583d0ba20e387d235()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.MTHD_fbd676e9e8a64455baba49474ef6f747()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.MTHD_eff3433a64644c1f93be91a6f5e4a4ee()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.MTHD_a08f992f5f334cce898f06f572b24137()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.MTHD_b12967e97f7a4624810e23d3bd514e2f()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.MTHD_1b31b08828b6475daa3e6f7458022ca2()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.MTHD_b54c8371a0094aa1ae28e9599de5a536()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.MTHD_5d80b9a1243d479f937a649574adb151()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.PROP_7d9ed2035ab8402e85f9a82efae55f7d());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.PROP_f10a82034a9f4c319ff3e1e8cb0e3958());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.PROP_0c2917278f5b43b89afe2dfdaa80caee());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.PROP_94c794dd6dd24e15ae871873bf11fae0());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.PROP_10f7ed314e0445b18c18fcd5ff620f4e());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.PROP_314dabc4668a4d899d3a9705b03337a2());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.PROP_85bb8a1a04dd4999a05010166286699a());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_b1cffd66d5424df6a1fd1f9adb1648a3.PROP_1bd4ce1e3c4f4d3093846ed961b7d0dd());
      }

      private sealed class MTHD_410cdfa5fe044181b9e75b561cd86e62 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_410cdfa5fe044181b9e75b561cd86e62()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_3fb4891fe60a47338c02d48e9958280f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3fb4891fe60a47338c02d48e9958280f()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_d5fb099533ea4edfa975b8b16d51bd08 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d5fb099533ea4edfa975b8b16d51bd08()
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

      private sealed class MTHD_1e65b9dff4e84d91b25e624fa07a974c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1e65b9dff4e84d91b25e624fa07a974c()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_9ad5d9e44d44498691ab66cc2d2d65f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ad5d9e44d44498691ab66cc2d2d65f1()
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

      private sealed class MTHD_2b08a98c065e4ef7ba89bf8c906e0422 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b08a98c065e4ef7ba89bf8c906e0422()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_059ee9c393b1413fa2dd21c667c09232 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_059ee9c393b1413fa2dd21c667c09232()
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

      private sealed class MTHD_8ce51b1f91f14477a3ffe35d051b4f90 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ce51b1f91f14477a3ffe35d051b4f90()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_8c7d9a0d698b40ea8a24e79247b2b431 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c7d9a0d698b40ea8a24e79247b2b431()
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

      private sealed class MTHD_58ff9dfab5d04a568448800c1fe54be0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_58ff9dfab5d04a568448800c1fe54be0()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_27f4ae07837c4170ad04b50d9b1b1011 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_27f4ae07837c4170ad04b50d9b1b1011()
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

      private sealed class MTHD_a4b6e05fb129436c8e8dd3d6807915bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a4b6e05fb129436c8e8dd3d6807915bd()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_7089a538941c4a0583d0ba20e387d235 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7089a538941c4a0583d0ba20e387d235()
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

      private sealed class MTHD_fbd676e9e8a64455baba49474ef6f747 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fbd676e9e8a64455baba49474ef6f747()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_eff3433a64644c1f93be91a6f5e4a4ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eff3433a64644c1f93be91a6f5e4a4ee()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_a08f992f5f334cce898f06f572b24137 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a08f992f5f334cce898f06f572b24137()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b12967e97f7a4624810e23d3bd514e2f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b12967e97f7a4624810e23d3bd514e2f()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_1b31b08828b6475daa3e6f7458022ca2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1b31b08828b6475daa3e6f7458022ca2()
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

      private sealed class MTHD_b54c8371a0094aa1ae28e9599de5a536 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b54c8371a0094aa1ae28e9599de5a536()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_5d80b9a1243d479f937a649574adb151 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d80b9a1243d479f937a649574adb151()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_7d9ed2035ab8402e85f9a82efae55f7d : HardwiredMemberDescriptor
      {
        internal PROP_7d9ed2035ab8402e85f9a82efae55f7d()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_f10a82034a9f4c319ff3e1e8cb0e3958 : HardwiredMemberDescriptor
      {
        internal PROP_f10a82034a9f4c319ff3e1e8cb0e3958()
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

      private sealed class PROP_0c2917278f5b43b89afe2dfdaa80caee : HardwiredMemberDescriptor
      {
        internal PROP_0c2917278f5b43b89afe2dfdaa80caee()
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

      private sealed class PROP_94c794dd6dd24e15ae871873bf11fae0 : HardwiredMemberDescriptor
      {
        internal PROP_94c794dd6dd24e15ae871873bf11fae0()
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

      private sealed class PROP_10f7ed314e0445b18c18fcd5ff620f4e : HardwiredMemberDescriptor
      {
        internal PROP_10f7ed314e0445b18c18fcd5ff620f4e()
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

      private sealed class PROP_314dabc4668a4d899d3a9705b03337a2 : HardwiredMemberDescriptor
      {
        internal PROP_314dabc4668a4d899d3a9705b03337a2()
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

      private sealed class PROP_85bb8a1a04dd4999a05010166286699a : HardwiredMemberDescriptor
      {
        internal PROP_85bb8a1a04dd4999a05010166286699a()
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

      private sealed class PROP_1bd4ce1e3c4f4d3093846ed961b7d0dd : HardwiredMemberDescriptor
      {
        internal PROP_1bd4ce1e3c4f4d3093846ed961b7d0dd()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_cfbcac7af60242368baf010ca3ac01f0 : HardwiredUserDataDescriptor
    {
      internal TYPE_cfbcac7af60242368baf010ca3ac01f0()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.MTHD_fb3f238277d5444aaaa3a0138697d224()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.MTHD_d16deaf3617d49c1bbdb59b3209e1fc2()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.MTHD_5413ed2fbe7d43cdadc033e8a7e16878()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.MTHD_c172707b829a40cbbb946cd3b9e01369()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.MTHD_0334c6824f0e4810abc7726864de52c9()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.MTHD_0fe8c7015a32469d987feac8a30665f2()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.MTHD_5bf427268aa745db8ce9ddd7de919b73()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.MTHD_d09e3be2cd1547c7b310335ed98d16eb()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.MTHD_f741de1b8466440082341aa4e5c578c4()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.MTHD_e1b7075bf4974ba6a6caa9dd8e8a9818()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.MTHD_3fc5b373a18342e8b71c6898e172a988()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.MTHD_ecd45cab8de5418985c9e5e9ec67b019()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.MTHD_fd7eed7cd04a4b2994c6014be252093b()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.MTHD_7532bb99acfe4325b460367f94675d8f()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.MTHD_7dc633c69b614935a0fbe9c537cf31d3()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.MTHD_3747a735926745829744cd2f569bddf5()
        }));
        this.AddMember("setIcon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setIcon", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.MTHD_ddc3a14e250e4abfa488591b9e89c9e1()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.MTHD_5af0ea85d5f74e7bad4250504bbd0602()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.MTHD_a9de49ceaeed4dc99cbef111c513615b()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.MTHD_fddaef9ce293464981e1cf1d4b89ada2()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.MTHD_1a4217dee8e94b15a3643799c4919377()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.MTHD_86639d090aed44be87107af3702dc357()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.PROP_b614673f06c540f6a1ddc286c0604778());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.PROP_2aab3ad8a7d94036988850bea7addfbb());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.PROP_255f13599168426783244b69a83d6ef6());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.PROP_91bfd210a9d74f6f92efc88186279cbe());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.PROP_9d62c011896040c89b51fe39379854ad());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.PROP_baba3c8e08c942f6ae18a42eb570e988());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.PROP_f9e5046698d74d2fbdd54a5209d5a58d());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.PROP_f44f17361f5f46728c2b606dedea92fa());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_cfbcac7af60242368baf010ca3ac01f0.PROP_b1f1a26d4ec6470980acf06a99d1be0e());
      }

      private sealed class MTHD_fb3f238277d5444aaaa3a0138697d224 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb3f238277d5444aaaa3a0138697d224()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_d16deaf3617d49c1bbdb59b3209e1fc2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d16deaf3617d49c1bbdb59b3209e1fc2()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_5413ed2fbe7d43cdadc033e8a7e16878 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5413ed2fbe7d43cdadc033e8a7e16878()
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

      private sealed class MTHD_c172707b829a40cbbb946cd3b9e01369 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c172707b829a40cbbb946cd3b9e01369()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_0334c6824f0e4810abc7726864de52c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0334c6824f0e4810abc7726864de52c9()
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

      private sealed class MTHD_0fe8c7015a32469d987feac8a30665f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0fe8c7015a32469d987feac8a30665f2()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_5bf427268aa745db8ce9ddd7de919b73 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5bf427268aa745db8ce9ddd7de919b73()
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

      private sealed class MTHD_d09e3be2cd1547c7b310335ed98d16eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d09e3be2cd1547c7b310335ed98d16eb()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_f741de1b8466440082341aa4e5c578c4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f741de1b8466440082341aa4e5c578c4()
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

      private sealed class MTHD_e1b7075bf4974ba6a6caa9dd8e8a9818 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e1b7075bf4974ba6a6caa9dd8e8a9818()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_3fc5b373a18342e8b71c6898e172a988 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3fc5b373a18342e8b71c6898e172a988()
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

      private sealed class MTHD_ecd45cab8de5418985c9e5e9ec67b019 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ecd45cab8de5418985c9e5e9ec67b019()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_fd7eed7cd04a4b2994c6014be252093b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd7eed7cd04a4b2994c6014be252093b()
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

      private sealed class MTHD_7532bb99acfe4325b460367f94675d8f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7532bb99acfe4325b460367f94675d8f()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color2;
        }
      }

      private sealed class MTHD_7dc633c69b614935a0fbe9c537cf31d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7dc633c69b614935a0fbe9c537cf31d3()
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

      private sealed class MTHD_3747a735926745829744cd2f569bddf5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3747a735926745829744cd2f569bddf5()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_ddc3a14e250e4abfa488591b9e89c9e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ddc3a14e250e4abfa488591b9e89c9e1()
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

      private sealed class MTHD_5af0ea85d5f74e7bad4250504bbd0602 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5af0ea85d5f74e7bad4250504bbd0602()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_a9de49ceaeed4dc99cbef111c513615b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a9de49ceaeed4dc99cbef111c513615b()
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

      private sealed class MTHD_fddaef9ce293464981e1cf1d4b89ada2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fddaef9ce293464981e1cf1d4b89ada2()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_1a4217dee8e94b15a3643799c4919377 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a4217dee8e94b15a3643799c4919377()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_86639d090aed44be87107af3702dc357 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_86639d090aed44be87107af3702dc357()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_b614673f06c540f6a1ddc286c0604778 : HardwiredMemberDescriptor
      {
        internal PROP_b614673f06c540f6a1ddc286c0604778()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_2aab3ad8a7d94036988850bea7addfbb : HardwiredMemberDescriptor
      {
        internal PROP_2aab3ad8a7d94036988850bea7addfbb()
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

      private sealed class PROP_255f13599168426783244b69a83d6ef6 : HardwiredMemberDescriptor
      {
        internal PROP_255f13599168426783244b69a83d6ef6()
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

      private sealed class PROP_91bfd210a9d74f6f92efc88186279cbe : HardwiredMemberDescriptor
      {
        internal PROP_91bfd210a9d74f6f92efc88186279cbe()
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

      private sealed class PROP_9d62c011896040c89b51fe39379854ad : HardwiredMemberDescriptor
      {
        internal PROP_9d62c011896040c89b51fe39379854ad()
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

      private sealed class PROP_baba3c8e08c942f6ae18a42eb570e988 : HardwiredMemberDescriptor
      {
        internal PROP_baba3c8e08c942f6ae18a42eb570e988()
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

      private sealed class PROP_f9e5046698d74d2fbdd54a5209d5a58d : HardwiredMemberDescriptor
      {
        internal PROP_f9e5046698d74d2fbdd54a5209d5a58d()
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

      private sealed class PROP_f44f17361f5f46728c2b606dedea92fa : HardwiredMemberDescriptor
      {
        internal PROP_f44f17361f5f46728c2b606dedea92fa()
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

      private sealed class PROP_b1f1a26d4ec6470980acf06a99d1be0e : HardwiredMemberDescriptor
      {
        internal PROP_b1f1a26d4ec6470980acf06a99d1be0e()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_ce63ad19a1884416a74d6e6182f266fc : HardwiredUserDataDescriptor
    {
      internal TYPE_ce63ad19a1884416a74d6e6182f266fc()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_83066dd91944461bb70f2849b7ce84bc()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_38d35b292fb246dab32ef634c41d5cec()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_9d4671f3f2dc431c98ea2c1fdd0390eb()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_14879dc8f3884ac4ba34df214474a817()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_de0bb7f71c1c444f94bb485068667297()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_5b79a6381f5b427b80b1cb5322b5a618()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_12cac7ec82dc44bdbbca09e82a8157db()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_ba40a6781c6145eea62443fe1ec73ec4()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_e779a235f8814a6d9762906ecb1ff0e3()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_01735cca6c8a4876addb2ed0f48ba390()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_93d983505c6242bd84c4d72751606c19()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_6171f162f71c46a193759bddc8d593d5()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_b3ca1d0874d14ec8bfefd8b50c1f66bd()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_5c320c370ce646c5a055707dbe3f7881()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_cfd982d65c394d1da7692c0cc4d59472()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_0354aba782a6413e99e8a613a7c24ea1()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_c3053f06d4d24ac79bb963e2e147f2a4()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_67319c5256054d8ca8486456ce22c4e1()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_f9ce80dbadee4870bf4b4e4f32c0c953()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_a6f6db4b281844acb6fbdced12c9302f()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_0f6d843455b64eb9afb103740068734c()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_0b4902012783441d87674f7716913962()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_4042b5751d6640ffbaf65806a38789bd()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_2730c2d84211408e9e04f015b5991181()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_a2990be24c244dfca875aa218a0eaaa1()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_84ce0d043a7a4a0182976853bb43d937()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_69a5c15c840a4fd1a5f5ea3c86c7468f()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.MTHD_7d53be8d276b4d69b2de3565b381af9c()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.PROP_04d3d0648b7b42679ea8b251a1d3b57f());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.PROP_e736be17f9b249f7bdb98590338fc238());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.PROP_b1512e5b2def4bffaa804ca644475b17());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.PROP_3277cd890db84c42aa9025d9848eafd4());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.PROP_9f5939336cb143e8bdcd2de7c5c55789());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.PROP_14e918aa47064fcc998890c14ef2074e());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.PROP_7616f08d58d445be9ba4fe9db3984a59());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.PROP_5d61fb60fce64703b73ec927f5702fae());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.PROP_34c838d4d0d74b83a5230a054529ccb3());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.PROP_c36681a3efcc425688d6a2b554dd6b35());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.PROP_b9ae06e951294effb0bbc12ce8ea072c());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.PROP_27f63b12e44349bc8e2e3cace199c92e());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.PROP_901bbfd1bdff4ad1892d5d0383ed5146());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.PROP_645f692853cc45d0a023a24d9adc59eb());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.PROP_7895d88079c24941b6bb41e4e0d66a61());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.PROP_139e79c53b48440fa55a5a90e5f99d68());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_ce63ad19a1884416a74d6e6182f266fc.PROP_0bd6bd8961ba44878c3c059c8af105a4());
      }

      private sealed class MTHD_83066dd91944461bb70f2849b7ce84bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_83066dd91944461bb70f2849b7ce84bc()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_38d35b292fb246dab32ef634c41d5cec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_38d35b292fb246dab32ef634c41d5cec()
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

      private sealed class MTHD_9d4671f3f2dc431c98ea2c1fdd0390eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d4671f3f2dc431c98ea2c1fdd0390eb()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_14879dc8f3884ac4ba34df214474a817 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_14879dc8f3884ac4ba34df214474a817()
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

      private sealed class MTHD_de0bb7f71c1c444f94bb485068667297 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de0bb7f71c1c444f94bb485068667297()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_5b79a6381f5b427b80b1cb5322b5a618 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b79a6381f5b427b80b1cb5322b5a618()
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

      private sealed class MTHD_12cac7ec82dc44bdbbca09e82a8157db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_12cac7ec82dc44bdbbca09e82a8157db()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_ba40a6781c6145eea62443fe1ec73ec4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba40a6781c6145eea62443fe1ec73ec4()
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

      private sealed class MTHD_e779a235f8814a6d9762906ecb1ff0e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e779a235f8814a6d9762906ecb1ff0e3()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_01735cca6c8a4876addb2ed0f48ba390 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_01735cca6c8a4876addb2ed0f48ba390()
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

      private sealed class MTHD_93d983505c6242bd84c4d72751606c19 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93d983505c6242bd84c4d72751606c19()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_6171f162f71c46a193759bddc8d593d5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6171f162f71c46a193759bddc8d593d5()
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

      private sealed class MTHD_b3ca1d0874d14ec8bfefd8b50c1f66bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b3ca1d0874d14ec8bfefd8b50c1f66bd()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_5c320c370ce646c5a055707dbe3f7881 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c320c370ce646c5a055707dbe3f7881()
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

      private sealed class MTHD_cfd982d65c394d1da7692c0cc4d59472 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cfd982d65c394d1da7692c0cc4d59472()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_0354aba782a6413e99e8a613a7c24ea1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0354aba782a6413e99e8a613a7c24ea1()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_c3053f06d4d24ac79bb963e2e147f2a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c3053f06d4d24ac79bb963e2e147f2a4()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_67319c5256054d8ca8486456ce22c4e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67319c5256054d8ca8486456ce22c4e1()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_f9ce80dbadee4870bf4b4e4f32c0c953 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f9ce80dbadee4870bf4b4e4f32c0c953()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_a6f6db4b281844acb6fbdced12c9302f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6f6db4b281844acb6fbdced12c9302f()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_0f6d843455b64eb9afb103740068734c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f6d843455b64eb9afb103740068734c()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_0b4902012783441d87674f7716913962 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b4902012783441d87674f7716913962()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_4042b5751d6640ffbaf65806a38789bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4042b5751d6640ffbaf65806a38789bd()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_2730c2d84211408e9e04f015b5991181 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2730c2d84211408e9e04f015b5991181()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_a2990be24c244dfca875aa218a0eaaa1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2990be24c244dfca875aa218a0eaaa1()
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

      private sealed class MTHD_84ce0d043a7a4a0182976853bb43d937 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84ce0d043a7a4a0182976853bb43d937()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_69a5c15c840a4fd1a5f5ea3c86c7468f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69a5c15c840a4fd1a5f5ea3c86c7468f()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_7d53be8d276b4d69b2de3565b381af9c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7d53be8d276b4d69b2de3565b381af9c()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_04d3d0648b7b42679ea8b251a1d3b57f : HardwiredMemberDescriptor
      {
        internal PROP_04d3d0648b7b42679ea8b251a1d3b57f()
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

      private sealed class PROP_e736be17f9b249f7bdb98590338fc238 : HardwiredMemberDescriptor
      {
        internal PROP_e736be17f9b249f7bdb98590338fc238()
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

      private sealed class PROP_b1512e5b2def4bffaa804ca644475b17 : HardwiredMemberDescriptor
      {
        internal PROP_b1512e5b2def4bffaa804ca644475b17()
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

      private sealed class PROP_3277cd890db84c42aa9025d9848eafd4 : HardwiredMemberDescriptor
      {
        internal PROP_3277cd890db84c42aa9025d9848eafd4()
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

      private sealed class PROP_9f5939336cb143e8bdcd2de7c5c55789 : HardwiredMemberDescriptor
      {
        internal PROP_9f5939336cb143e8bdcd2de7c5c55789()
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

      private sealed class PROP_14e918aa47064fcc998890c14ef2074e : HardwiredMemberDescriptor
      {
        internal PROP_14e918aa47064fcc998890c14ef2074e()
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

      private sealed class PROP_7616f08d58d445be9ba4fe9db3984a59 : HardwiredMemberDescriptor
      {
        internal PROP_7616f08d58d445be9ba4fe9db3984a59()
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

      private sealed class PROP_5d61fb60fce64703b73ec927f5702fae : HardwiredMemberDescriptor
      {
        internal PROP_5d61fb60fce64703b73ec927f5702fae()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_34c838d4d0d74b83a5230a054529ccb3 : HardwiredMemberDescriptor
      {
        internal PROP_34c838d4d0d74b83a5230a054529ccb3()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_c36681a3efcc425688d6a2b554dd6b35 : HardwiredMemberDescriptor
      {
        internal PROP_c36681a3efcc425688d6a2b554dd6b35()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_b9ae06e951294effb0bbc12ce8ea072c : HardwiredMemberDescriptor
      {
        internal PROP_b9ae06e951294effb0bbc12ce8ea072c()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_27f63b12e44349bc8e2e3cace199c92e : HardwiredMemberDescriptor
      {
        internal PROP_27f63b12e44349bc8e2e3cace199c92e()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_901bbfd1bdff4ad1892d5d0383ed5146 : HardwiredMemberDescriptor
      {
        internal PROP_901bbfd1bdff4ad1892d5d0383ed5146()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_645f692853cc45d0a023a24d9adc59eb : HardwiredMemberDescriptor
      {
        internal PROP_645f692853cc45d0a023a24d9adc59eb()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_7895d88079c24941b6bb41e4e0d66a61 : HardwiredMemberDescriptor
      {
        internal PROP_7895d88079c24941b6bb41e4e0d66a61()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_139e79c53b48440fa55a5a90e5f99d68 : HardwiredMemberDescriptor
      {
        internal PROP_139e79c53b48440fa55a5a90e5f99d68()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_0bd6bd8961ba44878c3c059c8af105a4 : HardwiredMemberDescriptor
      {
        internal PROP_0bd6bd8961ba44878c3c059c8af105a4()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_246bebdbd0394e48a0e29866179a4b4d : HardwiredUserDataDescriptor
    {
      internal TYPE_246bebdbd0394e48a0e29866179a4b4d()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_246bebdbd0394e48a0e29866179a4b4d.MTHD_a95d559601f648d3959c03613e86eadf()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_246bebdbd0394e48a0e29866179a4b4d.MTHD_13f81a6bf3464d7bab638bba2e0606fa()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_246bebdbd0394e48a0e29866179a4b4d.MTHD_c52b8f11d370488098baeb2d70c70448()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_246bebdbd0394e48a0e29866179a4b4d.MTHD_c379473dd6064ff587b41b7466aa9736()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_246bebdbd0394e48a0e29866179a4b4d.MTHD_e162a1f58480494da3cb75e82fe19b44()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_246bebdbd0394e48a0e29866179a4b4d.MTHD_9256f2769e80407fa79d3157284276bd()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_246bebdbd0394e48a0e29866179a4b4d.MTHD_ccd2e752dd364f0ea47b91e5bd8d3a47()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_246bebdbd0394e48a0e29866179a4b4d.MTHD_236597e058ae4b2d92786397dc348f80()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_246bebdbd0394e48a0e29866179a4b4d.MTHD_53d76aa6d0274b6eba4196e2e5ed5a5c()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_246bebdbd0394e48a0e29866179a4b4d.MTHD_a06f3e07235341d68f7539f113d2181e()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_246bebdbd0394e48a0e29866179a4b4d.MTHD_7ea8efc4c05147678d498c57d09590d3()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_246bebdbd0394e48a0e29866179a4b4d.MTHD_c4ed1305f2d94373b66c736da3ac5682()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_246bebdbd0394e48a0e29866179a4b4d.MTHD_d8c678f07f4b407986329f2537341ae5()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_246bebdbd0394e48a0e29866179a4b4d.MTHD_c3e15f9691a8472b9ecf137cc3aeb8ae()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_246bebdbd0394e48a0e29866179a4b4d.MTHD_78e648cdc3cd46928307d0e8e2f4bea8()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_246bebdbd0394e48a0e29866179a4b4d.MTHD_a6f5eb7b99774a8eaaac38050ac753f0()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_246bebdbd0394e48a0e29866179a4b4d.MTHD_c49feafa155f441d8a2cd8d7e09a7b39()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_246bebdbd0394e48a0e29866179a4b4d.PROP_eab3ff4af7f447a0bd9728dcb4c7bb86());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_246bebdbd0394e48a0e29866179a4b4d.PROP_13057484567e45bd9bac8b0d594e2376());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_246bebdbd0394e48a0e29866179a4b4d.PROP_d48c83c4c8544250a1f2198bf5ca1ae2());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_246bebdbd0394e48a0e29866179a4b4d.PROP_d760599963a04e8b82469e9da963085c());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_246bebdbd0394e48a0e29866179a4b4d.PROP_d2fedb2ca5b044878925aff62de0420a());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_246bebdbd0394e48a0e29866179a4b4d.PROP_f1ccbda63ab24bc79e3ca7150a2a95da());
      }

      private sealed class MTHD_a95d559601f648d3959c03613e86eadf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a95d559601f648d3959c03613e86eadf()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_13f81a6bf3464d7bab638bba2e0606fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_13f81a6bf3464d7bab638bba2e0606fa()
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

      private sealed class MTHD_c52b8f11d370488098baeb2d70c70448 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c52b8f11d370488098baeb2d70c70448()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_c379473dd6064ff587b41b7466aa9736 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c379473dd6064ff587b41b7466aa9736()
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

      private sealed class MTHD_e162a1f58480494da3cb75e82fe19b44 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e162a1f58480494da3cb75e82fe19b44()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_9256f2769e80407fa79d3157284276bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9256f2769e80407fa79d3157284276bd()
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

      private sealed class MTHD_ccd2e752dd364f0ea47b91e5bd8d3a47 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ccd2e752dd364f0ea47b91e5bd8d3a47()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_236597e058ae4b2d92786397dc348f80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_236597e058ae4b2d92786397dc348f80()
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

      private sealed class MTHD_53d76aa6d0274b6eba4196e2e5ed5a5c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_53d76aa6d0274b6eba4196e2e5ed5a5c()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_a06f3e07235341d68f7539f113d2181e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a06f3e07235341d68f7539f113d2181e()
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

      private sealed class MTHD_7ea8efc4c05147678d498c57d09590d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ea8efc4c05147678d498c57d09590d3()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_c4ed1305f2d94373b66c736da3ac5682 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c4ed1305f2d94373b66c736da3ac5682()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_d8c678f07f4b407986329f2537341ae5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8c678f07f4b407986329f2537341ae5()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c3e15f9691a8472b9ecf137cc3aeb8ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c3e15f9691a8472b9ecf137cc3aeb8ae()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_78e648cdc3cd46928307d0e8e2f4bea8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_78e648cdc3cd46928307d0e8e2f4bea8()
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

      private sealed class MTHD_a6f5eb7b99774a8eaaac38050ac753f0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6f5eb7b99774a8eaaac38050ac753f0()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_c49feafa155f441d8a2cd8d7e09a7b39 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c49feafa155f441d8a2cd8d7e09a7b39()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_eab3ff4af7f447a0bd9728dcb4c7bb86 : HardwiredMemberDescriptor
      {
        internal PROP_eab3ff4af7f447a0bd9728dcb4c7bb86()
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

      private sealed class PROP_13057484567e45bd9bac8b0d594e2376 : HardwiredMemberDescriptor
      {
        internal PROP_13057484567e45bd9bac8b0d594e2376()
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

      private sealed class PROP_d48c83c4c8544250a1f2198bf5ca1ae2 : HardwiredMemberDescriptor
      {
        internal PROP_d48c83c4c8544250a1f2198bf5ca1ae2()
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

      private sealed class PROP_d760599963a04e8b82469e9da963085c : HardwiredMemberDescriptor
      {
        internal PROP_d760599963a04e8b82469e9da963085c()
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

      private sealed class PROP_d2fedb2ca5b044878925aff62de0420a : HardwiredMemberDescriptor
      {
        internal PROP_d2fedb2ca5b044878925aff62de0420a()
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

      private sealed class PROP_f1ccbda63ab24bc79e3ca7150a2a95da : HardwiredMemberDescriptor
      {
        internal PROP_f1ccbda63ab24bc79e3ca7150a2a95da()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_9e8939f3a64a4960999873330f6e2f9a : HardwiredUserDataDescriptor
    {
      internal TYPE_9e8939f3a64a4960999873330f6e2f9a()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e8939f3a64a4960999873330f6e2f9a.MTHD_a80221332f3a4d6aad3bde5d8d7e1a61(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e8939f3a64a4960999873330f6e2f9a.MTHD_aab9f760a23b455aac52025e4029e7da()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e8939f3a64a4960999873330f6e2f9a.MTHD_821f4a4e171e4c5d930293141d9ecef6(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e8939f3a64a4960999873330f6e2f9a.MTHD_5af208b700b24883b9b1ee4cc1daaac2()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e8939f3a64a4960999873330f6e2f9a.MTHD_f48282ab787b40038605d0009aa9f1e3()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e8939f3a64a4960999873330f6e2f9a.MTHD_c0b3202795d9462bbb5db6f958cf4eac()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e8939f3a64a4960999873330f6e2f9a.MTHD_867f16a77bea42808341b8c5893ff44f()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e8939f3a64a4960999873330f6e2f9a.MTHD_13272eb51bd84daeb24a9b1fbfacfa29()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e8939f3a64a4960999873330f6e2f9a.MTHD_9bf302e981ee41b1a7a8093a2e702e26()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e8939f3a64a4960999873330f6e2f9a.MTHD_6f4c6f5593634209ae09f3686e7f0c2a()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e8939f3a64a4960999873330f6e2f9a.MTHD_77152999df0e4edaa1f41631a70d6cae()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e8939f3a64a4960999873330f6e2f9a.MTHD_554ef87033e9498e86c503ac80d1b132(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e8939f3a64a4960999873330f6e2f9a.MTHD_72d32847dbd54c68a88dd65cf273cda3()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e8939f3a64a4960999873330f6e2f9a.MTHD_f422a18869ba407f9616f47c8563c234(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e8939f3a64a4960999873330f6e2f9a.MTHD_14bace9acb7946c89a579cfc7c282cb6()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e8939f3a64a4960999873330f6e2f9a.MTHD_8dc8c7782ca245e094d8a0046789409a(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e8939f3a64a4960999873330f6e2f9a.MTHD_414812ace63d47078c39f6560c404b79()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e8939f3a64a4960999873330f6e2f9a.MTHD_70ec38077f9c4e4fb230e886904c03d9(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e8939f3a64a4960999873330f6e2f9a.MTHD_c66c2f1cbaf14e2684be760c9e5172ce()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e8939f3a64a4960999873330f6e2f9a.MTHD_075d36c4e53e4a42ad2b308d0023151f(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e8939f3a64a4960999873330f6e2f9a.MTHD_da8bd2fdba7245e8a4c176a0ea8f42d7()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e8939f3a64a4960999873330f6e2f9a.MTHD_22addf3de91d48d4a5da528ab651a5d7()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9e8939f3a64a4960999873330f6e2f9a.MTHD_8b23d9b6a5734c2d8f4cd7720ea86a3c()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_9e8939f3a64a4960999873330f6e2f9a.FLDV_759a78d70a224f5e938c02e3a86c1935());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_9e8939f3a64a4960999873330f6e2f9a.FLDV_57a6f05964754cd99ab40c205004785c());
      }

      private sealed class MTHD_a80221332f3a4d6aad3bde5d8d7e1a61 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a80221332f3a4d6aad3bde5d8d7e1a61()
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

      private sealed class MTHD_aab9f760a23b455aac52025e4029e7da : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aab9f760a23b455aac52025e4029e7da()
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

      private sealed class MTHD_821f4a4e171e4c5d930293141d9ecef6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_821f4a4e171e4c5d930293141d9ecef6()
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

      private sealed class MTHD_5af208b700b24883b9b1ee4cc1daaac2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5af208b700b24883b9b1ee4cc1daaac2()
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

      private sealed class MTHD_f48282ab787b40038605d0009aa9f1e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f48282ab787b40038605d0009aa9f1e3()
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

      private sealed class MTHD_c0b3202795d9462bbb5db6f958cf4eac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c0b3202795d9462bbb5db6f958cf4eac()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_867f16a77bea42808341b8c5893ff44f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_867f16a77bea42808341b8c5893ff44f()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_13272eb51bd84daeb24a9b1fbfacfa29 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_13272eb51bd84daeb24a9b1fbfacfa29()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9bf302e981ee41b1a7a8093a2e702e26 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9bf302e981ee41b1a7a8093a2e702e26()
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

      private sealed class MTHD_6f4c6f5593634209ae09f3686e7f0c2a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6f4c6f5593634209ae09f3686e7f0c2a()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_77152999df0e4edaa1f41631a70d6cae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_77152999df0e4edaa1f41631a70d6cae()
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

      private sealed class MTHD_554ef87033e9498e86c503ac80d1b132 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_554ef87033e9498e86c503ac80d1b132()
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

      private sealed class MTHD_72d32847dbd54c68a88dd65cf273cda3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_72d32847dbd54c68a88dd65cf273cda3()
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

      private sealed class MTHD_f422a18869ba407f9616f47c8563c234 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f422a18869ba407f9616f47c8563c234()
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

      private sealed class MTHD_14bace9acb7946c89a579cfc7c282cb6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_14bace9acb7946c89a579cfc7c282cb6()
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

      private sealed class MTHD_8dc8c7782ca245e094d8a0046789409a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8dc8c7782ca245e094d8a0046789409a()
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

      private sealed class MTHD_414812ace63d47078c39f6560c404b79 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_414812ace63d47078c39f6560c404b79()
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

      private sealed class MTHD_70ec38077f9c4e4fb230e886904c03d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70ec38077f9c4e4fb230e886904c03d9()
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

      private sealed class MTHD_c66c2f1cbaf14e2684be760c9e5172ce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c66c2f1cbaf14e2684be760c9e5172ce()
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

      private sealed class MTHD_075d36c4e53e4a42ad2b308d0023151f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_075d36c4e53e4a42ad2b308d0023151f()
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

      private sealed class MTHD_da8bd2fdba7245e8a4c176a0ea8f42d7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_da8bd2fdba7245e8a4c176a0ea8f42d7()
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

      private sealed class MTHD_22addf3de91d48d4a5da528ab651a5d7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22addf3de91d48d4a5da528ab651a5d7()
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

      private sealed class MTHD_8b23d9b6a5734c2d8f4cd7720ea86a3c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b23d9b6a5734c2d8f4cd7720ea86a3c()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_759a78d70a224f5e938c02e3a86c1935 : HardwiredMemberDescriptor
      {
        internal FLDV_759a78d70a224f5e938c02e3a86c1935()
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

      private sealed class FLDV_57a6f05964754cd99ab40c205004785c : HardwiredMemberDescriptor
      {
        internal FLDV_57a6f05964754cd99ab40c205004785c()
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

    private sealed class TYPE_dc24497884c1447d8ce910a835aa485a : HardwiredUserDataDescriptor
    {
      internal TYPE_dc24497884c1447d8ce910a835aa485a()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc24497884c1447d8ce910a835aa485a.MTHD_9a14f222717b4438992df5c08e3d6a7e()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc24497884c1447d8ce910a835aa485a.MTHD_6ce01c5741934df2904f055c2a009044()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc24497884c1447d8ce910a835aa485a.MTHD_8f80e7ed82374c5e8919e26ac5ea0a6e()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc24497884c1447d8ce910a835aa485a.MTHD_651af4c6d73143fe9901dbcc88b5f2e0()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc24497884c1447d8ce910a835aa485a.MTHD_95f67ee673b945e7b7459a91e50a2f43()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc24497884c1447d8ce910a835aa485a.MTHD_f9d9aa3d9d23479ba7832c176cf0500c()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_dc24497884c1447d8ce910a835aa485a.FLDV_57105c78960341768dbb222a7b47ca12());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_dc24497884c1447d8ce910a835aa485a.FLDV_595f32c0b93d4082a9553b038248f761());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_dc24497884c1447d8ce910a835aa485a.FLDV_df8cdb837bef42ca8c252fd8b365af8f());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_dc24497884c1447d8ce910a835aa485a.FLDV_e2b090d4a2514c9aa6c0697534322c51());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_dc24497884c1447d8ce910a835aa485a.FLDV_b3f26505c2da40b4a665208030a32ea1());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_dc24497884c1447d8ce910a835aa485a.FLDV_7155cf8e8d4e473b861e7c5febb5e8c8());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_dc24497884c1447d8ce910a835aa485a.FLDV_fd5bc3eff61742ab87c6b4841f17c343());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_dc24497884c1447d8ce910a835aa485a.FLDV_8adda37d12414234babe15ab943f3032());
        this.AddMember("prestige", (IMemberDescriptor) new Bridge.TYPE_dc24497884c1447d8ce910a835aa485a.FLDV_624a0837d69b47ea89e7bec5d452753b());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_dc24497884c1447d8ce910a835aa485a.FLDV_4b544d87969f4407b61798c030cb418c());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_dc24497884c1447d8ce910a835aa485a.FLDV_cad7b3b09d514f8683158f4f3ee338a9());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_dc24497884c1447d8ce910a835aa485a.FLDV_2f1db4722d9a44788d370dd5c7eba510());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_dc24497884c1447d8ce910a835aa485a.FLDV_d77f285e8d1a475fa99dff3c4291d823());
      }

      private sealed class MTHD_9a14f222717b4438992df5c08e3d6a7e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9a14f222717b4438992df5c08e3d6a7e()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_6ce01c5741934df2904f055c2a009044 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ce01c5741934df2904f055c2a009044()
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

      private sealed class MTHD_8f80e7ed82374c5e8919e26ac5ea0a6e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8f80e7ed82374c5e8919e26ac5ea0a6e()
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

      private sealed class MTHD_651af4c6d73143fe9901dbcc88b5f2e0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_651af4c6d73143fe9901dbcc88b5f2e0()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_95f67ee673b945e7b7459a91e50a2f43 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95f67ee673b945e7b7459a91e50a2f43()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_f9d9aa3d9d23479ba7832c176cf0500c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f9d9aa3d9d23479ba7832c176cf0500c()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_57105c78960341768dbb222a7b47ca12 : HardwiredMemberDescriptor
      {
        internal FLDV_57105c78960341768dbb222a7b47ca12()
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

      private sealed class FLDV_595f32c0b93d4082a9553b038248f761 : HardwiredMemberDescriptor
      {
        internal FLDV_595f32c0b93d4082a9553b038248f761()
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

      private sealed class FLDV_df8cdb837bef42ca8c252fd8b365af8f : HardwiredMemberDescriptor
      {
        internal FLDV_df8cdb837bef42ca8c252fd8b365af8f()
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

      private sealed class FLDV_e2b090d4a2514c9aa6c0697534322c51 : HardwiredMemberDescriptor
      {
        internal FLDV_e2b090d4a2514c9aa6c0697534322c51()
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

      private sealed class FLDV_b3f26505c2da40b4a665208030a32ea1 : HardwiredMemberDescriptor
      {
        internal FLDV_b3f26505c2da40b4a665208030a32ea1()
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

      private sealed class FLDV_7155cf8e8d4e473b861e7c5febb5e8c8 : HardwiredMemberDescriptor
      {
        internal FLDV_7155cf8e8d4e473b861e7c5febb5e8c8()
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

      private sealed class FLDV_fd5bc3eff61742ab87c6b4841f17c343 : HardwiredMemberDescriptor
      {
        internal FLDV_fd5bc3eff61742ab87c6b4841f17c343()
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

      private sealed class FLDV_8adda37d12414234babe15ab943f3032 : HardwiredMemberDescriptor
      {
        internal FLDV_8adda37d12414234babe15ab943f3032()
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

      private sealed class FLDV_624a0837d69b47ea89e7bec5d452753b : HardwiredMemberDescriptor
      {
        internal FLDV_624a0837d69b47ea89e7bec5d452753b()
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

      private sealed class FLDV_4b544d87969f4407b61798c030cb418c : HardwiredMemberDescriptor
      {
        internal FLDV_4b544d87969f4407b61798c030cb418c()
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

      private sealed class FLDV_cad7b3b09d514f8683158f4f3ee338a9 : HardwiredMemberDescriptor
      {
        internal FLDV_cad7b3b09d514f8683158f4f3ee338a9()
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

      private sealed class FLDV_2f1db4722d9a44788d370dd5c7eba510 : HardwiredMemberDescriptor
      {
        internal FLDV_2f1db4722d9a44788d370dd5c7eba510()
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

      private sealed class FLDV_d77f285e8d1a475fa99dff3c4291d823 : HardwiredMemberDescriptor
      {
        internal FLDV_d77f285e8d1a475fa99dff3c4291d823()
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

    private sealed class TYPE_456fa021ddee40c0878610ca9a0a42d2 : HardwiredUserDataDescriptor
    {
      internal TYPE_456fa021ddee40c0878610ca9a0a42d2()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_4520221125374f1a8d3ce672dbec454d()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_5d4362e941404e0c9e666e1a32da6fb7()
        }));
        this.AddMember("get_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_47f0dcf861de4aa7a2444c105ea1c0b0()
        }));
        this.AddMember("set_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_f8d0a04d5e8e47819e17037c7c544356()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_eed8c257a76d401d86b314af2ab21f69()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_2c3431f0bf09410182ca32b48044fdb3()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_94ba0d551d1b4d9791b067bfdfe011a4()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_ce27cd3a0277406b86c6099be4021a49()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_59e441130c7a4b6685ec0a19a664e864()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_9c4abd707bb840c6abc4637ff378755a()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_9766da66c9f847fc85d117da2b708e04()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_619980e420274ba8adcf1fe2b2a27346()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_0ed018adbd5f44efbf3da7836d135cf3()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_fdf747364d6e48bba58fdd97aa900c2b()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_0f213d09b00b4083b6bfe877530d9fc5()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_9d731bcf11884e32be1f801c13a9a863()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_6f9715b2895b4bb5ae645793fadd92fd()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_caaa9f2b496f4682892000ff26a0d2a3()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_cf5ecb57607e442b970150ec959b5d6a()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_48c535df6a9a4dc1b5a4f8c498ac0569()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_09049e02eb044f979de9fe962a30c990()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_716de4d372b448babe7adc3bbac4451b()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_de04ada4bfae4212ac8f7ee852ee75a1()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_c331b76fe7a9441e879c0550c70c7fd2()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_d66769f2e78e446e913e348316a251d1()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_3738de2157de47d4ae008f839e4f31fe()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_cccb8dd67ec149e3ae92dbc6ff718b08()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_a63a36a6c0c94eda8061118baac1d32a()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_06876badc1bb4c8ea969508a7c799e8f()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_0698a8a6d32345faa3c404c3651b8d04()
        }));
        this.AddMember("get_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_58975ae9a6dd430cbdc1143e79d5a86d()
        }));
        this.AddMember("set_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_57e5a82a5d2d4e53866db68aa760d6dd()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_aaaba8c7449647ba8f8404db5681742b()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_978575f59a2b43f9b6ea7cca331efd79()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_d74f6abca41f477e9c11a366c644ea3e()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_d7444612020044e199fdcd02ff508f6e()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_ae4cfcf540734d63a8a6e29a3e407081()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_1bd9fa6de7f74babb077acb2bae5e576()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_9598aa9ee58940388025703ed2c9192a()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_4e80629c8a104c23b4f8a2e04a095cad()
        }));
        this.AddMember("get_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_8a0d245a742e4f87bca556d7f9b6be24()
        }));
        this.AddMember("set_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_83f42066d5574122b0b54e286bbc61e6()
        }));
        this.AddMember("get_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_e7e16957b36b40f29493893c97d9bf04()
        }));
        this.AddMember("set_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_51b9ab6d700f47ac84257e8ce507913f()
        }));
        this.AddMember("get_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_92539e74f7b0490da3f2a3423a369b0d()
        }));
        this.AddMember("set_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_909befc13a114fba947b2e4d8f52c58c()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_498c0b3a91e5439aa2827240e1768183()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_a48b7b9c141f4bbf8ac0064a74ff8610()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_1010932fea61488bba3fe79f729a777e()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_fc86825cd4054583bfb9e94dd2a6d957()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_9fc5e8880336469581e3ba88201bbe0e()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_a8a6b6ac38ae428b810053158c974919()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_b3fd683bac30488b81d26efdb915ae13()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_6b90eaf04b9d40f8ae49d7b3f8099a9c()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_0392055a20224871903ac5cb74731fe4()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_e4578f1b68ef43bb94f1192288cdef62()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_8fa67ec10a514eb4b16a6ccaa260d9ce()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_146938f3a1a7491ba85af13e46751dc6()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_65873ff96e4c45319c5a9c93aff175fd()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.MTHD_cbbb4083b9834fbb816372ebfec80de6()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.PROP_cd7a6d976b8f4934b8d658819c1982df());
        this.AddMember("visible", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.PROP_a0acbdf0733d4b319e3a1f07b878da16());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.PROP_6dd6e79ff94c40e6be68ea376d94b060());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.PROP_e4bd3a064d094d32b87af8cbcff1d418());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.PROP_77ceb94e7eb24354bf07e4783847413a());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.PROP_f65b5bf1e2244bbda8745231e7a8084d());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.PROP_b4bf37ad30134d2f85bbb0cadfe89a04());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.PROP_cc8858194ec24227bd457c98011cdd37());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.PROP_b1df74a134194feeadd58643b596ca67());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.PROP_27a0597fc45140c49fa029aa15fb496c());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.PROP_8799acd45b3d4320a0c298e19fb1522a());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.PROP_33ce77c92da94aeea3ec4e4d935be28f());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.PROP_fae12629282a456098af4bd96d497ecb());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.PROP_57ef5bf527174a2bade4faeff22ac090());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.PROP_73b8e831824445cfad32c8e48a42d0d2());
        this.AddMember("onClick2", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.PROP_68a097e1788a420b99bb56be67acd95e());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.PROP_e63a33387bf04bc7bc88b976061c3a39());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.PROP_d76cdcb0b2c14b05aad6211a022cd4fc());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.PROP_10f5ea65a6d644b6997236d7cc4adb92());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.PROP_18a20442298e4f42838ddae843acdc78());
        this.AddMember("textColor2", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.PROP_61b0c6b5c2db42ed8754f0f14df5d250());
        this.AddMember("highlightColor", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.PROP_19fbe2d3bfe549c7abab59ae06ddf6fd());
        this.AddMember("highlightColor2", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.PROP_3374cc1ed0be40f19d59b288e79f8add());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.PROP_e59cc75c668546f0bc83c699e53f0999());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.PROP_fa11359699a24d20b6029db55a7b9d15());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.FLDV_1900729ccef844059f4a2763c3f71460());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.FLDV_201b99d774444b3e9e96299281e48f61());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_456fa021ddee40c0878610ca9a0a42d2.FLDV_7d83f52c80304c8bba277df7c3687f83());
      }

      private sealed class MTHD_4520221125374f1a8d3ce672dbec454d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4520221125374f1a8d3ce672dbec454d()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_5d4362e941404e0c9e666e1a32da6fb7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d4362e941404e0c9e666e1a32da6fb7()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_47f0dcf861de4aa7a2444c105ea1c0b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_47f0dcf861de4aa7a2444c105ea1c0b0()
        {
          this.Initialize("get_visible", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).visible;
        }
      }

      private sealed class MTHD_f8d0a04d5e8e47819e17037c7c544356 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f8d0a04d5e8e47819e17037c7c544356()
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

      private sealed class MTHD_eed8c257a76d401d86b314af2ab21f69 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eed8c257a76d401d86b314af2ab21f69()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_2c3431f0bf09410182ca32b48044fdb3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c3431f0bf09410182ca32b48044fdb3()
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

      private sealed class MTHD_94ba0d551d1b4d9791b067bfdfe011a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_94ba0d551d1b4d9791b067bfdfe011a4()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_ce27cd3a0277406b86c6099be4021a49 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ce27cd3a0277406b86c6099be4021a49()
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

      private sealed class MTHD_59e441130c7a4b6685ec0a19a664e864 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_59e441130c7a4b6685ec0a19a664e864()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_9c4abd707bb840c6abc4637ff378755a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c4abd707bb840c6abc4637ff378755a()
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

      private sealed class MTHD_9766da66c9f847fc85d117da2b708e04 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9766da66c9f847fc85d117da2b708e04()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_619980e420274ba8adcf1fe2b2a27346 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_619980e420274ba8adcf1fe2b2a27346()
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

      private sealed class MTHD_0ed018adbd5f44efbf3da7836d135cf3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ed018adbd5f44efbf3da7836d135cf3()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_fdf747364d6e48bba58fdd97aa900c2b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fdf747364d6e48bba58fdd97aa900c2b()
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

      private sealed class MTHD_0f213d09b00b4083b6bfe877530d9fc5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f213d09b00b4083b6bfe877530d9fc5()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_9d731bcf11884e32be1f801c13a9a863 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d731bcf11884e32be1f801c13a9a863()
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

      private sealed class MTHD_6f9715b2895b4bb5ae645793fadd92fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6f9715b2895b4bb5ae645793fadd92fd()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_caaa9f2b496f4682892000ff26a0d2a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_caaa9f2b496f4682892000ff26a0d2a3()
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

      private sealed class MTHD_cf5ecb57607e442b970150ec959b5d6a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf5ecb57607e442b970150ec959b5d6a()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_48c535df6a9a4dc1b5a4f8c498ac0569 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_48c535df6a9a4dc1b5a4f8c498ac0569()
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

      private sealed class MTHD_09049e02eb044f979de9fe962a30c990 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_09049e02eb044f979de9fe962a30c990()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_716de4d372b448babe7adc3bbac4451b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_716de4d372b448babe7adc3bbac4451b()
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

      private sealed class MTHD_de04ada4bfae4212ac8f7ee852ee75a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de04ada4bfae4212ac8f7ee852ee75a1()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_c331b76fe7a9441e879c0550c70c7fd2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c331b76fe7a9441e879c0550c70c7fd2()
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

      private sealed class MTHD_d66769f2e78e446e913e348316a251d1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d66769f2e78e446e913e348316a251d1()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_3738de2157de47d4ae008f839e4f31fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3738de2157de47d4ae008f839e4f31fe()
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

      private sealed class MTHD_cccb8dd67ec149e3ae92dbc6ff718b08 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cccb8dd67ec149e3ae92dbc6ff718b08()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_a63a36a6c0c94eda8061118baac1d32a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a63a36a6c0c94eda8061118baac1d32a()
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

      private sealed class MTHD_06876badc1bb4c8ea969508a7c799e8f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_06876badc1bb4c8ea969508a7c799e8f()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_0698a8a6d32345faa3c404c3651b8d04 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0698a8a6d32345faa3c404c3651b8d04()
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

      private sealed class MTHD_58975ae9a6dd430cbdc1143e79d5a86d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_58975ae9a6dd430cbdc1143e79d5a86d()
        {
          this.Initialize("get_onClick2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick2;
        }
      }

      private sealed class MTHD_57e5a82a5d2d4e53866db68aa760d6dd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57e5a82a5d2d4e53866db68aa760d6dd()
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

      private sealed class MTHD_aaaba8c7449647ba8f8404db5681742b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aaaba8c7449647ba8f8404db5681742b()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_978575f59a2b43f9b6ea7cca331efd79 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_978575f59a2b43f9b6ea7cca331efd79()
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

      private sealed class MTHD_d74f6abca41f477e9c11a366c644ea3e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d74f6abca41f477e9c11a366c644ea3e()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color2;
        }
      }

      private sealed class MTHD_d7444612020044e199fdcd02ff508f6e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d7444612020044e199fdcd02ff508f6e()
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

      private sealed class MTHD_ae4cfcf540734d63a8a6e29a3e407081 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae4cfcf540734d63a8a6e29a3e407081()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_1bd9fa6de7f74babb077acb2bae5e576 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1bd9fa6de7f74babb077acb2bae5e576()
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

      private sealed class MTHD_9598aa9ee58940388025703ed2c9192a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9598aa9ee58940388025703ed2c9192a()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_4e80629c8a104c23b4f8a2e04a095cad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e80629c8a104c23b4f8a2e04a095cad()
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

      private sealed class MTHD_8a0d245a742e4f87bca556d7f9b6be24 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a0d245a742e4f87bca556d7f9b6be24()
        {
          this.Initialize("get_textColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor2;
        }
      }

      private sealed class MTHD_83f42066d5574122b0b54e286bbc61e6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_83f42066d5574122b0b54e286bbc61e6()
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

      private sealed class MTHD_e7e16957b36b40f29493893c97d9bf04 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7e16957b36b40f29493893c97d9bf04()
        {
          this.Initialize("get_highlightColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor;
        }
      }

      private sealed class MTHD_51b9ab6d700f47ac84257e8ce507913f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_51b9ab6d700f47ac84257e8ce507913f()
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

      private sealed class MTHD_92539e74f7b0490da3f2a3423a369b0d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_92539e74f7b0490da3f2a3423a369b0d()
        {
          this.Initialize("get_highlightColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor2;
        }
      }

      private sealed class MTHD_909befc13a114fba947b2e4d8f52c58c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_909befc13a114fba947b2e4d8f52c58c()
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

      private sealed class MTHD_498c0b3a91e5439aa2827240e1768183 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_498c0b3a91e5439aa2827240e1768183()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_a48b7b9c141f4bbf8ac0064a74ff8610 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a48b7b9c141f4bbf8ac0064a74ff8610()
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

      private sealed class MTHD_1010932fea61488bba3fe79f729a777e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1010932fea61488bba3fe79f729a777e()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_fc86825cd4054583bfb9e94dd2a6d957 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fc86825cd4054583bfb9e94dd2a6d957()
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

      private sealed class MTHD_9fc5e8880336469581e3ba88201bbe0e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9fc5e8880336469581e3ba88201bbe0e()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_a8a6b6ac38ae428b810053158c974919 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a8a6b6ac38ae428b810053158c974919()
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

      private sealed class MTHD_b3fd683bac30488b81d26efdb915ae13 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b3fd683bac30488b81d26efdb915ae13()
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

      private sealed class MTHD_6b90eaf04b9d40f8ae49d7b3f8099a9c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b90eaf04b9d40f8ae49d7b3f8099a9c()
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

      private sealed class MTHD_0392055a20224871903ac5cb74731fe4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0392055a20224871903ac5cb74731fe4()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_e4578f1b68ef43bb94f1192288cdef62 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e4578f1b68ef43bb94f1192288cdef62()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_8fa67ec10a514eb4b16a6ccaa260d9ce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8fa67ec10a514eb4b16a6ccaa260d9ce()
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

      private sealed class MTHD_146938f3a1a7491ba85af13e46751dc6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_146938f3a1a7491ba85af13e46751dc6()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_65873ff96e4c45319c5a9c93aff175fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65873ff96e4c45319c5a9c93aff175fd()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_cbbb4083b9834fbb816372ebfec80de6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cbbb4083b9834fbb816372ebfec80de6()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_cd7a6d976b8f4934b8d658819c1982df : HardwiredMemberDescriptor
      {
        internal PROP_cd7a6d976b8f4934b8d658819c1982df()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_a0acbdf0733d4b319e3a1f07b878da16 : HardwiredMemberDescriptor
      {
        internal PROP_a0acbdf0733d4b319e3a1f07b878da16()
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

      private sealed class PROP_6dd6e79ff94c40e6be68ea376d94b060 : HardwiredMemberDescriptor
      {
        internal PROP_6dd6e79ff94c40e6be68ea376d94b060()
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

      private sealed class PROP_e4bd3a064d094d32b87af8cbcff1d418 : HardwiredMemberDescriptor
      {
        internal PROP_e4bd3a064d094d32b87af8cbcff1d418()
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

      private sealed class PROP_77ceb94e7eb24354bf07e4783847413a : HardwiredMemberDescriptor
      {
        internal PROP_77ceb94e7eb24354bf07e4783847413a()
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

      private sealed class PROP_f65b5bf1e2244bbda8745231e7a8084d : HardwiredMemberDescriptor
      {
        internal PROP_f65b5bf1e2244bbda8745231e7a8084d()
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

      private sealed class PROP_b4bf37ad30134d2f85bbb0cadfe89a04 : HardwiredMemberDescriptor
      {
        internal PROP_b4bf37ad30134d2f85bbb0cadfe89a04()
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

      private sealed class PROP_cc8858194ec24227bd457c98011cdd37 : HardwiredMemberDescriptor
      {
        internal PROP_cc8858194ec24227bd457c98011cdd37()
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

      private sealed class PROP_b1df74a134194feeadd58643b596ca67 : HardwiredMemberDescriptor
      {
        internal PROP_b1df74a134194feeadd58643b596ca67()
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

      private sealed class PROP_27a0597fc45140c49fa029aa15fb496c : HardwiredMemberDescriptor
      {
        internal PROP_27a0597fc45140c49fa029aa15fb496c()
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

      private sealed class PROP_8799acd45b3d4320a0c298e19fb1522a : HardwiredMemberDescriptor
      {
        internal PROP_8799acd45b3d4320a0c298e19fb1522a()
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

      private sealed class PROP_33ce77c92da94aeea3ec4e4d935be28f : HardwiredMemberDescriptor
      {
        internal PROP_33ce77c92da94aeea3ec4e4d935be28f()
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

      private sealed class PROP_fae12629282a456098af4bd96d497ecb : HardwiredMemberDescriptor
      {
        internal PROP_fae12629282a456098af4bd96d497ecb()
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

      private sealed class PROP_57ef5bf527174a2bade4faeff22ac090 : HardwiredMemberDescriptor
      {
        internal PROP_57ef5bf527174a2bade4faeff22ac090()
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

      private sealed class PROP_73b8e831824445cfad32c8e48a42d0d2 : HardwiredMemberDescriptor
      {
        internal PROP_73b8e831824445cfad32c8e48a42d0d2()
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

      private sealed class PROP_68a097e1788a420b99bb56be67acd95e : HardwiredMemberDescriptor
      {
        internal PROP_68a097e1788a420b99bb56be67acd95e()
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

      private sealed class PROP_e63a33387bf04bc7bc88b976061c3a39 : HardwiredMemberDescriptor
      {
        internal PROP_e63a33387bf04bc7bc88b976061c3a39()
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

      private sealed class PROP_d76cdcb0b2c14b05aad6211a022cd4fc : HardwiredMemberDescriptor
      {
        internal PROP_d76cdcb0b2c14b05aad6211a022cd4fc()
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

      private sealed class PROP_10f5ea65a6d644b6997236d7cc4adb92 : HardwiredMemberDescriptor
      {
        internal PROP_10f5ea65a6d644b6997236d7cc4adb92()
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

      private sealed class PROP_18a20442298e4f42838ddae843acdc78 : HardwiredMemberDescriptor
      {
        internal PROP_18a20442298e4f42838ddae843acdc78()
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

      private sealed class PROP_61b0c6b5c2db42ed8754f0f14df5d250 : HardwiredMemberDescriptor
      {
        internal PROP_61b0c6b5c2db42ed8754f0f14df5d250()
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

      private sealed class PROP_19fbe2d3bfe549c7abab59ae06ddf6fd : HardwiredMemberDescriptor
      {
        internal PROP_19fbe2d3bfe549c7abab59ae06ddf6fd()
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

      private sealed class PROP_3374cc1ed0be40f19d59b288e79f8add : HardwiredMemberDescriptor
      {
        internal PROP_3374cc1ed0be40f19d59b288e79f8add()
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

      private sealed class PROP_e59cc75c668546f0bc83c699e53f0999 : HardwiredMemberDescriptor
      {
        internal PROP_e59cc75c668546f0bc83c699e53f0999()
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

      private sealed class PROP_fa11359699a24d20b6029db55a7b9d15 : HardwiredMemberDescriptor
      {
        internal PROP_fa11359699a24d20b6029db55a7b9d15()
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

      private sealed class FLDV_1900729ccef844059f4a2763c3f71460 : HardwiredMemberDescriptor
      {
        internal FLDV_1900729ccef844059f4a2763c3f71460()
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

      private sealed class FLDV_201b99d774444b3e9e96299281e48f61 : HardwiredMemberDescriptor
      {
        internal FLDV_201b99d774444b3e9e96299281e48f61()
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

      private sealed class FLDV_7d83f52c80304c8bba277df7c3687f83 : HardwiredMemberDescriptor
      {
        internal FLDV_7d83f52c80304c8bba277df7c3687f83()
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

    private sealed class TYPE_1b503d38962e4b7e9ff29451f1a4e0fd : HardwiredUserDataDescriptor
    {
      internal TYPE_1b503d38962e4b7e9ff29451f1a4e0fd()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1b503d38962e4b7e9ff29451f1a4e0fd.MTHD_00dcbefd0e6b47ec8e862037892169d5()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1b503d38962e4b7e9ff29451f1a4e0fd.MTHD_149ba7fb8aae47558de4bfb4e56141c9()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1b503d38962e4b7e9ff29451f1a4e0fd.MTHD_4a8be98748214286920836af1a1ac3a3()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1b503d38962e4b7e9ff29451f1a4e0fd.MTHD_99a68046292a4b6fbee65cefcb185e00()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1b503d38962e4b7e9ff29451f1a4e0fd.MTHD_e29a0cdef8f7472089a6a0dc9f3d53f3()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1b503d38962e4b7e9ff29451f1a4e0fd.MTHD_65843cf601ff4acca28d96c509e3bd52()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_1b503d38962e4b7e9ff29451f1a4e0fd.FLDV_5a4f356e67c94aa58ce1dc3f2d8ff763());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_1b503d38962e4b7e9ff29451f1a4e0fd.FLDV_e44c15e79d064e9bbbc3f73bc43035e2());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_1b503d38962e4b7e9ff29451f1a4e0fd.FLDV_48076e4a4a9248b3a253313e71777e68());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_1b503d38962e4b7e9ff29451f1a4e0fd.FLDV_35a3d46b7f6a4077ba50375a9d053cb1());
      }

      private sealed class MTHD_00dcbefd0e6b47ec8e862037892169d5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_00dcbefd0e6b47ec8e862037892169d5()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_149ba7fb8aae47558de4bfb4e56141c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_149ba7fb8aae47558de4bfb4e56141c9()
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

      private sealed class MTHD_4a8be98748214286920836af1a1ac3a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a8be98748214286920836af1a1ac3a3()
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

      private sealed class MTHD_99a68046292a4b6fbee65cefcb185e00 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99a68046292a4b6fbee65cefcb185e00()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_e29a0cdef8f7472089a6a0dc9f3d53f3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e29a0cdef8f7472089a6a0dc9f3d53f3()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_65843cf601ff4acca28d96c509e3bd52 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65843cf601ff4acca28d96c509e3bd52()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_5a4f356e67c94aa58ce1dc3f2d8ff763 : HardwiredMemberDescriptor
      {
        internal FLDV_5a4f356e67c94aa58ce1dc3f2d8ff763()
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

      private sealed class FLDV_e44c15e79d064e9bbbc3f73bc43035e2 : HardwiredMemberDescriptor
      {
        internal FLDV_e44c15e79d064e9bbbc3f73bc43035e2()
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

      private sealed class FLDV_48076e4a4a9248b3a253313e71777e68 : HardwiredMemberDescriptor
      {
        internal FLDV_48076e4a4a9248b3a253313e71777e68()
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

      private sealed class FLDV_35a3d46b7f6a4077ba50375a9d053cb1 : HardwiredMemberDescriptor
      {
        internal FLDV_35a3d46b7f6a4077ba50375a9d053cb1()
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

    private sealed class TYPE_9f9c84e3708d4dff86bc4c835dcd9a3f : HardwiredUserDataDescriptor
    {
      internal TYPE_9f9c84e3708d4dff86bc4c835dcd9a3f()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9c84e3708d4dff86bc4c835dcd9a3f.MTHD_425c51880eb84e9e8da84d6a2643d6a2()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9c84e3708d4dff86bc4c835dcd9a3f.MTHD_3e697f26e05c4aa483cc862865dae5ba()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9c84e3708d4dff86bc4c835dcd9a3f.MTHD_152ec4812f6e4cd5957dbfa5b34df8a0()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9c84e3708d4dff86bc4c835dcd9a3f.MTHD_fb0f3502348549d2aba8bf4140d771ca()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9f9c84e3708d4dff86bc4c835dcd9a3f.MTHD_e8032c724f2e4ef09ada9dec7dc7f33e()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_9f9c84e3708d4dff86bc4c835dcd9a3f.FLDV_a54cecc8a988495080253c5c14ab247f());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_9f9c84e3708d4dff86bc4c835dcd9a3f.FLDV_ac7860ea5f864b96877e04d0aed94b5a());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_9f9c84e3708d4dff86bc4c835dcd9a3f.FLDV_f725b4e46b0548f59ee29f480c70edd8());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_9f9c84e3708d4dff86bc4c835dcd9a3f.FLDV_2dd63e6f088d425c8233a0926d66b29d());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_9f9c84e3708d4dff86bc4c835dcd9a3f.FLDV_b210e9f86e664d50a61264ef5d2b7fa5());
      }

      private sealed class MTHD_425c51880eb84e9e8da84d6a2643d6a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_425c51880eb84e9e8da84d6a2643d6a2()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_3e697f26e05c4aa483cc862865dae5ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e697f26e05c4aa483cc862865dae5ba()
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

      private sealed class MTHD_152ec4812f6e4cd5957dbfa5b34df8a0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_152ec4812f6e4cd5957dbfa5b34df8a0()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_fb0f3502348549d2aba8bf4140d771ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb0f3502348549d2aba8bf4140d771ca()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_e8032c724f2e4ef09ada9dec7dc7f33e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e8032c724f2e4ef09ada9dec7dc7f33e()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_a54cecc8a988495080253c5c14ab247f : HardwiredMemberDescriptor
      {
        internal FLDV_a54cecc8a988495080253c5c14ab247f()
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

      private sealed class FLDV_ac7860ea5f864b96877e04d0aed94b5a : HardwiredMemberDescriptor
      {
        internal FLDV_ac7860ea5f864b96877e04d0aed94b5a()
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

      private sealed class FLDV_f725b4e46b0548f59ee29f480c70edd8 : HardwiredMemberDescriptor
      {
        internal FLDV_f725b4e46b0548f59ee29f480c70edd8()
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

      private sealed class FLDV_2dd63e6f088d425c8233a0926d66b29d : HardwiredMemberDescriptor
      {
        internal FLDV_2dd63e6f088d425c8233a0926d66b29d()
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

      private sealed class FLDV_b210e9f86e664d50a61264ef5d2b7fa5 : HardwiredMemberDescriptor
      {
        internal FLDV_b210e9f86e664d50a61264ef5d2b7fa5()
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

    private sealed class TYPE_3db03bc69b8b447194880382f97fe946 : HardwiredUserDataDescriptor
    {
      internal TYPE_3db03bc69b8b447194880382f97fe946()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3db03bc69b8b447194880382f97fe946.MTHD_93f4ac2aebae403db7e15720d1a542c8()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3db03bc69b8b447194880382f97fe946.MTHD_2dc5b7f63d404f278883eac2fafa0c0e()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3db03bc69b8b447194880382f97fe946.MTHD_7fcab73b9a9845b495342561660aa5bf()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3db03bc69b8b447194880382f97fe946.MTHD_accd73f7ad21422483194cfed03033cf()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3db03bc69b8b447194880382f97fe946.MTHD_073b428c0b4c427abbb454badd3f8d66()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3db03bc69b8b447194880382f97fe946.MTHD_31a31bc7156243e089829dd97fbe8006()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3db03bc69b8b447194880382f97fe946.MTHD_d9d5d38506aa41e8adcf9c59153dbab2()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3db03bc69b8b447194880382f97fe946.MTHD_602708d75b914da1bc2b8b622150670f()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3db03bc69b8b447194880382f97fe946.MTHD_2e165457124842958cee3199827ba049()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3db03bc69b8b447194880382f97fe946.MTHD_922f83aee7054f03a66004883168999a()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3db03bc69b8b447194880382f97fe946.MTHD_f016093cbd6b4dc0bcf8bccdb3c1da9d()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3db03bc69b8b447194880382f97fe946.MTHD_4b8dbb2669024d32ab45aad9a5c77105()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3db03bc69b8b447194880382f97fe946.MTHD_e35c1d50cf41435ab25c26f9b4f5ea77()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_3db03bc69b8b447194880382f97fe946.FLDV_2f2a8508734d4826b5beae886f03d87a());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_3db03bc69b8b447194880382f97fe946.FLDV_f6520a87858f4c7e92c2333de019d8ec());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_3db03bc69b8b447194880382f97fe946.FLDV_aa5a5ae8c60b4a61847ac3947480dc61());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_3db03bc69b8b447194880382f97fe946.FLDV_310c0b936dd94818993a7a72071d41de());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_3db03bc69b8b447194880382f97fe946.FLDV_418d92a85abf41edafbed8182d11991f());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_3db03bc69b8b447194880382f97fe946.FLDV_cc3573e91b05416b9e3b9a971628d0ef());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_3db03bc69b8b447194880382f97fe946.FLDV_1eb5ccb5e6304ebea67f13cc052c3a5e());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_3db03bc69b8b447194880382f97fe946.FLDV_0d64768c210e45a9b085a0a7c1af801c());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_3db03bc69b8b447194880382f97fe946.DVAL_c305a8ca3d7e43549589133231fb5691());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_3db03bc69b8b447194880382f97fe946.DVAL_7b6e447c00074a09ad706a4b1694fa3b());
      }

      private sealed class MTHD_93f4ac2aebae403db7e15720d1a542c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93f4ac2aebae403db7e15720d1a542c8()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_2dc5b7f63d404f278883eac2fafa0c0e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2dc5b7f63d404f278883eac2fafa0c0e()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_7fcab73b9a9845b495342561660aa5bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7fcab73b9a9845b495342561660aa5bf()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_accd73f7ad21422483194cfed03033cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_accd73f7ad21422483194cfed03033cf()
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

      private sealed class MTHD_073b428c0b4c427abbb454badd3f8d66 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_073b428c0b4c427abbb454badd3f8d66()
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

      private sealed class MTHD_31a31bc7156243e089829dd97fbe8006 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_31a31bc7156243e089829dd97fbe8006()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_d9d5d38506aa41e8adcf9c59153dbab2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d9d5d38506aa41e8adcf9c59153dbab2()
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

      private sealed class MTHD_602708d75b914da1bc2b8b622150670f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_602708d75b914da1bc2b8b622150670f()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_2e165457124842958cee3199827ba049 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2e165457124842958cee3199827ba049()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_922f83aee7054f03a66004883168999a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_922f83aee7054f03a66004883168999a()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f016093cbd6b4dc0bcf8bccdb3c1da9d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f016093cbd6b4dc0bcf8bccdb3c1da9d()
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

      private sealed class MTHD_4b8dbb2669024d32ab45aad9a5c77105 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b8dbb2669024d32ab45aad9a5c77105()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_e35c1d50cf41435ab25c26f9b4f5ea77 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e35c1d50cf41435ab25c26f9b4f5ea77()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_2f2a8508734d4826b5beae886f03d87a : HardwiredMemberDescriptor
      {
        internal FLDV_2f2a8508734d4826b5beae886f03d87a()
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

      private sealed class FLDV_f6520a87858f4c7e92c2333de019d8ec : HardwiredMemberDescriptor
      {
        internal FLDV_f6520a87858f4c7e92c2333de019d8ec()
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

      private sealed class FLDV_aa5a5ae8c60b4a61847ac3947480dc61 : HardwiredMemberDescriptor
      {
        internal FLDV_aa5a5ae8c60b4a61847ac3947480dc61()
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

      private sealed class FLDV_310c0b936dd94818993a7a72071d41de : HardwiredMemberDescriptor
      {
        internal FLDV_310c0b936dd94818993a7a72071d41de()
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

      private sealed class FLDV_418d92a85abf41edafbed8182d11991f : HardwiredMemberDescriptor
      {
        internal FLDV_418d92a85abf41edafbed8182d11991f()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_cc3573e91b05416b9e3b9a971628d0ef : HardwiredMemberDescriptor
      {
        internal FLDV_cc3573e91b05416b9e3b9a971628d0ef()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_1eb5ccb5e6304ebea67f13cc052c3a5e : HardwiredMemberDescriptor
      {
        internal FLDV_1eb5ccb5e6304ebea67f13cc052c3a5e()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_0d64768c210e45a9b085a0a7c1af801c : HardwiredMemberDescriptor
      {
        internal FLDV_0d64768c210e45a9b085a0a7c1af801c()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_c305a8ca3d7e43549589133231fb5691 : DynValueMemberDescriptor
      {
        internal DVAL_c305a8ca3d7e43549589133231fb5691()
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

      private sealed class DVAL_7b6e447c00074a09ad706a4b1694fa3b : DynValueMemberDescriptor
      {
        internal DVAL_7b6e447c00074a09ad706a4b1694fa3b()
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

    private sealed class TYPE_6169071836e940ddbb227a48e1864bf4 : HardwiredUserDataDescriptor
    {
      internal TYPE_6169071836e940ddbb227a48e1864bf4()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6169071836e940ddbb227a48e1864bf4.MTHD_0dc495031e7d44e79cc8c30a5e698d65()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6169071836e940ddbb227a48e1864bf4.MTHD_e916f60cfbf2426287d704cb05b1dc28()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6169071836e940ddbb227a48e1864bf4.MTHD_04f754fc63cb480b8d51abc9e00260c8(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6169071836e940ddbb227a48e1864bf4.MTHD_9411085492bc4cef961150f280d7c9df()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6169071836e940ddbb227a48e1864bf4.MTHD_b75ecec939bc449eb0296f71daffc180(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6169071836e940ddbb227a48e1864bf4.MTHD_dbee84ac1ff04b03a0b4aed9ba2aefcf()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6169071836e940ddbb227a48e1864bf4.MTHD_90fa40a52a1440f6849625e918452970()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6169071836e940ddbb227a48e1864bf4.MTHD_4781591b9c1a4b378310c2a097827ac0()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6169071836e940ddbb227a48e1864bf4.MTHD_58e47cd48d214c68a709903d4775de7c()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6169071836e940ddbb227a48e1864bf4.MTHD_a847d4a57b004aa18eb73da1630317a3()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_6169071836e940ddbb227a48e1864bf4.FLDV_d79e1f7f80854e9ca7961e419e438d68());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_6169071836e940ddbb227a48e1864bf4.FLDV_e05dc4fcf28143b2ad893b5c64541bda());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_6169071836e940ddbb227a48e1864bf4.FLDV_8c9822dd4aae4c25b52bdcf2768e95fd());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_6169071836e940ddbb227a48e1864bf4.FLDV_5ac6da59df374ad38f071b29856df8a2());
        this.AddMember("white", (IMemberDescriptor) new Bridge.TYPE_6169071836e940ddbb227a48e1864bf4.FLDV_b220d50515a84f4eb880be947bd49467());
      }

      private sealed class MTHD_0dc495031e7d44e79cc8c30a5e698d65 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0dc495031e7d44e79cc8c30a5e698d65()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_e916f60cfbf2426287d704cb05b1dc28 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e916f60cfbf2426287d704cb05b1dc28()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_04f754fc63cb480b8d51abc9e00260c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_04f754fc63cb480b8d51abc9e00260c8()
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

      private sealed class MTHD_9411085492bc4cef961150f280d7c9df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9411085492bc4cef961150f280d7c9df()
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

      private sealed class MTHD_b75ecec939bc449eb0296f71daffc180 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b75ecec939bc449eb0296f71daffc180()
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

      private sealed class MTHD_dbee84ac1ff04b03a0b4aed9ba2aefcf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dbee84ac1ff04b03a0b4aed9ba2aefcf()
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

      private sealed class MTHD_90fa40a52a1440f6849625e918452970 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90fa40a52a1440f6849625e918452970()
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

      private sealed class MTHD_4781591b9c1a4b378310c2a097827ac0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4781591b9c1a4b378310c2a097827ac0()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_58e47cd48d214c68a709903d4775de7c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_58e47cd48d214c68a709903d4775de7c()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_a847d4a57b004aa18eb73da1630317a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a847d4a57b004aa18eb73da1630317a3()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_d79e1f7f80854e9ca7961e419e438d68 : HardwiredMemberDescriptor
      {
        internal FLDV_d79e1f7f80854e9ca7961e419e438d68()
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

      private sealed class FLDV_e05dc4fcf28143b2ad893b5c64541bda : HardwiredMemberDescriptor
      {
        internal FLDV_e05dc4fcf28143b2ad893b5c64541bda()
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

      private sealed class FLDV_8c9822dd4aae4c25b52bdcf2768e95fd : HardwiredMemberDescriptor
      {
        internal FLDV_8c9822dd4aae4c25b52bdcf2768e95fd()
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

      private sealed class FLDV_5ac6da59df374ad38f071b29856df8a2 : HardwiredMemberDescriptor
      {
        internal FLDV_5ac6da59df374ad38f071b29856df8a2()
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

      private sealed class FLDV_b220d50515a84f4eb880be947bd49467 : HardwiredMemberDescriptor
      {
        internal FLDV_b220d50515a84f4eb880be947bd49467()
          : base(typeof (LuaColor), "white", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) LuaColor.white;
        }
      }
    }

    private sealed class TYPE_81c4126b4d474b99a4c18a6012df0c8c : HardwiredUserDataDescriptor
    {
      internal TYPE_81c4126b4d474b99a4c18a6012df0c8c()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_81c4126b4d474b99a4c18a6012df0c8c.MTHD_6f3a080eff6d429bbfe32fcfe3aac194()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_81c4126b4d474b99a4c18a6012df0c8c.MTHD_5cefbb1668f4448abd8bfdca7436647f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_81c4126b4d474b99a4c18a6012df0c8c.MTHD_81801219597147e5896cca401787f0a1()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_81c4126b4d474b99a4c18a6012df0c8c.MTHD_8fa2b6adda3e4e44820ae9380a008735()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_81c4126b4d474b99a4c18a6012df0c8c.MTHD_3d28f189ba6f45718661079fb7c7a19e()
        }));
      }

      private sealed class MTHD_6f3a080eff6d429bbfe32fcfe3aac194 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6f3a080eff6d429bbfe32fcfe3aac194()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_5cefbb1668f4448abd8bfdca7436647f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5cefbb1668f4448abd8bfdca7436647f()
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

      private sealed class MTHD_81801219597147e5896cca401787f0a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_81801219597147e5896cca401787f0a1()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_8fa2b6adda3e4e44820ae9380a008735 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8fa2b6adda3e4e44820ae9380a008735()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_3d28f189ba6f45718661079fb7c7a19e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d28f189ba6f45718661079fb7c7a19e()
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
