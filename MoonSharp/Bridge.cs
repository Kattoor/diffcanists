
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
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_379e67fc3b7e4b22953ec7f58e453574());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_3869c76032424406bab57466cd8d7d2c());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_18bff3ec7b8b47549d4f7b2f089f6641());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_73fc8bc721184e89819087aca094616f());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_e2368d9071ad4cab82f343e0a8019349());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_11cc3705a3854fd7ad9219d27d884494());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_c37042b702114e4aacdc64f80a557e2f());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_dce94f764cc345178f83ae90598d8590());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_644a3fc67e7544b586ef49d10e7c47b9());
    }

    private sealed class TYPE_28b350ca5e244a75b06f208ea61619de : HardwiredUserDataDescriptor
    {
      internal TYPE_28b350ca5e244a75b06f208ea61619de()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_30369ea12b6445dd905cad2f3b9249cb()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_b1ee96fc5f7344898d619b8ac4884102()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_50032d5a05ee4e7a99a046d58a5b5baf()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_aa7700b14d9248089786b2476d91ae9c()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_c7e894fa8d6b4d11b9a75eaa04c1533b()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_2947510b3803489ebb3f79bea6a712dc()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_cc133465ad664ecea31f79d7a8439b43()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_900ae631627247f2a3095fc2bb75a8b7()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_0b34ce4517814dc49de648d8fb17f8ca()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_31840a46a45042de9ec3d5010919b66d()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_7612bf564c964d60bba2f4310b61a537()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_3b89ec41851c4a218423486ff51963f8()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_1bf6ac4cf06641c29c2b9f43a9ea5514()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_4799caf3b4944bb79d94855eb115d8bb()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_33dfd695d47344e79c93b1fa70f603cd()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_98bad64658f24ab68221a3c97543aff3()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_e9a08011f62743e0afa79843825758f3()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_49f443f5a4bc4fae91e035e4b4ba3c8d()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_3bf3c925cfe843fe8abb11a0f005a0f3()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_8165de2912b6432fab2b79cfc195f11a()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_798bfd2bf5884a529da6d02d1556b509()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_caa6317e6b8a44a3a5320724ced8fa85()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_dcdc4c2735424b8fbf3c4ef493dbea73()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_85b584d27751482887706ad273a9c096()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_8860349d0bbc4d1488d9b6f7eb63bdb1()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_365d0195bcc147af9a4fb99c6ee70e78()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_dacec8ab28e1499b91e49e0625fd79ee()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_ea50acdcfeb9402b86537069f14b5ff5()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_87fc15504197412a968fc7e43f1b7fb4()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_27752be22a924f3091b804272f1e57ff()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_8e4f5461a6194662986d89526a0e3741()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_e77b75f27c2c4783a32f62bc9d30cb4b()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_bad6eaae4f9748a68d16043138e85c57()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_8b2ea3196a3d4aba98dfb89fac09c621()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_bfdb83d260a447219016c5b852defc28()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_3c256230d16f4125ab035aa1979edec1()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_7b1ee146f8d04ceca6475b68b9357ddb()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_cb7b88a9ae2a41c2ba1dce4445a75d58()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_6a8cb939cf764a619fcfccaff39ac913()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_acb161bf67fe43cf88b6fd0cc063d753()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_5191ddb4730c46569e56ec6cba2bd7db()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_7ed0e0f8cd1349c08c5723fe9b1f829c()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_4d8fd18ea03d4501ab7638defd9cc6fa()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_8d2b3e2924ba4fa196898f24e4cf3e06()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_396cb453c35d42e0b5f7552e67a448cb()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_982210cc88b0444ba17aa2355833470a()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_1258e2634f9e4fdfb57f5c9254977d08()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_5e8c8663ca394f3f98baa3238c22d233()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_1c23532db7a04b81ae53e79ba9f2f62f()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_3f774adee72342029529d7d47e04a6cf()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_8b1577e6fc4d41c98112081289625b72()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_59c5ea4276974bc09570fc9fd22276e3()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_d9b3f9d79ec34226b7d6d70554ab29ad()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_d7b1f1aae893434d93bed3f8692e9400()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_1596e67e25a9441591d86933c686bab8()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_146793c3744347e39b1bfb492ad974f1()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_b40439a3bbcf41c6a21585e3ab2f0503()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_1b0c0b19a1684edd8143a461652d3954()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_74d8a11f77144894839a25fb239cbf32()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_5eb7c9f625d84171bf4b462c8f873c22()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_13323d8fa9b746f0adaceb10f93b4daa()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_1bb1edfc54a04c5a9010cbcb9fde4346()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_426ac41211514849a2d1c42c95f71027()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_19846b13607d47bb97bf7e48603d97cf()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_70308c50b7eb41f29023a6575c810b37()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_17b65fc905474ed9943865643028d7be()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_41c19e017f2b48b5a4ac2344c7ebd12d()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_48d9c98c77da4a1193398db1934468bd()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_93f8ed137d8a4d1a8a220ee08c41a23c()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_df22f8d953784d798ce681f19575f68b()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_40b7f1cfdf36438d99e9c8c6f051da93()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_f5f718ab118d4d5ea2e51bf25816d4a2()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_2aa9264046d24ccc84dcbb530bf378bb()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_51ef04d47b28433cbcabf331db6cd91a()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_944db75fcea849d7bbdea2729e581462()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_10d4f646bcba4b309774a11b62f7c9ae()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_263f9714074741378e1f8b82a9b91ecd()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_85303e1af4654727aba43f7959f56895()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_5c0ddf59a00c4193923bce55b8837639()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_e907c6a947944b2cadf7772ec873444a()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_782fdec3180c458b8acfadac136fae70()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_c76df40e54d3417b943275657b27ac5c()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_ec0370e115c041159db467622649a723()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_b5a4bb00277e4e5c8c66b449b1bbc924()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_37cca65d082f462c8cab9cc408ec4f0e()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_0f779125dfb64f5d94abdf5f4e405637()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_babe178e3ba447caaf6b4bd3acf79acd()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_0b9493c0a2924b06b5d9d62df2156cf1()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_69cf6e9067504cb19cd6e0e7e11f6f1b()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_d23900aed78d4745b52b3a6d50c37379()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_4f1c8d4cbda544959514472b3ac6adbf()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_c5f97535dd844508b7822cd237c0a40e()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_fb2958e2f22f4f878c1fb8b18bf3a03b()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_10481fccbd6548e08f34cfdd5c39a32d()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_80b13310afa44da9ba8260f2124c9014()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_771770c64ec74d29856087a724be8d30()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.MTHD_fa839432396b41f5ae2cb02c54eba44e()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_7f8f91e6ce964389b7215be044b3f824());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_a7f81df9d175459cac291b7795d59a24());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_56c1e83fb72f473eb3b4c60c3df2ac5d());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_4bcdae750a664edc97cb046831f1f9db());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_a15e8411abff42ac88fd4c5223da729c());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_cfbba2d15a5b4813bd9e2a664783bbe0());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_a62a1a55a4d542949d151a43e5d26c5e());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_c06877e20b8544bebb4fd237b0841362());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_5e1e2c1aa8324bfdb6b238b8367f237a());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_02e66f2657974f7eb1b4b027eb92b759());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_96d59eefb7624b7b859c3e524b434c16());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_f984ce5af8674c4e89aa0eed85653de7());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_0aff51ed6056442fbf8e7d1506dd3b22());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_7ee9734c26c3435f9c5aa948f6968cd2());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_fed69cc5e95c44fba9cf99ec7b3a6db7());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_57f89a577f554f3ebd04e142582dacc8());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_a6b088e36acc4fcaa954353c0788772b());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_e7ef261915ea48c2807d89c3a127ecd3());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_9be685f1b52c480f90306137bc17cb5d());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_8e5ae8f8c7fd4fb0b2c91b79e37545bf());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_56af9a10293f4f0f9b1de777c7eb24ba());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_24945db3f3254db6bc3babc1fb6d4845());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_0b975db5c7eb4747905bacbd09d58912());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_587caff6d5ce484881a965e5faa64536());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_d5f0265bbaeb4969bbb2aaeb5f2a4989());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_08d56dffce6149e3b9619f944e14b43d());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_ecb0ce66aa334a95adb7b4aea46bdd1a());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_05db619400f34312a66c7fd9e1056829());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_9a58106b3b474d8891457bacd4bf8ac8());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_a1c86300d7904a7d99284933e759eba6());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_a570b4b1157f4e0186ffc8ab191d448d());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_28b350ca5e244a75b06f208ea61619de.PROP_a1fce744e76f43a0beb24a7efc395268());
      }

      private sealed class MTHD_30369ea12b6445dd905cad2f3b9249cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_30369ea12b6445dd905cad2f3b9249cb()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_b1ee96fc5f7344898d619b8ac4884102 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b1ee96fc5f7344898d619b8ac4884102()
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

      private sealed class MTHD_50032d5a05ee4e7a99a046d58a5b5baf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_50032d5a05ee4e7a99a046d58a5b5baf()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_aa7700b14d9248089786b2476d91ae9c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa7700b14d9248089786b2476d91ae9c()
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

      private sealed class MTHD_c7e894fa8d6b4d11b9a75eaa04c1533b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c7e894fa8d6b4d11b9a75eaa04c1533b()
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

      private sealed class MTHD_2947510b3803489ebb3f79bea6a712dc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2947510b3803489ebb3f79bea6a712dc()
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

      private sealed class MTHD_cc133465ad664ecea31f79d7a8439b43 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cc133465ad664ecea31f79d7a8439b43()
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

      private sealed class MTHD_900ae631627247f2a3095fc2bb75a8b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_900ae631627247f2a3095fc2bb75a8b7()
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

      private sealed class MTHD_0b34ce4517814dc49de648d8fb17f8ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b34ce4517814dc49de648d8fb17f8ca()
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

      private sealed class MTHD_31840a46a45042de9ec3d5010919b66d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_31840a46a45042de9ec3d5010919b66d()
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

      private sealed class MTHD_7612bf564c964d60bba2f4310b61a537 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7612bf564c964d60bba2f4310b61a537()
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

      private sealed class MTHD_3b89ec41851c4a218423486ff51963f8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3b89ec41851c4a218423486ff51963f8()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_1bf6ac4cf06641c29c2b9f43a9ea5514 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1bf6ac4cf06641c29c2b9f43a9ea5514()
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

      private sealed class MTHD_4799caf3b4944bb79d94855eb115d8bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4799caf3b4944bb79d94855eb115d8bb()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_33dfd695d47344e79c93b1fa70f603cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_33dfd695d47344e79c93b1fa70f603cd()
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

      private sealed class MTHD_98bad64658f24ab68221a3c97543aff3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_98bad64658f24ab68221a3c97543aff3()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_e9a08011f62743e0afa79843825758f3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e9a08011f62743e0afa79843825758f3()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_49f443f5a4bc4fae91e035e4b4ba3c8d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49f443f5a4bc4fae91e035e4b4ba3c8d()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_3bf3c925cfe843fe8abb11a0f005a0f3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3bf3c925cfe843fe8abb11a0f005a0f3()
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

      private sealed class MTHD_8165de2912b6432fab2b79cfc195f11a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8165de2912b6432fab2b79cfc195f11a()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_798bfd2bf5884a529da6d02d1556b509 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_798bfd2bf5884a529da6d02d1556b509()
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

      private sealed class MTHD_caa6317e6b8a44a3a5320724ced8fa85 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_caa6317e6b8a44a3a5320724ced8fa85()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_dcdc4c2735424b8fbf3c4ef493dbea73 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dcdc4c2735424b8fbf3c4ef493dbea73()
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

      private sealed class MTHD_85b584d27751482887706ad273a9c096 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85b584d27751482887706ad273a9c096()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_8860349d0bbc4d1488d9b6f7eb63bdb1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8860349d0bbc4d1488d9b6f7eb63bdb1()
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

      private sealed class MTHD_365d0195bcc147af9a4fb99c6ee70e78 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_365d0195bcc147af9a4fb99c6ee70e78()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_dacec8ab28e1499b91e49e0625fd79ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dacec8ab28e1499b91e49e0625fd79ee()
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

      private sealed class MTHD_ea50acdcfeb9402b86537069f14b5ff5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea50acdcfeb9402b86537069f14b5ff5()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_87fc15504197412a968fc7e43f1b7fb4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_87fc15504197412a968fc7e43f1b7fb4()
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

      private sealed class MTHD_27752be22a924f3091b804272f1e57ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_27752be22a924f3091b804272f1e57ff()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_8e4f5461a6194662986d89526a0e3741 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e4f5461a6194662986d89526a0e3741()
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

      private sealed class MTHD_e77b75f27c2c4783a32f62bc9d30cb4b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e77b75f27c2c4783a32f62bc9d30cb4b()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_bad6eaae4f9748a68d16043138e85c57 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bad6eaae4f9748a68d16043138e85c57()
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

      private sealed class MTHD_8b2ea3196a3d4aba98dfb89fac09c621 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b2ea3196a3d4aba98dfb89fac09c621()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_bfdb83d260a447219016c5b852defc28 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bfdb83d260a447219016c5b852defc28()
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

      private sealed class MTHD_3c256230d16f4125ab035aa1979edec1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3c256230d16f4125ab035aa1979edec1()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_7b1ee146f8d04ceca6475b68b9357ddb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b1ee146f8d04ceca6475b68b9357ddb()
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

      private sealed class MTHD_cb7b88a9ae2a41c2ba1dce4445a75d58 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cb7b88a9ae2a41c2ba1dce4445a75d58()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_6a8cb939cf764a619fcfccaff39ac913 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6a8cb939cf764a619fcfccaff39ac913()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_acb161bf67fe43cf88b6fd0cc063d753 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_acb161bf67fe43cf88b6fd0cc063d753()
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

      private sealed class MTHD_5191ddb4730c46569e56ec6cba2bd7db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5191ddb4730c46569e56ec6cba2bd7db()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_7ed0e0f8cd1349c08c5723fe9b1f829c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ed0e0f8cd1349c08c5723fe9b1f829c()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_4d8fd18ea03d4501ab7638defd9cc6fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d8fd18ea03d4501ab7638defd9cc6fa()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_8d2b3e2924ba4fa196898f24e4cf3e06 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8d2b3e2924ba4fa196898f24e4cf3e06()
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

      private sealed class MTHD_396cb453c35d42e0b5f7552e67a448cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_396cb453c35d42e0b5f7552e67a448cb()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_982210cc88b0444ba17aa2355833470a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_982210cc88b0444ba17aa2355833470a()
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

      private sealed class MTHD_1258e2634f9e4fdfb57f5c9254977d08 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1258e2634f9e4fdfb57f5c9254977d08()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_5e8c8663ca394f3f98baa3238c22d233 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e8c8663ca394f3f98baa3238c22d233()
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

      private sealed class MTHD_1c23532db7a04b81ae53e79ba9f2f62f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c23532db7a04b81ae53e79ba9f2f62f()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_3f774adee72342029529d7d47e04a6cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f774adee72342029529d7d47e04a6cf()
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

      private sealed class MTHD_8b1577e6fc4d41c98112081289625b72 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b1577e6fc4d41c98112081289625b72()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_59c5ea4276974bc09570fc9fd22276e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_59c5ea4276974bc09570fc9fd22276e3()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_d9b3f9d79ec34226b7d6d70554ab29ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d9b3f9d79ec34226b7d6d70554ab29ad()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_d7b1f1aae893434d93bed3f8692e9400 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d7b1f1aae893434d93bed3f8692e9400()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_1596e67e25a9441591d86933c686bab8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1596e67e25a9441591d86933c686bab8()
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

      private sealed class MTHD_146793c3744347e39b1bfb492ad974f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_146793c3744347e39b1bfb492ad974f1()
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

      private sealed class MTHD_b40439a3bbcf41c6a21585e3ab2f0503 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b40439a3bbcf41c6a21585e3ab2f0503()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_1b0c0b19a1684edd8143a461652d3954 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1b0c0b19a1684edd8143a461652d3954()
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

      private sealed class MTHD_74d8a11f77144894839a25fb239cbf32 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74d8a11f77144894839a25fb239cbf32()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_5eb7c9f625d84171bf4b462c8f873c22 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5eb7c9f625d84171bf4b462c8f873c22()
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

      private sealed class MTHD_13323d8fa9b746f0adaceb10f93b4daa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_13323d8fa9b746f0adaceb10f93b4daa()
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

      private sealed class MTHD_1bb1edfc54a04c5a9010cbcb9fde4346 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1bb1edfc54a04c5a9010cbcb9fde4346()
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

      private sealed class MTHD_426ac41211514849a2d1c42c95f71027 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_426ac41211514849a2d1c42c95f71027()
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

      private sealed class MTHD_19846b13607d47bb97bf7e48603d97cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_19846b13607d47bb97bf7e48603d97cf()
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

      private sealed class MTHD_70308c50b7eb41f29023a6575c810b37 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70308c50b7eb41f29023a6575c810b37()
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

      private sealed class MTHD_17b65fc905474ed9943865643028d7be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_17b65fc905474ed9943865643028d7be()
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

      private sealed class MTHD_41c19e017f2b48b5a4ac2344c7ebd12d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41c19e017f2b48b5a4ac2344c7ebd12d()
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

      private sealed class MTHD_48d9c98c77da4a1193398db1934468bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_48d9c98c77da4a1193398db1934468bd()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_93f8ed137d8a4d1a8a220ee08c41a23c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93f8ed137d8a4d1a8a220ee08c41a23c()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_df22f8d953784d798ce681f19575f68b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_df22f8d953784d798ce681f19575f68b()
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

      private sealed class MTHD_40b7f1cfdf36438d99e9c8c6f051da93 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_40b7f1cfdf36438d99e9c8c6f051da93()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_f5f718ab118d4d5ea2e51bf25816d4a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f5f718ab118d4d5ea2e51bf25816d4a2()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_2aa9264046d24ccc84dcbb530bf378bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2aa9264046d24ccc84dcbb530bf378bb()
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

      private sealed class MTHD_51ef04d47b28433cbcabf331db6cd91a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_51ef04d47b28433cbcabf331db6cd91a()
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

      private sealed class MTHD_944db75fcea849d7bbdea2729e581462 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_944db75fcea849d7bbdea2729e581462()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_10d4f646bcba4b309774a11b62f7c9ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_10d4f646bcba4b309774a11b62f7c9ae()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_263f9714074741378e1f8b82a9b91ecd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_263f9714074741378e1f8b82a9b91ecd()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_85303e1af4654727aba43f7959f56895 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85303e1af4654727aba43f7959f56895()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_5c0ddf59a00c4193923bce55b8837639 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c0ddf59a00c4193923bce55b8837639()
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

      private sealed class MTHD_e907c6a947944b2cadf7772ec873444a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e907c6a947944b2cadf7772ec873444a()
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

      private sealed class MTHD_782fdec3180c458b8acfadac136fae70 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_782fdec3180c458b8acfadac136fae70()
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

      private sealed class MTHD_c76df40e54d3417b943275657b27ac5c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c76df40e54d3417b943275657b27ac5c()
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

      private sealed class MTHD_ec0370e115c041159db467622649a723 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec0370e115c041159db467622649a723()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_b5a4bb00277e4e5c8c66b449b1bbc924 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b5a4bb00277e4e5c8c66b449b1bbc924()
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

      private sealed class MTHD_37cca65d082f462c8cab9cc408ec4f0e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_37cca65d082f462c8cab9cc408ec4f0e()
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

      private sealed class MTHD_0f779125dfb64f5d94abdf5f4e405637 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f779125dfb64f5d94abdf5f4e405637()
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

      private sealed class MTHD_babe178e3ba447caaf6b4bd3acf79acd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_babe178e3ba447caaf6b4bd3acf79acd()
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

      private sealed class MTHD_0b9493c0a2924b06b5d9d62df2156cf1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b9493c0a2924b06b5d9d62df2156cf1()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_69cf6e9067504cb19cd6e0e7e11f6f1b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69cf6e9067504cb19cd6e0e7e11f6f1b()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_d23900aed78d4745b52b3a6d50c37379 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d23900aed78d4745b52b3a6d50c37379()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_4f1c8d4cbda544959514472b3ac6adbf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4f1c8d4cbda544959514472b3ac6adbf()
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

      private sealed class MTHD_c5f97535dd844508b7822cd237c0a40e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c5f97535dd844508b7822cd237c0a40e()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_fb2958e2f22f4f878c1fb8b18bf3a03b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb2958e2f22f4f878c1fb8b18bf3a03b()
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

      private sealed class MTHD_10481fccbd6548e08f34cfdd5c39a32d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_10481fccbd6548e08f34cfdd5c39a32d()
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

      private sealed class MTHD_80b13310afa44da9ba8260f2124c9014 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_80b13310afa44da9ba8260f2124c9014()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_771770c64ec74d29856087a724be8d30 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_771770c64ec74d29856087a724be8d30()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_fa839432396b41f5ae2cb02c54eba44e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa839432396b41f5ae2cb02c54eba44e()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_7f8f91e6ce964389b7215be044b3f824 : HardwiredMemberDescriptor
      {
        internal PROP_7f8f91e6ce964389b7215be044b3f824()
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

      private sealed class PROP_a7f81df9d175459cac291b7795d59a24 : HardwiredMemberDescriptor
      {
        internal PROP_a7f81df9d175459cac291b7795d59a24()
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

      private sealed class PROP_56c1e83fb72f473eb3b4c60c3df2ac5d : HardwiredMemberDescriptor
      {
        internal PROP_56c1e83fb72f473eb3b4c60c3df2ac5d()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_4bcdae750a664edc97cb046831f1f9db : HardwiredMemberDescriptor
      {
        internal PROP_4bcdae750a664edc97cb046831f1f9db()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_a15e8411abff42ac88fd4c5223da729c : HardwiredMemberDescriptor
      {
        internal PROP_a15e8411abff42ac88fd4c5223da729c()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_cfbba2d15a5b4813bd9e2a664783bbe0 : HardwiredMemberDescriptor
      {
        internal PROP_cfbba2d15a5b4813bd9e2a664783bbe0()
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

      private sealed class PROP_a62a1a55a4d542949d151a43e5d26c5e : HardwiredMemberDescriptor
      {
        internal PROP_a62a1a55a4d542949d151a43e5d26c5e()
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

      private sealed class PROP_c06877e20b8544bebb4fd237b0841362 : HardwiredMemberDescriptor
      {
        internal PROP_c06877e20b8544bebb4fd237b0841362()
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

      private sealed class PROP_5e1e2c1aa8324bfdb6b238b8367f237a : HardwiredMemberDescriptor
      {
        internal PROP_5e1e2c1aa8324bfdb6b238b8367f237a()
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

      private sealed class PROP_02e66f2657974f7eb1b4b027eb92b759 : HardwiredMemberDescriptor
      {
        internal PROP_02e66f2657974f7eb1b4b027eb92b759()
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

      private sealed class PROP_96d59eefb7624b7b859c3e524b434c16 : HardwiredMemberDescriptor
      {
        internal PROP_96d59eefb7624b7b859c3e524b434c16()
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

      private sealed class PROP_f984ce5af8674c4e89aa0eed85653de7 : HardwiredMemberDescriptor
      {
        internal PROP_f984ce5af8674c4e89aa0eed85653de7()
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

      private sealed class PROP_0aff51ed6056442fbf8e7d1506dd3b22 : HardwiredMemberDescriptor
      {
        internal PROP_0aff51ed6056442fbf8e7d1506dd3b22()
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

      private sealed class PROP_7ee9734c26c3435f9c5aa948f6968cd2 : HardwiredMemberDescriptor
      {
        internal PROP_7ee9734c26c3435f9c5aa948f6968cd2()
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

      private sealed class PROP_fed69cc5e95c44fba9cf99ec7b3a6db7 : HardwiredMemberDescriptor
      {
        internal PROP_fed69cc5e95c44fba9cf99ec7b3a6db7()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_57f89a577f554f3ebd04e142582dacc8 : HardwiredMemberDescriptor
      {
        internal PROP_57f89a577f554f3ebd04e142582dacc8()
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

      private sealed class PROP_a6b088e36acc4fcaa954353c0788772b : HardwiredMemberDescriptor
      {
        internal PROP_a6b088e36acc4fcaa954353c0788772b()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_e7ef261915ea48c2807d89c3a127ecd3 : HardwiredMemberDescriptor
      {
        internal PROP_e7ef261915ea48c2807d89c3a127ecd3()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_9be685f1b52c480f90306137bc17cb5d : HardwiredMemberDescriptor
      {
        internal PROP_9be685f1b52c480f90306137bc17cb5d()
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

      private sealed class PROP_8e5ae8f8c7fd4fb0b2c91b79e37545bf : HardwiredMemberDescriptor
      {
        internal PROP_8e5ae8f8c7fd4fb0b2c91b79e37545bf()
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

      private sealed class PROP_56af9a10293f4f0f9b1de777c7eb24ba : HardwiredMemberDescriptor
      {
        internal PROP_56af9a10293f4f0f9b1de777c7eb24ba()
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

      private sealed class PROP_24945db3f3254db6bc3babc1fb6d4845 : HardwiredMemberDescriptor
      {
        internal PROP_24945db3f3254db6bc3babc1fb6d4845()
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

      private sealed class PROP_0b975db5c7eb4747905bacbd09d58912 : HardwiredMemberDescriptor
      {
        internal PROP_0b975db5c7eb4747905bacbd09d58912()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_587caff6d5ce484881a965e5faa64536 : HardwiredMemberDescriptor
      {
        internal PROP_587caff6d5ce484881a965e5faa64536()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_d5f0265bbaeb4969bbb2aaeb5f2a4989 : HardwiredMemberDescriptor
      {
        internal PROP_d5f0265bbaeb4969bbb2aaeb5f2a4989()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_08d56dffce6149e3b9619f944e14b43d : HardwiredMemberDescriptor
      {
        internal PROP_08d56dffce6149e3b9619f944e14b43d()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_ecb0ce66aa334a95adb7b4aea46bdd1a : HardwiredMemberDescriptor
      {
        internal PROP_ecb0ce66aa334a95adb7b4aea46bdd1a()
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

      private sealed class PROP_05db619400f34312a66c7fd9e1056829 : HardwiredMemberDescriptor
      {
        internal PROP_05db619400f34312a66c7fd9e1056829()
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

      private sealed class PROP_9a58106b3b474d8891457bacd4bf8ac8 : HardwiredMemberDescriptor
      {
        internal PROP_9a58106b3b474d8891457bacd4bf8ac8()
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

      private sealed class PROP_a1c86300d7904a7d99284933e759eba6 : HardwiredMemberDescriptor
      {
        internal PROP_a1c86300d7904a7d99284933e759eba6()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_a570b4b1157f4e0186ffc8ab191d448d : HardwiredMemberDescriptor
      {
        internal PROP_a570b4b1157f4e0186ffc8ab191d448d()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_a1fce744e76f43a0beb24a7efc395268 : HardwiredMemberDescriptor
      {
        internal PROP_a1fce744e76f43a0beb24a7efc395268()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_379e67fc3b7e4b22953ec7f58e453574 : HardwiredUserDataDescriptor
    {
      internal TYPE_379e67fc3b7e4b22953ec7f58e453574()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_379e67fc3b7e4b22953ec7f58e453574.MTHD_38a248abeb6c4e79bfa9a33069d2ea44()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_379e67fc3b7e4b22953ec7f58e453574.MTHD_e0e76d9dd7124b0587a74dcaf90456f8()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_379e67fc3b7e4b22953ec7f58e453574.MTHD_6da5cba770414b5984a46843dbee40fe()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_379e67fc3b7e4b22953ec7f58e453574.MTHD_ac2f41726ce74d58904b75f194a854f1()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_379e67fc3b7e4b22953ec7f58e453574.MTHD_3dc95b795c6f444c96567e071fad8daa()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_379e67fc3b7e4b22953ec7f58e453574.MTHD_c07a55bca18d470ab319846194f81d12()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_379e67fc3b7e4b22953ec7f58e453574.MTHD_572ca2ac90714d80b82374a691343fcc()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_379e67fc3b7e4b22953ec7f58e453574.MTHD_367d9bbe9e0c41c0ad6e23366ab4987f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_379e67fc3b7e4b22953ec7f58e453574.MTHD_12cc71e5d3474be09937ec0ce2b23a07()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_379e67fc3b7e4b22953ec7f58e453574.MTHD_ec9c8c6482b44901a7cf4cbfbd8d3c30()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_379e67fc3b7e4b22953ec7f58e453574.MTHD_6fa9745d916c4a92a61b19861df0c323()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_379e67fc3b7e4b22953ec7f58e453574.MTHD_a1e48d00fe9c49d089953321dbe87198()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_379e67fc3b7e4b22953ec7f58e453574.PROP_7c9226c2b66146cd9a6cfe43cd614537());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_379e67fc3b7e4b22953ec7f58e453574.PROP_db19ff6158a04a3ab0f121e08cecec74());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_379e67fc3b7e4b22953ec7f58e453574.PROP_87d470de6c4d44f29c0bf93b20a3ab41());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_379e67fc3b7e4b22953ec7f58e453574.PROP_9a8508fd25ae41c8a8ab295b17f3a805());
      }

      private sealed class MTHD_38a248abeb6c4e79bfa9a33069d2ea44 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_38a248abeb6c4e79bfa9a33069d2ea44()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_e0e76d9dd7124b0587a74dcaf90456f8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e0e76d9dd7124b0587a74dcaf90456f8()
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

      private sealed class MTHD_6da5cba770414b5984a46843dbee40fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6da5cba770414b5984a46843dbee40fe()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_ac2f41726ce74d58904b75f194a854f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac2f41726ce74d58904b75f194a854f1()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_3dc95b795c6f444c96567e071fad8daa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3dc95b795c6f444c96567e071fad8daa()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_c07a55bca18d470ab319846194f81d12 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c07a55bca18d470ab319846194f81d12()
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

      private sealed class MTHD_572ca2ac90714d80b82374a691343fcc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_572ca2ac90714d80b82374a691343fcc()
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

      private sealed class MTHD_367d9bbe9e0c41c0ad6e23366ab4987f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_367d9bbe9e0c41c0ad6e23366ab4987f()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_12cc71e5d3474be09937ec0ce2b23a07 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_12cc71e5d3474be09937ec0ce2b23a07()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_ec9c8c6482b44901a7cf4cbfbd8d3c30 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec9c8c6482b44901a7cf4cbfbd8d3c30()
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

      private sealed class MTHD_6fa9745d916c4a92a61b19861df0c323 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6fa9745d916c4a92a61b19861df0c323()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_a1e48d00fe9c49d089953321dbe87198 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1e48d00fe9c49d089953321dbe87198()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_7c9226c2b66146cd9a6cfe43cd614537 : HardwiredMemberDescriptor
      {
        internal PROP_7c9226c2b66146cd9a6cfe43cd614537()
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

      private sealed class PROP_db19ff6158a04a3ab0f121e08cecec74 : HardwiredMemberDescriptor
      {
        internal PROP_db19ff6158a04a3ab0f121e08cecec74()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_87d470de6c4d44f29c0bf93b20a3ab41 : HardwiredMemberDescriptor
      {
        internal PROP_87d470de6c4d44f29c0bf93b20a3ab41()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_9a8508fd25ae41c8a8ab295b17f3a805 : HardwiredMemberDescriptor
      {
        internal PROP_9a8508fd25ae41c8a8ab295b17f3a805()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_b9a96aaa3ea345169c85269a014e1dcd : HardwiredUserDataDescriptor
    {
      internal TYPE_b9a96aaa3ea345169c85269a014e1dcd()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_7c45ecc2da0a4c03a82d3f548eb9cec0()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_abba1e80c92c43b6a1f33989e4cc0b8f()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_a5eef31dcd074c10b72d6e08ecf4701b()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_84380011feec4584980520de78cce530()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_e6106f2f655b4316ae9dc114baa310db()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_786ad186aad34a7d8df8f61a69bd9d51()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_f4e0665227cf49f1808b738b0b2b05ac()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_ed1069260ef843d79e00cde276251be2()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_fe00b77302f14fc790f94ff742eeb15f()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_1d00035bb1a84d23b3fccdac30d11367()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_ae792c7100fb4deabfdc75cd65687328()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_75ce02c597984330b11e69cabea40d92()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_3af41750448f4f9eae8ca7ce2ca466c5()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_f4d1eeaaff8349d7a2cd1b199c2aeafc()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_b7b9ef040104402b867b62609c2c0322()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_235251f6749749e3be65eb2fd89eaaf4()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_42d1b63537e940d38fee60542f067996()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_423034cedb42471896354c077eca7223()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_2939248657204b23b9c4901beb3f3ade()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_71ede6f203ea46c18b75a135793c335a()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_37d14a7100e24f0994ce06cd04543669()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_1b5dc8c8aa2e4542b63b9ddd93170c12()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_d1fd5a170722438ab751f00b8214263e()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_ae34cdcc47f34944af0b76ebe173f4dd()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_5384fba983ee4d8ebbef35508453b017()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_0bf38df91f574467ac2ce4d22bc84c71()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_861e216679d24f57ad587104b99db92e()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_ad8adefa11db438594b492f008a791bb()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_2e4da42a7500478e9526448c4f967107()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_331fb1ed201b4d55b73bf894eeb6eaae()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_532130d0a3e84f87bcbfcad408b64fb6()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_404d49dd1991478391805598e519a9c6()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_23ae9747d332434288ba8c2dcce96500()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_2587a81597474073b6013fefa26e87ac()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_94dcb04cf45f4a62adbe4764fa253c36()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_4e99a9ecb02643b48b5d13d89b6a4192()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_465e224d9f864139ba8bc714579164c2()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_0613562c17b345ba9edb0e4db67a7419()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_c98dd3a69d564564a3f9b79e759a3637()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_2fde0ea52de844aabe4505c4fee455ec()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_5a3c310f68914e5d89e6c959d5e66da7()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_f3311422bf8d47788186e9f3f1696895()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_74c8276d798e41ad9e328c5242916cdb()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_2a8c2eb80d0d4aa099274b30d29e4f3c()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_cfc7e92f29fe480d8fcfdcfa00235622()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_dbbc7ae5321848c18cb922b077c4bd19()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_9890bdbbe5be4868824a19ddd57df1e6()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_e14cda3378984fe0bd1148e4c4be04ba()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_074561ce3dd345b19931b9d11bef4545()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_e856ec20ee794cd1a8ae339765a43b8e()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_ee6d4b9a36f34406a698092d036f9bdc()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_7dc2b8076aa047c3bc752098e43c9ff8()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_70ff287ad888475ea98433b5ae7ae07a()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_52bc30ed715c4b868720d33e511f86a8()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_4e411d684384416e84c76466751a3dae()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_7ee8632d52ad48d293d79c0386486403()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_4c4289a5d0e8466393eeadaf1e358e9e()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_a3d8cff04d524963ad254ab4e9a3f180()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_f73e4b5351654b2e95f5d8acb5e72586()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_84a64d9a6f534162809f735479d167b1()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_263297ad2e664d9889b405239a6f5cf1()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_f04943f2c5dc489d90f5d4742eeec4fb()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_9fc837a2ac5848dfa1792c35c92ae77e()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_cac28f1751f14811b839fbbd91d8c9b4(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_c921056dc4bb45888014beb39f5fe454()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_524fa2c5dafb4c498bfb5a03a492e003(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_0d9102c6b29f43d6b863ef959a871d4d()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_064816d625074a8996966e0efbb24d7e()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_f4d2d051fb264291b1e0aa06100ff1ca()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_f26bd8bd697240a488d8928ceca7496b(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_e2b27e02f8b34d03b396ce20955f08af()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_8216d607a5ed44ba9ebfdbb981c0576f()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_bf6bd297ba98445b9c9b42c7bf56239c()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_4079ada34be14e71870c16022e0c5f42()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_268b4a5c69114f8ba2e3911911621292()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_822662e5f3d2455d9ae4e490c4a575ee()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_4028cee10b1f45faa25a4d624fb66233()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_0748a0a3ffcf4036a0624d62a1b56070()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_9d676780ccb04c42aa228b74e8684efe()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_23b0d7bce3d04d3294e020dddc6e3c66(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_08ee1e908f9f4e34ad93cbc6600d918a()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_ae0a6ba261804a698442d976480c9bd1(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_1f62eebcff0046bfa9867aa7ddb69e66()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_b9ee9ec01d22446cba7b871bd59daf3b()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_d82565c580c74ddcae6f1b00f1a00158()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_fc43299b3d45495a95d75961e870c23f()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_67a2c80bc30644f1a7504dba985ab569()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_72e18aa81e6e470d9b793eacd873f6fc()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.MTHD_3ab41ab82872405bb1b0b605f124c8db()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_b70d24917bc748e183022707cd5b5e92());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_5f71829911ac4220b8332e3bb8daf7e0());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_114eea7b8bcd46e0b2d8ac8596ac5efa());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_f52f348f8e5141b2bc820dc0eca8cf9f());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_1d56193760fd43f69ffdb5b2db75216b());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_a2d4144f0b0045008630e0008e09d175());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_89c8004263fe4323a6d84242662e2811());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_3b9c5d586acd48bd90a1bd3e62f5e271());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_e8118b6a965940dfac2e7d066be6de2d());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_c2e7c836005045298311162e2576df62());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_61c327c96b4a4d6f9f26e25739ec2d68());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_9993d7442e3346ef8fbcb4e1a4005d63());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_b2b25e6a372849429dd6ba658bbeeb1d());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_87f760ff46904c1fac01039bcdb64b55());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_acede9f91c3344df975c2a7996c9ceb7());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_642a4076f93445bcaeb36446ceb961e5());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_f008765054e44d1eb0a361c11da2bba9());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_a2cd189fcffc4284bd3d4107a9ee5de5());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_4a98e89b50324d4e8d4bd40b6a757edd());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_6e9167f659bc40a3b97ed8691f263bd6());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_cad938b927284ed0963fbcc0bf59a029());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_d5c0f5be227047e283a2128a36fd3c63());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_18c4870959f9498280b134c109763299());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_0addbae2022847aca95f92bba95953a6());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_ddf8ae69932e45af83f3d0b943900e39());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_5488f2d880e543138e9a19cd06418414());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_2e0b2359f46046339beae3bc602b1730());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_ed1da39402c649ec935b7c09cc3621a3());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_d953c351ed6941b89d973d9488fd2e51());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_af76cc6c4c6c475e96aee849d34f5c4b());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_089b3305ff0a4271abde6d2cc326d9db());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_ddbbfd67776244caa01f6018cfd398d4());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_b9a96aaa3ea345169c85269a014e1dcd.PROP_9ac13ac9d173468f9f002bf659d41ed5());
      }

      private sealed class MTHD_7c45ecc2da0a4c03a82d3f548eb9cec0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7c45ecc2da0a4c03a82d3f548eb9cec0()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_abba1e80c92c43b6a1f33989e4cc0b8f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_abba1e80c92c43b6a1f33989e4cc0b8f()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_a5eef31dcd074c10b72d6e08ecf4701b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a5eef31dcd074c10b72d6e08ecf4701b()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_84380011feec4584980520de78cce530 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84380011feec4584980520de78cce530()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_e6106f2f655b4316ae9dc114baa310db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e6106f2f655b4316ae9dc114baa310db()
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

      private sealed class MTHD_786ad186aad34a7d8df8f61a69bd9d51 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_786ad186aad34a7d8df8f61a69bd9d51()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_f4e0665227cf49f1808b738b0b2b05ac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4e0665227cf49f1808b738b0b2b05ac()
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

      private sealed class MTHD_ed1069260ef843d79e00cde276251be2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed1069260ef843d79e00cde276251be2()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_fe00b77302f14fc790f94ff742eeb15f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fe00b77302f14fc790f94ff742eeb15f()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_1d00035bb1a84d23b3fccdac30d11367 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d00035bb1a84d23b3fccdac30d11367()
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

      private sealed class MTHD_ae792c7100fb4deabfdc75cd65687328 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae792c7100fb4deabfdc75cd65687328()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_75ce02c597984330b11e69cabea40d92 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75ce02c597984330b11e69cabea40d92()
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

      private sealed class MTHD_3af41750448f4f9eae8ca7ce2ca466c5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3af41750448f4f9eae8ca7ce2ca466c5()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_f4d1eeaaff8349d7a2cd1b199c2aeafc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4d1eeaaff8349d7a2cd1b199c2aeafc()
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

      private sealed class MTHD_b7b9ef040104402b867b62609c2c0322 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b7b9ef040104402b867b62609c2c0322()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_235251f6749749e3be65eb2fd89eaaf4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_235251f6749749e3be65eb2fd89eaaf4()
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

      private sealed class MTHD_42d1b63537e940d38fee60542f067996 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42d1b63537e940d38fee60542f067996()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_423034cedb42471896354c077eca7223 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_423034cedb42471896354c077eca7223()
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

      private sealed class MTHD_2939248657204b23b9c4901beb3f3ade : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2939248657204b23b9c4901beb3f3ade()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_71ede6f203ea46c18b75a135793c335a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_71ede6f203ea46c18b75a135793c335a()
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

      private sealed class MTHD_37d14a7100e24f0994ce06cd04543669 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_37d14a7100e24f0994ce06cd04543669()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_1b5dc8c8aa2e4542b63b9ddd93170c12 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1b5dc8c8aa2e4542b63b9ddd93170c12()
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

      private sealed class MTHD_d1fd5a170722438ab751f00b8214263e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1fd5a170722438ab751f00b8214263e()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_ae34cdcc47f34944af0b76ebe173f4dd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae34cdcc47f34944af0b76ebe173f4dd()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_5384fba983ee4d8ebbef35508453b017 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5384fba983ee4d8ebbef35508453b017()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_0bf38df91f574467ac2ce4d22bc84c71 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0bf38df91f574467ac2ce4d22bc84c71()
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

      private sealed class MTHD_861e216679d24f57ad587104b99db92e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_861e216679d24f57ad587104b99db92e()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_ad8adefa11db438594b492f008a791bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ad8adefa11db438594b492f008a791bb()
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

      private sealed class MTHD_2e4da42a7500478e9526448c4f967107 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2e4da42a7500478e9526448c4f967107()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_331fb1ed201b4d55b73bf894eeb6eaae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_331fb1ed201b4d55b73bf894eeb6eaae()
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

      private sealed class MTHD_532130d0a3e84f87bcbfcad408b64fb6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_532130d0a3e84f87bcbfcad408b64fb6()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_404d49dd1991478391805598e519a9c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_404d49dd1991478391805598e519a9c6()
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

      private sealed class MTHD_23ae9747d332434288ba8c2dcce96500 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_23ae9747d332434288ba8c2dcce96500()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_2587a81597474073b6013fefa26e87ac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2587a81597474073b6013fefa26e87ac()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_94dcb04cf45f4a62adbe4764fa253c36 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_94dcb04cf45f4a62adbe4764fa253c36()
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

      private sealed class MTHD_4e99a9ecb02643b48b5d13d89b6a4192 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e99a9ecb02643b48b5d13d89b6a4192()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_465e224d9f864139ba8bc714579164c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_465e224d9f864139ba8bc714579164c2()
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

      private sealed class MTHD_0613562c17b345ba9edb0e4db67a7419 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0613562c17b345ba9edb0e4db67a7419()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_c98dd3a69d564564a3f9b79e759a3637 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c98dd3a69d564564a3f9b79e759a3637()
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

      private sealed class MTHD_2fde0ea52de844aabe4505c4fee455ec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2fde0ea52de844aabe4505c4fee455ec()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_5a3c310f68914e5d89e6c959d5e66da7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5a3c310f68914e5d89e6c959d5e66da7()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_f3311422bf8d47788186e9f3f1696895 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f3311422bf8d47788186e9f3f1696895()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_74c8276d798e41ad9e328c5242916cdb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74c8276d798e41ad9e328c5242916cdb()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_2a8c2eb80d0d4aa099274b30d29e4f3c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a8c2eb80d0d4aa099274b30d29e4f3c()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_cfc7e92f29fe480d8fcfdcfa00235622 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cfc7e92f29fe480d8fcfdcfa00235622()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_dbbc7ae5321848c18cb922b077c4bd19 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dbbc7ae5321848c18cb922b077c4bd19()
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

      private sealed class MTHD_9890bdbbe5be4868824a19ddd57df1e6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9890bdbbe5be4868824a19ddd57df1e6()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_e14cda3378984fe0bd1148e4c4be04ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e14cda3378984fe0bd1148e4c4be04ba()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_074561ce3dd345b19931b9d11bef4545 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_074561ce3dd345b19931b9d11bef4545()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_e856ec20ee794cd1a8ae339765a43b8e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e856ec20ee794cd1a8ae339765a43b8e()
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

      private sealed class MTHD_ee6d4b9a36f34406a698092d036f9bdc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee6d4b9a36f34406a698092d036f9bdc()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_7dc2b8076aa047c3bc752098e43c9ff8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7dc2b8076aa047c3bc752098e43c9ff8()
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

      private sealed class MTHD_70ff287ad888475ea98433b5ae7ae07a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70ff287ad888475ea98433b5ae7ae07a()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_52bc30ed715c4b868720d33e511f86a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52bc30ed715c4b868720d33e511f86a8()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_4e411d684384416e84c76466751a3dae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e411d684384416e84c76466751a3dae()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_7ee8632d52ad48d293d79c0386486403 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ee8632d52ad48d293d79c0386486403()
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

      private sealed class MTHD_4c4289a5d0e8466393eeadaf1e358e9e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c4289a5d0e8466393eeadaf1e358e9e()
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

      private sealed class MTHD_a3d8cff04d524963ad254ab4e9a3f180 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a3d8cff04d524963ad254ab4e9a3f180()
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

      private sealed class MTHD_f73e4b5351654b2e95f5d8acb5e72586 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f73e4b5351654b2e95f5d8acb5e72586()
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

      private sealed class MTHD_84a64d9a6f534162809f735479d167b1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_84a64d9a6f534162809f735479d167b1()
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

      private sealed class MTHD_263297ad2e664d9889b405239a6f5cf1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_263297ad2e664d9889b405239a6f5cf1()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_f04943f2c5dc489d90f5d4742eeec4fb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f04943f2c5dc489d90f5d4742eeec4fb()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_9fc837a2ac5848dfa1792c35c92ae77e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9fc837a2ac5848dfa1792c35c92ae77e()
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

      private sealed class MTHD_cac28f1751f14811b839fbbd91d8c9b4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cac28f1751f14811b839fbbd91d8c9b4()
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

      private sealed class MTHD_c921056dc4bb45888014beb39f5fe454 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c921056dc4bb45888014beb39f5fe454()
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

      private sealed class MTHD_524fa2c5dafb4c498bfb5a03a492e003 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_524fa2c5dafb4c498bfb5a03a492e003()
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

      private sealed class MTHD_0d9102c6b29f43d6b863ef959a871d4d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d9102c6b29f43d6b863ef959a871d4d()
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

      private sealed class MTHD_064816d625074a8996966e0efbb24d7e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_064816d625074a8996966e0efbb24d7e()
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

      private sealed class MTHD_f4d2d051fb264291b1e0aa06100ff1ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4d2d051fb264291b1e0aa06100ff1ca()
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

      private sealed class MTHD_f26bd8bd697240a488d8928ceca7496b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f26bd8bd697240a488d8928ceca7496b()
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

      private sealed class MTHD_e2b27e02f8b34d03b396ce20955f08af : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e2b27e02f8b34d03b396ce20955f08af()
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

      private sealed class MTHD_8216d607a5ed44ba9ebfdbb981c0576f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8216d607a5ed44ba9ebfdbb981c0576f()
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

      private sealed class MTHD_bf6bd297ba98445b9c9b42c7bf56239c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf6bd297ba98445b9c9b42c7bf56239c()
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

      private sealed class MTHD_4079ada34be14e71870c16022e0c5f42 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4079ada34be14e71870c16022e0c5f42()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_268b4a5c69114f8ba2e3911911621292 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_268b4a5c69114f8ba2e3911911621292()
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

      private sealed class MTHD_822662e5f3d2455d9ae4e490c4a575ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_822662e5f3d2455d9ae4e490c4a575ee()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_4028cee10b1f45faa25a4d624fb66233 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4028cee10b1f45faa25a4d624fb66233()
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

      private sealed class MTHD_0748a0a3ffcf4036a0624d62a1b56070 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0748a0a3ffcf4036a0624d62a1b56070()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_9d676780ccb04c42aa228b74e8684efe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d676780ccb04c42aa228b74e8684efe()
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

      private sealed class MTHD_23b0d7bce3d04d3294e020dddc6e3c66 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_23b0d7bce3d04d3294e020dddc6e3c66()
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

      private sealed class MTHD_08ee1e908f9f4e34ad93cbc6600d918a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_08ee1e908f9f4e34ad93cbc6600d918a()
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

      private sealed class MTHD_ae0a6ba261804a698442d976480c9bd1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae0a6ba261804a698442d976480c9bd1()
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

      private sealed class MTHD_1f62eebcff0046bfa9867aa7ddb69e66 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f62eebcff0046bfa9867aa7ddb69e66()
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

      private sealed class MTHD_b9ee9ec01d22446cba7b871bd59daf3b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b9ee9ec01d22446cba7b871bd59daf3b()
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

      private sealed class MTHD_d82565c580c74ddcae6f1b00f1a00158 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d82565c580c74ddcae6f1b00f1a00158()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_fc43299b3d45495a95d75961e870c23f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fc43299b3d45495a95d75961e870c23f()
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

      private sealed class MTHD_67a2c80bc30644f1a7504dba985ab569 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67a2c80bc30644f1a7504dba985ab569()
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

      private sealed class MTHD_72e18aa81e6e470d9b793eacd873f6fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_72e18aa81e6e470d9b793eacd873f6fc()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_3ab41ab82872405bb1b0b605f124c8db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3ab41ab82872405bb1b0b605f124c8db()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_b70d24917bc748e183022707cd5b5e92 : HardwiredMemberDescriptor
      {
        internal PROP_b70d24917bc748e183022707cd5b5e92()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_5f71829911ac4220b8332e3bb8daf7e0 : HardwiredMemberDescriptor
      {
        internal PROP_5f71829911ac4220b8332e3bb8daf7e0()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_114eea7b8bcd46e0b2d8ac8596ac5efa : HardwiredMemberDescriptor
      {
        internal PROP_114eea7b8bcd46e0b2d8ac8596ac5efa()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_f52f348f8e5141b2bc820dc0eca8cf9f : HardwiredMemberDescriptor
      {
        internal PROP_f52f348f8e5141b2bc820dc0eca8cf9f()
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

      private sealed class PROP_1d56193760fd43f69ffdb5b2db75216b : HardwiredMemberDescriptor
      {
        internal PROP_1d56193760fd43f69ffdb5b2db75216b()
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

      private sealed class PROP_a2d4144f0b0045008630e0008e09d175 : HardwiredMemberDescriptor
      {
        internal PROP_a2d4144f0b0045008630e0008e09d175()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_89c8004263fe4323a6d84242662e2811 : HardwiredMemberDescriptor
      {
        internal PROP_89c8004263fe4323a6d84242662e2811()
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

      private sealed class PROP_3b9c5d586acd48bd90a1bd3e62f5e271 : HardwiredMemberDescriptor
      {
        internal PROP_3b9c5d586acd48bd90a1bd3e62f5e271()
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

      private sealed class PROP_e8118b6a965940dfac2e7d066be6de2d : HardwiredMemberDescriptor
      {
        internal PROP_e8118b6a965940dfac2e7d066be6de2d()
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

      private sealed class PROP_c2e7c836005045298311162e2576df62 : HardwiredMemberDescriptor
      {
        internal PROP_c2e7c836005045298311162e2576df62()
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

      private sealed class PROP_61c327c96b4a4d6f9f26e25739ec2d68 : HardwiredMemberDescriptor
      {
        internal PROP_61c327c96b4a4d6f9f26e25739ec2d68()
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

      private sealed class PROP_9993d7442e3346ef8fbcb4e1a4005d63 : HardwiredMemberDescriptor
      {
        internal PROP_9993d7442e3346ef8fbcb4e1a4005d63()
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

      private sealed class PROP_b2b25e6a372849429dd6ba658bbeeb1d : HardwiredMemberDescriptor
      {
        internal PROP_b2b25e6a372849429dd6ba658bbeeb1d()
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

      private sealed class PROP_87f760ff46904c1fac01039bcdb64b55 : HardwiredMemberDescriptor
      {
        internal PROP_87f760ff46904c1fac01039bcdb64b55()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_acede9f91c3344df975c2a7996c9ceb7 : HardwiredMemberDescriptor
      {
        internal PROP_acede9f91c3344df975c2a7996c9ceb7()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_642a4076f93445bcaeb36446ceb961e5 : HardwiredMemberDescriptor
      {
        internal PROP_642a4076f93445bcaeb36446ceb961e5()
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

      private sealed class PROP_f008765054e44d1eb0a361c11da2bba9 : HardwiredMemberDescriptor
      {
        internal PROP_f008765054e44d1eb0a361c11da2bba9()
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

      private sealed class PROP_a2cd189fcffc4284bd3d4107a9ee5de5 : HardwiredMemberDescriptor
      {
        internal PROP_a2cd189fcffc4284bd3d4107a9ee5de5()
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

      private sealed class PROP_4a98e89b50324d4e8d4bd40b6a757edd : HardwiredMemberDescriptor
      {
        internal PROP_4a98e89b50324d4e8d4bd40b6a757edd()
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

      private sealed class PROP_6e9167f659bc40a3b97ed8691f263bd6 : HardwiredMemberDescriptor
      {
        internal PROP_6e9167f659bc40a3b97ed8691f263bd6()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_cad938b927284ed0963fbcc0bf59a029 : HardwiredMemberDescriptor
      {
        internal PROP_cad938b927284ed0963fbcc0bf59a029()
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

      private sealed class PROP_d5c0f5be227047e283a2128a36fd3c63 : HardwiredMemberDescriptor
      {
        internal PROP_d5c0f5be227047e283a2128a36fd3c63()
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

      private sealed class PROP_18c4870959f9498280b134c109763299 : HardwiredMemberDescriptor
      {
        internal PROP_18c4870959f9498280b134c109763299()
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

      private sealed class PROP_0addbae2022847aca95f92bba95953a6 : HardwiredMemberDescriptor
      {
        internal PROP_0addbae2022847aca95f92bba95953a6()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_ddf8ae69932e45af83f3d0b943900e39 : HardwiredMemberDescriptor
      {
        internal PROP_ddf8ae69932e45af83f3d0b943900e39()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_5488f2d880e543138e9a19cd06418414 : HardwiredMemberDescriptor
      {
        internal PROP_5488f2d880e543138e9a19cd06418414()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_2e0b2359f46046339beae3bc602b1730 : HardwiredMemberDescriptor
      {
        internal PROP_2e0b2359f46046339beae3bc602b1730()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_ed1da39402c649ec935b7c09cc3621a3 : HardwiredMemberDescriptor
      {
        internal PROP_ed1da39402c649ec935b7c09cc3621a3()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_d953c351ed6941b89d973d9488fd2e51 : HardwiredMemberDescriptor
      {
        internal PROP_d953c351ed6941b89d973d9488fd2e51()
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

      private sealed class PROP_af76cc6c4c6c475e96aee849d34f5c4b : HardwiredMemberDescriptor
      {
        internal PROP_af76cc6c4c6c475e96aee849d34f5c4b()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_089b3305ff0a4271abde6d2cc326d9db : HardwiredMemberDescriptor
      {
        internal PROP_089b3305ff0a4271abde6d2cc326d9db()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_ddbbfd67776244caa01f6018cfd398d4 : HardwiredMemberDescriptor
      {
        internal PROP_ddbbfd67776244caa01f6018cfd398d4()
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

      private sealed class PROP_9ac13ac9d173468f9f002bf659d41ed5 : HardwiredMemberDescriptor
      {
        internal PROP_9ac13ac9d173468f9f002bf659d41ed5()
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

    private sealed class TYPE_95eeb656f47d47388c7d8ad33d35f6dd : HardwiredUserDataDescriptor
    {
      internal TYPE_95eeb656f47d47388c7d8ad33d35f6dd()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.MTHD_e3bf727b141941c39d977e4b079df84e()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.MTHD_3b8cd4afe31f4900a7f44935f1b5cb4a()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.MTHD_aa0b1fd3fa20494b91ed4e571b35a1ae()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.MTHD_0464e591cf704d86875db002bac597ed()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.MTHD_397218b127f341978c74c054feb0f5b0()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.MTHD_4d278669f4674702b18b1d996ae6415c()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.MTHD_484335d4e4e74b348fc2e8fb270716e7()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.MTHD_73c1f10cb42a4277849f12cca2e4912a()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.MTHD_638cf18c56e14df895f845291f427889()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.MTHD_717baa16aaed4506bfdfeb823697659d()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.MTHD_f24e96532b534de09e030c2a85774d4d()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.MTHD_1f5c0c65c4a845ac82b38e13b238cb6a()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.MTHD_48134e83877448e8a242aec0dd4a11fb()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.MTHD_3279b5c8ad4642d8874a3e7112f7e02f()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.MTHD_05d3016080494eada58a14e2b0d31338()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.MTHD_c570518041994797850dec725b7658ad()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.MTHD_8c1ace935788433ea7fd864b07b38a65()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.MTHD_369c612476614afe9d0a1126b4459f18()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.MTHD_079b34c4046546d48b89d7fc20b14481()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.MTHD_073b94555da442269fabf413b5ce0c81()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.PROP_8dd5c0c3b87b4dd7b5e6db17b82da8e1());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.PROP_c96b2c4ff42140d38b5525aae6bd85c1());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.PROP_cc7e03adb80641f48d8f0f2f9d6a0884());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.PROP_b613ca4f01bc4b6ea3b0446bd23b5328());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.PROP_da1f1cd43b7146feb5cc1173f0e37273());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.PROP_9e346c25c29c4b648ce4e05c5dc7a807());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.PROP_c0899e5b88d8489a9694bfc5ed1771ed());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_95eeb656f47d47388c7d8ad33d35f6dd.PROP_3e420fef98d54c038a743759abaf9cd5());
      }

      private sealed class MTHD_e3bf727b141941c39d977e4b079df84e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e3bf727b141941c39d977e4b079df84e()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_3b8cd4afe31f4900a7f44935f1b5cb4a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3b8cd4afe31f4900a7f44935f1b5cb4a()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_aa0b1fd3fa20494b91ed4e571b35a1ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa0b1fd3fa20494b91ed4e571b35a1ae()
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

      private sealed class MTHD_0464e591cf704d86875db002bac597ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0464e591cf704d86875db002bac597ed()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_397218b127f341978c74c054feb0f5b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_397218b127f341978c74c054feb0f5b0()
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

      private sealed class MTHD_4d278669f4674702b18b1d996ae6415c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d278669f4674702b18b1d996ae6415c()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_484335d4e4e74b348fc2e8fb270716e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_484335d4e4e74b348fc2e8fb270716e7()
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

      private sealed class MTHD_73c1f10cb42a4277849f12cca2e4912a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_73c1f10cb42a4277849f12cca2e4912a()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_638cf18c56e14df895f845291f427889 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_638cf18c56e14df895f845291f427889()
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

      private sealed class MTHD_717baa16aaed4506bfdfeb823697659d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_717baa16aaed4506bfdfeb823697659d()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_f24e96532b534de09e030c2a85774d4d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f24e96532b534de09e030c2a85774d4d()
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

      private sealed class MTHD_1f5c0c65c4a845ac82b38e13b238cb6a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f5c0c65c4a845ac82b38e13b238cb6a()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_48134e83877448e8a242aec0dd4a11fb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_48134e83877448e8a242aec0dd4a11fb()
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

      private sealed class MTHD_3279b5c8ad4642d8874a3e7112f7e02f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3279b5c8ad4642d8874a3e7112f7e02f()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_05d3016080494eada58a14e2b0d31338 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_05d3016080494eada58a14e2b0d31338()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c570518041994797850dec725b7658ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c570518041994797850dec725b7658ad()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_8c1ace935788433ea7fd864b07b38a65 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c1ace935788433ea7fd864b07b38a65()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_369c612476614afe9d0a1126b4459f18 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_369c612476614afe9d0a1126b4459f18()
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

      private sealed class MTHD_079b34c4046546d48b89d7fc20b14481 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_079b34c4046546d48b89d7fc20b14481()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_073b94555da442269fabf413b5ce0c81 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_073b94555da442269fabf413b5ce0c81()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_8dd5c0c3b87b4dd7b5e6db17b82da8e1 : HardwiredMemberDescriptor
      {
        internal PROP_8dd5c0c3b87b4dd7b5e6db17b82da8e1()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_c96b2c4ff42140d38b5525aae6bd85c1 : HardwiredMemberDescriptor
      {
        internal PROP_c96b2c4ff42140d38b5525aae6bd85c1()
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

      private sealed class PROP_cc7e03adb80641f48d8f0f2f9d6a0884 : HardwiredMemberDescriptor
      {
        internal PROP_cc7e03adb80641f48d8f0f2f9d6a0884()
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

      private sealed class PROP_b613ca4f01bc4b6ea3b0446bd23b5328 : HardwiredMemberDescriptor
      {
        internal PROP_b613ca4f01bc4b6ea3b0446bd23b5328()
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

      private sealed class PROP_da1f1cd43b7146feb5cc1173f0e37273 : HardwiredMemberDescriptor
      {
        internal PROP_da1f1cd43b7146feb5cc1173f0e37273()
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

      private sealed class PROP_9e346c25c29c4b648ce4e05c5dc7a807 : HardwiredMemberDescriptor
      {
        internal PROP_9e346c25c29c4b648ce4e05c5dc7a807()
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

      private sealed class PROP_c0899e5b88d8489a9694bfc5ed1771ed : HardwiredMemberDescriptor
      {
        internal PROP_c0899e5b88d8489a9694bfc5ed1771ed()
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

      private sealed class PROP_3e420fef98d54c038a743759abaf9cd5 : HardwiredMemberDescriptor
      {
        internal PROP_3e420fef98d54c038a743759abaf9cd5()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_da498810843d44e5950e149326937281 : HardwiredUserDataDescriptor
    {
      internal TYPE_da498810843d44e5950e149326937281()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.MTHD_68da1bf8453e4febb533c47f14253176()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.MTHD_4043d14c39f14473867d58c1b8b04e53()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.MTHD_7041a3938629449e96633a2ee42a74cb()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.MTHD_e63184a685a6499b8ae09a226bad1271()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.MTHD_42f855b5b87348dab4cde150603843e6()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.MTHD_8a827d4df2c7453093638f0ec3111fbb()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.MTHD_93971cc0168548c596b10ef1744ebacb()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.MTHD_fe9f4a9c85004d29ba25aa1f127f3c29()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.MTHD_f26f650ec7554431960d702e4da41d3b()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.MTHD_42ee2fd670d14d429adadc1e4da4935a()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.MTHD_42cd49598ddd4a4a9a30cc1d8332a27f()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.MTHD_10ea64d2d5bf4180b1a3c74c39c02820()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.MTHD_ba5ceeba84c94c6b8a801031d084e16e()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.MTHD_031262b103ec4848b96bcb0f4a53e16e()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.MTHD_cba0d46dd19e4189ac0a32f6573c79df()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.MTHD_155d0225bc3e491ca1cf595d0454a362()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.MTHD_acc335824dfe4ca7a7fb7c8379fb2823()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.MTHD_620dce76e7ed42f6a414a0bdbcbd437c()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.MTHD_c957a544980441e2865dcc75908fd303()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.PROP_ba732f3de8cb48f3a574a9e0b49d9973());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.PROP_0f4d7d07cb7b41eaacb2774e8912f3ef());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.PROP_57a6661cf11d4ccb9ca5cb113d78fdbe());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.PROP_d2963598de794c149b69157fb434ce95());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.PROP_25afd4bbffad40b5b58bc8701f0af92c());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.PROP_a76a6abe1c8643f68721d0a70ec4c7a3());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.PROP_f25891980afd42889eded102d0a20f39());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_da498810843d44e5950e149326937281.PROP_a006c48584804f34a1e4fd7e00d61dff());
      }

      private sealed class MTHD_68da1bf8453e4febb533c47f14253176 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_68da1bf8453e4febb533c47f14253176()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_4043d14c39f14473867d58c1b8b04e53 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4043d14c39f14473867d58c1b8b04e53()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_7041a3938629449e96633a2ee42a74cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7041a3938629449e96633a2ee42a74cb()
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

      private sealed class MTHD_e63184a685a6499b8ae09a226bad1271 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e63184a685a6499b8ae09a226bad1271()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_42f855b5b87348dab4cde150603843e6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42f855b5b87348dab4cde150603843e6()
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

      private sealed class MTHD_8a827d4df2c7453093638f0ec3111fbb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a827d4df2c7453093638f0ec3111fbb()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_93971cc0168548c596b10ef1744ebacb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93971cc0168548c596b10ef1744ebacb()
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

      private sealed class MTHD_fe9f4a9c85004d29ba25aa1f127f3c29 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fe9f4a9c85004d29ba25aa1f127f3c29()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_f26f650ec7554431960d702e4da41d3b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f26f650ec7554431960d702e4da41d3b()
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

      private sealed class MTHD_42ee2fd670d14d429adadc1e4da4935a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42ee2fd670d14d429adadc1e4da4935a()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_42cd49598ddd4a4a9a30cc1d8332a27f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42cd49598ddd4a4a9a30cc1d8332a27f()
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

      private sealed class MTHD_10ea64d2d5bf4180b1a3c74c39c02820 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_10ea64d2d5bf4180b1a3c74c39c02820()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_ba5ceeba84c94c6b8a801031d084e16e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba5ceeba84c94c6b8a801031d084e16e()
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

      private sealed class MTHD_031262b103ec4848b96bcb0f4a53e16e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_031262b103ec4848b96bcb0f4a53e16e()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_cba0d46dd19e4189ac0a32f6573c79df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cba0d46dd19e4189ac0a32f6573c79df()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_155d0225bc3e491ca1cf595d0454a362 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_155d0225bc3e491ca1cf595d0454a362()
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

      private sealed class MTHD_acc335824dfe4ca7a7fb7c8379fb2823 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_acc335824dfe4ca7a7fb7c8379fb2823()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_620dce76e7ed42f6a414a0bdbcbd437c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_620dce76e7ed42f6a414a0bdbcbd437c()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_c957a544980441e2865dcc75908fd303 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c957a544980441e2865dcc75908fd303()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_ba732f3de8cb48f3a574a9e0b49d9973 : HardwiredMemberDescriptor
      {
        internal PROP_ba732f3de8cb48f3a574a9e0b49d9973()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_0f4d7d07cb7b41eaacb2774e8912f3ef : HardwiredMemberDescriptor
      {
        internal PROP_0f4d7d07cb7b41eaacb2774e8912f3ef()
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

      private sealed class PROP_57a6661cf11d4ccb9ca5cb113d78fdbe : HardwiredMemberDescriptor
      {
        internal PROP_57a6661cf11d4ccb9ca5cb113d78fdbe()
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

      private sealed class PROP_d2963598de794c149b69157fb434ce95 : HardwiredMemberDescriptor
      {
        internal PROP_d2963598de794c149b69157fb434ce95()
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

      private sealed class PROP_25afd4bbffad40b5b58bc8701f0af92c : HardwiredMemberDescriptor
      {
        internal PROP_25afd4bbffad40b5b58bc8701f0af92c()
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

      private sealed class PROP_a76a6abe1c8643f68721d0a70ec4c7a3 : HardwiredMemberDescriptor
      {
        internal PROP_a76a6abe1c8643f68721d0a70ec4c7a3()
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

      private sealed class PROP_f25891980afd42889eded102d0a20f39 : HardwiredMemberDescriptor
      {
        internal PROP_f25891980afd42889eded102d0a20f39()
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

      private sealed class PROP_a006c48584804f34a1e4fd7e00d61dff : HardwiredMemberDescriptor
      {
        internal PROP_a006c48584804f34a1e4fd7e00d61dff()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_26cc24e827624d5f9c4fcff8637d02ba : HardwiredUserDataDescriptor
    {
      internal TYPE_26cc24e827624d5f9c4fcff8637d02ba()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_c9837882d7804d66b31ae280a022fb5c()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_c5cd757bbe3d4e4aad1b3f8d39e1576b()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_01c00a8b71fe47c69873bca5e5e0ccb7()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_f67166899d7447b987df1c4fb96e1a2a()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_93a92c92c766430fb8047598c531fcec()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_b329fe121d5d43d6a75115d373f13de4()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_a38f064ba58b442f8ecf3632522eaa23()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_9c15c4ab73314606a870ad101e1c8859()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_a246b256b87640cb95897d2c17ce884e()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_cff6aab4bec242999ef59c036b51d8fe()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_ebc610331f124f6c8e982290c0626f67()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_3aaeed4010084e288d5b4bbef6ec2f2b()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_16bcdc20769a4d369d1feb837f732d1b()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_bbde746417dc43588725d0e3a7e67428()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_4c0b80a00b7c486294bd67d2a169d627()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_f9f3523814634309900421953815c74d()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_dc2d6c3980034bdea8a3673a9f14c1ea()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_9386f9d3032e495f9df51f3fb8c7fd72()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_4425b62a763c4ae5b4ea0135cab7c6f8()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_ee1b79fb7da84e4ab0b127c637bcd883()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_9f45629e2ab449f8b9be14d3c84c3f64()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_6083361f9f81458c95e26dd308c98b74()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_7fa185769feb499f9587ff954dc2b34b()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_a93ea5583095415d85d25752f408beaf()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_ff4494018d744b72a1fae3abbf03ea99()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_c51e3b3a06f9414a8e6a3739250f011d()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_1ecfbc48752a4da48aeb5b7bcffafdb2()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.MTHD_024d0139b0dc4ba4a0ffc7e46d6a96a0()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.PROP_7a6921c721e34e7994eb685a3731fa6c());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.PROP_4e63a717c61c4264825e3dc57ed5e94e());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.PROP_963b9e0405f846d993e716886d567f68());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.PROP_44c1242dbbcf4be4be47a2a74d58f124());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.PROP_abe9deb7f92640fc9591e53b7cedbdf1());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.PROP_a69a43b78b92485d9ebaff81d4bc6be8());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.PROP_bb41f2a9806344e8a511ffc1b623868f());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.PROP_d50aa66c868e421bba456ba7e02e9349());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.PROP_1857a504ff6745b28ddb353d178af368());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.PROP_8f5f15ea94c74ba6a8663e629073768f());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.PROP_dcffc0dc2bb74021865fe37cafaa1380());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.PROP_b3d551ebae384275ab6354de06616be1());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.PROP_588c2cf70a6b403eb8edd92425c8502b());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.PROP_accae2c5e8664b5783ba5f6dd0dde614());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.PROP_8ba48f2848c446409aa1a7882d129152());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.PROP_c4affab93a2e4ac091242c5c7eb59a61());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_26cc24e827624d5f9c4fcff8637d02ba.PROP_9b0e1f4cfb9547e8b8b87e1c937811fe());
      }

      private sealed class MTHD_c9837882d7804d66b31ae280a022fb5c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c9837882d7804d66b31ae280a022fb5c()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_c5cd757bbe3d4e4aad1b3f8d39e1576b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c5cd757bbe3d4e4aad1b3f8d39e1576b()
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

      private sealed class MTHD_01c00a8b71fe47c69873bca5e5e0ccb7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_01c00a8b71fe47c69873bca5e5e0ccb7()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_f67166899d7447b987df1c4fb96e1a2a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f67166899d7447b987df1c4fb96e1a2a()
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

      private sealed class MTHD_93a92c92c766430fb8047598c531fcec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93a92c92c766430fb8047598c531fcec()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_b329fe121d5d43d6a75115d373f13de4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b329fe121d5d43d6a75115d373f13de4()
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

      private sealed class MTHD_a38f064ba58b442f8ecf3632522eaa23 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a38f064ba58b442f8ecf3632522eaa23()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_9c15c4ab73314606a870ad101e1c8859 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c15c4ab73314606a870ad101e1c8859()
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

      private sealed class MTHD_a246b256b87640cb95897d2c17ce884e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a246b256b87640cb95897d2c17ce884e()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_cff6aab4bec242999ef59c036b51d8fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cff6aab4bec242999ef59c036b51d8fe()
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

      private sealed class MTHD_ebc610331f124f6c8e982290c0626f67 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ebc610331f124f6c8e982290c0626f67()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_3aaeed4010084e288d5b4bbef6ec2f2b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3aaeed4010084e288d5b4bbef6ec2f2b()
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

      private sealed class MTHD_16bcdc20769a4d369d1feb837f732d1b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_16bcdc20769a4d369d1feb837f732d1b()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_bbde746417dc43588725d0e3a7e67428 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bbde746417dc43588725d0e3a7e67428()
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

      private sealed class MTHD_4c0b80a00b7c486294bd67d2a169d627 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c0b80a00b7c486294bd67d2a169d627()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_f9f3523814634309900421953815c74d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f9f3523814634309900421953815c74d()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_dc2d6c3980034bdea8a3673a9f14c1ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc2d6c3980034bdea8a3673a9f14c1ea()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_9386f9d3032e495f9df51f3fb8c7fd72 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9386f9d3032e495f9df51f3fb8c7fd72()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_4425b62a763c4ae5b4ea0135cab7c6f8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4425b62a763c4ae5b4ea0135cab7c6f8()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_ee1b79fb7da84e4ab0b127c637bcd883 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee1b79fb7da84e4ab0b127c637bcd883()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_9f45629e2ab449f8b9be14d3c84c3f64 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f45629e2ab449f8b9be14d3c84c3f64()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_6083361f9f81458c95e26dd308c98b74 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6083361f9f81458c95e26dd308c98b74()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_7fa185769feb499f9587ff954dc2b34b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7fa185769feb499f9587ff954dc2b34b()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_a93ea5583095415d85d25752f408beaf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a93ea5583095415d85d25752f408beaf()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_ff4494018d744b72a1fae3abbf03ea99 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff4494018d744b72a1fae3abbf03ea99()
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

      private sealed class MTHD_c51e3b3a06f9414a8e6a3739250f011d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c51e3b3a06f9414a8e6a3739250f011d()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_1ecfbc48752a4da48aeb5b7bcffafdb2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ecfbc48752a4da48aeb5b7bcffafdb2()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_024d0139b0dc4ba4a0ffc7e46d6a96a0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_024d0139b0dc4ba4a0ffc7e46d6a96a0()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_7a6921c721e34e7994eb685a3731fa6c : HardwiredMemberDescriptor
      {
        internal PROP_7a6921c721e34e7994eb685a3731fa6c()
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

      private sealed class PROP_4e63a717c61c4264825e3dc57ed5e94e : HardwiredMemberDescriptor
      {
        internal PROP_4e63a717c61c4264825e3dc57ed5e94e()
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

      private sealed class PROP_963b9e0405f846d993e716886d567f68 : HardwiredMemberDescriptor
      {
        internal PROP_963b9e0405f846d993e716886d567f68()
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

      private sealed class PROP_44c1242dbbcf4be4be47a2a74d58f124 : HardwiredMemberDescriptor
      {
        internal PROP_44c1242dbbcf4be4be47a2a74d58f124()
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

      private sealed class PROP_abe9deb7f92640fc9591e53b7cedbdf1 : HardwiredMemberDescriptor
      {
        internal PROP_abe9deb7f92640fc9591e53b7cedbdf1()
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

      private sealed class PROP_a69a43b78b92485d9ebaff81d4bc6be8 : HardwiredMemberDescriptor
      {
        internal PROP_a69a43b78b92485d9ebaff81d4bc6be8()
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

      private sealed class PROP_bb41f2a9806344e8a511ffc1b623868f : HardwiredMemberDescriptor
      {
        internal PROP_bb41f2a9806344e8a511ffc1b623868f()
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

      private sealed class PROP_d50aa66c868e421bba456ba7e02e9349 : HardwiredMemberDescriptor
      {
        internal PROP_d50aa66c868e421bba456ba7e02e9349()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_1857a504ff6745b28ddb353d178af368 : HardwiredMemberDescriptor
      {
        internal PROP_1857a504ff6745b28ddb353d178af368()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_8f5f15ea94c74ba6a8663e629073768f : HardwiredMemberDescriptor
      {
        internal PROP_8f5f15ea94c74ba6a8663e629073768f()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_dcffc0dc2bb74021865fe37cafaa1380 : HardwiredMemberDescriptor
      {
        internal PROP_dcffc0dc2bb74021865fe37cafaa1380()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_b3d551ebae384275ab6354de06616be1 : HardwiredMemberDescriptor
      {
        internal PROP_b3d551ebae384275ab6354de06616be1()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_588c2cf70a6b403eb8edd92425c8502b : HardwiredMemberDescriptor
      {
        internal PROP_588c2cf70a6b403eb8edd92425c8502b()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_accae2c5e8664b5783ba5f6dd0dde614 : HardwiredMemberDescriptor
      {
        internal PROP_accae2c5e8664b5783ba5f6dd0dde614()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_8ba48f2848c446409aa1a7882d129152 : HardwiredMemberDescriptor
      {
        internal PROP_8ba48f2848c446409aa1a7882d129152()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_c4affab93a2e4ac091242c5c7eb59a61 : HardwiredMemberDescriptor
      {
        internal PROP_c4affab93a2e4ac091242c5c7eb59a61()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_9b0e1f4cfb9547e8b8b87e1c937811fe : HardwiredMemberDescriptor
      {
        internal PROP_9b0e1f4cfb9547e8b8b87e1c937811fe()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_3869c76032424406bab57466cd8d7d2c : HardwiredUserDataDescriptor
    {
      internal TYPE_3869c76032424406bab57466cd8d7d2c()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3869c76032424406bab57466cd8d7d2c.MTHD_e651acfca5ff4a04b8ef8def73db1496()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3869c76032424406bab57466cd8d7d2c.MTHD_8bf3e562a95e40aba708f6d52b047bd8()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3869c76032424406bab57466cd8d7d2c.MTHD_e9a4b80efde9453786147f9c149bc2f8()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3869c76032424406bab57466cd8d7d2c.MTHD_00ed14d06b8145c4a16db63eec683898()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3869c76032424406bab57466cd8d7d2c.MTHD_839270f7a7e1494d968beb3064a39f70()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3869c76032424406bab57466cd8d7d2c.MTHD_112dee0293e24e87969a2aaba69cef00()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3869c76032424406bab57466cd8d7d2c.MTHD_668d2ed66abb4b6db3ce3249e5785025()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3869c76032424406bab57466cd8d7d2c.MTHD_c6096458519d467087f9964e72cc182d()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3869c76032424406bab57466cd8d7d2c.MTHD_f487cb3f81b149c993651abaafb7efd8()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3869c76032424406bab57466cd8d7d2c.MTHD_c6cd79695461419bb19a6c0cc83299e1()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3869c76032424406bab57466cd8d7d2c.MTHD_692217164bfb4ae180962038933ccfcd()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3869c76032424406bab57466cd8d7d2c.MTHD_fa55c09bcc1643fa93f7901aa13d3e3d()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3869c76032424406bab57466cd8d7d2c.MTHD_9438a9f8db4748d6a0281b5f539f11f6()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3869c76032424406bab57466cd8d7d2c.MTHD_85b0168cfb564c80b6f232693b43e740()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3869c76032424406bab57466cd8d7d2c.MTHD_1d3f01f301ab44318bdfe08413d2d8b1()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3869c76032424406bab57466cd8d7d2c.MTHD_0e949442005646fda9cbede3cb53a646()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3869c76032424406bab57466cd8d7d2c.MTHD_54b4c6a97df14739ab7e57782267eeaa()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_3869c76032424406bab57466cd8d7d2c.PROP_2153e2675e2640c59d4b0d07dab95c27());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_3869c76032424406bab57466cd8d7d2c.PROP_24ee45e8903b4a0f93fc5d0cc5059b04());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_3869c76032424406bab57466cd8d7d2c.PROP_6356779d2af34f5188aa677d9d319474());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_3869c76032424406bab57466cd8d7d2c.PROP_b2414ff57fd7491999c0e872669b7e35());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_3869c76032424406bab57466cd8d7d2c.PROP_69c62642029c4ab381feb48e3ed4fdf6());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_3869c76032424406bab57466cd8d7d2c.PROP_5d67aaeb9c8c42fdbf21ecc237202a1d());
      }

      private sealed class MTHD_e651acfca5ff4a04b8ef8def73db1496 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e651acfca5ff4a04b8ef8def73db1496()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_8bf3e562a95e40aba708f6d52b047bd8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8bf3e562a95e40aba708f6d52b047bd8()
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

      private sealed class MTHD_e9a4b80efde9453786147f9c149bc2f8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e9a4b80efde9453786147f9c149bc2f8()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_00ed14d06b8145c4a16db63eec683898 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_00ed14d06b8145c4a16db63eec683898()
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

      private sealed class MTHD_839270f7a7e1494d968beb3064a39f70 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_839270f7a7e1494d968beb3064a39f70()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_112dee0293e24e87969a2aaba69cef00 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_112dee0293e24e87969a2aaba69cef00()
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

      private sealed class MTHD_668d2ed66abb4b6db3ce3249e5785025 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_668d2ed66abb4b6db3ce3249e5785025()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_c6096458519d467087f9964e72cc182d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c6096458519d467087f9964e72cc182d()
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

      private sealed class MTHD_f487cb3f81b149c993651abaafb7efd8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f487cb3f81b149c993651abaafb7efd8()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_c6cd79695461419bb19a6c0cc83299e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c6cd79695461419bb19a6c0cc83299e1()
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

      private sealed class MTHD_692217164bfb4ae180962038933ccfcd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_692217164bfb4ae180962038933ccfcd()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_fa55c09bcc1643fa93f7901aa13d3e3d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa55c09bcc1643fa93f7901aa13d3e3d()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_9438a9f8db4748d6a0281b5f539f11f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9438a9f8db4748d6a0281b5f539f11f6()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_85b0168cfb564c80b6f232693b43e740 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85b0168cfb564c80b6f232693b43e740()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_1d3f01f301ab44318bdfe08413d2d8b1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d3f01f301ab44318bdfe08413d2d8b1()
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

      private sealed class MTHD_0e949442005646fda9cbede3cb53a646 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e949442005646fda9cbede3cb53a646()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_54b4c6a97df14739ab7e57782267eeaa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_54b4c6a97df14739ab7e57782267eeaa()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_2153e2675e2640c59d4b0d07dab95c27 : HardwiredMemberDescriptor
      {
        internal PROP_2153e2675e2640c59d4b0d07dab95c27()
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

      private sealed class PROP_24ee45e8903b4a0f93fc5d0cc5059b04 : HardwiredMemberDescriptor
      {
        internal PROP_24ee45e8903b4a0f93fc5d0cc5059b04()
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

      private sealed class PROP_6356779d2af34f5188aa677d9d319474 : HardwiredMemberDescriptor
      {
        internal PROP_6356779d2af34f5188aa677d9d319474()
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

      private sealed class PROP_b2414ff57fd7491999c0e872669b7e35 : HardwiredMemberDescriptor
      {
        internal PROP_b2414ff57fd7491999c0e872669b7e35()
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

      private sealed class PROP_69c62642029c4ab381feb48e3ed4fdf6 : HardwiredMemberDescriptor
      {
        internal PROP_69c62642029c4ab381feb48e3ed4fdf6()
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

      private sealed class PROP_5d67aaeb9c8c42fdbf21ecc237202a1d : HardwiredMemberDescriptor
      {
        internal PROP_5d67aaeb9c8c42fdbf21ecc237202a1d()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_18bff3ec7b8b47549d4f7b2f089f6641 : HardwiredUserDataDescriptor
    {
      internal TYPE_18bff3ec7b8b47549d4f7b2f089f6641()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18bff3ec7b8b47549d4f7b2f089f6641.MTHD_c6fa90a02de94998967021cb5edb9646(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18bff3ec7b8b47549d4f7b2f089f6641.MTHD_f1033e49a6d243a8892551ba49c43aa0()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18bff3ec7b8b47549d4f7b2f089f6641.MTHD_f4d7340bcbe744869ab6358632ba50be(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18bff3ec7b8b47549d4f7b2f089f6641.MTHD_3f68a3cef44446188e0a216aca9029c9()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18bff3ec7b8b47549d4f7b2f089f6641.MTHD_e9a6edc57208452abfa9bc510863ab7e()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18bff3ec7b8b47549d4f7b2f089f6641.MTHD_ee17dc997efb452cb61bd61b7700e44c()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18bff3ec7b8b47549d4f7b2f089f6641.MTHD_fbb72429eb904a90ac9b85c0338ffc2a()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18bff3ec7b8b47549d4f7b2f089f6641.MTHD_960b23223b044d6cbf4da36d76ecaebd()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18bff3ec7b8b47549d4f7b2f089f6641.MTHD_89937705d8754959abfad8c2114de068()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18bff3ec7b8b47549d4f7b2f089f6641.MTHD_27bd64565b5a494395e82270c6da15b8()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18bff3ec7b8b47549d4f7b2f089f6641.MTHD_1178c2a1e960413e917c8a0802fc0085()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18bff3ec7b8b47549d4f7b2f089f6641.MTHD_ba13854b7119443a946fbc91d000ce89(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18bff3ec7b8b47549d4f7b2f089f6641.MTHD_2bc289ce00904da8a2a1251c16ca6d6c()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18bff3ec7b8b47549d4f7b2f089f6641.MTHD_ab2c23f23f7c4b158b5d4b7af7bc3054(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18bff3ec7b8b47549d4f7b2f089f6641.MTHD_d3b88814d4c347a0978aef2ac4af07ec()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18bff3ec7b8b47549d4f7b2f089f6641.MTHD_fcbdea6166bd45bd9f4b56ba97115b93(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18bff3ec7b8b47549d4f7b2f089f6641.MTHD_eb46db70d9bd4612be81a4ac8d05366d()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18bff3ec7b8b47549d4f7b2f089f6641.MTHD_e468079e69674fb7ab5e79fcab67fd66(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18bff3ec7b8b47549d4f7b2f089f6641.MTHD_4a7a82bfd169434189c54126ce6d199f()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18bff3ec7b8b47549d4f7b2f089f6641.MTHD_6ceabdcb7f004ca8a9099f4a10173a37(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18bff3ec7b8b47549d4f7b2f089f6641.MTHD_bf6a79364d2d430f88de0d2ef02045fe()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18bff3ec7b8b47549d4f7b2f089f6641.MTHD_8a9bac5279614626bc2fd4b7086d08bc()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_18bff3ec7b8b47549d4f7b2f089f6641.MTHD_411b44122baf4093a07c09cf32b7fd63()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_18bff3ec7b8b47549d4f7b2f089f6641.FLDV_382b7258eed94cde94d5f251a11223a9());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_18bff3ec7b8b47549d4f7b2f089f6641.FLDV_02160d482eee401d9f172bb02e84cd21());
      }

      private sealed class MTHD_c6fa90a02de94998967021cb5edb9646 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c6fa90a02de94998967021cb5edb9646()
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

      private sealed class MTHD_f1033e49a6d243a8892551ba49c43aa0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f1033e49a6d243a8892551ba49c43aa0()
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

      private sealed class MTHD_f4d7340bcbe744869ab6358632ba50be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4d7340bcbe744869ab6358632ba50be()
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

      private sealed class MTHD_3f68a3cef44446188e0a216aca9029c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f68a3cef44446188e0a216aca9029c9()
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

      private sealed class MTHD_e9a6edc57208452abfa9bc510863ab7e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e9a6edc57208452abfa9bc510863ab7e()
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

      private sealed class MTHD_ee17dc997efb452cb61bd61b7700e44c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee17dc997efb452cb61bd61b7700e44c()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_fbb72429eb904a90ac9b85c0338ffc2a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fbb72429eb904a90ac9b85c0338ffc2a()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_960b23223b044d6cbf4da36d76ecaebd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_960b23223b044d6cbf4da36d76ecaebd()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_89937705d8754959abfad8c2114de068 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_89937705d8754959abfad8c2114de068()
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

      private sealed class MTHD_27bd64565b5a494395e82270c6da15b8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_27bd64565b5a494395e82270c6da15b8()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_1178c2a1e960413e917c8a0802fc0085 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1178c2a1e960413e917c8a0802fc0085()
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

      private sealed class MTHD_ba13854b7119443a946fbc91d000ce89 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba13854b7119443a946fbc91d000ce89()
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

      private sealed class MTHD_2bc289ce00904da8a2a1251c16ca6d6c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2bc289ce00904da8a2a1251c16ca6d6c()
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

      private sealed class MTHD_ab2c23f23f7c4b158b5d4b7af7bc3054 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab2c23f23f7c4b158b5d4b7af7bc3054()
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

      private sealed class MTHD_d3b88814d4c347a0978aef2ac4af07ec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d3b88814d4c347a0978aef2ac4af07ec()
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

      private sealed class MTHD_fcbdea6166bd45bd9f4b56ba97115b93 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fcbdea6166bd45bd9f4b56ba97115b93()
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

      private sealed class MTHD_eb46db70d9bd4612be81a4ac8d05366d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb46db70d9bd4612be81a4ac8d05366d()
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

      private sealed class MTHD_e468079e69674fb7ab5e79fcab67fd66 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e468079e69674fb7ab5e79fcab67fd66()
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

      private sealed class MTHD_4a7a82bfd169434189c54126ce6d199f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a7a82bfd169434189c54126ce6d199f()
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

      private sealed class MTHD_6ceabdcb7f004ca8a9099f4a10173a37 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ceabdcb7f004ca8a9099f4a10173a37()
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

      private sealed class MTHD_bf6a79364d2d430f88de0d2ef02045fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf6a79364d2d430f88de0d2ef02045fe()
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

      private sealed class MTHD_8a9bac5279614626bc2fd4b7086d08bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a9bac5279614626bc2fd4b7086d08bc()
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

      private sealed class MTHD_411b44122baf4093a07c09cf32b7fd63 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_411b44122baf4093a07c09cf32b7fd63()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_382b7258eed94cde94d5f251a11223a9 : HardwiredMemberDescriptor
      {
        internal FLDV_382b7258eed94cde94d5f251a11223a9()
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

      private sealed class FLDV_02160d482eee401d9f172bb02e84cd21 : HardwiredMemberDescriptor
      {
        internal FLDV_02160d482eee401d9f172bb02e84cd21()
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

    private sealed class TYPE_73fc8bc721184e89819087aca094616f : HardwiredUserDataDescriptor
    {
      internal TYPE_73fc8bc721184e89819087aca094616f()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_73fc8bc721184e89819087aca094616f.MTHD_79b807759c744e928d959573f16daab6()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_73fc8bc721184e89819087aca094616f.MTHD_3843e3203c7240b38c1ff79094876825()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_73fc8bc721184e89819087aca094616f.MTHD_7090edda853b4054916ecd8f51d976e1()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_73fc8bc721184e89819087aca094616f.MTHD_de8d3df617b149ee9ade4f2e534f6f53()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_73fc8bc721184e89819087aca094616f.MTHD_89c6f65d3a7e46a7896fe545bc0ef18d()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_73fc8bc721184e89819087aca094616f.MTHD_1b04750edbea41068fba68cccfb6d879()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_73fc8bc721184e89819087aca094616f.FLDV_bc8f9adf63d74f04af123f9c39c4477f());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_73fc8bc721184e89819087aca094616f.FLDV_a3d06df053644bfbb3c37b6d97b8f428());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_73fc8bc721184e89819087aca094616f.FLDV_f28dd527a6d14e6cbe4b10590386ce67());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_73fc8bc721184e89819087aca094616f.FLDV_b4e297a1d11e4636b52c8533cc88fd24());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_73fc8bc721184e89819087aca094616f.FLDV_68e49156d0474cc5bc1a6bc27ac56d0e());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_73fc8bc721184e89819087aca094616f.FLDV_c52127ea1970430abb79df0909395d9b());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_73fc8bc721184e89819087aca094616f.FLDV_3d9973496eff4fdead25331f8a085d58());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_73fc8bc721184e89819087aca094616f.FLDV_abb6f723b5d4464ba667d1803ef91776());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_73fc8bc721184e89819087aca094616f.FLDV_19e2978c44524c7885c146b152f18027());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_73fc8bc721184e89819087aca094616f.FLDV_18628bb441fb437695c8afec7b0106c7());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_73fc8bc721184e89819087aca094616f.FLDV_5f5e1f526a45432892b238c358bdba6c());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_73fc8bc721184e89819087aca094616f.FLDV_98191e4edf2942cfa88bb90aac723711());
      }

      private sealed class MTHD_79b807759c744e928d959573f16daab6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_79b807759c744e928d959573f16daab6()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_3843e3203c7240b38c1ff79094876825 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3843e3203c7240b38c1ff79094876825()
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

      private sealed class MTHD_7090edda853b4054916ecd8f51d976e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7090edda853b4054916ecd8f51d976e1()
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

      private sealed class MTHD_de8d3df617b149ee9ade4f2e534f6f53 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de8d3df617b149ee9ade4f2e534f6f53()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_89c6f65d3a7e46a7896fe545bc0ef18d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_89c6f65d3a7e46a7896fe545bc0ef18d()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_1b04750edbea41068fba68cccfb6d879 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1b04750edbea41068fba68cccfb6d879()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_bc8f9adf63d74f04af123f9c39c4477f : HardwiredMemberDescriptor
      {
        internal FLDV_bc8f9adf63d74f04af123f9c39c4477f()
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

      private sealed class FLDV_a3d06df053644bfbb3c37b6d97b8f428 : HardwiredMemberDescriptor
      {
        internal FLDV_a3d06df053644bfbb3c37b6d97b8f428()
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

      private sealed class FLDV_f28dd527a6d14e6cbe4b10590386ce67 : HardwiredMemberDescriptor
      {
        internal FLDV_f28dd527a6d14e6cbe4b10590386ce67()
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

      private sealed class FLDV_b4e297a1d11e4636b52c8533cc88fd24 : HardwiredMemberDescriptor
      {
        internal FLDV_b4e297a1d11e4636b52c8533cc88fd24()
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

      private sealed class FLDV_68e49156d0474cc5bc1a6bc27ac56d0e : HardwiredMemberDescriptor
      {
        internal FLDV_68e49156d0474cc5bc1a6bc27ac56d0e()
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

      private sealed class FLDV_c52127ea1970430abb79df0909395d9b : HardwiredMemberDescriptor
      {
        internal FLDV_c52127ea1970430abb79df0909395d9b()
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

      private sealed class FLDV_3d9973496eff4fdead25331f8a085d58 : HardwiredMemberDescriptor
      {
        internal FLDV_3d9973496eff4fdead25331f8a085d58()
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

      private sealed class FLDV_abb6f723b5d4464ba667d1803ef91776 : HardwiredMemberDescriptor
      {
        internal FLDV_abb6f723b5d4464ba667d1803ef91776()
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

      private sealed class FLDV_19e2978c44524c7885c146b152f18027 : HardwiredMemberDescriptor
      {
        internal FLDV_19e2978c44524c7885c146b152f18027()
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

      private sealed class FLDV_18628bb441fb437695c8afec7b0106c7 : HardwiredMemberDescriptor
      {
        internal FLDV_18628bb441fb437695c8afec7b0106c7()
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

      private sealed class FLDV_5f5e1f526a45432892b238c358bdba6c : HardwiredMemberDescriptor
      {
        internal FLDV_5f5e1f526a45432892b238c358bdba6c()
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

      private sealed class FLDV_98191e4edf2942cfa88bb90aac723711 : HardwiredMemberDescriptor
      {
        internal FLDV_98191e4edf2942cfa88bb90aac723711()
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

    private sealed class TYPE_44740a982caf4cadb7cf0cbe95c7a680 : HardwiredUserDataDescriptor
    {
      internal TYPE_44740a982caf4cadb7cf0cbe95c7a680()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_1bf61ddc289d4466a1a8e6d5e340a348()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_1470c1b768f343dab2f0654358564e3d()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_b5fe2c5f2f5a42c5be6eddb2868abb42()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_2cb97a20d4ea4e12a57aa3b2371dfd10()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_c987049fc07d4de2ae54d4ca1c4a6260()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_bc0691c2a3d84ec9896be3e307866553()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_9161842579be4a04a8219128609150eb()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_d60ae52f2806445b9bd14203b0c147ba()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_0c91ca2aa72249e1a40d814e367ed445()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_cc5181aa51614bd0bb176d022aeea381()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_6251e019a6674330bc4b1c4680ebba45()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_4eb8baedb8e04d5f863fd9effd451ce2()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_fb47ff32d3814e0ea418331809906879()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_6a0cd25c8c1a4b50b2a43ba0a47f1559()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_08fe732de6c34f7a9dc77c71f60806d3()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_3d7df79a96a84918bd83a1367d3ca705()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_d3c5f53de4414877ae1e691a08748392()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_cabee2b5f26c49a390e5afb1e7f0998f()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_62123a5098c5407eb77b3d563ea806fd()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_087a6eff7e534fab883408123403696f()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_fcc26a5603d94ff6ad96a32a796c33a0()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_b5351b63735b40519e4fa13f0d4f61bf()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_6cf04bf416e24ad3a536f931a732c9a3()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_0be12e31bfb94342ba096e6620b6dbbc()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_3b815204a728489fb53b09e6544d9b59()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_75a62c8c5bfd473eb0860b942a8c21a3()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_247def86f67645ef9d12e31a1eeca3dd()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_a7dd128767ef420aa16d45a13fe60bae()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_878e99601bc941008e4369a91b82a08e()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_259e2802d72d4f8ab594ccf328b92db2()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_7538bcebdc0f4c2d96387a350828941e()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_69a0e9c6ad9e4731be2e3fbabe5a3770()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_ce092324d66d4703aafb20247bf3ed07()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_e37962152648464599c5b764105ea097()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_5aba6423dd8a418ebadce89bb15d1191()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_ab6e27a3034c4dbab978e73a255ebfb6()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_4ccdab1f5da549729ed5258e0468ee1d()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_97504528768e469ebe7300647edbd04d()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_cb68c6f10b3c42c5866dfcd754362bfa()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_b0cff5a2028645a68a7b62bd56535009()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_4f9882f282414de29a0c9ad083d29ab0()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_e38186519736409ba2e612336c872541()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_673744e25d424613900189df1210ba3b()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_a57e7ee22fd947caad3c07793939a0b5()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_6c3c7432d96e47a3abbc58cbb85ccbe1()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_77caee8de00943539e098ba4fe8055f4()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_caf1e85223e049d5bad1ee662d09795f()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.MTHD_f69d7a3b586d498c8d36f5d3da781827()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.PROP_0392d9dbc5c3435c8cbc11b17a1bf8b8());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.PROP_28d57e5347d84d5ab6b1ec1c9add9988());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.PROP_b02fcfad31784c9d89d85f5bd429a8f1());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.PROP_0a27fb33470043e0a11d366584be17cb());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.PROP_79709f5ddf8e4365a0656b85f76af4e6());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.PROP_4d96305f99134e59a115423204e92025());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.PROP_de57ff180a784b8183010d244176eab1());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.PROP_f82266c66dd148a69a5f9c69bdccdd58());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.PROP_d0d8ca4140eb4ebfb94aaa8d72078c09());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.PROP_8ddc5a4bc58b4001ae59cdc2f25a210d());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.PROP_0a1ce5d2ea41428087f1da4ccf56d469());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.PROP_1eca4e3c48b0413bbdcacfaf862b141a());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.PROP_778884cdaceb4d6c8615508d48ef5b91());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.PROP_5ea34ad1f94547848b1605fc76921582());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.PROP_344bfb647c1a4f0f8fc99233a7871b24());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.PROP_e82f422df60b414da565432693eb2e97());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.PROP_8724a0f092374d34b5c7567609551123());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.PROP_395a8c1819ea4d0984d4bf40bcd669d9());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.PROP_45f21ed3b6cf4206a648af2a85623dd2());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.FLDV_2f94e6e5f9fb4af599cf74d3c0fd2ed8());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.FLDV_75075ae4cc5c4873ac74a72a1c53b15d());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_44740a982caf4cadb7cf0cbe95c7a680.FLDV_ea04f0b3f2904c77b79eef7e3b334810());
      }

      private sealed class MTHD_1bf61ddc289d4466a1a8e6d5e340a348 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1bf61ddc289d4466a1a8e6d5e340a348()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_1470c1b768f343dab2f0654358564e3d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1470c1b768f343dab2f0654358564e3d()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_b5fe2c5f2f5a42c5be6eddb2868abb42 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b5fe2c5f2f5a42c5be6eddb2868abb42()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_2cb97a20d4ea4e12a57aa3b2371dfd10 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2cb97a20d4ea4e12a57aa3b2371dfd10()
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

      private sealed class MTHD_c987049fc07d4de2ae54d4ca1c4a6260 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c987049fc07d4de2ae54d4ca1c4a6260()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_bc0691c2a3d84ec9896be3e307866553 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bc0691c2a3d84ec9896be3e307866553()
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

      private sealed class MTHD_9161842579be4a04a8219128609150eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9161842579be4a04a8219128609150eb()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_d60ae52f2806445b9bd14203b0c147ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d60ae52f2806445b9bd14203b0c147ba()
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

      private sealed class MTHD_0c91ca2aa72249e1a40d814e367ed445 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c91ca2aa72249e1a40d814e367ed445()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_cc5181aa51614bd0bb176d022aeea381 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cc5181aa51614bd0bb176d022aeea381()
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

      private sealed class MTHD_6251e019a6674330bc4b1c4680ebba45 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6251e019a6674330bc4b1c4680ebba45()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_4eb8baedb8e04d5f863fd9effd451ce2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4eb8baedb8e04d5f863fd9effd451ce2()
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

      private sealed class MTHD_fb47ff32d3814e0ea418331809906879 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb47ff32d3814e0ea418331809906879()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_6a0cd25c8c1a4b50b2a43ba0a47f1559 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6a0cd25c8c1a4b50b2a43ba0a47f1559()
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

      private sealed class MTHD_08fe732de6c34f7a9dc77c71f60806d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_08fe732de6c34f7a9dc77c71f60806d3()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_3d7df79a96a84918bd83a1367d3ca705 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d7df79a96a84918bd83a1367d3ca705()
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

      private sealed class MTHD_d3c5f53de4414877ae1e691a08748392 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d3c5f53de4414877ae1e691a08748392()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_cabee2b5f26c49a390e5afb1e7f0998f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cabee2b5f26c49a390e5afb1e7f0998f()
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

      private sealed class MTHD_62123a5098c5407eb77b3d563ea806fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_62123a5098c5407eb77b3d563ea806fd()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_087a6eff7e534fab883408123403696f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_087a6eff7e534fab883408123403696f()
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

      private sealed class MTHD_fcc26a5603d94ff6ad96a32a796c33a0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fcc26a5603d94ff6ad96a32a796c33a0()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_b5351b63735b40519e4fa13f0d4f61bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b5351b63735b40519e4fa13f0d4f61bf()
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

      private sealed class MTHD_6cf04bf416e24ad3a536f931a732c9a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6cf04bf416e24ad3a536f931a732c9a3()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_0be12e31bfb94342ba096e6620b6dbbc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0be12e31bfb94342ba096e6620b6dbbc()
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

      private sealed class MTHD_3b815204a728489fb53b09e6544d9b59 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3b815204a728489fb53b09e6544d9b59()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_75a62c8c5bfd473eb0860b942a8c21a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75a62c8c5bfd473eb0860b942a8c21a3()
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

      private sealed class MTHD_247def86f67645ef9d12e31a1eeca3dd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_247def86f67645ef9d12e31a1eeca3dd()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_a7dd128767ef420aa16d45a13fe60bae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a7dd128767ef420aa16d45a13fe60bae()
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

      private sealed class MTHD_878e99601bc941008e4369a91b82a08e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_878e99601bc941008e4369a91b82a08e()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_259e2802d72d4f8ab594ccf328b92db2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_259e2802d72d4f8ab594ccf328b92db2()
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

      private sealed class MTHD_7538bcebdc0f4c2d96387a350828941e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7538bcebdc0f4c2d96387a350828941e()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_69a0e9c6ad9e4731be2e3fbabe5a3770 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69a0e9c6ad9e4731be2e3fbabe5a3770()
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

      private sealed class MTHD_ce092324d66d4703aafb20247bf3ed07 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ce092324d66d4703aafb20247bf3ed07()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_e37962152648464599c5b764105ea097 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e37962152648464599c5b764105ea097()
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

      private sealed class MTHD_5aba6423dd8a418ebadce89bb15d1191 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5aba6423dd8a418ebadce89bb15d1191()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_ab6e27a3034c4dbab978e73a255ebfb6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab6e27a3034c4dbab978e73a255ebfb6()
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

      private sealed class MTHD_4ccdab1f5da549729ed5258e0468ee1d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ccdab1f5da549729ed5258e0468ee1d()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_97504528768e469ebe7300647edbd04d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97504528768e469ebe7300647edbd04d()
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

      private sealed class MTHD_cb68c6f10b3c42c5866dfcd754362bfa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cb68c6f10b3c42c5866dfcd754362bfa()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b0cff5a2028645a68a7b62bd56535009 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b0cff5a2028645a68a7b62bd56535009()
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

      private sealed class MTHD_4f9882f282414de29a0c9ad083d29ab0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4f9882f282414de29a0c9ad083d29ab0()
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

      private sealed class MTHD_e38186519736409ba2e612336c872541 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e38186519736409ba2e612336c872541()
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

      private sealed class MTHD_673744e25d424613900189df1210ba3b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_673744e25d424613900189df1210ba3b()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_a57e7ee22fd947caad3c07793939a0b5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a57e7ee22fd947caad3c07793939a0b5()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_6c3c7432d96e47a3abbc58cbb85ccbe1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6c3c7432d96e47a3abbc58cbb85ccbe1()
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

      private sealed class MTHD_77caee8de00943539e098ba4fe8055f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_77caee8de00943539e098ba4fe8055f4()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_caf1e85223e049d5bad1ee662d09795f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_caf1e85223e049d5bad1ee662d09795f()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_f69d7a3b586d498c8d36f5d3da781827 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f69d7a3b586d498c8d36f5d3da781827()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_0392d9dbc5c3435c8cbc11b17a1bf8b8 : HardwiredMemberDescriptor
      {
        internal PROP_0392d9dbc5c3435c8cbc11b17a1bf8b8()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_28d57e5347d84d5ab6b1ec1c9add9988 : HardwiredMemberDescriptor
      {
        internal PROP_28d57e5347d84d5ab6b1ec1c9add9988()
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

      private sealed class PROP_b02fcfad31784c9d89d85f5bd429a8f1 : HardwiredMemberDescriptor
      {
        internal PROP_b02fcfad31784c9d89d85f5bd429a8f1()
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

      private sealed class PROP_0a27fb33470043e0a11d366584be17cb : HardwiredMemberDescriptor
      {
        internal PROP_0a27fb33470043e0a11d366584be17cb()
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

      private sealed class PROP_79709f5ddf8e4365a0656b85f76af4e6 : HardwiredMemberDescriptor
      {
        internal PROP_79709f5ddf8e4365a0656b85f76af4e6()
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

      private sealed class PROP_4d96305f99134e59a115423204e92025 : HardwiredMemberDescriptor
      {
        internal PROP_4d96305f99134e59a115423204e92025()
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

      private sealed class PROP_de57ff180a784b8183010d244176eab1 : HardwiredMemberDescriptor
      {
        internal PROP_de57ff180a784b8183010d244176eab1()
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

      private sealed class PROP_f82266c66dd148a69a5f9c69bdccdd58 : HardwiredMemberDescriptor
      {
        internal PROP_f82266c66dd148a69a5f9c69bdccdd58()
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

      private sealed class PROP_d0d8ca4140eb4ebfb94aaa8d72078c09 : HardwiredMemberDescriptor
      {
        internal PROP_d0d8ca4140eb4ebfb94aaa8d72078c09()
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

      private sealed class PROP_8ddc5a4bc58b4001ae59cdc2f25a210d : HardwiredMemberDescriptor
      {
        internal PROP_8ddc5a4bc58b4001ae59cdc2f25a210d()
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

      private sealed class PROP_0a1ce5d2ea41428087f1da4ccf56d469 : HardwiredMemberDescriptor
      {
        internal PROP_0a1ce5d2ea41428087f1da4ccf56d469()
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

      private sealed class PROP_1eca4e3c48b0413bbdcacfaf862b141a : HardwiredMemberDescriptor
      {
        internal PROP_1eca4e3c48b0413bbdcacfaf862b141a()
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

      private sealed class PROP_778884cdaceb4d6c8615508d48ef5b91 : HardwiredMemberDescriptor
      {
        internal PROP_778884cdaceb4d6c8615508d48ef5b91()
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

      private sealed class PROP_5ea34ad1f94547848b1605fc76921582 : HardwiredMemberDescriptor
      {
        internal PROP_5ea34ad1f94547848b1605fc76921582()
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

      private sealed class PROP_344bfb647c1a4f0f8fc99233a7871b24 : HardwiredMemberDescriptor
      {
        internal PROP_344bfb647c1a4f0f8fc99233a7871b24()
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

      private sealed class PROP_e82f422df60b414da565432693eb2e97 : HardwiredMemberDescriptor
      {
        internal PROP_e82f422df60b414da565432693eb2e97()
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

      private sealed class PROP_8724a0f092374d34b5c7567609551123 : HardwiredMemberDescriptor
      {
        internal PROP_8724a0f092374d34b5c7567609551123()
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

      private sealed class PROP_395a8c1819ea4d0984d4bf40bcd669d9 : HardwiredMemberDescriptor
      {
        internal PROP_395a8c1819ea4d0984d4bf40bcd669d9()
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

      private sealed class PROP_45f21ed3b6cf4206a648af2a85623dd2 : HardwiredMemberDescriptor
      {
        internal PROP_45f21ed3b6cf4206a648af2a85623dd2()
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

      private sealed class FLDV_2f94e6e5f9fb4af599cf74d3c0fd2ed8 : HardwiredMemberDescriptor
      {
        internal FLDV_2f94e6e5f9fb4af599cf74d3c0fd2ed8()
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

      private sealed class FLDV_75075ae4cc5c4873ac74a72a1c53b15d : HardwiredMemberDescriptor
      {
        internal FLDV_75075ae4cc5c4873ac74a72a1c53b15d()
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

      private sealed class FLDV_ea04f0b3f2904c77b79eef7e3b334810 : HardwiredMemberDescriptor
      {
        internal FLDV_ea04f0b3f2904c77b79eef7e3b334810()
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

    private sealed class TYPE_e2368d9071ad4cab82f343e0a8019349 : HardwiredUserDataDescriptor
    {
      internal TYPE_e2368d9071ad4cab82f343e0a8019349()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e2368d9071ad4cab82f343e0a8019349.MTHD_5620a97a8abb47c2a8cc4ec45dda0699()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e2368d9071ad4cab82f343e0a8019349.MTHD_abdf9bc96a59444b896a06c3b4abb833()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e2368d9071ad4cab82f343e0a8019349.MTHD_5f07b3c9edea407a9af6cb5dd29c8e41()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e2368d9071ad4cab82f343e0a8019349.MTHD_4d329644dbd24227ba6e91bb53c6d486()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e2368d9071ad4cab82f343e0a8019349.MTHD_6bf4ca5c7c2040659523ef60af96f727()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e2368d9071ad4cab82f343e0a8019349.MTHD_3da2f849f77940f6b26bc67d2bc8c765()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_e2368d9071ad4cab82f343e0a8019349.FLDV_3fd2538b5d5645d7b34284ce19691903());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_e2368d9071ad4cab82f343e0a8019349.FLDV_5a9f8c43bbde4fbfb17c1750064556e2());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_e2368d9071ad4cab82f343e0a8019349.FLDV_91e48a7de68c41e8894002e748db1432());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_e2368d9071ad4cab82f343e0a8019349.FLDV_bf914c91143f46f3ac9e80d5acb90807());
      }

      private sealed class MTHD_5620a97a8abb47c2a8cc4ec45dda0699 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5620a97a8abb47c2a8cc4ec45dda0699()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_abdf9bc96a59444b896a06c3b4abb833 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_abdf9bc96a59444b896a06c3b4abb833()
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

      private sealed class MTHD_5f07b3c9edea407a9af6cb5dd29c8e41 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5f07b3c9edea407a9af6cb5dd29c8e41()
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

      private sealed class MTHD_4d329644dbd24227ba6e91bb53c6d486 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d329644dbd24227ba6e91bb53c6d486()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_6bf4ca5c7c2040659523ef60af96f727 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6bf4ca5c7c2040659523ef60af96f727()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_3da2f849f77940f6b26bc67d2bc8c765 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3da2f849f77940f6b26bc67d2bc8c765()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_3fd2538b5d5645d7b34284ce19691903 : HardwiredMemberDescriptor
      {
        internal FLDV_3fd2538b5d5645d7b34284ce19691903()
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

      private sealed class FLDV_5a9f8c43bbde4fbfb17c1750064556e2 : HardwiredMemberDescriptor
      {
        internal FLDV_5a9f8c43bbde4fbfb17c1750064556e2()
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

      private sealed class FLDV_91e48a7de68c41e8894002e748db1432 : HardwiredMemberDescriptor
      {
        internal FLDV_91e48a7de68c41e8894002e748db1432()
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

      private sealed class FLDV_bf914c91143f46f3ac9e80d5acb90807 : HardwiredMemberDescriptor
      {
        internal FLDV_bf914c91143f46f3ac9e80d5acb90807()
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

    private sealed class TYPE_11cc3705a3854fd7ad9219d27d884494 : HardwiredUserDataDescriptor
    {
      internal TYPE_11cc3705a3854fd7ad9219d27d884494()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_11cc3705a3854fd7ad9219d27d884494.MTHD_39cffa60f7814927ae502f980a072660()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_11cc3705a3854fd7ad9219d27d884494.MTHD_4550d7bfdcb94ea49e50b26653d42015()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_11cc3705a3854fd7ad9219d27d884494.MTHD_efd50dfc57704cc5849bbc300f8bec2a()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_11cc3705a3854fd7ad9219d27d884494.MTHD_6ad0003aed4e4cbfa35ac731e0f1dade()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_11cc3705a3854fd7ad9219d27d884494.MTHD_51965cec9c9a4465b4ff2723e00f972b()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_11cc3705a3854fd7ad9219d27d884494.FLDV_3ea1cefbc77c4d729f31cc31e085a034());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_11cc3705a3854fd7ad9219d27d884494.FLDV_9abb6c826db4469eaf69750bb66ca63e());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_11cc3705a3854fd7ad9219d27d884494.FLDV_0974d5c28df64bab90348ea2e95ca853());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_11cc3705a3854fd7ad9219d27d884494.FLDV_653922364b054e64bf7e5a183c4a71fc());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_11cc3705a3854fd7ad9219d27d884494.FLDV_87f6c7a8716c4d7b9f633737c042d239());
      }

      private sealed class MTHD_39cffa60f7814927ae502f980a072660 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_39cffa60f7814927ae502f980a072660()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_4550d7bfdcb94ea49e50b26653d42015 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4550d7bfdcb94ea49e50b26653d42015()
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

      private sealed class MTHD_efd50dfc57704cc5849bbc300f8bec2a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_efd50dfc57704cc5849bbc300f8bec2a()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_6ad0003aed4e4cbfa35ac731e0f1dade : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ad0003aed4e4cbfa35ac731e0f1dade()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_51965cec9c9a4465b4ff2723e00f972b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_51965cec9c9a4465b4ff2723e00f972b()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_3ea1cefbc77c4d729f31cc31e085a034 : HardwiredMemberDescriptor
      {
        internal FLDV_3ea1cefbc77c4d729f31cc31e085a034()
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

      private sealed class FLDV_9abb6c826db4469eaf69750bb66ca63e : HardwiredMemberDescriptor
      {
        internal FLDV_9abb6c826db4469eaf69750bb66ca63e()
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

      private sealed class FLDV_0974d5c28df64bab90348ea2e95ca853 : HardwiredMemberDescriptor
      {
        internal FLDV_0974d5c28df64bab90348ea2e95ca853()
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

      private sealed class FLDV_653922364b054e64bf7e5a183c4a71fc : HardwiredMemberDescriptor
      {
        internal FLDV_653922364b054e64bf7e5a183c4a71fc()
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

      private sealed class FLDV_87f6c7a8716c4d7b9f633737c042d239 : HardwiredMemberDescriptor
      {
        internal FLDV_87f6c7a8716c4d7b9f633737c042d239()
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

    private sealed class TYPE_c37042b702114e4aacdc64f80a557e2f : HardwiredUserDataDescriptor
    {
      internal TYPE_c37042b702114e4aacdc64f80a557e2f()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c37042b702114e4aacdc64f80a557e2f.MTHD_2a2b277272e04f579f133794e4d47ced()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c37042b702114e4aacdc64f80a557e2f.MTHD_f930c8205b2d460dbe85749c18b9ea68()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c37042b702114e4aacdc64f80a557e2f.MTHD_237cec6c4773463bb43e7fcf1ff4eeb4()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c37042b702114e4aacdc64f80a557e2f.MTHD_49a471e131b04df6b78e7411ae750b98()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c37042b702114e4aacdc64f80a557e2f.MTHD_6ae1c32a9fad4a42be47f602bfeb93db()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c37042b702114e4aacdc64f80a557e2f.MTHD_774b69c5e3c449b787871bc04e01ba11()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c37042b702114e4aacdc64f80a557e2f.MTHD_4218613a5d134455b06e8eca8e9ae1e4()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c37042b702114e4aacdc64f80a557e2f.MTHD_d02fd46338a74751b30884468bdef3af()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c37042b702114e4aacdc64f80a557e2f.MTHD_862549a5c94e47b4bfbcaf56958f88f7()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c37042b702114e4aacdc64f80a557e2f.MTHD_3d64cc25d9664834936741e0b898ba73()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c37042b702114e4aacdc64f80a557e2f.MTHD_071218eda67944bfa070b643f793202e()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c37042b702114e4aacdc64f80a557e2f.MTHD_bb18326bdc6f4977ae5cb38487d26731()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c37042b702114e4aacdc64f80a557e2f.MTHD_2970f8db24594ba7998d3051e368db8f()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_c37042b702114e4aacdc64f80a557e2f.FLDV_4f06c0947e7c4c5ab5b2a46e051f8f8a());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_c37042b702114e4aacdc64f80a557e2f.FLDV_84ba2b7b264e441e878d84b9c899f44f());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_c37042b702114e4aacdc64f80a557e2f.FLDV_08a36da1e2d94bd3beb762cdbe040c17());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_c37042b702114e4aacdc64f80a557e2f.FLDV_e8ff75ed0a4c41479a063d6862f81762());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_c37042b702114e4aacdc64f80a557e2f.FLDV_38704bef0fc74ac89b6f235b4b209dba());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_c37042b702114e4aacdc64f80a557e2f.FLDV_ff2653d03f4446d08d72b45f1eb49a82());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_c37042b702114e4aacdc64f80a557e2f.FLDV_417c42b0d49744f184636a3a040bf2c8());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_c37042b702114e4aacdc64f80a557e2f.FLDV_cf4c14788e9840dc88b12ba855613a43());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_c37042b702114e4aacdc64f80a557e2f.DVAL_0979be227ac1474ab96fe74371640c08());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_c37042b702114e4aacdc64f80a557e2f.DVAL_64a2bee531df4300bbea74b4af6dcf56());
      }

      private sealed class MTHD_2a2b277272e04f579f133794e4d47ced : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a2b277272e04f579f133794e4d47ced()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_f930c8205b2d460dbe85749c18b9ea68 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f930c8205b2d460dbe85749c18b9ea68()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_237cec6c4773463bb43e7fcf1ff4eeb4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_237cec6c4773463bb43e7fcf1ff4eeb4()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_49a471e131b04df6b78e7411ae750b98 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49a471e131b04df6b78e7411ae750b98()
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

      private sealed class MTHD_6ae1c32a9fad4a42be47f602bfeb93db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ae1c32a9fad4a42be47f602bfeb93db()
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

      private sealed class MTHD_774b69c5e3c449b787871bc04e01ba11 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_774b69c5e3c449b787871bc04e01ba11()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_4218613a5d134455b06e8eca8e9ae1e4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4218613a5d134455b06e8eca8e9ae1e4()
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

      private sealed class MTHD_d02fd46338a74751b30884468bdef3af : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d02fd46338a74751b30884468bdef3af()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_862549a5c94e47b4bfbcaf56958f88f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_862549a5c94e47b4bfbcaf56958f88f7()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_3d64cc25d9664834936741e0b898ba73 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d64cc25d9664834936741e0b898ba73()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_071218eda67944bfa070b643f793202e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_071218eda67944bfa070b643f793202e()
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

      private sealed class MTHD_bb18326bdc6f4977ae5cb38487d26731 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb18326bdc6f4977ae5cb38487d26731()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_2970f8db24594ba7998d3051e368db8f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2970f8db24594ba7998d3051e368db8f()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_4f06c0947e7c4c5ab5b2a46e051f8f8a : HardwiredMemberDescriptor
      {
        internal FLDV_4f06c0947e7c4c5ab5b2a46e051f8f8a()
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

      private sealed class FLDV_84ba2b7b264e441e878d84b9c899f44f : HardwiredMemberDescriptor
      {
        internal FLDV_84ba2b7b264e441e878d84b9c899f44f()
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

      private sealed class FLDV_08a36da1e2d94bd3beb762cdbe040c17 : HardwiredMemberDescriptor
      {
        internal FLDV_08a36da1e2d94bd3beb762cdbe040c17()
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

      private sealed class FLDV_e8ff75ed0a4c41479a063d6862f81762 : HardwiredMemberDescriptor
      {
        internal FLDV_e8ff75ed0a4c41479a063d6862f81762()
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

      private sealed class FLDV_38704bef0fc74ac89b6f235b4b209dba : HardwiredMemberDescriptor
      {
        internal FLDV_38704bef0fc74ac89b6f235b4b209dba()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_ff2653d03f4446d08d72b45f1eb49a82 : HardwiredMemberDescriptor
      {
        internal FLDV_ff2653d03f4446d08d72b45f1eb49a82()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_417c42b0d49744f184636a3a040bf2c8 : HardwiredMemberDescriptor
      {
        internal FLDV_417c42b0d49744f184636a3a040bf2c8()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_cf4c14788e9840dc88b12ba855613a43 : HardwiredMemberDescriptor
      {
        internal FLDV_cf4c14788e9840dc88b12ba855613a43()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_0979be227ac1474ab96fe74371640c08 : DynValueMemberDescriptor
      {
        internal DVAL_0979be227ac1474ab96fe74371640c08()
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

      private sealed class DVAL_64a2bee531df4300bbea74b4af6dcf56 : DynValueMemberDescriptor
      {
        internal DVAL_64a2bee531df4300bbea74b4af6dcf56()
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

    private sealed class TYPE_dce94f764cc345178f83ae90598d8590 : HardwiredUserDataDescriptor
    {
      internal TYPE_dce94f764cc345178f83ae90598d8590()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dce94f764cc345178f83ae90598d8590.MTHD_3dcde6ae90d640c6976a5e8d5b51616a()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dce94f764cc345178f83ae90598d8590.MTHD_f8e314b520454442b0cb01ba09840379()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dce94f764cc345178f83ae90598d8590.MTHD_948d829a733c47ae9a9b1ac325ec60cb(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dce94f764cc345178f83ae90598d8590.MTHD_763acc21e778458f93914c9bffeaf755()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dce94f764cc345178f83ae90598d8590.MTHD_54ecf1211c7f4ff29c99fcd9979c2787(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dce94f764cc345178f83ae90598d8590.MTHD_430f6ebc185740bc9c7839a53522626f()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dce94f764cc345178f83ae90598d8590.MTHD_2787057a854545eaa29b560bbc0d8a95()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dce94f764cc345178f83ae90598d8590.MTHD_59a72cf6f0f34ccc9577a300c1066570()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dce94f764cc345178f83ae90598d8590.MTHD_960561bba0084dceaa3a4088ed6cffb0()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dce94f764cc345178f83ae90598d8590.MTHD_c9fc410c5b1f4e618bcae4387ce3f757()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_dce94f764cc345178f83ae90598d8590.FLDV_780b43246b5647e08aed5ec8e1be76ae());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_dce94f764cc345178f83ae90598d8590.FLDV_aa313914debf4eab8c0952f127645ca4());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_dce94f764cc345178f83ae90598d8590.FLDV_4f7ef3d4082b4f67804b643995625f13());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_dce94f764cc345178f83ae90598d8590.FLDV_27f72027f8a847babf66c1618741814c());
      }

      private sealed class MTHD_3dcde6ae90d640c6976a5e8d5b51616a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3dcde6ae90d640c6976a5e8d5b51616a()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_f8e314b520454442b0cb01ba09840379 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f8e314b520454442b0cb01ba09840379()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_948d829a733c47ae9a9b1ac325ec60cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_948d829a733c47ae9a9b1ac325ec60cb()
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

      private sealed class MTHD_763acc21e778458f93914c9bffeaf755 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_763acc21e778458f93914c9bffeaf755()
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

      private sealed class MTHD_54ecf1211c7f4ff29c99fcd9979c2787 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_54ecf1211c7f4ff29c99fcd9979c2787()
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

      private sealed class MTHD_430f6ebc185740bc9c7839a53522626f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_430f6ebc185740bc9c7839a53522626f()
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

      private sealed class MTHD_2787057a854545eaa29b560bbc0d8a95 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2787057a854545eaa29b560bbc0d8a95()
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

      private sealed class MTHD_59a72cf6f0f34ccc9577a300c1066570 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_59a72cf6f0f34ccc9577a300c1066570()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_960561bba0084dceaa3a4088ed6cffb0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_960561bba0084dceaa3a4088ed6cffb0()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_c9fc410c5b1f4e618bcae4387ce3f757 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c9fc410c5b1f4e618bcae4387ce3f757()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_780b43246b5647e08aed5ec8e1be76ae : HardwiredMemberDescriptor
      {
        internal FLDV_780b43246b5647e08aed5ec8e1be76ae()
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

      private sealed class FLDV_aa313914debf4eab8c0952f127645ca4 : HardwiredMemberDescriptor
      {
        internal FLDV_aa313914debf4eab8c0952f127645ca4()
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

      private sealed class FLDV_4f7ef3d4082b4f67804b643995625f13 : HardwiredMemberDescriptor
      {
        internal FLDV_4f7ef3d4082b4f67804b643995625f13()
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

      private sealed class FLDV_27f72027f8a847babf66c1618741814c : HardwiredMemberDescriptor
      {
        internal FLDV_27f72027f8a847babf66c1618741814c()
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

    private sealed class TYPE_644a3fc67e7544b586ef49d10e7c47b9 : HardwiredUserDataDescriptor
    {
      internal TYPE_644a3fc67e7544b586ef49d10e7c47b9()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_644a3fc67e7544b586ef49d10e7c47b9.MTHD_1e9cb7ceff9c4fa79083388ec6f09d9f()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_644a3fc67e7544b586ef49d10e7c47b9.MTHD_0e2487d90f0746119f3bfe4c9b4112bf()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_644a3fc67e7544b586ef49d10e7c47b9.MTHD_0766612c2ce94321ab1c4c1e4a0da966()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_644a3fc67e7544b586ef49d10e7c47b9.MTHD_431dabf2674a457bb6f70a42771ff0f8()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_644a3fc67e7544b586ef49d10e7c47b9.MTHD_35713cf15094447eb87a6ad186a93703()
        }));
      }

      private sealed class MTHD_1e9cb7ceff9c4fa79083388ec6f09d9f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1e9cb7ceff9c4fa79083388ec6f09d9f()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_0e2487d90f0746119f3bfe4c9b4112bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e2487d90f0746119f3bfe4c9b4112bf()
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

      private sealed class MTHD_0766612c2ce94321ab1c4c1e4a0da966 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0766612c2ce94321ab1c4c1e4a0da966()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_431dabf2674a457bb6f70a42771ff0f8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_431dabf2674a457bb6f70a42771ff0f8()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_35713cf15094447eb87a6ad186a93703 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35713cf15094447eb87a6ad186a93703()
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
