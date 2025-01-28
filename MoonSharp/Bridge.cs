
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
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_6fe3a78eb6ac4057b5cccaa3d1e2d98c());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_5e1f9db09fc84d23ad4203dacc9ad67d());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_dc7b79a5fee0482caa29d01a6ce9673c());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_52f48af89e574b7aaf7c76895d129949());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_52843e23609749608e698e80341a2330());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_3ebb49b7400445a581ffdbfd4443bb8e());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_3a58d73029104c93bfd3531d22b3fad5());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_bc58f12d10f141f4bc44c9ec0a51c2d2());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_328613fd367846d6979d696ca54e609a());
    }

    private sealed class TYPE_f5815bbbf7ae4155b552544fa26bf4d1 : HardwiredUserDataDescriptor
    {
      internal TYPE_f5815bbbf7ae4155b552544fa26bf4d1()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_4e410a521dab4854882a7ead852945b3()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_760c9b59df7f41f4885998bef0535ead()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_7cbfaca617994781af9e86181b64df16()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_f3529df422554987bd2a6eeb3fd8eaf5()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_892e624a2eb24dadaa64fb9e6537439d()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_68511154a5484db280d1fc37696f48c4()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_73390ead9a2645d393d3882f1f4c22e1()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_38a14778d09c4b20bdf7bafae8edb605()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_eb4d10423e174a1db092431619c14bfe()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_fef57ba5a369487193ae208d1eb7bbe2()
        }));
        this.AddMember("hideInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("hideInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_136b1a9ece6143eeb43ba9ec70bc5f9a()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_7399a79d7a484e3bb2488ff794590c91()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_ec7b91b96a4d40058c7aa36daf4acce7()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_3f4889217bb34f698dfbd752c6428adb()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_3ef41f1dcd0049d18f59c2741b860755()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_0ff08589b37842dcbd69c40532e6d711()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_ffe377fb99fe40a4a65d52920fc4fb61()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_ba4c74f4d88748beba5d7e5b86b5feb8()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_52029534e40443968d25fc25d4e0c6e0()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_0b7e8ea9dda74febb1e7615e4b3113d4()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_f197365bf7904c1b8a94977e78a98708()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_7fe81092583c44cdab22da704e0e5378()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_135bdab8c73f4568ac3c0ef39ccf5c91()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_b46a2447cf7e4db7a329d9fa22d98574()
        }));
        this.AddMember("get_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_988e3b31d4924fc9866a545476128121()
        }));
        this.AddMember("set_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_599b5710fe0240c5a6cfd114a387de95()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_65132d24b45247ecb45b3916a34d4c87()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_50513049984e4d33874125fb6eef9ab9()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_c32390a1428a41fbbecad0260f801e1f()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_b8161f75138e477dbda39fb0d7791785()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_95ce0418470f41b6bac539a868f7b922()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_8632f207696843b1bf7868c9bc369581()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_8739f4c8a9c646e7b5d162d0376e77ae()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_5c5049ca665a4435bae76fd1ccd76b84()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_96563883e28d43d4bfc37f390b50c8e3()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_4b4c7b9fc3ba4c57a8eef29868081a4a()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_f5ad549c737045ee96d6c58a030c4e92()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_abe3830f878542c0aeeadd2f873af7b6()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_c0431473c8cb47698bb18d7ce9f877ca()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_5debcd378c5b4066a0e98feba80bffbb()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_99a6c4024cc64c9790b4788b24ff78e5()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_4ae3b8a02d5940ff8838b6c8a3411184()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_6349b439ab694c8b8d0aae958cf8c0ff()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_51d3ce3cf43142a99c265eef9bf85f30()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_1323a631ed88488ba351a0c06c75ccd9()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_3f466ce355404851ae00e449d396eca0()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_5e2b6ccc36d040378bf9785df87f99c5()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_1930dba5051446279569d55777fae852()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_a710fa24b20a4cb08dbcd53a55696733()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_95d9f894996b402c90e128e480c1f29c()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_f135dc000b6643eab600f611e2750961()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_0f6ec70d4cd142f8ac52e65e20e63d58()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_45da03d728454192a5f839e684268909()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_598a33322bf844f8bfb2713b81350b99()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_85d5595ab15e403bbd1954bf09f13b4e()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_18512c2ccadd47b18b678637fff45c9f()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_b542703e36894a1abcb374ea3af0ccda()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_03b674e805fb4ddb84dd815070c0ac6f()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_b9933f57929c4372a8e8fd531243699d()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_3cc5b7b870354382975229d3e221dcbc()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_fae0c79f31394b78bc4e6ed9e3873576()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_44881f398d764fabaa5cd3f9d12b43fb()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_e8d84e549b73480ab4e67977dda18e02()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_8be4b95f43f74525bf431258e3a1da26()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_42b056e0d66b40359c8e4833515270a8()
        }));
        this.AddMember("Dispose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Dispose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_1d153e9a73e84e2d95c75f1e98b4630f()
        }));
        this.AddMember("drawImage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawImage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_ec602fe700fe49f1996cfc5f01ade079()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_60d9584a10504c4499f2b9e94d107164()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_d0eb0c1a6fc54ade94243e5de4879b2e()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_ebc8707080404aedb1a3b228d8e80d72()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_1d48c89dc24d4ccaa55e3770f63da478()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_0633777845084197bc177a86836a2c36()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_64a52425c1be4dd9ad7390534a2bb906()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_c9f6f4873f784579b8ac38004fe62f2c()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_0724f22d917d40889583655129127b37()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_36fb37ac8ba844a195cd2497cabd06bb()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_96715b27212545eea1f6880376ae097a()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_1a8ed8a5002c4759b5b406dc66589587()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_9d069dd4a0534d16b5208e6def09de11()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_33c0efb8aa51429db8a16a38a270fa9a()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_5f80340c81f8471894afebbc0507a898()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_2954cba913aa4ac38c448e1092bde4c2()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_8ae82c2de15042238f23fcffb0b8f626()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_b174f87d336e4bd4b6a6d5989a701a6a()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_8e8a25d744d043309b5f1eee27340a24()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_751a9d0223074012b48cc4905a589c9f()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_29e285836f5d435694aa73b783c625d4()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_433ede1437a840d0932d3b72837d88d3()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_debb593106554515943f2350c90347b2()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_d05bde20c06645f3b1229897ae56ea4b()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_a152ab2f9d894d839c2fdeef34d6d2ef()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_0b54c610eb7d43dd97379f04d215ba9e()
        }));
        this.AddMember("cameraFollow", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("cameraFollow", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_f3ecdceb4763473b8125fe40b37461fc()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_c14e44e69095408387b766b1968e5378()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_0631d3d2b61c4f8fa44d2a3ead1eefcd()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_bd8913a2f3d1474897eee07342f3a81a()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_b97c15436a6b491fbe001aef7b318da9()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_27f872aace66462c895a92c763c0c114()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_0d7cc70a686e462c8baac8840b7884ae(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_a5350c33940b4e069fc7f1459816d82b()
        }));
        this.AddMember("getKeyBinds", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getKeyBinds", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_55e018ba34164dc79a9b8b47086a74c6()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_ba5b09197a424f91bbfd86dd5b0dd04d()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_3ddaa847cddd41269a39ec0b2051bf8c()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_dbf4ab59ef354c6bab905a9a9d6eb91c()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.MTHD_5c3b4594d8f84dcd96fbcacc3bea7db2()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_5de39713a6b2428aadf8fadce7f2323d());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_86397868de3b45b1bd2a33439b6cdb49());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_c48e41ea4a604d5b8a3bac7c645f990b());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_418bf5f61c5d4f73a470d6cb6b4c3e98());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_5d636407e6ba4d0881527955febf4006());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_541edcbfa4ad4a048798c47c549162cd());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_daf8646058084c2c8020710502118e01());
        this.AddMember("allowMinionMovement", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_09fbde40b76141a5a9a13d698f6f108e());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_d1e1a2ff5c544832a63d70d440f520d2());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_373c4ce75e42477981d5761901888227());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_74e470c0ef5245d7b09f22acb3816d56());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_2edd29daeac445bd87b18edf6b3a6410());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_79aa2d6335354759b284c7cd7161a8cb());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_57c3d885d29f46cb959c11464335c9a4());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_554de3ff3faa48fa9df2b2aa1d72ecd3());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_b1d40784466c4aa39189bd8f4b8586bc());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_be8da0041f4d4709b9b405a79199a9f3());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_32edf6af75d24e41a7ae1763ce743c80());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_5559b15d562744a5b0bd326af5a1170c());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_fcc4356fa9674b59b81615981a6f2108());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_1c7add0fa03e4a7b9f764bea8a1bda3a());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_b71a05c416cb45538e3804c99b535c33());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_6981c26d3b164da3a9158616b4221318());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_26581622a8b5476abfefe16cfa413500());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_5892ba7e4de945948c51ef5c87df7fb2());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_d0971045c4d84e88b7360a1abfa659f5());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_475ec4760b4140d4beebfb57cbc1c8ae());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_8cf71944d59d4a649e64f8dec4a42575());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_b48fd7515b354fa4a4e5fada42ea3df8());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_717840c3ae764c77848b4057473c7549());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_b532a00b85084ecda495c0ea53d90adc());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_26b9dbabd4cd46ff8d59b3ea86420889());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_f5815bbbf7ae4155b552544fa26bf4d1.PROP_5a5d07fcbc3e41f0a8dfa90e0a1451b9());
      }

      private sealed class MTHD_4e410a521dab4854882a7ead852945b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e410a521dab4854882a7ead852945b3()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_760c9b59df7f41f4885998bef0535ead : HardwiredMethodMemberDescriptor
      {
        internal MTHD_760c9b59df7f41f4885998bef0535ead()
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

      private sealed class MTHD_7cbfaca617994781af9e86181b64df16 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7cbfaca617994781af9e86181b64df16()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_f3529df422554987bd2a6eeb3fd8eaf5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f3529df422554987bd2a6eeb3fd8eaf5()
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

      private sealed class MTHD_892e624a2eb24dadaa64fb9e6537439d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_892e624a2eb24dadaa64fb9e6537439d()
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

      private sealed class MTHD_68511154a5484db280d1fc37696f48c4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_68511154a5484db280d1fc37696f48c4()
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

      private sealed class MTHD_73390ead9a2645d393d3882f1f4c22e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_73390ead9a2645d393d3882f1f4c22e1()
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

      private sealed class MTHD_38a14778d09c4b20bdf7bafae8edb605 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_38a14778d09c4b20bdf7bafae8edb605()
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

      private sealed class MTHD_eb4d10423e174a1db092431619c14bfe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb4d10423e174a1db092431619c14bfe()
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

      private sealed class MTHD_fef57ba5a369487193ae208d1eb7bbe2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fef57ba5a369487193ae208d1eb7bbe2()
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

      private sealed class MTHD_136b1a9ece6143eeb43ba9ec70bc5f9a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_136b1a9ece6143eeb43ba9ec70bc5f9a()
        {
          this.Initialize("hideInfo", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).hideInfo();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_7399a79d7a484e3bb2488ff794590c91 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7399a79d7a484e3bb2488ff794590c91()
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

      private sealed class MTHD_ec7b91b96a4d40058c7aa36daf4acce7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec7b91b96a4d40058c7aa36daf4acce7()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_3f4889217bb34f698dfbd752c6428adb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f4889217bb34f698dfbd752c6428adb()
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

      private sealed class MTHD_3ef41f1dcd0049d18f59c2741b860755 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3ef41f1dcd0049d18f59c2741b860755()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_0ff08589b37842dcbd69c40532e6d711 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ff08589b37842dcbd69c40532e6d711()
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

      private sealed class MTHD_ffe377fb99fe40a4a65d52920fc4fb61 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ffe377fb99fe40a4a65d52920fc4fb61()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_ba4c74f4d88748beba5d7e5b86b5feb8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba4c74f4d88748beba5d7e5b86b5feb8()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_52029534e40443968d25fc25d4e0c6e0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52029534e40443968d25fc25d4e0c6e0()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_0b7e8ea9dda74febb1e7615e4b3113d4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b7e8ea9dda74febb1e7615e4b3113d4()
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

      private sealed class MTHD_f197365bf7904c1b8a94977e78a98708 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f197365bf7904c1b8a94977e78a98708()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_7fe81092583c44cdab22da704e0e5378 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7fe81092583c44cdab22da704e0e5378()
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

      private sealed class MTHD_135bdab8c73f4568ac3c0ef39ccf5c91 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_135bdab8c73f4568ac3c0ef39ccf5c91()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_b46a2447cf7e4db7a329d9fa22d98574 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b46a2447cf7e4db7a329d9fa22d98574()
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

      private sealed class MTHD_988e3b31d4924fc9866a545476128121 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_988e3b31d4924fc9866a545476128121()
        {
          this.Initialize("get_allowMinionMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMinionMovement;
        }
      }

      private sealed class MTHD_599b5710fe0240c5a6cfd114a387de95 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_599b5710fe0240c5a6cfd114a387de95()
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

      private sealed class MTHD_65132d24b45247ecb45b3916a34d4c87 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65132d24b45247ecb45b3916a34d4c87()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_50513049984e4d33874125fb6eef9ab9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_50513049984e4d33874125fb6eef9ab9()
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

      private sealed class MTHD_c32390a1428a41fbbecad0260f801e1f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c32390a1428a41fbbecad0260f801e1f()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_b8161f75138e477dbda39fb0d7791785 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b8161f75138e477dbda39fb0d7791785()
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

      private sealed class MTHD_95ce0418470f41b6bac539a868f7b922 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95ce0418470f41b6bac539a868f7b922()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_8632f207696843b1bf7868c9bc369581 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8632f207696843b1bf7868c9bc369581()
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

      private sealed class MTHD_8739f4c8a9c646e7b5d162d0376e77ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8739f4c8a9c646e7b5d162d0376e77ae()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_5c5049ca665a4435bae76fd1ccd76b84 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c5049ca665a4435bae76fd1ccd76b84()
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

      private sealed class MTHD_96563883e28d43d4bfc37f390b50c8e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_96563883e28d43d4bfc37f390b50c8e3()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_4b4c7b9fc3ba4c57a8eef29868081a4a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b4c7b9fc3ba4c57a8eef29868081a4a()
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

      private sealed class MTHD_f5ad549c737045ee96d6c58a030c4e92 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f5ad549c737045ee96d6c58a030c4e92()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_abe3830f878542c0aeeadd2f873af7b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_abe3830f878542c0aeeadd2f873af7b6()
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

      private sealed class MTHD_c0431473c8cb47698bb18d7ce9f877ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c0431473c8cb47698bb18d7ce9f877ca()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_5debcd378c5b4066a0e98feba80bffbb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5debcd378c5b4066a0e98feba80bffbb()
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

      private sealed class MTHD_99a6c4024cc64c9790b4788b24ff78e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99a6c4024cc64c9790b4788b24ff78e5()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_4ae3b8a02d5940ff8838b6c8a3411184 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ae3b8a02d5940ff8838b6c8a3411184()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_6349b439ab694c8b8d0aae958cf8c0ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6349b439ab694c8b8d0aae958cf8c0ff()
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

      private sealed class MTHD_51d3ce3cf43142a99c265eef9bf85f30 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_51d3ce3cf43142a99c265eef9bf85f30()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_1323a631ed88488ba351a0c06c75ccd9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1323a631ed88488ba351a0c06c75ccd9()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_3f466ce355404851ae00e449d396eca0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f466ce355404851ae00e449d396eca0()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_5e2b6ccc36d040378bf9785df87f99c5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e2b6ccc36d040378bf9785df87f99c5()
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

      private sealed class MTHD_1930dba5051446279569d55777fae852 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1930dba5051446279569d55777fae852()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_a710fa24b20a4cb08dbcd53a55696733 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a710fa24b20a4cb08dbcd53a55696733()
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

      private sealed class MTHD_95d9f894996b402c90e128e480c1f29c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95d9f894996b402c90e128e480c1f29c()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_f135dc000b6643eab600f611e2750961 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f135dc000b6643eab600f611e2750961()
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

      private sealed class MTHD_0f6ec70d4cd142f8ac52e65e20e63d58 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f6ec70d4cd142f8ac52e65e20e63d58()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_45da03d728454192a5f839e684268909 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_45da03d728454192a5f839e684268909()
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

      private sealed class MTHD_598a33322bf844f8bfb2713b81350b99 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_598a33322bf844f8bfb2713b81350b99()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_85d5595ab15e403bbd1954bf09f13b4e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85d5595ab15e403bbd1954bf09f13b4e()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_18512c2ccadd47b18b678637fff45c9f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_18512c2ccadd47b18b678637fff45c9f()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_b542703e36894a1abcb374ea3af0ccda : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b542703e36894a1abcb374ea3af0ccda()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_03b674e805fb4ddb84dd815070c0ac6f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_03b674e805fb4ddb84dd815070c0ac6f()
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

      private sealed class MTHD_b9933f57929c4372a8e8fd531243699d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b9933f57929c4372a8e8fd531243699d()
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

      private sealed class MTHD_3cc5b7b870354382975229d3e221dcbc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3cc5b7b870354382975229d3e221dcbc()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_fae0c79f31394b78bc4e6ed9e3873576 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fae0c79f31394b78bc4e6ed9e3873576()
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

      private sealed class MTHD_44881f398d764fabaa5cd3f9d12b43fb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_44881f398d764fabaa5cd3f9d12b43fb()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_e8d84e549b73480ab4e67977dda18e02 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e8d84e549b73480ab4e67977dda18e02()
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

      private sealed class MTHD_8be4b95f43f74525bf431258e3a1da26 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8be4b95f43f74525bf431258e3a1da26()
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

      private sealed class MTHD_42b056e0d66b40359c8e4833515270a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42b056e0d66b40359c8e4833515270a8()
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

      private sealed class MTHD_1d153e9a73e84e2d95c75f1e98b4630f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d153e9a73e84e2d95c75f1e98b4630f()
        {
          this.Initialize("Dispose", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ContainerGame.Dispose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ec602fe700fe49f1996cfc5f01ade079 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec602fe700fe49f1996cfc5f01ade079()
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

      private sealed class MTHD_60d9584a10504c4499f2b9e94d107164 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60d9584a10504c4499f2b9e94d107164()
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

      private sealed class MTHD_d0eb0c1a6fc54ade94243e5de4879b2e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0eb0c1a6fc54ade94243e5de4879b2e()
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

      private sealed class MTHD_ebc8707080404aedb1a3b228d8e80d72 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ebc8707080404aedb1a3b228d8e80d72()
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

      private sealed class MTHD_1d48c89dc24d4ccaa55e3770f63da478 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d48c89dc24d4ccaa55e3770f63da478()
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

      private sealed class MTHD_0633777845084197bc177a86836a2c36 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0633777845084197bc177a86836a2c36()
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

      private sealed class MTHD_64a52425c1be4dd9ad7390534a2bb906 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_64a52425c1be4dd9ad7390534a2bb906()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c9f6f4873f784579b8ac38004fe62f2c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c9f6f4873f784579b8ac38004fe62f2c()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_0724f22d917d40889583655129127b37 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0724f22d917d40889583655129127b37()
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

      private sealed class MTHD_36fb37ac8ba844a195cd2497cabd06bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_36fb37ac8ba844a195cd2497cabd06bb()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_96715b27212545eea1f6880376ae097a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_96715b27212545eea1f6880376ae097a()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_1a8ed8a5002c4759b5b406dc66589587 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a8ed8a5002c4759b5b406dc66589587()
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

      private sealed class MTHD_9d069dd4a0534d16b5208e6def09de11 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d069dd4a0534d16b5208e6def09de11()
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

      private sealed class MTHD_33c0efb8aa51429db8a16a38a270fa9a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_33c0efb8aa51429db8a16a38a270fa9a()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_5f80340c81f8471894afebbc0507a898 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5f80340c81f8471894afebbc0507a898()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_2954cba913aa4ac38c448e1092bde4c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2954cba913aa4ac38c448e1092bde4c2()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_8ae82c2de15042238f23fcffb0b8f626 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ae82c2de15042238f23fcffb0b8f626()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b174f87d336e4bd4b6a6d5989a701a6a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b174f87d336e4bd4b6a6d5989a701a6a()
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

      private sealed class MTHD_8e8a25d744d043309b5f1eee27340a24 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e8a25d744d043309b5f1eee27340a24()
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

      private sealed class MTHD_751a9d0223074012b48cc4905a589c9f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_751a9d0223074012b48cc4905a589c9f()
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

      private sealed class MTHD_29e285836f5d435694aa73b783c625d4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_29e285836f5d435694aa73b783c625d4()
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

      private sealed class MTHD_433ede1437a840d0932d3b72837d88d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_433ede1437a840d0932d3b72837d88d3()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_debb593106554515943f2350c90347b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_debb593106554515943f2350c90347b2()
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

      private sealed class MTHD_d05bde20c06645f3b1229897ae56ea4b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d05bde20c06645f3b1229897ae56ea4b()
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

      private sealed class MTHD_a152ab2f9d894d839c2fdeef34d6d2ef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a152ab2f9d894d839c2fdeef34d6d2ef()
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

      private sealed class MTHD_0b54c610eb7d43dd97379f04d215ba9e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b54c610eb7d43dd97379f04d215ba9e()
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

      private sealed class MTHD_f3ecdceb4763473b8125fe40b37461fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f3ecdceb4763473b8125fe40b37461fc()
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

      private sealed class MTHD_c14e44e69095408387b766b1968e5378 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c14e44e69095408387b766b1968e5378()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_0631d3d2b61c4f8fa44d2a3ead1eefcd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0631d3d2b61c4f8fa44d2a3ead1eefcd()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_bd8913a2f3d1474897eee07342f3a81a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd8913a2f3d1474897eee07342f3a81a()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_b97c15436a6b491fbe001aef7b318da9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b97c15436a6b491fbe001aef7b318da9()
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

      private sealed class MTHD_27f872aace66462c895a92c763c0c114 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_27f872aace66462c895a92c763c0c114()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_0d7cc70a686e462c8baac8840b7884ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d7cc70a686e462c8baac8840b7884ae()
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

      private sealed class MTHD_a5350c33940b4e069fc7f1459816d82b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a5350c33940b4e069fc7f1459816d82b()
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

      private sealed class MTHD_55e018ba34164dc79a9b8b47086a74c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_55e018ba34164dc79a9b8b47086a74c6()
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

      private sealed class MTHD_ba5b09197a424f91bbfd86dd5b0dd04d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba5b09197a424f91bbfd86dd5b0dd04d()
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

      private sealed class MTHD_3ddaa847cddd41269a39ec0b2051bf8c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3ddaa847cddd41269a39ec0b2051bf8c()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_dbf4ab59ef354c6bab905a9a9d6eb91c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dbf4ab59ef354c6bab905a9a9d6eb91c()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_5c3b4594d8f84dcd96fbcacc3bea7db2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c3b4594d8f84dcd96fbcacc3bea7db2()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_5de39713a6b2428aadf8fadce7f2323d : HardwiredMemberDescriptor
      {
        internal PROP_5de39713a6b2428aadf8fadce7f2323d()
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

      private sealed class PROP_86397868de3b45b1bd2a33439b6cdb49 : HardwiredMemberDescriptor
      {
        internal PROP_86397868de3b45b1bd2a33439b6cdb49()
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

      private sealed class PROP_c48e41ea4a604d5b8a3bac7c645f990b : HardwiredMemberDescriptor
      {
        internal PROP_c48e41ea4a604d5b8a3bac7c645f990b()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_418bf5f61c5d4f73a470d6cb6b4c3e98 : HardwiredMemberDescriptor
      {
        internal PROP_418bf5f61c5d4f73a470d6cb6b4c3e98()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_5d636407e6ba4d0881527955febf4006 : HardwiredMemberDescriptor
      {
        internal PROP_5d636407e6ba4d0881527955febf4006()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_541edcbfa4ad4a048798c47c549162cd : HardwiredMemberDescriptor
      {
        internal PROP_541edcbfa4ad4a048798c47c549162cd()
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

      private sealed class PROP_daf8646058084c2c8020710502118e01 : HardwiredMemberDescriptor
      {
        internal PROP_daf8646058084c2c8020710502118e01()
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

      private sealed class PROP_09fbde40b76141a5a9a13d698f6f108e : HardwiredMemberDescriptor
      {
        internal PROP_09fbde40b76141a5a9a13d698f6f108e()
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

      private sealed class PROP_d1e1a2ff5c544832a63d70d440f520d2 : HardwiredMemberDescriptor
      {
        internal PROP_d1e1a2ff5c544832a63d70d440f520d2()
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

      private sealed class PROP_373c4ce75e42477981d5761901888227 : HardwiredMemberDescriptor
      {
        internal PROP_373c4ce75e42477981d5761901888227()
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

      private sealed class PROP_74e470c0ef5245d7b09f22acb3816d56 : HardwiredMemberDescriptor
      {
        internal PROP_74e470c0ef5245d7b09f22acb3816d56()
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

      private sealed class PROP_2edd29daeac445bd87b18edf6b3a6410 : HardwiredMemberDescriptor
      {
        internal PROP_2edd29daeac445bd87b18edf6b3a6410()
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

      private sealed class PROP_79aa2d6335354759b284c7cd7161a8cb : HardwiredMemberDescriptor
      {
        internal PROP_79aa2d6335354759b284c7cd7161a8cb()
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

      private sealed class PROP_57c3d885d29f46cb959c11464335c9a4 : HardwiredMemberDescriptor
      {
        internal PROP_57c3d885d29f46cb959c11464335c9a4()
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

      private sealed class PROP_554de3ff3faa48fa9df2b2aa1d72ecd3 : HardwiredMemberDescriptor
      {
        internal PROP_554de3ff3faa48fa9df2b2aa1d72ecd3()
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

      private sealed class PROP_b1d40784466c4aa39189bd8f4b8586bc : HardwiredMemberDescriptor
      {
        internal PROP_b1d40784466c4aa39189bd8f4b8586bc()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_be8da0041f4d4709b9b405a79199a9f3 : HardwiredMemberDescriptor
      {
        internal PROP_be8da0041f4d4709b9b405a79199a9f3()
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

      private sealed class PROP_32edf6af75d24e41a7ae1763ce743c80 : HardwiredMemberDescriptor
      {
        internal PROP_32edf6af75d24e41a7ae1763ce743c80()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_5559b15d562744a5b0bd326af5a1170c : HardwiredMemberDescriptor
      {
        internal PROP_5559b15d562744a5b0bd326af5a1170c()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_fcc4356fa9674b59b81615981a6f2108 : HardwiredMemberDescriptor
      {
        internal PROP_fcc4356fa9674b59b81615981a6f2108()
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

      private sealed class PROP_1c7add0fa03e4a7b9f764bea8a1bda3a : HardwiredMemberDescriptor
      {
        internal PROP_1c7add0fa03e4a7b9f764bea8a1bda3a()
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

      private sealed class PROP_b71a05c416cb45538e3804c99b535c33 : HardwiredMemberDescriptor
      {
        internal PROP_b71a05c416cb45538e3804c99b535c33()
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

      private sealed class PROP_6981c26d3b164da3a9158616b4221318 : HardwiredMemberDescriptor
      {
        internal PROP_6981c26d3b164da3a9158616b4221318()
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

      private sealed class PROP_26581622a8b5476abfefe16cfa413500 : HardwiredMemberDescriptor
      {
        internal PROP_26581622a8b5476abfefe16cfa413500()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_5892ba7e4de945948c51ef5c87df7fb2 : HardwiredMemberDescriptor
      {
        internal PROP_5892ba7e4de945948c51ef5c87df7fb2()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_d0971045c4d84e88b7360a1abfa659f5 : HardwiredMemberDescriptor
      {
        internal PROP_d0971045c4d84e88b7360a1abfa659f5()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_475ec4760b4140d4beebfb57cbc1c8ae : HardwiredMemberDescriptor
      {
        internal PROP_475ec4760b4140d4beebfb57cbc1c8ae()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_8cf71944d59d4a649e64f8dec4a42575 : HardwiredMemberDescriptor
      {
        internal PROP_8cf71944d59d4a649e64f8dec4a42575()
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

      private sealed class PROP_b48fd7515b354fa4a4e5fada42ea3df8 : HardwiredMemberDescriptor
      {
        internal PROP_b48fd7515b354fa4a4e5fada42ea3df8()
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

      private sealed class PROP_717840c3ae764c77848b4057473c7549 : HardwiredMemberDescriptor
      {
        internal PROP_717840c3ae764c77848b4057473c7549()
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

      private sealed class PROP_b532a00b85084ecda495c0ea53d90adc : HardwiredMemberDescriptor
      {
        internal PROP_b532a00b85084ecda495c0ea53d90adc()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_26b9dbabd4cd46ff8d59b3ea86420889 : HardwiredMemberDescriptor
      {
        internal PROP_26b9dbabd4cd46ff8d59b3ea86420889()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_5a5d07fcbc3e41f0a8dfa90e0a1451b9 : HardwiredMemberDescriptor
      {
        internal PROP_5a5d07fcbc3e41f0a8dfa90e0a1451b9()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_6fe3a78eb6ac4057b5cccaa3d1e2d98c : HardwiredUserDataDescriptor
    {
      internal TYPE_6fe3a78eb6ac4057b5cccaa3d1e2d98c()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6fe3a78eb6ac4057b5cccaa3d1e2d98c.MTHD_c055c787a9fa4b37bddeefd34c125a74()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6fe3a78eb6ac4057b5cccaa3d1e2d98c.MTHD_ac1d68e3920b46a1945e0c3f288bfbe0()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6fe3a78eb6ac4057b5cccaa3d1e2d98c.MTHD_69115204eeb0437cb7fe71a1d66532d9()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6fe3a78eb6ac4057b5cccaa3d1e2d98c.MTHD_afa34e5bff294f62a1afb9139f9ae4aa()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6fe3a78eb6ac4057b5cccaa3d1e2d98c.MTHD_07b6644f044142878b8e706be2acdf16()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6fe3a78eb6ac4057b5cccaa3d1e2d98c.MTHD_5e0e6e6955154b00a6b4b5d61e87cd2a()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6fe3a78eb6ac4057b5cccaa3d1e2d98c.MTHD_0d4825d1c5be4430a83957e909149918()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6fe3a78eb6ac4057b5cccaa3d1e2d98c.MTHD_22d155407f2c438e834b2b4f1b854900()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6fe3a78eb6ac4057b5cccaa3d1e2d98c.MTHD_1a598d3355d44e1cbbe36f2e27ed12f4()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6fe3a78eb6ac4057b5cccaa3d1e2d98c.MTHD_50afc5a042a945208b022454a2c103d2()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6fe3a78eb6ac4057b5cccaa3d1e2d98c.MTHD_bd6a43e56705491e824d322335889496()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6fe3a78eb6ac4057b5cccaa3d1e2d98c.MTHD_dae4a81b1b6146429c2008ed02367639()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_6fe3a78eb6ac4057b5cccaa3d1e2d98c.PROP_21d3eb5ba91c4b259db04e9fa435de5b());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_6fe3a78eb6ac4057b5cccaa3d1e2d98c.PROP_e1b95d87fe844651be9b81f8c3cb5cbe());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_6fe3a78eb6ac4057b5cccaa3d1e2d98c.PROP_b37f4e0bb9de4474b4ed2a68083265f4());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_6fe3a78eb6ac4057b5cccaa3d1e2d98c.PROP_cc7071d0b32b47c2b361018ee42c910f());
      }

      private sealed class MTHD_c055c787a9fa4b37bddeefd34c125a74 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c055c787a9fa4b37bddeefd34c125a74()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_ac1d68e3920b46a1945e0c3f288bfbe0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac1d68e3920b46a1945e0c3f288bfbe0()
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

      private sealed class MTHD_69115204eeb0437cb7fe71a1d66532d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69115204eeb0437cb7fe71a1d66532d9()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_afa34e5bff294f62a1afb9139f9ae4aa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_afa34e5bff294f62a1afb9139f9ae4aa()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_07b6644f044142878b8e706be2acdf16 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_07b6644f044142878b8e706be2acdf16()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_5e0e6e6955154b00a6b4b5d61e87cd2a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e0e6e6955154b00a6b4b5d61e87cd2a()
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

      private sealed class MTHD_0d4825d1c5be4430a83957e909149918 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d4825d1c5be4430a83957e909149918()
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

      private sealed class MTHD_22d155407f2c438e834b2b4f1b854900 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22d155407f2c438e834b2b4f1b854900()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_1a598d3355d44e1cbbe36f2e27ed12f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a598d3355d44e1cbbe36f2e27ed12f4()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_50afc5a042a945208b022454a2c103d2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_50afc5a042a945208b022454a2c103d2()
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

      private sealed class MTHD_bd6a43e56705491e824d322335889496 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd6a43e56705491e824d322335889496()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_dae4a81b1b6146429c2008ed02367639 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dae4a81b1b6146429c2008ed02367639()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_21d3eb5ba91c4b259db04e9fa435de5b : HardwiredMemberDescriptor
      {
        internal PROP_21d3eb5ba91c4b259db04e9fa435de5b()
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

      private sealed class PROP_e1b95d87fe844651be9b81f8c3cb5cbe : HardwiredMemberDescriptor
      {
        internal PROP_e1b95d87fe844651be9b81f8c3cb5cbe()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_b37f4e0bb9de4474b4ed2a68083265f4 : HardwiredMemberDescriptor
      {
        internal PROP_b37f4e0bb9de4474b4ed2a68083265f4()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_cc7071d0b32b47c2b361018ee42c910f : HardwiredMemberDescriptor
      {
        internal PROP_cc7071d0b32b47c2b361018ee42c910f()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_61089371ef9c44c9813a18456f441fe4 : HardwiredUserDataDescriptor
    {
      internal TYPE_61089371ef9c44c9813a18456f441fe4()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_51aebeaab0b84ac5a607d6f4aaef1b16()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_a8ff1469450e4a5ba084d7c51e4846c1()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_21a059d188134168864595517d97d616()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_e28ede2add024b3094f18545b554d137()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_5bdf8c26908c40008781986fc252bcfd()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_2d1f5b8a281b4eac91328b6598b45033()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_a67ce917377d46abaada26d6ac7f6602()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_c168c5a74aec4dad8fc6e99594b7d750()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_b4b17524d3404f2e9cc6db5b6a5f8c32()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_28cb53e349154f9c9d979386ae1370f0()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_03e8839a746c4ba99d0b78b53830a95c()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_d204113b148a41daa351f7af2e2a0fc4()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_8af5b220f59546bba9ff2f67afebb3de()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_d8511fc5d59241b784f86930e605e293()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_66ba0488fde24c70845e5e0c8b49209f()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_20adb829708c495c8a45b7768cfe77d9()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_d215fa2361d04fd798fb870aba02e440()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_958334f2b8f248b68b78edb82a6c437c()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_ba79a7eb5b54491da084ec4f3d02ec79()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_72c2ac0806444568b11148d7d817a519()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_6710b893a3cc4bd8b26540ef477ff30a()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_0204d82b8d0640418b619be8a07f181e()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_1574798276474eef88c2de0b85a57a67()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_b150e8a309fb4a22ad3a2c05a7a32dfd()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_a6b96d2f27924057a99a52b575c6946f()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_c30471f6f7bb44d0a58df1de8d01915a()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_da857b261fae49c8b9b703746e37a272()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_66368b69e4e74ec0927f38b76ae66e32()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_b0f994b467d6406198896369d857e689()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_eb106ff77169407d884c3ee339d5fd79()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_796f52d7771b4e0e9e241a3fac92b10f()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_86ae54b316f74b70be03389da63d7155()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_fab5129cd1b7421699aa1000bbdb35bd()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_8f304121fa424bf9b4f7c0752ec7042c()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_131540544b704e438c6fa3c1255478c1()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_7e73f722026241cf9da662913c295483()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_4111122fbd36467b98d89a37cf85a842()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_7d6bdd707cde497c9ecf4d82fe60b577()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_33428a21681141128932ae1e62ab7d5b()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_b274e05e980c4a0b8f081192a7f8f914()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_cf4010388dc048229d51a597f2c06677()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_6e7ff467bc054391a17d392429768622()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_314e21876477495a846ec32c50303d19()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_f7bd0794c4ca4299a9991773ab42ff8d()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_ed2f3dc2537944229fce44829ba225ba()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_752bd1f93fd240568b16e76b39ff97a1()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_04f5a2e7ab134fb4bd0c372e58a2e20c()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_916cb24d077741bb8c462308d23e46c8()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_f60f6138c4f549a9bd56abafda75c386()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_dd3bdfef3c5c44baac01cfcadfcd5b12()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_5bdbe4bd8b33450f8772b7e16856781b()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_c6f3f653742c493998c81f6a82cf1b05()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_7a44b54503a04effb473a4ef2ab782e8()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_96f5c61f574e482cb4911f6d4f572e30()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_9f94501b61ec4fefa59e4ec8a358d735()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_8c21f4a5575e4866b2aa803ee25e67cb()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_bb3be9ee35534ff99a67331f685b4bb6()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_fb76bf7bcf1d4de2998cb1d7ec2818a7()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_cd8795e7cfad42e5be3f2f1a27b0d92e()
        }));
        this.AddMember("getDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_6de00d1b3b684768beb48be096c45107()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_5c0782c653e3422192ef739ef92044fa()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_05d9b21f5f0b460f90d03e85394413b6()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_95404edff9da4bcebad8084279f87d3f()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_d54b56ed9bbf4217bb7af5626d571904()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_a5d366da9f5e4af2a70906598e95224f(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_a6feeb3426ca47c2b708a8aecf27c3ef()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_025a3d8c6bc04199a44cee411d55197f(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_ed33ea78aeb746f08b3a4cc2429f0890()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_f5cdef6dd3b24efc9c7549777705582a()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_9e41f5071b3148338cca280748f285c6()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_49cd7a5db8674a979dfecbc8f9828a55(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_be2bf0345ecf49568ef670de29ad6d1b()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_1dda48f3cbd94f07a2797742f429185e()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_151592cabb9c43219a08900aeb9fa5f1()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_f4eb55c40f5e45ceb5b66d0a2d868df9()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_5964d1be0e2d4fb9a2ec054196647aa5()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_3d1d0a6c12fb40f3b22879d1504d46b8()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_e5f4991fe65c482fa58ce89b86100ecd()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_2fe7038d5865449dac209f33b26f3d1f()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_75a78f0297a24da0a03e3da9a0fe7655()
        }));
        this.AddMember("angleToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("angleToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_603d315bda594d9198107ba59b061dc2()
        }));
        this.AddMember("powerToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("powerToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_9c6540b2c4104d75934a8dcd5c34b227()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_356df6e9a5484fa19b4c2bbc3a61334a(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_072abbeefbfc4907890e216baf4c1c3d()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_5e44bbe2dfd34991ba6fbf35a9f5c338(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_815dcc02189e41f8a98253f06df24695()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_db14ba9029fd4cdb86b3af3b078b3e56()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_4e149da869a743a69d8987ea81028c04()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_a571df2921d24438939b6163fe87d148()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_02c0c7e86b73483fa8cf7f12ab105375()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_80a91d9ca88543348884e24cc19d774b()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.MTHD_ea8189a02b7a4ff9b617c9ba1fc8cedc()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_14c8b84f80b0422aa236adf29eaf55c4());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_9c0bffd918374c23a68cbd733329b18a());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_25a8c79987e647d9b61585ce1f0b73bd());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_69a34b92084b42418c8a49c5471a42fa());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_c2c7fadbbd5c48f49cd48b401e5d4ab6());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_78c958e7a2b34b128f075a6306206bcb());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_8c4d9db586774ff29927c9c500ce2e1b());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_c96b2c9e6cd14366a4021faa72946236());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_9e24d9a3be4342ffa23c820095604a3f());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_bf111d70f05f432dad1d5ef994d779de());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_142ada94ef7f4cf1b32fa76f7004b6ea());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_80d0f0db43fb473abb6a7a327d220927());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_2e24b99b8d1c451a9f06ac46f1c76c9f());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_60f9905b962c45688f41d8330b150182());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_98948cd57efd4f32a5bed07b6321b49f());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_1e21888484a741e7a517e6e351a9393d());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_48fcf4a35a454f769c77207ed10e82b7());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_6b33d2d4602d439ca7816eb08d3cfebb());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_ab7a0e077dd84332a29d55e85e836447());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_21fa1b3dea25496f85927bbfaa6e88ab());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_77c2264adf724e56a16e1718699191a7());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_1ef34480b551489dab25e405801b52b8());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_c325e5b2271c4b0d90cd0a30e1c35fca());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_d744634cbb70427685dc9b8f453d2f7b());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_d867352db1d34b1b82cf73c377a56269());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_67f285a3d3084197a6c352e5faf7d9d7());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_2305ca488c5e421ea4231506b2b6b0d7());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_f912bd304a944db3beb28bfcc2d54fb4());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_1d042fb150fd4e77ab2ce5a69567841f());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_1763ea781d4a4d16bd3d8d41a9b7cf8a());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_2019421a06ed43ecac5d861d42137b18());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_d59d0a48df4c46bf86a031ae161d8fbf());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_61089371ef9c44c9813a18456f441fe4.PROP_cc584e7c696141ecb2480191c001969c());
      }

      private sealed class MTHD_51aebeaab0b84ac5a607d6f4aaef1b16 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_51aebeaab0b84ac5a607d6f4aaef1b16()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_a8ff1469450e4a5ba084d7c51e4846c1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a8ff1469450e4a5ba084d7c51e4846c1()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_21a059d188134168864595517d97d616 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_21a059d188134168864595517d97d616()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_e28ede2add024b3094f18545b554d137 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e28ede2add024b3094f18545b554d137()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_5bdf8c26908c40008781986fc252bcfd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5bdf8c26908c40008781986fc252bcfd()
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

      private sealed class MTHD_2d1f5b8a281b4eac91328b6598b45033 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d1f5b8a281b4eac91328b6598b45033()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_a67ce917377d46abaada26d6ac7f6602 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a67ce917377d46abaada26d6ac7f6602()
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

      private sealed class MTHD_c168c5a74aec4dad8fc6e99594b7d750 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c168c5a74aec4dad8fc6e99594b7d750()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_b4b17524d3404f2e9cc6db5b6a5f8c32 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b4b17524d3404f2e9cc6db5b6a5f8c32()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_28cb53e349154f9c9d979386ae1370f0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_28cb53e349154f9c9d979386ae1370f0()
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

      private sealed class MTHD_03e8839a746c4ba99d0b78b53830a95c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_03e8839a746c4ba99d0b78b53830a95c()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_d204113b148a41daa351f7af2e2a0fc4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d204113b148a41daa351f7af2e2a0fc4()
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

      private sealed class MTHD_8af5b220f59546bba9ff2f67afebb3de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8af5b220f59546bba9ff2f67afebb3de()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_d8511fc5d59241b784f86930e605e293 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8511fc5d59241b784f86930e605e293()
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

      private sealed class MTHD_66ba0488fde24c70845e5e0c8b49209f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_66ba0488fde24c70845e5e0c8b49209f()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_20adb829708c495c8a45b7768cfe77d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_20adb829708c495c8a45b7768cfe77d9()
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

      private sealed class MTHD_d215fa2361d04fd798fb870aba02e440 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d215fa2361d04fd798fb870aba02e440()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_958334f2b8f248b68b78edb82a6c437c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_958334f2b8f248b68b78edb82a6c437c()
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

      private sealed class MTHD_ba79a7eb5b54491da084ec4f3d02ec79 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba79a7eb5b54491da084ec4f3d02ec79()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_72c2ac0806444568b11148d7d817a519 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_72c2ac0806444568b11148d7d817a519()
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

      private sealed class MTHD_6710b893a3cc4bd8b26540ef477ff30a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6710b893a3cc4bd8b26540ef477ff30a()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_0204d82b8d0640418b619be8a07f181e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0204d82b8d0640418b619be8a07f181e()
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

      private sealed class MTHD_1574798276474eef88c2de0b85a57a67 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1574798276474eef88c2de0b85a57a67()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_b150e8a309fb4a22ad3a2c05a7a32dfd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b150e8a309fb4a22ad3a2c05a7a32dfd()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_a6b96d2f27924057a99a52b575c6946f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6b96d2f27924057a99a52b575c6946f()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_c30471f6f7bb44d0a58df1de8d01915a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c30471f6f7bb44d0a58df1de8d01915a()
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

      private sealed class MTHD_da857b261fae49c8b9b703746e37a272 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_da857b261fae49c8b9b703746e37a272()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_66368b69e4e74ec0927f38b76ae66e32 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_66368b69e4e74ec0927f38b76ae66e32()
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

      private sealed class MTHD_b0f994b467d6406198896369d857e689 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b0f994b467d6406198896369d857e689()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_eb106ff77169407d884c3ee339d5fd79 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb106ff77169407d884c3ee339d5fd79()
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

      private sealed class MTHD_796f52d7771b4e0e9e241a3fac92b10f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_796f52d7771b4e0e9e241a3fac92b10f()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_86ae54b316f74b70be03389da63d7155 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_86ae54b316f74b70be03389da63d7155()
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

      private sealed class MTHD_fab5129cd1b7421699aa1000bbdb35bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fab5129cd1b7421699aa1000bbdb35bd()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_8f304121fa424bf9b4f7c0752ec7042c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8f304121fa424bf9b4f7c0752ec7042c()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_131540544b704e438c6fa3c1255478c1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_131540544b704e438c6fa3c1255478c1()
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

      private sealed class MTHD_7e73f722026241cf9da662913c295483 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7e73f722026241cf9da662913c295483()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_4111122fbd36467b98d89a37cf85a842 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4111122fbd36467b98d89a37cf85a842()
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

      private sealed class MTHD_7d6bdd707cde497c9ecf4d82fe60b577 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7d6bdd707cde497c9ecf4d82fe60b577()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_33428a21681141128932ae1e62ab7d5b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_33428a21681141128932ae1e62ab7d5b()
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

      private sealed class MTHD_b274e05e980c4a0b8f081192a7f8f914 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b274e05e980c4a0b8f081192a7f8f914()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_cf4010388dc048229d51a597f2c06677 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf4010388dc048229d51a597f2c06677()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_6e7ff467bc054391a17d392429768622 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e7ff467bc054391a17d392429768622()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_314e21876477495a846ec32c50303d19 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_314e21876477495a846ec32c50303d19()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_f7bd0794c4ca4299a9991773ab42ff8d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7bd0794c4ca4299a9991773ab42ff8d()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_ed2f3dc2537944229fce44829ba225ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed2f3dc2537944229fce44829ba225ba()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_752bd1f93fd240568b16e76b39ff97a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_752bd1f93fd240568b16e76b39ff97a1()
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

      private sealed class MTHD_04f5a2e7ab134fb4bd0c372e58a2e20c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_04f5a2e7ab134fb4bd0c372e58a2e20c()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_916cb24d077741bb8c462308d23e46c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_916cb24d077741bb8c462308d23e46c8()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_f60f6138c4f549a9bd56abafda75c386 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f60f6138c4f549a9bd56abafda75c386()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_dd3bdfef3c5c44baac01cfcadfcd5b12 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dd3bdfef3c5c44baac01cfcadfcd5b12()
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

      private sealed class MTHD_5bdbe4bd8b33450f8772b7e16856781b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5bdbe4bd8b33450f8772b7e16856781b()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_c6f3f653742c493998c81f6a82cf1b05 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c6f3f653742c493998c81f6a82cf1b05()
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

      private sealed class MTHD_7a44b54503a04effb473a4ef2ab782e8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a44b54503a04effb473a4ef2ab782e8()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_96f5c61f574e482cb4911f6d4f572e30 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_96f5c61f574e482cb4911f6d4f572e30()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_9f94501b61ec4fefa59e4ec8a358d735 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f94501b61ec4fefa59e4ec8a358d735()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_8c21f4a5575e4866b2aa803ee25e67cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c21f4a5575e4866b2aa803ee25e67cb()
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

      private sealed class MTHD_bb3be9ee35534ff99a67331f685b4bb6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb3be9ee35534ff99a67331f685b4bb6()
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

      private sealed class MTHD_fb76bf7bcf1d4de2998cb1d7ec2818a7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb76bf7bcf1d4de2998cb1d7ec2818a7()
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

      private sealed class MTHD_cd8795e7cfad42e5be3f2f1a27b0d92e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd8795e7cfad42e5be3f2f1a27b0d92e()
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

      private sealed class MTHD_6de00d1b3b684768beb48be096c45107 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6de00d1b3b684768beb48be096c45107()
        {
          this.Initialize("getDirection", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getDirection();
        }
      }

      private sealed class MTHD_5c0782c653e3422192ef739ef92044fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c0782c653e3422192ef739ef92044fa()
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

      private sealed class MTHD_05d9b21f5f0b460f90d03e85394413b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_05d9b21f5f0b460f90d03e85394413b6()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_95404edff9da4bcebad8084279f87d3f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95404edff9da4bcebad8084279f87d3f()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_d54b56ed9bbf4217bb7af5626d571904 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d54b56ed9bbf4217bb7af5626d571904()
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

      private sealed class MTHD_a5d366da9f5e4af2a70906598e95224f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a5d366da9f5e4af2a70906598e95224f()
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

      private sealed class MTHD_a6feeb3426ca47c2b708a8aecf27c3ef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6feeb3426ca47c2b708a8aecf27c3ef()
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

      private sealed class MTHD_025a3d8c6bc04199a44cee411d55197f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_025a3d8c6bc04199a44cee411d55197f()
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

      private sealed class MTHD_ed33ea78aeb746f08b3a4cc2429f0890 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed33ea78aeb746f08b3a4cc2429f0890()
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

      private sealed class MTHD_f5cdef6dd3b24efc9c7549777705582a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f5cdef6dd3b24efc9c7549777705582a()
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

      private sealed class MTHD_9e41f5071b3148338cca280748f285c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e41f5071b3148338cca280748f285c6()
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

      private sealed class MTHD_49cd7a5db8674a979dfecbc8f9828a55 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49cd7a5db8674a979dfecbc8f9828a55()
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

      private sealed class MTHD_be2bf0345ecf49568ef670de29ad6d1b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be2bf0345ecf49568ef670de29ad6d1b()
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

      private sealed class MTHD_1dda48f3cbd94f07a2797742f429185e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1dda48f3cbd94f07a2797742f429185e()
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

      private sealed class MTHD_151592cabb9c43219a08900aeb9fa5f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_151592cabb9c43219a08900aeb9fa5f1()
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

      private sealed class MTHD_f4eb55c40f5e45ceb5b66d0a2d868df9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4eb55c40f5e45ceb5b66d0a2d868df9()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_5964d1be0e2d4fb9a2ec054196647aa5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5964d1be0e2d4fb9a2ec054196647aa5()
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

      private sealed class MTHD_3d1d0a6c12fb40f3b22879d1504d46b8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d1d0a6c12fb40f3b22879d1504d46b8()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_e5f4991fe65c482fa58ce89b86100ecd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e5f4991fe65c482fa58ce89b86100ecd()
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

      private sealed class MTHD_2fe7038d5865449dac209f33b26f3d1f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2fe7038d5865449dac209f33b26f3d1f()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_75a78f0297a24da0a03e3da9a0fe7655 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75a78f0297a24da0a03e3da9a0fe7655()
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

      private sealed class MTHD_603d315bda594d9198107ba59b061dc2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_603d315bda594d9198107ba59b061dc2()
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

      private sealed class MTHD_9c6540b2c4104d75934a8dcd5c34b227 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c6540b2c4104d75934a8dcd5c34b227()
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

      private sealed class MTHD_356df6e9a5484fa19b4c2bbc3a61334a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_356df6e9a5484fa19b4c2bbc3a61334a()
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

      private sealed class MTHD_072abbeefbfc4907890e216baf4c1c3d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_072abbeefbfc4907890e216baf4c1c3d()
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

      private sealed class MTHD_5e44bbe2dfd34991ba6fbf35a9f5c338 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e44bbe2dfd34991ba6fbf35a9f5c338()
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

      private sealed class MTHD_815dcc02189e41f8a98253f06df24695 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_815dcc02189e41f8a98253f06df24695()
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

      private sealed class MTHD_db14ba9029fd4cdb86b3af3b078b3e56 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db14ba9029fd4cdb86b3af3b078b3e56()
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

      private sealed class MTHD_4e149da869a743a69d8987ea81028c04 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e149da869a743a69d8987ea81028c04()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_a571df2921d24438939b6163fe87d148 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a571df2921d24438939b6163fe87d148()
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

      private sealed class MTHD_02c0c7e86b73483fa8cf7f12ab105375 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_02c0c7e86b73483fa8cf7f12ab105375()
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

      private sealed class MTHD_80a91d9ca88543348884e24cc19d774b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_80a91d9ca88543348884e24cc19d774b()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_ea8189a02b7a4ff9b617c9ba1fc8cedc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea8189a02b7a4ff9b617c9ba1fc8cedc()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_14c8b84f80b0422aa236adf29eaf55c4 : HardwiredMemberDescriptor
      {
        internal PROP_14c8b84f80b0422aa236adf29eaf55c4()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_9c0bffd918374c23a68cbd733329b18a : HardwiredMemberDescriptor
      {
        internal PROP_9c0bffd918374c23a68cbd733329b18a()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_25a8c79987e647d9b61585ce1f0b73bd : HardwiredMemberDescriptor
      {
        internal PROP_25a8c79987e647d9b61585ce1f0b73bd()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_69a34b92084b42418c8a49c5471a42fa : HardwiredMemberDescriptor
      {
        internal PROP_69a34b92084b42418c8a49c5471a42fa()
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

      private sealed class PROP_c2c7fadbbd5c48f49cd48b401e5d4ab6 : HardwiredMemberDescriptor
      {
        internal PROP_c2c7fadbbd5c48f49cd48b401e5d4ab6()
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

      private sealed class PROP_78c958e7a2b34b128f075a6306206bcb : HardwiredMemberDescriptor
      {
        internal PROP_78c958e7a2b34b128f075a6306206bcb()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_8c4d9db586774ff29927c9c500ce2e1b : HardwiredMemberDescriptor
      {
        internal PROP_8c4d9db586774ff29927c9c500ce2e1b()
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

      private sealed class PROP_c96b2c9e6cd14366a4021faa72946236 : HardwiredMemberDescriptor
      {
        internal PROP_c96b2c9e6cd14366a4021faa72946236()
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

      private sealed class PROP_9e24d9a3be4342ffa23c820095604a3f : HardwiredMemberDescriptor
      {
        internal PROP_9e24d9a3be4342ffa23c820095604a3f()
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

      private sealed class PROP_bf111d70f05f432dad1d5ef994d779de : HardwiredMemberDescriptor
      {
        internal PROP_bf111d70f05f432dad1d5ef994d779de()
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

      private sealed class PROP_142ada94ef7f4cf1b32fa76f7004b6ea : HardwiredMemberDescriptor
      {
        internal PROP_142ada94ef7f4cf1b32fa76f7004b6ea()
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

      private sealed class PROP_80d0f0db43fb473abb6a7a327d220927 : HardwiredMemberDescriptor
      {
        internal PROP_80d0f0db43fb473abb6a7a327d220927()
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

      private sealed class PROP_2e24b99b8d1c451a9f06ac46f1c76c9f : HardwiredMemberDescriptor
      {
        internal PROP_2e24b99b8d1c451a9f06ac46f1c76c9f()
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

      private sealed class PROP_60f9905b962c45688f41d8330b150182 : HardwiredMemberDescriptor
      {
        internal PROP_60f9905b962c45688f41d8330b150182()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_98948cd57efd4f32a5bed07b6321b49f : HardwiredMemberDescriptor
      {
        internal PROP_98948cd57efd4f32a5bed07b6321b49f()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_1e21888484a741e7a517e6e351a9393d : HardwiredMemberDescriptor
      {
        internal PROP_1e21888484a741e7a517e6e351a9393d()
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

      private sealed class PROP_48fcf4a35a454f769c77207ed10e82b7 : HardwiredMemberDescriptor
      {
        internal PROP_48fcf4a35a454f769c77207ed10e82b7()
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

      private sealed class PROP_6b33d2d4602d439ca7816eb08d3cfebb : HardwiredMemberDescriptor
      {
        internal PROP_6b33d2d4602d439ca7816eb08d3cfebb()
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

      private sealed class PROP_ab7a0e077dd84332a29d55e85e836447 : HardwiredMemberDescriptor
      {
        internal PROP_ab7a0e077dd84332a29d55e85e836447()
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

      private sealed class PROP_21fa1b3dea25496f85927bbfaa6e88ab : HardwiredMemberDescriptor
      {
        internal PROP_21fa1b3dea25496f85927bbfaa6e88ab()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_77c2264adf724e56a16e1718699191a7 : HardwiredMemberDescriptor
      {
        internal PROP_77c2264adf724e56a16e1718699191a7()
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

      private sealed class PROP_1ef34480b551489dab25e405801b52b8 : HardwiredMemberDescriptor
      {
        internal PROP_1ef34480b551489dab25e405801b52b8()
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

      private sealed class PROP_c325e5b2271c4b0d90cd0a30e1c35fca : HardwiredMemberDescriptor
      {
        internal PROP_c325e5b2271c4b0d90cd0a30e1c35fca()
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

      private sealed class PROP_d744634cbb70427685dc9b8f453d2f7b : HardwiredMemberDescriptor
      {
        internal PROP_d744634cbb70427685dc9b8f453d2f7b()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_d867352db1d34b1b82cf73c377a56269 : HardwiredMemberDescriptor
      {
        internal PROP_d867352db1d34b1b82cf73c377a56269()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_67f285a3d3084197a6c352e5faf7d9d7 : HardwiredMemberDescriptor
      {
        internal PROP_67f285a3d3084197a6c352e5faf7d9d7()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_2305ca488c5e421ea4231506b2b6b0d7 : HardwiredMemberDescriptor
      {
        internal PROP_2305ca488c5e421ea4231506b2b6b0d7()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_f912bd304a944db3beb28bfcc2d54fb4 : HardwiredMemberDescriptor
      {
        internal PROP_f912bd304a944db3beb28bfcc2d54fb4()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_1d042fb150fd4e77ab2ce5a69567841f : HardwiredMemberDescriptor
      {
        internal PROP_1d042fb150fd4e77ab2ce5a69567841f()
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

      private sealed class PROP_1763ea781d4a4d16bd3d8d41a9b7cf8a : HardwiredMemberDescriptor
      {
        internal PROP_1763ea781d4a4d16bd3d8d41a9b7cf8a()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_2019421a06ed43ecac5d861d42137b18 : HardwiredMemberDescriptor
      {
        internal PROP_2019421a06ed43ecac5d861d42137b18()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_d59d0a48df4c46bf86a031ae161d8fbf : HardwiredMemberDescriptor
      {
        internal PROP_d59d0a48df4c46bf86a031ae161d8fbf()
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

      private sealed class PROP_cc584e7c696141ecb2480191c001969c : HardwiredMemberDescriptor
      {
        internal PROP_cc584e7c696141ecb2480191c001969c()
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

    private sealed class TYPE_620a3c711ffb4fc5b732bec82068842b : HardwiredUserDataDescriptor
    {
      internal TYPE_620a3c711ffb4fc5b732bec82068842b()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.MTHD_c9528ba4133f4676b0dcde3e933da71f()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.MTHD_f692b9f0f9a54f19ae07f7b9ce6f03b6()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.MTHD_dca87ac59a4a4e9c967470fe6b4a0362()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.MTHD_ae6c386c1c95431da091ff6f8e247063()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.MTHD_c9793918fb77490396cdcc031112bab4()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.MTHD_167c64debf494916812ed7286e4d421e()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.MTHD_c4e32b917549426ab86b45c482af3233()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.MTHD_e718c111166c476e93c2cc23ceb8d7b9()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.MTHD_d4fcd8e306bc46a7b38cd7c586ae4df6()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.MTHD_02158b6e6c4741eb865ecb9c221ae72d()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.MTHD_6937bb7753d74e639353bde94002cba6()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.MTHD_0303be54acfd4c1282bea43ab1b2cd33()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.MTHD_5d709e42b31f4b4988ffd1a9bc5291d5()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.MTHD_3e20265b06d04bef94f619d181b2fb0a()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.MTHD_5d7a10c67da64d3e887298a2a3336baa()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.MTHD_4ecc042677664348983e621b2436728a()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.MTHD_fde78160cb404c958c9597e6958e54de()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.MTHD_3933d36085aa496a8a75f1e3cfe2f90e()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.MTHD_40552a8b95414b148682e224c96484c0()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.MTHD_a6d01f6609004295a43aca7291ad8eb2()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.PROP_28c1788b924547339da4c9256437c0bf());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.PROP_95a1b45ab3de4c629b092e48ca1b09f1());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.PROP_3f6fd8adca2846388382949af0ee452d());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.PROP_fd155230aed4486cb00c97e059b55055());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.PROP_a24a0ac490cf4a58a9b12e81fc2778f0());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.PROP_52ca8ef1790b4c5a8301b0ba192e3848());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.PROP_f141dfc350244a27aa46836102cd764a());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_620a3c711ffb4fc5b732bec82068842b.PROP_205b641254804e81a958633b71198d4c());
      }

      private sealed class MTHD_c9528ba4133f4676b0dcde3e933da71f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c9528ba4133f4676b0dcde3e933da71f()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_f692b9f0f9a54f19ae07f7b9ce6f03b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f692b9f0f9a54f19ae07f7b9ce6f03b6()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_dca87ac59a4a4e9c967470fe6b4a0362 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dca87ac59a4a4e9c967470fe6b4a0362()
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

      private sealed class MTHD_ae6c386c1c95431da091ff6f8e247063 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae6c386c1c95431da091ff6f8e247063()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_c9793918fb77490396cdcc031112bab4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c9793918fb77490396cdcc031112bab4()
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

      private sealed class MTHD_167c64debf494916812ed7286e4d421e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_167c64debf494916812ed7286e4d421e()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_c4e32b917549426ab86b45c482af3233 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c4e32b917549426ab86b45c482af3233()
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

      private sealed class MTHD_e718c111166c476e93c2cc23ceb8d7b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e718c111166c476e93c2cc23ceb8d7b9()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_d4fcd8e306bc46a7b38cd7c586ae4df6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d4fcd8e306bc46a7b38cd7c586ae4df6()
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

      private sealed class MTHD_02158b6e6c4741eb865ecb9c221ae72d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_02158b6e6c4741eb865ecb9c221ae72d()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_6937bb7753d74e639353bde94002cba6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6937bb7753d74e639353bde94002cba6()
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

      private sealed class MTHD_0303be54acfd4c1282bea43ab1b2cd33 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0303be54acfd4c1282bea43ab1b2cd33()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_5d709e42b31f4b4988ffd1a9bc5291d5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d709e42b31f4b4988ffd1a9bc5291d5()
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

      private sealed class MTHD_3e20265b06d04bef94f619d181b2fb0a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e20265b06d04bef94f619d181b2fb0a()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_5d7a10c67da64d3e887298a2a3336baa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d7a10c67da64d3e887298a2a3336baa()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_4ecc042677664348983e621b2436728a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ecc042677664348983e621b2436728a()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_fde78160cb404c958c9597e6958e54de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fde78160cb404c958c9597e6958e54de()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_3933d36085aa496a8a75f1e3cfe2f90e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3933d36085aa496a8a75f1e3cfe2f90e()
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

      private sealed class MTHD_40552a8b95414b148682e224c96484c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_40552a8b95414b148682e224c96484c0()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_a6d01f6609004295a43aca7291ad8eb2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6d01f6609004295a43aca7291ad8eb2()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_28c1788b924547339da4c9256437c0bf : HardwiredMemberDescriptor
      {
        internal PROP_28c1788b924547339da4c9256437c0bf()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_95a1b45ab3de4c629b092e48ca1b09f1 : HardwiredMemberDescriptor
      {
        internal PROP_95a1b45ab3de4c629b092e48ca1b09f1()
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

      private sealed class PROP_3f6fd8adca2846388382949af0ee452d : HardwiredMemberDescriptor
      {
        internal PROP_3f6fd8adca2846388382949af0ee452d()
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

      private sealed class PROP_fd155230aed4486cb00c97e059b55055 : HardwiredMemberDescriptor
      {
        internal PROP_fd155230aed4486cb00c97e059b55055()
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

      private sealed class PROP_a24a0ac490cf4a58a9b12e81fc2778f0 : HardwiredMemberDescriptor
      {
        internal PROP_a24a0ac490cf4a58a9b12e81fc2778f0()
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

      private sealed class PROP_52ca8ef1790b4c5a8301b0ba192e3848 : HardwiredMemberDescriptor
      {
        internal PROP_52ca8ef1790b4c5a8301b0ba192e3848()
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

      private sealed class PROP_f141dfc350244a27aa46836102cd764a : HardwiredMemberDescriptor
      {
        internal PROP_f141dfc350244a27aa46836102cd764a()
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

      private sealed class PROP_205b641254804e81a958633b71198d4c : HardwiredMemberDescriptor
      {
        internal PROP_205b641254804e81a958633b71198d4c()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_951eeb1997bd416a9cee7d38025fa6a0 : HardwiredUserDataDescriptor
    {
      internal TYPE_951eeb1997bd416a9cee7d38025fa6a0()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.MTHD_d18620ac9a2d49a79641d964546ddafe()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.MTHD_9c79f9f9f93e463abfc2b3078c76f8d1()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.MTHD_449954e13f674c4dabf27af6dd52b54a()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.MTHD_37068858aa9c460a9ad46fb363fc915b()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.MTHD_93e82b3260f6434498ef236b8c39647b()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.MTHD_f65b6d9b68c5457f9b1a49d738fc63c4()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.MTHD_d0bb3a525688467d8ef7c19146acc112()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.MTHD_d864ca34fec74cf49c73582a7c66ddd1()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.MTHD_45e130a09af4429eb841d1a5caf6ff85()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.MTHD_a7127253f28b43dd8d33ac3abba65d4e()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.MTHD_3d4aba008d5641f2b632d352690cf469()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.MTHD_310c73f3afff4b25a816e83e93adec71()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.MTHD_b29e2e6867134a1b954a8c09cb9df84f()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.MTHD_a763dd6b56974c8183fae3a079ec9d1c()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.MTHD_033ed42622dc4beb8f3c806304cd990b()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.MTHD_eba920e3fec649af86f0573195e1175d()
        }));
        this.AddMember("setIcon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setIcon", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.MTHD_e0a518c2d88c48cab084171d87280b55()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.MTHD_ba7789fa717a4fd3b9a592cc5c2a2033()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.MTHD_30c53cff2e5a41d283368ba6085da243()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.MTHD_482c51b8e9234173ac6adc583824bea8()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.MTHD_439a2c176a6945b9ad1c52d59f9e7c22()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.MTHD_fa4653a5c6204857b46f383954a3e2b0()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.PROP_0925dc3c95de4eb0a14fe68d0c42a5df());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.PROP_f33c548cc6c74b8e849155f3bc03c77a());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.PROP_bdb50f5509684f84b1347d59e39c69a6());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.PROP_2c357ec49d514f3a84c2539f1b2469d2());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.PROP_2441e2fd1daa4f8fba940def478a01cf());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.PROP_8047cc3f50c347b88cbee44807b73a91());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.PROP_e4641ad42c9e411bb22830c36cadb219());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.PROP_bbfc809cd70545eda0b230c4e56d360c());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_951eeb1997bd416a9cee7d38025fa6a0.PROP_c8b3def5f2db4cdf81cf24c85cb2fed3());
      }

      private sealed class MTHD_d18620ac9a2d49a79641d964546ddafe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d18620ac9a2d49a79641d964546ddafe()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_9c79f9f9f93e463abfc2b3078c76f8d1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c79f9f9f93e463abfc2b3078c76f8d1()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_449954e13f674c4dabf27af6dd52b54a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_449954e13f674c4dabf27af6dd52b54a()
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

      private sealed class MTHD_37068858aa9c460a9ad46fb363fc915b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_37068858aa9c460a9ad46fb363fc915b()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_93e82b3260f6434498ef236b8c39647b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93e82b3260f6434498ef236b8c39647b()
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

      private sealed class MTHD_f65b6d9b68c5457f9b1a49d738fc63c4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f65b6d9b68c5457f9b1a49d738fc63c4()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_d0bb3a525688467d8ef7c19146acc112 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0bb3a525688467d8ef7c19146acc112()
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

      private sealed class MTHD_d864ca34fec74cf49c73582a7c66ddd1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d864ca34fec74cf49c73582a7c66ddd1()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_45e130a09af4429eb841d1a5caf6ff85 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_45e130a09af4429eb841d1a5caf6ff85()
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

      private sealed class MTHD_a7127253f28b43dd8d33ac3abba65d4e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a7127253f28b43dd8d33ac3abba65d4e()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_3d4aba008d5641f2b632d352690cf469 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d4aba008d5641f2b632d352690cf469()
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

      private sealed class MTHD_310c73f3afff4b25a816e83e93adec71 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_310c73f3afff4b25a816e83e93adec71()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_b29e2e6867134a1b954a8c09cb9df84f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b29e2e6867134a1b954a8c09cb9df84f()
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

      private sealed class MTHD_a763dd6b56974c8183fae3a079ec9d1c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a763dd6b56974c8183fae3a079ec9d1c()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color2;
        }
      }

      private sealed class MTHD_033ed42622dc4beb8f3c806304cd990b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_033ed42622dc4beb8f3c806304cd990b()
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

      private sealed class MTHD_eba920e3fec649af86f0573195e1175d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eba920e3fec649af86f0573195e1175d()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_e0a518c2d88c48cab084171d87280b55 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e0a518c2d88c48cab084171d87280b55()
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

      private sealed class MTHD_ba7789fa717a4fd3b9a592cc5c2a2033 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba7789fa717a4fd3b9a592cc5c2a2033()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_30c53cff2e5a41d283368ba6085da243 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_30c53cff2e5a41d283368ba6085da243()
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

      private sealed class MTHD_482c51b8e9234173ac6adc583824bea8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_482c51b8e9234173ac6adc583824bea8()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_439a2c176a6945b9ad1c52d59f9e7c22 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_439a2c176a6945b9ad1c52d59f9e7c22()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_fa4653a5c6204857b46f383954a3e2b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa4653a5c6204857b46f383954a3e2b0()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_0925dc3c95de4eb0a14fe68d0c42a5df : HardwiredMemberDescriptor
      {
        internal PROP_0925dc3c95de4eb0a14fe68d0c42a5df()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_f33c548cc6c74b8e849155f3bc03c77a : HardwiredMemberDescriptor
      {
        internal PROP_f33c548cc6c74b8e849155f3bc03c77a()
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

      private sealed class PROP_bdb50f5509684f84b1347d59e39c69a6 : HardwiredMemberDescriptor
      {
        internal PROP_bdb50f5509684f84b1347d59e39c69a6()
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

      private sealed class PROP_2c357ec49d514f3a84c2539f1b2469d2 : HardwiredMemberDescriptor
      {
        internal PROP_2c357ec49d514f3a84c2539f1b2469d2()
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

      private sealed class PROP_2441e2fd1daa4f8fba940def478a01cf : HardwiredMemberDescriptor
      {
        internal PROP_2441e2fd1daa4f8fba940def478a01cf()
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

      private sealed class PROP_8047cc3f50c347b88cbee44807b73a91 : HardwiredMemberDescriptor
      {
        internal PROP_8047cc3f50c347b88cbee44807b73a91()
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

      private sealed class PROP_e4641ad42c9e411bb22830c36cadb219 : HardwiredMemberDescriptor
      {
        internal PROP_e4641ad42c9e411bb22830c36cadb219()
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

      private sealed class PROP_bbfc809cd70545eda0b230c4e56d360c : HardwiredMemberDescriptor
      {
        internal PROP_bbfc809cd70545eda0b230c4e56d360c()
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

      private sealed class PROP_c8b3def5f2db4cdf81cf24c85cb2fed3 : HardwiredMemberDescriptor
      {
        internal PROP_c8b3def5f2db4cdf81cf24c85cb2fed3()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_ce84cc59d2b9430789480e639dfed1a8 : HardwiredUserDataDescriptor
    {
      internal TYPE_ce84cc59d2b9430789480e639dfed1a8()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_04232170bbcb422291a0ee4edb001a69()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_904ba583f25c461ebbe9dceba3d9f643()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_d6dfaca7832e434da907d426280a3a1c()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_5ce037f2f3f940649a42d95dd72355e0()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_00d33170a3b64d69ac76d5af856f5ae7()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_cddf639796f140669f0a1d64864b5ac9()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_44ff4e8a6aaa4412990a426424a56d74()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_e1e010dcac7c412eb06cd5fbc9c69078()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_62339156b65540f19996596a1c5718c2()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_00f9f186294944fd9934bb786eb26003()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_6ab72a5ac7a240e88e8e83e0065bfa39()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_7d74ce71804c4cee94f68bf3fe582611()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_f448ffe852a5465e901a514a3613f487()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_1f2d172522784f23b96b888cd08c4f28()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_bafed39133544fbca20da3db3fc4ca43()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_9f9a937bf9d84f36af2e2baf3e364308()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_cf69f33a37744e20beac78fd49bb9b1a()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_b1be1fdf44984f28aeecac6ccb8b3479()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_cca72232aa014cfbab531efe20968527()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_0772e35d19df4d7ca0768fc9b021f793()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_f3376e5047b04955a2407e549c22827e()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_af80462c7c364bd1a5c4e269675380ca()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_be56c96c39014d0fa0ac10ac6aeaa083()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_cdf793b893a049f3b562b6f3754e1da8()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_ea49f5391651485a8254c3d7c9a4cc4c()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_e6ab7a4d0cbc4bae82b0771912c9c059()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_0a53714baf8e4d1b8f1018570010d874()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.MTHD_d8f2ee07ba7542d9b944b42ee2ed149e()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.PROP_69d0be3c2ee14829b1b3db94f4541041());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.PROP_f6d6f5d3e5b8443d809460e7e1f7e75e());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.PROP_3f15c2f3cb1749a598eaf50968ac22bf());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.PROP_60ebb53d38b34682a12a32dde1bc9e8c());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.PROP_7fdb735e3bab4c158242407b8ff601f9());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.PROP_5fd636ceb634491499b6163efe9c25c7());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.PROP_c902230534c4463c9d43474b4c7f5f4f());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.PROP_5b259d5376fe42aa82c2560a54bbc8bc());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.PROP_35a70b302f6d41448f1e458240387d52());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.PROP_4a219172cba24305a0d2d5c220830917());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.PROP_40a3a972356b4a669611333b78e38c8f());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.PROP_989826551b00414ab700a93f80694386());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.PROP_3b4ddc12a8b24ad88ae8c4411288b920());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.PROP_efa52962d9de42be8273c1072bb746b3());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.PROP_b99f76c6fe48419491ac07ccc8844fd4());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.PROP_f00dcd9d5d734b2f8741b2856b9f3c68());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_ce84cc59d2b9430789480e639dfed1a8.PROP_29837ed2f4d94956993a9f4d6765fe82());
      }

      private sealed class MTHD_04232170bbcb422291a0ee4edb001a69 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_04232170bbcb422291a0ee4edb001a69()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_904ba583f25c461ebbe9dceba3d9f643 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_904ba583f25c461ebbe9dceba3d9f643()
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

      private sealed class MTHD_d6dfaca7832e434da907d426280a3a1c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6dfaca7832e434da907d426280a3a1c()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_5ce037f2f3f940649a42d95dd72355e0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ce037f2f3f940649a42d95dd72355e0()
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

      private sealed class MTHD_00d33170a3b64d69ac76d5af856f5ae7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_00d33170a3b64d69ac76d5af856f5ae7()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_cddf639796f140669f0a1d64864b5ac9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cddf639796f140669f0a1d64864b5ac9()
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

      private sealed class MTHD_44ff4e8a6aaa4412990a426424a56d74 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_44ff4e8a6aaa4412990a426424a56d74()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_e1e010dcac7c412eb06cd5fbc9c69078 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e1e010dcac7c412eb06cd5fbc9c69078()
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

      private sealed class MTHD_62339156b65540f19996596a1c5718c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_62339156b65540f19996596a1c5718c2()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_00f9f186294944fd9934bb786eb26003 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_00f9f186294944fd9934bb786eb26003()
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

      private sealed class MTHD_6ab72a5ac7a240e88e8e83e0065bfa39 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ab72a5ac7a240e88e8e83e0065bfa39()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_7d74ce71804c4cee94f68bf3fe582611 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7d74ce71804c4cee94f68bf3fe582611()
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

      private sealed class MTHD_f448ffe852a5465e901a514a3613f487 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f448ffe852a5465e901a514a3613f487()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_1f2d172522784f23b96b888cd08c4f28 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f2d172522784f23b96b888cd08c4f28()
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

      private sealed class MTHD_bafed39133544fbca20da3db3fc4ca43 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bafed39133544fbca20da3db3fc4ca43()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_9f9a937bf9d84f36af2e2baf3e364308 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f9a937bf9d84f36af2e2baf3e364308()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_cf69f33a37744e20beac78fd49bb9b1a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf69f33a37744e20beac78fd49bb9b1a()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_b1be1fdf44984f28aeecac6ccb8b3479 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b1be1fdf44984f28aeecac6ccb8b3479()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_cca72232aa014cfbab531efe20968527 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cca72232aa014cfbab531efe20968527()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_0772e35d19df4d7ca0768fc9b021f793 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0772e35d19df4d7ca0768fc9b021f793()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_f3376e5047b04955a2407e549c22827e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f3376e5047b04955a2407e549c22827e()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_af80462c7c364bd1a5c4e269675380ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_af80462c7c364bd1a5c4e269675380ca()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_be56c96c39014d0fa0ac10ac6aeaa083 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be56c96c39014d0fa0ac10ac6aeaa083()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_cdf793b893a049f3b562b6f3754e1da8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cdf793b893a049f3b562b6f3754e1da8()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_ea49f5391651485a8254c3d7c9a4cc4c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea49f5391651485a8254c3d7c9a4cc4c()
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

      private sealed class MTHD_e6ab7a4d0cbc4bae82b0771912c9c059 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e6ab7a4d0cbc4bae82b0771912c9c059()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_0a53714baf8e4d1b8f1018570010d874 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0a53714baf8e4d1b8f1018570010d874()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_d8f2ee07ba7542d9b944b42ee2ed149e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8f2ee07ba7542d9b944b42ee2ed149e()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_69d0be3c2ee14829b1b3db94f4541041 : HardwiredMemberDescriptor
      {
        internal PROP_69d0be3c2ee14829b1b3db94f4541041()
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

      private sealed class PROP_f6d6f5d3e5b8443d809460e7e1f7e75e : HardwiredMemberDescriptor
      {
        internal PROP_f6d6f5d3e5b8443d809460e7e1f7e75e()
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

      private sealed class PROP_3f15c2f3cb1749a598eaf50968ac22bf : HardwiredMemberDescriptor
      {
        internal PROP_3f15c2f3cb1749a598eaf50968ac22bf()
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

      private sealed class PROP_60ebb53d38b34682a12a32dde1bc9e8c : HardwiredMemberDescriptor
      {
        internal PROP_60ebb53d38b34682a12a32dde1bc9e8c()
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

      private sealed class PROP_7fdb735e3bab4c158242407b8ff601f9 : HardwiredMemberDescriptor
      {
        internal PROP_7fdb735e3bab4c158242407b8ff601f9()
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

      private sealed class PROP_5fd636ceb634491499b6163efe9c25c7 : HardwiredMemberDescriptor
      {
        internal PROP_5fd636ceb634491499b6163efe9c25c7()
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

      private sealed class PROP_c902230534c4463c9d43474b4c7f5f4f : HardwiredMemberDescriptor
      {
        internal PROP_c902230534c4463c9d43474b4c7f5f4f()
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

      private sealed class PROP_5b259d5376fe42aa82c2560a54bbc8bc : HardwiredMemberDescriptor
      {
        internal PROP_5b259d5376fe42aa82c2560a54bbc8bc()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_35a70b302f6d41448f1e458240387d52 : HardwiredMemberDescriptor
      {
        internal PROP_35a70b302f6d41448f1e458240387d52()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_4a219172cba24305a0d2d5c220830917 : HardwiredMemberDescriptor
      {
        internal PROP_4a219172cba24305a0d2d5c220830917()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_40a3a972356b4a669611333b78e38c8f : HardwiredMemberDescriptor
      {
        internal PROP_40a3a972356b4a669611333b78e38c8f()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_989826551b00414ab700a93f80694386 : HardwiredMemberDescriptor
      {
        internal PROP_989826551b00414ab700a93f80694386()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_3b4ddc12a8b24ad88ae8c4411288b920 : HardwiredMemberDescriptor
      {
        internal PROP_3b4ddc12a8b24ad88ae8c4411288b920()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_efa52962d9de42be8273c1072bb746b3 : HardwiredMemberDescriptor
      {
        internal PROP_efa52962d9de42be8273c1072bb746b3()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_b99f76c6fe48419491ac07ccc8844fd4 : HardwiredMemberDescriptor
      {
        internal PROP_b99f76c6fe48419491ac07ccc8844fd4()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_f00dcd9d5d734b2f8741b2856b9f3c68 : HardwiredMemberDescriptor
      {
        internal PROP_f00dcd9d5d734b2f8741b2856b9f3c68()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_29837ed2f4d94956993a9f4d6765fe82 : HardwiredMemberDescriptor
      {
        internal PROP_29837ed2f4d94956993a9f4d6765fe82()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_5e1f9db09fc84d23ad4203dacc9ad67d : HardwiredUserDataDescriptor
    {
      internal TYPE_5e1f9db09fc84d23ad4203dacc9ad67d()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e1f9db09fc84d23ad4203dacc9ad67d.MTHD_5639a1e8ce65449c95b92f7b54c14159()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e1f9db09fc84d23ad4203dacc9ad67d.MTHD_557445666e934d4fa6e868a2b6208189()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e1f9db09fc84d23ad4203dacc9ad67d.MTHD_827ee64655d646e1a7676172a5a96fb1()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e1f9db09fc84d23ad4203dacc9ad67d.MTHD_870e6b2934a44cfba9474f67da9a42ec()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e1f9db09fc84d23ad4203dacc9ad67d.MTHD_78e81f5499f147a5b5bc17e640a7d767()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e1f9db09fc84d23ad4203dacc9ad67d.MTHD_0a72752cd52d4287bd87c242fd2d9bea()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e1f9db09fc84d23ad4203dacc9ad67d.MTHD_3fe25f6723694ce2b7d7f07593560b34()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e1f9db09fc84d23ad4203dacc9ad67d.MTHD_c729b1f7b7034ab794bccffa1f52678b()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e1f9db09fc84d23ad4203dacc9ad67d.MTHD_f2086ac71afc4bd7a2e21acefc715509()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e1f9db09fc84d23ad4203dacc9ad67d.MTHD_be514e0cdc8f456d9be4462178546065()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e1f9db09fc84d23ad4203dacc9ad67d.MTHD_5e8a4923648c42a0b14c17f5f2b8f153()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e1f9db09fc84d23ad4203dacc9ad67d.MTHD_20476012342d4a16ac8b2780047bd69f()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e1f9db09fc84d23ad4203dacc9ad67d.MTHD_601d29c4c350498f9ca922caee8d2c46()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e1f9db09fc84d23ad4203dacc9ad67d.MTHD_7ac3776ad12446189a0c339d5a6dd84d()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e1f9db09fc84d23ad4203dacc9ad67d.MTHD_fa4a6ff84c694b81b3c9a873a5200d3f()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e1f9db09fc84d23ad4203dacc9ad67d.MTHD_fcc3faacd20c4cf8bd666167b0de68fd()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5e1f9db09fc84d23ad4203dacc9ad67d.MTHD_23c1994b5a1b46fba09c40691e4c3df7()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_5e1f9db09fc84d23ad4203dacc9ad67d.PROP_a656d95f45b14d6ab4bf597ba5b744da());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_5e1f9db09fc84d23ad4203dacc9ad67d.PROP_b3f8a2c4d57b4b50b029a20fd31eef9d());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_5e1f9db09fc84d23ad4203dacc9ad67d.PROP_de440066e75349d4a5b83ffdc29dc31b());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_5e1f9db09fc84d23ad4203dacc9ad67d.PROP_aceb43576e144324920e1abc2a044450());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_5e1f9db09fc84d23ad4203dacc9ad67d.PROP_36e37dc532b841539508d5a1e5c9d9ea());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_5e1f9db09fc84d23ad4203dacc9ad67d.PROP_edb1a6f89a894fdaab18c6968fab36a8());
      }

      private sealed class MTHD_5639a1e8ce65449c95b92f7b54c14159 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5639a1e8ce65449c95b92f7b54c14159()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_557445666e934d4fa6e868a2b6208189 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_557445666e934d4fa6e868a2b6208189()
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

      private sealed class MTHD_827ee64655d646e1a7676172a5a96fb1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_827ee64655d646e1a7676172a5a96fb1()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_870e6b2934a44cfba9474f67da9a42ec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_870e6b2934a44cfba9474f67da9a42ec()
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

      private sealed class MTHD_78e81f5499f147a5b5bc17e640a7d767 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_78e81f5499f147a5b5bc17e640a7d767()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_0a72752cd52d4287bd87c242fd2d9bea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0a72752cd52d4287bd87c242fd2d9bea()
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

      private sealed class MTHD_3fe25f6723694ce2b7d7f07593560b34 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3fe25f6723694ce2b7d7f07593560b34()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_c729b1f7b7034ab794bccffa1f52678b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c729b1f7b7034ab794bccffa1f52678b()
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

      private sealed class MTHD_f2086ac71afc4bd7a2e21acefc715509 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f2086ac71afc4bd7a2e21acefc715509()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_be514e0cdc8f456d9be4462178546065 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be514e0cdc8f456d9be4462178546065()
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

      private sealed class MTHD_5e8a4923648c42a0b14c17f5f2b8f153 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e8a4923648c42a0b14c17f5f2b8f153()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_20476012342d4a16ac8b2780047bd69f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_20476012342d4a16ac8b2780047bd69f()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_601d29c4c350498f9ca922caee8d2c46 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_601d29c4c350498f9ca922caee8d2c46()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_7ac3776ad12446189a0c339d5a6dd84d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ac3776ad12446189a0c339d5a6dd84d()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_fa4a6ff84c694b81b3c9a873a5200d3f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa4a6ff84c694b81b3c9a873a5200d3f()
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

      private sealed class MTHD_fcc3faacd20c4cf8bd666167b0de68fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fcc3faacd20c4cf8bd666167b0de68fd()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_23c1994b5a1b46fba09c40691e4c3df7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_23c1994b5a1b46fba09c40691e4c3df7()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_a656d95f45b14d6ab4bf597ba5b744da : HardwiredMemberDescriptor
      {
        internal PROP_a656d95f45b14d6ab4bf597ba5b744da()
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

      private sealed class PROP_b3f8a2c4d57b4b50b029a20fd31eef9d : HardwiredMemberDescriptor
      {
        internal PROP_b3f8a2c4d57b4b50b029a20fd31eef9d()
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

      private sealed class PROP_de440066e75349d4a5b83ffdc29dc31b : HardwiredMemberDescriptor
      {
        internal PROP_de440066e75349d4a5b83ffdc29dc31b()
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

      private sealed class PROP_aceb43576e144324920e1abc2a044450 : HardwiredMemberDescriptor
      {
        internal PROP_aceb43576e144324920e1abc2a044450()
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

      private sealed class PROP_36e37dc532b841539508d5a1e5c9d9ea : HardwiredMemberDescriptor
      {
        internal PROP_36e37dc532b841539508d5a1e5c9d9ea()
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

      private sealed class PROP_edb1a6f89a894fdaab18c6968fab36a8 : HardwiredMemberDescriptor
      {
        internal PROP_edb1a6f89a894fdaab18c6968fab36a8()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_dc7b79a5fee0482caa29d01a6ce9673c : HardwiredUserDataDescriptor
    {
      internal TYPE_dc7b79a5fee0482caa29d01a6ce9673c()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc7b79a5fee0482caa29d01a6ce9673c.MTHD_fc174eb2a88d4934af14b7a016b45b22(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc7b79a5fee0482caa29d01a6ce9673c.MTHD_21ae77099a824f139a66070504f78eb9()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc7b79a5fee0482caa29d01a6ce9673c.MTHD_5409e1c8922d4563b0a03974dac9d267(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc7b79a5fee0482caa29d01a6ce9673c.MTHD_1f689af42aad46d5880e468271e2f558()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc7b79a5fee0482caa29d01a6ce9673c.MTHD_0464be64a41a45af9102abac63e751ae()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc7b79a5fee0482caa29d01a6ce9673c.MTHD_4dccbf3a0a0f48ba9a19a51e2077aa70()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc7b79a5fee0482caa29d01a6ce9673c.MTHD_9b8066f1d39e4792b33fbd37809c53af()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc7b79a5fee0482caa29d01a6ce9673c.MTHD_cb3d8aaf6097413197a1f5fa769b136f()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc7b79a5fee0482caa29d01a6ce9673c.MTHD_71acc215753244b6bb33f1ece1474335()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc7b79a5fee0482caa29d01a6ce9673c.MTHD_8f08e2ac895e405f941dfde919bf7203()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc7b79a5fee0482caa29d01a6ce9673c.MTHD_f0c7b3dedf484ed39d87b0bd15d0046d()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc7b79a5fee0482caa29d01a6ce9673c.MTHD_c82b9012d62d42f9a6938241f78097cd(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc7b79a5fee0482caa29d01a6ce9673c.MTHD_fc646db4dfb2424db2edd53522395d2f()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc7b79a5fee0482caa29d01a6ce9673c.MTHD_6123946e150142deb4b095a86c2cdea2(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc7b79a5fee0482caa29d01a6ce9673c.MTHD_802786bd264346b8a1b228af4140ae63()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc7b79a5fee0482caa29d01a6ce9673c.MTHD_926c95fd7ca64c9096f38eddfe25eb6a(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc7b79a5fee0482caa29d01a6ce9673c.MTHD_b531a63823b44c49b8438d558f2372f6()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc7b79a5fee0482caa29d01a6ce9673c.MTHD_54820d7331e941fe9497be56243becf2(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc7b79a5fee0482caa29d01a6ce9673c.MTHD_531512c8138543019687ccb4202e4909()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc7b79a5fee0482caa29d01a6ce9673c.MTHD_ece8ae11ae304cea980a597cc0473134(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc7b79a5fee0482caa29d01a6ce9673c.MTHD_406554b9695645bb95a90d836efa2304()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc7b79a5fee0482caa29d01a6ce9673c.MTHD_41fb1b82cd94436583a149f78448788e()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc7b79a5fee0482caa29d01a6ce9673c.MTHD_bdc20d103d024811b3c5efa0d16d83a0()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_dc7b79a5fee0482caa29d01a6ce9673c.FLDV_894b7ad7c9714dfcb145283545d58287());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_dc7b79a5fee0482caa29d01a6ce9673c.FLDV_ac7e182ac837474c80c4b9d6c1cdc15b());
      }

      private sealed class MTHD_fc174eb2a88d4934af14b7a016b45b22 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fc174eb2a88d4934af14b7a016b45b22()
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

      private sealed class MTHD_21ae77099a824f139a66070504f78eb9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_21ae77099a824f139a66070504f78eb9()
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

      private sealed class MTHD_5409e1c8922d4563b0a03974dac9d267 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5409e1c8922d4563b0a03974dac9d267()
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

      private sealed class MTHD_1f689af42aad46d5880e468271e2f558 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f689af42aad46d5880e468271e2f558()
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

      private sealed class MTHD_0464be64a41a45af9102abac63e751ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0464be64a41a45af9102abac63e751ae()
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

      private sealed class MTHD_4dccbf3a0a0f48ba9a19a51e2077aa70 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4dccbf3a0a0f48ba9a19a51e2077aa70()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_9b8066f1d39e4792b33fbd37809c53af : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b8066f1d39e4792b33fbd37809c53af()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_cb3d8aaf6097413197a1f5fa769b136f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cb3d8aaf6097413197a1f5fa769b136f()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_71acc215753244b6bb33f1ece1474335 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_71acc215753244b6bb33f1ece1474335()
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

      private sealed class MTHD_8f08e2ac895e405f941dfde919bf7203 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8f08e2ac895e405f941dfde919bf7203()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_f0c7b3dedf484ed39d87b0bd15d0046d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f0c7b3dedf484ed39d87b0bd15d0046d()
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

      private sealed class MTHD_c82b9012d62d42f9a6938241f78097cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c82b9012d62d42f9a6938241f78097cd()
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

      private sealed class MTHD_fc646db4dfb2424db2edd53522395d2f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fc646db4dfb2424db2edd53522395d2f()
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

      private sealed class MTHD_6123946e150142deb4b095a86c2cdea2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6123946e150142deb4b095a86c2cdea2()
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

      private sealed class MTHD_802786bd264346b8a1b228af4140ae63 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_802786bd264346b8a1b228af4140ae63()
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

      private sealed class MTHD_926c95fd7ca64c9096f38eddfe25eb6a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_926c95fd7ca64c9096f38eddfe25eb6a()
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

      private sealed class MTHD_b531a63823b44c49b8438d558f2372f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b531a63823b44c49b8438d558f2372f6()
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

      private sealed class MTHD_54820d7331e941fe9497be56243becf2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_54820d7331e941fe9497be56243becf2()
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

      private sealed class MTHD_531512c8138543019687ccb4202e4909 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_531512c8138543019687ccb4202e4909()
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

      private sealed class MTHD_ece8ae11ae304cea980a597cc0473134 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ece8ae11ae304cea980a597cc0473134()
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

      private sealed class MTHD_406554b9695645bb95a90d836efa2304 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_406554b9695645bb95a90d836efa2304()
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

      private sealed class MTHD_41fb1b82cd94436583a149f78448788e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41fb1b82cd94436583a149f78448788e()
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

      private sealed class MTHD_bdc20d103d024811b3c5efa0d16d83a0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bdc20d103d024811b3c5efa0d16d83a0()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_894b7ad7c9714dfcb145283545d58287 : HardwiredMemberDescriptor
      {
        internal FLDV_894b7ad7c9714dfcb145283545d58287()
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

      private sealed class FLDV_ac7e182ac837474c80c4b9d6c1cdc15b : HardwiredMemberDescriptor
      {
        internal FLDV_ac7e182ac837474c80c4b9d6c1cdc15b()
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

    private sealed class TYPE_52f48af89e574b7aaf7c76895d129949 : HardwiredUserDataDescriptor
    {
      internal TYPE_52f48af89e574b7aaf7c76895d129949()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_52f48af89e574b7aaf7c76895d129949.MTHD_01160bc9412a4efc9fcca2b5946a206d()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_52f48af89e574b7aaf7c76895d129949.MTHD_53ae458610a1443ab8ca751d49364a46()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_52f48af89e574b7aaf7c76895d129949.MTHD_96d0576d3cb8493ab48f39d193547f05()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_52f48af89e574b7aaf7c76895d129949.MTHD_22652a66a7a94a069170466cf4db9eab()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_52f48af89e574b7aaf7c76895d129949.MTHD_c4651db0fc5e49abb7b2fb83a7a39c3e()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_52f48af89e574b7aaf7c76895d129949.MTHD_a6421f6fee99463c91a85051b8f2431e()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_52f48af89e574b7aaf7c76895d129949.FLDV_08772e2fb09b40ef879d891cac63bd33());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_52f48af89e574b7aaf7c76895d129949.FLDV_f2faf7a86dbb4bbba982f8849823de37());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_52f48af89e574b7aaf7c76895d129949.FLDV_5914d52ff01f45b2a63d8d30c68fdc0d());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_52f48af89e574b7aaf7c76895d129949.FLDV_e562dd8ffd6140e78966f3298485d865());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_52f48af89e574b7aaf7c76895d129949.FLDV_9c84746343de43fdaa0ede373446db5c());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_52f48af89e574b7aaf7c76895d129949.FLDV_729c87954bdb43e596042abc13ec5431());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_52f48af89e574b7aaf7c76895d129949.FLDV_a5d3cfdf59d74246b9d6a3db9365b882());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_52f48af89e574b7aaf7c76895d129949.FLDV_7c07ec71c4184e2a90d4b79693ccc3cc());
        this.AddMember("prestige", (IMemberDescriptor) new Bridge.TYPE_52f48af89e574b7aaf7c76895d129949.FLDV_24cb0b1733bb45a19f3219a099ebf8cb());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_52f48af89e574b7aaf7c76895d129949.FLDV_60dc47b3eaed4941869667cc56e0bbc1());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_52f48af89e574b7aaf7c76895d129949.FLDV_6cd5269a620742cdac96d6ffdfd8a62c());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_52f48af89e574b7aaf7c76895d129949.FLDV_25135ea15d4942098057c64d80878a33());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_52f48af89e574b7aaf7c76895d129949.FLDV_fa64e75dbb484e5cb62e478ecb5c0b01());
      }

      private sealed class MTHD_01160bc9412a4efc9fcca2b5946a206d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_01160bc9412a4efc9fcca2b5946a206d()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_53ae458610a1443ab8ca751d49364a46 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_53ae458610a1443ab8ca751d49364a46()
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

      private sealed class MTHD_96d0576d3cb8493ab48f39d193547f05 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_96d0576d3cb8493ab48f39d193547f05()
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

      private sealed class MTHD_22652a66a7a94a069170466cf4db9eab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22652a66a7a94a069170466cf4db9eab()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_c4651db0fc5e49abb7b2fb83a7a39c3e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c4651db0fc5e49abb7b2fb83a7a39c3e()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_a6421f6fee99463c91a85051b8f2431e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6421f6fee99463c91a85051b8f2431e()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_08772e2fb09b40ef879d891cac63bd33 : HardwiredMemberDescriptor
      {
        internal FLDV_08772e2fb09b40ef879d891cac63bd33()
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

      private sealed class FLDV_f2faf7a86dbb4bbba982f8849823de37 : HardwiredMemberDescriptor
      {
        internal FLDV_f2faf7a86dbb4bbba982f8849823de37()
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

      private sealed class FLDV_5914d52ff01f45b2a63d8d30c68fdc0d : HardwiredMemberDescriptor
      {
        internal FLDV_5914d52ff01f45b2a63d8d30c68fdc0d()
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

      private sealed class FLDV_e562dd8ffd6140e78966f3298485d865 : HardwiredMemberDescriptor
      {
        internal FLDV_e562dd8ffd6140e78966f3298485d865()
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

      private sealed class FLDV_9c84746343de43fdaa0ede373446db5c : HardwiredMemberDescriptor
      {
        internal FLDV_9c84746343de43fdaa0ede373446db5c()
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

      private sealed class FLDV_729c87954bdb43e596042abc13ec5431 : HardwiredMemberDescriptor
      {
        internal FLDV_729c87954bdb43e596042abc13ec5431()
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

      private sealed class FLDV_a5d3cfdf59d74246b9d6a3db9365b882 : HardwiredMemberDescriptor
      {
        internal FLDV_a5d3cfdf59d74246b9d6a3db9365b882()
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

      private sealed class FLDV_7c07ec71c4184e2a90d4b79693ccc3cc : HardwiredMemberDescriptor
      {
        internal FLDV_7c07ec71c4184e2a90d4b79693ccc3cc()
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

      private sealed class FLDV_24cb0b1733bb45a19f3219a099ebf8cb : HardwiredMemberDescriptor
      {
        internal FLDV_24cb0b1733bb45a19f3219a099ebf8cb()
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

      private sealed class FLDV_60dc47b3eaed4941869667cc56e0bbc1 : HardwiredMemberDescriptor
      {
        internal FLDV_60dc47b3eaed4941869667cc56e0bbc1()
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

      private sealed class FLDV_6cd5269a620742cdac96d6ffdfd8a62c : HardwiredMemberDescriptor
      {
        internal FLDV_6cd5269a620742cdac96d6ffdfd8a62c()
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

      private sealed class FLDV_25135ea15d4942098057c64d80878a33 : HardwiredMemberDescriptor
      {
        internal FLDV_25135ea15d4942098057c64d80878a33()
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

      private sealed class FLDV_fa64e75dbb484e5cb62e478ecb5c0b01 : HardwiredMemberDescriptor
      {
        internal FLDV_fa64e75dbb484e5cb62e478ecb5c0b01()
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

    private sealed class TYPE_cb3b7ac41d68418f87fd167664cf2edb : HardwiredUserDataDescriptor
    {
      internal TYPE_cb3b7ac41d68418f87fd167664cf2edb()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_ef710fb58ef34027b9f8099c02b295b4()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_a675366d053e46edb13195ba0370370e()
        }));
        this.AddMember("get_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_35c1e507ef744434981acdd278b5d0ae()
        }));
        this.AddMember("set_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_689fcf07fb8d4aabb05ada9d2bf7768f()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_c33819f896c84af886ab04bf8a58b26f()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_3fd2f4d3ccf445bc9e87860e0212dc60()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_4d3ed7d01e6c43219ca14d5a9dda4745()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_cd0eede5f7f749dcabcd65f8691e6625()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_d5298bfef731425a92ed85b35a9e6584()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_1eb946c06375413eb068f0b913c6f165()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_96c145b936ee4b6d9e46ea400fd85204()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_4278624b2be54e22b8486a2a777f0293()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_770cc7a5a2404f11934b52aa69bb68ec()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_64d733d8bce74cb58da4ec1a97f76a90()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_db7e81cca9544c208493eeb74adedf69()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_b4e5dc1e073c4c51bdc7edb23e6b0047()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_889d92ba19dc4f848990da3f9b61d15c()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_63f0b666c46a4747b56ca1a11dfcf45a()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_878002b1d064480a90fcedeb57695039()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_accb4ab626cd4400afb58fac9dffdae6()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_22b7e19154dc44bc83c260ab80f93b82()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_b143fc491ea14d3b90a521dede047d2b()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_c1d81a05a1c04406a5988e0f46f4cf73()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_045363b986c349b6a6e2ed1a7662f503()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_a23f2628846442b9a0b7ab3fbfe58afb()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_5fbea2f92b2348b4991ed5f33d34b0be()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_a57f9c81cfad451d8195856b66a09849()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_4d6b20d00ac34e5eb4126111a201bbdd()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_ba9e73641b4a4743870a07095ab1b15e()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_b293f65b2c7d494d8efb2ae655be7634()
        }));
        this.AddMember("get_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_1a0713f3b4e4436b87a3f77d97ff4c73()
        }));
        this.AddMember("set_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_f738b2e1dab3409a880e57463d74118e()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_f9b148bda706414c9b71a76305d4ba5b()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_1fe0f42f1a564d15ba039fd955070006()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_3f01dd51cfe14e158caca06c2712f59a()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_e5056089487245209da28526334e11fe()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_f830d453350b450d9be357154dda32e6()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_ea35afe4af004919a8ad5670820aeda0()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_a97d55c840bd4979af516148f25d3cc1()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_ce13c4779153456a9dc410960680a76e()
        }));
        this.AddMember("get_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_1dd024f0c0a444de8823fecce08413e8()
        }));
        this.AddMember("set_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_5a101ca1f26d40c183f5834f24f67902()
        }));
        this.AddMember("get_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_9d71d73be29f4496af71044998337365()
        }));
        this.AddMember("set_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_ee03c9bb1af146afacf7f58016373ed6()
        }));
        this.AddMember("get_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_01caab397ef04168939ef1a6728dfd27()
        }));
        this.AddMember("set_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_acc45a3478a34db484a0f29cbd159c21()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_ea176348668146f4b2f58a8397923072()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_ddbf4d03551c4fae8d27771c96096b1e()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_c9328cbbecd84d44ba5e025d2ec0c599()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_5414b98a912e434d9aeb9dbdcceab444()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_cd51d0076b5f4347b60e2284a6f06684()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_51ab8af940744fcab58b8d65d7ad0055()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_f7b5f755355c4187b17d17821a47decf()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_a7df8d4714e24bb3bbda37b6b58c9fdb()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_7c4b7678672b4a41b98e10e4bbb38fcc()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_20b50c38c5ff4ae3bfe79909263cae07()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_7b9b641f48ff4a6d9823e62cf531fb03()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_611774b8bf1f4d8ba61eba28d7e4de5e()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_5b5f482a005c4bd69c4454b1b479b758()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.MTHD_cdd6f58a620141dfb74dab5d1a023153()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.PROP_aea241383b654730a5c48441bf087d5a());
        this.AddMember("visible", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.PROP_af3957195fe141deb832c6ee89f9b8cb());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.PROP_9881ead007af40aabb6b0e13ec834c6c());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.PROP_48cd2126fda54cd9836e4810aa57312e());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.PROP_b90042a782b34252a33d934a03fa7f1c());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.PROP_26ea2c84ec01412085cd522fe73ab3e0());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.PROP_bbf5eebbb10b42d8b239ec3485bc630c());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.PROP_bb2e20cf12274b90806eeea62e2841a0());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.PROP_00cfd036009642d886825c43fe768d1b());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.PROP_d8a0a78b52be499ca11159228a209ed8());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.PROP_709ff46d70ae42d4a2f50dc72a4c3fed());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.PROP_8542e4b61ea34bc5818e31fa6c4cb44c());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.PROP_13172c9149f3435fa082e0c656eccbd2());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.PROP_1e9041f00cd74933a2ed1cff8abd0bec());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.PROP_f77bf42b10044d878f984e30ecc6667e());
        this.AddMember("onClick2", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.PROP_bfe5dec6bb4349fcb1098fdbf34a7b41());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.PROP_03aaf936227440f3a46fdad6eb226daf());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.PROP_908967dd90b24fee9105e1f03be8f05b());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.PROP_5e6614077e25402995414aeaa6713f82());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.PROP_d3142258e6bf4fba8a8c03465134ccdc());
        this.AddMember("textColor2", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.PROP_b813412d7c4743d288b1b6b7123f48ed());
        this.AddMember("highlightColor", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.PROP_52fe1418e6444877a07b2fa21b11723b());
        this.AddMember("highlightColor2", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.PROP_bc56109a1d154b679485d0c35b93a26e());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.PROP_4301625ea055451a949d251d388a2315());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.PROP_d5eb53ec07714fe1a40ca986b762d055());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.FLDV_bf2628fd8492496b9696180ad9c6f131());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.FLDV_91b121c11a8d429bac91614f10cb317f());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_cb3b7ac41d68418f87fd167664cf2edb.FLDV_66b7633c9b5e41b38dc593b387b9f031());
      }

      private sealed class MTHD_ef710fb58ef34027b9f8099c02b295b4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef710fb58ef34027b9f8099c02b295b4()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_a675366d053e46edb13195ba0370370e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a675366d053e46edb13195ba0370370e()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_35c1e507ef744434981acdd278b5d0ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35c1e507ef744434981acdd278b5d0ae()
        {
          this.Initialize("get_visible", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).visible;
        }
      }

      private sealed class MTHD_689fcf07fb8d4aabb05ada9d2bf7768f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_689fcf07fb8d4aabb05ada9d2bf7768f()
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

      private sealed class MTHD_c33819f896c84af886ab04bf8a58b26f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c33819f896c84af886ab04bf8a58b26f()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_3fd2f4d3ccf445bc9e87860e0212dc60 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3fd2f4d3ccf445bc9e87860e0212dc60()
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

      private sealed class MTHD_4d3ed7d01e6c43219ca14d5a9dda4745 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d3ed7d01e6c43219ca14d5a9dda4745()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_cd0eede5f7f749dcabcd65f8691e6625 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd0eede5f7f749dcabcd65f8691e6625()
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

      private sealed class MTHD_d5298bfef731425a92ed85b35a9e6584 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d5298bfef731425a92ed85b35a9e6584()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_1eb946c06375413eb068f0b913c6f165 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1eb946c06375413eb068f0b913c6f165()
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

      private sealed class MTHD_96c145b936ee4b6d9e46ea400fd85204 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_96c145b936ee4b6d9e46ea400fd85204()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_4278624b2be54e22b8486a2a777f0293 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4278624b2be54e22b8486a2a777f0293()
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

      private sealed class MTHD_770cc7a5a2404f11934b52aa69bb68ec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_770cc7a5a2404f11934b52aa69bb68ec()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_64d733d8bce74cb58da4ec1a97f76a90 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_64d733d8bce74cb58da4ec1a97f76a90()
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

      private sealed class MTHD_db7e81cca9544c208493eeb74adedf69 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db7e81cca9544c208493eeb74adedf69()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_b4e5dc1e073c4c51bdc7edb23e6b0047 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b4e5dc1e073c4c51bdc7edb23e6b0047()
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

      private sealed class MTHD_889d92ba19dc4f848990da3f9b61d15c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_889d92ba19dc4f848990da3f9b61d15c()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_63f0b666c46a4747b56ca1a11dfcf45a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_63f0b666c46a4747b56ca1a11dfcf45a()
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

      private sealed class MTHD_878002b1d064480a90fcedeb57695039 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_878002b1d064480a90fcedeb57695039()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_accb4ab626cd4400afb58fac9dffdae6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_accb4ab626cd4400afb58fac9dffdae6()
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

      private sealed class MTHD_22b7e19154dc44bc83c260ab80f93b82 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22b7e19154dc44bc83c260ab80f93b82()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_b143fc491ea14d3b90a521dede047d2b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b143fc491ea14d3b90a521dede047d2b()
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

      private sealed class MTHD_c1d81a05a1c04406a5988e0f46f4cf73 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c1d81a05a1c04406a5988e0f46f4cf73()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_045363b986c349b6a6e2ed1a7662f503 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_045363b986c349b6a6e2ed1a7662f503()
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

      private sealed class MTHD_a23f2628846442b9a0b7ab3fbfe58afb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a23f2628846442b9a0b7ab3fbfe58afb()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_5fbea2f92b2348b4991ed5f33d34b0be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5fbea2f92b2348b4991ed5f33d34b0be()
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

      private sealed class MTHD_a57f9c81cfad451d8195856b66a09849 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a57f9c81cfad451d8195856b66a09849()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_4d6b20d00ac34e5eb4126111a201bbdd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d6b20d00ac34e5eb4126111a201bbdd()
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

      private sealed class MTHD_ba9e73641b4a4743870a07095ab1b15e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba9e73641b4a4743870a07095ab1b15e()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_b293f65b2c7d494d8efb2ae655be7634 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b293f65b2c7d494d8efb2ae655be7634()
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

      private sealed class MTHD_1a0713f3b4e4436b87a3f77d97ff4c73 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a0713f3b4e4436b87a3f77d97ff4c73()
        {
          this.Initialize("get_onClick2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick2;
        }
      }

      private sealed class MTHD_f738b2e1dab3409a880e57463d74118e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f738b2e1dab3409a880e57463d74118e()
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

      private sealed class MTHD_f9b148bda706414c9b71a76305d4ba5b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f9b148bda706414c9b71a76305d4ba5b()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_1fe0f42f1a564d15ba039fd955070006 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1fe0f42f1a564d15ba039fd955070006()
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

      private sealed class MTHD_3f01dd51cfe14e158caca06c2712f59a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f01dd51cfe14e158caca06c2712f59a()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color2;
        }
      }

      private sealed class MTHD_e5056089487245209da28526334e11fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e5056089487245209da28526334e11fe()
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

      private sealed class MTHD_f830d453350b450d9be357154dda32e6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f830d453350b450d9be357154dda32e6()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_ea35afe4af004919a8ad5670820aeda0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea35afe4af004919a8ad5670820aeda0()
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

      private sealed class MTHD_a97d55c840bd4979af516148f25d3cc1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a97d55c840bd4979af516148f25d3cc1()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_ce13c4779153456a9dc410960680a76e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ce13c4779153456a9dc410960680a76e()
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

      private sealed class MTHD_1dd024f0c0a444de8823fecce08413e8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1dd024f0c0a444de8823fecce08413e8()
        {
          this.Initialize("get_textColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor2;
        }
      }

      private sealed class MTHD_5a101ca1f26d40c183f5834f24f67902 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5a101ca1f26d40c183f5834f24f67902()
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

      private sealed class MTHD_9d71d73be29f4496af71044998337365 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d71d73be29f4496af71044998337365()
        {
          this.Initialize("get_highlightColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor;
        }
      }

      private sealed class MTHD_ee03c9bb1af146afacf7f58016373ed6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee03c9bb1af146afacf7f58016373ed6()
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

      private sealed class MTHD_01caab397ef04168939ef1a6728dfd27 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_01caab397ef04168939ef1a6728dfd27()
        {
          this.Initialize("get_highlightColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor2;
        }
      }

      private sealed class MTHD_acc45a3478a34db484a0f29cbd159c21 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_acc45a3478a34db484a0f29cbd159c21()
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

      private sealed class MTHD_ea176348668146f4b2f58a8397923072 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea176348668146f4b2f58a8397923072()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_ddbf4d03551c4fae8d27771c96096b1e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ddbf4d03551c4fae8d27771c96096b1e()
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

      private sealed class MTHD_c9328cbbecd84d44ba5e025d2ec0c599 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c9328cbbecd84d44ba5e025d2ec0c599()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_5414b98a912e434d9aeb9dbdcceab444 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5414b98a912e434d9aeb9dbdcceab444()
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

      private sealed class MTHD_cd51d0076b5f4347b60e2284a6f06684 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd51d0076b5f4347b60e2284a6f06684()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_51ab8af940744fcab58b8d65d7ad0055 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_51ab8af940744fcab58b8d65d7ad0055()
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

      private sealed class MTHD_f7b5f755355c4187b17d17821a47decf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7b5f755355c4187b17d17821a47decf()
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

      private sealed class MTHD_a7df8d4714e24bb3bbda37b6b58c9fdb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a7df8d4714e24bb3bbda37b6b58c9fdb()
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

      private sealed class MTHD_7c4b7678672b4a41b98e10e4bbb38fcc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7c4b7678672b4a41b98e10e4bbb38fcc()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_20b50c38c5ff4ae3bfe79909263cae07 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_20b50c38c5ff4ae3bfe79909263cae07()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_7b9b641f48ff4a6d9823e62cf531fb03 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b9b641f48ff4a6d9823e62cf531fb03()
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

      private sealed class MTHD_611774b8bf1f4d8ba61eba28d7e4de5e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_611774b8bf1f4d8ba61eba28d7e4de5e()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_5b5f482a005c4bd69c4454b1b479b758 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b5f482a005c4bd69c4454b1b479b758()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_cdd6f58a620141dfb74dab5d1a023153 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cdd6f58a620141dfb74dab5d1a023153()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_aea241383b654730a5c48441bf087d5a : HardwiredMemberDescriptor
      {
        internal PROP_aea241383b654730a5c48441bf087d5a()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_af3957195fe141deb832c6ee89f9b8cb : HardwiredMemberDescriptor
      {
        internal PROP_af3957195fe141deb832c6ee89f9b8cb()
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

      private sealed class PROP_9881ead007af40aabb6b0e13ec834c6c : HardwiredMemberDescriptor
      {
        internal PROP_9881ead007af40aabb6b0e13ec834c6c()
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

      private sealed class PROP_48cd2126fda54cd9836e4810aa57312e : HardwiredMemberDescriptor
      {
        internal PROP_48cd2126fda54cd9836e4810aa57312e()
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

      private sealed class PROP_b90042a782b34252a33d934a03fa7f1c : HardwiredMemberDescriptor
      {
        internal PROP_b90042a782b34252a33d934a03fa7f1c()
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

      private sealed class PROP_26ea2c84ec01412085cd522fe73ab3e0 : HardwiredMemberDescriptor
      {
        internal PROP_26ea2c84ec01412085cd522fe73ab3e0()
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

      private sealed class PROP_bbf5eebbb10b42d8b239ec3485bc630c : HardwiredMemberDescriptor
      {
        internal PROP_bbf5eebbb10b42d8b239ec3485bc630c()
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

      private sealed class PROP_bb2e20cf12274b90806eeea62e2841a0 : HardwiredMemberDescriptor
      {
        internal PROP_bb2e20cf12274b90806eeea62e2841a0()
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

      private sealed class PROP_00cfd036009642d886825c43fe768d1b : HardwiredMemberDescriptor
      {
        internal PROP_00cfd036009642d886825c43fe768d1b()
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

      private sealed class PROP_d8a0a78b52be499ca11159228a209ed8 : HardwiredMemberDescriptor
      {
        internal PROP_d8a0a78b52be499ca11159228a209ed8()
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

      private sealed class PROP_709ff46d70ae42d4a2f50dc72a4c3fed : HardwiredMemberDescriptor
      {
        internal PROP_709ff46d70ae42d4a2f50dc72a4c3fed()
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

      private sealed class PROP_8542e4b61ea34bc5818e31fa6c4cb44c : HardwiredMemberDescriptor
      {
        internal PROP_8542e4b61ea34bc5818e31fa6c4cb44c()
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

      private sealed class PROP_13172c9149f3435fa082e0c656eccbd2 : HardwiredMemberDescriptor
      {
        internal PROP_13172c9149f3435fa082e0c656eccbd2()
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

      private sealed class PROP_1e9041f00cd74933a2ed1cff8abd0bec : HardwiredMemberDescriptor
      {
        internal PROP_1e9041f00cd74933a2ed1cff8abd0bec()
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

      private sealed class PROP_f77bf42b10044d878f984e30ecc6667e : HardwiredMemberDescriptor
      {
        internal PROP_f77bf42b10044d878f984e30ecc6667e()
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

      private sealed class PROP_bfe5dec6bb4349fcb1098fdbf34a7b41 : HardwiredMemberDescriptor
      {
        internal PROP_bfe5dec6bb4349fcb1098fdbf34a7b41()
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

      private sealed class PROP_03aaf936227440f3a46fdad6eb226daf : HardwiredMemberDescriptor
      {
        internal PROP_03aaf936227440f3a46fdad6eb226daf()
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

      private sealed class PROP_908967dd90b24fee9105e1f03be8f05b : HardwiredMemberDescriptor
      {
        internal PROP_908967dd90b24fee9105e1f03be8f05b()
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

      private sealed class PROP_5e6614077e25402995414aeaa6713f82 : HardwiredMemberDescriptor
      {
        internal PROP_5e6614077e25402995414aeaa6713f82()
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

      private sealed class PROP_d3142258e6bf4fba8a8c03465134ccdc : HardwiredMemberDescriptor
      {
        internal PROP_d3142258e6bf4fba8a8c03465134ccdc()
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

      private sealed class PROP_b813412d7c4743d288b1b6b7123f48ed : HardwiredMemberDescriptor
      {
        internal PROP_b813412d7c4743d288b1b6b7123f48ed()
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

      private sealed class PROP_52fe1418e6444877a07b2fa21b11723b : HardwiredMemberDescriptor
      {
        internal PROP_52fe1418e6444877a07b2fa21b11723b()
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

      private sealed class PROP_bc56109a1d154b679485d0c35b93a26e : HardwiredMemberDescriptor
      {
        internal PROP_bc56109a1d154b679485d0c35b93a26e()
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

      private sealed class PROP_4301625ea055451a949d251d388a2315 : HardwiredMemberDescriptor
      {
        internal PROP_4301625ea055451a949d251d388a2315()
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

      private sealed class PROP_d5eb53ec07714fe1a40ca986b762d055 : HardwiredMemberDescriptor
      {
        internal PROP_d5eb53ec07714fe1a40ca986b762d055()
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

      private sealed class FLDV_bf2628fd8492496b9696180ad9c6f131 : HardwiredMemberDescriptor
      {
        internal FLDV_bf2628fd8492496b9696180ad9c6f131()
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

      private sealed class FLDV_91b121c11a8d429bac91614f10cb317f : HardwiredMemberDescriptor
      {
        internal FLDV_91b121c11a8d429bac91614f10cb317f()
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

      private sealed class FLDV_66b7633c9b5e41b38dc593b387b9f031 : HardwiredMemberDescriptor
      {
        internal FLDV_66b7633c9b5e41b38dc593b387b9f031()
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

    private sealed class TYPE_52843e23609749608e698e80341a2330 : HardwiredUserDataDescriptor
    {
      internal TYPE_52843e23609749608e698e80341a2330()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_52843e23609749608e698e80341a2330.MTHD_a8f676912dc044c2bab78b70f691cb1c()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_52843e23609749608e698e80341a2330.MTHD_b449d367bf1d4071babc08719f72c66f()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_52843e23609749608e698e80341a2330.MTHD_3278249c4bdf407da0fe3a4c019cc41f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_52843e23609749608e698e80341a2330.MTHD_881b3b820f7441269ca19d607df419de()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_52843e23609749608e698e80341a2330.MTHD_b503f23461f04b269370c71e41427dbf()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_52843e23609749608e698e80341a2330.MTHD_b5894ed9a58b4b909c23accbbde6fedb()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_52843e23609749608e698e80341a2330.FLDV_4f40e5f7a512492f9e29e21f7d85e450());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_52843e23609749608e698e80341a2330.FLDV_46f9094d90234de5856660a4cb36c673());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_52843e23609749608e698e80341a2330.FLDV_328e5f68674c40cbb2992c462a9ebca4());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_52843e23609749608e698e80341a2330.FLDV_e1e47a51cfc1444b8f1cafcb5266678b());
      }

      private sealed class MTHD_a8f676912dc044c2bab78b70f691cb1c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a8f676912dc044c2bab78b70f691cb1c()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_b449d367bf1d4071babc08719f72c66f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b449d367bf1d4071babc08719f72c66f()
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

      private sealed class MTHD_3278249c4bdf407da0fe3a4c019cc41f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3278249c4bdf407da0fe3a4c019cc41f()
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

      private sealed class MTHD_881b3b820f7441269ca19d607df419de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_881b3b820f7441269ca19d607df419de()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_b503f23461f04b269370c71e41427dbf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b503f23461f04b269370c71e41427dbf()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_b5894ed9a58b4b909c23accbbde6fedb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b5894ed9a58b4b909c23accbbde6fedb()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_4f40e5f7a512492f9e29e21f7d85e450 : HardwiredMemberDescriptor
      {
        internal FLDV_4f40e5f7a512492f9e29e21f7d85e450()
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

      private sealed class FLDV_46f9094d90234de5856660a4cb36c673 : HardwiredMemberDescriptor
      {
        internal FLDV_46f9094d90234de5856660a4cb36c673()
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

      private sealed class FLDV_328e5f68674c40cbb2992c462a9ebca4 : HardwiredMemberDescriptor
      {
        internal FLDV_328e5f68674c40cbb2992c462a9ebca4()
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

      private sealed class FLDV_e1e47a51cfc1444b8f1cafcb5266678b : HardwiredMemberDescriptor
      {
        internal FLDV_e1e47a51cfc1444b8f1cafcb5266678b()
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

    private sealed class TYPE_3ebb49b7400445a581ffdbfd4443bb8e : HardwiredUserDataDescriptor
    {
      internal TYPE_3ebb49b7400445a581ffdbfd4443bb8e()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ebb49b7400445a581ffdbfd4443bb8e.MTHD_91f4b1a473db48169758e9e714d8e202()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ebb49b7400445a581ffdbfd4443bb8e.MTHD_5297b1ac394a442fadfe7b2b1715cfcc()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ebb49b7400445a581ffdbfd4443bb8e.MTHD_23a3648891a743d8ada50998f8dbb278()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ebb49b7400445a581ffdbfd4443bb8e.MTHD_cf7c3225c3a14d66a1aad998738dbd8b()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3ebb49b7400445a581ffdbfd4443bb8e.MTHD_43dd973948c34fb2848f90f8d9e2a56a()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_3ebb49b7400445a581ffdbfd4443bb8e.FLDV_541cb7b32bec431aa373f91c16aee8f4());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_3ebb49b7400445a581ffdbfd4443bb8e.FLDV_6a7708d840a04e198c81699bb58093b7());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_3ebb49b7400445a581ffdbfd4443bb8e.FLDV_d7ed18b5d9b3466faaf359fe6de22cc4());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_3ebb49b7400445a581ffdbfd4443bb8e.FLDV_1456436624684ecd8818ac7770577291());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_3ebb49b7400445a581ffdbfd4443bb8e.FLDV_713b95021b524d62aaee6d93413cf351());
      }

      private sealed class MTHD_91f4b1a473db48169758e9e714d8e202 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_91f4b1a473db48169758e9e714d8e202()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_5297b1ac394a442fadfe7b2b1715cfcc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5297b1ac394a442fadfe7b2b1715cfcc()
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

      private sealed class MTHD_23a3648891a743d8ada50998f8dbb278 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_23a3648891a743d8ada50998f8dbb278()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_cf7c3225c3a14d66a1aad998738dbd8b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf7c3225c3a14d66a1aad998738dbd8b()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_43dd973948c34fb2848f90f8d9e2a56a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_43dd973948c34fb2848f90f8d9e2a56a()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_541cb7b32bec431aa373f91c16aee8f4 : HardwiredMemberDescriptor
      {
        internal FLDV_541cb7b32bec431aa373f91c16aee8f4()
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

      private sealed class FLDV_6a7708d840a04e198c81699bb58093b7 : HardwiredMemberDescriptor
      {
        internal FLDV_6a7708d840a04e198c81699bb58093b7()
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

      private sealed class FLDV_d7ed18b5d9b3466faaf359fe6de22cc4 : HardwiredMemberDescriptor
      {
        internal FLDV_d7ed18b5d9b3466faaf359fe6de22cc4()
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

      private sealed class FLDV_1456436624684ecd8818ac7770577291 : HardwiredMemberDescriptor
      {
        internal FLDV_1456436624684ecd8818ac7770577291()
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

      private sealed class FLDV_713b95021b524d62aaee6d93413cf351 : HardwiredMemberDescriptor
      {
        internal FLDV_713b95021b524d62aaee6d93413cf351()
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

    private sealed class TYPE_3a58d73029104c93bfd3531d22b3fad5 : HardwiredUserDataDescriptor
    {
      internal TYPE_3a58d73029104c93bfd3531d22b3fad5()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3a58d73029104c93bfd3531d22b3fad5.MTHD_1e6e6eabdc9a466a822c2dbabd29f969()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3a58d73029104c93bfd3531d22b3fad5.MTHD_7954c166de514b48bb9dc7ef512deba4()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3a58d73029104c93bfd3531d22b3fad5.MTHD_e81aa38846f8435a9fad024c880d2112()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3a58d73029104c93bfd3531d22b3fad5.MTHD_107beebab0c846248ab7c8fb092cf924()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3a58d73029104c93bfd3531d22b3fad5.MTHD_999441a2b1154077841cb24034f030b5()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3a58d73029104c93bfd3531d22b3fad5.MTHD_5f465d8408dc47a391e8c0292eba13f1()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3a58d73029104c93bfd3531d22b3fad5.MTHD_21e68055c295492c9c1b2ca15b8da8fc()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3a58d73029104c93bfd3531d22b3fad5.MTHD_6be169e66a3b43ce93aa05286797f10b()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3a58d73029104c93bfd3531d22b3fad5.MTHD_35ae5a954c6c424c83deba3679eff50c()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3a58d73029104c93bfd3531d22b3fad5.MTHD_27eca8e669874d30bde3b857e883e5c9()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3a58d73029104c93bfd3531d22b3fad5.MTHD_57ef8a21f37b42ee80510b0a095904e2()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3a58d73029104c93bfd3531d22b3fad5.MTHD_3768a3dcc4204a1a97c8e8e12a7ca6ac()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3a58d73029104c93bfd3531d22b3fad5.MTHD_5e9ba03d13d449ad8dca795dfa92539f()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_3a58d73029104c93bfd3531d22b3fad5.FLDV_9a38bb75732e400c955372727f1a806a());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_3a58d73029104c93bfd3531d22b3fad5.FLDV_71925c2d5f434813af5ec4e7f7a47532());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_3a58d73029104c93bfd3531d22b3fad5.FLDV_d91a90a1a21b48489ebbb15d85d7fc7d());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_3a58d73029104c93bfd3531d22b3fad5.FLDV_72a2e55ca661442b9c80d5a002492b1c());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_3a58d73029104c93bfd3531d22b3fad5.FLDV_2d5ee2894dae43b18e2b6d91bf139d79());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_3a58d73029104c93bfd3531d22b3fad5.FLDV_1a9823b1c91a4b1682be0e7e444ce97b());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_3a58d73029104c93bfd3531d22b3fad5.FLDV_d235d8b196b24cb189c8af9ff41ba55e());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_3a58d73029104c93bfd3531d22b3fad5.FLDV_c8eeb29ef8c34d06b50e5b64b02900c1());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_3a58d73029104c93bfd3531d22b3fad5.DVAL_a992c4b5bbef4c058acc7fe98a091e9e());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_3a58d73029104c93bfd3531d22b3fad5.DVAL_443e579b2f244c468c0b0e34184704c8());
      }

      private sealed class MTHD_1e6e6eabdc9a466a822c2dbabd29f969 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1e6e6eabdc9a466a822c2dbabd29f969()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_7954c166de514b48bb9dc7ef512deba4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7954c166de514b48bb9dc7ef512deba4()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_e81aa38846f8435a9fad024c880d2112 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e81aa38846f8435a9fad024c880d2112()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_107beebab0c846248ab7c8fb092cf924 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_107beebab0c846248ab7c8fb092cf924()
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

      private sealed class MTHD_999441a2b1154077841cb24034f030b5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_999441a2b1154077841cb24034f030b5()
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

      private sealed class MTHD_5f465d8408dc47a391e8c0292eba13f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5f465d8408dc47a391e8c0292eba13f1()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_21e68055c295492c9c1b2ca15b8da8fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_21e68055c295492c9c1b2ca15b8da8fc()
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

      private sealed class MTHD_6be169e66a3b43ce93aa05286797f10b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6be169e66a3b43ce93aa05286797f10b()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_35ae5a954c6c424c83deba3679eff50c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35ae5a954c6c424c83deba3679eff50c()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_27eca8e669874d30bde3b857e883e5c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_27eca8e669874d30bde3b857e883e5c9()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_57ef8a21f37b42ee80510b0a095904e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57ef8a21f37b42ee80510b0a095904e2()
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

      private sealed class MTHD_3768a3dcc4204a1a97c8e8e12a7ca6ac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3768a3dcc4204a1a97c8e8e12a7ca6ac()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_5e9ba03d13d449ad8dca795dfa92539f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e9ba03d13d449ad8dca795dfa92539f()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_9a38bb75732e400c955372727f1a806a : HardwiredMemberDescriptor
      {
        internal FLDV_9a38bb75732e400c955372727f1a806a()
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

      private sealed class FLDV_71925c2d5f434813af5ec4e7f7a47532 : HardwiredMemberDescriptor
      {
        internal FLDV_71925c2d5f434813af5ec4e7f7a47532()
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

      private sealed class FLDV_d91a90a1a21b48489ebbb15d85d7fc7d : HardwiredMemberDescriptor
      {
        internal FLDV_d91a90a1a21b48489ebbb15d85d7fc7d()
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

      private sealed class FLDV_72a2e55ca661442b9c80d5a002492b1c : HardwiredMemberDescriptor
      {
        internal FLDV_72a2e55ca661442b9c80d5a002492b1c()
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

      private sealed class FLDV_2d5ee2894dae43b18e2b6d91bf139d79 : HardwiredMemberDescriptor
      {
        internal FLDV_2d5ee2894dae43b18e2b6d91bf139d79()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_1a9823b1c91a4b1682be0e7e444ce97b : HardwiredMemberDescriptor
      {
        internal FLDV_1a9823b1c91a4b1682be0e7e444ce97b()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_d235d8b196b24cb189c8af9ff41ba55e : HardwiredMemberDescriptor
      {
        internal FLDV_d235d8b196b24cb189c8af9ff41ba55e()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_c8eeb29ef8c34d06b50e5b64b02900c1 : HardwiredMemberDescriptor
      {
        internal FLDV_c8eeb29ef8c34d06b50e5b64b02900c1()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_a992c4b5bbef4c058acc7fe98a091e9e : DynValueMemberDescriptor
      {
        internal DVAL_a992c4b5bbef4c058acc7fe98a091e9e()
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

      private sealed class DVAL_443e579b2f244c468c0b0e34184704c8 : DynValueMemberDescriptor
      {
        internal DVAL_443e579b2f244c468c0b0e34184704c8()
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

    private sealed class TYPE_bc58f12d10f141f4bc44c9ec0a51c2d2 : HardwiredUserDataDescriptor
    {
      internal TYPE_bc58f12d10f141f4bc44c9ec0a51c2d2()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc58f12d10f141f4bc44c9ec0a51c2d2.MTHD_198c50efa06e48bba856d7765f5495d0()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc58f12d10f141f4bc44c9ec0a51c2d2.MTHD_990be25c69334b888ee3cf8b2fc02cbb()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc58f12d10f141f4bc44c9ec0a51c2d2.MTHD_dba71faa1c8b441aab91523f9a36af60(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc58f12d10f141f4bc44c9ec0a51c2d2.MTHD_a51c02d0642e4502afe859d7c4ad446f()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc58f12d10f141f4bc44c9ec0a51c2d2.MTHD_9e536a12e7b14ee5bc0ba47ccc23585e(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc58f12d10f141f4bc44c9ec0a51c2d2.MTHD_82a3d9362b0347c29a9d955684b2c627()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc58f12d10f141f4bc44c9ec0a51c2d2.MTHD_3f9e8e6f946f43ec830d06cb144ac1cb()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc58f12d10f141f4bc44c9ec0a51c2d2.MTHD_67ae49e5d77e4c299592ca3ac32a3046()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc58f12d10f141f4bc44c9ec0a51c2d2.MTHD_8b5381adf36741c982f960533422d086()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bc58f12d10f141f4bc44c9ec0a51c2d2.MTHD_f976a25fa4ac41379af74a3ed6240512()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_bc58f12d10f141f4bc44c9ec0a51c2d2.FLDV_c1964864d54348719b9b618beb63974d());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_bc58f12d10f141f4bc44c9ec0a51c2d2.FLDV_a1c428c6961e4c6ca6f06d1c62f3e12f());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_bc58f12d10f141f4bc44c9ec0a51c2d2.FLDV_f7cb9ea6392c405ab563f597d226e501());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_bc58f12d10f141f4bc44c9ec0a51c2d2.FLDV_03ca218f71a94775b5cc1f385dccce7d());
        this.AddMember("white", (IMemberDescriptor) new Bridge.TYPE_bc58f12d10f141f4bc44c9ec0a51c2d2.FLDV_5bf695c91cb1422a9aa58ae607a79978());
      }

      private sealed class MTHD_198c50efa06e48bba856d7765f5495d0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_198c50efa06e48bba856d7765f5495d0()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_990be25c69334b888ee3cf8b2fc02cbb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_990be25c69334b888ee3cf8b2fc02cbb()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_dba71faa1c8b441aab91523f9a36af60 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dba71faa1c8b441aab91523f9a36af60()
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

      private sealed class MTHD_a51c02d0642e4502afe859d7c4ad446f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a51c02d0642e4502afe859d7c4ad446f()
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

      private sealed class MTHD_9e536a12e7b14ee5bc0ba47ccc23585e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e536a12e7b14ee5bc0ba47ccc23585e()
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

      private sealed class MTHD_82a3d9362b0347c29a9d955684b2c627 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_82a3d9362b0347c29a9d955684b2c627()
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

      private sealed class MTHD_3f9e8e6f946f43ec830d06cb144ac1cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f9e8e6f946f43ec830d06cb144ac1cb()
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

      private sealed class MTHD_67ae49e5d77e4c299592ca3ac32a3046 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67ae49e5d77e4c299592ca3ac32a3046()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_8b5381adf36741c982f960533422d086 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b5381adf36741c982f960533422d086()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_f976a25fa4ac41379af74a3ed6240512 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f976a25fa4ac41379af74a3ed6240512()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_c1964864d54348719b9b618beb63974d : HardwiredMemberDescriptor
      {
        internal FLDV_c1964864d54348719b9b618beb63974d()
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

      private sealed class FLDV_a1c428c6961e4c6ca6f06d1c62f3e12f : HardwiredMemberDescriptor
      {
        internal FLDV_a1c428c6961e4c6ca6f06d1c62f3e12f()
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

      private sealed class FLDV_f7cb9ea6392c405ab563f597d226e501 : HardwiredMemberDescriptor
      {
        internal FLDV_f7cb9ea6392c405ab563f597d226e501()
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

      private sealed class FLDV_03ca218f71a94775b5cc1f385dccce7d : HardwiredMemberDescriptor
      {
        internal FLDV_03ca218f71a94775b5cc1f385dccce7d()
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

      private sealed class FLDV_5bf695c91cb1422a9aa58ae607a79978 : HardwiredMemberDescriptor
      {
        internal FLDV_5bf695c91cb1422a9aa58ae607a79978()
          : base(typeof (LuaColor), "white", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) LuaColor.white;
        }
      }
    }

    private sealed class TYPE_328613fd367846d6979d696ca54e609a : HardwiredUserDataDescriptor
    {
      internal TYPE_328613fd367846d6979d696ca54e609a()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_328613fd367846d6979d696ca54e609a.MTHD_f0aba740ec544e608f25e3f5b3ac96bb()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_328613fd367846d6979d696ca54e609a.MTHD_4b8960ffd2e34c4cafa62d2dc00bffb0()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_328613fd367846d6979d696ca54e609a.MTHD_024146c93b8e41c99b433abb68b07530()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_328613fd367846d6979d696ca54e609a.MTHD_8fd5665041124c74a3d46c7b65fe21c2()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_328613fd367846d6979d696ca54e609a.MTHD_c89e3236c4ec4bb7a6e68d69212e377a()
        }));
      }

      private sealed class MTHD_f0aba740ec544e608f25e3f5b3ac96bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f0aba740ec544e608f25e3f5b3ac96bb()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_4b8960ffd2e34c4cafa62d2dc00bffb0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b8960ffd2e34c4cafa62d2dc00bffb0()
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

      private sealed class MTHD_024146c93b8e41c99b433abb68b07530 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_024146c93b8e41c99b433abb68b07530()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_8fd5665041124c74a3d46c7b65fe21c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8fd5665041124c74a3d46c7b65fe21c2()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_c89e3236c4ec4bb7a6e68d69212e377a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c89e3236c4ec4bb7a6e68d69212e377a()
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
