
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
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_c46389ba19c544bb9aca248b068df174());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_75c42e8f6b0242298fe56df034304e53());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_44cff6b103104c1abd9bbcfe3e562bf5());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_6829ea0050334a42b3e486d24556a884());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_8912af4765db45008a0488b09ab1f095());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_0fd536adf10244a69a127bc76c138a79());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_3522a98f1180415a94382838d4ddef02());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_8779eab0e7d74a7fa35d37f02d4a37bd());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_d6596ae94fba46bdb068b2f529494e7a());
    }

    private sealed class TYPE_42f1bd3acffb4a829acdff39db97c95f : HardwiredUserDataDescriptor
    {
      internal TYPE_42f1bd3acffb4a829acdff39db97c95f()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_2bcfa40d5cf94443994dfcf32905d6fa()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_a14cf265dfae46a8ae07f85966310f4a()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_2a3c81b96c1c46db9e9601e1a0345722()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_ff41788cca60482198cbbab98e21c800()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_654c503d657d44818e01b7738a3c48a8()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_11dbd5d690b141bba1290a76b583d412()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_734dd018df584928a8b9fd2984b171c2()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_7506cec6d2164cb0b639f4dc3f6063d8()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_62afea6c7cb447629d8215ba6876eb42()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_981370144cd24c0ea2bf1b62e0a582ef()
        }));
        this.AddMember("hideInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("hideInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_15a75a8c88694e3f80e3045f77d6874f()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_9560ce82d6714f93bf2bf7d14ed1274f()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_7c1fc8ccffda479780bcdee332460dd7()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_c93dd64e4bf34116aeeb629d32d331c6()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_b2befa03c94449c1aaca44b5baf01aae()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_16f82a2c9aac4cbab387d16edab3441b()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_4c736691f7c546c9a9715ef17ef91e18()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_f63106b513ba409aacdf229aefdabfa0()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_534fd473fa34424e970bbd4ae9fe80b4()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_d6f40c83805d48ecbc365783c0659132()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_a6275c1b97d04ffc8d5460d1b5126dd9()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_5c127b32525140659727dc66e78ba96e()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_d0ed002d944d4354b018e59ef1b4165f()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_6be6beb8f88e471ba53261c566951e0d()
        }));
        this.AddMember("get_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_24d1eecbd9364fd780c3632e001e71d0()
        }));
        this.AddMember("set_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_33c0416482fb463d9170114afbebc888()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_d3858e39960a4bbab029cdabefcec9be()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_7f92886f5557431fa80d9c89ec8f7a77()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_2e8e20e97f6b47aa8e6b9f11c64482dd()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_749b82a55ad4459ca4e5a0a7663e95fe()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_6b00c68bdf8447bdad4ec694a82b2b71()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_90ecb427dade4b7e85c5bb245416d92c()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_2292e3d03c074f918f6125e8b547e5fb()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_555ed80740d843e784c8e24017a464d3()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_7b752c00821c4b38a6e8a69602e5d331()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_c3c51137492a47b781a91d8dcbc55297()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_ca042cfbcbbe41c8b610e247f7a37d39()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_fa8d23cb15544542aeb09e8b43f5b038()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_3728373ff01643929b0ddc800f9768d3()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_e4fabfc0f9934ed1adcb815b93532908()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_52c372a999fa4147891be126b4983b94()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_2ad95e7536a94c339667a3afc26bd1a4()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_033ae4749e464471aec75afe143cff96()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_ca25343f773b44908efd5b8cfbedff58()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_864eff550d4948858a9be4db5e6a3d48()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_782118cc237f47608d089d3bb79cdfdc()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_8e691ac55bb945c499b4c3d267eb05b2()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_10f10a7af02641d98d995464e37c5ee0()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_f3a0cbe8e46e4f52aa6ad683c0a2b6b8()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_8362d4c058eb47ffb6cd2c44c978aa71()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_20803a62ba84484eaef9bb4034f81799()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_fd3379b7487e459d894ef15546c12a22()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_4220cacf28d54390b500984224222ca8()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_da1b65af44244b2b891a28eae6e8fd9d()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_e832cc3e8cde43458904106de20cb8b5()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_dfb2bbce7ac142ee8018c9131f395a39()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_244192f147ae452b9958467982809fc1()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_67ff8e0e7e864b0fa2510c8224400c89()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_cbb203f4174c49399e6216f98d241582()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_38c98074df284ec9902360253ea5d669()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_6ebab0c7452a4cee82b18830705ae85e()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_59504011b41546cf9f005c48bbc9078c()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_7b451fa5172044a1bfc8ed2ae96917cf()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_6a8f8276cf394c789b6de2da6ed8b7ca()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_0634cde7dbb54e6dab8553c028e28a94()
        }));
        this.AddMember("Dispose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Dispose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_1f7188b0e26f4027b51b39d224918049()
        }));
        this.AddMember("drawImage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawImage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_da477249b1f04b1090acf9071a2d4e1d()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_bdbef88537db46b5bac404fbf7c788ff()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_77a1fe17e1c742dfa50b029951b521e6()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_9acbdad79bc34ecf9e6487693ef72031()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_f3d03219d82f415c85e57ce7bcc7794c()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_7fb89bb02dc54f598b1cda61a2d8358f()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_17405b21dc9547e2a92c8ef665887b39()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_7eea1ec210dd4df6a05423336096512c()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_75ae997f768c4fa691b3c2d1ce9c67f8()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_d17085623e3d4cb990ab0a3f59b00399()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_e6ee7212ab7f4ec2a7f52e08583e94ac()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_11a0a430d8ba4c0490440d97c6a1ebf2()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_111c5833ddf544dbbb18157f601bfca3()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_c2da44a9598e4dc1a7e74555c0007c77()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_b1fbe986b190452dbc4d4129576e5a95()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_a0f87858220141c2b02012b1e1625d65()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_6a9d6596794a4f6987611a1758187edb()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_826c0a7231bc4208b2fe581bdf896bd9()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_9ea78544b2a94b6695cc64dbd0d15a37()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_64099fffbe0f4e2e912316a4bf89604e()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_290884575ec944b59d30f7146b23549e()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_69a6e2583d5d4cb5a7527d9dc28b98b4()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_f87a414af21144c98023a7c32dd71af9()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_dec57d4039c6419384de79c635f04fd3()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_ac58753193194979bc89040cd48fe27c()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_7461744116734267b37cda9f040b96c3()
        }));
        this.AddMember("cameraFollow", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("cameraFollow", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_46fbb6698a8b4b2daefd03ba70d29a61()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_df34a55c56f44c7a99f377173ae225aa()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_74379926745f4bcc8120fe8e866e72a0()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_559e5ab9cab64f35a09ae213e9b7be3e()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_d457c6f2aa984ae38abb884c3bbbbbc7()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_ca299bf4e435447d9abde832fe3e0d73()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_69aa0c9ea4ba4a2a9ea1412b685793db(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_059be22b597742a394d0fc1afc3e4f20()
        }));
        this.AddMember("getKeyBinds", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getKeyBinds", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_b0322fab4eaa440db6b91985b6d2e2b6()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_2f1c422d49384d1cbcd76c8e8d4cc1c3()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_ee168fee2df946deaab547334ecf6462()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_bb6fdad6373f4b47946d15f3ed58346d()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.MTHD_a0cea1c49d8c42f5a285b874acbfa4c7()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_ea4232aafd3143f79a09a84aef4eecc4());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_84e077a2376e4a0498f6d1f348c01a81());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_d4735faf0a7243469ca765c81735ec2a());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_9981a2705b27473c91bf8132a2ec69df());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_b5f2bd7757d54951907a462c1f2c10a9());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_66cbeb298a6443c39fe0e5554630a600());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_68bdfce6153744118394e8b0d4f8ab1c());
        this.AddMember("allowMinionMovement", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_50866299cc29412694d3ffd4bf42e1fa());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_5ac28ce27b124f55a55be958727d4158());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_da0a6d89097b420890ab561c83a9c183());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_d0bb1b660c75442cb2904de0095096be());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_e9e4c4e108a640d2853ce1736c93d085());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_e420431d2f4e4cea860f60e775d2fc71());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_2b458edd4d414a98a4dde150d4ec59a5());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_2a18578c036d42699b1bd39973cd849f());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_99bc48307cc04b21a265fa7acccea60f());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_c1215ea34f3d495cadaafc52f7f3e347());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_07318c1843bf42e68bf6e71b52de99f2());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_705282cbce9949b094159d81a47e04a9());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_43dfcf0d3a70432e8e055becd21b55f8());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_835608e2cbe44a5b9f6399191b765872());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_c6206ca4de51494685003659d127f317());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_4cc400d2767a4bf6b3afd063e79e2ac6());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_4c64a416890249219a3ec209ff157e2c());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_fab365248f24479383711ea81b0d0b8b());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_f8b11141259b40ccae9c24cbb2077cf3());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_aa7305eca5f24b9384918aa2244aafce());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_e5cc9c3c35d04887b8c3a60f940f627c());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_800924b3ce2c42399ae274cde7994963());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_235006096553433d933fde9134833fc3());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_ca88e41dd9cf465dab420e1f43d3cdee());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_3c846620f5e14fe5867e29cb0a21241d());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_42f1bd3acffb4a829acdff39db97c95f.PROP_2ca88eb10f304c228c1c5d4d4c8d1efd());
      }

      private sealed class MTHD_2bcfa40d5cf94443994dfcf32905d6fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2bcfa40d5cf94443994dfcf32905d6fa()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_a14cf265dfae46a8ae07f85966310f4a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a14cf265dfae46a8ae07f85966310f4a()
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

      private sealed class MTHD_2a3c81b96c1c46db9e9601e1a0345722 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a3c81b96c1c46db9e9601e1a0345722()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_ff41788cca60482198cbbab98e21c800 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff41788cca60482198cbbab98e21c800()
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

      private sealed class MTHD_654c503d657d44818e01b7738a3c48a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_654c503d657d44818e01b7738a3c48a8()
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

      private sealed class MTHD_11dbd5d690b141bba1290a76b583d412 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_11dbd5d690b141bba1290a76b583d412()
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

      private sealed class MTHD_734dd018df584928a8b9fd2984b171c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_734dd018df584928a8b9fd2984b171c2()
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

      private sealed class MTHD_7506cec6d2164cb0b639f4dc3f6063d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7506cec6d2164cb0b639f4dc3f6063d8()
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

      private sealed class MTHD_62afea6c7cb447629d8215ba6876eb42 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_62afea6c7cb447629d8215ba6876eb42()
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

      private sealed class MTHD_981370144cd24c0ea2bf1b62e0a582ef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_981370144cd24c0ea2bf1b62e0a582ef()
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

      private sealed class MTHD_15a75a8c88694e3f80e3045f77d6874f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15a75a8c88694e3f80e3045f77d6874f()
        {
          this.Initialize("hideInfo", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).hideInfo();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9560ce82d6714f93bf2bf7d14ed1274f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9560ce82d6714f93bf2bf7d14ed1274f()
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

      private sealed class MTHD_7c1fc8ccffda479780bcdee332460dd7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7c1fc8ccffda479780bcdee332460dd7()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_c93dd64e4bf34116aeeb629d32d331c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c93dd64e4bf34116aeeb629d32d331c6()
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

      private sealed class MTHD_b2befa03c94449c1aaca44b5baf01aae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b2befa03c94449c1aaca44b5baf01aae()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_16f82a2c9aac4cbab387d16edab3441b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_16f82a2c9aac4cbab387d16edab3441b()
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

      private sealed class MTHD_4c736691f7c546c9a9715ef17ef91e18 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c736691f7c546c9a9715ef17ef91e18()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_f63106b513ba409aacdf229aefdabfa0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f63106b513ba409aacdf229aefdabfa0()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_534fd473fa34424e970bbd4ae9fe80b4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_534fd473fa34424e970bbd4ae9fe80b4()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_d6f40c83805d48ecbc365783c0659132 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6f40c83805d48ecbc365783c0659132()
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

      private sealed class MTHD_a6275c1b97d04ffc8d5460d1b5126dd9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a6275c1b97d04ffc8d5460d1b5126dd9()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_5c127b32525140659727dc66e78ba96e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c127b32525140659727dc66e78ba96e()
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

      private sealed class MTHD_d0ed002d944d4354b018e59ef1b4165f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0ed002d944d4354b018e59ef1b4165f()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_6be6beb8f88e471ba53261c566951e0d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6be6beb8f88e471ba53261c566951e0d()
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

      private sealed class MTHD_24d1eecbd9364fd780c3632e001e71d0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24d1eecbd9364fd780c3632e001e71d0()
        {
          this.Initialize("get_allowMinionMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMinionMovement;
        }
      }

      private sealed class MTHD_33c0416482fb463d9170114afbebc888 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_33c0416482fb463d9170114afbebc888()
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

      private sealed class MTHD_d3858e39960a4bbab029cdabefcec9be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d3858e39960a4bbab029cdabefcec9be()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_7f92886f5557431fa80d9c89ec8f7a77 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f92886f5557431fa80d9c89ec8f7a77()
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

      private sealed class MTHD_2e8e20e97f6b47aa8e6b9f11c64482dd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2e8e20e97f6b47aa8e6b9f11c64482dd()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_749b82a55ad4459ca4e5a0a7663e95fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_749b82a55ad4459ca4e5a0a7663e95fe()
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

      private sealed class MTHD_6b00c68bdf8447bdad4ec694a82b2b71 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b00c68bdf8447bdad4ec694a82b2b71()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_90ecb427dade4b7e85c5bb245416d92c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90ecb427dade4b7e85c5bb245416d92c()
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

      private sealed class MTHD_2292e3d03c074f918f6125e8b547e5fb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2292e3d03c074f918f6125e8b547e5fb()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_555ed80740d843e784c8e24017a464d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_555ed80740d843e784c8e24017a464d3()
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

      private sealed class MTHD_7b752c00821c4b38a6e8a69602e5d331 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b752c00821c4b38a6e8a69602e5d331()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_c3c51137492a47b781a91d8dcbc55297 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c3c51137492a47b781a91d8dcbc55297()
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

      private sealed class MTHD_ca042cfbcbbe41c8b610e247f7a37d39 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ca042cfbcbbe41c8b610e247f7a37d39()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_fa8d23cb15544542aeb09e8b43f5b038 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa8d23cb15544542aeb09e8b43f5b038()
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

      private sealed class MTHD_3728373ff01643929b0ddc800f9768d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3728373ff01643929b0ddc800f9768d3()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_e4fabfc0f9934ed1adcb815b93532908 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e4fabfc0f9934ed1adcb815b93532908()
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

      private sealed class MTHD_52c372a999fa4147891be126b4983b94 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52c372a999fa4147891be126b4983b94()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_2ad95e7536a94c339667a3afc26bd1a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2ad95e7536a94c339667a3afc26bd1a4()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_033ae4749e464471aec75afe143cff96 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_033ae4749e464471aec75afe143cff96()
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

      private sealed class MTHD_ca25343f773b44908efd5b8cfbedff58 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ca25343f773b44908efd5b8cfbedff58()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_864eff550d4948858a9be4db5e6a3d48 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_864eff550d4948858a9be4db5e6a3d48()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_782118cc237f47608d089d3bb79cdfdc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_782118cc237f47608d089d3bb79cdfdc()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_8e691ac55bb945c499b4c3d267eb05b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e691ac55bb945c499b4c3d267eb05b2()
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

      private sealed class MTHD_10f10a7af02641d98d995464e37c5ee0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_10f10a7af02641d98d995464e37c5ee0()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_f3a0cbe8e46e4f52aa6ad683c0a2b6b8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f3a0cbe8e46e4f52aa6ad683c0a2b6b8()
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

      private sealed class MTHD_8362d4c058eb47ffb6cd2c44c978aa71 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8362d4c058eb47ffb6cd2c44c978aa71()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_20803a62ba84484eaef9bb4034f81799 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_20803a62ba84484eaef9bb4034f81799()
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

      private sealed class MTHD_fd3379b7487e459d894ef15546c12a22 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd3379b7487e459d894ef15546c12a22()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_4220cacf28d54390b500984224222ca8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4220cacf28d54390b500984224222ca8()
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

      private sealed class MTHD_da1b65af44244b2b891a28eae6e8fd9d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_da1b65af44244b2b891a28eae6e8fd9d()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_e832cc3e8cde43458904106de20cb8b5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e832cc3e8cde43458904106de20cb8b5()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_dfb2bbce7ac142ee8018c9131f395a39 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dfb2bbce7ac142ee8018c9131f395a39()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_244192f147ae452b9958467982809fc1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_244192f147ae452b9958467982809fc1()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_67ff8e0e7e864b0fa2510c8224400c89 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67ff8e0e7e864b0fa2510c8224400c89()
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

      private sealed class MTHD_cbb203f4174c49399e6216f98d241582 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cbb203f4174c49399e6216f98d241582()
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

      private sealed class MTHD_38c98074df284ec9902360253ea5d669 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_38c98074df284ec9902360253ea5d669()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_6ebab0c7452a4cee82b18830705ae85e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ebab0c7452a4cee82b18830705ae85e()
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

      private sealed class MTHD_59504011b41546cf9f005c48bbc9078c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_59504011b41546cf9f005c48bbc9078c()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_7b451fa5172044a1bfc8ed2ae96917cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b451fa5172044a1bfc8ed2ae96917cf()
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

      private sealed class MTHD_6a8f8276cf394c789b6de2da6ed8b7ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6a8f8276cf394c789b6de2da6ed8b7ca()
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

      private sealed class MTHD_0634cde7dbb54e6dab8553c028e28a94 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0634cde7dbb54e6dab8553c028e28a94()
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

      private sealed class MTHD_1f7188b0e26f4027b51b39d224918049 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f7188b0e26f4027b51b39d224918049()
        {
          this.Initialize("Dispose", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ContainerGame.Dispose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_da477249b1f04b1090acf9071a2d4e1d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_da477249b1f04b1090acf9071a2d4e1d()
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

      private sealed class MTHD_bdbef88537db46b5bac404fbf7c788ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bdbef88537db46b5bac404fbf7c788ff()
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

      private sealed class MTHD_77a1fe17e1c742dfa50b029951b521e6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_77a1fe17e1c742dfa50b029951b521e6()
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

      private sealed class MTHD_9acbdad79bc34ecf9e6487693ef72031 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9acbdad79bc34ecf9e6487693ef72031()
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

      private sealed class MTHD_f3d03219d82f415c85e57ce7bcc7794c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f3d03219d82f415c85e57ce7bcc7794c()
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

      private sealed class MTHD_7fb89bb02dc54f598b1cda61a2d8358f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7fb89bb02dc54f598b1cda61a2d8358f()
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

      private sealed class MTHD_17405b21dc9547e2a92c8ef665887b39 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_17405b21dc9547e2a92c8ef665887b39()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_7eea1ec210dd4df6a05423336096512c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7eea1ec210dd4df6a05423336096512c()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_75ae997f768c4fa691b3c2d1ce9c67f8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75ae997f768c4fa691b3c2d1ce9c67f8()
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

      private sealed class MTHD_d17085623e3d4cb990ab0a3f59b00399 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d17085623e3d4cb990ab0a3f59b00399()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_e6ee7212ab7f4ec2a7f52e08583e94ac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e6ee7212ab7f4ec2a7f52e08583e94ac()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_11a0a430d8ba4c0490440d97c6a1ebf2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_11a0a430d8ba4c0490440d97c6a1ebf2()
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

      private sealed class MTHD_111c5833ddf544dbbb18157f601bfca3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_111c5833ddf544dbbb18157f601bfca3()
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

      private sealed class MTHD_c2da44a9598e4dc1a7e74555c0007c77 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c2da44a9598e4dc1a7e74555c0007c77()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b1fbe986b190452dbc4d4129576e5a95 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b1fbe986b190452dbc4d4129576e5a95()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_a0f87858220141c2b02012b1e1625d65 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a0f87858220141c2b02012b1e1625d65()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_6a9d6596794a4f6987611a1758187edb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6a9d6596794a4f6987611a1758187edb()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_826c0a7231bc4208b2fe581bdf896bd9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_826c0a7231bc4208b2fe581bdf896bd9()
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

      private sealed class MTHD_9ea78544b2a94b6695cc64dbd0d15a37 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ea78544b2a94b6695cc64dbd0d15a37()
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

      private sealed class MTHD_64099fffbe0f4e2e912316a4bf89604e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_64099fffbe0f4e2e912316a4bf89604e()
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

      private sealed class MTHD_290884575ec944b59d30f7146b23549e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_290884575ec944b59d30f7146b23549e()
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

      private sealed class MTHD_69a6e2583d5d4cb5a7527d9dc28b98b4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69a6e2583d5d4cb5a7527d9dc28b98b4()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_f87a414af21144c98023a7c32dd71af9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f87a414af21144c98023a7c32dd71af9()
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

      private sealed class MTHD_dec57d4039c6419384de79c635f04fd3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dec57d4039c6419384de79c635f04fd3()
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

      private sealed class MTHD_ac58753193194979bc89040cd48fe27c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac58753193194979bc89040cd48fe27c()
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

      private sealed class MTHD_7461744116734267b37cda9f040b96c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7461744116734267b37cda9f040b96c3()
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

      private sealed class MTHD_46fbb6698a8b4b2daefd03ba70d29a61 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_46fbb6698a8b4b2daefd03ba70d29a61()
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

      private sealed class MTHD_df34a55c56f44c7a99f377173ae225aa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_df34a55c56f44c7a99f377173ae225aa()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_74379926745f4bcc8120fe8e866e72a0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74379926745f4bcc8120fe8e866e72a0()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_559e5ab9cab64f35a09ae213e9b7be3e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_559e5ab9cab64f35a09ae213e9b7be3e()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_d457c6f2aa984ae38abb884c3bbbbbc7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d457c6f2aa984ae38abb884c3bbbbbc7()
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

      private sealed class MTHD_ca299bf4e435447d9abde832fe3e0d73 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ca299bf4e435447d9abde832fe3e0d73()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_69aa0c9ea4ba4a2a9ea1412b685793db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69aa0c9ea4ba4a2a9ea1412b685793db()
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

      private sealed class MTHD_059be22b597742a394d0fc1afc3e4f20 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_059be22b597742a394d0fc1afc3e4f20()
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

      private sealed class MTHD_b0322fab4eaa440db6b91985b6d2e2b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b0322fab4eaa440db6b91985b6d2e2b6()
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

      private sealed class MTHD_2f1c422d49384d1cbcd76c8e8d4cc1c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2f1c422d49384d1cbcd76c8e8d4cc1c3()
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

      private sealed class MTHD_ee168fee2df946deaab547334ecf6462 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee168fee2df946deaab547334ecf6462()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_bb6fdad6373f4b47946d15f3ed58346d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb6fdad6373f4b47946d15f3ed58346d()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_a0cea1c49d8c42f5a285b874acbfa4c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a0cea1c49d8c42f5a285b874acbfa4c7()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_ea4232aafd3143f79a09a84aef4eecc4 : HardwiredMemberDescriptor
      {
        internal PROP_ea4232aafd3143f79a09a84aef4eecc4()
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

      private sealed class PROP_84e077a2376e4a0498f6d1f348c01a81 : HardwiredMemberDescriptor
      {
        internal PROP_84e077a2376e4a0498f6d1f348c01a81()
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

      private sealed class PROP_d4735faf0a7243469ca765c81735ec2a : HardwiredMemberDescriptor
      {
        internal PROP_d4735faf0a7243469ca765c81735ec2a()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_9981a2705b27473c91bf8132a2ec69df : HardwiredMemberDescriptor
      {
        internal PROP_9981a2705b27473c91bf8132a2ec69df()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_b5f2bd7757d54951907a462c1f2c10a9 : HardwiredMemberDescriptor
      {
        internal PROP_b5f2bd7757d54951907a462c1f2c10a9()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_66cbeb298a6443c39fe0e5554630a600 : HardwiredMemberDescriptor
      {
        internal PROP_66cbeb298a6443c39fe0e5554630a600()
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

      private sealed class PROP_68bdfce6153744118394e8b0d4f8ab1c : HardwiredMemberDescriptor
      {
        internal PROP_68bdfce6153744118394e8b0d4f8ab1c()
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

      private sealed class PROP_50866299cc29412694d3ffd4bf42e1fa : HardwiredMemberDescriptor
      {
        internal PROP_50866299cc29412694d3ffd4bf42e1fa()
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

      private sealed class PROP_5ac28ce27b124f55a55be958727d4158 : HardwiredMemberDescriptor
      {
        internal PROP_5ac28ce27b124f55a55be958727d4158()
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

      private sealed class PROP_da0a6d89097b420890ab561c83a9c183 : HardwiredMemberDescriptor
      {
        internal PROP_da0a6d89097b420890ab561c83a9c183()
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

      private sealed class PROP_d0bb1b660c75442cb2904de0095096be : HardwiredMemberDescriptor
      {
        internal PROP_d0bb1b660c75442cb2904de0095096be()
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

      private sealed class PROP_e9e4c4e108a640d2853ce1736c93d085 : HardwiredMemberDescriptor
      {
        internal PROP_e9e4c4e108a640d2853ce1736c93d085()
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

      private sealed class PROP_e420431d2f4e4cea860f60e775d2fc71 : HardwiredMemberDescriptor
      {
        internal PROP_e420431d2f4e4cea860f60e775d2fc71()
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

      private sealed class PROP_2b458edd4d414a98a4dde150d4ec59a5 : HardwiredMemberDescriptor
      {
        internal PROP_2b458edd4d414a98a4dde150d4ec59a5()
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

      private sealed class PROP_2a18578c036d42699b1bd39973cd849f : HardwiredMemberDescriptor
      {
        internal PROP_2a18578c036d42699b1bd39973cd849f()
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

      private sealed class PROP_99bc48307cc04b21a265fa7acccea60f : HardwiredMemberDescriptor
      {
        internal PROP_99bc48307cc04b21a265fa7acccea60f()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_c1215ea34f3d495cadaafc52f7f3e347 : HardwiredMemberDescriptor
      {
        internal PROP_c1215ea34f3d495cadaafc52f7f3e347()
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

      private sealed class PROP_07318c1843bf42e68bf6e71b52de99f2 : HardwiredMemberDescriptor
      {
        internal PROP_07318c1843bf42e68bf6e71b52de99f2()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_705282cbce9949b094159d81a47e04a9 : HardwiredMemberDescriptor
      {
        internal PROP_705282cbce9949b094159d81a47e04a9()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_43dfcf0d3a70432e8e055becd21b55f8 : HardwiredMemberDescriptor
      {
        internal PROP_43dfcf0d3a70432e8e055becd21b55f8()
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

      private sealed class PROP_835608e2cbe44a5b9f6399191b765872 : HardwiredMemberDescriptor
      {
        internal PROP_835608e2cbe44a5b9f6399191b765872()
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

      private sealed class PROP_c6206ca4de51494685003659d127f317 : HardwiredMemberDescriptor
      {
        internal PROP_c6206ca4de51494685003659d127f317()
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

      private sealed class PROP_4cc400d2767a4bf6b3afd063e79e2ac6 : HardwiredMemberDescriptor
      {
        internal PROP_4cc400d2767a4bf6b3afd063e79e2ac6()
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

      private sealed class PROP_4c64a416890249219a3ec209ff157e2c : HardwiredMemberDescriptor
      {
        internal PROP_4c64a416890249219a3ec209ff157e2c()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_fab365248f24479383711ea81b0d0b8b : HardwiredMemberDescriptor
      {
        internal PROP_fab365248f24479383711ea81b0d0b8b()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_f8b11141259b40ccae9c24cbb2077cf3 : HardwiredMemberDescriptor
      {
        internal PROP_f8b11141259b40ccae9c24cbb2077cf3()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_aa7305eca5f24b9384918aa2244aafce : HardwiredMemberDescriptor
      {
        internal PROP_aa7305eca5f24b9384918aa2244aafce()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_e5cc9c3c35d04887b8c3a60f940f627c : HardwiredMemberDescriptor
      {
        internal PROP_e5cc9c3c35d04887b8c3a60f940f627c()
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

      private sealed class PROP_800924b3ce2c42399ae274cde7994963 : HardwiredMemberDescriptor
      {
        internal PROP_800924b3ce2c42399ae274cde7994963()
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

      private sealed class PROP_235006096553433d933fde9134833fc3 : HardwiredMemberDescriptor
      {
        internal PROP_235006096553433d933fde9134833fc3()
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

      private sealed class PROP_ca88e41dd9cf465dab420e1f43d3cdee : HardwiredMemberDescriptor
      {
        internal PROP_ca88e41dd9cf465dab420e1f43d3cdee()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_3c846620f5e14fe5867e29cb0a21241d : HardwiredMemberDescriptor
      {
        internal PROP_3c846620f5e14fe5867e29cb0a21241d()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_2ca88eb10f304c228c1c5d4d4c8d1efd : HardwiredMemberDescriptor
      {
        internal PROP_2ca88eb10f304c228c1c5d4d4c8d1efd()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_c46389ba19c544bb9aca248b068df174 : HardwiredUserDataDescriptor
    {
      internal TYPE_c46389ba19c544bb9aca248b068df174()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c46389ba19c544bb9aca248b068df174.MTHD_60f871c2b284454f9a83d045bb78fd6e()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c46389ba19c544bb9aca248b068df174.MTHD_38602a94a82c46c2bb85c0e9a680a062()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c46389ba19c544bb9aca248b068df174.MTHD_a53393bfbb8347f7a498185a179e1966()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c46389ba19c544bb9aca248b068df174.MTHD_d42bf073329046129b9933a716726842()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c46389ba19c544bb9aca248b068df174.MTHD_cdf41f19847c4687b2cc1db37d97ba82()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c46389ba19c544bb9aca248b068df174.MTHD_844cde1c2dc34df6a8fc730f6c39a686()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c46389ba19c544bb9aca248b068df174.MTHD_eb9dcfdda3fa42fe88619e89900bb3bc()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c46389ba19c544bb9aca248b068df174.MTHD_9ca56577279f4fbf8148448976a8b759()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c46389ba19c544bb9aca248b068df174.MTHD_e14483e93f174904a0ec079844b2d6d1()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c46389ba19c544bb9aca248b068df174.MTHD_fc16e13b2db34f7f9351f899dccd2ee1()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c46389ba19c544bb9aca248b068df174.MTHD_c84e0425d85f47afbbb85b861e155020()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c46389ba19c544bb9aca248b068df174.MTHD_4fad90f458cc4927af9e3be56880c03e()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_c46389ba19c544bb9aca248b068df174.PROP_f751c97ab03a49778afecd3f5048b4fb());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_c46389ba19c544bb9aca248b068df174.PROP_a991f1f8ff6d492c8413bbdd87ab21af());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_c46389ba19c544bb9aca248b068df174.PROP_1515b532cedf4301a0af1438f2050b8b());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_c46389ba19c544bb9aca248b068df174.PROP_b9ac161092314bb6a0c9b93ecf9d1ecc());
      }

      private sealed class MTHD_60f871c2b284454f9a83d045bb78fd6e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60f871c2b284454f9a83d045bb78fd6e()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_38602a94a82c46c2bb85c0e9a680a062 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_38602a94a82c46c2bb85c0e9a680a062()
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

      private sealed class MTHD_a53393bfbb8347f7a498185a179e1966 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a53393bfbb8347f7a498185a179e1966()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_d42bf073329046129b9933a716726842 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d42bf073329046129b9933a716726842()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_cdf41f19847c4687b2cc1db37d97ba82 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cdf41f19847c4687b2cc1db37d97ba82()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_844cde1c2dc34df6a8fc730f6c39a686 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_844cde1c2dc34df6a8fc730f6c39a686()
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

      private sealed class MTHD_eb9dcfdda3fa42fe88619e89900bb3bc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb9dcfdda3fa42fe88619e89900bb3bc()
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

      private sealed class MTHD_9ca56577279f4fbf8148448976a8b759 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9ca56577279f4fbf8148448976a8b759()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_e14483e93f174904a0ec079844b2d6d1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e14483e93f174904a0ec079844b2d6d1()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_fc16e13b2db34f7f9351f899dccd2ee1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fc16e13b2db34f7f9351f899dccd2ee1()
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

      private sealed class MTHD_c84e0425d85f47afbbb85b861e155020 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c84e0425d85f47afbbb85b861e155020()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_4fad90f458cc4927af9e3be56880c03e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4fad90f458cc4927af9e3be56880c03e()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_f751c97ab03a49778afecd3f5048b4fb : HardwiredMemberDescriptor
      {
        internal PROP_f751c97ab03a49778afecd3f5048b4fb()
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

      private sealed class PROP_a991f1f8ff6d492c8413bbdd87ab21af : HardwiredMemberDescriptor
      {
        internal PROP_a991f1f8ff6d492c8413bbdd87ab21af()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_1515b532cedf4301a0af1438f2050b8b : HardwiredMemberDescriptor
      {
        internal PROP_1515b532cedf4301a0af1438f2050b8b()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_b9ac161092314bb6a0c9b93ecf9d1ecc : HardwiredMemberDescriptor
      {
        internal PROP_b9ac161092314bb6a0c9b93ecf9d1ecc()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_fc39a19282864669a67818614bb87665 : HardwiredUserDataDescriptor
    {
      internal TYPE_fc39a19282864669a67818614bb87665()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_91dfe5e239214191b7af9d4a64cae1b7()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_5ded6f3cf0404b6bafdee62d23147053()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_18ec8e9cc66c412d8258a903b6825f35()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_41cc446d7dee40589c51bc52011e4b40()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_5c9429933eb34a668763a4bd92f90d2d()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_bc25a71ab9d7487785d34530b333d903()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_67fcb689bc814461acfc92ef13d8112a()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_cbdd74e8cf37435dbe7506a72e70d072()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_12ad47a27afc4db7af6af0f59e50c988()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_750b7e8b6ce740cb88e114012f0c803e()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_8381ad760111443c86533fd932952372()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_ab5bd0cd35054336b150b690a45c6e15()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_ee6132a9d8074f1eaa73cd8c758c567b()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_484ef19191a6436ab7bd654d904e6a41()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_9bd18b01b8bd42a7894cd92f269d1fc9()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_6ffab79d8cd442ccb291bea435f97e15()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_177cdaf7db7a4099ba16f9cbfc5508d6()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_8b49d2d85db94160b2d47b47e22dfe42()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_7ecef2e4ef734e8f8ea943ed83c6c34b()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_06b4f9a176824b48959c60cb4e5e6cf9()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_49058b36e82e40f4a8566540b2327562()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_35d4ac01b2d3472da67439387c0a82b1()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_0482a6a9156142aead26bbf117ea35cd()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_f59e448bd6b0440ca5abd12ed7fad523()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_18f85ad103874655b4c544763f18cea4()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_d410863d6c4a4ac9834ba935fbebf462()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_18f5c32253404f3a945c62f54a36ec1b()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_7600677ab3b443ba86ebb676220e218f()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_cd8b08c366704acd91c6f8eb112ec967()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_b00f4c54350f470187a7937d6d5c1e8a()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_24e4d433516c4dd08581d2aebb47c06f()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_de2654ebf0ad4f08814d8e63e4034b04()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_d410770763984f18a0a09a1359c260c3()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_2f5e4f7507484455855c67e675494f54()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_9b48e1e34c2c41989916df8e1bedc13e()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_3d4952ce9a1b495ea358a04383e311c4()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_41b7f040fe8d40b6b86d6ffec2fb4095()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_bfbaf5f202f946f8b1ee0a80e9884346()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_54ea245a8b87402d9e2465a27b3389b3()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_47f56769f47545ac884fd734fb294c9d()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_cf1d515929bc4f319e12b0004135212d()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_78d963274bc24b148c4d510c905a89fe()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_71c0821667cb4ab887aeda71057746df()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_1000bf79619a44e18b16a389efe48dcf()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_61fbac2200a44989986bcfbf4de3ac48()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_3ca79295a9f84a4e9ad43da0246b9690()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_ffea3f0a0cb646c8a1db4d329385f75a()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_81bddebb33ce414fa2feece4b1ed434d()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_90b41225717a43c0ac529c76b3ee684f()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_2793677c84d44f7ea762fb4a542dc2ec()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_ec068d1ba7084891877e675f4d1e2194()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_082b4db76a484c2ab2daa8e6b3f9a27e()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_85634e3489b0493c8a8adadb08030703()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_d1388817dbb8475c98ce9238b6fc8620()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_30540eea825d4c009601c0967e8062e0()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_b193dd437ca24499a2df57b79c3fed2d()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_7ac175f745c94f53bc79c13993adc299()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_c56447621081425382bd8655c4b7cad2()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_006d6a5befa7488ea579927846881a4a()
        }));
        this.AddMember("getDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_a9c42d049c1f42d9875279ad129ac42d()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_831b6c5042cb4055a2d3d0804a7d9549()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_bb0ad6cf732f46c8b1cc9d5a09503ad6()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_699862640b584b8292248e2832a923d9()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_714a17d5d65b40cd8079d67c3e7f34fc()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_963467a2863e482a9d2f934aa3e54c38(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_e8a89ad0bbc8423fb2c268f092c4fe78()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_580192ab66f94009a4990132f34faeda(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_3a88355554af45bd815a27bd6a59e9db()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_6bcb73c79b1f4ddebf66a7060cdc28a9()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_3a9f34c724b24ef3b1d3bdea8dee044f()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_e3740d1b14214907a0bcb87226b581be(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_2589a3583f244ae0a2e703e096b79034()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_c1f6b1b2643f463cb59a7fe84ed43c84()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_dda8043728624d50aa86400a724b1366()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_71697404dcec40e3b293f27b5f721551()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_3affffdf452f41629b8e9ef84948ad45()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_880838868d1946e3b337639073fd43a2()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_cf8dd7e33fb64e7b8395e3fda1535476()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_5d93bd5d9b0c46929b45771abc623340()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_ee42f81181054b12a35057d3e20f3197()
        }));
        this.AddMember("angleToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("angleToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_9a16431401b24609b2e1bcecf7efccfd()
        }));
        this.AddMember("powerToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("powerToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_e7bfd9154c074e47832970e98faf03fb()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_011b6af11da44c3ea3f2b7bfff4d60af(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_606aad5abfbf4dfabab36fea303ccad3()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_47f510da6f794db6ab704a0096871ed4(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_dc8f003d67884846908917e91bb5382d()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_66222ff900eb4ed6a5fe83ab711ce7df()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_ec0bfc186a494589a403f6b6debecc4d()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_875b0163161c4086af466a1615b12d95()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_3c5fb3761f49415c80b2af52db921b0a()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_e7cdfd8015a2487ea95fd214001000f3()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.MTHD_5ce9e1760b70424e9a4525e6bc30e67f()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_66a5b07c855c4061bb3504c8acda6e5f());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_89e9c9382b0542e2b0f4006f13aa80a3());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_4910ca1e757f4d90bbae839a0cf4cfc8());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_1dbffdc402f64767bb6d5348a65e681b());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_f075d9a4dc2c46cfb2b1a09fe8b23132());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_9e09f9fb37d74e7d82a5d0747c071e5c());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_9a83f02e66c044ddacbd2d33da3f8c62());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_d7101c19a0474c62bfe573f50f5be9ab());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_5ff5f99c0e2d47c9a768b8104d8fb696());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_def27cd166b64bbc83f56f6bdc07b416());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_f0a85be6dfbb4e0788b39a378a212e9c());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_0618dd7be04f467683a110ed6586b73b());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_3dda6f41bb36445993fa4901b6d6a8fb());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_b8d67c1d30634c31b4868d3e8a1d9bfc());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_03aad2e819c94186b70a054a1cf0cce3());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_ecd0828db1de4b079a78ba5e32a12987());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_c836990eb29f4485a81aeb7582ae7bfc());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_db8d8833554844efaf46914985003b73());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_8ec7ce426fa248f8ad48932281b7a02f());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_8e6f58f7f89d46b09dafa6d4d29b7bfa());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_c0fb8ce7b9bd4ab6b91b10c9c1aace42());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_0dac11afc3eb42fc9271327740bc88de());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_6a6ce52c2e4840d991ce239923b19c91());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_7ba303f229cc4c549345631fb8cab117());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_463a697ed51547b59d5dacbb52bfa11a());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_544269ba2c46482fa413011c94057ea2());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_33fa06706cf04bf89c2ae441eaa49366());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_b8438d4e567a445c9efe0041c26be462());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_9765ee56ea2b42dfa8efbebcc4429594());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_e6a09444d3d34fb3a307e70a28cff216());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_92fb313f83934e3683ffad68d14f6e43());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_ce1661ebc4a5479b9cf8c85ce24cbbe5());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_fc39a19282864669a67818614bb87665.PROP_e122bcc9c54a4ac2a39e28f11ff20a2a());
      }

      private sealed class MTHD_91dfe5e239214191b7af9d4a64cae1b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_91dfe5e239214191b7af9d4a64cae1b7()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_5ded6f3cf0404b6bafdee62d23147053 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ded6f3cf0404b6bafdee62d23147053()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_18ec8e9cc66c412d8258a903b6825f35 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_18ec8e9cc66c412d8258a903b6825f35()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_41cc446d7dee40589c51bc52011e4b40 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41cc446d7dee40589c51bc52011e4b40()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_5c9429933eb34a668763a4bd92f90d2d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c9429933eb34a668763a4bd92f90d2d()
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

      private sealed class MTHD_bc25a71ab9d7487785d34530b333d903 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bc25a71ab9d7487785d34530b333d903()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_67fcb689bc814461acfc92ef13d8112a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67fcb689bc814461acfc92ef13d8112a()
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

      private sealed class MTHD_cbdd74e8cf37435dbe7506a72e70d072 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cbdd74e8cf37435dbe7506a72e70d072()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_12ad47a27afc4db7af6af0f59e50c988 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_12ad47a27afc4db7af6af0f59e50c988()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_750b7e8b6ce740cb88e114012f0c803e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_750b7e8b6ce740cb88e114012f0c803e()
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

      private sealed class MTHD_8381ad760111443c86533fd932952372 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8381ad760111443c86533fd932952372()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_ab5bd0cd35054336b150b690a45c6e15 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab5bd0cd35054336b150b690a45c6e15()
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

      private sealed class MTHD_ee6132a9d8074f1eaa73cd8c758c567b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee6132a9d8074f1eaa73cd8c758c567b()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_484ef19191a6436ab7bd654d904e6a41 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_484ef19191a6436ab7bd654d904e6a41()
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

      private sealed class MTHD_9bd18b01b8bd42a7894cd92f269d1fc9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9bd18b01b8bd42a7894cd92f269d1fc9()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_6ffab79d8cd442ccb291bea435f97e15 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ffab79d8cd442ccb291bea435f97e15()
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

      private sealed class MTHD_177cdaf7db7a4099ba16f9cbfc5508d6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_177cdaf7db7a4099ba16f9cbfc5508d6()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_8b49d2d85db94160b2d47b47e22dfe42 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b49d2d85db94160b2d47b47e22dfe42()
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

      private sealed class MTHD_7ecef2e4ef734e8f8ea943ed83c6c34b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ecef2e4ef734e8f8ea943ed83c6c34b()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_06b4f9a176824b48959c60cb4e5e6cf9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_06b4f9a176824b48959c60cb4e5e6cf9()
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

      private sealed class MTHD_49058b36e82e40f4a8566540b2327562 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49058b36e82e40f4a8566540b2327562()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_35d4ac01b2d3472da67439387c0a82b1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35d4ac01b2d3472da67439387c0a82b1()
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

      private sealed class MTHD_0482a6a9156142aead26bbf117ea35cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0482a6a9156142aead26bbf117ea35cd()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_f59e448bd6b0440ca5abd12ed7fad523 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f59e448bd6b0440ca5abd12ed7fad523()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_18f85ad103874655b4c544763f18cea4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_18f85ad103874655b4c544763f18cea4()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_d410863d6c4a4ac9834ba935fbebf462 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d410863d6c4a4ac9834ba935fbebf462()
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

      private sealed class MTHD_18f5c32253404f3a945c62f54a36ec1b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_18f5c32253404f3a945c62f54a36ec1b()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_7600677ab3b443ba86ebb676220e218f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7600677ab3b443ba86ebb676220e218f()
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

      private sealed class MTHD_cd8b08c366704acd91c6f8eb112ec967 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd8b08c366704acd91c6f8eb112ec967()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_b00f4c54350f470187a7937d6d5c1e8a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b00f4c54350f470187a7937d6d5c1e8a()
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

      private sealed class MTHD_24e4d433516c4dd08581d2aebb47c06f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24e4d433516c4dd08581d2aebb47c06f()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_de2654ebf0ad4f08814d8e63e4034b04 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de2654ebf0ad4f08814d8e63e4034b04()
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

      private sealed class MTHD_d410770763984f18a0a09a1359c260c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d410770763984f18a0a09a1359c260c3()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_2f5e4f7507484455855c67e675494f54 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2f5e4f7507484455855c67e675494f54()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_9b48e1e34c2c41989916df8e1bedc13e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b48e1e34c2c41989916df8e1bedc13e()
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

      private sealed class MTHD_3d4952ce9a1b495ea358a04383e311c4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d4952ce9a1b495ea358a04383e311c4()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_41b7f040fe8d40b6b86d6ffec2fb4095 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41b7f040fe8d40b6b86d6ffec2fb4095()
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

      private sealed class MTHD_bfbaf5f202f946f8b1ee0a80e9884346 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bfbaf5f202f946f8b1ee0a80e9884346()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_54ea245a8b87402d9e2465a27b3389b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_54ea245a8b87402d9e2465a27b3389b3()
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

      private sealed class MTHD_47f56769f47545ac884fd734fb294c9d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_47f56769f47545ac884fd734fb294c9d()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_cf1d515929bc4f319e12b0004135212d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf1d515929bc4f319e12b0004135212d()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_78d963274bc24b148c4d510c905a89fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_78d963274bc24b148c4d510c905a89fe()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_71c0821667cb4ab887aeda71057746df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_71c0821667cb4ab887aeda71057746df()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_1000bf79619a44e18b16a389efe48dcf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1000bf79619a44e18b16a389efe48dcf()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_61fbac2200a44989986bcfbf4de3ac48 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_61fbac2200a44989986bcfbf4de3ac48()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_3ca79295a9f84a4e9ad43da0246b9690 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3ca79295a9f84a4e9ad43da0246b9690()
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

      private sealed class MTHD_ffea3f0a0cb646c8a1db4d329385f75a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ffea3f0a0cb646c8a1db4d329385f75a()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_81bddebb33ce414fa2feece4b1ed434d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_81bddebb33ce414fa2feece4b1ed434d()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_90b41225717a43c0ac529c76b3ee684f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_90b41225717a43c0ac529c76b3ee684f()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_2793677c84d44f7ea762fb4a542dc2ec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2793677c84d44f7ea762fb4a542dc2ec()
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

      private sealed class MTHD_ec068d1ba7084891877e675f4d1e2194 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec068d1ba7084891877e675f4d1e2194()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_082b4db76a484c2ab2daa8e6b3f9a27e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_082b4db76a484c2ab2daa8e6b3f9a27e()
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

      private sealed class MTHD_85634e3489b0493c8a8adadb08030703 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85634e3489b0493c8a8adadb08030703()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_d1388817dbb8475c98ce9238b6fc8620 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1388817dbb8475c98ce9238b6fc8620()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_30540eea825d4c009601c0967e8062e0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_30540eea825d4c009601c0967e8062e0()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_b193dd437ca24499a2df57b79c3fed2d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b193dd437ca24499a2df57b79c3fed2d()
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

      private sealed class MTHD_7ac175f745c94f53bc79c13993adc299 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ac175f745c94f53bc79c13993adc299()
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

      private sealed class MTHD_c56447621081425382bd8655c4b7cad2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c56447621081425382bd8655c4b7cad2()
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

      private sealed class MTHD_006d6a5befa7488ea579927846881a4a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_006d6a5befa7488ea579927846881a4a()
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

      private sealed class MTHD_a9c42d049c1f42d9875279ad129ac42d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a9c42d049c1f42d9875279ad129ac42d()
        {
          this.Initialize("getDirection", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getDirection();
        }
      }

      private sealed class MTHD_831b6c5042cb4055a2d3d0804a7d9549 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_831b6c5042cb4055a2d3d0804a7d9549()
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

      private sealed class MTHD_bb0ad6cf732f46c8b1cc9d5a09503ad6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb0ad6cf732f46c8b1cc9d5a09503ad6()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_699862640b584b8292248e2832a923d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_699862640b584b8292248e2832a923d9()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_714a17d5d65b40cd8079d67c3e7f34fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_714a17d5d65b40cd8079d67c3e7f34fc()
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

      private sealed class MTHD_963467a2863e482a9d2f934aa3e54c38 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_963467a2863e482a9d2f934aa3e54c38()
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

      private sealed class MTHD_e8a89ad0bbc8423fb2c268f092c4fe78 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e8a89ad0bbc8423fb2c268f092c4fe78()
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

      private sealed class MTHD_580192ab66f94009a4990132f34faeda : HardwiredMethodMemberDescriptor
      {
        internal MTHD_580192ab66f94009a4990132f34faeda()
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

      private sealed class MTHD_3a88355554af45bd815a27bd6a59e9db : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3a88355554af45bd815a27bd6a59e9db()
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

      private sealed class MTHD_6bcb73c79b1f4ddebf66a7060cdc28a9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6bcb73c79b1f4ddebf66a7060cdc28a9()
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

      private sealed class MTHD_3a9f34c724b24ef3b1d3bdea8dee044f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3a9f34c724b24ef3b1d3bdea8dee044f()
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

      private sealed class MTHD_e3740d1b14214907a0bcb87226b581be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e3740d1b14214907a0bcb87226b581be()
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

      private sealed class MTHD_2589a3583f244ae0a2e703e096b79034 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2589a3583f244ae0a2e703e096b79034()
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

      private sealed class MTHD_c1f6b1b2643f463cb59a7fe84ed43c84 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c1f6b1b2643f463cb59a7fe84ed43c84()
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

      private sealed class MTHD_dda8043728624d50aa86400a724b1366 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dda8043728624d50aa86400a724b1366()
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

      private sealed class MTHD_71697404dcec40e3b293f27b5f721551 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_71697404dcec40e3b293f27b5f721551()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_3affffdf452f41629b8e9ef84948ad45 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3affffdf452f41629b8e9ef84948ad45()
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

      private sealed class MTHD_880838868d1946e3b337639073fd43a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_880838868d1946e3b337639073fd43a2()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_cf8dd7e33fb64e7b8395e3fda1535476 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf8dd7e33fb64e7b8395e3fda1535476()
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

      private sealed class MTHD_5d93bd5d9b0c46929b45771abc623340 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d93bd5d9b0c46929b45771abc623340()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_ee42f81181054b12a35057d3e20f3197 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee42f81181054b12a35057d3e20f3197()
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

      private sealed class MTHD_9a16431401b24609b2e1bcecf7efccfd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9a16431401b24609b2e1bcecf7efccfd()
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

      private sealed class MTHD_e7bfd9154c074e47832970e98faf03fb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7bfd9154c074e47832970e98faf03fb()
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

      private sealed class MTHD_011b6af11da44c3ea3f2b7bfff4d60af : HardwiredMethodMemberDescriptor
      {
        internal MTHD_011b6af11da44c3ea3f2b7bfff4d60af()
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

      private sealed class MTHD_606aad5abfbf4dfabab36fea303ccad3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_606aad5abfbf4dfabab36fea303ccad3()
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

      private sealed class MTHD_47f510da6f794db6ab704a0096871ed4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_47f510da6f794db6ab704a0096871ed4()
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

      private sealed class MTHD_dc8f003d67884846908917e91bb5382d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc8f003d67884846908917e91bb5382d()
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

      private sealed class MTHD_66222ff900eb4ed6a5fe83ab711ce7df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_66222ff900eb4ed6a5fe83ab711ce7df()
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

      private sealed class MTHD_ec0bfc186a494589a403f6b6debecc4d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec0bfc186a494589a403f6b6debecc4d()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_875b0163161c4086af466a1615b12d95 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_875b0163161c4086af466a1615b12d95()
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

      private sealed class MTHD_3c5fb3761f49415c80b2af52db921b0a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3c5fb3761f49415c80b2af52db921b0a()
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

      private sealed class MTHD_e7cdfd8015a2487ea95fd214001000f3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7cdfd8015a2487ea95fd214001000f3()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_5ce9e1760b70424e9a4525e6bc30e67f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ce9e1760b70424e9a4525e6bc30e67f()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_66a5b07c855c4061bb3504c8acda6e5f : HardwiredMemberDescriptor
      {
        internal PROP_66a5b07c855c4061bb3504c8acda6e5f()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_89e9c9382b0542e2b0f4006f13aa80a3 : HardwiredMemberDescriptor
      {
        internal PROP_89e9c9382b0542e2b0f4006f13aa80a3()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_4910ca1e757f4d90bbae839a0cf4cfc8 : HardwiredMemberDescriptor
      {
        internal PROP_4910ca1e757f4d90bbae839a0cf4cfc8()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_1dbffdc402f64767bb6d5348a65e681b : HardwiredMemberDescriptor
      {
        internal PROP_1dbffdc402f64767bb6d5348a65e681b()
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

      private sealed class PROP_f075d9a4dc2c46cfb2b1a09fe8b23132 : HardwiredMemberDescriptor
      {
        internal PROP_f075d9a4dc2c46cfb2b1a09fe8b23132()
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

      private sealed class PROP_9e09f9fb37d74e7d82a5d0747c071e5c : HardwiredMemberDescriptor
      {
        internal PROP_9e09f9fb37d74e7d82a5d0747c071e5c()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_9a83f02e66c044ddacbd2d33da3f8c62 : HardwiredMemberDescriptor
      {
        internal PROP_9a83f02e66c044ddacbd2d33da3f8c62()
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

      private sealed class PROP_d7101c19a0474c62bfe573f50f5be9ab : HardwiredMemberDescriptor
      {
        internal PROP_d7101c19a0474c62bfe573f50f5be9ab()
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

      private sealed class PROP_5ff5f99c0e2d47c9a768b8104d8fb696 : HardwiredMemberDescriptor
      {
        internal PROP_5ff5f99c0e2d47c9a768b8104d8fb696()
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

      private sealed class PROP_def27cd166b64bbc83f56f6bdc07b416 : HardwiredMemberDescriptor
      {
        internal PROP_def27cd166b64bbc83f56f6bdc07b416()
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

      private sealed class PROP_f0a85be6dfbb4e0788b39a378a212e9c : HardwiredMemberDescriptor
      {
        internal PROP_f0a85be6dfbb4e0788b39a378a212e9c()
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

      private sealed class PROP_0618dd7be04f467683a110ed6586b73b : HardwiredMemberDescriptor
      {
        internal PROP_0618dd7be04f467683a110ed6586b73b()
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

      private sealed class PROP_3dda6f41bb36445993fa4901b6d6a8fb : HardwiredMemberDescriptor
      {
        internal PROP_3dda6f41bb36445993fa4901b6d6a8fb()
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

      private sealed class PROP_b8d67c1d30634c31b4868d3e8a1d9bfc : HardwiredMemberDescriptor
      {
        internal PROP_b8d67c1d30634c31b4868d3e8a1d9bfc()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_03aad2e819c94186b70a054a1cf0cce3 : HardwiredMemberDescriptor
      {
        internal PROP_03aad2e819c94186b70a054a1cf0cce3()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_ecd0828db1de4b079a78ba5e32a12987 : HardwiredMemberDescriptor
      {
        internal PROP_ecd0828db1de4b079a78ba5e32a12987()
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

      private sealed class PROP_c836990eb29f4485a81aeb7582ae7bfc : HardwiredMemberDescriptor
      {
        internal PROP_c836990eb29f4485a81aeb7582ae7bfc()
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

      private sealed class PROP_db8d8833554844efaf46914985003b73 : HardwiredMemberDescriptor
      {
        internal PROP_db8d8833554844efaf46914985003b73()
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

      private sealed class PROP_8ec7ce426fa248f8ad48932281b7a02f : HardwiredMemberDescriptor
      {
        internal PROP_8ec7ce426fa248f8ad48932281b7a02f()
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

      private sealed class PROP_8e6f58f7f89d46b09dafa6d4d29b7bfa : HardwiredMemberDescriptor
      {
        internal PROP_8e6f58f7f89d46b09dafa6d4d29b7bfa()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_c0fb8ce7b9bd4ab6b91b10c9c1aace42 : HardwiredMemberDescriptor
      {
        internal PROP_c0fb8ce7b9bd4ab6b91b10c9c1aace42()
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

      private sealed class PROP_0dac11afc3eb42fc9271327740bc88de : HardwiredMemberDescriptor
      {
        internal PROP_0dac11afc3eb42fc9271327740bc88de()
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

      private sealed class PROP_6a6ce52c2e4840d991ce239923b19c91 : HardwiredMemberDescriptor
      {
        internal PROP_6a6ce52c2e4840d991ce239923b19c91()
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

      private sealed class PROP_7ba303f229cc4c549345631fb8cab117 : HardwiredMemberDescriptor
      {
        internal PROP_7ba303f229cc4c549345631fb8cab117()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_463a697ed51547b59d5dacbb52bfa11a : HardwiredMemberDescriptor
      {
        internal PROP_463a697ed51547b59d5dacbb52bfa11a()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_544269ba2c46482fa413011c94057ea2 : HardwiredMemberDescriptor
      {
        internal PROP_544269ba2c46482fa413011c94057ea2()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_33fa06706cf04bf89c2ae441eaa49366 : HardwiredMemberDescriptor
      {
        internal PROP_33fa06706cf04bf89c2ae441eaa49366()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_b8438d4e567a445c9efe0041c26be462 : HardwiredMemberDescriptor
      {
        internal PROP_b8438d4e567a445c9efe0041c26be462()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_9765ee56ea2b42dfa8efbebcc4429594 : HardwiredMemberDescriptor
      {
        internal PROP_9765ee56ea2b42dfa8efbebcc4429594()
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

      private sealed class PROP_e6a09444d3d34fb3a307e70a28cff216 : HardwiredMemberDescriptor
      {
        internal PROP_e6a09444d3d34fb3a307e70a28cff216()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_92fb313f83934e3683ffad68d14f6e43 : HardwiredMemberDescriptor
      {
        internal PROP_92fb313f83934e3683ffad68d14f6e43()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_ce1661ebc4a5479b9cf8c85ce24cbbe5 : HardwiredMemberDescriptor
      {
        internal PROP_ce1661ebc4a5479b9cf8c85ce24cbbe5()
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

      private sealed class PROP_e122bcc9c54a4ac2a39e28f11ff20a2a : HardwiredMemberDescriptor
      {
        internal PROP_e122bcc9c54a4ac2a39e28f11ff20a2a()
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

    private sealed class TYPE_fbe317e2915943c687ee8572ef58675d : HardwiredUserDataDescriptor
    {
      internal TYPE_fbe317e2915943c687ee8572ef58675d()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.MTHD_a61b99a1d6a8469c952c6379d099c822()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.MTHD_4fcf01f93fed4899b7663fdc4d1f1ad5()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.MTHD_6d9560984ad547ceadcbcec05b895ccc()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.MTHD_e5ccb6005fc347e38391d8fef9813894()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.MTHD_3277db70e9274d6ebcc85a51d5dab3ec()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.MTHD_e7d6c6389c084e768ff148ea87f88da3()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.MTHD_73bbc55fa9d34b26bf84d484c581828f()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.MTHD_4e1b1fafe09e428ebc61a18257ff2d76()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.MTHD_5b9345f720b947568e3841756f4e19b2()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.MTHD_6515735efb024cd2b1ffc21f79ba8f08()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.MTHD_2d10169d6c8e4449b7fb703d139d6a26()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.MTHD_e12eb62adddd4a1fb6c3503aa5d072ba()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.MTHD_595e4693b6a345e791e9430ff04a40f7()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.MTHD_1bd494a1b47a4e0787f26e490ccd4ba7()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.MTHD_b83131c5d24e40b08507f93348d03a15()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.MTHD_52199e51fbc74174bc424e8a6f1cae40()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.MTHD_04689ab294d249229f6062703281e321()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.MTHD_6ca9e21368234a149c8ad1ce995d595d()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.MTHD_dfccb7bc21474c45a634e47820141967()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.MTHD_e7517dfdbe9c4122a324f0d23d510790()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.PROP_4ee257ba70ba4cca86dbbdf98c4989f5());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.PROP_f002b7a1368249eaad04dae06fcde250());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.PROP_edf49ad9f104407bad2e5d685437253a());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.PROP_4df3f719450a472a92d6cdf96fece1d6());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.PROP_ce40642c20ca4e8b8f6ce011c0f5b072());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.PROP_4b39a1545fd44bf2852a54ec9aaafcc9());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.PROP_9efb6289613245859b2c913f89d79929());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_fbe317e2915943c687ee8572ef58675d.PROP_e3a4528b86fa4cb3b7cb41e91506fa41());
      }

      private sealed class MTHD_a61b99a1d6a8469c952c6379d099c822 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a61b99a1d6a8469c952c6379d099c822()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_4fcf01f93fed4899b7663fdc4d1f1ad5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4fcf01f93fed4899b7663fdc4d1f1ad5()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_6d9560984ad547ceadcbcec05b895ccc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d9560984ad547ceadcbcec05b895ccc()
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

      private sealed class MTHD_e5ccb6005fc347e38391d8fef9813894 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e5ccb6005fc347e38391d8fef9813894()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_3277db70e9274d6ebcc85a51d5dab3ec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3277db70e9274d6ebcc85a51d5dab3ec()
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

      private sealed class MTHD_e7d6c6389c084e768ff148ea87f88da3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7d6c6389c084e768ff148ea87f88da3()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_73bbc55fa9d34b26bf84d484c581828f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_73bbc55fa9d34b26bf84d484c581828f()
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

      private sealed class MTHD_4e1b1fafe09e428ebc61a18257ff2d76 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e1b1fafe09e428ebc61a18257ff2d76()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_5b9345f720b947568e3841756f4e19b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b9345f720b947568e3841756f4e19b2()
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

      private sealed class MTHD_6515735efb024cd2b1ffc21f79ba8f08 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6515735efb024cd2b1ffc21f79ba8f08()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_2d10169d6c8e4449b7fb703d139d6a26 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d10169d6c8e4449b7fb703d139d6a26()
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

      private sealed class MTHD_e12eb62adddd4a1fb6c3503aa5d072ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e12eb62adddd4a1fb6c3503aa5d072ba()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_595e4693b6a345e791e9430ff04a40f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_595e4693b6a345e791e9430ff04a40f7()
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

      private sealed class MTHD_1bd494a1b47a4e0787f26e490ccd4ba7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1bd494a1b47a4e0787f26e490ccd4ba7()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_b83131c5d24e40b08507f93348d03a15 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b83131c5d24e40b08507f93348d03a15()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_52199e51fbc74174bc424e8a6f1cae40 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52199e51fbc74174bc424e8a6f1cae40()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_04689ab294d249229f6062703281e321 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_04689ab294d249229f6062703281e321()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_6ca9e21368234a149c8ad1ce995d595d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ca9e21368234a149c8ad1ce995d595d()
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

      private sealed class MTHD_dfccb7bc21474c45a634e47820141967 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dfccb7bc21474c45a634e47820141967()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_e7517dfdbe9c4122a324f0d23d510790 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7517dfdbe9c4122a324f0d23d510790()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_4ee257ba70ba4cca86dbbdf98c4989f5 : HardwiredMemberDescriptor
      {
        internal PROP_4ee257ba70ba4cca86dbbdf98c4989f5()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_f002b7a1368249eaad04dae06fcde250 : HardwiredMemberDescriptor
      {
        internal PROP_f002b7a1368249eaad04dae06fcde250()
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

      private sealed class PROP_edf49ad9f104407bad2e5d685437253a : HardwiredMemberDescriptor
      {
        internal PROP_edf49ad9f104407bad2e5d685437253a()
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

      private sealed class PROP_4df3f719450a472a92d6cdf96fece1d6 : HardwiredMemberDescriptor
      {
        internal PROP_4df3f719450a472a92d6cdf96fece1d6()
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

      private sealed class PROP_ce40642c20ca4e8b8f6ce011c0f5b072 : HardwiredMemberDescriptor
      {
        internal PROP_ce40642c20ca4e8b8f6ce011c0f5b072()
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

      private sealed class PROP_4b39a1545fd44bf2852a54ec9aaafcc9 : HardwiredMemberDescriptor
      {
        internal PROP_4b39a1545fd44bf2852a54ec9aaafcc9()
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

      private sealed class PROP_9efb6289613245859b2c913f89d79929 : HardwiredMemberDescriptor
      {
        internal PROP_9efb6289613245859b2c913f89d79929()
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

      private sealed class PROP_e3a4528b86fa4cb3b7cb41e91506fa41 : HardwiredMemberDescriptor
      {
        internal PROP_e3a4528b86fa4cb3b7cb41e91506fa41()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_4bd8e641a06e4375b0bcd5400c52e5d8 : HardwiredUserDataDescriptor
    {
      internal TYPE_4bd8e641a06e4375b0bcd5400c52e5d8()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.MTHD_80f701fd41634a79b35cbaa40d2abd4a()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.MTHD_7b3444102bdb4f77885218c2864b40d3()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.MTHD_a19a69910c414492962eb1aec2df377a()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.MTHD_ca8694997d6343478de78d134aebdc4a()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.MTHD_e528c624b74c48d888f7bfd8b85cfe03()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.MTHD_d3a0276b2c274032af57f8ec338762fc()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.MTHD_232eb93101594b6c92c9a75163f66371()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.MTHD_1d989001f1c94f23ae7870a18657d428()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.MTHD_5e433953501e465a9a3d88dfb83a6ced()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.MTHD_eb07c9a217bf44d3a8cdcb7afaf4cc01()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.MTHD_56cf6cf2b84d4a7aa0c6e0a9ef5a57fe()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.MTHD_0aa6a9c43ca147d798e9976495153fc5()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.MTHD_b71bed1c060e484ca5cb1510dfdc89f8()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.MTHD_66ef06bab8374208b0d7d9113ccdb655()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.MTHD_04f58e5d0df944f2b40e005c5e97f25a()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.MTHD_4ec4586edc6341de8511538f2fa864d5()
        }));
        this.AddMember("setIcon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setIcon", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.MTHD_a1281f4616f8486eb60700ae8f125c0b()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.MTHD_bb6ac7ea392244d0860f4df24557fca3()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.MTHD_50365409dc624b68bd083fea8057e240()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.MTHD_293fdf812bca4882a1cbb0b4a7bb2bac()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.MTHD_7f37ede822104fc1af53bab587bb2f3b()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.MTHD_8ae399a43aa744d8900b98c4d37d6814()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.PROP_1cac4dec92bf452fb20c7987766906ab());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.PROP_34eb92b026a04600bed40edba157d042());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.PROP_b0b4e4e424b5437b8ecc308a7178dce3());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.PROP_4bdff16718474c74bd60d7f7f940e970());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.PROP_9901a74d1cf448e9bf4cd2ad3230e4a6());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.PROP_dc908255caeb4911b06be4b2782128ea());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.PROP_30db8c79a2ea4c25b3889f6dafa1a8cc());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.PROP_6a861434b33c4879a32fca09d5042057());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_4bd8e641a06e4375b0bcd5400c52e5d8.PROP_7b02b5fef15d44da96004397ab7e9f60());
      }

      private sealed class MTHD_80f701fd41634a79b35cbaa40d2abd4a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_80f701fd41634a79b35cbaa40d2abd4a()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_7b3444102bdb4f77885218c2864b40d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7b3444102bdb4f77885218c2864b40d3()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_a19a69910c414492962eb1aec2df377a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a19a69910c414492962eb1aec2df377a()
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

      private sealed class MTHD_ca8694997d6343478de78d134aebdc4a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ca8694997d6343478de78d134aebdc4a()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_e528c624b74c48d888f7bfd8b85cfe03 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e528c624b74c48d888f7bfd8b85cfe03()
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

      private sealed class MTHD_d3a0276b2c274032af57f8ec338762fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d3a0276b2c274032af57f8ec338762fc()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_232eb93101594b6c92c9a75163f66371 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_232eb93101594b6c92c9a75163f66371()
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

      private sealed class MTHD_1d989001f1c94f23ae7870a18657d428 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d989001f1c94f23ae7870a18657d428()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_5e433953501e465a9a3d88dfb83a6ced : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e433953501e465a9a3d88dfb83a6ced()
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

      private sealed class MTHD_eb07c9a217bf44d3a8cdcb7afaf4cc01 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb07c9a217bf44d3a8cdcb7afaf4cc01()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_56cf6cf2b84d4a7aa0c6e0a9ef5a57fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_56cf6cf2b84d4a7aa0c6e0a9ef5a57fe()
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

      private sealed class MTHD_0aa6a9c43ca147d798e9976495153fc5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0aa6a9c43ca147d798e9976495153fc5()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_b71bed1c060e484ca5cb1510dfdc89f8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b71bed1c060e484ca5cb1510dfdc89f8()
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

      private sealed class MTHD_66ef06bab8374208b0d7d9113ccdb655 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_66ef06bab8374208b0d7d9113ccdb655()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color2;
        }
      }

      private sealed class MTHD_04f58e5d0df944f2b40e005c5e97f25a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_04f58e5d0df944f2b40e005c5e97f25a()
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

      private sealed class MTHD_4ec4586edc6341de8511538f2fa864d5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ec4586edc6341de8511538f2fa864d5()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_a1281f4616f8486eb60700ae8f125c0b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1281f4616f8486eb60700ae8f125c0b()
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

      private sealed class MTHD_bb6ac7ea392244d0860f4df24557fca3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb6ac7ea392244d0860f4df24557fca3()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_50365409dc624b68bd083fea8057e240 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_50365409dc624b68bd083fea8057e240()
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

      private sealed class MTHD_293fdf812bca4882a1cbb0b4a7bb2bac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_293fdf812bca4882a1cbb0b4a7bb2bac()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_7f37ede822104fc1af53bab587bb2f3b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f37ede822104fc1af53bab587bb2f3b()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_8ae399a43aa744d8900b98c4d37d6814 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ae399a43aa744d8900b98c4d37d6814()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_1cac4dec92bf452fb20c7987766906ab : HardwiredMemberDescriptor
      {
        internal PROP_1cac4dec92bf452fb20c7987766906ab()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_34eb92b026a04600bed40edba157d042 : HardwiredMemberDescriptor
      {
        internal PROP_34eb92b026a04600bed40edba157d042()
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

      private sealed class PROP_b0b4e4e424b5437b8ecc308a7178dce3 : HardwiredMemberDescriptor
      {
        internal PROP_b0b4e4e424b5437b8ecc308a7178dce3()
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

      private sealed class PROP_4bdff16718474c74bd60d7f7f940e970 : HardwiredMemberDescriptor
      {
        internal PROP_4bdff16718474c74bd60d7f7f940e970()
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

      private sealed class PROP_9901a74d1cf448e9bf4cd2ad3230e4a6 : HardwiredMemberDescriptor
      {
        internal PROP_9901a74d1cf448e9bf4cd2ad3230e4a6()
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

      private sealed class PROP_dc908255caeb4911b06be4b2782128ea : HardwiredMemberDescriptor
      {
        internal PROP_dc908255caeb4911b06be4b2782128ea()
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

      private sealed class PROP_30db8c79a2ea4c25b3889f6dafa1a8cc : HardwiredMemberDescriptor
      {
        internal PROP_30db8c79a2ea4c25b3889f6dafa1a8cc()
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

      private sealed class PROP_6a861434b33c4879a32fca09d5042057 : HardwiredMemberDescriptor
      {
        internal PROP_6a861434b33c4879a32fca09d5042057()
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

      private sealed class PROP_7b02b5fef15d44da96004397ab7e9f60 : HardwiredMemberDescriptor
      {
        internal PROP_7b02b5fef15d44da96004397ab7e9f60()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_043cb18370fe42ff974c5d8bd4fc7b8b : HardwiredUserDataDescriptor
    {
      internal TYPE_043cb18370fe42ff974c5d8bd4fc7b8b()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_13e267dff6d340ab9828a34d9041dee9()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_a5e618d825d647f1ac3753f0fb9e5c31()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_b5fc36ef5270424da3d5b46c7ca9efa1()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_b4f456853ddb40de99723ab88efd1f65()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_30e66c5e013441628186155503cd72d0()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_dfde548c9a6f4e50901b4765cbb45b5e()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_e082030c398d4b1393aae13b0f03cdb0()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_264f69cb16fe4bcb96d65bf47edd837a()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_35dba0eeaaf446a4a1407ec2d6d747a2()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_38efb9bcda594646b1bb77cd734dcd17()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_21a2a23399da4450b892989b48e79b3b()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_e03f14cc3ad642f18e704b37f6f96fb1()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_cf99c21876fb4383bb42757af98f9f56()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_672ec6068e544abdb053b09a661a0341()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_3d9348bf34044bd0a9d6b92a38f2040b()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_a1228e30bede49ce977885addedcda6a()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_bc88699f91104e60b5cd5b308054849b()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_c84c0e1ea8994bfb9e554b68f4d5cd61()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_6c1e10296bb3464a992fad7af95f195a()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_ac91782f4fa04b21a2704c574e092bb9()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_c27aadf379a14c36b2b1c90ef41ec508()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_5237e29ca4b845fda84f5490a549d7b4()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_69489911cd2c4b8d907adffb02ad65c2()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_478583bb4e7c408eb22bf79636ff5a3c()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_8322f810d9b54c3aac967555e3fe3b5a()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_8133093349be4651a7c348c8c8647ea6()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_c72a055c69b249048f8694550ede9e4f()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.MTHD_6bda45c50c804c188f5a2787403e420a()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.PROP_f54007fe01844e82b1e472d5e2d8c225());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.PROP_faebcecbfc4d44479afea66fa398cb32());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.PROP_abf95fa4219148d6b6336759316b6983());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.PROP_a611c2db8013456caa15df1663ab379b());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.PROP_41e7443fb39840e3b9d5be403aec5740());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.PROP_2a426852717548db83174db06559b5bb());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.PROP_b1ee4fc3b6594753a5a333229925f19e());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.PROP_026562b61de2477d821906ec27d85911());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.PROP_df640c6e337d418ebcff6256c9b0037c());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.PROP_ef44a8b4eed644dabca4b25583613b35());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.PROP_3bf397dbf5b74dc0bb4873d01fd4b284());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.PROP_069e67680045466faa0ce8440332cae1());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.PROP_1fc85baf97844c48bc8f89fb64a8397c());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.PROP_442a15a6373248b5931defdbbf6917e6());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.PROP_7997bb3fdf0249e3a11c415d42915737());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.PROP_555e307f97c7414c95faf8e0d32c1a69());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_043cb18370fe42ff974c5d8bd4fc7b8b.PROP_8feec0bd344c4308a19e83a33d6da716());
      }

      private sealed class MTHD_13e267dff6d340ab9828a34d9041dee9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_13e267dff6d340ab9828a34d9041dee9()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_a5e618d825d647f1ac3753f0fb9e5c31 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a5e618d825d647f1ac3753f0fb9e5c31()
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

      private sealed class MTHD_b5fc36ef5270424da3d5b46c7ca9efa1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b5fc36ef5270424da3d5b46c7ca9efa1()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_b4f456853ddb40de99723ab88efd1f65 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b4f456853ddb40de99723ab88efd1f65()
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

      private sealed class MTHD_30e66c5e013441628186155503cd72d0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_30e66c5e013441628186155503cd72d0()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_dfde548c9a6f4e50901b4765cbb45b5e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dfde548c9a6f4e50901b4765cbb45b5e()
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

      private sealed class MTHD_e082030c398d4b1393aae13b0f03cdb0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e082030c398d4b1393aae13b0f03cdb0()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_264f69cb16fe4bcb96d65bf47edd837a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_264f69cb16fe4bcb96d65bf47edd837a()
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

      private sealed class MTHD_35dba0eeaaf446a4a1407ec2d6d747a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35dba0eeaaf446a4a1407ec2d6d747a2()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_38efb9bcda594646b1bb77cd734dcd17 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_38efb9bcda594646b1bb77cd734dcd17()
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

      private sealed class MTHD_21a2a23399da4450b892989b48e79b3b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_21a2a23399da4450b892989b48e79b3b()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_e03f14cc3ad642f18e704b37f6f96fb1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e03f14cc3ad642f18e704b37f6f96fb1()
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

      private sealed class MTHD_cf99c21876fb4383bb42757af98f9f56 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf99c21876fb4383bb42757af98f9f56()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_672ec6068e544abdb053b09a661a0341 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_672ec6068e544abdb053b09a661a0341()
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

      private sealed class MTHD_3d9348bf34044bd0a9d6b92a38f2040b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d9348bf34044bd0a9d6b92a38f2040b()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_a1228e30bede49ce977885addedcda6a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1228e30bede49ce977885addedcda6a()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_bc88699f91104e60b5cd5b308054849b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bc88699f91104e60b5cd5b308054849b()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_c84c0e1ea8994bfb9e554b68f4d5cd61 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c84c0e1ea8994bfb9e554b68f4d5cd61()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_6c1e10296bb3464a992fad7af95f195a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6c1e10296bb3464a992fad7af95f195a()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_ac91782f4fa04b21a2704c574e092bb9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac91782f4fa04b21a2704c574e092bb9()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_c27aadf379a14c36b2b1c90ef41ec508 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c27aadf379a14c36b2b1c90ef41ec508()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_5237e29ca4b845fda84f5490a549d7b4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5237e29ca4b845fda84f5490a549d7b4()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_69489911cd2c4b8d907adffb02ad65c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69489911cd2c4b8d907adffb02ad65c2()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_478583bb4e7c408eb22bf79636ff5a3c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_478583bb4e7c408eb22bf79636ff5a3c()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_8322f810d9b54c3aac967555e3fe3b5a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8322f810d9b54c3aac967555e3fe3b5a()
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

      private sealed class MTHD_8133093349be4651a7c348c8c8647ea6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8133093349be4651a7c348c8c8647ea6()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_c72a055c69b249048f8694550ede9e4f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c72a055c69b249048f8694550ede9e4f()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_6bda45c50c804c188f5a2787403e420a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6bda45c50c804c188f5a2787403e420a()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_f54007fe01844e82b1e472d5e2d8c225 : HardwiredMemberDescriptor
      {
        internal PROP_f54007fe01844e82b1e472d5e2d8c225()
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

      private sealed class PROP_faebcecbfc4d44479afea66fa398cb32 : HardwiredMemberDescriptor
      {
        internal PROP_faebcecbfc4d44479afea66fa398cb32()
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

      private sealed class PROP_abf95fa4219148d6b6336759316b6983 : HardwiredMemberDescriptor
      {
        internal PROP_abf95fa4219148d6b6336759316b6983()
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

      private sealed class PROP_a611c2db8013456caa15df1663ab379b : HardwiredMemberDescriptor
      {
        internal PROP_a611c2db8013456caa15df1663ab379b()
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

      private sealed class PROP_41e7443fb39840e3b9d5be403aec5740 : HardwiredMemberDescriptor
      {
        internal PROP_41e7443fb39840e3b9d5be403aec5740()
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

      private sealed class PROP_2a426852717548db83174db06559b5bb : HardwiredMemberDescriptor
      {
        internal PROP_2a426852717548db83174db06559b5bb()
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

      private sealed class PROP_b1ee4fc3b6594753a5a333229925f19e : HardwiredMemberDescriptor
      {
        internal PROP_b1ee4fc3b6594753a5a333229925f19e()
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

      private sealed class PROP_026562b61de2477d821906ec27d85911 : HardwiredMemberDescriptor
      {
        internal PROP_026562b61de2477d821906ec27d85911()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_df640c6e337d418ebcff6256c9b0037c : HardwiredMemberDescriptor
      {
        internal PROP_df640c6e337d418ebcff6256c9b0037c()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_ef44a8b4eed644dabca4b25583613b35 : HardwiredMemberDescriptor
      {
        internal PROP_ef44a8b4eed644dabca4b25583613b35()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_3bf397dbf5b74dc0bb4873d01fd4b284 : HardwiredMemberDescriptor
      {
        internal PROP_3bf397dbf5b74dc0bb4873d01fd4b284()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_069e67680045466faa0ce8440332cae1 : HardwiredMemberDescriptor
      {
        internal PROP_069e67680045466faa0ce8440332cae1()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_1fc85baf97844c48bc8f89fb64a8397c : HardwiredMemberDescriptor
      {
        internal PROP_1fc85baf97844c48bc8f89fb64a8397c()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_442a15a6373248b5931defdbbf6917e6 : HardwiredMemberDescriptor
      {
        internal PROP_442a15a6373248b5931defdbbf6917e6()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_7997bb3fdf0249e3a11c415d42915737 : HardwiredMemberDescriptor
      {
        internal PROP_7997bb3fdf0249e3a11c415d42915737()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_555e307f97c7414c95faf8e0d32c1a69 : HardwiredMemberDescriptor
      {
        internal PROP_555e307f97c7414c95faf8e0d32c1a69()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_8feec0bd344c4308a19e83a33d6da716 : HardwiredMemberDescriptor
      {
        internal PROP_8feec0bd344c4308a19e83a33d6da716()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_75c42e8f6b0242298fe56df034304e53 : HardwiredUserDataDescriptor
    {
      internal TYPE_75c42e8f6b0242298fe56df034304e53()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_75c42e8f6b0242298fe56df034304e53.MTHD_f729401bba684730b5804371c80a34e1()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_75c42e8f6b0242298fe56df034304e53.MTHD_e359e1495ad64721913a4d4e76a8f8f6()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_75c42e8f6b0242298fe56df034304e53.MTHD_839ed8aa2cd54308a8574945ba0a24b3()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_75c42e8f6b0242298fe56df034304e53.MTHD_9a6c49098006471fad8e661ab4a4789e()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_75c42e8f6b0242298fe56df034304e53.MTHD_58d7e69586474f28b1d1daa3724f4f01()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_75c42e8f6b0242298fe56df034304e53.MTHD_a04aa59ea67643dda56c991aaa25d067()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_75c42e8f6b0242298fe56df034304e53.MTHD_628b2a2699d94428b76ebb7d86f73101()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_75c42e8f6b0242298fe56df034304e53.MTHD_583abd0488014bff8da3e51422c16ee0()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_75c42e8f6b0242298fe56df034304e53.MTHD_e49669cf1ca24bcdadfeb36944db8e22()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_75c42e8f6b0242298fe56df034304e53.MTHD_a29c0a37b52a488b83c4566da65f1d75()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_75c42e8f6b0242298fe56df034304e53.MTHD_b9b8c55aba0147b996d9bc8d1aba6fff()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_75c42e8f6b0242298fe56df034304e53.MTHD_ea4995e0338a4542b99c376378aadace()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_75c42e8f6b0242298fe56df034304e53.MTHD_db22497a6205408e8bfce8a4361c3582()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_75c42e8f6b0242298fe56df034304e53.MTHD_7979f8f70a8d4c30a5f7c570c64bcb31()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_75c42e8f6b0242298fe56df034304e53.MTHD_17b7771511704c29b8608fb5d182ab29()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_75c42e8f6b0242298fe56df034304e53.MTHD_166436831b994eb49b63b5820f141313()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_75c42e8f6b0242298fe56df034304e53.MTHD_f7fcca95b9e14d64ac753bd81e74956b()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_75c42e8f6b0242298fe56df034304e53.PROP_7238ff4626d44a309bad347d6dc765b2());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_75c42e8f6b0242298fe56df034304e53.PROP_c8e20713406a4431a6f5ed3b8bde7cf2());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_75c42e8f6b0242298fe56df034304e53.PROP_069b864de49945e4901290b461810b75());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_75c42e8f6b0242298fe56df034304e53.PROP_a5cb5f0b95a54fd6a913b9db488d0063());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_75c42e8f6b0242298fe56df034304e53.PROP_abc1a5ea32b64dccbdd743874f596537());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_75c42e8f6b0242298fe56df034304e53.PROP_1f94b40e678048f8b5d6b79931fc24b5());
      }

      private sealed class MTHD_f729401bba684730b5804371c80a34e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f729401bba684730b5804371c80a34e1()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_e359e1495ad64721913a4d4e76a8f8f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e359e1495ad64721913a4d4e76a8f8f6()
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

      private sealed class MTHD_839ed8aa2cd54308a8574945ba0a24b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_839ed8aa2cd54308a8574945ba0a24b3()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_9a6c49098006471fad8e661ab4a4789e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9a6c49098006471fad8e661ab4a4789e()
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

      private sealed class MTHD_58d7e69586474f28b1d1daa3724f4f01 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_58d7e69586474f28b1d1daa3724f4f01()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_a04aa59ea67643dda56c991aaa25d067 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a04aa59ea67643dda56c991aaa25d067()
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

      private sealed class MTHD_628b2a2699d94428b76ebb7d86f73101 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_628b2a2699d94428b76ebb7d86f73101()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_583abd0488014bff8da3e51422c16ee0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_583abd0488014bff8da3e51422c16ee0()
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

      private sealed class MTHD_e49669cf1ca24bcdadfeb36944db8e22 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e49669cf1ca24bcdadfeb36944db8e22()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_a29c0a37b52a488b83c4566da65f1d75 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a29c0a37b52a488b83c4566da65f1d75()
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

      private sealed class MTHD_b9b8c55aba0147b996d9bc8d1aba6fff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b9b8c55aba0147b996d9bc8d1aba6fff()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_ea4995e0338a4542b99c376378aadace : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea4995e0338a4542b99c376378aadace()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_db22497a6205408e8bfce8a4361c3582 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_db22497a6205408e8bfce8a4361c3582()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_7979f8f70a8d4c30a5f7c570c64bcb31 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7979f8f70a8d4c30a5f7c570c64bcb31()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_17b7771511704c29b8608fb5d182ab29 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_17b7771511704c29b8608fb5d182ab29()
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

      private sealed class MTHD_166436831b994eb49b63b5820f141313 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_166436831b994eb49b63b5820f141313()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_f7fcca95b9e14d64ac753bd81e74956b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7fcca95b9e14d64ac753bd81e74956b()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_7238ff4626d44a309bad347d6dc765b2 : HardwiredMemberDescriptor
      {
        internal PROP_7238ff4626d44a309bad347d6dc765b2()
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

      private sealed class PROP_c8e20713406a4431a6f5ed3b8bde7cf2 : HardwiredMemberDescriptor
      {
        internal PROP_c8e20713406a4431a6f5ed3b8bde7cf2()
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

      private sealed class PROP_069b864de49945e4901290b461810b75 : HardwiredMemberDescriptor
      {
        internal PROP_069b864de49945e4901290b461810b75()
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

      private sealed class PROP_a5cb5f0b95a54fd6a913b9db488d0063 : HardwiredMemberDescriptor
      {
        internal PROP_a5cb5f0b95a54fd6a913b9db488d0063()
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

      private sealed class PROP_abc1a5ea32b64dccbdd743874f596537 : HardwiredMemberDescriptor
      {
        internal PROP_abc1a5ea32b64dccbdd743874f596537()
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

      private sealed class PROP_1f94b40e678048f8b5d6b79931fc24b5 : HardwiredMemberDescriptor
      {
        internal PROP_1f94b40e678048f8b5d6b79931fc24b5()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_44cff6b103104c1abd9bbcfe3e562bf5 : HardwiredUserDataDescriptor
    {
      internal TYPE_44cff6b103104c1abd9bbcfe3e562bf5()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44cff6b103104c1abd9bbcfe3e562bf5.MTHD_cbe6bf37b51d45909854054ac449e9fd(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44cff6b103104c1abd9bbcfe3e562bf5.MTHD_3248be7ff2e14bc5946be9e2ea275c07()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44cff6b103104c1abd9bbcfe3e562bf5.MTHD_c66a3a2180334c60b7d50fce2d9d1c65(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44cff6b103104c1abd9bbcfe3e562bf5.MTHD_9a4bf791327749889925a1c60dfe15d2()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44cff6b103104c1abd9bbcfe3e562bf5.MTHD_3e0e3fe1d73e40d194f47e1a042c5602()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44cff6b103104c1abd9bbcfe3e562bf5.MTHD_908edb4e06ab4733a618ef39483408ba()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44cff6b103104c1abd9bbcfe3e562bf5.MTHD_ef3cbf3919b345babf5201f85a419caf()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44cff6b103104c1abd9bbcfe3e562bf5.MTHD_485dd7d90c5546f5b13bc400becfb51f()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44cff6b103104c1abd9bbcfe3e562bf5.MTHD_b409311b94b642d69611a0040b081368()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44cff6b103104c1abd9bbcfe3e562bf5.MTHD_41b1ba835c794cd6981b87cd3ad029a4()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44cff6b103104c1abd9bbcfe3e562bf5.MTHD_061741cc1577470cb5b9b0684ebcc677()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44cff6b103104c1abd9bbcfe3e562bf5.MTHD_3ac5d408fb6643b5833dfe4c699a8159(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44cff6b103104c1abd9bbcfe3e562bf5.MTHD_e1d12311c5344c5cad049cbe170d5c02()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44cff6b103104c1abd9bbcfe3e562bf5.MTHD_134ebceb9d4b46bb82b9e20aac2b554b(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44cff6b103104c1abd9bbcfe3e562bf5.MTHD_b2b4bcd7ca1e4cec978332f88763cd03()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44cff6b103104c1abd9bbcfe3e562bf5.MTHD_a2a6ffaf41ac45bbbad868077825d611(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44cff6b103104c1abd9bbcfe3e562bf5.MTHD_25f8b67150f24b87b5f7cf0b691fef8f()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44cff6b103104c1abd9bbcfe3e562bf5.MTHD_97021a9373c54789a96fb2244795b48c(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44cff6b103104c1abd9bbcfe3e562bf5.MTHD_78508fed096d45848c909d400346eb21()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44cff6b103104c1abd9bbcfe3e562bf5.MTHD_621da68ad7de48d9910cfcb688c1859f(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44cff6b103104c1abd9bbcfe3e562bf5.MTHD_f35ef148eecb4fbfa3191e087436ed3a()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44cff6b103104c1abd9bbcfe3e562bf5.MTHD_775ec6d763494eccac1bf3f828fcab64()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_44cff6b103104c1abd9bbcfe3e562bf5.MTHD_2de6ce0e62cf4e6fb4d74367ac028915()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_44cff6b103104c1abd9bbcfe3e562bf5.FLDV_19bd429d143f44b38ff7a2ad13aaaaa0());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_44cff6b103104c1abd9bbcfe3e562bf5.FLDV_d044b77e4cf3446da0dee579e5e6ba4a());
      }

      private sealed class MTHD_cbe6bf37b51d45909854054ac449e9fd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cbe6bf37b51d45909854054ac449e9fd()
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

      private sealed class MTHD_3248be7ff2e14bc5946be9e2ea275c07 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3248be7ff2e14bc5946be9e2ea275c07()
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

      private sealed class MTHD_c66a3a2180334c60b7d50fce2d9d1c65 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c66a3a2180334c60b7d50fce2d9d1c65()
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

      private sealed class MTHD_9a4bf791327749889925a1c60dfe15d2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9a4bf791327749889925a1c60dfe15d2()
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

      private sealed class MTHD_3e0e3fe1d73e40d194f47e1a042c5602 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3e0e3fe1d73e40d194f47e1a042c5602()
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

      private sealed class MTHD_908edb4e06ab4733a618ef39483408ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_908edb4e06ab4733a618ef39483408ba()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_ef3cbf3919b345babf5201f85a419caf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef3cbf3919b345babf5201f85a419caf()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_485dd7d90c5546f5b13bc400becfb51f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_485dd7d90c5546f5b13bc400becfb51f()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b409311b94b642d69611a0040b081368 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b409311b94b642d69611a0040b081368()
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

      private sealed class MTHD_41b1ba835c794cd6981b87cd3ad029a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41b1ba835c794cd6981b87cd3ad029a4()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_061741cc1577470cb5b9b0684ebcc677 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_061741cc1577470cb5b9b0684ebcc677()
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

      private sealed class MTHD_3ac5d408fb6643b5833dfe4c699a8159 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3ac5d408fb6643b5833dfe4c699a8159()
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

      private sealed class MTHD_e1d12311c5344c5cad049cbe170d5c02 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e1d12311c5344c5cad049cbe170d5c02()
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

      private sealed class MTHD_134ebceb9d4b46bb82b9e20aac2b554b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_134ebceb9d4b46bb82b9e20aac2b554b()
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

      private sealed class MTHD_b2b4bcd7ca1e4cec978332f88763cd03 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b2b4bcd7ca1e4cec978332f88763cd03()
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

      private sealed class MTHD_a2a6ffaf41ac45bbbad868077825d611 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2a6ffaf41ac45bbbad868077825d611()
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

      private sealed class MTHD_25f8b67150f24b87b5f7cf0b691fef8f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_25f8b67150f24b87b5f7cf0b691fef8f()
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

      private sealed class MTHD_97021a9373c54789a96fb2244795b48c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97021a9373c54789a96fb2244795b48c()
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

      private sealed class MTHD_78508fed096d45848c909d400346eb21 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_78508fed096d45848c909d400346eb21()
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

      private sealed class MTHD_621da68ad7de48d9910cfcb688c1859f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_621da68ad7de48d9910cfcb688c1859f()
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

      private sealed class MTHD_f35ef148eecb4fbfa3191e087436ed3a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f35ef148eecb4fbfa3191e087436ed3a()
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

      private sealed class MTHD_775ec6d763494eccac1bf3f828fcab64 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_775ec6d763494eccac1bf3f828fcab64()
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

      private sealed class MTHD_2de6ce0e62cf4e6fb4d74367ac028915 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2de6ce0e62cf4e6fb4d74367ac028915()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_19bd429d143f44b38ff7a2ad13aaaaa0 : HardwiredMemberDescriptor
      {
        internal FLDV_19bd429d143f44b38ff7a2ad13aaaaa0()
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

      private sealed class FLDV_d044b77e4cf3446da0dee579e5e6ba4a : HardwiredMemberDescriptor
      {
        internal FLDV_d044b77e4cf3446da0dee579e5e6ba4a()
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

    private sealed class TYPE_6829ea0050334a42b3e486d24556a884 : HardwiredUserDataDescriptor
    {
      internal TYPE_6829ea0050334a42b3e486d24556a884()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6829ea0050334a42b3e486d24556a884.MTHD_d6ea748d5a3747aab0b08e51b00702a1()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6829ea0050334a42b3e486d24556a884.MTHD_5d22fcdc70bd43a29f1231ca62ba6942()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6829ea0050334a42b3e486d24556a884.MTHD_24d4ca9223814e37a75958113b996cb8()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6829ea0050334a42b3e486d24556a884.MTHD_bf729f40edf34b0ba9b9db4762b49191()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6829ea0050334a42b3e486d24556a884.MTHD_6ab04a5a045f424db186d4e71e23fff6()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_6829ea0050334a42b3e486d24556a884.MTHD_70236297638245368311e17856d44b86()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_6829ea0050334a42b3e486d24556a884.FLDV_b02ee8c3efb149259ef52206f748eea9());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_6829ea0050334a42b3e486d24556a884.FLDV_28539e9d694547cba6ccf33095c6a53f());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_6829ea0050334a42b3e486d24556a884.FLDV_fc816e10e734405a85406c2c9710e827());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_6829ea0050334a42b3e486d24556a884.FLDV_2622aa36e6ea4021958e1be6ba48abf2());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_6829ea0050334a42b3e486d24556a884.FLDV_be40b7b3d46342e08d534f4fce996615());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_6829ea0050334a42b3e486d24556a884.FLDV_ed16795ad5d348559f49e08c095d3db0());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_6829ea0050334a42b3e486d24556a884.FLDV_b6d6a54815394718b9cc274e671eb0fe());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_6829ea0050334a42b3e486d24556a884.FLDV_554f13553dfe4900bd42162fcde4faec());
        this.AddMember("prestige", (IMemberDescriptor) new Bridge.TYPE_6829ea0050334a42b3e486d24556a884.FLDV_2dab0807a22b45cf928590bd3a4c8bfc());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_6829ea0050334a42b3e486d24556a884.FLDV_d940c48a2ba74accb34a92dd7dcedc35());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_6829ea0050334a42b3e486d24556a884.FLDV_71880bd5f64d4629b1ae29a7d81ccbd4());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_6829ea0050334a42b3e486d24556a884.FLDV_f8167e3b31fe4db3bd362988fb00a85a());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_6829ea0050334a42b3e486d24556a884.FLDV_23ac6b9928344b4d91f3217766605e61());
      }

      private sealed class MTHD_d6ea748d5a3747aab0b08e51b00702a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6ea748d5a3747aab0b08e51b00702a1()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_5d22fcdc70bd43a29f1231ca62ba6942 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d22fcdc70bd43a29f1231ca62ba6942()
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

      private sealed class MTHD_24d4ca9223814e37a75958113b996cb8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24d4ca9223814e37a75958113b996cb8()
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

      private sealed class MTHD_bf729f40edf34b0ba9b9db4762b49191 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf729f40edf34b0ba9b9db4762b49191()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_6ab04a5a045f424db186d4e71e23fff6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ab04a5a045f424db186d4e71e23fff6()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_70236297638245368311e17856d44b86 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_70236297638245368311e17856d44b86()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_b02ee8c3efb149259ef52206f748eea9 : HardwiredMemberDescriptor
      {
        internal FLDV_b02ee8c3efb149259ef52206f748eea9()
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

      private sealed class FLDV_28539e9d694547cba6ccf33095c6a53f : HardwiredMemberDescriptor
      {
        internal FLDV_28539e9d694547cba6ccf33095c6a53f()
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

      private sealed class FLDV_fc816e10e734405a85406c2c9710e827 : HardwiredMemberDescriptor
      {
        internal FLDV_fc816e10e734405a85406c2c9710e827()
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

      private sealed class FLDV_2622aa36e6ea4021958e1be6ba48abf2 : HardwiredMemberDescriptor
      {
        internal FLDV_2622aa36e6ea4021958e1be6ba48abf2()
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

      private sealed class FLDV_be40b7b3d46342e08d534f4fce996615 : HardwiredMemberDescriptor
      {
        internal FLDV_be40b7b3d46342e08d534f4fce996615()
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

      private sealed class FLDV_ed16795ad5d348559f49e08c095d3db0 : HardwiredMemberDescriptor
      {
        internal FLDV_ed16795ad5d348559f49e08c095d3db0()
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

      private sealed class FLDV_b6d6a54815394718b9cc274e671eb0fe : HardwiredMemberDescriptor
      {
        internal FLDV_b6d6a54815394718b9cc274e671eb0fe()
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

      private sealed class FLDV_554f13553dfe4900bd42162fcde4faec : HardwiredMemberDescriptor
      {
        internal FLDV_554f13553dfe4900bd42162fcde4faec()
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

      private sealed class FLDV_2dab0807a22b45cf928590bd3a4c8bfc : HardwiredMemberDescriptor
      {
        internal FLDV_2dab0807a22b45cf928590bd3a4c8bfc()
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

      private sealed class FLDV_d940c48a2ba74accb34a92dd7dcedc35 : HardwiredMemberDescriptor
      {
        internal FLDV_d940c48a2ba74accb34a92dd7dcedc35()
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

      private sealed class FLDV_71880bd5f64d4629b1ae29a7d81ccbd4 : HardwiredMemberDescriptor
      {
        internal FLDV_71880bd5f64d4629b1ae29a7d81ccbd4()
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

      private sealed class FLDV_f8167e3b31fe4db3bd362988fb00a85a : HardwiredMemberDescriptor
      {
        internal FLDV_f8167e3b31fe4db3bd362988fb00a85a()
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

      private sealed class FLDV_23ac6b9928344b4d91f3217766605e61 : HardwiredMemberDescriptor
      {
        internal FLDV_23ac6b9928344b4d91f3217766605e61()
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

    private sealed class TYPE_09c2ae49f9b7421b847c6e89acaebf0d : HardwiredUserDataDescriptor
    {
      internal TYPE_09c2ae49f9b7421b847c6e89acaebf0d()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_594b2dfa18ac4a0fa019df687dd1e532()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_e4d9318d58fc4a82b298ace125384d89()
        }));
        this.AddMember("get_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_0130b86c815b413daa38760cf35653ac()
        }));
        this.AddMember("set_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_6985c90c62414a67ba7a504cce945c26()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_1910552a9c0145509f0b1e612ec13e89()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_2ba703fbeed8438489976a8f3cf26eda()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_79ad2b3171b44635b3253a87f5439463()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_a974111b2675415db346a23edab08538()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_6ca7883283dd4ffc964294c37500c4a8()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_76856157c96846ceb0afdd23b1c4fa50()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_0bbc19f4097d48a7a00d3139c09bb648()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_5090a23d9e264226bd00d8cebb356b27()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_a411a6cdf73e4e98bcbbc3f81580dec6()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_eb5b6319e5af44208ae43c13179adf15()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_7f882fc5be0047e89cab12bec0c2add6()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_dad3f91e3e1e4c1f928539426934c8e7()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_c2d8ff5e7caa412fa614dcef85932e4a()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_803bab5e08d546e0a35d29715c681e7a()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_a2f200486ddf465b99ec10e33d4c9c33()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_cf3b3299891f4791a493c4b17cd58df5()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_0b30773bbfee47d986be540f038fc0f3()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_06763592179e4b66b35bd9e32dab862e()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_fc53b1aaf52c41f8a818390612558157()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_f26397f71c2f4a11b9b673c8be2108b9()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_a2082e78a9334d128236bb695c1f1279()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_47c0941004c44d138f0d5c4ff1298d0c()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_a1c37f2d1a1f4478aef88480a63b2e1c()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_e3b97e06177f43b3a69ef62e082296dd()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_55bd2906d28f4970a29537514a7e4c01()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_65f1ebbd5ce24b0f87875510a4f95359()
        }));
        this.AddMember("get_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_92dbe9695e9a4787ab67af560b43baed()
        }));
        this.AddMember("set_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_a0b6f82f91f8414eb707874656a9441f()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_b6e082bf2efd49f1acd35ac1077a2461()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_4090d80be7fc41769b88aa88de61b13a()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_9d966a70b9a14a3080d1de5fa097d65d()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_16653108ef784bb6840de4ac12e86fd7()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_133290ddbdd74fa4943d1e72df9c33d9()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_fdf78b3322e54ffbaf899633d89ea112()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_0dc007a070c94e1082091526096faf75()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_62aec09a0dd64795bed2e0a59b13a36f()
        }));
        this.AddMember("get_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_ab5fb39ae1064ac4add73d0a7939fc32()
        }));
        this.AddMember("set_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_ae75ad82d2284b09acc999bd05883bce()
        }));
        this.AddMember("get_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_4290e8d98c014e5cab4963d5b0ce3cac()
        }));
        this.AddMember("set_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_4d12605c7ac54338b5421994d27f184e()
        }));
        this.AddMember("get_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_eaa4bdd1adcd46a3a02e6d4e6e610e74()
        }));
        this.AddMember("set_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_9644fb9483134e8ebc32f7a1c8d9ec46()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_626ed7d738e04cb3b871b045c85afebf()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_16649936bfcf41e89e24dade38de1d9a()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_249a7a5bb9324e2a9fed1843ae39b101()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_23ace32abd1240c3bb5073a43bff46bf()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_391ca4ac4b6340cb94a88e8ac626529e()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_c8c4407e2020463e93f9e47c7e46dba1()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_35c11523877d4be4b10ef4366ba0483c()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_fa28aa5140134390931d6d24ff0bb7e3()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_680a9edb641d409aa27137c40cc7a581()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_d0ff27e0b7314dd4a09e81ccff3bf247()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_33d6d2be8e3643b3b5fac86cc0a6467a()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_92f4b14c232c478d8f493951811be425()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_ec95ad1a7f284467ba93407a24fdd789()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.MTHD_b535c07b6744432d8546121cc375310f()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.PROP_672558fee74d40f6a07e0789cc321ddc());
        this.AddMember("visible", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.PROP_2c074a80d95d4c81b37e08c3e95642d6());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.PROP_ed367f3bbde14524a6cf0c069d49161e());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.PROP_d2e5f6c06d9c4c5b849c006e0ddc39d8());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.PROP_bde93935db884159abd577ec5449c961());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.PROP_c15dfd8451dd4797b4a38bbb6c36dc61());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.PROP_644e74d4dd964dde9a6b0f69c72ebdb3());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.PROP_0c9a7469a53f4864a428b3036d35dd9d());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.PROP_d896e2e540a04592bdc4c6d0f79c3e8f());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.PROP_fe5da4a954cb4bf68e1de3c78e1554c0());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.PROP_d30975ffebfa41c286ea2815c7e9979f());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.PROP_65ddf5ec3fb549fa829079291ec932d0());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.PROP_54da503365f24959ab84586bf347fd30());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.PROP_e7454d57e8634311ac6b7dc49630d007());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.PROP_880b68402c354cd38fd72b20e211db29());
        this.AddMember("onClick2", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.PROP_2607f21273d04c72a92f030786dcc1fc());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.PROP_283ab17178b24cfe9ef993290bfcb403());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.PROP_1f38d2d4d8e74c238e9790f1cf7b2629());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.PROP_5d53e59c6c804d65ad03d3c93df88a3f());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.PROP_546904c37f1642938d6e7e15d4d93edb());
        this.AddMember("textColor2", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.PROP_32babb6eab1a4474880eac10ae80c303());
        this.AddMember("highlightColor", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.PROP_d5954c5960b946eab624dadcb31e5148());
        this.AddMember("highlightColor2", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.PROP_92c41808b82648a2ba6008094ff682a1());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.PROP_59b669c8bbd24b19839e307804bfe34f());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.PROP_ac88a47af9f4462fa4d22e785dd42f69());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.FLDV_a33eba91b95d4b3484eb0744f795b16d());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.FLDV_023c34fa98214a8e925a54040ee33410());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_09c2ae49f9b7421b847c6e89acaebf0d.FLDV_60698e1cdfbf45909fefc6bd7f5cc326());
      }

      private sealed class MTHD_594b2dfa18ac4a0fa019df687dd1e532 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_594b2dfa18ac4a0fa019df687dd1e532()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_e4d9318d58fc4a82b298ace125384d89 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e4d9318d58fc4a82b298ace125384d89()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_0130b86c815b413daa38760cf35653ac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0130b86c815b413daa38760cf35653ac()
        {
          this.Initialize("get_visible", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).visible;
        }
      }

      private sealed class MTHD_6985c90c62414a67ba7a504cce945c26 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6985c90c62414a67ba7a504cce945c26()
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

      private sealed class MTHD_1910552a9c0145509f0b1e612ec13e89 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1910552a9c0145509f0b1e612ec13e89()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_2ba703fbeed8438489976a8f3cf26eda : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2ba703fbeed8438489976a8f3cf26eda()
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

      private sealed class MTHD_79ad2b3171b44635b3253a87f5439463 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_79ad2b3171b44635b3253a87f5439463()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_a974111b2675415db346a23edab08538 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a974111b2675415db346a23edab08538()
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

      private sealed class MTHD_6ca7883283dd4ffc964294c37500c4a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6ca7883283dd4ffc964294c37500c4a8()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_76856157c96846ceb0afdd23b1c4fa50 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76856157c96846ceb0afdd23b1c4fa50()
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

      private sealed class MTHD_0bbc19f4097d48a7a00d3139c09bb648 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0bbc19f4097d48a7a00d3139c09bb648()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_5090a23d9e264226bd00d8cebb356b27 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5090a23d9e264226bd00d8cebb356b27()
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

      private sealed class MTHD_a411a6cdf73e4e98bcbbc3f81580dec6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a411a6cdf73e4e98bcbbc3f81580dec6()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_eb5b6319e5af44208ae43c13179adf15 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb5b6319e5af44208ae43c13179adf15()
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

      private sealed class MTHD_7f882fc5be0047e89cab12bec0c2add6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f882fc5be0047e89cab12bec0c2add6()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_dad3f91e3e1e4c1f928539426934c8e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dad3f91e3e1e4c1f928539426934c8e7()
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

      private sealed class MTHD_c2d8ff5e7caa412fa614dcef85932e4a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c2d8ff5e7caa412fa614dcef85932e4a()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_803bab5e08d546e0a35d29715c681e7a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_803bab5e08d546e0a35d29715c681e7a()
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

      private sealed class MTHD_a2f200486ddf465b99ec10e33d4c9c33 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2f200486ddf465b99ec10e33d4c9c33()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_cf3b3299891f4791a493c4b17cd58df5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf3b3299891f4791a493c4b17cd58df5()
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

      private sealed class MTHD_0b30773bbfee47d986be540f038fc0f3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0b30773bbfee47d986be540f038fc0f3()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_06763592179e4b66b35bd9e32dab862e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_06763592179e4b66b35bd9e32dab862e()
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

      private sealed class MTHD_fc53b1aaf52c41f8a818390612558157 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fc53b1aaf52c41f8a818390612558157()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_f26397f71c2f4a11b9b673c8be2108b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f26397f71c2f4a11b9b673c8be2108b9()
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

      private sealed class MTHD_a2082e78a9334d128236bb695c1f1279 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a2082e78a9334d128236bb695c1f1279()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_47c0941004c44d138f0d5c4ff1298d0c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_47c0941004c44d138f0d5c4ff1298d0c()
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

      private sealed class MTHD_a1c37f2d1a1f4478aef88480a63b2e1c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1c37f2d1a1f4478aef88480a63b2e1c()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_e3b97e06177f43b3a69ef62e082296dd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e3b97e06177f43b3a69ef62e082296dd()
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

      private sealed class MTHD_55bd2906d28f4970a29537514a7e4c01 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_55bd2906d28f4970a29537514a7e4c01()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_65f1ebbd5ce24b0f87875510a4f95359 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65f1ebbd5ce24b0f87875510a4f95359()
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

      private sealed class MTHD_92dbe9695e9a4787ab67af560b43baed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_92dbe9695e9a4787ab67af560b43baed()
        {
          this.Initialize("get_onClick2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick2;
        }
      }

      private sealed class MTHD_a0b6f82f91f8414eb707874656a9441f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a0b6f82f91f8414eb707874656a9441f()
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

      private sealed class MTHD_b6e082bf2efd49f1acd35ac1077a2461 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b6e082bf2efd49f1acd35ac1077a2461()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_4090d80be7fc41769b88aa88de61b13a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4090d80be7fc41769b88aa88de61b13a()
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

      private sealed class MTHD_9d966a70b9a14a3080d1de5fa097d65d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d966a70b9a14a3080d1de5fa097d65d()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color2;
        }
      }

      private sealed class MTHD_16653108ef784bb6840de4ac12e86fd7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_16653108ef784bb6840de4ac12e86fd7()
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

      private sealed class MTHD_133290ddbdd74fa4943d1e72df9c33d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_133290ddbdd74fa4943d1e72df9c33d9()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_fdf78b3322e54ffbaf899633d89ea112 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fdf78b3322e54ffbaf899633d89ea112()
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

      private sealed class MTHD_0dc007a070c94e1082091526096faf75 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0dc007a070c94e1082091526096faf75()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_62aec09a0dd64795bed2e0a59b13a36f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_62aec09a0dd64795bed2e0a59b13a36f()
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

      private sealed class MTHD_ab5fb39ae1064ac4add73d0a7939fc32 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab5fb39ae1064ac4add73d0a7939fc32()
        {
          this.Initialize("get_textColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor2;
        }
      }

      private sealed class MTHD_ae75ad82d2284b09acc999bd05883bce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ae75ad82d2284b09acc999bd05883bce()
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

      private sealed class MTHD_4290e8d98c014e5cab4963d5b0ce3cac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4290e8d98c014e5cab4963d5b0ce3cac()
        {
          this.Initialize("get_highlightColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor;
        }
      }

      private sealed class MTHD_4d12605c7ac54338b5421994d27f184e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d12605c7ac54338b5421994d27f184e()
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

      private sealed class MTHD_eaa4bdd1adcd46a3a02e6d4e6e610e74 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eaa4bdd1adcd46a3a02e6d4e6e610e74()
        {
          this.Initialize("get_highlightColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor2;
        }
      }

      private sealed class MTHD_9644fb9483134e8ebc32f7a1c8d9ec46 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9644fb9483134e8ebc32f7a1c8d9ec46()
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

      private sealed class MTHD_626ed7d738e04cb3b871b045c85afebf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_626ed7d738e04cb3b871b045c85afebf()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_16649936bfcf41e89e24dade38de1d9a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_16649936bfcf41e89e24dade38de1d9a()
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

      private sealed class MTHD_249a7a5bb9324e2a9fed1843ae39b101 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_249a7a5bb9324e2a9fed1843ae39b101()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_23ace32abd1240c3bb5073a43bff46bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_23ace32abd1240c3bb5073a43bff46bf()
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

      private sealed class MTHD_391ca4ac4b6340cb94a88e8ac626529e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_391ca4ac4b6340cb94a88e8ac626529e()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c8c4407e2020463e93f9e47c7e46dba1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c8c4407e2020463e93f9e47c7e46dba1()
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

      private sealed class MTHD_35c11523877d4be4b10ef4366ba0483c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35c11523877d4be4b10ef4366ba0483c()
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

      private sealed class MTHD_fa28aa5140134390931d6d24ff0bb7e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa28aa5140134390931d6d24ff0bb7e3()
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

      private sealed class MTHD_680a9edb641d409aa27137c40cc7a581 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_680a9edb641d409aa27137c40cc7a581()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_d0ff27e0b7314dd4a09e81ccff3bf247 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0ff27e0b7314dd4a09e81ccff3bf247()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_33d6d2be8e3643b3b5fac86cc0a6467a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_33d6d2be8e3643b3b5fac86cc0a6467a()
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

      private sealed class MTHD_92f4b14c232c478d8f493951811be425 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_92f4b14c232c478d8f493951811be425()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_ec95ad1a7f284467ba93407a24fdd789 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ec95ad1a7f284467ba93407a24fdd789()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_b535c07b6744432d8546121cc375310f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b535c07b6744432d8546121cc375310f()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_672558fee74d40f6a07e0789cc321ddc : HardwiredMemberDescriptor
      {
        internal PROP_672558fee74d40f6a07e0789cc321ddc()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_2c074a80d95d4c81b37e08c3e95642d6 : HardwiredMemberDescriptor
      {
        internal PROP_2c074a80d95d4c81b37e08c3e95642d6()
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

      private sealed class PROP_ed367f3bbde14524a6cf0c069d49161e : HardwiredMemberDescriptor
      {
        internal PROP_ed367f3bbde14524a6cf0c069d49161e()
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

      private sealed class PROP_d2e5f6c06d9c4c5b849c006e0ddc39d8 : HardwiredMemberDescriptor
      {
        internal PROP_d2e5f6c06d9c4c5b849c006e0ddc39d8()
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

      private sealed class PROP_bde93935db884159abd577ec5449c961 : HardwiredMemberDescriptor
      {
        internal PROP_bde93935db884159abd577ec5449c961()
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

      private sealed class PROP_c15dfd8451dd4797b4a38bbb6c36dc61 : HardwiredMemberDescriptor
      {
        internal PROP_c15dfd8451dd4797b4a38bbb6c36dc61()
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

      private sealed class PROP_644e74d4dd964dde9a6b0f69c72ebdb3 : HardwiredMemberDescriptor
      {
        internal PROP_644e74d4dd964dde9a6b0f69c72ebdb3()
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

      private sealed class PROP_0c9a7469a53f4864a428b3036d35dd9d : HardwiredMemberDescriptor
      {
        internal PROP_0c9a7469a53f4864a428b3036d35dd9d()
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

      private sealed class PROP_d896e2e540a04592bdc4c6d0f79c3e8f : HardwiredMemberDescriptor
      {
        internal PROP_d896e2e540a04592bdc4c6d0f79c3e8f()
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

      private sealed class PROP_fe5da4a954cb4bf68e1de3c78e1554c0 : HardwiredMemberDescriptor
      {
        internal PROP_fe5da4a954cb4bf68e1de3c78e1554c0()
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

      private sealed class PROP_d30975ffebfa41c286ea2815c7e9979f : HardwiredMemberDescriptor
      {
        internal PROP_d30975ffebfa41c286ea2815c7e9979f()
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

      private sealed class PROP_65ddf5ec3fb549fa829079291ec932d0 : HardwiredMemberDescriptor
      {
        internal PROP_65ddf5ec3fb549fa829079291ec932d0()
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

      private sealed class PROP_54da503365f24959ab84586bf347fd30 : HardwiredMemberDescriptor
      {
        internal PROP_54da503365f24959ab84586bf347fd30()
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

      private sealed class PROP_e7454d57e8634311ac6b7dc49630d007 : HardwiredMemberDescriptor
      {
        internal PROP_e7454d57e8634311ac6b7dc49630d007()
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

      private sealed class PROP_880b68402c354cd38fd72b20e211db29 : HardwiredMemberDescriptor
      {
        internal PROP_880b68402c354cd38fd72b20e211db29()
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

      private sealed class PROP_2607f21273d04c72a92f030786dcc1fc : HardwiredMemberDescriptor
      {
        internal PROP_2607f21273d04c72a92f030786dcc1fc()
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

      private sealed class PROP_283ab17178b24cfe9ef993290bfcb403 : HardwiredMemberDescriptor
      {
        internal PROP_283ab17178b24cfe9ef993290bfcb403()
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

      private sealed class PROP_1f38d2d4d8e74c238e9790f1cf7b2629 : HardwiredMemberDescriptor
      {
        internal PROP_1f38d2d4d8e74c238e9790f1cf7b2629()
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

      private sealed class PROP_5d53e59c6c804d65ad03d3c93df88a3f : HardwiredMemberDescriptor
      {
        internal PROP_5d53e59c6c804d65ad03d3c93df88a3f()
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

      private sealed class PROP_546904c37f1642938d6e7e15d4d93edb : HardwiredMemberDescriptor
      {
        internal PROP_546904c37f1642938d6e7e15d4d93edb()
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

      private sealed class PROP_32babb6eab1a4474880eac10ae80c303 : HardwiredMemberDescriptor
      {
        internal PROP_32babb6eab1a4474880eac10ae80c303()
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

      private sealed class PROP_d5954c5960b946eab624dadcb31e5148 : HardwiredMemberDescriptor
      {
        internal PROP_d5954c5960b946eab624dadcb31e5148()
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

      private sealed class PROP_92c41808b82648a2ba6008094ff682a1 : HardwiredMemberDescriptor
      {
        internal PROP_92c41808b82648a2ba6008094ff682a1()
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

      private sealed class PROP_59b669c8bbd24b19839e307804bfe34f : HardwiredMemberDescriptor
      {
        internal PROP_59b669c8bbd24b19839e307804bfe34f()
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

      private sealed class PROP_ac88a47af9f4462fa4d22e785dd42f69 : HardwiredMemberDescriptor
      {
        internal PROP_ac88a47af9f4462fa4d22e785dd42f69()
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

      private sealed class FLDV_a33eba91b95d4b3484eb0744f795b16d : HardwiredMemberDescriptor
      {
        internal FLDV_a33eba91b95d4b3484eb0744f795b16d()
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

      private sealed class FLDV_023c34fa98214a8e925a54040ee33410 : HardwiredMemberDescriptor
      {
        internal FLDV_023c34fa98214a8e925a54040ee33410()
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

      private sealed class FLDV_60698e1cdfbf45909fefc6bd7f5cc326 : HardwiredMemberDescriptor
      {
        internal FLDV_60698e1cdfbf45909fefc6bd7f5cc326()
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

    private sealed class TYPE_8912af4765db45008a0488b09ab1f095 : HardwiredUserDataDescriptor
    {
      internal TYPE_8912af4765db45008a0488b09ab1f095()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8912af4765db45008a0488b09ab1f095.MTHD_5d51260000384a8690ba46188d11db94()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8912af4765db45008a0488b09ab1f095.MTHD_1dc0a5ee42af46b8968c1d65249a0d6a()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8912af4765db45008a0488b09ab1f095.MTHD_cd033e8e19ce42dd8684d9c77e5f0eb0()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8912af4765db45008a0488b09ab1f095.MTHD_7f4c6a350ba947a9b0de71f81b2d1a52()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8912af4765db45008a0488b09ab1f095.MTHD_971ca21d30fb493187b6582d88735ff6()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8912af4765db45008a0488b09ab1f095.MTHD_9525b72486004e738edc78b7b9aafa80()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_8912af4765db45008a0488b09ab1f095.FLDV_7035b86eabd744e793c9d392899d331d());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_8912af4765db45008a0488b09ab1f095.FLDV_c28a0ae3dde24fc7a5d654c884fdbd21());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_8912af4765db45008a0488b09ab1f095.FLDV_f343e26fb7b3433f8cc51976d74f0448());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_8912af4765db45008a0488b09ab1f095.FLDV_e511ce5a1562491da819e35e0997497d());
      }

      private sealed class MTHD_5d51260000384a8690ba46188d11db94 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d51260000384a8690ba46188d11db94()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_1dc0a5ee42af46b8968c1d65249a0d6a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1dc0a5ee42af46b8968c1d65249a0d6a()
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

      private sealed class MTHD_cd033e8e19ce42dd8684d9c77e5f0eb0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd033e8e19ce42dd8684d9c77e5f0eb0()
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

      private sealed class MTHD_7f4c6a350ba947a9b0de71f81b2d1a52 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f4c6a350ba947a9b0de71f81b2d1a52()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_971ca21d30fb493187b6582d88735ff6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_971ca21d30fb493187b6582d88735ff6()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_9525b72486004e738edc78b7b9aafa80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9525b72486004e738edc78b7b9aafa80()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_7035b86eabd744e793c9d392899d331d : HardwiredMemberDescriptor
      {
        internal FLDV_7035b86eabd744e793c9d392899d331d()
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

      private sealed class FLDV_c28a0ae3dde24fc7a5d654c884fdbd21 : HardwiredMemberDescriptor
      {
        internal FLDV_c28a0ae3dde24fc7a5d654c884fdbd21()
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

      private sealed class FLDV_f343e26fb7b3433f8cc51976d74f0448 : HardwiredMemberDescriptor
      {
        internal FLDV_f343e26fb7b3433f8cc51976d74f0448()
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

      private sealed class FLDV_e511ce5a1562491da819e35e0997497d : HardwiredMemberDescriptor
      {
        internal FLDV_e511ce5a1562491da819e35e0997497d()
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

    private sealed class TYPE_0fd536adf10244a69a127bc76c138a79 : HardwiredUserDataDescriptor
    {
      internal TYPE_0fd536adf10244a69a127bc76c138a79()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0fd536adf10244a69a127bc76c138a79.MTHD_89d9ff7d215049b298ba8e960a5a9ed2()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0fd536adf10244a69a127bc76c138a79.MTHD_973386a3c1764ea98b3fa9cf0004722d()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0fd536adf10244a69a127bc76c138a79.MTHD_5a480c5a63aa4e2d8193180eb2c973b9()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0fd536adf10244a69a127bc76c138a79.MTHD_bc047324d8934a13a0cdb47b29e81a58()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_0fd536adf10244a69a127bc76c138a79.MTHD_0789076dfaa5489ba702ac553f655969()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_0fd536adf10244a69a127bc76c138a79.FLDV_0f905b2e81d64c699d225b161300a3f9());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_0fd536adf10244a69a127bc76c138a79.FLDV_7cac8cb276b7449ea7c32bfe3e57610b());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_0fd536adf10244a69a127bc76c138a79.FLDV_ed3965d0318d4c52a7ee5fd73ef880c9());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_0fd536adf10244a69a127bc76c138a79.FLDV_bceb918bdb62418b87697f5a21196fa7());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_0fd536adf10244a69a127bc76c138a79.FLDV_08daeb88670e499f83ae87e6bd3a2d22());
      }

      private sealed class MTHD_89d9ff7d215049b298ba8e960a5a9ed2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_89d9ff7d215049b298ba8e960a5a9ed2()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_973386a3c1764ea98b3fa9cf0004722d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_973386a3c1764ea98b3fa9cf0004722d()
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

      private sealed class MTHD_5a480c5a63aa4e2d8193180eb2c973b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5a480c5a63aa4e2d8193180eb2c973b9()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_bc047324d8934a13a0cdb47b29e81a58 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bc047324d8934a13a0cdb47b29e81a58()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_0789076dfaa5489ba702ac553f655969 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0789076dfaa5489ba702ac553f655969()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_0f905b2e81d64c699d225b161300a3f9 : HardwiredMemberDescriptor
      {
        internal FLDV_0f905b2e81d64c699d225b161300a3f9()
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

      private sealed class FLDV_7cac8cb276b7449ea7c32bfe3e57610b : HardwiredMemberDescriptor
      {
        internal FLDV_7cac8cb276b7449ea7c32bfe3e57610b()
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

      private sealed class FLDV_ed3965d0318d4c52a7ee5fd73ef880c9 : HardwiredMemberDescriptor
      {
        internal FLDV_ed3965d0318d4c52a7ee5fd73ef880c9()
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

      private sealed class FLDV_bceb918bdb62418b87697f5a21196fa7 : HardwiredMemberDescriptor
      {
        internal FLDV_bceb918bdb62418b87697f5a21196fa7()
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

      private sealed class FLDV_08daeb88670e499f83ae87e6bd3a2d22 : HardwiredMemberDescriptor
      {
        internal FLDV_08daeb88670e499f83ae87e6bd3a2d22()
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

    private sealed class TYPE_3522a98f1180415a94382838d4ddef02 : HardwiredUserDataDescriptor
    {
      internal TYPE_3522a98f1180415a94382838d4ddef02()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3522a98f1180415a94382838d4ddef02.MTHD_817a4497795e492aac0636a89b939518()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3522a98f1180415a94382838d4ddef02.MTHD_14bb9c2fbcd24811aab256c022df54ea()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3522a98f1180415a94382838d4ddef02.MTHD_1282b449b3fa45c09f39461792a4ca96()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3522a98f1180415a94382838d4ddef02.MTHD_f67b12599339477c8b21c573b0fbbeff()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3522a98f1180415a94382838d4ddef02.MTHD_840ded2299824610b70095f262b21eb8()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3522a98f1180415a94382838d4ddef02.MTHD_de7740de240a4fb3bb740613f59e1174()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3522a98f1180415a94382838d4ddef02.MTHD_8ae87b5b85114381a76348c2f0015096()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3522a98f1180415a94382838d4ddef02.MTHD_083c2b4a4919494c8d6c363d6cc4c06a()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3522a98f1180415a94382838d4ddef02.MTHD_6b0849b7e7404d67b320c6daeeb6b0c4()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3522a98f1180415a94382838d4ddef02.MTHD_42ef20ca35774fde80a5db082b9f5fb9()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3522a98f1180415a94382838d4ddef02.MTHD_82c1d3aba7a443afb7d9db0dfeb9f54e()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3522a98f1180415a94382838d4ddef02.MTHD_efb9f64b11f443229a4e26adf95e36b9()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_3522a98f1180415a94382838d4ddef02.MTHD_4e82718cafd1469cba2352df0b7b1764()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_3522a98f1180415a94382838d4ddef02.FLDV_3370af1684724a669c0e8ded82103a1d());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_3522a98f1180415a94382838d4ddef02.FLDV_e9d26a72713043eb9ae4ba3a0ab0ad09());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_3522a98f1180415a94382838d4ddef02.FLDV_728d36892ced4c34a016798db3f9b9a6());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_3522a98f1180415a94382838d4ddef02.FLDV_8c74878e59284a1e92150c4330ab9ce1());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_3522a98f1180415a94382838d4ddef02.FLDV_202a98ce099b43f7bc7e7e711a10eab6());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_3522a98f1180415a94382838d4ddef02.FLDV_386ce5c09a1f4f868650518e12da35a2());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_3522a98f1180415a94382838d4ddef02.FLDV_3a504406a82d4b52b5e6ddd8181ded04());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_3522a98f1180415a94382838d4ddef02.FLDV_f1e91561027e40feb27f678b392561e8());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_3522a98f1180415a94382838d4ddef02.DVAL_3c8578ced08d4f48afad6da61b399c61());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_3522a98f1180415a94382838d4ddef02.DVAL_17fe860d348f418e9d8af2ccfc1a34eb());
      }

      private sealed class MTHD_817a4497795e492aac0636a89b939518 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_817a4497795e492aac0636a89b939518()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_14bb9c2fbcd24811aab256c022df54ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_14bb9c2fbcd24811aab256c022df54ea()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_1282b449b3fa45c09f39461792a4ca96 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1282b449b3fa45c09f39461792a4ca96()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_f67b12599339477c8b21c573b0fbbeff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f67b12599339477c8b21c573b0fbbeff()
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

      private sealed class MTHD_840ded2299824610b70095f262b21eb8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_840ded2299824610b70095f262b21eb8()
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

      private sealed class MTHD_de7740de240a4fb3bb740613f59e1174 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de7740de240a4fb3bb740613f59e1174()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_8ae87b5b85114381a76348c2f0015096 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ae87b5b85114381a76348c2f0015096()
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

      private sealed class MTHD_083c2b4a4919494c8d6c363d6cc4c06a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_083c2b4a4919494c8d6c363d6cc4c06a()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_6b0849b7e7404d67b320c6daeeb6b0c4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b0849b7e7404d67b320c6daeeb6b0c4()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_42ef20ca35774fde80a5db082b9f5fb9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42ef20ca35774fde80a5db082b9f5fb9()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_82c1d3aba7a443afb7d9db0dfeb9f54e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_82c1d3aba7a443afb7d9db0dfeb9f54e()
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

      private sealed class MTHD_efb9f64b11f443229a4e26adf95e36b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_efb9f64b11f443229a4e26adf95e36b9()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_4e82718cafd1469cba2352df0b7b1764 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e82718cafd1469cba2352df0b7b1764()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_3370af1684724a669c0e8ded82103a1d : HardwiredMemberDescriptor
      {
        internal FLDV_3370af1684724a669c0e8ded82103a1d()
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

      private sealed class FLDV_e9d26a72713043eb9ae4ba3a0ab0ad09 : HardwiredMemberDescriptor
      {
        internal FLDV_e9d26a72713043eb9ae4ba3a0ab0ad09()
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

      private sealed class FLDV_728d36892ced4c34a016798db3f9b9a6 : HardwiredMemberDescriptor
      {
        internal FLDV_728d36892ced4c34a016798db3f9b9a6()
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

      private sealed class FLDV_8c74878e59284a1e92150c4330ab9ce1 : HardwiredMemberDescriptor
      {
        internal FLDV_8c74878e59284a1e92150c4330ab9ce1()
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

      private sealed class FLDV_202a98ce099b43f7bc7e7e711a10eab6 : HardwiredMemberDescriptor
      {
        internal FLDV_202a98ce099b43f7bc7e7e711a10eab6()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_386ce5c09a1f4f868650518e12da35a2 : HardwiredMemberDescriptor
      {
        internal FLDV_386ce5c09a1f4f868650518e12da35a2()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_3a504406a82d4b52b5e6ddd8181ded04 : HardwiredMemberDescriptor
      {
        internal FLDV_3a504406a82d4b52b5e6ddd8181ded04()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_f1e91561027e40feb27f678b392561e8 : HardwiredMemberDescriptor
      {
        internal FLDV_f1e91561027e40feb27f678b392561e8()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_3c8578ced08d4f48afad6da61b399c61 : DynValueMemberDescriptor
      {
        internal DVAL_3c8578ced08d4f48afad6da61b399c61()
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

      private sealed class DVAL_17fe860d348f418e9d8af2ccfc1a34eb : DynValueMemberDescriptor
      {
        internal DVAL_17fe860d348f418e9d8af2ccfc1a34eb()
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

    private sealed class TYPE_8779eab0e7d74a7fa35d37f02d4a37bd : HardwiredUserDataDescriptor
    {
      internal TYPE_8779eab0e7d74a7fa35d37f02d4a37bd()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8779eab0e7d74a7fa35d37f02d4a37bd.MTHD_17813ef655224634957d8450f5f254ad()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8779eab0e7d74a7fa35d37f02d4a37bd.MTHD_4e49eef663d5489d9e320da4b5184098()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8779eab0e7d74a7fa35d37f02d4a37bd.MTHD_24fa9608813345679de4c05cf40963d3(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8779eab0e7d74a7fa35d37f02d4a37bd.MTHD_e76d47f7e9d94444ae16a976497c6278()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8779eab0e7d74a7fa35d37f02d4a37bd.MTHD_ff2c867b77284a77a50a7773014a38d8(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8779eab0e7d74a7fa35d37f02d4a37bd.MTHD_2bd0f65edf1d4a4e9585a30440b1d0b9()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8779eab0e7d74a7fa35d37f02d4a37bd.MTHD_09c1a6fd299a41adad1cdeb15bbce5c5()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8779eab0e7d74a7fa35d37f02d4a37bd.MTHD_799e7d7202fd452a8dcddde9d0fbd946()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8779eab0e7d74a7fa35d37f02d4a37bd.MTHD_82be0ccc292948fb9ac11ed169798e2e()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_8779eab0e7d74a7fa35d37f02d4a37bd.MTHD_0e9864882d5b485ab088cf0269e29e67()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_8779eab0e7d74a7fa35d37f02d4a37bd.FLDV_6e2b40406a8e4ddd8b2182aaed28e92d());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_8779eab0e7d74a7fa35d37f02d4a37bd.FLDV_0f668d55ab7b478f8d86a619614e11f9());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_8779eab0e7d74a7fa35d37f02d4a37bd.FLDV_37009533d07e4541b1d9771b5a0a8484());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_8779eab0e7d74a7fa35d37f02d4a37bd.FLDV_2d6615c2495b4697b249c11c0b1c7216());
        this.AddMember("white", (IMemberDescriptor) new Bridge.TYPE_8779eab0e7d74a7fa35d37f02d4a37bd.FLDV_bb0d9587bbde4b3993294cd499de5637());
      }

      private sealed class MTHD_17813ef655224634957d8450f5f254ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_17813ef655224634957d8450f5f254ad()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_4e49eef663d5489d9e320da4b5184098 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e49eef663d5489d9e320da4b5184098()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_24fa9608813345679de4c05cf40963d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24fa9608813345679de4c05cf40963d3()
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

      private sealed class MTHD_e76d47f7e9d94444ae16a976497c6278 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e76d47f7e9d94444ae16a976497c6278()
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

      private sealed class MTHD_ff2c867b77284a77a50a7773014a38d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff2c867b77284a77a50a7773014a38d8()
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

      private sealed class MTHD_2bd0f65edf1d4a4e9585a30440b1d0b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2bd0f65edf1d4a4e9585a30440b1d0b9()
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

      private sealed class MTHD_09c1a6fd299a41adad1cdeb15bbce5c5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_09c1a6fd299a41adad1cdeb15bbce5c5()
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

      private sealed class MTHD_799e7d7202fd452a8dcddde9d0fbd946 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_799e7d7202fd452a8dcddde9d0fbd946()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_82be0ccc292948fb9ac11ed169798e2e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_82be0ccc292948fb9ac11ed169798e2e()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_0e9864882d5b485ab088cf0269e29e67 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e9864882d5b485ab088cf0269e29e67()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_6e2b40406a8e4ddd8b2182aaed28e92d : HardwiredMemberDescriptor
      {
        internal FLDV_6e2b40406a8e4ddd8b2182aaed28e92d()
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

      private sealed class FLDV_0f668d55ab7b478f8d86a619614e11f9 : HardwiredMemberDescriptor
      {
        internal FLDV_0f668d55ab7b478f8d86a619614e11f9()
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

      private sealed class FLDV_37009533d07e4541b1d9771b5a0a8484 : HardwiredMemberDescriptor
      {
        internal FLDV_37009533d07e4541b1d9771b5a0a8484()
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

      private sealed class FLDV_2d6615c2495b4697b249c11c0b1c7216 : HardwiredMemberDescriptor
      {
        internal FLDV_2d6615c2495b4697b249c11c0b1c7216()
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

      private sealed class FLDV_bb0d9587bbde4b3993294cd499de5637 : HardwiredMemberDescriptor
      {
        internal FLDV_bb0d9587bbde4b3993294cd499de5637()
          : base(typeof (LuaColor), "white", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) LuaColor.white;
        }
      }
    }

    private sealed class TYPE_d6596ae94fba46bdb068b2f529494e7a : HardwiredUserDataDescriptor
    {
      internal TYPE_d6596ae94fba46bdb068b2f529494e7a()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6596ae94fba46bdb068b2f529494e7a.MTHD_d5f93f6d090d445a8b4201f033430e5b()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6596ae94fba46bdb068b2f529494e7a.MTHD_5489006bcbed46f4ba9fe6b9953afe28()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6596ae94fba46bdb068b2f529494e7a.MTHD_c505da6a20be438ea104a269c8fb7acc()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6596ae94fba46bdb068b2f529494e7a.MTHD_59c39d893e3e412fa0e99c0bbfc08fd1()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d6596ae94fba46bdb068b2f529494e7a.MTHD_175cc52b3e5d414996e193da653dceea()
        }));
      }

      private sealed class MTHD_d5f93f6d090d445a8b4201f033430e5b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d5f93f6d090d445a8b4201f033430e5b()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_5489006bcbed46f4ba9fe6b9953afe28 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5489006bcbed46f4ba9fe6b9953afe28()
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

      private sealed class MTHD_c505da6a20be438ea104a269c8fb7acc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c505da6a20be438ea104a269c8fb7acc()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_59c39d893e3e412fa0e99c0bbfc08fd1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_59c39d893e3e412fa0e99c0bbfc08fd1()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_175cc52b3e5d414996e193da653dceea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_175cc52b3e5d414996e193da653dceea()
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
