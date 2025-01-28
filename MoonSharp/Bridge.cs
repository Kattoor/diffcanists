
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
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_49f1e44fe0c74cdc9f30dfe2e272324d());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_45b1bf24594344b29a271cbcf49f13db());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_d140d804e4cc407da2d335a49729ae0f());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_71e3fcb853144d808b5d749518ac0030());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_350580a35cc445c08deb4ddc4d3f8030());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_f6ff41ebbb4c4a7496ff0cf84d3c04fe());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_806a2c37519a4e3b95dc09d4524290ef());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_504e3b0461354e8e9cee00c1756887fe());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_6e79e883aeb0445db25bea64c9fbba3f());
    }

    private sealed class TYPE_6ae6ca9ca0264380b781b7fb43feb705 : HardwiredUserDataDescriptor
    {
      internal TYPE_6ae6ca9ca0264380b781b7fb43feb705()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_e8fac3ac4820496cacb8e4a98ca4137a()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_35738ad2c9104dce9fa0c7ebb1d5c634()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_a3ff7b1b82b340aba957f51a65a6a6c4()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_ec849401566d49b3a6a0e81190f10502()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_463448fb41fa4bfd88f6c4965fe84c78()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_d0277d47eee74b14bf6e35c4c3069238()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_57a6f268341b4e068bc03fc94748b034()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_df0e2bfaa0d047cea79fcf2616d3be7d()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_ba2d9eb6b15b44d3a0dc80a8fc537a30()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_322f5fd78b4f48fa8c51aeb032dd9cc7()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_d7ee448b4a774b80a9c59578c51b7afe()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_c1aabb0a77c54ec4a98d40604c321159()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_76dfd265fcc3414b80d17ea7de9ab73a()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_00e1920d0dcf461593d188ab4f726a3c()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_886822dba6bf45de980163f3c359cc2a()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_d63933a76be547c8bd252ec985f5b9ce()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_e4bbb4f5c25d474e8a1fef8f9bc42336()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_d63b9a74dde041ac9254bf5776c390e7()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_1ae2d2ab75b54a2bb181b93e315b94b7()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_aa354d40910c47158b8cced6a8bf709a()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_027ddfb6b9e843ee8b67e1558f0abfb2()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_9730ce5779ff4f60b73d915da0f9e126()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_caf08d52deb747dba184cb14e403b14d()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_fbe1ee3427334600bebb8fd9e93d83c0()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_5914b4e2f90e4bf2b0d7bc6bb31dae58()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_67b33740359b46ff9fbc9a86c61d448c()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_1f7989c019c949bb9e551d2960fd05cc()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_8581b4d6248a49d4b0992155a52b70bf()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_2b8314b8380f4e0cb49a4af6d48a17bb()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_d8ebe63faf9f4e5685df506e02fde63b()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_f7eba09dd6e54000b022f437b4c3a7fe()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_2377302fd2a84d9eb2088cf2e9aacd8e()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_69270825173a460c99ac0635c3f35542()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_68c5067a991543348ec8a12bbcfbc812()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_6424cfb051d7477ab5258752e513270f()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_6bb4557ffc5a466db060caf6841e2903()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_41e4ae8b0501481fbed922e89395a86c()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_06902cb8654342ae8a9ed240d7eeb80d()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_2f8fece9eda84897bd1342bedfa98356()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_773b4cb0596b4b78b779808ad7d226a5()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_ade96fb5e67a4a2cab97c8cdc9604350()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_1600af143b954abbae5deedd02aed561()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_7a5033d7ad5c4c518bd78f40e6968c3e()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_282b31637df743c89c37aa736accb85b()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_1ee841399ddd4d438d94f45ff0655690()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_ae8e1e94f98e44749b4736c90d2a5748()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_efc5e7803fb94729aea914a38b10ebf9()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_c320a91d086a4df39aa060d1d1100648()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_ae157a87c53c496caa57d3d9e9c78282()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_bd005db89fa845f8af6b69d75e5b88c3()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_dab11a02e4de4ed2bb9cf9cac27b9e57()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_c7c5c12af43d49cfba35815afd691128()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_176734417f254d899e1620867b27b1ed()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_d85eecfa0fdb4cf4bf816e1073a549ab()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_7cd170e759804ebeae7f6e6bdf558dda()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_a1fd62cd409049fd87dd8b3352150eb3()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_f0cd0cc23d604c5584359f42d39a16f1()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_627e3d8fd8254ebf972b0a900dc95c93()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_b7d34d14adb646d5a8f01989c5266f5a()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_25709990627d4f3380aeeebf53294bf8()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_15ca8576e5b748ca955cbe342c3e61a2()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_f03d1df304684ac08706a65ffb034b56()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_8abebc45f7fd41eca7686f9dec84c597()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_596773e279ea4d19a8b8eded3098e50a()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_917fe449fef94f0aa22d06f27c5cef7c()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_fb689de31ec2436eb83604b53d039519()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_54eb59a7085b40a081480d2d1bc9d112()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_b5795efff10947db858fcdafca63c399()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_d50b55e699fd43c9b2fb4128207b287e()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_b1583b698f0b4fdcb31a01b0ee814554()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_4894c17b4f1548429d50970389e9b9d8()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_579acebd30804abfb360865b3e51d531()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_4ee3cf5aeaac4f88a707219e4b5a910a()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_04ea9b19d04644b4a234a62d5dffd80d()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_b8733a2db44142ac83ad2c329fe86bd7()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_2dd43c77df7e43d6b93e548b20667471()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_053eb23dc1e94a2bbd21c2f6e5cc7dd3()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_fca0b6a5588744cc80b8bd488e62b1b5()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_9da6c61748244442ab1676148a964b24()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_3257010e34c14755ae08b01725e118eb()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_787806d74331447fb4b9f7cd91e6fd7b()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_acc59286e75149b7a90678cb2c3727d3()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_71dd5a37ce5645e38e5b56ce4b9edda3()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_e041e7fb4ffc42c1945c531431f0a226()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_94ed920027224f4fbd718c8b028c02e5()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_da0ecbf3b8274678b682be10fc8efaa0()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_d8a386151c0048628da4262456b5433e()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_d324868ccbf64cd8adbae7e6f14f719f()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_231b9fc927b1492ebc20a283545f35a5()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_23b5f6741c7e4f85970aa79e838a3474()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_7afeb51adba546d2a2dd6e1913f29de6()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_26678fce93184fda84087f5b88d7ecc0()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_c438f8ba27c44f7c8365eee5b4e43a83()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_dc7ccf89e5394ecba67b8944164a36eb()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_862f1f94ac104f7eb03a0d5127dd1982()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_67e8580f70c54008a12b357b14a31813()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.MTHD_88369869937c477c87b65dfd27efbf7d()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_2ac433cb9b2848a4bf6b397c6fcdfc11());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_8b5ef18a321149f8b164bf3479a119ae());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_80397ef76d7a400aa716f1754b921f66());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_30ede4a9ff824fd4837faed35934aabf());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_16781ddd836940938bf2a0719cc362a6());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_ab3c7074ea8a450bb94dbd352978a8f0());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_0a54e829f98541d79679e624dcfedc69());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_e47b3c208e854981aae61b79f6569a1e());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_6f3126343a664d96823fcaf8340fcfcb());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_f49072e77dd24b2190100019aa9e2e2d());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_c7f2cda53a454640bc2cf4970015551d());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_358a7599a3c842a48c9457ecbc02d6f5());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_a6c71d5d65b24d4397478f6d3650e0ad());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_efe167fae0ee4b549908c46859120e5d());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_39832fd6a7144220b943818b5e5a4a23());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_16632a7a34d845adbea68471d3feeb1c());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_0a375c578f6e4afc8c5795d13ffe18d9());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_c3df5f77ae894072828fd34181e4e5a5());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_e56f57c1fa1a4c94877cbe7c897b09cf());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_b517b66fbb9c46f0a7c0f8ab744458ef());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_745f5a5edf5847ffa4423e336ecb8fbe());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_cac73a0c161f411e8e7969a34865e023());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_289b6e96dbb242c992e463b2f8970525());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_29b563166dfc46f9bba576e49c1933a2());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_d86f4fff46d54ddf81d60d4797167221());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_e2ad39c8a49341a386b23d1cba8a7925());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_2eab0304d2ca488ab31e354b49584984());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_15c392c880d240c5a45ae44a88a9b8db());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_f327d2a1e8384d53b3c1dd35ffe2693b());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_ad0a7f6eb258421eac9ba76534d08c40());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_d074de2289db4f8480dbcc66787913f0());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_6ae6ca9ca0264380b781b7fb43feb705.PROP_019e7929df9c49c7ab044a30f831bded());
      }

      private sealed class MTHD_e8fac3ac4820496cacb8e4a98ca4137a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e8fac3ac4820496cacb8e4a98ca4137a()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_35738ad2c9104dce9fa0c7ebb1d5c634 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35738ad2c9104dce9fa0c7ebb1d5c634()
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

      private sealed class MTHD_a3ff7b1b82b340aba957f51a65a6a6c4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a3ff7b1b82b340aba957f51a65a6a6c4()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_ec849401566d49b3a6a0e81190f10502 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec849401566d49b3a6a0e81190f10502()
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

      private sealed class MTHD_463448fb41fa4bfd88f6c4965fe84c78 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_463448fb41fa4bfd88f6c4965fe84c78()
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

      private sealed class MTHD_d0277d47eee74b14bf6e35c4c3069238 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0277d47eee74b14bf6e35c4c3069238()
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

      private sealed class MTHD_57a6f268341b4e068bc03fc94748b034 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57a6f268341b4e068bc03fc94748b034()
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

      private sealed class MTHD_df0e2bfaa0d047cea79fcf2616d3be7d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_df0e2bfaa0d047cea79fcf2616d3be7d()
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

      private sealed class MTHD_ba2d9eb6b15b44d3a0dc80a8fc537a30 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba2d9eb6b15b44d3a0dc80a8fc537a30()
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

      private sealed class MTHD_322f5fd78b4f48fa8c51aeb032dd9cc7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_322f5fd78b4f48fa8c51aeb032dd9cc7()
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

      private sealed class MTHD_d7ee448b4a774b80a9c59578c51b7afe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d7ee448b4a774b80a9c59578c51b7afe()
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

      private sealed class MTHD_c1aabb0a77c54ec4a98d40604c321159 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c1aabb0a77c54ec4a98d40604c321159()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_76dfd265fcc3414b80d17ea7de9ab73a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76dfd265fcc3414b80d17ea7de9ab73a()
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

      private sealed class MTHD_00e1920d0dcf461593d188ab4f726a3c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_00e1920d0dcf461593d188ab4f726a3c()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_886822dba6bf45de980163f3c359cc2a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_886822dba6bf45de980163f3c359cc2a()
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

      private sealed class MTHD_d63933a76be547c8bd252ec985f5b9ce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d63933a76be547c8bd252ec985f5b9ce()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_e4bbb4f5c25d474e8a1fef8f9bc42336 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e4bbb4f5c25d474e8a1fef8f9bc42336()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_d63b9a74dde041ac9254bf5776c390e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d63b9a74dde041ac9254bf5776c390e7()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_1ae2d2ab75b54a2bb181b93e315b94b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ae2d2ab75b54a2bb181b93e315b94b7()
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

      private sealed class MTHD_aa354d40910c47158b8cced6a8bf709a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa354d40910c47158b8cced6a8bf709a()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_027ddfb6b9e843ee8b67e1558f0abfb2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_027ddfb6b9e843ee8b67e1558f0abfb2()
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

      private sealed class MTHD_9730ce5779ff4f60b73d915da0f9e126 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9730ce5779ff4f60b73d915da0f9e126()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_caf08d52deb747dba184cb14e403b14d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_caf08d52deb747dba184cb14e403b14d()
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

      private sealed class MTHD_fbe1ee3427334600bebb8fd9e93d83c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fbe1ee3427334600bebb8fd9e93d83c0()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_5914b4e2f90e4bf2b0d7bc6bb31dae58 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5914b4e2f90e4bf2b0d7bc6bb31dae58()
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

      private sealed class MTHD_67b33740359b46ff9fbc9a86c61d448c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67b33740359b46ff9fbc9a86c61d448c()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_1f7989c019c949bb9e551d2960fd05cc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f7989c019c949bb9e551d2960fd05cc()
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

      private sealed class MTHD_8581b4d6248a49d4b0992155a52b70bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8581b4d6248a49d4b0992155a52b70bf()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_2b8314b8380f4e0cb49a4af6d48a17bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b8314b8380f4e0cb49a4af6d48a17bb()
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

      private sealed class MTHD_d8ebe63faf9f4e5685df506e02fde63b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8ebe63faf9f4e5685df506e02fde63b()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_f7eba09dd6e54000b022f437b4c3a7fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7eba09dd6e54000b022f437b4c3a7fe()
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

      private sealed class MTHD_2377302fd2a84d9eb2088cf2e9aacd8e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2377302fd2a84d9eb2088cf2e9aacd8e()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_69270825173a460c99ac0635c3f35542 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69270825173a460c99ac0635c3f35542()
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

      private sealed class MTHD_68c5067a991543348ec8a12bbcfbc812 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_68c5067a991543348ec8a12bbcfbc812()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_6424cfb051d7477ab5258752e513270f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6424cfb051d7477ab5258752e513270f()
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

      private sealed class MTHD_6bb4557ffc5a466db060caf6841e2903 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6bb4557ffc5a466db060caf6841e2903()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_41e4ae8b0501481fbed922e89395a86c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41e4ae8b0501481fbed922e89395a86c()
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

      private sealed class MTHD_06902cb8654342ae8a9ed240d7eeb80d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_06902cb8654342ae8a9ed240d7eeb80d()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_2f8fece9eda84897bd1342bedfa98356 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2f8fece9eda84897bd1342bedfa98356()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_773b4cb0596b4b78b779808ad7d226a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_773b4cb0596b4b78b779808ad7d226a5()
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

      private sealed class MTHD_ade96fb5e67a4a2cab97c8cdc9604350 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ade96fb5e67a4a2cab97c8cdc9604350()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_1600af143b954abbae5deedd02aed561 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1600af143b954abbae5deedd02aed561()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_7a5033d7ad5c4c518bd78f40e6968c3e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a5033d7ad5c4c518bd78f40e6968c3e()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_282b31637df743c89c37aa736accb85b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_282b31637df743c89c37aa736accb85b()
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

      private sealed class MTHD_1ee841399ddd4d438d94f45ff0655690 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ee841399ddd4d438d94f45ff0655690()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_ae8e1e94f98e44749b4736c90d2a5748 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae8e1e94f98e44749b4736c90d2a5748()
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

      private sealed class MTHD_efc5e7803fb94729aea914a38b10ebf9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_efc5e7803fb94729aea914a38b10ebf9()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_c320a91d086a4df39aa060d1d1100648 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c320a91d086a4df39aa060d1d1100648()
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

      private sealed class MTHD_ae157a87c53c496caa57d3d9e9c78282 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae157a87c53c496caa57d3d9e9c78282()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_bd005db89fa845f8af6b69d75e5b88c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd005db89fa845f8af6b69d75e5b88c3()
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

      private sealed class MTHD_dab11a02e4de4ed2bb9cf9cac27b9e57 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dab11a02e4de4ed2bb9cf9cac27b9e57()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_c7c5c12af43d49cfba35815afd691128 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c7c5c12af43d49cfba35815afd691128()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_176734417f254d899e1620867b27b1ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_176734417f254d899e1620867b27b1ed()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_d85eecfa0fdb4cf4bf816e1073a549ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d85eecfa0fdb4cf4bf816e1073a549ab()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_7cd170e759804ebeae7f6e6bdf558dda : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7cd170e759804ebeae7f6e6bdf558dda()
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

      private sealed class MTHD_a1fd62cd409049fd87dd8b3352150eb3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1fd62cd409049fd87dd8b3352150eb3()
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

      private sealed class MTHD_f0cd0cc23d604c5584359f42d39a16f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f0cd0cc23d604c5584359f42d39a16f1()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_627e3d8fd8254ebf972b0a900dc95c93 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_627e3d8fd8254ebf972b0a900dc95c93()
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

      private sealed class MTHD_b7d34d14adb646d5a8f01989c5266f5a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b7d34d14adb646d5a8f01989c5266f5a()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_25709990627d4f3380aeeebf53294bf8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_25709990627d4f3380aeeebf53294bf8()
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

      private sealed class MTHD_15ca8576e5b748ca955cbe342c3e61a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15ca8576e5b748ca955cbe342c3e61a2()
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

      private sealed class MTHD_f03d1df304684ac08706a65ffb034b56 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f03d1df304684ac08706a65ffb034b56()
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

      private sealed class MTHD_8abebc45f7fd41eca7686f9dec84c597 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8abebc45f7fd41eca7686f9dec84c597()
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

      private sealed class MTHD_596773e279ea4d19a8b8eded3098e50a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_596773e279ea4d19a8b8eded3098e50a()
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

      private sealed class MTHD_917fe449fef94f0aa22d06f27c5cef7c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_917fe449fef94f0aa22d06f27c5cef7c()
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

      private sealed class MTHD_fb689de31ec2436eb83604b53d039519 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb689de31ec2436eb83604b53d039519()
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

      private sealed class MTHD_54eb59a7085b40a081480d2d1bc9d112 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_54eb59a7085b40a081480d2d1bc9d112()
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

      private sealed class MTHD_b5795efff10947db858fcdafca63c399 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b5795efff10947db858fcdafca63c399()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_d50b55e699fd43c9b2fb4128207b287e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d50b55e699fd43c9b2fb4128207b287e()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_b1583b698f0b4fdcb31a01b0ee814554 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b1583b698f0b4fdcb31a01b0ee814554()
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

      private sealed class MTHD_4894c17b4f1548429d50970389e9b9d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4894c17b4f1548429d50970389e9b9d8()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_579acebd30804abfb360865b3e51d531 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_579acebd30804abfb360865b3e51d531()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_4ee3cf5aeaac4f88a707219e4b5a910a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ee3cf5aeaac4f88a707219e4b5a910a()
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

      private sealed class MTHD_04ea9b19d04644b4a234a62d5dffd80d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_04ea9b19d04644b4a234a62d5dffd80d()
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

      private sealed class MTHD_b8733a2db44142ac83ad2c329fe86bd7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b8733a2db44142ac83ad2c329fe86bd7()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_2dd43c77df7e43d6b93e548b20667471 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2dd43c77df7e43d6b93e548b20667471()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_053eb23dc1e94a2bbd21c2f6e5cc7dd3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_053eb23dc1e94a2bbd21c2f6e5cc7dd3()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_fca0b6a5588744cc80b8bd488e62b1b5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fca0b6a5588744cc80b8bd488e62b1b5()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9da6c61748244442ab1676148a964b24 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9da6c61748244442ab1676148a964b24()
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

      private sealed class MTHD_3257010e34c14755ae08b01725e118eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3257010e34c14755ae08b01725e118eb()
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

      private sealed class MTHD_787806d74331447fb4b9f7cd91e6fd7b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_787806d74331447fb4b9f7cd91e6fd7b()
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

      private sealed class MTHD_acc59286e75149b7a90678cb2c3727d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_acc59286e75149b7a90678cb2c3727d3()
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

      private sealed class MTHD_71dd5a37ce5645e38e5b56ce4b9edda3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_71dd5a37ce5645e38e5b56ce4b9edda3()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_e041e7fb4ffc42c1945c531431f0a226 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e041e7fb4ffc42c1945c531431f0a226()
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

      private sealed class MTHD_94ed920027224f4fbd718c8b028c02e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_94ed920027224f4fbd718c8b028c02e5()
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

      private sealed class MTHD_da0ecbf3b8274678b682be10fc8efaa0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_da0ecbf3b8274678b682be10fc8efaa0()
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

      private sealed class MTHD_d8a386151c0048628da4262456b5433e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8a386151c0048628da4262456b5433e()
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

      private sealed class MTHD_d324868ccbf64cd8adbae7e6f14f719f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d324868ccbf64cd8adbae7e6f14f719f()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_231b9fc927b1492ebc20a283545f35a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_231b9fc927b1492ebc20a283545f35a5()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_23b5f6741c7e4f85970aa79e838a3474 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_23b5f6741c7e4f85970aa79e838a3474()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_7afeb51adba546d2a2dd6e1913f29de6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7afeb51adba546d2a2dd6e1913f29de6()
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

      private sealed class MTHD_26678fce93184fda84087f5b88d7ecc0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_26678fce93184fda84087f5b88d7ecc0()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c438f8ba27c44f7c8365eee5b4e43a83 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c438f8ba27c44f7c8365eee5b4e43a83()
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

      private sealed class MTHD_dc7ccf89e5394ecba67b8944164a36eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc7ccf89e5394ecba67b8944164a36eb()
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

      private sealed class MTHD_862f1f94ac104f7eb03a0d5127dd1982 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_862f1f94ac104f7eb03a0d5127dd1982()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_67e8580f70c54008a12b357b14a31813 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67e8580f70c54008a12b357b14a31813()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_88369869937c477c87b65dfd27efbf7d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_88369869937c477c87b65dfd27efbf7d()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_2ac433cb9b2848a4bf6b397c6fcdfc11 : HardwiredMemberDescriptor
      {
        internal PROP_2ac433cb9b2848a4bf6b397c6fcdfc11()
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

      private sealed class PROP_8b5ef18a321149f8b164bf3479a119ae : HardwiredMemberDescriptor
      {
        internal PROP_8b5ef18a321149f8b164bf3479a119ae()
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

      private sealed class PROP_80397ef76d7a400aa716f1754b921f66 : HardwiredMemberDescriptor
      {
        internal PROP_80397ef76d7a400aa716f1754b921f66()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_30ede4a9ff824fd4837faed35934aabf : HardwiredMemberDescriptor
      {
        internal PROP_30ede4a9ff824fd4837faed35934aabf()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_16781ddd836940938bf2a0719cc362a6 : HardwiredMemberDescriptor
      {
        internal PROP_16781ddd836940938bf2a0719cc362a6()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_ab3c7074ea8a450bb94dbd352978a8f0 : HardwiredMemberDescriptor
      {
        internal PROP_ab3c7074ea8a450bb94dbd352978a8f0()
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

      private sealed class PROP_0a54e829f98541d79679e624dcfedc69 : HardwiredMemberDescriptor
      {
        internal PROP_0a54e829f98541d79679e624dcfedc69()
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

      private sealed class PROP_e47b3c208e854981aae61b79f6569a1e : HardwiredMemberDescriptor
      {
        internal PROP_e47b3c208e854981aae61b79f6569a1e()
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

      private sealed class PROP_6f3126343a664d96823fcaf8340fcfcb : HardwiredMemberDescriptor
      {
        internal PROP_6f3126343a664d96823fcaf8340fcfcb()
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

      private sealed class PROP_f49072e77dd24b2190100019aa9e2e2d : HardwiredMemberDescriptor
      {
        internal PROP_f49072e77dd24b2190100019aa9e2e2d()
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

      private sealed class PROP_c7f2cda53a454640bc2cf4970015551d : HardwiredMemberDescriptor
      {
        internal PROP_c7f2cda53a454640bc2cf4970015551d()
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

      private sealed class PROP_358a7599a3c842a48c9457ecbc02d6f5 : HardwiredMemberDescriptor
      {
        internal PROP_358a7599a3c842a48c9457ecbc02d6f5()
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

      private sealed class PROP_a6c71d5d65b24d4397478f6d3650e0ad : HardwiredMemberDescriptor
      {
        internal PROP_a6c71d5d65b24d4397478f6d3650e0ad()
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

      private sealed class PROP_efe167fae0ee4b549908c46859120e5d : HardwiredMemberDescriptor
      {
        internal PROP_efe167fae0ee4b549908c46859120e5d()
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

      private sealed class PROP_39832fd6a7144220b943818b5e5a4a23 : HardwiredMemberDescriptor
      {
        internal PROP_39832fd6a7144220b943818b5e5a4a23()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_16632a7a34d845adbea68471d3feeb1c : HardwiredMemberDescriptor
      {
        internal PROP_16632a7a34d845adbea68471d3feeb1c()
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

      private sealed class PROP_0a375c578f6e4afc8c5795d13ffe18d9 : HardwiredMemberDescriptor
      {
        internal PROP_0a375c578f6e4afc8c5795d13ffe18d9()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_c3df5f77ae894072828fd34181e4e5a5 : HardwiredMemberDescriptor
      {
        internal PROP_c3df5f77ae894072828fd34181e4e5a5()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_e56f57c1fa1a4c94877cbe7c897b09cf : HardwiredMemberDescriptor
      {
        internal PROP_e56f57c1fa1a4c94877cbe7c897b09cf()
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

      private sealed class PROP_b517b66fbb9c46f0a7c0f8ab744458ef : HardwiredMemberDescriptor
      {
        internal PROP_b517b66fbb9c46f0a7c0f8ab744458ef()
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

      private sealed class PROP_745f5a5edf5847ffa4423e336ecb8fbe : HardwiredMemberDescriptor
      {
        internal PROP_745f5a5edf5847ffa4423e336ecb8fbe()
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

      private sealed class PROP_cac73a0c161f411e8e7969a34865e023 : HardwiredMemberDescriptor
      {
        internal PROP_cac73a0c161f411e8e7969a34865e023()
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

      private sealed class PROP_289b6e96dbb242c992e463b2f8970525 : HardwiredMemberDescriptor
      {
        internal PROP_289b6e96dbb242c992e463b2f8970525()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_29b563166dfc46f9bba576e49c1933a2 : HardwiredMemberDescriptor
      {
        internal PROP_29b563166dfc46f9bba576e49c1933a2()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_d86f4fff46d54ddf81d60d4797167221 : HardwiredMemberDescriptor
      {
        internal PROP_d86f4fff46d54ddf81d60d4797167221()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_e2ad39c8a49341a386b23d1cba8a7925 : HardwiredMemberDescriptor
      {
        internal PROP_e2ad39c8a49341a386b23d1cba8a7925()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_2eab0304d2ca488ab31e354b49584984 : HardwiredMemberDescriptor
      {
        internal PROP_2eab0304d2ca488ab31e354b49584984()
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

      private sealed class PROP_15c392c880d240c5a45ae44a88a9b8db : HardwiredMemberDescriptor
      {
        internal PROP_15c392c880d240c5a45ae44a88a9b8db()
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

      private sealed class PROP_f327d2a1e8384d53b3c1dd35ffe2693b : HardwiredMemberDescriptor
      {
        internal PROP_f327d2a1e8384d53b3c1dd35ffe2693b()
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

      private sealed class PROP_ad0a7f6eb258421eac9ba76534d08c40 : HardwiredMemberDescriptor
      {
        internal PROP_ad0a7f6eb258421eac9ba76534d08c40()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_d074de2289db4f8480dbcc66787913f0 : HardwiredMemberDescriptor
      {
        internal PROP_d074de2289db4f8480dbcc66787913f0()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_019e7929df9c49c7ab044a30f831bded : HardwiredMemberDescriptor
      {
        internal PROP_019e7929df9c49c7ab044a30f831bded()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_49f1e44fe0c74cdc9f30dfe2e272324d : HardwiredUserDataDescriptor
    {
      internal TYPE_49f1e44fe0c74cdc9f30dfe2e272324d()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_49f1e44fe0c74cdc9f30dfe2e272324d.MTHD_6b1805b18fe64ac8a6734a8b7509bda6()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_49f1e44fe0c74cdc9f30dfe2e272324d.MTHD_7e1d656f479f45c6acfda8e60dd173d0()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_49f1e44fe0c74cdc9f30dfe2e272324d.MTHD_ac52c00b19d442c4b2b31f9f1ca895fc()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_49f1e44fe0c74cdc9f30dfe2e272324d.MTHD_8a54157436664818b51c6d98876e666e()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_49f1e44fe0c74cdc9f30dfe2e272324d.MTHD_dc4944ce64b846d2bfa49a0d3b824812()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_49f1e44fe0c74cdc9f30dfe2e272324d.MTHD_ffb1759c5e8e432a8decd5beae77716c()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_49f1e44fe0c74cdc9f30dfe2e272324d.MTHD_9c1962b118fd44d0adacaa14622be45d()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_49f1e44fe0c74cdc9f30dfe2e272324d.MTHD_65a9ebc2c90e494e9c2f8de501c6e794()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_49f1e44fe0c74cdc9f30dfe2e272324d.MTHD_b136994d58004cc18ebcca28a5ec4a63()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_49f1e44fe0c74cdc9f30dfe2e272324d.MTHD_70a733f56f5844ff91c2d870d55fae07()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_49f1e44fe0c74cdc9f30dfe2e272324d.MTHD_8311d221f7c640ce96d88b8619eb1df5()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_49f1e44fe0c74cdc9f30dfe2e272324d.MTHD_a78835655f9a46be8128dcc469e2e673()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_49f1e44fe0c74cdc9f30dfe2e272324d.PROP_998e0906711148fd9f2c1e08e0c5765a());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_49f1e44fe0c74cdc9f30dfe2e272324d.PROP_7ebaff7c1b7b4cd582f17d9751f4d242());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_49f1e44fe0c74cdc9f30dfe2e272324d.PROP_f287a6efbcd34b6a91b996fda369857a());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_49f1e44fe0c74cdc9f30dfe2e272324d.PROP_81e6ab4e873c40ce8bc78ad04849695e());
      }

      private sealed class MTHD_6b1805b18fe64ac8a6734a8b7509bda6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b1805b18fe64ac8a6734a8b7509bda6()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_7e1d656f479f45c6acfda8e60dd173d0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7e1d656f479f45c6acfda8e60dd173d0()
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

      private sealed class MTHD_ac52c00b19d442c4b2b31f9f1ca895fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac52c00b19d442c4b2b31f9f1ca895fc()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_8a54157436664818b51c6d98876e666e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a54157436664818b51c6d98876e666e()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_dc4944ce64b846d2bfa49a0d3b824812 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc4944ce64b846d2bfa49a0d3b824812()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_ffb1759c5e8e432a8decd5beae77716c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ffb1759c5e8e432a8decd5beae77716c()
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

      private sealed class MTHD_9c1962b118fd44d0adacaa14622be45d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c1962b118fd44d0adacaa14622be45d()
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

      private sealed class MTHD_65a9ebc2c90e494e9c2f8de501c6e794 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65a9ebc2c90e494e9c2f8de501c6e794()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_b136994d58004cc18ebcca28a5ec4a63 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b136994d58004cc18ebcca28a5ec4a63()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_70a733f56f5844ff91c2d870d55fae07 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70a733f56f5844ff91c2d870d55fae07()
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

      private sealed class MTHD_8311d221f7c640ce96d88b8619eb1df5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8311d221f7c640ce96d88b8619eb1df5()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_a78835655f9a46be8128dcc469e2e673 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a78835655f9a46be8128dcc469e2e673()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_998e0906711148fd9f2c1e08e0c5765a : HardwiredMemberDescriptor
      {
        internal PROP_998e0906711148fd9f2c1e08e0c5765a()
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

      private sealed class PROP_7ebaff7c1b7b4cd582f17d9751f4d242 : HardwiredMemberDescriptor
      {
        internal PROP_7ebaff7c1b7b4cd582f17d9751f4d242()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_f287a6efbcd34b6a91b996fda369857a : HardwiredMemberDescriptor
      {
        internal PROP_f287a6efbcd34b6a91b996fda369857a()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_81e6ab4e873c40ce8bc78ad04849695e : HardwiredMemberDescriptor
      {
        internal PROP_81e6ab4e873c40ce8bc78ad04849695e()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_edb4c74691eb4698858b25afa878c510 : HardwiredUserDataDescriptor
    {
      internal TYPE_edb4c74691eb4698858b25afa878c510()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_870694955262402d8aca8d6b0bf59147()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_4853a72fabc8465cacb1553cce903279()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_12a2883e02fc48b1bfe171c09e1496a7()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_2345fac5f75b482c97fa0837e2b87eb7()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_141f335aa52a4cfebac32eabd8b983b3()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_892faf2472ee478faaf0bd119f6634cb()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_744b7d1efd434d61a21609ec3af68c6b()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_b1e2d1d85ac54dca91a30bbfc5b12cf9()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_96a689ec2ba946efa32bc39ca11014d0()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_6efd2d8c8ee44d4fa1d0ff66be602128()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_3458a723bc9c494f90c1307993f9d32c()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_38506cc01a8348228bae754a16955a2b()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_1c03c47497ae4bffb79073f1d7554073()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_9673f20d7ebc44c3ae66e90d166c4e19()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_6739df85c5704acb884c2e415b7f1555()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_c4ac3a82bfd143f2a6520aba85f9894f()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_e626941524e64ce9975176b04452ca14()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_aa7ccd1ef99e44aa9dfc939ebff85ce8()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_d0d284751eeb42258e6fe9b0b0fa5628()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_e4890130dedf4dc69fd632131222fdb1()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_3db286455d984d6eab1f74e9b3505e6e()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_620835e7acd54196b0126aa6d4c27909()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_91ec1174ad374268b2de1e00ea758b00()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_022da92709db4b3dad6e1c3153084733()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_11bb97a957eb4e4ebeb42af5b9e8b820()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_5570b8c7d917422c902bb773d3755e8a()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_67b25ef0685a4c5b884eb85ed5a2ba79()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_cb7f4e286b2045e5b00f27265d6d8810()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_00c28c036c56459c935192211f3509a4()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_0f59d6602018410892d5bd4c99f66554()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_72c7eae2d8d343598311f6972dda919a()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_6d3f5d5b3fab41789090b469ed8c9b7c()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_8262b42dfa3946bbb5e6e817e288e9f1()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_8b07f26fdd1244c1b9fa6bf5d0afdfaa()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_f9b3a2a7b97541aaad8a937d71f69a45()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_7e2e10b5c8064b95b9c262cdec080810()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_5c5d1b2f9bd0413db29a6a52465a54d8()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_c198b67387794fe68502e51ce07ad5d8()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_b55a42ac0439433b98db424c135a2ed7()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_924cf6067bbd46018a35b8e4ee3cfc64()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_54f5f1e9c4dc4a868bd34be18ece3386()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_c0e04eada4e243e89ba79d52dd69c5c8()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_675752c22fa344d6ba80cd31a8633abb()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_a1dac160630b4eee92d6bc867b3a6b0e()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_c34f07c08b13403fb59a849dee37ea6a()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_816b532efeb448ae9186dd042ad67d25()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_e08ffd8226af4bf3a68a83a31bead2a2()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_0715d96c49df4333b452d7a80d8fc495()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_6d6128ba0d4e4dd29dc958e341776222()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_0c1be1266801428ba2bbba1f30f6e186()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_902e632efdb74c6a9882abd3eaeb0cc8()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_9816841df16949c884eba6d3aacc290e()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_287ccc38d3ec45c498f90ad1c3057616()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_54583ffd54714ca0ad83288f3fb28f2c()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_3c8b9afaa3684dbfabee844072cc90e2()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_256d6d81db2341ac9ca768197a1c26ea()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_5a4ebe04fd5c4aca80aa19761f0e97e5()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_773ac6ad75244af8880d7339e5486126()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_b13992cccd12455b88427577de8ce0bb()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_c537b6bcdda748aa9fa3afdcec9a13c0()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_e1f3b6a1848b45e382e59f0d3fd94b69()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_ed5fedd808d846889ec158b8ae6ba14a()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_7ca71067931c44c6abd8fd117f00634a()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_0dbaa50e5c994da996870c30344f9acd(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_675ba16a43864ed9886cd53afc8c095d()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_5aa8b292527d4788a98c30d794c6fefb(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_cd48316957c94b1188208b8a4bf8a5b5()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_6cfaaaccb8694757a59f9d4ffd7b3f9e()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_98e398a458b349baa02676fc4cae5638()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_05f1a2f8d6744dd2aca875be362c0882(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_49a311228fab459cab5dd39f841c6069()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_0a3f12db0c474738be70f226f18853de()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_90599afc8869445d9d7464f3a53a80ce()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_0a645a46d68c4451ad47ef5b3a0accb7()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_b2c7632ba37f43438488c5c4d96f542c()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_cabab31da9344744bf139df461411d56()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_3ddffc3f645b465aa3cddc0deb2dc4cd()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_0021a22869504bf9b71d00e60eeb249d()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_06726ee9c698431ea54cf0b25213a654()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_f8817117a42a44b1a3b2a0a07ca4a925(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_dcf869b9b42344039c205d0f52ba1945()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_b746a4bdcaeb49498b08f90e5068c729(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_cf816af52963498196455e4ce7d890db()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_5c6eff59ef3b4d48afb03d0dd5c2bbb8()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_d2b18e2903864aafa547911d80c77a9f()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_1074b976792e498e834ca5bb234d0f6c()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_5993c90699ab43a6b7b1fb98db2a1c80()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_ddf285b7da1e4b21aec3877f3fa89a41()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.MTHD_e4b129bdce4b446db30633784d3d8794()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_021e8c1155b24418b26f4b4de0c812c2());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_2799044b7cfc4a58b6b8c0622f474a01());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_64484a2f7919491990982821854ce335());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_976e22c31aa14ddfaf01f49b9c66a26f());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_b6dc8c773c2f4ec7b69be766d0a02589());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_8ac3daa3656743298d00c20cdf4a1a1c());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_296be84b17294093affeaedd3ffafabb());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_f77a24da4f6d43f896bd117de7f9880f());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_30e4ac38fc3f42739cc4ee0ba382bb1d());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_897b8168111243f7bd335e636b4f6331());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_3e51b432d85b4c51a74d11c34be0e3f6());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_59e07aa9e695492593ab357ceb598012());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_3435eb7f46094592acaf910b49fc6795());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_ea669cf57c1242cdae9802ab279fe5e7());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_99d5b376acec4d81b94963b19ebab084());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_413e0f9f39184ae8a8afc36bf5ac7a48());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_f8e670a2ea7f4f9d91b3a8fe2dae00ad());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_3f50080494b14445a1026bb830b6ff0f());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_470a2c8274e344ca93a1ccfca94bff55());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_1c8a4c5736d94c87913f363d6c94394e());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_7efec883ab834b3e96dba49930512d7a());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_b18b92e34fcd4520be74430d16be3f76());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_df7416a35c2a4d04b84dede94c7482aa());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_7969c8ff2dd146b0ad8ab878b45d5a13());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_c8df64016fcb453d9b74e0a1def75e0c());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_0af6b3cb949a44bb9f9f88ebeb64ab13());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_e597e6f11bb041b8b85d4a2a9575a96a());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_3cafb592e1b14933b1ed1cc4665372e7());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_c8a1bc7d194a403badfd7c6d6219b497());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_6cb7f9f841f74e71b3421f521284d083());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_61ae55c8e5b044798ca9514353920a63());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_dd67f691e196477781ea3c3d04ef218c());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_edb4c74691eb4698858b25afa878c510.PROP_731d004776c34271a62f256c456f6602());
      }

      private sealed class MTHD_870694955262402d8aca8d6b0bf59147 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_870694955262402d8aca8d6b0bf59147()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_4853a72fabc8465cacb1553cce903279 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4853a72fabc8465cacb1553cce903279()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_12a2883e02fc48b1bfe171c09e1496a7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_12a2883e02fc48b1bfe171c09e1496a7()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_2345fac5f75b482c97fa0837e2b87eb7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2345fac5f75b482c97fa0837e2b87eb7()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_141f335aa52a4cfebac32eabd8b983b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_141f335aa52a4cfebac32eabd8b983b3()
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

      private sealed class MTHD_892faf2472ee478faaf0bd119f6634cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_892faf2472ee478faaf0bd119f6634cb()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_744b7d1efd434d61a21609ec3af68c6b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_744b7d1efd434d61a21609ec3af68c6b()
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

      private sealed class MTHD_b1e2d1d85ac54dca91a30bbfc5b12cf9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b1e2d1d85ac54dca91a30bbfc5b12cf9()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_96a689ec2ba946efa32bc39ca11014d0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_96a689ec2ba946efa32bc39ca11014d0()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_6efd2d8c8ee44d4fa1d0ff66be602128 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6efd2d8c8ee44d4fa1d0ff66be602128()
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

      private sealed class MTHD_3458a723bc9c494f90c1307993f9d32c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3458a723bc9c494f90c1307993f9d32c()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_38506cc01a8348228bae754a16955a2b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_38506cc01a8348228bae754a16955a2b()
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

      private sealed class MTHD_1c03c47497ae4bffb79073f1d7554073 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c03c47497ae4bffb79073f1d7554073()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_9673f20d7ebc44c3ae66e90d166c4e19 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9673f20d7ebc44c3ae66e90d166c4e19()
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

      private sealed class MTHD_6739df85c5704acb884c2e415b7f1555 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6739df85c5704acb884c2e415b7f1555()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_c4ac3a82bfd143f2a6520aba85f9894f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c4ac3a82bfd143f2a6520aba85f9894f()
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

      private sealed class MTHD_e626941524e64ce9975176b04452ca14 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e626941524e64ce9975176b04452ca14()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_aa7ccd1ef99e44aa9dfc939ebff85ce8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa7ccd1ef99e44aa9dfc939ebff85ce8()
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

      private sealed class MTHD_d0d284751eeb42258e6fe9b0b0fa5628 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0d284751eeb42258e6fe9b0b0fa5628()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_e4890130dedf4dc69fd632131222fdb1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e4890130dedf4dc69fd632131222fdb1()
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

      private sealed class MTHD_3db286455d984d6eab1f74e9b3505e6e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3db286455d984d6eab1f74e9b3505e6e()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_620835e7acd54196b0126aa6d4c27909 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_620835e7acd54196b0126aa6d4c27909()
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

      private sealed class MTHD_91ec1174ad374268b2de1e00ea758b00 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_91ec1174ad374268b2de1e00ea758b00()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_022da92709db4b3dad6e1c3153084733 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_022da92709db4b3dad6e1c3153084733()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_11bb97a957eb4e4ebeb42af5b9e8b820 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_11bb97a957eb4e4ebeb42af5b9e8b820()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_5570b8c7d917422c902bb773d3755e8a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5570b8c7d917422c902bb773d3755e8a()
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

      private sealed class MTHD_67b25ef0685a4c5b884eb85ed5a2ba79 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67b25ef0685a4c5b884eb85ed5a2ba79()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_cb7f4e286b2045e5b00f27265d6d8810 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cb7f4e286b2045e5b00f27265d6d8810()
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

      private sealed class MTHD_00c28c036c56459c935192211f3509a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_00c28c036c56459c935192211f3509a4()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_0f59d6602018410892d5bd4c99f66554 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f59d6602018410892d5bd4c99f66554()
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

      private sealed class MTHD_72c7eae2d8d343598311f6972dda919a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_72c7eae2d8d343598311f6972dda919a()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_6d3f5d5b3fab41789090b469ed8c9b7c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d3f5d5b3fab41789090b469ed8c9b7c()
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

      private sealed class MTHD_8262b42dfa3946bbb5e6e817e288e9f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8262b42dfa3946bbb5e6e817e288e9f1()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_8b07f26fdd1244c1b9fa6bf5d0afdfaa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b07f26fdd1244c1b9fa6bf5d0afdfaa()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_f9b3a2a7b97541aaad8a937d71f69a45 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f9b3a2a7b97541aaad8a937d71f69a45()
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

      private sealed class MTHD_7e2e10b5c8064b95b9c262cdec080810 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7e2e10b5c8064b95b9c262cdec080810()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_5c5d1b2f9bd0413db29a6a52465a54d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c5d1b2f9bd0413db29a6a52465a54d8()
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

      private sealed class MTHD_c198b67387794fe68502e51ce07ad5d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c198b67387794fe68502e51ce07ad5d8()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_b55a42ac0439433b98db424c135a2ed7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b55a42ac0439433b98db424c135a2ed7()
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

      private sealed class MTHD_924cf6067bbd46018a35b8e4ee3cfc64 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_924cf6067bbd46018a35b8e4ee3cfc64()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_54f5f1e9c4dc4a868bd34be18ece3386 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_54f5f1e9c4dc4a868bd34be18ece3386()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_c0e04eada4e243e89ba79d52dd69c5c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c0e04eada4e243e89ba79d52dd69c5c8()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_675752c22fa344d6ba80cd31a8633abb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_675752c22fa344d6ba80cd31a8633abb()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_a1dac160630b4eee92d6bc867b3a6b0e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1dac160630b4eee92d6bc867b3a6b0e()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_c34f07c08b13403fb59a849dee37ea6a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c34f07c08b13403fb59a849dee37ea6a()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_816b532efeb448ae9186dd042ad67d25 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_816b532efeb448ae9186dd042ad67d25()
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

      private sealed class MTHD_e08ffd8226af4bf3a68a83a31bead2a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e08ffd8226af4bf3a68a83a31bead2a2()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_0715d96c49df4333b452d7a80d8fc495 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0715d96c49df4333b452d7a80d8fc495()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_6d6128ba0d4e4dd29dc958e341776222 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d6128ba0d4e4dd29dc958e341776222()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_0c1be1266801428ba2bbba1f30f6e186 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c1be1266801428ba2bbba1f30f6e186()
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

      private sealed class MTHD_902e632efdb74c6a9882abd3eaeb0cc8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_902e632efdb74c6a9882abd3eaeb0cc8()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_9816841df16949c884eba6d3aacc290e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9816841df16949c884eba6d3aacc290e()
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

      private sealed class MTHD_287ccc38d3ec45c498f90ad1c3057616 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_287ccc38d3ec45c498f90ad1c3057616()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_54583ffd54714ca0ad83288f3fb28f2c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_54583ffd54714ca0ad83288f3fb28f2c()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_3c8b9afaa3684dbfabee844072cc90e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3c8b9afaa3684dbfabee844072cc90e2()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_256d6d81db2341ac9ca768197a1c26ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_256d6d81db2341ac9ca768197a1c26ea()
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

      private sealed class MTHD_5a4ebe04fd5c4aca80aa19761f0e97e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5a4ebe04fd5c4aca80aa19761f0e97e5()
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

      private sealed class MTHD_773ac6ad75244af8880d7339e5486126 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_773ac6ad75244af8880d7339e5486126()
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

      private sealed class MTHD_b13992cccd12455b88427577de8ce0bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b13992cccd12455b88427577de8ce0bb()
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

      private sealed class MTHD_c537b6bcdda748aa9fa3afdcec9a13c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c537b6bcdda748aa9fa3afdcec9a13c0()
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

      private sealed class MTHD_e1f3b6a1848b45e382e59f0d3fd94b69 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e1f3b6a1848b45e382e59f0d3fd94b69()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_ed5fedd808d846889ec158b8ae6ba14a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed5fedd808d846889ec158b8ae6ba14a()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_7ca71067931c44c6abd8fd117f00634a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ca71067931c44c6abd8fd117f00634a()
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

      private sealed class MTHD_0dbaa50e5c994da996870c30344f9acd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0dbaa50e5c994da996870c30344f9acd()
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

      private sealed class MTHD_675ba16a43864ed9886cd53afc8c095d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_675ba16a43864ed9886cd53afc8c095d()
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

      private sealed class MTHD_5aa8b292527d4788a98c30d794c6fefb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5aa8b292527d4788a98c30d794c6fefb()
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

      private sealed class MTHD_cd48316957c94b1188208b8a4bf8a5b5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd48316957c94b1188208b8a4bf8a5b5()
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

      private sealed class MTHD_6cfaaaccb8694757a59f9d4ffd7b3f9e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6cfaaaccb8694757a59f9d4ffd7b3f9e()
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

      private sealed class MTHD_98e398a458b349baa02676fc4cae5638 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_98e398a458b349baa02676fc4cae5638()
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

      private sealed class MTHD_05f1a2f8d6744dd2aca875be362c0882 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_05f1a2f8d6744dd2aca875be362c0882()
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

      private sealed class MTHD_49a311228fab459cab5dd39f841c6069 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49a311228fab459cab5dd39f841c6069()
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

      private sealed class MTHD_0a3f12db0c474738be70f226f18853de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0a3f12db0c474738be70f226f18853de()
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

      private sealed class MTHD_90599afc8869445d9d7464f3a53a80ce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90599afc8869445d9d7464f3a53a80ce()
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

      private sealed class MTHD_0a645a46d68c4451ad47ef5b3a0accb7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0a645a46d68c4451ad47ef5b3a0accb7()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_b2c7632ba37f43438488c5c4d96f542c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b2c7632ba37f43438488c5c4d96f542c()
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

      private sealed class MTHD_cabab31da9344744bf139df461411d56 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cabab31da9344744bf139df461411d56()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_3ddffc3f645b465aa3cddc0deb2dc4cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3ddffc3f645b465aa3cddc0deb2dc4cd()
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

      private sealed class MTHD_0021a22869504bf9b71d00e60eeb249d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0021a22869504bf9b71d00e60eeb249d()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_06726ee9c698431ea54cf0b25213a654 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_06726ee9c698431ea54cf0b25213a654()
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

      private sealed class MTHD_f8817117a42a44b1a3b2a0a07ca4a925 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f8817117a42a44b1a3b2a0a07ca4a925()
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

      private sealed class MTHD_dcf869b9b42344039c205d0f52ba1945 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dcf869b9b42344039c205d0f52ba1945()
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

      private sealed class MTHD_b746a4bdcaeb49498b08f90e5068c729 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b746a4bdcaeb49498b08f90e5068c729()
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

      private sealed class MTHD_cf816af52963498196455e4ce7d890db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf816af52963498196455e4ce7d890db()
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

      private sealed class MTHD_5c6eff59ef3b4d48afb03d0dd5c2bbb8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c6eff59ef3b4d48afb03d0dd5c2bbb8()
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

      private sealed class MTHD_d2b18e2903864aafa547911d80c77a9f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d2b18e2903864aafa547911d80c77a9f()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_1074b976792e498e834ca5bb234d0f6c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1074b976792e498e834ca5bb234d0f6c()
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

      private sealed class MTHD_5993c90699ab43a6b7b1fb98db2a1c80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5993c90699ab43a6b7b1fb98db2a1c80()
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

      private sealed class MTHD_ddf285b7da1e4b21aec3877f3fa89a41 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ddf285b7da1e4b21aec3877f3fa89a41()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_e4b129bdce4b446db30633784d3d8794 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e4b129bdce4b446db30633784d3d8794()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_021e8c1155b24418b26f4b4de0c812c2 : HardwiredMemberDescriptor
      {
        internal PROP_021e8c1155b24418b26f4b4de0c812c2()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_2799044b7cfc4a58b6b8c0622f474a01 : HardwiredMemberDescriptor
      {
        internal PROP_2799044b7cfc4a58b6b8c0622f474a01()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_64484a2f7919491990982821854ce335 : HardwiredMemberDescriptor
      {
        internal PROP_64484a2f7919491990982821854ce335()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_976e22c31aa14ddfaf01f49b9c66a26f : HardwiredMemberDescriptor
      {
        internal PROP_976e22c31aa14ddfaf01f49b9c66a26f()
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

      private sealed class PROP_b6dc8c773c2f4ec7b69be766d0a02589 : HardwiredMemberDescriptor
      {
        internal PROP_b6dc8c773c2f4ec7b69be766d0a02589()
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

      private sealed class PROP_8ac3daa3656743298d00c20cdf4a1a1c : HardwiredMemberDescriptor
      {
        internal PROP_8ac3daa3656743298d00c20cdf4a1a1c()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_296be84b17294093affeaedd3ffafabb : HardwiredMemberDescriptor
      {
        internal PROP_296be84b17294093affeaedd3ffafabb()
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

      private sealed class PROP_f77a24da4f6d43f896bd117de7f9880f : HardwiredMemberDescriptor
      {
        internal PROP_f77a24da4f6d43f896bd117de7f9880f()
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

      private sealed class PROP_30e4ac38fc3f42739cc4ee0ba382bb1d : HardwiredMemberDescriptor
      {
        internal PROP_30e4ac38fc3f42739cc4ee0ba382bb1d()
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

      private sealed class PROP_897b8168111243f7bd335e636b4f6331 : HardwiredMemberDescriptor
      {
        internal PROP_897b8168111243f7bd335e636b4f6331()
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

      private sealed class PROP_3e51b432d85b4c51a74d11c34be0e3f6 : HardwiredMemberDescriptor
      {
        internal PROP_3e51b432d85b4c51a74d11c34be0e3f6()
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

      private sealed class PROP_59e07aa9e695492593ab357ceb598012 : HardwiredMemberDescriptor
      {
        internal PROP_59e07aa9e695492593ab357ceb598012()
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

      private sealed class PROP_3435eb7f46094592acaf910b49fc6795 : HardwiredMemberDescriptor
      {
        internal PROP_3435eb7f46094592acaf910b49fc6795()
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

      private sealed class PROP_ea669cf57c1242cdae9802ab279fe5e7 : HardwiredMemberDescriptor
      {
        internal PROP_ea669cf57c1242cdae9802ab279fe5e7()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_99d5b376acec4d81b94963b19ebab084 : HardwiredMemberDescriptor
      {
        internal PROP_99d5b376acec4d81b94963b19ebab084()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_413e0f9f39184ae8a8afc36bf5ac7a48 : HardwiredMemberDescriptor
      {
        internal PROP_413e0f9f39184ae8a8afc36bf5ac7a48()
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

      private sealed class PROP_f8e670a2ea7f4f9d91b3a8fe2dae00ad : HardwiredMemberDescriptor
      {
        internal PROP_f8e670a2ea7f4f9d91b3a8fe2dae00ad()
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

      private sealed class PROP_3f50080494b14445a1026bb830b6ff0f : HardwiredMemberDescriptor
      {
        internal PROP_3f50080494b14445a1026bb830b6ff0f()
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

      private sealed class PROP_470a2c8274e344ca93a1ccfca94bff55 : HardwiredMemberDescriptor
      {
        internal PROP_470a2c8274e344ca93a1ccfca94bff55()
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

      private sealed class PROP_1c8a4c5736d94c87913f363d6c94394e : HardwiredMemberDescriptor
      {
        internal PROP_1c8a4c5736d94c87913f363d6c94394e()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_7efec883ab834b3e96dba49930512d7a : HardwiredMemberDescriptor
      {
        internal PROP_7efec883ab834b3e96dba49930512d7a()
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

      private sealed class PROP_b18b92e34fcd4520be74430d16be3f76 : HardwiredMemberDescriptor
      {
        internal PROP_b18b92e34fcd4520be74430d16be3f76()
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

      private sealed class PROP_df7416a35c2a4d04b84dede94c7482aa : HardwiredMemberDescriptor
      {
        internal PROP_df7416a35c2a4d04b84dede94c7482aa()
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

      private sealed class PROP_7969c8ff2dd146b0ad8ab878b45d5a13 : HardwiredMemberDescriptor
      {
        internal PROP_7969c8ff2dd146b0ad8ab878b45d5a13()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_c8df64016fcb453d9b74e0a1def75e0c : HardwiredMemberDescriptor
      {
        internal PROP_c8df64016fcb453d9b74e0a1def75e0c()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_0af6b3cb949a44bb9f9f88ebeb64ab13 : HardwiredMemberDescriptor
      {
        internal PROP_0af6b3cb949a44bb9f9f88ebeb64ab13()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_e597e6f11bb041b8b85d4a2a9575a96a : HardwiredMemberDescriptor
      {
        internal PROP_e597e6f11bb041b8b85d4a2a9575a96a()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_3cafb592e1b14933b1ed1cc4665372e7 : HardwiredMemberDescriptor
      {
        internal PROP_3cafb592e1b14933b1ed1cc4665372e7()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_c8a1bc7d194a403badfd7c6d6219b497 : HardwiredMemberDescriptor
      {
        internal PROP_c8a1bc7d194a403badfd7c6d6219b497()
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

      private sealed class PROP_6cb7f9f841f74e71b3421f521284d083 : HardwiredMemberDescriptor
      {
        internal PROP_6cb7f9f841f74e71b3421f521284d083()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_61ae55c8e5b044798ca9514353920a63 : HardwiredMemberDescriptor
      {
        internal PROP_61ae55c8e5b044798ca9514353920a63()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_dd67f691e196477781ea3c3d04ef218c : HardwiredMemberDescriptor
      {
        internal PROP_dd67f691e196477781ea3c3d04ef218c()
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

      private sealed class PROP_731d004776c34271a62f256c456f6602 : HardwiredMemberDescriptor
      {
        internal PROP_731d004776c34271a62f256c456f6602()
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

    private sealed class TYPE_be7978bd4e44424985f8332816a83e67 : HardwiredUserDataDescriptor
    {
      internal TYPE_be7978bd4e44424985f8332816a83e67()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.MTHD_e664120c39a4486bbb95f6fb426eaf14()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.MTHD_bd08d2d143ed4affa5979c54cc087396()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.MTHD_f52913b1830542798ee17e288bee7c4f()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.MTHD_a7fed5921b124b61a466793b62516607()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.MTHD_82b6d158d7de40d4b2d2a92023f51cdd()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.MTHD_4cc50fda062d4cd7a751d01a3f882bd5()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.MTHD_d553bf9d1ced46dc8aeb1b0e5e57d8a4()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.MTHD_031d0521883b4430b15d58ee7e0942c6()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.MTHD_91c11d0db8554b1a9d57116f50d4a0cc()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.MTHD_67c3b9c57f5b401b95fbec2aae443a94()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.MTHD_7c005a8724fe4bd4a4b483ab2a9744dc()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.MTHD_7021c124a0cd4275820cabd041f59b00()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.MTHD_566aa60a2a2f4512a92d334c1e176a5e()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.MTHD_0ff6673cf89c49ce9805b22654b2ef95()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.MTHD_7527fe8025c94125bd03fab8ac17c2a1()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.MTHD_a84016c4b65b4c009ab65baa1a7ea305()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.MTHD_661fe8edcfbc4bb8ba58f6955d73989d()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.MTHD_defaa98bedf5439c9d6c1de76f0cf7f4()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.MTHD_6668a7213bf74fddb6e8f5d533a50428()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.MTHD_5decea505d38473a9d899a902cf99868()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.PROP_6bd5613409414845bd48dc3b99a91361());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.PROP_6f8b7da24e1245349db86dc2a4336a94());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.PROP_e5e898cae6514dbc89576a4718a3a793());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.PROP_cf38d6b6d3724fe2bd842a0c21163ff1());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.PROP_8a08914a6a324a039b5c5e03c2722a57());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.PROP_86a7ed73a7fe468ab790730df3c0d09e());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.PROP_c016f0a96b0c4b0db91c18e9630ca3bf());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_be7978bd4e44424985f8332816a83e67.PROP_4bccda3e875149f6a696c03c594fb50e());
      }

      private sealed class MTHD_e664120c39a4486bbb95f6fb426eaf14 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e664120c39a4486bbb95f6fb426eaf14()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_bd08d2d143ed4affa5979c54cc087396 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd08d2d143ed4affa5979c54cc087396()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_f52913b1830542798ee17e288bee7c4f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f52913b1830542798ee17e288bee7c4f()
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

      private sealed class MTHD_a7fed5921b124b61a466793b62516607 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a7fed5921b124b61a466793b62516607()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_82b6d158d7de40d4b2d2a92023f51cdd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_82b6d158d7de40d4b2d2a92023f51cdd()
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

      private sealed class MTHD_4cc50fda062d4cd7a751d01a3f882bd5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4cc50fda062d4cd7a751d01a3f882bd5()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_d553bf9d1ced46dc8aeb1b0e5e57d8a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d553bf9d1ced46dc8aeb1b0e5e57d8a4()
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

      private sealed class MTHD_031d0521883b4430b15d58ee7e0942c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_031d0521883b4430b15d58ee7e0942c6()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_91c11d0db8554b1a9d57116f50d4a0cc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_91c11d0db8554b1a9d57116f50d4a0cc()
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

      private sealed class MTHD_67c3b9c57f5b401b95fbec2aae443a94 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67c3b9c57f5b401b95fbec2aae443a94()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_7c005a8724fe4bd4a4b483ab2a9744dc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7c005a8724fe4bd4a4b483ab2a9744dc()
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

      private sealed class MTHD_7021c124a0cd4275820cabd041f59b00 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7021c124a0cd4275820cabd041f59b00()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_566aa60a2a2f4512a92d334c1e176a5e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_566aa60a2a2f4512a92d334c1e176a5e()
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

      private sealed class MTHD_0ff6673cf89c49ce9805b22654b2ef95 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ff6673cf89c49ce9805b22654b2ef95()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_7527fe8025c94125bd03fab8ac17c2a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7527fe8025c94125bd03fab8ac17c2a1()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_a84016c4b65b4c009ab65baa1a7ea305 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a84016c4b65b4c009ab65baa1a7ea305()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_661fe8edcfbc4bb8ba58f6955d73989d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_661fe8edcfbc4bb8ba58f6955d73989d()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_defaa98bedf5439c9d6c1de76f0cf7f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_defaa98bedf5439c9d6c1de76f0cf7f4()
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

      private sealed class MTHD_6668a7213bf74fddb6e8f5d533a50428 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6668a7213bf74fddb6e8f5d533a50428()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_5decea505d38473a9d899a902cf99868 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5decea505d38473a9d899a902cf99868()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_6bd5613409414845bd48dc3b99a91361 : HardwiredMemberDescriptor
      {
        internal PROP_6bd5613409414845bd48dc3b99a91361()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_6f8b7da24e1245349db86dc2a4336a94 : HardwiredMemberDescriptor
      {
        internal PROP_6f8b7da24e1245349db86dc2a4336a94()
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

      private sealed class PROP_e5e898cae6514dbc89576a4718a3a793 : HardwiredMemberDescriptor
      {
        internal PROP_e5e898cae6514dbc89576a4718a3a793()
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

      private sealed class PROP_cf38d6b6d3724fe2bd842a0c21163ff1 : HardwiredMemberDescriptor
      {
        internal PROP_cf38d6b6d3724fe2bd842a0c21163ff1()
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

      private sealed class PROP_8a08914a6a324a039b5c5e03c2722a57 : HardwiredMemberDescriptor
      {
        internal PROP_8a08914a6a324a039b5c5e03c2722a57()
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

      private sealed class PROP_86a7ed73a7fe468ab790730df3c0d09e : HardwiredMemberDescriptor
      {
        internal PROP_86a7ed73a7fe468ab790730df3c0d09e()
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

      private sealed class PROP_c016f0a96b0c4b0db91c18e9630ca3bf : HardwiredMemberDescriptor
      {
        internal PROP_c016f0a96b0c4b0db91c18e9630ca3bf()
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

      private sealed class PROP_4bccda3e875149f6a696c03c594fb50e : HardwiredMemberDescriptor
      {
        internal PROP_4bccda3e875149f6a696c03c594fb50e()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_b6e21c6b0c2a495d830037f7aa66b068 : HardwiredUserDataDescriptor
    {
      internal TYPE_b6e21c6b0c2a495d830037f7aa66b068()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.MTHD_25493fa5ee1a4f86936851ae30d9eb9f()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.MTHD_01fa9fbe0e9748d2a536a66269a509f8()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.MTHD_c6f3316452954969a842f4199595fc5a()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.MTHD_4b994655d93742e0b8b71ed0fc3de1e4()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.MTHD_f3d8856d05084162b9918b06f46e2681()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.MTHD_42ed02a989c5462692f6132a3960b172()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.MTHD_e643588895224fffb7bc86f47d0dccdd()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.MTHD_2dc5f8429d7c40fb8696f1765993f0df()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.MTHD_0ba9d4d50f7f4a3ba9a0ec889a3aa5d0()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.MTHD_9d82f65c58e545518f7546ab2eaaaa52()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.MTHD_a14cdd9a357b4c37aca64eeabe24acda()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.MTHD_f390458e682044e4a5b0a30247fe3a88()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.MTHD_08d00a9bdfe14c749e31f4af5fa64fcb()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.MTHD_fd060690c2dd4df8930a594d17fb9ac4()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.MTHD_0706e8fa5e2441ecb8b7b8c3e8507f10()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.MTHD_24ae53f97c654a4186eb2189bf1cb977()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.MTHD_4ff5d9ecb5e34e8f836a3ce67bc32759()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.MTHD_ea66f093c6ee433297abe6029f468a16()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.MTHD_8efbff2c3c1a4b0a888cda1375d4294f()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.PROP_9785b15faa7248a39858c5896bb669e4());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.PROP_4b45cd2d9de54a4fa2e85f385da40822());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.PROP_54a06d3863074f4ab64d117e352c5213());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.PROP_93dd9d397b9447558ccca52d629a14e0());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.PROP_8e430a70316e4c4683a5b82bbc564f7b());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.PROP_57b477f847aa4bd293d798fc71ce8d1d());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.PROP_575340afb8e946b29e28fff61b70fafc());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_b6e21c6b0c2a495d830037f7aa66b068.PROP_edc896a576884b0bbbc817baff32ecd5());
      }

      private sealed class MTHD_25493fa5ee1a4f86936851ae30d9eb9f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_25493fa5ee1a4f86936851ae30d9eb9f()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_01fa9fbe0e9748d2a536a66269a509f8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_01fa9fbe0e9748d2a536a66269a509f8()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_c6f3316452954969a842f4199595fc5a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c6f3316452954969a842f4199595fc5a()
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

      private sealed class MTHD_4b994655d93742e0b8b71ed0fc3de1e4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b994655d93742e0b8b71ed0fc3de1e4()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_f3d8856d05084162b9918b06f46e2681 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f3d8856d05084162b9918b06f46e2681()
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

      private sealed class MTHD_42ed02a989c5462692f6132a3960b172 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42ed02a989c5462692f6132a3960b172()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_e643588895224fffb7bc86f47d0dccdd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e643588895224fffb7bc86f47d0dccdd()
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

      private sealed class MTHD_2dc5f8429d7c40fb8696f1765993f0df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2dc5f8429d7c40fb8696f1765993f0df()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_0ba9d4d50f7f4a3ba9a0ec889a3aa5d0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ba9d4d50f7f4a3ba9a0ec889a3aa5d0()
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

      private sealed class MTHD_9d82f65c58e545518f7546ab2eaaaa52 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d82f65c58e545518f7546ab2eaaaa52()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_a14cdd9a357b4c37aca64eeabe24acda : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a14cdd9a357b4c37aca64eeabe24acda()
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

      private sealed class MTHD_f390458e682044e4a5b0a30247fe3a88 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f390458e682044e4a5b0a30247fe3a88()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_08d00a9bdfe14c749e31f4af5fa64fcb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_08d00a9bdfe14c749e31f4af5fa64fcb()
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

      private sealed class MTHD_fd060690c2dd4df8930a594d17fb9ac4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd060690c2dd4df8930a594d17fb9ac4()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_0706e8fa5e2441ecb8b7b8c3e8507f10 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0706e8fa5e2441ecb8b7b8c3e8507f10()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_24ae53f97c654a4186eb2189bf1cb977 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24ae53f97c654a4186eb2189bf1cb977()
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

      private sealed class MTHD_4ff5d9ecb5e34e8f836a3ce67bc32759 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ff5d9ecb5e34e8f836a3ce67bc32759()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_ea66f093c6ee433297abe6029f468a16 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea66f093c6ee433297abe6029f468a16()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_8efbff2c3c1a4b0a888cda1375d4294f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8efbff2c3c1a4b0a888cda1375d4294f()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_9785b15faa7248a39858c5896bb669e4 : HardwiredMemberDescriptor
      {
        internal PROP_9785b15faa7248a39858c5896bb669e4()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_4b45cd2d9de54a4fa2e85f385da40822 : HardwiredMemberDescriptor
      {
        internal PROP_4b45cd2d9de54a4fa2e85f385da40822()
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

      private sealed class PROP_54a06d3863074f4ab64d117e352c5213 : HardwiredMemberDescriptor
      {
        internal PROP_54a06d3863074f4ab64d117e352c5213()
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

      private sealed class PROP_93dd9d397b9447558ccca52d629a14e0 : HardwiredMemberDescriptor
      {
        internal PROP_93dd9d397b9447558ccca52d629a14e0()
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

      private sealed class PROP_8e430a70316e4c4683a5b82bbc564f7b : HardwiredMemberDescriptor
      {
        internal PROP_8e430a70316e4c4683a5b82bbc564f7b()
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

      private sealed class PROP_57b477f847aa4bd293d798fc71ce8d1d : HardwiredMemberDescriptor
      {
        internal PROP_57b477f847aa4bd293d798fc71ce8d1d()
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

      private sealed class PROP_575340afb8e946b29e28fff61b70fafc : HardwiredMemberDescriptor
      {
        internal PROP_575340afb8e946b29e28fff61b70fafc()
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

      private sealed class PROP_edc896a576884b0bbbc817baff32ecd5 : HardwiredMemberDescriptor
      {
        internal PROP_edc896a576884b0bbbc817baff32ecd5()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_9028d2040d2e425d9441dd46e65d3390 : HardwiredUserDataDescriptor
    {
      internal TYPE_9028d2040d2e425d9441dd46e65d3390()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_baadb003d3704bb1b66fb3c81aed0a62()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_84573b2034c24731a623df0d0be3c176()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_9ec16985b72e4b57bf64804b16284391()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_f7d2deaeffa3408c9c826b8569bd76fa()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_ac58a349d36a48ab9903ea808ca3fae9()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_46cbb85ca14846f99dcd2c4993f6ffc4()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_5401a736b50e42e8a4473aa5c7de87a6()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_9b0ed2623b3d444d9c60777de39e9ab1()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_68a216f60fae4c8297948f728f7f342c()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_9dfac900da77422ab9c8b8e506147398()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_7f16454dd2b2488d986b493575039ae0()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_34c4745bfa4740c894b365330215c224()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_e5afb3d74c724bfd98539c178551dba3()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_09d29ebec13145ad93f6fef31ac2670a()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_2baf18b14d36466ba1c7b5358b7701d7()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_3e0edc9d309743d9b81665437ef186aa()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_14deb2b626e4465b9020d6356ba70b13()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_a26e1f6b1ef94771bcddd671b577a0fe()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_e8c17c399b4c4445b57839911a6b8f5f()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_f1e5eb27f50742489b9e9dd0e652ce36()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_0b316b9a2ec342d793d5bf60d6cbf0b3()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_4316ef814aa14228ba4a23fcfa87cfce()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_3a4873fc93994d289a93d0b43f47f5bd()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_99c55686529449e4805a84663b38b8d4()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_baacceb05a5747909ad8a02fde024d5b()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_c8963d53715147dc800571bff23efb03()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_3d467ed5c71045279eb3424f97954cac()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.MTHD_d3efb28976d547f79d0c8a8d30d814ad()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.PROP_241ed0247e9345bc908c609e77b8d5a7());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.PROP_8acd8864c76d477c83464642cfa9c43e());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.PROP_b123321a1b0041ef82bfa32e4b41a2bf());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.PROP_3b2069876fae4ecbb5a58e1f731dba16());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.PROP_32c2a2a1044947f9a4a61118c9fae3e1());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.PROP_979f315213a849a6a53720c543545ad4());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.PROP_bc3b2bba7334405ea594f1ac69815ccb());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.PROP_f2790d025339443c9ac6331a1e317b42());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.PROP_80e5f2a10be548a696839def77a6073b());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.PROP_c25bb06e9a1a44fa8a75e1481a1e6fb6());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.PROP_36d2254df366473fb61f50b24f8b4ea5());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.PROP_da86121bac1d423a933a96a66a888cc7());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.PROP_c6cc1419a3814e1bbf2db5f60783a454());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.PROP_744d267afd894c658d682f42fb850a31());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.PROP_fd10c50d76de46ac9aa252edaaaa2fc7());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.PROP_26565c6ddc7547c08bb22d1620283cba());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_9028d2040d2e425d9441dd46e65d3390.PROP_72374385535e466ebbeb2c13c4602747());
      }

      private sealed class MTHD_baadb003d3704bb1b66fb3c81aed0a62 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_baadb003d3704bb1b66fb3c81aed0a62()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_84573b2034c24731a623df0d0be3c176 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84573b2034c24731a623df0d0be3c176()
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

      private sealed class MTHD_9ec16985b72e4b57bf64804b16284391 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ec16985b72e4b57bf64804b16284391()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_f7d2deaeffa3408c9c826b8569bd76fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7d2deaeffa3408c9c826b8569bd76fa()
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

      private sealed class MTHD_ac58a349d36a48ab9903ea808ca3fae9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac58a349d36a48ab9903ea808ca3fae9()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_46cbb85ca14846f99dcd2c4993f6ffc4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_46cbb85ca14846f99dcd2c4993f6ffc4()
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

      private sealed class MTHD_5401a736b50e42e8a4473aa5c7de87a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5401a736b50e42e8a4473aa5c7de87a6()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_9b0ed2623b3d444d9c60777de39e9ab1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b0ed2623b3d444d9c60777de39e9ab1()
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

      private sealed class MTHD_68a216f60fae4c8297948f728f7f342c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_68a216f60fae4c8297948f728f7f342c()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_9dfac900da77422ab9c8b8e506147398 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9dfac900da77422ab9c8b8e506147398()
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

      private sealed class MTHD_7f16454dd2b2488d986b493575039ae0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f16454dd2b2488d986b493575039ae0()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_34c4745bfa4740c894b365330215c224 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_34c4745bfa4740c894b365330215c224()
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

      private sealed class MTHD_e5afb3d74c724bfd98539c178551dba3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e5afb3d74c724bfd98539c178551dba3()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_09d29ebec13145ad93f6fef31ac2670a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_09d29ebec13145ad93f6fef31ac2670a()
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

      private sealed class MTHD_2baf18b14d36466ba1c7b5358b7701d7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2baf18b14d36466ba1c7b5358b7701d7()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_3e0edc9d309743d9b81665437ef186aa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e0edc9d309743d9b81665437ef186aa()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_14deb2b626e4465b9020d6356ba70b13 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_14deb2b626e4465b9020d6356ba70b13()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_a26e1f6b1ef94771bcddd671b577a0fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a26e1f6b1ef94771bcddd671b577a0fe()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_e8c17c399b4c4445b57839911a6b8f5f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e8c17c399b4c4445b57839911a6b8f5f()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_f1e5eb27f50742489b9e9dd0e652ce36 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f1e5eb27f50742489b9e9dd0e652ce36()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_0b316b9a2ec342d793d5bf60d6cbf0b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b316b9a2ec342d793d5bf60d6cbf0b3()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_4316ef814aa14228ba4a23fcfa87cfce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4316ef814aa14228ba4a23fcfa87cfce()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_3a4873fc93994d289a93d0b43f47f5bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3a4873fc93994d289a93d0b43f47f5bd()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_99c55686529449e4805a84663b38b8d4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99c55686529449e4805a84663b38b8d4()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_baacceb05a5747909ad8a02fde024d5b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_baacceb05a5747909ad8a02fde024d5b()
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

      private sealed class MTHD_c8963d53715147dc800571bff23efb03 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c8963d53715147dc800571bff23efb03()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_3d467ed5c71045279eb3424f97954cac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d467ed5c71045279eb3424f97954cac()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_d3efb28976d547f79d0c8a8d30d814ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d3efb28976d547f79d0c8a8d30d814ad()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_241ed0247e9345bc908c609e77b8d5a7 : HardwiredMemberDescriptor
      {
        internal PROP_241ed0247e9345bc908c609e77b8d5a7()
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

      private sealed class PROP_8acd8864c76d477c83464642cfa9c43e : HardwiredMemberDescriptor
      {
        internal PROP_8acd8864c76d477c83464642cfa9c43e()
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

      private sealed class PROP_b123321a1b0041ef82bfa32e4b41a2bf : HardwiredMemberDescriptor
      {
        internal PROP_b123321a1b0041ef82bfa32e4b41a2bf()
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

      private sealed class PROP_3b2069876fae4ecbb5a58e1f731dba16 : HardwiredMemberDescriptor
      {
        internal PROP_3b2069876fae4ecbb5a58e1f731dba16()
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

      private sealed class PROP_32c2a2a1044947f9a4a61118c9fae3e1 : HardwiredMemberDescriptor
      {
        internal PROP_32c2a2a1044947f9a4a61118c9fae3e1()
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

      private sealed class PROP_979f315213a849a6a53720c543545ad4 : HardwiredMemberDescriptor
      {
        internal PROP_979f315213a849a6a53720c543545ad4()
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

      private sealed class PROP_bc3b2bba7334405ea594f1ac69815ccb : HardwiredMemberDescriptor
      {
        internal PROP_bc3b2bba7334405ea594f1ac69815ccb()
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

      private sealed class PROP_f2790d025339443c9ac6331a1e317b42 : HardwiredMemberDescriptor
      {
        internal PROP_f2790d025339443c9ac6331a1e317b42()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_80e5f2a10be548a696839def77a6073b : HardwiredMemberDescriptor
      {
        internal PROP_80e5f2a10be548a696839def77a6073b()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_c25bb06e9a1a44fa8a75e1481a1e6fb6 : HardwiredMemberDescriptor
      {
        internal PROP_c25bb06e9a1a44fa8a75e1481a1e6fb6()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_36d2254df366473fb61f50b24f8b4ea5 : HardwiredMemberDescriptor
      {
        internal PROP_36d2254df366473fb61f50b24f8b4ea5()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_da86121bac1d423a933a96a66a888cc7 : HardwiredMemberDescriptor
      {
        internal PROP_da86121bac1d423a933a96a66a888cc7()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_c6cc1419a3814e1bbf2db5f60783a454 : HardwiredMemberDescriptor
      {
        internal PROP_c6cc1419a3814e1bbf2db5f60783a454()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_744d267afd894c658d682f42fb850a31 : HardwiredMemberDescriptor
      {
        internal PROP_744d267afd894c658d682f42fb850a31()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_fd10c50d76de46ac9aa252edaaaa2fc7 : HardwiredMemberDescriptor
      {
        internal PROP_fd10c50d76de46ac9aa252edaaaa2fc7()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_26565c6ddc7547c08bb22d1620283cba : HardwiredMemberDescriptor
      {
        internal PROP_26565c6ddc7547c08bb22d1620283cba()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_72374385535e466ebbeb2c13c4602747 : HardwiredMemberDescriptor
      {
        internal PROP_72374385535e466ebbeb2c13c4602747()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_45b1bf24594344b29a271cbcf49f13db : HardwiredUserDataDescriptor
    {
      internal TYPE_45b1bf24594344b29a271cbcf49f13db()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_45b1bf24594344b29a271cbcf49f13db.MTHD_9c3e1240af8e4a99b2a602d75c2f5b27()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_45b1bf24594344b29a271cbcf49f13db.MTHD_88d0d5ecb6fd4c63851e6006f6566d91()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_45b1bf24594344b29a271cbcf49f13db.MTHD_e17be3a3f46e4dfc9739522b0034d900()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_45b1bf24594344b29a271cbcf49f13db.MTHD_9d28b5bffc2b4f96a91d624518e94f96()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_45b1bf24594344b29a271cbcf49f13db.MTHD_cd8ef92c1b0e4e9abe71a2d807c841d1()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_45b1bf24594344b29a271cbcf49f13db.MTHD_ef746afdd0bf4f13980fc01ecb0b40c2()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_45b1bf24594344b29a271cbcf49f13db.MTHD_0f1d2e44480144b2b4acea849330cb6e()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_45b1bf24594344b29a271cbcf49f13db.MTHD_256403711ca74b06a0f1096e2a73e232()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_45b1bf24594344b29a271cbcf49f13db.MTHD_dbfdd2c3254043a79d525249db1f20ba()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_45b1bf24594344b29a271cbcf49f13db.MTHD_0b31d6a708804d3f919c404c53095023()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_45b1bf24594344b29a271cbcf49f13db.MTHD_2327b7702ad74c4b9d537e20637a26f9()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_45b1bf24594344b29a271cbcf49f13db.MTHD_7fc362725df847829bf787cdf6c7295a()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_45b1bf24594344b29a271cbcf49f13db.MTHD_66224de27ddd4314b78c401c189bbb71()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_45b1bf24594344b29a271cbcf49f13db.MTHD_63d6d287f40946388235460b9de8c3e7()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_45b1bf24594344b29a271cbcf49f13db.MTHD_0339daacd9d644c6a176f22e3817185a()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_45b1bf24594344b29a271cbcf49f13db.MTHD_7c822f7f72d14973af539603e9433f9c()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_45b1bf24594344b29a271cbcf49f13db.MTHD_a471288f5cf94f6d8ad52676ac8201dd()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_45b1bf24594344b29a271cbcf49f13db.PROP_9278e93228134d4b9b46093308daadbb());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_45b1bf24594344b29a271cbcf49f13db.PROP_259d5395de8d4ecd947e76550d4d5583());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_45b1bf24594344b29a271cbcf49f13db.PROP_f5cb6fe25f664c36948caf994780b231());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_45b1bf24594344b29a271cbcf49f13db.PROP_e16732f17c1c46019ec66268d1f52f92());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_45b1bf24594344b29a271cbcf49f13db.PROP_ba54171f1c5c484ea1ebb966f896cbed());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_45b1bf24594344b29a271cbcf49f13db.PROP_6c854601169647598484f01c2fc890dd());
      }

      private sealed class MTHD_9c3e1240af8e4a99b2a602d75c2f5b27 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c3e1240af8e4a99b2a602d75c2f5b27()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_88d0d5ecb6fd4c63851e6006f6566d91 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_88d0d5ecb6fd4c63851e6006f6566d91()
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

      private sealed class MTHD_e17be3a3f46e4dfc9739522b0034d900 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e17be3a3f46e4dfc9739522b0034d900()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_9d28b5bffc2b4f96a91d624518e94f96 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d28b5bffc2b4f96a91d624518e94f96()
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

      private sealed class MTHD_cd8ef92c1b0e4e9abe71a2d807c841d1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd8ef92c1b0e4e9abe71a2d807c841d1()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_ef746afdd0bf4f13980fc01ecb0b40c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef746afdd0bf4f13980fc01ecb0b40c2()
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

      private sealed class MTHD_0f1d2e44480144b2b4acea849330cb6e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f1d2e44480144b2b4acea849330cb6e()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_256403711ca74b06a0f1096e2a73e232 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_256403711ca74b06a0f1096e2a73e232()
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

      private sealed class MTHD_dbfdd2c3254043a79d525249db1f20ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dbfdd2c3254043a79d525249db1f20ba()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_0b31d6a708804d3f919c404c53095023 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b31d6a708804d3f919c404c53095023()
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

      private sealed class MTHD_2327b7702ad74c4b9d537e20637a26f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2327b7702ad74c4b9d537e20637a26f9()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_7fc362725df847829bf787cdf6c7295a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7fc362725df847829bf787cdf6c7295a()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_66224de27ddd4314b78c401c189bbb71 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_66224de27ddd4314b78c401c189bbb71()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_63d6d287f40946388235460b9de8c3e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_63d6d287f40946388235460b9de8c3e7()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_0339daacd9d644c6a176f22e3817185a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0339daacd9d644c6a176f22e3817185a()
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

      private sealed class MTHD_7c822f7f72d14973af539603e9433f9c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7c822f7f72d14973af539603e9433f9c()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_a471288f5cf94f6d8ad52676ac8201dd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a471288f5cf94f6d8ad52676ac8201dd()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_9278e93228134d4b9b46093308daadbb : HardwiredMemberDescriptor
      {
        internal PROP_9278e93228134d4b9b46093308daadbb()
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

      private sealed class PROP_259d5395de8d4ecd947e76550d4d5583 : HardwiredMemberDescriptor
      {
        internal PROP_259d5395de8d4ecd947e76550d4d5583()
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

      private sealed class PROP_f5cb6fe25f664c36948caf994780b231 : HardwiredMemberDescriptor
      {
        internal PROP_f5cb6fe25f664c36948caf994780b231()
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

      private sealed class PROP_e16732f17c1c46019ec66268d1f52f92 : HardwiredMemberDescriptor
      {
        internal PROP_e16732f17c1c46019ec66268d1f52f92()
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

      private sealed class PROP_ba54171f1c5c484ea1ebb966f896cbed : HardwiredMemberDescriptor
      {
        internal PROP_ba54171f1c5c484ea1ebb966f896cbed()
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

      private sealed class PROP_6c854601169647598484f01c2fc890dd : HardwiredMemberDescriptor
      {
        internal PROP_6c854601169647598484f01c2fc890dd()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_d140d804e4cc407da2d335a49729ae0f : HardwiredUserDataDescriptor
    {
      internal TYPE_d140d804e4cc407da2d335a49729ae0f()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d140d804e4cc407da2d335a49729ae0f.MTHD_017ee89d24b24271ae986d514b0e8fc3(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d140d804e4cc407da2d335a49729ae0f.MTHD_6d259dbbb5604bb8ace74995c28b4964()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d140d804e4cc407da2d335a49729ae0f.MTHD_b866210ce45d4495af2b1942da9ec056(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d140d804e4cc407da2d335a49729ae0f.MTHD_9b86c806f0a14ba0af4f1573aad170f5()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d140d804e4cc407da2d335a49729ae0f.MTHD_e83ee6e35eae4567af0b4be29f0e68ea()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d140d804e4cc407da2d335a49729ae0f.MTHD_707457433d154422af98ac4cf628f818()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d140d804e4cc407da2d335a49729ae0f.MTHD_8865815868e247ac9439220425352ebd()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d140d804e4cc407da2d335a49729ae0f.MTHD_383a1f64b5114ee08123fafd1dfcc7ff()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d140d804e4cc407da2d335a49729ae0f.MTHD_cf71c1f23cb24f8ab94594cfe832623f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d140d804e4cc407da2d335a49729ae0f.MTHD_2cf063c878ac4b2281e9757d50dedd9f()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d140d804e4cc407da2d335a49729ae0f.MTHD_ce82120724e34a8bb13f521daddf3c22()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d140d804e4cc407da2d335a49729ae0f.MTHD_1fd171eb2edf4e5db3f702cb01356fba(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d140d804e4cc407da2d335a49729ae0f.MTHD_a2751c1a57844ced90fe6c93e1d99144()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d140d804e4cc407da2d335a49729ae0f.MTHD_3325f92fbc9b4ca5972c20cfbd370297(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d140d804e4cc407da2d335a49729ae0f.MTHD_8ac0729fd0fe4e1aa5b5c07939573f49()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d140d804e4cc407da2d335a49729ae0f.MTHD_17dc00ef115141238bad9bec54a5b363(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d140d804e4cc407da2d335a49729ae0f.MTHD_547b33eab57948f08787fe2c4334097e()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d140d804e4cc407da2d335a49729ae0f.MTHD_ffabb204423747f0aabcddd150068d68(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d140d804e4cc407da2d335a49729ae0f.MTHD_d724f0aa251b4851923f059854430bca()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d140d804e4cc407da2d335a49729ae0f.MTHD_b27572e2f4bb4499866ea3f9db0a159e(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d140d804e4cc407da2d335a49729ae0f.MTHD_094c0fb2ee1a4a58bf37ec0d2006a24e()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d140d804e4cc407da2d335a49729ae0f.MTHD_8a7645410ecc44539f831595c6c5da78()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d140d804e4cc407da2d335a49729ae0f.MTHD_fcad2d1a42b249b5bfcca6264304f16f()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_d140d804e4cc407da2d335a49729ae0f.FLDV_ff0ec8b5b92e4084b29d751e723e96c0());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_d140d804e4cc407da2d335a49729ae0f.FLDV_a7cf4dfca887444994fd763bc588c9c1());
      }

      private sealed class MTHD_017ee89d24b24271ae986d514b0e8fc3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_017ee89d24b24271ae986d514b0e8fc3()
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

      private sealed class MTHD_6d259dbbb5604bb8ace74995c28b4964 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d259dbbb5604bb8ace74995c28b4964()
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

      private sealed class MTHD_b866210ce45d4495af2b1942da9ec056 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b866210ce45d4495af2b1942da9ec056()
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

      private sealed class MTHD_9b86c806f0a14ba0af4f1573aad170f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b86c806f0a14ba0af4f1573aad170f5()
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

      private sealed class MTHD_e83ee6e35eae4567af0b4be29f0e68ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e83ee6e35eae4567af0b4be29f0e68ea()
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

      private sealed class MTHD_707457433d154422af98ac4cf628f818 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_707457433d154422af98ac4cf628f818()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_8865815868e247ac9439220425352ebd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8865815868e247ac9439220425352ebd()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_383a1f64b5114ee08123fafd1dfcc7ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_383a1f64b5114ee08123fafd1dfcc7ff()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_cf71c1f23cb24f8ab94594cfe832623f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf71c1f23cb24f8ab94594cfe832623f()
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

      private sealed class MTHD_2cf063c878ac4b2281e9757d50dedd9f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2cf063c878ac4b2281e9757d50dedd9f()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_ce82120724e34a8bb13f521daddf3c22 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ce82120724e34a8bb13f521daddf3c22()
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

      private sealed class MTHD_1fd171eb2edf4e5db3f702cb01356fba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1fd171eb2edf4e5db3f702cb01356fba()
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

      private sealed class MTHD_a2751c1a57844ced90fe6c93e1d99144 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2751c1a57844ced90fe6c93e1d99144()
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

      private sealed class MTHD_3325f92fbc9b4ca5972c20cfbd370297 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3325f92fbc9b4ca5972c20cfbd370297()
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

      private sealed class MTHD_8ac0729fd0fe4e1aa5b5c07939573f49 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ac0729fd0fe4e1aa5b5c07939573f49()
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

      private sealed class MTHD_17dc00ef115141238bad9bec54a5b363 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_17dc00ef115141238bad9bec54a5b363()
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

      private sealed class MTHD_547b33eab57948f08787fe2c4334097e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_547b33eab57948f08787fe2c4334097e()
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

      private sealed class MTHD_ffabb204423747f0aabcddd150068d68 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ffabb204423747f0aabcddd150068d68()
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

      private sealed class MTHD_d724f0aa251b4851923f059854430bca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d724f0aa251b4851923f059854430bca()
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

      private sealed class MTHD_b27572e2f4bb4499866ea3f9db0a159e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b27572e2f4bb4499866ea3f9db0a159e()
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

      private sealed class MTHD_094c0fb2ee1a4a58bf37ec0d2006a24e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_094c0fb2ee1a4a58bf37ec0d2006a24e()
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

      private sealed class MTHD_8a7645410ecc44539f831595c6c5da78 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a7645410ecc44539f831595c6c5da78()
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

      private sealed class MTHD_fcad2d1a42b249b5bfcca6264304f16f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fcad2d1a42b249b5bfcca6264304f16f()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_ff0ec8b5b92e4084b29d751e723e96c0 : HardwiredMemberDescriptor
      {
        internal FLDV_ff0ec8b5b92e4084b29d751e723e96c0()
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

      private sealed class FLDV_a7cf4dfca887444994fd763bc588c9c1 : HardwiredMemberDescriptor
      {
        internal FLDV_a7cf4dfca887444994fd763bc588c9c1()
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

    private sealed class TYPE_71e3fcb853144d808b5d749518ac0030 : HardwiredUserDataDescriptor
    {
      internal TYPE_71e3fcb853144d808b5d749518ac0030()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71e3fcb853144d808b5d749518ac0030.MTHD_ec5c2b6c7d6640d1b4845f5301b6a905()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71e3fcb853144d808b5d749518ac0030.MTHD_d71250876add48ae921627659273a158()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71e3fcb853144d808b5d749518ac0030.MTHD_0944e4598b0d42b29857b0bec93c6d8a()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71e3fcb853144d808b5d749518ac0030.MTHD_1eeddf16ba394adc8de2ff3fe89e1cb9()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71e3fcb853144d808b5d749518ac0030.MTHD_84e215b56f3b4dd59fe718420ae965a4()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_71e3fcb853144d808b5d749518ac0030.MTHD_289d8d0606414b97902a20994b45c087()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_71e3fcb853144d808b5d749518ac0030.FLDV_d5bdac05d0f1438890e18bd339170b49());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_71e3fcb853144d808b5d749518ac0030.FLDV_c3075da754134fbdbdf57a2480517d19());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_71e3fcb853144d808b5d749518ac0030.FLDV_08a4a70e81e04dab81614f29d92a53d1());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_71e3fcb853144d808b5d749518ac0030.FLDV_6a1c09bf041d4931b3b4689a2c7b51ee());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_71e3fcb853144d808b5d749518ac0030.FLDV_a3dec2af3db74de78bc3dc04f63927b7());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_71e3fcb853144d808b5d749518ac0030.FLDV_24352824463c4ec186a676dafc560f81());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_71e3fcb853144d808b5d749518ac0030.FLDV_91260fee335542cda4c5995437820d0b());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_71e3fcb853144d808b5d749518ac0030.FLDV_2a525f415896424d8b79269b53fd3f71());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_71e3fcb853144d808b5d749518ac0030.FLDV_21d7085a9782423e89d861f7be3c6568());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_71e3fcb853144d808b5d749518ac0030.FLDV_ad01facab3134bbc888c8421ef580861());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_71e3fcb853144d808b5d749518ac0030.FLDV_7ca93bf1ca044ba086babf3385f8c52a());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_71e3fcb853144d808b5d749518ac0030.FLDV_0d048b05eff54b689cb4bea122c8a5e5());
      }

      private sealed class MTHD_ec5c2b6c7d6640d1b4845f5301b6a905 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec5c2b6c7d6640d1b4845f5301b6a905()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_d71250876add48ae921627659273a158 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d71250876add48ae921627659273a158()
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

      private sealed class MTHD_0944e4598b0d42b29857b0bec93c6d8a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0944e4598b0d42b29857b0bec93c6d8a()
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

      private sealed class MTHD_1eeddf16ba394adc8de2ff3fe89e1cb9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1eeddf16ba394adc8de2ff3fe89e1cb9()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_84e215b56f3b4dd59fe718420ae965a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84e215b56f3b4dd59fe718420ae965a4()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_289d8d0606414b97902a20994b45c087 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_289d8d0606414b97902a20994b45c087()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_d5bdac05d0f1438890e18bd339170b49 : HardwiredMemberDescriptor
      {
        internal FLDV_d5bdac05d0f1438890e18bd339170b49()
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

      private sealed class FLDV_c3075da754134fbdbdf57a2480517d19 : HardwiredMemberDescriptor
      {
        internal FLDV_c3075da754134fbdbdf57a2480517d19()
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

      private sealed class FLDV_08a4a70e81e04dab81614f29d92a53d1 : HardwiredMemberDescriptor
      {
        internal FLDV_08a4a70e81e04dab81614f29d92a53d1()
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

      private sealed class FLDV_6a1c09bf041d4931b3b4689a2c7b51ee : HardwiredMemberDescriptor
      {
        internal FLDV_6a1c09bf041d4931b3b4689a2c7b51ee()
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

      private sealed class FLDV_a3dec2af3db74de78bc3dc04f63927b7 : HardwiredMemberDescriptor
      {
        internal FLDV_a3dec2af3db74de78bc3dc04f63927b7()
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

      private sealed class FLDV_24352824463c4ec186a676dafc560f81 : HardwiredMemberDescriptor
      {
        internal FLDV_24352824463c4ec186a676dafc560f81()
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

      private sealed class FLDV_91260fee335542cda4c5995437820d0b : HardwiredMemberDescriptor
      {
        internal FLDV_91260fee335542cda4c5995437820d0b()
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

      private sealed class FLDV_2a525f415896424d8b79269b53fd3f71 : HardwiredMemberDescriptor
      {
        internal FLDV_2a525f415896424d8b79269b53fd3f71()
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

      private sealed class FLDV_21d7085a9782423e89d861f7be3c6568 : HardwiredMemberDescriptor
      {
        internal FLDV_21d7085a9782423e89d861f7be3c6568()
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

      private sealed class FLDV_ad01facab3134bbc888c8421ef580861 : HardwiredMemberDescriptor
      {
        internal FLDV_ad01facab3134bbc888c8421ef580861()
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

      private sealed class FLDV_7ca93bf1ca044ba086babf3385f8c52a : HardwiredMemberDescriptor
      {
        internal FLDV_7ca93bf1ca044ba086babf3385f8c52a()
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

      private sealed class FLDV_0d048b05eff54b689cb4bea122c8a5e5 : HardwiredMemberDescriptor
      {
        internal FLDV_0d048b05eff54b689cb4bea122c8a5e5()
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

    private sealed class TYPE_c007eefe1f214ddb9f7c05ecef8a1606 : HardwiredUserDataDescriptor
    {
      internal TYPE_c007eefe1f214ddb9f7c05ecef8a1606()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_f04a2b16a7354cb897389ea46310659d()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_b7e162911bd74f9d8b0c2088b2788328()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_cbfc6af0dfed4d65b64909f453a18e30()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_d6d0b031b91348e49b731d502561b19b()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_6aba146db40a4ac795a53fcad2f60f4d()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_1f195597716a402886911ff001fc7058()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_fb2fd2abd9204e7db7d94b9d194e44d1()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_506d23053ae1428f9768f7ffc1c8526e()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_8d05fac3cd544825b5c17e14ee588388()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_9d0fcb7f806c47e9ad41f39592cdc93f()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_58b168d1877647238390b34c56e3006b()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_c1cfb4ab9fda4601878f7c66e0ed2721()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_c50ab36aec3d41708a92543eb3c949c0()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_6e9303ef1cad40e8b34ee122eab5a241()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_8cd44f934fec4f3f889a110123cb75df()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_2c8e25b6989c43e9a659af16c1b93161()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_3b0edf67d5494bf2977393192ca75f7b()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_343cbec65ee748f3a43f4df43b6e265f()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_2d6750f0777e4675b77589294c20ec6e()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_df1556fede5a401ea62b04a30d2b3d7c()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_a9022049253844d7ad262a7c951d3f21()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_11c0404d855e4239aab0e39cf76bd729()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_7424a856c6f5452e93175127f9e68007()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_7f4263ea8d1041b39f1685e48e700906()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_74dc6833d444434a87647347c6ac762e()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_5edd032fb31b40f19bb671380136e830()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_c7acd19ca3594e26a5cebfc9b0adc44b()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_2bd192a3e5b0432f8226b40c27d86919()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_0247b4e1b9ce440a8a01a3ad41facc3f()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_7ad6c577c8f0411d8d26184f359c7d58()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_770a0082abe8481aa01e77bfe997c026()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_b22e740e5fe44723af3001491d13d4e4()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_e6997dee34b94f8b8dc417d86093d1f6()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_ccfd7ab8323145388e97c8c4b03fd5e8()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_41b668835a9d41258d4af37530ec97d7()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_734af549329a4aa5bb85e12909d0588f()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_17b6e0becb2b449e9b902a534802fab2()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_ef5b05c63d864a41a1e2197f2208aa65()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_69c36a8ce6734b3aa15793294d5cfed6()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_5f6a7eb578e64d02a46c865e6cd31079()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_f2c126ef02ba46d48aaca401cc80b5e2()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_dbdf02d10d8344f9af94dacfb1c5ddba()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_9357b5a19d554b1cbd74a9ed98dd7103()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_2e4099ab4fca40a593928924d16a2e9c()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_ce354b12f9dd40f7aa2b2bb859e74394()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_5b9da8d939cf443b931e2c3e62a8f3e3()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_9cdaf919f0894afd9dfc21c3a3efa973()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.MTHD_6d6bbe52b66945d795401f75caa88150()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.PROP_a44175c31ebf4540a29447a0b981d125());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.PROP_054bbc1bf5cc4c5cae2c16cfa2824793());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.PROP_e42d9f33548b4d01920bc4260f252be1());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.PROP_5732cf4fa7654a58a9b89c9ad326909d());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.PROP_d27eb4732cb3474ba6eb8a0ccd64a09a());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.PROP_5af649fd9a2e47ee980f97c10089a604());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.PROP_43d4c982ebbc457195c2dfe582d3817e());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.PROP_71e711a6bb054e1ab4380757728da32a());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.PROP_22f3f5cb04a141ba8c420b44deadb9a8());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.PROP_91398864e36a4aeb89a4f52f50fe4979());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.PROP_cd24694751f445ffb3a2ac68b810bbf8());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.PROP_e9703c327acd4cc897edd61ff829a44d());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.PROP_9f7bfb39d7e14b8a9b05546fc410cd3c());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.PROP_012c2691291647019396d172b40d6683());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.PROP_bdecc964210a491fa740b7d2c5c43f73());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.PROP_138137756c024e7fa38ea8c703dd4b01());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.PROP_29c192b6c69244779ee0c09f2a6346dd());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.PROP_3fb3c97448f049d38c9a751ce30cdf2b());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.PROP_9a86a82aa9a74f8e97bf792e8c4b1c32());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.FLDV_f9d0d6ccc64f454293739bde8e5b7fba());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.FLDV_22683363f4504ae48a24ddfb2a4fe25b());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_c007eefe1f214ddb9f7c05ecef8a1606.FLDV_8b56c383a2ad4e00af681969d75ea42a());
      }

      private sealed class MTHD_f04a2b16a7354cb897389ea46310659d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f04a2b16a7354cb897389ea46310659d()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_b7e162911bd74f9d8b0c2088b2788328 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b7e162911bd74f9d8b0c2088b2788328()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_cbfc6af0dfed4d65b64909f453a18e30 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cbfc6af0dfed4d65b64909f453a18e30()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_d6d0b031b91348e49b731d502561b19b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6d0b031b91348e49b731d502561b19b()
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

      private sealed class MTHD_6aba146db40a4ac795a53fcad2f60f4d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6aba146db40a4ac795a53fcad2f60f4d()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_1f195597716a402886911ff001fc7058 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f195597716a402886911ff001fc7058()
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

      private sealed class MTHD_fb2fd2abd9204e7db7d94b9d194e44d1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb2fd2abd9204e7db7d94b9d194e44d1()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_506d23053ae1428f9768f7ffc1c8526e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_506d23053ae1428f9768f7ffc1c8526e()
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

      private sealed class MTHD_8d05fac3cd544825b5c17e14ee588388 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8d05fac3cd544825b5c17e14ee588388()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_9d0fcb7f806c47e9ad41f39592cdc93f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d0fcb7f806c47e9ad41f39592cdc93f()
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

      private sealed class MTHD_58b168d1877647238390b34c56e3006b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_58b168d1877647238390b34c56e3006b()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_c1cfb4ab9fda4601878f7c66e0ed2721 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c1cfb4ab9fda4601878f7c66e0ed2721()
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

      private sealed class MTHD_c50ab36aec3d41708a92543eb3c949c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c50ab36aec3d41708a92543eb3c949c0()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_6e9303ef1cad40e8b34ee122eab5a241 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e9303ef1cad40e8b34ee122eab5a241()
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

      private sealed class MTHD_8cd44f934fec4f3f889a110123cb75df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8cd44f934fec4f3f889a110123cb75df()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_2c8e25b6989c43e9a659af16c1b93161 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c8e25b6989c43e9a659af16c1b93161()
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

      private sealed class MTHD_3b0edf67d5494bf2977393192ca75f7b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3b0edf67d5494bf2977393192ca75f7b()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_343cbec65ee748f3a43f4df43b6e265f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_343cbec65ee748f3a43f4df43b6e265f()
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

      private sealed class MTHD_2d6750f0777e4675b77589294c20ec6e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d6750f0777e4675b77589294c20ec6e()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_df1556fede5a401ea62b04a30d2b3d7c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_df1556fede5a401ea62b04a30d2b3d7c()
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

      private sealed class MTHD_a9022049253844d7ad262a7c951d3f21 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a9022049253844d7ad262a7c951d3f21()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_11c0404d855e4239aab0e39cf76bd729 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_11c0404d855e4239aab0e39cf76bd729()
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

      private sealed class MTHD_7424a856c6f5452e93175127f9e68007 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7424a856c6f5452e93175127f9e68007()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_7f4263ea8d1041b39f1685e48e700906 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f4263ea8d1041b39f1685e48e700906()
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

      private sealed class MTHD_74dc6833d444434a87647347c6ac762e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74dc6833d444434a87647347c6ac762e()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_5edd032fb31b40f19bb671380136e830 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5edd032fb31b40f19bb671380136e830()
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

      private sealed class MTHD_c7acd19ca3594e26a5cebfc9b0adc44b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c7acd19ca3594e26a5cebfc9b0adc44b()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_2bd192a3e5b0432f8226b40c27d86919 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2bd192a3e5b0432f8226b40c27d86919()
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

      private sealed class MTHD_0247b4e1b9ce440a8a01a3ad41facc3f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0247b4e1b9ce440a8a01a3ad41facc3f()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_7ad6c577c8f0411d8d26184f359c7d58 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ad6c577c8f0411d8d26184f359c7d58()
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

      private sealed class MTHD_770a0082abe8481aa01e77bfe997c026 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_770a0082abe8481aa01e77bfe997c026()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_b22e740e5fe44723af3001491d13d4e4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b22e740e5fe44723af3001491d13d4e4()
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

      private sealed class MTHD_e6997dee34b94f8b8dc417d86093d1f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e6997dee34b94f8b8dc417d86093d1f6()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_ccfd7ab8323145388e97c8c4b03fd5e8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ccfd7ab8323145388e97c8c4b03fd5e8()
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

      private sealed class MTHD_41b668835a9d41258d4af37530ec97d7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41b668835a9d41258d4af37530ec97d7()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_734af549329a4aa5bb85e12909d0588f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_734af549329a4aa5bb85e12909d0588f()
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

      private sealed class MTHD_17b6e0becb2b449e9b902a534802fab2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_17b6e0becb2b449e9b902a534802fab2()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_ef5b05c63d864a41a1e2197f2208aa65 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef5b05c63d864a41a1e2197f2208aa65()
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

      private sealed class MTHD_69c36a8ce6734b3aa15793294d5cfed6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69c36a8ce6734b3aa15793294d5cfed6()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_5f6a7eb578e64d02a46c865e6cd31079 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5f6a7eb578e64d02a46c865e6cd31079()
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

      private sealed class MTHD_f2c126ef02ba46d48aaca401cc80b5e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f2c126ef02ba46d48aaca401cc80b5e2()
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

      private sealed class MTHD_dbdf02d10d8344f9af94dacfb1c5ddba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dbdf02d10d8344f9af94dacfb1c5ddba()
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

      private sealed class MTHD_9357b5a19d554b1cbd74a9ed98dd7103 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9357b5a19d554b1cbd74a9ed98dd7103()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_2e4099ab4fca40a593928924d16a2e9c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2e4099ab4fca40a593928924d16a2e9c()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ce354b12f9dd40f7aa2b2bb859e74394 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ce354b12f9dd40f7aa2b2bb859e74394()
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

      private sealed class MTHD_5b9da8d939cf443b931e2c3e62a8f3e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b9da8d939cf443b931e2c3e62a8f3e3()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_9cdaf919f0894afd9dfc21c3a3efa973 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9cdaf919f0894afd9dfc21c3a3efa973()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_6d6bbe52b66945d795401f75caa88150 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d6bbe52b66945d795401f75caa88150()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_a44175c31ebf4540a29447a0b981d125 : HardwiredMemberDescriptor
      {
        internal PROP_a44175c31ebf4540a29447a0b981d125()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_054bbc1bf5cc4c5cae2c16cfa2824793 : HardwiredMemberDescriptor
      {
        internal PROP_054bbc1bf5cc4c5cae2c16cfa2824793()
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

      private sealed class PROP_e42d9f33548b4d01920bc4260f252be1 : HardwiredMemberDescriptor
      {
        internal PROP_e42d9f33548b4d01920bc4260f252be1()
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

      private sealed class PROP_5732cf4fa7654a58a9b89c9ad326909d : HardwiredMemberDescriptor
      {
        internal PROP_5732cf4fa7654a58a9b89c9ad326909d()
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

      private sealed class PROP_d27eb4732cb3474ba6eb8a0ccd64a09a : HardwiredMemberDescriptor
      {
        internal PROP_d27eb4732cb3474ba6eb8a0ccd64a09a()
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

      private sealed class PROP_5af649fd9a2e47ee980f97c10089a604 : HardwiredMemberDescriptor
      {
        internal PROP_5af649fd9a2e47ee980f97c10089a604()
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

      private sealed class PROP_43d4c982ebbc457195c2dfe582d3817e : HardwiredMemberDescriptor
      {
        internal PROP_43d4c982ebbc457195c2dfe582d3817e()
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

      private sealed class PROP_71e711a6bb054e1ab4380757728da32a : HardwiredMemberDescriptor
      {
        internal PROP_71e711a6bb054e1ab4380757728da32a()
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

      private sealed class PROP_22f3f5cb04a141ba8c420b44deadb9a8 : HardwiredMemberDescriptor
      {
        internal PROP_22f3f5cb04a141ba8c420b44deadb9a8()
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

      private sealed class PROP_91398864e36a4aeb89a4f52f50fe4979 : HardwiredMemberDescriptor
      {
        internal PROP_91398864e36a4aeb89a4f52f50fe4979()
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

      private sealed class PROP_cd24694751f445ffb3a2ac68b810bbf8 : HardwiredMemberDescriptor
      {
        internal PROP_cd24694751f445ffb3a2ac68b810bbf8()
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

      private sealed class PROP_e9703c327acd4cc897edd61ff829a44d : HardwiredMemberDescriptor
      {
        internal PROP_e9703c327acd4cc897edd61ff829a44d()
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

      private sealed class PROP_9f7bfb39d7e14b8a9b05546fc410cd3c : HardwiredMemberDescriptor
      {
        internal PROP_9f7bfb39d7e14b8a9b05546fc410cd3c()
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

      private sealed class PROP_012c2691291647019396d172b40d6683 : HardwiredMemberDescriptor
      {
        internal PROP_012c2691291647019396d172b40d6683()
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

      private sealed class PROP_bdecc964210a491fa740b7d2c5c43f73 : HardwiredMemberDescriptor
      {
        internal PROP_bdecc964210a491fa740b7d2c5c43f73()
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

      private sealed class PROP_138137756c024e7fa38ea8c703dd4b01 : HardwiredMemberDescriptor
      {
        internal PROP_138137756c024e7fa38ea8c703dd4b01()
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

      private sealed class PROP_29c192b6c69244779ee0c09f2a6346dd : HardwiredMemberDescriptor
      {
        internal PROP_29c192b6c69244779ee0c09f2a6346dd()
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

      private sealed class PROP_3fb3c97448f049d38c9a751ce30cdf2b : HardwiredMemberDescriptor
      {
        internal PROP_3fb3c97448f049d38c9a751ce30cdf2b()
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

      private sealed class PROP_9a86a82aa9a74f8e97bf792e8c4b1c32 : HardwiredMemberDescriptor
      {
        internal PROP_9a86a82aa9a74f8e97bf792e8c4b1c32()
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

      private sealed class FLDV_f9d0d6ccc64f454293739bde8e5b7fba : HardwiredMemberDescriptor
      {
        internal FLDV_f9d0d6ccc64f454293739bde8e5b7fba()
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

      private sealed class FLDV_22683363f4504ae48a24ddfb2a4fe25b : HardwiredMemberDescriptor
      {
        internal FLDV_22683363f4504ae48a24ddfb2a4fe25b()
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

      private sealed class FLDV_8b56c383a2ad4e00af681969d75ea42a : HardwiredMemberDescriptor
      {
        internal FLDV_8b56c383a2ad4e00af681969d75ea42a()
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

    private sealed class TYPE_350580a35cc445c08deb4ddc4d3f8030 : HardwiredUserDataDescriptor
    {
      internal TYPE_350580a35cc445c08deb4ddc4d3f8030()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_350580a35cc445c08deb4ddc4d3f8030.MTHD_f03b4a4f711645e9921cb3ece3c239da()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_350580a35cc445c08deb4ddc4d3f8030.MTHD_509477e590f7468984ae9ec939008dca()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_350580a35cc445c08deb4ddc4d3f8030.MTHD_0a72547687a64672bac84278ce35ea4e()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_350580a35cc445c08deb4ddc4d3f8030.MTHD_302091533d5846e0981bab5dfff8de34()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_350580a35cc445c08deb4ddc4d3f8030.MTHD_379e76cd4af043ec9a99dc24450f6b98()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_350580a35cc445c08deb4ddc4d3f8030.MTHD_6741ed754fb445da93e1ccf5382adde2()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_350580a35cc445c08deb4ddc4d3f8030.FLDV_1cadcd63b1b94cb6be55a969db6faa8f());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_350580a35cc445c08deb4ddc4d3f8030.FLDV_6da1764be67746ecba8fdb0f4d5573f9());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_350580a35cc445c08deb4ddc4d3f8030.FLDV_ce9d2fac8f9f467895859c8e7d5f9af8());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_350580a35cc445c08deb4ddc4d3f8030.FLDV_80e42a0d41b24f608f517af13790427b());
      }

      private sealed class MTHD_f03b4a4f711645e9921cb3ece3c239da : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f03b4a4f711645e9921cb3ece3c239da()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_509477e590f7468984ae9ec939008dca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_509477e590f7468984ae9ec939008dca()
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

      private sealed class MTHD_0a72547687a64672bac84278ce35ea4e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0a72547687a64672bac84278ce35ea4e()
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

      private sealed class MTHD_302091533d5846e0981bab5dfff8de34 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_302091533d5846e0981bab5dfff8de34()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_379e76cd4af043ec9a99dc24450f6b98 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_379e76cd4af043ec9a99dc24450f6b98()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_6741ed754fb445da93e1ccf5382adde2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6741ed754fb445da93e1ccf5382adde2()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_1cadcd63b1b94cb6be55a969db6faa8f : HardwiredMemberDescriptor
      {
        internal FLDV_1cadcd63b1b94cb6be55a969db6faa8f()
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

      private sealed class FLDV_6da1764be67746ecba8fdb0f4d5573f9 : HardwiredMemberDescriptor
      {
        internal FLDV_6da1764be67746ecba8fdb0f4d5573f9()
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

      private sealed class FLDV_ce9d2fac8f9f467895859c8e7d5f9af8 : HardwiredMemberDescriptor
      {
        internal FLDV_ce9d2fac8f9f467895859c8e7d5f9af8()
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

      private sealed class FLDV_80e42a0d41b24f608f517af13790427b : HardwiredMemberDescriptor
      {
        internal FLDV_80e42a0d41b24f608f517af13790427b()
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

    private sealed class TYPE_f6ff41ebbb4c4a7496ff0cf84d3c04fe : HardwiredUserDataDescriptor
    {
      internal TYPE_f6ff41ebbb4c4a7496ff0cf84d3c04fe()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6ff41ebbb4c4a7496ff0cf84d3c04fe.MTHD_97be9958910f4d479b3c491c92714345()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6ff41ebbb4c4a7496ff0cf84d3c04fe.MTHD_c3c9df7eafe7458399ddbf31af364756()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6ff41ebbb4c4a7496ff0cf84d3c04fe.MTHD_b3288aa051e94caf8052f59615f951f5()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6ff41ebbb4c4a7496ff0cf84d3c04fe.MTHD_7de23a5eec0e4de6bbb52416b5b0a74b()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f6ff41ebbb4c4a7496ff0cf84d3c04fe.MTHD_c031697551944bc4b749bab428b6a11f()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_f6ff41ebbb4c4a7496ff0cf84d3c04fe.FLDV_f0e5852e172c491caaec9f1c27e69b4c());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_f6ff41ebbb4c4a7496ff0cf84d3c04fe.FLDV_4e352ab9a35642dd8ded69713179c345());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_f6ff41ebbb4c4a7496ff0cf84d3c04fe.FLDV_10e313732a5741e381dbf80f884e4b0d());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_f6ff41ebbb4c4a7496ff0cf84d3c04fe.FLDV_741393de5e584bb19470910ae95893b6());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_f6ff41ebbb4c4a7496ff0cf84d3c04fe.FLDV_910d1c6416394c4a8ae7152f38fc7f2d());
      }

      private sealed class MTHD_97be9958910f4d479b3c491c92714345 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97be9958910f4d479b3c491c92714345()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_c3c9df7eafe7458399ddbf31af364756 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c3c9df7eafe7458399ddbf31af364756()
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

      private sealed class MTHD_b3288aa051e94caf8052f59615f951f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b3288aa051e94caf8052f59615f951f5()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_7de23a5eec0e4de6bbb52416b5b0a74b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7de23a5eec0e4de6bbb52416b5b0a74b()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_c031697551944bc4b749bab428b6a11f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c031697551944bc4b749bab428b6a11f()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_f0e5852e172c491caaec9f1c27e69b4c : HardwiredMemberDescriptor
      {
        internal FLDV_f0e5852e172c491caaec9f1c27e69b4c()
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

      private sealed class FLDV_4e352ab9a35642dd8ded69713179c345 : HardwiredMemberDescriptor
      {
        internal FLDV_4e352ab9a35642dd8ded69713179c345()
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

      private sealed class FLDV_10e313732a5741e381dbf80f884e4b0d : HardwiredMemberDescriptor
      {
        internal FLDV_10e313732a5741e381dbf80f884e4b0d()
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

      private sealed class FLDV_741393de5e584bb19470910ae95893b6 : HardwiredMemberDescriptor
      {
        internal FLDV_741393de5e584bb19470910ae95893b6()
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

      private sealed class FLDV_910d1c6416394c4a8ae7152f38fc7f2d : HardwiredMemberDescriptor
      {
        internal FLDV_910d1c6416394c4a8ae7152f38fc7f2d()
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

    private sealed class TYPE_806a2c37519a4e3b95dc09d4524290ef : HardwiredUserDataDescriptor
    {
      internal TYPE_806a2c37519a4e3b95dc09d4524290ef()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_806a2c37519a4e3b95dc09d4524290ef.MTHD_48014ecc8069470dabc98dbe5c534757()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_806a2c37519a4e3b95dc09d4524290ef.MTHD_019c3f9e3cf7402cac53011bc4d32d02()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_806a2c37519a4e3b95dc09d4524290ef.MTHD_863869a7d346443bb7810e31ee9073e7()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_806a2c37519a4e3b95dc09d4524290ef.MTHD_c8af5ad1663f43cf85ca29b3a964abb2()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_806a2c37519a4e3b95dc09d4524290ef.MTHD_204bca3b5f9e4013b64d3edd796e675b()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_806a2c37519a4e3b95dc09d4524290ef.MTHD_1ba421b3fc3d46269886bf3453436f9d()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_806a2c37519a4e3b95dc09d4524290ef.MTHD_1db258db964b4dfda7c7db45bde0b250()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_806a2c37519a4e3b95dc09d4524290ef.MTHD_c0d0830bc6364d898e989f442e843f11()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_806a2c37519a4e3b95dc09d4524290ef.MTHD_69ddb1bdc29e457da872bdc2e70db93c()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_806a2c37519a4e3b95dc09d4524290ef.MTHD_44f03225171446a58f8d27144161bdd5()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_806a2c37519a4e3b95dc09d4524290ef.MTHD_a186cd4f12734ee2ab5cc876e0fbc516()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_806a2c37519a4e3b95dc09d4524290ef.MTHD_cb8ecb7df44d444684175fd2f5ad3e76()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_806a2c37519a4e3b95dc09d4524290ef.MTHD_fd572c530bce46769b088ff54861c63a()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_806a2c37519a4e3b95dc09d4524290ef.FLDV_8f14c232c690457dbfcef9adc0511ecd());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_806a2c37519a4e3b95dc09d4524290ef.FLDV_4eb8a51a42b649de936ed1ca07fe2b87());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_806a2c37519a4e3b95dc09d4524290ef.FLDV_65e1906affa94ce3a53917fdf7421f7a());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_806a2c37519a4e3b95dc09d4524290ef.FLDV_0dc268ae785942ad9f42a8697f4bf9b3());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_806a2c37519a4e3b95dc09d4524290ef.FLDV_72eeb2075d954d38a5544508c76d1815());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_806a2c37519a4e3b95dc09d4524290ef.FLDV_c750d876b9b940fb8f7a9aa4f807b9ce());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_806a2c37519a4e3b95dc09d4524290ef.FLDV_aaa46417066a4abf8a5312d6c004135d());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_806a2c37519a4e3b95dc09d4524290ef.FLDV_a88e49405eaf4e48b13cf68317bd2204());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_806a2c37519a4e3b95dc09d4524290ef.DVAL_d2f3fd238e184319954c4b3c564088d4());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_806a2c37519a4e3b95dc09d4524290ef.DVAL_24a8b9bb009240ad89f8b6895f5158fb());
      }

      private sealed class MTHD_48014ecc8069470dabc98dbe5c534757 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_48014ecc8069470dabc98dbe5c534757()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_019c3f9e3cf7402cac53011bc4d32d02 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_019c3f9e3cf7402cac53011bc4d32d02()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_863869a7d346443bb7810e31ee9073e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_863869a7d346443bb7810e31ee9073e7()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c8af5ad1663f43cf85ca29b3a964abb2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c8af5ad1663f43cf85ca29b3a964abb2()
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

      private sealed class MTHD_204bca3b5f9e4013b64d3edd796e675b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_204bca3b5f9e4013b64d3edd796e675b()
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

      private sealed class MTHD_1ba421b3fc3d46269886bf3453436f9d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ba421b3fc3d46269886bf3453436f9d()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_1db258db964b4dfda7c7db45bde0b250 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1db258db964b4dfda7c7db45bde0b250()
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

      private sealed class MTHD_c0d0830bc6364d898e989f442e843f11 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c0d0830bc6364d898e989f442e843f11()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_69ddb1bdc29e457da872bdc2e70db93c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69ddb1bdc29e457da872bdc2e70db93c()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_44f03225171446a58f8d27144161bdd5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_44f03225171446a58f8d27144161bdd5()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_a186cd4f12734ee2ab5cc876e0fbc516 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a186cd4f12734ee2ab5cc876e0fbc516()
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

      private sealed class MTHD_cb8ecb7df44d444684175fd2f5ad3e76 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cb8ecb7df44d444684175fd2f5ad3e76()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_fd572c530bce46769b088ff54861c63a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd572c530bce46769b088ff54861c63a()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_8f14c232c690457dbfcef9adc0511ecd : HardwiredMemberDescriptor
      {
        internal FLDV_8f14c232c690457dbfcef9adc0511ecd()
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

      private sealed class FLDV_4eb8a51a42b649de936ed1ca07fe2b87 : HardwiredMemberDescriptor
      {
        internal FLDV_4eb8a51a42b649de936ed1ca07fe2b87()
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

      private sealed class FLDV_65e1906affa94ce3a53917fdf7421f7a : HardwiredMemberDescriptor
      {
        internal FLDV_65e1906affa94ce3a53917fdf7421f7a()
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

      private sealed class FLDV_0dc268ae785942ad9f42a8697f4bf9b3 : HardwiredMemberDescriptor
      {
        internal FLDV_0dc268ae785942ad9f42a8697f4bf9b3()
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

      private sealed class FLDV_72eeb2075d954d38a5544508c76d1815 : HardwiredMemberDescriptor
      {
        internal FLDV_72eeb2075d954d38a5544508c76d1815()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_c750d876b9b940fb8f7a9aa4f807b9ce : HardwiredMemberDescriptor
      {
        internal FLDV_c750d876b9b940fb8f7a9aa4f807b9ce()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_aaa46417066a4abf8a5312d6c004135d : HardwiredMemberDescriptor
      {
        internal FLDV_aaa46417066a4abf8a5312d6c004135d()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_a88e49405eaf4e48b13cf68317bd2204 : HardwiredMemberDescriptor
      {
        internal FLDV_a88e49405eaf4e48b13cf68317bd2204()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_d2f3fd238e184319954c4b3c564088d4 : DynValueMemberDescriptor
      {
        internal DVAL_d2f3fd238e184319954c4b3c564088d4()
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

      private sealed class DVAL_24a8b9bb009240ad89f8b6895f5158fb : DynValueMemberDescriptor
      {
        internal DVAL_24a8b9bb009240ad89f8b6895f5158fb()
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

    private sealed class TYPE_504e3b0461354e8e9cee00c1756887fe : HardwiredUserDataDescriptor
    {
      internal TYPE_504e3b0461354e8e9cee00c1756887fe()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_504e3b0461354e8e9cee00c1756887fe.MTHD_d56dfddb550f4c9d808f94578efb28f5()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_504e3b0461354e8e9cee00c1756887fe.MTHD_1a3f131156c043e4af75114f381c7552()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_504e3b0461354e8e9cee00c1756887fe.MTHD_a83fee86ee5248928823a1bb6e79175d(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_504e3b0461354e8e9cee00c1756887fe.MTHD_d2504470980346f5ac3fac0d3bf32a72()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_504e3b0461354e8e9cee00c1756887fe.MTHD_52c14a5604134f2fa6f5fe5001ff7bcf(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_504e3b0461354e8e9cee00c1756887fe.MTHD_fe54403208db43a6889224218a67641f()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_504e3b0461354e8e9cee00c1756887fe.MTHD_8c11b0613f104fca883244142c70fad2()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_504e3b0461354e8e9cee00c1756887fe.MTHD_a6546228902043e89a018ec79881ff3e()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_504e3b0461354e8e9cee00c1756887fe.MTHD_41deef194fb04909b527014a42366247()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_504e3b0461354e8e9cee00c1756887fe.MTHD_52f3635bbf91427f83965938c59d1234()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_504e3b0461354e8e9cee00c1756887fe.FLDV_2f72e35bc6ea4311afa468e5166e0a58());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_504e3b0461354e8e9cee00c1756887fe.FLDV_aee1e888064942b785044b57981e2457());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_504e3b0461354e8e9cee00c1756887fe.FLDV_870923c2e1e9483496e4a1d93328ab7a());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_504e3b0461354e8e9cee00c1756887fe.FLDV_69d63611d9c949a5a520b7e9deb87d6d());
      }

      private sealed class MTHD_d56dfddb550f4c9d808f94578efb28f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d56dfddb550f4c9d808f94578efb28f5()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_1a3f131156c043e4af75114f381c7552 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a3f131156c043e4af75114f381c7552()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_a83fee86ee5248928823a1bb6e79175d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a83fee86ee5248928823a1bb6e79175d()
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

      private sealed class MTHD_d2504470980346f5ac3fac0d3bf32a72 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d2504470980346f5ac3fac0d3bf32a72()
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

      private sealed class MTHD_52c14a5604134f2fa6f5fe5001ff7bcf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52c14a5604134f2fa6f5fe5001ff7bcf()
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

      private sealed class MTHD_fe54403208db43a6889224218a67641f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fe54403208db43a6889224218a67641f()
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

      private sealed class MTHD_8c11b0613f104fca883244142c70fad2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c11b0613f104fca883244142c70fad2()
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

      private sealed class MTHD_a6546228902043e89a018ec79881ff3e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6546228902043e89a018ec79881ff3e()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_41deef194fb04909b527014a42366247 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41deef194fb04909b527014a42366247()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_52f3635bbf91427f83965938c59d1234 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52f3635bbf91427f83965938c59d1234()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_2f72e35bc6ea4311afa468e5166e0a58 : HardwiredMemberDescriptor
      {
        internal FLDV_2f72e35bc6ea4311afa468e5166e0a58()
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

      private sealed class FLDV_aee1e888064942b785044b57981e2457 : HardwiredMemberDescriptor
      {
        internal FLDV_aee1e888064942b785044b57981e2457()
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

      private sealed class FLDV_870923c2e1e9483496e4a1d93328ab7a : HardwiredMemberDescriptor
      {
        internal FLDV_870923c2e1e9483496e4a1d93328ab7a()
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

      private sealed class FLDV_69d63611d9c949a5a520b7e9deb87d6d : HardwiredMemberDescriptor
      {
        internal FLDV_69d63611d9c949a5a520b7e9deb87d6d()
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

    private sealed class TYPE_6e79e883aeb0445db25bea64c9fbba3f : HardwiredUserDataDescriptor
    {
      internal TYPE_6e79e883aeb0445db25bea64c9fbba3f()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e79e883aeb0445db25bea64c9fbba3f.MTHD_997ce861a1124557ac1b9c104a789b3a()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e79e883aeb0445db25bea64c9fbba3f.MTHD_fbb14007bceb48ea8eb3bd610cbe7ac0()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e79e883aeb0445db25bea64c9fbba3f.MTHD_64cbd4f399ae4b239c7997dab196ec10()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e79e883aeb0445db25bea64c9fbba3f.MTHD_20f07287d69446d99b17654b24be8822()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6e79e883aeb0445db25bea64c9fbba3f.MTHD_1d9a8788e990446ea9610cdabd3dd3e4()
        }));
      }

      private sealed class MTHD_997ce861a1124557ac1b9c104a789b3a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_997ce861a1124557ac1b9c104a789b3a()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_fbb14007bceb48ea8eb3bd610cbe7ac0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fbb14007bceb48ea8eb3bd610cbe7ac0()
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

      private sealed class MTHD_64cbd4f399ae4b239c7997dab196ec10 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_64cbd4f399ae4b239c7997dab196ec10()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_20f07287d69446d99b17654b24be8822 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_20f07287d69446d99b17654b24be8822()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_1d9a8788e990446ea9610cdabd3dd3e4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d9a8788e990446ea9610cdabd3dd3e4()
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
