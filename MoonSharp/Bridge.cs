
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
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_557b2f1cbc1241c9a7be194428b8845a());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_8441218b935f4f21b5181d0ec4a182ac());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_2da1e58eb6074909b0d062944e6a19f7());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_2003afdea1144f37b5d90ea266abc186());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_c3f1ab5d6f204a68ae19a47081030328());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_f78b440f7ab7422cbfe82aa338b2a895());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_2ead9aa734a14ce2b7af9df82cc6a4fa());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_ba97315355dc47dbb8cc13c9982d27e0());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_0393fef799aa439ba60d3bb3bb6d3466());
    }

    private sealed class TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997 : HardwiredUserDataDescriptor
    {
      internal TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_ffe64e05d7ca4e3cb1fc4e705d1b136a()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_e69f5945f2eb46709b66dc9ed9fe3291()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_93f368d501ed4be6a2140c20b01f7891()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_d9350361a2de4d0d96d1c7b670c24c33()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_c9bb061528414637b92ab919e655d656()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_ef9b4fba81664166a97b34b52af97af7()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_aaee7fd2f6c548148e42138fde34b9cf()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_9bb3898408304ea1862d142c3a69ee55()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_4b3c5fe459aa41febe651cbc2d93c3b9()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_78c29493ce794563932729ee295a54d0()
        }));
        this.AddMember("hideInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("hideInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_56710109430243d5a0370a9a45fdc86d()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_5fc4ac10d10148eea97f582b5aa2d38d()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_5b15b39c53f44ef1bcf011987cb63cda()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_95cba8af3d7d43f191fcec0ba09a588c()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_184d58cca0db44a8ad9f5b93399efe5d()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_7f166ea1a0b848cabd68bffd9d6114b3()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_092cc15ba02a434fa3d4520b1d7addaa()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_4fda500454d94ed4b422ac6df070174d()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_a1a0317c0dfa4ac78d3088bfb2834db5()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_810748b3ce4e4e16b3160cfb5d94a94b()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_941f565d7cc448d5abd35d8881576292()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_d0193030cf3545c499aef41cb13775c7()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_c3551298f69443f08561ec983958b8be()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_de68ad6da7c34b0ca2fa6c9f841d92ac()
        }));
        this.AddMember("get_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_70c67c4140a44417bc383c27414705fb()
        }));
        this.AddMember("set_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_3bf5b86fbba742fc96ef10e8947264de()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_f6b3988d1bf044d9b939dd676c549b02()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_5c48ac66d7db4b36abae8e6f286c75c6()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_c41d5fbe120b4bd3a65f6c38fb47f961()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_9f5ecaa1671449ab81cc0ecf96386a54()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_44354bd9124142afb346839b3984e157()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_b7b4d6fba4b148ada3b3eda1b6ec010f()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_3fa50b0e983d4801a19e556dabdf4d84()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_70be6a7fb7714490b9a3a7ac4c68936f()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_6ac7876593744d96a93076f87e9077d2()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_d25705bb09f446d5bea69609a591af92()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_ad107fb64eab494bb1c7dbdb34afe1e3()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_12d0b272b0e042b0b1f0aadb430218b0()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_d55b5f56853e455c8a3620cc1e37aad6()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_c75ead40e3db4b27a4504c6df2fa782c()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_cb3e8ec4d1f84e598d1614f85c84601a()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_b284972f707f4f54b1a3cfad5722f944()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_cbe4fef5527e4802be81ff8e47d1d0fb()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_dd7e6adee1d348d8a89e499dc5569d86()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_f3d372e8ead441a6b6400d4f9172d75b()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_ca5f8bdae30f488392655ebfbea2ea2b()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_0aa4e6ebe5ed4f50a65d804df4f2e2a0()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_5d7e6755420f4edabecc3f747512682e()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_f98de41b514f46b1b07309e5b97952da()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_f65ed65945dc43e39dbfb8e0b0f84571()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_b45c1b72426147c0bcfb098a3fb9c1b8()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_22f5076513224029b8df3c9ad0382b69()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_5106fb6e9b454d8cb690b8597cc6c8d9()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_c3d2ccf1e1974f6cab3ebcb57f878c17()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_e199b6e0837949a6a46698d6b0bbd05b()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_74051a2bf68e49599344dca91fcfbd20()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_0dea6513f906481790041b5b55892608()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_9188a7bd4df24e7683f4c1fe04c85c7a()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_e60257a2965840b4ab426410a4ea1813()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_4000e5ac23f545699908dbb2c59a2e0f()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_d4388a13424641bba7885c4499ddb4ba()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_f6b8b6e22d824ea89efae4893ef79575()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_9470bd5c494b46ecb90bcff71d88fad5()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_740f2bd2888347d1982c45e01de6a21b()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_a98e58a1dc4b4c40a18be955d105a664()
        }));
        this.AddMember("Dispose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Dispose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_c9ccdb4fef684553912c6d278075c472()
        }));
        this.AddMember("drawImage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawImage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_e72a6785de3e422ca417faba97753776()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_f1835c2811be4b498b758eb71d1d51fc()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_16a1c08525894d8d9094b8f422c0cfc3()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_e96fe7ea5f4342e29b6f0f4d7ade8f47()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_3b78305d8c8b44b79d6cf927b82df007()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_6474e928d78849a5accfa81ce785f412()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_934153cbb1dd443090fd65e65de78dd6()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_d1c5c2f3dcc34483b6b8148a04632e01()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_be3ac0304c534a3f9f4b49842d3e2daa()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_55bd7f308b9f49e1914801461f1e6335()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_2749b192a68548819a276eab71394ee0()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_76ff41a36e884efa91803f5283d49340()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_d73ca53b344b4ee5b1f2fbe020ffe5c6()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_1f568a4019ae4b43a89f41b3a10194cd()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_9a5e5cf9ea0845da8de5d10404427c07()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_225dd26d43d74e1bb89e2514c2dbb44d()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_2a29f185d7c94a88ba5f024ba04a4cc6()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_408d9da517974d26b6780b36bc03e001()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_0c78d371cf6f4f3da743f87b2384989e()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_75c056922b70446e9f8bd3fa15dc6770()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_0ea306897ac948b8a955b33ed7bac56a()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_329b6f18e7a044c6bcbdc4a7f08196b3()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_a010b8921d024add86ec6778c6594296()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_e9af38d3aee047dca2c55cbc5a30f87e()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_883a2a36597e4269b60516d449622488()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_54e942a4c454427e9de83b50a23745e1()
        }));
        this.AddMember("cameraFollow", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("cameraFollow", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_48915e5916b847058480add585236df9()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_3bd1e5298c4841138aa0deb9a42f77d8()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_21c2b8a6a3534f479e166919bc6ef77d()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_bcc3cfca8dc24036bcfcb0ae90250bec()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_26f94b0d75be47ec89947c7b5097a3b5()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_13107e7cb30f412880f8576b7f0c452f()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_71c902823fe646f5b7064f06bdc028b9(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_db3d26ec84a74891a298b2e5a0b99a05()
        }));
        this.AddMember("getKeyBinds", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getKeyBinds", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_74de5efe96104784951b6f0fcc3fbc45()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_1ae177660d614f50aa1e28ac5499df19()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_d2ca16d0b7174348bf196f1c1f8009de()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_aa5ebfd4b1b54430b2d2b0a89e3e4599()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.MTHD_a51e3693495c418aae37b83f3a4feff4()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_1a0115cbd8cc4fc189e9029550f19748());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_d3a9c943a7a84d52980c4b7d16cfa87c());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_f1d081866b9f4a3ba2d42349a58be0f3());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_8a8df841b009432a92be3a24ef4cfd85());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_7debcf318c644dd690c0837c49d52917());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_224c21cebccf4efeb426059077cb2579());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_6cd0ff1498a94ce2aa5848b4937bad72());
        this.AddMember("allowMinionMovement", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_50a7256ae0bf477399fced96b7f818ec());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_b301889ce3084dc4aa2bac4aded7004f());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_c2b3fe5c751843619055b670f5792b5e());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_b3aa8408f4ed42eb8d6a6e613d9150d3());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_354c57825d454ebdb39826eb22a832bf());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_e9775af80c90429baedcd070242e2999());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_218e048c83a64f2da8247a5bd1e6391f());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_be7cf0ceb3624ca086c5131c740b39f7());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_5ad7a092b4b44dcda45ed07916a66ea4());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_ed03779dbb7243e6a231cb94072bd9fd());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_10519e23d7054e78930370864c4615eb());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_b59d0c81bd1a4b7dbdb02f6eb9ff8073());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_89430ba633374f1abbf1ddf5a6a86b87());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_8f8320ed5c414a6a9f8070863a1ce86d());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_a0172766863c4e83ba3ce8d63cca0a33());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_d6f7f453e7684bbbb428d9dd5e35fee5());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_244049c94f5b498ea8ed23d525bd63bf());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_4ba08c79a3074ced89331614fa815990());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_1186de727c6142bdb5ed2c33e00e6e5c());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_06a2abc26d904a78beb0dbc5eb48b103());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_7bdf71910450451aa39bd360ffaef9e9());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_149178217d064e3695fadc7eac1b6127());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_1031cb6121ef4650985d980c9ab8e4e7());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_9c2501c0b7aa4855a51c173bd51c09a9());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_ccfc9b1b675146228c0eccdf6ce66757());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_36b04e0d088e4b94bfc4c8f9f4ed8997.PROP_9bcf75dc25d34be9bd73559f4a80b509());
      }

      private sealed class MTHD_ffe64e05d7ca4e3cb1fc4e705d1b136a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ffe64e05d7ca4e3cb1fc4e705d1b136a()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_e69f5945f2eb46709b66dc9ed9fe3291 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e69f5945f2eb46709b66dc9ed9fe3291()
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

      private sealed class MTHD_93f368d501ed4be6a2140c20b01f7891 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93f368d501ed4be6a2140c20b01f7891()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_d9350361a2de4d0d96d1c7b670c24c33 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d9350361a2de4d0d96d1c7b670c24c33()
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

      private sealed class MTHD_c9bb061528414637b92ab919e655d656 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c9bb061528414637b92ab919e655d656()
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

      private sealed class MTHD_ef9b4fba81664166a97b34b52af97af7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef9b4fba81664166a97b34b52af97af7()
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

      private sealed class MTHD_aaee7fd2f6c548148e42138fde34b9cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aaee7fd2f6c548148e42138fde34b9cf()
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

      private sealed class MTHD_9bb3898408304ea1862d142c3a69ee55 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9bb3898408304ea1862d142c3a69ee55()
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

      private sealed class MTHD_4b3c5fe459aa41febe651cbc2d93c3b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b3c5fe459aa41febe651cbc2d93c3b9()
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

      private sealed class MTHD_78c29493ce794563932729ee295a54d0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_78c29493ce794563932729ee295a54d0()
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

      private sealed class MTHD_56710109430243d5a0370a9a45fdc86d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_56710109430243d5a0370a9a45fdc86d()
        {
          this.Initialize("hideInfo", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).hideInfo();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_5fc4ac10d10148eea97f582b5aa2d38d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5fc4ac10d10148eea97f582b5aa2d38d()
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

      private sealed class MTHD_5b15b39c53f44ef1bcf011987cb63cda : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b15b39c53f44ef1bcf011987cb63cda()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_95cba8af3d7d43f191fcec0ba09a588c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95cba8af3d7d43f191fcec0ba09a588c()
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

      private sealed class MTHD_184d58cca0db44a8ad9f5b93399efe5d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_184d58cca0db44a8ad9f5b93399efe5d()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_7f166ea1a0b848cabd68bffd9d6114b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f166ea1a0b848cabd68bffd9d6114b3()
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

      private sealed class MTHD_092cc15ba02a434fa3d4520b1d7addaa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_092cc15ba02a434fa3d4520b1d7addaa()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_4fda500454d94ed4b422ac6df070174d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4fda500454d94ed4b422ac6df070174d()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_a1a0317c0dfa4ac78d3088bfb2834db5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1a0317c0dfa4ac78d3088bfb2834db5()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_810748b3ce4e4e16b3160cfb5d94a94b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_810748b3ce4e4e16b3160cfb5d94a94b()
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

      private sealed class MTHD_941f565d7cc448d5abd35d8881576292 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_941f565d7cc448d5abd35d8881576292()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_d0193030cf3545c499aef41cb13775c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0193030cf3545c499aef41cb13775c7()
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

      private sealed class MTHD_c3551298f69443f08561ec983958b8be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c3551298f69443f08561ec983958b8be()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_de68ad6da7c34b0ca2fa6c9f841d92ac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de68ad6da7c34b0ca2fa6c9f841d92ac()
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

      private sealed class MTHD_70c67c4140a44417bc383c27414705fb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70c67c4140a44417bc383c27414705fb()
        {
          this.Initialize("get_allowMinionMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMinionMovement;
        }
      }

      private sealed class MTHD_3bf5b86fbba742fc96ef10e8947264de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3bf5b86fbba742fc96ef10e8947264de()
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

      private sealed class MTHD_f6b3988d1bf044d9b939dd676c549b02 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f6b3988d1bf044d9b939dd676c549b02()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_5c48ac66d7db4b36abae8e6f286c75c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c48ac66d7db4b36abae8e6f286c75c6()
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

      private sealed class MTHD_c41d5fbe120b4bd3a65f6c38fb47f961 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c41d5fbe120b4bd3a65f6c38fb47f961()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_9f5ecaa1671449ab81cc0ecf96386a54 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f5ecaa1671449ab81cc0ecf96386a54()
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

      private sealed class MTHD_44354bd9124142afb346839b3984e157 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_44354bd9124142afb346839b3984e157()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_b7b4d6fba4b148ada3b3eda1b6ec010f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b7b4d6fba4b148ada3b3eda1b6ec010f()
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

      private sealed class MTHD_3fa50b0e983d4801a19e556dabdf4d84 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3fa50b0e983d4801a19e556dabdf4d84()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_70be6a7fb7714490b9a3a7ac4c68936f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70be6a7fb7714490b9a3a7ac4c68936f()
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

      private sealed class MTHD_6ac7876593744d96a93076f87e9077d2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ac7876593744d96a93076f87e9077d2()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_d25705bb09f446d5bea69609a591af92 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d25705bb09f446d5bea69609a591af92()
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

      private sealed class MTHD_ad107fb64eab494bb1c7dbdb34afe1e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ad107fb64eab494bb1c7dbdb34afe1e3()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_12d0b272b0e042b0b1f0aadb430218b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_12d0b272b0e042b0b1f0aadb430218b0()
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

      private sealed class MTHD_d55b5f56853e455c8a3620cc1e37aad6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d55b5f56853e455c8a3620cc1e37aad6()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_c75ead40e3db4b27a4504c6df2fa782c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c75ead40e3db4b27a4504c6df2fa782c()
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

      private sealed class MTHD_cb3e8ec4d1f84e598d1614f85c84601a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cb3e8ec4d1f84e598d1614f85c84601a()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_b284972f707f4f54b1a3cfad5722f944 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b284972f707f4f54b1a3cfad5722f944()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_cbe4fef5527e4802be81ff8e47d1d0fb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cbe4fef5527e4802be81ff8e47d1d0fb()
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

      private sealed class MTHD_dd7e6adee1d348d8a89e499dc5569d86 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dd7e6adee1d348d8a89e499dc5569d86()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_f3d372e8ead441a6b6400d4f9172d75b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f3d372e8ead441a6b6400d4f9172d75b()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_ca5f8bdae30f488392655ebfbea2ea2b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ca5f8bdae30f488392655ebfbea2ea2b()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_0aa4e6ebe5ed4f50a65d804df4f2e2a0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0aa4e6ebe5ed4f50a65d804df4f2e2a0()
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

      private sealed class MTHD_5d7e6755420f4edabecc3f747512682e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d7e6755420f4edabecc3f747512682e()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_f98de41b514f46b1b07309e5b97952da : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f98de41b514f46b1b07309e5b97952da()
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

      private sealed class MTHD_f65ed65945dc43e39dbfb8e0b0f84571 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f65ed65945dc43e39dbfb8e0b0f84571()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_b45c1b72426147c0bcfb098a3fb9c1b8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b45c1b72426147c0bcfb098a3fb9c1b8()
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

      private sealed class MTHD_22f5076513224029b8df3c9ad0382b69 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22f5076513224029b8df3c9ad0382b69()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_5106fb6e9b454d8cb690b8597cc6c8d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5106fb6e9b454d8cb690b8597cc6c8d9()
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

      private sealed class MTHD_c3d2ccf1e1974f6cab3ebcb57f878c17 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c3d2ccf1e1974f6cab3ebcb57f878c17()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_e199b6e0837949a6a46698d6b0bbd05b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e199b6e0837949a6a46698d6b0bbd05b()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_74051a2bf68e49599344dca91fcfbd20 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74051a2bf68e49599344dca91fcfbd20()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_0dea6513f906481790041b5b55892608 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0dea6513f906481790041b5b55892608()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_9188a7bd4df24e7683f4c1fe04c85c7a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9188a7bd4df24e7683f4c1fe04c85c7a()
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

      private sealed class MTHD_e60257a2965840b4ab426410a4ea1813 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e60257a2965840b4ab426410a4ea1813()
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

      private sealed class MTHD_4000e5ac23f545699908dbb2c59a2e0f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4000e5ac23f545699908dbb2c59a2e0f()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_d4388a13424641bba7885c4499ddb4ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d4388a13424641bba7885c4499ddb4ba()
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

      private sealed class MTHD_f6b8b6e22d824ea89efae4893ef79575 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f6b8b6e22d824ea89efae4893ef79575()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_9470bd5c494b46ecb90bcff71d88fad5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9470bd5c494b46ecb90bcff71d88fad5()
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

      private sealed class MTHD_740f2bd2888347d1982c45e01de6a21b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_740f2bd2888347d1982c45e01de6a21b()
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

      private sealed class MTHD_a98e58a1dc4b4c40a18be955d105a664 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a98e58a1dc4b4c40a18be955d105a664()
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

      private sealed class MTHD_c9ccdb4fef684553912c6d278075c472 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c9ccdb4fef684553912c6d278075c472()
        {
          this.Initialize("Dispose", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ContainerGame.Dispose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_e72a6785de3e422ca417faba97753776 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e72a6785de3e422ca417faba97753776()
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

      private sealed class MTHD_f1835c2811be4b498b758eb71d1d51fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f1835c2811be4b498b758eb71d1d51fc()
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

      private sealed class MTHD_16a1c08525894d8d9094b8f422c0cfc3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_16a1c08525894d8d9094b8f422c0cfc3()
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

      private sealed class MTHD_e96fe7ea5f4342e29b6f0f4d7ade8f47 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e96fe7ea5f4342e29b6f0f4d7ade8f47()
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

      private sealed class MTHD_3b78305d8c8b44b79d6cf927b82df007 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3b78305d8c8b44b79d6cf927b82df007()
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

      private sealed class MTHD_6474e928d78849a5accfa81ce785f412 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6474e928d78849a5accfa81ce785f412()
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

      private sealed class MTHD_934153cbb1dd443090fd65e65de78dd6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_934153cbb1dd443090fd65e65de78dd6()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_d1c5c2f3dcc34483b6b8148a04632e01 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1c5c2f3dcc34483b6b8148a04632e01()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_be3ac0304c534a3f9f4b49842d3e2daa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be3ac0304c534a3f9f4b49842d3e2daa()
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

      private sealed class MTHD_55bd7f308b9f49e1914801461f1e6335 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_55bd7f308b9f49e1914801461f1e6335()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_2749b192a68548819a276eab71394ee0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2749b192a68548819a276eab71394ee0()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_76ff41a36e884efa91803f5283d49340 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76ff41a36e884efa91803f5283d49340()
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

      private sealed class MTHD_d73ca53b344b4ee5b1f2fbe020ffe5c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d73ca53b344b4ee5b1f2fbe020ffe5c6()
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

      private sealed class MTHD_1f568a4019ae4b43a89f41b3a10194cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f568a4019ae4b43a89f41b3a10194cd()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9a5e5cf9ea0845da8de5d10404427c07 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9a5e5cf9ea0845da8de5d10404427c07()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_225dd26d43d74e1bb89e2514c2dbb44d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_225dd26d43d74e1bb89e2514c2dbb44d()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_2a29f185d7c94a88ba5f024ba04a4cc6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a29f185d7c94a88ba5f024ba04a4cc6()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_408d9da517974d26b6780b36bc03e001 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_408d9da517974d26b6780b36bc03e001()
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

      private sealed class MTHD_0c78d371cf6f4f3da743f87b2384989e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c78d371cf6f4f3da743f87b2384989e()
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

      private sealed class MTHD_75c056922b70446e9f8bd3fa15dc6770 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75c056922b70446e9f8bd3fa15dc6770()
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

      private sealed class MTHD_0ea306897ac948b8a955b33ed7bac56a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ea306897ac948b8a955b33ed7bac56a()
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

      private sealed class MTHD_329b6f18e7a044c6bcbdc4a7f08196b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_329b6f18e7a044c6bcbdc4a7f08196b3()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_a010b8921d024add86ec6778c6594296 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a010b8921d024add86ec6778c6594296()
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

      private sealed class MTHD_e9af38d3aee047dca2c55cbc5a30f87e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e9af38d3aee047dca2c55cbc5a30f87e()
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

      private sealed class MTHD_883a2a36597e4269b60516d449622488 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_883a2a36597e4269b60516d449622488()
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

      private sealed class MTHD_54e942a4c454427e9de83b50a23745e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_54e942a4c454427e9de83b50a23745e1()
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

      private sealed class MTHD_48915e5916b847058480add585236df9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_48915e5916b847058480add585236df9()
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

      private sealed class MTHD_3bd1e5298c4841138aa0deb9a42f77d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3bd1e5298c4841138aa0deb9a42f77d8()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_21c2b8a6a3534f479e166919bc6ef77d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_21c2b8a6a3534f479e166919bc6ef77d()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_bcc3cfca8dc24036bcfcb0ae90250bec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bcc3cfca8dc24036bcfcb0ae90250bec()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_26f94b0d75be47ec89947c7b5097a3b5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_26f94b0d75be47ec89947c7b5097a3b5()
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

      private sealed class MTHD_13107e7cb30f412880f8576b7f0c452f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_13107e7cb30f412880f8576b7f0c452f()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_71c902823fe646f5b7064f06bdc028b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_71c902823fe646f5b7064f06bdc028b9()
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

      private sealed class MTHD_db3d26ec84a74891a298b2e5a0b99a05 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db3d26ec84a74891a298b2e5a0b99a05()
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

      private sealed class MTHD_74de5efe96104784951b6f0fcc3fbc45 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74de5efe96104784951b6f0fcc3fbc45()
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

      private sealed class MTHD_1ae177660d614f50aa1e28ac5499df19 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ae177660d614f50aa1e28ac5499df19()
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

      private sealed class MTHD_d2ca16d0b7174348bf196f1c1f8009de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d2ca16d0b7174348bf196f1c1f8009de()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_aa5ebfd4b1b54430b2d2b0a89e3e4599 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa5ebfd4b1b54430b2d2b0a89e3e4599()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_a51e3693495c418aae37b83f3a4feff4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a51e3693495c418aae37b83f3a4feff4()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_1a0115cbd8cc4fc189e9029550f19748 : HardwiredMemberDescriptor
      {
        internal PROP_1a0115cbd8cc4fc189e9029550f19748()
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

      private sealed class PROP_d3a9c943a7a84d52980c4b7d16cfa87c : HardwiredMemberDescriptor
      {
        internal PROP_d3a9c943a7a84d52980c4b7d16cfa87c()
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

      private sealed class PROP_f1d081866b9f4a3ba2d42349a58be0f3 : HardwiredMemberDescriptor
      {
        internal PROP_f1d081866b9f4a3ba2d42349a58be0f3()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_8a8df841b009432a92be3a24ef4cfd85 : HardwiredMemberDescriptor
      {
        internal PROP_8a8df841b009432a92be3a24ef4cfd85()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_7debcf318c644dd690c0837c49d52917 : HardwiredMemberDescriptor
      {
        internal PROP_7debcf318c644dd690c0837c49d52917()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_224c21cebccf4efeb426059077cb2579 : HardwiredMemberDescriptor
      {
        internal PROP_224c21cebccf4efeb426059077cb2579()
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

      private sealed class PROP_6cd0ff1498a94ce2aa5848b4937bad72 : HardwiredMemberDescriptor
      {
        internal PROP_6cd0ff1498a94ce2aa5848b4937bad72()
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

      private sealed class PROP_50a7256ae0bf477399fced96b7f818ec : HardwiredMemberDescriptor
      {
        internal PROP_50a7256ae0bf477399fced96b7f818ec()
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

      private sealed class PROP_b301889ce3084dc4aa2bac4aded7004f : HardwiredMemberDescriptor
      {
        internal PROP_b301889ce3084dc4aa2bac4aded7004f()
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

      private sealed class PROP_c2b3fe5c751843619055b670f5792b5e : HardwiredMemberDescriptor
      {
        internal PROP_c2b3fe5c751843619055b670f5792b5e()
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

      private sealed class PROP_b3aa8408f4ed42eb8d6a6e613d9150d3 : HardwiredMemberDescriptor
      {
        internal PROP_b3aa8408f4ed42eb8d6a6e613d9150d3()
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

      private sealed class PROP_354c57825d454ebdb39826eb22a832bf : HardwiredMemberDescriptor
      {
        internal PROP_354c57825d454ebdb39826eb22a832bf()
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

      private sealed class PROP_e9775af80c90429baedcd070242e2999 : HardwiredMemberDescriptor
      {
        internal PROP_e9775af80c90429baedcd070242e2999()
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

      private sealed class PROP_218e048c83a64f2da8247a5bd1e6391f : HardwiredMemberDescriptor
      {
        internal PROP_218e048c83a64f2da8247a5bd1e6391f()
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

      private sealed class PROP_be7cf0ceb3624ca086c5131c740b39f7 : HardwiredMemberDescriptor
      {
        internal PROP_be7cf0ceb3624ca086c5131c740b39f7()
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

      private sealed class PROP_5ad7a092b4b44dcda45ed07916a66ea4 : HardwiredMemberDescriptor
      {
        internal PROP_5ad7a092b4b44dcda45ed07916a66ea4()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_ed03779dbb7243e6a231cb94072bd9fd : HardwiredMemberDescriptor
      {
        internal PROP_ed03779dbb7243e6a231cb94072bd9fd()
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

      private sealed class PROP_10519e23d7054e78930370864c4615eb : HardwiredMemberDescriptor
      {
        internal PROP_10519e23d7054e78930370864c4615eb()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_b59d0c81bd1a4b7dbdb02f6eb9ff8073 : HardwiredMemberDescriptor
      {
        internal PROP_b59d0c81bd1a4b7dbdb02f6eb9ff8073()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_89430ba633374f1abbf1ddf5a6a86b87 : HardwiredMemberDescriptor
      {
        internal PROP_89430ba633374f1abbf1ddf5a6a86b87()
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

      private sealed class PROP_8f8320ed5c414a6a9f8070863a1ce86d : HardwiredMemberDescriptor
      {
        internal PROP_8f8320ed5c414a6a9f8070863a1ce86d()
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

      private sealed class PROP_a0172766863c4e83ba3ce8d63cca0a33 : HardwiredMemberDescriptor
      {
        internal PROP_a0172766863c4e83ba3ce8d63cca0a33()
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

      private sealed class PROP_d6f7f453e7684bbbb428d9dd5e35fee5 : HardwiredMemberDescriptor
      {
        internal PROP_d6f7f453e7684bbbb428d9dd5e35fee5()
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

      private sealed class PROP_244049c94f5b498ea8ed23d525bd63bf : HardwiredMemberDescriptor
      {
        internal PROP_244049c94f5b498ea8ed23d525bd63bf()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_4ba08c79a3074ced89331614fa815990 : HardwiredMemberDescriptor
      {
        internal PROP_4ba08c79a3074ced89331614fa815990()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_1186de727c6142bdb5ed2c33e00e6e5c : HardwiredMemberDescriptor
      {
        internal PROP_1186de727c6142bdb5ed2c33e00e6e5c()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_06a2abc26d904a78beb0dbc5eb48b103 : HardwiredMemberDescriptor
      {
        internal PROP_06a2abc26d904a78beb0dbc5eb48b103()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_7bdf71910450451aa39bd360ffaef9e9 : HardwiredMemberDescriptor
      {
        internal PROP_7bdf71910450451aa39bd360ffaef9e9()
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

      private sealed class PROP_149178217d064e3695fadc7eac1b6127 : HardwiredMemberDescriptor
      {
        internal PROP_149178217d064e3695fadc7eac1b6127()
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

      private sealed class PROP_1031cb6121ef4650985d980c9ab8e4e7 : HardwiredMemberDescriptor
      {
        internal PROP_1031cb6121ef4650985d980c9ab8e4e7()
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

      private sealed class PROP_9c2501c0b7aa4855a51c173bd51c09a9 : HardwiredMemberDescriptor
      {
        internal PROP_9c2501c0b7aa4855a51c173bd51c09a9()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_ccfc9b1b675146228c0eccdf6ce66757 : HardwiredMemberDescriptor
      {
        internal PROP_ccfc9b1b675146228c0eccdf6ce66757()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_9bcf75dc25d34be9bd73559f4a80b509 : HardwiredMemberDescriptor
      {
        internal PROP_9bcf75dc25d34be9bd73559f4a80b509()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_557b2f1cbc1241c9a7be194428b8845a : HardwiredUserDataDescriptor
    {
      internal TYPE_557b2f1cbc1241c9a7be194428b8845a()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_557b2f1cbc1241c9a7be194428b8845a.MTHD_458eb34bdb8a49e8b964958e2e582779()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_557b2f1cbc1241c9a7be194428b8845a.MTHD_11d6d3f9f8f54fd081060e48165548dd()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_557b2f1cbc1241c9a7be194428b8845a.MTHD_c2773b638727412f9c047bffc120eeb9()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_557b2f1cbc1241c9a7be194428b8845a.MTHD_9e85db73030e47b99bda4f915a84d0f0()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_557b2f1cbc1241c9a7be194428b8845a.MTHD_690ead019e704ffb8cfb82c7d596c78d()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_557b2f1cbc1241c9a7be194428b8845a.MTHD_ed25b6b00c0642e29672d5b006053752()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_557b2f1cbc1241c9a7be194428b8845a.MTHD_714c3190ffa640ce8c6e20cd02a41976()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_557b2f1cbc1241c9a7be194428b8845a.MTHD_ee567cfd272a4cd1b729ac1ec36ff86d()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_557b2f1cbc1241c9a7be194428b8845a.MTHD_538832b118c648ec8c570330be7dcc77()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_557b2f1cbc1241c9a7be194428b8845a.MTHD_2b08dbac0e5a40ef8c31519f5592b0c1()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_557b2f1cbc1241c9a7be194428b8845a.MTHD_0610d6f694c24423a88bd10f02f097d6()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_557b2f1cbc1241c9a7be194428b8845a.MTHD_13e79bf638ea4ecf97da4cac8f7937b3()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_557b2f1cbc1241c9a7be194428b8845a.PROP_3c5801491c3845f49b24e7d9d9464259());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_557b2f1cbc1241c9a7be194428b8845a.PROP_00b4647876f842f59b67db5804bb4c3c());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_557b2f1cbc1241c9a7be194428b8845a.PROP_e80e48a3e2e04bd7ba7170b65b138a2b());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_557b2f1cbc1241c9a7be194428b8845a.PROP_599698e921dc4810a8836c0abb57eecf());
      }

      private sealed class MTHD_458eb34bdb8a49e8b964958e2e582779 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_458eb34bdb8a49e8b964958e2e582779()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_11d6d3f9f8f54fd081060e48165548dd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_11d6d3f9f8f54fd081060e48165548dd()
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

      private sealed class MTHD_c2773b638727412f9c047bffc120eeb9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c2773b638727412f9c047bffc120eeb9()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_9e85db73030e47b99bda4f915a84d0f0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e85db73030e47b99bda4f915a84d0f0()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_690ead019e704ffb8cfb82c7d596c78d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_690ead019e704ffb8cfb82c7d596c78d()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_ed25b6b00c0642e29672d5b006053752 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed25b6b00c0642e29672d5b006053752()
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

      private sealed class MTHD_714c3190ffa640ce8c6e20cd02a41976 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_714c3190ffa640ce8c6e20cd02a41976()
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

      private sealed class MTHD_ee567cfd272a4cd1b729ac1ec36ff86d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee567cfd272a4cd1b729ac1ec36ff86d()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_538832b118c648ec8c570330be7dcc77 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_538832b118c648ec8c570330be7dcc77()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_2b08dbac0e5a40ef8c31519f5592b0c1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b08dbac0e5a40ef8c31519f5592b0c1()
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

      private sealed class MTHD_0610d6f694c24423a88bd10f02f097d6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0610d6f694c24423a88bd10f02f097d6()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_13e79bf638ea4ecf97da4cac8f7937b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_13e79bf638ea4ecf97da4cac8f7937b3()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_3c5801491c3845f49b24e7d9d9464259 : HardwiredMemberDescriptor
      {
        internal PROP_3c5801491c3845f49b24e7d9d9464259()
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

      private sealed class PROP_00b4647876f842f59b67db5804bb4c3c : HardwiredMemberDescriptor
      {
        internal PROP_00b4647876f842f59b67db5804bb4c3c()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_e80e48a3e2e04bd7ba7170b65b138a2b : HardwiredMemberDescriptor
      {
        internal PROP_e80e48a3e2e04bd7ba7170b65b138a2b()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_599698e921dc4810a8836c0abb57eecf : HardwiredMemberDescriptor
      {
        internal PROP_599698e921dc4810a8836c0abb57eecf()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_76c3974028a3453da26db73aeceee209 : HardwiredUserDataDescriptor
    {
      internal TYPE_76c3974028a3453da26db73aeceee209()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_b1969834f0a541978a61f43f6e5969ce()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_60844b9118e14b719cc15bc8ccd913b2()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_2465ac06b7f44ca4ac52420dcc8f4b67()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_fb6eb379fc99492a902a08b8e44e58f7()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_c56d97f95bd5472e96da9ccddb08b3b5()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_6fefca091ffc4d5fb49f044f30bb0ab8()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_78f6407b2b204f3b92f31166ad6b8993()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_96a91df8b2c04119bd118f9048992acf()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_9efe9585b0ee4a22b1847f33efb3d1d4()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_0fef0d5f797140f8802c041a6ca2cabe()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_35d81c34177645da919b76fd9f30d1c7()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_9885a73fe44d48cf9416e1389799d930()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_b06b6ea5154a43b19a02487e0eea1f84()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_bd0839f909234a21a449fb8e3cc98624()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_5a1c9cdf7fd74ef89bc231d124ded48c()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_48d264fe64684158a1be7268d368a124()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_51bc3fb643d446e2b8f9576cc2114482()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_76d3e23de014470291ee8f57b0ab79d8()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_75849fd386154b999de857d34c66bafd()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_3a60b99b9f48451abdaeb49d0a8bd59b()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_5ac7f5994eb842aead3372997ddee42f()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_f580c580fd6f473792b6cd4df33e9c5e()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_23527a46c60d4837ae792f45cb7c6268()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_7fbdec8e45104008b21b2898d3bc8def()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_7162b4d25414475e9a5df416df8c7cfa()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_1023bd5c47f143429dcb2db7522e68a6()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_232b26c4bf554034a3bd01b62a1ec92a()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_b57ece86349f410ca3a995105fccb2a5()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_ce379c7f0cdb48138db8683c096a5def()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_9c48a386a4a445dbafe5fd9e07383f5b()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_3a116a3befca49c2b35e3f9f582640f0()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_41609cb9b1324e8e9f44c015afdc9ef9()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_0e3f8a8ca3e8406abf639413ac02fe53()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_0125f14abbf440f6af0494dd32b5c307()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_86ce654a326a46e3a736920573966014()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_d360c71ad2b14011888b75cb9e7648a8()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_85eb879ab54942a5a775687fadac4aec()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_97a11c600a11487c86183a817fd8aa26()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_7f0f38f12fa74449b2b5423ed8cfe3e8()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_846ce14438d749208d3d3877e96f0ae7()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_ff903929c73f47b398c54831baf65f55()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_5d8b063230c64772830a98966904c7f4()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_457012fa80854de2afb1977f602f77ec()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_0a64fd6c0cb64fe9921e6fa8d8843349()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_475a5efe37c94e6fa928fac6fd879f32()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_789cffc2224e4027a937f35dbea87e20()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_5d867a1d930e4b028b986c5a192c4c4d()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_94e670d7300a48e69cf9e7957ba8ef0f()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_aa8a8cfab0294b65a24788c0cd7aa2c0()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_d749817e6b60429eb0dcee99787b4d71()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_a1ab6e65d3fc4742af9b07e90871a7cb()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_2bc4a0ba5b874059a95f226e76679b16()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_c9c5a293d373406893e1166e547f8379()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_e6fd1c5d64d949f0a1516bdeab77b8c2()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_3a488511971649768c96d8c3c5ab5b46()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_db0d83bff1294a20a965be2e43b1331e()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_b5cf57272cfb4a539d08e66e35660621()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_021cfbaaf551493b85bd930600322852()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_9d0765f5762d4b60bb757b6d8c51d362()
        }));
        this.AddMember("getDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_22552ee90c0a4d4a870dc533df61a848()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_b7fe3e8e7f9545c1a74aec5e602a6cab()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_3e082d1036c942cea99f4f71bb199c3e()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_42dfe34237b64ea19aafc73abe64177c()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_59fee5c12b6a485a94d4ff9868fc1575()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_ce08f461d3db46039f4da5cfa687d798(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_95f150784df948ba822b508c734a6e43()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_053cef7946af4126aa32720f3ff8e85a(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_898952a8989145378cb6204d68b07b33()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_197126a2dc1648e697c65a40166876a0()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_d50c8d5ca364463eb0e4fcf875605e9e()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_0bb41f9e2c364c8d985181c424bdfcb1(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_10c44ad1e1904341a55c7af3900fb5e1()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_c0b1a068a26b4d84844749dad6282240()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_446c088e807445b7b7d94bb42274bc83()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_d5ff2abf0a4f4b098548d20db91af842()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_cf93a6994db64755853c11e04ceef663()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_29b6202ed1fe4aceb68ebe9fca3a5e4f()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_3a1b72bb9d9243f5924a7f37f59bdd03()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_47b1841c8afb4a2ebedd2778f9b61359()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_ffaf6bf4cea94fc3b3c788121a3122ed()
        }));
        this.AddMember("angleToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("angleToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_0acb274f36f94b9f8d072bc581e981bc()
        }));
        this.AddMember("powerToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("powerToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_8e9c456e84834d3fbd96bdb952d63c88()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_ef6fbafa9179465199516679be7a9d4e(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_db5ad4ff00644764a4ab7ac36924e7df()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_97d72f53a1234f3f90994a582f61e927(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_8ef17e58627f40ed82db52dd754959dc()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_fac5ae758834459c98ff869f70db3624()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_15f16c04133a42a88c31d6226072c54b()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_3015ec61aed24cbcaa47bfeab06e26ee()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_6ab2e7ec0d564659a780b592bbb4bcdf()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_795eedd646b1407caf325d42f8047d55()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.MTHD_bb5f40045d6f4be8a6688f4ddeefbbd3()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_67218892a41c469496279ad3ed692d06());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_6ca03d2c39ba479fbfd00401ebbea3c1());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_3879da57c99d48e6a32636c10cf9e051());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_a7ef9d09ed8649779f98bb9500144f14());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_519bbea247a14b56927c817baa377166());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_ba7b151a41694521b3e9d3fff072ede5());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_469bd858bb794e49a5d57e782dc8b27c());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_81a151eac556409a9d551bb3e51e386f());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_cac7f5b62ebf495296b60ff52dc60ff8());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_b7508ba1efb941c99a1abd3db9cca3fb());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_e80b5b34900c479e9df333ab60c4b1a5());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_53b872f4879f40d08e17b956dd763ba4());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_c646bfd666284eca926243c4368512e7());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_5ba700d419e74207b345992d34b8e2fd());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_dd35a5ce97ef4de79c1e0c47a9d328e8());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_e24f4b18920442a49fa2cd32e4f196f6());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_b3a62dd8e47641ef9a44b685cdb2893d());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_03f10be020f5435c88dc5f709edcb2ca());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_e0d46c821eec4aed8cee325a20c9800c());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_56fd9e8a4b85482d92d641d5dff56b30());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_075cd78bc04249a5b7775999c495452f());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_7a17ebbbb3b74e76b6c9a9cedd6a64f6());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_925e41a00c6b4378af6402e57549ff8c());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_bf47cd551899471b94321bfc5f7a07c4());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_85d4331f5c11410a85ab6d3af2adad69());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_97aba4d7dd73417baed4554d2959e3ed());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_08eacd7531264f92b36f7aeeb7276399());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_8fe7054d42a948f8a719a8ed6fdae18b());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_903fcec3ae6148b58195517cafc731e0());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_4e2726146dd847db963c871c83f6029f());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_ebd9001a143745fa8bb0f8238bea8855());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_5c4665cb05ad4eb8acb70d931490f999());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_76c3974028a3453da26db73aeceee209.PROP_1544708adb8a4dd9a646a07bf82bdd31());
      }

      private sealed class MTHD_b1969834f0a541978a61f43f6e5969ce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b1969834f0a541978a61f43f6e5969ce()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_60844b9118e14b719cc15bc8ccd913b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60844b9118e14b719cc15bc8ccd913b2()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_2465ac06b7f44ca4ac52420dcc8f4b67 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2465ac06b7f44ca4ac52420dcc8f4b67()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_fb6eb379fc99492a902a08b8e44e58f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb6eb379fc99492a902a08b8e44e58f7()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_c56d97f95bd5472e96da9ccddb08b3b5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c56d97f95bd5472e96da9ccddb08b3b5()
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

      private sealed class MTHD_6fefca091ffc4d5fb49f044f30bb0ab8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6fefca091ffc4d5fb49f044f30bb0ab8()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_78f6407b2b204f3b92f31166ad6b8993 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_78f6407b2b204f3b92f31166ad6b8993()
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

      private sealed class MTHD_96a91df8b2c04119bd118f9048992acf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_96a91df8b2c04119bd118f9048992acf()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_9efe9585b0ee4a22b1847f33efb3d1d4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9efe9585b0ee4a22b1847f33efb3d1d4()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_0fef0d5f797140f8802c041a6ca2cabe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0fef0d5f797140f8802c041a6ca2cabe()
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

      private sealed class MTHD_35d81c34177645da919b76fd9f30d1c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35d81c34177645da919b76fd9f30d1c7()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_9885a73fe44d48cf9416e1389799d930 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9885a73fe44d48cf9416e1389799d930()
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

      private sealed class MTHD_b06b6ea5154a43b19a02487e0eea1f84 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b06b6ea5154a43b19a02487e0eea1f84()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_bd0839f909234a21a449fb8e3cc98624 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd0839f909234a21a449fb8e3cc98624()
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

      private sealed class MTHD_5a1c9cdf7fd74ef89bc231d124ded48c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5a1c9cdf7fd74ef89bc231d124ded48c()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_48d264fe64684158a1be7268d368a124 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_48d264fe64684158a1be7268d368a124()
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

      private sealed class MTHD_51bc3fb643d446e2b8f9576cc2114482 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_51bc3fb643d446e2b8f9576cc2114482()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_76d3e23de014470291ee8f57b0ab79d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76d3e23de014470291ee8f57b0ab79d8()
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

      private sealed class MTHD_75849fd386154b999de857d34c66bafd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75849fd386154b999de857d34c66bafd()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_3a60b99b9f48451abdaeb49d0a8bd59b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3a60b99b9f48451abdaeb49d0a8bd59b()
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

      private sealed class MTHD_5ac7f5994eb842aead3372997ddee42f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ac7f5994eb842aead3372997ddee42f()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_f580c580fd6f473792b6cd4df33e9c5e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f580c580fd6f473792b6cd4df33e9c5e()
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

      private sealed class MTHD_23527a46c60d4837ae792f45cb7c6268 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_23527a46c60d4837ae792f45cb7c6268()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_7fbdec8e45104008b21b2898d3bc8def : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7fbdec8e45104008b21b2898d3bc8def()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_7162b4d25414475e9a5df416df8c7cfa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7162b4d25414475e9a5df416df8c7cfa()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_1023bd5c47f143429dcb2db7522e68a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1023bd5c47f143429dcb2db7522e68a6()
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

      private sealed class MTHD_232b26c4bf554034a3bd01b62a1ec92a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_232b26c4bf554034a3bd01b62a1ec92a()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_b57ece86349f410ca3a995105fccb2a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b57ece86349f410ca3a995105fccb2a5()
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

      private sealed class MTHD_ce379c7f0cdb48138db8683c096a5def : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ce379c7f0cdb48138db8683c096a5def()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_9c48a386a4a445dbafe5fd9e07383f5b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c48a386a4a445dbafe5fd9e07383f5b()
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

      private sealed class MTHD_3a116a3befca49c2b35e3f9f582640f0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3a116a3befca49c2b35e3f9f582640f0()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_41609cb9b1324e8e9f44c015afdc9ef9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41609cb9b1324e8e9f44c015afdc9ef9()
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

      private sealed class MTHD_0e3f8a8ca3e8406abf639413ac02fe53 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e3f8a8ca3e8406abf639413ac02fe53()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_0125f14abbf440f6af0494dd32b5c307 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0125f14abbf440f6af0494dd32b5c307()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_86ce654a326a46e3a736920573966014 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_86ce654a326a46e3a736920573966014()
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

      private sealed class MTHD_d360c71ad2b14011888b75cb9e7648a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d360c71ad2b14011888b75cb9e7648a8()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_85eb879ab54942a5a775687fadac4aec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85eb879ab54942a5a775687fadac4aec()
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

      private sealed class MTHD_97a11c600a11487c86183a817fd8aa26 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97a11c600a11487c86183a817fd8aa26()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_7f0f38f12fa74449b2b5423ed8cfe3e8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f0f38f12fa74449b2b5423ed8cfe3e8()
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

      private sealed class MTHD_846ce14438d749208d3d3877e96f0ae7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_846ce14438d749208d3d3877e96f0ae7()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_ff903929c73f47b398c54831baf65f55 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff903929c73f47b398c54831baf65f55()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_5d8b063230c64772830a98966904c7f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d8b063230c64772830a98966904c7f4()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_457012fa80854de2afb1977f602f77ec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_457012fa80854de2afb1977f602f77ec()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_0a64fd6c0cb64fe9921e6fa8d8843349 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0a64fd6c0cb64fe9921e6fa8d8843349()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_475a5efe37c94e6fa928fac6fd879f32 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_475a5efe37c94e6fa928fac6fd879f32()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_789cffc2224e4027a937f35dbea87e20 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_789cffc2224e4027a937f35dbea87e20()
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

      private sealed class MTHD_5d867a1d930e4b028b986c5a192c4c4d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d867a1d930e4b028b986c5a192c4c4d()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_94e670d7300a48e69cf9e7957ba8ef0f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_94e670d7300a48e69cf9e7957ba8ef0f()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_aa8a8cfab0294b65a24788c0cd7aa2c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa8a8cfab0294b65a24788c0cd7aa2c0()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_d749817e6b60429eb0dcee99787b4d71 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d749817e6b60429eb0dcee99787b4d71()
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

      private sealed class MTHD_a1ab6e65d3fc4742af9b07e90871a7cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1ab6e65d3fc4742af9b07e90871a7cb()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_2bc4a0ba5b874059a95f226e76679b16 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2bc4a0ba5b874059a95f226e76679b16()
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

      private sealed class MTHD_c9c5a293d373406893e1166e547f8379 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c9c5a293d373406893e1166e547f8379()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_e6fd1c5d64d949f0a1516bdeab77b8c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e6fd1c5d64d949f0a1516bdeab77b8c2()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_3a488511971649768c96d8c3c5ab5b46 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3a488511971649768c96d8c3c5ab5b46()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_db0d83bff1294a20a965be2e43b1331e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db0d83bff1294a20a965be2e43b1331e()
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

      private sealed class MTHD_b5cf57272cfb4a539d08e66e35660621 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b5cf57272cfb4a539d08e66e35660621()
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

      private sealed class MTHD_021cfbaaf551493b85bd930600322852 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_021cfbaaf551493b85bd930600322852()
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

      private sealed class MTHD_9d0765f5762d4b60bb757b6d8c51d362 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d0765f5762d4b60bb757b6d8c51d362()
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

      private sealed class MTHD_22552ee90c0a4d4a870dc533df61a848 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22552ee90c0a4d4a870dc533df61a848()
        {
          this.Initialize("getDirection", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getDirection();
        }
      }

      private sealed class MTHD_b7fe3e8e7f9545c1a74aec5e602a6cab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b7fe3e8e7f9545c1a74aec5e602a6cab()
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

      private sealed class MTHD_3e082d1036c942cea99f4f71bb199c3e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e082d1036c942cea99f4f71bb199c3e()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_42dfe34237b64ea19aafc73abe64177c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42dfe34237b64ea19aafc73abe64177c()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_59fee5c12b6a485a94d4ff9868fc1575 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_59fee5c12b6a485a94d4ff9868fc1575()
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

      private sealed class MTHD_ce08f461d3db46039f4da5cfa687d798 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ce08f461d3db46039f4da5cfa687d798()
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

      private sealed class MTHD_95f150784df948ba822b508c734a6e43 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95f150784df948ba822b508c734a6e43()
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

      private sealed class MTHD_053cef7946af4126aa32720f3ff8e85a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_053cef7946af4126aa32720f3ff8e85a()
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

      private sealed class MTHD_898952a8989145378cb6204d68b07b33 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_898952a8989145378cb6204d68b07b33()
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

      private sealed class MTHD_197126a2dc1648e697c65a40166876a0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_197126a2dc1648e697c65a40166876a0()
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

      private sealed class MTHD_d50c8d5ca364463eb0e4fcf875605e9e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d50c8d5ca364463eb0e4fcf875605e9e()
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

      private sealed class MTHD_0bb41f9e2c364c8d985181c424bdfcb1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0bb41f9e2c364c8d985181c424bdfcb1()
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

      private sealed class MTHD_10c44ad1e1904341a55c7af3900fb5e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_10c44ad1e1904341a55c7af3900fb5e1()
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

      private sealed class MTHD_c0b1a068a26b4d84844749dad6282240 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c0b1a068a26b4d84844749dad6282240()
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

      private sealed class MTHD_446c088e807445b7b7d94bb42274bc83 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_446c088e807445b7b7d94bb42274bc83()
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

      private sealed class MTHD_d5ff2abf0a4f4b098548d20db91af842 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d5ff2abf0a4f4b098548d20db91af842()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_cf93a6994db64755853c11e04ceef663 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf93a6994db64755853c11e04ceef663()
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

      private sealed class MTHD_29b6202ed1fe4aceb68ebe9fca3a5e4f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_29b6202ed1fe4aceb68ebe9fca3a5e4f()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_3a1b72bb9d9243f5924a7f37f59bdd03 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3a1b72bb9d9243f5924a7f37f59bdd03()
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

      private sealed class MTHD_47b1841c8afb4a2ebedd2778f9b61359 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_47b1841c8afb4a2ebedd2778f9b61359()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_ffaf6bf4cea94fc3b3c788121a3122ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ffaf6bf4cea94fc3b3c788121a3122ed()
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

      private sealed class MTHD_0acb274f36f94b9f8d072bc581e981bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0acb274f36f94b9f8d072bc581e981bc()
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

      private sealed class MTHD_8e9c456e84834d3fbd96bdb952d63c88 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e9c456e84834d3fbd96bdb952d63c88()
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

      private sealed class MTHD_ef6fbafa9179465199516679be7a9d4e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef6fbafa9179465199516679be7a9d4e()
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

      private sealed class MTHD_db5ad4ff00644764a4ab7ac36924e7df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db5ad4ff00644764a4ab7ac36924e7df()
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

      private sealed class MTHD_97d72f53a1234f3f90994a582f61e927 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97d72f53a1234f3f90994a582f61e927()
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

      private sealed class MTHD_8ef17e58627f40ed82db52dd754959dc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ef17e58627f40ed82db52dd754959dc()
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

      private sealed class MTHD_fac5ae758834459c98ff869f70db3624 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fac5ae758834459c98ff869f70db3624()
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

      private sealed class MTHD_15f16c04133a42a88c31d6226072c54b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15f16c04133a42a88c31d6226072c54b()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_3015ec61aed24cbcaa47bfeab06e26ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3015ec61aed24cbcaa47bfeab06e26ee()
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

      private sealed class MTHD_6ab2e7ec0d564659a780b592bbb4bcdf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ab2e7ec0d564659a780b592bbb4bcdf()
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

      private sealed class MTHD_795eedd646b1407caf325d42f8047d55 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_795eedd646b1407caf325d42f8047d55()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_bb5f40045d6f4be8a6688f4ddeefbbd3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb5f40045d6f4be8a6688f4ddeefbbd3()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_67218892a41c469496279ad3ed692d06 : HardwiredMemberDescriptor
      {
        internal PROP_67218892a41c469496279ad3ed692d06()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_6ca03d2c39ba479fbfd00401ebbea3c1 : HardwiredMemberDescriptor
      {
        internal PROP_6ca03d2c39ba479fbfd00401ebbea3c1()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_3879da57c99d48e6a32636c10cf9e051 : HardwiredMemberDescriptor
      {
        internal PROP_3879da57c99d48e6a32636c10cf9e051()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_a7ef9d09ed8649779f98bb9500144f14 : HardwiredMemberDescriptor
      {
        internal PROP_a7ef9d09ed8649779f98bb9500144f14()
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

      private sealed class PROP_519bbea247a14b56927c817baa377166 : HardwiredMemberDescriptor
      {
        internal PROP_519bbea247a14b56927c817baa377166()
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

      private sealed class PROP_ba7b151a41694521b3e9d3fff072ede5 : HardwiredMemberDescriptor
      {
        internal PROP_ba7b151a41694521b3e9d3fff072ede5()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_469bd858bb794e49a5d57e782dc8b27c : HardwiredMemberDescriptor
      {
        internal PROP_469bd858bb794e49a5d57e782dc8b27c()
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

      private sealed class PROP_81a151eac556409a9d551bb3e51e386f : HardwiredMemberDescriptor
      {
        internal PROP_81a151eac556409a9d551bb3e51e386f()
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

      private sealed class PROP_cac7f5b62ebf495296b60ff52dc60ff8 : HardwiredMemberDescriptor
      {
        internal PROP_cac7f5b62ebf495296b60ff52dc60ff8()
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

      private sealed class PROP_b7508ba1efb941c99a1abd3db9cca3fb : HardwiredMemberDescriptor
      {
        internal PROP_b7508ba1efb941c99a1abd3db9cca3fb()
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

      private sealed class PROP_e80b5b34900c479e9df333ab60c4b1a5 : HardwiredMemberDescriptor
      {
        internal PROP_e80b5b34900c479e9df333ab60c4b1a5()
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

      private sealed class PROP_53b872f4879f40d08e17b956dd763ba4 : HardwiredMemberDescriptor
      {
        internal PROP_53b872f4879f40d08e17b956dd763ba4()
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

      private sealed class PROP_c646bfd666284eca926243c4368512e7 : HardwiredMemberDescriptor
      {
        internal PROP_c646bfd666284eca926243c4368512e7()
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

      private sealed class PROP_5ba700d419e74207b345992d34b8e2fd : HardwiredMemberDescriptor
      {
        internal PROP_5ba700d419e74207b345992d34b8e2fd()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_dd35a5ce97ef4de79c1e0c47a9d328e8 : HardwiredMemberDescriptor
      {
        internal PROP_dd35a5ce97ef4de79c1e0c47a9d328e8()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_e24f4b18920442a49fa2cd32e4f196f6 : HardwiredMemberDescriptor
      {
        internal PROP_e24f4b18920442a49fa2cd32e4f196f6()
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

      private sealed class PROP_b3a62dd8e47641ef9a44b685cdb2893d : HardwiredMemberDescriptor
      {
        internal PROP_b3a62dd8e47641ef9a44b685cdb2893d()
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

      private sealed class PROP_03f10be020f5435c88dc5f709edcb2ca : HardwiredMemberDescriptor
      {
        internal PROP_03f10be020f5435c88dc5f709edcb2ca()
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

      private sealed class PROP_e0d46c821eec4aed8cee325a20c9800c : HardwiredMemberDescriptor
      {
        internal PROP_e0d46c821eec4aed8cee325a20c9800c()
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

      private sealed class PROP_56fd9e8a4b85482d92d641d5dff56b30 : HardwiredMemberDescriptor
      {
        internal PROP_56fd9e8a4b85482d92d641d5dff56b30()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_075cd78bc04249a5b7775999c495452f : HardwiredMemberDescriptor
      {
        internal PROP_075cd78bc04249a5b7775999c495452f()
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

      private sealed class PROP_7a17ebbbb3b74e76b6c9a9cedd6a64f6 : HardwiredMemberDescriptor
      {
        internal PROP_7a17ebbbb3b74e76b6c9a9cedd6a64f6()
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

      private sealed class PROP_925e41a00c6b4378af6402e57549ff8c : HardwiredMemberDescriptor
      {
        internal PROP_925e41a00c6b4378af6402e57549ff8c()
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

      private sealed class PROP_bf47cd551899471b94321bfc5f7a07c4 : HardwiredMemberDescriptor
      {
        internal PROP_bf47cd551899471b94321bfc5f7a07c4()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_85d4331f5c11410a85ab6d3af2adad69 : HardwiredMemberDescriptor
      {
        internal PROP_85d4331f5c11410a85ab6d3af2adad69()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_97aba4d7dd73417baed4554d2959e3ed : HardwiredMemberDescriptor
      {
        internal PROP_97aba4d7dd73417baed4554d2959e3ed()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_08eacd7531264f92b36f7aeeb7276399 : HardwiredMemberDescriptor
      {
        internal PROP_08eacd7531264f92b36f7aeeb7276399()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_8fe7054d42a948f8a719a8ed6fdae18b : HardwiredMemberDescriptor
      {
        internal PROP_8fe7054d42a948f8a719a8ed6fdae18b()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_903fcec3ae6148b58195517cafc731e0 : HardwiredMemberDescriptor
      {
        internal PROP_903fcec3ae6148b58195517cafc731e0()
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

      private sealed class PROP_4e2726146dd847db963c871c83f6029f : HardwiredMemberDescriptor
      {
        internal PROP_4e2726146dd847db963c871c83f6029f()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_ebd9001a143745fa8bb0f8238bea8855 : HardwiredMemberDescriptor
      {
        internal PROP_ebd9001a143745fa8bb0f8238bea8855()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_5c4665cb05ad4eb8acb70d931490f999 : HardwiredMemberDescriptor
      {
        internal PROP_5c4665cb05ad4eb8acb70d931490f999()
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

      private sealed class PROP_1544708adb8a4dd9a646a07bf82bdd31 : HardwiredMemberDescriptor
      {
        internal PROP_1544708adb8a4dd9a646a07bf82bdd31()
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

    private sealed class TYPE_197389fd07ac4145b8e1ac009ef29ea0 : HardwiredUserDataDescriptor
    {
      internal TYPE_197389fd07ac4145b8e1ac009ef29ea0()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.MTHD_299349039b34447e9e67337b638c9282()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.MTHD_2b0cee0986a84272bed80f3ca051359b()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.MTHD_a2a10933804743c496c4db61ed3d3258()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.MTHD_8f5fb0c720a3414aaee8bab7d2ed0d6d()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.MTHD_828233c51b184ddab89cc35550137912()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.MTHD_bfa7f9a896f3420aaa79f1a090107cbb()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.MTHD_05cde07b810446b48fb514b49f34363f()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.MTHD_62e751d439de4da1bbf9bac15ae350f1()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.MTHD_84c2900d68f04754a21842888844fddf()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.MTHD_54ac35ae92ad4768a3629785f2581b99()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.MTHD_22939bd1b64b47c79e97e1c515fbb35f()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.MTHD_b5100cd2b4fc4acbbfbfd86a06900fd4()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.MTHD_46412758e81a4f0ea96f00f4bc1b5847()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.MTHD_4065878abe6448eabd1537a1c1e3f878()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.MTHD_64dc7bd62161404a96e30692a016b522()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.MTHD_f5cba244adad4711bd3ac785b250ef1b()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.MTHD_5b91ea41a65e44ada518bafd248e077e()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.MTHD_cf328879ab2e4601afae00807ae9529b()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.MTHD_407a8c9c6c5b4811b6a3044ae64e4f73()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.MTHD_2dcbc23c225343e09a23208d2c25275e()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.PROP_bfb56afe6e134df7b11513243e008c02());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.PROP_4678a70198ae4e4292ff84f8c5aad6c9());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.PROP_e167da2bba9f498c8c30171e1e7f97e2());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.PROP_fc181af8b22b404789e42992374b16d3());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.PROP_842b836f79d244b48b619e0100092aa5());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.PROP_53e6108af79a4e06afdc898593c80dae());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.PROP_cca9a7023f99412ebf54fcb266918ca8());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_197389fd07ac4145b8e1ac009ef29ea0.PROP_40db8bad3fd64530b797c606ffda426a());
      }

      private sealed class MTHD_299349039b34447e9e67337b638c9282 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_299349039b34447e9e67337b638c9282()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_2b0cee0986a84272bed80f3ca051359b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b0cee0986a84272bed80f3ca051359b()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_a2a10933804743c496c4db61ed3d3258 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2a10933804743c496c4db61ed3d3258()
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

      private sealed class MTHD_8f5fb0c720a3414aaee8bab7d2ed0d6d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8f5fb0c720a3414aaee8bab7d2ed0d6d()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_828233c51b184ddab89cc35550137912 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_828233c51b184ddab89cc35550137912()
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

      private sealed class MTHD_bfa7f9a896f3420aaa79f1a090107cbb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bfa7f9a896f3420aaa79f1a090107cbb()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_05cde07b810446b48fb514b49f34363f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_05cde07b810446b48fb514b49f34363f()
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

      private sealed class MTHD_62e751d439de4da1bbf9bac15ae350f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_62e751d439de4da1bbf9bac15ae350f1()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_84c2900d68f04754a21842888844fddf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84c2900d68f04754a21842888844fddf()
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

      private sealed class MTHD_54ac35ae92ad4768a3629785f2581b99 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_54ac35ae92ad4768a3629785f2581b99()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_22939bd1b64b47c79e97e1c515fbb35f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22939bd1b64b47c79e97e1c515fbb35f()
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

      private sealed class MTHD_b5100cd2b4fc4acbbfbfd86a06900fd4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b5100cd2b4fc4acbbfbfd86a06900fd4()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_46412758e81a4f0ea96f00f4bc1b5847 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_46412758e81a4f0ea96f00f4bc1b5847()
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

      private sealed class MTHD_4065878abe6448eabd1537a1c1e3f878 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4065878abe6448eabd1537a1c1e3f878()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_64dc7bd62161404a96e30692a016b522 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_64dc7bd62161404a96e30692a016b522()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f5cba244adad4711bd3ac785b250ef1b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f5cba244adad4711bd3ac785b250ef1b()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_5b91ea41a65e44ada518bafd248e077e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b91ea41a65e44ada518bafd248e077e()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_cf328879ab2e4601afae00807ae9529b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf328879ab2e4601afae00807ae9529b()
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

      private sealed class MTHD_407a8c9c6c5b4811b6a3044ae64e4f73 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_407a8c9c6c5b4811b6a3044ae64e4f73()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_2dcbc23c225343e09a23208d2c25275e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2dcbc23c225343e09a23208d2c25275e()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_bfb56afe6e134df7b11513243e008c02 : HardwiredMemberDescriptor
      {
        internal PROP_bfb56afe6e134df7b11513243e008c02()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_4678a70198ae4e4292ff84f8c5aad6c9 : HardwiredMemberDescriptor
      {
        internal PROP_4678a70198ae4e4292ff84f8c5aad6c9()
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

      private sealed class PROP_e167da2bba9f498c8c30171e1e7f97e2 : HardwiredMemberDescriptor
      {
        internal PROP_e167da2bba9f498c8c30171e1e7f97e2()
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

      private sealed class PROP_fc181af8b22b404789e42992374b16d3 : HardwiredMemberDescriptor
      {
        internal PROP_fc181af8b22b404789e42992374b16d3()
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

      private sealed class PROP_842b836f79d244b48b619e0100092aa5 : HardwiredMemberDescriptor
      {
        internal PROP_842b836f79d244b48b619e0100092aa5()
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

      private sealed class PROP_53e6108af79a4e06afdc898593c80dae : HardwiredMemberDescriptor
      {
        internal PROP_53e6108af79a4e06afdc898593c80dae()
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

      private sealed class PROP_cca9a7023f99412ebf54fcb266918ca8 : HardwiredMemberDescriptor
      {
        internal PROP_cca9a7023f99412ebf54fcb266918ca8()
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

      private sealed class PROP_40db8bad3fd64530b797c606ffda426a : HardwiredMemberDescriptor
      {
        internal PROP_40db8bad3fd64530b797c606ffda426a()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_094049021b84433b8fb82f56d7a29cc4 : HardwiredUserDataDescriptor
    {
      internal TYPE_094049021b84433b8fb82f56d7a29cc4()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.MTHD_301b8e47b8c344a9941980c598c52d2f()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.MTHD_3369449ecbe14194a87b98147eebbed4()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.MTHD_eeb4b89916c04841888f604cd83af6d5()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.MTHD_9b0fecf3212f4225ab15edb427d51006()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.MTHD_de45d361928343be818102ce9a0509c3()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.MTHD_767e70045f4c457084c0b0658299d4bf()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.MTHD_1fd3f044eb554281b618a15d1826b159()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.MTHD_a5f8131cda0941bda740c5ab7a4959bf()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.MTHD_7510531ef7804fc48b84edd6131232c2()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.MTHD_679c86f6f93f4b10920e7d8090afcb04()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.MTHD_34cbc5e7ce404c93b0fcf7d79b6c5d71()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.MTHD_f51eb3dc8c984d0aa1f1362b42c3a5e4()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.MTHD_b7201c5988324807b0f364f9ef308183()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.MTHD_39cbdda5f7044cc286055528b00c7bde()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.MTHD_d6fa686c2d0b4c64932327d8dc2ab617()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.MTHD_33383bd9f31c4a1b948f2256c3708616()
        }));
        this.AddMember("setIcon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setIcon", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.MTHD_8ad2e2614b8d45d98b4fdf83dbee4235()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.MTHD_9939f507f49847f58457ef3e5f63ae7e()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.MTHD_37367a9f7d0947a6ac885e3c06f27eb4()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.MTHD_ea1d5e1cdc5f4754bf3c57b627b8a713()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.MTHD_dc04ca6ca1264942986d88408e4ffc19()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.MTHD_9cba3549f3314492949b5458db46e9b0()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.PROP_2283be4739c6450f860e754ff42cbcb2());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.PROP_6faea9672c3840d585a92e6add6edc74());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.PROP_55b102f8e51c4a019c52e35af8632e49());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.PROP_ef648970521d4655abfd0d0219e4b55f());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.PROP_48c40cd4c06b481ea6bf97e52864c9f6());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.PROP_473cfb1a373b444ea903a940d727927d());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.PROP_29842e62f9264fd5abe13a2b1c0d3eb9());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.PROP_a782a475200746fb9be77f7f1121d0b0());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_094049021b84433b8fb82f56d7a29cc4.PROP_2d044309ce97467cb708fafe94a3e010());
      }

      private sealed class MTHD_301b8e47b8c344a9941980c598c52d2f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_301b8e47b8c344a9941980c598c52d2f()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_3369449ecbe14194a87b98147eebbed4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3369449ecbe14194a87b98147eebbed4()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_eeb4b89916c04841888f604cd83af6d5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eeb4b89916c04841888f604cd83af6d5()
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

      private sealed class MTHD_9b0fecf3212f4225ab15edb427d51006 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b0fecf3212f4225ab15edb427d51006()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_de45d361928343be818102ce9a0509c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de45d361928343be818102ce9a0509c3()
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

      private sealed class MTHD_767e70045f4c457084c0b0658299d4bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_767e70045f4c457084c0b0658299d4bf()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_1fd3f044eb554281b618a15d1826b159 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1fd3f044eb554281b618a15d1826b159()
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

      private sealed class MTHD_a5f8131cda0941bda740c5ab7a4959bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a5f8131cda0941bda740c5ab7a4959bf()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_7510531ef7804fc48b84edd6131232c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7510531ef7804fc48b84edd6131232c2()
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

      private sealed class MTHD_679c86f6f93f4b10920e7d8090afcb04 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_679c86f6f93f4b10920e7d8090afcb04()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_34cbc5e7ce404c93b0fcf7d79b6c5d71 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_34cbc5e7ce404c93b0fcf7d79b6c5d71()
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

      private sealed class MTHD_f51eb3dc8c984d0aa1f1362b42c3a5e4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f51eb3dc8c984d0aa1f1362b42c3a5e4()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_b7201c5988324807b0f364f9ef308183 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b7201c5988324807b0f364f9ef308183()
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

      private sealed class MTHD_39cbdda5f7044cc286055528b00c7bde : HardwiredMethodMemberDescriptor
      {
        internal MTHD_39cbdda5f7044cc286055528b00c7bde()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color2;
        }
      }

      private sealed class MTHD_d6fa686c2d0b4c64932327d8dc2ab617 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6fa686c2d0b4c64932327d8dc2ab617()
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

      private sealed class MTHD_33383bd9f31c4a1b948f2256c3708616 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_33383bd9f31c4a1b948f2256c3708616()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_8ad2e2614b8d45d98b4fdf83dbee4235 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ad2e2614b8d45d98b4fdf83dbee4235()
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

      private sealed class MTHD_9939f507f49847f58457ef3e5f63ae7e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9939f507f49847f58457ef3e5f63ae7e()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_37367a9f7d0947a6ac885e3c06f27eb4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_37367a9f7d0947a6ac885e3c06f27eb4()
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

      private sealed class MTHD_ea1d5e1cdc5f4754bf3c57b627b8a713 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea1d5e1cdc5f4754bf3c57b627b8a713()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_dc04ca6ca1264942986d88408e4ffc19 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc04ca6ca1264942986d88408e4ffc19()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_9cba3549f3314492949b5458db46e9b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9cba3549f3314492949b5458db46e9b0()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_2283be4739c6450f860e754ff42cbcb2 : HardwiredMemberDescriptor
      {
        internal PROP_2283be4739c6450f860e754ff42cbcb2()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_6faea9672c3840d585a92e6add6edc74 : HardwiredMemberDescriptor
      {
        internal PROP_6faea9672c3840d585a92e6add6edc74()
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

      private sealed class PROP_55b102f8e51c4a019c52e35af8632e49 : HardwiredMemberDescriptor
      {
        internal PROP_55b102f8e51c4a019c52e35af8632e49()
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

      private sealed class PROP_ef648970521d4655abfd0d0219e4b55f : HardwiredMemberDescriptor
      {
        internal PROP_ef648970521d4655abfd0d0219e4b55f()
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

      private sealed class PROP_48c40cd4c06b481ea6bf97e52864c9f6 : HardwiredMemberDescriptor
      {
        internal PROP_48c40cd4c06b481ea6bf97e52864c9f6()
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

      private sealed class PROP_473cfb1a373b444ea903a940d727927d : HardwiredMemberDescriptor
      {
        internal PROP_473cfb1a373b444ea903a940d727927d()
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

      private sealed class PROP_29842e62f9264fd5abe13a2b1c0d3eb9 : HardwiredMemberDescriptor
      {
        internal PROP_29842e62f9264fd5abe13a2b1c0d3eb9()
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

      private sealed class PROP_a782a475200746fb9be77f7f1121d0b0 : HardwiredMemberDescriptor
      {
        internal PROP_a782a475200746fb9be77f7f1121d0b0()
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

      private sealed class PROP_2d044309ce97467cb708fafe94a3e010 : HardwiredMemberDescriptor
      {
        internal PROP_2d044309ce97467cb708fafe94a3e010()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_2f84724ac3084a8b9fb764bcd139853d : HardwiredUserDataDescriptor
    {
      internal TYPE_2f84724ac3084a8b9fb764bcd139853d()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_c4f411c29190420cbf7d4eb30ff91d0b()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_d7f87fe03bab438d956d68ab4211ad48()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_31e9af3e1a354cd5b0dbe4880c646e3b()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_b9cbfd098f25466bbf578946c259af41()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_097bf1a57fc946f39009eb0e508ab12c()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_a5363456c0214034a6f9f3e023d7bcd4()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_40c90c8b3ebf4d3589f0bfe592dd2b20()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_b10a478c2b8648f6b8837bf0c77a687a()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_fefaacf1228345be9a65ef0ad26acd1f()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_7a77096b7bb7448c94d166819c78a2cf()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_f876d16c59204edd9ccc52aa0e94d147()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_519ecd1eacdf46c08c3eafceb1fcf772()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_35b0b07d50d34d9982949257d8623451()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_77db00224dcc4e63b9085a38e823e728()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_43608e8537f44d7891f7d305779945a8()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_76486b9db1484ff1ba5fdbe9e2c36e5b()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_fde92e7f38b14f5eaf4c04ccd1344822()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_a45ba33e4bc541ac9f41a96d0b5765c4()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_83f215ab22304e4fa56ef82a806c3478()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_e2321be1099e4d8eb91d7d4096460bf1()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_9d7380f8b040462382372ba594d1c5ed()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_4fb01217b19048609de20706a1e1399d()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_436b24f90dfb4601935def70bf3267db()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_14ff42e24cc144e399f6c2b7c891d059()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_a1f6e2772fea4311a33bf25c205786d9()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_6a82507c17f9453d9fdebc15c8ff6c2d()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_412cfe41832948869dcc33ef6213a752()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.MTHD_6361b6f29c8345a5bcc97a9546e14fa6()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.PROP_21990197ec414c60bc1fbc87da12cb55());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.PROP_f5de1561647844d3bd7dfa72d410a8d1());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.PROP_03be47da244145bab34167e6703051c3());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.PROP_ca1e7e2d2aae413fb30a66630868f26c());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.PROP_3932abbf75954400b4c4175ec6698675());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.PROP_ecd3f92c178a4bdfb57f528814ca83de());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.PROP_6f734f32a37a460591a16dca8d66da75());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.PROP_dbf5337593ce4f008271a1f5cd08f67a());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.PROP_d84dc401455044ab9554bad5c104ce1a());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.PROP_b695e81ea1434f7a853bc8e62f77547c());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.PROP_631382136fdd4113aedee26c267492d3());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.PROP_55585e4dd4ee469198ea9f6ddcc61cc6());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.PROP_c59639e00dda43a8a4d57d57ee24ddb3());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.PROP_1bcc98f4940e4fe59693c0ed4f9d048a());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.PROP_17c7df35f2e34e47a0903ad35e5cbcb8());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.PROP_13dd737dda584d5d8fd7716af4d13638());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_2f84724ac3084a8b9fb764bcd139853d.PROP_a26870e104c44e4a9caa001ccddfa285());
      }

      private sealed class MTHD_c4f411c29190420cbf7d4eb30ff91d0b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c4f411c29190420cbf7d4eb30ff91d0b()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_d7f87fe03bab438d956d68ab4211ad48 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d7f87fe03bab438d956d68ab4211ad48()
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

      private sealed class MTHD_31e9af3e1a354cd5b0dbe4880c646e3b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_31e9af3e1a354cd5b0dbe4880c646e3b()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_b9cbfd098f25466bbf578946c259af41 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b9cbfd098f25466bbf578946c259af41()
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

      private sealed class MTHD_097bf1a57fc946f39009eb0e508ab12c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_097bf1a57fc946f39009eb0e508ab12c()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_a5363456c0214034a6f9f3e023d7bcd4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a5363456c0214034a6f9f3e023d7bcd4()
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

      private sealed class MTHD_40c90c8b3ebf4d3589f0bfe592dd2b20 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_40c90c8b3ebf4d3589f0bfe592dd2b20()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_b10a478c2b8648f6b8837bf0c77a687a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b10a478c2b8648f6b8837bf0c77a687a()
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

      private sealed class MTHD_fefaacf1228345be9a65ef0ad26acd1f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fefaacf1228345be9a65ef0ad26acd1f()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_7a77096b7bb7448c94d166819c78a2cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a77096b7bb7448c94d166819c78a2cf()
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

      private sealed class MTHD_f876d16c59204edd9ccc52aa0e94d147 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f876d16c59204edd9ccc52aa0e94d147()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_519ecd1eacdf46c08c3eafceb1fcf772 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_519ecd1eacdf46c08c3eafceb1fcf772()
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

      private sealed class MTHD_35b0b07d50d34d9982949257d8623451 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35b0b07d50d34d9982949257d8623451()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_77db00224dcc4e63b9085a38e823e728 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_77db00224dcc4e63b9085a38e823e728()
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

      private sealed class MTHD_43608e8537f44d7891f7d305779945a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_43608e8537f44d7891f7d305779945a8()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_76486b9db1484ff1ba5fdbe9e2c36e5b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76486b9db1484ff1ba5fdbe9e2c36e5b()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_fde92e7f38b14f5eaf4c04ccd1344822 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fde92e7f38b14f5eaf4c04ccd1344822()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_a45ba33e4bc541ac9f41a96d0b5765c4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a45ba33e4bc541ac9f41a96d0b5765c4()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_83f215ab22304e4fa56ef82a806c3478 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_83f215ab22304e4fa56ef82a806c3478()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_e2321be1099e4d8eb91d7d4096460bf1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e2321be1099e4d8eb91d7d4096460bf1()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_9d7380f8b040462382372ba594d1c5ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d7380f8b040462382372ba594d1c5ed()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_4fb01217b19048609de20706a1e1399d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4fb01217b19048609de20706a1e1399d()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_436b24f90dfb4601935def70bf3267db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_436b24f90dfb4601935def70bf3267db()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_14ff42e24cc144e399f6c2b7c891d059 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_14ff42e24cc144e399f6c2b7c891d059()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_a1f6e2772fea4311a33bf25c205786d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1f6e2772fea4311a33bf25c205786d9()
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

      private sealed class MTHD_6a82507c17f9453d9fdebc15c8ff6c2d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6a82507c17f9453d9fdebc15c8ff6c2d()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_412cfe41832948869dcc33ef6213a752 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_412cfe41832948869dcc33ef6213a752()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_6361b6f29c8345a5bcc97a9546e14fa6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6361b6f29c8345a5bcc97a9546e14fa6()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_21990197ec414c60bc1fbc87da12cb55 : HardwiredMemberDescriptor
      {
        internal PROP_21990197ec414c60bc1fbc87da12cb55()
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

      private sealed class PROP_f5de1561647844d3bd7dfa72d410a8d1 : HardwiredMemberDescriptor
      {
        internal PROP_f5de1561647844d3bd7dfa72d410a8d1()
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

      private sealed class PROP_03be47da244145bab34167e6703051c3 : HardwiredMemberDescriptor
      {
        internal PROP_03be47da244145bab34167e6703051c3()
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

      private sealed class PROP_ca1e7e2d2aae413fb30a66630868f26c : HardwiredMemberDescriptor
      {
        internal PROP_ca1e7e2d2aae413fb30a66630868f26c()
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

      private sealed class PROP_3932abbf75954400b4c4175ec6698675 : HardwiredMemberDescriptor
      {
        internal PROP_3932abbf75954400b4c4175ec6698675()
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

      private sealed class PROP_ecd3f92c178a4bdfb57f528814ca83de : HardwiredMemberDescriptor
      {
        internal PROP_ecd3f92c178a4bdfb57f528814ca83de()
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

      private sealed class PROP_6f734f32a37a460591a16dca8d66da75 : HardwiredMemberDescriptor
      {
        internal PROP_6f734f32a37a460591a16dca8d66da75()
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

      private sealed class PROP_dbf5337593ce4f008271a1f5cd08f67a : HardwiredMemberDescriptor
      {
        internal PROP_dbf5337593ce4f008271a1f5cd08f67a()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_d84dc401455044ab9554bad5c104ce1a : HardwiredMemberDescriptor
      {
        internal PROP_d84dc401455044ab9554bad5c104ce1a()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_b695e81ea1434f7a853bc8e62f77547c : HardwiredMemberDescriptor
      {
        internal PROP_b695e81ea1434f7a853bc8e62f77547c()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_631382136fdd4113aedee26c267492d3 : HardwiredMemberDescriptor
      {
        internal PROP_631382136fdd4113aedee26c267492d3()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_55585e4dd4ee469198ea9f6ddcc61cc6 : HardwiredMemberDescriptor
      {
        internal PROP_55585e4dd4ee469198ea9f6ddcc61cc6()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_c59639e00dda43a8a4d57d57ee24ddb3 : HardwiredMemberDescriptor
      {
        internal PROP_c59639e00dda43a8a4d57d57ee24ddb3()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_1bcc98f4940e4fe59693c0ed4f9d048a : HardwiredMemberDescriptor
      {
        internal PROP_1bcc98f4940e4fe59693c0ed4f9d048a()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_17c7df35f2e34e47a0903ad35e5cbcb8 : HardwiredMemberDescriptor
      {
        internal PROP_17c7df35f2e34e47a0903ad35e5cbcb8()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_13dd737dda584d5d8fd7716af4d13638 : HardwiredMemberDescriptor
      {
        internal PROP_13dd737dda584d5d8fd7716af4d13638()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_a26870e104c44e4a9caa001ccddfa285 : HardwiredMemberDescriptor
      {
        internal PROP_a26870e104c44e4a9caa001ccddfa285()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_8441218b935f4f21b5181d0ec4a182ac : HardwiredUserDataDescriptor
    {
      internal TYPE_8441218b935f4f21b5181d0ec4a182ac()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8441218b935f4f21b5181d0ec4a182ac.MTHD_beba715a02d94dbea80c7f0d731f0d99()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8441218b935f4f21b5181d0ec4a182ac.MTHD_0ed6c789f9a04e398aa7963b48bcee86()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8441218b935f4f21b5181d0ec4a182ac.MTHD_173852090e124d95b7d6b72224199ef2()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8441218b935f4f21b5181d0ec4a182ac.MTHD_5145b82a3ed74241a77c539d7be5dca6()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8441218b935f4f21b5181d0ec4a182ac.MTHD_77b64460b5954c68b4b14ceb82f37bc0()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8441218b935f4f21b5181d0ec4a182ac.MTHD_91e78d35ee4046e7a23190f4a9b02159()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8441218b935f4f21b5181d0ec4a182ac.MTHD_61d53c6b328b4ec599e57a3fc86b21e9()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8441218b935f4f21b5181d0ec4a182ac.MTHD_b99360da3da04a2f99764e73893c2fe8()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8441218b935f4f21b5181d0ec4a182ac.MTHD_149ba1b3323841209188eb246c44c87e()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8441218b935f4f21b5181d0ec4a182ac.MTHD_8fe2d9a15969434590ce427e79c7de99()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8441218b935f4f21b5181d0ec4a182ac.MTHD_5bec97f073c64503b580a6cb29ec05cc()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8441218b935f4f21b5181d0ec4a182ac.MTHD_a1fe96ecf3944349998fd808251bb4ac()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8441218b935f4f21b5181d0ec4a182ac.MTHD_81ef7bcff86a44c9b4603a72aaf2e057()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8441218b935f4f21b5181d0ec4a182ac.MTHD_a348320ff8e848289945b6bd260393cb()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8441218b935f4f21b5181d0ec4a182ac.MTHD_86298728f86043c880e96d23143315fa()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8441218b935f4f21b5181d0ec4a182ac.MTHD_2c9aae7f640d413c8b187cd402610317()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8441218b935f4f21b5181d0ec4a182ac.MTHD_57bc775b39134cadab736f40bf266c2e()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_8441218b935f4f21b5181d0ec4a182ac.PROP_55a2e2e3f85142d8b441464cfb1c9c17());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_8441218b935f4f21b5181d0ec4a182ac.PROP_b7e2d33c340d47c4a4c059bdc95e4b5b());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_8441218b935f4f21b5181d0ec4a182ac.PROP_af9887a0aed74a14a67946a81e326b42());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_8441218b935f4f21b5181d0ec4a182ac.PROP_03f7f40ca4104a518d0ff98bc5cf9139());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_8441218b935f4f21b5181d0ec4a182ac.PROP_75b6feec12ee4d74ae07b9b49e00f13c());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_8441218b935f4f21b5181d0ec4a182ac.PROP_63987b5a21fd4d59882d2b3da8adc9da());
      }

      private sealed class MTHD_beba715a02d94dbea80c7f0d731f0d99 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_beba715a02d94dbea80c7f0d731f0d99()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_0ed6c789f9a04e398aa7963b48bcee86 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ed6c789f9a04e398aa7963b48bcee86()
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

      private sealed class MTHD_173852090e124d95b7d6b72224199ef2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_173852090e124d95b7d6b72224199ef2()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_5145b82a3ed74241a77c539d7be5dca6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5145b82a3ed74241a77c539d7be5dca6()
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

      private sealed class MTHD_77b64460b5954c68b4b14ceb82f37bc0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_77b64460b5954c68b4b14ceb82f37bc0()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_91e78d35ee4046e7a23190f4a9b02159 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_91e78d35ee4046e7a23190f4a9b02159()
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

      private sealed class MTHD_61d53c6b328b4ec599e57a3fc86b21e9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_61d53c6b328b4ec599e57a3fc86b21e9()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_b99360da3da04a2f99764e73893c2fe8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b99360da3da04a2f99764e73893c2fe8()
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

      private sealed class MTHD_149ba1b3323841209188eb246c44c87e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_149ba1b3323841209188eb246c44c87e()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_8fe2d9a15969434590ce427e79c7de99 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8fe2d9a15969434590ce427e79c7de99()
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

      private sealed class MTHD_5bec97f073c64503b580a6cb29ec05cc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5bec97f073c64503b580a6cb29ec05cc()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_a1fe96ecf3944349998fd808251bb4ac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1fe96ecf3944349998fd808251bb4ac()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_81ef7bcff86a44c9b4603a72aaf2e057 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_81ef7bcff86a44c9b4603a72aaf2e057()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_a348320ff8e848289945b6bd260393cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a348320ff8e848289945b6bd260393cb()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_86298728f86043c880e96d23143315fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_86298728f86043c880e96d23143315fa()
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

      private sealed class MTHD_2c9aae7f640d413c8b187cd402610317 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c9aae7f640d413c8b187cd402610317()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_57bc775b39134cadab736f40bf266c2e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57bc775b39134cadab736f40bf266c2e()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_55a2e2e3f85142d8b441464cfb1c9c17 : HardwiredMemberDescriptor
      {
        internal PROP_55a2e2e3f85142d8b441464cfb1c9c17()
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

      private sealed class PROP_b7e2d33c340d47c4a4c059bdc95e4b5b : HardwiredMemberDescriptor
      {
        internal PROP_b7e2d33c340d47c4a4c059bdc95e4b5b()
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

      private sealed class PROP_af9887a0aed74a14a67946a81e326b42 : HardwiredMemberDescriptor
      {
        internal PROP_af9887a0aed74a14a67946a81e326b42()
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

      private sealed class PROP_03f7f40ca4104a518d0ff98bc5cf9139 : HardwiredMemberDescriptor
      {
        internal PROP_03f7f40ca4104a518d0ff98bc5cf9139()
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

      private sealed class PROP_75b6feec12ee4d74ae07b9b49e00f13c : HardwiredMemberDescriptor
      {
        internal PROP_75b6feec12ee4d74ae07b9b49e00f13c()
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

      private sealed class PROP_63987b5a21fd4d59882d2b3da8adc9da : HardwiredMemberDescriptor
      {
        internal PROP_63987b5a21fd4d59882d2b3da8adc9da()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_2da1e58eb6074909b0d062944e6a19f7 : HardwiredUserDataDescriptor
    {
      internal TYPE_2da1e58eb6074909b0d062944e6a19f7()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2da1e58eb6074909b0d062944e6a19f7.MTHD_e98e07639b9647b6b59167f18cfae013(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2da1e58eb6074909b0d062944e6a19f7.MTHD_e5b7f8418b8e4a77b1406497e26150b3()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2da1e58eb6074909b0d062944e6a19f7.MTHD_8f29f4d0112b48d1abad4ea22de78b14(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2da1e58eb6074909b0d062944e6a19f7.MTHD_800eb927ab88429fbce4a5a6d880cdb2()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2da1e58eb6074909b0d062944e6a19f7.MTHD_62f9a026e6544aadb260090c5ee1f128()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2da1e58eb6074909b0d062944e6a19f7.MTHD_205497e1b1b34b01ba9450e3074177a4()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2da1e58eb6074909b0d062944e6a19f7.MTHD_e9e8794eb84e4de28259447b0e7058ff()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2da1e58eb6074909b0d062944e6a19f7.MTHD_463f3b1c92584cec9b6326d48e023f88()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2da1e58eb6074909b0d062944e6a19f7.MTHD_4ec5339917c84a34a284a9ea1edf9f7f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2da1e58eb6074909b0d062944e6a19f7.MTHD_d06d11c55f93436ba0286a5f7336b3c7()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2da1e58eb6074909b0d062944e6a19f7.MTHD_57d21318280a43f38063a79583bf4f6d()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2da1e58eb6074909b0d062944e6a19f7.MTHD_d77a8735da3f4777905151a5b552fcd7(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2da1e58eb6074909b0d062944e6a19f7.MTHD_5e0e14fcd4604c8c8dcdefc6741de514()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2da1e58eb6074909b0d062944e6a19f7.MTHD_105bd5be6f8b452faed7109f599e2147(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2da1e58eb6074909b0d062944e6a19f7.MTHD_ad2905701e4c4b10ac9150315ac5a96f()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2da1e58eb6074909b0d062944e6a19f7.MTHD_e67c3468a2b6481a94eb5e0d42daca2a(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2da1e58eb6074909b0d062944e6a19f7.MTHD_0f6716535a6249029460d09175410f15()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2da1e58eb6074909b0d062944e6a19f7.MTHD_8b49e2583c6a459f8d0e69c5fbba35d5(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2da1e58eb6074909b0d062944e6a19f7.MTHD_6f6c3d3dca5846eda7fa9eb36213c318()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2da1e58eb6074909b0d062944e6a19f7.MTHD_e8d24e1cdea347e79a5e5487db5defad(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2da1e58eb6074909b0d062944e6a19f7.MTHD_16349fd339f04f07acd08284ad64bbf1()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2da1e58eb6074909b0d062944e6a19f7.MTHD_2fa814f131224fd0aa38f95cce6cc451()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2da1e58eb6074909b0d062944e6a19f7.MTHD_f4c7460cf8894e8e98bc8a3c407a39eb()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_2da1e58eb6074909b0d062944e6a19f7.FLDV_ea89bcf755cf45d4834b57474f47fafd());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_2da1e58eb6074909b0d062944e6a19f7.FLDV_ba52100a0fa14f518e6005184fa7dd82());
      }

      private sealed class MTHD_e98e07639b9647b6b59167f18cfae013 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e98e07639b9647b6b59167f18cfae013()
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

      private sealed class MTHD_e5b7f8418b8e4a77b1406497e26150b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e5b7f8418b8e4a77b1406497e26150b3()
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

      private sealed class MTHD_8f29f4d0112b48d1abad4ea22de78b14 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8f29f4d0112b48d1abad4ea22de78b14()
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

      private sealed class MTHD_800eb927ab88429fbce4a5a6d880cdb2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_800eb927ab88429fbce4a5a6d880cdb2()
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

      private sealed class MTHD_62f9a026e6544aadb260090c5ee1f128 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_62f9a026e6544aadb260090c5ee1f128()
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

      private sealed class MTHD_205497e1b1b34b01ba9450e3074177a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_205497e1b1b34b01ba9450e3074177a4()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_e9e8794eb84e4de28259447b0e7058ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e9e8794eb84e4de28259447b0e7058ff()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_463f3b1c92584cec9b6326d48e023f88 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_463f3b1c92584cec9b6326d48e023f88()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_4ec5339917c84a34a284a9ea1edf9f7f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ec5339917c84a34a284a9ea1edf9f7f()
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

      private sealed class MTHD_d06d11c55f93436ba0286a5f7336b3c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d06d11c55f93436ba0286a5f7336b3c7()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_57d21318280a43f38063a79583bf4f6d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57d21318280a43f38063a79583bf4f6d()
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

      private sealed class MTHD_d77a8735da3f4777905151a5b552fcd7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d77a8735da3f4777905151a5b552fcd7()
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

      private sealed class MTHD_5e0e14fcd4604c8c8dcdefc6741de514 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e0e14fcd4604c8c8dcdefc6741de514()
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

      private sealed class MTHD_105bd5be6f8b452faed7109f599e2147 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_105bd5be6f8b452faed7109f599e2147()
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

      private sealed class MTHD_ad2905701e4c4b10ac9150315ac5a96f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ad2905701e4c4b10ac9150315ac5a96f()
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

      private sealed class MTHD_e67c3468a2b6481a94eb5e0d42daca2a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e67c3468a2b6481a94eb5e0d42daca2a()
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

      private sealed class MTHD_0f6716535a6249029460d09175410f15 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f6716535a6249029460d09175410f15()
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

      private sealed class MTHD_8b49e2583c6a459f8d0e69c5fbba35d5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b49e2583c6a459f8d0e69c5fbba35d5()
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

      private sealed class MTHD_6f6c3d3dca5846eda7fa9eb36213c318 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6f6c3d3dca5846eda7fa9eb36213c318()
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

      private sealed class MTHD_e8d24e1cdea347e79a5e5487db5defad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e8d24e1cdea347e79a5e5487db5defad()
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

      private sealed class MTHD_16349fd339f04f07acd08284ad64bbf1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_16349fd339f04f07acd08284ad64bbf1()
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

      private sealed class MTHD_2fa814f131224fd0aa38f95cce6cc451 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2fa814f131224fd0aa38f95cce6cc451()
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

      private sealed class MTHD_f4c7460cf8894e8e98bc8a3c407a39eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4c7460cf8894e8e98bc8a3c407a39eb()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_ea89bcf755cf45d4834b57474f47fafd : HardwiredMemberDescriptor
      {
        internal FLDV_ea89bcf755cf45d4834b57474f47fafd()
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

      private sealed class FLDV_ba52100a0fa14f518e6005184fa7dd82 : HardwiredMemberDescriptor
      {
        internal FLDV_ba52100a0fa14f518e6005184fa7dd82()
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

    private sealed class TYPE_2003afdea1144f37b5d90ea266abc186 : HardwiredUserDataDescriptor
    {
      internal TYPE_2003afdea1144f37b5d90ea266abc186()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2003afdea1144f37b5d90ea266abc186.MTHD_d327bbb2ab434576ac768454c48cd5bf()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2003afdea1144f37b5d90ea266abc186.MTHD_7287f277a1d04f5c81ed36b45e678afc()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2003afdea1144f37b5d90ea266abc186.MTHD_fe9f4ea6ce5f4478adeab7bb4493cbed()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2003afdea1144f37b5d90ea266abc186.MTHD_e63c03ee84864495ada50ad08e4e0c66()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2003afdea1144f37b5d90ea266abc186.MTHD_60fd434f7d5f44eb836cce2a105f26bc()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2003afdea1144f37b5d90ea266abc186.MTHD_96978ccf3561477da661690a36d46d9a()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_2003afdea1144f37b5d90ea266abc186.FLDV_73e77d1157864c65a898439066e2bdc7());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_2003afdea1144f37b5d90ea266abc186.FLDV_099917c377024727aed22cd90c74aa81());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_2003afdea1144f37b5d90ea266abc186.FLDV_7cf908886d244389a035428798e8a089());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_2003afdea1144f37b5d90ea266abc186.FLDV_59e4bfbf4b9f4970a1220eaa8c9d55da());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_2003afdea1144f37b5d90ea266abc186.FLDV_951ffee9ebf342ba8a2667a2bf2fe215());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_2003afdea1144f37b5d90ea266abc186.FLDV_32c4dbbaabb042fea9fd52f1a72def8c());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_2003afdea1144f37b5d90ea266abc186.FLDV_ddf1579024b14eb887ac8fb5a01abb1a());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_2003afdea1144f37b5d90ea266abc186.FLDV_4342912214c44324848bfceee92996e1());
        this.AddMember("prestige", (IMemberDescriptor) new Bridge.TYPE_2003afdea1144f37b5d90ea266abc186.FLDV_8c7da74217d242fb827e9f5c90f33898());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_2003afdea1144f37b5d90ea266abc186.FLDV_cd566eec946446e4a94c4c612be5109c());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_2003afdea1144f37b5d90ea266abc186.FLDV_9f76e8fc31db4f0cada74ba85645a6b6());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_2003afdea1144f37b5d90ea266abc186.FLDV_c7f8d10591a7472ab55585a3cc04c020());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_2003afdea1144f37b5d90ea266abc186.FLDV_995f42cd4e7141bca6f6b2064fd79723());
      }

      private sealed class MTHD_d327bbb2ab434576ac768454c48cd5bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d327bbb2ab434576ac768454c48cd5bf()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_7287f277a1d04f5c81ed36b45e678afc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7287f277a1d04f5c81ed36b45e678afc()
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

      private sealed class MTHD_fe9f4ea6ce5f4478adeab7bb4493cbed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fe9f4ea6ce5f4478adeab7bb4493cbed()
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

      private sealed class MTHD_e63c03ee84864495ada50ad08e4e0c66 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e63c03ee84864495ada50ad08e4e0c66()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_60fd434f7d5f44eb836cce2a105f26bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60fd434f7d5f44eb836cce2a105f26bc()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_96978ccf3561477da661690a36d46d9a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_96978ccf3561477da661690a36d46d9a()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_73e77d1157864c65a898439066e2bdc7 : HardwiredMemberDescriptor
      {
        internal FLDV_73e77d1157864c65a898439066e2bdc7()
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

      private sealed class FLDV_099917c377024727aed22cd90c74aa81 : HardwiredMemberDescriptor
      {
        internal FLDV_099917c377024727aed22cd90c74aa81()
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

      private sealed class FLDV_7cf908886d244389a035428798e8a089 : HardwiredMemberDescriptor
      {
        internal FLDV_7cf908886d244389a035428798e8a089()
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

      private sealed class FLDV_59e4bfbf4b9f4970a1220eaa8c9d55da : HardwiredMemberDescriptor
      {
        internal FLDV_59e4bfbf4b9f4970a1220eaa8c9d55da()
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

      private sealed class FLDV_951ffee9ebf342ba8a2667a2bf2fe215 : HardwiredMemberDescriptor
      {
        internal FLDV_951ffee9ebf342ba8a2667a2bf2fe215()
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

      private sealed class FLDV_32c4dbbaabb042fea9fd52f1a72def8c : HardwiredMemberDescriptor
      {
        internal FLDV_32c4dbbaabb042fea9fd52f1a72def8c()
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

      private sealed class FLDV_ddf1579024b14eb887ac8fb5a01abb1a : HardwiredMemberDescriptor
      {
        internal FLDV_ddf1579024b14eb887ac8fb5a01abb1a()
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

      private sealed class FLDV_4342912214c44324848bfceee92996e1 : HardwiredMemberDescriptor
      {
        internal FLDV_4342912214c44324848bfceee92996e1()
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

      private sealed class FLDV_8c7da74217d242fb827e9f5c90f33898 : HardwiredMemberDescriptor
      {
        internal FLDV_8c7da74217d242fb827e9f5c90f33898()
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

      private sealed class FLDV_cd566eec946446e4a94c4c612be5109c : HardwiredMemberDescriptor
      {
        internal FLDV_cd566eec946446e4a94c4c612be5109c()
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

      private sealed class FLDV_9f76e8fc31db4f0cada74ba85645a6b6 : HardwiredMemberDescriptor
      {
        internal FLDV_9f76e8fc31db4f0cada74ba85645a6b6()
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

      private sealed class FLDV_c7f8d10591a7472ab55585a3cc04c020 : HardwiredMemberDescriptor
      {
        internal FLDV_c7f8d10591a7472ab55585a3cc04c020()
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

      private sealed class FLDV_995f42cd4e7141bca6f6b2064fd79723 : HardwiredMemberDescriptor
      {
        internal FLDV_995f42cd4e7141bca6f6b2064fd79723()
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

    private sealed class TYPE_5e30e2c0401f4c21bb3aa8ee992a1153 : HardwiredUserDataDescriptor
    {
      internal TYPE_5e30e2c0401f4c21bb3aa8ee992a1153()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_0601d7a206844fe4b0c764bb8dfe2233()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_51d67a087526478e977ef78b20253fb4()
        }));
        this.AddMember("get_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_b6b456a6e5f3466399b8dec7f6bd4bdb()
        }));
        this.AddMember("set_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_d1b86a5ec24c44a4bba88ed3523b0c5d()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_0e17be5fc8ba4c27aa0bddf5aded2109()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_80c3c759c37e4115b11573f738fc9437()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_8670e2a1a26948a1980d804678ae17f2()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_ff701b7d443c47bd8aca488b9133ba7b()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_9dd767db9557470e8562d52364151e82()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_c88336f45d694a5bbc5ebd66711f8d62()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_4f44412a5ec8484a9cbc72b274c89d6d()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_5c7ff6599b6348af9e1931e7aa2027b1()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_1f76167b1fbc4042a517224d67b204a3()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_33b50bfe22e049eb8934156e5831e619()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_eba3b94fa67b4914b4d1a5e0e92b1579()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_039bb54981f541b39e53a1b44bc21571()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_0c7a19bfc8e94a6abe21d935a0f101e6()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_9b3e032ea7eb4f6bb1a8e926f212bc83()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_1d2a3ac9a3ec4329b864e34105e3ddfb()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_d6af39723c5246e79ec3427df05b4cd8()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_35b55caa8ef9451e9dd59c6911615a50()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_6d15a896de5945a2a19b44a2cc65ef48()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_edb7f809753046aa93ac39b87081c6ef()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_b3640500553149359163d4d87ac9eeb9()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_b982046308954930bccff8d22ee5bf4b()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_6a588dca1c7f4d7e9cb458bccf1711e6()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_dc8592e998f34380831650b9ea5abe5b()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_b3a6a86cd07e427d90ed4272793beb80()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_adcf7d7943df4c8ab9b80211ee1fc7fe()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_3ce8d5ad9527486e9ccf7371c8e2fac9()
        }));
        this.AddMember("get_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_f92b12e9c851415f9b8dc8e424b83cce()
        }));
        this.AddMember("set_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_36e7ff908d44421bbc1080a00a7fd313()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_530b966708704b17bbda0f23d5483f31()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_951de093e26840f4814a66cac0c4a3d4()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_f6bc9a858eae4d3b8533dfebb2faca9c()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_fb0572081c9c415ba0cff0babf4a0e96()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_aec1b22309214efd8dcf5e0b9da9bb2e()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_0dd96466a8de429ba4776d7659f71a9d()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_508fb851b0854af9b38a65b746e8085a()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_06f66e54d9a046f5b151a2c9bef39158()
        }));
        this.AddMember("get_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_ca12ac181359457a81dda2565b6fff23()
        }));
        this.AddMember("set_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_92719590e4db415a91b4dbe2d498d1f2()
        }));
        this.AddMember("get_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_08de4a84d5864b2681b54f14964b8ef5()
        }));
        this.AddMember("set_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_4e88c9a401f1458ba380cfb3acd12a3d()
        }));
        this.AddMember("get_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_2f7599bd47f44a3781cfc38ed484e0e7()
        }));
        this.AddMember("set_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_bb5776d5b4ae41eeb65133cff151bf80()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_e4416929fd3e4897a0d437472b2ee399()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_5e9e19f7bdfd4c6984c1097a09462191()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_ed1d258cae0a4aeda3ea4e453a0f8a31()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_1aeb81c887584a3dbe9218cd8c4f54ff()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_2db4ac268a684b87b3f3e7023ea2551b()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_a86e2f49522547e3b09768e5c9f1dc65()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_acc5135fa51441f789b28221d8124b2d()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_878649fb6cff430c9a96872b90458a00()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_fe3559ded1d24d6daa309d8f91bb97fd()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_0dc81d64a05f4e968d79940ead5f1e1f()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_c6205d9e920d44829d94104a4da4abde()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_f46aff36e07d42e587ed473399c8c6d4()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_fc3feba159bf4d768ddba9caae731dd3()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.MTHD_907b721ea0af424797b311e3eef83842()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.PROP_08c62cb92c844411aabc463f14ecc450());
        this.AddMember("visible", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.PROP_e0e30353dc0f447daf9c14e098f83cfc());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.PROP_88dfa7f13c1d461fbc2523994646c862());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.PROP_76b9ec36e7974413956304b52ea31cb4());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.PROP_37c0307b624a42f791b80097b608a6c1());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.PROP_3923727bb6894921993c8f01e6157b8a());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.PROP_a9a41e8ca7aa4dc1b5d02725ac7d854c());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.PROP_7083fd0fdb9049ea9997ca68c8edc440());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.PROP_104076c3cdd343fb8d8a658c135f1663());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.PROP_7aab6cae59ad41efacc5104d47b28399());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.PROP_121e3209d8c64a0f849b0980286f7d92());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.PROP_f0bcafb91c334a6b87e9e6190a12d48d());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.PROP_3bcb26ce75aa46799e2fb034b495eb03());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.PROP_1632f1d3025547d1b9d41a19fe341cff());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.PROP_d51d136b4b22429f942ff0562aa4a5ff());
        this.AddMember("onClick2", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.PROP_5400df65905e443d9c197097e798ac08());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.PROP_b8c9662c888e4487b1d60407ca52f463());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.PROP_ed006e10611445e79a411c81c26fb370());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.PROP_094b6f4f6ca44745b6a1c80acb2b351b());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.PROP_828033e5317e422784d499fc68502e4a());
        this.AddMember("textColor2", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.PROP_c88d030ec79f476faca95bd83f5dcd26());
        this.AddMember("highlightColor", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.PROP_9afd88ad06ce434591466c9361dd3caa());
        this.AddMember("highlightColor2", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.PROP_70ae98707f6b44ddb7958b431a247064());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.PROP_62fd2b2e188249958642b8968af88bb4());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.PROP_e09c17a8f89a456cb4b3faeb349c2a0c());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.FLDV_9b7f3acd9fa246e6b1312fc230dbc35b());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.FLDV_54fe8676cae0487195f7dca95e1d38ca());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_5e30e2c0401f4c21bb3aa8ee992a1153.FLDV_dec48108b9864ba19246d34363188f7d());
      }

      private sealed class MTHD_0601d7a206844fe4b0c764bb8dfe2233 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0601d7a206844fe4b0c764bb8dfe2233()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_51d67a087526478e977ef78b20253fb4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_51d67a087526478e977ef78b20253fb4()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_b6b456a6e5f3466399b8dec7f6bd4bdb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b6b456a6e5f3466399b8dec7f6bd4bdb()
        {
          this.Initialize("get_visible", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).visible;
        }
      }

      private sealed class MTHD_d1b86a5ec24c44a4bba88ed3523b0c5d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1b86a5ec24c44a4bba88ed3523b0c5d()
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

      private sealed class MTHD_0e17be5fc8ba4c27aa0bddf5aded2109 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e17be5fc8ba4c27aa0bddf5aded2109()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_80c3c759c37e4115b11573f738fc9437 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_80c3c759c37e4115b11573f738fc9437()
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

      private sealed class MTHD_8670e2a1a26948a1980d804678ae17f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8670e2a1a26948a1980d804678ae17f2()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_ff701b7d443c47bd8aca488b9133ba7b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff701b7d443c47bd8aca488b9133ba7b()
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

      private sealed class MTHD_9dd767db9557470e8562d52364151e82 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9dd767db9557470e8562d52364151e82()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_c88336f45d694a5bbc5ebd66711f8d62 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c88336f45d694a5bbc5ebd66711f8d62()
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

      private sealed class MTHD_4f44412a5ec8484a9cbc72b274c89d6d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4f44412a5ec8484a9cbc72b274c89d6d()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_5c7ff6599b6348af9e1931e7aa2027b1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c7ff6599b6348af9e1931e7aa2027b1()
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

      private sealed class MTHD_1f76167b1fbc4042a517224d67b204a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f76167b1fbc4042a517224d67b204a3()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_33b50bfe22e049eb8934156e5831e619 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_33b50bfe22e049eb8934156e5831e619()
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

      private sealed class MTHD_eba3b94fa67b4914b4d1a5e0e92b1579 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eba3b94fa67b4914b4d1a5e0e92b1579()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_039bb54981f541b39e53a1b44bc21571 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_039bb54981f541b39e53a1b44bc21571()
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

      private sealed class MTHD_0c7a19bfc8e94a6abe21d935a0f101e6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c7a19bfc8e94a6abe21d935a0f101e6()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_9b3e032ea7eb4f6bb1a8e926f212bc83 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b3e032ea7eb4f6bb1a8e926f212bc83()
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

      private sealed class MTHD_1d2a3ac9a3ec4329b864e34105e3ddfb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d2a3ac9a3ec4329b864e34105e3ddfb()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_d6af39723c5246e79ec3427df05b4cd8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6af39723c5246e79ec3427df05b4cd8()
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

      private sealed class MTHD_35b55caa8ef9451e9dd59c6911615a50 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35b55caa8ef9451e9dd59c6911615a50()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_6d15a896de5945a2a19b44a2cc65ef48 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d15a896de5945a2a19b44a2cc65ef48()
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

      private sealed class MTHD_edb7f809753046aa93ac39b87081c6ef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_edb7f809753046aa93ac39b87081c6ef()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_b3640500553149359163d4d87ac9eeb9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b3640500553149359163d4d87ac9eeb9()
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

      private sealed class MTHD_b982046308954930bccff8d22ee5bf4b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b982046308954930bccff8d22ee5bf4b()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_6a588dca1c7f4d7e9cb458bccf1711e6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6a588dca1c7f4d7e9cb458bccf1711e6()
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

      private sealed class MTHD_dc8592e998f34380831650b9ea5abe5b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc8592e998f34380831650b9ea5abe5b()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_b3a6a86cd07e427d90ed4272793beb80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b3a6a86cd07e427d90ed4272793beb80()
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

      private sealed class MTHD_adcf7d7943df4c8ab9b80211ee1fc7fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_adcf7d7943df4c8ab9b80211ee1fc7fe()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_3ce8d5ad9527486e9ccf7371c8e2fac9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3ce8d5ad9527486e9ccf7371c8e2fac9()
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

      private sealed class MTHD_f92b12e9c851415f9b8dc8e424b83cce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f92b12e9c851415f9b8dc8e424b83cce()
        {
          this.Initialize("get_onClick2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick2;
        }
      }

      private sealed class MTHD_36e7ff908d44421bbc1080a00a7fd313 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_36e7ff908d44421bbc1080a00a7fd313()
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

      private sealed class MTHD_530b966708704b17bbda0f23d5483f31 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_530b966708704b17bbda0f23d5483f31()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_951de093e26840f4814a66cac0c4a3d4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_951de093e26840f4814a66cac0c4a3d4()
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

      private sealed class MTHD_f6bc9a858eae4d3b8533dfebb2faca9c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f6bc9a858eae4d3b8533dfebb2faca9c()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color2;
        }
      }

      private sealed class MTHD_fb0572081c9c415ba0cff0babf4a0e96 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb0572081c9c415ba0cff0babf4a0e96()
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

      private sealed class MTHD_aec1b22309214efd8dcf5e0b9da9bb2e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aec1b22309214efd8dcf5e0b9da9bb2e()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_0dd96466a8de429ba4776d7659f71a9d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0dd96466a8de429ba4776d7659f71a9d()
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

      private sealed class MTHD_508fb851b0854af9b38a65b746e8085a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_508fb851b0854af9b38a65b746e8085a()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_06f66e54d9a046f5b151a2c9bef39158 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_06f66e54d9a046f5b151a2c9bef39158()
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

      private sealed class MTHD_ca12ac181359457a81dda2565b6fff23 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ca12ac181359457a81dda2565b6fff23()
        {
          this.Initialize("get_textColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor2;
        }
      }

      private sealed class MTHD_92719590e4db415a91b4dbe2d498d1f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_92719590e4db415a91b4dbe2d498d1f2()
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

      private sealed class MTHD_08de4a84d5864b2681b54f14964b8ef5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_08de4a84d5864b2681b54f14964b8ef5()
        {
          this.Initialize("get_highlightColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor;
        }
      }

      private sealed class MTHD_4e88c9a401f1458ba380cfb3acd12a3d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e88c9a401f1458ba380cfb3acd12a3d()
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

      private sealed class MTHD_2f7599bd47f44a3781cfc38ed484e0e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2f7599bd47f44a3781cfc38ed484e0e7()
        {
          this.Initialize("get_highlightColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor2;
        }
      }

      private sealed class MTHD_bb5776d5b4ae41eeb65133cff151bf80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb5776d5b4ae41eeb65133cff151bf80()
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

      private sealed class MTHD_e4416929fd3e4897a0d437472b2ee399 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e4416929fd3e4897a0d437472b2ee399()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_5e9e19f7bdfd4c6984c1097a09462191 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e9e19f7bdfd4c6984c1097a09462191()
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

      private sealed class MTHD_ed1d258cae0a4aeda3ea4e453a0f8a31 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed1d258cae0a4aeda3ea4e453a0f8a31()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_1aeb81c887584a3dbe9218cd8c4f54ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1aeb81c887584a3dbe9218cd8c4f54ff()
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

      private sealed class MTHD_2db4ac268a684b87b3f3e7023ea2551b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2db4ac268a684b87b3f3e7023ea2551b()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_a86e2f49522547e3b09768e5c9f1dc65 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a86e2f49522547e3b09768e5c9f1dc65()
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

      private sealed class MTHD_acc5135fa51441f789b28221d8124b2d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_acc5135fa51441f789b28221d8124b2d()
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

      private sealed class MTHD_878649fb6cff430c9a96872b90458a00 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_878649fb6cff430c9a96872b90458a00()
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

      private sealed class MTHD_fe3559ded1d24d6daa309d8f91bb97fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fe3559ded1d24d6daa309d8f91bb97fd()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_0dc81d64a05f4e968d79940ead5f1e1f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0dc81d64a05f4e968d79940ead5f1e1f()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c6205d9e920d44829d94104a4da4abde : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c6205d9e920d44829d94104a4da4abde()
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

      private sealed class MTHD_f46aff36e07d42e587ed473399c8c6d4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f46aff36e07d42e587ed473399c8c6d4()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_fc3feba159bf4d768ddba9caae731dd3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fc3feba159bf4d768ddba9caae731dd3()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_907b721ea0af424797b311e3eef83842 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_907b721ea0af424797b311e3eef83842()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_08c62cb92c844411aabc463f14ecc450 : HardwiredMemberDescriptor
      {
        internal PROP_08c62cb92c844411aabc463f14ecc450()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_e0e30353dc0f447daf9c14e098f83cfc : HardwiredMemberDescriptor
      {
        internal PROP_e0e30353dc0f447daf9c14e098f83cfc()
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

      private sealed class PROP_88dfa7f13c1d461fbc2523994646c862 : HardwiredMemberDescriptor
      {
        internal PROP_88dfa7f13c1d461fbc2523994646c862()
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

      private sealed class PROP_76b9ec36e7974413956304b52ea31cb4 : HardwiredMemberDescriptor
      {
        internal PROP_76b9ec36e7974413956304b52ea31cb4()
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

      private sealed class PROP_37c0307b624a42f791b80097b608a6c1 : HardwiredMemberDescriptor
      {
        internal PROP_37c0307b624a42f791b80097b608a6c1()
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

      private sealed class PROP_3923727bb6894921993c8f01e6157b8a : HardwiredMemberDescriptor
      {
        internal PROP_3923727bb6894921993c8f01e6157b8a()
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

      private sealed class PROP_a9a41e8ca7aa4dc1b5d02725ac7d854c : HardwiredMemberDescriptor
      {
        internal PROP_a9a41e8ca7aa4dc1b5d02725ac7d854c()
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

      private sealed class PROP_7083fd0fdb9049ea9997ca68c8edc440 : HardwiredMemberDescriptor
      {
        internal PROP_7083fd0fdb9049ea9997ca68c8edc440()
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

      private sealed class PROP_104076c3cdd343fb8d8a658c135f1663 : HardwiredMemberDescriptor
      {
        internal PROP_104076c3cdd343fb8d8a658c135f1663()
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

      private sealed class PROP_7aab6cae59ad41efacc5104d47b28399 : HardwiredMemberDescriptor
      {
        internal PROP_7aab6cae59ad41efacc5104d47b28399()
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

      private sealed class PROP_121e3209d8c64a0f849b0980286f7d92 : HardwiredMemberDescriptor
      {
        internal PROP_121e3209d8c64a0f849b0980286f7d92()
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

      private sealed class PROP_f0bcafb91c334a6b87e9e6190a12d48d : HardwiredMemberDescriptor
      {
        internal PROP_f0bcafb91c334a6b87e9e6190a12d48d()
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

      private sealed class PROP_3bcb26ce75aa46799e2fb034b495eb03 : HardwiredMemberDescriptor
      {
        internal PROP_3bcb26ce75aa46799e2fb034b495eb03()
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

      private sealed class PROP_1632f1d3025547d1b9d41a19fe341cff : HardwiredMemberDescriptor
      {
        internal PROP_1632f1d3025547d1b9d41a19fe341cff()
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

      private sealed class PROP_d51d136b4b22429f942ff0562aa4a5ff : HardwiredMemberDescriptor
      {
        internal PROP_d51d136b4b22429f942ff0562aa4a5ff()
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

      private sealed class PROP_5400df65905e443d9c197097e798ac08 : HardwiredMemberDescriptor
      {
        internal PROP_5400df65905e443d9c197097e798ac08()
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

      private sealed class PROP_b8c9662c888e4487b1d60407ca52f463 : HardwiredMemberDescriptor
      {
        internal PROP_b8c9662c888e4487b1d60407ca52f463()
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

      private sealed class PROP_ed006e10611445e79a411c81c26fb370 : HardwiredMemberDescriptor
      {
        internal PROP_ed006e10611445e79a411c81c26fb370()
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

      private sealed class PROP_094b6f4f6ca44745b6a1c80acb2b351b : HardwiredMemberDescriptor
      {
        internal PROP_094b6f4f6ca44745b6a1c80acb2b351b()
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

      private sealed class PROP_828033e5317e422784d499fc68502e4a : HardwiredMemberDescriptor
      {
        internal PROP_828033e5317e422784d499fc68502e4a()
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

      private sealed class PROP_c88d030ec79f476faca95bd83f5dcd26 : HardwiredMemberDescriptor
      {
        internal PROP_c88d030ec79f476faca95bd83f5dcd26()
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

      private sealed class PROP_9afd88ad06ce434591466c9361dd3caa : HardwiredMemberDescriptor
      {
        internal PROP_9afd88ad06ce434591466c9361dd3caa()
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

      private sealed class PROP_70ae98707f6b44ddb7958b431a247064 : HardwiredMemberDescriptor
      {
        internal PROP_70ae98707f6b44ddb7958b431a247064()
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

      private sealed class PROP_62fd2b2e188249958642b8968af88bb4 : HardwiredMemberDescriptor
      {
        internal PROP_62fd2b2e188249958642b8968af88bb4()
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

      private sealed class PROP_e09c17a8f89a456cb4b3faeb349c2a0c : HardwiredMemberDescriptor
      {
        internal PROP_e09c17a8f89a456cb4b3faeb349c2a0c()
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

      private sealed class FLDV_9b7f3acd9fa246e6b1312fc230dbc35b : HardwiredMemberDescriptor
      {
        internal FLDV_9b7f3acd9fa246e6b1312fc230dbc35b()
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

      private sealed class FLDV_54fe8676cae0487195f7dca95e1d38ca : HardwiredMemberDescriptor
      {
        internal FLDV_54fe8676cae0487195f7dca95e1d38ca()
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

      private sealed class FLDV_dec48108b9864ba19246d34363188f7d : HardwiredMemberDescriptor
      {
        internal FLDV_dec48108b9864ba19246d34363188f7d()
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

    private sealed class TYPE_c3f1ab5d6f204a68ae19a47081030328 : HardwiredUserDataDescriptor
    {
      internal TYPE_c3f1ab5d6f204a68ae19a47081030328()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3f1ab5d6f204a68ae19a47081030328.MTHD_350ef18c963b4a8fa130310b2764461d()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3f1ab5d6f204a68ae19a47081030328.MTHD_44e84d21d1ff4aa686dac7de8b03b724()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3f1ab5d6f204a68ae19a47081030328.MTHD_36a76d221f0f41a08c14537b2a7f3121()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3f1ab5d6f204a68ae19a47081030328.MTHD_8c1758e3e09b43eb93ba010f6afa7f30()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3f1ab5d6f204a68ae19a47081030328.MTHD_49c4ded86d8543f5bb066fff0c153fcb()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c3f1ab5d6f204a68ae19a47081030328.MTHD_a354ad25cb184fe380a8bd20f3db3476()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_c3f1ab5d6f204a68ae19a47081030328.FLDV_b1561a694e79407e81d4eead07d0af49());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_c3f1ab5d6f204a68ae19a47081030328.FLDV_763e65b42c7141979998b8f9d31c6baa());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_c3f1ab5d6f204a68ae19a47081030328.FLDV_03bb1ba672c240f08e6966c722d3d044());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_c3f1ab5d6f204a68ae19a47081030328.FLDV_2eadec37d010426599af5812fdd00cc6());
      }

      private sealed class MTHD_350ef18c963b4a8fa130310b2764461d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_350ef18c963b4a8fa130310b2764461d()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_44e84d21d1ff4aa686dac7de8b03b724 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_44e84d21d1ff4aa686dac7de8b03b724()
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

      private sealed class MTHD_36a76d221f0f41a08c14537b2a7f3121 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_36a76d221f0f41a08c14537b2a7f3121()
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

      private sealed class MTHD_8c1758e3e09b43eb93ba010f6afa7f30 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c1758e3e09b43eb93ba010f6afa7f30()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_49c4ded86d8543f5bb066fff0c153fcb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49c4ded86d8543f5bb066fff0c153fcb()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_a354ad25cb184fe380a8bd20f3db3476 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a354ad25cb184fe380a8bd20f3db3476()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_b1561a694e79407e81d4eead07d0af49 : HardwiredMemberDescriptor
      {
        internal FLDV_b1561a694e79407e81d4eead07d0af49()
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

      private sealed class FLDV_763e65b42c7141979998b8f9d31c6baa : HardwiredMemberDescriptor
      {
        internal FLDV_763e65b42c7141979998b8f9d31c6baa()
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

      private sealed class FLDV_03bb1ba672c240f08e6966c722d3d044 : HardwiredMemberDescriptor
      {
        internal FLDV_03bb1ba672c240f08e6966c722d3d044()
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

      private sealed class FLDV_2eadec37d010426599af5812fdd00cc6 : HardwiredMemberDescriptor
      {
        internal FLDV_2eadec37d010426599af5812fdd00cc6()
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

    private sealed class TYPE_f78b440f7ab7422cbfe82aa338b2a895 : HardwiredUserDataDescriptor
    {
      internal TYPE_f78b440f7ab7422cbfe82aa338b2a895()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f78b440f7ab7422cbfe82aa338b2a895.MTHD_17bd5a50af4f4a438382eb835897173b()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f78b440f7ab7422cbfe82aa338b2a895.MTHD_fcf773a7ffd1482cb874a45e6a9db344()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f78b440f7ab7422cbfe82aa338b2a895.MTHD_c0f66d80a30c48cd84f35556427154e1()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f78b440f7ab7422cbfe82aa338b2a895.MTHD_b08e015a66554f55a2c4d1467f700cfa()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f78b440f7ab7422cbfe82aa338b2a895.MTHD_f97f0d89596146908f89df2180f6e854()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_f78b440f7ab7422cbfe82aa338b2a895.FLDV_ecf506da3cb84bbfb89b14772354fac2());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_f78b440f7ab7422cbfe82aa338b2a895.FLDV_c4a50a0936cd43c8924460b0dcbd8c46());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_f78b440f7ab7422cbfe82aa338b2a895.FLDV_b70134ddc7b34f6fbeaf6573c0055ae7());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_f78b440f7ab7422cbfe82aa338b2a895.FLDV_cb679b2776c94e08be7281a5a788fa19());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_f78b440f7ab7422cbfe82aa338b2a895.FLDV_54967a6b7ecf4feeac07659ca3f355e0());
      }

      private sealed class MTHD_17bd5a50af4f4a438382eb835897173b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_17bd5a50af4f4a438382eb835897173b()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_fcf773a7ffd1482cb874a45e6a9db344 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fcf773a7ffd1482cb874a45e6a9db344()
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

      private sealed class MTHD_c0f66d80a30c48cd84f35556427154e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c0f66d80a30c48cd84f35556427154e1()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_b08e015a66554f55a2c4d1467f700cfa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b08e015a66554f55a2c4d1467f700cfa()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_f97f0d89596146908f89df2180f6e854 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f97f0d89596146908f89df2180f6e854()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_ecf506da3cb84bbfb89b14772354fac2 : HardwiredMemberDescriptor
      {
        internal FLDV_ecf506da3cb84bbfb89b14772354fac2()
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

      private sealed class FLDV_c4a50a0936cd43c8924460b0dcbd8c46 : HardwiredMemberDescriptor
      {
        internal FLDV_c4a50a0936cd43c8924460b0dcbd8c46()
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

      private sealed class FLDV_b70134ddc7b34f6fbeaf6573c0055ae7 : HardwiredMemberDescriptor
      {
        internal FLDV_b70134ddc7b34f6fbeaf6573c0055ae7()
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

      private sealed class FLDV_cb679b2776c94e08be7281a5a788fa19 : HardwiredMemberDescriptor
      {
        internal FLDV_cb679b2776c94e08be7281a5a788fa19()
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

      private sealed class FLDV_54967a6b7ecf4feeac07659ca3f355e0 : HardwiredMemberDescriptor
      {
        internal FLDV_54967a6b7ecf4feeac07659ca3f355e0()
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

    private sealed class TYPE_2ead9aa734a14ce2b7af9df82cc6a4fa : HardwiredUserDataDescriptor
    {
      internal TYPE_2ead9aa734a14ce2b7af9df82cc6a4fa()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2ead9aa734a14ce2b7af9df82cc6a4fa.MTHD_e1bcd37ae74c4178830d1c86bcb534bc()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2ead9aa734a14ce2b7af9df82cc6a4fa.MTHD_37cee10332b049fa90fcc4f7b5ea8278()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2ead9aa734a14ce2b7af9df82cc6a4fa.MTHD_a30540639a8042049343d4b08846106e()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2ead9aa734a14ce2b7af9df82cc6a4fa.MTHD_fee32fa06819486496bd66b2fc92a65e()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2ead9aa734a14ce2b7af9df82cc6a4fa.MTHD_e65c7a66d4b445c5a2d1c786c890f9dc()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2ead9aa734a14ce2b7af9df82cc6a4fa.MTHD_29dc58b5052044bfa1bdf16672de64eb()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2ead9aa734a14ce2b7af9df82cc6a4fa.MTHD_93a472c152844becba716a9c17bd856c()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2ead9aa734a14ce2b7af9df82cc6a4fa.MTHD_081b230fa5cf4ce5bedfca6f2027cc2d()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2ead9aa734a14ce2b7af9df82cc6a4fa.MTHD_7642a19906644a7b8e1ff419e0cc4fa6()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2ead9aa734a14ce2b7af9df82cc6a4fa.MTHD_25fbab36b45f4f64812a60005a9b267a()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2ead9aa734a14ce2b7af9df82cc6a4fa.MTHD_b3ba12255cf24f6ca97e7cd4ba3244bf()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2ead9aa734a14ce2b7af9df82cc6a4fa.MTHD_c16b82af860a40468d2f1c046a7d48fd()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2ead9aa734a14ce2b7af9df82cc6a4fa.MTHD_047dfeb8142f4666a082bf9b74b1dee0()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_2ead9aa734a14ce2b7af9df82cc6a4fa.FLDV_c5e5ea4205f74eb59651311abca9e998());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_2ead9aa734a14ce2b7af9df82cc6a4fa.FLDV_4e1174e9369246c9bf3adf3933e1034b());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_2ead9aa734a14ce2b7af9df82cc6a4fa.FLDV_1bac1869a62d40209b2d1bf2c88bd891());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_2ead9aa734a14ce2b7af9df82cc6a4fa.FLDV_98a303ced8564fddbbfc32f06f794776());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_2ead9aa734a14ce2b7af9df82cc6a4fa.FLDV_0d7203ce4bd94c4097a572a4fb54dfa2());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_2ead9aa734a14ce2b7af9df82cc6a4fa.FLDV_bf33a769a65f473697bfc4428fbdf1f7());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_2ead9aa734a14ce2b7af9df82cc6a4fa.FLDV_87202a813da441efaddcea40168e0996());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_2ead9aa734a14ce2b7af9df82cc6a4fa.FLDV_c1e7db95b4344aa5b567a8ca33da7ca1());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_2ead9aa734a14ce2b7af9df82cc6a4fa.DVAL_7fbcada9c3864c78afd6f8b2ee25891d());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_2ead9aa734a14ce2b7af9df82cc6a4fa.DVAL_692bd9e885d04341aa0509f7e5b12d8f());
      }

      private sealed class MTHD_e1bcd37ae74c4178830d1c86bcb534bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e1bcd37ae74c4178830d1c86bcb534bc()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_37cee10332b049fa90fcc4f7b5ea8278 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_37cee10332b049fa90fcc4f7b5ea8278()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_a30540639a8042049343d4b08846106e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a30540639a8042049343d4b08846106e()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_fee32fa06819486496bd66b2fc92a65e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fee32fa06819486496bd66b2fc92a65e()
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

      private sealed class MTHD_e65c7a66d4b445c5a2d1c786c890f9dc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e65c7a66d4b445c5a2d1c786c890f9dc()
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

      private sealed class MTHD_29dc58b5052044bfa1bdf16672de64eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_29dc58b5052044bfa1bdf16672de64eb()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_93a472c152844becba716a9c17bd856c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93a472c152844becba716a9c17bd856c()
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

      private sealed class MTHD_081b230fa5cf4ce5bedfca6f2027cc2d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_081b230fa5cf4ce5bedfca6f2027cc2d()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_7642a19906644a7b8e1ff419e0cc4fa6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7642a19906644a7b8e1ff419e0cc4fa6()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_25fbab36b45f4f64812a60005a9b267a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_25fbab36b45f4f64812a60005a9b267a()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b3ba12255cf24f6ca97e7cd4ba3244bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b3ba12255cf24f6ca97e7cd4ba3244bf()
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

      private sealed class MTHD_c16b82af860a40468d2f1c046a7d48fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c16b82af860a40468d2f1c046a7d48fd()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_047dfeb8142f4666a082bf9b74b1dee0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_047dfeb8142f4666a082bf9b74b1dee0()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_c5e5ea4205f74eb59651311abca9e998 : HardwiredMemberDescriptor
      {
        internal FLDV_c5e5ea4205f74eb59651311abca9e998()
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

      private sealed class FLDV_4e1174e9369246c9bf3adf3933e1034b : HardwiredMemberDescriptor
      {
        internal FLDV_4e1174e9369246c9bf3adf3933e1034b()
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

      private sealed class FLDV_1bac1869a62d40209b2d1bf2c88bd891 : HardwiredMemberDescriptor
      {
        internal FLDV_1bac1869a62d40209b2d1bf2c88bd891()
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

      private sealed class FLDV_98a303ced8564fddbbfc32f06f794776 : HardwiredMemberDescriptor
      {
        internal FLDV_98a303ced8564fddbbfc32f06f794776()
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

      private sealed class FLDV_0d7203ce4bd94c4097a572a4fb54dfa2 : HardwiredMemberDescriptor
      {
        internal FLDV_0d7203ce4bd94c4097a572a4fb54dfa2()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_bf33a769a65f473697bfc4428fbdf1f7 : HardwiredMemberDescriptor
      {
        internal FLDV_bf33a769a65f473697bfc4428fbdf1f7()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_87202a813da441efaddcea40168e0996 : HardwiredMemberDescriptor
      {
        internal FLDV_87202a813da441efaddcea40168e0996()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_c1e7db95b4344aa5b567a8ca33da7ca1 : HardwiredMemberDescriptor
      {
        internal FLDV_c1e7db95b4344aa5b567a8ca33da7ca1()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_7fbcada9c3864c78afd6f8b2ee25891d : DynValueMemberDescriptor
      {
        internal DVAL_7fbcada9c3864c78afd6f8b2ee25891d()
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

      private sealed class DVAL_692bd9e885d04341aa0509f7e5b12d8f : DynValueMemberDescriptor
      {
        internal DVAL_692bd9e885d04341aa0509f7e5b12d8f()
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

    private sealed class TYPE_ba97315355dc47dbb8cc13c9982d27e0 : HardwiredUserDataDescriptor
    {
      internal TYPE_ba97315355dc47dbb8cc13c9982d27e0()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ba97315355dc47dbb8cc13c9982d27e0.MTHD_5edc292db656489890ab3af2878a6fc0()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ba97315355dc47dbb8cc13c9982d27e0.MTHD_4f0d6f8d05224d4ab2e648407c891ccd()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ba97315355dc47dbb8cc13c9982d27e0.MTHD_e88dd8e50b2a40a5a949198ae4167a71(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ba97315355dc47dbb8cc13c9982d27e0.MTHD_2330abb63a9643dea1b3d57c9c9104cf()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ba97315355dc47dbb8cc13c9982d27e0.MTHD_c2bfe8fd88284b21a2a25dc175cb9a3f(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ba97315355dc47dbb8cc13c9982d27e0.MTHD_e74c3ea9389a4e229629fdbafcc445b4()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ba97315355dc47dbb8cc13c9982d27e0.MTHD_beea5d26af6749da8e447113ab4ea109()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ba97315355dc47dbb8cc13c9982d27e0.MTHD_93cfed1911d741dfb41f8882ee0aa891()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ba97315355dc47dbb8cc13c9982d27e0.MTHD_da296fc834454648acdb82bec42f3ae4()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ba97315355dc47dbb8cc13c9982d27e0.MTHD_5492df7f1d7541ca891a563df59c65e6()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_ba97315355dc47dbb8cc13c9982d27e0.FLDV_1a048dc8fda34166b8f5ae3175d18f67());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_ba97315355dc47dbb8cc13c9982d27e0.FLDV_c9eaedde078549b38813ef166fa94d19());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_ba97315355dc47dbb8cc13c9982d27e0.FLDV_353bce06a2ea4de9984edf20e2e87e3f());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_ba97315355dc47dbb8cc13c9982d27e0.FLDV_75553e346d074f3e8c65df182aa4fdde());
        this.AddMember("white", (IMemberDescriptor) new Bridge.TYPE_ba97315355dc47dbb8cc13c9982d27e0.FLDV_9b29d67e89ba44bfab684b6a1ddb3237());
      }

      private sealed class MTHD_5edc292db656489890ab3af2878a6fc0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5edc292db656489890ab3af2878a6fc0()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_4f0d6f8d05224d4ab2e648407c891ccd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4f0d6f8d05224d4ab2e648407c891ccd()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_e88dd8e50b2a40a5a949198ae4167a71 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e88dd8e50b2a40a5a949198ae4167a71()
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

      private sealed class MTHD_2330abb63a9643dea1b3d57c9c9104cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2330abb63a9643dea1b3d57c9c9104cf()
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

      private sealed class MTHD_c2bfe8fd88284b21a2a25dc175cb9a3f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c2bfe8fd88284b21a2a25dc175cb9a3f()
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

      private sealed class MTHD_e74c3ea9389a4e229629fdbafcc445b4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e74c3ea9389a4e229629fdbafcc445b4()
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

      private sealed class MTHD_beea5d26af6749da8e447113ab4ea109 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_beea5d26af6749da8e447113ab4ea109()
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

      private sealed class MTHD_93cfed1911d741dfb41f8882ee0aa891 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93cfed1911d741dfb41f8882ee0aa891()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_da296fc834454648acdb82bec42f3ae4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_da296fc834454648acdb82bec42f3ae4()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_5492df7f1d7541ca891a563df59c65e6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5492df7f1d7541ca891a563df59c65e6()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_1a048dc8fda34166b8f5ae3175d18f67 : HardwiredMemberDescriptor
      {
        internal FLDV_1a048dc8fda34166b8f5ae3175d18f67()
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

      private sealed class FLDV_c9eaedde078549b38813ef166fa94d19 : HardwiredMemberDescriptor
      {
        internal FLDV_c9eaedde078549b38813ef166fa94d19()
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

      private sealed class FLDV_353bce06a2ea4de9984edf20e2e87e3f : HardwiredMemberDescriptor
      {
        internal FLDV_353bce06a2ea4de9984edf20e2e87e3f()
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

      private sealed class FLDV_75553e346d074f3e8c65df182aa4fdde : HardwiredMemberDescriptor
      {
        internal FLDV_75553e346d074f3e8c65df182aa4fdde()
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

      private sealed class FLDV_9b29d67e89ba44bfab684b6a1ddb3237 : HardwiredMemberDescriptor
      {
        internal FLDV_9b29d67e89ba44bfab684b6a1ddb3237()
          : base(typeof (LuaColor), "white", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) LuaColor.white;
        }
      }
    }

    private sealed class TYPE_0393fef799aa439ba60d3bb3bb6d3466 : HardwiredUserDataDescriptor
    {
      internal TYPE_0393fef799aa439ba60d3bb3bb6d3466()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0393fef799aa439ba60d3bb3bb6d3466.MTHD_53962774317a422a842e58d36283ae53()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0393fef799aa439ba60d3bb3bb6d3466.MTHD_52628d32e9e8486aabbaff9d331d013a()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0393fef799aa439ba60d3bb3bb6d3466.MTHD_73a80bb13d40439d811fd739260a86b6()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0393fef799aa439ba60d3bb3bb6d3466.MTHD_2de74bf5676344ae8d9f69570c284e2c()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0393fef799aa439ba60d3bb3bb6d3466.MTHD_7e5e736c5e7a4ae09e7fd3be6bb114b5()
        }));
      }

      private sealed class MTHD_53962774317a422a842e58d36283ae53 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_53962774317a422a842e58d36283ae53()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_52628d32e9e8486aabbaff9d331d013a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52628d32e9e8486aabbaff9d331d013a()
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

      private sealed class MTHD_73a80bb13d40439d811fd739260a86b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_73a80bb13d40439d811fd739260a86b6()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_2de74bf5676344ae8d9f69570c284e2c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2de74bf5676344ae8d9f69570c284e2c()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_7e5e736c5e7a4ae09e7fd3be6bb114b5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7e5e736c5e7a4ae09e7fd3be6bb114b5()
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
