
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
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_a978b31c53a543e2ba21a8ddb9e77bbd());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_a5a0e324b5ab40aea79db9f6cbfbb816());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_e17cde0c6ce44b98949694754451ac11());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_5d22a95e2c7141b98ce8c39d93cdc2bb());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_05fedb75fd87449da28f81efe931ef73());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_f7dc59a35b0b4c6181317f823b5850bf());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_0c1177ad192d46bda19dddc92b469a06());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_0030ba8836eb4b8d8b22c18a3e1f6c7e());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_4225a3a0f14948c7953d5fd88feba5c5());
    }

    private sealed class TYPE_31b27837d4d74edebffdeed54631f888 : HardwiredUserDataDescriptor
    {
      internal TYPE_31b27837d4d74edebffdeed54631f888()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_41703327c6a54687ac4f62331b9667a2()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_aa5350b7a69c4709a2ed871d23898b0c()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_629ed6f733c949f09c0e47a477761f7d()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_9b2f0f5d2122447dbd2093559ce348bb()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_9c5cab87d0e2468bb330d7cd31cf6733()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_ce8b51112c584aef97967bc2b13081a7()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_0510daca37ab40e2b23639e5af619d27()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_83cace0f1b134fce98c1994fc90451d9()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_24110132516a4ae683e4f3a82b6852b7()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_e24ebba27fa443dd8a6bf2146d24dae7()
        }));
        this.AddMember("hideInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("hideInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_84ffd5782a854ff1ba194b4893100fef()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_3c7067d3c52c48f4b9bed802a2ed92d5()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_b06900fe7fb64d8bba851f212ad52bd4()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_02bef2c62f034f0d82ba7e793bd5d581()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_f51cdedc4a7f4480b9eebc670c81c8bd()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_a5255bae813e4cd0824f497490966cdc()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_a3f196819c0e4dadb98379a24c82c2a5()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_ebd088f095324544a0b37494db57fe8d()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_48d5acf6752b450dbde960d9b768e1ca()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_7a7a873bdab7462ebac702f9cbf776c0()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_ceb2158bd2fd4761a4dc6dbdbc94be73()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_3cbbf8773eec4bd3896ccf3220021841()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_655067ddf3ef4c478b339214163de89b()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_e889b35949a24e6ca525deb4f14d9dab()
        }));
        this.AddMember("get_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_b3417813403547e8a4dd9eff1d242661()
        }));
        this.AddMember("set_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_5e888be8a9ad47ae966fdde5d910030d()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_b73fa00a9532400384302fd49b6e16bb()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_2070fce8be2a417a9caab356f0015044()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_174c7a85a6c84bde9e38e7edadadf7d9()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_74fba13779d042fe983a28706a93ef9a()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_e2cd731babca465f84b5bf988741cb68()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_72c7c2fb1262431fb1a613f19674accf()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_81b5175ecdad471aa454e53524885fac()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_1a015714078148f4825e5061175b2417()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_a7a86592b82d421cbf88f34a43b9cc9e()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_1259fe591d2c4fa0b5cab6e999754d7b()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_9a9278e7401d4de2aad162bef7559771()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_b9ec11fa56e44e40a5cf29185c962642()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_6a1e5d776ab943bbb15cbc03cdd7d064()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_b221b0b9c0ab4bbbb91e13d302d90a4b()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_9d18a5ca80ce4fb48bbf3f53935d19e2()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_348432dc132c47eeb298090241803695()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_c2b3b41201af4c76bcafffe6d83a47cf()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_ad30bd9ccb764fa28e64c0aaa41804a0()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_b33d29340d7f4fe5b8fc6e17d37e038a()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_c66318692e9548539ad09e4133271580()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_0a66b68f3d4349178e31dbc88619f610()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_84cd0ef6c7b04cff96db22fb1c1838d7()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_ab57aef274544940b9be5e80832113f7()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_ee1cc8a35e6a45da81e599c29a2baa63()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_3a29cbf3b0f54ce09c1c16c23b2763d0()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_ca6e3bbdfa1c40468706a82c9f964954()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_f1aecb01b44645d6983003538fc35cf5()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_6e9ec28bf0f040feaf540277eb1a9052()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_2521684fa81241aaa8e1a683fa8536c5()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_6d030db06d9c418daa7d6dbec76f95e8()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_7dc3997e45604f94b48e074b511bddbd()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_6f2e7f9777eb40bdbd7c8798a5f1f72a()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_226ae5df0fe44bfc9753d62595b9d26d()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_c5a178b05534431786637ea8fbd245e2()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_075840d74ed64922b2f4fe91d7b00784()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_5d26c62897714a13ad1fe8c9d1a268a5()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_73edceeaaf7e4475851e82879908d041()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_7a9f143feb844657ad33370972fbf0e6()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_e0d4dc5e0b26456c83a9a93ffe46212b()
        }));
        this.AddMember("Dispose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Dispose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_9e38aa186aa046efa6dd8e337b33609d()
        }));
        this.AddMember("drawImage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawImage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_9155493e12854778a79bf077d8b72efa()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_11f76b7a647344788449230a439d377c()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_6be53f4a72ea4c1d80f7db505e81a6fa()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_d332874a4051465d9655291ec2f02757()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_556c6767adb245b29bc1692616d941f3()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_d70ef80c2aef45ad98098c518b459139()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_64654ed728914e7ba1b2ee2fb1680df5()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_638a769a784749b7b5b6231d76f0f87d()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_7a4782c228bc4fc496f9a11bba296589()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_b48a2eafeecf43de8838e6a30fdf20c0()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_56518e44bbb04d5e8e91c3d1fd33d2a8()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_c280792cad64495081ba6044ae7077af()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_9f1732a6938d44e38635efdb25fdd820()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_21fdeff1ee05435f95374d7321de9d31()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_a7d85774263340f9acd027d5f437c1a8()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_f97b7b84be144cce87e3acee57dfed19()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_04a83b05623f436a96b01f423d848884()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_77edc4a38cf742d5b1c6bdbb6b0a65ff()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_22e0380288374073b50bcf6cbe3233b2()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_658154fa7b0e4e1db60be9464ea27845()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_fa7a8915ac9e40a493864790d6064da0()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_8fa3e9ee2e6c4db68756e48ddda06f57()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_1a1fe846840f4eec9a328116f47b615d()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_4be5fe7723c04371bc5a5264531b3ba4()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_b258871ed2e24e7eb6d0977c255429b4()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_9e4b95c70dd24dc9bc89011a8d7fedce()
        }));
        this.AddMember("cameraFollow", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("cameraFollow", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_02e563d50e2c407db0f0d7d224a28e23()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_5afb90e7bf9b42c7ab0d656f494f762d()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_8a66d10f4d9b47cb95915dc5bcf440f9()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_e66cd8c76b0746ab8891c6f57d9cb701()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_2ec6196da8604c81b96bcb9d7a8ebe4e()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_ff3a9e901b334108afc0146fdbf2b516()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_8dde08d1642a47b89dc59d6a9974323f(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_fe4d570f65644dd09d40bde48072fc7f()
        }));
        this.AddMember("getKeyBinds", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getKeyBinds", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_dfc639b981b54d9994b676568dfe6b09()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_171315a7c7c64c37bfc76ba2ef188f45()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_5522372adcff427a89b0755cbc482de3()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_70be2288970c4535b71ac9c8fbad8a05()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.MTHD_a5ffe0bc8fcf4702a788ca0381323b0c()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_202683f4d5854fac8eadd2af63a68dac());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_98aa3c464bc54c739ca3dd705abd72c7());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_c008d25452ba4ebd86359a04df217684());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_8a2726091a954c6c9345b171e3e62629());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_2e6b15cbe44e4b43bc21e37eaa1a4c18());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_d1acad1d2135484b883b707ebcab4ac9());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_977c349482a24dc486978f253700c189());
        this.AddMember("allowMinionMovement", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_5ab72cf486684083b40fe13e9a26df91());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_89c0450c3a2e409fb6fe93c5948e741e());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_56123123820e4da584f197813594c823());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_aa59d8aba2ab42699b2b6902dd4b106e());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_282f1321ce094ffbb3c43fd473bd7697());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_965f4bc883014456bc67456434670ef9());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_b39802a8475b42bf8a902c2d0d2bc58e());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_3012b60c1992468daf01237b7c06c12c());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_bf1fefe364e6461b80664e71bbe51f63());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_a95ad6fb0b9b409aacd124487c105111());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_22d4646841be436d879c0d9014d77113());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_74853461eded49e891f0e0b22369e53c());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_75b416d65c334a048edd6fb712f6e415());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_248656beef7b48d081fc4d9df656077a());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_d7d497e4b9e04091b2b1c578dc8bd249());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_f5fecf3accdc4e94b0ca98264e050c9f());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_ab9499e2ada8414ba607d07864060aa9());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_ae1868cc1d174841a58ed6c6be81219f());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_b5dd5fda18424d57a6eb797aa7317f9d());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_6384fbc9559348ec80feef164092a867());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_254964be6318422cbf5074d1c58fd20a());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_68e024feb02c4bfeafb9fdb3139194fa());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_55d12f9c353d4ab19a379746d9eb17b9());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_ebe6b90e69524081af52815bca13f6b5());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_75acfb79ab2a417dafd98b58a3c422d7());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_31b27837d4d74edebffdeed54631f888.PROP_5a41024b9de24cc98dbff3ddc51b3fec());
      }

      private sealed class MTHD_41703327c6a54687ac4f62331b9667a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41703327c6a54687ac4f62331b9667a2()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_aa5350b7a69c4709a2ed871d23898b0c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa5350b7a69c4709a2ed871d23898b0c()
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

      private sealed class MTHD_629ed6f733c949f09c0e47a477761f7d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_629ed6f733c949f09c0e47a477761f7d()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_9b2f0f5d2122447dbd2093559ce348bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b2f0f5d2122447dbd2093559ce348bb()
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

      private sealed class MTHD_9c5cab87d0e2468bb330d7cd31cf6733 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c5cab87d0e2468bb330d7cd31cf6733()
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

      private sealed class MTHD_ce8b51112c584aef97967bc2b13081a7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ce8b51112c584aef97967bc2b13081a7()
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

      private sealed class MTHD_0510daca37ab40e2b23639e5af619d27 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0510daca37ab40e2b23639e5af619d27()
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

      private sealed class MTHD_83cace0f1b134fce98c1994fc90451d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_83cace0f1b134fce98c1994fc90451d9()
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

      private sealed class MTHD_24110132516a4ae683e4f3a82b6852b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24110132516a4ae683e4f3a82b6852b7()
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

      private sealed class MTHD_e24ebba27fa443dd8a6bf2146d24dae7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e24ebba27fa443dd8a6bf2146d24dae7()
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

      private sealed class MTHD_84ffd5782a854ff1ba194b4893100fef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84ffd5782a854ff1ba194b4893100fef()
        {
          this.Initialize("hideInfo", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).hideInfo();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_3c7067d3c52c48f4b9bed802a2ed92d5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3c7067d3c52c48f4b9bed802a2ed92d5()
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

      private sealed class MTHD_b06900fe7fb64d8bba851f212ad52bd4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b06900fe7fb64d8bba851f212ad52bd4()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_02bef2c62f034f0d82ba7e793bd5d581 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_02bef2c62f034f0d82ba7e793bd5d581()
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

      private sealed class MTHD_f51cdedc4a7f4480b9eebc670c81c8bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f51cdedc4a7f4480b9eebc670c81c8bd()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_a5255bae813e4cd0824f497490966cdc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a5255bae813e4cd0824f497490966cdc()
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

      private sealed class MTHD_a3f196819c0e4dadb98379a24c82c2a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a3f196819c0e4dadb98379a24c82c2a5()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_ebd088f095324544a0b37494db57fe8d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ebd088f095324544a0b37494db57fe8d()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_48d5acf6752b450dbde960d9b768e1ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_48d5acf6752b450dbde960d9b768e1ca()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_7a7a873bdab7462ebac702f9cbf776c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a7a873bdab7462ebac702f9cbf776c0()
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

      private sealed class MTHD_ceb2158bd2fd4761a4dc6dbdbc94be73 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ceb2158bd2fd4761a4dc6dbdbc94be73()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_3cbbf8773eec4bd3896ccf3220021841 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3cbbf8773eec4bd3896ccf3220021841()
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

      private sealed class MTHD_655067ddf3ef4c478b339214163de89b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_655067ddf3ef4c478b339214163de89b()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_e889b35949a24e6ca525deb4f14d9dab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e889b35949a24e6ca525deb4f14d9dab()
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

      private sealed class MTHD_b3417813403547e8a4dd9eff1d242661 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b3417813403547e8a4dd9eff1d242661()
        {
          this.Initialize("get_allowMinionMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMinionMovement;
        }
      }

      private sealed class MTHD_5e888be8a9ad47ae966fdde5d910030d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e888be8a9ad47ae966fdde5d910030d()
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

      private sealed class MTHD_b73fa00a9532400384302fd49b6e16bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b73fa00a9532400384302fd49b6e16bb()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_2070fce8be2a417a9caab356f0015044 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2070fce8be2a417a9caab356f0015044()
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

      private sealed class MTHD_174c7a85a6c84bde9e38e7edadadf7d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_174c7a85a6c84bde9e38e7edadadf7d9()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_74fba13779d042fe983a28706a93ef9a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74fba13779d042fe983a28706a93ef9a()
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

      private sealed class MTHD_e2cd731babca465f84b5bf988741cb68 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e2cd731babca465f84b5bf988741cb68()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_72c7c2fb1262431fb1a613f19674accf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_72c7c2fb1262431fb1a613f19674accf()
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

      private sealed class MTHD_81b5175ecdad471aa454e53524885fac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_81b5175ecdad471aa454e53524885fac()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_1a015714078148f4825e5061175b2417 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a015714078148f4825e5061175b2417()
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

      private sealed class MTHD_a7a86592b82d421cbf88f34a43b9cc9e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a7a86592b82d421cbf88f34a43b9cc9e()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_1259fe591d2c4fa0b5cab6e999754d7b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1259fe591d2c4fa0b5cab6e999754d7b()
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

      private sealed class MTHD_9a9278e7401d4de2aad162bef7559771 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9a9278e7401d4de2aad162bef7559771()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_b9ec11fa56e44e40a5cf29185c962642 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b9ec11fa56e44e40a5cf29185c962642()
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

      private sealed class MTHD_6a1e5d776ab943bbb15cbc03cdd7d064 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6a1e5d776ab943bbb15cbc03cdd7d064()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_b221b0b9c0ab4bbbb91e13d302d90a4b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b221b0b9c0ab4bbbb91e13d302d90a4b()
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

      private sealed class MTHD_9d18a5ca80ce4fb48bbf3f53935d19e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d18a5ca80ce4fb48bbf3f53935d19e2()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_348432dc132c47eeb298090241803695 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_348432dc132c47eeb298090241803695()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_c2b3b41201af4c76bcafffe6d83a47cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c2b3b41201af4c76bcafffe6d83a47cf()
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

      private sealed class MTHD_ad30bd9ccb764fa28e64c0aaa41804a0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ad30bd9ccb764fa28e64c0aaa41804a0()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_b33d29340d7f4fe5b8fc6e17d37e038a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b33d29340d7f4fe5b8fc6e17d37e038a()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_c66318692e9548539ad09e4133271580 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c66318692e9548539ad09e4133271580()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_0a66b68f3d4349178e31dbc88619f610 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0a66b68f3d4349178e31dbc88619f610()
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

      private sealed class MTHD_84cd0ef6c7b04cff96db22fb1c1838d7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84cd0ef6c7b04cff96db22fb1c1838d7()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_ab57aef274544940b9be5e80832113f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab57aef274544940b9be5e80832113f7()
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

      private sealed class MTHD_ee1cc8a35e6a45da81e599c29a2baa63 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee1cc8a35e6a45da81e599c29a2baa63()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_3a29cbf3b0f54ce09c1c16c23b2763d0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3a29cbf3b0f54ce09c1c16c23b2763d0()
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

      private sealed class MTHD_ca6e3bbdfa1c40468706a82c9f964954 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ca6e3bbdfa1c40468706a82c9f964954()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_f1aecb01b44645d6983003538fc35cf5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f1aecb01b44645d6983003538fc35cf5()
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

      private sealed class MTHD_6e9ec28bf0f040feaf540277eb1a9052 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e9ec28bf0f040feaf540277eb1a9052()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_2521684fa81241aaa8e1a683fa8536c5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2521684fa81241aaa8e1a683fa8536c5()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_6d030db06d9c418daa7d6dbec76f95e8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d030db06d9c418daa7d6dbec76f95e8()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_7dc3997e45604f94b48e074b511bddbd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7dc3997e45604f94b48e074b511bddbd()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_6f2e7f9777eb40bdbd7c8798a5f1f72a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6f2e7f9777eb40bdbd7c8798a5f1f72a()
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

      private sealed class MTHD_226ae5df0fe44bfc9753d62595b9d26d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_226ae5df0fe44bfc9753d62595b9d26d()
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

      private sealed class MTHD_c5a178b05534431786637ea8fbd245e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c5a178b05534431786637ea8fbd245e2()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_075840d74ed64922b2f4fe91d7b00784 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_075840d74ed64922b2f4fe91d7b00784()
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

      private sealed class MTHD_5d26c62897714a13ad1fe8c9d1a268a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d26c62897714a13ad1fe8c9d1a268a5()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_73edceeaaf7e4475851e82879908d041 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_73edceeaaf7e4475851e82879908d041()
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

      private sealed class MTHD_7a9f143feb844657ad33370972fbf0e6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a9f143feb844657ad33370972fbf0e6()
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

      private sealed class MTHD_e0d4dc5e0b26456c83a9a93ffe46212b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e0d4dc5e0b26456c83a9a93ffe46212b()
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

      private sealed class MTHD_9e38aa186aa046efa6dd8e337b33609d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e38aa186aa046efa6dd8e337b33609d()
        {
          this.Initialize("Dispose", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ContainerGame.Dispose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9155493e12854778a79bf077d8b72efa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9155493e12854778a79bf077d8b72efa()
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

      private sealed class MTHD_11f76b7a647344788449230a439d377c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_11f76b7a647344788449230a439d377c()
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

      private sealed class MTHD_6be53f4a72ea4c1d80f7db505e81a6fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6be53f4a72ea4c1d80f7db505e81a6fa()
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

      private sealed class MTHD_d332874a4051465d9655291ec2f02757 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d332874a4051465d9655291ec2f02757()
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

      private sealed class MTHD_556c6767adb245b29bc1692616d941f3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_556c6767adb245b29bc1692616d941f3()
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

      private sealed class MTHD_d70ef80c2aef45ad98098c518b459139 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d70ef80c2aef45ad98098c518b459139()
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

      private sealed class MTHD_64654ed728914e7ba1b2ee2fb1680df5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_64654ed728914e7ba1b2ee2fb1680df5()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_638a769a784749b7b5b6231d76f0f87d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_638a769a784749b7b5b6231d76f0f87d()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_7a4782c228bc4fc496f9a11bba296589 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a4782c228bc4fc496f9a11bba296589()
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

      private sealed class MTHD_b48a2eafeecf43de8838e6a30fdf20c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b48a2eafeecf43de8838e6a30fdf20c0()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_56518e44bbb04d5e8e91c3d1fd33d2a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_56518e44bbb04d5e8e91c3d1fd33d2a8()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c280792cad64495081ba6044ae7077af : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c280792cad64495081ba6044ae7077af()
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

      private sealed class MTHD_9f1732a6938d44e38635efdb25fdd820 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f1732a6938d44e38635efdb25fdd820()
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

      private sealed class MTHD_21fdeff1ee05435f95374d7321de9d31 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_21fdeff1ee05435f95374d7321de9d31()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_a7d85774263340f9acd027d5f437c1a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a7d85774263340f9acd027d5f437c1a8()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f97b7b84be144cce87e3acee57dfed19 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f97b7b84be144cce87e3acee57dfed19()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_04a83b05623f436a96b01f423d848884 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_04a83b05623f436a96b01f423d848884()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_77edc4a38cf742d5b1c6bdbb6b0a65ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_77edc4a38cf742d5b1c6bdbb6b0a65ff()
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

      private sealed class MTHD_22e0380288374073b50bcf6cbe3233b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22e0380288374073b50bcf6cbe3233b2()
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

      private sealed class MTHD_658154fa7b0e4e1db60be9464ea27845 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_658154fa7b0e4e1db60be9464ea27845()
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

      private sealed class MTHD_fa7a8915ac9e40a493864790d6064da0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa7a8915ac9e40a493864790d6064da0()
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

      private sealed class MTHD_8fa3e9ee2e6c4db68756e48ddda06f57 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8fa3e9ee2e6c4db68756e48ddda06f57()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_1a1fe846840f4eec9a328116f47b615d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a1fe846840f4eec9a328116f47b615d()
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

      private sealed class MTHD_4be5fe7723c04371bc5a5264531b3ba4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4be5fe7723c04371bc5a5264531b3ba4()
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

      private sealed class MTHD_b258871ed2e24e7eb6d0977c255429b4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b258871ed2e24e7eb6d0977c255429b4()
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

      private sealed class MTHD_9e4b95c70dd24dc9bc89011a8d7fedce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e4b95c70dd24dc9bc89011a8d7fedce()
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

      private sealed class MTHD_02e563d50e2c407db0f0d7d224a28e23 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_02e563d50e2c407db0f0d7d224a28e23()
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

      private sealed class MTHD_5afb90e7bf9b42c7ab0d656f494f762d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5afb90e7bf9b42c7ab0d656f494f762d()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_8a66d10f4d9b47cb95915dc5bcf440f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a66d10f4d9b47cb95915dc5bcf440f9()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_e66cd8c76b0746ab8891c6f57d9cb701 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e66cd8c76b0746ab8891c6f57d9cb701()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_2ec6196da8604c81b96bcb9d7a8ebe4e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2ec6196da8604c81b96bcb9d7a8ebe4e()
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

      private sealed class MTHD_ff3a9e901b334108afc0146fdbf2b516 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff3a9e901b334108afc0146fdbf2b516()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_8dde08d1642a47b89dc59d6a9974323f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8dde08d1642a47b89dc59d6a9974323f()
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

      private sealed class MTHD_fe4d570f65644dd09d40bde48072fc7f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fe4d570f65644dd09d40bde48072fc7f()
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

      private sealed class MTHD_dfc639b981b54d9994b676568dfe6b09 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dfc639b981b54d9994b676568dfe6b09()
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

      private sealed class MTHD_171315a7c7c64c37bfc76ba2ef188f45 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_171315a7c7c64c37bfc76ba2ef188f45()
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

      private sealed class MTHD_5522372adcff427a89b0755cbc482de3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5522372adcff427a89b0755cbc482de3()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_70be2288970c4535b71ac9c8fbad8a05 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70be2288970c4535b71ac9c8fbad8a05()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_a5ffe0bc8fcf4702a788ca0381323b0c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a5ffe0bc8fcf4702a788ca0381323b0c()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_202683f4d5854fac8eadd2af63a68dac : HardwiredMemberDescriptor
      {
        internal PROP_202683f4d5854fac8eadd2af63a68dac()
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

      private sealed class PROP_98aa3c464bc54c739ca3dd705abd72c7 : HardwiredMemberDescriptor
      {
        internal PROP_98aa3c464bc54c739ca3dd705abd72c7()
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

      private sealed class PROP_c008d25452ba4ebd86359a04df217684 : HardwiredMemberDescriptor
      {
        internal PROP_c008d25452ba4ebd86359a04df217684()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_8a2726091a954c6c9345b171e3e62629 : HardwiredMemberDescriptor
      {
        internal PROP_8a2726091a954c6c9345b171e3e62629()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_2e6b15cbe44e4b43bc21e37eaa1a4c18 : HardwiredMemberDescriptor
      {
        internal PROP_2e6b15cbe44e4b43bc21e37eaa1a4c18()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_d1acad1d2135484b883b707ebcab4ac9 : HardwiredMemberDescriptor
      {
        internal PROP_d1acad1d2135484b883b707ebcab4ac9()
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

      private sealed class PROP_977c349482a24dc486978f253700c189 : HardwiredMemberDescriptor
      {
        internal PROP_977c349482a24dc486978f253700c189()
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

      private sealed class PROP_5ab72cf486684083b40fe13e9a26df91 : HardwiredMemberDescriptor
      {
        internal PROP_5ab72cf486684083b40fe13e9a26df91()
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

      private sealed class PROP_89c0450c3a2e409fb6fe93c5948e741e : HardwiredMemberDescriptor
      {
        internal PROP_89c0450c3a2e409fb6fe93c5948e741e()
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

      private sealed class PROP_56123123820e4da584f197813594c823 : HardwiredMemberDescriptor
      {
        internal PROP_56123123820e4da584f197813594c823()
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

      private sealed class PROP_aa59d8aba2ab42699b2b6902dd4b106e : HardwiredMemberDescriptor
      {
        internal PROP_aa59d8aba2ab42699b2b6902dd4b106e()
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

      private sealed class PROP_282f1321ce094ffbb3c43fd473bd7697 : HardwiredMemberDescriptor
      {
        internal PROP_282f1321ce094ffbb3c43fd473bd7697()
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

      private sealed class PROP_965f4bc883014456bc67456434670ef9 : HardwiredMemberDescriptor
      {
        internal PROP_965f4bc883014456bc67456434670ef9()
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

      private sealed class PROP_b39802a8475b42bf8a902c2d0d2bc58e : HardwiredMemberDescriptor
      {
        internal PROP_b39802a8475b42bf8a902c2d0d2bc58e()
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

      private sealed class PROP_3012b60c1992468daf01237b7c06c12c : HardwiredMemberDescriptor
      {
        internal PROP_3012b60c1992468daf01237b7c06c12c()
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

      private sealed class PROP_bf1fefe364e6461b80664e71bbe51f63 : HardwiredMemberDescriptor
      {
        internal PROP_bf1fefe364e6461b80664e71bbe51f63()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_a95ad6fb0b9b409aacd124487c105111 : HardwiredMemberDescriptor
      {
        internal PROP_a95ad6fb0b9b409aacd124487c105111()
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

      private sealed class PROP_22d4646841be436d879c0d9014d77113 : HardwiredMemberDescriptor
      {
        internal PROP_22d4646841be436d879c0d9014d77113()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_74853461eded49e891f0e0b22369e53c : HardwiredMemberDescriptor
      {
        internal PROP_74853461eded49e891f0e0b22369e53c()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_75b416d65c334a048edd6fb712f6e415 : HardwiredMemberDescriptor
      {
        internal PROP_75b416d65c334a048edd6fb712f6e415()
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

      private sealed class PROP_248656beef7b48d081fc4d9df656077a : HardwiredMemberDescriptor
      {
        internal PROP_248656beef7b48d081fc4d9df656077a()
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

      private sealed class PROP_d7d497e4b9e04091b2b1c578dc8bd249 : HardwiredMemberDescriptor
      {
        internal PROP_d7d497e4b9e04091b2b1c578dc8bd249()
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

      private sealed class PROP_f5fecf3accdc4e94b0ca98264e050c9f : HardwiredMemberDescriptor
      {
        internal PROP_f5fecf3accdc4e94b0ca98264e050c9f()
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

      private sealed class PROP_ab9499e2ada8414ba607d07864060aa9 : HardwiredMemberDescriptor
      {
        internal PROP_ab9499e2ada8414ba607d07864060aa9()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_ae1868cc1d174841a58ed6c6be81219f : HardwiredMemberDescriptor
      {
        internal PROP_ae1868cc1d174841a58ed6c6be81219f()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_b5dd5fda18424d57a6eb797aa7317f9d : HardwiredMemberDescriptor
      {
        internal PROP_b5dd5fda18424d57a6eb797aa7317f9d()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_6384fbc9559348ec80feef164092a867 : HardwiredMemberDescriptor
      {
        internal PROP_6384fbc9559348ec80feef164092a867()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_254964be6318422cbf5074d1c58fd20a : HardwiredMemberDescriptor
      {
        internal PROP_254964be6318422cbf5074d1c58fd20a()
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

      private sealed class PROP_68e024feb02c4bfeafb9fdb3139194fa : HardwiredMemberDescriptor
      {
        internal PROP_68e024feb02c4bfeafb9fdb3139194fa()
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

      private sealed class PROP_55d12f9c353d4ab19a379746d9eb17b9 : HardwiredMemberDescriptor
      {
        internal PROP_55d12f9c353d4ab19a379746d9eb17b9()
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

      private sealed class PROP_ebe6b90e69524081af52815bca13f6b5 : HardwiredMemberDescriptor
      {
        internal PROP_ebe6b90e69524081af52815bca13f6b5()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_75acfb79ab2a417dafd98b58a3c422d7 : HardwiredMemberDescriptor
      {
        internal PROP_75acfb79ab2a417dafd98b58a3c422d7()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_5a41024b9de24cc98dbff3ddc51b3fec : HardwiredMemberDescriptor
      {
        internal PROP_5a41024b9de24cc98dbff3ddc51b3fec()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_a978b31c53a543e2ba21a8ddb9e77bbd : HardwiredUserDataDescriptor
    {
      internal TYPE_a978b31c53a543e2ba21a8ddb9e77bbd()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a978b31c53a543e2ba21a8ddb9e77bbd.MTHD_9d35b07a73b045b1851e6e4c0573cf19()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a978b31c53a543e2ba21a8ddb9e77bbd.MTHD_6e0333fbab0348e291aa77ee6e062a4a()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a978b31c53a543e2ba21a8ddb9e77bbd.MTHD_7ae3f5214698479683aefea20490ff6d()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a978b31c53a543e2ba21a8ddb9e77bbd.MTHD_601b20ad3212410a9763d5117b8bb37c()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a978b31c53a543e2ba21a8ddb9e77bbd.MTHD_e87fba6bc78645f29a778ad051f8f772()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a978b31c53a543e2ba21a8ddb9e77bbd.MTHD_de25e4b30ee2457da1764156b7b2247a()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a978b31c53a543e2ba21a8ddb9e77bbd.MTHD_4b5bfba12aa048cfb9509cf68f945c9a()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a978b31c53a543e2ba21a8ddb9e77bbd.MTHD_bbf5201ea15b492185a4acf42b74ee1b()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a978b31c53a543e2ba21a8ddb9e77bbd.MTHD_175cb02c9c324226a86eea5dbcfce11d()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a978b31c53a543e2ba21a8ddb9e77bbd.MTHD_d42c699114754a9f8186e427d9057527()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a978b31c53a543e2ba21a8ddb9e77bbd.MTHD_1336ec1d79d8431381b1b94ba3a3b986()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a978b31c53a543e2ba21a8ddb9e77bbd.MTHD_8bfa079844fb45ad82bc7fe9c3349c80()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_a978b31c53a543e2ba21a8ddb9e77bbd.PROP_73128e2ddd9145b788751bbdc664a23a());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_a978b31c53a543e2ba21a8ddb9e77bbd.PROP_f53fcd88fa1d47638a6a4833ba791513());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_a978b31c53a543e2ba21a8ddb9e77bbd.PROP_60ecbfbe05cf4202bed5e906310e5fc2());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_a978b31c53a543e2ba21a8ddb9e77bbd.PROP_0209b6e0be7b43098f3ba83e49c7ef6d());
      }

      private sealed class MTHD_9d35b07a73b045b1851e6e4c0573cf19 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d35b07a73b045b1851e6e4c0573cf19()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_6e0333fbab0348e291aa77ee6e062a4a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e0333fbab0348e291aa77ee6e062a4a()
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

      private sealed class MTHD_7ae3f5214698479683aefea20490ff6d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ae3f5214698479683aefea20490ff6d()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_601b20ad3212410a9763d5117b8bb37c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_601b20ad3212410a9763d5117b8bb37c()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_e87fba6bc78645f29a778ad051f8f772 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e87fba6bc78645f29a778ad051f8f772()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_de25e4b30ee2457da1764156b7b2247a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de25e4b30ee2457da1764156b7b2247a()
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

      private sealed class MTHD_4b5bfba12aa048cfb9509cf68f945c9a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b5bfba12aa048cfb9509cf68f945c9a()
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

      private sealed class MTHD_bbf5201ea15b492185a4acf42b74ee1b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bbf5201ea15b492185a4acf42b74ee1b()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_175cb02c9c324226a86eea5dbcfce11d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_175cb02c9c324226a86eea5dbcfce11d()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_d42c699114754a9f8186e427d9057527 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d42c699114754a9f8186e427d9057527()
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

      private sealed class MTHD_1336ec1d79d8431381b1b94ba3a3b986 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1336ec1d79d8431381b1b94ba3a3b986()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_8bfa079844fb45ad82bc7fe9c3349c80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8bfa079844fb45ad82bc7fe9c3349c80()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_73128e2ddd9145b788751bbdc664a23a : HardwiredMemberDescriptor
      {
        internal PROP_73128e2ddd9145b788751bbdc664a23a()
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

      private sealed class PROP_f53fcd88fa1d47638a6a4833ba791513 : HardwiredMemberDescriptor
      {
        internal PROP_f53fcd88fa1d47638a6a4833ba791513()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_60ecbfbe05cf4202bed5e906310e5fc2 : HardwiredMemberDescriptor
      {
        internal PROP_60ecbfbe05cf4202bed5e906310e5fc2()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_0209b6e0be7b43098f3ba83e49c7ef6d : HardwiredMemberDescriptor
      {
        internal PROP_0209b6e0be7b43098f3ba83e49c7ef6d()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_7d5b389104854e1ca98815ab163e29bf : HardwiredUserDataDescriptor
    {
      internal TYPE_7d5b389104854e1ca98815ab163e29bf()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_869caf8a0dce42eeb0a53fb99aaa4034()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_b6872ed2671246e0a69a385684f292ec()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_95155700fecc4c18aa968e16a406f4f2()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_9440a2dfb9844ad3bd0cbb4145a94da4()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_c8956f9d09d94e079c4f534763b8be04()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_09c744d421cc4df3a1923a395ce1dfe8()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_ea5f5a1f20b34693abdd9e7dc808b487()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_ae2397e31d7148b39db046b1f3a53b77()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_734329ece7724e7ca0e5c8cc05f5aa35()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_ceb11f79c86b42c2a0ed668a11407d06()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_3d13fc9d548044fea505f14fea591968()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_a126408aa7b54b1c9d81dcc2a75b5fff()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_f2326a0689b741fdabdb3ae004ee9c19()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_cb0fc6e8468e466dabbe5f4b49c534a5()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_978a081a0cea438ba9f51e5ff3ed54a0()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_30e8990735d84480a715f5cabc639b76()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_215decb4a09f45d7a70d2b268e4dd3b2()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_7821ad7f8a934e0a8d319633c439d46a()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_dad659eb581a44858aeb15981539cfdd()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_29c4e186199747fc8e386d9d91e58412()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_fb55245e3ddb4a17ae64cebccdee76e7()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_01823917baac41ad809b488ee1247524()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_39d4eff0a9334faebb3645df9ecbd24d()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_204ac587d1714a6bbc744ec43585e506()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_3737c82054d2441faa21f8092153bc77()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_977e096b25304d09ba791ed2d47348eb()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_cac5d8c9736c47c5b39ef909d3eec427()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_c6980d79b1524e81b01972c73ee38814()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_bf9f6935d8bd4408a4c5a89aceffbb7c()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_214915c8a48442a6a141c7304d5db7e2()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_5f2e077442d44b01a591bc5ad5beea07()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_21ece635f5fa4deb872b44418fbc7d23()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_1f7e72d602884949a6787fff15139acc()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_0d6a28d4e510486bb93537b78bee3f7b()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_8266307069544bf7bcf785cb0baf7abe()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_2bf417b5175b4183ae44440377b08f27()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_1af867c960d744beb59fb53c7362025f()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_3c7d55f67d7a47a8ba26cca7d0950e72()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_753372aae2eb471b949f29e3426e6946()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_25c1225d4c754154967f2ec997d2ba01()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_c68f362f495a48d683ee5f408303e53e()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_1a102991f0c442d4b3712995a0e1656a()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_874693d3474e44568fa6db7b88dbc9d7()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_f1fa365fd4704ad6a14ab50ed3582919()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_10b4ec5057694e908ea0706e0d1e6823()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_b6ecd70d4dd546e887df5de9c4d90cda()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_b8e94a2d95b344efbe96c4e46511e846()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_cb6b28a13848449a9a2347a01e6ec717()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_001408804c5341819f53e47419ddf3ac()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_de0fed9c220944af9a870ec408c39602()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_259efafa02664b859127de9b36446a9b()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_6c83bf4ffad34a6f8708b6085a52d2f9()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_8d3b0c2f07a5445ca04b88d5fcb459b9()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_445d6a3e6aa44d408925df1a414d37d0()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_542db34e09ba4743b0a8c1d6358937f6()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_73e8a115563742e68c1c063713e14cb8()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_d922ef2eed28401db53eb711dfb19e92()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_54031d7f7fc04832b15108967376fd50()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_7a5500abf97740129de27a072c718599()
        }));
        this.AddMember("getDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_561e6ecb27c34246bbbc61f67462a3ab()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_1d10e54a11ad451db49d00f108ef8578()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_95c53747d1ac4496bc8e2dcd551a3b92()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_fe221dbad9404e8499829861bc238306()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_34e4d4aa399c4dff90a286b759fd4621()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_abc7a10acb0543edbadeea9f8af44c22(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_edf444fcb2e14e7ebd4a94c90214cf19()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_a6ac09a8a0ab449a9b237651c841304c(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_b9aaa9377d424c8bb0f1e0e867040713()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_fca04b19f97640eaa66f1ba4b218bbbd()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_56a4193017ec481cbf2fa65552b89f73()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_a749ac0c8e034664bae1de99c78118d9(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_c5adfe35582a46e2bea3c6941218616a()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_15fb8d722b644803bf7393042f5b2efb()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_4a31a61f6a72411d85b8a4fbe9f54d80()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_dc8abd7d69144fe585ba4a1357438e2b()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_1a5040b59037474f998615cbaa4c012c()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_6ed3c37b26934020aad23a5bdfda6085()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_8f74c6ef43be4c0b9523416108174d1e()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_e60b2bff32954f429fc32fe0f5fe5f07()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_034ba74981d34601a79554dbaca63e18()
        }));
        this.AddMember("angleToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("angleToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_b9e7cf8c76264c608a09228b787ece93()
        }));
        this.AddMember("powerToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("powerToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_3bb9e97d7afa409494e5aab9eea0f2d5()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_67932b8c2b9f44eeb37cefbaee74b89f(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_4b0fb37b411a464e99b76826ba01d827()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_1544c85afcdd4db1a56fd9b106f70a85(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_257588117a764d4cbaa6725d7f40e9a9()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_5bce1d0ebb344642bd7e5c6fd68d1c4f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_9c5c2b38b0834b6db13ca55c790a7a4b()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_172b5711feaf4b129308b5e68054aa43()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_fa910268651e48ccadc515c8baaf3d29()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_342b1ae1cada4794ae10e7ae54c0d811()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.MTHD_d8ca336caf7646b7945f0197cb4bd55e()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_de69f0b146d14df5acae9931f7374263());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_ac5b9e8ca0704411be6125001a625a1b());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_2f4c30bf503d4fc78940af633865a32d());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_13185c6dd93d4dd1aabd91447e115a67());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_cff3bdaae64346c3a21096c0621d0d39());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_1dfd84938df04ef3b32c41bafba4d8c7());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_2d74e0640d3c44cdb424af3200c86767());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_677959e701b2449da3287d8e444bfc82());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_73ea30475e23418a9f3c0e0974769eb7());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_d6cd78bca3f04ebe9b94fcc683521cd0());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_f8dc20a5388849f3b1e10cb1f92c0af7());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_4b57278ec3ce4d6eb1710db68034db7e());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_e25ae0f8c76f4bf8bb5cc9f12fe9df05());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_199ae9311d7a4e209e6f46e1d0555e97());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_1701e740e74e4945b984746f41daf3af());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_cc9ece201d7d4086882fa739ddb1e2fc());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_502337fa124a4b13ad3321ee9ce16d0a());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_0aa80037d29347cbac100507ae8f311f());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_ef4b338c271f403d9bce17fab151cc43());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_7b6998190bca4da283fe1c8b4ae94b12());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_77063007e0f0403794835c043f111085());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_b3b593d800b24b15973e42874f2a4b48());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_08f1ed62e0f442c8bccd333ccc09510e());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_9d1d68bdcb53479fa58df21e445c524f());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_a933490bc28643c78f73dbd046f7ad2c());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_445e4be951dc45f999555298343c1af5());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_4d0eb641577b4b73be5f776259da498e());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_baca0ee1945f4c8997886ad42374e1a1());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_169256a5be954014bf0c948214d8a39f());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_7319c7ecca9143f1b9e993352cfc3d4f());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_895f4379266046ea87be7790d3e7e727());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_3098a249e98641db8086b39888b3c752());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_7d5b389104854e1ca98815ab163e29bf.PROP_72ebd60d90a04c7da8ea74bbe4e96abd());
      }

      private sealed class MTHD_869caf8a0dce42eeb0a53fb99aaa4034 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_869caf8a0dce42eeb0a53fb99aaa4034()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_b6872ed2671246e0a69a385684f292ec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b6872ed2671246e0a69a385684f292ec()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_95155700fecc4c18aa968e16a406f4f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95155700fecc4c18aa968e16a406f4f2()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_9440a2dfb9844ad3bd0cbb4145a94da4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9440a2dfb9844ad3bd0cbb4145a94da4()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_c8956f9d09d94e079c4f534763b8be04 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c8956f9d09d94e079c4f534763b8be04()
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

      private sealed class MTHD_09c744d421cc4df3a1923a395ce1dfe8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_09c744d421cc4df3a1923a395ce1dfe8()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_ea5f5a1f20b34693abdd9e7dc808b487 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea5f5a1f20b34693abdd9e7dc808b487()
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

      private sealed class MTHD_ae2397e31d7148b39db046b1f3a53b77 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae2397e31d7148b39db046b1f3a53b77()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_734329ece7724e7ca0e5c8cc05f5aa35 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_734329ece7724e7ca0e5c8cc05f5aa35()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_ceb11f79c86b42c2a0ed668a11407d06 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ceb11f79c86b42c2a0ed668a11407d06()
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

      private sealed class MTHD_3d13fc9d548044fea505f14fea591968 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d13fc9d548044fea505f14fea591968()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_a126408aa7b54b1c9d81dcc2a75b5fff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a126408aa7b54b1c9d81dcc2a75b5fff()
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

      private sealed class MTHD_f2326a0689b741fdabdb3ae004ee9c19 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f2326a0689b741fdabdb3ae004ee9c19()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_cb0fc6e8468e466dabbe5f4b49c534a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cb0fc6e8468e466dabbe5f4b49c534a5()
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

      private sealed class MTHD_978a081a0cea438ba9f51e5ff3ed54a0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_978a081a0cea438ba9f51e5ff3ed54a0()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_30e8990735d84480a715f5cabc639b76 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_30e8990735d84480a715f5cabc639b76()
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

      private sealed class MTHD_215decb4a09f45d7a70d2b268e4dd3b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_215decb4a09f45d7a70d2b268e4dd3b2()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_7821ad7f8a934e0a8d319633c439d46a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7821ad7f8a934e0a8d319633c439d46a()
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

      private sealed class MTHD_dad659eb581a44858aeb15981539cfdd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dad659eb581a44858aeb15981539cfdd()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_29c4e186199747fc8e386d9d91e58412 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_29c4e186199747fc8e386d9d91e58412()
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

      private sealed class MTHD_fb55245e3ddb4a17ae64cebccdee76e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb55245e3ddb4a17ae64cebccdee76e7()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_01823917baac41ad809b488ee1247524 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_01823917baac41ad809b488ee1247524()
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

      private sealed class MTHD_39d4eff0a9334faebb3645df9ecbd24d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_39d4eff0a9334faebb3645df9ecbd24d()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_204ac587d1714a6bbc744ec43585e506 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_204ac587d1714a6bbc744ec43585e506()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_3737c82054d2441faa21f8092153bc77 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3737c82054d2441faa21f8092153bc77()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_977e096b25304d09ba791ed2d47348eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_977e096b25304d09ba791ed2d47348eb()
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

      private sealed class MTHD_cac5d8c9736c47c5b39ef909d3eec427 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cac5d8c9736c47c5b39ef909d3eec427()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_c6980d79b1524e81b01972c73ee38814 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c6980d79b1524e81b01972c73ee38814()
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

      private sealed class MTHD_bf9f6935d8bd4408a4c5a89aceffbb7c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf9f6935d8bd4408a4c5a89aceffbb7c()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_214915c8a48442a6a141c7304d5db7e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_214915c8a48442a6a141c7304d5db7e2()
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

      private sealed class MTHD_5f2e077442d44b01a591bc5ad5beea07 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5f2e077442d44b01a591bc5ad5beea07()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_21ece635f5fa4deb872b44418fbc7d23 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_21ece635f5fa4deb872b44418fbc7d23()
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

      private sealed class MTHD_1f7e72d602884949a6787fff15139acc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f7e72d602884949a6787fff15139acc()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_0d6a28d4e510486bb93537b78bee3f7b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d6a28d4e510486bb93537b78bee3f7b()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_8266307069544bf7bcf785cb0baf7abe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8266307069544bf7bcf785cb0baf7abe()
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

      private sealed class MTHD_2bf417b5175b4183ae44440377b08f27 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2bf417b5175b4183ae44440377b08f27()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_1af867c960d744beb59fb53c7362025f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1af867c960d744beb59fb53c7362025f()
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

      private sealed class MTHD_3c7d55f67d7a47a8ba26cca7d0950e72 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3c7d55f67d7a47a8ba26cca7d0950e72()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_753372aae2eb471b949f29e3426e6946 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_753372aae2eb471b949f29e3426e6946()
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

      private sealed class MTHD_25c1225d4c754154967f2ec997d2ba01 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_25c1225d4c754154967f2ec997d2ba01()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_c68f362f495a48d683ee5f408303e53e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c68f362f495a48d683ee5f408303e53e()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_1a102991f0c442d4b3712995a0e1656a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a102991f0c442d4b3712995a0e1656a()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_874693d3474e44568fa6db7b88dbc9d7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_874693d3474e44568fa6db7b88dbc9d7()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_f1fa365fd4704ad6a14ab50ed3582919 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f1fa365fd4704ad6a14ab50ed3582919()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_10b4ec5057694e908ea0706e0d1e6823 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_10b4ec5057694e908ea0706e0d1e6823()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_b6ecd70d4dd546e887df5de9c4d90cda : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b6ecd70d4dd546e887df5de9c4d90cda()
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

      private sealed class MTHD_b8e94a2d95b344efbe96c4e46511e846 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b8e94a2d95b344efbe96c4e46511e846()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_cb6b28a13848449a9a2347a01e6ec717 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cb6b28a13848449a9a2347a01e6ec717()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_001408804c5341819f53e47419ddf3ac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_001408804c5341819f53e47419ddf3ac()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_de0fed9c220944af9a870ec408c39602 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de0fed9c220944af9a870ec408c39602()
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

      private sealed class MTHD_259efafa02664b859127de9b36446a9b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_259efafa02664b859127de9b36446a9b()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_6c83bf4ffad34a6f8708b6085a52d2f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6c83bf4ffad34a6f8708b6085a52d2f9()
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

      private sealed class MTHD_8d3b0c2f07a5445ca04b88d5fcb459b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8d3b0c2f07a5445ca04b88d5fcb459b9()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_445d6a3e6aa44d408925df1a414d37d0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_445d6a3e6aa44d408925df1a414d37d0()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_542db34e09ba4743b0a8c1d6358937f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_542db34e09ba4743b0a8c1d6358937f6()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_73e8a115563742e68c1c063713e14cb8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_73e8a115563742e68c1c063713e14cb8()
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

      private sealed class MTHD_d922ef2eed28401db53eb711dfb19e92 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d922ef2eed28401db53eb711dfb19e92()
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

      private sealed class MTHD_54031d7f7fc04832b15108967376fd50 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_54031d7f7fc04832b15108967376fd50()
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

      private sealed class MTHD_7a5500abf97740129de27a072c718599 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a5500abf97740129de27a072c718599()
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

      private sealed class MTHD_561e6ecb27c34246bbbc61f67462a3ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_561e6ecb27c34246bbbc61f67462a3ab()
        {
          this.Initialize("getDirection", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getDirection();
        }
      }

      private sealed class MTHD_1d10e54a11ad451db49d00f108ef8578 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d10e54a11ad451db49d00f108ef8578()
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

      private sealed class MTHD_95c53747d1ac4496bc8e2dcd551a3b92 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95c53747d1ac4496bc8e2dcd551a3b92()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_fe221dbad9404e8499829861bc238306 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fe221dbad9404e8499829861bc238306()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_34e4d4aa399c4dff90a286b759fd4621 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_34e4d4aa399c4dff90a286b759fd4621()
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

      private sealed class MTHD_abc7a10acb0543edbadeea9f8af44c22 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_abc7a10acb0543edbadeea9f8af44c22()
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

      private sealed class MTHD_edf444fcb2e14e7ebd4a94c90214cf19 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_edf444fcb2e14e7ebd4a94c90214cf19()
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

      private sealed class MTHD_a6ac09a8a0ab449a9b237651c841304c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6ac09a8a0ab449a9b237651c841304c()
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

      private sealed class MTHD_b9aaa9377d424c8bb0f1e0e867040713 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b9aaa9377d424c8bb0f1e0e867040713()
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

      private sealed class MTHD_fca04b19f97640eaa66f1ba4b218bbbd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fca04b19f97640eaa66f1ba4b218bbbd()
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

      private sealed class MTHD_56a4193017ec481cbf2fa65552b89f73 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_56a4193017ec481cbf2fa65552b89f73()
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

      private sealed class MTHD_a749ac0c8e034664bae1de99c78118d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a749ac0c8e034664bae1de99c78118d9()
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

      private sealed class MTHD_c5adfe35582a46e2bea3c6941218616a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c5adfe35582a46e2bea3c6941218616a()
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

      private sealed class MTHD_15fb8d722b644803bf7393042f5b2efb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15fb8d722b644803bf7393042f5b2efb()
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

      private sealed class MTHD_4a31a61f6a72411d85b8a4fbe9f54d80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a31a61f6a72411d85b8a4fbe9f54d80()
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

      private sealed class MTHD_dc8abd7d69144fe585ba4a1357438e2b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc8abd7d69144fe585ba4a1357438e2b()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_1a5040b59037474f998615cbaa4c012c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a5040b59037474f998615cbaa4c012c()
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

      private sealed class MTHD_6ed3c37b26934020aad23a5bdfda6085 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ed3c37b26934020aad23a5bdfda6085()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_8f74c6ef43be4c0b9523416108174d1e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8f74c6ef43be4c0b9523416108174d1e()
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

      private sealed class MTHD_e60b2bff32954f429fc32fe0f5fe5f07 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e60b2bff32954f429fc32fe0f5fe5f07()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_034ba74981d34601a79554dbaca63e18 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_034ba74981d34601a79554dbaca63e18()
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

      private sealed class MTHD_b9e7cf8c76264c608a09228b787ece93 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b9e7cf8c76264c608a09228b787ece93()
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

      private sealed class MTHD_3bb9e97d7afa409494e5aab9eea0f2d5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3bb9e97d7afa409494e5aab9eea0f2d5()
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

      private sealed class MTHD_67932b8c2b9f44eeb37cefbaee74b89f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67932b8c2b9f44eeb37cefbaee74b89f()
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

      private sealed class MTHD_4b0fb37b411a464e99b76826ba01d827 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b0fb37b411a464e99b76826ba01d827()
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

      private sealed class MTHD_1544c85afcdd4db1a56fd9b106f70a85 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1544c85afcdd4db1a56fd9b106f70a85()
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

      private sealed class MTHD_257588117a764d4cbaa6725d7f40e9a9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_257588117a764d4cbaa6725d7f40e9a9()
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

      private sealed class MTHD_5bce1d0ebb344642bd7e5c6fd68d1c4f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5bce1d0ebb344642bd7e5c6fd68d1c4f()
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

      private sealed class MTHD_9c5c2b38b0834b6db13ca55c790a7a4b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c5c2b38b0834b6db13ca55c790a7a4b()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_172b5711feaf4b129308b5e68054aa43 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_172b5711feaf4b129308b5e68054aa43()
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

      private sealed class MTHD_fa910268651e48ccadc515c8baaf3d29 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa910268651e48ccadc515c8baaf3d29()
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

      private sealed class MTHD_342b1ae1cada4794ae10e7ae54c0d811 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_342b1ae1cada4794ae10e7ae54c0d811()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_d8ca336caf7646b7945f0197cb4bd55e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8ca336caf7646b7945f0197cb4bd55e()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_de69f0b146d14df5acae9931f7374263 : HardwiredMemberDescriptor
      {
        internal PROP_de69f0b146d14df5acae9931f7374263()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_ac5b9e8ca0704411be6125001a625a1b : HardwiredMemberDescriptor
      {
        internal PROP_ac5b9e8ca0704411be6125001a625a1b()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_2f4c30bf503d4fc78940af633865a32d : HardwiredMemberDescriptor
      {
        internal PROP_2f4c30bf503d4fc78940af633865a32d()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_13185c6dd93d4dd1aabd91447e115a67 : HardwiredMemberDescriptor
      {
        internal PROP_13185c6dd93d4dd1aabd91447e115a67()
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

      private sealed class PROP_cff3bdaae64346c3a21096c0621d0d39 : HardwiredMemberDescriptor
      {
        internal PROP_cff3bdaae64346c3a21096c0621d0d39()
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

      private sealed class PROP_1dfd84938df04ef3b32c41bafba4d8c7 : HardwiredMemberDescriptor
      {
        internal PROP_1dfd84938df04ef3b32c41bafba4d8c7()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_2d74e0640d3c44cdb424af3200c86767 : HardwiredMemberDescriptor
      {
        internal PROP_2d74e0640d3c44cdb424af3200c86767()
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

      private sealed class PROP_677959e701b2449da3287d8e444bfc82 : HardwiredMemberDescriptor
      {
        internal PROP_677959e701b2449da3287d8e444bfc82()
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

      private sealed class PROP_73ea30475e23418a9f3c0e0974769eb7 : HardwiredMemberDescriptor
      {
        internal PROP_73ea30475e23418a9f3c0e0974769eb7()
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

      private sealed class PROP_d6cd78bca3f04ebe9b94fcc683521cd0 : HardwiredMemberDescriptor
      {
        internal PROP_d6cd78bca3f04ebe9b94fcc683521cd0()
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

      private sealed class PROP_f8dc20a5388849f3b1e10cb1f92c0af7 : HardwiredMemberDescriptor
      {
        internal PROP_f8dc20a5388849f3b1e10cb1f92c0af7()
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

      private sealed class PROP_4b57278ec3ce4d6eb1710db68034db7e : HardwiredMemberDescriptor
      {
        internal PROP_4b57278ec3ce4d6eb1710db68034db7e()
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

      private sealed class PROP_e25ae0f8c76f4bf8bb5cc9f12fe9df05 : HardwiredMemberDescriptor
      {
        internal PROP_e25ae0f8c76f4bf8bb5cc9f12fe9df05()
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

      private sealed class PROP_199ae9311d7a4e209e6f46e1d0555e97 : HardwiredMemberDescriptor
      {
        internal PROP_199ae9311d7a4e209e6f46e1d0555e97()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_1701e740e74e4945b984746f41daf3af : HardwiredMemberDescriptor
      {
        internal PROP_1701e740e74e4945b984746f41daf3af()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_cc9ece201d7d4086882fa739ddb1e2fc : HardwiredMemberDescriptor
      {
        internal PROP_cc9ece201d7d4086882fa739ddb1e2fc()
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

      private sealed class PROP_502337fa124a4b13ad3321ee9ce16d0a : HardwiredMemberDescriptor
      {
        internal PROP_502337fa124a4b13ad3321ee9ce16d0a()
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

      private sealed class PROP_0aa80037d29347cbac100507ae8f311f : HardwiredMemberDescriptor
      {
        internal PROP_0aa80037d29347cbac100507ae8f311f()
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

      private sealed class PROP_ef4b338c271f403d9bce17fab151cc43 : HardwiredMemberDescriptor
      {
        internal PROP_ef4b338c271f403d9bce17fab151cc43()
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

      private sealed class PROP_7b6998190bca4da283fe1c8b4ae94b12 : HardwiredMemberDescriptor
      {
        internal PROP_7b6998190bca4da283fe1c8b4ae94b12()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_77063007e0f0403794835c043f111085 : HardwiredMemberDescriptor
      {
        internal PROP_77063007e0f0403794835c043f111085()
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

      private sealed class PROP_b3b593d800b24b15973e42874f2a4b48 : HardwiredMemberDescriptor
      {
        internal PROP_b3b593d800b24b15973e42874f2a4b48()
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

      private sealed class PROP_08f1ed62e0f442c8bccd333ccc09510e : HardwiredMemberDescriptor
      {
        internal PROP_08f1ed62e0f442c8bccd333ccc09510e()
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

      private sealed class PROP_9d1d68bdcb53479fa58df21e445c524f : HardwiredMemberDescriptor
      {
        internal PROP_9d1d68bdcb53479fa58df21e445c524f()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_a933490bc28643c78f73dbd046f7ad2c : HardwiredMemberDescriptor
      {
        internal PROP_a933490bc28643c78f73dbd046f7ad2c()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_445e4be951dc45f999555298343c1af5 : HardwiredMemberDescriptor
      {
        internal PROP_445e4be951dc45f999555298343c1af5()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_4d0eb641577b4b73be5f776259da498e : HardwiredMemberDescriptor
      {
        internal PROP_4d0eb641577b4b73be5f776259da498e()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_baca0ee1945f4c8997886ad42374e1a1 : HardwiredMemberDescriptor
      {
        internal PROP_baca0ee1945f4c8997886ad42374e1a1()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_169256a5be954014bf0c948214d8a39f : HardwiredMemberDescriptor
      {
        internal PROP_169256a5be954014bf0c948214d8a39f()
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

      private sealed class PROP_7319c7ecca9143f1b9e993352cfc3d4f : HardwiredMemberDescriptor
      {
        internal PROP_7319c7ecca9143f1b9e993352cfc3d4f()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_895f4379266046ea87be7790d3e7e727 : HardwiredMemberDescriptor
      {
        internal PROP_895f4379266046ea87be7790d3e7e727()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_3098a249e98641db8086b39888b3c752 : HardwiredMemberDescriptor
      {
        internal PROP_3098a249e98641db8086b39888b3c752()
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

      private sealed class PROP_72ebd60d90a04c7da8ea74bbe4e96abd : HardwiredMemberDescriptor
      {
        internal PROP_72ebd60d90a04c7da8ea74bbe4e96abd()
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

    private sealed class TYPE_f25fadd15ac04813a8dba976a9cfd9db : HardwiredUserDataDescriptor
    {
      internal TYPE_f25fadd15ac04813a8dba976a9cfd9db()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.MTHD_57c883336f614ed7934adf0b0f48e7eb()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.MTHD_7bb6cce9057d46119a5fda094dd9cd44()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.MTHD_0d1c9dfba5e744598c1f4fea8b95da82()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.MTHD_de4a50c0ba004ad69c43382e73fc61d2()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.MTHD_8be5e3bc2b0a4479a7587f08797753bf()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.MTHD_9808138740bd424a971ec01f27388c2b()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.MTHD_4f71904809234c5d944dafb6b0884aee()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.MTHD_f994f846b4b14775a93672b99b637734()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.MTHD_83344fc60b3a4fda817531dc325d8ca9()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.MTHD_75ec5d9c6e9a4cb082b5e3fe30ef0b45()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.MTHD_5ed83af2bc064e1cb32fad0733c8d2b0()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.MTHD_99f76eb4f7874338942e6a026942460a()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.MTHD_3df01fe699144791ba669d3f364d2f43()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.MTHD_a19cc497666f44a1a9c43a414a5b296b()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.MTHD_2579f7a9cc3c46ba8566bad8d5b4f6f8()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.MTHD_b569fb5b07a14735935b03af853583f2()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.MTHD_75aa3c295b5b440ea5db4512c1019797()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.MTHD_71681bdfde6d41dbaf6498344a33ee81()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.MTHD_f33d05dcde374733a83066926cb23232()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.MTHD_5a455f43af3e4039bc3abd7d68721753()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.PROP_6c6bfd7d209448d794c21943fdc89b64());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.PROP_d01f1595390746d9af7806cc401ee1a3());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.PROP_7b534d877af34fb4aaf2f6a198fd6ddc());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.PROP_409dd02e2804429fb90f44269d0040e6());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.PROP_f2005b79d27c4692b8b2033d2ea93e2c());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.PROP_e091ccc07a0e4a9fa4aa8800646345fc());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.PROP_ebf6ef18f1964ede96af7d4887fe96f8());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_f25fadd15ac04813a8dba976a9cfd9db.PROP_f5d76dc06d9a4bf4adae99e352cfe804());
      }

      private sealed class MTHD_57c883336f614ed7934adf0b0f48e7eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57c883336f614ed7934adf0b0f48e7eb()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_7bb6cce9057d46119a5fda094dd9cd44 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7bb6cce9057d46119a5fda094dd9cd44()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_0d1c9dfba5e744598c1f4fea8b95da82 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d1c9dfba5e744598c1f4fea8b95da82()
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

      private sealed class MTHD_de4a50c0ba004ad69c43382e73fc61d2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de4a50c0ba004ad69c43382e73fc61d2()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_8be5e3bc2b0a4479a7587f08797753bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8be5e3bc2b0a4479a7587f08797753bf()
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

      private sealed class MTHD_9808138740bd424a971ec01f27388c2b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9808138740bd424a971ec01f27388c2b()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_4f71904809234c5d944dafb6b0884aee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4f71904809234c5d944dafb6b0884aee()
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

      private sealed class MTHD_f994f846b4b14775a93672b99b637734 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f994f846b4b14775a93672b99b637734()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_83344fc60b3a4fda817531dc325d8ca9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_83344fc60b3a4fda817531dc325d8ca9()
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

      private sealed class MTHD_75ec5d9c6e9a4cb082b5e3fe30ef0b45 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75ec5d9c6e9a4cb082b5e3fe30ef0b45()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_5ed83af2bc064e1cb32fad0733c8d2b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ed83af2bc064e1cb32fad0733c8d2b0()
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

      private sealed class MTHD_99f76eb4f7874338942e6a026942460a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99f76eb4f7874338942e6a026942460a()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_3df01fe699144791ba669d3f364d2f43 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3df01fe699144791ba669d3f364d2f43()
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

      private sealed class MTHD_a19cc497666f44a1a9c43a414a5b296b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a19cc497666f44a1a9c43a414a5b296b()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_2579f7a9cc3c46ba8566bad8d5b4f6f8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2579f7a9cc3c46ba8566bad8d5b4f6f8()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b569fb5b07a14735935b03af853583f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b569fb5b07a14735935b03af853583f2()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_75aa3c295b5b440ea5db4512c1019797 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75aa3c295b5b440ea5db4512c1019797()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_71681bdfde6d41dbaf6498344a33ee81 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_71681bdfde6d41dbaf6498344a33ee81()
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

      private sealed class MTHD_f33d05dcde374733a83066926cb23232 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f33d05dcde374733a83066926cb23232()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_5a455f43af3e4039bc3abd7d68721753 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5a455f43af3e4039bc3abd7d68721753()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_6c6bfd7d209448d794c21943fdc89b64 : HardwiredMemberDescriptor
      {
        internal PROP_6c6bfd7d209448d794c21943fdc89b64()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_d01f1595390746d9af7806cc401ee1a3 : HardwiredMemberDescriptor
      {
        internal PROP_d01f1595390746d9af7806cc401ee1a3()
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

      private sealed class PROP_7b534d877af34fb4aaf2f6a198fd6ddc : HardwiredMemberDescriptor
      {
        internal PROP_7b534d877af34fb4aaf2f6a198fd6ddc()
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

      private sealed class PROP_409dd02e2804429fb90f44269d0040e6 : HardwiredMemberDescriptor
      {
        internal PROP_409dd02e2804429fb90f44269d0040e6()
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

      private sealed class PROP_f2005b79d27c4692b8b2033d2ea93e2c : HardwiredMemberDescriptor
      {
        internal PROP_f2005b79d27c4692b8b2033d2ea93e2c()
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

      private sealed class PROP_e091ccc07a0e4a9fa4aa8800646345fc : HardwiredMemberDescriptor
      {
        internal PROP_e091ccc07a0e4a9fa4aa8800646345fc()
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

      private sealed class PROP_ebf6ef18f1964ede96af7d4887fe96f8 : HardwiredMemberDescriptor
      {
        internal PROP_ebf6ef18f1964ede96af7d4887fe96f8()
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

      private sealed class PROP_f5d76dc06d9a4bf4adae99e352cfe804 : HardwiredMemberDescriptor
      {
        internal PROP_f5d76dc06d9a4bf4adae99e352cfe804()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_53b05b9f8be54e978b11af8d1fc6ef00 : HardwiredUserDataDescriptor
    {
      internal TYPE_53b05b9f8be54e978b11af8d1fc6ef00()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.MTHD_b2ba0c77f6aa43adb210256ea7e9d165()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.MTHD_9d6e73379a1a473f928edc3a7914de98()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.MTHD_a06e425be256498795a0078d4668222b()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.MTHD_8b386985a6084b428759e55412df7ffd()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.MTHD_3b0609f51a1644fea32959cb07824dd6()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.MTHD_8a780e59de5049c2a547208b2377089e()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.MTHD_b428ab731eaa4399b54ee04fd36decb1()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.MTHD_5301c5925f1b4876bca76f730797c9df()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.MTHD_2fea111c457a47f0985ce5e853da1023()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.MTHD_c451825e266f486abaa8305bcd5cad89()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.MTHD_c63a9b9327d746b69865599d617f7e83()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.MTHD_09cb8bfff0d84190ba4c69c9a86d7119()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.MTHD_54335dc3f35e4bd39c95302670c4abaf()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.MTHD_442122978099406781732aea9a99a723()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.MTHD_6e783aa7db004c68a67b204125ab0e35()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.MTHD_c5235bdf7f4c4cc59c6dff282ce28d0f()
        }));
        this.AddMember("setIcon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setIcon", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.MTHD_eb79ceb121cc4cf79807431dbab88046()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.MTHD_2797aaacbe4f4cd2b235e3a72a85d6d7()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.MTHD_9535e6fcb4244094bc14226c847df23a()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.MTHD_a1a218a3515f41f0a1b8608c4b58fe3d()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.MTHD_8e21fde60149463d9819f4fdf2634f01()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.MTHD_0ebe5df0df5a4303a3cf258c72862787()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.PROP_3f4006df75d544e5a319725242657393());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.PROP_6ed415ba0abb4a22a91e9c4e4fd5d5fd());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.PROP_3f122a5d4ebf40fcb43a659ab87fa216());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.PROP_1782adc70e85464db1f98903fb0c19ce());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.PROP_71799671c9ff4befa1eacdcf8e046247());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.PROP_ce87d725fa2c460eb71454083e3a9dcf());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.PROP_d3855c61d78b40eab3a729a1d66c2882());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.PROP_43b2ff2e3ddf483ebc52c02365cb3756());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_53b05b9f8be54e978b11af8d1fc6ef00.PROP_531697cdaad145d895f10f0833d13edf());
      }

      private sealed class MTHD_b2ba0c77f6aa43adb210256ea7e9d165 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b2ba0c77f6aa43adb210256ea7e9d165()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_9d6e73379a1a473f928edc3a7914de98 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d6e73379a1a473f928edc3a7914de98()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_a06e425be256498795a0078d4668222b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a06e425be256498795a0078d4668222b()
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

      private sealed class MTHD_8b386985a6084b428759e55412df7ffd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b386985a6084b428759e55412df7ffd()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_3b0609f51a1644fea32959cb07824dd6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3b0609f51a1644fea32959cb07824dd6()
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

      private sealed class MTHD_8a780e59de5049c2a547208b2377089e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a780e59de5049c2a547208b2377089e()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_b428ab731eaa4399b54ee04fd36decb1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b428ab731eaa4399b54ee04fd36decb1()
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

      private sealed class MTHD_5301c5925f1b4876bca76f730797c9df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5301c5925f1b4876bca76f730797c9df()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_2fea111c457a47f0985ce5e853da1023 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2fea111c457a47f0985ce5e853da1023()
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

      private sealed class MTHD_c451825e266f486abaa8305bcd5cad89 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c451825e266f486abaa8305bcd5cad89()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_c63a9b9327d746b69865599d617f7e83 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c63a9b9327d746b69865599d617f7e83()
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

      private sealed class MTHD_09cb8bfff0d84190ba4c69c9a86d7119 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_09cb8bfff0d84190ba4c69c9a86d7119()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_54335dc3f35e4bd39c95302670c4abaf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_54335dc3f35e4bd39c95302670c4abaf()
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

      private sealed class MTHD_442122978099406781732aea9a99a723 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_442122978099406781732aea9a99a723()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color2;
        }
      }

      private sealed class MTHD_6e783aa7db004c68a67b204125ab0e35 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e783aa7db004c68a67b204125ab0e35()
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

      private sealed class MTHD_c5235bdf7f4c4cc59c6dff282ce28d0f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c5235bdf7f4c4cc59c6dff282ce28d0f()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_eb79ceb121cc4cf79807431dbab88046 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb79ceb121cc4cf79807431dbab88046()
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

      private sealed class MTHD_2797aaacbe4f4cd2b235e3a72a85d6d7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2797aaacbe4f4cd2b235e3a72a85d6d7()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9535e6fcb4244094bc14226c847df23a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9535e6fcb4244094bc14226c847df23a()
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

      private sealed class MTHD_a1a218a3515f41f0a1b8608c4b58fe3d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1a218a3515f41f0a1b8608c4b58fe3d()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_8e21fde60149463d9819f4fdf2634f01 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e21fde60149463d9819f4fdf2634f01()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_0ebe5df0df5a4303a3cf258c72862787 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ebe5df0df5a4303a3cf258c72862787()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_3f4006df75d544e5a319725242657393 : HardwiredMemberDescriptor
      {
        internal PROP_3f4006df75d544e5a319725242657393()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_6ed415ba0abb4a22a91e9c4e4fd5d5fd : HardwiredMemberDescriptor
      {
        internal PROP_6ed415ba0abb4a22a91e9c4e4fd5d5fd()
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

      private sealed class PROP_3f122a5d4ebf40fcb43a659ab87fa216 : HardwiredMemberDescriptor
      {
        internal PROP_3f122a5d4ebf40fcb43a659ab87fa216()
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

      private sealed class PROP_1782adc70e85464db1f98903fb0c19ce : HardwiredMemberDescriptor
      {
        internal PROP_1782adc70e85464db1f98903fb0c19ce()
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

      private sealed class PROP_71799671c9ff4befa1eacdcf8e046247 : HardwiredMemberDescriptor
      {
        internal PROP_71799671c9ff4befa1eacdcf8e046247()
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

      private sealed class PROP_ce87d725fa2c460eb71454083e3a9dcf : HardwiredMemberDescriptor
      {
        internal PROP_ce87d725fa2c460eb71454083e3a9dcf()
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

      private sealed class PROP_d3855c61d78b40eab3a729a1d66c2882 : HardwiredMemberDescriptor
      {
        internal PROP_d3855c61d78b40eab3a729a1d66c2882()
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

      private sealed class PROP_43b2ff2e3ddf483ebc52c02365cb3756 : HardwiredMemberDescriptor
      {
        internal PROP_43b2ff2e3ddf483ebc52c02365cb3756()
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

      private sealed class PROP_531697cdaad145d895f10f0833d13edf : HardwiredMemberDescriptor
      {
        internal PROP_531697cdaad145d895f10f0833d13edf()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_de461c72870140e59f0850396adcaff7 : HardwiredUserDataDescriptor
    {
      internal TYPE_de461c72870140e59f0850396adcaff7()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_6e4d6e4d565c45e29dcde34551c8fdf6()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_68bfb561b4f64c4aa6e4c589734c83ed()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_ee05e285cffa4ab98263d480f0b76185()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_ab3c9d691d4543988950f1089410a79b()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_91fa8384121c4bb396a7b8ca6b412fbd()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_e12362337e5c457980e4584d816ea9b6()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_ed8bb6987ea8485a991ee24fd5379476()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_4d2a7d6929214ea681d9d4679eb9574c()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_bfb3d0863f9549749515b62f06ec8a9b()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_cbe39926077544dc9afd8d0c93bf5ba8()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_f3819e723d334d98bdec19d81381a31a()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_a06e1aac86f74a1bb1dd80e4307a30aa()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_1b80a9e6d95c4b0f97c99279c41bdda4()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_c7015395dae44ba3911bf32754030085()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_494d29e56f4948e0847886f1a0e767e0()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_8bceef16b6db446e98a79ea0ee7ca820()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_9ed8233095534e09b2e8f353c3aaa413()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_d28f654119ad47ffadf054e30be0a7c2()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_b42298fb4d474e00a54e49b579f8cf87()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_0381f5a2f8d14e919001518ea7b261b9()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_a13ee77c3bb944b7b05827760dd52bef()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_6c0a70f6b41b40549ff75fb3708325f0()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_88f969a8224842d5af55eb25eb559457()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_feeba661dee8490db046a3b201156e2f()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_843635deb4e0470dad6622a1c36c5a11()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_90b9d49b38d542419f8e2f4dd4c84bae()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_1aaf18c4071541fe8c5a06ba7afa12dd()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.MTHD_20704e3ed5d54d9da06ff34a5b51eb44()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.PROP_e0d48ae5ad384b7f8edb1cb75ce3c842());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.PROP_905ec00f588a4623be6722c5c86d84b0());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.PROP_57b7458a9ab9427faf0447f4bebc7b73());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.PROP_7c410a06868b478f9f751f5b247434aa());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.PROP_86549226697f4a1abbad788619a3e040());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.PROP_e2d445e14de2489293779535d6d828ed());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.PROP_e61503bab20e4131be575c6d59b0dc7b());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.PROP_60fe95d125dc419fa96c04a14b2492d1());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.PROP_7e9c9cd1ab9342dfabd88efb74c62273());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.PROP_b51eb88c99ed45f2ae35002bd54e6b69());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.PROP_f772865b7be5429dabb3ac2756bc86a3());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.PROP_eee78027c9ef4c13b1d272b8e9096fc7());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.PROP_11f2a42850c7470396edb900b68e7a03());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.PROP_4ef9f26241e94a61847c18f0b20e0764());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.PROP_bcad0f67ed0545bd8c6ed4556d9861dc());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.PROP_74d454a40a72488ab10add9de04b9a41());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_de461c72870140e59f0850396adcaff7.PROP_bc95168489b2424ba9bcbcd56f0e8724());
      }

      private sealed class MTHD_6e4d6e4d565c45e29dcde34551c8fdf6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e4d6e4d565c45e29dcde34551c8fdf6()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_68bfb561b4f64c4aa6e4c589734c83ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_68bfb561b4f64c4aa6e4c589734c83ed()
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

      private sealed class MTHD_ee05e285cffa4ab98263d480f0b76185 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee05e285cffa4ab98263d480f0b76185()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_ab3c9d691d4543988950f1089410a79b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab3c9d691d4543988950f1089410a79b()
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

      private sealed class MTHD_91fa8384121c4bb396a7b8ca6b412fbd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_91fa8384121c4bb396a7b8ca6b412fbd()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_e12362337e5c457980e4584d816ea9b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e12362337e5c457980e4584d816ea9b6()
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

      private sealed class MTHD_ed8bb6987ea8485a991ee24fd5379476 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed8bb6987ea8485a991ee24fd5379476()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_4d2a7d6929214ea681d9d4679eb9574c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d2a7d6929214ea681d9d4679eb9574c()
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

      private sealed class MTHD_bfb3d0863f9549749515b62f06ec8a9b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bfb3d0863f9549749515b62f06ec8a9b()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_cbe39926077544dc9afd8d0c93bf5ba8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cbe39926077544dc9afd8d0c93bf5ba8()
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

      private sealed class MTHD_f3819e723d334d98bdec19d81381a31a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f3819e723d334d98bdec19d81381a31a()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_a06e1aac86f74a1bb1dd80e4307a30aa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a06e1aac86f74a1bb1dd80e4307a30aa()
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

      private sealed class MTHD_1b80a9e6d95c4b0f97c99279c41bdda4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1b80a9e6d95c4b0f97c99279c41bdda4()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_c7015395dae44ba3911bf32754030085 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c7015395dae44ba3911bf32754030085()
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

      private sealed class MTHD_494d29e56f4948e0847886f1a0e767e0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_494d29e56f4948e0847886f1a0e767e0()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_8bceef16b6db446e98a79ea0ee7ca820 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8bceef16b6db446e98a79ea0ee7ca820()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_9ed8233095534e09b2e8f353c3aaa413 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ed8233095534e09b2e8f353c3aaa413()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_d28f654119ad47ffadf054e30be0a7c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d28f654119ad47ffadf054e30be0a7c2()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_b42298fb4d474e00a54e49b579f8cf87 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b42298fb4d474e00a54e49b579f8cf87()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_0381f5a2f8d14e919001518ea7b261b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0381f5a2f8d14e919001518ea7b261b9()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_a13ee77c3bb944b7b05827760dd52bef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a13ee77c3bb944b7b05827760dd52bef()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_6c0a70f6b41b40549ff75fb3708325f0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6c0a70f6b41b40549ff75fb3708325f0()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_88f969a8224842d5af55eb25eb559457 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_88f969a8224842d5af55eb25eb559457()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_feeba661dee8490db046a3b201156e2f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_feeba661dee8490db046a3b201156e2f()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_843635deb4e0470dad6622a1c36c5a11 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_843635deb4e0470dad6622a1c36c5a11()
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

      private sealed class MTHD_90b9d49b38d542419f8e2f4dd4c84bae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90b9d49b38d542419f8e2f4dd4c84bae()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_1aaf18c4071541fe8c5a06ba7afa12dd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1aaf18c4071541fe8c5a06ba7afa12dd()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_20704e3ed5d54d9da06ff34a5b51eb44 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_20704e3ed5d54d9da06ff34a5b51eb44()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_e0d48ae5ad384b7f8edb1cb75ce3c842 : HardwiredMemberDescriptor
      {
        internal PROP_e0d48ae5ad384b7f8edb1cb75ce3c842()
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

      private sealed class PROP_905ec00f588a4623be6722c5c86d84b0 : HardwiredMemberDescriptor
      {
        internal PROP_905ec00f588a4623be6722c5c86d84b0()
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

      private sealed class PROP_57b7458a9ab9427faf0447f4bebc7b73 : HardwiredMemberDescriptor
      {
        internal PROP_57b7458a9ab9427faf0447f4bebc7b73()
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

      private sealed class PROP_7c410a06868b478f9f751f5b247434aa : HardwiredMemberDescriptor
      {
        internal PROP_7c410a06868b478f9f751f5b247434aa()
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

      private sealed class PROP_86549226697f4a1abbad788619a3e040 : HardwiredMemberDescriptor
      {
        internal PROP_86549226697f4a1abbad788619a3e040()
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

      private sealed class PROP_e2d445e14de2489293779535d6d828ed : HardwiredMemberDescriptor
      {
        internal PROP_e2d445e14de2489293779535d6d828ed()
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

      private sealed class PROP_e61503bab20e4131be575c6d59b0dc7b : HardwiredMemberDescriptor
      {
        internal PROP_e61503bab20e4131be575c6d59b0dc7b()
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

      private sealed class PROP_60fe95d125dc419fa96c04a14b2492d1 : HardwiredMemberDescriptor
      {
        internal PROP_60fe95d125dc419fa96c04a14b2492d1()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_7e9c9cd1ab9342dfabd88efb74c62273 : HardwiredMemberDescriptor
      {
        internal PROP_7e9c9cd1ab9342dfabd88efb74c62273()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_b51eb88c99ed45f2ae35002bd54e6b69 : HardwiredMemberDescriptor
      {
        internal PROP_b51eb88c99ed45f2ae35002bd54e6b69()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_f772865b7be5429dabb3ac2756bc86a3 : HardwiredMemberDescriptor
      {
        internal PROP_f772865b7be5429dabb3ac2756bc86a3()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_eee78027c9ef4c13b1d272b8e9096fc7 : HardwiredMemberDescriptor
      {
        internal PROP_eee78027c9ef4c13b1d272b8e9096fc7()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_11f2a42850c7470396edb900b68e7a03 : HardwiredMemberDescriptor
      {
        internal PROP_11f2a42850c7470396edb900b68e7a03()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_4ef9f26241e94a61847c18f0b20e0764 : HardwiredMemberDescriptor
      {
        internal PROP_4ef9f26241e94a61847c18f0b20e0764()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_bcad0f67ed0545bd8c6ed4556d9861dc : HardwiredMemberDescriptor
      {
        internal PROP_bcad0f67ed0545bd8c6ed4556d9861dc()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_74d454a40a72488ab10add9de04b9a41 : HardwiredMemberDescriptor
      {
        internal PROP_74d454a40a72488ab10add9de04b9a41()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_bc95168489b2424ba9bcbcd56f0e8724 : HardwiredMemberDescriptor
      {
        internal PROP_bc95168489b2424ba9bcbcd56f0e8724()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_a5a0e324b5ab40aea79db9f6cbfbb816 : HardwiredUserDataDescriptor
    {
      internal TYPE_a5a0e324b5ab40aea79db9f6cbfbb816()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a5a0e324b5ab40aea79db9f6cbfbb816.MTHD_dbb87a5f256b4c8c81ad7d6c7276f4b7()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a5a0e324b5ab40aea79db9f6cbfbb816.MTHD_cce98f55a9ff4c13b952a14a0b556777()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a5a0e324b5ab40aea79db9f6cbfbb816.MTHD_0f8164392618411fa4f7ff1bf4628e64()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a5a0e324b5ab40aea79db9f6cbfbb816.MTHD_8b9d119434a4456bb4b6e2396af40475()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a5a0e324b5ab40aea79db9f6cbfbb816.MTHD_3555fcf1fe244c5f80589ed9902e91fd()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a5a0e324b5ab40aea79db9f6cbfbb816.MTHD_f08d95b63a21496e9e90d9ee6f32c5e5()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a5a0e324b5ab40aea79db9f6cbfbb816.MTHD_31d89d576b17453d84a9e920def0f515()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a5a0e324b5ab40aea79db9f6cbfbb816.MTHD_fe4e108bd1d84442aff420f8219f77c9()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a5a0e324b5ab40aea79db9f6cbfbb816.MTHD_e0a83add668f4d51a3a1891f085a5245()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a5a0e324b5ab40aea79db9f6cbfbb816.MTHD_a54f977642ec416f90c7f6bebdbff6ab()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a5a0e324b5ab40aea79db9f6cbfbb816.MTHD_97ab82c573064f2983e0de94daafa683()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a5a0e324b5ab40aea79db9f6cbfbb816.MTHD_7c9b2783614c4efcbf804174145989ee()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a5a0e324b5ab40aea79db9f6cbfbb816.MTHD_98b6bff8c06a436d9312dedeb8eefbb0()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a5a0e324b5ab40aea79db9f6cbfbb816.MTHD_cbd77f4ae4f5463da1345557bdfcf13c()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a5a0e324b5ab40aea79db9f6cbfbb816.MTHD_c91343dc269e447b8945169546d866b7()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a5a0e324b5ab40aea79db9f6cbfbb816.MTHD_7dad4a38eeb34507b68283a24aea2505()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a5a0e324b5ab40aea79db9f6cbfbb816.MTHD_7ecf4799eef74b3c8f0a8188caaf67db()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_a5a0e324b5ab40aea79db9f6cbfbb816.PROP_22bce080dccf4b459f249e7b6e81f556());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_a5a0e324b5ab40aea79db9f6cbfbb816.PROP_02a42dda9a224fad8c52d314a4f9098a());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_a5a0e324b5ab40aea79db9f6cbfbb816.PROP_eac9336e0f5f4993879a4f75e2b6b863());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_a5a0e324b5ab40aea79db9f6cbfbb816.PROP_a16b0fe0aca249d0beee667ba84a0959());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_a5a0e324b5ab40aea79db9f6cbfbb816.PROP_26687c47dfc640fb88617d7fc8b6dfa8());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_a5a0e324b5ab40aea79db9f6cbfbb816.PROP_e28a668e936942559e93d590849214b4());
      }

      private sealed class MTHD_dbb87a5f256b4c8c81ad7d6c7276f4b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dbb87a5f256b4c8c81ad7d6c7276f4b7()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_cce98f55a9ff4c13b952a14a0b556777 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cce98f55a9ff4c13b952a14a0b556777()
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

      private sealed class MTHD_0f8164392618411fa4f7ff1bf4628e64 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f8164392618411fa4f7ff1bf4628e64()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_8b9d119434a4456bb4b6e2396af40475 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b9d119434a4456bb4b6e2396af40475()
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

      private sealed class MTHD_3555fcf1fe244c5f80589ed9902e91fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3555fcf1fe244c5f80589ed9902e91fd()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_f08d95b63a21496e9e90d9ee6f32c5e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f08d95b63a21496e9e90d9ee6f32c5e5()
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

      private sealed class MTHD_31d89d576b17453d84a9e920def0f515 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_31d89d576b17453d84a9e920def0f515()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_fe4e108bd1d84442aff420f8219f77c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fe4e108bd1d84442aff420f8219f77c9()
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

      private sealed class MTHD_e0a83add668f4d51a3a1891f085a5245 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e0a83add668f4d51a3a1891f085a5245()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_a54f977642ec416f90c7f6bebdbff6ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a54f977642ec416f90c7f6bebdbff6ab()
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

      private sealed class MTHD_97ab82c573064f2983e0de94daafa683 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97ab82c573064f2983e0de94daafa683()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_7c9b2783614c4efcbf804174145989ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7c9b2783614c4efcbf804174145989ee()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_98b6bff8c06a436d9312dedeb8eefbb0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_98b6bff8c06a436d9312dedeb8eefbb0()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_cbd77f4ae4f5463da1345557bdfcf13c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cbd77f4ae4f5463da1345557bdfcf13c()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_c91343dc269e447b8945169546d866b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c91343dc269e447b8945169546d866b7()
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

      private sealed class MTHD_7dad4a38eeb34507b68283a24aea2505 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7dad4a38eeb34507b68283a24aea2505()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_7ecf4799eef74b3c8f0a8188caaf67db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ecf4799eef74b3c8f0a8188caaf67db()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_22bce080dccf4b459f249e7b6e81f556 : HardwiredMemberDescriptor
      {
        internal PROP_22bce080dccf4b459f249e7b6e81f556()
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

      private sealed class PROP_02a42dda9a224fad8c52d314a4f9098a : HardwiredMemberDescriptor
      {
        internal PROP_02a42dda9a224fad8c52d314a4f9098a()
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

      private sealed class PROP_eac9336e0f5f4993879a4f75e2b6b863 : HardwiredMemberDescriptor
      {
        internal PROP_eac9336e0f5f4993879a4f75e2b6b863()
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

      private sealed class PROP_a16b0fe0aca249d0beee667ba84a0959 : HardwiredMemberDescriptor
      {
        internal PROP_a16b0fe0aca249d0beee667ba84a0959()
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

      private sealed class PROP_26687c47dfc640fb88617d7fc8b6dfa8 : HardwiredMemberDescriptor
      {
        internal PROP_26687c47dfc640fb88617d7fc8b6dfa8()
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

      private sealed class PROP_e28a668e936942559e93d590849214b4 : HardwiredMemberDescriptor
      {
        internal PROP_e28a668e936942559e93d590849214b4()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_e17cde0c6ce44b98949694754451ac11 : HardwiredUserDataDescriptor
    {
      internal TYPE_e17cde0c6ce44b98949694754451ac11()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e17cde0c6ce44b98949694754451ac11.MTHD_21b672fa56da4321a36afba9a9295976(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e17cde0c6ce44b98949694754451ac11.MTHD_a1dac01e501448a2bf2748ebd924190e()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e17cde0c6ce44b98949694754451ac11.MTHD_be8b31278a85491fa7ed63dc6a8a0fc6(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e17cde0c6ce44b98949694754451ac11.MTHD_49d8f2bf00b04943b2c14d365c2ed3e5()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e17cde0c6ce44b98949694754451ac11.MTHD_adcaa8bdac584df3b141a0c59646aef9()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e17cde0c6ce44b98949694754451ac11.MTHD_c264c1696b384e21a07e63ac5d804b70()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e17cde0c6ce44b98949694754451ac11.MTHD_c2da67ee85364f6a83ad49a543049445()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e17cde0c6ce44b98949694754451ac11.MTHD_398af7ea8c804777afdc3d75682c6a59()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e17cde0c6ce44b98949694754451ac11.MTHD_29b16dc2c3874b79970e1bbac1353856()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e17cde0c6ce44b98949694754451ac11.MTHD_8a48f4b110364a58b2f600ed4f032d9d()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e17cde0c6ce44b98949694754451ac11.MTHD_180c3feec0b34784b529182cfacca6c8()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e17cde0c6ce44b98949694754451ac11.MTHD_2b81beff18fc4b81b9fce386aacabfb9(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e17cde0c6ce44b98949694754451ac11.MTHD_99189aab90d14363a3fc1c5d15418645()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e17cde0c6ce44b98949694754451ac11.MTHD_7b52a3aee57d44fa8bd15f8f4af73de1(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e17cde0c6ce44b98949694754451ac11.MTHD_5adc9d117e344bbbaf0f9d9072ab1508()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e17cde0c6ce44b98949694754451ac11.MTHD_6ee7c2c72de844a1a03ef55182e987da(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e17cde0c6ce44b98949694754451ac11.MTHD_5878a690667a406784728b19aa75db95()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e17cde0c6ce44b98949694754451ac11.MTHD_5630f352476741eb9318b816a861bf91(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e17cde0c6ce44b98949694754451ac11.MTHD_1d1d459266374a70ad94633bb0057b9e()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e17cde0c6ce44b98949694754451ac11.MTHD_c3f5ce3e50374f24bac6996c12a5fb52(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e17cde0c6ce44b98949694754451ac11.MTHD_3e8ad4b0d7374593b5072b9cdbbb5894()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e17cde0c6ce44b98949694754451ac11.MTHD_097bff3f97ef454382899052c89ae2de()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e17cde0c6ce44b98949694754451ac11.MTHD_7a8d473beae44809b972d72b73b10f64()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_e17cde0c6ce44b98949694754451ac11.FLDV_82db59920af84a7dba17b5ec613d3a16());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_e17cde0c6ce44b98949694754451ac11.FLDV_62787536516b4f0cb631eac263443aed());
      }

      private sealed class MTHD_21b672fa56da4321a36afba9a9295976 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_21b672fa56da4321a36afba9a9295976()
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

      private sealed class MTHD_a1dac01e501448a2bf2748ebd924190e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1dac01e501448a2bf2748ebd924190e()
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

      private sealed class MTHD_be8b31278a85491fa7ed63dc6a8a0fc6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be8b31278a85491fa7ed63dc6a8a0fc6()
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

      private sealed class MTHD_49d8f2bf00b04943b2c14d365c2ed3e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49d8f2bf00b04943b2c14d365c2ed3e5()
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

      private sealed class MTHD_adcaa8bdac584df3b141a0c59646aef9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_adcaa8bdac584df3b141a0c59646aef9()
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

      private sealed class MTHD_c264c1696b384e21a07e63ac5d804b70 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c264c1696b384e21a07e63ac5d804b70()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_c2da67ee85364f6a83ad49a543049445 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c2da67ee85364f6a83ad49a543049445()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_398af7ea8c804777afdc3d75682c6a59 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_398af7ea8c804777afdc3d75682c6a59()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_29b16dc2c3874b79970e1bbac1353856 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_29b16dc2c3874b79970e1bbac1353856()
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

      private sealed class MTHD_8a48f4b110364a58b2f600ed4f032d9d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a48f4b110364a58b2f600ed4f032d9d()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_180c3feec0b34784b529182cfacca6c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_180c3feec0b34784b529182cfacca6c8()
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

      private sealed class MTHD_2b81beff18fc4b81b9fce386aacabfb9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b81beff18fc4b81b9fce386aacabfb9()
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

      private sealed class MTHD_99189aab90d14363a3fc1c5d15418645 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99189aab90d14363a3fc1c5d15418645()
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

      private sealed class MTHD_7b52a3aee57d44fa8bd15f8f4af73de1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b52a3aee57d44fa8bd15f8f4af73de1()
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

      private sealed class MTHD_5adc9d117e344bbbaf0f9d9072ab1508 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5adc9d117e344bbbaf0f9d9072ab1508()
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

      private sealed class MTHD_6ee7c2c72de844a1a03ef55182e987da : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ee7c2c72de844a1a03ef55182e987da()
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

      private sealed class MTHD_5878a690667a406784728b19aa75db95 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5878a690667a406784728b19aa75db95()
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

      private sealed class MTHD_5630f352476741eb9318b816a861bf91 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5630f352476741eb9318b816a861bf91()
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

      private sealed class MTHD_1d1d459266374a70ad94633bb0057b9e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d1d459266374a70ad94633bb0057b9e()
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

      private sealed class MTHD_c3f5ce3e50374f24bac6996c12a5fb52 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c3f5ce3e50374f24bac6996c12a5fb52()
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

      private sealed class MTHD_3e8ad4b0d7374593b5072b9cdbbb5894 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e8ad4b0d7374593b5072b9cdbbb5894()
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

      private sealed class MTHD_097bff3f97ef454382899052c89ae2de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_097bff3f97ef454382899052c89ae2de()
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

      private sealed class MTHD_7a8d473beae44809b972d72b73b10f64 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a8d473beae44809b972d72b73b10f64()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_82db59920af84a7dba17b5ec613d3a16 : HardwiredMemberDescriptor
      {
        internal FLDV_82db59920af84a7dba17b5ec613d3a16()
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

      private sealed class FLDV_62787536516b4f0cb631eac263443aed : HardwiredMemberDescriptor
      {
        internal FLDV_62787536516b4f0cb631eac263443aed()
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

    private sealed class TYPE_5d22a95e2c7141b98ce8c39d93cdc2bb : HardwiredUserDataDescriptor
    {
      internal TYPE_5d22a95e2c7141b98ce8c39d93cdc2bb()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d22a95e2c7141b98ce8c39d93cdc2bb.MTHD_92da6db65eb748f3b4f5f38a395e118b()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d22a95e2c7141b98ce8c39d93cdc2bb.MTHD_6d1356f50a24486db2cf4622c0b1185a()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d22a95e2c7141b98ce8c39d93cdc2bb.MTHD_5608b1703a9e44189d5b067b5a681862()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d22a95e2c7141b98ce8c39d93cdc2bb.MTHD_0038d880796742ae9ac789e5ede04c5d()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d22a95e2c7141b98ce8c39d93cdc2bb.MTHD_2cfabc508076441cb0aec7d7676e4d4e()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5d22a95e2c7141b98ce8c39d93cdc2bb.MTHD_ed1d51812b6b4e859a98d6e47663aafb()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_5d22a95e2c7141b98ce8c39d93cdc2bb.FLDV_21c5d36128884ae0b3f348e1ff6fbb8c());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_5d22a95e2c7141b98ce8c39d93cdc2bb.FLDV_ca057671975b4ae1935af277a8dee42f());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_5d22a95e2c7141b98ce8c39d93cdc2bb.FLDV_43b36c30f6404cd292021f445c159f5a());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_5d22a95e2c7141b98ce8c39d93cdc2bb.FLDV_c1a6e546ec6240ee977b9fab1d5c880d());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_5d22a95e2c7141b98ce8c39d93cdc2bb.FLDV_db4e6b95ddce4edcb397bf15c3ef5c49());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_5d22a95e2c7141b98ce8c39d93cdc2bb.FLDV_48f000ec8d2b4106a18e143a30badc3a());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_5d22a95e2c7141b98ce8c39d93cdc2bb.FLDV_60f71b5530b84f3bba4b0f0617629f13());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_5d22a95e2c7141b98ce8c39d93cdc2bb.FLDV_c734fd4e3f394789ab13a2cac894177d());
        this.AddMember("prestige", (IMemberDescriptor) new Bridge.TYPE_5d22a95e2c7141b98ce8c39d93cdc2bb.FLDV_516d5394aee34dee9d22992d3d0a643c());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_5d22a95e2c7141b98ce8c39d93cdc2bb.FLDV_00c2a3cae2df42b9b05b22ae871374fa());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_5d22a95e2c7141b98ce8c39d93cdc2bb.FLDV_864e4b30d6314b7e9e4a6f6dbcd46e4d());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_5d22a95e2c7141b98ce8c39d93cdc2bb.FLDV_2d731233578e4974828fafad6526f41a());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_5d22a95e2c7141b98ce8c39d93cdc2bb.FLDV_ed98d8ba12b9418e9c91fffa77624361());
      }

      private sealed class MTHD_92da6db65eb748f3b4f5f38a395e118b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_92da6db65eb748f3b4f5f38a395e118b()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_6d1356f50a24486db2cf4622c0b1185a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d1356f50a24486db2cf4622c0b1185a()
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

      private sealed class MTHD_5608b1703a9e44189d5b067b5a681862 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5608b1703a9e44189d5b067b5a681862()
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

      private sealed class MTHD_0038d880796742ae9ac789e5ede04c5d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0038d880796742ae9ac789e5ede04c5d()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_2cfabc508076441cb0aec7d7676e4d4e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2cfabc508076441cb0aec7d7676e4d4e()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_ed1d51812b6b4e859a98d6e47663aafb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed1d51812b6b4e859a98d6e47663aafb()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_21c5d36128884ae0b3f348e1ff6fbb8c : HardwiredMemberDescriptor
      {
        internal FLDV_21c5d36128884ae0b3f348e1ff6fbb8c()
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

      private sealed class FLDV_ca057671975b4ae1935af277a8dee42f : HardwiredMemberDescriptor
      {
        internal FLDV_ca057671975b4ae1935af277a8dee42f()
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

      private sealed class FLDV_43b36c30f6404cd292021f445c159f5a : HardwiredMemberDescriptor
      {
        internal FLDV_43b36c30f6404cd292021f445c159f5a()
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

      private sealed class FLDV_c1a6e546ec6240ee977b9fab1d5c880d : HardwiredMemberDescriptor
      {
        internal FLDV_c1a6e546ec6240ee977b9fab1d5c880d()
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

      private sealed class FLDV_db4e6b95ddce4edcb397bf15c3ef5c49 : HardwiredMemberDescriptor
      {
        internal FLDV_db4e6b95ddce4edcb397bf15c3ef5c49()
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

      private sealed class FLDV_48f000ec8d2b4106a18e143a30badc3a : HardwiredMemberDescriptor
      {
        internal FLDV_48f000ec8d2b4106a18e143a30badc3a()
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

      private sealed class FLDV_60f71b5530b84f3bba4b0f0617629f13 : HardwiredMemberDescriptor
      {
        internal FLDV_60f71b5530b84f3bba4b0f0617629f13()
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

      private sealed class FLDV_c734fd4e3f394789ab13a2cac894177d : HardwiredMemberDescriptor
      {
        internal FLDV_c734fd4e3f394789ab13a2cac894177d()
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

      private sealed class FLDV_516d5394aee34dee9d22992d3d0a643c : HardwiredMemberDescriptor
      {
        internal FLDV_516d5394aee34dee9d22992d3d0a643c()
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

      private sealed class FLDV_00c2a3cae2df42b9b05b22ae871374fa : HardwiredMemberDescriptor
      {
        internal FLDV_00c2a3cae2df42b9b05b22ae871374fa()
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

      private sealed class FLDV_864e4b30d6314b7e9e4a6f6dbcd46e4d : HardwiredMemberDescriptor
      {
        internal FLDV_864e4b30d6314b7e9e4a6f6dbcd46e4d()
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

      private sealed class FLDV_2d731233578e4974828fafad6526f41a : HardwiredMemberDescriptor
      {
        internal FLDV_2d731233578e4974828fafad6526f41a()
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

      private sealed class FLDV_ed98d8ba12b9418e9c91fffa77624361 : HardwiredMemberDescriptor
      {
        internal FLDV_ed98d8ba12b9418e9c91fffa77624361()
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

    private sealed class TYPE_62dcc00a6c84459db0ce35b5c3844af5 : HardwiredUserDataDescriptor
    {
      internal TYPE_62dcc00a6c84459db0ce35b5c3844af5()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_e3c2ef5a8b854d46a9575c1d82415688()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_1be2ccc3d69845e8832588b5ae4f5ebb()
        }));
        this.AddMember("get_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_b7f7d79f8ada440eabbe879e76354d6d()
        }));
        this.AddMember("set_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_d025d1afdd4e47fca21274cbd0703bd1()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_28f9caf7057440c89201bee62c011064()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_ca04d6ebc56545a08eb3939799dd2573()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_bf6acab04b8b4b6c95181503212e176d()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_22ee56ad89794075855729af5cff59f5()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_ff880fb05ba64947b67258a0e83d7899()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_50f55f3e86834431b5bd7ad895b3dd77()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_0f0674c38c68477e9a250f5a4c73d55c()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_37c9f84a4cce42b5be7cdea511a1ed97()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_327bb79b363f4ff7819ba37c772a68e9()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_5e69d9c2de584b9b9899b7806a0faba1()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_fd5ef61c2865454caee638d6ecd91caf()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_2df0558dbacf4203880f9b65d700bc85()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_2a6488ed1a1245508abe485f25e54a08()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_9d09b52e4c9a4e91869305a20d78cda0()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_1a604a0ba80748d6a1d716e8b640e0d2()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_80fe785f2dac4208b4c3f6dc8b66bcea()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_487e9441ae7946b7b5ece82a133f02df()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_469b496bd5fc4bb8952c82ee7af4bdef()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_a0dce5b03c9042c18155e0742f22c150()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_26e1a13bf24943cd8db15e44a279fda2()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_0b6ff3e328254342916f48b83d9bc416()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_8a9bb632f5344c5ba6b0658b4f29081e()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_6414600b73e94f9a96aa0dab4c5666fd()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_964730ab611943fcba74cae3766fc7b6()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_0864c19752ab4bc897ecf591e7637ea5()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_dfe9e25265664f608e39e24accd6617e()
        }));
        this.AddMember("get_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_ed9c73555e7245d59985ab657524b023()
        }));
        this.AddMember("set_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_15c4e62598b04099bcc0ffb6c0c793a3()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_e66f46fc59344d58a1b394177705a1fd()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_9d5ec9b3173a4cd5a0ea82a96e512e34()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_3aa2fb882abc413490534e82068c44ee()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_d5ae1cb29e4c4c74b113ef91e86aeb9c()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_bdb4c029d4e146cab980554574dee449()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_e041fa539adc4640a97052b607f9ebdd()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_1003304aa23f4f62af9e2ee5335440ab()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_89824b349fe147bea404ad461fcec1ed()
        }));
        this.AddMember("get_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_05064b00f937450b8246b19089a1f1d3()
        }));
        this.AddMember("set_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_caab124c4ced4ea79bfa52984560960c()
        }));
        this.AddMember("get_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_cc8e7c6ea1c443878dd6794dcf8092da()
        }));
        this.AddMember("set_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_d50b471aa3094517968ea33ac7f8b6e9()
        }));
        this.AddMember("get_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_48a41ec58c4f4adc8b62696170de403a()
        }));
        this.AddMember("set_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_b25c81cef27b4f8eaec7384b7098ac85()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_fcddcccffea446c8a47fd396ea44ecbb()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_d7a7f1ab68b447eca4b8a4ba901cfdca()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_6e33ff692dde4322b3e0bcad64940c39()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_89fe13eb10904d58b3c9c52a462d8492()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_ab4291d80cc4440f8b2852350ba82626()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_aa1f13ed01954e07999e891e6b0e79f2()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_62d919c65d0441e6b74255dd4aceab28()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_a4b044ef2c41452d945adf6ba3094fbe()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_396721c869ed4133991d57ddea75e2db()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_bf9b0d293f6f4f5595132e48b1d8e449()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_9814db25e0984a47a7437c4baf75adbc()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_85ba063668d848819c9303fedeae07f7()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_a6a212c6a00d41d2b03ca00135d1881b()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.MTHD_2c86a2d85512438ca65ec1894f39706b()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.PROP_092837797a5c47809043d16a29f8d83f());
        this.AddMember("visible", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.PROP_96a012495ad34605879c47ad13ceddaa());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.PROP_543d6f4566124b1a8aebe6ebcd499bd7());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.PROP_8ec84a756cfb42308ca258850dab7741());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.PROP_cd4c4f624dab43a18f13eb1206aeadfe());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.PROP_36357fe48d7f43488794bfceb8e3b3ad());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.PROP_ea01e8fd98b64a1ab560aa900288a339());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.PROP_e4c7d9ddf095462baccdfb6faeae35e5());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.PROP_deb841a9a1ef474fabf7f76c31fc41ee());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.PROP_cc7d1e4b1a1f44d39d0f2539aab31c06());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.PROP_cd7d23748028433ea3cf05258b540472());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.PROP_e761537a7ea94973b466faf86edf1a8c());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.PROP_f65f694829c546fd83323fcf97968bd0());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.PROP_5719a047672e4b02bd902aae92c2b2a9());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.PROP_2c5525d9b96f42878784cd17a994524d());
        this.AddMember("onClick2", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.PROP_4bc34815411b4728b47ed2023c0ceeac());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.PROP_5a029b89f04c48e99eac5deed47d61a3());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.PROP_3d718f3a2fda413394e25dc2eac2f960());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.PROP_63a7e92ab9ff4684be1dce5b5d799753());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.PROP_d7294cbedefc446cbd8b78c83338dd18());
        this.AddMember("textColor2", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.PROP_6cfe4f487317452889035297268d8fae());
        this.AddMember("highlightColor", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.PROP_b166a4fb1b6e497087866b03ad64b4ab());
        this.AddMember("highlightColor2", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.PROP_270a39618f7e4b8abf91cd52b2b0cf10());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.PROP_20638aadfc2f4cfabde55f7b63820e7a());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.PROP_2039d078dce9405a9ad4b651b41195fd());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.FLDV_fd12577a55c943cbbf5fd44754f75670());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.FLDV_5c00ddaeb0244d48afebeb4b3fa18ad7());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_62dcc00a6c84459db0ce35b5c3844af5.FLDV_243b028d9dd64f2894b6facb077b68f6());
      }

      private sealed class MTHD_e3c2ef5a8b854d46a9575c1d82415688 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e3c2ef5a8b854d46a9575c1d82415688()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_1be2ccc3d69845e8832588b5ae4f5ebb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1be2ccc3d69845e8832588b5ae4f5ebb()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_b7f7d79f8ada440eabbe879e76354d6d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b7f7d79f8ada440eabbe879e76354d6d()
        {
          this.Initialize("get_visible", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).visible;
        }
      }

      private sealed class MTHD_d025d1afdd4e47fca21274cbd0703bd1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d025d1afdd4e47fca21274cbd0703bd1()
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

      private sealed class MTHD_28f9caf7057440c89201bee62c011064 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_28f9caf7057440c89201bee62c011064()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_ca04d6ebc56545a08eb3939799dd2573 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ca04d6ebc56545a08eb3939799dd2573()
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

      private sealed class MTHD_bf6acab04b8b4b6c95181503212e176d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf6acab04b8b4b6c95181503212e176d()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_22ee56ad89794075855729af5cff59f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22ee56ad89794075855729af5cff59f5()
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

      private sealed class MTHD_ff880fb05ba64947b67258a0e83d7899 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff880fb05ba64947b67258a0e83d7899()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_50f55f3e86834431b5bd7ad895b3dd77 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_50f55f3e86834431b5bd7ad895b3dd77()
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

      private sealed class MTHD_0f0674c38c68477e9a250f5a4c73d55c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f0674c38c68477e9a250f5a4c73d55c()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_37c9f84a4cce42b5be7cdea511a1ed97 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_37c9f84a4cce42b5be7cdea511a1ed97()
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

      private sealed class MTHD_327bb79b363f4ff7819ba37c772a68e9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_327bb79b363f4ff7819ba37c772a68e9()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_5e69d9c2de584b9b9899b7806a0faba1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e69d9c2de584b9b9899b7806a0faba1()
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

      private sealed class MTHD_fd5ef61c2865454caee638d6ecd91caf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd5ef61c2865454caee638d6ecd91caf()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_2df0558dbacf4203880f9b65d700bc85 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2df0558dbacf4203880f9b65d700bc85()
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

      private sealed class MTHD_2a6488ed1a1245508abe485f25e54a08 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a6488ed1a1245508abe485f25e54a08()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_9d09b52e4c9a4e91869305a20d78cda0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d09b52e4c9a4e91869305a20d78cda0()
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

      private sealed class MTHD_1a604a0ba80748d6a1d716e8b640e0d2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a604a0ba80748d6a1d716e8b640e0d2()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_80fe785f2dac4208b4c3f6dc8b66bcea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_80fe785f2dac4208b4c3f6dc8b66bcea()
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

      private sealed class MTHD_487e9441ae7946b7b5ece82a133f02df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_487e9441ae7946b7b5ece82a133f02df()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_469b496bd5fc4bb8952c82ee7af4bdef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_469b496bd5fc4bb8952c82ee7af4bdef()
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

      private sealed class MTHD_a0dce5b03c9042c18155e0742f22c150 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a0dce5b03c9042c18155e0742f22c150()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_26e1a13bf24943cd8db15e44a279fda2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_26e1a13bf24943cd8db15e44a279fda2()
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

      private sealed class MTHD_0b6ff3e328254342916f48b83d9bc416 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b6ff3e328254342916f48b83d9bc416()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_8a9bb632f5344c5ba6b0658b4f29081e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a9bb632f5344c5ba6b0658b4f29081e()
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

      private sealed class MTHD_6414600b73e94f9a96aa0dab4c5666fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6414600b73e94f9a96aa0dab4c5666fd()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_964730ab611943fcba74cae3766fc7b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_964730ab611943fcba74cae3766fc7b6()
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

      private sealed class MTHD_0864c19752ab4bc897ecf591e7637ea5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0864c19752ab4bc897ecf591e7637ea5()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_dfe9e25265664f608e39e24accd6617e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dfe9e25265664f608e39e24accd6617e()
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

      private sealed class MTHD_ed9c73555e7245d59985ab657524b023 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed9c73555e7245d59985ab657524b023()
        {
          this.Initialize("get_onClick2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick2;
        }
      }

      private sealed class MTHD_15c4e62598b04099bcc0ffb6c0c793a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15c4e62598b04099bcc0ffb6c0c793a3()
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

      private sealed class MTHD_e66f46fc59344d58a1b394177705a1fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e66f46fc59344d58a1b394177705a1fd()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_9d5ec9b3173a4cd5a0ea82a96e512e34 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d5ec9b3173a4cd5a0ea82a96e512e34()
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

      private sealed class MTHD_3aa2fb882abc413490534e82068c44ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3aa2fb882abc413490534e82068c44ee()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color2;
        }
      }

      private sealed class MTHD_d5ae1cb29e4c4c74b113ef91e86aeb9c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d5ae1cb29e4c4c74b113ef91e86aeb9c()
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

      private sealed class MTHD_bdb4c029d4e146cab980554574dee449 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bdb4c029d4e146cab980554574dee449()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_e041fa539adc4640a97052b607f9ebdd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e041fa539adc4640a97052b607f9ebdd()
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

      private sealed class MTHD_1003304aa23f4f62af9e2ee5335440ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1003304aa23f4f62af9e2ee5335440ab()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_89824b349fe147bea404ad461fcec1ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_89824b349fe147bea404ad461fcec1ed()
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

      private sealed class MTHD_05064b00f937450b8246b19089a1f1d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_05064b00f937450b8246b19089a1f1d3()
        {
          this.Initialize("get_textColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor2;
        }
      }

      private sealed class MTHD_caab124c4ced4ea79bfa52984560960c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_caab124c4ced4ea79bfa52984560960c()
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

      private sealed class MTHD_cc8e7c6ea1c443878dd6794dcf8092da : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cc8e7c6ea1c443878dd6794dcf8092da()
        {
          this.Initialize("get_highlightColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor;
        }
      }

      private sealed class MTHD_d50b471aa3094517968ea33ac7f8b6e9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d50b471aa3094517968ea33ac7f8b6e9()
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

      private sealed class MTHD_48a41ec58c4f4adc8b62696170de403a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_48a41ec58c4f4adc8b62696170de403a()
        {
          this.Initialize("get_highlightColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor2;
        }
      }

      private sealed class MTHD_b25c81cef27b4f8eaec7384b7098ac85 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b25c81cef27b4f8eaec7384b7098ac85()
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

      private sealed class MTHD_fcddcccffea446c8a47fd396ea44ecbb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fcddcccffea446c8a47fd396ea44ecbb()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_d7a7f1ab68b447eca4b8a4ba901cfdca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d7a7f1ab68b447eca4b8a4ba901cfdca()
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

      private sealed class MTHD_6e33ff692dde4322b3e0bcad64940c39 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e33ff692dde4322b3e0bcad64940c39()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_89fe13eb10904d58b3c9c52a462d8492 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_89fe13eb10904d58b3c9c52a462d8492()
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

      private sealed class MTHD_ab4291d80cc4440f8b2852350ba82626 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab4291d80cc4440f8b2852350ba82626()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_aa1f13ed01954e07999e891e6b0e79f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa1f13ed01954e07999e891e6b0e79f2()
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

      private sealed class MTHD_62d919c65d0441e6b74255dd4aceab28 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_62d919c65d0441e6b74255dd4aceab28()
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

      private sealed class MTHD_a4b044ef2c41452d945adf6ba3094fbe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a4b044ef2c41452d945adf6ba3094fbe()
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

      private sealed class MTHD_396721c869ed4133991d57ddea75e2db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_396721c869ed4133991d57ddea75e2db()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_bf9b0d293f6f4f5595132e48b1d8e449 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf9b0d293f6f4f5595132e48b1d8e449()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9814db25e0984a47a7437c4baf75adbc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9814db25e0984a47a7437c4baf75adbc()
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

      private sealed class MTHD_85ba063668d848819c9303fedeae07f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85ba063668d848819c9303fedeae07f7()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_a6a212c6a00d41d2b03ca00135d1881b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6a212c6a00d41d2b03ca00135d1881b()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_2c86a2d85512438ca65ec1894f39706b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c86a2d85512438ca65ec1894f39706b()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_092837797a5c47809043d16a29f8d83f : HardwiredMemberDescriptor
      {
        internal PROP_092837797a5c47809043d16a29f8d83f()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_96a012495ad34605879c47ad13ceddaa : HardwiredMemberDescriptor
      {
        internal PROP_96a012495ad34605879c47ad13ceddaa()
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

      private sealed class PROP_543d6f4566124b1a8aebe6ebcd499bd7 : HardwiredMemberDescriptor
      {
        internal PROP_543d6f4566124b1a8aebe6ebcd499bd7()
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

      private sealed class PROP_8ec84a756cfb42308ca258850dab7741 : HardwiredMemberDescriptor
      {
        internal PROP_8ec84a756cfb42308ca258850dab7741()
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

      private sealed class PROP_cd4c4f624dab43a18f13eb1206aeadfe : HardwiredMemberDescriptor
      {
        internal PROP_cd4c4f624dab43a18f13eb1206aeadfe()
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

      private sealed class PROP_36357fe48d7f43488794bfceb8e3b3ad : HardwiredMemberDescriptor
      {
        internal PROP_36357fe48d7f43488794bfceb8e3b3ad()
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

      private sealed class PROP_ea01e8fd98b64a1ab560aa900288a339 : HardwiredMemberDescriptor
      {
        internal PROP_ea01e8fd98b64a1ab560aa900288a339()
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

      private sealed class PROP_e4c7d9ddf095462baccdfb6faeae35e5 : HardwiredMemberDescriptor
      {
        internal PROP_e4c7d9ddf095462baccdfb6faeae35e5()
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

      private sealed class PROP_deb841a9a1ef474fabf7f76c31fc41ee : HardwiredMemberDescriptor
      {
        internal PROP_deb841a9a1ef474fabf7f76c31fc41ee()
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

      private sealed class PROP_cc7d1e4b1a1f44d39d0f2539aab31c06 : HardwiredMemberDescriptor
      {
        internal PROP_cc7d1e4b1a1f44d39d0f2539aab31c06()
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

      private sealed class PROP_cd7d23748028433ea3cf05258b540472 : HardwiredMemberDescriptor
      {
        internal PROP_cd7d23748028433ea3cf05258b540472()
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

      private sealed class PROP_e761537a7ea94973b466faf86edf1a8c : HardwiredMemberDescriptor
      {
        internal PROP_e761537a7ea94973b466faf86edf1a8c()
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

      private sealed class PROP_f65f694829c546fd83323fcf97968bd0 : HardwiredMemberDescriptor
      {
        internal PROP_f65f694829c546fd83323fcf97968bd0()
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

      private sealed class PROP_5719a047672e4b02bd902aae92c2b2a9 : HardwiredMemberDescriptor
      {
        internal PROP_5719a047672e4b02bd902aae92c2b2a9()
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

      private sealed class PROP_2c5525d9b96f42878784cd17a994524d : HardwiredMemberDescriptor
      {
        internal PROP_2c5525d9b96f42878784cd17a994524d()
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

      private sealed class PROP_4bc34815411b4728b47ed2023c0ceeac : HardwiredMemberDescriptor
      {
        internal PROP_4bc34815411b4728b47ed2023c0ceeac()
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

      private sealed class PROP_5a029b89f04c48e99eac5deed47d61a3 : HardwiredMemberDescriptor
      {
        internal PROP_5a029b89f04c48e99eac5deed47d61a3()
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

      private sealed class PROP_3d718f3a2fda413394e25dc2eac2f960 : HardwiredMemberDescriptor
      {
        internal PROP_3d718f3a2fda413394e25dc2eac2f960()
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

      private sealed class PROP_63a7e92ab9ff4684be1dce5b5d799753 : HardwiredMemberDescriptor
      {
        internal PROP_63a7e92ab9ff4684be1dce5b5d799753()
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

      private sealed class PROP_d7294cbedefc446cbd8b78c83338dd18 : HardwiredMemberDescriptor
      {
        internal PROP_d7294cbedefc446cbd8b78c83338dd18()
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

      private sealed class PROP_6cfe4f487317452889035297268d8fae : HardwiredMemberDescriptor
      {
        internal PROP_6cfe4f487317452889035297268d8fae()
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

      private sealed class PROP_b166a4fb1b6e497087866b03ad64b4ab : HardwiredMemberDescriptor
      {
        internal PROP_b166a4fb1b6e497087866b03ad64b4ab()
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

      private sealed class PROP_270a39618f7e4b8abf91cd52b2b0cf10 : HardwiredMemberDescriptor
      {
        internal PROP_270a39618f7e4b8abf91cd52b2b0cf10()
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

      private sealed class PROP_20638aadfc2f4cfabde55f7b63820e7a : HardwiredMemberDescriptor
      {
        internal PROP_20638aadfc2f4cfabde55f7b63820e7a()
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

      private sealed class PROP_2039d078dce9405a9ad4b651b41195fd : HardwiredMemberDescriptor
      {
        internal PROP_2039d078dce9405a9ad4b651b41195fd()
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

      private sealed class FLDV_fd12577a55c943cbbf5fd44754f75670 : HardwiredMemberDescriptor
      {
        internal FLDV_fd12577a55c943cbbf5fd44754f75670()
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

      private sealed class FLDV_5c00ddaeb0244d48afebeb4b3fa18ad7 : HardwiredMemberDescriptor
      {
        internal FLDV_5c00ddaeb0244d48afebeb4b3fa18ad7()
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

      private sealed class FLDV_243b028d9dd64f2894b6facb077b68f6 : HardwiredMemberDescriptor
      {
        internal FLDV_243b028d9dd64f2894b6facb077b68f6()
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

    private sealed class TYPE_05fedb75fd87449da28f81efe931ef73 : HardwiredUserDataDescriptor
    {
      internal TYPE_05fedb75fd87449da28f81efe931ef73()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_05fedb75fd87449da28f81efe931ef73.MTHD_981a5d9e05b14117a36102a2519c4ce4()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_05fedb75fd87449da28f81efe931ef73.MTHD_3ae8c44fbd5647d18be80d2dd7cc937a()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_05fedb75fd87449da28f81efe931ef73.MTHD_18b8b6714a24499d93de2c0f0db6af67()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_05fedb75fd87449da28f81efe931ef73.MTHD_7a65f82b1f744b119431cf029f872c2b()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_05fedb75fd87449da28f81efe931ef73.MTHD_9ed7f7944bf0497c8279c8f94d3cd097()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_05fedb75fd87449da28f81efe931ef73.MTHD_3d8047af6ed34078a075fe218202cdec()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_05fedb75fd87449da28f81efe931ef73.FLDV_d3a9e1c4eb5647a3a47b8847e17b39ae());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_05fedb75fd87449da28f81efe931ef73.FLDV_71d4c227f33740889330e7ab5c3a2228());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_05fedb75fd87449da28f81efe931ef73.FLDV_abe8452ac7e64785aa6ed77f1fd54e58());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_05fedb75fd87449da28f81efe931ef73.FLDV_786810e299724549b671849570da0028());
      }

      private sealed class MTHD_981a5d9e05b14117a36102a2519c4ce4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_981a5d9e05b14117a36102a2519c4ce4()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_3ae8c44fbd5647d18be80d2dd7cc937a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3ae8c44fbd5647d18be80d2dd7cc937a()
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

      private sealed class MTHD_18b8b6714a24499d93de2c0f0db6af67 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_18b8b6714a24499d93de2c0f0db6af67()
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

      private sealed class MTHD_7a65f82b1f744b119431cf029f872c2b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a65f82b1f744b119431cf029f872c2b()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_9ed7f7944bf0497c8279c8f94d3cd097 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ed7f7944bf0497c8279c8f94d3cd097()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_3d8047af6ed34078a075fe218202cdec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d8047af6ed34078a075fe218202cdec()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_d3a9e1c4eb5647a3a47b8847e17b39ae : HardwiredMemberDescriptor
      {
        internal FLDV_d3a9e1c4eb5647a3a47b8847e17b39ae()
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

      private sealed class FLDV_71d4c227f33740889330e7ab5c3a2228 : HardwiredMemberDescriptor
      {
        internal FLDV_71d4c227f33740889330e7ab5c3a2228()
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

      private sealed class FLDV_abe8452ac7e64785aa6ed77f1fd54e58 : HardwiredMemberDescriptor
      {
        internal FLDV_abe8452ac7e64785aa6ed77f1fd54e58()
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

      private sealed class FLDV_786810e299724549b671849570da0028 : HardwiredMemberDescriptor
      {
        internal FLDV_786810e299724549b671849570da0028()
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

    private sealed class TYPE_f7dc59a35b0b4c6181317f823b5850bf : HardwiredUserDataDescriptor
    {
      internal TYPE_f7dc59a35b0b4c6181317f823b5850bf()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f7dc59a35b0b4c6181317f823b5850bf.MTHD_d80389f6763e4015bac50f2691e72e4c()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f7dc59a35b0b4c6181317f823b5850bf.MTHD_025af6e9c3a141348cbea2f170b121b6()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f7dc59a35b0b4c6181317f823b5850bf.MTHD_c46b526d26db4bd7915e598f328d975a()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f7dc59a35b0b4c6181317f823b5850bf.MTHD_98c760b4a05c4f848204d41fc24f7350()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f7dc59a35b0b4c6181317f823b5850bf.MTHD_25514e4eaced40eca9e76e3484731cea()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_f7dc59a35b0b4c6181317f823b5850bf.FLDV_8366ed275a444256aa9429a9f0f4bfb7());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_f7dc59a35b0b4c6181317f823b5850bf.FLDV_587ae99d3665480886483f7a30d9acbd());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_f7dc59a35b0b4c6181317f823b5850bf.FLDV_360c7c16662e46f38aeb3d87ea886b6b());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_f7dc59a35b0b4c6181317f823b5850bf.FLDV_4162c6be34df45289875b6613a8612e1());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_f7dc59a35b0b4c6181317f823b5850bf.FLDV_54ddb2c6b8bb4f84aebd83b1a6d6f8c8());
      }

      private sealed class MTHD_d80389f6763e4015bac50f2691e72e4c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d80389f6763e4015bac50f2691e72e4c()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_025af6e9c3a141348cbea2f170b121b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_025af6e9c3a141348cbea2f170b121b6()
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

      private sealed class MTHD_c46b526d26db4bd7915e598f328d975a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c46b526d26db4bd7915e598f328d975a()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_98c760b4a05c4f848204d41fc24f7350 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_98c760b4a05c4f848204d41fc24f7350()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_25514e4eaced40eca9e76e3484731cea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_25514e4eaced40eca9e76e3484731cea()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_8366ed275a444256aa9429a9f0f4bfb7 : HardwiredMemberDescriptor
      {
        internal FLDV_8366ed275a444256aa9429a9f0f4bfb7()
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

      private sealed class FLDV_587ae99d3665480886483f7a30d9acbd : HardwiredMemberDescriptor
      {
        internal FLDV_587ae99d3665480886483f7a30d9acbd()
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

      private sealed class FLDV_360c7c16662e46f38aeb3d87ea886b6b : HardwiredMemberDescriptor
      {
        internal FLDV_360c7c16662e46f38aeb3d87ea886b6b()
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

      private sealed class FLDV_4162c6be34df45289875b6613a8612e1 : HardwiredMemberDescriptor
      {
        internal FLDV_4162c6be34df45289875b6613a8612e1()
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

      private sealed class FLDV_54ddb2c6b8bb4f84aebd83b1a6d6f8c8 : HardwiredMemberDescriptor
      {
        internal FLDV_54ddb2c6b8bb4f84aebd83b1a6d6f8c8()
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

    private sealed class TYPE_0c1177ad192d46bda19dddc92b469a06 : HardwiredUserDataDescriptor
    {
      internal TYPE_0c1177ad192d46bda19dddc92b469a06()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0c1177ad192d46bda19dddc92b469a06.MTHD_fe794c7c8b9b496089c0ff4d6b4f3f7c()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0c1177ad192d46bda19dddc92b469a06.MTHD_6e5b3e48325f4f4f83576002576c7187()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0c1177ad192d46bda19dddc92b469a06.MTHD_62405204add04caa8e7d5aae6b17d224()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0c1177ad192d46bda19dddc92b469a06.MTHD_332bf58889cf4bea94fe66f7f0c0206b()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0c1177ad192d46bda19dddc92b469a06.MTHD_69f9cd728804434a93879c03a2a95763()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0c1177ad192d46bda19dddc92b469a06.MTHD_64c7c2ade42740aeb5085ea10d4edbc8()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0c1177ad192d46bda19dddc92b469a06.MTHD_9e2c47f09e614d3ebeb77354e571a3f9()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0c1177ad192d46bda19dddc92b469a06.MTHD_bbc371f823fa4e23a6b06447a4ab32ec()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0c1177ad192d46bda19dddc92b469a06.MTHD_3f2cd5cf09ca4a2e9d0e091e87842f66()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0c1177ad192d46bda19dddc92b469a06.MTHD_2b633e28637e494087fb9c823af7a590()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0c1177ad192d46bda19dddc92b469a06.MTHD_56e90b6083ce4881bb06097421b5a28e()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0c1177ad192d46bda19dddc92b469a06.MTHD_740ae473ce514aef91357c5d371f79b3()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0c1177ad192d46bda19dddc92b469a06.MTHD_ea81dcd12ede41ce84a3712f4bb14489()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_0c1177ad192d46bda19dddc92b469a06.FLDV_d8701f90680c498698678c7beee8b7bf());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_0c1177ad192d46bda19dddc92b469a06.FLDV_97ebcc1d19b748b8978955868a345f9a());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_0c1177ad192d46bda19dddc92b469a06.FLDV_852b755ebce34d65afc8b1a2217a0180());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_0c1177ad192d46bda19dddc92b469a06.FLDV_aef44cae428342398ae0885988f68541());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_0c1177ad192d46bda19dddc92b469a06.FLDV_1d59ac2f9f0d4904b3660b77d0cc8bd9());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_0c1177ad192d46bda19dddc92b469a06.FLDV_8a44e76c1cf747509e9ce24746724b3b());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_0c1177ad192d46bda19dddc92b469a06.FLDV_19adcdfe8a964e748af8a8981a206c6f());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_0c1177ad192d46bda19dddc92b469a06.FLDV_cc7a7e15dcf6427b9b9d4becac93f6ff());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_0c1177ad192d46bda19dddc92b469a06.DVAL_5f852a38515142738911d0085f7ec729());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_0c1177ad192d46bda19dddc92b469a06.DVAL_cb95070828d349a683c4dbe4b060b157());
      }

      private sealed class MTHD_fe794c7c8b9b496089c0ff4d6b4f3f7c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fe794c7c8b9b496089c0ff4d6b4f3f7c()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_6e5b3e48325f4f4f83576002576c7187 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e5b3e48325f4f4f83576002576c7187()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_62405204add04caa8e7d5aae6b17d224 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_62405204add04caa8e7d5aae6b17d224()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_332bf58889cf4bea94fe66f7f0c0206b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_332bf58889cf4bea94fe66f7f0c0206b()
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

      private sealed class MTHD_69f9cd728804434a93879c03a2a95763 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69f9cd728804434a93879c03a2a95763()
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

      private sealed class MTHD_64c7c2ade42740aeb5085ea10d4edbc8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_64c7c2ade42740aeb5085ea10d4edbc8()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_9e2c47f09e614d3ebeb77354e571a3f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e2c47f09e614d3ebeb77354e571a3f9()
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

      private sealed class MTHD_bbc371f823fa4e23a6b06447a4ab32ec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bbc371f823fa4e23a6b06447a4ab32ec()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_3f2cd5cf09ca4a2e9d0e091e87842f66 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f2cd5cf09ca4a2e9d0e091e87842f66()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_2b633e28637e494087fb9c823af7a590 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b633e28637e494087fb9c823af7a590()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_56e90b6083ce4881bb06097421b5a28e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_56e90b6083ce4881bb06097421b5a28e()
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

      private sealed class MTHD_740ae473ce514aef91357c5d371f79b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_740ae473ce514aef91357c5d371f79b3()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_ea81dcd12ede41ce84a3712f4bb14489 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea81dcd12ede41ce84a3712f4bb14489()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_d8701f90680c498698678c7beee8b7bf : HardwiredMemberDescriptor
      {
        internal FLDV_d8701f90680c498698678c7beee8b7bf()
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

      private sealed class FLDV_97ebcc1d19b748b8978955868a345f9a : HardwiredMemberDescriptor
      {
        internal FLDV_97ebcc1d19b748b8978955868a345f9a()
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

      private sealed class FLDV_852b755ebce34d65afc8b1a2217a0180 : HardwiredMemberDescriptor
      {
        internal FLDV_852b755ebce34d65afc8b1a2217a0180()
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

      private sealed class FLDV_aef44cae428342398ae0885988f68541 : HardwiredMemberDescriptor
      {
        internal FLDV_aef44cae428342398ae0885988f68541()
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

      private sealed class FLDV_1d59ac2f9f0d4904b3660b77d0cc8bd9 : HardwiredMemberDescriptor
      {
        internal FLDV_1d59ac2f9f0d4904b3660b77d0cc8bd9()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_8a44e76c1cf747509e9ce24746724b3b : HardwiredMemberDescriptor
      {
        internal FLDV_8a44e76c1cf747509e9ce24746724b3b()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_19adcdfe8a964e748af8a8981a206c6f : HardwiredMemberDescriptor
      {
        internal FLDV_19adcdfe8a964e748af8a8981a206c6f()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_cc7a7e15dcf6427b9b9d4becac93f6ff : HardwiredMemberDescriptor
      {
        internal FLDV_cc7a7e15dcf6427b9b9d4becac93f6ff()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_5f852a38515142738911d0085f7ec729 : DynValueMemberDescriptor
      {
        internal DVAL_5f852a38515142738911d0085f7ec729()
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

      private sealed class DVAL_cb95070828d349a683c4dbe4b060b157 : DynValueMemberDescriptor
      {
        internal DVAL_cb95070828d349a683c4dbe4b060b157()
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

    private sealed class TYPE_0030ba8836eb4b8d8b22c18a3e1f6c7e : HardwiredUserDataDescriptor
    {
      internal TYPE_0030ba8836eb4b8d8b22c18a3e1f6c7e()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0030ba8836eb4b8d8b22c18a3e1f6c7e.MTHD_618f980d78b24c40a4efa196f219c0d3()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0030ba8836eb4b8d8b22c18a3e1f6c7e.MTHD_c4dafcc6193f4b7a854a083fc2b2f558()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0030ba8836eb4b8d8b22c18a3e1f6c7e.MTHD_6aa86f7ffd224545a94e73a9029b7aee(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0030ba8836eb4b8d8b22c18a3e1f6c7e.MTHD_c6cd4f399cc3445d8cacaf00979c3ef0()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0030ba8836eb4b8d8b22c18a3e1f6c7e.MTHD_e42622b611c04943971dfc8c6995100a(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0030ba8836eb4b8d8b22c18a3e1f6c7e.MTHD_17fdd9a6297e4845bab367c3dcdb869f()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0030ba8836eb4b8d8b22c18a3e1f6c7e.MTHD_4afa7900409e4d17a8365b27ff818042()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0030ba8836eb4b8d8b22c18a3e1f6c7e.MTHD_bcecdf6878b8462ababfbbd8f63baa18()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0030ba8836eb4b8d8b22c18a3e1f6c7e.MTHD_584e72690ac947e99f7e5a22b5edb81f()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0030ba8836eb4b8d8b22c18a3e1f6c7e.MTHD_73ca778a9bfb40fe84ebb094ab128408()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_0030ba8836eb4b8d8b22c18a3e1f6c7e.FLDV_75aa416be0d94336b69c8acda2f34328());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_0030ba8836eb4b8d8b22c18a3e1f6c7e.FLDV_1e6a310c1fb2456da5a40d18c49e9b9f());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_0030ba8836eb4b8d8b22c18a3e1f6c7e.FLDV_704976b1eb834ec59a97c2dd7821f5ca());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_0030ba8836eb4b8d8b22c18a3e1f6c7e.FLDV_24fbad53ea8e4135b96e2e0f3bd6b50f());
        this.AddMember("white", (IMemberDescriptor) new Bridge.TYPE_0030ba8836eb4b8d8b22c18a3e1f6c7e.FLDV_469bf14a713b429ea76e0a1ca94e1bee());
      }

      private sealed class MTHD_618f980d78b24c40a4efa196f219c0d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_618f980d78b24c40a4efa196f219c0d3()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_c4dafcc6193f4b7a854a083fc2b2f558 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c4dafcc6193f4b7a854a083fc2b2f558()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_6aa86f7ffd224545a94e73a9029b7aee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6aa86f7ffd224545a94e73a9029b7aee()
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

      private sealed class MTHD_c6cd4f399cc3445d8cacaf00979c3ef0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c6cd4f399cc3445d8cacaf00979c3ef0()
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

      private sealed class MTHD_e42622b611c04943971dfc8c6995100a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e42622b611c04943971dfc8c6995100a()
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

      private sealed class MTHD_17fdd9a6297e4845bab367c3dcdb869f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_17fdd9a6297e4845bab367c3dcdb869f()
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

      private sealed class MTHD_4afa7900409e4d17a8365b27ff818042 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4afa7900409e4d17a8365b27ff818042()
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

      private sealed class MTHD_bcecdf6878b8462ababfbbd8f63baa18 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bcecdf6878b8462ababfbbd8f63baa18()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_584e72690ac947e99f7e5a22b5edb81f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_584e72690ac947e99f7e5a22b5edb81f()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_73ca778a9bfb40fe84ebb094ab128408 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_73ca778a9bfb40fe84ebb094ab128408()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_75aa416be0d94336b69c8acda2f34328 : HardwiredMemberDescriptor
      {
        internal FLDV_75aa416be0d94336b69c8acda2f34328()
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

      private sealed class FLDV_1e6a310c1fb2456da5a40d18c49e9b9f : HardwiredMemberDescriptor
      {
        internal FLDV_1e6a310c1fb2456da5a40d18c49e9b9f()
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

      private sealed class FLDV_704976b1eb834ec59a97c2dd7821f5ca : HardwiredMemberDescriptor
      {
        internal FLDV_704976b1eb834ec59a97c2dd7821f5ca()
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

      private sealed class FLDV_24fbad53ea8e4135b96e2e0f3bd6b50f : HardwiredMemberDescriptor
      {
        internal FLDV_24fbad53ea8e4135b96e2e0f3bd6b50f()
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

      private sealed class FLDV_469bf14a713b429ea76e0a1ca94e1bee : HardwiredMemberDescriptor
      {
        internal FLDV_469bf14a713b429ea76e0a1ca94e1bee()
          : base(typeof (LuaColor), "white", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) LuaColor.white;
        }
      }
    }

    private sealed class TYPE_4225a3a0f14948c7953d5fd88feba5c5 : HardwiredUserDataDescriptor
    {
      internal TYPE_4225a3a0f14948c7953d5fd88feba5c5()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4225a3a0f14948c7953d5fd88feba5c5.MTHD_3c52f03fabc54c0fbd7354fe643b45b1()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4225a3a0f14948c7953d5fd88feba5c5.MTHD_51b1a360d05e478e93d956da49005d2e()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4225a3a0f14948c7953d5fd88feba5c5.MTHD_dc17a21e468545a58616c8cf57e53073()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4225a3a0f14948c7953d5fd88feba5c5.MTHD_d730e0afaa6142b8acfb9fdb5f7ca2f4()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4225a3a0f14948c7953d5fd88feba5c5.MTHD_58cab6952278438d80ccc84b27ca5acd()
        }));
      }

      private sealed class MTHD_3c52f03fabc54c0fbd7354fe643b45b1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3c52f03fabc54c0fbd7354fe643b45b1()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_51b1a360d05e478e93d956da49005d2e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_51b1a360d05e478e93d956da49005d2e()
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

      private sealed class MTHD_dc17a21e468545a58616c8cf57e53073 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc17a21e468545a58616c8cf57e53073()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_d730e0afaa6142b8acfb9fdb5f7ca2f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d730e0afaa6142b8acfb9fdb5f7ca2f4()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_58cab6952278438d80ccc84b27ca5acd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_58cab6952278438d80ccc84b27ca5acd()
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
