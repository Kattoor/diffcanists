
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
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_48019385a7e545d99071733c043c80c3());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_a4bdb6cb8f81422ba0a39ca2377d2a45());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_922a523ca23442e897e9a6abaf5ddd7a());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_dc30ddda57fc4efcaf62e0dbf73bb6ad());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_af9c7b103ddd4d81bc31553df9aa367e());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_bf829182a9cf485cbabae631e7ae1bb4());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_080d490a1b32483e90d0cfed6d331c3c());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_50086df340e24791ae600f782d2189d3());
      UserData.RegisterType((IUserDataDescriptor) new Bridge.TYPE_d31ed4f9de904dafb4dbf9ec05553fae());
    }

    private sealed class TYPE_4e389b4fe8004259b47448ae005ba933 : HardwiredUserDataDescriptor
    {
      internal TYPE_4e389b4fe8004259b47448ae005ba933()
        : base(typeof (ContainerGame))
      {
        this.AddMember("getUser", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getUser", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_954bdc21c7ed41538f06579ed07b7337()
        }));
        this.AddMember("getPlayers", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayers", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_ee3277a8350c4c4a8ea11ca998016791()
        }));
        this.AddMember("getPlayerCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getPlayerCount", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_cc47232077e9421985bf198b01b9f371()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_7ff98d5f634043e48c19674771ce47a4()
        }));
        this.AddMember("findCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_f3952ede4d844e838854d2a9837c870f()
        }));
        this.AddMember("findEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("findEffectors", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_502e4a8415764c5fac59ed81d000a401()
        }));
        this.AddMember("LineCast", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCast", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_5ac5415f472942a0ab3ea8fa4bb3016a()
        }));
        this.AddMember("LineCastOnlyCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyCreatures", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_7a1cc5c80835467992e590d3046908b4()
        }));
        this.AddMember("LineCastOnlyTerrain", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LineCastOnlyTerrain", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_da3f1600469049cf8cf7c37f19dca2bd()
        }));
        this.AddMember("ShowInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ShowInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_e33b2c648307438f966613eb3ce01b51()
        }));
        this.AddMember("hideInfo", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("hideInfo", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_d678de568cc746f78f956314fdb671c2()
        }));
        this.AddMember("Talk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Talk", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_17bfae7573f4456f9d6b6b73e3ac3ae5()
        }));
        this.AddMember("get_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_4feccb4a046a4503910930acd72320f4()
        }));
        this.AddMember("set_turn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_d8972b37ffad4a538722f4e6bade88f1()
        }));
        this.AddMember("get_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_99b8e970e3e640a8a0f26353f7db5a33()
        }));
        this.AddMember("set_timeLimit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_timeLimit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_9c62235fcb3948bcb70434dff3e77a9f()
        }));
        this.AddMember("get_totalTimeElapsed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_totalTimeElapsed", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_4bf1d120df9a40969881903c31d3b0c9()
        }));
        this.AddMember("get_turnTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnTime", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_638ed63b7d23466f8085f6d621d4be36()
        }));
        this.AddMember("get_frame", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frame", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_d91bfbda9196443b801d6eb1ad0c69ab()
        }));
        this.AddMember("random", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("random", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_4fdf6e5a1b2d41a58ce7970317cc2fa5()
        }));
        this.AddMember("get_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_c419425ed9f94a9ebb117dae0ba0b3e7()
        }));
        this.AddMember("set_winOnDeath", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_winOnDeath", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_814000228a0e451e9794f8a7048ffde3()
        }));
        this.AddMember("get_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_dc251b87312c4f29b873038149a71878()
        }));
        this.AddMember("set_allowMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_76844f9627a148bbabe70a2cb35d5cab()
        }));
        this.AddMember("get_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_11d31700976e42e29979b636cc361851()
        }));
        this.AddMember("set_allowMinionMovement", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowMinionMovement", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_fbf18bf9c5de490185d5cff07e537be4()
        }));
        this.AddMember("get_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_6b37c2570cba4ea5bbb80a2e0d77502c()
        }));
        this.AddMember("set_allowInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowInput", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_7c6e48b0eef247c2ace0c013d076a63c()
        }));
        this.AddMember("get_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_8fd49f34e20443a38829de76ad2f05cd()
        }));
        this.AddMember("set_allowCallbacks", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowCallbacks", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_fd2f5601ea1b4564806d911dad73d20b()
        }));
        this.AddMember("get_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_8fdd8a6de00f49559353d19437042171()
        }));
        this.AddMember("set_allowSkipTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowSkipTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_3a6e6c5fd9d64148b6f5e44653c9ff4a()
        }));
        this.AddMember("get_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_1aa6d35f271b4bc7b808d99a16faaa95()
        }));
        this.AddMember("set_terrainDestruction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_terrainDestruction", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_32e31803aa4a40679f09210f0631906d()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_2a3b67385ddb4e59bce08b40b03214d4()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_8b28deb23ab4481c9bac0a0be5af6443()
        }));
        this.AddMember("get_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_288def38addd49908b000c17d5d85841()
        }));
        this.AddMember("set_armageddon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddon", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_a180b92206e349cdbfd2e23f122f9de9()
        }));
        this.AddMember("get_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_38b5043b9d984530af9b5a887cb923c8()
        }));
        this.AddMember("set_armageddonTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_armageddonTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_8436c3a3c1934348bba28b908f4bdf1b()
        }));
        this.AddMember("get_waiting", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waiting", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_2060fb8c5f194e43a525edffc6a3de12()
        }));
        this.AddMember("get_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_f0319173a0054951920bf151180390b6()
        }));
        this.AddMember("set_paused", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_paused", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_fda69ae539534f4b8d6450cab22aa021()
        }));
        this.AddMember("get_busy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_busy", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_0be590dd00bb46f6a711cedd8aebc10e()
        }));
        this.AddMember("get_ongoing", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_ongoing", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_339b4b43db3b46eba56c38055143d315()
        }));
        this.AddMember("get_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_63534c8479a44737a1327ba28313021c()
        }));
        this.AddMember("set_gravity", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_gravity", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_396143fe74dc4794a248f12d737eb5a1()
        }));
        this.AddMember("get_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_6e14bbf84a72481fa62d5332191b3d87()
        }));
        this.AddMember("set_wind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_wind", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_826a1a545cc24abdbedbdd9d43d405ff()
        }));
        this.AddMember("get_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_7cddcd8f8c014fd6a0fe90475978146b()
        }));
        this.AddMember("set_windDir", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windDir", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_f8c4d3f95c054a7eb1df8fd16b451ee5()
        }));
        this.AddMember("get_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_f4181b068b1b412fb9e0912f3ce0af79()
        }));
        this.AddMember("set_windPower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_windPower", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_397189f3ff0541b2bf827366584adc2b()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_c2bfc8517f8647cab9e1b8641f874026()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_8dede4933a8348b590e3205f8538d35c()
        }));
        this.AddMember("get_mousePosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mousePosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_85f61fae09c144faaad240a693ddbe52()
        }));
        this.AddMember("get_mouseOverUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_mouseOverUI", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_3755d4ee13014d0aa96a654af2794a60()
        }));
        this.AddMember("worldToCanvas", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("worldToCanvas", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_52dccd1eceae416da9f78a91ac827859()
        }));
        this.AddMember("canvasToWorld", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("canvasToWorld", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_83b4460031634d9c90229cbae0d94591()
        }));
        this.AddMember("get_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_5a36c74454304581b1db6fd6505265f6()
        }));
        this.AddMember("set_cameraPosition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraPosition", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_ecf6d7bba0444689b3acf3fdd6b24313()
        }));
        this.AddMember("get_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_88b1a649f1f54a7391c240320fe8bf95()
        }));
        this.AddMember("set_cameraZoom", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_cameraZoom", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_b5840e54869c41e79509a2fbf35691d3()
        }));
        this.AddMember("getMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_46972b9d514941858883d334569f8aa0()
        }));
        this.AddMember("setMapPixel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setMapPixel", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_e5fa82b4425f4c1da16c4b377f685133()
        }));
        this.AddMember("Dispose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Dispose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_6c94295583b344bca7708d4ab7e9dbef()
        }));
        this.AddMember("drawImage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawImage", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_c732c6e0e82f4dc6b78d7e64d47165b4()
        }));
        this.AddMember("drawRectangle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawRectangle", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_cb5851e2c1de4758b6bb1a413f8e9b2d()
        }));
        this.AddMember("drawEllipseOutline", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipseOutline", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_5d94dd6dcfd4405c83844fdf10124ac2()
        }));
        this.AddMember("drawEllipse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("drawEllipse", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_8f8c37a641614f14a990b72ec579b264()
        }));
        this.AddMember("blit", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blit", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_f8da1e59cd64434fab9c434a618a9aa0()
        }));
        this.AddMember("blitRotate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("blitRotate", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_c8895c7ec1144bf4a582d1ba94b59286()
        }));
        this.AddMember("applyDraw", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("applyDraw", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_bf96c8b236ca4c11b090ed2e00f8e099()
        }));
        this.AddMember("get_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_ce2615eaab764ece980c1e7918864ea5()
        }));
        this.AddMember("set_allowBounce", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_allowBounce", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_072facda4ff640edb9ddbd26ee61264e()
        }));
        this.AddMember("get_isUsingTouchControls", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isUsingTouchControls", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_985d87f421fa46e9bbf1a258be1b418a()
        }));
        this.AddMember("clientRefreshSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clientRefreshSpells", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_8e3611519bac43c49f4ba628ee433f5b()
        }));
        this.AddMember("startCoroutine", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("startCoroutine", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_280950fd692f4527a1b3d7635df62cb8()
        }));
        this.AddMember("devCommand", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("devCommand", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_c8629233e8c94df8b6950707811109b9()
        }));
        this.AddMember("win", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("win", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_15d017a7b00941659adcc79d7f5f8de2()
        }));
        this.AddMember("lose", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("lose", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_7f318288396146dbb1c67a947c1933af()
        }));
        this.AddMember("nextTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("nextTurn", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_8360da7e213c4ce6998d59ea48633c03()
        }));
        this.AddMember("resetMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("resetMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_b36e86d3109140868268c5f598b53877()
        }));
        this.AddMember("clearMap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearMap", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_a7ce8727121b45b3abfcd2bfa97b6723()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_73be14ff391b422dbc6122c4f1bfbafe()
        }));
        this.AddMember("getSpellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellEnum", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_b0d4beafc4e24815aacde5022a49e042()
        }));
        this.AddMember("getSpellName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_4123af41c1244dcda6e00d7331dd0c37()
        }));
        this.AddMember("getMapID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapID", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_650c6484f6154494ba0b23583f14b191()
        }));
        this.AddMember("getMapRealName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapRealName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_7cdab76a06b441ef82850eb0edaf30b2()
        }));
        this.AddMember("getMapShortName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMapShortName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_4a7956c6dce94c839fee1218fc885fa2()
        }));
        this.AddMember("getArmageddonName", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getArmageddonName", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_4dae990e38194cb59760fbe7a67223b5()
        }));
        this.AddMember("panCamera", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("panCamera", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_93738d69633145e6b91beba8be49567f()
        }));
        this.AddMember("cameraFollow", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("cameraFollow", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_dc234c61adfe4f86a6ba8f9c4cbee627()
        }));
        this.AddMember("getInputString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getInputString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_8e9f26c0f5364aaaa3cae6c087904597()
        }));
        this.AddMember("get_screenWidth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenWidth", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_eb016aa45d084be0a4bf265757d5ecb1()
        }));
        this.AddMember("get_screenHeight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_screenHeight", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_a8dad25210d34a36b9fb94a4c9989f9d()
        }));
        this.AddMember("createCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createCreature", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_74bc463a23f244a288ee7604f7ee2dc4()
        }));
        this.AddMember("clearIndicators", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("clearIndicators", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_772923f0614a45f9839b279a56a3e0ff()
        }));
        this.AddMember("createIndicator", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createIndicator", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_2d97b5039ff2489685ea81cb404f535b(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_7996de09f56c4bfbaf39ba3212be32e6()
        }));
        this.AddMember("getKeyBinds", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getKeyBinds", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_76bfe2a2651c4792b1440850a6013305()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_aa0803ed89984a5d896ea0f1f63260ab()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_2c416382f8224dd58662b80eed3191d1()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_ef80a931f7824a6781f443f16331c920()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerGame), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.MTHD_f65a18d9b2b745eeac5717c7c7e55696()
        }));
        this.AddMember("turn", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_6814a38e082442a59e1d51af8f6273d2());
        this.AddMember("timeLimit", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_0385e3c87e094d6b8c415f35cfddabff());
        this.AddMember("totalTimeElapsed", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_932c2a1f29674fc3935a71bc9b3c9b69());
        this.AddMember("turnTime", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_ddf73e61ca984f299aa515159a01e521());
        this.AddMember("frame", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_7386b0bc28604694bbcb8eb707666450());
        this.AddMember("winOnDeath", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_27b690ffc4bc432d8500c320df35ee02());
        this.AddMember("allowMovement", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_c7649aca59c34299b12fc9c93659f0d4());
        this.AddMember("allowMinionMovement", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_e1749ea7cf7a4e04b7ba51a29681bfc2());
        this.AddMember("allowInput", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_df330463ca2e4c368d6e0c8a49347629());
        this.AddMember("allowCallbacks", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_8f7266e724b840a8be04951cda6e8f2d());
        this.AddMember("allowSkipTurn", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_aaac8a445f664020bfb2f5c1cbbab017());
        this.AddMember("terrainDestruction", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_1c4bd6a31c8f454787bee9310eda0c73());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_9d685a85c9d7477fb3d90450b16f0084());
        this.AddMember("armageddon", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_b24162e4338e40f89d1e0d94729c5d31());
        this.AddMember("armageddonTurn", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_b11ebf5e6ac9425aae59ef16716b6899());
        this.AddMember("waiting", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_1c0e12192e684de29f16d733db38dcdd());
        this.AddMember("paused", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_c0f33a8b6d3143e392782f424907d709());
        this.AddMember("busy", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_6beda7b14826482c9b39288520516a70());
        this.AddMember("ongoing", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_259ffffd85974a96897323571e92a1e9());
        this.AddMember("gravity", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_891b6eb337c44063ad95e82e6410f37f());
        this.AddMember("wind", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_c9d8c725136a472b8c583a8a3db8a1c4());
        this.AddMember("windDir", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_c446f4c7227a4894bed52e080ee6ca20());
        this.AddMember("windPower", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_8ed19bd4655c44cd8a03df84f48ece36());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_ac145e4261c742989a45350af30eb954());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_fdc5c27547d54cadae03c17904c9acf2());
        this.AddMember("mousePosition", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_cf3b6fbd73b44744ae97be13c6e3b563());
        this.AddMember("mouseOverUI", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_eddb9afff5924a73b1456d8c640eab2c());
        this.AddMember("cameraPosition", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_0e9541b581404b958784530ddb780af6());
        this.AddMember("cameraZoom", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_79f584c2f4ad406abf2bd38b9a66bdc2());
        this.AddMember("allowBounce", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_72d23af6da2049f5a9a9886b3746391f());
        this.AddMember("isUsingTouchControls", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_9f10b0ab8729415898f5068b5422552f());
        this.AddMember("screenWidth", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_80d85afe78454b4f999a7839366edfd4());
        this.AddMember("screenHeight", (IMemberDescriptor) new Bridge.TYPE_4e389b4fe8004259b47448ae005ba933.PROP_6bc55183221d432cad4e06f84c0955f3());
      }

      private sealed class MTHD_954bdc21c7ed41538f06579ed07b7337 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_954bdc21c7ed41538f06579ed07b7337()
        {
          this.Initialize("getUser", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getUser();
        }
      }

      private sealed class MTHD_ee3277a8350c4c4a8ea11ca998016791 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee3277a8350c4c4a8ea11ca998016791()
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

      private sealed class MTHD_cc47232077e9421985bf198b01b9f371 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cc47232077e9421985bf198b01b9f371()
        {
          this.Initialize("getPlayerCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getPlayerCount();
        }
      }

      private sealed class MTHD_7ff98d5f634043e48c19674771ce47a4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7ff98d5f634043e48c19674771ce47a4()
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

      private sealed class MTHD_f3952ede4d844e838854d2a9837c870f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f3952ede4d844e838854d2a9837c870f()
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

      private sealed class MTHD_502e4a8415764c5fac59ed81d000a401 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_502e4a8415764c5fac59ed81d000a401()
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

      private sealed class MTHD_5ac5415f472942a0ab3ea8fa4bb3016a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ac5415f472942a0ab3ea8fa4bb3016a()
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

      private sealed class MTHD_7a1cc5c80835467992e590d3046908b4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a1cc5c80835467992e590d3046908b4()
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

      private sealed class MTHD_da3f1600469049cf8cf7c37f19dca2bd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_da3f1600469049cf8cf7c37f19dca2bd()
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

      private sealed class MTHD_e33b2c648307438f966613eb3ce01b51 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e33b2c648307438f966613eb3ce01b51()
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

      private sealed class MTHD_d678de568cc746f78f956314fdb671c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d678de568cc746f78f956314fdb671c2()
        {
          this.Initialize("hideInfo", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).hideInfo();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_17bfae7573f4456f9d6b6b73e3ac3ae5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_17bfae7573f4456f9d6b6b73e3ac3ae5()
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

      private sealed class MTHD_4feccb4a046a4503910930acd72320f4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4feccb4a046a4503910930acd72320f4()
        {
          this.Initialize("get_turn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turn;
        }
      }

      private sealed class MTHD_d8972b37ffad4a538722f4e6bade88f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8972b37ffad4a538722f4e6bade88f1()
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

      private sealed class MTHD_99b8e970e3e640a8a0f26353f7db5a33 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_99b8e970e3e640a8a0f26353f7db5a33()
        {
          this.Initialize("get_timeLimit", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).timeLimit;
        }
      }

      private sealed class MTHD_9c62235fcb3948bcb70434dff3e77a9f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c62235fcb3948bcb70434dff3e77a9f()
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

      private sealed class MTHD_4bf1d120df9a40969881903c31d3b0c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4bf1d120df9a40969881903c31d3b0c9()
        {
          this.Initialize("get_totalTimeElapsed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class MTHD_638ed63b7d23466f8085f6d621d4be36 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_638ed63b7d23466f8085f6d621d4be36()
        {
          this.Initialize("get_turnTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class MTHD_d91bfbda9196443b801d6eb1ad0c69ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d91bfbda9196443b801d6eb1ad0c69ab()
        {
          this.Initialize("get_frame", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class MTHD_4fdf6e5a1b2d41a58ce7970317cc2fa5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4fdf6e5a1b2d41a58ce7970317cc2fa5()
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

      private sealed class MTHD_c419425ed9f94a9ebb117dae0ba0b3e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c419425ed9f94a9ebb117dae0ba0b3e7()
        {
          this.Initialize("get_winOnDeath", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).winOnDeath;
        }
      }

      private sealed class MTHD_814000228a0e451e9794f8a7048ffde3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_814000228a0e451e9794f8a7048ffde3()
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

      private sealed class MTHD_dc251b87312c4f29b873038149a71878 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc251b87312c4f29b873038149a71878()
        {
          this.Initialize("get_allowMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMovement;
        }
      }

      private sealed class MTHD_76844f9627a148bbabe70a2cb35d5cab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76844f9627a148bbabe70a2cb35d5cab()
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

      private sealed class MTHD_11d31700976e42e29979b636cc361851 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_11d31700976e42e29979b636cc361851()
        {
          this.Initialize("get_allowMinionMovement", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowMinionMovement;
        }
      }

      private sealed class MTHD_fbf18bf9c5de490185d5cff07e537be4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fbf18bf9c5de490185d5cff07e537be4()
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

      private sealed class MTHD_6b37c2570cba4ea5bbb80a2e0d77502c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b37c2570cba4ea5bbb80a2e0d77502c()
        {
          this.Initialize("get_allowInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowInput;
        }
      }

      private sealed class MTHD_7c6e48b0eef247c2ace0c013d076a63c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7c6e48b0eef247c2ace0c013d076a63c()
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

      private sealed class MTHD_8fd49f34e20443a38829de76ad2f05cd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8fd49f34e20443a38829de76ad2f05cd()
        {
          this.Initialize("get_allowCallbacks", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowCallbacks;
        }
      }

      private sealed class MTHD_fd2f5601ea1b4564806d911dad73d20b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fd2f5601ea1b4564806d911dad73d20b()
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

      private sealed class MTHD_8fdd8a6de00f49559353d19437042171 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8fdd8a6de00f49559353d19437042171()
        {
          this.Initialize("get_allowSkipTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowSkipTurn;
        }
      }

      private sealed class MTHD_3a6e6c5fd9d64148b6f5e44653c9ff4a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3a6e6c5fd9d64148b6f5e44653c9ff4a()
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

      private sealed class MTHD_1aa6d35f271b4bc7b808d99a16faaa95 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1aa6d35f271b4bc7b808d99a16faaa95()
        {
          this.Initialize("get_terrainDestruction", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).terrainDestruction;
        }
      }

      private sealed class MTHD_32e31803aa4a40679f09210f0631906d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_32e31803aa4a40679f09210f0631906d()
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

      private sealed class MTHD_2a3b67385ddb4e59bce08b40b03214d4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a3b67385ddb4e59bce08b40b03214d4()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).takeDamage;
        }
      }

      private sealed class MTHD_8b28deb23ab4481c9bac0a0be5af6443 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b28deb23ab4481c9bac0a0be5af6443()
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

      private sealed class MTHD_288def38addd49908b000c17d5d85841 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_288def38addd49908b000c17d5d85841()
        {
          this.Initialize("get_armageddon", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddon;
        }
      }

      private sealed class MTHD_a180b92206e349cdbfd2e23f122f9de9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a180b92206e349cdbfd2e23f122f9de9()
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

      private sealed class MTHD_38b5043b9d984530af9b5a887cb923c8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_38b5043b9d984530af9b5a887cb923c8()
        {
          this.Initialize("get_armageddonTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).armageddonTurn;
        }
      }

      private sealed class MTHD_8436c3a3c1934348bba28b908f4bdf1b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8436c3a3c1934348bba28b908f4bdf1b()
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

      private sealed class MTHD_2060fb8c5f194e43a525edffc6a3de12 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2060fb8c5f194e43a525edffc6a3de12()
        {
          this.Initialize("get_waiting", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class MTHD_f0319173a0054951920bf151180390b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f0319173a0054951920bf151180390b6()
        {
          this.Initialize("get_paused", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).paused;
        }
      }

      private sealed class MTHD_fda69ae539534f4b8d6450cab22aa021 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fda69ae539534f4b8d6450cab22aa021()
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

      private sealed class MTHD_0be590dd00bb46f6a711cedd8aebc10e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0be590dd00bb46f6a711cedd8aebc10e()
        {
          this.Initialize("get_busy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class MTHD_339b4b43db3b46eba56c38055143d315 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_339b4b43db3b46eba56c38055143d315()
        {
          this.Initialize("get_ongoing", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class MTHD_63534c8479a44737a1327ba28313021c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_63534c8479a44737a1327ba28313021c()
        {
          this.Initialize("get_gravity", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).gravity;
        }
      }

      private sealed class MTHD_396143fe74dc4794a248f12d737eb5a1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_396143fe74dc4794a248f12d737eb5a1()
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

      private sealed class MTHD_6e14bbf84a72481fa62d5332191b3d87 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6e14bbf84a72481fa62d5332191b3d87()
        {
          this.Initialize("get_wind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).wind;
        }
      }

      private sealed class MTHD_826a1a545cc24abdbedbdd9d43d405ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_826a1a545cc24abdbedbdd9d43d405ff()
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

      private sealed class MTHD_7cddcd8f8c014fd6a0fe90475978146b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7cddcd8f8c014fd6a0fe90475978146b()
        {
          this.Initialize("get_windDir", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windDir;
        }
      }

      private sealed class MTHD_f8c4d3f95c054a7eb1df8fd16b451ee5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f8c4d3f95c054a7eb1df8fd16b451ee5()
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

      private sealed class MTHD_f4181b068b1b412fb9e0912f3ce0af79 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f4181b068b1b412fb9e0912f3ce0af79()
        {
          this.Initialize("get_windPower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).windPower;
        }
      }

      private sealed class MTHD_397189f3ff0541b2bf827366584adc2b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_397189f3ff0541b2bf827366584adc2b()
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

      private sealed class MTHD_c2bfc8517f8647cab9e1b8641f874026 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c2bfc8517f8647cab9e1b8641f874026()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class MTHD_8dede4933a8348b590e3205f8538d35c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8dede4933a8348b590e3205f8538d35c()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class MTHD_85f61fae09c144faaad240a693ddbe52 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85f61fae09c144faaad240a693ddbe52()
        {
          this.Initialize("get_mousePosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class MTHD_3755d4ee13014d0aa96a654af2794a60 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3755d4ee13014d0aa96a654af2794a60()
        {
          this.Initialize("get_mouseOverUI", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class MTHD_52dccd1eceae416da9f78a91ac827859 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52dccd1eceae416da9f78a91ac827859()
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

      private sealed class MTHD_83b4460031634d9c90229cbae0d94591 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_83b4460031634d9c90229cbae0d94591()
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

      private sealed class MTHD_5a36c74454304581b1db6fd6505265f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5a36c74454304581b1db6fd6505265f6()
        {
          this.Initialize("get_cameraPosition", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraPosition;
        }
      }

      private sealed class MTHD_ecf6d7bba0444689b3acf3fdd6b24313 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ecf6d7bba0444689b3acf3fdd6b24313()
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

      private sealed class MTHD_88b1a649f1f54a7391c240320fe8bf95 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_88b1a649f1f54a7391c240320fe8bf95()
        {
          this.Initialize("get_cameraZoom", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).cameraZoom;
        }
      }

      private sealed class MTHD_b5840e54869c41e79509a2fbf35691d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b5840e54869c41e79509a2fbf35691d3()
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

      private sealed class MTHD_46972b9d514941858883d334569f8aa0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_46972b9d514941858883d334569f8aa0()
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

      private sealed class MTHD_e5fa82b4425f4c1da16c4b377f685133 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e5fa82b4425f4c1da16c4b377f685133()
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

      private sealed class MTHD_6c94295583b344bca7708d4ab7e9dbef : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6c94295583b344bca7708d4ab7e9dbef()
        {
          this.Initialize("Dispose", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ContainerGame.Dispose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_c732c6e0e82f4dc6b78d7e64d47165b4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c732c6e0e82f4dc6b78d7e64d47165b4()
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

      private sealed class MTHD_cb5851e2c1de4758b6bb1a413f8e9b2d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cb5851e2c1de4758b6bb1a413f8e9b2d()
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

      private sealed class MTHD_5d94dd6dcfd4405c83844fdf10124ac2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d94dd6dcfd4405c83844fdf10124ac2()
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

      private sealed class MTHD_8f8c37a641614f14a990b72ec579b264 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8f8c37a641614f14a990b72ec579b264()
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

      private sealed class MTHD_f8da1e59cd64434fab9c434a618a9aa0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f8da1e59cd64434fab9c434a618a9aa0()
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

      private sealed class MTHD_c8895c7ec1144bf4a582d1ba94b59286 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c8895c7ec1144bf4a582d1ba94b59286()
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

      private sealed class MTHD_bf96c8b236ca4c11b090ed2e00f8e099 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf96c8b236ca4c11b090ed2e00f8e099()
        {
          this.Initialize("applyDraw", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).applyDraw();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_ce2615eaab764ece980c1e7918864ea5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ce2615eaab764ece980c1e7918864ea5()
        {
          this.Initialize("get_allowBounce", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).allowBounce;
        }
      }

      private sealed class MTHD_072facda4ff640edb9ddbd26ee61264e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_072facda4ff640edb9ddbd26ee61264e()
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

      private sealed class MTHD_985d87f421fa46e9bbf1a258be1b418a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_985d87f421fa46e9bbf1a258be1b418a()
        {
          this.Initialize("get_isUsingTouchControls", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class MTHD_8e3611519bac43c49f4ba628ee433f5b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e3611519bac43c49f4ba628ee433f5b()
        {
          this.Initialize("clientRefreshSpells", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clientRefreshSpells();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_280950fd692f4527a1b3d7635df62cb8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_280950fd692f4527a1b3d7635df62cb8()
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

      private sealed class MTHD_c8629233e8c94df8b6950707811109b9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c8629233e8c94df8b6950707811109b9()
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

      private sealed class MTHD_15d017a7b00941659adcc79d7f5f8de2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15d017a7b00941659adcc79d7f5f8de2()
        {
          this.Initialize("win", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).win();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_7f318288396146dbb1c67a947c1933af : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f318288396146dbb1c67a947c1933af()
        {
          this.Initialize("lose", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).lose();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_8360da7e213c4ce6998d59ea48633c03 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8360da7e213c4ce6998d59ea48633c03()
        {
          this.Initialize("nextTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).nextTurn();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_b36e86d3109140868268c5f598b53877 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b36e86d3109140868268c5f598b53877()
        {
          this.Initialize("resetMap", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).resetMap();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_a7ce8727121b45b3abfcd2bfa97b6723 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a7ce8727121b45b3abfcd2bfa97b6723()
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

      private sealed class MTHD_73be14ff391b422dbc6122c4f1bfbafe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_73be14ff391b422dbc6122c4f1bfbafe()
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

      private sealed class MTHD_b0d4beafc4e24815aacde5022a49e042 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b0d4beafc4e24815aacde5022a49e042()
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

      private sealed class MTHD_4123af41c1244dcda6e00d7331dd0c37 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4123af41c1244dcda6e00d7331dd0c37()
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

      private sealed class MTHD_650c6484f6154494ba0b23583f14b191 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_650c6484f6154494ba0b23583f14b191()
        {
          this.Initialize("getMapID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getMapID();
        }
      }

      private sealed class MTHD_7cdab76a06b441ef82850eb0edaf30b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7cdab76a06b441ef82850eb0edaf30b2()
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

      private sealed class MTHD_4a7956c6dce94c839fee1218fc885fa2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a7956c6dce94c839fee1218fc885fa2()
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

      private sealed class MTHD_4dae990e38194cb59760fbe7a67223b5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4dae990e38194cb59760fbe7a67223b5()
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

      private sealed class MTHD_93738d69633145e6b91beba8be49567f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93738d69633145e6b91beba8be49567f()
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

      private sealed class MTHD_dc234c61adfe4f86a6ba8f9c4cbee627 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc234c61adfe4f86a6ba8f9c4cbee627()
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

      private sealed class MTHD_8e9f26c0f5364aaaa3cae6c087904597 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8e9f26c0f5364aaaa3cae6c087904597()
        {
          this.Initialize("getInputString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).getInputString();
        }
      }

      private sealed class MTHD_eb016aa45d084be0a4bf265757d5ecb1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_eb016aa45d084be0a4bf265757d5ecb1()
        {
          this.Initialize("get_screenWidth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class MTHD_a8dad25210d34a36b9fb94a4c9989f9d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a8dad25210d34a36b9fb94a4c9989f9d()
        {
          this.Initialize("get_screenHeight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }

      private sealed class MTHD_74bc463a23f244a288ee7604f7ee2dc4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_74bc463a23f244a288ee7604f7ee2dc4()
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

      private sealed class MTHD_772923f0614a45f9839b279a56a3e0ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_772923f0614a45f9839b279a56a3e0ff()
        {
          this.Initialize("clearIndicators", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerGame) obj).clearIndicators();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_2d97b5039ff2489685ea81cb404f535b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d97b5039ff2489685ea81cb404f535b()
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

      private sealed class MTHD_7996de09f56c4bfbaf39ba3212be32e6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7996de09f56c4bfbaf39ba3212be32e6()
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

      private sealed class MTHD_76bfe2a2651c4792b1440850a6013305 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_76bfe2a2651c4792b1440850a6013305()
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

      private sealed class MTHD_aa0803ed89984a5d896ea0f1f63260ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_aa0803ed89984a5d896ea0f1f63260ab()
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

      private sealed class MTHD_2c416382f8224dd58662b80eed3191d1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c416382f8224dd58662b80eed3191d1()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_ef80a931f7824a6781f443f16331c920 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef80a931f7824a6781f443f16331c920()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_f65a18d9b2b745eeac5717c7c7e55696 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f65a18d9b2b745eeac5717c7c7e55696()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_6814a38e082442a59e1d51af8f6273d2 : HardwiredMemberDescriptor
      {
        internal PROP_6814a38e082442a59e1d51af8f6273d2()
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

      private sealed class PROP_0385e3c87e094d6b8c415f35cfddabff : HardwiredMemberDescriptor
      {
        internal PROP_0385e3c87e094d6b8c415f35cfddabff()
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

      private sealed class PROP_932c2a1f29674fc3935a71bc9b3c9b69 : HardwiredMemberDescriptor
      {
        internal PROP_932c2a1f29674fc3935a71bc9b3c9b69()
          : base(typeof (double), "totalTimeElapsed", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).totalTimeElapsed;
        }
      }

      private sealed class PROP_ddf73e61ca984f299aa515159a01e521 : HardwiredMemberDescriptor
      {
        internal PROP_ddf73e61ca984f299aa515159a01e521()
          : base(typeof (double), "turnTime", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).turnTime;
        }
      }

      private sealed class PROP_7386b0bc28604694bbcb8eb707666450 : HardwiredMemberDescriptor
      {
        internal PROP_7386b0bc28604694bbcb8eb707666450()
          : base(typeof (int), "frame", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).frame;
        }
      }

      private sealed class PROP_27b690ffc4bc432d8500c320df35ee02 : HardwiredMemberDescriptor
      {
        internal PROP_27b690ffc4bc432d8500c320df35ee02()
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

      private sealed class PROP_c7649aca59c34299b12fc9c93659f0d4 : HardwiredMemberDescriptor
      {
        internal PROP_c7649aca59c34299b12fc9c93659f0d4()
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

      private sealed class PROP_e1749ea7cf7a4e04b7ba51a29681bfc2 : HardwiredMemberDescriptor
      {
        internal PROP_e1749ea7cf7a4e04b7ba51a29681bfc2()
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

      private sealed class PROP_df330463ca2e4c368d6e0c8a49347629 : HardwiredMemberDescriptor
      {
        internal PROP_df330463ca2e4c368d6e0c8a49347629()
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

      private sealed class PROP_8f7266e724b840a8be04951cda6e8f2d : HardwiredMemberDescriptor
      {
        internal PROP_8f7266e724b840a8be04951cda6e8f2d()
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

      private sealed class PROP_aaac8a445f664020bfb2f5c1cbbab017 : HardwiredMemberDescriptor
      {
        internal PROP_aaac8a445f664020bfb2f5c1cbbab017()
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

      private sealed class PROP_1c4bd6a31c8f454787bee9310eda0c73 : HardwiredMemberDescriptor
      {
        internal PROP_1c4bd6a31c8f454787bee9310eda0c73()
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

      private sealed class PROP_9d685a85c9d7477fb3d90450b16f0084 : HardwiredMemberDescriptor
      {
        internal PROP_9d685a85c9d7477fb3d90450b16f0084()
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

      private sealed class PROP_b24162e4338e40f89d1e0d94729c5d31 : HardwiredMemberDescriptor
      {
        internal PROP_b24162e4338e40f89d1e0d94729c5d31()
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

      private sealed class PROP_b11ebf5e6ac9425aae59ef16716b6899 : HardwiredMemberDescriptor
      {
        internal PROP_b11ebf5e6ac9425aae59ef16716b6899()
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

      private sealed class PROP_1c0e12192e684de29f16d733db38dcdd : HardwiredMemberDescriptor
      {
        internal PROP_1c0e12192e684de29f16d733db38dcdd()
          : base(typeof (bool), "waiting", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).waiting;
        }
      }

      private sealed class PROP_c0f33a8b6d3143e392782f424907d709 : HardwiredMemberDescriptor
      {
        internal PROP_c0f33a8b6d3143e392782f424907d709()
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

      private sealed class PROP_6beda7b14826482c9b39288520516a70 : HardwiredMemberDescriptor
      {
        internal PROP_6beda7b14826482c9b39288520516a70()
          : base(typeof (bool), "busy", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).busy;
        }
      }

      private sealed class PROP_259ffffd85974a96897323571e92a1e9 : HardwiredMemberDescriptor
      {
        internal PROP_259ffffd85974a96897323571e92a1e9()
          : base(typeof (bool), "ongoing", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).ongoing;
        }
      }

      private sealed class PROP_891b6eb337c44063ad95e82e6410f37f : HardwiredMemberDescriptor
      {
        internal PROP_891b6eb337c44063ad95e82e6410f37f()
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

      private sealed class PROP_c9d8c725136a472b8c583a8a3db8a1c4 : HardwiredMemberDescriptor
      {
        internal PROP_c9d8c725136a472b8c583a8a3db8a1c4()
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

      private sealed class PROP_c446f4c7227a4894bed52e080ee6ca20 : HardwiredMemberDescriptor
      {
        internal PROP_c446f4c7227a4894bed52e080ee6ca20()
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

      private sealed class PROP_8ed19bd4655c44cd8a03df84f48ece36 : HardwiredMemberDescriptor
      {
        internal PROP_8ed19bd4655c44cd8a03df84f48ece36()
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

      private sealed class PROP_ac145e4261c742989a45350af30eb954 : HardwiredMemberDescriptor
      {
        internal PROP_ac145e4261c742989a45350af30eb954()
          : base(typeof (int), "width", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).width;
        }
      }

      private sealed class PROP_fdc5c27547d54cadae03c17904c9acf2 : HardwiredMemberDescriptor
      {
        internal PROP_fdc5c27547d54cadae03c17904c9acf2()
          : base(typeof (int), "height", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).height;
        }
      }

      private sealed class PROP_cf3b6fbd73b44744ae97be13c6e3b563 : HardwiredMemberDescriptor
      {
        internal PROP_cf3b6fbd73b44744ae97be13c6e3b563()
          : base(typeof (Educative.Point), "mousePosition", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mousePosition;
        }
      }

      private sealed class PROP_eddb9afff5924a73b1456d8c640eab2c : HardwiredMemberDescriptor
      {
        internal PROP_eddb9afff5924a73b1456d8c640eab2c()
          : base(typeof (bool), "mouseOverUI", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).mouseOverUI;
        }
      }

      private sealed class PROP_0e9541b581404b958784530ddb780af6 : HardwiredMemberDescriptor
      {
        internal PROP_0e9541b581404b958784530ddb780af6()
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

      private sealed class PROP_79f584c2f4ad406abf2bd38b9a66bdc2 : HardwiredMemberDescriptor
      {
        internal PROP_79f584c2f4ad406abf2bd38b9a66bdc2()
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

      private sealed class PROP_72d23af6da2049f5a9a9886b3746391f : HardwiredMemberDescriptor
      {
        internal PROP_72d23af6da2049f5a9a9886b3746391f()
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

      private sealed class PROP_9f10b0ab8729415898f5068b5422552f : HardwiredMemberDescriptor
      {
        internal PROP_9f10b0ab8729415898f5068b5422552f()
          : base(typeof (bool), "isUsingTouchControls", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).isUsingTouchControls;
        }
      }

      private sealed class PROP_80d85afe78454b4f999a7839366edfd4 : HardwiredMemberDescriptor
      {
        internal PROP_80d85afe78454b4f999a7839366edfd4()
          : base(typeof (double), "screenWidth", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenWidth;
        }
      }

      private sealed class PROP_6bc55183221d432cad4e06f84c0955f3 : HardwiredMemberDescriptor
      {
        internal PROP_6bc55183221d432cad4e06f84c0955f3()
          : base(typeof (double), "screenHeight", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerGame) obj).screenHeight;
        }
      }
    }

    private sealed class TYPE_48019385a7e545d99071733c043c80c3 : HardwiredUserDataDescriptor
    {
      internal TYPE_48019385a7e545d99071733c043c80c3()
        : base(typeof (ContainerPlayer))
      {
        this.AddMember("get_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_48019385a7e545d99071733c043c80c3.MTHD_4c31bd6ae6c74f7fbd97515f9afba1de()
        }));
        this.AddMember("set_localTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_localTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_48019385a7e545d99071733c043c80c3.MTHD_198ce0ad26a440a3b20c60a695ab3662()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_48019385a7e545d99071733c043c80c3.MTHD_e28bde300e8c47689d5cf012f4637c6a()
        }));
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_48019385a7e545d99071733c043c80c3.MTHD_01003bd77c4147e7ac01b616182d4ebe()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_48019385a7e545d99071733c043c80c3.MTHD_dc39fc306bd84b00ab09770526b8ae45()
        }));
        this.AddMember("getCreatures", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreatures", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_48019385a7e545d99071733c043c80c3.MTHD_562586d2e3bc4258b801884bf1c096d5()
        }));
        this.AddMember("getCreature", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getCreature", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_48019385a7e545d99071733c043c80c3.MTHD_ccab2c427d574c969825d0bc6e8db795()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_48019385a7e545d99071733c043c80c3.MTHD_0e26a6be8d6a46238c59eff51716a9dc()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_48019385a7e545d99071733c043c80c3.MTHD_e744ec6bd0d441dda6e94caa63bc9749()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_48019385a7e545d99071733c043c80c3.MTHD_2d5a606e0d3b456eb3b8f629774fceb2()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_48019385a7e545d99071733c043c80c3.MTHD_f6d8d7d82a4048aa870f31ba8abfb5c6()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerPlayer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_48019385a7e545d99071733c043c80c3.MTHD_490900ddcd684479a884b7415f1d8fec()
        }));
        this.AddMember("localTurn", (IMemberDescriptor) new Bridge.TYPE_48019385a7e545d99071733c043c80c3.PROP_26e8b927ca3441959f4d58db92b876f3());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_48019385a7e545d99071733c043c80c3.PROP_4f6fcc120bdb431586d3006d42343ace());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_48019385a7e545d99071733c043c80c3.PROP_004ad5caef82403c9d20b16f2ef40b10());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_48019385a7e545d99071733c043c80c3.PROP_54d539a39c8e4c3abf4fab238472683f());
      }

      private sealed class MTHD_4c31bd6ae6c74f7fbd97515f9afba1de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c31bd6ae6c74f7fbd97515f9afba1de()
        {
          this.Initialize("get_localTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).localTurn;
        }
      }

      private sealed class MTHD_198ce0ad26a440a3b20c60a695ab3662 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_198ce0ad26a440a3b20c60a695ab3662()
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

      private sealed class MTHD_e28bde300e8c47689d5cf012f4637c6a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e28bde300e8c47689d5cf012f4637c6a()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class MTHD_01003bd77c4147e7ac01b616182d4ebe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_01003bd77c4147e7ac01b616182d4ebe()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class MTHD_dc39fc306bd84b00ab09770526b8ae45 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc39fc306bd84b00ab09770526b8ae45()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }

      private sealed class MTHD_562586d2e3bc4258b801884bf1c096d5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_562586d2e3bc4258b801884bf1c096d5()
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

      private sealed class MTHD_ccab2c427d574c969825d0bc6e8db795 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ccab2c427d574c969825d0bc6e8db795()
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

      private sealed class MTHD_0e26a6be8d6a46238c59eff51716a9dc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0e26a6be8d6a46238c59eff51716a9dc()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).getMinionCount();
        }
      }

      private sealed class MTHD_e744ec6bd0d441dda6e94caa63bc9749 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e744ec6bd0d441dda6e94caa63bc9749()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerPlayer) obj).GetHashCode();
        }
      }

      private sealed class MTHD_2d5a606e0d3b456eb3b8f629774fceb2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d5a606e0d3b456eb3b8f629774fceb2()
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

      private sealed class MTHD_f6d8d7d82a4048aa870f31ba8abfb5c6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f6d8d7d82a4048aa870f31ba8abfb5c6()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_490900ddcd684479a884b7415f1d8fec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_490900ddcd684479a884b7415f1d8fec()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_26e8b927ca3441959f4d58db92b876f3 : HardwiredMemberDescriptor
      {
        internal PROP_26e8b927ca3441959f4d58db92b876f3()
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

      private sealed class PROP_4f6fcc120bdb431586d3006d42343ace : HardwiredMemberDescriptor
      {
        internal PROP_4f6fcc120bdb431586d3006d42343ace()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).name;
        }
      }

      private sealed class PROP_004ad5caef82403c9d20b16f2ef40b10 : HardwiredMemberDescriptor
      {
        internal PROP_004ad5caef82403c9d20b16f2ef40b10()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).team;
        }
      }

      private sealed class PROP_54d539a39c8e4c3abf4fab238472683f : HardwiredMemberDescriptor
      {
        internal PROP_54d539a39c8e4c3abf4fab238472683f()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerPlayer) obj).yourTurn;
        }
      }
    }

    private sealed class TYPE_f0e953cab8214677b25ce888a8b4b41e : HardwiredUserDataDescriptor
    {
      internal TYPE_f0e953cab8214677b25ce888a8b4b41e()
        : base(typeof (ContainerCreature))
      {
        this.AddMember("get_team", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_team", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_1c6070ca28ec442fbef0b3f78878a768()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_ef5594c54b284f35a5f5507371ce238f()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_41593c507fa0482f93b960a2c0ce22f6()
        }));
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_1a992559a171489db71cf23823e521b0()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_b76ae68479b54937892ff664146d4b47()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_d2bec4a684e641b3a95898a8d20056e7()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_6f0f104ac083493394278fbccdd74bcd()
        }));
        this.AddMember("get_healthAndTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_healthAndTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_4bc3e9961401430a944b73ea654457a5()
        }));
        this.AddMember("get_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_b30124320c5b4c89b87257c93756c933()
        }));
        this.AddMember("set_shield", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_shield", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_c7dd3a43529a46629bb5fbe6fa94287b()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_65aeec31595a4e68aed31a60771aabce()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_2556e0c026cf4128aed69bc1a85450f9()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_4a6894adab2740a79f095f7eb0143a57()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_2a8284ae240942aaa5f3a092e415385f()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_02085698df284d2b8b1df233d482ca56()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_2c582fcd4a774f579f52151e5429854a()
        }));
        this.AddMember("get_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_4a992505d536477d950830f73117cd6d()
        }));
        this.AddMember("set_parent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_parent", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_41d45dab7acf42b5954d5c25f765a548()
        }));
        this.AddMember("get_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_01cd53819dc24edf927e02e9eed23e51()
        }));
        this.AddMember("set_weight", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_weight", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_88fa88af145b4b24932c6b9e6382b082()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_274e16f83a59467cbd1b678e74124872()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_160f92c35dd94e71afd6abc8e7fca941()
        }));
        this.AddMember("get_inTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_d128e078dc0f4a5d90cf1eb99d3e226f()
        }));
        this.AddMember("get_isMoving", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMoving", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_87d83b722f364c92a6cc03f13812a9e3()
        }));
        this.AddMember("get_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_860c21858af14fb0aa3b0f4967aa1f03()
        }));
        this.AddMember("set_stunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_stunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_37eb5c85875f4310bd7958804bea19e7()
        }));
        this.AddMember("get_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_ea8835c2897146aa835e58340b788815()
        }));
        this.AddMember("set_superStunned", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_superStunned", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_1f83cd4bf0dc46269ab4bbb2d1098866()
        }));
        this.AddMember("get_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_87098adb18d540bfb6e0c98f2619227b()
        }));
        this.AddMember("set_waterWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_waterWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_240f67fabb61401baca7ec52fbcf9672()
        }));
        this.AddMember("get_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_05d3cea86bdc423bac61c6bd07d0b018()
        }));
        this.AddMember("set_frostWalking", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_frostWalking", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_38e4a72ee2b74cc8b5889e9ffe7985b3()
        }));
        this.AddMember("get_inWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_inWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_4c1ccc2bba9d4d36baa469c3e0994784()
        }));
        this.AddMember("get_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_60ffeb4c524c4c8cbc67fece75984f59()
        }));
        this.AddMember("set_diesInWater", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_diesInWater", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_bec3d956b6174058b4cb2ba11ebbca0f()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_2f6293996dc549c1b1cec86e7d051b8e()
        }));
        this.AddMember("set_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_type", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_d33fef1870f44b18857bde05b7485e19()
        }));
        this.AddMember("get_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_7a8fcabbf1384a9b8b562eee0b7e8be5()
        }));
        this.AddMember("set_race", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_race", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_a3cdcc14c0354f7097caa8e8ae349565()
        }));
        this.AddMember("get_yourTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_yourTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_e0f40b0140e3461e97cbd44cac17f11d()
        }));
        this.AddMember("get_isRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_945f994f27f94243a1773d47edd2235a()
        }));
        this.AddMember("get_isMounted", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMounted", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_1fd7bed1f4f54d2a96dcf204b16288d7()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_d0348e6c357b4379bf9c1ad4cb17153e()
        }));
        this.AddMember("get_isPawn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPawn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_13bfafb92a4c44eeaf9d9607b91247cf()
        }));
        this.AddMember("get_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_5a0c7a1a75e944ce8974d0f59e6cb3d1()
        }));
        this.AddMember("set_isFlying", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isFlying", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_5d6b7f6f9552400ba01e297917670c1f()
        }));
        this.AddMember("get_isMountable", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isMountable", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_9b960b42b47f4dc79ac6dc77abb48800()
        }));
        this.AddMember("get_canMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_canMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_38f60fe0940d465d81b173ca1a8a0cb8()
        }));
        this.AddMember("get_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_ff365a5d643643d49a986671b894ce43()
        }));
        this.AddMember("set_arcaneMonster", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_arcaneMonster", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_1920d122db934f67865dd4d75b30d36a()
        }));
        this.AddMember("get_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_60f152c9af5a4dc09baf178e579f49d2()
        }));
        this.AddMember("set_takeDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_takeDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_cdc5910e89d34e98a32e9bf6e0a11f49()
        }));
        this.AddMember("getRider", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getRider", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_ded0937bd3d44b7681148d55b83d27ee()
        }));
        this.AddMember("getMount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_20090fac2306459c8224fdcfb8e348d8()
        }));
        this.AddMember("getTower", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getTower", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_5ed38fa88acc4b06aed8d0a16d5d42ec()
        }));
        this.AddMember("LongJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("LongJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_19735a04a66e4b0b868c7f670a03d303()
        }));
        this.AddMember("HighJump", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("HighJump", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_3d0e5c68f42140b6baeedbd501692265()
        }));
        this.AddMember("Walk", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Walk", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_447f9ee677a64edaa9e6543ad9064784()
        }));
        this.AddMember("setDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_179b3585160040b6a6b7529f3c429501()
        }));
        this.AddMember("getDirection", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getDirection", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_d8b718aa3a1e422bb5fe54d2faa3a787()
        }));
        this.AddMember("getFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_25a98100202042089bde78ff98b71d8a()
        }));
        this.AddMember("getActivateableFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_b7a71d81fa704dceab347599ecac4b02()
        }));
        this.AddMember("getActivateableFamiliarBookID", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getActivateableFamiliarBookID", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_241ead31dee14c0e87fea3e3909334f6()
        }));
        this.AddMember("increaseFamiliarLevel", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("increaseFamiliarLevel", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_a65b0b5f2b3a4bf59a8f89d92ae58835()
        }));
        this.AddMember("inside", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("inside", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_9aad2d485c5d4096b8c81c757ec8b872(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_ce153682c77e4a31b97ac90a0111c8cc()
        }));
        this.AddMember("overlap", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("overlap", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_a114672594b9462e8a86056756889951(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_9401573d27384a45a01d86fc15908a91()
        }));
        this.AddMember("die", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("die", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_dfeeb58a0fbf4b5ea8108c0ae04c1507()
        }));
        this.AddMember("addSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_a1d40b472f5044fe938352fb9fb8337d()
        }));
        this.AddMember("removeSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("removeSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_15f8d6c730eb42f98fbc855a44ea2b74(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_f1c63470d65644c8bac4b55fb25a9c16()
        }));
        this.AddMember("getSpells", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpells", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_0397b0b0840145ce97c09f3fb784e608()
        }));
        this.AddMember("getSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_1c9dc9c4aee8435488c41afe075c3275()
        }));
        this.AddMember("getSpellCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getSpellCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_b9cd39f55f084b688a29beb63b32d253()
        }));
        this.AddMember("castedCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_66767f3cdb214efa969a788ad1bbf997()
        }));
        this.AddMember("castedCountThisTurn", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedCountThisTurn", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_31d59955bc4a4f0a83c6ede75f1e0283()
        }));
        this.AddMember("castedDamage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castedDamage", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_c12cab2ca5cf4b469904906dba370195()
        }));
        this.AddMember("getMinionCount", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getMinionCount", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_473cc3e2ee0742fdb97d63b007febe1c()
        }));
        this.AddMember("castSpell", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("castSpell", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_4ed01eddc001430997a6b4c20eecb0e8()
        }));
        this.AddMember("angleToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("angleToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_6c9ad50670d447b99a0f50f6404ccceb()
        }));
        this.AddMember("powerToFire", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("powerToFire", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_534c7d85adec43aa90917ee6315fd512()
        }));
        this.AddMember("fireAt", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fireAt", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_190ca1f3d73d463095e1e71ddafe7e6a(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_f0407f5fb8864051a341967567686197()
        }));
        this.AddMember("getEffectors", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getEffectors", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_e9a1cbdd20834cf1b6d03a7cad458290(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_dd94f1b93f7240a6a7b1a41eb13a9283()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_6cc72a5fc32f458ab362199b36d4162a()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_9903cf63776142c0bf6cc5ebf96778e8()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_d82f7e6c7bfb45679bb807a1eca548df()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_b9f306359b7d427c9ff9e9f42d93c4a8()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_cde954fd11d74dee81db537585dc546a()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerCreature), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.MTHD_0ebabf5fc27f43c49690cb43b678235f()
        }));
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_60fd57cbdd4245baaf1f8ff2224aee14());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_318683fa67124401bebf2675a50cccc6());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_dcd278edcbc444fbbb7e10ce53cacbb8());
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_8a4dfa80268540c9a58c24ac22e0cdfa());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_ce57ef89c94f4c7585ec545b1e41da2f());
        this.AddMember("healthAndTower", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_4836d231e2c346a4b5ccafca4c99e585());
        this.AddMember("shield", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_9bfa61aa4b3a423d9d2e1c791d5d2276());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_f247ec4fabe946218f9639f0280dd43b());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_2f849e3ab7f94b02aaf52da58dc11c5e());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_de07af68b0fb42ec9683f5f0f523c3e5());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_4511ff1402c34fc18498ea7190bdf418());
        this.AddMember("weight", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_7987348f48274250b5aac24c4722a46c());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_80901c4362bc498ebd0ded9b06a6ab68());
        this.AddMember("inTower", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_1b72d3547a8e4add899afc643fa664ed());
        this.AddMember("isMoving", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_1d6eb347e84d47a8b2aadac982c50a1f());
        this.AddMember("stunned", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_64a32caffad941079f3a36b8ce3943b4());
        this.AddMember("superStunned", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_c9ea70558fb248649a4bed6313fbd056());
        this.AddMember("waterWalking", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_af97d31569b84a6885eac7e443e9bc7f());
        this.AddMember("frostWalking", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_43115b234ce742cebfd85e926783a28a());
        this.AddMember("inWater", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_869fb993376643cca004826621cd065d());
        this.AddMember("diesInWater", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_e3a6e76571264df8b601f72a74efafb6());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_5c6500d1884e4c2f86030492187230ba());
        this.AddMember("race", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_3f9cf275462b493b839f64b8762e8e84());
        this.AddMember("yourTurn", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_4049c2ce2cc641d594650ec2f655d903());
        this.AddMember("isRider", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_1a38cbc3d19249beb7c10793c38531e5());
        this.AddMember("isMounted", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_93d453a483544b448e32b369b7c84b32());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_b64372ff6bf84112a3dde9400f697fb5());
        this.AddMember("isPawn", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_816d4ef959664e73b0086db6464cb3be());
        this.AddMember("isFlying", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_7a54dc3260c44fec9c0110f917a6009e());
        this.AddMember("isMountable", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_a1d10ecd0ef64f9897340059a8ff0616());
        this.AddMember("canMount", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_4d8025cfe1c748f0bcd569f64d35b4c5());
        this.AddMember("arcaneMonster", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_1a0e742672594b22b680decd8cbb9173());
        this.AddMember("takeDamage", (IMemberDescriptor) new Bridge.TYPE_f0e953cab8214677b25ce888a8b4b41e.PROP_74f6813c4df64c6a873fb5ebbdafcc2f());
      }

      private sealed class MTHD_1c6070ca28ec442fbef0b3f78878a768 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c6070ca28ec442fbef0b3f78878a768()
        {
          this.Initialize("get_team", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class MTHD_ef5594c54b284f35a5f5507371ce238f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef5594c54b284f35a5f5507371ce238f()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class MTHD_41593c507fa0482f93b960a2c0ce22f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41593c507fa0482f93b960a2c0ce22f6()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class MTHD_1a992559a171489db71cf23823e521b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1a992559a171489db71cf23823e521b0()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).health;
        }
      }

      private sealed class MTHD_b76ae68479b54937892ff664146d4b47 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b76ae68479b54937892ff664146d4b47()
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

      private sealed class MTHD_d2bec4a684e641b3a95898a8d20056e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d2bec4a684e641b3a95898a8d20056e7()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).maxHealth;
        }
      }

      private sealed class MTHD_6f0f104ac083493394278fbccdd74bcd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6f0f104ac083493394278fbccdd74bcd()
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

      private sealed class MTHD_4bc3e9961401430a944b73ea654457a5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4bc3e9961401430a944b73ea654457a5()
        {
          this.Initialize("get_healthAndTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class MTHD_b30124320c5b4c89b87257c93756c933 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b30124320c5b4c89b87257c93756c933()
        {
          this.Initialize("get_shield", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).shield;
        }
      }

      private sealed class MTHD_c7dd3a43529a46629bb5fbe6fa94287b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c7dd3a43529a46629bb5fbe6fa94287b()
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

      private sealed class MTHD_65aeec31595a4e68aed31a60771aabce : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65aeec31595a4e68aed31a60771aabce()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).x;
        }
      }

      private sealed class MTHD_2556e0c026cf4128aed69bc1a85450f9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2556e0c026cf4128aed69bc1a85450f9()
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

      private sealed class MTHD_4a6894adab2740a79f095f7eb0143a57 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a6894adab2740a79f095f7eb0143a57()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).y;
        }
      }

      private sealed class MTHD_2a8284ae240942aaa5f3a092e415385f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a8284ae240942aaa5f3a092e415385f()
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

      private sealed class MTHD_02085698df284d2b8b1df233d482ca56 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_02085698df284d2b8b1df233d482ca56()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).position;
        }
      }

      private sealed class MTHD_2c582fcd4a774f579f52151e5429854a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c582fcd4a774f579f52151e5429854a()
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

      private sealed class MTHD_4a992505d536477d950830f73117cd6d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4a992505d536477d950830f73117cd6d()
        {
          this.Initialize("get_parent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).parent;
        }
      }

      private sealed class MTHD_41d45dab7acf42b5954d5c25f765a548 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_41d45dab7acf42b5954d5c25f765a548()
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

      private sealed class MTHD_01cd53819dc24edf927e02e9eed23e51 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_01cd53819dc24edf927e02e9eed23e51()
        {
          this.Initialize("get_weight", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).weight;
        }
      }

      private sealed class MTHD_88fa88af145b4b24932c6b9e6382b082 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_88fa88af145b4b24932c6b9e6382b082()
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

      private sealed class MTHD_274e16f83a59467cbd1b678e74124872 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_274e16f83a59467cbd1b678e74124872()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).radius;
        }
      }

      private sealed class MTHD_160f92c35dd94e71afd6abc8e7fca941 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_160f92c35dd94e71afd6abc8e7fca941()
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

      private sealed class MTHD_d128e078dc0f4a5d90cf1eb99d3e226f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d128e078dc0f4a5d90cf1eb99d3e226f()
        {
          this.Initialize("get_inTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class MTHD_87d83b722f364c92a6cc03f13812a9e3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_87d83b722f364c92a6cc03f13812a9e3()
        {
          this.Initialize("get_isMoving", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class MTHD_860c21858af14fb0aa3b0f4967aa1f03 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_860c21858af14fb0aa3b0f4967aa1f03()
        {
          this.Initialize("get_stunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).stunned;
        }
      }

      private sealed class MTHD_37eb5c85875f4310bd7958804bea19e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_37eb5c85875f4310bd7958804bea19e7()
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

      private sealed class MTHD_ea8835c2897146aa835e58340b788815 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea8835c2897146aa835e58340b788815()
        {
          this.Initialize("get_superStunned", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).superStunned;
        }
      }

      private sealed class MTHD_1f83cd4bf0dc46269ab4bbb2d1098866 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f83cd4bf0dc46269ab4bbb2d1098866()
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

      private sealed class MTHD_87098adb18d540bfb6e0c98f2619227b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_87098adb18d540bfb6e0c98f2619227b()
        {
          this.Initialize("get_waterWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).waterWalking;
        }
      }

      private sealed class MTHD_240f67fabb61401baca7ec52fbcf9672 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_240f67fabb61401baca7ec52fbcf9672()
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

      private sealed class MTHD_05d3cea86bdc423bac61c6bd07d0b018 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_05d3cea86bdc423bac61c6bd07d0b018()
        {
          this.Initialize("get_frostWalking", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).frostWalking;
        }
      }

      private sealed class MTHD_38e4a72ee2b74cc8b5889e9ffe7985b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_38e4a72ee2b74cc8b5889e9ffe7985b3()
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

      private sealed class MTHD_4c1ccc2bba9d4d36baa469c3e0994784 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4c1ccc2bba9d4d36baa469c3e0994784()
        {
          this.Initialize("get_inWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class MTHD_60ffeb4c524c4c8cbc67fece75984f59 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60ffeb4c524c4c8cbc67fece75984f59()
        {
          this.Initialize("get_diesInWater", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).diesInWater;
        }
      }

      private sealed class MTHD_bec3d956b6174058b4cb2ba11ebbca0f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bec3d956b6174058b4cb2ba11ebbca0f()
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

      private sealed class MTHD_2f6293996dc549c1b1cec86e7d051b8e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2f6293996dc549c1b1cec86e7d051b8e()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).type;
        }
      }

      private sealed class MTHD_d33fef1870f44b18857bde05b7485e19 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d33fef1870f44b18857bde05b7485e19()
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

      private sealed class MTHD_7a8fcabbf1384a9b8b562eee0b7e8be5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a8fcabbf1384a9b8b562eee0b7e8be5()
        {
          this.Initialize("get_race", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).race;
        }
      }

      private sealed class MTHD_a3cdcc14c0354f7097caa8e8ae349565 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a3cdcc14c0354f7097caa8e8ae349565()
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

      private sealed class MTHD_e0f40b0140e3461e97cbd44cac17f11d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e0f40b0140e3461e97cbd44cac17f11d()
        {
          this.Initialize("get_yourTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class MTHD_945f994f27f94243a1773d47edd2235a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_945f994f27f94243a1773d47edd2235a()
        {
          this.Initialize("get_isRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class MTHD_1fd7bed1f4f54d2a96dcf204b16288d7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1fd7bed1f4f54d2a96dcf204b16288d7()
        {
          this.Initialize("get_isMounted", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class MTHD_d0348e6c357b4379bf9c1ad4cb17153e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d0348e6c357b4379bf9c1ad4cb17153e()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class MTHD_13bfafb92a4c44eeaf9d9607b91247cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_13bfafb92a4c44eeaf9d9607b91247cf()
        {
          this.Initialize("get_isPawn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class MTHD_5a0c7a1a75e944ce8974d0f59e6cb3d1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5a0c7a1a75e944ce8974d0f59e6cb3d1()
        {
          this.Initialize("get_isFlying", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isFlying;
        }
      }

      private sealed class MTHD_5d6b7f6f9552400ba01e297917670c1f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d6b7f6f9552400ba01e297917670c1f()
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

      private sealed class MTHD_9b960b42b47f4dc79ac6dc77abb48800 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b960b42b47f4dc79ac6dc77abb48800()
        {
          this.Initialize("get_isMountable", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class MTHD_38f60fe0940d465d81b173ca1a8a0cb8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_38f60fe0940d465d81b173ca1a8a0cb8()
        {
          this.Initialize("get_canMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class MTHD_ff365a5d643643d49a986671b894ce43 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ff365a5d643643d49a986671b894ce43()
        {
          this.Initialize("get_arcaneMonster", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).arcaneMonster;
        }
      }

      private sealed class MTHD_1920d122db934f67865dd4d75b30d36a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1920d122db934f67865dd4d75b30d36a()
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

      private sealed class MTHD_60f152c9af5a4dc09baf178e579f49d2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60f152c9af5a4dc09baf178e579f49d2()
        {
          this.Initialize("get_takeDamage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).takeDamage;
        }
      }

      private sealed class MTHD_cdc5910e89d34e98a32e9bf6e0a11f49 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cdc5910e89d34e98a32e9bf6e0a11f49()
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

      private sealed class MTHD_ded0937bd3d44b7681148d55b83d27ee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ded0937bd3d44b7681148d55b83d27ee()
        {
          this.Initialize("getRider", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getRider();
        }
      }

      private sealed class MTHD_20090fac2306459c8224fdcfb8e348d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_20090fac2306459c8224fdcfb8e348d8()
        {
          this.Initialize("getMount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMount();
        }
      }

      private sealed class MTHD_5ed38fa88acc4b06aed8d0a16d5d42ec : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ed38fa88acc4b06aed8d0a16d5d42ec()
        {
          this.Initialize("getTower", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getTower();
        }
      }

      private sealed class MTHD_19735a04a66e4b0b868c7f670a03d303 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_19735a04a66e4b0b868c7f670a03d303()
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

      private sealed class MTHD_3d0e5c68f42140b6baeedbd501692265 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3d0e5c68f42140b6baeedbd501692265()
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

      private sealed class MTHD_447f9ee677a64edaa9e6543ad9064784 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_447f9ee677a64edaa9e6543ad9064784()
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

      private sealed class MTHD_179b3585160040b6a6b7529f3c429501 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_179b3585160040b6a6b7529f3c429501()
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

      private sealed class MTHD_d8b718aa3a1e422bb5fe54d2faa3a787 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8b718aa3a1e422bb5fe54d2faa3a787()
        {
          this.Initialize("getDirection", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getDirection();
        }
      }

      private sealed class MTHD_25a98100202042089bde78ff98b71d8a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_25a98100202042089bde78ff98b71d8a()
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

      private sealed class MTHD_b7a71d81fa704dceab347599ecac4b02 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b7a71d81fa704dceab347599ecac4b02()
        {
          this.Initialize("getActivateableFamiliarLevel", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarLevel();
        }
      }

      private sealed class MTHD_241ead31dee14c0e87fea3e3909334f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_241ead31dee14c0e87fea3e3909334f6()
        {
          this.Initialize("getActivateableFamiliarBookID", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getActivateableFamiliarBookID();
        }
      }

      private sealed class MTHD_a65b0b5f2b3a4bf59a8f89d92ae58835 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a65b0b5f2b3a4bf59a8f89d92ae58835()
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

      private sealed class MTHD_9aad2d485c5d4096b8c81c757ec8b872 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9aad2d485c5d4096b8c81c757ec8b872()
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

      private sealed class MTHD_ce153682c77e4a31b97ac90a0111c8cc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ce153682c77e4a31b97ac90a0111c8cc()
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

      private sealed class MTHD_a114672594b9462e8a86056756889951 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a114672594b9462e8a86056756889951()
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

      private sealed class MTHD_9401573d27384a45a01d86fc15908a91 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9401573d27384a45a01d86fc15908a91()
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

      private sealed class MTHD_dfeeb58a0fbf4b5ea8108c0ae04c1507 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dfeeb58a0fbf4b5ea8108c0ae04c1507()
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

      private sealed class MTHD_a1d40b472f5044fe938352fb9fb8337d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1d40b472f5044fe938352fb9fb8337d()
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

      private sealed class MTHD_15f8d6c730eb42f98fbc855a44ea2b74 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_15f8d6c730eb42f98fbc855a44ea2b74()
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

      private sealed class MTHD_f1c63470d65644c8bac4b55fb25a9c16 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f1c63470d65644c8bac4b55fb25a9c16()
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

      private sealed class MTHD_0397b0b0840145ce97c09f3fb784e608 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0397b0b0840145ce97c09f3fb784e608()
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

      private sealed class MTHD_1c9dc9c4aee8435488c41afe075c3275 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1c9dc9c4aee8435488c41afe075c3275()
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

      private sealed class MTHD_b9cd39f55f084b688a29beb63b32d253 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b9cd39f55f084b688a29beb63b32d253()
        {
          this.Initialize("getSpellCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getSpellCount();
        }
      }

      private sealed class MTHD_66767f3cdb214efa969a788ad1bbf997 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_66767f3cdb214efa969a788ad1bbf997()
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

      private sealed class MTHD_31d59955bc4a4f0a83c6ede75f1e0283 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_31d59955bc4a4f0a83c6ede75f1e0283()
        {
          this.Initialize("castedCountThisTurn", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).castedCountThisTurn();
        }
      }

      private sealed class MTHD_c12cab2ca5cf4b469904906dba370195 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c12cab2ca5cf4b469904906dba370195()
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

      private sealed class MTHD_473cc3e2ee0742fdb97d63b007febe1c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_473cc3e2ee0742fdb97d63b007febe1c()
        {
          this.Initialize("getMinionCount", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).getMinionCount();
        }
      }

      private sealed class MTHD_4ed01eddc001430997a6b4c20eecb0e8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4ed01eddc001430997a6b4c20eecb0e8()
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

      private sealed class MTHD_6c9ad50670d447b99a0f50f6404ccceb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6c9ad50670d447b99a0f50f6404ccceb()
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

      private sealed class MTHD_534c7d85adec43aa90917ee6315fd512 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_534c7d85adec43aa90917ee6315fd512()
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

      private sealed class MTHD_190ca1f3d73d463095e1e71ddafe7e6a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_190ca1f3d73d463095e1e71ddafe7e6a()
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

      private sealed class MTHD_f0407f5fb8864051a341967567686197 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f0407f5fb8864051a341967567686197()
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

      private sealed class MTHD_e9a1cbdd20834cf1b6d03a7cad458290 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e9a1cbdd20834cf1b6d03a7cad458290()
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

      private sealed class MTHD_dd94f1b93f7240a6a7b1a41eb13a9283 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dd94f1b93f7240a6a7b1a41eb13a9283()
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

      private sealed class MTHD_6cc72a5fc32f458ab362199b36d4162a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6cc72a5fc32f458ab362199b36d4162a()
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

      private sealed class MTHD_9903cf63776142c0bf6cc5ebf96778e8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9903cf63776142c0bf6cc5ebf96778e8()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerCreature) obj).GetHashCode();
        }
      }

      private sealed class MTHD_d82f7e6c7bfb45679bb807a1eca548df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d82f7e6c7bfb45679bb807a1eca548df()
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

      private sealed class MTHD_b9f306359b7d427c9ff9e9f42d93c4a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b9f306359b7d427c9ff9e9f42d93c4a8()
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

      private sealed class MTHD_cde954fd11d74dee81db537585dc546a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_cde954fd11d74dee81db537585dc546a()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_0ebabf5fc27f43c49690cb43b678235f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ebabf5fc27f43c49690cb43b678235f()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_60fd57cbdd4245baaf1f8ff2224aee14 : HardwiredMemberDescriptor
      {
        internal PROP_60fd57cbdd4245baaf1f8ff2224aee14()
          : base(typeof (int), "team", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).team;
        }
      }

      private sealed class PROP_318683fa67124401bebf2675a50cccc6 : HardwiredMemberDescriptor
      {
        internal PROP_318683fa67124401bebf2675a50cccc6()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).name;
        }
      }

      private sealed class PROP_dcd278edcbc444fbbb7e10ce53cacbb8 : HardwiredMemberDescriptor
      {
        internal PROP_dcd278edcbc444fbbb7e10ce53cacbb8()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).spellEnum;
        }
      }

      private sealed class PROP_8a4dfa80268540c9a58c24ac22e0cdfa : HardwiredMemberDescriptor
      {
        internal PROP_8a4dfa80268540c9a58c24ac22e0cdfa()
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

      private sealed class PROP_ce57ef89c94f4c7585ec545b1e41da2f : HardwiredMemberDescriptor
      {
        internal PROP_ce57ef89c94f4c7585ec545b1e41da2f()
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

      private sealed class PROP_4836d231e2c346a4b5ccafca4c99e585 : HardwiredMemberDescriptor
      {
        internal PROP_4836d231e2c346a4b5ccafca4c99e585()
          : base(typeof (int), "healthAndTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).healthAndTower;
        }
      }

      private sealed class PROP_9bfa61aa4b3a423d9d2e1c791d5d2276 : HardwiredMemberDescriptor
      {
        internal PROP_9bfa61aa4b3a423d9d2e1c791d5d2276()
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

      private sealed class PROP_f247ec4fabe946218f9639f0280dd43b : HardwiredMemberDescriptor
      {
        internal PROP_f247ec4fabe946218f9639f0280dd43b()
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

      private sealed class PROP_2f849e3ab7f94b02aaf52da58dc11c5e : HardwiredMemberDescriptor
      {
        internal PROP_2f849e3ab7f94b02aaf52da58dc11c5e()
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

      private sealed class PROP_de07af68b0fb42ec9683f5f0f523c3e5 : HardwiredMemberDescriptor
      {
        internal PROP_de07af68b0fb42ec9683f5f0f523c3e5()
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

      private sealed class PROP_4511ff1402c34fc18498ea7190bdf418 : HardwiredMemberDescriptor
      {
        internal PROP_4511ff1402c34fc18498ea7190bdf418()
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

      private sealed class PROP_7987348f48274250b5aac24c4722a46c : HardwiredMemberDescriptor
      {
        internal PROP_7987348f48274250b5aac24c4722a46c()
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

      private sealed class PROP_80901c4362bc498ebd0ded9b06a6ab68 : HardwiredMemberDescriptor
      {
        internal PROP_80901c4362bc498ebd0ded9b06a6ab68()
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

      private sealed class PROP_1b72d3547a8e4add899afc643fa664ed : HardwiredMemberDescriptor
      {
        internal PROP_1b72d3547a8e4add899afc643fa664ed()
          : base(typeof (bool), "inTower", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inTower;
        }
      }

      private sealed class PROP_1d6eb347e84d47a8b2aadac982c50a1f : HardwiredMemberDescriptor
      {
        internal PROP_1d6eb347e84d47a8b2aadac982c50a1f()
          : base(typeof (bool), "isMoving", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMoving;
        }
      }

      private sealed class PROP_64a32caffad941079f3a36b8ce3943b4 : HardwiredMemberDescriptor
      {
        internal PROP_64a32caffad941079f3a36b8ce3943b4()
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

      private sealed class PROP_c9ea70558fb248649a4bed6313fbd056 : HardwiredMemberDescriptor
      {
        internal PROP_c9ea70558fb248649a4bed6313fbd056()
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

      private sealed class PROP_af97d31569b84a6885eac7e443e9bc7f : HardwiredMemberDescriptor
      {
        internal PROP_af97d31569b84a6885eac7e443e9bc7f()
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

      private sealed class PROP_43115b234ce742cebfd85e926783a28a : HardwiredMemberDescriptor
      {
        internal PROP_43115b234ce742cebfd85e926783a28a()
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

      private sealed class PROP_869fb993376643cca004826621cd065d : HardwiredMemberDescriptor
      {
        internal PROP_869fb993376643cca004826621cd065d()
          : base(typeof (bool), "inWater", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).inWater;
        }
      }

      private sealed class PROP_e3a6e76571264df8b601f72a74efafb6 : HardwiredMemberDescriptor
      {
        internal PROP_e3a6e76571264df8b601f72a74efafb6()
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

      private sealed class PROP_5c6500d1884e4c2f86030492187230ba : HardwiredMemberDescriptor
      {
        internal PROP_5c6500d1884e4c2f86030492187230ba()
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

      private sealed class PROP_3f9cf275462b493b839f64b8762e8e84 : HardwiredMemberDescriptor
      {
        internal PROP_3f9cf275462b493b839f64b8762e8e84()
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

      private sealed class PROP_4049c2ce2cc641d594650ec2f655d903 : HardwiredMemberDescriptor
      {
        internal PROP_4049c2ce2cc641d594650ec2f655d903()
          : base(typeof (bool), "yourTurn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).yourTurn;
        }
      }

      private sealed class PROP_1a38cbc3d19249beb7c10793c38531e5 : HardwiredMemberDescriptor
      {
        internal PROP_1a38cbc3d19249beb7c10793c38531e5()
          : base(typeof (bool), "isRider", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isRider;
        }
      }

      private sealed class PROP_93d453a483544b448e32b369b7c84b32 : HardwiredMemberDescriptor
      {
        internal PROP_93d453a483544b448e32b369b7c84b32()
          : base(typeof (bool), "isMounted", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMounted;
        }
      }

      private sealed class PROP_b64372ff6bf84112a3dde9400f697fb5 : HardwiredMemberDescriptor
      {
        internal PROP_b64372ff6bf84112a3dde9400f697fb5()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isDead;
        }
      }

      private sealed class PROP_816d4ef959664e73b0086db6464cb3be : HardwiredMemberDescriptor
      {
        internal PROP_816d4ef959664e73b0086db6464cb3be()
          : base(typeof (bool), "isPawn", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isPawn;
        }
      }

      private sealed class PROP_7a54dc3260c44fec9c0110f917a6009e : HardwiredMemberDescriptor
      {
        internal PROP_7a54dc3260c44fec9c0110f917a6009e()
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

      private sealed class PROP_a1d10ecd0ef64f9897340059a8ff0616 : HardwiredMemberDescriptor
      {
        internal PROP_a1d10ecd0ef64f9897340059a8ff0616()
          : base(typeof (bool), "isMountable", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).isMountable;
        }
      }

      private sealed class PROP_4d8025cfe1c748f0bcd569f64d35b4c5 : HardwiredMemberDescriptor
      {
        internal PROP_4d8025cfe1c748f0bcd569f64d35b4c5()
          : base(typeof (bool), "canMount", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerCreature) obj).canMount;
        }
      }

      private sealed class PROP_1a0e742672594b22b680decd8cbb9173 : HardwiredMemberDescriptor
      {
        internal PROP_1a0e742672594b22b680decd8cbb9173()
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

      private sealed class PROP_74f6813c4df64c6a873fb5ebbdafcc2f : HardwiredMemberDescriptor
      {
        internal PROP_74f6813c4df64c6a873fb5ebbdafcc2f()
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

    private sealed class TYPE_00a4c3e293ff44edad8f7a62daf2cac2 : HardwiredUserDataDescriptor
    {
      internal TYPE_00a4c3e293ff44edad8f7a62daf2cac2()
        : base(typeof (ContainerEffector))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.MTHD_2c637965f0044e4d97b6f762136b263b()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.MTHD_1246a997d96f460280b8b1cdb5fa7d8a()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.MTHD_a3b82497f1f34e0c921d074c4a32f20f()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.MTHD_ce1f120fc2c24ef4b3bb00a1a11342c9()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.MTHD_c029e87b30ca4a4bbce60418b9aad257()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.MTHD_5eefb6c8cce64d38bb974003d79a8bfa()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.MTHD_b68bfca6d1084f60ab72f3a6b835b388()
        }));
        this.AddMember("get_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.MTHD_b3cc14d306f14b0a96a5e78dd2a63555()
        }));
        this.AddMember("set_turnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.MTHD_5d33b192110a49ffaff6fa055345938b()
        }));
        this.AddMember("get_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.MTHD_5fbae8710131452dad0c29b3baff22b7()
        }));
        this.AddMember("set_maxTurnsAlive", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxTurnsAlive", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.MTHD_42743ffe50cb495299e4b68b01f94f8d()
        }));
        this.AddMember("get_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.MTHD_d300b317397746dc94fb926cfe99a9b4()
        }));
        this.AddMember("set_active", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_active", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.MTHD_72b4658218af4219a0ad370e221d2adf()
        }));
        this.AddMember("get_type", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_type", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.MTHD_b10bd40590654531b1a35d99ab076a6d()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.MTHD_7f4654c385e94c088a477adf5e39230e()
        }));
        this.AddMember("turnPassed", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("turnPassed", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.MTHD_d893ce90dbc04a1b817cf985534b46c2()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.MTHD_a298140c78b849e6a105be2d15fadb06()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.MTHD_9e1fb2f40e4c4e148cc528555b1a141f()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.MTHD_5c88e838bae44f2b8eec10abdfdd9576()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerEffector), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.MTHD_f2ff91a9b98d496ba2dd2e37e7f01ab6()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.PROP_6a453511a6294208949df42340283f33());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.PROP_d93c8ef7481549fe8273937297394dde());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.PROP_41272137d19d48638c4d256badb9420a());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.PROP_09fb381faf244cfc99fa96822c3d0754());
        this.AddMember("turnsAlive", (IMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.PROP_9c923f0c3bf844949bfc2b1acdfdc34f());
        this.AddMember("maxTurnsAlive", (IMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.PROP_f165e5a6e13840009138f576ca9b896c());
        this.AddMember("active", (IMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.PROP_b691da9213344f9b8c8f42e8253584da());
        this.AddMember("type", (IMemberDescriptor) new Bridge.TYPE_00a4c3e293ff44edad8f7a62daf2cac2.PROP_cb3d9b2703314cec9039e3390c51d38e());
      }

      private sealed class MTHD_2c637965f0044e4d97b6f762136b263b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c637965f0044e4d97b6f762136b263b()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class MTHD_1246a997d96f460280b8b1cdb5fa7d8a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1246a997d96f460280b8b1cdb5fa7d8a()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).x;
        }
      }

      private sealed class MTHD_a3b82497f1f34e0c921d074c4a32f20f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a3b82497f1f34e0c921d074c4a32f20f()
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

      private sealed class MTHD_ce1f120fc2c24ef4b3bb00a1a11342c9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ce1f120fc2c24ef4b3bb00a1a11342c9()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).y;
        }
      }

      private sealed class MTHD_c029e87b30ca4a4bbce60418b9aad257 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c029e87b30ca4a4bbce60418b9aad257()
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

      private sealed class MTHD_5eefb6c8cce64d38bb974003d79a8bfa : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5eefb6c8cce64d38bb974003d79a8bfa()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).position;
        }
      }

      private sealed class MTHD_b68bfca6d1084f60ab72f3a6b835b388 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b68bfca6d1084f60ab72f3a6b835b388()
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

      private sealed class MTHD_b3cc14d306f14b0a96a5e78dd2a63555 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b3cc14d306f14b0a96a5e78dd2a63555()
        {
          this.Initialize("get_turnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).turnsAlive;
        }
      }

      private sealed class MTHD_5d33b192110a49ffaff6fa055345938b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5d33b192110a49ffaff6fa055345938b()
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

      private sealed class MTHD_5fbae8710131452dad0c29b3baff22b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5fbae8710131452dad0c29b3baff22b7()
        {
          this.Initialize("get_maxTurnsAlive", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).maxTurnsAlive;
        }
      }

      private sealed class MTHD_42743ffe50cb495299e4b68b01f94f8d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42743ffe50cb495299e4b68b01f94f8d()
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

      private sealed class MTHD_d300b317397746dc94fb926cfe99a9b4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d300b317397746dc94fb926cfe99a9b4()
        {
          this.Initialize("get_active", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).active;
        }
      }

      private sealed class MTHD_72b4658218af4219a0ad370e221d2adf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_72b4658218af4219a0ad370e221d2adf()
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

      private sealed class MTHD_b10bd40590654531b1a35d99ab076a6d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b10bd40590654531b1a35d99ab076a6d()
        {
          this.Initialize("get_type", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }

      private sealed class MTHD_7f4654c385e94c088a477adf5e39230e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7f4654c385e94c088a477adf5e39230e()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_d893ce90dbc04a1b817cf985534b46c2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d893ce90dbc04a1b817cf985534b46c2()
        {
          this.Initialize("turnPassed", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerEffector) obj).turnPassed();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_a298140c78b849e6a105be2d15fadb06 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a298140c78b849e6a105be2d15fadb06()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerEffector) obj).GetHashCode();
        }
      }

      private sealed class MTHD_9e1fb2f40e4c4e148cc528555b1a141f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e1fb2f40e4c4e148cc528555b1a141f()
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

      private sealed class MTHD_5c88e838bae44f2b8eec10abdfdd9576 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c88e838bae44f2b8eec10abdfdd9576()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_f2ff91a9b98d496ba2dd2e37e7f01ab6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f2ff91a9b98d496ba2dd2e37e7f01ab6()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_6a453511a6294208949df42340283f33 : HardwiredMemberDescriptor
      {
        internal PROP_6a453511a6294208949df42340283f33()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).isDead;
        }
      }

      private sealed class PROP_d93c8ef7481549fe8273937297394dde : HardwiredMemberDescriptor
      {
        internal PROP_d93c8ef7481549fe8273937297394dde()
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

      private sealed class PROP_41272137d19d48638c4d256badb9420a : HardwiredMemberDescriptor
      {
        internal PROP_41272137d19d48638c4d256badb9420a()
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

      private sealed class PROP_09fb381faf244cfc99fa96822c3d0754 : HardwiredMemberDescriptor
      {
        internal PROP_09fb381faf244cfc99fa96822c3d0754()
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

      private sealed class PROP_9c923f0c3bf844949bfc2b1acdfdc34f : HardwiredMemberDescriptor
      {
        internal PROP_9c923f0c3bf844949bfc2b1acdfdc34f()
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

      private sealed class PROP_f165e5a6e13840009138f576ca9b896c : HardwiredMemberDescriptor
      {
        internal PROP_f165e5a6e13840009138f576ca9b896c()
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

      private sealed class PROP_b691da9213344f9b8c8f42e8253584da : HardwiredMemberDescriptor
      {
        internal PROP_b691da9213344f9b8c8f42e8253584da()
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

      private sealed class PROP_cb3d9b2703314cec9039e3390c51d38e : HardwiredMemberDescriptor
      {
        internal PROP_cb3d9b2703314cec9039e3390c51d38e()
          : base(typeof (EffectorType), "type", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerEffector) obj).type;
        }
      }
    }

    private sealed class TYPE_c61f5bcb75c04be9bec7cf02cf182af2 : HardwiredUserDataDescriptor
    {
      internal TYPE_c61f5bcb75c04be9bec7cf02cf182af2()
        : base(typeof (ContainerIndicator))
      {
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.MTHD_9dcd03f1b23740dd9433a8b3b39db62e()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.MTHD_9299860936b54abe8b95cb1ac45fb3e7()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.MTHD_b2e668ef8f0444ef8080a749892d7b58()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.MTHD_5e5039befcd948b2858ec247279aaa48()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.MTHD_6b5cef20c05a4cd0be5cba5e7751222c()
        }));
        this.AddMember("get_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.MTHD_5ad153f4ba0f438faec66862e93ec2b7()
        }));
        this.AddMember("set_radius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_radius", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.MTHD_789d3ab26ee04afc94d5ddb0b442e143()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.MTHD_0ad199977f72430583df2fd040c207d5()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.MTHD_0026a0fdf9284be9ac4f2f1cf017801e()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.MTHD_7a3aca82448341f9b0209f10a7fce833()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.MTHD_465516a3c9624ffebf054935b3126fe0()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.MTHD_ca50758136f84ead9cb58acfa2f8b6b3()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.MTHD_71dafd13fa7945639b802c9504465b2f()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.MTHD_9b539260100a42f684ce93083ffd0b88()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.MTHD_1819af048d134dc3a27ca9350359a645()
        }));
        this.AddMember("get_kind", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_kind", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.MTHD_de6b50f77ac346df98696a649bca2356()
        }));
        this.AddMember("setIcon", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("setIcon", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.MTHD_d41e8d610014493db0e8e6192fc9d54e()
        }));
        this.AddMember("Destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Destroy", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.MTHD_24dfad8b8abc49cfb258c8c12dbd048c()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.MTHD_8fca774a2a5142c3869ea4a5af8f2885()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.MTHD_29f0c9d8f4324143b238cdf5014df2f2()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.MTHD_c749bdba6a324488b8080d41653eb9f1()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerIndicator), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.MTHD_3f224640f2be4ff1a5b3bea49cdb10e5()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.PROP_34a93d781e994d37b7391b2c73ef6be7());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.PROP_efd633eb27b649199bd3abd309371389());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.PROP_742a5f21594f461b90aed76d5567993a());
        this.AddMember("radius", (IMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.PROP_6277d3aa63834d73b2bb9cf0bba1d617());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.PROP_b5f0fcfcb6904f83976e848ad677092b());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.PROP_0bd0ba50993f4ed195adf4a004d90e8f());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.PROP_4270e867e97c4c35bcbf3a0c0e043438());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.PROP_9d6a1c258c014817b98954490ed1168b());
        this.AddMember("kind", (IMemberDescriptor) new Bridge.TYPE_c61f5bcb75c04be9bec7cf02cf182af2.PROP_0a183daeec4c4b26b8e53eafc8de60c5());
      }

      private sealed class MTHD_9dcd03f1b23740dd9433a8b3b39db62e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9dcd03f1b23740dd9433a8b3b39db62e()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class MTHD_9299860936b54abe8b95cb1ac45fb3e7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9299860936b54abe8b95cb1ac45fb3e7()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).x;
        }
      }

      private sealed class MTHD_b2e668ef8f0444ef8080a749892d7b58 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b2e668ef8f0444ef8080a749892d7b58()
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

      private sealed class MTHD_5e5039befcd948b2858ec247279aaa48 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e5039befcd948b2858ec247279aaa48()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).y;
        }
      }

      private sealed class MTHD_6b5cef20c05a4cd0be5cba5e7751222c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b5cef20c05a4cd0be5cba5e7751222c()
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

      private sealed class MTHD_5ad153f4ba0f438faec66862e93ec2b7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5ad153f4ba0f438faec66862e93ec2b7()
        {
          this.Initialize("get_radius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).radius;
        }
      }

      private sealed class MTHD_789d3ab26ee04afc94d5ddb0b442e143 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_789d3ab26ee04afc94d5ddb0b442e143()
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

      private sealed class MTHD_0ad199977f72430583df2fd040c207d5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0ad199977f72430583df2fd040c207d5()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).position;
        }
      }

      private sealed class MTHD_0026a0fdf9284be9ac4f2f1cf017801e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0026a0fdf9284be9ac4f2f1cf017801e()
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

      private sealed class MTHD_7a3aca82448341f9b0209f10a7fce833 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7a3aca82448341f9b0209f10a7fce833()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).angle;
        }
      }

      private sealed class MTHD_465516a3c9624ffebf054935b3126fe0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_465516a3c9624ffebf054935b3126fe0()
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

      private sealed class MTHD_ca50758136f84ead9cb58acfa2f8b6b3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ca50758136f84ead9cb58acfa2f8b6b3()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color;
        }
      }

      private sealed class MTHD_71dafd13fa7945639b802c9504465b2f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_71dafd13fa7945639b802c9504465b2f()
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

      private sealed class MTHD_9b539260100a42f684ce93083ffd0b88 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b539260100a42f684ce93083ffd0b88()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).color2;
        }
      }

      private sealed class MTHD_1819af048d134dc3a27ca9350359a645 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1819af048d134dc3a27ca9350359a645()
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

      private sealed class MTHD_de6b50f77ac346df98696a649bca2356 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de6b50f77ac346df98696a649bca2356()
        {
          this.Initialize("get_kind", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }

      private sealed class MTHD_d41e8d610014493db0e8e6192fc9d54e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d41e8d610014493db0e8e6192fc9d54e()
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

      private sealed class MTHD_24dfad8b8abc49cfb258c8c12dbd048c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24dfad8b8abc49cfb258c8c12dbd048c()
        {
          this.Initialize("Destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerIndicator) obj).Destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_8fca774a2a5142c3869ea4a5af8f2885 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8fca774a2a5142c3869ea4a5af8f2885()
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

      private sealed class MTHD_29f0c9d8f4324143b238cdf5014df2f2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_29f0c9d8f4324143b238cdf5014df2f2()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_c749bdba6a324488b8080d41653eb9f1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c749bdba6a324488b8080d41653eb9f1()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_3f224640f2be4ff1a5b3bea49cdb10e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3f224640f2be4ff1a5b3bea49cdb10e5()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_34a93d781e994d37b7391b2c73ef6be7 : HardwiredMemberDescriptor
      {
        internal PROP_34a93d781e994d37b7391b2c73ef6be7()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).isDead;
        }
      }

      private sealed class PROP_efd633eb27b649199bd3abd309371389 : HardwiredMemberDescriptor
      {
        internal PROP_efd633eb27b649199bd3abd309371389()
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

      private sealed class PROP_742a5f21594f461b90aed76d5567993a : HardwiredMemberDescriptor
      {
        internal PROP_742a5f21594f461b90aed76d5567993a()
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

      private sealed class PROP_6277d3aa63834d73b2bb9cf0bba1d617 : HardwiredMemberDescriptor
      {
        internal PROP_6277d3aa63834d73b2bb9cf0bba1d617()
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

      private sealed class PROP_b5f0fcfcb6904f83976e848ad677092b : HardwiredMemberDescriptor
      {
        internal PROP_b5f0fcfcb6904f83976e848ad677092b()
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

      private sealed class PROP_0bd0ba50993f4ed195adf4a004d90e8f : HardwiredMemberDescriptor
      {
        internal PROP_0bd0ba50993f4ed195adf4a004d90e8f()
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

      private sealed class PROP_4270e867e97c4c35bcbf3a0c0e043438 : HardwiredMemberDescriptor
      {
        internal PROP_4270e867e97c4c35bcbf3a0c0e043438()
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

      private sealed class PROP_9d6a1c258c014817b98954490ed1168b : HardwiredMemberDescriptor
      {
        internal PROP_9d6a1c258c014817b98954490ed1168b()
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

      private sealed class PROP_0a183daeec4c4b26b8e53eafc8de60c5 : HardwiredMemberDescriptor
      {
        internal PROP_0a183daeec4c4b26b8e53eafc8de60c5()
          : base(typeof (IndicatorKind), "kind", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerIndicator) obj).kind;
        }
      }
    }

    private sealed class TYPE_91dd4fc9060249b8826c501154639282 : HardwiredUserDataDescriptor
    {
      internal TYPE_91dd4fc9060249b8826c501154639282()
        : base(typeof (ContainerSpell))
      {
        this.AddMember("get_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_371c68ddfabb406090bc5fcc60305552()
        }));
        this.AddMember("set_uses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_uses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_03418581188c4cffb4983f1d97bbcab7()
        }));
        this.AddMember("get_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_0f291d535f004e1f93f1bb5cc57341f3()
        }));
        this.AddMember("set_maxUses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxUses", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_6f3093550e5a4755b7dedd0e1bee7f0d()
        }));
        this.AddMember("get_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_1d83b53eb672402aa34c8374ce250987()
        }));
        this.AddMember("set_rechargeTime", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_rechargeTime", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_56074234265040999303dfec80527ebf()
        }));
        this.AddMember("get_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_c80963dcd6564288ad3f4551f0de263a()
        }));
        this.AddMember("set_lastTurnFired", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_lastTurnFired", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_66b22056b98644ca95f295c1237cfa82()
        }));
        this.AddMember("get_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_f2932027b816472b8f21a8ba6bb92546()
        }));
        this.AddMember("set_isPresent", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_isPresent", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_d8ed90fe73644aea97f05e30475f12ca()
        }));
        this.AddMember("get_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_dc3b843228584a558c8078e0c4fa5860()
        }));
        this.AddMember("set_locked", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_locked", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_9c94c84b22984530825f15a921bf4419()
        }));
        this.AddMember("get_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_9eb48ed99b1b42fc959c570f1b05b34f()
        }));
        this.AddMember("set_turnsTillFirstUse", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_turnsTillFirstUse", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_38c1b5d3b6ca40e09123a8f469a8141c()
        }));
        this.AddMember("get_spellEnum", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_spellEnum", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_60d33c2a24a444a58a2f66fb3364eeb8()
        }));
        this.AddMember("get_castType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_castType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_79b5002d568c4249bd03270ac417245c()
        }));
        this.AddMember("get_damageType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damageType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_9339ef158ab344a5b08a53ba61c0fa4a()
        }));
        this.AddMember("get_book", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_book", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_961ced7824f946858850bcef53c9bed7()
        }));
        this.AddMember("get_damage", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_damage", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_0d82cdf31d98423ab583319cdfa49286()
        }));
        this.AddMember("get_explosionRadius", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_explosionRadius", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_d6d7379192d84e1bb8d1e080325b3e9a()
        }));
        this.AddMember("get_description", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_description", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_51751d3e05e1416c9348626d7b5a8fcc()
        }));
        this.AddMember("get_descriptionOnly", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionOnly", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_85d662c19e2d44538b5dac5820be1ee1()
        }));
        this.AddMember("get_descriptionExtra", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_descriptionExtra", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_52b193fcbfc042bc9a18d90e2e18a392()
        }));
        this.AddMember("get_name", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_name", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_f66359024a124d5395e220ff70f24ea8()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_9d00db7056204fdbabff0765e52dd38b()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_9e9ec1b3ec6b4c83851804f3703a6d26()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_617c5c35add642e3beb31890e13916e0()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerSpell), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.MTHD_310e0498a12c4e7f8159c55047316a68()
        }));
        this.AddMember("uses", (IMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.PROP_5dbcf8e6af50448fb0a40a7a8d298bf9());
        this.AddMember("maxUses", (IMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.PROP_0c1560cd61e640109d4571c81b21d7c7());
        this.AddMember("rechargeTime", (IMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.PROP_5209fdca27214b3aa3666fc2b3c85045());
        this.AddMember("lastTurnFired", (IMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.PROP_0380c6ffb1dc410f9a8f5a8d735c0caf());
        this.AddMember("isPresent", (IMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.PROP_e68cf91639a44f47bff386aee68f77cd());
        this.AddMember("locked", (IMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.PROP_1c1ad5fccec84252a38cc92dc048816d());
        this.AddMember("turnsTillFirstUse", (IMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.PROP_ec7b472f91a6417087d05d32ace640a9());
        this.AddMember("spellEnum", (IMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.PROP_8dc4b5fb315040c5911b4f7c3b68c6d1());
        this.AddMember("castType", (IMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.PROP_fb49b88053d64e3080e545d131c7b639());
        this.AddMember("damageType", (IMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.PROP_b8b7bd45f37d49b1b4de99f1362e4877());
        this.AddMember("book", (IMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.PROP_1ad399e1d6e44abbbe0deecb19846407());
        this.AddMember("damage", (IMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.PROP_a097245a3c3447e2921c0f7516ad0566());
        this.AddMember("explosionRadius", (IMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.PROP_bd35c23d742f46568e8c11ea9579dc10());
        this.AddMember("description", (IMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.PROP_b8463fe72da5497db0bdeda2824c6be7());
        this.AddMember("descriptionOnly", (IMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.PROP_6124ce922b1a49788dec11e1cc3b80eb());
        this.AddMember("descriptionExtra", (IMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.PROP_5171fa1fcbd040bf97ff0195fb4bca28());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_91dd4fc9060249b8826c501154639282.PROP_6f4458f1baf341558449ecff99b4d16c());
      }

      private sealed class MTHD_371c68ddfabb406090bc5fcc60305552 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_371c68ddfabb406090bc5fcc60305552()
        {
          this.Initialize("get_uses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).uses;
        }
      }

      private sealed class MTHD_03418581188c4cffb4983f1d97bbcab7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_03418581188c4cffb4983f1d97bbcab7()
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

      private sealed class MTHD_0f291d535f004e1f93f1bb5cc57341f3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0f291d535f004e1f93f1bb5cc57341f3()
        {
          this.Initialize("get_maxUses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).maxUses;
        }
      }

      private sealed class MTHD_6f3093550e5a4755b7dedd0e1bee7f0d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6f3093550e5a4755b7dedd0e1bee7f0d()
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

      private sealed class MTHD_1d83b53eb672402aa34c8374ce250987 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1d83b53eb672402aa34c8374ce250987()
        {
          this.Initialize("get_rechargeTime", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).rechargeTime;
        }
      }

      private sealed class MTHD_56074234265040999303dfec80527ebf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_56074234265040999303dfec80527ebf()
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

      private sealed class MTHD_c80963dcd6564288ad3f4551f0de263a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c80963dcd6564288ad3f4551f0de263a()
        {
          this.Initialize("get_lastTurnFired", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).lastTurnFired;
        }
      }

      private sealed class MTHD_66b22056b98644ca95f295c1237cfa82 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_66b22056b98644ca95f295c1237cfa82()
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

      private sealed class MTHD_f2932027b816472b8f21a8ba6bb92546 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f2932027b816472b8f21a8ba6bb92546()
        {
          this.Initialize("get_isPresent", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).isPresent;
        }
      }

      private sealed class MTHD_d8ed90fe73644aea97f05e30475f12ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d8ed90fe73644aea97f05e30475f12ca()
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

      private sealed class MTHD_dc3b843228584a558c8078e0c4fa5860 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dc3b843228584a558c8078e0c4fa5860()
        {
          this.Initialize("get_locked", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).locked;
        }
      }

      private sealed class MTHD_9c94c84b22984530825f15a921bf4419 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9c94c84b22984530825f15a921bf4419()
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

      private sealed class MTHD_9eb48ed99b1b42fc959c570f1b05b34f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9eb48ed99b1b42fc959c570f1b05b34f()
        {
          this.Initialize("get_turnsTillFirstUse", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).turnsTillFirstUse;
        }
      }

      private sealed class MTHD_38c1b5d3b6ca40e09123a8f469a8141c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_38c1b5d3b6ca40e09123a8f469a8141c()
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

      private sealed class MTHD_60d33c2a24a444a58a2f66fb3364eeb8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_60d33c2a24a444a58a2f66fb3364eeb8()
        {
          this.Initialize("get_spellEnum", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class MTHD_79b5002d568c4249bd03270ac417245c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_79b5002d568c4249bd03270ac417245c()
        {
          this.Initialize("get_castType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class MTHD_9339ef158ab344a5b08a53ba61c0fa4a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9339ef158ab344a5b08a53ba61c0fa4a()
        {
          this.Initialize("get_damageType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class MTHD_961ced7824f946858850bcef53c9bed7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_961ced7824f946858850bcef53c9bed7()
        {
          this.Initialize("get_book", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class MTHD_0d82cdf31d98423ab583319cdfa49286 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d82cdf31d98423ab583319cdfa49286()
        {
          this.Initialize("get_damage", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class MTHD_d6d7379192d84e1bb8d1e080325b3e9a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6d7379192d84e1bb8d1e080325b3e9a()
        {
          this.Initialize("get_explosionRadius", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class MTHD_51751d3e05e1416c9348626d7b5a8fcc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_51751d3e05e1416c9348626d7b5a8fcc()
        {
          this.Initialize("get_description", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class MTHD_85d662c19e2d44538b5dac5820be1ee1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_85d662c19e2d44538b5dac5820be1ee1()
        {
          this.Initialize("get_descriptionOnly", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class MTHD_52b193fcbfc042bc9a18d90e2e18a392 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_52b193fcbfc042bc9a18d90e2e18a392()
        {
          this.Initialize("get_descriptionExtra", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class MTHD_f66359024a124d5395e220ff70f24ea8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f66359024a124d5395e220ff70f24ea8()
        {
          this.Initialize("get_name", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }

      private sealed class MTHD_9d00db7056204fdbabff0765e52dd38b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d00db7056204fdbabff0765e52dd38b()
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

      private sealed class MTHD_9e9ec1b3ec6b4c83851804f3703a6d26 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e9ec1b3ec6b4c83851804f3703a6d26()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_617c5c35add642e3beb31890e13916e0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_617c5c35add642e3beb31890e13916e0()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_310e0498a12c4e7f8159c55047316a68 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_310e0498a12c4e7f8159c55047316a68()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_5dbcf8e6af50448fb0a40a7a8d298bf9 : HardwiredMemberDescriptor
      {
        internal PROP_5dbcf8e6af50448fb0a40a7a8d298bf9()
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

      private sealed class PROP_0c1560cd61e640109d4571c81b21d7c7 : HardwiredMemberDescriptor
      {
        internal PROP_0c1560cd61e640109d4571c81b21d7c7()
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

      private sealed class PROP_5209fdca27214b3aa3666fc2b3c85045 : HardwiredMemberDescriptor
      {
        internal PROP_5209fdca27214b3aa3666fc2b3c85045()
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

      private sealed class PROP_0380c6ffb1dc410f9a8f5a8d735c0caf : HardwiredMemberDescriptor
      {
        internal PROP_0380c6ffb1dc410f9a8f5a8d735c0caf()
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

      private sealed class PROP_e68cf91639a44f47bff386aee68f77cd : HardwiredMemberDescriptor
      {
        internal PROP_e68cf91639a44f47bff386aee68f77cd()
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

      private sealed class PROP_1c1ad5fccec84252a38cc92dc048816d : HardwiredMemberDescriptor
      {
        internal PROP_1c1ad5fccec84252a38cc92dc048816d()
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

      private sealed class PROP_ec7b472f91a6417087d05d32ace640a9 : HardwiredMemberDescriptor
      {
        internal PROP_ec7b472f91a6417087d05d32ace640a9()
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

      private sealed class PROP_8dc4b5fb315040c5911b4f7c3b68c6d1 : HardwiredMemberDescriptor
      {
        internal PROP_8dc4b5fb315040c5911b4f7c3b68c6d1()
          : base(typeof (SpellEnum), "spellEnum", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).spellEnum;
        }
      }

      private sealed class PROP_fb49b88053d64e3080e545d131c7b639 : HardwiredMemberDescriptor
      {
        internal PROP_fb49b88053d64e3080e545d131c7b639()
          : base(typeof (CastType), "castType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).castType;
        }
      }

      private sealed class PROP_b8b7bd45f37d49b1b4de99f1362e4877 : HardwiredMemberDescriptor
      {
        internal PROP_b8b7bd45f37d49b1b4de99f1362e4877()
          : base(typeof (DamageType), "damageType", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damageType;
        }
      }

      private sealed class PROP_1ad399e1d6e44abbbe0deecb19846407 : HardwiredMemberDescriptor
      {
        internal PROP_1ad399e1d6e44abbbe0deecb19846407()
          : base(typeof (BookOf), "book", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).book;
        }
      }

      private sealed class PROP_a097245a3c3447e2921c0f7516ad0566 : HardwiredMemberDescriptor
      {
        internal PROP_a097245a3c3447e2921c0f7516ad0566()
          : base(typeof (int), "damage", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).damage;
        }
      }

      private sealed class PROP_bd35c23d742f46568e8c11ea9579dc10 : HardwiredMemberDescriptor
      {
        internal PROP_bd35c23d742f46568e8c11ea9579dc10()
          : base(typeof (int), "explosionRadius", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).explosionRadius;
        }
      }

      private sealed class PROP_b8463fe72da5497db0bdeda2824c6be7 : HardwiredMemberDescriptor
      {
        internal PROP_b8463fe72da5497db0bdeda2824c6be7()
          : base(typeof (string), "description", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).description;
        }
      }

      private sealed class PROP_6124ce922b1a49788dec11e1cc3b80eb : HardwiredMemberDescriptor
      {
        internal PROP_6124ce922b1a49788dec11e1cc3b80eb()
          : base(typeof (string), "descriptionOnly", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionOnly;
        }
      }

      private sealed class PROP_5171fa1fcbd040bf97ff0195fb4bca28 : HardwiredMemberDescriptor
      {
        internal PROP_5171fa1fcbd040bf97ff0195fb4bca28()
          : base(typeof (string), "descriptionExtra", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).descriptionExtra;
        }
      }

      private sealed class PROP_6f4458f1baf341558449ecff99b4d16c : HardwiredMemberDescriptor
      {
        internal PROP_6f4458f1baf341558449ecff99b4d16c()
          : base(typeof (string), "name", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerSpell) obj).name;
        }
      }
    }

    private sealed class TYPE_a4bdb6cb8f81422ba0a39ca2377d2a45 : HardwiredUserDataDescriptor
    {
      internal TYPE_a4bdb6cb8f81422ba0a39ca2377d2a45()
        : base(typeof (ContainerTower))
      {
        this.AddMember("get_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a4bdb6cb8f81422ba0a39ca2377d2a45.MTHD_34dc59e02d2c46b2a8fc7361f6aa2e69()
        }));
        this.AddMember("set_health", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_health", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a4bdb6cb8f81422ba0a39ca2377d2a45.MTHD_63e3cd2d59054e8ba5ba60a10505b356()
        }));
        this.AddMember("get_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a4bdb6cb8f81422ba0a39ca2377d2a45.MTHD_a9af5f9efe02441bb47a45f16d570f0e()
        }));
        this.AddMember("set_maxHealth", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_maxHealth", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a4bdb6cb8f81422ba0a39ca2377d2a45.MTHD_ee2b70a777ae4c80b63a9aedb60310eb()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a4bdb6cb8f81422ba0a39ca2377d2a45.MTHD_34868822006e410ca65fd68d9c4c438c()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a4bdb6cb8f81422ba0a39ca2377d2a45.MTHD_2c7d78fbc3df4af18c92723b806f16ff()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a4bdb6cb8f81422ba0a39ca2377d2a45.MTHD_e7cdbeaf01664d7d81f77b1670362687()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a4bdb6cb8f81422ba0a39ca2377d2a45.MTHD_7528d63be75c4064967495b944399167()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a4bdb6cb8f81422ba0a39ca2377d2a45.MTHD_0d2bf095cc0d443a99b96fd4b52967ca()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a4bdb6cb8f81422ba0a39ca2377d2a45.MTHD_fdd600228155415b9c9db846fb55cb49()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a4bdb6cb8f81422ba0a39ca2377d2a45.MTHD_afe81b6acd56416d91a22eaa8ae2e426()
        }));
        this.AddMember("getType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("getType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a4bdb6cb8f81422ba0a39ca2377d2a45.MTHD_de77b8d00a774233bb48206ccdcfcc19()
        }));
        this.AddMember("kill", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("kill", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a4bdb6cb8f81422ba0a39ca2377d2a45.MTHD_8a053c772a3d495b84df952528e0a1eb()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a4bdb6cb8f81422ba0a39ca2377d2a45.MTHD_65b02ca653db48d78d41af87d6a2053b()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a4bdb6cb8f81422ba0a39ca2377d2a45.MTHD_16ef66f78da04d51b97b84917827c2a2()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a4bdb6cb8f81422ba0a39ca2377d2a45.MTHD_0a3724c2fd0c4edabfdadd55184164ad()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (ContainerTower), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_a4bdb6cb8f81422ba0a39ca2377d2a45.MTHD_bf39e016fff94d68ab70f68d22e41e37()
        }));
        this.AddMember("health", (IMemberDescriptor) new Bridge.TYPE_a4bdb6cb8f81422ba0a39ca2377d2a45.PROP_a6bbbf7c296d4736a93cf218922a9150());
        this.AddMember("maxHealth", (IMemberDescriptor) new Bridge.TYPE_a4bdb6cb8f81422ba0a39ca2377d2a45.PROP_ef63ecd20a7f4af8bf14b7511b6c1065());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_a4bdb6cb8f81422ba0a39ca2377d2a45.PROP_8326e54da0634c54a3c4885d763a2688());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_a4bdb6cb8f81422ba0a39ca2377d2a45.PROP_135ad799291f46e692eedb0e38f0cf90());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_a4bdb6cb8f81422ba0a39ca2377d2a45.PROP_fd417c85faaf4a7187fe001721b581f8());
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_a4bdb6cb8f81422ba0a39ca2377d2a45.PROP_b828fecedbd8401588cee9cb728bd897());
      }

      private sealed class MTHD_34dc59e02d2c46b2a8fc7361f6aa2e69 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_34dc59e02d2c46b2a8fc7361f6aa2e69()
        {
          this.Initialize("get_health", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).health;
        }
      }

      private sealed class MTHD_63e3cd2d59054e8ba5ba60a10505b356 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_63e3cd2d59054e8ba5ba60a10505b356()
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

      private sealed class MTHD_a9af5f9efe02441bb47a45f16d570f0e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a9af5f9efe02441bb47a45f16d570f0e()
        {
          this.Initialize("get_maxHealth", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).maxHealth;
        }
      }

      private sealed class MTHD_ee2b70a777ae4c80b63a9aedb60310eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ee2b70a777ae4c80b63a9aedb60310eb()
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

      private sealed class MTHD_34868822006e410ca65fd68d9c4c438c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_34868822006e410ca65fd68d9c4c438c()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).x;
        }
      }

      private sealed class MTHD_2c7d78fbc3df4af18c92723b806f16ff : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2c7d78fbc3df4af18c92723b806f16ff()
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

      private sealed class MTHD_e7cdbeaf01664d7d81f77b1670362687 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7cdbeaf01664d7d81f77b1670362687()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).y;
        }
      }

      private sealed class MTHD_7528d63be75c4064967495b944399167 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7528d63be75c4064967495b944399167()
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

      private sealed class MTHD_0d2bf095cc0d443a99b96fd4b52967ca : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0d2bf095cc0d443a99b96fd4b52967ca()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).position;
        }
      }

      private sealed class MTHD_fdd600228155415b9c9db846fb55cb49 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fdd600228155415b9c9db846fb55cb49()
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

      private sealed class MTHD_afe81b6acd56416d91a22eaa8ae2e426 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_afe81b6acd56416d91a22eaa8ae2e426()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }

      private sealed class MTHD_de77b8d00a774233bb48206ccdcfcc19 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_de77b8d00a774233bb48206ccdcfcc19()
        {
          this.Initialize("getType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).getType();
        }
      }

      private sealed class MTHD_8a053c772a3d495b84df952528e0a1eb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8a053c772a3d495b84df952528e0a1eb()
        {
          this.Initialize("kill", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((ContainerTower) obj).kill();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_65b02ca653db48d78d41af87d6a2053b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65b02ca653db48d78d41af87d6a2053b()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((ContainerTower) obj).GetHashCode();
        }
      }

      private sealed class MTHD_16ef66f78da04d51b97b84917827c2a2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_16ef66f78da04d51b97b84917827c2a2()
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

      private sealed class MTHD_0a3724c2fd0c4edabfdadd55184164ad : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0a3724c2fd0c4edabfdadd55184164ad()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_bf39e016fff94d68ab70f68d22e41e37 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf39e016fff94d68ab70f68d22e41e37()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_a6bbbf7c296d4736a93cf218922a9150 : HardwiredMemberDescriptor
      {
        internal PROP_a6bbbf7c296d4736a93cf218922a9150()
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

      private sealed class PROP_ef63ecd20a7f4af8bf14b7511b6c1065 : HardwiredMemberDescriptor
      {
        internal PROP_ef63ecd20a7f4af8bf14b7511b6c1065()
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

      private sealed class PROP_8326e54da0634c54a3c4885d763a2688 : HardwiredMemberDescriptor
      {
        internal PROP_8326e54da0634c54a3c4885d763a2688()
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

      private sealed class PROP_135ad799291f46e692eedb0e38f0cf90 : HardwiredMemberDescriptor
      {
        internal PROP_135ad799291f46e692eedb0e38f0cf90()
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

      private sealed class PROP_fd417c85faaf4a7187fe001721b581f8 : HardwiredMemberDescriptor
      {
        internal PROP_fd417c85faaf4a7187fe001721b581f8()
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

      private sealed class PROP_b828fecedbd8401588cee9cb728bd897 : HardwiredMemberDescriptor
      {
        internal PROP_b828fecedbd8401588cee9cb728bd897()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((ContainerTower) obj).isDead;
        }
      }
    }

    private sealed class TYPE_922a523ca23442e897e9a6abaf5ddd7a : HardwiredUserDataDescriptor
    {
      internal TYPE_922a523ca23442e897e9a6abaf5ddd7a()
        : base(typeof (Educative.Point))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_922a523ca23442e897e9a6abaf5ddd7a.MTHD_d780be777bdd4d819b9d48fa9e91f1dc(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_922a523ca23442e897e9a6abaf5ddd7a.MTHD_08a1a993e6f74faf91177c1986179b31()
        }));
        this.AddMember("distance", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("distance", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_922a523ca23442e897e9a6abaf5ddd7a.MTHD_78497f9fcae145239ea21096b339a3ab(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_922a523ca23442e897e9a6abaf5ddd7a.MTHD_4b4e4c52ba2b4bb5802ae4a82701192d()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_922a523ca23442e897e9a6abaf5ddd7a.MTHD_4d2f6d5181fc479893574d065a5086ea()
        }));
        this.AddMember("copy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("copy", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_922a523ca23442e897e9a6abaf5ddd7a.MTHD_4f2ae13644b64041b9be2d2aa7325594()
        }));
        this.AddMember("normalized", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalized", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_922a523ca23442e897e9a6abaf5ddd7a.MTHD_d6bd550bea5748b69c8851cfaab593af()
        }));
        this.AddMember("normalize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("normalize", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_922a523ca23442e897e9a6abaf5ddd7a.MTHD_86a14d14960d42d8a450d8555aa2d2a8()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_922a523ca23442e897e9a6abaf5ddd7a.MTHD_e9deb7ab9f7e4701be63329c810d4d57()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_922a523ca23442e897e9a6abaf5ddd7a.MTHD_0c1636277d3a4ef4b0a7934ee7294b6b()
        }));
        this.AddMember("op_Equality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Equality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_922a523ca23442e897e9a6abaf5ddd7a.MTHD_7dd22d7645704a30a5612c598df8553a()
        }));
        this.AddMember("op_Subtraction", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Subtraction", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_922a523ca23442e897e9a6abaf5ddd7a.MTHD_df521261aeea4002b9a757d0d9a6923a(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_922a523ca23442e897e9a6abaf5ddd7a.MTHD_d2f4b30293da43c8b699db876d43b0f6()
        }));
        this.AddMember("op_Addition", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Addition", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_922a523ca23442e897e9a6abaf5ddd7a.MTHD_6d72845e2a974da4874b117f31334b31(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_922a523ca23442e897e9a6abaf5ddd7a.MTHD_9f7cdb1fdc2b48c6b91820794a3548d3()
        }));
        this.AddMember("op_Multiply", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Multiply", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_922a523ca23442e897e9a6abaf5ddd7a.MTHD_6cf715ea722b469b8c78b2189d79de46(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_922a523ca23442e897e9a6abaf5ddd7a.MTHD_e84e655262fd4e8d811d77d7ea3c2bee()
        }));
        this.AddMember("op_Division", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Division", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_922a523ca23442e897e9a6abaf5ddd7a.MTHD_61c8fc661fa54c8685c52126f3c130ae(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_922a523ca23442e897e9a6abaf5ddd7a.MTHD_3ec4e03f120445a796839fc04247cb13()
        }));
        this.AddMember("op_Modulus", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Modulus", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_922a523ca23442e897e9a6abaf5ddd7a.MTHD_a95d112fe9db440ca8d2fdf9eef67d0e(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_922a523ca23442e897e9a6abaf5ddd7a.MTHD_4d2fd0162aff497fb5e79cbea6a5e650()
        }));
        this.AddMember("op_Inequality", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("op_Inequality", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_922a523ca23442e897e9a6abaf5ddd7a.MTHD_a918262d20e748929789c3d1d3a58b22()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Educative.Point), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_922a523ca23442e897e9a6abaf5ddd7a.MTHD_127cb43dea8d41879f88d6f4f842e324()
        }));
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_922a523ca23442e897e9a6abaf5ddd7a.FLDV_9210e52cbfe2426daefd1aa20788dcde());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_922a523ca23442e897e9a6abaf5ddd7a.FLDV_1e7f3502c4eb4c92a07d04b553b14680());
      }

      private sealed class MTHD_d780be777bdd4d819b9d48fa9e91f1dc : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d780be777bdd4d819b9d48fa9e91f1dc()
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

      private sealed class MTHD_08a1a993e6f74faf91177c1986179b31 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_08a1a993e6f74faf91177c1986179b31()
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

      private sealed class MTHD_78497f9fcae145239ea21096b339a3ab : HardwiredMethodMemberDescriptor
      {
        internal MTHD_78497f9fcae145239ea21096b339a3ab()
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

      private sealed class MTHD_4b4e4c52ba2b4bb5802ae4a82701192d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4b4e4c52ba2b4bb5802ae4a82701192d()
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

      private sealed class MTHD_4d2f6d5181fc479893574d065a5086ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d2f6d5181fc479893574d065a5086ea()
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

      private sealed class MTHD_4f2ae13644b64041b9be2d2aa7325594 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4f2ae13644b64041b9be2d2aa7325594()
        {
          this.Initialize("copy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).copy();
        }
      }

      private sealed class MTHD_d6bd550bea5748b69c8851cfaab593af : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d6bd550bea5748b69c8851cfaab593af()
        {
          this.Initialize("normalized", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).normalized();
        }
      }

      private sealed class MTHD_86a14d14960d42d8a450d8555aa2d2a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_86a14d14960d42d8a450d8555aa2d2a8()
        {
          this.Initialize("normalize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((Educative.Point) obj).normalize();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_e9deb7ab9f7e4701be63329c810d4d57 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e9deb7ab9f7e4701be63329c810d4d57()
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

      private sealed class MTHD_0c1636277d3a4ef4b0a7934ee7294b6b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0c1636277d3a4ef4b0a7934ee7294b6b()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((Educative.Point) obj).GetHashCode();
        }
      }

      private sealed class MTHD_7dd22d7645704a30a5612c598df8553a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7dd22d7645704a30a5612c598df8553a()
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

      private sealed class MTHD_df521261aeea4002b9a757d0d9a6923a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_df521261aeea4002b9a757d0d9a6923a()
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

      private sealed class MTHD_d2f4b30293da43c8b699db876d43b0f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d2f4b30293da43c8b699db876d43b0f6()
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

      private sealed class MTHD_6d72845e2a974da4874b117f31334b31 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6d72845e2a974da4874b117f31334b31()
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

      private sealed class MTHD_9f7cdb1fdc2b48c6b91820794a3548d3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9f7cdb1fdc2b48c6b91820794a3548d3()
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

      private sealed class MTHD_6cf715ea722b469b8c78b2189d79de46 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6cf715ea722b469b8c78b2189d79de46()
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

      private sealed class MTHD_e84e655262fd4e8d811d77d7ea3c2bee : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e84e655262fd4e8d811d77d7ea3c2bee()
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

      private sealed class MTHD_61c8fc661fa54c8685c52126f3c130ae : HardwiredMethodMemberDescriptor
      {
        internal MTHD_61c8fc661fa54c8685c52126f3c130ae()
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

      private sealed class MTHD_3ec4e03f120445a796839fc04247cb13 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3ec4e03f120445a796839fc04247cb13()
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

      private sealed class MTHD_a95d112fe9db440ca8d2fdf9eef67d0e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a95d112fe9db440ca8d2fdf9eef67d0e()
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

      private sealed class MTHD_4d2fd0162aff497fb5e79cbea6a5e650 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d2fd0162aff497fb5e79cbea6a5e650()
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

      private sealed class MTHD_a918262d20e748929789c3d1d3a58b22 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a918262d20e748929789c3d1d3a58b22()
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

      private sealed class MTHD_127cb43dea8d41879f88d6f4f842e324 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_127cb43dea8d41879f88d6f4f842e324()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_9210e52cbfe2426daefd1aa20788dcde : HardwiredMemberDescriptor
      {
        internal FLDV_9210e52cbfe2426daefd1aa20788dcde()
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

      private sealed class FLDV_1e7f3502c4eb4c92a07d04b553b14680 : HardwiredMemberDescriptor
      {
        internal FLDV_1e7f3502c4eb4c92a07d04b553b14680()
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

    private sealed class TYPE_dc30ddda57fc4efcaf62e0dbf73bb6ad : HardwiredUserDataDescriptor
    {
      internal TYPE_dc30ddda57fc4efcaf62e0dbf73bb6ad()
        : base(typeof (Summon))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc30ddda57fc4efcaf62e0dbf73bb6ad.MTHD_c3df0b7bda7c449197264bdc2703b744()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc30ddda57fc4efcaf62e0dbf73bb6ad.MTHD_b1d1afccd74b46e6a45ae47f5b8d296b()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc30ddda57fc4efcaf62e0dbf73bb6ad.MTHD_ecc0f6cb349c4f0b90441a232a8a4c12()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc30ddda57fc4efcaf62e0dbf73bb6ad.MTHD_24996a8f7acf477bae3f96e8b5e8787f()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc30ddda57fc4efcaf62e0dbf73bb6ad.MTHD_fb258a9129c84021888a9ffbd00a6d41()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (Summon), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_dc30ddda57fc4efcaf62e0dbf73bb6ad.MTHD_e7288f043c954b5094be18d25ef75c0b()
        }));
        this.AddMember("spell", (IMemberDescriptor) new Bridge.TYPE_dc30ddda57fc4efcaf62e0dbf73bb6ad.FLDV_a2c488399b94426fa052787db4c8e34a());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_dc30ddda57fc4efcaf62e0dbf73bb6ad.FLDV_62b6a821e0f54b6dbdc8d01966983d36());
        this.AddMember("team", (IMemberDescriptor) new Bridge.TYPE_dc30ddda57fc4efcaf62e0dbf73bb6ad.FLDV_65c750c563ac408197e8184ec2ec5e53());
        this.AddMember("onPlayersPanel", (IMemberDescriptor) new Bridge.TYPE_dc30ddda57fc4efcaf62e0dbf73bb6ad.FLDV_e2b0f53cd7e24d20976d7f22dfcc0424());
        this.AddMember("useAI", (IMemberDescriptor) new Bridge.TYPE_dc30ddda57fc4efcaf62e0dbf73bb6ad.FLDV_b712ac588c8c45eba847282a88c292d1());
        this.AddMember("no_AI_still_use_turn", (IMemberDescriptor) new Bridge.TYPE_dc30ddda57fc4efcaf62e0dbf73bb6ad.FLDV_01a1770a70a94f5d8b6862c309297b9c());
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_dc30ddda57fc4efcaf62e0dbf73bb6ad.FLDV_7548f133b92a458aa5255eb6e09982cd());
        this.AddMember("playSound", (IMemberDescriptor) new Bridge.TYPE_dc30ddda57fc4efcaf62e0dbf73bb6ad.FLDV_fa342551e37242d6867a5278d0e0fe68());
        this.AddMember("prestige", (IMemberDescriptor) new Bridge.TYPE_dc30ddda57fc4efcaf62e0dbf73bb6ad.FLDV_0062220239a54bb1b4861cf48e5d915a());
        this.AddMember("colors", (IMemberDescriptor) new Bridge.TYPE_dc30ddda57fc4efcaf62e0dbf73bb6ad.FLDV_410c6a9f1f9b42188b5da5d5d93c86f3());
        this.AddMember("spells", (IMemberDescriptor) new Bridge.TYPE_dc30ddda57fc4efcaf62e0dbf73bb6ad.FLDV_21ff3ac0f54840578e2e98edabdef9fd());
        this.AddMember("outfit", (IMemberDescriptor) new Bridge.TYPE_dc30ddda57fc4efcaf62e0dbf73bb6ad.FLDV_746cf5e2ad364b7eb8a831193c322b40());
        this.AddMember("elemental", (IMemberDescriptor) new Bridge.TYPE_dc30ddda57fc4efcaf62e0dbf73bb6ad.FLDV_6a3fad8a4e614e5e9b8f93a7eba85631());
      }

      private sealed class MTHD_c3df0b7bda7c449197264bdc2703b744 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c3df0b7bda7c449197264bdc2703b744()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new Summon();
        }
      }

      private sealed class MTHD_b1d1afccd74b46e6a45ae47f5b8d296b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b1d1afccd74b46e6a45ae47f5b8d296b()
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

      private sealed class MTHD_ecc0f6cb349c4f0b90441a232a8a4c12 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ecc0f6cb349c4f0b90441a232a8a4c12()
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

      private sealed class MTHD_24996a8f7acf477bae3f96e8b5e8787f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_24996a8f7acf477bae3f96e8b5e8787f()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_fb258a9129c84021888a9ffbd00a6d41 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fb258a9129c84021888a9ffbd00a6d41()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_e7288f043c954b5094be18d25ef75c0b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e7288f043c954b5094be18d25ef75c0b()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_a2c488399b94426fa052787db4c8e34a : HardwiredMemberDescriptor
      {
        internal FLDV_a2c488399b94426fa052787db4c8e34a()
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

      private sealed class FLDV_62b6a821e0f54b6dbdc8d01966983d36 : HardwiredMemberDescriptor
      {
        internal FLDV_62b6a821e0f54b6dbdc8d01966983d36()
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

      private sealed class FLDV_65c750c563ac408197e8184ec2ec5e53 : HardwiredMemberDescriptor
      {
        internal FLDV_65c750c563ac408197e8184ec2ec5e53()
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

      private sealed class FLDV_e2b0f53cd7e24d20976d7f22dfcc0424 : HardwiredMemberDescriptor
      {
        internal FLDV_e2b0f53cd7e24d20976d7f22dfcc0424()
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

      private sealed class FLDV_b712ac588c8c45eba847282a88c292d1 : HardwiredMemberDescriptor
      {
        internal FLDV_b712ac588c8c45eba847282a88c292d1()
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

      private sealed class FLDV_01a1770a70a94f5d8b6862c309297b9c : HardwiredMemberDescriptor
      {
        internal FLDV_01a1770a70a94f5d8b6862c309297b9c()
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

      private sealed class FLDV_7548f133b92a458aa5255eb6e09982cd : HardwiredMemberDescriptor
      {
        internal FLDV_7548f133b92a458aa5255eb6e09982cd()
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

      private sealed class FLDV_fa342551e37242d6867a5278d0e0fe68 : HardwiredMemberDescriptor
      {
        internal FLDV_fa342551e37242d6867a5278d0e0fe68()
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

      private sealed class FLDV_0062220239a54bb1b4861cf48e5d915a : HardwiredMemberDescriptor
      {
        internal FLDV_0062220239a54bb1b4861cf48e5d915a()
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

      private sealed class FLDV_410c6a9f1f9b42188b5da5d5d93c86f3 : HardwiredMemberDescriptor
      {
        internal FLDV_410c6a9f1f9b42188b5da5d5d93c86f3()
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

      private sealed class FLDV_21ff3ac0f54840578e2e98edabdef9fd : HardwiredMemberDescriptor
      {
        internal FLDV_21ff3ac0f54840578e2e98edabdef9fd()
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

      private sealed class FLDV_746cf5e2ad364b7eb8a831193c322b40 : HardwiredMemberDescriptor
      {
        internal FLDV_746cf5e2ad364b7eb8a831193c322b40()
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

      private sealed class FLDV_6a3fad8a4e614e5e9b8f93a7eba85631 : HardwiredMemberDescriptor
      {
        internal FLDV_6a3fad8a4e614e5e9b8f93a7eba85631()
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

    private sealed class TYPE_51ba4656ae664d54a0d8cb3825b1bed6 : HardwiredUserDataDescriptor
    {
      internal TYPE_51ba4656ae664d54a0d8cb3825b1bed6()
        : base(typeof (UIElement))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_6324c7bf352f44ae8bb27c090c00fe9f()
        }));
        this.AddMember("get_isDead", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_isDead", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_be5ba34019fd4daa9d575c60348aa3f6()
        }));
        this.AddMember("get_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_abcbc5f676f141f88d5e6aaa07efc0b0()
        }));
        this.AddMember("set_visible", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_visible", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_94f8621379d44bb4ba5fc0dbda501011()
        }));
        this.AddMember("get_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_42d5ee1ea3744913bb1ce0152313aa30()
        }));
        this.AddMember("set_graphic", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_graphic", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_a7b34f88130040509ae3caa85bbe2e0e()
        }));
        this.AddMember("get_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_b34d64ceae3349f584e89c42d4fbe88c()
        }));
        this.AddMember("set_anchor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_anchor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_728e87697f4646cd903ce10510e882b1()
        }));
        this.AddMember("get_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_d48299de5d064d6ba89692918b70a54b()
        }));
        this.AddMember("set_width", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_width", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_9d1903a81a414acfbea502bcabc686c7()
        }));
        this.AddMember("get_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_7286fea51fea413b91571825a54c49d8()
        }));
        this.AddMember("set_height", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_height", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_47fc24fa5fbe4cc28875e77b1fdf494a()
        }));
        this.AddMember("get_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_f6940afba32e43a882f2fea9d49f8cc9()
        }));
        this.AddMember("set_size", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_size", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_f817bcad93974bb6b1a6efadd61526e8()
        }));
        this.AddMember("get_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_5e3721a6ae3640979e8fd5d7f0948621()
        }));
        this.AddMember("set_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_e799ea52dfe64b50b1fc8d66228c201c()
        }));
        this.AddMember("get_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_635cd44beb8f492c9af055483a41254c()
        }));
        this.AddMember("set_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_ef7bcf5cdd92449a86798f776523029f()
        }));
        this.AddMember("get_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_4775f880a70b408a91f03dd70cfd3068()
        }));
        this.AddMember("set_position", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_position", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_a1c207d2507140b58ed9414e66e0f95a()
        }));
        this.AddMember("get_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_706adca5c9e44eb7b88f42e290bcaa7f()
        }));
        this.AddMember("set_pivot_x", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_x", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_56dcc03362ce40088b40730f9c2670d2()
        }));
        this.AddMember("get_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_1cc8cb6614db4bd49c76cd0c852e2655()
        }));
        this.AddMember("set_pivot_y", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot_y", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_4922c605bc114d4aac1c421efcfaa46a()
        }));
        this.AddMember("get_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_b4cb10421a034c7eb116233f60054199()
        }));
        this.AddMember("set_pivot", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_pivot", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_36452d480e5343ec9680d9acc9fa7709()
        }));
        this.AddMember("get_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_109d2291abce4edfbfd8f4a2d65a8bf5()
        }));
        this.AddMember("set_angle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_angle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_53b69b651207425dbbabac1937da41bb()
        }));
        this.AddMember("get_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_b48b3ed51f1c4264b03f947becca49df()
        }));
        this.AddMember("set_onClick", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_6c06cf2045bc410ea492f3dfd3c6d4d4()
        }));
        this.AddMember("get_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_f812f08cb2024d0f9894d73620e6431d()
        }));
        this.AddMember("set_onClick2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_onClick2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_79b2c23067ac4d1383e7ca300c94a99f()
        }));
        this.AddMember("get_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_9b65fc7296f343568e765ea5ba1c4045()
        }));
        this.AddMember("set_color", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_afad8333a95b4ec393017f5b636bebfd()
        }));
        this.AddMember("get_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_ea93da9267984a029a97e7a9062cfb1d()
        }));
        this.AddMember("set_color2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_color2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_33df9756ac76461c8aca58f623bc3194()
        }));
        this.AddMember("get_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_9e22e2fafb964dceb4ca9b19914be13f()
        }));
        this.AddMember("set_text", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_text", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_62f568e1fbda4e7e9569be44df673b33()
        }));
        this.AddMember("get_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_2a9bb8b42a6e4e4fa58df54372f13153()
        }));
        this.AddMember("set_textColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_65b8a4cacc1e44aa94510323d5f478be()
        }));
        this.AddMember("get_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_682f1cbc16a44843812825b62e8c003b()
        }));
        this.AddMember("set_textColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_afa41daf941646a89a6bf0cf14678c85()
        }));
        this.AddMember("get_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_72cf9f91995f424e8d041b9e8fd30af2()
        }));
        this.AddMember("set_highlightColor", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_bbc5ee6b17254850974a166fc780e1a8()
        }));
        this.AddMember("get_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_390ddc98db9f445b934d733f39b4c112()
        }));
        this.AddMember("set_highlightColor2", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_highlightColor2", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_51952aa56e174b0ebcb401ac40d8d3b6()
        }));
        this.AddMember("get_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_59c5497b453645f9b8127cf9844b5685()
        }));
        this.AddMember("set_textStyle", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textStyle", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_4d9c56bb4e9a4a45bf7cbb2e065bfc8b()
        }));
        this.AddMember("get_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("get_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_c6aa6d96e35c49de965fb5fa2ab13abd()
        }));
        this.AddMember("set_textSize", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("set_textSize", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_c404becd5e2148b9829a91185161f57a()
        }));
        this.AddMember("activateInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("activateInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_b49f03a5790e45b1baa07f877a4bd738()
        }));
        this.AddMember("createUI", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createUI", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_1531ea7e363545f8b13a8b96b5887b2c()
        }));
        this.AddMember("createInput", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("createInput", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_f17d1328b44046d3b03ade542a733942()
        }));
        this.AddMember("duplicate", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("duplicate", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_65b8e60fb8154cc79f09ff629fc3a66b()
        }));
        this.AddMember("destroyHierarchy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroyHierarchy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_39c4fc3df3a143ceb6957ea1f68ca1c4()
        }));
        this.AddMember("destroy", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("destroy", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_8ef7083f286644edbeac87d7d1ee4b6a()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_8c4978df982846f395c1b1689b8d220f()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_7900f764c4094704984778c8f2e2c962()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_fad0e3e1a02249cebd64af4785d5a7e9()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (UIElement), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.MTHD_05cde49daf094f6fa1202312041f53de()
        }));
        this.AddMember("isDead", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.PROP_8dd8bd2cecca4dc7a424f44905afd357());
        this.AddMember("visible", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.PROP_33ba3d696ec1411da29fe0014c7e8492());
        this.AddMember("graphic", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.PROP_2ddbd11024a34702aa9dfb8c32e86ca4());
        this.AddMember("anchor", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.PROP_f85c19052b134b6dacb2708bba354815());
        this.AddMember("width", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.PROP_617be13878694b009938daae24b39b50());
        this.AddMember("height", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.PROP_3e079642e21042b1a5dab3c00d42753f());
        this.AddMember("size", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.PROP_f2b0d205859748a4a2a3826d6d678072());
        this.AddMember("x", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.PROP_317cc7f6c52143049d26ff833120c8f7());
        this.AddMember("y", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.PROP_35582b88d538461e86064a37b97631ea());
        this.AddMember("position", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.PROP_aa094db2a0da48c9b073303e37f7dade());
        this.AddMember("pivot_x", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.PROP_286906ede421454c832511d87030910e());
        this.AddMember("pivot_y", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.PROP_a8d33072f17f4300b7df778a5e5539b6());
        this.AddMember("pivot", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.PROP_17797007a47c4155bb595da3641b13a2());
        this.AddMember("angle", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.PROP_978ac21d14cf4d4c85607ca5e76e220e());
        this.AddMember("onClick", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.PROP_9983cc590c354b7b9bbb0292393aec71());
        this.AddMember("onClick2", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.PROP_1080f4bf5bd148c491adbf6bd30e0a08());
        this.AddMember("color", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.PROP_00e25925f6ba400e9c25cabd2ac53cb3());
        this.AddMember("color2", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.PROP_645e8cf5c7ca4f3eae5c643eb14d4845());
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.PROP_9e1f3a88c34d433fb243803276011bb6());
        this.AddMember("textColor", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.PROP_cb3561088e104a2f8bf4e986df21767a());
        this.AddMember("textColor2", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.PROP_baca38857b1640639b323b8c2c7b888e());
        this.AddMember("highlightColor", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.PROP_bce8e5531160445493ca62693ec4e4b7());
        this.AddMember("highlightColor2", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.PROP_b7ea4df009224d58af658da4e36e2e95());
        this.AddMember("textStyle", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.PROP_67e6801fe5954ae0a39479760f141132());
        this.AddMember("textSize", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.PROP_c663703574bd4ea6ae7b9abe5ea7ce5c());
        this.AddMember("parent", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.FLDV_f923dd87ce324115a0421745449a1c3e());
        this.AddMember("clickID", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.FLDV_684cd30941fd42e1b329dba139b15a61());
        this.AddMember("clickDestroy", (IMemberDescriptor) new Bridge.TYPE_51ba4656ae664d54a0d8cb3825b1bed6.FLDV_ef02760c5a1740f0a53ea9cb23d48dc2());
      }

      private sealed class MTHD_6324c7bf352f44ae8bb27c090c00fe9f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6324c7bf352f44ae8bb27c090c00fe9f()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new UIElement();
        }
      }

      private sealed class MTHD_be5ba34019fd4daa9d575c60348aa3f6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_be5ba34019fd4daa9d575c60348aa3f6()
        {
          this.Initialize("get_isDead", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class MTHD_abcbc5f676f141f88d5e6aaa07efc0b0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_abcbc5f676f141f88d5e6aaa07efc0b0()
        {
          this.Initialize("get_visible", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).visible;
        }
      }

      private sealed class MTHD_94f8621379d44bb4ba5fc0dbda501011 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_94f8621379d44bb4ba5fc0dbda501011()
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

      private sealed class MTHD_42d5ee1ea3744913bb1ce0152313aa30 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_42d5ee1ea3744913bb1ce0152313aa30()
        {
          this.Initialize("get_graphic", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return ((UIElement) obj).graphic;
        }
      }

      private sealed class MTHD_a7b34f88130040509ae3caa85bbe2e0e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a7b34f88130040509ae3caa85bbe2e0e()
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

      private sealed class MTHD_b34d64ceae3349f584e89c42d4fbe88c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b34d64ceae3349f584e89c42d4fbe88c()
        {
          this.Initialize("get_anchor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).anchor;
        }
      }

      private sealed class MTHD_728e87697f4646cd903ce10510e882b1 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_728e87697f4646cd903ce10510e882b1()
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

      private sealed class MTHD_d48299de5d064d6ba89692918b70a54b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d48299de5d064d6ba89692918b70a54b()
        {
          this.Initialize("get_width", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).width;
        }
      }

      private sealed class MTHD_9d1903a81a414acfbea502bcabc686c7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9d1903a81a414acfbea502bcabc686c7()
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

      private sealed class MTHD_7286fea51fea413b91571825a54c49d8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7286fea51fea413b91571825a54c49d8()
        {
          this.Initialize("get_height", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).height;
        }
      }

      private sealed class MTHD_47fc24fa5fbe4cc28875e77b1fdf494a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_47fc24fa5fbe4cc28875e77b1fdf494a()
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

      private sealed class MTHD_f6940afba32e43a882f2fea9d49f8cc9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f6940afba32e43a882f2fea9d49f8cc9()
        {
          this.Initialize("get_size", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).size;
        }
      }

      private sealed class MTHD_f817bcad93974bb6b1a6efadd61526e8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f817bcad93974bb6b1a6efadd61526e8()
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

      private sealed class MTHD_5e3721a6ae3640979e8fd5d7f0948621 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5e3721a6ae3640979e8fd5d7f0948621()
        {
          this.Initialize("get_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).x;
        }
      }

      private sealed class MTHD_e799ea52dfe64b50b1fc8d66228c201c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e799ea52dfe64b50b1fc8d66228c201c()
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

      private sealed class MTHD_635cd44beb8f492c9af055483a41254c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_635cd44beb8f492c9af055483a41254c()
        {
          this.Initialize("get_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).y;
        }
      }

      private sealed class MTHD_ef7bcf5cdd92449a86798f776523029f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ef7bcf5cdd92449a86798f776523029f()
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

      private sealed class MTHD_4775f880a70b408a91f03dd70cfd3068 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4775f880a70b408a91f03dd70cfd3068()
        {
          this.Initialize("get_position", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).position;
        }
      }

      private sealed class MTHD_a1c207d2507140b58ed9414e66e0f95a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a1c207d2507140b58ed9414e66e0f95a()
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

      private sealed class MTHD_706adca5c9e44eb7b88f42e290bcaa7f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_706adca5c9e44eb7b88f42e290bcaa7f()
        {
          this.Initialize("get_pivot_x", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_x;
        }
      }

      private sealed class MTHD_56dcc03362ce40088b40730f9c2670d2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_56dcc03362ce40088b40730f9c2670d2()
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

      private sealed class MTHD_1cc8cb6614db4bd49c76cd0c852e2655 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1cc8cb6614db4bd49c76cd0c852e2655()
        {
          this.Initialize("get_pivot_y", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot_y;
        }
      }

      private sealed class MTHD_4922c605bc114d4aac1c421efcfaa46a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4922c605bc114d4aac1c421efcfaa46a()
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

      private sealed class MTHD_b4cb10421a034c7eb116233f60054199 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b4cb10421a034c7eb116233f60054199()
        {
          this.Initialize("get_pivot", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).pivot;
        }
      }

      private sealed class MTHD_36452d480e5343ec9680d9acc9fa7709 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_36452d480e5343ec9680d9acc9fa7709()
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

      private sealed class MTHD_109d2291abce4edfbfd8f4a2d65a8bf5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_109d2291abce4edfbfd8f4a2d65a8bf5()
        {
          this.Initialize("get_angle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).angle;
        }
      }

      private sealed class MTHD_53b69b651207425dbbabac1937da41bb : HardwiredMethodMemberDescriptor
      {
        internal MTHD_53b69b651207425dbbabac1937da41bb()
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

      private sealed class MTHD_b48b3ed51f1c4264b03f947becca49df : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b48b3ed51f1c4264b03f947becca49df()
        {
          this.Initialize("get_onClick", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick;
        }
      }

      private sealed class MTHD_6c06cf2045bc410ea492f3dfd3c6d4d4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6c06cf2045bc410ea492f3dfd3c6d4d4()
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

      private sealed class MTHD_f812f08cb2024d0f9894d73620e6431d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f812f08cb2024d0f9894d73620e6431d()
        {
          this.Initialize("get_onClick2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).onClick2;
        }
      }

      private sealed class MTHD_79b2c23067ac4d1383e7ca300c94a99f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_79b2c23067ac4d1383e7ca300c94a99f()
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

      private sealed class MTHD_9b65fc7296f343568e765ea5ba1c4045 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9b65fc7296f343568e765ea5ba1c4045()
        {
          this.Initialize("get_color", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color;
        }
      }

      private sealed class MTHD_afad8333a95b4ec393017f5b636bebfd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_afad8333a95b4ec393017f5b636bebfd()
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

      private sealed class MTHD_ea93da9267984a029a97e7a9062cfb1d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ea93da9267984a029a97e7a9062cfb1d()
        {
          this.Initialize("get_color2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).color2;
        }
      }

      private sealed class MTHD_33df9756ac76461c8aca58f623bc3194 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_33df9756ac76461c8aca58f623bc3194()
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

      private sealed class MTHD_9e22e2fafb964dceb4ca9b19914be13f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_9e22e2fafb964dceb4ca9b19914be13f()
        {
          this.Initialize("get_text", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).text;
        }
      }

      private sealed class MTHD_62f568e1fbda4e7e9569be44df673b33 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_62f568e1fbda4e7e9569be44df673b33()
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

      private sealed class MTHD_2a9bb8b42a6e4e4fa58df54372f13153 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2a9bb8b42a6e4e4fa58df54372f13153()
        {
          this.Initialize("get_textColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor;
        }
      }

      private sealed class MTHD_65b8a4cacc1e44aa94510323d5f478be : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65b8a4cacc1e44aa94510323d5f478be()
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

      private sealed class MTHD_682f1cbc16a44843812825b62e8c003b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_682f1cbc16a44843812825b62e8c003b()
        {
          this.Initialize("get_textColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textColor2;
        }
      }

      private sealed class MTHD_afa41daf941646a89a6bf0cf14678c85 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_afa41daf941646a89a6bf0cf14678c85()
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

      private sealed class MTHD_72cf9f91995f424e8d041b9e8fd30af2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_72cf9f91995f424e8d041b9e8fd30af2()
        {
          this.Initialize("get_highlightColor", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor;
        }
      }

      private sealed class MTHD_bbc5ee6b17254850974a166fc780e1a8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bbc5ee6b17254850974a166fc780e1a8()
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

      private sealed class MTHD_390ddc98db9f445b934d733f39b4c112 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_390ddc98db9f445b934d733f39b4c112()
        {
          this.Initialize("get_highlightColor2", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).highlightColor2;
        }
      }

      private sealed class MTHD_51952aa56e174b0ebcb401ac40d8d3b6 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_51952aa56e174b0ebcb401ac40d8d3b6()
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

      private sealed class MTHD_59c5497b453645f9b8127cf9844b5685 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_59c5497b453645f9b8127cf9844b5685()
        {
          this.Initialize("get_textStyle", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textStyle;
        }
      }

      private sealed class MTHD_4d9c56bb4e9a4a45bf7cbb2e065bfc8b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4d9c56bb4e9a4a45bf7cbb2e065bfc8b()
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

      private sealed class MTHD_c6aa6d96e35c49de965fb5fa2ab13abd : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c6aa6d96e35c49de965fb5fa2ab13abd()
        {
          this.Initialize("get_textSize", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((UIElement) obj).textSize;
        }
      }

      private sealed class MTHD_c404becd5e2148b9829a91185161f57a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c404becd5e2148b9829a91185161f57a()
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

      private sealed class MTHD_b49f03a5790e45b1baa07f877a4bd738 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b49f03a5790e45b1baa07f877a4bd738()
        {
          this.Initialize("activateInput", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).activateInput();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_1531ea7e363545f8b13a8b96b5887b2c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1531ea7e363545f8b13a8b96b5887b2c()
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

      private sealed class MTHD_f17d1328b44046d3b03ade542a733942 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f17d1328b44046d3b03ade542a733942()
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

      private sealed class MTHD_65b8e60fb8154cc79f09ff629fc3a66b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_65b8e60fb8154cc79f09ff629fc3a66b()
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

      private sealed class MTHD_39c4fc3df3a143ceb6957ea1f68ca1c4 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_39c4fc3df3a143ceb6957ea1f68ca1c4()
        {
          this.Initialize("destroyHierarchy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroyHierarchy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_8ef7083f286644edbeac87d7d1ee4b6a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8ef7083f286644edbeac87d7d1ee4b6a()
        {
          this.Initialize("destroy", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((UIElement) obj).destroy();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_8c4978df982846f395c1b1689b8d220f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8c4978df982846f395c1b1689b8d220f()
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

      private sealed class MTHD_7900f764c4094704984778c8f2e2c962 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7900f764c4094704984778c8f2e2c962()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_fad0e3e1a02249cebd64af4785d5a7e9 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fad0e3e1a02249cebd64af4785d5a7e9()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_05cde49daf094f6fa1202312041f53de : HardwiredMethodMemberDescriptor
      {
        internal MTHD_05cde49daf094f6fa1202312041f53de()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class PROP_8dd8bd2cecca4dc7a424f44905afd357 : HardwiredMemberDescriptor
      {
        internal PROP_8dd8bd2cecca4dc7a424f44905afd357()
          : base(typeof (bool), "isDead", false, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) ((UIElement) obj).isDead;
        }
      }

      private sealed class PROP_33ba3d696ec1411da29fe0014c7e8492 : HardwiredMemberDescriptor
      {
        internal PROP_33ba3d696ec1411da29fe0014c7e8492()
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

      private sealed class PROP_2ddbd11024a34702aa9dfb8c32e86ca4 : HardwiredMemberDescriptor
      {
        internal PROP_2ddbd11024a34702aa9dfb8c32e86ca4()
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

      private sealed class PROP_f85c19052b134b6dacb2708bba354815 : HardwiredMemberDescriptor
      {
        internal PROP_f85c19052b134b6dacb2708bba354815()
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

      private sealed class PROP_617be13878694b009938daae24b39b50 : HardwiredMemberDescriptor
      {
        internal PROP_617be13878694b009938daae24b39b50()
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

      private sealed class PROP_3e079642e21042b1a5dab3c00d42753f : HardwiredMemberDescriptor
      {
        internal PROP_3e079642e21042b1a5dab3c00d42753f()
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

      private sealed class PROP_f2b0d205859748a4a2a3826d6d678072 : HardwiredMemberDescriptor
      {
        internal PROP_f2b0d205859748a4a2a3826d6d678072()
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

      private sealed class PROP_317cc7f6c52143049d26ff833120c8f7 : HardwiredMemberDescriptor
      {
        internal PROP_317cc7f6c52143049d26ff833120c8f7()
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

      private sealed class PROP_35582b88d538461e86064a37b97631ea : HardwiredMemberDescriptor
      {
        internal PROP_35582b88d538461e86064a37b97631ea()
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

      private sealed class PROP_aa094db2a0da48c9b073303e37f7dade : HardwiredMemberDescriptor
      {
        internal PROP_aa094db2a0da48c9b073303e37f7dade()
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

      private sealed class PROP_286906ede421454c832511d87030910e : HardwiredMemberDescriptor
      {
        internal PROP_286906ede421454c832511d87030910e()
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

      private sealed class PROP_a8d33072f17f4300b7df778a5e5539b6 : HardwiredMemberDescriptor
      {
        internal PROP_a8d33072f17f4300b7df778a5e5539b6()
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

      private sealed class PROP_17797007a47c4155bb595da3641b13a2 : HardwiredMemberDescriptor
      {
        internal PROP_17797007a47c4155bb595da3641b13a2()
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

      private sealed class PROP_978ac21d14cf4d4c85607ca5e76e220e : HardwiredMemberDescriptor
      {
        internal PROP_978ac21d14cf4d4c85607ca5e76e220e()
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

      private sealed class PROP_9983cc590c354b7b9bbb0292393aec71 : HardwiredMemberDescriptor
      {
        internal PROP_9983cc590c354b7b9bbb0292393aec71()
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

      private sealed class PROP_1080f4bf5bd148c491adbf6bd30e0a08 : HardwiredMemberDescriptor
      {
        internal PROP_1080f4bf5bd148c491adbf6bd30e0a08()
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

      private sealed class PROP_00e25925f6ba400e9c25cabd2ac53cb3 : HardwiredMemberDescriptor
      {
        internal PROP_00e25925f6ba400e9c25cabd2ac53cb3()
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

      private sealed class PROP_645e8cf5c7ca4f3eae5c643eb14d4845 : HardwiredMemberDescriptor
      {
        internal PROP_645e8cf5c7ca4f3eae5c643eb14d4845()
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

      private sealed class PROP_9e1f3a88c34d433fb243803276011bb6 : HardwiredMemberDescriptor
      {
        internal PROP_9e1f3a88c34d433fb243803276011bb6()
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

      private sealed class PROP_cb3561088e104a2f8bf4e986df21767a : HardwiredMemberDescriptor
      {
        internal PROP_cb3561088e104a2f8bf4e986df21767a()
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

      private sealed class PROP_baca38857b1640639b323b8c2c7b888e : HardwiredMemberDescriptor
      {
        internal PROP_baca38857b1640639b323b8c2c7b888e()
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

      private sealed class PROP_bce8e5531160445493ca62693ec4e4b7 : HardwiredMemberDescriptor
      {
        internal PROP_bce8e5531160445493ca62693ec4e4b7()
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

      private sealed class PROP_b7ea4df009224d58af658da4e36e2e95 : HardwiredMemberDescriptor
      {
        internal PROP_b7ea4df009224d58af658da4e36e2e95()
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

      private sealed class PROP_67e6801fe5954ae0a39479760f141132 : HardwiredMemberDescriptor
      {
        internal PROP_67e6801fe5954ae0a39479760f141132()
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

      private sealed class PROP_c663703574bd4ea6ae7b9abe5ea7ce5c : HardwiredMemberDescriptor
      {
        internal PROP_c663703574bd4ea6ae7b9abe5ea7ce5c()
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

      private sealed class FLDV_f923dd87ce324115a0421745449a1c3e : HardwiredMemberDescriptor
      {
        internal FLDV_f923dd87ce324115a0421745449a1c3e()
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

      private sealed class FLDV_684cd30941fd42e1b329dba139b15a61 : HardwiredMemberDescriptor
      {
        internal FLDV_684cd30941fd42e1b329dba139b15a61()
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

      private sealed class FLDV_ef02760c5a1740f0a53ea9cb23d48dc2 : HardwiredMemberDescriptor
      {
        internal FLDV_ef02760c5a1740f0a53ea9cb23d48dc2()
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

    private sealed class TYPE_af9c7b103ddd4d81bc31553df9aa367e : HardwiredUserDataDescriptor
    {
      internal TYPE_af9c7b103ddd4d81bc31553df9aa367e()
        : base(typeof (MyPoll.Item))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_af9c7b103ddd4d81bc31553df9aa367e.MTHD_450e4a11de8a4104b1d95d30b715b0cf()
        }));
        this.AddMember("addAnswer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addAnswer", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_af9c7b103ddd4d81bc31553df9aa367e.MTHD_e09f187a89e04bfe94cad08bb5afb4a0()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_af9c7b103ddd4d81bc31553df9aa367e.MTHD_b30e270b96404e3c832bda582f727d35()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_af9c7b103ddd4d81bc31553df9aa367e.MTHD_79807fa556c543408a3a59781884078c()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_af9c7b103ddd4d81bc31553df9aa367e.MTHD_b825df6a1e3a4f7782361f4ad9b19fa7()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Item), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_af9c7b103ddd4d81bc31553df9aa367e.MTHD_dbf21b33dc88475fa8a4b43079ac4e52()
        }));
        this.AddMember("question", (IMemberDescriptor) new Bridge.TYPE_af9c7b103ddd4d81bc31553df9aa367e.FLDV_f70dc5824bec4c05ace70aee5066dfa7());
        this.AddMember("multipleSelection", (IMemberDescriptor) new Bridge.TYPE_af9c7b103ddd4d81bc31553df9aa367e.FLDV_99242a6d659e417f89f1b931236a555b());
        this.AddMember("requiresAnswer", (IMemberDescriptor) new Bridge.TYPE_af9c7b103ddd4d81bc31553df9aa367e.FLDV_5a1cd3e50a9d48fabefa59426ef7d069());
        this.AddMember("answers", (IMemberDescriptor) new Bridge.TYPE_af9c7b103ddd4d81bc31553df9aa367e.FLDV_54fffa9f011b40bebe2cb11072b88096());
      }

      private sealed class MTHD_450e4a11de8a4104b1d95d30b715b0cf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_450e4a11de8a4104b1d95d30b715b0cf()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Item();
        }
      }

      private sealed class MTHD_e09f187a89e04bfe94cad08bb5afb4a0 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e09f187a89e04bfe94cad08bb5afb4a0()
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

      private sealed class MTHD_b30e270b96404e3c832bda582f727d35 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b30e270b96404e3c832bda582f727d35()
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

      private sealed class MTHD_79807fa556c543408a3a59781884078c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_79807fa556c543408a3a59781884078c()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_b825df6a1e3a4f7782361f4ad9b19fa7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b825df6a1e3a4f7782361f4ad9b19fa7()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_dbf21b33dc88475fa8a4b43079ac4e52 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_dbf21b33dc88475fa8a4b43079ac4e52()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_f70dc5824bec4c05ace70aee5066dfa7 : HardwiredMemberDescriptor
      {
        internal FLDV_f70dc5824bec4c05ace70aee5066dfa7()
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

      private sealed class FLDV_99242a6d659e417f89f1b931236a555b : HardwiredMemberDescriptor
      {
        internal FLDV_99242a6d659e417f89f1b931236a555b()
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

      private sealed class FLDV_5a1cd3e50a9d48fabefa59426ef7d069 : HardwiredMemberDescriptor
      {
        internal FLDV_5a1cd3e50a9d48fabefa59426ef7d069()
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

      private sealed class FLDV_54fffa9f011b40bebe2cb11072b88096 : HardwiredMemberDescriptor
      {
        internal FLDV_54fffa9f011b40bebe2cb11072b88096()
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

    private sealed class TYPE_bf829182a9cf485cbabae631e7ae1bb4 : HardwiredUserDataDescriptor
    {
      internal TYPE_bf829182a9cf485cbabae631e7ae1bb4()
        : base(typeof (MyPoll.Answer))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bf829182a9cf485cbabae631e7ae1bb4.MTHD_2989c03bd9ec4a89a7e25701b8ae561d()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bf829182a9cf485cbabae631e7ae1bb4.MTHD_2d9a7b9cc3a24d5880fd8559f03762ea()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bf829182a9cf485cbabae631e7ae1bb4.MTHD_1f43c8c6abee47e199b83d4a890e166c()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bf829182a9cf485cbabae631e7ae1bb4.MTHD_fbd5fb3e60c34ee6af30ecd6c9528343()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll.Answer), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_bf829182a9cf485cbabae631e7ae1bb4.MTHD_8b5d394d92c04180807b68a3f4b4c2fe()
        }));
        this.AddMember("text", (IMemberDescriptor) new Bridge.TYPE_bf829182a9cf485cbabae631e7ae1bb4.FLDV_a529ab24f6d04f778e49dba4b0e88c3b());
        this.AddMember("allowUserInput", (IMemberDescriptor) new Bridge.TYPE_bf829182a9cf485cbabae631e7ae1bb4.FLDV_25727cdc588c4cfe946b3b52e07b0f4d());
        this.AddMember("checkable", (IMemberDescriptor) new Bridge.TYPE_bf829182a9cf485cbabae631e7ae1bb4.FLDV_3cf02cd646874a12b099e35c4a9cf01d());
        this.AddMember("userInput", (IMemberDescriptor) new Bridge.TYPE_bf829182a9cf485cbabae631e7ae1bb4.FLDV_5138726b2dee43b3ab1a376d72d2586a());
        this.AddMember("isChecked", (IMemberDescriptor) new Bridge.TYPE_bf829182a9cf485cbabae631e7ae1bb4.FLDV_a641ba79e9e64277b41498dc381a8a49());
      }

      private sealed class MTHD_2989c03bd9ec4a89a7e25701b8ae561d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2989c03bd9ec4a89a7e25701b8ae561d()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll.Answer();
        }
      }

      private sealed class MTHD_2d9a7b9cc3a24d5880fd8559f03762ea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_2d9a7b9cc3a24d5880fd8559f03762ea()
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

      private sealed class MTHD_1f43c8c6abee47e199b83d4a890e166c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_1f43c8c6abee47e199b83d4a890e166c()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_fbd5fb3e60c34ee6af30ecd6c9528343 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_fbd5fb3e60c34ee6af30ecd6c9528343()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_8b5d394d92c04180807b68a3f4b4c2fe : HardwiredMethodMemberDescriptor
      {
        internal MTHD_8b5d394d92c04180807b68a3f4b4c2fe()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_a529ab24f6d04f778e49dba4b0e88c3b : HardwiredMemberDescriptor
      {
        internal FLDV_a529ab24f6d04f778e49dba4b0e88c3b()
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

      private sealed class FLDV_25727cdc588c4cfe946b3b52e07b0f4d : HardwiredMemberDescriptor
      {
        internal FLDV_25727cdc588c4cfe946b3b52e07b0f4d()
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

      private sealed class FLDV_3cf02cd646874a12b099e35c4a9cf01d : HardwiredMemberDescriptor
      {
        internal FLDV_3cf02cd646874a12b099e35c4a9cf01d()
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

      private sealed class FLDV_5138726b2dee43b3ab1a376d72d2586a : HardwiredMemberDescriptor
      {
        internal FLDV_5138726b2dee43b3ab1a376d72d2586a()
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

      private sealed class FLDV_a641ba79e9e64277b41498dc381a8a49 : HardwiredMemberDescriptor
      {
        internal FLDV_a641ba79e9e64277b41498dc381a8a49()
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

    private sealed class TYPE_080d490a1b32483e90d0cfed6d331c3c : HardwiredUserDataDescriptor
    {
      internal TYPE_080d490a1b32483e90d0cfed6d331c3c()
        : base(typeof (MyPoll))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_080d490a1b32483e90d0cfed6d331c3c.MTHD_f1d03b9c59df45db8c8c9557972beb2a()
        }));
        this.AddMember("GetQuestionsAsString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetQuestionsAsString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_080d490a1b32483e90d0cfed6d331c3c.MTHD_d801771b5fd4402f8ced3dd6a14eaddf()
        }));
        this.AddMember("SanitizeResponses", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("SanitizeResponses", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_080d490a1b32483e90d0cfed6d331c3c.MTHD_f7b6ed90ba5744ef8fe4f877c4bc9dea()
        }));
        this.AddMember("addItem", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("addItem", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_080d490a1b32483e90d0cfed6d331c3c.MTHD_415a2abaa4974c309bc1c66a26866c81()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_080d490a1b32483e90d0cfed6d331c3c.MTHD_c468a593d6144e98b00a6dcfe7ab2201()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_080d490a1b32483e90d0cfed6d331c3c.MTHD_a8e36a304a644e28b152840489bbccd3()
        }));
        this.AddMember("fromString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("fromString", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_080d490a1b32483e90d0cfed6d331c3c.MTHD_0336cb5cab9446cdbe795876a07d0931()
        }));
        this.AddMember("sendToServer", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("sendToServer", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_080d490a1b32483e90d0cfed6d331c3c.MTHD_b1d840fdd9444f5ca3a594ec349f08ba()
        }));
        this.AddMember("closePoll", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("closePoll", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_080d490a1b32483e90d0cfed6d331c3c.MTHD_5c2449c7955a4c629459ea1e889ada52()
        }));
        this.AddMember("test", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("test", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_080d490a1b32483e90d0cfed6d331c3c.MTHD_4784981ff54c44b5a76f7702ee16b20e()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_080d490a1b32483e90d0cfed6d331c3c.MTHD_e97545d35d32493f911fe05ba2a0062b()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_080d490a1b32483e90d0cfed6d331c3c.MTHD_bf8993d3e2754462a51b4c7ae58442b2()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (MyPoll), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_080d490a1b32483e90d0cfed6d331c3c.MTHD_34986e09a3914af994d686c54bda378f()
        }));
        this.AddMember("name", (IMemberDescriptor) new Bridge.TYPE_080d490a1b32483e90d0cfed6d331c3c.FLDV_f1097f3e81d049058aa9c37beb4cc547());
        this.AddMember("id", (IMemberDescriptor) new Bridge.TYPE_080d490a1b32483e90d0cfed6d331c3c.FLDV_4820914b6ee0426a862bab1f48398020());
        this.AddMember("items", (IMemberDescriptor) new Bridge.TYPE_080d490a1b32483e90d0cfed6d331c3c.FLDV_1d3fa900cf0e4164b044e176f62048a5());
        this.AddMember("isPublic", (IMemberDescriptor) new Bridge.TYPE_080d490a1b32483e90d0cfed6d331c3c.FLDV_23c6095d905b4667a227e1c783684e13());
        this.AddMember("MsgRetrieve", (IMemberDescriptor) new Bridge.TYPE_080d490a1b32483e90d0cfed6d331c3c.FLDV_305548ebe62d46dca043f5dfaa197f8f());
        this.AddMember("MsgSubmit", (IMemberDescriptor) new Bridge.TYPE_080d490a1b32483e90d0cfed6d331c3c.FLDV_f2d70ed435b347d5ad22f792db12a1ac());
        this.AddMember("MsgCreate", (IMemberDescriptor) new Bridge.TYPE_080d490a1b32483e90d0cfed6d331c3c.FLDV_2bc7fc63145d4d52b625ea2df370b0ba());
        this.AddMember("MsgResults", (IMemberDescriptor) new Bridge.TYPE_080d490a1b32483e90d0cfed6d331c3c.FLDV_c024ac426be34f0c9698842f640d4f6f());
        this.AddMember("Item", (IMemberDescriptor) new Bridge.TYPE_080d490a1b32483e90d0cfed6d331c3c.DVAL_7063fcbde6374cc998edfe4288041b62());
        this.AddMember("Answer", (IMemberDescriptor) new Bridge.TYPE_080d490a1b32483e90d0cfed6d331c3c.DVAL_bb087c8cd7424019b413f8c23375d3fa());
      }

      private sealed class MTHD_f1d03b9c59df45db8c8c9557972beb2a : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f1d03b9c59df45db8c8c9557972beb2a()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new MyPoll();
        }
      }

      private sealed class MTHD_d801771b5fd4402f8ced3dd6a14eaddf : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d801771b5fd4402f8ced3dd6a14eaddf()
        {
          this.Initialize("GetQuestionsAsString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).GetQuestionsAsString();
        }
      }

      private sealed class MTHD_f7b6ed90ba5744ef8fe4f877c4bc9dea : HardwiredMethodMemberDescriptor
      {
        internal MTHD_f7b6ed90ba5744ef8fe4f877c4bc9dea()
        {
          this.Initialize("SanitizeResponses", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).SanitizeResponses();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_415a2abaa4974c309bc1c66a26866c81 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_415a2abaa4974c309bc1c66a26866c81()
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

      private sealed class MTHD_c468a593d6144e98b00a6dcfe7ab2201 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c468a593d6144e98b00a6dcfe7ab2201()
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

      private sealed class MTHD_a8e36a304a644e28b152840489bbccd3 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_a8e36a304a644e28b152840489bbccd3()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((MyPoll) obj).ToString();
        }
      }

      private sealed class MTHD_0336cb5cab9446cdbe795876a07d0931 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_0336cb5cab9446cdbe795876a07d0931()
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

      private sealed class MTHD_b1d840fdd9444f5ca3a594ec349f08ba : HardwiredMethodMemberDescriptor
      {
        internal MTHD_b1d840fdd9444f5ca3a594ec349f08ba()
        {
          this.Initialize("sendToServer", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).sendToServer();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_5c2449c7955a4c629459ea1e889ada52 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5c2449c7955a4c629459ea1e889ada52()
        {
          this.Initialize("closePoll", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          MyPoll.closePoll();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_4784981ff54c44b5a76f7702ee16b20e : HardwiredMethodMemberDescriptor
      {
        internal MTHD_4784981ff54c44b5a76f7702ee16b20e()
        {
          this.Initialize("test", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          ((MyPoll) obj).test();
          return (object) DynValue.Void;
        }
      }

      private sealed class MTHD_e97545d35d32493f911fe05ba2a0062b : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e97545d35d32493f911fe05ba2a0062b()
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

      private sealed class MTHD_bf8993d3e2754462a51b4c7ae58442b2 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_bf8993d3e2754462a51b4c7ae58442b2()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_34986e09a3914af994d686c54bda378f : HardwiredMethodMemberDescriptor
      {
        internal MTHD_34986e09a3914af994d686c54bda378f()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class FLDV_f1097f3e81d049058aa9c37beb4cc547 : HardwiredMemberDescriptor
      {
        internal FLDV_f1097f3e81d049058aa9c37beb4cc547()
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

      private sealed class FLDV_4820914b6ee0426a862bab1f48398020 : HardwiredMemberDescriptor
      {
        internal FLDV_4820914b6ee0426a862bab1f48398020()
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

      private sealed class FLDV_1d3fa900cf0e4164b044e176f62048a5 : HardwiredMemberDescriptor
      {
        internal FLDV_1d3fa900cf0e4164b044e176f62048a5()
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

      private sealed class FLDV_23c6095d905b4667a227e1c783684e13 : HardwiredMemberDescriptor
      {
        internal FLDV_23c6095d905b4667a227e1c783684e13()
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

      private sealed class FLDV_305548ebe62d46dca043f5dfaa197f8f : HardwiredMemberDescriptor
      {
        internal FLDV_305548ebe62d46dca043f5dfaa197f8f()
          : base(typeof (byte), "MsgRetrieve", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 1;
        }
      }

      private sealed class FLDV_f2d70ed435b347d5ad22f792db12a1ac : HardwiredMemberDescriptor
      {
        internal FLDV_f2d70ed435b347d5ad22f792db12a1ac()
          : base(typeof (byte), "MsgSubmit", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 2;
        }
      }

      private sealed class FLDV_2bc7fc63145d4d52b625ea2df370b0ba : HardwiredMemberDescriptor
      {
        internal FLDV_2bc7fc63145d4d52b625ea2df370b0ba()
          : base(typeof (byte), "MsgCreate", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 3;
        }
      }

      private sealed class FLDV_c024ac426be34f0c9698842f640d4f6f : HardwiredMemberDescriptor
      {
        internal FLDV_c024ac426be34f0c9698842f640d4f6f()
          : base(typeof (byte), "MsgResults", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) (byte) 4;
        }
      }

      private sealed class DVAL_7063fcbde6374cc998edfe4288041b62 : DynValueMemberDescriptor
      {
        internal DVAL_7063fcbde6374cc998edfe4288041b62()
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

      private sealed class DVAL_bb087c8cd7424019b413f8c23375d3fa : DynValueMemberDescriptor
      {
        internal DVAL_bb087c8cd7424019b413f8c23375d3fa()
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

    private sealed class TYPE_50086df340e24791ae600f782d2189d3 : HardwiredUserDataDescriptor
    {
      internal TYPE_50086df340e24791ae600f782d2189d3()
        : base(typeof (LuaColor))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50086df340e24791ae600f782d2189d3.MTHD_35444971ace942d482075dfded106143()
        }));
        this.AddMember("toHex", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("toHex", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50086df340e24791ae600f782d2189d3.MTHD_93d5757b96074d9dbfd9e60eb0bb5ac7()
        }));
        this.AddMember("construct", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("construct", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50086df340e24791ae600f782d2189d3.MTHD_6609d56cfc0c4b8ca4680d7e3469fe14(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50086df340e24791ae600f782d2189d3.MTHD_c4c6f066a92e4787af69626bb9cba458()
        }));
        this.AddMember("From", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("From", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[2]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50086df340e24791ae600f782d2189d3.MTHD_c2d5a722a4254e65afde13b9872e4b87(),
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50086df340e24791ae600f782d2189d3.MTHD_58605bab5afe458187b45cd62c1155e5()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50086df340e24791ae600f782d2189d3.MTHD_d4107f4eece04775a5c9a950e5cacd82()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50086df340e24791ae600f782d2189d3.MTHD_3527fe357c8d4bc6acc4087ba383f73d()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50086df340e24791ae600f782d2189d3.MTHD_e960e797eb574476a6c95c457b882da8()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (LuaColor), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_50086df340e24791ae600f782d2189d3.MTHD_ffee8545b8d44c889eb834ad0b0a0434()
        }));
        this.AddMember("r", (IMemberDescriptor) new Bridge.TYPE_50086df340e24791ae600f782d2189d3.FLDV_c63c23b7dcbb4e868eb3d2a2a69cdbb5());
        this.AddMember("g", (IMemberDescriptor) new Bridge.TYPE_50086df340e24791ae600f782d2189d3.FLDV_b4dcd6e4b680491f933a67d31c4fd8f0());
        this.AddMember("b", (IMemberDescriptor) new Bridge.TYPE_50086df340e24791ae600f782d2189d3.FLDV_0cddd3d5421143e897a8110667b502bf());
        this.AddMember("a", (IMemberDescriptor) new Bridge.TYPE_50086df340e24791ae600f782d2189d3.FLDV_73b2b3f113e74f8dad0116049286f9a1());
        this.AddMember("white", (IMemberDescriptor) new Bridge.TYPE_50086df340e24791ae600f782d2189d3.FLDV_cdfcf5ec4eab449484512524b7a59734());
      }

      private sealed class MTHD_35444971ace942d482075dfded106143 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_35444971ace942d482075dfded106143()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new LuaColor();
        }
      }

      private sealed class MTHD_93d5757b96074d9dbfd9e60eb0bb5ac7 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_93d5757b96074d9dbfd9e60eb0bb5ac7()
        {
          this.Initialize("toHex", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) ((LuaColor) obj).toHex();
        }
      }

      private sealed class MTHD_6609d56cfc0c4b8ca4680d7e3469fe14 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6609d56cfc0c4b8ca4680d7e3469fe14()
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

      private sealed class MTHD_c4c6f066a92e4787af69626bb9cba458 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c4c6f066a92e4787af69626bb9cba458()
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

      private sealed class MTHD_c2d5a722a4254e65afde13b9872e4b87 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_c2d5a722a4254e65afde13b9872e4b87()
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

      private sealed class MTHD_58605bab5afe458187b45cd62c1155e5 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_58605bab5afe458187b45cd62c1155e5()
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

      private sealed class MTHD_d4107f4eece04775a5c9a950e5cacd82 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_d4107f4eece04775a5c9a950e5cacd82()
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

      private sealed class MTHD_3527fe357c8d4bc6acc4087ba383f73d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_3527fe357c8d4bc6acc4087ba383f73d()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_e960e797eb574476a6c95c457b882da8 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_e960e797eb574476a6c95c457b882da8()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_ffee8545b8d44c889eb834ad0b0a0434 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ffee8545b8d44c889eb834ad0b0a0434()
        {
          this.Initialize("ToString", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.ToString();
        }
      }

      private sealed class FLDV_c63c23b7dcbb4e868eb3d2a2a69cdbb5 : HardwiredMemberDescriptor
      {
        internal FLDV_c63c23b7dcbb4e868eb3d2a2a69cdbb5()
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

      private sealed class FLDV_b4dcd6e4b680491f933a67d31c4fd8f0 : HardwiredMemberDescriptor
      {
        internal FLDV_b4dcd6e4b680491f933a67d31c4fd8f0()
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

      private sealed class FLDV_0cddd3d5421143e897a8110667b502bf : HardwiredMemberDescriptor
      {
        internal FLDV_0cddd3d5421143e897a8110667b502bf()
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

      private sealed class FLDV_73b2b3f113e74f8dad0116049286f9a1 : HardwiredMemberDescriptor
      {
        internal FLDV_73b2b3f113e74f8dad0116049286f9a1()
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

      private sealed class FLDV_cdfcf5ec4eab449484512524b7a59734 : HardwiredMemberDescriptor
      {
        internal FLDV_cdfcf5ec4eab449484512524b7a59734()
          : base(typeof (LuaColor), "white", true, MemberDescriptorAccess.CanRead)
        {
        }

        protected override object GetValueImpl(Script script, object obj)
        {
          return (object) LuaColor.white;
        }
      }
    }

    private sealed class TYPE_d31ed4f9de904dafb4dbf9ec05553fae : HardwiredUserDataDescriptor
    {
      internal TYPE_d31ed4f9de904dafb4dbf9ec05553fae()
        : base(typeof (TalkOptions))
      {
        this.AddMember("__new", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("__new", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d31ed4f9de904dafb4dbf9ec05553fae.MTHD_ced28438327246808a58fd77439b0e3d()
        }));
        this.AddMember("Equals", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("Equals", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d31ed4f9de904dafb4dbf9ec05553fae.MTHD_5f738e9aac714d93a88a87ba2df5f613()
        }));
        this.AddMember("GetHashCode", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetHashCode", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d31ed4f9de904dafb4dbf9ec05553fae.MTHD_7480e19176e24414abe9e7beadcce595()
        }));
        this.AddMember("GetType", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("GetType", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d31ed4f9de904dafb4dbf9ec05553fae.MTHD_55499e85b03148c79e9d1d32b2615380()
        }));
        this.AddMember("ToString", (IMemberDescriptor) new OverloadedMethodMemberDescriptor("ToString", typeof (TalkOptions), (IEnumerable<IOverloadableMemberDescriptor>) new IOverloadableMemberDescriptor[1]
        {
          (IOverloadableMemberDescriptor) new Bridge.TYPE_d31ed4f9de904dafb4dbf9ec05553fae.MTHD_6b41300b599e407a9cf09773a92a492c()
        }));
      }

      private sealed class MTHD_ced28438327246808a58fd77439b0e3d : HardwiredMethodMemberDescriptor
      {
        internal MTHD_ced28438327246808a58fd77439b0e3d()
        {
          this.Initialize(".ctor", true, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) new TalkOptions();
        }
      }

      private sealed class MTHD_5f738e9aac714d93a88a87ba2df5f613 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_5f738e9aac714d93a88a87ba2df5f613()
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

      private sealed class MTHD_7480e19176e24414abe9e7beadcce595 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_7480e19176e24414abe9e7beadcce595()
        {
          this.Initialize("GetHashCode", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetHashCode();
        }
      }

      private sealed class MTHD_55499e85b03148c79e9d1d32b2615380 : HardwiredMethodMemberDescriptor
      {
        internal MTHD_55499e85b03148c79e9d1d32b2615380()
        {
          this.Initialize("GetType", false, new ParameterDescriptor[0], false);
        }

        protected override object Invoke(Script script, object obj, object[] pars, int argscount)
        {
          return (object) obj.GetType();
        }
      }

      private sealed class MTHD_6b41300b599e407a9cf09773a92a492c : HardwiredMethodMemberDescriptor
      {
        internal MTHD_6b41300b599e407a9cf09773a92a492c()
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
