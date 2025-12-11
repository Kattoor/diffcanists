
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
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_91a41ecdd90a43cb9a24b7985d40dd4b());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_b4e9ef9412b14cc8b3bb4669ceee0d3c());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_2923f9c1b82746229c48903126ad3986());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_d8edcbc288ef4c9ab49e35c44bd5d403());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_16cf9a4163d34cef8710a4f3581513a0());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_4d69c32f00594122bf32a45b5d52f536());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_7ec2922f53c043a5bfba71a13af3af4c());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_13b4325a5c7f4a79a84cb4307ec5539e());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_1fa84e9bd1964663841dfe4a54f1afc0());
    }

    private sealed class TYPE_1dd98a686ccf4517b6dee2baa691dffd : HardwiredUserDataDescriptor
    {
      internal TYPE_1dd98a686ccf4517b6dee2baa691dffd()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_9bd57668a4884f20a9e13dbd2a43552d()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_42ff8cff90fd47c58389aa3d1c62484e()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_aa02655d81de43978b0f895fc0000d68()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_3057932b5fda4bd3a6efd7c7dac79bc3()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_c5a5132f25bb4a6bb3ff7e7fe64b23ca()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_f802821968494eea9e186123a72dc668()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_58b3f097c5b145239320156bd81061da()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_949f5d647ac5440eb3569d295666cada()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_3b2d5fae26624c64b6d39a842209b922()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_d564f55ebc734ed1bd15dce6fe9d58de()
        }));
        this.AddMember("hideInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("hideInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_17a88b88e25b47a2900e7f3b18708488()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_9debf502b3794850a23137dbc78091e2()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_05f18bc8af764005a56d521c1e36c599()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_ce953ef9366b4796adad5c175e95a6cf()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_be3760e1f1244141810b26ea63a05ce7()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_a37b94147c80406a9037d9624ec3157d()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_986624cb7516421b91533ad5113958c6()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_f000f887ec02445eb61a5e318531c0a8()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_8102f7736d894a2fba6fc67eb46bbf09()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_35a23303d0c3450d8bee3b51ea83d5e6()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_6bd43b52826a48c3b14d2d119bd8abc5()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_5ab7d2bc5b4645fa9ff30fd614b37443()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_f1089d5ba2f4445a9fbe5ba26f5d22ea()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_99fc2de4b6d64cd0a8cf05e12ef19afd()
        }));
        this.AddMember("get_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_1c255d02887c4ab7abdf848529e83a14()
        }));
        this.AddMember("set_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_5e60b962a0db4a49b5b2073513143c90()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_476c418271e74291bc6fe4669d2f60a2()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_ab13ec6e9a064743bb1d5fd1022168b1()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_c28dc5c55c0f4e83b7c03c4ed4e7f8b6()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_fab1af6cff524c45a5fc4ec35214ab26()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_a298631a2457461f9ad63c6ceebd6f83()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_92fbbef298d14766a2d0c8dec10def66()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_d7d654567c0d45eca63f1a561c292c5a()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_c0952238774147549047fdf51cde829d()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_dc586ceacca8411fa99ebf3d679c8071()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_f30e7522766b4d56839bbf7879738fdf()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_34fd6989ea794913a7d7bac72f0e0b99()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_779ec29b315a4423b5767a0231e3ac8e()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_bf1a862f37ab41d8a2238bd00503c409()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_ef4da817c70c4bf5843d09dbe40c75dd()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_dbfacaaeab4b482abe2c66ee95cb73b9()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_e6afe6f90a2741d6b61b4bb45539608d()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_43b11ca4a7ee4a31b7b838039a9a750a()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_38e686e737174b73909136e94a28dcf6()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_5809c1db68b547bda3be5ab2a66bab38()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_845bdad349de498e8eceb736b70f0eb5()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_fc3f704ec04a44eca592955b8e8c0896()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_eb3f9147530c4149a996394cd31aef6c()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_c720dd2e29d24c798369fa3f8354d447()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_1cd52e8b7a264ec8862cecd3a71bf122()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_2bf3c308fbf74629ac3f6074a49f09e5()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_2a97cd2fb80c49aeb6eeaed98f9d247c()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_d05dc9d8a00b4b20bcb07cdaab17a5cf()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_cea577fd57a34553a4b754dbfe7a4586()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_82d69e065f32417caf862946a7b325b8()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_408c1a6459ae40c39b1cf6222fe4ac96()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_fb672cf53d4a41039b2a405a8f4ecea5()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_ba01d4bde3184df087fb664accb0e4ed()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_1a4d6df89d5d4d6883cbb30f98130c8f()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_21bfd1af18b74bc1997ea9bd771432aa()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_4f2fc3c3310b45b08d43c0bd29befff1()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_cd7296b7af82427cb12326bab4e478f7()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_cb7f8cfb31a34739962f3b1baf4f2186()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_aec9d8b9d4684d3b9ad237e499a4a1c7()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_4d997365a4a645a5b50bb593ae6b6086()
        }));
        this.AddMember("Dispose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Dispose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_b05841dbcf1e4fcba1301cc70737cf4e()
        }));
        this.AddMember("drawImage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawImage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_2a7fe1c74b564b2c94b7d0a0c14ca09e()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_a1d25591a81948c4927caf17049a1999()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_67883e45d0684f9e91b94cdb9b4da9fc()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_2d738453fb084d4094172314f3967736()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_a3abf75725624745a6defb22f015ea25()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_6d1d76e41df64f9a98e65b394794308c()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_f7180f40011b43d2bdde6dac72456179()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_4f6900279344463fad81123bdd3c39c8()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_f505fe6219f845f8b478f9ef0eff2fbf()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_31d2ecfb29d340aabfefb4aa25214f63()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_65c5e1c7c70047ecb2f56d9a0f0ee7a6()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_c7da4beebd0f405d87dd557f60e7a7d9()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_843732ce5f98464d962f64de3d60c73b()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_26e945d229814d649f4aa8d149ae4057()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_a7ed51e3c99c4035b4f5f31a9952fdfc()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_41ae2ebf4c20455dbd3a92bc1cedaff4()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_7240afca7bc14f12aa18bdd6cd359411()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_ba6bc4ebce19425f8e3c8c48688081ed()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_a054c58dcf2847b0a9013ccda0f36755()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_669f915d7bc44f9098c5c15f5cfd61e8()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_e5f249fc737a46618438e8fb277bacc9()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_98f918019ac74058a266bd3a0cf679ff()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_05c1b15e760749738f3110296e0d069c()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_9c859967ea8942c9b26c5aee63c1c75a()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_8ddfee29d5364b0fb85bd4960d1d89b6()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_5503e9073021448894c71ca9e2d44cdc()
        }));
        this.AddMember("cameraFollow", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("cameraFollow", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_d0ef6c4b526449deb54fbc9cc7ed66ef()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_a346fcda73c346fc954b67d53206c5e5()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_5de9cc3f98da43a6b3abf70af75c476f()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_9c086c6d24d046b2a097aad832b9e166()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_d7de08cfc4e6466ba1c9c7af86c2098e()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_2a77dfc8a80e42b68041068171a4a039()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_ee9fac8f343942d1bed24e581c88330a(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_4956e2e9de064b34bb4e49f68a9f1d41()
        }));
        this.AddMember("getKeyBinds", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getKeyBinds", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_b960b31985214b75b38a2c79724e701d()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_36d561d720a74748898c82c78f24b0d2()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_07e02e865ae34502b24ba0eea0d09b5f()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_be7e6e79e129466990ec9cab34716c38()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.MTHD_9a605ff9a9ca4f6381c9a09a1f964974()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_b1ac79d86b3b4f6b93ab647972289a7a());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_543ea32b3052452cb51c4445e208f8df());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_963e5d5a63d147d9a81d7dc98878e748());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_579decece9d8466780d6ce54e4d95e99());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_adab39fed1dc43a7ba444d7181f2a7eb());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_812fe97b7b954e88b7cbf6ec4a2ce6ef());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_7454bff1ac524bc4807e0da6b0f7caac());
        this.AddMember("allowMinionMovement", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_7adecec20cf248e88cc34fc4eebc86b6());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_65d3a3f4ab214bfc96214e2d895cc559());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_d7e05cd64162471c9f5c38c56ee585ad());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_98547f1559c04489aa8a9b8a124b66a7());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_a230b394d6e4460388aa6d3738d0b9fd());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_226f384c7789456fbafb69337eea0fd2());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_61cc6c8b264e49ff860187dcfa43cdcc());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_6ff280b6b8724218904c3fc2766eed36());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_5227d31a79304cfa9f91890dbd8fc9b8());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_d2020fc000cc4bcfbd9bf0227d20ac2c());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_9a9bfcbf4c8045e18ec121a2cd449412());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_c46647a18136497195e27ad6915cc1e3());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_2a9cefed93d048349efb43b71cdce515());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_fe3a7bfde2914590bf3890fc59567ab8());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_4ed647f5ff634d2f9767ca026e57ae88());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_b5fcc78e55694c5fb9956319da049283());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_3b35d6896a9b43698d5041237bba0fc4());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_441ca3e654514705bfea0cd17410342e());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_4c197584de34402ea6192673fd4a2370());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_d9e0c8e93dbc4e7c8b0fb6f759b616e4());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_e9405c1ce73f4e05af85445d3d9f3ce1());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_28c38779b3d14336a51ed95ce75e6c0c());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_5f4d0826a3de415198846bac1e711810());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_78930da037f74eaf961a29ec7e9e399b());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_2415d9f0904a45a8ab6e7ecb03454be4());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_1dd98a686ccf4517b6dee2baa691dffd.PROP_d2e6da8dfa724813820520f6fe386181());
      }

      private sealed class MTHD_9bd57668a4884f20a9e13dbd2a43552d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9bd57668a4884f20a9e13dbd2a43552d()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_42ff8cff90fd47c58389aa3d1c62484e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42ff8cff90fd47c58389aa3d1c62484e()
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

      private sealed class MTHD_aa02655d81de43978b0f895fc0000d68 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa02655d81de43978b0f895fc0000d68()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_3057932b5fda4bd3a6efd7c7dac79bc3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3057932b5fda4bd3a6efd7c7dac79bc3()
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

      private sealed class MTHD_c5a5132f25bb4a6bb3ff7e7fe64b23ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c5a5132f25bb4a6bb3ff7e7fe64b23ca()
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

      private sealed class MTHD_f802821968494eea9e186123a72dc668 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f802821968494eea9e186123a72dc668()
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

      private sealed class MTHD_58b3f097c5b145239320156bd81061da : HardwiredMethodMemberDescriptor
      {
        internal MTHD_58b3f097c5b145239320156bd81061da()
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

      private sealed class MTHD_949f5d647ac5440eb3569d295666cada : HardwiredMethodMemberDescriptor
      {
        internal MTHD_949f5d647ac5440eb3569d295666cada()
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

      private sealed class MTHD_3b2d5fae26624c64b6d39a842209b922 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3b2d5fae26624c64b6d39a842209b922()
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

      private sealed class MTHD_d564f55ebc734ed1bd15dce6fe9d58de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d564f55ebc734ed1bd15dce6fe9d58de()
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

      private sealed class MTHD_17a88b88e25b47a2900e7f3b18708488 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_17a88b88e25b47a2900e7f3b18708488()
        {
          this.Initialize("hideInfo", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).hideInfo();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9debf502b3794850a23137dbc78091e2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9debf502b3794850a23137dbc78091e2()
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

      private sealed class MTHD_05f18bc8af764005a56d521c1e36c599 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_05f18bc8af764005a56d521c1e36c599()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_ce953ef9366b4796adad5c175e95a6cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ce953ef9366b4796adad5c175e95a6cf()
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

      private sealed class MTHD_be3760e1f1244141810b26ea63a05ce7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be3760e1f1244141810b26ea63a05ce7()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_a37b94147c80406a9037d9624ec3157d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a37b94147c80406a9037d9624ec3157d()
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

      private sealed class MTHD_986624cb7516421b91533ad5113958c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_986624cb7516421b91533ad5113958c6()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_f000f887ec02445eb61a5e318531c0a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f000f887ec02445eb61a5e318531c0a8()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_8102f7736d894a2fba6fc67eb46bbf09 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8102f7736d894a2fba6fc67eb46bbf09()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_35a23303d0c3450d8bee3b51ea83d5e6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35a23303d0c3450d8bee3b51ea83d5e6()
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

      private sealed class MTHD_6bd43b52826a48c3b14d2d119bd8abc5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6bd43b52826a48c3b14d2d119bd8abc5()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_5ab7d2bc5b4645fa9ff30fd614b37443 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ab7d2bc5b4645fa9ff30fd614b37443()
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

      private sealed class MTHD_f1089d5ba2f4445a9fbe5ba26f5d22ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f1089d5ba2f4445a9fbe5ba26f5d22ea()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_99fc2de4b6d64cd0a8cf05e12ef19afd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99fc2de4b6d64cd0a8cf05e12ef19afd()
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

      private sealed class MTHD_1c255d02887c4ab7abdf848529e83a14 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c255d02887c4ab7abdf848529e83a14()
        {
          this.Initialize("get_allowMinionMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMinionMovement;
        }
      }

      private sealed class MTHD_5e60b962a0db4a49b5b2073513143c90 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e60b962a0db4a49b5b2073513143c90()
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

      private sealed class MTHD_476c418271e74291bc6fe4669d2f60a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_476c418271e74291bc6fe4669d2f60a2()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_ab13ec6e9a064743bb1d5fd1022168b1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab13ec6e9a064743bb1d5fd1022168b1()
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

      private sealed class MTHD_c28dc5c55c0f4e83b7c03c4ed4e7f8b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c28dc5c55c0f4e83b7c03c4ed4e7f8b6()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_fab1af6cff524c45a5fc4ec35214ab26 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fab1af6cff524c45a5fc4ec35214ab26()
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

      private sealed class MTHD_a298631a2457461f9ad63c6ceebd6f83 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a298631a2457461f9ad63c6ceebd6f83()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_92fbbef298d14766a2d0c8dec10def66 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_92fbbef298d14766a2d0c8dec10def66()
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

      private sealed class MTHD_d7d654567c0d45eca63f1a561c292c5a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d7d654567c0d45eca63f1a561c292c5a()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_c0952238774147549047fdf51cde829d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c0952238774147549047fdf51cde829d()
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

      private sealed class MTHD_dc586ceacca8411fa99ebf3d679c8071 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc586ceacca8411fa99ebf3d679c8071()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_f30e7522766b4d56839bbf7879738fdf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f30e7522766b4d56839bbf7879738fdf()
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

      private sealed class MTHD_34fd6989ea794913a7d7bac72f0e0b99 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_34fd6989ea794913a7d7bac72f0e0b99()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_779ec29b315a4423b5767a0231e3ac8e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_779ec29b315a4423b5767a0231e3ac8e()
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

      private sealed class MTHD_bf1a862f37ab41d8a2238bd00503c409 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf1a862f37ab41d8a2238bd00503c409()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_ef4da817c70c4bf5843d09dbe40c75dd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef4da817c70c4bf5843d09dbe40c75dd()
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

      private sealed class MTHD_dbfacaaeab4b482abe2c66ee95cb73b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dbfacaaeab4b482abe2c66ee95cb73b9()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_e6afe6f90a2741d6b61b4bb45539608d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e6afe6f90a2741d6b61b4bb45539608d()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_43b11ca4a7ee4a31b7b838039a9a750a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_43b11ca4a7ee4a31b7b838039a9a750a()
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

      private sealed class MTHD_38e686e737174b73909136e94a28dcf6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_38e686e737174b73909136e94a28dcf6()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_5809c1db68b547bda3be5ab2a66bab38 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5809c1db68b547bda3be5ab2a66bab38()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_845bdad349de498e8eceb736b70f0eb5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_845bdad349de498e8eceb736b70f0eb5()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_fc3f704ec04a44eca592955b8e8c0896 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fc3f704ec04a44eca592955b8e8c0896()
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

      private sealed class MTHD_eb3f9147530c4149a996394cd31aef6c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb3f9147530c4149a996394cd31aef6c()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_c720dd2e29d24c798369fa3f8354d447 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c720dd2e29d24c798369fa3f8354d447()
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

      private sealed class MTHD_1cd52e8b7a264ec8862cecd3a71bf122 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1cd52e8b7a264ec8862cecd3a71bf122()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_2bf3c308fbf74629ac3f6074a49f09e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2bf3c308fbf74629ac3f6074a49f09e5()
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

      private sealed class MTHD_2a97cd2fb80c49aeb6eeaed98f9d247c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a97cd2fb80c49aeb6eeaed98f9d247c()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_d05dc9d8a00b4b20bcb07cdaab17a5cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d05dc9d8a00b4b20bcb07cdaab17a5cf()
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

      private sealed class MTHD_cea577fd57a34553a4b754dbfe7a4586 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cea577fd57a34553a4b754dbfe7a4586()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_82d69e065f32417caf862946a7b325b8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_82d69e065f32417caf862946a7b325b8()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_408c1a6459ae40c39b1cf6222fe4ac96 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_408c1a6459ae40c39b1cf6222fe4ac96()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_fb672cf53d4a41039b2a405a8f4ecea5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb672cf53d4a41039b2a405a8f4ecea5()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_ba01d4bde3184df087fb664accb0e4ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba01d4bde3184df087fb664accb0e4ed()
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

      private sealed class MTHD_1a4d6df89d5d4d6883cbb30f98130c8f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a4d6df89d5d4d6883cbb30f98130c8f()
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

      private sealed class MTHD_21bfd1af18b74bc1997ea9bd771432aa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_21bfd1af18b74bc1997ea9bd771432aa()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_4f2fc3c3310b45b08d43c0bd29befff1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4f2fc3c3310b45b08d43c0bd29befff1()
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

      private sealed class MTHD_cd7296b7af82427cb12326bab4e478f7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd7296b7af82427cb12326bab4e478f7()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_cb7f8cfb31a34739962f3b1baf4f2186 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cb7f8cfb31a34739962f3b1baf4f2186()
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

      private sealed class MTHD_aec9d8b9d4684d3b9ad237e499a4a1c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aec9d8b9d4684d3b9ad237e499a4a1c7()
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

      private sealed class MTHD_4d997365a4a645a5b50bb593ae6b6086 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d997365a4a645a5b50bb593ae6b6086()
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

      private sealed class MTHD_b05841dbcf1e4fcba1301cc70737cf4e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b05841dbcf1e4fcba1301cc70737cf4e()
        {
          this.Initialize("Dispose", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ContainerGame.Dispose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_2a7fe1c74b564b2c94b7d0a0c14ca09e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a7fe1c74b564b2c94b7d0a0c14ca09e()
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

      private sealed class MTHD_a1d25591a81948c4927caf17049a1999 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1d25591a81948c4927caf17049a1999()
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

      private sealed class MTHD_67883e45d0684f9e91b94cdb9b4da9fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67883e45d0684f9e91b94cdb9b4da9fc()
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

      private sealed class MTHD_2d738453fb084d4094172314f3967736 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d738453fb084d4094172314f3967736()
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

      private sealed class MTHD_a3abf75725624745a6defb22f015ea25 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a3abf75725624745a6defb22f015ea25()
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

      private sealed class MTHD_6d1d76e41df64f9a98e65b394794308c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d1d76e41df64f9a98e65b394794308c()
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

      private sealed class MTHD_f7180f40011b43d2bdde6dac72456179 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7180f40011b43d2bdde6dac72456179()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_4f6900279344463fad81123bdd3c39c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4f6900279344463fad81123bdd3c39c8()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_f505fe6219f845f8b478f9ef0eff2fbf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f505fe6219f845f8b478f9ef0eff2fbf()
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

      private sealed class MTHD_31d2ecfb29d340aabfefb4aa25214f63 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_31d2ecfb29d340aabfefb4aa25214f63()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_65c5e1c7c70047ecb2f56d9a0f0ee7a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65c5e1c7c70047ecb2f56d9a0f0ee7a6()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c7da4beebd0f405d87dd557f60e7a7d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c7da4beebd0f405d87dd557f60e7a7d9()
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

      private sealed class MTHD_843732ce5f98464d962f64de3d60c73b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_843732ce5f98464d962f64de3d60c73b()
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

      private sealed class MTHD_26e945d229814d649f4aa8d149ae4057 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_26e945d229814d649f4aa8d149ae4057()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_a7ed51e3c99c4035b4f5f31a9952fdfc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a7ed51e3c99c4035b4f5f31a9952fdfc()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_41ae2ebf4c20455dbd3a92bc1cedaff4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41ae2ebf4c20455dbd3a92bc1cedaff4()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_7240afca7bc14f12aa18bdd6cd359411 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7240afca7bc14f12aa18bdd6cd359411()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ba6bc4ebce19425f8e3c8c48688081ed : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba6bc4ebce19425f8e3c8c48688081ed()
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

      private sealed class MTHD_a054c58dcf2847b0a9013ccda0f36755 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a054c58dcf2847b0a9013ccda0f36755()
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

      private sealed class MTHD_669f915d7bc44f9098c5c15f5cfd61e8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_669f915d7bc44f9098c5c15f5cfd61e8()
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

      private sealed class MTHD_e5f249fc737a46618438e8fb277bacc9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e5f249fc737a46618438e8fb277bacc9()
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

      private sealed class MTHD_98f918019ac74058a266bd3a0cf679ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_98f918019ac74058a266bd3a0cf679ff()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_05c1b15e760749738f3110296e0d069c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_05c1b15e760749738f3110296e0d069c()
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

      private sealed class MTHD_9c859967ea8942c9b26c5aee63c1c75a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c859967ea8942c9b26c5aee63c1c75a()
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

      private sealed class MTHD_8ddfee29d5364b0fb85bd4960d1d89b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ddfee29d5364b0fb85bd4960d1d89b6()
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

      private sealed class MTHD_5503e9073021448894c71ca9e2d44cdc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5503e9073021448894c71ca9e2d44cdc()
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

      private sealed class MTHD_d0ef6c4b526449deb54fbc9cc7ed66ef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0ef6c4b526449deb54fbc9cc7ed66ef()
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

      private sealed class MTHD_a346fcda73c346fc954b67d53206c5e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a346fcda73c346fc954b67d53206c5e5()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_5de9cc3f98da43a6b3abf70af75c476f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5de9cc3f98da43a6b3abf70af75c476f()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_9c086c6d24d046b2a097aad832b9e166 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c086c6d24d046b2a097aad832b9e166()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_d7de08cfc4e6466ba1c9c7af86c2098e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d7de08cfc4e6466ba1c9c7af86c2098e()
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

      private sealed class MTHD_2a77dfc8a80e42b68041068171a4a039 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a77dfc8a80e42b68041068171a4a039()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ee9fac8f343942d1bed24e581c88330a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee9fac8f343942d1bed24e581c88330a()
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

      private sealed class MTHD_4956e2e9de064b34bb4e49f68a9f1d41 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4956e2e9de064b34bb4e49f68a9f1d41()
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

      private sealed class MTHD_b960b31985214b75b38a2c79724e701d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b960b31985214b75b38a2c79724e701d()
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

      private sealed class MTHD_36d561d720a74748898c82c78f24b0d2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_36d561d720a74748898c82c78f24b0d2()
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

      private sealed class MTHD_07e02e865ae34502b24ba0eea0d09b5f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_07e02e865ae34502b24ba0eea0d09b5f()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_be7e6e79e129466990ec9cab34716c38 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be7e6e79e129466990ec9cab34716c38()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_9a605ff9a9ca4f6381c9a09a1f964974 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9a605ff9a9ca4f6381c9a09a1f964974()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_b1ac79d86b3b4f6b93ab647972289a7a : HardwiredMemberDescriptor
      {
        internal PROP_b1ac79d86b3b4f6b93ab647972289a7a()
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

      private sealed class PROP_543ea32b3052452cb51c4445e208f8df : HardwiredMemberDescriptor
      {
        internal PROP_543ea32b3052452cb51c4445e208f8df()
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

      private sealed class PROP_963e5d5a63d147d9a81d7dc98878e748 : HardwiredMemberDescriptor
      {
        internal PROP_963e5d5a63d147d9a81d7dc98878e748()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_579decece9d8466780d6ce54e4d95e99 : HardwiredMemberDescriptor
      {
        internal PROP_579decece9d8466780d6ce54e4d95e99()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_adab39fed1dc43a7ba444d7181f2a7eb : HardwiredMemberDescriptor
      {
        internal PROP_adab39fed1dc43a7ba444d7181f2a7eb()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_812fe97b7b954e88b7cbf6ec4a2ce6ef : HardwiredMemberDescriptor
      {
        internal PROP_812fe97b7b954e88b7cbf6ec4a2ce6ef()
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

      private sealed class PROP_7454bff1ac524bc4807e0da6b0f7caac : HardwiredMemberDescriptor
      {
        internal PROP_7454bff1ac524bc4807e0da6b0f7caac()
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

      private sealed class PROP_7adecec20cf248e88cc34fc4eebc86b6 : HardwiredMemberDescriptor
      {
        internal PROP_7adecec20cf248e88cc34fc4eebc86b6()
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

      private sealed class PROP_65d3a3f4ab214bfc96214e2d895cc559 : HardwiredMemberDescriptor
      {
        internal PROP_65d3a3f4ab214bfc96214e2d895cc559()
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

      private sealed class PROP_d7e05cd64162471c9f5c38c56ee585ad : HardwiredMemberDescriptor
      {
        internal PROP_d7e05cd64162471c9f5c38c56ee585ad()
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

      private sealed class PROP_98547f1559c04489aa8a9b8a124b66a7 : HardwiredMemberDescriptor
      {
        internal PROP_98547f1559c04489aa8a9b8a124b66a7()
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

      private sealed class PROP_a230b394d6e4460388aa6d3738d0b9fd : HardwiredMemberDescriptor
      {
        internal PROP_a230b394d6e4460388aa6d3738d0b9fd()
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

      private sealed class PROP_226f384c7789456fbafb69337eea0fd2 : HardwiredMemberDescriptor
      {
        internal PROP_226f384c7789456fbafb69337eea0fd2()
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

      private sealed class PROP_61cc6c8b264e49ff860187dcfa43cdcc : HardwiredMemberDescriptor
      {
        internal PROP_61cc6c8b264e49ff860187dcfa43cdcc()
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

      private sealed class PROP_6ff280b6b8724218904c3fc2766eed36 : HardwiredMemberDescriptor
      {
        internal PROP_6ff280b6b8724218904c3fc2766eed36()
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

      private sealed class PROP_5227d31a79304cfa9f91890dbd8fc9b8 : HardwiredMemberDescriptor
      {
        internal PROP_5227d31a79304cfa9f91890dbd8fc9b8()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_d2020fc000cc4bcfbd9bf0227d20ac2c : HardwiredMemberDescriptor
      {
        internal PROP_d2020fc000cc4bcfbd9bf0227d20ac2c()
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

      private sealed class PROP_9a9bfcbf4c8045e18ec121a2cd449412 : HardwiredMemberDescriptor
      {
        internal PROP_9a9bfcbf4c8045e18ec121a2cd449412()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_c46647a18136497195e27ad6915cc1e3 : HardwiredMemberDescriptor
      {
        internal PROP_c46647a18136497195e27ad6915cc1e3()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_2a9cefed93d048349efb43b71cdce515 : HardwiredMemberDescriptor
      {
        internal PROP_2a9cefed93d048349efb43b71cdce515()
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

      private sealed class PROP_fe3a7bfde2914590bf3890fc59567ab8 : HardwiredMemberDescriptor
      {
        internal PROP_fe3a7bfde2914590bf3890fc59567ab8()
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

      private sealed class PROP_4ed647f5ff634d2f9767ca026e57ae88 : HardwiredMemberDescriptor
      {
        internal PROP_4ed647f5ff634d2f9767ca026e57ae88()
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

      private sealed class PROP_b5fcc78e55694c5fb9956319da049283 : HardwiredMemberDescriptor
      {
        internal PROP_b5fcc78e55694c5fb9956319da049283()
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

      private sealed class PROP_3b35d6896a9b43698d5041237bba0fc4 : HardwiredMemberDescriptor
      {
        internal PROP_3b35d6896a9b43698d5041237bba0fc4()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_441ca3e654514705bfea0cd17410342e : HardwiredMemberDescriptor
      {
        internal PROP_441ca3e654514705bfea0cd17410342e()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_4c197584de34402ea6192673fd4a2370 : HardwiredMemberDescriptor
      {
        internal PROP_4c197584de34402ea6192673fd4a2370()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_d9e0c8e93dbc4e7c8b0fb6f759b616e4 : HardwiredMemberDescriptor
      {
        internal PROP_d9e0c8e93dbc4e7c8b0fb6f759b616e4()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_e9405c1ce73f4e05af85445d3d9f3ce1 : HardwiredMemberDescriptor
      {
        internal PROP_e9405c1ce73f4e05af85445d3d9f3ce1()
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

      private sealed class PROP_28c38779b3d14336a51ed95ce75e6c0c : HardwiredMemberDescriptor
      {
        internal PROP_28c38779b3d14336a51ed95ce75e6c0c()
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

      private sealed class PROP_5f4d0826a3de415198846bac1e711810 : HardwiredMemberDescriptor
      {
        internal PROP_5f4d0826a3de415198846bac1e711810()
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

      private sealed class PROP_78930da037f74eaf961a29ec7e9e399b : HardwiredMemberDescriptor
      {
        internal PROP_78930da037f74eaf961a29ec7e9e399b()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_2415d9f0904a45a8ab6e7ecb03454be4 : HardwiredMemberDescriptor
      {
        internal PROP_2415d9f0904a45a8ab6e7ecb03454be4()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_d2e6da8dfa724813820520f6fe386181 : HardwiredMemberDescriptor
      {
        internal PROP_d2e6da8dfa724813820520f6fe386181()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_91a41ecdd90a43cb9a24b7985d40dd4b : HardwiredUserDataDescriptor
    {
      internal TYPE_91a41ecdd90a43cb9a24b7985d40dd4b()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91a41ecdd90a43cb9a24b7985d40dd4b.MTHD_a895104967f74e12a0ec3dd000ae10a3()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91a41ecdd90a43cb9a24b7985d40dd4b.MTHD_298567771f814092b73eff771186a5d8()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91a41ecdd90a43cb9a24b7985d40dd4b.MTHD_f38fd33a4efe487196bfdaa357abb083()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91a41ecdd90a43cb9a24b7985d40dd4b.MTHD_97ab827e3fc54379841e16baf0a70db0()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91a41ecdd90a43cb9a24b7985d40dd4b.MTHD_dee36920e44840da96a08266b1888fd7()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91a41ecdd90a43cb9a24b7985d40dd4b.MTHD_640c46ebc9ea4da2b002a8c8d175b28f()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91a41ecdd90a43cb9a24b7985d40dd4b.MTHD_8452ee83036647b1842dd270ceea55e6()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91a41ecdd90a43cb9a24b7985d40dd4b.MTHD_d1058f6e19a941a7b3e4e671b4fcb44d()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91a41ecdd90a43cb9a24b7985d40dd4b.MTHD_98562dfae3dd4d59b3cc0bd7b737f596()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91a41ecdd90a43cb9a24b7985d40dd4b.MTHD_15ad471188d6480dbedb12353b8f1767()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91a41ecdd90a43cb9a24b7985d40dd4b.MTHD_4c8316307d60438a97b8e34beb6f63f4()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91a41ecdd90a43cb9a24b7985d40dd4b.MTHD_75fafbd06d7f4c2ca5ae06d6486e4a03()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_91a41ecdd90a43cb9a24b7985d40dd4b.PROP_57d3d722fad0498480d51b42cfc2e69d());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_91a41ecdd90a43cb9a24b7985d40dd4b.PROP_316e0d270ee4478c9da09037cddb5b96());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_91a41ecdd90a43cb9a24b7985d40dd4b.PROP_16c0aec12d6a4809b7eb4abcbdffc56e());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_91a41ecdd90a43cb9a24b7985d40dd4b.PROP_46a2430435e04eea94c5f470d49f0ad8());
      }

      private sealed class MTHD_a895104967f74e12a0ec3dd000ae10a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a895104967f74e12a0ec3dd000ae10a3()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_298567771f814092b73eff771186a5d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_298567771f814092b73eff771186a5d8()
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

      private sealed class MTHD_f38fd33a4efe487196bfdaa357abb083 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f38fd33a4efe487196bfdaa357abb083()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_97ab827e3fc54379841e16baf0a70db0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97ab827e3fc54379841e16baf0a70db0()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_dee36920e44840da96a08266b1888fd7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dee36920e44840da96a08266b1888fd7()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_640c46ebc9ea4da2b002a8c8d175b28f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_640c46ebc9ea4da2b002a8c8d175b28f()
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

      private sealed class MTHD_8452ee83036647b1842dd270ceea55e6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8452ee83036647b1842dd270ceea55e6()
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

      private sealed class MTHD_d1058f6e19a941a7b3e4e671b4fcb44d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d1058f6e19a941a7b3e4e671b4fcb44d()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_98562dfae3dd4d59b3cc0bd7b737f596 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_98562dfae3dd4d59b3cc0bd7b737f596()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_15ad471188d6480dbedb12353b8f1767 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15ad471188d6480dbedb12353b8f1767()
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

      private sealed class MTHD_4c8316307d60438a97b8e34beb6f63f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c8316307d60438a97b8e34beb6f63f4()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_75fafbd06d7f4c2ca5ae06d6486e4a03 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75fafbd06d7f4c2ca5ae06d6486e4a03()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_57d3d722fad0498480d51b42cfc2e69d : HardwiredMemberDescriptor
      {
        internal PROP_57d3d722fad0498480d51b42cfc2e69d()
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

      private sealed class PROP_316e0d270ee4478c9da09037cddb5b96 : HardwiredMemberDescriptor
      {
        internal PROP_316e0d270ee4478c9da09037cddb5b96()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_16c0aec12d6a4809b7eb4abcbdffc56e : HardwiredMemberDescriptor
      {
        internal PROP_16c0aec12d6a4809b7eb4abcbdffc56e()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_46a2430435e04eea94c5f470d49f0ad8 : HardwiredMemberDescriptor
      {
        internal PROP_46a2430435e04eea94c5f470d49f0ad8()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_cc9f185623364cbf821b0aa1123413f2 : HardwiredUserDataDescriptor
    {
      internal TYPE_cc9f185623364cbf821b0aa1123413f2()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_3c8880f10dda41d9a1e39826bcbcc03d()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_478b2f8a780a4c7f8d3ddb9d9384c92b()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_49b04e280b3643af80ae4820fc6893bf()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_7ce0e48a2b444807b1156b911838c84d()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_21936c399dd74504ae7e33a50b6e298e()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_2a9e7e9ceed0471daa805439f945be6e()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_73c0deadb21b4c89b92fd0ad53f46d7d()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_0cf9d0614b6d47b9b2c9ec57af36b34f()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_b103210afff74b31bbce012fe3d95896()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_146facb0f43c45fcacf15b48ead72cdd()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_15e5a90fa3c0434da7e6556373c8e293()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_6e4ee76a92fa48c0810dd207f9085355()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_f8f9480bfe674b4e90e30c5110623470()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_ab0d3fb5ee5b492787c4f98fde275ab4()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_3d9ffc5b9abe4292b09e6512b64d76a1()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_0ec9d1ebeec44462aee177d3dfedb429()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_81a6b4f032c349d5bb22342389ec5041()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_149fb9c74a9b4cc185fbf409e538f726()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_ed0b7811be7e490fb1f6d7b0e82e5bbf()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_5250636df0284d37a6c54bc0e5474078()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_0847705e093d410fba0197a535eb0601()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_15047169c5c04f66990e1551c987ee9a()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_8362c28cc3f747a8816f662882db71b6()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_d80660b9f45e4509bc6412fbdde50731()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_eec082d26dbf495486eb85f782b823c5()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_88403cd9b7df4150a60302698b6b4908()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_a88ca0033cf242c68703e35cdac9514c()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_6571edca21f643f280f8777152c667a1()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_d0e2fbeaf9b54e11a2e85f1f07fa1a48()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_f7c05101e29d4194bfe05bf4cb65ba12()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_ca64875d622548f2912d4926647072cd()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_15038b60005f4e6488403c0e87395d3a()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_d6d88deb774c4a678a699ce908509f62()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_1c036f06a5274076a1b69a9a68fda0a7()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_9e18b89b19154468bc5e19ae6abce540()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_2190e92c848d4b0e833b0ea0c4204174()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_b8c446389041496384f6b8e45069a53f()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_ac3849856c674c0093f491b800a2fce8()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_32cea8f9fec94a578b227e845d9b4f1a()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_045265dd2ecd4e2d88ee2ca1bf4ba13e()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_4691c8d675f2459c8005614c378473a7()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_9aaacfb24e1c40f89276c643c66284cf()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_fe287e20553444559574721e5ceaba2e()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_b76efa0d1d444f5a8c10e4478a507c6c()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_0959e0867cc04bd5bf9293c4e5eb60b9()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_c64177d6beda4a8789bd1f6eb27004c3()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_8be38b66c86f44ef8c98b8c86cf33d2a()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_2c4b36d374d14182b49f0ed311e74d04()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_8b88bdb680fb46f1b2cd7d0c37ff6dd2()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_8c43735565964fa3a32a8e95269c93eb()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_8830a612fb8443d09087c3dcb86600a6()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_22aa7fec6cfa4cae8460d3b88e21c308()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_93ec236d564949cabac0f1038088a36a()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_dde5628da611422b8975b7af1801f30f()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_d9bb247c07704d82bea6143495f49600()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_cf22f34dc1754e08b90699b33d17fdc9()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_1345eee833c24245a72906ec9e556694()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_92997b5fb75843e3888a8f2a405c9471()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_f5f7e20b399240b8ac2e2202863afd46()
        }));
        this.AddMember("getDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_82d43dbba04a4b56b48db1ffa4de1133()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_cd8ce0e5cdd94cef9954d9581b0ca39c()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_108d8c1f5416462eaac7116b11aee9cc()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_603b041c67064388b54172c544a965cc()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_8b881bbb7d3e4a5e88251355bc67a281()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_d9e143b4d2e04aaea107e3de68da82ae(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_8d65b7a9351f430481d953a1832de8ea()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_40a8a669c70344378b02801f91002c38(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_736d4ddf2e0e415797f089bce5fdc6e3()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_02a8f42b808e48a5b95a727bb16a6210()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_5f33d3e9f81b46baaa5d234b0df554a9()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_da7050d49b79494cb4d95bee1d5f7d7f(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_3510b197747746bb9c3ccaaa9850e964()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_0863c24f695d4223acd15db48fa8a51c()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_e4bc062c6d1a4d5698a88dbe33c7d4dd()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_9b49580914664f1f83070e82f2cff259()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_61c67960b52947c29cc932cdfc03a928()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_866e91b9779a4866bab5b8c53aeae6c9()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_29700b6b5691471fb58c8f308e7f83d2()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_b32a8acc51584941a4583dcd582386ca()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_9b44615d2469454d9c71295d5e1c671c()
        }));
        this.AddMember("angleToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("angleToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_eff27928d057480f9220de79d25a2e4b()
        }));
        this.AddMember("powerToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("powerToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_0e9bd5ac99e846b7a88253ee3ba00a98()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_131e40ebf7a840dea56eaae391e32fda(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_ba183237677d4a5f84f3af828da3b730()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_57e86a879e3c4294965bb377c48a39b7(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_790f1d11fc024481b26adc1d7366202d()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_08a7fcaa89d64bc4a2ce6d590eaccb33()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_a66b5f9ad4b14b28830f6890056c1e8c()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_506a6b4e7c0446d88ace0b9cfd8ff114()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_77b9146a675544b6b1bce3dab36693ab()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_7c06d60d75574bada40f1dc29a9fc935()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.MTHD_d641b3819f3c4e978fc45e522ee69143()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_2890752242314e6d9eedaf1570b30d02());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_3c3a90a5e881480fbc3cd3ce2701c2d7());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_1d08ffafe6b142cbbf6eb11313aab450());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_f2c35cc294ff47399995f507e09af75e());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_bc92b40462e5481db16709f42e765882());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_f387bb29b4594611a3844c78dd3ff4d6());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_c315f6a465c3493d96236ebc156e5ce1());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_dbc9ca5d9bd74818b4717e5300a93d15());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_6c593adcd88244e18b35409f99a9b862());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_ec415d2fdae34ff2ab8b43a321edaa3e());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_42eaf88b9f3940bc84229ec801283631());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_68339e840e584ca1af89b6bc5dc6f372());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_5e7a778989254f8f8dcd9a22add29bdd());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_6cfd2317705d4fcd87e4bfc4b2797ae4());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_48c3deafb33e4cdba56c25098ca3655d());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_643b436b86db4e33a26a50dde3be8503());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_f53c44756f4947a19d5ec2eb83d58ac5());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_b307543ab54d4b6292ee8e4bcc847c14());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_cda7c9c9fd7a40de83a0cfe8afeca493());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_dab04d2248b44c7f845abe730b08ba24());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_2fdb899743904e598722d87efa5427e0());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_1b6db7c00212433ba0db4381327b8cfe());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_7596460ea1874d9bbfcd10fc63c782f0());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_413074c32b954681990761dfaeec22d0());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_bd2ecd528674458188fd3f24252e99dd());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_af3bdd1edaa24bf09ce5e24063f3280e());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_5f18159c848a44469c13ca55040ed9c8());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_da6c6be38e0c4a358d47f85923ff39f7());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_43587253ea5d4cf299e5eb91a0da0eb8());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_be6c059220714afb84c9851e0af55d20());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_67c10d46b62a402a8f09878a58d0386c());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_915a99742281488fad89062dd567e0a7());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_cc9f185623364cbf821b0aa1123413f2.PROP_c50ba3c1bd2e42a6a3666320be5e8c28());
      }

      private sealed class MTHD_3c8880f10dda41d9a1e39826bcbcc03d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3c8880f10dda41d9a1e39826bcbcc03d()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_478b2f8a780a4c7f8d3ddb9d9384c92b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_478b2f8a780a4c7f8d3ddb9d9384c92b()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_49b04e280b3643af80ae4820fc6893bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49b04e280b3643af80ae4820fc6893bf()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_7ce0e48a2b444807b1156b911838c84d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ce0e48a2b444807b1156b911838c84d()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_21936c399dd74504ae7e33a50b6e298e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_21936c399dd74504ae7e33a50b6e298e()
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

      private sealed class MTHD_2a9e7e9ceed0471daa805439f945be6e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a9e7e9ceed0471daa805439f945be6e()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_73c0deadb21b4c89b92fd0ad53f46d7d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_73c0deadb21b4c89b92fd0ad53f46d7d()
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

      private sealed class MTHD_0cf9d0614b6d47b9b2c9ec57af36b34f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0cf9d0614b6d47b9b2c9ec57af36b34f()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_b103210afff74b31bbce012fe3d95896 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b103210afff74b31bbce012fe3d95896()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_146facb0f43c45fcacf15b48ead72cdd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_146facb0f43c45fcacf15b48ead72cdd()
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

      private sealed class MTHD_15e5a90fa3c0434da7e6556373c8e293 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15e5a90fa3c0434da7e6556373c8e293()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_6e4ee76a92fa48c0810dd207f9085355 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e4ee76a92fa48c0810dd207f9085355()
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

      private sealed class MTHD_f8f9480bfe674b4e90e30c5110623470 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f8f9480bfe674b4e90e30c5110623470()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_ab0d3fb5ee5b492787c4f98fde275ab4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ab0d3fb5ee5b492787c4f98fde275ab4()
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

      private sealed class MTHD_3d9ffc5b9abe4292b09e6512b64d76a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d9ffc5b9abe4292b09e6512b64d76a1()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_0ec9d1ebeec44462aee177d3dfedb429 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ec9d1ebeec44462aee177d3dfedb429()
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

      private sealed class MTHD_81a6b4f032c349d5bb22342389ec5041 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_81a6b4f032c349d5bb22342389ec5041()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_149fb9c74a9b4cc185fbf409e538f726 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_149fb9c74a9b4cc185fbf409e538f726()
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

      private sealed class MTHD_ed0b7811be7e490fb1f6d7b0e82e5bbf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed0b7811be7e490fb1f6d7b0e82e5bbf()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_5250636df0284d37a6c54bc0e5474078 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5250636df0284d37a6c54bc0e5474078()
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

      private sealed class MTHD_0847705e093d410fba0197a535eb0601 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0847705e093d410fba0197a535eb0601()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_15047169c5c04f66990e1551c987ee9a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15047169c5c04f66990e1551c987ee9a()
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

      private sealed class MTHD_8362c28cc3f747a8816f662882db71b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8362c28cc3f747a8816f662882db71b6()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_d80660b9f45e4509bc6412fbdde50731 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d80660b9f45e4509bc6412fbdde50731()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_eec082d26dbf495486eb85f782b823c5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eec082d26dbf495486eb85f782b823c5()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_88403cd9b7df4150a60302698b6b4908 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_88403cd9b7df4150a60302698b6b4908()
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

      private sealed class MTHD_a88ca0033cf242c68703e35cdac9514c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a88ca0033cf242c68703e35cdac9514c()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_6571edca21f643f280f8777152c667a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6571edca21f643f280f8777152c667a1()
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

      private sealed class MTHD_d0e2fbeaf9b54e11a2e85f1f07fa1a48 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0e2fbeaf9b54e11a2e85f1f07fa1a48()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_f7c05101e29d4194bfe05bf4cb65ba12 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7c05101e29d4194bfe05bf4cb65ba12()
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

      private sealed class MTHD_ca64875d622548f2912d4926647072cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ca64875d622548f2912d4926647072cd()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_15038b60005f4e6488403c0e87395d3a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15038b60005f4e6488403c0e87395d3a()
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

      private sealed class MTHD_d6d88deb774c4a678a699ce908509f62 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6d88deb774c4a678a699ce908509f62()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_1c036f06a5274076a1b69a9a68fda0a7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c036f06a5274076a1b69a9a68fda0a7()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_9e18b89b19154468bc5e19ae6abce540 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e18b89b19154468bc5e19ae6abce540()
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

      private sealed class MTHD_2190e92c848d4b0e833b0ea0c4204174 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2190e92c848d4b0e833b0ea0c4204174()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_b8c446389041496384f6b8e45069a53f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b8c446389041496384f6b8e45069a53f()
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

      private sealed class MTHD_ac3849856c674c0093f491b800a2fce8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ac3849856c674c0093f491b800a2fce8()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_32cea8f9fec94a578b227e845d9b4f1a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_32cea8f9fec94a578b227e845d9b4f1a()
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

      private sealed class MTHD_045265dd2ecd4e2d88ee2ca1bf4ba13e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_045265dd2ecd4e2d88ee2ca1bf4ba13e()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_4691c8d675f2459c8005614c378473a7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4691c8d675f2459c8005614c378473a7()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_9aaacfb24e1c40f89276c643c66284cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9aaacfb24e1c40f89276c643c66284cf()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_fe287e20553444559574721e5ceaba2e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fe287e20553444559574721e5ceaba2e()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_b76efa0d1d444f5a8c10e4478a507c6c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b76efa0d1d444f5a8c10e4478a507c6c()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_0959e0867cc04bd5bf9293c4e5eb60b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0959e0867cc04bd5bf9293c4e5eb60b9()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_c64177d6beda4a8789bd1f6eb27004c3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c64177d6beda4a8789bd1f6eb27004c3()
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

      private sealed class MTHD_8be38b66c86f44ef8c98b8c86cf33d2a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8be38b66c86f44ef8c98b8c86cf33d2a()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_2c4b36d374d14182b49f0ed311e74d04 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c4b36d374d14182b49f0ed311e74d04()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_8b88bdb680fb46f1b2cd7d0c37ff6dd2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b88bdb680fb46f1b2cd7d0c37ff6dd2()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_8c43735565964fa3a32a8e95269c93eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c43735565964fa3a32a8e95269c93eb()
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

      private sealed class MTHD_8830a612fb8443d09087c3dcb86600a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8830a612fb8443d09087c3dcb86600a6()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_22aa7fec6cfa4cae8460d3b88e21c308 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_22aa7fec6cfa4cae8460d3b88e21c308()
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

      private sealed class MTHD_93ec236d564949cabac0f1038088a36a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93ec236d564949cabac0f1038088a36a()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_dde5628da611422b8975b7af1801f30f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dde5628da611422b8975b7af1801f30f()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_d9bb247c07704d82bea6143495f49600 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d9bb247c07704d82bea6143495f49600()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_cf22f34dc1754e08b90699b33d17fdc9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cf22f34dc1754e08b90699b33d17fdc9()
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

      private sealed class MTHD_1345eee833c24245a72906ec9e556694 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1345eee833c24245a72906ec9e556694()
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

      private sealed class MTHD_92997b5fb75843e3888a8f2a405c9471 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_92997b5fb75843e3888a8f2a405c9471()
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

      private sealed class MTHD_f5f7e20b399240b8ac2e2202863afd46 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f5f7e20b399240b8ac2e2202863afd46()
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

      private sealed class MTHD_82d43dbba04a4b56b48db1ffa4de1133 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_82d43dbba04a4b56b48db1ffa4de1133()
        {
          this.Initialize("getDirection", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getDirection();
        }
      }

      private sealed class MTHD_cd8ce0e5cdd94cef9954d9581b0ca39c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cd8ce0e5cdd94cef9954d9581b0ca39c()
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

      private sealed class MTHD_108d8c1f5416462eaac7116b11aee9cc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_108d8c1f5416462eaac7116b11aee9cc()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_603b041c67064388b54172c544a965cc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_603b041c67064388b54172c544a965cc()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_8b881bbb7d3e4a5e88251355bc67a281 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b881bbb7d3e4a5e88251355bc67a281()
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

      private sealed class MTHD_d9e143b4d2e04aaea107e3de68da82ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d9e143b4d2e04aaea107e3de68da82ae()
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

      private sealed class MTHD_8d65b7a9351f430481d953a1832de8ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8d65b7a9351f430481d953a1832de8ea()
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

      private sealed class MTHD_40a8a669c70344378b02801f91002c38 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_40a8a669c70344378b02801f91002c38()
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

      private sealed class MTHD_736d4ddf2e0e415797f089bce5fdc6e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_736d4ddf2e0e415797f089bce5fdc6e3()
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

      private sealed class MTHD_02a8f42b808e48a5b95a727bb16a6210 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_02a8f42b808e48a5b95a727bb16a6210()
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

      private sealed class MTHD_5f33d3e9f81b46baaa5d234b0df554a9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5f33d3e9f81b46baaa5d234b0df554a9()
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

      private sealed class MTHD_da7050d49b79494cb4d95bee1d5f7d7f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_da7050d49b79494cb4d95bee1d5f7d7f()
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

      private sealed class MTHD_3510b197747746bb9c3ccaaa9850e964 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3510b197747746bb9c3ccaaa9850e964()
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

      private sealed class MTHD_0863c24f695d4223acd15db48fa8a51c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0863c24f695d4223acd15db48fa8a51c()
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

      private sealed class MTHD_e4bc062c6d1a4d5698a88dbe33c7d4dd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e4bc062c6d1a4d5698a88dbe33c7d4dd()
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

      private sealed class MTHD_9b49580914664f1f83070e82f2cff259 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b49580914664f1f83070e82f2cff259()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_61c67960b52947c29cc932cdfc03a928 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_61c67960b52947c29cc932cdfc03a928()
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

      private sealed class MTHD_866e91b9779a4866bab5b8c53aeae6c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_866e91b9779a4866bab5b8c53aeae6c9()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_29700b6b5691471fb58c8f308e7f83d2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_29700b6b5691471fb58c8f308e7f83d2()
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

      private sealed class MTHD_b32a8acc51584941a4583dcd582386ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b32a8acc51584941a4583dcd582386ca()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_9b44615d2469454d9c71295d5e1c671c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b44615d2469454d9c71295d5e1c671c()
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

      private sealed class MTHD_eff27928d057480f9220de79d25a2e4b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eff27928d057480f9220de79d25a2e4b()
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

      private sealed class MTHD_0e9bd5ac99e846b7a88253ee3ba00a98 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e9bd5ac99e846b7a88253ee3ba00a98()
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

      private sealed class MTHD_131e40ebf7a840dea56eaae391e32fda : HardwiredMethodMemberDescriptor
      {
        internal MTHD_131e40ebf7a840dea56eaae391e32fda()
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

      private sealed class MTHD_ba183237677d4a5f84f3af828da3b730 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ba183237677d4a5f84f3af828da3b730()
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

      private sealed class MTHD_57e86a879e3c4294965bb377c48a39b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57e86a879e3c4294965bb377c48a39b7()
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

      private sealed class MTHD_790f1d11fc024481b26adc1d7366202d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_790f1d11fc024481b26adc1d7366202d()
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

      private sealed class MTHD_08a7fcaa89d64bc4a2ce6d590eaccb33 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_08a7fcaa89d64bc4a2ce6d590eaccb33()
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

      private sealed class MTHD_a66b5f9ad4b14b28830f6890056c1e8c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a66b5f9ad4b14b28830f6890056c1e8c()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_506a6b4e7c0446d88ace0b9cfd8ff114 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_506a6b4e7c0446d88ace0b9cfd8ff114()
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

      private sealed class MTHD_77b9146a675544b6b1bce3dab36693ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_77b9146a675544b6b1bce3dab36693ab()
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

      private sealed class MTHD_7c06d60d75574bada40f1dc29a9fc935 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7c06d60d75574bada40f1dc29a9fc935()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_d641b3819f3c4e978fc45e522ee69143 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d641b3819f3c4e978fc45e522ee69143()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_2890752242314e6d9eedaf1570b30d02 : HardwiredMemberDescriptor
      {
        internal PROP_2890752242314e6d9eedaf1570b30d02()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_3c3a90a5e881480fbc3cd3ce2701c2d7 : HardwiredMemberDescriptor
      {
        internal PROP_3c3a90a5e881480fbc3cd3ce2701c2d7()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_1d08ffafe6b142cbbf6eb11313aab450 : HardwiredMemberDescriptor
      {
        internal PROP_1d08ffafe6b142cbbf6eb11313aab450()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_f2c35cc294ff47399995f507e09af75e : HardwiredMemberDescriptor
      {
        internal PROP_f2c35cc294ff47399995f507e09af75e()
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

      private sealed class PROP_bc92b40462e5481db16709f42e765882 : HardwiredMemberDescriptor
      {
        internal PROP_bc92b40462e5481db16709f42e765882()
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

      private sealed class PROP_f387bb29b4594611a3844c78dd3ff4d6 : HardwiredMemberDescriptor
      {
        internal PROP_f387bb29b4594611a3844c78dd3ff4d6()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_c315f6a465c3493d96236ebc156e5ce1 : HardwiredMemberDescriptor
      {
        internal PROP_c315f6a465c3493d96236ebc156e5ce1()
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

      private sealed class PROP_dbc9ca5d9bd74818b4717e5300a93d15 : HardwiredMemberDescriptor
      {
        internal PROP_dbc9ca5d9bd74818b4717e5300a93d15()
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

      private sealed class PROP_6c593adcd88244e18b35409f99a9b862 : HardwiredMemberDescriptor
      {
        internal PROP_6c593adcd88244e18b35409f99a9b862()
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

      private sealed class PROP_ec415d2fdae34ff2ab8b43a321edaa3e : HardwiredMemberDescriptor
      {
        internal PROP_ec415d2fdae34ff2ab8b43a321edaa3e()
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

      private sealed class PROP_42eaf88b9f3940bc84229ec801283631 : HardwiredMemberDescriptor
      {
        internal PROP_42eaf88b9f3940bc84229ec801283631()
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

      private sealed class PROP_68339e840e584ca1af89b6bc5dc6f372 : HardwiredMemberDescriptor
      {
        internal PROP_68339e840e584ca1af89b6bc5dc6f372()
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

      private sealed class PROP_5e7a778989254f8f8dcd9a22add29bdd : HardwiredMemberDescriptor
      {
        internal PROP_5e7a778989254f8f8dcd9a22add29bdd()
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

      private sealed class PROP_6cfd2317705d4fcd87e4bfc4b2797ae4 : HardwiredMemberDescriptor
      {
        internal PROP_6cfd2317705d4fcd87e4bfc4b2797ae4()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_48c3deafb33e4cdba56c25098ca3655d : HardwiredMemberDescriptor
      {
        internal PROP_48c3deafb33e4cdba56c25098ca3655d()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_643b436b86db4e33a26a50dde3be8503 : HardwiredMemberDescriptor
      {
        internal PROP_643b436b86db4e33a26a50dde3be8503()
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

      private sealed class PROP_f53c44756f4947a19d5ec2eb83d58ac5 : HardwiredMemberDescriptor
      {
        internal PROP_f53c44756f4947a19d5ec2eb83d58ac5()
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

      private sealed class PROP_b307543ab54d4b6292ee8e4bcc847c14 : HardwiredMemberDescriptor
      {
        internal PROP_b307543ab54d4b6292ee8e4bcc847c14()
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

      private sealed class PROP_cda7c9c9fd7a40de83a0cfe8afeca493 : HardwiredMemberDescriptor
      {
        internal PROP_cda7c9c9fd7a40de83a0cfe8afeca493()
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

      private sealed class PROP_dab04d2248b44c7f845abe730b08ba24 : HardwiredMemberDescriptor
      {
        internal PROP_dab04d2248b44c7f845abe730b08ba24()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_2fdb899743904e598722d87efa5427e0 : HardwiredMemberDescriptor
      {
        internal PROP_2fdb899743904e598722d87efa5427e0()
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

      private sealed class PROP_1b6db7c00212433ba0db4381327b8cfe : HardwiredMemberDescriptor
      {
        internal PROP_1b6db7c00212433ba0db4381327b8cfe()
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

      private sealed class PROP_7596460ea1874d9bbfcd10fc63c782f0 : HardwiredMemberDescriptor
      {
        internal PROP_7596460ea1874d9bbfcd10fc63c782f0()
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

      private sealed class PROP_413074c32b954681990761dfaeec22d0 : HardwiredMemberDescriptor
      {
        internal PROP_413074c32b954681990761dfaeec22d0()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_bd2ecd528674458188fd3f24252e99dd : HardwiredMemberDescriptor
      {
        internal PROP_bd2ecd528674458188fd3f24252e99dd()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_af3bdd1edaa24bf09ce5e24063f3280e : HardwiredMemberDescriptor
      {
        internal PROP_af3bdd1edaa24bf09ce5e24063f3280e()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_5f18159c848a44469c13ca55040ed9c8 : HardwiredMemberDescriptor
      {
        internal PROP_5f18159c848a44469c13ca55040ed9c8()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_da6c6be38e0c4a358d47f85923ff39f7 : HardwiredMemberDescriptor
      {
        internal PROP_da6c6be38e0c4a358d47f85923ff39f7()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_43587253ea5d4cf299e5eb91a0da0eb8 : HardwiredMemberDescriptor
      {
        internal PROP_43587253ea5d4cf299e5eb91a0da0eb8()
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

      private sealed class PROP_be6c059220714afb84c9851e0af55d20 : HardwiredMemberDescriptor
      {
        internal PROP_be6c059220714afb84c9851e0af55d20()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_67c10d46b62a402a8f09878a58d0386c : HardwiredMemberDescriptor
      {
        internal PROP_67c10d46b62a402a8f09878a58d0386c()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_915a99742281488fad89062dd567e0a7 : HardwiredMemberDescriptor
      {
        internal PROP_915a99742281488fad89062dd567e0a7()
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

      private sealed class PROP_c50ba3c1bd2e42a6a3666320be5e8c28 : HardwiredMemberDescriptor
      {
        internal PROP_c50ba3c1bd2e42a6a3666320be5e8c28()
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

    private sealed class TYPE_a185395011b04380b3857efbb1cf2b43 : HardwiredUserDataDescriptor
    {
      internal TYPE_a185395011b04380b3857efbb1cf2b43()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.MTHD_766eb8c1dad8443d82a88c43a98342d6()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.MTHD_917a6938b9924f2dbd36e2f8ff1b7f80()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.MTHD_c729ca5d77344428aa50df7bb773f674()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.MTHD_4c82df5352d5434f8cebc1ccab1e2dea()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.MTHD_e65c9e47abcb486c8dbf6fae13a4bf41()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.MTHD_02354203e943451381ac57377faa1250()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.MTHD_dab207e51c1f403c8b068da77273de25()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.MTHD_084a27a191554180acdc928d0f272287()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.MTHD_d5291b155c7844289c453ef323283c91()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.MTHD_0f16c2a0358f463c9476f874d62a9071()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.MTHD_b625d81efe3341638815177336e21081()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.MTHD_7ff0a5b88e49472d8f10bbf394759d3a()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.MTHD_c74419eca0304883a533c70aeecf1925()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.MTHD_5e09add91bb6455ca664ee4c890bb0bd()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.MTHD_3c5df2231ccd4b89b531417e65419fe0()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.MTHD_51150250c8744ab8b6ec43192e79c4c4()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.MTHD_c632a372b82940d38e5eea42f3381426()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.MTHD_506e1320bba343c4b52c48f0a5a48c79()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.MTHD_386852b7cde94c87a76d81769155f25c()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.MTHD_0be82ec0adef4e03ab3d9ac8d869f294()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.PROP_1ff2b9e67edb4ff9911b2fd28a42c004());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.PROP_cc5f5fdd6d80412da9d9832501ca348f());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.PROP_283026bf164446e5b624efa4520ffda2());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.PROP_207e9f9015df45af9840f0a549ceb5a6());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.PROP_ddc294a5e15d46a5b216f34ca8e8c0c0());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.PROP_6bbc798142004ac88f30e232c3b49979());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.PROP_aba5174dd2cd4c678d6216cab545d7bd());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_a185395011b04380b3857efbb1cf2b43.PROP_21239069935a4ed1b5d4f942aa424f08());
      }

      private sealed class MTHD_766eb8c1dad8443d82a88c43a98342d6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_766eb8c1dad8443d82a88c43a98342d6()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_917a6938b9924f2dbd36e2f8ff1b7f80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_917a6938b9924f2dbd36e2f8ff1b7f80()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_c729ca5d77344428aa50df7bb773f674 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c729ca5d77344428aa50df7bb773f674()
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

      private sealed class MTHD_4c82df5352d5434f8cebc1ccab1e2dea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c82df5352d5434f8cebc1ccab1e2dea()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_e65c9e47abcb486c8dbf6fae13a4bf41 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e65c9e47abcb486c8dbf6fae13a4bf41()
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

      private sealed class MTHD_02354203e943451381ac57377faa1250 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_02354203e943451381ac57377faa1250()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_dab207e51c1f403c8b068da77273de25 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dab207e51c1f403c8b068da77273de25()
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

      private sealed class MTHD_084a27a191554180acdc928d0f272287 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_084a27a191554180acdc928d0f272287()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_d5291b155c7844289c453ef323283c91 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d5291b155c7844289c453ef323283c91()
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

      private sealed class MTHD_0f16c2a0358f463c9476f874d62a9071 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f16c2a0358f463c9476f874d62a9071()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_b625d81efe3341638815177336e21081 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b625d81efe3341638815177336e21081()
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

      private sealed class MTHD_7ff0a5b88e49472d8f10bbf394759d3a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ff0a5b88e49472d8f10bbf394759d3a()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_c74419eca0304883a533c70aeecf1925 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c74419eca0304883a533c70aeecf1925()
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

      private sealed class MTHD_5e09add91bb6455ca664ee4c890bb0bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e09add91bb6455ca664ee4c890bb0bd()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_3c5df2231ccd4b89b531417e65419fe0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3c5df2231ccd4b89b531417e65419fe0()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_51150250c8744ab8b6ec43192e79c4c4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_51150250c8744ab8b6ec43192e79c4c4()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c632a372b82940d38e5eea42f3381426 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c632a372b82940d38e5eea42f3381426()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_506e1320bba343c4b52c48f0a5a48c79 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_506e1320bba343c4b52c48f0a5a48c79()
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

      private sealed class MTHD_386852b7cde94c87a76d81769155f25c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_386852b7cde94c87a76d81769155f25c()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_0be82ec0adef4e03ab3d9ac8d869f294 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0be82ec0adef4e03ab3d9ac8d869f294()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_1ff2b9e67edb4ff9911b2fd28a42c004 : HardwiredMemberDescriptor
      {
        internal PROP_1ff2b9e67edb4ff9911b2fd28a42c004()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_cc5f5fdd6d80412da9d9832501ca348f : HardwiredMemberDescriptor
      {
        internal PROP_cc5f5fdd6d80412da9d9832501ca348f()
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

      private sealed class PROP_283026bf164446e5b624efa4520ffda2 : HardwiredMemberDescriptor
      {
        internal PROP_283026bf164446e5b624efa4520ffda2()
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

      private sealed class PROP_207e9f9015df45af9840f0a549ceb5a6 : HardwiredMemberDescriptor
      {
        internal PROP_207e9f9015df45af9840f0a549ceb5a6()
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

      private sealed class PROP_ddc294a5e15d46a5b216f34ca8e8c0c0 : HardwiredMemberDescriptor
      {
        internal PROP_ddc294a5e15d46a5b216f34ca8e8c0c0()
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

      private sealed class PROP_6bbc798142004ac88f30e232c3b49979 : HardwiredMemberDescriptor
      {
        internal PROP_6bbc798142004ac88f30e232c3b49979()
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

      private sealed class PROP_aba5174dd2cd4c678d6216cab545d7bd : HardwiredMemberDescriptor
      {
        internal PROP_aba5174dd2cd4c678d6216cab545d7bd()
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

      private sealed class PROP_21239069935a4ed1b5d4f942aa424f08 : HardwiredMemberDescriptor
      {
        internal PROP_21239069935a4ed1b5d4f942aa424f08()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_b8f9f9428c684c309351043f0a3e5008 : HardwiredUserDataDescriptor
    {
      internal TYPE_b8f9f9428c684c309351043f0a3e5008()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.MTHD_1f2bb9a7997f4e628eade8ee998978ff()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.MTHD_b26db7f4faac4610acef905f14be19f2()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.MTHD_c4afacc98fcf4f63b0c615339b906122()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.MTHD_736fb4803f9647a7bcd48750e5d9b9f6()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.MTHD_bba1d52faf1f4640b1e7b646a5b90bff()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.MTHD_26e7a7da6c0d411f8788fa098fe96b7c()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.MTHD_235f8590024a4779a92162fd563f7246()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.MTHD_2134a0458b9943bf9b4033dff5e515bb()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.MTHD_872f4084820f430999013fa752e2abb0()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.MTHD_a57a2ff201be43feaccf40fa546b60c1()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.MTHD_9fcf2474e3664b4a83d34b238c584263()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.MTHD_52080c42140e4a2ea4c9f9c1be2ed2b2()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.MTHD_6fcc61944c5c4d1ba1b165c823e7ed6d()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.MTHD_5ddd532003b24b89a7d9f8f81343051f()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.MTHD_b39eed26a7e84defbb074179b01688d0()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.MTHD_7c44580cb2ac4259b84ba1e2de59503c()
        }));
        this.AddMember("setIcon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setIcon", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.MTHD_8daea9ea54d04b8a89e5fbf9e5f834d5()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.MTHD_66105b5bc26345b597689a7239a199b6()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.MTHD_1fcce34f596a476b87c30a3afb2426c6()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.MTHD_5a90c79bbb6141da8679c1b6f8c6a7c2()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.MTHD_6c86614c87cc478aa8a3f466274533ad()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.MTHD_d2bd4d6eb3a04e4d9cd6ca4f468d0110()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.PROP_1bda2f0dad0e47a4b0271ad13ad9b2ea());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.PROP_a784fbc116624ac7a06a4bd5ab0219ab());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.PROP_c347a1cde53e4a6db9cf8d559309a216());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.PROP_5c4e6e843141400e96fb8337718591e5());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.PROP_e0c8438288c445a7b967ec420fe18daa());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.PROP_34158b61aaaa4cbdba354c3fe0bfc2f1());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.PROP_3867a2ff75284e6eb43b8e4d8416ca99());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.PROP_004553c5522140ad9e73c7f1c093c9ba());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_b8f9f9428c684c309351043f0a3e5008.PROP_d038477893894dacb99e6dabdc3867e6());
      }

      private sealed class MTHD_1f2bb9a7997f4e628eade8ee998978ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f2bb9a7997f4e628eade8ee998978ff()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_b26db7f4faac4610acef905f14be19f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b26db7f4faac4610acef905f14be19f2()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_c4afacc98fcf4f63b0c615339b906122 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c4afacc98fcf4f63b0c615339b906122()
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

      private sealed class MTHD_736fb4803f9647a7bcd48750e5d9b9f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_736fb4803f9647a7bcd48750e5d9b9f6()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_bba1d52faf1f4640b1e7b646a5b90bff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bba1d52faf1f4640b1e7b646a5b90bff()
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

      private sealed class MTHD_26e7a7da6c0d411f8788fa098fe96b7c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_26e7a7da6c0d411f8788fa098fe96b7c()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_235f8590024a4779a92162fd563f7246 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_235f8590024a4779a92162fd563f7246()
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

      private sealed class MTHD_2134a0458b9943bf9b4033dff5e515bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2134a0458b9943bf9b4033dff5e515bb()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_872f4084820f430999013fa752e2abb0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_872f4084820f430999013fa752e2abb0()
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

      private sealed class MTHD_a57a2ff201be43feaccf40fa546b60c1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a57a2ff201be43feaccf40fa546b60c1()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_9fcf2474e3664b4a83d34b238c584263 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9fcf2474e3664b4a83d34b238c584263()
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

      private sealed class MTHD_52080c42140e4a2ea4c9f9c1be2ed2b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52080c42140e4a2ea4c9f9c1be2ed2b2()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_6fcc61944c5c4d1ba1b165c823e7ed6d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6fcc61944c5c4d1ba1b165c823e7ed6d()
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

      private sealed class MTHD_5ddd532003b24b89a7d9f8f81343051f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ddd532003b24b89a7d9f8f81343051f()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color2;
        }
      }

      private sealed class MTHD_b39eed26a7e84defbb074179b01688d0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b39eed26a7e84defbb074179b01688d0()
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

      private sealed class MTHD_7c44580cb2ac4259b84ba1e2de59503c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7c44580cb2ac4259b84ba1e2de59503c()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_8daea9ea54d04b8a89e5fbf9e5f834d5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8daea9ea54d04b8a89e5fbf9e5f834d5()
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

      private sealed class MTHD_66105b5bc26345b597689a7239a199b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_66105b5bc26345b597689a7239a199b6()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_1fcce34f596a476b87c30a3afb2426c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1fcce34f596a476b87c30a3afb2426c6()
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

      private sealed class MTHD_5a90c79bbb6141da8679c1b6f8c6a7c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5a90c79bbb6141da8679c1b6f8c6a7c2()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_6c86614c87cc478aa8a3f466274533ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6c86614c87cc478aa8a3f466274533ad()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_d2bd4d6eb3a04e4d9cd6ca4f468d0110 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d2bd4d6eb3a04e4d9cd6ca4f468d0110()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_1bda2f0dad0e47a4b0271ad13ad9b2ea : HardwiredMemberDescriptor
      {
        internal PROP_1bda2f0dad0e47a4b0271ad13ad9b2ea()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_a784fbc116624ac7a06a4bd5ab0219ab : HardwiredMemberDescriptor
      {
        internal PROP_a784fbc116624ac7a06a4bd5ab0219ab()
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

      private sealed class PROP_c347a1cde53e4a6db9cf8d559309a216 : HardwiredMemberDescriptor
      {
        internal PROP_c347a1cde53e4a6db9cf8d559309a216()
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

      private sealed class PROP_5c4e6e843141400e96fb8337718591e5 : HardwiredMemberDescriptor
      {
        internal PROP_5c4e6e843141400e96fb8337718591e5()
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

      private sealed class PROP_e0c8438288c445a7b967ec420fe18daa : HardwiredMemberDescriptor
      {
        internal PROP_e0c8438288c445a7b967ec420fe18daa()
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

      private sealed class PROP_34158b61aaaa4cbdba354c3fe0bfc2f1 : HardwiredMemberDescriptor
      {
        internal PROP_34158b61aaaa4cbdba354c3fe0bfc2f1()
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

      private sealed class PROP_3867a2ff75284e6eb43b8e4d8416ca99 : HardwiredMemberDescriptor
      {
        internal PROP_3867a2ff75284e6eb43b8e4d8416ca99()
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

      private sealed class PROP_004553c5522140ad9e73c7f1c093c9ba : HardwiredMemberDescriptor
      {
        internal PROP_004553c5522140ad9e73c7f1c093c9ba()
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

      private sealed class PROP_d038477893894dacb99e6dabdc3867e6 : HardwiredMemberDescriptor
      {
        internal PROP_d038477893894dacb99e6dabdc3867e6()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_9b5610f8f681484a8bb6934e28ec8bf8 : HardwiredUserDataDescriptor
    {
      internal TYPE_9b5610f8f681484a8bb6934e28ec8bf8()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_5ca435c2f2884770bb4bd3a21c07a16a()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_b3d6fbccafcd4660bedd327c3259b721()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_24c04aa05e9e46678d955edee1bc2338()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_06367b0edb034c719edc88fd7f44bb19()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_53cb467444ea48e5837a92f5c3882979()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_f6d2cf228c4c4ddaa4f84ee1bc274857()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_3b352cbe0abc458ba6b3f81b32a2d0cd()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_3bf087e6e4bc4934865e98729b29298f()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_f8500e7003024b41b566706900d9bd91()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_189795a249934ffebae0fb8caccbf719()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_909fdf5d041b4aa698d7736d186fdf84()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_2d804549a171445d9a5d37960017909a()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_c9366c7093214177b25433669185c07c()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_67bd6a3c215b446ea175bfe77413f1e1()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_0ca627b89e41482b98002b45f02c9943()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_1c600fbf158b4e8fa09c0d49cd557bfb()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_53529a83bb3045f1a97a51a72dce4fc1()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_64b19b881a07492c97c4c6a2366721ff()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_fe2c42dd9e71493fb289950f0d3d6a72()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_d3a11d59a21748e6ada4ea794828cf08()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_c7565ceb369c44d48f60a5744b30a1e1()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_88dbad3360694193b535fdab7b812a0a()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_c33d46ab6307400e926e4534d470c5c1()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_4cb449fad96b4c51a32b4590354d6966()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_5d2d9e4c8ddc4b10b97b6a747e4abd0a()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_9552bdbb383845a4bca6b1f2ac78ff7a()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_58d59e4f59074491b2768b29cb6693b4()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.MTHD_9eaa374e88404197bcbf3c8b0fa6f1fe()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.PROP_f74b09c6592a46489b1fca2c515ddf97());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.PROP_0bf56c9d2d644a95b1c64cf70e7e4cb3());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.PROP_8b319ea6d07e48e2a33cadb866fb257b());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.PROP_fd7935a894d5426685a030c960c5858b());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.PROP_c2fd44878b044a34bf14440498fe48b5());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.PROP_3c782259c8ca4226bdbfc21a4f64df86());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.PROP_b082eee113c346b0aa825449a3de640b());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.PROP_99e14d8d85ea4cd19a17722ef794e149());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.PROP_c04192c25b364c659dbc12aead79f152());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.PROP_d4e33b39265f497c8c062db73af1cd9f());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.PROP_f6e5b9ec4a954e5f874c9e8179bcc0e4());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.PROP_d73c60b89c8244a0b2bc5a1231f6e453());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.PROP_4e67cdb9a81a4a09b69b0a11bece872f());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.PROP_489a900abe1c4bc9bf113e0bfdf8fed0());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.PROP_88ad55505eb54970bbf926ececf771be());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.PROP_69631d2b91454edfa82b60ce6fcc1d20());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_9b5610f8f681484a8bb6934e28ec8bf8.PROP_d078ed295ea74948bfccd7c2bbb91c9a());
      }

      private sealed class MTHD_5ca435c2f2884770bb4bd3a21c07a16a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ca435c2f2884770bb4bd3a21c07a16a()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_b3d6fbccafcd4660bedd327c3259b721 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b3d6fbccafcd4660bedd327c3259b721()
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

      private sealed class MTHD_24c04aa05e9e46678d955edee1bc2338 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24c04aa05e9e46678d955edee1bc2338()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_06367b0edb034c719edc88fd7f44bb19 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_06367b0edb034c719edc88fd7f44bb19()
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

      private sealed class MTHD_53cb467444ea48e5837a92f5c3882979 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_53cb467444ea48e5837a92f5c3882979()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_f6d2cf228c4c4ddaa4f84ee1bc274857 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f6d2cf228c4c4ddaa4f84ee1bc274857()
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

      private sealed class MTHD_3b352cbe0abc458ba6b3f81b32a2d0cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3b352cbe0abc458ba6b3f81b32a2d0cd()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_3bf087e6e4bc4934865e98729b29298f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3bf087e6e4bc4934865e98729b29298f()
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

      private sealed class MTHD_f8500e7003024b41b566706900d9bd91 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f8500e7003024b41b566706900d9bd91()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_189795a249934ffebae0fb8caccbf719 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_189795a249934ffebae0fb8caccbf719()
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

      private sealed class MTHD_909fdf5d041b4aa698d7736d186fdf84 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_909fdf5d041b4aa698d7736d186fdf84()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_2d804549a171445d9a5d37960017909a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d804549a171445d9a5d37960017909a()
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

      private sealed class MTHD_c9366c7093214177b25433669185c07c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c9366c7093214177b25433669185c07c()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_67bd6a3c215b446ea175bfe77413f1e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67bd6a3c215b446ea175bfe77413f1e1()
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

      private sealed class MTHD_0ca627b89e41482b98002b45f02c9943 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ca627b89e41482b98002b45f02c9943()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_1c600fbf158b4e8fa09c0d49cd557bfb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c600fbf158b4e8fa09c0d49cd557bfb()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_53529a83bb3045f1a97a51a72dce4fc1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_53529a83bb3045f1a97a51a72dce4fc1()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_64b19b881a07492c97c4c6a2366721ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_64b19b881a07492c97c4c6a2366721ff()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_fe2c42dd9e71493fb289950f0d3d6a72 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fe2c42dd9e71493fb289950f0d3d6a72()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_d3a11d59a21748e6ada4ea794828cf08 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d3a11d59a21748e6ada4ea794828cf08()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_c7565ceb369c44d48f60a5744b30a1e1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c7565ceb369c44d48f60a5744b30a1e1()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_88dbad3360694193b535fdab7b812a0a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_88dbad3360694193b535fdab7b812a0a()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_c33d46ab6307400e926e4534d470c5c1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c33d46ab6307400e926e4534d470c5c1()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_4cb449fad96b4c51a32b4590354d6966 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4cb449fad96b4c51a32b4590354d6966()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_5d2d9e4c8ddc4b10b97b6a747e4abd0a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d2d9e4c8ddc4b10b97b6a747e4abd0a()
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

      private sealed class MTHD_9552bdbb383845a4bca6b1f2ac78ff7a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9552bdbb383845a4bca6b1f2ac78ff7a()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_58d59e4f59074491b2768b29cb6693b4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_58d59e4f59074491b2768b29cb6693b4()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_9eaa374e88404197bcbf3c8b0fa6f1fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9eaa374e88404197bcbf3c8b0fa6f1fe()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_f74b09c6592a46489b1fca2c515ddf97 : HardwiredMemberDescriptor
      {
        internal PROP_f74b09c6592a46489b1fca2c515ddf97()
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

      private sealed class PROP_0bf56c9d2d644a95b1c64cf70e7e4cb3 : HardwiredMemberDescriptor
      {
        internal PROP_0bf56c9d2d644a95b1c64cf70e7e4cb3()
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

      private sealed class PROP_8b319ea6d07e48e2a33cadb866fb257b : HardwiredMemberDescriptor
      {
        internal PROP_8b319ea6d07e48e2a33cadb866fb257b()
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

      private sealed class PROP_fd7935a894d5426685a030c960c5858b : HardwiredMemberDescriptor
      {
        internal PROP_fd7935a894d5426685a030c960c5858b()
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

      private sealed class PROP_c2fd44878b044a34bf14440498fe48b5 : HardwiredMemberDescriptor
      {
        internal PROP_c2fd44878b044a34bf14440498fe48b5()
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

      private sealed class PROP_3c782259c8ca4226bdbfc21a4f64df86 : HardwiredMemberDescriptor
      {
        internal PROP_3c782259c8ca4226bdbfc21a4f64df86()
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

      private sealed class PROP_b082eee113c346b0aa825449a3de640b : HardwiredMemberDescriptor
      {
        internal PROP_b082eee113c346b0aa825449a3de640b()
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

      private sealed class PROP_99e14d8d85ea4cd19a17722ef794e149 : HardwiredMemberDescriptor
      {
        internal PROP_99e14d8d85ea4cd19a17722ef794e149()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_c04192c25b364c659dbc12aead79f152 : HardwiredMemberDescriptor
      {
        internal PROP_c04192c25b364c659dbc12aead79f152()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_d4e33b39265f497c8c062db73af1cd9f : HardwiredMemberDescriptor
      {
        internal PROP_d4e33b39265f497c8c062db73af1cd9f()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_f6e5b9ec4a954e5f874c9e8179bcc0e4 : HardwiredMemberDescriptor
      {
        internal PROP_f6e5b9ec4a954e5f874c9e8179bcc0e4()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_d73c60b89c8244a0b2bc5a1231f6e453 : HardwiredMemberDescriptor
      {
        internal PROP_d73c60b89c8244a0b2bc5a1231f6e453()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_4e67cdb9a81a4a09b69b0a11bece872f : HardwiredMemberDescriptor
      {
        internal PROP_4e67cdb9a81a4a09b69b0a11bece872f()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_489a900abe1c4bc9bf113e0bfdf8fed0 : HardwiredMemberDescriptor
      {
        internal PROP_489a900abe1c4bc9bf113e0bfdf8fed0()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_88ad55505eb54970bbf926ececf771be : HardwiredMemberDescriptor
      {
        internal PROP_88ad55505eb54970bbf926ececf771be()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_69631d2b91454edfa82b60ce6fcc1d20 : HardwiredMemberDescriptor
      {
        internal PROP_69631d2b91454edfa82b60ce6fcc1d20()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_d078ed295ea74948bfccd7c2bbb91c9a : HardwiredMemberDescriptor
      {
        internal PROP_d078ed295ea74948bfccd7c2bbb91c9a()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_b4e9ef9412b14cc8b3bb4669ceee0d3c : HardwiredUserDataDescriptor
    {
      internal TYPE_b4e9ef9412b14cc8b3bb4669ceee0d3c()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4e9ef9412b14cc8b3bb4669ceee0d3c.MTHD_c55ebdfcd47749028279081d25b540f9()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4e9ef9412b14cc8b3bb4669ceee0d3c.MTHD_01f400788f11446f9d33214707d988b1()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4e9ef9412b14cc8b3bb4669ceee0d3c.MTHD_6b00ba6f0e734d36af689cfff87514fc()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4e9ef9412b14cc8b3bb4669ceee0d3c.MTHD_07e2a703252343988c50c9b96b4b1640()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4e9ef9412b14cc8b3bb4669ceee0d3c.MTHD_f8458d01fa1d49518432db015acf1daa()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4e9ef9412b14cc8b3bb4669ceee0d3c.MTHD_828276ceac124954a8c3c396985c7a10()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4e9ef9412b14cc8b3bb4669ceee0d3c.MTHD_df175e318300431caf286a6b1d2ac2bf()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4e9ef9412b14cc8b3bb4669ceee0d3c.MTHD_e2e7bf8799144a7e909ade82b17c1fac()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4e9ef9412b14cc8b3bb4669ceee0d3c.MTHD_58a7f9d4a09c45e7baa0fd1386a6e383()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4e9ef9412b14cc8b3bb4669ceee0d3c.MTHD_c5b9759530c2430e9e52b8cf37889a68()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4e9ef9412b14cc8b3bb4669ceee0d3c.MTHD_d17aae9e9b014ac0ae514bc7d9b588d3()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4e9ef9412b14cc8b3bb4669ceee0d3c.MTHD_26a97d5edf24400fba409731643e0fb8()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4e9ef9412b14cc8b3bb4669ceee0d3c.MTHD_5db0e8d5fe354850ae19e5d62b9e3f66()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4e9ef9412b14cc8b3bb4669ceee0d3c.MTHD_69927bf3acfe4fafbf58b3f019158b82()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4e9ef9412b14cc8b3bb4669ceee0d3c.MTHD_dcb48d72b0d9496ba6700acb62dfba2c()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4e9ef9412b14cc8b3bb4669ceee0d3c.MTHD_ffbea302979f4a38aedd58a6c2cdfd61()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_b4e9ef9412b14cc8b3bb4669ceee0d3c.MTHD_94867aca7f684734aec57aceb911c8c0()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_b4e9ef9412b14cc8b3bb4669ceee0d3c.PROP_63c4d01d72fb41f58ba8dc419bd54653());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_b4e9ef9412b14cc8b3bb4669ceee0d3c.PROP_b2b147a02a5f48b9a3cf7912682081c4());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_b4e9ef9412b14cc8b3bb4669ceee0d3c.PROP_e370a8d981444ac28074d40672feaafa());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_b4e9ef9412b14cc8b3bb4669ceee0d3c.PROP_08cda89747904cf9b6ab42cb954198f5());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_b4e9ef9412b14cc8b3bb4669ceee0d3c.PROP_205d307a0ca1463eac8d3c904ffbcb5b());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_b4e9ef9412b14cc8b3bb4669ceee0d3c.PROP_3b6eea6292924617a61cf033923ff412());
      }

      private sealed class MTHD_c55ebdfcd47749028279081d25b540f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c55ebdfcd47749028279081d25b540f9()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_01f400788f11446f9d33214707d988b1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_01f400788f11446f9d33214707d988b1()
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

      private sealed class MTHD_6b00ba6f0e734d36af689cfff87514fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b00ba6f0e734d36af689cfff87514fc()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_07e2a703252343988c50c9b96b4b1640 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_07e2a703252343988c50c9b96b4b1640()
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

      private sealed class MTHD_f8458d01fa1d49518432db015acf1daa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f8458d01fa1d49518432db015acf1daa()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_828276ceac124954a8c3c396985c7a10 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_828276ceac124954a8c3c396985c7a10()
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

      private sealed class MTHD_df175e318300431caf286a6b1d2ac2bf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_df175e318300431caf286a6b1d2ac2bf()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_e2e7bf8799144a7e909ade82b17c1fac : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e2e7bf8799144a7e909ade82b17c1fac()
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

      private sealed class MTHD_58a7f9d4a09c45e7baa0fd1386a6e383 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_58a7f9d4a09c45e7baa0fd1386a6e383()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_c5b9759530c2430e9e52b8cf37889a68 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c5b9759530c2430e9e52b8cf37889a68()
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

      private sealed class MTHD_d17aae9e9b014ac0ae514bc7d9b588d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d17aae9e9b014ac0ae514bc7d9b588d3()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_26a97d5edf24400fba409731643e0fb8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_26a97d5edf24400fba409731643e0fb8()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_5db0e8d5fe354850ae19e5d62b9e3f66 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5db0e8d5fe354850ae19e5d62b9e3f66()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_69927bf3acfe4fafbf58b3f019158b82 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_69927bf3acfe4fafbf58b3f019158b82()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_dcb48d72b0d9496ba6700acb62dfba2c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dcb48d72b0d9496ba6700acb62dfba2c()
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

      private sealed class MTHD_ffbea302979f4a38aedd58a6c2cdfd61 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ffbea302979f4a38aedd58a6c2cdfd61()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_94867aca7f684734aec57aceb911c8c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_94867aca7f684734aec57aceb911c8c0()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_63c4d01d72fb41f58ba8dc419bd54653 : HardwiredMemberDescriptor
      {
        internal PROP_63c4d01d72fb41f58ba8dc419bd54653()
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

      private sealed class PROP_b2b147a02a5f48b9a3cf7912682081c4 : HardwiredMemberDescriptor
      {
        internal PROP_b2b147a02a5f48b9a3cf7912682081c4()
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

      private sealed class PROP_e370a8d981444ac28074d40672feaafa : HardwiredMemberDescriptor
      {
        internal PROP_e370a8d981444ac28074d40672feaafa()
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

      private sealed class PROP_08cda89747904cf9b6ab42cb954198f5 : HardwiredMemberDescriptor
      {
        internal PROP_08cda89747904cf9b6ab42cb954198f5()
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

      private sealed class PROP_205d307a0ca1463eac8d3c904ffbcb5b : HardwiredMemberDescriptor
      {
        internal PROP_205d307a0ca1463eac8d3c904ffbcb5b()
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

      private sealed class PROP_3b6eea6292924617a61cf033923ff412 : HardwiredMemberDescriptor
      {
        internal PROP_3b6eea6292924617a61cf033923ff412()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_2923f9c1b82746229c48903126ad3986 : HardwiredUserDataDescriptor
    {
      internal TYPE_2923f9c1b82746229c48903126ad3986()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2923f9c1b82746229c48903126ad3986.MTHD_fd074ec86f6f4a358dd6190f767a4f37(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2923f9c1b82746229c48903126ad3986.MTHD_fa0d98643b8f4b7e9d37b26df6fbb2a5()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2923f9c1b82746229c48903126ad3986.MTHD_8b541bbae91b4a6ab46e978a4c77737b(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2923f9c1b82746229c48903126ad3986.MTHD_fd2192dfeb5c4a229c312da16decab42()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2923f9c1b82746229c48903126ad3986.MTHD_72670a3fd00e4633ae0517299cbd6e54()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2923f9c1b82746229c48903126ad3986.MTHD_9296dfaf2cc24e7ca9586ec05ceea336()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2923f9c1b82746229c48903126ad3986.MTHD_49621068501046579b37cdd2268860d1()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2923f9c1b82746229c48903126ad3986.MTHD_405db0c74a08453eb1ca923b35ea10c0()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2923f9c1b82746229c48903126ad3986.MTHD_88583858123146bfbfcee9283fc337ce()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2923f9c1b82746229c48903126ad3986.MTHD_ff3acef16c8847139263ef587e899948()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2923f9c1b82746229c48903126ad3986.MTHD_412eb0e77f6e47ff9aa880b698ad7176()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2923f9c1b82746229c48903126ad3986.MTHD_967f85d5d6d343f3bd45e54f2468c2df(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2923f9c1b82746229c48903126ad3986.MTHD_40937e048e044b83b2ccfd6134f6097a()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2923f9c1b82746229c48903126ad3986.MTHD_f40de67ab70e48d2bb2d3d3a6986cb80(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2923f9c1b82746229c48903126ad3986.MTHD_dd30f6ab316c4a668c1fc7abc6932ae2()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2923f9c1b82746229c48903126ad3986.MTHD_f28d6d84c85343e5b44ca60cb8170a74(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2923f9c1b82746229c48903126ad3986.MTHD_fe563f31005d4c74aa9920e82a8db721()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2923f9c1b82746229c48903126ad3986.MTHD_a70c49ac469c4186a17cd714c88eb7fc(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2923f9c1b82746229c48903126ad3986.MTHD_023d4aca708f46f5aee3d83533b94ea0()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2923f9c1b82746229c48903126ad3986.MTHD_6eed8b1a515e464292fc16af43f9213d(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2923f9c1b82746229c48903126ad3986.MTHD_3d8c831f14f14be09986be5f5473b2cc()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2923f9c1b82746229c48903126ad3986.MTHD_276cb375ef6744b792c1714d1119e995()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_2923f9c1b82746229c48903126ad3986.MTHD_f2f3f2f02c2d4693a1271cd80e16f873()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_2923f9c1b82746229c48903126ad3986.FLDV_74418795815a4be6a11379afd3c6a389());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_2923f9c1b82746229c48903126ad3986.FLDV_bb429f0831104bbfa6cc2a93e98a6262());
      }

      private sealed class MTHD_fd074ec86f6f4a358dd6190f767a4f37 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd074ec86f6f4a358dd6190f767a4f37()
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

      private sealed class MTHD_fa0d98643b8f4b7e9d37b26df6fbb2a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fa0d98643b8f4b7e9d37b26df6fbb2a5()
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

      private sealed class MTHD_8b541bbae91b4a6ab46e978a4c77737b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b541bbae91b4a6ab46e978a4c77737b()
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

      private sealed class MTHD_fd2192dfeb5c4a229c312da16decab42 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd2192dfeb5c4a229c312da16decab42()
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

      private sealed class MTHD_72670a3fd00e4633ae0517299cbd6e54 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_72670a3fd00e4633ae0517299cbd6e54()
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

      private sealed class MTHD_9296dfaf2cc24e7ca9586ec05ceea336 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9296dfaf2cc24e7ca9586ec05ceea336()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_49621068501046579b37cdd2268860d1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_49621068501046579b37cdd2268860d1()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_405db0c74a08453eb1ca923b35ea10c0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_405db0c74a08453eb1ca923b35ea10c0()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_88583858123146bfbfcee9283fc337ce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_88583858123146bfbfcee9283fc337ce()
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

      private sealed class MTHD_ff3acef16c8847139263ef587e899948 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff3acef16c8847139263ef587e899948()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_412eb0e77f6e47ff9aa880b698ad7176 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_412eb0e77f6e47ff9aa880b698ad7176()
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

      private sealed class MTHD_967f85d5d6d343f3bd45e54f2468c2df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_967f85d5d6d343f3bd45e54f2468c2df()
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

      private sealed class MTHD_40937e048e044b83b2ccfd6134f6097a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_40937e048e044b83b2ccfd6134f6097a()
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

      private sealed class MTHD_f40de67ab70e48d2bb2d3d3a6986cb80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f40de67ab70e48d2bb2d3d3a6986cb80()
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

      private sealed class MTHD_dd30f6ab316c4a668c1fc7abc6932ae2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dd30f6ab316c4a668c1fc7abc6932ae2()
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

      private sealed class MTHD_f28d6d84c85343e5b44ca60cb8170a74 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f28d6d84c85343e5b44ca60cb8170a74()
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

      private sealed class MTHD_fe563f31005d4c74aa9920e82a8db721 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fe563f31005d4c74aa9920e82a8db721()
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

      private sealed class MTHD_a70c49ac469c4186a17cd714c88eb7fc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a70c49ac469c4186a17cd714c88eb7fc()
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

      private sealed class MTHD_023d4aca708f46f5aee3d83533b94ea0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_023d4aca708f46f5aee3d83533b94ea0()
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

      private sealed class MTHD_6eed8b1a515e464292fc16af43f9213d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6eed8b1a515e464292fc16af43f9213d()
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

      private sealed class MTHD_3d8c831f14f14be09986be5f5473b2cc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d8c831f14f14be09986be5f5473b2cc()
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

      private sealed class MTHD_276cb375ef6744b792c1714d1119e995 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_276cb375ef6744b792c1714d1119e995()
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

      private sealed class MTHD_f2f3f2f02c2d4693a1271cd80e16f873 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f2f3f2f02c2d4693a1271cd80e16f873()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_74418795815a4be6a11379afd3c6a389 : HardwiredMemberDescriptor
      {
        internal FLDV_74418795815a4be6a11379afd3c6a389()
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

      private sealed class FLDV_bb429f0831104bbfa6cc2a93e98a6262 : HardwiredMemberDescriptor
      {
        internal FLDV_bb429f0831104bbfa6cc2a93e98a6262()
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

    private sealed class TYPE_d8edcbc288ef4c9ab49e35c44bd5d403 : HardwiredUserDataDescriptor
    {
      internal TYPE_d8edcbc288ef4c9ab49e35c44bd5d403()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d8edcbc288ef4c9ab49e35c44bd5d403.MTHD_d45ee96397ca40bf98d6ef8855462dfe()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d8edcbc288ef4c9ab49e35c44bd5d403.MTHD_5235ae28fef645d4ac89243c0c2e0a5a()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d8edcbc288ef4c9ab49e35c44bd5d403.MTHD_ce6dd5a87daf4bd491adc12abb771894()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d8edcbc288ef4c9ab49e35c44bd5d403.MTHD_021fe1e67ded4b078ba938faab010a8d()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d8edcbc288ef4c9ab49e35c44bd5d403.MTHD_4e56c14b1b774794bdb20961cf90e9d6()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d8edcbc288ef4c9ab49e35c44bd5d403.MTHD_eca3ab7b1d17471e959603eb383c5d33()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_d8edcbc288ef4c9ab49e35c44bd5d403.FLDV_df43ed21bdce4448a4e5271605e03b98());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_d8edcbc288ef4c9ab49e35c44bd5d403.FLDV_bbcbc1b938304651b3076b74349d1274());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_d8edcbc288ef4c9ab49e35c44bd5d403.FLDV_5a1c5b02ec6248a6ba5382a89a5e6947());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_d8edcbc288ef4c9ab49e35c44bd5d403.FLDV_06b6ffae16b34cf2960aeb54078a9a3c());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_d8edcbc288ef4c9ab49e35c44bd5d403.FLDV_ce34a6785092458d9ed8966cb35d01a4());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_d8edcbc288ef4c9ab49e35c44bd5d403.FLDV_2e2273afe9a040f5b8748aa89056b5b6());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_d8edcbc288ef4c9ab49e35c44bd5d403.FLDV_35665679ae13435582f8e28d12006038());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_d8edcbc288ef4c9ab49e35c44bd5d403.FLDV_d0aae166ce9e43e89e7e2c4e1a414abf());
        this.AddMember("prestige", (IMemberDescriptor) new Bridge.TYPE_d8edcbc288ef4c9ab49e35c44bd5d403.FLDV_7225c49465e74982add89b3afc2b08ff());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_d8edcbc288ef4c9ab49e35c44bd5d403.FLDV_ea4bccdd419349f68b5124129c378563());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_d8edcbc288ef4c9ab49e35c44bd5d403.FLDV_a6d1105eb3d14e0b8c7e357dcb33483f());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_d8edcbc288ef4c9ab49e35c44bd5d403.FLDV_c88d7c80731b4ba59022dc6f4286fe74());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_d8edcbc288ef4c9ab49e35c44bd5d403.FLDV_6b1830ba5d764b5bb7976754e1ee780f());
      }

      private sealed class MTHD_d45ee96397ca40bf98d6ef8855462dfe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d45ee96397ca40bf98d6ef8855462dfe()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_5235ae28fef645d4ac89243c0c2e0a5a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5235ae28fef645d4ac89243c0c2e0a5a()
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

      private sealed class MTHD_ce6dd5a87daf4bd491adc12abb771894 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ce6dd5a87daf4bd491adc12abb771894()
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

      private sealed class MTHD_021fe1e67ded4b078ba938faab010a8d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_021fe1e67ded4b078ba938faab010a8d()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_4e56c14b1b774794bdb20961cf90e9d6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4e56c14b1b774794bdb20961cf90e9d6()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_eca3ab7b1d17471e959603eb383c5d33 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eca3ab7b1d17471e959603eb383c5d33()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_df43ed21bdce4448a4e5271605e03b98 : HardwiredMemberDescriptor
      {
        internal FLDV_df43ed21bdce4448a4e5271605e03b98()
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

      private sealed class FLDV_bbcbc1b938304651b3076b74349d1274 : HardwiredMemberDescriptor
      {
        internal FLDV_bbcbc1b938304651b3076b74349d1274()
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

      private sealed class FLDV_5a1c5b02ec6248a6ba5382a89a5e6947 : HardwiredMemberDescriptor
      {
        internal FLDV_5a1c5b02ec6248a6ba5382a89a5e6947()
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

      private sealed class FLDV_06b6ffae16b34cf2960aeb54078a9a3c : HardwiredMemberDescriptor
      {
        internal FLDV_06b6ffae16b34cf2960aeb54078a9a3c()
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

      private sealed class FLDV_ce34a6785092458d9ed8966cb35d01a4 : HardwiredMemberDescriptor
      {
        internal FLDV_ce34a6785092458d9ed8966cb35d01a4()
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

      private sealed class FLDV_2e2273afe9a040f5b8748aa89056b5b6 : HardwiredMemberDescriptor
      {
        internal FLDV_2e2273afe9a040f5b8748aa89056b5b6()
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

      private sealed class FLDV_35665679ae13435582f8e28d12006038 : HardwiredMemberDescriptor
      {
        internal FLDV_35665679ae13435582f8e28d12006038()
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

      private sealed class FLDV_d0aae166ce9e43e89e7e2c4e1a414abf : HardwiredMemberDescriptor
      {
        internal FLDV_d0aae166ce9e43e89e7e2c4e1a414abf()
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

      private sealed class FLDV_7225c49465e74982add89b3afc2b08ff : HardwiredMemberDescriptor
      {
        internal FLDV_7225c49465e74982add89b3afc2b08ff()
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

      private sealed class FLDV_ea4bccdd419349f68b5124129c378563 : HardwiredMemberDescriptor
      {
        internal FLDV_ea4bccdd419349f68b5124129c378563()
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

      private sealed class FLDV_a6d1105eb3d14e0b8c7e357dcb33483f : HardwiredMemberDescriptor
      {
        internal FLDV_a6d1105eb3d14e0b8c7e357dcb33483f()
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

      private sealed class FLDV_c88d7c80731b4ba59022dc6f4286fe74 : HardwiredMemberDescriptor
      {
        internal FLDV_c88d7c80731b4ba59022dc6f4286fe74()
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

      private sealed class FLDV_6b1830ba5d764b5bb7976754e1ee780f : HardwiredMemberDescriptor
      {
        internal FLDV_6b1830ba5d764b5bb7976754e1ee780f()
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

    private sealed class TYPE_1f1303adf8614077a5a3cdb819b2a0a7 : HardwiredUserDataDescriptor
    {
      internal TYPE_1f1303adf8614077a5a3cdb819b2a0a7()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_2c5ce254f2bf4e6c8c13fac1cf68d6a1()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_5dc09e71e1164d5294c63a8b0bee3257()
        }));
        this.AddMember("get_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_a5e07331e99a4189a4507350fcae3383()
        }));
        this.AddMember("set_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_a99e7429ab2949d1a2c1c400991d48a6()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_363835e8b971463a9f93b1901ca3047d()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_6d86de2a85884fb89a9eca976fbbb92e()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_27c46b1f272a4f74896d7365a44b6d9c()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_732e461e2a994288888e4621fe774aa2()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_de6305b36edb4cc0bf687d4e623074fb()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_d9c6dcc34591460889059efaadb672f6()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_24bd4e07ad94498e9d25ac6d87099b77()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_6af4e208fbb84aa39f154ab294812b93()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_299cccff447449f2a7cbf664df02ae00()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_2b2507331900447c9076c7c78cffc19d()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_917a396f81e8425a8623fbe2b035380d()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_3700985e6f1c42d7be1b88ef7290052c()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_53c758ca1b0741b09b766bd24b5a7bb1()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_0afb751449f54cb0bdacb98782ff0cbe()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_8ddf48775470480984e3aa10e8ceb906()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_ed94330b76404f55b46fdc609d80e747()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_d21f48594309408197eb0d5d2168b9e6()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_833aabbca38445d6ae72a2e1d175937c()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_bb89c00e89084918a40e0e0c3d342eff()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_d04c3b869073406f8e64797ecccd58d9()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_008e965267cd410bb4b86760dcf2886d()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_a1a387a88f5c4ba198fec380b9b93c2d()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_570befed59f740f1959703abeaeabe33()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_8e0d20c2d5f349839d09b8089ff45c31()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_f216dc719d70497881a2bed4c268adc3()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_8ab111550c33430cb8f29613a76ebb6d()
        }));
        this.AddMember("get_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_322c7f798e304cb89f4909fa8923deeb()
        }));
        this.AddMember("set_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_f6f1c5fe98e14874ae80310df0a0d3f4()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_189be934be254eb3b934260e079ec8bb()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_74fc6e963fb342ea8d8c42946d25388b()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_df9d32591bf7491abee1b5bd7e310dc1()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_a1d40bb953cb442289b5ea401f31afdc()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_2dca27aa36004b98826b823baebea133()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_54fc1c1685864637a4efeac35210badb()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_e0a3518705574566bd458b09d1657435()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_efaca5ae8eb94507bf69c173a03c6dc4()
        }));
        this.AddMember("get_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_281a36ab6ca5468d87eae205f4a719b9()
        }));
        this.AddMember("set_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_fb20fd4216d741dfad3c6fc5f1d04635()
        }));
        this.AddMember("get_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_30727b60712a44f19d4a645fb5e5889d()
        }));
        this.AddMember("set_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_734cd6120c0b4af0b6f642a404618c09()
        }));
        this.AddMember("get_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_decad062b02b480dafef2ac6fb01e296()
        }));
        this.AddMember("set_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_d6f6b4c8fa82401f80ef7c147ea039e0()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_b11294108b194afbb9a5c4338d437075()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_d37be37217b64c799ee4645c5b1e44b8()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_298ae23da8fd48498479077e1099d688()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_57c2c98d9cb84b06b4ae80c488fdb613()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_2886c265384d4c5bbf3135e6bf337e85()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_2a871a44892941d38eeb80add90e376b()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_aee7e212cf1743e080bd4b80d1e32443()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_bbd5023e7f3840ca8b5070f965876247()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_6a130bd77c784ded86d662403d8dfddd()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_25061fbad0584653b5bcb2517f4d745c()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_9c73ba2add3b4c5cbfc8bc99647a4b5a()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_d06eae572baa4e18a582a551fd1b1e7e()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_c4499d83a2e84daa942f7ae3cd61588a()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.MTHD_a5782602426d4a349fabbbd46c2f198f()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.PROP_a493555313de4842b415e9791dab9857());
        this.AddMember("visible", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.PROP_dc9c684d1484419a9528e3e1ea32cefb());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.PROP_7c26d87679064512ace2d11fe5a29c82());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.PROP_b9e61e45234e4269a54066ca08cf9f4d());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.PROP_96c8f25bba3c48ec8de8d262758ea834());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.PROP_7c4a7449f8c84cd1a3f5e8feabc3285a());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.PROP_0158249ca59e4215afcdf0894fab4fa6());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.PROP_e2dcad2cb78645c4b18a2e71b4e2b047());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.PROP_330fce32c1c04ba8a06766102f2597bb());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.PROP_d6984b20e49541efa4c63c81fd3a50b3());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.PROP_e63d9327f25643ab8062f234a36289e8());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.PROP_3225cae640ff4e3483a7f2645f4a1f57());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.PROP_b9be27daf4154c6b92c6fa18959810e0());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.PROP_1296d774f1ce4721bbc539452fc40b8c());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.PROP_06c572a311b6418493ed8d554d89513d());
        this.AddMember("onClick2", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.PROP_5baed13b5cbb4809973c07cbfc359aa9());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.PROP_ee1662638c974e559ab285d5b5dcd87d());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.PROP_da973dcf5c514afdaf2d480f91492f18());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.PROP_4ac2c0648ec440afbcd98a5087ef3453());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.PROP_52040223f32741eea0fb4d289b040445());
        this.AddMember("textColor2", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.PROP_71eb8b02b5d24df39083e126b045da67());
        this.AddMember("highlightColor", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.PROP_8bdc2e02d78540918fba954afb8a64aa());
        this.AddMember("highlightColor2", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.PROP_2537d8e81fce49c696dcaa29c1053ce0());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.PROP_68be983636c14554925f1be142d8dc38());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.PROP_48777da405644e1da2db18726ccdaf1f());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.FLDV_4c4f50bfa0c04ccfa579b7809d99d26d());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.FLDV_d9e4c1ebb7624221b9436f5b1f757849());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_1f1303adf8614077a5a3cdb819b2a0a7.FLDV_1bd9a1c311dd4384b533c770b7c13a66());
      }

      private sealed class MTHD_2c5ce254f2bf4e6c8c13fac1cf68d6a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c5ce254f2bf4e6c8c13fac1cf68d6a1()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_5dc09e71e1164d5294c63a8b0bee3257 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5dc09e71e1164d5294c63a8b0bee3257()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_a5e07331e99a4189a4507350fcae3383 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a5e07331e99a4189a4507350fcae3383()
        {
          this.Initialize("get_visible", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).visible;
        }
      }

      private sealed class MTHD_a99e7429ab2949d1a2c1c400991d48a6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a99e7429ab2949d1a2c1c400991d48a6()
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

      private sealed class MTHD_363835e8b971463a9f93b1901ca3047d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_363835e8b971463a9f93b1901ca3047d()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_6d86de2a85884fb89a9eca976fbbb92e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d86de2a85884fb89a9eca976fbbb92e()
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

      private sealed class MTHD_27c46b1f272a4f74896d7365a44b6d9c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_27c46b1f272a4f74896d7365a44b6d9c()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_732e461e2a994288888e4621fe774aa2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_732e461e2a994288888e4621fe774aa2()
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

      private sealed class MTHD_de6305b36edb4cc0bf687d4e623074fb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de6305b36edb4cc0bf687d4e623074fb()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_d9c6dcc34591460889059efaadb672f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d9c6dcc34591460889059efaadb672f6()
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

      private sealed class MTHD_24bd4e07ad94498e9d25ac6d87099b77 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24bd4e07ad94498e9d25ac6d87099b77()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_6af4e208fbb84aa39f154ab294812b93 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6af4e208fbb84aa39f154ab294812b93()
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

      private sealed class MTHD_299cccff447449f2a7cbf664df02ae00 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_299cccff447449f2a7cbf664df02ae00()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_2b2507331900447c9076c7c78cffc19d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2b2507331900447c9076c7c78cffc19d()
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

      private sealed class MTHD_917a396f81e8425a8623fbe2b035380d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_917a396f81e8425a8623fbe2b035380d()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_3700985e6f1c42d7be1b88ef7290052c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3700985e6f1c42d7be1b88ef7290052c()
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

      private sealed class MTHD_53c758ca1b0741b09b766bd24b5a7bb1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_53c758ca1b0741b09b766bd24b5a7bb1()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_0afb751449f54cb0bdacb98782ff0cbe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0afb751449f54cb0bdacb98782ff0cbe()
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

      private sealed class MTHD_8ddf48775470480984e3aa10e8ceb906 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ddf48775470480984e3aa10e8ceb906()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_ed94330b76404f55b46fdc609d80e747 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed94330b76404f55b46fdc609d80e747()
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

      private sealed class MTHD_d21f48594309408197eb0d5d2168b9e6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d21f48594309408197eb0d5d2168b9e6()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_833aabbca38445d6ae72a2e1d175937c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_833aabbca38445d6ae72a2e1d175937c()
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

      private sealed class MTHD_bb89c00e89084918a40e0e0c3d342eff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bb89c00e89084918a40e0e0c3d342eff()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_d04c3b869073406f8e64797ecccd58d9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d04c3b869073406f8e64797ecccd58d9()
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

      private sealed class MTHD_008e965267cd410bb4b86760dcf2886d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_008e965267cd410bb4b86760dcf2886d()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_a1a387a88f5c4ba198fec380b9b93c2d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1a387a88f5c4ba198fec380b9b93c2d()
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

      private sealed class MTHD_570befed59f740f1959703abeaeabe33 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_570befed59f740f1959703abeaeabe33()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_8e0d20c2d5f349839d09b8089ff45c31 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e0d20c2d5f349839d09b8089ff45c31()
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

      private sealed class MTHD_f216dc719d70497881a2bed4c268adc3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f216dc719d70497881a2bed4c268adc3()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_8ab111550c33430cb8f29613a76ebb6d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ab111550c33430cb8f29613a76ebb6d()
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

      private sealed class MTHD_322c7f798e304cb89f4909fa8923deeb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_322c7f798e304cb89f4909fa8923deeb()
        {
          this.Initialize("get_onClick2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick2;
        }
      }

      private sealed class MTHD_f6f1c5fe98e14874ae80310df0a0d3f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f6f1c5fe98e14874ae80310df0a0d3f4()
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

      private sealed class MTHD_189be934be254eb3b934260e079ec8bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_189be934be254eb3b934260e079ec8bb()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_74fc6e963fb342ea8d8c42946d25388b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74fc6e963fb342ea8d8c42946d25388b()
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

      private sealed class MTHD_df9d32591bf7491abee1b5bd7e310dc1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_df9d32591bf7491abee1b5bd7e310dc1()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color2;
        }
      }

      private sealed class MTHD_a1d40bb953cb442289b5ea401f31afdc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1d40bb953cb442289b5ea401f31afdc()
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

      private sealed class MTHD_2dca27aa36004b98826b823baebea133 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2dca27aa36004b98826b823baebea133()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_54fc1c1685864637a4efeac35210badb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_54fc1c1685864637a4efeac35210badb()
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

      private sealed class MTHD_e0a3518705574566bd458b09d1657435 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e0a3518705574566bd458b09d1657435()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_efaca5ae8eb94507bf69c173a03c6dc4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_efaca5ae8eb94507bf69c173a03c6dc4()
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

      private sealed class MTHD_281a36ab6ca5468d87eae205f4a719b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_281a36ab6ca5468d87eae205f4a719b9()
        {
          this.Initialize("get_textColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor2;
        }
      }

      private sealed class MTHD_fb20fd4216d741dfad3c6fc5f1d04635 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb20fd4216d741dfad3c6fc5f1d04635()
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

      private sealed class MTHD_30727b60712a44f19d4a645fb5e5889d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_30727b60712a44f19d4a645fb5e5889d()
        {
          this.Initialize("get_highlightColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor;
        }
      }

      private sealed class MTHD_734cd6120c0b4af0b6f642a404618c09 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_734cd6120c0b4af0b6f642a404618c09()
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

      private sealed class MTHD_decad062b02b480dafef2ac6fb01e296 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_decad062b02b480dafef2ac6fb01e296()
        {
          this.Initialize("get_highlightColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor2;
        }
      }

      private sealed class MTHD_d6f6b4c8fa82401f80ef7c147ea039e0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6f6b4c8fa82401f80ef7c147ea039e0()
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

      private sealed class MTHD_b11294108b194afbb9a5c4338d437075 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b11294108b194afbb9a5c4338d437075()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_d37be37217b64c799ee4645c5b1e44b8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d37be37217b64c799ee4645c5b1e44b8()
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

      private sealed class MTHD_298ae23da8fd48498479077e1099d688 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_298ae23da8fd48498479077e1099d688()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_57c2c98d9cb84b06b4ae80c488fdb613 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57c2c98d9cb84b06b4ae80c488fdb613()
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

      private sealed class MTHD_2886c265384d4c5bbf3135e6bf337e85 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2886c265384d4c5bbf3135e6bf337e85()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_2a871a44892941d38eeb80add90e376b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a871a44892941d38eeb80add90e376b()
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

      private sealed class MTHD_aee7e212cf1743e080bd4b80d1e32443 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aee7e212cf1743e080bd4b80d1e32443()
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

      private sealed class MTHD_bbd5023e7f3840ca8b5070f965876247 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bbd5023e7f3840ca8b5070f965876247()
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

      private sealed class MTHD_6a130bd77c784ded86d662403d8dfddd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6a130bd77c784ded86d662403d8dfddd()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_25061fbad0584653b5bcb2517f4d745c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_25061fbad0584653b5bcb2517f4d745c()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_9c73ba2add3b4c5cbfc8bc99647a4b5a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c73ba2add3b4c5cbfc8bc99647a4b5a()
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

      private sealed class MTHD_d06eae572baa4e18a582a551fd1b1e7e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d06eae572baa4e18a582a551fd1b1e7e()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_c4499d83a2e84daa942f7ae3cd61588a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c4499d83a2e84daa942f7ae3cd61588a()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_a5782602426d4a349fabbbd46c2f198f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a5782602426d4a349fabbbd46c2f198f()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_a493555313de4842b415e9791dab9857 : HardwiredMemberDescriptor
      {
        internal PROP_a493555313de4842b415e9791dab9857()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_dc9c684d1484419a9528e3e1ea32cefb : HardwiredMemberDescriptor
      {
        internal PROP_dc9c684d1484419a9528e3e1ea32cefb()
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

      private sealed class PROP_7c26d87679064512ace2d11fe5a29c82 : HardwiredMemberDescriptor
      {
        internal PROP_7c26d87679064512ace2d11fe5a29c82()
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

      private sealed class PROP_b9e61e45234e4269a54066ca08cf9f4d : HardwiredMemberDescriptor
      {
        internal PROP_b9e61e45234e4269a54066ca08cf9f4d()
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

      private sealed class PROP_96c8f25bba3c48ec8de8d262758ea834 : HardwiredMemberDescriptor
      {
        internal PROP_96c8f25bba3c48ec8de8d262758ea834()
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

      private sealed class PROP_7c4a7449f8c84cd1a3f5e8feabc3285a : HardwiredMemberDescriptor
      {
        internal PROP_7c4a7449f8c84cd1a3f5e8feabc3285a()
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

      private sealed class PROP_0158249ca59e4215afcdf0894fab4fa6 : HardwiredMemberDescriptor
      {
        internal PROP_0158249ca59e4215afcdf0894fab4fa6()
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

      private sealed class PROP_e2dcad2cb78645c4b18a2e71b4e2b047 : HardwiredMemberDescriptor
      {
        internal PROP_e2dcad2cb78645c4b18a2e71b4e2b047()
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

      private sealed class PROP_330fce32c1c04ba8a06766102f2597bb : HardwiredMemberDescriptor
      {
        internal PROP_330fce32c1c04ba8a06766102f2597bb()
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

      private sealed class PROP_d6984b20e49541efa4c63c81fd3a50b3 : HardwiredMemberDescriptor
      {
        internal PROP_d6984b20e49541efa4c63c81fd3a50b3()
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

      private sealed class PROP_e63d9327f25643ab8062f234a36289e8 : HardwiredMemberDescriptor
      {
        internal PROP_e63d9327f25643ab8062f234a36289e8()
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

      private sealed class PROP_3225cae640ff4e3483a7f2645f4a1f57 : HardwiredMemberDescriptor
      {
        internal PROP_3225cae640ff4e3483a7f2645f4a1f57()
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

      private sealed class PROP_b9be27daf4154c6b92c6fa18959810e0 : HardwiredMemberDescriptor
      {
        internal PROP_b9be27daf4154c6b92c6fa18959810e0()
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

      private sealed class PROP_1296d774f1ce4721bbc539452fc40b8c : HardwiredMemberDescriptor
      {
        internal PROP_1296d774f1ce4721bbc539452fc40b8c()
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

      private sealed class PROP_06c572a311b6418493ed8d554d89513d : HardwiredMemberDescriptor
      {
        internal PROP_06c572a311b6418493ed8d554d89513d()
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

      private sealed class PROP_5baed13b5cbb4809973c07cbfc359aa9 : HardwiredMemberDescriptor
      {
        internal PROP_5baed13b5cbb4809973c07cbfc359aa9()
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

      private sealed class PROP_ee1662638c974e559ab285d5b5dcd87d : HardwiredMemberDescriptor
      {
        internal PROP_ee1662638c974e559ab285d5b5dcd87d()
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

      private sealed class PROP_da973dcf5c514afdaf2d480f91492f18 : HardwiredMemberDescriptor
      {
        internal PROP_da973dcf5c514afdaf2d480f91492f18()
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

      private sealed class PROP_4ac2c0648ec440afbcd98a5087ef3453 : HardwiredMemberDescriptor
      {
        internal PROP_4ac2c0648ec440afbcd98a5087ef3453()
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

      private sealed class PROP_52040223f32741eea0fb4d289b040445 : HardwiredMemberDescriptor
      {
        internal PROP_52040223f32741eea0fb4d289b040445()
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

      private sealed class PROP_71eb8b02b5d24df39083e126b045da67 : HardwiredMemberDescriptor
      {
        internal PROP_71eb8b02b5d24df39083e126b045da67()
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

      private sealed class PROP_8bdc2e02d78540918fba954afb8a64aa : HardwiredMemberDescriptor
      {
        internal PROP_8bdc2e02d78540918fba954afb8a64aa()
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

      private sealed class PROP_2537d8e81fce49c696dcaa29c1053ce0 : HardwiredMemberDescriptor
      {
        internal PROP_2537d8e81fce49c696dcaa29c1053ce0()
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

      private sealed class PROP_68be983636c14554925f1be142d8dc38 : HardwiredMemberDescriptor
      {
        internal PROP_68be983636c14554925f1be142d8dc38()
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

      private sealed class PROP_48777da405644e1da2db18726ccdaf1f : HardwiredMemberDescriptor
      {
        internal PROP_48777da405644e1da2db18726ccdaf1f()
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

      private sealed class FLDV_4c4f50bfa0c04ccfa579b7809d99d26d : HardwiredMemberDescriptor
      {
        internal FLDV_4c4f50bfa0c04ccfa579b7809d99d26d()
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

      private sealed class FLDV_d9e4c1ebb7624221b9436f5b1f757849 : HardwiredMemberDescriptor
      {
        internal FLDV_d9e4c1ebb7624221b9436f5b1f757849()
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

      private sealed class FLDV_1bd9a1c311dd4384b533c770b7c13a66 : HardwiredMemberDescriptor
      {
        internal FLDV_1bd9a1c311dd4384b533c770b7c13a66()
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

    private sealed class TYPE_16cf9a4163d34cef8710a4f3581513a0 : HardwiredUserDataDescriptor
    {
      internal TYPE_16cf9a4163d34cef8710a4f3581513a0()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_16cf9a4163d34cef8710a4f3581513a0.MTHD_529cf487b3d74ccd885037eeae833b80()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_16cf9a4163d34cef8710a4f3581513a0.MTHD_ea6d3c53211d4f329fbf0846320d7cc6()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_16cf9a4163d34cef8710a4f3581513a0.MTHD_75a1999b7bb140afb0386bc6f77c486d()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_16cf9a4163d34cef8710a4f3581513a0.MTHD_5b10b57856234fed85e0476755c5d6b0()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_16cf9a4163d34cef8710a4f3581513a0.MTHD_d303e482a69e436c91ec723fcaef4d59()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_16cf9a4163d34cef8710a4f3581513a0.MTHD_37f9d333e5864a209be04c2ca7a2fc63()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_16cf9a4163d34cef8710a4f3581513a0.FLDV_25c963a9cd4944b488027c6cc68e5d9a());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_16cf9a4163d34cef8710a4f3581513a0.FLDV_e9582bbbf94947908ecd01180db1128e());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_16cf9a4163d34cef8710a4f3581513a0.FLDV_bc0e5b9a271d43f5b3cbbf754ac091f7());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_16cf9a4163d34cef8710a4f3581513a0.FLDV_057b813e63cc46f7992f39350814f480());
      }

      private sealed class MTHD_529cf487b3d74ccd885037eeae833b80 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_529cf487b3d74ccd885037eeae833b80()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_ea6d3c53211d4f329fbf0846320d7cc6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea6d3c53211d4f329fbf0846320d7cc6()
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

      private sealed class MTHD_75a1999b7bb140afb0386bc6f77c486d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75a1999b7bb140afb0386bc6f77c486d()
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

      private sealed class MTHD_5b10b57856234fed85e0476755c5d6b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5b10b57856234fed85e0476755c5d6b0()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_d303e482a69e436c91ec723fcaef4d59 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d303e482a69e436c91ec723fcaef4d59()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_37f9d333e5864a209be04c2ca7a2fc63 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_37f9d333e5864a209be04c2ca7a2fc63()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_25c963a9cd4944b488027c6cc68e5d9a : HardwiredMemberDescriptor
      {
        internal FLDV_25c963a9cd4944b488027c6cc68e5d9a()
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

      private sealed class FLDV_e9582bbbf94947908ecd01180db1128e : HardwiredMemberDescriptor
      {
        internal FLDV_e9582bbbf94947908ecd01180db1128e()
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

      private sealed class FLDV_bc0e5b9a271d43f5b3cbbf754ac091f7 : HardwiredMemberDescriptor
      {
        internal FLDV_bc0e5b9a271d43f5b3cbbf754ac091f7()
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

      private sealed class FLDV_057b813e63cc46f7992f39350814f480 : HardwiredMemberDescriptor
      {
        internal FLDV_057b813e63cc46f7992f39350814f480()
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

    private sealed class TYPE_4d69c32f00594122bf32a45b5d52f536 : HardwiredUserDataDescriptor
    {
      internal TYPE_4d69c32f00594122bf32a45b5d52f536()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4d69c32f00594122bf32a45b5d52f536.MTHD_094d272831ae4bd8aca4d0cb2465b22d()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4d69c32f00594122bf32a45b5d52f536.MTHD_760d5e00014541bcbc40a12f4bd7fced()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4d69c32f00594122bf32a45b5d52f536.MTHD_d3eb66fe0dd9454caea36f0715982e9e()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4d69c32f00594122bf32a45b5d52f536.MTHD_ed82e56ab9c04e45bc514d290891df65()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4d69c32f00594122bf32a45b5d52f536.MTHD_c3209a7a370446aa98ab482d9838b425()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_4d69c32f00594122bf32a45b5d52f536.FLDV_9dd7ec26d1ae48eaa9302e26c997e12f());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_4d69c32f00594122bf32a45b5d52f536.FLDV_fd028a4b248c44df86ca54fe5f0e3c1a());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_4d69c32f00594122bf32a45b5d52f536.FLDV_75eb5fb25adf409fbb8193a593e21ce9());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_4d69c32f00594122bf32a45b5d52f536.FLDV_0a7fe2ff9a0d43908d15ca8c78225786());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_4d69c32f00594122bf32a45b5d52f536.FLDV_e6e6c85ac71844aca91084bc451c5d47());
      }

      private sealed class MTHD_094d272831ae4bd8aca4d0cb2465b22d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_094d272831ae4bd8aca4d0cb2465b22d()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_760d5e00014541bcbc40a12f4bd7fced : HardwiredMethodMemberDescriptor
      {
        internal MTHD_760d5e00014541bcbc40a12f4bd7fced()
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

      private sealed class MTHD_d3eb66fe0dd9454caea36f0715982e9e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d3eb66fe0dd9454caea36f0715982e9e()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_ed82e56ab9c04e45bc514d290891df65 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ed82e56ab9c04e45bc514d290891df65()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_c3209a7a370446aa98ab482d9838b425 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c3209a7a370446aa98ab482d9838b425()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_9dd7ec26d1ae48eaa9302e26c997e12f : HardwiredMemberDescriptor
      {
        internal FLDV_9dd7ec26d1ae48eaa9302e26c997e12f()
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

      private sealed class FLDV_fd028a4b248c44df86ca54fe5f0e3c1a : HardwiredMemberDescriptor
      {
        internal FLDV_fd028a4b248c44df86ca54fe5f0e3c1a()
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

      private sealed class FLDV_75eb5fb25adf409fbb8193a593e21ce9 : HardwiredMemberDescriptor
      {
        internal FLDV_75eb5fb25adf409fbb8193a593e21ce9()
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

      private sealed class FLDV_0a7fe2ff9a0d43908d15ca8c78225786 : HardwiredMemberDescriptor
      {
        internal FLDV_0a7fe2ff9a0d43908d15ca8c78225786()
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

      private sealed class FLDV_e6e6c85ac71844aca91084bc451c5d47 : HardwiredMemberDescriptor
      {
        internal FLDV_e6e6c85ac71844aca91084bc451c5d47()
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

    private sealed class TYPE_7ec2922f53c043a5bfba71a13af3af4c : HardwiredUserDataDescriptor
    {
      internal TYPE_7ec2922f53c043a5bfba71a13af3af4c()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7ec2922f53c043a5bfba71a13af3af4c.MTHD_e8d39e7d61c3454881277cea2fe1c5ba()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7ec2922f53c043a5bfba71a13af3af4c.MTHD_b96be7401ae44f7a964a05d5146370ad()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7ec2922f53c043a5bfba71a13af3af4c.MTHD_2427f84258104fa8aaa9d0584649c43c()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7ec2922f53c043a5bfba71a13af3af4c.MTHD_494e750acac24fa88737716bb208bbc2()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7ec2922f53c043a5bfba71a13af3af4c.MTHD_e5001a58d04c46e7abe9e28e728daa7b()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7ec2922f53c043a5bfba71a13af3af4c.MTHD_c39c8ed2310b4da886c874442aa9f39c()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7ec2922f53c043a5bfba71a13af3af4c.MTHD_df5087d1ed29474f8601f16e12aff3fa()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7ec2922f53c043a5bfba71a13af3af4c.MTHD_dbeca92a54a64d528b5db6c0ca544dd7()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7ec2922f53c043a5bfba71a13af3af4c.MTHD_67f8ac2b479a431f810a68c511f05d27()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7ec2922f53c043a5bfba71a13af3af4c.MTHD_e76c87200d1b49888d4bca9f06889017()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7ec2922f53c043a5bfba71a13af3af4c.MTHD_57b3ca5b5b964655a491c3766299da13()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7ec2922f53c043a5bfba71a13af3af4c.MTHD_91b135cf3c4f45a182bdd1c73454afce()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_7ec2922f53c043a5bfba71a13af3af4c.MTHD_b4afaaf477e548f3b5ef0c0c958a4e9f()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_7ec2922f53c043a5bfba71a13af3af4c.FLDV_2f515e946b034ebc8218f9ec9cd0dbe8());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_7ec2922f53c043a5bfba71a13af3af4c.FLDV_63bf0fc9952a4619992061ce4ce808e9());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_7ec2922f53c043a5bfba71a13af3af4c.FLDV_9095a84fc07846a0813a05a3c7106743());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_7ec2922f53c043a5bfba71a13af3af4c.FLDV_e1410d42c4b046dab68c241a7b4c8014());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_7ec2922f53c043a5bfba71a13af3af4c.FLDV_b19e47fbfab341bfba544688a72cb61e());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_7ec2922f53c043a5bfba71a13af3af4c.FLDV_1d627810f29643c584f681c11fa596a1());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_7ec2922f53c043a5bfba71a13af3af4c.FLDV_e94285b23102495ebcfcebf7b8599683());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_7ec2922f53c043a5bfba71a13af3af4c.FLDV_9cd5c739128d4f59861b25190f29ac96());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_7ec2922f53c043a5bfba71a13af3af4c.DVAL_94f177b58c954457b1139681a3768a74());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_7ec2922f53c043a5bfba71a13af3af4c.DVAL_5097309a9d464917891a9fc21d8850df());
      }

      private sealed class MTHD_e8d39e7d61c3454881277cea2fe1c5ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e8d39e7d61c3454881277cea2fe1c5ba()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_b96be7401ae44f7a964a05d5146370ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b96be7401ae44f7a964a05d5146370ad()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_2427f84258104fa8aaa9d0584649c43c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2427f84258104fa8aaa9d0584649c43c()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_494e750acac24fa88737716bb208bbc2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_494e750acac24fa88737716bb208bbc2()
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

      private sealed class MTHD_e5001a58d04c46e7abe9e28e728daa7b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e5001a58d04c46e7abe9e28e728daa7b()
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

      private sealed class MTHD_c39c8ed2310b4da886c874442aa9f39c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c39c8ed2310b4da886c874442aa9f39c()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_df5087d1ed29474f8601f16e12aff3fa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_df5087d1ed29474f8601f16e12aff3fa()
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

      private sealed class MTHD_dbeca92a54a64d528b5db6c0ca544dd7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dbeca92a54a64d528b5db6c0ca544dd7()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_67f8ac2b479a431f810a68c511f05d27 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_67f8ac2b479a431f810a68c511f05d27()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_e76c87200d1b49888d4bca9f06889017 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e76c87200d1b49888d4bca9f06889017()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_57b3ca5b5b964655a491c3766299da13 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_57b3ca5b5b964655a491c3766299da13()
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

      private sealed class MTHD_91b135cf3c4f45a182bdd1c73454afce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_91b135cf3c4f45a182bdd1c73454afce()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_b4afaaf477e548f3b5ef0c0c958a4e9f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b4afaaf477e548f3b5ef0c0c958a4e9f()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_2f515e946b034ebc8218f9ec9cd0dbe8 : HardwiredMemberDescriptor
      {
        internal FLDV_2f515e946b034ebc8218f9ec9cd0dbe8()
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

      private sealed class FLDV_63bf0fc9952a4619992061ce4ce808e9 : HardwiredMemberDescriptor
      {
        internal FLDV_63bf0fc9952a4619992061ce4ce808e9()
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

      private sealed class FLDV_9095a84fc07846a0813a05a3c7106743 : HardwiredMemberDescriptor
      {
        internal FLDV_9095a84fc07846a0813a05a3c7106743()
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

      private sealed class FLDV_e1410d42c4b046dab68c241a7b4c8014 : HardwiredMemberDescriptor
      {
        internal FLDV_e1410d42c4b046dab68c241a7b4c8014()
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

      private sealed class FLDV_b19e47fbfab341bfba544688a72cb61e : HardwiredMemberDescriptor
      {
        internal FLDV_b19e47fbfab341bfba544688a72cb61e()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_1d627810f29643c584f681c11fa596a1 : HardwiredMemberDescriptor
      {
        internal FLDV_1d627810f29643c584f681c11fa596a1()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_e94285b23102495ebcfcebf7b8599683 : HardwiredMemberDescriptor
      {
        internal FLDV_e94285b23102495ebcfcebf7b8599683()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_9cd5c739128d4f59861b25190f29ac96 : HardwiredMemberDescriptor
      {
        internal FLDV_9cd5c739128d4f59861b25190f29ac96()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_94f177b58c954457b1139681a3768a74 : DynValueMemberDescriptor
      {
        internal DVAL_94f177b58c954457b1139681a3768a74()
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

      private sealed class DVAL_5097309a9d464917891a9fc21d8850df : DynValueMemberDescriptor
      {
        internal DVAL_5097309a9d464917891a9fc21d8850df()
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

    private sealed class TYPE_13b4325a5c7f4a79a84cb4307ec5539e : HardwiredUserDataDescriptor
    {
      internal TYPE_13b4325a5c7f4a79a84cb4307ec5539e()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_13b4325a5c7f4a79a84cb4307ec5539e.MTHD_2fc9bc27b9d74c928f06b9b2b08c254e()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_13b4325a5c7f4a79a84cb4307ec5539e.MTHD_a1141e6690e34440b36e28f912d52b16()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_13b4325a5c7f4a79a84cb4307ec5539e.MTHD_46504d8f854e4c18a3647f1e689bc457(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_13b4325a5c7f4a79a84cb4307ec5539e.MTHD_9dcbc7f2eddf42399440ee3249c45878()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_13b4325a5c7f4a79a84cb4307ec5539e.MTHD_b20e30a8e13940f7a0941ba436131458(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_13b4325a5c7f4a79a84cb4307ec5539e.MTHD_930e855f44c84046bb3811ed88cb1d3f()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_13b4325a5c7f4a79a84cb4307ec5539e.MTHD_b0a24307789f45dab534ea29de503b7d()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_13b4325a5c7f4a79a84cb4307ec5539e.MTHD_e7e58a9e9ca14206becdcd50187672d2()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_13b4325a5c7f4a79a84cb4307ec5539e.MTHD_b5e65bde44574868afe090fc5ac5d26c()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_13b4325a5c7f4a79a84cb4307ec5539e.MTHD_41f89d647aba489685de9c83a3c42450()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_13b4325a5c7f4a79a84cb4307ec5539e.FLDV_5326df400f3f45e4a024d544e21487e1());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_13b4325a5c7f4a79a84cb4307ec5539e.FLDV_8a3ffd360e014457b9569b0df585d610());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_13b4325a5c7f4a79a84cb4307ec5539e.FLDV_2f04a1c84c404a4b99a40affc1f18bf9());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_13b4325a5c7f4a79a84cb4307ec5539e.FLDV_83e2347dfbeb46fea2056c09c82bf002());
        this.AddMember("white", (IMemberDescriptor) new Bridge.TYPE_13b4325a5c7f4a79a84cb4307ec5539e.FLDV_f20879e8a0164765ac8348fca3ab9db8());
      }

      private sealed class MTHD_2fc9bc27b9d74c928f06b9b2b08c254e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2fc9bc27b9d74c928f06b9b2b08c254e()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_a1141e6690e34440b36e28f912d52b16 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1141e6690e34440b36e28f912d52b16()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_46504d8f854e4c18a3647f1e689bc457 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_46504d8f854e4c18a3647f1e689bc457()
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

      private sealed class MTHD_9dcbc7f2eddf42399440ee3249c45878 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9dcbc7f2eddf42399440ee3249c45878()
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

      private sealed class MTHD_b20e30a8e13940f7a0941ba436131458 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b20e30a8e13940f7a0941ba436131458()
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

      private sealed class MTHD_930e855f44c84046bb3811ed88cb1d3f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_930e855f44c84046bb3811ed88cb1d3f()
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

      private sealed class MTHD_b0a24307789f45dab534ea29de503b7d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b0a24307789f45dab534ea29de503b7d()
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

      private sealed class MTHD_e7e58a9e9ca14206becdcd50187672d2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7e58a9e9ca14206becdcd50187672d2()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_b5e65bde44574868afe090fc5ac5d26c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b5e65bde44574868afe090fc5ac5d26c()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_41f89d647aba489685de9c83a3c42450 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41f89d647aba489685de9c83a3c42450()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_5326df400f3f45e4a024d544e21487e1 : HardwiredMemberDescriptor
      {
        internal FLDV_5326df400f3f45e4a024d544e21487e1()
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

      private sealed class FLDV_8a3ffd360e014457b9569b0df585d610 : HardwiredMemberDescriptor
      {
        internal FLDV_8a3ffd360e014457b9569b0df585d610()
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

      private sealed class FLDV_2f04a1c84c404a4b99a40affc1f18bf9 : HardwiredMemberDescriptor
      {
        internal FLDV_2f04a1c84c404a4b99a40affc1f18bf9()
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

      private sealed class FLDV_83e2347dfbeb46fea2056c09c82bf002 : HardwiredMemberDescriptor
      {
        internal FLDV_83e2347dfbeb46fea2056c09c82bf002()
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

      private sealed class FLDV_f20879e8a0164765ac8348fca3ab9db8 : HardwiredMemberDescriptor
      {
        internal FLDV_f20879e8a0164765ac8348fca3ab9db8()
          : base(typeof (LuaColor), "white", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) LuaColor.white;
        }
      }
    }

    private sealed class TYPE_1fa84e9bd1964663841dfe4a54f1afc0 : HardwiredUserDataDescriptor
    {
      internal TYPE_1fa84e9bd1964663841dfe4a54f1afc0()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1fa84e9bd1964663841dfe4a54f1afc0.MTHD_97b78d981aac4f809b0769010019c9e5()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1fa84e9bd1964663841dfe4a54f1afc0.MTHD_bbbd696d1ff340fcaa7c918841ee5c17()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1fa84e9bd1964663841dfe4a54f1afc0.MTHD_803e3e6ee430484ab0dcfe6ee9a5e6a3()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1fa84e9bd1964663841dfe4a54f1afc0.MTHD_75491b095a5142c3b85a3029152e714f()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_1fa84e9bd1964663841dfe4a54f1afc0.MTHD_d77d8328150a4217898efd9532fd2685()
        }));
      }

      private sealed class MTHD_97b78d981aac4f809b0769010019c9e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_97b78d981aac4f809b0769010019c9e5()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_bbbd696d1ff340fcaa7c918841ee5c17 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bbbd696d1ff340fcaa7c918841ee5c17()
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

      private sealed class MTHD_803e3e6ee430484ab0dcfe6ee9a5e6a3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_803e3e6ee430484ab0dcfe6ee9a5e6a3()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_75491b095a5142c3b85a3029152e714f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_75491b095a5142c3b85a3029152e714f()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_d77d8328150a4217898efd9532fd2685 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d77d8328150a4217898efd9532fd2685()
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
