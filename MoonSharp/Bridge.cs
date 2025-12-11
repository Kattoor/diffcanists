
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
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_7ba9145dde214f51a6898d579428d52b());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_f8767134a2b143e0bab7850c0c2de0bf());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_c960440644724b0395ca0ebeb628037f());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_fcf072b4c9e44ba7966a9891d40373af());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_f64f1c9929c8400d995c0ebd807208b3());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_2313f7ae9aa94795a3c762a2cc2e2062());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_b5e75d3fb9b349cfba754279c7eaa18b());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_1c35834dda6f4abdb79472b56b9f1fa2());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_b58f1adcaf2244a48f5a23c2c16a765c());
    }

    private sealed class TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc : HardwiredUserDataDescriptor
    {
      internal TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_bdcd38c61fb8434ab00cfc6efea7eeef()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_97283c007cf54aa1922f6362ae15bdfe()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_ee75c47bf022486baf462b90e1c2723b()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_2a993dad48b74fbcac6477673e886b6b()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_e2faa357a64849ec9ed9318752c9baeb()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_2666735b1cd64afbabceffd02923f1a6()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_f2c2075363a545d381ab1fbe69b89aed()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_9fa8493fd558484fb2454eeeb992e448()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_00fe507ecb2f480394cf9147b70dff3a()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_88db7afde53f461b8fe97e699ddfe24b()
        }));
        this.AddMember("hideInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("hideInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_c8982e5fb0c24b9081cec5907c35cdb5()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_efe437ace8f14e1d9eb6b978207df547()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_95e70fac5e284c67bea809c29d6b5f8a()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_2d2ba16c4cb24c94a2e88aeee171c389()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_d5a3943713754a7f8a423b79228ba3fb()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_486d462b0bbc45a6b69972a73dc9a735()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_e1520c3a5f1a4162b217ce19bce2a2c3()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_bef5e1fcbbbd4c93abeb8ccdffb4b8a3()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_83b217cd55344073a7c8b7058067abbd()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_ea720cb71f5b49c584e0aa2b78a72676()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_0f54a7c2ed364558a636ad83c654e6dc()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_159fe2c9aff8498b8647bf199f33b893()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_72d88966d7be46e8837aa97fec1d5c80()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_8312b72576364795987ab487e4db280f()
        }));
        this.AddMember("get_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_ba3fbf9872dc4c7da46a8c3513f96312()
        }));
        this.AddMember("set_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_bf56aa9a717b4658b7c3ece0cb6403fe()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_c63a216735e1458c82357baace66aa3a()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_45a264e1a28249af8a118fec453a6f43()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_439f1e7e199d41ab821f21b90f6377a0()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_0baeb0d84623467dbd64fc8348c7d020()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_285cee1c9f434dfeb2c131585a98e7a5()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_62f8fed24cb64a248e6b5108e14d4f5f()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_73540f0b41944000a43598542e26839e()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_a23ab2d027e94a1d9680dfc1304aa234()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_2564f7e792494c33832273e46d49a8c7()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_e681e53fbbb64c50850b26308fc21efc()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_19eb37d7717d46a5a30cf352d77213f1()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_9f7a0cff610847c1bdf8acd4bbf8d2b7()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_1472d15dfde046829d511bb2e81fb1a0()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_eccf802b0bd1457d9d46357d3adb40a9()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_093a17817c27484d982ad7283c95ebd5()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_df1c80c3d45c44c09929938e83c10eb1()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_fa879564f6454d59beaa50e69730708d()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_8262f5c0707649678bced1874ef2b1e0()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_803ab0d302404dd09dd5b9c0c9fe6556()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_c50434e598a74ea68e4f181ccdcfbc97()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_1d21c19a4fcd43ddb79310eb43722a99()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_f8f18c9386b743c4a4a3ca5dfe44d79a()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_6180c2e3f2c040349a5b7b880db10136()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_f9463911b2cd4f41bca44aae1b51703b()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_7f0328bf58404718a915e6ecaa546c9c()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_bb7898224a754510b4c2b5a33181f997()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_423cb67908d743bd9def627161bd4b79()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_879586f8d27747b6bd6c9f09de2e7de9()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_0db52348a41c48ea929b659daace2fb0()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_e2e2e5d18c314b6f8085b4207ed0b911()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_62e2d912e3f94e3d8f76bc634af25a62()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_1a8988be3ac3407ebde119991a0d8784()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_8f23de49538f492ea84d1f90afa60f1b()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_034e3b48a8c944c98ccdf4cc6e484f39()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_2252587e8b434aec9b64b7e9ea016883()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_fabd0d758f4e4c82a88aa7bc8cff5c3e()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_23817e08b55141a7af0c48b803e972d8()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_1e96512bbc2243d6b0760eac011f5f00()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_624f2f4caf46410aa9e58ff1e0d7c839()
        }));
        this.AddMember("Dispose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Dispose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_b801f27a27b444f8bfe98735d4f2372e()
        }));
        this.AddMember("drawImage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawImage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_fde8a9fbc6ae4fa29b88499efc5bcdad()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_dc4966d686604b10acb0811a23a21c15()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_c9b8655275d44921a73d31f3d2dad942()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_04386509fd4b45fdadf3f681e2a3b321()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_a53c01e2753e47cf8e2490871a2f7e68()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_cdbf4f9332e4495a97a2751ceeadd7d2()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_1aee7107ad934973b2ba4c52c2a8a631()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_fa1934a429354ae8b493bda63bbb8146()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_a41922082bdb41e083d4bde4f208170b()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_7e71159b1540406e95220777370182da()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_e41e3cd668c64b1ea6134f005b7543d2()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_7ea8914993ff4f3b9c510ca9f4680d47()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_d2a50d3c650649b891f3057c4107eee5()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_b488043334a64e78bf32b89ac3c810b4()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_ac290615539c4f5ba115b4e79ac87c33()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_59b8076a7d0c4105a5809c2c5601415c()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_74678d10bcb147fa9801cdf2ca404ab1()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_70891e7a35294f65927973bbb3875814()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_4783deeb132c466fbbddbecdfad53521()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_c236e6dc9be54415bc050a3277829eee()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_6aa6c81de6284a3096a9b61efb1f94c8()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_65d0737abfe84b7881dd45bf83dd28c7()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_fd9ee482a9ad488598c6654dcc8cce3c()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_31817e78f7784271824e953c30ddab8e()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_00b0f11eddb34b99ae7f4c3839a56b9b()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_3c3bc4509f0440268fc83566fc45174b()
        }));
        this.AddMember("cameraFollow", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("cameraFollow", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_e063e041a0c040eea9deb1d387ddeeaa()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_c2cdff89ea86412cb45865400d4bbb94()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_bee0d09960b04fd4990fac47cf270724()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_94088babe5474cfcb355eb909d7db3ef()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_3764daf75e1f4ae2af1a08596e8dcb2d()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_aef2d1950cb14f1cbe8a5230a0f36d40()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_1110594e9d4043ad934f5a3b4e9745bb(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_ec3d1434f1714b1b95c1b526ad999fb6()
        }));
        this.AddMember("getKeyBinds", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getKeyBinds", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_14b1c49c8b384bf1a547ae83deec4b91()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_f93c2c272d8b42ac8abca30959c8fd6f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_0b8dfa83e32540af939f974a69327649()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_99954f4b78244ad2b339b41ac66a5f08()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.MTHD_59e1377ff4b9419f9096674a7878c01c()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_441a10f9e2a64e98b6a97ef98fbc266c());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_6e6b2388295840f692896e5d9d33dab8());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_cc3d3ee8bc8045abbe20780f8d195647());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_569aeac10e0d441bbd5f242b76999bfc());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_45b5fc2f140d4c71ae3e22f191415c67());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_207b1772688940359bc17c8384b8fa3a());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_690eebeded6c44fe830cd880086a66a6());
        this.AddMember("allowMinionMovement", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_42fd5039939e459d8dc05ce681db93ae());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_bd5eec02a9964b3b99c34ecc058be5b9());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_19428704229a46559759cf7b303b00f7());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_697b8c1a07b1402fbd344f52df718ba0());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_196a09e0d9a04640b485cca52d24d28b());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_eef8642e4c9146aeb1a047c23af4c48c());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_39afbbdfe20641199b8bc26f10ec870f());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_795fd2c9c59a4c72ab46ec0e4b1bc8fe());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_d352825e5f6d4c008289c974a327e9b3());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_aa0183eebcb7466a98532dcbe39fcaac());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_1a08846b6fc7459f8ef6b4f0fe142308());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_04dfdbd0e95149628f44f54b6efd1cbd());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_c6f20147e2be4ec4918febf880db2d21());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_382b1655a27f441fad45ea110add0cc0());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_dcd9fe7e3c1141b2952be8e676ea6d77());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_1576059b695e4de6b293acca36c92cc9());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_209e1ebe41af409685bef13a1292bbe8());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_96b3878420474194892fe92717ab071c());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_7169b627012d419f9b99c59d53025239());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_13b9d7544dc2454fa39a75f88075ec12());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_5e79ace01e2f4c97a05b1579546918ff());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_a3d67386edd140ddb7ee7a1650b25b89());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_df42786497b142fcb5e32d8f94a7c508());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_eb3c9aeaaf374241833902f24d53ed59());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_fe6db40cb4b248ec8c9b164b0470b3d9());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_0d480a3d1b9d4e7eb202fca2bf7112bc.PROP_0b14f29571884dd294e37b8630d3cc93());
      }

      private sealed class MTHD_bdcd38c61fb8434ab00cfc6efea7eeef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bdcd38c61fb8434ab00cfc6efea7eeef()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_97283c007cf54aa1922f6362ae15bdfe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97283c007cf54aa1922f6362ae15bdfe()
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

      private sealed class MTHD_ee75c47bf022486baf462b90e1c2723b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee75c47bf022486baf462b90e1c2723b()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_2a993dad48b74fbcac6477673e886b6b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a993dad48b74fbcac6477673e886b6b()
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

      private sealed class MTHD_e2faa357a64849ec9ed9318752c9baeb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e2faa357a64849ec9ed9318752c9baeb()
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

      private sealed class MTHD_2666735b1cd64afbabceffd02923f1a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2666735b1cd64afbabceffd02923f1a6()
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

      private sealed class MTHD_f2c2075363a545d381ab1fbe69b89aed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f2c2075363a545d381ab1fbe69b89aed()
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

      private sealed class MTHD_9fa8493fd558484fb2454eeeb992e448 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9fa8493fd558484fb2454eeeb992e448()
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

      private sealed class MTHD_00fe507ecb2f480394cf9147b70dff3a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_00fe507ecb2f480394cf9147b70dff3a()
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

      private sealed class MTHD_88db7afde53f461b8fe97e699ddfe24b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_88db7afde53f461b8fe97e699ddfe24b()
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

      private sealed class MTHD_c8982e5fb0c24b9081cec5907c35cdb5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c8982e5fb0c24b9081cec5907c35cdb5()
        {
          this.Initialize("hideInfo", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).hideInfo();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_efe437ace8f14e1d9eb6b978207df547 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_efe437ace8f14e1d9eb6b978207df547()
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

      private sealed class MTHD_95e70fac5e284c67bea809c29d6b5f8a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95e70fac5e284c67bea809c29d6b5f8a()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_2d2ba16c4cb24c94a2e88aeee171c389 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d2ba16c4cb24c94a2e88aeee171c389()
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

      private sealed class MTHD_d5a3943713754a7f8a423b79228ba3fb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d5a3943713754a7f8a423b79228ba3fb()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_486d462b0bbc45a6b69972a73dc9a735 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_486d462b0bbc45a6b69972a73dc9a735()
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

      private sealed class MTHD_e1520c3a5f1a4162b217ce19bce2a2c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e1520c3a5f1a4162b217ce19bce2a2c3()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_bef5e1fcbbbd4c93abeb8ccdffb4b8a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bef5e1fcbbbd4c93abeb8ccdffb4b8a3()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_83b217cd55344073a7c8b7058067abbd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_83b217cd55344073a7c8b7058067abbd()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_ea720cb71f5b49c584e0aa2b78a72676 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea720cb71f5b49c584e0aa2b78a72676()
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

      private sealed class MTHD_0f54a7c2ed364558a636ad83c654e6dc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f54a7c2ed364558a636ad83c654e6dc()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_159fe2c9aff8498b8647bf199f33b893 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_159fe2c9aff8498b8647bf199f33b893()
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

      private sealed class MTHD_72d88966d7be46e8837aa97fec1d5c80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_72d88966d7be46e8837aa97fec1d5c80()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_8312b72576364795987ab487e4db280f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8312b72576364795987ab487e4db280f()
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

      private sealed class MTHD_ba3fbf9872dc4c7da46a8c3513f96312 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba3fbf9872dc4c7da46a8c3513f96312()
        {
          this.Initialize("get_allowMinionMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMinionMovement;
        }
      }

      private sealed class MTHD_bf56aa9a717b4658b7c3ece0cb6403fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf56aa9a717b4658b7c3ece0cb6403fe()
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

      private sealed class MTHD_c63a216735e1458c82357baace66aa3a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c63a216735e1458c82357baace66aa3a()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_45a264e1a28249af8a118fec453a6f43 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_45a264e1a28249af8a118fec453a6f43()
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

      private sealed class MTHD_439f1e7e199d41ab821f21b90f6377a0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_439f1e7e199d41ab821f21b90f6377a0()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_0baeb0d84623467dbd64fc8348c7d020 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0baeb0d84623467dbd64fc8348c7d020()
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

      private sealed class MTHD_285cee1c9f434dfeb2c131585a98e7a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_285cee1c9f434dfeb2c131585a98e7a5()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_62f8fed24cb64a248e6b5108e14d4f5f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_62f8fed24cb64a248e6b5108e14d4f5f()
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

      private sealed class MTHD_73540f0b41944000a43598542e26839e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_73540f0b41944000a43598542e26839e()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_a23ab2d027e94a1d9680dfc1304aa234 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a23ab2d027e94a1d9680dfc1304aa234()
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

      private sealed class MTHD_2564f7e792494c33832273e46d49a8c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2564f7e792494c33832273e46d49a8c7()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_e681e53fbbb64c50850b26308fc21efc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e681e53fbbb64c50850b26308fc21efc()
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

      private sealed class MTHD_19eb37d7717d46a5a30cf352d77213f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_19eb37d7717d46a5a30cf352d77213f1()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_9f7a0cff610847c1bdf8acd4bbf8d2b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f7a0cff610847c1bdf8acd4bbf8d2b7()
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

      private sealed class MTHD_1472d15dfde046829d511bb2e81fb1a0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1472d15dfde046829d511bb2e81fb1a0()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_eccf802b0bd1457d9d46357d3adb40a9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eccf802b0bd1457d9d46357d3adb40a9()
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

      private sealed class MTHD_093a17817c27484d982ad7283c95ebd5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_093a17817c27484d982ad7283c95ebd5()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_df1c80c3d45c44c09929938e83c10eb1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_df1c80c3d45c44c09929938e83c10eb1()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_fa879564f6454d59beaa50e69730708d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa879564f6454d59beaa50e69730708d()
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

      private sealed class MTHD_8262f5c0707649678bced1874ef2b1e0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8262f5c0707649678bced1874ef2b1e0()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_803ab0d302404dd09dd5b9c0c9fe6556 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_803ab0d302404dd09dd5b9c0c9fe6556()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_c50434e598a74ea68e4f181ccdcfbc97 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c50434e598a74ea68e4f181ccdcfbc97()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_1d21c19a4fcd43ddb79310eb43722a99 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d21c19a4fcd43ddb79310eb43722a99()
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

      private sealed class MTHD_f8f18c9386b743c4a4a3ca5dfe44d79a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f8f18c9386b743c4a4a3ca5dfe44d79a()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_6180c2e3f2c040349a5b7b880db10136 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6180c2e3f2c040349a5b7b880db10136()
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

      private sealed class MTHD_f9463911b2cd4f41bca44aae1b51703b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f9463911b2cd4f41bca44aae1b51703b()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_7f0328bf58404718a915e6ecaa546c9c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f0328bf58404718a915e6ecaa546c9c()
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

      private sealed class MTHD_bb7898224a754510b4c2b5a33181f997 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb7898224a754510b4c2b5a33181f997()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_423cb67908d743bd9def627161bd4b79 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_423cb67908d743bd9def627161bd4b79()
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

      private sealed class MTHD_879586f8d27747b6bd6c9f09de2e7de9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_879586f8d27747b6bd6c9f09de2e7de9()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_0db52348a41c48ea929b659daace2fb0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0db52348a41c48ea929b659daace2fb0()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_e2e2e5d18c314b6f8085b4207ed0b911 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e2e2e5d18c314b6f8085b4207ed0b911()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_62e2d912e3f94e3d8f76bc634af25a62 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_62e2d912e3f94e3d8f76bc634af25a62()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_1a8988be3ac3407ebde119991a0d8784 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a8988be3ac3407ebde119991a0d8784()
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

      private sealed class MTHD_8f23de49538f492ea84d1f90afa60f1b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8f23de49538f492ea84d1f90afa60f1b()
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

      private sealed class MTHD_034e3b48a8c944c98ccdf4cc6e484f39 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_034e3b48a8c944c98ccdf4cc6e484f39()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_2252587e8b434aec9b64b7e9ea016883 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2252587e8b434aec9b64b7e9ea016883()
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

      private sealed class MTHD_fabd0d758f4e4c82a88aa7bc8cff5c3e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fabd0d758f4e4c82a88aa7bc8cff5c3e()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_23817e08b55141a7af0c48b803e972d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_23817e08b55141a7af0c48b803e972d8()
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

      private sealed class MTHD_1e96512bbc2243d6b0760eac011f5f00 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1e96512bbc2243d6b0760eac011f5f00()
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

      private sealed class MTHD_624f2f4caf46410aa9e58ff1e0d7c839 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_624f2f4caf46410aa9e58ff1e0d7c839()
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

      private sealed class MTHD_b801f27a27b444f8bfe98735d4f2372e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b801f27a27b444f8bfe98735d4f2372e()
        {
          this.Initialize("Dispose", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ContainerGame.Dispose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_fde8a9fbc6ae4fa29b88499efc5bcdad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fde8a9fbc6ae4fa29b88499efc5bcdad()
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

      private sealed class MTHD_dc4966d686604b10acb0811a23a21c15 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc4966d686604b10acb0811a23a21c15()
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

      private sealed class MTHD_c9b8655275d44921a73d31f3d2dad942 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c9b8655275d44921a73d31f3d2dad942()
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

      private sealed class MTHD_04386509fd4b45fdadf3f681e2a3b321 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_04386509fd4b45fdadf3f681e2a3b321()
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

      private sealed class MTHD_a53c01e2753e47cf8e2490871a2f7e68 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a53c01e2753e47cf8e2490871a2f7e68()
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

      private sealed class MTHD_cdbf4f9332e4495a97a2751ceeadd7d2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cdbf4f9332e4495a97a2751ceeadd7d2()
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

      private sealed class MTHD_1aee7107ad934973b2ba4c52c2a8a631 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1aee7107ad934973b2ba4c52c2a8a631()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_fa1934a429354ae8b493bda63bbb8146 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa1934a429354ae8b493bda63bbb8146()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_a41922082bdb41e083d4bde4f208170b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a41922082bdb41e083d4bde4f208170b()
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

      private sealed class MTHD_7e71159b1540406e95220777370182da : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7e71159b1540406e95220777370182da()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_e41e3cd668c64b1ea6134f005b7543d2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e41e3cd668c64b1ea6134f005b7543d2()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_7ea8914993ff4f3b9c510ca9f4680d47 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ea8914993ff4f3b9c510ca9f4680d47()
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

      private sealed class MTHD_d2a50d3c650649b891f3057c4107eee5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d2a50d3c650649b891f3057c4107eee5()
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

      private sealed class MTHD_b488043334a64e78bf32b89ac3c810b4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b488043334a64e78bf32b89ac3c810b4()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ac290615539c4f5ba115b4e79ac87c33 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac290615539c4f5ba115b4e79ac87c33()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_59b8076a7d0c4105a5809c2c5601415c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_59b8076a7d0c4105a5809c2c5601415c()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_74678d10bcb147fa9801cdf2ca404ab1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74678d10bcb147fa9801cdf2ca404ab1()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_70891e7a35294f65927973bbb3875814 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70891e7a35294f65927973bbb3875814()
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

      private sealed class MTHD_4783deeb132c466fbbddbecdfad53521 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4783deeb132c466fbbddbecdfad53521()
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

      private sealed class MTHD_c236e6dc9be54415bc050a3277829eee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c236e6dc9be54415bc050a3277829eee()
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

      private sealed class MTHD_6aa6c81de6284a3096a9b61efb1f94c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6aa6c81de6284a3096a9b61efb1f94c8()
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

      private sealed class MTHD_65d0737abfe84b7881dd45bf83dd28c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65d0737abfe84b7881dd45bf83dd28c7()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_fd9ee482a9ad488598c6654dcc8cce3c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd9ee482a9ad488598c6654dcc8cce3c()
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

      private sealed class MTHD_31817e78f7784271824e953c30ddab8e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_31817e78f7784271824e953c30ddab8e()
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

      private sealed class MTHD_00b0f11eddb34b99ae7f4c3839a56b9b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_00b0f11eddb34b99ae7f4c3839a56b9b()
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

      private sealed class MTHD_3c3bc4509f0440268fc83566fc45174b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3c3bc4509f0440268fc83566fc45174b()
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

      private sealed class MTHD_e063e041a0c040eea9deb1d387ddeeaa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e063e041a0c040eea9deb1d387ddeeaa()
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

      private sealed class MTHD_c2cdff89ea86412cb45865400d4bbb94 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c2cdff89ea86412cb45865400d4bbb94()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_bee0d09960b04fd4990fac47cf270724 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bee0d09960b04fd4990fac47cf270724()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_94088babe5474cfcb355eb909d7db3ef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_94088babe5474cfcb355eb909d7db3ef()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_3764daf75e1f4ae2af1a08596e8dcb2d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3764daf75e1f4ae2af1a08596e8dcb2d()
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

      private sealed class MTHD_aef2d1950cb14f1cbe8a5230a0f36d40 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aef2d1950cb14f1cbe8a5230a0f36d40()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_1110594e9d4043ad934f5a3b4e9745bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1110594e9d4043ad934f5a3b4e9745bb()
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

      private sealed class MTHD_ec3d1434f1714b1b95c1b526ad999fb6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec3d1434f1714b1b95c1b526ad999fb6()
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

      private sealed class MTHD_14b1c49c8b384bf1a547ae83deec4b91 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_14b1c49c8b384bf1a547ae83deec4b91()
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

      private sealed class MTHD_f93c2c272d8b42ac8abca30959c8fd6f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f93c2c272d8b42ac8abca30959c8fd6f()
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

      private sealed class MTHD_0b8dfa83e32540af939f974a69327649 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b8dfa83e32540af939f974a69327649()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_99954f4b78244ad2b339b41ac66a5f08 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99954f4b78244ad2b339b41ac66a5f08()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_59e1377ff4b9419f9096674a7878c01c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_59e1377ff4b9419f9096674a7878c01c()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_441a10f9e2a64e98b6a97ef98fbc266c : HardwiredMemberDescriptor
      {
        internal PROP_441a10f9e2a64e98b6a97ef98fbc266c()
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

      private sealed class PROP_6e6b2388295840f692896e5d9d33dab8 : HardwiredMemberDescriptor
      {
        internal PROP_6e6b2388295840f692896e5d9d33dab8()
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

      private sealed class PROP_cc3d3ee8bc8045abbe20780f8d195647 : HardwiredMemberDescriptor
      {
        internal PROP_cc3d3ee8bc8045abbe20780f8d195647()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_569aeac10e0d441bbd5f242b76999bfc : HardwiredMemberDescriptor
      {
        internal PROP_569aeac10e0d441bbd5f242b76999bfc()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_45b5fc2f140d4c71ae3e22f191415c67 : HardwiredMemberDescriptor
      {
        internal PROP_45b5fc2f140d4c71ae3e22f191415c67()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_207b1772688940359bc17c8384b8fa3a : HardwiredMemberDescriptor
      {
        internal PROP_207b1772688940359bc17c8384b8fa3a()
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

      private sealed class PROP_690eebeded6c44fe830cd880086a66a6 : HardwiredMemberDescriptor
      {
        internal PROP_690eebeded6c44fe830cd880086a66a6()
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

      private sealed class PROP_42fd5039939e459d8dc05ce681db93ae : HardwiredMemberDescriptor
      {
        internal PROP_42fd5039939e459d8dc05ce681db93ae()
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

      private sealed class PROP_bd5eec02a9964b3b99c34ecc058be5b9 : HardwiredMemberDescriptor
      {
        internal PROP_bd5eec02a9964b3b99c34ecc058be5b9()
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

      private sealed class PROP_19428704229a46559759cf7b303b00f7 : HardwiredMemberDescriptor
      {
        internal PROP_19428704229a46559759cf7b303b00f7()
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

      private sealed class PROP_697b8c1a07b1402fbd344f52df718ba0 : HardwiredMemberDescriptor
      {
        internal PROP_697b8c1a07b1402fbd344f52df718ba0()
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

      private sealed class PROP_196a09e0d9a04640b485cca52d24d28b : HardwiredMemberDescriptor
      {
        internal PROP_196a09e0d9a04640b485cca52d24d28b()
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

      private sealed class PROP_eef8642e4c9146aeb1a047c23af4c48c : HardwiredMemberDescriptor
      {
        internal PROP_eef8642e4c9146aeb1a047c23af4c48c()
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

      private sealed class PROP_39afbbdfe20641199b8bc26f10ec870f : HardwiredMemberDescriptor
      {
        internal PROP_39afbbdfe20641199b8bc26f10ec870f()
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

      private sealed class PROP_795fd2c9c59a4c72ab46ec0e4b1bc8fe : HardwiredMemberDescriptor
      {
        internal PROP_795fd2c9c59a4c72ab46ec0e4b1bc8fe()
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

      private sealed class PROP_d352825e5f6d4c008289c974a327e9b3 : HardwiredMemberDescriptor
      {
        internal PROP_d352825e5f6d4c008289c974a327e9b3()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_aa0183eebcb7466a98532dcbe39fcaac : HardwiredMemberDescriptor
      {
        internal PROP_aa0183eebcb7466a98532dcbe39fcaac()
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

      private sealed class PROP_1a08846b6fc7459f8ef6b4f0fe142308 : HardwiredMemberDescriptor
      {
        internal PROP_1a08846b6fc7459f8ef6b4f0fe142308()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_04dfdbd0e95149628f44f54b6efd1cbd : HardwiredMemberDescriptor
      {
        internal PROP_04dfdbd0e95149628f44f54b6efd1cbd()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_c6f20147e2be4ec4918febf880db2d21 : HardwiredMemberDescriptor
      {
        internal PROP_c6f20147e2be4ec4918febf880db2d21()
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

      private sealed class PROP_382b1655a27f441fad45ea110add0cc0 : HardwiredMemberDescriptor
      {
        internal PROP_382b1655a27f441fad45ea110add0cc0()
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

      private sealed class PROP_dcd9fe7e3c1141b2952be8e676ea6d77 : HardwiredMemberDescriptor
      {
        internal PROP_dcd9fe7e3c1141b2952be8e676ea6d77()
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

      private sealed class PROP_1576059b695e4de6b293acca36c92cc9 : HardwiredMemberDescriptor
      {
        internal PROP_1576059b695e4de6b293acca36c92cc9()
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

      private sealed class PROP_209e1ebe41af409685bef13a1292bbe8 : HardwiredMemberDescriptor
      {
        internal PROP_209e1ebe41af409685bef13a1292bbe8()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_96b3878420474194892fe92717ab071c : HardwiredMemberDescriptor
      {
        internal PROP_96b3878420474194892fe92717ab071c()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_7169b627012d419f9b99c59d53025239 : HardwiredMemberDescriptor
      {
        internal PROP_7169b627012d419f9b99c59d53025239()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_13b9d7544dc2454fa39a75f88075ec12 : HardwiredMemberDescriptor
      {
        internal PROP_13b9d7544dc2454fa39a75f88075ec12()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_5e79ace01e2f4c97a05b1579546918ff : HardwiredMemberDescriptor
      {
        internal PROP_5e79ace01e2f4c97a05b1579546918ff()
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

      private sealed class PROP_a3d67386edd140ddb7ee7a1650b25b89 : HardwiredMemberDescriptor
      {
        internal PROP_a3d67386edd140ddb7ee7a1650b25b89()
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

      private sealed class PROP_df42786497b142fcb5e32d8f94a7c508 : HardwiredMemberDescriptor
      {
        internal PROP_df42786497b142fcb5e32d8f94a7c508()
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

      private sealed class PROP_eb3c9aeaaf374241833902f24d53ed59 : HardwiredMemberDescriptor
      {
        internal PROP_eb3c9aeaaf374241833902f24d53ed59()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_fe6db40cb4b248ec8c9b164b0470b3d9 : HardwiredMemberDescriptor
      {
        internal PROP_fe6db40cb4b248ec8c9b164b0470b3d9()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_0b14f29571884dd294e37b8630d3cc93 : HardwiredMemberDescriptor
      {
        internal PROP_0b14f29571884dd294e37b8630d3cc93()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_7ba9145dde214f51a6898d579428d52b : HardwiredUserDataDescriptor
    {
      internal TYPE_7ba9145dde214f51a6898d579428d52b()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7ba9145dde214f51a6898d579428d52b.MTHD_079ac9013d684d1b8c037da4d19edfb6()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7ba9145dde214f51a6898d579428d52b.MTHD_8b50cc18fcb34a348cf6f5a4958b88bd()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7ba9145dde214f51a6898d579428d52b.MTHD_3bde419c97a54ea4bc7ba7a3898eb236()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7ba9145dde214f51a6898d579428d52b.MTHD_0a41848024ef48e984232aa6d0152dfb()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7ba9145dde214f51a6898d579428d52b.MTHD_d8c319e33b23419e8dbfa225d0cdc1f3()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7ba9145dde214f51a6898d579428d52b.MTHD_7ac76a5baaa641ae8ed7172cb4d0d2e6()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7ba9145dde214f51a6898d579428d52b.MTHD_6e5e55dda2c64f98b7473fd4a253169c()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7ba9145dde214f51a6898d579428d52b.MTHD_64e57c27641b46a186958f38ccfa6938()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7ba9145dde214f51a6898d579428d52b.MTHD_0506e6a64ad04181a448b3da6f1203e9()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7ba9145dde214f51a6898d579428d52b.MTHD_3c8c23fa256b47e291d456ee189b624e()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7ba9145dde214f51a6898d579428d52b.MTHD_c626099d08f74069824c97cea57b05b1()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7ba9145dde214f51a6898d579428d52b.MTHD_8968660edb0d4638a3bbf995080f8711()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_7ba9145dde214f51a6898d579428d52b.PROP_de6e19cfe3f0467a828d3e8c7478b7eb());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_7ba9145dde214f51a6898d579428d52b.PROP_6774a0b5e73242b2ba0d1e6494f1c6f5());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_7ba9145dde214f51a6898d579428d52b.PROP_db331277d3804de5908d0cbfbd45c3e3());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_7ba9145dde214f51a6898d579428d52b.PROP_ab3602c837b64a5ba2208bcb95159c6c());
      }

      private sealed class MTHD_079ac9013d684d1b8c037da4d19edfb6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_079ac9013d684d1b8c037da4d19edfb6()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_8b50cc18fcb34a348cf6f5a4958b88bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b50cc18fcb34a348cf6f5a4958b88bd()
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

      private sealed class MTHD_3bde419c97a54ea4bc7ba7a3898eb236 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3bde419c97a54ea4bc7ba7a3898eb236()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_0a41848024ef48e984232aa6d0152dfb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0a41848024ef48e984232aa6d0152dfb()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_d8c319e33b23419e8dbfa225d0cdc1f3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8c319e33b23419e8dbfa225d0cdc1f3()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_7ac76a5baaa641ae8ed7172cb4d0d2e6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ac76a5baaa641ae8ed7172cb4d0d2e6()
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

      private sealed class MTHD_6e5e55dda2c64f98b7473fd4a253169c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e5e55dda2c64f98b7473fd4a253169c()
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

      private sealed class MTHD_64e57c27641b46a186958f38ccfa6938 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_64e57c27641b46a186958f38ccfa6938()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_0506e6a64ad04181a448b3da6f1203e9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0506e6a64ad04181a448b3da6f1203e9()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_3c8c23fa256b47e291d456ee189b624e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3c8c23fa256b47e291d456ee189b624e()
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

      private sealed class MTHD_c626099d08f74069824c97cea57b05b1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c626099d08f74069824c97cea57b05b1()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_8968660edb0d4638a3bbf995080f8711 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8968660edb0d4638a3bbf995080f8711()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_de6e19cfe3f0467a828d3e8c7478b7eb : HardwiredMemberDescriptor
      {
        internal PROP_de6e19cfe3f0467a828d3e8c7478b7eb()
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

      private sealed class PROP_6774a0b5e73242b2ba0d1e6494f1c6f5 : HardwiredMemberDescriptor
      {
        internal PROP_6774a0b5e73242b2ba0d1e6494f1c6f5()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_db331277d3804de5908d0cbfbd45c3e3 : HardwiredMemberDescriptor
      {
        internal PROP_db331277d3804de5908d0cbfbd45c3e3()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_ab3602c837b64a5ba2208bcb95159c6c : HardwiredMemberDescriptor
      {
        internal PROP_ab3602c837b64a5ba2208bcb95159c6c()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_ab04ca92a63248319303707f63f043a5 : HardwiredUserDataDescriptor
    {
      internal TYPE_ab04ca92a63248319303707f63f043a5()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_feeb876acf7a42fea5787941656f1d09()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_2e593b89d1ae4816a8e113a2b6f3af03()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_cd25fa10ff624fc9950cfede58da682e()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_1c268b05ff0f440699e9e68df3e3ea96()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_a60cfac2fc5c422ebdb67c669d377bbc()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_683e94adb8074dd99df66bd869c227e0()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_d72efc2073354d1cb61e0a174009ce3d()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_27e2df41358e425ab828dc51573eb317()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_4d6fe02ae0204fbd8d47c4a89c7c9aac()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_3b685f483e7c44ccb0ee03a616e7641f()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_94e4415adb514d1380c1206db018c1cb()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_d35a3c67c92c41a19a7b968bce9ef325()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_8b62726101fe49e5a9bcbe5ebb57f33e()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_45bfc0be9adc4498bf2654d3ba1bef0c()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_75f6231e23a047ebad07c27618d05c24()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_d40fadd0b2ba414aaef828e3138f0fc2()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_026eede59ef943f79f7f35bcff14c98b()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_e2ad61fd44914fd485d8a958058784e7()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_9f66aa1b25f9477682f5bddedf02d810()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_a0361a43ebc34788b34abb97e97551ef()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_539652d0b5364719a6dd9a54e3733524()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_ad04e3d0b755498cb2ab4a3ba2b3c516()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_4a28cb36b94144aa9eee48ee6c1e588b()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_19308e1d4c63416290a912fc97fc74ee()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_74467431117141349866697cd27fffad()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_cf42ac33bce840e7acad4ea21e66691d()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_ef9e3b9054d54054800010cfb36d2f9c()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_666a472a31d14c5f9b61b54f7ee693e9()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_f3ceedfd131046cf86f463ab1c76a1c3()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_9d804f7187534e489ad9bc1001bb624a()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_a6585d88a314436bb982ca917dc0e0ee()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_007fc5a541a5473fb0375ceb0e43fbc4()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_101b12f342df4b68ab53368cb6e1b758()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_1a5c46ceacc24128a43350bb63e1082d()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_c88049e065644f9e989f553f8e604d63()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_b1d778341c3243e6a71a6367b9f01c0d()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_138922f287964234905bccbe84da7180()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_076507723b36437cadbf13559c06a1b2()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_33675105b26945ec9118ccb973a09919()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_db1526dab1b64d79809606330664c2d6()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_a0fdb24ce104498ba9d58f85914aba09()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_d5d7c126f02c450e982d96066690fe1c()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_32c9fb2c85da4007b9ed873b2efd868c()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_32892a0df6a447f585fcb8edc76014e9()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_a4a2757411cb44f38097664bb915bdb9()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_18a2c81de9e040aba2543b0f3fad5703()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_984d84b8260e4837a5c9234e2421aedd()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_69c6b6a0f8974ecd88f54f35625b42b6()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_c55b0b5f08be4145ae56255e5fa95d1e()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_874732454ed6466c822a7e1a565a35c1()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_dd2d26c3e22248378ccff431bd45a3c1()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_c0caab4962b1414c86fd4d3359762cab()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_95c2199a90fa46fa9808607948dc4dd2()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_4f915299d3f5463cb021b338266f1664()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_ebce870b17954761a1439be205e5ae32()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_1d6c5e55b1b046aba0d2e33440e0c84b()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_7be00cd4053a43ea877f42f16e443a3d()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_d7d3198983a0453c9d8eceee559425b2()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_acc124cb070b41c5bf20dbc2d0c584fd()
        }));
        this.AddMember("getDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_e6b5be905a9b417783e2ca0f582e01df()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_e3363a7cc7ec448c9579daa909ab1a9d()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_10d3e233e27e45619e67a46e349e303d()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_26aa06ab20a847e1962ad0d56c5c4ce9()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_90c77dd0f1ca4923b80deb435938d92b()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_5b1c7ca57d5f418c9b30350caf5b3a63(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_942a142960e840638dca4ef81b399975()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_4178e0c767db41488c3f2b966bfe5c8f(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_2d6bad504066494b9c3beb0c01c7b9f4()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_60533244ee574ce18edc94b487f591ed()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_d7d60c8c4be24c2398701cbc70975249()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_5752ffd301244d93a5ac533f3b270cf6(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_f6eaea3867ac487991c0b07327f1923a()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_32da43e2f57f43fb876f4e32790a78fa()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_6b634255c6744d248639241cc1358602()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_db6e8d5b561343919284386bbb9ef080()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_969afa66f02e4545866c09fb77371220()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_73dcb28f07be46d28d91eefe0dd36f27()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_1a9f93845b814d0c8ef67cd06c803ea5()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_b67c8ed9ad1941c1b22b330a162388a9()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_91b3d89bd8d747038262e521ad26fbe1()
        }));
        this.AddMember("angleToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("angleToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_915b6a67fc494366a59aca046e204309()
        }));
        this.AddMember("powerToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("powerToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_25b8bf6177a7405ab2fc310b2d7dfc5c()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_d3f14c2744084c61b1f2ddbe4a21d8de(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_342ae74bbf5d484d92f75f0ee7026c4d()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_926cf8d60e384d808b3872d93e863f7f(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_b740753c45a74923844a2d7da35c250a()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_95e9a3ac3256427fa8d80ea1ec5facd3()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_7e87336639634db8a69b4f0bed6db090()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_231d160452e74f999bf5540ff613ead3()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_39b67389400741d5ba5f36d3c8288764()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_a5fdd8cd1347480bb35f7a23a7ab1584()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.MTHD_bd68b091f85847d597726d53a6b5e90e()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_403ea82c945f49f9b7b7c293a5050f76());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_25ddf914100b45e580412a94aa616605());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_7377bc0de7e748168b13b428f0341b88());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_475fa51a8a2c456cb536338bc9f4aef0());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_1f760944203b4ec8a9a30478522a41e8());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_788d75ac212a4dc7985e573c92583dae());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_e945cf4eb93843d6881c553b3cddca79());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_fda9b22502454328a05ae81dd9b6aee7());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_7104d94b7030450f856be59504d28983());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_f3970153529c4406961252eb63b3b00d());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_634b85bc89bb4445afc385c2d0866442());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_b92efb07d0ce4c1eadbe315e04753651());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_d98d59342ba04ab6a3b39d5b6843d626());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_1b24a46bfafd4eb3a9703c4441be147b());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_7bad2886fcb0473889196248c230499b());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_b409fd3904124108b7c0a4ba759d8459());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_e904414d9c7a400abc362c84d3c69df6());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_a9eb5a1f792f46038d43413c1133d7de());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_66ecc5ff6e874eccb6989fd01c302a78());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_f62d522456ed430084bb13583102445a());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_75eeb4543ccb484396df0faf34bd0b9f());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_07f627a2160f449a8a450d1d61596a95());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_02d4b3ffeb39419e818f6a4164814c1d());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_fbc1bb634d0244c38a3a6873e215ae19());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_e4dd4d5e41c14e0cb43b636dfcec6f6d());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_bb043b3c2ac249e08ba3d540796d4fe7());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_1807a67410e84aed805284040fd22c76());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_5d9fdd30cb7e43d09ea93bdc662a916f());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_8089f3e1d3254fea81222fcdcdf30480());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_35fa2e69919648c3b4fd782913918a61());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_5ac8a2c2fbb542ad9e17e56f7ae800ed());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_f03bda9b7fbf4a5d9a06dd32fcd0d9a0());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_ab04ca92a63248319303707f63f043a5.PROP_d59c609adc9a475dae938f7759969520());
      }

      private sealed class MTHD_feeb876acf7a42fea5787941656f1d09 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_feeb876acf7a42fea5787941656f1d09()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_2e593b89d1ae4816a8e113a2b6f3af03 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2e593b89d1ae4816a8e113a2b6f3af03()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_cd25fa10ff624fc9950cfede58da682e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd25fa10ff624fc9950cfede58da682e()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_1c268b05ff0f440699e9e68df3e3ea96 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c268b05ff0f440699e9e68df3e3ea96()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_a60cfac2fc5c422ebdb67c669d377bbc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a60cfac2fc5c422ebdb67c669d377bbc()
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

      private sealed class MTHD_683e94adb8074dd99df66bd869c227e0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_683e94adb8074dd99df66bd869c227e0()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_d72efc2073354d1cb61e0a174009ce3d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d72efc2073354d1cb61e0a174009ce3d()
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

      private sealed class MTHD_27e2df41358e425ab828dc51573eb317 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_27e2df41358e425ab828dc51573eb317()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_4d6fe02ae0204fbd8d47c4a89c7c9aac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d6fe02ae0204fbd8d47c4a89c7c9aac()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_3b685f483e7c44ccb0ee03a616e7641f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3b685f483e7c44ccb0ee03a616e7641f()
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

      private sealed class MTHD_94e4415adb514d1380c1206db018c1cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_94e4415adb514d1380c1206db018c1cb()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_d35a3c67c92c41a19a7b968bce9ef325 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d35a3c67c92c41a19a7b968bce9ef325()
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

      private sealed class MTHD_8b62726101fe49e5a9bcbe5ebb57f33e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b62726101fe49e5a9bcbe5ebb57f33e()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_45bfc0be9adc4498bf2654d3ba1bef0c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_45bfc0be9adc4498bf2654d3ba1bef0c()
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

      private sealed class MTHD_75f6231e23a047ebad07c27618d05c24 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75f6231e23a047ebad07c27618d05c24()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_d40fadd0b2ba414aaef828e3138f0fc2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d40fadd0b2ba414aaef828e3138f0fc2()
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

      private sealed class MTHD_026eede59ef943f79f7f35bcff14c98b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_026eede59ef943f79f7f35bcff14c98b()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_e2ad61fd44914fd485d8a958058784e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e2ad61fd44914fd485d8a958058784e7()
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

      private sealed class MTHD_9f66aa1b25f9477682f5bddedf02d810 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f66aa1b25f9477682f5bddedf02d810()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_a0361a43ebc34788b34abb97e97551ef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a0361a43ebc34788b34abb97e97551ef()
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

      private sealed class MTHD_539652d0b5364719a6dd9a54e3733524 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_539652d0b5364719a6dd9a54e3733524()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_ad04e3d0b755498cb2ab4a3ba2b3c516 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ad04e3d0b755498cb2ab4a3ba2b3c516()
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

      private sealed class MTHD_4a28cb36b94144aa9eee48ee6c1e588b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a28cb36b94144aa9eee48ee6c1e588b()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_19308e1d4c63416290a912fc97fc74ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_19308e1d4c63416290a912fc97fc74ee()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_74467431117141349866697cd27fffad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74467431117141349866697cd27fffad()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_cf42ac33bce840e7acad4ea21e66691d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf42ac33bce840e7acad4ea21e66691d()
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

      private sealed class MTHD_ef9e3b9054d54054800010cfb36d2f9c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef9e3b9054d54054800010cfb36d2f9c()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_666a472a31d14c5f9b61b54f7ee693e9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_666a472a31d14c5f9b61b54f7ee693e9()
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

      private sealed class MTHD_f3ceedfd131046cf86f463ab1c76a1c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f3ceedfd131046cf86f463ab1c76a1c3()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_9d804f7187534e489ad9bc1001bb624a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d804f7187534e489ad9bc1001bb624a()
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

      private sealed class MTHD_a6585d88a314436bb982ca917dc0e0ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6585d88a314436bb982ca917dc0e0ee()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_007fc5a541a5473fb0375ceb0e43fbc4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_007fc5a541a5473fb0375ceb0e43fbc4()
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

      private sealed class MTHD_101b12f342df4b68ab53368cb6e1b758 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_101b12f342df4b68ab53368cb6e1b758()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_1a5c46ceacc24128a43350bb63e1082d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a5c46ceacc24128a43350bb63e1082d()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_c88049e065644f9e989f553f8e604d63 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c88049e065644f9e989f553f8e604d63()
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

      private sealed class MTHD_b1d778341c3243e6a71a6367b9f01c0d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b1d778341c3243e6a71a6367b9f01c0d()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_138922f287964234905bccbe84da7180 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_138922f287964234905bccbe84da7180()
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

      private sealed class MTHD_076507723b36437cadbf13559c06a1b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_076507723b36437cadbf13559c06a1b2()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_33675105b26945ec9118ccb973a09919 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_33675105b26945ec9118ccb973a09919()
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

      private sealed class MTHD_db1526dab1b64d79809606330664c2d6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db1526dab1b64d79809606330664c2d6()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_a0fdb24ce104498ba9d58f85914aba09 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a0fdb24ce104498ba9d58f85914aba09()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_d5d7c126f02c450e982d96066690fe1c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d5d7c126f02c450e982d96066690fe1c()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_32c9fb2c85da4007b9ed873b2efd868c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_32c9fb2c85da4007b9ed873b2efd868c()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_32892a0df6a447f585fcb8edc76014e9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_32892a0df6a447f585fcb8edc76014e9()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_a4a2757411cb44f38097664bb915bdb9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a4a2757411cb44f38097664bb915bdb9()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_18a2c81de9e040aba2543b0f3fad5703 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_18a2c81de9e040aba2543b0f3fad5703()
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

      private sealed class MTHD_984d84b8260e4837a5c9234e2421aedd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_984d84b8260e4837a5c9234e2421aedd()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_69c6b6a0f8974ecd88f54f35625b42b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69c6b6a0f8974ecd88f54f35625b42b6()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_c55b0b5f08be4145ae56255e5fa95d1e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c55b0b5f08be4145ae56255e5fa95d1e()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_874732454ed6466c822a7e1a565a35c1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_874732454ed6466c822a7e1a565a35c1()
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

      private sealed class MTHD_dd2d26c3e22248378ccff431bd45a3c1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dd2d26c3e22248378ccff431bd45a3c1()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_c0caab4962b1414c86fd4d3359762cab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c0caab4962b1414c86fd4d3359762cab()
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

      private sealed class MTHD_95c2199a90fa46fa9808607948dc4dd2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95c2199a90fa46fa9808607948dc4dd2()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_4f915299d3f5463cb021b338266f1664 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4f915299d3f5463cb021b338266f1664()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_ebce870b17954761a1439be205e5ae32 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ebce870b17954761a1439be205e5ae32()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_1d6c5e55b1b046aba0d2e33440e0c84b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d6c5e55b1b046aba0d2e33440e0c84b()
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

      private sealed class MTHD_7be00cd4053a43ea877f42f16e443a3d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7be00cd4053a43ea877f42f16e443a3d()
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

      private sealed class MTHD_d7d3198983a0453c9d8eceee559425b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d7d3198983a0453c9d8eceee559425b2()
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

      private sealed class MTHD_acc124cb070b41c5bf20dbc2d0c584fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_acc124cb070b41c5bf20dbc2d0c584fd()
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

      private sealed class MTHD_e6b5be905a9b417783e2ca0f582e01df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e6b5be905a9b417783e2ca0f582e01df()
        {
          this.Initialize("getDirection", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getDirection();
        }
      }

      private sealed class MTHD_e3363a7cc7ec448c9579daa909ab1a9d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e3363a7cc7ec448c9579daa909ab1a9d()
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

      private sealed class MTHD_10d3e233e27e45619e67a46e349e303d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_10d3e233e27e45619e67a46e349e303d()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_26aa06ab20a847e1962ad0d56c5c4ce9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_26aa06ab20a847e1962ad0d56c5c4ce9()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_90c77dd0f1ca4923b80deb435938d92b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90c77dd0f1ca4923b80deb435938d92b()
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

      private sealed class MTHD_5b1c7ca57d5f418c9b30350caf5b3a63 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b1c7ca57d5f418c9b30350caf5b3a63()
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

      private sealed class MTHD_942a142960e840638dca4ef81b399975 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_942a142960e840638dca4ef81b399975()
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

      private sealed class MTHD_4178e0c767db41488c3f2b966bfe5c8f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4178e0c767db41488c3f2b966bfe5c8f()
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

      private sealed class MTHD_2d6bad504066494b9c3beb0c01c7b9f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d6bad504066494b9c3beb0c01c7b9f4()
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

      private sealed class MTHD_60533244ee574ce18edc94b487f591ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60533244ee574ce18edc94b487f591ed()
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

      private sealed class MTHD_d7d60c8c4be24c2398701cbc70975249 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d7d60c8c4be24c2398701cbc70975249()
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

      private sealed class MTHD_5752ffd301244d93a5ac533f3b270cf6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5752ffd301244d93a5ac533f3b270cf6()
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

      private sealed class MTHD_f6eaea3867ac487991c0b07327f1923a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f6eaea3867ac487991c0b07327f1923a()
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

      private sealed class MTHD_32da43e2f57f43fb876f4e32790a78fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_32da43e2f57f43fb876f4e32790a78fa()
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

      private sealed class MTHD_6b634255c6744d248639241cc1358602 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b634255c6744d248639241cc1358602()
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

      private sealed class MTHD_db6e8d5b561343919284386bbb9ef080 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db6e8d5b561343919284386bbb9ef080()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_969afa66f02e4545866c09fb77371220 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_969afa66f02e4545866c09fb77371220()
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

      private sealed class MTHD_73dcb28f07be46d28d91eefe0dd36f27 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_73dcb28f07be46d28d91eefe0dd36f27()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_1a9f93845b814d0c8ef67cd06c803ea5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a9f93845b814d0c8ef67cd06c803ea5()
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

      private sealed class MTHD_b67c8ed9ad1941c1b22b330a162388a9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b67c8ed9ad1941c1b22b330a162388a9()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_91b3d89bd8d747038262e521ad26fbe1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_91b3d89bd8d747038262e521ad26fbe1()
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

      private sealed class MTHD_915b6a67fc494366a59aca046e204309 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_915b6a67fc494366a59aca046e204309()
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

      private sealed class MTHD_25b8bf6177a7405ab2fc310b2d7dfc5c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_25b8bf6177a7405ab2fc310b2d7dfc5c()
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

      private sealed class MTHD_d3f14c2744084c61b1f2ddbe4a21d8de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d3f14c2744084c61b1f2ddbe4a21d8de()
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

      private sealed class MTHD_342ae74bbf5d484d92f75f0ee7026c4d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_342ae74bbf5d484d92f75f0ee7026c4d()
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

      private sealed class MTHD_926cf8d60e384d808b3872d93e863f7f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_926cf8d60e384d808b3872d93e863f7f()
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

      private sealed class MTHD_b740753c45a74923844a2d7da35c250a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b740753c45a74923844a2d7da35c250a()
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

      private sealed class MTHD_95e9a3ac3256427fa8d80ea1ec5facd3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95e9a3ac3256427fa8d80ea1ec5facd3()
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

      private sealed class MTHD_7e87336639634db8a69b4f0bed6db090 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7e87336639634db8a69b4f0bed6db090()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_231d160452e74f999bf5540ff613ead3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_231d160452e74f999bf5540ff613ead3()
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

      private sealed class MTHD_39b67389400741d5ba5f36d3c8288764 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_39b67389400741d5ba5f36d3c8288764()
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

      private sealed class MTHD_a5fdd8cd1347480bb35f7a23a7ab1584 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a5fdd8cd1347480bb35f7a23a7ab1584()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_bd68b091f85847d597726d53a6b5e90e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd68b091f85847d597726d53a6b5e90e()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_403ea82c945f49f9b7b7c293a5050f76 : HardwiredMemberDescriptor
      {
        internal PROP_403ea82c945f49f9b7b7c293a5050f76()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_25ddf914100b45e580412a94aa616605 : HardwiredMemberDescriptor
      {
        internal PROP_25ddf914100b45e580412a94aa616605()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_7377bc0de7e748168b13b428f0341b88 : HardwiredMemberDescriptor
      {
        internal PROP_7377bc0de7e748168b13b428f0341b88()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_475fa51a8a2c456cb536338bc9f4aef0 : HardwiredMemberDescriptor
      {
        internal PROP_475fa51a8a2c456cb536338bc9f4aef0()
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

      private sealed class PROP_1f760944203b4ec8a9a30478522a41e8 : HardwiredMemberDescriptor
      {
        internal PROP_1f760944203b4ec8a9a30478522a41e8()
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

      private sealed class PROP_788d75ac212a4dc7985e573c92583dae : HardwiredMemberDescriptor
      {
        internal PROP_788d75ac212a4dc7985e573c92583dae()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_e945cf4eb93843d6881c553b3cddca79 : HardwiredMemberDescriptor
      {
        internal PROP_e945cf4eb93843d6881c553b3cddca79()
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

      private sealed class PROP_fda9b22502454328a05ae81dd9b6aee7 : HardwiredMemberDescriptor
      {
        internal PROP_fda9b22502454328a05ae81dd9b6aee7()
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

      private sealed class PROP_7104d94b7030450f856be59504d28983 : HardwiredMemberDescriptor
      {
        internal PROP_7104d94b7030450f856be59504d28983()
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

      private sealed class PROP_f3970153529c4406961252eb63b3b00d : HardwiredMemberDescriptor
      {
        internal PROP_f3970153529c4406961252eb63b3b00d()
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

      private sealed class PROP_634b85bc89bb4445afc385c2d0866442 : HardwiredMemberDescriptor
      {
        internal PROP_634b85bc89bb4445afc385c2d0866442()
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

      private sealed class PROP_b92efb07d0ce4c1eadbe315e04753651 : HardwiredMemberDescriptor
      {
        internal PROP_b92efb07d0ce4c1eadbe315e04753651()
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

      private sealed class PROP_d98d59342ba04ab6a3b39d5b6843d626 : HardwiredMemberDescriptor
      {
        internal PROP_d98d59342ba04ab6a3b39d5b6843d626()
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

      private sealed class PROP_1b24a46bfafd4eb3a9703c4441be147b : HardwiredMemberDescriptor
      {
        internal PROP_1b24a46bfafd4eb3a9703c4441be147b()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_7bad2886fcb0473889196248c230499b : HardwiredMemberDescriptor
      {
        internal PROP_7bad2886fcb0473889196248c230499b()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_b409fd3904124108b7c0a4ba759d8459 : HardwiredMemberDescriptor
      {
        internal PROP_b409fd3904124108b7c0a4ba759d8459()
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

      private sealed class PROP_e904414d9c7a400abc362c84d3c69df6 : HardwiredMemberDescriptor
      {
        internal PROP_e904414d9c7a400abc362c84d3c69df6()
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

      private sealed class PROP_a9eb5a1f792f46038d43413c1133d7de : HardwiredMemberDescriptor
      {
        internal PROP_a9eb5a1f792f46038d43413c1133d7de()
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

      private sealed class PROP_66ecc5ff6e874eccb6989fd01c302a78 : HardwiredMemberDescriptor
      {
        internal PROP_66ecc5ff6e874eccb6989fd01c302a78()
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

      private sealed class PROP_f62d522456ed430084bb13583102445a : HardwiredMemberDescriptor
      {
        internal PROP_f62d522456ed430084bb13583102445a()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_75eeb4543ccb484396df0faf34bd0b9f : HardwiredMemberDescriptor
      {
        internal PROP_75eeb4543ccb484396df0faf34bd0b9f()
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

      private sealed class PROP_07f627a2160f449a8a450d1d61596a95 : HardwiredMemberDescriptor
      {
        internal PROP_07f627a2160f449a8a450d1d61596a95()
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

      private sealed class PROP_02d4b3ffeb39419e818f6a4164814c1d : HardwiredMemberDescriptor
      {
        internal PROP_02d4b3ffeb39419e818f6a4164814c1d()
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

      private sealed class PROP_fbc1bb634d0244c38a3a6873e215ae19 : HardwiredMemberDescriptor
      {
        internal PROP_fbc1bb634d0244c38a3a6873e215ae19()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_e4dd4d5e41c14e0cb43b636dfcec6f6d : HardwiredMemberDescriptor
      {
        internal PROP_e4dd4d5e41c14e0cb43b636dfcec6f6d()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_bb043b3c2ac249e08ba3d540796d4fe7 : HardwiredMemberDescriptor
      {
        internal PROP_bb043b3c2ac249e08ba3d540796d4fe7()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_1807a67410e84aed805284040fd22c76 : HardwiredMemberDescriptor
      {
        internal PROP_1807a67410e84aed805284040fd22c76()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_5d9fdd30cb7e43d09ea93bdc662a916f : HardwiredMemberDescriptor
      {
        internal PROP_5d9fdd30cb7e43d09ea93bdc662a916f()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_8089f3e1d3254fea81222fcdcdf30480 : HardwiredMemberDescriptor
      {
        internal PROP_8089f3e1d3254fea81222fcdcdf30480()
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

      private sealed class PROP_35fa2e69919648c3b4fd782913918a61 : HardwiredMemberDescriptor
      {
        internal PROP_35fa2e69919648c3b4fd782913918a61()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_5ac8a2c2fbb542ad9e17e56f7ae800ed : HardwiredMemberDescriptor
      {
        internal PROP_5ac8a2c2fbb542ad9e17e56f7ae800ed()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_f03bda9b7fbf4a5d9a06dd32fcd0d9a0 : HardwiredMemberDescriptor
      {
        internal PROP_f03bda9b7fbf4a5d9a06dd32fcd0d9a0()
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

      private sealed class PROP_d59c609adc9a475dae938f7759969520 : HardwiredMemberDescriptor
      {
        internal PROP_d59c609adc9a475dae938f7759969520()
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

    private sealed class TYPE_9eb521fa60434d20b87079929834e63c : HardwiredUserDataDescriptor
    {
      internal TYPE_9eb521fa60434d20b87079929834e63c()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.MTHD_6c82d0eac20e4127a5e873e2db83c24a()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.MTHD_21a336a21607421f89b36ca8990832d8()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.MTHD_98470cb5d4be43afa5d9147789c65c43()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.MTHD_275c4f0cd63b40e9a1a178805778323f()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.MTHD_189f988976444500a52724a5ab920731()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.MTHD_c6bcfe28174a4b97892ff49d895f5096()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.MTHD_b654c0c0308242e0872ae486436aac50()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.MTHD_942df1b52cb1407c841b862f0f03b335()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.MTHD_83eabf62678d43e79a5b5b2230bbcb20()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.MTHD_808589109d524ebb9af113788d5a1037()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.MTHD_62b307333e3845b19561ac2ba564691a()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.MTHD_0033160459df42b1addc2836e2d9d1d7()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.MTHD_f939d581d6614f0a95d942a2f42b1bec()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.MTHD_1ca3367646514d778c5c02a75bd59f85()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.MTHD_7d1caac37d374996a028b0af5858c733()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.MTHD_8904b08eded640e0a855ac5aac7a7a59()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.MTHD_abe49d8d579241cbbbfdcd16d4581701()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.MTHD_75b8f8f0cf4a4ffc96d8c2b2439af805()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.MTHD_036cf516b2c04be492df3d5bd5bd9560()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.MTHD_30c6882b5f894f97bb3c00328a4bce33()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.PROP_2f94d1fe21964833abddc8780e95b9cf());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.PROP_faf4499bc726472ba0a197b041c20239());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.PROP_8c6d588600814254b22783dae824fdfa());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.PROP_6084e1ee55f24e54974711ce415a561e());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.PROP_c2e76d23c4264cdf9492369a788e039e());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.PROP_548f00ab5ea2433a90d66220c47e64f3());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.PROP_453b6db4a6044d58ac414d7f7a7b9dd1());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_9eb521fa60434d20b87079929834e63c.PROP_c01beac6a38846438f0a78720f4f5a09());
      }

      private sealed class MTHD_6c82d0eac20e4127a5e873e2db83c24a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6c82d0eac20e4127a5e873e2db83c24a()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_21a336a21607421f89b36ca8990832d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_21a336a21607421f89b36ca8990832d8()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_98470cb5d4be43afa5d9147789c65c43 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_98470cb5d4be43afa5d9147789c65c43()
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

      private sealed class MTHD_275c4f0cd63b40e9a1a178805778323f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_275c4f0cd63b40e9a1a178805778323f()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_189f988976444500a52724a5ab920731 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_189f988976444500a52724a5ab920731()
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

      private sealed class MTHD_c6bcfe28174a4b97892ff49d895f5096 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c6bcfe28174a4b97892ff49d895f5096()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_b654c0c0308242e0872ae486436aac50 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b654c0c0308242e0872ae486436aac50()
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

      private sealed class MTHD_942df1b52cb1407c841b862f0f03b335 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_942df1b52cb1407c841b862f0f03b335()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_83eabf62678d43e79a5b5b2230bbcb20 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_83eabf62678d43e79a5b5b2230bbcb20()
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

      private sealed class MTHD_808589109d524ebb9af113788d5a1037 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_808589109d524ebb9af113788d5a1037()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_62b307333e3845b19561ac2ba564691a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_62b307333e3845b19561ac2ba564691a()
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

      private sealed class MTHD_0033160459df42b1addc2836e2d9d1d7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0033160459df42b1addc2836e2d9d1d7()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_f939d581d6614f0a95d942a2f42b1bec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f939d581d6614f0a95d942a2f42b1bec()
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

      private sealed class MTHD_1ca3367646514d778c5c02a75bd59f85 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ca3367646514d778c5c02a75bd59f85()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_7d1caac37d374996a028b0af5858c733 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7d1caac37d374996a028b0af5858c733()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_8904b08eded640e0a855ac5aac7a7a59 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8904b08eded640e0a855ac5aac7a7a59()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_abe49d8d579241cbbbfdcd16d4581701 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_abe49d8d579241cbbbfdcd16d4581701()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_75b8f8f0cf4a4ffc96d8c2b2439af805 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75b8f8f0cf4a4ffc96d8c2b2439af805()
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

      private sealed class MTHD_036cf516b2c04be492df3d5bd5bd9560 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_036cf516b2c04be492df3d5bd5bd9560()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_30c6882b5f894f97bb3c00328a4bce33 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_30c6882b5f894f97bb3c00328a4bce33()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_2f94d1fe21964833abddc8780e95b9cf : HardwiredMemberDescriptor
      {
        internal PROP_2f94d1fe21964833abddc8780e95b9cf()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_faf4499bc726472ba0a197b041c20239 : HardwiredMemberDescriptor
      {
        internal PROP_faf4499bc726472ba0a197b041c20239()
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

      private sealed class PROP_8c6d588600814254b22783dae824fdfa : HardwiredMemberDescriptor
      {
        internal PROP_8c6d588600814254b22783dae824fdfa()
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

      private sealed class PROP_6084e1ee55f24e54974711ce415a561e : HardwiredMemberDescriptor
      {
        internal PROP_6084e1ee55f24e54974711ce415a561e()
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

      private sealed class PROP_c2e76d23c4264cdf9492369a788e039e : HardwiredMemberDescriptor
      {
        internal PROP_c2e76d23c4264cdf9492369a788e039e()
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

      private sealed class PROP_548f00ab5ea2433a90d66220c47e64f3 : HardwiredMemberDescriptor
      {
        internal PROP_548f00ab5ea2433a90d66220c47e64f3()
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

      private sealed class PROP_453b6db4a6044d58ac414d7f7a7b9dd1 : HardwiredMemberDescriptor
      {
        internal PROP_453b6db4a6044d58ac414d7f7a7b9dd1()
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

      private sealed class PROP_c01beac6a38846438f0a78720f4f5a09 : HardwiredMemberDescriptor
      {
        internal PROP_c01beac6a38846438f0a78720f4f5a09()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_c739cfbcaf924bba9cc526fb2fb14059 : HardwiredUserDataDescriptor
    {
      internal TYPE_c739cfbcaf924bba9cc526fb2fb14059()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.MTHD_2070f2ea66c44b59852768c9acd6a5e2()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.MTHD_40bab7d0eb6940039fa40b65b76ef0fc()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.MTHD_ea379d00142548d7ab44be86e536e820()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.MTHD_70d61364e6cb46bcb1e786d56c1594a1()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.MTHD_de51e45e656d46cd84acb7cbb765717c()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.MTHD_d389c37cd05d4d1da6681b62fbf3a52c()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.MTHD_b25f25d685444dd896d942c7c2105b95()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.MTHD_d2d1c5f3f484444f92c3316194668116()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.MTHD_9f251c2628714b41ac9325c0d8858f64()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.MTHD_dabf60ac7dac4c6cb66d4ad2c92a5390()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.MTHD_1f7e43c573a44f03beddda07a183f0dc()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.MTHD_0178999ba62349ed817eb70c4144d756()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.MTHD_0ea732ff6c554d63b644e9a189344074()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.MTHD_9b159e6144dc4afdb630470ccd412bf4()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.MTHD_85dcf7f8582a4152920f2b3bc8ac0975()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.MTHD_495a5f5aba0f424f994809dc9be9e294()
        }));
        this.AddMember("setIcon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setIcon", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.MTHD_8b1d5b0a2a4440559af3e316287288ed()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.MTHD_8a6241e1378c448d9ef94a5337d0bc41()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.MTHD_2e53293d311f4a9b9445aa69e5252519()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.MTHD_2855b7c76d6440ed88e3feec97607f6c()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.MTHD_45ed39eddafa478fa4169fc2e02059d3()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.MTHD_77e97539605f482db89d3114b4daa7f5()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.PROP_ca9a80beac59495e9cfed5c28b02c9d6());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.PROP_51a3a823109d47079ffb356eb5dd0ad9());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.PROP_99f8be1a35844a0380865dd463048da4());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.PROP_efcff8957f394b7b904d423480b709ef());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.PROP_a06a8f42fda14f2ab113c4e43f15c28d());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.PROP_d667736e33234198bdf6df5799c0b2a2());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.PROP_6406b85c36404d06b66f0540e0556bf4());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.PROP_b992937240c34f54a383e9915fed6afc());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_c739cfbcaf924bba9cc526fb2fb14059.PROP_bacb39955be84db1a82f95040bbe4343());
      }

      private sealed class MTHD_2070f2ea66c44b59852768c9acd6a5e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2070f2ea66c44b59852768c9acd6a5e2()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_40bab7d0eb6940039fa40b65b76ef0fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_40bab7d0eb6940039fa40b65b76ef0fc()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_ea379d00142548d7ab44be86e536e820 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea379d00142548d7ab44be86e536e820()
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

      private sealed class MTHD_70d61364e6cb46bcb1e786d56c1594a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70d61364e6cb46bcb1e786d56c1594a1()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_de51e45e656d46cd84acb7cbb765717c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de51e45e656d46cd84acb7cbb765717c()
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

      private sealed class MTHD_d389c37cd05d4d1da6681b62fbf3a52c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d389c37cd05d4d1da6681b62fbf3a52c()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_b25f25d685444dd896d942c7c2105b95 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b25f25d685444dd896d942c7c2105b95()
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

      private sealed class MTHD_d2d1c5f3f484444f92c3316194668116 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d2d1c5f3f484444f92c3316194668116()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_9f251c2628714b41ac9325c0d8858f64 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f251c2628714b41ac9325c0d8858f64()
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

      private sealed class MTHD_dabf60ac7dac4c6cb66d4ad2c92a5390 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dabf60ac7dac4c6cb66d4ad2c92a5390()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_1f7e43c573a44f03beddda07a183f0dc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f7e43c573a44f03beddda07a183f0dc()
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

      private sealed class MTHD_0178999ba62349ed817eb70c4144d756 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0178999ba62349ed817eb70c4144d756()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_0ea732ff6c554d63b644e9a189344074 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ea732ff6c554d63b644e9a189344074()
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

      private sealed class MTHD_9b159e6144dc4afdb630470ccd412bf4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b159e6144dc4afdb630470ccd412bf4()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color2;
        }
      }

      private sealed class MTHD_85dcf7f8582a4152920f2b3bc8ac0975 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85dcf7f8582a4152920f2b3bc8ac0975()
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

      private sealed class MTHD_495a5f5aba0f424f994809dc9be9e294 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_495a5f5aba0f424f994809dc9be9e294()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_8b1d5b0a2a4440559af3e316287288ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b1d5b0a2a4440559af3e316287288ed()
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

      private sealed class MTHD_8a6241e1378c448d9ef94a5337d0bc41 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a6241e1378c448d9ef94a5337d0bc41()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_2e53293d311f4a9b9445aa69e5252519 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2e53293d311f4a9b9445aa69e5252519()
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

      private sealed class MTHD_2855b7c76d6440ed88e3feec97607f6c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2855b7c76d6440ed88e3feec97607f6c()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_45ed39eddafa478fa4169fc2e02059d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_45ed39eddafa478fa4169fc2e02059d3()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_77e97539605f482db89d3114b4daa7f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_77e97539605f482db89d3114b4daa7f5()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_ca9a80beac59495e9cfed5c28b02c9d6 : HardwiredMemberDescriptor
      {
        internal PROP_ca9a80beac59495e9cfed5c28b02c9d6()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_51a3a823109d47079ffb356eb5dd0ad9 : HardwiredMemberDescriptor
      {
        internal PROP_51a3a823109d47079ffb356eb5dd0ad9()
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

      private sealed class PROP_99f8be1a35844a0380865dd463048da4 : HardwiredMemberDescriptor
      {
        internal PROP_99f8be1a35844a0380865dd463048da4()
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

      private sealed class PROP_efcff8957f394b7b904d423480b709ef : HardwiredMemberDescriptor
      {
        internal PROP_efcff8957f394b7b904d423480b709ef()
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

      private sealed class PROP_a06a8f42fda14f2ab113c4e43f15c28d : HardwiredMemberDescriptor
      {
        internal PROP_a06a8f42fda14f2ab113c4e43f15c28d()
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

      private sealed class PROP_d667736e33234198bdf6df5799c0b2a2 : HardwiredMemberDescriptor
      {
        internal PROP_d667736e33234198bdf6df5799c0b2a2()
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

      private sealed class PROP_6406b85c36404d06b66f0540e0556bf4 : HardwiredMemberDescriptor
      {
        internal PROP_6406b85c36404d06b66f0540e0556bf4()
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

      private sealed class PROP_b992937240c34f54a383e9915fed6afc : HardwiredMemberDescriptor
      {
        internal PROP_b992937240c34f54a383e9915fed6afc()
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

      private sealed class PROP_bacb39955be84db1a82f95040bbe4343 : HardwiredMemberDescriptor
      {
        internal PROP_bacb39955be84db1a82f95040bbe4343()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_bb51550f5be24ba7a0db0c8d25f0329f : HardwiredUserDataDescriptor
    {
      internal TYPE_bb51550f5be24ba7a0db0c8d25f0329f()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_70b12d59eb7e44cfbc6e572f5ed646ff()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_f62f9c1de6514d639779b9b308d18636()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_0f3b4d5cb7dc4cd18f0103d41534791c()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_04472ea9f0d64744904e169c22ab0ac8()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_6248a92342f044079a55389be6ac59dd()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_790cf21d00c04dc198a0f429998cca02()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_119be983727240dc98c67a344be1ad62()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_72aff68b9ed04c4e95e16178b6b78632()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_90874c0e325449f6aa220798b640d758()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_645b79d4cd3c4cc79a13b4511a8863a3()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_5da855742c0346e59084cadc60eba153()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_d73bb979c528444695c8b787e5d140fc()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_3f86952da52143ae973c7f275738a795()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_eb4a70d07b5b4380988588a801db7e3c()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_034aa738a1414c369cbf63d0fee77b19()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_81d0c56241c34f78aae5216d4b31e271()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_e8cfbfbfcd6240a8aaa722f00c3eb262()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_866ea55520294c9b86c023f30fa2606d()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_3abc3d065e5c4e4a9cf515cdcbca2cc1()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_0b372de8796f4c26bf1a194e3677244c()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_27338d5fe7d142acb79217e38c02a09e()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_5517157416684c5d8c2d8b19f1cc7b36()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_e81d2a09dfc34f16a473e7bd6ee0e961()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_de6a69ba489c40c6a2667b19d5ffcacd()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_940c4510c716462983a0b0a857d3a722()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_f8b05a88f6454d7f8edf280f90b0596f()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_eee72e1e333740da88f84cd249ddcd71()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.MTHD_b62849e5e57b4158a009854fb78f28ca()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.PROP_6bbcc92b257646cf8a1a43bae00f3e0a());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.PROP_11686c166c9a466e83ab864c060ee23f());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.PROP_6afa179a028d40a69953dd2272f61a6b());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.PROP_70cc3b7a676e488ca468fa568f242a7d());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.PROP_764e10948a504a61adcc070ebc5e812e());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.PROP_4be09bbf20fc49a688a97d8c9c89a5b8());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.PROP_dc825134684b483186b273e025880bab());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.PROP_14d58ff7823447b1ae281e4ac6858939());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.PROP_1842b4837cc343a59d8bfd6e8e4a1f66());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.PROP_26775d9e1c7b424098a053e26c44eea5());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.PROP_8646eeefdd394806a62c43c270c5b73a());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.PROP_b509ad2ad52f4d84a15c195c15ad9a46());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.PROP_df1135c2d55348c2bee652d700f1d3d6());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.PROP_10389617a0324698b3e52215a15a799d());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.PROP_511442d097c5458ca9411730df2d22da());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.PROP_ea9a9fc292544e2eb2842c79072a8989());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_bb51550f5be24ba7a0db0c8d25f0329f.PROP_9b67c24a711345e8a733163efe431cfb());
      }

      private sealed class MTHD_70b12d59eb7e44cfbc6e572f5ed646ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70b12d59eb7e44cfbc6e572f5ed646ff()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_f62f9c1de6514d639779b9b308d18636 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f62f9c1de6514d639779b9b308d18636()
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

      private sealed class MTHD_0f3b4d5cb7dc4cd18f0103d41534791c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f3b4d5cb7dc4cd18f0103d41534791c()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_04472ea9f0d64744904e169c22ab0ac8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_04472ea9f0d64744904e169c22ab0ac8()
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

      private sealed class MTHD_6248a92342f044079a55389be6ac59dd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6248a92342f044079a55389be6ac59dd()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_790cf21d00c04dc198a0f429998cca02 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_790cf21d00c04dc198a0f429998cca02()
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

      private sealed class MTHD_119be983727240dc98c67a344be1ad62 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_119be983727240dc98c67a344be1ad62()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_72aff68b9ed04c4e95e16178b6b78632 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_72aff68b9ed04c4e95e16178b6b78632()
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

      private sealed class MTHD_90874c0e325449f6aa220798b640d758 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90874c0e325449f6aa220798b640d758()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_645b79d4cd3c4cc79a13b4511a8863a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_645b79d4cd3c4cc79a13b4511a8863a3()
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

      private sealed class MTHD_5da855742c0346e59084cadc60eba153 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5da855742c0346e59084cadc60eba153()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_d73bb979c528444695c8b787e5d140fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d73bb979c528444695c8b787e5d140fc()
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

      private sealed class MTHD_3f86952da52143ae973c7f275738a795 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f86952da52143ae973c7f275738a795()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_eb4a70d07b5b4380988588a801db7e3c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb4a70d07b5b4380988588a801db7e3c()
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

      private sealed class MTHD_034aa738a1414c369cbf63d0fee77b19 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_034aa738a1414c369cbf63d0fee77b19()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_81d0c56241c34f78aae5216d4b31e271 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_81d0c56241c34f78aae5216d4b31e271()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_e8cfbfbfcd6240a8aaa722f00c3eb262 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e8cfbfbfcd6240a8aaa722f00c3eb262()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_866ea55520294c9b86c023f30fa2606d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_866ea55520294c9b86c023f30fa2606d()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_3abc3d065e5c4e4a9cf515cdcbca2cc1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3abc3d065e5c4e4a9cf515cdcbca2cc1()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_0b372de8796f4c26bf1a194e3677244c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b372de8796f4c26bf1a194e3677244c()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_27338d5fe7d142acb79217e38c02a09e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_27338d5fe7d142acb79217e38c02a09e()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_5517157416684c5d8c2d8b19f1cc7b36 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5517157416684c5d8c2d8b19f1cc7b36()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_e81d2a09dfc34f16a473e7bd6ee0e961 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e81d2a09dfc34f16a473e7bd6ee0e961()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_de6a69ba489c40c6a2667b19d5ffcacd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de6a69ba489c40c6a2667b19d5ffcacd()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_940c4510c716462983a0b0a857d3a722 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_940c4510c716462983a0b0a857d3a722()
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

      private sealed class MTHD_f8b05a88f6454d7f8edf280f90b0596f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f8b05a88f6454d7f8edf280f90b0596f()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_eee72e1e333740da88f84cd249ddcd71 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eee72e1e333740da88f84cd249ddcd71()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_b62849e5e57b4158a009854fb78f28ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b62849e5e57b4158a009854fb78f28ca()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_6bbcc92b257646cf8a1a43bae00f3e0a : HardwiredMemberDescriptor
      {
        internal PROP_6bbcc92b257646cf8a1a43bae00f3e0a()
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

      private sealed class PROP_11686c166c9a466e83ab864c060ee23f : HardwiredMemberDescriptor
      {
        internal PROP_11686c166c9a466e83ab864c060ee23f()
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

      private sealed class PROP_6afa179a028d40a69953dd2272f61a6b : HardwiredMemberDescriptor
      {
        internal PROP_6afa179a028d40a69953dd2272f61a6b()
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

      private sealed class PROP_70cc3b7a676e488ca468fa568f242a7d : HardwiredMemberDescriptor
      {
        internal PROP_70cc3b7a676e488ca468fa568f242a7d()
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

      private sealed class PROP_764e10948a504a61adcc070ebc5e812e : HardwiredMemberDescriptor
      {
        internal PROP_764e10948a504a61adcc070ebc5e812e()
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

      private sealed class PROP_4be09bbf20fc49a688a97d8c9c89a5b8 : HardwiredMemberDescriptor
      {
        internal PROP_4be09bbf20fc49a688a97d8c9c89a5b8()
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

      private sealed class PROP_dc825134684b483186b273e025880bab : HardwiredMemberDescriptor
      {
        internal PROP_dc825134684b483186b273e025880bab()
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

      private sealed class PROP_14d58ff7823447b1ae281e4ac6858939 : HardwiredMemberDescriptor
      {
        internal PROP_14d58ff7823447b1ae281e4ac6858939()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_1842b4837cc343a59d8bfd6e8e4a1f66 : HardwiredMemberDescriptor
      {
        internal PROP_1842b4837cc343a59d8bfd6e8e4a1f66()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_26775d9e1c7b424098a053e26c44eea5 : HardwiredMemberDescriptor
      {
        internal PROP_26775d9e1c7b424098a053e26c44eea5()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_8646eeefdd394806a62c43c270c5b73a : HardwiredMemberDescriptor
      {
        internal PROP_8646eeefdd394806a62c43c270c5b73a()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_b509ad2ad52f4d84a15c195c15ad9a46 : HardwiredMemberDescriptor
      {
        internal PROP_b509ad2ad52f4d84a15c195c15ad9a46()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_df1135c2d55348c2bee652d700f1d3d6 : HardwiredMemberDescriptor
      {
        internal PROP_df1135c2d55348c2bee652d700f1d3d6()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_10389617a0324698b3e52215a15a799d : HardwiredMemberDescriptor
      {
        internal PROP_10389617a0324698b3e52215a15a799d()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_511442d097c5458ca9411730df2d22da : HardwiredMemberDescriptor
      {
        internal PROP_511442d097c5458ca9411730df2d22da()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_ea9a9fc292544e2eb2842c79072a8989 : HardwiredMemberDescriptor
      {
        internal PROP_ea9a9fc292544e2eb2842c79072a8989()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_9b67c24a711345e8a733163efe431cfb : HardwiredMemberDescriptor
      {
        internal PROP_9b67c24a711345e8a733163efe431cfb()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_f8767134a2b143e0bab7850c0c2de0bf : HardwiredUserDataDescriptor
    {
      internal TYPE_f8767134a2b143e0bab7850c0c2de0bf()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f8767134a2b143e0bab7850c0c2de0bf.MTHD_129e194080084593b41466452ecf4609()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f8767134a2b143e0bab7850c0c2de0bf.MTHD_89f4c39da7054d09822d724a731cc4af()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f8767134a2b143e0bab7850c0c2de0bf.MTHD_788f3d2278164bab83a1a7295afd5030()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f8767134a2b143e0bab7850c0c2de0bf.MTHD_29028721a0d04255a38e179bc987b2b7()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f8767134a2b143e0bab7850c0c2de0bf.MTHD_953b2ab7417e486696ca7ff7d3c729aa()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f8767134a2b143e0bab7850c0c2de0bf.MTHD_d2982902f2174b57828924af76db08df()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f8767134a2b143e0bab7850c0c2de0bf.MTHD_dbbdc33fcae8430294187d034c3d64d9()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f8767134a2b143e0bab7850c0c2de0bf.MTHD_774eee16733d437faaf395bc13654a02()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f8767134a2b143e0bab7850c0c2de0bf.MTHD_daa74c7d8d084c9b99c90ad2ea379954()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f8767134a2b143e0bab7850c0c2de0bf.MTHD_39e52d22b644479a9866e513af27bd94()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f8767134a2b143e0bab7850c0c2de0bf.MTHD_1506c26c745341da8db8dd0073258fc1()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f8767134a2b143e0bab7850c0c2de0bf.MTHD_1d35e88572724f74a9dedb6af6ebdb18()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f8767134a2b143e0bab7850c0c2de0bf.MTHD_5b1daf2db2ab4972b814c9e7943a7bf5()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f8767134a2b143e0bab7850c0c2de0bf.MTHD_e1eb1064e71e49e8a84d96dadc631f8b()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f8767134a2b143e0bab7850c0c2de0bf.MTHD_84a6ea6333c54f53b59fb93c82478b16()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f8767134a2b143e0bab7850c0c2de0bf.MTHD_b2f67451d8f345fb8d2ce09f5b41c31d()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f8767134a2b143e0bab7850c0c2de0bf.MTHD_9840eb6411c4425c915d4dd8911ccf4a()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_f8767134a2b143e0bab7850c0c2de0bf.PROP_b4c28231d03047fc9c1df8b642baec24());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_f8767134a2b143e0bab7850c0c2de0bf.PROP_6c597f93c66b40bbb8809152abcb296c());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_f8767134a2b143e0bab7850c0c2de0bf.PROP_7d5e01e73e6a4e668a54bd5a65e8febd());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_f8767134a2b143e0bab7850c0c2de0bf.PROP_45da8a48f4444e86a51841f1726e96d7());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_f8767134a2b143e0bab7850c0c2de0bf.PROP_1795ad2fafe94816a8f0b15f9f991b2a());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_f8767134a2b143e0bab7850c0c2de0bf.PROP_de0ca067811f4e51b1176fed36b48204());
      }

      private sealed class MTHD_129e194080084593b41466452ecf4609 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_129e194080084593b41466452ecf4609()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_89f4c39da7054d09822d724a731cc4af : HardwiredMethodMemberDescriptor
      {
        internal MTHD_89f4c39da7054d09822d724a731cc4af()
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

      private sealed class MTHD_788f3d2278164bab83a1a7295afd5030 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_788f3d2278164bab83a1a7295afd5030()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_29028721a0d04255a38e179bc987b2b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_29028721a0d04255a38e179bc987b2b7()
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

      private sealed class MTHD_953b2ab7417e486696ca7ff7d3c729aa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_953b2ab7417e486696ca7ff7d3c729aa()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_d2982902f2174b57828924af76db08df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d2982902f2174b57828924af76db08df()
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

      private sealed class MTHD_dbbdc33fcae8430294187d034c3d64d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dbbdc33fcae8430294187d034c3d64d9()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_774eee16733d437faaf395bc13654a02 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_774eee16733d437faaf395bc13654a02()
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

      private sealed class MTHD_daa74c7d8d084c9b99c90ad2ea379954 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_daa74c7d8d084c9b99c90ad2ea379954()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_39e52d22b644479a9866e513af27bd94 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_39e52d22b644479a9866e513af27bd94()
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

      private sealed class MTHD_1506c26c745341da8db8dd0073258fc1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1506c26c745341da8db8dd0073258fc1()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_1d35e88572724f74a9dedb6af6ebdb18 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d35e88572724f74a9dedb6af6ebdb18()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_5b1daf2db2ab4972b814c9e7943a7bf5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b1daf2db2ab4972b814c9e7943a7bf5()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_e1eb1064e71e49e8a84d96dadc631f8b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e1eb1064e71e49e8a84d96dadc631f8b()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_84a6ea6333c54f53b59fb93c82478b16 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84a6ea6333c54f53b59fb93c82478b16()
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

      private sealed class MTHD_b2f67451d8f345fb8d2ce09f5b41c31d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b2f67451d8f345fb8d2ce09f5b41c31d()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_9840eb6411c4425c915d4dd8911ccf4a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9840eb6411c4425c915d4dd8911ccf4a()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_b4c28231d03047fc9c1df8b642baec24 : HardwiredMemberDescriptor
      {
        internal PROP_b4c28231d03047fc9c1df8b642baec24()
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

      private sealed class PROP_6c597f93c66b40bbb8809152abcb296c : HardwiredMemberDescriptor
      {
        internal PROP_6c597f93c66b40bbb8809152abcb296c()
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

      private sealed class PROP_7d5e01e73e6a4e668a54bd5a65e8febd : HardwiredMemberDescriptor
      {
        internal PROP_7d5e01e73e6a4e668a54bd5a65e8febd()
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

      private sealed class PROP_45da8a48f4444e86a51841f1726e96d7 : HardwiredMemberDescriptor
      {
        internal PROP_45da8a48f4444e86a51841f1726e96d7()
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

      private sealed class PROP_1795ad2fafe94816a8f0b15f9f991b2a : HardwiredMemberDescriptor
      {
        internal PROP_1795ad2fafe94816a8f0b15f9f991b2a()
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

      private sealed class PROP_de0ca067811f4e51b1176fed36b48204 : HardwiredMemberDescriptor
      {
        internal PROP_de0ca067811f4e51b1176fed36b48204()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_c960440644724b0395ca0ebeb628037f : HardwiredUserDataDescriptor
    {
      internal TYPE_c960440644724b0395ca0ebeb628037f()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c960440644724b0395ca0ebeb628037f.MTHD_fbf7bbf0f6fe4e5faccb1d6994948e99(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c960440644724b0395ca0ebeb628037f.MTHD_bf70a928c82446ee8dae6025461106ef()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c960440644724b0395ca0ebeb628037f.MTHD_262d527151404bf9a60a45406f30b5c8(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c960440644724b0395ca0ebeb628037f.MTHD_4eda934bd9304438ad81317e88d043c5()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c960440644724b0395ca0ebeb628037f.MTHD_da2638bf964846ed9892a6b52fff2f95()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c960440644724b0395ca0ebeb628037f.MTHD_9dccb4e5c6d14e5ab243734a8f02bc95()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c960440644724b0395ca0ebeb628037f.MTHD_3f8d4a3d134e4c2abdd201b11338345d()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c960440644724b0395ca0ebeb628037f.MTHD_0cd921d05f9f4e9492655a278addfa32()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c960440644724b0395ca0ebeb628037f.MTHD_d178def7eba546e48a74bd7e76b59fd9()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c960440644724b0395ca0ebeb628037f.MTHD_d41212cbdc3845d19db469a1f956ab70()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c960440644724b0395ca0ebeb628037f.MTHD_805ca1c79b78453ba1b072c8446cd0aa()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c960440644724b0395ca0ebeb628037f.MTHD_00a13ff0593d473e9aa210961a72e966(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c960440644724b0395ca0ebeb628037f.MTHD_e177f97bbe0f4bc09100d3fa3b11b4ba()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c960440644724b0395ca0ebeb628037f.MTHD_8780e6abe68b46549ea71ea4126104e6(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c960440644724b0395ca0ebeb628037f.MTHD_5aa600a7bcbf42149ab202f8b99dfe0f()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c960440644724b0395ca0ebeb628037f.MTHD_12bce7501ea2469495fb94a2a15fe78c(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c960440644724b0395ca0ebeb628037f.MTHD_f5567cb33d1846c18d7d6b799dffa2ca()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c960440644724b0395ca0ebeb628037f.MTHD_ee522bbf12c84b3a97d3a8f3bc7a1936(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c960440644724b0395ca0ebeb628037f.MTHD_b1857dbd1f5c46518b7902cd50a6e9e9()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c960440644724b0395ca0ebeb628037f.MTHD_2b96e88e2ff34737aaf0441b0e483459(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c960440644724b0395ca0ebeb628037f.MTHD_0b25e64a5ebf4b5cae720ce19fb5a17a()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c960440644724b0395ca0ebeb628037f.MTHD_3d1f6791c1d64f1fa3f94f9e2e331ceb()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c960440644724b0395ca0ebeb628037f.MTHD_7bed686abd4c416db57f36a8a1f0c48b()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_c960440644724b0395ca0ebeb628037f.FLDV_4b8ef9f3cc03465888ad5e24b590435d());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_c960440644724b0395ca0ebeb628037f.FLDV_751ff68387ab410387862883a5acd0ab());
      }

      private sealed class MTHD_fbf7bbf0f6fe4e5faccb1d6994948e99 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fbf7bbf0f6fe4e5faccb1d6994948e99()
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

      private sealed class MTHD_bf70a928c82446ee8dae6025461106ef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf70a928c82446ee8dae6025461106ef()
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

      private sealed class MTHD_262d527151404bf9a60a45406f30b5c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_262d527151404bf9a60a45406f30b5c8()
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

      private sealed class MTHD_4eda934bd9304438ad81317e88d043c5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4eda934bd9304438ad81317e88d043c5()
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

      private sealed class MTHD_da2638bf964846ed9892a6b52fff2f95 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_da2638bf964846ed9892a6b52fff2f95()
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

      private sealed class MTHD_9dccb4e5c6d14e5ab243734a8f02bc95 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9dccb4e5c6d14e5ab243734a8f02bc95()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_3f8d4a3d134e4c2abdd201b11338345d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f8d4a3d134e4c2abdd201b11338345d()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_0cd921d05f9f4e9492655a278addfa32 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0cd921d05f9f4e9492655a278addfa32()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_d178def7eba546e48a74bd7e76b59fd9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d178def7eba546e48a74bd7e76b59fd9()
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

      private sealed class MTHD_d41212cbdc3845d19db469a1f956ab70 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d41212cbdc3845d19db469a1f956ab70()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_805ca1c79b78453ba1b072c8446cd0aa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_805ca1c79b78453ba1b072c8446cd0aa()
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

      private sealed class MTHD_00a13ff0593d473e9aa210961a72e966 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_00a13ff0593d473e9aa210961a72e966()
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

      private sealed class MTHD_e177f97bbe0f4bc09100d3fa3b11b4ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e177f97bbe0f4bc09100d3fa3b11b4ba()
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

      private sealed class MTHD_8780e6abe68b46549ea71ea4126104e6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8780e6abe68b46549ea71ea4126104e6()
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

      private sealed class MTHD_5aa600a7bcbf42149ab202f8b99dfe0f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5aa600a7bcbf42149ab202f8b99dfe0f()
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

      private sealed class MTHD_12bce7501ea2469495fb94a2a15fe78c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_12bce7501ea2469495fb94a2a15fe78c()
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

      private sealed class MTHD_f5567cb33d1846c18d7d6b799dffa2ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f5567cb33d1846c18d7d6b799dffa2ca()
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

      private sealed class MTHD_ee522bbf12c84b3a97d3a8f3bc7a1936 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee522bbf12c84b3a97d3a8f3bc7a1936()
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

      private sealed class MTHD_b1857dbd1f5c46518b7902cd50a6e9e9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b1857dbd1f5c46518b7902cd50a6e9e9()
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

      private sealed class MTHD_2b96e88e2ff34737aaf0441b0e483459 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b96e88e2ff34737aaf0441b0e483459()
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

      private sealed class MTHD_0b25e64a5ebf4b5cae720ce19fb5a17a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b25e64a5ebf4b5cae720ce19fb5a17a()
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

      private sealed class MTHD_3d1f6791c1d64f1fa3f94f9e2e331ceb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d1f6791c1d64f1fa3f94f9e2e331ceb()
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

      private sealed class MTHD_7bed686abd4c416db57f36a8a1f0c48b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7bed686abd4c416db57f36a8a1f0c48b()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_4b8ef9f3cc03465888ad5e24b590435d : HardwiredMemberDescriptor
      {
        internal FLDV_4b8ef9f3cc03465888ad5e24b590435d()
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

      private sealed class FLDV_751ff68387ab410387862883a5acd0ab : HardwiredMemberDescriptor
      {
        internal FLDV_751ff68387ab410387862883a5acd0ab()
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

    private sealed class TYPE_fcf072b4c9e44ba7966a9891d40373af : HardwiredUserDataDescriptor
    {
      internal TYPE_fcf072b4c9e44ba7966a9891d40373af()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fcf072b4c9e44ba7966a9891d40373af.MTHD_282277dbef9c4dc5837c0ed652147d08()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fcf072b4c9e44ba7966a9891d40373af.MTHD_3f749cb23b764ee4b82b8e4bdb18da10()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fcf072b4c9e44ba7966a9891d40373af.MTHD_4d13be2a812a466791e728f65b1fa352()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fcf072b4c9e44ba7966a9891d40373af.MTHD_292b2bec42fa491880ffb49184b4f1a2()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fcf072b4c9e44ba7966a9891d40373af.MTHD_94231f077f6f425993ab7a947b1f9d8a()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fcf072b4c9e44ba7966a9891d40373af.MTHD_f9895515a3514da4a249ca590f31b879()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_fcf072b4c9e44ba7966a9891d40373af.FLDV_d407a3740c6741c1847b817278a8d3e6());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_fcf072b4c9e44ba7966a9891d40373af.FLDV_69241a9dce524e6b86a519fa8d6adffa());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_fcf072b4c9e44ba7966a9891d40373af.FLDV_962edaa5919a4de881cd124b503d651a());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_fcf072b4c9e44ba7966a9891d40373af.FLDV_0d30b2f7f6ad4a4b9a1a923ee1284b56());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_fcf072b4c9e44ba7966a9891d40373af.FLDV_1d2e6ade7f4b4136abb7c8ffe038cd3a());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_fcf072b4c9e44ba7966a9891d40373af.FLDV_7b4e1969893741d2a6ed7f70ad9c3837());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_fcf072b4c9e44ba7966a9891d40373af.FLDV_8b4c37edc9c24c32ac08a21fa1f366e2());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_fcf072b4c9e44ba7966a9891d40373af.FLDV_210d8462045c4f27839eb5e754e3fb50());
        this.AddMember("prestige", (IMemberDescriptor) new Bridge.TYPE_fcf072b4c9e44ba7966a9891d40373af.FLDV_7de1b04578204805b638292ade4a10dc());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_fcf072b4c9e44ba7966a9891d40373af.FLDV_40e0dd7cad5f4264a39f64e43fd1fbdc());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_fcf072b4c9e44ba7966a9891d40373af.FLDV_7319e7b63a814dab97543ea3cc9e2bac());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_fcf072b4c9e44ba7966a9891d40373af.FLDV_1c00c57bdd434763a196268c1092a67a());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_fcf072b4c9e44ba7966a9891d40373af.FLDV_52c7a2cbee1342a8a52cf5a3b409a324());
      }

      private sealed class MTHD_282277dbef9c4dc5837c0ed652147d08 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_282277dbef9c4dc5837c0ed652147d08()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_3f749cb23b764ee4b82b8e4bdb18da10 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f749cb23b764ee4b82b8e4bdb18da10()
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

      private sealed class MTHD_4d13be2a812a466791e728f65b1fa352 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d13be2a812a466791e728f65b1fa352()
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

      private sealed class MTHD_292b2bec42fa491880ffb49184b4f1a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_292b2bec42fa491880ffb49184b4f1a2()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_94231f077f6f425993ab7a947b1f9d8a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_94231f077f6f425993ab7a947b1f9d8a()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_f9895515a3514da4a249ca590f31b879 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f9895515a3514da4a249ca590f31b879()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_d407a3740c6741c1847b817278a8d3e6 : HardwiredMemberDescriptor
      {
        internal FLDV_d407a3740c6741c1847b817278a8d3e6()
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

      private sealed class FLDV_69241a9dce524e6b86a519fa8d6adffa : HardwiredMemberDescriptor
      {
        internal FLDV_69241a9dce524e6b86a519fa8d6adffa()
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

      private sealed class FLDV_962edaa5919a4de881cd124b503d651a : HardwiredMemberDescriptor
      {
        internal FLDV_962edaa5919a4de881cd124b503d651a()
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

      private sealed class FLDV_0d30b2f7f6ad4a4b9a1a923ee1284b56 : HardwiredMemberDescriptor
      {
        internal FLDV_0d30b2f7f6ad4a4b9a1a923ee1284b56()
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

      private sealed class FLDV_1d2e6ade7f4b4136abb7c8ffe038cd3a : HardwiredMemberDescriptor
      {
        internal FLDV_1d2e6ade7f4b4136abb7c8ffe038cd3a()
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

      private sealed class FLDV_7b4e1969893741d2a6ed7f70ad9c3837 : HardwiredMemberDescriptor
      {
        internal FLDV_7b4e1969893741d2a6ed7f70ad9c3837()
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

      private sealed class FLDV_8b4c37edc9c24c32ac08a21fa1f366e2 : HardwiredMemberDescriptor
      {
        internal FLDV_8b4c37edc9c24c32ac08a21fa1f366e2()
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

      private sealed class FLDV_210d8462045c4f27839eb5e754e3fb50 : HardwiredMemberDescriptor
      {
        internal FLDV_210d8462045c4f27839eb5e754e3fb50()
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

      private sealed class FLDV_7de1b04578204805b638292ade4a10dc : HardwiredMemberDescriptor
      {
        internal FLDV_7de1b04578204805b638292ade4a10dc()
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

      private sealed class FLDV_40e0dd7cad5f4264a39f64e43fd1fbdc : HardwiredMemberDescriptor
      {
        internal FLDV_40e0dd7cad5f4264a39f64e43fd1fbdc()
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

      private sealed class FLDV_7319e7b63a814dab97543ea3cc9e2bac : HardwiredMemberDescriptor
      {
        internal FLDV_7319e7b63a814dab97543ea3cc9e2bac()
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

      private sealed class FLDV_1c00c57bdd434763a196268c1092a67a : HardwiredMemberDescriptor
      {
        internal FLDV_1c00c57bdd434763a196268c1092a67a()
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

      private sealed class FLDV_52c7a2cbee1342a8a52cf5a3b409a324 : HardwiredMemberDescriptor
      {
        internal FLDV_52c7a2cbee1342a8a52cf5a3b409a324()
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

    private sealed class TYPE_7f3c403fcc454ca7b9da709f9c78e190 : HardwiredUserDataDescriptor
    {
      internal TYPE_7f3c403fcc454ca7b9da709f9c78e190()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_a40cbaa7e0ef459fbf0dde2bb4d248c8()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_ece2b99cc2804a22b3beeb390182f402()
        }));
        this.AddMember("get_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_d718f98d57c84965938b6c622c3d5442()
        }));
        this.AddMember("set_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_79b8cbc3214f4ffa8500cfec71931864()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_bd4e40a26d4d4eae82827dc8537556f8()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_7d2c4cdbca7b49f0b3489aae5d90adcc()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_f80b9ccdca2a495dbc4735502487612a()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_d722504b56b3436ab460cefda7cac5d5()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_c71749e2e5934ead842410c06c4212c9()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_7a63ae497a2f4cf98e01784d0815a76a()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_4e20811a2ab8423aad76dfc267cc9800()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_dbb39e0326a8462a9c5e9786d5369b68()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_441d985d2e014f7680255865e6bd0550()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_b46f7edc20e341c0affc7ec1ac4788ad()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_7239aa9a2d71403ea8225f9a6ae8c9cd()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_bac81817edd947db9aea4eed126f298c()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_81949177d60844c4aff77b0077c338c2()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_cb12b4a0485b4a2bb6709b0bd4c26e12()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_4b599296f9214a71b9f3ea3f1fc5e4da()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_0f3ece902fea499caf4f7f08a61412f8()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_22564f08bc074415acad7be3ea2afb92()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_2bdf789cbd45483884e8907078a466f6()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_b2a0ef3028864c85981ca0c27e017051()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_355dcf7711d14489b59d31f57a20340a()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_92d4227f9c114062a1574f27935659e0()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_3cb485e5ae8f431ea06554c9f38dd961()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_b6cf13033e0d4b7689209f8fb5308a42()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_75514de9b5074146800a4bfd6a6e4f4b()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_94246a2064b543b68607ee65af46e9e6()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_2b3e702d4be34a06a31dbd895d27a490()
        }));
        this.AddMember("get_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_04709db8c82649c2bf725911edfc75cf()
        }));
        this.AddMember("set_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_a6e22e780cd541c482565623756dee4d()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_db0c5a39112a4ba893a4b4e1aeae25ec()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_7b2d9fa1bdb54f0ea36aefc4d16ae680()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_f7f0ef2d70094736ab241d3b5479ab3f()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_2c2f8c0eb01b40839b371f984180828a()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_f01f1dd3296243fbb384fdb25d1ed64d()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_1ad8735f032644e1956be953f027ad04()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_e4c7824e6059483da266058e9a25c58d()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_8b9f072df0be41bfa2b5d57f0362a080()
        }));
        this.AddMember("get_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_1227d71c13e74107805cf36882a06448()
        }));
        this.AddMember("set_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_04b6ada6143b43bab9c94516119387dd()
        }));
        this.AddMember("get_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_e57051ac813a4775963c24bdcda693a0()
        }));
        this.AddMember("set_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_8b15db12425842cfab33c78017ddaba7()
        }));
        this.AddMember("get_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_9e25b25121c34a28b592eec2d4caa372()
        }));
        this.AddMember("set_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_2c77bbfe9e434e5085d89a231d927e25()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_bc154fbdc9c24a4391b037d0f19d88a5()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_e6b756da5966404d90babcf7cc79b066()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_15720a78990b4e638544034f0f505539()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_21e1ff3456534408b4c26dfba745a7bf()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_0ef8a8e301ca4e16aef4a81380bbb091()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_ff7ac9a85d874a08bb999bf7fa6590b8()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_e1d01ab4dd1e486e9fed955973b0ba36()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_bc670e1b23d14a74a5af0463ee3e9beb()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_e48945d0d30b4606b702d382c046ba28()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_efa7c7e8bbb7441eb50b0c551c188c05()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_aa600545f3974f8aa2df784413f5860b()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_1ad09041d82a4b3b9bad807b7fb59a22()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_a05837241c8d4c0d9262dfdd83aac02a()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.MTHD_8c61ba6f590b43c9997665f1d2060c4f()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.PROP_03d00a02cd75469694443f9edb004c60());
        this.AddMember("visible", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.PROP_7e544ca95a104f999483d9e90192ece4());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.PROP_4b06859183124d6a86055ce0a335f00d());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.PROP_107bc45c3116428cb88dbe5d4fa7f607());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.PROP_4f7007183b4a4ed6bcaf2acbc6f830ef());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.PROP_d4811b5577a64ebfb14b845cee112a0d());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.PROP_a71c195a567b47948ee27e200535046a());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.PROP_937c3f6f394346c495e1b4071c53c7a3());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.PROP_a115486471cb450eb60f63c50c71906d());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.PROP_7991918fa2ee48aaa6e652f617a031fb());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.PROP_a96e078352b5459daccd47881a944820());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.PROP_118a4cc462d24ab69928307f0be8a63c());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.PROP_decd09164a754771a5f2849201640a28());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.PROP_4ab793a929344ba7b6ed8f6aee4242da());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.PROP_5e9d99a4f81a46a39643215d2ac1912c());
        this.AddMember("onClick2", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.PROP_275f4f586f334081b6b786b7675e4a90());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.PROP_788abdca051845f3a3408075b4f43b73());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.PROP_391eb93b4e2441d8acb2d76561eec400());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.PROP_89a0fc54403f45c8a0a12c18897d3838());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.PROP_ea1f42b78ba947d6ae4dcd235c60cb47());
        this.AddMember("textColor2", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.PROP_143878cb496340548ce79b5d345de7d1());
        this.AddMember("highlightColor", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.PROP_6cfb2c243588400ea56c677d012ea7df());
        this.AddMember("highlightColor2", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.PROP_52f8fbb4486e45fe82bc21d2494c571c());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.PROP_7f68c420ff454b2cbeda849d6bc98c94());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.PROP_a116063267a849faab72eacc41e04dad());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.FLDV_fa36f84053fa4112b57d8c1beaa470ac());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.FLDV_83f588e42ce946149b2adec366a55182());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_7f3c403fcc454ca7b9da709f9c78e190.FLDV_9a2c762f2a3f451d8bd6976324297198());
      }

      private sealed class MTHD_a40cbaa7e0ef459fbf0dde2bb4d248c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a40cbaa7e0ef459fbf0dde2bb4d248c8()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_ece2b99cc2804a22b3beeb390182f402 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ece2b99cc2804a22b3beeb390182f402()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_d718f98d57c84965938b6c622c3d5442 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d718f98d57c84965938b6c622c3d5442()
        {
          this.Initialize("get_visible", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).visible;
        }
      }

      private sealed class MTHD_79b8cbc3214f4ffa8500cfec71931864 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_79b8cbc3214f4ffa8500cfec71931864()
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

      private sealed class MTHD_bd4e40a26d4d4eae82827dc8537556f8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd4e40a26d4d4eae82827dc8537556f8()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_7d2c4cdbca7b49f0b3489aae5d90adcc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7d2c4cdbca7b49f0b3489aae5d90adcc()
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

      private sealed class MTHD_f80b9ccdca2a495dbc4735502487612a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f80b9ccdca2a495dbc4735502487612a()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_d722504b56b3436ab460cefda7cac5d5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d722504b56b3436ab460cefda7cac5d5()
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

      private sealed class MTHD_c71749e2e5934ead842410c06c4212c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c71749e2e5934ead842410c06c4212c9()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_7a63ae497a2f4cf98e01784d0815a76a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a63ae497a2f4cf98e01784d0815a76a()
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

      private sealed class MTHD_4e20811a2ab8423aad76dfc267cc9800 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e20811a2ab8423aad76dfc267cc9800()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_dbb39e0326a8462a9c5e9786d5369b68 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dbb39e0326a8462a9c5e9786d5369b68()
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

      private sealed class MTHD_441d985d2e014f7680255865e6bd0550 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_441d985d2e014f7680255865e6bd0550()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_b46f7edc20e341c0affc7ec1ac4788ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b46f7edc20e341c0affc7ec1ac4788ad()
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

      private sealed class MTHD_7239aa9a2d71403ea8225f9a6ae8c9cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7239aa9a2d71403ea8225f9a6ae8c9cd()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_bac81817edd947db9aea4eed126f298c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bac81817edd947db9aea4eed126f298c()
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

      private sealed class MTHD_81949177d60844c4aff77b0077c338c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_81949177d60844c4aff77b0077c338c2()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_cb12b4a0485b4a2bb6709b0bd4c26e12 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cb12b4a0485b4a2bb6709b0bd4c26e12()
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

      private sealed class MTHD_4b599296f9214a71b9f3ea3f1fc5e4da : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b599296f9214a71b9f3ea3f1fc5e4da()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_0f3ece902fea499caf4f7f08a61412f8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f3ece902fea499caf4f7f08a61412f8()
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

      private sealed class MTHD_22564f08bc074415acad7be3ea2afb92 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22564f08bc074415acad7be3ea2afb92()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_2bdf789cbd45483884e8907078a466f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2bdf789cbd45483884e8907078a466f6()
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

      private sealed class MTHD_b2a0ef3028864c85981ca0c27e017051 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b2a0ef3028864c85981ca0c27e017051()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_355dcf7711d14489b59d31f57a20340a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_355dcf7711d14489b59d31f57a20340a()
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

      private sealed class MTHD_92d4227f9c114062a1574f27935659e0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_92d4227f9c114062a1574f27935659e0()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_3cb485e5ae8f431ea06554c9f38dd961 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3cb485e5ae8f431ea06554c9f38dd961()
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

      private sealed class MTHD_b6cf13033e0d4b7689209f8fb5308a42 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b6cf13033e0d4b7689209f8fb5308a42()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_75514de9b5074146800a4bfd6a6e4f4b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75514de9b5074146800a4bfd6a6e4f4b()
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

      private sealed class MTHD_94246a2064b543b68607ee65af46e9e6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_94246a2064b543b68607ee65af46e9e6()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_2b3e702d4be34a06a31dbd895d27a490 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b3e702d4be34a06a31dbd895d27a490()
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

      private sealed class MTHD_04709db8c82649c2bf725911edfc75cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_04709db8c82649c2bf725911edfc75cf()
        {
          this.Initialize("get_onClick2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick2;
        }
      }

      private sealed class MTHD_a6e22e780cd541c482565623756dee4d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6e22e780cd541c482565623756dee4d()
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

      private sealed class MTHD_db0c5a39112a4ba893a4b4e1aeae25ec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db0c5a39112a4ba893a4b4e1aeae25ec()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_7b2d9fa1bdb54f0ea36aefc4d16ae680 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b2d9fa1bdb54f0ea36aefc4d16ae680()
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

      private sealed class MTHD_f7f0ef2d70094736ab241d3b5479ab3f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7f0ef2d70094736ab241d3b5479ab3f()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color2;
        }
      }

      private sealed class MTHD_2c2f8c0eb01b40839b371f984180828a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c2f8c0eb01b40839b371f984180828a()
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

      private sealed class MTHD_f01f1dd3296243fbb384fdb25d1ed64d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f01f1dd3296243fbb384fdb25d1ed64d()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_1ad8735f032644e1956be953f027ad04 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ad8735f032644e1956be953f027ad04()
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

      private sealed class MTHD_e4c7824e6059483da266058e9a25c58d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e4c7824e6059483da266058e9a25c58d()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_8b9f072df0be41bfa2b5d57f0362a080 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b9f072df0be41bfa2b5d57f0362a080()
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

      private sealed class MTHD_1227d71c13e74107805cf36882a06448 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1227d71c13e74107805cf36882a06448()
        {
          this.Initialize("get_textColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor2;
        }
      }

      private sealed class MTHD_04b6ada6143b43bab9c94516119387dd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_04b6ada6143b43bab9c94516119387dd()
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

      private sealed class MTHD_e57051ac813a4775963c24bdcda693a0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e57051ac813a4775963c24bdcda693a0()
        {
          this.Initialize("get_highlightColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor;
        }
      }

      private sealed class MTHD_8b15db12425842cfab33c78017ddaba7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b15db12425842cfab33c78017ddaba7()
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

      private sealed class MTHD_9e25b25121c34a28b592eec2d4caa372 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e25b25121c34a28b592eec2d4caa372()
        {
          this.Initialize("get_highlightColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor2;
        }
      }

      private sealed class MTHD_2c77bbfe9e434e5085d89a231d927e25 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c77bbfe9e434e5085d89a231d927e25()
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

      private sealed class MTHD_bc154fbdc9c24a4391b037d0f19d88a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bc154fbdc9c24a4391b037d0f19d88a5()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_e6b756da5966404d90babcf7cc79b066 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e6b756da5966404d90babcf7cc79b066()
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

      private sealed class MTHD_15720a78990b4e638544034f0f505539 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15720a78990b4e638544034f0f505539()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_21e1ff3456534408b4c26dfba745a7bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_21e1ff3456534408b4c26dfba745a7bf()
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

      private sealed class MTHD_0ef8a8e301ca4e16aef4a81380bbb091 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ef8a8e301ca4e16aef4a81380bbb091()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ff7ac9a85d874a08bb999bf7fa6590b8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff7ac9a85d874a08bb999bf7fa6590b8()
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

      private sealed class MTHD_e1d01ab4dd1e486e9fed955973b0ba36 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e1d01ab4dd1e486e9fed955973b0ba36()
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

      private sealed class MTHD_bc670e1b23d14a74a5af0463ee3e9beb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bc670e1b23d14a74a5af0463ee3e9beb()
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

      private sealed class MTHD_e48945d0d30b4606b702d382c046ba28 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e48945d0d30b4606b702d382c046ba28()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_efa7c7e8bbb7441eb50b0c551c188c05 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_efa7c7e8bbb7441eb50b0c551c188c05()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_aa600545f3974f8aa2df784413f5860b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa600545f3974f8aa2df784413f5860b()
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

      private sealed class MTHD_1ad09041d82a4b3b9bad807b7fb59a22 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ad09041d82a4b3b9bad807b7fb59a22()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_a05837241c8d4c0d9262dfdd83aac02a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a05837241c8d4c0d9262dfdd83aac02a()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_8c61ba6f590b43c9997665f1d2060c4f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c61ba6f590b43c9997665f1d2060c4f()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_03d00a02cd75469694443f9edb004c60 : HardwiredMemberDescriptor
      {
        internal PROP_03d00a02cd75469694443f9edb004c60()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_7e544ca95a104f999483d9e90192ece4 : HardwiredMemberDescriptor
      {
        internal PROP_7e544ca95a104f999483d9e90192ece4()
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

      private sealed class PROP_4b06859183124d6a86055ce0a335f00d : HardwiredMemberDescriptor
      {
        internal PROP_4b06859183124d6a86055ce0a335f00d()
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

      private sealed class PROP_107bc45c3116428cb88dbe5d4fa7f607 : HardwiredMemberDescriptor
      {
        internal PROP_107bc45c3116428cb88dbe5d4fa7f607()
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

      private sealed class PROP_4f7007183b4a4ed6bcaf2acbc6f830ef : HardwiredMemberDescriptor
      {
        internal PROP_4f7007183b4a4ed6bcaf2acbc6f830ef()
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

      private sealed class PROP_d4811b5577a64ebfb14b845cee112a0d : HardwiredMemberDescriptor
      {
        internal PROP_d4811b5577a64ebfb14b845cee112a0d()
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

      private sealed class PROP_a71c195a567b47948ee27e200535046a : HardwiredMemberDescriptor
      {
        internal PROP_a71c195a567b47948ee27e200535046a()
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

      private sealed class PROP_937c3f6f394346c495e1b4071c53c7a3 : HardwiredMemberDescriptor
      {
        internal PROP_937c3f6f394346c495e1b4071c53c7a3()
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

      private sealed class PROP_a115486471cb450eb60f63c50c71906d : HardwiredMemberDescriptor
      {
        internal PROP_a115486471cb450eb60f63c50c71906d()
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

      private sealed class PROP_7991918fa2ee48aaa6e652f617a031fb : HardwiredMemberDescriptor
      {
        internal PROP_7991918fa2ee48aaa6e652f617a031fb()
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

      private sealed class PROP_a96e078352b5459daccd47881a944820 : HardwiredMemberDescriptor
      {
        internal PROP_a96e078352b5459daccd47881a944820()
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

      private sealed class PROP_118a4cc462d24ab69928307f0be8a63c : HardwiredMemberDescriptor
      {
        internal PROP_118a4cc462d24ab69928307f0be8a63c()
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

      private sealed class PROP_decd09164a754771a5f2849201640a28 : HardwiredMemberDescriptor
      {
        internal PROP_decd09164a754771a5f2849201640a28()
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

      private sealed class PROP_4ab793a929344ba7b6ed8f6aee4242da : HardwiredMemberDescriptor
      {
        internal PROP_4ab793a929344ba7b6ed8f6aee4242da()
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

      private sealed class PROP_5e9d99a4f81a46a39643215d2ac1912c : HardwiredMemberDescriptor
      {
        internal PROP_5e9d99a4f81a46a39643215d2ac1912c()
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

      private sealed class PROP_275f4f586f334081b6b786b7675e4a90 : HardwiredMemberDescriptor
      {
        internal PROP_275f4f586f334081b6b786b7675e4a90()
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

      private sealed class PROP_788abdca051845f3a3408075b4f43b73 : HardwiredMemberDescriptor
      {
        internal PROP_788abdca051845f3a3408075b4f43b73()
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

      private sealed class PROP_391eb93b4e2441d8acb2d76561eec400 : HardwiredMemberDescriptor
      {
        internal PROP_391eb93b4e2441d8acb2d76561eec400()
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

      private sealed class PROP_89a0fc54403f45c8a0a12c18897d3838 : HardwiredMemberDescriptor
      {
        internal PROP_89a0fc54403f45c8a0a12c18897d3838()
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

      private sealed class PROP_ea1f42b78ba947d6ae4dcd235c60cb47 : HardwiredMemberDescriptor
      {
        internal PROP_ea1f42b78ba947d6ae4dcd235c60cb47()
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

      private sealed class PROP_143878cb496340548ce79b5d345de7d1 : HardwiredMemberDescriptor
      {
        internal PROP_143878cb496340548ce79b5d345de7d1()
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

      private sealed class PROP_6cfb2c243588400ea56c677d012ea7df : HardwiredMemberDescriptor
      {
        internal PROP_6cfb2c243588400ea56c677d012ea7df()
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

      private sealed class PROP_52f8fbb4486e45fe82bc21d2494c571c : HardwiredMemberDescriptor
      {
        internal PROP_52f8fbb4486e45fe82bc21d2494c571c()
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

      private sealed class PROP_7f68c420ff454b2cbeda849d6bc98c94 : HardwiredMemberDescriptor
      {
        internal PROP_7f68c420ff454b2cbeda849d6bc98c94()
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

      private sealed class PROP_a116063267a849faab72eacc41e04dad : HardwiredMemberDescriptor
      {
        internal PROP_a116063267a849faab72eacc41e04dad()
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

      private sealed class FLDV_fa36f84053fa4112b57d8c1beaa470ac : HardwiredMemberDescriptor
      {
        internal FLDV_fa36f84053fa4112b57d8c1beaa470ac()
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

      private sealed class FLDV_83f588e42ce946149b2adec366a55182 : HardwiredMemberDescriptor
      {
        internal FLDV_83f588e42ce946149b2adec366a55182()
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

      private sealed class FLDV_9a2c762f2a3f451d8bd6976324297198 : HardwiredMemberDescriptor
      {
        internal FLDV_9a2c762f2a3f451d8bd6976324297198()
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

    private sealed class TYPE_f64f1c9929c8400d995c0ebd807208b3 : HardwiredUserDataDescriptor
    {
      internal TYPE_f64f1c9929c8400d995c0ebd807208b3()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f64f1c9929c8400d995c0ebd807208b3.MTHD_a52d6478ed5f4af5a555a6857f746fb2()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f64f1c9929c8400d995c0ebd807208b3.MTHD_87ebec37b16f4944a93c2fd12ccf6702()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f64f1c9929c8400d995c0ebd807208b3.MTHD_f823e6858b8647f7b0971b489b1a18f4()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f64f1c9929c8400d995c0ebd807208b3.MTHD_0b2abe0cd4ea457dad85895a19a7def7()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f64f1c9929c8400d995c0ebd807208b3.MTHD_d8f103cd343a4542aeae48a79d461299()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f64f1c9929c8400d995c0ebd807208b3.MTHD_9384c7217eaa43f793b3365d80623bd6()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_f64f1c9929c8400d995c0ebd807208b3.FLDV_d76cf3644f06459da8272bf388d41596());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_f64f1c9929c8400d995c0ebd807208b3.FLDV_0e4b0cb66de14f8a8b998f1241519718());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_f64f1c9929c8400d995c0ebd807208b3.FLDV_11e7693f838b40a388baa246a9173a15());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_f64f1c9929c8400d995c0ebd807208b3.FLDV_d3a866f6d5ae41ac9c9c0786b5e8dc75());
      }

      private sealed class MTHD_a52d6478ed5f4af5a555a6857f746fb2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a52d6478ed5f4af5a555a6857f746fb2()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_87ebec37b16f4944a93c2fd12ccf6702 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_87ebec37b16f4944a93c2fd12ccf6702()
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

      private sealed class MTHD_f823e6858b8647f7b0971b489b1a18f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f823e6858b8647f7b0971b489b1a18f4()
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

      private sealed class MTHD_0b2abe0cd4ea457dad85895a19a7def7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b2abe0cd4ea457dad85895a19a7def7()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_d8f103cd343a4542aeae48a79d461299 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8f103cd343a4542aeae48a79d461299()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_9384c7217eaa43f793b3365d80623bd6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9384c7217eaa43f793b3365d80623bd6()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_d76cf3644f06459da8272bf388d41596 : HardwiredMemberDescriptor
      {
        internal FLDV_d76cf3644f06459da8272bf388d41596()
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

      private sealed class FLDV_0e4b0cb66de14f8a8b998f1241519718 : HardwiredMemberDescriptor
      {
        internal FLDV_0e4b0cb66de14f8a8b998f1241519718()
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

      private sealed class FLDV_11e7693f838b40a388baa246a9173a15 : HardwiredMemberDescriptor
      {
        internal FLDV_11e7693f838b40a388baa246a9173a15()
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

      private sealed class FLDV_d3a866f6d5ae41ac9c9c0786b5e8dc75 : HardwiredMemberDescriptor
      {
        internal FLDV_d3a866f6d5ae41ac9c9c0786b5e8dc75()
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

    private sealed class TYPE_2313f7ae9aa94795a3c762a2cc2e2062 : HardwiredUserDataDescriptor
    {
      internal TYPE_2313f7ae9aa94795a3c762a2cc2e2062()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2313f7ae9aa94795a3c762a2cc2e2062.MTHD_bbaabbdb39cb47228a2d8ce9dfdc7767()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2313f7ae9aa94795a3c762a2cc2e2062.MTHD_4a477a8fad2e4b7da71b6f5412e84da0()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2313f7ae9aa94795a3c762a2cc2e2062.MTHD_a31cc60daab24668b8951982f928d59f()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2313f7ae9aa94795a3c762a2cc2e2062.MTHD_75ae433d3e7a49688bdf6ade77623d30()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2313f7ae9aa94795a3c762a2cc2e2062.MTHD_0b5783855b2743eda01d000de6bc664f()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_2313f7ae9aa94795a3c762a2cc2e2062.FLDV_8b71d838beeb40589ca92ee5ef31c714());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_2313f7ae9aa94795a3c762a2cc2e2062.FLDV_53be8d5044e54bae98f250babe628fd9());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_2313f7ae9aa94795a3c762a2cc2e2062.FLDV_4d852173847d4cc0a753563b2959fc1e());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_2313f7ae9aa94795a3c762a2cc2e2062.FLDV_850afd3467f24d6b8e5195a95a8101de());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_2313f7ae9aa94795a3c762a2cc2e2062.FLDV_4790dab8bad5453caaa49791b4fac6d9());
      }

      private sealed class MTHD_bbaabbdb39cb47228a2d8ce9dfdc7767 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bbaabbdb39cb47228a2d8ce9dfdc7767()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_4a477a8fad2e4b7da71b6f5412e84da0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a477a8fad2e4b7da71b6f5412e84da0()
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

      private sealed class MTHD_a31cc60daab24668b8951982f928d59f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a31cc60daab24668b8951982f928d59f()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_75ae433d3e7a49688bdf6ade77623d30 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75ae433d3e7a49688bdf6ade77623d30()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_0b5783855b2743eda01d000de6bc664f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b5783855b2743eda01d000de6bc664f()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_8b71d838beeb40589ca92ee5ef31c714 : HardwiredMemberDescriptor
      {
        internal FLDV_8b71d838beeb40589ca92ee5ef31c714()
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

      private sealed class FLDV_53be8d5044e54bae98f250babe628fd9 : HardwiredMemberDescriptor
      {
        internal FLDV_53be8d5044e54bae98f250babe628fd9()
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

      private sealed class FLDV_4d852173847d4cc0a753563b2959fc1e : HardwiredMemberDescriptor
      {
        internal FLDV_4d852173847d4cc0a753563b2959fc1e()
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

      private sealed class FLDV_850afd3467f24d6b8e5195a95a8101de : HardwiredMemberDescriptor
      {
        internal FLDV_850afd3467f24d6b8e5195a95a8101de()
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

      private sealed class FLDV_4790dab8bad5453caaa49791b4fac6d9 : HardwiredMemberDescriptor
      {
        internal FLDV_4790dab8bad5453caaa49791b4fac6d9()
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

    private sealed class TYPE_b5e75d3fb9b349cfba754279c7eaa18b : HardwiredUserDataDescriptor
    {
      internal TYPE_b5e75d3fb9b349cfba754279c7eaa18b()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b5e75d3fb9b349cfba754279c7eaa18b.MTHD_561c3abf21504bdda8ccd237c6f2edf4()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b5e75d3fb9b349cfba754279c7eaa18b.MTHD_19ab77183d9b44c78769e6a1d1d8d2fa()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b5e75d3fb9b349cfba754279c7eaa18b.MTHD_c583e8631b2a4f7481a8700bdb107780()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b5e75d3fb9b349cfba754279c7eaa18b.MTHD_80ff4ee0080e4dcdba9ccb5424d989b4()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b5e75d3fb9b349cfba754279c7eaa18b.MTHD_f6fc8ad9eddb4e5195974baa2d6a788e()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b5e75d3fb9b349cfba754279c7eaa18b.MTHD_32a5afa2e697498b9bb6ebe966a200cd()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b5e75d3fb9b349cfba754279c7eaa18b.MTHD_a6e08a83f11d430783832675bbc4ac7d()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b5e75d3fb9b349cfba754279c7eaa18b.MTHD_030af620e4ce4b62aeed1aba3f2810aa()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b5e75d3fb9b349cfba754279c7eaa18b.MTHD_02f20d1afe4a4073a9c2559304120bda()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b5e75d3fb9b349cfba754279c7eaa18b.MTHD_2990489fead34a44889df7e1c9e5e6de()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b5e75d3fb9b349cfba754279c7eaa18b.MTHD_173dbd58ae0e4d4d934bb45ffeaac23c()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b5e75d3fb9b349cfba754279c7eaa18b.MTHD_dce96eb68d914b20a8efb90ace737709()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b5e75d3fb9b349cfba754279c7eaa18b.MTHD_b133167f0f4649a7a8ca4626b6f3707c()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_b5e75d3fb9b349cfba754279c7eaa18b.FLDV_bee21f53ef9c4ddb86bcdbf76dbda505());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_b5e75d3fb9b349cfba754279c7eaa18b.FLDV_8742f51f016645d1a3e40d5bc67dccde());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_b5e75d3fb9b349cfba754279c7eaa18b.FLDV_cf8afe1f4f8a42489cec98935ce7d688());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_b5e75d3fb9b349cfba754279c7eaa18b.FLDV_3dc4e9966e8942a6b8918349c0ebf5d9());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_b5e75d3fb9b349cfba754279c7eaa18b.FLDV_c28bbfa8a7ed4f83bf37c0a7a0a95ccd());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_b5e75d3fb9b349cfba754279c7eaa18b.FLDV_9aef71b6ed4444a39b87b90c7e17ea46());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_b5e75d3fb9b349cfba754279c7eaa18b.FLDV_32545fe8db654fca9d3ee6beabf155ba());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_b5e75d3fb9b349cfba754279c7eaa18b.FLDV_5ffc5a9fde204978bb5b26db77bc0dde());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_b5e75d3fb9b349cfba754279c7eaa18b.DVAL_0270e31cb1c44c39a5a0ba121914007d());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_b5e75d3fb9b349cfba754279c7eaa18b.DVAL_c467ee9881e84cf5be89642d586989d9());
      }

      private sealed class MTHD_561c3abf21504bdda8ccd237c6f2edf4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_561c3abf21504bdda8ccd237c6f2edf4()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_19ab77183d9b44c78769e6a1d1d8d2fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_19ab77183d9b44c78769e6a1d1d8d2fa()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_c583e8631b2a4f7481a8700bdb107780 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c583e8631b2a4f7481a8700bdb107780()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_80ff4ee0080e4dcdba9ccb5424d989b4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_80ff4ee0080e4dcdba9ccb5424d989b4()
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

      private sealed class MTHD_f6fc8ad9eddb4e5195974baa2d6a788e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f6fc8ad9eddb4e5195974baa2d6a788e()
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

      private sealed class MTHD_32a5afa2e697498b9bb6ebe966a200cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_32a5afa2e697498b9bb6ebe966a200cd()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_a6e08a83f11d430783832675bbc4ac7d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6e08a83f11d430783832675bbc4ac7d()
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

      private sealed class MTHD_030af620e4ce4b62aeed1aba3f2810aa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_030af620e4ce4b62aeed1aba3f2810aa()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_02f20d1afe4a4073a9c2559304120bda : HardwiredMethodMemberDescriptor
      {
        internal MTHD_02f20d1afe4a4073a9c2559304120bda()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_2990489fead34a44889df7e1c9e5e6de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2990489fead34a44889df7e1c9e5e6de()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_173dbd58ae0e4d4d934bb45ffeaac23c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_173dbd58ae0e4d4d934bb45ffeaac23c()
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

      private sealed class MTHD_dce96eb68d914b20a8efb90ace737709 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dce96eb68d914b20a8efb90ace737709()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_b133167f0f4649a7a8ca4626b6f3707c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b133167f0f4649a7a8ca4626b6f3707c()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_bee21f53ef9c4ddb86bcdbf76dbda505 : HardwiredMemberDescriptor
      {
        internal FLDV_bee21f53ef9c4ddb86bcdbf76dbda505()
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

      private sealed class FLDV_8742f51f016645d1a3e40d5bc67dccde : HardwiredMemberDescriptor
      {
        internal FLDV_8742f51f016645d1a3e40d5bc67dccde()
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

      private sealed class FLDV_cf8afe1f4f8a42489cec98935ce7d688 : HardwiredMemberDescriptor
      {
        internal FLDV_cf8afe1f4f8a42489cec98935ce7d688()
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

      private sealed class FLDV_3dc4e9966e8942a6b8918349c0ebf5d9 : HardwiredMemberDescriptor
      {
        internal FLDV_3dc4e9966e8942a6b8918349c0ebf5d9()
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

      private sealed class FLDV_c28bbfa8a7ed4f83bf37c0a7a0a95ccd : HardwiredMemberDescriptor
      {
        internal FLDV_c28bbfa8a7ed4f83bf37c0a7a0a95ccd()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_9aef71b6ed4444a39b87b90c7e17ea46 : HardwiredMemberDescriptor
      {
        internal FLDV_9aef71b6ed4444a39b87b90c7e17ea46()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_32545fe8db654fca9d3ee6beabf155ba : HardwiredMemberDescriptor
      {
        internal FLDV_32545fe8db654fca9d3ee6beabf155ba()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_5ffc5a9fde204978bb5b26db77bc0dde : HardwiredMemberDescriptor
      {
        internal FLDV_5ffc5a9fde204978bb5b26db77bc0dde()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_0270e31cb1c44c39a5a0ba121914007d : DynValueMemberDescriptor
      {
        internal DVAL_0270e31cb1c44c39a5a0ba121914007d()
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

      private sealed class DVAL_c467ee9881e84cf5be89642d586989d9 : DynValueMemberDescriptor
      {
        internal DVAL_c467ee9881e84cf5be89642d586989d9()
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

    private sealed class TYPE_1c35834dda6f4abdb79472b56b9f1fa2 : HardwiredUserDataDescriptor
    {
      internal TYPE_1c35834dda6f4abdb79472b56b9f1fa2()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c35834dda6f4abdb79472b56b9f1fa2.MTHD_2d0b289e68254be78ca336d4d7b15c6c()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c35834dda6f4abdb79472b56b9f1fa2.MTHD_b32ad77f377245aa94f11b53573952ab()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c35834dda6f4abdb79472b56b9f1fa2.MTHD_3f785397b17c430f9d479c2370d32c07(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c35834dda6f4abdb79472b56b9f1fa2.MTHD_6132c8be419347b98a3b44d1fbc0359d()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c35834dda6f4abdb79472b56b9f1fa2.MTHD_4a08303618b24d7e9dee8872c35401e2(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c35834dda6f4abdb79472b56b9f1fa2.MTHD_b62557ef3e8c46439461bafccdfdabdb()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c35834dda6f4abdb79472b56b9f1fa2.MTHD_41deebee42314a99b4b7b2435b96d602()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c35834dda6f4abdb79472b56b9f1fa2.MTHD_e3367acca46e4ffc91558791a5a18d7b()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c35834dda6f4abdb79472b56b9f1fa2.MTHD_b86524b46e0249568f9632c10577f457()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1c35834dda6f4abdb79472b56b9f1fa2.MTHD_2d1a342c22754baebcccc3e2d2ea7524()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_1c35834dda6f4abdb79472b56b9f1fa2.FLDV_c8379eae8d7848d59934628bf4bed1f3());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_1c35834dda6f4abdb79472b56b9f1fa2.FLDV_61139a2b0e3945b3a0d7a08f40f12d1f());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_1c35834dda6f4abdb79472b56b9f1fa2.FLDV_c22c7bad75fb4e17985bdeac6cdea3d2());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_1c35834dda6f4abdb79472b56b9f1fa2.FLDV_b26c285004754ddf97a7288bcc7d3dc2());
        this.AddMember("white", (IMemberDescriptor) new Bridge.TYPE_1c35834dda6f4abdb79472b56b9f1fa2.FLDV_b1ab172f026a4ed7be00588150a0d161());
      }

      private sealed class MTHD_2d0b289e68254be78ca336d4d7b15c6c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d0b289e68254be78ca336d4d7b15c6c()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_b32ad77f377245aa94f11b53573952ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b32ad77f377245aa94f11b53573952ab()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_3f785397b17c430f9d479c2370d32c07 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f785397b17c430f9d479c2370d32c07()
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

      private sealed class MTHD_6132c8be419347b98a3b44d1fbc0359d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6132c8be419347b98a3b44d1fbc0359d()
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

      private sealed class MTHD_4a08303618b24d7e9dee8872c35401e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a08303618b24d7e9dee8872c35401e2()
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

      private sealed class MTHD_b62557ef3e8c46439461bafccdfdabdb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b62557ef3e8c46439461bafccdfdabdb()
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

      private sealed class MTHD_41deebee42314a99b4b7b2435b96d602 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41deebee42314a99b4b7b2435b96d602()
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

      private sealed class MTHD_e3367acca46e4ffc91558791a5a18d7b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e3367acca46e4ffc91558791a5a18d7b()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_b86524b46e0249568f9632c10577f457 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b86524b46e0249568f9632c10577f457()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_2d1a342c22754baebcccc3e2d2ea7524 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d1a342c22754baebcccc3e2d2ea7524()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_c8379eae8d7848d59934628bf4bed1f3 : HardwiredMemberDescriptor
      {
        internal FLDV_c8379eae8d7848d59934628bf4bed1f3()
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

      private sealed class FLDV_61139a2b0e3945b3a0d7a08f40f12d1f : HardwiredMemberDescriptor
      {
        internal FLDV_61139a2b0e3945b3a0d7a08f40f12d1f()
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

      private sealed class FLDV_c22c7bad75fb4e17985bdeac6cdea3d2 : HardwiredMemberDescriptor
      {
        internal FLDV_c22c7bad75fb4e17985bdeac6cdea3d2()
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

      private sealed class FLDV_b26c285004754ddf97a7288bcc7d3dc2 : HardwiredMemberDescriptor
      {
        internal FLDV_b26c285004754ddf97a7288bcc7d3dc2()
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

      private sealed class FLDV_b1ab172f026a4ed7be00588150a0d161 : HardwiredMemberDescriptor
      {
        internal FLDV_b1ab172f026a4ed7be00588150a0d161()
          : base(typeof (LuaColor), "white", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) LuaColor.white;
        }
      }
    }

    private sealed class TYPE_b58f1adcaf2244a48f5a23c2c16a765c : HardwiredUserDataDescriptor
    {
      internal TYPE_b58f1adcaf2244a48f5a23c2c16a765c()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b58f1adcaf2244a48f5a23c2c16a765c.MTHD_a30b731bea1949419275eff2e2b0176b()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b58f1adcaf2244a48f5a23c2c16a765c.MTHD_4929272441394d69a69da4d09f8f02f2()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b58f1adcaf2244a48f5a23c2c16a765c.MTHD_1be08a916502428295b450ef2eb7a5d1()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b58f1adcaf2244a48f5a23c2c16a765c.MTHD_65264e7ecad94481ad4879b5b86d561f()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b58f1adcaf2244a48f5a23c2c16a765c.MTHD_8a3d76a1e72b4874802fa9eb159c6697()
        }));
      }

      private sealed class MTHD_a30b731bea1949419275eff2e2b0176b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a30b731bea1949419275eff2e2b0176b()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_4929272441394d69a69da4d09f8f02f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4929272441394d69a69da4d09f8f02f2()
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

      private sealed class MTHD_1be08a916502428295b450ef2eb7a5d1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1be08a916502428295b450ef2eb7a5d1()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_65264e7ecad94481ad4879b5b86d561f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65264e7ecad94481ad4879b5b86d561f()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_8a3d76a1e72b4874802fa9eb159c6697 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a3d76a1e72b4874802fa9eb159c6697()
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
