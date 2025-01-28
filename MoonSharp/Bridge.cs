
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
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_bdc5fdbb6e0e4bcd8a54559c0afc8c45());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_d2b7746bdfbc4b418a4e4ae1a612ad1f());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_5c98f708dc2b4607a8727ae29331a5eb());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_ce3d5c3dc58448b5a6ba76d0d8a6950a());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_350dbeafb22d4e5bb4a4ae729e52cd5e());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_f2298fa4856b46ef8016db69d485523b());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_5c557aaeed9f4494a9dccd381abec297());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_a82b1667ab364121a9680d24f51e358a());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_f707a9f9b17c42a1a5b70f2692fd47ed());
    }

    private sealed class TYPE_71430219166541cca2fb224aab0aac67 : HardwiredUserDataDescriptor
    {
      internal TYPE_71430219166541cca2fb224aab0aac67()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_d97a11b2381a482aadc8ba07ae61e30a()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_ff68d6559a1c466a80e4d109b67a4cbc()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_0113d8664f6941ae8612e40b07cee845()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_6fb2b9eb24a54e31b65c10da7886aca6()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_dde629bed43740feb48761c2497181da()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_d11a627de0704a3bb7f3b4e726459aea()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_0e505b13d8324071a818b4d39ea4c102()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_a2c29f00bc31418191386484fb0bf07d()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_d0398111b40b4d98be54b390b64d1618()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_40e38fe35d6d478785d9409556155cd5()
        }));
        this.AddMember("hideInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("hideInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_86df0df52bab4599b69c22547a195d11()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_6b1687f886cf434982470492aca79546()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_861e10930acf4750a864416233151e9d()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_37cc2cc6e3134115b8bd2f8758449da5()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_dddacbe5370d46e188265b87aa3d7a31()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_7ef430344deb4dafa99935d38db0259c()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_91f5aec6aa3f4fe3bfcdb5073b3ae2cb()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_e4e22436bd8c4d66a99f09abaaf2cdbe()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_036ade5821eb4637895c6d70658c9ee7()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_41353829be524634a74f54b4c6b8ef39()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_a6b67666e6e24f64bb7774c53876a522()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_527ad5d318c444d295b5645afe8e9562()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_8f4ed6d82494474baaf7816e8b330f7a()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_19b6205343da4b9ab6887f8193992e70()
        }));
        this.AddMember("get_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_35e9c97edc7644bcad73bcfe4f21bed5()
        }));
        this.AddMember("set_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_94159d5e926748a9b657527c6a3a80e9()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_bba147841b2446b79099fe9b63e39f1c()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_910450c86e94495e8fac40c1a4cd2a69()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_ef4c3a3a3efa4d4a890b3df69cbfe01f()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_f22dc98391994dfba0e2325b6d84dd05()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_e00a8f0bf2234b1fabdfec457300f87b()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_febaf1c461004094b3bda39d50c4c3b4()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_2472b03bd30d467a8d89c67abf54b95c()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_40c80c97b7af402aab529dba246aa73b()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_6fe37588f4fa47119430edd49055f4c0()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_ffa22a9f39394f778d055fe6dcb92e0d()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_454d296938c0429ebb14b4e8a3d51126()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_449fdf84ed7f458192b1aa64c1aa1b8b()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_191d1f201bcd4f7bb1445e79e12921f9()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_6660df846ec447a0987b22aa5189fae6()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_2e09a3924ec24214ad1a89792e310184()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_4f0cf5f66d79425e985e0e4531f62ca3()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_b93a1fb4a86642cdb3e446a507a314f2()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_d88bbfd18d3541dbbb170b9368bf853a()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_b1fe7bd8bee247bf82fa33843b650904()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_b654ea2e78db48a9934d738f8e284ef5()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_ab830a51273e4bb995a14b38b60c2c24()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_1f548aef785f41bd9a55f4984e3e288c()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_e090c0d2563b4c5699ee93138b7831f7()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_f0cdc727b3e04e0aaff933c8c6834d54()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_94ad7323eae745f689212d1a368e7ef7()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_410e056840c44d94adbd57cd772c8d85()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_6a4261875e9d40c086c7cc105b815e17()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_df4bb973fcde467ebf806dfdfa98231a()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_478a3493eee246e5aa4bc53658703506()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_c90a336fe7314f98ae58b91756c2e5d8()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_fd7f935a2cde4514b9b79adc3a834252()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_9fc1a9a8714e474cb9174d9fa26bf710()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_2c1f18acd3084e7ab14be1cef9a89aac()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_ad20ccf6550e4ecd95ddca28d3bcac82()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_2f331fc285074d748fdd2b9d06a221f3()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_ebb0140f26974b56afb75ec596f9d177()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_d2358e8f9fca44729b6a0e59eebaeee9()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_b8a4f8db7f3a47f3b5e91b2e874be68f()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_5ec01e4971d44b988dcce11413d33ed2()
        }));
        this.AddMember("Dispose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Dispose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_46da8cf13c2d4a3c9122f1a1f5865eb1()
        }));
        this.AddMember("drawImage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawImage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_719a31acf24a4d668c51bb77cbadcc74()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_19ed0c75a81b4fd68bd64aac58e0cf75()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_940aea8fa9e94800864dc42964c173fe()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_071aa00c87724bfd939916f9c1426b0a()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_0c55aa51190a460baad4bafcf4370e4e()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_a4e72aafa48949a0bee773bda83eca88()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_9a3771e515ad4267960edb1ab8a7ed11()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_5b4fbda1547945b8aa030068b6ad5c1e()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_c82868ff6f7f43779e6aecadc814906d()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_4c3aad7bc724479f9cd7dab0fc99589c()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_45d83a0d656e4692b7bd1ffcb302d7ba()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_d2ebb41b94494ee4bc59dad8bc23d27a()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_97f4d569038645da920a61ef4c970f99()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_94ff0e85bbc240fe9c75acd8741efe82()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_793d0d1708c64ff7a84c07337659d961()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_4c3a4fbcb91244d3ac4a993f89053524()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_5d94845190d54f239b44768fb0d293b6()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_464216a0ffd94d5bb426aef8b72ee4b2()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_f1df2f023b3a4abea5269ee951166876()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_e288a578a3d641689af1e0567aca1736()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_324f910fa8b44e9f85e5ed7aa91bdc39()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_8dead3adceae432b9cf9dbb7f2e71717()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_67b154b7b2684ad5aa640a36810db4e7()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_93f2a1930cd34a00a464fe60442ba07f()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_bc04006b48744fa29bda65a52c8144f3()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_05714ec704d64914a643f4d929fb1b6a()
        }));
        this.AddMember("cameraFollow", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("cameraFollow", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_9105eb0a5f90429497fb8b138658cf81()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_ac5ffbe1f8f54dcd9a48132496bd5040()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_a653d9a449c04fe0a782087ba350e8cc()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_38b204cc01724e008753cc73ca211c1b()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_ec2bc7feb704496cb8dcb21b826af2fa()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_9e8f304dc892412c8213add7fa7a3c47()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_864dfa44344a4ddbb7ab06e6540af668(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_ad763d3dd368400790ebdb71f9197044()
        }));
        this.AddMember("getKeyBinds", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getKeyBinds", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_59af30e898c846568c3c42186743c246()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_e1201172dccd47c9811c54124b97ddfb()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_bd165e3814b0436eadd8f4d7e49d7a81()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_91ee3b41560a4b3788592aa271749ed9()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.MTHD_e41ad79c876b4fd493e7acb94717f953()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_8a0e7965a17f49b2b374e53eede88000());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_761df42b4a91459d9a51933d23b844d6());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_34a6d50b0eb44e84bcfd496204a0e4c0());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_bdf431d2bf624df89f045ded79569274());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_5a24d4e6afee4411a6dc74954d55bfea());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_ad56de097d604a2f93adaf2a7f55dc25());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_506695a5e1ab4abab5a4e1a6139ceef5());
        this.AddMember("allowMinionMovement", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_c2b6649b87f64928906972c240f8546c());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_6ad8d60087864a8faa4415dddda490b1());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_079a976ab8a2465dbc9e4f8e3d3b97df());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_7f53836b699e43d1bb3fc285e38bc14d());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_3196519efd744e48bc9dd2b4855983af());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_74646b089e4d44c291570b60d26da5ed());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_fa7df608cad4401fa2891c3131fdce9c());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_d0b6571376c94dd4955625fb6e1505fe());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_e90d359807f244a18c25bd017cf6ed83());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_041012db18e944dfa48b8edae510c769());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_50cd4723bb7c4edd80f9c9bc9dca3149());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_b3dbd487f2004e17851a8e47f0e1283f());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_2b3435932b0040b4899196d65ad861ae());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_2a1e79e859174995909e699f255b1ecd());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_7116d815bdc8480680818cd29eb3ce74());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_1e16c6bf6903472b92af171a89fe6aca());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_0e435c8b0f03490d9a903ff03b8e9609());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_95ba4b8b9cf64297b2a5b0ef124be168());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_65af7e5946ab496d8eec700baf432333());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_22adca46a7a24b13b22792cf63d8ea93());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_781225856c114a4989bd08f4e6bb1dab());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_6d5f69e9a5084ae2856866f841c009d1());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_5c61f66e0d344f48815c7c7d12898987());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_365c5a2e2de64b2f94d4bb9cfb91e7b2());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_78090cc2bc734e48949d497bcac7d05c());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_71430219166541cca2fb224aab0aac67.PROP_f070f7f855a540938ac7b3423b02c8af());
      }

      private sealed class MTHD_d97a11b2381a482aadc8ba07ae61e30a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d97a11b2381a482aadc8ba07ae61e30a()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_ff68d6559a1c466a80e4d109b67a4cbc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff68d6559a1c466a80e4d109b67a4cbc()
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

      private sealed class MTHD_0113d8664f6941ae8612e40b07cee845 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0113d8664f6941ae8612e40b07cee845()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_6fb2b9eb24a54e31b65c10da7886aca6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6fb2b9eb24a54e31b65c10da7886aca6()
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

      private sealed class MTHD_dde629bed43740feb48761c2497181da : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dde629bed43740feb48761c2497181da()
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

      private sealed class MTHD_d11a627de0704a3bb7f3b4e726459aea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d11a627de0704a3bb7f3b4e726459aea()
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

      private sealed class MTHD_0e505b13d8324071a818b4d39ea4c102 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e505b13d8324071a818b4d39ea4c102()
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

      private sealed class MTHD_a2c29f00bc31418191386484fb0bf07d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2c29f00bc31418191386484fb0bf07d()
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

      private sealed class MTHD_d0398111b40b4d98be54b390b64d1618 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0398111b40b4d98be54b390b64d1618()
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

      private sealed class MTHD_40e38fe35d6d478785d9409556155cd5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_40e38fe35d6d478785d9409556155cd5()
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

      private sealed class MTHD_86df0df52bab4599b69c22547a195d11 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_86df0df52bab4599b69c22547a195d11()
        {
          this.Initialize("hideInfo", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).hideInfo();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_6b1687f886cf434982470492aca79546 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b1687f886cf434982470492aca79546()
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

      private sealed class MTHD_861e10930acf4750a864416233151e9d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_861e10930acf4750a864416233151e9d()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_37cc2cc6e3134115b8bd2f8758449da5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_37cc2cc6e3134115b8bd2f8758449da5()
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

      private sealed class MTHD_dddacbe5370d46e188265b87aa3d7a31 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dddacbe5370d46e188265b87aa3d7a31()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_7ef430344deb4dafa99935d38db0259c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ef430344deb4dafa99935d38db0259c()
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

      private sealed class MTHD_91f5aec6aa3f4fe3bfcdb5073b3ae2cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_91f5aec6aa3f4fe3bfcdb5073b3ae2cb()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_e4e22436bd8c4d66a99f09abaaf2cdbe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e4e22436bd8c4d66a99f09abaaf2cdbe()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_036ade5821eb4637895c6d70658c9ee7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_036ade5821eb4637895c6d70658c9ee7()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_41353829be524634a74f54b4c6b8ef39 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41353829be524634a74f54b4c6b8ef39()
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

      private sealed class MTHD_a6b67666e6e24f64bb7774c53876a522 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6b67666e6e24f64bb7774c53876a522()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_527ad5d318c444d295b5645afe8e9562 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_527ad5d318c444d295b5645afe8e9562()
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

      private sealed class MTHD_8f4ed6d82494474baaf7816e8b330f7a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8f4ed6d82494474baaf7816e8b330f7a()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_19b6205343da4b9ab6887f8193992e70 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_19b6205343da4b9ab6887f8193992e70()
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

      private sealed class MTHD_35e9c97edc7644bcad73bcfe4f21bed5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35e9c97edc7644bcad73bcfe4f21bed5()
        {
          this.Initialize("get_allowMinionMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMinionMovement;
        }
      }

      private sealed class MTHD_94159d5e926748a9b657527c6a3a80e9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_94159d5e926748a9b657527c6a3a80e9()
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

      private sealed class MTHD_bba147841b2446b79099fe9b63e39f1c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bba147841b2446b79099fe9b63e39f1c()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_910450c86e94495e8fac40c1a4cd2a69 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_910450c86e94495e8fac40c1a4cd2a69()
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

      private sealed class MTHD_ef4c3a3a3efa4d4a890b3df69cbfe01f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef4c3a3a3efa4d4a890b3df69cbfe01f()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_f22dc98391994dfba0e2325b6d84dd05 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f22dc98391994dfba0e2325b6d84dd05()
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

      private sealed class MTHD_e00a8f0bf2234b1fabdfec457300f87b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e00a8f0bf2234b1fabdfec457300f87b()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_febaf1c461004094b3bda39d50c4c3b4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_febaf1c461004094b3bda39d50c4c3b4()
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

      private sealed class MTHD_2472b03bd30d467a8d89c67abf54b95c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2472b03bd30d467a8d89c67abf54b95c()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_40c80c97b7af402aab529dba246aa73b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_40c80c97b7af402aab529dba246aa73b()
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

      private sealed class MTHD_6fe37588f4fa47119430edd49055f4c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6fe37588f4fa47119430edd49055f4c0()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_ffa22a9f39394f778d055fe6dcb92e0d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ffa22a9f39394f778d055fe6dcb92e0d()
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

      private sealed class MTHD_454d296938c0429ebb14b4e8a3d51126 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_454d296938c0429ebb14b4e8a3d51126()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_449fdf84ed7f458192b1aa64c1aa1b8b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_449fdf84ed7f458192b1aa64c1aa1b8b()
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

      private sealed class MTHD_191d1f201bcd4f7bb1445e79e12921f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_191d1f201bcd4f7bb1445e79e12921f9()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_6660df846ec447a0987b22aa5189fae6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6660df846ec447a0987b22aa5189fae6()
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

      private sealed class MTHD_2e09a3924ec24214ad1a89792e310184 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2e09a3924ec24214ad1a89792e310184()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_4f0cf5f66d79425e985e0e4531f62ca3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4f0cf5f66d79425e985e0e4531f62ca3()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_b93a1fb4a86642cdb3e446a507a314f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b93a1fb4a86642cdb3e446a507a314f2()
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

      private sealed class MTHD_d88bbfd18d3541dbbb170b9368bf853a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d88bbfd18d3541dbbb170b9368bf853a()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_b1fe7bd8bee247bf82fa33843b650904 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b1fe7bd8bee247bf82fa33843b650904()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_b654ea2e78db48a9934d738f8e284ef5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b654ea2e78db48a9934d738f8e284ef5()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_ab830a51273e4bb995a14b38b60c2c24 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab830a51273e4bb995a14b38b60c2c24()
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

      private sealed class MTHD_1f548aef785f41bd9a55f4984e3e288c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f548aef785f41bd9a55f4984e3e288c()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_e090c0d2563b4c5699ee93138b7831f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e090c0d2563b4c5699ee93138b7831f7()
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

      private sealed class MTHD_f0cdc727b3e04e0aaff933c8c6834d54 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f0cdc727b3e04e0aaff933c8c6834d54()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_94ad7323eae745f689212d1a368e7ef7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_94ad7323eae745f689212d1a368e7ef7()
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

      private sealed class MTHD_410e056840c44d94adbd57cd772c8d85 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_410e056840c44d94adbd57cd772c8d85()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_6a4261875e9d40c086c7cc105b815e17 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6a4261875e9d40c086c7cc105b815e17()
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

      private sealed class MTHD_df4bb973fcde467ebf806dfdfa98231a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_df4bb973fcde467ebf806dfdfa98231a()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_478a3493eee246e5aa4bc53658703506 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_478a3493eee246e5aa4bc53658703506()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_c90a336fe7314f98ae58b91756c2e5d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c90a336fe7314f98ae58b91756c2e5d8()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_fd7f935a2cde4514b9b79adc3a834252 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd7f935a2cde4514b9b79adc3a834252()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_9fc1a9a8714e474cb9174d9fa26bf710 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9fc1a9a8714e474cb9174d9fa26bf710()
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

      private sealed class MTHD_2c1f18acd3084e7ab14be1cef9a89aac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c1f18acd3084e7ab14be1cef9a89aac()
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

      private sealed class MTHD_ad20ccf6550e4ecd95ddca28d3bcac82 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ad20ccf6550e4ecd95ddca28d3bcac82()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_2f331fc285074d748fdd2b9d06a221f3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2f331fc285074d748fdd2b9d06a221f3()
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

      private sealed class MTHD_ebb0140f26974b56afb75ec596f9d177 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ebb0140f26974b56afb75ec596f9d177()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_d2358e8f9fca44729b6a0e59eebaeee9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d2358e8f9fca44729b6a0e59eebaeee9()
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

      private sealed class MTHD_b8a4f8db7f3a47f3b5e91b2e874be68f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b8a4f8db7f3a47f3b5e91b2e874be68f()
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

      private sealed class MTHD_5ec01e4971d44b988dcce11413d33ed2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ec01e4971d44b988dcce11413d33ed2()
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

      private sealed class MTHD_46da8cf13c2d4a3c9122f1a1f5865eb1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_46da8cf13c2d4a3c9122f1a1f5865eb1()
        {
          this.Initialize("Dispose", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ContainerGame.Dispose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_719a31acf24a4d668c51bb77cbadcc74 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_719a31acf24a4d668c51bb77cbadcc74()
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

      private sealed class MTHD_19ed0c75a81b4fd68bd64aac58e0cf75 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_19ed0c75a81b4fd68bd64aac58e0cf75()
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

      private sealed class MTHD_940aea8fa9e94800864dc42964c173fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_940aea8fa9e94800864dc42964c173fe()
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

      private sealed class MTHD_071aa00c87724bfd939916f9c1426b0a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_071aa00c87724bfd939916f9c1426b0a()
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

      private sealed class MTHD_0c55aa51190a460baad4bafcf4370e4e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c55aa51190a460baad4bafcf4370e4e()
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

      private sealed class MTHD_a4e72aafa48949a0bee773bda83eca88 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a4e72aafa48949a0bee773bda83eca88()
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

      private sealed class MTHD_9a3771e515ad4267960edb1ab8a7ed11 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9a3771e515ad4267960edb1ab8a7ed11()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_5b4fbda1547945b8aa030068b6ad5c1e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b4fbda1547945b8aa030068b6ad5c1e()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_c82868ff6f7f43779e6aecadc814906d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c82868ff6f7f43779e6aecadc814906d()
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

      private sealed class MTHD_4c3aad7bc724479f9cd7dab0fc99589c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c3aad7bc724479f9cd7dab0fc99589c()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_45d83a0d656e4692b7bd1ffcb302d7ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_45d83a0d656e4692b7bd1ffcb302d7ba()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_d2ebb41b94494ee4bc59dad8bc23d27a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d2ebb41b94494ee4bc59dad8bc23d27a()
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

      private sealed class MTHD_97f4d569038645da920a61ef4c970f99 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97f4d569038645da920a61ef4c970f99()
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

      private sealed class MTHD_94ff0e85bbc240fe9c75acd8741efe82 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_94ff0e85bbc240fe9c75acd8741efe82()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_793d0d1708c64ff7a84c07337659d961 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_793d0d1708c64ff7a84c07337659d961()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_4c3a4fbcb91244d3ac4a993f89053524 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c3a4fbcb91244d3ac4a993f89053524()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_5d94845190d54f239b44768fb0d293b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d94845190d54f239b44768fb0d293b6()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_464216a0ffd94d5bb426aef8b72ee4b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_464216a0ffd94d5bb426aef8b72ee4b2()
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

      private sealed class MTHD_f1df2f023b3a4abea5269ee951166876 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f1df2f023b3a4abea5269ee951166876()
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

      private sealed class MTHD_e288a578a3d641689af1e0567aca1736 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e288a578a3d641689af1e0567aca1736()
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

      private sealed class MTHD_324f910fa8b44e9f85e5ed7aa91bdc39 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_324f910fa8b44e9f85e5ed7aa91bdc39()
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

      private sealed class MTHD_8dead3adceae432b9cf9dbb7f2e71717 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8dead3adceae432b9cf9dbb7f2e71717()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_67b154b7b2684ad5aa640a36810db4e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67b154b7b2684ad5aa640a36810db4e7()
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

      private sealed class MTHD_93f2a1930cd34a00a464fe60442ba07f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93f2a1930cd34a00a464fe60442ba07f()
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

      private sealed class MTHD_bc04006b48744fa29bda65a52c8144f3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bc04006b48744fa29bda65a52c8144f3()
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

      private sealed class MTHD_05714ec704d64914a643f4d929fb1b6a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_05714ec704d64914a643f4d929fb1b6a()
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

      private sealed class MTHD_9105eb0a5f90429497fb8b138658cf81 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9105eb0a5f90429497fb8b138658cf81()
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

      private sealed class MTHD_ac5ffbe1f8f54dcd9a48132496bd5040 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac5ffbe1f8f54dcd9a48132496bd5040()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_a653d9a449c04fe0a782087ba350e8cc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a653d9a449c04fe0a782087ba350e8cc()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_38b204cc01724e008753cc73ca211c1b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_38b204cc01724e008753cc73ca211c1b()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_ec2bc7feb704496cb8dcb21b826af2fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec2bc7feb704496cb8dcb21b826af2fa()
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

      private sealed class MTHD_9e8f304dc892412c8213add7fa7a3c47 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e8f304dc892412c8213add7fa7a3c47()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_864dfa44344a4ddbb7ab06e6540af668 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_864dfa44344a4ddbb7ab06e6540af668()
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

      private sealed class MTHD_ad763d3dd368400790ebdb71f9197044 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ad763d3dd368400790ebdb71f9197044()
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

      private sealed class MTHD_59af30e898c846568c3c42186743c246 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_59af30e898c846568c3c42186743c246()
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

      private sealed class MTHD_e1201172dccd47c9811c54124b97ddfb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e1201172dccd47c9811c54124b97ddfb()
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

      private sealed class MTHD_bd165e3814b0436eadd8f4d7e49d7a81 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd165e3814b0436eadd8f4d7e49d7a81()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_91ee3b41560a4b3788592aa271749ed9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_91ee3b41560a4b3788592aa271749ed9()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_e41ad79c876b4fd493e7acb94717f953 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e41ad79c876b4fd493e7acb94717f953()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_8a0e7965a17f49b2b374e53eede88000 : HardwiredMemberDescriptor
      {
        internal PROP_8a0e7965a17f49b2b374e53eede88000()
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

      private sealed class PROP_761df42b4a91459d9a51933d23b844d6 : HardwiredMemberDescriptor
      {
        internal PROP_761df42b4a91459d9a51933d23b844d6()
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

      private sealed class PROP_34a6d50b0eb44e84bcfd496204a0e4c0 : HardwiredMemberDescriptor
      {
        internal PROP_34a6d50b0eb44e84bcfd496204a0e4c0()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_bdf431d2bf624df89f045ded79569274 : HardwiredMemberDescriptor
      {
        internal PROP_bdf431d2bf624df89f045ded79569274()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_5a24d4e6afee4411a6dc74954d55bfea : HardwiredMemberDescriptor
      {
        internal PROP_5a24d4e6afee4411a6dc74954d55bfea()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_ad56de097d604a2f93adaf2a7f55dc25 : HardwiredMemberDescriptor
      {
        internal PROP_ad56de097d604a2f93adaf2a7f55dc25()
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

      private sealed class PROP_506695a5e1ab4abab5a4e1a6139ceef5 : HardwiredMemberDescriptor
      {
        internal PROP_506695a5e1ab4abab5a4e1a6139ceef5()
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

      private sealed class PROP_c2b6649b87f64928906972c240f8546c : HardwiredMemberDescriptor
      {
        internal PROP_c2b6649b87f64928906972c240f8546c()
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

      private sealed class PROP_6ad8d60087864a8faa4415dddda490b1 : HardwiredMemberDescriptor
      {
        internal PROP_6ad8d60087864a8faa4415dddda490b1()
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

      private sealed class PROP_079a976ab8a2465dbc9e4f8e3d3b97df : HardwiredMemberDescriptor
      {
        internal PROP_079a976ab8a2465dbc9e4f8e3d3b97df()
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

      private sealed class PROP_7f53836b699e43d1bb3fc285e38bc14d : HardwiredMemberDescriptor
      {
        internal PROP_7f53836b699e43d1bb3fc285e38bc14d()
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

      private sealed class PROP_3196519efd744e48bc9dd2b4855983af : HardwiredMemberDescriptor
      {
        internal PROP_3196519efd744e48bc9dd2b4855983af()
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

      private sealed class PROP_74646b089e4d44c291570b60d26da5ed : HardwiredMemberDescriptor
      {
        internal PROP_74646b089e4d44c291570b60d26da5ed()
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

      private sealed class PROP_fa7df608cad4401fa2891c3131fdce9c : HardwiredMemberDescriptor
      {
        internal PROP_fa7df608cad4401fa2891c3131fdce9c()
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

      private sealed class PROP_d0b6571376c94dd4955625fb6e1505fe : HardwiredMemberDescriptor
      {
        internal PROP_d0b6571376c94dd4955625fb6e1505fe()
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

      private sealed class PROP_e90d359807f244a18c25bd017cf6ed83 : HardwiredMemberDescriptor
      {
        internal PROP_e90d359807f244a18c25bd017cf6ed83()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_041012db18e944dfa48b8edae510c769 : HardwiredMemberDescriptor
      {
        internal PROP_041012db18e944dfa48b8edae510c769()
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

      private sealed class PROP_50cd4723bb7c4edd80f9c9bc9dca3149 : HardwiredMemberDescriptor
      {
        internal PROP_50cd4723bb7c4edd80f9c9bc9dca3149()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_b3dbd487f2004e17851a8e47f0e1283f : HardwiredMemberDescriptor
      {
        internal PROP_b3dbd487f2004e17851a8e47f0e1283f()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_2b3435932b0040b4899196d65ad861ae : HardwiredMemberDescriptor
      {
        internal PROP_2b3435932b0040b4899196d65ad861ae()
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

      private sealed class PROP_2a1e79e859174995909e699f255b1ecd : HardwiredMemberDescriptor
      {
        internal PROP_2a1e79e859174995909e699f255b1ecd()
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

      private sealed class PROP_7116d815bdc8480680818cd29eb3ce74 : HardwiredMemberDescriptor
      {
        internal PROP_7116d815bdc8480680818cd29eb3ce74()
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

      private sealed class PROP_1e16c6bf6903472b92af171a89fe6aca : HardwiredMemberDescriptor
      {
        internal PROP_1e16c6bf6903472b92af171a89fe6aca()
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

      private sealed class PROP_0e435c8b0f03490d9a903ff03b8e9609 : HardwiredMemberDescriptor
      {
        internal PROP_0e435c8b0f03490d9a903ff03b8e9609()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_95ba4b8b9cf64297b2a5b0ef124be168 : HardwiredMemberDescriptor
      {
        internal PROP_95ba4b8b9cf64297b2a5b0ef124be168()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_65af7e5946ab496d8eec700baf432333 : HardwiredMemberDescriptor
      {
        internal PROP_65af7e5946ab496d8eec700baf432333()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_22adca46a7a24b13b22792cf63d8ea93 : HardwiredMemberDescriptor
      {
        internal PROP_22adca46a7a24b13b22792cf63d8ea93()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_781225856c114a4989bd08f4e6bb1dab : HardwiredMemberDescriptor
      {
        internal PROP_781225856c114a4989bd08f4e6bb1dab()
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

      private sealed class PROP_6d5f69e9a5084ae2856866f841c009d1 : HardwiredMemberDescriptor
      {
        internal PROP_6d5f69e9a5084ae2856866f841c009d1()
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

      private sealed class PROP_5c61f66e0d344f48815c7c7d12898987 : HardwiredMemberDescriptor
      {
        internal PROP_5c61f66e0d344f48815c7c7d12898987()
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

      private sealed class PROP_365c5a2e2de64b2f94d4bb9cfb91e7b2 : HardwiredMemberDescriptor
      {
        internal PROP_365c5a2e2de64b2f94d4bb9cfb91e7b2()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_78090cc2bc734e48949d497bcac7d05c : HardwiredMemberDescriptor
      {
        internal PROP_78090cc2bc734e48949d497bcac7d05c()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_f070f7f855a540938ac7b3423b02c8af : HardwiredMemberDescriptor
      {
        internal PROP_f070f7f855a540938ac7b3423b02c8af()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_bdc5fdbb6e0e4bcd8a54559c0afc8c45 : HardwiredUserDataDescriptor
    {
      internal TYPE_bdc5fdbb6e0e4bcd8a54559c0afc8c45()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bdc5fdbb6e0e4bcd8a54559c0afc8c45.MTHD_6726472789a045cbb11c1dcfc4392bf5()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bdc5fdbb6e0e4bcd8a54559c0afc8c45.MTHD_931c3c8042ee4842806f9f6516652f71()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bdc5fdbb6e0e4bcd8a54559c0afc8c45.MTHD_45b8ae51b8fc467d9da2c888af1dab9f()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bdc5fdbb6e0e4bcd8a54559c0afc8c45.MTHD_4207d52a48ed47b7ae38756eda53258c()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bdc5fdbb6e0e4bcd8a54559c0afc8c45.MTHD_e465c1810ae34977bc7e8b5e839454ff()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bdc5fdbb6e0e4bcd8a54559c0afc8c45.MTHD_35e408a518ab4e0a841c39d42b9b57de()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bdc5fdbb6e0e4bcd8a54559c0afc8c45.MTHD_f5f7bc5302c9428ab30b58dd0cfffd99()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bdc5fdbb6e0e4bcd8a54559c0afc8c45.MTHD_edb30cf9a31e4d3682c31fe790d7620e()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bdc5fdbb6e0e4bcd8a54559c0afc8c45.MTHD_31a398f7f69e4a3f8c992583067b2494()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bdc5fdbb6e0e4bcd8a54559c0afc8c45.MTHD_3bc5b2d4bb5145a8951165c26e4b841e()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bdc5fdbb6e0e4bcd8a54559c0afc8c45.MTHD_4fae03b9373d49e092c7d0c81bd3d070()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bdc5fdbb6e0e4bcd8a54559c0afc8c45.MTHD_8c602c729cd644b18dbadbbf87041924()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_bdc5fdbb6e0e4bcd8a54559c0afc8c45.PROP_98e46bbb2bb04941be819e51642ef966());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_bdc5fdbb6e0e4bcd8a54559c0afc8c45.PROP_d82a25518a5f43f0b75c6febec0f79bb());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_bdc5fdbb6e0e4bcd8a54559c0afc8c45.PROP_c4db9a50ec4e4555994dd5abbca7791d());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_bdc5fdbb6e0e4bcd8a54559c0afc8c45.PROP_08ead041425c49e19b621d0b15b6d2bc());
      }

      private sealed class MTHD_6726472789a045cbb11c1dcfc4392bf5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6726472789a045cbb11c1dcfc4392bf5()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_931c3c8042ee4842806f9f6516652f71 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_931c3c8042ee4842806f9f6516652f71()
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

      private sealed class MTHD_45b8ae51b8fc467d9da2c888af1dab9f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_45b8ae51b8fc467d9da2c888af1dab9f()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_4207d52a48ed47b7ae38756eda53258c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4207d52a48ed47b7ae38756eda53258c()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_e465c1810ae34977bc7e8b5e839454ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e465c1810ae34977bc7e8b5e839454ff()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_35e408a518ab4e0a841c39d42b9b57de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35e408a518ab4e0a841c39d42b9b57de()
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

      private sealed class MTHD_f5f7bc5302c9428ab30b58dd0cfffd99 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f5f7bc5302c9428ab30b58dd0cfffd99()
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

      private sealed class MTHD_edb30cf9a31e4d3682c31fe790d7620e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_edb30cf9a31e4d3682c31fe790d7620e()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_31a398f7f69e4a3f8c992583067b2494 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_31a398f7f69e4a3f8c992583067b2494()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_3bc5b2d4bb5145a8951165c26e4b841e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3bc5b2d4bb5145a8951165c26e4b841e()
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

      private sealed class MTHD_4fae03b9373d49e092c7d0c81bd3d070 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4fae03b9373d49e092c7d0c81bd3d070()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_8c602c729cd644b18dbadbbf87041924 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c602c729cd644b18dbadbbf87041924()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_98e46bbb2bb04941be819e51642ef966 : HardwiredMemberDescriptor
      {
        internal PROP_98e46bbb2bb04941be819e51642ef966()
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

      private sealed class PROP_d82a25518a5f43f0b75c6febec0f79bb : HardwiredMemberDescriptor
      {
        internal PROP_d82a25518a5f43f0b75c6febec0f79bb()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_c4db9a50ec4e4555994dd5abbca7791d : HardwiredMemberDescriptor
      {
        internal PROP_c4db9a50ec4e4555994dd5abbca7791d()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_08ead041425c49e19b621d0b15b6d2bc : HardwiredMemberDescriptor
      {
        internal PROP_08ead041425c49e19b621d0b15b6d2bc()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0 : HardwiredUserDataDescriptor
    {
      internal TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_899ebd18448b4375b22e48f7dba6c1a3()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_8af04e1783034765a9225d0fecd4d05e()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_d31fd9c97fca4876a4d1c71acc976ef2()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_f4115ab67cdc4e70851548ce9209a32f()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_f9c8cbe705fa4516ac4b8536f78adda4()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_9829183136be4a50a0b315dab66c526a()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_382b6f7e64114030bbd1e148c6f2eb6f()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_83bcfaf6c5f94c5d8681ac931317d427()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_8351f0fa4439452eb2274597e70fc2af()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_9ff2224ce1c04926a367fdbf545c313d()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_5865c9a814684137827a63b11336ecd3()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_b6476e7ab5df43428ffd5a803b5e16e1()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_03ca20b360cf4eb381c5200427f7eaaa()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_cc26cb875ff242c8b70db55f7d60bfaf()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_6564ff224c454fe1813c0cf38a0de6ad()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_303907eea2274756b8c65b7bf60e8608()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_7e5d01492d7f4e7bb9da78ce7c67fe2f()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_65610ff3085f47d68d3954344f8c1a66()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_3631eede8e2c458da9b199fb413ba70a()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_b9f5635710f04ef88604c719e1541db8()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_805d76174e48447c8cf60c089288abc1()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_5d6469cfdf8b402c95cd5d63c894cb3f()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_8c902b6628e94cd1ab55a51762d25d6b()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_9a03dd34558746ea8d29d6d32c98411c()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_349b4b510dc940bdb132360ca6275c42()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_b749fe8e5eb2447f8ce01104601d4da7()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_56da1102f56e4123b1df992dae7b0c97()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_eb05ecc97790406088dfa1c3adef2bd8()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_3311ab45c62440e09328a1eb05c9c274()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_b31168a9d9494be3a99c1192bb77e381()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_4e05b681b7bd4ac68c1372df90413757()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_15f2c3e0c9774f5eb865bae7dffe430a()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_6c912174641842a081a0eab1a9a5c4e6()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_acf251365d4b47b99b1f01801a32158e()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_971240649b9446359d948e8a995e2436()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_e91f9ed642714b73b29a540d5c6e7526()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_f8312b581ee24288bab33d4935c5412f()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_6f5b469e71d744a08c7dcc1779033f16()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_835c91c46cc9448cb5df409c2c653e4f()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_6acb7065b0d54837a9bdb69a21c72329()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_f5c1093bd3a349daa73f25c14454ce04()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_40029de174fd4dae83990c7559205f9f()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_515de016825747e18d5443ab9f43399d()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_c7cc3455893a4826af431acf6c69df5a()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_4aa035e5c1634ab8b7bfd9a1886d1e3d()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_d905c22043cd471ca1d9c0da83c88f62()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_82feee6c8d914b9ba17ccebbcb34174a()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_a6fa8bf2961c495f9a0a07f5325c1078()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_37d76b9bb71a4f9fae2b8709df568cf7()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_cedec9d8dc4b4fb0aff369324b45c240()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_8310a88f13dc4d6bb68bfa25e6407994()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_a6ff7cf7bad94f93aabb5daa2074b93d()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_6c694b25aa9842a78e945669e47d573e()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_9d1308159da0477582167ad45f1a5fff()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_2d1afd9017ca45c091b182410dc3c368()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_5ce3402381bb4b6f94d65c8fadf922d9()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_c108c84a73cc4ccd8aa371148aaefee6()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_5a769bfd16a4424d9c11e66ad5fb4bf4()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_a2f722b3c507409794f15b815a446a52()
        }));
        this.AddMember("getDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_9378473aad53434784b766730b3a47b6()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_83a97d7234b04fe5ad040c2ef8d30536()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_c3c074b925154ca89c020013e3cb9795()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_d79000d5d763469db55f11ad5bbedbc0()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_77c162497def47b792f3d747d691b16c()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_5f0bdf6d6cee44e5ab15b07d5b7cc0e6(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_d18e4eb7c71f45c88dd1b5d456327966()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_7a60e44648db4aa094a94c711b493654(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_1f671c95f8324eb0b659829fcd6422b3()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_fb8d886be74c4a4dbb1ded544d33a4c2()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_3e114cd48fb04d4999595fc115c89786()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_8b711c052e6f4520b79e57af752e9e23(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_63a96841edef4d3fb1c98f45e15241cb()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_6dafb9492d704bc6b0c6000d01d90339()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_3d3b82a663ba4f938682bee868140419()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_ee0e95404dfc4d04bd84c88bad315b3e()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_e9d95f0d5ec94d4780203fb86bf25a2c()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_bee4adbfaeda4446a84391a7c360ef03()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_be8da737c885408d96b950994bdaea96()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_50c4a6666dca47adbe6eff19670d7ab8()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_cd2f53f1f97841a8b2da8345f7e19e4b()
        }));
        this.AddMember("angleToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("angleToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_3253f2e1f5fa456aa1eea93b22097347()
        }));
        this.AddMember("powerToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("powerToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_6f000582b9234017b1f9271545160c48()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_da5a4d4d30ef4ef5ae1eb349c3dcaf5f(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_070cd4d0ade24b3e9d5e5d165ae4517b()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_c38d75b1626f4e6989a401b2e02203af(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_170a21e8edd64f3189b8776d065c2f0e()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_1f097be179474bf8a82d4e3865241f7f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_7961190069a7490c8e9bb13452a81ae0()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_82b961e5fd7f4d21b3b30fda125dc973()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_012e7987c8904e3fb5fb0c4a53fdd198()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_6e1e5c52ac1047b9aaa4cb8fbc9a4ebe()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.MTHD_c80fb89f6f4c420dbf309dff9ad6189c()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_f1ad88cb6192441fae64d066034716d9());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_beacffbdb5434e478aa17e44a3ad8165());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_d0706891489d44a9b0e698bb0c5b4243());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_d14d685c3bab48ac8808caa9fb801dd9());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_974dac6f60d34959be339e82a66be855());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_7df44f3459d44a69b8723e0e7ecebed4());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_e31f91461cd14cf3985f85980f0114dd());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_4501abdf93f34bc39667a60e62204a07());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_cca95d03280c486cb8562428e895f376());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_d7f86ca02fe34f2193b87e53e858bedd());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_714868765e1f431ebb7fa69b37d50d68());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_e53c5692af18424cbcca454f86addccf());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_dbb7d1f61bb94f62987efe2d0454b188());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_02bfc3d52f894b548582f7d7cb148173());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_ceb9773edd894206b092ea7c059c185e());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_e1305edec7404df5bb9fd5ff4d242d0f());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_e7bd1a11a0e442c8bd524840015f16e8());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_5a78ba3fc3ee468e80b4f493df2a3806());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_8f076f2dbda14375ae4b1c47c81044f3());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_8926831bbae443f3a3659cdf8d8c98d6());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_a5d53819f4a2454a922e2968151ffd57());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_eaf38c7fd01c40418e8386e871f24bd9());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_213323823b7a4182a9d491e2cd6e5afc());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_81ccc435e33c407daf718c3774d13de9());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_948df8de8ad345f7a8ff990a0f785cad());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_e15910991f57422fa8fa6eae630a36e5());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_3f5fb2579e1b44c59f014050e77dda91());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_cb42d3b327804b639ea9ead0037627aa());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_d85054d5a63941a59ce4f267d060e6bb());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_f3ebedc5ae7d44ae84962ffb34b568b0());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_c512c392068c4ff5bb749a49d6594598());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_33afeb65a78f4ba9aaf76b8322147b30());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_063d9be6c3fd4c1f9bcd798cb74f4da0.PROP_2c0729bef9164c618d54474f085b0241());
      }

      private sealed class MTHD_899ebd18448b4375b22e48f7dba6c1a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_899ebd18448b4375b22e48f7dba6c1a3()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_8af04e1783034765a9225d0fecd4d05e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8af04e1783034765a9225d0fecd4d05e()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_d31fd9c97fca4876a4d1c71acc976ef2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d31fd9c97fca4876a4d1c71acc976ef2()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_f4115ab67cdc4e70851548ce9209a32f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4115ab67cdc4e70851548ce9209a32f()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_f9c8cbe705fa4516ac4b8536f78adda4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f9c8cbe705fa4516ac4b8536f78adda4()
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

      private sealed class MTHD_9829183136be4a50a0b315dab66c526a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9829183136be4a50a0b315dab66c526a()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_382b6f7e64114030bbd1e148c6f2eb6f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_382b6f7e64114030bbd1e148c6f2eb6f()
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

      private sealed class MTHD_83bcfaf6c5f94c5d8681ac931317d427 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_83bcfaf6c5f94c5d8681ac931317d427()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_8351f0fa4439452eb2274597e70fc2af : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8351f0fa4439452eb2274597e70fc2af()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_9ff2224ce1c04926a367fdbf545c313d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ff2224ce1c04926a367fdbf545c313d()
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

      private sealed class MTHD_5865c9a814684137827a63b11336ecd3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5865c9a814684137827a63b11336ecd3()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_b6476e7ab5df43428ffd5a803b5e16e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b6476e7ab5df43428ffd5a803b5e16e1()
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

      private sealed class MTHD_03ca20b360cf4eb381c5200427f7eaaa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_03ca20b360cf4eb381c5200427f7eaaa()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_cc26cb875ff242c8b70db55f7d60bfaf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cc26cb875ff242c8b70db55f7d60bfaf()
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

      private sealed class MTHD_6564ff224c454fe1813c0cf38a0de6ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6564ff224c454fe1813c0cf38a0de6ad()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_303907eea2274756b8c65b7bf60e8608 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_303907eea2274756b8c65b7bf60e8608()
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

      private sealed class MTHD_7e5d01492d7f4e7bb9da78ce7c67fe2f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7e5d01492d7f4e7bb9da78ce7c67fe2f()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_65610ff3085f47d68d3954344f8c1a66 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65610ff3085f47d68d3954344f8c1a66()
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

      private sealed class MTHD_3631eede8e2c458da9b199fb413ba70a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3631eede8e2c458da9b199fb413ba70a()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_b9f5635710f04ef88604c719e1541db8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b9f5635710f04ef88604c719e1541db8()
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

      private sealed class MTHD_805d76174e48447c8cf60c089288abc1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_805d76174e48447c8cf60c089288abc1()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_5d6469cfdf8b402c95cd5d63c894cb3f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d6469cfdf8b402c95cd5d63c894cb3f()
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

      private sealed class MTHD_8c902b6628e94cd1ab55a51762d25d6b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c902b6628e94cd1ab55a51762d25d6b()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_9a03dd34558746ea8d29d6d32c98411c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9a03dd34558746ea8d29d6d32c98411c()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_349b4b510dc940bdb132360ca6275c42 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_349b4b510dc940bdb132360ca6275c42()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_b749fe8e5eb2447f8ce01104601d4da7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b749fe8e5eb2447f8ce01104601d4da7()
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

      private sealed class MTHD_56da1102f56e4123b1df992dae7b0c97 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_56da1102f56e4123b1df992dae7b0c97()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_eb05ecc97790406088dfa1c3adef2bd8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb05ecc97790406088dfa1c3adef2bd8()
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

      private sealed class MTHD_3311ab45c62440e09328a1eb05c9c274 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3311ab45c62440e09328a1eb05c9c274()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_b31168a9d9494be3a99c1192bb77e381 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b31168a9d9494be3a99c1192bb77e381()
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

      private sealed class MTHD_4e05b681b7bd4ac68c1372df90413757 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e05b681b7bd4ac68c1372df90413757()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_15f2c3e0c9774f5eb865bae7dffe430a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15f2c3e0c9774f5eb865bae7dffe430a()
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

      private sealed class MTHD_6c912174641842a081a0eab1a9a5c4e6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6c912174641842a081a0eab1a9a5c4e6()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_acf251365d4b47b99b1f01801a32158e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_acf251365d4b47b99b1f01801a32158e()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_971240649b9446359d948e8a995e2436 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_971240649b9446359d948e8a995e2436()
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

      private sealed class MTHD_e91f9ed642714b73b29a540d5c6e7526 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e91f9ed642714b73b29a540d5c6e7526()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_f8312b581ee24288bab33d4935c5412f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f8312b581ee24288bab33d4935c5412f()
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

      private sealed class MTHD_6f5b469e71d744a08c7dcc1779033f16 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6f5b469e71d744a08c7dcc1779033f16()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_835c91c46cc9448cb5df409c2c653e4f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_835c91c46cc9448cb5df409c2c653e4f()
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

      private sealed class MTHD_6acb7065b0d54837a9bdb69a21c72329 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6acb7065b0d54837a9bdb69a21c72329()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_f5c1093bd3a349daa73f25c14454ce04 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f5c1093bd3a349daa73f25c14454ce04()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_40029de174fd4dae83990c7559205f9f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_40029de174fd4dae83990c7559205f9f()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_515de016825747e18d5443ab9f43399d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_515de016825747e18d5443ab9f43399d()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_c7cc3455893a4826af431acf6c69df5a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c7cc3455893a4826af431acf6c69df5a()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_4aa035e5c1634ab8b7bfd9a1886d1e3d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4aa035e5c1634ab8b7bfd9a1886d1e3d()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_d905c22043cd471ca1d9c0da83c88f62 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d905c22043cd471ca1d9c0da83c88f62()
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

      private sealed class MTHD_82feee6c8d914b9ba17ccebbcb34174a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_82feee6c8d914b9ba17ccebbcb34174a()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_a6fa8bf2961c495f9a0a07f5325c1078 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6fa8bf2961c495f9a0a07f5325c1078()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_37d76b9bb71a4f9fae2b8709df568cf7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_37d76b9bb71a4f9fae2b8709df568cf7()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_cedec9d8dc4b4fb0aff369324b45c240 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cedec9d8dc4b4fb0aff369324b45c240()
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

      private sealed class MTHD_8310a88f13dc4d6bb68bfa25e6407994 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8310a88f13dc4d6bb68bfa25e6407994()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_a6ff7cf7bad94f93aabb5daa2074b93d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6ff7cf7bad94f93aabb5daa2074b93d()
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

      private sealed class MTHD_6c694b25aa9842a78e945669e47d573e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6c694b25aa9842a78e945669e47d573e()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_9d1308159da0477582167ad45f1a5fff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d1308159da0477582167ad45f1a5fff()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_2d1afd9017ca45c091b182410dc3c368 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d1afd9017ca45c091b182410dc3c368()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_5ce3402381bb4b6f94d65c8fadf922d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ce3402381bb4b6f94d65c8fadf922d9()
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

      private sealed class MTHD_c108c84a73cc4ccd8aa371148aaefee6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c108c84a73cc4ccd8aa371148aaefee6()
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

      private sealed class MTHD_5a769bfd16a4424d9c11e66ad5fb4bf4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5a769bfd16a4424d9c11e66ad5fb4bf4()
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

      private sealed class MTHD_a2f722b3c507409794f15b815a446a52 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2f722b3c507409794f15b815a446a52()
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

      private sealed class MTHD_9378473aad53434784b766730b3a47b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9378473aad53434784b766730b3a47b6()
        {
          this.Initialize("getDirection", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getDirection();
        }
      }

      private sealed class MTHD_83a97d7234b04fe5ad040c2ef8d30536 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_83a97d7234b04fe5ad040c2ef8d30536()
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

      private sealed class MTHD_c3c074b925154ca89c020013e3cb9795 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c3c074b925154ca89c020013e3cb9795()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_d79000d5d763469db55f11ad5bbedbc0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d79000d5d763469db55f11ad5bbedbc0()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_77c162497def47b792f3d747d691b16c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_77c162497def47b792f3d747d691b16c()
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

      private sealed class MTHD_5f0bdf6d6cee44e5ab15b07d5b7cc0e6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5f0bdf6d6cee44e5ab15b07d5b7cc0e6()
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

      private sealed class MTHD_d18e4eb7c71f45c88dd1b5d456327966 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d18e4eb7c71f45c88dd1b5d456327966()
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

      private sealed class MTHD_7a60e44648db4aa094a94c711b493654 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a60e44648db4aa094a94c711b493654()
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

      private sealed class MTHD_1f671c95f8324eb0b659829fcd6422b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f671c95f8324eb0b659829fcd6422b3()
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

      private sealed class MTHD_fb8d886be74c4a4dbb1ded544d33a4c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb8d886be74c4a4dbb1ded544d33a4c2()
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

      private sealed class MTHD_3e114cd48fb04d4999595fc115c89786 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e114cd48fb04d4999595fc115c89786()
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

      private sealed class MTHD_8b711c052e6f4520b79e57af752e9e23 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b711c052e6f4520b79e57af752e9e23()
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

      private sealed class MTHD_63a96841edef4d3fb1c98f45e15241cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_63a96841edef4d3fb1c98f45e15241cb()
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

      private sealed class MTHD_6dafb9492d704bc6b0c6000d01d90339 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6dafb9492d704bc6b0c6000d01d90339()
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

      private sealed class MTHD_3d3b82a663ba4f938682bee868140419 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d3b82a663ba4f938682bee868140419()
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

      private sealed class MTHD_ee0e95404dfc4d04bd84c88bad315b3e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee0e95404dfc4d04bd84c88bad315b3e()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_e9d95f0d5ec94d4780203fb86bf25a2c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e9d95f0d5ec94d4780203fb86bf25a2c()
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

      private sealed class MTHD_bee4adbfaeda4446a84391a7c360ef03 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bee4adbfaeda4446a84391a7c360ef03()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_be8da737c885408d96b950994bdaea96 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be8da737c885408d96b950994bdaea96()
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

      private sealed class MTHD_50c4a6666dca47adbe6eff19670d7ab8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_50c4a6666dca47adbe6eff19670d7ab8()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_cd2f53f1f97841a8b2da8345f7e19e4b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd2f53f1f97841a8b2da8345f7e19e4b()
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

      private sealed class MTHD_3253f2e1f5fa456aa1eea93b22097347 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3253f2e1f5fa456aa1eea93b22097347()
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

      private sealed class MTHD_6f000582b9234017b1f9271545160c48 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6f000582b9234017b1f9271545160c48()
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

      private sealed class MTHD_da5a4d4d30ef4ef5ae1eb349c3dcaf5f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_da5a4d4d30ef4ef5ae1eb349c3dcaf5f()
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

      private sealed class MTHD_070cd4d0ade24b3e9d5e5d165ae4517b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_070cd4d0ade24b3e9d5e5d165ae4517b()
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

      private sealed class MTHD_c38d75b1626f4e6989a401b2e02203af : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c38d75b1626f4e6989a401b2e02203af()
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

      private sealed class MTHD_170a21e8edd64f3189b8776d065c2f0e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_170a21e8edd64f3189b8776d065c2f0e()
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

      private sealed class MTHD_1f097be179474bf8a82d4e3865241f7f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f097be179474bf8a82d4e3865241f7f()
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

      private sealed class MTHD_7961190069a7490c8e9bb13452a81ae0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7961190069a7490c8e9bb13452a81ae0()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_82b961e5fd7f4d21b3b30fda125dc973 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_82b961e5fd7f4d21b3b30fda125dc973()
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

      private sealed class MTHD_012e7987c8904e3fb5fb0c4a53fdd198 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_012e7987c8904e3fb5fb0c4a53fdd198()
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

      private sealed class MTHD_6e1e5c52ac1047b9aaa4cb8fbc9a4ebe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e1e5c52ac1047b9aaa4cb8fbc9a4ebe()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_c80fb89f6f4c420dbf309dff9ad6189c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c80fb89f6f4c420dbf309dff9ad6189c()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_f1ad88cb6192441fae64d066034716d9 : HardwiredMemberDescriptor
      {
        internal PROP_f1ad88cb6192441fae64d066034716d9()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_beacffbdb5434e478aa17e44a3ad8165 : HardwiredMemberDescriptor
      {
        internal PROP_beacffbdb5434e478aa17e44a3ad8165()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_d0706891489d44a9b0e698bb0c5b4243 : HardwiredMemberDescriptor
      {
        internal PROP_d0706891489d44a9b0e698bb0c5b4243()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_d14d685c3bab48ac8808caa9fb801dd9 : HardwiredMemberDescriptor
      {
        internal PROP_d14d685c3bab48ac8808caa9fb801dd9()
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

      private sealed class PROP_974dac6f60d34959be339e82a66be855 : HardwiredMemberDescriptor
      {
        internal PROP_974dac6f60d34959be339e82a66be855()
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

      private sealed class PROP_7df44f3459d44a69b8723e0e7ecebed4 : HardwiredMemberDescriptor
      {
        internal PROP_7df44f3459d44a69b8723e0e7ecebed4()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_e31f91461cd14cf3985f85980f0114dd : HardwiredMemberDescriptor
      {
        internal PROP_e31f91461cd14cf3985f85980f0114dd()
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

      private sealed class PROP_4501abdf93f34bc39667a60e62204a07 : HardwiredMemberDescriptor
      {
        internal PROP_4501abdf93f34bc39667a60e62204a07()
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

      private sealed class PROP_cca95d03280c486cb8562428e895f376 : HardwiredMemberDescriptor
      {
        internal PROP_cca95d03280c486cb8562428e895f376()
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

      private sealed class PROP_d7f86ca02fe34f2193b87e53e858bedd : HardwiredMemberDescriptor
      {
        internal PROP_d7f86ca02fe34f2193b87e53e858bedd()
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

      private sealed class PROP_714868765e1f431ebb7fa69b37d50d68 : HardwiredMemberDescriptor
      {
        internal PROP_714868765e1f431ebb7fa69b37d50d68()
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

      private sealed class PROP_e53c5692af18424cbcca454f86addccf : HardwiredMemberDescriptor
      {
        internal PROP_e53c5692af18424cbcca454f86addccf()
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

      private sealed class PROP_dbb7d1f61bb94f62987efe2d0454b188 : HardwiredMemberDescriptor
      {
        internal PROP_dbb7d1f61bb94f62987efe2d0454b188()
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

      private sealed class PROP_02bfc3d52f894b548582f7d7cb148173 : HardwiredMemberDescriptor
      {
        internal PROP_02bfc3d52f894b548582f7d7cb148173()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_ceb9773edd894206b092ea7c059c185e : HardwiredMemberDescriptor
      {
        internal PROP_ceb9773edd894206b092ea7c059c185e()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_e1305edec7404df5bb9fd5ff4d242d0f : HardwiredMemberDescriptor
      {
        internal PROP_e1305edec7404df5bb9fd5ff4d242d0f()
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

      private sealed class PROP_e7bd1a11a0e442c8bd524840015f16e8 : HardwiredMemberDescriptor
      {
        internal PROP_e7bd1a11a0e442c8bd524840015f16e8()
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

      private sealed class PROP_5a78ba3fc3ee468e80b4f493df2a3806 : HardwiredMemberDescriptor
      {
        internal PROP_5a78ba3fc3ee468e80b4f493df2a3806()
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

      private sealed class PROP_8f076f2dbda14375ae4b1c47c81044f3 : HardwiredMemberDescriptor
      {
        internal PROP_8f076f2dbda14375ae4b1c47c81044f3()
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

      private sealed class PROP_8926831bbae443f3a3659cdf8d8c98d6 : HardwiredMemberDescriptor
      {
        internal PROP_8926831bbae443f3a3659cdf8d8c98d6()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_a5d53819f4a2454a922e2968151ffd57 : HardwiredMemberDescriptor
      {
        internal PROP_a5d53819f4a2454a922e2968151ffd57()
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

      private sealed class PROP_eaf38c7fd01c40418e8386e871f24bd9 : HardwiredMemberDescriptor
      {
        internal PROP_eaf38c7fd01c40418e8386e871f24bd9()
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

      private sealed class PROP_213323823b7a4182a9d491e2cd6e5afc : HardwiredMemberDescriptor
      {
        internal PROP_213323823b7a4182a9d491e2cd6e5afc()
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

      private sealed class PROP_81ccc435e33c407daf718c3774d13de9 : HardwiredMemberDescriptor
      {
        internal PROP_81ccc435e33c407daf718c3774d13de9()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_948df8de8ad345f7a8ff990a0f785cad : HardwiredMemberDescriptor
      {
        internal PROP_948df8de8ad345f7a8ff990a0f785cad()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_e15910991f57422fa8fa6eae630a36e5 : HardwiredMemberDescriptor
      {
        internal PROP_e15910991f57422fa8fa6eae630a36e5()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_3f5fb2579e1b44c59f014050e77dda91 : HardwiredMemberDescriptor
      {
        internal PROP_3f5fb2579e1b44c59f014050e77dda91()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_cb42d3b327804b639ea9ead0037627aa : HardwiredMemberDescriptor
      {
        internal PROP_cb42d3b327804b639ea9ead0037627aa()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_d85054d5a63941a59ce4f267d060e6bb : HardwiredMemberDescriptor
      {
        internal PROP_d85054d5a63941a59ce4f267d060e6bb()
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

      private sealed class PROP_f3ebedc5ae7d44ae84962ffb34b568b0 : HardwiredMemberDescriptor
      {
        internal PROP_f3ebedc5ae7d44ae84962ffb34b568b0()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_c512c392068c4ff5bb749a49d6594598 : HardwiredMemberDescriptor
      {
        internal PROP_c512c392068c4ff5bb749a49d6594598()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_33afeb65a78f4ba9aaf76b8322147b30 : HardwiredMemberDescriptor
      {
        internal PROP_33afeb65a78f4ba9aaf76b8322147b30()
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

      private sealed class PROP_2c0729bef9164c618d54474f085b0241 : HardwiredMemberDescriptor
      {
        internal PROP_2c0729bef9164c618d54474f085b0241()
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

    private sealed class TYPE_dd6d6f3e0dae4798822ef7d093396d06 : HardwiredUserDataDescriptor
    {
      internal TYPE_dd6d6f3e0dae4798822ef7d093396d06()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.MTHD_1cfea66fcd674559b6f3c6f3825284c1()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.MTHD_bb50c30d93c24918a20bf86f14ba5aad()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.MTHD_377e5d03bacd44f29524d0d639314f5c()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.MTHD_b857eb3a030f474eb666a223872a669f()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.MTHD_a91d1143248e4495851724ecd297981a()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.MTHD_567e5b29a6c94441ae893c97fbd10eb3()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.MTHD_569124ed1a0849a48b58c2e293509846()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.MTHD_ae967b2cd3cb42e9ba62c0403b4aa1e3()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.MTHD_4ebded46a23446618e2ab2ab5ba4b18a()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.MTHD_f83072a980de46e98f059394093d0578()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.MTHD_c69b471375144fdfa9cfe133239ab2b4()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.MTHD_2003abde769e4235ad85746b0ebc2b8d()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.MTHD_9141d175083746a1b10fa7c18ce45f42()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.MTHD_2e56dff520ee4c0c94013419b55aad73()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.MTHD_a22f615b380f4d80a13d168ebba96d09()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.MTHD_7934601915934d15b108d44c15358cf6()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.MTHD_f6719496d26f45128866066214da4785()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.MTHD_662e8af44822482a8c7ec67d30f1aaf1()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.MTHD_bc32750a60844a299397d7562a0736a5()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.MTHD_0adfd1456ef4414595453e853d8cecd4()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.PROP_6f45b61b275946b6a60723b90900b270());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.PROP_286651c04968437ca3d772b155b715fe());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.PROP_5d7d0a167cc447d1b4e9808d1bfcd675());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.PROP_ece0571143e54246928e2a295e961847());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.PROP_a36cc380d15a47fb83fdb70bde162500());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.PROP_3507f3d73bae4124ae103eb056488042());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.PROP_97fd487a623745249df160bb3de648e3());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_dd6d6f3e0dae4798822ef7d093396d06.PROP_f0f5acc6d53946f5a7972d34cd1edaac());
      }

      private sealed class MTHD_1cfea66fcd674559b6f3c6f3825284c1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1cfea66fcd674559b6f3c6f3825284c1()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_bb50c30d93c24918a20bf86f14ba5aad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb50c30d93c24918a20bf86f14ba5aad()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_377e5d03bacd44f29524d0d639314f5c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_377e5d03bacd44f29524d0d639314f5c()
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

      private sealed class MTHD_b857eb3a030f474eb666a223872a669f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b857eb3a030f474eb666a223872a669f()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_a91d1143248e4495851724ecd297981a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a91d1143248e4495851724ecd297981a()
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

      private sealed class MTHD_567e5b29a6c94441ae893c97fbd10eb3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_567e5b29a6c94441ae893c97fbd10eb3()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_569124ed1a0849a48b58c2e293509846 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_569124ed1a0849a48b58c2e293509846()
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

      private sealed class MTHD_ae967b2cd3cb42e9ba62c0403b4aa1e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae967b2cd3cb42e9ba62c0403b4aa1e3()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_4ebded46a23446618e2ab2ab5ba4b18a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ebded46a23446618e2ab2ab5ba4b18a()
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

      private sealed class MTHD_f83072a980de46e98f059394093d0578 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f83072a980de46e98f059394093d0578()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_c69b471375144fdfa9cfe133239ab2b4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c69b471375144fdfa9cfe133239ab2b4()
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

      private sealed class MTHD_2003abde769e4235ad85746b0ebc2b8d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2003abde769e4235ad85746b0ebc2b8d()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_9141d175083746a1b10fa7c18ce45f42 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9141d175083746a1b10fa7c18ce45f42()
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

      private sealed class MTHD_2e56dff520ee4c0c94013419b55aad73 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2e56dff520ee4c0c94013419b55aad73()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_a22f615b380f4d80a13d168ebba96d09 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a22f615b380f4d80a13d168ebba96d09()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_7934601915934d15b108d44c15358cf6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7934601915934d15b108d44c15358cf6()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f6719496d26f45128866066214da4785 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f6719496d26f45128866066214da4785()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_662e8af44822482a8c7ec67d30f1aaf1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_662e8af44822482a8c7ec67d30f1aaf1()
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

      private sealed class MTHD_bc32750a60844a299397d7562a0736a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bc32750a60844a299397d7562a0736a5()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_0adfd1456ef4414595453e853d8cecd4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0adfd1456ef4414595453e853d8cecd4()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_6f45b61b275946b6a60723b90900b270 : HardwiredMemberDescriptor
      {
        internal PROP_6f45b61b275946b6a60723b90900b270()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_286651c04968437ca3d772b155b715fe : HardwiredMemberDescriptor
      {
        internal PROP_286651c04968437ca3d772b155b715fe()
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

      private sealed class PROP_5d7d0a167cc447d1b4e9808d1bfcd675 : HardwiredMemberDescriptor
      {
        internal PROP_5d7d0a167cc447d1b4e9808d1bfcd675()
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

      private sealed class PROP_ece0571143e54246928e2a295e961847 : HardwiredMemberDescriptor
      {
        internal PROP_ece0571143e54246928e2a295e961847()
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

      private sealed class PROP_a36cc380d15a47fb83fdb70bde162500 : HardwiredMemberDescriptor
      {
        internal PROP_a36cc380d15a47fb83fdb70bde162500()
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

      private sealed class PROP_3507f3d73bae4124ae103eb056488042 : HardwiredMemberDescriptor
      {
        internal PROP_3507f3d73bae4124ae103eb056488042()
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

      private sealed class PROP_97fd487a623745249df160bb3de648e3 : HardwiredMemberDescriptor
      {
        internal PROP_97fd487a623745249df160bb3de648e3()
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

      private sealed class PROP_f0f5acc6d53946f5a7972d34cd1edaac : HardwiredMemberDescriptor
      {
        internal PROP_f0f5acc6d53946f5a7972d34cd1edaac()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_a578601c70a44ac2a4748415bab03c45 : HardwiredUserDataDescriptor
    {
      internal TYPE_a578601c70a44ac2a4748415bab03c45()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.MTHD_c7c2447649a04c459a8f9924ea51643b()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.MTHD_37b6f486531b46d88eab8b074cb09f2e()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.MTHD_c02caf8918af447cbcff523c9807efd4()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.MTHD_170555e15d2c45baa19fc4d99eec6e70()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.MTHD_5b537ad2612e4dfb85b0f4cef1224a74()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.MTHD_6d36ca1f43d54165bb50bb3b917ef124()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.MTHD_608c5427fcaf4bd881355562094fcb59()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.MTHD_2556d6a3dbb04b3eb48504ca9fd1f471()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.MTHD_20401cbe744249e0afe0048132a757e9()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.MTHD_2cc9c71aebb74e1286c18ac95469e5c0()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.MTHD_23b0236809484b3f8cc4663647077cba()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.MTHD_2025e1a92348476ba27751c8991104be()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.MTHD_1b61a5a1aff949f3a3bce7042dfdff13()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.MTHD_186e1417b940458fa1af72497c98d080()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.MTHD_4ac4897c773841b6ad62edd841637639()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.MTHD_8c17803786f749d7a9f75ea2e2da517e()
        }));
        this.AddMember("setIcon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setIcon", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.MTHD_b3c468808a5d424e8452b1c773f8e5c0()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.MTHD_37cf654f0b39441696600c19bc02d78f()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.MTHD_88bf864e6e8b47b1b4f66f3801072f86()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.MTHD_130e1571f7fa4accbe52d4858ded2b00()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.MTHD_4fadc15c2f074856826392a530ccb388()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.MTHD_6d67d4701003431f9cc68ae2b739bfed()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.PROP_9eb314f82cd848c3b881126b586c6cee());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.PROP_21755b6d949b41c19e4d44c36a21917c());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.PROP_ecac9cb029ec4187b3bc9e34fffbf51e());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.PROP_42276265f19344948effd41387215160());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.PROP_310c87a978a248e5a4829f170d4b89db());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.PROP_c3778a3c25f1422aab43791ba6ae0c82());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.PROP_2c4430bf5b1445fdb37c01abde924db3());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.PROP_6d2277e4a6714a5e988198afc83c7e9c());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_a578601c70a44ac2a4748415bab03c45.PROP_76056189a9b94dda9b3e3f73f0a16cb7());
      }

      private sealed class MTHD_c7c2447649a04c459a8f9924ea51643b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c7c2447649a04c459a8f9924ea51643b()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_37b6f486531b46d88eab8b074cb09f2e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_37b6f486531b46d88eab8b074cb09f2e()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_c02caf8918af447cbcff523c9807efd4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c02caf8918af447cbcff523c9807efd4()
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

      private sealed class MTHD_170555e15d2c45baa19fc4d99eec6e70 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_170555e15d2c45baa19fc4d99eec6e70()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_5b537ad2612e4dfb85b0f4cef1224a74 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b537ad2612e4dfb85b0f4cef1224a74()
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

      private sealed class MTHD_6d36ca1f43d54165bb50bb3b917ef124 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d36ca1f43d54165bb50bb3b917ef124()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_608c5427fcaf4bd881355562094fcb59 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_608c5427fcaf4bd881355562094fcb59()
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

      private sealed class MTHD_2556d6a3dbb04b3eb48504ca9fd1f471 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2556d6a3dbb04b3eb48504ca9fd1f471()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_20401cbe744249e0afe0048132a757e9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_20401cbe744249e0afe0048132a757e9()
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

      private sealed class MTHD_2cc9c71aebb74e1286c18ac95469e5c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2cc9c71aebb74e1286c18ac95469e5c0()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_23b0236809484b3f8cc4663647077cba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_23b0236809484b3f8cc4663647077cba()
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

      private sealed class MTHD_2025e1a92348476ba27751c8991104be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2025e1a92348476ba27751c8991104be()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_1b61a5a1aff949f3a3bce7042dfdff13 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1b61a5a1aff949f3a3bce7042dfdff13()
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

      private sealed class MTHD_186e1417b940458fa1af72497c98d080 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_186e1417b940458fa1af72497c98d080()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color2;
        }
      }

      private sealed class MTHD_4ac4897c773841b6ad62edd841637639 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ac4897c773841b6ad62edd841637639()
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

      private sealed class MTHD_8c17803786f749d7a9f75ea2e2da517e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c17803786f749d7a9f75ea2e2da517e()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_b3c468808a5d424e8452b1c773f8e5c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b3c468808a5d424e8452b1c773f8e5c0()
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

      private sealed class MTHD_37cf654f0b39441696600c19bc02d78f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_37cf654f0b39441696600c19bc02d78f()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_88bf864e6e8b47b1b4f66f3801072f86 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_88bf864e6e8b47b1b4f66f3801072f86()
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

      private sealed class MTHD_130e1571f7fa4accbe52d4858ded2b00 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_130e1571f7fa4accbe52d4858ded2b00()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_4fadc15c2f074856826392a530ccb388 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4fadc15c2f074856826392a530ccb388()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_6d67d4701003431f9cc68ae2b739bfed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d67d4701003431f9cc68ae2b739bfed()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_9eb314f82cd848c3b881126b586c6cee : HardwiredMemberDescriptor
      {
        internal PROP_9eb314f82cd848c3b881126b586c6cee()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_21755b6d949b41c19e4d44c36a21917c : HardwiredMemberDescriptor
      {
        internal PROP_21755b6d949b41c19e4d44c36a21917c()
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

      private sealed class PROP_ecac9cb029ec4187b3bc9e34fffbf51e : HardwiredMemberDescriptor
      {
        internal PROP_ecac9cb029ec4187b3bc9e34fffbf51e()
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

      private sealed class PROP_42276265f19344948effd41387215160 : HardwiredMemberDescriptor
      {
        internal PROP_42276265f19344948effd41387215160()
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

      private sealed class PROP_310c87a978a248e5a4829f170d4b89db : HardwiredMemberDescriptor
      {
        internal PROP_310c87a978a248e5a4829f170d4b89db()
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

      private sealed class PROP_c3778a3c25f1422aab43791ba6ae0c82 : HardwiredMemberDescriptor
      {
        internal PROP_c3778a3c25f1422aab43791ba6ae0c82()
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

      private sealed class PROP_2c4430bf5b1445fdb37c01abde924db3 : HardwiredMemberDescriptor
      {
        internal PROP_2c4430bf5b1445fdb37c01abde924db3()
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

      private sealed class PROP_6d2277e4a6714a5e988198afc83c7e9c : HardwiredMemberDescriptor
      {
        internal PROP_6d2277e4a6714a5e988198afc83c7e9c()
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

      private sealed class PROP_76056189a9b94dda9b3e3f73f0a16cb7 : HardwiredMemberDescriptor
      {
        internal PROP_76056189a9b94dda9b3e3f73f0a16cb7()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_39a99ebd755640c1bff455fe2e723c49 : HardwiredUserDataDescriptor
    {
      internal TYPE_39a99ebd755640c1bff455fe2e723c49()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_2f5fee2ee8f445aeb1462a6b7eff69b3()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_567faabdf9e8402583b8287103cc7b42()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_5cbdeb184d974d16b900efdeb09eb2a1()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_643c6984ef43477ebfc672d5ae208d5b()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_db415304b0b4426194473d9472295e8d()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_ec1c54b730c7433197373a13b85b2aef()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_92592287322a41a68259d579348dc39e()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_54cad2d656764bb790105ec126e6ef34()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_6adb65027bc24e2ab3340916a5dbb77c()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_13f594b799ac4311a831a08cc8912da3()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_9bdb0d9366ff4569b24f8dd2cdd1552b()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_766f0fa363714cb59add9e9429ffa3c6()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_6385207c0dde4b56b5c6485772ae300c()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_1aa27edb51d44bab920eee89f209bd63()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_600f0ef2600641dbbcbcfeddf0a5d40f()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_b0e0066e944341998970608f85263e00()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_bda73aedca2345079a357f72f0110104()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_8bd594f78bc94e6d81a3a792fb4ae972()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_9982d51563b84416b89deeeea7a8c30d()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_d43feb10704c4bb8ad2b351b8c111145()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_98f3f3b3526c44adbc5b97cc8b4ae909()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_28db4006f68a4088a107026fe63128cb()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_ffae81ee21f64b43ab01003bfb7b7b0e()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_a4e186b3e7ed4666b235d392f1cc701b()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_ab97f29370aa4cdf988ea520839b9475()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_41b999cfd4dc47fab846e2b6416ebea8()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_4140ad485390484cb4ffa2bf92579cf2()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.MTHD_54c3b88fb08648fc8f54d4c9d67cd0ca()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.PROP_69552cf63b604e998c9fc1a442e0aea0());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.PROP_c96871210c2a47d6bbf1fa0e6bad9b48());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.PROP_92cdbc475bf64112b03b4371b39759aa());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.PROP_57e1601e44f64a3e98c8780eaa93a704());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.PROP_0532c7c3b7774425b0ef9b646ba763e0());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.PROP_5e1eaa0f05414085b21cbea08d6b9c75());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.PROP_b2deb720944a4c8b8783dd631a30a888());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.PROP_c781d604dcf24c399bf18847a16829d4());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.PROP_82918ddefd254652ab8957e426108e4b());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.PROP_9b4a2172c8644229a451aab159475b00());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.PROP_084950b825a341bfbde76ac4fed42dff());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.PROP_0a85a13c067a4aa48977ef9d5bf36b9f());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.PROP_e0824544108d41d6b1c5fcf70c5342a7());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.PROP_190acc02057246b686241d7605f554a9());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.PROP_ea4bdd562596425b9846fd42550f2fbc());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.PROP_a7ad7e9b96b0453889a16b4716d16758());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_39a99ebd755640c1bff455fe2e723c49.PROP_6d02f258bcca4bc89e55aef50449fcfe());
      }

      private sealed class MTHD_2f5fee2ee8f445aeb1462a6b7eff69b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2f5fee2ee8f445aeb1462a6b7eff69b3()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_567faabdf9e8402583b8287103cc7b42 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_567faabdf9e8402583b8287103cc7b42()
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

      private sealed class MTHD_5cbdeb184d974d16b900efdeb09eb2a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5cbdeb184d974d16b900efdeb09eb2a1()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_643c6984ef43477ebfc672d5ae208d5b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_643c6984ef43477ebfc672d5ae208d5b()
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

      private sealed class MTHD_db415304b0b4426194473d9472295e8d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db415304b0b4426194473d9472295e8d()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_ec1c54b730c7433197373a13b85b2aef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec1c54b730c7433197373a13b85b2aef()
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

      private sealed class MTHD_92592287322a41a68259d579348dc39e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_92592287322a41a68259d579348dc39e()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_54cad2d656764bb790105ec126e6ef34 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_54cad2d656764bb790105ec126e6ef34()
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

      private sealed class MTHD_6adb65027bc24e2ab3340916a5dbb77c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6adb65027bc24e2ab3340916a5dbb77c()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_13f594b799ac4311a831a08cc8912da3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_13f594b799ac4311a831a08cc8912da3()
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

      private sealed class MTHD_9bdb0d9366ff4569b24f8dd2cdd1552b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9bdb0d9366ff4569b24f8dd2cdd1552b()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_766f0fa363714cb59add9e9429ffa3c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_766f0fa363714cb59add9e9429ffa3c6()
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

      private sealed class MTHD_6385207c0dde4b56b5c6485772ae300c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6385207c0dde4b56b5c6485772ae300c()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_1aa27edb51d44bab920eee89f209bd63 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1aa27edb51d44bab920eee89f209bd63()
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

      private sealed class MTHD_600f0ef2600641dbbcbcfeddf0a5d40f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_600f0ef2600641dbbcbcfeddf0a5d40f()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_b0e0066e944341998970608f85263e00 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b0e0066e944341998970608f85263e00()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_bda73aedca2345079a357f72f0110104 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bda73aedca2345079a357f72f0110104()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_8bd594f78bc94e6d81a3a792fb4ae972 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8bd594f78bc94e6d81a3a792fb4ae972()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_9982d51563b84416b89deeeea7a8c30d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9982d51563b84416b89deeeea7a8c30d()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_d43feb10704c4bb8ad2b351b8c111145 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d43feb10704c4bb8ad2b351b8c111145()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_98f3f3b3526c44adbc5b97cc8b4ae909 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_98f3f3b3526c44adbc5b97cc8b4ae909()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_28db4006f68a4088a107026fe63128cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_28db4006f68a4088a107026fe63128cb()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_ffae81ee21f64b43ab01003bfb7b7b0e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ffae81ee21f64b43ab01003bfb7b7b0e()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_a4e186b3e7ed4666b235d392f1cc701b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a4e186b3e7ed4666b235d392f1cc701b()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_ab97f29370aa4cdf988ea520839b9475 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab97f29370aa4cdf988ea520839b9475()
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

      private sealed class MTHD_41b999cfd4dc47fab846e2b6416ebea8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41b999cfd4dc47fab846e2b6416ebea8()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_4140ad485390484cb4ffa2bf92579cf2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4140ad485390484cb4ffa2bf92579cf2()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_54c3b88fb08648fc8f54d4c9d67cd0ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_54c3b88fb08648fc8f54d4c9d67cd0ca()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_69552cf63b604e998c9fc1a442e0aea0 : HardwiredMemberDescriptor
      {
        internal PROP_69552cf63b604e998c9fc1a442e0aea0()
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

      private sealed class PROP_c96871210c2a47d6bbf1fa0e6bad9b48 : HardwiredMemberDescriptor
      {
        internal PROP_c96871210c2a47d6bbf1fa0e6bad9b48()
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

      private sealed class PROP_92cdbc475bf64112b03b4371b39759aa : HardwiredMemberDescriptor
      {
        internal PROP_92cdbc475bf64112b03b4371b39759aa()
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

      private sealed class PROP_57e1601e44f64a3e98c8780eaa93a704 : HardwiredMemberDescriptor
      {
        internal PROP_57e1601e44f64a3e98c8780eaa93a704()
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

      private sealed class PROP_0532c7c3b7774425b0ef9b646ba763e0 : HardwiredMemberDescriptor
      {
        internal PROP_0532c7c3b7774425b0ef9b646ba763e0()
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

      private sealed class PROP_5e1eaa0f05414085b21cbea08d6b9c75 : HardwiredMemberDescriptor
      {
        internal PROP_5e1eaa0f05414085b21cbea08d6b9c75()
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

      private sealed class PROP_b2deb720944a4c8b8783dd631a30a888 : HardwiredMemberDescriptor
      {
        internal PROP_b2deb720944a4c8b8783dd631a30a888()
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

      private sealed class PROP_c781d604dcf24c399bf18847a16829d4 : HardwiredMemberDescriptor
      {
        internal PROP_c781d604dcf24c399bf18847a16829d4()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_82918ddefd254652ab8957e426108e4b : HardwiredMemberDescriptor
      {
        internal PROP_82918ddefd254652ab8957e426108e4b()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_9b4a2172c8644229a451aab159475b00 : HardwiredMemberDescriptor
      {
        internal PROP_9b4a2172c8644229a451aab159475b00()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_084950b825a341bfbde76ac4fed42dff : HardwiredMemberDescriptor
      {
        internal PROP_084950b825a341bfbde76ac4fed42dff()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_0a85a13c067a4aa48977ef9d5bf36b9f : HardwiredMemberDescriptor
      {
        internal PROP_0a85a13c067a4aa48977ef9d5bf36b9f()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_e0824544108d41d6b1c5fcf70c5342a7 : HardwiredMemberDescriptor
      {
        internal PROP_e0824544108d41d6b1c5fcf70c5342a7()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_190acc02057246b686241d7605f554a9 : HardwiredMemberDescriptor
      {
        internal PROP_190acc02057246b686241d7605f554a9()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_ea4bdd562596425b9846fd42550f2fbc : HardwiredMemberDescriptor
      {
        internal PROP_ea4bdd562596425b9846fd42550f2fbc()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_a7ad7e9b96b0453889a16b4716d16758 : HardwiredMemberDescriptor
      {
        internal PROP_a7ad7e9b96b0453889a16b4716d16758()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_6d02f258bcca4bc89e55aef50449fcfe : HardwiredMemberDescriptor
      {
        internal PROP_6d02f258bcca4bc89e55aef50449fcfe()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_d2b7746bdfbc4b418a4e4ae1a612ad1f : HardwiredUserDataDescriptor
    {
      internal TYPE_d2b7746bdfbc4b418a4e4ae1a612ad1f()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d2b7746bdfbc4b418a4e4ae1a612ad1f.MTHD_8cc100b363784f85a39ef209046a1a61()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d2b7746bdfbc4b418a4e4ae1a612ad1f.MTHD_c3b4422eed9649b0a020b704aefd85c0()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d2b7746bdfbc4b418a4e4ae1a612ad1f.MTHD_3a22be3e71894e67858c4d35e36c931b()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d2b7746bdfbc4b418a4e4ae1a612ad1f.MTHD_8b378c7452ce4e6396bb8352c83a0a6a()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d2b7746bdfbc4b418a4e4ae1a612ad1f.MTHD_fbe0730545574819953c1a586938f92f()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d2b7746bdfbc4b418a4e4ae1a612ad1f.MTHD_bbf314b290854b5ab85eb5160ad5bef8()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d2b7746bdfbc4b418a4e4ae1a612ad1f.MTHD_8d878a06f701419da09303edab038b48()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d2b7746bdfbc4b418a4e4ae1a612ad1f.MTHD_6e0807b1c5a941a99a7d50037b3c0b17()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d2b7746bdfbc4b418a4e4ae1a612ad1f.MTHD_389cf8db8eb14935b521eb558656e3b5()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d2b7746bdfbc4b418a4e4ae1a612ad1f.MTHD_237f0db769eb4660b364f81569d06c88()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d2b7746bdfbc4b418a4e4ae1a612ad1f.MTHD_3151d06974e4424fb901196bd6778805()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d2b7746bdfbc4b418a4e4ae1a612ad1f.MTHD_4771c1ac0e0a4e2c937bb47aefcf04cd()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d2b7746bdfbc4b418a4e4ae1a612ad1f.MTHD_f858af0ea7d54b85b3b51a8bc8e6532f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d2b7746bdfbc4b418a4e4ae1a612ad1f.MTHD_9065c582b3834b49a7011e2da00e8e12()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d2b7746bdfbc4b418a4e4ae1a612ad1f.MTHD_2549fa3bc63248a18b434b43876f8028()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d2b7746bdfbc4b418a4e4ae1a612ad1f.MTHD_5ef5a4a4469343459047e13f6e29352b()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d2b7746bdfbc4b418a4e4ae1a612ad1f.MTHD_b65b08d59b9a4333883ecd9b3b1b8f92()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_d2b7746bdfbc4b418a4e4ae1a612ad1f.PROP_a9df8e8ee0664f9db12242080164d837());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_d2b7746bdfbc4b418a4e4ae1a612ad1f.PROP_ceebd208e439447fb72b4a6bedea3d6f());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_d2b7746bdfbc4b418a4e4ae1a612ad1f.PROP_7456d4cbd8354bc6936865295ee95355());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_d2b7746bdfbc4b418a4e4ae1a612ad1f.PROP_e241d76190fa42f1b1d35c8b9163095e());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_d2b7746bdfbc4b418a4e4ae1a612ad1f.PROP_16671ef84f8146e187efba49c95d3726());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_d2b7746bdfbc4b418a4e4ae1a612ad1f.PROP_9c9e37773cd24bd5a3e8b6f53e170ef7());
      }

      private sealed class MTHD_8cc100b363784f85a39ef209046a1a61 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8cc100b363784f85a39ef209046a1a61()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_c3b4422eed9649b0a020b704aefd85c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c3b4422eed9649b0a020b704aefd85c0()
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

      private sealed class MTHD_3a22be3e71894e67858c4d35e36c931b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3a22be3e71894e67858c4d35e36c931b()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_8b378c7452ce4e6396bb8352c83a0a6a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b378c7452ce4e6396bb8352c83a0a6a()
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

      private sealed class MTHD_fbe0730545574819953c1a586938f92f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fbe0730545574819953c1a586938f92f()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_bbf314b290854b5ab85eb5160ad5bef8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bbf314b290854b5ab85eb5160ad5bef8()
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

      private sealed class MTHD_8d878a06f701419da09303edab038b48 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8d878a06f701419da09303edab038b48()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_6e0807b1c5a941a99a7d50037b3c0b17 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e0807b1c5a941a99a7d50037b3c0b17()
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

      private sealed class MTHD_389cf8db8eb14935b521eb558656e3b5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_389cf8db8eb14935b521eb558656e3b5()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_237f0db769eb4660b364f81569d06c88 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_237f0db769eb4660b364f81569d06c88()
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

      private sealed class MTHD_3151d06974e4424fb901196bd6778805 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3151d06974e4424fb901196bd6778805()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_4771c1ac0e0a4e2c937bb47aefcf04cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4771c1ac0e0a4e2c937bb47aefcf04cd()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_f858af0ea7d54b85b3b51a8bc8e6532f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f858af0ea7d54b85b3b51a8bc8e6532f()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9065c582b3834b49a7011e2da00e8e12 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9065c582b3834b49a7011e2da00e8e12()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_2549fa3bc63248a18b434b43876f8028 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2549fa3bc63248a18b434b43876f8028()
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

      private sealed class MTHD_5ef5a4a4469343459047e13f6e29352b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ef5a4a4469343459047e13f6e29352b()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_b65b08d59b9a4333883ecd9b3b1b8f92 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b65b08d59b9a4333883ecd9b3b1b8f92()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_a9df8e8ee0664f9db12242080164d837 : HardwiredMemberDescriptor
      {
        internal PROP_a9df8e8ee0664f9db12242080164d837()
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

      private sealed class PROP_ceebd208e439447fb72b4a6bedea3d6f : HardwiredMemberDescriptor
      {
        internal PROP_ceebd208e439447fb72b4a6bedea3d6f()
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

      private sealed class PROP_7456d4cbd8354bc6936865295ee95355 : HardwiredMemberDescriptor
      {
        internal PROP_7456d4cbd8354bc6936865295ee95355()
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

      private sealed class PROP_e241d76190fa42f1b1d35c8b9163095e : HardwiredMemberDescriptor
      {
        internal PROP_e241d76190fa42f1b1d35c8b9163095e()
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

      private sealed class PROP_16671ef84f8146e187efba49c95d3726 : HardwiredMemberDescriptor
      {
        internal PROP_16671ef84f8146e187efba49c95d3726()
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

      private sealed class PROP_9c9e37773cd24bd5a3e8b6f53e170ef7 : HardwiredMemberDescriptor
      {
        internal PROP_9c9e37773cd24bd5a3e8b6f53e170ef7()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_5c98f708dc2b4607a8727ae29331a5eb : HardwiredUserDataDescriptor
    {
      internal TYPE_5c98f708dc2b4607a8727ae29331a5eb()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c98f708dc2b4607a8727ae29331a5eb.MTHD_12581268b5d34e998a0d8876e74d5ed1(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c98f708dc2b4607a8727ae29331a5eb.MTHD_c35493803a95400897bf8ab169b47a21()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c98f708dc2b4607a8727ae29331a5eb.MTHD_7e5bf015ba4d48e7aed64eaeeea6a3eb(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c98f708dc2b4607a8727ae29331a5eb.MTHD_53eff29226214a5b87df09653b83fee9()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c98f708dc2b4607a8727ae29331a5eb.MTHD_8d03d90973074475a9bc1f324b9de76d()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c98f708dc2b4607a8727ae29331a5eb.MTHD_ee92636ac7934ff98cc4e84fbba2c894()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c98f708dc2b4607a8727ae29331a5eb.MTHD_7ceb3c78944e4cb18f0f4d8d97cce524()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c98f708dc2b4607a8727ae29331a5eb.MTHD_753e8cc72c504b76986a4cca30068dad()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c98f708dc2b4607a8727ae29331a5eb.MTHD_66b41e14232a463bb461dac3663a9551()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c98f708dc2b4607a8727ae29331a5eb.MTHD_f8b6d23437b24bfd93c10219db472052()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c98f708dc2b4607a8727ae29331a5eb.MTHD_5c405277fb404d2b9697023cbe13e6f7()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c98f708dc2b4607a8727ae29331a5eb.MTHD_dee2dc4ec70a4fbda3fcc91d7edf913f(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c98f708dc2b4607a8727ae29331a5eb.MTHD_3e2d0299fa2f41b38614b2e17fdb83f5()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c98f708dc2b4607a8727ae29331a5eb.MTHD_4e6feb766ccc45fca6bc0cb31d6fce08(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c98f708dc2b4607a8727ae29331a5eb.MTHD_d3fb96146d594177b3a787e80d68e0d4()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c98f708dc2b4607a8727ae29331a5eb.MTHD_e91d8ecfa2a243ad87942002b3547ceb(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c98f708dc2b4607a8727ae29331a5eb.MTHD_753e83758e884ef1ba511ee3ed7e6415()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c98f708dc2b4607a8727ae29331a5eb.MTHD_f1ead67b442240d797a60cebb38ca1eb(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c98f708dc2b4607a8727ae29331a5eb.MTHD_7fe3e00966e845808ffd9725682dbda1()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c98f708dc2b4607a8727ae29331a5eb.MTHD_8dc453886a7f4589aa345111b8b25273(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c98f708dc2b4607a8727ae29331a5eb.MTHD_723585a8295c43acbf2a99a55c8ab03b()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c98f708dc2b4607a8727ae29331a5eb.MTHD_05c4439a915a4c3a8c21a5319f83a8da()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c98f708dc2b4607a8727ae29331a5eb.MTHD_1e7ccc2584eb46fd9d6be26cac701e1b()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_5c98f708dc2b4607a8727ae29331a5eb.FLDV_63e204c9941344b89e288ec329bfd533());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_5c98f708dc2b4607a8727ae29331a5eb.FLDV_24208e5410c0413e91eabede013d3151());
      }

      private sealed class MTHD_12581268b5d34e998a0d8876e74d5ed1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_12581268b5d34e998a0d8876e74d5ed1()
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

      private sealed class MTHD_c35493803a95400897bf8ab169b47a21 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c35493803a95400897bf8ab169b47a21()
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

      private sealed class MTHD_7e5bf015ba4d48e7aed64eaeeea6a3eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7e5bf015ba4d48e7aed64eaeeea6a3eb()
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

      private sealed class MTHD_53eff29226214a5b87df09653b83fee9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_53eff29226214a5b87df09653b83fee9()
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

      private sealed class MTHD_8d03d90973074475a9bc1f324b9de76d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8d03d90973074475a9bc1f324b9de76d()
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

      private sealed class MTHD_ee92636ac7934ff98cc4e84fbba2c894 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee92636ac7934ff98cc4e84fbba2c894()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_7ceb3c78944e4cb18f0f4d8d97cce524 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ceb3c78944e4cb18f0f4d8d97cce524()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_753e8cc72c504b76986a4cca30068dad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_753e8cc72c504b76986a4cca30068dad()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_66b41e14232a463bb461dac3663a9551 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_66b41e14232a463bb461dac3663a9551()
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

      private sealed class MTHD_f8b6d23437b24bfd93c10219db472052 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f8b6d23437b24bfd93c10219db472052()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_5c405277fb404d2b9697023cbe13e6f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c405277fb404d2b9697023cbe13e6f7()
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

      private sealed class MTHD_dee2dc4ec70a4fbda3fcc91d7edf913f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dee2dc4ec70a4fbda3fcc91d7edf913f()
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

      private sealed class MTHD_3e2d0299fa2f41b38614b2e17fdb83f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e2d0299fa2f41b38614b2e17fdb83f5()
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

      private sealed class MTHD_4e6feb766ccc45fca6bc0cb31d6fce08 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e6feb766ccc45fca6bc0cb31d6fce08()
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

      private sealed class MTHD_d3fb96146d594177b3a787e80d68e0d4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d3fb96146d594177b3a787e80d68e0d4()
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

      private sealed class MTHD_e91d8ecfa2a243ad87942002b3547ceb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e91d8ecfa2a243ad87942002b3547ceb()
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

      private sealed class MTHD_753e83758e884ef1ba511ee3ed7e6415 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_753e83758e884ef1ba511ee3ed7e6415()
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

      private sealed class MTHD_f1ead67b442240d797a60cebb38ca1eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f1ead67b442240d797a60cebb38ca1eb()
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

      private sealed class MTHD_7fe3e00966e845808ffd9725682dbda1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7fe3e00966e845808ffd9725682dbda1()
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

      private sealed class MTHD_8dc453886a7f4589aa345111b8b25273 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8dc453886a7f4589aa345111b8b25273()
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

      private sealed class MTHD_723585a8295c43acbf2a99a55c8ab03b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_723585a8295c43acbf2a99a55c8ab03b()
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

      private sealed class MTHD_05c4439a915a4c3a8c21a5319f83a8da : HardwiredMethodMemberDescriptor
      {
        internal MTHD_05c4439a915a4c3a8c21a5319f83a8da()
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

      private sealed class MTHD_1e7ccc2584eb46fd9d6be26cac701e1b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1e7ccc2584eb46fd9d6be26cac701e1b()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_63e204c9941344b89e288ec329bfd533 : HardwiredMemberDescriptor
      {
        internal FLDV_63e204c9941344b89e288ec329bfd533()
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

      private sealed class FLDV_24208e5410c0413e91eabede013d3151 : HardwiredMemberDescriptor
      {
        internal FLDV_24208e5410c0413e91eabede013d3151()
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

    private sealed class TYPE_ce3d5c3dc58448b5a6ba76d0d8a6950a : HardwiredUserDataDescriptor
    {
      internal TYPE_ce3d5c3dc58448b5a6ba76d0d8a6950a()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce3d5c3dc58448b5a6ba76d0d8a6950a.MTHD_631eb1c6888846a5a47bffdc9bacdfbd()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce3d5c3dc58448b5a6ba76d0d8a6950a.MTHD_8d44be8631424bcd93812c44155d52bd()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce3d5c3dc58448b5a6ba76d0d8a6950a.MTHD_7173dee8a26e4741af1512d35a7e5d44()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce3d5c3dc58448b5a6ba76d0d8a6950a.MTHD_8a819d3b9338435b95ec0cd8c4bab5e8()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce3d5c3dc58448b5a6ba76d0d8a6950a.MTHD_61842ab31f5b401cb8abf1a2a52d2c9e()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce3d5c3dc58448b5a6ba76d0d8a6950a.MTHD_01d6da13ef2e4017911827fcec1beaa3()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_ce3d5c3dc58448b5a6ba76d0d8a6950a.FLDV_8f35f2081b2e4274a4f07be7b5781315());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_ce3d5c3dc58448b5a6ba76d0d8a6950a.FLDV_6470fc2cea8b4298931c12216c211c76());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_ce3d5c3dc58448b5a6ba76d0d8a6950a.FLDV_64ab97fb36c548738990cd56eda12d63());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_ce3d5c3dc58448b5a6ba76d0d8a6950a.FLDV_047d96c9d3b64a8e8b90d8334eb629e4());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_ce3d5c3dc58448b5a6ba76d0d8a6950a.FLDV_d9457256e4b040f2b3d03c8e9e87031d());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_ce3d5c3dc58448b5a6ba76d0d8a6950a.FLDV_e479ded48fde4e62ac052b2a11577958());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_ce3d5c3dc58448b5a6ba76d0d8a6950a.FLDV_0604d105c5e04197bcdaf361229c6dc0());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_ce3d5c3dc58448b5a6ba76d0d8a6950a.FLDV_7f90c39d769845198819b056e27ba9b0());
        this.AddMember("prestige", (IMemberDescriptor) new Bridge.TYPE_ce3d5c3dc58448b5a6ba76d0d8a6950a.FLDV_1f85bc2ad78b45d48b6eb3e347daa0be());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_ce3d5c3dc58448b5a6ba76d0d8a6950a.FLDV_667cb3f889494a12ab810220654dd53f());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_ce3d5c3dc58448b5a6ba76d0d8a6950a.FLDV_f981a509fec644518c7262e85e31b85f());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_ce3d5c3dc58448b5a6ba76d0d8a6950a.FLDV_ab7d7b00e0d145deb880a8331f88a4c9());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_ce3d5c3dc58448b5a6ba76d0d8a6950a.FLDV_5933aff7e56341d592111c2e7e7d3801());
      }

      private sealed class MTHD_631eb1c6888846a5a47bffdc9bacdfbd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_631eb1c6888846a5a47bffdc9bacdfbd()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_8d44be8631424bcd93812c44155d52bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8d44be8631424bcd93812c44155d52bd()
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

      private sealed class MTHD_7173dee8a26e4741af1512d35a7e5d44 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7173dee8a26e4741af1512d35a7e5d44()
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

      private sealed class MTHD_8a819d3b9338435b95ec0cd8c4bab5e8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a819d3b9338435b95ec0cd8c4bab5e8()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_61842ab31f5b401cb8abf1a2a52d2c9e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_61842ab31f5b401cb8abf1a2a52d2c9e()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_01d6da13ef2e4017911827fcec1beaa3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_01d6da13ef2e4017911827fcec1beaa3()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_8f35f2081b2e4274a4f07be7b5781315 : HardwiredMemberDescriptor
      {
        internal FLDV_8f35f2081b2e4274a4f07be7b5781315()
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

      private sealed class FLDV_6470fc2cea8b4298931c12216c211c76 : HardwiredMemberDescriptor
      {
        internal FLDV_6470fc2cea8b4298931c12216c211c76()
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

      private sealed class FLDV_64ab97fb36c548738990cd56eda12d63 : HardwiredMemberDescriptor
      {
        internal FLDV_64ab97fb36c548738990cd56eda12d63()
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

      private sealed class FLDV_047d96c9d3b64a8e8b90d8334eb629e4 : HardwiredMemberDescriptor
      {
        internal FLDV_047d96c9d3b64a8e8b90d8334eb629e4()
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

      private sealed class FLDV_d9457256e4b040f2b3d03c8e9e87031d : HardwiredMemberDescriptor
      {
        internal FLDV_d9457256e4b040f2b3d03c8e9e87031d()
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

      private sealed class FLDV_e479ded48fde4e62ac052b2a11577958 : HardwiredMemberDescriptor
      {
        internal FLDV_e479ded48fde4e62ac052b2a11577958()
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

      private sealed class FLDV_0604d105c5e04197bcdaf361229c6dc0 : HardwiredMemberDescriptor
      {
        internal FLDV_0604d105c5e04197bcdaf361229c6dc0()
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

      private sealed class FLDV_7f90c39d769845198819b056e27ba9b0 : HardwiredMemberDescriptor
      {
        internal FLDV_7f90c39d769845198819b056e27ba9b0()
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

      private sealed class FLDV_1f85bc2ad78b45d48b6eb3e347daa0be : HardwiredMemberDescriptor
      {
        internal FLDV_1f85bc2ad78b45d48b6eb3e347daa0be()
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

      private sealed class FLDV_667cb3f889494a12ab810220654dd53f : HardwiredMemberDescriptor
      {
        internal FLDV_667cb3f889494a12ab810220654dd53f()
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

      private sealed class FLDV_f981a509fec644518c7262e85e31b85f : HardwiredMemberDescriptor
      {
        internal FLDV_f981a509fec644518c7262e85e31b85f()
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

      private sealed class FLDV_ab7d7b00e0d145deb880a8331f88a4c9 : HardwiredMemberDescriptor
      {
        internal FLDV_ab7d7b00e0d145deb880a8331f88a4c9()
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

      private sealed class FLDV_5933aff7e56341d592111c2e7e7d3801 : HardwiredMemberDescriptor
      {
        internal FLDV_5933aff7e56341d592111c2e7e7d3801()
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

    private sealed class TYPE_2331be6a473f4761bd04f4f888e6be7f : HardwiredUserDataDescriptor
    {
      internal TYPE_2331be6a473f4761bd04f4f888e6be7f()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_e7698dd540794f9abdf1c75fd9091d25()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_45c4c05365fe4cc48ddd103587c254d6()
        }));
        this.AddMember("get_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_4138582707bd466d975694827ee225ef()
        }));
        this.AddMember("set_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_72a4db68bfe048dc89d1a0f6898e5bb4()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_305a7fb087584b9088a076ae212c98d7()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_b4d47b3e3ab74f6492439381d5237910()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_d5f43344c6d24a93861e169b6ea43649()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_4e3f417c13504e31aa467737588c5cad()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_c04cb8fe754345c1bcacecb74c342878()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_fbd38a3ada8b4f3a90f5654bea054cab()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_d4ef8e71938149bdb7cd8798edb4317a()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_3d619bf1a37a4444add61d4e13f62cda()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_a537be90d6f34647a5795fbe7bcd161f()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_1903f8ad361b48dca8065944da5dea3a()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_177ce640e15442969a42b77c49fd437d()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_f34f0dc63880456b99eb3fe72455117e()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_48d7a56ceca64a5a92462515637b094f()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_ee358eefb5e74c59b8f88732e5845fc2()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_ec09b15f4ba74eb9b6ea328e4fc881ca()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_ba4a9ae59fb7476ca99e0fb0669d6c29()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_f2f9b03e5c1b4cf99fe02af12dec7fba()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_31aa7ec373bd4fac87ebbe936399dd68()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_c87e9373122146d7baf5f8ccdea800e2()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_cd10998d640d4a79979fd502048eb201()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_cd9c26c66efa4e1391ee4988233f852f()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_b2c60b0ec4d247669582b2afcba3e668()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_d571750e412448a1949777cbc52f7b97()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_1d08fa6e9c4147ff9b648b67935bf50b()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_ec34dbdab4b8466fbaccbdd95a5c1afe()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_94530c0509f84f3398332055bdca89e9()
        }));
        this.AddMember("get_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_a9d6abf1cafe42de924246ee838e3d76()
        }));
        this.AddMember("set_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_766fcf0c23304f099fc1537094ed3bec()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_03527f062b4545219f5e2f10ff704fa2()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_f711a054ce9040ac9cadb4751d6aa3fd()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_841f9ca1e61d493e8daad0b73c4e142b()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_f3241dd95f544e51834992d4965cd960()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_c9625ee11d3542819e8459a34b50b94b()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_2832cc674ef0475cb12dbeac18052171()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_48d8934c7ab14bf3b0adf745f1ec1b84()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_2ca9b9c11dfe45348a5bae3066e51b32()
        }));
        this.AddMember("get_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_28f86ed689f54de68262c02176a6c7e2()
        }));
        this.AddMember("set_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_7558cc8445774d1c85100190dbf6ceb3()
        }));
        this.AddMember("get_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_9da32952617e4a50b58def1ceb50219c()
        }));
        this.AddMember("set_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_c9a687fdf54e47d8a045043d5710a414()
        }));
        this.AddMember("get_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_cabed94350bf4abd9435d8a373907563()
        }));
        this.AddMember("set_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_81ae1cd5ef03455aaf78fcde984dd09e()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_13fc9d254de5474681d9ffb70940fbde()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_a26c3b9b8cbf49a3b291d9a74a06ba8a()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_d2764582fb5e4876a860e2f3c64ed5c7()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_ecde2e7764da407b8caeec966014c8fc()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_61293ce4cd4746eebfca128bc79a3e73()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_c3ff1875429d4ba59c593c6fb00c8274()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_6a11414406214edea38b5a536925e913()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_48bba2cd726f439491c2777e5bc35670()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_c3a7e39238d443f8ab695b6f6e4aa44c()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_99e12f249d5f4a829132be7047cb82ed()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_c9e6f5de886d4067a66678503e667bce()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_071a03d9642846359aace215187d496f()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_3713f82eecd4414a97a511e66affdf3e()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.MTHD_0ab83376a8e04247bf55a082bde84cb0()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.PROP_1c8aa3ce74084157b14f23e317508984());
        this.AddMember("visible", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.PROP_06d46f9a24384f34ab69aa893558b3e1());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.PROP_fdaa74c903574b22a8c167fab07abbbe());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.PROP_9967bf58d7144b6bb1aa1529c24cc430());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.PROP_54db1dc1babc40e99d42933d1d98268d());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.PROP_aea309927ff34f4a87b0d1ba0e9165e1());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.PROP_5799dfc14c2845da9101d10a10044fa4());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.PROP_7557e1b17d284c02b81e013594126db7());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.PROP_57d5f51c99d14640983b5c0dc44d8175());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.PROP_729f358f13e342f493da205a08d90d0e());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.PROP_c16412161ee9482fada060a682e8869e());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.PROP_b5a4a7913de04507a013831157e65ab7());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.PROP_1246d60b94cb4dd7960f1f97e84d942d());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.PROP_899313571fd44a14ba10ab3eae52fa0f());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.PROP_f7bc82e7a2f34a909142fdef8328c73d());
        this.AddMember("onClick2", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.PROP_542be457baeb478c866eea91bc14676a());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.PROP_bbcf7ed05c0740578d5f705122ff1b3a());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.PROP_1411a83f42fa4030a40834f326a6ddd4());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.PROP_65c54c71061746579f39d9923b920ebb());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.PROP_b9a6a66368cb439ca74ccd586840d553());
        this.AddMember("textColor2", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.PROP_9029df7cb7bb4997bc7ebad117e1039e());
        this.AddMember("highlightColor", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.PROP_fb9d6afc7b4d4f839433ca9aabaeba3c());
        this.AddMember("highlightColor2", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.PROP_3e310acb46804a7ea9a1b5af84dc6f65());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.PROP_4304b6b153c04f01814d51c8111bb079());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.PROP_c4f60818695343b48bdb695198ea3417());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.FLDV_22b3f5a0eb4f418988f371691fe6882c());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.FLDV_451a11bb89fd4d7494e37dc9386e8efc());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_2331be6a473f4761bd04f4f888e6be7f.FLDV_7ae331d090304e98bbd7196165ed0da6());
      }

      private sealed class MTHD_e7698dd540794f9abdf1c75fd9091d25 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7698dd540794f9abdf1c75fd9091d25()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_45c4c05365fe4cc48ddd103587c254d6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_45c4c05365fe4cc48ddd103587c254d6()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_4138582707bd466d975694827ee225ef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4138582707bd466d975694827ee225ef()
        {
          this.Initialize("get_visible", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).visible;
        }
      }

      private sealed class MTHD_72a4db68bfe048dc89d1a0f6898e5bb4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_72a4db68bfe048dc89d1a0f6898e5bb4()
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

      private sealed class MTHD_305a7fb087584b9088a076ae212c98d7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_305a7fb087584b9088a076ae212c98d7()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_b4d47b3e3ab74f6492439381d5237910 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b4d47b3e3ab74f6492439381d5237910()
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

      private sealed class MTHD_d5f43344c6d24a93861e169b6ea43649 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d5f43344c6d24a93861e169b6ea43649()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_4e3f417c13504e31aa467737588c5cad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e3f417c13504e31aa467737588c5cad()
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

      private sealed class MTHD_c04cb8fe754345c1bcacecb74c342878 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c04cb8fe754345c1bcacecb74c342878()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_fbd38a3ada8b4f3a90f5654bea054cab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fbd38a3ada8b4f3a90f5654bea054cab()
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

      private sealed class MTHD_d4ef8e71938149bdb7cd8798edb4317a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d4ef8e71938149bdb7cd8798edb4317a()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_3d619bf1a37a4444add61d4e13f62cda : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d619bf1a37a4444add61d4e13f62cda()
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

      private sealed class MTHD_a537be90d6f34647a5795fbe7bcd161f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a537be90d6f34647a5795fbe7bcd161f()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_1903f8ad361b48dca8065944da5dea3a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1903f8ad361b48dca8065944da5dea3a()
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

      private sealed class MTHD_177ce640e15442969a42b77c49fd437d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_177ce640e15442969a42b77c49fd437d()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_f34f0dc63880456b99eb3fe72455117e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f34f0dc63880456b99eb3fe72455117e()
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

      private sealed class MTHD_48d7a56ceca64a5a92462515637b094f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_48d7a56ceca64a5a92462515637b094f()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_ee358eefb5e74c59b8f88732e5845fc2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee358eefb5e74c59b8f88732e5845fc2()
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

      private sealed class MTHD_ec09b15f4ba74eb9b6ea328e4fc881ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec09b15f4ba74eb9b6ea328e4fc881ca()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_ba4a9ae59fb7476ca99e0fb0669d6c29 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba4a9ae59fb7476ca99e0fb0669d6c29()
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

      private sealed class MTHD_f2f9b03e5c1b4cf99fe02af12dec7fba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f2f9b03e5c1b4cf99fe02af12dec7fba()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_31aa7ec373bd4fac87ebbe936399dd68 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_31aa7ec373bd4fac87ebbe936399dd68()
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

      private sealed class MTHD_c87e9373122146d7baf5f8ccdea800e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c87e9373122146d7baf5f8ccdea800e2()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_cd10998d640d4a79979fd502048eb201 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd10998d640d4a79979fd502048eb201()
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

      private sealed class MTHD_cd9c26c66efa4e1391ee4988233f852f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd9c26c66efa4e1391ee4988233f852f()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_b2c60b0ec4d247669582b2afcba3e668 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b2c60b0ec4d247669582b2afcba3e668()
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

      private sealed class MTHD_d571750e412448a1949777cbc52f7b97 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d571750e412448a1949777cbc52f7b97()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_1d08fa6e9c4147ff9b648b67935bf50b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d08fa6e9c4147ff9b648b67935bf50b()
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

      private sealed class MTHD_ec34dbdab4b8466fbaccbdd95a5c1afe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec34dbdab4b8466fbaccbdd95a5c1afe()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_94530c0509f84f3398332055bdca89e9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_94530c0509f84f3398332055bdca89e9()
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

      private sealed class MTHD_a9d6abf1cafe42de924246ee838e3d76 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a9d6abf1cafe42de924246ee838e3d76()
        {
          this.Initialize("get_onClick2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick2;
        }
      }

      private sealed class MTHD_766fcf0c23304f099fc1537094ed3bec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_766fcf0c23304f099fc1537094ed3bec()
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

      private sealed class MTHD_03527f062b4545219f5e2f10ff704fa2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_03527f062b4545219f5e2f10ff704fa2()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_f711a054ce9040ac9cadb4751d6aa3fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f711a054ce9040ac9cadb4751d6aa3fd()
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

      private sealed class MTHD_841f9ca1e61d493e8daad0b73c4e142b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_841f9ca1e61d493e8daad0b73c4e142b()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color2;
        }
      }

      private sealed class MTHD_f3241dd95f544e51834992d4965cd960 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f3241dd95f544e51834992d4965cd960()
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

      private sealed class MTHD_c9625ee11d3542819e8459a34b50b94b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c9625ee11d3542819e8459a34b50b94b()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_2832cc674ef0475cb12dbeac18052171 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2832cc674ef0475cb12dbeac18052171()
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

      private sealed class MTHD_48d8934c7ab14bf3b0adf745f1ec1b84 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_48d8934c7ab14bf3b0adf745f1ec1b84()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_2ca9b9c11dfe45348a5bae3066e51b32 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2ca9b9c11dfe45348a5bae3066e51b32()
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

      private sealed class MTHD_28f86ed689f54de68262c02176a6c7e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_28f86ed689f54de68262c02176a6c7e2()
        {
          this.Initialize("get_textColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor2;
        }
      }

      private sealed class MTHD_7558cc8445774d1c85100190dbf6ceb3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7558cc8445774d1c85100190dbf6ceb3()
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

      private sealed class MTHD_9da32952617e4a50b58def1ceb50219c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9da32952617e4a50b58def1ceb50219c()
        {
          this.Initialize("get_highlightColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor;
        }
      }

      private sealed class MTHD_c9a687fdf54e47d8a045043d5710a414 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c9a687fdf54e47d8a045043d5710a414()
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

      private sealed class MTHD_cabed94350bf4abd9435d8a373907563 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cabed94350bf4abd9435d8a373907563()
        {
          this.Initialize("get_highlightColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor2;
        }
      }

      private sealed class MTHD_81ae1cd5ef03455aaf78fcde984dd09e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_81ae1cd5ef03455aaf78fcde984dd09e()
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

      private sealed class MTHD_13fc9d254de5474681d9ffb70940fbde : HardwiredMethodMemberDescriptor
      {
        internal MTHD_13fc9d254de5474681d9ffb70940fbde()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_a26c3b9b8cbf49a3b291d9a74a06ba8a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a26c3b9b8cbf49a3b291d9a74a06ba8a()
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

      private sealed class MTHD_d2764582fb5e4876a860e2f3c64ed5c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d2764582fb5e4876a860e2f3c64ed5c7()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_ecde2e7764da407b8caeec966014c8fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ecde2e7764da407b8caeec966014c8fc()
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

      private sealed class MTHD_61293ce4cd4746eebfca128bc79a3e73 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_61293ce4cd4746eebfca128bc79a3e73()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c3ff1875429d4ba59c593c6fb00c8274 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c3ff1875429d4ba59c593c6fb00c8274()
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

      private sealed class MTHD_6a11414406214edea38b5a536925e913 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6a11414406214edea38b5a536925e913()
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

      private sealed class MTHD_48bba2cd726f439491c2777e5bc35670 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_48bba2cd726f439491c2777e5bc35670()
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

      private sealed class MTHD_c3a7e39238d443f8ab695b6f6e4aa44c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c3a7e39238d443f8ab695b6f6e4aa44c()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_99e12f249d5f4a829132be7047cb82ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99e12f249d5f4a829132be7047cb82ed()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c9e6f5de886d4067a66678503e667bce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c9e6f5de886d4067a66678503e667bce()
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

      private sealed class MTHD_071a03d9642846359aace215187d496f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_071a03d9642846359aace215187d496f()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_3713f82eecd4414a97a511e66affdf3e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3713f82eecd4414a97a511e66affdf3e()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_0ab83376a8e04247bf55a082bde84cb0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ab83376a8e04247bf55a082bde84cb0()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_1c8aa3ce74084157b14f23e317508984 : HardwiredMemberDescriptor
      {
        internal PROP_1c8aa3ce74084157b14f23e317508984()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_06d46f9a24384f34ab69aa893558b3e1 : HardwiredMemberDescriptor
      {
        internal PROP_06d46f9a24384f34ab69aa893558b3e1()
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

      private sealed class PROP_fdaa74c903574b22a8c167fab07abbbe : HardwiredMemberDescriptor
      {
        internal PROP_fdaa74c903574b22a8c167fab07abbbe()
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

      private sealed class PROP_9967bf58d7144b6bb1aa1529c24cc430 : HardwiredMemberDescriptor
      {
        internal PROP_9967bf58d7144b6bb1aa1529c24cc430()
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

      private sealed class PROP_54db1dc1babc40e99d42933d1d98268d : HardwiredMemberDescriptor
      {
        internal PROP_54db1dc1babc40e99d42933d1d98268d()
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

      private sealed class PROP_aea309927ff34f4a87b0d1ba0e9165e1 : HardwiredMemberDescriptor
      {
        internal PROP_aea309927ff34f4a87b0d1ba0e9165e1()
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

      private sealed class PROP_5799dfc14c2845da9101d10a10044fa4 : HardwiredMemberDescriptor
      {
        internal PROP_5799dfc14c2845da9101d10a10044fa4()
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

      private sealed class PROP_7557e1b17d284c02b81e013594126db7 : HardwiredMemberDescriptor
      {
        internal PROP_7557e1b17d284c02b81e013594126db7()
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

      private sealed class PROP_57d5f51c99d14640983b5c0dc44d8175 : HardwiredMemberDescriptor
      {
        internal PROP_57d5f51c99d14640983b5c0dc44d8175()
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

      private sealed class PROP_729f358f13e342f493da205a08d90d0e : HardwiredMemberDescriptor
      {
        internal PROP_729f358f13e342f493da205a08d90d0e()
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

      private sealed class PROP_c16412161ee9482fada060a682e8869e : HardwiredMemberDescriptor
      {
        internal PROP_c16412161ee9482fada060a682e8869e()
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

      private sealed class PROP_b5a4a7913de04507a013831157e65ab7 : HardwiredMemberDescriptor
      {
        internal PROP_b5a4a7913de04507a013831157e65ab7()
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

      private sealed class PROP_1246d60b94cb4dd7960f1f97e84d942d : HardwiredMemberDescriptor
      {
        internal PROP_1246d60b94cb4dd7960f1f97e84d942d()
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

      private sealed class PROP_899313571fd44a14ba10ab3eae52fa0f : HardwiredMemberDescriptor
      {
        internal PROP_899313571fd44a14ba10ab3eae52fa0f()
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

      private sealed class PROP_f7bc82e7a2f34a909142fdef8328c73d : HardwiredMemberDescriptor
      {
        internal PROP_f7bc82e7a2f34a909142fdef8328c73d()
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

      private sealed class PROP_542be457baeb478c866eea91bc14676a : HardwiredMemberDescriptor
      {
        internal PROP_542be457baeb478c866eea91bc14676a()
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

      private sealed class PROP_bbcf7ed05c0740578d5f705122ff1b3a : HardwiredMemberDescriptor
      {
        internal PROP_bbcf7ed05c0740578d5f705122ff1b3a()
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

      private sealed class PROP_1411a83f42fa4030a40834f326a6ddd4 : HardwiredMemberDescriptor
      {
        internal PROP_1411a83f42fa4030a40834f326a6ddd4()
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

      private sealed class PROP_65c54c71061746579f39d9923b920ebb : HardwiredMemberDescriptor
      {
        internal PROP_65c54c71061746579f39d9923b920ebb()
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

      private sealed class PROP_b9a6a66368cb439ca74ccd586840d553 : HardwiredMemberDescriptor
      {
        internal PROP_b9a6a66368cb439ca74ccd586840d553()
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

      private sealed class PROP_9029df7cb7bb4997bc7ebad117e1039e : HardwiredMemberDescriptor
      {
        internal PROP_9029df7cb7bb4997bc7ebad117e1039e()
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

      private sealed class PROP_fb9d6afc7b4d4f839433ca9aabaeba3c : HardwiredMemberDescriptor
      {
        internal PROP_fb9d6afc7b4d4f839433ca9aabaeba3c()
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

      private sealed class PROP_3e310acb46804a7ea9a1b5af84dc6f65 : HardwiredMemberDescriptor
      {
        internal PROP_3e310acb46804a7ea9a1b5af84dc6f65()
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

      private sealed class PROP_4304b6b153c04f01814d51c8111bb079 : HardwiredMemberDescriptor
      {
        internal PROP_4304b6b153c04f01814d51c8111bb079()
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

      private sealed class PROP_c4f60818695343b48bdb695198ea3417 : HardwiredMemberDescriptor
      {
        internal PROP_c4f60818695343b48bdb695198ea3417()
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

      private sealed class FLDV_22b3f5a0eb4f418988f371691fe6882c : HardwiredMemberDescriptor
      {
        internal FLDV_22b3f5a0eb4f418988f371691fe6882c()
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

      private sealed class FLDV_451a11bb89fd4d7494e37dc9386e8efc : HardwiredMemberDescriptor
      {
        internal FLDV_451a11bb89fd4d7494e37dc9386e8efc()
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

      private sealed class FLDV_7ae331d090304e98bbd7196165ed0da6 : HardwiredMemberDescriptor
      {
        internal FLDV_7ae331d090304e98bbd7196165ed0da6()
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

    private sealed class TYPE_350dbeafb22d4e5bb4a4ae729e52cd5e : HardwiredUserDataDescriptor
    {
      internal TYPE_350dbeafb22d4e5bb4a4ae729e52cd5e()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_350dbeafb22d4e5bb4a4ae729e52cd5e.MTHD_3366dabe7a354333adc1eeccd0b77b5f()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_350dbeafb22d4e5bb4a4ae729e52cd5e.MTHD_f57d984de8bd4469a4cccf5338f14eaa()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_350dbeafb22d4e5bb4a4ae729e52cd5e.MTHD_dd9e130096e64615a85c8affb452c662()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_350dbeafb22d4e5bb4a4ae729e52cd5e.MTHD_8b9c9ce2d6934e558026375f8d9f8ae8()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_350dbeafb22d4e5bb4a4ae729e52cd5e.MTHD_dca386bf4f92491289de634e3e8f92dd()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_350dbeafb22d4e5bb4a4ae729e52cd5e.MTHD_cd791905573c4ae4af3d9eeb14944459()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_350dbeafb22d4e5bb4a4ae729e52cd5e.FLDV_bbc00b6ecaa3487d841fc4a844cdeeb3());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_350dbeafb22d4e5bb4a4ae729e52cd5e.FLDV_8600f0b1e07247ec9a49d8e55732dda5());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_350dbeafb22d4e5bb4a4ae729e52cd5e.FLDV_18649e246dbf46a88fa96f3a5195a596());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_350dbeafb22d4e5bb4a4ae729e52cd5e.FLDV_a320f7d8c9244e2ebd71f570762e4024());
      }

      private sealed class MTHD_3366dabe7a354333adc1eeccd0b77b5f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3366dabe7a354333adc1eeccd0b77b5f()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_f57d984de8bd4469a4cccf5338f14eaa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f57d984de8bd4469a4cccf5338f14eaa()
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

      private sealed class MTHD_dd9e130096e64615a85c8affb452c662 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dd9e130096e64615a85c8affb452c662()
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

      private sealed class MTHD_8b9c9ce2d6934e558026375f8d9f8ae8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b9c9ce2d6934e558026375f8d9f8ae8()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_dca386bf4f92491289de634e3e8f92dd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dca386bf4f92491289de634e3e8f92dd()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_cd791905573c4ae4af3d9eeb14944459 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd791905573c4ae4af3d9eeb14944459()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_bbc00b6ecaa3487d841fc4a844cdeeb3 : HardwiredMemberDescriptor
      {
        internal FLDV_bbc00b6ecaa3487d841fc4a844cdeeb3()
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

      private sealed class FLDV_8600f0b1e07247ec9a49d8e55732dda5 : HardwiredMemberDescriptor
      {
        internal FLDV_8600f0b1e07247ec9a49d8e55732dda5()
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

      private sealed class FLDV_18649e246dbf46a88fa96f3a5195a596 : HardwiredMemberDescriptor
      {
        internal FLDV_18649e246dbf46a88fa96f3a5195a596()
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

      private sealed class FLDV_a320f7d8c9244e2ebd71f570762e4024 : HardwiredMemberDescriptor
      {
        internal FLDV_a320f7d8c9244e2ebd71f570762e4024()
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

    private sealed class TYPE_f2298fa4856b46ef8016db69d485523b : HardwiredUserDataDescriptor
    {
      internal TYPE_f2298fa4856b46ef8016db69d485523b()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f2298fa4856b46ef8016db69d485523b.MTHD_89a64f86523a48858ac240bf8b45a158()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f2298fa4856b46ef8016db69d485523b.MTHD_a3cf1eb0eb1c48ec89898341027ffc83()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f2298fa4856b46ef8016db69d485523b.MTHD_aad6da4e2ee34077a53617a5d5d072a7()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f2298fa4856b46ef8016db69d485523b.MTHD_fb56bca389e94fa48d42d21eef005b10()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f2298fa4856b46ef8016db69d485523b.MTHD_0543238501904ac79de7e1d81a2c5877()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_f2298fa4856b46ef8016db69d485523b.FLDV_4dd871e9ac3745ebab5446dfca66e687());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_f2298fa4856b46ef8016db69d485523b.FLDV_24556f02f4eb43d0b3a6a3552350006a());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_f2298fa4856b46ef8016db69d485523b.FLDV_d82eb4fbdb7945a2a8eb92421e70b001());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_f2298fa4856b46ef8016db69d485523b.FLDV_40aceaf06a5040b6bac253b770f3397e());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_f2298fa4856b46ef8016db69d485523b.FLDV_eaea8d6c7df44dceb25c8928128ff7a7());
      }

      private sealed class MTHD_89a64f86523a48858ac240bf8b45a158 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_89a64f86523a48858ac240bf8b45a158()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_a3cf1eb0eb1c48ec89898341027ffc83 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a3cf1eb0eb1c48ec89898341027ffc83()
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

      private sealed class MTHD_aad6da4e2ee34077a53617a5d5d072a7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aad6da4e2ee34077a53617a5d5d072a7()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_fb56bca389e94fa48d42d21eef005b10 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb56bca389e94fa48d42d21eef005b10()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_0543238501904ac79de7e1d81a2c5877 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0543238501904ac79de7e1d81a2c5877()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_4dd871e9ac3745ebab5446dfca66e687 : HardwiredMemberDescriptor
      {
        internal FLDV_4dd871e9ac3745ebab5446dfca66e687()
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

      private sealed class FLDV_24556f02f4eb43d0b3a6a3552350006a : HardwiredMemberDescriptor
      {
        internal FLDV_24556f02f4eb43d0b3a6a3552350006a()
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

      private sealed class FLDV_d82eb4fbdb7945a2a8eb92421e70b001 : HardwiredMemberDescriptor
      {
        internal FLDV_d82eb4fbdb7945a2a8eb92421e70b001()
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

      private sealed class FLDV_40aceaf06a5040b6bac253b770f3397e : HardwiredMemberDescriptor
      {
        internal FLDV_40aceaf06a5040b6bac253b770f3397e()
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

      private sealed class FLDV_eaea8d6c7df44dceb25c8928128ff7a7 : HardwiredMemberDescriptor
      {
        internal FLDV_eaea8d6c7df44dceb25c8928128ff7a7()
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

    private sealed class TYPE_5c557aaeed9f4494a9dccd381abec297 : HardwiredUserDataDescriptor
    {
      internal TYPE_5c557aaeed9f4494a9dccd381abec297()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c557aaeed9f4494a9dccd381abec297.MTHD_e2c1b6aec59a47b9bdd59d6f2b639a24()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c557aaeed9f4494a9dccd381abec297.MTHD_254a84a9a37341e6a3d4dea5be976d2b()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c557aaeed9f4494a9dccd381abec297.MTHD_6ca67e9219ed43d3b6f7c1444f11ebfd()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c557aaeed9f4494a9dccd381abec297.MTHD_ea190131d5f64c0ebf39800a6ea5e65c()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c557aaeed9f4494a9dccd381abec297.MTHD_54daac18c88948c2b60497494e8cfd2e()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c557aaeed9f4494a9dccd381abec297.MTHD_ea43828f5a9d484897da6aaeb53177c4()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c557aaeed9f4494a9dccd381abec297.MTHD_fa29eab2fbe345368ac39a4935c6226e()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c557aaeed9f4494a9dccd381abec297.MTHD_0360b9c72681447b842b084ff6ae2801()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c557aaeed9f4494a9dccd381abec297.MTHD_e60ad31760cf4b2db3f7563c51d3e0d0()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c557aaeed9f4494a9dccd381abec297.MTHD_f748bd87914d46bdaf1bc99d1f6d0eac()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c557aaeed9f4494a9dccd381abec297.MTHD_b2e17483d4bf4ed6a649a0191a211046()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c557aaeed9f4494a9dccd381abec297.MTHD_352fa7e564cb4cc9adb8f6c4fc923723()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5c557aaeed9f4494a9dccd381abec297.MTHD_098d0e49ffec488b99643580d00353a6()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_5c557aaeed9f4494a9dccd381abec297.FLDV_ef76726de1d14903887311b8b498fc79());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_5c557aaeed9f4494a9dccd381abec297.FLDV_5caf2c09d47f4816ba4ee1aa143ac262());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_5c557aaeed9f4494a9dccd381abec297.FLDV_c85764d629a0422a87ff5da540a24f11());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_5c557aaeed9f4494a9dccd381abec297.FLDV_7edd88da3b484539b03271b8c62e77ee());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_5c557aaeed9f4494a9dccd381abec297.FLDV_73867c885c11401f8bb7e57371f9efc5());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_5c557aaeed9f4494a9dccd381abec297.FLDV_a48d8a4cf9fe4d8fae3f6a9a2395286c());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_5c557aaeed9f4494a9dccd381abec297.FLDV_06362b2749954477af04316b51064b73());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_5c557aaeed9f4494a9dccd381abec297.FLDV_c668ac5521fc412abeafc414d8b7c404());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_5c557aaeed9f4494a9dccd381abec297.DVAL_f9c4fcec906a4b2fa546ec8b70eb532d());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_5c557aaeed9f4494a9dccd381abec297.DVAL_1d5d1fbccd914fb3abb65847dd6c8c6c());
      }

      private sealed class MTHD_e2c1b6aec59a47b9bdd59d6f2b639a24 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e2c1b6aec59a47b9bdd59d6f2b639a24()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_254a84a9a37341e6a3d4dea5be976d2b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_254a84a9a37341e6a3d4dea5be976d2b()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_6ca67e9219ed43d3b6f7c1444f11ebfd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ca67e9219ed43d3b6f7c1444f11ebfd()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ea190131d5f64c0ebf39800a6ea5e65c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea190131d5f64c0ebf39800a6ea5e65c()
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

      private sealed class MTHD_54daac18c88948c2b60497494e8cfd2e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_54daac18c88948c2b60497494e8cfd2e()
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

      private sealed class MTHD_ea43828f5a9d484897da6aaeb53177c4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea43828f5a9d484897da6aaeb53177c4()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_fa29eab2fbe345368ac39a4935c6226e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa29eab2fbe345368ac39a4935c6226e()
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

      private sealed class MTHD_0360b9c72681447b842b084ff6ae2801 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0360b9c72681447b842b084ff6ae2801()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_e60ad31760cf4b2db3f7563c51d3e0d0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e60ad31760cf4b2db3f7563c51d3e0d0()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f748bd87914d46bdaf1bc99d1f6d0eac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f748bd87914d46bdaf1bc99d1f6d0eac()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b2e17483d4bf4ed6a649a0191a211046 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b2e17483d4bf4ed6a649a0191a211046()
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

      private sealed class MTHD_352fa7e564cb4cc9adb8f6c4fc923723 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_352fa7e564cb4cc9adb8f6c4fc923723()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_098d0e49ffec488b99643580d00353a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_098d0e49ffec488b99643580d00353a6()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_ef76726de1d14903887311b8b498fc79 : HardwiredMemberDescriptor
      {
        internal FLDV_ef76726de1d14903887311b8b498fc79()
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

      private sealed class FLDV_5caf2c09d47f4816ba4ee1aa143ac262 : HardwiredMemberDescriptor
      {
        internal FLDV_5caf2c09d47f4816ba4ee1aa143ac262()
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

      private sealed class FLDV_c85764d629a0422a87ff5da540a24f11 : HardwiredMemberDescriptor
      {
        internal FLDV_c85764d629a0422a87ff5da540a24f11()
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

      private sealed class FLDV_7edd88da3b484539b03271b8c62e77ee : HardwiredMemberDescriptor
      {
        internal FLDV_7edd88da3b484539b03271b8c62e77ee()
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

      private sealed class FLDV_73867c885c11401f8bb7e57371f9efc5 : HardwiredMemberDescriptor
      {
        internal FLDV_73867c885c11401f8bb7e57371f9efc5()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_a48d8a4cf9fe4d8fae3f6a9a2395286c : HardwiredMemberDescriptor
      {
        internal FLDV_a48d8a4cf9fe4d8fae3f6a9a2395286c()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_06362b2749954477af04316b51064b73 : HardwiredMemberDescriptor
      {
        internal FLDV_06362b2749954477af04316b51064b73()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_c668ac5521fc412abeafc414d8b7c404 : HardwiredMemberDescriptor
      {
        internal FLDV_c668ac5521fc412abeafc414d8b7c404()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_f9c4fcec906a4b2fa546ec8b70eb532d : DynValueMemberDescriptor
      {
        internal DVAL_f9c4fcec906a4b2fa546ec8b70eb532d()
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

      private sealed class DVAL_1d5d1fbccd914fb3abb65847dd6c8c6c : DynValueMemberDescriptor
      {
        internal DVAL_1d5d1fbccd914fb3abb65847dd6c8c6c()
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

    private sealed class TYPE_a82b1667ab364121a9680d24f51e358a : HardwiredUserDataDescriptor
    {
      internal TYPE_a82b1667ab364121a9680d24f51e358a()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a82b1667ab364121a9680d24f51e358a.MTHD_5e202fa6c88c4884ae81567e2356c13c()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a82b1667ab364121a9680d24f51e358a.MTHD_8e45b54aa65449e89303a5f1e954bf7a()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a82b1667ab364121a9680d24f51e358a.MTHD_76893826e2bf44d3ba554bb80eea1e2e(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a82b1667ab364121a9680d24f51e358a.MTHD_6c60fa504d3947fab4cef57350738b53()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a82b1667ab364121a9680d24f51e358a.MTHD_0816508867ad466faf52e2aaa62afe76(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a82b1667ab364121a9680d24f51e358a.MTHD_d7fb614302dd4a51bedfcceebe23fa4d()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a82b1667ab364121a9680d24f51e358a.MTHD_d516519907d54ab9a98f05880a0e5ca5()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a82b1667ab364121a9680d24f51e358a.MTHD_465a77f848594b9aa7b6bb1b3ddbc0a2()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a82b1667ab364121a9680d24f51e358a.MTHD_66a81c3fc2d44f25a3d3a881769ec078()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a82b1667ab364121a9680d24f51e358a.MTHD_eeb46dc5b91444cbb8c3f7e15b0e4094()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_a82b1667ab364121a9680d24f51e358a.FLDV_224fcc0a96a643cea305d5308accacc0());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_a82b1667ab364121a9680d24f51e358a.FLDV_b40b5c7e93ec465b940b9ca0abafa602());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_a82b1667ab364121a9680d24f51e358a.FLDV_f98232731b6545b9a0d1f25e75339acf());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_a82b1667ab364121a9680d24f51e358a.FLDV_c83bbd4a24724729bbce3710bc127ae0());
        this.AddMember("white", (IMemberDescriptor) new Bridge.TYPE_a82b1667ab364121a9680d24f51e358a.FLDV_e33e23b303f44676891b312323b7951d());
      }

      private sealed class MTHD_5e202fa6c88c4884ae81567e2356c13c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e202fa6c88c4884ae81567e2356c13c()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_8e45b54aa65449e89303a5f1e954bf7a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e45b54aa65449e89303a5f1e954bf7a()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_76893826e2bf44d3ba554bb80eea1e2e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76893826e2bf44d3ba554bb80eea1e2e()
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

      private sealed class MTHD_6c60fa504d3947fab4cef57350738b53 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6c60fa504d3947fab4cef57350738b53()
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

      private sealed class MTHD_0816508867ad466faf52e2aaa62afe76 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0816508867ad466faf52e2aaa62afe76()
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

      private sealed class MTHD_d7fb614302dd4a51bedfcceebe23fa4d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d7fb614302dd4a51bedfcceebe23fa4d()
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

      private sealed class MTHD_d516519907d54ab9a98f05880a0e5ca5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d516519907d54ab9a98f05880a0e5ca5()
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

      private sealed class MTHD_465a77f848594b9aa7b6bb1b3ddbc0a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_465a77f848594b9aa7b6bb1b3ddbc0a2()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_66a81c3fc2d44f25a3d3a881769ec078 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_66a81c3fc2d44f25a3d3a881769ec078()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_eeb46dc5b91444cbb8c3f7e15b0e4094 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eeb46dc5b91444cbb8c3f7e15b0e4094()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_224fcc0a96a643cea305d5308accacc0 : HardwiredMemberDescriptor
      {
        internal FLDV_224fcc0a96a643cea305d5308accacc0()
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

      private sealed class FLDV_b40b5c7e93ec465b940b9ca0abafa602 : HardwiredMemberDescriptor
      {
        internal FLDV_b40b5c7e93ec465b940b9ca0abafa602()
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

      private sealed class FLDV_f98232731b6545b9a0d1f25e75339acf : HardwiredMemberDescriptor
      {
        internal FLDV_f98232731b6545b9a0d1f25e75339acf()
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

      private sealed class FLDV_c83bbd4a24724729bbce3710bc127ae0 : HardwiredMemberDescriptor
      {
        internal FLDV_c83bbd4a24724729bbce3710bc127ae0()
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

      private sealed class FLDV_e33e23b303f44676891b312323b7951d : HardwiredMemberDescriptor
      {
        internal FLDV_e33e23b303f44676891b312323b7951d()
          : base(typeof (LuaColor), "white", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) LuaColor.white;
        }
      }
    }

    private sealed class TYPE_f707a9f9b17c42a1a5b70f2692fd47ed : HardwiredUserDataDescriptor
    {
      internal TYPE_f707a9f9b17c42a1a5b70f2692fd47ed()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f707a9f9b17c42a1a5b70f2692fd47ed.MTHD_d1061571303e4a399e98ebdb0ac7e961()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f707a9f9b17c42a1a5b70f2692fd47ed.MTHD_84891b403bd5430e89904330db10f5f2()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f707a9f9b17c42a1a5b70f2692fd47ed.MTHD_bebe902582af4e87bd7946cbd2865e44()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f707a9f9b17c42a1a5b70f2692fd47ed.MTHD_f313ee80310a4fdca835199fb7c5828e()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f707a9f9b17c42a1a5b70f2692fd47ed.MTHD_3aecff9db2c847d0bf1f18ac68662aee()
        }));
      }

      private sealed class MTHD_d1061571303e4a399e98ebdb0ac7e961 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1061571303e4a399e98ebdb0ac7e961()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_84891b403bd5430e89904330db10f5f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84891b403bd5430e89904330db10f5f2()
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

      private sealed class MTHD_bebe902582af4e87bd7946cbd2865e44 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bebe902582af4e87bd7946cbd2865e44()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_f313ee80310a4fdca835199fb7c5828e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f313ee80310a4fdca835199fb7c5828e()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_3aecff9db2c847d0bf1f18ac68662aee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3aecff9db2c847d0bf1f18ac68662aee()
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
