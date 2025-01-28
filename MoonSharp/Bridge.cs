
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
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_8aa86f586d0b447c8b946f090dc88c53());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_62e03a9b545b4dec8b50b898beb1a36c());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_f1ff049e5f944459ac32b759436aebbf());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_18885e133f8843af9176dc7ffb8655db());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_dd38bc58b0284112992f7ea388aa1d6e());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_66df29e9caa04c4d8581bb036e2d5c1e());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_77b24fc2f3584da4912c816257f1c63a());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_a187a273484a4c3baebc307a4934a4d3());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_d0b0468ce88c4c38a172949524bbeee0());
    }

    private sealed class TYPE_85f5dd43f3f44982adedebe63fc5166c : HardwiredUserDataDescriptor
    {
      internal TYPE_85f5dd43f3f44982adedebe63fc5166c()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_97f72efcdfa44d8ca0bd81a59b969e86()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_aa4fe6881c9541b2b4fd0a752b6bd0ad()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_0d56b20ac43e414dbfaea6c6feb786be()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_d5d880959cee4af1a99de865de6c666f()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_43446caf2c254e4796e52b123c83d8bd()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_5a3f046df131447198e3d0766fe4d0f7()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_e9d5e6b4f4db4ca2b0ad1551d3909a82()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_6aed59f5a7334ba78427985c686817d3()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_2116fa30cd9e4a9b89f0b2abb9329d3a()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_e24a0a3845e041269178fdb26c2c1db7()
        }));
        this.AddMember("hideInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("hideInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_59cc0ea5483d49e1bb445a15c6951699()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_b8119fcb60234c118b8018bca593f570()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_b0e20278e29a4bea95ecc5fc4178117e()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_c8d42401d9df49bf957b1fd5c94489e3()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_a82854db2eda40728fda92f08c35c830()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_78225053f6f045aab7eb984e28845c1a()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_be056d9b537a441c9cce42fae7bb6338()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_ddda162b35fa4b5e825ac2f21a3d008c()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_4a6732b43a954e15af8e31237221e895()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_ef05c76c22f444bdb1ab786754da5f8e()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_f49d5fdafe514f1283caf426c17ef2e9()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_231ef984517b48f5ba564926b398189b()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_4c6f85d42f924c229bc846dcd09b90cd()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_7a3ac2f90bae4140809626ec8983ef89()
        }));
        this.AddMember("get_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_66488ed5930c4c9d95966cffac108488()
        }));
        this.AddMember("set_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_4c0b786c9bc74d99aaa648abb182c7a3()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_6b096759997b4773928a232ebcedab57()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_70da45c596d24490ade8c01e73d95a01()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_778aa04db0404cb48ed552c4a10e6c18()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_ab98128b83e2415f94e5b8b5f6b93517()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_db566311dabe49658a2aa904460b69e7()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_12688d6ff95d41ffa09963e522f219cc()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_950d38a72aa042daa5fb301634f7e5ed()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_73205ad7a07d4d78bee06eb2529e16d3()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_a3617140460a4a65b08dae36259d5d60()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_e119e8325fc9490f88055642c779b312()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_a2d6268e1a63401587ad088122dc04b5()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_60fe59a81ace46458b111114721aff9f()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_dc73b96fc2ee4eaca11673c31c19840f()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_1eb53566c1ab4bd685e8892675a7e5fe()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_5e1a391e0e8f4391bd61b5031dddde81()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_c2366736735543689a0fe6ffacbf38cf()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_28edf6c59a9546f9bce29114ff3eb5ca()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_7b2f75143c7740399be45c7b05e0c0a5()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_9edb31e44a9a4b98a259d74bccf0cda4()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_e12ead3277694455a05f6b40d7de2b8e()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_723f2ebee9054992b09684b1e2a666e7()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_2880cfab5fa1491889818942dea0b9eb()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_a3f20eb20d014a4ca2402a8ee0616914()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_769395c646cc443eabc82d409b9e6058()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_f68cb58ad6b04686a7b1b15447e1b318()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_d1408abf489942f8a48dce0b43262d72()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_9a940343cdb745edbd351f253712a6d6()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_f9a976d930b049a6aef968e0994bdb4a()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_51704a80b35f4184a68d34c9964a5661()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_718b4080a7104c029befff08a99f11f7()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_ab206af4a3c442139ea080f220bfa3a7()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_fc9829c1a0bc4013a128e1d01d609178()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_0c7339133aa34d2ebffaca8ce94bbfa9()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_2713855935f94bb3af6fe5f2badbf87e()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_83f2333a73ed422a8361f3e1a5ddbe91()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_d8617079e6d94f17bbe5abd01d940970()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_10e8f288f2ee4334bfe15a9654f5efd3()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_05164b43144841c79b54ffdb63e3ecfb()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_2d24ea4d7e8043c1b0d29053a3ccfb32()
        }));
        this.AddMember("Dispose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Dispose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_b7475925dd604c65984690c33d1824ad()
        }));
        this.AddMember("drawImage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawImage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_6144e2daa2fa413c9656919bf37d4847()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_bfd45b6c07d14738a2e747636cb16b1b()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_5fbfec5fbca34a33994b38e8864aabea()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_1d15a65d7ae34ebdba2259c53c5d5430()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_92221f065d36414c963fcda5114068e1()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_d0e11415c114479b80e1c4dd976accbb()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_feee23bb30184aa5bc0b7f0721842252()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_ce82f4612b7e4d3ea26980a8ad4446df()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_12cc340392a449c2855a613ddb0d9107()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_507c085b93e04e1594ec1783bdc99e7e()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_5117a2d6a66044708c1f672cc3fcfce2()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_09a966bc9a6e4fad8424705bbf3d59a6()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_d88ef78028474269bcb274e7c4861068()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_dc57eb12351b43bfa12b81adb5c3f6b6()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_f26432c0e09c4f7186fb70cbdb7333c9()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_e8a71edf102d42e5bdc0440f51648e13()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_0ed43ca58ff44a6db52591747469ee48()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_0726f49e004a4373a079a5530cbc08c7()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_130ad7f260e14b21863301bbb3cab7e2()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_d60cbd419c9b4ae2b6b2776f0d3d0935()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_28623f924e0c43ffafa5388c667717e1()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_a1f504a0bec542fdb07bb68d0b709325()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_6e4aaa596071484091134a2c78c017fa()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_4798498d27cb42cd8622790b47ee0512()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_dc1d683cd84a4512938c597f178f3756()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_17e4a80254e44c79b7cb091a498cc510()
        }));
        this.AddMember("cameraFollow", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("cameraFollow", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_7522889203fd476d922ec22de1eedab7()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_6c338e59ce93474fac7c6a7fd696f0e8()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_9054a76379f84f338e7c1398d88059cd()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_9cc4e582ced14800b4aad04af75a3978()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_51e713614aaa4c818b48ccd58cb54a2c()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_bb9c63ad32f64daabf233eb5d637f803()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_3d90a1ac462c4b4991ab212d9cebb37a(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_36fa50ec79704708b941ba2927a1500d()
        }));
        this.AddMember("getKeyBinds", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getKeyBinds", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_1fa4834190a94058b6e08aec116d09aa()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_19f2dc58cb9d4e4eaac5449311088236()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_79171dc57ee34d40829e5e7269e62979()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_eb85c5f5de294044aa12b9211be441dc()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.MTHD_957c60b43de647eda9533c35496cee4d()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_9ce7fa26a3fe47f994a92e1745c0d80b());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_db388411984745d5bc32be609dea541d());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_d039b4d75cd14d1f8ecf32ec64dfecfa());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_23ae1672c29948088baa6e0028057d8d());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_510c776ec67348c2a797905a833747c4());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_da920bef354d4e9b9ec16e20f026377c());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_026ef70f092842bea61f60aad5146883());
        this.AddMember("allowMinionMovement", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_a667bf77a29740968a5f43959dc65557());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_a135e0a173c54412a1e948a3b7728d79());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_829eb8302ae34ebf9de09882d1249709());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_99311f5f5d624d79bda94daf2ec59a62());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_d5d3f31b96544e1087fdf3d622f59bc7());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_ee7f5efd8c044bf1a714266c5fbfa6e6());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_1dce217337d64d10b896ede3a54009cc());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_6d97e18b33e24231a380e5b8f1a06d65());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_7558513a925d489f8cfc3648a8d593c6());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_96e06cebff964dcdbf1a23fb6038fb64());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_d9b42627c2ff46a6839f522ce48f5b11());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_679a4072108a4195a194704db1d1ab3f());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_a8ae1a4fa7214c19a695551a95e5795b());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_edfca26ab5004170af639d12ca1fd8db());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_35baea1de06845988da1883427bfe747());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_e1a20af14f084fb59a7b0c9981c60138());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_45c4a6139b374d9ba83d4632c9c95459());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_9ce21621a99b4e8fbafc018d85910dd2());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_42e2b57cc9244a0fa0be8e86f50b5545());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_6aac8678e7424984b68b7635d64bbe7b());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_bc5008f6b42f4ad7983bbdd9a3f7acf4());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_ec39abbe5fea4da689a0c5877fb0fd8c());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_8cbec267dd214ad9ae404bdaca12a7b2());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_305776f7f4594ae4928c032e7e1cbd35());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_a7432bf713ed415fbc846729ba7e8edf());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_85f5dd43f3f44982adedebe63fc5166c.PROP_de170186072f485dae5bfa84bff01b8b());
      }

      private sealed class MTHD_97f72efcdfa44d8ca0bd81a59b969e86 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97f72efcdfa44d8ca0bd81a59b969e86()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_aa4fe6881c9541b2b4fd0a752b6bd0ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa4fe6881c9541b2b4fd0a752b6bd0ad()
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

      private sealed class MTHD_0d56b20ac43e414dbfaea6c6feb786be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d56b20ac43e414dbfaea6c6feb786be()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_d5d880959cee4af1a99de865de6c666f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d5d880959cee4af1a99de865de6c666f()
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

      private sealed class MTHD_43446caf2c254e4796e52b123c83d8bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_43446caf2c254e4796e52b123c83d8bd()
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

      private sealed class MTHD_5a3f046df131447198e3d0766fe4d0f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5a3f046df131447198e3d0766fe4d0f7()
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

      private sealed class MTHD_e9d5e6b4f4db4ca2b0ad1551d3909a82 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e9d5e6b4f4db4ca2b0ad1551d3909a82()
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

      private sealed class MTHD_6aed59f5a7334ba78427985c686817d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6aed59f5a7334ba78427985c686817d3()
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

      private sealed class MTHD_2116fa30cd9e4a9b89f0b2abb9329d3a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2116fa30cd9e4a9b89f0b2abb9329d3a()
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

      private sealed class MTHD_e24a0a3845e041269178fdb26c2c1db7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e24a0a3845e041269178fdb26c2c1db7()
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

      private sealed class MTHD_59cc0ea5483d49e1bb445a15c6951699 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_59cc0ea5483d49e1bb445a15c6951699()
        {
          this.Initialize("hideInfo", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).hideInfo();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b8119fcb60234c118b8018bca593f570 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b8119fcb60234c118b8018bca593f570()
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

      private sealed class MTHD_b0e20278e29a4bea95ecc5fc4178117e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b0e20278e29a4bea95ecc5fc4178117e()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_c8d42401d9df49bf957b1fd5c94489e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c8d42401d9df49bf957b1fd5c94489e3()
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

      private sealed class MTHD_a82854db2eda40728fda92f08c35c830 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a82854db2eda40728fda92f08c35c830()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_78225053f6f045aab7eb984e28845c1a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_78225053f6f045aab7eb984e28845c1a()
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

      private sealed class MTHD_be056d9b537a441c9cce42fae7bb6338 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be056d9b537a441c9cce42fae7bb6338()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_ddda162b35fa4b5e825ac2f21a3d008c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ddda162b35fa4b5e825ac2f21a3d008c()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_4a6732b43a954e15af8e31237221e895 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a6732b43a954e15af8e31237221e895()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_ef05c76c22f444bdb1ab786754da5f8e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef05c76c22f444bdb1ab786754da5f8e()
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

      private sealed class MTHD_f49d5fdafe514f1283caf426c17ef2e9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f49d5fdafe514f1283caf426c17ef2e9()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_231ef984517b48f5ba564926b398189b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_231ef984517b48f5ba564926b398189b()
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

      private sealed class MTHD_4c6f85d42f924c229bc846dcd09b90cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c6f85d42f924c229bc846dcd09b90cd()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_7a3ac2f90bae4140809626ec8983ef89 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a3ac2f90bae4140809626ec8983ef89()
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

      private sealed class MTHD_66488ed5930c4c9d95966cffac108488 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_66488ed5930c4c9d95966cffac108488()
        {
          this.Initialize("get_allowMinionMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMinionMovement;
        }
      }

      private sealed class MTHD_4c0b786c9bc74d99aaa648abb182c7a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c0b786c9bc74d99aaa648abb182c7a3()
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

      private sealed class MTHD_6b096759997b4773928a232ebcedab57 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b096759997b4773928a232ebcedab57()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_70da45c596d24490ade8c01e73d95a01 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70da45c596d24490ade8c01e73d95a01()
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

      private sealed class MTHD_778aa04db0404cb48ed552c4a10e6c18 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_778aa04db0404cb48ed552c4a10e6c18()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_ab98128b83e2415f94e5b8b5f6b93517 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab98128b83e2415f94e5b8b5f6b93517()
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

      private sealed class MTHD_db566311dabe49658a2aa904460b69e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db566311dabe49658a2aa904460b69e7()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_12688d6ff95d41ffa09963e522f219cc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_12688d6ff95d41ffa09963e522f219cc()
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

      private sealed class MTHD_950d38a72aa042daa5fb301634f7e5ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_950d38a72aa042daa5fb301634f7e5ed()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_73205ad7a07d4d78bee06eb2529e16d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_73205ad7a07d4d78bee06eb2529e16d3()
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

      private sealed class MTHD_a3617140460a4a65b08dae36259d5d60 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a3617140460a4a65b08dae36259d5d60()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_e119e8325fc9490f88055642c779b312 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e119e8325fc9490f88055642c779b312()
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

      private sealed class MTHD_a2d6268e1a63401587ad088122dc04b5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2d6268e1a63401587ad088122dc04b5()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_60fe59a81ace46458b111114721aff9f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60fe59a81ace46458b111114721aff9f()
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

      private sealed class MTHD_dc73b96fc2ee4eaca11673c31c19840f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc73b96fc2ee4eaca11673c31c19840f()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_1eb53566c1ab4bd685e8892675a7e5fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1eb53566c1ab4bd685e8892675a7e5fe()
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

      private sealed class MTHD_5e1a391e0e8f4391bd61b5031dddde81 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e1a391e0e8f4391bd61b5031dddde81()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_c2366736735543689a0fe6ffacbf38cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c2366736735543689a0fe6ffacbf38cf()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_28edf6c59a9546f9bce29114ff3eb5ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_28edf6c59a9546f9bce29114ff3eb5ca()
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

      private sealed class MTHD_7b2f75143c7740399be45c7b05e0c0a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b2f75143c7740399be45c7b05e0c0a5()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_9edb31e44a9a4b98a259d74bccf0cda4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9edb31e44a9a4b98a259d74bccf0cda4()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_e12ead3277694455a05f6b40d7de2b8e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e12ead3277694455a05f6b40d7de2b8e()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_723f2ebee9054992b09684b1e2a666e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_723f2ebee9054992b09684b1e2a666e7()
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

      private sealed class MTHD_2880cfab5fa1491889818942dea0b9eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2880cfab5fa1491889818942dea0b9eb()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_a3f20eb20d014a4ca2402a8ee0616914 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a3f20eb20d014a4ca2402a8ee0616914()
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

      private sealed class MTHD_769395c646cc443eabc82d409b9e6058 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_769395c646cc443eabc82d409b9e6058()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_f68cb58ad6b04686a7b1b15447e1b318 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f68cb58ad6b04686a7b1b15447e1b318()
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

      private sealed class MTHD_d1408abf489942f8a48dce0b43262d72 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1408abf489942f8a48dce0b43262d72()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_9a940343cdb745edbd351f253712a6d6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9a940343cdb745edbd351f253712a6d6()
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

      private sealed class MTHD_f9a976d930b049a6aef968e0994bdb4a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f9a976d930b049a6aef968e0994bdb4a()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_51704a80b35f4184a68d34c9964a5661 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_51704a80b35f4184a68d34c9964a5661()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_718b4080a7104c029befff08a99f11f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_718b4080a7104c029befff08a99f11f7()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_ab206af4a3c442139ea080f220bfa3a7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab206af4a3c442139ea080f220bfa3a7()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_fc9829c1a0bc4013a128e1d01d609178 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fc9829c1a0bc4013a128e1d01d609178()
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

      private sealed class MTHD_0c7339133aa34d2ebffaca8ce94bbfa9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c7339133aa34d2ebffaca8ce94bbfa9()
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

      private sealed class MTHD_2713855935f94bb3af6fe5f2badbf87e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2713855935f94bb3af6fe5f2badbf87e()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_83f2333a73ed422a8361f3e1a5ddbe91 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_83f2333a73ed422a8361f3e1a5ddbe91()
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

      private sealed class MTHD_d8617079e6d94f17bbe5abd01d940970 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8617079e6d94f17bbe5abd01d940970()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_10e8f288f2ee4334bfe15a9654f5efd3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_10e8f288f2ee4334bfe15a9654f5efd3()
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

      private sealed class MTHD_05164b43144841c79b54ffdb63e3ecfb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_05164b43144841c79b54ffdb63e3ecfb()
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

      private sealed class MTHD_2d24ea4d7e8043c1b0d29053a3ccfb32 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d24ea4d7e8043c1b0d29053a3ccfb32()
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

      private sealed class MTHD_b7475925dd604c65984690c33d1824ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b7475925dd604c65984690c33d1824ad()
        {
          this.Initialize("Dispose", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ContainerGame.Dispose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_6144e2daa2fa413c9656919bf37d4847 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6144e2daa2fa413c9656919bf37d4847()
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

      private sealed class MTHD_bfd45b6c07d14738a2e747636cb16b1b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bfd45b6c07d14738a2e747636cb16b1b()
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

      private sealed class MTHD_5fbfec5fbca34a33994b38e8864aabea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5fbfec5fbca34a33994b38e8864aabea()
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

      private sealed class MTHD_1d15a65d7ae34ebdba2259c53c5d5430 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d15a65d7ae34ebdba2259c53c5d5430()
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

      private sealed class MTHD_92221f065d36414c963fcda5114068e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_92221f065d36414c963fcda5114068e1()
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

      private sealed class MTHD_d0e11415c114479b80e1c4dd976accbb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0e11415c114479b80e1c4dd976accbb()
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

      private sealed class MTHD_feee23bb30184aa5bc0b7f0721842252 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_feee23bb30184aa5bc0b7f0721842252()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ce82f4612b7e4d3ea26980a8ad4446df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ce82f4612b7e4d3ea26980a8ad4446df()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_12cc340392a449c2855a613ddb0d9107 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_12cc340392a449c2855a613ddb0d9107()
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

      private sealed class MTHD_507c085b93e04e1594ec1783bdc99e7e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_507c085b93e04e1594ec1783bdc99e7e()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_5117a2d6a66044708c1f672cc3fcfce2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5117a2d6a66044708c1f672cc3fcfce2()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_09a966bc9a6e4fad8424705bbf3d59a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_09a966bc9a6e4fad8424705bbf3d59a6()
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

      private sealed class MTHD_d88ef78028474269bcb274e7c4861068 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d88ef78028474269bcb274e7c4861068()
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

      private sealed class MTHD_dc57eb12351b43bfa12b81adb5c3f6b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc57eb12351b43bfa12b81adb5c3f6b6()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f26432c0e09c4f7186fb70cbdb7333c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f26432c0e09c4f7186fb70cbdb7333c9()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_e8a71edf102d42e5bdc0440f51648e13 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e8a71edf102d42e5bdc0440f51648e13()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_0ed43ca58ff44a6db52591747469ee48 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ed43ca58ff44a6db52591747469ee48()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_0726f49e004a4373a079a5530cbc08c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0726f49e004a4373a079a5530cbc08c7()
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

      private sealed class MTHD_130ad7f260e14b21863301bbb3cab7e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_130ad7f260e14b21863301bbb3cab7e2()
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

      private sealed class MTHD_d60cbd419c9b4ae2b6b2776f0d3d0935 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d60cbd419c9b4ae2b6b2776f0d3d0935()
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

      private sealed class MTHD_28623f924e0c43ffafa5388c667717e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_28623f924e0c43ffafa5388c667717e1()
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

      private sealed class MTHD_a1f504a0bec542fdb07bb68d0b709325 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1f504a0bec542fdb07bb68d0b709325()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_6e4aaa596071484091134a2c78c017fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e4aaa596071484091134a2c78c017fa()
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

      private sealed class MTHD_4798498d27cb42cd8622790b47ee0512 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4798498d27cb42cd8622790b47ee0512()
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

      private sealed class MTHD_dc1d683cd84a4512938c597f178f3756 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc1d683cd84a4512938c597f178f3756()
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

      private sealed class MTHD_17e4a80254e44c79b7cb091a498cc510 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_17e4a80254e44c79b7cb091a498cc510()
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

      private sealed class MTHD_7522889203fd476d922ec22de1eedab7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7522889203fd476d922ec22de1eedab7()
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

      private sealed class MTHD_6c338e59ce93474fac7c6a7fd696f0e8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6c338e59ce93474fac7c6a7fd696f0e8()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_9054a76379f84f338e7c1398d88059cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9054a76379f84f338e7c1398d88059cd()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_9cc4e582ced14800b4aad04af75a3978 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9cc4e582ced14800b4aad04af75a3978()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_51e713614aaa4c818b48ccd58cb54a2c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_51e713614aaa4c818b48ccd58cb54a2c()
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

      private sealed class MTHD_bb9c63ad32f64daabf233eb5d637f803 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb9c63ad32f64daabf233eb5d637f803()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_3d90a1ac462c4b4991ab212d9cebb37a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d90a1ac462c4b4991ab212d9cebb37a()
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

      private sealed class MTHD_36fa50ec79704708b941ba2927a1500d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_36fa50ec79704708b941ba2927a1500d()
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

      private sealed class MTHD_1fa4834190a94058b6e08aec116d09aa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1fa4834190a94058b6e08aec116d09aa()
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

      private sealed class MTHD_19f2dc58cb9d4e4eaac5449311088236 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_19f2dc58cb9d4e4eaac5449311088236()
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

      private sealed class MTHD_79171dc57ee34d40829e5e7269e62979 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_79171dc57ee34d40829e5e7269e62979()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_eb85c5f5de294044aa12b9211be441dc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb85c5f5de294044aa12b9211be441dc()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_957c60b43de647eda9533c35496cee4d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_957c60b43de647eda9533c35496cee4d()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_9ce7fa26a3fe47f994a92e1745c0d80b : HardwiredMemberDescriptor
      {
        internal PROP_9ce7fa26a3fe47f994a92e1745c0d80b()
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

      private sealed class PROP_db388411984745d5bc32be609dea541d : HardwiredMemberDescriptor
      {
        internal PROP_db388411984745d5bc32be609dea541d()
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

      private sealed class PROP_d039b4d75cd14d1f8ecf32ec64dfecfa : HardwiredMemberDescriptor
      {
        internal PROP_d039b4d75cd14d1f8ecf32ec64dfecfa()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_23ae1672c29948088baa6e0028057d8d : HardwiredMemberDescriptor
      {
        internal PROP_23ae1672c29948088baa6e0028057d8d()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_510c776ec67348c2a797905a833747c4 : HardwiredMemberDescriptor
      {
        internal PROP_510c776ec67348c2a797905a833747c4()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_da920bef354d4e9b9ec16e20f026377c : HardwiredMemberDescriptor
      {
        internal PROP_da920bef354d4e9b9ec16e20f026377c()
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

      private sealed class PROP_026ef70f092842bea61f60aad5146883 : HardwiredMemberDescriptor
      {
        internal PROP_026ef70f092842bea61f60aad5146883()
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

      private sealed class PROP_a667bf77a29740968a5f43959dc65557 : HardwiredMemberDescriptor
      {
        internal PROP_a667bf77a29740968a5f43959dc65557()
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

      private sealed class PROP_a135e0a173c54412a1e948a3b7728d79 : HardwiredMemberDescriptor
      {
        internal PROP_a135e0a173c54412a1e948a3b7728d79()
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

      private sealed class PROP_829eb8302ae34ebf9de09882d1249709 : HardwiredMemberDescriptor
      {
        internal PROP_829eb8302ae34ebf9de09882d1249709()
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

      private sealed class PROP_99311f5f5d624d79bda94daf2ec59a62 : HardwiredMemberDescriptor
      {
        internal PROP_99311f5f5d624d79bda94daf2ec59a62()
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

      private sealed class PROP_d5d3f31b96544e1087fdf3d622f59bc7 : HardwiredMemberDescriptor
      {
        internal PROP_d5d3f31b96544e1087fdf3d622f59bc7()
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

      private sealed class PROP_ee7f5efd8c044bf1a714266c5fbfa6e6 : HardwiredMemberDescriptor
      {
        internal PROP_ee7f5efd8c044bf1a714266c5fbfa6e6()
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

      private sealed class PROP_1dce217337d64d10b896ede3a54009cc : HardwiredMemberDescriptor
      {
        internal PROP_1dce217337d64d10b896ede3a54009cc()
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

      private sealed class PROP_6d97e18b33e24231a380e5b8f1a06d65 : HardwiredMemberDescriptor
      {
        internal PROP_6d97e18b33e24231a380e5b8f1a06d65()
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

      private sealed class PROP_7558513a925d489f8cfc3648a8d593c6 : HardwiredMemberDescriptor
      {
        internal PROP_7558513a925d489f8cfc3648a8d593c6()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_96e06cebff964dcdbf1a23fb6038fb64 : HardwiredMemberDescriptor
      {
        internal PROP_96e06cebff964dcdbf1a23fb6038fb64()
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

      private sealed class PROP_d9b42627c2ff46a6839f522ce48f5b11 : HardwiredMemberDescriptor
      {
        internal PROP_d9b42627c2ff46a6839f522ce48f5b11()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_679a4072108a4195a194704db1d1ab3f : HardwiredMemberDescriptor
      {
        internal PROP_679a4072108a4195a194704db1d1ab3f()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_a8ae1a4fa7214c19a695551a95e5795b : HardwiredMemberDescriptor
      {
        internal PROP_a8ae1a4fa7214c19a695551a95e5795b()
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

      private sealed class PROP_edfca26ab5004170af639d12ca1fd8db : HardwiredMemberDescriptor
      {
        internal PROP_edfca26ab5004170af639d12ca1fd8db()
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

      private sealed class PROP_35baea1de06845988da1883427bfe747 : HardwiredMemberDescriptor
      {
        internal PROP_35baea1de06845988da1883427bfe747()
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

      private sealed class PROP_e1a20af14f084fb59a7b0c9981c60138 : HardwiredMemberDescriptor
      {
        internal PROP_e1a20af14f084fb59a7b0c9981c60138()
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

      private sealed class PROP_45c4a6139b374d9ba83d4632c9c95459 : HardwiredMemberDescriptor
      {
        internal PROP_45c4a6139b374d9ba83d4632c9c95459()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_9ce21621a99b4e8fbafc018d85910dd2 : HardwiredMemberDescriptor
      {
        internal PROP_9ce21621a99b4e8fbafc018d85910dd2()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_42e2b57cc9244a0fa0be8e86f50b5545 : HardwiredMemberDescriptor
      {
        internal PROP_42e2b57cc9244a0fa0be8e86f50b5545()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_6aac8678e7424984b68b7635d64bbe7b : HardwiredMemberDescriptor
      {
        internal PROP_6aac8678e7424984b68b7635d64bbe7b()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_bc5008f6b42f4ad7983bbdd9a3f7acf4 : HardwiredMemberDescriptor
      {
        internal PROP_bc5008f6b42f4ad7983bbdd9a3f7acf4()
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

      private sealed class PROP_ec39abbe5fea4da689a0c5877fb0fd8c : HardwiredMemberDescriptor
      {
        internal PROP_ec39abbe5fea4da689a0c5877fb0fd8c()
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

      private sealed class PROP_8cbec267dd214ad9ae404bdaca12a7b2 : HardwiredMemberDescriptor
      {
        internal PROP_8cbec267dd214ad9ae404bdaca12a7b2()
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

      private sealed class PROP_305776f7f4594ae4928c032e7e1cbd35 : HardwiredMemberDescriptor
      {
        internal PROP_305776f7f4594ae4928c032e7e1cbd35()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_a7432bf713ed415fbc846729ba7e8edf : HardwiredMemberDescriptor
      {
        internal PROP_a7432bf713ed415fbc846729ba7e8edf()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_de170186072f485dae5bfa84bff01b8b : HardwiredMemberDescriptor
      {
        internal PROP_de170186072f485dae5bfa84bff01b8b()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_8aa86f586d0b447c8b946f090dc88c53 : HardwiredUserDataDescriptor
    {
      internal TYPE_8aa86f586d0b447c8b946f090dc88c53()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8aa86f586d0b447c8b946f090dc88c53.MTHD_9a27f21cee09459ca805180087dbfd07()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8aa86f586d0b447c8b946f090dc88c53.MTHD_eee7f71b52c646b6a9549cc8997afbfe()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8aa86f586d0b447c8b946f090dc88c53.MTHD_f6b5932ee50745d9939984d999dc7446()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8aa86f586d0b447c8b946f090dc88c53.MTHD_3843216688e54aa2a215220e59a760a8()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8aa86f586d0b447c8b946f090dc88c53.MTHD_278499c3719447559a03969e591a0c43()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8aa86f586d0b447c8b946f090dc88c53.MTHD_669d78da7bed4694b0a1bd38d8b43a16()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8aa86f586d0b447c8b946f090dc88c53.MTHD_5729ee2c12744b318d49758394e34f6f()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8aa86f586d0b447c8b946f090dc88c53.MTHD_0e8590f839834a87aeef74dc96c3ce1e()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8aa86f586d0b447c8b946f090dc88c53.MTHD_f33a274d88794af0bdc2242220893f99()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8aa86f586d0b447c8b946f090dc88c53.MTHD_40de40214bf740d59814adb15e400e90()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8aa86f586d0b447c8b946f090dc88c53.MTHD_5df157ede445460982203fc071c08564()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8aa86f586d0b447c8b946f090dc88c53.MTHD_30558aa169c04896a10ed83b835171c3()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_8aa86f586d0b447c8b946f090dc88c53.PROP_7c78b37ea2c4485bb00744a2a1cf0ecc());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_8aa86f586d0b447c8b946f090dc88c53.PROP_182fa3df76ed49b2b3e6cf9ef36b17a1());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_8aa86f586d0b447c8b946f090dc88c53.PROP_5604657417694d09940bcf0e05be09c0());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_8aa86f586d0b447c8b946f090dc88c53.PROP_463783be39e146ffb05fbb170c2b6efa());
      }

      private sealed class MTHD_9a27f21cee09459ca805180087dbfd07 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9a27f21cee09459ca805180087dbfd07()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_eee7f71b52c646b6a9549cc8997afbfe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eee7f71b52c646b6a9549cc8997afbfe()
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

      private sealed class MTHD_f6b5932ee50745d9939984d999dc7446 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f6b5932ee50745d9939984d999dc7446()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_3843216688e54aa2a215220e59a760a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3843216688e54aa2a215220e59a760a8()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_278499c3719447559a03969e591a0c43 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_278499c3719447559a03969e591a0c43()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_669d78da7bed4694b0a1bd38d8b43a16 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_669d78da7bed4694b0a1bd38d8b43a16()
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

      private sealed class MTHD_5729ee2c12744b318d49758394e34f6f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5729ee2c12744b318d49758394e34f6f()
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

      private sealed class MTHD_0e8590f839834a87aeef74dc96c3ce1e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e8590f839834a87aeef74dc96c3ce1e()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_f33a274d88794af0bdc2242220893f99 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f33a274d88794af0bdc2242220893f99()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_40de40214bf740d59814adb15e400e90 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_40de40214bf740d59814adb15e400e90()
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

      private sealed class MTHD_5df157ede445460982203fc071c08564 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5df157ede445460982203fc071c08564()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_30558aa169c04896a10ed83b835171c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_30558aa169c04896a10ed83b835171c3()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_7c78b37ea2c4485bb00744a2a1cf0ecc : HardwiredMemberDescriptor
      {
        internal PROP_7c78b37ea2c4485bb00744a2a1cf0ecc()
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

      private sealed class PROP_182fa3df76ed49b2b3e6cf9ef36b17a1 : HardwiredMemberDescriptor
      {
        internal PROP_182fa3df76ed49b2b3e6cf9ef36b17a1()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_5604657417694d09940bcf0e05be09c0 : HardwiredMemberDescriptor
      {
        internal PROP_5604657417694d09940bcf0e05be09c0()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_463783be39e146ffb05fbb170c2b6efa : HardwiredMemberDescriptor
      {
        internal PROP_463783be39e146ffb05fbb170c2b6efa()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_b7e099dc936e424592c7c93867352715 : HardwiredUserDataDescriptor
    {
      internal TYPE_b7e099dc936e424592c7c93867352715()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_25382dbb547546d9990ddacb33cd3acf()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_f4e0024c5227428a9ed4e4d48087d866()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_822240c8eb5d4612a59123f79397f767()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_6fb97cc5554543ad9a8fe8fa4290a680()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_60f301e8f120454f912ba158b5021a1b()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_b2b7bc856d7c490899153736e6a8333f()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_d4738877e6984042be788be19cafbc01()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_5d3382e660bf4f17bc7dfa7b48ac1ec6()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_aeb8c5aa419440219c2200793edf8322()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_aab103fd57f34091ac2997e6d52cd5fe()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_c1ae4aa6ff9541c7ad0a5eac817dd0a3()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_d42d4754690643bcbaba25f5acfb823b()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_7cd0a71c992b4c3e82ae08dd757cb18f()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_bdcec7b0566147f28ec53a4f8fa45fba()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_0fcffa0ea2d54144bf463130a363583c()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_469d26460c2644e19c5fb6ccfc71d5cd()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_c0eed40cab614306bdd2a220b9524aa6()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_7a8df1a550ed4f4e958efa413746c2ba()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_e307ebe0b2d8484d8121678ce3e48eaf()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_25553d66e98845c7925c7aae9b556285()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_c42266d6b3c2447d9277cd8cac0ff5e5()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_ca4de3d9938246bab34cb1d3c330b4fa()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_46c72c088e0643419898f44e8ab06b4a()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_6efa7891f6514e91939e9c36d965c0f4()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_e6a93771fe674b2ebc8d66c5a95dfbb6()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_c21e2583229b4a66a72c7f9d6d35e7f0()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_62cd7e928ebc4ef6a3c846be767ec022()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_2ed2ea7c39a444b2acaa211aec1fcd6d()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_690c5aed684c4840bf4d4e2db2da4800()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_80d10601fdb840c1906a8f0969841491()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_bbf046eddc2d456db34093c5aefc29f4()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_d18bafd287a5449a933ea58f6682db33()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_a83c82ff39484675973b1734e1a20581()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_5db2c69f15e94bc2b758de582c72492b()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_f98c06fdb2514d70b88c5243032e1d4a()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_e4ca537e937b45a5b056190dc7c3737d()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_dcda59fffecb4ec2b8a929854372cc20()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_93da98754ff04164b7294dd4bdb433a6()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_45a1c62169194721b978c98156c4eb8d()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_30d3bf394304473da089386cf5091c74()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_8d1bfe97b8b04ff897f87ba61050f0b6()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_884f69fde2654dfd9be7b135fc5c4fc0()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_bc4aa3012744495686a3b1928d696a99()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_52ec4f68a88f41d086f53c47162212d8()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_db5147da2fbe4e11b88aceac52c7f1c1()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_892bb498e717464b915e389736e07143()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_0396d4f0432f48f785e10c7d832f105b()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_c8d15e2f69864bc28f2057c60c3d57c8()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_45bceaee1dbd43fc8da70e5b4be292b0()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_2a099dfbbc8244c98cd42384e501b3dc()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_2173387be7e24ec3987f44ea981f48b6()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_a49f77ef06a2444c967c48c652d689a5()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_c50e249687d74322b188c5e0b29c457f()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_9eac2540f86940cab09bfe4bff9df82b()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_f92034c7ff314f2586d904cdce7deb6d()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_f7ecf53da3f24525b70eeb0df54005c5()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_9477591b998345d997f2a53fec8270d6()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_068954e385a6405cab9d569a6397a9cc()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_93a819a904ec460a8d54681464ec4586()
        }));
        this.AddMember("getDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_60d1c68225284cb4a3854a94c4ec89f3()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_04afa44d6bd940838a599f34ff92fef1()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_cca4df19f401480eac6f55831feecfd7()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_0c0a9f8e82f44767aac748fe89536d75()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_82275d3b9e994600952a4117fc8cc335()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_735ccda5812c453ea71aef350574198f(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_2579222774774654b91699ccbfc3ba8d()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_06b0452c495341bda11d980cdafc10b6(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_bfaba4a75d7047fd8236a73faea7cc08()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_d9c7fac7975d459587fdae6f7139bc15()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_76f8c077ce404ab5b8baa36d8ef8113b()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_2c2a7dad0b7440bfbf3db595e95e3c3f(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_1093e1fe7a144a68a166230b14a43f2f()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_cddac68b5bc948a6b56fd18ef5b12a8d()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_63758a494a26422a9e30a5d393f16df4()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_9e7418bcdfa84cf9ba462ed2b31fe750()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_2f3aa04c8edd400c9b8ea5e000e09a28()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_3da8a5138cba40f28c0a7b7bb0936865()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_f92529aae1024d1e804fa09278ebdc02()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_270786d9697e41b287479fb44be3b5ff()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_84ce1baed8dc4b4081e12afd2fa3a230()
        }));
        this.AddMember("angleToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("angleToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_1d2e3484e993432ba0cd623dec310b20()
        }));
        this.AddMember("powerToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("powerToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_8b1c8168ad064ba79faa9907464b29c8()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_defaf43ec24d4dacaddb657b0fb241e1(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_513b3c0269be44e7be88e237b71740ff()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_33638e4693c2434ca23ea2c5af586481(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_d79eabc37f7749c083d2484834b8a30c()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_93d800bd3d1945e59886c205cfa418b6()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_d97df6ad2ba74194b53ff66a42a82074()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_e2612b61fdf5451083e68bdc56ed0317()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_be15290ff81e4b76b7075094be416a14()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_f8567c9d32ce4c248595876d68e15c95()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.MTHD_77539338aa2b47988523139710867c10()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_023e7787a0ac4da89c76d1a4f40f8e2f());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_85355d5949664fd3a35225fb7787ef3d());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_f563fd6606334b769936fa3706bf49a9());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_b4767bc201a04e779aaeaa3edd0178e2());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_fbb80634fc77494c83bfe3f7a3800afd());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_b512241ab8574ed588c4ec134d86a079());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_c41efe89826149c4b38eb7e220900c29());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_e272158289544ea8b2ee8f8b89f9517e());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_4ee7cb16bac549c2ad9b26c525b33df2());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_f1cd12b0e73e4c3aab7a6573240b815e());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_a08137f0a39245e6ba901a03a0912321());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_20bb70f6e1004fbe8fdb468893b4aebc());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_70d023e09b664f54a2d3bac6bc061e1c());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_8a2efc3c8b274f028f5430ee3694f396());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_2e37b4734122431caee24857e4e1be66());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_f422d5cb94bb4131b89fae6e1c32121e());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_e7f78f67d0ab475ca4321983f6fa9ad7());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_66a717fffd494696bd6173362540bcb9());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_88ec463c38b04c46b0010897ec66800c());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_82846c5c4dcc4056990148c1361d2795());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_1712ac531e5747b4af5ec3f6b794fc0b());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_f133e91a8acf4c579d960e825724a100());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_9531b1b63bef43fdaf822a1e723be049());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_7a59adb949a14c16a2f985a6100a5000());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_452acf18e8e04cbea8e739d9ecc87de3());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_f0e833b87b494b7cbfa6b726b69201f4());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_416e316ee8f04c9d870971e4489274d6());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_785956581f91436ca326e3b6ca03df08());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_a8dea2cbbd3e4de8969a36f3e66d9c81());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_3d09a9cf347445eeb8c51e4438f41766());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_cfed8f160aa0497987bbebadeff8e288());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_3a6fa39530334203a80ccbf896bac16b());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_b7e099dc936e424592c7c93867352715.PROP_9f74f7dcd7fe45d8826f432d6fc54faa());
      }

      private sealed class MTHD_25382dbb547546d9990ddacb33cd3acf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_25382dbb547546d9990ddacb33cd3acf()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_f4e0024c5227428a9ed4e4d48087d866 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4e0024c5227428a9ed4e4d48087d866()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_822240c8eb5d4612a59123f79397f767 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_822240c8eb5d4612a59123f79397f767()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_6fb97cc5554543ad9a8fe8fa4290a680 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6fb97cc5554543ad9a8fe8fa4290a680()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_60f301e8f120454f912ba158b5021a1b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60f301e8f120454f912ba158b5021a1b()
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

      private sealed class MTHD_b2b7bc856d7c490899153736e6a8333f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b2b7bc856d7c490899153736e6a8333f()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_d4738877e6984042be788be19cafbc01 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d4738877e6984042be788be19cafbc01()
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

      private sealed class MTHD_5d3382e660bf4f17bc7dfa7b48ac1ec6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d3382e660bf4f17bc7dfa7b48ac1ec6()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_aeb8c5aa419440219c2200793edf8322 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aeb8c5aa419440219c2200793edf8322()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_aab103fd57f34091ac2997e6d52cd5fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aab103fd57f34091ac2997e6d52cd5fe()
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

      private sealed class MTHD_c1ae4aa6ff9541c7ad0a5eac817dd0a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c1ae4aa6ff9541c7ad0a5eac817dd0a3()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_d42d4754690643bcbaba25f5acfb823b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d42d4754690643bcbaba25f5acfb823b()
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

      private sealed class MTHD_7cd0a71c992b4c3e82ae08dd757cb18f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7cd0a71c992b4c3e82ae08dd757cb18f()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_bdcec7b0566147f28ec53a4f8fa45fba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bdcec7b0566147f28ec53a4f8fa45fba()
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

      private sealed class MTHD_0fcffa0ea2d54144bf463130a363583c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0fcffa0ea2d54144bf463130a363583c()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_469d26460c2644e19c5fb6ccfc71d5cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_469d26460c2644e19c5fb6ccfc71d5cd()
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

      private sealed class MTHD_c0eed40cab614306bdd2a220b9524aa6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c0eed40cab614306bdd2a220b9524aa6()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_7a8df1a550ed4f4e958efa413746c2ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a8df1a550ed4f4e958efa413746c2ba()
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

      private sealed class MTHD_e307ebe0b2d8484d8121678ce3e48eaf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e307ebe0b2d8484d8121678ce3e48eaf()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_25553d66e98845c7925c7aae9b556285 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_25553d66e98845c7925c7aae9b556285()
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

      private sealed class MTHD_c42266d6b3c2447d9277cd8cac0ff5e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c42266d6b3c2447d9277cd8cac0ff5e5()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_ca4de3d9938246bab34cb1d3c330b4fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ca4de3d9938246bab34cb1d3c330b4fa()
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

      private sealed class MTHD_46c72c088e0643419898f44e8ab06b4a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_46c72c088e0643419898f44e8ab06b4a()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_6efa7891f6514e91939e9c36d965c0f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6efa7891f6514e91939e9c36d965c0f4()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_e6a93771fe674b2ebc8d66c5a95dfbb6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e6a93771fe674b2ebc8d66c5a95dfbb6()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_c21e2583229b4a66a72c7f9d6d35e7f0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c21e2583229b4a66a72c7f9d6d35e7f0()
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

      private sealed class MTHD_62cd7e928ebc4ef6a3c846be767ec022 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_62cd7e928ebc4ef6a3c846be767ec022()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_2ed2ea7c39a444b2acaa211aec1fcd6d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2ed2ea7c39a444b2acaa211aec1fcd6d()
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

      private sealed class MTHD_690c5aed684c4840bf4d4e2db2da4800 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_690c5aed684c4840bf4d4e2db2da4800()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_80d10601fdb840c1906a8f0969841491 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_80d10601fdb840c1906a8f0969841491()
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

      private sealed class MTHD_bbf046eddc2d456db34093c5aefc29f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bbf046eddc2d456db34093c5aefc29f4()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_d18bafd287a5449a933ea58f6682db33 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d18bafd287a5449a933ea58f6682db33()
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

      private sealed class MTHD_a83c82ff39484675973b1734e1a20581 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a83c82ff39484675973b1734e1a20581()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_5db2c69f15e94bc2b758de582c72492b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5db2c69f15e94bc2b758de582c72492b()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_f98c06fdb2514d70b88c5243032e1d4a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f98c06fdb2514d70b88c5243032e1d4a()
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

      private sealed class MTHD_e4ca537e937b45a5b056190dc7c3737d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e4ca537e937b45a5b056190dc7c3737d()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_dcda59fffecb4ec2b8a929854372cc20 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dcda59fffecb4ec2b8a929854372cc20()
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

      private sealed class MTHD_93da98754ff04164b7294dd4bdb433a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93da98754ff04164b7294dd4bdb433a6()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_45a1c62169194721b978c98156c4eb8d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_45a1c62169194721b978c98156c4eb8d()
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

      private sealed class MTHD_30d3bf394304473da089386cf5091c74 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_30d3bf394304473da089386cf5091c74()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_8d1bfe97b8b04ff897f87ba61050f0b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8d1bfe97b8b04ff897f87ba61050f0b6()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_884f69fde2654dfd9be7b135fc5c4fc0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_884f69fde2654dfd9be7b135fc5c4fc0()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_bc4aa3012744495686a3b1928d696a99 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bc4aa3012744495686a3b1928d696a99()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_52ec4f68a88f41d086f53c47162212d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52ec4f68a88f41d086f53c47162212d8()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_db5147da2fbe4e11b88aceac52c7f1c1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db5147da2fbe4e11b88aceac52c7f1c1()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_892bb498e717464b915e389736e07143 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_892bb498e717464b915e389736e07143()
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

      private sealed class MTHD_0396d4f0432f48f785e10c7d832f105b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0396d4f0432f48f785e10c7d832f105b()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_c8d15e2f69864bc28f2057c60c3d57c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c8d15e2f69864bc28f2057c60c3d57c8()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_45bceaee1dbd43fc8da70e5b4be292b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_45bceaee1dbd43fc8da70e5b4be292b0()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_2a099dfbbc8244c98cd42384e501b3dc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a099dfbbc8244c98cd42384e501b3dc()
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

      private sealed class MTHD_2173387be7e24ec3987f44ea981f48b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2173387be7e24ec3987f44ea981f48b6()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_a49f77ef06a2444c967c48c652d689a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a49f77ef06a2444c967c48c652d689a5()
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

      private sealed class MTHD_c50e249687d74322b188c5e0b29c457f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c50e249687d74322b188c5e0b29c457f()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_9eac2540f86940cab09bfe4bff9df82b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9eac2540f86940cab09bfe4bff9df82b()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_f92034c7ff314f2586d904cdce7deb6d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f92034c7ff314f2586d904cdce7deb6d()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_f7ecf53da3f24525b70eeb0df54005c5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7ecf53da3f24525b70eeb0df54005c5()
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

      private sealed class MTHD_9477591b998345d997f2a53fec8270d6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9477591b998345d997f2a53fec8270d6()
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

      private sealed class MTHD_068954e385a6405cab9d569a6397a9cc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_068954e385a6405cab9d569a6397a9cc()
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

      private sealed class MTHD_93a819a904ec460a8d54681464ec4586 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93a819a904ec460a8d54681464ec4586()
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

      private sealed class MTHD_60d1c68225284cb4a3854a94c4ec89f3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60d1c68225284cb4a3854a94c4ec89f3()
        {
          this.Initialize("getDirection", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getDirection();
        }
      }

      private sealed class MTHD_04afa44d6bd940838a599f34ff92fef1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_04afa44d6bd940838a599f34ff92fef1()
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

      private sealed class MTHD_cca4df19f401480eac6f55831feecfd7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cca4df19f401480eac6f55831feecfd7()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_0c0a9f8e82f44767aac748fe89536d75 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c0a9f8e82f44767aac748fe89536d75()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_82275d3b9e994600952a4117fc8cc335 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_82275d3b9e994600952a4117fc8cc335()
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

      private sealed class MTHD_735ccda5812c453ea71aef350574198f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_735ccda5812c453ea71aef350574198f()
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

      private sealed class MTHD_2579222774774654b91699ccbfc3ba8d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2579222774774654b91699ccbfc3ba8d()
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

      private sealed class MTHD_06b0452c495341bda11d980cdafc10b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_06b0452c495341bda11d980cdafc10b6()
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

      private sealed class MTHD_bfaba4a75d7047fd8236a73faea7cc08 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bfaba4a75d7047fd8236a73faea7cc08()
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

      private sealed class MTHD_d9c7fac7975d459587fdae6f7139bc15 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d9c7fac7975d459587fdae6f7139bc15()
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

      private sealed class MTHD_76f8c077ce404ab5b8baa36d8ef8113b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76f8c077ce404ab5b8baa36d8ef8113b()
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

      private sealed class MTHD_2c2a7dad0b7440bfbf3db595e95e3c3f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c2a7dad0b7440bfbf3db595e95e3c3f()
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

      private sealed class MTHD_1093e1fe7a144a68a166230b14a43f2f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1093e1fe7a144a68a166230b14a43f2f()
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

      private sealed class MTHD_cddac68b5bc948a6b56fd18ef5b12a8d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cddac68b5bc948a6b56fd18ef5b12a8d()
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

      private sealed class MTHD_63758a494a26422a9e30a5d393f16df4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_63758a494a26422a9e30a5d393f16df4()
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

      private sealed class MTHD_9e7418bcdfa84cf9ba462ed2b31fe750 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e7418bcdfa84cf9ba462ed2b31fe750()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_2f3aa04c8edd400c9b8ea5e000e09a28 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2f3aa04c8edd400c9b8ea5e000e09a28()
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

      private sealed class MTHD_3da8a5138cba40f28c0a7b7bb0936865 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3da8a5138cba40f28c0a7b7bb0936865()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_f92529aae1024d1e804fa09278ebdc02 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f92529aae1024d1e804fa09278ebdc02()
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

      private sealed class MTHD_270786d9697e41b287479fb44be3b5ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_270786d9697e41b287479fb44be3b5ff()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_84ce1baed8dc4b4081e12afd2fa3a230 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84ce1baed8dc4b4081e12afd2fa3a230()
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

      private sealed class MTHD_1d2e3484e993432ba0cd623dec310b20 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d2e3484e993432ba0cd623dec310b20()
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

      private sealed class MTHD_8b1c8168ad064ba79faa9907464b29c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b1c8168ad064ba79faa9907464b29c8()
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

      private sealed class MTHD_defaf43ec24d4dacaddb657b0fb241e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_defaf43ec24d4dacaddb657b0fb241e1()
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

      private sealed class MTHD_513b3c0269be44e7be88e237b71740ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_513b3c0269be44e7be88e237b71740ff()
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

      private sealed class MTHD_33638e4693c2434ca23ea2c5af586481 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_33638e4693c2434ca23ea2c5af586481()
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

      private sealed class MTHD_d79eabc37f7749c083d2484834b8a30c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d79eabc37f7749c083d2484834b8a30c()
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

      private sealed class MTHD_93d800bd3d1945e59886c205cfa418b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93d800bd3d1945e59886c205cfa418b6()
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

      private sealed class MTHD_d97df6ad2ba74194b53ff66a42a82074 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d97df6ad2ba74194b53ff66a42a82074()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_e2612b61fdf5451083e68bdc56ed0317 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e2612b61fdf5451083e68bdc56ed0317()
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

      private sealed class MTHD_be15290ff81e4b76b7075094be416a14 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be15290ff81e4b76b7075094be416a14()
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

      private sealed class MTHD_f8567c9d32ce4c248595876d68e15c95 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f8567c9d32ce4c248595876d68e15c95()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_77539338aa2b47988523139710867c10 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_77539338aa2b47988523139710867c10()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_023e7787a0ac4da89c76d1a4f40f8e2f : HardwiredMemberDescriptor
      {
        internal PROP_023e7787a0ac4da89c76d1a4f40f8e2f()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_85355d5949664fd3a35225fb7787ef3d : HardwiredMemberDescriptor
      {
        internal PROP_85355d5949664fd3a35225fb7787ef3d()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_f563fd6606334b769936fa3706bf49a9 : HardwiredMemberDescriptor
      {
        internal PROP_f563fd6606334b769936fa3706bf49a9()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_b4767bc201a04e779aaeaa3edd0178e2 : HardwiredMemberDescriptor
      {
        internal PROP_b4767bc201a04e779aaeaa3edd0178e2()
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

      private sealed class PROP_fbb80634fc77494c83bfe3f7a3800afd : HardwiredMemberDescriptor
      {
        internal PROP_fbb80634fc77494c83bfe3f7a3800afd()
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

      private sealed class PROP_b512241ab8574ed588c4ec134d86a079 : HardwiredMemberDescriptor
      {
        internal PROP_b512241ab8574ed588c4ec134d86a079()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_c41efe89826149c4b38eb7e220900c29 : HardwiredMemberDescriptor
      {
        internal PROP_c41efe89826149c4b38eb7e220900c29()
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

      private sealed class PROP_e272158289544ea8b2ee8f8b89f9517e : HardwiredMemberDescriptor
      {
        internal PROP_e272158289544ea8b2ee8f8b89f9517e()
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

      private sealed class PROP_4ee7cb16bac549c2ad9b26c525b33df2 : HardwiredMemberDescriptor
      {
        internal PROP_4ee7cb16bac549c2ad9b26c525b33df2()
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

      private sealed class PROP_f1cd12b0e73e4c3aab7a6573240b815e : HardwiredMemberDescriptor
      {
        internal PROP_f1cd12b0e73e4c3aab7a6573240b815e()
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

      private sealed class PROP_a08137f0a39245e6ba901a03a0912321 : HardwiredMemberDescriptor
      {
        internal PROP_a08137f0a39245e6ba901a03a0912321()
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

      private sealed class PROP_20bb70f6e1004fbe8fdb468893b4aebc : HardwiredMemberDescriptor
      {
        internal PROP_20bb70f6e1004fbe8fdb468893b4aebc()
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

      private sealed class PROP_70d023e09b664f54a2d3bac6bc061e1c : HardwiredMemberDescriptor
      {
        internal PROP_70d023e09b664f54a2d3bac6bc061e1c()
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

      private sealed class PROP_8a2efc3c8b274f028f5430ee3694f396 : HardwiredMemberDescriptor
      {
        internal PROP_8a2efc3c8b274f028f5430ee3694f396()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_2e37b4734122431caee24857e4e1be66 : HardwiredMemberDescriptor
      {
        internal PROP_2e37b4734122431caee24857e4e1be66()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_f422d5cb94bb4131b89fae6e1c32121e : HardwiredMemberDescriptor
      {
        internal PROP_f422d5cb94bb4131b89fae6e1c32121e()
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

      private sealed class PROP_e7f78f67d0ab475ca4321983f6fa9ad7 : HardwiredMemberDescriptor
      {
        internal PROP_e7f78f67d0ab475ca4321983f6fa9ad7()
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

      private sealed class PROP_66a717fffd494696bd6173362540bcb9 : HardwiredMemberDescriptor
      {
        internal PROP_66a717fffd494696bd6173362540bcb9()
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

      private sealed class PROP_88ec463c38b04c46b0010897ec66800c : HardwiredMemberDescriptor
      {
        internal PROP_88ec463c38b04c46b0010897ec66800c()
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

      private sealed class PROP_82846c5c4dcc4056990148c1361d2795 : HardwiredMemberDescriptor
      {
        internal PROP_82846c5c4dcc4056990148c1361d2795()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_1712ac531e5747b4af5ec3f6b794fc0b : HardwiredMemberDescriptor
      {
        internal PROP_1712ac531e5747b4af5ec3f6b794fc0b()
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

      private sealed class PROP_f133e91a8acf4c579d960e825724a100 : HardwiredMemberDescriptor
      {
        internal PROP_f133e91a8acf4c579d960e825724a100()
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

      private sealed class PROP_9531b1b63bef43fdaf822a1e723be049 : HardwiredMemberDescriptor
      {
        internal PROP_9531b1b63bef43fdaf822a1e723be049()
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

      private sealed class PROP_7a59adb949a14c16a2f985a6100a5000 : HardwiredMemberDescriptor
      {
        internal PROP_7a59adb949a14c16a2f985a6100a5000()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_452acf18e8e04cbea8e739d9ecc87de3 : HardwiredMemberDescriptor
      {
        internal PROP_452acf18e8e04cbea8e739d9ecc87de3()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_f0e833b87b494b7cbfa6b726b69201f4 : HardwiredMemberDescriptor
      {
        internal PROP_f0e833b87b494b7cbfa6b726b69201f4()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_416e316ee8f04c9d870971e4489274d6 : HardwiredMemberDescriptor
      {
        internal PROP_416e316ee8f04c9d870971e4489274d6()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_785956581f91436ca326e3b6ca03df08 : HardwiredMemberDescriptor
      {
        internal PROP_785956581f91436ca326e3b6ca03df08()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_a8dea2cbbd3e4de8969a36f3e66d9c81 : HardwiredMemberDescriptor
      {
        internal PROP_a8dea2cbbd3e4de8969a36f3e66d9c81()
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

      private sealed class PROP_3d09a9cf347445eeb8c51e4438f41766 : HardwiredMemberDescriptor
      {
        internal PROP_3d09a9cf347445eeb8c51e4438f41766()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_cfed8f160aa0497987bbebadeff8e288 : HardwiredMemberDescriptor
      {
        internal PROP_cfed8f160aa0497987bbebadeff8e288()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_3a6fa39530334203a80ccbf896bac16b : HardwiredMemberDescriptor
      {
        internal PROP_3a6fa39530334203a80ccbf896bac16b()
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

      private sealed class PROP_9f74f7dcd7fe45d8826f432d6fc54faa : HardwiredMemberDescriptor
      {
        internal PROP_9f74f7dcd7fe45d8826f432d6fc54faa()
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

    private sealed class TYPE_20978ef7d9ac493cae95fe443e6f2b8f : HardwiredUserDataDescriptor
    {
      internal TYPE_20978ef7d9ac493cae95fe443e6f2b8f()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.MTHD_1ad2de91d44e4bb68b0bac19d438b430()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.MTHD_35e760cd64be4d47b08370c118bf7c08()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.MTHD_625ca4b9aafd469993fa281edd3d9c12()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.MTHD_338f3cebb0624b82a47cd59eccbb0661()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.MTHD_b703c42d350e43c4a8fe320bc2121b65()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.MTHD_1508463af0db4a2eae147aa04312fdf0()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.MTHD_cdf2b72fe30a4c9cb75302964af2bfaf()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.MTHD_f31b102a85e348ef95bbb1daa1eca397()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.MTHD_1ce6220001344870b1359ccf8131c5be()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.MTHD_85204004fed2497699a8fca1c9686f45()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.MTHD_ee0d3e192f6347e691a0306cb8fbacf4()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.MTHD_710a9b2fcb424256878626474a38c53e()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.MTHD_4d4879bbb2114701a3d0cbdf3f4506ef()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.MTHD_d107deee7d1445e9b1bb8f3d45a20bf9()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.MTHD_e3cb7e6a4ad644ef8d873459fca73a6f()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.MTHD_5e34e067799347b2b630f9c560d00121()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.MTHD_0616fd0884d9453ead3b7a22ad8934b5()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.MTHD_20b7ba1e933047d4b7846d65dc5f470c()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.MTHD_068cc3c725e84f3ba9dccbdaec8f4d25()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.MTHD_ffb9686895ea406fba2669087cff6eed()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.PROP_1113c8121e6e49f8bfe2b9b225fce455());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.PROP_80c7d72e8fcf44d0a32898fbe5bc3533());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.PROP_442ef9c38039425d954d50929dc26fe7());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.PROP_a7f04d0cb64f47c38358427349a6d2a1());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.PROP_80b9138bda0b499da3dd66129ceec34d());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.PROP_6fb3a33e818449fda61fe24fd8b39d28());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.PROP_16417de94be74efaa971ef6b142ea058());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_20978ef7d9ac493cae95fe443e6f2b8f.PROP_236c084163944377b2a6a3ff4a035ad7());
      }

      private sealed class MTHD_1ad2de91d44e4bb68b0bac19d438b430 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ad2de91d44e4bb68b0bac19d438b430()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_35e760cd64be4d47b08370c118bf7c08 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35e760cd64be4d47b08370c118bf7c08()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_625ca4b9aafd469993fa281edd3d9c12 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_625ca4b9aafd469993fa281edd3d9c12()
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

      private sealed class MTHD_338f3cebb0624b82a47cd59eccbb0661 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_338f3cebb0624b82a47cd59eccbb0661()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_b703c42d350e43c4a8fe320bc2121b65 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b703c42d350e43c4a8fe320bc2121b65()
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

      private sealed class MTHD_1508463af0db4a2eae147aa04312fdf0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1508463af0db4a2eae147aa04312fdf0()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_cdf2b72fe30a4c9cb75302964af2bfaf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cdf2b72fe30a4c9cb75302964af2bfaf()
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

      private sealed class MTHD_f31b102a85e348ef95bbb1daa1eca397 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f31b102a85e348ef95bbb1daa1eca397()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_1ce6220001344870b1359ccf8131c5be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ce6220001344870b1359ccf8131c5be()
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

      private sealed class MTHD_85204004fed2497699a8fca1c9686f45 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85204004fed2497699a8fca1c9686f45()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_ee0d3e192f6347e691a0306cb8fbacf4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee0d3e192f6347e691a0306cb8fbacf4()
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

      private sealed class MTHD_710a9b2fcb424256878626474a38c53e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_710a9b2fcb424256878626474a38c53e()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_4d4879bbb2114701a3d0cbdf3f4506ef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d4879bbb2114701a3d0cbdf3f4506ef()
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

      private sealed class MTHD_d107deee7d1445e9b1bb8f3d45a20bf9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d107deee7d1445e9b1bb8f3d45a20bf9()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_e3cb7e6a4ad644ef8d873459fca73a6f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e3cb7e6a4ad644ef8d873459fca73a6f()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_5e34e067799347b2b630f9c560d00121 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e34e067799347b2b630f9c560d00121()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_0616fd0884d9453ead3b7a22ad8934b5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0616fd0884d9453ead3b7a22ad8934b5()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_20b7ba1e933047d4b7846d65dc5f470c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_20b7ba1e933047d4b7846d65dc5f470c()
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

      private sealed class MTHD_068cc3c725e84f3ba9dccbdaec8f4d25 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_068cc3c725e84f3ba9dccbdaec8f4d25()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_ffb9686895ea406fba2669087cff6eed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ffb9686895ea406fba2669087cff6eed()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_1113c8121e6e49f8bfe2b9b225fce455 : HardwiredMemberDescriptor
      {
        internal PROP_1113c8121e6e49f8bfe2b9b225fce455()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_80c7d72e8fcf44d0a32898fbe5bc3533 : HardwiredMemberDescriptor
      {
        internal PROP_80c7d72e8fcf44d0a32898fbe5bc3533()
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

      private sealed class PROP_442ef9c38039425d954d50929dc26fe7 : HardwiredMemberDescriptor
      {
        internal PROP_442ef9c38039425d954d50929dc26fe7()
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

      private sealed class PROP_a7f04d0cb64f47c38358427349a6d2a1 : HardwiredMemberDescriptor
      {
        internal PROP_a7f04d0cb64f47c38358427349a6d2a1()
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

      private sealed class PROP_80b9138bda0b499da3dd66129ceec34d : HardwiredMemberDescriptor
      {
        internal PROP_80b9138bda0b499da3dd66129ceec34d()
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

      private sealed class PROP_6fb3a33e818449fda61fe24fd8b39d28 : HardwiredMemberDescriptor
      {
        internal PROP_6fb3a33e818449fda61fe24fd8b39d28()
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

      private sealed class PROP_16417de94be74efaa971ef6b142ea058 : HardwiredMemberDescriptor
      {
        internal PROP_16417de94be74efaa971ef6b142ea058()
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

      private sealed class PROP_236c084163944377b2a6a3ff4a035ad7 : HardwiredMemberDescriptor
      {
        internal PROP_236c084163944377b2a6a3ff4a035ad7()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_8e904c22eb47491fb4d516e714f9bbbe : HardwiredUserDataDescriptor
    {
      internal TYPE_8e904c22eb47491fb4d516e714f9bbbe()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.MTHD_fd60d5f72cde4630987d948bf3234b07()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.MTHD_be7efe6db7cc4f0ba31ee0df7e9c6c38()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.MTHD_b8d2c854264747bf8cc234935840e21e()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.MTHD_ef4a85d921154fe39ce82418b7ba83bb()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.MTHD_6f510237ef2c45aba628ff1d15ff5ee8()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.MTHD_68d101560c4c42afbae503add804fae9()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.MTHD_76c388341e8c4419b49fc19d3bda43e0()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.MTHD_51f2ec1932354eb5a640902589912f93()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.MTHD_28e154dc009d4ab1b9824f7fcb905acb()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.MTHD_4dd9c50478bb4e1da2d560a8ae246d16()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.MTHD_4cd5bad7463a4326823139e94a6fdc31()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.MTHD_25c7a6d65c6c4037b828cedf306536ba()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.MTHD_1f639740ddbc4cc3a16db7f66ed24545()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.MTHD_bcc86f4dd254468a9d3f03c1588e5c66()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.MTHD_51b63984fbe446c18876fca3759f65ea()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.MTHD_25efdd7f82034ca09f94e21d43f176a7()
        }));
        this.AddMember("setIcon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setIcon", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.MTHD_4e433362340948c39574a001ec661e47()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.MTHD_ea7ee7ad235c446cac7498a4b582ab2b()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.MTHD_13ac3eba6dce467dab66528631bf112d()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.MTHD_4d8c858fc23840308071ba2a0b9910a8()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.MTHD_c9b3e78f4c2043f1a0db013b668e639d()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.MTHD_b685cd0603c048729c10fa303900cab0()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.PROP_c481319da5634c9cb683bd81c9ba03de());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.PROP_9c5264486b64453082bc95b675f8cc64());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.PROP_e6b8b313d806421183f3afdb1ec75ab2());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.PROP_6051f2a7a82648879096a759be0232e0());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.PROP_74e352289dad47909aaa8d67ca478a32());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.PROP_46d762d086f24ac588be5c8bddbe1d5c());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.PROP_1651866a7fa04bc585d8fb02821fbd4a());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.PROP_f49ac283e06b44b8a410db66cf60ff21());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_8e904c22eb47491fb4d516e714f9bbbe.PROP_6fcc1a4f9aff4cb59e53239ac6fd1ccf());
      }

      private sealed class MTHD_fd60d5f72cde4630987d948bf3234b07 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd60d5f72cde4630987d948bf3234b07()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_be7efe6db7cc4f0ba31ee0df7e9c6c38 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be7efe6db7cc4f0ba31ee0df7e9c6c38()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_b8d2c854264747bf8cc234935840e21e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b8d2c854264747bf8cc234935840e21e()
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

      private sealed class MTHD_ef4a85d921154fe39ce82418b7ba83bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef4a85d921154fe39ce82418b7ba83bb()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_6f510237ef2c45aba628ff1d15ff5ee8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6f510237ef2c45aba628ff1d15ff5ee8()
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

      private sealed class MTHD_68d101560c4c42afbae503add804fae9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_68d101560c4c42afbae503add804fae9()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_76c388341e8c4419b49fc19d3bda43e0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76c388341e8c4419b49fc19d3bda43e0()
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

      private sealed class MTHD_51f2ec1932354eb5a640902589912f93 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_51f2ec1932354eb5a640902589912f93()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_28e154dc009d4ab1b9824f7fcb905acb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_28e154dc009d4ab1b9824f7fcb905acb()
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

      private sealed class MTHD_4dd9c50478bb4e1da2d560a8ae246d16 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4dd9c50478bb4e1da2d560a8ae246d16()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_4cd5bad7463a4326823139e94a6fdc31 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4cd5bad7463a4326823139e94a6fdc31()
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

      private sealed class MTHD_25c7a6d65c6c4037b828cedf306536ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_25c7a6d65c6c4037b828cedf306536ba()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_1f639740ddbc4cc3a16db7f66ed24545 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f639740ddbc4cc3a16db7f66ed24545()
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

      private sealed class MTHD_bcc86f4dd254468a9d3f03c1588e5c66 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bcc86f4dd254468a9d3f03c1588e5c66()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color2;
        }
      }

      private sealed class MTHD_51b63984fbe446c18876fca3759f65ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_51b63984fbe446c18876fca3759f65ea()
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

      private sealed class MTHD_25efdd7f82034ca09f94e21d43f176a7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_25efdd7f82034ca09f94e21d43f176a7()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_4e433362340948c39574a001ec661e47 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e433362340948c39574a001ec661e47()
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

      private sealed class MTHD_ea7ee7ad235c446cac7498a4b582ab2b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea7ee7ad235c446cac7498a4b582ab2b()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_13ac3eba6dce467dab66528631bf112d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_13ac3eba6dce467dab66528631bf112d()
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

      private sealed class MTHD_4d8c858fc23840308071ba2a0b9910a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d8c858fc23840308071ba2a0b9910a8()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_c9b3e78f4c2043f1a0db013b668e639d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c9b3e78f4c2043f1a0db013b668e639d()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_b685cd0603c048729c10fa303900cab0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b685cd0603c048729c10fa303900cab0()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_c481319da5634c9cb683bd81c9ba03de : HardwiredMemberDescriptor
      {
        internal PROP_c481319da5634c9cb683bd81c9ba03de()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_9c5264486b64453082bc95b675f8cc64 : HardwiredMemberDescriptor
      {
        internal PROP_9c5264486b64453082bc95b675f8cc64()
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

      private sealed class PROP_e6b8b313d806421183f3afdb1ec75ab2 : HardwiredMemberDescriptor
      {
        internal PROP_e6b8b313d806421183f3afdb1ec75ab2()
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

      private sealed class PROP_6051f2a7a82648879096a759be0232e0 : HardwiredMemberDescriptor
      {
        internal PROP_6051f2a7a82648879096a759be0232e0()
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

      private sealed class PROP_74e352289dad47909aaa8d67ca478a32 : HardwiredMemberDescriptor
      {
        internal PROP_74e352289dad47909aaa8d67ca478a32()
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

      private sealed class PROP_46d762d086f24ac588be5c8bddbe1d5c : HardwiredMemberDescriptor
      {
        internal PROP_46d762d086f24ac588be5c8bddbe1d5c()
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

      private sealed class PROP_1651866a7fa04bc585d8fb02821fbd4a : HardwiredMemberDescriptor
      {
        internal PROP_1651866a7fa04bc585d8fb02821fbd4a()
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

      private sealed class PROP_f49ac283e06b44b8a410db66cf60ff21 : HardwiredMemberDescriptor
      {
        internal PROP_f49ac283e06b44b8a410db66cf60ff21()
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

      private sealed class PROP_6fcc1a4f9aff4cb59e53239ac6fd1ccf : HardwiredMemberDescriptor
      {
        internal PROP_6fcc1a4f9aff4cb59e53239ac6fd1ccf()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_82ccd853ad174016b7dbbcab31e8f333 : HardwiredUserDataDescriptor
    {
      internal TYPE_82ccd853ad174016b7dbbcab31e8f333()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_919b261eaa9849bda7c1fb7ab5a80a4c()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_d2bdb5fe88b84895944fe39bbf703cfa()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_f0b7ddae9d6848899237291eca97240b()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_a850769118884930b3bd7a49d9ba5172()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_65f54f683c164bdfa9e12341d5684285()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_feff5cdb372046239ed82268616ce30a()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_be7c7504c85e42ba8323789188510396()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_b01cfb5634e1445fb3f60d6d7056f739()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_dca2f06326034abe89f7a41df14a4c9c()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_4c0a51159af84d40a1b7e5dcf1d10391()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_29ea6268613541ef9f21fa4c43df3b2c()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_8dc92fc954904bf5a8ab61464278ff54()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_ead4a3db218a43d59afdcb9eeb8e29c3()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_34b83e43fc374504b3e344bdf1089da8()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_a31946f1b5c24e9d99921c29b6fe9e91()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_bace68efad4d417ba6d4283f22168fa2()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_496ee42480684104924e85a2b91bd952()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_310e1ef65aa24a62a78b136163c5cf6a()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_6c5aa92a34c94a90b59e269483b72975()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_b68267c888be4413845a4abc3a708533()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_6f9bc2e8d4854d5a9c02ff66b65a10c0()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_5de82c8223b04ddcad372cd11009e139()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_14e94beb35d7412fb54c33ae6b62f3ae()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_ec592d39b47747149249ad4ff8caaf58()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_004413a4cc3b4b4397cd5e8240daa072()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_8a4c961ffc2d445eb6dd67bbd6214476()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_8308fc8be2244732a8ce6f9b62ba657b()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.MTHD_1c0ff058e8dc416d883a0553dcebd9af()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.PROP_7d6a45675efc494bbe2c9128b0057a78());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.PROP_0dd2663f301c491291c33399521dd488());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.PROP_403b58a2aa214722a8e37e26b858a009());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.PROP_c7aed84cdf5741bf802a200eb5ed63bf());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.PROP_42a5d5bf512440beac0bffef20b40cfe());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.PROP_52fe9474962f40e491f84e4f94740b5f());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.PROP_4e291725608c490a85744d4e68118ea8());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.PROP_a215850ed1a54efa8b2ff614494fd093());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.PROP_0070bf7dab1b40e69f50d90ac5a07ecd());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.PROP_3cf5913d61a641eb9abf78e255b11a8a());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.PROP_732dd731ab164293b18ce07a5c56f851());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.PROP_19d41099a05a485b907ee71aa649fbd4());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.PROP_8c6cc788e8a94aa6ab9e3d8b6131ab5b());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.PROP_6b93aaa4d9224fa4b02f2541c95ce44c());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.PROP_aabf98ac7d7543edb3ec30a5f052f4d1());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.PROP_79de6fe0370842f094c86ca3d7224213());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_82ccd853ad174016b7dbbcab31e8f333.PROP_df0339afdbe54338a3d876399ade397a());
      }

      private sealed class MTHD_919b261eaa9849bda7c1fb7ab5a80a4c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_919b261eaa9849bda7c1fb7ab5a80a4c()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_d2bdb5fe88b84895944fe39bbf703cfa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d2bdb5fe88b84895944fe39bbf703cfa()
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

      private sealed class MTHD_f0b7ddae9d6848899237291eca97240b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f0b7ddae9d6848899237291eca97240b()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_a850769118884930b3bd7a49d9ba5172 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a850769118884930b3bd7a49d9ba5172()
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

      private sealed class MTHD_65f54f683c164bdfa9e12341d5684285 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65f54f683c164bdfa9e12341d5684285()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_feff5cdb372046239ed82268616ce30a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_feff5cdb372046239ed82268616ce30a()
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

      private sealed class MTHD_be7c7504c85e42ba8323789188510396 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be7c7504c85e42ba8323789188510396()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_b01cfb5634e1445fb3f60d6d7056f739 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b01cfb5634e1445fb3f60d6d7056f739()
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

      private sealed class MTHD_dca2f06326034abe89f7a41df14a4c9c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dca2f06326034abe89f7a41df14a4c9c()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_4c0a51159af84d40a1b7e5dcf1d10391 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c0a51159af84d40a1b7e5dcf1d10391()
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

      private sealed class MTHD_29ea6268613541ef9f21fa4c43df3b2c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_29ea6268613541ef9f21fa4c43df3b2c()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_8dc92fc954904bf5a8ab61464278ff54 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8dc92fc954904bf5a8ab61464278ff54()
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

      private sealed class MTHD_ead4a3db218a43d59afdcb9eeb8e29c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ead4a3db218a43d59afdcb9eeb8e29c3()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_34b83e43fc374504b3e344bdf1089da8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_34b83e43fc374504b3e344bdf1089da8()
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

      private sealed class MTHD_a31946f1b5c24e9d99921c29b6fe9e91 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a31946f1b5c24e9d99921c29b6fe9e91()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_bace68efad4d417ba6d4283f22168fa2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bace68efad4d417ba6d4283f22168fa2()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_496ee42480684104924e85a2b91bd952 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_496ee42480684104924e85a2b91bd952()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_310e1ef65aa24a62a78b136163c5cf6a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_310e1ef65aa24a62a78b136163c5cf6a()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_6c5aa92a34c94a90b59e269483b72975 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6c5aa92a34c94a90b59e269483b72975()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_b68267c888be4413845a4abc3a708533 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b68267c888be4413845a4abc3a708533()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_6f9bc2e8d4854d5a9c02ff66b65a10c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6f9bc2e8d4854d5a9c02ff66b65a10c0()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_5de82c8223b04ddcad372cd11009e139 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5de82c8223b04ddcad372cd11009e139()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_14e94beb35d7412fb54c33ae6b62f3ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_14e94beb35d7412fb54c33ae6b62f3ae()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_ec592d39b47747149249ad4ff8caaf58 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec592d39b47747149249ad4ff8caaf58()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_004413a4cc3b4b4397cd5e8240daa072 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_004413a4cc3b4b4397cd5e8240daa072()
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

      private sealed class MTHD_8a4c961ffc2d445eb6dd67bbd6214476 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a4c961ffc2d445eb6dd67bbd6214476()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_8308fc8be2244732a8ce6f9b62ba657b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8308fc8be2244732a8ce6f9b62ba657b()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_1c0ff058e8dc416d883a0553dcebd9af : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c0ff058e8dc416d883a0553dcebd9af()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_7d6a45675efc494bbe2c9128b0057a78 : HardwiredMemberDescriptor
      {
        internal PROP_7d6a45675efc494bbe2c9128b0057a78()
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

      private sealed class PROP_0dd2663f301c491291c33399521dd488 : HardwiredMemberDescriptor
      {
        internal PROP_0dd2663f301c491291c33399521dd488()
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

      private sealed class PROP_403b58a2aa214722a8e37e26b858a009 : HardwiredMemberDescriptor
      {
        internal PROP_403b58a2aa214722a8e37e26b858a009()
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

      private sealed class PROP_c7aed84cdf5741bf802a200eb5ed63bf : HardwiredMemberDescriptor
      {
        internal PROP_c7aed84cdf5741bf802a200eb5ed63bf()
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

      private sealed class PROP_42a5d5bf512440beac0bffef20b40cfe : HardwiredMemberDescriptor
      {
        internal PROP_42a5d5bf512440beac0bffef20b40cfe()
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

      private sealed class PROP_52fe9474962f40e491f84e4f94740b5f : HardwiredMemberDescriptor
      {
        internal PROP_52fe9474962f40e491f84e4f94740b5f()
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

      private sealed class PROP_4e291725608c490a85744d4e68118ea8 : HardwiredMemberDescriptor
      {
        internal PROP_4e291725608c490a85744d4e68118ea8()
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

      private sealed class PROP_a215850ed1a54efa8b2ff614494fd093 : HardwiredMemberDescriptor
      {
        internal PROP_a215850ed1a54efa8b2ff614494fd093()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_0070bf7dab1b40e69f50d90ac5a07ecd : HardwiredMemberDescriptor
      {
        internal PROP_0070bf7dab1b40e69f50d90ac5a07ecd()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_3cf5913d61a641eb9abf78e255b11a8a : HardwiredMemberDescriptor
      {
        internal PROP_3cf5913d61a641eb9abf78e255b11a8a()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_732dd731ab164293b18ce07a5c56f851 : HardwiredMemberDescriptor
      {
        internal PROP_732dd731ab164293b18ce07a5c56f851()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_19d41099a05a485b907ee71aa649fbd4 : HardwiredMemberDescriptor
      {
        internal PROP_19d41099a05a485b907ee71aa649fbd4()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_8c6cc788e8a94aa6ab9e3d8b6131ab5b : HardwiredMemberDescriptor
      {
        internal PROP_8c6cc788e8a94aa6ab9e3d8b6131ab5b()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_6b93aaa4d9224fa4b02f2541c95ce44c : HardwiredMemberDescriptor
      {
        internal PROP_6b93aaa4d9224fa4b02f2541c95ce44c()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_aabf98ac7d7543edb3ec30a5f052f4d1 : HardwiredMemberDescriptor
      {
        internal PROP_aabf98ac7d7543edb3ec30a5f052f4d1()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_79de6fe0370842f094c86ca3d7224213 : HardwiredMemberDescriptor
      {
        internal PROP_79de6fe0370842f094c86ca3d7224213()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_df0339afdbe54338a3d876399ade397a : HardwiredMemberDescriptor
      {
        internal PROP_df0339afdbe54338a3d876399ade397a()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_62e03a9b545b4dec8b50b898beb1a36c : HardwiredUserDataDescriptor
    {
      internal TYPE_62e03a9b545b4dec8b50b898beb1a36c()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62e03a9b545b4dec8b50b898beb1a36c.MTHD_ce02b8b0beb24c92a66bff8db311e34f()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62e03a9b545b4dec8b50b898beb1a36c.MTHD_9640a6546d2f462b87b3507cac315758()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62e03a9b545b4dec8b50b898beb1a36c.MTHD_99c7a54dbbb84b57935614a998fd04ab()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62e03a9b545b4dec8b50b898beb1a36c.MTHD_201c816f0c4c48f5997f9651169b22df()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62e03a9b545b4dec8b50b898beb1a36c.MTHD_1368af86237d4930be2b6916f39ee699()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62e03a9b545b4dec8b50b898beb1a36c.MTHD_f8db337e8821408f93538b38758a0890()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62e03a9b545b4dec8b50b898beb1a36c.MTHD_4f6a489f3e5c444eacdbef22f1f6750b()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62e03a9b545b4dec8b50b898beb1a36c.MTHD_9c97eda63f4a4bc9a4312869ae821d52()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62e03a9b545b4dec8b50b898beb1a36c.MTHD_9938510991524321ac25b9676bcbe446()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62e03a9b545b4dec8b50b898beb1a36c.MTHD_d0a4b46541764e0095173dabdf1f80fc()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62e03a9b545b4dec8b50b898beb1a36c.MTHD_fb9ae56ce1744846bf294d96f4b79cbf()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62e03a9b545b4dec8b50b898beb1a36c.MTHD_2d2f8dd891554cd284b283378c4278e3()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62e03a9b545b4dec8b50b898beb1a36c.MTHD_5ee1c60aed96477a8d88fcc9272e2cff()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62e03a9b545b4dec8b50b898beb1a36c.MTHD_7e08fb0b55fe4f018976b25bc1e7d57f()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62e03a9b545b4dec8b50b898beb1a36c.MTHD_2b029726607f44dca061a9030ea73c77()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62e03a9b545b4dec8b50b898beb1a36c.MTHD_b1f7cfcaca4e47788a2abdc939c92d10()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62e03a9b545b4dec8b50b898beb1a36c.MTHD_acd263827e584a64aeed72a3241cee64()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_62e03a9b545b4dec8b50b898beb1a36c.PROP_0ab4a4dfba4f4516b7abf17d5dd16dc1());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_62e03a9b545b4dec8b50b898beb1a36c.PROP_122ca9fb219a4e72982bc689f8914685());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_62e03a9b545b4dec8b50b898beb1a36c.PROP_d5cccb9f43e64761b5ba651586698068());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_62e03a9b545b4dec8b50b898beb1a36c.PROP_cd1c51f2c0754fcb81a43cb48740680d());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_62e03a9b545b4dec8b50b898beb1a36c.PROP_cb75f95779354ec786c802cc297ee6c4());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_62e03a9b545b4dec8b50b898beb1a36c.PROP_0b1bf5d13b0f4d9d9a30141d5de969f2());
      }

      private sealed class MTHD_ce02b8b0beb24c92a66bff8db311e34f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ce02b8b0beb24c92a66bff8db311e34f()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_9640a6546d2f462b87b3507cac315758 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9640a6546d2f462b87b3507cac315758()
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

      private sealed class MTHD_99c7a54dbbb84b57935614a998fd04ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99c7a54dbbb84b57935614a998fd04ab()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_201c816f0c4c48f5997f9651169b22df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_201c816f0c4c48f5997f9651169b22df()
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

      private sealed class MTHD_1368af86237d4930be2b6916f39ee699 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1368af86237d4930be2b6916f39ee699()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_f8db337e8821408f93538b38758a0890 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f8db337e8821408f93538b38758a0890()
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

      private sealed class MTHD_4f6a489f3e5c444eacdbef22f1f6750b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4f6a489f3e5c444eacdbef22f1f6750b()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_9c97eda63f4a4bc9a4312869ae821d52 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c97eda63f4a4bc9a4312869ae821d52()
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

      private sealed class MTHD_9938510991524321ac25b9676bcbe446 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9938510991524321ac25b9676bcbe446()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_d0a4b46541764e0095173dabdf1f80fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0a4b46541764e0095173dabdf1f80fc()
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

      private sealed class MTHD_fb9ae56ce1744846bf294d96f4b79cbf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb9ae56ce1744846bf294d96f4b79cbf()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_2d2f8dd891554cd284b283378c4278e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d2f8dd891554cd284b283378c4278e3()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_5ee1c60aed96477a8d88fcc9272e2cff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ee1c60aed96477a8d88fcc9272e2cff()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_7e08fb0b55fe4f018976b25bc1e7d57f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7e08fb0b55fe4f018976b25bc1e7d57f()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_2b029726607f44dca061a9030ea73c77 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b029726607f44dca061a9030ea73c77()
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

      private sealed class MTHD_b1f7cfcaca4e47788a2abdc939c92d10 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b1f7cfcaca4e47788a2abdc939c92d10()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_acd263827e584a64aeed72a3241cee64 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_acd263827e584a64aeed72a3241cee64()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_0ab4a4dfba4f4516b7abf17d5dd16dc1 : HardwiredMemberDescriptor
      {
        internal PROP_0ab4a4dfba4f4516b7abf17d5dd16dc1()
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

      private sealed class PROP_122ca9fb219a4e72982bc689f8914685 : HardwiredMemberDescriptor
      {
        internal PROP_122ca9fb219a4e72982bc689f8914685()
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

      private sealed class PROP_d5cccb9f43e64761b5ba651586698068 : HardwiredMemberDescriptor
      {
        internal PROP_d5cccb9f43e64761b5ba651586698068()
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

      private sealed class PROP_cd1c51f2c0754fcb81a43cb48740680d : HardwiredMemberDescriptor
      {
        internal PROP_cd1c51f2c0754fcb81a43cb48740680d()
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

      private sealed class PROP_cb75f95779354ec786c802cc297ee6c4 : HardwiredMemberDescriptor
      {
        internal PROP_cb75f95779354ec786c802cc297ee6c4()
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

      private sealed class PROP_0b1bf5d13b0f4d9d9a30141d5de969f2 : HardwiredMemberDescriptor
      {
        internal PROP_0b1bf5d13b0f4d9d9a30141d5de969f2()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_f1ff049e5f944459ac32b759436aebbf : HardwiredUserDataDescriptor
    {
      internal TYPE_f1ff049e5f944459ac32b759436aebbf()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f1ff049e5f944459ac32b759436aebbf.MTHD_811f3502f0b640c1b1b6e25f100c28bb(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f1ff049e5f944459ac32b759436aebbf.MTHD_ce3d8b21f46a48528b8dbc55f0dc23c2()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f1ff049e5f944459ac32b759436aebbf.MTHD_39e131453a404675a81a8a71bc883563(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f1ff049e5f944459ac32b759436aebbf.MTHD_9f6ccd12d5e1443e878ccbf791dc9894()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f1ff049e5f944459ac32b759436aebbf.MTHD_5fa0e68f4fdb458c9526331d9da2b2ec()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f1ff049e5f944459ac32b759436aebbf.MTHD_62b0030ef3494314ba6ee57e482ed89c()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f1ff049e5f944459ac32b759436aebbf.MTHD_a5458449167f43c9864fc66725eb0e45()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f1ff049e5f944459ac32b759436aebbf.MTHD_fbcc9c7a4fd64241abf0429a643d336e()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f1ff049e5f944459ac32b759436aebbf.MTHD_e0b776c9087d402e814f8dcda11690ef()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f1ff049e5f944459ac32b759436aebbf.MTHD_b4b2f3948f55444fb445c48f0fffb2f8()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f1ff049e5f944459ac32b759436aebbf.MTHD_0e5d107a8d9745008e979fc22ea05929()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f1ff049e5f944459ac32b759436aebbf.MTHD_5c91f86c135344f59307fc56507290f5(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f1ff049e5f944459ac32b759436aebbf.MTHD_fe8c3adc55e74cb5b745ffa3a55215f5()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f1ff049e5f944459ac32b759436aebbf.MTHD_691c323e3aaf405e8bd9ad246f4fa876(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f1ff049e5f944459ac32b759436aebbf.MTHD_eed3ac0469404bf7960af2071ddd3cab()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f1ff049e5f944459ac32b759436aebbf.MTHD_300e3578fe63495aa47364e46ea774fb(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f1ff049e5f944459ac32b759436aebbf.MTHD_5ccc42579297426ca964f6346b0f1beb()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f1ff049e5f944459ac32b759436aebbf.MTHD_64fffaf83eef4be78074c54fc97c31da(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f1ff049e5f944459ac32b759436aebbf.MTHD_32f832bde7b44695b3f9c24fa4fa06b9()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f1ff049e5f944459ac32b759436aebbf.MTHD_4189dcc562f4487aaf4e950da82f5af5(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f1ff049e5f944459ac32b759436aebbf.MTHD_4bd2a48833ea4dea8d7f9513e1e447f0()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f1ff049e5f944459ac32b759436aebbf.MTHD_41754768a3d74361a36579d2ae4f05ef()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f1ff049e5f944459ac32b759436aebbf.MTHD_bf3b08955e9a4209a426fc04f0ab1055()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_f1ff049e5f944459ac32b759436aebbf.FLDV_3db8827de8234e3ebdade57f30d4992a());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_f1ff049e5f944459ac32b759436aebbf.FLDV_33363c6d66764f7a9ec985770863e610());
      }

      private sealed class MTHD_811f3502f0b640c1b1b6e25f100c28bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_811f3502f0b640c1b1b6e25f100c28bb()
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

      private sealed class MTHD_ce3d8b21f46a48528b8dbc55f0dc23c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ce3d8b21f46a48528b8dbc55f0dc23c2()
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

      private sealed class MTHD_39e131453a404675a81a8a71bc883563 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_39e131453a404675a81a8a71bc883563()
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

      private sealed class MTHD_9f6ccd12d5e1443e878ccbf791dc9894 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f6ccd12d5e1443e878ccbf791dc9894()
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

      private sealed class MTHD_5fa0e68f4fdb458c9526331d9da2b2ec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5fa0e68f4fdb458c9526331d9da2b2ec()
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

      private sealed class MTHD_62b0030ef3494314ba6ee57e482ed89c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_62b0030ef3494314ba6ee57e482ed89c()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_a5458449167f43c9864fc66725eb0e45 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a5458449167f43c9864fc66725eb0e45()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_fbcc9c7a4fd64241abf0429a643d336e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fbcc9c7a4fd64241abf0429a643d336e()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_e0b776c9087d402e814f8dcda11690ef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e0b776c9087d402e814f8dcda11690ef()
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

      private sealed class MTHD_b4b2f3948f55444fb445c48f0fffb2f8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b4b2f3948f55444fb445c48f0fffb2f8()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_0e5d107a8d9745008e979fc22ea05929 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e5d107a8d9745008e979fc22ea05929()
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

      private sealed class MTHD_5c91f86c135344f59307fc56507290f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c91f86c135344f59307fc56507290f5()
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

      private sealed class MTHD_fe8c3adc55e74cb5b745ffa3a55215f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fe8c3adc55e74cb5b745ffa3a55215f5()
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

      private sealed class MTHD_691c323e3aaf405e8bd9ad246f4fa876 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_691c323e3aaf405e8bd9ad246f4fa876()
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

      private sealed class MTHD_eed3ac0469404bf7960af2071ddd3cab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eed3ac0469404bf7960af2071ddd3cab()
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

      private sealed class MTHD_300e3578fe63495aa47364e46ea774fb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_300e3578fe63495aa47364e46ea774fb()
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

      private sealed class MTHD_5ccc42579297426ca964f6346b0f1beb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ccc42579297426ca964f6346b0f1beb()
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

      private sealed class MTHD_64fffaf83eef4be78074c54fc97c31da : HardwiredMethodMemberDescriptor
      {
        internal MTHD_64fffaf83eef4be78074c54fc97c31da()
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

      private sealed class MTHD_32f832bde7b44695b3f9c24fa4fa06b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_32f832bde7b44695b3f9c24fa4fa06b9()
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

      private sealed class MTHD_4189dcc562f4487aaf4e950da82f5af5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4189dcc562f4487aaf4e950da82f5af5()
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

      private sealed class MTHD_4bd2a48833ea4dea8d7f9513e1e447f0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4bd2a48833ea4dea8d7f9513e1e447f0()
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

      private sealed class MTHD_41754768a3d74361a36579d2ae4f05ef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41754768a3d74361a36579d2ae4f05ef()
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

      private sealed class MTHD_bf3b08955e9a4209a426fc04f0ab1055 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf3b08955e9a4209a426fc04f0ab1055()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_3db8827de8234e3ebdade57f30d4992a : HardwiredMemberDescriptor
      {
        internal FLDV_3db8827de8234e3ebdade57f30d4992a()
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

      private sealed class FLDV_33363c6d66764f7a9ec985770863e610 : HardwiredMemberDescriptor
      {
        internal FLDV_33363c6d66764f7a9ec985770863e610()
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

    private sealed class TYPE_18885e133f8843af9176dc7ffb8655db : HardwiredUserDataDescriptor
    {
      internal TYPE_18885e133f8843af9176dc7ffb8655db()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18885e133f8843af9176dc7ffb8655db.MTHD_e8eeb10c19b94e818c3fbdd5d3534b06()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18885e133f8843af9176dc7ffb8655db.MTHD_79fffdca8eca497a97c7216bf4c6aa92()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18885e133f8843af9176dc7ffb8655db.MTHD_998a5981c8f141c7a2e1658a0beb2689()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18885e133f8843af9176dc7ffb8655db.MTHD_eba44447a69c47dab1b2d70b05017349()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18885e133f8843af9176dc7ffb8655db.MTHD_04ed02a0b18648bea1a6e6ca5352df4e()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18885e133f8843af9176dc7ffb8655db.MTHD_3d63d514b8b64d9f9af183f97e9e8ed9()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_18885e133f8843af9176dc7ffb8655db.FLDV_c4ebf8f9e6044a3fabb06b8b831c5433());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_18885e133f8843af9176dc7ffb8655db.FLDV_de6ee4f71caf4f9db171e08b58a52df5());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_18885e133f8843af9176dc7ffb8655db.FLDV_c4d25daeb5124314b352a997f5e6af55());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_18885e133f8843af9176dc7ffb8655db.FLDV_7f840c0b1d9e423aaa5424731e3b113f());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_18885e133f8843af9176dc7ffb8655db.FLDV_b4bf4696263d4f22bd5400867363524d());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_18885e133f8843af9176dc7ffb8655db.FLDV_20c6f50e8e674c4c8e37a06f2505ccf0());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_18885e133f8843af9176dc7ffb8655db.FLDV_b6206b5be68140a2b6d8223106bc9c1d());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_18885e133f8843af9176dc7ffb8655db.FLDV_788d818f406b473fbfa809475e44ec56());
        this.AddMember("prestige", (IMemberDescriptor) new Bridge.TYPE_18885e133f8843af9176dc7ffb8655db.FLDV_aa1ee8bf98b24d9d96fa0f90f054019b());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_18885e133f8843af9176dc7ffb8655db.FLDV_ef5d4c8fe2314881be6a44192b770fd4());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_18885e133f8843af9176dc7ffb8655db.FLDV_b6e218c4fb60486ca1d76ed8dba46b29());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_18885e133f8843af9176dc7ffb8655db.FLDV_e8851a6fcd6343f4bf2d0e097ba87a6b());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_18885e133f8843af9176dc7ffb8655db.FLDV_4c735b942eb94d608bb6131051bf0d96());
      }

      private sealed class MTHD_e8eeb10c19b94e818c3fbdd5d3534b06 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e8eeb10c19b94e818c3fbdd5d3534b06()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_79fffdca8eca497a97c7216bf4c6aa92 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_79fffdca8eca497a97c7216bf4c6aa92()
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

      private sealed class MTHD_998a5981c8f141c7a2e1658a0beb2689 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_998a5981c8f141c7a2e1658a0beb2689()
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

      private sealed class MTHD_eba44447a69c47dab1b2d70b05017349 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eba44447a69c47dab1b2d70b05017349()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_04ed02a0b18648bea1a6e6ca5352df4e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_04ed02a0b18648bea1a6e6ca5352df4e()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_3d63d514b8b64d9f9af183f97e9e8ed9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d63d514b8b64d9f9af183f97e9e8ed9()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_c4ebf8f9e6044a3fabb06b8b831c5433 : HardwiredMemberDescriptor
      {
        internal FLDV_c4ebf8f9e6044a3fabb06b8b831c5433()
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

      private sealed class FLDV_de6ee4f71caf4f9db171e08b58a52df5 : HardwiredMemberDescriptor
      {
        internal FLDV_de6ee4f71caf4f9db171e08b58a52df5()
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

      private sealed class FLDV_c4d25daeb5124314b352a997f5e6af55 : HardwiredMemberDescriptor
      {
        internal FLDV_c4d25daeb5124314b352a997f5e6af55()
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

      private sealed class FLDV_7f840c0b1d9e423aaa5424731e3b113f : HardwiredMemberDescriptor
      {
        internal FLDV_7f840c0b1d9e423aaa5424731e3b113f()
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

      private sealed class FLDV_b4bf4696263d4f22bd5400867363524d : HardwiredMemberDescriptor
      {
        internal FLDV_b4bf4696263d4f22bd5400867363524d()
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

      private sealed class FLDV_20c6f50e8e674c4c8e37a06f2505ccf0 : HardwiredMemberDescriptor
      {
        internal FLDV_20c6f50e8e674c4c8e37a06f2505ccf0()
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

      private sealed class FLDV_b6206b5be68140a2b6d8223106bc9c1d : HardwiredMemberDescriptor
      {
        internal FLDV_b6206b5be68140a2b6d8223106bc9c1d()
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

      private sealed class FLDV_788d818f406b473fbfa809475e44ec56 : HardwiredMemberDescriptor
      {
        internal FLDV_788d818f406b473fbfa809475e44ec56()
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

      private sealed class FLDV_aa1ee8bf98b24d9d96fa0f90f054019b : HardwiredMemberDescriptor
      {
        internal FLDV_aa1ee8bf98b24d9d96fa0f90f054019b()
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

      private sealed class FLDV_ef5d4c8fe2314881be6a44192b770fd4 : HardwiredMemberDescriptor
      {
        internal FLDV_ef5d4c8fe2314881be6a44192b770fd4()
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

      private sealed class FLDV_b6e218c4fb60486ca1d76ed8dba46b29 : HardwiredMemberDescriptor
      {
        internal FLDV_b6e218c4fb60486ca1d76ed8dba46b29()
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

      private sealed class FLDV_e8851a6fcd6343f4bf2d0e097ba87a6b : HardwiredMemberDescriptor
      {
        internal FLDV_e8851a6fcd6343f4bf2d0e097ba87a6b()
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

      private sealed class FLDV_4c735b942eb94d608bb6131051bf0d96 : HardwiredMemberDescriptor
      {
        internal FLDV_4c735b942eb94d608bb6131051bf0d96()
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

    private sealed class TYPE_35fc50c48d2e41bfaa12635104e36cb1 : HardwiredUserDataDescriptor
    {
      internal TYPE_35fc50c48d2e41bfaa12635104e36cb1()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_7d8ff088f0644b44a5649a1af0121890()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_bccd0867d9494e718b763c9186c52c96()
        }));
        this.AddMember("get_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_7812773e1c8d4e3badeafcf08791dab6()
        }));
        this.AddMember("set_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_4c814d756128462a8dc825bd98e4e255()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_b4c3773391354981bd55044fabbc6c75()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_cdd1997a4e2d4a91a9719b072e0ed15b()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_cbec920e84c1424dadd2e559df10e51a()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_21b1d312f59846348ee289cd28d481ee()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_20ddc96cda674bfd9568de023ad68ba1()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_2c0730b36b684c8f9d384dc6e867cdec()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_bd7f529d8b3e43a681060bad911de04f()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_9ad218f488884d2b8514146d337e168c()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_766ac689c0224673aef675c7b9d624e3()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_d8033cb706e940039075352ded11f949()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_8ce49695f61244ad816f91f40cee4cdc()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_607550be20fb49c3b7a6f27e66cea8e5()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_b82f9683d2be409fac87622e2eb214eb()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_0d745d876f1647779ad04f6d6978936a()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_eb1a8b4b97e54c9fb2a79def13560c27()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_1a0b62b5d7554254919c02b0b26b0a64()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_7476becbbf054c1f8b25f835307ab3fb()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_32beb8e6596c458cb53eba7fc62a5d9a()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_875f08a0e92c494ea370dc7d8d3576fe()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_c614834fc4c340ae80729ddb727cbe26()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_bae68c2003884fb2aea7f5ea5fb99832()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_4a6cf5e354094aa3a20488a2a661ce7c()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_b99eddb2302642fa93c6902f91cd8e38()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_6387837fe984493d9fb908b8100d3462()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_825b218329e749d091792f95a0b0d5ef()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_48f07093a80a4581a0a48e88749cdc56()
        }));
        this.AddMember("get_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_55fa44e405074a93bb4f5baa0ace4611()
        }));
        this.AddMember("set_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_3405cad82a0a413fa845c322476463c5()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_df1ec231c55143d88bcabf62046abdf0()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_f6cbb9d5917f4cd39efb3416a2fc944b()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_05567d059559431c9b6dabf8e24314bd()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_fb1c0cee75bd4eb6b63548449d4ae0cb()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_c42f6d5514b64dcca479ffc5773c1995()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_2f3e71b989a745c2a6913adde9b73a22()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_79fc443c0f4b4b64aa065110b415b247()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_7f5823d2dd984b7ab705194215668f21()
        }));
        this.AddMember("get_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_0c629396382f4f7883bb9d6cef6427cb()
        }));
        this.AddMember("set_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_f5e6ab14358b421d8eeab82d3cd1cb51()
        }));
        this.AddMember("get_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_03e0989b75ff47568112721fdcc4d1d7()
        }));
        this.AddMember("set_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_9021e0ae7c6447119e4f84c47bc292b0()
        }));
        this.AddMember("get_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_6efbeebfe5104a109961aa98d131e06e()
        }));
        this.AddMember("set_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_e7b9bedbd707458fad73c8a0bda613af()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_207257efb4994fc88d338293aacdf4a6()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_1c5faa49640948ff81ecabf920337284()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_17328767807441598eb324820083191b()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_c353044011d5425684d79c01aeb2e0ba()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_6a31e83490004be1bd6aa6470c1fa59a()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_3d0f9bafdfb040d88727e2b6c19fc57f()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_3070ec8ce5e040a0bdb0ca262a43fa8d()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_0338e7586078440e9f3c50f2a1fc44ea()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_9d59279c2caa43f4abd2c7b778a57a11()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_819b42b693fe455d942748b0c05f276a()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_93fbb338b28b41ec8305f9d63846de1a()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_a0b32dab850b40738953fc769917f7a2()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_a181d46767404f47bbf3bec9f37b331e()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.MTHD_4823f61ae7f64068a648d76e3111bea7()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.PROP_58ffe1b9be994db48c3855c747e96e45());
        this.AddMember("visible", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.PROP_a0f19661ac1f4b43b3979aab7ada5ece());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.PROP_fa58c69140c245a4b4b00371c00cdbd8());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.PROP_e38356b73b9a4958a771c09bd9d4b6f6());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.PROP_7540e6999f76403194046a0ad01f6c29());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.PROP_57d135c081a74cebaa33ca02cb101d27());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.PROP_77c8fe755879470aa2ae7bb1caa87900());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.PROP_5aa576300efd405382c352b9552568a0());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.PROP_d1ac9981b4e6471a8532de89f4d3dd87());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.PROP_86dc41e7c211454b8a4a07840b864ea1());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.PROP_944e39af39ba445a93928e9f093428f3());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.PROP_47227fee3dd146469de370dfa4f26fc2());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.PROP_44c52dbc071a42c48fac3ca947557f2d());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.PROP_fda8e90c26604b33b933d9e60bc7dfb6());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.PROP_095e23ee27084535ae1a14751c9b3ce6());
        this.AddMember("onClick2", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.PROP_ee426df3e9c84faf96c4a413565babde());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.PROP_e508be92cae44bd3abdd9e3e06cbedce());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.PROP_fede971020f8405ca8050677588d6ab3());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.PROP_7df38a0996af420db4d9f898d3f8bc8e());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.PROP_c6cb1356d31b46d597c7cf1d9bc40703());
        this.AddMember("textColor2", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.PROP_e19a455544824415a25e17ff97ca8412());
        this.AddMember("highlightColor", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.PROP_95040ebb875f4101a73639cc1cd25c2d());
        this.AddMember("highlightColor2", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.PROP_59ca784d0d5c4ea58478dff1ff511dbc());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.PROP_328b8ab444ca41268fdf8d01d2555791());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.PROP_33c5fce4941b450d8666cfd48f3b6cbc());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.FLDV_286d10ffb840470c8abe7354131ac468());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.FLDV_6a28684e833c4f6cae4fc6e0a7911c18());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_35fc50c48d2e41bfaa12635104e36cb1.FLDV_6a48f0f161f94a36bdbbe1341d3ee853());
      }

      private sealed class MTHD_7d8ff088f0644b44a5649a1af0121890 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7d8ff088f0644b44a5649a1af0121890()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_bccd0867d9494e718b763c9186c52c96 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bccd0867d9494e718b763c9186c52c96()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_7812773e1c8d4e3badeafcf08791dab6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7812773e1c8d4e3badeafcf08791dab6()
        {
          this.Initialize("get_visible", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).visible;
        }
      }

      private sealed class MTHD_4c814d756128462a8dc825bd98e4e255 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c814d756128462a8dc825bd98e4e255()
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

      private sealed class MTHD_b4c3773391354981bd55044fabbc6c75 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b4c3773391354981bd55044fabbc6c75()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_cdd1997a4e2d4a91a9719b072e0ed15b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cdd1997a4e2d4a91a9719b072e0ed15b()
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

      private sealed class MTHD_cbec920e84c1424dadd2e559df10e51a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cbec920e84c1424dadd2e559df10e51a()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_21b1d312f59846348ee289cd28d481ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_21b1d312f59846348ee289cd28d481ee()
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

      private sealed class MTHD_20ddc96cda674bfd9568de023ad68ba1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_20ddc96cda674bfd9568de023ad68ba1()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_2c0730b36b684c8f9d384dc6e867cdec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c0730b36b684c8f9d384dc6e867cdec()
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

      private sealed class MTHD_bd7f529d8b3e43a681060bad911de04f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd7f529d8b3e43a681060bad911de04f()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_9ad218f488884d2b8514146d337e168c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ad218f488884d2b8514146d337e168c()
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

      private sealed class MTHD_766ac689c0224673aef675c7b9d624e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_766ac689c0224673aef675c7b9d624e3()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_d8033cb706e940039075352ded11f949 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8033cb706e940039075352ded11f949()
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

      private sealed class MTHD_8ce49695f61244ad816f91f40cee4cdc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ce49695f61244ad816f91f40cee4cdc()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_607550be20fb49c3b7a6f27e66cea8e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_607550be20fb49c3b7a6f27e66cea8e5()
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

      private sealed class MTHD_b82f9683d2be409fac87622e2eb214eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b82f9683d2be409fac87622e2eb214eb()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_0d745d876f1647779ad04f6d6978936a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d745d876f1647779ad04f6d6978936a()
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

      private sealed class MTHD_eb1a8b4b97e54c9fb2a79def13560c27 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb1a8b4b97e54c9fb2a79def13560c27()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_1a0b62b5d7554254919c02b0b26b0a64 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a0b62b5d7554254919c02b0b26b0a64()
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

      private sealed class MTHD_7476becbbf054c1f8b25f835307ab3fb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7476becbbf054c1f8b25f835307ab3fb()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_32beb8e6596c458cb53eba7fc62a5d9a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_32beb8e6596c458cb53eba7fc62a5d9a()
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

      private sealed class MTHD_875f08a0e92c494ea370dc7d8d3576fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_875f08a0e92c494ea370dc7d8d3576fe()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_c614834fc4c340ae80729ddb727cbe26 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c614834fc4c340ae80729ddb727cbe26()
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

      private sealed class MTHD_bae68c2003884fb2aea7f5ea5fb99832 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bae68c2003884fb2aea7f5ea5fb99832()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_4a6cf5e354094aa3a20488a2a661ce7c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a6cf5e354094aa3a20488a2a661ce7c()
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

      private sealed class MTHD_b99eddb2302642fa93c6902f91cd8e38 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b99eddb2302642fa93c6902f91cd8e38()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_6387837fe984493d9fb908b8100d3462 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6387837fe984493d9fb908b8100d3462()
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

      private sealed class MTHD_825b218329e749d091792f95a0b0d5ef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_825b218329e749d091792f95a0b0d5ef()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_48f07093a80a4581a0a48e88749cdc56 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_48f07093a80a4581a0a48e88749cdc56()
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

      private sealed class MTHD_55fa44e405074a93bb4f5baa0ace4611 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_55fa44e405074a93bb4f5baa0ace4611()
        {
          this.Initialize("get_onClick2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick2;
        }
      }

      private sealed class MTHD_3405cad82a0a413fa845c322476463c5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3405cad82a0a413fa845c322476463c5()
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

      private sealed class MTHD_df1ec231c55143d88bcabf62046abdf0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_df1ec231c55143d88bcabf62046abdf0()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_f6cbb9d5917f4cd39efb3416a2fc944b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f6cbb9d5917f4cd39efb3416a2fc944b()
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

      private sealed class MTHD_05567d059559431c9b6dabf8e24314bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_05567d059559431c9b6dabf8e24314bd()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color2;
        }
      }

      private sealed class MTHD_fb1c0cee75bd4eb6b63548449d4ae0cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb1c0cee75bd4eb6b63548449d4ae0cb()
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

      private sealed class MTHD_c42f6d5514b64dcca479ffc5773c1995 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c42f6d5514b64dcca479ffc5773c1995()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_2f3e71b989a745c2a6913adde9b73a22 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2f3e71b989a745c2a6913adde9b73a22()
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

      private sealed class MTHD_79fc443c0f4b4b64aa065110b415b247 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_79fc443c0f4b4b64aa065110b415b247()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_7f5823d2dd984b7ab705194215668f21 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f5823d2dd984b7ab705194215668f21()
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

      private sealed class MTHD_0c629396382f4f7883bb9d6cef6427cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c629396382f4f7883bb9d6cef6427cb()
        {
          this.Initialize("get_textColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor2;
        }
      }

      private sealed class MTHD_f5e6ab14358b421d8eeab82d3cd1cb51 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f5e6ab14358b421d8eeab82d3cd1cb51()
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

      private sealed class MTHD_03e0989b75ff47568112721fdcc4d1d7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_03e0989b75ff47568112721fdcc4d1d7()
        {
          this.Initialize("get_highlightColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor;
        }
      }

      private sealed class MTHD_9021e0ae7c6447119e4f84c47bc292b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9021e0ae7c6447119e4f84c47bc292b0()
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

      private sealed class MTHD_6efbeebfe5104a109961aa98d131e06e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6efbeebfe5104a109961aa98d131e06e()
        {
          this.Initialize("get_highlightColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor2;
        }
      }

      private sealed class MTHD_e7b9bedbd707458fad73c8a0bda613af : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7b9bedbd707458fad73c8a0bda613af()
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

      private sealed class MTHD_207257efb4994fc88d338293aacdf4a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_207257efb4994fc88d338293aacdf4a6()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_1c5faa49640948ff81ecabf920337284 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c5faa49640948ff81ecabf920337284()
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

      private sealed class MTHD_17328767807441598eb324820083191b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_17328767807441598eb324820083191b()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_c353044011d5425684d79c01aeb2e0ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c353044011d5425684d79c01aeb2e0ba()
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

      private sealed class MTHD_6a31e83490004be1bd6aa6470c1fa59a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6a31e83490004be1bd6aa6470c1fa59a()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_3d0f9bafdfb040d88727e2b6c19fc57f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d0f9bafdfb040d88727e2b6c19fc57f()
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

      private sealed class MTHD_3070ec8ce5e040a0bdb0ca262a43fa8d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3070ec8ce5e040a0bdb0ca262a43fa8d()
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

      private sealed class MTHD_0338e7586078440e9f3c50f2a1fc44ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0338e7586078440e9f3c50f2a1fc44ea()
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

      private sealed class MTHD_9d59279c2caa43f4abd2c7b778a57a11 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d59279c2caa43f4abd2c7b778a57a11()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_819b42b693fe455d942748b0c05f276a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_819b42b693fe455d942748b0c05f276a()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_93fbb338b28b41ec8305f9d63846de1a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93fbb338b28b41ec8305f9d63846de1a()
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

      private sealed class MTHD_a0b32dab850b40738953fc769917f7a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a0b32dab850b40738953fc769917f7a2()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_a181d46767404f47bbf3bec9f37b331e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a181d46767404f47bbf3bec9f37b331e()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_4823f61ae7f64068a648d76e3111bea7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4823f61ae7f64068a648d76e3111bea7()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_58ffe1b9be994db48c3855c747e96e45 : HardwiredMemberDescriptor
      {
        internal PROP_58ffe1b9be994db48c3855c747e96e45()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_a0f19661ac1f4b43b3979aab7ada5ece : HardwiredMemberDescriptor
      {
        internal PROP_a0f19661ac1f4b43b3979aab7ada5ece()
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

      private sealed class PROP_fa58c69140c245a4b4b00371c00cdbd8 : HardwiredMemberDescriptor
      {
        internal PROP_fa58c69140c245a4b4b00371c00cdbd8()
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

      private sealed class PROP_e38356b73b9a4958a771c09bd9d4b6f6 : HardwiredMemberDescriptor
      {
        internal PROP_e38356b73b9a4958a771c09bd9d4b6f6()
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

      private sealed class PROP_7540e6999f76403194046a0ad01f6c29 : HardwiredMemberDescriptor
      {
        internal PROP_7540e6999f76403194046a0ad01f6c29()
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

      private sealed class PROP_57d135c081a74cebaa33ca02cb101d27 : HardwiredMemberDescriptor
      {
        internal PROP_57d135c081a74cebaa33ca02cb101d27()
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

      private sealed class PROP_77c8fe755879470aa2ae7bb1caa87900 : HardwiredMemberDescriptor
      {
        internal PROP_77c8fe755879470aa2ae7bb1caa87900()
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

      private sealed class PROP_5aa576300efd405382c352b9552568a0 : HardwiredMemberDescriptor
      {
        internal PROP_5aa576300efd405382c352b9552568a0()
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

      private sealed class PROP_d1ac9981b4e6471a8532de89f4d3dd87 : HardwiredMemberDescriptor
      {
        internal PROP_d1ac9981b4e6471a8532de89f4d3dd87()
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

      private sealed class PROP_86dc41e7c211454b8a4a07840b864ea1 : HardwiredMemberDescriptor
      {
        internal PROP_86dc41e7c211454b8a4a07840b864ea1()
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

      private sealed class PROP_944e39af39ba445a93928e9f093428f3 : HardwiredMemberDescriptor
      {
        internal PROP_944e39af39ba445a93928e9f093428f3()
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

      private sealed class PROP_47227fee3dd146469de370dfa4f26fc2 : HardwiredMemberDescriptor
      {
        internal PROP_47227fee3dd146469de370dfa4f26fc2()
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

      private sealed class PROP_44c52dbc071a42c48fac3ca947557f2d : HardwiredMemberDescriptor
      {
        internal PROP_44c52dbc071a42c48fac3ca947557f2d()
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

      private sealed class PROP_fda8e90c26604b33b933d9e60bc7dfb6 : HardwiredMemberDescriptor
      {
        internal PROP_fda8e90c26604b33b933d9e60bc7dfb6()
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

      private sealed class PROP_095e23ee27084535ae1a14751c9b3ce6 : HardwiredMemberDescriptor
      {
        internal PROP_095e23ee27084535ae1a14751c9b3ce6()
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

      private sealed class PROP_ee426df3e9c84faf96c4a413565babde : HardwiredMemberDescriptor
      {
        internal PROP_ee426df3e9c84faf96c4a413565babde()
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

      private sealed class PROP_e508be92cae44bd3abdd9e3e06cbedce : HardwiredMemberDescriptor
      {
        internal PROP_e508be92cae44bd3abdd9e3e06cbedce()
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

      private sealed class PROP_fede971020f8405ca8050677588d6ab3 : HardwiredMemberDescriptor
      {
        internal PROP_fede971020f8405ca8050677588d6ab3()
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

      private sealed class PROP_7df38a0996af420db4d9f898d3f8bc8e : HardwiredMemberDescriptor
      {
        internal PROP_7df38a0996af420db4d9f898d3f8bc8e()
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

      private sealed class PROP_c6cb1356d31b46d597c7cf1d9bc40703 : HardwiredMemberDescriptor
      {
        internal PROP_c6cb1356d31b46d597c7cf1d9bc40703()
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

      private sealed class PROP_e19a455544824415a25e17ff97ca8412 : HardwiredMemberDescriptor
      {
        internal PROP_e19a455544824415a25e17ff97ca8412()
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

      private sealed class PROP_95040ebb875f4101a73639cc1cd25c2d : HardwiredMemberDescriptor
      {
        internal PROP_95040ebb875f4101a73639cc1cd25c2d()
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

      private sealed class PROP_59ca784d0d5c4ea58478dff1ff511dbc : HardwiredMemberDescriptor
      {
        internal PROP_59ca784d0d5c4ea58478dff1ff511dbc()
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

      private sealed class PROP_328b8ab444ca41268fdf8d01d2555791 : HardwiredMemberDescriptor
      {
        internal PROP_328b8ab444ca41268fdf8d01d2555791()
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

      private sealed class PROP_33c5fce4941b450d8666cfd48f3b6cbc : HardwiredMemberDescriptor
      {
        internal PROP_33c5fce4941b450d8666cfd48f3b6cbc()
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

      private sealed class FLDV_286d10ffb840470c8abe7354131ac468 : HardwiredMemberDescriptor
      {
        internal FLDV_286d10ffb840470c8abe7354131ac468()
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

      private sealed class FLDV_6a28684e833c4f6cae4fc6e0a7911c18 : HardwiredMemberDescriptor
      {
        internal FLDV_6a28684e833c4f6cae4fc6e0a7911c18()
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

      private sealed class FLDV_6a48f0f161f94a36bdbbe1341d3ee853 : HardwiredMemberDescriptor
      {
        internal FLDV_6a48f0f161f94a36bdbbe1341d3ee853()
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

    private sealed class TYPE_dd38bc58b0284112992f7ea388aa1d6e : HardwiredUserDataDescriptor
    {
      internal TYPE_dd38bc58b0284112992f7ea388aa1d6e()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd38bc58b0284112992f7ea388aa1d6e.MTHD_a025fd793a5c41a8af0657b9638cd046()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd38bc58b0284112992f7ea388aa1d6e.MTHD_f964df3dce1c4c12b01d08955ad55824()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd38bc58b0284112992f7ea388aa1d6e.MTHD_e5e60d55f2414b51a20dcdb8387bee9d()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd38bc58b0284112992f7ea388aa1d6e.MTHD_9826364307ef4d869d40b98a58cc4417()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd38bc58b0284112992f7ea388aa1d6e.MTHD_83bd7363df464a5bb3951bf72c8d4115()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dd38bc58b0284112992f7ea388aa1d6e.MTHD_b8383f8ef6a4420dab5df0b142dd1f62()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_dd38bc58b0284112992f7ea388aa1d6e.FLDV_cc16dd9e99a149d9842da2d2f2ca7022());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_dd38bc58b0284112992f7ea388aa1d6e.FLDV_9bf12706656c47838e67c4e720317591());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_dd38bc58b0284112992f7ea388aa1d6e.FLDV_ff44a0e806f24514bc6cb3c580e84c3f());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_dd38bc58b0284112992f7ea388aa1d6e.FLDV_a09deee9bbe84494a28bf727d6f10ea1());
      }

      private sealed class MTHD_a025fd793a5c41a8af0657b9638cd046 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a025fd793a5c41a8af0657b9638cd046()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_f964df3dce1c4c12b01d08955ad55824 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f964df3dce1c4c12b01d08955ad55824()
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

      private sealed class MTHD_e5e60d55f2414b51a20dcdb8387bee9d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e5e60d55f2414b51a20dcdb8387bee9d()
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

      private sealed class MTHD_9826364307ef4d869d40b98a58cc4417 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9826364307ef4d869d40b98a58cc4417()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_83bd7363df464a5bb3951bf72c8d4115 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_83bd7363df464a5bb3951bf72c8d4115()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_b8383f8ef6a4420dab5df0b142dd1f62 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b8383f8ef6a4420dab5df0b142dd1f62()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_cc16dd9e99a149d9842da2d2f2ca7022 : HardwiredMemberDescriptor
      {
        internal FLDV_cc16dd9e99a149d9842da2d2f2ca7022()
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

      private sealed class FLDV_9bf12706656c47838e67c4e720317591 : HardwiredMemberDescriptor
      {
        internal FLDV_9bf12706656c47838e67c4e720317591()
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

      private sealed class FLDV_ff44a0e806f24514bc6cb3c580e84c3f : HardwiredMemberDescriptor
      {
        internal FLDV_ff44a0e806f24514bc6cb3c580e84c3f()
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

      private sealed class FLDV_a09deee9bbe84494a28bf727d6f10ea1 : HardwiredMemberDescriptor
      {
        internal FLDV_a09deee9bbe84494a28bf727d6f10ea1()
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

    private sealed class TYPE_66df29e9caa04c4d8581bb036e2d5c1e : HardwiredUserDataDescriptor
    {
      internal TYPE_66df29e9caa04c4d8581bb036e2d5c1e()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66df29e9caa04c4d8581bb036e2d5c1e.MTHD_f932cb51dc2d422690c55a50499069e5()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66df29e9caa04c4d8581bb036e2d5c1e.MTHD_53a77959b3b24df99b49f9662c795dcc()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66df29e9caa04c4d8581bb036e2d5c1e.MTHD_36ea1a634d7f46698a8955ff3426aa98()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66df29e9caa04c4d8581bb036e2d5c1e.MTHD_9e1300fc5a9b474da0d3930575400070()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_66df29e9caa04c4d8581bb036e2d5c1e.MTHD_6845ef3374504256b62433db30904c90()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_66df29e9caa04c4d8581bb036e2d5c1e.FLDV_0c02529ad57449e682d3d4cebb2c663e());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_66df29e9caa04c4d8581bb036e2d5c1e.FLDV_8ca86c5dec2f4b9ab5de3a8eb802862d());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_66df29e9caa04c4d8581bb036e2d5c1e.FLDV_2e09174cad124959a88d9a23bdee2223());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_66df29e9caa04c4d8581bb036e2d5c1e.FLDV_d0bb236a631d47c08f37cba16fc04d09());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_66df29e9caa04c4d8581bb036e2d5c1e.FLDV_1e038cc903364a2e9cd4cae5cee39752());
      }

      private sealed class MTHD_f932cb51dc2d422690c55a50499069e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f932cb51dc2d422690c55a50499069e5()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_53a77959b3b24df99b49f9662c795dcc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_53a77959b3b24df99b49f9662c795dcc()
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

      private sealed class MTHD_36ea1a634d7f46698a8955ff3426aa98 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_36ea1a634d7f46698a8955ff3426aa98()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_9e1300fc5a9b474da0d3930575400070 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e1300fc5a9b474da0d3930575400070()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_6845ef3374504256b62433db30904c90 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6845ef3374504256b62433db30904c90()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_0c02529ad57449e682d3d4cebb2c663e : HardwiredMemberDescriptor
      {
        internal FLDV_0c02529ad57449e682d3d4cebb2c663e()
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

      private sealed class FLDV_8ca86c5dec2f4b9ab5de3a8eb802862d : HardwiredMemberDescriptor
      {
        internal FLDV_8ca86c5dec2f4b9ab5de3a8eb802862d()
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

      private sealed class FLDV_2e09174cad124959a88d9a23bdee2223 : HardwiredMemberDescriptor
      {
        internal FLDV_2e09174cad124959a88d9a23bdee2223()
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

      private sealed class FLDV_d0bb236a631d47c08f37cba16fc04d09 : HardwiredMemberDescriptor
      {
        internal FLDV_d0bb236a631d47c08f37cba16fc04d09()
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

      private sealed class FLDV_1e038cc903364a2e9cd4cae5cee39752 : HardwiredMemberDescriptor
      {
        internal FLDV_1e038cc903364a2e9cd4cae5cee39752()
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

    private sealed class TYPE_77b24fc2f3584da4912c816257f1c63a : HardwiredUserDataDescriptor
    {
      internal TYPE_77b24fc2f3584da4912c816257f1c63a()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77b24fc2f3584da4912c816257f1c63a.MTHD_bd657f95b212463fb0e69570b188f484()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77b24fc2f3584da4912c816257f1c63a.MTHD_6f010efe674f46d09bc60783fbbdfa6e()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77b24fc2f3584da4912c816257f1c63a.MTHD_9d30b4aabd1944d8bde224b41e20b8e1()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77b24fc2f3584da4912c816257f1c63a.MTHD_2dd745a0623f416e849ed8e1398cf9c6()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77b24fc2f3584da4912c816257f1c63a.MTHD_d73247dbbb4d4db4a76be9f3c5bc653d()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77b24fc2f3584da4912c816257f1c63a.MTHD_ef8b002748ff4769ac357b4943e41e40()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77b24fc2f3584da4912c816257f1c63a.MTHD_7f3c9a8870fd439d9415a5d29a70e72e()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77b24fc2f3584da4912c816257f1c63a.MTHD_84f26874573c449a9c88c7d39d02ff28()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77b24fc2f3584da4912c816257f1c63a.MTHD_57f274917f7e4d82a0e1e1f5d6b24a29()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77b24fc2f3584da4912c816257f1c63a.MTHD_d18b99aae46947cda58820dbf9e34ca3()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77b24fc2f3584da4912c816257f1c63a.MTHD_9ec4e7bd764f45adbe6aab11e8aca4f2()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77b24fc2f3584da4912c816257f1c63a.MTHD_286a246ebd72476ea92c0e5a21028cb0()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_77b24fc2f3584da4912c816257f1c63a.MTHD_1d26d48e8a204a86be4b72b2bea2c0e5()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_77b24fc2f3584da4912c816257f1c63a.FLDV_96f969cf269640b59dbfd03a7c079b51());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_77b24fc2f3584da4912c816257f1c63a.FLDV_f1d104fedd0f4976b98910e6887276e5());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_77b24fc2f3584da4912c816257f1c63a.FLDV_2b86b429f2ad45ed99d9d05b73811a6e());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_77b24fc2f3584da4912c816257f1c63a.FLDV_93b19167efc34831a1c47090cb0919a7());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_77b24fc2f3584da4912c816257f1c63a.FLDV_c7ee70114bf14b2a89a26cb3a241b949());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_77b24fc2f3584da4912c816257f1c63a.FLDV_11a8ff2ff8cb4e8faee4f27b30d6f416());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_77b24fc2f3584da4912c816257f1c63a.FLDV_0cfe92faeca04be8ba2fcb178e5ccb19());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_77b24fc2f3584da4912c816257f1c63a.FLDV_02d134bae8564ad48439f1dc7d2d71e3());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_77b24fc2f3584da4912c816257f1c63a.DVAL_ec93a95eae9a42509e28b408e7ce198f());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_77b24fc2f3584da4912c816257f1c63a.DVAL_15d4f157da344576bcebcf08398a1d64());
      }

      private sealed class MTHD_bd657f95b212463fb0e69570b188f484 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd657f95b212463fb0e69570b188f484()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_6f010efe674f46d09bc60783fbbdfa6e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6f010efe674f46d09bc60783fbbdfa6e()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_9d30b4aabd1944d8bde224b41e20b8e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d30b4aabd1944d8bde224b41e20b8e1()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_2dd745a0623f416e849ed8e1398cf9c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2dd745a0623f416e849ed8e1398cf9c6()
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

      private sealed class MTHD_d73247dbbb4d4db4a76be9f3c5bc653d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d73247dbbb4d4db4a76be9f3c5bc653d()
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

      private sealed class MTHD_ef8b002748ff4769ac357b4943e41e40 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef8b002748ff4769ac357b4943e41e40()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_7f3c9a8870fd439d9415a5d29a70e72e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f3c9a8870fd439d9415a5d29a70e72e()
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

      private sealed class MTHD_84f26874573c449a9c88c7d39d02ff28 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84f26874573c449a9c88c7d39d02ff28()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_57f274917f7e4d82a0e1e1f5d6b24a29 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57f274917f7e4d82a0e1e1f5d6b24a29()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_d18b99aae46947cda58820dbf9e34ca3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d18b99aae46947cda58820dbf9e34ca3()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9ec4e7bd764f45adbe6aab11e8aca4f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ec4e7bd764f45adbe6aab11e8aca4f2()
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

      private sealed class MTHD_286a246ebd72476ea92c0e5a21028cb0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_286a246ebd72476ea92c0e5a21028cb0()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_1d26d48e8a204a86be4b72b2bea2c0e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d26d48e8a204a86be4b72b2bea2c0e5()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_96f969cf269640b59dbfd03a7c079b51 : HardwiredMemberDescriptor
      {
        internal FLDV_96f969cf269640b59dbfd03a7c079b51()
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

      private sealed class FLDV_f1d104fedd0f4976b98910e6887276e5 : HardwiredMemberDescriptor
      {
        internal FLDV_f1d104fedd0f4976b98910e6887276e5()
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

      private sealed class FLDV_2b86b429f2ad45ed99d9d05b73811a6e : HardwiredMemberDescriptor
      {
        internal FLDV_2b86b429f2ad45ed99d9d05b73811a6e()
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

      private sealed class FLDV_93b19167efc34831a1c47090cb0919a7 : HardwiredMemberDescriptor
      {
        internal FLDV_93b19167efc34831a1c47090cb0919a7()
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

      private sealed class FLDV_c7ee70114bf14b2a89a26cb3a241b949 : HardwiredMemberDescriptor
      {
        internal FLDV_c7ee70114bf14b2a89a26cb3a241b949()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_11a8ff2ff8cb4e8faee4f27b30d6f416 : HardwiredMemberDescriptor
      {
        internal FLDV_11a8ff2ff8cb4e8faee4f27b30d6f416()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_0cfe92faeca04be8ba2fcb178e5ccb19 : HardwiredMemberDescriptor
      {
        internal FLDV_0cfe92faeca04be8ba2fcb178e5ccb19()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_02d134bae8564ad48439f1dc7d2d71e3 : HardwiredMemberDescriptor
      {
        internal FLDV_02d134bae8564ad48439f1dc7d2d71e3()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_ec93a95eae9a42509e28b408e7ce198f : DynValueMemberDescriptor
      {
        internal DVAL_ec93a95eae9a42509e28b408e7ce198f()
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

      private sealed class DVAL_15d4f157da344576bcebcf08398a1d64 : DynValueMemberDescriptor
      {
        internal DVAL_15d4f157da344576bcebcf08398a1d64()
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

    private sealed class TYPE_a187a273484a4c3baebc307a4934a4d3 : HardwiredUserDataDescriptor
    {
      internal TYPE_a187a273484a4c3baebc307a4934a4d3()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a187a273484a4c3baebc307a4934a4d3.MTHD_621b717228794d9f9dd68c92d4d9e977()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a187a273484a4c3baebc307a4934a4d3.MTHD_d2250f469e9e49d68db5ed316394233e()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a187a273484a4c3baebc307a4934a4d3.MTHD_0eae474ef51043b8ba8e5fbef0e5e6ca(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a187a273484a4c3baebc307a4934a4d3.MTHD_beddd221df9f4798bb0b191867cf3195()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a187a273484a4c3baebc307a4934a4d3.MTHD_3097289890314c84a10c47dcc4ed1de9(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a187a273484a4c3baebc307a4934a4d3.MTHD_ef88c7cdb24c4a0b9873654ec9f989ac()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a187a273484a4c3baebc307a4934a4d3.MTHD_23123d4b784043b4b3a02b9937bf691a()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a187a273484a4c3baebc307a4934a4d3.MTHD_39de4ca1eae54d2ea99c8650e1b6c468()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a187a273484a4c3baebc307a4934a4d3.MTHD_222cfd12c01f469fbebdbf046290aec7()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a187a273484a4c3baebc307a4934a4d3.MTHD_42fb77dd437d429b978d51c5bcefd3d3()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_a187a273484a4c3baebc307a4934a4d3.FLDV_88404bc38a7043b382d7a6cbb0a86d1d());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_a187a273484a4c3baebc307a4934a4d3.FLDV_7fd23290a2af4b5b88522a2e383fba5a());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_a187a273484a4c3baebc307a4934a4d3.FLDV_24735d6a2d024089a2c8d5a6a25c63ef());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_a187a273484a4c3baebc307a4934a4d3.FLDV_391d7af031354ee6af8ad1a84b97e3dd());
        this.AddMember("white", (IMemberDescriptor) new Bridge.TYPE_a187a273484a4c3baebc307a4934a4d3.FLDV_cad5c6f9e0d4482f9f06b4514316573c());
      }

      private sealed class MTHD_621b717228794d9f9dd68c92d4d9e977 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_621b717228794d9f9dd68c92d4d9e977()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_d2250f469e9e49d68db5ed316394233e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d2250f469e9e49d68db5ed316394233e()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_0eae474ef51043b8ba8e5fbef0e5e6ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0eae474ef51043b8ba8e5fbef0e5e6ca()
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

      private sealed class MTHD_beddd221df9f4798bb0b191867cf3195 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_beddd221df9f4798bb0b191867cf3195()
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

      private sealed class MTHD_3097289890314c84a10c47dcc4ed1de9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3097289890314c84a10c47dcc4ed1de9()
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

      private sealed class MTHD_ef88c7cdb24c4a0b9873654ec9f989ac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef88c7cdb24c4a0b9873654ec9f989ac()
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

      private sealed class MTHD_23123d4b784043b4b3a02b9937bf691a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_23123d4b784043b4b3a02b9937bf691a()
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

      private sealed class MTHD_39de4ca1eae54d2ea99c8650e1b6c468 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_39de4ca1eae54d2ea99c8650e1b6c468()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_222cfd12c01f469fbebdbf046290aec7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_222cfd12c01f469fbebdbf046290aec7()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_42fb77dd437d429b978d51c5bcefd3d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42fb77dd437d429b978d51c5bcefd3d3()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_88404bc38a7043b382d7a6cbb0a86d1d : HardwiredMemberDescriptor
      {
        internal FLDV_88404bc38a7043b382d7a6cbb0a86d1d()
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

      private sealed class FLDV_7fd23290a2af4b5b88522a2e383fba5a : HardwiredMemberDescriptor
      {
        internal FLDV_7fd23290a2af4b5b88522a2e383fba5a()
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

      private sealed class FLDV_24735d6a2d024089a2c8d5a6a25c63ef : HardwiredMemberDescriptor
      {
        internal FLDV_24735d6a2d024089a2c8d5a6a25c63ef()
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

      private sealed class FLDV_391d7af031354ee6af8ad1a84b97e3dd : HardwiredMemberDescriptor
      {
        internal FLDV_391d7af031354ee6af8ad1a84b97e3dd()
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

      private sealed class FLDV_cad5c6f9e0d4482f9f06b4514316573c : HardwiredMemberDescriptor
      {
        internal FLDV_cad5c6f9e0d4482f9f06b4514316573c()
          : base(typeof (LuaColor), "white", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) LuaColor.white;
        }
      }
    }

    private sealed class TYPE_d0b0468ce88c4c38a172949524bbeee0 : HardwiredUserDataDescriptor
    {
      internal TYPE_d0b0468ce88c4c38a172949524bbeee0()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0b0468ce88c4c38a172949524bbeee0.MTHD_4be209caf5284970869932ce5dfc4513()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0b0468ce88c4c38a172949524bbeee0.MTHD_0e2ea234acf642c387e6495927abab4f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0b0468ce88c4c38a172949524bbeee0.MTHD_d211fabb2c534ae390ea8e00eaafb8fd()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0b0468ce88c4c38a172949524bbeee0.MTHD_2163d992fa6046f0b0726fc6c8f93e2d()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0b0468ce88c4c38a172949524bbeee0.MTHD_da4cc06309c14095a7274e42d0f77ebd()
        }));
      }

      private sealed class MTHD_4be209caf5284970869932ce5dfc4513 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4be209caf5284970869932ce5dfc4513()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_0e2ea234acf642c387e6495927abab4f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e2ea234acf642c387e6495927abab4f()
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

      private sealed class MTHD_d211fabb2c534ae390ea8e00eaafb8fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d211fabb2c534ae390ea8e00eaafb8fd()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_2163d992fa6046f0b0726fc6c8f93e2d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2163d992fa6046f0b0726fc6c8f93e2d()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_da4cc06309c14095a7274e42d0f77ebd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_da4cc06309c14095a7274e42d0f77ebd()
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
