
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
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_414555a0f4434601b42e40ce8eeec2c1());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_a727a58b4ea14a5481e839c510eada34());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_94891f1d35684b19acbf36ac50186c1d());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_e1b921cdff1842beb096c1bf161dad51());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_3cfd592a21d5433fa1766ac1d4d45acf());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_4fdbc634a1bc4dd9ac23c09d27a61dd6());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_9978c3814cb147c4918032397d92b4fd());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_7086222dfdf042ce9ca28c5b09718529());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_d0653baac985446ab91461f37666ac36());
    }

    private sealed class TYPE_490ffa6053e04dd2a81e9585e7d65dc1 : HardwiredUserDataDescriptor
    {
      internal TYPE_490ffa6053e04dd2a81e9585e7d65dc1()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_a4da4e2f7b5841c3be2d11a90e48ec9a()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_8abbc6e17ad441879030763f608e28b9()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_5e67cc348f6a47c0a25d81ca62421832()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_204f1390a7b54f779ec178bfda4fbe81()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_a217207219fd48a5b1db49802ad20a5c()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_0e6839ad03e44b5aa40d80e691712cb1()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_295f49987beb4272b7fcf74802b11121()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_74c7d1a233854af5a16c16ba781af246()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_6c14a34c87a14c459401352ff1284653()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_2210aa3c0d824a3a8f47601fba6eaf37()
        }));
        this.AddMember("hideInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("hideInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_951e691eff1243f28c50068b98ef9cff()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_25ec5eb7de6d41d39e9e9a2afcd448d1()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_b5a32de847c446438c7dfa7bf20abf25()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_7a721909a5b640b480751605b7155b0b()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_6ca1310789424419b82458aaee0d8369()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_b2a4de8066ab49a6a0a086165dfc814a()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_3aad7f3cf4994976a4c720fbf7b9d8c6()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_f8566f9c3a524fe9a9bc6d6fa3822230()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_f56f14cc942645608504cabda42c8fec()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_c4e8806fd594438987cd353399a47aba()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_457b41208ed94fd7bb21bdfb9a4e259d()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_eb274877d22840f1885ccbdbef933870()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_baa0339f867849d9b58bc4623849bff7()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_6b3bba3268994390b2aa369b831bc6f4()
        }));
        this.AddMember("get_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_3c0abb0c4986496f9c77fcd8d903012a()
        }));
        this.AddMember("set_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_1d497b808d7a42c79f3102971b08180f()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_4a6a21a492ef4991954363b6237cf111()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_f2d168b2bfdf485b9c5974570ef96138()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_7fa696a6249043afa40f218faef7656f()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_dcee72d441284787a1ca2411786ddb6d()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_99600a2471634229b8498ad021b76a37()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_54eb44994e114c0db81e9a564ab9ae17()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_7a4cd10c65ab45cc8af334ddb6696d8b()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_3f58c93176e047698c407bd8f26ba52a()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_ba022c0fd0ce446da0769c349cc0e079()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_85ab3e8141f149b99b7ae2f04dae4c99()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_d1791aa8e06644e991bda0ab5d73d602()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_25bb2ab8a4944857a88e8aead5d6d4cb()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_0eeb70ecdb3e4207896def7a21af873f()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_aee3fbba4ab846c0b7e6704e1617e909()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_cf743ed8ba0e46688217bf93555d4830()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_be44ae4ebdab490d9db315d812a9ef38()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_4c37a256bbc34d41a543d62e57366fdb()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_a18e21477f6d4450adc452c1db50fc15()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_53531e99a4a643a09b5db3459f1a077c()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_a7d6affe9b6d44a5866f608046100601()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_3a702cdb37974358b8c4cc7c1669a9c3()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_7628fb7d01274004876369131147c1a9()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_70bd7beeaa704f5483e368faeab3821f()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_b168a14516214c4db157a47ca86c6672()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_77e9dd1ce2244a8b96afb19d80967dd0()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_e3dd3771401c451c8d32a263d28fd252()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_aef4f85f7e544164bf810685b73edc9c()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_d8eb326269f446a398e8c78fbd643835()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_3050558bc3404d44917d14cfadf4dddf()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_9ef52a13ba6940a2aa4e2802b480953a()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_63e6dfefcc9f471cab2ad8f363f0e785()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_2a614a9b5b634d1583771269e74840db()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_485c53b870e84c14b1145e09390bcfe1()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_7f7f993b6768463b9a7ea9192dc1febd()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_95964b3b9ce24cbdbf4ac49a1369e37d()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_33b8f7a54a4d45e4b50c0f4719b8e83c()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_37535e3ea7a24118bb5c8cabe23d7ab2()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_7b0b350964c44be2a0099f0796df4131()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_73cc1f94e53d482fa5e8bae0c7e8137f()
        }));
        this.AddMember("Dispose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Dispose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_e4143f5d77a34825b3ee528677206550()
        }));
        this.AddMember("drawImage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawImage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_4760dca5e9734d30b2afb5e62d71d9aa()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_005a3f18cb8a48119d7c369f82bb430c()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_3febd4eafbf745a4bda6e096e921aff1()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_598a9f700b56452196bad956e1424490()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_0d02cb5f00814c66ae48129cd5a0cc83()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_3e96c5e0d8054eb6b5afd06be91098ce()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_e9791901cda74f5ab9e820726bc13c10()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_34959b513c8a4b34a92dbf643ffeb7b9()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_391460fe48974e46b28b9fbc4704dc37()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_cc56cde4b91a4d0a9d9dae0677632811()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_d76e27dec13e4b66826851c1d1f1f49f()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_aed0ff6cfc3940cba50d32da57e6f6e9()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_d0c057ecbf934e7b87f16df90fa4737b()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_43cf012a03334b91962a7d96045d570d()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_0f8c15e84ab742c4bd574879448a115a()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_b65d2f913e404e54b5c600e17ade53f2()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_3bb39960c2b34028b9b9f1f048c6d89d()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_d1b451e96c7142b887f9b8b05bf20677()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_ba179241c1b94782bb557671309f2672()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_d4330441f6354a7ab2cdfa2c87cdbea0()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_f64011e2d6ad4557a838742dfd7755c0()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_cbda38afabd2411a9f97c47966793809()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_b90b689963ef4cc2ada3bd2aba93bc08()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_fb4f6275782947b093497e98fbf67be9()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_1f8b85f1b2be4e2fba4d730b74a7107f()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_823aad2892e9470a8b40660c968522e3()
        }));
        this.AddMember("cameraFollow", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("cameraFollow", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_760146baef3c401882ef2775eac53e05()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_c5499b6e31cf48418cebe7712411e632()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_66e32d4052b74423b2d9d69a89e022f6()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_24cd362ed22c464a971c03e9e22bc503()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_8faf61f4ad8746e980ee71ca7742f7a6()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_41f4e25a043f46ef8ea9219ed0c89348()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_a9dff638e95a4cddaeadda0be5ea78ce(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_b6206c04d6ab46e68a3135ea03bd6f6d()
        }));
        this.AddMember("getKeyBinds", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getKeyBinds", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_157ad66a816c4b8f94083cb8504c0b8d()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_c8375afdb8f84c09b2c8ec78efcf7fef()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_74f1f996345443d2923ca5c74e8dc34e()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_1d0e858ba7a94905b90f2dc78cb6caf5()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.MTHD_defc9eb38e3f44c8905e230b2e50ddc2()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_7185b84d36e84bde96edfd5b1da2a484());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_54ce9287acb346488b49fcedee55d887());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_44de1922473f45f7b023b7fde6b04a30());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_fb3bb1d147484108a4d527c9d1c021e3());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_27f9d443736c447fbd4cd684269f09bd());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_0b773dea5f2a49c0b2c4dac28efe21db());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_b9ea557ecd0e4bfc871f407d1cf33404());
        this.AddMember("allowMinionMovement", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_bfbf5564e8af45cfaa23685c0c1ebc52());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_7781c63fa6c7455f9215f397c962b77b());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_4b80e60df9774eaa90a02ac971a497ec());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_6befb1e2732e4f4eb50ac6922cbec43b());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_6178eb5778d74a4c85a22b4a57eff9aa());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_5d6c9caa162a48ce820aca98650f0c2e());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_ce397a6118bc4c39987d61399ebdf33e());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_f40e498627ae448da9f30529940ce289());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_deb0deb4333a4cd6ab1549a65b1ed8ec());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_bf85c1e462f542a48355fb1eb79ea48e());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_715378299abe4fd094d44ed0524a5eb6());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_9828b7aab2bb4191bdf095879607ac71());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_33a2eb1c2df743abb1a8b7c022a383cc());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_3e69c25a30804a45acbfcf725aaeabc2());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_44d77cf2b3ee4eb0bae8e3dfb207f9f9());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_bd028ff283d64e79abdf59e1b79b7f3c());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_f9cd094704a14a18b0e9d24f44844305());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_059aa64ac6304ce8821ef6080d776cff());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_0e539cf9c8604ea1a60332c0095a7920());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_08ca4c7588254e759adbc5671903a17b());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_880e8e1cf58f4646ae4ec2681cdec38c());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_80fb32ae38f84134b445335d2d5357b4());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_d3542acb3f394d1b9d6c5e5e92e33721());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_27694fac1a2d44fa8c6d0a45a373eb76());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_19409041e4c14cfc8cab7366a74cd045());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_490ffa6053e04dd2a81e9585e7d65dc1.PROP_1332d625c0a04b0294e85ca4893d982d());
      }

      private sealed class MTHD_a4da4e2f7b5841c3be2d11a90e48ec9a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a4da4e2f7b5841c3be2d11a90e48ec9a()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_8abbc6e17ad441879030763f608e28b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8abbc6e17ad441879030763f608e28b9()
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

      private sealed class MTHD_5e67cc348f6a47c0a25d81ca62421832 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e67cc348f6a47c0a25d81ca62421832()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_204f1390a7b54f779ec178bfda4fbe81 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_204f1390a7b54f779ec178bfda4fbe81()
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

      private sealed class MTHD_a217207219fd48a5b1db49802ad20a5c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a217207219fd48a5b1db49802ad20a5c()
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

      private sealed class MTHD_0e6839ad03e44b5aa40d80e691712cb1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e6839ad03e44b5aa40d80e691712cb1()
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

      private sealed class MTHD_295f49987beb4272b7fcf74802b11121 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_295f49987beb4272b7fcf74802b11121()
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

      private sealed class MTHD_74c7d1a233854af5a16c16ba781af246 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74c7d1a233854af5a16c16ba781af246()
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

      private sealed class MTHD_6c14a34c87a14c459401352ff1284653 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6c14a34c87a14c459401352ff1284653()
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

      private sealed class MTHD_2210aa3c0d824a3a8f47601fba6eaf37 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2210aa3c0d824a3a8f47601fba6eaf37()
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

      private sealed class MTHD_951e691eff1243f28c50068b98ef9cff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_951e691eff1243f28c50068b98ef9cff()
        {
          this.Initialize("hideInfo", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).hideInfo();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_25ec5eb7de6d41d39e9e9a2afcd448d1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_25ec5eb7de6d41d39e9e9a2afcd448d1()
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

      private sealed class MTHD_b5a32de847c446438c7dfa7bf20abf25 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b5a32de847c446438c7dfa7bf20abf25()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_7a721909a5b640b480751605b7155b0b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a721909a5b640b480751605b7155b0b()
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

      private sealed class MTHD_6ca1310789424419b82458aaee0d8369 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ca1310789424419b82458aaee0d8369()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_b2a4de8066ab49a6a0a086165dfc814a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b2a4de8066ab49a6a0a086165dfc814a()
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

      private sealed class MTHD_3aad7f3cf4994976a4c720fbf7b9d8c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3aad7f3cf4994976a4c720fbf7b9d8c6()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_f8566f9c3a524fe9a9bc6d6fa3822230 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f8566f9c3a524fe9a9bc6d6fa3822230()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_f56f14cc942645608504cabda42c8fec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f56f14cc942645608504cabda42c8fec()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_c4e8806fd594438987cd353399a47aba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c4e8806fd594438987cd353399a47aba()
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

      private sealed class MTHD_457b41208ed94fd7bb21bdfb9a4e259d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_457b41208ed94fd7bb21bdfb9a4e259d()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_eb274877d22840f1885ccbdbef933870 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb274877d22840f1885ccbdbef933870()
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

      private sealed class MTHD_baa0339f867849d9b58bc4623849bff7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_baa0339f867849d9b58bc4623849bff7()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_6b3bba3268994390b2aa369b831bc6f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b3bba3268994390b2aa369b831bc6f4()
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

      private sealed class MTHD_3c0abb0c4986496f9c77fcd8d903012a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3c0abb0c4986496f9c77fcd8d903012a()
        {
          this.Initialize("get_allowMinionMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMinionMovement;
        }
      }

      private sealed class MTHD_1d497b808d7a42c79f3102971b08180f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d497b808d7a42c79f3102971b08180f()
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

      private sealed class MTHD_4a6a21a492ef4991954363b6237cf111 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a6a21a492ef4991954363b6237cf111()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_f2d168b2bfdf485b9c5974570ef96138 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f2d168b2bfdf485b9c5974570ef96138()
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

      private sealed class MTHD_7fa696a6249043afa40f218faef7656f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7fa696a6249043afa40f218faef7656f()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_dcee72d441284787a1ca2411786ddb6d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dcee72d441284787a1ca2411786ddb6d()
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

      private sealed class MTHD_99600a2471634229b8498ad021b76a37 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99600a2471634229b8498ad021b76a37()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_54eb44994e114c0db81e9a564ab9ae17 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_54eb44994e114c0db81e9a564ab9ae17()
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

      private sealed class MTHD_7a4cd10c65ab45cc8af334ddb6696d8b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a4cd10c65ab45cc8af334ddb6696d8b()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_3f58c93176e047698c407bd8f26ba52a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f58c93176e047698c407bd8f26ba52a()
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

      private sealed class MTHD_ba022c0fd0ce446da0769c349cc0e079 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba022c0fd0ce446da0769c349cc0e079()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_85ab3e8141f149b99b7ae2f04dae4c99 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85ab3e8141f149b99b7ae2f04dae4c99()
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

      private sealed class MTHD_d1791aa8e06644e991bda0ab5d73d602 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1791aa8e06644e991bda0ab5d73d602()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_25bb2ab8a4944857a88e8aead5d6d4cb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_25bb2ab8a4944857a88e8aead5d6d4cb()
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

      private sealed class MTHD_0eeb70ecdb3e4207896def7a21af873f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0eeb70ecdb3e4207896def7a21af873f()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_aee3fbba4ab846c0b7e6704e1617e909 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aee3fbba4ab846c0b7e6704e1617e909()
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

      private sealed class MTHD_cf743ed8ba0e46688217bf93555d4830 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf743ed8ba0e46688217bf93555d4830()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_be44ae4ebdab490d9db315d812a9ef38 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be44ae4ebdab490d9db315d812a9ef38()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_4c37a256bbc34d41a543d62e57366fdb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c37a256bbc34d41a543d62e57366fdb()
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

      private sealed class MTHD_a18e21477f6d4450adc452c1db50fc15 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a18e21477f6d4450adc452c1db50fc15()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_53531e99a4a643a09b5db3459f1a077c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_53531e99a4a643a09b5db3459f1a077c()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_a7d6affe9b6d44a5866f608046100601 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a7d6affe9b6d44a5866f608046100601()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_3a702cdb37974358b8c4cc7c1669a9c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3a702cdb37974358b8c4cc7c1669a9c3()
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

      private sealed class MTHD_7628fb7d01274004876369131147c1a9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7628fb7d01274004876369131147c1a9()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_70bd7beeaa704f5483e368faeab3821f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70bd7beeaa704f5483e368faeab3821f()
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

      private sealed class MTHD_b168a14516214c4db157a47ca86c6672 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b168a14516214c4db157a47ca86c6672()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_77e9dd1ce2244a8b96afb19d80967dd0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_77e9dd1ce2244a8b96afb19d80967dd0()
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

      private sealed class MTHD_e3dd3771401c451c8d32a263d28fd252 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e3dd3771401c451c8d32a263d28fd252()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_aef4f85f7e544164bf810685b73edc9c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aef4f85f7e544164bf810685b73edc9c()
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

      private sealed class MTHD_d8eb326269f446a398e8c78fbd643835 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8eb326269f446a398e8c78fbd643835()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_3050558bc3404d44917d14cfadf4dddf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3050558bc3404d44917d14cfadf4dddf()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_9ef52a13ba6940a2aa4e2802b480953a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ef52a13ba6940a2aa4e2802b480953a()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_63e6dfefcc9f471cab2ad8f363f0e785 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_63e6dfefcc9f471cab2ad8f363f0e785()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_2a614a9b5b634d1583771269e74840db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a614a9b5b634d1583771269e74840db()
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

      private sealed class MTHD_485c53b870e84c14b1145e09390bcfe1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_485c53b870e84c14b1145e09390bcfe1()
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

      private sealed class MTHD_7f7f993b6768463b9a7ea9192dc1febd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f7f993b6768463b9a7ea9192dc1febd()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_95964b3b9ce24cbdbf4ac49a1369e37d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95964b3b9ce24cbdbf4ac49a1369e37d()
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

      private sealed class MTHD_33b8f7a54a4d45e4b50c0f4719b8e83c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_33b8f7a54a4d45e4b50c0f4719b8e83c()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_37535e3ea7a24118bb5c8cabe23d7ab2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_37535e3ea7a24118bb5c8cabe23d7ab2()
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

      private sealed class MTHD_7b0b350964c44be2a0099f0796df4131 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b0b350964c44be2a0099f0796df4131()
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

      private sealed class MTHD_73cc1f94e53d482fa5e8bae0c7e8137f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_73cc1f94e53d482fa5e8bae0c7e8137f()
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

      private sealed class MTHD_e4143f5d77a34825b3ee528677206550 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e4143f5d77a34825b3ee528677206550()
        {
          this.Initialize("Dispose", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ContainerGame.Dispose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_4760dca5e9734d30b2afb5e62d71d9aa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4760dca5e9734d30b2afb5e62d71d9aa()
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

      private sealed class MTHD_005a3f18cb8a48119d7c369f82bb430c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_005a3f18cb8a48119d7c369f82bb430c()
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

      private sealed class MTHD_3febd4eafbf745a4bda6e096e921aff1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3febd4eafbf745a4bda6e096e921aff1()
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

      private sealed class MTHD_598a9f700b56452196bad956e1424490 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_598a9f700b56452196bad956e1424490()
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

      private sealed class MTHD_0d02cb5f00814c66ae48129cd5a0cc83 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d02cb5f00814c66ae48129cd5a0cc83()
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

      private sealed class MTHD_3e96c5e0d8054eb6b5afd06be91098ce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e96c5e0d8054eb6b5afd06be91098ce()
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

      private sealed class MTHD_e9791901cda74f5ab9e820726bc13c10 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e9791901cda74f5ab9e820726bc13c10()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_34959b513c8a4b34a92dbf643ffeb7b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_34959b513c8a4b34a92dbf643ffeb7b9()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_391460fe48974e46b28b9fbc4704dc37 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_391460fe48974e46b28b9fbc4704dc37()
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

      private sealed class MTHD_cc56cde4b91a4d0a9d9dae0677632811 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cc56cde4b91a4d0a9d9dae0677632811()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_d76e27dec13e4b66826851c1d1f1f49f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d76e27dec13e4b66826851c1d1f1f49f()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_aed0ff6cfc3940cba50d32da57e6f6e9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aed0ff6cfc3940cba50d32da57e6f6e9()
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

      private sealed class MTHD_d0c057ecbf934e7b87f16df90fa4737b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0c057ecbf934e7b87f16df90fa4737b()
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

      private sealed class MTHD_43cf012a03334b91962a7d96045d570d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_43cf012a03334b91962a7d96045d570d()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_0f8c15e84ab742c4bd574879448a115a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f8c15e84ab742c4bd574879448a115a()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b65d2f913e404e54b5c600e17ade53f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b65d2f913e404e54b5c600e17ade53f2()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_3bb39960c2b34028b9b9f1f048c6d89d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3bb39960c2b34028b9b9f1f048c6d89d()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_d1b451e96c7142b887f9b8b05bf20677 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1b451e96c7142b887f9b8b05bf20677()
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

      private sealed class MTHD_ba179241c1b94782bb557671309f2672 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba179241c1b94782bb557671309f2672()
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

      private sealed class MTHD_d4330441f6354a7ab2cdfa2c87cdbea0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d4330441f6354a7ab2cdfa2c87cdbea0()
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

      private sealed class MTHD_f64011e2d6ad4557a838742dfd7755c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f64011e2d6ad4557a838742dfd7755c0()
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

      private sealed class MTHD_cbda38afabd2411a9f97c47966793809 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cbda38afabd2411a9f97c47966793809()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_b90b689963ef4cc2ada3bd2aba93bc08 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b90b689963ef4cc2ada3bd2aba93bc08()
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

      private sealed class MTHD_fb4f6275782947b093497e98fbf67be9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb4f6275782947b093497e98fbf67be9()
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

      private sealed class MTHD_1f8b85f1b2be4e2fba4d730b74a7107f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f8b85f1b2be4e2fba4d730b74a7107f()
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

      private sealed class MTHD_823aad2892e9470a8b40660c968522e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_823aad2892e9470a8b40660c968522e3()
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

      private sealed class MTHD_760146baef3c401882ef2775eac53e05 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_760146baef3c401882ef2775eac53e05()
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

      private sealed class MTHD_c5499b6e31cf48418cebe7712411e632 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c5499b6e31cf48418cebe7712411e632()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_66e32d4052b74423b2d9d69a89e022f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_66e32d4052b74423b2d9d69a89e022f6()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_24cd362ed22c464a971c03e9e22bc503 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24cd362ed22c464a971c03e9e22bc503()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_8faf61f4ad8746e980ee71ca7742f7a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8faf61f4ad8746e980ee71ca7742f7a6()
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

      private sealed class MTHD_41f4e25a043f46ef8ea9219ed0c89348 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41f4e25a043f46ef8ea9219ed0c89348()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_a9dff638e95a4cddaeadda0be5ea78ce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a9dff638e95a4cddaeadda0be5ea78ce()
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

      private sealed class MTHD_b6206c04d6ab46e68a3135ea03bd6f6d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b6206c04d6ab46e68a3135ea03bd6f6d()
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

      private sealed class MTHD_157ad66a816c4b8f94083cb8504c0b8d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_157ad66a816c4b8f94083cb8504c0b8d()
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

      private sealed class MTHD_c8375afdb8f84c09b2c8ec78efcf7fef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c8375afdb8f84c09b2c8ec78efcf7fef()
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

      private sealed class MTHD_74f1f996345443d2923ca5c74e8dc34e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74f1f996345443d2923ca5c74e8dc34e()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_1d0e858ba7a94905b90f2dc78cb6caf5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d0e858ba7a94905b90f2dc78cb6caf5()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_defc9eb38e3f44c8905e230b2e50ddc2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_defc9eb38e3f44c8905e230b2e50ddc2()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_7185b84d36e84bde96edfd5b1da2a484 : HardwiredMemberDescriptor
      {
        internal PROP_7185b84d36e84bde96edfd5b1da2a484()
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

      private sealed class PROP_54ce9287acb346488b49fcedee55d887 : HardwiredMemberDescriptor
      {
        internal PROP_54ce9287acb346488b49fcedee55d887()
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

      private sealed class PROP_44de1922473f45f7b023b7fde6b04a30 : HardwiredMemberDescriptor
      {
        internal PROP_44de1922473f45f7b023b7fde6b04a30()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_fb3bb1d147484108a4d527c9d1c021e3 : HardwiredMemberDescriptor
      {
        internal PROP_fb3bb1d147484108a4d527c9d1c021e3()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_27f9d443736c447fbd4cd684269f09bd : HardwiredMemberDescriptor
      {
        internal PROP_27f9d443736c447fbd4cd684269f09bd()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_0b773dea5f2a49c0b2c4dac28efe21db : HardwiredMemberDescriptor
      {
        internal PROP_0b773dea5f2a49c0b2c4dac28efe21db()
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

      private sealed class PROP_b9ea557ecd0e4bfc871f407d1cf33404 : HardwiredMemberDescriptor
      {
        internal PROP_b9ea557ecd0e4bfc871f407d1cf33404()
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

      private sealed class PROP_bfbf5564e8af45cfaa23685c0c1ebc52 : HardwiredMemberDescriptor
      {
        internal PROP_bfbf5564e8af45cfaa23685c0c1ebc52()
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

      private sealed class PROP_7781c63fa6c7455f9215f397c962b77b : HardwiredMemberDescriptor
      {
        internal PROP_7781c63fa6c7455f9215f397c962b77b()
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

      private sealed class PROP_4b80e60df9774eaa90a02ac971a497ec : HardwiredMemberDescriptor
      {
        internal PROP_4b80e60df9774eaa90a02ac971a497ec()
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

      private sealed class PROP_6befb1e2732e4f4eb50ac6922cbec43b : HardwiredMemberDescriptor
      {
        internal PROP_6befb1e2732e4f4eb50ac6922cbec43b()
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

      private sealed class PROP_6178eb5778d74a4c85a22b4a57eff9aa : HardwiredMemberDescriptor
      {
        internal PROP_6178eb5778d74a4c85a22b4a57eff9aa()
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

      private sealed class PROP_5d6c9caa162a48ce820aca98650f0c2e : HardwiredMemberDescriptor
      {
        internal PROP_5d6c9caa162a48ce820aca98650f0c2e()
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

      private sealed class PROP_ce397a6118bc4c39987d61399ebdf33e : HardwiredMemberDescriptor
      {
        internal PROP_ce397a6118bc4c39987d61399ebdf33e()
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

      private sealed class PROP_f40e498627ae448da9f30529940ce289 : HardwiredMemberDescriptor
      {
        internal PROP_f40e498627ae448da9f30529940ce289()
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

      private sealed class PROP_deb0deb4333a4cd6ab1549a65b1ed8ec : HardwiredMemberDescriptor
      {
        internal PROP_deb0deb4333a4cd6ab1549a65b1ed8ec()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_bf85c1e462f542a48355fb1eb79ea48e : HardwiredMemberDescriptor
      {
        internal PROP_bf85c1e462f542a48355fb1eb79ea48e()
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

      private sealed class PROP_715378299abe4fd094d44ed0524a5eb6 : HardwiredMemberDescriptor
      {
        internal PROP_715378299abe4fd094d44ed0524a5eb6()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_9828b7aab2bb4191bdf095879607ac71 : HardwiredMemberDescriptor
      {
        internal PROP_9828b7aab2bb4191bdf095879607ac71()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_33a2eb1c2df743abb1a8b7c022a383cc : HardwiredMemberDescriptor
      {
        internal PROP_33a2eb1c2df743abb1a8b7c022a383cc()
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

      private sealed class PROP_3e69c25a30804a45acbfcf725aaeabc2 : HardwiredMemberDescriptor
      {
        internal PROP_3e69c25a30804a45acbfcf725aaeabc2()
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

      private sealed class PROP_44d77cf2b3ee4eb0bae8e3dfb207f9f9 : HardwiredMemberDescriptor
      {
        internal PROP_44d77cf2b3ee4eb0bae8e3dfb207f9f9()
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

      private sealed class PROP_bd028ff283d64e79abdf59e1b79b7f3c : HardwiredMemberDescriptor
      {
        internal PROP_bd028ff283d64e79abdf59e1b79b7f3c()
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

      private sealed class PROP_f9cd094704a14a18b0e9d24f44844305 : HardwiredMemberDescriptor
      {
        internal PROP_f9cd094704a14a18b0e9d24f44844305()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_059aa64ac6304ce8821ef6080d776cff : HardwiredMemberDescriptor
      {
        internal PROP_059aa64ac6304ce8821ef6080d776cff()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_0e539cf9c8604ea1a60332c0095a7920 : HardwiredMemberDescriptor
      {
        internal PROP_0e539cf9c8604ea1a60332c0095a7920()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_08ca4c7588254e759adbc5671903a17b : HardwiredMemberDescriptor
      {
        internal PROP_08ca4c7588254e759adbc5671903a17b()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_880e8e1cf58f4646ae4ec2681cdec38c : HardwiredMemberDescriptor
      {
        internal PROP_880e8e1cf58f4646ae4ec2681cdec38c()
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

      private sealed class PROP_80fb32ae38f84134b445335d2d5357b4 : HardwiredMemberDescriptor
      {
        internal PROP_80fb32ae38f84134b445335d2d5357b4()
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

      private sealed class PROP_d3542acb3f394d1b9d6c5e5e92e33721 : HardwiredMemberDescriptor
      {
        internal PROP_d3542acb3f394d1b9d6c5e5e92e33721()
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

      private sealed class PROP_27694fac1a2d44fa8c6d0a45a373eb76 : HardwiredMemberDescriptor
      {
        internal PROP_27694fac1a2d44fa8c6d0a45a373eb76()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_19409041e4c14cfc8cab7366a74cd045 : HardwiredMemberDescriptor
      {
        internal PROP_19409041e4c14cfc8cab7366a74cd045()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_1332d625c0a04b0294e85ca4893d982d : HardwiredMemberDescriptor
      {
        internal PROP_1332d625c0a04b0294e85ca4893d982d()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_414555a0f4434601b42e40ce8eeec2c1 : HardwiredUserDataDescriptor
    {
      internal TYPE_414555a0f4434601b42e40ce8eeec2c1()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_414555a0f4434601b42e40ce8eeec2c1.MTHD_8ea74bfd41bb4e74a96938d899a2bc2c()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_414555a0f4434601b42e40ce8eeec2c1.MTHD_03ad266f463f48beae5c0718a4663df1()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_414555a0f4434601b42e40ce8eeec2c1.MTHD_db6b6dccefe1426d9d0f54652e994050()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_414555a0f4434601b42e40ce8eeec2c1.MTHD_692b8cbd0ae9447cacc1cc1325543ae5()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_414555a0f4434601b42e40ce8eeec2c1.MTHD_686f6dd84ac5448ca1aa989cef12688b()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_414555a0f4434601b42e40ce8eeec2c1.MTHD_919d3fbdb3b740bebeaedec7bd592319()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_414555a0f4434601b42e40ce8eeec2c1.MTHD_ec1bd11f733343d6b56fce9e7f6dbdaf()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_414555a0f4434601b42e40ce8eeec2c1.MTHD_9ed215e72e724882a43a67e2fa9bfad6()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_414555a0f4434601b42e40ce8eeec2c1.MTHD_e0ae2420c4a04a8ea7a714835d49140b()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_414555a0f4434601b42e40ce8eeec2c1.MTHD_f200979d8b5f4299ae2d02f06833b58a()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_414555a0f4434601b42e40ce8eeec2c1.MTHD_f22f066d785b46cc8a0db7c1030a1aeb()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_414555a0f4434601b42e40ce8eeec2c1.MTHD_2729011b752844f28c7d584ef7461a0f()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_414555a0f4434601b42e40ce8eeec2c1.PROP_1edc0e1399074fd99002adcaf77064b8());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_414555a0f4434601b42e40ce8eeec2c1.PROP_fb5420c62875492fbdf2d6fd47579933());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_414555a0f4434601b42e40ce8eeec2c1.PROP_9d49c0c851d7482ea9786203f4cd9075());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_414555a0f4434601b42e40ce8eeec2c1.PROP_4eb22dadbf8b48ea91aac1509f3777da());
      }

      private sealed class MTHD_8ea74bfd41bb4e74a96938d899a2bc2c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ea74bfd41bb4e74a96938d899a2bc2c()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_03ad266f463f48beae5c0718a4663df1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_03ad266f463f48beae5c0718a4663df1()
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

      private sealed class MTHD_db6b6dccefe1426d9d0f54652e994050 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db6b6dccefe1426d9d0f54652e994050()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_692b8cbd0ae9447cacc1cc1325543ae5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_692b8cbd0ae9447cacc1cc1325543ae5()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_686f6dd84ac5448ca1aa989cef12688b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_686f6dd84ac5448ca1aa989cef12688b()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_919d3fbdb3b740bebeaedec7bd592319 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_919d3fbdb3b740bebeaedec7bd592319()
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

      private sealed class MTHD_ec1bd11f733343d6b56fce9e7f6dbdaf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec1bd11f733343d6b56fce9e7f6dbdaf()
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

      private sealed class MTHD_9ed215e72e724882a43a67e2fa9bfad6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ed215e72e724882a43a67e2fa9bfad6()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_e0ae2420c4a04a8ea7a714835d49140b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e0ae2420c4a04a8ea7a714835d49140b()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_f200979d8b5f4299ae2d02f06833b58a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f200979d8b5f4299ae2d02f06833b58a()
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

      private sealed class MTHD_f22f066d785b46cc8a0db7c1030a1aeb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f22f066d785b46cc8a0db7c1030a1aeb()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_2729011b752844f28c7d584ef7461a0f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2729011b752844f28c7d584ef7461a0f()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_1edc0e1399074fd99002adcaf77064b8 : HardwiredMemberDescriptor
      {
        internal PROP_1edc0e1399074fd99002adcaf77064b8()
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

      private sealed class PROP_fb5420c62875492fbdf2d6fd47579933 : HardwiredMemberDescriptor
      {
        internal PROP_fb5420c62875492fbdf2d6fd47579933()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_9d49c0c851d7482ea9786203f4cd9075 : HardwiredMemberDescriptor
      {
        internal PROP_9d49c0c851d7482ea9786203f4cd9075()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_4eb22dadbf8b48ea91aac1509f3777da : HardwiredMemberDescriptor
      {
        internal PROP_4eb22dadbf8b48ea91aac1509f3777da()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_09ae7ed9ea5445478d7896101ccaba76 : HardwiredUserDataDescriptor
    {
      internal TYPE_09ae7ed9ea5445478d7896101ccaba76()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_ee0f4b8913d844788e755e49939bc276()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_429a44165b1b4fb8b5541a549517e001()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_e7598e3d5a7243269ab278080ed52436()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_d9a75159c04042c496b2cff6e5ac02cf()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_b35a587f824e475ba999e3a08be15a84()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_b7b0a2e5b78b436f9d8ab45c2a3f813a()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_d536f5365cce4833b832043316534950()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_ac62e7638e9844a3afdbfb51ec6ad580()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_8498d017bd574e5b845721d94557b25d()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_d00e8cbddcd544ec9f4d294393b48886()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_cea25b614f6b4696ba050d5d7f75d4ef()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_377dfa4dbe0d479ebb79ba11e2d08ea0()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_10542f568b684ba495e6d5fadc6a7b1b()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_7f6da4fd401844b6b9b0b408bd635425()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_649b63d92a794baca40644f6f03f485b()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_5eced208cbdb4a5c9ef13694eb59dccf()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_f7b1f2aed8fb4632b8df38e0218dd187()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_30bb68b4b85d41d6ac3136ebb2961884()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_a4e3ac4d92e04d04a6b1337a636b43ad()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_39890db95155471b9bb6e7885ad89029()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_7a43130fd1584b85abd3c814f8d725e5()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_363d0b97f9cb4c6a991aadcca75c9aac()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_14318a4aad8445a782bff8b70a6aaec4()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_171fe41276e042bfacf0b1b3612ab1da()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_d1ef98e75a69473b8aad0633427f82bd()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_610dcdcac6a64443b8edb6f87dcbf119()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_22ad9ac5b2254e80a1c4f72c80a08c41()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_63ecd8bd46b340dd83421fa32152bebe()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_fc17d890b25a407c8c736f1dfe428957()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_ac4e50d09cda434295fe3b9293ce732a()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_1e5d010501a94cba944fd551ccd4e947()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_0a1591ae09c44093b367d47bf14b6a6d()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_4e6aaab50d3c4a2686a625a6d56c91e7()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_88682f9d59994602975b7ff0010b9c31()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_d4cacccec69b488a92ba51ae150854d4()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_1a9528f5a26943a1846402c47e646a2e()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_5f1914ba2b2949ada14f9ecc4e6d85ba()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_9905c20237984151b6f8c099eed72df4()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_f7e21835e3ef47fea7cc301bca252051()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_ef7e03fb872e406c98d4d7cac3cf123d()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_b2c2259df533420487215a5ca81e78b7()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_faf5ec8b30164c12b6426e048e0cd320()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_05b6b44007e94090aa72d7600147dea2()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_7d3c2ed9ec154cdc9eda753921209ea6()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_faf6b8fbfbdb441a83fa9af294e6a6cd()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_04af9153f74340ec9f9559dde7cc8ca6()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_e4cfcee19b7b4c6cb426f4b0bc1104e5()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_2e523f66c68e4c9a8f1d14cad4560b8e()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_00a375e16da540bcab1799d81a8bb0e7()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_bca255eda9324a3da8aedcd843cc24d0()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_a59a23c6d8384d48a7becda127604d11()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_6e986cd5fdd749488b56b50829443e96()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_e6229d7ac2b14821b13520e22b2e3c2e()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_cf3b7c19c54e4fed9666143ed4e7b36c()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_3678993e9df345b1813dd7eeae319e5e()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_11280c106b944360b46435be56d8c280()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_e8157742a7b64c96a99d5a3148f3092f()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_b8c0065ca22240ca956c3043fde426f4()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_53c2b98954304ca6bddaf144e6fdc3bc()
        }));
        this.AddMember("getDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_8ab503d1e86c4ba9b06cb2fb0a8b012a()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_4925e012a6df446cb938b3ee1dd9fd69()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_ede5346e6caa4626afb9874f5d6c45b8()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_81f1f56cabf34cd083c68720245577d6()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_729359eb12084c64854963fc0d51f6a4()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_3115853b1f254a0e940c552809b8c7bb(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_714c27d000814610b4b062d732938a87()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_160bf06e0bfd4cd0a50844180bcfd199(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_a7bc521fc0c44c6eb40d3233a22408c6()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_5a785a1633c9424192d916ac3141e977()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_7aaf170898f446d1b9fe408f9064f924()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_0913f842138d4d01b3655f206b33eb87(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_f02514055f8b4ae1885809873432b1e7()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_6d5b5670ad3a42fa82525e46ed2461c2()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_0029d680de1a4c05add00329082e63c4()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_006153dad5874bdca5dcb3bf10bd71e5()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_d5971919a87548c9a09ab34c3e7ec489()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_be76c2c4ac804caa92f20ed4d43033c7()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_d672125a955243f688b5696812d471e3()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_c7c8be817e7e48d9bd62a2d693433ef1()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_414bdab742724b008954a5b8f133bef1()
        }));
        this.AddMember("angleToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("angleToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_90e7170633494f73a26271fbec349159()
        }));
        this.AddMember("powerToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("powerToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_42db921593c643d3b8b820b68169f6f9()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_f058ff9302ec442e9ad97f1abef14eeb(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_117e80b1271346268022a2b8d8401202()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_71804e4b415f4a18bf8d229e860e4b41(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_05b4a70085514094b7829d6d645b7b60()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_721e1226f1594d8cab0eeab295da06a2()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_fb3dead70c3747968017844fb58aa44a()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_30794c6249444916ab9863c83f8718b3()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_d17ce024c6c5499eb26474743743d701()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_a311eb2e064c4d63805644d3e79c1b75()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.MTHD_4419854e03af426fb2b0d6317a35fda7()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_93e9a077ed1d4d6599c1590cbe5d1064());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_a1d6c26d95064640b351dc706ee25ece());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_0b2209c5180743a3987e0f6567d516d1());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_d683541591f04db1aea2751d123c7409());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_9205abcc2e43425ebc30af383ab775e5());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_75b4dce4f7e341028171c1c0aaaec5f9());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_a7592b9ae13741d5a90e478b8a569086());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_2de6082c7d824724b4e22917617ac96e());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_cf7f577ac36d47c0ae98c2fd3b171290());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_b1dc15641b0144e0b3ccc50b1c8ca2f0());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_d7cd144cc0c8433e95302923872714e6());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_00448bdf45384e73ba76f2815089b58f());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_0f6a377972a849d4abc6d9e23eb8b4a2());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_888e0a19fe724bdfb090bf9d9b07cbdb());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_c22b90162fcb48328cbc766b56e35a5c());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_7140c35827d247169b662b28a0db7af0());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_8c773c517adc4e1c82af48474e7c71fb());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_4a5cf2d3814048c8b626c43d2ddabb8e());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_7b49029196e94f738d0bc62a64c915f4());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_4d595ffe6d1a456a86d63e46bb1c27a3());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_cf689a9bfe9740fea901a8a722cacea3());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_9dae3d6b443342e9a2c825a2d2f0f1cb());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_548b45a0e37f46489bc9651db0a86bb9());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_7d51046eaf95412f82824e7cab9aaa88());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_26ff4584236545228dac1371e6f7af13());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_a8fd1be1f6404e43ac6247a8d4deb130());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_af49da25570c476b9eced0d82dbf00e1());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_6b049dc4eb174763bdaae196406c6dad());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_e495aad2d7d44d838cd4a9a7a93dd104());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_06817c915572461c848a1dff15f19a4e());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_9111e911e09a4210ae6f5e431513c87c());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_2e1de3562dea44c4af894013d0ee8764());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_09ae7ed9ea5445478d7896101ccaba76.PROP_b58ef346ff3f47ce9a69eb1b8d5b9e31());
      }

      private sealed class MTHD_ee0f4b8913d844788e755e49939bc276 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee0f4b8913d844788e755e49939bc276()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_429a44165b1b4fb8b5541a549517e001 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_429a44165b1b4fb8b5541a549517e001()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_e7598e3d5a7243269ab278080ed52436 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7598e3d5a7243269ab278080ed52436()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_d9a75159c04042c496b2cff6e5ac02cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d9a75159c04042c496b2cff6e5ac02cf()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_b35a587f824e475ba999e3a08be15a84 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b35a587f824e475ba999e3a08be15a84()
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

      private sealed class MTHD_b7b0a2e5b78b436f9d8ab45c2a3f813a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b7b0a2e5b78b436f9d8ab45c2a3f813a()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_d536f5365cce4833b832043316534950 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d536f5365cce4833b832043316534950()
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

      private sealed class MTHD_ac62e7638e9844a3afdbfb51ec6ad580 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac62e7638e9844a3afdbfb51ec6ad580()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_8498d017bd574e5b845721d94557b25d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8498d017bd574e5b845721d94557b25d()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_d00e8cbddcd544ec9f4d294393b48886 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d00e8cbddcd544ec9f4d294393b48886()
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

      private sealed class MTHD_cea25b614f6b4696ba050d5d7f75d4ef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cea25b614f6b4696ba050d5d7f75d4ef()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_377dfa4dbe0d479ebb79ba11e2d08ea0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_377dfa4dbe0d479ebb79ba11e2d08ea0()
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

      private sealed class MTHD_10542f568b684ba495e6d5fadc6a7b1b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_10542f568b684ba495e6d5fadc6a7b1b()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_7f6da4fd401844b6b9b0b408bd635425 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f6da4fd401844b6b9b0b408bd635425()
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

      private sealed class MTHD_649b63d92a794baca40644f6f03f485b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_649b63d92a794baca40644f6f03f485b()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_5eced208cbdb4a5c9ef13694eb59dccf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5eced208cbdb4a5c9ef13694eb59dccf()
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

      private sealed class MTHD_f7b1f2aed8fb4632b8df38e0218dd187 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7b1f2aed8fb4632b8df38e0218dd187()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_30bb68b4b85d41d6ac3136ebb2961884 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_30bb68b4b85d41d6ac3136ebb2961884()
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

      private sealed class MTHD_a4e3ac4d92e04d04a6b1337a636b43ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a4e3ac4d92e04d04a6b1337a636b43ad()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_39890db95155471b9bb6e7885ad89029 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_39890db95155471b9bb6e7885ad89029()
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

      private sealed class MTHD_7a43130fd1584b85abd3c814f8d725e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a43130fd1584b85abd3c814f8d725e5()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_363d0b97f9cb4c6a991aadcca75c9aac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_363d0b97f9cb4c6a991aadcca75c9aac()
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

      private sealed class MTHD_14318a4aad8445a782bff8b70a6aaec4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_14318a4aad8445a782bff8b70a6aaec4()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_171fe41276e042bfacf0b1b3612ab1da : HardwiredMethodMemberDescriptor
      {
        internal MTHD_171fe41276e042bfacf0b1b3612ab1da()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_d1ef98e75a69473b8aad0633427f82bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1ef98e75a69473b8aad0633427f82bd()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_610dcdcac6a64443b8edb6f87dcbf119 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_610dcdcac6a64443b8edb6f87dcbf119()
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

      private sealed class MTHD_22ad9ac5b2254e80a1c4f72c80a08c41 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22ad9ac5b2254e80a1c4f72c80a08c41()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_63ecd8bd46b340dd83421fa32152bebe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_63ecd8bd46b340dd83421fa32152bebe()
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

      private sealed class MTHD_fc17d890b25a407c8c736f1dfe428957 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fc17d890b25a407c8c736f1dfe428957()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_ac4e50d09cda434295fe3b9293ce732a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac4e50d09cda434295fe3b9293ce732a()
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

      private sealed class MTHD_1e5d010501a94cba944fd551ccd4e947 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1e5d010501a94cba944fd551ccd4e947()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_0a1591ae09c44093b367d47bf14b6a6d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0a1591ae09c44093b367d47bf14b6a6d()
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

      private sealed class MTHD_4e6aaab50d3c4a2686a625a6d56c91e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e6aaab50d3c4a2686a625a6d56c91e7()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_88682f9d59994602975b7ff0010b9c31 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_88682f9d59994602975b7ff0010b9c31()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_d4cacccec69b488a92ba51ae150854d4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d4cacccec69b488a92ba51ae150854d4()
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

      private sealed class MTHD_1a9528f5a26943a1846402c47e646a2e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a9528f5a26943a1846402c47e646a2e()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_5f1914ba2b2949ada14f9ecc4e6d85ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5f1914ba2b2949ada14f9ecc4e6d85ba()
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

      private sealed class MTHD_9905c20237984151b6f8c099eed72df4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9905c20237984151b6f8c099eed72df4()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_f7e21835e3ef47fea7cc301bca252051 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7e21835e3ef47fea7cc301bca252051()
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

      private sealed class MTHD_ef7e03fb872e406c98d4d7cac3cf123d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef7e03fb872e406c98d4d7cac3cf123d()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_b2c2259df533420487215a5ca81e78b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b2c2259df533420487215a5ca81e78b7()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_faf5ec8b30164c12b6426e048e0cd320 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_faf5ec8b30164c12b6426e048e0cd320()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_05b6b44007e94090aa72d7600147dea2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_05b6b44007e94090aa72d7600147dea2()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_7d3c2ed9ec154cdc9eda753921209ea6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7d3c2ed9ec154cdc9eda753921209ea6()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_faf6b8fbfbdb441a83fa9af294e6a6cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_faf6b8fbfbdb441a83fa9af294e6a6cd()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_04af9153f74340ec9f9559dde7cc8ca6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_04af9153f74340ec9f9559dde7cc8ca6()
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

      private sealed class MTHD_e4cfcee19b7b4c6cb426f4b0bc1104e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e4cfcee19b7b4c6cb426f4b0bc1104e5()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_2e523f66c68e4c9a8f1d14cad4560b8e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2e523f66c68e4c9a8f1d14cad4560b8e()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_00a375e16da540bcab1799d81a8bb0e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_00a375e16da540bcab1799d81a8bb0e7()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_bca255eda9324a3da8aedcd843cc24d0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bca255eda9324a3da8aedcd843cc24d0()
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

      private sealed class MTHD_a59a23c6d8384d48a7becda127604d11 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a59a23c6d8384d48a7becda127604d11()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_6e986cd5fdd749488b56b50829443e96 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e986cd5fdd749488b56b50829443e96()
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

      private sealed class MTHD_e6229d7ac2b14821b13520e22b2e3c2e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e6229d7ac2b14821b13520e22b2e3c2e()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_cf3b7c19c54e4fed9666143ed4e7b36c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf3b7c19c54e4fed9666143ed4e7b36c()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_3678993e9df345b1813dd7eeae319e5e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3678993e9df345b1813dd7eeae319e5e()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_11280c106b944360b46435be56d8c280 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_11280c106b944360b46435be56d8c280()
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

      private sealed class MTHD_e8157742a7b64c96a99d5a3148f3092f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e8157742a7b64c96a99d5a3148f3092f()
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

      private sealed class MTHD_b8c0065ca22240ca956c3043fde426f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b8c0065ca22240ca956c3043fde426f4()
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

      private sealed class MTHD_53c2b98954304ca6bddaf144e6fdc3bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_53c2b98954304ca6bddaf144e6fdc3bc()
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

      private sealed class MTHD_8ab503d1e86c4ba9b06cb2fb0a8b012a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ab503d1e86c4ba9b06cb2fb0a8b012a()
        {
          this.Initialize("getDirection", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getDirection();
        }
      }

      private sealed class MTHD_4925e012a6df446cb938b3ee1dd9fd69 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4925e012a6df446cb938b3ee1dd9fd69()
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

      private sealed class MTHD_ede5346e6caa4626afb9874f5d6c45b8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ede5346e6caa4626afb9874f5d6c45b8()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_81f1f56cabf34cd083c68720245577d6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_81f1f56cabf34cd083c68720245577d6()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_729359eb12084c64854963fc0d51f6a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_729359eb12084c64854963fc0d51f6a4()
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

      private sealed class MTHD_3115853b1f254a0e940c552809b8c7bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3115853b1f254a0e940c552809b8c7bb()
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

      private sealed class MTHD_714c27d000814610b4b062d732938a87 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_714c27d000814610b4b062d732938a87()
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

      private sealed class MTHD_160bf06e0bfd4cd0a50844180bcfd199 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_160bf06e0bfd4cd0a50844180bcfd199()
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

      private sealed class MTHD_a7bc521fc0c44c6eb40d3233a22408c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a7bc521fc0c44c6eb40d3233a22408c6()
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

      private sealed class MTHD_5a785a1633c9424192d916ac3141e977 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5a785a1633c9424192d916ac3141e977()
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

      private sealed class MTHD_7aaf170898f446d1b9fe408f9064f924 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7aaf170898f446d1b9fe408f9064f924()
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

      private sealed class MTHD_0913f842138d4d01b3655f206b33eb87 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0913f842138d4d01b3655f206b33eb87()
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

      private sealed class MTHD_f02514055f8b4ae1885809873432b1e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f02514055f8b4ae1885809873432b1e7()
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

      private sealed class MTHD_6d5b5670ad3a42fa82525e46ed2461c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d5b5670ad3a42fa82525e46ed2461c2()
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

      private sealed class MTHD_0029d680de1a4c05add00329082e63c4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0029d680de1a4c05add00329082e63c4()
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

      private sealed class MTHD_006153dad5874bdca5dcb3bf10bd71e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_006153dad5874bdca5dcb3bf10bd71e5()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_d5971919a87548c9a09ab34c3e7ec489 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d5971919a87548c9a09ab34c3e7ec489()
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

      private sealed class MTHD_be76c2c4ac804caa92f20ed4d43033c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be76c2c4ac804caa92f20ed4d43033c7()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_d672125a955243f688b5696812d471e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d672125a955243f688b5696812d471e3()
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

      private sealed class MTHD_c7c8be817e7e48d9bd62a2d693433ef1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c7c8be817e7e48d9bd62a2d693433ef1()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_414bdab742724b008954a5b8f133bef1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_414bdab742724b008954a5b8f133bef1()
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

      private sealed class MTHD_90e7170633494f73a26271fbec349159 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90e7170633494f73a26271fbec349159()
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

      private sealed class MTHD_42db921593c643d3b8b820b68169f6f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42db921593c643d3b8b820b68169f6f9()
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

      private sealed class MTHD_f058ff9302ec442e9ad97f1abef14eeb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f058ff9302ec442e9ad97f1abef14eeb()
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

      private sealed class MTHD_117e80b1271346268022a2b8d8401202 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_117e80b1271346268022a2b8d8401202()
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

      private sealed class MTHD_71804e4b415f4a18bf8d229e860e4b41 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_71804e4b415f4a18bf8d229e860e4b41()
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

      private sealed class MTHD_05b4a70085514094b7829d6d645b7b60 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_05b4a70085514094b7829d6d645b7b60()
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

      private sealed class MTHD_721e1226f1594d8cab0eeab295da06a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_721e1226f1594d8cab0eeab295da06a2()
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

      private sealed class MTHD_fb3dead70c3747968017844fb58aa44a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb3dead70c3747968017844fb58aa44a()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_30794c6249444916ab9863c83f8718b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_30794c6249444916ab9863c83f8718b3()
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

      private sealed class MTHD_d17ce024c6c5499eb26474743743d701 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d17ce024c6c5499eb26474743743d701()
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

      private sealed class MTHD_a311eb2e064c4d63805644d3e79c1b75 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a311eb2e064c4d63805644d3e79c1b75()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_4419854e03af426fb2b0d6317a35fda7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4419854e03af426fb2b0d6317a35fda7()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_93e9a077ed1d4d6599c1590cbe5d1064 : HardwiredMemberDescriptor
      {
        internal PROP_93e9a077ed1d4d6599c1590cbe5d1064()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_a1d6c26d95064640b351dc706ee25ece : HardwiredMemberDescriptor
      {
        internal PROP_a1d6c26d95064640b351dc706ee25ece()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_0b2209c5180743a3987e0f6567d516d1 : HardwiredMemberDescriptor
      {
        internal PROP_0b2209c5180743a3987e0f6567d516d1()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_d683541591f04db1aea2751d123c7409 : HardwiredMemberDescriptor
      {
        internal PROP_d683541591f04db1aea2751d123c7409()
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

      private sealed class PROP_9205abcc2e43425ebc30af383ab775e5 : HardwiredMemberDescriptor
      {
        internal PROP_9205abcc2e43425ebc30af383ab775e5()
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

      private sealed class PROP_75b4dce4f7e341028171c1c0aaaec5f9 : HardwiredMemberDescriptor
      {
        internal PROP_75b4dce4f7e341028171c1c0aaaec5f9()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_a7592b9ae13741d5a90e478b8a569086 : HardwiredMemberDescriptor
      {
        internal PROP_a7592b9ae13741d5a90e478b8a569086()
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

      private sealed class PROP_2de6082c7d824724b4e22917617ac96e : HardwiredMemberDescriptor
      {
        internal PROP_2de6082c7d824724b4e22917617ac96e()
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

      private sealed class PROP_cf7f577ac36d47c0ae98c2fd3b171290 : HardwiredMemberDescriptor
      {
        internal PROP_cf7f577ac36d47c0ae98c2fd3b171290()
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

      private sealed class PROP_b1dc15641b0144e0b3ccc50b1c8ca2f0 : HardwiredMemberDescriptor
      {
        internal PROP_b1dc15641b0144e0b3ccc50b1c8ca2f0()
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

      private sealed class PROP_d7cd144cc0c8433e95302923872714e6 : HardwiredMemberDescriptor
      {
        internal PROP_d7cd144cc0c8433e95302923872714e6()
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

      private sealed class PROP_00448bdf45384e73ba76f2815089b58f : HardwiredMemberDescriptor
      {
        internal PROP_00448bdf45384e73ba76f2815089b58f()
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

      private sealed class PROP_0f6a377972a849d4abc6d9e23eb8b4a2 : HardwiredMemberDescriptor
      {
        internal PROP_0f6a377972a849d4abc6d9e23eb8b4a2()
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

      private sealed class PROP_888e0a19fe724bdfb090bf9d9b07cbdb : HardwiredMemberDescriptor
      {
        internal PROP_888e0a19fe724bdfb090bf9d9b07cbdb()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_c22b90162fcb48328cbc766b56e35a5c : HardwiredMemberDescriptor
      {
        internal PROP_c22b90162fcb48328cbc766b56e35a5c()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_7140c35827d247169b662b28a0db7af0 : HardwiredMemberDescriptor
      {
        internal PROP_7140c35827d247169b662b28a0db7af0()
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

      private sealed class PROP_8c773c517adc4e1c82af48474e7c71fb : HardwiredMemberDescriptor
      {
        internal PROP_8c773c517adc4e1c82af48474e7c71fb()
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

      private sealed class PROP_4a5cf2d3814048c8b626c43d2ddabb8e : HardwiredMemberDescriptor
      {
        internal PROP_4a5cf2d3814048c8b626c43d2ddabb8e()
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

      private sealed class PROP_7b49029196e94f738d0bc62a64c915f4 : HardwiredMemberDescriptor
      {
        internal PROP_7b49029196e94f738d0bc62a64c915f4()
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

      private sealed class PROP_4d595ffe6d1a456a86d63e46bb1c27a3 : HardwiredMemberDescriptor
      {
        internal PROP_4d595ffe6d1a456a86d63e46bb1c27a3()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_cf689a9bfe9740fea901a8a722cacea3 : HardwiredMemberDescriptor
      {
        internal PROP_cf689a9bfe9740fea901a8a722cacea3()
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

      private sealed class PROP_9dae3d6b443342e9a2c825a2d2f0f1cb : HardwiredMemberDescriptor
      {
        internal PROP_9dae3d6b443342e9a2c825a2d2f0f1cb()
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

      private sealed class PROP_548b45a0e37f46489bc9651db0a86bb9 : HardwiredMemberDescriptor
      {
        internal PROP_548b45a0e37f46489bc9651db0a86bb9()
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

      private sealed class PROP_7d51046eaf95412f82824e7cab9aaa88 : HardwiredMemberDescriptor
      {
        internal PROP_7d51046eaf95412f82824e7cab9aaa88()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_26ff4584236545228dac1371e6f7af13 : HardwiredMemberDescriptor
      {
        internal PROP_26ff4584236545228dac1371e6f7af13()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_a8fd1be1f6404e43ac6247a8d4deb130 : HardwiredMemberDescriptor
      {
        internal PROP_a8fd1be1f6404e43ac6247a8d4deb130()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_af49da25570c476b9eced0d82dbf00e1 : HardwiredMemberDescriptor
      {
        internal PROP_af49da25570c476b9eced0d82dbf00e1()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_6b049dc4eb174763bdaae196406c6dad : HardwiredMemberDescriptor
      {
        internal PROP_6b049dc4eb174763bdaae196406c6dad()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_e495aad2d7d44d838cd4a9a7a93dd104 : HardwiredMemberDescriptor
      {
        internal PROP_e495aad2d7d44d838cd4a9a7a93dd104()
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

      private sealed class PROP_06817c915572461c848a1dff15f19a4e : HardwiredMemberDescriptor
      {
        internal PROP_06817c915572461c848a1dff15f19a4e()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_9111e911e09a4210ae6f5e431513c87c : HardwiredMemberDescriptor
      {
        internal PROP_9111e911e09a4210ae6f5e431513c87c()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_2e1de3562dea44c4af894013d0ee8764 : HardwiredMemberDescriptor
      {
        internal PROP_2e1de3562dea44c4af894013d0ee8764()
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

      private sealed class PROP_b58ef346ff3f47ce9a69eb1b8d5b9e31 : HardwiredMemberDescriptor
      {
        internal PROP_b58ef346ff3f47ce9a69eb1b8d5b9e31()
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

    private sealed class TYPE_8bb5fce563be4776b4719aa882ac1e9b : HardwiredUserDataDescriptor
    {
      internal TYPE_8bb5fce563be4776b4719aa882ac1e9b()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.MTHD_29495c8cf791410689f9c4bdbd4cf402()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.MTHD_77637d96efa44f5e87302518b2c19638()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.MTHD_230520bd4599412e9961370903283a5a()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.MTHD_4307515e46a54ee58985dc1fa68b6db4()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.MTHD_bd49be5e6ea34d78b1f2eb5828bae6ac()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.MTHD_5828aa588c144c129399c945fc999a6d()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.MTHD_17a341d212e84e068d309b0bb17636fa()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.MTHD_a840ffff8b734696a48fa736ca42ee8f()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.MTHD_32e1e71099e941788f275f9a5d03058c()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.MTHD_b159eb7c4fa643eabab2a790ddc3b8fc()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.MTHD_9f5c156111eb44939f88e077bda7cc8e()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.MTHD_996f78935c054e0a82cf7f75f9142674()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.MTHD_bfcb0ee1fe554e55b65635702f4c59a6()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.MTHD_45d71ec806f447d3a5ecbf929755c0ae()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.MTHD_6071425640c14e5b8c5ab55252ad0633()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.MTHD_7cf5c063cd034e188ab0ecd6fa165da2()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.MTHD_9c9d56aef37d4797a8f570e97b7b9074()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.MTHD_757d8130a9914bb8944d8366ad0d05f0()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.MTHD_1807ff11598b4ec9b1ec5a2fcab4cb24()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.MTHD_44ac460eb4d04f1d89b8e9765d9a8ebb()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.PROP_e6f5346b98b0408dbb19232989892c77());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.PROP_e0f3224d6bd449a1aaeae623d31fcaea());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.PROP_6e311e5933a245e3bae9cd99a98c194d());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.PROP_f02e481730d7405bb60761db2192adc6());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.PROP_be6db3202d644799b8f3ee715bac4525());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.PROP_910256bc60ea41b6b99268f5fed03555());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.PROP_f447eddd5d2a4686b58cb40210017578());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_8bb5fce563be4776b4719aa882ac1e9b.PROP_08d031f2ae6f4a5e8339fc8e9106ff58());
      }

      private sealed class MTHD_29495c8cf791410689f9c4bdbd4cf402 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_29495c8cf791410689f9c4bdbd4cf402()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_77637d96efa44f5e87302518b2c19638 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_77637d96efa44f5e87302518b2c19638()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_230520bd4599412e9961370903283a5a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_230520bd4599412e9961370903283a5a()
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

      private sealed class MTHD_4307515e46a54ee58985dc1fa68b6db4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4307515e46a54ee58985dc1fa68b6db4()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_bd49be5e6ea34d78b1f2eb5828bae6ac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bd49be5e6ea34d78b1f2eb5828bae6ac()
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

      private sealed class MTHD_5828aa588c144c129399c945fc999a6d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5828aa588c144c129399c945fc999a6d()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_17a341d212e84e068d309b0bb17636fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_17a341d212e84e068d309b0bb17636fa()
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

      private sealed class MTHD_a840ffff8b734696a48fa736ca42ee8f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a840ffff8b734696a48fa736ca42ee8f()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_32e1e71099e941788f275f9a5d03058c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_32e1e71099e941788f275f9a5d03058c()
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

      private sealed class MTHD_b159eb7c4fa643eabab2a790ddc3b8fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b159eb7c4fa643eabab2a790ddc3b8fc()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_9f5c156111eb44939f88e077bda7cc8e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f5c156111eb44939f88e077bda7cc8e()
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

      private sealed class MTHD_996f78935c054e0a82cf7f75f9142674 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_996f78935c054e0a82cf7f75f9142674()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_bfcb0ee1fe554e55b65635702f4c59a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bfcb0ee1fe554e55b65635702f4c59a6()
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

      private sealed class MTHD_45d71ec806f447d3a5ecbf929755c0ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_45d71ec806f447d3a5ecbf929755c0ae()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_6071425640c14e5b8c5ab55252ad0633 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6071425640c14e5b8c5ab55252ad0633()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_7cf5c063cd034e188ab0ecd6fa165da2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7cf5c063cd034e188ab0ecd6fa165da2()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9c9d56aef37d4797a8f570e97b7b9074 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c9d56aef37d4797a8f570e97b7b9074()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_757d8130a9914bb8944d8366ad0d05f0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_757d8130a9914bb8944d8366ad0d05f0()
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

      private sealed class MTHD_1807ff11598b4ec9b1ec5a2fcab4cb24 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1807ff11598b4ec9b1ec5a2fcab4cb24()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_44ac460eb4d04f1d89b8e9765d9a8ebb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_44ac460eb4d04f1d89b8e9765d9a8ebb()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_e6f5346b98b0408dbb19232989892c77 : HardwiredMemberDescriptor
      {
        internal PROP_e6f5346b98b0408dbb19232989892c77()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_e0f3224d6bd449a1aaeae623d31fcaea : HardwiredMemberDescriptor
      {
        internal PROP_e0f3224d6bd449a1aaeae623d31fcaea()
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

      private sealed class PROP_6e311e5933a245e3bae9cd99a98c194d : HardwiredMemberDescriptor
      {
        internal PROP_6e311e5933a245e3bae9cd99a98c194d()
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

      private sealed class PROP_f02e481730d7405bb60761db2192adc6 : HardwiredMemberDescriptor
      {
        internal PROP_f02e481730d7405bb60761db2192adc6()
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

      private sealed class PROP_be6db3202d644799b8f3ee715bac4525 : HardwiredMemberDescriptor
      {
        internal PROP_be6db3202d644799b8f3ee715bac4525()
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

      private sealed class PROP_910256bc60ea41b6b99268f5fed03555 : HardwiredMemberDescriptor
      {
        internal PROP_910256bc60ea41b6b99268f5fed03555()
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

      private sealed class PROP_f447eddd5d2a4686b58cb40210017578 : HardwiredMemberDescriptor
      {
        internal PROP_f447eddd5d2a4686b58cb40210017578()
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

      private sealed class PROP_08d031f2ae6f4a5e8339fc8e9106ff58 : HardwiredMemberDescriptor
      {
        internal PROP_08d031f2ae6f4a5e8339fc8e9106ff58()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_0ea8e3df96a140d2b33d77ca410a4973 : HardwiredUserDataDescriptor
    {
      internal TYPE_0ea8e3df96a140d2b33d77ca410a4973()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.MTHD_17016d0a12ac4ddaafce707e9747d296()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.MTHD_e4656aae85404636ba97c4ea6b3043de()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.MTHD_31f21a26a6c44693b3f60b0142086d90()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.MTHD_a801c786d9174b5dba7e258e8c30598a()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.MTHD_59031a66bb014d7e82397bc2d141dc9f()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.MTHD_c261c63f6e8045ba990d4781038afc9b()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.MTHD_10aa9fa4e0ef4ab0a88ea3054e36fcbb()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.MTHD_13c69912add64b67b1578ffba383f070()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.MTHD_b4378922180d4412ae6db51214a6725a()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.MTHD_5183648f29964191ae083881cfdedce2()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.MTHD_594844ac100b4e279b67dac0cd19675a()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.MTHD_5eecc1a8eb4f4eb895fe97b361acc63b()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.MTHD_dea4672fbb6943ecb0ea6ebae5ac76a5()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.MTHD_2820ef2e7c72409d9f0630e519a41ef4()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.MTHD_e61f03682c154c97a5a9b1bedaa27fdd()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.MTHD_794d053e53154b95b4ec18f0ba6ab0b7()
        }));
        this.AddMember("setIcon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setIcon", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.MTHD_890e4a359ce14aa580cfd533db5e36a7()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.MTHD_5bf27c843a024969a8151c58bfbbdf58()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.MTHD_9c56df9031a54ce495abe415cc947e95()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.MTHD_e45813858a184fac988a3031efb67078()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.MTHD_08e301b7fea64d1a8882514cde0f0929()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.MTHD_7dd674403d2346b08880781a1a01ccab()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.PROP_0545d579ef9e47969dd273a2b3636340());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.PROP_877999af231e41749b11c3f63a3c4d33());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.PROP_5fb4683f1f6d47b9af921346d4f49b0f());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.PROP_37b77099c5004721b1606bc95e616641());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.PROP_0ebf1d3f89fd4878b4642c75107388a1());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.PROP_c91b2cec9a4c4ca19d83869c7f17ee09());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.PROP_16fd02633cb1475ea63f23f5d0cf5dea());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.PROP_4d26756aa5b846b48cc88f2c3ab9060a());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_0ea8e3df96a140d2b33d77ca410a4973.PROP_07c283846ad24493adf188ee38eee780());
      }

      private sealed class MTHD_17016d0a12ac4ddaafce707e9747d296 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_17016d0a12ac4ddaafce707e9747d296()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_e4656aae85404636ba97c4ea6b3043de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e4656aae85404636ba97c4ea6b3043de()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_31f21a26a6c44693b3f60b0142086d90 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_31f21a26a6c44693b3f60b0142086d90()
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

      private sealed class MTHD_a801c786d9174b5dba7e258e8c30598a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a801c786d9174b5dba7e258e8c30598a()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_59031a66bb014d7e82397bc2d141dc9f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_59031a66bb014d7e82397bc2d141dc9f()
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

      private sealed class MTHD_c261c63f6e8045ba990d4781038afc9b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c261c63f6e8045ba990d4781038afc9b()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_10aa9fa4e0ef4ab0a88ea3054e36fcbb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_10aa9fa4e0ef4ab0a88ea3054e36fcbb()
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

      private sealed class MTHD_13c69912add64b67b1578ffba383f070 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_13c69912add64b67b1578ffba383f070()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_b4378922180d4412ae6db51214a6725a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b4378922180d4412ae6db51214a6725a()
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

      private sealed class MTHD_5183648f29964191ae083881cfdedce2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5183648f29964191ae083881cfdedce2()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_594844ac100b4e279b67dac0cd19675a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_594844ac100b4e279b67dac0cd19675a()
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

      private sealed class MTHD_5eecc1a8eb4f4eb895fe97b361acc63b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5eecc1a8eb4f4eb895fe97b361acc63b()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_dea4672fbb6943ecb0ea6ebae5ac76a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dea4672fbb6943ecb0ea6ebae5ac76a5()
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

      private sealed class MTHD_2820ef2e7c72409d9f0630e519a41ef4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2820ef2e7c72409d9f0630e519a41ef4()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color2;
        }
      }

      private sealed class MTHD_e61f03682c154c97a5a9b1bedaa27fdd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e61f03682c154c97a5a9b1bedaa27fdd()
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

      private sealed class MTHD_794d053e53154b95b4ec18f0ba6ab0b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_794d053e53154b95b4ec18f0ba6ab0b7()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_890e4a359ce14aa580cfd533db5e36a7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_890e4a359ce14aa580cfd533db5e36a7()
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

      private sealed class MTHD_5bf27c843a024969a8151c58bfbbdf58 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5bf27c843a024969a8151c58bfbbdf58()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9c56df9031a54ce495abe415cc947e95 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c56df9031a54ce495abe415cc947e95()
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

      private sealed class MTHD_e45813858a184fac988a3031efb67078 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e45813858a184fac988a3031efb67078()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_08e301b7fea64d1a8882514cde0f0929 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_08e301b7fea64d1a8882514cde0f0929()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_7dd674403d2346b08880781a1a01ccab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7dd674403d2346b08880781a1a01ccab()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_0545d579ef9e47969dd273a2b3636340 : HardwiredMemberDescriptor
      {
        internal PROP_0545d579ef9e47969dd273a2b3636340()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_877999af231e41749b11c3f63a3c4d33 : HardwiredMemberDescriptor
      {
        internal PROP_877999af231e41749b11c3f63a3c4d33()
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

      private sealed class PROP_5fb4683f1f6d47b9af921346d4f49b0f : HardwiredMemberDescriptor
      {
        internal PROP_5fb4683f1f6d47b9af921346d4f49b0f()
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

      private sealed class PROP_37b77099c5004721b1606bc95e616641 : HardwiredMemberDescriptor
      {
        internal PROP_37b77099c5004721b1606bc95e616641()
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

      private sealed class PROP_0ebf1d3f89fd4878b4642c75107388a1 : HardwiredMemberDescriptor
      {
        internal PROP_0ebf1d3f89fd4878b4642c75107388a1()
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

      private sealed class PROP_c91b2cec9a4c4ca19d83869c7f17ee09 : HardwiredMemberDescriptor
      {
        internal PROP_c91b2cec9a4c4ca19d83869c7f17ee09()
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

      private sealed class PROP_16fd02633cb1475ea63f23f5d0cf5dea : HardwiredMemberDescriptor
      {
        internal PROP_16fd02633cb1475ea63f23f5d0cf5dea()
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

      private sealed class PROP_4d26756aa5b846b48cc88f2c3ab9060a : HardwiredMemberDescriptor
      {
        internal PROP_4d26756aa5b846b48cc88f2c3ab9060a()
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

      private sealed class PROP_07c283846ad24493adf188ee38eee780 : HardwiredMemberDescriptor
      {
        internal PROP_07c283846ad24493adf188ee38eee780()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_1ce2b8701115472daead96f71b093990 : HardwiredUserDataDescriptor
    {
      internal TYPE_1ce2b8701115472daead96f71b093990()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_ed27746dae464149b1d0b8800e98e1dc()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_dec356e879a745beadb80a88af0a0598()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_ca39be987a564fed96ecf7f11ebf0cf2()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_256fb5b3f21a44e9a768dbbbe1133d89()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_cf2b05b67bc8484692a5f3939fc7df7a()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_8ea024420d8d40d0b6da1e008a876c79()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_5aaf0f51320b4433b2b330597f94fc7d()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_a1cf0c51688f44a0983371ced89c0faf()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_bce371f40641404a94fa2f4526bc0cd1()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_511a736dfae64622a8fda23e3f126c2a()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_9f3fac389e29424cb56dad4acc8c31fc()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_5b6bc27dd16547979b5fe385c7586300()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_544e05445f30442d8b6024cad4bd928f()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_e194758724e7478980b8ff856f15aa8e()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_ed4261163cbc48bcba561798327d4e7a()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_d408147e864941dd8eb0c8d69648f5f9()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_6d4075c528374733812744ce74485226()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_9c8e52635dec44a884d7cc4d48bd8d9a()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_64a9cc729c854bbbb1c7f12896364b21()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_3f3299df68fa4737b1e6cdfe34cb2f08()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_380782e04315447f8225e53546bdeeb5()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_e70d238608774f7ea69d6dae9d7a6f0e()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_1a5ebdd212ea4856af7251eb50600c2f()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_1855e5bbbab345768ec58b59cdf149f5()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_7b315c674cf3447888976e0e0e25b1e3()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_37bb0ea9ed164944ad25c301d0675b15()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_234a94bcb1c64da4a6afea8da679c07c()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.MTHD_2608df3a76a2496d95eff974a051d957()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.PROP_fba5a9e8744e44538a9fa7996b2fdffa());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.PROP_712146f7ed804b81ac1c2d5f33113553());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.PROP_72eb544127954fd68c756bf7cccaab6f());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.PROP_a165a24fb8f747659174097c89ce29a7());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.PROP_07fcea9fa343409a8e6f6a4ae6317f37());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.PROP_6cb881feeaf84b389ce97b33b5401b24());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.PROP_a67958c037924f13ac49e279b42d0dd3());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.PROP_9acae9729229491b85396ea30b43196d());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.PROP_b44f081100fa46a99cfc6b7a0cf0aad4());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.PROP_9e53e9e0f0314919b93d885536a26097());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.PROP_0c9df3ae88554012ae2bd1af5b5e3e2c());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.PROP_39cf7127163741d7834f9209c848cd6b());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.PROP_6a641f9bfe0948859038ef828f71d649());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.PROP_6fbdf0f0e7084a2a91c0356def7a7dc6());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.PROP_e0fc8845b04445bebc7c5a443e93043f());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.PROP_5507a45de7e94f1a81e97e7909f8bca2());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_1ce2b8701115472daead96f71b093990.PROP_77aa2b0ec5654a56971e21153b572cda());
      }

      private sealed class MTHD_ed27746dae464149b1d0b8800e98e1dc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed27746dae464149b1d0b8800e98e1dc()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_dec356e879a745beadb80a88af0a0598 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dec356e879a745beadb80a88af0a0598()
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

      private sealed class MTHD_ca39be987a564fed96ecf7f11ebf0cf2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ca39be987a564fed96ecf7f11ebf0cf2()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_256fb5b3f21a44e9a768dbbbe1133d89 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_256fb5b3f21a44e9a768dbbbe1133d89()
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

      private sealed class MTHD_cf2b05b67bc8484692a5f3939fc7df7a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf2b05b67bc8484692a5f3939fc7df7a()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_8ea024420d8d40d0b6da1e008a876c79 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ea024420d8d40d0b6da1e008a876c79()
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

      private sealed class MTHD_5aaf0f51320b4433b2b330597f94fc7d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5aaf0f51320b4433b2b330597f94fc7d()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_a1cf0c51688f44a0983371ced89c0faf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1cf0c51688f44a0983371ced89c0faf()
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

      private sealed class MTHD_bce371f40641404a94fa2f4526bc0cd1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bce371f40641404a94fa2f4526bc0cd1()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_511a736dfae64622a8fda23e3f126c2a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_511a736dfae64622a8fda23e3f126c2a()
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

      private sealed class MTHD_9f3fac389e29424cb56dad4acc8c31fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f3fac389e29424cb56dad4acc8c31fc()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_5b6bc27dd16547979b5fe385c7586300 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b6bc27dd16547979b5fe385c7586300()
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

      private sealed class MTHD_544e05445f30442d8b6024cad4bd928f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_544e05445f30442d8b6024cad4bd928f()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_e194758724e7478980b8ff856f15aa8e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e194758724e7478980b8ff856f15aa8e()
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

      private sealed class MTHD_ed4261163cbc48bcba561798327d4e7a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed4261163cbc48bcba561798327d4e7a()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_d408147e864941dd8eb0c8d69648f5f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d408147e864941dd8eb0c8d69648f5f9()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_6d4075c528374733812744ce74485226 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d4075c528374733812744ce74485226()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_9c8e52635dec44a884d7cc4d48bd8d9a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c8e52635dec44a884d7cc4d48bd8d9a()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_64a9cc729c854bbbb1c7f12896364b21 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_64a9cc729c854bbbb1c7f12896364b21()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_3f3299df68fa4737b1e6cdfe34cb2f08 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f3299df68fa4737b1e6cdfe34cb2f08()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_380782e04315447f8225e53546bdeeb5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_380782e04315447f8225e53546bdeeb5()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_e70d238608774f7ea69d6dae9d7a6f0e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e70d238608774f7ea69d6dae9d7a6f0e()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_1a5ebdd212ea4856af7251eb50600c2f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a5ebdd212ea4856af7251eb50600c2f()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_1855e5bbbab345768ec58b59cdf149f5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1855e5bbbab345768ec58b59cdf149f5()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_7b315c674cf3447888976e0e0e25b1e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b315c674cf3447888976e0e0e25b1e3()
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

      private sealed class MTHD_37bb0ea9ed164944ad25c301d0675b15 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_37bb0ea9ed164944ad25c301d0675b15()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_234a94bcb1c64da4a6afea8da679c07c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_234a94bcb1c64da4a6afea8da679c07c()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_2608df3a76a2496d95eff974a051d957 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2608df3a76a2496d95eff974a051d957()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_fba5a9e8744e44538a9fa7996b2fdffa : HardwiredMemberDescriptor
      {
        internal PROP_fba5a9e8744e44538a9fa7996b2fdffa()
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

      private sealed class PROP_712146f7ed804b81ac1c2d5f33113553 : HardwiredMemberDescriptor
      {
        internal PROP_712146f7ed804b81ac1c2d5f33113553()
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

      private sealed class PROP_72eb544127954fd68c756bf7cccaab6f : HardwiredMemberDescriptor
      {
        internal PROP_72eb544127954fd68c756bf7cccaab6f()
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

      private sealed class PROP_a165a24fb8f747659174097c89ce29a7 : HardwiredMemberDescriptor
      {
        internal PROP_a165a24fb8f747659174097c89ce29a7()
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

      private sealed class PROP_07fcea9fa343409a8e6f6a4ae6317f37 : HardwiredMemberDescriptor
      {
        internal PROP_07fcea9fa343409a8e6f6a4ae6317f37()
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

      private sealed class PROP_6cb881feeaf84b389ce97b33b5401b24 : HardwiredMemberDescriptor
      {
        internal PROP_6cb881feeaf84b389ce97b33b5401b24()
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

      private sealed class PROP_a67958c037924f13ac49e279b42d0dd3 : HardwiredMemberDescriptor
      {
        internal PROP_a67958c037924f13ac49e279b42d0dd3()
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

      private sealed class PROP_9acae9729229491b85396ea30b43196d : HardwiredMemberDescriptor
      {
        internal PROP_9acae9729229491b85396ea30b43196d()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_b44f081100fa46a99cfc6b7a0cf0aad4 : HardwiredMemberDescriptor
      {
        internal PROP_b44f081100fa46a99cfc6b7a0cf0aad4()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_9e53e9e0f0314919b93d885536a26097 : HardwiredMemberDescriptor
      {
        internal PROP_9e53e9e0f0314919b93d885536a26097()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_0c9df3ae88554012ae2bd1af5b5e3e2c : HardwiredMemberDescriptor
      {
        internal PROP_0c9df3ae88554012ae2bd1af5b5e3e2c()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_39cf7127163741d7834f9209c848cd6b : HardwiredMemberDescriptor
      {
        internal PROP_39cf7127163741d7834f9209c848cd6b()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_6a641f9bfe0948859038ef828f71d649 : HardwiredMemberDescriptor
      {
        internal PROP_6a641f9bfe0948859038ef828f71d649()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_6fbdf0f0e7084a2a91c0356def7a7dc6 : HardwiredMemberDescriptor
      {
        internal PROP_6fbdf0f0e7084a2a91c0356def7a7dc6()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_e0fc8845b04445bebc7c5a443e93043f : HardwiredMemberDescriptor
      {
        internal PROP_e0fc8845b04445bebc7c5a443e93043f()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_5507a45de7e94f1a81e97e7909f8bca2 : HardwiredMemberDescriptor
      {
        internal PROP_5507a45de7e94f1a81e97e7909f8bca2()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_77aa2b0ec5654a56971e21153b572cda : HardwiredMemberDescriptor
      {
        internal PROP_77aa2b0ec5654a56971e21153b572cda()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_a727a58b4ea14a5481e839c510eada34 : HardwiredUserDataDescriptor
    {
      internal TYPE_a727a58b4ea14a5481e839c510eada34()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a727a58b4ea14a5481e839c510eada34.MTHD_488d5ef48aaf4daa8edc6b87dd8daefc()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a727a58b4ea14a5481e839c510eada34.MTHD_e56f8c1c5a0349e4964370fa06238fa1()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a727a58b4ea14a5481e839c510eada34.MTHD_90ff4c0f1ec544529cfc3f349e7c975c()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a727a58b4ea14a5481e839c510eada34.MTHD_189efd60db4e40a38d3c4d67eeca3721()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a727a58b4ea14a5481e839c510eada34.MTHD_3085589a8963437eb7476b6276cad869()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a727a58b4ea14a5481e839c510eada34.MTHD_16b86393df4046ad85b0402c84aec390()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a727a58b4ea14a5481e839c510eada34.MTHD_ebc732cd37c7423489dee1dd96b3db69()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a727a58b4ea14a5481e839c510eada34.MTHD_12be061dbb3f4a38b0c24f8302c4f048()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a727a58b4ea14a5481e839c510eada34.MTHD_7c190327babd4a6bac25d0d5cddf7de5()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a727a58b4ea14a5481e839c510eada34.MTHD_560938a6e4054c45a01c035384938941()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a727a58b4ea14a5481e839c510eada34.MTHD_7ee0a87e6d2641658d467d1a1c230224()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a727a58b4ea14a5481e839c510eada34.MTHD_d76c91392983422b914033984d7e73ba()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a727a58b4ea14a5481e839c510eada34.MTHD_ed95bb960d2245bfb3f62b79613baff0()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a727a58b4ea14a5481e839c510eada34.MTHD_6d36914cd9dc4f82ad432680d820873c()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a727a58b4ea14a5481e839c510eada34.MTHD_7d1bc98c07cf489181c37d3714d915bd()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a727a58b4ea14a5481e839c510eada34.MTHD_9848a681677048a39795a02fa06a7ff0()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a727a58b4ea14a5481e839c510eada34.MTHD_4aa2ccfb61e5438188cb381ecfbb43b3()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_a727a58b4ea14a5481e839c510eada34.PROP_091860ef4d90412d8ba32a32c41463ba());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_a727a58b4ea14a5481e839c510eada34.PROP_05e8ddb2512c430687f11a554824d6bc());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_a727a58b4ea14a5481e839c510eada34.PROP_7c963ed454824671930d41e28508685a());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_a727a58b4ea14a5481e839c510eada34.PROP_b701aaf081344893826d96437bd8804e());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_a727a58b4ea14a5481e839c510eada34.PROP_9a7913daacad496abe035f3acb77fee1());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_a727a58b4ea14a5481e839c510eada34.PROP_95173caf7d804f05856ae07ba4bd7f95());
      }

      private sealed class MTHD_488d5ef48aaf4daa8edc6b87dd8daefc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_488d5ef48aaf4daa8edc6b87dd8daefc()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_e56f8c1c5a0349e4964370fa06238fa1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e56f8c1c5a0349e4964370fa06238fa1()
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

      private sealed class MTHD_90ff4c0f1ec544529cfc3f349e7c975c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90ff4c0f1ec544529cfc3f349e7c975c()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_189efd60db4e40a38d3c4d67eeca3721 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_189efd60db4e40a38d3c4d67eeca3721()
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

      private sealed class MTHD_3085589a8963437eb7476b6276cad869 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3085589a8963437eb7476b6276cad869()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_16b86393df4046ad85b0402c84aec390 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_16b86393df4046ad85b0402c84aec390()
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

      private sealed class MTHD_ebc732cd37c7423489dee1dd96b3db69 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ebc732cd37c7423489dee1dd96b3db69()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_12be061dbb3f4a38b0c24f8302c4f048 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_12be061dbb3f4a38b0c24f8302c4f048()
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

      private sealed class MTHD_7c190327babd4a6bac25d0d5cddf7de5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7c190327babd4a6bac25d0d5cddf7de5()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_560938a6e4054c45a01c035384938941 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_560938a6e4054c45a01c035384938941()
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

      private sealed class MTHD_7ee0a87e6d2641658d467d1a1c230224 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ee0a87e6d2641658d467d1a1c230224()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_d76c91392983422b914033984d7e73ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d76c91392983422b914033984d7e73ba()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_ed95bb960d2245bfb3f62b79613baff0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed95bb960d2245bfb3f62b79613baff0()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_6d36914cd9dc4f82ad432680d820873c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d36914cd9dc4f82ad432680d820873c()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_7d1bc98c07cf489181c37d3714d915bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7d1bc98c07cf489181c37d3714d915bd()
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

      private sealed class MTHD_9848a681677048a39795a02fa06a7ff0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9848a681677048a39795a02fa06a7ff0()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_4aa2ccfb61e5438188cb381ecfbb43b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4aa2ccfb61e5438188cb381ecfbb43b3()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_091860ef4d90412d8ba32a32c41463ba : HardwiredMemberDescriptor
      {
        internal PROP_091860ef4d90412d8ba32a32c41463ba()
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

      private sealed class PROP_05e8ddb2512c430687f11a554824d6bc : HardwiredMemberDescriptor
      {
        internal PROP_05e8ddb2512c430687f11a554824d6bc()
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

      private sealed class PROP_7c963ed454824671930d41e28508685a : HardwiredMemberDescriptor
      {
        internal PROP_7c963ed454824671930d41e28508685a()
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

      private sealed class PROP_b701aaf081344893826d96437bd8804e : HardwiredMemberDescriptor
      {
        internal PROP_b701aaf081344893826d96437bd8804e()
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

      private sealed class PROP_9a7913daacad496abe035f3acb77fee1 : HardwiredMemberDescriptor
      {
        internal PROP_9a7913daacad496abe035f3acb77fee1()
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

      private sealed class PROP_95173caf7d804f05856ae07ba4bd7f95 : HardwiredMemberDescriptor
      {
        internal PROP_95173caf7d804f05856ae07ba4bd7f95()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_94891f1d35684b19acbf36ac50186c1d : HardwiredUserDataDescriptor
    {
      internal TYPE_94891f1d35684b19acbf36ac50186c1d()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_94891f1d35684b19acbf36ac50186c1d.MTHD_96d9814ff2d74a8c8183333529e4a89b(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_94891f1d35684b19acbf36ac50186c1d.MTHD_71d98e5c27524cfa84cc835ca30d08df()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_94891f1d35684b19acbf36ac50186c1d.MTHD_c82313da68314f7e9310c96470289eb7(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_94891f1d35684b19acbf36ac50186c1d.MTHD_ff8e871c19e84f599e1c036b6eaa482c()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_94891f1d35684b19acbf36ac50186c1d.MTHD_9e757dbfdfd241fc9e48cbed68550d49()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_94891f1d35684b19acbf36ac50186c1d.MTHD_b00fd20846ae458ca0c923477078ca36()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_94891f1d35684b19acbf36ac50186c1d.MTHD_6d47446a3dec4601badece78e1e1d6b0()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_94891f1d35684b19acbf36ac50186c1d.MTHD_536ab309ef2f4fe9a0bc0bc6c7bd4451()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_94891f1d35684b19acbf36ac50186c1d.MTHD_dc090e3206914857a713750f4366826a()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_94891f1d35684b19acbf36ac50186c1d.MTHD_bda7475832594871b0151afcbe6d02b9()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_94891f1d35684b19acbf36ac50186c1d.MTHD_866ba6b354314350893497fa010d5afd()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_94891f1d35684b19acbf36ac50186c1d.MTHD_7ad27a6feb6d4d0483448483f94ee822(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_94891f1d35684b19acbf36ac50186c1d.MTHD_bae77db9ba414636ab2a4b6cbd6adf18()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_94891f1d35684b19acbf36ac50186c1d.MTHD_b7c35d8ca3f04c1e8445ffd798b7822b(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_94891f1d35684b19acbf36ac50186c1d.MTHD_1ec9ed9497c249f19e511ba5af5646c9()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_94891f1d35684b19acbf36ac50186c1d.MTHD_a22bf1dd4aa241748d38bcbfdddb40c8(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_94891f1d35684b19acbf36ac50186c1d.MTHD_30a44cba17264245a4faa0a3164930eb()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_94891f1d35684b19acbf36ac50186c1d.MTHD_36a1df26bf4947c38e77f9ae860552ad(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_94891f1d35684b19acbf36ac50186c1d.MTHD_c68471303c7a43b282d11e78c8ae01f7()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_94891f1d35684b19acbf36ac50186c1d.MTHD_cb04f1e8431440f2a93bb910bf7f8eb6(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_94891f1d35684b19acbf36ac50186c1d.MTHD_485ef1eb78524409b70a74ef5f46a73a()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_94891f1d35684b19acbf36ac50186c1d.MTHD_ad3888f17d1f42b687f2de7930d7c84d()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_94891f1d35684b19acbf36ac50186c1d.MTHD_4a864b61b012455fa4a4d218e1170cbc()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_94891f1d35684b19acbf36ac50186c1d.FLDV_16662605ae584095b35d958dcd41b3e8());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_94891f1d35684b19acbf36ac50186c1d.FLDV_0bf020dfcf054be4879d1ab5a73ca8b8());
      }

      private sealed class MTHD_96d9814ff2d74a8c8183333529e4a89b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_96d9814ff2d74a8c8183333529e4a89b()
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

      private sealed class MTHD_71d98e5c27524cfa84cc835ca30d08df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_71d98e5c27524cfa84cc835ca30d08df()
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

      private sealed class MTHD_c82313da68314f7e9310c96470289eb7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c82313da68314f7e9310c96470289eb7()
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

      private sealed class MTHD_ff8e871c19e84f599e1c036b6eaa482c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff8e871c19e84f599e1c036b6eaa482c()
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

      private sealed class MTHD_9e757dbfdfd241fc9e48cbed68550d49 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e757dbfdfd241fc9e48cbed68550d49()
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

      private sealed class MTHD_b00fd20846ae458ca0c923477078ca36 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b00fd20846ae458ca0c923477078ca36()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_6d47446a3dec4601badece78e1e1d6b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d47446a3dec4601badece78e1e1d6b0()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_536ab309ef2f4fe9a0bc0bc6c7bd4451 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_536ab309ef2f4fe9a0bc0bc6c7bd4451()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_dc090e3206914857a713750f4366826a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc090e3206914857a713750f4366826a()
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

      private sealed class MTHD_bda7475832594871b0151afcbe6d02b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bda7475832594871b0151afcbe6d02b9()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_866ba6b354314350893497fa010d5afd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_866ba6b354314350893497fa010d5afd()
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

      private sealed class MTHD_7ad27a6feb6d4d0483448483f94ee822 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ad27a6feb6d4d0483448483f94ee822()
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

      private sealed class MTHD_bae77db9ba414636ab2a4b6cbd6adf18 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bae77db9ba414636ab2a4b6cbd6adf18()
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

      private sealed class MTHD_b7c35d8ca3f04c1e8445ffd798b7822b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b7c35d8ca3f04c1e8445ffd798b7822b()
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

      private sealed class MTHD_1ec9ed9497c249f19e511ba5af5646c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1ec9ed9497c249f19e511ba5af5646c9()
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

      private sealed class MTHD_a22bf1dd4aa241748d38bcbfdddb40c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a22bf1dd4aa241748d38bcbfdddb40c8()
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

      private sealed class MTHD_30a44cba17264245a4faa0a3164930eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_30a44cba17264245a4faa0a3164930eb()
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

      private sealed class MTHD_36a1df26bf4947c38e77f9ae860552ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_36a1df26bf4947c38e77f9ae860552ad()
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

      private sealed class MTHD_c68471303c7a43b282d11e78c8ae01f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c68471303c7a43b282d11e78c8ae01f7()
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

      private sealed class MTHD_cb04f1e8431440f2a93bb910bf7f8eb6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cb04f1e8431440f2a93bb910bf7f8eb6()
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

      private sealed class MTHD_485ef1eb78524409b70a74ef5f46a73a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_485ef1eb78524409b70a74ef5f46a73a()
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

      private sealed class MTHD_ad3888f17d1f42b687f2de7930d7c84d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ad3888f17d1f42b687f2de7930d7c84d()
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

      private sealed class MTHD_4a864b61b012455fa4a4d218e1170cbc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a864b61b012455fa4a4d218e1170cbc()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_16662605ae584095b35d958dcd41b3e8 : HardwiredMemberDescriptor
      {
        internal FLDV_16662605ae584095b35d958dcd41b3e8()
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

      private sealed class FLDV_0bf020dfcf054be4879d1ab5a73ca8b8 : HardwiredMemberDescriptor
      {
        internal FLDV_0bf020dfcf054be4879d1ab5a73ca8b8()
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

    private sealed class TYPE_e1b921cdff1842beb096c1bf161dad51 : HardwiredUserDataDescriptor
    {
      internal TYPE_e1b921cdff1842beb096c1bf161dad51()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e1b921cdff1842beb096c1bf161dad51.MTHD_1daf489247774c16951823f8ebbc3f63()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e1b921cdff1842beb096c1bf161dad51.MTHD_d3148abf1e274d708638d4a33ebbba9a()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e1b921cdff1842beb096c1bf161dad51.MTHD_95ce61a600a749cf92d8d2aebf017033()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e1b921cdff1842beb096c1bf161dad51.MTHD_6a5b8fb2a7314fa4bcc9369fa01d8063()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e1b921cdff1842beb096c1bf161dad51.MTHD_3e99db7777cc43e5b74af07ced1409a5()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_e1b921cdff1842beb096c1bf161dad51.MTHD_33de09b740c54702a128705fd2231f91()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_e1b921cdff1842beb096c1bf161dad51.FLDV_dbf9c50c464e448d9d11e88318ef590b());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_e1b921cdff1842beb096c1bf161dad51.FLDV_64731481c5c54ba78ebc4c0bf072877d());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_e1b921cdff1842beb096c1bf161dad51.FLDV_ecc84a7ceb6a4f5580fbc09d7387eb16());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_e1b921cdff1842beb096c1bf161dad51.FLDV_8190239ec62d405c882d01d38f5b0469());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_e1b921cdff1842beb096c1bf161dad51.FLDV_67acd470f32a40bf80e8f6da6e209d94());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_e1b921cdff1842beb096c1bf161dad51.FLDV_d7e8bd15bbe2414ea0595cb704803fae());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_e1b921cdff1842beb096c1bf161dad51.FLDV_01204fa5812e46dca7fa31428af8423b());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_e1b921cdff1842beb096c1bf161dad51.FLDV_6815733f22874b009b155b4859126022());
        this.AddMember("prestige", (IMemberDescriptor) new Bridge.TYPE_e1b921cdff1842beb096c1bf161dad51.FLDV_21617ee7b9434b2cadc396216126bf59());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_e1b921cdff1842beb096c1bf161dad51.FLDV_22b44e02f44e4ebb8742a995a73844b9());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_e1b921cdff1842beb096c1bf161dad51.FLDV_2dcf381377da4b66a0ca286adcb1f58b());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_e1b921cdff1842beb096c1bf161dad51.FLDV_35b4078d4f0e47b7bf255bc2f157fd54());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_e1b921cdff1842beb096c1bf161dad51.FLDV_057d56b8f5184ed0b0d854f97b069f67());
      }

      private sealed class MTHD_1daf489247774c16951823f8ebbc3f63 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1daf489247774c16951823f8ebbc3f63()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_d3148abf1e274d708638d4a33ebbba9a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d3148abf1e274d708638d4a33ebbba9a()
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

      private sealed class MTHD_95ce61a600a749cf92d8d2aebf017033 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_95ce61a600a749cf92d8d2aebf017033()
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

      private sealed class MTHD_6a5b8fb2a7314fa4bcc9369fa01d8063 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6a5b8fb2a7314fa4bcc9369fa01d8063()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_3e99db7777cc43e5b74af07ced1409a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e99db7777cc43e5b74af07ced1409a5()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_33de09b740c54702a128705fd2231f91 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_33de09b740c54702a128705fd2231f91()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_dbf9c50c464e448d9d11e88318ef590b : HardwiredMemberDescriptor
      {
        internal FLDV_dbf9c50c464e448d9d11e88318ef590b()
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

      private sealed class FLDV_64731481c5c54ba78ebc4c0bf072877d : HardwiredMemberDescriptor
      {
        internal FLDV_64731481c5c54ba78ebc4c0bf072877d()
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

      private sealed class FLDV_ecc84a7ceb6a4f5580fbc09d7387eb16 : HardwiredMemberDescriptor
      {
        internal FLDV_ecc84a7ceb6a4f5580fbc09d7387eb16()
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

      private sealed class FLDV_8190239ec62d405c882d01d38f5b0469 : HardwiredMemberDescriptor
      {
        internal FLDV_8190239ec62d405c882d01d38f5b0469()
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

      private sealed class FLDV_67acd470f32a40bf80e8f6da6e209d94 : HardwiredMemberDescriptor
      {
        internal FLDV_67acd470f32a40bf80e8f6da6e209d94()
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

      private sealed class FLDV_d7e8bd15bbe2414ea0595cb704803fae : HardwiredMemberDescriptor
      {
        internal FLDV_d7e8bd15bbe2414ea0595cb704803fae()
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

      private sealed class FLDV_01204fa5812e46dca7fa31428af8423b : HardwiredMemberDescriptor
      {
        internal FLDV_01204fa5812e46dca7fa31428af8423b()
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

      private sealed class FLDV_6815733f22874b009b155b4859126022 : HardwiredMemberDescriptor
      {
        internal FLDV_6815733f22874b009b155b4859126022()
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

      private sealed class FLDV_21617ee7b9434b2cadc396216126bf59 : HardwiredMemberDescriptor
      {
        internal FLDV_21617ee7b9434b2cadc396216126bf59()
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

      private sealed class FLDV_22b44e02f44e4ebb8742a995a73844b9 : HardwiredMemberDescriptor
      {
        internal FLDV_22b44e02f44e4ebb8742a995a73844b9()
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

      private sealed class FLDV_2dcf381377da4b66a0ca286adcb1f58b : HardwiredMemberDescriptor
      {
        internal FLDV_2dcf381377da4b66a0ca286adcb1f58b()
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

      private sealed class FLDV_35b4078d4f0e47b7bf255bc2f157fd54 : HardwiredMemberDescriptor
      {
        internal FLDV_35b4078d4f0e47b7bf255bc2f157fd54()
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

      private sealed class FLDV_057d56b8f5184ed0b0d854f97b069f67 : HardwiredMemberDescriptor
      {
        internal FLDV_057d56b8f5184ed0b0d854f97b069f67()
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

    private sealed class TYPE_5f3236c0b01a4ff081cd11827a9bdc13 : HardwiredUserDataDescriptor
    {
      internal TYPE_5f3236c0b01a4ff081cd11827a9bdc13()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_fe128904d4d3437ba109c3b71e7807c9()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_7e99316492e646b2936eb3dd63e8aead()
        }));
        this.AddMember("get_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_4a8fb7b90552490fb4677b215089be5c()
        }));
        this.AddMember("set_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_5dced1cdbc1c42d58eb142948994e775()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_50b70f86bd264813a84997f5f11d26b3()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_acac4d92059b49ac8f2589d4556b6d4b()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_1c2580608d5d403da8bc1ae0f2cec667()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_73b4d274e83f45449783a8babf590372()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_425ec60f7a4e4478974ae83c5cf20c64()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_768a2b25f8b8486aaabc735597bffaf5()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_866e01dfd9e1468db268b0257f451511()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_33741781709f4f928389a703875ac0a3()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_400822cbe5a6468587b70784d6b50436()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_595826bd775741dbaf3364b33913758a()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_67942d75eed345bba7239cf7b6b5ea30()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_0798a4e1cf9341a6bcc77b3656900f46()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_412546608d7d49c5922a1362de44a06c()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_4bdd4e30f6004e5dba2e774f0c84470b()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_8d236f43fd86440faaf636244cb433ff()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_f50f259ea58042ad916f52fde1a8f998()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_d1f1aa27bd54411a9e9830a32fc1a294()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_a70ffb931f4448f5bc1e6b39f782078f()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_bcfde94747b848e7ab31113e51beefc8()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_64b33e428bf448ebab947642ff31e98d()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_24fbefae5a474dfeb5a0957eea145510()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_448e1e6d515b41f7887a72a6e75318bb()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_a275542663c241fbb578245d80c4c6f9()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_10e485fbe6cf48678b86865a81977ba9()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_dcb6e45da893435aa6d72dc9a03f0627()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_bb566bf104c344bc823de9b5b0f9831f()
        }));
        this.AddMember("get_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_8c9cc7dc41ba4f49ac61ba1a6a6b9bd7()
        }));
        this.AddMember("set_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_586a4b07e1b7401394fe73f0aaa6ebbe()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_2f3799f9314347129ac665cdf3c1f7c2()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_8b2bba0aea9d472a80f4298551292f4c()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_ca0a67b1f5d140c19638ddbc0053dca5()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_17d072e5d8144b69b2eb4f12ceed16bf()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_d215284f9bff4ecc9a61ede3732f0979()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_75d66f863d9a416c826576cda2e3c133()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_646c614279af4f71a3035451a47f49f2()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_e7cc455f14e347b79c0279fe54f319e3()
        }));
        this.AddMember("get_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_7498efc63adf49a7803013b7f55296b4()
        }));
        this.AddMember("set_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_5f20f774f7e7462897cbd0bf2a034116()
        }));
        this.AddMember("get_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_286c0182c2e74658bd1022f4904e06f8()
        }));
        this.AddMember("set_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_c81a1ba72bdf4d0f8a0cb43f8c28e571()
        }));
        this.AddMember("get_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_e0d3b61e96c941caa0b6cdcdb1b01076()
        }));
        this.AddMember("set_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_57ec431d73934587a88fd6d7e75099e5()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_9b9615e8290243948e73ed70b26d54e5()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_332b433b3d794fccb599dc9419df1a9f()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_1b4617f5129d45719d4270b119bbf81b()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_0536a27821254bd6aeac3d49f217f9d8()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_94afe09383d44171b6087bc181ae50d9()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_ef6e271ef55f4167b438bd59206362a2()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_d759329b219c49c88123a309cb31365b()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_040f0b03f0f44140b6629e4a50a2dcde()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_03ac8c675951472f8a2e37b46dfd8f02()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_d939ed5acd7a422d98879acfdac7756a()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_ac5c68a2b93243ba872fc631c3a71a35()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_3205368abf0f4a778158d827673dad9c()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_90263d912e0a4b0aaf8aafee78384491()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.MTHD_780229bccbc645edbb0756ab0db76821()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.PROP_9e5288b394f34af083c32fa51d692b22());
        this.AddMember("visible", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.PROP_690fe7bc08314fb9929315fdaf5884da());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.PROP_f6e609ec7a3045f3acdf365b81e332b8());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.PROP_af7ccb7e9b924695bba7cd25a9a9c206());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.PROP_20e29c33328e4335920048d56b0e6d79());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.PROP_9e9d2c5655cf4abcb589710e76075510());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.PROP_6883dfa35ee5424cb1d5ac27453eacee());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.PROP_9de69b82f74f45a6a056e66fbccee4e8());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.PROP_ce95b8c257d04227a58aa0a32d562514());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.PROP_2b9b78838ef74cf0bcc38a70bbf79205());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.PROP_ddb53aaf257f41989154f7e521670448());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.PROP_4ca8ffa4b3a94c73813bfa4055542654());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.PROP_b3bec11c2a294b51b1adea8d74502a63());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.PROP_80b12fa562704293b62a774a82655c04());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.PROP_374b7d03b01941f3ae9ac77b71de6e5d());
        this.AddMember("onClick2", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.PROP_01d85ae29d9b4827a4ec238b4c29385c());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.PROP_54e10e37c15a478da5d5712421e7bb12());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.PROP_38dd6445f04946609320c1f4efdf32eb());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.PROP_add098c1e14e454a971cdee26be41984());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.PROP_05b6ec8a0bc144b78209bee986b4b5b8());
        this.AddMember("textColor2", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.PROP_40f7d758c5dc4519b2822d2ded84cadb());
        this.AddMember("highlightColor", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.PROP_181a86185b8a438c89489eb594f0ed27());
        this.AddMember("highlightColor2", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.PROP_45e7c380531c49c8af56c2afc4b72283());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.PROP_102ae41d70cf42c3b7aa7a15020618d5());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.PROP_2d7b42854c1e4731838062829988f0f0());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.FLDV_c9c81cb8b33749a1a7475ffd5981f9fa());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.FLDV_74abb9251696415b8ba3f02edfc0eb9a());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_5f3236c0b01a4ff081cd11827a9bdc13.FLDV_59ea4da6a10048969da707e1b01b7306());
      }

      private sealed class MTHD_fe128904d4d3437ba109c3b71e7807c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fe128904d4d3437ba109c3b71e7807c9()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_7e99316492e646b2936eb3dd63e8aead : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7e99316492e646b2936eb3dd63e8aead()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_4a8fb7b90552490fb4677b215089be5c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a8fb7b90552490fb4677b215089be5c()
        {
          this.Initialize("get_visible", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).visible;
        }
      }

      private sealed class MTHD_5dced1cdbc1c42d58eb142948994e775 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5dced1cdbc1c42d58eb142948994e775()
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

      private sealed class MTHD_50b70f86bd264813a84997f5f11d26b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_50b70f86bd264813a84997f5f11d26b3()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_acac4d92059b49ac8f2589d4556b6d4b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_acac4d92059b49ac8f2589d4556b6d4b()
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

      private sealed class MTHD_1c2580608d5d403da8bc1ae0f2cec667 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c2580608d5d403da8bc1ae0f2cec667()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_73b4d274e83f45449783a8babf590372 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_73b4d274e83f45449783a8babf590372()
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

      private sealed class MTHD_425ec60f7a4e4478974ae83c5cf20c64 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_425ec60f7a4e4478974ae83c5cf20c64()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_768a2b25f8b8486aaabc735597bffaf5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_768a2b25f8b8486aaabc735597bffaf5()
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

      private sealed class MTHD_866e01dfd9e1468db268b0257f451511 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_866e01dfd9e1468db268b0257f451511()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_33741781709f4f928389a703875ac0a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_33741781709f4f928389a703875ac0a3()
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

      private sealed class MTHD_400822cbe5a6468587b70784d6b50436 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_400822cbe5a6468587b70784d6b50436()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_595826bd775741dbaf3364b33913758a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_595826bd775741dbaf3364b33913758a()
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

      private sealed class MTHD_67942d75eed345bba7239cf7b6b5ea30 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67942d75eed345bba7239cf7b6b5ea30()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_0798a4e1cf9341a6bcc77b3656900f46 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0798a4e1cf9341a6bcc77b3656900f46()
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

      private sealed class MTHD_412546608d7d49c5922a1362de44a06c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_412546608d7d49c5922a1362de44a06c()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_4bdd4e30f6004e5dba2e774f0c84470b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4bdd4e30f6004e5dba2e774f0c84470b()
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

      private sealed class MTHD_8d236f43fd86440faaf636244cb433ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8d236f43fd86440faaf636244cb433ff()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_f50f259ea58042ad916f52fde1a8f998 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f50f259ea58042ad916f52fde1a8f998()
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

      private sealed class MTHD_d1f1aa27bd54411a9e9830a32fc1a294 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1f1aa27bd54411a9e9830a32fc1a294()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_a70ffb931f4448f5bc1e6b39f782078f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a70ffb931f4448f5bc1e6b39f782078f()
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

      private sealed class MTHD_bcfde94747b848e7ab31113e51beefc8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bcfde94747b848e7ab31113e51beefc8()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_64b33e428bf448ebab947642ff31e98d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_64b33e428bf448ebab947642ff31e98d()
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

      private sealed class MTHD_24fbefae5a474dfeb5a0957eea145510 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24fbefae5a474dfeb5a0957eea145510()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_448e1e6d515b41f7887a72a6e75318bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_448e1e6d515b41f7887a72a6e75318bb()
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

      private sealed class MTHD_a275542663c241fbb578245d80c4c6f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a275542663c241fbb578245d80c4c6f9()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_10e485fbe6cf48678b86865a81977ba9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_10e485fbe6cf48678b86865a81977ba9()
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

      private sealed class MTHD_dcb6e45da893435aa6d72dc9a03f0627 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dcb6e45da893435aa6d72dc9a03f0627()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_bb566bf104c344bc823de9b5b0f9831f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb566bf104c344bc823de9b5b0f9831f()
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

      private sealed class MTHD_8c9cc7dc41ba4f49ac61ba1a6a6b9bd7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c9cc7dc41ba4f49ac61ba1a6a6b9bd7()
        {
          this.Initialize("get_onClick2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick2;
        }
      }

      private sealed class MTHD_586a4b07e1b7401394fe73f0aaa6ebbe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_586a4b07e1b7401394fe73f0aaa6ebbe()
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

      private sealed class MTHD_2f3799f9314347129ac665cdf3c1f7c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2f3799f9314347129ac665cdf3c1f7c2()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_8b2bba0aea9d472a80f4298551292f4c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b2bba0aea9d472a80f4298551292f4c()
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

      private sealed class MTHD_ca0a67b1f5d140c19638ddbc0053dca5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ca0a67b1f5d140c19638ddbc0053dca5()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color2;
        }
      }

      private sealed class MTHD_17d072e5d8144b69b2eb4f12ceed16bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_17d072e5d8144b69b2eb4f12ceed16bf()
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

      private sealed class MTHD_d215284f9bff4ecc9a61ede3732f0979 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d215284f9bff4ecc9a61ede3732f0979()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_75d66f863d9a416c826576cda2e3c133 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75d66f863d9a416c826576cda2e3c133()
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

      private sealed class MTHD_646c614279af4f71a3035451a47f49f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_646c614279af4f71a3035451a47f49f2()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_e7cc455f14e347b79c0279fe54f319e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7cc455f14e347b79c0279fe54f319e3()
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

      private sealed class MTHD_7498efc63adf49a7803013b7f55296b4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7498efc63adf49a7803013b7f55296b4()
        {
          this.Initialize("get_textColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor2;
        }
      }

      private sealed class MTHD_5f20f774f7e7462897cbd0bf2a034116 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5f20f774f7e7462897cbd0bf2a034116()
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

      private sealed class MTHD_286c0182c2e74658bd1022f4904e06f8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_286c0182c2e74658bd1022f4904e06f8()
        {
          this.Initialize("get_highlightColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor;
        }
      }

      private sealed class MTHD_c81a1ba72bdf4d0f8a0cb43f8c28e571 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c81a1ba72bdf4d0f8a0cb43f8c28e571()
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

      private sealed class MTHD_e0d3b61e96c941caa0b6cdcdb1b01076 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e0d3b61e96c941caa0b6cdcdb1b01076()
        {
          this.Initialize("get_highlightColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor2;
        }
      }

      private sealed class MTHD_57ec431d73934587a88fd6d7e75099e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57ec431d73934587a88fd6d7e75099e5()
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

      private sealed class MTHD_9b9615e8290243948e73ed70b26d54e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b9615e8290243948e73ed70b26d54e5()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_332b433b3d794fccb599dc9419df1a9f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_332b433b3d794fccb599dc9419df1a9f()
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

      private sealed class MTHD_1b4617f5129d45719d4270b119bbf81b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1b4617f5129d45719d4270b119bbf81b()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_0536a27821254bd6aeac3d49f217f9d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0536a27821254bd6aeac3d49f217f9d8()
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

      private sealed class MTHD_94afe09383d44171b6087bc181ae50d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_94afe09383d44171b6087bc181ae50d9()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ef6e271ef55f4167b438bd59206362a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef6e271ef55f4167b438bd59206362a2()
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

      private sealed class MTHD_d759329b219c49c88123a309cb31365b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d759329b219c49c88123a309cb31365b()
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

      private sealed class MTHD_040f0b03f0f44140b6629e4a50a2dcde : HardwiredMethodMemberDescriptor
      {
        internal MTHD_040f0b03f0f44140b6629e4a50a2dcde()
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

      private sealed class MTHD_03ac8c675951472f8a2e37b46dfd8f02 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_03ac8c675951472f8a2e37b46dfd8f02()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_d939ed5acd7a422d98879acfdac7756a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d939ed5acd7a422d98879acfdac7756a()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ac5c68a2b93243ba872fc631c3a71a35 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac5c68a2b93243ba872fc631c3a71a35()
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

      private sealed class MTHD_3205368abf0f4a778158d827673dad9c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3205368abf0f4a778158d827673dad9c()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_90263d912e0a4b0aaf8aafee78384491 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90263d912e0a4b0aaf8aafee78384491()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_780229bccbc645edbb0756ab0db76821 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_780229bccbc645edbb0756ab0db76821()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_9e5288b394f34af083c32fa51d692b22 : HardwiredMemberDescriptor
      {
        internal PROP_9e5288b394f34af083c32fa51d692b22()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_690fe7bc08314fb9929315fdaf5884da : HardwiredMemberDescriptor
      {
        internal PROP_690fe7bc08314fb9929315fdaf5884da()
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

      private sealed class PROP_f6e609ec7a3045f3acdf365b81e332b8 : HardwiredMemberDescriptor
      {
        internal PROP_f6e609ec7a3045f3acdf365b81e332b8()
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

      private sealed class PROP_af7ccb7e9b924695bba7cd25a9a9c206 : HardwiredMemberDescriptor
      {
        internal PROP_af7ccb7e9b924695bba7cd25a9a9c206()
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

      private sealed class PROP_20e29c33328e4335920048d56b0e6d79 : HardwiredMemberDescriptor
      {
        internal PROP_20e29c33328e4335920048d56b0e6d79()
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

      private sealed class PROP_9e9d2c5655cf4abcb589710e76075510 : HardwiredMemberDescriptor
      {
        internal PROP_9e9d2c5655cf4abcb589710e76075510()
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

      private sealed class PROP_6883dfa35ee5424cb1d5ac27453eacee : HardwiredMemberDescriptor
      {
        internal PROP_6883dfa35ee5424cb1d5ac27453eacee()
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

      private sealed class PROP_9de69b82f74f45a6a056e66fbccee4e8 : HardwiredMemberDescriptor
      {
        internal PROP_9de69b82f74f45a6a056e66fbccee4e8()
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

      private sealed class PROP_ce95b8c257d04227a58aa0a32d562514 : HardwiredMemberDescriptor
      {
        internal PROP_ce95b8c257d04227a58aa0a32d562514()
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

      private sealed class PROP_2b9b78838ef74cf0bcc38a70bbf79205 : HardwiredMemberDescriptor
      {
        internal PROP_2b9b78838ef74cf0bcc38a70bbf79205()
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

      private sealed class PROP_ddb53aaf257f41989154f7e521670448 : HardwiredMemberDescriptor
      {
        internal PROP_ddb53aaf257f41989154f7e521670448()
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

      private sealed class PROP_4ca8ffa4b3a94c73813bfa4055542654 : HardwiredMemberDescriptor
      {
        internal PROP_4ca8ffa4b3a94c73813bfa4055542654()
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

      private sealed class PROP_b3bec11c2a294b51b1adea8d74502a63 : HardwiredMemberDescriptor
      {
        internal PROP_b3bec11c2a294b51b1adea8d74502a63()
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

      private sealed class PROP_80b12fa562704293b62a774a82655c04 : HardwiredMemberDescriptor
      {
        internal PROP_80b12fa562704293b62a774a82655c04()
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

      private sealed class PROP_374b7d03b01941f3ae9ac77b71de6e5d : HardwiredMemberDescriptor
      {
        internal PROP_374b7d03b01941f3ae9ac77b71de6e5d()
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

      private sealed class PROP_01d85ae29d9b4827a4ec238b4c29385c : HardwiredMemberDescriptor
      {
        internal PROP_01d85ae29d9b4827a4ec238b4c29385c()
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

      private sealed class PROP_54e10e37c15a478da5d5712421e7bb12 : HardwiredMemberDescriptor
      {
        internal PROP_54e10e37c15a478da5d5712421e7bb12()
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

      private sealed class PROP_38dd6445f04946609320c1f4efdf32eb : HardwiredMemberDescriptor
      {
        internal PROP_38dd6445f04946609320c1f4efdf32eb()
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

      private sealed class PROP_add098c1e14e454a971cdee26be41984 : HardwiredMemberDescriptor
      {
        internal PROP_add098c1e14e454a971cdee26be41984()
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

      private sealed class PROP_05b6ec8a0bc144b78209bee986b4b5b8 : HardwiredMemberDescriptor
      {
        internal PROP_05b6ec8a0bc144b78209bee986b4b5b8()
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

      private sealed class PROP_40f7d758c5dc4519b2822d2ded84cadb : HardwiredMemberDescriptor
      {
        internal PROP_40f7d758c5dc4519b2822d2ded84cadb()
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

      private sealed class PROP_181a86185b8a438c89489eb594f0ed27 : HardwiredMemberDescriptor
      {
        internal PROP_181a86185b8a438c89489eb594f0ed27()
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

      private sealed class PROP_45e7c380531c49c8af56c2afc4b72283 : HardwiredMemberDescriptor
      {
        internal PROP_45e7c380531c49c8af56c2afc4b72283()
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

      private sealed class PROP_102ae41d70cf42c3b7aa7a15020618d5 : HardwiredMemberDescriptor
      {
        internal PROP_102ae41d70cf42c3b7aa7a15020618d5()
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

      private sealed class PROP_2d7b42854c1e4731838062829988f0f0 : HardwiredMemberDescriptor
      {
        internal PROP_2d7b42854c1e4731838062829988f0f0()
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

      private sealed class FLDV_c9c81cb8b33749a1a7475ffd5981f9fa : HardwiredMemberDescriptor
      {
        internal FLDV_c9c81cb8b33749a1a7475ffd5981f9fa()
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

      private sealed class FLDV_74abb9251696415b8ba3f02edfc0eb9a : HardwiredMemberDescriptor
      {
        internal FLDV_74abb9251696415b8ba3f02edfc0eb9a()
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

      private sealed class FLDV_59ea4da6a10048969da707e1b01b7306 : HardwiredMemberDescriptor
      {
        internal FLDV_59ea4da6a10048969da707e1b01b7306()
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

    private sealed class TYPE_3cfd592a21d5433fa1766ac1d4d45acf : HardwiredUserDataDescriptor
    {
      internal TYPE_3cfd592a21d5433fa1766ac1d4d45acf()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3cfd592a21d5433fa1766ac1d4d45acf.MTHD_5b227ef343ec445385ee3c9287557aa0()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3cfd592a21d5433fa1766ac1d4d45acf.MTHD_880a77277cfa45cfbb6312317ab3f3e5()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3cfd592a21d5433fa1766ac1d4d45acf.MTHD_b9a92028a49449268b882384608703da()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3cfd592a21d5433fa1766ac1d4d45acf.MTHD_0b142520e6154850b5e26107684dfd61()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3cfd592a21d5433fa1766ac1d4d45acf.MTHD_ba646b66d4e3466f9b3e3be88e1f22cc()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3cfd592a21d5433fa1766ac1d4d45acf.MTHD_ee334181bea14ca382a75d200b256be2()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_3cfd592a21d5433fa1766ac1d4d45acf.FLDV_dd7d457690054571abdbff5f0b02f2a6());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_3cfd592a21d5433fa1766ac1d4d45acf.FLDV_e8e1fab74636422da7514285e981ea03());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_3cfd592a21d5433fa1766ac1d4d45acf.FLDV_76a944a907114ae78a8fb03af0f2f8e5());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_3cfd592a21d5433fa1766ac1d4d45acf.FLDV_7e22a876996b46538e88511c94f11fed());
      }

      private sealed class MTHD_5b227ef343ec445385ee3c9287557aa0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b227ef343ec445385ee3c9287557aa0()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_880a77277cfa45cfbb6312317ab3f3e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_880a77277cfa45cfbb6312317ab3f3e5()
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

      private sealed class MTHD_b9a92028a49449268b882384608703da : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b9a92028a49449268b882384608703da()
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

      private sealed class MTHD_0b142520e6154850b5e26107684dfd61 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b142520e6154850b5e26107684dfd61()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_ba646b66d4e3466f9b3e3be88e1f22cc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba646b66d4e3466f9b3e3be88e1f22cc()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_ee334181bea14ca382a75d200b256be2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee334181bea14ca382a75d200b256be2()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_dd7d457690054571abdbff5f0b02f2a6 : HardwiredMemberDescriptor
      {
        internal FLDV_dd7d457690054571abdbff5f0b02f2a6()
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

      private sealed class FLDV_e8e1fab74636422da7514285e981ea03 : HardwiredMemberDescriptor
      {
        internal FLDV_e8e1fab74636422da7514285e981ea03()
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

      private sealed class FLDV_76a944a907114ae78a8fb03af0f2f8e5 : HardwiredMemberDescriptor
      {
        internal FLDV_76a944a907114ae78a8fb03af0f2f8e5()
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

      private sealed class FLDV_7e22a876996b46538e88511c94f11fed : HardwiredMemberDescriptor
      {
        internal FLDV_7e22a876996b46538e88511c94f11fed()
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

    private sealed class TYPE_4fdbc634a1bc4dd9ac23c09d27a61dd6 : HardwiredUserDataDescriptor
    {
      internal TYPE_4fdbc634a1bc4dd9ac23c09d27a61dd6()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4fdbc634a1bc4dd9ac23c09d27a61dd6.MTHD_5bbb1c32221c454a9d4af84c29453af5()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4fdbc634a1bc4dd9ac23c09d27a61dd6.MTHD_1c6ebd563d2449008c698df98f879b1a()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4fdbc634a1bc4dd9ac23c09d27a61dd6.MTHD_70187830644a47c6be6b9bdedf8c6ee6()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4fdbc634a1bc4dd9ac23c09d27a61dd6.MTHD_d203c9756e404340a7b105077be1138b()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4fdbc634a1bc4dd9ac23c09d27a61dd6.MTHD_7d585fadc676435da9cd946a6a0cdf5a()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_4fdbc634a1bc4dd9ac23c09d27a61dd6.FLDV_7e3ee9e4ba704774b2815d83af1b4930());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_4fdbc634a1bc4dd9ac23c09d27a61dd6.FLDV_15cadd4a4b5e474eb0593d69c08ae1d5());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_4fdbc634a1bc4dd9ac23c09d27a61dd6.FLDV_336e22742ffe47bdb0f9f21d2f5e653d());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_4fdbc634a1bc4dd9ac23c09d27a61dd6.FLDV_12dd70d079c84e48a2e058bec767fa00());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_4fdbc634a1bc4dd9ac23c09d27a61dd6.FLDV_c6e5e12c52674ebfaa8d7e10834fe93d());
      }

      private sealed class MTHD_5bbb1c32221c454a9d4af84c29453af5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5bbb1c32221c454a9d4af84c29453af5()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_1c6ebd563d2449008c698df98f879b1a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c6ebd563d2449008c698df98f879b1a()
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

      private sealed class MTHD_70187830644a47c6be6b9bdedf8c6ee6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70187830644a47c6be6b9bdedf8c6ee6()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_d203c9756e404340a7b105077be1138b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d203c9756e404340a7b105077be1138b()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_7d585fadc676435da9cd946a6a0cdf5a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7d585fadc676435da9cd946a6a0cdf5a()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_7e3ee9e4ba704774b2815d83af1b4930 : HardwiredMemberDescriptor
      {
        internal FLDV_7e3ee9e4ba704774b2815d83af1b4930()
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

      private sealed class FLDV_15cadd4a4b5e474eb0593d69c08ae1d5 : HardwiredMemberDescriptor
      {
        internal FLDV_15cadd4a4b5e474eb0593d69c08ae1d5()
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

      private sealed class FLDV_336e22742ffe47bdb0f9f21d2f5e653d : HardwiredMemberDescriptor
      {
        internal FLDV_336e22742ffe47bdb0f9f21d2f5e653d()
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

      private sealed class FLDV_12dd70d079c84e48a2e058bec767fa00 : HardwiredMemberDescriptor
      {
        internal FLDV_12dd70d079c84e48a2e058bec767fa00()
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

      private sealed class FLDV_c6e5e12c52674ebfaa8d7e10834fe93d : HardwiredMemberDescriptor
      {
        internal FLDV_c6e5e12c52674ebfaa8d7e10834fe93d()
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

    private sealed class TYPE_9978c3814cb147c4918032397d92b4fd : HardwiredUserDataDescriptor
    {
      internal TYPE_9978c3814cb147c4918032397d92b4fd()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9978c3814cb147c4918032397d92b4fd.MTHD_8324fc1c57d84264a1e2011cc5a5c34f()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9978c3814cb147c4918032397d92b4fd.MTHD_ba592408edba4b3694772df944ecbacf()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9978c3814cb147c4918032397d92b4fd.MTHD_8307b61356f9488eb156a1e3e71a87ae()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9978c3814cb147c4918032397d92b4fd.MTHD_c6150847688640a5b3f9f40281afdab5()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9978c3814cb147c4918032397d92b4fd.MTHD_37b3830481c0490a8292252a99df6607()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9978c3814cb147c4918032397d92b4fd.MTHD_bea36dc06c34408280c0b8fefebd086e()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9978c3814cb147c4918032397d92b4fd.MTHD_18b79c19d40540ad88b68bbfc4a6ee71()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9978c3814cb147c4918032397d92b4fd.MTHD_8fd2e7dec0be480abd96c16e20aa49fc()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9978c3814cb147c4918032397d92b4fd.MTHD_de483b9035cc4c6fa7df51ddb8cf54f1()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9978c3814cb147c4918032397d92b4fd.MTHD_f9c63180e6d6496d844da6a5b0342e6d()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9978c3814cb147c4918032397d92b4fd.MTHD_3f53b14457414a22b956cb18b114a2bc()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9978c3814cb147c4918032397d92b4fd.MTHD_cc1acd17315a4e52b5548f8b188b9027()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9978c3814cb147c4918032397d92b4fd.MTHD_6a0057a4b1c845b3bd51c61a38d26142()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_9978c3814cb147c4918032397d92b4fd.FLDV_e76fdb5b8d6c42228cc56127ed452781());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_9978c3814cb147c4918032397d92b4fd.FLDV_628b907be8fc464aa932fa6f6356b608());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_9978c3814cb147c4918032397d92b4fd.FLDV_8ee43a8ad2b84ca1b9aed21a76d1dcba());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_9978c3814cb147c4918032397d92b4fd.FLDV_ea8e2b5cd4c14bfebe98064a192fe81d());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_9978c3814cb147c4918032397d92b4fd.FLDV_aa79a235eccf4f308629398ca6fa3d2b());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_9978c3814cb147c4918032397d92b4fd.FLDV_b72e5aa881fd41ca85f5e99da619e3f4());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_9978c3814cb147c4918032397d92b4fd.FLDV_8cdcbdd982094993843b42869d804dc8());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_9978c3814cb147c4918032397d92b4fd.FLDV_6bcbc3975c394acc9632c5e915edead7());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_9978c3814cb147c4918032397d92b4fd.DVAL_f71adbbcb80249138c83d1665705a241());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_9978c3814cb147c4918032397d92b4fd.DVAL_fe0093910b43469eae166ed6e8067e21());
      }

      private sealed class MTHD_8324fc1c57d84264a1e2011cc5a5c34f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8324fc1c57d84264a1e2011cc5a5c34f()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_ba592408edba4b3694772df944ecbacf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba592408edba4b3694772df944ecbacf()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_8307b61356f9488eb156a1e3e71a87ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8307b61356f9488eb156a1e3e71a87ae()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c6150847688640a5b3f9f40281afdab5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c6150847688640a5b3f9f40281afdab5()
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

      private sealed class MTHD_37b3830481c0490a8292252a99df6607 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_37b3830481c0490a8292252a99df6607()
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

      private sealed class MTHD_bea36dc06c34408280c0b8fefebd086e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bea36dc06c34408280c0b8fefebd086e()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_18b79c19d40540ad88b68bbfc4a6ee71 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_18b79c19d40540ad88b68bbfc4a6ee71()
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

      private sealed class MTHD_8fd2e7dec0be480abd96c16e20aa49fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8fd2e7dec0be480abd96c16e20aa49fc()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_de483b9035cc4c6fa7df51ddb8cf54f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de483b9035cc4c6fa7df51ddb8cf54f1()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f9c63180e6d6496d844da6a5b0342e6d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f9c63180e6d6496d844da6a5b0342e6d()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_3f53b14457414a22b956cb18b114a2bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f53b14457414a22b956cb18b114a2bc()
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

      private sealed class MTHD_cc1acd17315a4e52b5548f8b188b9027 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cc1acd17315a4e52b5548f8b188b9027()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_6a0057a4b1c845b3bd51c61a38d26142 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6a0057a4b1c845b3bd51c61a38d26142()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_e76fdb5b8d6c42228cc56127ed452781 : HardwiredMemberDescriptor
      {
        internal FLDV_e76fdb5b8d6c42228cc56127ed452781()
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

      private sealed class FLDV_628b907be8fc464aa932fa6f6356b608 : HardwiredMemberDescriptor
      {
        internal FLDV_628b907be8fc464aa932fa6f6356b608()
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

      private sealed class FLDV_8ee43a8ad2b84ca1b9aed21a76d1dcba : HardwiredMemberDescriptor
      {
        internal FLDV_8ee43a8ad2b84ca1b9aed21a76d1dcba()
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

      private sealed class FLDV_ea8e2b5cd4c14bfebe98064a192fe81d : HardwiredMemberDescriptor
      {
        internal FLDV_ea8e2b5cd4c14bfebe98064a192fe81d()
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

      private sealed class FLDV_aa79a235eccf4f308629398ca6fa3d2b : HardwiredMemberDescriptor
      {
        internal FLDV_aa79a235eccf4f308629398ca6fa3d2b()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_b72e5aa881fd41ca85f5e99da619e3f4 : HardwiredMemberDescriptor
      {
        internal FLDV_b72e5aa881fd41ca85f5e99da619e3f4()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_8cdcbdd982094993843b42869d804dc8 : HardwiredMemberDescriptor
      {
        internal FLDV_8cdcbdd982094993843b42869d804dc8()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_6bcbc3975c394acc9632c5e915edead7 : HardwiredMemberDescriptor
      {
        internal FLDV_6bcbc3975c394acc9632c5e915edead7()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_f71adbbcb80249138c83d1665705a241 : DynValueMemberDescriptor
      {
        internal DVAL_f71adbbcb80249138c83d1665705a241()
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

      private sealed class DVAL_fe0093910b43469eae166ed6e8067e21 : DynValueMemberDescriptor
      {
        internal DVAL_fe0093910b43469eae166ed6e8067e21()
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

    private sealed class TYPE_7086222dfdf042ce9ca28c5b09718529 : HardwiredUserDataDescriptor
    {
      internal TYPE_7086222dfdf042ce9ca28c5b09718529()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7086222dfdf042ce9ca28c5b09718529.MTHD_6e82044208ce47028dc6a26b739b6919()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7086222dfdf042ce9ca28c5b09718529.MTHD_6ace4f46433c4899a807b267b5a6c17b()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7086222dfdf042ce9ca28c5b09718529.MTHD_159b6d9242ce43b28d3a471f39b77d97(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7086222dfdf042ce9ca28c5b09718529.MTHD_194d7d369d2a4c5c85f00ae46d8ec251()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7086222dfdf042ce9ca28c5b09718529.MTHD_e737391919f4488d988508d5fc3a4ca5(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7086222dfdf042ce9ca28c5b09718529.MTHD_177f0fcce05648598e246378a2f02b74()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7086222dfdf042ce9ca28c5b09718529.MTHD_a7bcfc8e15c041fe96b5a21125c39337()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7086222dfdf042ce9ca28c5b09718529.MTHD_8d1700d8bffc447e8282302c7dc8d3cf()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7086222dfdf042ce9ca28c5b09718529.MTHD_f4b37168b0b0419e811d631255b5d547()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7086222dfdf042ce9ca28c5b09718529.MTHD_56b6ff17d2cf4012bbe54aa9ad57940b()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_7086222dfdf042ce9ca28c5b09718529.FLDV_881a62d273ef45ea9643b3845c56623c());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_7086222dfdf042ce9ca28c5b09718529.FLDV_db2a851dbbeb491399052e648ca6e9ea());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_7086222dfdf042ce9ca28c5b09718529.FLDV_f88fbd4ab45b4187a8388b944be0aaea());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_7086222dfdf042ce9ca28c5b09718529.FLDV_dcdb24eba9f94463b5fdbcc427c2c2d1());
        this.AddMember("white", (IMemberDescriptor) new Bridge.TYPE_7086222dfdf042ce9ca28c5b09718529.FLDV_a8c916c774054ca6a993e68f35779ba1());
      }

      private sealed class MTHD_6e82044208ce47028dc6a26b739b6919 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e82044208ce47028dc6a26b739b6919()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_6ace4f46433c4899a807b267b5a6c17b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ace4f46433c4899a807b267b5a6c17b()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_159b6d9242ce43b28d3a471f39b77d97 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_159b6d9242ce43b28d3a471f39b77d97()
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

      private sealed class MTHD_194d7d369d2a4c5c85f00ae46d8ec251 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_194d7d369d2a4c5c85f00ae46d8ec251()
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

      private sealed class MTHD_e737391919f4488d988508d5fc3a4ca5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e737391919f4488d988508d5fc3a4ca5()
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

      private sealed class MTHD_177f0fcce05648598e246378a2f02b74 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_177f0fcce05648598e246378a2f02b74()
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

      private sealed class MTHD_a7bcfc8e15c041fe96b5a21125c39337 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a7bcfc8e15c041fe96b5a21125c39337()
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

      private sealed class MTHD_8d1700d8bffc447e8282302c7dc8d3cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8d1700d8bffc447e8282302c7dc8d3cf()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_f4b37168b0b0419e811d631255b5d547 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4b37168b0b0419e811d631255b5d547()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_56b6ff17d2cf4012bbe54aa9ad57940b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_56b6ff17d2cf4012bbe54aa9ad57940b()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_881a62d273ef45ea9643b3845c56623c : HardwiredMemberDescriptor
      {
        internal FLDV_881a62d273ef45ea9643b3845c56623c()
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

      private sealed class FLDV_db2a851dbbeb491399052e648ca6e9ea : HardwiredMemberDescriptor
      {
        internal FLDV_db2a851dbbeb491399052e648ca6e9ea()
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

      private sealed class FLDV_f88fbd4ab45b4187a8388b944be0aaea : HardwiredMemberDescriptor
      {
        internal FLDV_f88fbd4ab45b4187a8388b944be0aaea()
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

      private sealed class FLDV_dcdb24eba9f94463b5fdbcc427c2c2d1 : HardwiredMemberDescriptor
      {
        internal FLDV_dcdb24eba9f94463b5fdbcc427c2c2d1()
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

      private sealed class FLDV_a8c916c774054ca6a993e68f35779ba1 : HardwiredMemberDescriptor
      {
        internal FLDV_a8c916c774054ca6a993e68f35779ba1()
          : base(typeof (LuaColor), "white", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) LuaColor.white;
        }
      }
    }

    private sealed class TYPE_d0653baac985446ab91461f37666ac36 : HardwiredUserDataDescriptor
    {
      internal TYPE_d0653baac985446ab91461f37666ac36()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0653baac985446ab91461f37666ac36.MTHD_c93cc10ed2404b37b28b1668a6426630()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0653baac985446ab91461f37666ac36.MTHD_23822dcf47104f6bac407672fa104741()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0653baac985446ab91461f37666ac36.MTHD_9b1df697ad55451b83317352d4e60e52()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0653baac985446ab91461f37666ac36.MTHD_d1b4ad91acdf4e2d9a4fa2bec7757a37()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d0653baac985446ab91461f37666ac36.MTHD_3bf63a01dc054e178e6bb6e3bb09b273()
        }));
      }

      private sealed class MTHD_c93cc10ed2404b37b28b1668a6426630 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c93cc10ed2404b37b28b1668a6426630()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_23822dcf47104f6bac407672fa104741 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_23822dcf47104f6bac407672fa104741()
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

      private sealed class MTHD_9b1df697ad55451b83317352d4e60e52 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b1df697ad55451b83317352d4e60e52()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_d1b4ad91acdf4e2d9a4fa2bec7757a37 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1b4ad91acdf4e2d9a4fa2bec7757a37()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_3bf63a01dc054e178e6bb6e3bb09b273 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3bf63a01dc054e178e6bb6e3bb09b273()
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
