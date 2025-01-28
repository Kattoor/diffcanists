
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
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_99344bfd6f124034be47a0b498685806());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_a39dbca03a4340beb2a7bc74ca6616c4());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_faad6757200f4c039ce12e0dc963e52c());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_62e360517d614f0aaff1ecab4029cdf6());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_db2c11b002e84433980a2e976de1a94e());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_d16d501df73b4655a3eb8da5a9aaa357());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_3135d9a88bef41418b9e3134232da12d());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_694a4de28c60462b8b04689a1e2ffcaf());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_695f3d6b54a44409878437a2de85b915());
    }

    private sealed class TYPE_2117ff548a114d22b6d55ece9454ffb9 : HardwiredUserDataDescriptor
    {
      internal TYPE_2117ff548a114d22b6d55ece9454ffb9()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_53309c7908bf423f800e4f80c9c99e43()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_c57af470d64f4f989586ef05d6e1b2de()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_2ad3e67d32a74188aadbd82411dc9f8e()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_8e41fe6e44a34730a90668b16b3cef48()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_8ad08e4a761b4cbe980dd019b68c8421()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_6d6ac8c33eac4d66b25a2234031e7969()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_58f2e726b32e488f964eaaaa044e5927()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_ae1663fbffe84d96864943f519018d55()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_196936bfcafe4514ab414dcb0bcaf6d8()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_0233d7b14f844381acb5fb6607506ba6()
        }));
        this.AddMember("hideInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("hideInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_86bce0f6759b43bdb8ae8109bbc04f84()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_7e24cecae4734bb9a852dcc7fc56fca0()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_4deae9c1bdbf499cbef13fe325870a90()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_5869214daa9c4f439226cf8fce2e293f()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_f47f3637e9774e479f2b321d2b4fd92a()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_7cc938cd51db46bf8ac99745fd9e0175()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_477937eef3f14a7fae40b5f43747fa3b()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_fdfc64a2460c4ca0a696fdaa4d6b525b()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_c3644d07ecbc40f8b62adc19e6c8a5c1()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_d433e73f3eeb47e793ceceec47068c59()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_78a2cde0093d47a2b5283e468bed1628()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_778e8349af67490a86d9c44250fab91a()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_f420e9afb2c247c69bc1eecef78291dd()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_59f75256d853473fbabc64fcd7fd87c2()
        }));
        this.AddMember("get_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_a23f306e8cd84845bb33fa8498807ac2()
        }));
        this.AddMember("set_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_aef42202737a439f952fd8e939200bda()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_64c71f9e7a3b4872906226e6b8140229()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_20d93d5416e5425d9ae61a5f7d52d901()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_2bc3ea42c402425d8958208a82977593()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_740560a9bf0e41788469085b7a113c14()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_708703aa03204cf388d904ab1e9be4f9()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_0364bf59f6094d4dbb83fcda385602fd()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_f17b7a208b724d0dbc54d9a7fb9ba5f4()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_82c9d2dcae0a41f894e7328eb765bb27()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_a26d4cc7e5814d74b425310e1d51f374()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_4a45a935081e4f638919e0b903bad76a()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_0bf3fdd4c30d4a35894c82b7b85689e2()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_c943399eda3c4e2abd11a4c458d8dee1()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_7aa6d7bc813e401eb717a50788282f10()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_7d5084c5b4184b05afd35b2169d7c46d()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_348429de2be14bafaacb7fa02f288fed()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_e274d1a6b742485c8486bf2cc258783b()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_70062818cacf4522afb0c3e681e762ab()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_34edaf3a549b43a68a727342cd8ac39e()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_7383c6053c3f476eabcbe41adf3883ff()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_ddb529ac3cd9457ca6cae894f5e0ce34()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_269b38ac511d45fa8e4038606090f949()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_018c78290622434389f9d2a746790585()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_2a856304d1904697b2cef39d18089968()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_a9d8f13c4e254095af3ba2c6a5c8c172()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_859e59c5683c4bcd8f874f803ac75ea0()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_50b72801933d47898191484d08741aac()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_b9789a9b58f749978bf9eb9fcd719abd()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_5210444687da41e18520c19bd3f11bc1()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_3eb23c40411e4209994daf7fd444ff97()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_b0fa0acd90f9410da227cc4188665f58()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_ce10b9d376f94092a21c84731093c5a8()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_6101f910c11e48fabcf17a59df6b4e96()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_69f22a3ac9124607bec643b2ec4858fe()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_ee3c7377281e4b6fb8f8fa67edd52425()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_5ea23e642aac4e8080797091eee989f9()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_49c51cebef59420488cdfc57f07dc956()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_87509aab456743d1bd2861e00c2fb75a()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_1af2b55a34d34e83891d8a32816b53bf()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_abe91f9f17424978ac6b9c272432266c()
        }));
        this.AddMember("Dispose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Dispose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_770c800ef8ec4a57aca795107e2ac7e8()
        }));
        this.AddMember("drawImage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawImage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_d93ae3db1a174fae906eabd9b19f8e21()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_f5989a14dd494be39f41c80c5d345466()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_42fc73cbedf34939876eae31f4c70c15()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_7debba289c294339a51394bcc07a4020()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_07c032527bce4d0a8ddbc66d7b9cde11()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_d38ba99d9c32424fae4cf775e82dc60c()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_47d5c6c2ce2e4c739e0b2b3c444fc038()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_ee1ebedf2d3d45b498ce11e0d90982a5()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_964125c1920245d6a290e933aa15d705()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_277ca0129e9b48569e78d6122c941a18()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_6d7ab8dae2824d489970b9a3ce1efbbd()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_93d10797640545debca3c0ecf0662d57()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_7f36ba8495204ab5b6316d1637a73ff5()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_3a386c44477e49ef9b5a80332e679340()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_e1732967a97943b0b166d49404019002()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_aa0d83f8b7484db5aed024d8c09c0f2d()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_8c1673c075b44b4cb355fd1914821a9a()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_7f84cae85b3d4dedbbda1dea53749c93()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_3c567145405c4a328b7b86c1f2c905f4()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_baa0a085a5ee43598df47dec526845c6()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_ad1e5215aaaa44b08e57a03ee7c5b28f()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_3ec9c49da4fd45828da645cf93b96a6a()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_cdef3deaa5d146388c698d215d867957()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_cc6ff750251f4c41b931efa14226133c()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_36565a0b487d4a018b5549a123747882()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_5320d0ed63c9428ea545066c5adf2376()
        }));
        this.AddMember("cameraFollow", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("cameraFollow", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_c5d304c2bffe4645ae61d394cab38921()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_3ac2b6e416a54277893b9d52f177f877()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_c4b4dc8808a64875b836ace5efea0622()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_08fd5ca513cf421aaa1eee32bea757e2()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_52bafd30315d4577be00379a56db5661()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_f6583b53893e42febf7ca9715ac62000()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_35ff8b2764084c55a4b2a1f48a5f28e2(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_76e01875572541d0b47e5b135a16aa3f()
        }));
        this.AddMember("getKeyBinds", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getKeyBinds", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_88c5f0b6ee1f474684f6afd78aa59aad()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_aba7e620a3024c6a8218c7f1a078d111()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_29a853bc217e4c138fb7c2f9a753ab8d()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_513580608dd74ddfa019db8f18e3db35()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.MTHD_1ca88275cbca43debfa527fc66b73738()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_8eefe68ddf224dd1a6fec8983dc98d87());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_cc4b6f5a7ea048179af306d2e13c1019());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_8dc294bc0bc34d95a3c5d1e2a2e6b9bd());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_7f47e00139f84348bf2df76b76f21eff());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_a45f684a20ea40e0a7bf29978b3742db());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_a295f0ba4dd248cb985e60bd3f7cce8e());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_bb51f88846b94d8ea5e225601d2dddbd());
        this.AddMember("allowMinionMovement", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_b23233b148904ea2aff4dfff97c7cce0());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_aa099e1641c64bd0a06c276cee1fd9ce());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_5578a0337b634480912938360d613699());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_b595a2390d6d43b8a801f248327736c2());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_86d595208f9c4a2296b4c89b0a04d013());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_befba1f117c04d64a4b7b38ad51ade25());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_7df4f04c695c47568ab69f6e11f2e632());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_2162b94300c5497ea835e3f8e01ade74());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_dd85c958154147b7b58fb0beb0b0fdd3());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_8d6b25d1bb68463088cd29d41a46f28b());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_bda898e03d844f49baca3bb433edb604());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_58e44a2bdd9a4f97bc2ff27a32635b35());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_093a1a2b305e4a5aa2da4ea777ea9da1());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_18a555b4197b4a57afd5e9257f212ce5());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_bdbbf2e9d3b54874bab0e4091a405e08());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_d2940737d064481089437f1ccf23f0e2());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_843ae03998f941f48c1b0b25aa9d35df());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_dcd93a398fc5450aa60e1e55fe2a7416());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_a45854ea7030487f93f1fcb0f2be4b82());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_e6850a3e9470496db0e67cfb2a614693());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_1fe50234c1a34be28b4001e58ac001e6());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_90312c1ef8c04753bde368c4adf9717b());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_c015f362adc6494995131d06befa8ce0());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_fdc8bb38477d4a9194f5f94a21dca9b3());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_4aa59098010f42edbd5bfb6d841ed762());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_2117ff548a114d22b6d55ece9454ffb9.PROP_8bca3d7328a443619528c8970538fbd1());
      }

      private sealed class MTHD_53309c7908bf423f800e4f80c9c99e43 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_53309c7908bf423f800e4f80c9c99e43()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_c57af470d64f4f989586ef05d6e1b2de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c57af470d64f4f989586ef05d6e1b2de()
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

      private sealed class MTHD_2ad3e67d32a74188aadbd82411dc9f8e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2ad3e67d32a74188aadbd82411dc9f8e()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_8e41fe6e44a34730a90668b16b3cef48 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e41fe6e44a34730a90668b16b3cef48()
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

      private sealed class MTHD_8ad08e4a761b4cbe980dd019b68c8421 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ad08e4a761b4cbe980dd019b68c8421()
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

      private sealed class MTHD_6d6ac8c33eac4d66b25a2234031e7969 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d6ac8c33eac4d66b25a2234031e7969()
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

      private sealed class MTHD_58f2e726b32e488f964eaaaa044e5927 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_58f2e726b32e488f964eaaaa044e5927()
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

      private sealed class MTHD_ae1663fbffe84d96864943f519018d55 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae1663fbffe84d96864943f519018d55()
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

      private sealed class MTHD_196936bfcafe4514ab414dcb0bcaf6d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_196936bfcafe4514ab414dcb0bcaf6d8()
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

      private sealed class MTHD_0233d7b14f844381acb5fb6607506ba6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0233d7b14f844381acb5fb6607506ba6()
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

      private sealed class MTHD_86bce0f6759b43bdb8ae8109bbc04f84 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_86bce0f6759b43bdb8ae8109bbc04f84()
        {
          this.Initialize("hideInfo", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).hideInfo();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_7e24cecae4734bb9a852dcc7fc56fca0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7e24cecae4734bb9a852dcc7fc56fca0()
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

      private sealed class MTHD_4deae9c1bdbf499cbef13fe325870a90 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4deae9c1bdbf499cbef13fe325870a90()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_5869214daa9c4f439226cf8fce2e293f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5869214daa9c4f439226cf8fce2e293f()
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

      private sealed class MTHD_f47f3637e9774e479f2b321d2b4fd92a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f47f3637e9774e479f2b321d2b4fd92a()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_7cc938cd51db46bf8ac99745fd9e0175 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7cc938cd51db46bf8ac99745fd9e0175()
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

      private sealed class MTHD_477937eef3f14a7fae40b5f43747fa3b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_477937eef3f14a7fae40b5f43747fa3b()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_fdfc64a2460c4ca0a696fdaa4d6b525b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fdfc64a2460c4ca0a696fdaa4d6b525b()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_c3644d07ecbc40f8b62adc19e6c8a5c1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c3644d07ecbc40f8b62adc19e6c8a5c1()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_d433e73f3eeb47e793ceceec47068c59 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d433e73f3eeb47e793ceceec47068c59()
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

      private sealed class MTHD_78a2cde0093d47a2b5283e468bed1628 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_78a2cde0093d47a2b5283e468bed1628()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_778e8349af67490a86d9c44250fab91a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_778e8349af67490a86d9c44250fab91a()
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

      private sealed class MTHD_f420e9afb2c247c69bc1eecef78291dd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f420e9afb2c247c69bc1eecef78291dd()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_59f75256d853473fbabc64fcd7fd87c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_59f75256d853473fbabc64fcd7fd87c2()
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

      private sealed class MTHD_a23f306e8cd84845bb33fa8498807ac2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a23f306e8cd84845bb33fa8498807ac2()
        {
          this.Initialize("get_allowMinionMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMinionMovement;
        }
      }

      private sealed class MTHD_aef42202737a439f952fd8e939200bda : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aef42202737a439f952fd8e939200bda()
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

      private sealed class MTHD_64c71f9e7a3b4872906226e6b8140229 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_64c71f9e7a3b4872906226e6b8140229()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_20d93d5416e5425d9ae61a5f7d52d901 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_20d93d5416e5425d9ae61a5f7d52d901()
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

      private sealed class MTHD_2bc3ea42c402425d8958208a82977593 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2bc3ea42c402425d8958208a82977593()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_740560a9bf0e41788469085b7a113c14 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_740560a9bf0e41788469085b7a113c14()
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

      private sealed class MTHD_708703aa03204cf388d904ab1e9be4f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_708703aa03204cf388d904ab1e9be4f9()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_0364bf59f6094d4dbb83fcda385602fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0364bf59f6094d4dbb83fcda385602fd()
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

      private sealed class MTHD_f17b7a208b724d0dbc54d9a7fb9ba5f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f17b7a208b724d0dbc54d9a7fb9ba5f4()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_82c9d2dcae0a41f894e7328eb765bb27 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_82c9d2dcae0a41f894e7328eb765bb27()
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

      private sealed class MTHD_a26d4cc7e5814d74b425310e1d51f374 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a26d4cc7e5814d74b425310e1d51f374()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_4a45a935081e4f638919e0b903bad76a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a45a935081e4f638919e0b903bad76a()
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

      private sealed class MTHD_0bf3fdd4c30d4a35894c82b7b85689e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0bf3fdd4c30d4a35894c82b7b85689e2()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_c943399eda3c4e2abd11a4c458d8dee1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c943399eda3c4e2abd11a4c458d8dee1()
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

      private sealed class MTHD_7aa6d7bc813e401eb717a50788282f10 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7aa6d7bc813e401eb717a50788282f10()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_7d5084c5b4184b05afd35b2169d7c46d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7d5084c5b4184b05afd35b2169d7c46d()
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

      private sealed class MTHD_348429de2be14bafaacb7fa02f288fed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_348429de2be14bafaacb7fa02f288fed()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_e274d1a6b742485c8486bf2cc258783b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e274d1a6b742485c8486bf2cc258783b()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_70062818cacf4522afb0c3e681e762ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70062818cacf4522afb0c3e681e762ab()
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

      private sealed class MTHD_34edaf3a549b43a68a727342cd8ac39e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_34edaf3a549b43a68a727342cd8ac39e()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_7383c6053c3f476eabcbe41adf3883ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7383c6053c3f476eabcbe41adf3883ff()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_ddb529ac3cd9457ca6cae894f5e0ce34 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ddb529ac3cd9457ca6cae894f5e0ce34()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_269b38ac511d45fa8e4038606090f949 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_269b38ac511d45fa8e4038606090f949()
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

      private sealed class MTHD_018c78290622434389f9d2a746790585 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_018c78290622434389f9d2a746790585()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_2a856304d1904697b2cef39d18089968 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a856304d1904697b2cef39d18089968()
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

      private sealed class MTHD_a9d8f13c4e254095af3ba2c6a5c8c172 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a9d8f13c4e254095af3ba2c6a5c8c172()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_859e59c5683c4bcd8f874f803ac75ea0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_859e59c5683c4bcd8f874f803ac75ea0()
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

      private sealed class MTHD_50b72801933d47898191484d08741aac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_50b72801933d47898191484d08741aac()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_b9789a9b58f749978bf9eb9fcd719abd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b9789a9b58f749978bf9eb9fcd719abd()
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

      private sealed class MTHD_5210444687da41e18520c19bd3f11bc1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5210444687da41e18520c19bd3f11bc1()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_3eb23c40411e4209994daf7fd444ff97 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3eb23c40411e4209994daf7fd444ff97()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_b0fa0acd90f9410da227cc4188665f58 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b0fa0acd90f9410da227cc4188665f58()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_ce10b9d376f94092a21c84731093c5a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ce10b9d376f94092a21c84731093c5a8()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_6101f910c11e48fabcf17a59df6b4e96 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6101f910c11e48fabcf17a59df6b4e96()
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

      private sealed class MTHD_69f22a3ac9124607bec643b2ec4858fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69f22a3ac9124607bec643b2ec4858fe()
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

      private sealed class MTHD_ee3c7377281e4b6fb8f8fa67edd52425 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee3c7377281e4b6fb8f8fa67edd52425()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_5ea23e642aac4e8080797091eee989f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ea23e642aac4e8080797091eee989f9()
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

      private sealed class MTHD_49c51cebef59420488cdfc57f07dc956 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49c51cebef59420488cdfc57f07dc956()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_87509aab456743d1bd2861e00c2fb75a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_87509aab456743d1bd2861e00c2fb75a()
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

      private sealed class MTHD_1af2b55a34d34e83891d8a32816b53bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1af2b55a34d34e83891d8a32816b53bf()
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

      private sealed class MTHD_abe91f9f17424978ac6b9c272432266c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_abe91f9f17424978ac6b9c272432266c()
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

      private sealed class MTHD_770c800ef8ec4a57aca795107e2ac7e8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_770c800ef8ec4a57aca795107e2ac7e8()
        {
          this.Initialize("Dispose", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ContainerGame.Dispose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_d93ae3db1a174fae906eabd9b19f8e21 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d93ae3db1a174fae906eabd9b19f8e21()
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

      private sealed class MTHD_f5989a14dd494be39f41c80c5d345466 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f5989a14dd494be39f41c80c5d345466()
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

      private sealed class MTHD_42fc73cbedf34939876eae31f4c70c15 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42fc73cbedf34939876eae31f4c70c15()
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

      private sealed class MTHD_7debba289c294339a51394bcc07a4020 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7debba289c294339a51394bcc07a4020()
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

      private sealed class MTHD_07c032527bce4d0a8ddbc66d7b9cde11 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_07c032527bce4d0a8ddbc66d7b9cde11()
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

      private sealed class MTHD_d38ba99d9c32424fae4cf775e82dc60c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d38ba99d9c32424fae4cf775e82dc60c()
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

      private sealed class MTHD_47d5c6c2ce2e4c739e0b2b3c444fc038 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_47d5c6c2ce2e4c739e0b2b3c444fc038()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ee1ebedf2d3d45b498ce11e0d90982a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee1ebedf2d3d45b498ce11e0d90982a5()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_964125c1920245d6a290e933aa15d705 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_964125c1920245d6a290e933aa15d705()
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

      private sealed class MTHD_277ca0129e9b48569e78d6122c941a18 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_277ca0129e9b48569e78d6122c941a18()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_6d7ab8dae2824d489970b9a3ce1efbbd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d7ab8dae2824d489970b9a3ce1efbbd()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_93d10797640545debca3c0ecf0662d57 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93d10797640545debca3c0ecf0662d57()
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

      private sealed class MTHD_7f36ba8495204ab5b6316d1637a73ff5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f36ba8495204ab5b6316d1637a73ff5()
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

      private sealed class MTHD_3a386c44477e49ef9b5a80332e679340 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3a386c44477e49ef9b5a80332e679340()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_e1732967a97943b0b166d49404019002 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e1732967a97943b0b166d49404019002()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_aa0d83f8b7484db5aed024d8c09c0f2d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa0d83f8b7484db5aed024d8c09c0f2d()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_8c1673c075b44b4cb355fd1914821a9a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c1673c075b44b4cb355fd1914821a9a()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_7f84cae85b3d4dedbbda1dea53749c93 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f84cae85b3d4dedbbda1dea53749c93()
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

      private sealed class MTHD_3c567145405c4a328b7b86c1f2c905f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3c567145405c4a328b7b86c1f2c905f4()
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

      private sealed class MTHD_baa0a085a5ee43598df47dec526845c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_baa0a085a5ee43598df47dec526845c6()
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

      private sealed class MTHD_ad1e5215aaaa44b08e57a03ee7c5b28f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ad1e5215aaaa44b08e57a03ee7c5b28f()
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

      private sealed class MTHD_3ec9c49da4fd45828da645cf93b96a6a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3ec9c49da4fd45828da645cf93b96a6a()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_cdef3deaa5d146388c698d215d867957 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cdef3deaa5d146388c698d215d867957()
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

      private sealed class MTHD_cc6ff750251f4c41b931efa14226133c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cc6ff750251f4c41b931efa14226133c()
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

      private sealed class MTHD_36565a0b487d4a018b5549a123747882 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_36565a0b487d4a018b5549a123747882()
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

      private sealed class MTHD_5320d0ed63c9428ea545066c5adf2376 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5320d0ed63c9428ea545066c5adf2376()
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

      private sealed class MTHD_c5d304c2bffe4645ae61d394cab38921 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c5d304c2bffe4645ae61d394cab38921()
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

      private sealed class MTHD_3ac2b6e416a54277893b9d52f177f877 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3ac2b6e416a54277893b9d52f177f877()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_c4b4dc8808a64875b836ace5efea0622 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c4b4dc8808a64875b836ace5efea0622()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_08fd5ca513cf421aaa1eee32bea757e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_08fd5ca513cf421aaa1eee32bea757e2()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_52bafd30315d4577be00379a56db5661 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52bafd30315d4577be00379a56db5661()
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

      private sealed class MTHD_f6583b53893e42febf7ca9715ac62000 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f6583b53893e42febf7ca9715ac62000()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_35ff8b2764084c55a4b2a1f48a5f28e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35ff8b2764084c55a4b2a1f48a5f28e2()
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

      private sealed class MTHD_76e01875572541d0b47e5b135a16aa3f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76e01875572541d0b47e5b135a16aa3f()
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

      private sealed class MTHD_88c5f0b6ee1f474684f6afd78aa59aad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_88c5f0b6ee1f474684f6afd78aa59aad()
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

      private sealed class MTHD_aba7e620a3024c6a8218c7f1a078d111 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aba7e620a3024c6a8218c7f1a078d111()
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

      private sealed class MTHD_29a853bc217e4c138fb7c2f9a753ab8d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_29a853bc217e4c138fb7c2f9a753ab8d()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_513580608dd74ddfa019db8f18e3db35 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_513580608dd74ddfa019db8f18e3db35()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_1ca88275cbca43debfa527fc66b73738 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ca88275cbca43debfa527fc66b73738()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_8eefe68ddf224dd1a6fec8983dc98d87 : HardwiredMemberDescriptor
      {
        internal PROP_8eefe68ddf224dd1a6fec8983dc98d87()
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

      private sealed class PROP_cc4b6f5a7ea048179af306d2e13c1019 : HardwiredMemberDescriptor
      {
        internal PROP_cc4b6f5a7ea048179af306d2e13c1019()
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

      private sealed class PROP_8dc294bc0bc34d95a3c5d1e2a2e6b9bd : HardwiredMemberDescriptor
      {
        internal PROP_8dc294bc0bc34d95a3c5d1e2a2e6b9bd()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_7f47e00139f84348bf2df76b76f21eff : HardwiredMemberDescriptor
      {
        internal PROP_7f47e00139f84348bf2df76b76f21eff()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_a45f684a20ea40e0a7bf29978b3742db : HardwiredMemberDescriptor
      {
        internal PROP_a45f684a20ea40e0a7bf29978b3742db()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_a295f0ba4dd248cb985e60bd3f7cce8e : HardwiredMemberDescriptor
      {
        internal PROP_a295f0ba4dd248cb985e60bd3f7cce8e()
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

      private sealed class PROP_bb51f88846b94d8ea5e225601d2dddbd : HardwiredMemberDescriptor
      {
        internal PROP_bb51f88846b94d8ea5e225601d2dddbd()
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

      private sealed class PROP_b23233b148904ea2aff4dfff97c7cce0 : HardwiredMemberDescriptor
      {
        internal PROP_b23233b148904ea2aff4dfff97c7cce0()
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

      private sealed class PROP_aa099e1641c64bd0a06c276cee1fd9ce : HardwiredMemberDescriptor
      {
        internal PROP_aa099e1641c64bd0a06c276cee1fd9ce()
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

      private sealed class PROP_5578a0337b634480912938360d613699 : HardwiredMemberDescriptor
      {
        internal PROP_5578a0337b634480912938360d613699()
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

      private sealed class PROP_b595a2390d6d43b8a801f248327736c2 : HardwiredMemberDescriptor
      {
        internal PROP_b595a2390d6d43b8a801f248327736c2()
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

      private sealed class PROP_86d595208f9c4a2296b4c89b0a04d013 : HardwiredMemberDescriptor
      {
        internal PROP_86d595208f9c4a2296b4c89b0a04d013()
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

      private sealed class PROP_befba1f117c04d64a4b7b38ad51ade25 : HardwiredMemberDescriptor
      {
        internal PROP_befba1f117c04d64a4b7b38ad51ade25()
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

      private sealed class PROP_7df4f04c695c47568ab69f6e11f2e632 : HardwiredMemberDescriptor
      {
        internal PROP_7df4f04c695c47568ab69f6e11f2e632()
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

      private sealed class PROP_2162b94300c5497ea835e3f8e01ade74 : HardwiredMemberDescriptor
      {
        internal PROP_2162b94300c5497ea835e3f8e01ade74()
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

      private sealed class PROP_dd85c958154147b7b58fb0beb0b0fdd3 : HardwiredMemberDescriptor
      {
        internal PROP_dd85c958154147b7b58fb0beb0b0fdd3()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_8d6b25d1bb68463088cd29d41a46f28b : HardwiredMemberDescriptor
      {
        internal PROP_8d6b25d1bb68463088cd29d41a46f28b()
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

      private sealed class PROP_bda898e03d844f49baca3bb433edb604 : HardwiredMemberDescriptor
      {
        internal PROP_bda898e03d844f49baca3bb433edb604()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_58e44a2bdd9a4f97bc2ff27a32635b35 : HardwiredMemberDescriptor
      {
        internal PROP_58e44a2bdd9a4f97bc2ff27a32635b35()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_093a1a2b305e4a5aa2da4ea777ea9da1 : HardwiredMemberDescriptor
      {
        internal PROP_093a1a2b305e4a5aa2da4ea777ea9da1()
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

      private sealed class PROP_18a555b4197b4a57afd5e9257f212ce5 : HardwiredMemberDescriptor
      {
        internal PROP_18a555b4197b4a57afd5e9257f212ce5()
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

      private sealed class PROP_bdbbf2e9d3b54874bab0e4091a405e08 : HardwiredMemberDescriptor
      {
        internal PROP_bdbbf2e9d3b54874bab0e4091a405e08()
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

      private sealed class PROP_d2940737d064481089437f1ccf23f0e2 : HardwiredMemberDescriptor
      {
        internal PROP_d2940737d064481089437f1ccf23f0e2()
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

      private sealed class PROP_843ae03998f941f48c1b0b25aa9d35df : HardwiredMemberDescriptor
      {
        internal PROP_843ae03998f941f48c1b0b25aa9d35df()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_dcd93a398fc5450aa60e1e55fe2a7416 : HardwiredMemberDescriptor
      {
        internal PROP_dcd93a398fc5450aa60e1e55fe2a7416()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_a45854ea7030487f93f1fcb0f2be4b82 : HardwiredMemberDescriptor
      {
        internal PROP_a45854ea7030487f93f1fcb0f2be4b82()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_e6850a3e9470496db0e67cfb2a614693 : HardwiredMemberDescriptor
      {
        internal PROP_e6850a3e9470496db0e67cfb2a614693()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_1fe50234c1a34be28b4001e58ac001e6 : HardwiredMemberDescriptor
      {
        internal PROP_1fe50234c1a34be28b4001e58ac001e6()
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

      private sealed class PROP_90312c1ef8c04753bde368c4adf9717b : HardwiredMemberDescriptor
      {
        internal PROP_90312c1ef8c04753bde368c4adf9717b()
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

      private sealed class PROP_c015f362adc6494995131d06befa8ce0 : HardwiredMemberDescriptor
      {
        internal PROP_c015f362adc6494995131d06befa8ce0()
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

      private sealed class PROP_fdc8bb38477d4a9194f5f94a21dca9b3 : HardwiredMemberDescriptor
      {
        internal PROP_fdc8bb38477d4a9194f5f94a21dca9b3()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_4aa59098010f42edbd5bfb6d841ed762 : HardwiredMemberDescriptor
      {
        internal PROP_4aa59098010f42edbd5bfb6d841ed762()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_8bca3d7328a443619528c8970538fbd1 : HardwiredMemberDescriptor
      {
        internal PROP_8bca3d7328a443619528c8970538fbd1()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_99344bfd6f124034be47a0b498685806 : HardwiredUserDataDescriptor
    {
      internal TYPE_99344bfd6f124034be47a0b498685806()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_99344bfd6f124034be47a0b498685806.MTHD_af68ff4b2cc4471aa589d73d9550ad88()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_99344bfd6f124034be47a0b498685806.MTHD_3cf6d7c5561c4df094eeef21c6c38d6b()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_99344bfd6f124034be47a0b498685806.MTHD_39470a22fd97491ca5fa3f9eec16013c()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_99344bfd6f124034be47a0b498685806.MTHD_fba525c2a88e498bb4c8da31973d35cd()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_99344bfd6f124034be47a0b498685806.MTHD_7609ba831ed34910b7db2ccc769a1cf6()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_99344bfd6f124034be47a0b498685806.MTHD_d23048cb10a24641acddaa4b3a46b8dd()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_99344bfd6f124034be47a0b498685806.MTHD_6307cb015f8845ce8c4f71b87f193867()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_99344bfd6f124034be47a0b498685806.MTHD_7d407ad246b04ef1b6b014065c6192de()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_99344bfd6f124034be47a0b498685806.MTHD_eb2657b929c245f39d396c61494a1693()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_99344bfd6f124034be47a0b498685806.MTHD_32ec2d9fdd7543aebcee286628386ea6()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_99344bfd6f124034be47a0b498685806.MTHD_74d21956eb244bdda44fb847850dda43()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_99344bfd6f124034be47a0b498685806.MTHD_d5546471ab8b4b6aa4ebb86e265fdb1b()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_99344bfd6f124034be47a0b498685806.PROP_a73aa28fae3145559fafa8ebff7d4307());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_99344bfd6f124034be47a0b498685806.PROP_45b169d8126f4768aa8430d117744465());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_99344bfd6f124034be47a0b498685806.PROP_3d66e42776814030bb4b587fe16e3cde());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_99344bfd6f124034be47a0b498685806.PROP_60538d010a80492e91e82959a7cd7bcd());
      }

      private sealed class MTHD_af68ff4b2cc4471aa589d73d9550ad88 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_af68ff4b2cc4471aa589d73d9550ad88()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_3cf6d7c5561c4df094eeef21c6c38d6b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3cf6d7c5561c4df094eeef21c6c38d6b()
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

      private sealed class MTHD_39470a22fd97491ca5fa3f9eec16013c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_39470a22fd97491ca5fa3f9eec16013c()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_fba525c2a88e498bb4c8da31973d35cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fba525c2a88e498bb4c8da31973d35cd()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_7609ba831ed34910b7db2ccc769a1cf6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7609ba831ed34910b7db2ccc769a1cf6()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_d23048cb10a24641acddaa4b3a46b8dd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d23048cb10a24641acddaa4b3a46b8dd()
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

      private sealed class MTHD_6307cb015f8845ce8c4f71b87f193867 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6307cb015f8845ce8c4f71b87f193867()
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

      private sealed class MTHD_7d407ad246b04ef1b6b014065c6192de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7d407ad246b04ef1b6b014065c6192de()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_eb2657b929c245f39d396c61494a1693 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb2657b929c245f39d396c61494a1693()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_32ec2d9fdd7543aebcee286628386ea6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_32ec2d9fdd7543aebcee286628386ea6()
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

      private sealed class MTHD_74d21956eb244bdda44fb847850dda43 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74d21956eb244bdda44fb847850dda43()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_d5546471ab8b4b6aa4ebb86e265fdb1b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d5546471ab8b4b6aa4ebb86e265fdb1b()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_a73aa28fae3145559fafa8ebff7d4307 : HardwiredMemberDescriptor
      {
        internal PROP_a73aa28fae3145559fafa8ebff7d4307()
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

      private sealed class PROP_45b169d8126f4768aa8430d117744465 : HardwiredMemberDescriptor
      {
        internal PROP_45b169d8126f4768aa8430d117744465()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_3d66e42776814030bb4b587fe16e3cde : HardwiredMemberDescriptor
      {
        internal PROP_3d66e42776814030bb4b587fe16e3cde()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_60538d010a80492e91e82959a7cd7bcd : HardwiredMemberDescriptor
      {
        internal PROP_60538d010a80492e91e82959a7cd7bcd()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_9c9a0719ef2a40868759aa8b15105f2b : HardwiredUserDataDescriptor
    {
      internal TYPE_9c9a0719ef2a40868759aa8b15105f2b()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_d9e92cfa553e4e9a993ce120316cc600()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_ca4767652c1a442dadcdd905169daba4()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_d85ffdc627c840b2b2ce1245714d6c47()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_8ef4e5f3e3304461a01c3441a094dd34()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_1a984578497e40fe94ac152f9516d132()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_83604635cafc408b8303d61a2aa0e79b()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_3f9594aedc864caab2e29196454ecb7b()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_d8c84287e56a4ab28abc833165748bb5()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_74696fbbc43641a9841bf0466db485c0()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_79022dd7e26f4cd1815996f343699087()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_798577f2527e4a1cbfe6d56d31326600()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_39376c8c8c60495c9d6bb083afdfb7ae()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_e43a4007c15645098570dd6d7f674efa()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_14868fde3f4641b3919a5a168df328aa()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_f7f72d646c6041839087dd36ef4385fc()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_cc1b207fbed24a61a849be4ce64b8b88()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_0b6ee9de33794bd1b8d6fdbc4a8ea9a3()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_cb3347c998f24ba79817381aae4a5962()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_75860573d60f41a3a5395b11b7bb25fc()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_13115b8d3e804efdaa89be9337889928()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_020414bc3e544f58aa9858a8952adb70()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_d91a3ed83e29492b8695500f69d71f8a()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_f3324150453a430a914e02c7550e8e84()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_4718160e63ca4fddb159727437c34e27()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_4b1c4992178044689415d69077cfe7f8()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_5cc3f1da01da47e999dd6194a7487074()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_0706233051a84b26b4c4a98155aea138()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_4260219deca44b4b94eab2837adb8fe6()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_092fc8fe35f446cd9e570305f0d8ee62()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_60799ae6deec4210a42b78ab4ad06e5b()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_909d4b383ea84221ae91be8f19898a06()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_271888a2edb44e2d99eda3b90c304813()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_691034b285c149d8a80006e772c9255b()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_93b208192b904bfb88a1f74a7d236f0b()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_5543b682d19d4a7cb0da564612fa1f2b()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_0fd1520e10234f93adc0b1d07a56a365()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_0221d2dc1fb84f20a0d32b1176c6e5a2()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_3da450cb1e084d14ae25b7b5b194e836()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_35ba1ab78be04271885c94b9e1c986bf()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_82b5f84108924d8996612f29b96235ff()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_415560b96f3c4bee92f4cae88ec3c27c()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_edc3adcff6404312b847db08c4e58b47()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_fa199cb9b8ca437a98eaf57bc3ca02e2()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_22814749d4934061a46477f9b37ea20a()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_4c9c6ca75cff46669f64ae1817010edb()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_974aac0988a34969b3da5612e5329556()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_c49b1c691de44bd1b42408fc1430db0f()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_9296b48a31c843bc98822ca8e58365fe()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_dfe53a2055af4aa389d6c696905aafd3()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_b2908f40680640f489917ae9fa4fc76f()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_50f6c623430e4616b43ae7bb7f048cd9()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_34d45a6c8aca4d968c81e5d68ec56cb2()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_6213db9d81d44ae18e6aa2ac9f44c1a1()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_8bb772f0a7da459a8b6ea542996a9763()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_86bf7cfa204c444e80ffd8130fe5438c()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_b3ec1ba1667b459ea914a509456dad0b()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_0937566c06eb42e78a0bd065c85fd1bf()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_6ef533c1842744aeb60451adea2fa9f2()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_4029af3d18e44ad59af0af4fc6fae7d8()
        }));
        this.AddMember("getDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_c520152e98e449a2ac9a7b7eadc97e20()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_d6e5d47ba5ee4fd5953da5340434ae53()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_09eea00d221442e786838fb23116190c()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_d9dcfe28542347f6bb2b09c0c126770f()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_207db96b72b6405dbf3f6d2f42a7e894()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_9f397facf4584c1595931d60c5d3b5e5(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_58577056371b45df95cc698b160a8194()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_7b24a3ea42174859a15e2926483bb80b(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_ba85b11e34fd443c9cc45492d7cb5923()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_9b9eda3df68549618c297eca347705db()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_610c74b97e7648e38d5fcda445db270f()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_520b975612bd40f98e51737ab32e7548(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_32bb8c0661fa4a1ebb8838e8ae5dde01()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_ef099c806cfe476f918a77274796ee5a()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_ed394466fe8d4b2aab4617511efa9631()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_21efd15e19ec425292f15184d6bf4961()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_f096423056f644e4b5b33440b1f87be7()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_5b3598445cb6473d94326cadebb40995()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_f7171e845218427994b0784de9df4693()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_81f34a123ba64edda125dec261a85c02()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_2521a8550c1843e0909d6bbda209dc1f()
        }));
        this.AddMember("angleToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("angleToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_470c261f73344cea8fa7505027ad82de()
        }));
        this.AddMember("powerToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("powerToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_2c36c907d35b45bfae69f9b1c4a557a9()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_51fc07bcc99d4edfa91fcb07b6bfa04e(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_17ebda8f9a5d430e857068d77241eb10()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_6195f5d43e2a4ace836bdef491ba8189(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_f0b614b7848d4f7ab71095319706794f()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_75490f6d574649fd8f0618d21654ef87()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_1dde5b3b072741d7961ae9058ef19502()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_68197441ae9648c29d422241c6991494()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_a7db2a2fe6df49eeaf1e15d25108f9da()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_715812c2e16a4821870ed1e31732db9d()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.MTHD_73399c35ae684297afc135392434cbac()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_477c09d1c49d4057a101433d66a22b9b());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_6be36fd9faf44ecab118cea3a523af84());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_c859fb2817f04a65ac0518008620806d());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_c801fef3a4d2483b8c4e65265371b580());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_6766de82a8244aba8ba6194e36ec0161());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_a0d17c6fcf4e4cf5a02c3a3baf4e2939());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_d4374f1e445246e2aa89686e48d7cc95());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_026394437ad94edc9568a3c3085a1fd7());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_8ce151461e62452d9d3358d392a67242());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_8b582bced85444ea92367bc3aa7391ea());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_3818320023a94f2f9c360eb45de521f9());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_03d79a799da44ae7b1c69b3842771c9f());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_f60823aaafe846b889dcf8d0730b909c());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_831c1e7f2f31456ea24b48322dc1c76a());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_26921ce8f6da4def924d4f05e1234281());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_25c6b1186ff94d81add7204e8bdba11a());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_219e72504da24d7b94038dd2c5462ea3());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_968796d1b81f4e38acb1c4e327761c3c());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_dd771ad591844957a6ec4646e8cdb42d());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_518ac092173f4f13b919648f9f8be625());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_6784fac1023548e18ab5c128de88cd7a());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_7c89d70e000347e3a9fbbb8fee0c1987());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_9758ac322c8c465b8dfcc58137fad5bb());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_f90ac20e74904ce8af02421b4d7568b3());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_e2997f9b55fc4dd6a9aa257cec1533e2());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_3033d058d9754ed6828f20bb2140e0ad());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_13f2222e0a384dbc990763b18e96c410());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_7b132320654e40f884532b0d163aa0b5());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_b3b83249763149c1bc7e53be12226d23());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_4ac78f0c1c59488cac703e7172245db7());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_0577ad9317d74351a5c1a908107c31ab());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_032916636827458aa9e020a5c32b1ced());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_9c9a0719ef2a40868759aa8b15105f2b.PROP_5850cee482314343858f853f4b3d4526());
      }

      private sealed class MTHD_d9e92cfa553e4e9a993ce120316cc600 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d9e92cfa553e4e9a993ce120316cc600()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_ca4767652c1a442dadcdd905169daba4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ca4767652c1a442dadcdd905169daba4()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_d85ffdc627c840b2b2ce1245714d6c47 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d85ffdc627c840b2b2ce1245714d6c47()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_8ef4e5f3e3304461a01c3441a094dd34 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ef4e5f3e3304461a01c3441a094dd34()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_1a984578497e40fe94ac152f9516d132 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a984578497e40fe94ac152f9516d132()
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

      private sealed class MTHD_83604635cafc408b8303d61a2aa0e79b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_83604635cafc408b8303d61a2aa0e79b()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_3f9594aedc864caab2e29196454ecb7b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f9594aedc864caab2e29196454ecb7b()
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

      private sealed class MTHD_d8c84287e56a4ab28abc833165748bb5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8c84287e56a4ab28abc833165748bb5()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_74696fbbc43641a9841bf0466db485c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74696fbbc43641a9841bf0466db485c0()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_79022dd7e26f4cd1815996f343699087 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_79022dd7e26f4cd1815996f343699087()
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

      private sealed class MTHD_798577f2527e4a1cbfe6d56d31326600 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_798577f2527e4a1cbfe6d56d31326600()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_39376c8c8c60495c9d6bb083afdfb7ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_39376c8c8c60495c9d6bb083afdfb7ae()
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

      private sealed class MTHD_e43a4007c15645098570dd6d7f674efa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e43a4007c15645098570dd6d7f674efa()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_14868fde3f4641b3919a5a168df328aa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_14868fde3f4641b3919a5a168df328aa()
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

      private sealed class MTHD_f7f72d646c6041839087dd36ef4385fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7f72d646c6041839087dd36ef4385fc()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_cc1b207fbed24a61a849be4ce64b8b88 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cc1b207fbed24a61a849be4ce64b8b88()
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

      private sealed class MTHD_0b6ee9de33794bd1b8d6fdbc4a8ea9a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b6ee9de33794bd1b8d6fdbc4a8ea9a3()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_cb3347c998f24ba79817381aae4a5962 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cb3347c998f24ba79817381aae4a5962()
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

      private sealed class MTHD_75860573d60f41a3a5395b11b7bb25fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75860573d60f41a3a5395b11b7bb25fc()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_13115b8d3e804efdaa89be9337889928 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_13115b8d3e804efdaa89be9337889928()
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

      private sealed class MTHD_020414bc3e544f58aa9858a8952adb70 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_020414bc3e544f58aa9858a8952adb70()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_d91a3ed83e29492b8695500f69d71f8a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d91a3ed83e29492b8695500f69d71f8a()
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

      private sealed class MTHD_f3324150453a430a914e02c7550e8e84 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f3324150453a430a914e02c7550e8e84()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_4718160e63ca4fddb159727437c34e27 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4718160e63ca4fddb159727437c34e27()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_4b1c4992178044689415d69077cfe7f8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b1c4992178044689415d69077cfe7f8()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_5cc3f1da01da47e999dd6194a7487074 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5cc3f1da01da47e999dd6194a7487074()
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

      private sealed class MTHD_0706233051a84b26b4c4a98155aea138 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0706233051a84b26b4c4a98155aea138()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_4260219deca44b4b94eab2837adb8fe6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4260219deca44b4b94eab2837adb8fe6()
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

      private sealed class MTHD_092fc8fe35f446cd9e570305f0d8ee62 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_092fc8fe35f446cd9e570305f0d8ee62()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_60799ae6deec4210a42b78ab4ad06e5b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60799ae6deec4210a42b78ab4ad06e5b()
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

      private sealed class MTHD_909d4b383ea84221ae91be8f19898a06 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_909d4b383ea84221ae91be8f19898a06()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_271888a2edb44e2d99eda3b90c304813 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_271888a2edb44e2d99eda3b90c304813()
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

      private sealed class MTHD_691034b285c149d8a80006e772c9255b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_691034b285c149d8a80006e772c9255b()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_93b208192b904bfb88a1f74a7d236f0b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93b208192b904bfb88a1f74a7d236f0b()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_5543b682d19d4a7cb0da564612fa1f2b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5543b682d19d4a7cb0da564612fa1f2b()
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

      private sealed class MTHD_0fd1520e10234f93adc0b1d07a56a365 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0fd1520e10234f93adc0b1d07a56a365()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_0221d2dc1fb84f20a0d32b1176c6e5a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0221d2dc1fb84f20a0d32b1176c6e5a2()
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

      private sealed class MTHD_3da450cb1e084d14ae25b7b5b194e836 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3da450cb1e084d14ae25b7b5b194e836()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_35ba1ab78be04271885c94b9e1c986bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35ba1ab78be04271885c94b9e1c986bf()
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

      private sealed class MTHD_82b5f84108924d8996612f29b96235ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_82b5f84108924d8996612f29b96235ff()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_415560b96f3c4bee92f4cae88ec3c27c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_415560b96f3c4bee92f4cae88ec3c27c()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_edc3adcff6404312b847db08c4e58b47 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_edc3adcff6404312b847db08c4e58b47()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_fa199cb9b8ca437a98eaf57bc3ca02e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa199cb9b8ca437a98eaf57bc3ca02e2()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_22814749d4934061a46477f9b37ea20a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22814749d4934061a46477f9b37ea20a()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_4c9c6ca75cff46669f64ae1817010edb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c9c6ca75cff46669f64ae1817010edb()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_974aac0988a34969b3da5612e5329556 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_974aac0988a34969b3da5612e5329556()
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

      private sealed class MTHD_c49b1c691de44bd1b42408fc1430db0f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c49b1c691de44bd1b42408fc1430db0f()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_9296b48a31c843bc98822ca8e58365fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9296b48a31c843bc98822ca8e58365fe()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_dfe53a2055af4aa389d6c696905aafd3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dfe53a2055af4aa389d6c696905aafd3()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_b2908f40680640f489917ae9fa4fc76f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b2908f40680640f489917ae9fa4fc76f()
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

      private sealed class MTHD_50f6c623430e4616b43ae7bb7f048cd9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_50f6c623430e4616b43ae7bb7f048cd9()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_34d45a6c8aca4d968c81e5d68ec56cb2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_34d45a6c8aca4d968c81e5d68ec56cb2()
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

      private sealed class MTHD_6213db9d81d44ae18e6aa2ac9f44c1a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6213db9d81d44ae18e6aa2ac9f44c1a1()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_8bb772f0a7da459a8b6ea542996a9763 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8bb772f0a7da459a8b6ea542996a9763()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_86bf7cfa204c444e80ffd8130fe5438c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_86bf7cfa204c444e80ffd8130fe5438c()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_b3ec1ba1667b459ea914a509456dad0b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b3ec1ba1667b459ea914a509456dad0b()
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

      private sealed class MTHD_0937566c06eb42e78a0bd065c85fd1bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0937566c06eb42e78a0bd065c85fd1bf()
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

      private sealed class MTHD_6ef533c1842744aeb60451adea2fa9f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ef533c1842744aeb60451adea2fa9f2()
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

      private sealed class MTHD_4029af3d18e44ad59af0af4fc6fae7d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4029af3d18e44ad59af0af4fc6fae7d8()
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

      private sealed class MTHD_c520152e98e449a2ac9a7b7eadc97e20 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c520152e98e449a2ac9a7b7eadc97e20()
        {
          this.Initialize("getDirection", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getDirection();
        }
      }

      private sealed class MTHD_d6e5d47ba5ee4fd5953da5340434ae53 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6e5d47ba5ee4fd5953da5340434ae53()
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

      private sealed class MTHD_09eea00d221442e786838fb23116190c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_09eea00d221442e786838fb23116190c()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_d9dcfe28542347f6bb2b09c0c126770f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d9dcfe28542347f6bb2b09c0c126770f()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_207db96b72b6405dbf3f6d2f42a7e894 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_207db96b72b6405dbf3f6d2f42a7e894()
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

      private sealed class MTHD_9f397facf4584c1595931d60c5d3b5e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f397facf4584c1595931d60c5d3b5e5()
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

      private sealed class MTHD_58577056371b45df95cc698b160a8194 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_58577056371b45df95cc698b160a8194()
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

      private sealed class MTHD_7b24a3ea42174859a15e2926483bb80b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b24a3ea42174859a15e2926483bb80b()
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

      private sealed class MTHD_ba85b11e34fd443c9cc45492d7cb5923 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba85b11e34fd443c9cc45492d7cb5923()
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

      private sealed class MTHD_9b9eda3df68549618c297eca347705db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b9eda3df68549618c297eca347705db()
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

      private sealed class MTHD_610c74b97e7648e38d5fcda445db270f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_610c74b97e7648e38d5fcda445db270f()
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

      private sealed class MTHD_520b975612bd40f98e51737ab32e7548 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_520b975612bd40f98e51737ab32e7548()
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

      private sealed class MTHD_32bb8c0661fa4a1ebb8838e8ae5dde01 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_32bb8c0661fa4a1ebb8838e8ae5dde01()
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

      private sealed class MTHD_ef099c806cfe476f918a77274796ee5a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef099c806cfe476f918a77274796ee5a()
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

      private sealed class MTHD_ed394466fe8d4b2aab4617511efa9631 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed394466fe8d4b2aab4617511efa9631()
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

      private sealed class MTHD_21efd15e19ec425292f15184d6bf4961 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_21efd15e19ec425292f15184d6bf4961()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_f096423056f644e4b5b33440b1f87be7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f096423056f644e4b5b33440b1f87be7()
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

      private sealed class MTHD_5b3598445cb6473d94326cadebb40995 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b3598445cb6473d94326cadebb40995()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_f7171e845218427994b0784de9df4693 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7171e845218427994b0784de9df4693()
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

      private sealed class MTHD_81f34a123ba64edda125dec261a85c02 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_81f34a123ba64edda125dec261a85c02()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_2521a8550c1843e0909d6bbda209dc1f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2521a8550c1843e0909d6bbda209dc1f()
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

      private sealed class MTHD_470c261f73344cea8fa7505027ad82de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_470c261f73344cea8fa7505027ad82de()
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

      private sealed class MTHD_2c36c907d35b45bfae69f9b1c4a557a9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c36c907d35b45bfae69f9b1c4a557a9()
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

      private sealed class MTHD_51fc07bcc99d4edfa91fcb07b6bfa04e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_51fc07bcc99d4edfa91fcb07b6bfa04e()
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

      private sealed class MTHD_17ebda8f9a5d430e857068d77241eb10 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_17ebda8f9a5d430e857068d77241eb10()
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

      private sealed class MTHD_6195f5d43e2a4ace836bdef491ba8189 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6195f5d43e2a4ace836bdef491ba8189()
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

      private sealed class MTHD_f0b614b7848d4f7ab71095319706794f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f0b614b7848d4f7ab71095319706794f()
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

      private sealed class MTHD_75490f6d574649fd8f0618d21654ef87 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75490f6d574649fd8f0618d21654ef87()
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

      private sealed class MTHD_1dde5b3b072741d7961ae9058ef19502 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1dde5b3b072741d7961ae9058ef19502()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_68197441ae9648c29d422241c6991494 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_68197441ae9648c29d422241c6991494()
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

      private sealed class MTHD_a7db2a2fe6df49eeaf1e15d25108f9da : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a7db2a2fe6df49eeaf1e15d25108f9da()
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

      private sealed class MTHD_715812c2e16a4821870ed1e31732db9d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_715812c2e16a4821870ed1e31732db9d()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_73399c35ae684297afc135392434cbac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_73399c35ae684297afc135392434cbac()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_477c09d1c49d4057a101433d66a22b9b : HardwiredMemberDescriptor
      {
        internal PROP_477c09d1c49d4057a101433d66a22b9b()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_6be36fd9faf44ecab118cea3a523af84 : HardwiredMemberDescriptor
      {
        internal PROP_6be36fd9faf44ecab118cea3a523af84()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_c859fb2817f04a65ac0518008620806d : HardwiredMemberDescriptor
      {
        internal PROP_c859fb2817f04a65ac0518008620806d()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_c801fef3a4d2483b8c4e65265371b580 : HardwiredMemberDescriptor
      {
        internal PROP_c801fef3a4d2483b8c4e65265371b580()
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

      private sealed class PROP_6766de82a8244aba8ba6194e36ec0161 : HardwiredMemberDescriptor
      {
        internal PROP_6766de82a8244aba8ba6194e36ec0161()
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

      private sealed class PROP_a0d17c6fcf4e4cf5a02c3a3baf4e2939 : HardwiredMemberDescriptor
      {
        internal PROP_a0d17c6fcf4e4cf5a02c3a3baf4e2939()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_d4374f1e445246e2aa89686e48d7cc95 : HardwiredMemberDescriptor
      {
        internal PROP_d4374f1e445246e2aa89686e48d7cc95()
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

      private sealed class PROP_026394437ad94edc9568a3c3085a1fd7 : HardwiredMemberDescriptor
      {
        internal PROP_026394437ad94edc9568a3c3085a1fd7()
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

      private sealed class PROP_8ce151461e62452d9d3358d392a67242 : HardwiredMemberDescriptor
      {
        internal PROP_8ce151461e62452d9d3358d392a67242()
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

      private sealed class PROP_8b582bced85444ea92367bc3aa7391ea : HardwiredMemberDescriptor
      {
        internal PROP_8b582bced85444ea92367bc3aa7391ea()
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

      private sealed class PROP_3818320023a94f2f9c360eb45de521f9 : HardwiredMemberDescriptor
      {
        internal PROP_3818320023a94f2f9c360eb45de521f9()
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

      private sealed class PROP_03d79a799da44ae7b1c69b3842771c9f : HardwiredMemberDescriptor
      {
        internal PROP_03d79a799da44ae7b1c69b3842771c9f()
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

      private sealed class PROP_f60823aaafe846b889dcf8d0730b909c : HardwiredMemberDescriptor
      {
        internal PROP_f60823aaafe846b889dcf8d0730b909c()
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

      private sealed class PROP_831c1e7f2f31456ea24b48322dc1c76a : HardwiredMemberDescriptor
      {
        internal PROP_831c1e7f2f31456ea24b48322dc1c76a()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_26921ce8f6da4def924d4f05e1234281 : HardwiredMemberDescriptor
      {
        internal PROP_26921ce8f6da4def924d4f05e1234281()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_25c6b1186ff94d81add7204e8bdba11a : HardwiredMemberDescriptor
      {
        internal PROP_25c6b1186ff94d81add7204e8bdba11a()
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

      private sealed class PROP_219e72504da24d7b94038dd2c5462ea3 : HardwiredMemberDescriptor
      {
        internal PROP_219e72504da24d7b94038dd2c5462ea3()
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

      private sealed class PROP_968796d1b81f4e38acb1c4e327761c3c : HardwiredMemberDescriptor
      {
        internal PROP_968796d1b81f4e38acb1c4e327761c3c()
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

      private sealed class PROP_dd771ad591844957a6ec4646e8cdb42d : HardwiredMemberDescriptor
      {
        internal PROP_dd771ad591844957a6ec4646e8cdb42d()
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

      private sealed class PROP_518ac092173f4f13b919648f9f8be625 : HardwiredMemberDescriptor
      {
        internal PROP_518ac092173f4f13b919648f9f8be625()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_6784fac1023548e18ab5c128de88cd7a : HardwiredMemberDescriptor
      {
        internal PROP_6784fac1023548e18ab5c128de88cd7a()
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

      private sealed class PROP_7c89d70e000347e3a9fbbb8fee0c1987 : HardwiredMemberDescriptor
      {
        internal PROP_7c89d70e000347e3a9fbbb8fee0c1987()
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

      private sealed class PROP_9758ac322c8c465b8dfcc58137fad5bb : HardwiredMemberDescriptor
      {
        internal PROP_9758ac322c8c465b8dfcc58137fad5bb()
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

      private sealed class PROP_f90ac20e74904ce8af02421b4d7568b3 : HardwiredMemberDescriptor
      {
        internal PROP_f90ac20e74904ce8af02421b4d7568b3()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_e2997f9b55fc4dd6a9aa257cec1533e2 : HardwiredMemberDescriptor
      {
        internal PROP_e2997f9b55fc4dd6a9aa257cec1533e2()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_3033d058d9754ed6828f20bb2140e0ad : HardwiredMemberDescriptor
      {
        internal PROP_3033d058d9754ed6828f20bb2140e0ad()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_13f2222e0a384dbc990763b18e96c410 : HardwiredMemberDescriptor
      {
        internal PROP_13f2222e0a384dbc990763b18e96c410()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_7b132320654e40f884532b0d163aa0b5 : HardwiredMemberDescriptor
      {
        internal PROP_7b132320654e40f884532b0d163aa0b5()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_b3b83249763149c1bc7e53be12226d23 : HardwiredMemberDescriptor
      {
        internal PROP_b3b83249763149c1bc7e53be12226d23()
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

      private sealed class PROP_4ac78f0c1c59488cac703e7172245db7 : HardwiredMemberDescriptor
      {
        internal PROP_4ac78f0c1c59488cac703e7172245db7()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_0577ad9317d74351a5c1a908107c31ab : HardwiredMemberDescriptor
      {
        internal PROP_0577ad9317d74351a5c1a908107c31ab()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_032916636827458aa9e020a5c32b1ced : HardwiredMemberDescriptor
      {
        internal PROP_032916636827458aa9e020a5c32b1ced()
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

      private sealed class PROP_5850cee482314343858f853f4b3d4526 : HardwiredMemberDescriptor
      {
        internal PROP_5850cee482314343858f853f4b3d4526()
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

    private sealed class TYPE_bc5553ffd50a47f9a18373fa26841a20 : HardwiredUserDataDescriptor
    {
      internal TYPE_bc5553ffd50a47f9a18373fa26841a20()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.MTHD_7383bb6af9ba4a1091010a84211974a9()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.MTHD_dab34471aa1e44569d6818f389ce44db()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.MTHD_ee47aafa3c8f4a92af28aee85e6292e5()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.MTHD_f9209b48d0ab4bd7855ba8f3f8bf677e()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.MTHD_bd407fbbcaf84937bdda532a096c07a6()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.MTHD_6cd30522737043d4af3129508f6e559f()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.MTHD_488e76242a4d4626963a0803d36bcd80()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.MTHD_e2760c0e355e487a81c587ee18a85ffb()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.MTHD_ab49bc9480a147cf9b1b110be0239e64()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.MTHD_d888ce9cdf17458cb92caf39cb6efece()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.MTHD_f6c9f6f78b5d4579a166c2d0e981a5ed()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.MTHD_792e9d4b34d2424bb660a80656d757cd()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.MTHD_9f4c16ac153b430cb3f4e36305c94de2()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.MTHD_cdae48623ea04769a64c2d6e375ba8fb()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.MTHD_e401fb9db94c4b999c14c347d276f131()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.MTHD_e7082b79b9ea4f4b9fb22cfe2f5304ee()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.MTHD_ff1d689541aa4a9384b5f4c0a6b7a919()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.MTHD_0246b58cdcb24c8b98838db6948a9108()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.MTHD_eae6566d135b4e73a9ab52b57ac6c961()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.MTHD_e816f9d66cf44be98a361804b596c167()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.PROP_0abb812180cd4d529448129773e27575());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.PROP_608e4fb4b56c446caa81794524b7f57d());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.PROP_5d8f7e23e20a426c9a267a8786dd7740());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.PROP_3ddb269087dd45e4a444febf82c9057e());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.PROP_746ee6e2496744faac36f813c35826c1());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.PROP_edb563fa94094cfe921b5ddc4c6e1067());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.PROP_d2b6ee776c264763ba6bc6656b1a8758());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_bc5553ffd50a47f9a18373fa26841a20.PROP_65f24f7abee94a31bff70d3fff1bd399());
      }

      private sealed class MTHD_7383bb6af9ba4a1091010a84211974a9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7383bb6af9ba4a1091010a84211974a9()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_dab34471aa1e44569d6818f389ce44db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dab34471aa1e44569d6818f389ce44db()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_ee47aafa3c8f4a92af28aee85e6292e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee47aafa3c8f4a92af28aee85e6292e5()
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

      private sealed class MTHD_f9209b48d0ab4bd7855ba8f3f8bf677e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f9209b48d0ab4bd7855ba8f3f8bf677e()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_bd407fbbcaf84937bdda532a096c07a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd407fbbcaf84937bdda532a096c07a6()
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

      private sealed class MTHD_6cd30522737043d4af3129508f6e559f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6cd30522737043d4af3129508f6e559f()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_488e76242a4d4626963a0803d36bcd80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_488e76242a4d4626963a0803d36bcd80()
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

      private sealed class MTHD_e2760c0e355e487a81c587ee18a85ffb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e2760c0e355e487a81c587ee18a85ffb()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_ab49bc9480a147cf9b1b110be0239e64 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab49bc9480a147cf9b1b110be0239e64()
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

      private sealed class MTHD_d888ce9cdf17458cb92caf39cb6efece : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d888ce9cdf17458cb92caf39cb6efece()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_f6c9f6f78b5d4579a166c2d0e981a5ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f6c9f6f78b5d4579a166c2d0e981a5ed()
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

      private sealed class MTHD_792e9d4b34d2424bb660a80656d757cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_792e9d4b34d2424bb660a80656d757cd()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_9f4c16ac153b430cb3f4e36305c94de2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f4c16ac153b430cb3f4e36305c94de2()
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

      private sealed class MTHD_cdae48623ea04769a64c2d6e375ba8fb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cdae48623ea04769a64c2d6e375ba8fb()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_e401fb9db94c4b999c14c347d276f131 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e401fb9db94c4b999c14c347d276f131()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_e7082b79b9ea4f4b9fb22cfe2f5304ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7082b79b9ea4f4b9fb22cfe2f5304ee()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ff1d689541aa4a9384b5f4c0a6b7a919 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff1d689541aa4a9384b5f4c0a6b7a919()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_0246b58cdcb24c8b98838db6948a9108 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0246b58cdcb24c8b98838db6948a9108()
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

      private sealed class MTHD_eae6566d135b4e73a9ab52b57ac6c961 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eae6566d135b4e73a9ab52b57ac6c961()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_e816f9d66cf44be98a361804b596c167 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e816f9d66cf44be98a361804b596c167()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_0abb812180cd4d529448129773e27575 : HardwiredMemberDescriptor
      {
        internal PROP_0abb812180cd4d529448129773e27575()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_608e4fb4b56c446caa81794524b7f57d : HardwiredMemberDescriptor
      {
        internal PROP_608e4fb4b56c446caa81794524b7f57d()
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

      private sealed class PROP_5d8f7e23e20a426c9a267a8786dd7740 : HardwiredMemberDescriptor
      {
        internal PROP_5d8f7e23e20a426c9a267a8786dd7740()
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

      private sealed class PROP_3ddb269087dd45e4a444febf82c9057e : HardwiredMemberDescriptor
      {
        internal PROP_3ddb269087dd45e4a444febf82c9057e()
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

      private sealed class PROP_746ee6e2496744faac36f813c35826c1 : HardwiredMemberDescriptor
      {
        internal PROP_746ee6e2496744faac36f813c35826c1()
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

      private sealed class PROP_edb563fa94094cfe921b5ddc4c6e1067 : HardwiredMemberDescriptor
      {
        internal PROP_edb563fa94094cfe921b5ddc4c6e1067()
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

      private sealed class PROP_d2b6ee776c264763ba6bc6656b1a8758 : HardwiredMemberDescriptor
      {
        internal PROP_d2b6ee776c264763ba6bc6656b1a8758()
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

      private sealed class PROP_65f24f7abee94a31bff70d3fff1bd399 : HardwiredMemberDescriptor
      {
        internal PROP_65f24f7abee94a31bff70d3fff1bd399()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_2475d899a184439f9487dd6437305dd6 : HardwiredUserDataDescriptor
    {
      internal TYPE_2475d899a184439f9487dd6437305dd6()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.MTHD_e0f38c099b564d1298892da8acdf6f33()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.MTHD_1730656bafcd4a47bbaceb52b9a9e7ec()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.MTHD_15a8cd671c60416c824d174f1748cd57()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.MTHD_415b24febafd43de958716fe7bc8ab5d()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.MTHD_5e758a99244447a89cbbdcd81ba0423b()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.MTHD_28e90e1363204dbf9fef654dfded67a1()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.MTHD_c0ce76e81de3410eb7d0908290eb6d0f()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.MTHD_a007cbee54784e2a9d7f0f7187bd50be()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.MTHD_f2805b42d22148a1b87f24dd93fc7ccc()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.MTHD_93fae98e64fb48dc9c46d4446e51b88b()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.MTHD_22f26bfb176747c89b180ebbf7df8e78()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.MTHD_4f8ace1450e34316b07fc41839cc4cd9()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.MTHD_f0ea9e2ae4e74797b276f324e762c2fa()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.MTHD_a7c28248c74e48a3bc45ba16f44fc33e()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.MTHD_244f2ef4bd584ec7a4e55cb589e45c68()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.MTHD_7189b086a5634b49bf4f06b42c6ce42b()
        }));
        this.AddMember("setIcon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setIcon", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.MTHD_65c51659fc474e0da377a030942c6144()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.MTHD_506f98304ec043d9acd9ced58c766863()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.MTHD_e3b9ea0b4fb0452f94dacd3f632b981b()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.MTHD_c69d93a9cbe340b9b6102d3c5bc74e69()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.MTHD_b76974b8de2e4317bca164ba33f05d9d()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.MTHD_1d235ba19c42474a8d6c73b5c64e63dc()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.PROP_34651285e6e04057938605708f322a7a());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.PROP_6c91bbfb0fa34b79b2a54a4324bbc385());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.PROP_f7ee9b01825f4a7fb8121249c8db52d8());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.PROP_a24ddee00a724e4399cb830b5c3a3337());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.PROP_2b11db70fe9f40028883261f8c818295());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.PROP_03a6057031e24d03b92be41c3a723064());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.PROP_b253cfec2976443591dc72dd699b9361());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.PROP_6445b56dc5cb42b2862d1c74affc2b1b());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_2475d899a184439f9487dd6437305dd6.PROP_c016bd85b8404ddba7e2b291f5283ae2());
      }

      private sealed class MTHD_e0f38c099b564d1298892da8acdf6f33 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e0f38c099b564d1298892da8acdf6f33()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_1730656bafcd4a47bbaceb52b9a9e7ec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1730656bafcd4a47bbaceb52b9a9e7ec()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_15a8cd671c60416c824d174f1748cd57 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15a8cd671c60416c824d174f1748cd57()
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

      private sealed class MTHD_415b24febafd43de958716fe7bc8ab5d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_415b24febafd43de958716fe7bc8ab5d()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_5e758a99244447a89cbbdcd81ba0423b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e758a99244447a89cbbdcd81ba0423b()
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

      private sealed class MTHD_28e90e1363204dbf9fef654dfded67a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_28e90e1363204dbf9fef654dfded67a1()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_c0ce76e81de3410eb7d0908290eb6d0f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c0ce76e81de3410eb7d0908290eb6d0f()
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

      private sealed class MTHD_a007cbee54784e2a9d7f0f7187bd50be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a007cbee54784e2a9d7f0f7187bd50be()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_f2805b42d22148a1b87f24dd93fc7ccc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f2805b42d22148a1b87f24dd93fc7ccc()
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

      private sealed class MTHD_93fae98e64fb48dc9c46d4446e51b88b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93fae98e64fb48dc9c46d4446e51b88b()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_22f26bfb176747c89b180ebbf7df8e78 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22f26bfb176747c89b180ebbf7df8e78()
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

      private sealed class MTHD_4f8ace1450e34316b07fc41839cc4cd9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4f8ace1450e34316b07fc41839cc4cd9()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_f0ea9e2ae4e74797b276f324e762c2fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f0ea9e2ae4e74797b276f324e762c2fa()
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

      private sealed class MTHD_a7c28248c74e48a3bc45ba16f44fc33e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a7c28248c74e48a3bc45ba16f44fc33e()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color2;
        }
      }

      private sealed class MTHD_244f2ef4bd584ec7a4e55cb589e45c68 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_244f2ef4bd584ec7a4e55cb589e45c68()
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

      private sealed class MTHD_7189b086a5634b49bf4f06b42c6ce42b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7189b086a5634b49bf4f06b42c6ce42b()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_65c51659fc474e0da377a030942c6144 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65c51659fc474e0da377a030942c6144()
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

      private sealed class MTHD_506f98304ec043d9acd9ced58c766863 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_506f98304ec043d9acd9ced58c766863()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_e3b9ea0b4fb0452f94dacd3f632b981b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e3b9ea0b4fb0452f94dacd3f632b981b()
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

      private sealed class MTHD_c69d93a9cbe340b9b6102d3c5bc74e69 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c69d93a9cbe340b9b6102d3c5bc74e69()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_b76974b8de2e4317bca164ba33f05d9d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b76974b8de2e4317bca164ba33f05d9d()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_1d235ba19c42474a8d6c73b5c64e63dc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d235ba19c42474a8d6c73b5c64e63dc()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_34651285e6e04057938605708f322a7a : HardwiredMemberDescriptor
      {
        internal PROP_34651285e6e04057938605708f322a7a()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_6c91bbfb0fa34b79b2a54a4324bbc385 : HardwiredMemberDescriptor
      {
        internal PROP_6c91bbfb0fa34b79b2a54a4324bbc385()
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

      private sealed class PROP_f7ee9b01825f4a7fb8121249c8db52d8 : HardwiredMemberDescriptor
      {
        internal PROP_f7ee9b01825f4a7fb8121249c8db52d8()
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

      private sealed class PROP_a24ddee00a724e4399cb830b5c3a3337 : HardwiredMemberDescriptor
      {
        internal PROP_a24ddee00a724e4399cb830b5c3a3337()
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

      private sealed class PROP_2b11db70fe9f40028883261f8c818295 : HardwiredMemberDescriptor
      {
        internal PROP_2b11db70fe9f40028883261f8c818295()
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

      private sealed class PROP_03a6057031e24d03b92be41c3a723064 : HardwiredMemberDescriptor
      {
        internal PROP_03a6057031e24d03b92be41c3a723064()
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

      private sealed class PROP_b253cfec2976443591dc72dd699b9361 : HardwiredMemberDescriptor
      {
        internal PROP_b253cfec2976443591dc72dd699b9361()
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

      private sealed class PROP_6445b56dc5cb42b2862d1c74affc2b1b : HardwiredMemberDescriptor
      {
        internal PROP_6445b56dc5cb42b2862d1c74affc2b1b()
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

      private sealed class PROP_c016bd85b8404ddba7e2b291f5283ae2 : HardwiredMemberDescriptor
      {
        internal PROP_c016bd85b8404ddba7e2b291f5283ae2()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_ddb886c4aedb4637896bf04d3cf8f93b : HardwiredUserDataDescriptor
    {
      internal TYPE_ddb886c4aedb4637896bf04d3cf8f93b()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_d25df653869043f89878629b038c8180()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_47687ff5523547d0a259bbf18272116f()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_183e414c6f0843d2ac707243a96b23f8()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_f68e2718b4b84ca3b47e9e8c54cff03a()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_eea45a806b5b4f9f8b2a18d3a3e1b1a5()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_bbdc85e5082640b681c7f49d60249c4e()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_8757c47b601645079ddf62303321f9db()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_e5644640ea084364b9cba187682d292e()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_9e1e171880ef4853b72024cfd750101d()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_d9d633ff08834f21b9f501d1a31405e5()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_060098e6fc5b46c7a366b2ea2e851875()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_f20580621d9641c1a750cd523a6a340c()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_b78609e52ff64ef3be5c6ab81b8d8437()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_a5ca6288fbb44eb0ba5b42fc4d43f424()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_1c04eb7aa38e4d94b2ee33f5239b460f()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_f801444bca6641958057b01986f3919f()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_c7f43b90737241cb9e403e5fd0299135()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_f6d07996ecd9414fadfe04896a0911de()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_d15829f36cf14fc59e101e3db82918d5()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_3633f7cf9f894f28871e83bb4460b4dc()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_0aab25b61d8647d3945d7e95bce7f982()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_9a9fe714b93141058a32c180424faf46()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_7aa624d177dc4ec6aadb3a5e5fb3b91c()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_a84d9bf1b763488ea92c64309dc380fd()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_51483f819d03463e8466ef0648cf59a4()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_b9a4a1d6cc904d849cc0957ba1d79ecc()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_c5d61bf17cd249308989add350841f08()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.MTHD_62724f55f0444763adec4f88d15e1f1c()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.PROP_e9ebbd2a3b44451aaebe49db2a634ea3());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.PROP_5dbcc936303f4917ba6cc1a2493ea460());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.PROP_b9c467b20b69403282297851062f51ba());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.PROP_0d2d02f51fdd422f9cf2c05f7c1ca69c());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.PROP_0e84c20b836d458d853ec227678b4dea());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.PROP_7feb7b65ccb340969f525894544bed3b());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.PROP_49fe737cc9a0427b9cd10b0f59b9b431());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.PROP_2f22e49bbb0b40408bfd3da445ea1deb());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.PROP_6a35f5160373479995f79a79f1e3f690());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.PROP_82571b14303f4eab8cf069983b075d34());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.PROP_735d93e3843242209dfe5be24d4ea8f1());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.PROP_02e73884f23c4cc6b18d028f77df3ebd());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.PROP_92e7d883b8d34eed9cab13b440fc0b9c());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.PROP_d28e6b9035ec46ed8ac732bd48f5a24d());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.PROP_4375be541dc749e392375729857b8ef6());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.PROP_72efbe872ebd45bb9988485466503683());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_ddb886c4aedb4637896bf04d3cf8f93b.PROP_539558c828194543966d8e0c90fac0da());
      }

      private sealed class MTHD_d25df653869043f89878629b038c8180 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d25df653869043f89878629b038c8180()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_47687ff5523547d0a259bbf18272116f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_47687ff5523547d0a259bbf18272116f()
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

      private sealed class MTHD_183e414c6f0843d2ac707243a96b23f8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_183e414c6f0843d2ac707243a96b23f8()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_f68e2718b4b84ca3b47e9e8c54cff03a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f68e2718b4b84ca3b47e9e8c54cff03a()
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

      private sealed class MTHD_eea45a806b5b4f9f8b2a18d3a3e1b1a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eea45a806b5b4f9f8b2a18d3a3e1b1a5()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_bbdc85e5082640b681c7f49d60249c4e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bbdc85e5082640b681c7f49d60249c4e()
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

      private sealed class MTHD_8757c47b601645079ddf62303321f9db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8757c47b601645079ddf62303321f9db()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_e5644640ea084364b9cba187682d292e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e5644640ea084364b9cba187682d292e()
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

      private sealed class MTHD_9e1e171880ef4853b72024cfd750101d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e1e171880ef4853b72024cfd750101d()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_d9d633ff08834f21b9f501d1a31405e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d9d633ff08834f21b9f501d1a31405e5()
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

      private sealed class MTHD_060098e6fc5b46c7a366b2ea2e851875 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_060098e6fc5b46c7a366b2ea2e851875()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_f20580621d9641c1a750cd523a6a340c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f20580621d9641c1a750cd523a6a340c()
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

      private sealed class MTHD_b78609e52ff64ef3be5c6ab81b8d8437 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b78609e52ff64ef3be5c6ab81b8d8437()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_a5ca6288fbb44eb0ba5b42fc4d43f424 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a5ca6288fbb44eb0ba5b42fc4d43f424()
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

      private sealed class MTHD_1c04eb7aa38e4d94b2ee33f5239b460f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c04eb7aa38e4d94b2ee33f5239b460f()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_f801444bca6641958057b01986f3919f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f801444bca6641958057b01986f3919f()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_c7f43b90737241cb9e403e5fd0299135 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c7f43b90737241cb9e403e5fd0299135()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_f6d07996ecd9414fadfe04896a0911de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f6d07996ecd9414fadfe04896a0911de()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_d15829f36cf14fc59e101e3db82918d5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d15829f36cf14fc59e101e3db82918d5()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_3633f7cf9f894f28871e83bb4460b4dc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3633f7cf9f894f28871e83bb4460b4dc()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_0aab25b61d8647d3945d7e95bce7f982 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0aab25b61d8647d3945d7e95bce7f982()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_9a9fe714b93141058a32c180424faf46 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9a9fe714b93141058a32c180424faf46()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_7aa624d177dc4ec6aadb3a5e5fb3b91c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7aa624d177dc4ec6aadb3a5e5fb3b91c()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_a84d9bf1b763488ea92c64309dc380fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a84d9bf1b763488ea92c64309dc380fd()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_51483f819d03463e8466ef0648cf59a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_51483f819d03463e8466ef0648cf59a4()
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

      private sealed class MTHD_b9a4a1d6cc904d849cc0957ba1d79ecc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b9a4a1d6cc904d849cc0957ba1d79ecc()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_c5d61bf17cd249308989add350841f08 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c5d61bf17cd249308989add350841f08()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_62724f55f0444763adec4f88d15e1f1c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_62724f55f0444763adec4f88d15e1f1c()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_e9ebbd2a3b44451aaebe49db2a634ea3 : HardwiredMemberDescriptor
      {
        internal PROP_e9ebbd2a3b44451aaebe49db2a634ea3()
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

      private sealed class PROP_5dbcc936303f4917ba6cc1a2493ea460 : HardwiredMemberDescriptor
      {
        internal PROP_5dbcc936303f4917ba6cc1a2493ea460()
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

      private sealed class PROP_b9c467b20b69403282297851062f51ba : HardwiredMemberDescriptor
      {
        internal PROP_b9c467b20b69403282297851062f51ba()
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

      private sealed class PROP_0d2d02f51fdd422f9cf2c05f7c1ca69c : HardwiredMemberDescriptor
      {
        internal PROP_0d2d02f51fdd422f9cf2c05f7c1ca69c()
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

      private sealed class PROP_0e84c20b836d458d853ec227678b4dea : HardwiredMemberDescriptor
      {
        internal PROP_0e84c20b836d458d853ec227678b4dea()
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

      private sealed class PROP_7feb7b65ccb340969f525894544bed3b : HardwiredMemberDescriptor
      {
        internal PROP_7feb7b65ccb340969f525894544bed3b()
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

      private sealed class PROP_49fe737cc9a0427b9cd10b0f59b9b431 : HardwiredMemberDescriptor
      {
        internal PROP_49fe737cc9a0427b9cd10b0f59b9b431()
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

      private sealed class PROP_2f22e49bbb0b40408bfd3da445ea1deb : HardwiredMemberDescriptor
      {
        internal PROP_2f22e49bbb0b40408bfd3da445ea1deb()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_6a35f5160373479995f79a79f1e3f690 : HardwiredMemberDescriptor
      {
        internal PROP_6a35f5160373479995f79a79f1e3f690()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_82571b14303f4eab8cf069983b075d34 : HardwiredMemberDescriptor
      {
        internal PROP_82571b14303f4eab8cf069983b075d34()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_735d93e3843242209dfe5be24d4ea8f1 : HardwiredMemberDescriptor
      {
        internal PROP_735d93e3843242209dfe5be24d4ea8f1()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_02e73884f23c4cc6b18d028f77df3ebd : HardwiredMemberDescriptor
      {
        internal PROP_02e73884f23c4cc6b18d028f77df3ebd()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_92e7d883b8d34eed9cab13b440fc0b9c : HardwiredMemberDescriptor
      {
        internal PROP_92e7d883b8d34eed9cab13b440fc0b9c()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_d28e6b9035ec46ed8ac732bd48f5a24d : HardwiredMemberDescriptor
      {
        internal PROP_d28e6b9035ec46ed8ac732bd48f5a24d()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_4375be541dc749e392375729857b8ef6 : HardwiredMemberDescriptor
      {
        internal PROP_4375be541dc749e392375729857b8ef6()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_72efbe872ebd45bb9988485466503683 : HardwiredMemberDescriptor
      {
        internal PROP_72efbe872ebd45bb9988485466503683()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_539558c828194543966d8e0c90fac0da : HardwiredMemberDescriptor
      {
        internal PROP_539558c828194543966d8e0c90fac0da()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_a39dbca03a4340beb2a7bc74ca6616c4 : HardwiredUserDataDescriptor
    {
      internal TYPE_a39dbca03a4340beb2a7bc74ca6616c4()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a39dbca03a4340beb2a7bc74ca6616c4.MTHD_6c2abd2131df482986d584afd5b60a6e()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a39dbca03a4340beb2a7bc74ca6616c4.MTHD_79cd2f4807ab420c8e345e1a10cb8117()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a39dbca03a4340beb2a7bc74ca6616c4.MTHD_96ff9d8ead0c4ebbac13d87d1786c61d()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a39dbca03a4340beb2a7bc74ca6616c4.MTHD_f3b164f2ecf04585b1cf2db278d1fa34()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a39dbca03a4340beb2a7bc74ca6616c4.MTHD_b591499932d2413d85585a7f9cf02944()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a39dbca03a4340beb2a7bc74ca6616c4.MTHD_47bf4e630a6346e0ba475caada1c2412()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a39dbca03a4340beb2a7bc74ca6616c4.MTHD_6699048e6b5d4100a2560befa4131bd2()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a39dbca03a4340beb2a7bc74ca6616c4.MTHD_f54a7b0ab2ff439281f76dc97721f6ee()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a39dbca03a4340beb2a7bc74ca6616c4.MTHD_385799697847437b8cfe235dc654b102()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a39dbca03a4340beb2a7bc74ca6616c4.MTHD_6cf12e3919c7466ba5feaa0605d07f21()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a39dbca03a4340beb2a7bc74ca6616c4.MTHD_4150f69051e54257920af3a8ad0c8a9c()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a39dbca03a4340beb2a7bc74ca6616c4.MTHD_6690e25f055d42c698daa878c5c55baa()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a39dbca03a4340beb2a7bc74ca6616c4.MTHD_3438b2661d6140a9bb22d7370d307438()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a39dbca03a4340beb2a7bc74ca6616c4.MTHD_df24861fa6a64e91b1f9c854e200aeb8()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a39dbca03a4340beb2a7bc74ca6616c4.MTHD_75c0fcd2984b47598c109208a7cc3230()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a39dbca03a4340beb2a7bc74ca6616c4.MTHD_83bb96fa16384fd1b3e22b2e97f8ff73()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a39dbca03a4340beb2a7bc74ca6616c4.MTHD_c1afcce2307647a4855f6961b5d8fb25()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_a39dbca03a4340beb2a7bc74ca6616c4.PROP_a57bc178d37d46dca1eed6090f678631());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_a39dbca03a4340beb2a7bc74ca6616c4.PROP_c7ed6feb6fde4af0b440a9fba2a7dcce());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_a39dbca03a4340beb2a7bc74ca6616c4.PROP_8b0a4bfec97d4ee096d82abcbdfceaa3());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_a39dbca03a4340beb2a7bc74ca6616c4.PROP_a63546d1a4fd42ea85a79f424935ef2b());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_a39dbca03a4340beb2a7bc74ca6616c4.PROP_ee73a5d072c74610b6182959e4a4c72e());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_a39dbca03a4340beb2a7bc74ca6616c4.PROP_5376e72bdb414b858ff4931494e54fc1());
      }

      private sealed class MTHD_6c2abd2131df482986d584afd5b60a6e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6c2abd2131df482986d584afd5b60a6e()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_79cd2f4807ab420c8e345e1a10cb8117 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_79cd2f4807ab420c8e345e1a10cb8117()
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

      private sealed class MTHD_96ff9d8ead0c4ebbac13d87d1786c61d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_96ff9d8ead0c4ebbac13d87d1786c61d()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_f3b164f2ecf04585b1cf2db278d1fa34 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f3b164f2ecf04585b1cf2db278d1fa34()
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

      private sealed class MTHD_b591499932d2413d85585a7f9cf02944 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b591499932d2413d85585a7f9cf02944()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_47bf4e630a6346e0ba475caada1c2412 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_47bf4e630a6346e0ba475caada1c2412()
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

      private sealed class MTHD_6699048e6b5d4100a2560befa4131bd2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6699048e6b5d4100a2560befa4131bd2()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_f54a7b0ab2ff439281f76dc97721f6ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f54a7b0ab2ff439281f76dc97721f6ee()
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

      private sealed class MTHD_385799697847437b8cfe235dc654b102 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_385799697847437b8cfe235dc654b102()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_6cf12e3919c7466ba5feaa0605d07f21 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6cf12e3919c7466ba5feaa0605d07f21()
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

      private sealed class MTHD_4150f69051e54257920af3a8ad0c8a9c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4150f69051e54257920af3a8ad0c8a9c()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_6690e25f055d42c698daa878c5c55baa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6690e25f055d42c698daa878c5c55baa()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_3438b2661d6140a9bb22d7370d307438 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3438b2661d6140a9bb22d7370d307438()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_df24861fa6a64e91b1f9c854e200aeb8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_df24861fa6a64e91b1f9c854e200aeb8()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_75c0fcd2984b47598c109208a7cc3230 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75c0fcd2984b47598c109208a7cc3230()
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

      private sealed class MTHD_83bb96fa16384fd1b3e22b2e97f8ff73 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_83bb96fa16384fd1b3e22b2e97f8ff73()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_c1afcce2307647a4855f6961b5d8fb25 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c1afcce2307647a4855f6961b5d8fb25()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_a57bc178d37d46dca1eed6090f678631 : HardwiredMemberDescriptor
      {
        internal PROP_a57bc178d37d46dca1eed6090f678631()
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

      private sealed class PROP_c7ed6feb6fde4af0b440a9fba2a7dcce : HardwiredMemberDescriptor
      {
        internal PROP_c7ed6feb6fde4af0b440a9fba2a7dcce()
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

      private sealed class PROP_8b0a4bfec97d4ee096d82abcbdfceaa3 : HardwiredMemberDescriptor
      {
        internal PROP_8b0a4bfec97d4ee096d82abcbdfceaa3()
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

      private sealed class PROP_a63546d1a4fd42ea85a79f424935ef2b : HardwiredMemberDescriptor
      {
        internal PROP_a63546d1a4fd42ea85a79f424935ef2b()
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

      private sealed class PROP_ee73a5d072c74610b6182959e4a4c72e : HardwiredMemberDescriptor
      {
        internal PROP_ee73a5d072c74610b6182959e4a4c72e()
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

      private sealed class PROP_5376e72bdb414b858ff4931494e54fc1 : HardwiredMemberDescriptor
      {
        internal PROP_5376e72bdb414b858ff4931494e54fc1()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_faad6757200f4c039ce12e0dc963e52c : HardwiredUserDataDescriptor
    {
      internal TYPE_faad6757200f4c039ce12e0dc963e52c()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_faad6757200f4c039ce12e0dc963e52c.MTHD_16cd16253bad448e8f37df131766bc66(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_faad6757200f4c039ce12e0dc963e52c.MTHD_fceb513396ba44948b76c2a0b6c00017()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_faad6757200f4c039ce12e0dc963e52c.MTHD_f630954485704d139d55dc4fc72b1eb8(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_faad6757200f4c039ce12e0dc963e52c.MTHD_da52180c4fc546c1a7dff47d276b130c()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_faad6757200f4c039ce12e0dc963e52c.MTHD_c355e41a78a24342ae81dbe894aa8d54()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_faad6757200f4c039ce12e0dc963e52c.MTHD_b2b5865f6ddf481daeba7690804d4507()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_faad6757200f4c039ce12e0dc963e52c.MTHD_ba04495e6863459c8d248dcf5a584d71()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_faad6757200f4c039ce12e0dc963e52c.MTHD_be13cbf0ee284d2793603c352b6b5bf0()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_faad6757200f4c039ce12e0dc963e52c.MTHD_5c030680586b429abc464745597a06f6()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_faad6757200f4c039ce12e0dc963e52c.MTHD_90cf0fc4792148f4b3714dd53e3f1071()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_faad6757200f4c039ce12e0dc963e52c.MTHD_4ce73dd2cf454e4e8bcca887681db5bd()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_faad6757200f4c039ce12e0dc963e52c.MTHD_fd2ffa4b481c49fd9a671ed20c40c744(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_faad6757200f4c039ce12e0dc963e52c.MTHD_fbbe5956c92d4fafae2c89759212d6bc()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_faad6757200f4c039ce12e0dc963e52c.MTHD_ac8ecc09f347425eba891e917a915a7d(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_faad6757200f4c039ce12e0dc963e52c.MTHD_f7c500a3bd9843198ef22246c904e7a2()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_faad6757200f4c039ce12e0dc963e52c.MTHD_b3279f9d77a74c03a4ef9fc6ae226681(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_faad6757200f4c039ce12e0dc963e52c.MTHD_fbd4e01306e344048a8fd1f03f1452c4()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_faad6757200f4c039ce12e0dc963e52c.MTHD_8c232f4f8adf4d8e8e73dc836ae1ba75(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_faad6757200f4c039ce12e0dc963e52c.MTHD_378c52fa538e4f0083b1e927fb63322a()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_faad6757200f4c039ce12e0dc963e52c.MTHD_140a235812914b9dbddae0010f0db884(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_faad6757200f4c039ce12e0dc963e52c.MTHD_0f2e7172383f4bbdb5c78a93379096be()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_faad6757200f4c039ce12e0dc963e52c.MTHD_735813ea74564682ae2631f129ca203c()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_faad6757200f4c039ce12e0dc963e52c.MTHD_3e5d0635ee094175a1e2788a1cc6005c()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_faad6757200f4c039ce12e0dc963e52c.FLDV_2a8b6902b9c04cda833eebbbdb1fe055());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_faad6757200f4c039ce12e0dc963e52c.FLDV_60e6efd573664fbf9855b43e0e426fa3());
      }

      private sealed class MTHD_16cd16253bad448e8f37df131766bc66 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_16cd16253bad448e8f37df131766bc66()
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

      private sealed class MTHD_fceb513396ba44948b76c2a0b6c00017 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fceb513396ba44948b76c2a0b6c00017()
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

      private sealed class MTHD_f630954485704d139d55dc4fc72b1eb8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f630954485704d139d55dc4fc72b1eb8()
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

      private sealed class MTHD_da52180c4fc546c1a7dff47d276b130c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_da52180c4fc546c1a7dff47d276b130c()
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

      private sealed class MTHD_c355e41a78a24342ae81dbe894aa8d54 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c355e41a78a24342ae81dbe894aa8d54()
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

      private sealed class MTHD_b2b5865f6ddf481daeba7690804d4507 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b2b5865f6ddf481daeba7690804d4507()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_ba04495e6863459c8d248dcf5a584d71 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba04495e6863459c8d248dcf5a584d71()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_be13cbf0ee284d2793603c352b6b5bf0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be13cbf0ee284d2793603c352b6b5bf0()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_5c030680586b429abc464745597a06f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c030680586b429abc464745597a06f6()
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

      private sealed class MTHD_90cf0fc4792148f4b3714dd53e3f1071 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90cf0fc4792148f4b3714dd53e3f1071()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_4ce73dd2cf454e4e8bcca887681db5bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ce73dd2cf454e4e8bcca887681db5bd()
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

      private sealed class MTHD_fd2ffa4b481c49fd9a671ed20c40c744 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd2ffa4b481c49fd9a671ed20c40c744()
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

      private sealed class MTHD_fbbe5956c92d4fafae2c89759212d6bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fbbe5956c92d4fafae2c89759212d6bc()
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

      private sealed class MTHD_ac8ecc09f347425eba891e917a915a7d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac8ecc09f347425eba891e917a915a7d()
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

      private sealed class MTHD_f7c500a3bd9843198ef22246c904e7a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7c500a3bd9843198ef22246c904e7a2()
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

      private sealed class MTHD_b3279f9d77a74c03a4ef9fc6ae226681 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b3279f9d77a74c03a4ef9fc6ae226681()
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

      private sealed class MTHD_fbd4e01306e344048a8fd1f03f1452c4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fbd4e01306e344048a8fd1f03f1452c4()
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

      private sealed class MTHD_8c232f4f8adf4d8e8e73dc836ae1ba75 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c232f4f8adf4d8e8e73dc836ae1ba75()
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

      private sealed class MTHD_378c52fa538e4f0083b1e927fb63322a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_378c52fa538e4f0083b1e927fb63322a()
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

      private sealed class MTHD_140a235812914b9dbddae0010f0db884 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_140a235812914b9dbddae0010f0db884()
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

      private sealed class MTHD_0f2e7172383f4bbdb5c78a93379096be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f2e7172383f4bbdb5c78a93379096be()
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

      private sealed class MTHD_735813ea74564682ae2631f129ca203c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_735813ea74564682ae2631f129ca203c()
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

      private sealed class MTHD_3e5d0635ee094175a1e2788a1cc6005c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e5d0635ee094175a1e2788a1cc6005c()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_2a8b6902b9c04cda833eebbbdb1fe055 : HardwiredMemberDescriptor
      {
        internal FLDV_2a8b6902b9c04cda833eebbbdb1fe055()
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

      private sealed class FLDV_60e6efd573664fbf9855b43e0e426fa3 : HardwiredMemberDescriptor
      {
        internal FLDV_60e6efd573664fbf9855b43e0e426fa3()
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

    private sealed class TYPE_62e360517d614f0aaff1ecab4029cdf6 : HardwiredUserDataDescriptor
    {
      internal TYPE_62e360517d614f0aaff1ecab4029cdf6()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62e360517d614f0aaff1ecab4029cdf6.MTHD_aeb2db7544dd43cdb64132c5473363be()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62e360517d614f0aaff1ecab4029cdf6.MTHD_44acbcbdd44442b4b377a15708e4e406()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62e360517d614f0aaff1ecab4029cdf6.MTHD_89f3a3003dfd4843ac020bd02a20726c()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62e360517d614f0aaff1ecab4029cdf6.MTHD_3bef25328a114d64aa66e1f7bb7da788()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62e360517d614f0aaff1ecab4029cdf6.MTHD_ae12913edf9c435caf421cdd41fbbcfe()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62e360517d614f0aaff1ecab4029cdf6.MTHD_c0ef16e328c8445dbca2afe6258edd73()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_62e360517d614f0aaff1ecab4029cdf6.FLDV_7a57627b9e7c4ee3b908cec5d0917ad8());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_62e360517d614f0aaff1ecab4029cdf6.FLDV_412988cb215e4e5d9c20833894258a17());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_62e360517d614f0aaff1ecab4029cdf6.FLDV_65398a539bf84b1bb1c166cfc9337e74());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_62e360517d614f0aaff1ecab4029cdf6.FLDV_95a7c531adfc40eb8a4273f35847fc77());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_62e360517d614f0aaff1ecab4029cdf6.FLDV_aa2417d976214996b60c039271ca4dad());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_62e360517d614f0aaff1ecab4029cdf6.FLDV_456ce8868d6242349bba0e784b15ced1());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_62e360517d614f0aaff1ecab4029cdf6.FLDV_2e5b9a17e8d449e69177ef258d2b94ec());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_62e360517d614f0aaff1ecab4029cdf6.FLDV_2c63cd412f1c406c9c7518a39eea14af());
        this.AddMember("prestige", (IMemberDescriptor) new Bridge.TYPE_62e360517d614f0aaff1ecab4029cdf6.FLDV_ee96b8031d1b49bc9d86af3ae1dd9f4a());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_62e360517d614f0aaff1ecab4029cdf6.FLDV_ec4c2eb3dd154319be935cbb2dc83524());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_62e360517d614f0aaff1ecab4029cdf6.FLDV_f5599837ebad4dcb9b9db9e0a5554711());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_62e360517d614f0aaff1ecab4029cdf6.FLDV_f886547c342442e6a6ef468feb2e2112());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_62e360517d614f0aaff1ecab4029cdf6.FLDV_aeed1e27df5543348e15ff42613870ac());
      }

      private sealed class MTHD_aeb2db7544dd43cdb64132c5473363be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aeb2db7544dd43cdb64132c5473363be()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_44acbcbdd44442b4b377a15708e4e406 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_44acbcbdd44442b4b377a15708e4e406()
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

      private sealed class MTHD_89f3a3003dfd4843ac020bd02a20726c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_89f3a3003dfd4843ac020bd02a20726c()
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

      private sealed class MTHD_3bef25328a114d64aa66e1f7bb7da788 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3bef25328a114d64aa66e1f7bb7da788()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_ae12913edf9c435caf421cdd41fbbcfe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae12913edf9c435caf421cdd41fbbcfe()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_c0ef16e328c8445dbca2afe6258edd73 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c0ef16e328c8445dbca2afe6258edd73()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_7a57627b9e7c4ee3b908cec5d0917ad8 : HardwiredMemberDescriptor
      {
        internal FLDV_7a57627b9e7c4ee3b908cec5d0917ad8()
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

      private sealed class FLDV_412988cb215e4e5d9c20833894258a17 : HardwiredMemberDescriptor
      {
        internal FLDV_412988cb215e4e5d9c20833894258a17()
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

      private sealed class FLDV_65398a539bf84b1bb1c166cfc9337e74 : HardwiredMemberDescriptor
      {
        internal FLDV_65398a539bf84b1bb1c166cfc9337e74()
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

      private sealed class FLDV_95a7c531adfc40eb8a4273f35847fc77 : HardwiredMemberDescriptor
      {
        internal FLDV_95a7c531adfc40eb8a4273f35847fc77()
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

      private sealed class FLDV_aa2417d976214996b60c039271ca4dad : HardwiredMemberDescriptor
      {
        internal FLDV_aa2417d976214996b60c039271ca4dad()
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

      private sealed class FLDV_456ce8868d6242349bba0e784b15ced1 : HardwiredMemberDescriptor
      {
        internal FLDV_456ce8868d6242349bba0e784b15ced1()
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

      private sealed class FLDV_2e5b9a17e8d449e69177ef258d2b94ec : HardwiredMemberDescriptor
      {
        internal FLDV_2e5b9a17e8d449e69177ef258d2b94ec()
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

      private sealed class FLDV_2c63cd412f1c406c9c7518a39eea14af : HardwiredMemberDescriptor
      {
        internal FLDV_2c63cd412f1c406c9c7518a39eea14af()
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

      private sealed class FLDV_ee96b8031d1b49bc9d86af3ae1dd9f4a : HardwiredMemberDescriptor
      {
        internal FLDV_ee96b8031d1b49bc9d86af3ae1dd9f4a()
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

      private sealed class FLDV_ec4c2eb3dd154319be935cbb2dc83524 : HardwiredMemberDescriptor
      {
        internal FLDV_ec4c2eb3dd154319be935cbb2dc83524()
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

      private sealed class FLDV_f5599837ebad4dcb9b9db9e0a5554711 : HardwiredMemberDescriptor
      {
        internal FLDV_f5599837ebad4dcb9b9db9e0a5554711()
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

      private sealed class FLDV_f886547c342442e6a6ef468feb2e2112 : HardwiredMemberDescriptor
      {
        internal FLDV_f886547c342442e6a6ef468feb2e2112()
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

      private sealed class FLDV_aeed1e27df5543348e15ff42613870ac : HardwiredMemberDescriptor
      {
        internal FLDV_aeed1e27df5543348e15ff42613870ac()
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

    private sealed class TYPE_c671f1bc175944c98b9c63a7ece4bd44 : HardwiredUserDataDescriptor
    {
      internal TYPE_c671f1bc175944c98b9c63a7ece4bd44()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_8e91a0a045304e78b967ce11f6270f1b()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_696fcc9c024c41488c5b072cd9aff100()
        }));
        this.AddMember("get_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_3fafe8e8c08940baa35bab5f4f5fb445()
        }));
        this.AddMember("set_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_9459b504ec62476e9dadc6bf33ce8610()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_9057f03c74a445fa83db154f919eb3d0()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_097dec87740d44e49ede63f065121606()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_6ffe2db980934e10bd9b9963f4b325f7()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_e49c8d5c860f4a3ea0c932ad8fb69641()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_627d797d3eb142d9913b32cc938707b1()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_364ad0ec83df43f48a61acaf9f901ef7()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_3b2d29c97cb843b7a6aac4e855a76244()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_dd41701ae5094f8da3811b35f1dab256()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_ea1a641563794882b8eebda4fbe44d97()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_f8c05dc2862a40d48433403a12f62661()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_653b6985bbf2472293ab3e9f3bd6a1c1()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_78a6a1fa07b04f97b1541518fe93a98a()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_a2faf1a2e9954db18c566fb37bc5af25()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_b101073633054f6490519412db308e89()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_d82be5907c0e4256b8c95416911644fe()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_ff08a5bbd3fd440589abe02736ae742b()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_d6991aa4a5c04b92b448d60d411e53a1()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_ef707e291d404f759eca01b6277ce5fa()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_3aa58b1c93424ef7be72efa3599029a1()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_ab1d4cffdaf448f7b67af4d026ab5b14()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_02c5b65168ab4a74a6581234a90738f2()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_12c37a1b3efa4de9bee3235089943f17()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_e47b5eec97fa41a39532a62fc8ff7bc9()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_d7e6d318321f46269424f6e2cca269b3()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_6e6cd626763f40b98114bdea050899f1()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_87a20165625942139f78ab001a581f50()
        }));
        this.AddMember("get_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_2c6d5afdb6374ae5b58635ffa7aaedac()
        }));
        this.AddMember("set_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_db464a64564f4d2ab74dd07996ead0c5()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_39550bd02f08434bb714f5670145a726()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_88dba901125a441cb5b47173fa3fca4e()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_34e76c154c4347f7a110af40f2613193()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_2269a81cb2eb4a659c85da52cf6937a2()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_8e0f8d11ea7f42f6a2c4954b2c78e5d2()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_20deb41763ff4b8fba73eab1ce2d43cf()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_8dd2285e2d9741248f9420f2df0801ad()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_f48404125f3c4ea38668b6295ae1a02e()
        }));
        this.AddMember("get_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_83a9d025baaf42a3acf7c804101f7a36()
        }));
        this.AddMember("set_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_b906a86587ac4b61bd22df2439feeb12()
        }));
        this.AddMember("get_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_347555715d4e43ff9e066c2018a95dd8()
        }));
        this.AddMember("set_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_91e12099d9f84583b369337b27e35601()
        }));
        this.AddMember("get_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_2b3ee128f6f2474b870eaf778041108c()
        }));
        this.AddMember("set_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_e8e60263ce2f461ea626c82f1a75d3cb()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_225c2ae885a84bd18319810da7378860()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_b3ace20771294f63b43268ec064b362c()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_cf11f44fb3ac4c3f85ea95cece907337()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_e0bfc754a7434558902f358afb6c25e5()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_f75fecfb5cf642e3b9329e995ee431a6()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_9b23f0eae3fa427091ace1e52aeee25f()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_6af0f7c38e9e46afab28be79ebeafca0()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_6fbf852ba9304ae4b2113e3c82c476e1()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_0c68696f497a4799b49708e482df3662()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_3202d9109ce3482a8407f98aca6dc6fb()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_7810b69fd6c04213919938a82487f50d()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_b751661910d8483db8d17a47729a5e59()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_9e6ccb1847f846bdbc2dd27f12bcf7aa()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.MTHD_0e0be691f8a84906b3ff14d7840cc681()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.PROP_d929a837a41b4d9eb876e0524eefaa0a());
        this.AddMember("visible", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.PROP_1ac7063a7cc745909a61e884ea110853());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.PROP_f19f15711baf485ab92b1b9f1c9bc1ad());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.PROP_382da9c48de34499a650d6a6bb9340ed());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.PROP_b28dc5bb32a0427d9161474c7c6a750d());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.PROP_f1853bad253741489f41d37ac27e918c());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.PROP_2027e895121d44c58b8fdf2a7495a5f0());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.PROP_42fbdf9c37d344c98ac39118354e2dbe());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.PROP_b2457649920c4b21a5a09fa46a8bc698());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.PROP_92a43431d9c94e65b31c8b3d511588b5());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.PROP_4cb324fa9d9a4bc88c82a397ca735c99());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.PROP_8f779a536b314e15acda1a045f4ac14f());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.PROP_948222282e1341679e07e8c55a04ba97());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.PROP_1bad40b95cd6438db2a27e3ab20067d6());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.PROP_aebb062f84ca4b96a281356a1c94e76c());
        this.AddMember("onClick2", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.PROP_ca2ef0eab89f4c7081d0a00dfa7af082());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.PROP_70ae99e653bc4a1c82973d7513cadef4());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.PROP_e644517c9d7b4e25acedeae93782a8fe());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.PROP_f9de5bf52a2c45a68dc58380f41e890b());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.PROP_39461039624d45debad25a997e51ae4d());
        this.AddMember("textColor2", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.PROP_f8ab7eb93ac7422085885fa958fb3743());
        this.AddMember("highlightColor", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.PROP_943019cb82404e229d9a451e0f87cfd0());
        this.AddMember("highlightColor2", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.PROP_08723e790996436abf732267f79e6ec3());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.PROP_bd60962b0ff24b08bba138e0fdb233e5());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.PROP_f34f501be4854f0ba3191b8378593a9d());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.FLDV_b39a3b0949744967934115e5b6c26017());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.FLDV_fd99d16644be4641aa812ec66368b741());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_c671f1bc175944c98b9c63a7ece4bd44.FLDV_afb68d61002548b2932b949381322163());
      }

      private sealed class MTHD_8e91a0a045304e78b967ce11f6270f1b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e91a0a045304e78b967ce11f6270f1b()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_696fcc9c024c41488c5b072cd9aff100 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_696fcc9c024c41488c5b072cd9aff100()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_3fafe8e8c08940baa35bab5f4f5fb445 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3fafe8e8c08940baa35bab5f4f5fb445()
        {
          this.Initialize("get_visible", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).visible;
        }
      }

      private sealed class MTHD_9459b504ec62476e9dadc6bf33ce8610 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9459b504ec62476e9dadc6bf33ce8610()
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

      private sealed class MTHD_9057f03c74a445fa83db154f919eb3d0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9057f03c74a445fa83db154f919eb3d0()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_097dec87740d44e49ede63f065121606 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_097dec87740d44e49ede63f065121606()
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

      private sealed class MTHD_6ffe2db980934e10bd9b9963f4b325f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ffe2db980934e10bd9b9963f4b325f7()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_e49c8d5c860f4a3ea0c932ad8fb69641 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e49c8d5c860f4a3ea0c932ad8fb69641()
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

      private sealed class MTHD_627d797d3eb142d9913b32cc938707b1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_627d797d3eb142d9913b32cc938707b1()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_364ad0ec83df43f48a61acaf9f901ef7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_364ad0ec83df43f48a61acaf9f901ef7()
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

      private sealed class MTHD_3b2d29c97cb843b7a6aac4e855a76244 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3b2d29c97cb843b7a6aac4e855a76244()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_dd41701ae5094f8da3811b35f1dab256 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dd41701ae5094f8da3811b35f1dab256()
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

      private sealed class MTHD_ea1a641563794882b8eebda4fbe44d97 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea1a641563794882b8eebda4fbe44d97()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_f8c05dc2862a40d48433403a12f62661 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f8c05dc2862a40d48433403a12f62661()
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

      private sealed class MTHD_653b6985bbf2472293ab3e9f3bd6a1c1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_653b6985bbf2472293ab3e9f3bd6a1c1()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_78a6a1fa07b04f97b1541518fe93a98a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_78a6a1fa07b04f97b1541518fe93a98a()
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

      private sealed class MTHD_a2faf1a2e9954db18c566fb37bc5af25 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2faf1a2e9954db18c566fb37bc5af25()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_b101073633054f6490519412db308e89 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b101073633054f6490519412db308e89()
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

      private sealed class MTHD_d82be5907c0e4256b8c95416911644fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d82be5907c0e4256b8c95416911644fe()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_ff08a5bbd3fd440589abe02736ae742b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff08a5bbd3fd440589abe02736ae742b()
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

      private sealed class MTHD_d6991aa4a5c04b92b448d60d411e53a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6991aa4a5c04b92b448d60d411e53a1()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_ef707e291d404f759eca01b6277ce5fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef707e291d404f759eca01b6277ce5fa()
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

      private sealed class MTHD_3aa58b1c93424ef7be72efa3599029a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3aa58b1c93424ef7be72efa3599029a1()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_ab1d4cffdaf448f7b67af4d026ab5b14 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab1d4cffdaf448f7b67af4d026ab5b14()
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

      private sealed class MTHD_02c5b65168ab4a74a6581234a90738f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_02c5b65168ab4a74a6581234a90738f2()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_12c37a1b3efa4de9bee3235089943f17 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_12c37a1b3efa4de9bee3235089943f17()
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

      private sealed class MTHD_e47b5eec97fa41a39532a62fc8ff7bc9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e47b5eec97fa41a39532a62fc8ff7bc9()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_d7e6d318321f46269424f6e2cca269b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d7e6d318321f46269424f6e2cca269b3()
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

      private sealed class MTHD_6e6cd626763f40b98114bdea050899f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e6cd626763f40b98114bdea050899f1()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_87a20165625942139f78ab001a581f50 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_87a20165625942139f78ab001a581f50()
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

      private sealed class MTHD_2c6d5afdb6374ae5b58635ffa7aaedac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c6d5afdb6374ae5b58635ffa7aaedac()
        {
          this.Initialize("get_onClick2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick2;
        }
      }

      private sealed class MTHD_db464a64564f4d2ab74dd07996ead0c5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db464a64564f4d2ab74dd07996ead0c5()
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

      private sealed class MTHD_39550bd02f08434bb714f5670145a726 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_39550bd02f08434bb714f5670145a726()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_88dba901125a441cb5b47173fa3fca4e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_88dba901125a441cb5b47173fa3fca4e()
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

      private sealed class MTHD_34e76c154c4347f7a110af40f2613193 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_34e76c154c4347f7a110af40f2613193()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color2;
        }
      }

      private sealed class MTHD_2269a81cb2eb4a659c85da52cf6937a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2269a81cb2eb4a659c85da52cf6937a2()
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

      private sealed class MTHD_8e0f8d11ea7f42f6a2c4954b2c78e5d2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e0f8d11ea7f42f6a2c4954b2c78e5d2()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_20deb41763ff4b8fba73eab1ce2d43cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_20deb41763ff4b8fba73eab1ce2d43cf()
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

      private sealed class MTHD_8dd2285e2d9741248f9420f2df0801ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8dd2285e2d9741248f9420f2df0801ad()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_f48404125f3c4ea38668b6295ae1a02e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f48404125f3c4ea38668b6295ae1a02e()
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

      private sealed class MTHD_83a9d025baaf42a3acf7c804101f7a36 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_83a9d025baaf42a3acf7c804101f7a36()
        {
          this.Initialize("get_textColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor2;
        }
      }

      private sealed class MTHD_b906a86587ac4b61bd22df2439feeb12 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b906a86587ac4b61bd22df2439feeb12()
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

      private sealed class MTHD_347555715d4e43ff9e066c2018a95dd8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_347555715d4e43ff9e066c2018a95dd8()
        {
          this.Initialize("get_highlightColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor;
        }
      }

      private sealed class MTHD_91e12099d9f84583b369337b27e35601 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_91e12099d9f84583b369337b27e35601()
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

      private sealed class MTHD_2b3ee128f6f2474b870eaf778041108c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b3ee128f6f2474b870eaf778041108c()
        {
          this.Initialize("get_highlightColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor2;
        }
      }

      private sealed class MTHD_e8e60263ce2f461ea626c82f1a75d3cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e8e60263ce2f461ea626c82f1a75d3cb()
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

      private sealed class MTHD_225c2ae885a84bd18319810da7378860 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_225c2ae885a84bd18319810da7378860()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_b3ace20771294f63b43268ec064b362c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b3ace20771294f63b43268ec064b362c()
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

      private sealed class MTHD_cf11f44fb3ac4c3f85ea95cece907337 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf11f44fb3ac4c3f85ea95cece907337()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_e0bfc754a7434558902f358afb6c25e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e0bfc754a7434558902f358afb6c25e5()
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

      private sealed class MTHD_f75fecfb5cf642e3b9329e995ee431a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f75fecfb5cf642e3b9329e995ee431a6()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9b23f0eae3fa427091ace1e52aeee25f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b23f0eae3fa427091ace1e52aeee25f()
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

      private sealed class MTHD_6af0f7c38e9e46afab28be79ebeafca0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6af0f7c38e9e46afab28be79ebeafca0()
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

      private sealed class MTHD_6fbf852ba9304ae4b2113e3c82c476e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6fbf852ba9304ae4b2113e3c82c476e1()
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

      private sealed class MTHD_0c68696f497a4799b49708e482df3662 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c68696f497a4799b49708e482df3662()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_3202d9109ce3482a8407f98aca6dc6fb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3202d9109ce3482a8407f98aca6dc6fb()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_7810b69fd6c04213919938a82487f50d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7810b69fd6c04213919938a82487f50d()
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

      private sealed class MTHD_b751661910d8483db8d17a47729a5e59 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b751661910d8483db8d17a47729a5e59()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_9e6ccb1847f846bdbc2dd27f12bcf7aa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e6ccb1847f846bdbc2dd27f12bcf7aa()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_0e0be691f8a84906b3ff14d7840cc681 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e0be691f8a84906b3ff14d7840cc681()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_d929a837a41b4d9eb876e0524eefaa0a : HardwiredMemberDescriptor
      {
        internal PROP_d929a837a41b4d9eb876e0524eefaa0a()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_1ac7063a7cc745909a61e884ea110853 : HardwiredMemberDescriptor
      {
        internal PROP_1ac7063a7cc745909a61e884ea110853()
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

      private sealed class PROP_f19f15711baf485ab92b1b9f1c9bc1ad : HardwiredMemberDescriptor
      {
        internal PROP_f19f15711baf485ab92b1b9f1c9bc1ad()
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

      private sealed class PROP_382da9c48de34499a650d6a6bb9340ed : HardwiredMemberDescriptor
      {
        internal PROP_382da9c48de34499a650d6a6bb9340ed()
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

      private sealed class PROP_b28dc5bb32a0427d9161474c7c6a750d : HardwiredMemberDescriptor
      {
        internal PROP_b28dc5bb32a0427d9161474c7c6a750d()
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

      private sealed class PROP_f1853bad253741489f41d37ac27e918c : HardwiredMemberDescriptor
      {
        internal PROP_f1853bad253741489f41d37ac27e918c()
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

      private sealed class PROP_2027e895121d44c58b8fdf2a7495a5f0 : HardwiredMemberDescriptor
      {
        internal PROP_2027e895121d44c58b8fdf2a7495a5f0()
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

      private sealed class PROP_42fbdf9c37d344c98ac39118354e2dbe : HardwiredMemberDescriptor
      {
        internal PROP_42fbdf9c37d344c98ac39118354e2dbe()
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

      private sealed class PROP_b2457649920c4b21a5a09fa46a8bc698 : HardwiredMemberDescriptor
      {
        internal PROP_b2457649920c4b21a5a09fa46a8bc698()
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

      private sealed class PROP_92a43431d9c94e65b31c8b3d511588b5 : HardwiredMemberDescriptor
      {
        internal PROP_92a43431d9c94e65b31c8b3d511588b5()
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

      private sealed class PROP_4cb324fa9d9a4bc88c82a397ca735c99 : HardwiredMemberDescriptor
      {
        internal PROP_4cb324fa9d9a4bc88c82a397ca735c99()
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

      private sealed class PROP_8f779a536b314e15acda1a045f4ac14f : HardwiredMemberDescriptor
      {
        internal PROP_8f779a536b314e15acda1a045f4ac14f()
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

      private sealed class PROP_948222282e1341679e07e8c55a04ba97 : HardwiredMemberDescriptor
      {
        internal PROP_948222282e1341679e07e8c55a04ba97()
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

      private sealed class PROP_1bad40b95cd6438db2a27e3ab20067d6 : HardwiredMemberDescriptor
      {
        internal PROP_1bad40b95cd6438db2a27e3ab20067d6()
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

      private sealed class PROP_aebb062f84ca4b96a281356a1c94e76c : HardwiredMemberDescriptor
      {
        internal PROP_aebb062f84ca4b96a281356a1c94e76c()
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

      private sealed class PROP_ca2ef0eab89f4c7081d0a00dfa7af082 : HardwiredMemberDescriptor
      {
        internal PROP_ca2ef0eab89f4c7081d0a00dfa7af082()
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

      private sealed class PROP_70ae99e653bc4a1c82973d7513cadef4 : HardwiredMemberDescriptor
      {
        internal PROP_70ae99e653bc4a1c82973d7513cadef4()
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

      private sealed class PROP_e644517c9d7b4e25acedeae93782a8fe : HardwiredMemberDescriptor
      {
        internal PROP_e644517c9d7b4e25acedeae93782a8fe()
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

      private sealed class PROP_f9de5bf52a2c45a68dc58380f41e890b : HardwiredMemberDescriptor
      {
        internal PROP_f9de5bf52a2c45a68dc58380f41e890b()
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

      private sealed class PROP_39461039624d45debad25a997e51ae4d : HardwiredMemberDescriptor
      {
        internal PROP_39461039624d45debad25a997e51ae4d()
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

      private sealed class PROP_f8ab7eb93ac7422085885fa958fb3743 : HardwiredMemberDescriptor
      {
        internal PROP_f8ab7eb93ac7422085885fa958fb3743()
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

      private sealed class PROP_943019cb82404e229d9a451e0f87cfd0 : HardwiredMemberDescriptor
      {
        internal PROP_943019cb82404e229d9a451e0f87cfd0()
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

      private sealed class PROP_08723e790996436abf732267f79e6ec3 : HardwiredMemberDescriptor
      {
        internal PROP_08723e790996436abf732267f79e6ec3()
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

      private sealed class PROP_bd60962b0ff24b08bba138e0fdb233e5 : HardwiredMemberDescriptor
      {
        internal PROP_bd60962b0ff24b08bba138e0fdb233e5()
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

      private sealed class PROP_f34f501be4854f0ba3191b8378593a9d : HardwiredMemberDescriptor
      {
        internal PROP_f34f501be4854f0ba3191b8378593a9d()
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

      private sealed class FLDV_b39a3b0949744967934115e5b6c26017 : HardwiredMemberDescriptor
      {
        internal FLDV_b39a3b0949744967934115e5b6c26017()
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

      private sealed class FLDV_fd99d16644be4641aa812ec66368b741 : HardwiredMemberDescriptor
      {
        internal FLDV_fd99d16644be4641aa812ec66368b741()
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

      private sealed class FLDV_afb68d61002548b2932b949381322163 : HardwiredMemberDescriptor
      {
        internal FLDV_afb68d61002548b2932b949381322163()
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

    private sealed class TYPE_db2c11b002e84433980a2e976de1a94e : HardwiredUserDataDescriptor
    {
      internal TYPE_db2c11b002e84433980a2e976de1a94e()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_db2c11b002e84433980a2e976de1a94e.MTHD_3fb4794623ab49a495e2695fb4789220()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_db2c11b002e84433980a2e976de1a94e.MTHD_307b74dffaa044d39549ff89e7a5ac23()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_db2c11b002e84433980a2e976de1a94e.MTHD_a51d7de3c3ae4e6ab3695a6f82c4ecac()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_db2c11b002e84433980a2e976de1a94e.MTHD_9da37f8a53de40f28ba46e4e89365430()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_db2c11b002e84433980a2e976de1a94e.MTHD_ba1680e645734136bba2d6cc0ce57910()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_db2c11b002e84433980a2e976de1a94e.MTHD_e217e2997f584b89a3c6a9a9ca689ab2()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_db2c11b002e84433980a2e976de1a94e.FLDV_95bc2e0faeeb4b3abd398960eba7228e());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_db2c11b002e84433980a2e976de1a94e.FLDV_981b2024009145c1a1ae26ff24fa1150());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_db2c11b002e84433980a2e976de1a94e.FLDV_74dfe9ed17f643d1b5920219dd957c2d());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_db2c11b002e84433980a2e976de1a94e.FLDV_9177186b476d4fed92ce306d2e9d2df3());
      }

      private sealed class MTHD_3fb4794623ab49a495e2695fb4789220 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3fb4794623ab49a495e2695fb4789220()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_307b74dffaa044d39549ff89e7a5ac23 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_307b74dffaa044d39549ff89e7a5ac23()
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

      private sealed class MTHD_a51d7de3c3ae4e6ab3695a6f82c4ecac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a51d7de3c3ae4e6ab3695a6f82c4ecac()
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

      private sealed class MTHD_9da37f8a53de40f28ba46e4e89365430 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9da37f8a53de40f28ba46e4e89365430()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_ba1680e645734136bba2d6cc0ce57910 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba1680e645734136bba2d6cc0ce57910()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_e217e2997f584b89a3c6a9a9ca689ab2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e217e2997f584b89a3c6a9a9ca689ab2()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_95bc2e0faeeb4b3abd398960eba7228e : HardwiredMemberDescriptor
      {
        internal FLDV_95bc2e0faeeb4b3abd398960eba7228e()
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

      private sealed class FLDV_981b2024009145c1a1ae26ff24fa1150 : HardwiredMemberDescriptor
      {
        internal FLDV_981b2024009145c1a1ae26ff24fa1150()
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

      private sealed class FLDV_74dfe9ed17f643d1b5920219dd957c2d : HardwiredMemberDescriptor
      {
        internal FLDV_74dfe9ed17f643d1b5920219dd957c2d()
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

      private sealed class FLDV_9177186b476d4fed92ce306d2e9d2df3 : HardwiredMemberDescriptor
      {
        internal FLDV_9177186b476d4fed92ce306d2e9d2df3()
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

    private sealed class TYPE_d16d501df73b4655a3eb8da5a9aaa357 : HardwiredUserDataDescriptor
    {
      internal TYPE_d16d501df73b4655a3eb8da5a9aaa357()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d16d501df73b4655a3eb8da5a9aaa357.MTHD_8be87481ac0048b7b36fa3286a8d53a4()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d16d501df73b4655a3eb8da5a9aaa357.MTHD_7d29f584ef9647dc87870ef23ba9feff()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d16d501df73b4655a3eb8da5a9aaa357.MTHD_28538c9c235d4f7fb0d4d19722139390()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d16d501df73b4655a3eb8da5a9aaa357.MTHD_ecab7647b28c497dbab749e5c5a2ef0a()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d16d501df73b4655a3eb8da5a9aaa357.MTHD_1457a145d6ae40daaa1e542f95eb3996()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_d16d501df73b4655a3eb8da5a9aaa357.FLDV_d90bb3d643a640a9960f4c2f760c293d());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_d16d501df73b4655a3eb8da5a9aaa357.FLDV_a9fedf73944f4dd4941d503204c4c5ce());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_d16d501df73b4655a3eb8da5a9aaa357.FLDV_af637367c97d4ae6bb59ac7fb7ac6c87());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_d16d501df73b4655a3eb8da5a9aaa357.FLDV_a183d1de3c4d438fb900e5afbf2fe38c());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_d16d501df73b4655a3eb8da5a9aaa357.FLDV_280fdd1f873c431a968d7b90f89b0f94());
      }

      private sealed class MTHD_8be87481ac0048b7b36fa3286a8d53a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8be87481ac0048b7b36fa3286a8d53a4()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_7d29f584ef9647dc87870ef23ba9feff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7d29f584ef9647dc87870ef23ba9feff()
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

      private sealed class MTHD_28538c9c235d4f7fb0d4d19722139390 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_28538c9c235d4f7fb0d4d19722139390()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_ecab7647b28c497dbab749e5c5a2ef0a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ecab7647b28c497dbab749e5c5a2ef0a()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_1457a145d6ae40daaa1e542f95eb3996 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1457a145d6ae40daaa1e542f95eb3996()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_d90bb3d643a640a9960f4c2f760c293d : HardwiredMemberDescriptor
      {
        internal FLDV_d90bb3d643a640a9960f4c2f760c293d()
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

      private sealed class FLDV_a9fedf73944f4dd4941d503204c4c5ce : HardwiredMemberDescriptor
      {
        internal FLDV_a9fedf73944f4dd4941d503204c4c5ce()
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

      private sealed class FLDV_af637367c97d4ae6bb59ac7fb7ac6c87 : HardwiredMemberDescriptor
      {
        internal FLDV_af637367c97d4ae6bb59ac7fb7ac6c87()
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

      private sealed class FLDV_a183d1de3c4d438fb900e5afbf2fe38c : HardwiredMemberDescriptor
      {
        internal FLDV_a183d1de3c4d438fb900e5afbf2fe38c()
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

      private sealed class FLDV_280fdd1f873c431a968d7b90f89b0f94 : HardwiredMemberDescriptor
      {
        internal FLDV_280fdd1f873c431a968d7b90f89b0f94()
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

    private sealed class TYPE_3135d9a88bef41418b9e3134232da12d : HardwiredUserDataDescriptor
    {
      internal TYPE_3135d9a88bef41418b9e3134232da12d()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3135d9a88bef41418b9e3134232da12d.MTHD_adeba4140f094684bc060d75500132c8()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3135d9a88bef41418b9e3134232da12d.MTHD_00ceb92a2a114cbeb13b3ed24c5f27cf()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3135d9a88bef41418b9e3134232da12d.MTHD_d535858f7ec645b4ab6295cbcb36e88d()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3135d9a88bef41418b9e3134232da12d.MTHD_321b6a48e7ce4f87a9509386f7ddeb88()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3135d9a88bef41418b9e3134232da12d.MTHD_46b2fc5a19af472abe6aab3a0c4b1bc2()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3135d9a88bef41418b9e3134232da12d.MTHD_50277be5abf849f4ac99bcfaee64dbee()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3135d9a88bef41418b9e3134232da12d.MTHD_3433870d81294acfb22b1b846bdbe610()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3135d9a88bef41418b9e3134232da12d.MTHD_08137f6a541b46ee997eac0ad2705138()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3135d9a88bef41418b9e3134232da12d.MTHD_4f8c46f85cab42e59b2f913ab4befaf0()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3135d9a88bef41418b9e3134232da12d.MTHD_394015f9caae43de864e96e9ba44ce40()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3135d9a88bef41418b9e3134232da12d.MTHD_0661a3ebde9f45fdbc579bc54553d693()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3135d9a88bef41418b9e3134232da12d.MTHD_d47968ee61664d5d800755fbc4e92d11()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3135d9a88bef41418b9e3134232da12d.MTHD_d3bd1076b5b841b59e8114d5e21da278()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_3135d9a88bef41418b9e3134232da12d.FLDV_1199d845af7441269b672a57110ef2e4());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_3135d9a88bef41418b9e3134232da12d.FLDV_478e4ca227f44cbd87de5d4c9935a751());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_3135d9a88bef41418b9e3134232da12d.FLDV_876a4f1611434efba73f0d669a53b2fa());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_3135d9a88bef41418b9e3134232da12d.FLDV_e685b47b8fcb4d2d8c8909fa95bd9efc());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_3135d9a88bef41418b9e3134232da12d.FLDV_2186813f074e4744a9103548f214b5ea());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_3135d9a88bef41418b9e3134232da12d.FLDV_09e16004c29846aa953d69f40eb969b7());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_3135d9a88bef41418b9e3134232da12d.FLDV_8a2e1364538046ab9592678d840431dd());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_3135d9a88bef41418b9e3134232da12d.FLDV_456aedbca2c644728effc3b92a6c134a());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_3135d9a88bef41418b9e3134232da12d.DVAL_f25fed8adf7c42899aec2c73c67e34f7());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_3135d9a88bef41418b9e3134232da12d.DVAL_ff6097caf6cb4669912323ffefd7483a());
      }

      private sealed class MTHD_adeba4140f094684bc060d75500132c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_adeba4140f094684bc060d75500132c8()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_00ceb92a2a114cbeb13b3ed24c5f27cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_00ceb92a2a114cbeb13b3ed24c5f27cf()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_d535858f7ec645b4ab6295cbcb36e88d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d535858f7ec645b4ab6295cbcb36e88d()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_321b6a48e7ce4f87a9509386f7ddeb88 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_321b6a48e7ce4f87a9509386f7ddeb88()
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

      private sealed class MTHD_46b2fc5a19af472abe6aab3a0c4b1bc2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_46b2fc5a19af472abe6aab3a0c4b1bc2()
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

      private sealed class MTHD_50277be5abf849f4ac99bcfaee64dbee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_50277be5abf849f4ac99bcfaee64dbee()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_3433870d81294acfb22b1b846bdbe610 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3433870d81294acfb22b1b846bdbe610()
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

      private sealed class MTHD_08137f6a541b46ee997eac0ad2705138 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_08137f6a541b46ee997eac0ad2705138()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_4f8c46f85cab42e59b2f913ab4befaf0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4f8c46f85cab42e59b2f913ab4befaf0()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_394015f9caae43de864e96e9ba44ce40 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_394015f9caae43de864e96e9ba44ce40()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_0661a3ebde9f45fdbc579bc54553d693 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0661a3ebde9f45fdbc579bc54553d693()
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

      private sealed class MTHD_d47968ee61664d5d800755fbc4e92d11 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d47968ee61664d5d800755fbc4e92d11()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_d3bd1076b5b841b59e8114d5e21da278 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d3bd1076b5b841b59e8114d5e21da278()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_1199d845af7441269b672a57110ef2e4 : HardwiredMemberDescriptor
      {
        internal FLDV_1199d845af7441269b672a57110ef2e4()
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

      private sealed class FLDV_478e4ca227f44cbd87de5d4c9935a751 : HardwiredMemberDescriptor
      {
        internal FLDV_478e4ca227f44cbd87de5d4c9935a751()
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

      private sealed class FLDV_876a4f1611434efba73f0d669a53b2fa : HardwiredMemberDescriptor
      {
        internal FLDV_876a4f1611434efba73f0d669a53b2fa()
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

      private sealed class FLDV_e685b47b8fcb4d2d8c8909fa95bd9efc : HardwiredMemberDescriptor
      {
        internal FLDV_e685b47b8fcb4d2d8c8909fa95bd9efc()
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

      private sealed class FLDV_2186813f074e4744a9103548f214b5ea : HardwiredMemberDescriptor
      {
        internal FLDV_2186813f074e4744a9103548f214b5ea()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_09e16004c29846aa953d69f40eb969b7 : HardwiredMemberDescriptor
      {
        internal FLDV_09e16004c29846aa953d69f40eb969b7()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_8a2e1364538046ab9592678d840431dd : HardwiredMemberDescriptor
      {
        internal FLDV_8a2e1364538046ab9592678d840431dd()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_456aedbca2c644728effc3b92a6c134a : HardwiredMemberDescriptor
      {
        internal FLDV_456aedbca2c644728effc3b92a6c134a()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_f25fed8adf7c42899aec2c73c67e34f7 : DynValueMemberDescriptor
      {
        internal DVAL_f25fed8adf7c42899aec2c73c67e34f7()
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

      private sealed class DVAL_ff6097caf6cb4669912323ffefd7483a : DynValueMemberDescriptor
      {
        internal DVAL_ff6097caf6cb4669912323ffefd7483a()
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

    private sealed class TYPE_694a4de28c60462b8b04689a1e2ffcaf : HardwiredUserDataDescriptor
    {
      internal TYPE_694a4de28c60462b8b04689a1e2ffcaf()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_694a4de28c60462b8b04689a1e2ffcaf.MTHD_52dc4a105d2b455b9895b94418e930e2()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_694a4de28c60462b8b04689a1e2ffcaf.MTHD_d8f81deb21014abd8256e3a864a7ec95()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_694a4de28c60462b8b04689a1e2ffcaf.MTHD_494bf7af98534cab9fd60b1f0541556a(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_694a4de28c60462b8b04689a1e2ffcaf.MTHD_2d1eb32fcbd14e8c911e2cdd27ebac99()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_694a4de28c60462b8b04689a1e2ffcaf.MTHD_e436eb16cce9466f9e33393d7910f09e(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_694a4de28c60462b8b04689a1e2ffcaf.MTHD_d925bb5d57594aff80fd96bdeeb8ee14()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_694a4de28c60462b8b04689a1e2ffcaf.MTHD_54a09105dcc9427182fe48411c25332c()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_694a4de28c60462b8b04689a1e2ffcaf.MTHD_4278c5ee1dec4340be7da04e92a9f791()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_694a4de28c60462b8b04689a1e2ffcaf.MTHD_1d94734ad7214fc4b637d328a74c2819()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_694a4de28c60462b8b04689a1e2ffcaf.MTHD_fb49da41f0e04359a33ef6fda4f27a06()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_694a4de28c60462b8b04689a1e2ffcaf.FLDV_ed4dd9c23f1443bda03e364c1f137d97());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_694a4de28c60462b8b04689a1e2ffcaf.FLDV_f1c19587e1f040a5ae423b1a7fd57225());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_694a4de28c60462b8b04689a1e2ffcaf.FLDV_33bb356a48aa45a5b34854b19425b367());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_694a4de28c60462b8b04689a1e2ffcaf.FLDV_c9e5292256cc435dae213de744b05263());
        this.AddMember("white", (IMemberDescriptor) new Bridge.TYPE_694a4de28c60462b8b04689a1e2ffcaf.FLDV_1d0c600e94ae4881ae57cbea10d5450f());
      }

      private sealed class MTHD_52dc4a105d2b455b9895b94418e930e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52dc4a105d2b455b9895b94418e930e2()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_d8f81deb21014abd8256e3a864a7ec95 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8f81deb21014abd8256e3a864a7ec95()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_494bf7af98534cab9fd60b1f0541556a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_494bf7af98534cab9fd60b1f0541556a()
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

      private sealed class MTHD_2d1eb32fcbd14e8c911e2cdd27ebac99 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d1eb32fcbd14e8c911e2cdd27ebac99()
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

      private sealed class MTHD_e436eb16cce9466f9e33393d7910f09e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e436eb16cce9466f9e33393d7910f09e()
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

      private sealed class MTHD_d925bb5d57594aff80fd96bdeeb8ee14 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d925bb5d57594aff80fd96bdeeb8ee14()
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

      private sealed class MTHD_54a09105dcc9427182fe48411c25332c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_54a09105dcc9427182fe48411c25332c()
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

      private sealed class MTHD_4278c5ee1dec4340be7da04e92a9f791 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4278c5ee1dec4340be7da04e92a9f791()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_1d94734ad7214fc4b637d328a74c2819 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d94734ad7214fc4b637d328a74c2819()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_fb49da41f0e04359a33ef6fda4f27a06 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb49da41f0e04359a33ef6fda4f27a06()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_ed4dd9c23f1443bda03e364c1f137d97 : HardwiredMemberDescriptor
      {
        internal FLDV_ed4dd9c23f1443bda03e364c1f137d97()
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

      private sealed class FLDV_f1c19587e1f040a5ae423b1a7fd57225 : HardwiredMemberDescriptor
      {
        internal FLDV_f1c19587e1f040a5ae423b1a7fd57225()
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

      private sealed class FLDV_33bb356a48aa45a5b34854b19425b367 : HardwiredMemberDescriptor
      {
        internal FLDV_33bb356a48aa45a5b34854b19425b367()
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

      private sealed class FLDV_c9e5292256cc435dae213de744b05263 : HardwiredMemberDescriptor
      {
        internal FLDV_c9e5292256cc435dae213de744b05263()
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

      private sealed class FLDV_1d0c600e94ae4881ae57cbea10d5450f : HardwiredMemberDescriptor
      {
        internal FLDV_1d0c600e94ae4881ae57cbea10d5450f()
          : base(typeof (LuaColor), "white", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) LuaColor.white;
        }
      }
    }

    private sealed class TYPE_695f3d6b54a44409878437a2de85b915 : HardwiredUserDataDescriptor
    {
      internal TYPE_695f3d6b54a44409878437a2de85b915()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_695f3d6b54a44409878437a2de85b915.MTHD_a4198b948efa40ffaa51f9ac3bad4222()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_695f3d6b54a44409878437a2de85b915.MTHD_cb985141db0447c28aab23d6599c38d1()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_695f3d6b54a44409878437a2de85b915.MTHD_53f04e9222ab45bfad3db00e8f3ed107()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_695f3d6b54a44409878437a2de85b915.MTHD_1a55916e164c4271b02a18647c70d3e3()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_695f3d6b54a44409878437a2de85b915.MTHD_401a0199269444408f055289960afdb5()
        }));
      }

      private sealed class MTHD_a4198b948efa40ffaa51f9ac3bad4222 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a4198b948efa40ffaa51f9ac3bad4222()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_cb985141db0447c28aab23d6599c38d1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cb985141db0447c28aab23d6599c38d1()
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

      private sealed class MTHD_53f04e9222ab45bfad3db00e8f3ed107 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_53f04e9222ab45bfad3db00e8f3ed107()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_1a55916e164c4271b02a18647c70d3e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a55916e164c4271b02a18647c70d3e3()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_401a0199269444408f055289960afdb5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_401a0199269444408f055289960afdb5()
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
