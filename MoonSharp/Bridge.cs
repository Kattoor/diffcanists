
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
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_1d1621ae7eb84ff2bb5672654c3d12a9());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_7aede1466d464dafaf6a4970a1875c8a());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_1f996eb2e5b04f5a9757cd749ba089fd());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_d7272d91ce834b169895e0f063a60bf3());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_f9aa562922044a588b3b57b86ec27d24());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_552193ead99c487d8f6ec9ed1acf055f());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_b37d25832f274bc7b586a244954e25bd());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_829c7964b7c54264b61a9ff48de97f65());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_5d0226ef418346868209b89bb45ae8e5());
    }

    private sealed class TYPE_d917fcf2257c467c90fd3b932902c3a0 : HardwiredUserDataDescriptor
    {
      internal TYPE_d917fcf2257c467c90fd3b932902c3a0()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_3643494a7da24516abb4dd5994d7ec77()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_77e86038e76c4f9a91feb6094ef0bb67()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_c03f22068a9246829b68c007ea85e925()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_8b0ff4e66182473f95a406a0e7c82a4f()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_a74018d964214641a675ad819f524684()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_587e9f67eb624e66a8c46e73205273a9()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_00275f390c294f58ac158182017619fe()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_d35d792e3a984958ad4c82fd33a457b3()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_179fcba127f14df6bd3cc07e684edcd5()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_dc962f483fa541a1b17ee44464c3da6b()
        }));
        this.AddMember("hideInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("hideInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_379b1b46f61440e49bfa995d5ca9ab29()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_34e3c7c7d40a4f108cbe6628a13ae671()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_ca6d78138a59474abd339610c0dc99f2()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_24b5162fe0394d54a50a31c9d9d14412()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_7ada8826ac0749d88039302678be005e()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_8e1584aeb70c40749c4838b1cc4de9c0()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_8cddc1f94e4c4ce3839b1579030996f7()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_6dc2beae14c7423b81cd9545faa36447()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_e947821f6b7947888976baa89fcdd339()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_7f2be54fe7e24106bb71c370c585c5d5()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_d827917cab4a4fd2b3197a3eb86b102a()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_98e3a6881fe64716bcd15d1a0ea3e9a1()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_02fa31e0a2cc480ebd43ce7d1a67f6ae()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_e1fc79c41f6b4ea1aef7d929fb5b2991()
        }));
        this.AddMember("get_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_35fb06b3adc14b22aa2543a0dd49a04b()
        }));
        this.AddMember("set_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_d368e428ef514951b6b08a100c2db3ed()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_5727134f688f4316bfe244d44c5933e8()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_08034326180741f8a10f83ec2f003a96()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_cac648f83c414c2e8fab4a9f0e8160f4()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_474a5c99664b42bcaa123e78ba7f182d()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_2a943007a9d54f118d8b3191022f2a9d()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_6432dbcd8e1a418eb628388f88ef3b8d()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_dd49ecf9cb614cc5a2501e96782b08ee()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_ef3b616635bb4f35b99ea5e8671364f5()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_30694f0245f64f32981dd4d89dbd1955()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_d2c5de61960440599124c5d360bf132d()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_8e8969f019344f3f84513ca55be52255()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_31071df3cb5a4be484a54321067605f7()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_7877876777f5456da0831ae738ed629b()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_1a57b2a74bc441acae0e22d818bc3bec()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_a28cae74638f44718d47437e3dc631c7()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_25b9ca43bd1d4d9f812fcd6f764dce68()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_404a2cda3c25463e9baf932d99d36e9e()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_159ae78de5344fcfb7390bfc60a46b2e()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_61cef9c509144b70878665d7f8e9800d()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_7739d1aaf0704a8ab59e3af0ac2c6692()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_b39d34da64574304b595236a3507df7a()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_d0e8902ec06d4968a4c5a4bff7285612()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_be03fd22656440528e6a582da25ed899()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_7d0769ecdd3b47e7a945423ca7e058ac()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_c1f3a88cf1d14ef99294dfe83eeb6570()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_7ae184c4359c4195abbe252a31831144()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_95fb82407842437f924afd2ba8eb1d00()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_4408a216a73d41848ee45e2f3fc7960f()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_5cde68e8d1a64bb7ab3390129f873397()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_1ab4a170d57f4f02ae5779695c1321fc()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_83935cd005c849a893976c98dc0c9dc0()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_cd50448c7fdd46b9a730c0390463dc10()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_457af4b2a8d6417889cab23d39bbc9e9()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_b5fb030e5aca468ab9727e6c89ff79d3()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_5c4a54d1d59647d2aa12c557893eed6d()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_b5bf687169ab44a4a0f77353627d01bd()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_24eef205b22744fcb0e4e0495cd30b28()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_5896401926304e34948d9fb8c84b7bca()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_795d434b54a84628982054c31838f1fd()
        }));
        this.AddMember("Dispose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Dispose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_f534f0932f084d5fb92cf5de460a8e20()
        }));
        this.AddMember("drawImage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawImage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_4aeb8b21e5694434a74ff976b2edf931()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_f6e71c541a654664b8b1a6dc3825de6d()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_ea2f621e1e77449d8af7a0b6a3c6fc97()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_d33eeaafe33e4bd28c1dc3a7bad259e8()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_36edf20343304acc9f94509cdae5585e()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_a78e71ca4c27408ca4ae5b8c94f943f7()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_893a3467b254470a879cb7b588beace8()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_822eea46f8764b3f845e72dd211d09be()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_87ef8fd8fe7746158df6ef3db8483c70()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_b7bac8a623964cc4aab307688f36a280()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_edf982278bef477ab5e383463409d9df()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_f7dd14af8e154bad8ca06f30be8c2469()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_844e2791beb5407fb90acd33017b6009()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_da6e7e494e454fca94152aa5203935a6()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_a5aed7862a72491f8d1797dbb7de5b3c()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_53a486ba11f54d1ca4a01a315ae74a51()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_eb0444c31ea940b4b8530d85938cd190()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_9255cb9d7ee84d4683d8db383075561e()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_0b6ca7e5200b495e8be86feec0045102()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_3a7981f402ec42c3bf752f1c1642606a()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_6fb1465464344749951e7eba18345eed()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_76eb0a2113254e478946c31fce70ff92()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_77d37d8a4eda43df9b5218239321416f()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_a9e7704c673f4d14b2e8a3c7b20284a5()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_360c174b63464b1fad15d7f7db80404f()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_791d78b5b37c47aaa9ce69f752c2a225()
        }));
        this.AddMember("cameraFollow", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("cameraFollow", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_9d6bd3c7182749b6a45c447da4d6be13()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_24a069ebf32048f68e849bb3117f5dce()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_89c2895fe4994609b0cf0b3ee95eeed1()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_20090087ecbd4f76aeae7d130a37dfb2()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_0bb66e0da621436e8af3a740e41b5e6d()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_0ebf45f664de4f82bf8bbae46387c4b7()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_e1f2a2e8f86849a38db2924f1dd1e003(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_b9234457ef5d454cb535d70ac99ea0bf()
        }));
        this.AddMember("getKeyBinds", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getKeyBinds", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_bd087575038f4b9a9e680bf9772de9f0()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_4173e21e44ee4a4ea622e7eb1380d9ab()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_8a89b579c5084bd9b677684cd353b612()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_8fe0f0aee28942c1bd3fad350b617daf()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.MTHD_b1f84c2dfd924ed78c22ee668f571b3e()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_1e0d73a67c1848888ad72d5692f16f4d());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_aa74549cd25441da8ac01e6cb2eb3f3b());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_deafa31e156c4b6f8533c5e851be271e());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_72b41c8fc7c041739ee36facfed1d7a1());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_8df5e0e5fa69444fbb2ccfa02adc8ede());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_c1f379fca4e2493394b18ab25a31061b());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_16b76f8b928643ab8867f277784ca51d());
        this.AddMember("allowMinionMovement", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_6ca43bbf6fef4ea981201c42c85e5e5c());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_13ce4d0ceed54699b0f8fe54fbf97088());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_ff204f878ef543888fe8c803dd52c4df());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_41a7bc9fc0664de6ad7a128aa5b3b0fb());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_06d6578bf76f4bf1b7cc70fdc06a8bc7());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_d3d3556bfc3244d7aa389c597b989c4a());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_2f61c3a217d44827b23ecc2797b65e9c());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_1f181e1020804b38b28a01cf4d43b0ae());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_51918d5026404a78af0d9b39de6e87d6());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_7a21e5dfeaac4bbda2dce40bea8f77de());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_629b97a39a60490ca65df40bf8694b30());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_1cdde659a85a4cfe9365bc47488d6d60());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_4a43cc7e64d844d8bdc6e6a08755a7da());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_22ea87b7b2a0416f968c8d3be2f54ab4());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_a57b614b75564e84b12fe461aee6dac1());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_3e2c66f4d5d24d2a80596ec87d2624a3());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_72a80142e34b46e295c8c1effc62f0b8());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_e4f00f37758548309c52181a7b6fba4e());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_00428abb669b48358f8cb2270813d78c());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_e2f32e1b10e746f1b4fbe7001d821d4d());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_ad5909fd610543499fb758baa4d5efac());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_90f78f9fe55248499ee8a4d4a176e360());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_144612c9794b45188635e7fd61861aa1());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_196a0bc3151f40db9c4751c0516728aa());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_7ae6cdc9cdc84339b09d73259e817265());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_d917fcf2257c467c90fd3b932902c3a0.PROP_a5e558ed1d3d40969531c15c504d8d11());
      }

      private sealed class MTHD_3643494a7da24516abb4dd5994d7ec77 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3643494a7da24516abb4dd5994d7ec77()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_77e86038e76c4f9a91feb6094ef0bb67 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_77e86038e76c4f9a91feb6094ef0bb67()
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

      private sealed class MTHD_c03f22068a9246829b68c007ea85e925 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c03f22068a9246829b68c007ea85e925()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_8b0ff4e66182473f95a406a0e7c82a4f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b0ff4e66182473f95a406a0e7c82a4f()
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

      private sealed class MTHD_a74018d964214641a675ad819f524684 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a74018d964214641a675ad819f524684()
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

      private sealed class MTHD_587e9f67eb624e66a8c46e73205273a9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_587e9f67eb624e66a8c46e73205273a9()
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

      private sealed class MTHD_00275f390c294f58ac158182017619fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_00275f390c294f58ac158182017619fe()
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

      private sealed class MTHD_d35d792e3a984958ad4c82fd33a457b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d35d792e3a984958ad4c82fd33a457b3()
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

      private sealed class MTHD_179fcba127f14df6bd3cc07e684edcd5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_179fcba127f14df6bd3cc07e684edcd5()
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

      private sealed class MTHD_dc962f483fa541a1b17ee44464c3da6b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc962f483fa541a1b17ee44464c3da6b()
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

      private sealed class MTHD_379b1b46f61440e49bfa995d5ca9ab29 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_379b1b46f61440e49bfa995d5ca9ab29()
        {
          this.Initialize("hideInfo", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).hideInfo();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_34e3c7c7d40a4f108cbe6628a13ae671 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_34e3c7c7d40a4f108cbe6628a13ae671()
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

      private sealed class MTHD_ca6d78138a59474abd339610c0dc99f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ca6d78138a59474abd339610c0dc99f2()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_24b5162fe0394d54a50a31c9d9d14412 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24b5162fe0394d54a50a31c9d9d14412()
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

      private sealed class MTHD_7ada8826ac0749d88039302678be005e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ada8826ac0749d88039302678be005e()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_8e1584aeb70c40749c4838b1cc4de9c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e1584aeb70c40749c4838b1cc4de9c0()
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

      private sealed class MTHD_8cddc1f94e4c4ce3839b1579030996f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8cddc1f94e4c4ce3839b1579030996f7()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_6dc2beae14c7423b81cd9545faa36447 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6dc2beae14c7423b81cd9545faa36447()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_e947821f6b7947888976baa89fcdd339 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e947821f6b7947888976baa89fcdd339()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_7f2be54fe7e24106bb71c370c585c5d5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f2be54fe7e24106bb71c370c585c5d5()
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

      private sealed class MTHD_d827917cab4a4fd2b3197a3eb86b102a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d827917cab4a4fd2b3197a3eb86b102a()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_98e3a6881fe64716bcd15d1a0ea3e9a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_98e3a6881fe64716bcd15d1a0ea3e9a1()
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

      private sealed class MTHD_02fa31e0a2cc480ebd43ce7d1a67f6ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_02fa31e0a2cc480ebd43ce7d1a67f6ae()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_e1fc79c41f6b4ea1aef7d929fb5b2991 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e1fc79c41f6b4ea1aef7d929fb5b2991()
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

      private sealed class MTHD_35fb06b3adc14b22aa2543a0dd49a04b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35fb06b3adc14b22aa2543a0dd49a04b()
        {
          this.Initialize("get_allowMinionMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMinionMovement;
        }
      }

      private sealed class MTHD_d368e428ef514951b6b08a100c2db3ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d368e428ef514951b6b08a100c2db3ed()
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

      private sealed class MTHD_5727134f688f4316bfe244d44c5933e8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5727134f688f4316bfe244d44c5933e8()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_08034326180741f8a10f83ec2f003a96 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_08034326180741f8a10f83ec2f003a96()
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

      private sealed class MTHD_cac648f83c414c2e8fab4a9f0e8160f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cac648f83c414c2e8fab4a9f0e8160f4()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_474a5c99664b42bcaa123e78ba7f182d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_474a5c99664b42bcaa123e78ba7f182d()
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

      private sealed class MTHD_2a943007a9d54f118d8b3191022f2a9d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a943007a9d54f118d8b3191022f2a9d()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_6432dbcd8e1a418eb628388f88ef3b8d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6432dbcd8e1a418eb628388f88ef3b8d()
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

      private sealed class MTHD_dd49ecf9cb614cc5a2501e96782b08ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dd49ecf9cb614cc5a2501e96782b08ee()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_ef3b616635bb4f35b99ea5e8671364f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef3b616635bb4f35b99ea5e8671364f5()
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

      private sealed class MTHD_30694f0245f64f32981dd4d89dbd1955 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_30694f0245f64f32981dd4d89dbd1955()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_d2c5de61960440599124c5d360bf132d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d2c5de61960440599124c5d360bf132d()
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

      private sealed class MTHD_8e8969f019344f3f84513ca55be52255 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e8969f019344f3f84513ca55be52255()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_31071df3cb5a4be484a54321067605f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_31071df3cb5a4be484a54321067605f7()
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

      private sealed class MTHD_7877876777f5456da0831ae738ed629b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7877876777f5456da0831ae738ed629b()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_1a57b2a74bc441acae0e22d818bc3bec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a57b2a74bc441acae0e22d818bc3bec()
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

      private sealed class MTHD_a28cae74638f44718d47437e3dc631c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a28cae74638f44718d47437e3dc631c7()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_25b9ca43bd1d4d9f812fcd6f764dce68 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_25b9ca43bd1d4d9f812fcd6f764dce68()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_404a2cda3c25463e9baf932d99d36e9e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_404a2cda3c25463e9baf932d99d36e9e()
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

      private sealed class MTHD_159ae78de5344fcfb7390bfc60a46b2e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_159ae78de5344fcfb7390bfc60a46b2e()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_61cef9c509144b70878665d7f8e9800d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_61cef9c509144b70878665d7f8e9800d()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_7739d1aaf0704a8ab59e3af0ac2c6692 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7739d1aaf0704a8ab59e3af0ac2c6692()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_b39d34da64574304b595236a3507df7a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b39d34da64574304b595236a3507df7a()
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

      private sealed class MTHD_d0e8902ec06d4968a4c5a4bff7285612 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0e8902ec06d4968a4c5a4bff7285612()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_be03fd22656440528e6a582da25ed899 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be03fd22656440528e6a582da25ed899()
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

      private sealed class MTHD_7d0769ecdd3b47e7a945423ca7e058ac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7d0769ecdd3b47e7a945423ca7e058ac()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_c1f3a88cf1d14ef99294dfe83eeb6570 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c1f3a88cf1d14ef99294dfe83eeb6570()
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

      private sealed class MTHD_7ae184c4359c4195abbe252a31831144 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ae184c4359c4195abbe252a31831144()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_95fb82407842437f924afd2ba8eb1d00 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95fb82407842437f924afd2ba8eb1d00()
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

      private sealed class MTHD_4408a216a73d41848ee45e2f3fc7960f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4408a216a73d41848ee45e2f3fc7960f()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_5cde68e8d1a64bb7ab3390129f873397 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5cde68e8d1a64bb7ab3390129f873397()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_1ab4a170d57f4f02ae5779695c1321fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ab4a170d57f4f02ae5779695c1321fc()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_83935cd005c849a893976c98dc0c9dc0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_83935cd005c849a893976c98dc0c9dc0()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_cd50448c7fdd46b9a730c0390463dc10 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd50448c7fdd46b9a730c0390463dc10()
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

      private sealed class MTHD_457af4b2a8d6417889cab23d39bbc9e9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_457af4b2a8d6417889cab23d39bbc9e9()
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

      private sealed class MTHD_b5fb030e5aca468ab9727e6c89ff79d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b5fb030e5aca468ab9727e6c89ff79d3()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_5c4a54d1d59647d2aa12c557893eed6d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c4a54d1d59647d2aa12c557893eed6d()
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

      private sealed class MTHD_b5bf687169ab44a4a0f77353627d01bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b5bf687169ab44a4a0f77353627d01bd()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_24eef205b22744fcb0e4e0495cd30b28 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24eef205b22744fcb0e4e0495cd30b28()
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

      private sealed class MTHD_5896401926304e34948d9fb8c84b7bca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5896401926304e34948d9fb8c84b7bca()
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

      private sealed class MTHD_795d434b54a84628982054c31838f1fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_795d434b54a84628982054c31838f1fd()
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

      private sealed class MTHD_f534f0932f084d5fb92cf5de460a8e20 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f534f0932f084d5fb92cf5de460a8e20()
        {
          this.Initialize("Dispose", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ContainerGame.Dispose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_4aeb8b21e5694434a74ff976b2edf931 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4aeb8b21e5694434a74ff976b2edf931()
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

      private sealed class MTHD_f6e71c541a654664b8b1a6dc3825de6d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f6e71c541a654664b8b1a6dc3825de6d()
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

      private sealed class MTHD_ea2f621e1e77449d8af7a0b6a3c6fc97 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea2f621e1e77449d8af7a0b6a3c6fc97()
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

      private sealed class MTHD_d33eeaafe33e4bd28c1dc3a7bad259e8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d33eeaafe33e4bd28c1dc3a7bad259e8()
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

      private sealed class MTHD_36edf20343304acc9f94509cdae5585e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_36edf20343304acc9f94509cdae5585e()
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

      private sealed class MTHD_a78e71ca4c27408ca4ae5b8c94f943f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a78e71ca4c27408ca4ae5b8c94f943f7()
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

      private sealed class MTHD_893a3467b254470a879cb7b588beace8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_893a3467b254470a879cb7b588beace8()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_822eea46f8764b3f845e72dd211d09be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_822eea46f8764b3f845e72dd211d09be()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_87ef8fd8fe7746158df6ef3db8483c70 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_87ef8fd8fe7746158df6ef3db8483c70()
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

      private sealed class MTHD_b7bac8a623964cc4aab307688f36a280 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b7bac8a623964cc4aab307688f36a280()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_edf982278bef477ab5e383463409d9df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_edf982278bef477ab5e383463409d9df()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f7dd14af8e154bad8ca06f30be8c2469 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7dd14af8e154bad8ca06f30be8c2469()
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

      private sealed class MTHD_844e2791beb5407fb90acd33017b6009 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_844e2791beb5407fb90acd33017b6009()
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

      private sealed class MTHD_da6e7e494e454fca94152aa5203935a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_da6e7e494e454fca94152aa5203935a6()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_a5aed7862a72491f8d1797dbb7de5b3c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a5aed7862a72491f8d1797dbb7de5b3c()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_53a486ba11f54d1ca4a01a315ae74a51 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_53a486ba11f54d1ca4a01a315ae74a51()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_eb0444c31ea940b4b8530d85938cd190 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb0444c31ea940b4b8530d85938cd190()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9255cb9d7ee84d4683d8db383075561e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9255cb9d7ee84d4683d8db383075561e()
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

      private sealed class MTHD_0b6ca7e5200b495e8be86feec0045102 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b6ca7e5200b495e8be86feec0045102()
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

      private sealed class MTHD_3a7981f402ec42c3bf752f1c1642606a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3a7981f402ec42c3bf752f1c1642606a()
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

      private sealed class MTHD_6fb1465464344749951e7eba18345eed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6fb1465464344749951e7eba18345eed()
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

      private sealed class MTHD_76eb0a2113254e478946c31fce70ff92 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76eb0a2113254e478946c31fce70ff92()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_77d37d8a4eda43df9b5218239321416f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_77d37d8a4eda43df9b5218239321416f()
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

      private sealed class MTHD_a9e7704c673f4d14b2e8a3c7b20284a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a9e7704c673f4d14b2e8a3c7b20284a5()
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

      private sealed class MTHD_360c174b63464b1fad15d7f7db80404f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_360c174b63464b1fad15d7f7db80404f()
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

      private sealed class MTHD_791d78b5b37c47aaa9ce69f752c2a225 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_791d78b5b37c47aaa9ce69f752c2a225()
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

      private sealed class MTHD_9d6bd3c7182749b6a45c447da4d6be13 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d6bd3c7182749b6a45c447da4d6be13()
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

      private sealed class MTHD_24a069ebf32048f68e849bb3117f5dce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24a069ebf32048f68e849bb3117f5dce()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_89c2895fe4994609b0cf0b3ee95eeed1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_89c2895fe4994609b0cf0b3ee95eeed1()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_20090087ecbd4f76aeae7d130a37dfb2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_20090087ecbd4f76aeae7d130a37dfb2()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_0bb66e0da621436e8af3a740e41b5e6d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0bb66e0da621436e8af3a740e41b5e6d()
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

      private sealed class MTHD_0ebf45f664de4f82bf8bbae46387c4b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ebf45f664de4f82bf8bbae46387c4b7()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_e1f2a2e8f86849a38db2924f1dd1e003 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e1f2a2e8f86849a38db2924f1dd1e003()
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

      private sealed class MTHD_b9234457ef5d454cb535d70ac99ea0bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b9234457ef5d454cb535d70ac99ea0bf()
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

      private sealed class MTHD_bd087575038f4b9a9e680bf9772de9f0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd087575038f4b9a9e680bf9772de9f0()
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

      private sealed class MTHD_4173e21e44ee4a4ea622e7eb1380d9ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4173e21e44ee4a4ea622e7eb1380d9ab()
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

      private sealed class MTHD_8a89b579c5084bd9b677684cd353b612 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a89b579c5084bd9b677684cd353b612()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_8fe0f0aee28942c1bd3fad350b617daf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8fe0f0aee28942c1bd3fad350b617daf()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_b1f84c2dfd924ed78c22ee668f571b3e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b1f84c2dfd924ed78c22ee668f571b3e()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_1e0d73a67c1848888ad72d5692f16f4d : HardwiredMemberDescriptor
      {
        internal PROP_1e0d73a67c1848888ad72d5692f16f4d()
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

      private sealed class PROP_aa74549cd25441da8ac01e6cb2eb3f3b : HardwiredMemberDescriptor
      {
        internal PROP_aa74549cd25441da8ac01e6cb2eb3f3b()
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

      private sealed class PROP_deafa31e156c4b6f8533c5e851be271e : HardwiredMemberDescriptor
      {
        internal PROP_deafa31e156c4b6f8533c5e851be271e()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_72b41c8fc7c041739ee36facfed1d7a1 : HardwiredMemberDescriptor
      {
        internal PROP_72b41c8fc7c041739ee36facfed1d7a1()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_8df5e0e5fa69444fbb2ccfa02adc8ede : HardwiredMemberDescriptor
      {
        internal PROP_8df5e0e5fa69444fbb2ccfa02adc8ede()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_c1f379fca4e2493394b18ab25a31061b : HardwiredMemberDescriptor
      {
        internal PROP_c1f379fca4e2493394b18ab25a31061b()
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

      private sealed class PROP_16b76f8b928643ab8867f277784ca51d : HardwiredMemberDescriptor
      {
        internal PROP_16b76f8b928643ab8867f277784ca51d()
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

      private sealed class PROP_6ca43bbf6fef4ea981201c42c85e5e5c : HardwiredMemberDescriptor
      {
        internal PROP_6ca43bbf6fef4ea981201c42c85e5e5c()
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

      private sealed class PROP_13ce4d0ceed54699b0f8fe54fbf97088 : HardwiredMemberDescriptor
      {
        internal PROP_13ce4d0ceed54699b0f8fe54fbf97088()
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

      private sealed class PROP_ff204f878ef543888fe8c803dd52c4df : HardwiredMemberDescriptor
      {
        internal PROP_ff204f878ef543888fe8c803dd52c4df()
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

      private sealed class PROP_41a7bc9fc0664de6ad7a128aa5b3b0fb : HardwiredMemberDescriptor
      {
        internal PROP_41a7bc9fc0664de6ad7a128aa5b3b0fb()
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

      private sealed class PROP_06d6578bf76f4bf1b7cc70fdc06a8bc7 : HardwiredMemberDescriptor
      {
        internal PROP_06d6578bf76f4bf1b7cc70fdc06a8bc7()
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

      private sealed class PROP_d3d3556bfc3244d7aa389c597b989c4a : HardwiredMemberDescriptor
      {
        internal PROP_d3d3556bfc3244d7aa389c597b989c4a()
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

      private sealed class PROP_2f61c3a217d44827b23ecc2797b65e9c : HardwiredMemberDescriptor
      {
        internal PROP_2f61c3a217d44827b23ecc2797b65e9c()
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

      private sealed class PROP_1f181e1020804b38b28a01cf4d43b0ae : HardwiredMemberDescriptor
      {
        internal PROP_1f181e1020804b38b28a01cf4d43b0ae()
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

      private sealed class PROP_51918d5026404a78af0d9b39de6e87d6 : HardwiredMemberDescriptor
      {
        internal PROP_51918d5026404a78af0d9b39de6e87d6()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_7a21e5dfeaac4bbda2dce40bea8f77de : HardwiredMemberDescriptor
      {
        internal PROP_7a21e5dfeaac4bbda2dce40bea8f77de()
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

      private sealed class PROP_629b97a39a60490ca65df40bf8694b30 : HardwiredMemberDescriptor
      {
        internal PROP_629b97a39a60490ca65df40bf8694b30()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_1cdde659a85a4cfe9365bc47488d6d60 : HardwiredMemberDescriptor
      {
        internal PROP_1cdde659a85a4cfe9365bc47488d6d60()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_4a43cc7e64d844d8bdc6e6a08755a7da : HardwiredMemberDescriptor
      {
        internal PROP_4a43cc7e64d844d8bdc6e6a08755a7da()
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

      private sealed class PROP_22ea87b7b2a0416f968c8d3be2f54ab4 : HardwiredMemberDescriptor
      {
        internal PROP_22ea87b7b2a0416f968c8d3be2f54ab4()
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

      private sealed class PROP_a57b614b75564e84b12fe461aee6dac1 : HardwiredMemberDescriptor
      {
        internal PROP_a57b614b75564e84b12fe461aee6dac1()
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

      private sealed class PROP_3e2c66f4d5d24d2a80596ec87d2624a3 : HardwiredMemberDescriptor
      {
        internal PROP_3e2c66f4d5d24d2a80596ec87d2624a3()
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

      private sealed class PROP_72a80142e34b46e295c8c1effc62f0b8 : HardwiredMemberDescriptor
      {
        internal PROP_72a80142e34b46e295c8c1effc62f0b8()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_e4f00f37758548309c52181a7b6fba4e : HardwiredMemberDescriptor
      {
        internal PROP_e4f00f37758548309c52181a7b6fba4e()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_00428abb669b48358f8cb2270813d78c : HardwiredMemberDescriptor
      {
        internal PROP_00428abb669b48358f8cb2270813d78c()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_e2f32e1b10e746f1b4fbe7001d821d4d : HardwiredMemberDescriptor
      {
        internal PROP_e2f32e1b10e746f1b4fbe7001d821d4d()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_ad5909fd610543499fb758baa4d5efac : HardwiredMemberDescriptor
      {
        internal PROP_ad5909fd610543499fb758baa4d5efac()
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

      private sealed class PROP_90f78f9fe55248499ee8a4d4a176e360 : HardwiredMemberDescriptor
      {
        internal PROP_90f78f9fe55248499ee8a4d4a176e360()
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

      private sealed class PROP_144612c9794b45188635e7fd61861aa1 : HardwiredMemberDescriptor
      {
        internal PROP_144612c9794b45188635e7fd61861aa1()
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

      private sealed class PROP_196a0bc3151f40db9c4751c0516728aa : HardwiredMemberDescriptor
      {
        internal PROP_196a0bc3151f40db9c4751c0516728aa()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_7ae6cdc9cdc84339b09d73259e817265 : HardwiredMemberDescriptor
      {
        internal PROP_7ae6cdc9cdc84339b09d73259e817265()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_a5e558ed1d3d40969531c15c504d8d11 : HardwiredMemberDescriptor
      {
        internal PROP_a5e558ed1d3d40969531c15c504d8d11()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_1d1621ae7eb84ff2bb5672654c3d12a9 : HardwiredUserDataDescriptor
    {
      internal TYPE_1d1621ae7eb84ff2bb5672654c3d12a9()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1d1621ae7eb84ff2bb5672654c3d12a9.MTHD_3d00305454f14bf3925ba7fbb6c5c79b()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1d1621ae7eb84ff2bb5672654c3d12a9.MTHD_cbd55b5cda9749f986dc75ee62524d4a()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1d1621ae7eb84ff2bb5672654c3d12a9.MTHD_4c3e6d7943c847508dd8f2f841ecde75()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1d1621ae7eb84ff2bb5672654c3d12a9.MTHD_04d667954fc9431ea7ecc9c854a79439()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1d1621ae7eb84ff2bb5672654c3d12a9.MTHD_5d71f5c468f24655aa263e0b553cc24a()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1d1621ae7eb84ff2bb5672654c3d12a9.MTHD_468cb78372b44471916e96863cb81971()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1d1621ae7eb84ff2bb5672654c3d12a9.MTHD_335b79e3819e4340a3c00cee6a477ed1()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1d1621ae7eb84ff2bb5672654c3d12a9.MTHD_2cd8c533be12440c8c7dc74f9a5d4326()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1d1621ae7eb84ff2bb5672654c3d12a9.MTHD_9ba6847f54ed499da81a47fe6cfad250()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1d1621ae7eb84ff2bb5672654c3d12a9.MTHD_171370c9c8a142b3bb64a3704b35af2b()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1d1621ae7eb84ff2bb5672654c3d12a9.MTHD_2385c32dabe6462a869db157e8684d5f()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1d1621ae7eb84ff2bb5672654c3d12a9.MTHD_98e6b34706fd45abaf6b529a9e4d0ea4()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_1d1621ae7eb84ff2bb5672654c3d12a9.PROP_3c7a6c81fe0d4c88a2532869e268e568());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_1d1621ae7eb84ff2bb5672654c3d12a9.PROP_6379d38f42014016845e7e1dad377094());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_1d1621ae7eb84ff2bb5672654c3d12a9.PROP_f5179e36cc9b49c0ac0c6a3ccf0269fd());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_1d1621ae7eb84ff2bb5672654c3d12a9.PROP_3615d4074a16414fb3a0f16d53e4ca56());
      }

      private sealed class MTHD_3d00305454f14bf3925ba7fbb6c5c79b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d00305454f14bf3925ba7fbb6c5c79b()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_cbd55b5cda9749f986dc75ee62524d4a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cbd55b5cda9749f986dc75ee62524d4a()
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

      private sealed class MTHD_4c3e6d7943c847508dd8f2f841ecde75 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c3e6d7943c847508dd8f2f841ecde75()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_04d667954fc9431ea7ecc9c854a79439 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_04d667954fc9431ea7ecc9c854a79439()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_5d71f5c468f24655aa263e0b553cc24a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d71f5c468f24655aa263e0b553cc24a()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_468cb78372b44471916e96863cb81971 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_468cb78372b44471916e96863cb81971()
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

      private sealed class MTHD_335b79e3819e4340a3c00cee6a477ed1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_335b79e3819e4340a3c00cee6a477ed1()
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

      private sealed class MTHD_2cd8c533be12440c8c7dc74f9a5d4326 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2cd8c533be12440c8c7dc74f9a5d4326()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_9ba6847f54ed499da81a47fe6cfad250 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ba6847f54ed499da81a47fe6cfad250()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_171370c9c8a142b3bb64a3704b35af2b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_171370c9c8a142b3bb64a3704b35af2b()
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

      private sealed class MTHD_2385c32dabe6462a869db157e8684d5f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2385c32dabe6462a869db157e8684d5f()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_98e6b34706fd45abaf6b529a9e4d0ea4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_98e6b34706fd45abaf6b529a9e4d0ea4()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_3c7a6c81fe0d4c88a2532869e268e568 : HardwiredMemberDescriptor
      {
        internal PROP_3c7a6c81fe0d4c88a2532869e268e568()
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

      private sealed class PROP_6379d38f42014016845e7e1dad377094 : HardwiredMemberDescriptor
      {
        internal PROP_6379d38f42014016845e7e1dad377094()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_f5179e36cc9b49c0ac0c6a3ccf0269fd : HardwiredMemberDescriptor
      {
        internal PROP_f5179e36cc9b49c0ac0c6a3ccf0269fd()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_3615d4074a16414fb3a0f16d53e4ca56 : HardwiredMemberDescriptor
      {
        internal PROP_3615d4074a16414fb3a0f16d53e4ca56()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_d010158b86b949cab06c9f76bc8f70a7 : HardwiredUserDataDescriptor
    {
      internal TYPE_d010158b86b949cab06c9f76bc8f70a7()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_e21f934f11914cfcb1fd65f8faa17a95()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_3f5967d69a394df5aa928f4509960552()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_2371d427738543deb5bdcef997f91b3a()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_97a1fdd68b8f4c48bbca5a4d405219db()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_8ad24e8660c24245b19c5e528ce02539()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_d1a96da5b66148538d08d89053f5cf8d()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_c0aca0357ac245689cd6585accdfc741()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_7b8858033aa54fe69fe128570da4f519()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_cc7c44f456f54db7af3c7ab1c718551f()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_ac4e2b75996a42b6b6f89d76600128cd()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_210444c4141e4477a02ed894f7aeb1b0()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_47c7e3d57b6d41c6976270ed8138678f()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_95e2a6ed6a9b4fc4af6a1144118a7298()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_a8278ad99c5f4faa9d83a45e4284010b()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_b7b6797bc86f416b95fe89afe5bf4e2c()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_ba6817e88aab4f29ab147d05af4de91c()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_882c7e258b5e4283aa436370d56513f4()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_233da4d614114cc3b701de7d51f3e0f0()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_041761748b764fe8b94bc59cac1ac678()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_67f02df773994ca3aea6d5f827fc2a55()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_e1e13befadbb43cfb2e0de2e15c96177()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_ce99e47e9c044f01bbc2317a333acd4f()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_67e68fb9d440409f8a8eca97854e91b4()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_3321624b345842cc83a58d28d593d43f()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_1f53a1f8b82347c1abb5db96a8e68d24()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_fdbd5f9bd57a4276a4ac0e1a255db49c()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_17ede51b7b9d45fb8b2f3c223bf4dd41()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_3cd34aa0dbf24606a286225d58564127()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_7b729e8fd2534fb9a4c04d13872fea73()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_e20c233f07b54dbbb10334bcc011bce6()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_8b98933e0ab843c7b4c79e0fff60de64()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_9b7b2713ea9c4ee39287be488530f7e2()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_484b76f1c0eb4a4fa415a04db96b65f1()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_452c2cc7c7814caf96e84aed99e85cfb()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_46be8f97bfe1427384f6b2608b47a2b7()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_c8e75c99ed73425b8798b0ce242737e6()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_7333f626f82b4ee8a6058e5e47829d7c()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_322dbdb03ac3497aaed49eedade7d6f9()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_4aad1413c7c941889c5dfbf8dc9b8ba4()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_cbc9020a87e2486dbe4ec88924aeea9d()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_1d54416804394a6e930c0d9f62428d8e()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_b190bf6cd4994e0bacd543ea9bd11123()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_b59f2c0b713a481d9821a67ec9df0f59()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_033dc91bb6584be0ab6645be7ae5c1b2()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_14951b0c4664449b8cfc8d51b27887ad()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_a30ce2018b3849139093364e660cd772()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_f5922bbfbe404f09b1ee37b70de16b6a()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_8630327e7da04bd9a28c7ba01251eb53()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_fc9bd8f5683449ffa0eb5eb8c19fd67d()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_9c4c4f92e528432285b4c9f21bd960cf()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_5bfd40cdca194eff988fc139a1dc2476()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_d7fa0d95e85442f883ecdcf614c80a7e()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_241408f514a64d58b93b638d7406d157()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_5fc03a1ad3d9406988f201f37ecb0f7d()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_f90709628af940cc9def7c9b7620c9c7()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_3e5dec568ec64ed5b1fd35874eb2a841()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_3bbf6e9dcc9b430d85024944232a457d()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_c579a430b5e34565a4fd6c26a69d1031()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_2e6ba9448b92419cb399a8362436dfe0()
        }));
        this.AddMember("getDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_a7d01ce7244b4e04bfd62bc96e207a69()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_b3f778a8051342f9946f32d0b895aeea()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_5ebd0e76178c4d3d85e2a73441df56f6()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_a26b26a7c333417d972762170047a217()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_0d8d5fee4b114d8ab90eaffa3c049399()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_c382697c27114d80bcf963a923651a8a(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_9b1992146fea432f8406a6922c75f141()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_22a47e8e2ce44eaba2bf8bec26403e31(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_8628cd4cfd8e4f76826d5cbda9d495b6()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_3e8c17d738d04918a913c466ebcb3c65()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_97f91dd9b6e04ea890f36a50e7873293()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_04ae908695fc406c9a81960435e5718e(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_68b2716a62944339bdf04cebafa65ce7()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_508a5525d8d1451491c3fd312650a934()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_2ea5f442b4924bb69ef8a300d38ea101()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_cac70fd64b9a45b19a91f7421644767e()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_4c7ccb401bdf40778ccb8c96cd634e77()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_28ffe941e534425391a65df0401bc5fd()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_967066feb9374020960c9410495a9cd6()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_03b50d472a8448d2b2fb6fa4de777dde()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_fca170bf2dcc4bf084697919003b2ae1()
        }));
        this.AddMember("angleToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("angleToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_46c507adcf154f20a6d53dcff8dadbca()
        }));
        this.AddMember("powerToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("powerToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_691e84846e764f0aa5247167c8155e85()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_ae98221d0dd04eaead79b20c1ea10790(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_b80807ad71874848836070334deb7c8e()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_bd27c99ea22a49c99394c44192756308(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_322d98178a64431780e4cbe57f5a3f60()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_248f3c9bc5604550a7824a26f6e13023()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_48c69a8a9a0c47e9a5e6163849380eb3()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_fde1c80169c844b1a2c2ebf3f20f4015()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_a8a0ad0b378c4ebebf51243665591064()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_f79783e48185492ba88cb1cf897fe93f()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.MTHD_a1ef83f9631d4d6ba2319ddbb20ee6e1()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_36dd4c683b0048318cb30ae8928c646c());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_921ee27dded248149c693bd757228ff7());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_81fce29aa26348aaa6968be7e59da222());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_f3a7576225b84903be24eef00328aa90());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_12eb743d47b04dd5bcd752ec8c66f586());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_4df444346c4d41019019fb1c91233866());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_50fe9da8d0f3431dad9af1ab311bb637());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_4e988a39d2cb433ea8d09a45f421a317());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_54f7cf95d766465ea6affb893bff8b38());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_308bdbfc87ea4a7896d1e1f36f259c0b());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_b85443cfe1b240779a53fdb9b58b0ee7());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_00dc0e485b894f64b8c09ba10340230e());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_d47f19a817944911b21ed8f130a47947());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_7e6f37f96d0c4a68a06f8078855e06c3());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_b0e4b03f91c94aa79158eff13bb3b7be());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_100ca5d4ff934979938d142b85600445());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_efc03c064d9c4628852918d9f5b04226());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_cd9f4688297c438fa69b6350aced7130());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_3d8e5950310d416197a9b8e5e7786a04());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_f32d5b3bfbec492292647303e28d01df());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_451aa7440c4f48ea9b848e675ec36a23());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_91bf02feb48c4b369d5c3ca32a5d4662());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_fac64a978bad4250a6bda3eb9d79a2e5());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_24a8de70e473479d88345c73e3755eb3());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_687a167752bc43839c81b5b01460fae2());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_584dd6b2353d40ca841e53f37e1b7531());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_9d4293b5cfbc467392283796cc41d3e6());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_8ed973d495e941a896bdf6a4e419155d());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_63ebb1f112d14544bcd17cbca3a71a7c());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_cb0d8314237a4f46b4093771aeed7c81());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_c79b400fa2fc4156a534968b65ae7990());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_82c31d96d8c94af99f650dd0a77bc104());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_d010158b86b949cab06c9f76bc8f70a7.PROP_c52985c1c38041deb4f1f2a43f6d8567());
      }

      private sealed class MTHD_e21f934f11914cfcb1fd65f8faa17a95 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e21f934f11914cfcb1fd65f8faa17a95()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_3f5967d69a394df5aa928f4509960552 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f5967d69a394df5aa928f4509960552()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_2371d427738543deb5bdcef997f91b3a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2371d427738543deb5bdcef997f91b3a()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_97a1fdd68b8f4c48bbca5a4d405219db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97a1fdd68b8f4c48bbca5a4d405219db()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_8ad24e8660c24245b19c5e528ce02539 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ad24e8660c24245b19c5e528ce02539()
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

      private sealed class MTHD_d1a96da5b66148538d08d89053f5cf8d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1a96da5b66148538d08d89053f5cf8d()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_c0aca0357ac245689cd6585accdfc741 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c0aca0357ac245689cd6585accdfc741()
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

      private sealed class MTHD_7b8858033aa54fe69fe128570da4f519 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b8858033aa54fe69fe128570da4f519()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_cc7c44f456f54db7af3c7ab1c718551f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cc7c44f456f54db7af3c7ab1c718551f()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_ac4e2b75996a42b6b6f89d76600128cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac4e2b75996a42b6b6f89d76600128cd()
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

      private sealed class MTHD_210444c4141e4477a02ed894f7aeb1b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_210444c4141e4477a02ed894f7aeb1b0()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_47c7e3d57b6d41c6976270ed8138678f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_47c7e3d57b6d41c6976270ed8138678f()
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

      private sealed class MTHD_95e2a6ed6a9b4fc4af6a1144118a7298 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95e2a6ed6a9b4fc4af6a1144118a7298()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_a8278ad99c5f4faa9d83a45e4284010b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a8278ad99c5f4faa9d83a45e4284010b()
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

      private sealed class MTHD_b7b6797bc86f416b95fe89afe5bf4e2c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b7b6797bc86f416b95fe89afe5bf4e2c()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_ba6817e88aab4f29ab147d05af4de91c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba6817e88aab4f29ab147d05af4de91c()
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

      private sealed class MTHD_882c7e258b5e4283aa436370d56513f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_882c7e258b5e4283aa436370d56513f4()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_233da4d614114cc3b701de7d51f3e0f0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_233da4d614114cc3b701de7d51f3e0f0()
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

      private sealed class MTHD_041761748b764fe8b94bc59cac1ac678 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_041761748b764fe8b94bc59cac1ac678()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_67f02df773994ca3aea6d5f827fc2a55 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67f02df773994ca3aea6d5f827fc2a55()
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

      private sealed class MTHD_e1e13befadbb43cfb2e0de2e15c96177 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e1e13befadbb43cfb2e0de2e15c96177()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_ce99e47e9c044f01bbc2317a333acd4f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ce99e47e9c044f01bbc2317a333acd4f()
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

      private sealed class MTHD_67e68fb9d440409f8a8eca97854e91b4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67e68fb9d440409f8a8eca97854e91b4()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_3321624b345842cc83a58d28d593d43f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3321624b345842cc83a58d28d593d43f()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_1f53a1f8b82347c1abb5db96a8e68d24 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f53a1f8b82347c1abb5db96a8e68d24()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_fdbd5f9bd57a4276a4ac0e1a255db49c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fdbd5f9bd57a4276a4ac0e1a255db49c()
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

      private sealed class MTHD_17ede51b7b9d45fb8b2f3c223bf4dd41 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_17ede51b7b9d45fb8b2f3c223bf4dd41()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_3cd34aa0dbf24606a286225d58564127 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3cd34aa0dbf24606a286225d58564127()
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

      private sealed class MTHD_7b729e8fd2534fb9a4c04d13872fea73 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b729e8fd2534fb9a4c04d13872fea73()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_e20c233f07b54dbbb10334bcc011bce6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e20c233f07b54dbbb10334bcc011bce6()
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

      private sealed class MTHD_8b98933e0ab843c7b4c79e0fff60de64 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b98933e0ab843c7b4c79e0fff60de64()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_9b7b2713ea9c4ee39287be488530f7e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b7b2713ea9c4ee39287be488530f7e2()
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

      private sealed class MTHD_484b76f1c0eb4a4fa415a04db96b65f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_484b76f1c0eb4a4fa415a04db96b65f1()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_452c2cc7c7814caf96e84aed99e85cfb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_452c2cc7c7814caf96e84aed99e85cfb()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_46be8f97bfe1427384f6b2608b47a2b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_46be8f97bfe1427384f6b2608b47a2b7()
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

      private sealed class MTHD_c8e75c99ed73425b8798b0ce242737e6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c8e75c99ed73425b8798b0ce242737e6()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_7333f626f82b4ee8a6058e5e47829d7c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7333f626f82b4ee8a6058e5e47829d7c()
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

      private sealed class MTHD_322dbdb03ac3497aaed49eedade7d6f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_322dbdb03ac3497aaed49eedade7d6f9()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_4aad1413c7c941889c5dfbf8dc9b8ba4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4aad1413c7c941889c5dfbf8dc9b8ba4()
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

      private sealed class MTHD_cbc9020a87e2486dbe4ec88924aeea9d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cbc9020a87e2486dbe4ec88924aeea9d()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_1d54416804394a6e930c0d9f62428d8e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d54416804394a6e930c0d9f62428d8e()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_b190bf6cd4994e0bacd543ea9bd11123 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b190bf6cd4994e0bacd543ea9bd11123()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_b59f2c0b713a481d9821a67ec9df0f59 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b59f2c0b713a481d9821a67ec9df0f59()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_033dc91bb6584be0ab6645be7ae5c1b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_033dc91bb6584be0ab6645be7ae5c1b2()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_14951b0c4664449b8cfc8d51b27887ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_14951b0c4664449b8cfc8d51b27887ad()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_a30ce2018b3849139093364e660cd772 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a30ce2018b3849139093364e660cd772()
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

      private sealed class MTHD_f5922bbfbe404f09b1ee37b70de16b6a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f5922bbfbe404f09b1ee37b70de16b6a()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_8630327e7da04bd9a28c7ba01251eb53 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8630327e7da04bd9a28c7ba01251eb53()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_fc9bd8f5683449ffa0eb5eb8c19fd67d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fc9bd8f5683449ffa0eb5eb8c19fd67d()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_9c4c4f92e528432285b4c9f21bd960cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c4c4f92e528432285b4c9f21bd960cf()
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

      private sealed class MTHD_5bfd40cdca194eff988fc139a1dc2476 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5bfd40cdca194eff988fc139a1dc2476()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_d7fa0d95e85442f883ecdcf614c80a7e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d7fa0d95e85442f883ecdcf614c80a7e()
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

      private sealed class MTHD_241408f514a64d58b93b638d7406d157 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_241408f514a64d58b93b638d7406d157()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_5fc03a1ad3d9406988f201f37ecb0f7d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5fc03a1ad3d9406988f201f37ecb0f7d()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_f90709628af940cc9def7c9b7620c9c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f90709628af940cc9def7c9b7620c9c7()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_3e5dec568ec64ed5b1fd35874eb2a841 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e5dec568ec64ed5b1fd35874eb2a841()
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

      private sealed class MTHD_3bbf6e9dcc9b430d85024944232a457d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3bbf6e9dcc9b430d85024944232a457d()
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

      private sealed class MTHD_c579a430b5e34565a4fd6c26a69d1031 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c579a430b5e34565a4fd6c26a69d1031()
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

      private sealed class MTHD_2e6ba9448b92419cb399a8362436dfe0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2e6ba9448b92419cb399a8362436dfe0()
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

      private sealed class MTHD_a7d01ce7244b4e04bfd62bc96e207a69 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a7d01ce7244b4e04bfd62bc96e207a69()
        {
          this.Initialize("getDirection", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getDirection();
        }
      }

      private sealed class MTHD_b3f778a8051342f9946f32d0b895aeea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b3f778a8051342f9946f32d0b895aeea()
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

      private sealed class MTHD_5ebd0e76178c4d3d85e2a73441df56f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ebd0e76178c4d3d85e2a73441df56f6()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_a26b26a7c333417d972762170047a217 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a26b26a7c333417d972762170047a217()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_0d8d5fee4b114d8ab90eaffa3c049399 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d8d5fee4b114d8ab90eaffa3c049399()
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

      private sealed class MTHD_c382697c27114d80bcf963a923651a8a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c382697c27114d80bcf963a923651a8a()
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

      private sealed class MTHD_9b1992146fea432f8406a6922c75f141 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b1992146fea432f8406a6922c75f141()
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

      private sealed class MTHD_22a47e8e2ce44eaba2bf8bec26403e31 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22a47e8e2ce44eaba2bf8bec26403e31()
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

      private sealed class MTHD_8628cd4cfd8e4f76826d5cbda9d495b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8628cd4cfd8e4f76826d5cbda9d495b6()
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

      private sealed class MTHD_3e8c17d738d04918a913c466ebcb3c65 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e8c17d738d04918a913c466ebcb3c65()
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

      private sealed class MTHD_97f91dd9b6e04ea890f36a50e7873293 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97f91dd9b6e04ea890f36a50e7873293()
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

      private sealed class MTHD_04ae908695fc406c9a81960435e5718e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_04ae908695fc406c9a81960435e5718e()
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

      private sealed class MTHD_68b2716a62944339bdf04cebafa65ce7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_68b2716a62944339bdf04cebafa65ce7()
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

      private sealed class MTHD_508a5525d8d1451491c3fd312650a934 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_508a5525d8d1451491c3fd312650a934()
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

      private sealed class MTHD_2ea5f442b4924bb69ef8a300d38ea101 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2ea5f442b4924bb69ef8a300d38ea101()
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

      private sealed class MTHD_cac70fd64b9a45b19a91f7421644767e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cac70fd64b9a45b19a91f7421644767e()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_4c7ccb401bdf40778ccb8c96cd634e77 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c7ccb401bdf40778ccb8c96cd634e77()
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

      private sealed class MTHD_28ffe941e534425391a65df0401bc5fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_28ffe941e534425391a65df0401bc5fd()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_967066feb9374020960c9410495a9cd6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_967066feb9374020960c9410495a9cd6()
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

      private sealed class MTHD_03b50d472a8448d2b2fb6fa4de777dde : HardwiredMethodMemberDescriptor
      {
        internal MTHD_03b50d472a8448d2b2fb6fa4de777dde()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_fca170bf2dcc4bf084697919003b2ae1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fca170bf2dcc4bf084697919003b2ae1()
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

      private sealed class MTHD_46c507adcf154f20a6d53dcff8dadbca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_46c507adcf154f20a6d53dcff8dadbca()
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

      private sealed class MTHD_691e84846e764f0aa5247167c8155e85 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_691e84846e764f0aa5247167c8155e85()
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

      private sealed class MTHD_ae98221d0dd04eaead79b20c1ea10790 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae98221d0dd04eaead79b20c1ea10790()
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

      private sealed class MTHD_b80807ad71874848836070334deb7c8e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b80807ad71874848836070334deb7c8e()
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

      private sealed class MTHD_bd27c99ea22a49c99394c44192756308 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd27c99ea22a49c99394c44192756308()
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

      private sealed class MTHD_322d98178a64431780e4cbe57f5a3f60 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_322d98178a64431780e4cbe57f5a3f60()
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

      private sealed class MTHD_248f3c9bc5604550a7824a26f6e13023 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_248f3c9bc5604550a7824a26f6e13023()
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

      private sealed class MTHD_48c69a8a9a0c47e9a5e6163849380eb3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_48c69a8a9a0c47e9a5e6163849380eb3()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_fde1c80169c844b1a2c2ebf3f20f4015 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fde1c80169c844b1a2c2ebf3f20f4015()
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

      private sealed class MTHD_a8a0ad0b378c4ebebf51243665591064 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a8a0ad0b378c4ebebf51243665591064()
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

      private sealed class MTHD_f79783e48185492ba88cb1cf897fe93f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f79783e48185492ba88cb1cf897fe93f()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_a1ef83f9631d4d6ba2319ddbb20ee6e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1ef83f9631d4d6ba2319ddbb20ee6e1()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_36dd4c683b0048318cb30ae8928c646c : HardwiredMemberDescriptor
      {
        internal PROP_36dd4c683b0048318cb30ae8928c646c()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_921ee27dded248149c693bd757228ff7 : HardwiredMemberDescriptor
      {
        internal PROP_921ee27dded248149c693bd757228ff7()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_81fce29aa26348aaa6968be7e59da222 : HardwiredMemberDescriptor
      {
        internal PROP_81fce29aa26348aaa6968be7e59da222()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_f3a7576225b84903be24eef00328aa90 : HardwiredMemberDescriptor
      {
        internal PROP_f3a7576225b84903be24eef00328aa90()
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

      private sealed class PROP_12eb743d47b04dd5bcd752ec8c66f586 : HardwiredMemberDescriptor
      {
        internal PROP_12eb743d47b04dd5bcd752ec8c66f586()
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

      private sealed class PROP_4df444346c4d41019019fb1c91233866 : HardwiredMemberDescriptor
      {
        internal PROP_4df444346c4d41019019fb1c91233866()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_50fe9da8d0f3431dad9af1ab311bb637 : HardwiredMemberDescriptor
      {
        internal PROP_50fe9da8d0f3431dad9af1ab311bb637()
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

      private sealed class PROP_4e988a39d2cb433ea8d09a45f421a317 : HardwiredMemberDescriptor
      {
        internal PROP_4e988a39d2cb433ea8d09a45f421a317()
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

      private sealed class PROP_54f7cf95d766465ea6affb893bff8b38 : HardwiredMemberDescriptor
      {
        internal PROP_54f7cf95d766465ea6affb893bff8b38()
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

      private sealed class PROP_308bdbfc87ea4a7896d1e1f36f259c0b : HardwiredMemberDescriptor
      {
        internal PROP_308bdbfc87ea4a7896d1e1f36f259c0b()
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

      private sealed class PROP_b85443cfe1b240779a53fdb9b58b0ee7 : HardwiredMemberDescriptor
      {
        internal PROP_b85443cfe1b240779a53fdb9b58b0ee7()
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

      private sealed class PROP_00dc0e485b894f64b8c09ba10340230e : HardwiredMemberDescriptor
      {
        internal PROP_00dc0e485b894f64b8c09ba10340230e()
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

      private sealed class PROP_d47f19a817944911b21ed8f130a47947 : HardwiredMemberDescriptor
      {
        internal PROP_d47f19a817944911b21ed8f130a47947()
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

      private sealed class PROP_7e6f37f96d0c4a68a06f8078855e06c3 : HardwiredMemberDescriptor
      {
        internal PROP_7e6f37f96d0c4a68a06f8078855e06c3()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_b0e4b03f91c94aa79158eff13bb3b7be : HardwiredMemberDescriptor
      {
        internal PROP_b0e4b03f91c94aa79158eff13bb3b7be()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_100ca5d4ff934979938d142b85600445 : HardwiredMemberDescriptor
      {
        internal PROP_100ca5d4ff934979938d142b85600445()
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

      private sealed class PROP_efc03c064d9c4628852918d9f5b04226 : HardwiredMemberDescriptor
      {
        internal PROP_efc03c064d9c4628852918d9f5b04226()
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

      private sealed class PROP_cd9f4688297c438fa69b6350aced7130 : HardwiredMemberDescriptor
      {
        internal PROP_cd9f4688297c438fa69b6350aced7130()
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

      private sealed class PROP_3d8e5950310d416197a9b8e5e7786a04 : HardwiredMemberDescriptor
      {
        internal PROP_3d8e5950310d416197a9b8e5e7786a04()
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

      private sealed class PROP_f32d5b3bfbec492292647303e28d01df : HardwiredMemberDescriptor
      {
        internal PROP_f32d5b3bfbec492292647303e28d01df()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_451aa7440c4f48ea9b848e675ec36a23 : HardwiredMemberDescriptor
      {
        internal PROP_451aa7440c4f48ea9b848e675ec36a23()
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

      private sealed class PROP_91bf02feb48c4b369d5c3ca32a5d4662 : HardwiredMemberDescriptor
      {
        internal PROP_91bf02feb48c4b369d5c3ca32a5d4662()
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

      private sealed class PROP_fac64a978bad4250a6bda3eb9d79a2e5 : HardwiredMemberDescriptor
      {
        internal PROP_fac64a978bad4250a6bda3eb9d79a2e5()
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

      private sealed class PROP_24a8de70e473479d88345c73e3755eb3 : HardwiredMemberDescriptor
      {
        internal PROP_24a8de70e473479d88345c73e3755eb3()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_687a167752bc43839c81b5b01460fae2 : HardwiredMemberDescriptor
      {
        internal PROP_687a167752bc43839c81b5b01460fae2()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_584dd6b2353d40ca841e53f37e1b7531 : HardwiredMemberDescriptor
      {
        internal PROP_584dd6b2353d40ca841e53f37e1b7531()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_9d4293b5cfbc467392283796cc41d3e6 : HardwiredMemberDescriptor
      {
        internal PROP_9d4293b5cfbc467392283796cc41d3e6()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_8ed973d495e941a896bdf6a4e419155d : HardwiredMemberDescriptor
      {
        internal PROP_8ed973d495e941a896bdf6a4e419155d()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_63ebb1f112d14544bcd17cbca3a71a7c : HardwiredMemberDescriptor
      {
        internal PROP_63ebb1f112d14544bcd17cbca3a71a7c()
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

      private sealed class PROP_cb0d8314237a4f46b4093771aeed7c81 : HardwiredMemberDescriptor
      {
        internal PROP_cb0d8314237a4f46b4093771aeed7c81()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_c79b400fa2fc4156a534968b65ae7990 : HardwiredMemberDescriptor
      {
        internal PROP_c79b400fa2fc4156a534968b65ae7990()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_82c31d96d8c94af99f650dd0a77bc104 : HardwiredMemberDescriptor
      {
        internal PROP_82c31d96d8c94af99f650dd0a77bc104()
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

      private sealed class PROP_c52985c1c38041deb4f1f2a43f6d8567 : HardwiredMemberDescriptor
      {
        internal PROP_c52985c1c38041deb4f1f2a43f6d8567()
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

    private sealed class TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb : HardwiredUserDataDescriptor
    {
      internal TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.MTHD_eab04e9f202c48aa9a16920b323dafaa()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.MTHD_46fe39d6df3e435b9d9885551a1f2788()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.MTHD_a48dc87227564b709f3c2da5d16fa40a()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.MTHD_371d650f3b444acebf783b72dbfd89f6()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.MTHD_957ab963ab2444c1b093c34b6b86fa96()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.MTHD_66bf9d73f6f64a3a976c9f8f7318a838()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.MTHD_492e6e3aab21413cbf6c3778386926b3()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.MTHD_1b7a49bd35334a67a17438533d760701()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.MTHD_c52925642f0d4e699f685cac12bbe455()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.MTHD_92f0489644ca4425a16a8858b6780493()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.MTHD_1a8e5c3f73144513af7bac52df8b34bc()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.MTHD_eea345f720df46acbed781c31821ceae()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.MTHD_08ad0260ee2b4a27a78364915936939c()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.MTHD_bdaac9ffa2034b5f97e2938108001a62()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.MTHD_f81a2aa32d704e67a0579e3daeed597f()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.MTHD_6574093453d14534b86a07af81cc13be()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.MTHD_3f3c8732dff94a47824f0bd25d1625c9()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.MTHD_c839df3af72b46549377d86f8f9fc358()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.MTHD_96bf72ab0d514fbe845b032cf3844b01()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.MTHD_0e772a2d0b444e6dad17e15e78a02b3f()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.PROP_e44cfc9c30514a82bb531f016bb05a2c());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.PROP_564b41be2e164b828e5b1ad321beb7be());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.PROP_0e5b1283297f4eb19e0a506dedb33d38());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.PROP_ab1d2488890b455d905c8357fdaa2d39());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.PROP_04cc41955de042edac033436cb112632());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.PROP_918fecfac9eb4c1a9edcac539e55b652());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.PROP_adf5e4136931467d9327955102944e36());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_c17766dcd6ab4d14b6fa3567b7fee2eb.PROP_66cc3aabaac24816bbce8c34a7a92c82());
      }

      private sealed class MTHD_eab04e9f202c48aa9a16920b323dafaa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eab04e9f202c48aa9a16920b323dafaa()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_46fe39d6df3e435b9d9885551a1f2788 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_46fe39d6df3e435b9d9885551a1f2788()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_a48dc87227564b709f3c2da5d16fa40a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a48dc87227564b709f3c2da5d16fa40a()
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

      private sealed class MTHD_371d650f3b444acebf783b72dbfd89f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_371d650f3b444acebf783b72dbfd89f6()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_957ab963ab2444c1b093c34b6b86fa96 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_957ab963ab2444c1b093c34b6b86fa96()
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

      private sealed class MTHD_66bf9d73f6f64a3a976c9f8f7318a838 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_66bf9d73f6f64a3a976c9f8f7318a838()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_492e6e3aab21413cbf6c3778386926b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_492e6e3aab21413cbf6c3778386926b3()
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

      private sealed class MTHD_1b7a49bd35334a67a17438533d760701 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1b7a49bd35334a67a17438533d760701()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_c52925642f0d4e699f685cac12bbe455 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c52925642f0d4e699f685cac12bbe455()
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

      private sealed class MTHD_92f0489644ca4425a16a8858b6780493 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_92f0489644ca4425a16a8858b6780493()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_1a8e5c3f73144513af7bac52df8b34bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a8e5c3f73144513af7bac52df8b34bc()
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

      private sealed class MTHD_eea345f720df46acbed781c31821ceae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eea345f720df46acbed781c31821ceae()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_08ad0260ee2b4a27a78364915936939c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_08ad0260ee2b4a27a78364915936939c()
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

      private sealed class MTHD_bdaac9ffa2034b5f97e2938108001a62 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bdaac9ffa2034b5f97e2938108001a62()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_f81a2aa32d704e67a0579e3daeed597f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f81a2aa32d704e67a0579e3daeed597f()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_6574093453d14534b86a07af81cc13be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6574093453d14534b86a07af81cc13be()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_3f3c8732dff94a47824f0bd25d1625c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f3c8732dff94a47824f0bd25d1625c9()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_c839df3af72b46549377d86f8f9fc358 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c839df3af72b46549377d86f8f9fc358()
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

      private sealed class MTHD_96bf72ab0d514fbe845b032cf3844b01 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_96bf72ab0d514fbe845b032cf3844b01()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_0e772a2d0b444e6dad17e15e78a02b3f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e772a2d0b444e6dad17e15e78a02b3f()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_e44cfc9c30514a82bb531f016bb05a2c : HardwiredMemberDescriptor
      {
        internal PROP_e44cfc9c30514a82bb531f016bb05a2c()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_564b41be2e164b828e5b1ad321beb7be : HardwiredMemberDescriptor
      {
        internal PROP_564b41be2e164b828e5b1ad321beb7be()
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

      private sealed class PROP_0e5b1283297f4eb19e0a506dedb33d38 : HardwiredMemberDescriptor
      {
        internal PROP_0e5b1283297f4eb19e0a506dedb33d38()
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

      private sealed class PROP_ab1d2488890b455d905c8357fdaa2d39 : HardwiredMemberDescriptor
      {
        internal PROP_ab1d2488890b455d905c8357fdaa2d39()
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

      private sealed class PROP_04cc41955de042edac033436cb112632 : HardwiredMemberDescriptor
      {
        internal PROP_04cc41955de042edac033436cb112632()
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

      private sealed class PROP_918fecfac9eb4c1a9edcac539e55b652 : HardwiredMemberDescriptor
      {
        internal PROP_918fecfac9eb4c1a9edcac539e55b652()
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

      private sealed class PROP_adf5e4136931467d9327955102944e36 : HardwiredMemberDescriptor
      {
        internal PROP_adf5e4136931467d9327955102944e36()
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

      private sealed class PROP_66cc3aabaac24816bbce8c34a7a92c82 : HardwiredMemberDescriptor
      {
        internal PROP_66cc3aabaac24816bbce8c34a7a92c82()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_6e0d68c43bda42f9a182a05c45668c02 : HardwiredUserDataDescriptor
    {
      internal TYPE_6e0d68c43bda42f9a182a05c45668c02()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.MTHD_5667ee72889e4c0bb5f3b87150608f71()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.MTHD_1f69b3bf847f4f5885358d499ed3bf1f()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.MTHD_720ff31dae8043618084feee34ed6876()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.MTHD_247191d0f1c34233b4b1065e98eda33a()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.MTHD_2861ab0ea1744c2d8a2f63a333459b18()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.MTHD_9c6c8bf508334a17b9160d869c932a6e()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.MTHD_70be369dcfd149d899223187983ca21e()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.MTHD_c3cef187431e4e949b895579dbec3013()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.MTHD_de735a58425d47d2a809a854b5d52593()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.MTHD_efa9cbdc5dd94f0381424b1e39f6c2c3()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.MTHD_c3557c4c0b58416b82c2a3ee3fd55fc6()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.MTHD_d4b2e6e42e574fc8b8a4774890667e31()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.MTHD_2ad5d9e6aaeb449b8327f52c3da3593c()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.MTHD_2ed342316d414de5ad83eb1c5e941253()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.MTHD_2542c9ff207f488d823ec4603c355adf()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.MTHD_0ccc7f59a75b445582cb9d10f293ab52()
        }));
        this.AddMember("setIcon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setIcon", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.MTHD_5b72716641464f51b4c2ff4f796aeb96()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.MTHD_b686a53585564920b4526d54ccc624bf()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.MTHD_d4c090aff3f64b9eaeb7ebde243d5170()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.MTHD_f37c1682cc904213804c3185d81b3121()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.MTHD_e3ce33ce9da0452eab9bf2963190bcbc()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.MTHD_8c18f8aab902483aa1b114cb5369047c()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.PROP_7b0e49c1265a4d5da24bb84089b94435());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.PROP_033460f84fae486cb4f8e82514fdd01a());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.PROP_c1b40bff3c334eedba50f24d6a91dc8f());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.PROP_7bcfa7d9c3b443caaa5cc369edd2f600());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.PROP_081db5ebbb9b46f89579fb2e46e7d33e());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.PROP_d520cc939f5d4dc3b8a50371e3b0d623());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.PROP_9d1fcc012ba34cb39c4e4ee548dc7e73());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.PROP_9b59db4820904f399e444423b838132b());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_6e0d68c43bda42f9a182a05c45668c02.PROP_ae56a8adb0704a989a9632a4213cb73f());
      }

      private sealed class MTHD_5667ee72889e4c0bb5f3b87150608f71 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5667ee72889e4c0bb5f3b87150608f71()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_1f69b3bf847f4f5885358d499ed3bf1f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f69b3bf847f4f5885358d499ed3bf1f()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_720ff31dae8043618084feee34ed6876 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_720ff31dae8043618084feee34ed6876()
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

      private sealed class MTHD_247191d0f1c34233b4b1065e98eda33a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_247191d0f1c34233b4b1065e98eda33a()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_2861ab0ea1744c2d8a2f63a333459b18 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2861ab0ea1744c2d8a2f63a333459b18()
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

      private sealed class MTHD_9c6c8bf508334a17b9160d869c932a6e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c6c8bf508334a17b9160d869c932a6e()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_70be369dcfd149d899223187983ca21e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70be369dcfd149d899223187983ca21e()
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

      private sealed class MTHD_c3cef187431e4e949b895579dbec3013 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c3cef187431e4e949b895579dbec3013()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_de735a58425d47d2a809a854b5d52593 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de735a58425d47d2a809a854b5d52593()
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

      private sealed class MTHD_efa9cbdc5dd94f0381424b1e39f6c2c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_efa9cbdc5dd94f0381424b1e39f6c2c3()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_c3557c4c0b58416b82c2a3ee3fd55fc6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c3557c4c0b58416b82c2a3ee3fd55fc6()
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

      private sealed class MTHD_d4b2e6e42e574fc8b8a4774890667e31 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d4b2e6e42e574fc8b8a4774890667e31()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_2ad5d9e6aaeb449b8327f52c3da3593c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2ad5d9e6aaeb449b8327f52c3da3593c()
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

      private sealed class MTHD_2ed342316d414de5ad83eb1c5e941253 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2ed342316d414de5ad83eb1c5e941253()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color2;
        }
      }

      private sealed class MTHD_2542c9ff207f488d823ec4603c355adf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2542c9ff207f488d823ec4603c355adf()
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

      private sealed class MTHD_0ccc7f59a75b445582cb9d10f293ab52 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ccc7f59a75b445582cb9d10f293ab52()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_5b72716641464f51b4c2ff4f796aeb96 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b72716641464f51b4c2ff4f796aeb96()
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

      private sealed class MTHD_b686a53585564920b4526d54ccc624bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b686a53585564920b4526d54ccc624bf()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_d4c090aff3f64b9eaeb7ebde243d5170 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d4c090aff3f64b9eaeb7ebde243d5170()
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

      private sealed class MTHD_f37c1682cc904213804c3185d81b3121 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f37c1682cc904213804c3185d81b3121()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_e3ce33ce9da0452eab9bf2963190bcbc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e3ce33ce9da0452eab9bf2963190bcbc()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_8c18f8aab902483aa1b114cb5369047c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c18f8aab902483aa1b114cb5369047c()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_7b0e49c1265a4d5da24bb84089b94435 : HardwiredMemberDescriptor
      {
        internal PROP_7b0e49c1265a4d5da24bb84089b94435()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_033460f84fae486cb4f8e82514fdd01a : HardwiredMemberDescriptor
      {
        internal PROP_033460f84fae486cb4f8e82514fdd01a()
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

      private sealed class PROP_c1b40bff3c334eedba50f24d6a91dc8f : HardwiredMemberDescriptor
      {
        internal PROP_c1b40bff3c334eedba50f24d6a91dc8f()
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

      private sealed class PROP_7bcfa7d9c3b443caaa5cc369edd2f600 : HardwiredMemberDescriptor
      {
        internal PROP_7bcfa7d9c3b443caaa5cc369edd2f600()
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

      private sealed class PROP_081db5ebbb9b46f89579fb2e46e7d33e : HardwiredMemberDescriptor
      {
        internal PROP_081db5ebbb9b46f89579fb2e46e7d33e()
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

      private sealed class PROP_d520cc939f5d4dc3b8a50371e3b0d623 : HardwiredMemberDescriptor
      {
        internal PROP_d520cc939f5d4dc3b8a50371e3b0d623()
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

      private sealed class PROP_9d1fcc012ba34cb39c4e4ee548dc7e73 : HardwiredMemberDescriptor
      {
        internal PROP_9d1fcc012ba34cb39c4e4ee548dc7e73()
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

      private sealed class PROP_9b59db4820904f399e444423b838132b : HardwiredMemberDescriptor
      {
        internal PROP_9b59db4820904f399e444423b838132b()
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

      private sealed class PROP_ae56a8adb0704a989a9632a4213cb73f : HardwiredMemberDescriptor
      {
        internal PROP_ae56a8adb0704a989a9632a4213cb73f()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_d92c14c9c16d4129833b13ccf152de2b : HardwiredUserDataDescriptor
    {
      internal TYPE_d92c14c9c16d4129833b13ccf152de2b()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_dcd2caffa61a4813bff58a44449c8373()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_c171f7e85cf641eca4b0e825f41f84aa()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_b8bf6a0578594728a486b5b9962e981d()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_7369a458297546e1ae977a7b36ff3f8d()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_5ad2266c8f514880a107ec0f0aa56c2c()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_6d718ac823d54f919ca85c54c23eabec()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_09d525837a40467092d281023d4984f9()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_8fe6b886929041e49f8ad529125a5de5()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_24598e82f7e84da49421ccaaa280c89d()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_1fba40edc6a14cce9832d09d46a92d22()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_1796d0557ec74be09a10f4bb25d74bac()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_f55ba2d843ce431b897ee1dd8aa292c7()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_6ff0bfa42e81488abbb16677ed5edd24()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_d0945f6181b4459d96aad46ac7f32907()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_10781d854e544719a0e15382b02a0439()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_1b4542887dba41b18e0b7d5515aa9a1f()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_3d9e7c9d33bb436ea260a72c455bab07()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_3a8eedc3c2fb44c28f48f4a62f83943b()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_57d2dbc1d5f74cbc8906674d2b369ff9()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_961cff9223c04f4db0071399c58536ee()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_796bbe6812224324bfc971630c13b251()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_2fd04221bc334ea5a001b26eeeed821b()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_9309df54b08c47f09cc922e032d1c15f()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_65c310fade914c168f5828ef3f2add2a()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_a657aeaf7de34399b7abc8bc49adab75()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_cc6ff78946094023bf40f76831e4b37c()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_d426ab9d0d1246a0b58cf4baf8f1d49d()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.MTHD_2fdcdd651424410e8f241f1bf5bbb3ee()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.PROP_5e82648774504ee6b6c53871d3ecba3b());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.PROP_8367573067bd41a0be0dfdb789a9b5aa());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.PROP_13bcebbe71e8402ab140e6a0b6d4e5ba());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.PROP_2178576ef6df40e7b95aa590fc7382fc());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.PROP_511613265f994fddb79cd8f4d70d6cd0());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.PROP_a6e10cd00aef419080589e5a884d71c1());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.PROP_00ff194ea42b4a598125d708714ce888());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.PROP_1bbd9b28428b4dccb8e5a4ab81625729());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.PROP_43f66d92b0ad452f9e51782ed1563387());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.PROP_586634aae1734287a4a46261a5a63af3());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.PROP_0490135b8c394709918ddf7a1523d6fe());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.PROP_47445e4fe07c44eba26b261e2ce5276e());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.PROP_e8136358c8a74e63970a8f369d1c23ec());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.PROP_9900a47c4f3640beadf7a15a1d050273());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.PROP_d89427b778194813835c17bf77e04b5d());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.PROP_b806d3c7570c4094ac3f9bebf3137e21());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_d92c14c9c16d4129833b13ccf152de2b.PROP_0c69341ccdbe4e21a9aa1ede852e0642());
      }

      private sealed class MTHD_dcd2caffa61a4813bff58a44449c8373 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dcd2caffa61a4813bff58a44449c8373()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_c171f7e85cf641eca4b0e825f41f84aa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c171f7e85cf641eca4b0e825f41f84aa()
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

      private sealed class MTHD_b8bf6a0578594728a486b5b9962e981d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b8bf6a0578594728a486b5b9962e981d()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_7369a458297546e1ae977a7b36ff3f8d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7369a458297546e1ae977a7b36ff3f8d()
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

      private sealed class MTHD_5ad2266c8f514880a107ec0f0aa56c2c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ad2266c8f514880a107ec0f0aa56c2c()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_6d718ac823d54f919ca85c54c23eabec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d718ac823d54f919ca85c54c23eabec()
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

      private sealed class MTHD_09d525837a40467092d281023d4984f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_09d525837a40467092d281023d4984f9()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_8fe6b886929041e49f8ad529125a5de5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8fe6b886929041e49f8ad529125a5de5()
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

      private sealed class MTHD_24598e82f7e84da49421ccaaa280c89d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24598e82f7e84da49421ccaaa280c89d()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_1fba40edc6a14cce9832d09d46a92d22 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1fba40edc6a14cce9832d09d46a92d22()
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

      private sealed class MTHD_1796d0557ec74be09a10f4bb25d74bac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1796d0557ec74be09a10f4bb25d74bac()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_f55ba2d843ce431b897ee1dd8aa292c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f55ba2d843ce431b897ee1dd8aa292c7()
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

      private sealed class MTHD_6ff0bfa42e81488abbb16677ed5edd24 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ff0bfa42e81488abbb16677ed5edd24()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_d0945f6181b4459d96aad46ac7f32907 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0945f6181b4459d96aad46ac7f32907()
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

      private sealed class MTHD_10781d854e544719a0e15382b02a0439 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_10781d854e544719a0e15382b02a0439()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_1b4542887dba41b18e0b7d5515aa9a1f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1b4542887dba41b18e0b7d5515aa9a1f()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_3d9e7c9d33bb436ea260a72c455bab07 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d9e7c9d33bb436ea260a72c455bab07()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_3a8eedc3c2fb44c28f48f4a62f83943b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3a8eedc3c2fb44c28f48f4a62f83943b()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_57d2dbc1d5f74cbc8906674d2b369ff9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57d2dbc1d5f74cbc8906674d2b369ff9()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_961cff9223c04f4db0071399c58536ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_961cff9223c04f4db0071399c58536ee()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_796bbe6812224324bfc971630c13b251 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_796bbe6812224324bfc971630c13b251()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_2fd04221bc334ea5a001b26eeeed821b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2fd04221bc334ea5a001b26eeeed821b()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_9309df54b08c47f09cc922e032d1c15f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9309df54b08c47f09cc922e032d1c15f()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_65c310fade914c168f5828ef3f2add2a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65c310fade914c168f5828ef3f2add2a()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_a657aeaf7de34399b7abc8bc49adab75 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a657aeaf7de34399b7abc8bc49adab75()
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

      private sealed class MTHD_cc6ff78946094023bf40f76831e4b37c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cc6ff78946094023bf40f76831e4b37c()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_d426ab9d0d1246a0b58cf4baf8f1d49d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d426ab9d0d1246a0b58cf4baf8f1d49d()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_2fdcdd651424410e8f241f1bf5bbb3ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2fdcdd651424410e8f241f1bf5bbb3ee()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_5e82648774504ee6b6c53871d3ecba3b : HardwiredMemberDescriptor
      {
        internal PROP_5e82648774504ee6b6c53871d3ecba3b()
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

      private sealed class PROP_8367573067bd41a0be0dfdb789a9b5aa : HardwiredMemberDescriptor
      {
        internal PROP_8367573067bd41a0be0dfdb789a9b5aa()
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

      private sealed class PROP_13bcebbe71e8402ab140e6a0b6d4e5ba : HardwiredMemberDescriptor
      {
        internal PROP_13bcebbe71e8402ab140e6a0b6d4e5ba()
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

      private sealed class PROP_2178576ef6df40e7b95aa590fc7382fc : HardwiredMemberDescriptor
      {
        internal PROP_2178576ef6df40e7b95aa590fc7382fc()
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

      private sealed class PROP_511613265f994fddb79cd8f4d70d6cd0 : HardwiredMemberDescriptor
      {
        internal PROP_511613265f994fddb79cd8f4d70d6cd0()
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

      private sealed class PROP_a6e10cd00aef419080589e5a884d71c1 : HardwiredMemberDescriptor
      {
        internal PROP_a6e10cd00aef419080589e5a884d71c1()
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

      private sealed class PROP_00ff194ea42b4a598125d708714ce888 : HardwiredMemberDescriptor
      {
        internal PROP_00ff194ea42b4a598125d708714ce888()
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

      private sealed class PROP_1bbd9b28428b4dccb8e5a4ab81625729 : HardwiredMemberDescriptor
      {
        internal PROP_1bbd9b28428b4dccb8e5a4ab81625729()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_43f66d92b0ad452f9e51782ed1563387 : HardwiredMemberDescriptor
      {
        internal PROP_43f66d92b0ad452f9e51782ed1563387()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_586634aae1734287a4a46261a5a63af3 : HardwiredMemberDescriptor
      {
        internal PROP_586634aae1734287a4a46261a5a63af3()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_0490135b8c394709918ddf7a1523d6fe : HardwiredMemberDescriptor
      {
        internal PROP_0490135b8c394709918ddf7a1523d6fe()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_47445e4fe07c44eba26b261e2ce5276e : HardwiredMemberDescriptor
      {
        internal PROP_47445e4fe07c44eba26b261e2ce5276e()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_e8136358c8a74e63970a8f369d1c23ec : HardwiredMemberDescriptor
      {
        internal PROP_e8136358c8a74e63970a8f369d1c23ec()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_9900a47c4f3640beadf7a15a1d050273 : HardwiredMemberDescriptor
      {
        internal PROP_9900a47c4f3640beadf7a15a1d050273()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_d89427b778194813835c17bf77e04b5d : HardwiredMemberDescriptor
      {
        internal PROP_d89427b778194813835c17bf77e04b5d()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_b806d3c7570c4094ac3f9bebf3137e21 : HardwiredMemberDescriptor
      {
        internal PROP_b806d3c7570c4094ac3f9bebf3137e21()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_0c69341ccdbe4e21a9aa1ede852e0642 : HardwiredMemberDescriptor
      {
        internal PROP_0c69341ccdbe4e21a9aa1ede852e0642()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_7aede1466d464dafaf6a4970a1875c8a : HardwiredUserDataDescriptor
    {
      internal TYPE_7aede1466d464dafaf6a4970a1875c8a()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7aede1466d464dafaf6a4970a1875c8a.MTHD_d5f98127cd934799b0d2f41d33c3ef57()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7aede1466d464dafaf6a4970a1875c8a.MTHD_222b7e605aca4dbebf554cb44bdfbdb6()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7aede1466d464dafaf6a4970a1875c8a.MTHD_d5ab1a868a1944d2acde466cb52cbda5()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7aede1466d464dafaf6a4970a1875c8a.MTHD_ae32b98eb1114edc8793712890a07e89()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7aede1466d464dafaf6a4970a1875c8a.MTHD_f9344bae9b0044f19c03d2485b979806()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7aede1466d464dafaf6a4970a1875c8a.MTHD_d9c0d33973964c7c8e3713cdedc82059()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7aede1466d464dafaf6a4970a1875c8a.MTHD_d584d51625b145dca96cbbf807eebfe3()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7aede1466d464dafaf6a4970a1875c8a.MTHD_8231525aad6d42b0977114da1a1c4511()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7aede1466d464dafaf6a4970a1875c8a.MTHD_f7606d53924049bcb7b9abea7301ac03()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7aede1466d464dafaf6a4970a1875c8a.MTHD_ed3593cb28c74411a46a07ca4385190f()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7aede1466d464dafaf6a4970a1875c8a.MTHD_9b953cb91aad455b89a24a4cf6931104()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7aede1466d464dafaf6a4970a1875c8a.MTHD_1b1a205567d74185a0ffad643374e844()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7aede1466d464dafaf6a4970a1875c8a.MTHD_5bf745be1735499380fc298f50897eac()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7aede1466d464dafaf6a4970a1875c8a.MTHD_d8f457b0767b489a825e6a0f42dd4cbf()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7aede1466d464dafaf6a4970a1875c8a.MTHD_03965ca6b78b4db1bb520ece1b8de215()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7aede1466d464dafaf6a4970a1875c8a.MTHD_dafa711553a24a5e8773a97a23cd5278()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7aede1466d464dafaf6a4970a1875c8a.MTHD_41dd244314874f7fa25416d554b58e79()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_7aede1466d464dafaf6a4970a1875c8a.PROP_9b1c55fa8b4d4e32bc9753f069ef042e());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_7aede1466d464dafaf6a4970a1875c8a.PROP_53a83173eb8c495cbff6ed5751affed7());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_7aede1466d464dafaf6a4970a1875c8a.PROP_5fb570f553af4b7e8d15e8d6b6a9d4b0());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_7aede1466d464dafaf6a4970a1875c8a.PROP_6a2dfcb7e53b4400a67ceadfb3376868());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_7aede1466d464dafaf6a4970a1875c8a.PROP_90c8873c608a496790ee7284b87dc7cf());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_7aede1466d464dafaf6a4970a1875c8a.PROP_288ab4f09a9c49318e7f008c52cd9a11());
      }

      private sealed class MTHD_d5f98127cd934799b0d2f41d33c3ef57 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d5f98127cd934799b0d2f41d33c3ef57()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_222b7e605aca4dbebf554cb44bdfbdb6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_222b7e605aca4dbebf554cb44bdfbdb6()
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

      private sealed class MTHD_d5ab1a868a1944d2acde466cb52cbda5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d5ab1a868a1944d2acde466cb52cbda5()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_ae32b98eb1114edc8793712890a07e89 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae32b98eb1114edc8793712890a07e89()
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

      private sealed class MTHD_f9344bae9b0044f19c03d2485b979806 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f9344bae9b0044f19c03d2485b979806()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_d9c0d33973964c7c8e3713cdedc82059 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d9c0d33973964c7c8e3713cdedc82059()
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

      private sealed class MTHD_d584d51625b145dca96cbbf807eebfe3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d584d51625b145dca96cbbf807eebfe3()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_8231525aad6d42b0977114da1a1c4511 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8231525aad6d42b0977114da1a1c4511()
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

      private sealed class MTHD_f7606d53924049bcb7b9abea7301ac03 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7606d53924049bcb7b9abea7301ac03()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_ed3593cb28c74411a46a07ca4385190f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed3593cb28c74411a46a07ca4385190f()
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

      private sealed class MTHD_9b953cb91aad455b89a24a4cf6931104 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b953cb91aad455b89a24a4cf6931104()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_1b1a205567d74185a0ffad643374e844 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1b1a205567d74185a0ffad643374e844()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_5bf745be1735499380fc298f50897eac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5bf745be1735499380fc298f50897eac()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_d8f457b0767b489a825e6a0f42dd4cbf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8f457b0767b489a825e6a0f42dd4cbf()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_03965ca6b78b4db1bb520ece1b8de215 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_03965ca6b78b4db1bb520ece1b8de215()
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

      private sealed class MTHD_dafa711553a24a5e8773a97a23cd5278 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dafa711553a24a5e8773a97a23cd5278()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_41dd244314874f7fa25416d554b58e79 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41dd244314874f7fa25416d554b58e79()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_9b1c55fa8b4d4e32bc9753f069ef042e : HardwiredMemberDescriptor
      {
        internal PROP_9b1c55fa8b4d4e32bc9753f069ef042e()
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

      private sealed class PROP_53a83173eb8c495cbff6ed5751affed7 : HardwiredMemberDescriptor
      {
        internal PROP_53a83173eb8c495cbff6ed5751affed7()
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

      private sealed class PROP_5fb570f553af4b7e8d15e8d6b6a9d4b0 : HardwiredMemberDescriptor
      {
        internal PROP_5fb570f553af4b7e8d15e8d6b6a9d4b0()
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

      private sealed class PROP_6a2dfcb7e53b4400a67ceadfb3376868 : HardwiredMemberDescriptor
      {
        internal PROP_6a2dfcb7e53b4400a67ceadfb3376868()
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

      private sealed class PROP_90c8873c608a496790ee7284b87dc7cf : HardwiredMemberDescriptor
      {
        internal PROP_90c8873c608a496790ee7284b87dc7cf()
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

      private sealed class PROP_288ab4f09a9c49318e7f008c52cd9a11 : HardwiredMemberDescriptor
      {
        internal PROP_288ab4f09a9c49318e7f008c52cd9a11()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_1f996eb2e5b04f5a9757cd749ba089fd : HardwiredUserDataDescriptor
    {
      internal TYPE_1f996eb2e5b04f5a9757cd749ba089fd()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f996eb2e5b04f5a9757cd749ba089fd.MTHD_ad0a632f5c2a4427b47741e5c4468641(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f996eb2e5b04f5a9757cd749ba089fd.MTHD_79650b4ceeb641dfa5f6c989325f047d()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f996eb2e5b04f5a9757cd749ba089fd.MTHD_57cebc5365914a748410d9ea03879b71(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f996eb2e5b04f5a9757cd749ba089fd.MTHD_cd909c27b93645ab9e28dd2aa007bf71()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f996eb2e5b04f5a9757cd749ba089fd.MTHD_e7ade4d22a184ef790f296fde545d0d3()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f996eb2e5b04f5a9757cd749ba089fd.MTHD_e2ecda7031054e97899cc28741683213()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f996eb2e5b04f5a9757cd749ba089fd.MTHD_5802ae6823d043caadd0a870b493a165()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f996eb2e5b04f5a9757cd749ba089fd.MTHD_0c24030b093640119e20d801e6612c80()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f996eb2e5b04f5a9757cd749ba089fd.MTHD_bf285ab7dca24de8b83c5568f2e365ca()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f996eb2e5b04f5a9757cd749ba089fd.MTHD_34a44d9cefdc497fb8cedea7424267bc()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f996eb2e5b04f5a9757cd749ba089fd.MTHD_3b49128bc47e4fefab79428550b7ef35()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f996eb2e5b04f5a9757cd749ba089fd.MTHD_6cf4ac7af0394d5d81e84ec36f8cdedf(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f996eb2e5b04f5a9757cd749ba089fd.MTHD_0fe7b01a9e8045548583d5e4b622d8db()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f996eb2e5b04f5a9757cd749ba089fd.MTHD_2a9966574b654e44a33cbc7ef2faeed2(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f996eb2e5b04f5a9757cd749ba089fd.MTHD_0df9c7692d444d51b6324a7006fd63d7()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f996eb2e5b04f5a9757cd749ba089fd.MTHD_2e0cb76bdb2247128e8883e94fa7f55b(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f996eb2e5b04f5a9757cd749ba089fd.MTHD_6d4686383d9c45788c50479228b6f885()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f996eb2e5b04f5a9757cd749ba089fd.MTHD_d3e5003a9a1640cf9634a0fc5d72246e(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f996eb2e5b04f5a9757cd749ba089fd.MTHD_5a032c71c3134ec98758de20e1af71e1()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f996eb2e5b04f5a9757cd749ba089fd.MTHD_c28d00c18c76452eb90997f1690997b2(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f996eb2e5b04f5a9757cd749ba089fd.MTHD_627c0b74c5e34674af5ec31e330a085c()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f996eb2e5b04f5a9757cd749ba089fd.MTHD_43a02944dc6e4a8aa5e370fb2ee09dd2()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f996eb2e5b04f5a9757cd749ba089fd.MTHD_54d906f4a4b44c42b2550a7516f16c9c()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_1f996eb2e5b04f5a9757cd749ba089fd.FLDV_4fb1c17d78bd48e3a1508a09742f70b6());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_1f996eb2e5b04f5a9757cd749ba089fd.FLDV_57f17c9fff6f433483cb3e3093d56991());
      }

      private sealed class MTHD_ad0a632f5c2a4427b47741e5c4468641 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ad0a632f5c2a4427b47741e5c4468641()
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

      private sealed class MTHD_79650b4ceeb641dfa5f6c989325f047d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_79650b4ceeb641dfa5f6c989325f047d()
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

      private sealed class MTHD_57cebc5365914a748410d9ea03879b71 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57cebc5365914a748410d9ea03879b71()
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

      private sealed class MTHD_cd909c27b93645ab9e28dd2aa007bf71 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd909c27b93645ab9e28dd2aa007bf71()
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

      private sealed class MTHD_e7ade4d22a184ef790f296fde545d0d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7ade4d22a184ef790f296fde545d0d3()
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

      private sealed class MTHD_e2ecda7031054e97899cc28741683213 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e2ecda7031054e97899cc28741683213()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_5802ae6823d043caadd0a870b493a165 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5802ae6823d043caadd0a870b493a165()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_0c24030b093640119e20d801e6612c80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c24030b093640119e20d801e6612c80()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_bf285ab7dca24de8b83c5568f2e365ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf285ab7dca24de8b83c5568f2e365ca()
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

      private sealed class MTHD_34a44d9cefdc497fb8cedea7424267bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_34a44d9cefdc497fb8cedea7424267bc()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_3b49128bc47e4fefab79428550b7ef35 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3b49128bc47e4fefab79428550b7ef35()
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

      private sealed class MTHD_6cf4ac7af0394d5d81e84ec36f8cdedf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6cf4ac7af0394d5d81e84ec36f8cdedf()
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

      private sealed class MTHD_0fe7b01a9e8045548583d5e4b622d8db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0fe7b01a9e8045548583d5e4b622d8db()
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

      private sealed class MTHD_2a9966574b654e44a33cbc7ef2faeed2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a9966574b654e44a33cbc7ef2faeed2()
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

      private sealed class MTHD_0df9c7692d444d51b6324a7006fd63d7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0df9c7692d444d51b6324a7006fd63d7()
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

      private sealed class MTHD_2e0cb76bdb2247128e8883e94fa7f55b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2e0cb76bdb2247128e8883e94fa7f55b()
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

      private sealed class MTHD_6d4686383d9c45788c50479228b6f885 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d4686383d9c45788c50479228b6f885()
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

      private sealed class MTHD_d3e5003a9a1640cf9634a0fc5d72246e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d3e5003a9a1640cf9634a0fc5d72246e()
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

      private sealed class MTHD_5a032c71c3134ec98758de20e1af71e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5a032c71c3134ec98758de20e1af71e1()
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

      private sealed class MTHD_c28d00c18c76452eb90997f1690997b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c28d00c18c76452eb90997f1690997b2()
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

      private sealed class MTHD_627c0b74c5e34674af5ec31e330a085c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_627c0b74c5e34674af5ec31e330a085c()
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

      private sealed class MTHD_43a02944dc6e4a8aa5e370fb2ee09dd2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_43a02944dc6e4a8aa5e370fb2ee09dd2()
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

      private sealed class MTHD_54d906f4a4b44c42b2550a7516f16c9c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_54d906f4a4b44c42b2550a7516f16c9c()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_4fb1c17d78bd48e3a1508a09742f70b6 : HardwiredMemberDescriptor
      {
        internal FLDV_4fb1c17d78bd48e3a1508a09742f70b6()
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

      private sealed class FLDV_57f17c9fff6f433483cb3e3093d56991 : HardwiredMemberDescriptor
      {
        internal FLDV_57f17c9fff6f433483cb3e3093d56991()
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

    private sealed class TYPE_d7272d91ce834b169895e0f063a60bf3 : HardwiredUserDataDescriptor
    {
      internal TYPE_d7272d91ce834b169895e0f063a60bf3()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d7272d91ce834b169895e0f063a60bf3.MTHD_3b6db966b6d3475b947ef54a8579cf63()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d7272d91ce834b169895e0f063a60bf3.MTHD_7e633b172a7c41cfaf3a801ef8bc9c82()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d7272d91ce834b169895e0f063a60bf3.MTHD_d74136ec3799402285d26cc74c2e6192()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d7272d91ce834b169895e0f063a60bf3.MTHD_2620fedc658a4e078c84920cc0929209()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d7272d91ce834b169895e0f063a60bf3.MTHD_121b4aa5e0254e8293c45481c0092d88()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d7272d91ce834b169895e0f063a60bf3.MTHD_f7c0181a04024bb8a9a3df80f862f54f()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_d7272d91ce834b169895e0f063a60bf3.FLDV_b8451a3336a142fe8c4c3564dc551477());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_d7272d91ce834b169895e0f063a60bf3.FLDV_edb688a2bc6443318cad4878bdfe9e9c());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_d7272d91ce834b169895e0f063a60bf3.FLDV_accb8dbc5d2b45939e8bc140b67ce63f());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_d7272d91ce834b169895e0f063a60bf3.FLDV_cb1298ad43e145559df6a877b4277957());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_d7272d91ce834b169895e0f063a60bf3.FLDV_a254bd63f4f24684a3213e8e6779aff0());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_d7272d91ce834b169895e0f063a60bf3.FLDV_4f1ddf10441c40a0bcd17d3a61ac8d00());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_d7272d91ce834b169895e0f063a60bf3.FLDV_68fefc897f2c40bd859284cb05fceef3());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_d7272d91ce834b169895e0f063a60bf3.FLDV_7285046e873d4d12ad6292e990810093());
        this.AddMember("prestige", (IMemberDescriptor) new Bridge.TYPE_d7272d91ce834b169895e0f063a60bf3.FLDV_cf4be6ea8b45449f97facdb852221d96());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_d7272d91ce834b169895e0f063a60bf3.FLDV_b3b78d8750ed40b9b5265ef3594f1391());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_d7272d91ce834b169895e0f063a60bf3.FLDV_871c7de853694a84b9652fef94aedbd3());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_d7272d91ce834b169895e0f063a60bf3.FLDV_2e789a2cf4f248c8b507f7c701d42875());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_d7272d91ce834b169895e0f063a60bf3.FLDV_cf7ebfabdc334a388d20ab04f7472015());
      }

      private sealed class MTHD_3b6db966b6d3475b947ef54a8579cf63 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3b6db966b6d3475b947ef54a8579cf63()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_7e633b172a7c41cfaf3a801ef8bc9c82 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7e633b172a7c41cfaf3a801ef8bc9c82()
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

      private sealed class MTHD_d74136ec3799402285d26cc74c2e6192 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d74136ec3799402285d26cc74c2e6192()
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

      private sealed class MTHD_2620fedc658a4e078c84920cc0929209 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2620fedc658a4e078c84920cc0929209()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_121b4aa5e0254e8293c45481c0092d88 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_121b4aa5e0254e8293c45481c0092d88()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_f7c0181a04024bb8a9a3df80f862f54f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7c0181a04024bb8a9a3df80f862f54f()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_b8451a3336a142fe8c4c3564dc551477 : HardwiredMemberDescriptor
      {
        internal FLDV_b8451a3336a142fe8c4c3564dc551477()
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

      private sealed class FLDV_edb688a2bc6443318cad4878bdfe9e9c : HardwiredMemberDescriptor
      {
        internal FLDV_edb688a2bc6443318cad4878bdfe9e9c()
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

      private sealed class FLDV_accb8dbc5d2b45939e8bc140b67ce63f : HardwiredMemberDescriptor
      {
        internal FLDV_accb8dbc5d2b45939e8bc140b67ce63f()
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

      private sealed class FLDV_cb1298ad43e145559df6a877b4277957 : HardwiredMemberDescriptor
      {
        internal FLDV_cb1298ad43e145559df6a877b4277957()
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

      private sealed class FLDV_a254bd63f4f24684a3213e8e6779aff0 : HardwiredMemberDescriptor
      {
        internal FLDV_a254bd63f4f24684a3213e8e6779aff0()
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

      private sealed class FLDV_4f1ddf10441c40a0bcd17d3a61ac8d00 : HardwiredMemberDescriptor
      {
        internal FLDV_4f1ddf10441c40a0bcd17d3a61ac8d00()
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

      private sealed class FLDV_68fefc897f2c40bd859284cb05fceef3 : HardwiredMemberDescriptor
      {
        internal FLDV_68fefc897f2c40bd859284cb05fceef3()
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

      private sealed class FLDV_7285046e873d4d12ad6292e990810093 : HardwiredMemberDescriptor
      {
        internal FLDV_7285046e873d4d12ad6292e990810093()
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

      private sealed class FLDV_cf4be6ea8b45449f97facdb852221d96 : HardwiredMemberDescriptor
      {
        internal FLDV_cf4be6ea8b45449f97facdb852221d96()
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

      private sealed class FLDV_b3b78d8750ed40b9b5265ef3594f1391 : HardwiredMemberDescriptor
      {
        internal FLDV_b3b78d8750ed40b9b5265ef3594f1391()
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

      private sealed class FLDV_871c7de853694a84b9652fef94aedbd3 : HardwiredMemberDescriptor
      {
        internal FLDV_871c7de853694a84b9652fef94aedbd3()
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

      private sealed class FLDV_2e789a2cf4f248c8b507f7c701d42875 : HardwiredMemberDescriptor
      {
        internal FLDV_2e789a2cf4f248c8b507f7c701d42875()
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

      private sealed class FLDV_cf7ebfabdc334a388d20ab04f7472015 : HardwiredMemberDescriptor
      {
        internal FLDV_cf7ebfabdc334a388d20ab04f7472015()
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

    private sealed class TYPE_f3d4cbcba58c456a89f5525af6db3e3d : HardwiredUserDataDescriptor
    {
      internal TYPE_f3d4cbcba58c456a89f5525af6db3e3d()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_e85a7b2a9e2943b0b012c94f89417f50()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_ea781274b84742fcba5a5b2f62313061()
        }));
        this.AddMember("get_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_ea283fb7b01b446cb33f52a390349f09()
        }));
        this.AddMember("set_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_056086b717354320a647c86b47d2e611()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_ae0b3d76e6d143e7b09f52b4c1354ac4()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_558c1730e8c54d94986c02172206e9df()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_14a9f94a6a1742b481b751ce29aac592()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_f64159c4447a457e8141bbc8fbf70e96()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_6257e9c55b004cddae24656b8e074ac4()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_82bea2a106054acb85246a1ddd7a2f29()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_1348e147ea0643eb9d333677a6cccf38()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_12d476723f49492fb36cada2dae092b9()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_73ab11bbba33499a97b2750cad913dcb()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_6e5e8fb3143b4dfcb29295bdab3d9a42()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_d37d102ca3da4ebd993d10cf83991836()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_fd417d133cc84fd2a5d7716b7caa8e76()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_be5e254a3d5f4001a1ff2524b88ec72f()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_7335aea25823411db88bdfd699e3ffb4()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_b82dfcef5d264006a52c9e1e1069d8e8()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_4c84da47165f40e9b4f164f2fbd78155()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_d4d22d63061d472ea66777f3d5d086cf()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_afbb5a9cf191492c8d2081fbd25950a4()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_d7fdf95fcda0499fa3be423b22b05087()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_427e356871cc4cc1aacc6b697ae3c121()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_06b4886aefc640c48221852a9f2d26f9()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_5ec775fc01bf4b21baa93092d51543ab()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_ef913209f4d049fa985a3c0050597d40()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_9d0a082481544a4b94936c340ffacad8()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_218d087302d64ca685cb4ee670eb2a82()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_a0df5a0011ea4e499630179e39c8046d()
        }));
        this.AddMember("get_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_f24a94f34d2c4e98b28831113b8bd81e()
        }));
        this.AddMember("set_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_ff05455175884fe79cb08f6bfd836057()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_90505e3eb99649298b14695fb67a7f81()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_819278cf6c07487e859aa40f89aeff60()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_1f466ac1936c46fcac6cdc021a96de87()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_c7a95acf915b4baab0d5308c2d89f379()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_aecdca01718043aa814e2dbcd50e932b()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_c2f4b384a82a490695340fa2f5c5c8a7()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_8256f888b37f43ec8cb8799738719edf()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_3bff9b18a1d043ea8b8b891ddd0fda94()
        }));
        this.AddMember("get_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_efd3ef38ae0f4300adec4df62f0cd764()
        }));
        this.AddMember("set_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_36c08d9247f549c2b80a01c8e482018e()
        }));
        this.AddMember("get_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_99f13877292247ddbe289bee2dc5450a()
        }));
        this.AddMember("set_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_fdf81db77f65481a9c12d03248e313fc()
        }));
        this.AddMember("get_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_0667e2462cbd4e78a74a2c9642ee8d14()
        }));
        this.AddMember("set_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_617bcbea61a0407b813d2d619a69c933()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_8cffb0582127479f9fc8f9f9cd747b6b()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_679a67f0d1944a769f692fb514f58723()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_8ba259622bfe4bd7b6ce5a5893bb0bad()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_4a084674f90c46c3824c834cf7c059a4()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_32c1b86c3e14483d84ac5553f871ff74()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_c3067a66e65b4ca392c8d01e85e2d3ad()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_c4eda6f1e45e4e7da8cc7d3b7bfd8fa4()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_e4c3f0bba8dd4d59b537389b71247980()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_e1a464422b48489bab9fd7e6476ae854()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_c59ae24881b34d27a9d38c4c49cc59bf()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_a4e6d65d24bf4c9784acfd037b15971a()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_9e6f5da41e5f4081a0b7376c74995067()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_f91e5ce9d0b54adca51f5e12711f56dc()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.MTHD_dae37d138d9a4f40b3f5569e49b001f4()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.PROP_a757c983c68247128cc91178301a51c1());
        this.AddMember("visible", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.PROP_3b947bc730b5435f8ff95e4b10212c1b());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.PROP_1abbfaa2e9ab4e3e897c3afa9890219d());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.PROP_f7e4b181070e410baf326ae84319d243());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.PROP_b6ebe0109e60473b818bc6fae0ad1901());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.PROP_aa609bd46ac140678abc7429fd6ff1da());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.PROP_2967866039b34d05bc86762e08a8b5e1());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.PROP_ecf765350f734eb28f30eff2c48ea65e());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.PROP_81f56b1e65e84b5a90cef0c0283cc80e());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.PROP_887be5a7ac7c43128ab643d347f0cb0e());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.PROP_d7efc61cdba74fad9e7cc4af2e5ef8e7());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.PROP_b571371196404f67a21c0e3f81353aef());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.PROP_8730aed74c414e47a3e4a658b6d8e243());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.PROP_de5c75dd82c3457295a62ca6a2a73e53());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.PROP_43eaa0388dbb45af8a2c4f336e4d4825());
        this.AddMember("onClick2", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.PROP_22116f96c65f4297931af14b68f9230e());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.PROP_3a9e7bfa886548608fa9e99ea316c0a7());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.PROP_d8d09dfa3866424299ec61e38c42ed1a());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.PROP_3e192363ac194293ab72be36ead7efd4());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.PROP_8ffc59759f1c4ebdadb78615bdefff3d());
        this.AddMember("textColor2", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.PROP_4abeadd81afb489390f83984d06a2ea9());
        this.AddMember("highlightColor", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.PROP_689d4fcf00a64e36b7d4ce936b478d7a());
        this.AddMember("highlightColor2", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.PROP_e4f63a20de0f443196a1c9f2036e4b1a());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.PROP_a2cc966498d5416ab2b790ea321e3f16());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.PROP_498c843405e64983b601ee7bc5873993());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.FLDV_e933be0fc17146fca0d81cd19206f4a6());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.FLDV_3b9208d5ac9d4fa7a1bb558c9b8aa99d());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_f3d4cbcba58c456a89f5525af6db3e3d.FLDV_225b6ff280a9499db25a6ad0a3040a08());
      }

      private sealed class MTHD_e85a7b2a9e2943b0b012c94f89417f50 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e85a7b2a9e2943b0b012c94f89417f50()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_ea781274b84742fcba5a5b2f62313061 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea781274b84742fcba5a5b2f62313061()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_ea283fb7b01b446cb33f52a390349f09 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea283fb7b01b446cb33f52a390349f09()
        {
          this.Initialize("get_visible", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).visible;
        }
      }

      private sealed class MTHD_056086b717354320a647c86b47d2e611 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_056086b717354320a647c86b47d2e611()
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

      private sealed class MTHD_ae0b3d76e6d143e7b09f52b4c1354ac4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae0b3d76e6d143e7b09f52b4c1354ac4()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_558c1730e8c54d94986c02172206e9df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_558c1730e8c54d94986c02172206e9df()
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

      private sealed class MTHD_14a9f94a6a1742b481b751ce29aac592 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_14a9f94a6a1742b481b751ce29aac592()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_f64159c4447a457e8141bbc8fbf70e96 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f64159c4447a457e8141bbc8fbf70e96()
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

      private sealed class MTHD_6257e9c55b004cddae24656b8e074ac4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6257e9c55b004cddae24656b8e074ac4()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_82bea2a106054acb85246a1ddd7a2f29 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_82bea2a106054acb85246a1ddd7a2f29()
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

      private sealed class MTHD_1348e147ea0643eb9d333677a6cccf38 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1348e147ea0643eb9d333677a6cccf38()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_12d476723f49492fb36cada2dae092b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_12d476723f49492fb36cada2dae092b9()
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

      private sealed class MTHD_73ab11bbba33499a97b2750cad913dcb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_73ab11bbba33499a97b2750cad913dcb()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_6e5e8fb3143b4dfcb29295bdab3d9a42 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e5e8fb3143b4dfcb29295bdab3d9a42()
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

      private sealed class MTHD_d37d102ca3da4ebd993d10cf83991836 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d37d102ca3da4ebd993d10cf83991836()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_fd417d133cc84fd2a5d7716b7caa8e76 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd417d133cc84fd2a5d7716b7caa8e76()
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

      private sealed class MTHD_be5e254a3d5f4001a1ff2524b88ec72f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be5e254a3d5f4001a1ff2524b88ec72f()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_7335aea25823411db88bdfd699e3ffb4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7335aea25823411db88bdfd699e3ffb4()
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

      private sealed class MTHD_b82dfcef5d264006a52c9e1e1069d8e8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b82dfcef5d264006a52c9e1e1069d8e8()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_4c84da47165f40e9b4f164f2fbd78155 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c84da47165f40e9b4f164f2fbd78155()
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

      private sealed class MTHD_d4d22d63061d472ea66777f3d5d086cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d4d22d63061d472ea66777f3d5d086cf()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_afbb5a9cf191492c8d2081fbd25950a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_afbb5a9cf191492c8d2081fbd25950a4()
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

      private sealed class MTHD_d7fdf95fcda0499fa3be423b22b05087 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d7fdf95fcda0499fa3be423b22b05087()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_427e356871cc4cc1aacc6b697ae3c121 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_427e356871cc4cc1aacc6b697ae3c121()
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

      private sealed class MTHD_06b4886aefc640c48221852a9f2d26f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_06b4886aefc640c48221852a9f2d26f9()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_5ec775fc01bf4b21baa93092d51543ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ec775fc01bf4b21baa93092d51543ab()
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

      private sealed class MTHD_ef913209f4d049fa985a3c0050597d40 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef913209f4d049fa985a3c0050597d40()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_9d0a082481544a4b94936c340ffacad8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d0a082481544a4b94936c340ffacad8()
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

      private sealed class MTHD_218d087302d64ca685cb4ee670eb2a82 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_218d087302d64ca685cb4ee670eb2a82()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_a0df5a0011ea4e499630179e39c8046d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a0df5a0011ea4e499630179e39c8046d()
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

      private sealed class MTHD_f24a94f34d2c4e98b28831113b8bd81e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f24a94f34d2c4e98b28831113b8bd81e()
        {
          this.Initialize("get_onClick2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick2;
        }
      }

      private sealed class MTHD_ff05455175884fe79cb08f6bfd836057 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff05455175884fe79cb08f6bfd836057()
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

      private sealed class MTHD_90505e3eb99649298b14695fb67a7f81 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90505e3eb99649298b14695fb67a7f81()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_819278cf6c07487e859aa40f89aeff60 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_819278cf6c07487e859aa40f89aeff60()
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

      private sealed class MTHD_1f466ac1936c46fcac6cdc021a96de87 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f466ac1936c46fcac6cdc021a96de87()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color2;
        }
      }

      private sealed class MTHD_c7a95acf915b4baab0d5308c2d89f379 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c7a95acf915b4baab0d5308c2d89f379()
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

      private sealed class MTHD_aecdca01718043aa814e2dbcd50e932b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aecdca01718043aa814e2dbcd50e932b()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_c2f4b384a82a490695340fa2f5c5c8a7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c2f4b384a82a490695340fa2f5c5c8a7()
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

      private sealed class MTHD_8256f888b37f43ec8cb8799738719edf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8256f888b37f43ec8cb8799738719edf()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_3bff9b18a1d043ea8b8b891ddd0fda94 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3bff9b18a1d043ea8b8b891ddd0fda94()
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

      private sealed class MTHD_efd3ef38ae0f4300adec4df62f0cd764 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_efd3ef38ae0f4300adec4df62f0cd764()
        {
          this.Initialize("get_textColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor2;
        }
      }

      private sealed class MTHD_36c08d9247f549c2b80a01c8e482018e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_36c08d9247f549c2b80a01c8e482018e()
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

      private sealed class MTHD_99f13877292247ddbe289bee2dc5450a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99f13877292247ddbe289bee2dc5450a()
        {
          this.Initialize("get_highlightColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor;
        }
      }

      private sealed class MTHD_fdf81db77f65481a9c12d03248e313fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fdf81db77f65481a9c12d03248e313fc()
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

      private sealed class MTHD_0667e2462cbd4e78a74a2c9642ee8d14 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0667e2462cbd4e78a74a2c9642ee8d14()
        {
          this.Initialize("get_highlightColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor2;
        }
      }

      private sealed class MTHD_617bcbea61a0407b813d2d619a69c933 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_617bcbea61a0407b813d2d619a69c933()
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

      private sealed class MTHD_8cffb0582127479f9fc8f9f9cd747b6b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8cffb0582127479f9fc8f9f9cd747b6b()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_679a67f0d1944a769f692fb514f58723 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_679a67f0d1944a769f692fb514f58723()
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

      private sealed class MTHD_8ba259622bfe4bd7b6ce5a5893bb0bad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ba259622bfe4bd7b6ce5a5893bb0bad()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_4a084674f90c46c3824c834cf7c059a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a084674f90c46c3824c834cf7c059a4()
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

      private sealed class MTHD_32c1b86c3e14483d84ac5553f871ff74 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_32c1b86c3e14483d84ac5553f871ff74()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c3067a66e65b4ca392c8d01e85e2d3ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c3067a66e65b4ca392c8d01e85e2d3ad()
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

      private sealed class MTHD_c4eda6f1e45e4e7da8cc7d3b7bfd8fa4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c4eda6f1e45e4e7da8cc7d3b7bfd8fa4()
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

      private sealed class MTHD_e4c3f0bba8dd4d59b537389b71247980 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e4c3f0bba8dd4d59b537389b71247980()
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

      private sealed class MTHD_e1a464422b48489bab9fd7e6476ae854 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e1a464422b48489bab9fd7e6476ae854()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c59ae24881b34d27a9d38c4c49cc59bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c59ae24881b34d27a9d38c4c49cc59bf()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_a4e6d65d24bf4c9784acfd037b15971a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a4e6d65d24bf4c9784acfd037b15971a()
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

      private sealed class MTHD_9e6f5da41e5f4081a0b7376c74995067 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e6f5da41e5f4081a0b7376c74995067()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_f91e5ce9d0b54adca51f5e12711f56dc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f91e5ce9d0b54adca51f5e12711f56dc()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_dae37d138d9a4f40b3f5569e49b001f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dae37d138d9a4f40b3f5569e49b001f4()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_a757c983c68247128cc91178301a51c1 : HardwiredMemberDescriptor
      {
        internal PROP_a757c983c68247128cc91178301a51c1()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_3b947bc730b5435f8ff95e4b10212c1b : HardwiredMemberDescriptor
      {
        internal PROP_3b947bc730b5435f8ff95e4b10212c1b()
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

      private sealed class PROP_1abbfaa2e9ab4e3e897c3afa9890219d : HardwiredMemberDescriptor
      {
        internal PROP_1abbfaa2e9ab4e3e897c3afa9890219d()
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

      private sealed class PROP_f7e4b181070e410baf326ae84319d243 : HardwiredMemberDescriptor
      {
        internal PROP_f7e4b181070e410baf326ae84319d243()
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

      private sealed class PROP_b6ebe0109e60473b818bc6fae0ad1901 : HardwiredMemberDescriptor
      {
        internal PROP_b6ebe0109e60473b818bc6fae0ad1901()
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

      private sealed class PROP_aa609bd46ac140678abc7429fd6ff1da : HardwiredMemberDescriptor
      {
        internal PROP_aa609bd46ac140678abc7429fd6ff1da()
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

      private sealed class PROP_2967866039b34d05bc86762e08a8b5e1 : HardwiredMemberDescriptor
      {
        internal PROP_2967866039b34d05bc86762e08a8b5e1()
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

      private sealed class PROP_ecf765350f734eb28f30eff2c48ea65e : HardwiredMemberDescriptor
      {
        internal PROP_ecf765350f734eb28f30eff2c48ea65e()
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

      private sealed class PROP_81f56b1e65e84b5a90cef0c0283cc80e : HardwiredMemberDescriptor
      {
        internal PROP_81f56b1e65e84b5a90cef0c0283cc80e()
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

      private sealed class PROP_887be5a7ac7c43128ab643d347f0cb0e : HardwiredMemberDescriptor
      {
        internal PROP_887be5a7ac7c43128ab643d347f0cb0e()
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

      private sealed class PROP_d7efc61cdba74fad9e7cc4af2e5ef8e7 : HardwiredMemberDescriptor
      {
        internal PROP_d7efc61cdba74fad9e7cc4af2e5ef8e7()
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

      private sealed class PROP_b571371196404f67a21c0e3f81353aef : HardwiredMemberDescriptor
      {
        internal PROP_b571371196404f67a21c0e3f81353aef()
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

      private sealed class PROP_8730aed74c414e47a3e4a658b6d8e243 : HardwiredMemberDescriptor
      {
        internal PROP_8730aed74c414e47a3e4a658b6d8e243()
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

      private sealed class PROP_de5c75dd82c3457295a62ca6a2a73e53 : HardwiredMemberDescriptor
      {
        internal PROP_de5c75dd82c3457295a62ca6a2a73e53()
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

      private sealed class PROP_43eaa0388dbb45af8a2c4f336e4d4825 : HardwiredMemberDescriptor
      {
        internal PROP_43eaa0388dbb45af8a2c4f336e4d4825()
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

      private sealed class PROP_22116f96c65f4297931af14b68f9230e : HardwiredMemberDescriptor
      {
        internal PROP_22116f96c65f4297931af14b68f9230e()
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

      private sealed class PROP_3a9e7bfa886548608fa9e99ea316c0a7 : HardwiredMemberDescriptor
      {
        internal PROP_3a9e7bfa886548608fa9e99ea316c0a7()
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

      private sealed class PROP_d8d09dfa3866424299ec61e38c42ed1a : HardwiredMemberDescriptor
      {
        internal PROP_d8d09dfa3866424299ec61e38c42ed1a()
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

      private sealed class PROP_3e192363ac194293ab72be36ead7efd4 : HardwiredMemberDescriptor
      {
        internal PROP_3e192363ac194293ab72be36ead7efd4()
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

      private sealed class PROP_8ffc59759f1c4ebdadb78615bdefff3d : HardwiredMemberDescriptor
      {
        internal PROP_8ffc59759f1c4ebdadb78615bdefff3d()
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

      private sealed class PROP_4abeadd81afb489390f83984d06a2ea9 : HardwiredMemberDescriptor
      {
        internal PROP_4abeadd81afb489390f83984d06a2ea9()
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

      private sealed class PROP_689d4fcf00a64e36b7d4ce936b478d7a : HardwiredMemberDescriptor
      {
        internal PROP_689d4fcf00a64e36b7d4ce936b478d7a()
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

      private sealed class PROP_e4f63a20de0f443196a1c9f2036e4b1a : HardwiredMemberDescriptor
      {
        internal PROP_e4f63a20de0f443196a1c9f2036e4b1a()
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

      private sealed class PROP_a2cc966498d5416ab2b790ea321e3f16 : HardwiredMemberDescriptor
      {
        internal PROP_a2cc966498d5416ab2b790ea321e3f16()
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

      private sealed class PROP_498c843405e64983b601ee7bc5873993 : HardwiredMemberDescriptor
      {
        internal PROP_498c843405e64983b601ee7bc5873993()
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

      private sealed class FLDV_e933be0fc17146fca0d81cd19206f4a6 : HardwiredMemberDescriptor
      {
        internal FLDV_e933be0fc17146fca0d81cd19206f4a6()
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

      private sealed class FLDV_3b9208d5ac9d4fa7a1bb558c9b8aa99d : HardwiredMemberDescriptor
      {
        internal FLDV_3b9208d5ac9d4fa7a1bb558c9b8aa99d()
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

      private sealed class FLDV_225b6ff280a9499db25a6ad0a3040a08 : HardwiredMemberDescriptor
      {
        internal FLDV_225b6ff280a9499db25a6ad0a3040a08()
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

    private sealed class TYPE_f9aa562922044a588b3b57b86ec27d24 : HardwiredUserDataDescriptor
    {
      internal TYPE_f9aa562922044a588b3b57b86ec27d24()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f9aa562922044a588b3b57b86ec27d24.MTHD_c434d2313cca4a12976fdcd5a186e5be()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f9aa562922044a588b3b57b86ec27d24.MTHD_2c6a4b44c9e44c68b4d6633108e597e7()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f9aa562922044a588b3b57b86ec27d24.MTHD_207ff6308ad840cbbde0fe2ced378d50()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f9aa562922044a588b3b57b86ec27d24.MTHD_bd16c572f9b746498fc7d9175367cb6e()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f9aa562922044a588b3b57b86ec27d24.MTHD_e3db0160fddf4f30928910ac5728c294()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f9aa562922044a588b3b57b86ec27d24.MTHD_153655cb1e59402f8d3d4774aa7fe9a1()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_f9aa562922044a588b3b57b86ec27d24.FLDV_34ceb24ca5324525b1af0eeef7e23c79());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_f9aa562922044a588b3b57b86ec27d24.FLDV_837e50cc2059484ebd08389e8f7bc59c());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_f9aa562922044a588b3b57b86ec27d24.FLDV_ca2ad408366044a7868f5134a6b64b51());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_f9aa562922044a588b3b57b86ec27d24.FLDV_7c61800de9f648678403a912bc87fe27());
      }

      private sealed class MTHD_c434d2313cca4a12976fdcd5a186e5be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c434d2313cca4a12976fdcd5a186e5be()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_2c6a4b44c9e44c68b4d6633108e597e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c6a4b44c9e44c68b4d6633108e597e7()
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

      private sealed class MTHD_207ff6308ad840cbbde0fe2ced378d50 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_207ff6308ad840cbbde0fe2ced378d50()
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

      private sealed class MTHD_bd16c572f9b746498fc7d9175367cb6e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd16c572f9b746498fc7d9175367cb6e()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_e3db0160fddf4f30928910ac5728c294 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e3db0160fddf4f30928910ac5728c294()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_153655cb1e59402f8d3d4774aa7fe9a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_153655cb1e59402f8d3d4774aa7fe9a1()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_34ceb24ca5324525b1af0eeef7e23c79 : HardwiredMemberDescriptor
      {
        internal FLDV_34ceb24ca5324525b1af0eeef7e23c79()
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

      private sealed class FLDV_837e50cc2059484ebd08389e8f7bc59c : HardwiredMemberDescriptor
      {
        internal FLDV_837e50cc2059484ebd08389e8f7bc59c()
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

      private sealed class FLDV_ca2ad408366044a7868f5134a6b64b51 : HardwiredMemberDescriptor
      {
        internal FLDV_ca2ad408366044a7868f5134a6b64b51()
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

      private sealed class FLDV_7c61800de9f648678403a912bc87fe27 : HardwiredMemberDescriptor
      {
        internal FLDV_7c61800de9f648678403a912bc87fe27()
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

    private sealed class TYPE_552193ead99c487d8f6ec9ed1acf055f : HardwiredUserDataDescriptor
    {
      internal TYPE_552193ead99c487d8f6ec9ed1acf055f()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_552193ead99c487d8f6ec9ed1acf055f.MTHD_c6d71a96e03548beb140d70750953e8c()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_552193ead99c487d8f6ec9ed1acf055f.MTHD_3fbeaf377d9d409783cd1ebb4be43b93()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_552193ead99c487d8f6ec9ed1acf055f.MTHD_6645d75d76c64d33bbd99780fa6b6f42()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_552193ead99c487d8f6ec9ed1acf055f.MTHD_a01efe6db6d244318066816c2db6c66a()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_552193ead99c487d8f6ec9ed1acf055f.MTHD_60dc3e492cd2402391dcf2d3bd81a5fd()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_552193ead99c487d8f6ec9ed1acf055f.FLDV_88aedf31b6e74158adf37bc57fe007ff());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_552193ead99c487d8f6ec9ed1acf055f.FLDV_cdba29855e8546d485270383df0b8bd8());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_552193ead99c487d8f6ec9ed1acf055f.FLDV_f345cc4ca051498da15b12c09f5899e7());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_552193ead99c487d8f6ec9ed1acf055f.FLDV_2435e8719d3f49faa51b877692966fc2());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_552193ead99c487d8f6ec9ed1acf055f.FLDV_f147426ac83c432d88ae2e323d1be2e0());
      }

      private sealed class MTHD_c6d71a96e03548beb140d70750953e8c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c6d71a96e03548beb140d70750953e8c()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_3fbeaf377d9d409783cd1ebb4be43b93 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3fbeaf377d9d409783cd1ebb4be43b93()
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

      private sealed class MTHD_6645d75d76c64d33bbd99780fa6b6f42 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6645d75d76c64d33bbd99780fa6b6f42()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_a01efe6db6d244318066816c2db6c66a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a01efe6db6d244318066816c2db6c66a()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_60dc3e492cd2402391dcf2d3bd81a5fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60dc3e492cd2402391dcf2d3bd81a5fd()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_88aedf31b6e74158adf37bc57fe007ff : HardwiredMemberDescriptor
      {
        internal FLDV_88aedf31b6e74158adf37bc57fe007ff()
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

      private sealed class FLDV_cdba29855e8546d485270383df0b8bd8 : HardwiredMemberDescriptor
      {
        internal FLDV_cdba29855e8546d485270383df0b8bd8()
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

      private sealed class FLDV_f345cc4ca051498da15b12c09f5899e7 : HardwiredMemberDescriptor
      {
        internal FLDV_f345cc4ca051498da15b12c09f5899e7()
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

      private sealed class FLDV_2435e8719d3f49faa51b877692966fc2 : HardwiredMemberDescriptor
      {
        internal FLDV_2435e8719d3f49faa51b877692966fc2()
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

      private sealed class FLDV_f147426ac83c432d88ae2e323d1be2e0 : HardwiredMemberDescriptor
      {
        internal FLDV_f147426ac83c432d88ae2e323d1be2e0()
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

    private sealed class TYPE_b37d25832f274bc7b586a244954e25bd : HardwiredUserDataDescriptor
    {
      internal TYPE_b37d25832f274bc7b586a244954e25bd()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b37d25832f274bc7b586a244954e25bd.MTHD_bdddc5a5789446498e222fe2f750be62()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b37d25832f274bc7b586a244954e25bd.MTHD_4f8886446bb445e59b0d3875fa2c179c()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b37d25832f274bc7b586a244954e25bd.MTHD_e6595a91050747c998b1ca79034bb209()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b37d25832f274bc7b586a244954e25bd.MTHD_86058f154f5044789b50a93cc673ff72()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b37d25832f274bc7b586a244954e25bd.MTHD_aa7164caaf314c8fb236b55089efa596()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b37d25832f274bc7b586a244954e25bd.MTHD_8fffc8d66253475e994c5376e54293a1()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b37d25832f274bc7b586a244954e25bd.MTHD_338d5d705ad84fb0b037fcdb965e7847()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b37d25832f274bc7b586a244954e25bd.MTHD_e745ac9444964e6e890d2a27d4437520()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b37d25832f274bc7b586a244954e25bd.MTHD_65fa3b5aa74148dbb252b4f145f80a34()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b37d25832f274bc7b586a244954e25bd.MTHD_57e6d3dff03d408ca577fde20e552b51()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b37d25832f274bc7b586a244954e25bd.MTHD_bf972420795a4441b6b7ba1442c0758c()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b37d25832f274bc7b586a244954e25bd.MTHD_01f4398e06fe414ca613007a103089c2()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b37d25832f274bc7b586a244954e25bd.MTHD_d6b4d47aa23b42b8864cd046256ca4ee()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_b37d25832f274bc7b586a244954e25bd.FLDV_d82b8cb54f7244df81d0980df392196c());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_b37d25832f274bc7b586a244954e25bd.FLDV_70e9260fa25b48cfa914c1e0c546fa80());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_b37d25832f274bc7b586a244954e25bd.FLDV_275656fe6172414c8e020364c2c1fa60());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_b37d25832f274bc7b586a244954e25bd.FLDV_fdf683ed134a452aa64b1c35a4fd92aa());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_b37d25832f274bc7b586a244954e25bd.FLDV_c65474b327ac4c989e46454c520496aa());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_b37d25832f274bc7b586a244954e25bd.FLDV_5e6e4a47db0940ee839a878d9c634fd6());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_b37d25832f274bc7b586a244954e25bd.FLDV_5c51aa59671c4ba3b596c7e92214b860());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_b37d25832f274bc7b586a244954e25bd.FLDV_5f9bd35a4a7b47d4a2ed7610cbe80b86());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_b37d25832f274bc7b586a244954e25bd.DVAL_5d9a82c74a8549eeaabcacab039e8234());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_b37d25832f274bc7b586a244954e25bd.DVAL_4544eebb24254551ba98dee96e9532f7());
      }

      private sealed class MTHD_bdddc5a5789446498e222fe2f750be62 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bdddc5a5789446498e222fe2f750be62()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_4f8886446bb445e59b0d3875fa2c179c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4f8886446bb445e59b0d3875fa2c179c()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_e6595a91050747c998b1ca79034bb209 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e6595a91050747c998b1ca79034bb209()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_86058f154f5044789b50a93cc673ff72 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_86058f154f5044789b50a93cc673ff72()
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

      private sealed class MTHD_aa7164caaf314c8fb236b55089efa596 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa7164caaf314c8fb236b55089efa596()
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

      private sealed class MTHD_8fffc8d66253475e994c5376e54293a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8fffc8d66253475e994c5376e54293a1()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_338d5d705ad84fb0b037fcdb965e7847 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_338d5d705ad84fb0b037fcdb965e7847()
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

      private sealed class MTHD_e745ac9444964e6e890d2a27d4437520 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e745ac9444964e6e890d2a27d4437520()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_65fa3b5aa74148dbb252b4f145f80a34 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65fa3b5aa74148dbb252b4f145f80a34()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_57e6d3dff03d408ca577fde20e552b51 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57e6d3dff03d408ca577fde20e552b51()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_bf972420795a4441b6b7ba1442c0758c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf972420795a4441b6b7ba1442c0758c()
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

      private sealed class MTHD_01f4398e06fe414ca613007a103089c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_01f4398e06fe414ca613007a103089c2()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_d6b4d47aa23b42b8864cd046256ca4ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6b4d47aa23b42b8864cd046256ca4ee()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_d82b8cb54f7244df81d0980df392196c : HardwiredMemberDescriptor
      {
        internal FLDV_d82b8cb54f7244df81d0980df392196c()
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

      private sealed class FLDV_70e9260fa25b48cfa914c1e0c546fa80 : HardwiredMemberDescriptor
      {
        internal FLDV_70e9260fa25b48cfa914c1e0c546fa80()
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

      private sealed class FLDV_275656fe6172414c8e020364c2c1fa60 : HardwiredMemberDescriptor
      {
        internal FLDV_275656fe6172414c8e020364c2c1fa60()
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

      private sealed class FLDV_fdf683ed134a452aa64b1c35a4fd92aa : HardwiredMemberDescriptor
      {
        internal FLDV_fdf683ed134a452aa64b1c35a4fd92aa()
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

      private sealed class FLDV_c65474b327ac4c989e46454c520496aa : HardwiredMemberDescriptor
      {
        internal FLDV_c65474b327ac4c989e46454c520496aa()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_5e6e4a47db0940ee839a878d9c634fd6 : HardwiredMemberDescriptor
      {
        internal FLDV_5e6e4a47db0940ee839a878d9c634fd6()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_5c51aa59671c4ba3b596c7e92214b860 : HardwiredMemberDescriptor
      {
        internal FLDV_5c51aa59671c4ba3b596c7e92214b860()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_5f9bd35a4a7b47d4a2ed7610cbe80b86 : HardwiredMemberDescriptor
      {
        internal FLDV_5f9bd35a4a7b47d4a2ed7610cbe80b86()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_5d9a82c74a8549eeaabcacab039e8234 : DynValueMemberDescriptor
      {
        internal DVAL_5d9a82c74a8549eeaabcacab039e8234()
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

      private sealed class DVAL_4544eebb24254551ba98dee96e9532f7 : DynValueMemberDescriptor
      {
        internal DVAL_4544eebb24254551ba98dee96e9532f7()
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

    private sealed class TYPE_829c7964b7c54264b61a9ff48de97f65 : HardwiredUserDataDescriptor
    {
      internal TYPE_829c7964b7c54264b61a9ff48de97f65()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_829c7964b7c54264b61a9ff48de97f65.MTHD_3d62caf1f75d4189ac520da50ed1fb1a()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_829c7964b7c54264b61a9ff48de97f65.MTHD_d85eef7289ba4a4686235b74fd4c4208()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_829c7964b7c54264b61a9ff48de97f65.MTHD_dfad8bead2c74bbfb3f0721e746fe10b(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_829c7964b7c54264b61a9ff48de97f65.MTHD_c22d9be8f656463698c380e73dbb0fe1()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_829c7964b7c54264b61a9ff48de97f65.MTHD_2276973a52f24cfdb54f433be141e1a0(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_829c7964b7c54264b61a9ff48de97f65.MTHD_cbf1afd4e777412cb8e8abcc09a174ce()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_829c7964b7c54264b61a9ff48de97f65.MTHD_9ae24b84ffa4436a88cad821cfd619ca()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_829c7964b7c54264b61a9ff48de97f65.MTHD_9ed7ad87a2e64ca0b269437529969d6a()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_829c7964b7c54264b61a9ff48de97f65.MTHD_4d10f4cfca8f4f85ae9272e2b17d929d()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_829c7964b7c54264b61a9ff48de97f65.MTHD_046b0e531b7643188ddda5806f3f3156()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_829c7964b7c54264b61a9ff48de97f65.FLDV_7ccc75991a344937ae65c26908c3d0c3());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_829c7964b7c54264b61a9ff48de97f65.FLDV_f1eb799f36ae4b8faa0bb227640beb64());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_829c7964b7c54264b61a9ff48de97f65.FLDV_a171deaf4b114946975dfefb55db298a());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_829c7964b7c54264b61a9ff48de97f65.FLDV_3255d991f7f847aa929066febc882fc9());
        this.AddMember("white", (IMemberDescriptor) new Bridge.TYPE_829c7964b7c54264b61a9ff48de97f65.FLDV_da829b445ba04516ae450e36b8f12100());
      }

      private sealed class MTHD_3d62caf1f75d4189ac520da50ed1fb1a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d62caf1f75d4189ac520da50ed1fb1a()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_d85eef7289ba4a4686235b74fd4c4208 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d85eef7289ba4a4686235b74fd4c4208()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_dfad8bead2c74bbfb3f0721e746fe10b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dfad8bead2c74bbfb3f0721e746fe10b()
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

      private sealed class MTHD_c22d9be8f656463698c380e73dbb0fe1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c22d9be8f656463698c380e73dbb0fe1()
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

      private sealed class MTHD_2276973a52f24cfdb54f433be141e1a0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2276973a52f24cfdb54f433be141e1a0()
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

      private sealed class MTHD_cbf1afd4e777412cb8e8abcc09a174ce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cbf1afd4e777412cb8e8abcc09a174ce()
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

      private sealed class MTHD_9ae24b84ffa4436a88cad821cfd619ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ae24b84ffa4436a88cad821cfd619ca()
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

      private sealed class MTHD_9ed7ad87a2e64ca0b269437529969d6a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ed7ad87a2e64ca0b269437529969d6a()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_4d10f4cfca8f4f85ae9272e2b17d929d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d10f4cfca8f4f85ae9272e2b17d929d()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_046b0e531b7643188ddda5806f3f3156 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_046b0e531b7643188ddda5806f3f3156()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_7ccc75991a344937ae65c26908c3d0c3 : HardwiredMemberDescriptor
      {
        internal FLDV_7ccc75991a344937ae65c26908c3d0c3()
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

      private sealed class FLDV_f1eb799f36ae4b8faa0bb227640beb64 : HardwiredMemberDescriptor
      {
        internal FLDV_f1eb799f36ae4b8faa0bb227640beb64()
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

      private sealed class FLDV_a171deaf4b114946975dfefb55db298a : HardwiredMemberDescriptor
      {
        internal FLDV_a171deaf4b114946975dfefb55db298a()
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

      private sealed class FLDV_3255d991f7f847aa929066febc882fc9 : HardwiredMemberDescriptor
      {
        internal FLDV_3255d991f7f847aa929066febc882fc9()
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

      private sealed class FLDV_da829b445ba04516ae450e36b8f12100 : HardwiredMemberDescriptor
      {
        internal FLDV_da829b445ba04516ae450e36b8f12100()
          : base(typeof (LuaColor), "white", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) LuaColor.white;
        }
      }
    }

    private sealed class TYPE_5d0226ef418346868209b89bb45ae8e5 : HardwiredUserDataDescriptor
    {
      internal TYPE_5d0226ef418346868209b89bb45ae8e5()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d0226ef418346868209b89bb45ae8e5.MTHD_65be8130ea2e4afca18bf61fba1bb154()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d0226ef418346868209b89bb45ae8e5.MTHD_08bd6ea508e3405eb66b997552fb9502()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d0226ef418346868209b89bb45ae8e5.MTHD_e7166a5d144249feb21c1552caf5a6b0()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d0226ef418346868209b89bb45ae8e5.MTHD_695b1fb3bbeb40069ae02ae1c2f6b3aa()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d0226ef418346868209b89bb45ae8e5.MTHD_bada1bd1b8b040a1927583f4e6f44804()
        }));
      }

      private sealed class MTHD_65be8130ea2e4afca18bf61fba1bb154 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65be8130ea2e4afca18bf61fba1bb154()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_08bd6ea508e3405eb66b997552fb9502 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_08bd6ea508e3405eb66b997552fb9502()
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

      private sealed class MTHD_e7166a5d144249feb21c1552caf5a6b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7166a5d144249feb21c1552caf5a6b0()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_695b1fb3bbeb40069ae02ae1c2f6b3aa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_695b1fb3bbeb40069ae02ae1c2f6b3aa()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_bada1bd1b8b040a1927583f4e6f44804 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bada1bd1b8b040a1927583f4e6f44804()
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
