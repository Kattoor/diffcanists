
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
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_139b3fe831854efe9495ab197e7f9432());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_758bc7af1b27432f84c5997dd6635e61());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_04e8acaef74f4a208b19e5852447dcc4());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_40bb7a2addca479ebe1a82b81e0be2f2());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_a21104bf24194de6bb25601673aae5b2());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_d994cd3245674f9bb0a4e91929b9abe5());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_5f88b02bf6b2455cb02ab8fde7a70f46());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_4f1399411d1e4310a005037c73ebc6ec());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_53e46213d47840cd9ae9914c352bfb3d());
    }

    private sealed class TYPE_35ab7000d428447fac1d6ae579e2aa57 : HardwiredUserDataDescriptor
    {
      internal TYPE_35ab7000d428447fac1d6ae579e2aa57()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_8e1604df29e64c9e9cabad124d878f5e()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_71c78099fe364531a14f5b2c7ef4ec04()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_093084620c674a00bf4cb1062165a288()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_d71456ea61d14116a691aab3ccb98053()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_084f0c86804f4354b3e729f838e59a8d()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_64f839eec23442929ed88c32804ee0c9()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_9f0bf614b27546eaa1aea479703f5e85()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_b563a64714d14429a4af4937e086ec3b()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_b552b3e810b349bc91bb270595bd2add()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_e55939a6f04843f6b4ba1fc340e6ef5b()
        }));
        this.AddMember("hideInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("hideInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_4f81b935968a44d8a39e6a1cae0d7f97()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_c0494b8f5bf44da98ba23225c37fd53a()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_0eb2187e23844fefb8dcf1ea94426735()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_40f4322b8afe4a539cfda8e4de854114()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_465a5e760cc54c7895ed72a26f183c02()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_414a4c26493d42318054dbf9b59b1fb9()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_d8cbfa80a59042a29ebb7bc863f6822e()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_c01c675e30154f5bbfcdef9c03afb932()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_18a1549cea484473a95e13bfc026ce3e()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_ef49fd42ba1e4af2a54d597e794563b4()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_9f302ef3de48432185ae5e7e26b9dbd6()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_762e9ff913c6466aa5735b3f9dc3a73f()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_f8cd783b50d540259e1c4bdb5cde3e13()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_f5d1e8bb6f224a11b9a63648c6d275d6()
        }));
        this.AddMember("get_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_c40d25c7fc9047e7b050d260d9b7c1b6()
        }));
        this.AddMember("set_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_f98061eb76ed402da21d6652f46fbd65()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_a50d1f49fc6b472ea4fe72a9aef8ff47()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_fb0ab5ef7dcc427e872bff434a3b8b5e()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_a0bf5da5956842fbbb9183e6d9340ae0()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_d537dc30019e403fa85357f59ba51dbe()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_0bfad1e1bdbb4c6eb7d50135f3cbdfdb()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_bc3b32d5219a4564859ac5cba276142f()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_fa4a81778fd2486f83eda7247ca7d018()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_84e2020b0d2d49f1b44ef6b54e35e80f()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_22fb4fad197d403f8f4bd7b68ea65a9b()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_ae83f35de34746a48b88ff68d02a2a86()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_dc329b9c746446a2987b8ae9f3970a2d()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_e24712a0afb04c0a9dfcf3beccc26de8()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_42a5b99c3eb04fc9b59c7ba6e1e76a4a()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_68e71aaba978485bade6d7b2bed023cb()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_e63c24ed1368484aa099d35c0369797d()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_14920d9764544a11893b7839e6140604()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_d29966bd60224ee189b686abde0adc4c()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_acb72d23149949559d47c4c503724889()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_a7138d915a8c432f9cd22f4bdcf8fb9f()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_ae48f053f95749ebac8ee20e7917e8d5()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_379b79ded41e4b3c9cf07f66e6d4e73f()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_a1c7b77e963d434099fbc55104ce2b7a()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_55e029ee0b964f1aa4df6f622922d5ca()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_2c42742025d54cf8a373b9b71e848288()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_17b5f6b70dbc474baa99650e76293aca()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_c5a49e7ff27f40db8a044efed5064392()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_be0ee6269c2d47d1812e874025236b7d()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_d8443c3cc38b41bd8c4aa9216c4e4380()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_a52d5521c8e641499f74944df57dbb4c()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_aaa4a6fec0cf426280a1f1358d7fb19e()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_b1221820c1534e888237ce691553c13b()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_4c45348b79894656a2be75946edde28e()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_4e4b799144354919a9d4c4c3b0564e8f()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_d794558ddc89487d99e9068ab1933fac()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_e33274e635164c30a0a9aa6b82c96bab()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_ad105584ba004623acf7e4d696222bce()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_14c83a49244d49318e364ea0e7089f74()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_7f13d9e7e9de4572a33ddf587539ee24()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_583b95aa2b7346238e559e5b1a95a016()
        }));
        this.AddMember("Dispose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Dispose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_01ea6ff1439a48ef952b8d329c19163b()
        }));
        this.AddMember("drawImage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawImage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_9e2bb8da3e47474899199e1f889cfb71()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_78ec602a57e442f292730eb3111876d3()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_7c79fdf0ace944009b7042de795ee222()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_32544f2e2d64462a891f482e799cf4e0()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_76d81004902b4803ac85cd6b6fe34d38()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_f702aba118df452ebbb9521149f70be2()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_f18e090ba79d488aab665f6aacddb219()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_75af6377889345b4889734621663c77d()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_f0781f5caf45470f82f1ad9c9e3c6a60()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_61f05ec115594cb5a029d7594e677013()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_4599d610a04f457bbc293aa7fb1bc4a6()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_b11bc2aae6b64f3d9ebb4af5036779ef()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_d9a83fcf083c4ed390a1255a6f0bcdef()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_2610b0d20f97466daebde4b6572904b0()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_3068f56cc9e64040b8a3639b4d843ab1()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_5ec85a07878b4c8a9d93d9360b054358()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_ce4731ff6de445ba88ab19bd6585bb90()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_b54961d024764ec7bf0211157fbf78f8()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_696c5276d1184952b0c12aa8214f45c1()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_9e694d9d53924302a4df108e96b66054()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_78f064f857564ba08970183f7759b2a4()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_be2ab27cb7134fa8a3b6aec27270470d()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_ed0ef45efd7f44e8af07f3900f27e546()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_01080efaa9474a0b8a6aefbe53d88560()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_6d8aeb3bfc9744a09658c18672d1516f()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_60b9ec2f4362441580de635444bbc856()
        }));
        this.AddMember("cameraFollow", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("cameraFollow", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_cc6391996c2b4e8e97374af670447732()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_e7363e66894049a3b301e6a01e5b39b2()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_d6140bc3b94a461bae6d43d19f9da180()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_c5ebdba4b0624716aa1423167b86da1f()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_ce6b1ad0e03846f79172239e0cc1e82d()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_92cc9c0bad99461ba8855bcd4cd9dd0d()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_77fe392078134de08f569a0acb008ea8(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_cf9478c042a14db8a5a0e825a9ad77b5()
        }));
        this.AddMember("getKeyBinds", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getKeyBinds", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_a0bbab6d3c484dad9b7f36a14859e8f3()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_4c93e58055314b439c476d67f955a52e()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_8937e619c33941c3acc2edc271a3cf98()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_74aacff7702d432093dcc872c7a43235()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.MTHD_2734971a3c714e0bbc2b92b5992eb846()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_e769656bc8a84d74a1d6c0fc345c263f());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_28e743df8c6242b4bd4905b8b6c8d803());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_b20a8bc6cd3b4b339ee36b1150344e76());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_3e33afb563a24dd9b69eb0a11d0d1675());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_1ec37fdfd14e4fd9be2fab6ef64b32e8());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_f06456912b114f089e01435a49f85e50());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_a3fb6ffce6e142d98c0c3168199cc6b6());
        this.AddMember("allowMinionMovement", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_cca57762ae4246109d75ea927fb953c1());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_66aefdf611134f7294c3b51d9df4863d());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_0489eda95d8048bfbc87a7dc60530647());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_09a21d1e81e344bd88e6493acf6a2dfa());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_b4a3eefdb4504eb9b614504f67b2eced());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_4f756eb5571d441d96d1a902bdbf3cf2());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_8d2be0a5a5024e4c870a96a65ddcfec2());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_98ba3faf414347e3b61cc72fdb813498());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_0896b445d8c2466193ca8997c93fb86e());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_d9755f65acca4f62bdf4d5944ff8ad21());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_2c8a043a043d4ed898b900472c44450a());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_c5639e20f5cc437b838025110f0fe019());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_03fafdd13c934f7e84890ca64d29f4fe());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_bed9f16fe63f42e58dba56947cfb4397());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_c1b70756903f4f6cb8e8fe12e44da16b());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_0721a61ffb654c9facf5f3f7a74ee363());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_fce6957cde2947a3ac84673948cca8e3());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_3c1918cc08e7446cbc27b72dff668d89());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_5f1f07661e4d4993800b561de2d84855());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_42cf8d2494414a4b9f3043713e96e9c8());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_40726764f0bd40c18ee7809eae117193());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_98f6d719cdcd4caca1d579f727d45b44());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_200d42c14e284d1f8608a44e18ef1116());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_115410423e33493f94243753ae82ac56());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_c8baf0cde6704066bfbdd9cec188337f());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_35ab7000d428447fac1d6ae579e2aa57.PROP_871d9e699ec74be48888a8fb11b6d0bd());
      }

      private sealed class MTHD_8e1604df29e64c9e9cabad124d878f5e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e1604df29e64c9e9cabad124d878f5e()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_71c78099fe364531a14f5b2c7ef4ec04 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_71c78099fe364531a14f5b2c7ef4ec04()
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

      private sealed class MTHD_093084620c674a00bf4cb1062165a288 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_093084620c674a00bf4cb1062165a288()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_d71456ea61d14116a691aab3ccb98053 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d71456ea61d14116a691aab3ccb98053()
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

      private sealed class MTHD_084f0c86804f4354b3e729f838e59a8d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_084f0c86804f4354b3e729f838e59a8d()
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

      private sealed class MTHD_64f839eec23442929ed88c32804ee0c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_64f839eec23442929ed88c32804ee0c9()
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

      private sealed class MTHD_9f0bf614b27546eaa1aea479703f5e85 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f0bf614b27546eaa1aea479703f5e85()
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

      private sealed class MTHD_b563a64714d14429a4af4937e086ec3b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b563a64714d14429a4af4937e086ec3b()
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

      private sealed class MTHD_b552b3e810b349bc91bb270595bd2add : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b552b3e810b349bc91bb270595bd2add()
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

      private sealed class MTHD_e55939a6f04843f6b4ba1fc340e6ef5b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e55939a6f04843f6b4ba1fc340e6ef5b()
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

      private sealed class MTHD_4f81b935968a44d8a39e6a1cae0d7f97 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4f81b935968a44d8a39e6a1cae0d7f97()
        {
          this.Initialize("hideInfo", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).hideInfo();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c0494b8f5bf44da98ba23225c37fd53a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c0494b8f5bf44da98ba23225c37fd53a()
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

      private sealed class MTHD_0eb2187e23844fefb8dcf1ea94426735 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0eb2187e23844fefb8dcf1ea94426735()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_40f4322b8afe4a539cfda8e4de854114 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_40f4322b8afe4a539cfda8e4de854114()
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

      private sealed class MTHD_465a5e760cc54c7895ed72a26f183c02 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_465a5e760cc54c7895ed72a26f183c02()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_414a4c26493d42318054dbf9b59b1fb9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_414a4c26493d42318054dbf9b59b1fb9()
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

      private sealed class MTHD_d8cbfa80a59042a29ebb7bc863f6822e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8cbfa80a59042a29ebb7bc863f6822e()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_c01c675e30154f5bbfcdef9c03afb932 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c01c675e30154f5bbfcdef9c03afb932()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_18a1549cea484473a95e13bfc026ce3e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_18a1549cea484473a95e13bfc026ce3e()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_ef49fd42ba1e4af2a54d597e794563b4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef49fd42ba1e4af2a54d597e794563b4()
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

      private sealed class MTHD_9f302ef3de48432185ae5e7e26b9dbd6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f302ef3de48432185ae5e7e26b9dbd6()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_762e9ff913c6466aa5735b3f9dc3a73f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_762e9ff913c6466aa5735b3f9dc3a73f()
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

      private sealed class MTHD_f8cd783b50d540259e1c4bdb5cde3e13 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f8cd783b50d540259e1c4bdb5cde3e13()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_f5d1e8bb6f224a11b9a63648c6d275d6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f5d1e8bb6f224a11b9a63648c6d275d6()
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

      private sealed class MTHD_c40d25c7fc9047e7b050d260d9b7c1b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c40d25c7fc9047e7b050d260d9b7c1b6()
        {
          this.Initialize("get_allowMinionMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMinionMovement;
        }
      }

      private sealed class MTHD_f98061eb76ed402da21d6652f46fbd65 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f98061eb76ed402da21d6652f46fbd65()
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

      private sealed class MTHD_a50d1f49fc6b472ea4fe72a9aef8ff47 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a50d1f49fc6b472ea4fe72a9aef8ff47()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_fb0ab5ef7dcc427e872bff434a3b8b5e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb0ab5ef7dcc427e872bff434a3b8b5e()
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

      private sealed class MTHD_a0bf5da5956842fbbb9183e6d9340ae0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a0bf5da5956842fbbb9183e6d9340ae0()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_d537dc30019e403fa85357f59ba51dbe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d537dc30019e403fa85357f59ba51dbe()
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

      private sealed class MTHD_0bfad1e1bdbb4c6eb7d50135f3cbdfdb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0bfad1e1bdbb4c6eb7d50135f3cbdfdb()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_bc3b32d5219a4564859ac5cba276142f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bc3b32d5219a4564859ac5cba276142f()
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

      private sealed class MTHD_fa4a81778fd2486f83eda7247ca7d018 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa4a81778fd2486f83eda7247ca7d018()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_84e2020b0d2d49f1b44ef6b54e35e80f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84e2020b0d2d49f1b44ef6b54e35e80f()
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

      private sealed class MTHD_22fb4fad197d403f8f4bd7b68ea65a9b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22fb4fad197d403f8f4bd7b68ea65a9b()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_ae83f35de34746a48b88ff68d02a2a86 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae83f35de34746a48b88ff68d02a2a86()
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

      private sealed class MTHD_dc329b9c746446a2987b8ae9f3970a2d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc329b9c746446a2987b8ae9f3970a2d()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_e24712a0afb04c0a9dfcf3beccc26de8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e24712a0afb04c0a9dfcf3beccc26de8()
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

      private sealed class MTHD_42a5b99c3eb04fc9b59c7ba6e1e76a4a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42a5b99c3eb04fc9b59c7ba6e1e76a4a()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_68e71aaba978485bade6d7b2bed023cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_68e71aaba978485bade6d7b2bed023cb()
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

      private sealed class MTHD_e63c24ed1368484aa099d35c0369797d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e63c24ed1368484aa099d35c0369797d()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_14920d9764544a11893b7839e6140604 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_14920d9764544a11893b7839e6140604()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_d29966bd60224ee189b686abde0adc4c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d29966bd60224ee189b686abde0adc4c()
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

      private sealed class MTHD_acb72d23149949559d47c4c503724889 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_acb72d23149949559d47c4c503724889()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_a7138d915a8c432f9cd22f4bdcf8fb9f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a7138d915a8c432f9cd22f4bdcf8fb9f()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_ae48f053f95749ebac8ee20e7917e8d5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae48f053f95749ebac8ee20e7917e8d5()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_379b79ded41e4b3c9cf07f66e6d4e73f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_379b79ded41e4b3c9cf07f66e6d4e73f()
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

      private sealed class MTHD_a1c7b77e963d434099fbc55104ce2b7a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1c7b77e963d434099fbc55104ce2b7a()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_55e029ee0b964f1aa4df6f622922d5ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_55e029ee0b964f1aa4df6f622922d5ca()
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

      private sealed class MTHD_2c42742025d54cf8a373b9b71e848288 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c42742025d54cf8a373b9b71e848288()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_17b5f6b70dbc474baa99650e76293aca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_17b5f6b70dbc474baa99650e76293aca()
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

      private sealed class MTHD_c5a49e7ff27f40db8a044efed5064392 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c5a49e7ff27f40db8a044efed5064392()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_be0ee6269c2d47d1812e874025236b7d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be0ee6269c2d47d1812e874025236b7d()
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

      private sealed class MTHD_d8443c3cc38b41bd8c4aa9216c4e4380 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8443c3cc38b41bd8c4aa9216c4e4380()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_a52d5521c8e641499f74944df57dbb4c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a52d5521c8e641499f74944df57dbb4c()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_aaa4a6fec0cf426280a1f1358d7fb19e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aaa4a6fec0cf426280a1f1358d7fb19e()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_b1221820c1534e888237ce691553c13b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b1221820c1534e888237ce691553c13b()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_4c45348b79894656a2be75946edde28e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c45348b79894656a2be75946edde28e()
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

      private sealed class MTHD_4e4b799144354919a9d4c4c3b0564e8f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e4b799144354919a9d4c4c3b0564e8f()
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

      private sealed class MTHD_d794558ddc89487d99e9068ab1933fac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d794558ddc89487d99e9068ab1933fac()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_e33274e635164c30a0a9aa6b82c96bab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e33274e635164c30a0a9aa6b82c96bab()
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

      private sealed class MTHD_ad105584ba004623acf7e4d696222bce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ad105584ba004623acf7e4d696222bce()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_14c83a49244d49318e364ea0e7089f74 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_14c83a49244d49318e364ea0e7089f74()
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

      private sealed class MTHD_7f13d9e7e9de4572a33ddf587539ee24 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f13d9e7e9de4572a33ddf587539ee24()
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

      private sealed class MTHD_583b95aa2b7346238e559e5b1a95a016 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_583b95aa2b7346238e559e5b1a95a016()
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

      private sealed class MTHD_01ea6ff1439a48ef952b8d329c19163b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_01ea6ff1439a48ef952b8d329c19163b()
        {
          this.Initialize("Dispose", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ContainerGame.Dispose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9e2bb8da3e47474899199e1f889cfb71 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e2bb8da3e47474899199e1f889cfb71()
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

      private sealed class MTHD_78ec602a57e442f292730eb3111876d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_78ec602a57e442f292730eb3111876d3()
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

      private sealed class MTHD_7c79fdf0ace944009b7042de795ee222 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7c79fdf0ace944009b7042de795ee222()
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

      private sealed class MTHD_32544f2e2d64462a891f482e799cf4e0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_32544f2e2d64462a891f482e799cf4e0()
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

      private sealed class MTHD_76d81004902b4803ac85cd6b6fe34d38 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76d81004902b4803ac85cd6b6fe34d38()
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

      private sealed class MTHD_f702aba118df452ebbb9521149f70be2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f702aba118df452ebbb9521149f70be2()
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

      private sealed class MTHD_f18e090ba79d488aab665f6aacddb219 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f18e090ba79d488aab665f6aacddb219()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_75af6377889345b4889734621663c77d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75af6377889345b4889734621663c77d()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_f0781f5caf45470f82f1ad9c9e3c6a60 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f0781f5caf45470f82f1ad9c9e3c6a60()
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

      private sealed class MTHD_61f05ec115594cb5a029d7594e677013 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_61f05ec115594cb5a029d7594e677013()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_4599d610a04f457bbc293aa7fb1bc4a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4599d610a04f457bbc293aa7fb1bc4a6()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b11bc2aae6b64f3d9ebb4af5036779ef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b11bc2aae6b64f3d9ebb4af5036779ef()
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

      private sealed class MTHD_d9a83fcf083c4ed390a1255a6f0bcdef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d9a83fcf083c4ed390a1255a6f0bcdef()
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

      private sealed class MTHD_2610b0d20f97466daebde4b6572904b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2610b0d20f97466daebde4b6572904b0()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_3068f56cc9e64040b8a3639b4d843ab1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3068f56cc9e64040b8a3639b4d843ab1()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_5ec85a07878b4c8a9d93d9360b054358 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ec85a07878b4c8a9d93d9360b054358()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ce4731ff6de445ba88ab19bd6585bb90 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ce4731ff6de445ba88ab19bd6585bb90()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b54961d024764ec7bf0211157fbf78f8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b54961d024764ec7bf0211157fbf78f8()
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

      private sealed class MTHD_696c5276d1184952b0c12aa8214f45c1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_696c5276d1184952b0c12aa8214f45c1()
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

      private sealed class MTHD_9e694d9d53924302a4df108e96b66054 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e694d9d53924302a4df108e96b66054()
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

      private sealed class MTHD_78f064f857564ba08970183f7759b2a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_78f064f857564ba08970183f7759b2a4()
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

      private sealed class MTHD_be2ab27cb7134fa8a3b6aec27270470d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be2ab27cb7134fa8a3b6aec27270470d()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_ed0ef45efd7f44e8af07f3900f27e546 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed0ef45efd7f44e8af07f3900f27e546()
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

      private sealed class MTHD_01080efaa9474a0b8a6aefbe53d88560 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_01080efaa9474a0b8a6aefbe53d88560()
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

      private sealed class MTHD_6d8aeb3bfc9744a09658c18672d1516f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d8aeb3bfc9744a09658c18672d1516f()
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

      private sealed class MTHD_60b9ec2f4362441580de635444bbc856 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60b9ec2f4362441580de635444bbc856()
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

      private sealed class MTHD_cc6391996c2b4e8e97374af670447732 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cc6391996c2b4e8e97374af670447732()
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

      private sealed class MTHD_e7363e66894049a3b301e6a01e5b39b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7363e66894049a3b301e6a01e5b39b2()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_d6140bc3b94a461bae6d43d19f9da180 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6140bc3b94a461bae6d43d19f9da180()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_c5ebdba4b0624716aa1423167b86da1f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c5ebdba4b0624716aa1423167b86da1f()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_ce6b1ad0e03846f79172239e0cc1e82d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ce6b1ad0e03846f79172239e0cc1e82d()
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

      private sealed class MTHD_92cc9c0bad99461ba8855bcd4cd9dd0d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_92cc9c0bad99461ba8855bcd4cd9dd0d()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_77fe392078134de08f569a0acb008ea8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_77fe392078134de08f569a0acb008ea8()
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

      private sealed class MTHD_cf9478c042a14db8a5a0e825a9ad77b5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf9478c042a14db8a5a0e825a9ad77b5()
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

      private sealed class MTHD_a0bbab6d3c484dad9b7f36a14859e8f3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a0bbab6d3c484dad9b7f36a14859e8f3()
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

      private sealed class MTHD_4c93e58055314b439c476d67f955a52e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c93e58055314b439c476d67f955a52e()
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

      private sealed class MTHD_8937e619c33941c3acc2edc271a3cf98 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8937e619c33941c3acc2edc271a3cf98()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_74aacff7702d432093dcc872c7a43235 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74aacff7702d432093dcc872c7a43235()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_2734971a3c714e0bbc2b92b5992eb846 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2734971a3c714e0bbc2b92b5992eb846()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_e769656bc8a84d74a1d6c0fc345c263f : HardwiredMemberDescriptor
      {
        internal PROP_e769656bc8a84d74a1d6c0fc345c263f()
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

      private sealed class PROP_28e743df8c6242b4bd4905b8b6c8d803 : HardwiredMemberDescriptor
      {
        internal PROP_28e743df8c6242b4bd4905b8b6c8d803()
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

      private sealed class PROP_b20a8bc6cd3b4b339ee36b1150344e76 : HardwiredMemberDescriptor
      {
        internal PROP_b20a8bc6cd3b4b339ee36b1150344e76()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_3e33afb563a24dd9b69eb0a11d0d1675 : HardwiredMemberDescriptor
      {
        internal PROP_3e33afb563a24dd9b69eb0a11d0d1675()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_1ec37fdfd14e4fd9be2fab6ef64b32e8 : HardwiredMemberDescriptor
      {
        internal PROP_1ec37fdfd14e4fd9be2fab6ef64b32e8()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_f06456912b114f089e01435a49f85e50 : HardwiredMemberDescriptor
      {
        internal PROP_f06456912b114f089e01435a49f85e50()
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

      private sealed class PROP_a3fb6ffce6e142d98c0c3168199cc6b6 : HardwiredMemberDescriptor
      {
        internal PROP_a3fb6ffce6e142d98c0c3168199cc6b6()
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

      private sealed class PROP_cca57762ae4246109d75ea927fb953c1 : HardwiredMemberDescriptor
      {
        internal PROP_cca57762ae4246109d75ea927fb953c1()
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

      private sealed class PROP_66aefdf611134f7294c3b51d9df4863d : HardwiredMemberDescriptor
      {
        internal PROP_66aefdf611134f7294c3b51d9df4863d()
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

      private sealed class PROP_0489eda95d8048bfbc87a7dc60530647 : HardwiredMemberDescriptor
      {
        internal PROP_0489eda95d8048bfbc87a7dc60530647()
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

      private sealed class PROP_09a21d1e81e344bd88e6493acf6a2dfa : HardwiredMemberDescriptor
      {
        internal PROP_09a21d1e81e344bd88e6493acf6a2dfa()
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

      private sealed class PROP_b4a3eefdb4504eb9b614504f67b2eced : HardwiredMemberDescriptor
      {
        internal PROP_b4a3eefdb4504eb9b614504f67b2eced()
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

      private sealed class PROP_4f756eb5571d441d96d1a902bdbf3cf2 : HardwiredMemberDescriptor
      {
        internal PROP_4f756eb5571d441d96d1a902bdbf3cf2()
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

      private sealed class PROP_8d2be0a5a5024e4c870a96a65ddcfec2 : HardwiredMemberDescriptor
      {
        internal PROP_8d2be0a5a5024e4c870a96a65ddcfec2()
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

      private sealed class PROP_98ba3faf414347e3b61cc72fdb813498 : HardwiredMemberDescriptor
      {
        internal PROP_98ba3faf414347e3b61cc72fdb813498()
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

      private sealed class PROP_0896b445d8c2466193ca8997c93fb86e : HardwiredMemberDescriptor
      {
        internal PROP_0896b445d8c2466193ca8997c93fb86e()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_d9755f65acca4f62bdf4d5944ff8ad21 : HardwiredMemberDescriptor
      {
        internal PROP_d9755f65acca4f62bdf4d5944ff8ad21()
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

      private sealed class PROP_2c8a043a043d4ed898b900472c44450a : HardwiredMemberDescriptor
      {
        internal PROP_2c8a043a043d4ed898b900472c44450a()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_c5639e20f5cc437b838025110f0fe019 : HardwiredMemberDescriptor
      {
        internal PROP_c5639e20f5cc437b838025110f0fe019()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_03fafdd13c934f7e84890ca64d29f4fe : HardwiredMemberDescriptor
      {
        internal PROP_03fafdd13c934f7e84890ca64d29f4fe()
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

      private sealed class PROP_bed9f16fe63f42e58dba56947cfb4397 : HardwiredMemberDescriptor
      {
        internal PROP_bed9f16fe63f42e58dba56947cfb4397()
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

      private sealed class PROP_c1b70756903f4f6cb8e8fe12e44da16b : HardwiredMemberDescriptor
      {
        internal PROP_c1b70756903f4f6cb8e8fe12e44da16b()
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

      private sealed class PROP_0721a61ffb654c9facf5f3f7a74ee363 : HardwiredMemberDescriptor
      {
        internal PROP_0721a61ffb654c9facf5f3f7a74ee363()
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

      private sealed class PROP_fce6957cde2947a3ac84673948cca8e3 : HardwiredMemberDescriptor
      {
        internal PROP_fce6957cde2947a3ac84673948cca8e3()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_3c1918cc08e7446cbc27b72dff668d89 : HardwiredMemberDescriptor
      {
        internal PROP_3c1918cc08e7446cbc27b72dff668d89()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_5f1f07661e4d4993800b561de2d84855 : HardwiredMemberDescriptor
      {
        internal PROP_5f1f07661e4d4993800b561de2d84855()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_42cf8d2494414a4b9f3043713e96e9c8 : HardwiredMemberDescriptor
      {
        internal PROP_42cf8d2494414a4b9f3043713e96e9c8()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_40726764f0bd40c18ee7809eae117193 : HardwiredMemberDescriptor
      {
        internal PROP_40726764f0bd40c18ee7809eae117193()
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

      private sealed class PROP_98f6d719cdcd4caca1d579f727d45b44 : HardwiredMemberDescriptor
      {
        internal PROP_98f6d719cdcd4caca1d579f727d45b44()
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

      private sealed class PROP_200d42c14e284d1f8608a44e18ef1116 : HardwiredMemberDescriptor
      {
        internal PROP_200d42c14e284d1f8608a44e18ef1116()
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

      private sealed class PROP_115410423e33493f94243753ae82ac56 : HardwiredMemberDescriptor
      {
        internal PROP_115410423e33493f94243753ae82ac56()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_c8baf0cde6704066bfbdd9cec188337f : HardwiredMemberDescriptor
      {
        internal PROP_c8baf0cde6704066bfbdd9cec188337f()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_871d9e699ec74be48888a8fb11b6d0bd : HardwiredMemberDescriptor
      {
        internal PROP_871d9e699ec74be48888a8fb11b6d0bd()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_139b3fe831854efe9495ab197e7f9432 : HardwiredUserDataDescriptor
    {
      internal TYPE_139b3fe831854efe9495ab197e7f9432()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_139b3fe831854efe9495ab197e7f9432.MTHD_cab89f1729ba4f628d25110ccdbf892c()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_139b3fe831854efe9495ab197e7f9432.MTHD_51e77b0088074519a4908e25398f325a()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_139b3fe831854efe9495ab197e7f9432.MTHD_bc5f48c5445d4537a2c66c4790689092()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_139b3fe831854efe9495ab197e7f9432.MTHD_62bb049951d04658b9ce7bde7c0d5fb1()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_139b3fe831854efe9495ab197e7f9432.MTHD_c07ea04c28334779aeaa7d69b521d6cb()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_139b3fe831854efe9495ab197e7f9432.MTHD_de4245512dd848aaa0a305e2307cb433()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_139b3fe831854efe9495ab197e7f9432.MTHD_2da7a6137b8a41c5b039d9524e715d01()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_139b3fe831854efe9495ab197e7f9432.MTHD_76c15c2aee7742dcbe58b71344929375()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_139b3fe831854efe9495ab197e7f9432.MTHD_087d8d20f06745808c639d903e6aabea()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_139b3fe831854efe9495ab197e7f9432.MTHD_ff0786dd312745499160be4a0e059410()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_139b3fe831854efe9495ab197e7f9432.MTHD_1d13e7c846cd4695952dd835a6fdc931()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_139b3fe831854efe9495ab197e7f9432.MTHD_ae4986010ea44d58bbc08a787cb5fbce()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_139b3fe831854efe9495ab197e7f9432.PROP_dc0596e48781451dbc7262543ca0794d());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_139b3fe831854efe9495ab197e7f9432.PROP_e0b5f43ea3d1426b943f4b6012f9d7b9());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_139b3fe831854efe9495ab197e7f9432.PROP_b66043a96e5e4034947e5a7a63ab0b71());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_139b3fe831854efe9495ab197e7f9432.PROP_8ba33b0d96814f449588b1de430aeb9f());
      }

      private sealed class MTHD_cab89f1729ba4f628d25110ccdbf892c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cab89f1729ba4f628d25110ccdbf892c()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_51e77b0088074519a4908e25398f325a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_51e77b0088074519a4908e25398f325a()
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

      private sealed class MTHD_bc5f48c5445d4537a2c66c4790689092 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bc5f48c5445d4537a2c66c4790689092()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_62bb049951d04658b9ce7bde7c0d5fb1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_62bb049951d04658b9ce7bde7c0d5fb1()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_c07ea04c28334779aeaa7d69b521d6cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c07ea04c28334779aeaa7d69b521d6cb()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_de4245512dd848aaa0a305e2307cb433 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de4245512dd848aaa0a305e2307cb433()
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

      private sealed class MTHD_2da7a6137b8a41c5b039d9524e715d01 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2da7a6137b8a41c5b039d9524e715d01()
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

      private sealed class MTHD_76c15c2aee7742dcbe58b71344929375 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76c15c2aee7742dcbe58b71344929375()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_087d8d20f06745808c639d903e6aabea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_087d8d20f06745808c639d903e6aabea()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_ff0786dd312745499160be4a0e059410 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff0786dd312745499160be4a0e059410()
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

      private sealed class MTHD_1d13e7c846cd4695952dd835a6fdc931 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d13e7c846cd4695952dd835a6fdc931()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_ae4986010ea44d58bbc08a787cb5fbce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae4986010ea44d58bbc08a787cb5fbce()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_dc0596e48781451dbc7262543ca0794d : HardwiredMemberDescriptor
      {
        internal PROP_dc0596e48781451dbc7262543ca0794d()
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

      private sealed class PROP_e0b5f43ea3d1426b943f4b6012f9d7b9 : HardwiredMemberDescriptor
      {
        internal PROP_e0b5f43ea3d1426b943f4b6012f9d7b9()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_b66043a96e5e4034947e5a7a63ab0b71 : HardwiredMemberDescriptor
      {
        internal PROP_b66043a96e5e4034947e5a7a63ab0b71()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_8ba33b0d96814f449588b1de430aeb9f : HardwiredMemberDescriptor
      {
        internal PROP_8ba33b0d96814f449588b1de430aeb9f()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_10fb1cbcc75f42198ae0fa239226c678 : HardwiredUserDataDescriptor
    {
      internal TYPE_10fb1cbcc75f42198ae0fa239226c678()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_d0f73510b4d54a42b59677074ed96bfa()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_776348903e494839b734035a5141ec23()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_25ad0a0288544c91a545201692c4077e()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_8e457240b55146639d66b540a288b785()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_6f15fbae9f7749f3b89c8f8c4bcae1ec()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_8f9bd731f81b4a1caf95b878513ce54f()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_7dedc0b1e97f4e1f8721507794a77312()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_ff14405c44fb4326bd80ea63e8b907ba()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_a8f4d165844c4efda65df70d02b0d9de()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_5d41c91ee9a746dda44a21320a4b3195()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_28063f36100f444da4399a44c062eba9()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_a711e526b5814ecc8defd5a8c4b98e2b()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_c40567178f6147b3becdc9cccf3704ab()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_e6283dac79644e0faaf91c4b49552bee()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_67827ede53234b6e95ebd6188a526836()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_0d5f0457b7df44c4aa7987b15e938496()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_0f8865420bf4476a9cc10d9c91f76f58()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_f7e794208a614f5face5f3d8f9478ce4()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_8b67d7bebd4e4921aa346f4661ae8111()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_a679215415034219b432f5b52c7a0d33()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_aefb96da14ae4e0785dc43214ad95533()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_9613d32ef97144b6b986207f1a2f4531()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_81bddf8481724bb6859d2157bd8514fa()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_d0e46b5a1ccc4c5ba398e2ea5aa4bdd2()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_819c0419ea694c4785d83f9bde5dfa28()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_11c9861aef7b4306a437e5dbd297d840()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_6d24a3e9b8074463810a807bc83fea22()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_8c3902c0dc304a1bbd4569215ead7d2c()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_8afea1b28d0e4b00bf9dce444cc36b7e()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_3af2a6e459744a29a066d88bdfe2e9b6()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_18c7c1c0cf944746bb6f575cb5af1e22()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_7eaff0c72de840939e12073496d34f23()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_68a2c1f710cd489e8056313f11825734()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_ed3ad330592f411cb897adc2d40cc60d()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_4690f29b939f445591818ca8ca29a33b()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_c9d21c57af92401b9b1737f138ecf788()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_d38c364f8081404fae295eaa13a0f843()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_8965aaa334ab458d9b7ff30408584e49()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_40250782033c4fc3a14aa97bb0f3bce0()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_40fb27e4d3d34a9bb8bb79e8b8260dad()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_1dccb972d94b42adb9a4efaf60bb22fc()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_61101324185e4c7983edb6e2e5b0731a()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_05300ccedb4a4ae9936afce26ed9f801()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_3b0ea2ace3c641099774b7fa88711e83()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_3a9fc27b4f514e609dd74c6f11fb6a73()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_0d571c12aeae47769bcc80e8af4a656d()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_b4bc490b375e45e7b35c9bb7d71f2f91()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_56950945f8a94a648998394e9de2552f()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_f06498e086b24e70989dbe8689e9df76()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_30ac24ff4780405eab720d4ca8230733()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_72e8b20167dc459ca8020ee9be3d016e()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_47cd53fabb71451c81bfa32ed5b4cc7d()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_0379cafc1c28408b9b33c8bd3b186d0d()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_820ee142c6914cea894807fdd7f0bb8d()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_fc3368de8a8c4aae8471f0a104f39b6c()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_4e6aaad0c70547e4a8e7a2a1cd6a4ee9()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_199bb84648aa4cf0bfdc079ab3616812()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_5bffcdff4759461e808a05311ffcb550()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_c06d403629294c22a88fc7fb35154604()
        }));
        this.AddMember("getDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_2292968c6e4c4497a3a18c9c4cc8d3b8()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_4087c82db4c74c498a38530fcfacdbf5()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_a92e854ebd9147acba35fce40dc2c72c()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_2ae257a508df46d09d5fdc18b25d107f()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_e1c2111c2022479a8fa5a5cc9c578c4c()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_dba8c49b98894b0cb582fea828e60c44(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_094eb6c5286d40d6b99fa6cb84f789ee()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_db9c215f18284a61b5e376f89cd996ad(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_c02e0fcf910442e99a7e1531bc78b613()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_cc78c132f3d84f8ea82061172bc0c0e5()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_ed5bc519750f493180b33d1b88768d0f()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_56f628660f574409986dfdce4065fce9(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_95d2cc19fe9840c996b53a269bf81601()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_10687920a2d5443f94bd7ea5fe1ec076()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_2d05a872cd0b427d9adc3e4e8cdd4f2d()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_22d289273e01418d922e31ebc6893dfe()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_02307f9a47424b2e944669c8bb808d76()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_22d9c18db45a45d698911ecf821e9210()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_7816148a8bd54456bddd458316f9bd90()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_7b098ff98dfb49049797f91f8863d0f1()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_98051fd93544478788b524edfee38193()
        }));
        this.AddMember("angleToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("angleToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_f64704972c4c4091960f2e824b3f0f9c()
        }));
        this.AddMember("powerToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("powerToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_9c52c7953c154abc80ca3999d67469fe()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_3534e856b3a3439b95417a708508c56a(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_be60423319544fc3820f9a541c9abd14()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_c128a595437c46989cc6d84f0688352c(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_f77570028f824b1dbc7fe4ad06a767bd()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_6306748afe2b40f1b6d5d12bec27be45()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_8784e45404d347769175a03201e2bafa()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_91ffb0bf74bf418b9c7739932baf16e6()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_9172b3867e504ecc8b08934613d092ff()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_ed000a049a8c408798634466469c7d18()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.MTHD_d505b4fe202844c3a0f20fab2f62cc29()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_8fe6f5d405a14bfd80fc10e09171a336());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_f1dbe598a1f9482385b82b3fa71138bc());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_32b16334e7294db890d064d697662dc7());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_ef07473f4b924fecbd092758c2ffc658());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_b76e2ad909c6484a90e40608080cb814());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_9462ed0aae654338b6a1bbbde2627f3d());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_bc2aa7c44c814bfbab7f46cc90dd1c13());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_d007c4ceec3f4deeb9393f7ebd3320b5());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_3b85c300becf4187a1672f65257505c0());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_7ecacbd74ea6446b9303b4a1b7a92e9c());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_eee9d97235114638a6cac822f9339f76());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_b515b8a1b21a41ad8bc5ca27a738559b());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_bb263eea9c4d408ebaa346ff6dea4241());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_98356fdc77d247f9a33d9a1394eb75fd());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_7a70e92b6d984dedaf1529a61ad18a2b());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_3090c8a8ba484f0fbe82e5f785759982());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_988fe83a984b499798ab7ba58870be59());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_1c121847b1a74190864e84077f5c7ea5());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_20dd36118c6448909d5fdb435a0c0425());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_0ebaa0a112964c5eb366b1804d8022e3());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_6e05f673b5ed4845b91c5e43fc50707d());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_2521a96141124b578d082a706a44d5d4());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_d5da6ff53d2a42a689f46f9ec581c829());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_85e8c68a8bcb4b3eac1b0fbc57ee5a98());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_8e89e5c9f7eb4d94b7852f5bf0c53b88());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_27d9cf9be92f469ebe5acc0bbedeafd4());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_72470098703b494f9692496eac1dc642());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_bb78c809c1c54acb9f08a7a843d6f427());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_47696e9119b34a4096231417fdc6408f());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_4430f7f70036474a82e7a0660a62d8a9());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_1ddf5b89db9540a78f3eabb3797c92e1());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_919d2a930a2d4a0aae37cd743b78ee12());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_10fb1cbcc75f42198ae0fa239226c678.PROP_b9de03d8993b4b00a7ccdd4e31bebbe3());
      }

      private sealed class MTHD_d0f73510b4d54a42b59677074ed96bfa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0f73510b4d54a42b59677074ed96bfa()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_776348903e494839b734035a5141ec23 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_776348903e494839b734035a5141ec23()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_25ad0a0288544c91a545201692c4077e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_25ad0a0288544c91a545201692c4077e()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_8e457240b55146639d66b540a288b785 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e457240b55146639d66b540a288b785()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_6f15fbae9f7749f3b89c8f8c4bcae1ec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6f15fbae9f7749f3b89c8f8c4bcae1ec()
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

      private sealed class MTHD_8f9bd731f81b4a1caf95b878513ce54f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8f9bd731f81b4a1caf95b878513ce54f()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_7dedc0b1e97f4e1f8721507794a77312 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7dedc0b1e97f4e1f8721507794a77312()
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

      private sealed class MTHD_ff14405c44fb4326bd80ea63e8b907ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff14405c44fb4326bd80ea63e8b907ba()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_a8f4d165844c4efda65df70d02b0d9de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a8f4d165844c4efda65df70d02b0d9de()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_5d41c91ee9a746dda44a21320a4b3195 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d41c91ee9a746dda44a21320a4b3195()
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

      private sealed class MTHD_28063f36100f444da4399a44c062eba9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_28063f36100f444da4399a44c062eba9()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_a711e526b5814ecc8defd5a8c4b98e2b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a711e526b5814ecc8defd5a8c4b98e2b()
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

      private sealed class MTHD_c40567178f6147b3becdc9cccf3704ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c40567178f6147b3becdc9cccf3704ab()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_e6283dac79644e0faaf91c4b49552bee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e6283dac79644e0faaf91c4b49552bee()
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

      private sealed class MTHD_67827ede53234b6e95ebd6188a526836 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67827ede53234b6e95ebd6188a526836()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_0d5f0457b7df44c4aa7987b15e938496 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d5f0457b7df44c4aa7987b15e938496()
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

      private sealed class MTHD_0f8865420bf4476a9cc10d9c91f76f58 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f8865420bf4476a9cc10d9c91f76f58()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_f7e794208a614f5face5f3d8f9478ce4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7e794208a614f5face5f3d8f9478ce4()
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

      private sealed class MTHD_8b67d7bebd4e4921aa346f4661ae8111 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b67d7bebd4e4921aa346f4661ae8111()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_a679215415034219b432f5b52c7a0d33 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a679215415034219b432f5b52c7a0d33()
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

      private sealed class MTHD_aefb96da14ae4e0785dc43214ad95533 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aefb96da14ae4e0785dc43214ad95533()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_9613d32ef97144b6b986207f1a2f4531 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9613d32ef97144b6b986207f1a2f4531()
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

      private sealed class MTHD_81bddf8481724bb6859d2157bd8514fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_81bddf8481724bb6859d2157bd8514fa()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_d0e46b5a1ccc4c5ba398e2ea5aa4bdd2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0e46b5a1ccc4c5ba398e2ea5aa4bdd2()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_819c0419ea694c4785d83f9bde5dfa28 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_819c0419ea694c4785d83f9bde5dfa28()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_11c9861aef7b4306a437e5dbd297d840 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_11c9861aef7b4306a437e5dbd297d840()
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

      private sealed class MTHD_6d24a3e9b8074463810a807bc83fea22 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d24a3e9b8074463810a807bc83fea22()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_8c3902c0dc304a1bbd4569215ead7d2c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c3902c0dc304a1bbd4569215ead7d2c()
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

      private sealed class MTHD_8afea1b28d0e4b00bf9dce444cc36b7e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8afea1b28d0e4b00bf9dce444cc36b7e()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_3af2a6e459744a29a066d88bdfe2e9b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3af2a6e459744a29a066d88bdfe2e9b6()
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

      private sealed class MTHD_18c7c1c0cf944746bb6f575cb5af1e22 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_18c7c1c0cf944746bb6f575cb5af1e22()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_7eaff0c72de840939e12073496d34f23 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7eaff0c72de840939e12073496d34f23()
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

      private sealed class MTHD_68a2c1f710cd489e8056313f11825734 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_68a2c1f710cd489e8056313f11825734()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_ed3ad330592f411cb897adc2d40cc60d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed3ad330592f411cb897adc2d40cc60d()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_4690f29b939f445591818ca8ca29a33b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4690f29b939f445591818ca8ca29a33b()
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

      private sealed class MTHD_c9d21c57af92401b9b1737f138ecf788 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c9d21c57af92401b9b1737f138ecf788()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_d38c364f8081404fae295eaa13a0f843 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d38c364f8081404fae295eaa13a0f843()
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

      private sealed class MTHD_8965aaa334ab458d9b7ff30408584e49 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8965aaa334ab458d9b7ff30408584e49()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_40250782033c4fc3a14aa97bb0f3bce0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_40250782033c4fc3a14aa97bb0f3bce0()
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

      private sealed class MTHD_40fb27e4d3d34a9bb8bb79e8b8260dad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_40fb27e4d3d34a9bb8bb79e8b8260dad()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_1dccb972d94b42adb9a4efaf60bb22fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1dccb972d94b42adb9a4efaf60bb22fc()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_61101324185e4c7983edb6e2e5b0731a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_61101324185e4c7983edb6e2e5b0731a()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_05300ccedb4a4ae9936afce26ed9f801 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_05300ccedb4a4ae9936afce26ed9f801()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_3b0ea2ace3c641099774b7fa88711e83 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3b0ea2ace3c641099774b7fa88711e83()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_3a9fc27b4f514e609dd74c6f11fb6a73 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3a9fc27b4f514e609dd74c6f11fb6a73()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_0d571c12aeae47769bcc80e8af4a656d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d571c12aeae47769bcc80e8af4a656d()
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

      private sealed class MTHD_b4bc490b375e45e7b35c9bb7d71f2f91 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b4bc490b375e45e7b35c9bb7d71f2f91()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_56950945f8a94a648998394e9de2552f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_56950945f8a94a648998394e9de2552f()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_f06498e086b24e70989dbe8689e9df76 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f06498e086b24e70989dbe8689e9df76()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_30ac24ff4780405eab720d4ca8230733 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_30ac24ff4780405eab720d4ca8230733()
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

      private sealed class MTHD_72e8b20167dc459ca8020ee9be3d016e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_72e8b20167dc459ca8020ee9be3d016e()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_47cd53fabb71451c81bfa32ed5b4cc7d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_47cd53fabb71451c81bfa32ed5b4cc7d()
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

      private sealed class MTHD_0379cafc1c28408b9b33c8bd3b186d0d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0379cafc1c28408b9b33c8bd3b186d0d()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_820ee142c6914cea894807fdd7f0bb8d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_820ee142c6914cea894807fdd7f0bb8d()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_fc3368de8a8c4aae8471f0a104f39b6c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fc3368de8a8c4aae8471f0a104f39b6c()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_4e6aaad0c70547e4a8e7a2a1cd6a4ee9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e6aaad0c70547e4a8e7a2a1cd6a4ee9()
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

      private sealed class MTHD_199bb84648aa4cf0bfdc079ab3616812 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_199bb84648aa4cf0bfdc079ab3616812()
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

      private sealed class MTHD_5bffcdff4759461e808a05311ffcb550 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5bffcdff4759461e808a05311ffcb550()
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

      private sealed class MTHD_c06d403629294c22a88fc7fb35154604 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c06d403629294c22a88fc7fb35154604()
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

      private sealed class MTHD_2292968c6e4c4497a3a18c9c4cc8d3b8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2292968c6e4c4497a3a18c9c4cc8d3b8()
        {
          this.Initialize("getDirection", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getDirection();
        }
      }

      private sealed class MTHD_4087c82db4c74c498a38530fcfacdbf5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4087c82db4c74c498a38530fcfacdbf5()
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

      private sealed class MTHD_a92e854ebd9147acba35fce40dc2c72c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a92e854ebd9147acba35fce40dc2c72c()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_2ae257a508df46d09d5fdc18b25d107f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2ae257a508df46d09d5fdc18b25d107f()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_e1c2111c2022479a8fa5a5cc9c578c4c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e1c2111c2022479a8fa5a5cc9c578c4c()
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

      private sealed class MTHD_dba8c49b98894b0cb582fea828e60c44 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dba8c49b98894b0cb582fea828e60c44()
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

      private sealed class MTHD_094eb6c5286d40d6b99fa6cb84f789ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_094eb6c5286d40d6b99fa6cb84f789ee()
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

      private sealed class MTHD_db9c215f18284a61b5e376f89cd996ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db9c215f18284a61b5e376f89cd996ad()
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

      private sealed class MTHD_c02e0fcf910442e99a7e1531bc78b613 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c02e0fcf910442e99a7e1531bc78b613()
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

      private sealed class MTHD_cc78c132f3d84f8ea82061172bc0c0e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cc78c132f3d84f8ea82061172bc0c0e5()
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

      private sealed class MTHD_ed5bc519750f493180b33d1b88768d0f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed5bc519750f493180b33d1b88768d0f()
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

      private sealed class MTHD_56f628660f574409986dfdce4065fce9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_56f628660f574409986dfdce4065fce9()
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

      private sealed class MTHD_95d2cc19fe9840c996b53a269bf81601 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95d2cc19fe9840c996b53a269bf81601()
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

      private sealed class MTHD_10687920a2d5443f94bd7ea5fe1ec076 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_10687920a2d5443f94bd7ea5fe1ec076()
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

      private sealed class MTHD_2d05a872cd0b427d9adc3e4e8cdd4f2d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d05a872cd0b427d9adc3e4e8cdd4f2d()
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

      private sealed class MTHD_22d289273e01418d922e31ebc6893dfe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22d289273e01418d922e31ebc6893dfe()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_02307f9a47424b2e944669c8bb808d76 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_02307f9a47424b2e944669c8bb808d76()
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

      private sealed class MTHD_22d9c18db45a45d698911ecf821e9210 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22d9c18db45a45d698911ecf821e9210()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_7816148a8bd54456bddd458316f9bd90 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7816148a8bd54456bddd458316f9bd90()
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

      private sealed class MTHD_7b098ff98dfb49049797f91f8863d0f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b098ff98dfb49049797f91f8863d0f1()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_98051fd93544478788b524edfee38193 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_98051fd93544478788b524edfee38193()
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

      private sealed class MTHD_f64704972c4c4091960f2e824b3f0f9c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f64704972c4c4091960f2e824b3f0f9c()
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

      private sealed class MTHD_9c52c7953c154abc80ca3999d67469fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c52c7953c154abc80ca3999d67469fe()
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

      private sealed class MTHD_3534e856b3a3439b95417a708508c56a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3534e856b3a3439b95417a708508c56a()
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

      private sealed class MTHD_be60423319544fc3820f9a541c9abd14 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be60423319544fc3820f9a541c9abd14()
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

      private sealed class MTHD_c128a595437c46989cc6d84f0688352c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c128a595437c46989cc6d84f0688352c()
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

      private sealed class MTHD_f77570028f824b1dbc7fe4ad06a767bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f77570028f824b1dbc7fe4ad06a767bd()
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

      private sealed class MTHD_6306748afe2b40f1b6d5d12bec27be45 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6306748afe2b40f1b6d5d12bec27be45()
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

      private sealed class MTHD_8784e45404d347769175a03201e2bafa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8784e45404d347769175a03201e2bafa()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_91ffb0bf74bf418b9c7739932baf16e6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_91ffb0bf74bf418b9c7739932baf16e6()
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

      private sealed class MTHD_9172b3867e504ecc8b08934613d092ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9172b3867e504ecc8b08934613d092ff()
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

      private sealed class MTHD_ed000a049a8c408798634466469c7d18 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed000a049a8c408798634466469c7d18()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_d505b4fe202844c3a0f20fab2f62cc29 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d505b4fe202844c3a0f20fab2f62cc29()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_8fe6f5d405a14bfd80fc10e09171a336 : HardwiredMemberDescriptor
      {
        internal PROP_8fe6f5d405a14bfd80fc10e09171a336()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_f1dbe598a1f9482385b82b3fa71138bc : HardwiredMemberDescriptor
      {
        internal PROP_f1dbe598a1f9482385b82b3fa71138bc()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_32b16334e7294db890d064d697662dc7 : HardwiredMemberDescriptor
      {
        internal PROP_32b16334e7294db890d064d697662dc7()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_ef07473f4b924fecbd092758c2ffc658 : HardwiredMemberDescriptor
      {
        internal PROP_ef07473f4b924fecbd092758c2ffc658()
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

      private sealed class PROP_b76e2ad909c6484a90e40608080cb814 : HardwiredMemberDescriptor
      {
        internal PROP_b76e2ad909c6484a90e40608080cb814()
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

      private sealed class PROP_9462ed0aae654338b6a1bbbde2627f3d : HardwiredMemberDescriptor
      {
        internal PROP_9462ed0aae654338b6a1bbbde2627f3d()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_bc2aa7c44c814bfbab7f46cc90dd1c13 : HardwiredMemberDescriptor
      {
        internal PROP_bc2aa7c44c814bfbab7f46cc90dd1c13()
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

      private sealed class PROP_d007c4ceec3f4deeb9393f7ebd3320b5 : HardwiredMemberDescriptor
      {
        internal PROP_d007c4ceec3f4deeb9393f7ebd3320b5()
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

      private sealed class PROP_3b85c300becf4187a1672f65257505c0 : HardwiredMemberDescriptor
      {
        internal PROP_3b85c300becf4187a1672f65257505c0()
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

      private sealed class PROP_7ecacbd74ea6446b9303b4a1b7a92e9c : HardwiredMemberDescriptor
      {
        internal PROP_7ecacbd74ea6446b9303b4a1b7a92e9c()
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

      private sealed class PROP_eee9d97235114638a6cac822f9339f76 : HardwiredMemberDescriptor
      {
        internal PROP_eee9d97235114638a6cac822f9339f76()
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

      private sealed class PROP_b515b8a1b21a41ad8bc5ca27a738559b : HardwiredMemberDescriptor
      {
        internal PROP_b515b8a1b21a41ad8bc5ca27a738559b()
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

      private sealed class PROP_bb263eea9c4d408ebaa346ff6dea4241 : HardwiredMemberDescriptor
      {
        internal PROP_bb263eea9c4d408ebaa346ff6dea4241()
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

      private sealed class PROP_98356fdc77d247f9a33d9a1394eb75fd : HardwiredMemberDescriptor
      {
        internal PROP_98356fdc77d247f9a33d9a1394eb75fd()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_7a70e92b6d984dedaf1529a61ad18a2b : HardwiredMemberDescriptor
      {
        internal PROP_7a70e92b6d984dedaf1529a61ad18a2b()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_3090c8a8ba484f0fbe82e5f785759982 : HardwiredMemberDescriptor
      {
        internal PROP_3090c8a8ba484f0fbe82e5f785759982()
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

      private sealed class PROP_988fe83a984b499798ab7ba58870be59 : HardwiredMemberDescriptor
      {
        internal PROP_988fe83a984b499798ab7ba58870be59()
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

      private sealed class PROP_1c121847b1a74190864e84077f5c7ea5 : HardwiredMemberDescriptor
      {
        internal PROP_1c121847b1a74190864e84077f5c7ea5()
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

      private sealed class PROP_20dd36118c6448909d5fdb435a0c0425 : HardwiredMemberDescriptor
      {
        internal PROP_20dd36118c6448909d5fdb435a0c0425()
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

      private sealed class PROP_0ebaa0a112964c5eb366b1804d8022e3 : HardwiredMemberDescriptor
      {
        internal PROP_0ebaa0a112964c5eb366b1804d8022e3()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_6e05f673b5ed4845b91c5e43fc50707d : HardwiredMemberDescriptor
      {
        internal PROP_6e05f673b5ed4845b91c5e43fc50707d()
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

      private sealed class PROP_2521a96141124b578d082a706a44d5d4 : HardwiredMemberDescriptor
      {
        internal PROP_2521a96141124b578d082a706a44d5d4()
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

      private sealed class PROP_d5da6ff53d2a42a689f46f9ec581c829 : HardwiredMemberDescriptor
      {
        internal PROP_d5da6ff53d2a42a689f46f9ec581c829()
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

      private sealed class PROP_85e8c68a8bcb4b3eac1b0fbc57ee5a98 : HardwiredMemberDescriptor
      {
        internal PROP_85e8c68a8bcb4b3eac1b0fbc57ee5a98()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_8e89e5c9f7eb4d94b7852f5bf0c53b88 : HardwiredMemberDescriptor
      {
        internal PROP_8e89e5c9f7eb4d94b7852f5bf0c53b88()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_27d9cf9be92f469ebe5acc0bbedeafd4 : HardwiredMemberDescriptor
      {
        internal PROP_27d9cf9be92f469ebe5acc0bbedeafd4()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_72470098703b494f9692496eac1dc642 : HardwiredMemberDescriptor
      {
        internal PROP_72470098703b494f9692496eac1dc642()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_bb78c809c1c54acb9f08a7a843d6f427 : HardwiredMemberDescriptor
      {
        internal PROP_bb78c809c1c54acb9f08a7a843d6f427()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_47696e9119b34a4096231417fdc6408f : HardwiredMemberDescriptor
      {
        internal PROP_47696e9119b34a4096231417fdc6408f()
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

      private sealed class PROP_4430f7f70036474a82e7a0660a62d8a9 : HardwiredMemberDescriptor
      {
        internal PROP_4430f7f70036474a82e7a0660a62d8a9()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_1ddf5b89db9540a78f3eabb3797c92e1 : HardwiredMemberDescriptor
      {
        internal PROP_1ddf5b89db9540a78f3eabb3797c92e1()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_919d2a930a2d4a0aae37cd743b78ee12 : HardwiredMemberDescriptor
      {
        internal PROP_919d2a930a2d4a0aae37cd743b78ee12()
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

      private sealed class PROP_b9de03d8993b4b00a7ccdd4e31bebbe3 : HardwiredMemberDescriptor
      {
        internal PROP_b9de03d8993b4b00a7ccdd4e31bebbe3()
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

    private sealed class TYPE_2851c6eb9609416089a8743e4cdcd336 : HardwiredUserDataDescriptor
    {
      internal TYPE_2851c6eb9609416089a8743e4cdcd336()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.MTHD_c25a61728ca94bbdb05c5c2bd8b64c03()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.MTHD_364046a28c9b48bca6caa21ec9d5f599()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.MTHD_a2ee8fd21cec46e4944a43e9e928c1d0()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.MTHD_bdb4e7da50884ccd9d3d4e71ec938f56()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.MTHD_e26ef0ddb0fd4adc95053c24d8773751()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.MTHD_c280f0e69e2b43938e67486c4a1a9611()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.MTHD_b8b2e2268d424330b0efce7195528503()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.MTHD_355a86f962a44c8f9c800e761cdbd6d8()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.MTHD_f465e7eca6a74049adfb67b64863c6ee()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.MTHD_7f73328dd32e44d08f52ce84b6798525()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.MTHD_6f4d832f082b40db92f4ee73038a99a2()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.MTHD_17c22112b1ac43efa7c4f95f76ed74ac()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.MTHD_a08cc18f16924c46959c33d2004fe004()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.MTHD_05a748dbabaa4b99b019f8da90d4731d()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.MTHD_424af3359f07492b924b05d96ad3354a()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.MTHD_6db625140d4b42c1bf1e9e2bcbf95c10()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.MTHD_129472bd3c5b42dca175ea040bbe6fab()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.MTHD_49bd9f096217424e85db226b521dc3b7()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.MTHD_ed3f3dfd42ff48d5b879b9b79278c4af()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.MTHD_eb227e6bfaa949a0b759316ce6819089()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.PROP_cfa0544f486e4e71abbf03f3e6b6de80());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.PROP_562fcd1b3bdf41da846fc406e8e14e35());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.PROP_859a99ceff7e4b608fa5a1723a2f8ad3());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.PROP_83479a2967a74ad8afc259420f841290());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.PROP_42a9aeb0a0334362b4e5eb32dea52ade());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.PROP_79c56bf01205473dbf201120bd7a8a4f());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.PROP_1b077f3905f04c3f9ef3e59ea8777316());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_2851c6eb9609416089a8743e4cdcd336.PROP_7d66008d62ae4bb1a6a2a361c66aa20e());
      }

      private sealed class MTHD_c25a61728ca94bbdb05c5c2bd8b64c03 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c25a61728ca94bbdb05c5c2bd8b64c03()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_364046a28c9b48bca6caa21ec9d5f599 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_364046a28c9b48bca6caa21ec9d5f599()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_a2ee8fd21cec46e4944a43e9e928c1d0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2ee8fd21cec46e4944a43e9e928c1d0()
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

      private sealed class MTHD_bdb4e7da50884ccd9d3d4e71ec938f56 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bdb4e7da50884ccd9d3d4e71ec938f56()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_e26ef0ddb0fd4adc95053c24d8773751 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e26ef0ddb0fd4adc95053c24d8773751()
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

      private sealed class MTHD_c280f0e69e2b43938e67486c4a1a9611 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c280f0e69e2b43938e67486c4a1a9611()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_b8b2e2268d424330b0efce7195528503 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b8b2e2268d424330b0efce7195528503()
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

      private sealed class MTHD_355a86f962a44c8f9c800e761cdbd6d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_355a86f962a44c8f9c800e761cdbd6d8()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_f465e7eca6a74049adfb67b64863c6ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f465e7eca6a74049adfb67b64863c6ee()
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

      private sealed class MTHD_7f73328dd32e44d08f52ce84b6798525 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f73328dd32e44d08f52ce84b6798525()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_6f4d832f082b40db92f4ee73038a99a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6f4d832f082b40db92f4ee73038a99a2()
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

      private sealed class MTHD_17c22112b1ac43efa7c4f95f76ed74ac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_17c22112b1ac43efa7c4f95f76ed74ac()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_a08cc18f16924c46959c33d2004fe004 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a08cc18f16924c46959c33d2004fe004()
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

      private sealed class MTHD_05a748dbabaa4b99b019f8da90d4731d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_05a748dbabaa4b99b019f8da90d4731d()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_424af3359f07492b924b05d96ad3354a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_424af3359f07492b924b05d96ad3354a()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_6db625140d4b42c1bf1e9e2bcbf95c10 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6db625140d4b42c1bf1e9e2bcbf95c10()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_129472bd3c5b42dca175ea040bbe6fab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_129472bd3c5b42dca175ea040bbe6fab()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_49bd9f096217424e85db226b521dc3b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49bd9f096217424e85db226b521dc3b7()
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

      private sealed class MTHD_ed3f3dfd42ff48d5b879b9b79278c4af : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed3f3dfd42ff48d5b879b9b79278c4af()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_eb227e6bfaa949a0b759316ce6819089 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb227e6bfaa949a0b759316ce6819089()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_cfa0544f486e4e71abbf03f3e6b6de80 : HardwiredMemberDescriptor
      {
        internal PROP_cfa0544f486e4e71abbf03f3e6b6de80()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_562fcd1b3bdf41da846fc406e8e14e35 : HardwiredMemberDescriptor
      {
        internal PROP_562fcd1b3bdf41da846fc406e8e14e35()
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

      private sealed class PROP_859a99ceff7e4b608fa5a1723a2f8ad3 : HardwiredMemberDescriptor
      {
        internal PROP_859a99ceff7e4b608fa5a1723a2f8ad3()
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

      private sealed class PROP_83479a2967a74ad8afc259420f841290 : HardwiredMemberDescriptor
      {
        internal PROP_83479a2967a74ad8afc259420f841290()
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

      private sealed class PROP_42a9aeb0a0334362b4e5eb32dea52ade : HardwiredMemberDescriptor
      {
        internal PROP_42a9aeb0a0334362b4e5eb32dea52ade()
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

      private sealed class PROP_79c56bf01205473dbf201120bd7a8a4f : HardwiredMemberDescriptor
      {
        internal PROP_79c56bf01205473dbf201120bd7a8a4f()
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

      private sealed class PROP_1b077f3905f04c3f9ef3e59ea8777316 : HardwiredMemberDescriptor
      {
        internal PROP_1b077f3905f04c3f9ef3e59ea8777316()
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

      private sealed class PROP_7d66008d62ae4bb1a6a2a361c66aa20e : HardwiredMemberDescriptor
      {
        internal PROP_7d66008d62ae4bb1a6a2a361c66aa20e()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_e0ec086923c045bb8e0d6c400db5014f : HardwiredUserDataDescriptor
    {
      internal TYPE_e0ec086923c045bb8e0d6c400db5014f()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.MTHD_5072d0554f3948869a18f26c09021809()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.MTHD_1936c3dd7631457ca283a382fb64bbdb()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.MTHD_e4ad53ac2fac407f9d64ed9bd9bdb1c0()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.MTHD_361a2e3b03e34c5aab9ee1d421888881()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.MTHD_c800131673d7410ba025be27266a5b38()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.MTHD_2fda52ef5e73465e9cb3ea19a6d27f6c()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.MTHD_0e2f97b82fe14675930eab05dc59f698()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.MTHD_abbed09c0c484aec8b609f72f9cff488()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.MTHD_e54f49acafa544d7b94ddde0361b88c0()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.MTHD_a6059c5567d648af96946a08eb6c16fb()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.MTHD_4a2c546f27b041f9a76aac8514ec95e4()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.MTHD_b24f642d8c9046639c763385f9aabb23()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.MTHD_9936ffedac33443b823e9462e9e1a924()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.MTHD_faf504af8d2a431c8ca9708024a8fcac()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.MTHD_90220e60691d4a4ea44264dd96db5eef()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.MTHD_3bea3736b5cb4ebfa3dc5c78f11eb292()
        }));
        this.AddMember("setIcon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setIcon", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.MTHD_32ce642011034cd788d0564871abc1b7()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.MTHD_b4744bc0ce7f445c97ecdd5e440dd25d()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.MTHD_60ac277353db4acabb8e2df8eb31f4fa()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.MTHD_024101a196dd4450970404918e6ee858()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.MTHD_fc804dc70ba846dca486f90a50e207cc()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.MTHD_dd376b3e093f44e198bc433e38e10c26()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.PROP_b87b48978f224588928b7602189c0bc2());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.PROP_56e9fae6f5da4a7fbb63c62f55aead19());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.PROP_591a8cba7b0640ec9d247a23bbd64e56());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.PROP_824f4acb85af4a7fad31bebb3901eac3());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.PROP_37b68a33bbab49ceb4f7f3ddcbcd3906());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.PROP_f118221a98804d279a848ce1edf9aaa0());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.PROP_dc1a6df3ff8b4ebb98d82d44e7c3ff70());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.PROP_d5219b8a0cae4950bc27715ac1618b04());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_e0ec086923c045bb8e0d6c400db5014f.PROP_7aa76e09ca50446ab7636f5070706712());
      }

      private sealed class MTHD_5072d0554f3948869a18f26c09021809 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5072d0554f3948869a18f26c09021809()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_1936c3dd7631457ca283a382fb64bbdb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1936c3dd7631457ca283a382fb64bbdb()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_e4ad53ac2fac407f9d64ed9bd9bdb1c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e4ad53ac2fac407f9d64ed9bd9bdb1c0()
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

      private sealed class MTHD_361a2e3b03e34c5aab9ee1d421888881 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_361a2e3b03e34c5aab9ee1d421888881()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_c800131673d7410ba025be27266a5b38 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c800131673d7410ba025be27266a5b38()
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

      private sealed class MTHD_2fda52ef5e73465e9cb3ea19a6d27f6c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2fda52ef5e73465e9cb3ea19a6d27f6c()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_0e2f97b82fe14675930eab05dc59f698 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e2f97b82fe14675930eab05dc59f698()
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

      private sealed class MTHD_abbed09c0c484aec8b609f72f9cff488 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_abbed09c0c484aec8b609f72f9cff488()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_e54f49acafa544d7b94ddde0361b88c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e54f49acafa544d7b94ddde0361b88c0()
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

      private sealed class MTHD_a6059c5567d648af96946a08eb6c16fb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6059c5567d648af96946a08eb6c16fb()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_4a2c546f27b041f9a76aac8514ec95e4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a2c546f27b041f9a76aac8514ec95e4()
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

      private sealed class MTHD_b24f642d8c9046639c763385f9aabb23 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b24f642d8c9046639c763385f9aabb23()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_9936ffedac33443b823e9462e9e1a924 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9936ffedac33443b823e9462e9e1a924()
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

      private sealed class MTHD_faf504af8d2a431c8ca9708024a8fcac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_faf504af8d2a431c8ca9708024a8fcac()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color2;
        }
      }

      private sealed class MTHD_90220e60691d4a4ea44264dd96db5eef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90220e60691d4a4ea44264dd96db5eef()
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

      private sealed class MTHD_3bea3736b5cb4ebfa3dc5c78f11eb292 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3bea3736b5cb4ebfa3dc5c78f11eb292()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_32ce642011034cd788d0564871abc1b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_32ce642011034cd788d0564871abc1b7()
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

      private sealed class MTHD_b4744bc0ce7f445c97ecdd5e440dd25d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b4744bc0ce7f445c97ecdd5e440dd25d()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_60ac277353db4acabb8e2df8eb31f4fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60ac277353db4acabb8e2df8eb31f4fa()
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

      private sealed class MTHD_024101a196dd4450970404918e6ee858 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_024101a196dd4450970404918e6ee858()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_fc804dc70ba846dca486f90a50e207cc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fc804dc70ba846dca486f90a50e207cc()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_dd376b3e093f44e198bc433e38e10c26 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dd376b3e093f44e198bc433e38e10c26()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_b87b48978f224588928b7602189c0bc2 : HardwiredMemberDescriptor
      {
        internal PROP_b87b48978f224588928b7602189c0bc2()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_56e9fae6f5da4a7fbb63c62f55aead19 : HardwiredMemberDescriptor
      {
        internal PROP_56e9fae6f5da4a7fbb63c62f55aead19()
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

      private sealed class PROP_591a8cba7b0640ec9d247a23bbd64e56 : HardwiredMemberDescriptor
      {
        internal PROP_591a8cba7b0640ec9d247a23bbd64e56()
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

      private sealed class PROP_824f4acb85af4a7fad31bebb3901eac3 : HardwiredMemberDescriptor
      {
        internal PROP_824f4acb85af4a7fad31bebb3901eac3()
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

      private sealed class PROP_37b68a33bbab49ceb4f7f3ddcbcd3906 : HardwiredMemberDescriptor
      {
        internal PROP_37b68a33bbab49ceb4f7f3ddcbcd3906()
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

      private sealed class PROP_f118221a98804d279a848ce1edf9aaa0 : HardwiredMemberDescriptor
      {
        internal PROP_f118221a98804d279a848ce1edf9aaa0()
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

      private sealed class PROP_dc1a6df3ff8b4ebb98d82d44e7c3ff70 : HardwiredMemberDescriptor
      {
        internal PROP_dc1a6df3ff8b4ebb98d82d44e7c3ff70()
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

      private sealed class PROP_d5219b8a0cae4950bc27715ac1618b04 : HardwiredMemberDescriptor
      {
        internal PROP_d5219b8a0cae4950bc27715ac1618b04()
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

      private sealed class PROP_7aa76e09ca50446ab7636f5070706712 : HardwiredMemberDescriptor
      {
        internal PROP_7aa76e09ca50446ab7636f5070706712()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_9661697b92814155aa4cc9bbfdf0f319 : HardwiredUserDataDescriptor
    {
      internal TYPE_9661697b92814155aa4cc9bbfdf0f319()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_f2d6a58a8a1d471db190105e571b9092()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_018a243c327d421b901863ad0eb7e814()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_8f4e536bba5c47628e1cf9ee80066911()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_8e2e9861d05c406693a173348a6931ff()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_eb4ef1d5faea45f198dc6f3e00654d6b()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_1397defae7644c87be273680aba48051()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_5c3e171a78f74b70ae5be6083527afdf()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_cbd8bb4cf339438084288ae7c9671c0d()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_9973dcc13be44dfea876afe7be6de6e0()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_2bfddc6e84c34eba88391aaf63c85454()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_659398304e364c75a349141ceea7e775()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_acae558b90bc4670a898e2c22ed40aa1()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_6996fbb472314eb0b1bd929982821e2f()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_11b5b81488e44ec389c08c94ee4ce0c5()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_6e83d45fb50e449fac8665f9ea16cdce()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_5b7c3d4ca79540c2bf7faf76bc9bc160()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_396770c8136c44958ec993aa77b00259()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_cb473c918e684fe7a3a3b2171c8f3808()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_a10b9e04add7487db9594dc9e035592e()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_358ddfca19c94ad18398dabf708e18ea()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_15d4a9860e194a4bb8bc65fe0d464bd8()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_7b8d420e47954f13a310f80a8deba19c()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_768f607de51444cbbd0dfd02d9aa8094()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_d056273131414eb0aa5a51df796c9b6f()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_ddd79a233ae247e4bc0d10f41ae961c5()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_1fa96d5f1af74d76ae8303b8789400fe()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_a7d764ce57374d2694ab5ea402d08529()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.MTHD_99e9e69cc3d0484995d614d71ade397b()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.PROP_4b53f3b2a7cc45db976f49dbdb4f87fd());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.PROP_c5750407c9d54f4e876dbfbf296a02f5());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.PROP_90e4cdc660614f66822f868226f657e1());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.PROP_770102306c704bc085069675f3b2d25d());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.PROP_73f22d98a01e4d24a474470b5b978efe());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.PROP_ff3377398fc84bf3b0b7da4c655f3066());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.PROP_9e044fb4ba844a8ea3ef5ca3ffc3b77c());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.PROP_fae31fd2cbd248eca69c4c968cfa4b3c());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.PROP_d5f7ecf0fe874c838ddc3c416d9eeba6());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.PROP_30b678e73f9347c9b44d6f3f67d52692());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.PROP_782cbdfbebbb44b195d6dd69ebb874ed());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.PROP_3adebb58f2d642a290006faef80a57fd());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.PROP_d7793d67c3a2498d905eb0c625e54116());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.PROP_68e9b64a31314e03895f3b345faa8c54());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.PROP_805d24f572664c928e20dadccfe054f2());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.PROP_e327209b604e41bca4bc23bd8e0d4dc2());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_9661697b92814155aa4cc9bbfdf0f319.PROP_aa02d83bb3ac47ab87b6320f705f1fa0());
      }

      private sealed class MTHD_f2d6a58a8a1d471db190105e571b9092 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f2d6a58a8a1d471db190105e571b9092()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_018a243c327d421b901863ad0eb7e814 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_018a243c327d421b901863ad0eb7e814()
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

      private sealed class MTHD_8f4e536bba5c47628e1cf9ee80066911 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8f4e536bba5c47628e1cf9ee80066911()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_8e2e9861d05c406693a173348a6931ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e2e9861d05c406693a173348a6931ff()
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

      private sealed class MTHD_eb4ef1d5faea45f198dc6f3e00654d6b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb4ef1d5faea45f198dc6f3e00654d6b()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_1397defae7644c87be273680aba48051 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1397defae7644c87be273680aba48051()
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

      private sealed class MTHD_5c3e171a78f74b70ae5be6083527afdf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c3e171a78f74b70ae5be6083527afdf()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_cbd8bb4cf339438084288ae7c9671c0d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cbd8bb4cf339438084288ae7c9671c0d()
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

      private sealed class MTHD_9973dcc13be44dfea876afe7be6de6e0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9973dcc13be44dfea876afe7be6de6e0()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_2bfddc6e84c34eba88391aaf63c85454 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2bfddc6e84c34eba88391aaf63c85454()
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

      private sealed class MTHD_659398304e364c75a349141ceea7e775 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_659398304e364c75a349141ceea7e775()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_acae558b90bc4670a898e2c22ed40aa1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_acae558b90bc4670a898e2c22ed40aa1()
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

      private sealed class MTHD_6996fbb472314eb0b1bd929982821e2f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6996fbb472314eb0b1bd929982821e2f()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_11b5b81488e44ec389c08c94ee4ce0c5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_11b5b81488e44ec389c08c94ee4ce0c5()
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

      private sealed class MTHD_6e83d45fb50e449fac8665f9ea16cdce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e83d45fb50e449fac8665f9ea16cdce()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_5b7c3d4ca79540c2bf7faf76bc9bc160 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b7c3d4ca79540c2bf7faf76bc9bc160()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_396770c8136c44958ec993aa77b00259 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_396770c8136c44958ec993aa77b00259()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_cb473c918e684fe7a3a3b2171c8f3808 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cb473c918e684fe7a3a3b2171c8f3808()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_a10b9e04add7487db9594dc9e035592e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a10b9e04add7487db9594dc9e035592e()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_358ddfca19c94ad18398dabf708e18ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_358ddfca19c94ad18398dabf708e18ea()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_15d4a9860e194a4bb8bc65fe0d464bd8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15d4a9860e194a4bb8bc65fe0d464bd8()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_7b8d420e47954f13a310f80a8deba19c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b8d420e47954f13a310f80a8deba19c()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_768f607de51444cbbd0dfd02d9aa8094 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_768f607de51444cbbd0dfd02d9aa8094()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_d056273131414eb0aa5a51df796c9b6f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d056273131414eb0aa5a51df796c9b6f()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_ddd79a233ae247e4bc0d10f41ae961c5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ddd79a233ae247e4bc0d10f41ae961c5()
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

      private sealed class MTHD_1fa96d5f1af74d76ae8303b8789400fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1fa96d5f1af74d76ae8303b8789400fe()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_a7d764ce57374d2694ab5ea402d08529 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a7d764ce57374d2694ab5ea402d08529()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_99e9e69cc3d0484995d614d71ade397b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99e9e69cc3d0484995d614d71ade397b()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_4b53f3b2a7cc45db976f49dbdb4f87fd : HardwiredMemberDescriptor
      {
        internal PROP_4b53f3b2a7cc45db976f49dbdb4f87fd()
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

      private sealed class PROP_c5750407c9d54f4e876dbfbf296a02f5 : HardwiredMemberDescriptor
      {
        internal PROP_c5750407c9d54f4e876dbfbf296a02f5()
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

      private sealed class PROP_90e4cdc660614f66822f868226f657e1 : HardwiredMemberDescriptor
      {
        internal PROP_90e4cdc660614f66822f868226f657e1()
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

      private sealed class PROP_770102306c704bc085069675f3b2d25d : HardwiredMemberDescriptor
      {
        internal PROP_770102306c704bc085069675f3b2d25d()
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

      private sealed class PROP_73f22d98a01e4d24a474470b5b978efe : HardwiredMemberDescriptor
      {
        internal PROP_73f22d98a01e4d24a474470b5b978efe()
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

      private sealed class PROP_ff3377398fc84bf3b0b7da4c655f3066 : HardwiredMemberDescriptor
      {
        internal PROP_ff3377398fc84bf3b0b7da4c655f3066()
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

      private sealed class PROP_9e044fb4ba844a8ea3ef5ca3ffc3b77c : HardwiredMemberDescriptor
      {
        internal PROP_9e044fb4ba844a8ea3ef5ca3ffc3b77c()
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

      private sealed class PROP_fae31fd2cbd248eca69c4c968cfa4b3c : HardwiredMemberDescriptor
      {
        internal PROP_fae31fd2cbd248eca69c4c968cfa4b3c()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_d5f7ecf0fe874c838ddc3c416d9eeba6 : HardwiredMemberDescriptor
      {
        internal PROP_d5f7ecf0fe874c838ddc3c416d9eeba6()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_30b678e73f9347c9b44d6f3f67d52692 : HardwiredMemberDescriptor
      {
        internal PROP_30b678e73f9347c9b44d6f3f67d52692()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_782cbdfbebbb44b195d6dd69ebb874ed : HardwiredMemberDescriptor
      {
        internal PROP_782cbdfbebbb44b195d6dd69ebb874ed()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_3adebb58f2d642a290006faef80a57fd : HardwiredMemberDescriptor
      {
        internal PROP_3adebb58f2d642a290006faef80a57fd()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_d7793d67c3a2498d905eb0c625e54116 : HardwiredMemberDescriptor
      {
        internal PROP_d7793d67c3a2498d905eb0c625e54116()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_68e9b64a31314e03895f3b345faa8c54 : HardwiredMemberDescriptor
      {
        internal PROP_68e9b64a31314e03895f3b345faa8c54()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_805d24f572664c928e20dadccfe054f2 : HardwiredMemberDescriptor
      {
        internal PROP_805d24f572664c928e20dadccfe054f2()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_e327209b604e41bca4bc23bd8e0d4dc2 : HardwiredMemberDescriptor
      {
        internal PROP_e327209b604e41bca4bc23bd8e0d4dc2()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_aa02d83bb3ac47ab87b6320f705f1fa0 : HardwiredMemberDescriptor
      {
        internal PROP_aa02d83bb3ac47ab87b6320f705f1fa0()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_758bc7af1b27432f84c5997dd6635e61 : HardwiredUserDataDescriptor
    {
      internal TYPE_758bc7af1b27432f84c5997dd6635e61()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_758bc7af1b27432f84c5997dd6635e61.MTHD_8d41b29638e2400fb5cd58f165a4adfb()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_758bc7af1b27432f84c5997dd6635e61.MTHD_bfe59c6507094d2c8106a0f30f788080()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_758bc7af1b27432f84c5997dd6635e61.MTHD_c70bf6ffdb02404a9cffbd5cbff77fa3()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_758bc7af1b27432f84c5997dd6635e61.MTHD_c7d2a2e9904e4d4c898e1eda6f569e6a()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_758bc7af1b27432f84c5997dd6635e61.MTHD_c45337ee792a40be8f090ca9880b9938()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_758bc7af1b27432f84c5997dd6635e61.MTHD_553a2991716649d4a63c6e6c8eef26d7()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_758bc7af1b27432f84c5997dd6635e61.MTHD_929938bff8fe4e86b9f9ced0cee9b28e()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_758bc7af1b27432f84c5997dd6635e61.MTHD_10b6be35951a453d8cfb46b2e6b9b8ce()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_758bc7af1b27432f84c5997dd6635e61.MTHD_d239d3dd78814500a9e5f18ebc47b9e3()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_758bc7af1b27432f84c5997dd6635e61.MTHD_9b879832988a445ba02a1370ce09373a()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_758bc7af1b27432f84c5997dd6635e61.MTHD_a7bfb86a1809453f834cb8c281db7eff()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_758bc7af1b27432f84c5997dd6635e61.MTHD_9d14d78a59ad41348ed1f47041f8cbbe()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_758bc7af1b27432f84c5997dd6635e61.MTHD_9aaccadb98044459b52e3db571d17126()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_758bc7af1b27432f84c5997dd6635e61.MTHD_f7064c838ec44f2b808ccc1cd8dce4d5()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_758bc7af1b27432f84c5997dd6635e61.MTHD_4c7655e83dfd409383f8b24131da34cc()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_758bc7af1b27432f84c5997dd6635e61.MTHD_fb155fc8bd194c6bb499990cd2e59102()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_758bc7af1b27432f84c5997dd6635e61.MTHD_5854e1474b5c474cbd98491c7e5e71fc()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_758bc7af1b27432f84c5997dd6635e61.PROP_0c26ad2b234e48a2ba33d7261dff1bf5());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_758bc7af1b27432f84c5997dd6635e61.PROP_1260c4ea6771481c854126991df129bb());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_758bc7af1b27432f84c5997dd6635e61.PROP_cda64ddbeb9140f39fa0bc2be5a8606a());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_758bc7af1b27432f84c5997dd6635e61.PROP_e6d48320924446529a5a77fa7826eacb());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_758bc7af1b27432f84c5997dd6635e61.PROP_585cc1279e8242f882644749cbffa941());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_758bc7af1b27432f84c5997dd6635e61.PROP_4b93b385ae4b49acbbe44d8403d832ce());
      }

      private sealed class MTHD_8d41b29638e2400fb5cd58f165a4adfb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8d41b29638e2400fb5cd58f165a4adfb()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_bfe59c6507094d2c8106a0f30f788080 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bfe59c6507094d2c8106a0f30f788080()
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

      private sealed class MTHD_c70bf6ffdb02404a9cffbd5cbff77fa3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c70bf6ffdb02404a9cffbd5cbff77fa3()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_c7d2a2e9904e4d4c898e1eda6f569e6a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c7d2a2e9904e4d4c898e1eda6f569e6a()
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

      private sealed class MTHD_c45337ee792a40be8f090ca9880b9938 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c45337ee792a40be8f090ca9880b9938()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_553a2991716649d4a63c6e6c8eef26d7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_553a2991716649d4a63c6e6c8eef26d7()
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

      private sealed class MTHD_929938bff8fe4e86b9f9ced0cee9b28e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_929938bff8fe4e86b9f9ced0cee9b28e()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_10b6be35951a453d8cfb46b2e6b9b8ce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_10b6be35951a453d8cfb46b2e6b9b8ce()
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

      private sealed class MTHD_d239d3dd78814500a9e5f18ebc47b9e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d239d3dd78814500a9e5f18ebc47b9e3()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_9b879832988a445ba02a1370ce09373a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b879832988a445ba02a1370ce09373a()
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

      private sealed class MTHD_a7bfb86a1809453f834cb8c281db7eff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a7bfb86a1809453f834cb8c281db7eff()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_9d14d78a59ad41348ed1f47041f8cbbe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d14d78a59ad41348ed1f47041f8cbbe()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_9aaccadb98044459b52e3db571d17126 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9aaccadb98044459b52e3db571d17126()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f7064c838ec44f2b808ccc1cd8dce4d5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7064c838ec44f2b808ccc1cd8dce4d5()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_4c7655e83dfd409383f8b24131da34cc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c7655e83dfd409383f8b24131da34cc()
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

      private sealed class MTHD_fb155fc8bd194c6bb499990cd2e59102 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb155fc8bd194c6bb499990cd2e59102()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_5854e1474b5c474cbd98491c7e5e71fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5854e1474b5c474cbd98491c7e5e71fc()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_0c26ad2b234e48a2ba33d7261dff1bf5 : HardwiredMemberDescriptor
      {
        internal PROP_0c26ad2b234e48a2ba33d7261dff1bf5()
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

      private sealed class PROP_1260c4ea6771481c854126991df129bb : HardwiredMemberDescriptor
      {
        internal PROP_1260c4ea6771481c854126991df129bb()
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

      private sealed class PROP_cda64ddbeb9140f39fa0bc2be5a8606a : HardwiredMemberDescriptor
      {
        internal PROP_cda64ddbeb9140f39fa0bc2be5a8606a()
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

      private sealed class PROP_e6d48320924446529a5a77fa7826eacb : HardwiredMemberDescriptor
      {
        internal PROP_e6d48320924446529a5a77fa7826eacb()
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

      private sealed class PROP_585cc1279e8242f882644749cbffa941 : HardwiredMemberDescriptor
      {
        internal PROP_585cc1279e8242f882644749cbffa941()
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

      private sealed class PROP_4b93b385ae4b49acbbe44d8403d832ce : HardwiredMemberDescriptor
      {
        internal PROP_4b93b385ae4b49acbbe44d8403d832ce()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_04e8acaef74f4a208b19e5852447dcc4 : HardwiredUserDataDescriptor
    {
      internal TYPE_04e8acaef74f4a208b19e5852447dcc4()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04e8acaef74f4a208b19e5852447dcc4.MTHD_dfc00ecfd4e444f1b9ac86c13a3afd80(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04e8acaef74f4a208b19e5852447dcc4.MTHD_1c2f24716c384759be84c2cc481b0eee()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04e8acaef74f4a208b19e5852447dcc4.MTHD_bbe774bfba624be7ba26f3c2ae5c75b7(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04e8acaef74f4a208b19e5852447dcc4.MTHD_29da0f1d7b1b46c7994780b7fe64f9fc()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04e8acaef74f4a208b19e5852447dcc4.MTHD_200cbeff31a4441bb728153a587e0532()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04e8acaef74f4a208b19e5852447dcc4.MTHD_47064c9a2bec4b8f9604a7162764e232()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04e8acaef74f4a208b19e5852447dcc4.MTHD_fe3e3be4209e4b989afa1c33cd9225a6()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04e8acaef74f4a208b19e5852447dcc4.MTHD_6d6c29bc8fbe411b98a1550f3f13ceb1()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04e8acaef74f4a208b19e5852447dcc4.MTHD_69e2211619d6408c8597c4f6e33d1f9a()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04e8acaef74f4a208b19e5852447dcc4.MTHD_3e5f5d6edf084697876ac4c1d5fe9d40()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04e8acaef74f4a208b19e5852447dcc4.MTHD_a9ee85a1d5ff4cdf8d114aa27cfa7d43()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04e8acaef74f4a208b19e5852447dcc4.MTHD_82be13f89f60437b8ef522b98d12b794(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04e8acaef74f4a208b19e5852447dcc4.MTHD_e370b5ce28994076ac86187c7cc7fcac()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04e8acaef74f4a208b19e5852447dcc4.MTHD_dceff664eec5492684d74b98f4220fc1(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04e8acaef74f4a208b19e5852447dcc4.MTHD_7e4a9cb98b944a848e1540df40135b95()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04e8acaef74f4a208b19e5852447dcc4.MTHD_4b4039ccfdcd4e449f70ba2f21935da1(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04e8acaef74f4a208b19e5852447dcc4.MTHD_6d5a89e1f4c341d7b77cfa241569c390()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04e8acaef74f4a208b19e5852447dcc4.MTHD_ba99ab6a843e4d72a8cfe12d18804e89(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04e8acaef74f4a208b19e5852447dcc4.MTHD_c8b3e11e323945d3accd732738d4b8f6()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04e8acaef74f4a208b19e5852447dcc4.MTHD_57ccde134d23466393de7ff3b75eee8f(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04e8acaef74f4a208b19e5852447dcc4.MTHD_69714ab0c26549859a03d8eb7b39cdb4()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04e8acaef74f4a208b19e5852447dcc4.MTHD_80a437b4623b44eca4f0caad41e8d51d()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_04e8acaef74f4a208b19e5852447dcc4.MTHD_51d10c67db3740268264108f1af74a6f()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_04e8acaef74f4a208b19e5852447dcc4.FLDV_70708fc8d64546018fbe1d3faa5d0cbf());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_04e8acaef74f4a208b19e5852447dcc4.FLDV_ece79a449ac84a80873b92f81c442f8b());
      }

      private sealed class MTHD_dfc00ecfd4e444f1b9ac86c13a3afd80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dfc00ecfd4e444f1b9ac86c13a3afd80()
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

      private sealed class MTHD_1c2f24716c384759be84c2cc481b0eee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c2f24716c384759be84c2cc481b0eee()
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

      private sealed class MTHD_bbe774bfba624be7ba26f3c2ae5c75b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bbe774bfba624be7ba26f3c2ae5c75b7()
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

      private sealed class MTHD_29da0f1d7b1b46c7994780b7fe64f9fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_29da0f1d7b1b46c7994780b7fe64f9fc()
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

      private sealed class MTHD_200cbeff31a4441bb728153a587e0532 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_200cbeff31a4441bb728153a587e0532()
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

      private sealed class MTHD_47064c9a2bec4b8f9604a7162764e232 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_47064c9a2bec4b8f9604a7162764e232()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_fe3e3be4209e4b989afa1c33cd9225a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fe3e3be4209e4b989afa1c33cd9225a6()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_6d6c29bc8fbe411b98a1550f3f13ceb1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d6c29bc8fbe411b98a1550f3f13ceb1()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_69e2211619d6408c8597c4f6e33d1f9a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69e2211619d6408c8597c4f6e33d1f9a()
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

      private sealed class MTHD_3e5f5d6edf084697876ac4c1d5fe9d40 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e5f5d6edf084697876ac4c1d5fe9d40()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_a9ee85a1d5ff4cdf8d114aa27cfa7d43 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a9ee85a1d5ff4cdf8d114aa27cfa7d43()
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

      private sealed class MTHD_82be13f89f60437b8ef522b98d12b794 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_82be13f89f60437b8ef522b98d12b794()
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

      private sealed class MTHD_e370b5ce28994076ac86187c7cc7fcac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e370b5ce28994076ac86187c7cc7fcac()
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

      private sealed class MTHD_dceff664eec5492684d74b98f4220fc1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dceff664eec5492684d74b98f4220fc1()
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

      private sealed class MTHD_7e4a9cb98b944a848e1540df40135b95 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7e4a9cb98b944a848e1540df40135b95()
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

      private sealed class MTHD_4b4039ccfdcd4e449f70ba2f21935da1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b4039ccfdcd4e449f70ba2f21935da1()
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

      private sealed class MTHD_6d5a89e1f4c341d7b77cfa241569c390 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d5a89e1f4c341d7b77cfa241569c390()
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

      private sealed class MTHD_ba99ab6a843e4d72a8cfe12d18804e89 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba99ab6a843e4d72a8cfe12d18804e89()
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

      private sealed class MTHD_c8b3e11e323945d3accd732738d4b8f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c8b3e11e323945d3accd732738d4b8f6()
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

      private sealed class MTHD_57ccde134d23466393de7ff3b75eee8f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57ccde134d23466393de7ff3b75eee8f()
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

      private sealed class MTHD_69714ab0c26549859a03d8eb7b39cdb4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69714ab0c26549859a03d8eb7b39cdb4()
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

      private sealed class MTHD_80a437b4623b44eca4f0caad41e8d51d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_80a437b4623b44eca4f0caad41e8d51d()
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

      private sealed class MTHD_51d10c67db3740268264108f1af74a6f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_51d10c67db3740268264108f1af74a6f()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_70708fc8d64546018fbe1d3faa5d0cbf : HardwiredMemberDescriptor
      {
        internal FLDV_70708fc8d64546018fbe1d3faa5d0cbf()
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

      private sealed class FLDV_ece79a449ac84a80873b92f81c442f8b : HardwiredMemberDescriptor
      {
        internal FLDV_ece79a449ac84a80873b92f81c442f8b()
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

    private sealed class TYPE_40bb7a2addca479ebe1a82b81e0be2f2 : HardwiredUserDataDescriptor
    {
      internal TYPE_40bb7a2addca479ebe1a82b81e0be2f2()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_40bb7a2addca479ebe1a82b81e0be2f2.MTHD_a82f9bb13fa54ef1badbe6705db03845()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_40bb7a2addca479ebe1a82b81e0be2f2.MTHD_93207c779cff4afc821a67acd77b0222()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_40bb7a2addca479ebe1a82b81e0be2f2.MTHD_8d399e817fc94fdcbc7de68737593a2b()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_40bb7a2addca479ebe1a82b81e0be2f2.MTHD_3bd1a10a05d84aa8ae668d46e4767688()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_40bb7a2addca479ebe1a82b81e0be2f2.MTHD_fb9c13b6808a4ee98a1eec77fc398616()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_40bb7a2addca479ebe1a82b81e0be2f2.MTHD_ddd8ede2b5354d959e5ab5095eea81de()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_40bb7a2addca479ebe1a82b81e0be2f2.FLDV_21ab5331ba844ec5a62163a3b8ff75b0());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_40bb7a2addca479ebe1a82b81e0be2f2.FLDV_e8972ee6c19e453c912b479e9f235641());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_40bb7a2addca479ebe1a82b81e0be2f2.FLDV_4b542a92cb3e4c25bd59b66aaa2dc718());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_40bb7a2addca479ebe1a82b81e0be2f2.FLDV_e2657dbd797a44449e00be393e07b664());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_40bb7a2addca479ebe1a82b81e0be2f2.FLDV_6660555716e04ec5a011002f46de3a1c());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_40bb7a2addca479ebe1a82b81e0be2f2.FLDV_f5159b8c213b4ef6b8f98651c6d79f13());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_40bb7a2addca479ebe1a82b81e0be2f2.FLDV_8adedb95ecb343768008d8a6fceaa0f6());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_40bb7a2addca479ebe1a82b81e0be2f2.FLDV_e9418195db7e4f31b4b0ee6ac757f512());
        this.AddMember("prestige", (IMemberDescriptor) new Bridge.TYPE_40bb7a2addca479ebe1a82b81e0be2f2.FLDV_db0cbb01d43140ee837f70be17b8c7f2());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_40bb7a2addca479ebe1a82b81e0be2f2.FLDV_70d7c27cca0144e68104f65013808691());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_40bb7a2addca479ebe1a82b81e0be2f2.FLDV_fd772dd5066744459c43f41a81c76563());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_40bb7a2addca479ebe1a82b81e0be2f2.FLDV_7a32e344321f47c190b3fdd9e9c5b3a2());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_40bb7a2addca479ebe1a82b81e0be2f2.FLDV_0f60682f3e9a4f83ac43510656773bd4());
      }

      private sealed class MTHD_a82f9bb13fa54ef1badbe6705db03845 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a82f9bb13fa54ef1badbe6705db03845()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_93207c779cff4afc821a67acd77b0222 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93207c779cff4afc821a67acd77b0222()
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

      private sealed class MTHD_8d399e817fc94fdcbc7de68737593a2b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8d399e817fc94fdcbc7de68737593a2b()
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

      private sealed class MTHD_3bd1a10a05d84aa8ae668d46e4767688 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3bd1a10a05d84aa8ae668d46e4767688()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_fb9c13b6808a4ee98a1eec77fc398616 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb9c13b6808a4ee98a1eec77fc398616()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_ddd8ede2b5354d959e5ab5095eea81de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ddd8ede2b5354d959e5ab5095eea81de()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_21ab5331ba844ec5a62163a3b8ff75b0 : HardwiredMemberDescriptor
      {
        internal FLDV_21ab5331ba844ec5a62163a3b8ff75b0()
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

      private sealed class FLDV_e8972ee6c19e453c912b479e9f235641 : HardwiredMemberDescriptor
      {
        internal FLDV_e8972ee6c19e453c912b479e9f235641()
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

      private sealed class FLDV_4b542a92cb3e4c25bd59b66aaa2dc718 : HardwiredMemberDescriptor
      {
        internal FLDV_4b542a92cb3e4c25bd59b66aaa2dc718()
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

      private sealed class FLDV_e2657dbd797a44449e00be393e07b664 : HardwiredMemberDescriptor
      {
        internal FLDV_e2657dbd797a44449e00be393e07b664()
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

      private sealed class FLDV_6660555716e04ec5a011002f46de3a1c : HardwiredMemberDescriptor
      {
        internal FLDV_6660555716e04ec5a011002f46de3a1c()
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

      private sealed class FLDV_f5159b8c213b4ef6b8f98651c6d79f13 : HardwiredMemberDescriptor
      {
        internal FLDV_f5159b8c213b4ef6b8f98651c6d79f13()
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

      private sealed class FLDV_8adedb95ecb343768008d8a6fceaa0f6 : HardwiredMemberDescriptor
      {
        internal FLDV_8adedb95ecb343768008d8a6fceaa0f6()
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

      private sealed class FLDV_e9418195db7e4f31b4b0ee6ac757f512 : HardwiredMemberDescriptor
      {
        internal FLDV_e9418195db7e4f31b4b0ee6ac757f512()
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

      private sealed class FLDV_db0cbb01d43140ee837f70be17b8c7f2 : HardwiredMemberDescriptor
      {
        internal FLDV_db0cbb01d43140ee837f70be17b8c7f2()
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

      private sealed class FLDV_70d7c27cca0144e68104f65013808691 : HardwiredMemberDescriptor
      {
        internal FLDV_70d7c27cca0144e68104f65013808691()
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

      private sealed class FLDV_fd772dd5066744459c43f41a81c76563 : HardwiredMemberDescriptor
      {
        internal FLDV_fd772dd5066744459c43f41a81c76563()
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

      private sealed class FLDV_7a32e344321f47c190b3fdd9e9c5b3a2 : HardwiredMemberDescriptor
      {
        internal FLDV_7a32e344321f47c190b3fdd9e9c5b3a2()
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

      private sealed class FLDV_0f60682f3e9a4f83ac43510656773bd4 : HardwiredMemberDescriptor
      {
        internal FLDV_0f60682f3e9a4f83ac43510656773bd4()
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

    private sealed class TYPE_ff2dae86364e4f79a1c23f116868c8bd : HardwiredUserDataDescriptor
    {
      internal TYPE_ff2dae86364e4f79a1c23f116868c8bd()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_71fd84c98592401a88d42ae54011e063()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_27524a16cb174f4caabe5b8cbedec941()
        }));
        this.AddMember("get_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_5caac70d42de4a6fa6bd01d278c13857()
        }));
        this.AddMember("set_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_70474e3c65824d008c273eafb0ba8389()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_ebb82f2032a5478c8d25c4f56c041239()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_3329f3e4540f4576b5c87d7db91f5d09()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_345bf14d12ce4116817f42d6424a91bc()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_7bc35fa00a2041e9aa5eccc727bbd438()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_3844d7da05d042e29cc3c490df7b5f2d()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_2b663c89cd5148fda1a6c2c729a2ce27()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_0c1a0c364d8046db84d886f9984c240d()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_0f9618c2c95f43eb90baf9c7ba33504d()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_b60daea30f4648d1927690c3d9873d9a()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_07e3506a48734944b5d8e3a1fba30583()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_60847108a6a442c5861ed24814e2c692()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_b30fac8cea6b43e0b3b929c841f187b3()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_1b9a94dec6324a3ea21a99c0c4e015e9()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_55deb38ae84a44b68c83f7fa3aadd8f4()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_f035bc098f9b4724912e5a0d515ceafd()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_0ba8c879d9ab40de884c327ee20a6dcf()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_4b9b2255f77a433e94eaeafc636aab62()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_144354a2a3b749ac95956f78c4ac0604()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_fe091ec216e74b008fdf106ddeb0cf79()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_f99481eb383e439dba8ec676d4885c0b()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_c91af7dfc6a245b289fc078278577336()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_500809e8176f41e596c0a8816369b781()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_3d5a7e586240438ab71e2b58008cd43a()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_0d51e32e5c0b44c7a325448692ebc24e()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_3c06a4072f294bc7b9b1d73599acc4d0()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_d36b68994510450f985f566c46d56a2a()
        }));
        this.AddMember("get_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_7493737ddc984c27bb1ceeb86f9c0e3d()
        }));
        this.AddMember("set_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_d171deeb612944bda3fa9085a22cbb75()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_3ac3e09c807b4136b820c402ffc8bdf2()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_44adc9bc9b704bec94a508e7b6e7c64f()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_d0f53cb01807491eb1d820151716cb75()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_1b8f6f7502eb4df2807b80f155fafeb3()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_3e40a0702fef4e5087ae727ba161143a()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_de0ee19b7b614c6883b2e5d38dbf102d()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_8d97b657293b4d90807210d5896138a1()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_951ea7afdf34426c9941cd1e07792eb3()
        }));
        this.AddMember("get_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_8d840edbf26941c0a33a7ac5a783bdba()
        }));
        this.AddMember("set_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_bd8c3b8eb1ff410ab08574ebf9f45add()
        }));
        this.AddMember("get_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_74f4382639ec4cc2972c99ee07ead72e()
        }));
        this.AddMember("set_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_4d6d12fb7bc34aadbd5b9ee3920eafc3()
        }));
        this.AddMember("get_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_e3a54dd7136d493eb745edc6105d93d0()
        }));
        this.AddMember("set_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_212ece27158b43a5a2121528efbe536c()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_635c758cc41f4f2085ab3154c9f0f282()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_d16b76c951154b25ab72211d6df86861()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_c6cbf438ae164d5cbf4f99169ed882da()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_14fcc32e7da74483ab7e81df1436407e()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_61f10943d8484ca68e4c1f67f819f988()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_1362e2c2b7a9445cae7d6b8f28693056()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_4da84a44fddf4b5a96b907090cc02742()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_2ceee6dcbe204dfea588727924c4106a()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_9b57fb166436486abca82b74e2e95a80()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_5d44979235834920888ea6eb2a028ccf()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_32c930667f934cb98f9751d2a557838a()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_1d6bdbf2a1dd44aa8fe669a7e9950f27()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_1931bd62e72a4212bff388c1d5bf4dfd()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.MTHD_e306855ce9a54a888484023c00a94104()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.PROP_d1c4e40b90d744718421d8c31ffda3d7());
        this.AddMember("visible", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.PROP_dddf1a54280044d9945e3bef2067233a());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.PROP_057abaf06e16418289effc56ae5e5206());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.PROP_11236e6b132e473b90313ef3c0900ba4());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.PROP_6d7a8eac5f0141ad8583ba8c11ac5171());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.PROP_e134878ec33444c294afbe42a862b425());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.PROP_3eaa01ac792348baab697b04cddb7d40());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.PROP_0e8904d7013d46afb1b6da9981200765());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.PROP_e17b73410a3c46baadde0d1e6e5d6ff3());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.PROP_667910b339c34d2ba8c54789f1b1f8b4());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.PROP_2603af320da94eb6b13e7952997b0f3d());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.PROP_6f898747fa484a82be6f5b067da4a47d());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.PROP_c3d7f848ac91466e8bd4868c74ce8c5a());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.PROP_b99205429536449dbe6b4705ea32f7c8());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.PROP_1e704b910cc643b4a327f30ff35c5190());
        this.AddMember("onClick2", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.PROP_7b2405cc06e8477bb71cc9f53e6069b0());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.PROP_327939f2ae774aebbcf2b17471ef99b1());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.PROP_bbbf878bd8cf4920830784c0a795c563());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.PROP_88d1f24134cb4a03868a214def1a669d());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.PROP_2aea6bb1f5af4ab09c2e1da660966381());
        this.AddMember("textColor2", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.PROP_67083686f4ae4ec2b46d14c862b7e4d0());
        this.AddMember("highlightColor", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.PROP_f8a7ddf698ed4255b01718ff293adddd());
        this.AddMember("highlightColor2", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.PROP_cb90ecff83284373bb119afcfff9f60f());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.PROP_98e6c652d6ae4e4ca869a82447e0d227());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.PROP_396645dfe0fc4efa85fcac032740c1fc());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.FLDV_a641d8695264490294e7ad0ce7ee9865());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.FLDV_9b92be026378467d9160d298503f4122());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_ff2dae86364e4f79a1c23f116868c8bd.FLDV_235238dedc084cbba5114334d4d8e211());
      }

      private sealed class MTHD_71fd84c98592401a88d42ae54011e063 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_71fd84c98592401a88d42ae54011e063()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_27524a16cb174f4caabe5b8cbedec941 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_27524a16cb174f4caabe5b8cbedec941()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_5caac70d42de4a6fa6bd01d278c13857 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5caac70d42de4a6fa6bd01d278c13857()
        {
          this.Initialize("get_visible", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).visible;
        }
      }

      private sealed class MTHD_70474e3c65824d008c273eafb0ba8389 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70474e3c65824d008c273eafb0ba8389()
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

      private sealed class MTHD_ebb82f2032a5478c8d25c4f56c041239 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ebb82f2032a5478c8d25c4f56c041239()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_3329f3e4540f4576b5c87d7db91f5d09 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3329f3e4540f4576b5c87d7db91f5d09()
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

      private sealed class MTHD_345bf14d12ce4116817f42d6424a91bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_345bf14d12ce4116817f42d6424a91bc()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_7bc35fa00a2041e9aa5eccc727bbd438 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7bc35fa00a2041e9aa5eccc727bbd438()
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

      private sealed class MTHD_3844d7da05d042e29cc3c490df7b5f2d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3844d7da05d042e29cc3c490df7b5f2d()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_2b663c89cd5148fda1a6c2c729a2ce27 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b663c89cd5148fda1a6c2c729a2ce27()
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

      private sealed class MTHD_0c1a0c364d8046db84d886f9984c240d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c1a0c364d8046db84d886f9984c240d()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_0f9618c2c95f43eb90baf9c7ba33504d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f9618c2c95f43eb90baf9c7ba33504d()
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

      private sealed class MTHD_b60daea30f4648d1927690c3d9873d9a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b60daea30f4648d1927690c3d9873d9a()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_07e3506a48734944b5d8e3a1fba30583 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_07e3506a48734944b5d8e3a1fba30583()
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

      private sealed class MTHD_60847108a6a442c5861ed24814e2c692 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60847108a6a442c5861ed24814e2c692()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_b30fac8cea6b43e0b3b929c841f187b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b30fac8cea6b43e0b3b929c841f187b3()
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

      private sealed class MTHD_1b9a94dec6324a3ea21a99c0c4e015e9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1b9a94dec6324a3ea21a99c0c4e015e9()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_55deb38ae84a44b68c83f7fa3aadd8f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_55deb38ae84a44b68c83f7fa3aadd8f4()
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

      private sealed class MTHD_f035bc098f9b4724912e5a0d515ceafd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f035bc098f9b4724912e5a0d515ceafd()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_0ba8c879d9ab40de884c327ee20a6dcf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ba8c879d9ab40de884c327ee20a6dcf()
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

      private sealed class MTHD_4b9b2255f77a433e94eaeafc636aab62 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b9b2255f77a433e94eaeafc636aab62()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_144354a2a3b749ac95956f78c4ac0604 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_144354a2a3b749ac95956f78c4ac0604()
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

      private sealed class MTHD_fe091ec216e74b008fdf106ddeb0cf79 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fe091ec216e74b008fdf106ddeb0cf79()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_f99481eb383e439dba8ec676d4885c0b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f99481eb383e439dba8ec676d4885c0b()
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

      private sealed class MTHD_c91af7dfc6a245b289fc078278577336 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c91af7dfc6a245b289fc078278577336()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_500809e8176f41e596c0a8816369b781 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_500809e8176f41e596c0a8816369b781()
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

      private sealed class MTHD_3d5a7e586240438ab71e2b58008cd43a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d5a7e586240438ab71e2b58008cd43a()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_0d51e32e5c0b44c7a325448692ebc24e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d51e32e5c0b44c7a325448692ebc24e()
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

      private sealed class MTHD_3c06a4072f294bc7b9b1d73599acc4d0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3c06a4072f294bc7b9b1d73599acc4d0()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_d36b68994510450f985f566c46d56a2a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d36b68994510450f985f566c46d56a2a()
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

      private sealed class MTHD_7493737ddc984c27bb1ceeb86f9c0e3d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7493737ddc984c27bb1ceeb86f9c0e3d()
        {
          this.Initialize("get_onClick2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick2;
        }
      }

      private sealed class MTHD_d171deeb612944bda3fa9085a22cbb75 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d171deeb612944bda3fa9085a22cbb75()
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

      private sealed class MTHD_3ac3e09c807b4136b820c402ffc8bdf2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3ac3e09c807b4136b820c402ffc8bdf2()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_44adc9bc9b704bec94a508e7b6e7c64f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_44adc9bc9b704bec94a508e7b6e7c64f()
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

      private sealed class MTHD_d0f53cb01807491eb1d820151716cb75 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0f53cb01807491eb1d820151716cb75()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color2;
        }
      }

      private sealed class MTHD_1b8f6f7502eb4df2807b80f155fafeb3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1b8f6f7502eb4df2807b80f155fafeb3()
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

      private sealed class MTHD_3e40a0702fef4e5087ae727ba161143a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e40a0702fef4e5087ae727ba161143a()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_de0ee19b7b614c6883b2e5d38dbf102d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de0ee19b7b614c6883b2e5d38dbf102d()
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

      private sealed class MTHD_8d97b657293b4d90807210d5896138a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8d97b657293b4d90807210d5896138a1()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_951ea7afdf34426c9941cd1e07792eb3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_951ea7afdf34426c9941cd1e07792eb3()
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

      private sealed class MTHD_8d840edbf26941c0a33a7ac5a783bdba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8d840edbf26941c0a33a7ac5a783bdba()
        {
          this.Initialize("get_textColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor2;
        }
      }

      private sealed class MTHD_bd8c3b8eb1ff410ab08574ebf9f45add : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd8c3b8eb1ff410ab08574ebf9f45add()
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

      private sealed class MTHD_74f4382639ec4cc2972c99ee07ead72e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74f4382639ec4cc2972c99ee07ead72e()
        {
          this.Initialize("get_highlightColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor;
        }
      }

      private sealed class MTHD_4d6d12fb7bc34aadbd5b9ee3920eafc3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d6d12fb7bc34aadbd5b9ee3920eafc3()
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

      private sealed class MTHD_e3a54dd7136d493eb745edc6105d93d0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e3a54dd7136d493eb745edc6105d93d0()
        {
          this.Initialize("get_highlightColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor2;
        }
      }

      private sealed class MTHD_212ece27158b43a5a2121528efbe536c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_212ece27158b43a5a2121528efbe536c()
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

      private sealed class MTHD_635c758cc41f4f2085ab3154c9f0f282 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_635c758cc41f4f2085ab3154c9f0f282()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_d16b76c951154b25ab72211d6df86861 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d16b76c951154b25ab72211d6df86861()
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

      private sealed class MTHD_c6cbf438ae164d5cbf4f99169ed882da : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c6cbf438ae164d5cbf4f99169ed882da()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_14fcc32e7da74483ab7e81df1436407e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_14fcc32e7da74483ab7e81df1436407e()
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

      private sealed class MTHD_61f10943d8484ca68e4c1f67f819f988 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_61f10943d8484ca68e4c1f67f819f988()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_1362e2c2b7a9445cae7d6b8f28693056 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1362e2c2b7a9445cae7d6b8f28693056()
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

      private sealed class MTHD_4da84a44fddf4b5a96b907090cc02742 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4da84a44fddf4b5a96b907090cc02742()
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

      private sealed class MTHD_2ceee6dcbe204dfea588727924c4106a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2ceee6dcbe204dfea588727924c4106a()
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

      private sealed class MTHD_9b57fb166436486abca82b74e2e95a80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b57fb166436486abca82b74e2e95a80()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_5d44979235834920888ea6eb2a028ccf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d44979235834920888ea6eb2a028ccf()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_32c930667f934cb98f9751d2a557838a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_32c930667f934cb98f9751d2a557838a()
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

      private sealed class MTHD_1d6bdbf2a1dd44aa8fe669a7e9950f27 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d6bdbf2a1dd44aa8fe669a7e9950f27()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_1931bd62e72a4212bff388c1d5bf4dfd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1931bd62e72a4212bff388c1d5bf4dfd()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_e306855ce9a54a888484023c00a94104 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e306855ce9a54a888484023c00a94104()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_d1c4e40b90d744718421d8c31ffda3d7 : HardwiredMemberDescriptor
      {
        internal PROP_d1c4e40b90d744718421d8c31ffda3d7()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_dddf1a54280044d9945e3bef2067233a : HardwiredMemberDescriptor
      {
        internal PROP_dddf1a54280044d9945e3bef2067233a()
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

      private sealed class PROP_057abaf06e16418289effc56ae5e5206 : HardwiredMemberDescriptor
      {
        internal PROP_057abaf06e16418289effc56ae5e5206()
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

      private sealed class PROP_11236e6b132e473b90313ef3c0900ba4 : HardwiredMemberDescriptor
      {
        internal PROP_11236e6b132e473b90313ef3c0900ba4()
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

      private sealed class PROP_6d7a8eac5f0141ad8583ba8c11ac5171 : HardwiredMemberDescriptor
      {
        internal PROP_6d7a8eac5f0141ad8583ba8c11ac5171()
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

      private sealed class PROP_e134878ec33444c294afbe42a862b425 : HardwiredMemberDescriptor
      {
        internal PROP_e134878ec33444c294afbe42a862b425()
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

      private sealed class PROP_3eaa01ac792348baab697b04cddb7d40 : HardwiredMemberDescriptor
      {
        internal PROP_3eaa01ac792348baab697b04cddb7d40()
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

      private sealed class PROP_0e8904d7013d46afb1b6da9981200765 : HardwiredMemberDescriptor
      {
        internal PROP_0e8904d7013d46afb1b6da9981200765()
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

      private sealed class PROP_e17b73410a3c46baadde0d1e6e5d6ff3 : HardwiredMemberDescriptor
      {
        internal PROP_e17b73410a3c46baadde0d1e6e5d6ff3()
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

      private sealed class PROP_667910b339c34d2ba8c54789f1b1f8b4 : HardwiredMemberDescriptor
      {
        internal PROP_667910b339c34d2ba8c54789f1b1f8b4()
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

      private sealed class PROP_2603af320da94eb6b13e7952997b0f3d : HardwiredMemberDescriptor
      {
        internal PROP_2603af320da94eb6b13e7952997b0f3d()
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

      private sealed class PROP_6f898747fa484a82be6f5b067da4a47d : HardwiredMemberDescriptor
      {
        internal PROP_6f898747fa484a82be6f5b067da4a47d()
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

      private sealed class PROP_c3d7f848ac91466e8bd4868c74ce8c5a : HardwiredMemberDescriptor
      {
        internal PROP_c3d7f848ac91466e8bd4868c74ce8c5a()
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

      private sealed class PROP_b99205429536449dbe6b4705ea32f7c8 : HardwiredMemberDescriptor
      {
        internal PROP_b99205429536449dbe6b4705ea32f7c8()
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

      private sealed class PROP_1e704b910cc643b4a327f30ff35c5190 : HardwiredMemberDescriptor
      {
        internal PROP_1e704b910cc643b4a327f30ff35c5190()
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

      private sealed class PROP_7b2405cc06e8477bb71cc9f53e6069b0 : HardwiredMemberDescriptor
      {
        internal PROP_7b2405cc06e8477bb71cc9f53e6069b0()
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

      private sealed class PROP_327939f2ae774aebbcf2b17471ef99b1 : HardwiredMemberDescriptor
      {
        internal PROP_327939f2ae774aebbcf2b17471ef99b1()
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

      private sealed class PROP_bbbf878bd8cf4920830784c0a795c563 : HardwiredMemberDescriptor
      {
        internal PROP_bbbf878bd8cf4920830784c0a795c563()
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

      private sealed class PROP_88d1f24134cb4a03868a214def1a669d : HardwiredMemberDescriptor
      {
        internal PROP_88d1f24134cb4a03868a214def1a669d()
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

      private sealed class PROP_2aea6bb1f5af4ab09c2e1da660966381 : HardwiredMemberDescriptor
      {
        internal PROP_2aea6bb1f5af4ab09c2e1da660966381()
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

      private sealed class PROP_67083686f4ae4ec2b46d14c862b7e4d0 : HardwiredMemberDescriptor
      {
        internal PROP_67083686f4ae4ec2b46d14c862b7e4d0()
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

      private sealed class PROP_f8a7ddf698ed4255b01718ff293adddd : HardwiredMemberDescriptor
      {
        internal PROP_f8a7ddf698ed4255b01718ff293adddd()
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

      private sealed class PROP_cb90ecff83284373bb119afcfff9f60f : HardwiredMemberDescriptor
      {
        internal PROP_cb90ecff83284373bb119afcfff9f60f()
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

      private sealed class PROP_98e6c652d6ae4e4ca869a82447e0d227 : HardwiredMemberDescriptor
      {
        internal PROP_98e6c652d6ae4e4ca869a82447e0d227()
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

      private sealed class PROP_396645dfe0fc4efa85fcac032740c1fc : HardwiredMemberDescriptor
      {
        internal PROP_396645dfe0fc4efa85fcac032740c1fc()
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

      private sealed class FLDV_a641d8695264490294e7ad0ce7ee9865 : HardwiredMemberDescriptor
      {
        internal FLDV_a641d8695264490294e7ad0ce7ee9865()
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

      private sealed class FLDV_9b92be026378467d9160d298503f4122 : HardwiredMemberDescriptor
      {
        internal FLDV_9b92be026378467d9160d298503f4122()
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

      private sealed class FLDV_235238dedc084cbba5114334d4d8e211 : HardwiredMemberDescriptor
      {
        internal FLDV_235238dedc084cbba5114334d4d8e211()
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

    private sealed class TYPE_a21104bf24194de6bb25601673aae5b2 : HardwiredUserDataDescriptor
    {
      internal TYPE_a21104bf24194de6bb25601673aae5b2()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a21104bf24194de6bb25601673aae5b2.MTHD_e55382559d5b46a3a2396c4213930615()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a21104bf24194de6bb25601673aae5b2.MTHD_4cb9658bd27f4a789b367c3ca14badee()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a21104bf24194de6bb25601673aae5b2.MTHD_29d8c046cd5f48559f39f620e447bb70()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a21104bf24194de6bb25601673aae5b2.MTHD_9abcee3d01e14061bc8aec3c314f8a4a()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a21104bf24194de6bb25601673aae5b2.MTHD_77933e006ab84ef3af0b12da0956d9b7()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a21104bf24194de6bb25601673aae5b2.MTHD_354247dd740140d0aac80b4c990db6ad()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_a21104bf24194de6bb25601673aae5b2.FLDV_32d19ab45bb740ee955b1d23cb69756a());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_a21104bf24194de6bb25601673aae5b2.FLDV_cf5f6202159e43dd9224c560316d641f());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_a21104bf24194de6bb25601673aae5b2.FLDV_c69b0a4771ca4095be0137404d1899d6());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_a21104bf24194de6bb25601673aae5b2.FLDV_a11d7084a31e459d8a25ff98eff825f8());
      }

      private sealed class MTHD_e55382559d5b46a3a2396c4213930615 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e55382559d5b46a3a2396c4213930615()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_4cb9658bd27f4a789b367c3ca14badee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4cb9658bd27f4a789b367c3ca14badee()
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

      private sealed class MTHD_29d8c046cd5f48559f39f620e447bb70 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_29d8c046cd5f48559f39f620e447bb70()
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

      private sealed class MTHD_9abcee3d01e14061bc8aec3c314f8a4a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9abcee3d01e14061bc8aec3c314f8a4a()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_77933e006ab84ef3af0b12da0956d9b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_77933e006ab84ef3af0b12da0956d9b7()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_354247dd740140d0aac80b4c990db6ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_354247dd740140d0aac80b4c990db6ad()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_32d19ab45bb740ee955b1d23cb69756a : HardwiredMemberDescriptor
      {
        internal FLDV_32d19ab45bb740ee955b1d23cb69756a()
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

      private sealed class FLDV_cf5f6202159e43dd9224c560316d641f : HardwiredMemberDescriptor
      {
        internal FLDV_cf5f6202159e43dd9224c560316d641f()
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

      private sealed class FLDV_c69b0a4771ca4095be0137404d1899d6 : HardwiredMemberDescriptor
      {
        internal FLDV_c69b0a4771ca4095be0137404d1899d6()
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

      private sealed class FLDV_a11d7084a31e459d8a25ff98eff825f8 : HardwiredMemberDescriptor
      {
        internal FLDV_a11d7084a31e459d8a25ff98eff825f8()
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

    private sealed class TYPE_d994cd3245674f9bb0a4e91929b9abe5 : HardwiredUserDataDescriptor
    {
      internal TYPE_d994cd3245674f9bb0a4e91929b9abe5()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d994cd3245674f9bb0a4e91929b9abe5.MTHD_a3a7b6f77c0641ce9c68500e6faf1abb()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d994cd3245674f9bb0a4e91929b9abe5.MTHD_e93880cba2804be28e6f70a9015e7e4e()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d994cd3245674f9bb0a4e91929b9abe5.MTHD_1e34d4ee6e1c43aeaa5dec5ce659ca54()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d994cd3245674f9bb0a4e91929b9abe5.MTHD_9f5c895d38fb43bdbdc3345a3edc3db1()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d994cd3245674f9bb0a4e91929b9abe5.MTHD_1e08476a33264b65aac6c72ce46f0275()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_d994cd3245674f9bb0a4e91929b9abe5.FLDV_1c9f9649167544f2aa8f2c5041e38247());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_d994cd3245674f9bb0a4e91929b9abe5.FLDV_c3581a5c8a8d479ba3272a5fea7fc08c());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_d994cd3245674f9bb0a4e91929b9abe5.FLDV_3957af49e385464c9b1a440251b1a5a7());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_d994cd3245674f9bb0a4e91929b9abe5.FLDV_f9205d77258d4c17a51e7d5e1f7fdaa1());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_d994cd3245674f9bb0a4e91929b9abe5.FLDV_cf51c7575f904ded8a38410c45eb4090());
      }

      private sealed class MTHD_a3a7b6f77c0641ce9c68500e6faf1abb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a3a7b6f77c0641ce9c68500e6faf1abb()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_e93880cba2804be28e6f70a9015e7e4e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e93880cba2804be28e6f70a9015e7e4e()
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

      private sealed class MTHD_1e34d4ee6e1c43aeaa5dec5ce659ca54 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1e34d4ee6e1c43aeaa5dec5ce659ca54()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_9f5c895d38fb43bdbdc3345a3edc3db1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f5c895d38fb43bdbdc3345a3edc3db1()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_1e08476a33264b65aac6c72ce46f0275 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1e08476a33264b65aac6c72ce46f0275()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_1c9f9649167544f2aa8f2c5041e38247 : HardwiredMemberDescriptor
      {
        internal FLDV_1c9f9649167544f2aa8f2c5041e38247()
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

      private sealed class FLDV_c3581a5c8a8d479ba3272a5fea7fc08c : HardwiredMemberDescriptor
      {
        internal FLDV_c3581a5c8a8d479ba3272a5fea7fc08c()
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

      private sealed class FLDV_3957af49e385464c9b1a440251b1a5a7 : HardwiredMemberDescriptor
      {
        internal FLDV_3957af49e385464c9b1a440251b1a5a7()
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

      private sealed class FLDV_f9205d77258d4c17a51e7d5e1f7fdaa1 : HardwiredMemberDescriptor
      {
        internal FLDV_f9205d77258d4c17a51e7d5e1f7fdaa1()
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

      private sealed class FLDV_cf51c7575f904ded8a38410c45eb4090 : HardwiredMemberDescriptor
      {
        internal FLDV_cf51c7575f904ded8a38410c45eb4090()
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

    private sealed class TYPE_5f88b02bf6b2455cb02ab8fde7a70f46 : HardwiredUserDataDescriptor
    {
      internal TYPE_5f88b02bf6b2455cb02ab8fde7a70f46()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f88b02bf6b2455cb02ab8fde7a70f46.MTHD_7dc4611bb5374000bfc60b8296ce4a7c()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f88b02bf6b2455cb02ab8fde7a70f46.MTHD_10e70ae876204a2996533d2aeb4f68a7()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f88b02bf6b2455cb02ab8fde7a70f46.MTHD_51f41b41182e404a911fba84d6300f7d()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f88b02bf6b2455cb02ab8fde7a70f46.MTHD_93bd706fbeb541d88928b239ee0a8b8b()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f88b02bf6b2455cb02ab8fde7a70f46.MTHD_d7f9cb99ee5545099722d452eed11d7d()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f88b02bf6b2455cb02ab8fde7a70f46.MTHD_3d87268186704fce97a432a036a088f7()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f88b02bf6b2455cb02ab8fde7a70f46.MTHD_73edc71ac3144e95a43caf6ad4d1be2c()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f88b02bf6b2455cb02ab8fde7a70f46.MTHD_39dda0ca53814197966548947089027d()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f88b02bf6b2455cb02ab8fde7a70f46.MTHD_cfb71a9db8bd4857a363d432486407ed()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f88b02bf6b2455cb02ab8fde7a70f46.MTHD_5d0f36e487a74d23b763bd5bb72068cd()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f88b02bf6b2455cb02ab8fde7a70f46.MTHD_3bde6cb136d647869e108d8035821270()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f88b02bf6b2455cb02ab8fde7a70f46.MTHD_847aab4cd59c4345b9f25d2ff9a14806()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f88b02bf6b2455cb02ab8fde7a70f46.MTHD_fd1ab816ac454ce7a7d323eb6606243d()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_5f88b02bf6b2455cb02ab8fde7a70f46.FLDV_bafe5a03efc8416f98bace4a24bb3975());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_5f88b02bf6b2455cb02ab8fde7a70f46.FLDV_ff9be8fdd8674784bfc713cc2ea6d173());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_5f88b02bf6b2455cb02ab8fde7a70f46.FLDV_c8ba4af00f4a42cfaecb361031d605df());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_5f88b02bf6b2455cb02ab8fde7a70f46.FLDV_5a90c877440c4fa4b1de5d48f8348fe9());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_5f88b02bf6b2455cb02ab8fde7a70f46.FLDV_5f38e8906dcf4134a49604ad7c7dcf4c());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_5f88b02bf6b2455cb02ab8fde7a70f46.FLDV_ab94c792203b4b7abf0a4ba23afdfbb4());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_5f88b02bf6b2455cb02ab8fde7a70f46.FLDV_b2c6f9bcdde54105ac429ccf013f7e20());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_5f88b02bf6b2455cb02ab8fde7a70f46.FLDV_5cc40304e7a2439c9569ea1b226b91bc());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_5f88b02bf6b2455cb02ab8fde7a70f46.DVAL_2110bcb9dda14f0394a5ae099d9e6abc());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_5f88b02bf6b2455cb02ab8fde7a70f46.DVAL_20236d6d94e64cb382c03e54fb1c791b());
      }

      private sealed class MTHD_7dc4611bb5374000bfc60b8296ce4a7c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7dc4611bb5374000bfc60b8296ce4a7c()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_10e70ae876204a2996533d2aeb4f68a7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_10e70ae876204a2996533d2aeb4f68a7()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_51f41b41182e404a911fba84d6300f7d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_51f41b41182e404a911fba84d6300f7d()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_93bd706fbeb541d88928b239ee0a8b8b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93bd706fbeb541d88928b239ee0a8b8b()
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

      private sealed class MTHD_d7f9cb99ee5545099722d452eed11d7d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d7f9cb99ee5545099722d452eed11d7d()
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

      private sealed class MTHD_3d87268186704fce97a432a036a088f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d87268186704fce97a432a036a088f7()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_73edc71ac3144e95a43caf6ad4d1be2c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_73edc71ac3144e95a43caf6ad4d1be2c()
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

      private sealed class MTHD_39dda0ca53814197966548947089027d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_39dda0ca53814197966548947089027d()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_cfb71a9db8bd4857a363d432486407ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cfb71a9db8bd4857a363d432486407ed()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_5d0f36e487a74d23b763bd5bb72068cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d0f36e487a74d23b763bd5bb72068cd()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_3bde6cb136d647869e108d8035821270 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3bde6cb136d647869e108d8035821270()
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

      private sealed class MTHD_847aab4cd59c4345b9f25d2ff9a14806 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_847aab4cd59c4345b9f25d2ff9a14806()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_fd1ab816ac454ce7a7d323eb6606243d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd1ab816ac454ce7a7d323eb6606243d()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_bafe5a03efc8416f98bace4a24bb3975 : HardwiredMemberDescriptor
      {
        internal FLDV_bafe5a03efc8416f98bace4a24bb3975()
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

      private sealed class FLDV_ff9be8fdd8674784bfc713cc2ea6d173 : HardwiredMemberDescriptor
      {
        internal FLDV_ff9be8fdd8674784bfc713cc2ea6d173()
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

      private sealed class FLDV_c8ba4af00f4a42cfaecb361031d605df : HardwiredMemberDescriptor
      {
        internal FLDV_c8ba4af00f4a42cfaecb361031d605df()
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

      private sealed class FLDV_5a90c877440c4fa4b1de5d48f8348fe9 : HardwiredMemberDescriptor
      {
        internal FLDV_5a90c877440c4fa4b1de5d48f8348fe9()
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

      private sealed class FLDV_5f38e8906dcf4134a49604ad7c7dcf4c : HardwiredMemberDescriptor
      {
        internal FLDV_5f38e8906dcf4134a49604ad7c7dcf4c()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_ab94c792203b4b7abf0a4ba23afdfbb4 : HardwiredMemberDescriptor
      {
        internal FLDV_ab94c792203b4b7abf0a4ba23afdfbb4()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_b2c6f9bcdde54105ac429ccf013f7e20 : HardwiredMemberDescriptor
      {
        internal FLDV_b2c6f9bcdde54105ac429ccf013f7e20()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_5cc40304e7a2439c9569ea1b226b91bc : HardwiredMemberDescriptor
      {
        internal FLDV_5cc40304e7a2439c9569ea1b226b91bc()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_2110bcb9dda14f0394a5ae099d9e6abc : DynValueMemberDescriptor
      {
        internal DVAL_2110bcb9dda14f0394a5ae099d9e6abc()
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

      private sealed class DVAL_20236d6d94e64cb382c03e54fb1c791b : DynValueMemberDescriptor
      {
        internal DVAL_20236d6d94e64cb382c03e54fb1c791b()
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

    private sealed class TYPE_4f1399411d1e4310a005037c73ebc6ec : HardwiredUserDataDescriptor
    {
      internal TYPE_4f1399411d1e4310a005037c73ebc6ec()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4f1399411d1e4310a005037c73ebc6ec.MTHD_f167be2fd45e41a7a589f776d27b6b2d()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4f1399411d1e4310a005037c73ebc6ec.MTHD_90aac00ccc264552aafdf3b25053bc64()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4f1399411d1e4310a005037c73ebc6ec.MTHD_8df220b1b4b04e44a675a28a7c2b231b(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4f1399411d1e4310a005037c73ebc6ec.MTHD_39b360ba7b5440e681be20bd8a055d8e()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4f1399411d1e4310a005037c73ebc6ec.MTHD_52060235360b4ddb801386d58e6cafd9(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4f1399411d1e4310a005037c73ebc6ec.MTHD_d05d4558979d42ee9c3539e2e05c285b()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4f1399411d1e4310a005037c73ebc6ec.MTHD_57a5488379c34a189c92d1361790dedf()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4f1399411d1e4310a005037c73ebc6ec.MTHD_46016111bd10404b81fc28fd9321a3a1()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4f1399411d1e4310a005037c73ebc6ec.MTHD_6689a42eaaab4d0d9d59cd6d62812361()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4f1399411d1e4310a005037c73ebc6ec.MTHD_f1ee71642dea4f10ae743e7181a83b2f()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_4f1399411d1e4310a005037c73ebc6ec.FLDV_90975208107f4ee48f889a6df2f683c8());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_4f1399411d1e4310a005037c73ebc6ec.FLDV_ac8f09dd2bd545129f451af4c36ed31c());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_4f1399411d1e4310a005037c73ebc6ec.FLDV_05f421f1dc914874857cf41a68a51a18());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_4f1399411d1e4310a005037c73ebc6ec.FLDV_1fcdc08248754b2a86936bb42bd2afdf());
        this.AddMember("white", (IMemberDescriptor) new Bridge.TYPE_4f1399411d1e4310a005037c73ebc6ec.FLDV_729765fa728d456cbfb649bdf68e78d6());
      }

      private sealed class MTHD_f167be2fd45e41a7a589f776d27b6b2d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f167be2fd45e41a7a589f776d27b6b2d()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_90aac00ccc264552aafdf3b25053bc64 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90aac00ccc264552aafdf3b25053bc64()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_8df220b1b4b04e44a675a28a7c2b231b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8df220b1b4b04e44a675a28a7c2b231b()
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

      private sealed class MTHD_39b360ba7b5440e681be20bd8a055d8e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_39b360ba7b5440e681be20bd8a055d8e()
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

      private sealed class MTHD_52060235360b4ddb801386d58e6cafd9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52060235360b4ddb801386d58e6cafd9()
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

      private sealed class MTHD_d05d4558979d42ee9c3539e2e05c285b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d05d4558979d42ee9c3539e2e05c285b()
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

      private sealed class MTHD_57a5488379c34a189c92d1361790dedf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57a5488379c34a189c92d1361790dedf()
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

      private sealed class MTHD_46016111bd10404b81fc28fd9321a3a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_46016111bd10404b81fc28fd9321a3a1()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_6689a42eaaab4d0d9d59cd6d62812361 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6689a42eaaab4d0d9d59cd6d62812361()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_f1ee71642dea4f10ae743e7181a83b2f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f1ee71642dea4f10ae743e7181a83b2f()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_90975208107f4ee48f889a6df2f683c8 : HardwiredMemberDescriptor
      {
        internal FLDV_90975208107f4ee48f889a6df2f683c8()
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

      private sealed class FLDV_ac8f09dd2bd545129f451af4c36ed31c : HardwiredMemberDescriptor
      {
        internal FLDV_ac8f09dd2bd545129f451af4c36ed31c()
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

      private sealed class FLDV_05f421f1dc914874857cf41a68a51a18 : HardwiredMemberDescriptor
      {
        internal FLDV_05f421f1dc914874857cf41a68a51a18()
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

      private sealed class FLDV_1fcdc08248754b2a86936bb42bd2afdf : HardwiredMemberDescriptor
      {
        internal FLDV_1fcdc08248754b2a86936bb42bd2afdf()
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

      private sealed class FLDV_729765fa728d456cbfb649bdf68e78d6 : HardwiredMemberDescriptor
      {
        internal FLDV_729765fa728d456cbfb649bdf68e78d6()
          : base(typeof (LuaColor), "white", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) LuaColor.white;
        }
      }
    }

    private sealed class TYPE_53e46213d47840cd9ae9914c352bfb3d : HardwiredUserDataDescriptor
    {
      internal TYPE_53e46213d47840cd9ae9914c352bfb3d()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53e46213d47840cd9ae9914c352bfb3d.MTHD_c6c6096a68c84e719ff50f0ce3ff6086()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53e46213d47840cd9ae9914c352bfb3d.MTHD_bd4ff85ef9b54d4baabe6a37e9ac9cc2()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53e46213d47840cd9ae9914c352bfb3d.MTHD_2dc0bf2e68db4931892acf34ba04a47a()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53e46213d47840cd9ae9914c352bfb3d.MTHD_aec8f36cfa024418afcb140af4880b2c()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53e46213d47840cd9ae9914c352bfb3d.MTHD_f3e2e79729d047819230e09ae43accc0()
        }));
      }

      private sealed class MTHD_c6c6096a68c84e719ff50f0ce3ff6086 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c6c6096a68c84e719ff50f0ce3ff6086()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_bd4ff85ef9b54d4baabe6a37e9ac9cc2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd4ff85ef9b54d4baabe6a37e9ac9cc2()
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

      private sealed class MTHD_2dc0bf2e68db4931892acf34ba04a47a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2dc0bf2e68db4931892acf34ba04a47a()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_aec8f36cfa024418afcb140af4880b2c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aec8f36cfa024418afcb140af4880b2c()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_f3e2e79729d047819230e09ae43accc0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f3e2e79729d047819230e09ae43accc0()
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
